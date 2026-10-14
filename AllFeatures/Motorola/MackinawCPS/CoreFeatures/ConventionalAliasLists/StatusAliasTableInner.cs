using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists
{
	// Token: 0x020005D9 RID: 1497
	[global::System.Serializable]
	public class StatusAliasTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170067FD RID: 26621
		// (get) Token: 0x0600CED4 RID: 52948 RVA: 0x00C06C64 File Offset: 0x00C04E64
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInnerSection StatusAliasTableInnerSection
		{
			get
			{
				short num = (short)936378368;
				short num2 = num;
				num = (short)1928790017;
				if (num != 0)
				{
				}
				num = (short)35713699;
				short num3 = num;
				num = (short)14873251;
				switch (num3 == num)
				{
				}
				num = (short)1663238144;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInnerSection)base[10015];
			}
		}

		// Token: 0x0600CED5 RID: 52949 RVA: 0x00C06D1C File Offset: 0x00C04F1C
		public StatusAliasTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 19;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蟓ꋕ맗껙꧛귝샟ꏡ裣迥觧駩쳫뫭釯郱飳鏵", a_);
			base.UIName = global::CommonResources.AcgResources.ID_STATUSALIASTABLE;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.StatusAliasTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600CED6 RID: 52950 RVA: 0x00C06D68 File Offset: 0x00C04F68
		protected StatusAliasTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 9;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("駉룋꿍꓏ꟑꟓ駗뛙뗛뿝鏟싡냣蟥諧蛩觫", a_);
		}
	}
}
