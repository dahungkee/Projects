using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace UnitTest {
	[TestClass]
	public class StringReplacementTests {
		[TestMethod]
		public void ReplaceAllSpaces() {
			Assert.AreEqual(StringReplacement.ReplaceSpaces("Jessica Joshua Jaden Francis"), "Jessica%20Joshua%20Jaden%20Francis");
		}
		[TestMethod]
		public void ReverseStringWithNumber() {
			Assert.AreEqual(Exercise.ReverseString.ReverseStringInput("abc3de5"), "5ed3cba");
		}
		[TestMethod]
		public void ReverseCharacterArray() {
			CollectionAssert.AreEqual(Exercise.ReverseString.ReverseCharacterArray(new char[] { 'a', 'b', 'c', 'd' }), new char[] { 'd','c', 'b', 'a' }); 
		}
	}
}
