using System;

namespace EnteredCircle
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			try
			{
				string __userInput = "";

				Console.WriteLine("Задача за окръжност, вписана в четириъгълник. За да затворите програмата напишете 'Изход'\n");

				do
				{

					bool _result;

					Console.Write("\n\nМоля въведете a, b, c и d на четириъгълника: ");
					string _userInput = __userInput = Console.ReadLine().ToLower();


					string[] param = _userInput.Split(' ');

					if (_userInput != "изход")
					{
						if (param.Length != 4 || _userInput == " " || _userInput == "   ")
						{
							Console.WriteLine("\nМоля въведете данните коректно. Страните трябва да бъдат цели положителни числа!");

						}
						else {

							int a = 0, b = 0, c = 0, d = 0;

							int.TryParse(param[0], out a);
							int.TryParse(param[1], out b);
							int.TryParse(param[2], out c);
							int.TryParse(param[3], out d);

							if (a + c == b + d && a * a + c * c == b * b + d * d && param.Length == 4 && _userInput != " " & _userInput != "   ")
							{
								_result = true;
								Console.WriteLine("\nОкръжността може да бъде вписана в четириъгълника");

							}
							else {
								if (a + c != b + d && a * a + c * c != b * b + d * d && param.Length == 4)
								{
									_result = false;
									Console.WriteLine("\nОкръжността НЕ може да бъде вписана в четириъгълника");
								}
							}
						}
					}

				} while (__userInput != "изход");

				Console.WriteLine();

			} catch {
			}
		}
	}
}
 
