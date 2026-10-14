namespace SpecialFeatures.Comms
{
    using System;

    public enum COMMS_OP
    {
        public const COMMS_OP USB_READ_WRITE = 1;,
        public const COMMS_OP USB_CLONE = 2;,
        public const COMMS_OP OTAP_READ_WRITE = 8;,
        public const COMMS_OP OTAP_CLONE = 10;,
        public const COMMS_OP BLUETOOTH_READ_WRITE = 0x10;,
        public const COMMS_OP BLUETOOTH_CLONE = 0x20;
    }
}

