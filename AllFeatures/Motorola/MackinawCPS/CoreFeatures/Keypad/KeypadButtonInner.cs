using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Keypad
{
	// Token: 0x02000302 RID: 770
	[global::System.Serializable]
	public class KeypadButtonInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17003F04 RID: 16132
		// (get) Token: 0x06007ACC RID: 31436 RVA: 0x006FF7C4 File Offset: 0x006FD9C4
		public global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection KeypadButtonInnerSection
		{
			get
			{
				short num = (short)1168347122;
				short num2 = num;
				num = (short)2068353010;
				switch (num2 == num)
				{
				}
				num = (short)1110769664;
				if (num != 0)
				{
				}
				num = (short)2069233664;
				short num3 = num;
				num = (short)423165953;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection)base[10709];
			}
		}

		// Token: 0x06007ACD RID: 31437 RVA: 0x006FF87C File Offset: 0x006FDA7C
		public KeypadButtonInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 14;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蓎듐꫒ꗔ뛖뷘ﯚ鿜꫞闠韢諤触", a_);
			base.UIName = global::CommonResources.AcgResources.ID_KEYPADBUTTON;
			global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06007ACE RID: 31438 RVA: 0x006FF8C8 File Offset: 0x006FDAC8
		protected KeypadButtonInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 9;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("臉꧋럍ꃏ돑냓髗꿙꣛ꫝ迟賡", a_);
		}
	}
}
