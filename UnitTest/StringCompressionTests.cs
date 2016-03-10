using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace UnitTest {
	[TestClass]
	public class StringCompressionTests {
		[TestMethod]
		public void StringCompressTest() {
			Assert.AreEqual(Exercise.StringCompression.StringCompressMethod("aabcccccaaa"), "a2b1c5a3");
		}
		[TestMethod]
		public void StringCompressTest2() {
			Assert.AreEqual(Exercise.StringCompression.StringCompressMethod("abc"), "abc");
		}
	}
}
