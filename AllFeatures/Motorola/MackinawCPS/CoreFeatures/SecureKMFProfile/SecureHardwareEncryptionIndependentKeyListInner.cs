using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile
{
	// Token: 0x020000FC RID: 252
	[global::System.Serializable]
	public class SecureHardwareEncryptionIndependentKeyListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170012E8 RID: 4840
		// (get) Token: 0x06002588 RID: 9608 RVA: 0x00249A14 File Offset: 0x00247C14
		public global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerSection SecureHardwareEncryptionIndependentKeyListInnerSection
		{
			get
			{
				short num = (short)1552319688;
				short num2 = num;
				num = (short)340362440;
				switch (num2 == num)
				{
				}
				num = (short)1227882497;
				if (num != 0)
				{
				}
				num = (short)1188429824;
				if (num != 0)
				{
				}
				num = (short)2055012352;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerSection)base[10882];
			}
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x00249ACC File Offset: 0x00247CCC
		public SecureHardwareEncryptionIndependentKeyListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 9;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("駉꧋귍ꗏꃑ뇓郗믙껛뫝韟菡難菥죧꿩苫跭苯诱蓳苵釷闹鋻\udefd䧿氁怃挅砇漉戋樍甏簑怓㘕北缙攛㸝氟䬡圣別", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SECUREHARDWAREENCRYPTIONINDEPENDENTKEYLIST;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600258A RID: 9610 RVA: 0x00249B18 File Offset: 0x00247D18
		protected SecureHardwareEncryptionIndependentKeyListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 14;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鳎듐냒ꃔꗖ볘ﯚ關뻞鏠蟢鋤蛦鯨軪췬ꫮ鿰郲蟴軶觸迺铼郾漀⌂䰄椆洈渊紌樎缐眒瀔礖洘㬚嘜稞堠̢椤並娨弪", a_);
		}
	}
}
