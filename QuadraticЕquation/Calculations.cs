//using System;
//namespace QuadraticЕquation
//{
//	public class Calculations
//	{
//		public Calculations()
//		{
//			Calcs();
//		}

//		public bool Calcs()
//		{
//			try
//			{
//				string __userInput = "";

//				do
//				{

//					string _userInput = Console.ReadLine().ToLower();

//					_userInput = __userInput;

//					string[] param = _userInput.Split(' ');

//					double a = 0, b = 0, c = 0, d = 0, x1 = 0, x2 = 0;

//					double.TryParse(param[0], out a);
//					double.TryParse(param[1], out b);
//					double.TryParse(param[2], out c);

//					if (param.Length == 3)
//					{

//						if (a == 0)
//						{
//							Console.WriteLine("\n\nТова не е квадратно уравнение\n\n");
//						} else {

//							d = (b) * (b) - 4 * a * (c);

//							Console.WriteLine("\n\nD = b^2 - 4*a*c  =  " + d);

//							if (d > 0)
//							{

//								Console.WriteLine("\nКорените на квадратното уравнение са x1 = (-(" + b + ") + √" + d + ") / 2 * " + a);
//								Console.WriteLine("Корените на квадратното уравнение са x2 = (-(" + b + ") - √" + d + ") / 2 * " + a);


//								x1 = (-(b) + Math.Sqrt(d)) / 2 * a;
//								x2 = (-(b) - Math.Sqrt(d)) / 2 * a;

//								Console.Write("\nКорените на квадратното уравнение са x1 = ");
//								Console.Write(x1.ToString("N2"));
//								Console.Write(" и x2 = ");
//								Console.WriteLine(x2.ToString("N2") + "\n\n");

//							}


//							if (d == 0)
//							{
//								x1 = (-(b)) / 2 * a;

//								Console.WriteLine("\nКвадратното уравнение има един двоен корен x = " + x1 + "\n\n");
//							}

//							if (d < 0)
//							{
//								Console.WriteLine("\nУравнението няма решение." + "\n\n");
//							}

//						}

//					} else {

//						Console.WriteLine("Моля въведете данните коректно!");
//					}

//				} while (__userInput != "изход");

//			} catch {
//			}

//			return true;
//		}

//	}

//}
