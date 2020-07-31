using System;
using add;
namespace driver_prog
{
	public class my_driver_class
	{
		static void Main(string[] args)
		{
			add a=new add();
			int ans=a.addition(5,10);
			Console.WriteLine(ans);
			Console.ReadKey();
		}
	}
}