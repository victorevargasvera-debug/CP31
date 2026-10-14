namespace SpecialFeatures.AcpReportManagerLib
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class ReportsSerializeItems : ISerializable
    {
        internal Dictionary<string, int> sField;

        public ReportsSerializeItems();
        internal ReportsSerializeItems(SerializationInfo info, StreamingContext context);
        public void GetObjectData(SerializationInfo info, StreamingContext context);
    }
}

