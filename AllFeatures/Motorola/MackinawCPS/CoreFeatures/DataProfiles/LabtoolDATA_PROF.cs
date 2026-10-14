using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x02000510 RID: 1296
	[global::System.Serializable]
	public class LabtoolDATA_PROF : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600AEDB RID: 44763 RVA: 0x00A27B34 File Offset: 0x00A25D34
		public LabtoolDATA_PROF(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600AEDC RID: 44764 RVA: 0x00A27B50 File Offset: 0x00A25D50
		protected LabtoolDATA_PROF(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600AEDD RID: 44765 RVA: 0x00A27B68 File Offset: 0x00A25D68
		public override void Init()
		{
			int a_ = 16;
			short num = (short)1993998337;
			if (num != 0)
			{
			}
			num = (short)913440768;
			short num2 = num;
			num = (short)1107584198;
			short num3 = num;
			num = (short)1612539078;
			switch (num3 == num)
			{
			}
			num = (short)275709952;
			if (num != 0)
			{
			}
			this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475 = new global::AcpBusinessLayer.AcpSimpleRangeField(2, this, global::AllFeatures.CodeplugGuid.b("闐닒ꇔ뛖觘꧚닜맞균苢蟤鏦蛨蓪臬꯮냰ꟲ듴ꣶ꧸ꧺ닼맾唀焂瀄椆戈戊挌栎倐䄒䘔化簘椚砜砞䠠倢儤唦䠨弪䐬䀮弰眲倴嬶堸䈺椼嘾ⱀ♂㝄ᡆࡈ牊祌硎摐", a_), global::CommonResources.AcgResources.ID_TRUNKINGARSDEREGISTRATIONDELAYTIMER, 0, 255, null, null, 0, 1);
			this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.DataTransferOrder = -1;
			this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.ShowHexValue = false;
			this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("闐닒ꇔ뛖觘꧚닜맞균苢蟤鏦蛨蓪臬꯮냰ꟲ듴ꣶ꧸ꧺ닼맾䔀戂焄昆䴈渊愌明朐瘒朔渖吘琚礜稞縠戢ᐤᘦᴨᴪᔬ", a_), global::CommonResources.AcgResources.ID_DATADELIVERYMODE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfLabtoolDATA_PROFDataDeliveryMode_A11468LovStrs);
			this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.DataTransferOrder = -1;
			this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991 = new global::AcpBusinessLayer.AcpSimpleRangeField(2, this, global::AllFeatures.CodeplugGuid.b("闐닒ꇔ뛖觘꧚닜맞균苢蟤鏦蛨蓪臬꯮냰ꟲ듴ꣶ꧸ꧺ닼맾䈀氂欄焆氈攊礌明縐紒琔笖堘䤚东嬞䐠儢䀤䀦䀨堪夬崮倰䜲尴堶圸缺堼匾⁀㩂ᅄ⹆⑈⹊㽌၎ၐ慒敔湖恘橚", a_), global::CommonResources.AcgResources.ID_CONVENTIONALARSDEREGISTRATIONDELAYTIMER, 0, 255, null, null, 0, 1);
			this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.DataTransferOrder = -1;
			this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.ShowHexValue = false;
			this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闐닒ꇔ뛖高듚돜맞裠蓢郤闦裨鿪蓬胮鿰럲铴菶飸꯺迼郾最樂椄戆崈礊砌愎稐稒笔瀖堘⤚⠜嬞怠怢栤䘦夨嬪䐬䄮嘰缲尴䐶䴸爺䤼娾ⱀൂ⑄⩆ⱈɊ⥌၎ၐ恒捔敖桘捚", a_), global::CommonResources.AcgResources.ID_DACMAPPINGLISTITEMNAMEID, null, null, true, false);
			this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.DataTransferOrder = -1;
			this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闐닒ꇔ뛖高듚돜맞裠蓢郤闦裨鿪蓬胮鿰럲铴菶飸꯺迼郾最樂椄戆崈礊砌愎稐稒笔瀖堘⤚⠜嬞䀠圢䐤怦嬨䐪堬弮砰眲礴帶䨸伺琼䬾⑀⹂ୄ♆⑈⹊ь⭎๐ቒ晔慖歘橚摜", a_), global::CommonResources.AcgResources.ID_DATAGROUPIDLISTITEMNAMEID, null, null, true, false);
			this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.DataTransferOrder = -1;
			this.dataProfLabtoolTrk25EIDBypassListItemID_A36423 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("闐닒ꇔ뛖觘꧚닜맞균苢蟤鏦蛨蓪臬믮菰飲쟴싶본닺맼뷾砀猂搄理稈䜊搌簎攐娒愔爖琘刚夜䀞怠ဢጤጦᬨᠪ", a_), global::CommonResources.AcgResources.ID_DATAPROFILETRUNKINGA25EIDBYPASSLISTITEMID, null, null, true, false);
			this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鷐닒럔ꏖ뛘듚뇜￞쳠쏢ꇤꛦ뷨ꫪ달뿮ꏰ볲돴", a_);
			base.Id = 10123;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOLDATA_PROF;
			base.DataTransferOrder = 3;
		}

		// Token: 0x0600AEDE RID: 44766 RVA: 0x00A27DD8 File Offset: 0x00A25FD8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 6;
			short num = (short)2032926741;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)502661124;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_357;
				case 2:
					num = (short)1511129097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)76218368;
					short num3 = num;
					goto IL_1C0;
				}
				case 4:
				{
					if (producerFields == null)
					{
						goto IL_576;
					}
					num = (short)1671383445;
					short num4 = num;
					num = (short)1408453013;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_571;
					default:
						num = (short)1690632192;
						if (num != 0)
						{
						}
						num = (short)1182400514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菆꣈뿊곌賎뻐뷒돔뻖뻘껚꿜뻞闠諢諤触귨諪駬軮ꇰ臲髴釶郸韺飼꯾猀瘂欄氆怈攊樌与⌐☒儔嘖娘嘚簜漞儠䨢䬤䀦攨䈪帬嬮砰䜲倴娶眸娺值娾ࡀ❂ᩄن穈絊罌繎楐", a_)))
					{
						num = (short)985923590;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AA;
				case 6:
					num = (short)413597697;
					if (num != 0)
					{
					}
					this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("菆꣈뿊곌賎뻐뷒돔뻖뻘껚꿜뻞闠諢諤触귨諪駬軮ꇰ臲髴釶郸韺飼꯾猀瘂欄氆怈攊樌与⌐☒儔嘖娘嘚簜漞儠䨢䬤䀦攨䈪帬嬮砰䜲倴娶眸娺值娾ࡀ❂ᩄن穈絊罌繎楐", a_), global::CommonResources.AcgResources.ID_DACMAPPINGLISTITEMNAMEID, null, null, true, false);
					this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.DataTransferOrder = -1;
					num = (short)258342922;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991 = new global::AcpBusinessLayer.AcpSimpleRangeField(2, this, global::AllFeatures.CodeplugGuid.b("菆꣈뿊곌鿎ꏐ볒돔鯖룘맚꧜냞軠迢ꇤꛦ뷨ꫪ달뿮ꏰ볲돴듶雸闺诼髾漀眂氄栆月樊愌与䌐䀒儔爖欘縚稜瘞删圢圤䘦崨䈪䈬䄮田嘲头嘶䀸漺吼刾⑀ㅂᩄن筈筊瑌癎恐", a_), global::CommonResources.AcgResources.ID_CONVENTIONALARSDEREGISTRATIONDELAYTIMER, null, null, 0, 1);
					this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.DataTransferOrder = -1;
					this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.ShowHexValue = false;
					num = (short)1916076040;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_421;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菆꣈뿊곌鿎ꏐ볒돔鯖룘맚꧜냞軠迢ꇤꛦ뷨ꫪ달뿮ꏰ볲돴ꏶ诸軺鏼链栀洂戄䘆嬈堊䤌樎挐瘒爔縖樘漚漜縞唠䨢䨤䤦洨个䄬丮䠰朲尴娶尸䤺戼績础睂牄牆", a_)))
					{
						num = (short)1844248591;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_357;
				case 10:
					goto IL_AA;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菆꣈뿊곌鿎ꏐ볒돔鯖룘맚꧜냞軠迢뇤闦苨\ud9ea\ud8ecꫮ룰럲럴軶觸髺軼賾䴀樂瘄猆䀈缊栌戎堐園䨔嘖⨘ⴚ⤜ⴞሠ", a_)))
					{
						num = (short)428605458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_576;
				case 12:
					this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("菆꣈뿊곌賎뻐뷒돔뻖뻘껚꿜뻞闠諢諤触귨諪駬軮ꇰ臲髴釶郸韺飼꯾猀瘂欄氆怈攊樌与⌐☒儔瘖洘稚娜洞丠嘢唤渦洨未䐬尮䔰稲䄴制吸町尼刾⑀ੂ⅄ᡆࡈ硊筌絎恐橒", a_), global::CommonResources.AcgResources.ID_DATAGROUPIDLISTITEMNAMEID, null, null, true, false);
					this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.DataTransferOrder = -1;
					num = (short)2091319299;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_571;
				case 14:
					goto IL_305;
				case 15:
					this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475 = new global::AcpBusinessLayer.AcpSimpleRangeField(2, this, global::AllFeatures.CodeplugGuid.b("菆꣈뿊곌鿎ꏐ볒돔鯖룘맚꧜냞軠迢ꇤꛦ뷨ꫪ달뿮ꏰ볲돴ꏶ诸軺鏼链栀洂戄䘆嬈堊䤌樎挐瘒爔縖樘漚漜縞唠䨢䨤䤦洨个䄬丮䠰朲尴娶尸䤺戼績础睂牄牆", a_), global::CommonResources.AcgResources.ID_TRUNKINGARSDEREGISTRATIONDELAYTIMER, null, null, 0, 1);
					this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.DataTransferOrder = -1;
					this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.ShowHexValue = false;
					num = (short)273874945;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菆꣈뿊곌賎뻐뷒돔뻖뻘껚꿜뻞闠諢諤触귨諪駬軮ꇰ臲髴釶郸韺飼꯾猀瘂欄氆怈攊樌与⌐☒儔瘖洘稚娜洞丠嘢唤渦洨未䐬尮䔰稲䄴制吸町尼刾⑀ੂ⅄ᡆࡈ硊筌絎恐橒", a_)))
					{
						num = (short)39256076;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C0;
				case 17:
					this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("菆꣈뿊곌鿎ꏐ볒돔鯖룘맚꧜냞軠迢ꇤꛦ뷨ꫪ달뿮ꏰ볲돴돶飸迺鳼믾搀漂氄焆氈礊琌䈎縐眒瀔䠖堘⨚Ⱌ⬞ᜠᬢ", a_), global::CommonResources.AcgResources.ID_DATADELIVERYMODE, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LOVs.DataProfLabtoolDATA_PROFDataDeliveryMode_A11468LovStrs);
					this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.DataTransferOrder = -1;
					num = (short)922288141;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					this.dataProfLabtoolTrk25EIDBypassListItemID_A36423 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("菆꣈뿊곌鿎ꏐ볒돔鯖룘맚꧜냞軠迢뇤闦苨\ud9ea\ud8ecꫮ룰럲럴軶觸髺軼賾䴀樂瘄猆䀈缊栌戎堐園䨔嘖⨘ⴚ⤜ⴞሠ", a_), global::CommonResources.AcgResources.ID_DATAPROFILETRUNKINGA25EIDBYPASSLISTITEMID, null, null, true, false);
					this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.DataTransferOrder = -1;
					num = (short)1194786830;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菆꣈뿊곌鿎ꏐ볒돔鯖룘맚꧜냞軠迢ꇤꛦ뷨ꫪ달뿮ꏰ볲돴돶飸迺鳼믾搀漂氄焆氈礊琌䈎縐眒瀔䠖堘⨚Ⱌ⬞ᜠᬢ", a_)))
					{
						num = (short)1543897105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_30A;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菆꣈뿊곌鿎ꏐ볒돔鯖룘맚꧜냞軠迢ꇤꛦ뷨ꫪ달뿮ꏰ볲돴듶雸闺诼髾漀眂氄栆月樊愌与䌐䀒儔爖欘縚稜瘞删圢圤䘦崨䈪䈬䄮田嘲头嘶䀸漺吼刾⑀ㅂᩄن筈筊瑌癎恐", a_)))
					{
						num = (short)1011941383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_421;
				case 21:
					switch (0)
					{
					case 0:
						goto IL_86;
					}
					continue;
				}
				IL_86:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1044578304;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_AA:
				num = (short)1091764240;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C0:
				num = (short)866779147;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_30A:
				num = (short)780795924;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_571:
				goto IL_30A;
				IL_357:
				num = (short)762183699;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_421:
				num = (short)1633878021;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_305:
			IL_576:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("识꣈꧊만ꃎ뻐뿒𥳐律鿚鳜诞ꃠ볢뗤뗦ꛨ귪", a_);
			base.Id = 10123;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOLDATA_PROF;
			base.DataTransferOrder = 3;
		}

		// Token: 0x0600AEDF RID: 44767 RVA: 0x00A2838C File Offset: 0x00A2658C
		public override void PopulateReferences()
		{
			short num = (short)1381279469;
			short num2 = num;
			num = (short)33400557;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1319829504;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2040659969;
			if (num != 0)
			{
			}
			num = (short)1037631488;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600AEE0 RID: 44768 RVA: 0x00A28434 File Offset: 0x00A26634
		public override void DropReferences()
		{
			short num = (short)158286952;
			short num2 = num;
			num = (short)1364477032;
			switch (num2 == num)
			{
			default:
			{
				num = (short)191496192;
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
			num = (short)1959591937;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600AEE1 RID: 44769 RVA: 0x00A284DC File Offset: 0x00A266DC
		public override void SetConstraints()
		{
			short num = (short)1381629953;
			if (num != 0)
			{
			}
			num = (short)160366592;
			short num2 = num;
			num = (short)248998160;
			short num3 = num;
			num = (short)1117350160;
			switch (num3 == num)
			{
			}
			num = (short)664207360;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600AEE2 RID: 44770 RVA: 0x00A28584 File Offset: 0x00A26784
		public override void SetupDependencies()
		{
			short num = (short)320515607;
			short num2 = num;
			num = (short)1446227479;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1545732096;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)918159360;
			if (num != 0)
			{
			}
			num = (short)454819841;
			if (num != 0)
			{
			}
		}

		// Token: 0x170057BE RID: 22462
		// (get) Token: 0x0600AEE3 RID: 44771 RVA: 0x00A2862C File Offset: 0x00A2682C
		public bool HasDiffs
		{
			get
			{
				short num = (short)352295655;
				short num2 = num;
				num = (short)1094097639;
				switch (num2 == num)
				{
				default:
				{
					num = (short)261160960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)420216833;
				if (num != 0)
				{
				}
				num = (short)1280442368;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170057BF RID: 22463
		// (get) Token: 0x0600AEE4 RID: 44772 RVA: 0x00A286DC File Offset: 0x00A268DC
		// (set) Token: 0x0600AEE5 RID: 44773 RVA: 0x00A28794 File Offset: 0x00A26994
		public int DataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475Value
		{
			get
			{
				short num = (short)2011121583;
				short num2 = num;
				num = (short)1651787695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)880934912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)14024705;
				if (num != 0)
				{
				}
				num = (short)1160511488;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.Value;
			}
			set
			{
				short num = (short)389414912;
				short num2 = num;
				num = (short)1036972672;
				short num3 = num;
				num = (short)1375728256;
				switch (num3 == num)
				{
				}
				num = (short)397475840;
				if (num != 0)
				{
				}
				num = (short)1831469057;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.Value = value;
			}
		}

		// Token: 0x170057C0 RID: 22464
		// (get) Token: 0x0600AEE6 RID: 44774 RVA: 0x00A28848 File Offset: 0x00A26A48
		public global::AcpBusinessLayer.AcpSimpleRangeField DataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475
		{
			get
			{
				short num = (short)207945728;
				short num2 = num;
				num = (short)1138647287;
				short num3 = num;
				num = (short)2018140407;
				switch (num3 == num)
				{
				}
				num = (short)1526988800;
				if (num != 0)
				{
				}
				num = (short)189792257;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475;
			}
		}

		// Token: 0x170057C1 RID: 22465
		// (get) Token: 0x0600AEE7 RID: 44775 RVA: 0x00A288FC File Offset: 0x00A26AFC
		// (set) Token: 0x0600AEE8 RID: 44776 RVA: 0x00A289B4 File Offset: 0x00A26BB4
		public string DataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475_UIValue
		{
			get
			{
				short num = (short)1140850688;
				short num2 = num;
				num = (short)202943836;
				short num3 = num;
				num = (short)70102364;
				switch (num3 == num)
				{
				}
				num = (short)212074497;
				if (num != 0)
				{
				}
				num = (short)1857617920;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.UIValue;
			}
			set
			{
				short num = (short)1084227584;
				short num2 = num;
				num = (short)1777336321;
				if (num != 0)
				{
				}
				num = (short)591222462;
				short num3 = num;
				num = (short)2036618942;
				switch (num3 == num)
				{
				}
				num = (short)88932352;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.UIValue = value;
			}
		}

		// Token: 0x170057C2 RID: 22466
		// (get) Token: 0x0600AEE9 RID: 44777 RVA: 0x00A28A6C File Offset: 0x00A26C6C
		// (set) Token: 0x0600AEEA RID: 44778 RVA: 0x00A28B20 File Offset: 0x00A26D20
		internal int DataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475Min
		{
			get
			{
				short num = (short)1536557056;
				short num2 = num;
				num = (short)1496514561;
				if (num != 0)
				{
				}
				num = (short)421295951;
				short num3 = num;
				num = (short)1169127247;
				switch (num3 == num)
				{
				}
				num = (short)1618477056;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.Min;
			}
			set
			{
				short num = (short)1155792896;
				short num2 = num;
				num = (short)1325173579;
				short num3 = num;
				num = (short)1218218827;
				switch (num3 == num)
				{
				}
				num = (short)708706305;
				if (num != 0)
				{
				}
				num = (short)1844183040;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.Min = value;
			}
		}

		// Token: 0x170057C3 RID: 22467
		// (get) Token: 0x0600AEEB RID: 44779 RVA: 0x00A28BD8 File Offset: 0x00A26DD8
		// (set) Token: 0x0600AEEC RID: 44780 RVA: 0x00A28C90 File Offset: 0x00A26E90
		internal int DataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475Max
		{
			get
			{
				short num = (short)413466624;
				short num2 = num;
				num = (short)1177684398;
				short num3 = num;
				num = (short)1154943406;
				switch (num3 == num)
				{
				}
				num = (short)768606208;
				if (num != 0)
				{
				}
				num = (short)983433217;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.Max;
			}
			set
			{
				short num = (short)761528320;
				short num2 = num;
				num = (short)1198969229;
				short num3 = num;
				num = (short)1892995469;
				switch (num3 == num)
				{
				}
				num = (short)401539073;
				if (num != 0)
				{
				}
				num = (short)447152128;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.Max = value;
			}
		}

		// Token: 0x170057C4 RID: 22468
		// (get) Token: 0x0600AEED RID: 44781 RVA: 0x00A28D48 File Offset: 0x00A26F48
		// (set) Token: 0x0600AEEE RID: 44782 RVA: 0x00A28E00 File Offset: 0x00A27000
		internal int DataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475Step
		{
			get
			{
				short num = (short)1509163008;
				short num2 = num;
				num = (short)438628426;
				short num3 = num;
				num = (short)364769354;
				switch (num3 == num)
				{
				}
				num = (short)1274544129;
				if (num != 0)
				{
				}
				num = (short)661389312;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.StepSize;
			}
			set
			{
				short num = (short)1466499072;
				short num2 = num;
				num = (short)537367454;
				short num3 = num;
				num = (short)1096848286;
				switch (num3 == num)
				{
				}
				num = (short)2068054017;
				if (num != 0)
				{
				}
				num = (short)1286078464;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.StepSize = value;
			}
		}

		// Token: 0x170057C5 RID: 22469
		// (get) Token: 0x0600AEEF RID: 44783 RVA: 0x00A28EB8 File Offset: 0x00A270B8
		// (set) Token: 0x0600AEF0 RID: 44784 RVA: 0x00A28F6C File Offset: 0x00A2716C
		public bool DataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475_Applicable
		{
			get
			{
				short num = (short)1415118848;
				short num2 = num;
				num = (short)858592558;
				short num3 = num;
				num = (short)1781273902;
				switch (num3 == num)
				{
				}
				num = (short)1648033793;
				if (num != 0)
				{
				}
				num = (short)448200704;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.Applicable;
			}
			set
			{
				short num = (short)1905786880;
				short num2 = num;
				num = (short)1909821361;
				short num3 = num;
				num = (short)983470001;
				switch (num3 == num)
				{
				}
				num = (short)1339883520;
				if (num != 0)
				{
				}
				num = (short)1038483457;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.Applicable = value;
			}
		}

		// Token: 0x170057C6 RID: 22470
		// (get) Token: 0x0600AEF1 RID: 44785 RVA: 0x00A29028 File Offset: 0x00A27228
		// (set) Token: 0x0600AEF2 RID: 44786 RVA: 0x00A290E0 File Offset: 0x00A272E0
		public bool DataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475_Valid
		{
			get
			{
				short num = (short)782041088;
				short num2 = num;
				num = (short)1676662116;
				short num3 = num;
				num = (short)152425828;
				switch (num3 == num)
				{
				}
				num = (short)750780416;
				if (num != 0)
				{
				}
				num = (short)1444872193;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.Valid;
			}
			set
			{
				short num = (short)706347008;
				short num2 = num;
				num = (short)315843174;
				short num3 = num;
				num = (short)866214502;
				switch (num3 == num)
				{
				}
				num = (short)106037249;
				if (num != 0)
				{
				}
				num = (short)805240832;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.Valid = value;
			}
		}

		// Token: 0x170057C7 RID: 22471
		// (get) Token: 0x0600AEF3 RID: 44787 RVA: 0x00A29194 File Offset: 0x00A27394
		// (set) Token: 0x0600AEF4 RID: 44788 RVA: 0x00A29248 File Offset: 0x00A27448
		public bool DataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475_Visible
		{
			get
			{
				short num = (short)2117992448;
				short num2 = num;
				num = (short)341835777;
				if (num != 0)
				{
				}
				num = (short)65899618;
				short num3 = num;
				num = (short)601328738;
				switch (num3 == num)
				{
				}
				num = (short)486670336;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.Visible;
			}
			set
			{
				short num = (short)159514624;
				short num2 = num;
				num = (short)933288100;
				short num3 = num;
				num = (short)1653201060;
				switch (num3 == num)
				{
				}
				num = (short)1782251520;
				if (num != 0)
				{
				}
				num = (short)1661206529;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.Visible = value;
			}
		}

		// Token: 0x170057C8 RID: 22472
		// (get) Token: 0x0600AEF5 RID: 44789 RVA: 0x00A292FC File Offset: 0x00A274FC
		// (set) Token: 0x0600AEF6 RID: 44790 RVA: 0x00A293B4 File Offset: 0x00A275B4
		public bool DataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475_Editable
		{
			get
			{
				short num = (short)1596981248;
				short num2 = num;
				num = (short)684583170;
				short num3 = num;
				num = (short)1645406466;
				switch (num3 == num)
				{
				}
				num = (short)2091712513;
				if (num != 0)
				{
				}
				num = (short)2009595904;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.Editable;
			}
			set
			{
				short num = (short)129826816;
				short num2 = num;
				num = (short)768081921;
				if (num != 0)
				{
				}
				num = (short)104446908;
				short num3 = num;
				num = (short)2128329660;
				switch (num3 == num)
				{
				}
				num = (short)2101936128;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.Editable = value;
			}
		}

		// Token: 0x170057C9 RID: 22473
		// (get) Token: 0x0600AEF7 RID: 44791 RVA: 0x00A29468 File Offset: 0x00A27668
		internal string DataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475_UILabel
		{
			get
			{
				short num = (short)1132265472;
				short num2 = num;
				num = (short)139945413;
				short num3 = num;
				num = (short)995911109;
				switch (num3 == num)
				{
				}
				num = (short)1289027585;
				if (num != 0)
				{
				}
				num = (short)543555584;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.UIName;
			}
		}

		// Token: 0x170057CA RID: 22474
		// (get) Token: 0x0600AEF8 RID: 44792 RVA: 0x00A29520 File Offset: 0x00A27720
		// (set) Token: 0x0600AEF9 RID: 44793 RVA: 0x00A295D4 File Offset: 0x00A277D4
		internal bool DataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475_HiddenStatic
		{
			get
			{
				short num = (short)711720960;
				short num2 = num;
				num = (short)1201908862;
				short num3 = num;
				num = (short)1185918078;
				switch (num3 == num)
				{
				}
				num = (short)40239105;
				if (num != 0)
				{
				}
				num = (short)1485111296;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.HiddenStatic;
			}
			set
			{
				short num = (short)1271201792;
				short num2 = num;
				num = (short)948469813;
				short num3 = num;
				num = (short)603684917;
				switch (num3 == num)
				{
				}
				num = (short)686555137;
				if (num != 0)
				{
				}
				num = (short)2020016128;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.HiddenStatic = value;
			}
		}

		// Token: 0x170057CB RID: 22475
		// (get) Token: 0x0600AEFA RID: 44794 RVA: 0x00A2968C File Offset: 0x00A2788C
		// (set) Token: 0x0600AEFB RID: 44795 RVA: 0x00A29744 File Offset: 0x00A27944
		internal bool DataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475_HiddenDynamic
		{
			get
			{
				short num = (short)996212736;
				short num2 = num;
				num = (short)85130680;
				short num3 = num;
				num = (short)1279327672;
				switch (num3 == num)
				{
				}
				num = (short)1393295361;
				if (num != 0)
				{
				}
				num = (short)139329536;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.HiddenDynamic;
			}
			set
			{
				short num = (short)18939904;
				short num2 = num;
				num = (short)1421821425;
				short num3 = num;
				num = (short)290932209;
				switch (num3 == num)
				{
				}
				num = (short)1083375617;
				if (num != 0)
				{
				}
				num = (short)1073414144;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.HiddenDynamic = value;
			}
		}

		// Token: 0x170057CC RID: 22476
		// (get) Token: 0x0600AEFC RID: 44796 RVA: 0x00A297FC File Offset: 0x00A279FC
		public bool DataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475_HasDiffs
		{
			get
			{
				short num = (short)414515200;
				short num2 = num;
				num = (short)1893589287;
				short num3 = num;
				num = (short)1127407911;
				switch (num3 == num)
				{
				}
				num = (short)1078198272;
				if (num != 0)
				{
				}
				num = (short)1642397697;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475._HasDiffs;
			}
		}

		// Token: 0x170057CD RID: 22477
		// (get) Token: 0x0600AEFD RID: 44797 RVA: 0x00A298B4 File Offset: 0x00A27AB4
		// (set) Token: 0x0600AEFE RID: 44798 RVA: 0x00A29968 File Offset: 0x00A27B68
		public int DataProfLabtoolDATA_PROFDataDeliveryMode_A11468Value
		{
			get
			{
				short num = (short)969080832;
				short num2 = num;
				num = (short)1896949123;
				short num3 = num;
				num = (short)326837635;
				switch (num3 == num)
				{
				}
				num = (short)1447559168;
				if (num != 0)
				{
				}
				num = (short)1573191681;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.Value;
			}
			set
			{
				short num = (short)295043072;
				short num2 = num;
				num = (short)26425467;
				short num3 = num;
				num = (short)1163933819;
				switch (num3 == num)
				{
				}
				num = (short)289996801;
				if (num != 0)
				{
				}
				num = (short)1999110144;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.Value = value;
			}
		}

		// Token: 0x170057CE RID: 22478
		// (get) Token: 0x0600AEFF RID: 44799 RVA: 0x00A29A1C File Offset: 0x00A27C1C
		// (set) Token: 0x0600AF00 RID: 44800 RVA: 0x00A29AD4 File Offset: 0x00A27CD4
		public string DataProfLabtoolDATA_PROFDataDeliveryMode_A11468_UIValue
		{
			get
			{
				short num = (short)148307968;
				short num2 = num;
				num = (short)1862846231;
				short num3 = num;
				num = (short)1254868759;
				switch (num3 == num)
				{
				}
				num = (short)2049572864;
				if (num != 0)
				{
				}
				num = (short)2078277633;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.UIValue;
			}
			set
			{
				short num = (short)619446272;
				short num2 = num;
				num = (short)318882438;
				short num3 = num;
				num = (short)2094514822;
				switch (num3 == num)
				{
				}
				num = (short)1900412929;
				if (num != 0)
				{
				}
				num = (short)1878589440;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.UIValue = value;
			}
		}

		// Token: 0x170057CF RID: 22479
		// (get) Token: 0x0600AF01 RID: 44801 RVA: 0x00A29B8C File Offset: 0x00A27D8C
		public global::AcpBusinessLayer.AcpListField DataProfLabtoolDATA_PROFDataDeliveryMode_A11468
		{
			get
			{
				short num = (short)2109734912;
				short num2 = num;
				num = (short)1189980690;
				short num3 = num;
				num = (short)1258596882;
				switch (num3 == num)
				{
				}
				num = (short)1566769152;
				if (num != 0)
				{
				}
				num = (short)969932801;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468;
			}
		}

		// Token: 0x170057D0 RID: 22480
		// (get) Token: 0x0600AF02 RID: 44802 RVA: 0x00A29C3C File Offset: 0x00A27E3C
		// (set) Token: 0x0600AF03 RID: 44803 RVA: 0x00A29CF0 File Offset: 0x00A27EF0
		public bool DataProfLabtoolDATA_PROFDataDeliveryMode_A11468_Applicable
		{
			get
			{
				short num = (short)1192755200;
				short num2 = num;
				num = (short)804354291;
				short num3 = num;
				num = (short)1215985907;
				switch (num3 == num)
				{
				}
				num = (short)956760064;
				if (num != 0)
				{
				}
				num = (short)1494941697;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.Applicable;
			}
			set
			{
				short num = (short)1219690496;
				short num2 = num;
				num = (short)1571424247;
				short num3 = num;
				num = (short)808191991;
				switch (num3 == num)
				{
				}
				num = (short)605290497;
				if (num != 0)
				{
				}
				num = (short)1671364608;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.Applicable = value;
			}
		}

		// Token: 0x170057D1 RID: 22481
		// (get) Token: 0x0600AF04 RID: 44804 RVA: 0x00A29DA8 File Offset: 0x00A27FA8
		// (set) Token: 0x0600AF05 RID: 44805 RVA: 0x00A29E5C File Offset: 0x00A2805C
		public bool DataProfLabtoolDATA_PROFDataDeliveryMode_A11468_Valid
		{
			get
			{
				short num = (short)1522925568;
				short num2 = num;
				num = (short)566875824;
				short num3 = num;
				num = (short)480433840;
				switch (num3 == num)
				{
				}
				num = (short)565641217;
				if (num != 0)
				{
				}
				num = (short)911409152;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.Valid;
			}
			set
			{
				short num = (short)662568960;
				short num2 = num;
				num = (short)1408271760;
				short num3 = num;
				num = (short)815826320;
				switch (num3 == num)
				{
				}
				num = (short)614662145;
				if (num != 0)
				{
				}
				num = (short)122224640;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.Valid = value;
			}
		}

		// Token: 0x170057D2 RID: 22482
		// (get) Token: 0x0600AF06 RID: 44806 RVA: 0x00A29F10 File Offset: 0x00A28110
		// (set) Token: 0x0600AF07 RID: 44807 RVA: 0x00A29FC8 File Offset: 0x00A281C8
		public bool DataProfLabtoolDATA_PROFDataDeliveryMode_A11468_Visible
		{
			get
			{
				short num = (short)1562443776;
				short num2 = num;
				num = (short)192544769;
				if (num != 0)
				{
				}
				num = (short)1421630193;
				short num3 = num;
				num = (short)671308529;
				switch (num3 == num)
				{
				}
				num = (short)1019674624;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.Visible;
			}
			set
			{
				short num = (short)1373700096;
				short num2 = num;
				num = (short)979977896;
				short num3 = num;
				num = (short)489572008;
				switch (num3 == num)
				{
				}
				num = (short)912850944;
				if (num != 0)
				{
				}
				num = (short)1080950785;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.Visible = value;
			}
		}

		// Token: 0x170057D3 RID: 22483
		// (get) Token: 0x0600AF08 RID: 44808 RVA: 0x00A2A07C File Offset: 0x00A2827C
		// (set) Token: 0x0600AF09 RID: 44809 RVA: 0x00A2A130 File Offset: 0x00A28330
		public bool DataProfLabtoolDATA_PROFDataDeliveryMode_A11468_Editable
		{
			get
			{
				short num = (short)1746993152;
				short num2 = num;
				num = (short)1615921153;
				if (num != 0)
				{
				}
				num = (short)812423330;
				short num3 = num;
				num = (short)1791269026;
				switch (num3 == num)
				{
				}
				num = (short)1534918656;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.Editable;
			}
			set
			{
				short num = (short)624361472;
				short num2 = num;
				num = (short)1934014345;
				short num3 = num;
				num = (short)1642641289;
				switch (num3 == num)
				{
				}
				num = (short)2077491201;
				if (num != 0)
				{
				}
				num = (short)1607335936;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.Editable = value;
			}
		}

		// Token: 0x170057D4 RID: 22484
		// (get) Token: 0x0600AF0A RID: 44810 RVA: 0x00A2A1E4 File Offset: 0x00A283E4
		internal string DataProfLabtoolDATA_PROFDataDeliveryMode_A11468_UILabel
		{
			get
			{
				short num = (short)526188544;
				short num2 = num;
				num = (short)1790947574;
				short num3 = num;
				num = (short)2144973046;
				switch (num3 == num)
				{
				}
				num = (short)872087553;
				if (num != 0)
				{
				}
				num = (short)363986944;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.UIName;
			}
		}

		// Token: 0x170057D5 RID: 22485
		// (get) Token: 0x0600AF0B RID: 44811 RVA: 0x00A2A298 File Offset: 0x00A28498
		// (set) Token: 0x0600AF0C RID: 44812 RVA: 0x00A2A34C File Offset: 0x00A2854C
		internal bool DataProfLabtoolDATA_PROFDataDeliveryMode_A11468_HiddenStatic
		{
			get
			{
				short num = (short)1526792192;
				short num2 = num;
				num = (short)916455425;
				if (num != 0)
				{
				}
				num = (short)759186775;
				short num3 = num;
				num = (short)1192707415;
				switch (num3 == num)
				{
				}
				num = (short)1221459968;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.HiddenStatic;
			}
			set
			{
				short num = (short)1336803328;
				short num2 = num;
				num = (short)1758013062;
				short num3 = num;
				num = (short)2036999814;
				switch (num3 == num)
				{
				}
				num = (short)878968833;
				if (num != 0)
				{
				}
				num = (short)922550272;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.HiddenStatic = value;
			}
		}

		// Token: 0x170057D6 RID: 22486
		// (get) Token: 0x0600AF0D RID: 44813 RVA: 0x00A2A400 File Offset: 0x00A28600
		// (set) Token: 0x0600AF0E RID: 44814 RVA: 0x00A2A4B4 File Offset: 0x00A286B4
		internal bool DataProfLabtoolDATA_PROFDataDeliveryMode_A11468_HiddenDynamic
		{
			get
			{
				short num = (short)1749811200;
				short num2 = num;
				num = (short)1167179535;
				short num3 = num;
				num = (short)380550927;
				switch (num3 == num)
				{
				}
				num = (short)1475674112;
				if (num != 0)
				{
				}
				num = (short)185663489;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.HiddenDynamic;
			}
			set
			{
				short num = (short)1914568704;
				short num2 = num;
				num = (short)390332417;
				if (num != 0)
				{
				}
				num = (short)962058834;
				short num3 = num;
				num = (short)1197529682;
				switch (num3 == num)
				{
				}
				num = (short)1040121856;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468.HiddenDynamic = value;
			}
		}

		// Token: 0x170057D7 RID: 22487
		// (get) Token: 0x0600AF0F RID: 44815 RVA: 0x00A2A56C File Offset: 0x00A2876C
		public bool DataProfLabtoolDATA_PROFDataDeliveryMode_A11468_HasDiffs
		{
			get
			{
				short num = (short)39388024;
				short num2 = num;
				num = (short)1713767288;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1075314688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)801046529;
				if (num != 0)
				{
				}
				num = (short)744488960;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFDataDeliveryMode_A11468._HasDiffs;
			}
		}

		// Token: 0x170057D8 RID: 22488
		// (get) Token: 0x0600AF10 RID: 44816 RVA: 0x00A2A620 File Offset: 0x00A28820
		// (set) Token: 0x0600AF11 RID: 44817 RVA: 0x00A2A6D4 File Offset: 0x00A288D4
		public int DataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991Value
		{
			get
			{
				short num = (short)569012532;
				short num2 = num;
				num = (short)1934717236;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1240727552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1729691649;
				if (num != 0)
				{
				}
				num = (short)1575616512;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.Value;
			}
			set
			{
				short num = (short)1649203896;
				short num2 = num;
				num = (short)1509415608;
				switch (num2 == num)
				{
				default:
				{
					num = (short)599785472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1174405120;
				if (num != 0)
				{
				}
				num = (short)448200705;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.Value = value;
			}
		}

		// Token: 0x170057D9 RID: 22489
		// (get) Token: 0x0600AF12 RID: 44818 RVA: 0x00A2A78C File Offset: 0x00A2898C
		public global::AcpBusinessLayer.AcpSimpleRangeField DataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991
		{
			get
			{
				short num = (short)1453049862;
				short num2 = num;
				num = (short)1331480582;
				switch (num2 == num)
				{
				default:
				{
					num = (short)382664704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)163577857;
				if (num != 0)
				{
				}
				num = (short)1314586624;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991;
			}
		}

		// Token: 0x170057DA RID: 22490
		// (get) Token: 0x0600AF13 RID: 44819 RVA: 0x00A2A838 File Offset: 0x00A28A38
		// (set) Token: 0x0600AF14 RID: 44820 RVA: 0x00A2A8F0 File Offset: 0x00A28AF0
		public string DataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991_UIValue
		{
			get
			{
				short num = (short)44828624;
				short num2 = num;
				num = (short)1753483216;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1933180928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)364773376;
				if (num != 0)
				{
				}
				num = (short)596836353;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.UIValue;
			}
			set
			{
				short num = (short)854524511;
				short num2 = num;
				num = (short)1983054431;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1733296128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)579993601;
				if (num != 0)
				{
				}
				num = (short)864485376;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.UIValue = value;
			}
		}

		// Token: 0x170057DB RID: 22491
		// (get) Token: 0x0600AF15 RID: 44821 RVA: 0x00A2A9A8 File Offset: 0x00A28BA8
		// (set) Token: 0x0600AF16 RID: 44822 RVA: 0x00A2AA60 File Offset: 0x00A28C60
		internal int DataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991Min
		{
			get
			{
				short num = (short)783203635;
				short num2 = num;
				num = (short)1767619891;
				switch (num2 == num)
				{
				default:
				{
					num = (short)402522112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)963706881;
				if (num != 0)
				{
				}
				num = (short)71958528;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.Min;
			}
			set
			{
				short num = (short)1451544136;
				short num2 = num;
				num = (short)1093455432;
				switch (num2 == num)
				{
				default:
				{
					num = (short)115802112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1286668289;
				if (num != 0)
				{
				}
				num = (short)2065629184;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.Min = value;
			}
		}

		// Token: 0x170057DC RID: 22492
		// (get) Token: 0x0600AF17 RID: 44823 RVA: 0x00A2AB14 File Offset: 0x00A28D14
		// (set) Token: 0x0600AF18 RID: 44824 RVA: 0x00A2ABCC File Offset: 0x00A28DCC
		internal int DataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991Max
		{
			get
			{
				short num = (short)265050982;
				short num2 = num;
				num = (short)729439078;
				switch (num2 == num)
				{
				default:
				{
					num = (short)606666752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1948909569;
				if (num != 0)
				{
				}
				num = (short)925302784;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.Max;
			}
			set
			{
				short num = (short)1605042177;
				if (num != 0)
				{
				}
				num = (short)603193344;
				short num2 = num;
				num = (short)1801432403;
				short num3 = num;
				num = (short)1081912659;
				switch (num3 == num)
				{
				}
				num = (short)1366294528;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.Max = value;
			}
		}

		// Token: 0x170057DD RID: 22493
		// (get) Token: 0x0600AF19 RID: 44825 RVA: 0x00A2AC80 File Offset: 0x00A28E80
		// (set) Token: 0x0600AF1A RID: 44826 RVA: 0x00A2AD34 File Offset: 0x00A28F34
		internal int DataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991Step
		{
			get
			{
				short num = (short)2034452562;
				short num2 = num;
				num = (short)284510290;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1081016320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)25886721;
				if (num != 0)
				{
				}
				num = (short)757071872;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.StepSize;
			}
			set
			{
				short num = (short)1360588393;
				short num2 = num;
				num = (short)1144647273;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1702166528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1932197888;
				if (num != 0)
				{
				}
				num = (short)1837629441;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.StepSize = value;
			}
		}

		// Token: 0x170057DE RID: 22494
		// (get) Token: 0x0600AF1B RID: 44827 RVA: 0x00A2ADE8 File Offset: 0x00A28FE8
		// (set) Token: 0x0600AF1C RID: 44828 RVA: 0x00A2AE9C File Offset: 0x00A2909C
		public bool DataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991_Applicable
		{
			get
			{
				short num = (short)539477882;
				short num2 = num;
				num = (short)380880762;
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
				num = (short)437387264;
				if (num != 0)
				{
				}
				num = (short)491257857;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.Applicable;
			}
			set
			{
				short num = (short)360838343;
				short num2 = num;
				num = (short)1922495687;
				switch (num2 == num)
				{
				default:
				{
					num = (short)881786880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)90570753;
				if (num != 0)
				{
				}
				num = (short)22740992;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.Applicable = value;
			}
		}

		// Token: 0x170057DF RID: 22495
		// (get) Token: 0x0600AF1D RID: 44829 RVA: 0x00A2AF50 File Offset: 0x00A29150
		// (set) Token: 0x0600AF1E RID: 44830 RVA: 0x00A2B004 File Offset: 0x00A29204
		public bool DataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991_Valid
		{
			get
			{
				short num = (short)1812856833;
				if (num != 0)
				{
				}
				num = (short)1802829824;
				short num2 = num;
				num = (short)1117199110;
				short num3 = num;
				num = (short)1501174534;
				switch (num3 == num)
				{
				}
				num = (short)582615040;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.Valid;
			}
			set
			{
				short num = (short)114478133;
				short num2 = num;
				num = (short)1818610741;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1588264960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1954676737;
				if (num != 0)
				{
				}
				num = (short)719126528;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.Valid = value;
			}
		}

		// Token: 0x170057E0 RID: 22496
		// (get) Token: 0x0600AF1F RID: 44831 RVA: 0x00A2B0B8 File Offset: 0x00A292B8
		// (set) Token: 0x0600AF20 RID: 44832 RVA: 0x00A2B16C File Offset: 0x00A2936C
		public bool DataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991_Visible
		{
			get
			{
				short num = (short)1208889659;
				short num2 = num;
				num = (short)823865659;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2064515072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)662437889;
				if (num != 0)
				{
				}
				num = (short)1591083008;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.Visible;
			}
			set
			{
				short num = (short)506937044;
				short num2 = num;
				num = (short)602029780;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1171718144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)512491521;
				if (num != 0)
				{
				}
				num = (short)1048444928;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.Visible = value;
			}
		}

		// Token: 0x170057E1 RID: 22497
		// (get) Token: 0x0600AF21 RID: 44833 RVA: 0x00A2B220 File Offset: 0x00A29420
		// (set) Token: 0x0600AF22 RID: 44834 RVA: 0x00A2B2D8 File Offset: 0x00A294D8
		public bool DataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991_Editable
		{
			get
			{
				short num = (short)706200628;
				short num2 = num;
				num = (short)1316471860;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2053767168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1285095425;
				if (num != 0)
				{
				}
				num = (short)1863909376;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.Editable;
			}
			set
			{
				short num = (short)1927694119;
				short num2 = num;
				num = (short)618546983;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2082209792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1099956225;
				if (num != 0)
				{
				}
				num = (short)296484864;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.Editable = value;
			}
		}

		// Token: 0x170057E2 RID: 22498
		// (get) Token: 0x0600AF23 RID: 44835 RVA: 0x00A2B38C File Offset: 0x00A2958C
		internal string DataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991_UILabel
		{
			get
			{
				short num = (short)377366394;
				short num2 = num;
				num = (short)168241018;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1965752320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)847511553;
				if (num != 0)
				{
				}
				num = (short)47775744;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.UIName;
			}
		}

		// Token: 0x170057E3 RID: 22499
		// (get) Token: 0x0600AF24 RID: 44836 RVA: 0x00A2B440 File Offset: 0x00A29640
		// (set) Token: 0x0600AF25 RID: 44837 RVA: 0x00A2B4F4 File Offset: 0x00A296F4
		internal bool DataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991_HiddenStatic
		{
			get
			{
				short num = (short)1675982679;
				short num2 = num;
				num = (short)187201367;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1776549888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1854275585;
				if (num != 0)
				{
				}
				num = (short)239992832;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.HiddenStatic;
			}
			set
			{
				short num = (short)1600490406;
				short num2 = num;
				num = (short)809012134;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1434517504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)723451905;
				if (num != 0)
				{
				}
				num = (short)909115392;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.HiddenStatic = value;
			}
		}

		// Token: 0x170057E4 RID: 22500
		// (get) Token: 0x0600AF26 RID: 44838 RVA: 0x00A2B5A8 File Offset: 0x00A297A8
		// (set) Token: 0x0600AF27 RID: 44839 RVA: 0x00A2B660 File Offset: 0x00A29860
		internal bool DataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991_HiddenDynamic
		{
			get
			{
				short num = (short)655179390;
				short num2 = num;
				num = (short)1789279870;
				switch (num2 == num)
				{
				default:
				{
					num = (short)544604160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1482620928;
				if (num != 0)
				{
				}
				num = (short)1715273729;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.HiddenDynamic;
			}
			set
			{
				short num = (short)1289423392;
				short num2 = num;
				num = (short)1369508384;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1413414912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)441057281;
				if (num != 0)
				{
				}
				num = (short)641335296;
				if (num != 0)
				{
				}
				this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.HiddenDynamic = value;
			}
		}

		// Token: 0x170057E5 RID: 22501
		// (get) Token: 0x0600AF28 RID: 44840 RVA: 0x00A2B714 File Offset: 0x00A29914
		public bool DataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991_HasDiffs
		{
			get
			{
				short num = (short)338393715;
				short num2 = num;
				num = (short)1344109171;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1679556608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1860894720;
				if (num != 0)
				{
				}
				num = (short)2138636289;
				if (num != 0)
				{
				}
				return this.dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991._HasDiffs;
			}
		}

		// Token: 0x170057E6 RID: 22502
		// (get) Token: 0x0600AF29 RID: 44841 RVA: 0x00A2B7CC File Offset: 0x00A299CC
		// (set) Token: 0x0600AF2A RID: 44842 RVA: 0x00A2B884 File Offset: 0x00A29A84
		public int DataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218Value
		{
			get
			{
				short num = (short)642522046;
				short num2 = num;
				num = (short)1585454014;
				switch (num2 == num)
				{
				default:
				{
					num = (short)669515776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1918566400;
				if (num != 0)
				{
				}
				num = (short)434438145;
				if (num != 0)
				{
				}
				return this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.Value;
			}
			set
			{
				short num = (short)624230401;
				if (num != 0)
				{
				}
				num = (short)293404672;
				short num2 = num;
				num = (short)459273152;
				short num3 = num;
				num = (short)1549267904;
				switch (num3 == num)
				{
				}
				num = (short)2114650112;
				if (num != 0)
				{
				}
				this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.Value = value;
			}
		}

		// Token: 0x170057E7 RID: 22503
		// (get) Token: 0x0600AF2B RID: 44843 RVA: 0x00A2B940 File Offset: 0x00A29B40
		// (set) Token: 0x0600AF2C RID: 44844 RVA: 0x00A2B9F4 File Offset: 0x00A29BF4
		public string DataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218_UIValue
		{
			get
			{
				short num = (short)1051009307;
				short num2 = num;
				num = (short)253174043;
				switch (num2 == num)
				{
				default:
				{
					num = (short)809041920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1602224129;
				if (num != 0)
				{
				}
				num = (short)1776353280;
				if (num != 0)
				{
				}
				return this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.UIValue;
			}
			set
			{
				short num = (short)1120090123;
				short num2 = num;
				num = (short)1164851211;
				switch (num2 == num)
				{
				default:
				{
					num = (short)414384128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1569062912;
				if (num != 0)
				{
				}
				num = (short)198246401;
				if (num != 0)
				{
				}
				this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.UIValue = value;
			}
		}

		// Token: 0x170057E8 RID: 22504
		// (get) Token: 0x0600AF2D RID: 44845 RVA: 0x00A2BAA8 File Offset: 0x00A29CA8
		public global::AcpBusinessLayer.AcpRecRefField DataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218
		{
			get
			{
				short num = (short)2085814273;
				if (num != 0)
				{
				}
				num = (short)1041694720;
				short num2 = num;
				num = (short)1291679332;
				short num3 = num;
				num = (short)1416066660;
				switch (num3 == num)
				{
				}
				num = (short)237436928;
				if (num != 0)
				{
				}
				return this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218;
			}
		}

		// Token: 0x170057E9 RID: 22505
		// (get) Token: 0x0600AF2E RID: 44846 RVA: 0x00A2BB58 File Offset: 0x00A29D58
		// (set) Token: 0x0600AF2F RID: 44847 RVA: 0x00A2BC0C File Offset: 0x00A29E0C
		public bool DataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218_Applicable
		{
			get
			{
				short num = (short)1382219777;
				if (num != 0)
				{
				}
				num = (short)663224320;
				short num2 = num;
				num = (short)230899518;
				short num3 = num;
				num = (short)1626160958;
				switch (num3 == num)
				{
				}
				num = (short)851705856;
				if (num != 0)
				{
				}
				return this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.Applicable;
			}
			set
			{
				short num = (short)1179905390;
				short num2 = num;
				num = (short)618982766;
				switch (num2 == num)
				{
				default:
				{
					num = (short)311099392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1778450433;
				if (num != 0)
				{
				}
				num = (short)890568704;
				if (num != 0)
				{
				}
				this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.Applicable = value;
			}
		}

		// Token: 0x170057EA RID: 22506
		// (get) Token: 0x0600AF30 RID: 44848 RVA: 0x00A2BCC0 File Offset: 0x00A29EC0
		// (set) Token: 0x0600AF31 RID: 44849 RVA: 0x00A2BD78 File Offset: 0x00A29F78
		public bool DataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218_Valid
		{
			get
			{
				short num = (short)691709410;
				short num2 = num;
				num = (short)1065723362;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1611923456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1704722433;
				if (num != 0)
				{
				}
				num = (short)1607073792;
				if (num != 0)
				{
				}
				return this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.Valid;
			}
			set
			{
				short num = (short)599719937;
				if (num != 0)
				{
				}
				num = (short)1307770880;
				short num2 = num;
				num = (short)456718911;
				short num3 = num;
				num = (short)1151072831;
				switch (num3 == num)
				{
				}
				num = (short)1198063616;
				if (num != 0)
				{
				}
				this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.Valid = value;
			}
		}

		// Token: 0x170057EB RID: 22507
		// (get) Token: 0x0600AF32 RID: 44850 RVA: 0x00A2BE30 File Offset: 0x00A2A030
		// (set) Token: 0x0600AF33 RID: 44851 RVA: 0x00A2BEE8 File Offset: 0x00A2A0E8
		public bool DataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218_Visible
		{
			get
			{
				short num = (short)1840698556;
				short num2 = num;
				num = (short)41735356;
				switch (num2 == num)
				{
				default:
				{
					num = (short)301203456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)565313537;
				if (num != 0)
				{
				}
				num = (short)2086207488;
				if (num != 0)
				{
				}
				return this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.Visible;
			}
			set
			{
				short num = (short)1390477313;
				if (num != 0)
				{
				}
				num = (short)1312489472;
				short num2 = num;
				num = (short)707921518;
				short num3 = num;
				num = (short)1788675694;
				switch (num3 == num)
				{
				}
				num = (short)1234042880;
				if (num != 0)
				{
				}
				this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.Visible = value;
			}
		}

		// Token: 0x170057EC RID: 22508
		// (get) Token: 0x0600AF34 RID: 44852 RVA: 0x00A2BF9C File Offset: 0x00A2A19C
		// (set) Token: 0x0600AF35 RID: 44853 RVA: 0x00A2C050 File Offset: 0x00A2A250
		public bool DataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218_Editable
		{
			get
			{
				short num = (short)1576951165;
				short num2 = num;
				num = (short)1058758013;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1509949440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)455540737;
				if (num != 0)
				{
				}
				num = (short)706740224;
				if (num != 0)
				{
				}
				return this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.Editable;
			}
			set
			{
				short num = (short)249835690;
				short num2 = num;
				num = (short)1991651498;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1126891520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1914241025;
				if (num != 0)
				{
				}
				num = (short)1015283712;
				if (num != 0)
				{
				}
				this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.Editable = value;
			}
		}

		// Token: 0x170057ED RID: 22509
		// (get) Token: 0x0600AF36 RID: 44854 RVA: 0x00A2C104 File Offset: 0x00A2A304
		internal string DataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218_UILabel
		{
			get
			{
				short num = (short)1955644599;
				short num2 = num;
				num = (short)557761719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)787415040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1376845825;
				if (num != 0)
				{
				}
				num = (short)950468608;
				if (num != 0)
				{
				}
				return this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.UIName;
			}
		}

		// Token: 0x170057EE RID: 22510
		// (get) Token: 0x0600AF37 RID: 44855 RVA: 0x00A2C1B8 File Offset: 0x00A2A3B8
		// (set) Token: 0x0600AF38 RID: 44856 RVA: 0x00A2C26C File Offset: 0x00A2A46C
		internal bool DataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218_HiddenStatic
		{
			get
			{
				short num = (short)1210058067;
				short num2 = num;
				num = (short)1563624787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)145555456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1854996481;
				if (num != 0)
				{
				}
				num = (short)1918435328;
				if (num != 0)
				{
				}
				return this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.HiddenStatic;
			}
			set
			{
				short num = (short)1428675530;
				short num2 = num;
				num = (short)2114444234;
				switch (num2 == num)
				{
				default:
				{
					num = (short)465829888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)282198017;
				if (num != 0)
				{
				}
				num = (short)1855455232;
				if (num != 0)
				{
				}
				this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.HiddenStatic = value;
			}
		}

		// Token: 0x170057EF RID: 22511
		// (get) Token: 0x0600AF39 RID: 44857 RVA: 0x00A2C324 File Offset: 0x00A2A524
		// (set) Token: 0x0600AF3A RID: 44858 RVA: 0x00A2C3DC File Offset: 0x00A2A5DC
		internal bool DataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218_HiddenDynamic
		{
			get
			{
				short num = (short)903814541;
				short num2 = num;
				num = (short)311565709;
				switch (num2 == num)
				{
				default:
				{
					num = (short)88014848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)650575873;
				if (num != 0)
				{
				}
				num = (short)1778712576;
				if (num != 0)
				{
				}
				return this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.HiddenDynamic;
			}
			set
			{
				short num = (short)1984692225;
				if (num != 0)
				{
				}
				num = (short)907149312;
				short num2 = num;
				num = (short)1246780067;
				short num3 = num;
				num = (short)1722964643;
				switch (num3 == num)
				{
				}
				num = (short)1712717824;
				if (num != 0)
				{
				}
				this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.HiddenDynamic = value;
			}
		}

		// Token: 0x170057F0 RID: 22512
		// (get) Token: 0x0600AF3B RID: 44859 RVA: 0x00A2C490 File Offset: 0x00A2A690
		public bool DataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218_HasDiffs
		{
			get
			{
				short num = (short)12845057;
				if (num != 0)
				{
				}
				num = (short)149028864;
				short num2 = num;
				num = (short)1918799453;
				short num3 = num;
				num = (short)1653575261;
				switch (num3 == num)
				{
				}
				num = (short)861405184;
				if (num != 0)
				{
				}
				return this.dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218._HasDiffs;
			}
		}

		// Token: 0x170057F1 RID: 22513
		// (get) Token: 0x0600AF3C RID: 44860 RVA: 0x00A2C548 File Offset: 0x00A2A748
		// (set) Token: 0x0600AF3D RID: 44861 RVA: 0x00A2C600 File Offset: 0x00A2A800
		public int DataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219Value
		{
			get
			{
				short num = (short)375363367;
				short num2 = num;
				num = (short)1382651687;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1634729984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)649396225;
				if (num != 0)
				{
				}
				num = (short)1111490560;
				if (num != 0)
				{
				}
				return this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.Value;
			}
			set
			{
				short num = (short)435786614;
				short num2 = num;
				num = (short)820679542;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2018443264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1938554881;
				if (num != 0)
				{
				}
				num = (short)1430585344;
				if (num != 0)
				{
				}
				this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.Value = value;
			}
		}

		// Token: 0x170057F2 RID: 22514
		// (get) Token: 0x0600AF3E RID: 44862 RVA: 0x00A2C6B4 File Offset: 0x00A2A8B4
		// (set) Token: 0x0600AF3F RID: 44863 RVA: 0x00A2C76C File Offset: 0x00A2A96C
		public string DataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219_UIValue
		{
			get
			{
				short num = (short)249057760;
				short num2 = num;
				num = (short)949506528;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1424490496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)20185089;
				if (num != 0)
				{
				}
				num = (short)1925382144;
				if (num != 0)
				{
				}
				return this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.UIValue;
			}
			set
			{
				short num = (short)1289486337;
				if (num != 0)
				{
				}
				num = (short)1520041984;
				short num2 = num;
				num = (short)11173276;
				short num3 = num;
				num = (short)62815644;
				switch (num3 == num)
				{
				}
				num = (short)542638080;
				if (num != 0)
				{
				}
				this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.UIValue = value;
			}
		}

		// Token: 0x170057F3 RID: 22515
		// (get) Token: 0x0600AF40 RID: 44864 RVA: 0x00A2C824 File Offset: 0x00A2AA24
		public global::AcpBusinessLayer.AcpRecRefField DataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219
		{
			get
			{
				short num = (short)864086867;
				short num2 = num;
				num = (short)924904275;
				switch (num2 == num)
				{
				default:
				{
					num = (short)519569408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)864616449;
				if (num != 0)
				{
				}
				num = (short)1986592768;
				if (num != 0)
				{
				}
				return this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219;
			}
		}

		// Token: 0x170057F4 RID: 22516
		// (get) Token: 0x0600AF41 RID: 44865 RVA: 0x00A2C8D4 File Offset: 0x00A2AAD4
		// (set) Token: 0x0600AF42 RID: 44866 RVA: 0x00A2C98C File Offset: 0x00A2AB8C
		public bool DataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219_Applicable
		{
			get
			{
				short num = (short)1646690235;
				short num2 = num;
				num = (short)1775075259;
				switch (num2 == num)
				{
				default:
				{
					num = (short)143589376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1624637441;
				if (num != 0)
				{
				}
				num = (short)1614217216;
				if (num != 0)
				{
				}
				return this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.Applicable;
			}
			set
			{
				short num = (short)1813317250;
				short num2 = num;
				num = (short)321259138;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1070792704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1002504193;
				if (num != 0)
				{
				}
				num = (short)1950547968;
				if (num != 0)
				{
				}
				this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.Applicable = value;
			}
		}

		// Token: 0x170057F5 RID: 22517
		// (get) Token: 0x0600AF43 RID: 44867 RVA: 0x00A2CA44 File Offset: 0x00A2AC44
		// (set) Token: 0x0600AF44 RID: 44868 RVA: 0x00A2CAFC File Offset: 0x00A2ACFC
		public bool DataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219_Valid
		{
			get
			{
				short num = (short)125133394;
				short num2 = num;
				num = (short)957178450;
				switch (num2 == num)
				{
				default:
				{
					num = (short)541917184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1528627200;
				if (num != 0)
				{
				}
				num = (short)236257281;
				if (num != 0)
				{
				}
				return this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.Valid;
			}
			set
			{
				short num = (short)1857845223;
				short num2 = num;
				num = (short)1805416423;
				switch (num2 == num)
				{
				default:
				{
					num = (short)159186944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)139657217;
				if (num != 0)
				{
				}
				num = (short)1543241728;
				if (num != 0)
				{
				}
				this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.Valid = value;
			}
		}

		// Token: 0x170057F6 RID: 22518
		// (get) Token: 0x0600AF45 RID: 44869 RVA: 0x00A2CBB0 File Offset: 0x00A2ADB0
		// (set) Token: 0x0600AF46 RID: 44870 RVA: 0x00A2CC64 File Offset: 0x00A2AE64
		public bool DataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219_Visible
		{
			get
			{
				short num = (short)1102885592;
				short num2 = num;
				num = (short)615428824;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1629552640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1663107072;
				if (num != 0)
				{
				}
				num = (short)1309409281;
				if (num != 0)
				{
				}
				return this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.Visible;
			}
			set
			{
				short num = (short)376015905;
				short num2 = num;
				num = (short)1553894433;
				switch (num2 == num)
				{
				default:
				{
					num = (short)209387520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)92602369;
				if (num != 0)
				{
				}
				num = (short)968818688;
				if (num != 0)
				{
				}
				this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.Visible = value;
			}
		}

		// Token: 0x170057F7 RID: 22519
		// (get) Token: 0x0600AF47 RID: 44871 RVA: 0x00A2CD18 File Offset: 0x00A2AF18
		// (set) Token: 0x0600AF48 RID: 44872 RVA: 0x00A2CDCC File Offset: 0x00A2AFCC
		public bool DataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219_Editable
		{
			get
			{
				short num = (short)1787422094;
				short num2 = num;
				num = (short)1781065102;
				switch (num2 == num)
				{
				default:
				{
					num = (short)543948800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2000945153;
				if (num != 0)
				{
				}
				num = (short)1467744256;
				if (num != 0)
				{
				}
				return this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.Editable;
			}
			set
			{
				short num = (short)1039728641;
				if (num != 0)
				{
				}
				num = (short)1494548480;
				short num2 = num;
				num = (short)1479253050;
				short num3 = num;
				num = (short)564501562;
				switch (num3 == num)
				{
				}
				num = (short)58851328;
				if (num != 0)
				{
				}
				this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.Editable = value;
			}
		}

		// Token: 0x170057F8 RID: 22520
		// (get) Token: 0x0600AF49 RID: 44873 RVA: 0x00A2CE80 File Offset: 0x00A2B080
		internal string DataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219_UILabel
		{
			get
			{
				short num = (short)1943846373;
				short num2 = num;
				num = (short)52280805;
				switch (num2 == num)
				{
				}
				num = (short)1357053953;
				if (num != 0)
				{
				}
				num = (short)1124270080;
				if (num != 0)
				{
				}
				num = (short)1006960640;
				short num3 = num;
				return this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.UIName;
			}
		}

		// Token: 0x170057F9 RID: 22521
		// (get) Token: 0x0600AF4A RID: 44874 RVA: 0x00A2CF34 File Offset: 0x00A2B134
		// (set) Token: 0x0600AF4B RID: 44875 RVA: 0x00A2CFE8 File Offset: 0x00A2B1E8
		internal bool DataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219_HiddenStatic
		{
			get
			{
				short num = (short)273416193;
				if (num != 0)
				{
				}
				num = (short)1402047837;
				short num2 = num;
				num = (short)46435677;
				switch (num2 == num)
				{
				}
				num = (short)466550784;
				if (num != 0)
				{
				}
				num = (short)614072320;
				short num3 = num;
				return this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.HiddenStatic;
			}
			set
			{
				short num = (short)988210849;
				short num2 = num;
				num = (short)503441057;
				switch (num2 == num)
				{
				}
				num = (short)654901249;
				if (num != 0)
				{
				}
				num = (short)1211891712;
				if (num != 0)
				{
				}
				num = (short)843513856;
				short num3 = num;
				this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.HiddenStatic = value;
			}
		}

		// Token: 0x170057FA RID: 22522
		// (get) Token: 0x0600AF4C RID: 44876 RVA: 0x00A2D09C File Offset: 0x00A2B29C
		// (set) Token: 0x0600AF4D RID: 44877 RVA: 0x00A2D158 File Offset: 0x00A2B358
		internal bool DataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219_HiddenDynamic
		{
			get
			{
				short num = (short)327272818;
				short num2 = num;
				num = (short)1168296306;
				switch (num2 == num)
				{
				}
				num = (short)297861121;
				if (num != 0)
				{
				}
				num = (short)1617887232;
				if (num != 0)
				{
				}
				num = (short)418643968;
				short num3 = num;
				return this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.HiddenDynamic;
			}
			set
			{
				short num = (short)120565037;
				short num2 = num;
				num = (short)1689038125;
				switch (num2 == num)
				{
				}
				num = (short)1660616705;
				if (num != 0)
				{
				}
				num = (short)1387200512;
				if (num != 0)
				{
				}
				num = (short)1140785152;
				short num3 = num;
				this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.HiddenDynamic = value;
			}
		}

		// Token: 0x170057FB RID: 22523
		// (get) Token: 0x0600AF4E RID: 44878 RVA: 0x00A2D20C File Offset: 0x00A2B40C
		public bool DataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219_HasDiffs
		{
			get
			{
				short num = (short)1850483546;
				short num2 = num;
				num = (short)2137334618;
				switch (num2 == num)
				{
				}
				num = (short)879230977;
				if (num != 0)
				{
				}
				num = (short)213319680;
				if (num != 0)
				{
				}
				num = (short)1674969088;
				short num3 = num;
				return this.dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219._HasDiffs;
			}
		}

		// Token: 0x170057FC RID: 22524
		// (get) Token: 0x0600AF4F RID: 44879 RVA: 0x00A2D2C4 File Offset: 0x00A2B4C4
		// (set) Token: 0x0600AF50 RID: 44880 RVA: 0x00A2D378 File Offset: 0x00A2B578
		public int DataProfLabtoolTrk25EIDBypassListItemID_A36423Value
		{
			get
			{
				short num = (short)1639645185;
				if (num != 0)
				{
				}
				num = (short)1041250030;
				short num2 = num;
				num = (short)41301742;
				switch (num2 == num)
				{
				}
				num = (short)231342080;
				if (num != 0)
				{
				}
				num = (short)397606912;
				short num3 = num;
				return this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.Value;
			}
			set
			{
				short num = (short)1196427539;
				short num2 = num;
				num = (short)1956841747;
				switch (num2 == num)
				{
				}
				num = (short)815136769;
				if (num != 0)
				{
				}
				num = (short)652541952;
				if (num != 0)
				{
				}
				num = (short)417792000;
				short num3 = num;
				this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.Value = value;
			}
		}

		// Token: 0x170057FD RID: 22525
		// (get) Token: 0x0600AF51 RID: 44881 RVA: 0x00A2D430 File Offset: 0x00A2B630
		// (set) Token: 0x0600AF52 RID: 44882 RVA: 0x00A2D4E4 File Offset: 0x00A2B6E4
		public string DataProfLabtoolTrk25EIDBypassListItemID_A36423_UIValue
		{
			get
			{
				short num = (short)1381040378;
				short num2 = num;
				num = (short)658243834;
				switch (num2 == num)
				{
				}
				num = (short)956039169;
				if (num != 0)
				{
				}
				num = (short)1883242496;
				if (num != 0)
				{
				}
				num = (short)1706164224;
				short num3 = num;
				return this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.UIValue;
			}
			set
			{
				short num = (short)1567367576;
				short num2 = num;
				num = (short)1465262488;
				switch (num2 == num)
				{
				}
				num = (short)465698817;
				if (num != 0)
				{
				}
				num = (short)1241317376;
				if (num != 0)
				{
				}
				num = (short)1673986048;
				short num3 = num;
				this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.UIValue = value;
			}
		}

		// Token: 0x170057FE RID: 22526
		// (get) Token: 0x0600AF53 RID: 44883 RVA: 0x00A2D598 File Offset: 0x00A2B798
		public global::AcpBusinessLayer.AcpRecRefField DataProfLabtoolTrk25EIDBypassListItemID_A36423
		{
			get
			{
				short num = (short)1062993921;
				if (num != 0)
				{
				}
				num = (short)1376844423;
				short num2 = num;
				num = (short)506395271;
				switch (num2 == num)
				{
				}
				num = (short)651493376;
				if (num != 0)
				{
				}
				num = (short)570556416;
				short num3 = num;
				return this.dataProfLabtoolTrk25EIDBypassListItemID_A36423;
			}
		}

		// Token: 0x170057FF RID: 22527
		// (get) Token: 0x0600AF54 RID: 44884 RVA: 0x00A2D648 File Offset: 0x00A2B848
		// (set) Token: 0x0600AF55 RID: 44885 RVA: 0x00A2D700 File Offset: 0x00A2B900
		public bool DataProfLabtoolTrk25EIDBypassListItemID_A36423_Applicable
		{
			get
			{
				short num = (short)98387529;
				short num2 = num;
				num = (short)1017333321;
				switch (num2 == num)
				{
				}
				num = (short)1905262592;
				if (num != 0)
				{
				}
				num = (short)1434320897;
				if (num != 0)
				{
				}
				num = (short)561315840;
				short num3 = num;
				return this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.Applicable;
			}
			set
			{
				short num = (short)213173703;
				short num2 = num;
				num = (short)317441479;
				switch (num2 == num)
				{
				}
				num = (short)1373437953;
				if (num != 0)
				{
				}
				num = (short)660733952;
				if (num != 0)
				{
				}
				num = (short)1659895808;
				short num3 = num;
				this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.Applicable = value;
			}
		}

		// Token: 0x17005800 RID: 22528
		// (get) Token: 0x0600AF56 RID: 44886 RVA: 0x00A2D7B4 File Offset: 0x00A2B9B4
		// (set) Token: 0x0600AF57 RID: 44887 RVA: 0x00A2D868 File Offset: 0x00A2BA68
		public bool DataProfLabtoolTrk25EIDBypassListItemID_A36423_Valid
		{
			get
			{
				short num = (short)279445505;
				if (num != 0)
				{
				}
				num = (short)866243518;
				short num2 = num;
				num = (short)959763390;
				switch (num2 == num)
				{
				}
				num = (short)578617344;
				if (num != 0)
				{
				}
				num = (short)1193279488;
				short num3 = num;
				return this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.Valid;
			}
			set
			{
				short num = (short)1306922538;
				short num2 = num;
				num = (short)1810632234;
				switch (num2 == num)
				{
				}
				num = (short)730333184;
				if (num != 0)
				{
				}
				num = (short)88735745;
				if (num != 0)
				{
				}
				num = (short)271515648;
				short num3 = num;
				this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.Valid = value;
			}
		}

		// Token: 0x17005801 RID: 22529
		// (get) Token: 0x0600AF58 RID: 44888 RVA: 0x00A2D91C File Offset: 0x00A2BB1C
		// (set) Token: 0x0600AF59 RID: 44889 RVA: 0x00A2D9D0 File Offset: 0x00A2BBD0
		public bool DataProfLabtoolTrk25EIDBypassListItemID_A36423_Visible
		{
			get
			{
				short num = (short)1310523393;
				if (num != 0)
				{
				}
				num = (short)1148649340;
				short num2 = num;
				num = (short)460783484;
				switch (num2 == num)
				{
				}
				num = (short)1046216704;
				if (num != 0)
				{
				}
				num = (short)565510144;
				short num3 = num;
				return this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.Visible;
			}
			set
			{
				short num = (short)1640300545;
				if (num != 0)
				{
				}
				num = (short)1034502612;
				short num2 = num;
				num = (short)1637106132;
				switch (num2 == num)
				{
				}
				num = (short)2133917696;
				if (num != 0)
				{
				}
				num = (short)530513920;
				short num3 = num;
				this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.Visible = value;
			}
		}

		// Token: 0x17005802 RID: 22530
		// (get) Token: 0x0600AF5A RID: 44890 RVA: 0x00A2DA88 File Offset: 0x00A2BC88
		// (set) Token: 0x0600AF5B RID: 44891 RVA: 0x00A2DB40 File Offset: 0x00A2BD40
		public bool DataProfLabtoolTrk25EIDBypassListItemID_A36423_Editable
		{
			get
			{
				short num = (short)1388530607;
				short num2 = num;
				num = (short)121981871;
				switch (num2 == num)
				{
				}
				num = (short)512950272;
				if (num != 0)
				{
				}
				num = (short)713883649;
				if (num != 0)
				{
				}
				num = (short)1934163968;
				short num3 = num;
				return this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.Editable;
			}
			set
			{
				short num = (short)593035265;
				if (num != 0)
				{
				}
				num = (short)2030000585;
				short num2 = num;
				num = (short)825448905;
				switch (num2 == num)
				{
				}
				num = (short)222822400;
				if (num != 0)
				{
				}
				num = (short)114360320;
				short num3 = num;
				this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.Editable = value;
			}
		}

		// Token: 0x17005803 RID: 22531
		// (get) Token: 0x0600AF5C RID: 44892 RVA: 0x00A2DBF4 File Offset: 0x00A2BDF4
		internal string DataProfLabtoolTrk25EIDBypassListItemID_A36423_UILabel
		{
			get
			{
				short num = (short)1242824705;
				if (num != 0)
				{
				}
				num = (short)2085957890;
				short num2 = num;
				num = (short)1589326082;
				switch (num2 == num)
				{
				}
				num = (short)1606287360;
				if (num != 0)
				{
				}
				num = (short)1851195392;
				short num3 = num;
				return this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.UIName;
			}
		}

		// Token: 0x17005804 RID: 22532
		// (get) Token: 0x0600AF5D RID: 44893 RVA: 0x00A2DCA8 File Offset: 0x00A2BEA8
		// (set) Token: 0x0600AF5E RID: 44894 RVA: 0x00A2DD60 File Offset: 0x00A2BF60
		internal bool DataProfLabtoolTrk25EIDBypassListItemID_A36423_HiddenStatic
		{
			get
			{
				short num = (short)911519776;
				short num2 = num;
				num = (short)1571991584;
				switch (num2 == num)
				{
				}
				num = (short)658046977;
				if (num != 0)
				{
				}
				num = (short)2088042496;
				if (num != 0)
				{
				}
				num = (short)1172111360;
				short num3 = num;
				return this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.HiddenStatic;
			}
			set
			{
				short num = (short)1032352504;
				short num2 = num;
				num = (short)1925739256;
				switch (num2 == num)
				{
				}
				num = (short)89980929;
				if (num != 0)
				{
				}
				num = (short)908984320;
				if (num != 0)
				{
				}
				num = (short)1856700416;
				short num3 = num;
				this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.HiddenStatic = value;
			}
		}

		// Token: 0x17005805 RID: 22533
		// (get) Token: 0x0600AF5F RID: 44895 RVA: 0x00A2DE18 File Offset: 0x00A2C018
		// (set) Token: 0x0600AF60 RID: 44896 RVA: 0x00A2DECC File Offset: 0x00A2C0CC
		internal bool DataProfLabtoolTrk25EIDBypassListItemID_A36423_HiddenDynamic
		{
			get
			{
				short num = (short)1597892348;
				short num2 = num;
				num = (short)235005692;
				switch (num2 == num)
				{
				}
				num = (short)1017446401;
				if (num != 0)
				{
				}
				num = (short)441843712;
				if (num != 0)
				{
				}
				num = (short)214958080;
				short num3 = num;
				return this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.HiddenDynamic;
			}
			set
			{
				short num = (short)1601372161;
				if (num != 0)
				{
				}
				num = (short)1497680349;
				short num2 = num;
				num = (short)92326365;
				switch (num2 == num)
				{
				}
				num = (short)1907097600;
				if (num != 0)
				{
				}
				num = (short)1069875200;
				short num3 = num;
				this.dataProfLabtoolTrk25EIDBypassListItemID_A36423.HiddenDynamic = value;
			}
		}

		// Token: 0x17005806 RID: 22534
		// (get) Token: 0x0600AF61 RID: 44897 RVA: 0x00A2DF80 File Offset: 0x00A2C180
		public bool DataProfLabtoolTrk25EIDBypassListItemID_A36423_HasDiffs
		{
			get
			{
				short num = (short)1728446465;
				if (num != 0)
				{
				}
				num = (short)2119595556;
				short num2 = num;
				num = (short)1535604260;
				switch (num2 == num)
				{
				}
				num = (short)2048393216;
				if (num != 0)
				{
				}
				num = (short)2105475072;
				short num3 = num;
				return this.dataProfLabtoolTrk25EIDBypassListItemID_A36423._HasDiffs;
			}
		}

		// Token: 0x0600AF62 RID: 44898 RVA: 0x00A2E034 File Offset: 0x00A2C234
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1014890497;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_32:
				switch (num2)
				{
				case 0:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1428750340;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (base.ParentRecset != null)
					{
						num = (short)1651310595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_117;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1844772864;
						short num3 = num;
						num = (short)595787776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_117;
				case 3:
					num = (short)640024578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_AC;
				}
				goto IL_4C;
			}
			IL_AC:
			IL_117:
			num = (short)409941447;
			short num4 = num;
			num = (short)159659463;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_AC;
			default:
				num = (short)210698240;
				if (num != 0)
				{
				}
				return result;
			}
			IL_4C:
			result = null;
			num = (short)1977483265;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x040053DA RID: 21466
		private global::AcpBusinessLayer.AcpSimpleRangeField dataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475;

		// Token: 0x040053DB RID: 21467
		private global::AcpBusinessLayer.AcpListField dataProfLabtoolDATA_PROFDataDeliveryMode_A11468;

		// Token: 0x040053DC RID: 21468
		private global::AcpBusinessLayer.AcpSimpleRangeField dataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991;

		// Token: 0x040053DD RID: 21469
		private global::AcpBusinessLayer.AcpRecRefField dataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218;

		// Token: 0x040053DE RID: 21470
		private global::AcpBusinessLayer.AcpRecRefField dataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219;

		// Token: 0x040053DF RID: 21471
		private global::AcpBusinessLayer.AcpRecRefField dataProfLabtoolTrk25EIDBypassListItemID_A36423;
	}
}
