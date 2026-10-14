using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList
{
	// Token: 0x020005E7 RID: 1511
	[global::System.Serializable]
	public class TalkgroupTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600CFC9 RID: 53193 RVA: 0x00C15508 File Offset: 0x00C13708
		public TalkgroupTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600CFCA RID: 53194 RVA: 0x00C15524 File Offset: 0x00C13724
		protected TalkgroupTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600CFCB RID: 53195 RVA: 0x00C1553C File Offset: 0x00C1373C
		public override void Init()
		{
			int a_ = 14;
			short num = (short)1412578437;
			short num2 = num;
			num = (short)10632325;
			switch (num2 == num)
			{
			}
			num = (short)1843265536;
			short num3 = num;
			num = (short)247136257;
			if (num != 0)
			{
			}
			num = (short)180355072;
			if (num != 0)
			{
			}
			this.astTlkgrpLstTalkgroupListKeySelectReference_A8366 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("軎ꋐ꟒臔믖님볚꿜꿞균郢釤돦裨蟪蛬裮菰鳲胴蟶뗸鋺軼课䨀昂簄吆氈朊栌氎攐䄒瀔焖簘椚砜焞䈠䘢稤昦ᄨᠪᬬ᤮", a_), global::CommonResources.AcgResources.ID_KEYSELECT, null, null, true, false);
			this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.DataTransferOrder = 7;
			this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("軎ꋐ꟒臔믖님볚꿜꿞균郢釤돦裨蟪蛬裮菰鳲胴蟶뗸鋺軼课唀戂椄氆済礊戌税愐划礔縖砘栚䤜稞夠圢稤昦ဨᤪᨬᜮ", a_), global::CommonResources.AcgResources.ID_TALKGROUPALIASTEXT, 14);
			this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.DataTransferOrder = 6;
			this.astTlkgrpLstTalkgroupListTalkgroupID_A9282 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("軎ꋐ꟒臔믖님볚꿜꿞균郢釤돦裨蟪蛬裮菰鳲胴蟶뗸鋺軼课唀戂椄氆済礊戌税愐娒儔䠖堘√⼜✞ጠ", a_), global::CommonResources.AcgResources.ID_TALKGROUPID, 0, 65535, null, null, 0, 1);
			this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.DataTransferOrder = 4;
			this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.EvaluateRecRefs = true;
			this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.ShowHexValue = true;
			this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("軎ꋐ꟒臔믖님볚꿜꿞균郢釤돦裨蟪蛬裮菰鳲胴蟶뗸鋺軼课圀氂氄搆氈堊栌氎搐愒瀔吖甘縚簜洞爠圢圤䘦夨嬪䐬䄮嘰氲琴ึ༸़ฺ", a_), global::CommonResources.AcgResources.ID_VOICESECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.LOVs.AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654LovStrs);
			this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.DataTransferOrder = 3;
			this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("軎ꋐ꟒臔믖님볚꿜꿞균郢釤돦裨蟪蛬裮菰鳲胴蟶뗸鋺軼课䔀唂圄吆娈爊縌笎琐縒尔化䘘娚⤜⼞ဠᔢᜤ", a_), global::CommonResources.AcgResources.ID_TGSYSTEMID, 0, 4094, 1, null, null);
			this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.DataTransferOrder = -1;
			this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.AddCustomValue(0, global::CommonResources.AcgResources.ID_HOMEID);
			this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.ShowHexValue = true;
			this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.ShowLeadingZeros = true;
			this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("軎ꋐ꟒臔믖님볚꿜꿞균郢釤돦裨蟪蛬裮菰鳲胴蟶뗸鋺軼课䔀唂圄吆师䨊丌䄎堐園䨔嘖ⴘ⬚Ⱌ⤞ሠ", a_), global::CommonResources.AcgResources.ID_TGWACNID, 0, 1048574, 1, null, null);
			this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.DataTransferOrder = -1;
			this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.AddCustomValue(0, global::CommonResources.AcgResources.ID_HOMEID);
			this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.ShowHexValue = true;
			this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.ShowLeadingZeros = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鯎냐뿒뻔냖ꯘ듚꣜꿞쇠럢蓤藦藨軪", a_);
			base.Id = 10153;
			base.UIName = global::CommonResources.AcgResources.ID_TALKGROUPTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600CFCC RID: 53196 RVA: 0x00C15800 File Offset: 0x00C13A00
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)927334411;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裈룊만鯎뷐룒닔ꗖ꧘韚껜ꯞ뗠苢觤賦軨駪苬髮臰뿲鳴蓶跸꿺鳼鏾樀搂眄栆簈笊䐌䬎丐划Ⱄ┖℘⤚", a_)))
					{
						goto IL_4C1;
					}
					num = (short)1527163263;
					short num3 = num;
					num = (short)97626495;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_52D;
					default:
						num = (short)1440546816;
						if (num != 0)
						{
						}
						num = (short)998965257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (producerFields != null)
					{
						goto IL_52D;
					}
					goto IL_5C8;
				case 2:
					goto IL_357;
				case 3:
					this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("裈룊만鯎뷐룒닔ꗖ꧘韚껜ꯞ뗠苢觤賦軨駪苬髮臰뿲鳴蓶跸귺鋼雾戀昂嘄戆樈縊缌樎刐缒瀔瘖欘䠚検洞䀠匢唤並䜨䰪爬渮࠰Բ4̶", a_), global::CommonResources.AcgResources.ID_VOICESECURECLEARSTRAPPING, global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.LOVs.AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654LovStrs);
					this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.DataTransferOrder = 3;
					num = (short)1857224723;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("裈룊만鯎뷐룒닔ꗖ꧘韚껜ꯞ뗠苢觤賦軨駪苬髮臰뿲鳴蓶跸뿺꯼귾刀倂簄理紈渊怌䘎唐䰒吔⌖⤘⨚⬜ⴞ", a_), global::CommonResources.AcgResources.ID_TGSYSTEMID, null, null);
					this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.DataTransferOrder = -1;
					this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.AddCustomValue(0, global::CommonResources.AcgResources.ID_HOMEID);
					this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.ShowHexValue = true;
					this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.ShowLeadingZeros = true;
					num = (short)1522728966;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裈룊만鯎뷐룒닔ꗖ꧘韚껜ꯞ뗠苢觤賦軨駪苬髮臰뿲鳴蓶跸꿺鳼鏾樀搂眄栆簈笊䰌挎砐爒昔䌖簘挚検䀞怠ᨢᜤဦᄨ", a_)))
					{
						num = (short)427163665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_35C;
				case 6:
					goto IL_1BF;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裈룊만鯎뷐룒닔ꗖ꧘韚껜ꯞ뗠苢觤賦軨駪苬髮臰뿲鳴蓶跸뿺꯼귾刀倂簄理紈渊怌䘎唐䰒吔⌖⤘⨚⬜ⴞ", a_)))
					{
						num = (short)1574436868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BF;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裈룊만鯎뷐룒닔ꗖ꧘韚껜ꯞ뗠苢觤賦軨駪苬髮臰뿲鳴蓶跸귺鋼雾戀昂嘄戆樈縊缌樎刐缒瀔瘖欘䠚検洞䀠匢唤並䜨䰪爬渮࠰Բ4̶", a_)))
					{
						num = (short)952762371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AA;
				case 9:
					this.astTlkgrpLstTalkgroupListTalkgroupID_A9282 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("裈룊만鯎뷐룒닔ꗖ꧘韚껜ꯞ뗠苢觤賦軨駪苬髮臰뿲鳴蓶跸꿺鳼鏾樀搂眄栆簈笊䐌䬎丐划Ⱄ┖℘⤚", a_), global::CommonResources.AcgResources.ID_TALKGROUPID, null, null, 0, 1);
					this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.DataTransferOrder = 4;
					this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.EvaluateRecRefs = true;
					this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.ShowHexValue = true;
					num = (short)169279508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_3F3;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_87;
					}
					continue;
				case 12:
					this.astTlkgrpLstTalkgroupListKeySelectReference_A8366 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("裈룊만鯎뷐룒닔ꗖ꧘韚껜ꯞ뗠苢觤賦軨駪苬髮臰뿲鳴蓶跸냺飼蛾刀昂椄戆樈缊弌樎眐瘒朔爖眘砚砜䀞怠ᬢᘤᄦἨ", a_), global::CommonResources.AcgResources.ID_KEYSELECT, null, null, true, false);
					this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.DataTransferOrder = 7;
					num = (short)720306186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裈룊만鯎뷐룒닔ꗖ꧘韚껜ꯞ뗠苢觤賦軨駪苬髮臰뿲鳴蓶跸냺飼蛾刀昂椄戆樈缊弌樎眐瘒朔爖眘砚砜䀞怠ᬢᘤᄦἨ", a_)))
					{
						num = (short)1514078220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3F3;
				case 14:
					num = (short)1588461569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_35C;
				case 16:
				{
					this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163 = new global::AcpBusinessLayer.AcpCustomRangeField(0, this, global::AllFeatures.CodeplugGuid.b("裈룊만鯎뷐룒닔ꗖ꧘韚껜ꯞ뗠苢觤賦軨駪苬髮臰뿲鳴蓶跸뿺꯼귾刀吂䐄䐆䜈䈊䤌倎倐✒└☖⼘⠚", a_), global::CommonResources.AcgResources.ID_TGWACNID, null, null);
					this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.DataTransferOrder = -1;
					this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.AddCustomValue(0, global::CommonResources.AcgResources.ID_HOMEID);
					this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.ShowHexValue = true;
					this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.ShowLeadingZeros = true;
					num = (short)530317312;
					short num4 = num;
					num = (short)801046530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 17:
					this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("裈룊만鯎뷐룒닔ꗖ꧘韚껜ꯞ뗠苢觤賦軨駪苬髮臰뿲鳴蓶跸꿺鳼鏾樀搂眄栆簈笊䰌挎砐爒昔䌖簘挚検䀞怠ᨢᜤဦᄨ", a_), global::CommonResources.AcgResources.ID_TALKGROUPALIASTEXT, 14);
					this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.DataTransferOrder = 6;
					num = (short)156565505;
					if (num != 0)
					{
					}
					num = (short)327695;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					num = (short)1298530317;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					goto IL_AA;
				case 20:
					goto IL_4C1;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裈룊만鯎뷐룒닔ꗖ꧘韚껜ꯞ뗠苢觤賦軨駪苬髮臰뿲鳴蓶跸뿺꯼귾刀吂䐄䐆䜈䈊䤌倎倐✒└☖⼘⠚", a_)))
					{
						num = (short)714473488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5C8;
				}
				IL_87:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)594608142;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_AA:
				num = (short)2104295431;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1BF:
				num = (short)1809973269;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_35C:
				num = (short)2109014016;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3F3:
				num = (short)653983749;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4C1:
				num = (short)630587400;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_52D:
				num = (short)1997930514;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_357:
			IL_5C8:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鷈꫊ꇌ꓎뛐ꇒ뫔ꋖ꧘ﯚ觜뻞菠迢胤", a_);
			base.Id = 10153;
			base.UIName = global::CommonResources.AcgResources.ID_TALKGROUPTABLE;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600CFCD RID: 53197 RVA: 0x00C15E08 File Offset: 0x00C14008
		public override void PopulateReferences()
		{
			short num = (short)1753610803;
			short num2 = num;
			num = (short)1144060467;
			switch (num2 == num)
			{
			}
			num = (short)1431830528;
			short num3 = num;
			num = (short)1032257537;
			if (num != 0)
			{
			}
			num = (short)1284898816;
			if (num != 0)
			{
			}
			global::AcpCommonLib.IAcpRecordset recset = this.a();
			this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.SetRecset(recset);
		}

		// Token: 0x0600CFCE RID: 53198 RVA: 0x00C15EC4 File Offset: 0x00C140C4
		private global::AcpCommonLib.IAcpRecordset a()
		{
			short num = (short)2027487232;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9E;
				}
				global::AcpCommonLib.IAcpRecordset embeddedRecset;
				for (;;)
				{
					IL_28:
					num = (short)1328873472;
					short num3 = num;
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
					bool? flag;
					bool? flag3;
					bool flag4;
					switch (num2)
					{
					case 0:
						goto IL_309;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.General general;
						secureKMFProfile = (general.AstTlkgrpLstGeneralKMFProfileIndex_A8380.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile);
						num = (short)202637327;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1745879048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1626079244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)261226496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						embeddedRecset = secureKMFProfile.SecureHardwareEncryptionIndependentKeyList.EmbeddedRecset;
						num = (short)1662517258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (base.ParentRecset != null)
						{
							num = (short)343670800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					case 7:
						num = (short)1643315201;
						if (num != 0)
						{
						}
						if (base.ParentRecset.ParentSection != null)
						{
							num = (short)2001076226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					case 8:
					{
						if (base.ParentRecset.ParentSection.Parent == null)
						{
							return embeddedRecset;
						}
						num = (short)1590578167;
						short num4 = num;
						num = (short)1167084535;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_309;
						default:
							num = (short)122290176;
							if (num != 0)
							{
							}
							num = (short)680787977;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.General general = base.ParentRecset.ParentSection.Parent[10151] as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.General;
						num = (short)1175650317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						return embeddedRecset;
					case 11:
					{
						bool? flag2;
						flag = flag2;
						goto IL_34C;
					}
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.General general;
						if (general.AstTlkgrpLstGeneralKMFProfileIndex_A8380.ReferencedNode != null)
						{
							num = (short)1806761985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					}
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.General general;
						if (general.AstTlkgrpLstGeneralKMFProfileIndex_A8380.Value > 0)
						{
							num = (short)1442775043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					}
					case 14:
						if (flag3.GetValueOrDefault() == flag4 & flag3 != null)
						{
							num = (short)1019674629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					case 15:
						if (secureKMFProfile != null)
						{
							num = (short)868810756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return embeddedRecset;
					case 16:
						num = (short)114294791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9E;
					IL_309:
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general2 = secureKMFProfile.General;
					if (general2 == null)
					{
						bool? flag2 = null;
						num = (short)1785397259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					flag = new bool?(general2.SecKmfProfGenIndependentKeyList_43597.Value);
					IL_34C:
					flag3 = flag;
					flag4 = true;
					num = (short)1182990350;
					num2 = (int)((global::System.IntPtr)num);
				}
				return embeddedRecset;
				IL_9E:
				embeddedRecset = this.a(2021)[0][10040].EmbeddedRecset;
				num = (short)1179385862;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600CFCF RID: 53199 RVA: 0x00C16294 File Offset: 0x00C14494
		public override void DropReferences()
		{
			short num = (short)591267739;
			short num2 = num;
			num = (short)2000553883;
			switch (num2 == num)
			{
			default:
			{
				num = (short)987430912;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1304363009;
			if (num != 0)
			{
			}
			num = (short)2046296064;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600CFD0 RID: 53200 RVA: 0x00C1633C File Offset: 0x00C1453C
		public override void SetConstraints()
		{
			short num = (short)603673340;
			short num2 = num;
			num = (short)248206076;
			switch (num2 == num)
			{
			default:
			{
				num = (short)565379072;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)878641152;
			if (num != 0)
			{
			}
			num = (short)656080897;
			if (num != 0)
			{
			}
			this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListConstraints.ConSecureOperationIsNotDisabledAndCnvTlkGrpSecureTypeIsNotClear);
			this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListConstraints.ConKeySelect8366IsValid);
			this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListConstraints.ConTalkGroupListAliasIsEnabled);
			this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListConstraints.ConCallConIsAstroRxUnmuteRuleValid);
			this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListConstraints.ConHwCryptoCapable);
		}

		// Token: 0x0600CFD1 RID: 53201 RVA: 0x00C16458 File Offset: 0x00C14658
		public override void SetupDependencies()
		{
			short num = (short)1443089006;
			short num2 = num;
			num = (short)1779812974;
			switch (num2 == num)
			{
			default:
			{
				num = (short)481165312;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1258881025;
			if (num != 0)
			{
			}
			num = (short)2139226112;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList astrotalkgroupList = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList;
			this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.AddDependentObject(this.astTlkgrpLstTalkgroupListKeySelectReference_A8366);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.astTlkgrpLstTalkgroupListKeySelectReference_A8366);
			astrotalkgroupList.General.AstTlkgrpLstGeneralTalkgroupAlias_A9277.AddDependentObject(this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278);
			this.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.AddDependentObject(this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654);
		}

		// Token: 0x1700685C RID: 26716
		// (get) Token: 0x0600CFD2 RID: 53202 RVA: 0x00C16578 File Offset: 0x00C14778
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner EncryptionKeyListInnerSectionForAstTlkgrpLstTalkgroupListKeySelectReference_A8366
		{
			get
			{
				short num = (short)1898556459;
				short num2 = num;
				num = (short)437300267;
				switch (num2 == num)
				{
				default:
				{
					num = (short)394788864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1740898305;
				if (num != 0)
				{
				}
				num = (short)335937536;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInner;
			}
		}

		// Token: 0x1700685D RID: 26717
		// (get) Token: 0x0600CFD3 RID: 53203 RVA: 0x00C16630 File Offset: 0x00C14830
		public bool HasDiffs
		{
			get
			{
				short num = (short)8764557;
				short num2 = num;
				num = (short)1419295885;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2135687168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1522466816;
				if (num != 0)
				{
				}
				num = (short)171245569;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700685E RID: 26718
		// (get) Token: 0x0600CFD4 RID: 53204 RVA: 0x00C166E0 File Offset: 0x00C148E0
		// (set) Token: 0x0600CFD5 RID: 53205 RVA: 0x00C16794 File Offset: 0x00C14994
		public int AstTlkgrpLstTalkgroupListKeySelectReference_A8366Value
		{
			get
			{
				short num = (short)163297452;
				short num2 = num;
				num = (short)858699948;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1099235328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1684865025;
				if (num != 0)
				{
				}
				num = (short)359661568;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.Value;
			}
			set
			{
				short num = (short)1575918941;
				short num2 = num;
				num = (short)2080152925;
				switch (num2 == num)
				{
				default:
				{
					num = (short)430178304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1285029889;
				if (num != 0)
				{
				}
				num = (short)323616768;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.Value = value;
			}
		}

		// Token: 0x1700685F RID: 26719
		// (get) Token: 0x0600CFD6 RID: 53206 RVA: 0x00C1684C File Offset: 0x00C14A4C
		// (set) Token: 0x0600CFD7 RID: 53207 RVA: 0x00C16900 File Offset: 0x00C14B00
		public string AstTlkgrpLstTalkgroupListKeySelectReference_A8366_UIValue
		{
			get
			{
				short num = (short)1213139904;
				short num2 = num;
				num = (short)946801600;
				switch (num2 == num)
				{
				default:
				{
					num = (short)323092480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)88014849;
				if (num != 0)
				{
				}
				num = (short)1831206912;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.UIValue;
			}
			set
			{
				short num = (short)1269178490;
				short num2 = num;
				num = (short)1361715322;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1211498496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)12517376;
				if (num != 0)
				{
				}
				num = (short)775684097;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.UIValue = value;
			}
		}

		// Token: 0x17006860 RID: 26720
		// (get) Token: 0x0600CFD8 RID: 53208 RVA: 0x00C169B4 File Offset: 0x00C14BB4
		public global::AcpBusinessLayer.AcpRecRefField AstTlkgrpLstTalkgroupListKeySelectReference_A8366
		{
			get
			{
				short num = (short)483006586;
				short num2 = num;
				num = (short)2023037050;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1162477568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)450035713;
				if (num != 0)
				{
				}
				num = (short)2110062592;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListKeySelectReference_A8366;
			}
		}

		// Token: 0x17006861 RID: 26721
		// (get) Token: 0x0600CFD9 RID: 53209 RVA: 0x00C16A64 File Offset: 0x00C14C64
		// (set) Token: 0x0600CFDA RID: 53210 RVA: 0x00C16B18 File Offset: 0x00C14D18
		public bool AstTlkgrpLstTalkgroupListKeySelectReference_A8366_Applicable
		{
			get
			{
				short num = (short)1307442651;
				short num2 = num;
				num = (short)2042297819;
				switch (num2 == num)
				{
				default:
				{
					num = (short)266797056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)293142529;
				if (num != 0)
				{
				}
				num = (short)1080033280;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.Applicable;
			}
			set
			{
				short num = (short)969553178;
				short num2 = num;
				num = (short)1070347546;
				switch (num2 == num)
				{
				default:
				{
					num = (short)733806592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1000341504;
				if (num != 0)
				{
				}
				num = (short)128581633;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.Applicable = value;
			}
		}

		// Token: 0x17006862 RID: 26722
		// (get) Token: 0x0600CFDB RID: 53211 RVA: 0x00C16BD0 File Offset: 0x00C14DD0
		// (set) Token: 0x0600CFDC RID: 53212 RVA: 0x00C16C84 File Offset: 0x00C14E84
		public bool AstTlkgrpLstTalkgroupListKeySelectReference_A8366_Valid
		{
			get
			{
				short num = (short)1052045203;
				short num2 = num;
				num = (short)1999564691;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1943076864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1458634753;
				if (num != 0)
				{
				}
				num = (short)768344064;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.Valid;
			}
			set
			{
				short num = (short)2049100252;
				short num2 = num;
				num = (short)445565404;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1658191872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1346895873;
				if (num != 0)
				{
				}
				num = (short)290652160;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.Valid = value;
			}
		}

		// Token: 0x17006863 RID: 26723
		// (get) Token: 0x0600CFDD RID: 53213 RVA: 0x00C16D38 File Offset: 0x00C14F38
		// (set) Token: 0x0600CFDE RID: 53214 RVA: 0x00C16DF0 File Offset: 0x00C14FF0
		public bool AstTlkgrpLstTalkgroupListKeySelectReference_A8366_Visible
		{
			get
			{
				short num = (short)960606223;
				short num2 = num;
				num = (short)306884623;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1385431040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)572522497;
				if (num != 0)
				{
				}
				num = (short)652804096;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.Visible;
			}
			set
			{
				short num = (short)949675225;
				short num2 = num;
				num = (short)2107958489;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1232404480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1246560257;
				if (num != 0)
				{
				}
				num = (short)1954086912;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.Visible = value;
			}
		}

		// Token: 0x17006864 RID: 26724
		// (get) Token: 0x0600CFDF RID: 53215 RVA: 0x00C16EA4 File Offset: 0x00C150A4
		// (set) Token: 0x0600CFE0 RID: 53216 RVA: 0x00C16F58 File Offset: 0x00C15158
		public bool AstTlkgrpLstTalkgroupListKeySelectReference_A8366_Editable
		{
			get
			{
				short num = (short)1478762220;
				short num2 = num;
				num = (short)936713964;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1114832896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1770782721;
				if (num != 0)
				{
				}
				num = (short)1829437440;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.Editable;
			}
			set
			{
				short num = (short)1321577331;
				short num2 = num;
				num = (short)277850995;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1462501376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)206045184;
				if (num != 0)
				{
				}
				num = (short)1996881921;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.Editable = value;
			}
		}

		// Token: 0x17006865 RID: 26725
		// (get) Token: 0x0600CFE1 RID: 53217 RVA: 0x00C1700C File Offset: 0x00C1520C
		internal string AstTlkgrpLstTalkgroupListKeySelectReference_A8366_UILabel
		{
			get
			{
				short num = (short)1886301068;
				short num2 = num;
				num = (short)2111089548;
				switch (num2 == num)
				{
				default:
				{
					num = (short)534708224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1516240897;
				if (num != 0)
				{
				}
				num = (short)1776091136;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.UIName;
			}
		}

		// Token: 0x17006866 RID: 26726
		// (get) Token: 0x0600CFE2 RID: 53218 RVA: 0x00C170C0 File Offset: 0x00C152C0
		// (set) Token: 0x0600CFE3 RID: 53219 RVA: 0x00C17174 File Offset: 0x00C15374
		internal bool AstTlkgrpLstTalkgroupListKeySelectReference_A8366_HiddenStatic
		{
			get
			{
				short num = (short)1960664515;
				short num2 = num;
				num = (short)694640067;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2102132736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)789970945;
				if (num != 0)
				{
				}
				num = (short)557907968;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.HiddenStatic;
			}
			set
			{
				short num = (short)276441527;
				short num2 = num;
				num = (short)258156983;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1745682432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)641400833;
				if (num != 0)
				{
				}
				num = (short)1147535360;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.HiddenStatic = value;
			}
		}

		// Token: 0x17006867 RID: 26727
		// (get) Token: 0x0600CFE4 RID: 53220 RVA: 0x00C1722C File Offset: 0x00C1542C
		// (set) Token: 0x0600CFE5 RID: 53221 RVA: 0x00C172E4 File Offset: 0x00C154E4
		internal bool AstTlkgrpLstTalkgroupListKeySelectReference_A8366_HiddenDynamic
		{
			get
			{
				short num = (short)1955045591;
				short num2 = num;
				num = (short)947101911;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1429405696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)257949697;
				if (num != 0)
				{
				}
				num = (short)1193607168;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.HiddenDynamic;
			}
			set
			{
				short num = (short)1571551428;
				short num2 = num;
				num = (short)1368127684;
				switch (num2 == num)
				{
				default:
				{
					num = (short)597753856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1029505025;
				if (num != 0)
				{
				}
				num = (short)1668218880;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListKeySelectReference_A8366.HiddenDynamic = value;
			}
		}

		// Token: 0x17006868 RID: 26728
		// (get) Token: 0x0600CFE6 RID: 53222 RVA: 0x00C1739C File Offset: 0x00C1559C
		public bool AstTlkgrpLstTalkgroupListKeySelectReference_A8366_HasDiffs
		{
			get
			{
				short num = (short)424107724;
				short num2 = num;
				num = (short)1120689868;
				switch (num2 == num)
				{
				default:
				{
					num = (short)411172864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1443692545;
				if (num != 0)
				{
				}
				num = (short)1219362816;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListKeySelectReference_A8366._HasDiffs;
			}
		}

		// Token: 0x17006869 RID: 26729
		// (get) Token: 0x0600CFE7 RID: 53223 RVA: 0x00C17450 File Offset: 0x00C15650
		// (set) Token: 0x0600CFE8 RID: 53224 RVA: 0x00C17504 File Offset: 0x00C15704
		public string AstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278Value
		{
			get
			{
				short num = (short)1212704833;
				short num2 = num;
				num = (short)1932879937;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1425276928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)751632385;
				if (num != 0)
				{
				}
				num = (short)1060896768;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.Value;
			}
			set
			{
				short num = (short)1518141442;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)439484416;
						short num3 = num;
						this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.Value = value;
						num = (short)339017728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)1450938342;
					short num4 = num;
					num = (short)1273925606;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)874053633;
						if (num != 0)
						{
						}
						num = (short)337707008;
						if (num != 0)
						{
						}
						num = (short)156565505;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x1700686A RID: 26730
		// (get) Token: 0x0600CFE9 RID: 53225 RVA: 0x00C1762C File Offset: 0x00C1582C
		// (set) Token: 0x0600CFEA RID: 53226 RVA: 0x00C176E0 File Offset: 0x00C158E0
		public string AstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278_UIValue
		{
			get
			{
				short num = (short)1931495088;
				short num2 = num;
				num = (short)1708541616;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1433272320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2063400961;
				if (num != 0)
				{
				}
				num = (short)1449984000;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.Value;
			}
			set
			{
				short num = (short)493813761;
				if (num != 0)
				{
				}
				num = (short)757858304;
				short num2 = num;
				num = (short)1231760610;
				short num3 = num;
				num = (short)1418210530;
				switch (num3 == num)
				{
				}
				num = (short)2116747264;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.Value = value;
			}
		}

		// Token: 0x1700686B RID: 26731
		// (get) Token: 0x0600CFEB RID: 53227 RVA: 0x00C17798 File Offset: 0x00C15998
		public global::AcpBusinessLayer.AcpKeyField AstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278
		{
			get
			{
				short num = (short)481837340;
				short num2 = num;
				num = (short)1603748124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)196411392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1630535680;
				if (num != 0)
				{
				}
				num = (short)1883242497;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278;
			}
		}

		// Token: 0x1700686C RID: 26732
		// (get) Token: 0x0600CFEC RID: 53228 RVA: 0x00C17848 File Offset: 0x00C15A48
		// (set) Token: 0x0600CFED RID: 53229 RVA: 0x00C178FC File Offset: 0x00C15AFC
		public bool AstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278_Applicable
		{
			get
			{
				short num = (short)630642094;
				short num2 = num;
				num = (short)1510004142;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2087190528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1514340353;
				if (num != 0)
				{
				}
				num = (short)12582912;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.Applicable;
			}
			set
			{
				short num = (short)195821569;
				if (num != 0)
				{
				}
				num = (short)1017249792;
				short num2 = num;
				num = (short)974561847;
				short num3 = num;
				num = (short)1364369975;
				switch (num3 == num)
				{
				}
				num = (short)438173696;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.Applicable = value;
			}
		}

		// Token: 0x1700686D RID: 26733
		// (get) Token: 0x0600CFEE RID: 53230 RVA: 0x00C179B4 File Offset: 0x00C15BB4
		// (set) Token: 0x0600CFEF RID: 53231 RVA: 0x00C17A6C File Offset: 0x00C15C6C
		public bool AstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278_Valid
		{
			get
			{
				short num = (short)2010039486;
				short num2 = num;
				num = (short)1289405630;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2002321408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1636040705;
				if (num != 0)
				{
				}
				num = (short)496041984;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.Valid;
			}
			set
			{
				short num = (short)993444963;
				short num2 = num;
				num = (short)93308003;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1437138944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)968949761;
				if (num != 0)
				{
				}
				num = (short)1580400640;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.Valid = value;
			}
		}

		// Token: 0x1700686E RID: 26734
		// (get) Token: 0x0600CFF0 RID: 53232 RVA: 0x00C17B20 File Offset: 0x00C15D20
		// (set) Token: 0x0600CFF1 RID: 53233 RVA: 0x00C17BD4 File Offset: 0x00C15DD4
		public bool AstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278_Visible
		{
			get
			{
				short num = (short)1466460305;
				short num2 = num;
				num = (short)1837852817;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1108410368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)847314945;
				if (num != 0)
				{
				}
				num = (short)1052508160;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.Visible;
			}
			set
			{
				short num = (short)1127720535;
				short num2 = num;
				num = (short)1410639447;
				switch (num2 == num)
				{
				default:
				{
					num = (short)822083584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)775290881;
				if (num != 0)
				{
				}
				num = (short)661061632;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.Visible = value;
			}
		}

		// Token: 0x1700686F RID: 26735
		// (get) Token: 0x0600CFF2 RID: 53234 RVA: 0x00C17C8C File Offset: 0x00C15E8C
		// (set) Token: 0x0600CFF3 RID: 53235 RVA: 0x00C17D40 File Offset: 0x00C15F40
		public bool AstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278_Editable
		{
			get
			{
				short num = (short)5525239;
				short num2 = num;
				num = (short)255741687;
				switch (num2 == num)
				{
				default:
				{
					num = (short)786956288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1281687553;
				if (num != 0)
				{
				}
				num = (short)2009530368;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.Editable;
			}
			set
			{
				short num = (short)1840693563;
				short num2 = num;
				num = (short)9421115;
				switch (num2 == num)
				{
				default:
				{
					num = (short)490536960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1273888769;
				if (num != 0)
				{
				}
				num = (short)1601110016;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.Editable = value;
			}
		}

		// Token: 0x17006870 RID: 26736
		// (get) Token: 0x0600CFF4 RID: 53236 RVA: 0x00C17DF4 File Offset: 0x00C15FF4
		internal string AstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278_UILabel
		{
			get
			{
				short num = (short)1652880515;
				short num2 = num;
				num = (short)1961227395;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1414856704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)770310145;
				if (num != 0)
				{
				}
				num = (short)1816199168;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.UIName;
			}
		}

		// Token: 0x17006871 RID: 26737
		// (get) Token: 0x0600CFF5 RID: 53237 RVA: 0x00C17EA8 File Offset: 0x00C160A8
		// (set) Token: 0x0600CFF6 RID: 53238 RVA: 0x00C17F5C File Offset: 0x00C1615C
		internal bool AstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278_HiddenStatic
		{
			get
			{
				short num = (short)908491960;
				short num2 = num;
				num = (short)1521843384;
				switch (num2 == num)
				{
				default:
				{
					num = (short)336330752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)13303808;
				if (num != 0)
				{
				}
				num = (short)161153025;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.HiddenStatic;
			}
			set
			{
				short num = (short)1691025409;
				if (num != 0)
				{
				}
				num = (short)406781952;
				short num2 = num;
				num = (short)1193882479;
				short num3 = num;
				num = (short)380580719;
				switch (num3 == num)
				{
				}
				num = (short)493944832;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.HiddenStatic = value;
			}
		}

		// Token: 0x17006872 RID: 26738
		// (get) Token: 0x0600CFF7 RID: 53239 RVA: 0x00C18010 File Offset: 0x00C16210
		// (set) Token: 0x0600CFF8 RID: 53240 RVA: 0x00C180C4 File Offset: 0x00C162C4
		internal bool AstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278_HiddenDynamic
		{
			get
			{
				short num = (short)1989407141;
				short num2 = num;
				num = (short)1453453733;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1123352576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)806092801;
				if (num != 0)
				{
				}
				num = (short)1493893120;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.HiddenDynamic;
			}
			set
			{
				short num = (short)819667158;
				short num2 = num;
				num = (short)1697718486;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1333198848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)201261057;
				if (num != 0)
				{
				}
				num = (short)208207872;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278.HiddenDynamic = value;
			}
		}

		// Token: 0x17006873 RID: 26739
		// (get) Token: 0x0600CFF9 RID: 53241 RVA: 0x00C18178 File Offset: 0x00C16378
		public bool AstTlkgrpLstTalkgroupListTalkgroupAliasText_A9278_HasDiffs
		{
			get
			{
				short num = (short)564660547;
				short num2 = num;
				num = (short)1087113539;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1194524672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)263913473;
				if (num != 0)
				{
				}
				num = (short)1563361280;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278._HasDiffs;
			}
		}

		// Token: 0x17006874 RID: 26740
		// (get) Token: 0x0600CFFA RID: 53242 RVA: 0x00C18230 File Offset: 0x00C16430
		// (set) Token: 0x0600CFFB RID: 53243 RVA: 0x00C182E4 File Offset: 0x00C164E4
		public int AstTlkgrpLstTalkgroupListTalkgroupID_A9282Value
		{
			get
			{
				short num = (short)561112173;
				short num2 = num;
				num = (short)1257497709;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1157365760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1574830080;
				if (num != 0)
				{
				}
				num = (short)1934163969;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.Value;
			}
			set
			{
				short num = (short)62689538;
				short num2 = num;
				num = (short)169382146;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1810300928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1562705921;
				if (num != 0)
				{
				}
				num = (short)726925312;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.Value = value;
			}
		}

		// Token: 0x17006875 RID: 26741
		// (get) Token: 0x0600CFFC RID: 53244 RVA: 0x00C1839C File Offset: 0x00C1659C
		public global::AcpBusinessLayer.AcpSimpleRangeField AstTlkgrpLstTalkgroupListTalkgroupID_A9282
		{
			get
			{
				short num = (short)1982671484;
				short num2 = num;
				num = (short)1161964156;
				switch (num2 == num)
				{
				default:
				{
					num = (short)314048512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)834338816;
				if (num != 0)
				{
				}
				num = (short)1639383041;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListTalkgroupID_A9282;
			}
		}

		// Token: 0x17006876 RID: 26742
		// (get) Token: 0x0600CFFD RID: 53245 RVA: 0x00C1844C File Offset: 0x00C1664C
		// (set) Token: 0x0600CFFE RID: 53246 RVA: 0x00C18500 File Offset: 0x00C16700
		public string AstTlkgrpLstTalkgroupListTalkgroupID_A9282_UIValue
		{
			get
			{
				short num = (short)1372303950;
				short num2 = num;
				num = (short)440775246;
				switch (num2 == num)
				{
				default:
				{
					num = (short)373882880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)546045953;
				if (num != 0)
				{
				}
				num = (short)1925840896;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.UIValue;
			}
			set
			{
				short num = (short)310344640;
				short num2 = num;
				num = (short)1519352768;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2144272384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)699072512;
				if (num != 0)
				{
				}
				num = (short)920715265;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.UIValue = value;
			}
		}

		// Token: 0x17006877 RID: 26743
		// (get) Token: 0x0600CFFF RID: 53247 RVA: 0x00C185B4 File Offset: 0x00C167B4
		// (set) Token: 0x0600D000 RID: 53248 RVA: 0x00C1866C File Offset: 0x00C1686C
		public string AstTlkgrpLstTalkgroupListTalkgroupID_A9282_HexUIValue
		{
			get
			{
				short num = (short)1598081111;
				short num2 = num;
				num = (short)378849367;
				switch (num2 == num)
				{
				default:
				{
					num = (short)462487552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)911998976;
				if (num != 0)
				{
				}
				num = (short)1462632449;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.HexUIValue;
			}
			set
			{
				short num = (short)796000257;
				if (num != 0)
				{
				}
				num = (short)1465384960;
				short num2 = num;
				num = (short)1737917209;
				short num3 = num;
				num = (short)1616413465;
				switch (num3 == num)
				{
				}
				num = (short)855965696;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.HexUIValue = value;
			}
		}

		// Token: 0x17006878 RID: 26744
		// (get) Token: 0x0600D001 RID: 53249 RVA: 0x00C18720 File Offset: 0x00C16920
		// (set) Token: 0x0600D002 RID: 53250 RVA: 0x00C187D8 File Offset: 0x00C169D8
		internal int AstTlkgrpLstTalkgroupListTalkgroupID_A9282Min
		{
			get
			{
				short num = (short)1718667771;
				short num2 = num;
				num = (short)1477888507;
				switch (num2 == num)
				{
				}
				num = (short)467075073;
				if (num != 0)
				{
				}
				num = (short)412680192;
				if (num != 0)
				{
				}
				num = (short)1000079360;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.Min;
			}
			set
			{
				short num = (short)2010288401;
				short num2 = num;
				num = (short)1249153297;
				switch (num2 == num)
				{
				}
				num = (short)1742274561;
				if (num != 0)
				{
				}
				num = (short)549978112;
				if (num != 0)
				{
				}
				num = (short)866910208;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.Min = value;
			}
		}

		// Token: 0x17006879 RID: 26745
		// (get) Token: 0x0600D003 RID: 53251 RVA: 0x00C1888C File Offset: 0x00C16A8C
		// (set) Token: 0x0600D004 RID: 53252 RVA: 0x00C18940 File Offset: 0x00C16B40
		internal int AstTlkgrpLstTalkgroupListTalkgroupID_A9282Max
		{
			get
			{
				short num = (short)457309682;
				short num2 = num;
				num = (short)998374898;
				switch (num2 == num)
				{
				}
				num = (short)1445920769;
				if (num != 0)
				{
				}
				num = (short)1790246912;
				if (num != 0)
				{
				}
				num = (short)1138753536;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.Max;
			}
			set
			{
				short num = (short)1164181505;
				if (num != 0)
				{
				}
				num = (short)1731107952;
				short num2 = num;
				num = (short)2133105776;
				switch (num2 == num)
				{
				}
				num = (short)661323776;
				if (num != 0)
				{
				}
				num = (short)1824063488;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.Max = value;
			}
		}

		// Token: 0x1700687A RID: 26746
		// (get) Token: 0x0600D005 RID: 53253 RVA: 0x00C189F4 File Offset: 0x00C16BF4
		// (set) Token: 0x0600D006 RID: 53254 RVA: 0x00C18AAC File Offset: 0x00C16CAC
		internal int AstTlkgrpLstTalkgroupListTalkgroupID_A9282Step
		{
			get
			{
				short num = (short)599532096;
				short num2 = num;
				num = (short)1226383936;
				switch (num2 == num)
				{
				}
				num = (short)406257665;
				if (num != 0)
				{
				}
				num = (short)1460273152;
				if (num != 0)
				{
				}
				num = (short)1354825728;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.StepSize;
			}
			set
			{
				short num = (short)1778017988;
				short num2 = num;
				num = (short)1203594948;
				switch (num2 == num)
				{
				}
				num = (short)1114374144;
				if (num != 0)
				{
				}
				num = (short)492634113;
				if (num != 0)
				{
				}
				num = (short)1888878592;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.StepSize = value;
			}
		}

		// Token: 0x1700687B RID: 26747
		// (get) Token: 0x0600D007 RID: 53255 RVA: 0x00C18B64 File Offset: 0x00C16D64
		// (set) Token: 0x0600D008 RID: 53256 RVA: 0x00C18C14 File Offset: 0x00C16E14
		public bool AstTlkgrpLstTalkgroupListTalkgroupID_A9282_Applicable
		{
			get
			{
				short num = (short)1218796087;
				short num2 = num;
				num = (short)1603820087;
				switch (num2 == num)
				{
				}
				num = (short)558694401;
				if (num != 0)
				{
				}
				num = (short)519045120;
				if (num != 0)
				{
				}
				num = (short)760938496;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.Applicable;
			}
			set
			{
				short num = (short)1391946657;
				short num2 = num;
				num = (short)1887726497;
				switch (num2 == num)
				{
				}
				num = (short)213712896;
				if (num != 0)
				{
				}
				num = (short)1762983937;
				if (num != 0)
				{
				}
				num = (short)420741120;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.Applicable = value;
			}
		}

		// Token: 0x1700687C RID: 26748
		// (get) Token: 0x0600D009 RID: 53257 RVA: 0x00C18CC8 File Offset: 0x00C16EC8
		// (set) Token: 0x0600D00A RID: 53258 RVA: 0x00C18D7C File Offset: 0x00C16F7C
		public bool AstTlkgrpLstTalkgroupListTalkgroupID_A9282_Valid
		{
			get
			{
				short num = (short)1808810985;
				short num2 = num;
				num = (short)460538857;
				switch (num2 == num)
				{
				}
				num = (short)1509883905;
				if (num != 0)
				{
				}
				num = (short)990445568;
				if (num != 0)
				{
				}
				num = (short)1141243904;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.Valid;
			}
			set
			{
				short num = (short)854404263;
				short num2 = num;
				num = (short)106572967;
				switch (num2 == num)
				{
				}
				num = (short)929300481;
				if (num != 0)
				{
				}
				num = (short)99745792;
				if (num != 0)
				{
				}
				num = (short)1492254720;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.Valid = value;
			}
		}

		// Token: 0x1700687D RID: 26749
		// (get) Token: 0x0600D00B RID: 53259 RVA: 0x00C18E38 File Offset: 0x00C17038
		// (set) Token: 0x0600D00C RID: 53260 RVA: 0x00C18EEC File Offset: 0x00C170EC
		public bool AstTlkgrpLstTalkgroupListTalkgroupID_A9282_Visible
		{
			get
			{
				short num = (short)1368486395;
				short num2 = num;
				num = (short)492859899;
				switch (num2 == num)
				{
				}
				num = (short)523239425;
				if (num != 0)
				{
				}
				num = (short)1275265024;
				if (num != 0)
				{
				}
				num = (short)1148780544;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.Visible;
			}
			set
			{
				short num = (short)132149371;
				short num2 = num;
				num = (short)1400991867;
				switch (num2 == num)
				{
				}
				num = (short)760741889;
				if (num != 0)
				{
				}
				num = (short)767623168;
				if (num != 0)
				{
				}
				num = (short)678100992;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.Visible = value;
			}
		}

		// Token: 0x1700687E RID: 26750
		// (get) Token: 0x0600D00D RID: 53261 RVA: 0x00C18FA4 File Offset: 0x00C171A4
		// (set) Token: 0x0600D00E RID: 53262 RVA: 0x00C19058 File Offset: 0x00C17258
		public bool AstTlkgrpLstTalkgroupListTalkgroupID_A9282_Editable
		{
			get
			{
				short num = (short)905038500;
				short num2 = num;
				num = (short)65063588;
				switch (num2 == num)
				{
				}
				num = (short)506200065;
				if (num != 0)
				{
				}
				num = (short)519110656;
				if (num != 0)
				{
				}
				num = (short)42401792;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.Editable;
			}
			set
			{
				short num = (short)1413827275;
				short num2 = num;
				num = (short)1631734475;
				switch (num2 == num)
				{
				}
				num = (short)1601437697;
				if (num != 0)
				{
				}
				num = (short)1585577984;
				if (num != 0)
				{
				}
				num = (short)355270656;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.Editable = value;
			}
		}

		// Token: 0x1700687F RID: 26751
		// (get) Token: 0x0600D00F RID: 53263 RVA: 0x00C1910C File Offset: 0x00C1730C
		internal string AstTlkgrpLstTalkgroupListTalkgroupID_A9282_UILabel
		{
			get
			{
				short num = (short)904296003;
				short num2 = num;
				num = (short)1374320195;
				switch (num2 == num)
				{
				}
				num = (short)1022296065;
				if (num != 0)
				{
				}
				num = (short)559218688;
				if (num != 0)
				{
				}
				num = (short)852951040;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.UIName;
			}
		}

		// Token: 0x17006880 RID: 26752
		// (get) Token: 0x0600D010 RID: 53264 RVA: 0x00C191C4 File Offset: 0x00C173C4
		// (set) Token: 0x0600D011 RID: 53265 RVA: 0x00C1927C File Offset: 0x00C1747C
		internal bool AstTlkgrpLstTalkgroupListTalkgroupID_A9282_HiddenStatic
		{
			get
			{
				short num = (short)342374685;
				short num2 = num;
				num = (short)377108765;
				switch (num2 == num)
				{
				}
				num = (short)1500512256;
				if (num != 0)
				{
				}
				num = (short)46268417;
				if (num != 0)
				{
				}
				num = (short)277807104;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.HiddenStatic;
			}
			set
			{
				short num = (short)226193590;
				short num2 = num;
				num = (short)1394503862;
				switch (num2 == num)
				{
				}
				num = (short)1404895233;
				if (num != 0)
				{
				}
				num = (short)150536192;
				if (num != 0)
				{
				}
				num = (short)1838284800;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.HiddenStatic = value;
			}
		}

		// Token: 0x17006881 RID: 26753
		// (get) Token: 0x0600D012 RID: 53266 RVA: 0x00C19330 File Offset: 0x00C17530
		// (set) Token: 0x0600D013 RID: 53267 RVA: 0x00C193E4 File Offset: 0x00C175E4
		internal bool AstTlkgrpLstTalkgroupListTalkgroupID_A9282_HiddenDynamic
		{
			get
			{
				short num = (short)2067891969;
				short num2 = num;
				num = (short)1754302209;
				switch (num2 == num)
				{
				}
				num = (short)1868562432;
				if (num != 0)
				{
				}
				num = (short)1676214273;
				if (num != 0)
				{
				}
				num = (short)1253769216;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.HiddenDynamic;
			}
			set
			{
				short num = (short)1365320580;
				short num2 = num;
				num = (short)241705860;
				switch (num2 == num)
				{
				}
				num = (short)1540227072;
				if (num != 0)
				{
				}
				num = (short)2069299201;
				if (num != 0)
				{
				}
				num = (short)784269312;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListTalkgroupID_A9282.HiddenDynamic = value;
			}
		}

		// Token: 0x17006882 RID: 26754
		// (get) Token: 0x0600D014 RID: 53268 RVA: 0x00C19498 File Offset: 0x00C17698
		public bool AstTlkgrpLstTalkgroupListTalkgroupID_A9282_HasDiffs
		{
			get
			{
				short num = (short)1925210392;
				short num2 = num;
				num = (short)1045324056;
				switch (num2 == num)
				{
				}
				num = (short)441712641;
				if (num != 0)
				{
				}
				num = (short)65208320;
				if (num != 0)
				{
				}
				num = (short)916783104;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListTalkgroupID_A9282._HasDiffs;
			}
		}

		// Token: 0x17006883 RID: 26755
		// (get) Token: 0x0600D015 RID: 53269 RVA: 0x00C1954C File Offset: 0x00C1774C
		// (set) Token: 0x0600D016 RID: 53270 RVA: 0x00C19600 File Offset: 0x00C17800
		public int AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654Value
		{
			get
			{
				short num = (short)1945379741;
				short num2 = num;
				num = (short)1916543901;
				switch (num2 == num)
				{
				}
				num = (short)1458962432;
				if (num != 0)
				{
				}
				num = (short)2144600065;
				if (num != 0)
				{
				}
				num = (short)1500971008;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.Value;
			}
			set
			{
				short num = (short)1082403433;
				short num2 = num;
				num = (short)1146169961;
				switch (num2 == num)
				{
				}
				num = (short)481820672;
				if (num != 0)
				{
				}
				num = (short)1248198657;
				if (num != 0)
				{
				}
				num = (short)1549008896;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.Value = value;
			}
		}

		// Token: 0x17006884 RID: 26756
		// (get) Token: 0x0600D017 RID: 53271 RVA: 0x00C196B4 File Offset: 0x00C178B4
		// (set) Token: 0x0600D018 RID: 53272 RVA: 0x00C19768 File Offset: 0x00C17968
		public string AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654_UIValue
		{
			get
			{
				short num = (short)421277371;
				short num2 = num;
				num = (short)61812411;
				switch (num2 == num)
				{
				}
				num = (short)604504064;
				if (num != 0)
				{
				}
				num = (short)246022145;
				if (num != 0)
				{
				}
				num = (short)1173553152;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.UIValue;
			}
			set
			{
				short num = (short)716732445;
				short num2 = num;
				num = (short)230455325;
				switch (num2 == num)
				{
				}
				num = (short)1730871297;
				if (num != 0)
				{
				}
				num = (short)12058624;
				if (num != 0)
				{
				}
				num = (short)1713176576;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.UIValue = value;
			}
		}

		// Token: 0x17006885 RID: 26757
		// (get) Token: 0x0600D019 RID: 53273 RVA: 0x00C1981C File Offset: 0x00C17A1C
		public global::AcpBusinessLayer.AcpListField AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654
		{
			get
			{
				short num = (short)284781598;
				short num2 = num;
				num = (short)22047774;
				switch (num2 == num)
				{
				}
				num = (short)2027290624;
				if (num != 0)
				{
				}
				num = (short)1385365505;
				if (num != 0)
				{
				}
				num = (short)655491072;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654;
			}
		}

		// Token: 0x17006886 RID: 26758
		// (get) Token: 0x0600D01A RID: 53274 RVA: 0x00C198D0 File Offset: 0x00C17AD0
		// (set) Token: 0x0600D01B RID: 53275 RVA: 0x00C19984 File Offset: 0x00C17B84
		public bool AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654_Applicable
		{
			get
			{
				short num = (short)2075983873;
				if (num != 0)
				{
				}
				num = (short)542902496;
				short num2 = num;
				num = (short)754059488;
				switch (num2 == num)
				{
				}
				num = (short)654966784;
				if (num != 0)
				{
				}
				num = (short)871235584;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.Applicable;
			}
			set
			{
				short num = (short)1745328020;
				short num2 = num;
				num = (short)553752468;
				switch (num2 == num)
				{
				}
				num = (short)1810104320;
				if (num != 0)
				{
				}
				num = (short)1305149441;
				if (num != 0)
				{
				}
				num = (short)1883832320;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.Applicable = value;
			}
		}

		// Token: 0x17006887 RID: 26759
		// (get) Token: 0x0600D01C RID: 53276 RVA: 0x00C19A3C File Offset: 0x00C17C3C
		// (set) Token: 0x0600D01D RID: 53277 RVA: 0x00C19AF4 File Offset: 0x00C17CF4
		public bool AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654_Valid
		{
			get
			{
				short num = (short)1343558743;
				short num2 = num;
				num = (short)1629426775;
				switch (num2 == num)
				{
				}
				num = (short)558956545;
				if (num != 0)
				{
				}
				num = (short)1259405312;
				if (num != 0)
				{
				}
				num = (short)2013003776;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.Valid;
			}
			set
			{
				short num = (short)1913847809;
				if (num != 0)
				{
				}
				num = (short)766496202;
				short num2 = num;
				num = (short)1516293578;
				switch (num2 == num)
				{
				}
				num = (short)1234370560;
				if (num != 0)
				{
				}
				num = (short)52625408;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.Valid = value;
			}
		}

		// Token: 0x17006888 RID: 26760
		// (get) Token: 0x0600D01E RID: 53278 RVA: 0x00C19BAC File Offset: 0x00C17DAC
		// (set) Token: 0x0600D01F RID: 53279 RVA: 0x00C19C60 File Offset: 0x00C17E60
		public bool AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654_Visible
		{
			get
			{
				short num = (short)973422021;
				short num2 = num;
				num = (short)193805765;
				switch (num2 == num)
				{
				}
				num = (short)351993857;
				if (num != 0)
				{
				}
				num = (short)1394868224;
				if (num != 0)
				{
				}
				num = (short)1878065152;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.Visible;
			}
			set
			{
				short num = (short)1359347713;
				if (num != 0)
				{
				}
				num = (short)1398005143;
				short num2 = num;
				num = (short)1721097623;
				switch (num2 == num)
				{
				}
				num = (short)1327104000;
				if (num != 0)
				{
				}
				num = (short)1221001216;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.Visible = value;
			}
		}

		// Token: 0x17006889 RID: 26761
		// (get) Token: 0x0600D020 RID: 53280 RVA: 0x00C19D14 File Offset: 0x00C17F14
		// (set) Token: 0x0600D021 RID: 53281 RVA: 0x00C19DC8 File Offset: 0x00C17FC8
		public bool AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654_Editable
		{
			get
			{
				short num = (short)1497680624;
				short num2 = num;
				num = (short)2074594032;
				switch (num2 == num)
				{
				}
				num = (short)2124546049;
				if (num != 0)
				{
				}
				num = (short)463273984;
				if (num != 0)
				{
				}
				num = (short)330563584;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.Editable;
			}
			set
			{
				short num = (short)812934283;
				short num2 = num;
				num = (short)1762944139;
				switch (num2 == num)
				{
				}
				num = (short)827588609;
				if (num != 0)
				{
				}
				num = (short)212074496;
				if (num != 0)
				{
				}
				num = (short)1050607616;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.Editable = value;
			}
		}

		// Token: 0x1700688A RID: 26762
		// (get) Token: 0x0600D022 RID: 53282 RVA: 0x00C19E7C File Offset: 0x00C1807C
		internal string AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654_UILabel
		{
			get
			{
				short num = (short)864271874;
				short num2 = num;
				num = (short)1828765186;
				switch (num2 == num)
				{
				}
				num = (short)513277953;
				if (num != 0)
				{
				}
				num = (short)833617920;
				if (num != 0)
				{
				}
				num = (short)491978752;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.UIName;
			}
		}

		// Token: 0x1700688B RID: 26763
		// (get) Token: 0x0600D023 RID: 53283 RVA: 0x00C19F30 File Offset: 0x00C18130
		// (set) Token: 0x0600D024 RID: 53284 RVA: 0x00C19FE4 File Offset: 0x00C181E4
		internal bool AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654_HiddenStatic
		{
			get
			{
				short num = (short)19598258;
				short num2 = num;
				num = (short)720374706;
				switch (num2 == num)
				{
				}
				num = (short)1935474689;
				if (num != 0)
				{
				}
				num = (short)838926336;
				if (num != 0)
				{
				}
				num = (short)1746534400;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.HiddenStatic;
			}
			set
			{
				short num = (short)1161564453;
				short num2 = num;
				num = (short)1705775397;
				switch (num2 == num)
				{
				}
				num = (short)379125761;
				if (num != 0)
				{
				}
				num = (short)858652672;
				if (num != 0)
				{
				}
				num = (short)83492864;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.HiddenStatic = value;
			}
		}

		// Token: 0x1700688C RID: 26764
		// (get) Token: 0x0600D025 RID: 53285 RVA: 0x00C1A09C File Offset: 0x00C1829C
		// (set) Token: 0x0600D026 RID: 53286 RVA: 0x00C1A150 File Offset: 0x00C18350
		internal bool AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654_HiddenDynamic
		{
			get
			{
				short num = (short)1101579980;
				short num2 = num;
				num = (short)667600588;
				switch (num2 == num)
				{
				}
				num = (short)1064435712;
				if (num != 0)
				{
				}
				num = (short)903938049;
				if (num != 0)
				{
				}
				num = (short)2075852800;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.HiddenDynamic;
			}
			set
			{
				short num = (short)534514;
				short num2 = num;
				num = (short)1916479474;
				switch (num2 == num)
				{
				}
				num = (short)2069757953;
				if (num != 0)
				{
				}
				num = (short)260702208;
				if (num != 0)
				{
				}
				num = (short)1592524800;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654.HiddenDynamic = value;
			}
		}

		// Token: 0x1700688D RID: 26765
		// (get) Token: 0x0600D027 RID: 53287 RVA: 0x00C1A204 File Offset: 0x00C18404
		public bool AstTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654_HasDiffs
		{
			get
			{
				short num = (short)1335641681;
				short num2 = num;
				num = (short)1893615185;
				switch (num2 == num)
				{
				}
				num = (short)140050432;
				if (num != 0)
				{
				}
				num = (short)1509556225;
				if (num != 0)
				{
				}
				num = (short)100925440;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654._HasDiffs;
			}
		}

		// Token: 0x1700688E RID: 26766
		// (get) Token: 0x0600D028 RID: 53288 RVA: 0x00C1A2B8 File Offset: 0x00C184B8
		// (set) Token: 0x0600D029 RID: 53289 RVA: 0x00C1A36C File Offset: 0x00C1856C
		public int AstTlkgrpLstTalkgroupListDVRSSystemID_A40162Value
		{
			get
			{
				short num = (short)516374419;
				short num2 = num;
				num = (short)717111187;
				switch (num2 == num)
				{
				}
				num = (short)1576665089;
				if (num != 0)
				{
				}
				num = (short)1459159040;
				if (num != 0)
				{
				}
				num = (short)114753536;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.Value;
			}
			set
			{
				short num = (short)866579647;
				short num2 = num;
				num = (short)1240396991;
				switch (num2 == num)
				{
				}
				num = (short)796327937;
				if (num != 0)
				{
				}
				num = (short)1105068032;
				if (num != 0)
				{
				}
				num = (short)1656619008;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.Value = value;
			}
		}

		// Token: 0x1700688F RID: 26767
		// (get) Token: 0x0600D02A RID: 53290 RVA: 0x00C1A424 File Offset: 0x00C18624
		public global::AcpBusinessLayer.AcpCustomRangeField AstTlkgrpLstTalkgroupListDVRSSystemID_A40162
		{
			get
			{
				short num = (short)1125799321;
				short num2 = num;
				num = (short)671307161;
				switch (num2 == num)
				{
				}
				num = (short)1629421569;
				if (num != 0)
				{
				}
				num = (short)1435435008;
				if (num != 0)
				{
				}
				num = (short)829751296;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162;
			}
		}

		// Token: 0x17006890 RID: 26768
		// (get) Token: 0x0600D02B RID: 53291 RVA: 0x00C1A4D4 File Offset: 0x00C186D4
		// (set) Token: 0x0600D02C RID: 53292 RVA: 0x00C1A588 File Offset: 0x00C18788
		public string AstTlkgrpLstTalkgroupListDVRSSystemID_A40162_UIValue
		{
			get
			{
				short num = (short)385875969;
				if (num != 0)
				{
				}
				num = (short)75280538;
				short num2 = num;
				num = (short)103592090;
				switch (num2 == num)
				{
				}
				num = (short)1018953728;
				if (num != 0)
				{
				}
				num = (short)1236271104;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.UIValue;
			}
			set
			{
				short num = (short)491343888;
				short num2 = num;
				num = (short)1055346704;
				switch (num2 == num)
				{
				}
				num = (short)69992449;
				if (num != 0)
				{
				}
				num = (short)1050673152;
				if (num != 0)
				{
				}
				num = (short)1816657920;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.UIValue = value;
			}
		}

		// Token: 0x17006891 RID: 26769
		// (get) Token: 0x0600D02D RID: 53293 RVA: 0x00C1A640 File Offset: 0x00C18840
		// (set) Token: 0x0600D02E RID: 53294 RVA: 0x00C1A6F4 File Offset: 0x00C188F4
		public string AstTlkgrpLstTalkgroupListDVRSSystemID_A40162_HexUIValue
		{
			get
			{
				short num = (short)2046542195;
				short num2 = num;
				num = (short)2130231667;
				switch (num2 == num)
				{
				}
				num = (short)265682944;
				if (num != 0)
				{
				}
				num = (short)828440577;
				if (num != 0)
				{
				}
				num = (short)850657280;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.HexUIValue;
			}
			set
			{
				short num = (short)1103986986;
				short num2 = num;
				num = (short)1446019370;
				switch (num2 == num)
				{
				}
				num = (short)1230241793;
				if (num != 0)
				{
				}
				num = (short)931790848;
				if (num != 0)
				{
				}
				num = (short)1875574784;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.HexUIValue = value;
			}
		}

		// Token: 0x17006892 RID: 26770
		// (get) Token: 0x0600D02F RID: 53295 RVA: 0x00C1A7AC File Offset: 0x00C189AC
		// (set) Token: 0x0600D030 RID: 53296 RVA: 0x00C1A860 File Offset: 0x00C18A60
		internal int AstTlkgrpLstTalkgroupListDVRSSystemID_A40162Min
		{
			get
			{
				short num = (short)1932613170;
				short num2 = num;
				num = (short)861034034;
				switch (num2 == num)
				{
				}
				num = (short)828309504;
				if (num != 0)
				{
				}
				num = (short)1545404417;
				if (num != 0)
				{
				}
				num = (short)1506410496;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.Min;
			}
			set
			{
				short num = (short)1771159159;
				short num2 = num;
				num = (short)2048769655;
				switch (num2 == num)
				{
				}
				num = (short)328663041;
				if (num != 0)
				{
				}
				num = (short)330235904;
				if (num != 0)
				{
				}
				num = (short)2059272192;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.Min = value;
			}
		}

		// Token: 0x17006893 RID: 26771
		// (get) Token: 0x0600D031 RID: 53297 RVA: 0x00C1A918 File Offset: 0x00C18B18
		// (set) Token: 0x0600D032 RID: 53298 RVA: 0x00C1A9CC File Offset: 0x00C18BCC
		internal int AstTlkgrpLstTalkgroupListDVRSSystemID_A40162Max
		{
			get
			{
				short num = (short)386297385;
				short num2 = num;
				num = (short)1882811945;
				switch (num2 == num)
				{
				}
				num = (short)592314369;
				if (num != 0)
				{
				}
				num = (short)256180224;
				if (num != 0)
				{
				}
				num = (short)1735393280;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.Max;
			}
			set
			{
				short num = (short)362174437;
				short num2 = num;
				num = (short)1914984421;
				switch (num2 == num)
				{
				}
				num = (short)417464321;
				if (num != 0)
				{
				}
				num = (short)1735000064;
				if (num != 0)
				{
				}
				num = (short)103940096;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.Max = value;
			}
		}

		// Token: 0x17006894 RID: 26772
		// (get) Token: 0x0600D033 RID: 53299 RVA: 0x00C1AA80 File Offset: 0x00C18C80
		// (set) Token: 0x0600D034 RID: 53300 RVA: 0x00C1AB38 File Offset: 0x00C18D38
		internal int AstTlkgrpLstTalkgroupListDVRSSystemID_A40162Step
		{
			get
			{
				short num = (short)312261061;
				short num2 = num;
				num = (short)49068485;
				switch (num2 == num)
				{
				}
				num = (short)1357905921;
				if (num != 0)
				{
				}
				num = (short)1784807424;
				if (num != 0)
				{
				}
				num = (short)745668608;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.StepSize;
			}
			set
			{
				short num = (short)1037642572;
				short num2 = num;
				num = (short)496577356;
				switch (num2 == num)
				{
				}
				num = (short)1903886337;
				if (num != 0)
				{
				}
				num = (short)698744832;
				if (num != 0)
				{
				}
				num = (short)426377216;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.StepSize = value;
			}
		}

		// Token: 0x17006895 RID: 26773
		// (get) Token: 0x0600D035 RID: 53301 RVA: 0x00C1ABEC File Offset: 0x00C18DEC
		// (set) Token: 0x0600D036 RID: 53302 RVA: 0x00C1ACA0 File Offset: 0x00C18EA0
		public bool AstTlkgrpLstTalkgroupListDVRSSystemID_A40162_Applicable
		{
			get
			{
				short num = (short)451303483;
				short num2 = num;
				num = (short)1991596091;
				switch (num2 == num)
				{
				}
				num = (short)1102184448;
				if (num != 0)
				{
				}
				num = (short)86966273;
				if (num != 0)
				{
				}
				num = (short)1119617024;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.Applicable;
			}
			set
			{
				short num = (short)1715038014;
				short num2 = num;
				num = (short)1912170302;
				switch (num2 == num)
				{
				}
				num = (short)1598095361;
				if (num != 0)
				{
				}
				num = (short)1040121856;
				if (num != 0)
				{
				}
				num = (short)106102784;
				short num3 = num;
				this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.Applicable = value;
			}
		}

		// Token: 0x17006896 RID: 26774
		// (get) Token: 0x0600D037 RID: 53303 RVA: 0x00C1AD54 File Offset: 0x00C18F54
		// (set) Token: 0x0600D038 RID: 53304 RVA: 0x00C1AE08 File Offset: 0x00C19008
		public bool AstTlkgrpLstTalkgroupListDVRSSystemID_A40162_Valid
		{
			get
			{
				short num = (short)60907387;
				short num2 = num;
				num = (short)1064984443;
				switch (num2 == num)
				{
				}
				num = (short)1750925313;
				if (num != 0)
				{
				}
				num = (short)762904576;
				if (num != 0)
				{
				}
				num = (short)530317312;
				short num3 = num;
				return this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.Valid;
			}
			set
			{
				short num = (short)977182610;
				short num2 = num;
				num = (short)1114873746;
				switch (num2 == num)
				{
				}
				num = (short)1275854848;
				short num3 = num;
				num = (short)67043329;
				if (num != 0)
				{
				}
				num = (short)1013579776;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.Valid = value;
			}
		}

		// Token: 0x17006897 RID: 26775
		// (get) Token: 0x0600D039 RID: 53305 RVA: 0x00C1AEC0 File Offset: 0x00C190C0
		// (set) Token: 0x0600D03A RID: 53306 RVA: 0x00C1AF78 File Offset: 0x00C19178
		public bool AstTlkgrpLstTalkgroupListDVRSSystemID_A40162_Visible
		{
			get
			{
				short num = (short)29712982;
				short num2 = num;
				num = (short)1605198422;
				switch (num2 == num)
				{
				}
				num = (short)866779136;
				short num3 = num;
				num = (short)1209139200;
				if (num != 0)
				{
				}
				num = (short)692453377;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.Visible;
			}
			set
			{
				short num = (short)487491029;
				short num2 = num;
				num = (short)1933346261;
				switch (num2 == num)
				{
				}
				num = (short)1830682624;
				short num3 = num;
				num = (short)2120286209;
				if (num != 0)
				{
				}
				num = (short)2014314496;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.Visible = value;
			}
		}

		// Token: 0x17006898 RID: 26776
		// (get) Token: 0x0600D03B RID: 53307 RVA: 0x00C1B02C File Offset: 0x00C1922C
		// (set) Token: 0x0600D03C RID: 53308 RVA: 0x00C1B0E0 File Offset: 0x00C192E0
		public bool AstTlkgrpLstTalkgroupListDVRSSystemID_A40162_Editable
		{
			get
			{
				short num = (short)629223506;
				short num2 = num;
				num = (short)2063937618;
				switch (num2 == num)
				{
				}
				num = (short)702021632;
				short num3 = num;
				num = (short)280363009;
				if (num != 0)
				{
				}
				num = (short)1105133568;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.Editable;
			}
			set
			{
				short num = (short)1209407839;
				short num2 = num;
				num = (short)1052383583;
				switch (num2 == num)
				{
				}
				num = (short)1797849088;
				short num3 = num;
				num = (short)1890516993;
				if (num != 0)
				{
				}
				num = (short)1921384448;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.Editable = value;
			}
		}

		// Token: 0x17006899 RID: 26777
		// (get) Token: 0x0600D03D RID: 53309 RVA: 0x00C1B194 File Offset: 0x00C19394
		internal string AstTlkgrpLstTalkgroupListDVRSSystemID_A40162_UILabel
		{
			get
			{
				short num = (short)1398591279;
				short num2 = num;
				num = (short)629133103;
				switch (num2 == num)
				{
				}
				num = (short)919076864;
				short num3 = num;
				num = (short)1369112576;
				if (num != 0)
				{
				}
				num = (short)2004877313;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.UIName;
			}
		}

		// Token: 0x1700689A RID: 26778
		// (get) Token: 0x0600D03E RID: 53310 RVA: 0x00C1B248 File Offset: 0x00C19448
		// (set) Token: 0x0600D03F RID: 53311 RVA: 0x00C1B2FC File Offset: 0x00C194FC
		internal bool AstTlkgrpLstTalkgroupListDVRSSystemID_A40162_HiddenStatic
		{
			get
			{
				short num = (short)454641120;
				short num2 = num;
				num = (short)1470842336;
				switch (num2 == num)
				{
				}
				num = (short)634191872;
				short num3 = num;
				num = (short)183697408;
				if (num != 0)
				{
				}
				num = (short)1588789249;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.HiddenStatic;
			}
			set
			{
				short num = (short)442080727;
				short num2 = num;
				num = (short)2011209175;
				switch (num2 == num)
				{
				}
				num = (short)1901068288;
				short num3 = num;
				num = (short)1934819328;
				if (num != 0)
				{
				}
				num = (short)995164161;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.HiddenStatic = value;
			}
		}

		// Token: 0x1700689B RID: 26779
		// (get) Token: 0x0600D040 RID: 53312 RVA: 0x00C1B3B0 File Offset: 0x00C195B0
		// (set) Token: 0x0600D041 RID: 53313 RVA: 0x00C1B468 File Offset: 0x00C19668
		internal bool AstTlkgrpLstTalkgroupListDVRSSystemID_A40162_HiddenDynamic
		{
			get
			{
				short num = (short)1528956452;
				short num2 = num;
				num = (short)1532036644;
				switch (num2 == num)
				{
				}
				num = (short)627703808;
				short num3 = num;
				num = (short)1958608896;
				if (num != 0)
				{
				}
				num = (short)569507841;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.HiddenDynamic;
			}
			set
			{
				short num = (short)1253003023;
				short num2 = num;
				num = (short)394284815;
				switch (num2 == num)
				{
				}
				num = (short)1390542848;
				short num3 = num;
				num = (short)1574174721;
				if (num != 0)
				{
				}
				num = (short)155320320;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162.HiddenDynamic = value;
			}
		}

		// Token: 0x1700689C RID: 26780
		// (get) Token: 0x0600D042 RID: 53314 RVA: 0x00C1B520 File Offset: 0x00C19720
		public bool AstTlkgrpLstTalkgroupListDVRSSystemID_A40162_HasDiffs
		{
			get
			{
				short num = (short)1944889099;
				short num2 = num;
				num = (short)238069515;
				switch (num2 == num)
				{
				}
				num = (short)1621819392;
				short num3 = num;
				num = (short)444792833;
				if (num != 0)
				{
				}
				num = (short)1400766464;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSSystemID_A40162._HasDiffs;
			}
		}

		// Token: 0x1700689D RID: 26781
		// (get) Token: 0x0600D043 RID: 53315 RVA: 0x00C1B5D4 File Offset: 0x00C197D4
		// (set) Token: 0x0600D044 RID: 53316 RVA: 0x00C1B688 File Offset: 0x00C19888
		public int AstTlkgrpLstTalkgroupListDVRSWACNID_A40163Value
		{
			get
			{
				short num = (short)1568931841;
				if (num != 0)
				{
				}
				num = (short)535235567;
				short num2 = num;
				num = (short)1453984751;
				switch (num2 == num)
				{
				default:
				{
					num = (short)616759296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)506068992;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.Value;
			}
			set
			{
				short num = (short)2139357185;
				if (num != 0)
				{
				}
				num = (short)604245153;
				short num2 = num;
				num = (short)15731873;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1121714176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2073493504;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.Value = value;
			}
		}

		// Token: 0x1700689E RID: 26782
		// (get) Token: 0x0600D045 RID: 53317 RVA: 0x00C1B740 File Offset: 0x00C19940
		public global::AcpBusinessLayer.AcpCustomRangeField AstTlkgrpLstTalkgroupListDVRSWACNID_A40163
		{
			get
			{
				short num = (short)1216954137;
				short num2 = num;
				num = (short)254885657;
				switch (num2 == num)
				{
				}
				num = (short)1931870208;
				short num3 = num;
				num = (short)621936641;
				if (num != 0)
				{
				}
				num = (short)698155008;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163;
			}
		}

		// Token: 0x1700689F RID: 26783
		// (get) Token: 0x0600D046 RID: 53318 RVA: 0x00C1B7F0 File Offset: 0x00C199F0
		// (set) Token: 0x0600D047 RID: 53319 RVA: 0x00C1B8A8 File Offset: 0x00C19AA8
		public string AstTlkgrpLstTalkgroupListDVRSWACNID_A40163_UIValue
		{
			get
			{
				short num = (short)426009886;
				short num2 = num;
				num = (short)1066951966;
				switch (num2 == num)
				{
				}
				num = (short)1327955968;
				short num3 = num;
				num = (short)1364983809;
				if (num != 0)
				{
				}
				num = (short)1818361856;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.UIValue;
			}
			set
			{
				short num = (short)2111861328;
				short num2 = num;
				num = (short)1181184592;
				switch (num2 == num)
				{
				}
				num = (short)1201340416;
				short num3 = num;
				num = (short)1841233920;
				if (num != 0)
				{
				}
				num = (short)1253113857;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.UIValue = value;
			}
		}

		// Token: 0x170068A0 RID: 26784
		// (get) Token: 0x0600D048 RID: 53320 RVA: 0x00C1B95C File Offset: 0x00C19B5C
		// (set) Token: 0x0600D049 RID: 53321 RVA: 0x00C1BA14 File Offset: 0x00C19C14
		public string AstTlkgrpLstTalkgroupListDVRSWACNID_A40163_HexUIValue
		{
			get
			{
				short num = (short)934889668;
				short num2 = num;
				num = (short)328812740;
				switch (num2 == num)
				{
				}
				num = (short)2014576640;
				short num3 = num;
				num = (short)780468225;
				if (num != 0)
				{
				}
				num = (short)1343291392;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.HexUIValue;
			}
			set
			{
				short num = (short)264388784;
				short num2 = num;
				num = (short)1078149296;
				switch (num2 == num)
				{
				}
				num = (short)1412300800;
				short num3 = num;
				num = (short)2027814912;
				if (num != 0)
				{
				}
				num = (short)1471283201;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.HexUIValue = value;
			}
		}

		// Token: 0x170068A1 RID: 26785
		// (get) Token: 0x0600D04A RID: 53322 RVA: 0x00C1BACC File Offset: 0x00C19CCC
		// (set) Token: 0x0600D04B RID: 53323 RVA: 0x00C1BB80 File Offset: 0x00C19D80
		internal int AstTlkgrpLstTalkgroupListDVRSWACNID_A40163Min
		{
			get
			{
				short num = (short)1921246193;
				short num2 = num;
				num = (short)1089594353;
				switch (num2 == num)
				{
				}
				num = (short)1782906880;
				short num3 = num;
				num = (short)1340801025;
				if (num != 0)
				{
				}
				num = (short)1205993472;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.Min;
			}
			set
			{
				short num = (short)2911320;
				short num2 = num;
				num = (short)1131506776;
				switch (num2 == num)
				{
				}
				num = (short)1345060864;
				short num3 = num;
				num = (short)525074433;
				if (num != 0)
				{
				}
				num = (short)2112946176;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.Min = value;
			}
		}

		// Token: 0x170068A2 RID: 26786
		// (get) Token: 0x0600D04C RID: 53324 RVA: 0x00C1BC38 File Offset: 0x00C19E38
		// (set) Token: 0x0600D04D RID: 53325 RVA: 0x00C1BCEC File Offset: 0x00C19EEC
		internal int AstTlkgrpLstTalkgroupListDVRSWACNID_A40163Max
		{
			get
			{
				short num = (short)272223747;
				short num2 = num;
				num = (short)1852427779;
				switch (num2 == num)
				{
				}
				num = (short)1043595264;
				short num3 = num;
				num = (short)1584136193;
				if (num != 0)
				{
				}
				num = (short)1133576192;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.Max;
			}
			set
			{
				short num = (short)1698134478;
				short num2 = num;
				num = (short)1055816142;
				switch (num2 == num)
				{
				}
				num = (short)1505492992;
				short num3 = num;
				num = (short)2092040192;
				if (num != 0)
				{
				}
				num = (short)1376257;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.Max = value;
			}
		}

		// Token: 0x170068A3 RID: 26787
		// (get) Token: 0x0600D04E RID: 53326 RVA: 0x00C1BDA4 File Offset: 0x00C19FA4
		// (set) Token: 0x0600D04F RID: 53327 RVA: 0x00C1BE58 File Offset: 0x00C1A058
		internal int AstTlkgrpLstTalkgroupListDVRSWACNID_A40163Step
		{
			get
			{
				short num = (short)991813290;
				short num2 = num;
				num = (short)304733866;
				switch (num2 == num)
				{
				}
				num = (short)402718720;
				short num3 = num;
				num = (short)2045444097;
				if (num != 0)
				{
				}
				num = (short)418578432;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.StepSize;
			}
			set
			{
				short num = (short)537310889;
				short num2 = num;
				num = (short)1979037353;
				switch (num2 == num)
				{
				}
				num = (short)790953984;
				short num3 = num;
				num = (short)1935802368;
				if (num != 0)
				{
				}
				num = (short)1717043201;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.StepSize = value;
			}
		}

		// Token: 0x170068A4 RID: 26788
		// (get) Token: 0x0600D050 RID: 53328 RVA: 0x00C1BF0C File Offset: 0x00C1A10C
		// (set) Token: 0x0600D051 RID: 53329 RVA: 0x00C1BFC4 File Offset: 0x00C1A1C4
		public bool AstTlkgrpLstTalkgroupListDVRSWACNID_A40163_Applicable
		{
			get
			{
				short num = (short)101509876;
				short num2 = num;
				num = (short)1752492788;
				switch (num2 == num)
				{
				}
				num = (short)939065344;
				short num3 = num;
				num = (short)188809217;
				if (num != 0)
				{
				}
				num = (short)887750656;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.Applicable;
			}
			set
			{
				short num = (short)2009576110;
				short num2 = num;
				num = (short)793948846;
				switch (num2 == num)
				{
				}
				num = (short)631177216;
				short num3 = num;
				num = (short)1162215425;
				if (num != 0)
				{
				}
				num = (short)1872429056;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.Applicable = value;
			}
		}

		// Token: 0x170068A5 RID: 26789
		// (get) Token: 0x0600D052 RID: 53330 RVA: 0x00C1C078 File Offset: 0x00C1A278
		// (set) Token: 0x0600D053 RID: 53331 RVA: 0x00C1C12C File Offset: 0x00C1A32C
		public bool AstTlkgrpLstTalkgroupListDVRSWACNID_A40163_Valid
		{
			get
			{
				short num = (short)2054674717;
				short num2 = num;
				num = (short)1132976413;
				switch (num2 == num)
				{
				}
				num = (short)763428864;
				short num3 = num;
				num = (short)845414400;
				if (num != 0)
				{
				}
				num = (short)768802817;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.Valid;
			}
			set
			{
				short num = (short)646119425;
				if (num != 0)
				{
				}
				num = (short)841066029;
				short num2 = num;
				num = (short)999728685;
				switch (num2 == num)
				{
				default:
				{
					num = (short)81788928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1286078464;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.Valid = value;
			}
		}

		// Token: 0x170068A6 RID: 26790
		// (get) Token: 0x0600D054 RID: 53332 RVA: 0x00C1C1E0 File Offset: 0x00C1A3E0
		// (set) Token: 0x0600D055 RID: 53333 RVA: 0x00C1C294 File Offset: 0x00C1A494
		public bool AstTlkgrpLstTalkgroupListDVRSWACNID_A40163_Visible
		{
			get
			{
				short num = (short)986346981;
				short num2 = num;
				num = (short)474772965;
				switch (num2 == num)
				{
				}
				num = (short)542638080;
				short num3 = num;
				num = (short)1802698752;
				if (num != 0)
				{
				}
				num = (short)610729985;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.Visible;
			}
			set
			{
				short num = (short)1750369279;
				short num2 = num;
				num = (short)676365311;
				switch (num2 == num)
				{
				}
				num = (short)170917888;
				short num3 = num;
				num = (short)771555328;
				if (num != 0)
				{
				}
				num = (short)204603393;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.Visible = value;
			}
		}

		// Token: 0x170068A7 RID: 26791
		// (get) Token: 0x0600D056 RID: 53334 RVA: 0x00C1C350 File Offset: 0x00C1A550
		// (set) Token: 0x0600D057 RID: 53335 RVA: 0x00C1C400 File Offset: 0x00C1A600
		public bool AstTlkgrpLstTalkgroupListDVRSWACNID_A40163_Editable
		{
			get
			{
				short num = (short)329101899;
				short num2 = num;
				num = (short)1583395403;
				switch (num2 == num)
				{
				}
				num = (short)1440808960;
				short num3 = num;
				num = (short)1497759745;
				if (num != 0)
				{
				}
				num = (short)18153472;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.Editable;
			}
			set
			{
				short num = (short)71004852;
				short num2 = num;
				num = (short)2040689332;
				switch (num2 == num)
				{
				}
				num = (short)2060517376;
				short num3 = num;
				num = (short)411238401;
				if (num != 0)
				{
				}
				num = (short)1796341760;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.Editable = value;
			}
		}

		// Token: 0x170068A8 RID: 26792
		// (get) Token: 0x0600D058 RID: 53336 RVA: 0x00C1C4B4 File Offset: 0x00C1A6B4
		internal string AstTlkgrpLstTalkgroupListDVRSWACNID_A40163_UILabel
		{
			get
			{
				short num = (short)1595538764;
				short num2 = num;
				num = (short)1990262092;
				switch (num2 == num)
				{
				}
				num = (short)1193738240;
				short num3 = num;
				num = (short)180224000;
				if (num != 0)
				{
				}
				num = (short)539361281;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.UIName;
			}
		}

		// Token: 0x170068A9 RID: 26793
		// (get) Token: 0x0600D059 RID: 53337 RVA: 0x00C1C568 File Offset: 0x00C1A768
		// (set) Token: 0x0600D05A RID: 53338 RVA: 0x00C1C61C File Offset: 0x00C1A81C
		internal bool AstTlkgrpLstTalkgroupListDVRSWACNID_A40163_HiddenStatic
		{
			get
			{
				short num = (short)892755591;
				short num2 = num;
				num = (short)571956871;
				switch (num2 == num)
				{
				}
				num = (short)2115239936;
				short num3 = num;
				num = (short)934084609;
				if (num != 0)
				{
				}
				num = (short)1533935616;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.HiddenStatic;
			}
			set
			{
				short num = (short)1626762272;
				short num2 = num;
				num = (short)1685941280;
				switch (num2 == num)
				{
				}
				num = (short)821821440;
				short num3 = num;
				num = (short)962002945;
				if (num != 0)
				{
				}
				num = (short)1979711488;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.HiddenStatic = value;
			}
		}

		// Token: 0x170068AA RID: 26794
		// (get) Token: 0x0600D05B RID: 53339 RVA: 0x00C1C6D0 File Offset: 0x00C1A8D0
		// (set) Token: 0x0600D05C RID: 53340 RVA: 0x00C1C784 File Offset: 0x00C1A984
		internal bool AstTlkgrpLstTalkgroupListDVRSWACNID_A40163_HiddenDynamic
		{
			get
			{
				short num = (short)683912910;
				short num2 = num;
				num = (short)618770126;
				switch (num2 == num)
				{
				}
				num = (short)330629120;
				short num3 = num;
				num = (short)1402339329;
				if (num != 0)
				{
				}
				num = (short)1644232704;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.HiddenDynamic;
			}
			set
			{
				short num = (short)941965558;
				short num2 = num;
				num = (short)86196470;
				switch (num2 == num)
				{
				}
				num = (short)2030698496;
				short num3 = num;
				num = (short)640811009;
				if (num != 0)
				{
				}
				num = (short)562102272;
				if (num != 0)
				{
				}
				this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163.HiddenDynamic = value;
			}
		}

		// Token: 0x170068AB RID: 26795
		// (get) Token: 0x0600D05D RID: 53341 RVA: 0x00C1C838 File Offset: 0x00C1AA38
		public bool AstTlkgrpLstTalkgroupListDVRSWACNID_A40163_HasDiffs
		{
			get
			{
				short num = (short)1630271392;
				short num2 = num;
				num = (short)2002646944;
				switch (num2 == num)
				{
				}
				num = (short)906297344;
				short num3 = num;
				num = (short)1937506304;
				if (num != 0)
				{
				}
				num = (short)1619591169;
				if (num != 0)
				{
				}
				return this.astTlkgrpLstTalkgroupListDVRSWACNID_A40163._HasDiffs;
			}
		}

		// Token: 0x170068AC RID: 26796
		// (get) Token: 0x0600D05E RID: 53342 RVA: 0x00C1C8EC File Offset: 0x00C1AAEC
		public global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide RefSecureWide
		{
			get
			{
				short num = (short)1760177393;
				short num2 = num;
				num = (short)1170418929;
				switch (num2 == num)
				{
				}
				num = (short)1145634816;
				short num3 = num;
				num = (short)1726152705;
				if (num != 0)
				{
				}
				num = (short)1084358656;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
			}
		}

		// Token: 0x0600D05F RID: 53343 RVA: 0x00C1C9AC File Offset: 0x00C1ABAC
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
					goto IL_84;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1641086980;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					for (;;)
					{
						num2 = (short)2067689571;
						short num3 = num2;
						num2 = (short)1448112227;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_110;
						}
					}
					IL_110:
					num2 = (short)1329790976;
					if (num2 != 0)
					{
					}
					num2 = (short)2008219649;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)1061552130;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)197722112;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_84:
			num2 = (short)1452474368;
			short num4 = num2;
			num2 = (short)1115684865;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)8585219;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040065B2 RID: 26034
		private global::AcpBusinessLayer.AcpRecRefField astTlkgrpLstTalkgroupListKeySelectReference_A8366;

		// Token: 0x040065B3 RID: 26035
		private global::AcpBusinessLayer.AcpKeyField astTlkgrpLstTalkgroupListTalkgroupAliasText_A9278;

		// Token: 0x040065B4 RID: 26036
		private global::AcpBusinessLayer.AcpSimpleRangeField astTlkgrpLstTalkgroupListTalkgroupID_A9282;

		// Token: 0x040065B5 RID: 26037
		private global::AcpBusinessLayer.AcpListField astTlkgrpLstTalkgroupListVoiceSecureClearStrapping_A9654;

		// Token: 0x040065B6 RID: 26038
		private global::AcpBusinessLayer.AcpCustomRangeField astTlkgrpLstTalkgroupListDVRSSystemID_A40162;

		// Token: 0x040065B7 RID: 26039
		private global::AcpBusinessLayer.AcpCustomRangeField astTlkgrpLstTalkgroupListDVRSWACNID_A40163;
	}
}
