using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x020000A6 RID: 166
	[global::System.Serializable]
	public class StatusAliasInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x060014BF RID: 5311 RVA: 0x00135ADC File Offset: 0x00133CDC
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInnerSection StatusAliasInnerSection
		{
			get
			{
				short num = (short)1574448307;
				short num2 = num;
				num = (short)221326515;
				switch (num2 == num)
				{
				}
				num = (short)1554513920;
				short num3 = num;
				num = (short)869072897;
				if (num != 0)
				{
				}
				num = (short)874381312;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInnerSection)base[10174];
			}
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00135B98 File Offset: 0x00133D98
		public StatusAliasInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 4;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("雄돆꣈뿊료볎鋒맔뻖룘꣚", a_);
			base.UIName = global::CommonResources.AcgResources.ID_STATUSALIAS;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00135BE4 File Offset: 0x00133DE4
		protected StatusAliasInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 18;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("胒ꇔ뛖귘껚껜￞ꃠ迢賤蛦髨", a_);
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x060014C2 RID: 5314 RVA: 0x00135C18 File Offset: 0x00133E18
		public override string ReferenceKey
		{
			get
			{
				int a_ = 0;
				short num = (short)49926828;
				short num2 = num;
				num = (short)1176752812;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1955004416;
					short num3 = num;
					num = (short)1412366336;
					if (num != 0)
					{
					}
					num = (short)364052480;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_B4;
							}
							continue;
						case 1:
							if (this.StatusAliasInnerSection.TrkSysStatusAlias_A24070 != null)
							{
								num = (short)1218445315;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_16C;
						case 2:
							num = (short)446038017;
							if (num != 0)
							{
							}
							num = (short)1425145857;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_16A;
						}
						IL_B4:
						if (this.StatusAliasInnerSection == null)
						{
							goto IL_16C;
						}
						num = (short)1567883266;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_16A:
					break;
					IL_16C:
					return base.Position.ToString() + global::AllFeatures.CodeplugGuid.b("", a_) + base.FeatureName;
				}
				}
				return base.Position.ToString() + global::AllFeatures.CodeplugGuid.b("", a_) + this.StatusAliasInnerSection.TrkSysStatusAlias_A24070.ToString();
			}
		}
	}
}
