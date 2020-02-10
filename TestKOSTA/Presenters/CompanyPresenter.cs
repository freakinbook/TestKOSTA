using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TestKOSTA.Model;
using TestKOSTA.Repository;
using TestKOSTA.Views;

namespace TestKOSTA
{
	/// <summary>
	/// This class is a MVP presenter for a MainForm view. All the business logic goes here. The view is linked inderectly through an interface ICompanyView.
	/// </summary>
	public class CompanyPresenter
	{
		private ICompanyView view = null;
		private ICompanyModel model = null;

		private List<Department> departments;
		private List<Empoyee> employees;

		private TreeNode company;
		
		public CompanyPresenter(ICompanyView view, ICompanyModel model)
		{
			this.view = view;
			this.model = model;
			SetStructure();
		}

		/// <summary>
		/// Initializes the tree
		/// </summary>
		public void SetStructure()
		{
			departments = model.GetDepartments();
			employees = model.GetEmployees();
			Department rootDepartment = departments.First(d => d.ParentDepartmentID == null);
			if(rootDepartment.ParentDepartmentID != null)
			{
				throw new ArgumentException("Company department not found");
			}
			company = new TreeNode(rootDepartment.Name) { Tag = rootDepartment.ID};
			Guid id = rootDepartment.ID;
			GetDepartmentStructure(company, id);
			view.ShowTreeStructure(company);
		}

		/// <summary>
		///	Recursively populates the tree from DB entries
		/// </summary>
		/// <param name="parent">The root node of tree for the first iteration</param>
		/// <param name="parentId">The Guid of a department that corresponds to the root node</param>
		private void GetDepartmentStructure(TreeNode parent, Guid parentId)
		{
			IEnumerable<Department> children = departments.Where(d => d.ParentDepartmentID == parentId);
			IEnumerable<Empoyee> employeesOfDepartment = employees.Where(e => e.DepartmentID == parentId);
			if (employeesOfDepartment != null)
			{
				foreach (var employee in employeesOfDepartment)
				{
					TreeNode employeeNode = CreateEmployeeTreeNode(employee);
					parent.Nodes.Add(employeeNode);
				}
			}
			foreach (var child in children)
			{
				TreeNode childNode = new TreeNode(child.Name);
				childNode.Tag = child.ID;
				GetDepartmentStructure(childNode, child.ID);
				parent.Nodes.Add(childNode);
			}
		}

		/// <summary>
		/// Calculates the age of an employee
		/// </summary>
		/// <param name="employee"></param>
		/// <returns>Age in years</returns>
		public int GetAge(Empoyee employee)
		{
			var today = DateTime.Today;
			var age = today.Year - employee.DateOfBirth.Year;
			if(employee.DateOfBirth.AddYears(age) > DateTime.Now)
			{
				age--;
			}
			return age;
		}

		/// <summary>
		/// Decides if selected node was an employee or a department. Views different data depending on a node.
		/// </summary>
		public void SelectionResponse(TreeNode selectedNode)
		{
			if(selectedNode.Nodes.Count == 0)
			{
				Empoyee employee = employees.First(e => e.ID == (decimal)selectedNode.Tag);
				Department dep = departments.First(d => d.ID == employee.DepartmentID);
				view.ShowDepartmentInfo(dep);
				view.ShowEmployeeInfo(employee);
			}
			else
			{
				Department dep = departments.First(d => d.ID == (Guid)selectedNode.Tag);
				view.ShowDepartmentInfo(dep);
			}
		}

		/// <summary>
		/// Opens another form to edit an employee
		/// </summary>
		/// <param name="selectedNode">The employee selected in a treeview.</param>
		public void OpenEditDialog(TreeNode selectedNode)
		{
			Empoyee employee = employees.First(e => e.ID == (decimal)selectedNode.Tag);
			AddEditPresenter editPresenter = new AddEditPresenter(this,model,ViewMode.Edit,employee);
		}

		/// <summary>
		/// Opens another form to add a new employee
		/// </summary>
		public void OpenAddDialog()
		{
			AddEditPresenter addPresenter = new AddEditPresenter(this,model, ViewMode.Add);
		}

		/// <summary>
		/// Updates the tree structure after changing employee data
		/// </summary>
		/// <param name="employee">Changed employee</param>
		public void UpdateEmployee(Empoyee employee)
		{
			TreeNode employeeNode = FromID(employee.ID, company);
			TreeNode departmentNode = employeeNode.Parent;
			employeeNode.Remove();
			TreeNode newEmployeeNode = CreateEmployeeTreeNode(employee);
			departmentNode = FromID(employee.DepartmentID, company);
			departmentNode.Nodes.Add(newEmployeeNode);
			employees = model.GetEmployees();
			departments = model.GetDepartments();
			view.ShowTreeStructure(company,newEmployeeNode);
		}

		/// <summary>
		/// Updates the tree structure after adding an employee
		/// </summary>
		/// <param name="employee">Added employee</param>
		public void CreateEmployee(Empoyee employee)
		{
			TreeNode departmentNode = FromID(employee.DepartmentID, company);
			TreeNode newEmployeeNode = CreateEmployeeTreeNode(employee);
			departmentNode.Nodes.Add(newEmployeeNode);
			employees = model.GetEmployees();
			departments = model.GetDepartments();
			view.ShowTreeStructure(company,newEmployeeNode);
		}

		/// <summary>
		/// Creates a tree node with a full firstname and initials of an employee
		/// </summary>
		/// <param name="employee">Employee for whom the treenode is created</param>
		/// <returns>The created treenode</returns>
		private static TreeNode CreateEmployeeTreeNode(Empoyee employee)
		{
			Char patronymicDot = (employee.Patronymic != null) ? '.' : ' ';
			TreeNode newEmployeeNode = new TreeNode($"{employee.SurName} {employee.FirstName.First()}.{employee.Patronymic?.First()}{patronymicDot}");
			newEmployeeNode.Tag = employee.ID;
			newEmployeeNode.ImageIndex = 1;
			newEmployeeNode.SelectedImageIndex = 1;
			return newEmployeeNode;
		}

		/// <summary>
		/// Searches the tree for a department node
		/// </summary>
		/// <param name="itemId">A department ID</param>
		/// <param name="rootNode">Node from which to search down</param>
		/// <returns>A treenode if found, null if not.</returns>
		private TreeNode FromID(Guid itemId, TreeNode rootNode)
		{
			if(rootNode.Tag is Guid)
			{
				if (((Guid)rootNode.Tag).Equals(itemId))
				{
					return rootNode;
				}
			}
			foreach (TreeNode node in rootNode.Nodes)
			{
				if(node.Tag is Guid)
				{
					if (((Guid)node.Tag).Equals(itemId))
					{
						return node;
					}
				}
				TreeNode next = FromID(itemId, node);
				if (next != null)
				{
					return next;
				}
			}
			return null;
		}

		/// <summary>
		/// Searches the tree for an employee node
		/// </summary>
		/// <param name="itemId">Employee ID</param>
		/// <param name="rootNode">Node from which to search down</param>
		/// <returns>Treenode of an employee or null if not found</returns>
		private TreeNode FromID(decimal itemId, TreeNode rootNode)
		{
			foreach (TreeNode node in rootNode.Nodes)
			{
				if (node.Tag.Equals(itemId))
				{
					return node;
				}
				TreeNode next = FromID(itemId, node);
				if (next != null)
				{
					return next;
				}
			}
			return null;
		}
	}
}
