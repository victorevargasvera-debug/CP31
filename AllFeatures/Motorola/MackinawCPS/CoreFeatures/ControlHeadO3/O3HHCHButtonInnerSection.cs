using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO3
{
	// Token: 0x020003CD RID: 973
	[global::System.Serializable]
	public class O3HHCHButtonInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008A6C RID: 35436 RVA: 0x00817CA8 File Offset: 0x00815EA8
		public O3HHCHButtonInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06008A6D RID: 35437 RVA: 0x00817CC4 File Offset: 0x00815EC4
		protected O3HHCHButtonInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008A6E RID: 35438 RVA: 0x00817CDC File Offset: 0x00815EDC
		public override void Init()
		{
			int a_ = 11;
			short num = (short)386218562;
			short num2 = num;
			num = (short)915552834;
			switch (num2 == num)
			{
			}
			num = (short)744292353;
			if (num != 0)
			{
			}
			num = (short)1300365312;
			short num3 = num;
			num = (short)563281920;
			if (num != 0)
			{
			}
			this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649 = new global::AcpBusinessLayer.AcpSparseLOVField(153, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.indexCntrlHeadO3ConventionalO3HHCHButtonBCO_A19649LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.idCntrlHeadO3ConventionalO3HHCHButtonBCO_A19649LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋ꃍ꓏ꃑ룓黕뷗믙룛針폟ꇡ诣裥黧迩苫髭駯鷱髳韵铷뗹쿻뛽䣿䄁䰃䐅紇縉砋愍縏們圓夕䜗嬙ⴛ✝ᘟᘡᴣ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.CntrlHeadO3ConventionalO3HHCHButtonBCO_A19649LovStrs);
			this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.DataTransferOrder = -1;
			this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.indexCntrlHeadO3ConventionalO3HHCHButtonFeature_A19650LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.idCntrlHeadO3ConventionalO3HHCHButtonFeature_A19650LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋ꃍ꓏ꃑ룓黕뷗믙룛針폟ꇡ诣裥黧迩苫髭駯鷱髳韵铷뗹쿻뛽䣿䄁䰃䐅紇縉砋愍縏向焓眕気漙減笝缟挡ᔣἥḧἩᰫ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650LovStrs);
			this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.DataTransferOrder = 3;
			this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749 = new global::AcpBusinessLayer.AcpSparseLOVField(153, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.indexCntrlHeadO3TrunkingO3HHCHButtonBCO_A19749LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.idCntrlHeadO3TrunkingO3HHCHButtonBCO_A19749LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋ꃍ꓏ꃑ룓黕뷗믙룛針폟뛡難鏥蛧臩藫胭韯뷱쟳뻵냷맹듻볽痿瘁瀃椅昇䠉伋䄍伏匑┓⼕⼗⸙┛", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749LovStrs);
			this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.DataTransferOrder = -1;
			this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.indexCntrlHeadO3TrunkingO3HHCHButtonFeature_A19750LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.idCntrlHeadO3TrunkingO3HHCHButtonFeature_A19750LovStrs), this, global::AllFeatures.CodeplugGuid.b("迋ꃍ꓏ꃑ룓黕뷗믙룛針폟뛡難鏥蛧臩藫胭韯뷱쟳뻵냷맹듻볽痿瘁瀃椅昇䰉椋漍搏朑易猕䜗嬙ⴛ✝ᜟᜡᐣ", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750LovStrs);
			this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.DataTransferOrder = 5;
			this.cntrlHeadO3HHCHButtonKey_A22522 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("迋ꃍ꓏ꃑ룓黕뷗믙룛針폟ꫡ곣ꗥꃧ꣩駫髭蓯鷱髳뷵鷷菹ꏻ뿽㋿、㄃㐅㨇", a_), global::CommonResources.AcgResources.ID_KEY, 20);
			this.cntrlHeadO3HHCHButtonKey_A22522.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cntrlHeadO3HHCHButtonKey_A22522.DataTransferOrder = -1;
			this.cntrlHeadO3HHCHButtonName_A22523 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_TOPRIGHTBUTTON, this, global::AllFeatures.CodeplugGuid.b("迋ꃍ꓏ꃑ룓黕뷗믙룛針폟ꫡ곣ꗥꃧ꣩駫髭蓯鷱髳룵駷韹駻ꇽ䇿、㘃㌅㨇㤉", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.cntrlHeadO3HHCHButtonName_A22523.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cntrlHeadO3HHCHButtonName_A22523.DataTransferOrder = -1;
			this.radErgCtrlHeadO3GeneralShortKeyPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("黋꿍듏韑ꛓ뇕鯗껙껛닝꣟蟡藣若꟧\ud9e9꯫语黯韱蛳韵铷꧹铻釽狿瘁伃挅焇娉縋欍挏愑䀓缕甗缙", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
			this.radErgCtrlHeadO3GeneralShortKeyPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgCtrlHeadO3GeneralShortKeyPressTime.DataTransferOrder = -1;
			((global::AcpBusinessLayer.AcpSimpleRangeField)this.radErgCtrlHeadO3GeneralShortKeyPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.radErgCtrlHeadO3GeneralShortKeyPressTime.ShowHexValue = false;
			this.radErgCtrlHeadO3GeneralShortKeyPressTime.ValidateAcrossRecset = true;
			this.radErgCtrlHeadO3GeneralLongKeyPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("黋꿍듏韑ꛓ뇕鯗껙껛닝꣟蟡藣若꟧\ud9e9꯫语黯韱蛳韵铷뛹鏻都柿䤁愃缅堇砉椋納挏䘑紓笕紗", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
			this.radErgCtrlHeadO3GeneralLongKeyPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgCtrlHeadO3GeneralLongKeyPressTime.DataTransferOrder = -1;
			((global::AcpBusinessLayer.AcpSimpleRangeField)this.radErgCtrlHeadO3GeneralLongKeyPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.radErgCtrlHeadO3GeneralLongKeyPressTime.ShowHexValue = false;
			this.radErgCtrlHeadO3GeneralLongKeyPressTime.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菋﷍髑鳓闕郗龎黛ꯝ铟雡诣裥", a_);
			base.Id = 10210;
			base.UIName = global::CommonResources.AcgResources.ID_O3HHCHBUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008A6F RID: 35439 RVA: 0x00818060 File Offset: 0x00816260
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 15;
			short num = (short)1110966280;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꃓꓕ듗鋙맛뿝蓟귡ퟣ껥ꃧꧩꓫ곭藯蛱胳駵雷듹鷻鏽旿崁䔃㐅㨇㼉㸋㴍", a_)))
					{
						num = (short)401735697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45A;
				case 1:
					goto IL_15C;
				case 2:
					goto IL_2E4;
				case 3:
					goto IL_358;
				case 4:
					num = (short)158334996;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.radErgCtrlHeadO3GeneralShortKeyPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("苏돑냓鏕꫗뷙鿛ꫝ鋟軡곣菥觧軩ꏫ\udded럯韱髳鏵諷鯹郻귽棿洁瘃爅䌇漉甋帍戏眑朓攕䰗猙焛笝", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
					this.radErgCtrlHeadO3GeneralShortKeyPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgCtrlHeadO3GeneralShortKeyPressTime.DataTransferOrder = -1;
					((global::AcpBusinessLayer.AcpSimpleRangeField)this.radErgCtrlHeadO3GeneralShortKeyPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.radErgCtrlHeadO3GeneralShortKeyPressTime.ShowHexValue = false;
					this.radErgCtrlHeadO3GeneralShortKeyPressTime.ValidateAcrossRecset = true;
					num = (short)1279262722;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.indexCntrlHeadO3ConventionalO3HHCHButtonFeature_A19650LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.idCntrlHeadO3ConventionalO3HHCHButtonFeature_A19650LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏏병ꃓꓕ듗鋙맛뿝蓟귡ퟣꗥ蟧蓩髫语黯蛱鷳駵雷鯹郻뇽㏿䨁䰃䔅䀇䠉礋稍搏紑稓倕紗笙栛欝刟䜡笣朥ᤧጩᨫᬭ/", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650LovStrs);
					this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.DataTransferOrder = 3;
					num = (short)1320026128;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields != null)
					{
						num = (short)1050738692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_784;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_9D;
					}
					continue;
				case 9:
					this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649 = new global::AcpBusinessLayer.AcpSparseLOVField(153, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.indexCntrlHeadO3ConventionalO3HHCHButtonBCO_A19649LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.idCntrlHeadO3ConventionalO3HHCHButtonBCO_A19649LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏏병ꃓꓕ듗鋙맛뿝蓟귡ퟣꗥ蟧蓩髫语黯蛱鷳駵雷鯹郻뇽㏿䨁䰃䔅䀇䠉礋稍搏紑稓吕嬗唙䌛弝ᄟᬡሣሥᄧ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.CntrlHeadO3ConventionalO3HHCHButtonBCO_A19649LovStrs);
					this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.DataTransferOrder = -1;
					num = (short)103612417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_537;
				case 11:
				{
					num = (short)453312512;
					short num3 = num;
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苏돑냓鏕꫗뷙鿛ꫝ鋟軡곣菥觧軩ꏫ\udded럯韱髳鏵諷鯹郻닽濿氁挃䴅洇猉尋簍甏愑朓䈕焗眙礛", a_)))
					{
						num = (short)1040252953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_784;
				}
				case 12:
					num = (short)339017735;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
				{
					num = (short)1537524665;
					short num4 = num;
					num = (short)1572520889;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_370;
					default:
						num = (short)645922816;
						if (num != 0)
						{
						}
						this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.indexCntrlHeadO3TrunkingO3HHCHButtonFeature_A19750LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.idCntrlHeadO3TrunkingO3HHCHButtonFeature_A19750LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏏병ꃓꓕ듗鋙맛뿝蓟귡ퟣ닥髧鿩苫藭駯鳱鏳맵쯷당듻뷽䣿䀁焃爅簇攉戋䠍甏猑怓挕樗缙䌛弝ᄟᬡጣጥᠧ", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750LovStrs);
						this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.DataTransferOrder = 5;
						num = (short)1896611863;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꃓꓕ듗鋙맛뿝蓟귡ퟣꗥ蟧蓩髫语黯蛱鷳駵雷鯹郻뇽㏿䨁䰃䔅䀇䠉礋稍搏紑稓倕紗笙栛欝刟䜡笣朥ᤧጩᨫᬭ/", a_)))
					{
						num = (short)1416036358;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_53C;
				case 15:
					this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749 = new global::AcpBusinessLayer.AcpSparseLOVField(153, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.indexCntrlHeadO3TrunkingO3HHCHButtonBCO_A19749LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.idCntrlHeadO3TrunkingO3HHCHButtonBCO_A19749LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏏병ꃓꓕ듗鋙맛뿝蓟귡ퟣ닥髧鿩苫藭駯鳱鏳맵쯷당듻뷽䣿䀁焃爅簇攉戋䰍匏崑䬓圕⤗⌙⬛⨝᤟", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.LOVs.CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749LovStrs);
					this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.DataTransferOrder = -1;
					num = (short)2142175235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_53C;
				case 17:
					this.cntrlHeadO3HHCHButtonName_A22523 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_TOPRIGHTBUTTON, this, global::AllFeatures.CodeplugGuid.b("鏏병ꃓꓕ듗鋙맛뿝蓟귡ퟣ껥ꃧꧩꓫ곭藯蛱胳駵雷듹鷻鏽旿崁䔃㐅㨇㼉㸋㴍", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.cntrlHeadO3HHCHButtonName_A22523.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cntrlHeadO3HHCHButtonName_A22523.DataTransferOrder = -1;
					num = (short)2096955414;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꃓꓕ듗鋙맛뿝蓟귡ퟣ껥ꃧꧩꓫ곭藯蛱胳駵雷뇹駻蟽忿䌁㘃㐅㴇㠉㸋", a_)))
					{
						num = (short)1246429210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C3;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苏돑냓鏕꫗뷙鿛ꫝ鋟軡곣菥觧軩ꏫ\udded럯韱髳鏵諷鯹郻귽棿洁瘃爅䌇漉甋帍戏眑朓攕䰗猙焛笝", a_)))
					{
						num = (short)1551499269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E4;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꃓꓕ듗鋙맛뿝蓟귡ퟣꗥ蟧蓩髫语黯蛱鷳駵雷鯹郻뇽㏿䨁䰃䔅䀇䠉礋稍搏紑稓吕嬗唙䌛弝ᄟᬡሣሥᄧ", a_)))
					{
						num = (short)2054160393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15C;
				case 21:
					goto IL_C3;
				case 22:
					goto IL_45A;
				case 23:
					num = (short)262733825;
					if (num != 0)
					{
					}
					goto IL_110;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꃓꓕ듗鋙맛뿝蓟귡ퟣ닥髧鿩苫藭駯鳱鏳맵쯷당듻뷽䣿䀁焃爅簇攉戋䰍匏崑䬓圕⤗⌙⬛⨝᤟", a_)))
					{
						num = (short)836567055;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_358;
				case 25:
					this.radErgCtrlHeadO3GeneralLongKeyPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("苏돑냓鏕꫗뷙鿛ꫝ鋟軡곣菥觧軩ꏫ\udded럯韱髳鏵諷鯹郻닽濿氁挃䴅洇猉尋簍甏愑朓䈕焗眙礛", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
					this.radErgCtrlHeadO3GeneralLongKeyPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgCtrlHeadO3GeneralLongKeyPressTime.DataTransferOrder = -1;
					((global::AcpBusinessLayer.AcpSimpleRangeField)this.radErgCtrlHeadO3GeneralLongKeyPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.radErgCtrlHeadO3GeneralLongKeyPressTime.ShowHexValue = false;
					this.radErgCtrlHeadO3GeneralLongKeyPressTime.ValidateAcrossRecset = true;
					num = (short)2047279114;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					this.cntrlHeadO3HHCHButtonKey_A22522 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鏏병ꃓꓕ듗鋙맛뿝蓟귡ퟣ껥ꃧꧩꓫ곭藯蛱胳駵雷뇹駻蟽忿䌁㘃㐅㴇㠉㸋", a_), global::CommonResources.AcgResources.ID_KEY, 20);
					this.cntrlHeadO3HHCHButtonKey_A22522.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cntrlHeadO3HHCHButtonKey_A22522.DataTransferOrder = -1;
					num = (short)1215758357;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					goto IL_370;
				}
				IL_9D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)219349004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_C3:
				num = (short)150208512;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_110:
				num = (short)1685389330;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_370:
				if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏏병ꃓꓕ듗鋙맛뿝蓟귡ퟣ닥髧鿩苫藭駯鳱鏳맵쯷당듻뷽䣿䀁焃爅簇攉戋䠍甏猑怓挕樗缙䌛弝ᄟᬡጣጥᠧ", a_)))
				{
					num = (short)769064973;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_110;
				IL_15C:
				num = (short)805699598;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E4:
				num = (short)1166016523;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_358:
				num = (short)921370651;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_45A:
				num = (short)1289682963;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_53C:
				num = (short)33357848;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_537:
			IL_784:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鿏黕郗駙铛ﻝꋟ韡郣鋥蟧蓩", a_);
			base.Id = 10210;
			base.UIName = global::CommonResources.AcgResources.ID_O3HHCHBUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008A70 RID: 35440 RVA: 0x00818824 File Offset: 0x00816A24
		public override void PopulateReferences()
		{
			short num = (short)683999233;
			if (num != 0)
			{
			}
			num = (short)1584963033;
			short num2 = num;
			num = (short)368221657;
			switch (num2 == num)
			{
			}
			num = (short)1398800384;
			short num3 = num;
			num = (short)205586432;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008A71 RID: 35441 RVA: 0x008188D4 File Offset: 0x00816AD4
		public override void DropReferences()
		{
			short num = (short)685309953;
			if (num != 0)
			{
			}
			num = (short)1696879739;
			short num2 = num;
			num = (short)1717720187;
			switch (num2 == num)
			{
			}
			num = (short)1376059392;
			short num3 = num;
			num = (short)1764491264;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008A72 RID: 35442 RVA: 0x0081897C File Offset: 0x00816B7C
		public override void SetConstraints()
		{
			short num = (short)1127039595;
			short num2 = num;
			num = (short)2005811819;
			switch (num2 == num)
			{
			}
			num = (short)2093678593;
			if (num != 0)
			{
			}
			num = (short)1585774592;
			short num3 = num;
			num = (short)50266112;
			if (num != 0)
			{
			}
			this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.ConStandaloneRadioSystemEnableApp);
			this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.ConControlHeadFeaturesSelect);
			this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.ConStandaloneRadioSystemEnableApp);
			this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.ConControlHeadFeaturesSelect);
			this.cntrlHeadO3HHCHButtonName_A22523.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06008A73 RID: 35443 RVA: 0x00818A98 File Offset: 0x00816C98
		public override void SetupDependencies()
		{
			short num = (short)1551002020;
			short num2 = num;
			num = (short)632449444;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1628569600;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)813498368;
			if (num != 0)
			{
			}
			num = (short)112590849;
			if (num != 0)
			{
			}
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650);
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561.AddDependentObject(this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650);
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550.AddDependentObject(this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750);
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561.AddDependentObject(this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750);
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550.AddDependentObject(this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750);
			this.RefRadioWide.Features.RadWideFeaturesChannelFallbackEnable.AddDependentObject(this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650);
			this.RefRadioWide.Features.RadWideFeaturesChannelFallbackEnable.AddDependentObject(this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750);
		}

		// Token: 0x17004631 RID: 17969
		// (get) Token: 0x06008A74 RID: 35444 RVA: 0x00818C24 File Offset: 0x00816E24
		public bool HasDiffs
		{
			get
			{
				short num = (short)1629883838;
				short num2 = num;
				num = (short)838274494;
				switch (num2 == num)
				{
				default:
				{
					num = (short)26804224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)921501697;
				if (num != 0)
				{
				}
				num = (short)393740288;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004632 RID: 17970
		// (get) Token: 0x06008A75 RID: 35445 RVA: 0x00818CD8 File Offset: 0x00816ED8
		// (set) Token: 0x06008A76 RID: 35446 RVA: 0x00818D8C File Offset: 0x00816F8C
		public int CntrlHeadO3ConventionalO3HHCHButtonBCO_A19649Value
		{
			get
			{
				short num = (short)1506053518;
				short num2 = num;
				num = (short)1576832398;
				switch (num2 == num)
				{
				default:
				{
					num = (short)402587648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1416298496;
				if (num != 0)
				{
				}
				num = (short)802357249;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.Value;
			}
			set
			{
				short num = (short)1997800773;
				short num2 = num;
				num = (short)1659307333;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1830027264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1869348865;
				if (num != 0)
				{
				}
				num = (short)28966912;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.Value = value;
			}
		}

		// Token: 0x17004633 RID: 17971
		// (get) Token: 0x06008A77 RID: 35447 RVA: 0x00818E40 File Offset: 0x00817040
		// (set) Token: 0x06008A78 RID: 35448 RVA: 0x00818EF8 File Offset: 0x008170F8
		public string CntrlHeadO3ConventionalO3HHCHButtonBCO_A19649_UIValue
		{
			get
			{
				short num = (short)878880136;
				short num2 = num;
				num = (short)1896785288;
				switch (num2 == num)
				{
				default:
				{
					num = (short)918159360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1300299777;
				if (num != 0)
				{
				}
				num = (short)936509440;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.UIValue;
			}
			set
			{
				short num = (short)1948592099;
				short num2 = num;
				num = (short)871507939;
				switch (num2 == num)
				{
				default:
				{
					num = (short)60489728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)297140225;
				if (num != 0)
				{
				}
				num = (short)994115584;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.UIValue = value;
			}
		}

		// Token: 0x17004634 RID: 17972
		// (get) Token: 0x06008A79 RID: 35449 RVA: 0x00818FAC File Offset: 0x008171AC
		public global::AcpBusinessLayer.AcpListField CntrlHeadO3ConventionalO3HHCHButtonBCO_A19649
		{
			get
			{
				short num = (short)2032975277;
				short num2 = num;
				num = (short)325238189;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1340014592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)70647808;
				if (num != 0)
				{
				}
				num = (short)1810563073;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649;
			}
		}

		// Token: 0x17004635 RID: 17973
		// (get) Token: 0x06008A7A RID: 35450 RVA: 0x00819060 File Offset: 0x00817260
		// (set) Token: 0x06008A7B RID: 35451 RVA: 0x00819114 File Offset: 0x00817314
		public bool CntrlHeadO3ConventionalO3HHCHButtonBCO_A19649_Applicable
		{
			get
			{
				short num = (short)1946970531;
				short num2 = num;
				num = (short)1784244643;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1959854080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1821769729;
				if (num != 0)
				{
				}
				num = (short)1114898432;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.Applicable;
			}
			set
			{
				short num = (short)897240766;
				short num2 = num;
				num = (short)99471038;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2013528064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1575550977;
				if (num != 0)
				{
				}
				num = (short)316604416;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.Applicable = value;
			}
		}

		// Token: 0x17004636 RID: 17974
		// (get) Token: 0x06008A7C RID: 35452 RVA: 0x008191C8 File Offset: 0x008173C8
		// (set) Token: 0x06008A7D RID: 35453 RVA: 0x0081927C File Offset: 0x0081747C
		public bool CntrlHeadO3ConventionalO3HHCHButtonBCO_A19649_Valid
		{
			get
			{
				short num = (short)196900639;
				short num2 = num;
				num = (short)888960799;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2030764032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1156251648;
				if (num != 0)
				{
				}
				num = (short)1669791745;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.Valid;
			}
			set
			{
				short num = (short)1808098601;
				short num2 = num;
				num = (short)1252746537;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1387724800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1402273793;
				if (num != 0)
				{
				}
				num = (short)938868736;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.Valid = value;
			}
		}

		// Token: 0x17004637 RID: 17975
		// (get) Token: 0x06008A7E RID: 35454 RVA: 0x00819330 File Offset: 0x00817530
		// (set) Token: 0x06008A7F RID: 35455 RVA: 0x008193E4 File Offset: 0x008175E4
		public bool CntrlHeadO3ConventionalO3HHCHButtonBCO_A19649_Visible
		{
			get
			{
				short num = (short)1015755819;
				short num2 = num;
				num = (short)1835480107;
				switch (num2 == num)
				{
				default:
				{
					num = (short)966131712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1804533761;
				if (num != 0)
				{
				}
				num = (short)637403136;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.Visible;
			}
			set
			{
				short num = (short)1005616136;
				short num2 = num;
				num = (short)1093696520;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1637744640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)697892864;
				if (num != 0)
				{
				}
				num = (short)802553857;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.Visible = value;
			}
		}

		// Token: 0x17004638 RID: 17976
		// (get) Token: 0x06008A80 RID: 35456 RVA: 0x00819498 File Offset: 0x00817698
		// (set) Token: 0x06008A81 RID: 35457 RVA: 0x00819550 File Offset: 0x00817750
		public bool CntrlHeadO3ConventionalO3HHCHButtonBCO_A19649_Editable
		{
			get
			{
				short num = (short)2067146227;
				short num2 = num;
				num = (short)2080318963;
				switch (num2 == num)
				{
				default:
				{
					num = (short)458883072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1099169792;
				if (num != 0)
				{
				}
				num = (short)1496580097;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.Editable;
			}
			set
			{
				short num = (short)306397291;
				short num2 = num;
				num = (short)1639989355;
				switch (num2 == num)
				{
				default:
				{
					num = (short)803209216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)694550529;
				if (num != 0)
				{
				}
				num = (short)664731648;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.Editable = value;
			}
		}

		// Token: 0x17004639 RID: 17977
		// (get) Token: 0x06008A82 RID: 35458 RVA: 0x00819604 File Offset: 0x00817804
		internal string CntrlHeadO3ConventionalO3HHCHButtonBCO_A19649_UILabel
		{
			get
			{
				short num = (short)573738512;
				short num2 = num;
				num = (short)1282969104;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1480458240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)346423297;
				if (num != 0)
				{
				}
				num = (short)831389696;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.UIName;
			}
		}

		// Token: 0x1700463A RID: 17978
		// (get) Token: 0x06008A83 RID: 35459 RVA: 0x008196B8 File Offset: 0x008178B8
		// (set) Token: 0x06008A84 RID: 35460 RVA: 0x0081976C File Offset: 0x0081796C
		internal bool CntrlHeadO3ConventionalO3HHCHButtonBCO_A19649_HiddenStatic
		{
			get
			{
				short num = (short)1926486617;
				short num2 = num;
				num = (short)1006688857;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2143354880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)5046273;
				if (num != 0)
				{
				}
				num = (short)1936523264;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.HiddenStatic;
			}
			set
			{
				short num = (short)13571190;
				short num2 = num;
				num = (short)749409398;
				switch (num2 == num)
				{
				default:
				{
					num = (short)934150144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)620888065;
				if (num != 0)
				{
				}
				num = (short)246415360;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.HiddenStatic = value;
			}
		}

		// Token: 0x1700463B RID: 17979
		// (get) Token: 0x06008A85 RID: 35461 RVA: 0x00819820 File Offset: 0x00817A20
		// (set) Token: 0x06008A86 RID: 35462 RVA: 0x008198D8 File Offset: 0x00817AD8
		internal bool CntrlHeadO3ConventionalO3HHCHButtonBCO_A19649_HiddenDynamic
		{
			get
			{
				short num = (short)490536961;
				if (num != 0)
				{
				}
				num = (short)675282944;
				short num2 = num;
				num = (short)1946826797;
				short num3 = num;
				num = (short)1374107693;
				switch (num3 == num)
				{
				}
				num = (short)987561984;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.HiddenDynamic;
			}
			set
			{
				short num = (short)1273899257;
				short num2 = num;
				num = (short)14756089;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1636433920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1936326657;
				if (num != 0)
				{
				}
				num = (short)984088576;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649.HiddenDynamic = value;
			}
		}

		// Token: 0x1700463C RID: 17980
		// (get) Token: 0x06008A87 RID: 35463 RVA: 0x0081998C File Offset: 0x00817B8C
		public bool CntrlHeadO3ConventionalO3HHCHButtonBCO_A19649_HasDiffs
		{
			get
			{
				short num = (short)2135293953;
				if (num != 0)
				{
				}
				num = (short)842203136;
				short num2 = num;
				num = (short)324129288;
				short num3 = num;
				num = (short)1232065032;
				switch (num3 == num)
				{
				}
				num = (short)1487273984;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649._HasDiffs;
			}
		}

		// Token: 0x1700463D RID: 17981
		// (get) Token: 0x06008A88 RID: 35464 RVA: 0x00819A3C File Offset: 0x00817C3C
		// (set) Token: 0x06008A89 RID: 35465 RVA: 0x00819AF0 File Offset: 0x00817CF0
		public int CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650Value
		{
			get
			{
				short num = (short)1838865454;
				short num2 = num;
				num = (short)711973934;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1630011392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)98828289;
				if (num != 0)
				{
				}
				num = (short)962592768;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Value;
			}
			set
			{
				short num = (short)1842819814;
				short num2 = num;
				num = (short)375927526;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2018115584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)348782592;
				if (num != 0)
				{
				}
				num = (short)1988165633;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Value = value;
			}
		}

		// Token: 0x1700463E RID: 17982
		// (get) Token: 0x06008A8A RID: 35466 RVA: 0x00819BAC File Offset: 0x00817DAC
		// (set) Token: 0x06008A8B RID: 35467 RVA: 0x00819C60 File Offset: 0x00817E60
		public string CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650_UIValue
		{
			get
			{
				short num = (short)1728025980;
				short num2 = num;
				num = (short)1967494524;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1666121728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2120286209;
				if (num != 0)
				{
				}
				num = (short)338755584;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.UIValue;
			}
			set
			{
				short num = (short)738131969;
				if (num != 0)
				{
				}
				num = (short)1494417408;
				short num2 = num;
				num = (short)284349988;
				short num3 = num;
				num = (short)1947653668;
				switch (num3 == num)
				{
				}
				num = (short)1269760000;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.UIValue = value;
			}
		}

		// Token: 0x1700463F RID: 17983
		// (get) Token: 0x06008A8C RID: 35468 RVA: 0x00819D18 File Offset: 0x00817F18
		public global::AcpBusinessLayer.AcpListField CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650
		{
			get
			{
				short num = (short)27556842;
				short num2 = num;
				num = (short)1128430570;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1705771008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1888092160;
				if (num != 0)
				{
				}
				num = (short)1960640513;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650;
			}
		}

		// Token: 0x17004640 RID: 17984
		// (get) Token: 0x06008A8D RID: 35469 RVA: 0x00819DC8 File Offset: 0x00817FC8
		// (set) Token: 0x06008A8E RID: 35470 RVA: 0x00819E78 File Offset: 0x00818078
		public bool CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650_Applicable
		{
			get
			{
				short num = (short)1059293068;
				short num2 = num;
				num = (short)1445037964;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1610285056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)876019712;
				if (num != 0)
				{
				}
				num = (short)138543105;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Applicable;
			}
			set
			{
				short num = (short)968228865;
				if (num != 0)
				{
				}
				num = (short)1627717632;
				short num2 = num;
				num = (short)1861766178;
				short num3 = num;
				num = (short)518474786;
				switch (num3 == num)
				{
				}
				num = (short)1433337856;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Applicable = value;
			}
		}

		// Token: 0x17004641 RID: 17985
		// (get) Token: 0x06008A8F RID: 35471 RVA: 0x00819F34 File Offset: 0x00818134
		// (set) Token: 0x06008A90 RID: 35472 RVA: 0x00819FE4 File Offset: 0x008181E4
		public bool CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650_Valid
		{
			get
			{
				short num = (short)1498273824;
				short num2 = num;
				num = (short)1468258336;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1459552256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)584646657;
				if (num != 0)
				{
				}
				num = (short)1998782464;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Valid;
			}
			set
			{
				short num = (short)116861240;
				short num2 = num;
				num = (short)192489784;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2127298560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1232732160;
				if (num != 0)
				{
				}
				num = (short)638189569;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Valid = value;
			}
		}

		// Token: 0x17004642 RID: 17986
		// (get) Token: 0x06008A91 RID: 35473 RVA: 0x0081A098 File Offset: 0x00818298
		// (set) Token: 0x06008A92 RID: 35474 RVA: 0x0081A14C File Offset: 0x0081834C
		public bool CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650_Visible
		{
			get
			{
				short num = (short)1845318583;
				short num2 = num;
				num = (short)536761271;
				switch (num2 == num)
				{
				default:
				{
					num = (short)258670592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)261423105;
				if (num != 0)
				{
				}
				num = (short)916717568;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Visible;
			}
			set
			{
				short num = (short)831780746;
				short num2 = num;
				num = (short)1343551370;
				switch (num2 == num)
				{
				default:
				{
					num = (short)719585280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1267793920;
				if (num != 0)
				{
				}
				num = (short)1046347777;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Visible = value;
			}
		}

		// Token: 0x17004643 RID: 17987
		// (get) Token: 0x06008A93 RID: 35475 RVA: 0x0081A200 File Offset: 0x00818400
		// (set) Token: 0x06008A94 RID: 35476 RVA: 0x0081A2B8 File Offset: 0x008184B8
		public bool CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650_Editable
		{
			get
			{
				short num = (short)729735097;
				short num2 = num;
				num = (short)2075320249;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1121845248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1950679040;
				if (num != 0)
				{
				}
				num = (short)188219393;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Editable;
			}
			set
			{
				short num = (short)1245174724;
				short num2 = num;
				num = (short)2091703236;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1535836160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)623771649;
				if (num != 0)
				{
				}
				num = (short)315097088;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.Editable = value;
			}
		}

		// Token: 0x17004644 RID: 17988
		// (get) Token: 0x06008A95 RID: 35477 RVA: 0x0081A36C File Offset: 0x0081856C
		internal string CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650_UILabel
		{
			get
			{
				short num = (short)66492105;
				short num2 = num;
				num = (short)66098889;
				switch (num2 == num)
				{
				default:
				{
					num = (short)347734016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)169607168;
				if (num != 0)
				{
				}
				num = (short)887226369;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.UIName;
			}
		}

		// Token: 0x17004645 RID: 17989
		// (get) Token: 0x06008A96 RID: 35478 RVA: 0x0081A420 File Offset: 0x00818620
		// (set) Token: 0x06008A97 RID: 35479 RVA: 0x0081A4D8 File Offset: 0x008186D8
		internal bool CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650_HiddenStatic
		{
			get
			{
				short num = (short)1678710615;
				short num2 = num;
				num = (short)886380375;
				switch (num2 == num)
				{
				default:
				{
					num = (short)554369024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)136970241;
				if (num != 0)
				{
				}
				num = (short)803405824;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.HiddenStatic;
			}
			set
			{
				short num = (short)900283301;
				short num2 = num;
				num = (short)205863845;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1528037376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)596705281;
				if (num != 0)
				{
				}
				num = (short)1530396672;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.HiddenStatic = value;
			}
		}

		// Token: 0x17004646 RID: 17990
		// (get) Token: 0x06008A98 RID: 35480 RVA: 0x0081A58C File Offset: 0x0081878C
		// (set) Token: 0x06008A99 RID: 35481 RVA: 0x0081A640 File Offset: 0x00818840
		internal bool CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650_HiddenDynamic
		{
			get
			{
				short num = (short)1122385003;
				short num2 = num;
				num = (short)1639005291;
				switch (num2 == num)
				{
				default:
				{
					num = (short)403701760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)838205441;
				if (num != 0)
				{
				}
				num = (short)1433862144;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.HiddenDynamic;
			}
			set
			{
				short num = (short)665605919;
				short num2 = num;
				num = (short)1593988895;
				switch (num2 == num)
				{
				default:
				{
					num = (short)649068544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)461570049;
				if (num != 0)
				{
				}
				num = (short)969146368;
				if (num != 0)
				{
				}
				this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650.HiddenDynamic = value;
			}
		}

		// Token: 0x17004647 RID: 17991
		// (get) Token: 0x06008A9A RID: 35482 RVA: 0x0081A6F4 File Offset: 0x008188F4
		public bool CntrlHeadO3ConventionalO3HHCHButtonFeature_A19650_HasDiffs
		{
			get
			{
				short num = (short)844840023;
				short num2 = num;
				num = (short)1560427607;
				switch (num2 == num)
				{
				default:
				{
					num = (short)912523264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)950534145;
				if (num != 0)
				{
				}
				num = (short)803209216;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650._HasDiffs;
			}
		}

		// Token: 0x17004648 RID: 17992
		// (get) Token: 0x06008A9B RID: 35483 RVA: 0x0081A7A8 File Offset: 0x008189A8
		// (set) Token: 0x06008A9C RID: 35484 RVA: 0x0081A860 File Offset: 0x00818A60
		public int CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749Value
		{
			get
			{
				short num = (short)1624445335;
				short num2 = num;
				num = (short)1780093335;
				switch (num2 == num)
				{
				default:
				{
					num = (short)58523648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1607991296;
				if (num != 0)
				{
				}
				num = (short)940244993;
				if (num != 0)
				{
				}
				return this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.Value;
			}
			set
			{
				short num = (short)894838868;
				short num2 = num;
				num = (short)98510932;
				switch (num2 == num)
				{
				}
				num = (short)501743616;
				if (num != 0)
				{
				}
				num = (short)60162049;
				if (num != 0)
				{
				}
				num = (short)1535574016;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.Value = value;
			}
		}

		// Token: 0x17004649 RID: 17993
		// (get) Token: 0x06008A9D RID: 35485 RVA: 0x0081A918 File Offset: 0x00818B18
		// (set) Token: 0x06008A9E RID: 35486 RVA: 0x0081A9D0 File Offset: 0x00818BD0
		public string CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749_UIValue
		{
			get
			{
				short num = (short)272129306;
				short num2 = num;
				num = (short)811949338;
				switch (num2 == num)
				{
				}
				num = (short)615579649;
				if (num != 0)
				{
				}
				num = (short)1760231424;
				if (num != 0)
				{
				}
				num = (short)1082785792;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.UIValue;
			}
			set
			{
				short num = (short)440321764;
				short num2 = num;
				num = (short)1119667940;
				switch (num2 == num)
				{
				}
				num = (short)2006122496;
				if (num != 0)
				{
				}
				num = (short)653852673;
				if (num != 0)
				{
				}
				num = (short)1082785792;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.UIValue = value;
			}
		}

		// Token: 0x1700464A RID: 17994
		// (get) Token: 0x06008A9F RID: 35487 RVA: 0x0081AA88 File Offset: 0x00818C88
		public global::AcpBusinessLayer.AcpListField CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749
		{
			get
			{
				short num = (short)1738230886;
				short num2 = num;
				num = (short)1354320998;
				switch (num2 == num)
				{
				}
				num = (short)770375680;
				if (num != 0)
				{
				}
				num = (short)1576665089;
				if (num != 0)
				{
				}
				num = (short)482017280;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749;
			}
		}

		// Token: 0x1700464B RID: 17995
		// (get) Token: 0x06008AA0 RID: 35488 RVA: 0x0081AB38 File Offset: 0x00818D38
		// (set) Token: 0x06008AA1 RID: 35489 RVA: 0x0081ABEC File Offset: 0x00818DEC
		public bool CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749_Applicable
		{
			get
			{
				short num = (short)994032093;
				short num2 = num;
				num = (short)930920925;
				switch (num2 == num)
				{
				}
				num = (short)1496514561;
				if (num != 0)
				{
				}
				num = (short)1385365504;
				if (num != 0)
				{
				}
				num = (short)1772224512;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.Applicable;
			}
			set
			{
				short num = (short)1168131593;
				short num2 = num;
				num = (short)241387017;
				switch (num2 == num)
				{
				}
				num = (short)1385431041;
				if (num != 0)
				{
				}
				num = (short)25427968;
				if (num != 0)
				{
				}
				num = (short)7667712;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.Applicable = value;
			}
		}

		// Token: 0x1700464C RID: 17996
		// (get) Token: 0x06008AA2 RID: 35490 RVA: 0x0081ACA0 File Offset: 0x00818EA0
		// (set) Token: 0x06008AA3 RID: 35491 RVA: 0x0081AD54 File Offset: 0x00818F54
		public bool CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749_Valid
		{
			get
			{
				short num = (short)1591677313;
				short num2 = num;
				num = (short)166793601;
				switch (num2 == num)
				{
				}
				num = (short)827916289;
				if (num != 0)
				{
				}
				num = (short)198443008;
				if (num != 0)
				{
				}
				num = (short)1855717376;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.Valid;
			}
			set
			{
				short num = (short)980307078;
				short num2 = num;
				num = (short)1946111110;
				switch (num2 == num)
				{
				}
				num = (short)1499463680;
				if (num != 0)
				{
				}
				num = (short)1108017153;
				if (num != 0)
				{
				}
				num = (short)1662648320;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.Valid = value;
			}
		}

		// Token: 0x1700464D RID: 17997
		// (get) Token: 0x06008AA4 RID: 35492 RVA: 0x0081AE0C File Offset: 0x0081900C
		// (set) Token: 0x06008AA5 RID: 35493 RVA: 0x0081AEC0 File Offset: 0x008190C0
		public bool CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749_Visible
		{
			get
			{
				short num = (short)257223954;
				short num2 = num;
				num = (short)1394404626;
				switch (num2 == num)
				{
				}
				num = (short)1671233536;
				if (num != 0)
				{
				}
				num = (short)1601110017;
				if (num != 0)
				{
				}
				num = (short)804061184;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.Visible;
			}
			set
			{
				short num = (short)9330664;
				short num2 = num;
				num = (short)1784897512;
				switch (num2 == num)
				{
				}
				num = (short)1254096896;
				if (num != 0)
				{
				}
				num = (short)1854734337;
				if (num != 0)
				{
				}
				num = (short)1866596352;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.Visible = value;
			}
		}

		// Token: 0x1700464E RID: 17998
		// (get) Token: 0x06008AA6 RID: 35494 RVA: 0x0081AF74 File Offset: 0x00819174
		// (set) Token: 0x06008AA7 RID: 35495 RVA: 0x0081B02C File Offset: 0x0081922C
		public bool CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749_Editable
		{
			get
			{
				short num = (short)855027522;
				short num2 = num;
				num = (short)28421954;
				switch (num2 == num)
				{
				}
				num = (short)1738866689;
				if (num != 0)
				{
				}
				num = (short)1628176384;
				if (num != 0)
				{
				}
				num = (short)1148846080;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.Editable;
			}
			set
			{
				short num = (short)1741710764;
				short num2 = num;
				num = (short)1374774700;
				switch (num2 == num)
				{
				}
				num = (short)1689518080;
				if (num != 0)
				{
				}
				num = (short)1689255937;
				if (num != 0)
				{
				}
				num = (short)1540161536;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.Editable = value;
			}
		}

		// Token: 0x1700464F RID: 17999
		// (get) Token: 0x06008AA8 RID: 35496 RVA: 0x0081B0E0 File Offset: 0x008192E0
		internal string CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749_UILabel
		{
			get
			{
				short num = (short)1608395649;
				short num2 = num;
				num = (short)1306012545;
				switch (num2 == num)
				{
				}
				num = (short)631898112;
				if (num != 0)
				{
				}
				num = (short)947060737;
				if (num != 0)
				{
				}
				num = (short)1095630848;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.UIName;
			}
		}

		// Token: 0x17004650 RID: 18000
		// (get) Token: 0x06008AA9 RID: 35497 RVA: 0x0081B194 File Offset: 0x00819394
		// (set) Token: 0x06008AAA RID: 35498 RVA: 0x0081B24C File Offset: 0x0081944C
		internal bool CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749_HiddenStatic
		{
			get
			{
				short num = (short)754872419;
				short num2 = num;
				num = (short)2110025827;
				switch (num2 == num)
				{
				}
				num = (short)501809153;
				if (num != 0)
				{
				}
				num = (short)799145984;
				if (num != 0)
				{
				}
				num = (short)1358430208;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.HiddenStatic;
			}
			set
			{
				short num = (short)1097108853;
				short num2 = num;
				num = (short)1539870069;
				switch (num2 == num)
				{
				}
				num = (short)1721237505;
				if (num != 0)
				{
				}
				num = (short)1356267520;
				if (num != 0)
				{
				}
				num = (short)2073755648;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.HiddenStatic = value;
			}
		}

		// Token: 0x17004651 RID: 18001
		// (get) Token: 0x06008AAB RID: 35499 RVA: 0x0081B300 File Offset: 0x00819500
		// (set) Token: 0x06008AAC RID: 35500 RVA: 0x0081B3B8 File Offset: 0x008195B8
		internal bool CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749_HiddenDynamic
		{
			get
			{
				short num = (short)2118114007;
				short num2 = num;
				num = (short)688249559;
				switch (num2 == num)
				{
				}
				num = (short)692846593;
				if (num != 0)
				{
				}
				num = (short)1446707200;
				if (num != 0)
				{
				}
				num = (short)686686208;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.HiddenDynamic;
			}
			set
			{
				short num = (short)297531410;
				short num2 = num;
				num = (short)134346770;
				switch (num2 == num)
				{
				}
				num = (short)278921217;
				if (num != 0)
				{
				}
				num = (short)1424293888;
				if (num != 0)
				{
				}
				num = (short)872677376;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.HiddenDynamic = value;
			}
		}

		// Token: 0x17004652 RID: 18002
		// (get) Token: 0x06008AAD RID: 35501 RVA: 0x0081B46C File Offset: 0x0081966C
		public bool CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749_HasDiffs
		{
			get
			{
				short num = (short)1928539936;
				short num2 = num;
				num = (short)1604071200;
				switch (num2 == num)
				{
				}
				num = (short)750845953;
				if (num != 0)
				{
				}
				num = (short)1978466304;
				if (num != 0)
				{
				}
				num = (short)1600716800;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749._HasDiffs;
			}
		}

		// Token: 0x17004653 RID: 18003
		// (get) Token: 0x06008AAE RID: 35502 RVA: 0x0081B520 File Offset: 0x00819720
		// (set) Token: 0x06008AAF RID: 35503 RVA: 0x0081B5D4 File Offset: 0x008197D4
		public int CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750Value
		{
			get
			{
				short num = (short)1031940509;
				short num2 = num;
				num = (short)10627485;
				switch (num2 == num)
				{
				}
				num = (short)612696064;
				if (num != 0)
				{
				}
				num = (short)1388380161;
				if (num != 0)
				{
				}
				num = (short)1995046912;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Value;
			}
			set
			{
				short num = (short)173121623;
				short num2 = num;
				num = (short)1940496471;
				switch (num2 == num)
				{
				}
				num = (short)813629441;
				if (num != 0)
				{
				}
				num = (short)1996029952;
				if (num != 0)
				{
				}
				num = (short)1192820736;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Value = value;
			}
		}

		// Token: 0x17004654 RID: 18004
		// (get) Token: 0x06008AB0 RID: 35504 RVA: 0x0081B68C File Offset: 0x0081988C
		// (set) Token: 0x06008AB1 RID: 35505 RVA: 0x0081B744 File Offset: 0x00819944
		public string CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750_UIValue
		{
			get
			{
				short num = (short)1487499658;
				short num2 = num;
				num = (short)1732669834;
				switch (num2 == num)
				{
				}
				num = (short)702545920;
				if (num != 0)
				{
				}
				num = (short)657063937;
				if (num != 0)
				{
				}
				num = (short)979107840;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.UIValue;
			}
			set
			{
				short num = (short)2006356354;
				short num2 = num;
				num = (short)1148359042;
				switch (num2 == num)
				{
				}
				num = (short)1528102912;
				if (num != 0)
				{
				}
				num = (short)1715666945;
				if (num != 0)
				{
				}
				num = (short)1688731648;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.UIValue = value;
			}
		}

		// Token: 0x17004655 RID: 18005
		// (get) Token: 0x06008AB2 RID: 35506 RVA: 0x0081B7F8 File Offset: 0x008199F8
		public global::AcpBusinessLayer.AcpListField CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750
		{
			get
			{
				short num = (short)1487709573;
				short num2 = num;
				num = (short)279881093;
				switch (num2 == num)
				{
				}
				num = (short)1799684097;
				if (num != 0)
				{
				}
				num = (short)1234436096;
				if (num != 0)
				{
				}
				num = (short)1834483712;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750;
			}
		}

		// Token: 0x17004656 RID: 18006
		// (get) Token: 0x06008AB3 RID: 35507 RVA: 0x0081B8A8 File Offset: 0x00819AA8
		// (set) Token: 0x06008AB4 RID: 35508 RVA: 0x0081B95C File Offset: 0x00819B5C
		public bool CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750_Applicable
		{
			get
			{
				short num = (short)1547445095;
				short num2 = num;
				num = (short)53683047;
				switch (num2 == num)
				{
				}
				num = (short)700055553;
				if (num != 0)
				{
				}
				num = (short)1220149248;
				if (num != 0)
				{
				}
				num = (short)1922891776;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Applicable;
			}
			set
			{
				short num = (short)1162767774;
				short num2 = num;
				num = (short)1782541726;
				switch (num2 == num)
				{
				}
				num = (short)1798176769;
				if (num != 0)
				{
				}
				num = (short)1522925568;
				if (num != 0)
				{
				}
				num = (short)1839661056;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Applicable = value;
			}
		}

		// Token: 0x17004657 RID: 18007
		// (get) Token: 0x06008AB5 RID: 35509 RVA: 0x0081BA14 File Offset: 0x00819C14
		// (set) Token: 0x06008AB6 RID: 35510 RVA: 0x0081BAC8 File Offset: 0x00819CC8
		public bool CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750_Valid
		{
			get
			{
				short num = (short)1008686194;
				short num2 = num;
				num = (short)1076188274;
				switch (num2 == num)
				{
				}
				num = (short)156893185;
				if (num != 0)
				{
				}
				num = (short)1127088128;
				if (num != 0)
				{
				}
				num = (short)172883968;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Valid;
			}
			set
			{
				short num = (short)553492547;
				short num2 = num;
				num = (short)623222851;
				switch (num2 == num)
				{
				}
				num = (short)1072300032;
				if (num != 0)
				{
				}
				num = (short)1790443521;
				if (num != 0)
				{
				}
				num = (short)482738176;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Valid = value;
			}
		}

		// Token: 0x17004658 RID: 18008
		// (get) Token: 0x06008AB7 RID: 35511 RVA: 0x0081BB80 File Offset: 0x00819D80
		// (set) Token: 0x06008AB8 RID: 35512 RVA: 0x0081BC34 File Offset: 0x00819E34
		public bool CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750_Visible
		{
			get
			{
				short num = (short)1927057194;
				short num2 = num;
				num = (short)411012906;
				switch (num2 == num)
				{
				}
				num = (short)1573453824;
				if (num != 0)
				{
				}
				num = (short)941555713;
				if (num != 0)
				{
				}
				num = (short)1638006784;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Visible;
			}
			set
			{
				short num = (short)1266297107;
				short num2 = num;
				num = (short)388704531;
				switch (num2 == num)
				{
				}
				num = (short)280035329;
				if (num != 0)
				{
				}
				num = (short)87949312;
				if (num != 0)
				{
				}
				num = (short)327745536;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Visible = value;
			}
		}

		// Token: 0x17004659 RID: 18009
		// (get) Token: 0x06008AB9 RID: 35513 RVA: 0x0081BCE8 File Offset: 0x00819EE8
		// (set) Token: 0x06008ABA RID: 35514 RVA: 0x0081BD9C File Offset: 0x00819F9C
		public bool CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750_Editable
		{
			get
			{
				short num = (short)1873674241;
				if (num != 0)
				{
				}
				num = (short)27677291;
				short num2 = num;
				num = (short)1209487979;
				switch (num2 == num)
				{
				}
				num = (short)194969600;
				if (num != 0)
				{
				}
				num = (short)1898250240;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Editable;
			}
			set
			{
				short num = (short)1797496302;
				short num2 = num;
				num = (short)1432002030;
				switch (num2 == num)
				{
				}
				num = (short)736952321;
				if (num != 0)
				{
				}
				num = (short)614072320;
				if (num != 0)
				{
				}
				num = (short)246218752;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.Editable = value;
			}
		}

		// Token: 0x1700465A RID: 18010
		// (get) Token: 0x06008ABB RID: 35515 RVA: 0x0081BE54 File Offset: 0x0081A054
		internal string CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750_UILabel
		{
			get
			{
				short num = (short)151305558;
				short num2 = num;
				num = (short)1524677974;
				switch (num2 == num)
				{
				}
				num = (short)835584001;
				if (num != 0)
				{
				}
				num = (short)1366753280;
				if (num != 0)
				{
				}
				num = (short)2009399296;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.UIName;
			}
		}

		// Token: 0x1700465B RID: 18011
		// (get) Token: 0x06008ABC RID: 35516 RVA: 0x0081BF08 File Offset: 0x0081A108
		// (set) Token: 0x06008ABD RID: 35517 RVA: 0x0081BFC0 File Offset: 0x0081A1C0
		internal bool CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750_HiddenStatic
		{
			get
			{
				short num = (short)1325071318;
				short num2 = num;
				num = (short)210107350;
				switch (num2 == num)
				{
				}
				num = (short)861470720;
				if (num != 0)
				{
				}
				num = (short)1204289537;
				if (num != 0)
				{
				}
				num = (short)1234305024;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.HiddenStatic;
			}
			set
			{
				short num = (short)1678514017;
				short num2 = num;
				num = (short)2010847073;
				switch (num2 == num)
				{
				}
				num = (short)1633484801;
				if (num != 0)
				{
				}
				num = (short)961871872;
				if (num != 0)
				{
				}
				num = (short)1456996352;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.HiddenStatic = value;
			}
		}

		// Token: 0x1700465C RID: 18012
		// (get) Token: 0x06008ABE RID: 35518 RVA: 0x0081C07C File Offset: 0x0081A27C
		// (set) Token: 0x06008ABF RID: 35519 RVA: 0x0081C130 File Offset: 0x0081A330
		internal bool CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750_HiddenDynamic
		{
			get
			{
				short num = (short)1883570177;
				if (num != 0)
				{
				}
				num = (short)915188148;
				short num2 = num;
				num = (short)1076734388;
				switch (num2 == num)
				{
				}
				num = (short)1244987392;
				if (num != 0)
				{
				}
				num = (short)1631780864;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.HiddenDynamic;
			}
			set
			{
				short num = (short)559316756;
				short num2 = num;
				num = (short)1914928916;
				switch (num2 == num)
				{
				}
				num = (short)1031471105;
				if (num != 0)
				{
				}
				num = (short)1239810048;
				if (num != 0)
				{
				}
				num = (short)897581056;
				short num3 = num;
				this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750.HiddenDynamic = value;
			}
		}

		// Token: 0x1700465D RID: 18013
		// (get) Token: 0x06008AC0 RID: 35520 RVA: 0x0081C1E4 File Offset: 0x0081A3E4
		public bool CntrlHeadO3TrunkingO3HHCHButtonFeature_A19750_HasDiffs
		{
			get
			{
				short num = (short)947612674;
				short num2 = num;
				num = (short)1917807618;
				switch (num2 == num)
				{
				}
				num = (short)1031798785;
				if (num != 0)
				{
				}
				num = (short)554303488;
				if (num != 0)
				{
				}
				num = (short)1849556992;
				short num3 = num;
				return this.cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750._HasDiffs;
			}
		}

		// Token: 0x1700465E RID: 18014
		// (get) Token: 0x06008AC1 RID: 35521 RVA: 0x0081C298 File Offset: 0x0081A498
		// (set) Token: 0x06008AC2 RID: 35522 RVA: 0x0081C34C File Offset: 0x0081A54C
		public string CntrlHeadO3HHCHButtonKey_A22522Value
		{
			get
			{
				short num = (short)320227605;
				short num2 = num;
				num = (short)2141473045;
				switch (num2 == num)
				{
				}
				num = (short)1544159233;
				if (num != 0)
				{
				}
				num = (short)945029120;
				if (num != 0)
				{
				}
				num = (short)922222592;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonKey_A22522.Value;
			}
			set
			{
				short num = (short)1358437446;
				short num2 = num;
				num = (short)566565958;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_C5:
					this.cntrlHeadO3HHCHButtonKey_A22522.Value = value;
					num = (short)1445003266;
					num3 = (int)((global::System.IntPtr)num);
					break;
				case 1:
					goto IL_5E;
				default:
				{
					num = (short)491454464;
					short num4 = num;
					goto IL_5E;
				}
				}
				for (;;)
				{
					IL_92:
					switch (num3)
					{
					case 0:
						goto IL_C5;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						continue;
					case 2:
						goto IL_E8;
					}
					IL_A4:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						return;
					}
					num = (short)248578048;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_E8:
				num = (short)138084353;
				if (num != 0)
				{
				}
				return;
				IL_5E:
				num = (short)202768384;
				if (num != 0)
				{
				}
				num = (short)1608056833;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_92;
			}
		}

		// Token: 0x1700465F RID: 18015
		// (get) Token: 0x06008AC3 RID: 35523 RVA: 0x0081C46C File Offset: 0x0081A66C
		// (set) Token: 0x06008AC4 RID: 35524 RVA: 0x0081C520 File Offset: 0x0081A720
		public string CntrlHeadO3HHCHButtonKey_A22522_UIValue
		{
			get
			{
				short num = (short)903362017;
				short num2 = num;
				num = (short)365508065;
				switch (num2 == num)
				{
				}
				num = (short)521994241;
				if (num != 0)
				{
				}
				num = (short)435093504;
				if (num != 0)
				{
				}
				num = (short)799735808;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonKey_A22522.Value;
			}
			set
			{
				short num = (short)463238666;
				short num2 = num;
				num = (short)975533578;
				switch (num2 == num)
				{
				}
				num = (short)1139671041;
				if (num != 0)
				{
				}
				num = (short)286982144;
				if (num != 0)
				{
				}
				num = (short)1796210688;
				short num3 = num;
				this.cntrlHeadO3HHCHButtonKey_A22522.Value = value;
			}
		}

		// Token: 0x17004660 RID: 18016
		// (get) Token: 0x06008AC5 RID: 35525 RVA: 0x0081C5D4 File Offset: 0x0081A7D4
		public global::AcpBusinessLayer.AcpKeyField CntrlHeadO3HHCHButtonKey_A22522
		{
			get
			{
				short num = (short)194576385;
				if (num != 0)
				{
				}
				num = (short)648413084;
				short num2 = num;
				num = (short)2013659036;
				switch (num2 == num)
				{
				}
				num = (short)931528704;
				if (num != 0)
				{
				}
				num = (short)1407123456;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonKey_A22522;
			}
		}

		// Token: 0x17004661 RID: 18017
		// (get) Token: 0x06008AC6 RID: 35526 RVA: 0x0081C684 File Offset: 0x0081A884
		// (set) Token: 0x06008AC7 RID: 35527 RVA: 0x0081C738 File Offset: 0x0081A938
		public bool CntrlHeadO3HHCHButtonKey_A22522_Applicable
		{
			get
			{
				short num = (short)1681910542;
				short num2 = num;
				num = (short)1794960142;
				switch (num2 == num)
				{
				}
				num = (short)1922957313;
				if (num != 0)
				{
				}
				num = (short)169803776;
				if (num != 0)
				{
				}
				num = (short)1962409984;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonKey_A22522.Applicable;
			}
			set
			{
				short num = (short)396675407;
				short num2 = num;
				num = (short)259574095;
				switch (num2 == num)
				{
				}
				num = (short)1615396865;
				if (num != 0)
				{
				}
				num = (short)2085748736;
				if (num != 0)
				{
				}
				num = (short)1670971392;
				short num3 = num;
				this.cntrlHeadO3HHCHButtonKey_A22522.Applicable = value;
			}
		}

		// Token: 0x17004662 RID: 18018
		// (get) Token: 0x06008AC8 RID: 35528 RVA: 0x0081C7EC File Offset: 0x0081A9EC
		// (set) Token: 0x06008AC9 RID: 35529 RVA: 0x0081C8A0 File Offset: 0x0081AAA0
		public bool CntrlHeadO3HHCHButtonKey_A22522_Valid
		{
			get
			{
				short num = (short)909157492;
				short num2 = num;
				num = (short)1649910900;
				switch (num2 == num)
				{
				}
				num = (short)532283392;
				if (num != 0)
				{
				}
				num = (short)1589968897;
				if (num != 0)
				{
				}
				num = (short)1729363968;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonKey_A22522.Valid;
			}
			set
			{
				short num = (short)1550881246;
				short num2 = num;
				num = (short)732336606;
				switch (num2 == num)
				{
				}
				num = (short)1952448512;
				if (num != 0)
				{
				}
				num = (short)110952449;
				if (num != 0)
				{
				}
				num = (short)818282496;
				short num3 = num;
				this.cntrlHeadO3HHCHButtonKey_A22522.Valid = value;
			}
		}

		// Token: 0x17004663 RID: 18019
		// (get) Token: 0x06008ACA RID: 35530 RVA: 0x0081C954 File Offset: 0x0081AB54
		// (set) Token: 0x06008ACB RID: 35531 RVA: 0x0081CA08 File Offset: 0x0081AC08
		public bool CntrlHeadO3HHCHButtonKey_A22522_Visible
		{
			get
			{
				short num = (short)1346961409;
				if (num != 0)
				{
				}
				num = (short)582595639;
				short num2 = num;
				num = (short)1987097655;
				switch (num2 == num)
				{
				}
				num = (short)1673068544;
				if (num != 0)
				{
				}
				num = (short)697237504;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonKey_A22522.Visible;
			}
			set
			{
				short num = (short)1850895201;
				short num2 = num;
				num = (short)268659553;
				switch (num2 == num)
				{
				}
				num = (short)1319960576;
				if (num != 0)
				{
				}
				num = (short)2059468801;
				if (num != 0)
				{
				}
				num = (short)643170304;
				short num3 = num;
				this.cntrlHeadO3HHCHButtonKey_A22522.Visible = value;
			}
		}

		// Token: 0x17004664 RID: 18020
		// (get) Token: 0x06008ACC RID: 35532 RVA: 0x0081CABC File Offset: 0x0081ACBC
		// (set) Token: 0x06008ACD RID: 35533 RVA: 0x0081CB6C File Offset: 0x0081AD6C
		public bool CntrlHeadO3HHCHButtonKey_A22522_Editable
		{
			get
			{
				short num = (short)399968596;
				short num2 = num;
				num = (short)1695091028;
				switch (num2 == num)
				{
				}
				num = (short)1956184065;
				if (num != 0)
				{
				}
				num = (short)122421248;
				if (num != 0)
				{
				}
				num = (short)403636224;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonKey_A22522.Editable;
			}
			set
			{
				short num = (short)514997375;
				short num2 = num;
				num = (short)935672959;
				switch (num2 == num)
				{
				}
				num = (short)1988820992;
				if (num != 0)
				{
				}
				num = (short)123273217;
				if (num != 0)
				{
				}
				num = (short)1524891648;
				short num3 = num;
				this.cntrlHeadO3HHCHButtonKey_A22522.Editable = value;
			}
		}

		// Token: 0x17004665 RID: 18021
		// (get) Token: 0x06008ACE RID: 35534 RVA: 0x0081CC20 File Offset: 0x0081AE20
		internal string CntrlHeadO3HHCHButtonKey_A22522_UILabel
		{
			get
			{
				short num = (short)646005651;
				short num2 = num;
				num = (short)356729747;
				switch (num2 == num)
				{
				}
				num = (short)168886272;
				if (num != 0)
				{
				}
				num = (short)1750269953;
				if (num != 0)
				{
				}
				num = (short)7012352;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonKey_A22522.UIName;
			}
		}

		// Token: 0x17004666 RID: 18022
		// (get) Token: 0x06008ACF RID: 35535 RVA: 0x0081CCD4 File Offset: 0x0081AED4
		// (set) Token: 0x06008AD0 RID: 35536 RVA: 0x0081CD88 File Offset: 0x0081AF88
		internal bool CntrlHeadO3HHCHButtonKey_A22522_HiddenStatic
		{
			get
			{
				short num = (short)234163530;
				short num2 = num;
				num = (short)377032010;
				switch (num2 == num)
				{
				}
				num = (short)1716781056;
				if (num != 0)
				{
				}
				num = (short)1969487873;
				if (num != 0)
				{
				}
				num = (short)1695416320;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonKey_A22522.HiddenStatic;
			}
			set
			{
				short num = (short)1468214658;
				short num2 = num;
				num = (short)1609313666;
				switch (num2 == num)
				{
				}
				num = (short)437256193;
				if (num != 0)
				{
				}
				num = (short)1505755136;
				if (num != 0)
				{
				}
				num = (short)850001920;
				short num3 = num;
				this.cntrlHeadO3HHCHButtonKey_A22522.HiddenStatic = value;
			}
		}

		// Token: 0x17004667 RID: 18023
		// (get) Token: 0x06008AD1 RID: 35537 RVA: 0x0081CE40 File Offset: 0x0081B040
		// (set) Token: 0x06008AD2 RID: 35538 RVA: 0x0081CEF4 File Offset: 0x0081B0F4
		internal bool CntrlHeadO3HHCHButtonKey_A22522_HiddenDynamic
		{
			get
			{
				short num = (short)319921151;
				short num2 = num;
				num = (short)789617663;
				switch (num2 == num)
				{
				}
				num = (short)54263809;
				if (num != 0)
				{
				}
				num = (short)2125398016;
				if (num != 0)
				{
				}
				num = (short)1563885568;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonKey_A22522.HiddenDynamic;
			}
			set
			{
				short num = (short)181731329;
				if (num != 0)
				{
				}
				num = (short)2129633293;
				short num2 = num;
				num = (short)1659674637;
				switch (num2 == num)
				{
				}
				num = (short)871825408;
				if (num != 0)
				{
				}
				num = (short)1804861440;
				short num3 = num;
				this.cntrlHeadO3HHCHButtonKey_A22522.HiddenDynamic = value;
			}
		}

		// Token: 0x17004668 RID: 18024
		// (get) Token: 0x06008AD3 RID: 35539 RVA: 0x0081CFAC File Offset: 0x0081B1AC
		public bool CntrlHeadO3HHCHButtonKey_A22522_HasDiffs
		{
			get
			{
				short num = (short)772708049;
				short num2 = num;
				num = (short)1180473041;
				switch (num2 == num)
				{
				}
				num = (short)582221824;
				if (num != 0)
				{
				}
				num = (short)213254145;
				if (num != 0)
				{
				}
				num = (short)1302659072;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonKey_A22522._HasDiffs;
			}
		}

		// Token: 0x17004669 RID: 18025
		// (get) Token: 0x06008AD4 RID: 35540 RVA: 0x0081D064 File Offset: 0x0081B264
		// (set) Token: 0x06008AD5 RID: 35541 RVA: 0x0081D118 File Offset: 0x0081B318
		public string CntrlHeadO3HHCHButtonName_A22523Value
		{
			get
			{
				short num = (short)671201173;
				short num2 = num;
				num = (short)1404811157;
				switch (num2 == num)
				{
				}
				num = (short)1606221824;
				if (num != 0)
				{
				}
				num = (short)1884291073;
				if (num != 0)
				{
				}
				num = (short)2076311552;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonName_A22523.Value;
			}
			set
			{
				short num = (short)957653885;
				short num2 = num;
				num = (short)358392701;
				switch (num2 == num)
				{
				}
				num = (short)995885057;
				if (num != 0)
				{
				}
				num = (short)1153236992;
				if (num != 0)
				{
				}
				num = (short)1967652864;
				short num3 = num;
				this.cntrlHeadO3HHCHButtonName_A22523.Value = value;
			}
		}

		// Token: 0x1700466A RID: 18026
		// (get) Token: 0x06008AD6 RID: 35542 RVA: 0x0081D1D0 File Offset: 0x0081B3D0
		public global::AcpBusinessLayer.AcpField<string> CntrlHeadO3HHCHButtonName_A22523
		{
			get
			{
				short num = (short)1696194248;
				short num2 = num;
				num = (short)1852628680;
				switch (num2 == num)
				{
				}
				num = (short)1520107521;
				if (num != 0)
				{
				}
				num = (short)1142620160;
				if (num != 0)
				{
				}
				num = (short)443285504;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonName_A22523;
			}
		}

		// Token: 0x1700466B RID: 18027
		// (get) Token: 0x06008AD7 RID: 35543 RVA: 0x0081D280 File Offset: 0x0081B480
		// (set) Token: 0x06008AD8 RID: 35544 RVA: 0x0081D334 File Offset: 0x0081B534
		public string CntrlHeadO3HHCHButtonName_A22523_UIValue
		{
			get
			{
				short num = (short)930964843;
				short num2 = num;
				num = (short)1785619819;
				switch (num2 == num)
				{
				}
				num = (short)1448935424;
				if (num != 0)
				{
				}
				num = (short)936312833;
				if (num != 0)
				{
				}
				num = (short)1927741440;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonName_A22523.Value;
			}
			set
			{
				short num = (short)1620288965;
				short num2 = num;
				num = (short)1585358277;
				switch (num2 == num)
				{
				}
				num = (short)1779105793;
				if (num != 0)
				{
				}
				num = (short)1584594944;
				if (num != 0)
				{
				}
				num = (short)1100414976;
				short num3 = num;
				this.cntrlHeadO3HHCHButtonName_A22523.Value = value;
			}
		}

		// Token: 0x1700466C RID: 18028
		// (get) Token: 0x06008AD9 RID: 35545 RVA: 0x0081D3EC File Offset: 0x0081B5EC
		// (set) Token: 0x06008ADA RID: 35546 RVA: 0x0081D4A0 File Offset: 0x0081B6A0
		public bool CntrlHeadO3HHCHButtonName_A22523_Applicable
		{
			get
			{
				short num = (short)277250647;
				short num2 = num;
				num = (short)1472561751;
				switch (num2 == num)
				{
				}
				num = (short)1630011393;
				if (num != 0)
				{
				}
				num = (short)2026897408;
				if (num != 0)
				{
				}
				num = (short)1305214976;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonName_A22523.Applicable;
			}
			set
			{
				short num = (short)2000167794;
				short num2 = num;
				num = (short)988226418;
				switch (num2 == num)
				{
				}
				num = (short)1849753601;
				if (num != 0)
				{
				}
				num = (short)1607401472;
				if (num != 0)
				{
				}
				num = (short)1571422208;
				short num3 = num;
				this.cntrlHeadO3HHCHButtonName_A22523.Applicable = value;
			}
		}

		// Token: 0x1700466D RID: 18029
		// (get) Token: 0x06008ADB RID: 35547 RVA: 0x0081D554 File Offset: 0x0081B754
		// (set) Token: 0x06008ADC RID: 35548 RVA: 0x0081D60C File Offset: 0x0081B80C
		public bool CntrlHeadO3HHCHButtonName_A22523_Valid
		{
			get
			{
				short num = (short)1128307366;
				short num2 = num;
				num = (short)2118884006;
				switch (num2 == num)
				{
				}
				num = (short)2072838144;
				if (num != 0)
				{
				}
				num = (short)2139357185;
				if (num != 0)
				{
				}
				num = (short)17956864;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonName_A22523.Valid;
			}
			set
			{
				short num = (short)1569899002;
				short num2 = num;
				num = (short)1686225402;
				switch (num2 == num)
				{
				}
				num = (short)1157955585;
				if (num != 0)
				{
				}
				num = (short)710737920;
				if (num != 0)
				{
				}
				num = (short)1425735680;
				short num3 = num;
				this.cntrlHeadO3HHCHButtonName_A22523.Valid = value;
			}
		}

		// Token: 0x1700466E RID: 18030
		// (get) Token: 0x06008ADD RID: 35549 RVA: 0x0081D6C0 File Offset: 0x0081B8C0
		// (set) Token: 0x06008ADE RID: 35550 RVA: 0x0081D774 File Offset: 0x0081B974
		public bool CntrlHeadO3HHCHButtonName_A22523_Visible
		{
			get
			{
				short num = (short)656670721;
				if (num != 0)
				{
				}
				num = (short)21623276;
				short num2 = num;
				num = (short)1961816556;
				switch (num2 == num)
				{
				}
				num = (short)312868864;
				if (num != 0)
				{
				}
				num = (short)1801125888;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonName_A22523.Visible;
			}
			set
			{
				short num = (short)516489217;
				if (num != 0)
				{
				}
				num = (short)1895328213;
				short num2 = num;
				num = (short)599288277;
				switch (num2 == num)
				{
				}
				num = (short)477757440;
				if (num != 0)
				{
				}
				num = (short)1478033408;
				short num3 = num;
				this.cntrlHeadO3HHCHButtonName_A22523.Visible = value;
			}
		}

		// Token: 0x1700466F RID: 18031
		// (get) Token: 0x06008ADF RID: 35551 RVA: 0x0081D828 File Offset: 0x0081BA28
		// (set) Token: 0x06008AE0 RID: 35552 RVA: 0x0081D8DC File Offset: 0x0081BADC
		public bool CntrlHeadO3HHCHButtonName_A22523_Editable
		{
			get
			{
				short num = (short)692261919;
				short num2 = num;
				num = (short)1204229151;
				switch (num2 == num)
				{
				}
				num = (short)78053377;
				if (num != 0)
				{
				}
				num = (short)132448256;
				if (num != 0)
				{
				}
				num = (short)1235353600;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonName_A22523.Editable;
			}
			set
			{
				short num = (short)1038730926;
				short num2 = num;
				num = (short)697812654;
				switch (num2 == num)
				{
				}
				num = (short)597491713;
				if (num != 0)
				{
				}
				num = (short)1208483840;
				if (num != 0)
				{
				}
				num = (short)997064704;
				short num3 = num;
				this.cntrlHeadO3HHCHButtonName_A22523.Editable = value;
			}
		}

		// Token: 0x17004670 RID: 18032
		// (get) Token: 0x06008AE1 RID: 35553 RVA: 0x0081D994 File Offset: 0x0081BB94
		internal string CntrlHeadO3HHCHButtonName_A22523_UILabel
		{
			get
			{
				short num = (short)394661473;
				short num2 = num;
				num = (short)586092129;
				switch (num2 == num)
				{
				}
				num = (short)977993728;
				if (num != 0)
				{
				}
				num = (short)2140274689;
				if (num != 0)
				{
				}
				num = (short)587137024;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonName_A22523.UIName;
			}
		}

		// Token: 0x17004671 RID: 18033
		// (get) Token: 0x06008AE2 RID: 35554 RVA: 0x0081DA4C File Offset: 0x0081BC4C
		// (set) Token: 0x06008AE3 RID: 35555 RVA: 0x0081DB00 File Offset: 0x0081BD00
		internal bool CntrlHeadO3HHCHButtonName_A22523_HiddenStatic
		{
			get
			{
				short num = (short)1924689621;
				short num2 = num;
				num = (short)1692430037;
				switch (num2 == num)
				{
				}
				num = (short)111214592;
				if (num != 0)
				{
				}
				num = (short)1376780289;
				if (num != 0)
				{
				}
				num = (short)1913520128;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonName_A22523.HiddenStatic;
			}
			set
			{
				short num = (short)1496645633;
				if (num != 0)
				{
				}
				num = (short)1500491516;
				short num2 = num;
				num = (short)190689020;
				switch (num2 == num)
				{
				}
				num = (short)1219821568;
				if (num != 0)
				{
				}
				num = (short)501022720;
				short num3 = num;
				this.cntrlHeadO3HHCHButtonName_A22523.HiddenStatic = value;
			}
		}

		// Token: 0x17004672 RID: 18034
		// (get) Token: 0x06008AE4 RID: 35556 RVA: 0x0081DBB8 File Offset: 0x0081BDB8
		// (set) Token: 0x06008AE5 RID: 35557 RVA: 0x0081DC68 File Offset: 0x0081BE68
		internal bool CntrlHeadO3HHCHButtonName_A22523_HiddenDynamic
		{
			get
			{
				short num = (short)1044255449;
				short num2 = num;
				num = (short)1255412441;
				switch (num2 == num)
				{
				}
				num = (short)502923265;
				if (num != 0)
				{
				}
				num = (short)1731919872;
				if (num != 0)
				{
				}
				num = (short)767557632;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonName_A22523.HiddenDynamic;
			}
			set
			{
				short num = (short)1329984444;
				short num2 = num;
				num = (short)102888380;
				switch (num2 == num)
				{
				}
				num = (short)1724514305;
				if (num != 0)
				{
				}
				num = (short)1094975488;
				if (num != 0)
				{
				}
				num = (short)729677824;
				short num3 = num;
				this.cntrlHeadO3HHCHButtonName_A22523.HiddenDynamic = value;
			}
		}

		// Token: 0x17004673 RID: 18035
		// (get) Token: 0x06008AE6 RID: 35558 RVA: 0x0081DD1C File Offset: 0x0081BF1C
		public bool CntrlHeadO3HHCHButtonName_A22523_HasDiffs
		{
			get
			{
				short num = (short)2016946764;
				short num2 = num;
				num = (short)486419020;
				switch (num2 == num)
				{
				}
				num = (short)1328807936;
				if (num != 0)
				{
				}
				num = (short)1721565185;
				if (num != 0)
				{
				}
				num = (short)1470365696;
				short num3 = num;
				return this.cntrlHeadO3HHCHButtonName_A22523._HasDiffs;
			}
		}

		// Token: 0x17004674 RID: 18036
		// (get) Token: 0x06008AE7 RID: 35559 RVA: 0x0081DDD0 File Offset: 0x0081BFD0
		// (set) Token: 0x06008AE8 RID: 35560 RVA: 0x0081DE84 File Offset: 0x0081C084
		public int RadErgCtrlHeadO3DataButtonShortKeyPressTimeValue
		{
			get
			{
				short num = (short)1450013166;
				short num2 = num;
				num = (short)1690464750;
				switch (num2 == num)
				{
				}
				num = (short)2056388608;
				if (num != 0)
				{
				}
				num = (short)790953985;
				if (num != 0)
				{
				}
				num = (short)1269825536;
				short num3 = num;
				return this.radErgCtrlHeadO3GeneralShortKeyPressTime.Value;
			}
			set
			{
				short num = (short)1242670708;
				short num2 = num;
				num = (short)1796187764;
				switch (num2 == num)
				{
				}
				num = (short)1898577921;
				if (num != 0)
				{
				}
				num = (short)1944584192;
				if (num != 0)
				{
				}
				num = (short)1957560320;
				short num3 = num;
				this.radErgCtrlHeadO3GeneralShortKeyPressTime.Value = value;
			}
		}

		// Token: 0x17004675 RID: 18037
		// (get) Token: 0x06008AE9 RID: 35561 RVA: 0x0081DF3C File Offset: 0x0081C13C
		// (set) Token: 0x06008AEA RID: 35562 RVA: 0x0081DFF4 File Offset: 0x0081C1F4
		public string RadErgCtrlHeadO3DataButtonShortKeyPressTime_UIValue
		{
			get
			{
				short num = (short)213376053;
				short num2 = num;
				num = (short)1501617205;
				switch (num2 == num)
				{
				}
				num = (short)1360855041;
				if (num != 0)
				{
				}
				num = (short)1703804928;
				if (num != 0)
				{
				}
				num = (short)619905024;
				short num3 = num;
				return this.radErgCtrlHeadO3GeneralShortKeyPressTime.UIValue;
			}
			set
			{
				short num = (short)426737395;
				short num2 = num;
				num = (short)311066355;
				switch (num2 == num)
				{
				}
				num = (short)1780219904;
				if (num != 0)
				{
				}
				num = (short)1782710273;
				if (num != 0)
				{
				}
				num = (short)545849344;
				short num3 = num;
				this.radErgCtrlHeadO3GeneralShortKeyPressTime.UIValue = value;
			}
		}

		// Token: 0x17004676 RID: 18038
		// (get) Token: 0x06008AEB RID: 35563 RVA: 0x0081E0A8 File Offset: 0x0081C2A8
		public global::AcpBusinessLayer.AcpCustomRangeField RadErgCtrlHeadO3GeneralShortKeyPressTime
		{
			get
			{
				short num = (short)1106631616;
				short num2 = num;
				num = (short)2078268352;
				switch (num2 == num)
				{
				}
				num = (short)958988289;
				if (num != 0)
				{
				}
				num = (short)1744502784;
				if (num != 0)
				{
				}
				num = (short)187695104;
				short num3 = num;
				return this.radErgCtrlHeadO3GeneralShortKeyPressTime;
			}
		}

		// Token: 0x17004677 RID: 18039
		// (get) Token: 0x06008AEC RID: 35564 RVA: 0x0081E158 File Offset: 0x0081C358
		// (set) Token: 0x06008AED RID: 35565 RVA: 0x0081E20C File Offset: 0x0081C40C
		public bool RadErgCtrlHeadO3DataButtonShortKeyPressTime_Applicable
		{
			get
			{
				short num = (short)1236770874;
				short num2 = num;
				num = (short)1771675706;
				switch (num2 == num)
				{
				}
				num = (short)259719169;
				if (num != 0)
				{
				}
				num = (short)632160256;
				if (num != 0)
				{
				}
				num = (short)1159921664;
				short num3 = num;
				return this.radErgCtrlHeadO3GeneralShortKeyPressTime.Applicable;
			}
			set
			{
				short num = (short)1837760513;
				if (num != 0)
				{
				}
				num = (short)1139291362;
				short num2 = num;
				num = (short)829502690;
				switch (num2 == num)
				{
				}
				num = (short)174718976;
				if (num != 0)
				{
				}
				num = (short)390397952;
				short num3 = num;
				this.radErgCtrlHeadO3GeneralShortKeyPressTime.Applicable = value;
			}
		}

		// Token: 0x17004678 RID: 18040
		// (get) Token: 0x06008AEE RID: 35566 RVA: 0x0081E2C0 File Offset: 0x0081C4C0
		// (set) Token: 0x06008AEF RID: 35567 RVA: 0x0081E374 File Offset: 0x0081C574
		public bool RadErgCtrlHeadO3DataButtonShortKeyPressTime_Valid
		{
			get
			{
				short num = (short)995132885;
				short num2 = num;
				num = (short)689472981;
				switch (num2 == num)
				{
				}
				num = (short)1171718144;
				if (num != 0)
				{
				}
				num = (short)1914568705;
				if (num != 0)
				{
				}
				num = (short)781975552;
				short num3 = num;
				return this.radErgCtrlHeadO3GeneralShortKeyPressTime.Valid;
			}
			set
			{
				short num = (short)864152723;
				short num2 = num;
				num = (short)1350364307;
				switch (num2 == num)
				{
				}
				num = (short)745144321;
				if (num != 0)
				{
				}
				num = (short)84017152;
				if (num != 0)
				{
				}
				num = (short)1248460800;
				short num3 = num;
				this.radErgCtrlHeadO3GeneralShortKeyPressTime.Valid = value;
			}
		}

		// Token: 0x17004679 RID: 18041
		// (get) Token: 0x06008AF0 RID: 35568 RVA: 0x0081E42C File Offset: 0x0081C62C
		// (set) Token: 0x06008AF1 RID: 35569 RVA: 0x0081E4E4 File Offset: 0x0081C6E4
		public bool RadErgCtrlHeadO3DataButtonShortKeyPressTime_Visible
		{
			get
			{
				short num = (short)1097666264;
				short num2 = num;
				num = (short)190779096;
				switch (num2 == num)
				{
				}
				num = (short)841940993;
				if (num != 0)
				{
				}
				num = (short)1996816384;
				if (num != 0)
				{
				}
				num = (short)1116536832;
				short num3 = num;
				return this.radErgCtrlHeadO3GeneralShortKeyPressTime.Visible;
			}
			set
			{
				short num = (short)157585572;
				short num2 = num;
				num = (short)203460772;
				switch (num2 == num)
				{
				}
				num = (short)920453121;
				if (num != 0)
				{
				}
				num = (short)2020343808;
				if (num != 0)
				{
				}
				num = (short)1657798656;
				short num3 = num;
				this.radErgCtrlHeadO3GeneralShortKeyPressTime.Visible = value;
			}
		}

		// Token: 0x1700467A RID: 18042
		// (get) Token: 0x06008AF2 RID: 35570 RVA: 0x0081E59C File Offset: 0x0081C79C
		// (set) Token: 0x06008AF3 RID: 35571 RVA: 0x0081E654 File Offset: 0x0081C854
		public bool RadErgCtrlHeadO3DataButtonShortKeyPressTime_Editable
		{
			get
			{
				short num = (short)1041862612;
				short num2 = num;
				num = (short)1905889236;
				switch (num2 == num)
				{
				}
				num = (short)1271136256;
				if (num != 0)
				{
				}
				num = (short)1523253249;
				if (num != 0)
				{
				}
				num = (short)1550450688;
				short num3 = num;
				return this.radErgCtrlHeadO3GeneralShortKeyPressTime.Editable;
			}
			set
			{
				short num = (short)1102733270;
				short num2 = num;
				num = (short)1961648086;
				switch (num2 == num)
				{
				}
				num = (short)1032978433;
				if (num != 0)
				{
				}
				num = (short)666763264;
				if (num != 0)
				{
				}
				num = (short)497418240;
				short num3 = num;
				this.radErgCtrlHeadO3GeneralShortKeyPressTime.Editable = value;
			}
		}

		// Token: 0x1700467B RID: 18043
		// (get) Token: 0x06008AF4 RID: 35572 RVA: 0x0081E708 File Offset: 0x0081C908
		internal string RadErgCtrlHeadO3DataButtonShortKeyPressTime_UILabel
		{
			get
			{
				short num = (short)1777139713;
				if (num != 0)
				{
				}
				num = (short)1437562708;
				short num2 = num;
				num = (short)1374386004;
				switch (num2 == num)
				{
				}
				num = (short)1723334656;
				if (num != 0)
				{
				}
				num = (short)1962344448;
				short num3 = num;
				return this.radErgCtrlHeadO3GeneralShortKeyPressTime.UIName;
			}
		}

		// Token: 0x1700467C RID: 18044
		// (get) Token: 0x06008AF5 RID: 35573 RVA: 0x0081E7BC File Offset: 0x0081C9BC
		// (set) Token: 0x06008AF6 RID: 35574 RVA: 0x0081E874 File Offset: 0x0081CA74
		internal bool RadErgCtrlHeadO3DataButtonShortKeyPressTime_HiddenStatic
		{
			get
			{
				short num = (short)1117917922;
				short num2 = num;
				num = (short)717165282;
				switch (num2 == num)
				{
				}
				num = (short)730464257;
				if (num != 0)
				{
				}
				num = (short)1186070528;
				if (num != 0)
				{
				}
				num = (short)753860608;
				short num3 = num;
				return this.radErgCtrlHeadO3GeneralShortKeyPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)830326654;
				short num2 = num;
				num = (short)699254654;
				switch (num2 == num)
				{
				}
				num = (short)1900609537;
				if (num != 0)
				{
				}
				num = (short)1174732800;
				if (num != 0)
				{
				}
				num = (short)1252917248;
				short num3 = num;
				this.radErgCtrlHeadO3GeneralShortKeyPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x1700467D RID: 18045
		// (get) Token: 0x06008AF7 RID: 35575 RVA: 0x0081E92C File Offset: 0x0081CB2C
		// (set) Token: 0x06008AF8 RID: 35576 RVA: 0x0081E9E0 File Offset: 0x0081CBE0
		internal bool RadErgCtrlHeadO3DataButtonShortKeyPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)988661893;
				short num2 = num;
				num = (short)520669317;
				switch (num2 == num)
				{
				}
				num = (short)1965096960;
				if (num != 0)
				{
				}
				num = (short)735838209;
				if (num != 0)
				{
				}
				num = (short)480444416;
				short num3 = num;
				return this.radErgCtrlHeadO3GeneralShortKeyPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)775121485;
				short num2 = num;
				num = (short)1621518925;
				switch (num2 == num)
				{
				}
				num = (short)2059796480;
				if (num != 0)
				{
				}
				num = (short)1520762881;
				if (num != 0)
				{
				}
				num = (short)311885824;
				short num3 = num;
				this.radErgCtrlHeadO3GeneralShortKeyPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x1700467E RID: 18046
		// (get) Token: 0x06008AF9 RID: 35577 RVA: 0x0081EA94 File Offset: 0x0081CC94
		public bool RadErgCtrlHeadO3DataButtonShortKeyPressTime_HasDiffs
		{
			get
			{
				short num = (short)1657995265;
				if (num != 0)
				{
				}
				num = (short)1211741915;
				short num2 = num;
				num = (short)290961115;
				switch (num2 == num)
				{
				}
				num = (short)446431232;
				if (num != 0)
				{
				}
				num = (short)381681664;
				short num3 = num;
				return this.radErgCtrlHeadO3GeneralShortKeyPressTime._HasDiffs;
			}
		}

		// Token: 0x1700467F RID: 18047
		// (get) Token: 0x06008AFA RID: 35578 RVA: 0x0081EB4C File Offset: 0x0081CD4C
		// (set) Token: 0x06008AFB RID: 35579 RVA: 0x0081EC00 File Offset: 0x0081CE00
		public int RadErgCtrlHeadO3DataButtonLongKeyPressTimeValue
		{
			get
			{
				short num = (short)536936449;
				if (num != 0)
				{
				}
				num = (short)1276350492;
				short num2 = num;
				num = (short)1482854428;
				switch (num2 == num)
				{
				}
				num = (short)1032192000;
				if (num != 0)
				{
				}
				num = (short)351272960;
				short num3 = num;
				return this.radErgCtrlHeadO3GeneralLongKeyPressTime.Value;
			}
			set
			{
				short num = (short)266269619;
				short num2 = num;
				num = (short)44889011;
				switch (num2 == num)
				{
				}
				num = (short)1164574721;
				if (num != 0)
				{
				}
				num = (short)1253703680;
				if (num != 0)
				{
				}
				num = (short)865861632;
				short num3 = num;
				this.radErgCtrlHeadO3GeneralLongKeyPressTime.Value = value;
			}
		}

		// Token: 0x17004680 RID: 18048
		// (get) Token: 0x06008AFC RID: 35580 RVA: 0x0081ECB8 File Offset: 0x0081CEB8
		// (set) Token: 0x06008AFD RID: 35581 RVA: 0x0081ED70 File Offset: 0x0081CF70
		public string RadErgCtrlHeadO3DataButtonLongKeyPressTime_UIValue
		{
			get
			{
				short num = (short)1441717289;
				short num2 = num;
				num = (short)416734249;
				switch (num2 == num)
				{
				}
				num = (short)180092929;
				if (num != 0)
				{
				}
				num = (short)1869283328;
				if (num != 0)
				{
				}
				num = (short)414515200;
				short num3 = num;
				return this.radErgCtrlHeadO3GeneralLongKeyPressTime.UIValue;
			}
			set
			{
				short num = (short)43405415;
				short num2 = num;
				num = (short)930304103;
				switch (num2 == num)
				{
				}
				num = (short)641204224;
				short num3 = num;
				num = (short)2099511297;
				if (num != 0)
				{
				}
				num = (short)2015756288;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO3GeneralLongKeyPressTime.UIValue = value;
			}
		}

		// Token: 0x17004681 RID: 18049
		// (get) Token: 0x06008AFE RID: 35582 RVA: 0x0081EE24 File Offset: 0x0081D024
		public global::AcpBusinessLayer.AcpCustomRangeField RadErgCtrlHeadO3GeneralLongKeyPressTime
		{
			get
			{
				short num = (short)880346965;
				short num2 = num;
				num = (short)141035349;
				switch (num2 == num)
				{
				}
				num = (short)1582694400;
				short num3 = num;
				num = (short)810352640;
				if (num != 0)
				{
				}
				num = (short)483721217;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO3GeneralLongKeyPressTime;
			}
		}

		// Token: 0x17004682 RID: 18050
		// (get) Token: 0x06008AFF RID: 35583 RVA: 0x0081EED4 File Offset: 0x0081D0D4
		// (set) Token: 0x06008B00 RID: 35584 RVA: 0x0081EF88 File Offset: 0x0081D188
		public bool RadErgCtrlHeadO3DataButtonLongKeyPressTime_Applicable
		{
			get
			{
				short num = (short)1856352904;
				short num2 = num;
				num = (short)1235333768;
				switch (num2 == num)
				{
				}
				num = (short)1340866560;
				short num3 = num;
				num = (short)1538654208;
				if (num != 0)
				{
				}
				num = (short)1712717825;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO3GeneralLongKeyPressTime.Applicable;
			}
			set
			{
				short num = (short)1896949768;
				short num2 = num;
				num = (short)1856448520;
				switch (num2 == num)
				{
				}
				num = (short)807534592;
				short num3 = num;
				num = (short)1459027968;
				if (num != 0)
				{
				}
				num = (short)1190395905;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO3GeneralLongKeyPressTime.Applicable = value;
			}
		}

		// Token: 0x17004683 RID: 18051
		// (get) Token: 0x06008B01 RID: 35585 RVA: 0x0081F040 File Offset: 0x0081D240
		// (set) Token: 0x06008B02 RID: 35586 RVA: 0x0081F0F4 File Offset: 0x0081D2F4
		public bool RadErgCtrlHeadO3DataButtonLongKeyPressTime_Valid
		{
			get
			{
				short num = (short)976199703;
				short num2 = num;
				num = (short)1104519191;
				switch (num2 == num)
				{
				}
				num = (short)284164096;
				short num3 = num;
				num = (short)1157496833;
				if (num != 0)
				{
				}
				num = (short)828768256;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO3GeneralLongKeyPressTime.Valid;
			}
			set
			{
				short num = (short)1432265906;
				short num2 = num;
				num = (short)2128061618;
				switch (num2 == num)
				{
				}
				num = (short)1830551552;
				short num3 = num;
				num = (short)597688321;
				if (num != 0)
				{
				}
				num = (short)1692729344;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO3GeneralLongKeyPressTime.Valid = value;
			}
		}

		// Token: 0x17004684 RID: 18052
		// (get) Token: 0x06008B03 RID: 35587 RVA: 0x0081F1AC File Offset: 0x0081D3AC
		// (set) Token: 0x06008B04 RID: 35588 RVA: 0x0081F260 File Offset: 0x0081D460
		public bool RadErgCtrlHeadO3DataButtonLongKeyPressTime_Visible
		{
			get
			{
				short num = (short)1085405939;
				short num2 = num;
				num = (short)765721331;
				switch (num2 == num)
				{
				}
				num = (short)343474176;
				short num3 = num;
				num = (short)1582891009;
				if (num != 0)
				{
				}
				num = (short)1731592192;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO3GeneralLongKeyPressTime.Visible;
			}
			set
			{
				short num = (short)1998769578;
				short num2 = num;
				num = (short)938593706;
				switch (num2 == num)
				{
				}
				num = (short)1360789504;
				short num3 = num;
				num = (short)536477696;
				if (num != 0)
				{
				}
				num = (short)834797569;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO3GeneralLongKeyPressTime.Visible = value;
			}
		}

		// Token: 0x17004685 RID: 18053
		// (get) Token: 0x06008B05 RID: 35589 RVA: 0x0081F314 File Offset: 0x0081D514
		// (set) Token: 0x06008B06 RID: 35590 RVA: 0x0081F3C8 File Offset: 0x0081D5C8
		public bool RadErgCtrlHeadO3DataButtonLongKeyPressTime_Editable
		{
			get
			{
				short num = (short)13341846;
				short num2 = num;
				num = (short)2059637910;
				switch (num2 == num)
				{
				}
				num = (short)1824260096;
				short num3 = num;
				num = (short)1766457345;
				if (num != 0)
				{
				}
				num = (short)1439170560;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO3GeneralLongKeyPressTime.Editable;
			}
			set
			{
				short num = (short)909703792;
				short num2 = num;
				num = (short)1169291888;
				switch (num2 == num)
				{
				}
				num = (short)1058471936;
				short num3 = num;
				num = (short)538640385;
				if (num != 0)
				{
				}
				num = (short)2037252096;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO3GeneralLongKeyPressTime.Editable = value;
			}
		}

		// Token: 0x17004686 RID: 18054
		// (get) Token: 0x06008B07 RID: 35591 RVA: 0x0081F480 File Offset: 0x0081D680
		internal string RadErgCtrlHeadO3DataButtonLongKeyPressTime_UILabel
		{
			get
			{
				short num = (short)1346189766;
				short num2 = num;
				num = (short)1767324102;
				switch (num2 == num)
				{
				}
				num = (short)1194524672;
				short num3 = num;
				num = (short)2110259201;
				if (num != 0)
				{
				}
				num = (short)1766522880;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO3GeneralLongKeyPressTime.UIName;
			}
		}

		// Token: 0x17004687 RID: 18055
		// (get) Token: 0x06008B08 RID: 35592 RVA: 0x0081F534 File Offset: 0x0081D734
		// (set) Token: 0x06008B09 RID: 35593 RVA: 0x0081F5E8 File Offset: 0x0081D7E8
		internal bool RadErgCtrlHeadO3DataButtonLongKeyPressTime_HiddenStatic
		{
			get
			{
				short num = (short)611348915;
				short num2 = num;
				num = (short)2025353651;
				switch (num2 == num)
				{
				}
				num = (short)606142464;
				short num3 = num;
				num = (short)656801793;
				if (num != 0)
				{
				}
				num = (short)192937984;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO3GeneralLongKeyPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)2136682014;
				short num2 = num;
				num = (short)1248013854;
				switch (num2 == num)
				{
				}
				num = (short)1075118080;
				short num3 = num;
				num = (short)211419137;
				if (num != 0)
				{
				}
				num = (short)832372736;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO3GeneralLongKeyPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17004688 RID: 18056
		// (get) Token: 0x06008B0A RID: 35594 RVA: 0x0081F6A0 File Offset: 0x0081D8A0
		// (set) Token: 0x06008B0B RID: 35595 RVA: 0x0081F754 File Offset: 0x0081D954
		internal bool RadErgCtrlHeadO3DataButtonLongKeyPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)866316380;
				short num2 = num;
				num = (short)1238626396;
				switch (num2 == num)
				{
				}
				num = (short)1094516736;
				short num3 = num;
				num = (short)564592641;
				if (num != 0)
				{
				}
				num = (short)1571160064;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO3GeneralLongKeyPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)243850079;
				short num2 = num;
				num = (short)1898175327;
				switch (num2 == num)
				{
				}
				num = (short)352714752;
				short num3 = num;
				num = (short)224722945;
				if (num != 0)
				{
				}
				num = (short)1873936384;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO3GeneralLongKeyPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17004689 RID: 18057
		// (get) Token: 0x06008B0C RID: 35596 RVA: 0x0081F808 File Offset: 0x0081DA08
		public bool RadErgCtrlHeadO3DataButtonLongKeyPressTime_HasDiffs
		{
			get
			{
				short num = (short)5645449;
				short num2 = num;
				num = (short)1974412425;
				switch (num2 == num)
				{
				}
				num = (short)601358336;
				short num3 = num;
				num = (short)1823473665;
				if (num != 0)
				{
				}
				num = (short)247726080;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO3GeneralLongKeyPressTime._HasDiffs;
			}
		}

		// Token: 0x1700468A RID: 18058
		// (get) Token: 0x06008B0D RID: 35597 RVA: 0x0081F8BC File Offset: 0x0081DABC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)266863368;
				short num2 = num;
				num = (short)129237768;
				switch (num2 == num)
				{
				}
				num = (short)421462016;
				short num3 = num;
				num = (short)1639448576;
				if (num != 0)
				{
				}
				num = (short)238747649;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x1700468B RID: 18059
		// (get) Token: 0x06008B0E RID: 35598 RVA: 0x0081F97C File Offset: 0x0081DB7C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)763675952;
				short num2 = num;
				num = (short)504677680;
				switch (num2 == num)
				{
				}
				num = (short)1980301312;
				short num3 = num;
				num = (short)114819073;
				if (num != 0)
				{
				}
				num = (short)335282176;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x06008B0F RID: 35599 RVA: 0x0081FA40 File Offset: 0x0081DC40
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					num2 = (short)2088566786;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1306460163;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
				{
					num2 = (short)1266024449;
					if (num2 != 0)
					{
					}
					num2 = (short)1947168994;
					short num3 = num2;
					num2 = (short)335180002;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)1031602176;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1649475584;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
				{
					num2 = (short)181993472;
					short num4 = num2;
					if (base.ParentRecset != null)
					{
						num2 = (short)2003959809;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1076101124;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040042D4 RID: 17108
		private global::AcpBusinessLayer.AcpListField cntrlHeadO3ConventionalO3HHCHButtonBCO_A19649;

		// Token: 0x040042D5 RID: 17109
		private global::AcpBusinessLayer.AcpListField cntrlHeadO3ConventionalO3HHCHButtonFeature_A19650;

		// Token: 0x040042D6 RID: 17110
		private global::AcpBusinessLayer.AcpListField cntrlHeadO3TrunkingO3HHCHButtonBCO_A19749;

		// Token: 0x040042D7 RID: 17111
		private global::AcpBusinessLayer.AcpListField cntrlHeadO3TrunkingO3HHCHButtonFeature_A19750;

		// Token: 0x040042D8 RID: 17112
		private global::AcpBusinessLayer.AcpKeyField cntrlHeadO3HHCHButtonKey_A22522;

		// Token: 0x040042D9 RID: 17113
		private global::AcpBusinessLayer.AcpField<string> cntrlHeadO3HHCHButtonName_A22523;

		// Token: 0x040042DA RID: 17114
		private global::AcpBusinessLayer.AcpCustomRangeField radErgCtrlHeadO3GeneralShortKeyPressTime;

		// Token: 0x040042DB RID: 17115
		private global::AcpBusinessLayer.AcpCustomRangeField radErgCtrlHeadO3GeneralLongKeyPressTime;
	}
}
