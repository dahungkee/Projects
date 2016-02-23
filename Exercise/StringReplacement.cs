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

		 *  given an array in c#, does it tell you how many elements it has?
			if so, then you need 2. Otherwise you need 3.
			1. The array itself
			2. The actual size of the array. But may not be necessary if C# can tell u from the array.
			3. The length of the string contained within the array.  It is shorter than the actual size of the array.
			There are two sizes.
			the array size and the string length
			array size is longer and is enough to hold the "extended" string.
			in the example, string length is 13
			array size is 17
			is it clear?
		 */
		public static char[] ReplaceSpaces(char[] input, int lengthOfString) {
			for (int i = 0; i < input.Length; i++) {
				if (input[i] == ' ') {
					//move the rest of elements down by 2					
					int sourceIndex = i + 1;
					int destinationIndex = i + 3;
					int lengthOfCharToMove = lengthOfString - sourceIndex;
					Array.ConstrainedCopy(input, sourceIndex, input, destinationIndex, lengthOfCharToMove);

					input[i] = '%';
					input[++i] = '2';
					input[++i] = '0';
					lengthOfString += 2;				
				}
			}
			return input;
		}

		public static char[] ReplaceSpacesWithHubbyWay(char[] input, int lengthOfString) {
			int nextAvailPos = input.Length - 1;
			for (int i = lengthOfString - 1; i >= 0; i--) {
				if (input[i] == ' ') {
					input[nextAvailPos--] = '0';
					input[nextAvailPos--] = '2';
					input[nextAvailPos--] = '%';
				} else {
					input[nextAvailPos--] = input[i];
				}
			}
			return input;
		}
	}
}
