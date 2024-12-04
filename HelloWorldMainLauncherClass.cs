namespace it.Nanowar.OfSteel.HelloWorld
{
	public class HelloWorldMainLauncherClass
	{
		public HelloWorldMainLauncherClass(int foo)
		{
			this.foo = foo;
		}

		private int foo = 0;

		public void SongRefrain()
		{
			for (int i = 0; i < foo; i++)
			{
				System.Console.WriteLine("Hello World!");
			}

			int pippo = 0;
			while (pippo < foo)
			{
				System.Console.WriteLine("Hello World!");
				pippo++;
			}
		}

		public static void Main(string[] args)
		{
			System.Console.WriteLine("Hello World Programmer Start");
			HelloWorldMainLauncherClass tizio = new HelloWorldMainLauncherClass(2);
			tizio.SongRefrain();
			System.Console.WriteLine("Program Finished!");
			tizio.FalseMethod();
		}

		/*
        If I may introduce a bug, the CLR will manage it for me
        ensuring both security and portability
        Then I'll write my code once, and run it on supported devices!
        With Static and Strong Typing, will let my programs be type safe!
        */

		public void FalseMethod()
		{
			bool metal = false;
			if (metal == false)
			{
				string joeyDeCaio = null;
				joeyDeCaio.Trim();
			}
		}
	}
}
