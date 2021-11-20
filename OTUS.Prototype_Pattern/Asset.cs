using System;

namespace OTUS.Prototype_Pattern
{
    class Asset : IMyCloneable<Asset>, ICloneable
    {
        public string AssetId { get; set; }
        public double InitialCost { get; set; }

        public Asset()
        {
        }

        public Asset(Asset source)
        {
            AssetId = source.AssetId;
            InitialCost = source.InitialCost;
        }

        virtual public Asset MyClone()
        {
            return new Asset(this);
        }

        virtual public object Clone()
        {
            return MyClone();
        }
    }
}