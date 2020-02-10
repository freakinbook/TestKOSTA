using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using TestKOSTA.Model;
using TestKOSTA.Repository;

namespace TestKOSTA
{
	/// <summary>
	/// One form is used for editing and adding an employee. This enum decides when there should be different behavior.
	/// </summary>
	public enum ViewMode
	{
		Add = 0,
		Edit = 1
	}

	/// <summary>
	/// An MVP presenter for a add/edit employee view.
	/// </summary>
	public class AddEditPresenter
	{
		private IAddEditView editView;
		private ICompanyModel model;
		private List<Department> departments;
		private List<Empoyee> employees;
		private Empoyee editedEmployee;
		private Guid originalDepartment;
		private ViewMode mode;
		private CompanyPresenter parentPresenter;

		public AddEditPresenter(CompanyPresenter parent, ICompanyModel model, ViewMode mode)
		{
			this.model = model;
			departments = model.GetDepartments();
			employees = model.GetEmployees();
			this.mode = mode;
			this.parentPresenter = parent;
			this.editView = new AddEditForm(this);
			editView.LoadForm();
		}

		public AddEditPresenter(CompanyPresenter parent, ICompanyModel model, ViewMode mode, Empoyee employee)
		{
			this.model = model;
			departments = model.GetDepartments();
			employees = model.GetEmployees();
			this.editedEmployee = employee;
			this.originalDepartment = employee.DepartmentID;
			this.mode = mode;
			this.parentPresenter = parent;
			this.editView = new AddEditForm(this);
			editView.LoadForm(editedEmployee);
		}

		/// <summary>
		/// Gets the list of names of departments to show in a combobox 
		/// </summary>
		/// <returns>A list of names</returns>
		public List<string> GetDepartmentNames()
		{
			List<string> names = new List<string>();
			foreach (Department d in departments)
			{
				names.Add(d.Name);
			}
			return names;
		}

		/// <summary>
		/// Checks if inputs in a view are valid
		/// </summary>
		/// <param name="name">A name of an employee</param>
		/// <param name="surname">A surname of an employee</param>
		/// <param name="position">A position of an employee</param>
		/// <param name="date">A birthdate of an employee</param>
		/// <param name="department">A department of an employee</param>
		/// <returns>True if all entries are valid. False if at least one is invalid.</returns>
		public bool ValidateEntries(string name, string surname,string position, string date, string department)
		{
			if(name == null || name == "")
			{
				editView.ErrorMessage("An employee must have a first name");
				return false;
			}
			if (surname == null || surname == "")
			{
				editView.ErrorMessage("An employee must have a surname");
				return false;
			}
			if (position == null || position == "")
			{
				editView.ErrorMessage("An employee must have a position");
				return false;
			}
			DateTime birthDate;
			if(!DateTime.TryParse(date, out birthDate))
			{
				editView.ErrorMessage("Birth date is invalid. Please try again");
				return false;
			}
			if (birthDate < (DateTime)SqlDateTime.MinValue)
			{
				editView.ErrorMessage("Nobody lives that long. Please enter a valid birthdate");
				return false;
			}
			if(department == "")
			{
				editView.ErrorMessage("Please choose the department");
				return false;
			}
			return true;
		}

		/// <summary>
		/// Returns an employee's department by its name from combobox
		/// </summary>
		/// <param name="departmentName"></param>
		/// <returns></returns>
		public Department GetEmployeeDepartment(string departmentName)
		{
			//this assumes that department names never repeat
			//potential bug
			//probably shoud have used combobox tags like I did in a tree
			Department result = departments.First(d => d.Name == departmentName);
			return result;
		}

		/// <summary>
		/// Returns an employee's department
		/// </summary>
		/// <param name="employee"></param>
		/// <returns></returns>
		public Department GetEmployeeDepartment(Empoyee employee)
		{
			Department result = departments.First(d => d.ID == employee.DepartmentID);
			return result;
		}

		/// <summary>
		/// For edited employee leave ID as it was. For a created employee create a new ID
		/// </summary>
		/// <returns></returns>
		public decimal GetEmployeeID()
		{
			if (mode == ViewMode.Add)
			{
				decimal result = employees.Max(e => e.ID);
				return ++result;
			} else
			{
				return editedEmployee.ID;
			}
		}

		/// <summary>
		/// Saves employee in a model
		/// </summary>
		/// <param name="employee"></param>
		public void SetEmployee(Empoyee employee)
		{
			if (mode == ViewMode.Add)
			{
				model.AddEmployee(employee);
				parentPresenter.CreateEmployee(employee);
				return;
			}
			if (mode == ViewMode.Edit)
			{
				model.EditEmployee(employee);
				parentPresenter.UpdateEmployee(employee);
				return;
			}
			
		}
	}
}
