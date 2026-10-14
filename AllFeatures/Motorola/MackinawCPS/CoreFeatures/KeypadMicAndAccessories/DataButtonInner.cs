using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories
{
	// Token: 0x02000308 RID: 776
	[global::System.Serializable]
	public class DataButtonInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17003F3B RID: 16187
		// (get) Token: 0x06007B55 RID: 31573 RVA: 0x00710BC4 File Offset: 0x0070EDC4
		public global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection DataButtonInnerSection
		{
			get
			{
				short num = (short)767175433;
				short num2 = num;
				num = (short)2043357961;
				switch (num2 == num)
				{
				}
				num = (short)524288;
				short num3 = num;
				num = (short)1350303745;
				if (num != 0)
				{
				}
				num = (short)996933632;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection)base[10209];
			}
		}

		// Token: 0x06007B56 RID: 31574 RVA: 0x00710C7C File Offset: 0x0070EE7C
		public DataButtonInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 10;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("胊鷌苎韒듔ꏖ룘ﯚ鿜꫞闠韢諤触", a_);
			base.UIName = global::CommonResources.AcgResources.ID_KPMDATABUTTON;
			global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06007B57 RID: 31575 RVA: 0x00710CC8 File Offset: 0x0070EEC8
		protected DataButtonInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 8;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苈鯊背闐닒ꇔ뛖律駚꣜ꯞ闠賢诤", a_);
		}
	}
}
