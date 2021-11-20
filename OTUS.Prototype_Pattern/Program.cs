using System;

namespace OTUS.Prototype_Pattern
{
    class Program
	{
		static void Main(string[] args)
		{
			var myPC = new PersonalComputerDefaultBuilder()
				.BuildCPU()
				.BuildMotherBoard()
				.BuildNetworkCard()
				.GetPC();

			var clonedPC	= myPC.Clone();
			var clonedMyPC	= myPC.MyClone();

            Console.WriteLine($"IClonable - diff btw myPC and cloned one: {clonedPC.Equals(myPC)}");
            Console.WriteLine($"IMyClonable - diff btw myPC and cloned one: {clonedMyPC.Equals(myPC)}");

			Console.ReadKey();
		}
	}
}