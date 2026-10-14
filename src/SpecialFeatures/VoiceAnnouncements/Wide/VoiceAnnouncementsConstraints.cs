namespace SpecialFeatures.VoiceAnnouncements.Wide
{
    using AcpBusinessLayer;
    using AcpCommonLib;
    using Motorola.MackinawCPS.CoreFeatures.RadioWide;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public static class VoiceAnnouncementsConstraints
    {
        private const int a = 0xffff;

        private static General a(IAcpFeatureSection A_0);
        private static bool a(Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide A_0);
        internal static bool ConIsVARecRefSelectionValid(IAcpFeatureSection self, int index);
        public static bool ConSetVAFieldInvalidWhenNoneForNFPACompliantEnabled(IAcpFeatureSection self, int index);
        public static bool ConSetVAPriorityFieldInapplicableAndLowForNFPAModelsAndNFPACompliantEnabled(IAcpFeatureSection self);
        public static bool ConSetVoiceCommandFieldInapplicableIfVoiceAnnouncementIsNotTTS(IAcpFeatureSection self);
        public static bool ConValidateTTSFieldAndDuration(IAcpFeatureSection self);
        public static bool VerifyTtsValueSupport(int index);

        private static Dictionary<string, VoiceAnnouncementsConstraints.FieldAccessors> FieldsByName { get; }

        [Serializable, CompilerGenerated]
        private sealed class <>c
        {
            public static readonly VoiceAnnouncementsConstraints.<>c <>9;
            public static Func<General, AcpRecRefField> <>9__10_0;
            public static Func<General, AcpField<string>> <>9__10_1;
            public static Func<General, AcpRecRefField> <>9__10_2;
            public static Func<General, AcpField<string>> <>9__10_3;
            public static Func<General, AcpRecRefField> <>9__10_4;
            public static Func<General, AcpField<string>> <>9__10_5;
            public static Func<General, AcpRecRefField> <>9__10_6;
            public static Func<General, AcpField<string>> <>9__10_7;
            public static Func<General, AcpRecRefField> <>9__10_8;
            public static Func<General, AcpField<string>> <>9__10_9;
            public static Func<General, AcpRecRefField> <>9__10_10;
            public static Func<General, AcpField<string>> <>9__10_11;
            public static Func<General, AcpRecRefField> <>9__10_12;
            public static Func<General, AcpField<string>> <>9__10_13;
            public static Func<General, AcpRecRefField> <>9__10_14;
            public static Func<General, AcpField<string>> <>9__10_15;
            public static Func<General, AcpRecRefField> <>9__10_16;
            public static Func<General, AcpField<string>> <>9__10_17;
            public static Func<General, AcpRecRefField> <>9__10_18;
            public static Func<General, AcpField<string>> <>9__10_19;
            public static Func<General, AcpRecRefField> <>9__10_20;
            public static Func<General, AcpField<string>> <>9__10_21;
            public static Func<General, AcpRecRefField> <>9__10_22;
            public static Func<General, AcpField<string>> <>9__10_23;
            public static Func<General, AcpRecRefField> <>9__10_24;
            public static Func<General, AcpField<string>> <>9__10_25;
            public static Func<General, AcpRecRefField> <>9__10_26;
            public static Func<General, AcpField<string>> <>9__10_27;
            public static Func<General, AcpRecRefField> <>9__10_28;
            public static Func<General, AcpField<string>> <>9__10_29;
            public static Func<General, AcpRecRefField> <>9__10_30;
            public static Func<General, AcpField<string>> <>9__10_31;
            public static Func<General, AcpRecRefField> <>9__10_32;
            public static Func<General, AcpField<string>> <>9__10_33;
            public static Func<General, AcpRecRefField> <>9__10_34;
            public static Func<General, AcpField<string>> <>9__10_35;
            public static Func<General, AcpRecRefField> <>9__10_36;
            public static Func<General, AcpField<string>> <>9__10_37;
            public static Func<General, AcpRecRefField> <>9__10_38;
            public static Func<General, AcpField<string>> <>9__10_39;
            public static Func<General, AcpRecRefField> <>9__10_40;
            public static Func<General, AcpField<string>> <>9__10_41;
            public static Func<General, AcpRecRefField> <>9__10_42;
            public static Func<General, AcpField<string>> <>9__10_43;
            public static Func<General, AcpRecRefField> <>9__10_44;
            public static Func<General, AcpField<string>> <>9__10_45;
            public static Func<General, AcpRecRefField> <>9__10_46;
            public static Func<General, AcpField<string>> <>9__10_47;
            public static Func<General, AcpRecRefField> <>9__10_48;
            public static Func<General, AcpField<string>> <>9__10_49;
            public static Func<General, AcpRecRefField> <>9__10_50;
            public static Func<General, AcpField<string>> <>9__10_51;
            public static Func<General, AcpRecRefField> <>9__10_52;
            public static Func<General, AcpField<string>> <>9__10_53;
            public static Func<General, AcpRecRefField> <>9__10_54;
            public static Func<General, AcpField<string>> <>9__10_55;
            public static Func<General, AcpRecRefField> <>9__10_56;
            public static Func<General, AcpField<string>> <>9__10_57;

            static <>c();
            public <>c();
            internal AcpRecRefField <get_FieldsByName>b__10_0(General general);
            internal AcpField<string> <get_FieldsByName>b__10_1(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_10(General general);
            internal AcpField<string> <get_FieldsByName>b__10_11(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_12(General general);
            internal AcpField<string> <get_FieldsByName>b__10_13(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_14(General general);
            internal AcpField<string> <get_FieldsByName>b__10_15(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_16(General general);
            internal AcpField<string> <get_FieldsByName>b__10_17(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_18(General general);
            internal AcpField<string> <get_FieldsByName>b__10_19(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_2(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_20(General general);
            internal AcpField<string> <get_FieldsByName>b__10_21(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_22(General general);
            internal AcpField<string> <get_FieldsByName>b__10_23(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_24(General general);
            internal AcpField<string> <get_FieldsByName>b__10_25(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_26(General general);
            internal AcpField<string> <get_FieldsByName>b__10_27(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_28(General general);
            internal AcpField<string> <get_FieldsByName>b__10_29(General general);
            internal AcpField<string> <get_FieldsByName>b__10_3(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_30(General general);
            internal AcpField<string> <get_FieldsByName>b__10_31(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_32(General general);
            internal AcpField<string> <get_FieldsByName>b__10_33(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_34(General general);
            internal AcpField<string> <get_FieldsByName>b__10_35(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_36(General general);
            internal AcpField<string> <get_FieldsByName>b__10_37(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_38(General general);
            internal AcpField<string> <get_FieldsByName>b__10_39(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_4(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_40(General general);
            internal AcpField<string> <get_FieldsByName>b__10_41(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_42(General general);
            internal AcpField<string> <get_FieldsByName>b__10_43(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_44(General general);
            internal AcpField<string> <get_FieldsByName>b__10_45(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_46(General general);
            internal AcpField<string> <get_FieldsByName>b__10_47(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_48(General general);
            internal AcpField<string> <get_FieldsByName>b__10_49(General general);
            internal AcpField<string> <get_FieldsByName>b__10_5(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_50(General general);
            internal AcpField<string> <get_FieldsByName>b__10_51(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_52(General general);
            internal AcpField<string> <get_FieldsByName>b__10_53(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_54(General general);
            internal AcpField<string> <get_FieldsByName>b__10_55(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_56(General general);
            internal AcpField<string> <get_FieldsByName>b__10_57(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_6(General general);
            internal AcpField<string> <get_FieldsByName>b__10_7(General general);
            internal AcpRecRefField <get_FieldsByName>b__10_8(General general);
            internal AcpField<string> <get_FieldsByName>b__10_9(General general);
        }

        private class FieldAccessors
        {
            [CompilerGenerated]
            private readonly Func<General, AcpRecRefField> a;
            [CompilerGenerated]
            private readonly Func<General, AcpField<string>> b;

            public FieldAccessors(Func<General, AcpRecRefField> voiceAnnouncementId, Func<General, AcpField<string>> ttsText);

            public Func<General, AcpRecRefField> VoiceAnnouncementId { get; }

            public Func<General, AcpField<string>> TtsText { get; }
        }
    }
}

