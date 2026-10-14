namespace SpecialFeatures.Security
{
    using Motorola.Acp.PackUnpack.Ish;
    using Motorola.Acp.PackUnpack.Ish.Layouts;
    using Motorola.Common.Communication.CommonUtil;
    using SpecialFeatures.Comms;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    public class CPSRadioAccessValidator : RadioAccessValidatorBase
    {
        private IshItemCollection a;
        private Collection<TrkSysBandPlan> b;
        private bool c;

        public CPSRadioAccessValidator(COMMS_OP WriteType, RadioSecurityData radSecData, RadioSecurityData cpgSecData, IshItemCollection progHistoryItems, Collection<TrkSysBandPlan> radioTrkShuffledBandPlans, bool writeProtectWriteProtectedRadio, bool otapBatchProgramming, bool updateWriteProtect);
        private long a(ByteBufferStreamReader A_0, int A_1);
        private string a(ByteBufferStreamReader A_0, StringFieldLayout A_1, int A_2);
        private bool a(int A_0, int A_1, Collection<TrkSysBandPlan> A_2);
        protected override Collection<TrkSysID> GetCodeplugTrkSystemIDs();
        protected override bool HandleWriteProtect(out string stsMsg);
        protected override bool IsCpgOwnerIDValid(out string statusMsg);
        protected override bool RestoreASKRequiredFlag(bool bUnLimitedOwnASKAttached);
        protected override void RestoreOwnerSystemData();
        protected override void RestoreRadioWideSecurityData();
        protected override void RestoreWriteProtect();
        internal void SetUnlimitedAskRequiredFlag(Dictionary<string, int> trkSystemsOnRadioWithOldAskReqValue, bool newAskRequiredValue, ICollection<TrkSysID> trkSystemsToBeWritten);
        internal void SetUnlimitedAskRequiredFlagForSystemsWithAskReqModified(ICollection<TrkSysID> trkSystems);
        protected override void UpdateASKProgrammingHistory();
        protected override void UpdateTrkSysShuffledBandPlans();

        [CompilerGenerated]
        private sealed class <>c__DisplayClass12_0
        {
            public bool newAskRequiredValue;

            public <>c__DisplayClass12_0();
            internal bool <SetUnlimitedAskRequiredFlag>b__0(TrkSysID x);
        }

        [CompilerGenerated]
        private sealed class <>c__DisplayClass12_1
        {
            public TrkSysID trkSys;

            public <>c__DisplayClass12_1();
            internal bool <SetUnlimitedAskRequiredFlag>b__1(KeyValuePair<string, int> x);
        }
    }
}

