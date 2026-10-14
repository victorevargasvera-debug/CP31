using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x02000098 RID: 152
	[global::System.Serializable]
	public class MessageAliasInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x0010D600 File Offset: 0x0010B800
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInnerSection MessageAliasInnerSection
		{
			get
			{
				short num = (short)2054922854;
				short num2 = num;
				num = (short)1155834470;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1844117504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1625751553;
				if (num != 0)
				{
				}
				num = (short)105250816;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInnerSection)base[10164];
			}
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x0010D6B8 File Offset: 0x0010B8B8
		public MessageAliasInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 4;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("裄ꋆ뫈룊곌꣎듐铔믖냘뫚껜", a_);
			base.UIName = global::CommonResources.AcgResources.ID_MESSAGEALIAS;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x0010D704 File Offset: 0x0010B904
		protected MessageAliasInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 0;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("賀ꛂ뛄듆꣈곊꣌郐뿒볔뛖꫘", a_);
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x0010D738 File Offset: 0x0010B938
		public override string ReferenceKey
		{
			get
			{
				int a_ = 16;
				short num = (short)1293156354;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1121583107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_142;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3E;
						}
						continue;
					case 3:
						if (this.MessageAliasInnerSection.TrkSysMsgAlias_A24069 != null)
						{
							num = (short)1155596289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_147;
					}
					IL_3E:
					if (this.MessageAliasInnerSection == null)
					{
						goto IL_147;
					}
					num = (short)1828639999;
					short num3 = num;
					num = (short)743757055;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_147;
					default:
						num = (short)1112539136;
						if (num != 0)
						{
						}
						num = (short)1872101376;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_142:
				num = (short)737280001;
				if (num != 0)
				{
				}
				return base.Position.ToString() + global::AllFeatures.CodeplugGuid.b("ﳐ", a_) + this.MessageAliasInnerSection.TrkSysMsgAlias_A24069.ToString();
				IL_147:
				num = (short)130088960;
				short num4 = num;
				return base.Position.ToString() + global::AllFeatures.CodeplugGuid.b("ﳐ", a_) + base.FeatureName;
			}
		}
	}
}
