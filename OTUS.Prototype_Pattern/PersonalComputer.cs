using System;
using System.Collections.Generic;

namespace OTUS.Prototype_Pattern
{
    class PersonalComputer : IMyCloneable<PersonalComputer>, ICloneable
    {
        private List<ComputerComponent> Components = new List<ComputerComponent>();

        public void AddComponent(ComputerComponent newComponent)
        {
            Components.Add(newComponent);
        }

        public PersonalComputer MyClone()
        {
			var clonedPC = new PersonalComputer();
			foreach (var component in Components)
            {
                clonedPC.AddComponent((ComputerComponent)component.MyClone());
			}

			return clonedPC;
		}

        public object Clone()
        {
            var clonedPC = new PersonalComputer();
            foreach (var component in Components)
            {
                clonedPC.AddComponent((ComputerComponent)component.Clone());
            }

            return clonedPC;
        }
    }
}