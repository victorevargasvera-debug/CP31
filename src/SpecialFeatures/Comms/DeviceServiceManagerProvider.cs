namespace SpecialFeatures.Comms
{
    using Motorola.Common.Communication.Service;
    using System;

    public class DeviceServiceManagerProvider
    {
        private static readonly Lazy<DeviceServiceManager> a;

        static DeviceServiceManagerProvider();
        public DeviceServiceManagerProvider();
        private static DeviceServiceManager a();

        public static DeviceServiceManager Instance { get; }
    }
}

