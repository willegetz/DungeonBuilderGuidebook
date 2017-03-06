using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TrapArchitectConsole.TrapLoaders
{
	public static class DataConstants
	{
		public static string DataFilesPath
		{
			get { return Path.GetDirectoryName(Assembly.GetCallingAssembly().CodeBase) + @"\DataFiles\"; }
		}
	}
}
