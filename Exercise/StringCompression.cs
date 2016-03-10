using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
	public static class StringCompression {
		/// <summary>
		/// Implement a method to perform basic string compression using the counts of repeated characters. 
		/// For example, the string aabcccccaaa would become a2blc5a3. 
		/// If the "compressed" string would not become smaller than the original string, your method should return the original string.
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public static string StringCompressMethod(string input) {
			StringBuilder sb = new StringBuilder();			
			int count = 1;
			string currentLetter = input[0].ToString();

			for (int i = 1; i < input.Length; i++) {				
				if (currentLetter == input[i].ToString()) {
					count++;					
				} else {
					sb.Append(currentLetter + count);
					currentLetter = input[i].ToString();
					count = 1;
				}
				if (i == input.Length - 1) {
					sb.Append(currentLetter + count);
				}
			}

			return sb.Length > input.Length ? input : sb.ToString();
		}
	}
}
