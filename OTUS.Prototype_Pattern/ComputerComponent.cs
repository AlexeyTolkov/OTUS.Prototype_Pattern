namespace OTUS.Prototype_Pattern
{
    abstract class ComputerComponent : ElectronicDevice
    {
        public ComputerComponentType Type { get; set; }
        public string ModelName { get; set; }

        public ComputerComponent()
        {
        }

        public ComputerComponent(
            ComputerComponent source) : base (source)
        {
            Type = source.Type;
            ModelName = source.ModelName;
        }

        abstract override public Asset MyClone();
        abstract override public object Clone();
    }
}