using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class MathTest
	{
		[TestMethod]
		public void TestMethod1()
		{

			int lot1 = 10;
			int lot2 = 20;

			int result = TestApp.testnum.Calcul(lot1, lot2);

			Assert.AreEqual(30, result);
		}

		[TestMethod]
		public void TestMethod2()
		{

			int lot1 = 10;
			int lot2 = 20;

			int result = TestApp.testnum.Calcul(lot1, lot2);

			Assert.AreEqual(30, result);
		}
	}
}
