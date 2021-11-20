namespace OTUS.Prototype_Pattern
{
    class MotherBoard : ComputerComponent
    {
        public string CPUSocket { get; set; }

        public MotherBoard()
        {
        }

        public MotherBoard(
            MotherBoard source) : base(source)
        {
            CPUSocket = source.CPUSocket;
        }

        public override Asset MyClone()
        {
            return new MotherBoard(this);
        }

        public override object Clone()
        {
            return MyClone();
        }
    }
}