using System;
using System.Linq;

namespace TransformationClient
{
	class Program
	{
		static void Main(string[] args)
		{
			var proxy = new DataModelProxy(new Uri(@"http://localhost:9793/EmployeeDataService.svc/"));
			var employees = from e in proxy.Employees
							orderby e.StreetName
							select e;

			foreach (var e in employees)
			{
				Console.WriteLine("{0}, {1}", e.LastName, e.FirstName);
			}
		}
	}
}