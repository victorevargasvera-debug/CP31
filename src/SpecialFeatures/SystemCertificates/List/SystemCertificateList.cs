namespace SpecialFeatures.SystemCertificates.List
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class SystemCertificateList : FeatureNode
    {
        internal SystemCertificateList(Recordset parent);
        protected SystemCertificateList(SerializationInfo info, StreamingContext context);
        internal static IAcpFeatureNode GetSystemCertificate();

        public SystemCertificateGeneralSection General { get; }
    }
}

