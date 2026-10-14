namespace SpecialFeatures.Ucl.Contact
{
    using AcpBusinessLayer;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class UclContactRecset : Recordset
    {
        public static int _MaxPool;
        public static int _Max;

        static UclContactRecset();
        public UclContactRecset();
        protected UclContactRecset(SerializationInfo info, StreamingContext context);
        private void a();
        public override FeatureNode CreateDefaultRecord();
        protected override void Dispose(bool disposing);
        protected override void Finalize();
        public override string GenerateKeyValue(FeatureNode node);
        public override int GetCounterToMaxCopiesOf(int index);

        public override int MaxPool { get; }

        public override int Max { get; }

        public override int CounterToMax { get; }

        public bool HasDiffs { get; }

        internal bool ReachedMaxContactsHotlisted { get; }
    }
}

