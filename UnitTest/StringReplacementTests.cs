using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace UnitTest {
	[TestClass]
	public class StringReplacementTests {
		[TestMethod]
		public void ReplaceAllSpaces() {
			Assert.AreEqual(StringReplacement.ReplaceSpaces(" Jessica Joshua Jaden Francis"), "%20Jessica%20Joshua%20Jaden%20Francis");
		}
	}
}
