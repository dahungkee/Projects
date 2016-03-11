using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace UnitTest {
	[TestClass]
	public class StringCompressionTests {
		[TestMethod]
		public void StringCompressTest() {
			Assert.AreEqual("a2b1c5a3", Exercise.StringCompression.StringCompressMethod("aabcccccaaa"));
		}
		[TestMethod]
		public void ShorterInputTest() {
			Assert.AreEqual("abc", Exercise.StringCompression.StringCompressMethod("abc"));
		}
		[TestMethod]
		public void EmptyInputTest() {
			Assert.AreEqual("", Exercise.StringCompression.StringCompressMethod(""));
		}
		[TestMethod]
		public void OneLetterInputTest() {
			Assert.AreEqual("ab", Exercise.StringCompression.StringCompressMethod("ab"));
		}
		[TestMethod]
		public void OneLetterInputTest2() {
			Assert.AreEqual("aab", Exercise.StringCompression.StringCompressMethod("aab"));
		}
	}
}
