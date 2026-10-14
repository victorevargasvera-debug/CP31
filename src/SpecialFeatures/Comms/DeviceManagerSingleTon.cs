namespace SpecialFeatures.Comms
{
    using System;

    public static class DeviceManagerSingleTon
    {
        private static IDeviceManager a;
        private static object b;

        static DeviceManagerSingleTon();

        public static IDeviceManager Instance { get; }
    }
}

