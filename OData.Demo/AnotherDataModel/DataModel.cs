using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AnotherDataModel
{
	/// <summary>Represents a data model exposing processes.</summary>
	public class DataModel
	{
		/// <summary>Default constructor.</summary>
		/// <remarks>Populates the model.</remarks>
		public DataModel()
		{
			var processProjection = from p in Process.GetProcesses()
									select new ProcessModel
									{
										Name = p.ProcessName,
										ID = p.Id
									};

			Processes = processProjection.AsQueryable();
		}

		/// <summary>Returns the list of running processes.</summary>
		public IQueryable<ProcessModel> Processes { get; private set; }
	}
}