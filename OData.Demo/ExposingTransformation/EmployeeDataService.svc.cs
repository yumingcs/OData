using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;

namespace ExposingTransformation
{
    public class EmployeeDataService : DataService<DataModel>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
			config.SetEntitySetAccessRule("Employees", EntitySetRights.AllRead);
			config.SetEntitySetAccessRule("Departments", EntitySetRights.AllRead);

			config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
		}
    }
}