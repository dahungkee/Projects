using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace UnitTest {
	[TestClass]
	public class StringSearchTests {
		[TestMethod]
		public void TestNoDuplication_Implementation1() {
			Assert.IsFalse(StringSearch.SearchDuplication2("aBcDeFg", true));
		}
		[TestMethod]
		public void TestWithDuplication_Implementation1() {
			Assert.IsTrue(StringSearch.SearchDuplication2("aBcDeFAg", true));
		}
		[TestMethod]
		public void TestWithDuplicationIgnoreCase_Implementation1() {
			Assert.IsFalse(StringSearch.SearchDuplication2("aBcDeFAg", false));
		}
		[TestMethod]
		public void TestAlphaNumericDuplication2_Implementation1() {
			Assert.IsTrue(StringSearch.SearchDuplication2("aBc33DeFAg", false));
		}


		[TestMethod]
		public void TestNoDuplication_Implementation2() {
			Assert.IsFalse(StringSearch.SearchDuplication2("aBcDeFg", true));
		}
		[TestMethod]
		public void TestWithDuplication_Implementation2() {
			Assert.IsTrue(StringSearch.SearchDuplication2("aBcDeFAg", true));
		}
		[TestMethod]
		public void TestWithDuplicationIgnoreCase_Implementation2() {
			Assert.IsFalse(StringSearch.SearchDuplication2("aBcDeFAg", false));
		}
		[TestMethod]
		public void TestAlphaNumericDuplication2_Implementation2() {
			Assert.IsTrue(StringSearch.SearchDuplication2("aBc33DeFAg", false));
		}
	}
}
