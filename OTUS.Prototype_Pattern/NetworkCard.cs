namespace OTUS.Prototype_Pattern
{
    class NetworkCard : ComputerComponent
    {
        public string MacAddress { get; set; }

        public NetworkCard()
        {
        }

        public NetworkCard(
            NetworkCard source) : base(source)
        {
            MacAddress = source.MacAddress;
        }

        public override Asset MyClone()
        {
            return new NetworkCard(this);
        }

        public override object Clone()
        {
            return MyClone();
        }
    }
}