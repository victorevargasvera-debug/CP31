using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists
{
	// Token: 0x020005D5 RID: 1493
	[global::System.Serializable]
	public class MessageAliasTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170067DC RID: 26588
		// (get) Token: 0x0600CE82 RID: 52866 RVA: 0x00C02EDC File Offset: 0x00C010DC
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasTableInnerSection MessageAliasTableInnerSection
		{
			get
			{
				short num = (short)744367490;
				short num2 = num;
				num = (short)720643458;
				switch (num2 == num)
				{
				default:
				{
					num = (short)813826048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1534066689;
				if (num != 0)
				{
				}
				num = (short)1608908800;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasTableInnerSection)base[10013];
			}
		}

		// Token: 0x0600CE83 RID: 52867 RVA: 0x00C02F94 File Offset: 0x00C01194
		public MessageAliasTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 12;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("背꫎ꋐꃒ듔냖볘ﯚ鳜돞裠苢雤쟦뷨諪迬菮铰", a_);
			base.UIName = global::CommonResources.AcgResources.ID_MESSAGEALIASTABLE;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ConventionalAliasLists.MessageAliasTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600CE84 RID: 52868 RVA: 0x00C02FE0 File Offset: 0x00C011E0
		protected MessageAliasTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 1;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("迁ꇃ뗅믇ꯉꯋꯍ鏑룓뿕맗꧙ﳛ諝臟胡裣菥", a_);
		}
	}
}
