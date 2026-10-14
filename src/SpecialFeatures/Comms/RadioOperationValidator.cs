namespace SpecialFeatures.Comms
{
    using Motorola.Common.Communication.Pba;
    using Motorola.CommonCPS.Server.EntityModel;
    using SpecialFeatures.Security;
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    public static class RadioOperationValidator
    {
        private static string a(string A_0);
        private static bool a(int A_0, int A_1, out TrkSysBandPlan A_2);
        internal static void CheckAndReviseBlockList(List<IshHeader> blockList);
        internal static void CompareRadioParams(RadioParams codeplug, RadioParams radio, COMMS_OP writeType);
        internal static bool FlashCodeMatch(string radioFlashInfo, string codeplgFlashInfo);
        internal static bool Is800MHzBandEnabledInRadio(RadioParams curRadioParms, PbaObject pba);
        public static bool IsRadioConvOnly(string modelNumber, string flashCode, bool fromCodeplug);
        internal static bool PerformCompatibilityChecks(PbaObject pba, string cpgModelNumber, string radioModelNumber, ref string stsErrMsg);
        public static ValidationField PopulateLanguageSettingValidationField(PbaObject xpbaCodeplug);
        public static List<ValidationInfo> PopulateLPValidationInfos(PbaObject xpbaCodeplug, APXCodeplug currentcp);
        public static List<ValidationField> PopulateUpgradeValidationFields(PbaObject xpbaCodeplug);
        public static List<ValidationInfo> PopulateUpgradeValidationInfos(PbaObject xpbaCodeplug, APXCodeplug currentcp, bool bRefresh);
        public static List<ValidationInfo> PopulateValidationInfosForRegularWrite(PbaObject xpbaCodeplug, APXCodeplug currentcp);
        public static List<ValidationField> PopulateWriteValidationFields(PbaObject xpbaCodeplug);
        internal static void RadioFlashCodeCheck(PbaObject xpbaCodeplug, COMMS_OP WriteType);
    }
}

