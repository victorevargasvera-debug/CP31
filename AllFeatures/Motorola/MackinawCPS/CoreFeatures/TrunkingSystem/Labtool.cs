using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x02000096 RID: 150
	[global::System.Serializable]
	public class Labtool : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600109B RID: 4251 RVA: 0x00102910 File Offset: 0x00100B10
		public Labtool(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x0010292C File Offset: 0x00100B2C
		protected Labtool(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x00102944 File Offset: 0x00100B44
		public override void Init()
		{
			int a_ = 7;
			short num = (short)5873856;
			short num2 = num;
			num = (short)536125632;
			switch (num2 == num)
			{
			}
			num = (short)689700864;
			if (num != 0)
			{
			}
			num = (short)1561460736;
			short num3 = num;
			num = (short)1580990465;
			if (num != 0)
			{
			}
			this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ飓럕뫗껙돛뇝賟뛡難鏥蛧臩藫胭韯ꇱ跳藵賷鿹釻뷽濿氁瀃琅朇昉伋昍焏簑稓猕琗嘙甛洝吟次倣䌥䔧挩栫焭焯̱ള༵ืู", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMCONTROLCHANNELLISTITEMID, null, null, true, false);
			this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.DataTransferOrder = -1;
			this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ飓럕뫗껙돛뇝賟뛡難鏥蛧臩藫胭韯ꇱ跳藵賷鿹釻뿽僿䄁䬃䔅怇欉戋怍甏縑崓爕紗琙栛眝䘟䬡䄣吥搧䌩弫娭礯䘱儳嬵焷縹挻缽焿筁絃灅絇", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMAPCOCHANNELIDENTIFIERLISTITEMID, null, null, true, false);
			this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.DataTransferOrder = -1;
			this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ飓럕뫗껙돛뇝賟뛡難鏥蛧臩藫胭韯ꇱ跳藵賷鿹釻럽䧿䴁䘃刅䬇戉洋怍縏眑砓圕欗椙甛礝丟伡䄣䠥尧昩䔫崭䐯笱䀳匵唷猹砻愽Ŀ獁絃罅繇籉", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMIIOBTCHANNELASSIGNMENTLISTITEMID, null, null, true, false);
			this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.DataTransferOrder = -1;
			this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ飓럕뫗껙돛뇝賟뛡難鏥蛧臩藫胭韯ꇱ跳藵賷鿹釻귽瓿持瀃猅笇䬉怋服焏愑堓缕欗渙唛樝䔟伡洣戥眧欩ᴫᜭयб̳", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMSTATUSALIASLISTITEMID, null, null, true, false);
			this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.DataTransferOrder = -1;
			this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ飓럕뫗껙돛뇝賟뛡難鏥蛧臩藫胭韯ꇱ跳藵賷鿹釻귽瓿持瀃猅笇䬉怋服焏愑䀓猕怗渙倛眝匟嘡洣別䴧䜩攫樭漯猱Գ༵ķహл", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMSTATUSALIASTEXTLISTITEMID, null, null, true, false);
			this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.DataTransferOrder = -1;
			this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ飓럕뫗껙돛뇝賟뛡難鏥蛧臩藫胭韯ꇱ跳藵賷鿹釻돽旿焁眃朅漇漉䴋戍礏猑朓娕焗椙栛圝吟䜡䤣漥氧甩洫Ἥय଱ȳ༵", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMMESSAGEALIASLISTITEMID, null, null, true, false);
			this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.DataTransferOrder = -1;
			this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ飓럕뫗껙돛뇝賟뛡難鏥蛧臩藫胭韯ꇱ跳藵賷鿹釻돽旿焁眃朅漇漉䴋戍礏猑朓䈕紗戙栛初䤟儡倣漥尧伩䄫札琯洱申ܵķ̹଻฽", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMMESSAGEALIASTEXTLISTITEMID, null, null, true, false);
			this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.DataTransferOrder = -1;
			this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ飓럕뫗껙돛뇝賟뛡難鏥蛧臩藫胭韯ꇱ跳藵賷鿹釻귽槿瘁愃䜅搇按洋納小笑朓戕儗渙礛猝椟昡笣朥ᤧጩᔫ᤭į", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMSITEALIASLISTITEMID, null, null, true, false);
			this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.DataTransferOrder = -1;
			this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ飓럕뫗껙돛뇝賟뛡難鏥蛧臩藫胭韯ꇱ跳藵賷鿹釻귽槿瘁愃䜅搇按洋納䐏眑氓戕吗猙漛樝椟嘡䄣䬥愧温猫漭į଱ളĵ਷", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMSITEALIASTEXTLISTITEMID, null, null, true, false);
			this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.DataTransferOrder = -1;
			this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ鷍ꧏꇑ飓럕뫗껙돛뇝賟뛡難鏥蛧臩藫胭韯ꇱ跳藵賷鿹釻뇽滿朁倃椅紇椉搋䈍礏愑怓引気缙焛圝搟紡攣ᐥᨧᰩἫᴭ", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMONETOUCHLISTITEMNAMEID, null, null, true, false);
			this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓇ꯉ껋뫍뿏뷑룓", a_);
			base.Id = 10156;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 14;
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00102C78 File Offset: 0x00100E78
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 11;
			short num = (short)1093468162;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_4B9;
				case 1:
					num = (short)191627265;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ铗믙뻛ꫝ迟跡裣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿儁瀃朅簇缉缋伍簏笑甓攕䰗缙搛樝氟䬡圣別愧帩䤫䌭礯瘱欳眵ष̹Ի࠽砿", a_)))
					{
						num = (short)1322385413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_135;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_B6;
					}
					continue;
				case 3:
					goto IL_4B4;
				case 4:
					goto IL_225;
				case 5:
					this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ铗믙뻛ꫝ迟跡裣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿儁瀃朅簇缉缋伍簏笑甓攕䰗缙搛樝氟䬡圣別愧帩䤫䌭礯瘱欳眵ष̹Ի࠽砿", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMSTATUSALIASTEXTLISTITEMID, null, null, true, false);
					this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.DataTransferOrder = -1;
					num = (short)2097283093;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ铗믙뻛ꫝ迟跡裣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿儁洃爅洇䬉怋服焏愑堓缕欗渙唛樝䔟伡洣戥眧欩ᴫᜭयԱԳ", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMSITEALIASLISTITEMID, null, null, true, false);
					this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.DataTransferOrder = -1;
					num = (short)1197080580;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ铗믙뻛ꫝ迟跡裣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿企愃甅笇欉欋欍儏縑紓眕欗嘙甛洝吟次倣䌥䔧挩栫焭焯̱ള༵ื̹", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMMESSAGEALIASLISTITEMID, null, null, true, false);
					this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.DataTransferOrder = -1;
					num = (short)122028046;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_569;
				case 9:
					num = (short)1224278035;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ铗믙뻛ꫝ迟跡裣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿企愃甅笇欉欋欍儏縑紓眕欗丙礛昝吟渡䴣唥尧挩堫䬭崯笱瀳椵礷ହԻܽ眿牁", a_)))
					{
						num = (short)2037645323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C9;
				case 11:
					this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ铗믙뻛ꫝ迟跡裣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿企愃甅笇欉欋欍儏縑紓眕欗丙礛昝吟渡䴣唥尧挩堫䬭崯笱瀳椵礷ହԻܽ眿牁", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMMESSAGEALIASTEXTLISTITEMID, null, null, true, false);
					this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.DataTransferOrder = -1;
					num = (short)2032992279;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ铗믙뻛ꫝ迟跡裣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿儁瀃朅簇缉缋伍簏笑甓攕吗猙漛樝椟嘡䄣䬥愧温猫漭į଱ള5༷", a_)))
					{
						num = (short)1757675551;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_708;
				case 13:
					goto IL_708;
				case 14:
					goto IL_6BB;
				case 15:
					goto IL_318;
				case 16:
				{
					num = (short)1651311830;
					short num3 = num;
					num = (short)1342899414;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3EC;
					default:
						num = (short)644153344;
						if (num != 0)
						{
						}
						this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ铗믙뻛ꫝ迟跡裣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿䌁吃䔅䜇䤉搋漍縏簑焓稕儗縙礛瀝吟䬡䈣伥䴧堩怫䜭䌯䘱紳䈵崷圹画稽Ἷ́畃罅煇籉祋", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMAPCOCHANNELIDENTIFIERLISTITEMID, null, null, true, false);
						this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.DataTransferOrder = -1;
						num = (short)942669856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ铗믙뻛ꫝ迟跡裣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿䬁䴃䤅䨇帉伋昍焏簑稓猕琗嬙漛洝䤟䔡䨣䬥䴧䐩堫戭夯䄱䀳缵䰷弹儻眽пᵁՃ睅煇獉穋硍", a_)))
					{
						goto IL_3EC;
					}
					goto IL_4B9;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ铗믙뻛ꫝ迟跡裣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿䄁欃栅簇砉挋戍匏稑甓砕瘗缙瀛初䤟儡倣漥尧伩䄫札琯洱申ܵķ̹਻਽", a_)))
					{
						num = (short)1374879777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_569;
				case 19:
					if (producerFields != null)
					{
						num = (short)2136604700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_821;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ铗믙뻛ꫝ迟跡裣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿儁洃爅洇䬉怋服焏愑堓缕欗渙唛樝䔟伡洣戥眧欩ᴫᜭयԱԳ", a_)))
					{
						num = (short)889454598;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_225;
				case 21:
					goto IL_135;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ铗믙뻛ꫝ迟跡裣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿䴁樃挅將攉礋洍砏帑紓攕気匙栛笝䴟次怣礥椧ᠩḫᠭ̯ı", a_)))
					{
						num = (short)134610970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_821;
				case 23:
					goto IL_2C9;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ铗믙뻛ꫝ迟跡裣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿儁洃爅洇䬉怋服焏愑䀓猕怗渙倛眝匟嘡洣別䴧䜩攫樭漯猱Գ༵ķഹ฻", a_)))
					{
						num = (short)978780187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_318;
				case 25:
					this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ铗믙뻛ꫝ迟跡裣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿䬁䴃䤅䨇帉伋昍焏簑稓猕琗嬙漛洝䤟䔡䨣䬥䴧䐩堫戭夯䄱䀳缵䰷弹儻眽пᵁՃ睅煇獉穋硍", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMIIOBTCHANNELASSIGNMENTLISTITEMID, null, null, true, false);
					this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.DataTransferOrder = -1;
					num = (short)651886592;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ铗믙뻛ꫝ迟跡裣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿䴁樃挅將攉礋洍砏帑紓攕気匙栛笝䴟次怣礥椧ᠩḫᠭ̯ı", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMONETOUCHLISTITEMNAMEID, null, null, true, false);
					this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.DataTransferOrder = -1;
					num = (short)821493763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ铗믙뻛ꫝ迟跡裣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿儁洃爅洇䬉怋服焏愑䀓猕怗渙倛眝匟嘡洣別䴧䜩攫樭漯猱Գ༵ķഹ฻", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMSITEALIASTEXTLISTITEMID, null, null, true, false);
					this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.DataTransferOrder = -1;
					num = (short)685047823;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					num = (short)1658781714;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ铗믙뻛ꫝ迟跡裣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿企愃甅笇欉欋欍儏縑紓眕欗嘙甛洝吟次倣䌥䔧挩栫焭焯̱ള༵ื̹", a_)))
					{
						num = (short)469565447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6BB;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ铗믙뻛ꫝ迟跡裣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿䌁吃䔅䜇䤉搋漍縏簑焓稕儗縙礛瀝吟䬡䈣伥䴧堩怫䜭䌯䘱紳䈵崷圹画稽Ἷ́畃罅煇籉祋", a_)))
					{
						num = (short)1822490640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3BC;
				case 31:
				{
					num = (short)1589903360;
					short num4 = num;
					this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ铗믙뻛ꫝ迟跡裣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿儁瀃朅簇缉缋伍簏笑甓攕吗猙漛樝椟嘡䄣䬥愧温猫漭į଱ള5༷", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMSTATUSALIASLISTITEMID, null, null, true, false);
					this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.DataTransferOrder = -1;
					num = (short)1657536525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 32:
					goto IL_3BC;
				case 33:
					this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("飋볍믏臑귓ꗕ铗믙뻛ꫝ迟跡裣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿䄁欃栅簇砉挋戍匏稑甓砕瘗缙瀛初䤟儡倣漥尧伩䄫札琯洱申ܵķ̹਻਽", a_), global::CommonResources.AcgResources.ID_TRUNKINGSYSTEMCONTROLCHANNELLISTITEMID, null, null, true, false);
					this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.DataTransferOrder = -1;
					num = (short)519503880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B6:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)208470025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_135:
				num = (short)662634525;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_225:
				num = (short)1002766360;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C9:
				num = (short)22675476;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_318:
				num = (short)2038956054;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3BC:
				num = (short)144900113;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3EC:
				num = (short)1865416729;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4B9:
				num = (short)62062604;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_569:
				num = (short)951517214;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6BB:
				num = (short)1892089866;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_708:
				num = (short)2027749377;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4B4:
			IL_821:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胋꿍닏ꛑ믓맕듗", a_);
			base.Id = 10156;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 14;
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x001034D8 File Offset: 0x001016D8
		public override void PopulateReferences()
		{
			short num = (short)383957656;
			short num2 = num;
			num = (short)1841347224;
			switch (num2 == num)
			{
			}
			num = (short)1985609729;
			if (num != 0)
			{
			}
			num = (short)1895497728;
			if (num != 0)
			{
			}
			num = (short)1266286592;
			short num3 = num;
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x00103584 File Offset: 0x00101784
		public override void DropReferences()
		{
			short num = (short)1003477078;
			short num2 = num;
			num = (short)1548474454;
			switch (num2 == num)
			{
			}
			num = (short)1128792064;
			if (num != 0)
			{
			}
			num = (short)1998323713;
			if (num != 0)
			{
			}
			num = (short)1729101824;
			short num3 = num;
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x00103630 File Offset: 0x00101830
		public override void SetConstraints()
		{
			short num = (short)566667443;
			short num2 = num;
			num = (short)52471987;
			switch (num2 == num)
			{
			}
			num = (short)1020329985;
			if (num != 0)
			{
			}
			num = (short)293273600;
			if (num != 0)
			{
			}
			num = (short)714866688;
			short num3 = num;
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x001036DC File Offset: 0x001018DC
		public override void SetupDependencies()
		{
			short num = (short)196628931;
			short num2 = num;
			num = (short)1519079875;
			switch (num2 == num)
			{
			}
			num = (short)1638072321;
			if (num != 0)
			{
			}
			num = (short)1832583168;
			if (num != 0)
			{
			}
			num = (short)232128512;
			short num3 = num;
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x060010A3 RID: 4259 RVA: 0x00103784 File Offset: 0x00101984
		public bool HasDiffs
		{
			get
			{
				short num = (short)1176804096;
				short num2 = num;
				num = (short)36674304;
				switch (num2 == num)
				{
				}
				num = (short)1864826880;
				if (num != 0)
				{
				}
				num = (short)1689059329;
				if (num != 0)
				{
				}
				num = (short)1370423296;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x060010A4 RID: 4260 RVA: 0x00103834 File Offset: 0x00101A34
		// (set) Token: 0x060010A5 RID: 4261 RVA: 0x001038EC File Offset: 0x00101AEC
		public int TrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964Value
		{
			get
			{
				short num = (short)839998301;
				short num2 = num;
				num = (short)542464861;
				switch (num2 == num)
				{
				}
				num = (short)128843777;
				if (num != 0)
				{
				}
				num = (short)553910272;
				if (num != 0)
				{
				}
				num = (short)685965312;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.Value;
			}
			set
			{
				short num = (short)589086955;
				short num2 = num;
				num = (short)527155435;
				switch (num2 == num)
				{
				}
				num = (short)1016004609;
				if (num != 0)
				{
				}
				num = (short)1813184512;
				if (num != 0)
				{
				}
				num = (short)1997275136;
				short num3 = num;
				this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.Value = value;
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x001039A4 File Offset: 0x00101BA4
		// (set) Token: 0x060010A7 RID: 4263 RVA: 0x00103A58 File Offset: 0x00101C58
		public string TrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964_UIValue
		{
			get
			{
				short num = (short)508706687;
				short num2 = num;
				num = (short)952319871;
				switch (num2 == num)
				{
				}
				num = (short)489422849;
				if (num != 0)
				{
				}
				num = (short)1702100992;
				if (num != 0)
				{
				}
				num = (short)869728256;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.UIValue;
			}
			set
			{
				short num = (short)839116321;
				short num2 = num;
				num = (short)1176954401;
				switch (num2 == num)
				{
				}
				num = (short)31719425;
				if (num != 0)
				{
				}
				num = (short)2085355520;
				if (num != 0)
				{
				}
				num = (short)433586176;
				short num3 = num;
				this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.UIValue = value;
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x060010A8 RID: 4264 RVA: 0x00103B10 File Offset: 0x00101D10
		public global::AcpBusinessLayer.AcpRecRefField TrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964
		{
			get
			{
				short num = (short)1501307099;
				short num2 = num;
				num = (short)1929191643;
				switch (num2 == num)
				{
				}
				num = (short)881590273;
				if (num != 0)
				{
				}
				num = (short)2009530368;
				if (num != 0)
				{
				}
				num = (short)1411121152;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x060010A9 RID: 4265 RVA: 0x00103BBC File Offset: 0x00101DBC
		// (set) Token: 0x060010AA RID: 4266 RVA: 0x00103C70 File Offset: 0x00101E70
		public bool TrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964_Applicable
		{
			get
			{
				short num = (short)1286542850;
				short num2 = num;
				num = (short)486413826;
				switch (num2 == num)
				{
				}
				num = (short)1246101505;
				if (num != 0)
				{
				}
				num = (short)461111296;
				if (num != 0)
				{
				}
				num = (short)164560896;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.Applicable;
			}
			set
			{
				short num = (short)706889571;
				short num2 = num;
				num = (short)1750746979;
				switch (num2 == num)
				{
				}
				num = (short)1044709377;
				if (num != 0)
				{
				}
				num = (short)1527840768;
				if (num != 0)
				{
				}
				num = (short)570359808;
				short num3 = num;
				this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.Applicable = value;
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x00103D28 File Offset: 0x00101F28
		// (set) Token: 0x060010AC RID: 4268 RVA: 0x00103DDC File Offset: 0x00101FDC
		public bool TrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964_Valid
		{
			get
			{
				short num = (short)156515970;
				short num2 = num;
				num = (short)441400962;
				switch (num2 == num)
				{
				}
				num = (short)571473921;
				if (num != 0)
				{
				}
				num = (short)212664320;
				if (num != 0)
				{
				}
				num = (short)721092608;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.Valid;
			}
			set
			{
				short num = (short)1745122100;
				short num2 = num;
				num = (short)742814516;
				switch (num2 == num)
				{
				}
				num = (short)1046872065;
				if (num != 0)
				{
				}
				num = (short)13172736;
				if (num != 0)
				{
				}
				num = (short)1591017472;
				short num3 = num;
				this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.Valid = value;
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x00103E94 File Offset: 0x00102094
		// (set) Token: 0x060010AE RID: 4270 RVA: 0x00103F48 File Offset: 0x00102148
		public bool TrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964_Visible
		{
			get
			{
				short num = (short)529056998;
				short num2 = num;
				num = (short)1075496166;
				switch (num2 == num)
				{
				}
				num = (short)14090241;
				if (num != 0)
				{
				}
				num = (short)458752;
				if (num != 0)
				{
				}
				num = (short)32899072;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.Visible;
			}
			set
			{
				short num = (short)202239729;
				short num2 = num;
				num = (short)2118905585;
				switch (num2 == num)
				{
				}
				num = (short)198049793;
				if (num != 0)
				{
				}
				num = (short)887226368;
				if (num != 0)
				{
				}
				num = (short)1701511168;
				short num3 = num;
				this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.Visible = value;
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x00103FFC File Offset: 0x001021FC
		// (set) Token: 0x060010B0 RID: 4272 RVA: 0x001040B0 File Offset: 0x001022B0
		public bool TrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964_Editable
		{
			get
			{
				short num = (short)1181705481;
				short num2 = num;
				num = (short)952395017;
				switch (num2 == num)
				{
				}
				num = (short)1608384512;
				if (num != 0)
				{
				}
				num = (short)1859452929;
				if (num != 0)
				{
				}
				num = (short)1850671104;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.Editable;
			}
			set
			{
				short num = (short)1125733441;
				short num2 = num;
				num = (short)1306612801;
				switch (num2 == num)
				{
				}
				num = (short)320208897;
				if (num != 0)
				{
				}
				num = (short)757661696;
				if (num != 0)
				{
				}
				num = (short)773718016;
				short num3 = num;
				this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.Editable = value;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x060010B1 RID: 4273 RVA: 0x0010416C File Offset: 0x0010236C
		internal string TrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964_UILabel
		{
			get
			{
				short num = (short)1222350621;
				short num2 = num;
				num = (short)1559402269;
				switch (num2 == num)
				{
				}
				num = (short)811859969;
				if (num != 0)
				{
				}
				num = (short)630849536;
				if (num != 0)
				{
				}
				num = (short)1746468864;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.UIName;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x060010B2 RID: 4274 RVA: 0x00104220 File Offset: 0x00102420
		// (set) Token: 0x060010B3 RID: 4275 RVA: 0x001042D8 File Offset: 0x001024D8
		internal bool TrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964_HiddenStatic
		{
			get
			{
				short num = (short)2097850825;
				short num2 = num;
				num = (short)1656400329;
				switch (num2 == num)
				{
				}
				num = (short)429981696;
				if (num != 0)
				{
				}
				num = (short)2048720897;
				if (num != 0)
				{
				}
				num = (short)322895872;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.HiddenStatic;
			}
			set
			{
				short num = (short)478216193;
				if (num != 0)
				{
				}
				num = (short)531369045;
				short num2 = num;
				num = (short)1248070741;
				switch (num2 == num)
				{
				}
				num = (short)2034761728;
				if (num != 0)
				{
				}
				num = (short)1035075584;
				short num3 = num;
				this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.HiddenStatic = value;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x0010438C File Offset: 0x0010258C
		// (set) Token: 0x060010B5 RID: 4277 RVA: 0x00104444 File Offset: 0x00102644
		internal bool TrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964_HiddenDynamic
		{
			get
			{
				short num = (short)1517944833;
				if (num != 0)
				{
				}
				num = (short)1563986046;
				short num2 = num;
				num = (short)487688318;
				switch (num2 == num)
				{
				}
				num = (short)1018036224;
				if (num != 0)
				{
				}
				num = (short)1157038080;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.HiddenDynamic;
			}
			set
			{
				short num = (short)325830815;
				short num2 = num;
				num = (short)1904658591;
				switch (num2 == num)
				{
				}
				num = (short)2116222977;
				if (num != 0)
				{
				}
				num = (short)1555431424;
				if (num != 0)
				{
				}
				num = (short)915144704;
				short num3 = num;
				this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.HiddenDynamic = value;
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x060010B6 RID: 4278 RVA: 0x001044FC File Offset: 0x001026FC
		public bool TrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964_HasDiffs
		{
			get
			{
				short num = (short)49871442;
				short num2 = num;
				num = (short)2097805906;
				switch (num2 == num)
				{
				}
				num = (short)1717436417;
				if (num != 0)
				{
				}
				num = (short)1660616704;
				if (num != 0)
				{
				}
				num = (short)1384775680;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964._HasDiffs;
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x001045B0 File Offset: 0x001027B0
		// (set) Token: 0x060010B8 RID: 4280 RVA: 0x00104668 File Offset: 0x00102868
		public int TrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965Value
		{
			get
			{
				short num = (short)68835078;
				short num2 = num;
				num = (short)1493915398;
				switch (num2 == num)
				{
				}
				num = (short)992673793;
				if (num != 0)
				{
				}
				num = (short)1941307392;
				if (num != 0)
				{
				}
				num = (short)1234173952;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.Value;
			}
			set
			{
				short num = (short)748726677;
				short num2 = num;
				num = (short)334735765;
				switch (num2 == num)
				{
				}
				num = (short)427884545;
				if (num != 0)
				{
				}
				num = (short)974848000;
				if (num != 0)
				{
				}
				num = (short)368377856;
				short num3 = num;
				this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.Value = value;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x0010471C File Offset: 0x0010291C
		// (set) Token: 0x060010BA RID: 4282 RVA: 0x001047D4 File Offset: 0x001029D4
		public string TrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965_UIValue
		{
			get
			{
				short num = (short)111529309;
				short num2 = num;
				num = (short)1673645405;
				switch (num2 == num)
				{
				}
				num = (short)1844379649;
				if (num != 0)
				{
				}
				num = (short)112525312;
				if (num != 0)
				{
				}
				num = (short)1375272960;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.UIValue;
			}
			set
			{
				short num = (short)759497738;
				short num2 = num;
				num = (short)777782282;
				switch (num2 == num)
				{
				}
				num = (short)1485897729;
				if (num != 0)
				{
				}
				num = (short)1224409088;
				if (num != 0)
				{
				}
				num = (short)304676864;
				short num3 = num;
				this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.UIValue = value;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x00104888 File Offset: 0x00102A88
		public global::AcpBusinessLayer.AcpRecRefField TrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965
		{
			get
			{
				short num = (short)350448764;
				short num2 = num;
				num = (short)247360636;
				switch (num2 == num)
				{
				}
				num = (short)1873018881;
				if (num != 0)
				{
				}
				num = (short)1843331072;
				if (num != 0)
				{
				}
				num = (short)1434320896;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x060010BC RID: 4284 RVA: 0x00104934 File Offset: 0x00102B34
		// (set) Token: 0x060010BD RID: 4285 RVA: 0x001049E4 File Offset: 0x00102BE4
		public bool TrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965_Applicable
		{
			get
			{
				short num = (short)420788099;
				short num2 = num;
				num = (short)331724675;
				switch (num2 == num)
				{
				}
				num = (short)1257373697;
				if (num != 0)
				{
				}
				num = (short)1595146240;
				if (num != 0)
				{
				}
				num = (short)430047232;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.Applicable;
			}
			set
			{
				short num = (short)1649195553;
				short num2 = num;
				num = (short)962116129;
				switch (num2 == num)
				{
				}
				num = (short)1804075009;
				if (num != 0)
				{
				}
				num = (short)958595072;
				if (num != 0)
				{
				}
				num = (short)1391198208;
				short num3 = num;
				this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.Applicable = value;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x060010BE RID: 4286 RVA: 0x00104A98 File Offset: 0x00102C98
		// (set) Token: 0x060010BF RID: 4287 RVA: 0x00104B50 File Offset: 0x00102D50
		public bool TrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965_Valid
		{
			get
			{
				short num = (short)1056823737;
				short num2 = num;
				num = (short)1016060345;
				switch (num2 == num)
				{
				}
				num = (short)341770240;
				if (num != 0)
				{
				}
				num = (short)645922817;
				if (num != 0)
				{
				}
				num = (short)910622720;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.Valid;
			}
			set
			{
				short num = (short)179186498;
				short num2 = num;
				num = (short)1351953218;
				switch (num2 == num)
				{
				}
				num = (short)858193921;
				if (num != 0)
				{
				}
				num = (short)1550647296;
				if (num != 0)
				{
				}
				num = (short)1547698176;
				short num3 = num;
				this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.Valid = value;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x060010C0 RID: 4288 RVA: 0x00104C04 File Offset: 0x00102E04
		// (set) Token: 0x060010C1 RID: 4289 RVA: 0x00104CBC File Offset: 0x00102EBC
		public bool TrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965_Visible
		{
			get
			{
				short num = (short)99279145;
				short num2 = num;
				num = (short)1784602921;
				switch (num2 == num)
				{
				}
				num = (short)412418049;
				if (num != 0)
				{
				}
				num = (short)347930624;
				if (num != 0)
				{
				}
				num = (short)1153826816;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.Visible;
			}
			set
			{
				short num = (short)1847307239;
				short num2 = num;
				num = (short)1137552359;
				switch (num2 == num)
				{
				}
				num = (short)1081278464;
				if (num != 0)
				{
				}
				num = (short)347144193;
				if (num != 0)
				{
				}
				num = (short)2069954560;
				short num3 = num;
				this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.Visible = value;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x060010C2 RID: 4290 RVA: 0x00104D74 File Offset: 0x00102F74
		// (set) Token: 0x060010C3 RID: 4291 RVA: 0x00104E24 File Offset: 0x00103024
		public bool TrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965_Editable
		{
			get
			{
				short num = (short)623465349;
				short num2 = num;
				num = (short)772166533;
				switch (num2 == num)
				{
				}
				num = (short)1075970048;
				if (num != 0)
				{
				}
				num = (short)1477836801;
				if (num != 0)
				{
				}
				num = (short)598278144;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.Editable;
			}
			set
			{
				short num = (short)84237276;
				short num2 = num;
				num = (short)968711132;
				switch (num2 == num)
				{
				}
				num = (short)1332936705;
				if (num != 0)
				{
				}
				num = (short)1617821696;
				if (num != 0)
				{
				}
				num = (short)918290432;
				short num3 = num;
				this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.Editable = value;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x00104ED8 File Offset: 0x001030D8
		internal string TrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965_UILabel
		{
			get
			{
				short num = (short)1427646936;
				short num2 = num;
				num = (short)447687128;
				switch (num2 == num)
				{
				}
				num = (short)1278607360;
				if (num != 0)
				{
				}
				num = (short)1630928897;
				if (num != 0)
				{
				}
				num = (short)1036189696;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.UIName;
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x060010C5 RID: 4293 RVA: 0x00104F8C File Offset: 0x0010318C
		// (set) Token: 0x060010C6 RID: 4294 RVA: 0x00105040 File Offset: 0x00103240
		internal bool TrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965_HiddenStatic
		{
			get
			{
				short num = (short)46272480;
				short num2 = num;
				num = (short)951062496;
				switch (num2 == num)
				{
				}
				num = (short)1551695873;
				if (num != 0)
				{
				}
				num = (short)1891762176;
				if (num != 0)
				{
				}
				num = (short)928710656;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.HiddenStatic;
			}
			set
			{
				short num = (short)993991714;
				short num2 = num;
				num = (short)188554274;
				switch (num2 == num)
				{
				}
				num = (short)1879638016;
				if (num != 0)
				{
				}
				num = (short)753664001;
				if (num != 0)
				{
				}
				num = (short)577634304;
				short num3 = num;
				this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.HiddenStatic = value;
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x001050F4 File Offset: 0x001032F4
		// (set) Token: 0x060010C8 RID: 4296 RVA: 0x001051A8 File Offset: 0x001033A8
		internal bool TrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965_HiddenDynamic
		{
			get
			{
				short num = (short)124433454;
				short num2 = num;
				num = (short)673625134;
				switch (num2 == num)
				{
				}
				num = (short)1038680065;
				if (num != 0)
				{
				}
				num = (short)511508480;
				if (num != 0)
				{
				}
				num = (short)1643118592;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.HiddenDynamic;
			}
			set
			{
				short num = (short)1505899343;
				short num2 = num;
				num = (short)1141846863;
				switch (num2 == num)
				{
				}
				num = (short)1228603393;
				if (num != 0)
				{
				}
				num = (short)1356857344;
				if (num != 0)
				{
				}
				num = (short)323813376;
				short num3 = num;
				this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.HiddenDynamic = value;
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x060010C9 RID: 4297 RVA: 0x00105260 File Offset: 0x00103460
		public bool TrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965_HasDiffs
		{
			get
			{
				short num = (short)1361253656;
				short num2 = num;
				num = (short)442373400;
				switch (num2 == num)
				{
				}
				num = (short)709689345;
				if (num != 0)
				{
				}
				num = (short)228130816;
				if (num != 0)
				{
				}
				num = (short)1563426816;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965._HasDiffs;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x060010CA RID: 4298 RVA: 0x00105314 File Offset: 0x00103514
		// (set) Token: 0x060010CB RID: 4299 RVA: 0x001053C8 File Offset: 0x001035C8
		public int TrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966Value
		{
			get
			{
				short num = (short)465365516;
				short num2 = num;
				num = (short)1700325900;
				switch (num2 == num)
				{
				}
				num = (short)1555365888;
				if (num != 0)
				{
				}
				num = (short)1727594497;
				if (num != 0)
				{
				}
				num = (short)344522752;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.Value;
			}
			set
			{
				short num = (short)1859480190;
				short num2 = num;
				num = (short)154757758;
				switch (num2 == num)
				{
				}
				num = (short)472580096;
				if (num != 0)
				{
				}
				num = (short)191954945;
				if (num != 0)
				{
				}
				num = (short)759103488;
				short num3 = num;
				this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.Value = value;
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x060010CC RID: 4300 RVA: 0x00105480 File Offset: 0x00103680
		// (set) Token: 0x060010CD RID: 4301 RVA: 0x00105534 File Offset: 0x00103734
		public string TrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966_UIValue
		{
			get
			{
				short num = (short)569015336;
				short num2 = num;
				num = (short)1000766504;
				switch (num2 == num)
				{
				}
				num = (short)1476001793;
				if (num != 0)
				{
				}
				num = (short)1024393216;
				if (num != 0)
				{
				}
				num = (short)887554048;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.UIValue;
			}
			set
			{
				short num = (short)558371373;
				short num2 = num;
				num = (short)1977356845;
				switch (num2 == num)
				{
				}
				num = (short)1730609153;
				if (num != 0)
				{
				}
				num = (short)739508224;
				if (num != 0)
				{
				}
				num = (short)1968242688;
				short num3 = num;
				this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.UIValue = value;
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x060010CE RID: 4302 RVA: 0x001055EC File Offset: 0x001037EC
		public global::AcpBusinessLayer.AcpRecRefField TrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966
		{
			get
			{
				short num = (short)452967887;
				short num2 = num;
				num = (short)1896070607;
				switch (num2 == num)
				{
				}
				num = (short)1940062208;
				if (num != 0)
				{
				}
				num = (short)1918369793;
				if (num != 0)
				{
				}
				num = (short)1147731968;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966;
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x060010CF RID: 4303 RVA: 0x00105698 File Offset: 0x00103898
		// (set) Token: 0x060010D0 RID: 4304 RVA: 0x0010574C File Offset: 0x0010394C
		public bool TrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966_Applicable
		{
			get
			{
				short num = (short)1939626321;
				short num2 = num;
				num = (short)125065553;
				switch (num2 == num)
				{
				}
				num = (short)1144717313;
				if (num != 0)
				{
				}
				num = (short)727056384;
				if (num != 0)
				{
				}
				num = (short)1059848192;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.Applicable;
			}
			set
			{
				short num = (short)1639629600;
				short num2 = num;
				num = (short)990954272;
				switch (num2 == num)
				{
				}
				num = (short)59113472;
				if (num != 0)
				{
				}
				num = (short)411566081;
				if (num != 0)
				{
				}
				num = (short)1839071232;
				short num3 = num;
				this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.Applicable = value;
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x060010D1 RID: 4305 RVA: 0x00105800 File Offset: 0x00103A00
		// (set) Token: 0x060010D2 RID: 4306 RVA: 0x001058B8 File Offset: 0x00103AB8
		public bool TrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966_Valid
		{
			get
			{
				short num = (short)348647497;
				short num2 = num;
				num = (short)1662644297;
				switch (num2 == num)
				{
				}
				num = (short)1820917760;
				if (num != 0)
				{
				}
				num = (short)1019215873;
				if (num != 0)
				{
				}
				num = (short)430309376;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.Valid;
			}
			set
			{
				short num = (short)528343014;
				short num2 = num;
				num = (short)619634662;
				switch (num2 == num)
				{
				}
				num = (short)819003393;
				if (num != 0)
				{
				}
				num = (short)649396224;
				if (num != 0)
				{
				}
				num = (short)24772608;
				short num3 = num;
				this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.Valid = value;
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x060010D3 RID: 4307 RVA: 0x00105970 File Offset: 0x00103B70
		// (set) Token: 0x060010D4 RID: 4308 RVA: 0x00105A24 File Offset: 0x00103C24
		public bool TrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966_Visible
		{
			get
			{
				short num = (short)1579678221;
				short num2 = num;
				num = (short)2043083277;
				switch (num2 == num)
				{
				}
				num = (short)809369600;
				if (num != 0)
				{
				}
				num = (short)556072961;
				if (num != 0)
				{
				}
				num = (short)1935015936;
				short num3 = num;
				return this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.Visible;
			}
			set
			{
				short num = (short)2004547318;
				short num2 = num;
				num = (short)719320822;
				switch (num2 == num)
				{
				}
				num = (short)691732480;
				if (num != 0)
				{
				}
				num = (short)776863744;
				short num3 = num;
				num = (short)580386817;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.Visible = value;
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x060010D5 RID: 4309 RVA: 0x00105ADC File Offset: 0x00103CDC
		// (set) Token: 0x060010D6 RID: 4310 RVA: 0x00105B90 File Offset: 0x00103D90
		public bool TrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966_Editable
		{
			get
			{
				short num = (short)1819277440;
				short num2 = num;
				num = (short)166721664;
				switch (num2 == num)
				{
				}
				num = (short)1699348480;
				if (num != 0)
				{
				}
				num = (short)1308229632;
				short num3 = num;
				num = (short)1562443777;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.Editable;
			}
			set
			{
				short num = (short)167260697;
				short num2 = num;
				num = (short)193344025;
				switch (num2 == num)
				{
				}
				num = (short)132055041;
				if (num != 0)
				{
				}
				num = (short)1242890240;
				short num3 = num;
				num = (short)265879552;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.Editable = value;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x060010D7 RID: 4311 RVA: 0x00105C44 File Offset: 0x00103E44
		internal string TrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966_UILabel
		{
			get
			{
				short num = (short)687476663;
				short num2 = num;
				num = (short)2120814519;
				switch (num2 == num)
				{
				}
				num = (short)1756233729;
				if (num != 0)
				{
				}
				num = (short)1831993344;
				short num3 = num;
				num = (short)1548025856;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.UIName;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x060010D8 RID: 4312 RVA: 0x00105CF4 File Offset: 0x00103EF4
		// (set) Token: 0x060010D9 RID: 4313 RVA: 0x00105DAC File Offset: 0x00103FAC
		internal bool TrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966_HiddenStatic
		{
			get
			{
				short num = (short)1196163073;
				if (num != 0)
				{
				}
				num = (short)1655352929;
				short num2 = num;
				num = (short)1041084001;
				switch (num2 == num)
				{
				}
				num = (short)2112421888;
				short num3 = num;
				num = (short)741867520;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.HiddenStatic;
			}
			set
			{
				short num = (short)16121857;
				if (num != 0)
				{
				}
				num = (short)1660287677;
				short num2 = num;
				num = (short)202046141;
				switch (num2 == num)
				{
				}
				num = (short)350552064;
				short num3 = num;
				num = (short)47316992;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.HiddenStatic = value;
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x060010DA RID: 4314 RVA: 0x00105E60 File Offset: 0x00104060
		// (set) Token: 0x060010DB RID: 4315 RVA: 0x00105F18 File Offset: 0x00104118
		internal bool TrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966_HiddenDynamic
		{
			get
			{
				short num = (short)336916843;
				short num2 = num;
				num = (short)1724117355;
				switch (num2 == num)
				{
				}
				num = (short)867303425;
				if (num != 0)
				{
				}
				num = (short)468647936;
				short num3 = num;
				num = (short)106233856;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.HiddenDynamic;
			}
			set
			{
				short num = (short)1090031104;
				short num2 = num;
				num = (short)1649118720;
				switch (num2 == num)
				{
				}
				num = (short)1673461761;
				if (num != 0)
				{
				}
				num = (short)51183616;
				short num3 = num;
				num = (short)1728118784;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.HiddenDynamic = value;
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x060010DC RID: 4316 RVA: 0x00105FCC File Offset: 0x001041CC
		public bool TrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966_HasDiffs
		{
			get
			{
				short num = (short)879755265;
				if (num != 0)
				{
				}
				num = (short)1490468065;
				short num2 = num;
				num = (short)1015790817;
				switch (num2 == num)
				{
				}
				num = (short)1122435072;
				short num3 = num;
				num = (short)1779105792;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966._HasDiffs;
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x060010DD RID: 4317 RVA: 0x00106080 File Offset: 0x00104280
		// (set) Token: 0x060010DE RID: 4318 RVA: 0x00106134 File Offset: 0x00104334
		public int TrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967Value
		{
			get
			{
				short num = (short)723702531;
				short num2 = num;
				num = (short)688902915;
				switch (num2 == num)
				{
				}
				num = (short)1433796608;
				if (num != 0)
				{
				}
				num = (short)451936256;
				short num3 = num;
				num = (short)526778369;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.Value;
			}
			set
			{
				short num = (short)702688926;
				short num2 = num;
				num = (short)2123443870;
				switch (num2 == num)
				{
				}
				num = (short)941031425;
				if (num != 0)
				{
				}
				num = (short)1455423488;
				short num3 = num;
				num = (short)1557331968;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.Value = value;
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x001061EC File Offset: 0x001043EC
		// (set) Token: 0x060010E0 RID: 4320 RVA: 0x001062A0 File Offset: 0x001044A0
		public string TrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967_UIValue
		{
			get
			{
				short num = (short)977954490;
				short num2 = num;
				num = (short)1474586298;
				switch (num2 == num)
				{
				}
				num = (short)532021248;
				if (num != 0)
				{
				}
				num = (short)1797324800;
				short num3 = num;
				num = (short)202375169;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.UIValue;
			}
			set
			{
				short num = (short)880294985;
				short num2 = num;
				num = (short)1391082569;
				switch (num2 == num)
				{
				}
				num = (short)272105472;
				if (num != 0)
				{
				}
				num = (short)2139160576;
				short num3 = num;
				num = (short)738263041;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.UIValue = value;
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x00106358 File Offset: 0x00104558
		public global::AcpBusinessLayer.AcpRecRefField TrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967
		{
			get
			{
				short num = (short)2074148865;
				if (num != 0)
				{
				}
				num = (short)1089805344;
				short num2 = num;
				num = (short)1963596832;
				switch (num2 == num)
				{
				}
				num = (short)1551761408;
				short num3 = num;
				num = (short)131334144;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x00106404 File Offset: 0x00104604
		// (set) Token: 0x060010E3 RID: 4323 RVA: 0x001064C0 File Offset: 0x001046C0
		public bool TrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967_Applicable
		{
			get
			{
				short num = (short)355753305;
				short num2 = num;
				num = (short)745561433;
				switch (num2 == num)
				{
				}
				num = (short)2028077057;
				if (num != 0)
				{
				}
				num = (short)1272971264;
				short num3 = num;
				num = (short)1179320320;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.Applicable;
			}
			set
			{
				short num = (short)1084278604;
				short num2 = num;
				num = (short)1130284876;
				switch (num2 == num)
				{
				}
				num = (short)550305793;
				if (num != 0)
				{
				}
				num = (short)377618432;
				short num3 = num;
				num = (short)811794432;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.Applicable = value;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x060010E4 RID: 4324 RVA: 0x00106574 File Offset: 0x00104774
		// (set) Token: 0x060010E5 RID: 4325 RVA: 0x0010662C File Offset: 0x0010482C
		public bool TrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967_Valid
		{
			get
			{
				short num = (short)115831137;
				short num2 = num;
				num = (short)722628961;
				switch (num2 == num)
				{
				}
				num = (short)1964572673;
				if (num != 0)
				{
				}
				num = (short)405798912;
				short num3 = num;
				num = (short)30015488;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.Valid;
			}
			set
			{
				short num = (short)1662948116;
				short num2 = num;
				num = (short)342922004;
				switch (num2 == num)
				{
				}
				num = (short)1064894464;
				if (num != 0)
				{
				}
				num = (short)1762525184;
				short num3 = num;
				num = (short)4456449;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.Valid = value;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x060010E6 RID: 4326 RVA: 0x001066E0 File Offset: 0x001048E0
		// (set) Token: 0x060010E7 RID: 4327 RVA: 0x0010679C File Offset: 0x0010499C
		public bool TrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967_Visible
		{
			get
			{
				short num = (short)1554463536;
				short num2 = num;
				num = (short)1381710640;
				switch (num2 == num)
				{
				}
				num = (short)357367808;
				if (num != 0)
				{
				}
				num = (short)2071658496;
				short num3 = num;
				num = (short)783286273;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.Visible;
			}
			set
			{
				short num = (short)887112800;
				short num2 = num;
				num = (short)1087652960;
				switch (num2 == num)
				{
				}
				num = (short)1104805889;
				if (num != 0)
				{
				}
				num = (short)842268672;
				short num3 = num;
				num = (short)298450944;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.Visible = value;
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x060010E8 RID: 4328 RVA: 0x00106850 File Offset: 0x00104A50
		// (set) Token: 0x060010E9 RID: 4329 RVA: 0x00106904 File Offset: 0x00104B04
		public bool TrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967_Editable
		{
			get
			{
				short num = (short)1045658362;
				short num2 = num;
				num = (short)857242362;
				switch (num2 == num)
				{
				}
				num = (short)1937571841;
				if (num != 0)
				{
				}
				num = (short)352649216;
				short num3 = num;
				num = (short)1339228160;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.Editable;
			}
			set
			{
				short num = (short)887354778;
				short num2 = num;
				num = (short)1896281498;
				switch (num2 == num)
				{
				}
				num = (short)1669660673;
				if (num != 0)
				{
				}
				num = (short)1028849664;
				short num3 = num;
				num = (short)1362362368;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.Editable = value;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x060010EA RID: 4330 RVA: 0x001069B8 File Offset: 0x00104BB8
		internal string TrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967_UILabel
		{
			get
			{
				short num = (short)1223547141;
				short num2 = num;
				num = (short)1353373957;
				switch (num2 == num)
				{
				}
				num = (short)188874752;
				if (num != 0)
				{
				}
				num = (short)526319616;
				short num3 = num;
				num = (short)1817837569;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.UIName;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x00106A70 File Offset: 0x00104C70
		// (set) Token: 0x060010EC RID: 4332 RVA: 0x00106B24 File Offset: 0x00104D24
		internal bool TrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967_HiddenStatic
		{
			get
			{
				short num = (short)1867608933;
				short num2 = num;
				num = (short)184841061;
				switch (num2 == num)
				{
				}
				num = (short)1387724800;
				if (num != 0)
				{
				}
				num = (short)198967296;
				short num3 = num;
				num = (short)1521287169;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.HiddenStatic;
			}
			set
			{
				short num = (short)1685577362;
				short num2 = num;
				num = (short)2124471954;
				switch (num2 == num)
				{
				}
				num = (short)2139815937;
				if (num != 0)
				{
				}
				num = (short)1355743232;
				short num3 = num;
				num = (short)714276864;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.HiddenStatic = value;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x00106BDC File Offset: 0x00104DDC
		// (set) Token: 0x060010EE RID: 4334 RVA: 0x00106C90 File Offset: 0x00104E90
		internal bool TrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967_HiddenDynamic
		{
			get
			{
				short num = (short)772444115;
				short num2 = num;
				num = (short)34901971;
				switch (num2 == num)
				{
				}
				num = (short)1026883585;
				if (num != 0)
				{
				}
				num = (short)402915328;
				short num3 = num;
				num = (short)2132738048;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.HiddenDynamic;
			}
			set
			{
				short num = (short)1450040029;
				short num2 = num;
				num = (short)1468455645;
				switch (num2 == num)
				{
				}
				num = (short)515899392;
				if (num != 0)
				{
				}
				num = (short)650051584;
				short num3 = num;
				num = (short)1921253377;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.HiddenDynamic = value;
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x00106D48 File Offset: 0x00104F48
		public bool TrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967_HasDiffs
		{
			get
			{
				short num = (short)345020264;
				short num2 = num;
				num = (short)352032616;
				switch (num2 == num)
				{
				}
				num = (short)757202945;
				if (num != 0)
				{
				}
				num = (short)837353472;
				short num3 = num;
				num = (short)879755264;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967._HasDiffs;
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x060010F0 RID: 4336 RVA: 0x00106DFC File Offset: 0x00104FFC
		// (set) Token: 0x060010F1 RID: 4337 RVA: 0x00106EB4 File Offset: 0x001050B4
		public int TrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968Value
		{
			get
			{
				short num = (short)770576269;
				short num2 = num;
				num = (short)681185165;
				switch (num2 == num)
				{
				}
				num = (short)1319567361;
				if (num != 0)
				{
				}
				num = (short)1735262208;
				short num3 = num;
				num = (short)482869248;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.Value;
			}
			set
			{
				short num = (short)1170123448;
				short num2 = num;
				num = (short)447654584;
				switch (num2 == num)
				{
				}
				num = (short)638451713;
				if (num != 0)
				{
				}
				num = (short)281346048;
				short num3 = num;
				num = (short)921698304;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.Value = value;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x060010F2 RID: 4338 RVA: 0x00106F68 File Offset: 0x00105168
		// (set) Token: 0x060010F3 RID: 4339 RVA: 0x0010701C File Offset: 0x0010521C
		public string TrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968_UIValue
		{
			get
			{
				short num = (short)2070522203;
				short num2 = num;
				num = (short)536521051;
				switch (num2 == num)
				{
				}
				num = (short)678494209;
				if (num != 0)
				{
				}
				num = (short)1688207360;
				short num3 = num;
				num = (short)178388992;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.UIValue;
			}
			set
			{
				short num = (short)1470220089;
				short num2 = num;
				num = (short)1120061241;
				switch (num2 == num)
				{
				}
				num = (short)1491402752;
				if (num != 0)
				{
				}
				num = (short)270467072;
				short num3 = num;
				num = (short)1940914177;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.UIValue = value;
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x001070D4 File Offset: 0x001052D4
		public global::AcpBusinessLayer.AcpRecRefField TrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968
		{
			get
			{
				short num = (short)1445321274;
				short num2 = num;
				num = (short)1741412922;
				switch (num2 == num)
				{
				}
				num = (short)2044985345;
				if (num != 0)
				{
				}
				num = (short)954925056;
				short num3 = num;
				num = (short)536936448;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968;
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x060010F5 RID: 4341 RVA: 0x00107184 File Offset: 0x00105384
		// (set) Token: 0x060010F6 RID: 4342 RVA: 0x0010723C File Offset: 0x0010543C
		public bool TrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968_Applicable
		{
			get
			{
				short num = (short)1837555627;
				short num2 = num;
				num = (short)521002923;
				switch (num2 == num)
				{
				}
				num = (short)358940672;
				if (num != 0)
				{
				}
				num = (short)654180352;
				short num3 = num;
				num = (short)2075262977;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.Applicable;
			}
			set
			{
				short num = (short)1455436875;
				short num2 = num;
				num = (short)1805661259;
				switch (num2 == num)
				{
				}
				num = (short)238092289;
				if (num != 0)
				{
				}
				num = (short)84934656;
				short num3 = num;
				num = (short)32899072;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.Applicable = value;
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x001072F0 File Offset: 0x001054F0
		// (set) Token: 0x060010F8 RID: 4344 RVA: 0x001073A4 File Offset: 0x001055A4
		public bool TrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968_Valid
		{
			get
			{
				short num = (short)787015848;
				short num2 = num;
				num = (short)1679812776;
				switch (num2 == num)
				{
				}
				num = (short)2058551297;
				if (num != 0)
				{
				}
				num = (short)1691025408;
				short num3 = num;
				num = (short)1989672960;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.Valid;
			}
			set
			{
				short num = (short)1767602638;
				short num2 = num;
				num = (short)422738382;
				switch (num2 == num)
				{
				}
				num = (short)1882390529;
				if (num != 0)
				{
				}
				num = (short)1448607744;
				short num3 = num;
				num = (short)501612544;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.Valid = value;
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x0010745C File Offset: 0x0010565C
		// (set) Token: 0x060010FA RID: 4346 RVA: 0x00107510 File Offset: 0x00105710
		public bool TrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968_Visible
		{
			get
			{
				short num = (short)589775821;
				short num2 = num;
				num = (short)1279673293;
				switch (num2 == num)
				{
				}
				num = (short)588120065;
				if (num != 0)
				{
				}
				num = (short)860225536;
				short num3 = num;
				num = (short)387186688;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.Visible;
			}
			set
			{
				short num = (short)763145595;
				short num2 = num;
				num = (short)1080536443;
				switch (num2 == num)
				{
				}
				num = (short)536346625;
				if (num != 0)
				{
				}
				num = (short)2039480320;
				short num3 = num;
				num = (short)2048720896;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.Visible = value;
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x001075C4 File Offset: 0x001057C4
		// (set) Token: 0x060010FC RID: 4348 RVA: 0x00107678 File Offset: 0x00105878
		public bool TrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968_Editable
		{
			get
			{
				short num = (short)433729307;
				short num2 = num;
				num = (short)1405759259;
				switch (num2 == num)
				{
				}
				num = (short)1672019968;
				if (num != 0)
				{
				}
				num = (short)1365966848;
				short num3 = num;
				num = (short)1105592321;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.Editable;
			}
			set
			{
				short num = (short)1286938229;
				short num2 = num;
				num = (short)64757365;
				switch (num2 == num)
				{
				}
				num = (short)922025985;
				if (num != 0)
				{
				}
				num = (short)1099038720;
				short num3 = num;
				num = (short)1429602304;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.Editable = value;
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x0010772C File Offset: 0x0010592C
		internal string TrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968_UILabel
		{
			get
			{
				short num = (short)980323873;
				short num2 = num;
				num = (short)1824034337;
				switch (num2 == num)
				{
				}
				num = (short)433389568;
				if (num != 0)
				{
				}
				num = (short)128122880;
				short num3 = num;
				num = (short)398917633;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.UIName;
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x001077E0 File Offset: 0x001059E0
		// (set) Token: 0x060010FF RID: 4351 RVA: 0x00107894 File Offset: 0x00105A94
		internal bool TrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968_HiddenStatic
		{
			get
			{
				short num = (short)308148045;
				short num2 = num;
				num = (short)228980557;
				switch (num2 == num)
				{
				}
				num = (short)1725104129;
				if (num != 0)
				{
				}
				num = (short)1125974016;
				short num3 = num;
				num = (short)1557987328;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.HiddenStatic;
			}
			set
			{
				short num = (short)693395532;
				short num2 = num;
				num = (short)372596812;
				switch (num2 == num)
				{
				}
				num = (short)816054273;
				if (num != 0)
				{
				}
				num = (short)1236664320;
				short num3 = num;
				num = (short)1545535488;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.HiddenStatic = value;
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x00107948 File Offset: 0x00105B48
		// (set) Token: 0x06001101 RID: 4353 RVA: 0x001079FC File Offset: 0x00105BFC
		internal bool TrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968_HiddenDynamic
		{
			get
			{
				short num = (short)145090170;
				short num2 = num;
				num = (short)133097082;
				switch (num2 == num)
				{
				}
				num = (short)523960321;
				if (num != 0)
				{
				}
				num = (short)1163067392;
				short num3 = num;
				num = (short)1852243968;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.HiddenDynamic;
			}
			set
			{
				short num = (short)51773441;
				if (num != 0)
				{
				}
				num = (short)1905427282;
				short num2 = num;
				num = (short)306676562;
				switch (num2 == num)
				{
				}
				num = (short)888274944;
				short num3 = num;
				num = (short)1658978304;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.HiddenDynamic = value;
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x00107AB0 File Offset: 0x00105CB0
		public bool TrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968_HasDiffs
		{
			get
			{
				short num = (short)1734684213;
				short num2 = num;
				num = (short)356068917;
				switch (num2 == num)
				{
				}
				num = (short)2031550465;
				if (num != 0)
				{
				}
				num = (short)1538457600;
				short num3 = num;
				num = (short)1756692480;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968._HasDiffs;
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x00107B64 File Offset: 0x00105D64
		// (set) Token: 0x06001104 RID: 4356 RVA: 0x00107C1C File Offset: 0x00105E1C
		public int TrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969Value
		{
			get
			{
				short num = (short)2004246535;
				short num2 = num;
				num = (short)150822919;
				switch (num2 == num)
				{
				}
				num = (short)1584857089;
				if (num != 0)
				{
				}
				num = (short)587726848;
				short num3 = num;
				num = (short)790429696;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.Value;
			}
			set
			{
				short num = (short)985989121;
				if (num != 0)
				{
				}
				num = (short)1220654292;
				short num2 = num;
				num = (short)1559278804;
				switch (num2 == num)
				{
				}
				num = (short)1721171968;
				short num3 = num;
				num = (short)392036352;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.Value = value;
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x00107CD0 File Offset: 0x00105ED0
		// (set) Token: 0x06001106 RID: 4358 RVA: 0x00107D84 File Offset: 0x00105F84
		public string TrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969_UIValue
		{
			get
			{
				short num = (short)83359362;
				short num2 = num;
				num = (short)4322946;
				switch (num2 == num)
				{
				}
				num = (short)1646002177;
				if (num != 0)
				{
				}
				num = (short)1180696576;
				short num3 = num;
				num = (short)271974400;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.UIValue;
			}
			set
			{
				short num = (short)615245808;
				short num2 = num;
				num = (short)544008176;
				switch (num2 == num)
				{
				}
				num = (short)161087489;
				if (num != 0)
				{
				}
				num = (short)622657536;
				short num3 = num;
				num = (short)1622016000;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.UIValue = value;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x00107E38 File Offset: 0x00106038
		public global::AcpBusinessLayer.AcpRecRefField TrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969
		{
			get
			{
				short num = (short)276103169;
				if (num != 0)
				{
				}
				num = (short)770584588;
				short num2 = num;
				num = (short)19607564;
				switch (num2 == num)
				{
				}
				num = (short)1720385536;
				short num3 = num;
				num = (short)802684928;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969;
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x00107EE4 File Offset: 0x001060E4
		// (set) Token: 0x06001109 RID: 4361 RVA: 0x00107F98 File Offset: 0x00106198
		public bool TrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969_Applicable
		{
			get
			{
				short num = (short)598390041;
				short num2 = num;
				num = (short)1660728601;
				switch (num2 == num)
				{
				}
				num = (short)697040896;
				if (num != 0)
				{
				}
				num = (short)1652424704;
				short num3 = num;
				num = (short)360906753;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.Applicable;
			}
			set
			{
				short num = (short)2119801733;
				short num2 = num;
				num = (short)66362245;
				switch (num2 == num)
				{
				}
				num = (short)1909260289;
				if (num != 0)
				{
				}
				num = (short)748748800;
				short num3 = num;
				num = (short)516030464;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.Applicable = value;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x0010804C File Offset: 0x0010624C
		// (set) Token: 0x0600110B RID: 4363 RVA: 0x00108100 File Offset: 0x00106300
		public bool TrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969_Valid
		{
			get
			{
				short num = (short)1511882515;
				short num2 = num;
				num = (short)1163165459;
				switch (num2 == num)
				{
				}
				num = (short)1614479361;
				if (num != 0)
				{
				}
				num = (short)2058354688;
				short num3 = num;
				num = (short)1661665280;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.Valid;
			}
			set
			{
				short num = (short)1198981120;
				short num2 = num;
				num = (short)1005125980;
				short num3 = num;
				num = (short)144441692;
				switch (num3 == num)
				{
				}
				num = (short)783351809;
				if (num != 0)
				{
				}
				num = (short)405078016;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.Valid = value;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x001081B8 File Offset: 0x001063B8
		// (set) Token: 0x0600110D RID: 4365 RVA: 0x00108268 File Offset: 0x00106468
		public bool TrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969_Visible
		{
			get
			{
				short num = (short)542441472;
				short num2 = num;
				num = (short)1402740603;
				short num3 = num;
				num = (short)149299067;
				switch (num3 == num)
				{
				}
				num = (short)2128936960;
				if (num != 0)
				{
				}
				num = (short)1165295617;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.Visible;
			}
			set
			{
				short num = (short)1777467392;
				short num2 = num;
				num = (short)1946074803;
				short num3 = num;
				num = (short)1521008307;
				switch (num3 == num)
				{
				}
				num = (short)620101633;
				if (num != 0)
				{
				}
				num = (short)906231808;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.Visible = value;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x0010831C File Offset: 0x0010651C
		// (set) Token: 0x0600110F RID: 4367 RVA: 0x001083D0 File Offset: 0x001065D0
		public bool TrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969_Editable
		{
			get
			{
				short num = (short)746586112;
				short num2 = num;
				num = (short)278659073;
				if (num != 0)
				{
				}
				num = (short)1724199205;
				short num3 = num;
				num = (short)1790325029;
				switch (num3 == num)
				{
				}
				num = (short)384172032;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.Editable;
			}
			set
			{
				short num = (short)743374848;
				short num2 = num;
				num = (short)1167662733;
				short num3 = num;
				num = (short)1920147085;
				switch (num3 == num)
				{
				}
				num = (short)1394409473;
				if (num != 0)
				{
				}
				num = (short)1536163840;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.Editable = value;
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06001110 RID: 4368 RVA: 0x00108484 File Offset: 0x00106684
		internal string TrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969_UILabel
		{
			get
			{
				short num = (short)126353408;
				short num2 = num;
				num = (short)446635999;
				short num3 = num;
				num = (short)380182495;
				switch (num3 == num)
				{
				}
				num = (short)2034106369;
				if (num != 0)
				{
				}
				num = (short)407175168;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.UIName;
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x0010853C File Offset: 0x0010673C
		// (set) Token: 0x06001112 RID: 4370 RVA: 0x001085F0 File Offset: 0x001067F0
		internal bool TrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969_HiddenStatic
		{
			get
			{
				short num = (short)1880424448;
				short num2 = num;
				num = (short)932839425;
				if (num != 0)
				{
				}
				num = (short)1958042115;
				short num3 = num;
				num = (short)214194691;
				switch (num3 == num)
				{
				}
				num = (short)1639907328;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.HiddenStatic;
			}
			set
			{
				short num = (short)1573781504;
				short num2 = num;
				num = (short)1344700019;
				short num3 = num;
				num = (short)1226210931;
				switch (num3 == num)
				{
				}
				num = (short)1075773441;
				if (num != 0)
				{
				}
				num = (short)691666944;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.HiddenStatic = value;
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x001086A8 File Offset: 0x001068A8
		// (set) Token: 0x06001114 RID: 4372 RVA: 0x0010875C File Offset: 0x0010695C
		internal bool TrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969_HiddenDynamic
		{
			get
			{
				short num = (short)109248512;
				short num2 = num;
				num = (short)1443566121;
				short num3 = num;
				num = (short)648286761;
				switch (num3 == num)
				{
				}
				num = (short)1815150593;
				if (num != 0)
				{
				}
				num = (short)38404096;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.HiddenDynamic;
			}
			set
			{
				short num = (short)25100288;
				short num2 = num;
				num = (short)1301031336;
				short num3 = num;
				num = (short)581052840;
				switch (num3 == num)
				{
				}
				num = (short)482672641;
				if (num != 0)
				{
				}
				num = (short)145883136;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.HiddenDynamic = value;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001115 RID: 4373 RVA: 0x00108810 File Offset: 0x00106A10
		public bool TrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969_HasDiffs
		{
			get
			{
				short num = (short)1232273408;
				short num2 = num;
				num = (short)1400661861;
				short num3 = num;
				num = (short)163604325;
				switch (num3 == num)
				{
				}
				num = (short)212795392;
				if (num != 0)
				{
				}
				num = (short)814284801;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969._HasDiffs;
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x001088C4 File Offset: 0x00106AC4
		// (set) Token: 0x06001117 RID: 4375 RVA: 0x00108978 File Offset: 0x00106B78
		public int TrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970Value
		{
			get
			{
				short num = (short)59965440;
				short num2 = num;
				num = (short)1423477887;
				short num3 = num;
				num = (short)1092258943;
				switch (num3 == num)
				{
				}
				num = (short)726335489;
				if (num != 0)
				{
				}
				num = (short)855048192;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.Value;
			}
			set
			{
				short num = (short)2023948288;
				short num2 = num;
				num = (short)377248926;
				short num3 = num;
				num = (short)1667521694;
				switch (num3 == num)
				{
				}
				num = (short)1906245632;
				if (num != 0)
				{
				}
				num = (short)1427767297;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.Value = value;
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x00108A30 File Offset: 0x00106C30
		// (set) Token: 0x06001119 RID: 4377 RVA: 0x00108AE8 File Offset: 0x00106CE8
		public string TrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970_UIValue
		{
			get
			{
				short num = (short)1075904512;
				short num2 = num;
				num = (short)2110515156;
				short num3 = num;
				num = (short)200665044;
				switch (num3 == num)
				{
				}
				num = (short)90112000;
				if (num != 0)
				{
				}
				num = (short)100794369;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.UIValue;
			}
			set
			{
				short num = (short)1132920832;
				short num2 = num;
				num = (short)1130919088;
				short num3 = num;
				num = (short)435844272;
				switch (num3 == num)
				{
				}
				num = (short)671023105;
				if (num != 0)
				{
				}
				num = (short)393281536;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.UIValue = value;
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x0600111A RID: 4378 RVA: 0x00108B9C File Offset: 0x00106D9C
		public global::AcpBusinessLayer.AcpRecRefField TrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970
		{
			get
			{
				short num = (short)1893400576;
				short num2 = num;
				num = (short)1961446782;
				short num3 = num;
				num = (short)460606846;
				switch (num3 == num)
				{
				}
				num = (short)1723072513;
				if (num != 0)
				{
				}
				num = (short)1507393536;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970;
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x00108C50 File Offset: 0x00106E50
		// (set) Token: 0x0600111C RID: 4380 RVA: 0x00108D08 File Offset: 0x00106F08
		public bool TrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970_Applicable
		{
			get
			{
				short num = (short)416088064;
				short num2 = num;
				num = (short)1271660545;
				if (num != 0)
				{
				}
				num = (short)1145318803;
				short num3 = num;
				num = (short)1974283667;
				switch (num3 == num)
				{
				}
				num = (short)1018757120;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.Applicable;
			}
			set
			{
				short num = (short)157351936;
				short num2 = num;
				num = (short)2086593945;
				short num3 = num;
				num = (short)719906201;
				switch (num3 == num)
				{
				}
				num = (short)1548222465;
				if (num != 0)
				{
				}
				num = (short)1092878336;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.Applicable = value;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x0600111D RID: 4381 RVA: 0x00108DBC File Offset: 0x00106FBC
		// (set) Token: 0x0600111E RID: 4382 RVA: 0x00108E70 File Offset: 0x00107070
		public bool TrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970_Valid
		{
			get
			{
				short num = (short)897581056;
				short num2 = num;
				num = (short)860487681;
				if (num != 0)
				{
				}
				num = (short)1327107093;
				short num3 = num;
				num = (short)976620565;
				switch (num3 == num)
				{
				}
				num = (short)1550057472;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.Valid;
			}
			set
			{
				short num = (short)2123431936;
				short num2 = num;
				num = (short)466626027;
				short num3 = num;
				num = (short)606610923;
				switch (num3 == num)
				{
				}
				num = (short)1860960257;
				if (num != 0)
				{
				}
				num = (short)1291517952;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.Valid = value;
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x0600111F RID: 4383 RVA: 0x00108F28 File Offset: 0x00107128
		// (set) Token: 0x06001120 RID: 4384 RVA: 0x00108FE0 File Offset: 0x001071E0
		public bool TrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970_Visible
		{
			get
			{
				short num = (short)1273102336;
				short num2 = num;
				num = (short)597290200;
				short num3 = num;
				num = (short)1324870872;
				switch (num3 == num)
				{
				}
				num = (short)324337664;
				if (num != 0)
				{
				}
				num = (short)983695361;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.Visible;
			}
			set
			{
				short num = (short)2018705408;
				short num2 = num;
				num = (short)1306918477;
				short num3 = num;
				num = (short)719846989;
				switch (num3 == num)
				{
				}
				num = (short)1281622017;
				if (num != 0)
				{
				}
				num = (short)1316814848;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.Visible = value;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06001121 RID: 4385 RVA: 0x00109094 File Offset: 0x00107294
		// (set) Token: 0x06001122 RID: 4386 RVA: 0x00109148 File Offset: 0x00107348
		public bool TrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970_Editable
		{
			get
			{
				short num = (short)89849856;
				short num2 = num;
				num = (short)14514361;
				short num3 = num;
				num = (short)1001224377;
				switch (num3 == num)
				{
				}
				num = (short)1936982017;
				if (num != 0)
				{
				}
				num = (short)489881600;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.Editable;
			}
			set
			{
				short num = (short)1519124480;
				short num2 = num;
				num = (short)296062187;
				short num3 = num;
				num = (short)1923910891;
				switch (num3 == num)
				{
				}
				num = (short)111149057;
				if (num != 0)
				{
				}
				num = (short)1649606656;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.Editable = value;
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06001123 RID: 4387 RVA: 0x001091FC File Offset: 0x001073FC
		internal string TrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970_UILabel
		{
			get
			{
				short num = (short)300679168;
				short num2 = num;
				num = (short)289168191;
				short num3 = num;
				num = (short)775117631;
				switch (num3 == num)
				{
				}
				num = (short)1306656769;
				if (num != 0)
				{
				}
				num = (short)1021575168;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.UIName;
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06001124 RID: 4388 RVA: 0x001092B0 File Offset: 0x001074B0
		// (set) Token: 0x06001125 RID: 4389 RVA: 0x00109368 File Offset: 0x00107568
		internal bool TrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970_HiddenStatic
		{
			get
			{
				short num = (short)724238336;
				short num2 = num;
				num = (short)506356126;
				short num3 = num;
				num = (short)971137438;
				switch (num3 == num)
				{
				}
				num = (short)534970369;
				if (num != 0)
				{
				}
				num = (short)1886781440;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.HiddenStatic;
			}
			set
			{
				short num = (short)1531445248;
				short num2 = num;
				num = (short)668105430;
				short num3 = num;
				num = (short)448756438;
				switch (num3 == num)
				{
				}
				num = (short)455737345;
				if (num != 0)
				{
				}
				num = (short)1885011968;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.HiddenStatic = value;
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x0010941C File Offset: 0x0010761C
		// (set) Token: 0x06001127 RID: 4391 RVA: 0x001094D0 File Offset: 0x001076D0
		internal bool TrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970_HiddenDynamic
		{
			get
			{
				short num = (short)482344960;
				short num2 = num;
				num = (short)600637441;
				if (num != 0)
				{
				}
				num = (short)1037951635;
				short num3 = num;
				num = (short)25551507;
				switch (num3 == num)
				{
				}
				num = (short)815202304;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.HiddenDynamic;
			}
			set
			{
				short num = (short)1779892224;
				short num2 = num;
				num = (short)364321034;
				short num3 = num;
				num = (short)385620234;
				switch (num3 == num)
				{
				}
				num = (short)1067384832;
				if (num != 0)
				{
				}
				num = (short)1296171009;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.HiddenDynamic = value;
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x00109584 File Offset: 0x00107784
		public bool TrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970_HasDiffs
		{
			get
			{
				short num = (short)2145714176;
				short num2 = num;
				num = (short)768262856;
				short num3 = num;
				num = (short)1672266440;
				switch (num3 == num)
				{
				}
				num = (short)933953537;
				if (num != 0)
				{
				}
				num = (short)2084831232;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970._HasDiffs;
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x06001129 RID: 4393 RVA: 0x0010963C File Offset: 0x0010783C
		// (set) Token: 0x0600112A RID: 4394 RVA: 0x001096F0 File Offset: 0x001078F0
		public int TrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971Value
		{
			get
			{
				short num = (short)724500480;
				short num2 = num;
				num = (short)1113160015;
				short num3 = num;
				num = (short)1982167375;
				switch (num3 == num)
				{
				}
				num = (short)1617494017;
				if (num != 0)
				{
				}
				num = (short)629669888;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.Value;
			}
			set
			{
				short num = (short)346423296;
				short num2 = num;
				num = (short)1887961089;
				if (num != 0)
				{
				}
				num = (short)1315377696;
				short num3 = num;
				num = (short)1451364896;
				switch (num3 == num)
				{
				}
				num = (short)1420165120;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.Value = value;
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x0600112B RID: 4395 RVA: 0x001097A8 File Offset: 0x001079A8
		// (set) Token: 0x0600112C RID: 4396 RVA: 0x0010985C File Offset: 0x00107A5C
		public string TrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971_UIValue
		{
			get
			{
				short num = (short)1157627904;
				short num2 = num;
				num = (short)789659316;
				short num3 = num;
				num = (short)1227505332;
				switch (num3 == num)
				{
				}
				num = (short)600113152;
				if (num != 0)
				{
				}
				num = (short)1502543873;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.UIValue;
			}
			set
			{
				short num = (short)1399324672;
				short num2 = num;
				num = (short)2057199768;
				short num3 = num;
				num = (short)1366188184;
				switch (num3 == num)
				{
				}
				num = (short)1948844033;
				if (num != 0)
				{
				}
				num = (short)1292632064;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.UIValue = value;
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x0600112D RID: 4397 RVA: 0x00109910 File Offset: 0x00107B10
		public global::AcpBusinessLayer.AcpRecRefField TrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971
		{
			get
			{
				short num = (short)1173553152;
				short num2 = num;
				num = (short)1903964911;
				short num3 = num;
				num = (short)1063203567;
				switch (num3 == num)
				{
				}
				num = (short)2115239936;
				if (num != 0)
				{
				}
				num = (short)49020929;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971;
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x001099C0 File Offset: 0x00107BC0
		// (set) Token: 0x0600112F RID: 4399 RVA: 0x00109A74 File Offset: 0x00107C74
		public bool TrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971_Applicable
		{
			get
			{
				short num = (short)1085800448;
				short num2 = num;
				num = (short)1492764973;
				short num3 = num;
				num = (short)1629079853;
				switch (num3 == num)
				{
				}
				num = (short)1959460864;
				if (num != 0)
				{
				}
				num = (short)1037828097;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.Applicable;
			}
			set
			{
				short num = (short)2141257728;
				short num2 = num;
				num = (short)745454362;
				short num3 = num;
				num = (short)2037955354;
				switch (num3 == num)
				{
				}
				num = (short)1888092161;
				if (num != 0)
				{
				}
				num = (short)696123392;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.Applicable = value;
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x00109B28 File Offset: 0x00107D28
		// (set) Token: 0x06001131 RID: 4401 RVA: 0x00109BDC File Offset: 0x00107DDC
		public bool TrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971_Valid
		{
			get
			{
				short num = (short)76087296;
				short num2 = num;
				num = (short)300159656;
				short num3 = num;
				num = (short)602935976;
				switch (num3 == num)
				{
				}
				num = (short)1946615809;
				if (num != 0)
				{
				}
				num = (short)1163395072;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.Valid;
			}
			set
			{
				short num = (short)767229952;
				short num2 = num;
				num = (short)499683053;
				short num3 = num;
				num = (short)1516015341;
				switch (num3 == num)
				{
				}
				num = (short)670367744;
				if (num != 0)
				{
				}
				num = (short)2108489729;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.Valid = value;
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06001132 RID: 4402 RVA: 0x00109C90 File Offset: 0x00107E90
		// (set) Token: 0x06001133 RID: 4403 RVA: 0x00109D44 File Offset: 0x00107F44
		public bool TrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971_Visible
		{
			get
			{
				short num = (short)783679488;
				short num2 = num;
				num = (short)1142296379;
				short num3 = num;
				num = (short)681774907;
				switch (num3 == num)
				{
				}
				num = (short)2010710017;
				if (num != 0)
				{
				}
				num = (short)1868496896;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.Visible;
			}
			set
			{
				short num = (short)1892286464;
				short num2 = num;
				num = (short)1561117810;
				short num3 = num;
				num = (short)1597162610;
				switch (num3 == num)
				{
				}
				num = (short)141492225;
				if (num != 0)
				{
				}
				num = (short)542703616;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.Visible = value;
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06001134 RID: 4404 RVA: 0x00109DFC File Offset: 0x00107FFC
		// (set) Token: 0x06001135 RID: 4405 RVA: 0x00109EB0 File Offset: 0x001080B0
		public bool TrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971_Editable
		{
			get
			{
				short num = (short)524025856;
				short num2 = num;
				num = (short)826212353;
				if (num != 0)
				{
				}
				num = (short)1224150958;
				short num3 = num;
				num = (short)1686507438;
				switch (num3 == num)
				{
				}
				num = (short)2032992256;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.Editable;
			}
			set
			{
				short num = (short)599654400;
				short num2 = num;
				num = (short)268756260;
				short num3 = num;
				num = (short)2080171300;
				switch (num3 == num)
				{
				}
				num = (short)1552678912;
				if (num != 0)
				{
				}
				num = (short)55508993;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.Editable = value;
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x00109F60 File Offset: 0x00108160
		internal string TrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971_UILabel
		{
			get
			{
				short num = (short)1701314560;
				short num2 = num;
				num = (short)1648244388;
				short num3 = num;
				num = (short)1236743844;
				switch (num3 == num)
				{
				}
				num = (short)2125529089;
				if (num != 0)
				{
				}
				num = (short)944439296;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.UIName;
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06001137 RID: 4407 RVA: 0x0010A014 File Offset: 0x00108214
		// (set) Token: 0x06001138 RID: 4408 RVA: 0x0010A0C8 File Offset: 0x001082C8
		internal bool TrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971_HiddenStatic
		{
			get
			{
				short num = (short)633995264;
				short num2 = num;
				num = (short)1748139797;
				short num3 = num;
				num = (short)610631445;
				switch (num3 == num)
				{
				}
				num = (short)345636864;
				if (num != 0)
				{
				}
				num = (short)1715732481;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.HiddenStatic;
			}
			set
			{
				short num = (short)1781006336;
				short num2 = num;
				num = (short)1509684947;
				short num3 = num;
				num = (short)29619923;
				switch (num3 == num)
				{
				}
				num = (short)1386872833;
				if (num != 0)
				{
				}
				num = (short)910360576;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.HiddenStatic = value;
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06001139 RID: 4409 RVA: 0x0010A180 File Offset: 0x00108380
		// (set) Token: 0x0600113A RID: 4410 RVA: 0x0010A234 File Offset: 0x00108434
		internal bool TrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971_HiddenDynamic
		{
			get
			{
				short num = (short)190054400;
				short num2 = num;
				num = (short)1358418326;
				short num3 = num;
				num = (short)1173737878;
				switch (num3 == num)
				{
				}
				num = (short)2121793537;
				if (num != 0)
				{
				}
				num = (short)86310912;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.HiddenDynamic;
			}
			set
			{
				short num = (short)2116288512;
				short num2 = num;
				num = (short)1846310962;
				short num3 = num;
				num = (short)440825906;
				switch (num3 == num)
				{
				}
				num = (short)1397096449;
				if (num != 0)
				{
				}
				num = (short)1344602112;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.HiddenDynamic = value;
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x0600113B RID: 4411 RVA: 0x0010A2EC File Offset: 0x001084EC
		public bool TrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971_HasDiffs
		{
			get
			{
				short num = (short)1737818112;
				short num2 = num;
				num = (short)168509475;
				short num3 = num;
				num = (short)824131619;
				switch (num3 == num)
				{
				}
				num = (short)1752039425;
				if (num != 0)
				{
				}
				num = (short)925827072;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971._HasDiffs;
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x0010A3A0 File Offset: 0x001085A0
		// (set) Token: 0x0600113D RID: 4413 RVA: 0x0010A454 File Offset: 0x00108654
		public int TrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972Value
		{
			get
			{
				short num = (short)1300299776;
				short num2 = num;
				num = (short)707176708;
				short num3 = num;
				num = (short)2046404868;
				switch (num3 == num)
				{
				}
				num = (short)1342832640;
				if (num != 0)
				{
				}
				num = (short)1370095617;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.Value;
			}
			set
			{
				short num = (short)1040646144;
				short num2 = num;
				num = (short)158906972;
				short num3 = num;
				num = (short)1826929244;
				switch (num3 == num)
				{
				}
				num = (short)558825473;
				if (num != 0)
				{
				}
				num = (short)635240448;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.Value = value;
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x0600113E RID: 4414 RVA: 0x0010A50C File Offset: 0x0010870C
		// (set) Token: 0x0600113F RID: 4415 RVA: 0x0010A5C4 File Offset: 0x001087C4
		public string TrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972_UIValue
		{
			get
			{
				short num = (short)823525376;
				short num2 = num;
				num = (short)911690355;
				short num3 = num;
				num = (short)559499891;
				switch (num3 == num)
				{
				}
				num = (short)931725312;
				if (num != 0)
				{
				}
				num = (short)1326186497;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.UIValue;
			}
			set
			{
				short num = (short)896335872;
				short num2 = num;
				num = (short)1188473091;
				short num3 = num;
				num = (short)1179822339;
				switch (num3 == num)
				{
				}
				num = (short)1582366721;
				if (num != 0)
				{
				}
				num = (short)1155923968;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.UIValue = value;
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06001140 RID: 4416 RVA: 0x0010A67C File Offset: 0x0010887C
		public global::AcpBusinessLayer.AcpRecRefField TrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972
		{
			get
			{
				short num = (short)1622802432;
				short num2 = num;
				num = (short)103052698;
				short num3 = num;
				num = (short)414021018;
				switch (num3 == num)
				{
				}
				num = (short)605290497;
				if (num != 0)
				{
				}
				num = (short)566951936;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972;
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001141 RID: 4417 RVA: 0x0010A728 File Offset: 0x00108928
		// (set) Token: 0x06001142 RID: 4418 RVA: 0x0010A7DC File Offset: 0x001089DC
		public bool TrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972_Applicable
		{
			get
			{
				short num = (short)755630080;
				short num2 = num;
				num = (short)647926330;
				short num3 = num;
				num = (short)35361338;
				switch (num3 == num)
				{
				}
				num = (short)1481965569;
				if (num != 0)
				{
				}
				num = (short)655228928;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.Applicable;
			}
			set
			{
				short num = (short)407764992;
				short num2 = num;
				num = (short)699400974;
				short num3 = num;
				num = (short)1366491918;
				switch (num3 == num)
				{
				}
				num = (short)1895497729;
				if (num != 0)
				{
				}
				num = (short)1765343232;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.Applicable = value;
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001143 RID: 4419 RVA: 0x0010A894 File Offset: 0x00108A94
		// (set) Token: 0x06001144 RID: 4420 RVA: 0x0010A948 File Offset: 0x00108B48
		public bool TrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972_Valid
		{
			get
			{
				short num = (short)683212800;
				short num2 = num;
				num = (short)2038802113;
				short num3 = num;
				num = (short)480356033;
				switch (num3 == num)
				{
				}
				num = (short)540540929;
				if (num != 0)
				{
				}
				num = (short)1433468928;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.Valid;
			}
			set
			{
				short num = (short)1260781568;
				short num2 = num;
				num = (short)2002792904;
				short num3 = num;
				num = (short)1457336776;
				switch (num3 == num)
				{
				}
				num = (short)463273985;
				if (num != 0)
				{
				}
				num = (short)874381312;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.Valid = value;
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001145 RID: 4421 RVA: 0x0010A9FC File Offset: 0x00108BFC
		// (set) Token: 0x06001146 RID: 4422 RVA: 0x0010AAB4 File Offset: 0x00108CB4
		public bool TrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972_Visible
		{
			get
			{
				short num = (short)1668481024;
				short num2 = num;
				num = (short)1132582373;
				short num3 = num;
				num = (short)982242789;
				switch (num3 == num)
				{
				}
				num = (short)1260388352;
				if (num != 0)
				{
				}
				num = (short)1375272961;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.Visible;
			}
			set
			{
				short num = (short)103809024;
				short num2 = num;
				num = (short)1758444783;
				short num3 = num;
				num = (short)457161967;
				switch (num3 == num)
				{
				}
				num = (short)184287233;
				if (num != 0)
				{
				}
				num = (short)1069023232;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.Visible = value;
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06001147 RID: 4423 RVA: 0x0010AB68 File Offset: 0x00108D68
		// (set) Token: 0x06001148 RID: 4424 RVA: 0x0010AC1C File Offset: 0x00108E1C
		public bool TrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972_Editable
		{
			get
			{
				short num = (short)309657600;
				short num2 = num;
				num = (short)16295177;
				short num3 = num;
				num = (short)1083614473;
				switch (num3 == num)
				{
				}
				num = (short)1489567745;
				if (num != 0)
				{
				}
				num = (short)1037172736;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.Editable;
			}
			set
			{
				short num = (short)2058158080;
				short num2 = num;
				num = (short)1183383553;
				if (num != 0)
				{
				}
				num = (short)941586287;
				short num3 = num;
				num = (short)1863743343;
				switch (num3 == num)
				{
				}
				num = (short)1480130560;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.Editable = value;
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x0010ACD0 File Offset: 0x00108ED0
		internal string TrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972_UILabel
		{
			get
			{
				short num = (short)6619136;
				short num2 = num;
				num = (short)799368552;
				short num3 = num;
				num = (short)1302947176;
				switch (num3 == num)
				{
				}
				num = (short)1839267840;
				if (num != 0)
				{
				}
				num = (short)1432289281;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.UIName;
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x0010AD88 File Offset: 0x00108F88
		// (set) Token: 0x0600114B RID: 4427 RVA: 0x0010AE40 File Offset: 0x00109040
		internal bool TrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972_HiddenStatic
		{
			get
			{
				short num = (short)202440704;
				short num2 = num;
				num = (short)395640833;
				if (num != 0)
				{
				}
				num = (short)1251692385;
				short num3 = num;
				num = (short)1657360225;
				switch (num3 == num)
				{
				}
				num = (short)1505361920;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.HiddenStatic;
			}
			set
			{
				short num = (short)816316416;
				short num2 = num;
				num = (short)803123288;
				short num3 = num;
				num = (short)794407000;
				switch (num3 == num)
				{
				}
				num = (short)855572481;
				if (num != 0)
				{
				}
				num = (short)496435200;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.HiddenStatic = value;
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x0010AEF4 File Offset: 0x001090F4
		// (set) Token: 0x0600114D RID: 4429 RVA: 0x0010AFA8 File Offset: 0x001091A8
		internal bool TrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972_HiddenDynamic
		{
			get
			{
				short num = (short)353566720;
				short num2 = num;
				num = (short)2120242500;
				short num3 = num;
				num = (short)744510788;
				switch (num3 == num)
				{
				}
				num = (short)1094385664;
				if (num != 0)
				{
				}
				num = (short)233177089;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.HiddenDynamic;
			}
			set
			{
				short num = (short)626655232;
				short num2 = num;
				num = (short)1952468426;
				short num3 = num;
				num = (short)1741508042;
				switch (num3 == num)
				{
				}
				num = (short)794165249;
				if (num != 0)
				{
				}
				num = (short)1731264512;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.HiddenDynamic = value;
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x0010B064 File Offset: 0x00109264
		public bool TrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972_HasDiffs
		{
			get
			{
				short num = (short)1580269568;
				short num2 = num;
				num = (short)782236678;
				short num3 = num;
				num = (short)1910504454;
				switch (num3 == num)
				{
				}
				num = (short)426835969;
				if (num != 0)
				{
				}
				num = (short)1615200256;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972._HasDiffs;
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x0600114F RID: 4431 RVA: 0x0010B118 File Offset: 0x00109318
		// (set) Token: 0x06001150 RID: 4432 RVA: 0x0010B1CC File Offset: 0x001093CC
		public int TrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633Value
		{
			get
			{
				short num = (short)1008795648;
				short num2 = num;
				num = (short)1509995749;
				short num3 = num;
				num = (short)279491813;
				switch (num3 == num)
				{
				}
				num = (short)1614020608;
				if (num != 0)
				{
				}
				num = (short)949878785;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.Value;
			}
			set
			{
				short num = (short)660733952;
				short num2 = num;
				num = (short)1686416258;
				short num3 = num;
				num = (short)1372433282;
				switch (num3 == num)
				{
				}
				num = (short)522715137;
				if (num != 0)
				{
				}
				num = (short)550633472;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.Value = value;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06001151 RID: 4433 RVA: 0x0010B280 File Offset: 0x00109480
		// (set) Token: 0x06001152 RID: 4434 RVA: 0x0010B338 File Offset: 0x00109538
		public string TrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633_UIValue
		{
			get
			{
				short num = (short)426967040;
				short num2 = num;
				num = (short)1667600995;
				short num3 = num;
				num = (short)1072206435;
				switch (num3 == num)
				{
				}
				num = (short)1889468417;
				if (num != 0)
				{
				}
				num = (short)1381564416;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.UIValue;
			}
			set
			{
				short num = (short)305397760;
				short num2 = num;
				num = (short)109976299;
				short num3 = num;
				num = (short)2140150507;
				switch (num3 == num)
				{
				}
				num = (short)1095172096;
				if (num != 0)
				{
				}
				num = (short)991559681;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.UIValue = value;
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06001153 RID: 4435 RVA: 0x0010B3F0 File Offset: 0x001095F0
		public global::AcpBusinessLayer.AcpRecRefField TrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633
		{
			get
			{
				short num = (short)1804206080;
				short num2 = num;
				num = (short)907957931;
				short num3 = num;
				num = (short)1759729323;
				switch (num3 == num)
				{
				}
				num = (short)1764687873;
				if (num != 0)
				{
				}
				num = (short)550371328;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x0010B4A0 File Offset: 0x001096A0
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x0010B554 File Offset: 0x00109754
		public bool TrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633_Applicable
		{
			get
			{
				short num = (short)1224081408;
				short num2 = num;
				num = (short)1498873049;
				short num3 = num;
				num = (short)1498545369;
				switch (num3 == num)
				{
				}
				num = (short)1530593281;
				if (num != 0)
				{
				}
				num = (short)1166475264;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.Applicable;
			}
			set
			{
				short num = (short)1365966848;
				short num2 = num;
				num = (short)1282473985;
				if (num != 0)
				{
				}
				num = (short)1890804088;
				short num3 = num;
				num = (short)818438520;
				switch (num3 == num)
				{
				}
				num = (short)1834483712;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.Applicable = value;
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x0010B60C File Offset: 0x0010980C
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x0010B6C4 File Offset: 0x001098C4
		public bool TrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633_Valid
		{
			get
			{
				short num = (short)1228931072;
				short num2 = num;
				num = (short)433904938;
				short num3 = num;
				num = (short)1536810282;
				switch (num3 == num)
				{
				}
				num = (short)4325376;
				if (num != 0)
				{
				}
				num = (short)1349844993;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.Valid;
			}
			set
			{
				short num = (short)1313406976;
				short num2 = num;
				num = (short)1561073961;
				short num3 = num;
				num = (short)1009457449;
				switch (num3 == num)
				{
				}
				num = (short)1721434113;
				if (num != 0)
				{
				}
				num = (short)287965184;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.Valid = value;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x0010B77C File Offset: 0x0010997C
		// (set) Token: 0x06001159 RID: 4441 RVA: 0x0010B830 File Offset: 0x00109A30
		public bool TrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633_Visible
		{
			get
			{
				short num = (short)1952907264;
				short num2 = num;
				num = (short)989413909;
				short num3 = num;
				num = (short)1853243925;
				switch (num3 == num)
				{
				}
				num = (short)893452288;
				if (num != 0)
				{
				}
				num = (short)1959591937;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.Visible;
			}
			set
			{
				short num = (short)1948123136;
				short num2 = num;
				num = (short)1164185046;
				short num3 = num;
				num = (short)1835666902;
				switch (num3 == num)
				{
				}
				num = (short)1716322305;
				if (num != 0)
				{
				}
				num = (short)1117257728;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.Visible = value;
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x0010B8E8 File Offset: 0x00109AE8
		// (set) Token: 0x0600115B RID: 4443 RVA: 0x0010B99C File Offset: 0x00109B9C
		public bool TrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633_Editable
		{
			get
			{
				short num = (short)2013069312;
				short num2 = num;
				num = (short)2000774251;
				short num3 = num;
				num = (short)1835623531;
				switch (num3 == num)
				{
				}
				num = (short)1209729024;
				if (num != 0)
				{
				}
				num = (short)414908417;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.Editable;
			}
			set
			{
				short num = (short)1022492672;
				short num2 = num;
				num = (short)100204545;
				if (num != 0)
				{
				}
				num = (short)2001637383;
				short num3 = num;
				num = (short)470126599;
				switch (num3 == num)
				{
				}
				num = (short)320602112;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.Editable = value;
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x0600115C RID: 4444 RVA: 0x0010BA50 File Offset: 0x00109C50
		internal string TrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633_UILabel
		{
			get
			{
				short num = (short)781320192;
				short num2 = num;
				num = (short)479133697;
				if (num != 0)
				{
				}
				num = (short)936379043;
				short num3 = num;
				num = (short)1589510819;
				switch (num3 == num)
				{
				}
				num = (short)1814757376;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.UIName;
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x0010BB04 File Offset: 0x00109D04
		// (set) Token: 0x0600115E RID: 4446 RVA: 0x0010BBBC File Offset: 0x00109DBC
		internal bool TrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633_HiddenStatic
		{
			get
			{
				short num = (short)445186048;
				short num2 = num;
				num = (short)352690800;
				short num3 = num;
				num = (short)927179376;
				switch (num3 == num)
				{
				}
				num = (short)254672897;
				if (num != 0)
				{
				}
				num = (short)230752256;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.HiddenStatic;
			}
			set
			{
				short num = (short)1639579648;
				short num2 = num;
				num = (short)199557121;
				if (num != 0)
				{
				}
				num = (short)1674932229;
				short num3 = num;
				num = (short)1125675013;
				switch (num3 == num)
				{
				}
				num = (short)778174464;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.HiddenStatic = value;
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x0010BC74 File Offset: 0x00109E74
		// (set) Token: 0x06001160 RID: 4448 RVA: 0x0010BD28 File Offset: 0x00109F28
		internal bool TrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633_HiddenDynamic
		{
			get
			{
				short num = (short)199032832;
				short num2 = num;
				num = (short)1775632385;
				if (num != 0)
				{
				}
				num = (short)1513359467;
				short num3 = num;
				num = (short)1350174827;
				switch (num3 == num)
				{
				}
				num = (short)1968898048;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.HiddenDynamic;
			}
			set
			{
				short num = (short)1867972608;
				short num2 = num;
				num = (short)539045596;
				short num3 = num;
				num = (short)208875228;
				switch (num3 == num)
				{
				}
				num = (short)1869611009;
				if (num != 0)
				{
				}
				num = (short)869007360;
				if (num != 0)
				{
				}
				this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.HiddenDynamic = value;
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06001161 RID: 4449 RVA: 0x0010BDDC File Offset: 0x00109FDC
		public bool TrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633_HasDiffs
		{
			get
			{
				short num = (short)1828716544;
				short num2 = num;
				num = (short)181233948;
				short num3 = num;
				num = (short)1399613724;
				switch (num3 == num)
				{
				}
				num = (short)899088385;
				if (num != 0)
				{
				}
				num = (short)305463296;
				if (num != 0)
				{
				}
				return this.trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633._HasDiffs;
			}
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x0010BE94 File Offset: 0x0010A094
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (base.ParentRecset != null)
					{
						num2 = (short)770506756;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)945160195;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					goto IL_FD;
				case 3:
				{
					num2 = (short)1453522944;
					short num3 = num2;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1144389634;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					goto IL_A8;
				}
				goto IL_24;
			}
			IL_FD:
			num2 = (short)1622474753;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			num2 = (short)1773717786;
			short num4 = num2;
			num2 = (short)1664600346;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_A8:
				num2 = (short)442499073;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)323485696;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)71892992;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x04000435 RID: 1077
		private global::AcpBusinessLayer.AcpRecRefField trkSysLabtoolTrunkingSystemControlChannelListItemID_A19964;

		// Token: 0x04000436 RID: 1078
		private global::AcpBusinessLayer.AcpRecRefField trkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965;

		// Token: 0x04000437 RID: 1079
		private global::AcpBusinessLayer.AcpRecRefField trkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966;

		// Token: 0x04000438 RID: 1080
		private global::AcpBusinessLayer.AcpRecRefField trkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967;

		// Token: 0x04000439 RID: 1081
		private global::AcpBusinessLayer.AcpRecRefField trkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968;

		// Token: 0x0400043A RID: 1082
		private global::AcpBusinessLayer.AcpRecRefField trkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969;

		// Token: 0x0400043B RID: 1083
		private global::AcpBusinessLayer.AcpRecRefField trkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970;

		// Token: 0x0400043C RID: 1084
		private global::AcpBusinessLayer.AcpRecRefField trkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971;

		// Token: 0x0400043D RID: 1085
		private global::AcpBusinessLayer.AcpRecRefField trkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972;

		// Token: 0x0400043E RID: 1086
		private global::AcpBusinessLayer.AcpRecRefField trkSysLabtoolTrunkingSystemOneTouchListItemID_A22633;
	}
}
