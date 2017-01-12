using System;

namespace QuadraticЕquation
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Colors.ForCLI _c = new Colors.ForCLI();

			try
			{

				_c.Default(); 	Console.WriteLine("Квадратно уравнение. За да излезете от конзолата напишете 'Изход'.");

				string __userInput = "";

				do
				{

					_c.Prompt(); 	Console.Write("\n\n\nПриведете квадратното уравнение до вида: ");
					_c.Result();	Console.WriteLine("ax^2 + bx + c = 0\n");

					_c.Prompt();	Console.Write("Въведете коефициентите a, b и c на квадратното уравнение: ");


					_c.Command(); 	string _userInput = __userInput = Console.ReadLine().ToLower();


					string[] param = _userInput.Split(' ');

					if (_userInput != "изход")
					{

						if (param.Length != 3)
						{

							_c.Result(); Console.WriteLine("\nМоля въведете данните коректно!\n");

						}
						else {


							double a = 0, b = 0, c = 0, d = 0, x1 = 0, x2 = 0;



							double.TryParse(param[0], out a);
							double.TryParse(param[1], out b);
							double.TryParse(param[2], out c);

							d = (b) * (b) - 4 * a * (c);

							if (a == 0)
							{
								_c.Result(); Console.WriteLine("\nМоля въведете данните коректно!");
								_c.Default(); Console.Write("Внимание: ");
								_c.Result(); Console.WriteLine("Коефициентът пред 'a' не може да е 0\n");

							}
							else {

								if (d > 0)
								{
									_c.Default(); Console.Write("\n\nD = b^2 - 4*a*c  =  ");
									_c.Result(); Console.WriteLine(d);

									_c.Default(); Console.Write("\nКоренът x1 = ");
									_c.Result(); Console.WriteLine("-(" + b + ") + √" + d + ") / 2 * " + a);
									_c.Default(); Console.Write("\nКоренът x2 = ");
									_c.Result(); Console.WriteLine("-(" + b + ") - √" + d + ") / 2 * " + a);


									x1 = (-(b) + Math.Sqrt(d)) / 2 * a;
									x2 = (-(b) - Math.Sqrt(d)) / 2 * a;

									_c.Default(); Console.Write("\n\nКорените на квадратното уравнение са x1 = ");
									_c.Result(); Console.Write(x1.ToString("N2"));
									_c.Default(); Console.Write(" и x2 = ");
									_c.Result(); Console.WriteLine(x2.ToString("N2") + "\n\n");

								}


								if (d == 0)
								{
									x1 = (-(b)) / 2 * a;

									_c.Default(); Console.Write("\n\nD = b^2 - 4*a*c  =  ");
									_c.Result(); Console.WriteLine(d);

									_c.Default(); Console.Write("\nКвадратното уравнение има един двоен корен x = ");
									_c.Result(); Console.WriteLine(x1 + "\n\n");
								}

								if (d < 0)
								{
									_c.Default(); Console.Write("\n\nD = b^2 - 4*a*c  =  ");
									_c.Result(); Console.WriteLine(d);

									_c.Result(); Console.WriteLine("\nУравнението няма решение." + "\n\n");
								}

							}
						}
					}

				} while (__userInput != "изход");

				Console.WriteLine();

			}catch {
			}
		}
	}
}
