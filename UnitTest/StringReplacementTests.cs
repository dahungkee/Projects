using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise;

namespace UnitTest {
	[TestClass]
	public class StringReplacementTests {
		[TestMethod]
		public void ReplaceAllSpaces() {
			char[] testdata = new char[9];
			testdata[0] = 'a';
			testdata[1] = ' ';
			testdata[2] = 'b';
			testdata[3] = ' ';
			testdata[4] = 'c';
			//testdata[5] = ' ';
			//testdata[6] = 'd';


			int lengthOfString = 5;

			char[] actualResult = new char[9];
			actualResult[0] = 'a';
			actualResult[1] = '%';
			actualResult[2] = '2';
			actualResult[3] = '0';
			actualResult[4] = 'b';
			actualResult[5] = '%';
			actualResult[6] = '2';
			actualResult[7] = '0';
			actualResult[8] = 'c';
			//actualResult[9] = '%';
			//actualResult[10] = '2';
			//actualResult[11] = '0';
			//actualResult[12] = 'd';

			CollectionAssert.AreEqual(StringReplacement.ReplaceSpacesWithHubbyWay(testdata, lengthOfString), actualResult);			
		}
	}
}
