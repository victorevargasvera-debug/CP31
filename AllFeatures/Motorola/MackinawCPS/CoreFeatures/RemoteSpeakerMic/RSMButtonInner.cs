using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic
{
	// Token: 0x020002DB RID: 731
	[global::System.Serializable]
	public class RSMButtonInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17003DB3 RID: 15795
		// (get) Token: 0x06007809 RID: 30729 RVA: 0x006D0640 File Offset: 0x006CE840
		public global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection RSMButtonInnerSection
		{
			get
			{
				short num = (short)1213520548;
				short num2 = num;
				num = (short)1717820068;
				switch (num2 == num)
				{
				}
				num = (short)441843712;
				if (num != 0)
				{
				}
				num = (short)208338944;
				short num3 = num;
				num = (short)1935474689;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection)base[10080];
			}
		}

		// Token: 0x0600780A RID: 30730 RVA: 0x006D06F8 File Offset: 0x006CE8F8
		public RSMButtonInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 18;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鋒뛔듖볘꣚껜냞鏠髢엤ꗦ鳨鿪駬胮鿰胲헴ꏶ飸駺釼髾", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ACCESSORYBUTTONSTABLE;
			global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600780B RID: 30731 RVA: 0x006D0744 File Offset: 0x006CE944
		protected RSMButtonInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 4;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蓄꓆꫈껊뻌볎뻐ꇒ곔鯘껚꧜ꯞ軠跢雤쟦뷨諪迬菮铰", a_);
		}
	}
}
