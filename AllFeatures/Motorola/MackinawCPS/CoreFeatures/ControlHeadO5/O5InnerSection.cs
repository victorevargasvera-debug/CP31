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

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO5
{
	// Token: 0x020003B3 RID: 947
	[global::System.Serializable]
	public class O5InnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060088A7 RID: 34983 RVA: 0x007F525C File Offset: 0x007F345C
		public O5InnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060088A8 RID: 34984 RVA: 0x007F5278 File Offset: 0x007F3478
		protected O5InnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060088A9 RID: 34985 RVA: 0x007F5290 File Offset: 0x007F3490
		public override void Init()
		{
			int a_ = 15;
			short num = (short)774766592;
			short num2 = num;
			num = (short)1286923658;
			short num3 = num;
			num = (short)258205066;
			switch (num3 == num)
			{
			}
			num = (short)884539393;
			if (num != 0)
			{
			}
			num = (short)967311360;
			if (num != 0)
			{
			}
			this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753 = new global::AcpBusinessLayer.AcpSparseLOVField(148, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.LOVs.indexCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.LOVs.idCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏏병ꃓꓕ듗鋙맛뿝蓟귡퇣뗥臧跩苫迭鳯믱髳鋵鷷諹駻都擿朁樃爅䜇㼉䄋㬍崏䨑圓縕焗缙稛崝栟怡儣別尧䔩䈫氭䔯䘱䀳夵嘷砹缻焽Ἷ́畃罅罇罉罋", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.LOVs.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753LovStrs);
			this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.DataTransferOrder = -1;
			this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754 = new global::AcpBusinessLayer.AcpSparseLOVField(31, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.LOVs.indexCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.LOVs.idCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754LovStrs), this, global::AllFeatures.CodeplugGuid.b("鏏병ꃓꓕ듗鋙맛뿝蓟귡퇣뗥臧跩苫迭鳯믱髳鋵鷷諹駻都擿朁樃爅䜇㼉䄋㬍崏䨑圓縕焗缙稛崝栟怡儣別尧䔩䈫氭䔯䘱䀳夵嘷簹夻弽㐿㝁㙃⍅ᝇ୉絋睍杏村恓", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.LOVs.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754LovStrs);
			this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.DataTransferOrder = 7;
			this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鏏병ꃓꓕ듗鋙맛뿝蓟귡퇣뗥臧跩苫迭鳯믱髳鋵鷷諹駻都擿朁樃爅䜇㼉䄋㬍崏䨑圓縕焗缙稛崝栟怡儣別尧䔩䈫攭唯䬱欳眵਷ହ഻ܽ猿", a_), global::CommonResources.AcgResources.ID_KEY, 20);
			this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.DataTransferOrder = -1;
			this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_ORANGEBUTTON, this, global::AllFeatures.CodeplugGuid.b("鏏병ꃓꓕ듗鋙맛뿝蓟귡퇣뗥臧跩苫迭鳯믱髳鋵鷷諹駻都擿朁樃爅䜇㼉䄋㬍崏䨑圓縕焗缙稛崝栟怡儣別尧䔩䈫怭儯弱儳椵礷࠹฻ଽ爿牁", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.DataTransferOrder = -1;
			this.radErgCtrlHeadO5ShortKeyPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("ꋏ돑냓鏕꫗뷙鿛ꫝ鋟軡곣菥觧軩ꏫ\udbedꏯ髱鯳蓵賷뇹駻蟽僿瀁愃甅笇帉攋挍甏", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
			this.radErgCtrlHeadO5ShortKeyPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgCtrlHeadO5ShortKeyPressTime.DataTransferOrder = -1;
			((global::AcpBusinessLayer.AcpSimpleRangeField)this.radErgCtrlHeadO5ShortKeyPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.radErgCtrlHeadO5ShortKeyPressTime.ShowHexValue = false;
			this.radErgCtrlHeadO5ShortKeyPressTime.ValidateAcrossRecset = true;
			this.radErgCtrlHeadO5LongKeyPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("ꋏ돑냓鏕꫗뷙鿛ꫝ鋟軡곣菥觧軩ꏫ\udbed볯鷱髳釵돷鿹藻껽狿朁眃甅將按愋欍", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
			this.radErgCtrlHeadO5LongKeyPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgCtrlHeadO5LongKeyPressTime.DataTransferOrder = -1;
			((global::AcpBusinessLayer.AcpSimpleRangeField)this.radErgCtrlHeadO5LongKeyPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.radErgCtrlHeadO5LongKeyPressTime.ShowHexValue = false;
			this.radErgCtrlHeadO5LongKeyPressTime.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鿏", a_);
			base.Id = 10211;
			base.UIName = global::CommonResources.AcgResources.ID_O5;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060088AA RID: 34986 RVA: 0x007F5578 File Offset: 0x007F3778
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)1184169990;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)326326103;
					short num3 = num;
					num = (short)2059032407;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_20D;
					default:
						num = (short)1203765248;
						if (num != 0)
						{
						}
						this.radErgCtrlHeadO5ShortKeyPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("룉귋꫍闏ꃑ돓闕곗꣙냛雝藟菡胣ꧥ\udde7맩蓫臭苯蛱뿳鏵臷꫹軻鯽珿焁倃漅攇漉", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
						this.radErgCtrlHeadO5ShortKeyPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.radErgCtrlHeadO5ShortKeyPressTime.DataTransferOrder = 8;
						((global::AcpBusinessLayer.AcpSimpleRangeField)this.radErgCtrlHeadO5ShortKeyPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
						this.radErgCtrlHeadO5ShortKeyPressTime.ShowHexValue = false;
						this.radErgCtrlHeadO5ShortKeyPressTime.ValidateAcrossRecset = true;
						num = (short)871563265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_22A;
				case 2:
					this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753 = new global::AcpBusinessLayer.AcpSparseLOVField(148, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.LOVs.indexCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.LOVs.idCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753LovStrs), this, global::AllFeatures.CodeplugGuid.b("觉ꋋ뫍ꋏ뻑鳓돕맗뻙鏛돟诡菣裥觧蛩ꗫ胭铯韱蓳鏵雷黹駻都瓿䴁㄃䬅㴇䜉吋䴍砏笑焓瀕嬗则帛欝吟嘡䬣䠥樧弩堫娭弯就瘳电眷改紻༽礿畁煃畅", a_), global::CommonResources.AcgResources.ID_BCO, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.LOVs.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753LovStrs);
					this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.DataTransferOrder = -1;
					goto IL_20D;
				case 3:
					this.radErgCtrlHeadO5LongKeyPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("룉귋꫍闏ꃑ돓闕곗꣙냛雝藟菡胣ꧥ\udde7ꛩ菫胭韯맱釳迵ꣷ裹駻跽珿嘁洃欅洇", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
					this.radErgCtrlHeadO5LongKeyPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgCtrlHeadO5LongKeyPressTime.DataTransferOrder = 9;
					((global::AcpBusinessLayer.AcpSimpleRangeField)this.radErgCtrlHeadO5LongKeyPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.radErgCtrlHeadO5LongKeyPressTime.ShowHexValue = false;
					this.radErgCtrlHeadO5LongKeyPressTime.ValidateAcrossRecset = true;
					num = (short)1121058833;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍闏ꃑ돓闕곗꣙냛雝藟菡胣ꧥ\udde7ꛩ菫胭韯맱釳迵ꣷ裹駻跽珿嘁洃欅洇", a_)))
					{
						num = (short)51970051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5F7;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觉ꋋ뫍ꋏ뻑鳓돕맗뻙鏛돟诡菣裥觧蛩ꗫ胭铯韱蓳鏵雷黹駻都瓿䴁㄃䬅㴇䜉吋䴍砏笑焓瀕嬗则帛欝吟嘡䬣䠥樧弩堫娭弯就爳匵夷丹䤻䰽┿ᵁՃ睅煇絉祋積", a_)))
					{
						num = (short)1652031499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B4;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_86;
					}
					continue;
				case 7:
					goto IL_AB;
				case 8:
					goto IL_3B4;
				case 9:
					num = (short)989396993;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍闏ꃑ돓闕곗꣙냛雝藟菡胣ꧥ\udde7맩蓫臭苯蛱뿳鏵臷꫹軻鯽珿焁倃漅攇漉", a_)))
					{
						num = (short)2037579776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_22A;
				case 10:
					goto IL_505;
				case 11:
				{
					num = (short)1256783872;
					short num4 = num;
					this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754 = new global::AcpBusinessLayer.AcpSparseLOVField(31, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.LOVs.indexCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.LOVs.idCntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754LovStrs), this, global::AllFeatures.CodeplugGuid.b("觉ꋋ뫍ꋏ뻑鳓돕맗뻙鏛돟诡菣裥觧蛩ꗫ胭铯韱蓳鏵雷黹駻都瓿䴁㄃䬅㴇䜉吋䴍砏笑焓瀕嬗则帛欝吟嘡䬣䠥樧弩堫娭弯就爳匵夷丹䤻䰽┿ᵁՃ睅煇絉祋積", a_), global::CommonResources.AcgResources.ID_FEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.LOVs.CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754LovStrs);
					this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.DataTransferOrder = 7;
					num = (short)1983905800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觉ꋋ뫍ꋏ뻑鳓돕맗뻙鏛돟诡菣裥觧蛩ꗫ胭铯韱蓳鏵雷黹駻都瓿䴁㄃䬅㴇䜉吋䴍砏笑焓瀕嬗则帛欝吟嘡䬣䠥挧伩唫焭焯1Գܵķह", a_)))
					{
						num = (short)607911956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_505;
				case 13:
					goto IL_400;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觉ꋋ뫍ꋏ뻑鳓돕맗뻙鏛돟诡菣裥觧蛩ꗫ胭铯韱蓳鏵雷黹駻都瓿䴁㄃䬅㴇䜉吋䴍砏笑焓瀕嬗则帛欝吟嘡䬣䠥昧䬩䄫䬭漯猱سеഷ࠹఻", a_)))
					{
						num = (short)197918739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AB;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("觉ꋋ뫍ꋏ뻑鳓돕맗뻙鏛돟诡菣裥觧蛩ꗫ胭铯韱蓳鏵雷黹駻都瓿䴁㄃䬅㴇䜉吋䴍砏笑焓瀕嬗则帛欝吟嘡䬣䠥樧弩堫娭弯就瘳电眷改紻༽礿畁煃畅", a_)))
					{
						num = (short)1557135362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_400;
				case 16:
					num = (short)1735852050;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_3AF;
				case 18:
					if (producerFields != null)
					{
						num = (short)1364918293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5F7;
				case 19:
					this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_ORANGEBUTTON, this, global::AllFeatures.CodeplugGuid.b("觉ꋋ뫍ꋏ뻑鳓돕맗뻙鏛돟诡菣裥觧蛩ꗫ胭铯韱蓳鏵雷黹駻都瓿䴁㄃䬅㴇䜉吋䴍砏笑焓瀕嬗则帛欝吟嘡䬣䠥昧䬩䄫䬭漯猱سеഷ࠹఻", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.DataTransferOrder = -1;
					num = (short)1214578695;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("觉ꋋ뫍ꋏ뻑鳓돕맗뻙鏛돟诡菣裥觧蛩ꗫ胭铯韱蓳鏵雷黹駻都瓿䴁㄃䬅㴇䜉吋䴍砏笑焓瀕嬗则帛欝吟嘡䬣䠥挧伩唫焭焯1Գܵķह", a_), global::CommonResources.AcgResources.ID_KEY, 20);
					this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.DataTransferOrder = -1;
					num = (short)596705290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					num = (short)1259929615;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_86:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1210056720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_AB:
				num = (short)579993609;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_20D:
				num = (short)590282765;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_22A:
				num = (short)1839923204;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3B4:
				num = (short)961675276;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_400:
				num = (short)1579679749;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_505:
				num = (short)796524558;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3AF:
			IL_5F7:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藉溜", a_);
			base.Id = 10211;
			base.UIName = global::CommonResources.AcgResources.ID_O5;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060088AB RID: 34987 RVA: 0x007F5BB0 File Offset: 0x007F3DB0
		public override void PopulateReferences()
		{
			short num = (short)949354496;
			short num2 = num;
			num = (short)1869494295;
			short num3 = num;
			num = (short)1108293655;
			switch (num3 == num)
			{
			}
			num = (short)925171713;
			if (num != 0)
			{
			}
			num = (short)1381236736;
			if (num != 0)
			{
			}
		}

		// Token: 0x060088AC RID: 34988 RVA: 0x007F5C5C File Offset: 0x007F3E5C
		public override void DropReferences()
		{
			short num = (short)1446445056;
			short num2 = num;
			num = (short)729924138;
			short num3 = num;
			num = (short)371114538;
			switch (num3 == num)
			{
			}
			num = (short)1353449472;
			if (num != 0)
			{
			}
			num = (short)685047809;
			if (num != 0)
			{
			}
		}

		// Token: 0x060088AD RID: 34989 RVA: 0x007F5D08 File Offset: 0x007F3F08
		public override void SetConstraints()
		{
			short num = (short)634716160;
			short num2 = num;
			num = (short)847472070;
			short num3 = num;
			num = (short)1417045446;
			switch (num3 == num)
			{
			}
			num = (short)1639383041;
			if (num != 0)
			{
			}
			num = (short)405798912;
			if (num != 0)
			{
			}
			this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Constraints.ConStandaloneRadioSystemEnableApp);
			this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Constraints.ConControlHeadEmergencyFeaturesSelect);
			this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Constraints.ConSyncOrangeBtn);
			this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x060088AE RID: 34990 RVA: 0x007F5E0C File Offset: 0x007F400C
		public override void SetupDependencies()
		{
			short num = (short)1630928896;
			short num2 = num;
			num = (short)1051737364;
			short num3 = num;
			num = (short)1952398612;
			switch (num3 == num)
			{
			}
			num = (short)1459552256;
			if (num != 0)
			{
			}
			num = (short)1090715649;
			if (num != 0)
			{
			}
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754);
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561.AddDependentObject(this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754);
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550.AddDependentObject(this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754);
			this.RefRadioWide.DualRadio.RadWideDualRadioEmergencyRadio_A42239.AddDependentObject(this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754);
			this.RefRadioWide.Features.RadWideTPSFiregroundEvacuationTone_A7980.AddDependentObject(this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754);
			this.RefRadioWide.Features.RadWideFeaturesChannelFallbackEnable.AddDependentObject(this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754);
		}

		// Token: 0x17004560 RID: 17760
		// (get) Token: 0x060088AF RID: 34991 RVA: 0x007F5F5C File Offset: 0x007F415C
		public bool HasDiffs
		{
			get
			{
				short num = (short)650641408;
				short num2 = num;
				num = (short)206892672;
				short num3 = num;
				num = (short)700837504;
				switch (num3 == num)
				{
				}
				num = (short)879034369;
				if (num != 0)
				{
				}
				num = (short)1949564928;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004561 RID: 17761
		// (get) Token: 0x060088B0 RID: 34992 RVA: 0x007F6010 File Offset: 0x007F4210
		// (set) Token: 0x060088B1 RID: 34993 RVA: 0x007F60C4 File Offset: 0x007F42C4
		public int CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753Value
		{
			get
			{
				short num = (short)1138163712;
				short num2 = num;
				num = (short)1913676248;
				short num3 = num;
				num = (short)1286627800;
				switch (num3 == num)
				{
				}
				num = (short)668336129;
				if (num != 0)
				{
				}
				num = (short)1858011136;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.Value;
			}
			set
			{
				short num = (short)1363148800;
				short num2 = num;
				num = (short)4542198;
				short num3 = num;
				num = (short)2023706358;
				switch (num3 == num)
				{
				}
				num = (short)703135745;
				if (num != 0)
				{
				}
				num = (short)680525824;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.Value = value;
			}
		}

		// Token: 0x17004562 RID: 17762
		// (get) Token: 0x060088B2 RID: 34994 RVA: 0x007F6178 File Offset: 0x007F4378
		// (set) Token: 0x060088B3 RID: 34995 RVA: 0x007F622C File Offset: 0x007F442C
		public string CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753_UIValue
		{
			get
			{
				short num = (short)1418330113;
				if (num != 0)
				{
				}
				num = (short)1121870389;
				short num2 = num;
				num = (short)1123050037;
				switch (num2 == num)
				{
				}
				num = (short)235405312;
				short num3 = num;
				num = (short)1425408000;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.UIValue;
			}
			set
			{
				short num = (short)1713901246;
				short num2 = num;
				num = (short)503647934;
				switch (num2 == num)
				{
				}
				num = (short)1371865089;
				if (num != 0)
				{
				}
				num = (short)166920192;
				short num3 = num;
				num = (short)743374848;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.UIValue = value;
			}
		}

		// Token: 0x17004563 RID: 17763
		// (get) Token: 0x060088B4 RID: 34996 RVA: 0x007F62E0 File Offset: 0x007F44E0
		public global::AcpBusinessLayer.AcpListField CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753
		{
			get
			{
				short num = (short)1411903377;
				short num2 = num;
				num = (short)863825809;
				switch (num2 == num)
				{
				}
				num = (short)1876164608;
				if (num != 0)
				{
				}
				num = (short)782499840;
				short num3 = num;
				num = (short)1912668161;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753;
			}
		}

		// Token: 0x17004564 RID: 17764
		// (get) Token: 0x060088B5 RID: 34997 RVA: 0x007F6390 File Offset: 0x007F4590
		// (set) Token: 0x060088B6 RID: 34998 RVA: 0x007F6448 File Offset: 0x007F4648
		public bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753_Applicable
		{
			get
			{
				short num = (short)1781385723;
				short num2 = num;
				num = (short)1903282683;
				switch (num2 == num)
				{
				}
				num = (short)402849793;
				if (num != 0)
				{
				}
				num = (short)655163392;
				short num3 = num;
				num = (short)590151680;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.Applicable;
			}
			set
			{
				short num = (short)1092604723;
				short num2 = num;
				num = (short)1003737907;
				switch (num2 == num)
				{
				}
				num = (short)1216413696;
				if (num != 0)
				{
				}
				num = (short)482476032;
				short num3 = num;
				num = (short)1745289217;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.Applicable = value;
			}
		}

		// Token: 0x17004565 RID: 17765
		// (get) Token: 0x060088B7 RID: 34999 RVA: 0x007F64FC File Offset: 0x007F46FC
		// (set) Token: 0x060088B8 RID: 35000 RVA: 0x007F65B0 File Offset: 0x007F47B0
		public bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753_Valid
		{
			get
			{
				short num = (short)1764623559;
				short num2 = num;
				num = (short)1887962311;
				switch (num2 == num)
				{
				}
				num = (short)828440576;
				if (num != 0)
				{
				}
				num = (short)459079680;
				short num3 = num;
				num = (short)1014628353;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.Valid;
			}
			set
			{
				short num = (short)1269039225;
				short num2 = num;
				num = (short)1606025337;
				switch (num2 == num)
				{
				}
				num = (short)739508224;
				if (num != 0)
				{
				}
				num = (short)1597046784;
				short num3 = num;
				num = (short)2123169793;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.Valid = value;
			}
		}

		// Token: 0x17004566 RID: 17766
		// (get) Token: 0x060088B9 RID: 35001 RVA: 0x007F6668 File Offset: 0x007F4868
		// (set) Token: 0x060088BA RID: 35002 RVA: 0x007F671C File Offset: 0x007F491C
		public bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753_Visible
		{
			get
			{
				short num = (short)1210511480;
				short num2 = num;
				num = (short)346550392;
				switch (num2 == num)
				{
				}
				num = (short)594870272;
				if (num != 0)
				{
				}
				num = (short)404094976;
				short num3 = num;
				num = (short)1705967617;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.Visible;
			}
			set
			{
				short num = (short)92755177;
				short num2 = num;
				num = (short)1359762665;
				switch (num2 == num)
				{
				}
				num = (short)1590231041;
				if (num != 0)
				{
				}
				num = (short)910491648;
				short num3 = num;
				num = (short)762576896;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.Visible = value;
			}
		}

		// Token: 0x17004567 RID: 17767
		// (get) Token: 0x060088BB RID: 35003 RVA: 0x007F67D4 File Offset: 0x007F49D4
		// (set) Token: 0x060088BC RID: 35004 RVA: 0x007F688C File Offset: 0x007F4A8C
		public bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753_Editable
		{
			get
			{
				short num = (short)907305114;
				short num2 = num;
				num = (short)571826330;
				switch (num2 == num)
				{
				}
				num = (short)54263809;
				if (num != 0)
				{
				}
				num = (short)1563754496;
				short num3 = num;
				num = (short)952893440;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.Editable;
			}
			set
			{
				short num = (short)764201347;
				short num2 = num;
				num = (short)117885315;
				switch (num2 == num)
				{
				}
				num = (short)836960257;
				if (num != 0)
				{
				}
				num = (short)1276772352;
				short num3 = num;
				num = (short)596639744;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.Editable = value;
			}
		}

		// Token: 0x17004568 RID: 17768
		// (get) Token: 0x060088BD RID: 35005 RVA: 0x007F6944 File Offset: 0x007F4B44
		internal string CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753_UILabel
		{
			get
			{
				short num = (short)1030517821;
				short num2 = num;
				num = (short)1918137405;
				switch (num2 == num)
				{
				}
				num = (short)777453569;
				if (num != 0)
				{
				}
				num = (short)2043936768;
				short num3 = num;
				num = (short)118816768;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.UIName;
			}
		}

		// Token: 0x17004569 RID: 17769
		// (get) Token: 0x060088BE RID: 35006 RVA: 0x007F69F8 File Offset: 0x007F4BF8
		// (set) Token: 0x060088BF RID: 35007 RVA: 0x007F6AAC File Offset: 0x007F4CAC
		internal bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753_HiddenStatic
		{
			get
			{
				short num = (short)514565745;
				short num2 = num;
				num = (short)1095738993;
				switch (num2 == num)
				{
				}
				num = (short)1943797761;
				if (num != 0)
				{
				}
				num = (short)1825439744;
				short num3 = num;
				num = (short)1780613120;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.HiddenStatic;
			}
			set
			{
				short num = (short)876847342;
				short num2 = num;
				num = (short)263823598;
				switch (num2 == num)
				{
				}
				num = (short)801046529;
				if (num != 0)
				{
				}
				num = (short)513409024;
				short num3 = num;
				num = (short)833617920;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.HiddenStatic = value;
			}
		}

		// Token: 0x1700456A RID: 17770
		// (get) Token: 0x060088C0 RID: 35008 RVA: 0x007F6B68 File Offset: 0x007F4D68
		// (set) Token: 0x060088C1 RID: 35009 RVA: 0x007F6C20 File Offset: 0x007F4E20
		internal bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753_HiddenDynamic
		{
			get
			{
				short num = (short)1804950609;
				short num2 = num;
				num = (short)1299209297;
				switch (num2 == num)
				{
				}
				num = (short)403570689;
				if (num != 0)
				{
				}
				num = (short)143458304;
				short num3 = num;
				num = (short)1721958400;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.HiddenDynamic;
			}
			set
			{
				short num = (short)1185229463;
				short num2 = num;
				num = (short)1790126743;
				switch (num2 == num)
				{
				}
				num = (short)1317404673;
				if (num != 0)
				{
				}
				num = (short)1673789440;
				short num3 = num;
				num = (short)1900675072;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753.HiddenDynamic = value;
			}
		}

		// Token: 0x1700456B RID: 17771
		// (get) Token: 0x060088C2 RID: 35010 RVA: 0x007F6CD4 File Offset: 0x007F4ED4
		public bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753_HasDiffs
		{
			get
			{
				short num = (short)528424488;
				short num2 = num;
				num = (short)847257128;
				switch (num2 == num)
				{
				}
				num = (short)1139277825;
				if (num != 0)
				{
				}
				num = (short)1653342208;
				short num3 = num;
				num = (short)609288192;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753._HasDiffs;
			}
		}

		// Token: 0x1700456C RID: 17772
		// (get) Token: 0x060088C3 RID: 35011 RVA: 0x007F6D88 File Offset: 0x007F4F88
		// (set) Token: 0x060088C4 RID: 35012 RVA: 0x007F6E3C File Offset: 0x007F503C
		public int CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754Value
		{
			get
			{
				short num = (short)1790648610;
				short num2 = num;
				num = (short)794501410;
				switch (num2 == num)
				{
				}
				num = (short)133431297;
				if (num != 0)
				{
				}
				num = (short)1413939200;
				short num3 = num;
				num = (short)456589312;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value;
			}
			set
			{
				short num = (short)1061207096;
				short num2 = num;
				num = (short)721075256;
				switch (num2 == num)
				{
				}
				num = (short)2049966081;
				if (num != 0)
				{
				}
				num = (short)1442512896;
				short num3 = num;
				num = (short)180486144;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value = value;
			}
		}

		// Token: 0x1700456D RID: 17773
		// (get) Token: 0x060088C5 RID: 35013 RVA: 0x007F6EF4 File Offset: 0x007F50F4
		// (set) Token: 0x060088C6 RID: 35014 RVA: 0x007F6FAC File Offset: 0x007F51AC
		public string CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_UIValue
		{
			get
			{
				short num = (short)1691609173;
				short num2 = num;
				num = (short)1767827541;
				switch (num2 == num)
				{
				}
				num = (short)96862209;
				if (num != 0)
				{
				}
				num = (short)824639488;
				short num3 = num;
				num = (short)631177216;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.UIValue;
			}
			set
			{
				short num = (short)1546100215;
				short num2 = num;
				num = (short)1287953911;
				switch (num2 == num)
				{
				}
				num = (short)588513280;
				if (num != 0)
				{
				}
				num = (short)1959329792;
				short num3 = num;
				num = (short)313262081;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.UIValue = value;
			}
		}

		// Token: 0x1700456E RID: 17774
		// (get) Token: 0x060088C7 RID: 35015 RVA: 0x007F7060 File Offset: 0x007F5260
		public global::AcpBusinessLayer.AcpListField CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754
		{
			get
			{
				short num = (short)976833087;
				short num2 = num;
				num = (short)920472127;
				switch (num2 == num)
				{
				}
				num = (short)1405878273;
				if (num != 0)
				{
				}
				num = (short)500498432;
				short num3 = num;
				num = (short)1305149440;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754;
			}
		}

		// Token: 0x1700456F RID: 17775
		// (get) Token: 0x060088C8 RID: 35016 RVA: 0x007F7114 File Offset: 0x007F5314
		// (set) Token: 0x060088C9 RID: 35017 RVA: 0x007F71C8 File Offset: 0x007F53C8
		public bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_Applicable
		{
			get
			{
				short num = (short)1743802708;
				short num2 = num;
				num = (short)716722516;
				switch (num2 == num)
				{
				}
				num = (short)808845313;
				if (num != 0)
				{
				}
				num = (short)1337065472;
				short num3 = num;
				num = (short)888864768;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Applicable;
			}
			set
			{
				short num = (short)1025948415;
				short num2 = num;
				num = (short)970504959;
				switch (num2 == num)
				{
				}
				num = (short)301465600;
				if (num != 0)
				{
				}
				num = (short)323747840;
				short num3 = num;
				num = (short)284491777;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Applicable = value;
			}
		}

		// Token: 0x17004570 RID: 17776
		// (get) Token: 0x060088CA RID: 35018 RVA: 0x007F727C File Offset: 0x007F547C
		// (set) Token: 0x060088CB RID: 35019 RVA: 0x007F7330 File Offset: 0x007F5530
		public bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_Valid
		{
			get
			{
				short num = (short)32737278;
				short num2 = num;
				num = (short)277448702;
				switch (num2 == num)
				{
				}
				num = (short)1820917761;
				if (num != 0)
				{
				}
				num = (short)1518796800;
				short num3 = num;
				num = (short)1414332416;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Valid;
			}
			set
			{
				short num = (short)2118569140;
				short num2 = num;
				num = (short)1564724404;
				switch (num2 == num)
				{
				}
				num = (short)1637154816;
				if (num != 0)
				{
				}
				num = (short)104792064;
				short num3 = num;
				num = (short)1519779841;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Valid = value;
			}
		}

		// Token: 0x17004571 RID: 17777
		// (get) Token: 0x060088CC RID: 35020 RVA: 0x007F73E8 File Offset: 0x007F55E8
		// (set) Token: 0x060088CD RID: 35021 RVA: 0x007F749C File Offset: 0x007F569C
		public bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_Visible
		{
			get
			{
				short num = (short)227728259;
				short num2 = num;
				num = (short)1987828611;
				switch (num2 == num)
				{
				}
				num = (short)1904410624;
				if (num != 0)
				{
				}
				num = (short)195035136;
				short num3 = num;
				num = (short)979435521;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Visible;
			}
			set
			{
				short num = (short)822957452;
				short num2 = num;
				num = (short)928339340;
				switch (num2 == num)
				{
				}
				num = (short)1606221824;
				if (num != 0)
				{
				}
				num = (short)681574400;
				short num3 = num;
				num = (short)578682881;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Visible = value;
			}
		}

		// Token: 0x17004572 RID: 17778
		// (get) Token: 0x060088CE RID: 35022 RVA: 0x007F7554 File Offset: 0x007F5754
		// (set) Token: 0x060088CF RID: 35023 RVA: 0x007F760C File Offset: 0x007F580C
		public bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_Editable
		{
			get
			{
				short num = (short)71106561;
				if (num != 0)
				{
				}
				num = (short)1145916430;
				short num2 = num;
				num = (short)1763068942;
				switch (num2 == num)
				{
				}
				num = (short)1747648512;
				short num3 = num;
				num = (short)651034624;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Editable;
			}
			set
			{
				short num = (short)610729985;
				if (num != 0)
				{
				}
				num = (short)2133985384;
				short num2 = num;
				num = (short)1881278568;
				switch (num2 == num)
				{
				}
				num = (short)1639120896;
				short num3 = num;
				num = (short)1012334592;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Editable = value;
			}
		}

		// Token: 0x17004573 RID: 17779
		// (get) Token: 0x060088D0 RID: 35024 RVA: 0x007F76C4 File Offset: 0x007F58C4
		internal string CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_UILabel
		{
			get
			{
				short num = (short)186700155;
				short num2 = num;
				num = (short)574214523;
				switch (num2 == num)
				{
				}
				num = (short)835452928;
				if (num != 0)
				{
				}
				num = (short)517603328;
				short num3 = num;
				num = (short)2052456449;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.UIName;
			}
		}

		// Token: 0x17004574 RID: 17780
		// (get) Token: 0x060088D1 RID: 35025 RVA: 0x007F777C File Offset: 0x007F597C
		// (set) Token: 0x060088D2 RID: 35026 RVA: 0x007F7834 File Offset: 0x007F5A34
		internal bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_HiddenStatic
		{
			get
			{
				short num = (short)713980727;
				short num2 = num;
				num = (short)1085831991;
				switch (num2 == num)
				{
				}
				num = (short)1291190272;
				if (num != 0)
				{
				}
				num = (short)482934784;
				short num3 = num;
				num = (short)463142913;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.HiddenStatic;
			}
			set
			{
				short num = (short)1651137369;
				short num2 = num;
				num = (short)251485017;
				switch (num2 == num)
				{
				}
				num = (short)2017394689;
				if (num != 0)
				{
				}
				num = (short)515702784;
				short num3 = num;
				num = (short)807075840;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.HiddenStatic = value;
			}
		}

		// Token: 0x17004575 RID: 17781
		// (get) Token: 0x060088D3 RID: 35027 RVA: 0x007F78EC File Offset: 0x007F5AEC
		// (set) Token: 0x060088D4 RID: 35028 RVA: 0x007F79A4 File Offset: 0x007F5BA4
		internal bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_HiddenDynamic
		{
			get
			{
				short num = (short)712413954;
				short num2 = num;
				num = (short)385520386;
				switch (num2 == num)
				{
				}
				num = (short)836763649;
				if (num != 0)
				{
				}
				num = (short)409993216;
				short num3 = num;
				num = (short)1873936384;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.HiddenDynamic;
			}
			set
			{
				short num = (short)1998629054;
				short num2 = num;
				num = (short)550021310;
				switch (num2 == num)
				{
				}
				num = (short)1252196353;
				if (num != 0)
				{
				}
				num = (short)1495465984;
				short num3 = num;
				num = (short)251592704;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.HiddenDynamic = value;
			}
		}

		// Token: 0x17004576 RID: 17782
		// (get) Token: 0x060088D5 RID: 35029 RVA: 0x007F7A5C File Offset: 0x007F5C5C
		public bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754_HasDiffs
		{
			get
			{
				short num = (short)566378989;
				short num2 = num;
				num = (short)220807661;
				switch (num2 == num)
				{
				}
				num = (short)1555562496;
				if (num != 0)
				{
				}
				num = (short)581435392;
				short num3 = num;
				num = (short)1966866433;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754._HasDiffs;
			}
		}

		// Token: 0x17004577 RID: 17783
		// (get) Token: 0x060088D6 RID: 35030 RVA: 0x007F7B10 File Offset: 0x007F5D10
		// (set) Token: 0x060088D7 RID: 35031 RVA: 0x007F7BC8 File Offset: 0x007F5DC8
		public string CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193Value
		{
			get
			{
				short num = (short)65794730;
				short num2 = num;
				num = (short)517862058;
				switch (num2 == num)
				{
				}
				num = (short)834863105;
				if (num != 0)
				{
				}
				num = (short)1630863360;
				short num3 = num;
				num = (short)379453440;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.Value;
			}
			set
			{
				short num = (short)578224130;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)866516993;
						if (num != 0)
						{
						}
						this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.Value = value;
						num = (short)938475521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
					{
						num = (short)355872405;
						short num3 = num;
						num = (short)583282325;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AF;
						default:
						{
							num = (short)836304896;
							short num4 = num;
							num = (short)1433731072;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_A2;
							}
							continue;
						}
						}
						break;
					}
					}
					goto IL_A2;
					IL_AF:
					num = (short)646512640;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A2:
					if (!string.IsNullOrEmpty(value.Trim()))
					{
						goto IL_AF;
					}
					break;
				}
			}
		}

		// Token: 0x17004578 RID: 17784
		// (get) Token: 0x060088D8 RID: 35032 RVA: 0x007F7CE4 File Offset: 0x007F5EE4
		// (set) Token: 0x060088D9 RID: 35033 RVA: 0x007F7D98 File Offset: 0x007F5F98
		public string CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193_UIValue
		{
			get
			{
				short num = (short)166822900;
				short num2 = num;
				num = (short)1968014324;
				switch (num2 == num)
				{
				}
				num = (short)95617024;
				if (num != 0)
				{
				}
				num = (short)272433152;
				short num3 = num;
				num = (short)946798593;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.Value;
			}
			set
			{
				short num = (short)5373953;
				if (num != 0)
				{
				}
				num = (short)2106272543;
				short num2 = num;
				num = (short)1591094047;
				switch (num2 == num)
				{
				}
				num = (short)900136960;
				short num3 = num;
				num = (short)394133504;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.Value = value;
			}
		}

		// Token: 0x17004579 RID: 17785
		// (get) Token: 0x060088DA RID: 35034 RVA: 0x007F7E4C File Offset: 0x007F604C
		public global::AcpBusinessLayer.AcpKeyField CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193
		{
			get
			{
				short num = (short)1292261273;
				short num2 = num;
				num = (short)1208965017;
				switch (num2 == num)
				{
				}
				num = (short)407371776;
				if (num != 0)
				{
				}
				num = (short)1971322880;
				short num3 = num;
				num = (short)1546256385;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193;
			}
		}

		// Token: 0x1700457A RID: 17786
		// (get) Token: 0x060088DB RID: 35035 RVA: 0x007F7EFC File Offset: 0x007F60FC
		// (set) Token: 0x060088DC RID: 35036 RVA: 0x007F7FB0 File Offset: 0x007F61B0
		public bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193_Applicable
		{
			get
			{
				short num = (short)738034965;
				short num2 = num;
				num = (short)112821525;
				switch (num2 == num)
				{
				}
				num = (short)837746689;
				if (num != 0)
				{
				}
				num = (short)1448017920;
				short num3 = num;
				num = (short)786169856;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.Applicable;
			}
			set
			{
				short num = (short)892852800;
				short num2 = num;
				num = (short)1592121920;
				switch (num2 == num)
				{
				}
				num = (short)1911488513;
				if (num != 0)
				{
				}
				num = (short)103743488;
				short num3 = num;
				num = (short)96075776;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.Applicable = value;
			}
		}

		// Token: 0x1700457B RID: 17787
		// (get) Token: 0x060088DD RID: 35037 RVA: 0x007F8068 File Offset: 0x007F6268
		// (set) Token: 0x060088DE RID: 35038 RVA: 0x007F811C File Offset: 0x007F631C
		public bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193_Valid
		{
			get
			{
				short num = (short)1700198869;
				short num2 = num;
				num = (short)866646485;
				switch (num2 == num)
				{
				}
				num = (short)1920991233;
				if (num != 0)
				{
				}
				num = (short)1591934976;
				short num3 = num;
				num = (short)2147352576;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.Valid;
			}
			set
			{
				short num = (short)767796834;
				short num2 = num;
				num = (short)997762658;
				switch (num2 == num)
				{
				}
				num = (short)1345519617;
				if (num != 0)
				{
				}
				num = (short)1325334528;
				short num3 = num;
				num = (short)304480256;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.Valid = value;
			}
		}

		// Token: 0x1700457C RID: 17788
		// (get) Token: 0x060088DF RID: 35039 RVA: 0x007F81D4 File Offset: 0x007F63D4
		// (set) Token: 0x060088E0 RID: 35040 RVA: 0x007F828C File Offset: 0x007F648C
		public bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193_Visible
		{
			get
			{
				short num = (short)314413873;
				short num2 = num;
				num = (short)532321073;
				switch (num2 == num)
				{
				}
				num = (short)92078081;
				if (num != 0)
				{
				}
				num = (short)1875443712;
				short num3 = num;
				num = (short)1133969408;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.Visible;
			}
			set
			{
				short num = (short)1361067801;
				short num2 = num;
				num = (short)1514356505;
				switch (num2 == num)
				{
				}
				num = (short)693895168;
				if (num != 0)
				{
				}
				num = (short)1665597440;
				short num3 = num;
				num = (short)1358954497;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.Visible = value;
			}
		}

		// Token: 0x1700457D RID: 17789
		// (get) Token: 0x060088E1 RID: 35041 RVA: 0x007F8340 File Offset: 0x007F6540
		// (set) Token: 0x060088E2 RID: 35042 RVA: 0x007F83F8 File Offset: 0x007F65F8
		public bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193_Editable
		{
			get
			{
				short num = (short)554612329;
				short num2 = num;
				num = (short)386315881;
				switch (num2 == num)
				{
				}
				num = (short)705429505;
				if (num != 0)
				{
				}
				num = (short)1163132928;
				short num3 = num;
				num = (short)818216960;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.Editable;
			}
			set
			{
				short num = (short)1309596613;
				short num2 = num;
				num = (short)987421637;
				switch (num2 == num)
				{
				}
				num = (short)504430593;
				if (num != 0)
				{
				}
				num = (short)963379200;
				short num3 = num;
				num = (short)2056978432;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.Editable = value;
			}
		}

		// Token: 0x1700457E RID: 17790
		// (get) Token: 0x060088E3 RID: 35043 RVA: 0x007F84B0 File Offset: 0x007F66B0
		internal string CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193_UILabel
		{
			get
			{
				short num = (short)133601171;
				short num2 = num;
				num = (short)346199955;
				switch (num2 == num)
				{
				}
				num = (short)503513089;
				if (num != 0)
				{
				}
				num = (short)1111818240;
				short num3 = num;
				num = (short)979632128;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.UIName;
			}
		}

		// Token: 0x1700457F RID: 17791
		// (get) Token: 0x060088E4 RID: 35044 RVA: 0x007F8564 File Offset: 0x007F6764
		// (set) Token: 0x060088E5 RID: 35045 RVA: 0x007F8618 File Offset: 0x007F6818
		internal bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193_HiddenStatic
		{
			get
			{
				short num = (short)1249068958;
				short num2 = num;
				num = (short)701843358;
				switch (num2 == num)
				{
				}
				num = (short)736034817;
				if (num != 0)
				{
				}
				num = (short)1617887232;
				short num3 = num;
				num = (short)2016083968;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.HiddenStatic;
			}
			set
			{
				short num = (short)1701977073;
				short num2 = num;
				num = (short)41819121;
				switch (num2 == num)
				{
				}
				num = (short)715063297;
				if (num != 0)
				{
				}
				num = (short)1790509056;
				short num3 = num;
				num = (short)726138880;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.HiddenStatic = value;
			}
		}

		// Token: 0x17004580 RID: 17792
		// (get) Token: 0x060088E6 RID: 35046 RVA: 0x007F86CC File Offset: 0x007F68CC
		// (set) Token: 0x060088E7 RID: 35047 RVA: 0x007F8780 File Offset: 0x007F6980
		internal bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193_HiddenDynamic
		{
			get
			{
				short num = (short)442774088;
				short num2 = num;
				num = (short)1163735624;
				switch (num2 == num)
				{
				}
				num = (short)1801125889;
				if (num != 0)
				{
				}
				num = (short)923729920;
				short num3 = num;
				num = (short)1318125568;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.HiddenDynamic;
			}
			set
			{
				short num = (short)1678442497;
				if (num != 0)
				{
				}
				num = (short)1841199490;
				short num2 = num;
				num = (short)1583053186;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1034158080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1021181952;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193.HiddenDynamic = value;
			}
		}

		// Token: 0x17004581 RID: 17793
		// (get) Token: 0x060088E8 RID: 35048 RVA: 0x007F8834 File Offset: 0x007F6A34
		public bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193_HasDiffs
		{
			get
			{
				short num = (short)785887486;
				short num2 = num;
				num = (short)1321382142;
				switch (num2 == num)
				{
				}
				num = (short)1558052864;
				short num3 = num;
				num = (short)1707933697;
				if (num != 0)
				{
				}
				num = (short)904200192;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193._HasDiffs;
			}
		}

		// Token: 0x17004582 RID: 17794
		// (get) Token: 0x060088E9 RID: 35049 RVA: 0x007F88E8 File Offset: 0x007F6AE8
		// (set) Token: 0x060088EA RID: 35050 RVA: 0x007F899C File Offset: 0x007F6B9C
		public string CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520Value
		{
			get
			{
				short num = (short)1653020662;
				short num2 = num;
				num = (short)1705514998;
				switch (num2 == num)
				{
				}
				num = (short)359858176;
				short num3 = num;
				num = (short)1331101697;
				if (num != 0)
				{
				}
				num = (short)1156775936;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.Value;
			}
			set
			{
				short num = (short)395820394;
				short num2 = num;
				num = (short)646495594;
				switch (num2 == num)
				{
				}
				num = (short)970588160;
				short num3 = num;
				num = (short)1690304512;
				if (num != 0)
				{
				}
				num = (short)783548417;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.Value = value;
			}
		}

		// Token: 0x17004583 RID: 17795
		// (get) Token: 0x060088EB RID: 35051 RVA: 0x007F8A54 File Offset: 0x007F6C54
		public global::AcpBusinessLayer.AcpField<string> CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520
		{
			get
			{
				short num = (short)219873281;
				if (num != 0)
				{
				}
				num = (short)276575377;
				short num2 = num;
				num = (short)1916351633;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1302331392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1458438144;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520;
			}
		}

		// Token: 0x17004584 RID: 17796
		// (get) Token: 0x060088EC RID: 35052 RVA: 0x007F8B08 File Offset: 0x007F6D08
		// (set) Token: 0x060088ED RID: 35053 RVA: 0x007F8BBC File Offset: 0x007F6DBC
		public string CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520_UIValue
		{
			get
			{
				short num = (short)1857700348;
				short num2 = num;
				num = (short)1220821500;
				switch (num2 == num)
				{
				}
				num = (short)973012992;
				short num3 = num;
				num = (short)2034696192;
				if (num != 0)
				{
				}
				num = (short)1515126785;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.Value;
			}
			set
			{
				short num = (short)334628479;
				short num2 = num;
				num = (short)1934427775;
				switch (num2 == num)
				{
				}
				num = (short)1914372096;
				short num3 = num;
				num = (short)2059796481;
				if (num != 0)
				{
				}
				num = (short)2104754176;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.Value = value;
			}
		}

		// Token: 0x17004585 RID: 17797
		// (get) Token: 0x060088EE RID: 35054 RVA: 0x007F8C74 File Offset: 0x007F6E74
		// (set) Token: 0x060088EF RID: 35055 RVA: 0x007F8D28 File Offset: 0x007F6F28
		public bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520_Applicable
		{
			get
			{
				short num = (short)961882436;
				short num2 = num;
				num = (short)805644612;
				switch (num2 == num)
				{
				}
				num = (short)31129600;
				short num3 = num;
				num = (short)547422208;
				if (num != 0)
				{
				}
				num = (short)152829953;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.Applicable;
			}
			set
			{
				short num = (short)1013230317;
				short num2 = num;
				num = (short)1314499309;
				switch (num2 == num)
				{
				}
				num = (short)558694400;
				short num3 = num;
				num = (short)254672896;
				if (num != 0)
				{
				}
				num = (short)435748865;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.Applicable = value;
			}
		}

		// Token: 0x17004586 RID: 17798
		// (get) Token: 0x060088F0 RID: 35056 RVA: 0x007F8DE0 File Offset: 0x007F6FE0
		// (set) Token: 0x060088F1 RID: 35057 RVA: 0x007F8E98 File Offset: 0x007F7098
		public bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520_Valid
		{
			get
			{
				short num = (short)524395625;
				short num2 = num;
				num = (short)1676321897;
				switch (num2 == num)
				{
				}
				num = (short)620036096;
				short num3 = num;
				num = (short)1946353664;
				if (num != 0)
				{
				}
				num = (short)1718681601;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.Valid;
			}
			set
			{
				short num = (short)555699329;
				short num2 = num;
				num = (short)990989441;
				switch (num2 == num)
				{
				}
				num = (short)240582656;
				short num3 = num;
				num = (short)641204225;
				if (num != 0)
				{
				}
				num = (short)1437204480;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.Valid = value;
			}
		}

		// Token: 0x17004587 RID: 17799
		// (get) Token: 0x060088F2 RID: 35058 RVA: 0x007F8F4C File Offset: 0x007F714C
		// (set) Token: 0x060088F3 RID: 35059 RVA: 0x007F9004 File Offset: 0x007F7204
		public bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520_Visible
		{
			get
			{
				short num = (short)1451134750;
				short num2 = num;
				num = (short)968396574;
				switch (num2 == num)
				{
				}
				num = (short)372834304;
				short num3 = num;
				num = (short)693043200;
				if (num != 0)
				{
				}
				num = (short)520355841;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.Visible;
			}
			set
			{
				short num = (short)275926604;
				short num2 = num;
				num = (short)1031949900;
				switch (num2 == num)
				{
				}
				num = (short)706478080;
				short num3 = num;
				num = (short)1223098369;
				if (num != 0)
				{
				}
				num = (short)231800832;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.Visible = value;
			}
		}

		// Token: 0x17004588 RID: 17800
		// (get) Token: 0x060088F4 RID: 35060 RVA: 0x007F90B8 File Offset: 0x007F72B8
		// (set) Token: 0x060088F5 RID: 35061 RVA: 0x007F9174 File Offset: 0x007F7374
		public bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520_Editable
		{
			get
			{
				short num = (short)1237129443;
				short num2 = num;
				num = (short)44046563;
				switch (num2 == num)
				{
				}
				num = (short)1850146816;
				short num3 = num;
				num = (short)399769601;
				if (num != 0)
				{
				}
				num = (short)597229568;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.Editable;
			}
			set
			{
				short num = (short)445317121;
				if (num != 0)
				{
				}
				num = (short)906171246;
				short num2 = num;
				num = (short)1130763118;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1357709312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)823590912;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.Editable = value;
			}
		}

		// Token: 0x17004589 RID: 17801
		// (get) Token: 0x060088F6 RID: 35062 RVA: 0x007F9228 File Offset: 0x007F7428
		internal string CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520_UILabel
		{
			get
			{
				short num = (short)179238959;
				short num2 = num;
				num = (short)1236072495;
				switch (num2 == num)
				{
				}
				num = (short)22216704;
				short num3 = num;
				num = (short)1255342080;
				if (num != 0)
				{
				}
				num = (short)785317889;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.UIName;
			}
		}

		// Token: 0x1700458A RID: 17802
		// (get) Token: 0x060088F7 RID: 35063 RVA: 0x007F92DC File Offset: 0x007F74DC
		// (set) Token: 0x060088F8 RID: 35064 RVA: 0x007F9390 File Offset: 0x007F7590
		internal bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520_HiddenStatic
		{
			get
			{
				short num = (short)616766052;
				short num2 = num;
				num = (short)896997988;
				switch (num2 == num)
				{
				}
				num = (short)1441005568;
				short num3 = num;
				num = (short)914096129;
				if (num != 0)
				{
				}
				num = (short)1889337344;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.HiddenStatic;
			}
			set
			{
				short num = (short)1784166380;
				short num2 = num;
				num = (short)456210412;
				switch (num2 == num)
				{
				}
				num = (short)781451264;
				short num3 = num;
				num = (short)1230635008;
				if (num != 0)
				{
				}
				num = (short)1420165121;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.HiddenStatic = value;
			}
		}

		// Token: 0x1700458B RID: 17803
		// (get) Token: 0x060088F9 RID: 35065 RVA: 0x007F9444 File Offset: 0x007F7644
		// (set) Token: 0x060088FA RID: 35066 RVA: 0x007F94FC File Offset: 0x007F76FC
		internal bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520_HiddenDynamic
		{
			get
			{
				short num = (short)149811090;
				short num2 = num;
				num = (short)629075858;
				switch (num2 == num)
				{
				}
				num = (short)977338368;
				short num3 = num;
				num = (short)29425665;
				if (num != 0)
				{
				}
				num = (short)109641728;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.HiddenDynamic;
			}
			set
			{
				short num = (short)1038064941;
				short num2 = num;
				num = (short)1263639853;
				switch (num2 == num)
				{
				}
				num = (short)1098579968;
				short num3 = num;
				num = (short)399704065;
				if (num != 0)
				{
				}
				num = (short)581369856;
				if (num != 0)
				{
				}
				this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520.HiddenDynamic = value;
			}
		}

		// Token: 0x1700458C RID: 17804
		// (get) Token: 0x060088FB RID: 35067 RVA: 0x007F95B0 File Offset: 0x007F77B0
		public bool CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520_HasDiffs
		{
			get
			{
				short num = (short)2028507416;
				short num2 = num;
				num = (short)317886744;
				switch (num2 == num)
				{
				}
				num = (short)1940783104;
				short num3 = num;
				num = (short)2128543745;
				if (num != 0)
				{
				}
				num = (short)1351155712;
				if (num != 0)
				{
				}
				return this.cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520._HasDiffs;
			}
		}

		// Token: 0x1700458D RID: 17805
		// (get) Token: 0x060088FC RID: 35068 RVA: 0x007F9668 File Offset: 0x007F7868
		// (set) Token: 0x060088FD RID: 35069 RVA: 0x007F971C File Offset: 0x007F791C
		public int RadErgCtrlHeadO5ShortKeyPressTimeValue
		{
			get
			{
				short num = (short)1066832060;
				short num2 = num;
				num = (short)2088538300;
				switch (num2 == num)
				{
				}
				num = (short)620494848;
				short num3 = num;
				num = (short)498204673;
				if (num != 0)
				{
				}
				num = (short)2147024896;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5ShortKeyPressTime.Value;
			}
			set
			{
				short num = (short)691869922;
				short num2 = num;
				num = (short)2063866082;
				switch (num2 == num)
				{
				}
				num = (short)169476096;
				short num3 = num;
				num = (short)1544945664;
				if (num != 0)
				{
				}
				num = (short)913178625;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO5ShortKeyPressTime.Value = value;
			}
		}

		// Token: 0x1700458E RID: 17806
		// (get) Token: 0x060088FE RID: 35070 RVA: 0x007F97D4 File Offset: 0x007F79D4
		// (set) Token: 0x060088FF RID: 35071 RVA: 0x007F9888 File Offset: 0x007F7A88
		public string RadErgCtrlHeadO5ShortKeyPressTime_UIValue
		{
			get
			{
				short num = (short)1915383806;
				short num2 = num;
				num = (short)680095742;
				switch (num2 == num)
				{
				}
				num = (short)1763901440;
				short num3 = num;
				num = (short)631308289;
				if (num != 0)
				{
				}
				num = (short)2120941568;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5ShortKeyPressTime.UIValue;
			}
			set
			{
				short num = (short)2029279102;
				short num2 = num;
				num = (short)253515646;
				switch (num2 == num)
				{
				}
				num = (short)1693450240;
				short num3 = num;
				num = (short)1541799937;
				if (num != 0)
				{
				}
				num = (short)995491840;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO5ShortKeyPressTime.UIValue = value;
			}
		}

		// Token: 0x1700458F RID: 17807
		// (get) Token: 0x06008900 RID: 35072 RVA: 0x007F993C File Offset: 0x007F7B3C
		public global::AcpBusinessLayer.AcpCustomRangeField RadErgCtrlHeadO5ShortKeyPressTime
		{
			get
			{
				short num = (short)1114177537;
				if (num != 0)
				{
				}
				num = (short)620369052;
				short num2 = num;
				num = (short)2026968220;
				switch (num2 == num)
				{
				default:
				{
					num = (short)77791232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)506265600;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5ShortKeyPressTime;
			}
		}

		// Token: 0x17004590 RID: 17808
		// (get) Token: 0x06008901 RID: 35073 RVA: 0x007F99F0 File Offset: 0x007F7BF0
		// (set) Token: 0x06008902 RID: 35074 RVA: 0x007F9AA4 File Offset: 0x007F7CA4
		public bool RadErgCtrlHeadO5ShortKeyPressTime_Applicable
		{
			get
			{
				short num = (short)2081092812;
				short num2 = num;
				num = (short)927003852;
				switch (num2 == num)
				{
				}
				num = (short)1528692736;
				short num3 = num;
				num = (short)1146880000;
				if (num != 0)
				{
				}
				num = (short)1911816193;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5ShortKeyPressTime.Applicable;
			}
			set
			{
				short num = (short)1481543067;
				short num2 = num;
				num = (short)1481870747;
				switch (num2 == num)
				{
				}
				num = (short)1144651776;
				short num3 = num;
				num = (short)1060175872;
				if (num != 0)
				{
				}
				num = (short)1955463169;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO5ShortKeyPressTime.Applicable = value;
			}
		}

		// Token: 0x17004591 RID: 17809
		// (get) Token: 0x06008903 RID: 35075 RVA: 0x007F9B58 File Offset: 0x007F7D58
		// (set) Token: 0x06008904 RID: 35076 RVA: 0x007F9C08 File Offset: 0x007F7E08
		public bool RadErgCtrlHeadO5ShortKeyPressTime_Valid
		{
			get
			{
				short num = (short)1608197402;
				short num2 = num;
				num = (short)1470768410;
				switch (num2 == num)
				{
				}
				num = (short)1281753088;
				short num3 = num;
				num = (short)1906900993;
				if (num != 0)
				{
				}
				num = (short)1079705600;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5ShortKeyPressTime.Valid;
			}
			set
			{
				short num = (short)999651782;
				short num2 = num;
				num = (short)425097670;
				switch (num2 == num)
				{
				}
				num = (short)2145779712;
				short num3 = num;
				num = (short)825556993;
				if (num != 0)
				{
				}
				num = (short)999751680;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO5ShortKeyPressTime.Valid = value;
			}
		}

		// Token: 0x17004592 RID: 17810
		// (get) Token: 0x06008905 RID: 35077 RVA: 0x007F9CC0 File Offset: 0x007F7EC0
		// (set) Token: 0x06008906 RID: 35078 RVA: 0x007F9D78 File Offset: 0x007F7F78
		public bool RadErgCtrlHeadO5ShortKeyPressTime_Visible
		{
			get
			{
				short num = (short)2000925818;
				short num2 = num;
				num = (short)113095802;
				switch (num2 == num)
				{
				}
				num = (short)1023148032;
				short num3 = num;
				num = (short)1231618049;
				if (num != 0)
				{
				}
				num = (short)422510592;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5ShortKeyPressTime.Visible;
			}
			set
			{
				short num = (short)1738064073;
				short num2 = num;
				num = (short)1766572233;
				switch (num2 == num)
				{
				}
				num = (short)302120960;
				short num3 = num;
				num = (short)1869807616;
				if (num != 0)
				{
				}
				num = (short)1026883585;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO5ShortKeyPressTime.Visible = value;
			}
		}

		// Token: 0x17004593 RID: 17811
		// (get) Token: 0x06008907 RID: 35079 RVA: 0x007F9E30 File Offset: 0x007F8030
		// (set) Token: 0x06008908 RID: 35080 RVA: 0x007F9EE4 File Offset: 0x007F80E4
		public bool RadErgCtrlHeadO5ShortKeyPressTime_Editable
		{
			get
			{
				short num = (short)1314043273;
				short num2 = num;
				num = (short)669496713;
				switch (num2 == num)
				{
				}
				num = (short)510656512;
				short num3 = num;
				num = (short)2068774913;
				if (num != 0)
				{
				}
				num = (short)97648640;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5ShortKeyPressTime.Editable;
			}
			set
			{
				short num = (short)1896499438;
				short num2 = num;
				num = (short)1934117102;
				switch (num2 == num)
				{
				}
				num = (short)2080636928;
				short num3 = num;
				num = (short)1480785921;
				if (num != 0)
				{
				}
				num = (short)1812660224;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO5ShortKeyPressTime.Editable = value;
			}
		}

		// Token: 0x17004594 RID: 17812
		// (get) Token: 0x06008909 RID: 35081 RVA: 0x007F9F9C File Offset: 0x007F819C
		internal string RadErgCtrlHeadO5ShortKeyPressTime_UILabel
		{
			get
			{
				short num = (short)948560343;
				short num2 = num;
				num = (short)1505812951;
				switch (num2 == num)
				{
				}
				num = (short)1033961472;
				short num3 = num;
				num = (short)1705377793;
				if (num != 0)
				{
				}
				num = (short)2137587712;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5ShortKeyPressTime.UIName;
			}
		}

		// Token: 0x17004595 RID: 17813
		// (get) Token: 0x0600890A RID: 35082 RVA: 0x007FA050 File Offset: 0x007F8250
		// (set) Token: 0x0600890B RID: 35083 RVA: 0x007FA104 File Offset: 0x007F8304
		internal bool RadErgCtrlHeadO5ShortKeyPressTime_HiddenStatic
		{
			get
			{
				short num = (short)1365049345;
				if (num != 0)
				{
				}
				num = (short)578019844;
				short num2 = num;
				num = (short)1270014468;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2130182144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1292500992;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5ShortKeyPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)1092194503;
				short num2 = num;
				num = (short)1028296903;
				switch (num2 == num)
				{
				}
				num = (short)971636736;
				short num3 = num;
				num = (short)1368588289;
				if (num != 0)
				{
				}
				num = (short)122093568;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO5ShortKeyPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17004596 RID: 17814
		// (get) Token: 0x0600890C RID: 35084 RVA: 0x007FA1B8 File Offset: 0x007F83B8
		// (set) Token: 0x0600890D RID: 35085 RVA: 0x007FA270 File Offset: 0x007F8470
		internal bool RadErgCtrlHeadO5ShortKeyPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)123994113;
				if (num != 0)
				{
				}
				num = (short)1792443522;
				short num2 = num;
				num = (short)973767810;
				switch (num2 == num)
				{
				default:
				{
					num = (short)593952768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)293994496;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5ShortKeyPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)1667153432;
				short num2 = num;
				num = (short)610385432;
				switch (num2 == num)
				{
				}
				num = (short)1016528896;
				short num3 = num;
				num = (short)521404417;
				if (num != 0)
				{
				}
				num = (short)569507840;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO5ShortKeyPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17004597 RID: 17815
		// (get) Token: 0x0600890E RID: 35086 RVA: 0x007FA324 File Offset: 0x007F8524
		public bool RadErgCtrlHeadO5ShortKeyPressTime_HasDiffs
		{
			get
			{
				short num = (short)2095705241;
				short num2 = num;
				num = (short)1331489945;
				switch (num2 == num)
				{
				}
				num = (short)1065091072;
				short num3 = num;
				num = (short)1683619840;
				if (num != 0)
				{
				}
				num = (short)1567293441;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5ShortKeyPressTime._HasDiffs;
			}
		}

		// Token: 0x17004598 RID: 17816
		// (get) Token: 0x0600890F RID: 35087 RVA: 0x007FA3D8 File Offset: 0x007F85D8
		// (set) Token: 0x06008910 RID: 35088 RVA: 0x007FA48C File Offset: 0x007F868C
		public int RadErgCtrlHeadO5LongKeyPressTimeValue
		{
			get
			{
				short num = (short)1144683893;
				short num2 = num;
				num = (short)1679457653;
				switch (num2 == num)
				{
				}
				num = (short)2000617472;
				short num3 = num;
				num = (short)1106313216;
				if (num != 0)
				{
				}
				num = (short)368640001;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5LongKeyPressTime.Value;
			}
			set
			{
				short num = (short)2000290267;
				short num2 = num;
				num = (short)1688207835;
				switch (num2 == num)
				{
				}
				num = (short)92995584;
				short num3 = num;
				num = (short)1364525057;
				if (num != 0)
				{
				}
				num = (short)179306496;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO5LongKeyPressTime.Value = value;
			}
		}

		// Token: 0x17004599 RID: 17817
		// (get) Token: 0x06008911 RID: 35089 RVA: 0x007FA544 File Offset: 0x007F8744
		// (set) Token: 0x06008912 RID: 35090 RVA: 0x007FA5F8 File Offset: 0x007F87F8
		public string RadErgCtrlHeadO5LongKeyPressTime_UIValue
		{
			get
			{
				short num = (short)1942880257;
				if (num != 0)
				{
				}
				num = (short)1958587564;
				short num2 = num;
				num = (short)730705068;
				switch (num2 == num)
				{
				default:
				{
					num = (short)12255232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1963589632;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5LongKeyPressTime.UIValue;
			}
			set
			{
				short num = (short)1739055276;
				short num2 = num;
				num = (short)1033232556;
				switch (num2 == num)
				{
				}
				num = (short)1581842432;
				short num3 = num;
				num = (short)753926145;
				if (num != 0)
				{
				}
				num = (short)255655936;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO5LongKeyPressTime.UIValue = value;
			}
		}

		// Token: 0x1700459A RID: 17818
		// (get) Token: 0x06008913 RID: 35091 RVA: 0x007FA6AC File Offset: 0x007F88AC
		public global::AcpBusinessLayer.AcpCustomRangeField RadErgCtrlHeadO5LongKeyPressTime
		{
			get
			{
				short num = (short)1974635966;
				short num2 = num;
				num = (short)1326026174;
				switch (num2 == num)
				{
				}
				num = (short)1008926720;
				short num3 = num;
				num = (short)678625281;
				if (num != 0)
				{
				}
				num = (short)1103298560;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5LongKeyPressTime;
			}
		}

		// Token: 0x1700459B RID: 17819
		// (get) Token: 0x06008914 RID: 35092 RVA: 0x007FA75C File Offset: 0x007F895C
		// (set) Token: 0x06008915 RID: 35093 RVA: 0x007FA810 File Offset: 0x007F8A10
		public bool RadErgCtrlHeadO5LongKeyPressTime_Applicable
		{
			get
			{
				short num = (short)900688567;
				short num2 = num;
				num = (short)11430583;
				switch (num2 == num)
				{
				}
				num = (short)101253120;
				short num3 = num;
				num = (short)1651834880;
				if (num != 0)
				{
				}
				num = (short)265551873;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5LongKeyPressTime.Applicable;
			}
			set
			{
				short num = (short)1646460929;
				if (num != 0)
				{
				}
				num = (short)868374550;
				short num2 = num;
				num = (short)1967675414;
				switch (num2 == num)
				{
				}
				num = (short)427163648;
				short num3 = num;
				num = (short)2009858048;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO5LongKeyPressTime.Applicable = value;
			}
		}

		// Token: 0x1700459C RID: 17820
		// (get) Token: 0x06008916 RID: 35094 RVA: 0x007FA8C4 File Offset: 0x007F8AC4
		// (set) Token: 0x06008917 RID: 35095 RVA: 0x007FA978 File Offset: 0x007F8B78
		public bool RadErgCtrlHeadO5LongKeyPressTime_Valid
		{
			get
			{
				short num = (short)686914126;
				short num2 = num;
				num = (short)1921415758;
				switch (num2 == num)
				{
				}
				num = (short)866648064;
				if (num != 0)
				{
				}
				num = (short)2016149504;
				short num3 = num;
				num = (short)112328705;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5LongKeyPressTime.Valid;
			}
			set
			{
				short num = (short)2135632810;
				short num2 = num;
				num = (short)1902980010;
				switch (num2 == num)
				{
				}
				num = (short)2126315520;
				if (num != 0)
				{
				}
				num = (short)1340669952;
				short num3 = num;
				num = (short)688455681;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO5LongKeyPressTime.Valid = value;
			}
		}

		// Token: 0x1700459D RID: 17821
		// (get) Token: 0x06008918 RID: 35096 RVA: 0x007FAA30 File Offset: 0x007F8C30
		// (set) Token: 0x06008919 RID: 35097 RVA: 0x007FAAE4 File Offset: 0x007F8CE4
		public bool RadErgCtrlHeadO5LongKeyPressTime_Visible
		{
			get
			{
				short num = (short)845004345;
				short num2 = num;
				num = (short)2124791353;
				switch (num2 == num)
				{
				}
				num = (short)530710528;
				if (num != 0)
				{
				}
				num = (short)537395200;
				short num3 = num;
				num = (short)2050949121;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5LongKeyPressTime.Visible;
			}
			set
			{
				short num = (short)1975451649;
				if (num != 0)
				{
				}
				num = (short)1167180129;
				short num2 = num;
				num = (short)1281212769;
				switch (num2 == num)
				{
				}
				num = (short)1261961216;
				short num3 = num;
				num = (short)1368981504;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO5LongKeyPressTime.Visible = value;
			}
		}

		// Token: 0x1700459E RID: 17822
		// (get) Token: 0x0600891A RID: 35098 RVA: 0x007FAB98 File Offset: 0x007F8D98
		// (set) Token: 0x0600891B RID: 35099 RVA: 0x007FAC4C File Offset: 0x007F8E4C
		public bool RadErgCtrlHeadO5LongKeyPressTime_Editable
		{
			get
			{
				short num = (short)47079334;
				short num2 = num;
				num = (short)359686054;
				switch (num2 == num)
				{
				}
				num = (short)1661992961;
				if (num != 0)
				{
				}
				num = (short)674103296;
				short num3 = num;
				num = (short)360382464;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5LongKeyPressTime.Editable;
			}
			set
			{
				short num = (short)1186813964;
				short num2 = num;
				num = (short)1586321420;
				switch (num2 == num)
				{
				}
				num = (short)397737984;
				if (num != 0)
				{
				}
				num = (short)13565952;
				short num3 = num;
				num = (short)75890689;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO5LongKeyPressTime.Editable = value;
			}
		}

		// Token: 0x1700459F RID: 17823
		// (get) Token: 0x0600891C RID: 35100 RVA: 0x007FAD00 File Offset: 0x007F8F00
		internal string RadErgCtrlHeadO5LongKeyPressTime_UILabel
		{
			get
			{
				short num = (short)254345217;
				if (num != 0)
				{
				}
				num = (short)1514372804;
				short num2 = num;
				num = (short)1745059524;
				switch (num2 == num)
				{
				}
				num = (short)762052608;
				short num3 = num;
				num = (short)931332096;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5LongKeyPressTime.UIName;
			}
		}

		// Token: 0x170045A0 RID: 17824
		// (get) Token: 0x0600891D RID: 35101 RVA: 0x007FADB8 File Offset: 0x007F8FB8
		// (set) Token: 0x0600891E RID: 35102 RVA: 0x007FAE6C File Offset: 0x007F906C
		internal bool RadErgCtrlHeadO5LongKeyPressTime_HiddenStatic
		{
			get
			{
				short num = (short)1322950959;
				short num2 = num;
				num = (short)1057988911;
				switch (num2 == num)
				{
				}
				num = (short)836894721;
				if (num != 0)
				{
				}
				num = (short)66650112;
				short num3 = num;
				num = (short)1034092544;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5LongKeyPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)1737877701;
				short num2 = num;
				num = (short)1829365957;
				switch (num2 == num)
				{
				}
				num = (short)1575288833;
				if (num != 0)
				{
				}
				num = (short)399572992;
				short num3 = num;
				num = (short)1628700672;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO5LongKeyPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x170045A1 RID: 17825
		// (get) Token: 0x0600891F RID: 35103 RVA: 0x007FAF20 File Offset: 0x007F9120
		// (set) Token: 0x06008920 RID: 35104 RVA: 0x007FAFD4 File Offset: 0x007F91D4
		internal bool RadErgCtrlHeadO5LongKeyPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)1289787420;
				short num2 = num;
				num = (short)1436194844;
				switch (num2 == num)
				{
				}
				num = (short)1259339776;
				if (num != 0)
				{
				}
				num = (short)1856045056;
				short num3 = num;
				num = (short)1697185793;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5LongKeyPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)2006384641;
				if (num != 0)
				{
				}
				num = (short)1071884279;
				short num2 = num;
				num = (short)2119084023;
				switch (num2 == num)
				{
				}
				num = (short)1686831104;
				short num3 = num;
				num = (short)57868288;
				if (num != 0)
				{
				}
				this.radErgCtrlHeadO5LongKeyPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x170045A2 RID: 17826
		// (get) Token: 0x06008921 RID: 35105 RVA: 0x007FB08C File Offset: 0x007F928C
		public bool RadErgCtrlHeadO5LongKeyPressTime_HasDiffs
		{
			get
			{
				short num = (short)1647863275;
				short num2 = num;
				num = (short)974808555;
				switch (num2 == num)
				{
				}
				num = (short)1118502913;
				if (num != 0)
				{
				}
				num = (short)253886464;
				short num3 = num;
				num = (short)1982201856;
				if (num != 0)
				{
				}
				return this.radErgCtrlHeadO5LongKeyPressTime._HasDiffs;
			}
		}

		// Token: 0x170045A3 RID: 17827
		// (get) Token: 0x06008922 RID: 35106 RVA: 0x007FB140 File Offset: 0x007F9340
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1961295873;
				if (num != 0)
				{
				}
				num = (short)554377205;
				short num2 = num;
				num = (short)48635893;
				switch (num2 == num)
				{
				}
				num = (short)731578368;
				short num3 = num;
				num = (short)305135616;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x170045A4 RID: 17828
		// (get) Token: 0x06008923 RID: 35107 RVA: 0x007FB200 File Offset: 0x007F9400
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)1616183297;
				if (num != 0)
				{
				}
				num = (short)1149652272;
				short num2 = num;
				num = (short)1422282032;
				switch (num2 == num)
				{
				}
				num = (short)9371648;
				short num3 = num;
				num = (short)999030784;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x06008924 RID: 35108 RVA: 0x007FB2C0 File Offset: 0x007F94C0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1909653506;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_118;
					case 1:
						if (base.ParentRecset != null)
						{
							num2 = (short)1686568963;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_118;
					case 2:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)967639044;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
					{
						num2 = (short)1972895744;
						short num3 = num2;
						num2 = (short)247136257;
						if (num2 != 0)
						{
						}
						num2 = (short)439287808;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 4:
						goto IL_D7;
					}
					goto IL_24;
				}
				IL_D7:
				IL_118:
				num2 = (short)1651079396;
				short num4 = num2;
				num2 = (short)734623972;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_26;
				default:
					num2 = (short)258605056;
					if (num2 != 0)
					{
					}
					return result;
				}
				break;
			}
			}
			IL_24:
			result = null;
			IL_26:
			num2 = (short)698744833;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040040E1 RID: 16609
		private global::AcpBusinessLayer.AcpListField cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonBCO_A19753;

		// Token: 0x040040E2 RID: 16610
		private global::AcpBusinessLayer.AcpListField cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754;

		// Token: 0x040040E3 RID: 16611
		private global::AcpBusinessLayer.AcpKeyField cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonKey_A21193;

		// Token: 0x040040E4 RID: 16612
		private global::AcpBusinessLayer.AcpField<string> cntrlHeadO5SignalIndependentO5M5MXChiefCHButtonName_A22520;

		// Token: 0x040040E5 RID: 16613
		private global::AcpBusinessLayer.AcpCustomRangeField radErgCtrlHeadO5ShortKeyPressTime;

		// Token: 0x040040E6 RID: 16614
		private global::AcpBusinessLayer.AcpCustomRangeField radErgCtrlHeadO5LongKeyPressTime;
	}
}
