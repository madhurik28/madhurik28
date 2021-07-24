using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace FileData
{
	class FileDetails
	{
		private static Random random = new Random();
		public static string Version(string random="")
		{
			try
			{
				Random ran = new Random();
				random = ran.Next().ToString();
				return random;
			}catch(Exception ex)
			{
				throw ex;
			}
		}

		public static string Size(string random = "")
		{
			try
			{
				var thisApp = Assembly.GetExecutingAssembly();
				AssemblyName name = new AssemblyName(thisApp.FullName);
				string VersionNumber = "v. " + name.Version;
				return VersionNumber;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
