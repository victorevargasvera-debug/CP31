using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories
{
	// Token: 0x0200030A RID: 778
	[global::System.Serializable]
	public class DataButtonInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007B64 RID: 31588 RVA: 0x00711470 File Offset: 0x0070F670
		public DataButtonInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06007B65 RID: 31589 RVA: 0x0071148C File Offset: 0x0070F68C
		protected DataButtonInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007B66 RID: 31590 RVA: 0x007114A4 File Offset: 0x0070F6A4
		public override void Init()
		{
			int a_ = 19;
			short num = (short)2109050547;
			short num2 = num;
			num = (short)1118146227;
			switch (num2 == num)
			{
			}
			num = (short)181075968;
			short num3 = num;
			num = (short)1423900672;
			if (num != 0)
			{
			}
			num = (short)1115226113;
			if (num != 0)
			{
			}
			this.radErgoCfgKMDataButtonKey_A22600 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("蛓럕볗鿙껛망迟ꇡ苣臥ꏧ꟩꣫迭蓯鏱뛳菵賷軹鏻都䯿朁紃夅䤇㠉㸋㠍‏∑", a_), global::CommonResources.AcgResources.ID_KEY, 20);
			this.radErgoCfgKMDataButtonKey_A22600.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgKMDataButtonKey_A22600.DataTransferOrder = -1;
			this.radErgoCfgKMDataButtonName_A22601 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_DATABUTTON_1, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗鿙껛망迟ꇡ苣臥ꏧ꟩꣫迭蓯鏱뛳菵賷軹鏻都仿持椃挅圇䬉㸋㰍☏∑┓", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.radErgoCfgKMDataButtonName_A22601.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgKMDataButtonName_A22601.DataTransferOrder = -1;
			this.radErgoCfgKMConventionalKMDataButtonBCO_A22602 = new global::AcpBusinessLayer.AcpSparseLOVField(134, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.indexRadErgoCfgKMConventionalKMDataButtonBCO_A22602LovStrs, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.idRadErgoCfgKMConventionalKMDataButtonBCO_A22602LovStrs), this, global::AllFeatures.CodeplugGuid.b("蛓럕볗鿙껛망迟ꇡ苣臥ꏧ꟩꿫臭黯蓱釳飵賷鏹鏻都懿渁伃䬅䰇欉砋漍刏朑怓戕眗琙帛崝漟紡攣ᐥᨧᰩᰫᰭ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBCO, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.RadErgoCfgKMConventionalKMDataButtonBCO_A22602LovStrs);
			this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.DataTransferOrder = -1;
			this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603 = new global::AcpBusinessLayer.AcpSparseLOVField(161, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.indexRadErgoCfgKMConventionalKMDatatButtonFeature_A22603LovStrs, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.idRadErgoCfgKMConventionalKMDatatButtonFeature_A22603LovStrs), this, global::AllFeatures.CodeplugGuid.b("蛓럕볗鿙껛망迟ꇡ苣臥ꏧ꟩꿫臭黯蓱釳飵賷鏹鏻都懿渁伃䬅䰇欉砋漍搏們愓戕気甙爛堝䔟䌡倣匥娧伩猫漭ȯ1ȳصଷ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603LovStrs);
			this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.DataTransferOrder = 8;
			this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604 = new global::AcpBusinessLayer.AcpSparseLOVField(134, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.indexRadErgoCfgKMTrunkingKMDataButtonBCO_A22604LovStrs, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.idRadErgoCfgKMTrunkingKMDataButtonBCO_A22604LovStrs), this, global::AllFeatures.CodeplugGuid.b("蛓럕볗鿙껛망迟ꇡ苣臥ꏧ꟩룫鳭藯鳱鿳鿵雷鷹럻돽䓿持瀃朅䨇缉砋稍缏簑嘓唕圗䔙崛Ⱍሟᐡᐣሥ", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.RadErgoCfgKMTrunkingKMDataButtonBCO_A22604LovStrs);
			this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.DataTransferOrder = -1;
			this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605 = new global::AcpBusinessLayer.AcpSparseLOVField(161, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.indexRadErgoCfgKMTrunkingKMDatatButtonFeature_A22605LovStrs, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.idRadErgoCfgKMTrunkingKMDatatButtonFeature_A22605LovStrs), this, global::AllFeatures.CodeplugGuid.b("蛓럕볗鿙껛망迟ꇡ苣臥ꏧ꟩룫鳭藯鳱鿳鿵雷鷹럻돽䓿持瀃朅簇䠉礋稍搏紑稓倕紗笙栛欝刟䜡笣朥ᨧᠩᨫḭԯ", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605LovStrs);
			this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.DataTransferOrder = 10;
			this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蛓럕볗鿙껛망迟ꇡ苣臥ꏧ꟩꿫臭黯蓱釳飵賷鏹鏻都懿渁伃䬅䰇欉砋漍搏們愓戕気甙爛圝丟䘡䄣帥眧欩ᠫἭЯ1ܳ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALINDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.DataTransferOrder = 9;
			this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("蛓럕볗鿙껛망迟ꇡ苣臥ꏧ꟩룫鳭藯鳱鿳鿵雷鷹럻돽䓿持瀃朅簇䠉礋稍搏紑稓引瘗縙礛昝缟挡ဣᜥᰧᠩᠫ", a_), global::CommonResources.AcgResources.ID_TRUNKINGINDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.DataTransferOrder = 11;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鿓蛕闗龎飛뿝铟菡쓣ꓥ鷧黩飫臭黯", a_);
			base.Id = 10209;
			base.UIName = global::CommonResources.AcgResources.ID_KPMDATABUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007B67 RID: 31591 RVA: 0x007117DC File Offset: 0x0070F9DC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 1;
			short num = (short)1590493209;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_34B;
				case 1:
					goto IL_521;
				case 2:
					goto IL_18A;
				case 3:
					num = (short)1938161683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604 = new global::AcpBusinessLayer.AcpSparseLOVField(134, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.indexRadErgoCfgKMTrunkingKMDataButtonBCO_A22604LovStrs, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.idRadErgoCfgKMTrunkingKMDataButtonBCO_A22604LovStrs), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓鷕闗軙껛ꯝ軟觡跣裥迧ꇩꇫꫭ釯蛱闳듵跷軹裻釽滿䀁䜃䤅圇䬉㸋㰍☏∑–", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.RadErgoCfgKMTrunkingKMDataButtonBCO_A22604LovStrs);
					this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.DataTransferOrder = -1;
					num = (short)1386151953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓鷕闗駙돛냝雟蟡諣鋥臧藩苫迭鳯맱맳답駷軹鷻諽䋿省瀃爅朇搉䔋怍琏眑氓䤕夗⸙ⴛ⨝ሟᄡ", a_)))
					{
						num = (short)594739206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2FC;
				case 6:
					this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓鷕闗駙돛냝雟蟡諣鋥臧藩苫迭鳯맱맳답駷軹鷻諽䋿省瀃爅朇搉䔋怍琏眑氓䤕夗⸙ⴛ⨝ሟᄡ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALINDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.DataTransferOrder = 9;
					num = (short)968687627;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_3F4;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓鷕闗軙껛ꯝ軟觡跣裥迧ꇩꇫꫭ釯蛱闳苵뫷迹裻諽濿氁䈃挅椇縉礋簍甏䴑唓␕⨗ⰙⰛ⬝", a_)))
					{
						num = (short)1532035085;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3F4;
				case 9:
					this.radErgoCfgKMDataButtonKey_A22600 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓鷕闗黙뷛ꫝ臟ꃡ釣鋥鳧藩苫ꗭ闯诱꯳럵쫷죹쫻컽ヿ", a_), global::CommonResources.AcgResources.ID_KEY, 20);
					this.radErgoCfgKMDataButtonKey_A22600.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgKMDataButtonKey_A22600.DataTransferOrder = -1;
					num = (short)1650524162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓鷕闗駙돛냝雟蟡諣鋥臧藩苫迭鳯맱맳답駷軹鷻諽䋿省瀃爅朇搉䨋欍焏昑愓搕紗䔙崛Ⱍሟᐡᐣᔥ", a_)))
					{
						num = (short)714211352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13D;
				case 11:
					goto IL_2FC;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓鷕闗黙뷛ꫝ臟ꃡ釣鋥鳧藩苫ꃭ釯鿱釳꧵맷죹컻죽ヿ㌁", a_)))
					{
						num = (short)1786576922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_521;
				case 13:
					this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605 = new global::AcpBusinessLayer.AcpSparseLOVField(161, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.indexRadErgoCfgKMTrunkingKMDatatButtonFeature_A22605LovStrs, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.idRadErgoCfgKMTrunkingKMDatatButtonFeature_A22605LovStrs), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓鷕闗軙껛ꯝ軟觡跣裥迧ꇩꇫꫭ釯蛱闳苵뫷迹裻諽濿氁䈃挅椇縉礋簍甏䴑唓␕⨗ⰙⰛ⬝", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605LovStrs);
					this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.DataTransferOrder = 10;
					num = (short)469827591;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_51C;
				case 15:
					num = (short)1682046977;
					if (num != 0)
					{
					}
					this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓鷕闗軙껛ꯝ軟觡跣裥迧ꇩꇫꫭ釯蛱闳苵뫷迹裻諽濿氁䴃栅氇漉琋儍儏☑┓∕⨗⸙", a_), global::CommonResources.AcgResources.ID_TRUNKINGINDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.DataTransferOrder = 11;
					num = (short)769589262;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (producerFields != null)
					{
						num = (short)119799811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_745;
				case 17:
					goto IL_C4;
				case 18:
					this.radErgoCfgKMConventionalKMDataButtonBCO_A22602 = new global::AcpBusinessLayer.AcpSparseLOVField(134, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.indexRadErgoCfgKMConventionalKMDataButtonBCO_A22602LovStrs, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.idRadErgoCfgKMConventionalKMDataButtonBCO_A22602LovStrs), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓鷕闗駙돛냝雟蟡諣鋥臧藩苫迭鳯맱맳답駷軹鷻볽痿瘁瀃椅昇䠉伋䄍伏匑☓␕⸗⨙⸛", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBCO, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.RadErgoCfgKMConventionalKMDataButtonBCO_A22602LovStrs);
					this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.DataTransferOrder = -1;
					num = (short)1135607808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓鷕闗黙뷛ꫝ臟ꃡ釣鋥鳧藩苫ꗭ闯诱꯳럵쫷죹쫻컽ヿ", a_)))
					{
						num = (short)48168969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18A;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓鷕闗軙껛ꯝ軟觡跣裥迧ꇩꇫꫭ釯蛱闳苵뫷迹裻諽濿氁䴃栅氇漉琋儍儏☑┓∕⨗⸙", a_)))
					{
						num = (short)1519845391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_745;
				case 21:
					num = (short)1129512976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓鷕闗駙돛냝雟蟡諣鋥臧藩苫迭鳯맱맳답駷軹鷻볽痿瘁瀃椅昇䠉伋䄍伏匑☓␕⸗⨙⸛", a_)))
					{
						num = (short)602996754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_34B;
				case 23:
					goto IL_13D;
				case 24:
					goto IL_66C;
				case 25:
					switch (0)
					{
					case 0:
						goto IL_9D;
					}
					continue;
				case 26:
					this.radErgoCfgKMDataButtonName_A22601 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_DATABUTTON_1, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓鷕闗黙뷛ꫝ臟ꃡ釣鋥鳧藩苫ꃭ釯鿱釳꧵맷죹컻죽ヿ㌁", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.radErgoCfgKMDataButtonName_A22601.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgKMDataButtonName_A22601.DataTransferOrder = -1;
					num = (short)675414017;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓鷕闗軙껛ꯝ軟觡跣裥迧ꇩꇫꫭ釯蛱闳듵跷軹裻釽滿䀁䜃䤅圇䬉㸋㰍☏∑–", a_)))
					{
						num = (short)784269316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C4;
				}
				IL_9D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1332543509;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_C4:
				num = (short)1489305600;
				short num3 = num;
				num = (short)1621491720;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_13D:
				num = (short)1392181275;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_18A:
				num = (short)1216610316;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2FC:
				num = (short)1165819924;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_34B:
				num = (short)196214794;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3F4:
				num = (short)568692142;
				short num4 = num;
				num = (short)1802800558;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_66C:
					this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603 = new global::AcpBusinessLayer.AcpSparseLOVField(161, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.indexRadErgoCfgKMConventionalKMDatatButtonFeature_A22603LovStrs, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.idRadErgoCfgKMConventionalKMDatatButtonFeature_A22603LovStrs), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ跇룉ꯋꇍ鏏듑돓鷕闗駙돛냝雟蟡諣鋥臧藩苫迭鳯맱맳답駷軹鷻諽䋿省瀃爅朇搉䨋欍焏昑愓搕紗䔙崛Ⱍሟᐡᐣᔥ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603LovStrs);
					this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.DataTransferOrder = 8;
					num = (short)1437073431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
					num = (short)1471545344;
					if (num != 0)
					{
					}
					num = (short)1649475589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_521:
				num = (short)1978859542;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_51C:
			IL_745:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("见铃诅軉귋뫍뇏雓ꏕ곗껙돛냝", a_);
			base.Id = 10209;
			base.UIName = global::CommonResources.AcgResources.ID_KPMDATABUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007B68 RID: 31592 RVA: 0x00711F60 File Offset: 0x00710160
		public override void PopulateReferences()
		{
			short num = (short)711393281;
			if (num != 0)
			{
			}
			num = (short)170524672;
			short num2 = num;
			num = (short)918585118;
			short num3 = num;
			num = (short)1388740382;
			switch (num3 == num)
			{
			}
			num = (short)1700593664;
			if (num != 0)
			{
			}
			this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.SetRecset(this.a(4008));
			this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.SetRecset(this.a(4008));
		}

		// Token: 0x06007B69 RID: 31593 RVA: 0x00712034 File Offset: 0x00710234
		public override void DropReferences()
		{
			short num = (short)133674096;
			short num2 = num;
			num = (short)1760801904;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1984364544;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1953955840;
			if (num != 0)
			{
			}
			num = (short)2111635457;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007B6A RID: 31594 RVA: 0x007120DC File Offset: 0x007102DC
		public override void SetConstraints()
		{
			short num = (short)827954841;
			short num2 = num;
			num = (short)16291481;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2062876672;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1127284737;
			if (num != 0)
			{
			}
			num = (short)923009024;
			if (num != 0)
			{
			}
			this.radErgoCfgKMDataButtonName_A22601.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.conDataBtnConvFeatureValid);
			this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.ConSyncCnvDataBtnFeature);
			this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.conDataBtnTrkFeatureValid);
			this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.ConSyncTrkDataBtnFeature);
			this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.ConKPMDataButtonConvIndexApplicable);
			this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.ConDataButtonIndexValid);
			this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.ConValueSetIfDataCnvIndexChanged);
			this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.ConKPMDataButtonTrkIndexApplicable);
			this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.ConDataButtonIndexValid);
			this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.ConValueSetIfDataTrkIndexChanged);
		}

		// Token: 0x06007B6B RID: 31595 RVA: 0x00712284 File Offset: 0x00710484
		public override void SetupDependencies()
		{
			short num = (short)869292379;
			short num2 = num;
			num = (short)419649883;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1272840192;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)154992641;
			if (num != 0)
			{
			}
			num = (short)420741120;
			if (num != 0)
			{
			}
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605);
			this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.AddDependentObject(this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423);
			this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.AddDependentObject(this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424);
		}

		// Token: 0x17003F41 RID: 16193
		// (get) Token: 0x06007B6C RID: 31596 RVA: 0x00712388 File Offset: 0x00710588
		public global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation ActionConsolidationForRadErgoCfgKMConventionalKMDatatButtonIndex_A41423
		{
			get
			{
				short num = (short)626119311;
				short num2 = num;
				num = (short)61592207;
				switch (num2 == num)
				{
				default:
				{
					num = (short)799473664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1649082369;
				if (num != 0)
				{
				}
				num = (short)1713766400;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation;
			}
		}

		// Token: 0x17003F42 RID: 16194
		// (get) Token: 0x06007B6D RID: 31597 RVA: 0x00712440 File Offset: 0x00710640
		public global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation ActionConsolidationForRadErgoCfgKMTrunkingKMDatatButtonIndex_A41424
		{
			get
			{
				short num = (short)1098296212;
				short num2 = num;
				num = (short)58305428;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1172897792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)710737921;
				if (num != 0)
				{
				}
				num = (short)1392967680;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation;
			}
		}

		// Token: 0x17003F43 RID: 16195
		// (get) Token: 0x06007B6E RID: 31598 RVA: 0x007124F8 File Offset: 0x007106F8
		public bool HasDiffs
		{
			get
			{
				short num = (short)591061498;
				short num2 = num;
				num = (short)1034740218;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1961033728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)428277761;
				if (num != 0)
				{
				}
				num = (short)547028992;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003F44 RID: 16196
		// (get) Token: 0x06007B6F RID: 31599 RVA: 0x007125A8 File Offset: 0x007107A8
		// (set) Token: 0x06007B70 RID: 31600 RVA: 0x0071265C File Offset: 0x0071085C
		public string RadErgoCfgKMDataButtonKey_A22600Value
		{
			get
			{
				short num = (short)1564588963;
				short num2 = num;
				num = (short)1646115747;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1453064192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1942224897;
				if (num != 0)
				{
				}
				num = (short)2088435712;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMDataButtonKey_A22600.Value;
			}
			set
			{
				short num = (short)2076377088;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)242065110;
					short num3 = num;
					num = (short)2100600534;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)485556225;
						if (num != 0)
						{
						}
						num = (short)28442624;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_A3;
							}
							continue;
						case 1:
							return;
						case 2:
						{
							num = (short)1990656000;
							short num4 = num;
							this.radErgoCfgKMDataButtonKey_A22600.Value = value;
							num = (short)2047934465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_A3:
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)1223491586;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x17003F45 RID: 16197
		// (get) Token: 0x06007B71 RID: 31601 RVA: 0x00712780 File Offset: 0x00710980
		// (set) Token: 0x06007B72 RID: 31602 RVA: 0x00712838 File Offset: 0x00710A38
		public string RadErgoCfgKMDataButtonKey_A22600_UIValue
		{
			get
			{
				short num = (short)2046508820;
				short num2 = num;
				num = (short)1739407124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)941752320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1236926465;
				if (num != 0)
				{
				}
				num = (short)667484160;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMDataButtonKey_A22600.Value;
			}
			set
			{
				short num = (short)861339649;
				if (num != 0)
				{
				}
				num = (short)853540864;
				short num2 = num;
				num = (short)584869799;
				short num3 = num;
				num = (short)208365479;
				switch (num3 == num)
				{
				}
				num = (short)1798569984;
				if (num != 0)
				{
				}
				this.radErgoCfgKMDataButtonKey_A22600.Value = value;
			}
		}

		// Token: 0x17003F46 RID: 16198
		// (get) Token: 0x06007B73 RID: 31603 RVA: 0x007128EC File Offset: 0x00710AEC
		public global::AcpBusinessLayer.AcpKeyField RadErgoCfgKMDataButtonKey_A22600
		{
			get
			{
				short num = (short)1737001264;
				short num2 = num;
				num = (short)1555466544;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2038431744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2022834177;
				if (num != 0)
				{
				}
				num = (short)454164480;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMDataButtonKey_A22600;
			}
		}

		// Token: 0x17003F47 RID: 16199
		// (get) Token: 0x06007B74 RID: 31604 RVA: 0x0071299C File Offset: 0x00710B9C
		// (set) Token: 0x06007B75 RID: 31605 RVA: 0x00712A50 File Offset: 0x00710C50
		public bool RadErgoCfgKMDataButtonKey_A22600_Applicable
		{
			get
			{
				short num = (short)1507478040;
				short num2 = num;
				num = (short)1336101400;
				switch (num2 == num)
				{
				default:
				{
					num = (short)441712640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1643773953;
				if (num != 0)
				{
				}
				num = (short)332660736;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMDataButtonKey_A22600.Applicable;
			}
			set
			{
				short num = (short)1915883759;
				short num2 = num;
				num = (short)1626804463;
				switch (num2 == num)
				{
				default:
				{
					num = (short)631963648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)555352065;
				if (num != 0)
				{
				}
				num = (short)433979392;
				if (num != 0)
				{
				}
				this.radErgoCfgKMDataButtonKey_A22600.Applicable = value;
			}
		}

		// Token: 0x17003F48 RID: 16200
		// (get) Token: 0x06007B76 RID: 31606 RVA: 0x00712B08 File Offset: 0x00710D08
		// (set) Token: 0x06007B77 RID: 31607 RVA: 0x00712BBC File Offset: 0x00710DBC
		public bool RadErgoCfgKMDataButtonKey_A22600_Valid
		{
			get
			{
				short num = (short)1118550376;
				short num2 = num;
				num = (short)696629608;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1233846272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)406257665;
				if (num != 0)
				{
				}
				num = (short)2138112000;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMDataButtonKey_A22600.Valid;
			}
			set
			{
				short num = (short)1966669825;
				if (num != 0)
				{
				}
				num = (short)760872960;
				short num2 = num;
				num = (short)1878777790;
				short num3 = num;
				num = (short)916053950;
				switch (num3 == num)
				{
				}
				num = (short)641794048;
				if (num != 0)
				{
				}
				this.radErgoCfgKMDataButtonKey_A22600.Valid = value;
			}
		}

		// Token: 0x17003F49 RID: 16201
		// (get) Token: 0x06007B78 RID: 31608 RVA: 0x00712C74 File Offset: 0x00710E74
		// (set) Token: 0x06007B79 RID: 31609 RVA: 0x00712D2C File Offset: 0x00710F2C
		public bool RadErgoCfgKMDataButtonKey_A22600_Visible
		{
			get
			{
				short num = (short)640142857;
				short num2 = num;
				num = (short)894815753;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1069678592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2094202880;
				if (num != 0)
				{
				}
				num = (short)1176502273;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMDataButtonKey_A22600.Visible;
			}
			set
			{
				short num = (short)22323809;
				short num2 = num;
				num = (short)933470817;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1431240704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1011286016;
				if (num != 0)
				{
				}
				num = (short)578486273;
				if (num != 0)
				{
				}
				this.radErgoCfgKMDataButtonKey_A22600.Visible = value;
			}
		}

		// Token: 0x17003F4A RID: 16202
		// (get) Token: 0x06007B7A RID: 31610 RVA: 0x00712DE4 File Offset: 0x00710FE4
		// (set) Token: 0x06007B7B RID: 31611 RVA: 0x00712E9C File Offset: 0x0071109C
		public bool RadErgoCfgKMDataButtonKey_A22600_Editable
		{
			get
			{
				short num = (short)1099108839;
				short num2 = num;
				num = (short)725881319;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1465778176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2052784129;
				if (num != 0)
				{
				}
				num = (short)1762721792;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMDataButtonKey_A22600.Editable;
			}
			set
			{
				short num = (short)982515713;
				if (num != 0)
				{
				}
				num = (short)412745728;
				short num2 = num;
				num = (short)723705742;
				short num3 = num;
				num = (short)507961230;
				switch (num3 == num)
				{
				}
				num = (short)969277440;
				if (num != 0)
				{
				}
				this.radErgoCfgKMDataButtonKey_A22600.Editable = value;
			}
		}

		// Token: 0x17003F4B RID: 16203
		// (get) Token: 0x06007B7C RID: 31612 RVA: 0x00712F50 File Offset: 0x00711150
		internal string RadErgoCfgKMDataButtonKey_A22600_UILabel
		{
			get
			{
				short num = (short)1076526510;
				short num2 = num;
				num = (short)1138916782;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2068709376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)840499201;
				if (num != 0)
				{
				}
				num = (short)1022689280;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMDataButtonKey_A22600.UIName;
			}
		}

		// Token: 0x17003F4C RID: 16204
		// (get) Token: 0x06007B7D RID: 31613 RVA: 0x00713008 File Offset: 0x00711208
		// (set) Token: 0x06007B7E RID: 31614 RVA: 0x007130BC File Offset: 0x007112BC
		internal bool RadErgoCfgKMDataButtonKey_A22600_HiddenStatic
		{
			get
			{
				short num = (short)867955111;
				short num2 = num;
				num = (short)1299050919;
				switch (num2 == num)
				{
				}
				num = (short)878313472;
				if (num != 0)
				{
				}
				num = (short)465829888;
				short num3 = num;
				num = (short)70975489;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMDataButtonKey_A22600.HiddenStatic;
			}
			set
			{
				short num = (short)217300674;
				short num2 = num;
				num = (short)1369292482;
				switch (num2 == num)
				{
				}
				num = (short)1214054400;
				if (num != 0)
				{
				}
				num = (short)1713242112;
				short num3 = num;
				num = (short)271908865;
				if (num != 0)
				{
				}
				this.radErgoCfgKMDataButtonKey_A22600.HiddenStatic = value;
			}
		}

		// Token: 0x17003F4D RID: 16205
		// (get) Token: 0x06007B7F RID: 31615 RVA: 0x00713174 File Offset: 0x00711374
		// (set) Token: 0x06007B80 RID: 31616 RVA: 0x0071322C File Offset: 0x0071142C
		internal bool RadErgoCfgKMDataButtonKey_A22600_HiddenDynamic
		{
			get
			{
				short num = (short)606142465;
				if (num != 0)
				{
				}
				num = (short)2038650659;
				short num2 = num;
				num = (short)935810851;
				switch (num2 == num)
				{
				}
				num = (short)1902772224;
				short num3 = num;
				num = (short)1147600896;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMDataButtonKey_A22600.HiddenDynamic;
			}
			set
			{
				short num = (short)1630541182;
				short num2 = num;
				num = (short)250025342;
				switch (num2 == num)
				{
				}
				num = (short)1241120768;
				if (num != 0)
				{
				}
				num = (short)973078528;
				short num3 = num;
				num = (short)1829568513;
				if (num != 0)
				{
				}
				this.radErgoCfgKMDataButtonKey_A22600.HiddenDynamic = value;
			}
		}

		// Token: 0x17003F4E RID: 16206
		// (get) Token: 0x06007B81 RID: 31617 RVA: 0x007132E4 File Offset: 0x007114E4
		public bool RadErgoCfgKMDataButtonKey_A22600_HasDiffs
		{
			get
			{
				short num = (short)31008384;
				short num2 = num;
				num = (short)631645824;
				switch (num2 == num)
				{
				}
				num = (short)1142882305;
				if (num != 0)
				{
				}
				num = (short)1421541376;
				short num3 = num;
				num = (short)756285440;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMDataButtonKey_A22600._HasDiffs;
			}
		}

		// Token: 0x17003F4F RID: 16207
		// (get) Token: 0x06007B82 RID: 31618 RVA: 0x0071339C File Offset: 0x0071159C
		// (set) Token: 0x06007B83 RID: 31619 RVA: 0x00713450 File Offset: 0x00711650
		public string RadErgoCfgKMDataButtonName_A22601Value
		{
			get
			{
				short num = (short)756850842;
				short num2 = num;
				num = (short)1829216410;
				switch (num2 == num)
				{
				}
				num = (short)1005256705;
				if (num != 0)
				{
				}
				num = (short)125304832;
				short num3 = num;
				num = (short)591200256;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMDataButtonName_A22601.Value;
			}
			set
			{
				short num = (short)1226376216;
				short num2 = num;
				num = (short)1155335192;
				switch (num2 == num)
				{
				}
				num = (short)1997012993;
				if (num != 0)
				{
				}
				num = (short)14876672;
				short num3 = num;
				num = (short)1474166784;
				if (num != 0)
				{
				}
				this.radErgoCfgKMDataButtonName_A22601.Value = value;
			}
		}

		// Token: 0x17003F50 RID: 16208
		// (get) Token: 0x06007B84 RID: 31620 RVA: 0x00713504 File Offset: 0x00711704
		public global::AcpBusinessLayer.AcpField<string> RadErgoCfgKMDataButtonName_A22601
		{
			get
			{
				short num = (short)1468613172;
				short num2 = num;
				num = (short)1247625780;
				switch (num2 == num)
				{
				}
				num = (short)1276182529;
				if (num != 0)
				{
				}
				num = (short)1003749376;
				short num3 = num;
				num = (short)1481703424;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMDataButtonName_A22601;
			}
		}

		// Token: 0x17003F51 RID: 16209
		// (get) Token: 0x06007B85 RID: 31621 RVA: 0x007135B4 File Offset: 0x007117B4
		// (set) Token: 0x06007B86 RID: 31622 RVA: 0x00713668 File Offset: 0x00711868
		public string RadErgoCfgKMDataButtonName_A22601_UIValue
		{
			get
			{
				short num = (short)1664546496;
				short num2 = num;
				num = (short)1715664576;
				switch (num2 == num)
				{
				}
				num = (short)139788289;
				if (num != 0)
				{
				}
				num = (short)1788608512;
				short num3 = num;
				num = (short)1786773504;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMDataButtonName_A22601.Value;
			}
			set
			{
				short num = (short)1168573883;
				short num2 = num;
				num = (short)1797850555;
				switch (num2 == num)
				{
				}
				num = (short)927072256;
				if (num != 0)
				{
				}
				num = (short)1959329792;
				short num3 = num;
				num = (short)17367041;
				if (num != 0)
				{
				}
				this.radErgoCfgKMDataButtonName_A22601.Value = value;
			}
		}

		// Token: 0x17003F52 RID: 16210
		// (get) Token: 0x06007B87 RID: 31623 RVA: 0x0071371C File Offset: 0x0071191C
		// (set) Token: 0x06007B88 RID: 31624 RVA: 0x007137D0 File Offset: 0x007119D0
		public bool RadErgoCfgKMDataButtonName_A22601_Applicable
		{
			get
			{
				short num = (short)71354450;
				short num2 = num;
				num = (short)458868818;
				switch (num2 == num)
				{
				}
				num = (short)579665921;
				if (num != 0)
				{
				}
				num = (short)661651456;
				short num3 = num;
				num = (short)733675520;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMDataButtonName_A22601.Applicable;
			}
			set
			{
				short num = (short)1212678665;
				short num2 = num;
				num = (short)1117848073;
				switch (num2 == num)
				{
				}
				num = (short)549060609;
				if (num != 0)
				{
				}
				num = (short)2111045632;
				short num3 = num;
				num = (short)935854080;
				if (num != 0)
				{
				}
				this.radErgoCfgKMDataButtonName_A22601.Applicable = value;
			}
		}

		// Token: 0x17003F53 RID: 16211
		// (get) Token: 0x06007B89 RID: 31625 RVA: 0x00713888 File Offset: 0x00711A88
		// (set) Token: 0x06007B8A RID: 31626 RVA: 0x00713940 File Offset: 0x00711B40
		public bool RadErgoCfgKMDataButtonName_A22601_Valid
		{
			get
			{
				short num = (short)1330946881;
				short num2 = num;
				num = (short)1794220865;
				switch (num2 == num)
				{
				}
				num = (short)942080000;
				if (num != 0)
				{
				}
				num = (short)833552384;
				short num3 = num;
				num = (short)318111745;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMDataButtonName_A22601.Valid;
			}
			set
			{
				short num = (short)1472264735;
				short num2 = num;
				num = (short)5175839;
				switch (num2 == num)
				{
				}
				num = (short)1768357888;
				if (num != 0)
				{
				}
				num = (short)1527316480;
				short num3 = num;
				num = (short)229179393;
				if (num != 0)
				{
				}
				this.radErgoCfgKMDataButtonName_A22601.Valid = value;
			}
		}

		// Token: 0x17003F54 RID: 16212
		// (get) Token: 0x06007B8B RID: 31627 RVA: 0x007139F8 File Offset: 0x00711BF8
		// (set) Token: 0x06007B8C RID: 31628 RVA: 0x00713AAC File Offset: 0x00711CAC
		public bool RadErgoCfgKMDataButtonName_A22601_Visible
		{
			get
			{
				short num = (short)1402622438;
				short num2 = num;
				num = (short)1383289318;
				switch (num2 == num)
				{
				}
				num = (short)1157758976;
				if (num != 0)
				{
				}
				num = (short)276889600;
				short num3 = num;
				num = (short)111935489;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMDataButtonName_A22601.Visible;
			}
			set
			{
				short num = (short)1911133576;
				short num2 = num;
				num = (short)1249744264;
				switch (num2 == num)
				{
				}
				num = (short)648347649;
				if (num != 0)
				{
				}
				num = (short)224133120;
				short num3 = num;
				num = (short)528154624;
				if (num != 0)
				{
				}
				this.radErgoCfgKMDataButtonName_A22601.Visible = value;
			}
		}

		// Token: 0x17003F55 RID: 16213
		// (get) Token: 0x06007B8D RID: 31629 RVA: 0x00713B64 File Offset: 0x00711D64
		// (set) Token: 0x06007B8E RID: 31630 RVA: 0x00713C18 File Offset: 0x00711E18
		public bool RadErgoCfgKMDataButtonName_A22601_Editable
		{
			get
			{
				short num = (short)1500856560;
				short num2 = num;
				num = (short)971129072;
				switch (num2 == num)
				{
				}
				num = (short)66322433;
				if (num != 0)
				{
				}
				num = (short)1924792320;
				short num3 = num;
				num = (short)321257472;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMDataButtonName_A22601.Editable;
			}
			set
			{
				short num = (short)1945829377;
				if (num != 0)
				{
				}
				num = (short)256665765;
				short num2 = num;
				num = (short)1545955493;
				switch (num2 == num)
				{
				}
				num = (short)1665597440;
				if (num != 0)
				{
				}
				num = (short)468451328;
				short num3 = num;
				this.radErgoCfgKMDataButtonName_A22601.Editable = value;
			}
		}

		// Token: 0x17003F56 RID: 16214
		// (get) Token: 0x06007B8F RID: 31631 RVA: 0x00713CD0 File Offset: 0x00711ED0
		internal string RadErgoCfgKMDataButtonName_A22601_UILabel
		{
			get
			{
				short num = (short)458287078;
				short num2 = num;
				num = (short)812443622;
				switch (num2 == num)
				{
				}
				num = (short)61407233;
				if (num != 0)
				{
				}
				num = (short)778043392;
				if (num != 0)
				{
				}
				num = (short)737673216;
				short num3 = num;
				return this.radErgoCfgKMDataButtonName_A22601.UIName;
			}
		}

		// Token: 0x17003F57 RID: 16215
		// (get) Token: 0x06007B90 RID: 31632 RVA: 0x00713D84 File Offset: 0x00711F84
		// (set) Token: 0x06007B91 RID: 31633 RVA: 0x00713E38 File Offset: 0x00712038
		internal bool RadErgoCfgKMDataButtonName_A22601_HiddenStatic
		{
			get
			{
				short num = (short)1953882952;
				short num2 = num;
				num = (short)8577864;
				switch (num2 == num)
				{
				}
				num = (short)900857856;
				if (num != 0)
				{
				}
				num = (short)1501822977;
				if (num != 0)
				{
				}
				num = (short)278593536;
				short num3 = num;
				return this.radErgoCfgKMDataButtonName_A22601.HiddenStatic;
			}
			set
			{
				short num = (short)908290815;
				short num2 = num;
				num = (short)2094951167;
				switch (num2 == num)
				{
				}
				num = (short)1614413825;
				if (num != 0)
				{
				}
				num = (short)2049835008;
				if (num != 0)
				{
				}
				num = (short)1800929280;
				short num3 = num;
				this.radErgoCfgKMDataButtonName_A22601.HiddenStatic = value;
			}
		}

		// Token: 0x17003F58 RID: 16216
		// (get) Token: 0x06007B92 RID: 31634 RVA: 0x00713EF0 File Offset: 0x007120F0
		// (set) Token: 0x06007B93 RID: 31635 RVA: 0x00713FA4 File Offset: 0x007121A4
		internal bool RadErgoCfgKMDataButtonName_A22601_HiddenDynamic
		{
			get
			{
				short num = (short)928746547;
				short num2 = num;
				num = (short)125144115;
				switch (num2 == num)
				{
				}
				num = (short)2048458752;
				if (num != 0)
				{
				}
				num = (short)233308161;
				if (num != 0)
				{
				}
				num = (short)1057488896;
				short num3 = num;
				return this.radErgoCfgKMDataButtonName_A22601.HiddenDynamic;
			}
			set
			{
				short num = (short)346724910;
				short num2 = num;
				num = (short)1923258926;
				switch (num2 == num)
				{
				}
				num = (short)1129054208;
				if (num != 0)
				{
				}
				num = (short)1988231169;
				if (num != 0)
				{
				}
				num = (short)1062076416;
				short num3 = num;
				this.radErgoCfgKMDataButtonName_A22601.HiddenDynamic = value;
			}
		}

		// Token: 0x17003F59 RID: 16217
		// (get) Token: 0x06007B94 RID: 31636 RVA: 0x0071405C File Offset: 0x0071225C
		public bool RadErgoCfgKMDataButtonName_A22601_HasDiffs
		{
			get
			{
				short num = (short)414484222;
				short num2 = num;
				num = (short)1776060158;
				switch (num2 == num)
				{
				}
				num = (short)1166606337;
				if (num != 0)
				{
				}
				num = (short)938803200;
				if (num != 0)
				{
				}
				num = (short)1387462656;
				short num3 = num;
				return this.radErgoCfgKMDataButtonName_A22601._HasDiffs;
			}
		}

		// Token: 0x17003F5A RID: 16218
		// (get) Token: 0x06007B95 RID: 31637 RVA: 0x00714110 File Offset: 0x00712310
		// (set) Token: 0x06007B96 RID: 31638 RVA: 0x007141C8 File Offset: 0x007123C8
		public int RadErgoCfgKMConventionalKMDataButtonBCO_A22602Value
		{
			get
			{
				short num = (short)940299702;
				short num2 = num;
				num = (short)1899353526;
				switch (num2 == num)
				{
				}
				num = (short)1444741121;
				if (num != 0)
				{
				}
				num = (short)645005312;
				if (num != 0)
				{
				}
				num = (short)704184320;
				short num3 = num;
				return this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.Value;
			}
			set
			{
				short num = (short)1592933643;
				short num2 = num;
				num = (short)60570891;
				switch (num2 == num)
				{
				}
				num = (short)2102919169;
				if (num != 0)
				{
				}
				num = (short)518127616;
				if (num != 0)
				{
				}
				num = (short)586153984;
				short num3 = num;
				this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.Value = value;
			}
		}

		// Token: 0x17003F5B RID: 16219
		// (get) Token: 0x06007B97 RID: 31639 RVA: 0x0071427C File Offset: 0x0071247C
		// (set) Token: 0x06007B98 RID: 31640 RVA: 0x00714330 File Offset: 0x00712530
		public string RadErgoCfgKMConventionalKMDataButtonBCO_A22602_UIValue
		{
			get
			{
				short num = (short)1134034945;
				if (num != 0)
				{
				}
				num = (short)842466867;
				short num2 = num;
				num = (short)1752368691;
				switch (num2 == num)
				{
				}
				num = (short)2102198272;
				if (num != 0)
				{
				}
				num = (short)1086390272;
				short num3 = num;
				return this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.UIValue;
			}
			set
			{
				short num = (short)506320345;
				short num2 = num;
				num = (short)1275057625;
				switch (num2 == num)
				{
				}
				num = (short)71958529;
				if (num != 0)
				{
				}
				num = (short)1818427392;
				if (num != 0)
				{
				}
				num = (short)838270976;
				short num3 = num;
				this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.UIValue = value;
			}
		}

		// Token: 0x17003F5C RID: 16220
		// (get) Token: 0x06007B99 RID: 31641 RVA: 0x007143E8 File Offset: 0x007125E8
		public global::AcpBusinessLayer.AcpListField RadErgoCfgKMConventionalKMDataButtonBCO_A22602
		{
			get
			{
				short num = (short)20905189;
				short num2 = num;
				num = (short)1727855845;
				switch (num2 == num)
				{
				}
				num = (short)544342017;
				if (num != 0)
				{
				}
				num = (short)957808640;
				if (num != 0)
				{
				}
				num = (short)1664679936;
				short num3 = num;
				return this.radErgoCfgKMConventionalKMDataButtonBCO_A22602;
			}
		}

		// Token: 0x17003F5D RID: 16221
		// (get) Token: 0x06007B9A RID: 31642 RVA: 0x00714494 File Offset: 0x00712694
		// (set) Token: 0x06007B9B RID: 31643 RVA: 0x00714548 File Offset: 0x00712748
		public bool RadErgoCfgKMConventionalKMDataButtonBCO_A22602_Applicable
		{
			get
			{
				short num = (short)1383312647;
				short num2 = num;
				num = (short)752266503;
				switch (num2 == num)
				{
				}
				num = (short)1953497088;
				if (num != 0)
				{
				}
				num = (short)866189313;
				if (num != 0)
				{
				}
				num = (short)1706557440;
				short num3 = num;
				return this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.Applicable;
			}
			set
			{
				short num = (short)2088485784;
				short num2 = num;
				num = (short)1045742488;
				switch (num2 == num)
				{
				}
				num = (short)1319567360;
				if (num != 0)
				{
				}
				num = (short)843251713;
				if (num != 0)
				{
				}
				num = (short)405667840;
				short num3 = num;
				this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.Applicable = value;
			}
		}

		// Token: 0x17003F5E RID: 16222
		// (get) Token: 0x06007B9C RID: 31644 RVA: 0x007145FC File Offset: 0x007127FC
		// (set) Token: 0x06007B9D RID: 31645 RVA: 0x007146AC File Offset: 0x007128AC
		public bool RadErgoCfgKMConventionalKMDataButtonBCO_A22602_Valid
		{
			get
			{
				short num = (short)1066303173;
				short num2 = num;
				num = (short)1035435717;
				switch (num2 == num)
				{
				}
				num = (short)1199636481;
				if (num != 0)
				{
				}
				num = (short)647233536;
				if (num != 0)
				{
				}
				num = (short)240582656;
				short num3 = num;
				return this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.Valid;
			}
			set
			{
				short num = (short)1519890213;
				short num2 = num;
				num = (short)1798745893;
				switch (num2 == num)
				{
				}
				num = (short)1832845312;
				if (num != 0)
				{
				}
				num = (short)854917121;
				if (num != 0)
				{
				}
				num = (short)382271488;
				short num3 = num;
				this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.Valid = value;
			}
		}

		// Token: 0x17003F5F RID: 16223
		// (get) Token: 0x06007B9E RID: 31646 RVA: 0x00714760 File Offset: 0x00712960
		// (set) Token: 0x06007B9F RID: 31647 RVA: 0x00714818 File Offset: 0x00712A18
		public bool RadErgoCfgKMConventionalKMDataButtonBCO_A22602_Visible
		{
			get
			{
				short num = (short)1902514175;
				short num2 = num;
				num = (short)1342443519;
				switch (num2 == num)
				{
				}
				num = (short)730267649;
				if (num != 0)
				{
				}
				num = (short)1900609536;
				if (num != 0)
				{
				}
				num = (short)1458176000;
				short num3 = num;
				return this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.Visible;
			}
			set
			{
				short num = (short)495291766;
				short num2 = num;
				num = (short)412781942;
				switch (num2 == num)
				{
				}
				num = (short)1253507073;
				if (num != 0)
				{
				}
				num = (short)2034630656;
				if (num != 0)
				{
				}
				num = (short)869531648;
				short num3 = num;
				this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.Visible = value;
			}
		}

		// Token: 0x17003F60 RID: 16224
		// (get) Token: 0x06007BA0 RID: 31648 RVA: 0x007148D0 File Offset: 0x00712AD0
		// (set) Token: 0x06007BA1 RID: 31649 RVA: 0x00714984 File Offset: 0x00712B84
		public bool RadErgoCfgKMConventionalKMDataButtonBCO_A22602_Editable
		{
			get
			{
				short num = (short)1954938881;
				if (num != 0)
				{
				}
				num = (short)1683682734;
				short num2 = num;
				num = (short)16446894;
				switch (num2 == num)
				{
				}
				num = (short)104988672;
				if (num != 0)
				{
				}
				num = (short)978518016;
				short num3 = num;
				return this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.Editable;
			}
			set
			{
				short num = (short)1312882689;
				if (num != 0)
				{
				}
				num = (short)2005090166;
				short num2 = num;
				num = (short)107102070;
				switch (num2 == num)
				{
				}
				num = (short)266797056;
				if (num != 0)
				{
				}
				num = (short)1512112128;
				short num3 = num;
				this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.Editable = value;
			}
		}

		// Token: 0x17003F61 RID: 16225
		// (get) Token: 0x06007BA2 RID: 31650 RVA: 0x00714A3C File Offset: 0x00712C3C
		internal string RadErgoCfgKMConventionalKMDataButtonBCO_A22602_UILabel
		{
			get
			{
				short num = (short)664028124;
				short num2 = num;
				num = (short)640107484;
				switch (num2 == num)
				{
				}
				num = (short)997326848;
				if (num != 0)
				{
				}
				num = (short)958660609;
				if (num != 0)
				{
				}
				num = (short)1236992000;
				short num3 = num;
				return this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.UIName;
			}
		}

		// Token: 0x17003F62 RID: 16226
		// (get) Token: 0x06007BA3 RID: 31651 RVA: 0x00714AF0 File Offset: 0x00712CF0
		// (set) Token: 0x06007BA4 RID: 31652 RVA: 0x00714BA4 File Offset: 0x00712DA4
		internal bool RadErgoCfgKMConventionalKMDataButtonBCO_A22602_HiddenStatic
		{
			get
			{
				short num = (short)1738255374;
				short num2 = num;
				num = (short)500476942;
				switch (num2 == num)
				{
				}
				num = (short)995098624;
				if (num != 0)
				{
				}
				num = (short)1622736897;
				if (num != 0)
				{
				}
				num = (short)1515257856;
				short num3 = num;
				return this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.HiddenStatic;
			}
			set
			{
				short num = (short)1646398201;
				short num2 = num;
				num = (short)180488953;
				switch (num2 == num)
				{
				}
				num = (short)1372323841;
				if (num != 0)
				{
				}
				num = (short)1319174144;
				if (num != 0)
				{
				}
				num = (short)1439498240;
				short num3 = num;
				this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.HiddenStatic = value;
			}
		}

		// Token: 0x17003F63 RID: 16227
		// (get) Token: 0x06007BA5 RID: 31653 RVA: 0x00714C5C File Offset: 0x00712E5C
		// (set) Token: 0x06007BA6 RID: 31654 RVA: 0x00714D14 File Offset: 0x00712F14
		internal bool RadErgoCfgKMConventionalKMDataButtonBCO_A22602_HiddenDynamic
		{
			get
			{
				short num = (short)1541004769;
				short num2 = num;
				num = (short)1444732385;
				switch (num2 == num)
				{
				}
				num = (short)1308098560;
				if (num != 0)
				{
				}
				num = (short)46202881;
				if (num != 0)
				{
				}
				num = (short)791478272;
				short num3 = num;
				return this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.HiddenDynamic;
			}
			set
			{
				short num = (short)1338703873;
				if (num != 0)
				{
				}
				num = (short)447969646;
				short num2 = num;
				num = (short)160528750;
				switch (num2 == num)
				{
				}
				num = (short)2019295232;
				if (num != 0)
				{
				}
				num = (short)1919680512;
				short num3 = num;
				this.radErgoCfgKMConventionalKMDataButtonBCO_A22602.HiddenDynamic = value;
			}
		}

		// Token: 0x17003F64 RID: 16228
		// (get) Token: 0x06007BA7 RID: 31655 RVA: 0x00714DCC File Offset: 0x00712FCC
		public bool RadErgoCfgKMConventionalKMDataButtonBCO_A22602_HasDiffs
		{
			get
			{
				short num = (short)2031812609;
				if (num != 0)
				{
				}
				num = (short)486582293;
				short num2 = num;
				num = (short)1157474325;
				switch (num2 == num)
				{
				}
				num = (short)613482496;
				if (num != 0)
				{
				}
				num = (short)18743296;
				short num3 = num;
				return this.radErgoCfgKMConventionalKMDataButtonBCO_A22602._HasDiffs;
			}
		}

		// Token: 0x17003F65 RID: 16229
		// (get) Token: 0x06007BA8 RID: 31656 RVA: 0x00714E80 File Offset: 0x00713080
		// (set) Token: 0x06007BA9 RID: 31657 RVA: 0x00714F34 File Offset: 0x00713134
		public int RadErgoCfgKMConventionalKMDatatButtonFeature_A22603Value
		{
			get
			{
				short num = (short)1584281945;
				short num2 = num;
				num = (short)14039385;
				switch (num2 == num)
				{
				}
				num = (short)1429078017;
				if (num != 0)
				{
				}
				num = (short)2060451840;
				if (num != 0)
				{
				}
				num = (short)678690816;
				short num3 = num;
				return this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.Value;
			}
			set
			{
				short num = (short)1775935316;
				short num2 = num;
				num = (short)167747412;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1928593408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)910491648;
				if (num != 0)
				{
				}
				num = (short)38404097;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.Value = value;
			}
		}

		// Token: 0x17003F66 RID: 16230
		// (get) Token: 0x06007BAA RID: 31658 RVA: 0x00714FE8 File Offset: 0x007131E8
		// (set) Token: 0x06007BAB RID: 31659 RVA: 0x0071509C File Offset: 0x0071329C
		public string RadErgoCfgKMConventionalKMDatatButtonFeature_A22603_UIValue
		{
			get
			{
				short num = (short)340983809;
				if (num != 0)
				{
				}
				num = (short)1318191104;
				short num2 = num;
				num = (short)283871014;
				short num3 = num;
				num = (short)107120422;
				switch (num3 == num)
				{
				}
				num = (short)1613168640;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.UIValue;
			}
			set
			{
				short num = (short)2010162903;
				short num2 = num;
				num = (short)269723351;
				switch (num2 == num)
				{
				default:
				{
					num = (short)656605184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)598736897;
				if (num != 0)
				{
				}
				num = (short)999489536;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.UIValue = value;
			}
		}

		// Token: 0x17003F67 RID: 16231
		// (get) Token: 0x06007BAC RID: 31660 RVA: 0x00715150 File Offset: 0x00713350
		public global::AcpBusinessLayer.AcpListField RadErgoCfgKMConventionalKMDatatButtonFeature_A22603
		{
			get
			{
				short num = (short)800069328;
				short num2 = num;
				num = (short)77207248;
				switch (num2 == num)
				{
				default:
				{
					num = (short)359202816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)714932224;
				if (num != 0)
				{
				}
				num = (short)1292697601;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603;
			}
		}

		// Token: 0x17003F68 RID: 16232
		// (get) Token: 0x06007BAD RID: 31661 RVA: 0x00715200 File Offset: 0x00713400
		// (set) Token: 0x06007BAE RID: 31662 RVA: 0x007152B4 File Offset: 0x007134B4
		public bool RadErgoCfgKMConventionalKMDatatButtonFeature_A22603_Applicable
		{
			get
			{
				short num = (short)1783654274;
				short num2 = num;
				num = (short)1893951362;
				switch (num2 == num)
				{
				default:
				{
					num = (short)139657216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)89915393;
				if (num != 0)
				{
				}
				num = (short)1197342720;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.Applicable;
			}
			set
			{
				short num = (short)1012222518;
				short num2 = num;
				num = (short)1702382134;
				switch (num2 == num)
				{
				default:
				{
					num = (short)151781376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1942355968;
				if (num != 0)
				{
				}
				num = (short)1480065025;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.Applicable = value;
			}
		}

		// Token: 0x17003F69 RID: 16233
		// (get) Token: 0x06007BAF RID: 31663 RVA: 0x0071536C File Offset: 0x0071356C
		// (set) Token: 0x06007BB0 RID: 31664 RVA: 0x00715420 File Offset: 0x00713620
		public bool RadErgoCfgKMConventionalKMDatatButtonFeature_A22603_Valid
		{
			get
			{
				short num = (short)323878913;
				if (num != 0)
				{
				}
				num = (short)1113915392;
				short num2 = num;
				num = (short)1620479257;
				short num3 = num;
				num = (short)1246006553;
				switch (num3 == num)
				{
				}
				num = (short)1980563456;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.Valid;
			}
			set
			{
				short num = (short)1773222332;
				short num2 = num;
				num = (short)1520449980;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1425342464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)30670848;
				if (num != 0)
				{
				}
				num = (short)1798373377;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.Valid = value;
			}
		}

		// Token: 0x17003F6A RID: 16234
		// (get) Token: 0x06007BB1 RID: 31665 RVA: 0x007154D8 File Offset: 0x007136D8
		// (set) Token: 0x06007BB2 RID: 31666 RVA: 0x0071558C File Offset: 0x0071378C
		public bool RadErgoCfgKMConventionalKMDatatButtonFeature_A22603_Visible
		{
			get
			{
				short num = (short)1805724161;
				short num2 = num;
				num = (short)666970625;
				switch (num2 == num)
				{
				default:
				{
					num = (short)974913536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2040594433;
				if (num != 0)
				{
				}
				num = (short)887619584;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.Visible;
			}
			set
			{
				short num = (short)1369832517;
				short num2 = num;
				num = (short)202046533;
				switch (num2 == num)
				{
				default:
				{
					num = (short)478347264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1762263041;
				if (num != 0)
				{
				}
				num = (short)1345323008;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.Visible = value;
			}
		}

		// Token: 0x17003F6B RID: 16235
		// (get) Token: 0x06007BB3 RID: 31667 RVA: 0x00715644 File Offset: 0x00713844
		// (set) Token: 0x06007BB4 RID: 31668 RVA: 0x007156F8 File Offset: 0x007138F8
		public bool RadErgoCfgKMConventionalKMDatatButtonFeature_A22603_Editable
		{
			get
			{
				short num = (short)1858671278;
				short num2 = num;
				num = (short)768217774;
				switch (num2 == num)
				{
				default:
				{
					num = (short)212074496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)906756097;
				if (num != 0)
				{
				}
				num = (short)1601961984;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.Editable;
			}
			set
			{
				short num = (short)957677569;
				if (num != 0)
				{
				}
				num = (short)430505984;
				short num2 = num;
				num = (short)1540318580;
				short num3 = num;
				num = (short)239035764;
				switch (num3 == num)
				{
				}
				num = (short)81854464;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.Editable = value;
			}
		}

		// Token: 0x17003F6C RID: 16236
		// (get) Token: 0x06007BB5 RID: 31669 RVA: 0x007157B0 File Offset: 0x007139B0
		internal string RadErgoCfgKMConventionalKMDatatButtonFeature_A22603_UILabel
		{
			get
			{
				short num = (short)1762993299;
				short num2 = num;
				num = (short)1704535187;
				switch (num2 == num)
				{
				default:
				{
					num = (short)236912640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2099183617;
				if (num != 0)
				{
				}
				num = (short)1756233728;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.UIName;
			}
		}

		// Token: 0x17003F6D RID: 16237
		// (get) Token: 0x06007BB6 RID: 31670 RVA: 0x00715868 File Offset: 0x00713A68
		// (set) Token: 0x06007BB7 RID: 31671 RVA: 0x0071591C File Offset: 0x00713B1C
		internal bool RadErgoCfgKMConventionalKMDatatButtonFeature_A22603_HiddenStatic
		{
			get
			{
				short num = (short)924045348;
				short num2 = num;
				num = (short)351588388;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1224474624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)42663937;
				if (num != 0)
				{
				}
				num = (short)1490550784;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.HiddenStatic;
			}
			set
			{
				short num = (short)411779015;
				short num2 = num;
				num = (short)2127577031;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1735458816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)739835905;
				if (num != 0)
				{
				}
				num = (short)761724928;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.HiddenStatic = value;
			}
		}

		// Token: 0x17003F6E RID: 16238
		// (get) Token: 0x06007BB8 RID: 31672 RVA: 0x007159D0 File Offset: 0x00713BD0
		// (set) Token: 0x06007BB9 RID: 31673 RVA: 0x00715A88 File Offset: 0x00713C88
		internal bool RadErgoCfgKMConventionalKMDatatButtonFeature_A22603_HiddenDynamic
		{
			get
			{
				short num = (short)1001843061;
				short num2 = num;
				num = (short)903866741;
				switch (num2 == num)
				{
				default:
				{
					num = (short)195624960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1012465665;
				if (num != 0)
				{
				}
				num = (short)439943168;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.HiddenDynamic;
			}
			set
			{
				short num = (short)1370004071;
				short num2 = num;
				num = (short)1534958183;
				switch (num2 == num)
				{
				default:
				{
					num = (short)27131904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)520290305;
				if (num != 0)
				{
				}
				num = (short)428212224;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603.HiddenDynamic = value;
			}
		}

		// Token: 0x17003F6F RID: 16239
		// (get) Token: 0x06007BBA RID: 31674 RVA: 0x00715B40 File Offset: 0x00713D40
		public bool RadErgoCfgKMConventionalKMDatatButtonFeature_A22603_HasDiffs
		{
			get
			{
				short num = (short)1114570753;
				if (num != 0)
				{
				}
				num = (short)319029248;
				short num2 = num;
				num = (short)1669344831;
				short num3 = num;
				num = (short)1073622591;
				switch (num3 == num)
				{
				}
				num = (short)610795520;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonFeature_A22603._HasDiffs;
			}
		}

		// Token: 0x17003F70 RID: 16240
		// (get) Token: 0x06007BBB RID: 31675 RVA: 0x00715BF4 File Offset: 0x00713DF4
		// (set) Token: 0x06007BBC RID: 31676 RVA: 0x00715CA8 File Offset: 0x00713EA8
		public int RadErgoCfgKMTrunkingKMDataButtonBCO_A22604Value
		{
			get
			{
				short num = (short)1451115855;
				short num2 = num;
				num = (short)1769948495;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1272643584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1996292096;
				if (num != 0)
				{
				}
				num = (short)824967169;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.Value;
			}
			set
			{
				short num = (short)1518815672;
				short num2 = num;
				num = (short)1623542200;
				switch (num2 == num)
				{
				default:
				{
					num = (short)948895744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1625882625;
				if (num != 0)
				{
				}
				num = (short)351600640;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.Value = value;
			}
		}

		// Token: 0x17003F71 RID: 16241
		// (get) Token: 0x06007BBD RID: 31677 RVA: 0x00715D5C File Offset: 0x00713F5C
		// (set) Token: 0x06007BBE RID: 31678 RVA: 0x00715E10 File Offset: 0x00714010
		public string RadErgoCfgKMTrunkingKMDataButtonBCO_A22604_UIValue
		{
			get
			{
				short num = (short)2023244322;
				short num2 = num;
				num = (short)1635729954;
				switch (num2 == num)
				{
				}
				num = (short)1231028224;
				short num3 = num;
				num = (short)256573440;
				if (num != 0)
				{
				}
				num = (short)159055873;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.UIValue;
			}
			set
			{
				short num = (short)1288372225;
				if (num != 0)
				{
				}
				num = (short)1314343309;
				short num2 = num;
				num = (short)992299405;
				switch (num2 == num)
				{
				default:
				{
					num = (short)535429120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)222560256;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.UIValue = value;
			}
		}

		// Token: 0x17003F72 RID: 16242
		// (get) Token: 0x06007BBF RID: 31679 RVA: 0x00715EC8 File Offset: 0x007140C8
		public global::AcpBusinessLayer.AcpListField RadErgoCfgKMTrunkingKMDataButtonBCO_A22604
		{
			get
			{
				short num = (short)2051035876;
				short num2 = num;
				num = (short)1647465188;
				switch (num2 == num)
				{
				}
				num = (short)1951858688;
				short num3 = num;
				num = (short)2115239937;
				if (num != 0)
				{
				}
				num = (short)1523318784;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604;
			}
		}

		// Token: 0x17003F73 RID: 16243
		// (get) Token: 0x06007BC0 RID: 31680 RVA: 0x00715F7C File Offset: 0x0071417C
		// (set) Token: 0x06007BC1 RID: 31681 RVA: 0x00716030 File Offset: 0x00714230
		public bool RadErgoCfgKMTrunkingKMDataButtonBCO_A22604_Applicable
		{
			get
			{
				short num = (short)1392481089;
				short num2 = num;
				num = (short)1367642945;
				switch (num2 == num)
				{
				}
				num = (short)197197824;
				short num3 = num;
				num = (short)1510211585;
				if (num != 0)
				{
				}
				num = (short)2011955200;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.Applicable;
			}
			set
			{
				short num = (short)92564648;
				short num2 = num;
				num = (short)1086942376;
				switch (num2 == num)
				{
				}
				num = (short)413007872;
				short num3 = num;
				num = (short)2060648448;
				if (num != 0)
				{
				}
				num = (short)2000486401;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.Applicable = value;
			}
		}

		// Token: 0x17003F74 RID: 16244
		// (get) Token: 0x06007BC2 RID: 31682 RVA: 0x007160E8 File Offset: 0x007142E8
		// (set) Token: 0x06007BC3 RID: 31683 RVA: 0x0071619C File Offset: 0x0071439C
		public bool RadErgoCfgKMTrunkingKMDataButtonBCO_A22604_Valid
		{
			get
			{
				short num = (short)1772641335;
				short num2 = num;
				num = (short)2115591223;
				switch (num2 == num)
				{
				}
				num = (short)731840512;
				short num3 = num;
				num = (short)463732736;
				if (num != 0)
				{
				}
				num = (short)1926037505;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.Valid;
			}
			set
			{
				short num = (short)1756976657;
				short num2 = num;
				num = (short)1458263569;
				switch (num2 == num)
				{
				}
				num = (short)34668544;
				short num3 = num;
				num = (short)446365697;
				if (num != 0)
				{
				}
				num = (short)256573440;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.Valid = value;
			}
		}

		// Token: 0x17003F75 RID: 16245
		// (get) Token: 0x06007BC4 RID: 31684 RVA: 0x00716250 File Offset: 0x00714450
		// (set) Token: 0x06007BC5 RID: 31685 RVA: 0x00716304 File Offset: 0x00714504
		public bool RadErgoCfgKMTrunkingKMDataButtonBCO_A22604_Visible
		{
			get
			{
				short num = (short)77724947;
				short num2 = num;
				num = (short)1188035859;
				switch (num2 == num)
				{
				}
				num = (short)1953234944;
				short num3 = num;
				num = (short)189005824;
				if (num != 0)
				{
				}
				num = (short)308019201;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.Visible;
			}
			set
			{
				short num = (short)846576790;
				short num2 = num;
				num = (short)1938668694;
				switch (num2 == num)
				{
				}
				num = (short)820445184;
				short num3 = num;
				num = (short)723845121;
				if (num != 0)
				{
				}
				num = (short)1083965440;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.Visible = value;
			}
		}

		// Token: 0x17003F76 RID: 16246
		// (get) Token: 0x06007BC6 RID: 31686 RVA: 0x007163BC File Offset: 0x007145BC
		// (set) Token: 0x06007BC7 RID: 31687 RVA: 0x00716470 File Offset: 0x00714670
		public bool RadErgoCfgKMTrunkingKMDataButtonBCO_A22604_Editable
		{
			get
			{
				short num = (short)70835437;
				short num2 = num;
				num = (short)1453186285;
				switch (num2 == num)
				{
				}
				num = (short)1240858624;
				short num3 = num;
				num = (short)1451884544;
				if (num != 0)
				{
				}
				num = (short)942931969;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.Editable;
			}
			set
			{
				short num = (short)623773031;
				short num2 = num;
				num = (short)1507460455;
				switch (num2 == num)
				{
				}
				num = (short)1881669632;
				short num3 = num;
				num = (short)2075525120;
				if (num != 0)
				{
				}
				num = (short)1931476993;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.Editable = value;
			}
		}

		// Token: 0x17003F77 RID: 16247
		// (get) Token: 0x06007BC8 RID: 31688 RVA: 0x00716524 File Offset: 0x00714724
		internal string RadErgoCfgKMTrunkingKMDataButtonBCO_A22604_UILabel
		{
			get
			{
				short num = (short)962195857;
				short num2 = num;
				num = (short)2123362705;
				switch (num2 == num)
				{
				}
				num = (short)1020002304;
				short num3 = num;
				num = (short)1589837825;
				if (num != 0)
				{
				}
				num = (short)1166475264;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.UIName;
			}
		}

		// Token: 0x17003F78 RID: 16248
		// (get) Token: 0x06007BC9 RID: 31689 RVA: 0x007165D8 File Offset: 0x007147D8
		// (set) Token: 0x06007BCA RID: 31690 RVA: 0x0071668C File Offset: 0x0071488C
		internal bool RadErgoCfgKMTrunkingKMDataButtonBCO_A22604_HiddenStatic
		{
			get
			{
				short num = (short)61793309;
				short num2 = num;
				num = (short)29877277;
				switch (num2 == num)
				{
				}
				num = (short)448921600;
				short num3 = num;
				num = (short)1569193984;
				if (num != 0)
				{
				}
				num = (short)240910337;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.HiddenStatic;
			}
			set
			{
				short num = (short)332226773;
				short num2 = num;
				num = (short)1436246229;
				switch (num2 == num)
				{
				}
				num = (short)810876928;
				short num3 = num;
				num = (short)864878593;
				if (num != 0)
				{
				}
				num = (short)1505624064;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.HiddenStatic = value;
			}
		}

		// Token: 0x17003F79 RID: 16249
		// (get) Token: 0x06007BCB RID: 31691 RVA: 0x00716740 File Offset: 0x00714940
		// (set) Token: 0x06007BCC RID: 31692 RVA: 0x007167F4 File Offset: 0x007149F4
		internal bool RadErgoCfgKMTrunkingKMDataButtonBCO_A22604_HiddenDynamic
		{
			get
			{
				short num = (short)245098410;
				short num2 = num;
				num = (short)835774378;
				switch (num2 == num)
				{
				}
				num = (short)849805312;
				short num3 = num;
				num = (short)1084489729;
				if (num != 0)
				{
				}
				num = (short)25493504;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.HiddenDynamic;
			}
			set
			{
				short num = (short)1307987599;
				short num2 = num;
				num = (short)600460943;
				switch (num2 == num)
				{
				}
				num = (short)1465384960;
				short num3 = num;
				num = (short)487260161;
				if (num != 0)
				{
				}
				num = (short)1834024960;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604.HiddenDynamic = value;
			}
		}

		// Token: 0x17003F7A RID: 16250
		// (get) Token: 0x06007BCD RID: 31693 RVA: 0x007168AC File Offset: 0x00714AAC
		public bool RadErgoCfgKMTrunkingKMDataButtonBCO_A22604_HasDiffs
		{
			get
			{
				short num = (short)1153930803;
				short num2 = num;
				num = (short)1815320115;
				switch (num2 == num)
				{
				}
				num = (short)1843462144;
				short num3 = num;
				num = (short)348258305;
				if (num != 0)
				{
				}
				num = (short)851836928;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDataButtonBCO_A22604._HasDiffs;
			}
		}

		// Token: 0x17003F7B RID: 16251
		// (get) Token: 0x06007BCE RID: 31694 RVA: 0x00716960 File Offset: 0x00714B60
		// (set) Token: 0x06007BCF RID: 31695 RVA: 0x00716A14 File Offset: 0x00714C14
		public int RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605Value
		{
			get
			{
				short num = (short)1553395555;
				short num2 = num;
				num = (short)145026915;
				switch (num2 == num)
				{
				}
				num = (short)2039021568;
				short num3 = num;
				num = (short)710410241;
				if (num != 0)
				{
				}
				num = (short)134545408;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Value;
			}
			set
			{
				short num = (short)1401384535;
				short num2 = num;
				num = (short)1449291351;
				switch (num2 == num)
				{
				}
				num = (short)657195008;
				short num3 = num;
				num = (short)131661825;
				if (num != 0)
				{
				}
				num = (short)399704064;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Value = value;
			}
		}

		// Token: 0x17003F7C RID: 16252
		// (get) Token: 0x06007BD0 RID: 31696 RVA: 0x00716ACC File Offset: 0x00714CCC
		// (set) Token: 0x06007BD1 RID: 31697 RVA: 0x00716B80 File Offset: 0x00714D80
		public string RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605_UIValue
		{
			get
			{
				short num = (short)191935150;
				short num2 = num;
				num = (short)807187118;
				switch (num2 == num)
				{
				}
				num = (short)1302593536;
				short num3 = num;
				num = (short)849149952;
				if (num != 0)
				{
				}
				num = (short)1586954241;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.UIValue;
			}
			set
			{
				short num = (short)728506350;
				short num2 = num;
				num = (short)681385966;
				switch (num2 == num)
				{
				}
				num = (short)1466957824;
				short num3 = num;
				num = (short)420020225;
				if (num != 0)
				{
				}
				num = (short)1429864448;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.UIValue = value;
			}
		}

		// Token: 0x17003F7D RID: 16253
		// (get) Token: 0x06007BD2 RID: 31698 RVA: 0x00716C38 File Offset: 0x00714E38
		public global::AcpBusinessLayer.AcpListField RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605
		{
			get
			{
				short num = (short)1408892929;
				if (num != 0)
				{
				}
				num = (short)239634907;
				short num2 = num;
				num = (short)483232219;
				switch (num2 == num)
				{
				default:
				{
					num = (short)572129280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1011875840;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605;
			}
		}

		// Token: 0x17003F7E RID: 16254
		// (get) Token: 0x06007BD3 RID: 31699 RVA: 0x00716CE8 File Offset: 0x00714EE8
		// (set) Token: 0x06007BD4 RID: 31700 RVA: 0x00716DA0 File Offset: 0x00714FA0
		public bool RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605_Applicable
		{
			get
			{
				short num = (short)1274937344;
				short num2 = num;
				num = (short)2057589956;
				short num3 = num;
				num = (short)1336431812;
				switch (num3 == num)
				{
				}
				num = (short)251592704;
				if (num != 0)
				{
				}
				num = (short)674693121;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Applicable;
			}
			set
			{
				short num = (short)1330839552;
				short num2 = num;
				num = (short)2109649631;
				short num3 = num;
				num = (short)70628063;
				switch (num3 == num)
				{
				}
				num = (short)424083457;
				if (num != 0)
				{
				}
				num = (short)1787232256;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Applicable = value;
			}
		}

		// Token: 0x17003F7F RID: 16255
		// (get) Token: 0x06007BD5 RID: 31701 RVA: 0x00716E58 File Offset: 0x00715058
		// (set) Token: 0x06007BD6 RID: 31702 RVA: 0x00716F0C File Offset: 0x0071510C
		public bool RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605_Valid
		{
			get
			{
				short num = (short)1887764480;
				short num2 = num;
				num = (short)1774386513;
				short num3 = num;
				num = (short)564264273;
				switch (num3 == num)
				{
				}
				num = (short)971505664;
				if (num != 0)
				{
				}
				num = (short)1716846593;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Valid;
			}
			set
			{
				short num = (short)2115895296;
				short num2 = num;
				num = (short)1734017025;
				if (num != 0)
				{
				}
				num = (short)658974721;
				short num3 = num;
				num = (short)1811884033;
				switch (num3 == num)
				{
				}
				num = (short)114688000;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Valid = value;
			}
		}

		// Token: 0x17003F80 RID: 16256
		// (get) Token: 0x06007BD7 RID: 31703 RVA: 0x00716FC0 File Offset: 0x007151C0
		// (set) Token: 0x06007BD8 RID: 31704 RVA: 0x00717074 File Offset: 0x00715274
		public bool RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605_Visible
		{
			get
			{
				short num = (short)1056440320;
				short num2 = num;
				num = (short)182833434;
				short num3 = num;
				num = (short)1792725274;
				switch (num3 == num)
				{
				}
				num = (short)1598619648;
				if (num != 0)
				{
				}
				num = (short)1043857409;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Visible;
			}
			set
			{
				short num = (short)781058048;
				short num2 = num;
				num = (short)2146135890;
				short num3 = num;
				num = (short)292450130;
				switch (num3 == num)
				{
				}
				num = (short)405405697;
				if (num != 0)
				{
				}
				num = (short)1489371136;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Visible = value;
			}
		}

		// Token: 0x17003F81 RID: 16257
		// (get) Token: 0x06007BD9 RID: 31705 RVA: 0x0071712C File Offset: 0x0071532C
		// (set) Token: 0x06007BDA RID: 31706 RVA: 0x007171E0 File Offset: 0x007153E0
		public bool RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605_Editable
		{
			get
			{
				short num = (short)268042240;
				short num2 = num;
				num = (short)811664404;
				short num3 = num;
				num = (short)134022164;
				switch (num3 == num)
				{
				}
				num = (short)1600061441;
				if (num != 0)
				{
				}
				num = (short)1797652480;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Editable;
			}
			set
			{
				short num = (short)1390608384;
				short num2 = num;
				num = (short)1582023321;
				short num3 = num;
				num = (short)596886169;
				switch (num3 == num)
				{
				}
				num = (short)695533569;
				if (num != 0)
				{
				}
				num = (short)1695088640;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Editable = value;
			}
		}

		// Token: 0x17003F82 RID: 16258
		// (get) Token: 0x06007BDB RID: 31707 RVA: 0x00717294 File Offset: 0x00715494
		internal string RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605_UILabel
		{
			get
			{
				short num = (short)150994944;
				short num2 = num;
				num = (short)643170305;
				if (num != 0)
				{
				}
				num = (short)1903325330;
				short num3 = num;
				num = (short)308899986;
				switch (num3 == num)
				{
				}
				num = (short)1844772864;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.UIName;
			}
		}

		// Token: 0x17003F83 RID: 16259
		// (get) Token: 0x06007BDC RID: 31708 RVA: 0x0071734C File Offset: 0x0071554C
		// (set) Token: 0x06007BDD RID: 31709 RVA: 0x00717404 File Offset: 0x00715604
		internal bool RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605_HiddenStatic
		{
			get
			{
				short num = (short)742588416;
				short num2 = num;
				num = (short)912568226;
				short num3 = num;
				num = (short)816164770;
				switch (num3 == num)
				{
				}
				num = (short)1334968320;
				if (num != 0)
				{
				}
				num = (short)113573889;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.HiddenStatic;
			}
			set
			{
				short num = (short)1960116224;
				short num2 = num;
				num = (short)506672158;
				short num3 = num;
				num = (short)136524830;
				switch (num3 == num)
				{
				}
				num = (short)734593025;
				if (num != 0)
				{
				}
				num = (short)775290880;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.HiddenStatic = value;
			}
		}

		// Token: 0x17003F84 RID: 16260
		// (get) Token: 0x06007BDE RID: 31710 RVA: 0x007174B8 File Offset: 0x007156B8
		// (set) Token: 0x06007BDF RID: 31711 RVA: 0x0071756C File Offset: 0x0071576C
		internal bool RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605_HiddenDynamic
		{
			get
			{
				short num = (short)404553728;
				short num2 = num;
				num = (short)1635475036;
				short num3 = num;
				num = (short)850026076;
				switch (num3 == num)
				{
				}
				num = (short)325386241;
				if (num != 0)
				{
				}
				num = (short)2047279104;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.HiddenDynamic;
			}
			set
			{
				short num = (short)413138944;
				short num2 = num;
				num = (short)606664502;
				short num3 = num;
				num = (short)874837814;
				switch (num3 == num)
				{
				}
				num = (short)1938030593;
				if (num != 0)
				{
				}
				num = (short)1593245696;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605.HiddenDynamic = value;
			}
		}

		// Token: 0x17003F85 RID: 16261
		// (get) Token: 0x06007BE0 RID: 31712 RVA: 0x00717620 File Offset: 0x00715820
		public bool RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605_HasDiffs
		{
			get
			{
				short num = (short)1875050496;
				short num2 = num;
				num = (short)1825658311;
				short num3 = num;
				num = (short)557471175;
				switch (num3 == num)
				{
				}
				num = (short)299368448;
				if (num != 0)
				{
				}
				num = (short)1463091201;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDatatButtonFeature_A22605._HasDiffs;
			}
		}

		// Token: 0x17003F86 RID: 16262
		// (get) Token: 0x06007BE1 RID: 31713 RVA: 0x007176D4 File Offset: 0x007158D4
		// (set) Token: 0x06007BE2 RID: 31714 RVA: 0x00717788 File Offset: 0x00715988
		public int RadErgoCfgKMConventionalKMDatatButtonIndex_A41423Value
		{
			get
			{
				short num = (short)1089142784;
				short num2 = num;
				num = (short)1043543106;
				short num3 = num;
				num = (short)107754562;
				switch (num3 == num)
				{
				}
				num = (short)1181089793;
				if (num != 0)
				{
				}
				num = (short)1178140672;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.Value;
			}
			set
			{
				short num = (short)1173422080;
				short num2 = num;
				num = (short)1225392129;
				if (num != 0)
				{
				}
				num = (short)1624052629;
				short num3 = num;
				num = (short)662573973;
				switch (num3 == num)
				{
				}
				num = (short)240910336;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.Value = value;
			}
		}

		// Token: 0x17003F87 RID: 16263
		// (get) Token: 0x06007BE3 RID: 31715 RVA: 0x00717840 File Offset: 0x00715A40
		// (set) Token: 0x06007BE4 RID: 31716 RVA: 0x007178F4 File Offset: 0x00715AF4
		public string RadErgoCfgKMConventionalKMDatatButtonIndex_A41423_UIValue
		{
			get
			{
				short num = (short)371916800;
				short num2 = num;
				num = (short)716177409;
				if (num != 0)
				{
				}
				num = (short)1933093415;
				short num3 = num;
				num = (short)1114090023;
				switch (num3 == num)
				{
				}
				num = (short)667746304;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.UIValue;
			}
			set
			{
				short num = (short)1887502336;
				short num2 = num;
				num = (short)1415121738;
				short num3 = num;
				num = (short)806292298;
				switch (num3 == num)
				{
				}
				num = (short)417923073;
				if (num != 0)
				{
				}
				num = (short)1149108224;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.UIValue = value;
			}
		}

		// Token: 0x17003F88 RID: 16264
		// (get) Token: 0x06007BE5 RID: 31717 RVA: 0x007179A8 File Offset: 0x00715BA8
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgKMConventionalKMDatatButtonIndex_A41423
		{
			get
			{
				short num = (short)1339097088;
				short num2 = num;
				num = (short)1434645540;
				short num3 = num;
				num = (short)119927844;
				switch (num3 == num)
				{
				}
				num = (short)1213595649;
				if (num != 0)
				{
				}
				num = (short)1535836160;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423;
			}
		}

		// Token: 0x17003F89 RID: 16265
		// (get) Token: 0x06007BE6 RID: 31718 RVA: 0x00717A54 File Offset: 0x00715C54
		// (set) Token: 0x06007BE7 RID: 31719 RVA: 0x00717B08 File Offset: 0x00715D08
		public bool RadErgoCfgKMConventionalKMDatatButtonIndex_A41423_Applicable
		{
			get
			{
				short num = (short)1425276928;
				short num2 = num;
				num = (short)2143260677;
				short num3 = num;
				num = (short)170299397;
				switch (num3 == num)
				{
				}
				num = (short)957546497;
				if (num != 0)
				{
				}
				num = (short)1604452352;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.Applicable;
			}
			set
			{
				short num = (short)1310916608;
				short num2 = num;
				num = (short)1416396070;
				short num3 = num;
				num = (short)1415871782;
				switch (num3 == num)
				{
				}
				num = (short)71106561;
				if (num != 0)
				{
				}
				num = (short)1837170688;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.Applicable = value;
			}
		}

		// Token: 0x17003F8A RID: 16266
		// (get) Token: 0x06007BE8 RID: 31720 RVA: 0x00717BBC File Offset: 0x00715DBC
		// (set) Token: 0x06007BE9 RID: 31721 RVA: 0x00717C74 File Offset: 0x00715E74
		public bool RadErgoCfgKMConventionalKMDatatButtonIndex_A41423_Valid
		{
			get
			{
				short num = (short)1034878976;
				short num2 = num;
				num = (short)1053052179;
				short num3 = num;
				num = (short)724126995;
				switch (num3 == num)
				{
				}
				num = (short)174718977;
				if (num != 0)
				{
				}
				num = (short)1116012544;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.Valid;
			}
			set
			{
				short num = (short)2130966238;
				short num2 = num;
				num = (short)259061470;
				switch (num2 == num)
				{
				default:
				{
					num = (short)96468992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1296629761;
				if (num != 0)
				{
				}
				num = (short)388366336;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.Valid = value;
			}
		}

		// Token: 0x17003F8B RID: 16267
		// (get) Token: 0x06007BEA RID: 31722 RVA: 0x00717D28 File Offset: 0x00715F28
		// (set) Token: 0x06007BEB RID: 31723 RVA: 0x00717DDC File Offset: 0x00715FDC
		public bool RadErgoCfgKMConventionalKMDatatButtonIndex_A41423_Visible
		{
			get
			{
				short num = (short)1007222785;
				if (num != 0)
				{
				}
				num = (short)1815609344;
				short num2 = num;
				num = (short)2113544477;
				short num3 = num;
				num = (short)735781149;
				switch (num3 == num)
				{
				}
				num = (short)6291456;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.Visible;
			}
			set
			{
				short num = (short)1364558167;
				short num2 = num;
				num = (short)814252375;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1547829248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1209860097;
				if (num != 0)
				{
				}
				num = (short)1146814464;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.Visible = value;
			}
		}

		// Token: 0x17003F8C RID: 16268
		// (get) Token: 0x06007BEC RID: 31724 RVA: 0x00717E90 File Offset: 0x00716090
		// (set) Token: 0x06007BED RID: 31725 RVA: 0x00717F44 File Offset: 0x00716144
		public bool RadErgoCfgKMConventionalKMDatatButtonIndex_A41423_Editable
		{
			get
			{
				short num = (short)1530381245;
				short num2 = num;
				num = (short)777110461;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1889337344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1318518784;
				if (num != 0)
				{
				}
				num = (short)466747393;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.Editable;
			}
			set
			{
				short num = (short)1749221377;
				if (num != 0)
				{
				}
				num = (short)1110179840;
				short num2 = num;
				num = (short)493152378;
				short num3 = num;
				num = (short)895215738;
				switch (num3 == num)
				{
				}
				num = (short)1773600768;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.Editable = value;
			}
		}

		// Token: 0x17003F8D RID: 16269
		// (get) Token: 0x06007BEE RID: 31726 RVA: 0x00717FFC File Offset: 0x007161FC
		internal string RadErgoCfgKMConventionalKMDatatButtonIndex_A41423_UILabel
		{
			get
			{
				short num = (short)1764028728;
				short num2 = num;
				num = (short)638841144;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1006764032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1720188928;
				if (num != 0)
				{
				}
				num = (short)819003393;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.UIName;
			}
		}

		// Token: 0x17003F8E RID: 16270
		// (get) Token: 0x06007BEF RID: 31727 RVA: 0x007180B0 File Offset: 0x007162B0
		// (set) Token: 0x06007BF0 RID: 31728 RVA: 0x00718164 File Offset: 0x00716364
		internal bool RadErgoCfgKMConventionalKMDatatButtonIndex_A41423_HiddenStatic
		{
			get
			{
				short num = (short)1458852673;
				short num2 = num;
				num = (short)1019040577;
				switch (num2 == num)
				{
				default:
				{
					num = (short)253886464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)203816961;
				if (num != 0)
				{
				}
				num = (short)2046623744;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.HiddenStatic;
			}
			set
			{
				short num = (short)1597090563;
				short num2 = num;
				num = (short)218999555;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1377042432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)980484097;
				if (num != 0)
				{
				}
				num = (short)75366400;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.HiddenStatic = value;
			}
		}

		// Token: 0x17003F8F RID: 16271
		// (get) Token: 0x06007BF1 RID: 31729 RVA: 0x0071821C File Offset: 0x0071641C
		// (set) Token: 0x06007BF2 RID: 31730 RVA: 0x007182CC File Offset: 0x007164CC
		internal bool RadErgoCfgKMConventionalKMDatatButtonIndex_A41423_HiddenDynamic
		{
			get
			{
				short num = (short)1964949480;
				short num2 = num;
				num = (short)1726922728;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1774977024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1882193920;
				if (num != 0)
				{
				}
				num = (short)981532673;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.HiddenDynamic;
			}
			set
			{
				short num = (short)1624543905;
				short num2 = num;
				num = (short)602247841;
				switch (num2 == num)
				{
				default:
				{
					num = (short)881983488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)479657984;
				if (num != 0)
				{
				}
				num = (short)163774465;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423.HiddenDynamic = value;
			}
		}

		// Token: 0x17003F90 RID: 16272
		// (get) Token: 0x06007BF3 RID: 31731 RVA: 0x00718380 File Offset: 0x00716580
		public bool RadErgoCfgKMConventionalKMDatatButtonIndex_A41423_HasDiffs
		{
			get
			{
				short num = (short)1725639114;
				short num2 = num;
				num = (short)24783306;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1656553472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)589496320;
				if (num != 0)
				{
				}
				num = (short)2949121;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMDatatButtonIndex_A41423._HasDiffs;
			}
		}

		// Token: 0x17003F91 RID: 16273
		// (get) Token: 0x06007BF4 RID: 31732 RVA: 0x00718434 File Offset: 0x00716634
		// (set) Token: 0x06007BF5 RID: 31733 RVA: 0x007184EC File Offset: 0x007166EC
		public int RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424Value
		{
			get
			{
				short num = (short)2003548231;
				short num2 = num;
				num = (short)1967765575;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1275854848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1884291072;
				if (num != 0)
				{
				}
				num = (short)637730817;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.Value;
			}
			set
			{
				short num = (short)1408106497;
				if (num != 0)
				{
				}
				num = (short)1675427840;
				short num2 = num;
				num = (short)553841865;
				short num3 = num;
				num = (short)2023355593;
				switch (num3 == num)
				{
				}
				num = (short)1656487936;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.Value = value;
			}
		}

		// Token: 0x17003F92 RID: 16274
		// (get) Token: 0x06007BF6 RID: 31734 RVA: 0x007185A0 File Offset: 0x007167A0
		// (set) Token: 0x06007BF7 RID: 31735 RVA: 0x00718654 File Offset: 0x00716854
		public string RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424_UIValue
		{
			get
			{
				short num = (short)1973944321;
				if (num != 0)
				{
				}
				num = (short)1226637312;
				short num2 = num;
				num = (short)1516740613;
				short num3 = num;
				num = (short)249995269;
				switch (num3 == num)
				{
				}
				num = (short)537657344;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.UIValue;
			}
			set
			{
				short num = (short)1689949680;
				short num2 = num;
				num = (short)1546032624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2145058816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)182583296;
				if (num != 0)
				{
				}
				num = (short)191823873;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.UIValue = value;
			}
		}

		// Token: 0x17003F93 RID: 16275
		// (get) Token: 0x06007BF8 RID: 31736 RVA: 0x0071870C File Offset: 0x0071690C
		public global::AcpBusinessLayer.AcpRecRefField RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424
		{
			get
			{
				short num = (short)2007123111;
				short num2 = num;
				num = (short)507069607;
				switch (num2 == num)
				{
				default:
				{
					num = (short)249692160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)687996929;
				if (num != 0)
				{
				}
				num = (short)2081685504;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424;
			}
		}

		// Token: 0x17003F94 RID: 16276
		// (get) Token: 0x06007BF9 RID: 31737 RVA: 0x007187BC File Offset: 0x007169BC
		// (set) Token: 0x06007BFA RID: 31738 RVA: 0x00718874 File Offset: 0x00716A74
		public bool RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424_Applicable
		{
			get
			{
				short num = (short)1988332317;
				short num2 = num;
				num = (short)810519325;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1383727104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1368064000;
				if (num != 0)
				{
				}
				num = (short)160890881;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.Applicable;
			}
			set
			{
				short num = (short)34531007;
				short num2 = num;
				num = (short)551937727;
				switch (num2 == num)
				{
				default:
				{
					num = (short)769064960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1394475008;
				if (num != 0)
				{
				}
				num = (short)1606746113;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.Applicable = value;
			}
		}

		// Token: 0x17003F95 RID: 16277
		// (get) Token: 0x06007BFB RID: 31739 RVA: 0x00718928 File Offset: 0x00716B28
		// (set) Token: 0x06007BFC RID: 31740 RVA: 0x007189E0 File Offset: 0x00716BE0
		public bool RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424_Valid
		{
			get
			{
				short num = (short)2021193982;
				short num2 = num;
				num = (short)1777072382;
				switch (num2 == num)
				{
				default:
				{
					num = (short)160628736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1454702593;
				if (num != 0)
				{
				}
				num = (short)1823211520;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.Valid;
			}
			set
			{
				short num = (short)798226940;
				short num2 = num;
				num = (short)1830091260;
				switch (num2 == num)
				{
				default:
				{
					num = (short)314114048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)245760001;
				if (num != 0)
				{
				}
				num = (short)1323958272;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.Valid = value;
			}
		}

		// Token: 0x17003F96 RID: 16278
		// (get) Token: 0x06007BFD RID: 31741 RVA: 0x00718A94 File Offset: 0x00716C94
		// (set) Token: 0x06007BFE RID: 31742 RVA: 0x00718B48 File Offset: 0x00716D48
		public bool RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424_Visible
		{
			get
			{
				short num = (short)1815702618;
				short num2 = num;
				num = (short)543976538;
				switch (num2 == num)
				{
				}
				num = (short)354091009;
				if (num != 0)
				{
				}
				num = (short)229900288;
				if (num != 0)
				{
				}
				num = (short)1885011968;
				short num3 = num;
				return this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.Visible;
			}
			set
			{
				short num = (short)57933825;
				if (num != 0)
				{
				}
				num = (short)367547845;
				short num2 = num;
				num = (short)778917317;
				switch (num2 == num)
				{
				}
				num = (short)1039597568;
				if (num != 0)
				{
				}
				num = (short)1254424576;
				short num3 = num;
				this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.Visible = value;
			}
		}

		// Token: 0x17003F97 RID: 16279
		// (get) Token: 0x06007BFF RID: 31743 RVA: 0x00718C00 File Offset: 0x00716E00
		// (set) Token: 0x06007C00 RID: 31744 RVA: 0x00718CB8 File Offset: 0x00716EB8
		public bool RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424_Editable
		{
			get
			{
				short num = (short)813088114;
				short num2 = num;
				num = (short)2021637490;
				switch (num2 == num)
				{
				}
				num = (short)114229249;
				if (num != 0)
				{
				}
				num = (short)1300234240;
				if (num != 0)
				{
				}
				num = (short)2025127936;
				short num3 = num;
				return this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.Editable;
			}
			set
			{
				short num = (short)1247543297;
				if (num != 0)
				{
				}
				num = (short)1683916224;
				short num2 = num;
				num = (short)883459520;
				switch (num2 == num)
				{
				}
				num = (short)189857792;
				if (num != 0)
				{
				}
				num = (short)1507065856;
				short num3 = num;
				this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.Editable = value;
			}
		}

		// Token: 0x17003F98 RID: 16280
		// (get) Token: 0x06007C01 RID: 31745 RVA: 0x00718D6C File Offset: 0x00716F6C
		internal string RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424_UILabel
		{
			get
			{
				short num = (short)2014603679;
				short num2 = num;
				num = (short)27093407;
				switch (num2 == num)
				{
				}
				num = (short)1663500289;
				if (num != 0)
				{
				}
				num = (short)1545601024;
				if (num != 0)
				{
				}
				num = (short)293208064;
				short num3 = num;
				return this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.UIName;
			}
		}

		// Token: 0x17003F99 RID: 16281
		// (get) Token: 0x06007C02 RID: 31746 RVA: 0x00718E20 File Offset: 0x00717020
		// (set) Token: 0x06007C03 RID: 31747 RVA: 0x00718ED4 File Offset: 0x007170D4
		internal bool RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424_HiddenStatic
		{
			get
			{
				short num = (short)198808035;
				short num2 = num;
				num = (short)707957219;
				switch (num2 == num)
				{
				}
				num = (short)979435520;
				if (num != 0)
				{
				}
				num = (short)1725366273;
				if (num != 0)
				{
				}
				num = (short)1760755712;
				short num3 = num;
				return this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.HiddenStatic;
			}
			set
			{
				short num = (short)69599233;
				if (num != 0)
				{
				}
				num = (short)344463949;
				short num2 = num;
				num = (short)236460621;
				switch (num2 == num)
				{
				}
				num = (short)1295319040;
				if (num != 0)
				{
				}
				num = (short)1255014400;
				short num3 = num;
				this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.HiddenStatic = value;
			}
		}

		// Token: 0x17003F9A RID: 16282
		// (get) Token: 0x06007C04 RID: 31748 RVA: 0x00718F88 File Offset: 0x00717188
		// (set) Token: 0x06007C05 RID: 31749 RVA: 0x0071903C File Offset: 0x0071723C
		internal bool RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424_HiddenDynamic
		{
			get
			{
				short num = (short)132547230;
				short num2 = num;
				num = (short)2022081182;
				switch (num2 == num)
				{
				}
				num = (short)1444675585;
				if (num != 0)
				{
				}
				num = (short)1221066752;
				if (num != 0)
				{
				}
				num = (short)706936832;
				short num3 = num;
				return this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.HiddenDynamic;
			}
			set
			{
				short num = (short)1138378043;
				short num2 = num;
				num = (short)2068858171;
				switch (num2 == num)
				{
				}
				num = (short)1648820225;
				if (num != 0)
				{
				}
				num = (short)1241382912;
				if (num != 0)
				{
				}
				num = (short)940965888;
				short num3 = num;
				this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424.HiddenDynamic = value;
			}
		}

		// Token: 0x17003F9B RID: 16283
		// (get) Token: 0x06007C06 RID: 31750 RVA: 0x007190F0 File Offset: 0x007172F0
		public bool RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424_HasDiffs
		{
			get
			{
				short num = (short)755131148;
				short num2 = num;
				num = (short)50225932;
				switch (num2 == num)
				{
				}
				num = (short)766050305;
				if (num != 0)
				{
				}
				num = (short)796065792;
				if (num != 0)
				{
				}
				num = (short)1591279616;
				short num3 = num;
				return this.radErgoCfgKMTrunkingKMDatatButtonIndex_A41424._HasDiffs;
			}
		}

		// Token: 0x17003F9C RID: 16284
		// (get) Token: 0x06007C07 RID: 31751 RVA: 0x007191A4 File Offset: 0x007173A4
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)771735177;
				short num2 = num;
				num = (short)673758857;
				switch (num2 == num)
				{
				}
				num = (short)1809186817;
				if (num != 0)
				{
				}
				num = (short)1265369088;
				if (num != 0)
				{
				}
				num = (short)2139881472;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06007C08 RID: 31752 RVA: 0x00719268 File Offset: 0x00717468
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
					num2 = (short)265027585;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1914961920;
					short num3 = num2;
					num2 = (short)1344602116;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)2113863682;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
				{
					num2 = (short)517902312;
					short num4 = num2;
					num2 = (short)1216647144;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_141;
					default:
						num2 = (short)721944576;
						if (num2 != 0)
						{
						}
						num2 = (short)2124873731;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					goto IL_141;
				case 4:
					return result;
				}
				goto IL_24;
				IL_141:
				if (base.ParentRecset.ContainerDoc == null)
				{
					break;
				}
				num2 = (short)946077696;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1676607489;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040035EF RID: 13807
		private global::AcpBusinessLayer.AcpKeyField radErgoCfgKMDataButtonKey_A22600;

		// Token: 0x040035F0 RID: 13808
		private global::AcpBusinessLayer.AcpField<string> radErgoCfgKMDataButtonName_A22601;

		// Token: 0x040035F1 RID: 13809
		private global::AcpBusinessLayer.AcpListField radErgoCfgKMConventionalKMDataButtonBCO_A22602;

		// Token: 0x040035F2 RID: 13810
		private global::AcpBusinessLayer.AcpListField radErgoCfgKMConventionalKMDatatButtonFeature_A22603;

		// Token: 0x040035F3 RID: 13811
		private global::AcpBusinessLayer.AcpListField radErgoCfgKMTrunkingKMDataButtonBCO_A22604;

		// Token: 0x040035F4 RID: 13812
		private global::AcpBusinessLayer.AcpListField radErgoCfgKMTrunkingKMDatatButtonFeature_A22605;

		// Token: 0x040035F5 RID: 13813
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgKMConventionalKMDatatButtonIndex_A41423;

		// Token: 0x040035F6 RID: 13814
		private global::AcpBusinessLayer.AcpRecRefField radErgoCfgKMTrunkingKMDatatButtonIndex_A41424;
	}
}
