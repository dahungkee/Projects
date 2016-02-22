using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
	public static class StringTools {
		//Given two strings, write a method to decide if one is a permutation of the other.
		public static bool IsStringPermutation(string input1, string input2) {
			if (input1.Length != input2.Length) {
				return false;
			}

			return Alphabetize(input1).Equals(Alphabetize(input2));
		}

		private static string Alphabetize(string s) {
			//1. Convert to char array
			char[] a = s.ToCharArray();

			//2. Sort letters
			Array.Sort(a);

			//3. Return modified string
			return new string(a);
		}
	}
}
