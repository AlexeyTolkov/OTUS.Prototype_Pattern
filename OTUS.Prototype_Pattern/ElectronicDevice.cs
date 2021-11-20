namespace OTUS.Prototype_Pattern
{
    class ElectronicDevice : Asset
    {
		public double Voltage { get; set; }

        public ElectronicDevice()
        {
        }

        public ElectronicDevice(
            ElectronicDevice source) : base(source)
        {
            Voltage = source.Voltage;
        }

        public override Asset MyClone()
        {
            return new ElectronicDevice(this);
        }

        public override object Clone()
        {
            return MyClone();
        }
    }
}