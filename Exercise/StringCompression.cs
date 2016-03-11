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
			
			if (string.IsNullOrEmpty(input)) {
				return input;
			}

			StringBuilder sb = new StringBuilder();
			int count = 0;
			string currentLetter = input[0].ToString();

			sb.Append(currentLetter);

			for (int i = 0; i < input.Length; i++) {
				if (currentLetter == input[i].ToString()) {
					count++;					
				}
				else {
					currentLetter = input[i].ToString();
					sb.Append(count + currentLetter);						
					count = 1;														
				}
				if (i == input.Length - 1) {
					sb.Append(count);
				}
			}			
			return sb.Length > input.Length ? input : sb.ToString();
		}
	}
}