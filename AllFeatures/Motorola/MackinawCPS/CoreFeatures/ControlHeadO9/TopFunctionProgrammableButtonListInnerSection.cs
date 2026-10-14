using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000389 RID: 905
	[global::System.Serializable]
	public class TopFunctionProgrammableButtonListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060084FF RID: 34047 RVA: 0x007B625C File Offset: 0x007B445C
		public TopFunctionProgrammableButtonListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06008500 RID: 34048 RVA: 0x007B6278 File Offset: 0x007B4478
		protected TopFunctionProgrammableButtonListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008501 RID: 34049 RVA: 0x007B6290 File Offset: 0x007B4490
		public override void Init()
		{
			int a_ = 9;
			short num = (short)2036847153;
			short num2 = num;
			num = (short)1166725681;
			switch (num2 == num)
			{
			}
			num = (short)1158086656;
			if (num != 0)
			{
			}
			num = (short)1210253312;
			short num3 = num;
			num = (short)1803354113;
			if (num != 0)
			{
			}
			this.cHO9TopFunctionButton_A36618 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_BUTTON1, this, global::AllFeatures.CodeplugGuid.b("觉蓋臍蛑믓ꛕ黗꿙닛뷝铟诡诣裥ꫧ鿩飫髭鿯鳱꯳럵쯷쳹쫻쿽㣿", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.cHO9TopFunctionButton_A36618.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO9TopFunctionButton_A36618.DataTransferOrder = -1;
			this.cHO9CnvTopFunctionButtonLabelLine1_A36626 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("觉蓋臍金뫓ꃕ賗뗙곛飝闟賡蟣鋥臧藩苫곭藯蛱胳駵雷뛹鷻鳽旿渁䠃漅昇漉㴋儍儏ℑ∓―⨗Ⱉ", a_), global::CommonResources.AcgResources.ID_LABELLINE1, 6);
			this.cHO9CnvTopFunctionButtonLabelLine1_A36626.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO9CnvTopFunctionButtonLabelLine1_A36626.DataTransferOrder = 6;
			this.cHO9CnvTopFunctionButtonLabelLine2_A36627 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("觉蓋臍金뫓ꃕ賗뗙곛飝闟賡蟣鋥臧藩苫곭藯蛱胳駵雷뛹鷻鳽旿渁䠃漅昇漉㸋儍儏ℑ∓―⨗ⴙ", a_), global::CommonResources.AcgResources.ID_LABELLINE2, 6);
			this.cHO9CnvTopFunctionButtonLabelLine2_A36627.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO9CnvTopFunctionButtonLabelLine2_A36627.DataTransferOrder = 7;
			this.cnvTopFunctionButtonBCO_A36628 = new global::AcpBusinessLayer.AcpSparseLOVField(160, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexCnvTopFunctionButtonBCO_A36628LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idCnvTopFunctionButtonBCO_A36628LovStrs), this, global::AllFeatures.CodeplugGuid.b("觉ꋋ룍蓏뷑ꓓ郕귗듙뿛ꫝ觟跡諣ꓥ鷧黩飫臭黯냱럳맵ꟷ믹쿻죽㛿、㰃", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.CnvTopFunctionButtonBCO_A36628LovStrs);
			this.cnvTopFunctionButtonBCO_A36628.IgnoreOnCompare = true;
			this.cnvTopFunctionButtonBCO_A36628.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cnvTopFunctionButtonBCO_A36628.DataTransferOrder = -1;
			this.o9CHCnvTopFunctionButtonIndex_A36634 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("藉跍飏金뫓ꃕ賗뗙곛飝闟賡蟣鋥臧藩苫곭藯蛱胳駵雷돹鋻髽旿稁嬃䜅㬇㰉㨋㴍␏", a_), global::CommonResources.AcgResources.ID_INDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.o9CHCnvTopFunctionButtonIndex_A36634.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.o9CHCnvTopFunctionButtonIndex_A36634.DataTransferOrder = 9;
			this.o9CHCnvTopFunctionButtonIndex_A36634.ValidateAcrossRecset = true;
			this.o9CHTrkTopFunctionButtonBCO_A36636 = new global::AcpBusinessLayer.AcpSparseLOVField(160, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexO9CHTrkTopFunctionButtonBCO_A36636LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idO9CHTrkTopFunctionButtonBCO_A36636LovStrs), this, global::AllFeatures.CodeplugGuid.b("藉跍飏蛑ꛓ뷕賗뗙곛飝闟賡蟣鋥臧藩苫곭藯蛱胳駵雷룹뿻뇽忿䌁㜃々㸇㤉㨋", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.O9CHTrkTopFunctionButtonBCO_A36636LovStrs);
			this.o9CHTrkTopFunctionButtonBCO_A36636.IgnoreOnCompare = true;
			this.o9CHTrkTopFunctionButtonBCO_A36636.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.o9CHTrkTopFunctionButtonBCO_A36636.DataTransferOrder = -1;
			this.o9CHTrkTopFunctionButtonIndex_A36639 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("藉跍飏蛑ꛓ뷕賗뗙곛飝闟賡蟣鋥臧藩苫곭藯蛱胳駵雷돹鋻髽旿稁嬃䜅㬇㰉㨋㴍⤏", a_), global::CommonResources.AcgResources.ID_TRUNKINGINDEX, 0, 25, null, null, 0, 1);
			this.o9CHTrkTopFunctionButtonIndex_A36639.IgnoreOnCompare = true;
			this.o9CHTrkTopFunctionButtonIndex_A36639.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.o9CHTrkTopFunctionButtonIndex_A36639.DataTransferOrder = -1;
			this.o9CHTrkTopFunctionButtonIndex_A36639.ShowHexValue = false;
			this.cHO9TrkTopFunctionButtonLabelLine1_A36650 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("觉蓋臍蛑ꛓ뷕賗뗙곛飝闟賡蟣鋥臧藩苫곭藯蛱胳駵雷뛹鷻鳽旿渁䠃漅昇漉㴋儍儏ℑ∓―ⴗ⨙", a_), global::CommonResources.AcgResources.ID_TRUNKINGLABELLINE1, 14);
			this.cHO9TrkTopFunctionButtonLabelLine1_A36650.IgnoreOnCompare = true;
			this.cHO9TrkTopFunctionButtonLabelLine1_A36650.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cHO9TrkTopFunctionButtonLabelLine1_A36650.DataTransferOrder = -1;
			this.cHO9TrkTopFunctionButtonLabelLine2_A36651 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("觉蓋臍蛑ꛓ뷕賗뗙곛飝闟賡蟣鋥臧藩苫곭藯蛱胳駵雷뛹鷻鳽旿渁䠃漅昇漉㸋儍儏ℑ∓―ⴗ⬙", a_), global::CommonResources.AcgResources.ID_TRUNKINGLABELLINE2, 14);
			this.cHO9TrkTopFunctionButtonLabelLine2_A36651.IgnoreOnCompare = true;
			this.cHO9TrkTopFunctionButtonLabelLine2_A36651.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cHO9TrkTopFunctionButtonLabelLine2_A36651.DataTransferOrder = -1;
			this.topFunctionBtnCnvZone_A36942 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("黉ꏋ뻍雏ꟑ뫓뗕곗동돛냝ꋟ雡諣ꗥ蛧鳩뛫臭黯韱꯳럵쯷쳹엻쫽㋿", a_), global::CommonResources.AcgResources.ID_ZONE, null, null, false, false);
			this.topFunctionBtnCnvZone_A36942.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.topFunctionBtnCnvZone_A36942.DataTransferOrder = 11;
			this.topFunctionBtnCnvChannel_A36943 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("黉ꏋ뻍雏ꟑ뫓뗕곗동돛냝ꋟ雡諣ꗥ蛧鳩꿫蛭釯鳱髳鏵铷ꗹ뷻췽㛿㬁〃㔅", a_), global::CommonResources.AcgResources.ID_CHANNEL, null, null, false, false);
			this.topFunctionBtnCnvChannel_A36943.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.topFunctionBtnCnvChannel_A36943.DataTransferOrder = 12;
			this.topFunctionBtnTrkZone_A36944 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("黉ꏋ뻍雏ꟑ뫓뗕곗동돛냝ꋟ雡諣닥髧臩뛫臭黯韱꯳럵쯷쳹엻쫽㓿", a_), global::CommonResources.AcgResources.ID_TRUNKINGZONE, null, null, false, false);
			this.topFunctionBtnTrkZone_A36944.IgnoreOnCompare = true;
			this.topFunctionBtnTrkZone_A36944.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.topFunctionBtnTrkZone_A36944.DataTransferOrder = -1;
			this.topFunctionBtnTrkChannel_A36945 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("黉ꏋ뻍雏ꟑ뫓뗕곗동돛냝ꋟ雡諣닥髧臩꿫蛭釯鳱髳鏵铷ꗹ뷻췽㛿㬁〃㌅", a_), global::CommonResources.AcgResources.ID_TRUNKINGCHANNEL, null, null, false, false);
			this.topFunctionBtnTrkChannel_A36945.IgnoreOnCompare = true;
			this.topFunctionBtnTrkChannel_A36945.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.topFunctionBtnTrkChannel_A36945.DataTransferOrder = -1;
			this.o9CHCnvTopFunctionButtonFeature_A36629 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexO9CHCnvTopFunctionButtonFeature_A36629LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idO9CHCnvTopFunctionButtonFeature_A36629LovStrs), this, global::AllFeatures.CodeplugGuid.b("藉跍飏金뫓ꃕ賗뗙곛飝闟賡蟣鋥臧藩苫곭藯蛱胳駵雷볹駻鿽瓿省瘃挅圇䬉㼋㠍☏‑ⴓ", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.O9CHCnvTopFunctionButtonFeature_A36629LovStrs);
			this.o9CHCnvTopFunctionButtonFeature_A36629.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.o9CHCnvTopFunctionButtonFeature_A36629.DataTransferOrder = 8;
			this.o9CHTrkTopFunctionButtonFeature_A36637 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexO9CHTrkTopFunctionButtonFeature_A36637LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idO9CHTrkTopFunctionButtonFeature_A36637LovStrs), this, global::AllFeatures.CodeplugGuid.b("藉跍飏蛑ꛓ뷕賗뗙곛飝闟賡蟣鋥臧藩苫곭藯蛱胳駵雷볹駻鿽瓿省瘃挅圇䬉㼋㠍☏ℑ⌓", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.O9CHTrkTopFunctionButtonFeature_A36637LovStrs);
			this.o9CHTrkTopFunctionButtonFeature_A36637.IgnoreOnCompare = true;
			this.o9CHTrkTopFunctionButtonFeature_A36637.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.o9CHTrkTopFunctionButtonFeature_A36637.DataTransferOrder = -1;
			this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("藉跍飏金뫓ꃕ賗뗙곛飝闟賡蟣鋥臧藩苫곭藯蛱胳駵雷꧹裻跽䷿焁挃伅昇渉椋瘍伏匑✓―⼗∙ⴛ", a_), global::CommonResources.AcgResources.ID_STSMSGINDEX, 1, 16, null, null, 0, 1);
			this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.DataTransferOrder = 10;
			this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.ValidateAcrossRecset = true;
			this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.ShowHexValue = false;
			this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("藉跍飏蛑ꛓ뷕賗뗙곛飝闟賡蟣鋥臧藩苫곭藯蛱胳駵雷꧹裻跽䷿焁挃伅昇渉椋瘍伏匑✓―⼗∙⸛", a_), global::CommonResources.AcgResources.ID_TRUNKINGSTSMSGINDEX, 1, 16, null, null, 0, 1);
			this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.IgnoreOnCompare = true;
			this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.DataTransferOrder = -1;
			this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.ShowHexValue = false;
			this.o9CHTopFunctionProgrammableButtonShortKeyPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("藉跍飏蛑믓ꛕ黗꿙닛뷝铟诡诣裥룧飩菫觭苯鏱駳鯵駷飹郻鯽䋿省瀃爅朇搉弋昍缏怑怓崕紗挙䰛氝䔟儡圣爥䄧䜩䤫", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
			this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.DataTransferOrder = -1;
			((global::AcpBusinessLayer.AcpSimpleRangeField)this.o9CHTopFunctionProgrammableButtonShortKeyPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.ShowHexValue = false;
			this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.ValidateAcrossRecset = true;
			this.o9CHTopFunctionProgrammableButtonLongKeyPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("藉跍飏蛑믓ꛕ黗꿙닛뷝铟诡诣裥룧飩菫觭苯鏱駳鯵駷飹郻鯽䋿省瀃爅朇搉䀋愍縏甑弓猕愗䨙減笝匟儡瀣伥䔧伩", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
			this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.DataTransferOrder = -1;
			((global::AcpBusinessLayer.AcpSimpleRangeField)this.o9CHTopFunctionProgrammableButtonLongKeyPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.ShowHexValue = false;
			this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("黉ꏋ뻍铑ꇓ룕믗껙뗛뇝軟싡듣铥蟧跩黫迭鷯鿱闳铵铷鿹\udcfb볽痿瘁瀃椅昇", a_);
			base.Id = 10617;
			base.UIName = global::CommonResources.AcgResources.ID_TOPFUNCTIONPROGRAMMABLEBUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008502 RID: 34050 RVA: 0x007B6974 File Offset: 0x007B4B74
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 12;
			short num = (short)1046609972;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_F38;
				case 1:
					goto IL_E57;
				case 2:
					this.o9CHTopFunctionProgrammableButtonShortKeyPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("苌鋐鯒臔룖꧘鷚꣜뇞苠韢賤裦蟨믪鿬胮雰臲铴髶铸髺鿼鏾搀䄂瀄猆紈搊挌導礐簒朔挖刘縚搜伞匠䘢嘤否紨䈪䀬䨮", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
					this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.DataTransferOrder = -1;
					((global::AcpBusinessLayer.AcpSimpleRangeField)this.o9CHTopFunctionProgrammableButtonShortKeyPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.ShowHexValue = false;
					this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.ValidateAcrossRecset = true;
					num = (short)738525229;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)2054094890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌蟎黐雔맖꿘迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺뇼黾挀昂椄䬆怈攊栌㸎丐划☔№⼘⤚⬜", a_)))
					{
						num = (short)1357971470;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_979;
				case 5:
					this.topFunctionBtnCnvChannel_A36943 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("駌ꃎꇐ闒ꃔ맖뫘꿚드냞迠ꇢ釤触ꫨ藪鯬곮駰鋲鯴駶鳸韺ꋼ뻾㈀㔂㰄㌆㨈", a_), global::CommonResources.AcgResources.ID_CHANNEL, null, null, false, false);
					this.topFunctionBtnCnvChannel_A36943.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.topFunctionBtnCnvChannel_A36943.DataTransferOrder = 12;
					num = (short)1717043251;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苌鋐鯒雔맖꿘迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺껼课爀丂瘄怆䀈攊椌樎椐䰒吔␖⼘Ⱊ├⸞", a_)))
					{
						num = (short)1327628341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_72A;
				case 7:
					this.cHO9CnvTopFunctionButtonLabelLine2_A36627 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("軌蟎黐雔맖꿘迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺뇼黾挀昂椄䬆怈攊栌㴎丐划☔№⼘⤚⨜", a_), global::CommonResources.AcgResources.ID_LABELLINE2, 6);
					this.cHO9CnvTopFunctionButtonLabelLine2_A36627.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHO9CnvTopFunctionButtonLabelLine2_A36627.DataTransferOrder = 7;
					num = (short)1552744458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苌鋐鯒臔ꗖ님迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺민髾怀眂瀄甆氈吊䰌㰎✐┒☔‖", a_)))
					{
						num = (short)896991244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9C7;
				case 9:
				{
					num = (short)296484865;
					if (num != 0)
					{
					}
					num = (short)936651285;
					short num3 = num;
					num = (short)957164053;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5D3;
					default:
						num = (short)118882304;
						if (num != 0)
						{
						}
						this.cHO9TrkTopFunctionButtonLabelLine2_A36651 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("軌蟎黐臔ꗖ님迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺뇼黾挀昂椄䬆怈攊栌㴎丐划☔№⼘⸚Ⱌ", a_), global::CommonResources.AcgResources.ID_TRUNKINGLABELLINE2, 14);
						this.cHO9TrkTopFunctionButtonLabelLine2_A36651.IgnoreOnCompare = true;
						this.cHO9TrkTopFunctionButtonLabelLine2_A36651.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.cHO9TrkTopFunctionButtonLabelLine2_A36651.DataTransferOrder = -1;
						num = (short)1602158625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 10:
					goto IL_20D;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苌鋐鯒臔룖꧘鷚꣜뇞苠韢賤裦蟨믪鿬胮雰臲铴髶铸髺鿼鏾搀䄂瀄猆紈搊挌䌎縐紒爔尖簘戚䴜洞䐠倢嘤猦䀨䘪䠬", a_)))
					{
						num = (short)972226583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FEF;
				case 12:
					this.o9CHTrkTopFunctionButtonFeature_A36637 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexO9CHTrkTopFunctionButtonFeature_A36637LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idO9CHTrkTopFunctionButtonFeature_A36637LovStrs), this, global::AllFeatures.CodeplugGuid.b("苌鋐鯒臔ꗖ님迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺민髾怀眂瀄甆氈吊䰌㰎✐┒☔‖", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.O9CHTrkTopFunctionButtonFeature_A36637LovStrs);
					this.o9CHTrkTopFunctionButtonFeature_A36637.IgnoreOnCompare = true;
					this.o9CHTrkTopFunctionButtonFeature_A36637.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.o9CHTrkTopFunctionButtonFeature_A36637.DataTransferOrder = -1;
					num = (short)223608854;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					this.o9CHTrkTopFunctionButtonIndex_A36639 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("苌鋐鯒臔ꗖ님迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺듼釾攀昂約堆䠈㠊㬌㤎∐⨒", a_), global::CommonResources.AcgResources.ID_TRUNKINGINDEX, null, null, 0, 1);
					this.o9CHTrkTopFunctionButtonIndex_A36639.IgnoreOnCompare = true;
					this.o9CHTrkTopFunctionButtonIndex_A36639.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.o9CHTrkTopFunctionButtonIndex_A36639.DataTransferOrder = -1;
					this.o9CHTrkTopFunctionButtonIndex_A36639.ShowHexValue = false;
					num = (short)1811808315;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					this.cHO9CnvTopFunctionButtonLabelLine1_A36626 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("軌蟎黐雔맖꿘迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺뇼黾挀昂椄䬆怈攊栌㸎丐划☔№⼘⤚⬜", a_), global::CommonResources.AcgResources.ID_LABELLINE1, 6);
					this.cHO9CnvTopFunctionButtonLabelLine1_A36626.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHO9CnvTopFunctionButtonLabelLine1_A36626.DataTransferOrder = 6;
					num = (short)1953890330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					this.cHO9TopFunctionButton_A36618 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_BUTTON1, this, global::AllFeatures.CodeplugGuid.b("軌蟎黐臔룖꧘鷚꣜뇞苠韢賤裦蟨ꧪ飬鯮藰鳲鯴ꣶ룸죺쯼짾\u3000㬂", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.cHO9TopFunctionButton_A36618.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHO9TopFunctionButton_A36618.DataTransferOrder = -1;
					num = (short)371326977;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_778;
				case 17:
					this.topFunctionBtnTrkZone_A36944 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("駌ꃎꇐ闒ꃔ맖뫘꿚드냞迠ꇢ釤触뷨駪蛬뗮黰鷲郴ꣶ룸죺쯼웾㔀㜂", a_), global::CommonResources.AcgResources.ID_TRUNKINGZONE, null, null, false, false);
					this.topFunctionBtnTrkZone_A36944.IgnoreOnCompare = true;
					this.topFunctionBtnTrkZone_A36944.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.topFunctionBtnTrkZone_A36944.DataTransferOrder = -1;
					num = (short)123404288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苌鋐鯒臔ꗖ님迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺껼课爀丂瘄怆䀈攊椌樎椐䰒吔␖⼘Ⱊ├ⴞ", a_)))
					{
						num = (short)1267400742;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_38A;
				case 19:
					goto IL_72A;
				case 20:
					goto IL_6DE;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駌ꃎꇐ闒ꃔ맖뫘꿚드냞迠ꇢ釤触뷨駪蛬뗮黰鷲郴ꣶ룸죺쯼웾㔀㜂", a_)))
					{
						num = (short)116588561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F38;
				case 22:
					goto IL_9C7;
				case 23:
					this.o9CHTopFunctionProgrammableButtonLongKeyPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("苌鋐鯒臔룖꧘鷚꣜뇞苠韢賤裦蟨믪鿬胮雰臲铴髶铸髺鿼鏾搀䄂瀄猆紈搊挌䌎縐紒爔尖簘戚䴜洞䐠倢嘤猦䀨䘪䠬", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
					this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.DataTransferOrder = -1;
					((global::AcpBusinessLayer.AcpSimpleRangeField)this.o9CHTopFunctionProgrammableButtonLongKeyPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.ShowHexValue = false;
					this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.ValidateAcrossRecset = true;
					num = (short)1551958052;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌蟎黐雔맖꿘迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺뇼黾挀昂椄䬆怈攊栌㴎丐划☔№⼘⤚⨜", a_)))
					{
						num = (short)934215687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_20D;
				case 25:
					if (producerFields != null)
					{
						num = (short)1801912323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FEF;
				case 26:
					goto IL_979;
				case 27:
					goto IL_5D3;
				case 28:
				{
					num = (short)1784086528;
					short num4 = num;
					this.o9CHCnvTopFunctionButtonFeature_A36629 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexO9CHCnvTopFunctionButtonFeature_A36629LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idO9CHCnvTopFunctionButtonFeature_A36629LovStrs), this, global::AllFeatures.CodeplugGuid.b("苌鋐鯒雔맖꿘迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺민髾怀眂瀄甆氈吊䰌㰎✐┒✔⸖", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.O9CHCnvTopFunctionButtonFeature_A36629LovStrs);
					this.o9CHCnvTopFunctionButtonFeature_A36629.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.o9CHCnvTopFunctionButtonFeature_A36629.DataTransferOrder = 8;
					num = (short)429981712;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 29:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苌鋐鯒臔ꗖ님迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺듼釾攀昂約堆䠈㠊㬌㤎∐⨒", a_)))
					{
						num = (short)554958861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_584;
				case 30:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌蟎黐臔ꗖ님迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺뇼黾挀昂椄䬆怈攊栌㴎丐划☔№⼘⸚Ⱌ", a_)))
					{
						num = (short)520814601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D65;
				case 31:
					this.cnvTopFunctionButtonBCO_A36628 = new global::AcpBusinessLayer.AcpSparseLOVField(160, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexCnvTopFunctionButtonBCO_A36628LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idCnvTopFunctionButtonBCO_A36628LovStrs), this, global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ蟒뫔Ꟗ鿘껚돜볞闠諢諤触ꯨ黪駬鯮黰鷲럴듶뛸ꓺ볼쳾㜀㔂㜄㼆", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.CnvTopFunctionButtonBCO_A36628LovStrs);
					this.cnvTopFunctionButtonBCO_A36628.IgnoreOnCompare = true;
					this.cnvTopFunctionButtonBCO_A36628.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cnvTopFunctionButtonBCO_A36628.DataTransferOrder = -1;
					num = (short)1151795237;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					goto IL_148;
				case 33:
					goto IL_D65;
				case 34:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌蟎黐臔ꗖ님迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺뇼黾挀昂椄䬆怈攊栌㸎丐划☔№⼘⸚ⴜ", a_)))
					{
						num = (short)981205039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AD8;
				case 35:
					goto IL_1C1;
				case 36:
					goto IL_57F;
				case 37:
					goto IL_430;
				case 38:
					this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("苌鋐鯒臔ꗖ님迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺껼课爀丂瘄怆䀈攊椌樎椐䰒吔␖⼘Ⱊ├ⴞ", a_), global::CommonResources.AcgResources.ID_TRUNKINGSTSMSGINDEX, null, null, 0, 1);
					this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.IgnoreOnCompare = true;
					this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.DataTransferOrder = -1;
					this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.ShowHexValue = false;
					num = (short)1747320888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駌ꃎꇐ闒ꃔ맖뫘꿚드냞迠ꇢ釤触뷨駪蛬곮駰鋲鯴駶鳸韺ꋼ뻾㈀㔂㰄㌆㰈", a_)))
					{
						num = (short)810090536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_148;
				case 40:
					this.topFunctionBtnTrkChannel_A36945 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("駌ꃎꇐ闒ꃔ맖뫘꿚드냞迠ꇢ釤触뷨駪蛬곮駰鋲鯴駶鳸韺ꋼ뻾㈀㔂㰄㌆㰈", a_), global::CommonResources.AcgResources.ID_TRUNKINGCHANNEL, null, null, false, false);
					this.topFunctionBtnTrkChannel_A36945.IgnoreOnCompare = true;
					this.topFunctionBtnTrkChannel_A36945.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.topFunctionBtnTrkChannel_A36945.DataTransferOrder = -1;
					num = (short)636551200;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 41:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苌鋐鯒臔룖꧘鷚꣜뇞苠韢賤裦蟨믪鿬胮雰臲铴髶铸髺鿼鏾搀䄂瀄猆紈搊挌導礐簒朔挖刘縚搜伞匠䘢嘤否紨䈪䀬䨮", a_)))
					{
						num = (short)1043070978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DB3;
				case 42:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌蟎黐臔룖꧘鷚꣜뇞苠韢賤裦蟨ꧪ飬鯮藰鳲鯴ꣶ룸죺쯼짾\u3000㬂", a_)))
					{
						num = (short)273612815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E57;
				case 43:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苌鋐鯒雔맖꿘迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺듼釾攀昂約堆䠈㠊㬌㤎∐✒", a_)))
					{
						num = (short)647757874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6DE;
				case 44:
					goto IL_AD8;
				case 45:
					goto IL_DB3;
				case 46:
					this.o9CHTrkTopFunctionButtonBCO_A36636 = new global::AcpBusinessLayer.AcpSparseLOVField(160, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexO9CHTrkTopFunctionButtonBCO_A36636LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idO9CHTrkTopFunctionButtonBCO_A36636LovStrs), this, global::AllFeatures.CodeplugGuid.b("苌鋐鯒臔ꗖ님迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺뿼볾一専䐄㐆㼈㴊㸌㤎", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.O9CHTrkTopFunctionButtonBCO_A36636LovStrs);
					this.o9CHTrkTopFunctionButtonBCO_A36636.IgnoreOnCompare = true;
					this.o9CHTrkTopFunctionButtonBCO_A36636.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.o9CHTrkTopFunctionButtonBCO_A36636.DataTransferOrder = -1;
					num = (short)91226170;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 47:
					this.cHO9TrkTopFunctionButtonLabelLine1_A36650 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("軌蟎黐臔ꗖ님迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺뇼黾挀昂椄䬆怈攊栌㸎丐划☔№⼘⸚ⴜ", a_), global::CommonResources.AcgResources.ID_TRUNKINGLABELLINE1, 14);
					this.cHO9TrkTopFunctionButtonLabelLine1_A36650.IgnoreOnCompare = true;
					this.cHO9TrkTopFunctionButtonLabelLine1_A36650.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cHO9TrkTopFunctionButtonLabelLine1_A36650.DataTransferOrder = -1;
					num = (short)1998192684;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 48:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駌ꃎꇐ闒ꃔ맖뫘꿚드냞迠ꇢ釤触ꫨ藪鯬곮駰鋲鯴駶鳸韺ꋼ뻾㈀㔂㰄㌆㨈", a_)))
					{
						num = (short)2094006277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B4B;
				case 49:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軌ꇎꟐ蟒뫔Ꟗ鿘껚돜볞闠諢諤触ꯨ黪駬鯮黰鷲럴듶뛸ꓺ볼쳾㜀㔂㜄㼆", a_)))
					{
						num = (short)1312096287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_430;
				case 50:
					this.o9CHCnvTopFunctionButtonIndex_A36634 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("苌鋐鯒雔맖꿘迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺듼釾攀昂約堆䠈㠊㬌㤎∐✒", a_), global::CommonResources.AcgResources.ID_INDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.o9CHCnvTopFunctionButtonIndex_A36634.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.o9CHCnvTopFunctionButtonIndex_A36634.DataTransferOrder = 9;
					this.o9CHCnvTopFunctionButtonIndex_A36634.ValidateAcrossRecset = true;
					num = (short)1681457172;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 51:
					goto IL_B4B;
				case 52:
					switch (0)
					{
					case 0:
						goto IL_121;
					}
					continue;
				case 53:
					this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("苌鋐鯒雔맖꿘迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺껼课爀丂瘄怆䀈攊椌樎椐䰒吔␖⼘Ⱊ├⸞", a_), global::CommonResources.AcgResources.ID_STSMSGINDEX, null, null, 0, 1);
					this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.DataTransferOrder = 10;
					this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.ValidateAcrossRecset = true;
					this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.ShowHexValue = false;
					num = (short)1895235603;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 54:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苌鋐鯒臔ꗖ님迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺뿼볾一専䐄㐆㼈㴊㸌㤎", a_)))
					{
						num = (short)1027276846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A14;
				case 55:
					this.topFunctionBtnCnvZone_A36942 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("駌ꃎꇐ闒ꃔ맖뫘꿚드냞迠ꇢ釤触ꫨ藪鯬뗮黰鷲郴ꣶ룸죺쯼웾㔀㄂", a_), global::CommonResources.AcgResources.ID_ZONE, null, null, false, false);
					this.topFunctionBtnCnvZone_A36942.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.topFunctionBtnCnvZone_A36942.DataTransferOrder = 11;
					num = (short)2001731619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 56:
					goto IL_38A;
				case 57:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苌鋐鯒雔맖꿘迚닜꿞꟠離诤蓦鷨苪苬臮돰蛲致菶雸闺민髾怀眂瀄甆氈吊䰌㰎✐┒✔⸖", a_)))
					{
						num = (short)80740380;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_778;
				case 58:
					goto IL_A14;
				case 59:
					goto IL_584;
				case 60:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駌ꃎꇐ闒ꃔ맖뫘꿚드냞迠ꇢ釤触ꫨ藪鯬뗮黰鷲郴ꣶ룸죺쯼웾㔀㄂", a_)))
					{
						num = (short)837877815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C1;
				}
				IL_121:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)173473819;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_148:
				num = (short)1111425081;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C1:
				num = (short)1862402096;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_20D:
				num = (short)2093613105;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_38A:
				num = (short)1714487337;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_430:
				num = (short)2011758635;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_584:
				num = (short)1636106274;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5D3:
				num = (short)1065353241;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6DE:
				num = (short)1605959734;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_72A:
				num = (short)56623122;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_778:
				num = (short)994246664;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_979:
				num = (short)2097872920;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9C7:
				num = (short)1375272966;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A14:
				num = (short)88539165;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AD8:
				num = (short)1863712798;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B4B:
				num = (short)681771029;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D65:
				num = (short)66977852;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_DB3:
				num = (short)1225392139;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E57:
				num = (short)510590980;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F38:
				num = (short)2015363111;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_57F:
			IL_FEF:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("駌ꃎꇐ鏔ꋖ럘룚꧜뛞軠跢엤럦鯨蓪諬鷮郰黲飴零鯸韺飼\udffe䌀瘂焄猆昈攊", a_);
			base.Id = 10617;
			base.UIName = global::CommonResources.AcgResources.ID_TOPFUNCTIONPROGRAMMABLEBUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008503 RID: 34051 RVA: 0x007B79A4 File Offset: 0x007B5BA4
		public override void PopulateReferences()
		{
			short num = (short)1954107148;
			short num2 = num;
			num = (short)1482903308;
			switch (num2 == num)
			{
			default:
			{
				num = (short)385548288;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)925237249;
			if (num != 0)
			{
			}
			num = (short)1274675200;
			if (num != 0)
			{
			}
			this.topFunctionBtnCnvZone_A36942.SetRecset(this.a(2051));
			this.topFunctionBtnTrkZone_A36944.SetRecset(this.a(2051));
			this.topFunctionBtnCnvZone_A36942.AddSlaveField(this.topFunctionBtnCnvChannel_A36943, 10114);
			this.topFunctionBtnTrkZone_A36944.AddSlaveField(this.topFunctionBtnTrkChannel_A36945, 10114);
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			global::System.Collections.Generic.List<global::AcpBusinessLayer.Recordset> list2 = new global::System.Collections.Generic.List<global::AcpBusinessLayer.Recordset>();
			list2.Add((global::AcpBusinessLayer.Recordset)this.a(4008));
			list.Add(global::CommonResources.AcgResources.ID_ACTIONCONSOLIDATION);
			list2.Add((global::AcpBusinessLayer.Recordset)this.a(2045)[0][10604].EmbeddedRecset);
			list.Add(global::CommonResources.AcgResources.ID_RELAYPATTERN);
			((global::AcpBusinessLayer.AcpSparseLOVField)this.o9CHCnvTopFunctionButtonFeature_A36629).SetBuddyRecRefField(this.o9CHCnvTopFunctionButtonIndex_A36634, list2, list);
		}

		// Token: 0x06008504 RID: 34052 RVA: 0x007B7B20 File Offset: 0x007B5D20
		public override void DropReferences()
		{
			short num = (short)677721393;
			short num2 = num;
			num = (short)1158034737;
			switch (num2 == num)
			{
			default:
			{
				num = (short)758972416;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)77332480;
			if (num != 0)
			{
			}
			num = (short)1220476929;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008505 RID: 34053 RVA: 0x007B7BCC File Offset: 0x007B5DCC
		public override void SetConstraints()
		{
			short num = (short)1424453303;
			short num2 = num;
			num = (short)1589079735;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1955069952;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2122579969;
			if (num != 0)
			{
			}
			num = (short)2001534976;
			if (num != 0)
			{
			}
			this.cHO9TopFunctionButton_A36618.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.cHO9CnvTopFunctionButtonLabelLine1_A36626.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableApp);
			this.cHO9CnvTopFunctionButtonLabelLine1_A36626.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConTopFunctionButtonLabel1Valid);
			this.cHO9CnvTopFunctionButtonLabelLine1_A36626.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableEditable);
			this.cHO9CnvTopFunctionButtonLabelLine1_A36626.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConSyncTrkTopButtonLabel1WithCnvTopButtonLabel1inO9);
			this.cHO9CnvTopFunctionButtonLabelLine2_A36627.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableApp);
			this.cHO9CnvTopFunctionButtonLabelLine2_A36627.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConTopFunctionButtonLabel2Valid);
			this.cHO9CnvTopFunctionButtonLabelLine2_A36627.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableEditable);
			this.cHO9CnvTopFunctionButtonLabelLine2_A36627.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConSyncTrkTopButtonLabel2WithCnvTopButtonLabel2inO9);
			this.o9CHCnvTopFunctionButtonIndex_A36634.ValidateAcrossRecset = true;
			this.o9CHCnvTopFunctionButtonIndex_A36634.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConTopFunctionButtonIndexApplicable);
			this.o9CHCnvTopFunctionButtonIndex_A36634.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConACorRelayPatternUniqueinTopandBottomandDirLightTBL);
			this.o9CHCnvTopFunctionButtonIndex_A36634.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableEditable);
			this.o9CHCnvTopFunctionButtonIndex_A36634.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConValueSetIfTopButtomACOrLBIndexChanged);
			this.o9CHTrkTopFunctionButtonIndex_A36639.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConTopFunctionButtonIndexApplicable);
			this.o9CHTrkTopFunctionButtonIndex_A36639.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConTopFunctionButtonIndexEditbl);
			this.topFunctionBtnCnvZone_A36942.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConTopFunctionButtonCnvZoneApplicable);
			this.topFunctionBtnCnvZone_A36942.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConIsDynamicZoneValidInO9TopButtonCnvZone);
			this.topFunctionBtnCnvZone_A36942.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableEditable);
			this.topFunctionBtnCnvZone_A36942.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConTopFunctionButtonModeZoneSelect);
			this.topFunctionBtnCnvChannel_A36943.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConTopFunctionBtnCnvChannelApplicable);
			this.topFunctionBtnCnvChannel_A36943.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableEditable);
			this.topFunctionBtnCnvChannel_A36943.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConTopFunctionButtonModeChannelSelect);
			this.topFunctionBtnTrkZone_A36944.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConTopFunctionButtonTrkZoneApplicable);
			this.topFunctionBtnTrkZone_A36944.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConIsDynamicZoneValidInO9TopButtonTrkZone);
			this.topFunctionBtnTrkZone_A36944.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConTopFunctionButtonTrkZoneEditbl);
			this.topFunctionBtnTrkChannel_A36945.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConTopFunctionBtnTrkChannelApplicable);
			this.topFunctionBtnTrkChannel_A36945.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConTopFunctionBtnTrkChannelEditabl);
			this.o9CHCnvTopFunctionButtonFeature_A36629.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableApp);
			this.o9CHCnvTopFunctionButtonFeature_A36629.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConCHO9ButtonFeaturesSelect);
			this.o9CHCnvTopFunctionButtonFeature_A36629.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableEditable);
			this.o9CHCnvTopFunctionButtonFeature_A36629.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConValueSetIfTopButtomFeatIsStxOrMsgOrACOrLB);
			this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.ValidateAcrossRecset = true;
			this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConTopFunctionButtonStsMsgIndexApplicable);
			this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConTopFunStsOrMsgIndexPairUniqueConstraint);
			this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableEditable);
			this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConValueSetIfTopButtomStxOrMsgIndexChanged);
			this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConTopFunctionButtonStsMsgIndexApplicable);
			this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConTopFunctionButtonStsMsgIndexEditbl);
		}

		// Token: 0x06008506 RID: 34054 RVA: 0x007B7FE4 File Offset: 0x007B61E4
		public override void SetupDependencies()
		{
			short num = (short)1301026682;
			short num2 = num;
			num = (short)571938682;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1509490688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)7405568;
			if (num != 0)
			{
			}
			num = (short)1868955649;
			if (num != 0)
			{
			}
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cHO9CnvTopFunctionButtonLabelLine1_A36626);
			this.cHO9TrkTopFunctionButtonLabelLine1_A36650.AddDependentObject(this.cHO9CnvTopFunctionButtonLabelLine1_A36626);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cHO9CnvTopFunctionButtonLabelLine2_A36627);
			this.cHO9TrkTopFunctionButtonLabelLine2_A36651.AddDependentObject(this.cHO9CnvTopFunctionButtonLabelLine2_A36627);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.o9CHCnvTopFunctionButtonIndex_A36634);
			this.o9CHCnvTopFunctionButtonFeature_A36629.AddDependentObject(this.o9CHCnvTopFunctionButtonIndex_A36634);
			this.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.AddDependentObject(this.o9CHCnvTopFunctionButtonIndex_A36634);
			this.o9CHCnvTopFunctionButtonIndex_A36634.AddDependentObject(this.o9CHTrkTopFunctionButtonIndex_A36639);
			this.o9CHCnvTopFunctionButtonFeature_A36629.AddDependentObject(this.o9CHTrkTopFunctionButtonIndex_A36639);
			this.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.AddDependentObject(this.o9CHTrkTopFunctionButtonIndex_A36639);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.o9CHTrkTopFunctionButtonIndex_A36639);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.topFunctionBtnCnvZone_A36942);
			this.o9CHCnvTopFunctionButtonFeature_A36629.AddDependentObject(this.topFunctionBtnCnvZone_A36942);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.topFunctionBtnCnvChannel_A36943);
			this.o9CHCnvTopFunctionButtonFeature_A36629.AddDependentObject(this.topFunctionBtnCnvChannel_A36943);
			this.o9CHCnvTopFunctionButtonFeature_A36629.AddDependentObject(this.topFunctionBtnTrkZone_A36944);
			this.o9CHCnvTopFunctionButtonFeature_A36629.AddDependentObject(this.topFunctionBtnTrkChannel_A36945);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.o9CHCnvTopFunctionButtonFeature_A36629);
			this.RefRadioErgonomicsWide.PASiren.RadErgoWidePASirenHiLoAirhornTones_A8200.AddDependentObject(this.o9CHCnvTopFunctionButtonFeature_A36629);
			this.RefRadioErgonomicsWide.PASiren.RadErgoWidePASirenSirenOperation_A9139.AddDependentObject(this.o9CHCnvTopFunctionButtonFeature_A36629);
			this.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.AddDependentObject(this.o9CHCnvTopFunctionButtonFeature_A36629);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781);
			this.o9CHCnvTopFunctionButtonFeature_A36629.AddDependentObject(this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781);
			this.o9CHCnvTopFunctionButtonFeature_A36629.AddDependentObject(this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782);
			this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.AddDependentObject(this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782);
		}

		// Token: 0x170043A5 RID: 17317
		// (get) Token: 0x06008507 RID: 34055 RVA: 0x007B82F0 File Offset: 0x007B64F0
		public global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation ActionConsolidationForO9CHCnvTopFunctionButtonIndex_A36634
		{
			get
			{
				short num = (short)1679400466;
				short num2 = num;
				num = (short)2081070610;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1103101952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)760217601;
				if (num != 0)
				{
				}
				num = (short)1551958016;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonIndex_A36634.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation;
			}
		}

		// Token: 0x170043A6 RID: 17318
		// (get) Token: 0x06008508 RID: 34056 RVA: 0x007B83AC File Offset: 0x007B65AC
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment ZoneChannelAssignmentForTopFunctionBtnCnvZone_A36942
		{
			get
			{
				short num = (short)965632835;
				short num2 = num;
				num = (short)161833795;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1920270336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)608501761;
				if (num != 0)
				{
				}
				num = (short)1995702272;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvZone_A36942.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
			}
		}

		// Token: 0x170043A7 RID: 17319
		// (get) Token: 0x06008509 RID: 34057 RVA: 0x007B8464 File Offset: 0x007B6664
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner ChannelAssignmentListInnerSectionForTopFunctionBtnCnvChannel_A36943
		{
			get
			{
				short num = (short)1379241825;
				short num2 = num;
				num = (short)287346529;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1837170688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)425132032;
				if (num != 0)
				{
				}
				num = (short)1472004097;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvChannel_A36943.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
			}
		}

		// Token: 0x170043A8 RID: 17320
		// (get) Token: 0x0600850A RID: 34058 RVA: 0x007B851C File Offset: 0x007B671C
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment ZoneChannelAssignmentForTopFunctionBtnTrkZone_A36944
		{
			get
			{
				short num = (short)1190920193;
				if (num != 0)
				{
				}
				num = (short)435814400;
				short num2 = num;
				num = (short)708551353;
				short num3 = num;
				num = (short)85828281;
				switch (num3 == num)
				{
				}
				num = (short)466026496;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkZone_A36944.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
			}
		}

		// Token: 0x170043A9 RID: 17321
		// (get) Token: 0x0600850B RID: 34059 RVA: 0x007B85D8 File Offset: 0x007B67D8
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner ChannelAssignmentListInnerSectionForTopFunctionBtnTrkChannel_A36945
		{
			get
			{
				short num = (short)507344085;
				short num2 = num;
				num = (short)492270805;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1432944640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)609026048;
				if (num != 0)
				{
				}
				num = (short)1867186177;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkChannel_A36945.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
			}
		}

		// Token: 0x170043AA RID: 17322
		// (get) Token: 0x0600850C RID: 34060 RVA: 0x007B8694 File Offset: 0x007B6894
		public bool HasDiffs
		{
			get
			{
				short num = (short)2067394855;
				short num2 = num;
				num = (short)460452135;
				switch (num2 == num)
				{
				default:
				{
					num = (short)392429568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)58064897;
				if (num != 0)
				{
				}
				num = (short)105054208;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170043AB RID: 17323
		// (get) Token: 0x0600850D RID: 34061 RVA: 0x007B8744 File Offset: 0x007B6944
		// (set) Token: 0x0600850E RID: 34062 RVA: 0x007B87F8 File Offset: 0x007B69F8
		public string CHO9TopFunctionButton_A36618Value
		{
			get
			{
				short num = (short)700645377;
				if (num != 0)
				{
				}
				num = (short)1239810048;
				short num2 = num;
				num = (short)375073928;
				short num3 = num;
				num = (short)810364040;
				switch (num3 == num)
				{
				}
				num = (short)1738211328;
				if (num != 0)
				{
				}
				return this.cHO9TopFunctionButton_A36618.Value;
			}
			set
			{
				short num = (short)1688272897;
				if (num != 0)
				{
				}
				num = (short)960364544;
				short num2 = num;
				num = (short)1393309408;
				short num3 = num;
				num = (short)2025338592;
				switch (num3 == num)
				{
				}
				num = (short)2113273856;
				if (num != 0)
				{
				}
				this.cHO9TopFunctionButton_A36618.Value = value;
			}
		}

		// Token: 0x170043AC RID: 17324
		// (get) Token: 0x0600850F RID: 34063 RVA: 0x007B88A8 File Offset: 0x007B6AA8
		public global::AcpBusinessLayer.AcpField<string> CHO9TopFunctionButton_A36618
		{
			get
			{
				short num = (short)1541537793;
				if (num != 0)
				{
				}
				num = (short)1115029504;
				short num2 = num;
				num = (short)165818109;
				short num3 = num;
				num = (short)1247620861;
				switch (num3 == num)
				{
				}
				num = (short)10747904;
				if (num != 0)
				{
				}
				return this.cHO9TopFunctionButton_A36618;
			}
		}

		// Token: 0x170043AD RID: 17325
		// (get) Token: 0x06008510 RID: 34064 RVA: 0x007B8958 File Offset: 0x007B6B58
		// (set) Token: 0x06008511 RID: 34065 RVA: 0x007B8A0C File Offset: 0x007B6C0C
		public string CHO9TopFunctionButton_A36618_UIValue
		{
			get
			{
				short num = (short)737542145;
				if (num != 0)
				{
				}
				num = (short)1799880704;
				short num2 = num;
				num = (short)2052035031;
				short num3 = num;
				num = (short)112234967;
				switch (num3 == num)
				{
				}
				num = (short)1399324672;
				if (num != 0)
				{
				}
				return this.cHO9TopFunctionButton_A36618.Value;
			}
			set
			{
				short num = (short)457372585;
				short num2 = num;
				num = (short)796849065;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1719336960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1665925121;
				if (num != 0)
				{
				}
				num = (short)1492844544;
				if (num != 0)
				{
				}
				this.cHO9TopFunctionButton_A36618.Value = value;
			}
		}

		// Token: 0x170043AE RID: 17326
		// (get) Token: 0x06008512 RID: 34066 RVA: 0x007B8AC0 File Offset: 0x007B6CC0
		// (set) Token: 0x06008513 RID: 34067 RVA: 0x007B8B70 File Offset: 0x007B6D70
		public bool CHO9TopFunctionButton_A36618_Applicable
		{
			get
			{
				short num = (short)861052452;
				short num2 = num;
				num = (short)662543908;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1226244096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2136997889;
				if (num != 0)
				{
				}
				num = (short)1626275840;
				if (num != 0)
				{
				}
				return this.cHO9TopFunctionButton_A36618.Applicable;
			}
			set
			{
				short num = (short)1191313409;
				if (num != 0)
				{
				}
				num = (short)624951296;
				short num2 = num;
				num = (short)319685091;
				short num3 = num;
				num = (short)1548550627;
				switch (num3 == num)
				{
				}
				num = (short)2119368704;
				if (num != 0)
				{
				}
				this.cHO9TopFunctionButton_A36618.Applicable = value;
			}
		}

		// Token: 0x170043AF RID: 17327
		// (get) Token: 0x06008514 RID: 34068 RVA: 0x007B8C24 File Offset: 0x007B6E24
		// (set) Token: 0x06008515 RID: 34069 RVA: 0x007B8CD8 File Offset: 0x007B6ED8
		public bool CHO9TopFunctionButton_A36618_Valid
		{
			get
			{
				short num = (short)1258926235;
				short num2 = num;
				num = (short)1759424667;
				switch (num2 == num)
				{
				default:
				{
					num = (short)21364736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1259536384;
				if (num != 0)
				{
				}
				num = (short)713621505;
				if (num != 0)
				{
				}
				return this.cHO9TopFunctionButton_A36618.Valid;
			}
			set
			{
				short num = (short)1436187120;
				short num2 = num;
				num = (short)1090746864;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1097990144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)141033473;
				if (num != 0)
				{
				}
				num = (short)1966342144;
				if (num != 0)
				{
				}
				this.cHO9TopFunctionButton_A36618.Valid = value;
			}
		}

		// Token: 0x170043B0 RID: 17328
		// (get) Token: 0x06008516 RID: 34070 RVA: 0x007B8D8C File Offset: 0x007B6F8C
		// (set) Token: 0x06008517 RID: 34071 RVA: 0x007B8E40 File Offset: 0x007B7040
		public bool CHO9TopFunctionButton_A36618_Visible
		{
			get
			{
				short num = (short)103208159;
				short num2 = num;
				num = (short)1731908831;
				switch (num2 == num)
				{
				default:
				{
					num = (short)369557504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)4849665;
				if (num != 0)
				{
				}
				num = (short)232259584;
				if (num != 0)
				{
				}
				return this.cHO9TopFunctionButton_A36618.Visible;
			}
			set
			{
				short num = (short)765692243;
				short num2 = num;
				num = (short)262703443;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1273430016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)714145793;
				if (num != 0)
				{
				}
				num = (short)1091633152;
				if (num != 0)
				{
				}
				this.cHO9TopFunctionButton_A36618.Visible = value;
			}
		}

		// Token: 0x170043B1 RID: 17329
		// (get) Token: 0x06008518 RID: 34072 RVA: 0x007B8EF8 File Offset: 0x007B70F8
		// (set) Token: 0x06008519 RID: 34073 RVA: 0x007B8FAC File Offset: 0x007B71AC
		public bool CHO9TopFunctionButton_A36618_Editable
		{
			get
			{
				short num = (short)1113241913;
				short num2 = num;
				num = (short)1730984249;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1915551744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1761280001;
				if (num != 0)
				{
				}
				num = (short)1990131712;
				if (num != 0)
				{
				}
				return this.cHO9TopFunctionButton_A36618.Editable;
			}
			set
			{
				short num = (short)960369143;
				short num2 = num;
				num = (short)935793143;
				switch (num2 == num)
				{
				default:
				{
					num = (short)945029120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)202702849;
				if (num != 0)
				{
				}
				num = (short)1095761920;
				if (num != 0)
				{
				}
				this.cHO9TopFunctionButton_A36618.Editable = value;
			}
		}

		// Token: 0x170043B2 RID: 17330
		// (get) Token: 0x0600851A RID: 34074 RVA: 0x007B9060 File Offset: 0x007B7260
		internal string CHO9TopFunctionButton_A36618_UILabel
		{
			get
			{
				short num = (short)554481248;
				short num2 = num;
				num = (short)91862624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)573964288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)748748801;
				if (num != 0)
				{
				}
				num = (short)179961856;
				if (num != 0)
				{
				}
				return this.cHO9TopFunctionButton_A36618.UIName;
			}
		}

		// Token: 0x170043B3 RID: 17331
		// (get) Token: 0x0600851B RID: 34075 RVA: 0x007B9110 File Offset: 0x007B7310
		// (set) Token: 0x0600851C RID: 34076 RVA: 0x007B91C4 File Offset: 0x007B73C4
		internal bool CHO9TopFunctionButton_A36618_HiddenStatic
		{
			get
			{
				short num = (short)654335101;
				short num2 = num;
				num = (short)1930452093;
				switch (num2 == num)
				{
				default:
				{
					num = (short)158859264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)237174784;
				if (num != 0)
				{
				}
				num = (short)1817182209;
				if (num != 0)
				{
				}
				return this.cHO9TopFunctionButton_A36618.HiddenStatic;
			}
			set
			{
				short num = (short)955811900;
				short num2 = num;
				num = (short)256477244;
				switch (num2 == num)
				{
				default:
				{
					num = (short)204275712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)838598656;
				if (num != 0)
				{
				}
				num = (short)1884749825;
				if (num != 0)
				{
				}
				this.cHO9TopFunctionButton_A36618.HiddenStatic = value;
			}
		}

		// Token: 0x170043B4 RID: 17332
		// (get) Token: 0x0600851D RID: 34077 RVA: 0x007B9274 File Offset: 0x007B7474
		// (set) Token: 0x0600851E RID: 34078 RVA: 0x007B9328 File Offset: 0x007B7528
		internal bool CHO9TopFunctionButton_A36618_HiddenDynamic
		{
			get
			{
				short num = (short)1976434689;
				if (num != 0)
				{
				}
				num = (short)1864695808;
				short num2 = num;
				num = (short)996809529;
				short num3 = num;
				num = (short)1838029625;
				switch (num3 == num)
				{
				}
				num = (short)1193213952;
				if (num != 0)
				{
				}
				return this.cHO9TopFunctionButton_A36618.HiddenDynamic;
			}
			set
			{
				short num = (short)482591504;
				short num2 = num;
				num = (short)1823720208;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1972436992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)671547392;
				if (num != 0)
				{
				}
				num = (short)344981505;
				if (num != 0)
				{
				}
				this.cHO9TopFunctionButton_A36618.HiddenDynamic = value;
			}
		}

		// Token: 0x170043B5 RID: 17333
		// (get) Token: 0x0600851F RID: 34079 RVA: 0x007B93DC File Offset: 0x007B75DC
		public bool CHO9TopFunctionButton_A36618_HasDiffs
		{
			get
			{
				short num = (short)589692929;
				if (num != 0)
				{
				}
				num = (short)371720192;
				short num2 = num;
				num = (short)928005493;
				short num3 = num;
				num = (short)1226063221;
				switch (num3 == num)
				{
				}
				num = (short)6291456;
				if (num != 0)
				{
				}
				return this.cHO9TopFunctionButton_A36618._HasDiffs;
			}
		}

		// Token: 0x170043B6 RID: 17334
		// (get) Token: 0x06008520 RID: 34080 RVA: 0x007B9490 File Offset: 0x007B7690
		// (set) Token: 0x06008521 RID: 34081 RVA: 0x007B9544 File Offset: 0x007B7744
		public string CHO9CnvTopFunctionButtonLabelLine1_A36626Value
		{
			get
			{
				short num = (short)851938849;
				short num2 = num;
				num = (short)1152159265;
				switch (num2 == num)
				{
				default:
				{
					num = (short)521601024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1104216065;
				if (num != 0)
				{
				}
				num = (short)246415360;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine1_A36626.Value;
			}
			set
			{
				short num = (short)2034562691;
				short num2 = num;
				num = (short)1329657475;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2114322432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)996343809;
				if (num != 0)
				{
				}
				num = (short)1236664320;
				if (num != 0)
				{
				}
				this.cHO9CnvTopFunctionButtonLabelLine1_A36626.Value = value;
			}
		}

		// Token: 0x170043B7 RID: 17335
		// (get) Token: 0x06008522 RID: 34082 RVA: 0x007B95F8 File Offset: 0x007B77F8
		public global::AcpBusinessLayer.AcpField<string> CHO9CnvTopFunctionButtonLabelLine1_A36626
		{
			get
			{
				short num = (short)807590683;
				short num2 = num;
				num = (short)16374555;
				switch (num2 == num)
				{
				default:
				{
					num = (short)494469120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)753270784;
				if (num != 0)
				{
				}
				num = (short)1843724289;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine1_A36626;
			}
		}

		// Token: 0x170043B8 RID: 17336
		// (get) Token: 0x06008523 RID: 34083 RVA: 0x007B96A8 File Offset: 0x007B78A8
		// (set) Token: 0x06008524 RID: 34084 RVA: 0x007B9760 File Offset: 0x007B7960
		public string CHO9CnvTopFunctionButtonLabelLine1_A36626_UIValue
		{
			get
			{
				short num = (short)806938552;
				short num2 = num;
				num = (short)208463800;
				switch (num2 == num)
				{
				default:
				{
					num = (short)818413568;
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
				num = (short)1662582784;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine1_A36626.Value;
			}
			set
			{
				short num = (short)912203987;
				short num2 = num;
				num = (short)1951408339;
				switch (num2 == num)
				{
				default:
				{
					num = (short)240582656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1099563009;
				if (num != 0)
				{
				}
				num = (short)619511808;
				if (num != 0)
				{
				}
				this.cHO9CnvTopFunctionButtonLabelLine1_A36626.Value = value;
			}
		}

		// Token: 0x170043B9 RID: 17337
		// (get) Token: 0x06008525 RID: 34085 RVA: 0x007B9818 File Offset: 0x007B7A18
		// (set) Token: 0x06008526 RID: 34086 RVA: 0x007B98C8 File Offset: 0x007B7AC8
		public bool CHO9CnvTopFunctionButtonLabelLine1_A36626_Applicable
		{
			get
			{
				short num = (short)883963862;
				short num2 = num;
				num = (short)1880045526;
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
				num = (short)1443430401;
				if (num != 0)
				{
				}
				num = (short)1547239424;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine1_A36626.Applicable;
			}
			set
			{
				short num = (short)451509299;
				short num2 = num;
				num = (short)1831304243;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1246953472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2109145088;
				if (num != 0)
				{
				}
				num = (short)503316481;
				if (num != 0)
				{
				}
				this.cHO9CnvTopFunctionButtonLabelLine1_A36626.Applicable = value;
			}
		}

		// Token: 0x170043BA RID: 17338
		// (get) Token: 0x06008527 RID: 34087 RVA: 0x007B9980 File Offset: 0x007B7B80
		// (set) Token: 0x06008528 RID: 34088 RVA: 0x007B9A34 File Offset: 0x007B7C34
		public bool CHO9CnvTopFunctionButtonLabelLine1_A36626_Valid
		{
			get
			{
				short num = (short)647744206;
				short num2 = num;
				num = (short)248629966;
				switch (num2 == num)
				{
				default:
				{
					num = (short)691798016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)671350785;
				if (num != 0)
				{
				}
				num = (short)1308884992;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine1_A36626.Valid;
			}
			set
			{
				short num = (short)1604976641;
				if (num != 0)
				{
				}
				num = (short)385941504;
				short num2 = num;
				num = (short)1146069232;
				short num3 = num;
				num = (short)2120196336;
				switch (num3 == num)
				{
				}
				num = (short)1204879360;
				if (num != 0)
				{
				}
				this.cHO9CnvTopFunctionButtonLabelLine1_A36626.Valid = value;
			}
		}

		// Token: 0x170043BB RID: 17339
		// (get) Token: 0x06008529 RID: 34089 RVA: 0x007B9AEC File Offset: 0x007B7CEC
		// (set) Token: 0x0600852A RID: 34090 RVA: 0x007B9BA0 File Offset: 0x007B7DA0
		public bool CHO9CnvTopFunctionButtonLabelLine1_A36626_Visible
		{
			get
			{
				short num = (short)298722132;
				short num2 = num;
				num = (short)877077332;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1403453440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1027145728;
				if (num != 0)
				{
				}
				num = (short)829095937;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine1_A36626.Visible;
			}
			set
			{
				short num = (short)1356745564;
				short num2 = num;
				num = (short)1315326812;
				switch (num2 == num)
				{
				default:
				{
					num = (short)773914624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)150405121;
				if (num != 0)
				{
				}
				num = (short)705888256;
				if (num != 0)
				{
				}
				this.cHO9CnvTopFunctionButtonLabelLine1_A36626.Visible = value;
			}
		}

		// Token: 0x170043BC RID: 17340
		// (get) Token: 0x0600852B RID: 34091 RVA: 0x007B9C54 File Offset: 0x007B7E54
		// (set) Token: 0x0600852C RID: 34092 RVA: 0x007B9D08 File Offset: 0x007B7F08
		public bool CHO9CnvTopFunctionButtonLabelLine1_A36626_Editable
		{
			get
			{
				short num = (short)350088075;
				short num2 = num;
				num = (short)1709632395;
				switch (num2 == num)
				{
				default:
				{
					num = (short)547160064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1299906560;
				if (num != 0)
				{
				}
				num = (short)1822621697;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine1_A36626.Editable;
			}
			set
			{
				short num = (short)254389671;
				short num2 = num;
				num = (short)2037165479;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1632632832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)407633921;
				if (num != 0)
				{
				}
				num = (short)93061120;
				if (num != 0)
				{
				}
				this.cHO9CnvTopFunctionButtonLabelLine1_A36626.Editable = value;
			}
		}

		// Token: 0x170043BD RID: 17341
		// (get) Token: 0x0600852D RID: 34093 RVA: 0x007B9DBC File Offset: 0x007B7FBC
		internal string CHO9CnvTopFunctionButtonLabelLine1_A36626_UILabel
		{
			get
			{
				short num = (short)92083681;
				short num2 = num;
				num = (short)732435937;
				switch (num2 == num)
				{
				default:
				{
					num = (short)168230912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)651296769;
				if (num != 0)
				{
				}
				num = (short)1495072768;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine1_A36626.UIName;
			}
		}

		// Token: 0x170043BE RID: 17342
		// (get) Token: 0x0600852E RID: 34094 RVA: 0x007B9E70 File Offset: 0x007B8070
		// (set) Token: 0x0600852F RID: 34095 RVA: 0x007B9F24 File Offset: 0x007B8124
		internal bool CHO9CnvTopFunctionButtonLabelLine1_A36626_HiddenStatic
		{
			get
			{
				short num = (short)1223178775;
				short num2 = num;
				num = (short)1392917015;
				switch (num2 == num)
				{
				default:
				{
					num = (short)207945728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1554907136;
				if (num != 0)
				{
				}
				num = (short)2095972353;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine1_A36626.HiddenStatic;
			}
			set
			{
				short num = (short)1123155969;
				if (num != 0)
				{
				}
				num = (short)380497060;
				short num2 = num;
				num = (short)1839787172;
				switch (num2 == num)
				{
				}
				num = (short)739049472;
				short num3 = num;
				num = (short)672399360;
				if (num != 0)
				{
				}
				this.cHO9CnvTopFunctionButtonLabelLine1_A36626.HiddenStatic = value;
			}
		}

		// Token: 0x170043BF RID: 17343
		// (get) Token: 0x06008530 RID: 34096 RVA: 0x007B9FD8 File Offset: 0x007B81D8
		// (set) Token: 0x06008531 RID: 34097 RVA: 0x007BA090 File Offset: 0x007B8290
		internal bool CHO9CnvTopFunctionButtonLabelLine1_A36626_HiddenDynamic
		{
			get
			{
				short num = (short)557628884;
				short num2 = num;
				num = (short)866172372;
				switch (num2 == num)
				{
				}
				num = (short)1869873152;
				if (num != 0)
				{
				}
				num = (short)1224278016;
				short num3 = num;
				num = (short)175570945;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine1_A36626.HiddenDynamic;
			}
			set
			{
				short num = (short)1052927605;
				short num2 = num;
				num = (short)848848501;
				switch (num2 == num)
				{
				}
				num = (short)775553025;
				if (num != 0)
				{
				}
				num = (short)920518656;
				short num3 = num;
				num = (short)1278345216;
				if (num != 0)
				{
				}
				this.cHO9CnvTopFunctionButtonLabelLine1_A36626.HiddenDynamic = value;
			}
		}

		// Token: 0x170043C0 RID: 17344
		// (get) Token: 0x06008532 RID: 34098 RVA: 0x007BA148 File Offset: 0x007B8348
		public bool CHO9CnvTopFunctionButtonLabelLine1_A36626_HasDiffs
		{
			get
			{
				short num = (short)744063694;
				short num2 = num;
				num = (short)849838798;
				switch (num2 == num)
				{
				}
				num = (short)194904064;
				if (num != 0)
				{
				}
				num = (short)1196883968;
				short num3 = num;
				num = (short)1505427457;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine1_A36626._HasDiffs;
			}
		}

		// Token: 0x170043C1 RID: 17345
		// (get) Token: 0x06008533 RID: 34099 RVA: 0x007BA1FC File Offset: 0x007B83FC
		// (set) Token: 0x06008534 RID: 34100 RVA: 0x007BA2B0 File Offset: 0x007B84B0
		public string CHO9CnvTopFunctionButtonLabelLine2_A36627Value
		{
			get
			{
				short num = (short)1680401559;
				short num2 = num;
				num = (short)2087773335;
				switch (num2 == num)
				{
				}
				num = (short)2107637761;
				if (num != 0)
				{
				}
				num = (short)1707474944;
				short num3 = num;
				num = (short)898367488;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine2_A36627.Value;
			}
			set
			{
				short num = (short)2117356047;
				short num2 = num;
				num = (short)1949780495;
				switch (num2 == num)
				{
				}
				num = (short)208666624;
				if (num != 0)
				{
				}
				num = (short)677773312;
				short num3 = num;
				num = (short)1130364929;
				if (num != 0)
				{
				}
				this.cHO9CnvTopFunctionButtonLabelLine2_A36627.Value = value;
			}
		}

		// Token: 0x170043C2 RID: 17346
		// (get) Token: 0x06008535 RID: 34101 RVA: 0x007BA364 File Offset: 0x007B8564
		public global::AcpBusinessLayer.AcpField<string> CHO9CnvTopFunctionButtonLabelLine2_A36627
		{
			get
			{
				short num = (short)779091969;
				if (num != 0)
				{
				}
				num = (short)2071697177;
				short num2 = num;
				num = (short)1703384857;
				switch (num2 == num)
				{
				}
				num = (short)651755520;
				short num3 = num;
				num = (short)1552023552;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine2_A36627;
			}
		}

		// Token: 0x170043C3 RID: 17347
		// (get) Token: 0x06008536 RID: 34102 RVA: 0x007BA414 File Offset: 0x007B8614
		// (set) Token: 0x06008537 RID: 34103 RVA: 0x007BA4CC File Offset: 0x007B86CC
		public string CHO9CnvTopFunctionButtonLabelLine2_A36627_UIValue
		{
			get
			{
				short num = (short)27137492;
				short num2 = num;
				num = (short)1429018068;
				switch (num2 == num)
				{
				}
				num = (short)1339949056;
				if (num != 0)
				{
				}
				num = (short)236912640;
				short num3 = num;
				num = (short)1019740161;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine2_A36627.Value;
			}
			set
			{
				short num = (short)672805898;
				short num2 = num;
				num = (short)1216623626;
				switch (num2 == num)
				{
				}
				num = (short)907608065;
				if (num != 0)
				{
				}
				num = (short)406978560;
				short num3 = num;
				num = (short)1868496896;
				if (num != 0)
				{
				}
				this.cHO9CnvTopFunctionButtonLabelLine2_A36627.Value = value;
			}
		}

		// Token: 0x170043C4 RID: 17348
		// (get) Token: 0x06008538 RID: 34104 RVA: 0x007BA584 File Offset: 0x007B8784
		// (set) Token: 0x06008539 RID: 34105 RVA: 0x007BA634 File Offset: 0x007B8834
		public bool CHO9CnvTopFunctionButtonLabelLine2_A36627_Applicable
		{
			get
			{
				short num = (short)358219089;
				short num2 = num;
				num = (short)468450641;
				switch (num2 == num)
				{
				}
				num = (short)657522689;
				if (num != 0)
				{
				}
				num = (short)983629824;
				short num3 = num;
				num = (short)1757413376;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine2_A36627.Applicable;
			}
			set
			{
				short num = (short)1281925314;
				short num2 = num;
				num = (short)328835266;
				switch (num2 == num)
				{
				}
				num = (short)1277886465;
				if (num != 0)
				{
				}
				num = (short)1645871104;
				short num3 = num;
				num = (short)909574144;
				if (num != 0)
				{
				}
				this.cHO9CnvTopFunctionButtonLabelLine2_A36627.Applicable = value;
			}
		}

		// Token: 0x170043C5 RID: 17349
		// (get) Token: 0x0600853A RID: 34106 RVA: 0x007BA6EC File Offset: 0x007B88EC
		// (set) Token: 0x0600853B RID: 34107 RVA: 0x007BA7A4 File Offset: 0x007B89A4
		public bool CHO9CnvTopFunctionButtonLabelLine2_A36627_Valid
		{
			get
			{
				short num = (short)1788450259;
				short num2 = num;
				num = (short)769824211;
				switch (num2 == num)
				{
				}
				num = (short)1421279233;
				if (num != 0)
				{
				}
				num = (short)1267859456;
				short num3 = num;
				num = (short)1168769024;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine2_A36627.Valid;
			}
			set
			{
				short num = (short)1661936442;
				short num2 = num;
				num = (short)1353327418;
				switch (num2 == num)
				{
				}
				num = (short)1230176257;
				if (num != 0)
				{
				}
				num = (short)1427570688;
				short num3 = num;
				num = (short)1633812480;
				if (num != 0)
				{
				}
				this.cHO9CnvTopFunctionButtonLabelLine2_A36627.Valid = value;
			}
		}

		// Token: 0x170043C6 RID: 17350
		// (get) Token: 0x0600853C RID: 34108 RVA: 0x007BA85C File Offset: 0x007B8A5C
		// (set) Token: 0x0600853D RID: 34109 RVA: 0x007BA910 File Offset: 0x007B8B10
		public bool CHO9CnvTopFunctionButtonLabelLine2_A36627_Visible
		{
			get
			{
				short num = (short)239056982;
				short num2 = num;
				num = (short)884586582;
				switch (num2 == num)
				{
				}
				num = (short)1551040513;
				if (num != 0)
				{
				}
				num = (short)907411456;
				short num3 = num;
				num = (short)795344896;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine2_A36627.Visible;
			}
			set
			{
				short num = (short)1927854844;
				short num2 = num;
				num = (short)338344700;
				switch (num2 == num)
				{
				}
				num = (short)783482880;
				if (num != 0)
				{
				}
				num = (short)1692991488;
				short num3 = num;
				num = (short)1967587329;
				if (num != 0)
				{
				}
				this.cHO9CnvTopFunctionButtonLabelLine2_A36627.Visible = value;
			}
		}

		// Token: 0x170043C7 RID: 17351
		// (get) Token: 0x0600853E RID: 34110 RVA: 0x007BA9C4 File Offset: 0x007B8BC4
		// (set) Token: 0x0600853F RID: 34111 RVA: 0x007BAA7C File Offset: 0x007B8C7C
		public bool CHO9CnvTopFunctionButtonLabelLine2_A36627_Editable
		{
			get
			{
				short num = (short)843060694;
				short num2 = num;
				num = (short)1536497110;
				switch (num2 == num)
				{
				}
				num = (short)145489921;
				if (num != 0)
				{
				}
				num = (short)104398848;
				short num3 = num;
				num = (short)1281425408;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine2_A36627.Editable;
			}
			set
			{
				short num = (short)696778753;
				if (num != 0)
				{
				}
				num = (short)162809865;
				short num2 = num;
				num = (short)971327497;
				switch (num2 == num)
				{
				}
				num = (short)825360384;
				short num3 = num;
				num = (short)368967680;
				if (num != 0)
				{
				}
				this.cHO9CnvTopFunctionButtonLabelLine2_A36627.Editable = value;
			}
		}

		// Token: 0x170043C8 RID: 17352
		// (get) Token: 0x06008540 RID: 34112 RVA: 0x007BAB30 File Offset: 0x007B8D30
		internal string CHO9CnvTopFunctionButtonLabelLine2_A36627_UILabel
		{
			get
			{
				short num = (short)485752833;
				if (num != 0)
				{
				}
				num = (short)659213393;
				short num2 = num;
				num = (short)2085211217;
				switch (num2 == num)
				{
				}
				num = (short)1749942272;
				short num3 = num;
				num = (short)1694760960;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine2_A36627.UIName;
			}
		}

		// Token: 0x170043C9 RID: 17353
		// (get) Token: 0x06008541 RID: 34113 RVA: 0x007BABE8 File Offset: 0x007B8DE8
		// (set) Token: 0x06008542 RID: 34114 RVA: 0x007BACA0 File Offset: 0x007B8EA0
		internal bool CHO9CnvTopFunctionButtonLabelLine2_A36627_HiddenStatic
		{
			get
			{
				short num = (short)663289857;
				if (num != 0)
				{
				}
				num = (short)278750531;
				short num2 = num;
				num = (short)2001560899;
				switch (num2 == num)
				{
				}
				num = (short)1434976256;
				short num3 = num;
				num = (short)691994624;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine2_A36627.HiddenStatic;
			}
			set
			{
				short num = (short)1664476851;
				short num2 = num;
				num = (short)1981408947;
				switch (num2 == num)
				{
				}
				num = (short)331874305;
				if (num != 0)
				{
				}
				num = (short)1750859776;
				short num3 = num;
				num = (short)1898184704;
				if (num != 0)
				{
				}
				this.cHO9CnvTopFunctionButtonLabelLine2_A36627.HiddenStatic = value;
			}
		}

		// Token: 0x170043CA RID: 17354
		// (get) Token: 0x06008543 RID: 34115 RVA: 0x007BAD58 File Offset: 0x007B8F58
		// (set) Token: 0x06008544 RID: 34116 RVA: 0x007BAE10 File Offset: 0x007B9010
		internal bool CHO9CnvTopFunctionButtonLabelLine2_A36627_HiddenDynamic
		{
			get
			{
				short num = (short)50789027;
				short num2 = num;
				num = (short)1539898019;
				switch (num2 == num)
				{
				}
				num = (short)585826304;
				if (num != 0)
				{
				}
				num = (short)10420224;
				short num3 = num;
				num = (short)440074241;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine2_A36627.HiddenDynamic;
			}
			set
			{
				short num = (short)1497890817;
				if (num != 0)
				{
				}
				num = (short)1667453293;
				short num2 = num;
				num = (short)1150570861;
				switch (num2 == num)
				{
				}
				num = (short)496041984;
				short num3 = num;
				num = (short)1986134016;
				if (num != 0)
				{
				}
				this.cHO9CnvTopFunctionButtonLabelLine2_A36627.HiddenDynamic = value;
			}
		}

		// Token: 0x170043CB RID: 17355
		// (get) Token: 0x06008545 RID: 34117 RVA: 0x007BAEC8 File Offset: 0x007B90C8
		public bool CHO9CnvTopFunctionButtonLabelLine2_A36627_HasDiffs
		{
			get
			{
				short num = (short)245845800;
				short num2 = num;
				num = (short)1686720296;
				switch (num2 == num)
				{
				}
				num = (short)643235841;
				if (num != 0)
				{
				}
				num = (short)914489344;
				short num3 = num;
				num = (short)937361408;
				if (num != 0)
				{
				}
				return this.cHO9CnvTopFunctionButtonLabelLine2_A36627._HasDiffs;
			}
		}

		// Token: 0x170043CC RID: 17356
		// (get) Token: 0x06008546 RID: 34118 RVA: 0x007BAF7C File Offset: 0x007B917C
		// (set) Token: 0x06008547 RID: 34119 RVA: 0x007BB034 File Offset: 0x007B9234
		public int CnvTopFunctionButtonBCO_A36628Value
		{
			get
			{
				short num = (short)620564010;
				short num2 = num;
				num = (short)183111210;
				switch (num2 == num)
				{
				}
				num = (short)1679687681;
				if (num != 0)
				{
				}
				num = (short)890503168;
				short num3 = num;
				num = (short)86441984;
				if (num != 0)
				{
				}
				return this.cnvTopFunctionButtonBCO_A36628.Value;
			}
			set
			{
				short num = (short)161241601;
				short num2 = num;
				num = (short)1593072129;
				switch (num2 == num)
				{
				}
				num = (short)2020868096;
				if (num != 0)
				{
				}
				num = (short)14483456;
				short num3 = num;
				num = (short)1272578049;
				if (num != 0)
				{
				}
				this.cnvTopFunctionButtonBCO_A36628.Value = value;
			}
		}

		// Token: 0x170043CD RID: 17357
		// (get) Token: 0x06008548 RID: 34120 RVA: 0x007BB0EC File Offset: 0x007B92EC
		// (set) Token: 0x06008549 RID: 34121 RVA: 0x007BB1A0 File Offset: 0x007B93A0
		public string CnvTopFunctionButtonBCO_A36628_UIValue
		{
			get
			{
				short num = (short)2012313462;
				short num2 = num;
				num = (short)879785846;
				switch (num2 == num)
				{
				}
				num = (short)9830400;
				if (num != 0)
				{
				}
				num = (short)553320448;
				short num3 = num;
				num = (short)1579286529;
				if (num != 0)
				{
				}
				return this.cnvTopFunctionButtonBCO_A36628.UIValue;
			}
			set
			{
				short num = (short)1573114710;
				short num2 = num;
				num = (short)1516426070;
				switch (num2 == num)
				{
				}
				num = (short)638844928;
				if (num != 0)
				{
				}
				num = (short)1582563328;
				short num3 = num;
				num = (short)745144321;
				if (num != 0)
				{
				}
				this.cnvTopFunctionButtonBCO_A36628.UIValue = value;
			}
		}

		// Token: 0x170043CE RID: 17358
		// (get) Token: 0x0600854A RID: 34122 RVA: 0x007BB254 File Offset: 0x007B9454
		public global::AcpBusinessLayer.AcpListField CnvTopFunctionButtonBCO_A36628
		{
			get
			{
				short num = (short)32202995;
				short num2 = num;
				num = (short)25846003;
				switch (num2 == num)
				{
				}
				num = (short)1560477696;
				if (num != 0)
				{
				}
				num = (short)493092864;
				short num3 = num;
				num = (short)834338817;
				if (num != 0)
				{
				}
				return this.cnvTopFunctionButtonBCO_A36628;
			}
		}

		// Token: 0x170043CF RID: 17359
		// (get) Token: 0x0600854B RID: 34123 RVA: 0x007BB304 File Offset: 0x007B9504
		// (set) Token: 0x0600854C RID: 34124 RVA: 0x007BB3B8 File Offset: 0x007B95B8
		public bool CnvTopFunctionButtonBCO_A36628_Applicable
		{
			get
			{
				short num = (short)908692806;
				short num2 = num;
				num = (short)1711639878;
				switch (num2 == num)
				{
				}
				num = (short)1282015232;
				if (num != 0)
				{
				}
				num = (short)1214971904;
				short num3 = num;
				num = (short)1092550657;
				if (num != 0)
				{
				}
				return this.cnvTopFunctionButtonBCO_A36628.Applicable;
			}
			set
			{
				short num = (short)1306537620;
				short num2 = num;
				num = (short)963260052;
				switch (num2 == num)
				{
				}
				num = (short)2091515905;
				if (num != 0)
				{
				}
				num = (short)1952841728;
				short num3 = num;
				num = (short)1312882688;
				if (num != 0)
				{
				}
				this.cnvTopFunctionButtonBCO_A36628.Applicable = value;
			}
		}

		// Token: 0x170043D0 RID: 17360
		// (get) Token: 0x0600854D RID: 34125 RVA: 0x007BB470 File Offset: 0x007B9670
		// (set) Token: 0x0600854E RID: 34126 RVA: 0x007BB528 File Offset: 0x007B9728
		public bool CnvTopFunctionButtonBCO_A36628_Valid
		{
			get
			{
				short num = (short)87746900;
				short num2 = num;
				num = (short)1509353812;
				switch (num2 == num)
				{
				}
				num = (short)113246209;
				if (num != 0)
				{
				}
				num = (short)285409280;
				short num3 = num;
				num = (short)825950208;
				if (num != 0)
				{
				}
				return this.cnvTopFunctionButtonBCO_A36628.Valid;
			}
			set
			{
				short num = (short)1783487404;
				short num2 = num;
				num = (short)1631968172;
				switch (num2 == num)
				{
				}
				num = (short)1004994561;
				if (num != 0)
				{
				}
				num = (short)1026162688;
				short num3 = num;
				num = (short)1593573376;
				if (num != 0)
				{
				}
				this.cnvTopFunctionButtonBCO_A36628.Valid = value;
			}
		}

		// Token: 0x170043D1 RID: 17361
		// (get) Token: 0x0600854F RID: 34127 RVA: 0x007BB5DC File Offset: 0x007B97DC
		// (set) Token: 0x06008550 RID: 34128 RVA: 0x007BB690 File Offset: 0x007B9890
		public bool CnvTopFunctionButtonBCO_A36628_Visible
		{
			get
			{
				short num = (short)493355009;
				if (num != 0)
				{
				}
				num = (short)1333502807;
				short num2 = num;
				num = (short)649241431;
				switch (num2 == num)
				{
				}
				num = (short)1247150080;
				short num3 = num;
				num = (short)2093088768;
				if (num != 0)
				{
				}
				return this.cnvTopFunctionButtonBCO_A36628.Visible;
			}
			set
			{
				short num = (short)571987935;
				short num2 = num;
				num = (short)987617247;
				switch (num2 == num)
				{
				}
				num = (short)1673461761;
				if (num != 0)
				{
				}
				num = (short)354549760;
				short num3 = num;
				num = (short)653000704;
				if (num != 0)
				{
				}
				this.cnvTopFunctionButtonBCO_A36628.Visible = value;
			}
		}

		// Token: 0x170043D2 RID: 17362
		// (get) Token: 0x06008551 RID: 34129 RVA: 0x007BB744 File Offset: 0x007B9944
		// (set) Token: 0x06008552 RID: 34130 RVA: 0x007BB7F8 File Offset: 0x007B99F8
		public bool CnvTopFunctionButtonBCO_A36628_Editable
		{
			get
			{
				short num = (short)1422248380;
				short num2 = num;
				num = (short)344377788;
				switch (num2 == num)
				{
				}
				num = (short)1317470209;
				if (num != 0)
				{
				}
				num = (short)295501824;
				short num3 = num;
				num = (short)1147731968;
				if (num != 0)
				{
				}
				return this.cnvTopFunctionButtonBCO_A36628.Editable;
			}
			set
			{
				short num = (short)1190002689;
				if (num != 0)
				{
				}
				num = (short)811572905;
				short num2 = num;
				num = (short)1079746217;
				switch (num2 == num)
				{
				}
				num = (short)1419640832;
				short num3 = num;
				num = (short)1472593920;
				if (num != 0)
				{
				}
				this.cnvTopFunctionButtonBCO_A36628.Editable = value;
			}
		}

		// Token: 0x170043D3 RID: 17363
		// (get) Token: 0x06008553 RID: 34131 RVA: 0x007BB8B0 File Offset: 0x007B9AB0
		internal string CnvTopFunctionButtonBCO_A36628_UILabel
		{
			get
			{
				short num = (short)532881862;
				short num2 = num;
				num = (short)2053120454;
				switch (num2 == num)
				{
				}
				num = (short)1639186433;
				if (num != 0)
				{
				}
				num = (short)855638016;
				short num3 = num;
				num = (short)710868992;
				if (num != 0)
				{
				}
				return this.cnvTopFunctionButtonBCO_A36628.UIName;
			}
		}

		// Token: 0x170043D4 RID: 17364
		// (get) Token: 0x06008554 RID: 34132 RVA: 0x007BB964 File Offset: 0x007B9B64
		// (set) Token: 0x06008555 RID: 34133 RVA: 0x007BBA18 File Offset: 0x007B9C18
		internal bool CnvTopFunctionButtonBCO_A36628_HiddenStatic
		{
			get
			{
				short num = (short)578656363;
				short num2 = num;
				num = (short)752326763;
				switch (num2 == num)
				{
				}
				num = (short)909246465;
				if (num != 0)
				{
				}
				num = (short)503250944;
				short num3 = num;
				num = (short)1739390976;
				if (num != 0)
				{
				}
				return this.cnvTopFunctionButtonBCO_A36628.HiddenStatic;
			}
			set
			{
				short num = (short)1313660536;
				short num2 = num;
				num = (short)290905720;
				switch (num2 == num)
				{
				}
				num = (short)418054145;
				if (num != 0)
				{
				}
				num = (short)1821245440;
				short num3 = num;
				num = (short)1623326720;
				if (num != 0)
				{
				}
				this.cnvTopFunctionButtonBCO_A36628.HiddenStatic = value;
			}
		}

		// Token: 0x170043D5 RID: 17365
		// (get) Token: 0x06008556 RID: 34134 RVA: 0x007BBAD0 File Offset: 0x007B9CD0
		// (set) Token: 0x06008557 RID: 34135 RVA: 0x007BBB84 File Offset: 0x007B9D84
		internal bool CnvTopFunctionButtonBCO_A36628_HiddenDynamic
		{
			get
			{
				short num = (short)1881273190;
				short num2 = num;
				num = (short)430240614;
				switch (num2 == num)
				{
				}
				num = (short)1541079041;
				if (num != 0)
				{
				}
				num = (short)1491402752;
				short num3 = num;
				num = (short)21168128;
				if (num != 0)
				{
				}
				return this.cnvTopFunctionButtonBCO_A36628.HiddenDynamic;
			}
			set
			{
				short num = (short)528152327;
				short num2 = num;
				num = (short)755365639;
				switch (num2 == num)
				{
				}
				num = (short)1047199745;
				if (num != 0)
				{
				}
				num = (short)357629952;
				short num3 = num;
				num = (short)285671424;
				if (num != 0)
				{
				}
				this.cnvTopFunctionButtonBCO_A36628.HiddenDynamic = value;
			}
		}

		// Token: 0x170043D6 RID: 17366
		// (get) Token: 0x06008558 RID: 34136 RVA: 0x007BBC3C File Offset: 0x007B9E3C
		public bool CnvTopFunctionButtonBCO_A36628_HasDiffs
		{
			get
			{
				short num = (short)1655496878;
				short num2 = num;
				num = (short)578412718;
				switch (num2 == num)
				{
				}
				num = (short)1784283137;
				if (num != 0)
				{
				}
				num = (short)1168310272;
				short num3 = num;
				num = (short)1906376704;
				if (num != 0)
				{
				}
				return this.cnvTopFunctionButtonBCO_A36628._HasDiffs;
			}
		}

		// Token: 0x170043D7 RID: 17367
		// (get) Token: 0x06008559 RID: 34137 RVA: 0x007BBCF0 File Offset: 0x007B9EF0
		// (set) Token: 0x0600855A RID: 34138 RVA: 0x007BBDA4 File Offset: 0x007B9FA4
		public int O9CHCnvTopFunctionButtonIndex_A36634Value
		{
			get
			{
				short num = (short)901424913;
				short num2 = num;
				num = (short)919447313;
				switch (num2 == num)
				{
				}
				num = (short)1654980609;
				if (num != 0)
				{
				}
				num = (short)1271463936;
				short num3 = num;
				num = (short)381419520;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonIndex_A36634.Value;
			}
			set
			{
				short num = (short)1593567846;
				short num2 = num;
				num = (short)1241836134;
				switch (num2 == num)
				{
				}
				num = (short)323485696;
				if (num != 0)
				{
				}
				num = (short)979304448;
				short num3 = num;
				num = (short)876675073;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonIndex_A36634.Value = value;
			}
		}

		// Token: 0x170043D8 RID: 17368
		// (get) Token: 0x0600855B RID: 34139 RVA: 0x007BBE58 File Offset: 0x007BA058
		// (set) Token: 0x0600855C RID: 34140 RVA: 0x007BBF0C File Offset: 0x007BA10C
		public string O9CHCnvTopFunctionButtonIndex_A36634_UIValue
		{
			get
			{
				short num = (short)1802272785;
				short num2 = num;
				num = (short)1378451473;
				switch (num2 == num)
				{
				}
				num = (short)1431896065;
				if (num != 0)
				{
				}
				num = (short)3407872;
				short num3 = num;
				num = (short)713490432;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonIndex_A36634.UIValue;
			}
			set
			{
				short num = (short)1853334018;
				short num2 = num;
				num = (short)94544386;
				switch (num2 == num)
				{
				}
				num = (short)1530789888;
				if (num != 0)
				{
				}
				num = (short)1001324544;
				short num3 = num;
				num = (short)632160257;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonIndex_A36634.UIValue = value;
			}
		}

		// Token: 0x170043D9 RID: 17369
		// (get) Token: 0x0600855D RID: 34141 RVA: 0x007BBFC0 File Offset: 0x007BA1C0
		public global::AcpBusinessLayer.AcpRecRefField O9CHCnvTopFunctionButtonIndex_A36634
		{
			get
			{
				short num = (short)1184520441;
				short num2 = num;
				num = (short)676878585;
				switch (num2 == num)
				{
				}
				num = (short)741408769;
				if (num != 0)
				{
				}
				num = (short)300089344;
				short num3 = num;
				num = (short)425984000;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonIndex_A36634;
			}
		}

		// Token: 0x170043DA RID: 17370
		// (get) Token: 0x0600855E RID: 34142 RVA: 0x007BC070 File Offset: 0x007BA270
		// (set) Token: 0x0600855F RID: 34143 RVA: 0x007BC124 File Offset: 0x007BA324
		public bool O9CHCnvTopFunctionButtonIndex_A36634_Applicable
		{
			get
			{
				short num = (short)918557303;
				short num2 = num;
				num = (short)981078647;
				switch (num2 == num)
				{
				}
				num = (short)635764737;
				if (num != 0)
				{
				}
				num = (short)839319552;
				short num3 = num;
				num = (short)509673472;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonIndex_A36634.Applicable;
			}
			set
			{
				short num = (short)635692532;
				short num2 = num;
				num = (short)1080813044;
				switch (num2 == num)
				{
				}
				num = (short)2106261505;
				if (num != 0)
				{
				}
				num = (short)1203568640;
				short num3 = num;
				num = (short)1500577792;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonIndex_A36634.Applicable = value;
			}
		}

		// Token: 0x170043DB RID: 17371
		// (get) Token: 0x06008560 RID: 34144 RVA: 0x007BC1DC File Offset: 0x007BA3DC
		// (set) Token: 0x06008561 RID: 34145 RVA: 0x007BC290 File Offset: 0x007BA490
		public bool O9CHCnvTopFunctionButtonIndex_A36634_Valid
		{
			get
			{
				short num = (short)402591102;
				short num2 = num;
				num = (short)496569726;
				switch (num2 == num)
				{
				}
				num = (short)748617729;
				if (num != 0)
				{
				}
				num = (short)1162018816;
				short num3 = num;
				num = (short)1880817664;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonIndex_A36634.Valid;
			}
			set
			{
				short num = (short)1759118162;
				short num2 = num;
				num = (short)1070269266;
				switch (num2 == num)
				{
				}
				num = (short)372506624;
				short num3 = num;
				num = (short)249888769;
				if (num != 0)
				{
				}
				num = (short)175636480;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonIndex_A36634.Valid = value;
			}
		}

		// Token: 0x170043DC RID: 17372
		// (get) Token: 0x06008562 RID: 34146 RVA: 0x007BC344 File Offset: 0x007BA544
		// (set) Token: 0x06008563 RID: 34147 RVA: 0x007BC3FC File Offset: 0x007BA5FC
		public bool O9CHCnvTopFunctionButtonIndex_A36634_Visible
		{
			get
			{
				short num = (short)2055479097;
				short num2 = num;
				num = (short)1188962105;
				switch (num2 == num)
				{
				}
				num = (short)92012544;
				short num3 = num;
				num = (short)1982267392;
				if (num != 0)
				{
				}
				num = (short)1213464577;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonIndex_A36634.Visible;
			}
			set
			{
				short num = (short)1374963811;
				short num2 = num;
				num = (short)195184739;
				switch (num2 == num)
				{
				}
				num = (short)1777926144;
				short num3 = num;
				num = (short)1898577921;
				if (num != 0)
				{
				}
				num = (short)1343094784;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonIndex_A36634.Visible = value;
			}
		}

		// Token: 0x170043DD RID: 17373
		// (get) Token: 0x06008564 RID: 34148 RVA: 0x007BC4B0 File Offset: 0x007BA6B0
		// (set) Token: 0x06008565 RID: 34149 RVA: 0x007BC568 File Offset: 0x007BA768
		public bool O9CHCnvTopFunctionButtonIndex_A36634_Editable
		{
			get
			{
				short num = (short)1067003694;
				short num2 = num;
				num = (short)670838574;
				switch (num2 == num)
				{
				}
				num = (short)1886846976;
				short num3 = num;
				num = (short)612106241;
				if (num != 0)
				{
				}
				num = (short)1389690880;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonIndex_A36634.Editable;
			}
			set
			{
				short num = (short)1079983988;
				short num2 = num;
				num = (short)368394100;
				switch (num2 == num)
				{
				}
				num = (short)2067005440;
				short num3 = num;
				num = (short)337707008;
				if (num != 0)
				{
				}
				num = (short)992280577;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonIndex_A36634.Editable = value;
			}
		}

		// Token: 0x170043DE RID: 17374
		// (get) Token: 0x06008566 RID: 34150 RVA: 0x007BC620 File Offset: 0x007BA820
		internal string O9CHCnvTopFunctionButtonIndex_A36634_UILabel
		{
			get
			{
				short num = (short)273678337;
				if (num != 0)
				{
				}
				num = (short)508861238;
				short num2 = num;
				num = (short)1420598070;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2026962944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1808072704;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonIndex_A36634.UIName;
			}
		}

		// Token: 0x170043DF RID: 17375
		// (get) Token: 0x06008567 RID: 34151 RVA: 0x007BC6D4 File Offset: 0x007BA8D4
		// (set) Token: 0x06008568 RID: 34152 RVA: 0x007BC788 File Offset: 0x007BA988
		internal bool O9CHCnvTopFunctionButtonIndex_A36634_HiddenStatic
		{
			get
			{
				short num = (short)655519404;
				short num2 = num;
				num = (short)458387116;
				switch (num2 == num)
				{
				}
				num = (short)587202560;
				short num3 = num;
				num = (short)1637744641;
				if (num != 0)
				{
				}
				num = (short)2058027008;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonIndex_A36634.HiddenStatic;
			}
			set
			{
				short num = (short)1866815563;
				short num2 = num;
				num = (short)711481419;
				switch (num2 == num)
				{
				}
				num = (short)24838144;
				short num3 = num;
				num = (short)55836672;
				if (num != 0)
				{
				}
				num = (short)553385985;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonIndex_A36634.HiddenStatic = value;
			}
		}

		// Token: 0x170043E0 RID: 17376
		// (get) Token: 0x06008569 RID: 34153 RVA: 0x007BC83C File Offset: 0x007BAA3C
		// (set) Token: 0x0600856A RID: 34154 RVA: 0x007BC8F0 File Offset: 0x007BAAF0
		internal bool O9CHCnvTopFunctionButtonIndex_A36634_HiddenDynamic
		{
			get
			{
				short num = (short)421144781;
				short num2 = num;
				num = (short)841492685;
				switch (num2 == num)
				{
				}
				num = (short)958857216;
				short num3 = num;
				num = (short)1008271360;
				if (num != 0)
				{
				}
				num = (short)1625358337;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonIndex_A36634.HiddenDynamic;
			}
			set
			{
				short num = (short)519073057;
				short num2 = num;
				num = (short)1664183585;
				switch (num2 == num)
				{
				}
				num = (short)1362624512;
				short num3 = num;
				num = (short)2069364736;
				if (num != 0)
				{
				}
				num = (short)1051590657;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonIndex_A36634.HiddenDynamic = value;
			}
		}

		// Token: 0x170043E1 RID: 17377
		// (get) Token: 0x0600856B RID: 34155 RVA: 0x007BC9A8 File Offset: 0x007BABA8
		public bool O9CHCnvTopFunctionButtonIndex_A36634_HasDiffs
		{
			get
			{
				short num = (short)164460217;
				short num2 = num;
				num = (short)1842050745;
				switch (num2 == num)
				{
				}
				num = (short)1751908352;
				short num3 = num;
				num = (short)286785536;
				if (num != 0)
				{
				}
				num = (short)1255866369;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonIndex_A36634._HasDiffs;
			}
		}

		// Token: 0x170043E2 RID: 17378
		// (get) Token: 0x0600856C RID: 34156 RVA: 0x007BCA58 File Offset: 0x007BAC58
		// (set) Token: 0x0600856D RID: 34157 RVA: 0x007BCB0C File Offset: 0x007BAD0C
		public int O9CHTrkTopFunctionButtonBCO_A36636Value
		{
			get
			{
				short num = (short)241645094;
				short num2 = num;
				num = (short)1487943206;
				switch (num2 == num)
				{
				}
				num = (short)1226899456;
				short num3 = num;
				num = (short)2120613889;
				if (num != 0)
				{
				}
				num = (short)1205993472;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonBCO_A36636.Value;
			}
			set
			{
				short num = (short)712149134;
				short num2 = num;
				num = (short)680167566;
				switch (num2 == num)
				{
				}
				num = (short)356581376;
				short num3 = num;
				num = (short)318242816;
				if (num != 0)
				{
				}
				num = (short)538050561;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonBCO_A36636.Value = value;
			}
		}

		// Token: 0x170043E3 RID: 17379
		// (get) Token: 0x0600856E RID: 34158 RVA: 0x007BCBC0 File Offset: 0x007BADC0
		// (set) Token: 0x0600856F RID: 34159 RVA: 0x007BCC74 File Offset: 0x007BAE74
		public string O9CHTrkTopFunctionButtonBCO_A36636_UIValue
		{
			get
			{
				short num = (short)1308296566;
				short num2 = num;
				num = (short)2032272758;
				switch (num2 == num)
				{
				}
				num = (short)1263337472;
				short num3 = num;
				num = (short)933494784;
				if (num != 0)
				{
				}
				num = (short)1317011457;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonBCO_A36636.UIValue;
			}
			set
			{
				short num = (short)1925321724;
				short num2 = num;
				num = (short)1278743548;
				switch (num2 == num)
				{
				}
				num = (short)2079391744;
				short num3 = num;
				num = (short)1510080513;
				if (num != 0)
				{
				}
				num = (short)678035456;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonBCO_A36636.UIValue = value;
			}
		}

		// Token: 0x170043E4 RID: 17380
		// (get) Token: 0x06008570 RID: 34160 RVA: 0x007BCD2C File Offset: 0x007BAF2C
		public global::AcpBusinessLayer.AcpListField O9CHTrkTopFunctionButtonBCO_A36636
		{
			get
			{
				short num = (short)1985594646;
				short num2 = num;
				num = (short)69190934;
				switch (num2 == num)
				{
				}
				num = (short)1274150912;
				short num3 = num;
				num = (short)515637249;
				if (num != 0)
				{
				}
				num = (short)1232076800;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonBCO_A36636;
			}
		}

		// Token: 0x170043E5 RID: 17381
		// (get) Token: 0x06008571 RID: 34161 RVA: 0x007BCDD8 File Offset: 0x007BAFD8
		// (set) Token: 0x06008572 RID: 34162 RVA: 0x007BCE90 File Offset: 0x007BB090
		public bool O9CHTrkTopFunctionButtonBCO_A36636_Applicable
		{
			get
			{
				short num = (short)1872097916;
				short num2 = num;
				num = (short)1163719292;
				switch (num2 == num)
				{
				}
				num = (short)388890624;
				short num3 = num;
				num = (short)685637633;
				if (num != 0)
				{
				}
				num = (short)374407168;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonBCO_A36636.Applicable;
			}
			set
			{
				short num = (short)1190658049;
				if (num != 0)
				{
				}
				num = (short)1889880922;
				short num2 = num;
				num = (short)39144282;
				switch (num2 == num)
				{
				default:
				{
					num = (short)119078912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1951465472;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonBCO_A36636.Applicable = value;
			}
		}

		// Token: 0x170043E6 RID: 17382
		// (get) Token: 0x06008573 RID: 34163 RVA: 0x007BCF48 File Offset: 0x007BB148
		// (set) Token: 0x06008574 RID: 34164 RVA: 0x007BCFFC File Offset: 0x007BB1FC
		public bool O9CHTrkTopFunctionButtonBCO_A36636_Valid
		{
			get
			{
				short num = (short)38268570;
				short num2 = num;
				num = (short)1822551706;
				switch (num2 == num)
				{
				}
				num = (short)1473445888;
				short num3 = num;
				num = (short)800063488;
				if (num != 0)
				{
				}
				num = (short)2103574529;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonBCO_A36636.Valid;
			}
			set
			{
				short num = (short)1896881235;
				short num2 = num;
				num = (short)1494686803;
				switch (num2 == num)
				{
				}
				num = (short)981532672;
				short num3 = num;
				num = (short)568066048;
				if (num != 0)
				{
				}
				num = (short)570359809;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonBCO_A36636.Valid = value;
			}
		}

		// Token: 0x170043E7 RID: 17383
		// (get) Token: 0x06008575 RID: 34165 RVA: 0x007BD0B4 File Offset: 0x007BB2B4
		// (set) Token: 0x06008576 RID: 34166 RVA: 0x007BD168 File Offset: 0x007BB368
		public bool O9CHTrkTopFunctionButtonBCO_A36636_Visible
		{
			get
			{
				short num = (short)1615262735;
				short num2 = num;
				num = (short)322761743;
				switch (num2 == num)
				{
				}
				num = (short)1122697216;
				short num3 = num;
				num = (short)2131230720;
				if (num != 0)
				{
				}
				num = (short)1825243137;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonBCO_A36636.Visible;
			}
			set
			{
				short num = (short)1216589726;
				short num2 = num;
				num = (short)388411294;
				switch (num2 == num)
				{
				}
				num = (short)1019281408;
				short num3 = num;
				num = (short)1070596096;
				if (num != 0)
				{
				}
				num = (short)467468289;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonBCO_A36636.Visible = value;
			}
		}

		// Token: 0x170043E8 RID: 17384
		// (get) Token: 0x06008577 RID: 34167 RVA: 0x007BD21C File Offset: 0x007BB41C
		// (set) Token: 0x06008578 RID: 34168 RVA: 0x007BD2D0 File Offset: 0x007BB4D0
		public bool O9CHTrkTopFunctionButtonBCO_A36636_Editable
		{
			get
			{
				short num = (short)726265305;
				short num2 = num;
				num = (short)1929702873;
				switch (num2 == num)
				{
				}
				num = (short)123928576;
				short num3 = num;
				num = (short)2125856768;
				if (num != 0)
				{
				}
				num = (short)1186398209;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonBCO_A36636.Editable;
			}
			set
			{
				short num = (short)632582621;
				short num2 = num;
				num = (short)1466266077;
				switch (num2 == num)
				{
				}
				num = (short)1306066944;
				short num3 = num;
				num = (short)1956773888;
				if (num != 0)
				{
				}
				num = (short)1632698369;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonBCO_A36636.Editable = value;
			}
		}

		// Token: 0x170043E9 RID: 17385
		// (get) Token: 0x06008579 RID: 34169 RVA: 0x007BD384 File Offset: 0x007BB584
		internal string O9CHTrkTopFunctionButtonBCO_A36636_UILabel
		{
			get
			{
				short num = (short)813428652;
				short num2 = num;
				num = (short)1486024620;
				switch (num2 == num)
				{
				}
				num = (short)448724992;
				short num3 = num;
				num = (short)2029649921;
				if (num != 0)
				{
				}
				num = (short)469827584;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonBCO_A36636.UIName;
			}
		}

		// Token: 0x170043EA RID: 17386
		// (get) Token: 0x0600857A RID: 34170 RVA: 0x007BD438 File Offset: 0x007BB638
		// (set) Token: 0x0600857B RID: 34171 RVA: 0x007BD4EC File Offset: 0x007BB6EC
		internal bool O9CHTrkTopFunctionButtonBCO_A36636_HiddenStatic
		{
			get
			{
				short num = (short)987765237;
				short num2 = num;
				num = (short)728504821;
				switch (num2 == num)
				{
				}
				num = (short)1859452928;
				short num3 = num;
				num = (short)264699905;
				if (num != 0)
				{
				}
				num = (short)469630976;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonBCO_A36636.HiddenStatic;
			}
			set
			{
				short num = (short)1379445339;
				short num2 = num;
				num = (short)589539931;
				switch (num2 == num)
				{
				}
				num = (short)1727070208;
				short num3 = num;
				num = (short)842399745;
				if (num != 0)
				{
				}
				num = (short)546897920;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonBCO_A36636.HiddenStatic = value;
			}
		}

		// Token: 0x170043EB RID: 17387
		// (get) Token: 0x0600857C RID: 34172 RVA: 0x007BD5A4 File Offset: 0x007BB7A4
		// (set) Token: 0x0600857D RID: 34173 RVA: 0x007BD658 File Offset: 0x007BB858
		internal bool O9CHTrkTopFunctionButtonBCO_A36636_HiddenDynamic
		{
			get
			{
				short num = (short)843801793;
				short num2 = num;
				num = (short)833184961;
				switch (num2 == num)
				{
				}
				num = (short)1805254656;
				short num3 = num;
				num = (short)1151991808;
				if (num != 0)
				{
				}
				num = (short)2131492865;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonBCO_A36636.HiddenDynamic;
			}
			set
			{
				short num = (short)587071489;
				if (num != 0)
				{
				}
				num = (short)1909952025;
				short num2 = num;
				num = (short)603688473;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1371865088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)193789952;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonBCO_A36636.HiddenDynamic = value;
			}
		}

		// Token: 0x170043EC RID: 17388
		// (get) Token: 0x0600857E RID: 34174 RVA: 0x007BD710 File Offset: 0x007BB910
		public bool O9CHTrkTopFunctionButtonBCO_A36636_HasDiffs
		{
			get
			{
				short num = (short)649134081;
				if (num != 0)
				{
				}
				num = (short)375371774;
				short num2 = num;
				num = (short)2045491198;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1998782464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)242614272;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonBCO_A36636._HasDiffs;
			}
		}

		// Token: 0x170043ED RID: 17389
		// (get) Token: 0x0600857F RID: 34175 RVA: 0x007BD7C8 File Offset: 0x007BB9C8
		// (set) Token: 0x06008580 RID: 34176 RVA: 0x007BD880 File Offset: 0x007BBA80
		public int O9CHTrkTopFunctionButtonIndex_A36639Value
		{
			get
			{
				short num = (short)516890236;
				short num2 = num;
				num = (short)1982668412;
				switch (num2 == num)
				{
				}
				num = (short)950009856;
				short num3 = num;
				num = (short)617938945;
				if (num != 0)
				{
				}
				num = (short)1618018304;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonIndex_A36639.Value;
			}
			set
			{
				short num = (short)1817624798;
				short num2 = num;
				num = (short)1441906910;
				switch (num2 == num)
				{
				}
				num = (short)460259328;
				short num3 = num;
				num = (short)1175715840;
				if (num != 0)
				{
				}
				num = (short)1727528961;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonIndex_A36639.Value = value;
			}
		}

		// Token: 0x170043EE RID: 17390
		// (get) Token: 0x06008581 RID: 34177 RVA: 0x007BD938 File Offset: 0x007BBB38
		public global::AcpBusinessLayer.AcpSimpleRangeField O9CHTrkTopFunctionButtonIndex_A36639
		{
			get
			{
				short num = (short)1990032126;
				short num2 = num;
				num = (short)1741781758;
				switch (num2 == num)
				{
				}
				num = (short)348061696;
				short num3 = num;
				num = (short)1769472001;
				if (num != 0)
				{
				}
				num = (short)563019776;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonIndex_A36639;
			}
		}

		// Token: 0x170043EF RID: 17391
		// (get) Token: 0x06008582 RID: 34178 RVA: 0x007BD9E8 File Offset: 0x007BBBE8
		// (set) Token: 0x06008583 RID: 34179 RVA: 0x007BDA9C File Offset: 0x007BBC9C
		public string O9CHTrkTopFunctionButtonIndex_A36639_UIValue
		{
			get
			{
				short num = (short)1905491911;
				short num2 = num;
				num = (short)1511161799;
				switch (num2 == num)
				{
				}
				num = (short)1948909568;
				short num3 = num;
				num = (short)1519058945;
				if (num != 0)
				{
				}
				num = (short)1310130176;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonIndex_A36639.UIValue;
			}
			set
			{
				short num = (short)1969040193;
				short num2 = num;
				num = (short)58272577;
				switch (num2 == num)
				{
				}
				num = (short)857145344;
				short num3 = num;
				num = (short)87883777;
				if (num != 0)
				{
				}
				num = (short)1521483776;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonIndex_A36639.UIValue = value;
			}
		}

		// Token: 0x170043F0 RID: 17392
		// (get) Token: 0x06008584 RID: 34180 RVA: 0x007BDB50 File Offset: 0x007BBD50
		// (set) Token: 0x06008585 RID: 34181 RVA: 0x007BDC08 File Offset: 0x007BBE08
		internal int O9CHTrkTopFunctionButtonIndex_A36639Min
		{
			get
			{
				short num = (short)2079181339;
				short num2 = num;
				num = (short)1077398043;
				switch (num2 == num)
				{
				}
				num = (short)411697152;
				short num3 = num;
				num = (short)909115393;
				if (num != 0)
				{
				}
				num = (short)721223680;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonIndex_A36639.Min;
			}
			set
			{
				short num = (short)284726088;
				short num2 = num;
				num = (short)415732552;
				switch (num2 == num)
				{
				}
				num = (short)344653824;
				short num3 = num;
				num = (short)1284440064;
				if (num != 0)
				{
				}
				num = (short)42008577;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonIndex_A36639.Min = value;
			}
		}

		// Token: 0x170043F1 RID: 17393
		// (get) Token: 0x06008586 RID: 34182 RVA: 0x007BDCC0 File Offset: 0x007BBEC0
		// (set) Token: 0x06008587 RID: 34183 RVA: 0x007BDD74 File Offset: 0x007BBF74
		internal int O9CHTrkTopFunctionButtonIndex_A36639Max
		{
			get
			{
				short num = (short)1283486761;
				short num2 = num;
				num = (short)1246196777;
				switch (num2 == num)
				{
				}
				num = (short)1796866048;
				short num3 = num;
				num = (short)417071105;
				if (num != 0)
				{
				}
				num = (short)69074944;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonIndex_A36639.Max;
			}
			set
			{
				short num = (short)2024314987;
				short num2 = num;
				num = (short)136222827;
				switch (num2 == num)
				{
				}
				num = (short)1922629632;
				short num3 = num;
				num = (short)1662844929;
				if (num != 0)
				{
				}
				num = (short)319881216;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonIndex_A36639.Max = value;
			}
		}

		// Token: 0x170043F2 RID: 17394
		// (get) Token: 0x06008588 RID: 34184 RVA: 0x007BDE28 File Offset: 0x007BC028
		// (set) Token: 0x06008589 RID: 34185 RVA: 0x007BDED8 File Offset: 0x007BC0D8
		internal int O9CHTrkTopFunctionButtonIndex_A36639Step
		{
			get
			{
				short num = (short)1474244229;
				short num2 = num;
				num = (short)542453381;
				switch (num2 == num)
				{
				}
				num = (short)1017905152;
				short num3 = num;
				num = (short)600571905;
				if (num != 0)
				{
				}
				num = (short)2095841280;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonIndex_A36639.StepSize;
			}
			set
			{
				short num = (short)314519549;
				short num2 = num;
				num = (short)58535933;
				switch (num2 == num)
				{
				}
				num = (short)783024128;
				short num3 = num;
				num = (short)2081882113;
				if (num != 0)
				{
				}
				num = (short)144441344;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonIndex_A36639.StepSize = value;
			}
		}

		// Token: 0x170043F3 RID: 17395
		// (get) Token: 0x0600858A RID: 34186 RVA: 0x007BDF8C File Offset: 0x007BC18C
		// (set) Token: 0x0600858B RID: 34187 RVA: 0x007BE03C File Offset: 0x007BC23C
		public bool O9CHTrkTopFunctionButtonIndex_A36639_Applicable
		{
			get
			{
				short num = (short)2050214267;
				short num2 = num;
				num = (short)1660471675;
				switch (num2 == num)
				{
				}
				num = (short)1536950272;
				short num3 = num;
				num = (short)1511718912;
				if (num != 0)
				{
				}
				num = (short)623902721;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonIndex_A36639.Applicable;
			}
			set
			{
				short num = (short)2033151901;
				short num2 = num;
				num = (short)1696624541;
				switch (num2 == num)
				{
				}
				num = (short)35782656;
				short num3 = num;
				num = (short)223674369;
				if (num != 0)
				{
				}
				num = (short)1016659968;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonIndex_A36639.Applicable = value;
			}
		}

		// Token: 0x170043F4 RID: 17396
		// (get) Token: 0x0600858C RID: 34188 RVA: 0x007BE0F4 File Offset: 0x007BC2F4
		// (set) Token: 0x0600858D RID: 34189 RVA: 0x007BE1A8 File Offset: 0x007BC3A8
		public bool O9CHTrkTopFunctionButtonIndex_A36639_Valid
		{
			get
			{
				short num = (short)365850966;
				short num2 = num;
				num = (short)1001484630;
				switch (num2 == num)
				{
				}
				num = (short)952893440;
				short num3 = num;
				num = (short)845283329;
				if (num != 0)
				{
				}
				num = (short)267255808;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonIndex_A36639.Valid;
			}
			set
			{
				short num = (short)362314924;
				short num2 = num;
				num = (short)1254587564;
				switch (num2 == num)
				{
				}
				num = (short)1397096448;
				short num3 = num;
				num = (short)547225601;
				if (num != 0)
				{
				}
				num = (short)345571328;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonIndex_A36639.Valid = value;
			}
		}

		// Token: 0x170043F5 RID: 17397
		// (get) Token: 0x0600858E RID: 34190 RVA: 0x007BE25C File Offset: 0x007BC45C
		// (set) Token: 0x0600858F RID: 34191 RVA: 0x007BE310 File Offset: 0x007BC510
		public bool O9CHTrkTopFunctionButtonIndex_A36639_Visible
		{
			get
			{
				short num = (short)534315009;
				if (num != 0)
				{
				}
				num = (short)1448919264;
				short num2 = num;
				num = (short)81445088;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1448607744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)319946752;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonIndex_A36639.Visible;
			}
			set
			{
				short num = (short)1789067264;
				short num2 = num;
				num = (short)1948342303;
				short num3 = num;
				num = (short)404314143;
				switch (num3 == num)
				{
				}
				num = (short)478281729;
				if (num != 0)
				{
				}
				num = (short)597557248;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonIndex_A36639.Visible = value;
			}
		}

		// Token: 0x170043F6 RID: 17398
		// (get) Token: 0x06008590 RID: 34192 RVA: 0x007BE3C8 File Offset: 0x007BC5C8
		// (set) Token: 0x06008591 RID: 34193 RVA: 0x007BE47C File Offset: 0x007BC67C
		public bool O9CHTrkTopFunctionButtonIndex_A36639_Editable
		{
			get
			{
				short num = (short)334692352;
				short num2 = num;
				num = (short)213295515;
				short num3 = num;
				num = (short)889233819;
				switch (num3 == num)
				{
				}
				num = (short)1111818241;
				if (num != 0)
				{
				}
				num = (short)679477248;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonIndex_A36639.Editable;
			}
			set
			{
				short num = (short)229310464;
				short num2 = num;
				num = (short)1132320361;
				short num3 = num;
				num = (short)830199401;
				switch (num3 == num)
				{
				}
				num = (short)1757478913;
				if (num != 0)
				{
				}
				num = (short)127860736;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonIndex_A36639.Editable = value;
			}
		}

		// Token: 0x170043F7 RID: 17399
		// (get) Token: 0x06008592 RID: 34194 RVA: 0x007BE530 File Offset: 0x007BC730
		internal string O9CHTrkTopFunctionButtonIndex_A36639_UILabel
		{
			get
			{
				short num = (short)1954480128;
				short num2 = num;
				num = (short)21674746;
				short num3 = num;
				num = (short)1363393274;
				switch (num3 == num)
				{
				}
				num = (short)450101249;
				if (num != 0)
				{
				}
				num = (short)783876096;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonIndex_A36639.UIName;
			}
		}

		// Token: 0x170043F8 RID: 17400
		// (get) Token: 0x06008593 RID: 34195 RVA: 0x007BE5E4 File Offset: 0x007BC7E4
		// (set) Token: 0x06008594 RID: 34196 RVA: 0x007BE698 File Offset: 0x007BC898
		internal bool O9CHTrkTopFunctionButtonIndex_A36639_HiddenStatic
		{
			get
			{
				short num = (short)1394475008;
				short num2 = num;
				num = (short)673230726;
				short num3 = num;
				num = (short)139636614;
				switch (num3 == num)
				{
				}
				num = (short)2041970689;
				if (num != 0)
				{
				}
				num = (short)32833536;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonIndex_A36639.HiddenStatic;
			}
			set
			{
				short num = (short)2051145728;
				short num2 = num;
				num = (short)1442057630;
				short num3 = num;
				num = (short)1865878942;
				switch (num3 == num)
				{
				}
				num = (short)1389166593;
				if (num != 0)
				{
				}
				num = (short)1355808768;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonIndex_A36639.HiddenStatic = value;
			}
		}

		// Token: 0x170043F9 RID: 17401
		// (get) Token: 0x06008595 RID: 34197 RVA: 0x007BE74C File Offset: 0x007BC94C
		// (set) Token: 0x06008596 RID: 34198 RVA: 0x007BE800 File Offset: 0x007BCA00
		internal bool O9CHTrkTopFunctionButtonIndex_A36639_HiddenDynamic
		{
			get
			{
				short num = (short)365363200;
				short num2 = num;
				num = (short)997663709;
				short num3 = num;
				num = (short)1811948509;
				switch (num3 == num)
				{
				}
				num = (short)62783489;
				if (num != 0)
				{
				}
				num = (short)1934688256;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonIndex_A36639.HiddenDynamic;
			}
			set
			{
				short num = (short)1905262592;
				short num2 = num;
				num = (short)252168608;
				short num3 = num;
				num = (short)1653524896;
				switch (num3 == num)
				{
				}
				num = (short)1235746817;
				if (num != 0)
				{
				}
				num = (short)392167424;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonIndex_A36639.HiddenDynamic = value;
			}
		}

		// Token: 0x170043FA RID: 17402
		// (get) Token: 0x06008597 RID: 34199 RVA: 0x007BE8B8 File Offset: 0x007BCAB8
		public bool O9CHTrkTopFunctionButtonIndex_A36639_HasDiffs
		{
			get
			{
				short num = (short)109051904;
				short num2 = num;
				num = (short)1459231087;
				short num3 = num;
				num = (short)364386671;
				switch (num3 == num)
				{
				}
				num = (short)973930497;
				if (num != 0)
				{
				}
				num = (short)824180736;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonIndex_A36639._HasDiffs;
			}
		}

		// Token: 0x170043FB RID: 17403
		// (get) Token: 0x06008598 RID: 34200 RVA: 0x007BE970 File Offset: 0x007BCB70
		// (set) Token: 0x06008599 RID: 34201 RVA: 0x007BEA28 File Offset: 0x007BCC28
		public string CHO9TrkTopFunctionButtonLabelLine1_A36650Value
		{
			get
			{
				short num = (short)917110784;
				short num2 = num;
				num = (short)183980980;
				short num3 = num;
				num = (short)949179316;
				switch (num3 == num)
				{
				}
				num = (short)452657153;
				if (num != 0)
				{
				}
				num = (short)1389363200;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine1_A36650.Value;
			}
			set
			{
				short num = (short)1844314112;
				short num2 = num;
				num = (short)690827615;
				short num3 = num;
				num = (short)76558687;
				switch (num3 == num)
				{
				}
				num = (short)1010040832;
				if (num != 0)
				{
				}
				num = (short)220856321;
				if (num != 0)
				{
				}
				this.cHO9TrkTopFunctionButtonLabelLine1_A36650.Value = value;
			}
		}

		// Token: 0x170043FC RID: 17404
		// (get) Token: 0x0600859A RID: 34202 RVA: 0x007BEADC File Offset: 0x007BCCDC
		public global::AcpBusinessLayer.AcpField<string> CHO9TrkTopFunctionButtonLabelLine1_A36650
		{
			get
			{
				short num = (short)1777139712;
				short num2 = num;
				num = (short)82761349;
				short num3 = num;
				num = (short)1175049861;
				switch (num3 == num)
				{
				}
				num = (short)1947140096;
				if (num != 0)
				{
				}
				num = (short)1487011841;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine1_A36650;
			}
		}

		// Token: 0x170043FD RID: 17405
		// (get) Token: 0x0600859B RID: 34203 RVA: 0x007BEB8C File Offset: 0x007BCD8C
		// (set) Token: 0x0600859C RID: 34204 RVA: 0x007BEC44 File Offset: 0x007BCE44
		public string CHO9TrkTopFunctionButtonLabelLine1_A36650_UIValue
		{
			get
			{
				short num = (short)1310785536;
				short num2 = num;
				num = (short)1582710657;
				short num3 = num;
				num = (short)1605910401;
				switch (num3 == num)
				{
				}
				num = (short)551616513;
				if (num != 0)
				{
				}
				num = (short)320929792;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine1_A36650.Value;
			}
			set
			{
				short num = (short)1891500032;
				short num2 = num;
				num = (short)18556287;
				short num3 = num;
				num = (short)331621759;
				switch (num3 == num)
				{
				}
				num = (short)610926593;
				if (num != 0)
				{
				}
				num = (short)498925568;
				if (num != 0)
				{
				}
				this.cHO9TrkTopFunctionButtonLabelLine1_A36650.Value = value;
			}
		}

		// Token: 0x170043FE RID: 17406
		// (get) Token: 0x0600859D RID: 34205 RVA: 0x007BECFC File Offset: 0x007BCEFC
		// (set) Token: 0x0600859E RID: 34206 RVA: 0x007BEDB0 File Offset: 0x007BCFB0
		public bool CHO9TrkTopFunctionButtonLabelLine1_A36650_Applicable
		{
			get
			{
				short num = (short)1576988890;
				short num2 = num;
				num = (short)1009774810;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1158610944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1102315521;
				if (num != 0)
				{
				}
				num = (short)1514995712;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine1_A36650.Applicable;
			}
			set
			{
				short num = (short)130943466;
				short num2 = num;
				num = (short)483396074;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2061041664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1948581889;
				if (num != 0)
				{
				}
				num = (short)1182793728;
				if (num != 0)
				{
				}
				this.cHO9TrkTopFunctionButtonLabelLine1_A36650.Applicable = value;
			}
		}

		// Token: 0x170043FF RID: 17407
		// (get) Token: 0x0600859F RID: 34207 RVA: 0x007BEE68 File Offset: 0x007BD068
		// (set) Token: 0x060085A0 RID: 34208 RVA: 0x007BEF1C File Offset: 0x007BD11C
		public bool CHO9TrkTopFunctionButtonLabelLine1_A36650_Valid
		{
			get
			{
				short num = (short)220580402;
				short num2 = num;
				num = (short)1043778098;
				switch (num2 == num)
				{
				default:
				{
					num = (short)552271872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1305346049;
				if (num != 0)
				{
				}
				num = (short)716898304;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine1_A36650.Valid;
			}
			set
			{
				short num = (short)1500672207;
				short num2 = num;
				num = (short)306344143;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1135149056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)89522176;
				if (num != 0)
				{
				}
				num = (short)146014209;
				if (num != 0)
				{
				}
				this.cHO9TrkTopFunctionButtonLabelLine1_A36650.Valid = value;
			}
		}

		// Token: 0x17004400 RID: 17408
		// (get) Token: 0x060085A1 RID: 34209 RVA: 0x007BEFD4 File Offset: 0x007BD1D4
		// (set) Token: 0x060085A2 RID: 34210 RVA: 0x007BF08C File Offset: 0x007BD28C
		public bool CHO9TrkTopFunctionButtonLabelLine1_A36650_Visible
		{
			get
			{
				short num = (short)1938968228;
				short num2 = num;
				num = (short)1623412388;
				switch (num2 == num)
				{
				default:
				{
					num = (short)415170560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)531169281;
				if (num != 0)
				{
				}
				num = (short)258080768;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine1_A36650.Visible;
			}
			set
			{
				short num = (short)1473118209;
				if (num != 0)
				{
				}
				num = (short)1343291392;
				short num2 = num;
				num = (short)595506650;
				short num3 = num;
				num = (short)835630554;
				switch (num3 == num)
				{
				}
				num = (short)1744830464;
				if (num != 0)
				{
				}
				this.cHO9TrkTopFunctionButtonLabelLine1_A36650.Visible = value;
			}
		}

		// Token: 0x17004401 RID: 17409
		// (get) Token: 0x060085A3 RID: 34211 RVA: 0x007BF140 File Offset: 0x007BD340
		// (set) Token: 0x060085A4 RID: 34212 RVA: 0x007BF1F4 File Offset: 0x007BD3F4
		public bool CHO9TrkTopFunctionButtonLabelLine1_A36650_Editable
		{
			get
			{
				short num = (short)1707653928;
				short num2 = num;
				num = (short)110279464;
				switch (num2 == num)
				{
				default:
				{
					num = (short)634454016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)834142209;
				if (num != 0)
				{
				}
				num = (short)1087176704;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine1_A36650.Editable;
			}
			set
			{
				short num = (short)2059995335;
				short num2 = num;
				num = (short)248842439;
				switch (num2 == num)
				{
				default:
				{
					num = (short)336592896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1750859777;
				if (num != 0)
				{
				}
				num = (short)255328256;
				if (num != 0)
				{
				}
				this.cHO9TrkTopFunctionButtonLabelLine1_A36650.Editable = value;
			}
		}

		// Token: 0x17004402 RID: 17410
		// (get) Token: 0x060085A5 RID: 34213 RVA: 0x007BF2AC File Offset: 0x007BD4AC
		internal string CHO9TrkTopFunctionButtonLabelLine1_A36650_UILabel
		{
			get
			{
				short num = (short)1564596788;
				short num2 = num;
				num = (short)754899508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1162936320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)270008320;
				if (num != 0)
				{
				}
				num = (short)785252353;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine1_A36650.UIName;
			}
		}

		// Token: 0x17004403 RID: 17411
		// (get) Token: 0x060085A6 RID: 34214 RVA: 0x007BF360 File Offset: 0x007BD560
		// (set) Token: 0x060085A7 RID: 34215 RVA: 0x007BF410 File Offset: 0x007BD610
		internal bool CHO9TrkTopFunctionButtonLabelLine1_A36650_HiddenStatic
		{
			get
			{
				short num = (short)786516449;
				short num2 = num;
				num = (short)1604667873;
				switch (num2 == num)
				{
				default:
				{
					num = (short)428146688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)487391232;
				if (num != 0)
				{
				}
				num = (short)224198657;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine1_A36650.HiddenStatic;
			}
			set
			{
				short num = (short)118501837;
				short num2 = num;
				num = (short)31470029;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1436286976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1834090497;
				if (num != 0)
				{
				}
				num = (short)1457455104;
				if (num != 0)
				{
				}
				this.cHO9TrkTopFunctionButtonLabelLine1_A36650.HiddenStatic = value;
			}
		}

		// Token: 0x17004404 RID: 17412
		// (get) Token: 0x060085A8 RID: 34216 RVA: 0x007BF4C4 File Offset: 0x007BD6C4
		// (set) Token: 0x060085A9 RID: 34217 RVA: 0x007BF578 File Offset: 0x007BD778
		internal bool CHO9TrkTopFunctionButtonLabelLine1_A36650_HiddenDynamic
		{
			get
			{
				short num = (short)315981395;
				short num2 = num;
				num = (short)1457028691;
				switch (num2 == num)
				{
				default:
				{
					num = (short)634781696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1196490752;
				if (num != 0)
				{
				}
				num = (short)1969029121;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine1_A36650.HiddenDynamic;
			}
			set
			{
				short num = (short)1861858031;
				short num2 = num;
				num = (short)1399960303;
				switch (num2 == num)
				{
				default:
				{
					num = (short)110493696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)717291521;
				if (num != 0)
				{
				}
				num = (short)788463616;
				if (num != 0)
				{
				}
				this.cHO9TrkTopFunctionButtonLabelLine1_A36650.HiddenDynamic = value;
			}
		}

		// Token: 0x17004405 RID: 17413
		// (get) Token: 0x060085AA RID: 34218 RVA: 0x007BF62C File Offset: 0x007BD82C
		public bool CHO9TrkTopFunctionButtonLabelLine1_A36650_HasDiffs
		{
			get
			{
				short num = (short)2085339156;
				short num2 = num;
				num = (short)1759756308;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1320484864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1561329665;
				if (num != 0)
				{
				}
				num = (short)540803072;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine1_A36650._HasDiffs;
			}
		}

		// Token: 0x17004406 RID: 17414
		// (get) Token: 0x060085AB RID: 34219 RVA: 0x007BF6E0 File Offset: 0x007BD8E0
		// (set) Token: 0x060085AC RID: 34220 RVA: 0x007BF794 File Offset: 0x007BD994
		public string CHO9TrkTopFunctionButtonLabelLine2_A36651Value
		{
			get
			{
				short num = (short)1347682305;
				if (num != 0)
				{
				}
				num = (short)1280835584;
				short num2 = num;
				num = (short)1691151446;
				short num3 = num;
				num = (short)304475222;
				switch (num3 == num)
				{
				}
				num = (short)1903230976;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine2_A36651.Value;
			}
			set
			{
				short num = (short)1857890964;
				short num2 = num;
				num = (short)174074516;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2021064704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1745682433;
				if (num != 0)
				{
				}
				num = (short)11796480;
				if (num != 0)
				{
				}
				this.cHO9TrkTopFunctionButtonLabelLine2_A36651.Value = value;
			}
		}

		// Token: 0x17004407 RID: 17415
		// (get) Token: 0x060085AD RID: 34221 RVA: 0x007BF848 File Offset: 0x007BDA48
		public global::AcpBusinessLayer.AcpField<string> CHO9TrkTopFunctionButtonLabelLine2_A36651
		{
			get
			{
				short num = (short)2029797376;
				short num2 = num;
				num = (short)310460416;
				switch (num2 == num)
				{
				default:
				{
					num = (short)213188608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)645398529;
				if (num != 0)
				{
				}
				num = (short)2071461888;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine2_A36651;
			}
		}

		// Token: 0x17004408 RID: 17416
		// (get) Token: 0x060085AE RID: 34222 RVA: 0x007BF8F8 File Offset: 0x007BDAF8
		// (set) Token: 0x060085AF RID: 34223 RVA: 0x007BF9A8 File Offset: 0x007BDBA8
		public string CHO9TrkTopFunctionButtonLabelLine2_A36651_UIValue
		{
			get
			{
				short num = (short)270433411;
				short num2 = num;
				num = (short)895777923;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2118909952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1471545345;
				if (num != 0)
				{
				}
				num = (short)763297792;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine2_A36651.Value;
			}
			set
			{
				short num = (short)2125919536;
				short num2 = num;
				num = (short)608695600;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1356201984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)406913025;
				if (num != 0)
				{
				}
				num = (short)1570504704;
				if (num != 0)
				{
				}
				this.cHO9TrkTopFunctionButtonLabelLine2_A36651.Value = value;
			}
		}

		// Token: 0x17004409 RID: 17417
		// (get) Token: 0x060085B0 RID: 34224 RVA: 0x007BFA60 File Offset: 0x007BDC60
		// (set) Token: 0x060085B1 RID: 34225 RVA: 0x007BFB14 File Offset: 0x007BDD14
		public bool CHO9TrkTopFunctionButtonLabelLine2_A36651_Applicable
		{
			get
			{
				short num = (short)655109835;
				short num2 = num;
				num = (short)2059153099;
				switch (num2 == num)
				{
				default:
				{
					num = (short)689963008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)912392193;
				if (num != 0)
				{
				}
				num = (short)1977024512;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine2_A36651.Applicable;
			}
			set
			{
				short num = (short)995082709;
				short num2 = num;
				num = (short)2088944085;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1981218816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)365494272;
				if (num != 0)
				{
				}
				num = (short)1585643521;
				if (num != 0)
				{
				}
				this.cHO9TrkTopFunctionButtonLabelLine2_A36651.Applicable = value;
			}
		}

		// Token: 0x1700440A RID: 17418
		// (get) Token: 0x060085B2 RID: 34226 RVA: 0x007BFBC8 File Offset: 0x007BDDC8
		// (set) Token: 0x060085B3 RID: 34227 RVA: 0x007BFC7C File Offset: 0x007BDE7C
		public bool CHO9TrkTopFunctionButtonLabelLine2_A36651_Valid
		{
			get
			{
				short num = (short)1190856896;
				short num2 = num;
				num = (short)1464928448;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1363410944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)238944257;
				if (num != 0)
				{
				}
				num = (short)239140864;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine2_A36651.Valid;
			}
			set
			{
				short num = (short)595627607;
				short num2 = num;
				num = (short)2135920215;
				switch (num2 == num)
				{
				default:
				{
					num = (short)447217664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2088173569;
				if (num != 0)
				{
				}
				num = (short)1967783936;
				if (num != 0)
				{
				}
				this.cHO9TrkTopFunctionButtonLabelLine2_A36651.Valid = value;
			}
		}

		// Token: 0x1700440B RID: 17419
		// (get) Token: 0x060085B4 RID: 34228 RVA: 0x007BFD30 File Offset: 0x007BDF30
		// (set) Token: 0x060085B5 RID: 34229 RVA: 0x007BFDE4 File Offset: 0x007BDFE4
		public bool CHO9TrkTopFunctionButtonLabelLine2_A36651_Visible
		{
			get
			{
				short num = (short)1291637534;
				short num2 = num;
				num = (short)982242078;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1097072640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1850867713;
				if (num != 0)
				{
				}
				num = (short)718864384;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine2_A36651.Visible;
			}
			set
			{
				short num = (short)1754007671;
				short num2 = num;
				num = (short)1342179447;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1443692544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)24117249;
				if (num != 0)
				{
				}
				num = (short)665518080;
				if (num != 0)
				{
				}
				this.cHO9TrkTopFunctionButtonLabelLine2_A36651.Visible = value;
			}
		}

		// Token: 0x1700440C RID: 17420
		// (get) Token: 0x060085B6 RID: 34230 RVA: 0x007BFE98 File Offset: 0x007BE098
		// (set) Token: 0x060085B7 RID: 34231 RVA: 0x007BFF4C File Offset: 0x007BE14C
		public bool CHO9TrkTopFunctionButtonLabelLine2_A36651_Editable
		{
			get
			{
				short num = (short)1120145630;
				short num2 = num;
				num = (short)254546142;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1874067456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1687617537;
				if (num != 0)
				{
				}
				num = (short)1014038528;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine2_A36651.Editable;
			}
			set
			{
				short num = (short)1479056640;
				short num2 = num;
				num = (short)1909169408;
				switch (num2 == num)
				{
				default:
				{
					num = (short)960888832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)926810113;
				if (num != 0)
				{
				}
				num = (short)797179904;
				if (num != 0)
				{
				}
				this.cHO9TrkTopFunctionButtonLabelLine2_A36651.Editable = value;
			}
		}

		// Token: 0x1700440D RID: 17421
		// (get) Token: 0x060085B8 RID: 34232 RVA: 0x007C0004 File Offset: 0x007BE204
		internal string CHO9TrkTopFunctionButtonLabelLine2_A36651_UILabel
		{
			get
			{
				short num = (short)1019261277;
				short num2 = num;
				num = (short)679981405;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1846280192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)368312321;
				if (num != 0)
				{
				}
				num = (short)1757413376;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine2_A36651.UIName;
			}
		}

		// Token: 0x1700440E RID: 17422
		// (get) Token: 0x060085B9 RID: 34233 RVA: 0x007C00B8 File Offset: 0x007BE2B8
		// (set) Token: 0x060085BA RID: 34234 RVA: 0x007C0168 File Offset: 0x007BE368
		internal bool CHO9TrkTopFunctionButtonLabelLine2_A36651_HiddenStatic
		{
			get
			{
				short num = (short)1145267799;
				short num2 = num;
				num = (short)1918395991;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1344667648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)53477377;
				if (num != 0)
				{
				}
				num = (short)1701117952;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine2_A36651.HiddenStatic;
			}
			set
			{
				short num = (short)2143213452;
				short num2 = num;
				num = (short)295032716;
				switch (num2 == num)
				{
				default:
				{
					num = (short)547487744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1062600704;
				if (num != 0)
				{
				}
				num = (short)1639055361;
				if (num != 0)
				{
				}
				this.cHO9TrkTopFunctionButtonLabelLine2_A36651.HiddenStatic = value;
			}
		}

		// Token: 0x1700440F RID: 17423
		// (get) Token: 0x060085BB RID: 34235 RVA: 0x007C0220 File Offset: 0x007BE420
		// (set) Token: 0x060085BC RID: 34236 RVA: 0x007C02D8 File Offset: 0x007BE4D8
		internal bool CHO9TrkTopFunctionButtonLabelLine2_A36651_HiddenDynamic
		{
			get
			{
				short num = (short)133798075;
				short num2 = num;
				num = (short)47814843;
				switch (num2 == num)
				{
				default:
				{
					num = (short)74383360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2004484097;
				if (num != 0)
				{
				}
				num = (short)927399936;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine2_A36651.HiddenDynamic;
			}
			set
			{
				short num = (short)1949696001;
				if (num != 0)
				{
				}
				num = (short)1422000128;
				short num2 = num;
				num = (short)846707907;
				short num3 = num;
				num = (short)869055683;
				switch (num3 == num)
				{
				}
				num = (short)271515648;
				if (num != 0)
				{
				}
				this.cHO9TrkTopFunctionButtonLabelLine2_A36651.HiddenDynamic = value;
			}
		}

		// Token: 0x17004410 RID: 17424
		// (get) Token: 0x060085BD RID: 34237 RVA: 0x007C0390 File Offset: 0x007BE590
		public bool CHO9TrkTopFunctionButtonLabelLine2_A36651_HasDiffs
		{
			get
			{
				short num = (short)2015166465;
				if (num != 0)
				{
				}
				num = (short)1128857600;
				short num2 = num;
				num = (short)160117927;
				short num3 = num;
				num = (short)1269118119;
				switch (num3 == num)
				{
				}
				num = (short)177995776;
				if (num != 0)
				{
				}
				return this.cHO9TrkTopFunctionButtonLabelLine2_A36651._HasDiffs;
			}
		}

		// Token: 0x17004411 RID: 17425
		// (get) Token: 0x060085BE RID: 34238 RVA: 0x007C0444 File Offset: 0x007BE644
		// (set) Token: 0x060085BF RID: 34239 RVA: 0x007C04FC File Offset: 0x007BE6FC
		public int TopFunctionBtnCnvZone_A36942Value
		{
			get
			{
				short num = (short)830930945;
				if (num != 0)
				{
				}
				num = (short)244449280;
				short num2 = num;
				num = (short)848917227;
				short num3 = num;
				num = (short)2109764331;
				switch (num3 == num)
				{
				}
				num = (short)551682048;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvZone_A36942.Value;
			}
			set
			{
				short num = (short)489242026;
				short num2 = num;
				num = (short)112278954;
				switch (num2 == num)
				{
				default:
				{
					num = (short)628817920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)951451648;
				if (num != 0)
				{
				}
				num = (short)824442881;
				if (num != 0)
				{
				}
				this.topFunctionBtnCnvZone_A36942.Value = value;
			}
		}

		// Token: 0x17004412 RID: 17426
		// (get) Token: 0x060085C0 RID: 34240 RVA: 0x007C05B4 File Offset: 0x007BE7B4
		// (set) Token: 0x060085C1 RID: 34241 RVA: 0x007C0668 File Offset: 0x007BE868
		public string TopFunctionBtnCnvZone_A36942_UIValue
		{
			get
			{
				short num = (short)1607476754;
				short num2 = num;
				num = (short)2121999890;
				switch (num2 == num)
				{
				default:
				{
					num = (short)88932352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)421396481;
				if (num != 0)
				{
				}
				num = (short)430047232;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvZone_A36942.UIValue;
			}
			set
			{
				short num = (short)252903425;
				if (num != 0)
				{
				}
				num = (short)762445824;
				short num2 = num;
				num = (short)79298376;
				short num3 = num;
				num = (short)1760952136;
				switch (num3 == num)
				{
				}
				num = (short)1558642688;
				if (num != 0)
				{
				}
				this.topFunctionBtnCnvZone_A36942.UIValue = value;
			}
		}

		// Token: 0x17004413 RID: 17427
		// (get) Token: 0x060085C2 RID: 34242 RVA: 0x007C071C File Offset: 0x007BE91C
		public global::AcpBusinessLayer.AcpRecRefField TopFunctionBtnCnvZone_A36942
		{
			get
			{
				short num = (short)1633156814;
				short num2 = num;
				num = (short)1300561614;
				switch (num2 == num)
				{
				default:
				{
					num = (short)767950848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)443547649;
				if (num != 0)
				{
				}
				num = (short)99745792;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvZone_A36942;
			}
		}

		// Token: 0x17004414 RID: 17428
		// (get) Token: 0x060085C3 RID: 34243 RVA: 0x007C07CC File Offset: 0x007BE9CC
		// (set) Token: 0x060085C4 RID: 34244 RVA: 0x007C0884 File Offset: 0x007BEA84
		public bool TopFunctionBtnCnvZone_A36942_Applicable
		{
			get
			{
				short num = (short)1349329585;
				short num2 = num;
				num = (short)1792549553;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2016411648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1089339393;
				if (num != 0)
				{
				}
				num = (short)1502019584;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvZone_A36942.Applicable;
			}
			set
			{
				short num = (short)1869792978;
				short num2 = num;
				num = (short)1177798354;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1621360640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)660865025;
				if (num != 0)
				{
				}
				num = (short)53673984;
				if (num != 0)
				{
				}
				this.topFunctionBtnCnvZone_A36942.Applicable = value;
			}
		}

		// Token: 0x17004415 RID: 17429
		// (get) Token: 0x060085C5 RID: 34245 RVA: 0x007C0938 File Offset: 0x007BEB38
		// (set) Token: 0x060085C6 RID: 34246 RVA: 0x007C09EC File Offset: 0x007BEBEC
		public bool TopFunctionBtnCnvZone_A36942_Valid
		{
			get
			{
				short num = (short)51316152;
				short num2 = num;
				num = (short)540411320;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1912668160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1818951681;
				if (num != 0)
				{
				}
				num = (short)1083899904;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvZone_A36942.Valid;
			}
			set
			{
				short num = (short)1901350744;
				short num2 = num;
				num = (short)816598872;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1137967104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)418185217;
				if (num != 0)
				{
				}
				num = (short)1861746688;
				if (num != 0)
				{
				}
				this.topFunctionBtnCnvZone_A36942.Valid = value;
			}
		}

		// Token: 0x17004416 RID: 17430
		// (get) Token: 0x060085C7 RID: 34247 RVA: 0x007C0AA4 File Offset: 0x007BECA4
		// (set) Token: 0x060085C8 RID: 34248 RVA: 0x007C0B58 File Offset: 0x007BED58
		public bool TopFunctionBtnCnvZone_A36942_Visible
		{
			get
			{
				short num = (short)115001190;
				short num2 = num;
				num = (short)1776469862;
				switch (num2 == num)
				{
				default:
				{
					num = (short)188088320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)568655872;
				if (num != 0)
				{
				}
				num = (short)2141585409;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvZone_A36942.Visible;
			}
			set
			{
				short num = (short)218270856;
				short num2 = num;
				num = (short)2123140232;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1206190080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1877278721;
				if (num != 0)
				{
				}
				num = (short)282001408;
				if (num != 0)
				{
				}
				this.topFunctionBtnCnvZone_A36942.Visible = value;
			}
		}

		// Token: 0x17004417 RID: 17431
		// (get) Token: 0x060085C9 RID: 34249 RVA: 0x007C0C0C File Offset: 0x007BEE0C
		// (set) Token: 0x060085CA RID: 34250 RVA: 0x007C0CC0 File Offset: 0x007BEEC0
		public bool TopFunctionBtnCnvZone_A36942_Editable
		{
			get
			{
				short num = (short)1550944557;
				short num2 = num;
				num = (short)2019592493;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1687027712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1451556864;
				if (num != 0)
				{
				}
				num = (short)1031602177;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvZone_A36942.Editable;
			}
			set
			{
				short num = (short)1753887027;
				short num2 = num;
				num = (short)2074030387;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1049231360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)625147905;
				if (num != 0)
				{
				}
				num = (short)1133838336;
				if (num != 0)
				{
				}
				this.topFunctionBtnCnvZone_A36942.Editable = value;
			}
		}

		// Token: 0x17004418 RID: 17432
		// (get) Token: 0x060085CB RID: 34251 RVA: 0x007C0D78 File Offset: 0x007BEF78
		internal string TopFunctionBtnCnvZone_A36942_UILabel
		{
			get
			{
				short num = (short)1285315246;
				short num2 = num;
				num = (short)877419182;
				switch (num2 == num)
				{
				default:
				{
					num = (short)714473472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1964572672;
				if (num != 0)
				{
				}
				num = (short)1755709441;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvZone_A36942.UIName;
			}
		}

		// Token: 0x17004419 RID: 17433
		// (get) Token: 0x060085CC RID: 34252 RVA: 0x007C0E2C File Offset: 0x007BF02C
		// (set) Token: 0x060085CD RID: 34253 RVA: 0x007C0EE0 File Offset: 0x007BF0E0
		internal bool TopFunctionBtnCnvZone_A36942_HiddenStatic
		{
			get
			{
				short num = (short)743571457;
				if (num != 0)
				{
				}
				num = (short)998113280;
				short num2 = num;
				num = (short)1615291337;
				short num3 = num;
				num = (short)1495491529;
				switch (num3 == num)
				{
				}
				num = (short)1229455360;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvZone_A36942.HiddenStatic;
			}
			set
			{
				short num = (short)972873034;
				short num2 = num;
				num = (short)1955913034;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1208483840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1090125825;
				if (num != 0)
				{
				}
				num = (short)2137063424;
				if (num != 0)
				{
				}
				this.topFunctionBtnCnvZone_A36942.HiddenStatic = value;
			}
		}

		// Token: 0x1700441A RID: 17434
		// (get) Token: 0x060085CE RID: 34254 RVA: 0x007C0F98 File Offset: 0x007BF198
		// (set) Token: 0x060085CF RID: 34255 RVA: 0x007C104C File Offset: 0x007BF24C
		internal bool TopFunctionBtnCnvZone_A36942_HiddenDynamic
		{
			get
			{
				short num = (short)1779040257;
				if (num != 0)
				{
				}
				num = (short)1349255168;
				short num2 = num;
				num = (short)1441263323;
				short num3 = num;
				num = (short)2141253339;
				switch (num3 == num)
				{
				}
				num = (short)1326645248;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvZone_A36942.HiddenDynamic;
			}
			set
			{
				short num = (short)569573377;
				if (num != 0)
				{
				}
				num = (short)1353056256;
				short num2 = num;
				num = (short)1195840435;
				short num3 = num;
				num = (short)2114786227;
				switch (num3 == num)
				{
				}
				num = (short)1658716160;
				if (num != 0)
				{
				}
				this.topFunctionBtnCnvZone_A36942.HiddenDynamic = value;
			}
		}

		// Token: 0x1700441B RID: 17435
		// (get) Token: 0x060085D0 RID: 34256 RVA: 0x007C1104 File Offset: 0x007BF304
		public bool TopFunctionBtnCnvZone_A36942_HasDiffs
		{
			get
			{
				short num = (short)321828060;
				short num2 = num;
				num = (short)670348508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)508297216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)638255105;
				if (num != 0)
				{
				}
				num = (short)1176305664;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvZone_A36942._HasDiffs;
			}
		}

		// Token: 0x1700441C RID: 17436
		// (get) Token: 0x060085D1 RID: 34257 RVA: 0x007C11B8 File Offset: 0x007BF3B8
		// (set) Token: 0x060085D2 RID: 34258 RVA: 0x007C126C File Offset: 0x007BF46C
		public int TopFunctionBtnCnvChannel_A36943Value
		{
			get
			{
				short num = (short)918282580;
				short num2 = num;
				num = (short)580575572;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1855717376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1030684673;
				if (num != 0)
				{
				}
				num = (short)1299447808;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvChannel_A36943.Value;
			}
			set
			{
				short num = (short)1776287745;
				if (num != 0)
				{
				}
				num = (short)1164050432;
				short num2 = num;
				num = (short)183898294;
				short num3 = num;
				num = (short)1582502070;
				switch (num3 == num)
				{
				}
				num = (short)859504640;
				if (num != 0)
				{
				}
				this.topFunctionBtnCnvChannel_A36943.Value = value;
			}
		}

		// Token: 0x1700441D RID: 17437
		// (get) Token: 0x060085D3 RID: 34259 RVA: 0x007C1320 File Offset: 0x007BF520
		// (set) Token: 0x060085D4 RID: 34260 RVA: 0x007C13D4 File Offset: 0x007BF5D4
		public string TopFunctionBtnCnvChannel_A36943_UIValue
		{
			get
			{
				short num = (short)65627050;
				short num2 = num;
				num = (short)1349280682;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1726087168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)785973249;
				if (num != 0)
				{
				}
				num = (short)1017905152;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvChannel_A36943.UIValue;
			}
			set
			{
				short num = (short)6219802;
				short num2 = num;
				num = (short)2044520474;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1985871872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1868431360;
				if (num != 0)
				{
				}
				num = (short)1192886273;
				if (num != 0)
				{
				}
				this.topFunctionBtnCnvChannel_A36943.UIValue = value;
			}
		}

		// Token: 0x1700441E RID: 17438
		// (get) Token: 0x060085D5 RID: 34261 RVA: 0x007C148C File Offset: 0x007BF68C
		public global::AcpBusinessLayer.AcpRecRefField TopFunctionBtnCnvChannel_A36943
		{
			get
			{
				short num = (short)1546484627;
				short num2 = num;
				num = (short)1704491923;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2026307584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)422903809;
				if (num != 0)
				{
				}
				num = (short)98304000;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvChannel_A36943;
			}
		}

		// Token: 0x1700441F RID: 17439
		// (get) Token: 0x060085D6 RID: 34262 RVA: 0x007C153C File Offset: 0x007BF73C
		// (set) Token: 0x060085D7 RID: 34263 RVA: 0x007C15F0 File Offset: 0x007BF7F0
		public bool TopFunctionBtnCnvChannel_A36943_Applicable
		{
			get
			{
				short num = (short)1616770836;
				short num2 = num;
				num = (short)157808404;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1767571456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2019033089;
				if (num != 0)
				{
				}
				num = (short)1878130688;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvChannel_A36943.Applicable;
			}
			set
			{
				short num = (short)248014935;
				short num2 = num;
				num = (short)1589602391;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1334640640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)994902017;
				if (num != 0)
				{
				}
				num = (short)729808896;
				if (num != 0)
				{
				}
				this.topFunctionBtnCnvChannel_A36943.Applicable = value;
			}
		}

		// Token: 0x17004420 RID: 17440
		// (get) Token: 0x060085D8 RID: 34264 RVA: 0x007C16A4 File Offset: 0x007BF8A4
		// (set) Token: 0x060085D9 RID: 34265 RVA: 0x007C1758 File Offset: 0x007BF958
		public bool TopFunctionBtnCnvChannel_A36943_Valid
		{
			get
			{
				short num = (short)125108225;
				if (num != 0)
				{
				}
				num = (short)1636958208;
				short num2 = num;
				num = (short)268320198;
				short num3 = num;
				num = (short)40189382;
				switch (num3 == num)
				{
				}
				num = (short)655097856;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvChannel_A36943.Valid;
			}
			set
			{
				short num = (short)1863391449;
				short num2 = num;
				num = (short)1103173849;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1870004224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2127429633;
				if (num != 0)
				{
				}
				num = (short)1637089280;
				if (num != 0)
				{
				}
				this.topFunctionBtnCnvChannel_A36943.Valid = value;
			}
		}

		// Token: 0x17004421 RID: 17441
		// (get) Token: 0x060085DA RID: 34266 RVA: 0x007C180C File Offset: 0x007BFA0C
		// (set) Token: 0x060085DB RID: 34267 RVA: 0x007C18C4 File Offset: 0x007BFAC4
		public bool TopFunctionBtnCnvChannel_A36943_Visible
		{
			get
			{
				short num = (short)1872497098;
				short num2 = num;
				num = (short)570165706;
				switch (num2 == num)
				{
				default:
				{
					num = (short)557711360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1251803137;
				if (num != 0)
				{
				}
				num = (short)1499594752;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvChannel_A36943.Visible;
			}
			set
			{
				short num = (short)838836848;
				short num2 = num;
				num = (short)128819824;
				switch (num2 == num)
				{
				default:
				{
					num = (short)618725376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1409548288;
				if (num != 0)
				{
				}
				num = (short)1806368769;
				if (num != 0)
				{
				}
				this.topFunctionBtnCnvChannel_A36943.Visible = value;
			}
		}

		// Token: 0x17004422 RID: 17442
		// (get) Token: 0x060085DC RID: 34268 RVA: 0x007C1978 File Offset: 0x007BFB78
		// (set) Token: 0x060085DD RID: 34269 RVA: 0x007C1A30 File Offset: 0x007BFC30
		public bool TopFunctionBtnCnvChannel_A36943_Editable
		{
			get
			{
				short num = (short)499712001;
				if (num != 0)
				{
				}
				num = (short)381419520;
				short num2 = num;
				num = (short)225772199;
				short num3 = num;
				num = (short)19727015;
				switch (num3 == num)
				{
				}
				num = (short)1874329600;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvChannel_A36943.Editable;
			}
			set
			{
				short num = (short)1431613734;
				short num2 = num;
				num = (short)473280806;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1337917440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1203765249;
				if (num != 0)
				{
				}
				num = (short)1252524032;
				if (num != 0)
				{
				}
				this.topFunctionBtnCnvChannel_A36943.Editable = value;
			}
		}

		// Token: 0x17004423 RID: 17443
		// (get) Token: 0x060085DE RID: 34270 RVA: 0x007C1AE4 File Offset: 0x007BFCE4
		internal string TopFunctionBtnCnvChannel_A36943_UILabel
		{
			get
			{
				short num = (short)53179658;
				short num2 = num;
				num = (short)1274377482;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1775960064;
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
				num = (short)1011089408;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvChannel_A36943.UIName;
			}
		}

		// Token: 0x17004424 RID: 17444
		// (get) Token: 0x060085DF RID: 34271 RVA: 0x007C1B98 File Offset: 0x007BFD98
		// (set) Token: 0x060085E0 RID: 34272 RVA: 0x007C1C4C File Offset: 0x007BFE4C
		internal bool TopFunctionBtnCnvChannel_A36943_HiddenStatic
		{
			get
			{
				short num = (short)570706347;
				short num2 = num;
				num = (short)89213355;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1924792320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)372703232;
				if (num != 0)
				{
				}
				num = (short)1428291585;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvChannel_A36943.HiddenStatic;
			}
			set
			{
				short num = (short)619659267;
				short num2 = num;
				num = (short)1359560707;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1629487104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1013317633;
				if (num != 0)
				{
				}
				num = (short)479068160;
				if (num != 0)
				{
				}
				this.topFunctionBtnCnvChannel_A36943.HiddenStatic = value;
			}
		}

		// Token: 0x17004425 RID: 17445
		// (get) Token: 0x060085E1 RID: 34273 RVA: 0x007C1D00 File Offset: 0x007BFF00
		// (set) Token: 0x060085E2 RID: 34274 RVA: 0x007C1DB8 File Offset: 0x007BFFB8
		internal bool TopFunctionBtnCnvChannel_A36943_HiddenDynamic
		{
			get
			{
				short num = (short)670859881;
				short num2 = num;
				num = (short)261325417;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1630928896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2138636289;
				if (num != 0)
				{
				}
				num = (short)805896192;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvChannel_A36943.HiddenDynamic;
			}
			set
			{
				short num = (short)783533636;
				short num2 = num;
				num = (short)2134230596;
				switch (num2 == num)
				{
				default:
				{
					num = (short)462618624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2004221952;
				if (num != 0)
				{
				}
				num = (short)1607270401;
				if (num != 0)
				{
				}
				this.topFunctionBtnCnvChannel_A36943.HiddenDynamic = value;
			}
		}

		// Token: 0x17004426 RID: 17446
		// (get) Token: 0x060085E3 RID: 34275 RVA: 0x007C1E70 File Offset: 0x007C0070
		public bool TopFunctionBtnCnvChannel_A36943_HasDiffs
		{
			get
			{
				short num = (short)39387137;
				if (num != 0)
				{
				}
				num = (short)1128857600;
				short num2 = num;
				num = (short)298003275;
				short num3 = num;
				num = (short)1849699147;
				switch (num3 == num)
				{
				}
				num = (short)74579968;
				if (num != 0)
				{
				}
				return this.topFunctionBtnCnvChannel_A36943._HasDiffs;
			}
		}

		// Token: 0x17004427 RID: 17447
		// (get) Token: 0x060085E4 RID: 34276 RVA: 0x007C1F28 File Offset: 0x007C0128
		// (set) Token: 0x060085E5 RID: 34277 RVA: 0x007C1FDC File Offset: 0x007C01DC
		public int TopFunctionBtnTrkZone_A36944Value
		{
			get
			{
				short num = (short)36127026;
				short num2 = num;
				num = (short)1330200882;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1683226624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1976369152;
				if (num != 0)
				{
				}
				num = (short)1412038657;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkZone_A36944.Value;
			}
			set
			{
				short num = (short)1035557329;
				short num2 = num;
				num = (short)1924618705;
				switch (num2 == num)
				{
				default:
				{
					num = (short)428212224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1046609921;
				if (num != 0)
				{
				}
				num = (short)2119630848;
				if (num != 0)
				{
				}
				this.topFunctionBtnTrkZone_A36944.Value = value;
			}
		}

		// Token: 0x17004428 RID: 17448
		// (get) Token: 0x060085E6 RID: 34278 RVA: 0x007C2090 File Offset: 0x007C0290
		// (set) Token: 0x060085E7 RID: 34279 RVA: 0x007C2144 File Offset: 0x007C0344
		public string TopFunctionBtnTrkZone_A36944_UIValue
		{
			get
			{
				short num = (short)1332620894;
				short num2 = num;
				num = (short)917450334;
				switch (num2 == num)
				{
				default:
				{
					num = (short)535560192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1791033345;
				if (num != 0)
				{
				}
				num = (short)1113980928;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkZone_A36944.UIValue;
			}
			set
			{
				short num = (short)14035218;
				short num2 = num;
				num = (short)2051352850;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1597308928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1086914561;
				if (num != 0)
				{
				}
				num = (short)1092485120;
				if (num != 0)
				{
				}
				this.topFunctionBtnTrkZone_A36944.UIValue = value;
			}
		}

		// Token: 0x17004429 RID: 17449
		// (get) Token: 0x060085E8 RID: 34280 RVA: 0x007C21FC File Offset: 0x007C03FC
		public global::AcpBusinessLayer.AcpRecRefField TopFunctionBtnTrkZone_A36944
		{
			get
			{
				short num = (short)757428861;
				short num2 = num;
				num = (short)1809871485;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1719861248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)198246401;
				if (num != 0)
				{
				}
				num = (short)873922560;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkZone_A36944;
			}
		}

		// Token: 0x1700442A RID: 17450
		// (get) Token: 0x060085E9 RID: 34281 RVA: 0x007C22A8 File Offset: 0x007C04A8
		// (set) Token: 0x060085EA RID: 34282 RVA: 0x007C2358 File Offset: 0x007C0558
		public bool TopFunctionBtnTrkZone_A36944_Applicable
		{
			get
			{
				short num = (short)1243955545;
				short num2 = num;
				num = (short)1663451481;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1171783680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)771817472;
				if (num != 0)
				{
				}
				num = (short)25493505;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkZone_A36944.Applicable;
			}
			set
			{
				short num = (short)890175951;
				short num2 = num;
				num = (short)872546767;
				switch (num2 == num)
				{
				default:
				{
					num = (short)609026048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)351666176;
				if (num != 0)
				{
				}
				num = (short)1666187265;
				if (num != 0)
				{
				}
				this.topFunctionBtnTrkZone_A36944.Applicable = value;
			}
		}

		// Token: 0x1700442B RID: 17451
		// (get) Token: 0x060085EB RID: 34283 RVA: 0x007C240C File Offset: 0x007C060C
		// (set) Token: 0x060085EC RID: 34284 RVA: 0x007C24C0 File Offset: 0x007C06C0
		public bool TopFunctionBtnTrkZone_A36944_Valid
		{
			get
			{
				short num = (short)841763313;
				short num2 = num;
				num = (short)1800161777;
				switch (num2 == num)
				{
				default:
				{
					num = (short)558235648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)183959553;
				if (num != 0)
				{
				}
				num = (short)165478400;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkZone_A36944.Valid;
			}
			set
			{
				short num = (short)76601156;
				short num2 = num;
				num = (short)824891204;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1939800064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)905641984;
				if (num != 0)
				{
				}
				num = (short)1216151553;
				if (num != 0)
				{
				}
				this.topFunctionBtnTrkZone_A36944.Valid = value;
			}
		}

		// Token: 0x1700442C RID: 17452
		// (get) Token: 0x060085ED RID: 34285 RVA: 0x007C2574 File Offset: 0x007C0774
		// (set) Token: 0x060085EE RID: 34286 RVA: 0x007C2628 File Offset: 0x007C0828
		public bool TopFunctionBtnTrkZone_A36944_Visible
		{
			get
			{
				short num = (short)66237999;
				short num2 = num;
				num = (short)125417007;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1295515648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2146566145;
				if (num != 0)
				{
				}
				num = (short)1269170176;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkZone_A36944.Visible;
			}
			set
			{
				short num = (short)149109047;
				short num2 = num;
				num = (short)243939639;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1561460736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)83689473;
				if (num != 0)
				{
				}
				num = (short)522977280;
				if (num != 0)
				{
				}
				this.topFunctionBtnTrkZone_A36944.Visible = value;
			}
		}

		// Token: 0x1700442D RID: 17453
		// (get) Token: 0x060085EF RID: 34287 RVA: 0x007C26E0 File Offset: 0x007C08E0
		// (set) Token: 0x060085F0 RID: 34288 RVA: 0x007C2794 File Offset: 0x007C0994
		public bool TopFunctionBtnTrkZone_A36944_Editable
		{
			get
			{
				short num = (short)1563022355;
				short num2 = num;
				num = (short)1315689491;
				switch (num2 == num)
				{
				default:
				{
					num = (short)389939200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1957363712;
				if (num != 0)
				{
				}
				num = (short)335806465;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkZone_A36944.Editable;
			}
			set
			{
				short num = (short)1910142844;
				short num2 = num;
				num = (short)1814067068;
				switch (num2 == num)
				{
				default:
				{
					num = (short)169279488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)855048193;
				if (num != 0)
				{
				}
				num = (short)1847001088;
				if (num != 0)
				{
				}
				this.topFunctionBtnTrkZone_A36944.Editable = value;
			}
		}

		// Token: 0x1700442E RID: 17454
		// (get) Token: 0x060085F1 RID: 34289 RVA: 0x007C284C File Offset: 0x007C0A4C
		internal string TopFunctionBtnTrkZone_A36944_UILabel
		{
			get
			{
				short num = (short)387171289;
				short num2 = num;
				num = (short)886227929;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1813643264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)585236481;
				if (num != 0)
				{
				}
				num = (short)779943936;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkZone_A36944.UIName;
			}
		}

		// Token: 0x1700442F RID: 17455
		// (get) Token: 0x060085F2 RID: 34290 RVA: 0x007C2900 File Offset: 0x007C0B00
		// (set) Token: 0x060085F3 RID: 34291 RVA: 0x007C29B8 File Offset: 0x007C0BB8
		internal bool TopFunctionBtnTrkZone_A36944_HiddenStatic
		{
			get
			{
				short num = (short)559997918;
				short num2 = num;
				num = (short)1981670366;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2046820352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1945108480;
				if (num != 0)
				{
				}
				num = (short)1892941825;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkZone_A36944.HiddenStatic;
			}
			set
			{
				short num = (short)1317919598;
				short num2 = num;
				num = (short)278977390;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1325531136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1678704641;
				if (num != 0)
				{
				}
				num = (short)1610547200;
				if (num != 0)
				{
				}
				this.topFunctionBtnTrkZone_A36944.HiddenStatic = value;
			}
		}

		// Token: 0x17004430 RID: 17456
		// (get) Token: 0x060085F4 RID: 34292 RVA: 0x007C2A6C File Offset: 0x007C0C6C
		// (set) Token: 0x060085F5 RID: 34293 RVA: 0x007C2B20 File Offset: 0x007C0D20
		internal bool TopFunctionBtnTrkZone_A36944_HiddenDynamic
		{
			get
			{
				short num = (short)1837442032;
				short num2 = num;
				num = (short)177349616;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2055733248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1392115712;
				if (num != 0)
				{
				}
				num = (short)629932033;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkZone_A36944.HiddenDynamic;
			}
			set
			{
				short num = (short)1451167553;
				short num2 = num;
				num = (short)1924730689;
				switch (num2 == num)
				{
				default:
				{
					num = (short)653328384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1386348545;
				if (num != 0)
				{
				}
				num = (short)276299776;
				if (num != 0)
				{
				}
				this.topFunctionBtnTrkZone_A36944.HiddenDynamic = value;
			}
		}

		// Token: 0x17004431 RID: 17457
		// (get) Token: 0x060085F6 RID: 34294 RVA: 0x007C2BD4 File Offset: 0x007C0DD4
		public bool TopFunctionBtnTrkZone_A36944_HasDiffs
		{
			get
			{
				short num = (short)811750800;
				short num2 = num;
				num = (short)770266512;
				switch (num2 == num)
				{
				default:
				{
					num = (short)184614912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)751828992;
				if (num != 0)
				{
				}
				num = (short)1453457409;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkZone_A36944._HasDiffs;
			}
		}

		// Token: 0x17004432 RID: 17458
		// (get) Token: 0x060085F7 RID: 34295 RVA: 0x007C2C88 File Offset: 0x007C0E88
		// (set) Token: 0x060085F8 RID: 34296 RVA: 0x007C2D3C File Offset: 0x007C0F3C
		public int TopFunctionBtnTrkChannel_A36945Value
		{
			get
			{
				short num = (short)438545022;
				short num2 = num;
				num = (short)1985653374;
				switch (num2 == num)
				{
				default:
				{
					num = (short)258080768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1069678592;
				if (num != 0)
				{
				}
				num = (short)1926496257;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkChannel_A36945.Value;
			}
			set
			{
				short num = (short)1599866932;
				short num2 = num;
				num = (short)1062471732;
				switch (num2 == num)
				{
				default:
				{
					num = (short)599588864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1514340352;
				if (num != 0)
				{
				}
				num = (short)882245633;
				if (num != 0)
				{
				}
				this.topFunctionBtnTrkChannel_A36945.Value = value;
			}
		}

		// Token: 0x17004433 RID: 17459
		// (get) Token: 0x060085F9 RID: 34297 RVA: 0x007C2DF0 File Offset: 0x007C0FF0
		// (set) Token: 0x060085FA RID: 34298 RVA: 0x007C2EA4 File Offset: 0x007C10A4
		public string TopFunctionBtnTrkChannel_A36945_UIValue
		{
			get
			{
				short num = (short)784596993;
				if (num != 0)
				{
				}
				num = (short)976879616;
				short num2 = num;
				num = (short)311334518;
				short num3 = num;
				num = (short)1458869878;
				switch (num3 == num)
				{
				}
				num = (short)1762459648;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkChannel_A36945.UIValue;
			}
			set
			{
				short num = (short)1391788033;
				if (num != 0)
				{
				}
				num = (short)811728896;
				short num2 = num;
				num = (short)1031922922;
				short num3 = num;
				num = (short)626124010;
				switch (num3 == num)
				{
				}
				num = (short)1913323520;
				if (num != 0)
				{
				}
				this.topFunctionBtnTrkChannel_A36945.UIValue = value;
			}
		}

		// Token: 0x17004434 RID: 17460
		// (get) Token: 0x060085FB RID: 34299 RVA: 0x007C2F58 File Offset: 0x007C1158
		public global::AcpBusinessLayer.AcpRecRefField TopFunctionBtnTrkChannel_A36945
		{
			get
			{
				short num = (short)235318776;
				short num2 = num;
				num = (short)517975544;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1305739264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)523501569;
				if (num != 0)
				{
				}
				num = (short)490864640;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkChannel_A36945;
			}
		}

		// Token: 0x17004435 RID: 17461
		// (get) Token: 0x060085FC RID: 34300 RVA: 0x007C3008 File Offset: 0x007C1208
		// (set) Token: 0x060085FD RID: 34301 RVA: 0x007C30BC File Offset: 0x007C12BC
		public bool TopFunctionBtnTrkChannel_A36945_Applicable
		{
			get
			{
				short num = (short)1476852718;
				short num2 = num;
				num = (short)1137114094;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1700331520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)586743809;
				if (num != 0)
				{
				}
				num = (short)1304035328;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkChannel_A36945.Applicable;
			}
			set
			{
				short num = (short)1328524519;
				short num2 = num;
				num = (short)408726759;
				switch (num2 == num)
				{
				default:
				{
					num = (short)29622272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1164247041;
				if (num != 0)
				{
				}
				num = (short)24969216;
				if (num != 0)
				{
				}
				this.topFunctionBtnTrkChannel_A36945.Applicable = value;
			}
		}

		// Token: 0x17004436 RID: 17462
		// (get) Token: 0x060085FE RID: 34302 RVA: 0x007C3170 File Offset: 0x007C1370
		// (set) Token: 0x060085FF RID: 34303 RVA: 0x007C3228 File Offset: 0x007C1428
		public bool TopFunctionBtnTrkChannel_A36945_Valid
		{
			get
			{
				short num = (short)1454818494;
				short num2 = num;
				num = (short)341427390;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1884291072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1739587584;
				if (num != 0)
				{
				}
				num = (short)638910465;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkChannel_A36945.Valid;
			}
			set
			{
				short num = (short)2074542081;
				if (num != 0)
				{
				}
				num = (short)484638720;
				short num2 = num;
				num = (short)1175182178;
				short num3 = num;
				num = (short)1696389986;
				switch (num3 == num)
				{
				}
				num = (short)1430847488;
				if (num != 0)
				{
				}
				this.topFunctionBtnTrkChannel_A36945.Valid = value;
			}
		}

		// Token: 0x17004437 RID: 17463
		// (get) Token: 0x06008600 RID: 34304 RVA: 0x007C32DC File Offset: 0x007C14DC
		// (set) Token: 0x06008601 RID: 34305 RVA: 0x007C3390 File Offset: 0x007C1590
		public bool TopFunctionBtnTrkChannel_A36945_Visible
		{
			get
			{
				short num = (short)1945179170;
				short num2 = num;
				num = (short)1677726754;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1359347712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)345178113;
				if (num != 0)
				{
				}
				num = (short)493355008;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkChannel_A36945.Visible;
			}
			set
			{
				short num = (short)221898631;
				short num2 = num;
				num = (short)1414195079;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1253834752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)505544705;
				if (num != 0)
				{
				}
				num = (short)1565392896;
				if (num != 0)
				{
				}
				this.topFunctionBtnTrkChannel_A36945.Visible = value;
			}
		}

		// Token: 0x17004438 RID: 17464
		// (get) Token: 0x06008602 RID: 34306 RVA: 0x007C3448 File Offset: 0x007C1648
		// (set) Token: 0x06008603 RID: 34307 RVA: 0x007C34F8 File Offset: 0x007C16F8
		public bool TopFunctionBtnTrkChannel_A36945_Editable
		{
			get
			{
				short num = (short)2106464939;
				short num2 = num;
				num = (short)308353707;
				switch (num2 == num)
				{
				default:
				{
					num = (short)574226432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)68616193;
				if (num != 0)
				{
				}
				num = (short)1709309952;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkChannel_A36945.Editable;
			}
			set
			{
				short num = (short)1839063391;
				short num2 = num;
				num = (short)1784144223;
				switch (num2 == num)
				{
				default:
				{
					num = (short)470745088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1237516288;
				if (num != 0)
				{
				}
				num = (short)710606849;
				if (num != 0)
				{
				}
				this.topFunctionBtnTrkChannel_A36945.Editable = value;
			}
		}

		// Token: 0x17004439 RID: 17465
		// (get) Token: 0x06008604 RID: 34308 RVA: 0x007C35B0 File Offset: 0x007C17B0
		internal string TopFunctionBtnTrkChannel_A36945_UILabel
		{
			get
			{
				short num = (short)633018118;
				short num2 = num;
				num = (short)1735071494;
				switch (num2 == num)
				{
				default:
				{
					num = (short)641466368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)300679169;
				if (num != 0)
				{
				}
				num = (short)676593664;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkChannel_A36945.UIName;
			}
		}

		// Token: 0x1700443A RID: 17466
		// (get) Token: 0x06008605 RID: 34309 RVA: 0x007C3668 File Offset: 0x007C1868
		// (set) Token: 0x06008606 RID: 34310 RVA: 0x007C3720 File Offset: 0x007C1920
		internal bool TopFunctionBtnTrkChannel_A36945_HiddenStatic
		{
			get
			{
				short num = (short)2064121857;
				if (num != 0)
				{
				}
				num = (short)2128609280;
				short num2 = num;
				num = (short)639615887;
				short num3 = num;
				num = (short)319275919;
				switch (num3 == num)
				{
				}
				num = (short)1698693120;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkChannel_A36945.HiddenStatic;
			}
			set
			{
				short num = (short)506319488;
				short num2 = num;
				num = (short)1077269120;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1576402944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1790902273;
				if (num != 0)
				{
				}
				num = (short)1860042752;
				if (num != 0)
				{
				}
				this.topFunctionBtnTrkChannel_A36945.HiddenStatic = value;
			}
		}

		// Token: 0x1700443B RID: 17467
		// (get) Token: 0x06008607 RID: 34311 RVA: 0x007C37D8 File Offset: 0x007C19D8
		// (set) Token: 0x06008608 RID: 34312 RVA: 0x007C388C File Offset: 0x007C1A8C
		internal bool TopFunctionBtnTrkChannel_A36945_HiddenDynamic
		{
			get
			{
				short num = (short)1122327307;
				short num2 = num;
				num = (short)161110795;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2129264640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1158348801;
				if (num != 0)
				{
				}
				num = (short)2055274496;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkChannel_A36945.HiddenDynamic;
			}
			set
			{
				short num = (short)1157149429;
				short num2 = num;
				num = (short)2097787637;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1736507392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)960495617;
				if (num != 0)
				{
				}
				num = (short)1049952256;
				if (num != 0)
				{
				}
				this.topFunctionBtnTrkChannel_A36945.HiddenDynamic = value;
			}
		}

		// Token: 0x1700443C RID: 17468
		// (get) Token: 0x06008609 RID: 34313 RVA: 0x007C3940 File Offset: 0x007C1B40
		public bool TopFunctionBtnTrkChannel_A36945_HasDiffs
		{
			get
			{
				short num = (short)992274339;
				short num2 = num;
				num = (short)1764026275;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1084555264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)454230017;
				if (num != 0)
				{
				}
				num = (short)712114176;
				if (num != 0)
				{
				}
				return this.topFunctionBtnTrkChannel_A36945._HasDiffs;
			}
		}

		// Token: 0x1700443D RID: 17469
		// (get) Token: 0x0600860A RID: 34314 RVA: 0x007C39F0 File Offset: 0x007C1BF0
		// (set) Token: 0x0600860B RID: 34315 RVA: 0x007C3AA0 File Offset: 0x007C1CA0
		public int O9CHCnvTopFunctionButtonFeature_A36629Value
		{
			get
			{
				short num = (short)1906897196;
				short num2 = num;
				num = (short)1562177836;
				switch (num2 == num)
				{
				default:
				{
					num = (short)36438016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)985858048;
				if (num != 0)
				{
				}
				num = (short)2105278465;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonFeature_A36629.Value;
			}
			set
			{
				short num = (short)1823080449;
				if (num != 0)
				{
				}
				num = (short)46596096;
				short num2 = num;
				num = (short)25142976;
				short num3 = num;
				num = (short)2124195520;
				switch (num3 == num)
				{
				}
				num = (short)231014400;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonFeature_A36629.Value = value;
			}
		}

		// Token: 0x1700443E RID: 17470
		// (get) Token: 0x0600860C RID: 34316 RVA: 0x007C3B54 File Offset: 0x007C1D54
		// (set) Token: 0x0600860D RID: 34317 RVA: 0x007C3C08 File Offset: 0x007C1E08
		public string O9CHCnvTopFunctionButtonFeature_A36629_UIValue
		{
			get
			{
				short num = (short)1914830848;
				short num2 = num;
				num = (short)1941338564;
				short num3 = num;
				num = (short)1757641156;
				switch (num3 == num)
				{
				}
				num = (short)20709377;
				if (num != 0)
				{
				}
				num = (short)667090944;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonFeature_A36629.UIValue;
			}
			set
			{
				short num = (short)58130432;
				short num2 = num;
				num = (short)1426369826;
				short num3 = num;
				num = (short)48082210;
				switch (num3 == num)
				{
				}
				num = (short)156696577;
				if (num != 0)
				{
				}
				num = (short)1375010816;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonFeature_A36629.UIValue = value;
			}
		}

		// Token: 0x1700443F RID: 17471
		// (get) Token: 0x0600860E RID: 34318 RVA: 0x007C3CC0 File Offset: 0x007C1EC0
		public global::AcpBusinessLayer.AcpListField O9CHCnvTopFunctionButtonFeature_A36629
		{
			get
			{
				short num = (short)1184825344;
				short num2 = num;
				num = (short)658411795;
				short num3 = num;
				num = (short)62820627;
				switch (num3 == num)
				{
				}
				num = (short)1443037185;
				if (num != 0)
				{
				}
				num = (short)815923200;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonFeature_A36629;
			}
		}

		// Token: 0x17004440 RID: 17472
		// (get) Token: 0x0600860F RID: 34319 RVA: 0x007C3D70 File Offset: 0x007C1F70
		// (set) Token: 0x06008610 RID: 34320 RVA: 0x007C3E28 File Offset: 0x007C2028
		public bool O9CHCnvTopFunctionButtonFeature_A36629_Applicable
		{
			get
			{
				short num = (short)1978662912;
				short num2 = num;
				num = (short)292521879;
				short num3 = num;
				num = (short)96110487;
				switch (num3 == num)
				{
				}
				num = (short)1732116481;
				if (num != 0)
				{
				}
				num = (short)928710656;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonFeature_A36629.Applicable;
			}
			set
			{
				short num = (short)463405056;
				short num2 = num;
				num = (short)1771495329;
				short num3 = num;
				num = (short)1158602657;
				switch (num3 == num)
				{
				}
				num = (short)1237123073;
				if (num != 0)
				{
				}
				num = (short)1493893120;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonFeature_A36629.Applicable = value;
			}
		}

		// Token: 0x17004441 RID: 17473
		// (get) Token: 0x06008611 RID: 34321 RVA: 0x007C3EDC File Offset: 0x007C20DC
		// (set) Token: 0x06008612 RID: 34322 RVA: 0x007C3F90 File Offset: 0x007C2190
		public bool O9CHCnvTopFunctionButtonFeature_A36629_Valid
		{
			get
			{
				short num = (short)1372585984;
				short num2 = num;
				num = (short)1145517494;
				short num3 = num;
				num = (short)1450456502;
				switch (num3 == num)
				{
				}
				num = (short)1458307073;
				if (num != 0)
				{
				}
				num = (short)67371008;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonFeature_A36629.Valid;
			}
			set
			{
				short num = (short)959709184;
				short num2 = num;
				num = (short)908208883;
				short num3 = num;
				num = (short)1798056691;
				switch (num3 == num)
				{
				}
				num = (short)1418592256;
				if (num != 0)
				{
				}
				num = (short)784531457;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonFeature_A36629.Valid = value;
			}
		}

		// Token: 0x17004442 RID: 17474
		// (get) Token: 0x06008613 RID: 34323 RVA: 0x007C4044 File Offset: 0x007C2244
		// (set) Token: 0x06008614 RID: 34324 RVA: 0x007C40F8 File Offset: 0x007C22F8
		public bool O9CHCnvTopFunctionButtonFeature_A36629_Visible
		{
			get
			{
				short num = (short)1255473152;
				short num2 = num;
				num = (short)120340174;
				short num3 = num;
				num = (short)322977486;
				switch (num3 == num)
				{
				}
				num = (short)1436483585;
				if (num != 0)
				{
				}
				num = (short)1055260672;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonFeature_A36629.Visible;
			}
			set
			{
				short num = (short)470351872;
				short num2 = num;
				num = (short)259575111;
				short num3 = num;
				num = (short)116247879;
				switch (num3 == num)
				{
				}
				num = (short)811859969;
				if (num != 0)
				{
				}
				num = (short)649068544;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonFeature_A36629.Visible = value;
			}
		}

		// Token: 0x17004443 RID: 17475
		// (get) Token: 0x06008615 RID: 34325 RVA: 0x007C41AC File Offset: 0x007C23AC
		// (set) Token: 0x06008616 RID: 34326 RVA: 0x007C4260 File Offset: 0x007C2460
		public bool O9CHCnvTopFunctionButtonFeature_A36629_Editable
		{
			get
			{
				short num = (short)1744371712;
				short num2 = num;
				num = (short)90675611;
				short num3 = num;
				num = (short)1688443291;
				switch (num3 == num)
				{
				}
				num = (short)499187712;
				if (num != 0)
				{
				}
				num = (short)1459748865;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonFeature_A36629.Editable;
			}
			set
			{
				short num = (short)59113472;
				short num2 = num;
				num = (short)1908549051;
				short num3 = num;
				num = (short)1741628859;
				switch (num3 == num)
				{
				}
				num = (short)988741632;
				if (num != 0)
				{
				}
				num = (short)317259777;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonFeature_A36629.Editable = value;
			}
		}

		// Token: 0x17004444 RID: 17476
		// (get) Token: 0x06008617 RID: 34327 RVA: 0x007C4314 File Offset: 0x007C2514
		internal string O9CHCnvTopFunctionButtonFeature_A36629_UILabel
		{
			get
			{
				short num = (short)1815609344;
				short num2 = num;
				num = (short)2084188354;
				short num3 = num;
				num = (short)1126052034;
				switch (num3 == num)
				{
				}
				num = (short)1138229248;
				if (num != 0)
				{
				}
				num = (short)2065563649;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonFeature_A36629.UIName;
			}
		}

		// Token: 0x17004445 RID: 17477
		// (get) Token: 0x06008618 RID: 34328 RVA: 0x007C43C4 File Offset: 0x007C25C4
		// (set) Token: 0x06008619 RID: 34329 RVA: 0x007C447C File Offset: 0x007C267C
		internal bool O9CHCnvTopFunctionButtonFeature_A36629_HiddenStatic
		{
			get
			{
				short num = (short)1106837504;
				short num2 = num;
				num = (short)322186457;
				short num3 = num;
				num = (short)1611017433;
				switch (num3 == num)
				{
				}
				num = (short)1535574017;
				if (num != 0)
				{
				}
				num = (short)1997340672;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonFeature_A36629.HiddenStatic;
			}
			set
			{
				short num = (short)893059072;
				short num2 = num;
				num = (short)749993985;
				if (num != 0)
				{
				}
				num = (short)1323178949;
				short num3 = num;
				num = (short)135207877;
				switch (num3 == num)
				{
				}
				num = (short)299630592;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonFeature_A36629.HiddenStatic = value;
			}
		}

		// Token: 0x17004446 RID: 17478
		// (get) Token: 0x0600861A RID: 34330 RVA: 0x007C4530 File Offset: 0x007C2730
		// (set) Token: 0x0600861B RID: 34331 RVA: 0x007C45E4 File Offset: 0x007C27E4
		internal bool O9CHCnvTopFunctionButtonFeature_A36629_HiddenDynamic
		{
			get
			{
				short num = (short)122683392;
				short num2 = num;
				num = (short)1542914049;
				if (num != 0)
				{
				}
				num = (short)1999381271;
				short num3 = num;
				num = (short)338567959;
				switch (num3 == num)
				{
				}
				num = (short)496893952;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonFeature_A36629.HiddenDynamic;
			}
			set
			{
				short num = (short)459538432;
				short num2 = num;
				num = (short)76786363;
				short num3 = num;
				num = (short)2119871163;
				switch (num3 == num)
				{
				}
				num = (short)661127168;
				if (num != 0)
				{
				}
				num = (short)908132353;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonFeature_A36629.HiddenDynamic = value;
			}
		}

		// Token: 0x17004447 RID: 17479
		// (get) Token: 0x0600861C RID: 34332 RVA: 0x007C4698 File Offset: 0x007C2898
		public bool O9CHCnvTopFunctionButtonFeature_A36629_HasDiffs
		{
			get
			{
				short num = (short)1142489088;
				short num2 = num;
				num = (short)1651733734;
				short num3 = num;
				num = (short)1226142950;
				switch (num3 == num)
				{
				}
				num = (short)50790401;
				if (num != 0)
				{
				}
				num = (short)322961408;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonFeature_A36629._HasDiffs;
			}
		}

		// Token: 0x17004448 RID: 17480
		// (get) Token: 0x0600861D RID: 34333 RVA: 0x007C4750 File Offset: 0x007C2950
		// (set) Token: 0x0600861E RID: 34334 RVA: 0x007C4800 File Offset: 0x007C2A00
		public int O9CHTrkTopFunctionButtonFeature_A36637Value
		{
			get
			{
				short num = (short)205389824;
				short num2 = num;
				num = (short)1262780518;
				short num3 = num;
				num = (short)1068269670;
				switch (num3 == num)
				{
				}
				num = (short)327352321;
				if (num != 0)
				{
				}
				num = (short)167641088;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonFeature_A36637.Value;
			}
			set
			{
				short num = (short)1556021248;
				short num2 = num;
				num = (short)1149054243;
				short num3 = num;
				num = (short)417279267;
				switch (num3 == num)
				{
				}
				num = (short)1013841921;
				if (num != 0)
				{
				}
				num = (short)2092826624;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonFeature_A36637.Value = value;
			}
		}

		// Token: 0x17004449 RID: 17481
		// (get) Token: 0x0600861F RID: 34335 RVA: 0x007C48B8 File Offset: 0x007C2AB8
		// (set) Token: 0x06008620 RID: 34336 RVA: 0x007C496C File Offset: 0x007C2B6C
		public string O9CHTrkTopFunctionButtonFeature_A36637_UIValue
		{
			get
			{
				short num = (short)1778909184;
				short num2 = num;
				num = (short)395953557;
				short num3 = num;
				num = (short)476431765;
				switch (num3 == num)
				{
				}
				num = (short)347013121;
				if (num != 0)
				{
				}
				num = (short)1453129728;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonFeature_A36637.UIValue;
			}
			set
			{
				short num = (short)246677504;
				short num2 = num;
				num = (short)45317275;
				short num3 = num;
				num = (short)1120435355;
				switch (num3 == num)
				{
				}
				num = (short)1148190720;
				if (num != 0)
				{
				}
				num = (short)1904934913;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonFeature_A36637.UIValue = value;
			}
		}

		// Token: 0x1700444A RID: 17482
		// (get) Token: 0x06008621 RID: 34337 RVA: 0x007C4A24 File Offset: 0x007C2C24
		public global::AcpBusinessLayer.AcpListField O9CHTrkTopFunctionButtonFeature_A36637
		{
			get
			{
				short num = (short)796917760;
				short num2 = num;
				num = (short)562964077;
				short num3 = num;
				num = (short)727721581;
				switch (num3 == num)
				{
				}
				num = (short)1054081024;
				if (num != 0)
				{
				}
				num = (short)1506148353;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonFeature_A36637;
			}
		}

		// Token: 0x1700444B RID: 17483
		// (get) Token: 0x06008622 RID: 34338 RVA: 0x007C4AD0 File Offset: 0x007C2CD0
		// (set) Token: 0x06008623 RID: 34339 RVA: 0x007C4B84 File Offset: 0x007C2D84
		public bool O9CHTrkTopFunctionButtonFeature_A36637_Applicable
		{
			get
			{
				short num = (short)407109632;
				short num2 = num;
				num = (short)2047672321;
				if (num != 0)
				{
				}
				num = (short)1883715022;
				short num3 = num;
				num = (short)2048341454;
				switch (num3 == num)
				{
				}
				num = (short)500105216;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonFeature_A36637.Applicable;
			}
			set
			{
				short num = (short)289210368;
				short num2 = num;
				num = (short)2098786236;
				short num3 = num;
				num = (short)642248636;
				switch (num3 == num)
				{
				}
				num = (short)1583218689;
				if (num != 0)
				{
				}
				num = (short)865992704;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonFeature_A36637.Applicable = value;
			}
		}

		// Token: 0x1700444C RID: 17484
		// (get) Token: 0x06008624 RID: 34340 RVA: 0x007C4C38 File Offset: 0x007C2E38
		// (set) Token: 0x06008625 RID: 34341 RVA: 0x007C4CEC File Offset: 0x007C2EEC
		public bool O9CHTrkTopFunctionButtonFeature_A36637_Valid
		{
			get
			{
				short num = (short)361562112;
				short num2 = num;
				num = (short)391617412;
				short num3 = num;
				num = (short)613260164;
				switch (num3 == num)
				{
				}
				num = (short)1539244032;
				if (num != 0)
				{
				}
				num = (short)1321861121;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonFeature_A36637.Valid;
			}
			set
			{
				short num = (short)1149042688;
				short num2 = num;
				num = (short)606033880;
				short num3 = num;
				num = (short)1232558040;
				switch (num3 == num)
				{
				}
				num = (short)592117761;
				if (num != 0)
				{
				}
				num = (short)1197146112;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonFeature_A36637.Valid = value;
			}
		}

		// Token: 0x1700444D RID: 17485
		// (get) Token: 0x06008626 RID: 34342 RVA: 0x007C4DA4 File Offset: 0x007C2FA4
		// (set) Token: 0x06008627 RID: 34343 RVA: 0x007C4E58 File Offset: 0x007C3058
		public bool O9CHTrkTopFunctionButtonFeature_A36637_Visible
		{
			get
			{
				short num = (short)943325184;
				short num2 = num;
				num = (short)1903017229;
				short num3 = num;
				num = (short)1873460493;
				switch (num3 == num)
				{
				}
				num = (short)1821966337;
				if (num != 0)
				{
				}
				num = (short)1469972480;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonFeature_A36637.Visible;
			}
			set
			{
				short num = (short)784203776;
				short num2 = num;
				num = (short)1719645164;
				short num3 = num;
				num = (short)1918022636;
				switch (num3 == num)
				{
				}
				num = (short)2137456641;
				if (num != 0)
				{
				}
				num = (short)1566113792;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonFeature_A36637.Visible = value;
			}
		}

		// Token: 0x1700444E RID: 17486
		// (get) Token: 0x06008628 RID: 34344 RVA: 0x007C4F0C File Offset: 0x007C310C
		// (set) Token: 0x06008629 RID: 34345 RVA: 0x007C4FC0 File Offset: 0x007C31C0
		public bool O9CHTrkTopFunctionButtonFeature_A36637_Editable
		{
			get
			{
				short num = (short)1936523264;
				short num2 = num;
				num = (short)1074327896;
				short num3 = num;
				num = (short)1134227800;
				switch (num3 == num)
				{
				}
				num = (short)1498152961;
				if (num != 0)
				{
				}
				num = (short)50790400;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonFeature_A36637.Editable;
			}
			set
			{
				short num = (short)1437401088;
				short num2 = num;
				num = (short)1981647059;
				short num3 = num;
				num = (short)1484949715;
				switch (num3 == num)
				{
				}
				num = (short)1765015552;
				if (num != 0)
				{
				}
				num = (short)196870145;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonFeature_A36637.Editable = value;
			}
		}

		// Token: 0x1700444F RID: 17487
		// (get) Token: 0x0600862A RID: 34346 RVA: 0x007C5078 File Offset: 0x007C3278
		internal string O9CHTrkTopFunctionButtonFeature_A36637_UILabel
		{
			get
			{
				short num = (short)1876754432;
				short num2 = num;
				num = (short)883894392;
				short num3 = num;
				num = (short)1231628408;
				switch (num3 == num)
				{
				}
				num = (short)134742017;
				if (num != 0)
				{
				}
				num = (short)241172480;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonFeature_A36637.UIName;
			}
		}

		// Token: 0x17004450 RID: 17488
		// (get) Token: 0x0600862B RID: 34347 RVA: 0x007C5130 File Offset: 0x007C3330
		// (set) Token: 0x0600862C RID: 34348 RVA: 0x007C51E4 File Offset: 0x007C33E4
		internal bool O9CHTrkTopFunctionButtonFeature_A36637_HiddenStatic
		{
			get
			{
				short num = (short)581632000;
				short num2 = num;
				num = (short)1173568588;
				short num3 = num;
				num = (short)1956789324;
				switch (num3 == num)
				{
				}
				num = (short)318701569;
				if (num != 0)
				{
				}
				num = (short)435290112;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonFeature_A36637.HiddenStatic;
			}
			set
			{
				short num = (short)1832648704;
				short num2 = num;
				num = (short)1878269460;
				short num3 = num;
				num = (short)80420372;
				switch (num3 == num)
				{
				}
				num = (short)829227008;
				if (num != 0)
				{
				}
				num = (short)133038081;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonFeature_A36637.HiddenStatic = value;
			}
		}

		// Token: 0x17004451 RID: 17489
		// (get) Token: 0x0600862D RID: 34349 RVA: 0x007C5298 File Offset: 0x007C3498
		// (set) Token: 0x0600862E RID: 34350 RVA: 0x007C5350 File Offset: 0x007C3550
		internal bool O9CHTrkTopFunctionButtonFeature_A36637_HiddenDynamic
		{
			get
			{
				short num = (short)1686896640;
				short num2 = num;
				num = (short)645443279;
				short num3 = num;
				num = (short)1701097167;
				switch (num3 == num)
				{
				}
				num = (short)457965568;
				if (num != 0)
				{
				}
				num = (short)829358081;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonFeature_A36637.HiddenDynamic;
			}
			set
			{
				short num = (short)13959168;
				short num2 = num;
				num = (short)735326394;
				short num3 = num;
				num = (short)464924858;
				switch (num3 == num)
				{
				}
				num = (short)98762753;
				if (num != 0)
				{
				}
				num = (short)1143209984;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonFeature_A36637.HiddenDynamic = value;
			}
		}

		// Token: 0x17004452 RID: 17490
		// (get) Token: 0x0600862F RID: 34351 RVA: 0x007C5408 File Offset: 0x007C3608
		public bool O9CHTrkTopFunctionButtonFeature_A36637_HasDiffs
		{
			get
			{
				short num = (short)444530688;
				short num2 = num;
				num = (short)1942248209;
				short num3 = num;
				num = (short)440163089;
				switch (num3 == num)
				{
				}
				num = (short)314966017;
				if (num != 0)
				{
				}
				num = (short)741605376;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonFeature_A36637._HasDiffs;
			}
		}

		// Token: 0x17004453 RID: 17491
		// (get) Token: 0x06008630 RID: 34352 RVA: 0x007C54BC File Offset: 0x007C36BC
		// (set) Token: 0x06008631 RID: 34353 RVA: 0x007C5570 File Offset: 0x007C3770
		public int O9CHCnvTopFunctionButtonStsMsgIndex_A36781Value
		{
			get
			{
				short num = (short)106823680;
				short num2 = num;
				num = (short)1618412899;
				short num3 = num;
				num = (short)1441334627;
				switch (num3 == num)
				{
				}
				num = (short)257163265;
				if (num != 0)
				{
				}
				num = (short)1020919808;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.Value;
			}
			set
			{
				short num = (short)2008809472;
				short num2 = num;
				num = (short)817323347;
				short num3 = num;
				num = (short)136535379;
				switch (num3 == num)
				{
				}
				num = (short)542834689;
				if (num != 0)
				{
				}
				num = (short)1917321216;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.Value = value;
			}
		}

		// Token: 0x17004454 RID: 17492
		// (get) Token: 0x06008632 RID: 34354 RVA: 0x007C5624 File Offset: 0x007C3824
		public global::AcpBusinessLayer.AcpSimpleRangeField O9CHCnvTopFunctionButtonStsMsgIndex_A36781
		{
			get
			{
				short num = (short)796590080;
				short num2 = num;
				num = (short)1721618006;
				short num3 = num;
				num = (short)1438240342;
				switch (num3 == num)
				{
				}
				num = (short)1493958657;
				if (num != 0)
				{
				}
				num = (short)1979318272;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781;
			}
		}

		// Token: 0x17004455 RID: 17493
		// (get) Token: 0x06008633 RID: 34355 RVA: 0x007C56D8 File Offset: 0x007C38D8
		// (set) Token: 0x06008634 RID: 34356 RVA: 0x007C578C File Offset: 0x007C398C
		public string O9CHCnvTopFunctionButtonStsMsgIndex_A36781_UIValue
		{
			get
			{
				short num = (short)478281728;
				short num2 = num;
				num = (short)238419969;
				if (num != 0)
				{
				}
				num = (short)1982449208;
				short num3 = num;
				num = (short)1324271160;
				switch (num3 == num)
				{
				}
				num = (short)721354752;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.UIValue;
			}
			set
			{
				short num = (short)2130640896;
				short num2 = num;
				num = (short)320831988;
				short num3 = num;
				num = (short)830570996;
				switch (num3 == num)
				{
				}
				num = (short)292487169;
				if (num != 0)
				{
				}
				num = (short)2075066368;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.UIValue = value;
			}
		}

		// Token: 0x17004456 RID: 17494
		// (get) Token: 0x06008635 RID: 34357 RVA: 0x007C5844 File Offset: 0x007C3A44
		// (set) Token: 0x06008636 RID: 34358 RVA: 0x007C58FC File Offset: 0x007C3AFC
		internal int O9CHCnvTopFunctionButtonStsMsgIndex_A36781Min
		{
			get
			{
				short num = (short)1184563200;
				short num2 = num;
				num = (short)238847472;
				short num3 = num;
				num = (short)582452720;
				switch (num3 == num)
				{
				}
				num = (short)1236074497;
				if (num != 0)
				{
				}
				num = (short)694681600;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.Min;
			}
			set
			{
				short num = (short)960823296;
				short num2 = num;
				num = (short)1629490714;
				short num3 = num;
				num = (short)2098073114;
				switch (num3 == num)
				{
				}
				num = (short)2063663105;
				if (num != 0)
				{
				}
				num = (short)2113732608;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.Min = value;
			}
		}

		// Token: 0x17004457 RID: 17495
		// (get) Token: 0x06008637 RID: 34359 RVA: 0x007C59B4 File Offset: 0x007C3BB4
		// (set) Token: 0x06008638 RID: 34360 RVA: 0x007C5A68 File Offset: 0x007C3C68
		internal int O9CHCnvTopFunctionButtonStsMsgIndex_A36781Max
		{
			get
			{
				short num = (short)1901723648;
				short num2 = num;
				num = (short)1202944647;
				short num3 = num;
				num = (short)987396743;
				switch (num3 == num)
				{
				}
				num = (short)1811218433;
				if (num != 0)
				{
				}
				num = (short)1624047616;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.Max;
			}
			set
			{
				short num = (short)930480128;
				short num2 = num;
				num = (short)1716634060;
				short num3 = num;
				num = (short)1673052620;
				switch (num3 == num)
				{
				}
				num = (short)981008385;
				if (num != 0)
				{
				}
				num = (short)1385431040;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.Max = value;
			}
		}

		// Token: 0x17004458 RID: 17496
		// (get) Token: 0x06008639 RID: 34361 RVA: 0x007C5B20 File Offset: 0x007C3D20
		// (set) Token: 0x0600863A RID: 34362 RVA: 0x007C5BD4 File Offset: 0x007C3DD4
		internal int O9CHCnvTopFunctionButtonStsMsgIndex_A36781Step
		{
			get
			{
				short num = (short)1913323520;
				short num2 = num;
				num = (short)1016195561;
				short num3 = num;
				num = (short)2070735337;
				switch (num3 == num)
				{
				}
				num = (short)1166147585;
				if (num != 0)
				{
				}
				num = (short)997064704;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.StepSize;
			}
			set
			{
				short num = (short)887488512;
				short num2 = num;
				num = (short)803189893;
				short num3 = num;
				num = (short)1816835205;
				switch (num3 == num)
				{
				}
				num = (short)213778433;
				if (num != 0)
				{
				}
				num = (short)1731330048;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.StepSize = value;
			}
		}

		// Token: 0x17004459 RID: 17497
		// (get) Token: 0x0600863B RID: 34363 RVA: 0x007C5C88 File Offset: 0x007C3E88
		// (set) Token: 0x0600863C RID: 34364 RVA: 0x007C5D3C File Offset: 0x007C3F3C
		public bool O9CHCnvTopFunctionButtonStsMsgIndex_A36781_Applicable
		{
			get
			{
				short num = (short)868024320;
				short num2 = num;
				num = (short)1952054080;
				short num3 = num;
				num = (short)1476918080;
				switch (num3 == num)
				{
				}
				num = (short)1219624961;
				if (num != 0)
				{
				}
				num = (short)233111552;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.Applicable;
			}
			set
			{
				short num = (short)268894208;
				short num2 = num;
				num = (short)1304338551;
				short num3 = num;
				num = (short)1747099767;
				switch (num3 == num)
				{
				}
				num = (short)505675776;
				if (num != 0)
				{
				}
				num = (short)288030721;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.Applicable = value;
			}
		}

		// Token: 0x1700445A RID: 17498
		// (get) Token: 0x0600863D RID: 34365 RVA: 0x007C5DF0 File Offset: 0x007C3FF0
		// (set) Token: 0x0600863E RID: 34366 RVA: 0x007C5EA4 File Offset: 0x007C40A4
		public bool O9CHCnvTopFunctionButtonStsMsgIndex_A36781_Valid
		{
			get
			{
				short num = (short)1457061888;
				short num2 = num;
				num = (short)1453795269;
				short num3 = num;
				num = (short)1685465029;
				switch (num3 == num)
				{
				}
				num = (short)244449281;
				if (num != 0)
				{
				}
				num = (short)1779826688;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.Valid;
			}
			set
			{
				short num = (short)1644691456;
				short num2 = num;
				num = (short)1000865793;
				if (num != 0)
				{
				}
				num = (short)1445127716;
				short num3 = num;
				num = (short)612558372;
				switch (num3 == num)
				{
				}
				num = (short)792657920;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.Valid = value;
			}
		}

		// Token: 0x1700445B RID: 17499
		// (get) Token: 0x0600863F RID: 34367 RVA: 0x007C5F5C File Offset: 0x007C415C
		// (set) Token: 0x06008640 RID: 34368 RVA: 0x007C6014 File Offset: 0x007C4214
		public bool O9CHCnvTopFunctionButtonStsMsgIndex_A36781_Visible
		{
			get
			{
				short num = (short)1094451200;
				short num2 = num;
				num = (short)508310159;
				short num3 = num;
				num = (short)246100623;
				switch (num3 == num)
				{
				}
				num = (short)1309999104;
				if (num != 0)
				{
				}
				num = (short)510132225;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.Visible;
			}
			set
			{
				short num = (short)1034027008;
				short num2 = num;
				num = (short)2046099457;
				if (num != 0)
				{
				}
				num = (short)1063500416;
				short num3 = num;
				num = (short)1434172032;
				switch (num3 == num)
				{
				}
				num = (short)1062666240;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.Visible = value;
			}
		}

		// Token: 0x1700445C RID: 17500
		// (get) Token: 0x06008641 RID: 34369 RVA: 0x007C60C8 File Offset: 0x007C42C8
		// (set) Token: 0x06008642 RID: 34370 RVA: 0x007C6180 File Offset: 0x007C4380
		public bool O9CHCnvTopFunctionButtonStsMsgIndex_A36781_Editable
		{
			get
			{
				short num = (short)1826750464;
				short num2 = num;
				num = (short)504900503;
				short num3 = num;
				num = (short)2089626519;
				switch (num3 == num)
				{
				}
				num = (short)371654657;
				if (num != 0)
				{
				}
				num = (short)1473773568;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.Editable;
			}
			set
			{
				short num = (short)1303183360;
				short num2 = num;
				num = (short)626600485;
				short num3 = num;
				num = (short)1331505701;
				switch (num3 == num)
				{
				}
				num = (short)22020097;
				if (num != 0)
				{
				}
				num = (short)1858600960;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.Editable = value;
			}
		}

		// Token: 0x1700445D RID: 17501
		// (get) Token: 0x06008643 RID: 34371 RVA: 0x007C6238 File Offset: 0x007C4438
		internal string O9CHCnvTopFunctionButtonStsMsgIndex_A36781_UILabel
		{
			get
			{
				short num = (short)792461312;
				short num2 = num;
				num = (short)2145604438;
				short num3 = num;
				num = (short)17453910;
				switch (num3 == num)
				{
				}
				num = (short)729612289;
				if (num != 0)
				{
				}
				num = (short)1983709184;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.UIName;
			}
		}

		// Token: 0x1700445E RID: 17502
		// (get) Token: 0x06008644 RID: 34372 RVA: 0x007C62EC File Offset: 0x007C44EC
		// (set) Token: 0x06008645 RID: 34373 RVA: 0x007C63A4 File Offset: 0x007C45A4
		internal bool O9CHCnvTopFunctionButtonStsMsgIndex_A36781_HiddenStatic
		{
			get
			{
				short num = (short)1075511296;
				short num2 = num;
				num = (short)438269780;
				short num3 = num;
				num = (short)1937602388;
				switch (num3 == num)
				{
				}
				num = (short)1870725121;
				if (num != 0)
				{
				}
				num = (short)299433984;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.HiddenStatic;
			}
			set
			{
				short num = (short)421199872;
				short num2 = num;
				num = (short)806789462;
				short num3 = num;
				num = (short)1231135062;
				switch (num3 == num)
				{
				}
				num = (short)1915551745;
				if (num != 0)
				{
				}
				num = (short)1510277120;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.HiddenStatic = value;
			}
		}

		// Token: 0x1700445F RID: 17503
		// (get) Token: 0x06008646 RID: 34374 RVA: 0x007C645C File Offset: 0x007C465C
		// (set) Token: 0x06008647 RID: 34375 RVA: 0x007C6510 File Offset: 0x007C4710
		internal bool O9CHCnvTopFunctionButtonStsMsgIndex_A36781_HiddenDynamic
		{
			get
			{
				short num = (short)514850816;
				short num2 = num;
				num = (short)73198610;
				short num3 = num;
				num = (short)2059136018;
				switch (num3 == num)
				{
				}
				num = (short)297926656;
				if (num != 0)
				{
				}
				num = (short)1565982721;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.HiddenDynamic;
			}
			set
			{
				short num = (short)2107410376;
				short num2 = num;
				num = (short)739346376;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1802436608;
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
				num = (short)1087438849;
				if (num != 0)
				{
				}
				this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781.HiddenDynamic = value;
			}
		}

		// Token: 0x17004460 RID: 17504
		// (get) Token: 0x06008648 RID: 34376 RVA: 0x007C65C8 File Offset: 0x007C47C8
		public bool O9CHCnvTopFunctionButtonStsMsgIndex_A36781_HasDiffs
		{
			get
			{
				short num = (short)963999913;
				short num2 = num;
				num = (short)903248041;
				switch (num2 == num)
				{
				default:
				{
					num = (short)121176064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)438960129;
				if (num != 0)
				{
				}
				num = (short)2088960000;
				if (num != 0)
				{
				}
				return this.o9CHCnvTopFunctionButtonStsMsgIndex_A36781._HasDiffs;
			}
		}

		// Token: 0x17004461 RID: 17505
		// (get) Token: 0x06008649 RID: 34377 RVA: 0x007C667C File Offset: 0x007C487C
		// (set) Token: 0x0600864A RID: 34378 RVA: 0x007C6734 File Offset: 0x007C4934
		public int O9CHTrkTopFunctionButtonStsMsgIndex_A36782Value
		{
			get
			{
				short num = (short)1651865351;
				short num2 = num;
				num = (short)1812363015;
				switch (num2 == num)
				{
				default:
				{
					num = (short)847773696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1598816257;
				if (num != 0)
				{
				}
				num = (short)369885184;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.Value;
			}
			set
			{
				short num = (short)826232181;
				short num2 = num;
				num = (short)190205301;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1463812096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1081475072;
				if (num != 0)
				{
				}
				num = (short)1342046209;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.Value = value;
			}
		}

		// Token: 0x17004462 RID: 17506
		// (get) Token: 0x0600864B RID: 34379 RVA: 0x007C67E8 File Offset: 0x007C49E8
		public global::AcpBusinessLayer.AcpSimpleRangeField O9CHTrkTopFunctionButtonStsMsgIndex_A36782
		{
			get
			{
				short num = (short)270812275;
				short num2 = num;
				num = (short)1796424819;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1041104896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1906311168;
				if (num != 0)
				{
				}
				num = (short)1546452993;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782;
			}
		}

		// Token: 0x17004463 RID: 17507
		// (get) Token: 0x0600864C RID: 34380 RVA: 0x007C6898 File Offset: 0x007C4A98
		// (set) Token: 0x0600864D RID: 34381 RVA: 0x007C694C File Offset: 0x007C4B4C
		public string O9CHTrkTopFunctionButtonStsMsgIndex_A36782_UIValue
		{
			get
			{
				short num = (short)995258658;
				short num2 = num;
				num = (short)1292005666;
				switch (num2 == num)
				{
				default:
				{
					num = (short)683343872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)103743489;
				if (num != 0)
				{
				}
				num = (short)1668808704;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.UIValue;
			}
			set
			{
				short num = (short)1536813422;
				short num2 = num;
				num = (short)1676142958;
				switch (num2 == num)
				{
				default:
				{
					num = (short)707067904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)82968577;
				if (num != 0)
				{
				}
				num = (short)791412736;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.UIValue = value;
			}
		}

		// Token: 0x17004464 RID: 17508
		// (get) Token: 0x0600864E RID: 34382 RVA: 0x007C6A04 File Offset: 0x007C4C04
		// (set) Token: 0x0600864F RID: 34383 RVA: 0x007C6AB8 File Offset: 0x007C4CB8
		internal int O9CHTrkTopFunctionButtonStsMsgIndex_A36782Min
		{
			get
			{
				short num = (short)1917386753;
				if (num != 0)
				{
				}
				num = (short)901906432;
				short num2 = num;
				num = (short)1146950317;
				short num3 = num;
				num = (short)297341613;
				switch (num3 == num)
				{
				}
				num = (short)1242300416;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.Min;
			}
			set
			{
				short num = (short)681803273;
				short num2 = num;
				num = (short)1455783433;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1521549312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)273547265;
				if (num != 0)
				{
				}
				num = (short)351141888;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.Min = value;
			}
		}

		// Token: 0x17004465 RID: 17509
		// (get) Token: 0x06008650 RID: 34384 RVA: 0x007C6B70 File Offset: 0x007C4D70
		// (set) Token: 0x06008651 RID: 34385 RVA: 0x007C6C28 File Offset: 0x007C4E28
		internal int O9CHTrkTopFunctionButtonStsMsgIndex_A36782Max
		{
			get
			{
				short num = (short)485813003;
				short num2 = num;
				num = (short)2071784203;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1274806272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)269615105;
				if (num != 0)
				{
				}
				num = (short)1710555136;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.Max;
			}
			set
			{
				short num = (short)1567934470;
				short num2 = num;
				num = (short)1892534278;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2105344000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)278265856;
				if (num != 0)
				{
				}
				num = (short)296943617;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.Max = value;
			}
		}

		// Token: 0x17004466 RID: 17510
		// (get) Token: 0x06008652 RID: 34386 RVA: 0x007C6CDC File Offset: 0x007C4EDC
		// (set) Token: 0x06008653 RID: 34387 RVA: 0x007C6D90 File Offset: 0x007C4F90
		internal int O9CHTrkTopFunctionButtonStsMsgIndex_A36782Step
		{
			get
			{
				short num = (short)1591453016;
				short num2 = num;
				num = (short)816686424;
				switch (num2 == num)
				{
				default:
				{
					num = (short)160301056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)545325057;
				if (num != 0)
				{
				}
				num = (short)1892155392;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.StepSize;
			}
			set
			{
				short num = (short)241964946;
				short num2 = num;
				num = (short)108271506;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1594294272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)989069312;
				if (num != 0)
				{
				}
				num = (short)547618817;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.StepSize = value;
			}
		}

		// Token: 0x17004467 RID: 17511
		// (get) Token: 0x06008654 RID: 34388 RVA: 0x007C6E48 File Offset: 0x007C5048
		// (set) Token: 0x06008655 RID: 34389 RVA: 0x007C6EFC File Offset: 0x007C50FC
		public bool O9CHTrkTopFunctionButtonStsMsgIndex_A36782_Applicable
		{
			get
			{
				short num = (short)1575203343;
				short num2 = num;
				num = (short)1260499471;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1677787136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)634781697;
				if (num != 0)
				{
				}
				num = (short)365232128;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.Applicable;
			}
			set
			{
				short num = (short)2132698859;
				short num2 = num;
				num = (short)176645867;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1199767552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1841823745;
				if (num != 0)
				{
				}
				num = (short)436273152;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.Applicable = value;
			}
		}

		// Token: 0x17004468 RID: 17512
		// (get) Token: 0x06008656 RID: 34390 RVA: 0x007C6FB0 File Offset: 0x007C51B0
		// (set) Token: 0x06008657 RID: 34391 RVA: 0x007C7068 File Offset: 0x007C5268
		public bool O9CHTrkTopFunctionButtonStsMsgIndex_A36782_Valid
		{
			get
			{
				short num = (short)372720545;
				short num2 = num;
				num = (short)1003832225;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1461846016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1533542400;
				if (num != 0)
				{
				}
				num = (short)1970143233;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.Valid;
			}
			set
			{
				short num = (short)1592522410;
				short num2 = num;
				num = (short)510457514;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2144141312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1736966145;
				if (num != 0)
				{
				}
				num = (short)1964376064;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.Valid = value;
			}
		}

		// Token: 0x17004469 RID: 17513
		// (get) Token: 0x06008658 RID: 34392 RVA: 0x007C7124 File Offset: 0x007C5324
		// (set) Token: 0x06008659 RID: 34393 RVA: 0x007C71D8 File Offset: 0x007C53D8
		public bool O9CHTrkTopFunctionButtonStsMsgIndex_A36782_Visible
		{
			get
			{
				short num = (short)686037074;
				short num2 = num;
				num = (short)583931986;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2046885888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)483328001;
				if (num != 0)
				{
				}
				num = (short)1688469504;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.Visible;
			}
			set
			{
				short num = (short)1423293254;
				short num2 = num;
				num = (short)1342225222;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1129512960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1838546944;
				if (num != 0)
				{
				}
				num = (short)1857355777;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.Visible = value;
			}
		}

		// Token: 0x1700446A RID: 17514
		// (get) Token: 0x0600865A RID: 34394 RVA: 0x007C7290 File Offset: 0x007C5490
		// (set) Token: 0x0600865B RID: 34395 RVA: 0x007C7344 File Offset: 0x007C5544
		public bool O9CHTrkTopFunctionButtonStsMsgIndex_A36782_Editable
		{
			get
			{
				short num = (short)350236144;
				short num2 = num;
				num = (short)1588276720;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1322385408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2104754177;
				if (num != 0)
				{
				}
				num = (short)137691136;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.Editable;
			}
			set
			{
				short num = (short)249213339;
				short num2 = num;
				num = (short)959820187;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1121189888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2030108673;
				if (num != 0)
				{
				}
				num = (short)803471360;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.Editable = value;
			}
		}

		// Token: 0x1700446B RID: 17515
		// (get) Token: 0x0600865C RID: 34396 RVA: 0x007C73F8 File Offset: 0x007C55F8
		internal string O9CHTrkTopFunctionButtonStsMsgIndex_A36782_UILabel
		{
			get
			{
				short num = (short)1835728897;
				if (num != 0)
				{
				}
				num = (short)1214513152;
				short num2 = num;
				num = (short)1150460755;
				short num3 = num;
				num = (short)1896784723;
				switch (num3 == num)
				{
				}
				num = (short)1262419968;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.UIName;
			}
		}

		// Token: 0x1700446C RID: 17516
		// (get) Token: 0x0600865D RID: 34397 RVA: 0x007C74AC File Offset: 0x007C56AC
		// (set) Token: 0x0600865E RID: 34398 RVA: 0x007C7564 File Offset: 0x007C5764
		internal bool O9CHTrkTopFunctionButtonStsMsgIndex_A36782_HiddenStatic
		{
			get
			{
				short num = (short)152289740;
				short num2 = num;
				num = (short)1076085196;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1313603584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1191444481;
				if (num != 0)
				{
				}
				num = (short)1667563520;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.HiddenStatic;
			}
			set
			{
				short num = (short)1137120116;
				short num2 = num;
				num = (short)862065524;
				switch (num2 == num)
				{
				default:
				{
					num = (short)213385216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)775684097;
				if (num != 0)
				{
				}
				num = (short)1280704512;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.HiddenStatic = value;
			}
		}

		// Token: 0x1700446D RID: 17517
		// (get) Token: 0x0600865F RID: 34399 RVA: 0x007C761C File Offset: 0x007C581C
		// (set) Token: 0x06008660 RID: 34400 RVA: 0x007C76D0 File Offset: 0x007C58D0
		internal bool O9CHTrkTopFunctionButtonStsMsgIndex_A36782_HiddenDynamic
		{
			get
			{
				short num = (short)1647757715;
				short num2 = num;
				num = (short)127256979;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1264386048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)3014656;
				if (num != 0)
				{
				}
				num = (short)1617494017;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.HiddenDynamic;
			}
			set
			{
				short num = (short)731751087;
				short num2 = num;
				num = (short)1252893359;
				switch (num2 == num)
				{
				default:
				{
					num = (short)987758592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1535836160;
				if (num != 0)
				{
				}
				num = (short)421593089;
				if (num != 0)
				{
				}
				this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782.HiddenDynamic = value;
			}
		}

		// Token: 0x1700446E RID: 17518
		// (get) Token: 0x06008661 RID: 34401 RVA: 0x007C7788 File Offset: 0x007C5988
		public bool O9CHTrkTopFunctionButtonStsMsgIndex_A36782_HasDiffs
		{
			get
			{
				short num = (short)585037289;
				short num2 = num;
				num = (short)318109161;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1882324992;
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
				num = (short)1450639360;
				if (num != 0)
				{
				}
				return this.o9CHTrkTopFunctionButtonStsMsgIndex_A36782._HasDiffs;
			}
		}

		// Token: 0x1700446F RID: 17519
		// (get) Token: 0x06008662 RID: 34402 RVA: 0x007C783C File Offset: 0x007C5A3C
		// (set) Token: 0x06008663 RID: 34403 RVA: 0x007C78F4 File Offset: 0x007C5AF4
		public int O9CHTopFunctionProgrammableButtonShortKeyPressTimeValue
		{
			get
			{
				short num = (short)1742438860;
				short num2 = num;
				num = (short)1841005004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1519910912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)457506817;
				if (num != 0)
				{
				}
				num = (short)1285095424;
				if (num != 0)
				{
				}
				return this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.Value;
			}
			set
			{
				short num = (short)1807217277;
				short num2 = num;
				num = (short)1948840573;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1342177280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1287716865;
				if (num != 0)
				{
				}
				num = (short)1928921088;
				if (num != 0)
				{
				}
				this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.Value = value;
			}
		}

		// Token: 0x17004470 RID: 17520
		// (get) Token: 0x06008664 RID: 34404 RVA: 0x007C79A8 File Offset: 0x007C5BA8
		// (set) Token: 0x06008665 RID: 34405 RVA: 0x007C7A5C File Offset: 0x007C5C5C
		public string O9CHTopFunctionProgrammableButtonShortKeyPressTime_UIValue
		{
			get
			{
				short num = (short)1198556330;
				short num2 = num;
				num = (short)2041414826;
				switch (num2 == num)
				{
				default:
				{
					num = (short)964886528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)829292545;
				if (num != 0)
				{
				}
				num = (short)1326252032;
				if (num != 0)
				{
				}
				return this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.UIValue;
			}
			set
			{
				short num = (short)1482555393;
				if (num != 0)
				{
				}
				num = (short)2062745600;
				short num2 = num;
				num = (short)394976611;
				short num3 = num;
				num = (short)1397742947;
				switch (num3 == num)
				{
				}
				num = (short)945291264;
				if (num != 0)
				{
				}
				this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.UIValue = value;
			}
		}

		// Token: 0x17004471 RID: 17521
		// (get) Token: 0x06008666 RID: 34406 RVA: 0x007C7B14 File Offset: 0x007C5D14
		public global::AcpBusinessLayer.AcpCustomRangeField O9CHTopFunctionProgrammableButtonShortKeyPressTime
		{
			get
			{
				short num = (short)618062780;
				short num2 = num;
				num = (short)1937105852;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1849556992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1218707456;
				if (num != 0)
				{
				}
				num = (short)339214337;
				if (num != 0)
				{
				}
				return this.o9CHTopFunctionProgrammableButtonShortKeyPressTime;
			}
		}

		// Token: 0x17004472 RID: 17522
		// (get) Token: 0x06008667 RID: 34407 RVA: 0x007C7BC4 File Offset: 0x007C5DC4
		// (set) Token: 0x06008668 RID: 34408 RVA: 0x007C7C78 File Offset: 0x007C5E78
		public bool O9CHTopFunctionProgrammableButtonShortKeyPressTime_Applicable
		{
			get
			{
				short num = (short)228942860;
				short num2 = num;
				num = (short)350970892;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2093023232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1247674369;
				if (num != 0)
				{
				}
				num = (short)20381696;
				if (num != 0)
				{
				}
				return this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.Applicable;
			}
			set
			{
				short num = (short)627208512;
				short num2 = num;
				num = (short)805925184;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1907359744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)358154241;
				if (num != 0)
				{
				}
				num = (short)1906114560;
				if (num != 0)
				{
				}
				this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.Applicable = value;
			}
		}

		// Token: 0x17004473 RID: 17523
		// (get) Token: 0x06008669 RID: 34409 RVA: 0x007C7D30 File Offset: 0x007C5F30
		// (set) Token: 0x0600866A RID: 34410 RVA: 0x007C7DE4 File Offset: 0x007C5FE4
		public bool O9CHTopFunctionProgrammableButtonShortKeyPressTime_Valid
		{
			get
			{
				short num = (short)1029588621;
				short num2 = num;
				num = (short)460932749;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1668743168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1295122433;
				if (num != 0)
				{
				}
				num = (short)2115174400;
				if (num != 0)
				{
				}
				return this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.Valid;
			}
			set
			{
				short num = (short)449006990;
				short num2 = num;
				num = (short)986205582;
				switch (num2 == num)
				{
				default:
				{
					num = (short)81330176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)881065985;
				if (num != 0)
				{
				}
				num = (short)1864630272;
				if (num != 0)
				{
				}
				this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.Valid = value;
			}
		}

		// Token: 0x17004474 RID: 17524
		// (get) Token: 0x0600866B RID: 34411 RVA: 0x007C7E98 File Offset: 0x007C6098
		// (set) Token: 0x0600866C RID: 34412 RVA: 0x007C7F50 File Offset: 0x007C6150
		public bool O9CHTopFunctionProgrammableButtonShortKeyPressTime_Visible
		{
			get
			{
				short num = (short)324143852;
				short num2 = num;
				num = (short)1334315756;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1887305728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1309540352;
				if (num != 0)
				{
				}
				num = (short)1578303489;
				if (num != 0)
				{
				}
				return this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.Visible;
			}
			set
			{
				short num = (short)715864186;
				short num2 = num;
				num = (short)924072058;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1371668480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)398655489;
				if (num != 0)
				{
				}
				num = (short)1515126784;
				if (num != 0)
				{
				}
				this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.Visible = value;
			}
		}

		// Token: 0x17004475 RID: 17525
		// (get) Token: 0x0600866D RID: 34413 RVA: 0x007C8004 File Offset: 0x007C6204
		// (set) Token: 0x0600866E RID: 34414 RVA: 0x007C80B8 File Offset: 0x007C62B8
		public bool O9CHTopFunctionProgrammableButtonShortKeyPressTime_Editable
		{
			get
			{
				short num = (short)821938599;
				short num2 = num;
				num = (short)1374079399;
				switch (num2 == num)
				{
				default:
				{
					num = (short)846921728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)210960384;
				if (num != 0)
				{
				}
				num = (short)1033109505;
				if (num != 0)
				{
				}
				return this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.Editable;
			}
			set
			{
				short num = (short)882182500;
				short num2 = num;
				num = (short)7604580;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1656619008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)974782464;
				if (num != 0)
				{
				}
				num = (short)1335820289;
				if (num != 0)
				{
				}
				this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.Editable = value;
			}
		}

		// Token: 0x17004476 RID: 17526
		// (get) Token: 0x0600866F RID: 34415 RVA: 0x007C816C File Offset: 0x007C636C
		internal string O9CHTopFunctionProgrammableButtonShortKeyPressTime_UILabel
		{
			get
			{
				short num = (short)1618991197;
				short num2 = num;
				num = (short)1132255325;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1271726080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1480327169;
				if (num != 0)
				{
				}
				num = (short)1312423936;
				if (num != 0)
				{
				}
				return this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.UIName;
			}
		}

		// Token: 0x17004477 RID: 17527
		// (get) Token: 0x06008670 RID: 34416 RVA: 0x007C8220 File Offset: 0x007C6420
		// (set) Token: 0x06008671 RID: 34417 RVA: 0x007C82D8 File Offset: 0x007C64D8
		internal bool O9CHTopFunctionProgrammableButtonShortKeyPressTime_HiddenStatic
		{
			get
			{
				short num = (short)507172667;
				short num2 = num;
				num = (short)658233147;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1529937920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1584857089;
				if (num != 0)
				{
				}
				num = (short)1578565632;
				if (num != 0)
				{
				}
				return this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)1293287425;
				if (num != 0)
				{
				}
				num = (short)1631911936;
				short num2 = num;
				num = (short)657077884;
				short num3 = num;
				num = (short)2085303932;
				switch (num3 == num)
				{
				}
				num = (short)513343488;
				if (num != 0)
				{
				}
				this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17004478 RID: 17528
		// (get) Token: 0x06008672 RID: 34418 RVA: 0x007C838C File Offset: 0x007C658C
		// (set) Token: 0x06008673 RID: 34419 RVA: 0x007C8440 File Offset: 0x007C6640
		internal bool O9CHTopFunctionProgrammableButtonShortKeyPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)692981813;
				short num2 = num;
				num = (short)1035341877;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2042101760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1189871616;
				if (num != 0)
				{
				}
				num = (short)569769985;
				if (num != 0)
				{
				}
				return this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)595974257;
				short num2 = num;
				num = (short)519100529;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1575813120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1966473217;
				if (num != 0)
				{
				}
				num = (short)1124597760;
				if (num != 0)
				{
				}
				this.o9CHTopFunctionProgrammableButtonShortKeyPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17004479 RID: 17529
		// (get) Token: 0x06008674 RID: 34420 RVA: 0x007C84F8 File Offset: 0x007C66F8
		public bool O9CHTopFunctionProgrammableButtonShortKeyPressTime_HasDiffs
		{
			get
			{
				short num = (short)1003324012;
				short num2 = num;
				num = (short)359563884;
				switch (num2 == num)
				{
				default:
				{
					num = (short)409862144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)538116097;
				if (num != 0)
				{
				}
				num = (short)1947795456;
				if (num != 0)
				{
				}
				return this.o9CHTopFunctionProgrammableButtonShortKeyPressTime._HasDiffs;
			}
		}

		// Token: 0x1700447A RID: 17530
		// (get) Token: 0x06008675 RID: 34421 RVA: 0x007C85AC File Offset: 0x007C67AC
		// (set) Token: 0x06008676 RID: 34422 RVA: 0x007C8668 File Offset: 0x007C6868
		public int O9CHTopFunctionProgrammableButtonLongKeyPressTimeValue
		{
			get
			{
				short num = (short)2071318161;
				short num2 = num;
				num = (short)236965521;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1026621440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)672006145;
				if (num != 0)
				{
				}
				num = (short)899416064;
				if (num != 0)
				{
				}
				return this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.Value;
			}
			set
			{
				short num = (short)867795071;
				short num2 = num;
				num = (short)28475519;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1620770816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1442709505;
				if (num != 0)
				{
				}
				num = (short)1295187968;
				if (num != 0)
				{
				}
				this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.Value = value;
			}
		}

		// Token: 0x1700447B RID: 17531
		// (get) Token: 0x06008677 RID: 34423 RVA: 0x007C871C File Offset: 0x007C691C
		// (set) Token: 0x06008678 RID: 34424 RVA: 0x007C87D0 File Offset: 0x007C69D0
		public string O9CHTopFunctionProgrammableButtonLongKeyPressTime_UIValue
		{
			get
			{
				short num = (short)855331732;
				short num2 = num;
				num = (short)1808552852;
				switch (num2 == num)
				{
				default:
				{
					num = (short)430702592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1883635712;
				if (num != 0)
				{
				}
				num = (short)519372801;
				if (num != 0)
				{
				}
				return this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.UIValue;
			}
			set
			{
				short num = (short)487516150;
				short num2 = num;
				num = (short)1311041526;
				switch (num2 == num)
				{
				default:
				{
					num = (short)295632896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1548746753;
				if (num != 0)
				{
				}
				num = (short)1742536704;
				if (num != 0)
				{
				}
				this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.UIValue = value;
			}
		}

		// Token: 0x1700447C RID: 17532
		// (get) Token: 0x06008679 RID: 34425 RVA: 0x007C8888 File Offset: 0x007C6A88
		public global::AcpBusinessLayer.AcpCustomRangeField O9CHTopFunctionProgrammableButtonLongKeyPressTime
		{
			get
			{
				short num = (short)1408971642;
				short num2 = num;
				num = (short)1103704954;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1481506816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1711276033;
				if (num != 0)
				{
				}
				num = (short)410910720;
				if (num != 0)
				{
				}
				return this.o9CHTopFunctionProgrammableButtonLongKeyPressTime;
			}
		}

		// Token: 0x1700447D RID: 17533
		// (get) Token: 0x0600867A RID: 34426 RVA: 0x007C8934 File Offset: 0x007C6B34
		// (set) Token: 0x0600867B RID: 34427 RVA: 0x007C89E8 File Offset: 0x007C6BE8
		public bool O9CHTopFunctionProgrammableButtonLongKeyPressTime_Applicable
		{
			get
			{
				short num = (short)1026898692;
				short num2 = num;
				num = (short)502872836;
				switch (num2 == num)
				{
				default:
				{
					num = (short)637992960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)634847233;
				if (num != 0)
				{
				}
				num = (short)1958739968;
				if (num != 0)
				{
				}
				return this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.Applicable;
			}
			set
			{
				short num = (short)1610464269;
				short num2 = num;
				num = (short)1691401229;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1204224000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1000800256;
				if (num != 0)
				{
				}
				num = (short)1323827201;
				if (num != 0)
				{
				}
				this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.Applicable = value;
			}
		}

		// Token: 0x1700447E RID: 17534
		// (get) Token: 0x0600867C RID: 34428 RVA: 0x007C8A9C File Offset: 0x007C6C9C
		// (set) Token: 0x0600867D RID: 34429 RVA: 0x007C8B50 File Offset: 0x007C6D50
		public bool O9CHTopFunctionProgrammableButtonLongKeyPressTime_Valid
		{
			get
			{
				short num = (short)1466594150;
				short num2 = num;
				num = (short)1098085222;
				switch (num2 == num)
				{
				}
				num = (short)1522991105;
				if (num != 0)
				{
				}
				num = (short)42205184;
				if (num != 0)
				{
				}
				num = (short)889585664;
				short num3 = num;
				return this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.Valid;
			}
			set
			{
				short num = (short)1757952631;
				short num2 = num;
				num = (short)56506999;
				switch (num2 == num)
				{
				}
				num = (short)1116995585;
				if (num != 0)
				{
				}
				num = (short)1597112320;
				if (num != 0)
				{
				}
				num = (short)29556736;
				short num3 = num;
				this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.Valid = value;
			}
		}

		// Token: 0x1700447F RID: 17535
		// (get) Token: 0x0600867E RID: 34430 RVA: 0x007C8C04 File Offset: 0x007C6E04
		// (set) Token: 0x0600867F RID: 34431 RVA: 0x007C8CB8 File Offset: 0x007C6EB8
		public bool O9CHTopFunctionProgrammableButtonLongKeyPressTime_Visible
		{
			get
			{
				short num = (short)1290790005;
				short num2 = num;
				num = (short)771744885;
				switch (num2 == num)
				{
				}
				num = (short)656932865;
				if (num != 0)
				{
				}
				num = (short)2019950592;
				if (num != 0)
				{
				}
				num = (short)405929984;
				short num3 = num;
				return this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.Visible;
			}
			set
			{
				short num = (short)2080421597;
				short num2 = num;
				num = (short)433174237;
				switch (num2 == num)
				{
				}
				num = (short)1853161473;
				if (num != 0)
				{
				}
				num = (short)1799487488;
				if (num != 0)
				{
				}
				num = (short)1853685760;
				short num3 = num;
				this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.Visible = value;
			}
		}

		// Token: 0x17004480 RID: 17536
		// (get) Token: 0x06008680 RID: 34432 RVA: 0x007C8D6C File Offset: 0x007C6F6C
		// (set) Token: 0x06008681 RID: 34433 RVA: 0x007C8E20 File Offset: 0x007C7020
		public bool O9CHTopFunctionProgrammableButtonLongKeyPressTime_Editable
		{
			get
			{
				short num = (short)88040338;
				short num2 = num;
				num = (short)333144978;
				switch (num2 == num)
				{
				}
				num = (short)490995713;
				if (num != 0)
				{
				}
				num = (short)2108030976;
				if (num != 0)
				{
				}
				num = (short)946470912;
				short num3 = num;
				return this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.Editable;
			}
			set
			{
				short num = (short)1046085633;
				if (num != 0)
				{
				}
				num = (short)871334882;
				short num2 = num;
				num = (short)303006690;
				switch (num2 == num)
				{
				}
				num = (short)902627328;
				if (num != 0)
				{
				}
				num = (short)185663488;
				short num3 = num;
				this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.Editable = value;
			}
		}

		// Token: 0x17004481 RID: 17537
		// (get) Token: 0x06008682 RID: 34434 RVA: 0x007C8ED4 File Offset: 0x007C70D4
		internal string O9CHTopFunctionProgrammableButtonLongKeyPressTime_UILabel
		{
			get
			{
				short num = (short)997195777;
				if (num != 0)
				{
				}
				num = (short)1977786820;
				short num2 = num;
				num = (short)409772484;
				switch (num2 == num)
				{
				}
				num = (short)851574784;
				if (num != 0)
				{
				}
				num = (short)2119434240;
				short num3 = num;
				return this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.UIName;
			}
		}

		// Token: 0x17004482 RID: 17538
		// (get) Token: 0x06008683 RID: 34435 RVA: 0x007C8F88 File Offset: 0x007C7188
		// (set) Token: 0x06008684 RID: 34436 RVA: 0x007C903C File Offset: 0x007C723C
		internal bool O9CHTopFunctionProgrammableButtonLongKeyPressTime_HiddenStatic
		{
			get
			{
				short num = (short)1185284097;
				if (num != 0)
				{
				}
				num = (short)1696889657;
				short num2 = num;
				num = (short)917666617;
				switch (num2 == num)
				{
				}
				num = (short)1620115456;
				if (num != 0)
				{
				}
				num = (short)614072320;
				short num3 = num;
				return this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)784138241;
				if (num != 0)
				{
				}
				num = (short)1313761185;
				short num2 = num;
				num = (short)1563322273;
				switch (num2 == num)
				{
				}
				num = (short)455606272;
				if (num != 0)
				{
				}
				num = (short)241303552;
				short num3 = num;
				this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17004483 RID: 17539
		// (get) Token: 0x06008685 RID: 34437 RVA: 0x007C90F4 File Offset: 0x007C72F4
		// (set) Token: 0x06008686 RID: 34438 RVA: 0x007C91AC File Offset: 0x007C73AC
		internal bool O9CHTopFunctionProgrammableButtonLongKeyPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)847847471;
				short num2 = num;
				num = (short)998907951;
				switch (num2 == num)
				{
				}
				num = (short)1384906752;
				if (num != 0)
				{
				}
				num = (short)1392443393;
				if (num != 0)
				{
				}
				num = (short)1474166784;
				short num3 = num;
				return this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)951581022;
				short num2 = num;
				num = (short)1581709662;
				switch (num2 == num)
				{
				}
				num = (short)1774321664;
				if (num != 0)
				{
				}
				num = (short)722010113;
				if (num != 0)
				{
				}
				num = (short)2007564288;
				short num3 = num;
				this.o9CHTopFunctionProgrammableButtonLongKeyPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17004484 RID: 17540
		// (get) Token: 0x06008687 RID: 34439 RVA: 0x007C9260 File Offset: 0x007C7460
		public bool O9CHTopFunctionProgrammableButtonLongKeyPressTime_HasDiffs
		{
			get
			{
				short num = (short)809373095;
				short num2 = num;
				num = (short)2071268775;
				switch (num2 == num)
				{
				}
				num = (short)859308033;
				if (num != 0)
				{
				}
				num = (short)1846804480;
				if (num != 0)
				{
				}
				num = (short)1746796544;
				short num3 = num;
				return this.o9CHTopFunctionProgrammableButtonLongKeyPressTime._HasDiffs;
			}
		}

		// Token: 0x17004485 RID: 17541
		// (get) Token: 0x06008688 RID: 34440 RVA: 0x007C9314 File Offset: 0x007C7514
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)350020681;
				short num2 = num;
				num = (short)1207297097;
				switch (num2 == num)
				{
				}
				num = (short)730923008;
				if (num != 0)
				{
				}
				num = (short)1251868673;
				if (num != 0)
				{
				}
				num = (short)1691549696;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x17004486 RID: 17542
		// (get) Token: 0x06008689 RID: 34441 RVA: 0x007C93D4 File Offset: 0x007C75D4
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)1210335563;
				short num2 = num;
				num = (short)1248346443;
				switch (num2 == num)
				{
				}
				num = (short)171245568;
				if (num != 0)
				{
				}
				num = (short)168165377;
				if (num != 0)
				{
				}
				num = (short)1958281216;
				short num3 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x0600868A RID: 34442 RVA: 0x007C9490 File Offset: 0x007C7690
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)702611456;
				short num2 = num;
				switch (num3)
				{
				case 0:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)461743697;
					short num4 = num;
					num = (short)1119725137;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_63;
					default:
						num = (short)2023358464;
						if (num != 0)
						{
						}
						num = (short)1538260996;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1828913152;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					goto IL_63;
				case 3:
					num = (short)1285226497;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return result;
				}
				goto IL_4D;
				IL_63:
				num = (short)1758068737;
				if (num != 0)
				{
				}
				if (base.ParentRecset == null)
				{
					break;
				}
				num = (short)1165950979;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_4D:
			result = null;
			num = (short)1250033666;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04003E83 RID: 16003
		private global::AcpBusinessLayer.AcpField<string> cHO9TopFunctionButton_A36618;

		// Token: 0x04003E84 RID: 16004
		private global::AcpBusinessLayer.AcpField<string> cHO9CnvTopFunctionButtonLabelLine1_A36626;

		// Token: 0x04003E85 RID: 16005
		private global::AcpBusinessLayer.AcpField<string> cHO9CnvTopFunctionButtonLabelLine2_A36627;

		// Token: 0x04003E86 RID: 16006
		private global::AcpBusinessLayer.AcpListField cnvTopFunctionButtonBCO_A36628;

		// Token: 0x04003E87 RID: 16007
		private global::AcpBusinessLayer.AcpRecRefField o9CHCnvTopFunctionButtonIndex_A36634;

		// Token: 0x04003E88 RID: 16008
		private global::AcpBusinessLayer.AcpListField o9CHTrkTopFunctionButtonBCO_A36636;

		// Token: 0x04003E89 RID: 16009
		private global::AcpBusinessLayer.AcpSimpleRangeField o9CHTrkTopFunctionButtonIndex_A36639;

		// Token: 0x04003E8A RID: 16010
		private global::AcpBusinessLayer.AcpField<string> cHO9TrkTopFunctionButtonLabelLine1_A36650;

		// Token: 0x04003E8B RID: 16011
		private global::AcpBusinessLayer.AcpField<string> cHO9TrkTopFunctionButtonLabelLine2_A36651;

		// Token: 0x04003E8C RID: 16012
		private global::AcpBusinessLayer.AcpRecRefField topFunctionBtnCnvZone_A36942;

		// Token: 0x04003E8D RID: 16013
		private global::AcpBusinessLayer.AcpRecRefField topFunctionBtnCnvChannel_A36943;

		// Token: 0x04003E8E RID: 16014
		private global::AcpBusinessLayer.AcpRecRefField topFunctionBtnTrkZone_A36944;

		// Token: 0x04003E8F RID: 16015
		private global::AcpBusinessLayer.AcpRecRefField topFunctionBtnTrkChannel_A36945;

		// Token: 0x04003E90 RID: 16016
		private global::AcpBusinessLayer.AcpListField o9CHCnvTopFunctionButtonFeature_A36629;

		// Token: 0x04003E91 RID: 16017
		private global::AcpBusinessLayer.AcpListField o9CHTrkTopFunctionButtonFeature_A36637;

		// Token: 0x04003E92 RID: 16018
		private global::AcpBusinessLayer.AcpSimpleRangeField o9CHCnvTopFunctionButtonStsMsgIndex_A36781;

		// Token: 0x04003E93 RID: 16019
		private global::AcpBusinessLayer.AcpSimpleRangeField o9CHTrkTopFunctionButtonStsMsgIndex_A36782;

		// Token: 0x04003E94 RID: 16020
		private global::AcpBusinessLayer.AcpCustomRangeField o9CHTopFunctionProgrammableButtonShortKeyPressTime;

		// Token: 0x04003E95 RID: 16021
		private global::AcpBusinessLayer.AcpCustomRangeField o9CHTopFunctionProgrammableButtonLongKeyPressTime;
	}
}
