using System;
using System.Collections.Generic;
using System.Text;

namespace OTUS.Prototype_Pattern
{
    class PersonalComputerDefaultBuilder
    {
		private readonly PersonalComputer _pc = new PersonalComputer();
		public PersonalComputerDefaultBuilder BuildMotherBoard()
		{
			_pc.AddComponent(new MotherBoard()
			{
				AssetId = "1",
				InitialCost = 1000.00,
				Voltage = 220.00,
				Type = ComputerComponentType.MotherBoard,
				ModelName = "Some motherboard model..",
				CPUSocket = "LGA 1155"
			});

			return this;
		}

		public PersonalComputerDefaultBuilder BuildCPU()
		{
			_pc.AddComponent(new CPU()
			{
				AssetId = "2",
				InitialCost = 2000.00,
				Voltage = 220.00,
				Type = ComputerComponentType.CPU,
				ModelName = "Some processor model..",
				Socket = "LGA 1155",
				ClockSpeed = 2000
			});

			return this;
		}

		public PersonalComputerDefaultBuilder BuildNetworkCard()
		{
			_pc.AddComponent(new NetworkCard()
			{
				AssetId = "3",
				InitialCost = 3000.00,
				Voltage = 220.00,
				Type = ComputerComponentType.CPU,
				ModelName = "Some networkCard model..",
				MacAddress = "7c:e9:a9:a9:7b:43"
			});

			return this;
		}

		public PersonalComputer GetPC()
		{
			return _pc;
		}
	}
}
