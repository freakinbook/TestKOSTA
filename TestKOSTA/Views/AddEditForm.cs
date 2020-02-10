using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestKOSTA.Repository;

namespace TestKOSTA
{
	interface IAddEditView
	{
		void LoadForm();
		void LoadForm(Empoyee employee);
		void ErrorMessage(string error);
	}

	public partial class AddEditForm : Form, IAddEditView
	{
		private AddEditPresenter presenter;
		
		public AddEditForm(AddEditPresenter presenter)
		{
			this.presenter = presenter;
			InitializeComponent();
			this.departmentCombobox.Items.AddRange(presenter.GetDepartmentNames().ToArray());
			this.departmentCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
		}

		/// <summary>
		/// Shows the view for creating a new employee
		/// </summary>
		public void LoadForm()
		{
			this.ShowDialog();
		}

		/// <summary>
		/// Shows the view for editing the existing employee. Sets the textboxes with employee data
		/// </summary>
		/// <param name="employee"></param>
		public void LoadForm(Empoyee employee)
		{
			this.firstNameTextBox.Text = employee.FirstName;
			this.surNameTextBox.Text = employee.SurName;
			this.patronymicTextBox.Text = employee.Patronymic;
			this.positionTextBox.Text = employee.Position;
			this.dateTextBox.Text = employee.DateOfBirth.ToShortDateString();
			this.docSeriesTextBox.Text = employee.DocSeries;
			this.docNumberTextBox.Text = employee.DocNumber;
			this.departmentCombobox.SelectedIndex = departmentCombobox.FindStringExact(presenter.GetEmployeeDepartment(employee).Name);
			this.ShowDialog();
		}


		private void discardButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void ackButton_Click(object sender, EventArgs e)
		{
			if (presenter.ValidateEntries(firstNameTextBox.Text,surNameTextBox.Text, positionTextBox.Text,dateTextBox.Text,departmentCombobox.Text))
			{
				Empoyee employee = new Empoyee();
				employee.FirstName = firstNameTextBox.Text;
				employee.SurName = surNameTextBox.Text;
				employee.Patronymic = patronymicTextBox.Text == "" ? null : patronymicTextBox.Text;
				employee.Position = positionTextBox.Text;
				employee.DateOfBirth = DateTime.Parse(dateTextBox.Text);
				employee.ID = presenter.GetEmployeeID();
				employee.DocSeries = docSeriesTextBox.Text;
				employee.DocNumber = docNumberTextBox.Text;
				employee.Department = presenter.GetEmployeeDepartment(departmentCombobox.Text);
				employee.DepartmentID = employee.Department.ID;
				presenter.SetEmployee(employee);
				this.Close();
			}
		}

		/// <summary>
		/// Shows the messagebox with a message
		/// </summary>
		/// <param name="error"></param>
		public void ErrorMessage(string error)
		{
			MessageBox.Show(error);
		}

		
	}
}
