namespace SpecialFeatures.Programming
{
    using System;

    public class OTAPPrescenceResult
    {
        private OTAP_SUBSCRIBER_NETWORK_PRESCENCE a;
        private string b;
        private string c;
        private string d;

        public OTAPPrescenceResult(OTAP_SUBSCRIBER_NETWORK_PRESCENCE subscriber_prescence, string subscriber_deviceID, string foundIPAddress, string pnErr);

        internal OTAP_SUBSCRIBER_NETWORK_PRESCENCE DevicePrescence { get; }

        internal string DeviceID { get; }

        internal string DeviceIPAddress { get; }

        internal string NetworkError { get; }
    }
}

