using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
	public class factorial {
		//test

		public static int Fact(int input) {
			int fact = input;
			for (int i = input -1; i >= 1; i--) {
				fact = fact * i;
			}
			return fact;
		}

		public static int RecursiveFactorial(int input) {
			if (input <= 1) {
				return 1;
			}
			return input * RecursiveFactorial(input - 1);
		}

		public static void FunFactorial() {
			Console.Write("Enter a number to find factorial: ");
			int n = Convert.ToInt32(Console.ReadLine());
			int r = RecursiveFactorial(n);
			Console.WriteLine(n.ToString() + "! = " + r.ToString());
			Console.Write("Press any key to continue...");
			Console.ReadKey();
		}
	}
}
