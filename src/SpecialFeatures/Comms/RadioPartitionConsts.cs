namespace SpecialFeatures.Comms
{
    using System;

    public class RadioPartitionConsts
    {
        internal const byte constAppPart = 0xd0;
        internal const ushort constAstroCmpType = 0x406;
        internal const byte constSecurityPart = 0xd4;
        internal const ushort constTrkSysCdaType = 0xf0c;
        internal const ushort constTrkAlsTxt = 0x438;
        internal const ushort constTrkAlsTxtLstCap = 0xff;
        internal const ushort constFDB = 0x385;
        internal const ushort constSecKmfProfType = 0xf13;
        internal const ushort constSecKmfProfAlsTxt = 0x43c;
        internal const ushort constSecKmfProfAlsTxtLstCap = 0xff;
        internal const ushort constRadWideCmpType = 0x402;
        internal const ushort constPasswordType = 0x405;
        internal const ushort constAskKeyListHeaderID = 0x426;
        internal const ushort constCnvSysCmpType = 0xf1c;
        internal const ushort constCnvSysAlsTxt = 0x434;
        internal const ushort constCnvSysAlsTxtLstCap = 0xff;
        internal const ushort constDataProfCmpType = 0xf53;
        internal const ushort constDataProfAlsTxt = 0x431;
        internal const ushort constDataConfigCmpType = 0x403;
        internal const ushort constDataProfAlsTxtLstCap = 0xff;
        internal const ushort constSoftId = 0x445;
        internal const ushort constRadioWidePin = 0x404;
        internal const ushort constRadioAlias = 0x402;
        internal const ushort constBluetoothCmpType = 0x471;
        internal const ushort constMDFCmpType = 0x387;
        internal const ushort constRadioWideLoginUnitID = 0x47a;
        internal const ushort constRadAppInfoCmpType = 0x401;
        internal const ushort constRadProtectionInfoCmpType = 900;
        internal const ushort constEncryptedPINPSWDCmpType = 0x47e;
        internal const ushort constOnPremBlockType = 0x495;

        public RadioPartitionConsts();
    }
}

