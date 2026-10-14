namespace SpecialFeatures.VoiceAnnouncements.Wide
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using Motorola.MackinawCPS.CoreFeatures.RadioWide;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [Serializable]
    public sealed class General : FeatureSection
    {
        private AcpField<bool> siteSelectableAlertAllowedinOutofRange_A42013;
        private AcpSparseLOVField voiceAnnouncementPriority_A7651;
        private AcpField<bool> suppressReplay_A44925;
        private AcpRecRefField scanOnAnnouncementID_A22250;
        private AcpRecRefField scanOffAnnouncementID_A22252;
        private AcpRecRefField monitorOnAnnouncementID_A22254;
        private AcpRecRefField monitorOffAnnouncementID_A22256;
        private AcpRecRefField directModeOnAnnouncementID_A22258;
        private AcpRecRefField directModeOffAnnouncementID_A22121;
        private AcpRecRefField txInhibitOnAnnouncementID_A22260;
        private AcpRecRefField txInhibitOffAnnouncementID_A22262;
        private AcpRecRefField radErgoCfgVAWide_A41497;
        private AcpRecRefField radErgoCfgVAWide_A41499;
        private AcpRecRefField radErgoCfgVAWide_A41500;
        private AcpRecRefField radErgoCfgVAWide_A41501;
        private AcpRecRefField radErgoCfgVAWide_A41502;
        private AcpRecRefField radErgoCfgVAWide_A41503;
        private AcpRecRefField radErgoCfgVAWide_A41504;
        private AcpRecRefField radErgoCfgVAWide_A41505;
        private AcpRecRefField radErgoCfgVAWide_A41506;
        private AcpRecRefField wrongBatteryOnAnnouncementID_43251;
        private AcpField<string> radErgoScanOnAnnouncementVoiceCommand;
        private AcpField<string> radErgoScanOffAnnouncementVoiceCommand;
        private AcpField<string> radErgoMonitorOnVoiceCommand;
        private AcpField<string> radErgoMonitorOffVoiceCommand;
        private AcpField<string> radErgoDirectModeOnVoiceCommand;
        private AcpField<string> radErgoDirectModeOffVoiceCommand;
        private AcpField<string> radErgoTxInhibitOnVoiceCommand;
        private AcpField<string> radErgoTxInhibitOffVoiceCommand;
        private AcpField<string> radErgoEmergencyOnVoiceCommand;
        private AcpField<string> radErgoInCallUserAlertOnVoiceCommand;
        private AcpField<string> radErgoInCallUserAlertOffVoiceCommand;
        private AcpField<string> radErgoSecureTxSelectOnVoiceCommand;
        private AcpField<string> radErgoSecureTxSelectOffVoiceCommand;
        private AcpField<string> radErgoKeyPadControlsLockOnVoiceCommand;
        private AcpField<string> radErgoKeyPadControlsLockOffVoiceCommand;
        private AcpField<string> radErgoMultiFuntionalButtonPrimaryModeCommand;
        private AcpField<string> radErgoMultiFuntionalButtonSecondaryModeCommand;
        private AcpField<string> radErgoWrongBatteryVoiceCommand;
        private AcpRecRefField radErgoCfgVAWideExitHazardZoneMode;
        private AcpField<string> radErgoExitHazardZoneModeAnnouncementVoiceCommand;
        private AcpRecRefField radErgoCfgVAWideSelfCheckFailure;
        private AcpField<string> radErgoSelfCheckFailAnnouncementVoiceCommand;
        private AcpRecRefField radErgoCfgVAWideAccessoryFailure;
        private AcpField<string> radErgoAccessoryFailureAnnouncementVoiceCommand;
        private AcpRecRefField radErgoCfgVAWideOutOfRange;
        private AcpField<string> radErgoOutOfRangeAnnouncementVoiceCommand;
        private AcpRecRefField radErgoCfgVAWideOverTemperature;
        private AcpField<string> radErgoOverTemperatureAnnouncementVoiceCommand;
        private AcpField<string> radErgoPowerDownAnnouncementVoiceCommand;
        private AcpField<string> radErgoAntennaFailureAnnouncementVoiceCommand;
        private AcpRecRefField radErgoCfgVAWidePowerDown;
        private AcpRecRefField radErgoCfgVAWideAntennaFailure;
        private AcpRecRefField radErgoCfgVAWideRFDeviceCumulativeOverTemperature;
        private AcpRecRefField radErgoCfgVAWideOptionalComponentCumulativeOverTemperature;
        private AcpRecRefField radErgoCfgVAWideNonHZMAccessory;
        private AcpRecRefField radErgoCfgVAWideBatteryCumulativeOverTemperature;
        private AcpField<string> radErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand;
        private AcpField<string> radErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand;
        private AcpField<string> radErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand;
        private AcpField<string> radErgoNonHZMAccessoryAnnouncementVoiceCommand;

        internal General(FeatureNode parent);
        internal General(SerializationInfo info, StreamingContext context);
        private IAcpRecordset a(int A_0);
        public override void DropReferences();
        public override void GetObjectData(SerializationInfo info, StreamingContext context);
        public override void Init();
        public override void Init(List<string> producerFields);
        public override void PopulateReferences();
        public override void SetConstraints();
        public override void SetupDependencies();

        public bool HasDiffs { get; }

        public bool SiteSelectableAlertAllowedinOutofRange_A42013Value { get; set; }

        public AcpField<bool> SiteSelectableAlertAllowedinOutofRange_A42013 { get; }

        public bool SiteSelectableAlertAllowedinOutofRange_A42013_UIValue { get; set; }

        public bool SiteSelectableAlertAllowedinOutofRange_A42013_Applicable { get; set; }

        public bool SiteSelectableAlertAllowedinOutofRange_A42013_Valid { get; set; }

        public bool SiteSelectableAlertAllowedinOutofRange_A42013_Visible { get; set; }

        public bool SiteSelectableAlertAllowedinOutofRange_A42013_Editable { get; set; }

        internal string SiteSelectableAlertAllowedinOutofRange_A42013_UILabel { get; }

        internal bool SiteSelectableAlertAllowedinOutofRange_A42013_HiddenStatic { get; set; }

        internal bool SiteSelectableAlertAllowedinOutofRange_A42013_HiddenDynamic { get; set; }

        public bool SiteSelectableAlertAllowedinOutofRange_A42013_HasDiffs { get; }

        public int VoiceAnnouncementPriority_A7651Value { get; set; }

        public string VoiceAnnouncementPriority_A7651_UIValue { get; set; }

        public AcpSparseLOVField VoiceAnnouncementPriority_A7651 { get; }

        public bool VoiceAnnouncementPriority_A7651_Applicable { get; set; }

        public bool VoiceAnnouncementPriority_A7651_Valid { get; set; }

        public bool VoiceAnnouncementPriority_A7651_Visible { get; set; }

        public bool VoiceAnnouncementPriority_A7651_Editable { get; set; }

        internal string VoiceAnnouncementPriority_A7651_UILabel { get; }

        internal bool VoiceAnnouncementPriority_A7651_HiddenStatic { get; set; }

        internal bool VoiceAnnouncementPriority_A7651_HiddenDynamic { get; set; }

        public bool VoiceAnnouncementPriority_A7651_HasDiffs { get; }

        public bool SuppressReplay_A44925Value { get; set; }

        public AcpField<bool> SuppressReplay_A44925 { get; }

        public bool SuppressReplay_A44925_UIValue { get; set; }

        public bool SuppressReplay_A44925_Applicable { get; set; }

        public bool SuppressReplay_A44925_Valid { get; set; }

        public bool SuppressReplay_A44925_Visible { get; set; }

        public bool SuppressReplay_A44925_Editable { get; set; }

        internal string SuppressReplay_A44925_UILabel { get; }

        internal bool SuppressReplay_A44925_HiddenStatic { get; set; }

        internal bool SuppressReplay_A44925_HiddenDynamic { get; set; }

        public bool SuppressReplay_A44925_HasDiffs { get; }

        public int ScanOnAnnouncementID_A22250Value { get; set; }

        public string ScanOnAnnouncementID_A22250_UIValue { get; set; }

        public AcpRecRefField ScanOnAnnouncementID_A22250 { get; }

        public bool ScanOnAnnouncementID_A22250_Applicable { get; set; }

        public bool ScanOnAnnouncementID_A22250_Valid { get; set; }

        public bool ScanOnAnnouncementID_A22250_Visible { get; set; }

        public bool ScanOnAnnouncementID_A22250_Editable { get; set; }

        internal string ScanOnAnnouncementID_A22250_UILabel { get; }

        internal bool ScanOnAnnouncementID_A22250_HiddenStatic { get; set; }

        internal bool ScanOnAnnouncementID_A22250_HiddenDynamic { get; set; }

        public bool ScanOnAnnouncementID_A22250_HasDiffs { get; }

        public int ScanOffAnnouncementID_A22252Value { get; set; }

        public string ScanOffAnnouncementID_A22252_UIValue { get; set; }

        public AcpRecRefField ScanOffAnnouncementID_A22252 { get; }

        public bool ScanOffAnnouncementID_A22252_Applicable { get; set; }

        public bool ScanOffAnnouncementID_A22252_Valid { get; set; }

        public bool ScanOffAnnouncementID_A22252_Visible { get; set; }

        public bool ScanOffAnnouncementID_A22252_Editable { get; set; }

        internal string ScanOffAnnouncementID_A22252_UILabel { get; }

        internal bool ScanOffAnnouncementID_A22252_HiddenStatic { get; set; }

        internal bool ScanOffAnnouncementID_A22252_HiddenDynamic { get; set; }

        public bool ScanOffAnnouncementID_A22252_HasDiffs { get; }

        public int MonitorOnAnnouncementID_A22254Value { get; set; }

        public string MonitorOnAnnouncementID_A22254_UIValue { get; set; }

        public AcpRecRefField MonitorOnAnnouncementID_A22254 { get; }

        public bool MonitorOnAnnouncementID_A22254_Applicable { get; set; }

        public bool MonitorOnAnnouncementID_A22254_Valid { get; set; }

        public bool MonitorOnAnnouncementID_A22254_Visible { get; set; }

        public bool MonitorOnAnnouncementID_A22254_Editable { get; set; }

        internal string MonitorOnAnnouncementID_A22254_UILabel { get; }

        internal bool MonitorOnAnnouncementID_A22254_HiddenStatic { get; set; }

        internal bool MonitorOnAnnouncementID_A22254_HiddenDynamic { get; set; }

        public bool MonitorOnAnnouncementID_A22254_HasDiffs { get; }

        public int MonitorOffAnnouncementID_A22256Value { get; set; }

        public string MonitorOffAnnouncementID_A22256_UIValue { get; set; }

        public AcpRecRefField MonitorOffAnnouncementID_A22256 { get; }

        public bool MonitorOffAnnouncementID_A22256_Applicable { get; set; }

        public bool MonitorOffAnnouncementID_A22256_Valid { get; set; }

        public bool MonitorOffAnnouncementID_A22256_Visible { get; set; }

        public bool MonitorOffAnnouncementID_A22256_Editable { get; set; }

        internal string MonitorOffAnnouncementID_A22256_UILabel { get; }

        internal bool MonitorOffAnnouncementID_A22256_HiddenStatic { get; set; }

        internal bool MonitorOffAnnouncementID_A22256_HiddenDynamic { get; set; }

        public bool MonitorOffAnnouncementID_A22256_HasDiffs { get; }

        public int DirectModeOnAnnouncementID_A22258Value { get; set; }

        public string DirectModeOnAnnouncementID_A22258_UIValue { get; set; }

        public AcpRecRefField DirectModeOnAnnouncementID_A22258 { get; }

        public bool DirectModeOnAnnouncementID_A22258_Applicable { get; set; }

        public bool DirectModeOnAnnouncementID_A22258_Valid { get; set; }

        public bool DirectModeOnAnnouncementID_A22258_Visible { get; set; }

        public bool DirectModeOnAnnouncementID_A22258_Editable { get; set; }

        internal string DirectModeOnAnnouncementID_A22258_UILabel { get; }

        internal bool DirectModeOnAnnouncementID_A22258_HiddenStatic { get; set; }

        internal bool DirectModeOnAnnouncementID_A22258_HiddenDynamic { get; set; }

        public bool DirectModeOnAnnouncementID_A22258_HasDiffs { get; }

        public int DirectModeOffAnnouncementID_A22121Value { get; set; }

        public string DirectModeOffAnnouncementID_A22121_UIValue { get; set; }

        public AcpRecRefField DirectModeOffAnnouncementID_A22121 { get; }

        public bool DirectModeOffAnnouncementID_A22121_Applicable { get; set; }

        public bool DirectModeOffAnnouncementID_A22121_Valid { get; set; }

        public bool DirectModeOffAnnouncementID_A22121_Visible { get; set; }

        public bool DirectModeOffAnnouncementID_A22121_Editable { get; set; }

        internal string DirectModeOffAnnouncementID_A22121_UILabel { get; }

        internal bool DirectModeOffAnnouncementID_A22121_HiddenStatic { get; set; }

        internal bool DirectModeOffAnnouncementID_A22121_HiddenDynamic { get; set; }

        public bool DirectModeOffAnnouncementID_A22121_HasDiffs { get; }

        public int TxInhibitOnAnnouncementID_A22260Value { get; set; }

        public string TxInhibitOnAnnouncementID_A22260_UIValue { get; set; }

        public AcpRecRefField TxInhibitOnAnnouncementID_A22260 { get; }

        public bool TxInhibitOnAnnouncementID_A22260_Applicable { get; set; }

        public bool TxInhibitOnAnnouncementID_A22260_Valid { get; set; }

        public bool TxInhibitOnAnnouncementID_A22260_Visible { get; set; }

        public bool TxInhibitOnAnnouncementID_A22260_Editable { get; set; }

        internal string TxInhibitOnAnnouncementID_A22260_UILabel { get; }

        internal bool TxInhibitOnAnnouncementID_A22260_HiddenStatic { get; set; }

        internal bool TxInhibitOnAnnouncementID_A22260_HiddenDynamic { get; set; }

        public bool TxInhibitOnAnnouncementID_A22260_HasDiffs { get; }

        public int TxInhibitOffAnnouncementID_A22262Value { get; set; }

        public string TxInhibitOffAnnouncementID_A22262_UIValue { get; set; }

        public AcpRecRefField TxInhibitOffAnnouncementID_A22262 { get; }

        public bool TxInhibitOffAnnouncementID_A22262_Applicable { get; set; }

        public bool TxInhibitOffAnnouncementID_A22262_Valid { get; set; }

        public bool TxInhibitOffAnnouncementID_A22262_Visible { get; set; }

        public bool TxInhibitOffAnnouncementID_A22262_Editable { get; set; }

        internal string TxInhibitOffAnnouncementID_A22262_UILabel { get; }

        internal bool TxInhibitOffAnnouncementID_A22262_HiddenStatic { get; set; }

        internal bool TxInhibitOffAnnouncementID_A22262_HiddenDynamic { get; set; }

        public bool TxInhibitOffAnnouncementID_A22262_HasDiffs { get; }

        public int RadErgoCfgVAWide_A41497Value { get; set; }

        public string RadErgoCfgVAWide_A41497_UIValue { get; set; }

        public AcpRecRefField RadErgoCfgVAWide_A41497 { get; }

        public bool RadErgoCfgVAWide_A41497_Applicable { get; set; }

        public bool RadErgoCfgVAWide_A41497_Valid { get; set; }

        public bool RadErgoCfgVAWide_A41497_Visible { get; set; }

        public bool RadErgoCfgVAWide_A41497_Editable { get; set; }

        internal string RadErgoCfgVAWide_A41497_UILabel { get; }

        internal bool RadErgoCfgVAWide_A41497_HiddenStatic { get; set; }

        internal bool RadErgoCfgVAWide_A41497_HiddenDynamic { get; set; }

        public bool RadErgoCfgVAWide_A41497_HasDiffs { get; }

        public int RadErgoCfgVAWide_A41499Value { get; set; }

        public string RadErgoCfgVAWide_A41499_UIValue { get; set; }

        public AcpRecRefField RadErgoCfgVAWide_A41499 { get; }

        public bool RadErgoCfgVAWide_A41499_Applicable { get; set; }

        public bool RadErgoCfgVAWide_A41499_Valid { get; set; }

        public bool RadErgoCfgVAWide_A41499_Visible { get; set; }

        public bool RadErgoCfgVAWide_A41499_Editable { get; set; }

        internal string RadErgoCfgVAWide_A41499_UILabel { get; }

        internal bool RadErgoCfgVAWide_A41499_HiddenStatic { get; set; }

        internal bool RadErgoCfgVAWide_A41499_HiddenDynamic { get; set; }

        public bool RadErgoCfgVAWide_A41499_HasDiffs { get; }

        public int RadErgoCfgVAWide_A41500Value { get; set; }

        public string RadErgoCfgVAWide_A41500_UIValue { get; set; }

        public AcpRecRefField RadErgoCfgVAWide_A41500 { get; }

        public bool RadErgoCfgVAWide_A41500_Applicable { get; set; }

        public bool RadErgoCfgVAWide_A41500_Valid { get; set; }

        public bool RadErgoCfgVAWide_A41500_Visible { get; set; }

        public bool RadErgoCfgVAWide_A41500_Editable { get; set; }

        internal string RadErgoCfgVAWide_A41500_UILabel { get; }

        internal bool RadErgoCfgVAWide_A41500_HiddenStatic { get; set; }

        internal bool RadErgoCfgVAWide_A41500_HiddenDynamic { get; set; }

        public bool RadErgoCfgVAWide_A41500_HasDiffs { get; }

        public int RadErgoCfgVAWide_A41501Value { get; set; }

        public string RadErgoCfgVAWide_A41501_UIValue { get; set; }

        public AcpRecRefField RadErgoCfgVAWide_A41501 { get; }

        public bool RadErgoCfgVAWide_A41501_Applicable { get; set; }

        public bool RadErgoCfgVAWide_A41501_Valid { get; set; }

        public bool RadErgoCfgVAWide_A41501_Visible { get; set; }

        public bool RadErgoCfgVAWide_A41501_Editable { get; set; }

        internal string RadErgoCfgVAWide_A41501_UILabel { get; }

        internal bool RadErgoCfgVAWide_A41501_HiddenStatic { get; set; }

        internal bool RadErgoCfgVAWide_A41501_HiddenDynamic { get; set; }

        public bool RadErgoCfgVAWide_A41501_HasDiffs { get; }

        public int RadErgoCfgVAWide_A41502Value { get; set; }

        public string RadErgoCfgVAWide_A41502_UIValue { get; set; }

        public AcpRecRefField RadErgoCfgVAWide_A41502 { get; }

        public bool RadErgoCfgVAWide_A41502_Applicable { get; set; }

        public bool RadErgoCfgVAWide_A41502_Valid { get; set; }

        public bool RadErgoCfgVAWide_A41502_Visible { get; set; }

        public bool RadErgoCfgVAWide_A41502_Editable { get; set; }

        internal string RadErgoCfgVAWide_A41502_UILabel { get; }

        internal bool RadErgoCfgVAWide_A41502_HiddenStatic { get; set; }

        internal bool RadErgoCfgVAWide_A41502_HiddenDynamic { get; set; }

        public bool RadErgoCfgVAWide_A41502_HasDiffs { get; }

        public int RadErgoCfgVAWide_A41503Value { get; set; }

        public string RadErgoCfgVAWide_A41503_UIValue { get; set; }

        public AcpRecRefField RadErgoCfgVAWide_A41503 { get; }

        public bool RadErgoCfgVAWide_A41503_Applicable { get; set; }

        public bool RadErgoCfgVAWide_A41503_Valid { get; set; }

        public bool RadErgoCfgVAWide_A41503_Visible { get; set; }

        public bool RadErgoCfgVAWide_A41503_Editable { get; set; }

        internal string RadErgoCfgVAWide_A41503_UILabel { get; }

        internal bool RadErgoCfgVAWide_A41503_HiddenStatic { get; set; }

        internal bool RadErgoCfgVAWide_A41503_HiddenDynamic { get; set; }

        public bool RadErgoCfgVAWide_A41503_HasDiffs { get; }

        public int RadErgoCfgVAWide_A41504Value { get; set; }

        public string RadErgoCfgVAWide_A41504_UIValue { get; set; }

        public AcpRecRefField RadErgoCfgVAWide_A41504 { get; }

        public bool RadErgoCfgVAWide_A41504_Applicable { get; set; }

        public bool RadErgoCfgVAWide_A41504_Valid { get; set; }

        public bool RadErgoCfgVAWide_A41504_Visible { get; set; }

        public bool RadErgoCfgVAWide_A41504_Editable { get; set; }

        internal string RadErgoCfgVAWide_A41504_UILabel { get; }

        internal bool RadErgoCfgVAWide_A41504_HiddenStatic { get; set; }

        internal bool RadErgoCfgVAWide_A41504_HiddenDynamic { get; set; }

        public bool RadErgoCfgVAWide_A41504_HasDiffs { get; }

        public int RadErgoCfgVAWide_A41505Value { get; set; }

        public string RadErgoCfgVAWide_A41505_UIValue { get; set; }

        public AcpRecRefField RadErgoCfgVAWide_A41505 { get; }

        public bool RadErgoCfgVAWide_A41505_Applicable { get; set; }

        public bool RadErgoCfgVAWide_A41505_Valid { get; set; }

        public bool RadErgoCfgVAWide_A41505_Visible { get; set; }

        public bool RadErgoCfgVAWide_A41505_Editable { get; set; }

        internal string RadErgoCfgVAWide_A41505_UILabel { get; }

        internal bool RadErgoCfgVAWide_A41505_HiddenStatic { get; set; }

        internal bool RadErgoCfgVAWide_A41505_HiddenDynamic { get; set; }

        public bool RadErgoCfgVAWide_A41505_HasDiffs { get; }

        public int RadErgoCfgVAWide_A41506Value { get; set; }

        public string RadErgoCfgVAWide_A41506_UIValue { get; set; }

        public AcpRecRefField RadErgoCfgVAWide_A41506 { get; }

        public bool RadErgoCfgVAWide_A41506_Applicable { get; set; }

        public bool RadErgoCfgVAWide_A41506_Valid { get; set; }

        public bool RadErgoCfgVAWide_A41506_Visible { get; set; }

        public bool RadErgoCfgVAWide_A41506_Editable { get; set; }

        internal string RadErgoCfgVAWide_A41506_UILabel { get; }

        internal bool RadErgoCfgVAWide_A41506_HiddenStatic { get; set; }

        internal bool RadErgoCfgVAWide_A41506_HiddenDynamic { get; set; }

        public bool RadErgoCfgVAWide_A41506_HasDiffs { get; }

        public int WrongBatteryOnAnnouncementID_43251Value { get; set; }

        public string WrongBatteryOnAnnouncementID_43251_UIValue { get; set; }

        public AcpRecRefField WrongBatteryOnAnnouncementID_43251 { get; }

        public bool WrongBatteryOnAnnouncementID_43251_Applicable { get; set; }

        public bool WrongBatteryOnAnnouncementID_43251_Valid { get; set; }

        public bool WrongBatteryOnAnnouncementID_43251_Visible { get; set; }

        public bool WrongBatteryOnAnnouncementID_43251_Editable { get; set; }

        internal string WrongBatteryOnAnnouncementID_43251_UILabel { get; }

        internal bool WrongBatteryOnAnnouncementID_43251_HiddenStatic { get; set; }

        internal bool WrongBatteryOnAnnouncementID_43251_HiddenDynamic { get; set; }

        public bool WrongBatteryOnAnnouncementID_43251_HasDiffs { get; }

        public string RadErgoScanOnAnnouncementVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoScanOnAnnouncementVoiceCommand { get; }

        public string RadErgoScanOnAnnouncementVoiceCommand_UIValue { get; set; }

        public bool RadErgoScanOnAnnouncementVoiceCommand_Applicable { get; set; }

        public bool RadErgoScanOnAnnouncementVoiceCommand_Valid { get; set; }

        public bool RadErgoScanOnAnnouncementVoiceCommand_Visible { get; set; }

        public bool RadErgoScanOnAnnouncementVoiceCommand_Editable { get; set; }

        internal string RadErgoScanOnAnnouncementVoiceCommand_UILabel { get; }

        internal bool RadErgoScanOnAnnouncementVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoScanOnAnnouncementVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoScanOnAnnouncementVoiceCommand_HasDiffs { get; }

        public string RadErgoScanOffAnnouncementVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoScanOffAnnouncementVoiceCommand { get; }

        public string RadErgoScanOffAnnouncementVoiceCommand_UIValue { get; set; }

        public bool RadErgoScanOffAnnouncementVoiceCommand_Applicable { get; set; }

        public bool RadErgoScanOffAnnouncementVoiceCommand_Valid { get; set; }

        public bool RadErgoScanOffAnnouncementVoiceCommand_Visible { get; set; }

        public bool RadErgoScanOffAnnouncementVoiceCommand_Editable { get; set; }

        internal string radErgoScanOffAnnouncementVoiceCommand_UILabel { get; }

        internal bool RadErgoScanOffAnnouncementVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoScanOffAnnouncementVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoScanOffAnnouncementVoiceCommand_HasDiffs { get; }

        public string RadErgoMonitorOnVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoMonitorOnVoiceCommand { get; }

        public string RadErgoMonitorOnVoiceCommand_UIValue { get; set; }

        public bool RadErgoMonitorOnVoiceCommand_Applicable { get; set; }

        public bool RadErgoMonitorOnVoiceCommand_Valid { get; set; }

        public bool RadErgoMonitorOnVoiceCommand_Visible { get; set; }

        public bool RadErgoMonitorOnVoiceCommand_Editable { get; set; }

        internal string radErgoMonitorOnVoiceCommand_UILabel { get; }

        internal bool RadErgoMonitorOnVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoMonitorOnVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoMonitorOnVoiceCommand_HasDiffs { get; }

        public string RadErgoMonitorOffVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoMonitorOffVoiceCommand { get; }

        public string RadErgoMonitorOffVoiceCommand_UIValue { get; set; }

        public bool RadErgoMonitorOffVoiceCommand_Applicable { get; set; }

        public bool RadErgoMonitorOffVoiceCommand_Valid { get; set; }

        public bool RadErgoMonitorOffVoiceCommand_Visible { get; set; }

        public bool RadErgoMonitorOffVoiceCommand_Editable { get; set; }

        internal string radErgoMonitorOffVoiceCommand_UILabel { get; }

        internal bool RadErgoMonitorOffVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoMonitorOffVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoMonitorOffVoiceCommand_HasDiffs { get; }

        public string RadErgoDirectModeOnVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoDirectModeOnVoiceCommand { get; }

        public string RadErgoDirectModeOnVoiceCommand_UIValue { get; set; }

        public bool RadErgoDirectModeOnVoiceCommand_Applicable { get; set; }

        public bool RadErgoDirectModeOnVoiceCommand_Valid { get; set; }

        public bool RadErgoDirectModeOnVoiceCommand_Visible { get; set; }

        public bool RadErgoDirectModeOnVoiceCommand_Editable { get; set; }

        internal string radErgoDirectModeOnVoiceCommand_UILabel { get; }

        internal bool RadErgoDirectModeOnVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoDirectModeOnVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoDirectModeOnVoiceCommand_HasDiffs { get; }

        public string RadErgoDirectModeOffVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoDirectModeOffVoiceCommand { get; }

        public string RadErgoDirectModeOffVoiceCommand_UIValue { get; set; }

        public bool RadErgoDirectModeOffVoiceCommand_Applicable { get; set; }

        public bool RadErgoDirectModeOffVoiceCommand_Valid { get; set; }

        public bool RadErgoDirectModeOffVoiceCommand_Visible { get; set; }

        public bool RadErgoDirectModeOffVoiceCommand_Editable { get; set; }

        internal string radErgoDirectModeOffVoiceCommand_UILabel { get; }

        internal bool RadErgoDirectModeOffVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoDirectModeOffVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoDirectModeOffVoiceCommand_HasDiffs { get; }

        public string RadErgoTxInhibitOnVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoTxInhibitOnVoiceCommand { get; }

        public string RadErgoTxInhibitOnVoiceCommand_UIValue { get; set; }

        public bool RadErgoTxInhibitOnVoiceCommand_Applicable { get; set; }

        public bool RadErgoTxInhibitOnVoiceCommand_Valid { get; set; }

        public bool RadErgoTxInhibitOnVoiceCommand_Visible { get; set; }

        public bool RadErgoTxInhibitOnVoiceCommand_Editable { get; set; }

        internal string radErgoTxInhibitOnVoiceCommand_UILabel { get; }

        internal bool RadErgoTxInhibitOnVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoTxInhibitOnVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoTxInhibitOnVoiceCommand_HasDiffs { get; }

        public string RadErgoTxInhibitOffVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoTxInhibitOffVoiceCommand { get; }

        public string RadErgoTxInhibitOffVoiceCommand_UIValue { get; set; }

        public bool RadErgoTxInhibitOffVoiceCommand_Applicable { get; set; }

        public bool RadErgoTxInhibitOffVoiceCommand_Valid { get; set; }

        public bool RadErgoTxInhibitOffVoiceCommand_Visible { get; set; }

        public bool RadErgoTxInhibitOffVoiceCommand_Editable { get; set; }

        internal string radErgoTxInhibitOffVoiceCommand_UILabel { get; }

        internal bool RadErgoTxInhibitOffVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoTxInhibitOffVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoTxInhibitOffVoiceCommand_HasDiffs { get; }

        public string RadErgoEmergencyOnVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoEmergencyOnVoiceCommand { get; }

        public string RadErgoEmergencyOnVoiceCommand_UIValue { get; set; }

        public bool RadErgoEmergencyOnVoiceCommand_Applicable { get; set; }

        public bool RadErgoEmergencyOnVoiceCommand_Valid { get; set; }

        public bool RadErgoEmergencyOnVoiceCommand_Visible { get; set; }

        public bool RadErgoEmergencyOnVoiceCommand_Editable { get; set; }

        internal string radErgoEmergencyOnVoiceCommand_UILabel { get; }

        internal bool RadErgoEmergencyOnVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoEmergencyOnVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoEmergencyOnVoiceCommand_HasDiffs { get; }

        public string RadErgoInCallUserAlertOnVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoInCallUserAlertOnVoiceCommand { get; }

        public string RadErgoInCallUserAlertOnVoiceCommand_UIValue { get; set; }

        public bool RadErgoInCallUserAlertOnVoiceCommand_Applicable { get; set; }

        public bool RadErgoInCallUserAlertOnVoiceCommand_Valid { get; set; }

        public bool RadErgoInCallUserAlertOnVoiceCommand_Visible { get; set; }

        public bool RadErgoInCallUserAlertOnVoiceCommand_Editable { get; set; }

        internal string radErgoInCallUserAlertOnVoiceCommand_UILabel { get; }

        internal bool RadErgoInCallUserAlertOnVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoInCallUserAlertOnVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoInCallUserAlertOnVoiceCommand_HasDiffs { get; }

        public string RadErgoInCallUserAlertOffVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoInCallUserAlertOffVoiceCommand { get; }

        public string RadErgoInCallUserAlertOffVoiceCommand_UIValue { get; set; }

        public bool RadErgoInCallUserAlertOffVoiceCommand_Applicable { get; set; }

        public bool RadErgoInCallUserAlertOffVoiceCommand_Valid { get; set; }

        public bool RadErgoInCallUserAlertOffVoiceCommand_Visible { get; set; }

        public bool RadErgoInCallUserAlertOffVoiceCommand_Editable { get; set; }

        internal string radErgoInCallUserAlertOffVoiceCommand_UILabel { get; }

        internal bool RadErgoInCallUserAlertOffVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoInCallUserAlertOffVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoInCallUserAlertOffVoiceCommand_HasDiffs { get; }

        public string RadErgoSecureTxSelectOnVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoSecureTxSelectOnVoiceCommand { get; }

        public string RadErgoSecureTxSelectOnVoiceCommand_UIValue { get; set; }

        public bool RadErgoSecureTxSelectOnVoiceCommand_Applicable { get; set; }

        public bool RadErgoSecureTxSelectOnVoiceCommand_Valid { get; set; }

        public bool RadErgoSecureTxSelectOnVoiceCommand_Visible { get; set; }

        public bool RadErgoSecureTxSelectOnVoiceCommand_Editable { get; set; }

        internal string radErgoSecureTxSelectOnVoiceCommand_UILabel { get; }

        internal bool RadErgoSecureTxSelectOnVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoSecureTxSelectOnVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoSecureTxSelectOnVoiceCommand_HasDiffs { get; }

        public string RadErgoSecureTxSelectOffVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoSecureTxSelectOffVoiceCommand { get; }

        public string RadErgoSecureTxSelectOffVoiceCommand_UIValue { get; set; }

        public bool RadErgoSecureTxSelectOffVoiceCommand_Applicable { get; set; }

        public bool RadErgoSecureTxSelectOffVoiceCommand_Valid { get; set; }

        public bool RadErgoSecureTxSelectOffVoiceCommand_Visible { get; set; }

        public bool RadErgoSecureTxSelectOffVoiceCommand_Editable { get; set; }

        internal string radErgoSecureTxSelectOffVoiceCommand_UILabel { get; }

        internal bool RadErgoSecureTxSelectOffVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoSecureTxSelectOffVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoSecureTxSelectOffVoiceCommand_HasDiffs { get; }

        public string RadErgoKeyPadControlsLockOnVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoKeyPadControlsLockOnVoiceCommand { get; }

        public string RadErgoKeyPadControlsLockOnVoiceCommand_UIValue { get; set; }

        public bool RadErgoKeyPadControlsLockOnVoiceCommand_Applicable { get; set; }

        public bool RadErgoKeyPadControlsLockOnVoiceCommand_Valid { get; set; }

        public bool RadErgoKeyPadControlsLockOnVoiceCommand_Visible { get; set; }

        public bool RadErgoKeyPadControlsLockOnVoiceCommand_Editable { get; set; }

        internal string radErgoKeyPadControlsLockOnVoiceCommand_UILabel { get; }

        internal bool RadErgoKeyPadControlsLockOnVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoKeyPadControlsLockOnVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoKeyPadControlsLockOnVoiceCommand_HasDiffs { get; }

        public string RadErgoKeyPadControlsLockOffVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoKeyPadControlsLockOffVoiceCommand { get; }

        public string RadErgoKeyPadControlsLockOffVoiceCommand_UIValue { get; set; }

        public bool RadErgoKeyPadControlsLockOffVoiceCommand_Applicable { get; set; }

        public bool RadErgoKeyPadControlsLockOffVoiceCommand_Valid { get; set; }

        public bool RadErgoKeyPadControlsLockOffVoiceCommand_Visible { get; set; }

        public bool RadErgoKeyPadControlsLockOffVoiceCommand_Editable { get; set; }

        internal string radErgoKeyPadControlsLockOffVoiceCommand_UILabel { get; }

        internal bool RadErgoKeyPadControlsLockOffVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoKeyPadControlsLockOffVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoKeyPadControlsLockOffVoiceCommand_HasDiffs { get; }

        public string RadErgoMultiFuntionalButtonPrimaryModeCommandValue { get; set; }

        public AcpField<string> RadErgoMultiFuntionalButtonPrimaryModeCommand { get; }

        public string RadErgoMultiFuntionalButtonPrimaryModeCommand_UIValue { get; set; }

        public bool RadErgoMultiFuntionalButtonPrimaryModeCommand_Applicable { get; set; }

        public bool RadErgoMultiFuntionalButtonPrimaryModeCommand_Valid { get; set; }

        public bool RadErgoMultiFuntionalButtonPrimaryModeCommand_Visible { get; set; }

        public bool RadErgoMultiFuntionalButtonPrimaryModeCommand_Editable { get; set; }

        internal string radErgoMultiFuntionalButtonPrimaryModeCommand_UILabel { get; }

        internal bool RadErgoMultiFuntionalButtonPrimaryModeCommand_HiddenStatic { get; set; }

        internal bool RadErgoMultiFuntionalButtonPrimaryModeCommand_HiddenDynamic { get; set; }

        public bool RadErgoMultiFuntionalButtonPrimaryModeCommand_HasDiffs { get; }

        public string RadErgoMultiFuntionalButtonSecondaryModeCommandValue { get; set; }

        public AcpField<string> RadErgoMultiFuntionalButtonSecondaryModeCommand { get; }

        public string RadErgoMultiFuntionalButtonSecondaryModeCommand_UIValue { get; set; }

        public bool RadErgoMultiFuntionalButtonSecondaryModeCommand_Applicable { get; set; }

        public bool RadErgoMultiFuntionalButtonSecondaryModeCommand_Valid { get; set; }

        public bool RadErgoMultiFuntionalButtonSecondaryModeCommand_Visible { get; set; }

        public bool RadErgoMultiFuntionalButtonSecondaryModeCommand_Editable { get; set; }

        internal string radErgoMultiFuntionalButtonSecondaryModeCommand_UILabel { get; }

        internal bool RadErgoMultiFuntionalButtonSecondaryModeCommand_HiddenStatic { get; set; }

        internal bool RadErgoMultiFuntionalButtonSecondaryModeCommand_HiddenDynamic { get; set; }

        public bool RadErgoMultiFuntionalButtonSecondaryModeCommand_HasDiffs { get; }

        public string RadErgoWrongBatteryVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoWrongBatteryVoiceCommand { get; }

        public string RadErgoWrongBatteryVoiceCommand_UIValue { get; set; }

        public bool RadErgoWrongBatteryVoiceCommand_Applicable { get; set; }

        public bool RadErgoWrongBatteryVoiceCommand_Valid { get; set; }

        public bool RadErgoWrongBatteryVoiceCommand_Visible { get; set; }

        public bool RadErgoWrongBatteryVoiceCommand_Editable { get; set; }

        internal string radErgoWrongBatteryVoiceCommand_UILabel { get; }

        internal bool RadErgoWrongBatteryVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoWrongBatteryVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoWrongBatteryVoiceCommand_HasDiffs { get; }

        public int RadErgoCfgVAWideExitHazardZoneModeValue { get; set; }

        public string RadErgoCfgVAWideExitHazardZoneMode_UIValue { get; set; }

        public AcpRecRefField RadErgoCfgVAWideExitHazardZoneMode { get; }

        public bool RadErgoCfgVAWideExitHazardZoneMode_Applicable { get; set; }

        public bool RadErgoCfgVAWideExitHazardZoneMode_Valid { get; set; }

        public bool RadErgoCfgVAWideExitHazardZoneMode_Visible { get; set; }

        public bool RadErgoCfgVAWideExitHazardZoneMode_Editable { get; set; }

        internal string RadErgoCfgVAWideExitHazardZoneMode_UILabel { get; }

        internal bool RadErgoCfgVAWideExitHazardZoneMode_HiddenStatic { get; set; }

        internal bool RadErgoCfgVAWideExitHazardZoneMode_HiddenDynamic { get; set; }

        public bool RadErgoCfgVAWideExitHazardZoneMode_HasDiffs { get; }

        public string RadErgoExitHazardZoneModeAnnouncementVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoExitHazardZoneModeAnnouncementVoiceCommand { get; }

        public string RadErgoExitHazardZoneModeAnnouncementVoiceCommand_UIValue { get; set; }

        public bool RadErgoExitHazardZoneModeAnnouncementVoiceCommand_Applicable { get; set; }

        public bool RadErgoExitHazardZoneModeAnnouncementVoiceCommand_Valid { get; set; }

        public bool RadErgoExitHazardZoneModeAnnouncementVoiceCommand_Visible { get; set; }

        public bool RadErgoExitHazardZoneModeAnnouncementVoiceCommand_Editable { get; set; }

        internal string RadErgoExitHazardZoneModeAnnouncementVoiceCommand_UILabel { get; }

        internal bool RadErgoExitHazardZoneModeAnnouncementVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoExitHazardZoneModeAnnouncementVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoExitHazardZoneModeAnnouncementVoiceCommand_HasDiffs { get; }

        public int RadErgoCfgVAWideSelfCheckFailureValue { get; set; }

        public string RadErgoCfgVAWideSelfCheckFailure_UIValue { get; set; }

        public AcpRecRefField RadErgoCfgVAWideSelfCheckFailure { get; }

        public bool RadErgoCfgVAWideSelfCheckFailure_Applicable { get; set; }

        public bool RadErgoCfgVAWideSelfCheckFailure_Valid { get; set; }

        public bool RadErgoCfgVAWideSelfCheckFailure_Visible { get; set; }

        public bool RadErgoCfgVAWideSelfCheckFailure_Editable { get; set; }

        internal string RadErgoCfgVAWideSelfCheckFailure_UILabel { get; }

        internal bool RadErgoCfgVAWideSelfCheckFailure_HiddenStatic { get; set; }

        internal bool RadErgoCfgVAWideSelfCheckFailure_HiddenDynamic { get; set; }

        public bool RadErgoCfgVAWideSelfCheckFailure_HasDiffs { get; }

        public string RadErgoSelfCheckFailAnnouncementVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoSelfCheckFailAnnouncementVoiceCommand { get; }

        public string RadErgoSelfCheckFailAnnouncementVoiceCommand_UIValue { get; set; }

        public bool RadErgoSelfCheckFailAnnouncementVoiceCommand_Applicable { get; set; }

        public bool RadErgoSelfCheckFailAnnouncementVoiceCommand_Valid { get; set; }

        public bool RadErgoSelfCheckFailAnnouncementVoiceCommand_Visible { get; set; }

        public bool RadErgoSelfCheckFailAnnouncementVoiceCommand_Editable { get; set; }

        internal string radErgoSelfCheckFailAnnouncementVoiceCommand_UILabel { get; }

        internal bool RadErgoSelfCheckFailAnnouncementVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoSelfCheckFailAnnouncementVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoSelfCheckFailAnnouncementVoiceCommand_HasDiffs { get; }

        public int RadErgoCfgVAWideAccessoryFailureValue { get; set; }

        public string RadErgoCfgVAWideAccessoryFailure_UIValue { get; set; }

        public AcpRecRefField RadErgoCfgVAWideAccessoryFailure { get; }

        public bool RadErgoCfgVAWideAccessoryFailure_Applicable { get; set; }

        public bool RadErgoCfgVAWideAccessoryFailure_Valid { get; set; }

        public bool RadErgoCfgVAWideAccessoryFailure_Visible { get; set; }

        public bool RadErgoCfgVAWideAccessoryFailure_Editable { get; set; }

        internal string RadErgoCfgVAWideAccessoryFailure_UILabel { get; }

        internal bool RadErgoCfgVAWideAccessoryFailure_HiddenStatic { get; set; }

        internal bool RadErgoCfgVAWideAccessoryFailure_HiddenDynamic { get; set; }

        public bool RadErgoCfgVAWideAccessoryFailure_HasDiffs { get; }

        public string RadErgoAccessoryFailureAnnouncementVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoAccessoryFailureAnnouncementVoiceCommand { get; }

        public string RadErgoAccessoryFailureAnnouncementVoiceCommand_UIValue { get; set; }

        public bool RadErgoAccessoryFailureAnnouncementVoiceCommand_Applicable { get; set; }

        public bool RadErgoAccessoryFailureAnnouncementVoiceCommand_Valid { get; set; }

        public bool RadErgoAccessoryFailureAnnouncementVoiceCommand_Visible { get; set; }

        public bool RadErgoAccessoryFailureAnnouncementVoiceCommand_Editable { get; set; }

        internal string RadErgoAccessoryFailureAnnouncementVoiceCommand_UILabel { get; }

        internal bool RadErgoAccessoryFailureAnnouncementVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoAccessoryFailureAnnouncementVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoAccessoryFailureAnnouncementVoiceCommand_HasDiffs { get; }

        public int RadErgoCfgVAWideOutOfRangeValue { get; set; }

        public string RadErgoCfgVAWideOutOfRange_UIValue { get; set; }

        public AcpRecRefField RadErgoCfgVAWideOutOfRange { get; }

        public bool RadErgoCfgVAWideOutOfRange_Applicable { get; set; }

        public bool RadErgoCfgVAWideOutOfRange_Valid { get; set; }

        public bool RadErgoCfgVAWideOutOfRange_Visible { get; set; }

        public bool RadErgoCfgVAWideOutOfRange_Editable { get; set; }

        internal string RadErgoCfgVAWideOutOfRange_UILabel { get; }

        internal bool RadErgoCfgVAWideOutOfRange_HiddenStatic { get; set; }

        internal bool RadErgoCfgVAWideOutOfRange_HiddenDynamic { get; set; }

        public bool RadErgoCfgVAWideOutOfRange_HasDiffs { get; }

        public string RadErgoOutOfRangeAnnouncementVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoOutOfRangeAnnouncementVoiceCommand { get; }

        public string RadErgoOutOfRangeAnnouncementVoiceCommand_UIValue { get; set; }

        public bool RadErgoOutOfRangeAnnouncementVoiceCommand_Applicable { get; set; }

        public bool RadErgoOutOfRangeAnnouncementVoiceCommand_Valid { get; set; }

        public bool RadErgoOutOfRangeAnnouncementVoiceCommand_Visible { get; set; }

        public bool RadErgoOutOfRangeAnnouncementVoiceCommand_Editable { get; set; }

        internal string RadErgoOutOfRangeAnnouncementVoiceCommand_UILabel { get; }

        internal bool RadErgoOutOfRangeAnnouncementVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoOutOfRangeAnnouncementVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoOutOfRangeAnnouncementVoiceCommand_HasDiffs { get; }

        public int RadErgoCfgVAWideOverTemperatureValue { get; set; }

        public string RadErgoCfgVAWideOverTemperature_UIValue { get; set; }

        public AcpRecRefField RadErgoCfgVAWideOverTemperature { get; }

        public bool RadErgoCfgVAWideOverTemperature_Applicable { get; set; }

        public bool RadErgoCfgVAWideOverTemperature_Valid { get; set; }

        public bool RadErgoCfgVAWideOverTemperature_Visible { get; set; }

        public bool RadErgoCfgVAWideOverTemperature_Editable { get; set; }

        internal string RadErgoCfgVAWideOverTemperature_UILabel { get; }

        internal bool RadErgoCfgVAWideOverTemperature_HiddenStatic { get; set; }

        internal bool RadErgoCfgVAWideOverTemperature_HiddenDynamic { get; set; }

        public bool RadErgoCfgVAWideOverTemperature_HasDiffs { get; }

        public string RadErgoOverTemperatureAnnouncementVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoOverTemperatureAnnouncementVoiceCommand { get; }

        public string RadErgoOverTemperatureAnnouncementVoiceCommand_UIValue { get; set; }

        public bool RadErgoOverTemperatureAnnouncementVoiceCommand_Applicable { get; set; }

        public bool RadErgoOverTemperatureAnnouncementVoiceCommand_Valid { get; set; }

        public bool RadErgoOverTemperatureAnnouncementVoiceCommand_Visible { get; set; }

        public bool RadErgoOverTemperatureAnnouncementVoiceCommand_Editable { get; set; }

        internal string RadErgoOverTemperatureAnnouncementVoiceCommand_UILabel { get; }

        internal bool RadErgoOverTemperatureAnnouncementVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoOverTemperatureAnnouncementVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoOverTemperatureAnnouncementVoiceCommand_HasDiffs { get; }

        public string RadErgoPowerDownAnnouncementVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoPowerDownAnnouncementVoiceCommand { get; }

        public string RadErgoPowerDownAnnouncementVoiceCommand_UIValue { get; set; }

        public bool RadErgoPowerDownAnnouncementVoiceCommand_Applicable { get; set; }

        public bool RadErgoPowerDownAnnouncementVoiceCommand_Valid { get; set; }

        public bool RadErgoPowerDownAnnouncementVoiceCommand_Visible { get; set; }

        public bool RadErgoPowerDownAnnouncementVoiceCommand_Editable { get; set; }

        internal string RadErgoPowerDownAnnouncementVoiceCommand_UILabel { get; }

        internal bool RadErgoPowerDownAnnouncementVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoPowerDownAnnouncementVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoPowerDownAnnouncementVoiceCommand_HasDiffs { get; }

        public string RadErgoAntennaFailureAnnouncementVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoAntennaFailureAnnouncementVoiceCommand { get; }

        public string RadErgoAntennaFailureAnnouncementVoiceCommand_UIValue { get; set; }

        public bool RadErgoAntennaFailureAnnouncementVoiceCommand_Applicable { get; set; }

        public bool RadErgoAntennaFailureAnnouncementVoiceCommand_Valid { get; set; }

        public bool RadErgoAntennaFailureAnnouncementVoiceCommand_Visible { get; set; }

        public bool RadErgoAntennaFailureAnnouncementVoiceCommand_Editable { get; set; }

        internal string RadErgoAntennaFailureAnnouncementVoiceCommand_UILabel { get; }

        internal bool RadErgoAntennaFailureAnnouncementVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoAntennaFailureAnnouncementVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoAntennaFailureAnnouncementVoiceCommand_HasDiffs { get; }

        public int RadErgoCfgVAWidePowerDownValue { get; set; }

        public string RadErgoCfgVAWidePowerDown_UIValue { get; set; }

        public AcpRecRefField RadErgoCfgVAWidePowerDown { get; }

        public bool RadErgoCfgVAWidePowerDown_Applicable { get; set; }

        public bool RadErgoCfgVAWidePowerDown_Valid { get; set; }

        public bool RadErgoCfgVAWidePowerDown_Visible { get; set; }

        public bool RadErgoCfgVAWidePowerDown_Editable { get; set; }

        internal string RadErgoCfgVAWidePowerDown_UILabel { get; }

        internal bool RadErgoCfgVAWidePowerDown_HiddenStatic { get; set; }

        internal bool RadErgoCfgVAWidePowerDown_HiddenDynamic { get; set; }

        public bool RadErgoCfgVAWidePowerDown_HasDiffs { get; }

        public int RadErgoCfgVAWideAntennaFailureValue { get; set; }

        public string RadErgoCfgVAWideAntennaFailure_UIValue { get; set; }

        public AcpRecRefField RadErgoCfgVAWideAntennaFailure { get; }

        public bool RadErgoCfgVAWideAntennaFailure_Applicable { get; set; }

        public bool RadErgoCfgVAWideAntennaFailure_Valid { get; set; }

        public bool RadErgoCfgVAWideAntennaFailure_Visible { get; set; }

        public bool RadErgoCfgVAWideAntennaFailure_Editable { get; set; }

        internal string RadErgoCfgVAWideAntennaFailure_UILabel { get; }

        internal bool RadErgoCfgVAWideAntennaFailure_HiddenStatic { get; set; }

        internal bool RadErgoCfgVAWideAntennaFailure_HiddenDynamic { get; set; }

        public bool RadErgoCfgVAWideAntennaFailure_HasDiffs { get; }

        public int RadErgoCfgVAWideRFDeviceCumulativeOverTemperatureValue { get; set; }

        public string RadErgoCfgVAWideRFDeviceCumulativeOverTemperature_UIValue { get; set; }

        public AcpRecRefField RadErgoCfgVAWideRFDeviceCumulativeOverTemperature { get; }

        public bool RadErgoCfgVAWideRFDeviceCumulativeOverTemperature_Applicable { get; set; }

        public bool RadErgoCfgVAWideRFDeviceCumulativeOverTemperature_Valid { get; set; }

        public bool RadErgoCfgVAWideRFDeviceCumulativeOverTemperature_Visible { get; set; }

        public bool RadErgoCfgVAWideRFDeviceCumulativeOverTemperature_Editable { get; set; }

        internal string RadErgoCfgVAWideRFDeviceCumulativeOverTemperature_UILabel { get; }

        internal bool RadErgoCfgVAWideRFDeviceCumulativeOverTemperature_HiddenStatic { get; set; }

        internal bool RadErgoCfgVAWideRFDeviceCumulativeOverTemperature_HiddenDynamic { get; set; }

        public bool RadErgoCfgVAWideRFDeviceCumulativeOverTemperature_HasDiffs { get; }

        public int RadErgoCfgVAWideOptionalComponentCumulativeOverTemperatureValue { get; set; }

        public string RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature_UIValue { get; set; }

        public AcpRecRefField RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature { get; }

        public bool RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature_Applicable { get; set; }

        public bool RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature_Valid { get; set; }

        public bool RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature_Visible { get; set; }

        public bool RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature_Editable { get; set; }

        internal string RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature_UILabel { get; }

        internal bool RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature_HiddenStatic { get; set; }

        internal bool RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature_HiddenDynamic { get; set; }

        public bool RadErgoCfgVAWideOptionalComponentCumulativeOverTemperature_HasDiffs { get; }

        public int RadErgoCfgVAWideNonHZMAccessoryValue { get; set; }

        public string RadErgoCfgVAWideNonHZMAccessory_UIValue { get; set; }

        public AcpRecRefField RadErgoCfgVAWideNonHZMAccessory { get; }

        public bool RadErgoCfgVAWideNonHZMAccessory_Applicable { get; set; }

        public bool RadErgoCfgVAWideNonHZMAccessory_Valid { get; set; }

        public bool RadErgoCfgVAWideNonHZMAccessory_Visible { get; set; }

        public bool RadErgoCfgVAWideNonHZMAccessory_Editable { get; set; }

        internal string RadErgoCfgVAWideNonHZMAccessory_UILabel { get; }

        internal bool RadErgoCfgVAWideNonHZMAccessory_HiddenStatic { get; set; }

        internal bool RadErgoCfgVAWideNonHZMAccessory_HiddenDynamic { get; set; }

        public bool RadErgoCfgVAWideNonHZMAccessory_HasDiffs { get; }

        public int RadErgoCfgVAWideBatteryCumulativeOverTemperatureValue { get; set; }

        public string RadErgoCfgVAWideBatteryCumulativeOverTemperature_UIValue { get; set; }

        public AcpRecRefField RadErgoCfgVAWideBatteryCumulativeOverTemperature { get; }

        public bool RadErgoCfgVAWideBatteryCumulativeOverTemperature_Applicable { get; set; }

        public bool RadErgoCfgVAWideBatteryCumulativeOverTemperature_Valid { get; set; }

        public bool RadErgoCfgVAWideBatteryCumulativeOverTemperature_Visible { get; set; }

        public bool RadErgoCfgVAWideBatteryCumulativeOverTemperature_Editable { get; set; }

        internal string RadErgoCfgVAWideBatteryCumulativeOverTemperature_UILabel { get; }

        internal bool RadErgoCfgVAWideBatteryCumulativeOverTemperature_HiddenStatic { get; set; }

        internal bool RadErgoCfgVAWideBatteryCumulativeOverTemperature_HiddenDynamic { get; set; }

        public bool RadErgoCfgVAWideBatteryCumulativeOverTemperature_HasDiffs { get; }

        public string RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand { get; }

        public string RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand_UIValue { get; set; }

        public bool RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand_Applicable { get; set; }

        public bool RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand_Valid { get; set; }

        public bool RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand_Visible { get; set; }

        public bool RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand_Editable { get; set; }

        internal string RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand_UILabel { get; }

        internal bool RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoRfDeviceCumulativeOverTemperatureAnnouncementVoiceCommand_HasDiffs { get; }

        public string RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand { get; }

        public string RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand_UIValue { get; set; }

        public bool RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand_Applicable { get; set; }

        public bool RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand_Valid { get; set; }

        public bool RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand_Visible { get; set; }

        public bool RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand_Editable { get; set; }

        internal string RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand_UILabel { get; }

        internal bool RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoOptionalComponentCumulativeOverTemperatureAnnouncementVoiceCommand_HasDiffs { get; }

        public string RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand { get; }

        public string RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand_UIValue { get; set; }

        public bool RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand_Applicable { get; set; }

        public bool RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand_Valid { get; set; }

        public bool RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand_Visible { get; set; }

        public bool RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand_Editable { get; set; }

        internal string RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand_UILabel { get; }

        internal bool RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoBatteryCumulativeOverTemperatureAnnouncementVoiceCommand_HasDiffs { get; }

        public string RadErgoNonHZMAccessoryAnnouncementVoiceCommandValue { get; set; }

        public AcpField<string> RadErgoNonHZMAccessoryAnnouncementVoiceCommand { get; }

        public string RadErgoNonHZMAccessoryAnnouncementVoiceCommand_UIValue { get; set; }

        public bool RadErgoNonHZMAccessoryAnnouncementVoiceCommand_Applicable { get; set; }

        public bool RadErgoNonHZMAccessoryAnnouncementVoiceCommand_Valid { get; set; }

        public bool RadErgoNonHZMAccessoryAnnouncementVoiceCommand_Visible { get; set; }

        public bool RadErgoNonHZMAccessoryAnnouncementVoiceCommand_Editable { get; set; }

        internal string RadErgoNonHZMAccessoryAnnouncementVoiceCommand_UILabel { get; }

        internal bool RadErgoNonHZMAccessoryAnnouncementVoiceCommand_HiddenStatic { get; set; }

        internal bool RadErgoNonHZMAccessoryAnnouncementVoiceCommand_HiddenDynamic { get; set; }

        public bool RadErgoNonHZMAccessoryAnnouncementVoiceCommand_HasDiffs { get; }

        public string TTSTargetSpeaker { get; }

        public Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide { get; }
    }
}

