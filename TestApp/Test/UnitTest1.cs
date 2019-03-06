using System;
using Xunit;


namespace Test
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			int lot1 = 10;
			int lot2 = 20;

			int result = TestApp.testnum.Calcul(lot1, lot2);

			Assert.Equal(30, result);
		}

		[Fact]
		public void Test2()
		{
			int lot1 = 10;
			int lot2 = 20;

			int result = TestApp.testnum.Calcul(lot1, lot2);

			Assert.Equal(50, result);
		}
	}
}
