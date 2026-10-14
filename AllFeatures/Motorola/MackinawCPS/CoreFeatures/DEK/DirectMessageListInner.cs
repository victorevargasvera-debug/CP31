using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x02000336 RID: 822
	[global::System.Serializable]
	public class DirectMessageListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004102 RID: 16642
		// (get) Token: 0x06007F02 RID: 32514 RVA: 0x0074F840 File Offset: 0x0074DA40
		public global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerSection DirectMessageListInnerSection
		{
			get
			{
				short num = (short)1082444693;
				short num2 = num;
				num = (short)52087701;
				switch (num2 == num)
				{
				}
				num = (short)1408040960;
				short num3 = num;
				num = (short)845807617;
				if (num != 0)
				{
				}
				num = (short)1609433088;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerSection)base[10236];
			}
		}

		// Token: 0x06007F03 RID: 32515 RVA: 0x0074F8F8 File Offset: 0x0074DAF8
		public DirectMessageListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 17;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("雑뷓ꓕ뷗맙꣛ﻝ귟蟡韣闥觧跩觫컭볯鯱蟳苵", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTMESSAGELIST;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06007F04 RID: 32516 RVA: 0x0074F944 File Offset: 0x0074DB44
		protected DirectMessageListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 0;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("藀ꫂ럄ꋆ꫈뿊苎듐ꃒꛔ뛖뻘뻚﷜鏞裠郢釤", a_);
		}
	}
}
