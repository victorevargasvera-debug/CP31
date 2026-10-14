using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x020002BA RID: 698
	[global::System.Serializable]
	public class RotaryControlInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17003C64 RID: 15460
		// (get) Token: 0x0600753C RID: 30012 RVA: 0x0069BD80 File Offset: 0x00699F80
		public global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerSection RotaryControlInnerSection
		{
			get
			{
				short num = (short)1889450107;
				short num2 = num;
				num = (short)1197324411;
				switch (num2 == num)
				{
				}
				num = (short)1645412352;
				short num3 = num;
				num = (short)509870080;
				if (num != 0)
				{
				}
				num = (short)959053825;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerSection)base[10082];
			}
		}

		// Token: 0x0600753D RID: 30013 RVA: 0x0069BE3C File Offset: 0x0069A03C
		public RotaryControlInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 6;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("闆ꛈ뿊곌뷎꣐雔룖럘꿚꿜냞跠", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ROTARYCONTROL;
			global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600753E RID: 30014 RVA: 0x0069BE88 File Offset: 0x0069A088
		protected RotaryControlInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 11;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("黋ꇍ꓏돑ꛓ꿕駙돛냝铟郡诣諥", a_);
		}
	}
}
