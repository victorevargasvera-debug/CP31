namespace SpecialFeatures.Flashport.FlashRadio.ApxNext
{
    using SpecialFeatures.Flashport.FlashRadio;
    using System;

    public class MetadataFileValidator
    {
        private const int a = 3;
        private const string b = "_";
        private const string c = "full";
        private const string d = "differential";
        private const string e = "bp_update";

        public MetadataFileValidator();
        private static void a(MetadataFile A_0);
        public static void VerifyAllowedTargetDevice(MetadataFile metadataFile, string targetDeviceCode);
        public static bool VerifyIsTargetDevice(MetadataFile metadataFile, string targetDeviceCode);
        public static void VerifyMetadataFileContent(MetadataFile metadataFile);
    }
}

