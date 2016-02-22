﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace UnitTest {
	[TestClass]
	public class ReverseStringTests {
		[TestMethod]
		public void ReverseString() {
			Assert.AreEqual(Exercise.ReverseString.ReverseStringInput("ABC"), "CBA");
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
