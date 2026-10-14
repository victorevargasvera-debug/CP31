namespace SpecialFeatures.Comms
{
    using Motorola.Common.Communication.CommonUtil;
    using System;
    using System.Runtime.CompilerServices;

    [Extension]
    public static class Extension
    {
        [Extension]
        internal static DeviceInfo Clone(DeviceInfo deviceInfo);
        [Extension]
        internal static AstroDeviceInfo Deserialize(AstroDeviceInfo astrodeviceInfo, string fileName);
        internal static string GetRadioBBFSuiteVersion(AstroDeviceInfo deviceInfo);
        [Extension]
        internal static string GetSHA256Hash(byte[] data);
        [Extension]
        internal static bool Serialize(AstroDeviceInfo astrodeviceInfo, string fileName);
        [Extension]
        internal static DeviceInfo WrapperDeviceInfo(RadioParams radioPara);
        [Extension]
        internal static RadioParams WrapperRadioParams(AstroDeviceInfo astroDeviceInfo);
    }
}

