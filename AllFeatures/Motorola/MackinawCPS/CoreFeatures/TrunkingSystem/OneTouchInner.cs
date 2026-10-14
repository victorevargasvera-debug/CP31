using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x0200009D RID: 157
	[global::System.Serializable]
	public class OneTouchInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x00112A30 File Offset: 0x00110C30
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerSection OneTouchInnerSection
		{
			get
			{
				short num = (short)543227904;
				short num2 = num;
				num = (short)884952741;
				short num3 = num;
				num = (short)381111973;
				switch (num3 == num)
				{
				}
				num = (short)1289158656;
				if (num != 0)
				{
				}
				num = (short)1653800961;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerSection)base[10166];
			}
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00112AEC File Offset: 0x00110CEC
		public OneTouchInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 9;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("黉뻋믍뻏맑뷓룕뿗龎鏛냝藟싡냣觥鷧觩蓫", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGONETOUCH;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00112B38 File Offset: 0x00110D38
		protected OneTouchInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 2;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("韂럄닆ꟈꃊ꓌ꇎ뛐體맖볘ﯚ觜냞铠胢跤", a_);
		}
	}
}
