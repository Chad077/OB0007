// ------------------------------------------------------------------------------ 
// Main - Tests - UnitTest1.cs
// 2019/03/26  -  tjl
// Rather have things you don't need than things you need that you don't have. 5/7/2013
// A complex system can only be "practically perfect" or "perfectly practical" but never perfect and practical. 30/11/2015
// Copyright(c) 2012-2019 - T Liebenberg - Union Software Ltd
// ------------------------------------------------------------------------------ 

namespace Tests
{
	using Main;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var signal1 = new Foo<int>();
			var signal2 = new Foo<string>();

			signal1.Send(1);
			signal2.Send("2");
		}
	}
}