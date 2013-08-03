using System;
using System.Linq;
using System.Data.Services.Common;

namespace AnotherDataModel
{
	/// <summary>Represents the information of a process.</summary>
	[DataServiceKey("Name")]
	public class ProcessModel
	{
		/// <summary>Name of the process.</summary>
		public string Name { get; set; }

		/// <summary>Process ID.</summary>
		public int ID { get; set; }
	}
}