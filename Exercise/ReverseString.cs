using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
	public static class ReverseString {
		/// <summary>
		/// Implement a function void reverse(char* str) in C or C++ which reverses a nullterminated string.
		/// I am implementing this in C# rather than C or C++.
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static string ReverseStringInput(string input) {
			char[] inputData = new char[input.Length];
			int j = 0;
			for (int i = input.Length - 1; i >= 0; i--) {
				inputData[j] = input[i];
				j++;
			}
			return new string(inputData);
		}
	}
}
