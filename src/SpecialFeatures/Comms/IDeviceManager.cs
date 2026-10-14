namespace SpecialFeatures.Comms
{
    using Motorola.Common.Communication.CommonUtil;
    using SSLMangrComp;
    using System;
    using System.Runtime.CompilerServices;

    public interface IDeviceManager
    {
        event EventHandler<DeviceEventArgs> DeviceConnectedEvent;

        event EventHandler<DeviceEventArgs> DeviceLostEvent;

        IDeviceProxy CreateDeviceProxy(RadioParams radioPara, RadioOperation radioOp);
        DeviceInfo[] GetAllConnectedDevice();
        PresenceNotification RetrievePresenceInfo(PNConnectionInfo connectionConfig);
    }
}

