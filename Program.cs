using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileData
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length == 0)
			{
				Console.WriteLine("Please enter parameter values.");
				Console.Read();
			}
			else
			{
					if (args[1] == "-v" )
					{
						if (args[2] == "FileDetails.Version")
						{
							args[2] = "FileDetails.Version('1234')";
							Console.WriteLine(args[2]);
						}
					}

					if (args[1] == "--v" || args[1] == "/v")
					{
						if (args[2] == "FileDetails.Version")
						{
							args[2] = "FileDetails.Version('1234')";
							Console.WriteLine(args[2]);
						}
					}else if (args[1] == "-s" || args[1] == "--s" || args[1] == "/s")
					{
						if (args[2] == "FileDetails.Size")
						{
							args[2] = "FileDetails.Size('1234')";
							Console.WriteLine(args[2]);
						}

					}

				Console.Read();
			}
		}
	}
}
	