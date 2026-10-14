using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x0200033E RID: 830
	[global::System.Serializable]
	public class DirectStatusBCOListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004156 RID: 16726
		// (get) Token: 0x06007FBE RID: 32702 RVA: 0x00758144 File Offset: 0x00756344
		public global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerSection DirectStatusBCOListInnerSection
		{
			get
			{
				short num = (short)1525414812;
				short num2 = num;
				num = (short)39123868;
				switch (num2 == num)
				{
				}
				num = (short)336199680;
				if (num != 0)
				{
				}
				num = (short)772800513;
				if (num != 0)
				{
				}
				num = (short)1734148096;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerSection)base[10237];
			}
		}

		// Token: 0x06007FBF RID: 32703 RVA: 0x00758200 File Offset: 0x00756400
		public DirectStatusBCOListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 1;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蛁귃듅귇꧉룋菏ꛑ뗓ꋕ귗꧙ﳛ鳝ꏟ귡쓣ꫥ臧駩飫", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTSTATUSBCOLIST;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06007FC0 RID: 32704 RVA: 0x0075824C File Offset: 0x0075644C
		protected DirectStatusBCOListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 1;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蛁귃듅귇꧉룋菏ꛑ뗓ꋕ귗꧙ﳛ鳝ꏟ귡쓣ꫥ臧駩飫", a_);
		}
	}
}
