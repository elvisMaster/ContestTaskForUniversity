using System;

namespace Application
{
	class MainClass
	{
		public static void Main(string[] args){
			
			string[]data=Console.ReadLine().Split (' ');
			int M = int.Parse(data [0]);
			int N = int.Parse(data [1]);
			Console.WriteLine (M+N);

		}
	}
}
