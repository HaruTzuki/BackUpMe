using System;

namespace BackUpMe.Process
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length <= 0)
			{
				Console.WriteLine("This application not started correctly.");
				return;
			}

			var JobId = args[0];

			Console.Write(JobId);
		}
	}
}
