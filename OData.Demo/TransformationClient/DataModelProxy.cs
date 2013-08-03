using System;
using System.Linq;
using System.Data.Services.Client;
using ExposingTransformation;

namespace TransformationClient
{
	/// <summary>Proxy to our data model exposed as OData.</summary>
	public class DataModelProxy : DataServiceContext
	{
		/// <summary>Constructor taking the service root in parameter.</summary>
		/// <param name="serviceRoot"></param>
		public DataModelProxy(Uri serviceRoot)
			: base(serviceRoot)
		{
		}

		/// <summary>Returns the list of employees.</summary>
		public IQueryable<EmployeeModel> Employees
		{
			get { return CreateQuery<EmployeeModel>("Employees"); }
		}

		/// <summary>Returns the list of departments.</summary>
		public IQueryable<DepartmentModel> Departments
		{
			get { return CreateQuery<DepartmentModel>("Departments"); }
		}
	}
}