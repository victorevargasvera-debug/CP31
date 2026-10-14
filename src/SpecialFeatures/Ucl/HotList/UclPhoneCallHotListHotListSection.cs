namespace SpecialFeatures.Ucl.HotList
{
    using AcpBusinessLayer;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class UclPhoneCallHotListHotListSection : FeatureSection
    {
        private SpecialFeatures.Ucl.HotList.PhoneCallHotListRecset phoneCallHotListRecset;

        internal UclPhoneCallHotListHotListSection(FeatureNode parent);
        internal UclPhoneCallHotListHotListSection(SerializationInfo info, StreamingContext context);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        internal SpecialFeatures.Ucl.HotList.PhoneCallHotListRecset PhoneCallHotListRecset { get; }

        public bool HasDiffs { get; }
    }
}

