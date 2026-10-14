using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile
{
	// Token: 0x02000100 RID: 256
	[global::System.Serializable]
	public class SecureHardwareEncryptionKeyReferencesListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x0024DC78 File Offset: 0x0024BE78
		public global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerSection SecureHardwareEncryptionKeyReferencesListInnerSection
		{
			get
			{
				short num = (short)1304876727;
				short num2 = num;
				num = (short)227989175;
				switch (num2 == num)
				{
				}
				num = (short)1472987137;
				if (num != 0)
				{
				}
				num = (short)1956249600;
				short num3 = num;
				num = (short)1781530624;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerSection)base[10127];
			}
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x0024DD30 File Offset: 0x0024BF30
		public SecureHardwareEncryptionKeyReferencesListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 10;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("飊꣌곎ꓐꇒ냔釘뫚꿜믞雠苢韤苦짨껪菬賮菰諲藴菶郸铺鏼\udffe䨀昂簄✆嬈渊欌樎挐瘒笔琖簘栚㴜匞䠠倢儤", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SECUREHARDWAREENCRYPTIONKEYREFERENCESLIST;
			global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x0024DD7C File Offset: 0x0024BF7C
		protected SecureHardwareEncryptionKeyReferencesListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 5;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("闅귇꧉맋볍뗏鳓럕꫗뻙ꯛ뿝鋟蟡쓣ꏥ蛧觩黫韭胯蛱鷳駵雷\udaf9럻鯽秿∁嘃挅渇漉縋欍縏焑焓攕㠗嘙甛洝吟", a_);
		}
	}
}
