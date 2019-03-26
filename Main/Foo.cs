namespace Main
{
	public sealed class Foo<T1>
	{
		public bool Send(T1 arg1)
		{
			return true;
		}

		public  bool Send(bool eventArgs)
		{
			return true;
		}
	}
}