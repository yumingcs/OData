using System;
using System.Collections.Generic;
using System.Data.Services.Common;
using System.Linq;

namespace ExposingTransformation
{
	/// <summary>Represents a department.</summary>
	[DataServiceKey("ID")]
	public class DepartmentModel
	{
		/// <summary>ID of the department.</summary>
		public int ID { get; set; }

		/// <summary>Name of the department.</summary>
		public string Name { get; set; }
	}
}