using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;

namespace HelloWorld
{
    public class EmployeeDataService : DataService<ODataDemoEntities>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
			config.SetEntitySetAccessRule("Employee", EntitySetRights.AllRead);
			config.SetEntitySetAccessRule("Address", EntitySetRights.AllRead);
			config.SetEntitySetAccessRule("Department", EntitySetRights.AllRead);

			config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
        }
    }
}
