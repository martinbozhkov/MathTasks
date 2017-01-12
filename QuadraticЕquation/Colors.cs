using System;
namespace Colors
{
	public class ForCLI
	{
		public ForCLI()
		{
		}

		public void Default()
		{
			Console.ForegroundColor = ConsoleColor.Gray;
		}
		public void Prompt()
		{
			Console.ForegroundColor = ConsoleColor.White;
		}
		public void Command()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
		}
		public void Result()
		{
			Console.ForegroundColor = ConsoleColor.Red;
		}

	}
}
