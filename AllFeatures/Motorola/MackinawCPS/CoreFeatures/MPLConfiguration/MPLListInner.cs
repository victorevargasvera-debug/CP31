using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.MPLConfiguration
{
	// Token: 0x0200053C RID: 1340
	[global::System.Serializable]
	public class MPLListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700593F RID: 22847
		// (get) Token: 0x0600B228 RID: 45608 RVA: 0x00A57980 File Offset: 0x00A55B80
		public global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection MPLListInnerSection
		{
			get
			{
				short num = (short)114804835;
				short num2 = num;
				num = (short)230344803;
				switch (num2 == num)
				{
				}
				num = (short)507641857;
				if (num != 0)
				{
				}
				num = (short)1769472000;
				short num3 = num;
				num = (short)671416320;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection)base[10193];
			}
		}

		// Token: 0x0600B229 RID: 45609 RVA: 0x00A57A38 File Offset: 0x00A55C38
		public MPLListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 7;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("藇髉胋鳏믑ꟓꋕ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_MPLLIST;
			global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600B22A RID: 45610 RVA: 0x00A57A84 File Offset: 0x00A55C84
		protected MPLListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 3;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("觃雅蓇胋ꟍꏏꛑ", a_);
		}
	}
}
