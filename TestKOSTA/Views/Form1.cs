using System;
using System.Windows.Forms;
using TestKOSTA.Model;
using TestKOSTA.Repository;
using TestKOSTA.Views;

namespace TestKOSTA
{
	/// <summary>
	/// This class is an MVP view. It implements ICompanyView interface.
	/// </summary>
	public partial class MainForm : Form, ICompanyView
	{
		CompanyPresenter presenter;

		public MainForm()
		{
			InitializeComponent();
			presenter = new CompanyPresenter(this, new CompanyModel());
		}

		/// <summary>
		/// Updates the labels on the form to show department data
		/// </summary>
		/// <param name="dept">The department for which the data should be shown</param>
		public void ShowDepartmentInfo(Department dept)
		{
			deptNameLabel.Text = dept.Name;
			deptIdLabel.Text = dept.ID.ToString();
			mnemoLabel.Text = dept.Code;
			// not showing all the labels bound to employee
			ClearEmployeeLabels();
			ToggleEmployeeLabels(false);
			editButton.Enabled = false;
		}

		/// <summary>
		/// Updates the labels on the form to show employee data
		/// </summary>
		/// <param name="emp">The employee for which the data should be shown</param>
		public void ShowEmployeeInfo(Empoyee emp)
		{
			editButton.Enabled = true;
			ToggleEmployeeLabels(true);
			surnameLabel.Text = emp.SurName;
			nameLabel.Text = emp.FirstName;
			patronymicLabel.Text = emp.Patronymic;
			employeeIdLabel.Text = emp.ID.ToString();
			positionLabel.Text = emp.Position;
			birthLabel.Text = emp.DateOfBirth.ToShortDateString() + $" ({presenter.GetAge(emp)})";
			docSeriesLabel.Text = emp.DocSeries;
			docNumLabel.Text = emp.DocNumber;
		}

		/// <summary>
		/// Shows the labels corresponding to employee data
		/// </summary>
		/// <param name="on"><see langword="true"/> for on, <see langword="false"/> for off</param>
		private void ToggleEmployeeLabels(bool on)
		{
			label3.Visible = on;
			label4.Visible = on;
			label5.Visible = on;
			label6.Visible = on;
			label7.Visible = on;
			label8.Visible = on;
			label9.Visible = on;
			label10.Visible = on;
		}

		/// <summary>
		/// Clear the labels corresponding to employee data
		/// </summary>
		private void ClearEmployeeLabels()
		{
			surnameLabel.Text = "";
			nameLabel.Text = "";
			patronymicLabel.Text = "";
			employeeIdLabel.Text = "";
			positionLabel.Text = "";
			birthLabel.Text = "";
			docSeriesLabel.Text = "";
			docNumLabel.Text = "";
			docSeriesLabel.Text = "";
			docNumLabel.Text = "";
		}

		/// <summary>
		/// Puts the root node with its child structure into a treeview
		/// </summary>
		/// <param name="root"></param>
		public void ShowTreeStructure(TreeNode root)
		{
			treeView1.ImageList = imageList1;
			treeView1.Nodes.Clear();
			treeView1.Nodes.Add(root);
			this.ActiveControl = treeView1;
		}

		public void ShowTreeStructure(TreeNode root,TreeNode selectedNode)
		{
			ShowTreeStructure(root);
			treeView1.SelectedNode = selectedNode;
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			TreeNode node = ((TreeView)sender).SelectedNode;
			presenter.SelectionResponse(node);
		}

		private void editButton_Click(object sender, EventArgs e)
		{
			TreeNode node = treeView1.SelectedNode;
			presenter.OpenEditDialog(node);
		}

		private void addEmpButton_Click(object sender, EventArgs e)
		{
			presenter.OpenAddDialog();
		}

		private void treeView1_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
		{
			TreeNode node = ((TreeView)sender).SelectedNode;
			if (!node.IsVisible)
			{
				node = node.Parent;
			}
			presenter.SelectionResponse(node);
		}


	}
}
