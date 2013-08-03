using System;
using System.Collections.Generic;
using System.Linq;

namespace ExposingTransformation
{
	/// <summary>Represents a data model exposing both the employee and the department.</summary>
	public class DataModel : IDisposable
	{
		private readonly ODataDemoEntities _dbContext = new ODataDemoEntities();

		/// <summary>Default constructor.</summary>
		/// <remarks>Populates the model.</remarks>
		public DataModel()
		{
			Departments = from d in _dbContext.Department
						  select new DepartmentModel
						  {
							  ID = d.DepartmentID,
							  Name = d.DepartmentName
						  };

			Employees = from e in _dbContext.Employee
						select new EmployeeModel
						{
							ID = e.EmployeeID,
							DepartmentID = e.DepartmentID,
							AddressID = e.AddressID,
							FirstName = e.FirstName,
							LastName = e.LastName,
							StreetNumber = e.Address.StreetNumber,
							StreetName = e.Address.StreetName
						};
		}

		/// <summary>Returns the list of employees.</summary>
		public IQueryable<EmployeeModel> Employees { get; private set; }

		/// <summary>Returns the list of departments.</summary>
		public IQueryable<DepartmentModel> Departments { get; private set; }

		void IDisposable.Dispose()
		{
			_dbContext.Dispose();
		}
	}
}