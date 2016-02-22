using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
	public static class ReverseString {
		/// <summary>
		/// Implement a function void reverse(char* str) in C or C++ which reverses a nullterminated string.
		/// I am implementing this in C# rather than C or C++. ABC
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static string ReverseStringInput(string input) {
			//1. Easy way
			//char[] inputData = input.ToCharArray();
			//Array.Reverse(inputData);

			//2. Mannually implement the reverse function
			char[] inputData = new char[input.Length];

			int dest = 0;
			for (int source = input.Length - 1; source >= 0; source--) {
				inputData[dest] = input[source];
				dest++;
			}
			return new string(inputData);
		}

		public static char[] ReverseCharacterArray(char[] input) {
			int dest = 0;
			for (int source = input.Length - 1; source >= input.Length / 2; source--) {
				char tempChar = input[source];
				input[source] = input[dest];
				input[dest] = tempChar;			
				dest++;				
			}

			return input;
		}

		public static char[] ReverseCharArrayWithHubbyWay(char[] input) {
			int begin = 0;
			int end = input.Length - 1;

			while (begin < end) {
				char tempChar = input[begin];
				input[begin] = input[end];
				input[end] = tempChar;
				begin++;
				end--;
			}
			return input;
		}
	}
}
