using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.SecureWide
{
	// Token: 0x020000EA RID: 234
	[global::System.Serializable]
	public class Multikey : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600225D RID: 8797 RVA: 0x0021A58C File Offset: 0x0021878C
		public Multikey(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x0021A5A8 File Offset: 0x002187A8
		protected Multikey(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x0021A5C0 File Offset: 0x002187C0
		public override void Init()
		{
			int a_ = 9;
			short num = (short)523982816;
			short num2 = num;
			num = (short)517887968;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1152647168;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)732692481;
			if (num != 0)
			{
			}
			num = (short)2142568448;
			if (num != 0)
			{
			}
			this.secWideMultikeyDisplayOnModeChange_A7877 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("駉꧋귍蟏믑냓돕闗꿙냛ꫝ觟觡臣鿥곧菩鿫黭鳯鏱跳맵雷럹鏻髽旿䄁氃朅昇洉椋儍儏┑Ⱃℕ⼗", a_), global::CommonResources.AcgResources.ID_DISPLAYONMODECHANGE, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.SecWideMultikeyDisplayOnModeChange_A7877LovStrs);
			this.secWideMultikeyDisplayOnModeChange_A7877.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideMultikeyDisplayOnModeChange_A7877.DataTransferOrder = 24;
			this.secWideMultikeyDisplayOnPTT_A7879 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("駉꧋귍蟏믑냓돕闗꿙냛ꫝ觟觡臣鿥곧菩鿫黭鳯鏱跳맵雷꫹ꣻ꫽忿䌁㌃㸅㼇㌉", a_), global::CommonResources.AcgResources.ID_DISPLAYONPTT, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.SecWideMultikeyDisplayOnPTT_A7879LovStrs);
			this.secWideMultikeyDisplayOnPTT_A7879.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideMultikeyDisplayOnPTT_A7879.DataTransferOrder = 17;
			this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("駉꧋귍蟏믑냓돕闗꿙냛ꫝ觟觡臣鿥곧菩鿫黭鳯鏱跳맵雷꧹駻鷽痿瀁愃唅缇按砋洍砏䄑焓稕紗礙栛䄝感ᔡᰣḥᤧ", a_), global::CommonResources.AcgResources.ID_DISPLAYONSECURESWITCHSELECT, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.SecWideMultikeyDisplayOnSecureSwitchSelect_A7881LovStrs);
			this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.DataTransferOrder = 18;
			this.secWideMultikeyPIDKeyManagementforASNMode_A8704 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駉꧋귍蟏믑냓돕闗꿙냛ꫝ觟觡臣鿥룧ꏩ꣫ꗭ闯诱맳韵雷鯹鯻鯽淿朁樃爅渇攉縋伍䌏少夓礕簗缙䌛弝᠟ᔡᐣሥ", a_), global::CommonResources.AcgResources.ID_PIDKEYMANAGEMENTFORASNMODE);
			this.secWideMultikeyPIDKeyManagementforASNMode_A8704.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideMultikeyPIDKeyManagementforASNMode_A8704.DataTransferOrder = 7;
			this.secWideMultikeyRxHangTimems_A9019 = new global::AcpBusinessLayer.AcpSimpleRangeField(12, this, global::AllFeatures.CodeplugGuid.b("駉꧋귍蟏믑냓돕闗꿙냛ꫝ觟觡臣鿥뫧鋩ꓫ迭黯闱ꃳ鿵闷鿹釻跽忿䌁㴃㘅㤇㌉", a_), global::CommonResources.AcgResources.ID_KEYIDRXHANGTIMEMS, 0, 40, null, null, 0, 250);
			this.secWideMultikeyRxHangTimems_A9019.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideMultikeyRxHangTimems_A9019.DataTransferOrder = 30;
			this.secWideMultikeyRxHangTimems_A9019.ShowHexValue = false;
			this.secWideMultikeyTxHangTimeMs_A9540 = new global::AcpBusinessLayer.AcpSimpleRangeField(12, this, global::AllFeatures.CodeplugGuid.b("駉꧋귍蟏믑냓돕闗꿙냛ꫝ觟觡臣鿥볧鋩ꓫ迭黯闱ꃳ鿵闷鿹뇻跽忿䌁㴃㌅㰇㨉", a_), global::CommonResources.AcgResources.ID_KEYIDTXHANGTIMEMS, 0, 40, null, null, 0, 250);
			this.secWideMultikeyTxHangTimeMs_A9540.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideMultikeyTxHangTimeMs_A9540.DataTransferOrder = 22;
			this.secWideMultikeyTxHangTimeMs_A9540.ShowHexValue = false;
			this.secWideMultikeyErasePreviousOnUserChange_A8373 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駉꧋귍蟏믑냓돕闗꿙냛ꫝ觟觡臣鿥귧飩跫鷭闯ꋱ蛳鏵軷鏹鏻诽珿䴁樃包笇漉縋䴍砏猑稓焕紗䔙崛☝ጟᔡᜣ", a_), global::CommonResources.AcgResources.ID_KEYSETERASEPREVIOUSONUSERCHANGE);
			this.secWideMultikeyErasePreviousOnUserChange_A8373.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideMultikeyErasePreviousOnUserChange_A8373.DataTransferOrder = 38;
			this.secWideMultikeyUserSelectable_A9604 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("駉꧋귍蟏믑냓돕闗꿙냛ꫝ觟觡臣鿥뷧駩觫鳭ꏯ韱飳鏵鯷軹鷻鳽泿朁嬃䜅ㄇ㰉㰋㨍", a_), global::CommonResources.AcgResources.ID_KEYSETUSERSELECTABLE);
			this.secWideMultikeyUserSelectable_A9604.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.secWideMultikeyUserSelectable_A9604.DataTransferOrder = 41;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟉맋ꋍ꓏믑뿓돕ꇗ", a_);
			base.Id = 10044;
			base.UIName = global::CommonResources.AcgResources.ID_MULTIKEY;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x0021A8AC File Offset: 0x00218AAC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)482856436;
			short num2 = num;
			num = (short)2014236148;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_5CE:
				this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("郂ꃄ꓆黈ꋊ꧌꫎鳐ꛒ맔ꏖ냘냚룜ꛞꗠ諢雤韦藨諪铬ꃮ鿰ꃲ郴银賸觺飼곾瘀樂焄搆愈堊栌挎琐瀒愔䠖堘Ⱊ├✞ဠ", a_), global::CommonResources.AcgResources.ID_DISPLAYONSECURESWITCHSELECT, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.SecWideMultikeyDisplayOnSecureSwitchSelect_A7881LovStrs);
				this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
				this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.DataTransferOrder = 18;
				num = (short)1626996745;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1514995712;
				if (num != 0)
				{
				}
				num = (short)325124119;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					this.secWideMultikeyDisplayOnModeChange_A7877 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("郂ꃄ꓆黈ꋊ꧌꫎鳐ꛒ맔ꏖ냘냚룜ꛞꗠ諢雤韦藨諪铬ꃮ鿰뻲髴鏶鳸룺闼黾漀搂怄堆䠈㰊㔌㠎☐", a_), global::CommonResources.AcgResources.ID_DISPLAYONMODECHANGE, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.SecWideMultikeyDisplayOnModeChange_A7877LovStrs);
					this.secWideMultikeyDisplayOnModeChange_A7877.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideMultikeyDisplayOnModeChange_A7877.DataTransferOrder = 24;
					num = (short)2052194316;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郂ꃄ꓆黈ꋊ꧌꫎鳐ꛒ맔ꏖ냘냚룜ꛞꗠ諢雤韦藨諪铬ꃮ鿰뻲髴鏶鳸룺闼黾漀搂怄堆䠈㰊㔌㠎☐", a_)))
					{
						num = (short)449249280;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F9;
				case 2:
					num = (short)691208193;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_4E5;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郂ꃄ꓆黈ꋊ꧌꫎鳐ꛒ맔ꏖ냘냚룜ꛞ뇠ꫢꇤ곦賨鋪ꃬ軮鿰鋲鋴鋶铸黺鏼课最氂眄䘆娈䔊䀌怎甐瘒䨔嘖℘Ⱊⴜ⬞", a_)))
					{
						num = (short)611450887;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_183;
				case 5:
					goto IL_10F;
				case 6:
					goto IL_447;
				case 7:
					this.secWideMultikeyPIDKeyManagementforASNMode_A8704 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郂ꃄ꓆黈ꋊ꧌꫎鳐ꛒ맔ꏖ냘냚룜ꛞ뇠ꫢꇤ곦賨鋪ꃬ軮鿰鋲鋴鋶铸黺鏼课最氂眄䘆娈䔊䀌怎甐瘒䨔嘖℘Ⱊⴜ⬞", a_), global::CommonResources.AcgResources.ID_PIDKEYMANAGEMENTFORASNMODE);
					this.secWideMultikeyPIDKeyManagementforASNMode_A8704.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideMultikeyPIDKeyManagementforASNMode_A8704.DataTransferOrder = 7;
					num = (short)1127284747;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					this.secWideMultikeyRxHangTimems_A9019 = new global::AcpBusinessLayer.AcpSimpleRangeField(12, this, global::AllFeatures.CodeplugGuid.b("郂ꃄ꓆黈ꋊ꧌꫎鳐ꛒ맔ꏖ냘냚룜ꛞ돠鯢귤蛦蟨質맬蛮鳰雲飴蓶꛸뫺쓼쿾\u3000㨂", a_), global::CommonResources.AcgResources.ID_KEYIDRXHANGTIMEMS, null, null, 0, 250);
					this.secWideMultikeyRxHangTimems_A9019.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideMultikeyRxHangTimems_A9019.DataTransferOrder = 30;
					this.secWideMultikeyRxHangTimems_A9019.ShowHexValue = false;
					num = (short)1754660869;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_39F;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郂ꃄ꓆黈ꋊ꧌꫎鳐ꛒ맔ꏖ냘냚룜ꛞꗠ諢雤韦藨諪铬ꃮ鿰ꏲꇴꏶ꛸뫺쫼쟾㘀㨂", a_)))
					{
						num = (short)82968591;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4EA;
				case 11:
					goto IL_183;
				case 12:
					goto IL_1F9;
				case 13:
					if (producerFields != null)
					{
						num = (short)2031157250;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6E9;
				case 14:
					num = (short)1907687425;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郂ꃄ꓆黈ꋊ꧌꫎鳐ꛒ맔ꏖ냘냚룜ꛞ뗠鯢귤蛦蟨質맬蛮鳰雲룴蓶꛸뫺쓼쫾㔀㌂", a_)))
					{
						num = (short)1142816786;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_447;
				case 15:
					this.secWideMultikeyDisplayOnPTT_A7879 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("郂ꃄ꓆黈ꋊ꧌꫎鳐ꛒ맔ꏖ냘냚룜ꛞꗠ諢雤韦藨諪铬ꃮ鿰ꏲꇴꏶ꛸뫺쫼쟾㘀㨂", a_), global::CommonResources.AcgResources.ID_DISPLAYONPTT, global::Motorola.MackinawCPS.CoreFeatures.SecureWide.LOVs.SecWideMultikeyDisplayOnPTT_A7879LovStrs);
					this.secWideMultikeyDisplayOnPTT_A7879.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideMultikeyDisplayOnPTT_A7879.DataTransferOrder = 17;
					num = (short)1569062932;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					this.secWideMultikeyErasePreviousOnUserChange_A8373 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郂ꃄ꓆黈ꋊ꧌꫎鳐ꛒ맔ꏖ냘냚룜ꛞꓠ釢蓤铦賨믪鿬諮蟰髲髴苶諸듺鏼꫾爀昂眄䐆愈樊挌栎琐䰒吔⼖⨘Ⱊ⸜", a_), global::CommonResources.AcgResources.ID_KEYSETERASEPREVIOUSONUSERCHANGE);
					this.secWideMultikeyErasePreviousOnUserChange_A8373.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideMultikeyErasePreviousOnUserChange_A8373.DataTransferOrder = 38;
					num = (short)682622995;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					this.secWideMultikeyUserSelectable_A9604 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("郂ꃄ꓆黈ꋊ꧌꫎鳐ꛒ맔ꏖ냘냚룜ꛞ든郢胤闦뫨軪臬諮鋰蟲铴闶闸黺ꋼ뻾㠀㔂㔄㌆", a_), global::CommonResources.AcgResources.ID_KEYSETUSERSELECTABLE);
					this.secWideMultikeyUserSelectable_A9604.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideMultikeyUserSelectable_A9604.DataTransferOrder = 41;
					num = (short)514523139;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					this.secWideMultikeyTxHangTimeMs_A9540 = new global::AcpBusinessLayer.AcpSimpleRangeField(12, this, global::AllFeatures.CodeplugGuid.b("郂ꃄ꓆黈ꋊ꧌꫎鳐ꛒ맔ꏖ냘냚룜ꛞ뗠鯢귤蛦蟨質맬蛮鳰雲룴蓶꛸뫺쓼쫾㔀㌂", a_), global::CommonResources.AcgResources.ID_KEYIDTXHANGTIMEMS, null, null, 0, 250);
					this.secWideMultikeyTxHangTimeMs_A9540.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.secWideMultikeyTxHangTimeMs_A9540.DataTransferOrder = 22;
					this.secWideMultikeyTxHangTimeMs_A9540.ShowHexValue = false;
					num = (short)1593507846;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					goto IL_353;
				case 20:
					goto IL_4EA;
				case 21:
					goto IL_534;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郂ꃄ꓆黈ꋊ꧌꫎鳐ꛒ맔ꏖ냘냚룜ꛞ든郢胤闦뫨軪臬諮鋰蟲铴闶闸黺ꋼ뻾㠀㔂㔄㌆", a_)))
					{
						num = (short)737411089;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6E9;
				case 23:
					switch (0)
					{
					case 0:
						goto IL_E8;
					}
					continue;
				case 24:
				{
					num = (short)2095054848;
					short num4 = num;
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郂ꃄ꓆黈ꋊ꧌꫎鳐ꛒ맔ꏖ냘냚룜ꛞ돠鯢귤蛦蟨質맬蛮鳰雲飴蓶꛸뫺쓼쿾\u3000㨂", a_)))
					{
						num = (short)900005896;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10F;
				}
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郂ꃄ꓆黈ꋊ꧌꫎鳐ꛒ맔ꏖ냘냚룜ꛞꗠ諢雤韦藨諪铬ꃮ鿰ꃲ郴银賸觺飼곾瘀樂焄搆愈堊栌挎琐瀒愔䠖堘Ⱊ├✞ဠ", a_)))
					{
						num = (short)1696202773;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_39F;
				case 26:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郂ꃄ꓆黈ꋊ꧌꫎鳐ꛒ맔ꏖ냘냚룜ꛞꓠ釢蓤铦賨믪鿬諮蟰髲髴苶諸듺鏼꫾爀昂眄䐆愈樊挌栎琐䰒吔⼖⨘Ⱊ⸜", a_)))
					{
						num = (short)881000464;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_353;
				case 27:
					num = (short)1797586957;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_E8:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)2100232219;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_10F:
				num = (short)1103233038;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_183:
				num = (short)1346961432;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F9:
				num = (short)1925054474;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_353:
				num = (short)1600323606;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_39F:
				num = (short)817430532;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_447:
				num = (short)646643738;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_4EA:
				num = (short)1447231513;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_4E5:
			goto IL_6E9;
			IL_534:
			goto IL_5CE;
			IL_6E9:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軂냄ꯆ뷈ꋊꛌ꫎꣐", a_);
			base.Id = 10044;
			base.UIName = global::CommonResources.AcgResources.ID_MULTIKEY;
			base.DataTransferOrder = 4;
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x0021AFD4 File Offset: 0x002191D4
		public override void PopulateReferences()
		{
			short num = (short)1718359609;
			short num2 = num;
			num = (short)1632376377;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1505558528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)97124353;
			if (num != 0)
			{
			}
			num = (short)716111872;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x0021B07C File Offset: 0x0021927C
		public override void DropReferences()
		{
			short num = (short)1330395859;
			short num2 = num;
			num = (short)2065185491;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1469382656;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)141230081;
			if (num != 0)
			{
			}
			num = (short)49872896;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002263 RID: 8803 RVA: 0x0021B124 File Offset: 0x00219324
		public override void SetConstraints()
		{
			short num = (short)237240321;
			if (num != 0)
			{
			}
			num = (short)511442944;
			short num2 = num;
			num = (short)1236939118;
			short num3 = num;
			num = (short)1653551470;
			switch (num3 == num)
			{
			}
			num = (short)1706098688;
			if (num != 0)
			{
			}
			this.secWideMultikeyDisplayOnModeChange_A7877.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecureOperationIsNotDisabled);
			this.secWideMultikeyDisplayOnModeChange_A7877.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConDispListValidityForDispOnMc);
			this.secWideMultikeyDisplayOnPTT_A7879.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecureOperationIsNotDisabled);
			this.secWideMultikeyDisplayOnPTT_A7879.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConDispListValidityForDispOnPtt);
			this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecureOperationIsNotDisabled);
			this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConDispListValidityForSecSwitchSel);
			this.secWideMultikeyPIDKeyManagementforASNMode_A8704.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecOperationIsHardware);
			this.secWideMultikeyRxHangTimems_A9019.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecureOperationIsNotDisabled);
			this.secWideMultikeyTxHangTimeMs_A9540.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWideConstraints.ConSecureOperationIsNotDisabled);
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x0021B29C File Offset: 0x0021949C
		public override void SetupDependencies()
		{
			short num = (short)6738359;
			short num2 = num;
			num = (short)2070335927;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2119172096;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)730202113;
			if (num != 0)
			{
			}
			num = (short)72089600;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMultikeyDisplayOnModeChange_A7877);
			secureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secWideMultikeyDisplayOnModeChange_A7877);
			secureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.secWideMultikeyDisplayOnModeChange_A7877);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMultikeyDisplayOnPTT_A7879);
			secureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secWideMultikeyDisplayOnPTT_A7879);
			secureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.secWideMultikeyDisplayOnPTT_A7879);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881);
			secureWide.General.SecureWideAESAlgorithmEnable_43201.AddDependentObject(this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881);
			secureWide.General.SecureWideDESAlgorithmEnable_43744.AddDependentObject(this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMultikeyPIDKeyManagementforASNMode_A8704);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMultikeyRxHangTimems_A9019);
			secureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.secWideMultikeyTxHangTimeMs_A9540);
		}

		// Token: 0x17001156 RID: 4438
		// (get) Token: 0x06002265 RID: 8805 RVA: 0x0021B460 File Offset: 0x00219660
		public bool HasDiffs
		{
			get
			{
				short num = (short)1148562616;
				short num2 = num;
				num = (short)636660920;
				switch (num2 == num)
				{
				default:
				{
					num = (short)986578944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1060831233;
				if (num != 0)
				{
				}
				num = (short)1341194240;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17001157 RID: 4439
		// (get) Token: 0x06002266 RID: 8806 RVA: 0x0021B510 File Offset: 0x00219710
		// (set) Token: 0x06002267 RID: 8807 RVA: 0x0021B5C8 File Offset: 0x002197C8
		public int SecWideMultikeyDisplayOnModeChange_A7877Value
		{
			get
			{
				short num = (short)123226614;
				short num2 = num;
				num = (short)1212369398;
				switch (num2 == num)
				{
				default:
				{
					num = (short)412221440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)64028673;
				if (num != 0)
				{
				}
				num = (short)1576009728;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnModeChange_A7877.Value;
			}
			set
			{
				short num = (short)1803152915;
				short num2 = num;
				num = (short)1888611859;
				switch (num2 == num)
				{
				default:
				{
					num = (short)749666304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1433927681;
				if (num != 0)
				{
				}
				num = (short)1478033408;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnModeChange_A7877.Value = value;
			}
		}

		// Token: 0x17001158 RID: 4440
		// (get) Token: 0x06002268 RID: 8808 RVA: 0x0021B684 File Offset: 0x00219884
		// (set) Token: 0x06002269 RID: 8809 RVA: 0x0021B738 File Offset: 0x00219938
		public string SecWideMultikeyDisplayOnModeChange_A7877_UIValue
		{
			get
			{
				short num = (short)167000812;
				short num2 = num;
				num = (short)1332099820;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1029767168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2055012353;
				if (num != 0)
				{
				}
				num = (short)1324285952;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnModeChange_A7877.UIValue;
			}
			set
			{
				short num = (short)1383730694;
				short num2 = num;
				num = (short)179965446;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2064384000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1694957569;
				if (num != 0)
				{
				}
				num = (short)499646464;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnModeChange_A7877.UIValue = value;
			}
		}

		// Token: 0x17001159 RID: 4441
		// (get) Token: 0x0600226A RID: 8810 RVA: 0x0021B7EC File Offset: 0x002199EC
		public global::AcpBusinessLayer.AcpListField SecWideMultikeyDisplayOnModeChange_A7877
		{
			get
			{
				short num = (short)1795329264;
				short num2 = num;
				num = (short)1033211120;
				switch (num2 == num)
				{
				default:
				{
					num = (short)871170048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)180224000;
				if (num != 0)
				{
				}
				num = (short)680329217;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnModeChange_A7877;
			}
		}

		// Token: 0x1700115A RID: 4442
		// (get) Token: 0x0600226B RID: 8811 RVA: 0x0021B89C File Offset: 0x00219A9C
		// (set) Token: 0x0600226C RID: 8812 RVA: 0x0021B954 File Offset: 0x00219B54
		public bool SecWideMultikeyDisplayOnModeChange_A7877_Applicable
		{
			get
			{
				short num = (short)625068534;
				short num2 = num;
				num = (short)1107610102;
				switch (num2 == num)
				{
				default:
				{
					num = (short)320077824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)629800961;
				if (num != 0)
				{
				}
				num = (short)1678049280;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnModeChange_A7877.Applicable;
			}
			set
			{
				short num = (short)459855459;
				short num2 = num;
				num = (short)1557648995;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1388707840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)623050753;
				if (num != 0)
				{
				}
				num = (short)165347328;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnModeChange_A7877.Applicable = value;
			}
		}

		// Token: 0x1700115B RID: 4443
		// (get) Token: 0x0600226D RID: 8813 RVA: 0x0021BA08 File Offset: 0x00219C08
		// (set) Token: 0x0600226E RID: 8814 RVA: 0x0021BAC0 File Offset: 0x00219CC0
		public bool SecWideMultikeyDisplayOnModeChange_A7877_Valid
		{
			get
			{
				short num = (short)2017109796;
				short num2 = num;
				num = (short)55617316;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1352794112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1024655361;
				if (num != 0)
				{
				}
				num = (short)1862008832;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnModeChange_A7877.Valid;
			}
			set
			{
				short num = (short)1183703838;
				short num2 = num;
				num = (short)1594745630;
				switch (num2 == num)
				{
				default:
				{
					num = (short)227999744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2038693889;
				if (num != 0)
				{
				}
				num = (short)436600832;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnModeChange_A7877.Valid = value;
			}
		}

		// Token: 0x1700115C RID: 4444
		// (get) Token: 0x0600226F RID: 8815 RVA: 0x0021BB74 File Offset: 0x00219D74
		// (set) Token: 0x06002270 RID: 8816 RVA: 0x0021BC28 File Offset: 0x00219E28
		public bool SecWideMultikeyDisplayOnModeChange_A7877_Visible
		{
			get
			{
				short num = (short)306659874;
				short num2 = num;
				num = (short)855261730;
				switch (num2 == num)
				{
				default:
				{
					num = (short)177602560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1658322945;
				if (num != 0)
				{
				}
				num = (short)1545338880;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnModeChange_A7877.Visible;
			}
			set
			{
				short num = (short)2027356161;
				if (num != 0)
				{
				}
				num = (short)1484062720;
				short num2 = num;
				num = (short)467558979;
				short num3 = num;
				num = (short)134767171;
				switch (num3 == num)
				{
				}
				num = (short)1847721984;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnModeChange_A7877.Visible = value;
			}
		}

		// Token: 0x1700115D RID: 4445
		// (get) Token: 0x06002271 RID: 8817 RVA: 0x0021BCE0 File Offset: 0x00219EE0
		// (set) Token: 0x06002272 RID: 8818 RVA: 0x0021BD94 File Offset: 0x00219F94
		public bool SecWideMultikeyDisplayOnModeChange_A7877_Editable
		{
			get
			{
				short num = (short)873384442;
				short num2 = num;
				num = (short)1027918330;
				switch (num2 == num)
				{
				default:
				{
					num = (short)354025472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)281804801;
				if (num != 0)
				{
				}
				num = (short)1739456512;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnModeChange_A7877.Editable;
			}
			set
			{
				short num = (short)709885712;
				short num2 = num;
				num = (short)378470160;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1812725760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1994588161;
				if (num != 0)
				{
				}
				num = (short)1935474688;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnModeChange_A7877.Editable = value;
			}
		}

		// Token: 0x1700115E RID: 4446
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x0021BE4C File Offset: 0x0021A04C
		internal string SecWideMultikeyDisplayOnModeChange_A7877_UILabel
		{
			get
			{
				short num = (short)1596404156;
				short num2 = num;
				num = (short)1917268412;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2092564480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1622278144;
				if (num != 0)
				{
				}
				num = (short)1443495937;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnModeChange_A7877.UIName;
			}
		}

		// Token: 0x1700115F RID: 4447
		// (get) Token: 0x06002274 RID: 8820 RVA: 0x0021BF00 File Offset: 0x0021A100
		// (set) Token: 0x06002275 RID: 8821 RVA: 0x0021BFB4 File Offset: 0x0021A1B4
		internal bool SecWideMultikeyDisplayOnModeChange_A7877_HiddenStatic
		{
			get
			{
				short num = (short)1663971132;
				short num2 = num;
				num = (short)2006527804;
				switch (num2 == num)
				{
				default:
				{
					num = (short)312934400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)744161281;
				if (num != 0)
				{
				}
				num = (short)546570240;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnModeChange_A7877.HiddenStatic;
			}
			set
			{
				short num = (short)360513537;
				if (num != 0)
				{
				}
				num = (short)965476352;
				short num2 = num;
				num = (short)6955292;
				short num3 = num;
				num = (short)397418780;
				switch (num3 == num)
				{
				}
				num = (short)2083717120;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnModeChange_A7877.HiddenStatic = value;
			}
		}

		// Token: 0x17001160 RID: 4448
		// (get) Token: 0x06002276 RID: 8822 RVA: 0x0021C06C File Offset: 0x0021A26C
		// (set) Token: 0x06002277 RID: 8823 RVA: 0x0021C11C File Offset: 0x0021A31C
		internal bool SecWideMultikeyDisplayOnModeChange_A7877_HiddenDynamic
		{
			get
			{
				short num = (short)984307311;
				short num2 = num;
				num = (short)1103910511;
				switch (num2 == num)
				{
				default:
				{
					num = (short)448397312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)420151297;
				if (num != 0)
				{
				}
				num = (short)1830158336;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnModeChange_A7877.HiddenDynamic;
			}
			set
			{
				short num = (short)1096972626;
				short num2 = num;
				num = (short)817461586;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1527775232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2033057793;
				if (num != 0)
				{
				}
				num = (short)923074560;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnModeChange_A7877.HiddenDynamic = value;
			}
		}

		// Token: 0x17001161 RID: 4449
		// (get) Token: 0x06002278 RID: 8824 RVA: 0x0021C1D0 File Offset: 0x0021A3D0
		public bool SecWideMultikeyDisplayOnModeChange_A7877_HasDiffs
		{
			get
			{
				short num = (short)1468938184;
				short num2 = num;
				num = (short)150484936;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1133117440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1418461185;
				if (num != 0)
				{
				}
				num = (short)1288044544;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnModeChange_A7877._HasDiffs;
			}
		}

		// Token: 0x17001162 RID: 4450
		// (get) Token: 0x06002279 RID: 8825 RVA: 0x0021C284 File Offset: 0x0021A484
		// (set) Token: 0x0600227A RID: 8826 RVA: 0x0021C338 File Offset: 0x0021A538
		public int SecWideMultikeyDisplayOnPTT_A7879Value
		{
			get
			{
				short num = (short)2073362433;
				if (num != 0)
				{
				}
				num = (short)969080832;
				short num2 = num;
				num = (short)784572872;
				short num3 = num;
				num = (short)1861132744;
				switch (num3 == num)
				{
				}
				num = (short)997982208;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnPTT_A7879.Value;
			}
			set
			{
				short num = (short)827049150;
				short num2 = num;
				num = (short)1702413502;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1564672000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)487063553;
				if (num != 0)
				{
				}
				num = (short)952565760;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnPTT_A7879.Value = value;
			}
		}

		// Token: 0x17001163 RID: 4451
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x0021C3EC File Offset: 0x0021A5EC
		// (set) Token: 0x0600227C RID: 8828 RVA: 0x0021C4A4 File Offset: 0x0021A6A4
		public string SecWideMultikeyDisplayOnPTT_A7879_UIValue
		{
			get
			{
				short num = (short)66081499;
				short num2 = num;
				num = (short)164254427;
				switch (num2 == num)
				{
				default:
				{
					num = (short)802160640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)948109313;
				if (num != 0)
				{
				}
				num = (short)1021378560;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnPTT_A7879.UIValue;
			}
			set
			{
				short num = (short)1571936474;
				short num2 = num;
				num = (short)1601558746;
				switch (num2 == num)
				{
				default:
				{
					num = (short)50069504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1674444800;
				if (num != 0)
				{
				}
				num = (short)1152057345;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnPTT_A7879.UIValue = value;
			}
		}

		// Token: 0x17001164 RID: 4452
		// (get) Token: 0x0600227D RID: 8829 RVA: 0x0021C55C File Offset: 0x0021A75C
		public global::AcpBusinessLayer.AcpListField SecWideMultikeyDisplayOnPTT_A7879
		{
			get
			{
				short num = (short)680226942;
				short num2 = num;
				num = (short)557150334;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2066612224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1469579264;
				if (num != 0)
				{
				}
				num = (short)1894973441;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnPTT_A7879;
			}
		}

		// Token: 0x17001165 RID: 4453
		// (get) Token: 0x0600227E RID: 8830 RVA: 0x0021C60C File Offset: 0x0021A80C
		// (set) Token: 0x0600227F RID: 8831 RVA: 0x0021C6C0 File Offset: 0x0021A8C0
		public bool SecWideMultikeyDisplayOnPTT_A7879_Applicable
		{
			get
			{
				short num = (short)1664424949;
				short num2 = num;
				num = (short)945560565;
				switch (num2 == num)
				{
				default:
				{
					num = (short)579207168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1096155136;
				if (num != 0)
				{
				}
				num = (short)982843393;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnPTT_A7879.Applicable;
			}
			set
			{
				short num = (short)837150784;
				short num2 = num;
				num = (short)388032576;
				switch (num2 == num)
				{
				default:
				{
					num = (short)360382464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1769013249;
				if (num != 0)
				{
				}
				num = (short)1278672896;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnPTT_A7879.Applicable = value;
			}
		}

		// Token: 0x17001166 RID: 4454
		// (get) Token: 0x06002280 RID: 8832 RVA: 0x0021C778 File Offset: 0x0021A978
		// (set) Token: 0x06002281 RID: 8833 RVA: 0x0021C82C File Offset: 0x0021AA2C
		public bool SecWideMultikeyDisplayOnPTT_A7879_Valid
		{
			get
			{
				short num = (short)69398839;
				short num2 = num;
				num = (short)2030301495;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1116995584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1618411521;
				if (num != 0)
				{
				}
				num = (short)1799225344;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnPTT_A7879.Valid;
			}
			set
			{
				short num = (short)713033458;
				short num2 = num;
				num = (short)722405106;
				switch (num2 == num)
				{
				default:
				{
					num = (short)527892480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2115633152;
				if (num != 0)
				{
				}
				num = (short)781385729;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnPTT_A7879.Valid = value;
			}
		}

		// Token: 0x17001167 RID: 4455
		// (get) Token: 0x06002282 RID: 8834 RVA: 0x0021C8E0 File Offset: 0x0021AAE0
		// (set) Token: 0x06002283 RID: 8835 RVA: 0x0021C994 File Offset: 0x0021AB94
		public bool SecWideMultikeyDisplayOnPTT_A7879_Visible
		{
			get
			{
				short num = (short)1960195572;
				short num2 = num;
				num = (short)10040820;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1877082112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1877475329;
				if (num != 0)
				{
				}
				num = (short)1379205120;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnPTT_A7879.Visible;
			}
			set
			{
				short num = (short)1091305262;
				short num2 = num;
				num = (short)560791342;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1955921920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)564264960;
				if (num != 0)
				{
				}
				num = (short)1908604929;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnPTT_A7879.Visible = value;
			}
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x06002284 RID: 8836 RVA: 0x0021CA4C File Offset: 0x0021AC4C
		// (set) Token: 0x06002285 RID: 8837 RVA: 0x0021CB04 File Offset: 0x0021AD04
		public bool SecWideMultikeyDisplayOnPTT_A7879_Editable
		{
			get
			{
				short num = (short)23658497;
				if (num != 0)
				{
				}
				num = (short)17235968;
				short num2 = num;
				num = (short)314428076;
				short num3 = num;
				num = (short)931842732;
				switch (num3 == num)
				{
				}
				num = (short)1033961472;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnPTT_A7879.Editable;
			}
			set
			{
				short num = (short)97970902;
				short num2 = num;
				num = (short)1691478742;
				switch (num2 == num)
				{
				default:
				{
					num = (short)919076864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)204210176;
				if (num != 0)
				{
				}
				num = (short)1676607489;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnPTT_A7879.Editable = value;
			}
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x06002286 RID: 8838 RVA: 0x0021CBB8 File Offset: 0x0021ADB8
		internal string SecWideMultikeyDisplayOnPTT_A7879_UILabel
		{
			get
			{
				short num = (short)1378513725;
				short num2 = num;
				num = (short)1124889405;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1891827712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1223622656;
				if (num != 0)
				{
				}
				num = (short)1878130689;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnPTT_A7879.UIName;
			}
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x0021CC6C File Offset: 0x0021AE6C
		// (set) Token: 0x06002288 RID: 8840 RVA: 0x0021CD24 File Offset: 0x0021AF24
		internal bool SecWideMultikeyDisplayOnPTT_A7879_HiddenStatic
		{
			get
			{
				short num = (short)1196228609;
				if (num != 0)
				{
				}
				num = (short)2028470272;
				short num2 = num;
				num = (short)1811661152;
				short num3 = num;
				num = (short)1483391328;
				switch (num3 == num)
				{
				}
				num = (short)2033123328;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnPTT_A7879.HiddenStatic;
			}
			set
			{
				short num = (short)1613427758;
				short num2 = num;
				num = (short)1269756974;
				switch (num2 == num)
				{
				default:
				{
					num = (short)603783168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1683947521;
				if (num != 0)
				{
				}
				num = (short)1452015616;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnPTT_A7879.HiddenStatic = value;
			}
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x06002289 RID: 8841 RVA: 0x0021CDD8 File Offset: 0x0021AFD8
		// (set) Token: 0x0600228A RID: 8842 RVA: 0x0021CE8C File Offset: 0x0021B08C
		internal bool SecWideMultikeyDisplayOnPTT_A7879_HiddenDynamic
		{
			get
			{
				short num = (short)1644756993;
				if (num != 0)
				{
				}
				num = (short)436994048;
				short num2 = num;
				num = (short)1834761469;
				short num3 = num;
				num = (short)538197245;
				switch (num3 == num)
				{
				}
				num = (short)813826048;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnPTT_A7879.HiddenDynamic;
			}
			set
			{
				short num = (short)1682007127;
				short num2 = num;
				num = (short)1546806359;
				switch (num2 == num)
				{
				default:
				{
					num = (short)722796544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1163788289;
				if (num != 0)
				{
				}
				num = (short)1786511360;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnPTT_A7879.HiddenDynamic = value;
			}
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x0600228B RID: 8843 RVA: 0x0021CF40 File Offset: 0x0021B140
		public bool SecWideMultikeyDisplayOnPTT_A7879_HasDiffs
		{
			get
			{
				short num = (short)170869090;
				short num2 = num;
				num = (short)318783842;
				switch (num2 == num)
				{
				default:
				{
					num = (short)363593728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1033240576;
				if (num != 0)
				{
				}
				num = (short)2021195777;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnPTT_A7879._HasDiffs;
			}
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x0021CFF8 File Offset: 0x0021B1F8
		// (set) Token: 0x0600228D RID: 8845 RVA: 0x0021D0AC File Offset: 0x0021B2AC
		public int SecWideMultikeyDisplayOnSecureSwitchSelect_A7881Value
		{
			get
			{
				short num = (short)674977867;
				short num2 = num;
				num = (short)1758550091;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1431764992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1730150401;
				if (num != 0)
				{
				}
				num = (short)209911808;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.Value;
			}
			set
			{
				short num = (short)1199611508;
				short num2 = num;
				num = (short)1624153716;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1338966016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1522466817;
				if (num != 0)
				{
				}
				num = (short)653852672;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.Value = value;
			}
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x0600228E RID: 8846 RVA: 0x0021D164 File Offset: 0x0021B364
		// (set) Token: 0x0600228F RID: 8847 RVA: 0x0021D218 File Offset: 0x0021B418
		public string SecWideMultikeyDisplayOnSecureSwitchSelect_A7881_UIValue
		{
			get
			{
				short num = (short)318526724;
				short num2 = num;
				num = (short)2077840644;
				switch (num2 == num)
				{
				default:
				{
					num = (short)760545280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)955056128;
				if (num != 0)
				{
				}
				num = (short)1852702721;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.UIValue;
			}
			set
			{
				short num = (short)1113194497;
				if (num != 0)
				{
				}
				num = (short)867827712;
				short num2 = num;
				num = (short)1318845439;
				short num3 = num;
				num = (short)91618303;
				switch (num3 == num)
				{
				}
				num = (short)1003618304;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.UIValue = value;
			}
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x06002290 RID: 8848 RVA: 0x0021D2CC File Offset: 0x0021B4CC
		public global::AcpBusinessLayer.AcpListField SecWideMultikeyDisplayOnSecureSwitchSelect_A7881
		{
			get
			{
				short num = (short)1931083777;
				if (num != 0)
				{
				}
				num = (short)1882521600;
				short num2 = num;
				num = (short)950148662;
				short num3 = num;
				num = (short)1884692022;
				switch (num3 == num)
				{
				}
				num = (short)1065680896;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881;
			}
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x06002291 RID: 8849 RVA: 0x0021D37C File Offset: 0x0021B57C
		// (set) Token: 0x06002292 RID: 8850 RVA: 0x0021D430 File Offset: 0x0021B630
		public bool SecWideMultikeyDisplayOnSecureSwitchSelect_A7881_Applicable
		{
			get
			{
				short num = (short)1237580557;
				short num2 = num;
				num = (short)835910413;
				switch (num2 == num)
				{
				default:
				{
					num = (short)299565056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1408630785;
				if (num != 0)
				{
				}
				num = (short)843776000;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.Applicable;
			}
			set
			{
				short num = (short)1211826177;
				if (num != 0)
				{
				}
				num = (short)1563099136;
				short num2 = num;
				num = (short)2146464266;
				short num3 = num;
				num = (short)351760906;
				switch (num3 == num)
				{
				}
				num = (short)1322319872;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.Applicable = value;
			}
		}

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x06002293 RID: 8851 RVA: 0x0021D4E8 File Offset: 0x0021B6E8
		// (set) Token: 0x06002294 RID: 8852 RVA: 0x0021D59C File Offset: 0x0021B79C
		public bool SecWideMultikeyDisplayOnSecureSwitchSelect_A7881_Valid
		{
			get
			{
				short num = (short)1838032859;
				short num2 = num;
				num = (short)958736347;
				switch (num2 == num)
				{
				default:
				{
					num = (short)604176384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2064318464;
				if (num != 0)
				{
				}
				num = (short)2066939905;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.Valid;
			}
			set
			{
				short num = (short)1465376768;
				short num2 = num;
				num = (short)613146624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1079836672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1089142785;
				if (num != 0)
				{
				}
				num = (short)849412096;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.Valid = value;
			}
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x06002295 RID: 8853 RVA: 0x0021D650 File Offset: 0x0021B850
		// (set) Token: 0x06002296 RID: 8854 RVA: 0x0021D70C File Offset: 0x0021B90C
		public bool SecWideMultikeyDisplayOnSecureSwitchSelect_A7881_Visible
		{
			get
			{
				short num = (short)950877220;
				short num2 = num;
				num = (short)140524580;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1052639232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1750532097;
				if (num != 0)
				{
				}
				num = (short)1621032960;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.Visible;
			}
			set
			{
				short num = (short)870514688;
				short num2 = num;
				num = (short)1193420964;
				short num3 = num;
				num = (short)1418995876;
				switch (num3 == num)
				{
				}
				num = (short)456130560;
				if (num != 0)
				{
				}
				num = (short)91357185;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.Visible = value;
			}
		}

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x06002297 RID: 8855 RVA: 0x0021D7C4 File Offset: 0x0021B9C4
		// (set) Token: 0x06002298 RID: 8856 RVA: 0x0021D878 File Offset: 0x0021BA78
		public bool SecWideMultikeyDisplayOnSecureSwitchSelect_A7881_Editable
		{
			get
			{
				short num = (short)349503488;
				short num2 = num;
				num = (short)393805825;
				if (num != 0)
				{
				}
				num = (short)40414424;
				short num3 = num;
				num = (short)66890968;
				switch (num3 == num)
				{
				}
				num = (short)654114816;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.Editable;
			}
			set
			{
				short num = (short)322830336;
				short num2 = num;
				num = (short)233635841;
				if (num != 0)
				{
				}
				num = (short)233422793;
				short num3 = num;
				num = (short)1660010441;
				switch (num3 == num)
				{
				}
				num = (short)281739264;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.Editable = value;
			}
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x06002299 RID: 8857 RVA: 0x0021D930 File Offset: 0x0021BB30
		internal string SecWideMultikeyDisplayOnSecureSwitchSelect_A7881_UILabel
		{
			get
			{
				short num = (short)1219493888;
				short num2 = num;
				num = (short)270778753;
				short num3 = num;
				num = (short)2120794497;
				switch (num3 == num)
				{
				}
				num = (short)1648951297;
				if (num != 0)
				{
				}
				num = (short)1755316224;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.UIName;
			}
		}

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x0021D9E4 File Offset: 0x0021BBE4
		// (set) Token: 0x0600229B RID: 8859 RVA: 0x0021DA98 File Offset: 0x0021BC98
		internal bool SecWideMultikeyDisplayOnSecureSwitchSelect_A7881_HiddenStatic
		{
			get
			{
				short num = (short)416677888;
				short num2 = num;
				num = (short)1455815078;
				short num3 = num;
				num = (short)1587411366;
				switch (num3 == num)
				{
				}
				num = (short)1060044801;
				if (num != 0)
				{
				}
				num = (short)1745485824;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.HiddenStatic;
			}
			set
			{
				short num = (short)1630994432;
				short num2 = num;
				num = (short)1840001007;
				short num3 = num;
				num = (short)1352871919;
				switch (num3 == num)
				{
				}
				num = (short)1225392129;
				if (num != 0)
				{
				}
				num = (short)1240203264;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.HiddenStatic = value;
			}
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x0021DB50 File Offset: 0x0021BD50
		// (set) Token: 0x0600229D RID: 8861 RVA: 0x0021DC04 File Offset: 0x0021BE04
		internal bool SecWideMultikeyDisplayOnSecureSwitchSelect_A7881_HiddenDynamic
		{
			get
			{
				short num = (short)47972352;
				short num2 = num;
				num = (short)1360848890;
				short num3 = num;
				num = (short)1536419834;
				switch (num3 == num)
				{
				}
				num = (short)409862145;
				if (num != 0)
				{
				}
				num = (short)719257600;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.HiddenDynamic;
			}
			set
			{
				short num = (short)778829824;
				short num2 = num;
				num = (short)1239152410;
				short num3 = num;
				num = (short)1787688730;
				switch (num3 == num)
				{
				}
				num = (short)2077425665;
				if (num != 0)
				{
				}
				num = (short)4915200;
				if (num != 0)
				{
				}
				this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881.HiddenDynamic = value;
			}
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x0600229E RID: 8862 RVA: 0x0021DCB8 File Offset: 0x0021BEB8
		public bool SecWideMultikeyDisplayOnSecureSwitchSelect_A7881_HasDiffs
		{
			get
			{
				short num = (short)693305344;
				short num2 = num;
				num = (short)1881740601;
				short num3 = num;
				num = (short)688985401;
				switch (num3 == num)
				{
				}
				num = (short)1226702849;
				if (num != 0)
				{
				}
				num = (short)1810628608;
				if (num != 0)
				{
				}
				return this.secWideMultikeyDisplayOnSecureSwitchSelect_A7881._HasDiffs;
			}
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x0021DD6C File Offset: 0x0021BF6C
		// (set) Token: 0x060022A0 RID: 8864 RVA: 0x0021DE20 File Offset: 0x0021C020
		public bool SecWideMultikeyPIDKeyManagementforASNMode_A8704Value
		{
			get
			{
				short num = (short)1931083776;
				short num2 = num;
				num = (short)82102893;
				short num3 = num;
				num = (short)745327213;
				switch (num3 == num)
				{
				}
				num = (short)1568538625;
				if (num != 0)
				{
				}
				num = (short)1669595136;
				if (num != 0)
				{
				}
				return this.secWideMultikeyPIDKeyManagementforASNMode_A8704.Value;
			}
			set
			{
				short num = (short)1662648320;
				short num2 = num;
				num = (short)1232663056;
				short num3 = num;
				num = (short)2122117648;
				switch (num3 == num)
				{
				}
				num = (short)1194196993;
				if (num != 0)
				{
				}
				num = (short)1596719104;
				if (num != 0)
				{
				}
				this.secWideMultikeyPIDKeyManagementforASNMode_A8704.Value = value;
			}
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x0021DED8 File Offset: 0x0021C0D8
		public global::AcpBusinessLayer.AcpField<bool> SecWideMultikeyPIDKeyManagementforASNMode_A8704
		{
			get
			{
				short num = (short)917831680;
				short num2 = num;
				num = (short)2089133231;
				short num3 = num;
				num = (short)2058134703;
				switch (num3 == num)
				{
				}
				num = (short)490012673;
				if (num != 0)
				{
				}
				num = (short)774832128;
				if (num != 0)
				{
				}
				return this.secWideMultikeyPIDKeyManagementforASNMode_A8704;
			}
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x060022A2 RID: 8866 RVA: 0x0021DF84 File Offset: 0x0021C184
		// (set) Token: 0x060022A3 RID: 8867 RVA: 0x0021E03C File Offset: 0x0021C23C
		public bool SecWideMultikeyPIDKeyManagementforASNMode_A8704_UIValue
		{
			get
			{
				short num = (short)791937024;
				short num2 = num;
				num = (short)437639359;
				short num3 = num;
				num = (short)1516099775;
				switch (num3 == num)
				{
				}
				num = (short)6488065;
				if (num != 0)
				{
				}
				num = (short)2136145920;
				if (num != 0)
				{
				}
				return this.secWideMultikeyPIDKeyManagementforASNMode_A8704.Value;
			}
			set
			{
				short num = (short)64356352;
				short num2 = num;
				num = (short)537775985;
				short num3 = num;
				num = (short)354865009;
				switch (num3 == num)
				{
				}
				num = (short)227540993;
				if (num != 0)
				{
				}
				num = (short)567803904;
				if (num != 0)
				{
				}
				this.secWideMultikeyPIDKeyManagementforASNMode_A8704.Value = value;
			}
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x060022A4 RID: 8868 RVA: 0x0021E0F4 File Offset: 0x0021C2F4
		// (set) Token: 0x060022A5 RID: 8869 RVA: 0x0021E1A8 File Offset: 0x0021C3A8
		public bool SecWideMultikeyPIDKeyManagementforASNMode_A8704_Applicable
		{
			get
			{
				short num = (short)1291845632;
				short num2 = num;
				num = (short)152269103;
				short num3 = num;
				num = (short)1145991471;
				switch (num3 == num)
				{
				}
				num = (short)243335169;
				if (num != 0)
				{
				}
				num = (short)1990328320;
				if (num != 0)
				{
				}
				return this.secWideMultikeyPIDKeyManagementforASNMode_A8704.Applicable;
			}
			set
			{
				short num = (short)522190848;
				short num2 = num;
				num = (short)520610799;
				short num3 = num;
				num = (short)1654907887;
				switch (num3 == num)
				{
				}
				num = (short)932315137;
				if (num != 0)
				{
				}
				num = (short)420741120;
				if (num != 0)
				{
				}
				this.secWideMultikeyPIDKeyManagementforASNMode_A8704.Applicable = value;
			}
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x060022A6 RID: 8870 RVA: 0x0021E25C File Offset: 0x0021C45C
		// (set) Token: 0x060022A7 RID: 8871 RVA: 0x0021E310 File Offset: 0x0021C510
		public bool SecWideMultikeyPIDKeyManagementforASNMode_A8704_Valid
		{
			get
			{
				short num = (short)1723793408;
				short num2 = num;
				num = (short)2037020534;
				short num3 = num;
				num = (short)2044360566;
				switch (num3 == num)
				{
				}
				num = (short)1225981953;
				if (num != 0)
				{
				}
				num = (short)1222180864;
				if (num != 0)
				{
				}
				return this.secWideMultikeyPIDKeyManagementforASNMode_A8704.Valid;
			}
			set
			{
				short num = (short)1236664320;
				short num2 = num;
				num = (short)591558509;
				short num3 = num;
				num = (short)1388607341;
				switch (num3 == num)
				{
				}
				num = (short)1506213889;
				if (num != 0)
				{
				}
				num = (short)228524032;
				if (num != 0)
				{
				}
				this.secWideMultikeyPIDKeyManagementforASNMode_A8704.Valid = value;
			}
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x060022A8 RID: 8872 RVA: 0x0021E3C4 File Offset: 0x0021C5C4
		// (set) Token: 0x060022A9 RID: 8873 RVA: 0x0021E47C File Offset: 0x0021C67C
		public bool SecWideMultikeyPIDKeyManagementforASNMode_A8704_Visible
		{
			get
			{
				short num = (short)689963008;
				short num2 = num;
				num = (short)1043027645;
				short num3 = num;
				num = (short)307975869;
				switch (num3 == num)
				{
				}
				num = (short)1490092033;
				if (num != 0)
				{
				}
				num = (short)591331328;
				if (num != 0)
				{
				}
				return this.secWideMultikeyPIDKeyManagementforASNMode_A8704.Visible;
			}
			set
			{
				short num = (short)12451840;
				short num2 = num;
				num = (short)1064582575;
				short num3 = num;
				num = (short)1444363695;
				switch (num3 == num)
				{
				}
				num = (short)1435369473;
				if (num != 0)
				{
				}
				num = (short)1257701376;
				if (num != 0)
				{
				}
				this.secWideMultikeyPIDKeyManagementforASNMode_A8704.Visible = value;
			}
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x060022AA RID: 8874 RVA: 0x0021E534 File Offset: 0x0021C734
		// (set) Token: 0x060022AB RID: 8875 RVA: 0x0021E5E8 File Offset: 0x0021C7E8
		public bool SecWideMultikeyPIDKeyManagementforASNMode_A8704_Editable
		{
			get
			{
				short num = (short)767688704;
				short num2 = num;
				num = (short)2111192461;
				short num3 = num;
				num = (short)1487355277;
				switch (num3 == num)
				{
				}
				num = (short)249692161;
				if (num != 0)
				{
				}
				num = (short)1369964544;
				if (num != 0)
				{
				}
				return this.secWideMultikeyPIDKeyManagementforASNMode_A8704.Editable;
			}
			set
			{
				short num = (short)188284928;
				short num2 = num;
				num = (short)1665397311;
				short num3 = num;
				num = (short)2003759679;
				switch (num3 == num)
				{
				}
				num = (short)990117889;
				if (num != 0)
				{
				}
				num = (short)793837568;
				if (num != 0)
				{
				}
				this.secWideMultikeyPIDKeyManagementforASNMode_A8704.Editable = value;
			}
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x060022AC RID: 8876 RVA: 0x0021E6A0 File Offset: 0x0021C8A0
		internal string SecWideMultikeyPIDKeyManagementforASNMode_A8704_UILabel
		{
			get
			{
				short num = (short)562888704;
				short num2 = num;
				num = (short)1730657476;
				short num3 = num;
				num = (short)901037252;
				switch (num3 == num)
				{
				}
				num = (short)2116354049;
				if (num != 0)
				{
				}
				num = (short)1797259264;
				if (num != 0)
				{
				}
				return this.secWideMultikeyPIDKeyManagementforASNMode_A8704.UIName;
			}
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x060022AD RID: 8877 RVA: 0x0021E754 File Offset: 0x0021C954
		// (set) Token: 0x060022AE RID: 8878 RVA: 0x0021E808 File Offset: 0x0021CA08
		internal bool SecWideMultikeyPIDKeyManagementforASNMode_A8704_HiddenStatic
		{
			get
			{
				short num = (short)666828800;
				short num2 = num;
				num = (short)1214977293;
				short num3 = num;
				num = (short)1671632141;
				switch (num3 == num)
				{
				}
				num = (short)539033601;
				if (num != 0)
				{
				}
				num = (short)1893335040;
				if (num != 0)
				{
				}
				return this.secWideMultikeyPIDKeyManagementforASNMode_A8704.HiddenStatic;
			}
			set
			{
				short num = (short)1849491456;
				short num2 = num;
				num = (short)643235841;
				if (num != 0)
				{
				}
				num = (short)2053251335;
				short num3 = num;
				num = (short)73998599;
				switch (num3 == num)
				{
				}
				num = (short)831848448;
				if (num != 0)
				{
				}
				this.secWideMultikeyPIDKeyManagementforASNMode_A8704.HiddenStatic = value;
			}
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x060022AF RID: 8879 RVA: 0x0021E8BC File Offset: 0x0021CABC
		// (set) Token: 0x060022B0 RID: 8880 RVA: 0x0021E970 File Offset: 0x0021CB70
		internal bool SecWideMultikeyPIDKeyManagementforASNMode_A8704_HiddenDynamic
		{
			get
			{
				short num = (short)1311375360;
				short num2 = num;
				num = (short)398524417;
				if (num != 0)
				{
				}
				num = (short)1944557907;
				short num3 = num;
				num = (short)693279059;
				switch (num3 == num)
				{
				}
				num = (short)727711744;
				if (num != 0)
				{
				}
				return this.secWideMultikeyPIDKeyManagementforASNMode_A8704.HiddenDynamic;
			}
			set
			{
				short num = (short)474415104;
				short num2 = num;
				num = (short)1546125313;
				if (num != 0)
				{
				}
				num = (short)1278168259;
				short num3 = num;
				num = (short)2117225667;
				switch (num3 == num)
				{
				}
				num = (short)260767744;
				if (num != 0)
				{
				}
				this.secWideMultikeyPIDKeyManagementforASNMode_A8704.HiddenDynamic = value;
			}
		}

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x060022B1 RID: 8881 RVA: 0x0021EA24 File Offset: 0x0021CC24
		public bool SecWideMultikeyPIDKeyManagementforASNMode_A8704_HasDiffs
		{
			get
			{
				short num = (short)460980224;
				short num2 = num;
				num = (short)87556097;
				if (num != 0)
				{
				}
				num = (short)116705470;
				short num3 = num;
				num = (short)2033895614;
				switch (num3 == num)
				{
				}
				num = (short)1561198592;
				if (num != 0)
				{
				}
				return this.secWideMultikeyPIDKeyManagementforASNMode_A8704._HasDiffs;
			}
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x0021EAD8 File Offset: 0x0021CCD8
		// (set) Token: 0x060022B3 RID: 8883 RVA: 0x0021EB90 File Offset: 0x0021CD90
		public int SecWideMultikeyRxHangTimems_A9019Value
		{
			get
			{
				short num = (short)1921056768;
				short num2 = num;
				num = (short)240202916;
				short num3 = num;
				num = (short)1048196260;
				switch (num3 == num)
				{
				}
				num = (short)1883832321;
				if (num != 0)
				{
				}
				num = (short)2089091072;
				if (num != 0)
				{
				}
				return this.secWideMultikeyRxHangTimems_A9019.Value;
			}
			set
			{
				short num = (short)295305216;
				short num2 = num;
				num = (short)222944717;
				short num3 = num;
				num = (short)700440013;
				switch (num3 == num)
				{
				}
				num = (short)2070347777;
				if (num != 0)
				{
				}
				num = (short)999751680;
				if (num != 0)
				{
				}
				this.secWideMultikeyRxHangTimems_A9019.Value = value;
			}
		}

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x0021EC48 File Offset: 0x0021CE48
		public global::AcpBusinessLayer.AcpSimpleRangeField SecWideMultikeyRxHangTimems_A9019
		{
			get
			{
				short num = (short)1578565632;
				short num2 = num;
				num = (short)2089090676;
				short num3 = num;
				num = (short)1759837812;
				switch (num3 == num)
				{
				}
				num = (short)2013986816;
				if (num != 0)
				{
				}
				num = (short)499056641;
				if (num != 0)
				{
				}
				return this.secWideMultikeyRxHangTimems_A9019;
			}
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x0021ECF8 File Offset: 0x0021CEF8
		// (set) Token: 0x060022B6 RID: 8886 RVA: 0x0021EDAC File Offset: 0x0021CFAC
		public string SecWideMultikeyRxHangTimems_A9019_UIValue
		{
			get
			{
				short num = (short)1058668544;
				short num2 = num;
				num = (short)1940780058;
				short num3 = num;
				num = (short)1500967962;
				switch (num3 == num)
				{
				}
				num = (short)808189952;
				if (num != 0)
				{
				}
				num = (short)1944911873;
				if (num != 0)
				{
				}
				return this.secWideMultikeyRxHangTimems_A9019.UIValue;
			}
			set
			{
				short num = (short)797114368;
				short num2 = num;
				num = (short)445253696;
				short num3 = num;
				num = (short)419104832;
				switch (num3 == num)
				{
				}
				num = (short)1600258048;
				if (num != 0)
				{
				}
				num = (short)2046689281;
				if (num != 0)
				{
				}
				this.secWideMultikeyRxHangTimems_A9019.UIValue = value;
			}
		}

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x060022B7 RID: 8887 RVA: 0x0021EE64 File Offset: 0x0021D064
		// (set) Token: 0x060022B8 RID: 8888 RVA: 0x0021EF18 File Offset: 0x0021D118
		internal int SecWideMultikeyRxHangTimems_A9019Min
		{
			get
			{
				short num = (short)1424949248;
				short num2 = num;
				num = (short)505787667;
				short num3 = num;
				num = (short)274576659;
				switch (num3 == num)
				{
				}
				num = (short)1773862912;
				if (num != 0)
				{
				}
				num = (short)1637023745;
				if (num != 0)
				{
				}
				return this.secWideMultikeyRxHangTimems_A9019.Min;
			}
			set
			{
				short num = (short)1037434880;
				short num2 = num;
				num = (short)1373953614;
				short num3 = num;
				num = (short)1057480270;
				switch (num3 == num)
				{
				}
				num = (short)938672128;
				if (num != 0)
				{
				}
				num = (short)1662517249;
				if (num != 0)
				{
				}
				this.secWideMultikeyRxHangTimems_A9019.Min = value;
			}
		}

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x060022B9 RID: 8889 RVA: 0x0021EFCC File Offset: 0x0021D1CC
		// (set) Token: 0x060022BA RID: 8890 RVA: 0x0021F080 File Offset: 0x0021D280
		internal int SecWideMultikeyRxHangTimems_A9019Max
		{
			get
			{
				short num = (short)674693120;
				short num2 = num;
				num = (short)16812316;
				short num3 = num;
				num = (short)1411549468;
				switch (num3 == num)
				{
				}
				num = (short)537919489;
				if (num != 0)
				{
				}
				num = (short)585564160;
				if (num != 0)
				{
				}
				return this.secWideMultikeyRxHangTimems_A9019.Max;
			}
			set
			{
				short num = (short)2020671488;
				short num2 = num;
				num = (short)648298341;
				short num3 = num;
				num = (short)1509113701;
				switch (num3 == num)
				{
				}
				num = (short)583991297;
				if (num != 0)
				{
				}
				num = (short)1079574528;
				if (num != 0)
				{
				}
				this.secWideMultikeyRxHangTimems_A9019.Max = value;
			}
		}

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x060022BB RID: 8891 RVA: 0x0021F138 File Offset: 0x0021D338
		// (set) Token: 0x060022BC RID: 8892 RVA: 0x0021F1EC File Offset: 0x0021D3EC
		internal int SecWideMultikeyRxHangTimems_A9019Step
		{
			get
			{
				short num = (short)1543897088;
				short num2 = num;
				num = (short)1380714795;
				short num3 = num;
				num = (short)49350955;
				switch (num3 == num)
				{
				}
				num = (short)421920768;
				if (num != 0)
				{
				}
				num = (short)690618369;
				if (num != 0)
				{
				}
				return this.secWideMultikeyRxHangTimems_A9019.StepSize;
			}
			set
			{
				short num = (short)783417344;
				short num2 = num;
				num = (short)1273950512;
				short num3 = num;
				num = (short)847180080;
				switch (num3 == num)
				{
				}
				num = (short)1509031937;
				if (num != 0)
				{
				}
				num = (short)1260388352;
				if (num != 0)
				{
				}
				this.secWideMultikeyRxHangTimems_A9019.StepSize = value;
			}
		}

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x0021F2A0 File Offset: 0x0021D4A0
		// (set) Token: 0x060022BE RID: 8894 RVA: 0x0021F354 File Offset: 0x0021D554
		public bool SecWideMultikeyRxHangTimems_A9019_Applicable
		{
			get
			{
				short num = (short)1242234880;
				short num2 = num;
				num = (short)738542413;
				short num3 = num;
				num = (short)1498170189;
				switch (num3 == num)
				{
				}
				num = (short)1234042881;
				if (num != 0)
				{
				}
				num = (short)93847552;
				if (num != 0)
				{
				}
				return this.secWideMultikeyRxHangTimems_A9019.Applicable;
			}
			set
			{
				short num = (short)1909325824;
				short num2 = num;
				num = (short)1293670758;
				short num3 = num;
				num = (short)736221542;
				switch (num3 == num)
				{
				}
				num = (short)1326448641;
				if (num != 0)
				{
				}
				num = (short)1097531392;
				if (num != 0)
				{
				}
				this.secWideMultikeyRxHangTimems_A9019.Applicable = value;
			}
		}

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x0021F40C File Offset: 0x0021D60C
		// (set) Token: 0x060022C0 RID: 8896 RVA: 0x0021F4C0 File Offset: 0x0021D6C0
		public bool SecWideMultikeyRxHangTimems_A9019_Valid
		{
			get
			{
				short num = (short)1096417280;
				short num2 = num;
				num = (short)790953235;
				short num3 = num;
				num = (short)981269779;
				switch (num3 == num)
				{
				}
				num = (short)878182400;
				if (num != 0)
				{
				}
				num = (short)1090060289;
				if (num != 0)
				{
				}
				return this.secWideMultikeyRxHangTimems_A9019.Valid;
			}
			set
			{
				short num = (short)1817575424;
				short num2 = num;
				num = (short)1553803204;
				short num3 = num;
				num = (short)1156327364;
				switch (num3 == num)
				{
				}
				num = (short)1422393345;
				if (num != 0)
				{
				}
				num = (short)1111425024;
				if (num != 0)
				{
				}
				this.secWideMultikeyRxHangTimems_A9019.Valid = value;
			}
		}

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x060022C1 RID: 8897 RVA: 0x0021F574 File Offset: 0x0021D774
		// (set) Token: 0x060022C2 RID: 8898 RVA: 0x0021F628 File Offset: 0x0021D828
		public bool SecWideMultikeyRxHangTimems_A9019_Visible
		{
			get
			{
				short num = (short)624295936;
				short num2 = num;
				num = (short)1064540649;
				short num3 = num;
				num = (short)490248681;
				switch (num3 == num)
				{
				}
				num = (short)1605959680;
				if (num != 0)
				{
				}
				num = (short)2109079553;
				if (num != 0)
				{
				}
				return this.secWideMultikeyRxHangTimems_A9019.Visible;
			}
			set
			{
				short num = (short)1343881216;
				short num2 = num;
				num = (short)1212305233;
				short num3 = num;
				num = (short)1152470865;
				switch (num3 == num)
				{
				}
				num = (short)1415118849;
				if (num != 0)
				{
				}
				num = (short)1992294400;
				if (num != 0)
				{
				}
				this.secWideMultikeyRxHangTimems_A9019.Visible = value;
			}
		}

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x060022C3 RID: 8899 RVA: 0x0021F6DC File Offset: 0x0021D8DC
		// (set) Token: 0x060022C4 RID: 8900 RVA: 0x0021F794 File Offset: 0x0021D994
		public bool SecWideMultikeyRxHangTimems_A9019_Editable
		{
			get
			{
				short num = (short)768475136;
				short num2 = num;
				num = (short)847885211;
				short num3 = num;
				num = (short)1846588315;
				switch (num3 == num)
				{
				}
				num = (short)1913978881;
				if (num != 0)
				{
				}
				num = (short)54394880;
				if (num != 0)
				{
				}
				return this.secWideMultikeyRxHangTimems_A9019.Editable;
			}
			set
			{
				short num = (short)67960832;
				short num2 = num;
				num = (short)1010877877;
				short num3 = num;
				num = (short)942261685;
				switch (num3 == num)
				{
				}
				num = (short)180158465;
				if (num != 0)
				{
				}
				num = (short)2037121024;
				if (num != 0)
				{
				}
				this.secWideMultikeyRxHangTimems_A9019.Editable = value;
			}
		}

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x0021F848 File Offset: 0x0021DA48
		internal string SecWideMultikeyRxHangTimems_A9019_UILabel
		{
			get
			{
				short num = (short)1547632640;
				short num2 = num;
				num = (short)260801939;
				short num3 = num;
				num = (short)761496979;
				switch (num3 == num)
				{
				}
				num = (short)1533345793;
				if (num != 0)
				{
				}
				num = (short)21561344;
				if (num != 0)
				{
				}
				return this.secWideMultikeyRxHangTimems_A9019.UIName;
			}
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x060022C6 RID: 8902 RVA: 0x0021F8FC File Offset: 0x0021DAFC
		// (set) Token: 0x060022C7 RID: 8903 RVA: 0x0021F9B4 File Offset: 0x0021DBB4
		internal bool SecWideMultikeyRxHangTimems_A9019_HiddenStatic
		{
			get
			{
				short num = (short)1080360960;
				short num2 = num;
				num = (short)1474398928;
				short num3 = num;
				num = (short)2139327184;
				switch (num3 == num)
				{
				}
				num = (short)986775553;
				if (num != 0)
				{
				}
				num = (short)940507136;
				if (num != 0)
				{
				}
				return this.secWideMultikeyRxHangTimems_A9019.HiddenStatic;
			}
			set
			{
				short num = (short)668270592;
				short num2 = num;
				num = (short)1569929798;
				short num3 = num;
				num = (short)1218853446;
				switch (num3 == num)
				{
				}
				num = (short)1157300225;
				if (num != 0)
				{
				}
				num = (short)1643118592;
				if (num != 0)
				{
				}
				this.secWideMultikeyRxHangTimems_A9019.HiddenStatic = value;
			}
		}

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x060022C8 RID: 8904 RVA: 0x0021FA6C File Offset: 0x0021DC6C
		// (set) Token: 0x060022C9 RID: 8905 RVA: 0x0021FB24 File Offset: 0x0021DD24
		internal bool SecWideMultikeyRxHangTimems_A9019_HiddenDynamic
		{
			get
			{
				short num = (short)1099235328;
				short num2 = num;
				num = (short)1291355030;
				short num3 = num;
				num = (short)780764054;
				switch (num3 == num)
				{
				}
				num = (short)1733558273;
				if (num != 0)
				{
				}
				num = (short)1659371520;
				if (num != 0)
				{
				}
				return this.secWideMultikeyRxHangTimems_A9019.HiddenDynamic;
			}
			set
			{
				short num = (short)1786314752;
				short num2 = num;
				num = (short)939129501;
				short num3 = num;
				num = (short)1178270365;
				switch (num3 == num)
				{
				}
				num = (short)320339968;
				if (num != 0)
				{
				}
				num = (short)484311041;
				if (num != 0)
				{
				}
				this.secWideMultikeyRxHangTimems_A9019.HiddenDynamic = value;
			}
		}

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x060022CA RID: 8906 RVA: 0x0021FBD8 File Offset: 0x0021DDD8
		public bool SecWideMultikeyRxHangTimems_A9019_HasDiffs
		{
			get
			{
				short num = (short)904462336;
				short num2 = num;
				num = (short)2002309406;
				short num3 = num;
				num = (short)478859550;
				switch (num3 == num)
				{
				}
				num = (short)2043805697;
				if (num != 0)
				{
				}
				num = (short)319422464;
				if (num != 0)
				{
				}
				return this.secWideMultikeyRxHangTimems_A9019._HasDiffs;
			}
		}

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x0021FC8C File Offset: 0x0021DE8C
		// (set) Token: 0x060022CC RID: 8908 RVA: 0x0021FD3C File Offset: 0x0021DF3C
		public int SecWideMultikeyTxHangTimeMs_A9540Value
		{
			get
			{
				short num = (short)1987903488;
				short num2 = num;
				num = (short)437428817;
				short num3 = num;
				num = (short)1586799185;
				switch (num3 == num)
				{
				}
				num = (short)1010434048;
				if (num != 0)
				{
				}
				num = (short)132841473;
				if (num != 0)
				{
				}
				return this.secWideMultikeyTxHangTimeMs_A9540.Value;
			}
			set
			{
				short num = (short)1820196502;
				short num2 = num;
				num = (short)2025520790;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1806368768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2014904320;
				if (num != 0)
				{
				}
				num = (short)1830813697;
				if (num != 0)
				{
				}
				this.secWideMultikeyTxHangTimeMs_A9540.Value = value;
			}
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x060022CD RID: 8909 RVA: 0x0021FDF4 File Offset: 0x0021DFF4
		public global::AcpBusinessLayer.AcpSimpleRangeField SecWideMultikeyTxHangTimeMs_A9540
		{
			get
			{
				short num = (short)1971585025;
				if (num != 0)
				{
				}
				num = (short)1238827008;
				short num2 = num;
				num = (short)1632253540;
				short num3 = num;
				num = (short)61159012;
				switch (num3 == num)
				{
				}
				num = (short)632881152;
				if (num != 0)
				{
				}
				return this.secWideMultikeyTxHangTimeMs_A9540;
			}
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x060022CE RID: 8910 RVA: 0x0021FEA4 File Offset: 0x0021E0A4
		// (set) Token: 0x060022CF RID: 8911 RVA: 0x0021FF58 File Offset: 0x0021E158
		public string SecWideMultikeyTxHangTimeMs_A9540_UIValue
		{
			get
			{
				short num = (short)1077735443;
				short num2 = num;
				num = (short)1134030867;
				switch (num2 == num)
				{
				default:
				{
					num = (short)291241984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1382350849;
				if (num != 0)
				{
				}
				num = (short)1912537088;
				if (num != 0)
				{
				}
				return this.secWideMultikeyTxHangTimeMs_A9540.UIValue;
			}
			set
			{
				short num = (short)324250300;
				short num2 = num;
				num = (short)889957052;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1804992512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)765919233;
				if (num != 0)
				{
				}
				num = (short)810614784;
				if (num != 0)
				{
				}
				this.secWideMultikeyTxHangTimeMs_A9540.UIValue = value;
			}
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x00220010 File Offset: 0x0021E210
		// (set) Token: 0x060022D1 RID: 8913 RVA: 0x002200C4 File Offset: 0x0021E2C4
		internal int SecWideMultikeyTxHangTimeMs_A9540Min
		{
			get
			{
				short num = (short)2126225529;
				short num2 = num;
				num = (short)1923129465;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1932066816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)390856705;
				if (num != 0)
				{
				}
				num = (short)2025783296;
				if (num != 0)
				{
				}
				return this.secWideMultikeyTxHangTimeMs_A9540.Min;
			}
			set
			{
				short num = (short)1759797330;
				short num2 = num;
				num = (short)2062901330;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1782251520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2096627713;
				if (num != 0)
				{
				}
				num = (short)1871052800;
				if (num != 0)
				{
				}
				this.secWideMultikeyTxHangTimeMs_A9540.Min = value;
			}
		}

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x060022D2 RID: 8914 RVA: 0x00220178 File Offset: 0x0021E378
		// (set) Token: 0x060022D3 RID: 8915 RVA: 0x0022022C File Offset: 0x0021E42C
		internal int SecWideMultikeyTxHangTimeMs_A9540Max
		{
			get
			{
				short num = (short)1984619307;
				short num2 = num;
				num = (short)1539040043;
				switch (num2 == num)
				{
				default:
				{
					num = (short)535232512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1681981441;
				if (num != 0)
				{
				}
				num = (short)1290010624;
				if (num != 0)
				{
				}
				return this.secWideMultikeyTxHangTimeMs_A9540.Max;
			}
			set
			{
				short num = (short)923082555;
				short num2 = num;
				num = (short)1931026235;
				switch (num2 == num)
				{
				default:
				{
					num = (short)791937024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1436614657;
				if (num != 0)
				{
				}
				num = (short)225705984;
				if (num != 0)
				{
				}
				this.secWideMultikeyTxHangTimeMs_A9540.Max = value;
			}
		}

		// Token: 0x17001196 RID: 4502
		// (get) Token: 0x060022D4 RID: 8916 RVA: 0x002202E4 File Offset: 0x0021E4E4
		// (set) Token: 0x060022D5 RID: 8917 RVA: 0x00220398 File Offset: 0x0021E598
		internal int SecWideMultikeyTxHangTimeMs_A9540Step
		{
			get
			{
				short num = (short)2103296630;
				short num2 = num;
				num = (short)1959576182;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1138491392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1842610177;
				if (num != 0)
				{
				}
				num = (short)1069285376;
				if (num != 0)
				{
				}
				return this.secWideMultikeyTxHangTimeMs_A9540.StepSize;
			}
			set
			{
				short num = (short)1710045036;
				short num2 = num;
				num = (short)1399076716;
				switch (num2 == num)
				{
				default:
				{
					num = (short)787283968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)747307009;
				if (num != 0)
				{
				}
				num = (short)1400635392;
				if (num != 0)
				{
				}
				this.secWideMultikeyTxHangTimeMs_A9540.StepSize = value;
			}
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x060022D6 RID: 8918 RVA: 0x0022044C File Offset: 0x0021E64C
		// (set) Token: 0x060022D7 RID: 8919 RVA: 0x00220500 File Offset: 0x0021E700
		public bool SecWideMultikeyTxHangTimeMs_A9540_Applicable
		{
			get
			{
				short num = (short)1094437881;
				short num2 = num;
				num = (short)298634233;
				switch (num2 == num)
				{
				default:
				{
					num = (short)67043328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1207762944;
				if (num != 0)
				{
				}
				num = (short)2008940545;
				if (num != 0)
				{
				}
				return this.secWideMultikeyTxHangTimeMs_A9540.Applicable;
			}
			set
			{
				short num = (short)34274806;
				short num2 = num;
				num = (short)228064758;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1577451520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1555103745;
				if (num != 0)
				{
				}
				num = (short)1646788608;
				if (num != 0)
				{
				}
				this.secWideMultikeyTxHangTimeMs_A9540.Applicable = value;
			}
		}

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x060022D8 RID: 8920 RVA: 0x002205B4 File Offset: 0x0021E7B4
		// (set) Token: 0x060022D9 RID: 8921 RVA: 0x0022066C File Offset: 0x0021E86C
		public bool SecWideMultikeyTxHangTimeMs_A9540_Valid
		{
			get
			{
				short num = (short)475372655;
				short num2 = num;
				num = (short)1689951343;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1966211072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1394409472;
				if (num != 0)
				{
				}
				num = (short)196608001;
				if (num != 0)
				{
				}
				return this.secWideMultikeyTxHangTimeMs_A9540.Valid;
			}
			set
			{
				short num = (short)1281172396;
				short num2 = num;
				num = (short)183444396;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1124597760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)467533825;
				if (num != 0)
				{
				}
				num = (short)1139343360;
				if (num != 0)
				{
				}
				this.secWideMultikeyTxHangTimeMs_A9540.Valid = value;
			}
		}

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x060022DA RID: 8922 RVA: 0x00220724 File Offset: 0x0021E924
		// (set) Token: 0x060022DB RID: 8923 RVA: 0x002207D8 File Offset: 0x0021E9D8
		public bool SecWideMultikeyTxHangTimeMs_A9540_Visible
		{
			get
			{
				short num = (short)1990127906;
				short num2 = num;
				num = (short)970715426;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1646854144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)505741313;
				if (num != 0)
				{
				}
				num = (short)640548864;
				if (num != 0)
				{
				}
				return this.secWideMultikeyTxHangTimeMs_A9540.Visible;
			}
			set
			{
				short num = (short)917170194;
				short num2 = num;
				num = (short)1398466578;
				switch (num2 == num)
				{
				default:
				{
					num = (short)298188800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1507917825;
				if (num != 0)
				{
				}
				num = (short)17956864;
				if (num != 0)
				{
				}
				this.secWideMultikeyTxHangTimeMs_A9540.Visible = value;
			}
		}

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x060022DC RID: 8924 RVA: 0x00220890 File Offset: 0x0021EA90
		// (set) Token: 0x060022DD RID: 8925 RVA: 0x00220944 File Offset: 0x0021EB44
		public bool SecWideMultikeyTxHangTimeMs_A9540_Editable
		{
			get
			{
				short num = (short)367830154;
				short num2 = num;
				num = (short)1679139978;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1434451968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1624309760;
				if (num != 0)
				{
				}
				num = (short)1318256641;
				if (num != 0)
				{
				}
				return this.secWideMultikeyTxHangTimeMs_A9540.Editable;
			}
			set
			{
				short num = (short)1895525963;
				short num2 = num;
				num = (short)1270509131;
				switch (num2 == num)
				{
				default:
				{
					num = (short)49545216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1720385537;
				if (num != 0)
				{
				}
				num = (short)1379205120;
				if (num != 0)
				{
				}
				this.secWideMultikeyTxHangTimeMs_A9540.Editable = value;
			}
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x060022DE RID: 8926 RVA: 0x002209F8 File Offset: 0x0021EBF8
		internal string SecWideMultikeyTxHangTimeMs_A9540_UILabel
		{
			get
			{
				short num = (short)34899517;
				short num2 = num;
				num = (short)746948157;
				switch (num2 == num)
				{
				default:
				{
					num = (short)187498496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1404108800;
				if (num != 0)
				{
				}
				num = (short)2120024065;
				if (num != 0)
				{
				}
				return this.secWideMultikeyTxHangTimeMs_A9540.UIName;
			}
		}

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x00220AAC File Offset: 0x0021ECAC
		// (set) Token: 0x060022E0 RID: 8928 RVA: 0x00220B60 File Offset: 0x0021ED60
		internal bool SecWideMultikeyTxHangTimeMs_A9540_HiddenStatic
		{
			get
			{
				short num = (short)1956844399;
				short num2 = num;
				num = (short)1324290927;
				switch (num2 == num)
				{
				default:
				{
					num = (short)962068480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1256390657;
				if (num != 0)
				{
				}
				num = (short)35258368;
				if (num != 0)
				{
				}
				return this.secWideMultikeyTxHangTimeMs_A9540.HiddenStatic;
			}
			set
			{
				short num = (short)990733385;
				short num2 = num;
				num = (short)717186121;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2136211456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1783562240;
				if (num != 0)
				{
				}
				num = (short)543752193;
				if (num != 0)
				{
				}
				this.secWideMultikeyTxHangTimeMs_A9540.HiddenStatic = value;
			}
		}

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x060022E1 RID: 8929 RVA: 0x00220C14 File Offset: 0x0021EE14
		// (set) Token: 0x060022E2 RID: 8930 RVA: 0x00220CCC File Offset: 0x0021EECC
		internal bool SecWideMultikeyTxHangTimeMs_A9540_HiddenDynamic
		{
			get
			{
				short num = (short)1394032762;
				short num2 = num;
				num = (short)364724346;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1081802752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1859321857;
				if (num != 0)
				{
				}
				num = (short)1397161984;
				if (num != 0)
				{
				}
				return this.secWideMultikeyTxHangTimeMs_A9540.HiddenDynamic;
			}
			set
			{
				short num = (short)290455553;
				if (num != 0)
				{
				}
				num = (short)245170176;
				short num2 = num;
				num = (short)1901578875;
				short num3 = num;
				num = (short)1725352571;
				switch (num3 == num)
				{
				}
				num = (short)2069757952;
				if (num != 0)
				{
				}
				this.secWideMultikeyTxHangTimeMs_A9540.HiddenDynamic = value;
			}
		}

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x060022E3 RID: 8931 RVA: 0x00220D80 File Offset: 0x0021EF80
		public bool SecWideMultikeyTxHangTimeMs_A9540_HasDiffs
		{
			get
			{
				short num = (short)922231515;
				short num2 = num;
				num = (short)2056921819;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1781858304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)672333824;
				if (num != 0)
				{
				}
				num = (short)96272385;
				if (num != 0)
				{
				}
				return this.secWideMultikeyTxHangTimeMs_A9540._HasDiffs;
			}
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x060022E4 RID: 8932 RVA: 0x00220E34 File Offset: 0x0021F034
		public global::AcpBusinessLayer.AcpField<bool> SecWideMultikeyUserSelectable_A9604
		{
			get
			{
				short num = (short)1355662780;
				short num2 = num;
				num = (short)996656572;
				switch (num2 == num)
				{
				default:
				{
					num = (short)720109568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1143865345;
				if (num != 0)
				{
				}
				num = (short)1223098368;
				if (num != 0)
				{
				}
				return this.secWideMultikeyUserSelectable_A9604;
			}
		}

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x060022E5 RID: 8933 RVA: 0x00220EE4 File Offset: 0x0021F0E4
		public global::AcpBusinessLayer.AcpField<bool> SecWideMultikeyErasePreviousOnUserChange_A8373
		{
			get
			{
				short num = (short)998206827;
				short num2 = num;
				num = (short)435776875;
				switch (num2 == num)
				{
				default:
				{
					num = (short)257425408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1340211201;
				if (num != 0)
				{
				}
				num = (short)945684480;
				if (num != 0)
				{
				}
				return this.secWideMultikeyErasePreviousOnUserChange_A8373;
			}
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x00220F94 File Offset: 0x0021F194
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)197579678;
					short num3 = num2;
					num2 = (short)756994974;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15F;
					default:
						num2 = (short)1091305472;
						if (num2 != 0)
						{
						}
						num2 = (short)1089142785;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					num2 = (short)36962305;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)436011011;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					goto IL_85;
				case 3:
					goto IL_15F;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)1291976704;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_15F:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)218103810;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_85:
			num2 = (short)1257439232;
			short num4 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)688717828;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000BDC RID: 3036
		private global::AcpBusinessLayer.AcpListField secWideMultikeyDisplayOnModeChange_A7877;

		// Token: 0x04000BDD RID: 3037
		private global::AcpBusinessLayer.AcpListField secWideMultikeyDisplayOnPTT_A7879;

		// Token: 0x04000BDE RID: 3038
		private global::AcpBusinessLayer.AcpListField secWideMultikeyDisplayOnSecureSwitchSelect_A7881;

		// Token: 0x04000BDF RID: 3039
		private global::AcpBusinessLayer.AcpField<bool> secWideMultikeyPIDKeyManagementforASNMode_A8704;

		// Token: 0x04000BE0 RID: 3040
		private global::AcpBusinessLayer.AcpSimpleRangeField secWideMultikeyRxHangTimems_A9019;

		// Token: 0x04000BE1 RID: 3041
		private global::AcpBusinessLayer.AcpSimpleRangeField secWideMultikeyTxHangTimeMs_A9540;

		// Token: 0x04000BE2 RID: 3042
		private global::AcpBusinessLayer.AcpField<bool> secWideMultikeyUserSelectable_A9604;

		// Token: 0x04000BE3 RID: 3043
		private global::AcpBusinessLayer.AcpField<bool> secWideMultikeyErasePreviousOnUserChange_A8373;
	}
}
