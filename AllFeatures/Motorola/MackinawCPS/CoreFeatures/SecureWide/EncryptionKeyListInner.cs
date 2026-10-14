using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.SecureWide
{
	// Token: 0x020000E2 RID: 226
	[global::System.Serializable]
	public class EncryptionKeyListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x001EDEC0 File Offset: 0x001EC0C0
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection EncryptionKeyListInnerSection
		{
			get
			{
				short num = (short)60909663;
				short num2 = num;
				num = (short)399206495;
				switch (num2 == num)
				{
				}
				num = (short)545718272;
				if (num != 0)
				{
				}
				num = (short)1400438784;
				short num3 = num;
				num = (short)1763835905;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection)base[10041];
			}
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x001EDF7C File Offset: 0x001EC17C
		public EncryptionKeyListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 13;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("词뻏뇑ꛓ꿕꣗껙뗛뇝軟싡꿣菥釧쫩ꃫ蟭華蛱", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ENCRYPTIONKEYLIST;
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x001EDFC8 File Offset: 0x001EC1C8
		protected EncryptionKeyListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 0;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蓀귂ꛄ뗆냈믊만ꛎ뻐뷒鳖볘ꋚ﷜鏞裠郢釤", a_);
		}
	}
}
