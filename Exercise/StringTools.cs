using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
	public static class StringTools {
		//Given two strings, write a method to decide if one is a permutation of the other. Test. Test Test.
		public static bool IsStringPermutation(string input1, string input2) {
			if (input1.Length != input2.Length) {
				return false;
			}

			string data1 = Alphabetize(input1);
			string data2 = Alphabetize(input2);

			for (int i = 0; i < data1.Length; i++) {
				if (data1[i] != data2[i]) {
					return false;
				}
			}

			return true;
		}

		private static string Alphabetize(string s) {
			//1. string is immutable so can't do anyting with the letters in-place
			s = s.ToLower();

			//2. Convert to char array
			char[] a = s.ToCharArray();

			//3. Sort letters
			Array.Sort(a);

			//4. Return modified string
			return new string(a);
		}
	}
}
