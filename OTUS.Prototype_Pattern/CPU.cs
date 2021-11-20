namespace OTUS.Prototype_Pattern
{
    class CPU : ComputerComponent
    {
        public string Socket { get; set; }
        public int ClockSpeed { get; set; }
        public CPU()
        {
        }

        public CPU(
            CPU source) : base(source)
        {
            Socket = source.Socket;
            ClockSpeed = source.ClockSpeed;
        }

        public override Asset MyClone()
        {
            return new CPU(this);
        }

        public override object Clone()
        {
            return MyClone();
        }
    }
}