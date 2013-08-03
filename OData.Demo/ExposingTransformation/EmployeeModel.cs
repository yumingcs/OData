using System;
using System.Linq;
using System.Data.Services.Common;

namespace ExposingTransformation
{
	/// <summary>Represents an employee.</summary>
	[DataServiceKey("ID")]
	public class EmployeeModel
	{
		/// <summary>ID of the employee.</summary>
		public int ID { get; set; }

		/// <summary>ID of the associated department.</summary>
		public int DepartmentID { get; set; }

		/// <summary>ID of the address.</summary>
		public int AddressID { get; set; }

		/// <summary>First name of the employee.</summary>
		public string FirstName { get; set; }

		/// <summary>Last name of the employee.</summary>
		public string LastName { get; set; }

		/// <summary>Address street number.</summary>
		public int StreetNumber { get; set; }

		/// <summary>Address street name.</summary>
		public string StreetName { get; set; }
	}
}