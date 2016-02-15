using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace UnitTest {
	[TestClass]
	public class FactorialTests {
		[TestMethod]
		public void NonRecursiveMethodTest() {
			Assert.AreEqual(Exercise.factorial.Fact(4),24);
		}
		[TestMethod]
		public void RecursiveMethodTest() {
			Assert.AreEqual(factorial.RecursiveFactorial(4), 24);
		}
		[TestMethod]
		public void RecursiveMethodZeroTest() {
			Assert.AreEqual(factorial.RecursiveFactorial(0), 1);
		}
	}
}
