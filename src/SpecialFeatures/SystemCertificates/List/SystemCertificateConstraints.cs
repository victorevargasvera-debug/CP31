namespace SpecialFeatures.SystemCertificates.List
{
    using AcpCommonLib;
    using AcpCommonLib.UndoRedo;
    using System;
    using System.IO;

    internal class SystemCertificateConstraints
    {
        public SystemCertificateConstraints();
        internal static void conSetSystemCertificateFieldsValue(IAcpFeatureSection self, ContainerTask task);
        internal static bool conSetSystemCertificateFieldValidation(IAcpFeatureSection self);
        public static bool ValidateCertificateDataIntegrity(MemoryStream fStream);
    }
}

