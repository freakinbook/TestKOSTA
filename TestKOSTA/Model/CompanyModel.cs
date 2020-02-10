using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestKOSTA.Repository;

namespace TestKOSTA.Model
{
	public interface ICompanyModel
	{
		List<Empoyee> GetEmployees();
		List<Department> GetDepartments();
		void AddEmployee(Empoyee employee);
		void EditEmployee(Empoyee employee);
	}

	/// <summary>
	/// Represents the MVP model. Holds the data
	/// </summary>
	class CompanyModel : ICompanyModel
	{

		/// <summary>
		/// Returns a list of departments in a database
		/// </summary>
		/// <returns></returns>
		public List<Department> GetDepartments()
		{
			IEnumerable<Department> departments;
			using (TestDBEntities entities = new TestDBEntities())
			{
				departments = entities.Department;
				foreach(var d in departments)
				{
					Console.WriteLine($"{d.Name} {d.ID} {d.ParentDepartmentID}");
				}
				return departments.ToList();
			}
		}

		/// <summary>
		/// Returns a list of employees in a database
		/// </summary>
		/// <returns></returns>
		public List<Empoyee> GetEmployees()
		{
			IEnumerable<Empoyee> employees;
			using(TestDBEntities entities = new TestDBEntities())
			{
				employees = entities.Empoyee;
				return employees.ToList();
			}
		}

		/// <summary>
		/// Adds a new employee to the database
		/// </summary>
		/// <param name="employee"></param>
		public void AddEmployee(Empoyee employee)
		{
			using(TestDBEntities entities = new TestDBEntities())
			{
				//without getting the department from database I got an error that said I tried to create another department with the same primary keyw
				var department = entities.Department.FirstOrDefault(d => d.ID == employee.DepartmentID);
				employee.Department = department;
				entities.Empoyee.Add(employee);
				entities.SaveChanges();
			}
		}

		/// <summary>
		/// Updates an employee with a new data
		/// </summary>
		/// <param name="employee"></param>
		public void EditEmployee(Empoyee employee)
		{
			using (TestDBEntities entities = new TestDBEntities())
			{
				entities.Entry(employee).State = EntityState.Modified;
				entities.SaveChanges();
			}
		}
	}
}
