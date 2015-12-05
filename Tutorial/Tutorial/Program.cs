using System;

namespace Tutorial
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num1;
			int num2;

			Console.Write ("Type in a number to be multiplied: ");
			num1 = Convert.ToInt32 (Console.ReadLine ());
			Console.Write ("Type in another number to be multiplied: ");
			num2 = Convert.ToInt32 (Console.ReadLine ());
			Console.WriteLine ("The product is: " + num1*num2);
			Console.ReadKey ();
			
		}
	}
}
