using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;

namespace ServiceOperations
{
	public class EmployeeDataService : DataService<ODataDemoEntities>
	{
		// This method is called only once to initialize service-wide policies.
		public static void InitializeService(DataServiceConfiguration config)
		{
			config.SetEntitySetAccessRule("Employee", EntitySetRights.AllRead);
			config.SetEntitySetAccessRule("Address", EntitySetRights.AllRead);
			config.SetEntitySetAccessRule("Department", EntitySetRights.AllRead);

			config.SetServiceOperationAccessRule("GetDepartmentByMembership", ServiceOperationRights.AllRead);

			config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
		}

		[WebGet]
		public IQueryable<Department> GetDepartmentByMembership(int employeeCount)
		{
			var departments = from d in this.CurrentDataSource.Department
							  where d.Employee.Count >= employeeCount
							  select d;

			return departments;
		}
	}
}
