using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x020000A2 RID: 162
	[global::System.Serializable]
	public class SiteAliasInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x060013E5 RID: 5093 RVA: 0x0012B4F4 File Offset: 0x001296F4
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerSection SiteAliasInnerSection
		{
			get
			{
				short num = (short)895611487;
				short num2 = num;
				num = (short)886108767;
				switch (num2 == num)
				{
				}
				num = (short)721027072;
				if (num != 0)
				{
				}
				num = (short)1765343232;
				short num3 = num;
				num = (short)1505034241;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerSection)base[10172];
			}
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x0012B5B4 File Offset: 0x001297B4
		public SiteAliasInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 14;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鳎룐꟒냔飘럚드뻞鋠", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SITEALIAS;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060013E7 RID: 5095 RVA: 0x0012B600 File Offset: 0x00129800
		protected SiteAliasInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 7;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鯇ꏉ룋ꯍ鏑룓뿕맗꧙", a_);
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x0012B634 File Offset: 0x00129834
		public override string ReferenceKey
		{
			get
			{
				int a_ = 8;
				short num = (short)1357643779;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (this.SiteAliasInnerSection.TrkSysSiteAlias_A24071 != null)
						{
							goto IL_155;
						}
						goto IL_171;
					case 1:
					{
						num = (short)1150030214;
						short num3 = num;
						num = (short)2099515782;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_155;
						default:
							goto IL_E9;
						}
						break;
					}
					case 2:
						num = (short)520355840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					}
					IL_3D:
					num = (short)243531777;
					if (num != 0)
					{
					}
					if (this.SiteAliasInnerSection != null)
					{
						num = (short)1705771008;
						short num4 = num;
						num = (short)119603202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_171;
					IL_155:
					num = (short)1016725505;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E9:
				num = (short)1911947264;
				if (num != 0)
				{
				}
				return base.Position.ToString() + global::AllFeatures.CodeplugGuid.b("", a_) + this.SiteAliasInnerSection.TrkSysSiteAlias_A24071.ToString();
				IL_171:
				return base.Position.ToString() + global::AllFeatures.CodeplugGuid.b("", a_) + base.FeatureName;
			}
		}
	}
}
