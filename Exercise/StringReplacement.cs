using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
	public static class StringReplacement {
		/*	Write a method to replace all spaces in a string with'%20'. You may assume that the string has sufficient space 
			at the end of the string to hold the additional characters, and that you are given the "true" length of the string. 
		    (Note: if implementing in Java, please use a character array so that you can perform this operation in place.)
			EXAMPLE
			Input: "Mr John Smith
			Output: "Mr%20Dohn%20Smith"
		 */

		public static string ReplaceSpaces(string input) {
			int spaceCount = 0;
			foreach (char s in input.ToCharArray()) {
				if (s == ' ') {
					spaceCount++;
				}
			}
			char[] inputData = new char[input.Length + (spaceCount * 2)];
			int j = 0;
			int curPos = 0;
			for (int i = 0; i < input.Length; i++) {
				if (input[i].ToString() == " ") {
					inputData[curPos] = '%';
					inputData[++curPos] = '2';
					inputData[++curPos] = '0';
				} else {
					inputData[curPos] = input[i];
				}
				curPos++;
			}

			return new string(inputData);
			//advantage of using StringBuilder method is that we can keep appending items.
			//disadvantage: slower then array char but array char requires to define number of elements
			//StringBuilder sb = new StringBuilder();

			//for (int i = 0; i < input.Length; i++) {
			//	sb.Append(input[i].ToString() == " " ? "%20" : input[i].ToString());
			//}
			//return input;
		}
	}
}
