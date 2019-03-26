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