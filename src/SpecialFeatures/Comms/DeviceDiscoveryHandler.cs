namespace SpecialFeatures.Comms
{
    using Motorola.Common.Communication.CommonUtil;
    using Motorola.Common.Communication.Service;
    using System;
    using System.Runtime.CompilerServices;
    using System.ServiceModel;

    [CallbackBehavior(UseSynchronizationContext=false)]
    public class DeviceDiscoveryHandler : IDiscoveryServiceEvent
    {
        [CompilerGenerated]
        private EventHandler<DeviceEventArgs> a;
        [CompilerGenerated]
        private EventHandler<DeviceEventArgs> b;

        public DeviceDiscoveryHandler();
        public void OnDeviceConnected(DeviceEventArgs args);
        public void OnDeviceLost(DeviceEventArgs args);
        public void OnDeviceSwitchOver(SwitchOverEventArgs args);
        public void OnMasterSystemLost(DeviceEventArgs args);

        internal EventHandler<DeviceEventArgs> DeviceConnectedEventHandler { get; set; }

        internal EventHandler<DeviceEventArgs> DeviceLostEventHandler { get; set; }
    }
}

