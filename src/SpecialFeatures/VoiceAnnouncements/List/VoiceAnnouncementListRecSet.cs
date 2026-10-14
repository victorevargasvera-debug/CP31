namespace SpecialFeatures.VoiceAnnouncements.List
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class VoiceAnnouncementListRecSet : Recordset, ISerializable
    {
        public static string[] voiceFiles;
        public static int vaCount;
        public static int _MaxPool;
        public static int _Max;
        internal int _DynMax;
        public static int _Min;

        static VoiceAnnouncementListRecSet();
        public VoiceAnnouncementListRecSet();
        internal VoiceAnnouncementListRecSet(SerializationInfo info, StreamingContext context);
        public override FeatureNode CreateDefaultRecord();
        public override void DecrementCumulativeMax(IAcpFeatureNode record);
        public void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void IncrementCumulativeMax(IAcpFeatureNode record);
        protected override void OnFinishedAddRecord(IAcpFeatureNode record);
        protected override void OnFinishedMoveRecord(IAcpFeatureNode draggedRecord, IAcpFeatureNode targetRecord);
        protected override void OnFinishedRemoveRecord(IAcpFeatureNode record);
        internal void SetValues();

        public override int MaxPool { get; }

        public override int Max { get; set; }

        public override int Min { get; }

        public override int CounterToMax { get; }

        public bool HasDiffs { get; }

        public static int MaxVoiceFilesTotalMS { get; }

        internal static int VoiceFilesTotalMS { get; }
    }
}

