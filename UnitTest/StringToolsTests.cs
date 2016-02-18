using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace UnitTest {
	[TestClass]
	public class StringToolsTests {
		[TestMethod]
		public void IsPermutation() {
			Assert.IsTrue(StringTools.IsStringPermutation("sam", "ams"));
		}

		[TestMethod]
		public void NotPermutation() {
			Assert.IsFalse(StringTools.IsStringPermutation("cat", "ctt"));
		}

		[TestMethod]
		public void InputLenDiff() {
			Assert.IsFalse(StringTools.IsStringPermutation("app", "apps"));
		}

		[TestMethod]
		public void CaseDifferent() {
			Assert.IsFalse(StringTools.IsStringPermutation("app", "apP"));
		}
	}
}
