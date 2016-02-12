using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
	public class StringSearch {
		static void Main(string[] args) {
		}

		/// <summary>
		/// Implement an algorithm to determine if a string has all unique characters.
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static bool SearchDuplication(string input) {
			HashSet<char> result = new HashSet<char>();
			foreach (char s in input) {
				if (result.Contains(s)) {
					return true;
				}
				result.Add(s);
			}
			return false;
		}

		/// <summary>
		/// Implement an algorithm to determine if a string has all unique characters. What if you cannot use additional data structures?
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static bool SearchDuplication2(string input, bool ignoreCase) {
			string testInput = input;
			if (ignoreCase) {
				testInput = input.ToLower();
			}
			
			for (int i = 0; i < testInput.Length; i++) {
				for (int j = i + 1; j < testInput.Length; j++) {
					if (testInput[i] == testInput[j]) {
						return true;
					}
				}
			}
			return false;
		}
	}
}
