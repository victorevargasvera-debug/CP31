using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;
using Motorola.MackinawCPS.CoreFeatures.MenuItems;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.Switches;

namespace Motorola.MackinawCPS.CoreFeatures.SmartKeyFob
{
	// Token: 0x020002CF RID: 719
	[global::System.Serializable]
	public class SmartKeyFobButtonTableInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600772A RID: 30506 RVA: 0x006BCAAC File Offset: 0x006BACAC
		public SmartKeyFobButtonTableInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600772B RID: 30507 RVA: 0x006BCAC8 File Offset: 0x006BACC8
		protected SmartKeyFobButtonTableInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600772C RID: 30508 RVA: 0x006BCAE0 File Offset: 0x006BACE0
		public override void Init()
		{
			int a_ = 3;
			short num = (short)1270514712;
			short num2 = num;
			num = (short)1154909208;
			switch (num2 == num)
			{
			default:
			{
				num = (short)881393664;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1059913729;
			if (num != 0)
			{
			}
			num = (short)1407320064;
			if (num != 0)
			{
			}
			this.radErgoCfgFobButtonName_A41573 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇迉뻋꧍뿏金닓뇕黗뗙뻛鳝闟雡郣觥蛧ꓩ跫菭闯귱뗳싵짷쿹쯻췽", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.radErgoCfgFobButtonName_A41573.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgFobButtonName_A41573.DataTransferOrder = -1;
			this.radErgoCfgFobConventionalFeature_A41574 = new global::AcpBusinessLayer.AcpSparseLOVField(35, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.indexRadErgoCfgFobConventionalFeature_A41574LovStrs, global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.idRadErgoCfgFobConventionalFeature_A41574LovStrs), this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇迉뻋꧍뿏金닓뇕黗뗙뻛鷝迟賡鋣菥蛧黩藫臭黯鏱飳냵鷷鯹裻诽狿朁嬃䜅㰇㬉㤋㤍␏", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.RadErgoCfgFobConventionalFeature_A41574LovStrs);
			this.radErgoCfgFobConventionalFeature_A41574.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgFobConventionalFeature_A41574.DataTransferOrder = 128;
			this.radErgoCfgFobConventionalFeature_A41574.ValidateAcrossRecset = true;
			this.radErgoCfgFobTrunkingFeature_A41575 = new global::AcpBusinessLayer.AcpSparseLOVField(35, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.indexRadErgoCfgFobTrunkingFeature_A41575LovStrs, global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.idRadErgoCfgFobTrunkingFeature_A41575LovStrs), this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇迉뻋꧍뿏金닓뇕黗뗙뻛諝鋟韡諣跥臧蓩诫꣭闯鏱胳菵諷鿹ꏻ뿽㓿㌁㄃ㄅ㴇", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.RadErgoCfgFobTrunkingFeature_A41575LovStrs);
			this.radErgoCfgFobTrunkingFeature_A41575.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgFobTrunkingFeature_A41575.DataTransferOrder = 142;
			this.radErgoCfgFobTrunkingFeature_A41575.ValidateAcrossRecset = true;
			this.radErgoCfgFobConventionalBCO_A41577 = new global::AcpBusinessLayer.AcpSparseLOVField(40, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.indexRadErgoCfgFobConventionalBCO_A41577LovStrs, global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.idRadErgoCfgFobConventionalBCO_A41577LovStrs), this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇迉뻋꧍뿏金닓뇕黗뗙뻛鷝迟賡鋣菥蛧黩藫臭黯鏱飳듵믷뗹ꏻ뿽㓿㌁㄃ㄅ㼇", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBCO, global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.RadErgoCfgFobConventionalBCO_A41577LovStrs);
			this.radErgoCfgFobConventionalBCO_A41577.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgFobConventionalBCO_A41577.DataTransferOrder = 125;
			this.radErgoCfgFobTrunkingBCO_A41578 = new global::AcpBusinessLayer.AcpSparseLOVField(40, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.indexRadErgoCfgFobTrunkingBCO_A41578LovStrs, global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.idRadErgoCfgFobTrunkingBCO_A41578LovStrs), this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇迉뻋꧍뿏金닓뇕黗뗙뻛諝鋟韡諣跥臧蓩诫곭돯뷱꯳럵쳷쯹짻짽㣿", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.RadErgoCfgFobTrunkingBCO_A41578LovStrs);
			this.radErgoCfgFobTrunkingBCO_A41578.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgFobTrunkingBCO_A41578.DataTransferOrder = 130;
			this.radErgoCfgSmartKeyFobButtonKey_A41579 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇迉뻋꧍뿏金닓뇕诗럙뷛곝铟ꧡ臣鿥껧藩軫곭藯蛱胳駵雷뇹駻蟽忿䌁〃㜅㴇㴉㔋", a_), global::CommonResources.AcgResources.ID_KEY);
			this.radErgoCfgSmartKeyFobButtonKey_A41579.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgSmartKeyFobButtonKey_A41579.DataTransferOrder = -1;
			this.radErgoCfgSmartKeyFobShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇迉뻋꧍뿏金닓뇕诗럙뷛곝铟ꧡ臣鿥껧藩軫뷭飯鷱蛳苵ꣷ裹駻跽珿嘁洃欅洇", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
			this.radErgoCfgSmartKeyFobShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgSmartKeyFobShortPressTime.DataTransferOrder = -1;
			this.radErgoCfgSmartKeyFobShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.radErgoCfgSmartKeyFobShortPressTime.ShowHexValue = false;
			this.radErgoCfgSmartKeyFobShortPressTime.ValidateAcrossRecset = true;
			this.radErgoCfgSmartKeyFobLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇迉뻋꧍뿏金닓뇕诗럙뷛곝铟ꧡ臣鿥껧藩軫ꋭ鿯鳱鏳꛵諷鿹迻跽哿欁椃挅", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
			this.radErgoCfgSmartKeyFobLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgSmartKeyFobLongPressTime.DataTransferOrder = -1;
			this.radErgoCfgSmartKeyFobLongPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.radErgoCfgSmartKeyFobLongPressTime.ShowHexValue = false;
			this.radErgoCfgSmartKeyFobLongPressTime.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("韃ꯅ꧇룉룋鯏럑귓黗뗙뻛ﻝꋟ韡郣鋥蟧蓩쳫뫭釯郱飳鏵", a_);
			base.Id = 10748;
			base.UIName = global::CommonResources.AcgResources.ID_SMARTKEYFOBBUTTONTABLE;
			base.DataTransferOrder = 124;
		}

		// Token: 0x0600772D RID: 30509 RVA: 0x006BCE78 File Offset: 0x006BB078
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)1996750871;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.radErgoCfgSmartKeyFobShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠냢裤蛦鯨鿪ꛬ諮裰뗲髴闶꫸鏺鋼跾甀匂眄戆稈砊夌明簐瘒", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
					this.radErgoCfgSmartKeyFobShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgSmartKeyFobShortPressTime.DataTransferOrder = -1;
					this.radErgoCfgSmartKeyFobShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.radErgoCfgSmartKeyFobShortPressTime.ShowHexValue = false;
					this.radErgoCfgSmartKeyFobShortPressTime.ValidateAcrossRecset = true;
					num = (short)1264517133;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)184221697;
					if (num != 0)
					{
					}
					this.radErgoCfgSmartKeyFobLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠냢裤蛦鯨鿪ꛬ諮裰뗲髴闶뗸铺鏼飾儀焂怄理稈弊搌戎琐", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
					this.radErgoCfgSmartKeyFobLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgSmartKeyFobLongPressTime.DataTransferOrder = -1;
					this.radErgoCfgSmartKeyFobLongPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.radErgoCfgSmartKeyFobLongPressTime.ShowHexValue = false;
					this.radErgoCfgSmartKeyFobLongPressTime.ValidateAcrossRecset = true;
					goto IL_54D;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠ꗢ諤藦뷨駪飬臮髰髲鯴郶뿸黺鳼课琀焂怄堆䠈㼊㰌㨎☐☒", a_)))
					{
						num = (short)574816277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_39A;
				case 3:
					num = (short)497942534;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_39A;
				case 5:
					if (producerFields != null)
					{
						num = (short)2072903683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7A0;
				case 6:
				{
					if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠ꗢ諤藦ꯨ黪駬鯮黰鷲믴零铸黺ꋼ뻾㔀㈂〄〆㨈", a_)))
					{
						goto IL_186;
					}
					num = (short)784259865;
					short num3 = num;
					num = (short)1304156953;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_54D;
					default:
						num = (short)680853504;
						if (num != 0)
						{
						}
						num = (short)454098963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠냢裤蛦鯨鿪ꛬ諮裰뗲髴闶미軺觼课渀洂丄戆瀈吊䰌㬎‐☒∔⸖", a_)))
					{
						num = (short)373030928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_463;
				case 8:
					goto IL_186;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠냢裤蛦鯨鿪ꛬ諮裰뗲髴闶꫸鏺鋼跾甀匂眄戆稈砊夌明簐瘒", a_)))
					{
						num = (short)915472384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_34C;
				case 10:
					goto IL_463;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠ꗢ諤藦ꫨ蓪菬駮铰鷲致黶雸闺鳼鏾䜀昂搄猆簈礊栌倎倐✒␔∖⸘⼚", a_)))
					{
						num = (short)1675100184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_56A;
				case 12:
					goto IL_110;
				case 13:
					goto IL_34C;
				case 14:
					goto IL_565;
				case 15:
					this.radErgoCfgFobTrunkingBCO_A41578 = new global::AcpBusinessLayer.AcpSparseLOVField(40, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.indexRadErgoCfgFobTrunkingBCO_A41578LovStrs, global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.idRadErgoCfgFobTrunkingBCO_A41578LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠ꗢ諤藦뷨駪飬臮髰髲鯴郶미룺닼ꃾ䀀㜂㐄㈆㸈㌊", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.RadErgoCfgFobTrunkingBCO_A41578LovStrs);
					this.radErgoCfgFobTrunkingBCO_A41578.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgFobTrunkingBCO_A41578.DataTransferOrder = 130;
					num = (short)308346897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					this.radErgoCfgSmartKeyFobButtonKey_A41579 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠냢裤蛦鯨鿪ꛬ諮裰뗲髴闶미軺觼课渀洂丄戆瀈吊䰌㬎‐☒∔⸖", a_), global::CommonResources.AcgResources.ID_KEY);
					this.radErgoCfgSmartKeyFobButtonKey_A41579.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgSmartKeyFobButtonKey_A41579.DataTransferOrder = -1;
					num = (short)1352400906;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_C3;
				case 18:
				{
					num = (short)1242431488;
					short num4 = num;
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠ꗢ諤藦뷨駪飬臮髰髲鯴郶미룺닼ꃾ䀀㜂㐄㈆㸈㌊", a_)))
					{
						num = (short)256311311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C3;
				}
				case 19:
					this.radErgoCfgFobButtonName_A41573 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠ꗢ諤藦ꯨ黪駬鯮黰鷲믴零铸黺ꋼ뻾㔀㈂〄〆㨈", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.radErgoCfgFobButtonName_A41573.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgFobButtonName_A41573.DataTransferOrder = -1;
					num = (short)2096168968;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠냢裤蛦鯨鿪ꛬ諮裰뗲髴闶뗸铺鏼飾儀焂怄理稈弊搌戎琐", a_)))
					{
						num = (short)2054750209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7A0;
				case 21:
					this.radErgoCfgFobTrunkingFeature_A41575 = new global::AcpBusinessLayer.AcpSparseLOVField(35, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.indexRadErgoCfgFobTrunkingFeature_A41575LovStrs, global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.idRadErgoCfgFobTrunkingFeature_A41575LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠ꗢ諤藦뷨駪飬臮髰髲鯴郶뿸黺鳼课琀焂怄堆䠈㼊㰌㨎☐☒", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.RadErgoCfgFobTrunkingFeature_A41575LovStrs);
					this.radErgoCfgFobTrunkingFeature_A41575.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgFobTrunkingFeature_A41575.DataTransferOrder = 142;
					this.radErgoCfgFobTrunkingFeature_A41575.ValidateAcrossRecset = true;
					num = (short)1441005572;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠ꗢ諤藦ꫨ蓪菬駮铰鷲致黶雸闺鳼鏾䌀䀂䨄堆䠈㼊㰌㨎☐␒", a_)))
					{
						num = (short)1205338138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_110;
				case 23:
					switch (0)
					{
					case 0:
						goto IL_9D;
					}
					continue;
				case 24:
					this.radErgoCfgFobConventionalFeature_A41574 = new global::AcpBusinessLayer.AcpSparseLOVField(35, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.indexRadErgoCfgFobConventionalFeature_A41574LovStrs, global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.idRadErgoCfgFobConventionalFeature_A41574LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠ꗢ諤藦ꫨ蓪菬駮铰鷲致黶雸闺鳼鏾䜀昂搄猆簈礊栌倎倐✒␔∖⸘⼚", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.RadErgoCfgFobConventionalFeature_A41574LovStrs);
					this.radErgoCfgFobConventionalFeature_A41574.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgFobConventionalFeature_A41574.DataTransferOrder = 128;
					this.radErgoCfgFobConventionalFeature_A41574.ValidateAcrossRecset = true;
					num = (short)2083061785;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					goto IL_56A;
				case 26:
					this.radErgoCfgFobConventionalBCO_A41577 = new global::AcpBusinessLayer.AcpSparseLOVField(40, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.indexRadErgoCfgFobConventionalBCO_A41577LovStrs, global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.idRadErgoCfgFobConventionalBCO_A41577LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠ꗢ諤藦ꫨ蓪菬駮铰鷲致黶雸闺鳼鏾䌀䀂䨄堆䠈㼊㰌㨎☐␒", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBCO, global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.LOVs.RadErgoCfgFobConventionalBCO_A41577LovStrs);
					this.radErgoCfgFobConventionalBCO_A41577.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgFobConventionalBCO_A41577.DataTransferOrder = 125;
					num = (short)1407909900;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					num = (short)284688389;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)505282587;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_C3:
				num = (short)1203699719;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_110:
				num = (short)72810514;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_186:
				num = (short)612696075;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_34C:
				num = (short)1593966612;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_39A:
				num = (short)327702;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_463:
				num = (short)1651048457;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_54D:
				num = (short)174063630;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_56A:
				num = (short)457310210;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_565:
			IL_7A0:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鳎볐닒꟔ꏖ律郚룜ꛞ쇠ꗢ諤藦짨ꧪ飬鯮藰鳲鯴ퟶ그髺鿼鏾搀", a_);
			base.Id = 10748;
			base.UIName = global::CommonResources.AcgResources.ID_SMARTKEYFOBBUTTONTABLE;
			base.DataTransferOrder = 124;
		}

		// Token: 0x0600772E RID: 30510 RVA: 0x006BD658 File Offset: 0x006BB858
		public override void PopulateReferences()
		{
			short num = (short)1758018186;
			short num2 = num;
			num = (short)1326856842;
			switch (num2 == num)
			{
			}
			num = (short)705888256;
			if (num != 0)
			{
			}
			num = (short)2038038528;
			short num3 = num;
			num = (short)40042497;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600772F RID: 30511 RVA: 0x006BD704 File Offset: 0x006BB904
		public override void DropReferences()
		{
			short num = (short)2126081002;
			short num2 = num;
			num = (short)811297770;
			switch (num2 == num)
			{
			}
			num = (short)190906369;
			if (num != 0)
			{
			}
			num = (short)127926272;
			short num3 = num;
			num = (short)957284352;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007730 RID: 30512 RVA: 0x006BD7B0 File Offset: 0x006BB9B0
		public override void SetConstraints()
		{
			short num = (short)695935867;
			short num2 = num;
			num = (short)1607869307;
			switch (num2 == num)
			{
			}
			num = (short)627572737;
			if (num != 0)
			{
			}
			num = (short)751632384;
			short num3 = num;
			num = (short)63766528;
			if (num != 0)
			{
			}
			this.radErgoCfgFobButtonName_A41573.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radErgoCfgFobConventionalFeature_A41574.ValidateAcrossRecset = true;
			this.radErgoCfgFobConventionalFeature_A41574.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobConstraints.conFobConventionalTriggerProRSMButTableFeature);
			this.radErgoCfgFobConventionalFeature_A41574.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobConstraints.ConConventionalFobFeaturesValid);
			this.radErgoCfgFobConventionalFeature_A41574.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobConstraints.conUpdateFieldsDepOnFobCnvButton);
			this.radErgoCfgFobTrunkingFeature_A41575.ValidateAcrossRecset = true;
			this.radErgoCfgFobTrunkingFeature_A41575.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobConstraints.conFobTrunkingTriggerProRSMButTableFeature);
			this.radErgoCfgFobTrunkingFeature_A41575.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobConstraints.ConTrunkingFobFeaturesValid);
			this.radErgoCfgFobTrunkingFeature_A41575.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobConstraints.conSetEditabilityFobTrkFeature);
		}

		// Token: 0x06007731 RID: 30513 RVA: 0x006BD914 File Offset: 0x006BBB14
		public override void SetupDependencies()
		{
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
			for (;;)
			{
				IL_0A:
				num = (short)501874688;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_84B;
				case 1:
				{
					num = (short)2065075848;
					short num4 = num;
					num = (short)443715208;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7C1;
					default:
						goto IL_80E;
					}
					break;
				}
				case 2:
				{
					global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2045);
					if (feature == null)
					{
						goto IL_7C1;
					}
					acpFeatureNode = feature[0];
					if (acpFeatureNode == null)
					{
						num = (short)1875050496;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_84E;
				}
				}
				goto IL_45;
				IL_7C1:
				num = (short)992935937;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_80E:
			num = (short)16973824;
			if (num != 0)
			{
			}
			object obj = null;
			goto IL_85A;
			IL_84B:
			obj = null;
			goto IL_85A;
			IL_84E:
			obj = acpFeatureNode[10105];
			IL_85A:
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features = obj as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features;
			if (features != null)
			{
				features.RadWideFeaturesChannelFallbackEnable.AddDependentObject(this.radErgoCfgFobConventionalFeature_A41574);
			}
			if (features == null)
			{
				return;
			}
			features.RadWideFeaturesChannelFallbackEnable.AddDependentObject(this.radErgoCfgFobTrunkingFeature_A41575);
			return;
			IL_45:
			num = (short)274661377;
			if (num != 0)
			{
			}
			this.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836.AddDependentObject(this.radErgoCfgFobConventionalFeature_A41574);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.AddDependentObject(this.radErgoCfgFobConventionalFeature_A41574);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.AddDependentObject(this.radErgoCfgFobConventionalFeature_A41574);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.AddDependentObject(this.radErgoCfgFobConventionalFeature_A41574);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.AddDependentObject(this.radErgoCfgFobConventionalFeature_A41574);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.AddDependentObject(this.radErgoCfgFobConventionalFeature_A41574);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.AddDependentObject(this.radErgoCfgFobConventionalFeature_A41574);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.AddDependentObject(this.radErgoCfgFobConventionalFeature_A41574);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.AddDependentObject(this.radErgoCfgFobConventionalFeature_A41574);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.AddDependentObject(this.radErgoCfgFobConventionalFeature_A41574);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.AddDependentObject(this.radErgoCfgFobConventionalFeature_A41574);
			this.RefMenuItems.General.DispMenuConventionalSelectedMenuItems_A21736.AddDependentObject(this.radErgoCfgFobConventionalFeature_A41574);
			this.RefMenuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.AddDependentObject(this.radErgoCfgFobConventionalFeature_A41574);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.AddDependentObject(this.radErgoCfgFobConventionalFeature_A41574);
			this.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.AddDependentObject(this.radErgoCfgFobConventionalFeature_A41574);
			this.radErgoCfgFobTrunkingFeature_A41575.AddDependentObject(this.radErgoCfgFobConventionalFeature_A41574);
			this.radErgoCfgFobConventionalFeature_A41574.AddDependentObject(this.radErgoCfgFobTrunkingFeature_A41575);
			this.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836.AddDependentObject(this.radErgoCfgFobTrunkingFeature_A41575);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.AddDependentObject(this.radErgoCfgFobTrunkingFeature_A41575);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.AddDependentObject(this.radErgoCfgFobTrunkingFeature_A41575);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.AddDependentObject(this.radErgoCfgFobTrunkingFeature_A41575);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.AddDependentObject(this.radErgoCfgFobTrunkingFeature_A41575);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.AddDependentObject(this.radErgoCfgFobTrunkingFeature_A41575);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.AddDependentObject(this.radErgoCfgFobTrunkingFeature_A41575);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.AddDependentObject(this.radErgoCfgFobTrunkingFeature_A41575);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.AddDependentObject(this.radErgoCfgFobTrunkingFeature_A41575);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.AddDependentObject(this.radErgoCfgFobTrunkingFeature_A41575);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.AddDependentObject(this.radErgoCfgFobTrunkingFeature_A41575);
			this.RefMenuItems.General.DispMenuConventionalSelectedMenuItems_A21736.AddDependentObject(this.radErgoCfgFobTrunkingFeature_A41575);
			this.RefMenuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.AddDependentObject(this.radErgoCfgFobTrunkingFeature_A41575);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.AddDependentObject(this.radErgoCfgFobTrunkingFeature_A41575);
			this.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.AddDependentObject(this.radErgoCfgFobTrunkingFeature_A41575);
			this.radErgoCfgFobConventionalFeature_A41574.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition1_A7734);
			this.radErgoCfgFobConventionalFeature_A41574.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition2_A7735);
			this.radErgoCfgFobConventionalFeature_A41574.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition3_A7737);
			this.radErgoCfgFobConventionalFeature_A41574.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition2_A9467);
			this.radErgoCfgFobConventionalFeature_A41574.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition3_A9468);
			this.radErgoCfgFobConventionalFeature_A41574.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition1_A9466);
			this.radErgoCfgFobConventionalFeature_A41574.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition4_A21534);
			this.radErgoCfgFobConventionalFeature_A41574.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition5_A21535);
			this.radErgoCfgFobConventionalFeature_A41574.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition4_A21530);
			this.radErgoCfgFobConventionalFeature_A41574.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition5_A21531);
			this.radErgoCfgFobTrunkingFeature_A41575.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition1_A7734);
			this.radErgoCfgFobTrunkingFeature_A41575.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition2_A7735);
			this.radErgoCfgFobTrunkingFeature_A41575.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition3_A7737);
			this.radErgoCfgFobTrunkingFeature_A41575.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition2_A9467);
			this.radErgoCfgFobTrunkingFeature_A41575.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition3_A9468);
			this.radErgoCfgFobTrunkingFeature_A41575.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition1_A9466);
			this.radErgoCfgFobTrunkingFeature_A41575.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition4_A21534);
			this.radErgoCfgFobTrunkingFeature_A41575.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition5_A21535);
			this.radErgoCfgFobTrunkingFeature_A41575.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition4_A21530);
			this.radErgoCfgFobTrunkingFeature_A41575.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition5_A21531);
			num = (short)177668098;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x17003D4D RID: 15693
		// (get) Token: 0x06007732 RID: 30514 RVA: 0x006BE1B4 File Offset: 0x006BC3B4
		public bool HasDiffs
		{
			get
			{
				short num = (short)74366522;
				short num2 = num;
				num = (short)30457402;
				switch (num2 == num)
				{
				}
				num = (short)1175846912;
				if (num != 0)
				{
				}
				num = (short)759103488;
				short num3 = num;
				num = (short)1425801217;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003D4E RID: 15694
		// (get) Token: 0x06007733 RID: 30515 RVA: 0x006BE264 File Offset: 0x006BC464
		// (set) Token: 0x06007734 RID: 30516 RVA: 0x006BE318 File Offset: 0x006BC518
		public string RadErgoCfgFobButtonName_A41573Value
		{
			get
			{
				short num = (short)1122131316;
				short num2 = num;
				num = (short)937713012;
				switch (num2 == num)
				{
				}
				num = (short)1505165313;
				if (num != 0)
				{
				}
				num = (short)935723008;
				short num3 = num;
				num = (short)402522112;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobButtonName_A41573.Value;
			}
			set
			{
				short num = (short)1498620758;
				short num2 = num;
				num = (short)158409558;
				switch (num2 == num)
				{
				}
				num = (short)1278279681;
				if (num != 0)
				{
				}
				num = (short)271450112;
				short num3 = num;
				num = (short)219217920;
				if (num != 0)
				{
				}
				this.radErgoCfgFobButtonName_A41573.Value = value;
			}
		}

		// Token: 0x17003D4F RID: 15695
		// (get) Token: 0x06007735 RID: 30517 RVA: 0x006BE3D0 File Offset: 0x006BC5D0
		public global::AcpBusinessLayer.AcpField<string> RadErgoCfgFobButtonName_A41573
		{
			get
			{
				short num = (short)307515677;
				short num2 = num;
				num = (short)723472669;
				switch (num2 == num)
				{
				}
				num = (short)496041985;
				if (num != 0)
				{
				}
				num = (short)1308164096;
				short num3 = num;
				num = (short)1988296704;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobButtonName_A41573;
			}
		}

		// Token: 0x17003D50 RID: 15696
		// (get) Token: 0x06007736 RID: 30518 RVA: 0x006BE47C File Offset: 0x006BC67C
		// (set) Token: 0x06007737 RID: 30519 RVA: 0x006BE530 File Offset: 0x006BC730
		public string RadErgoCfgFobButtonName_A41573_UIValue
		{
			get
			{
				short num = (short)1898088206;
				short num2 = num;
				num = (short)1824229134;
				switch (num2 == num)
				{
				}
				num = (short)335151105;
				if (num != 0)
				{
				}
				num = (short)538968064;
				short num3 = num;
				num = (short)1859649536;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobButtonName_A41573.Value;
			}
			set
			{
				short num = (short)501397105;
				short num2 = num;
				num = (short)246789745;
				switch (num2 == num)
				{
				}
				num = (short)1563885569;
				if (num != 0)
				{
				}
				num = (short)926351360;
				short num3 = num;
				num = (short)1270349824;
				if (num != 0)
				{
				}
				this.radErgoCfgFobButtonName_A41573.Value = value;
			}
		}

		// Token: 0x17003D51 RID: 15697
		// (get) Token: 0x06007738 RID: 30520 RVA: 0x006BE5E8 File Offset: 0x006BC7E8
		// (set) Token: 0x06007739 RID: 30521 RVA: 0x006BE69C File Offset: 0x006BC89C
		public bool RadErgoCfgFobButtonName_A41573_Applicable
		{
			get
			{
				short num = (short)341442910;
				short num2 = num;
				num = (short)361824606;
				switch (num2 == num)
				{
				}
				num = (short)1399652353;
				if (num != 0)
				{
				}
				num = (short)896663552;
				short num3 = num;
				num = (short)259457024;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobButtonName_A41573.Applicable;
			}
			set
			{
				short num = (short)1976648753;
				short num2 = num;
				num = (short)777274417;
				switch (num2 == num)
				{
				}
				num = (short)1587871744;
				if (num != 0)
				{
				}
				num = (short)7012352;
				short num3 = num;
				num = (short)1305608193;
				if (num != 0)
				{
				}
				this.radErgoCfgFobButtonName_A41573.Applicable = value;
			}
		}

		// Token: 0x17003D52 RID: 15698
		// (get) Token: 0x0600773A RID: 30522 RVA: 0x006BE750 File Offset: 0x006BC950
		// (set) Token: 0x0600773B RID: 30523 RVA: 0x006BE804 File Offset: 0x006BCA04
		public bool RadErgoCfgFobButtonName_A41573_Valid
		{
			get
			{
				short num = (short)922681344;
				short num2 = num;
				num = (short)1728274947;
				short num3 = num;
				num = (short)1222074883;
				switch (num3 == num)
				{
				}
				num = (short)1455226881;
				if (num != 0)
				{
				}
				num = (short)2036006912;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobButtonName_A41573.Valid;
			}
			set
			{
				short num = (short)397344768;
				short num2 = num;
				num = (short)1689075114;
				short num3 = num;
				num = (short)1349991850;
				switch (num3 == num)
				{
				}
				num = (short)2108555264;
				if (num != 0)
				{
				}
				num = (short)1827536897;
				if (num != 0)
				{
				}
				this.radErgoCfgFobButtonName_A41573.Valid = value;
			}
		}

		// Token: 0x17003D53 RID: 15699
		// (get) Token: 0x0600773C RID: 30524 RVA: 0x006BE8B8 File Offset: 0x006BCAB8
		// (set) Token: 0x0600773D RID: 30525 RVA: 0x006BE968 File Offset: 0x006BCB68
		public bool RadErgoCfgFobButtonName_A41573_Visible
		{
			get
			{
				short num = (short)641859584;
				short num2 = num;
				num = (short)2097770665;
				short num3 = num;
				num = (short)2078240937;
				switch (num3 == num)
				{
				}
				num = (short)161808385;
				if (num != 0)
				{
				}
				num = (short)888537088;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobButtonName_A41573.Visible;
			}
			set
			{
				short num = (short)2104098816;
				short num2 = num;
				num = (short)1959927304;
				short num3 = num;
				num = (short)239607304;
				switch (num3 == num)
				{
				}
				num = (short)1933377537;
				if (num != 0)
				{
				}
				num = (short)1641742336;
				if (num != 0)
				{
				}
				this.radErgoCfgFobButtonName_A41573.Visible = value;
			}
		}

		// Token: 0x17003D54 RID: 15700
		// (get) Token: 0x0600773E RID: 30526 RVA: 0x006BEA20 File Offset: 0x006BCC20
		// (set) Token: 0x0600773F RID: 30527 RVA: 0x006BEAD4 File Offset: 0x006BCCD4
		public bool RadErgoCfgFobButtonName_A41573_Editable
		{
			get
			{
				short num = (short)1710817280;
				short num2 = num;
				num = (short)1821084094;
				short num3 = num;
				num = (short)1394575806;
				switch (num3 == num)
				{
				}
				num = (short)1611005953;
				if (num != 0)
				{
				}
				num = (short)1009778688;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobButtonName_A41573.Editable;
			}
			set
			{
				short num = (short)618332160;
				short num2 = num;
				num = (short)1363195391;
				short num3 = num;
				num = (short)158578175;
				switch (num3 == num)
				{
				}
				num = (short)798949376;
				if (num != 0)
				{
				}
				num = (short)1319632897;
				if (num != 0)
				{
				}
				this.radErgoCfgFobButtonName_A41573.Editable = value;
			}
		}

		// Token: 0x17003D55 RID: 15701
		// (get) Token: 0x06007740 RID: 30528 RVA: 0x006BEB8C File Offset: 0x006BCD8C
		internal string RadErgoCfgFobButtonName_A41573_UILabel
		{
			get
			{
				short num = (short)73531392;
				short num2 = num;
				num = (short)1148224893;
				short num3 = num;
				num = (short)1628931453;
				switch (num3 == num)
				{
				}
				num = (short)527695872;
				if (num != 0)
				{
				}
				num = (short)1226506241;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobButtonName_A41573.UIName;
			}
		}

		// Token: 0x17003D56 RID: 15702
		// (get) Token: 0x06007741 RID: 30529 RVA: 0x006BEC40 File Offset: 0x006BCE40
		// (set) Token: 0x06007742 RID: 30530 RVA: 0x006BECF8 File Offset: 0x006BCEF8
		internal bool RadErgoCfgFobButtonName_A41573_HiddenStatic
		{
			get
			{
				short num = (short)1764622336;
				short num2 = num;
				num = (short)1110978022;
				short num3 = num;
				num = (short)1031810534;
				switch (num3 == num)
				{
				}
				num = (short)159842305;
				if (num != 0)
				{
				}
				num = (short)547487744;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobButtonName_A41573.HiddenStatic;
			}
			set
			{
				short num = (short)1178796032;
				short num2 = num;
				num = (short)1856215689;
				short num3 = num;
				num = (short)1534630537;
				switch (num3 == num)
				{
				}
				num = (short)1909981185;
				if (num != 0)
				{
				}
				num = (short)1947533312;
				if (num != 0)
				{
				}
				this.radErgoCfgFobButtonName_A41573.HiddenStatic = value;
			}
		}

		// Token: 0x17003D57 RID: 15703
		// (get) Token: 0x06007743 RID: 30531 RVA: 0x006BEDAC File Offset: 0x006BCFAC
		// (set) Token: 0x06007744 RID: 30532 RVA: 0x006BEE60 File Offset: 0x006BD060
		internal bool RadErgoCfgFobButtonName_A41573_HiddenDynamic
		{
			get
			{
				short num = (short)786366464;
				short num2 = num;
				num = (short)1046007942;
				short num3 = num;
				num = (short)734515334;
				switch (num3 == num)
				{
				}
				num = (short)1583546369;
				if (num != 0)
				{
				}
				num = (short)1227292672;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobButtonName_A41573.HiddenDynamic;
			}
			set
			{
				short num = (short)1702887424;
				short num2 = num;
				num = (short)303282361;
				short num3 = num;
				num = (short)2127935673;
				switch (num3 == num)
				{
				}
				num = (short)2126708737;
				if (num != 0)
				{
				}
				num = (short)1736900608;
				if (num != 0)
				{
				}
				this.radErgoCfgFobButtonName_A41573.HiddenDynamic = value;
			}
		}

		// Token: 0x17003D58 RID: 15704
		// (get) Token: 0x06007745 RID: 30533 RVA: 0x006BEF14 File Offset: 0x006BD114
		public bool RadErgoCfgFobButtonName_A41573_HasDiffs
		{
			get
			{
				short num = (short)773521408;
				short num2 = num;
				num = (short)449376982;
				short num3 = num;
				num = (short)875950806;
				switch (num3 == num)
				{
				}
				num = (short)1362427905;
				if (num != 0)
				{
				}
				num = (short)843382784;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobButtonName_A41573._HasDiffs;
			}
		}

		// Token: 0x17003D59 RID: 15705
		// (get) Token: 0x06007746 RID: 30534 RVA: 0x006BEFC8 File Offset: 0x006BD1C8
		// (set) Token: 0x06007747 RID: 30535 RVA: 0x006BF07C File Offset: 0x006BD27C
		public int RadErgoCfgFobConventionalFeature_A41574Value
		{
			get
			{
				short num = (short)1662517248;
				short num2 = num;
				num = (short)203323644;
				short num3 = num;
				num = (short)1050179836;
				switch (num3 == num)
				{
				}
				num = (short)1024589825;
				if (num != 0)
				{
				}
				num = (short)1043988480;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalFeature_A41574.Value;
			}
			set
			{
				short num = (short)559218688;
				short num2 = num;
				num = (short)1035804387;
				short num3 = num;
				num = (short)529997539;
				switch (num3 == num)
				{
				}
				num = (short)189202433;
				if (num != 0)
				{
				}
				num = (short)971505664;
				if (num != 0)
				{
				}
				this.radErgoCfgFobConventionalFeature_A41574.Value = value;
			}
		}

		// Token: 0x17003D5A RID: 15706
		// (get) Token: 0x06007748 RID: 30536 RVA: 0x006BF130 File Offset: 0x006BD330
		// (set) Token: 0x06007749 RID: 30537 RVA: 0x006BF1E4 File Offset: 0x006BD3E4
		public string RadErgoCfgFobConventionalFeature_A41574_UIValue
		{
			get
			{
				short num = (short)1383006208;
				short num2 = num;
				num = (short)1208571789;
				short num3 = num;
				num = (short)416634765;
				switch (num3 == num)
				{
				}
				num = (short)399245312;
				if (num != 0)
				{
				}
				num = (short)183631873;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalFeature_A41574.UIValue;
			}
			set
			{
				short num = (short)757399552;
				short num2 = num;
				num = (short)2075826617;
				short num3 = num;
				num = (short)707893689;
				switch (num3 == num)
				{
				}
				num = (short)518324225;
				if (num != 0)
				{
				}
				num = (short)1436090368;
				if (num != 0)
				{
				}
				this.radErgoCfgFobConventionalFeature_A41574.UIValue = value;
			}
		}

		// Token: 0x17003D5B RID: 15707
		// (get) Token: 0x0600774A RID: 30538 RVA: 0x006BF29C File Offset: 0x006BD49C
		public global::AcpBusinessLayer.AcpListField RadErgoCfgFobConventionalFeature_A41574
		{
			get
			{
				short num = (short)1346371584;
				short num2 = num;
				num = (short)1728349658;
				short num3 = num;
				num = (short)1488946650;
				switch (num3 == num)
				{
				}
				num = (short)309460992;
				if (num != 0)
				{
				}
				num = (short)1905917953;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalFeature_A41574;
			}
		}

		// Token: 0x17003D5C RID: 15708
		// (get) Token: 0x0600774B RID: 30539 RVA: 0x006BF34C File Offset: 0x006BD54C
		// (set) Token: 0x0600774C RID: 30540 RVA: 0x006BF400 File Offset: 0x006BD600
		public bool RadErgoCfgFobConventionalFeature_A41574_Applicable
		{
			get
			{
				short num = (short)525271040;
				short num2 = num;
				num = (short)747896413;
				short num3 = num;
				num = (short)1581579869;
				switch (num3 == num)
				{
				}
				num = (short)1271660544;
				if (num != 0)
				{
				}
				num = (short)105381889;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalFeature_A41574.Applicable;
			}
			set
			{
				short num = (short)834863104;
				short num2 = num;
				num = (short)365297665;
				if (num != 0)
				{
				}
				num = (short)2062851967;
				short num3 = num;
				num = (short)1403035519;
				switch (num3 == num)
				{
				}
				num = (short)1332412416;
				if (num != 0)
				{
				}
				this.radErgoCfgFobConventionalFeature_A41574.Applicable = value;
			}
		}

		// Token: 0x17003D5D RID: 15709
		// (get) Token: 0x0600774D RID: 30541 RVA: 0x006BF4B4 File Offset: 0x006BD6B4
		// (set) Token: 0x0600774E RID: 30542 RVA: 0x006BF568 File Offset: 0x006BD768
		public bool RadErgoCfgFobConventionalFeature_A41574_Valid
		{
			get
			{
				short num = (short)357302272;
				short num2 = num;
				num = (short)928621666;
				short num3 = num;
				num = (short)1520804962;
				switch (num3 == num)
				{
				}
				num = (short)57540608;
				if (num != 0)
				{
				}
				num = (short)334495745;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalFeature_A41574.Valid;
			}
			set
			{
				short num = (short)1213005824;
				short num2 = num;
				num = (short)2103018210;
				short num3 = num;
				num = (short)89555682;
				switch (num3 == num)
				{
				}
				num = (short)1203765249;
				if (num != 0)
				{
				}
				num = (short)872546304;
				if (num != 0)
				{
				}
				this.radErgoCfgFobConventionalFeature_A41574.Valid = value;
			}
		}

		// Token: 0x17003D5E RID: 15710
		// (get) Token: 0x0600774F RID: 30543 RVA: 0x006BF61C File Offset: 0x006BD81C
		// (set) Token: 0x06007750 RID: 30544 RVA: 0x006BF6D0 File Offset: 0x006BD8D0
		public bool RadErgoCfgFobConventionalFeature_A41574_Visible
		{
			get
			{
				short num = (short)44630016;
				short num2 = num;
				num = (short)931964434;
				short num3 = num;
				num = (short)107259410;
				switch (num3 == num)
				{
				}
				num = (short)1059586049;
				if (num != 0)
				{
				}
				num = (short)439353344;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalFeature_A41574.Visible;
			}
			set
			{
				short num = (short)2029256704;
				short num2 = num;
				num = (short)1395695970;
				short num3 = num;
				num = (short)551985506;
				switch (num3 == num)
				{
				}
				num = (short)772800513;
				if (num != 0)
				{
				}
				num = (short)908656640;
				if (num != 0)
				{
				}
				this.radErgoCfgFobConventionalFeature_A41574.Visible = value;
			}
		}

		// Token: 0x17003D5F RID: 15711
		// (get) Token: 0x06007751 RID: 30545 RVA: 0x006BF788 File Offset: 0x006BD988
		// (set) Token: 0x06007752 RID: 30546 RVA: 0x006BF840 File Offset: 0x006BDA40
		public bool RadErgoCfgFobConventionalFeature_A41574_Editable
		{
			get
			{
				short num = (short)938213376;
				short num2 = num;
				num = (short)1293392434;
				short num3 = num;
				num = (short)595106354;
				switch (num3 == num)
				{
				}
				num = (short)852492289;
				if (num != 0)
				{
				}
				num = (short)1261568000;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalFeature_A41574.Editable;
			}
			set
			{
				short num = (short)2095382528;
				short num2 = num;
				num = (short)914957848;
				short num3 = num;
				num = (short)1547249176;
				switch (num3 == num)
				{
				}
				num = (short)1014759425;
				if (num != 0)
				{
				}
				num = (short)2019491840;
				if (num != 0)
				{
				}
				this.radErgoCfgFobConventionalFeature_A41574.Editable = value;
			}
		}

		// Token: 0x17003D60 RID: 15712
		// (get) Token: 0x06007753 RID: 30547 RVA: 0x006BF8F8 File Offset: 0x006BDAF8
		internal string RadErgoCfgFobConventionalFeature_A41574_UILabel
		{
			get
			{
				short num = (short)381419520;
				short num2 = num;
				num = (short)1593633676;
				short num3 = num;
				num = (short)231992204;
				switch (num3 == num)
				{
				}
				num = (short)1771700225;
				if (num != 0)
				{
				}
				num = (short)454295552;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalFeature_A41574.UIName;
			}
		}

		// Token: 0x17003D61 RID: 15713
		// (get) Token: 0x06007754 RID: 30548 RVA: 0x006BF9B0 File Offset: 0x006BDBB0
		// (set) Token: 0x06007755 RID: 30549 RVA: 0x006BFA68 File Offset: 0x006BDC68
		internal bool RadErgoCfgFobConventionalFeature_A41574_HiddenStatic
		{
			get
			{
				short num = (short)131792896;
				short num2 = num;
				num = (short)962403880;
				short num3 = num;
				num = (short)558374440;
				switch (num3 == num)
				{
				}
				num = (short)1463222273;
				if (num != 0)
				{
				}
				num = (short)752877568;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalFeature_A41574.HiddenStatic;
			}
			set
			{
				short num = (short)747241472;
				short num2 = num;
				num = (short)1816967436;
				short num3 = num;
				num = (short)1752283404;
				switch (num3 == num)
				{
				}
				num = (short)1544290304;
				if (num != 0)
				{
				}
				num = (short)612827137;
				if (num != 0)
				{
				}
				this.radErgoCfgFobConventionalFeature_A41574.HiddenStatic = value;
			}
		}

		// Token: 0x17003D62 RID: 15714
		// (get) Token: 0x06007756 RID: 30550 RVA: 0x006BFB20 File Offset: 0x006BDD20
		// (set) Token: 0x06007757 RID: 30551 RVA: 0x006BFBD4 File Offset: 0x006BDDD4
		internal bool RadErgoCfgFobConventionalFeature_A41574_HiddenDynamic
		{
			get
			{
				short num = (short)451346432;
				short num2 = num;
				num = (short)1349087154;
				short num3 = num;
				num = (short)1075670962;
				switch (num3 == num)
				{
				}
				num = (short)958922753;
				if (num != 0)
				{
				}
				num = (short)880934912;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalFeature_A41574.HiddenDynamic;
			}
			set
			{
				short num = (short)1834483712;
				short num2 = num;
				num = (short)310178931;
				short num3 = num;
				num = (short)156759155;
				switch (num3 == num)
				{
				}
				num = (short)1480654849;
				if (num != 0)
				{
				}
				num = (short)561643520;
				if (num != 0)
				{
				}
				this.radErgoCfgFobConventionalFeature_A41574.HiddenDynamic = value;
			}
		}

		// Token: 0x17003D63 RID: 15715
		// (get) Token: 0x06007758 RID: 30552 RVA: 0x006BFC88 File Offset: 0x006BDE88
		public bool RadErgoCfgFobConventionalFeature_A41574_HasDiffs
		{
			get
			{
				short num = (short)1856634880;
				short num2 = num;
				num = (short)33730168;
				short num3 = num;
				num = (short)1460514424;
				switch (num3 == num)
				{
				}
				num = (short)955449345;
				if (num != 0)
				{
				}
				num = (short)1715011584;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalFeature_A41574._HasDiffs;
			}
		}

		// Token: 0x17003D64 RID: 15716
		// (get) Token: 0x06007759 RID: 30553 RVA: 0x006BFD3C File Offset: 0x006BDF3C
		// (set) Token: 0x0600775A RID: 30554 RVA: 0x006BFDF4 File Offset: 0x006BDFF4
		public int RadErgoCfgFobTrunkingFeature_A41575Value
		{
			get
			{
				short num = (short)2002649088;
				short num2 = num;
				num = (short)1421832055;
				short num3 = num;
				num = (short)1471573879;
				switch (num3 == num)
				{
				}
				num = (short)337772545;
				if (num != 0)
				{
				}
				num = (short)205783040;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingFeature_A41575.Value;
			}
			set
			{
				short num = (short)278069248;
				short num2 = num;
				num = (short)1424632687;
				short num3 = num;
				num = (short)1912482671;
				switch (num3 == num)
				{
				}
				num = (short)1092943873;
				if (num != 0)
				{
				}
				num = (short)1356398592;
				if (num != 0)
				{
				}
				this.radErgoCfgFobTrunkingFeature_A41575.Value = value;
			}
		}

		// Token: 0x17003D65 RID: 15717
		// (get) Token: 0x0600775B RID: 30555 RVA: 0x006BFEA8 File Offset: 0x006BE0A8
		// (set) Token: 0x0600775C RID: 30556 RVA: 0x006BFF60 File Offset: 0x006BE160
		public string RadErgoCfgFobTrunkingFeature_A41575_UIValue
		{
			get
			{
				short num = (short)292028416;
				short num2 = num;
				num = (short)787034242;
				short num3 = num;
				num = (short)1910648962;
				switch (num3 == num)
				{
				}
				num = (short)1776484353;
				if (num != 0)
				{
				}
				num = (short)223412224;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingFeature_A41575.UIValue;
			}
			set
			{
				short num = (short)1590231040;
				short num2 = num;
				num = (short)545610169;
				short num3 = num;
				num = (short)123427257;
				switch (num3 == num)
				{
				}
				num = (short)1213333504;
				if (num != 0)
				{
				}
				num = (short)128319489;
				if (num != 0)
				{
				}
				this.radErgoCfgFobTrunkingFeature_A41575.UIValue = value;
			}
		}

		// Token: 0x17003D66 RID: 15718
		// (get) Token: 0x0600775D RID: 30557 RVA: 0x006C0014 File Offset: 0x006BE214
		public global::AcpBusinessLayer.AcpListField RadErgoCfgFobTrunkingFeature_A41575
		{
			get
			{
				short num = (short)897253376;
				short num2 = num;
				num = (short)1140739792;
				short num3 = num;
				num = (short)490032848;
				switch (num3 == num)
				{
				}
				num = (short)1820327937;
				if (num != 0)
				{
				}
				num = (short)813432832;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingFeature_A41575;
			}
		}

		// Token: 0x17003D67 RID: 15719
		// (get) Token: 0x0600775E RID: 30558 RVA: 0x006C00C8 File Offset: 0x006BE2C8
		// (set) Token: 0x0600775F RID: 30559 RVA: 0x006C0184 File Offset: 0x006BE384
		public bool RadErgoCfgFobTrunkingFeature_A41575_Applicable
		{
			get
			{
				short num = (short)1090781184;
				short num2 = num;
				num = (short)807211242;
				short num3 = num;
				num = (short)1207111914;
				switch (num3 == num)
				{
				}
				num = (short)748683265;
				if (num != 0)
				{
				}
				num = (short)1761214464;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingFeature_A41575.Applicable;
			}
			set
			{
				short num = (short)1295581184;
				short num2 = num;
				num = (short)2056249736;
				short num3 = num;
				num = (short)1930551688;
				switch (num3 == num)
				{
				}
				num = (short)1356726273;
				if (num != 0)
				{
				}
				num = (short)213188608;
				if (num != 0)
				{
				}
				this.radErgoCfgFobTrunkingFeature_A41575.Applicable = value;
			}
		}

		// Token: 0x17003D68 RID: 15720
		// (get) Token: 0x06007760 RID: 30560 RVA: 0x006C0238 File Offset: 0x006BE438
		// (set) Token: 0x06007761 RID: 30561 RVA: 0x006C02EC File Offset: 0x006BE4EC
		public bool RadErgoCfgFobTrunkingFeature_A41575_Valid
		{
			get
			{
				short num = (short)672006144;
				short num2 = num;
				num = (short)231171294;
				short num3 = num;
				num = (short)12805342;
				switch (num3 == num)
				{
				}
				num = (short)1920466944;
				if (num != 0)
				{
				}
				num = (short)863109121;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingFeature_A41575.Valid;
			}
			set
			{
				short num = (short)1181351936;
				short num2 = num;
				num = (short)1610804762;
				short num3 = num;
				num = (short)1499459098;
				switch (num3 == num)
				{
				}
				num = (short)1838612481;
				if (num != 0)
				{
				}
				num = (short)1897267200;
				if (num != 0)
				{
				}
				this.radErgoCfgFobTrunkingFeature_A41575.Valid = value;
			}
		}

		// Token: 0x17003D69 RID: 15721
		// (get) Token: 0x06007762 RID: 30562 RVA: 0x006C03A0 File Offset: 0x006BE5A0
		// (set) Token: 0x06007763 RID: 30563 RVA: 0x006C0454 File Offset: 0x006BE654
		public bool RadErgoCfgFobTrunkingFeature_A41575_Visible
		{
			get
			{
				short num = (short)514588672;
				short num2 = num;
				num = (short)481719872;
				short num3 = num;
				num = (short)1809741376;
				switch (num3 == num)
				{
				}
				num = (short)2051145728;
				if (num != 0)
				{
				}
				num = (short)1478885377;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingFeature_A41575.Visible;
			}
			set
			{
				short num = (short)1376976896;
				short num2 = num;
				num = (short)1923547137;
				if (num != 0)
				{
				}
				num = (short)2129942066;
				short num3 = num;
				num = (short)951866930;
				switch (num3 == num)
				{
				}
				num = (short)1838088192;
				if (num != 0)
				{
				}
				this.radErgoCfgFobTrunkingFeature_A41575.Visible = value;
			}
		}

		// Token: 0x17003D6A RID: 15722
		// (get) Token: 0x06007764 RID: 30564 RVA: 0x006C0508 File Offset: 0x006BE708
		// (set) Token: 0x06007765 RID: 30565 RVA: 0x006C05BC File Offset: 0x006BE7BC
		public bool RadErgoCfgFobTrunkingFeature_A41575_Editable
		{
			get
			{
				short num = (short)797442048;
				short num2 = num;
				num = (short)1863860368;
				short num3 = num;
				num = (short)847528080;
				switch (num3 == num)
				{
				}
				num = (short)1164312577;
				if (num != 0)
				{
				}
				num = (short)2001600512;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingFeature_A41575.Editable;
			}
			set
			{
				short num = (short)195952640;
				short num2 = num;
				num = (short)1383819780;
				short num3 = num;
				num = (short)1532324356;
				switch (num3 == num)
				{
				}
				num = (short)1409024001;
				if (num != 0)
				{
				}
				num = (short)1935015936;
				if (num != 0)
				{
				}
				this.radErgoCfgFobTrunkingFeature_A41575.Editable = value;
			}
		}

		// Token: 0x17003D6B RID: 15723
		// (get) Token: 0x06007766 RID: 30566 RVA: 0x006C0670 File Offset: 0x006BE870
		internal string RadErgoCfgFobTrunkingFeature_A41575_UILabel
		{
			get
			{
				short num = (short)642777088;
				short num2 = num;
				num = (short)704951089;
				short num3 = num;
				num = (short)130396977;
				switch (num3 == num)
				{
				}
				num = (short)1426522113;
				if (num != 0)
				{
				}
				num = (short)2108227584;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingFeature_A41575.UIName;
			}
		}

		// Token: 0x17003D6C RID: 15724
		// (get) Token: 0x06007767 RID: 30567 RVA: 0x006C0724 File Offset: 0x006BE924
		// (set) Token: 0x06007768 RID: 30568 RVA: 0x006C07DC File Offset: 0x006BE9DC
		internal bool RadErgoCfgFobTrunkingFeature_A41575_HiddenStatic
		{
			get
			{
				short num = (short)233570304;
				short num2 = num;
				num = (short)816525477;
				short num3 = num;
				num = (short)526725285;
				switch (num3 == num)
				{
				}
				num = (short)676069376;
				if (num != 0)
				{
				}
				num = (short)1744437249;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingFeature_A41575.HiddenStatic;
			}
			set
			{
				short num = (short)2064777216;
				short num2 = num;
				num = (short)592516492;
				short num3 = num;
				num = (short)777196940;
				switch (num3 == num)
				{
				}
				num = (short)91095041;
				if (num != 0)
				{
				}
				num = (short)1966342144;
				if (num != 0)
				{
				}
				this.radErgoCfgFobTrunkingFeature_A41575.HiddenStatic = value;
			}
		}

		// Token: 0x17003D6D RID: 15725
		// (get) Token: 0x06007769 RID: 30569 RVA: 0x006C0890 File Offset: 0x006BEA90
		// (set) Token: 0x0600776A RID: 30570 RVA: 0x006C0944 File Offset: 0x006BEB44
		internal bool RadErgoCfgFobTrunkingFeature_A41575_HiddenDynamic
		{
			get
			{
				short num = (short)445579264;
				short num2 = num;
				num = (short)1916444502;
				short num3 = num;
				num = (short)339058518;
				switch (num3 == num)
				{
				}
				num = (short)301662209;
				if (num != 0)
				{
				}
				num = (short)717160448;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingFeature_A41575.HiddenDynamic;
			}
			set
			{
				short num = (short)357433344;
				short num2 = num;
				num = (short)93849063;
				short num3 = num;
				num = (short)1000474087;
				switch (num3 == num)
				{
				}
				num = (short)1136721921;
				if (num != 0)
				{
				}
				num = (short)849805312;
				if (num != 0)
				{
				}
				this.radErgoCfgFobTrunkingFeature_A41575.HiddenDynamic = value;
			}
		}

		// Token: 0x17003D6E RID: 15726
		// (get) Token: 0x0600776B RID: 30571 RVA: 0x006C09FC File Offset: 0x006BEBFC
		public bool RadErgoCfgFobTrunkingFeature_A41575_HasDiffs
		{
			get
			{
				short num = (short)884736000;
				short num2 = num;
				num = (short)1358530972;
				short num3 = num;
				num = (short)2075101596;
				switch (num3 == num)
				{
				}
				num = (short)298844161;
				if (num != 0)
				{
				}
				num = (short)1957429248;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingFeature_A41575._HasDiffs;
			}
		}

		// Token: 0x17003D6F RID: 15727
		// (get) Token: 0x0600776C RID: 30572 RVA: 0x006C0AB4 File Offset: 0x006BECB4
		// (set) Token: 0x0600776D RID: 30573 RVA: 0x006C0B6C File Offset: 0x006BED6C
		public int RadErgoCfgFobConventionalBCO_A41577Value
		{
			get
			{
				short num = (short)962330624;
				short num2 = num;
				num = (short)764660546;
				short num3 = num;
				num = (short)1320536898;
				switch (num3 == num)
				{
				}
				num = (short)1911881729;
				if (num != 0)
				{
				}
				num = (short)351469568;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalBCO_A41577.Value;
			}
			set
			{
				short num = (short)1940324352;
				short num2 = num;
				num = (short)1038190769;
				short num3 = num;
				num = (short)330860721;
				switch (num3 == num)
				{
				}
				num = (short)280821761;
				if (num != 0)
				{
				}
				num = (short)1071185920;
				if (num != 0)
				{
				}
				this.radErgoCfgFobConventionalBCO_A41577.Value = value;
			}
		}

		// Token: 0x17003D70 RID: 15728
		// (get) Token: 0x0600776E RID: 30574 RVA: 0x006C0C20 File Offset: 0x006BEE20
		// (set) Token: 0x0600776F RID: 30575 RVA: 0x006C0CD4 File Offset: 0x006BEED4
		public string RadErgoCfgFobConventionalBCO_A41577_UIValue
		{
			get
			{
				short num = (short)171376640;
				short num2 = num;
				num = (short)1761089265;
				short num3 = num;
				num = (short)1036261105;
				switch (num3 == num)
				{
				}
				num = (short)539295745;
				if (num != 0)
				{
				}
				num = (short)1537802240;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalBCO_A41577.UIValue;
			}
			set
			{
				short num = (short)773062656;
				short num2 = num;
				num = (short)694050044;
				short num3 = num;
				num = (short)542072060;
				switch (num3 == num)
				{
				}
				num = (short)645070849;
				if (num != 0)
				{
				}
				num = (short)677838848;
				if (num != 0)
				{
				}
				this.radErgoCfgFobConventionalBCO_A41577.UIValue = value;
			}
		}

		// Token: 0x17003D71 RID: 15729
		// (get) Token: 0x06007770 RID: 30576 RVA: 0x006C0D88 File Offset: 0x006BEF88
		public global::AcpBusinessLayer.AcpListField RadErgoCfgFobConventionalBCO_A41577
		{
			get
			{
				short num = (short)492568576;
				short num2 = num;
				num = (short)303284559;
				short num3 = num;
				num = (short)1971831119;
				switch (num3 == num)
				{
				}
				num = (short)901906433;
				if (num != 0)
				{
				}
				num = (short)1814626304;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalBCO_A41577;
			}
		}

		// Token: 0x17003D72 RID: 15730
		// (get) Token: 0x06007771 RID: 30577 RVA: 0x006C0E3C File Offset: 0x006BF03C
		// (set) Token: 0x06007772 RID: 30578 RVA: 0x006C0EF0 File Offset: 0x006BF0F0
		public bool RadErgoCfgFobConventionalBCO_A41577_Applicable
		{
			get
			{
				short num = (short)310640640;
				short num2 = num;
				num = (short)838253552;
				short num3 = num;
				num = (short)2078260208;
				switch (num3 == num)
				{
				}
				num = (short)1088356353;
				if (num != 0)
				{
				}
				num = (short)2040070144;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalBCO_A41577.Applicable;
			}
			set
			{
				short num = (short)1638727680;
				short num2 = num;
				num = (short)1326750791;
				short num3 = num;
				num = (short)1234345031;
				switch (num3 == num)
				{
				}
				num = (short)783613953;
				if (num != 0)
				{
				}
				num = (short)1078394880;
				if (num != 0)
				{
				}
				this.radErgoCfgFobConventionalBCO_A41577.Applicable = value;
			}
		}

		// Token: 0x17003D73 RID: 15731
		// (get) Token: 0x06007773 RID: 30579 RVA: 0x006C0FA4 File Offset: 0x006BF1A4
		// (set) Token: 0x06007774 RID: 30580 RVA: 0x006C1058 File Offset: 0x006BF258
		public bool RadErgoCfgFobConventionalBCO_A41577_Valid
		{
			get
			{
				short num = (short)1293942784;
				short num2 = num;
				num = (short)1475335798;
				short num3 = num;
				num = (short)1771361910;
				switch (num3 == num)
				{
				}
				num = (short)107806721;
				if (num != 0)
				{
				}
				num = (short)894238720;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalBCO_A41577.Valid;
			}
			set
			{
				short num = (short)1821573120;
				short num2 = num;
				num = (short)2020210671;
				short num3 = num;
				num = (short)1806301167;
				switch (num3 == num)
				{
				}
				num = (short)1867120640;
				if (num != 0)
				{
				}
				num = (short)237502465;
				if (num != 0)
				{
				}
				this.radErgoCfgFobConventionalBCO_A41577.Valid = value;
			}
		}

		// Token: 0x17003D74 RID: 15732
		// (get) Token: 0x06007775 RID: 30581 RVA: 0x006C1110 File Offset: 0x006BF310
		// (set) Token: 0x06007776 RID: 30582 RVA: 0x006C11C4 File Offset: 0x006BF3C4
		public bool RadErgoCfgFobConventionalBCO_A41577_Visible
		{
			get
			{
				short num = (short)1525153792;
				short num2 = num;
				num = (short)537108018;
				short num3 = num;
				num = (short)749051442;
				switch (num3 == num)
				{
				}
				num = (short)1698365441;
				if (num != 0)
				{
				}
				num = (short)1211301888;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalBCO_A41577.Visible;
			}
			set
			{
				short num = (short)1890451457;
				if (num != 0)
				{
				}
				num = (short)1378260951;
				short num2 = num;
				num = (short)1476040663;
				switch (num2 == num)
				{
				}
				num = (short)761331712;
				short num3 = num;
				num = (short)167837696;
				if (num != 0)
				{
				}
				this.radErgoCfgFobConventionalBCO_A41577.Visible = value;
			}
		}

		// Token: 0x17003D75 RID: 15733
		// (get) Token: 0x06007777 RID: 30583 RVA: 0x006C127C File Offset: 0x006BF47C
		// (set) Token: 0x06007778 RID: 30584 RVA: 0x006C1330 File Offset: 0x006BF530
		public bool RadErgoCfgFobConventionalBCO_A41577_Editable
		{
			get
			{
				short num = (short)1913703537;
				short num2 = num;
				num = (short)284347505;
				switch (num2 == num)
				{
				}
				num = (short)714473472;
				if (num != 0)
				{
				}
				num = (short)1107755008;
				short num3 = num;
				num = (short)673579009;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalBCO_A41577.Editable;
			}
			set
			{
				short num = (short)1083113473;
				if (num != 0)
				{
				}
				num = (short)1106165299;
				short num2 = num;
				num = (short)911195699;
				switch (num2 == num)
				{
				}
				num = (short)525336576;
				short num3 = num;
				num = (short)1053491200;
				if (num != 0)
				{
				}
				this.radErgoCfgFobConventionalBCO_A41577.Editable = value;
			}
		}

		// Token: 0x17003D76 RID: 15734
		// (get) Token: 0x06007779 RID: 30585 RVA: 0x006C13E8 File Offset: 0x006BF5E8
		internal string RadErgoCfgFobConventionalBCO_A41577_UILabel
		{
			get
			{
				short num = (short)2066654742;
				short num2 = num;
				num = (short)161719830;
				switch (num2 == num)
				{
				}
				num = (short)766771201;
				if (num != 0)
				{
				}
				num = (short)889651200;
				short num3 = num;
				num = (short)1590427648;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalBCO_A41577.UIName;
			}
		}

		// Token: 0x17003D77 RID: 15735
		// (get) Token: 0x0600777A RID: 30586 RVA: 0x006C149C File Offset: 0x006BF69C
		// (set) Token: 0x0600777B RID: 30587 RVA: 0x006C1550 File Offset: 0x006BF750
		internal bool RadErgoCfgFobConventionalBCO_A41577_HiddenStatic
		{
			get
			{
				short num = (short)1418928654;
				short num2 = num;
				num = (short)1224417806;
				switch (num2 == num)
				{
				}
				num = (short)1640431617;
				if (num != 0)
				{
				}
				num = (short)1215496192;
				short num3 = num;
				num = (short)451674112;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalBCO_A41577.HiddenStatic;
			}
			set
			{
				short num = (short)24641537;
				if (num != 0)
				{
				}
				num = (short)153635137;
				short num2 = num;
				num = (short)340740417;
				switch (num2 == num)
				{
				}
				num = (short)532152320;
				short num3 = num;
				num = (short)1953300480;
				if (num != 0)
				{
				}
				this.radErgoCfgFobConventionalBCO_A41577.HiddenStatic = value;
			}
		}

		// Token: 0x17003D78 RID: 15736
		// (get) Token: 0x0600777C RID: 30588 RVA: 0x006C1604 File Offset: 0x006BF804
		// (set) Token: 0x0600777D RID: 30589 RVA: 0x006C16B8 File Offset: 0x006BF8B8
		internal bool RadErgoCfgFobConventionalBCO_A41577_HiddenDynamic
		{
			get
			{
				short num = (short)925681510;
				short num2 = num;
				num = (short)1560987494;
				switch (num2 == num)
				{
				}
				num = (short)1015218177;
				if (num != 0)
				{
				}
				num = (short)2141782016;
				short num3 = num;
				num = (short)205783040;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalBCO_A41577.HiddenDynamic;
			}
			set
			{
				short num = (short)65142785;
				if (num != 0)
				{
				}
				num = (short)1604667514;
				short num2 = num;
				num = (short)394283130;
				switch (num2 == num)
				{
				}
				num = (short)1990066176;
				short num3 = num;
				num = (short)1548812288;
				if (num != 0)
				{
				}
				this.radErgoCfgFobConventionalBCO_A41577.HiddenDynamic = value;
			}
		}

		// Token: 0x17003D79 RID: 15737
		// (get) Token: 0x0600777E RID: 30590 RVA: 0x006C176C File Offset: 0x006BF96C
		public bool RadErgoCfgFobConventionalBCO_A41577_HasDiffs
		{
			get
			{
				short num = (short)1324664106;
				short num2 = num;
				num = (short)2066728234;
				switch (num2 == num)
				{
				}
				num = (short)2045050881;
				if (num != 0)
				{
				}
				num = (short)1430454272;
				short num3 = num;
				num = (short)1540882432;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobConventionalBCO_A41577._HasDiffs;
			}
		}

		// Token: 0x17003D7A RID: 15738
		// (get) Token: 0x0600777F RID: 30591 RVA: 0x006C1824 File Offset: 0x006BFA24
		// (set) Token: 0x06007780 RID: 30592 RVA: 0x006C18DC File Offset: 0x006BFADC
		public int RadErgoCfgFobTrunkingBCO_A41578Value
		{
			get
			{
				short num = (short)1790773436;
				short num2 = num;
				num = (short)1447102652;
				switch (num2 == num)
				{
				}
				num = (short)1339883521;
				if (num != 0)
				{
				}
				num = (short)349700096;
				short num3 = num;
				num = (short)566296576;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingBCO_A41578.Value;
			}
			set
			{
				short num = (short)2055571663;
				short num2 = num;
				num = (short)1641842895;
				switch (num2 == num)
				{
				}
				num = (short)1528168448;
				if (num != 0)
				{
				}
				num = (short)1045430272;
				short num3 = num;
				num = (short)2128150529;
				if (num != 0)
				{
				}
				this.radErgoCfgFobTrunkingBCO_A41578.Value = value;
			}
		}

		// Token: 0x17003D7B RID: 15739
		// (get) Token: 0x06007781 RID: 30593 RVA: 0x006C1990 File Offset: 0x006BFB90
		// (set) Token: 0x06007782 RID: 30594 RVA: 0x006C1A48 File Offset: 0x006BFC48
		public string RadErgoCfgFobTrunkingBCO_A41578_UIValue
		{
			get
			{
				short num = (short)883270737;
				short num2 = num;
				num = (short)1336321105;
				switch (num2 == num)
				{
				}
				num = (short)1911816193;
				if (num != 0)
				{
				}
				num = (short)1658126336;
				short num3 = num;
				num = (short)663158784;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingBCO_A41578.UIValue;
			}
			set
			{
				short num = (short)1062338561;
				if (num != 0)
				{
				}
				num = (short)1035377023;
				short num2 = num;
				num = (short)1588631935;
				switch (num2 == num)
				{
				}
				num = (short)1067646976;
				short num3 = num;
				num = (short)697565184;
				if (num != 0)
				{
				}
				this.radErgoCfgFobTrunkingBCO_A41578.UIValue = value;
			}
		}

		// Token: 0x17003D7C RID: 15740
		// (get) Token: 0x06007783 RID: 30595 RVA: 0x006C1AFC File Offset: 0x006BFCFC
		public global::AcpBusinessLayer.AcpListField RadErgoCfgFobTrunkingBCO_A41578
		{
			get
			{
				short num = (short)344568164;
				short num2 = num;
				num = (short)1405727076;
				switch (num2 == num)
				{
				}
				num = (short)895549441;
				if (num != 0)
				{
				}
				num = (short)2091712512;
				short num3 = num;
				num = (short)393019392;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingBCO_A41578;
			}
		}

		// Token: 0x17003D7D RID: 15741
		// (get) Token: 0x06007784 RID: 30596 RVA: 0x006C1BB0 File Offset: 0x006BFDB0
		// (set) Token: 0x06007785 RID: 30597 RVA: 0x006C1C64 File Offset: 0x006BFE64
		public bool RadErgoCfgFobTrunkingBCO_A41578_Applicable
		{
			get
			{
				short num = (short)1785135105;
				if (num != 0)
				{
				}
				num = (short)1851272737;
				short num2 = num;
				num = (short)1437478433;
				switch (num2 == num)
				{
				}
				num = (short)644022272;
				short num3 = num;
				num = (short)1497825280;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingBCO_A41578.Applicable;
			}
			set
			{
				short num = (short)610348207;
				short num2 = num;
				num = (short)1036266671;
				switch (num2 == num)
				{
				}
				num = (short)1324351489;
				if (num != 0)
				{
				}
				num = (short)385417216;
				short num3 = num;
				num = (short)2094465024;
				if (num != 0)
				{
				}
				this.radErgoCfgFobTrunkingBCO_A41578.Applicable = value;
			}
		}

		// Token: 0x17003D7E RID: 15742
		// (get) Token: 0x06007786 RID: 30598 RVA: 0x006C1D18 File Offset: 0x006BFF18
		// (set) Token: 0x06007787 RID: 30599 RVA: 0x006C1DD0 File Offset: 0x006BFFD0
		public bool RadErgoCfgFobTrunkingBCO_A41578_Valid
		{
			get
			{
				short num = (short)77292930;
				short num2 = num;
				num = (short)2029544834;
				switch (num2 == num)
				{
				}
				num = (short)599457793;
				if (num != 0)
				{
				}
				num = (short)1435107328;
				short num3 = num;
				num = (short)1118633984;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingBCO_A41578.Valid;
			}
			set
			{
				short num = (short)1648768862;
				short num2 = num;
				num = (short)1370503006;
				switch (num2 == num)
				{
				}
				num = (short)1188233217;
				if (num != 0)
				{
				}
				num = (short)915341312;
				short num3 = num;
				num = (short)1653276672;
				if (num != 0)
				{
				}
				this.radErgoCfgFobTrunkingBCO_A41578.Valid = value;
			}
		}

		// Token: 0x17003D7F RID: 15743
		// (get) Token: 0x06007788 RID: 30600 RVA: 0x006C1E88 File Offset: 0x006C0088
		// (set) Token: 0x06007789 RID: 30601 RVA: 0x006C1F3C File Offset: 0x006C013C
		public bool RadErgoCfgFobTrunkingBCO_A41578_Visible
		{
			get
			{
				short num = (short)753854209;
				short num2 = num;
				num = (short)1747445505;
				switch (num2 == num)
				{
				}
				num = (short)1833500673;
				if (num != 0)
				{
				}
				num = (short)1597898752;
				short num3 = num;
				num = (short)675217408;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingBCO_A41578.Visible;
			}
			set
			{
				short num = (short)301987186;
				short num2 = num;
				num = (short)1817245042;
				switch (num2 == num)
				{
				}
				num = (short)45547521;
				if (num != 0)
				{
				}
				num = (short)104202240;
				short num3 = num;
				num = (short)1541799936;
				if (num != 0)
				{
				}
				this.radErgoCfgFobTrunkingBCO_A41578.Visible = value;
			}
		}

		// Token: 0x17003D80 RID: 15744
		// (get) Token: 0x0600778A RID: 30602 RVA: 0x006C1FF0 File Offset: 0x006C01F0
		// (set) Token: 0x0600778B RID: 30603 RVA: 0x006C20A8 File Offset: 0x006C02A8
		public bool RadErgoCfgFobTrunkingBCO_A41578_Editable
		{
			get
			{
				short num = (short)2078397951;
				short num2 = num;
				num = (short)813159935;
				switch (num2 == num)
				{
				}
				num = (short)1718288384;
				if (num != 0)
				{
				}
				num = (short)2100101120;
				short num3 = num;
				num = (short)2027356161;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingBCO_A41578.Editable;
			}
			set
			{
				short num = (short)1024458753;
				if (num != 0)
				{
				}
				num = (short)394886865;
				short num2 = num;
				num = (short)116948689;
				switch (num2 == num)
				{
				}
				num = (short)1653669888;
				short num3 = num;
				num = (short)1815871488;
				if (num != 0)
				{
				}
				this.radErgoCfgFobTrunkingBCO_A41578.Editable = value;
			}
		}

		// Token: 0x17003D81 RID: 15745
		// (get) Token: 0x0600778C RID: 30604 RVA: 0x006C215C File Offset: 0x006C035C
		internal string RadErgoCfgFobTrunkingBCO_A41578_UILabel
		{
			get
			{
				short num = (short)1729213221;
				short num2 = num;
				num = (short)410104613;
				switch (num2 == num)
				{
				}
				num = (short)1851392001;
				if (num != 0)
				{
				}
				num = (short)1050148864;
				short num3 = num;
				num = (short)1765408768;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingBCO_A41578.UIName;
			}
		}

		// Token: 0x17003D82 RID: 15746
		// (get) Token: 0x0600778D RID: 30605 RVA: 0x006C2210 File Offset: 0x006C0410
		// (set) Token: 0x0600778E RID: 30606 RVA: 0x006C22C8 File Offset: 0x006C04C8
		internal bool RadErgoCfgFobTrunkingBCO_A41578_HiddenStatic
		{
			get
			{
				short num = (short)1417012758;
				short num2 = num;
				num = (short)494134806;
				switch (num2 == num)
				{
				}
				num = (short)996016128;
				if (num != 0)
				{
				}
				num = (short)1668022272;
				short num3 = num;
				num = (short)276430849;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingBCO_A41578.HiddenStatic;
			}
			set
			{
				short num = (short)1659119920;
				short num2 = num;
				num = (short)832514352;
				switch (num2 == num)
				{
				}
				num = (short)1196032001;
				if (num != 0)
				{
				}
				num = (short)1836253184;
				short num3 = num;
				num = (short)886833152;
				if (num != 0)
				{
				}
				this.radErgoCfgFobTrunkingBCO_A41578.HiddenStatic = value;
			}
		}

		// Token: 0x17003D83 RID: 15747
		// (get) Token: 0x0600778F RID: 30607 RVA: 0x006C237C File Offset: 0x006C057C
		// (set) Token: 0x06007790 RID: 30608 RVA: 0x006C2430 File Offset: 0x006C0630
		internal bool RadErgoCfgFobTrunkingBCO_A41578_HiddenDynamic
		{
			get
			{
				short num = (short)1321477575;
				short num2 = num;
				num = (short)869213639;
				switch (num2 == num)
				{
				}
				num = (short)155648000;
				if (num != 0)
				{
				}
				num = (short)1025703936;
				short num3 = num;
				num = (short)1559363585;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingBCO_A41578.HiddenDynamic;
			}
			set
			{
				short num = (short)1342855302;
				short num2 = num;
				num = (short)466180230;
				switch (num2 == num)
				{
				}
				num = (short)1529872384;
				if (num != 0)
				{
				}
				num = (short)332333056;
				short num3 = num;
				num = (short)931659777;
				if (num != 0)
				{
				}
				this.radErgoCfgFobTrunkingBCO_A41578.HiddenDynamic = value;
			}
		}

		// Token: 0x17003D84 RID: 15748
		// (get) Token: 0x06007791 RID: 30609 RVA: 0x006C24E4 File Offset: 0x006C06E4
		public bool RadErgoCfgFobTrunkingBCO_A41578_HasDiffs
		{
			get
			{
				short num = (short)1112067699;
				short num2 = num;
				num = (short)887344755;
				switch (num2 == num)
				{
				}
				num = (short)226164736;
				if (num != 0)
				{
				}
				num = (short)316145664;
				short num3 = num;
				num = (short)839450625;
				if (num != 0)
				{
				}
				return this.radErgoCfgFobTrunkingBCO_A41578._HasDiffs;
			}
		}

		// Token: 0x17003D85 RID: 15749
		// (get) Token: 0x06007792 RID: 30610 RVA: 0x006C259C File Offset: 0x006C079C
		// (set) Token: 0x06007793 RID: 30611 RVA: 0x006C2654 File Offset: 0x006C0854
		public string RadErgoCfgSmartKeyFobButtonKey_A41579Value
		{
			get
			{
				short num = (short)1616604979;
				short num2 = num;
				num = (short)1426681651;
				switch (num2 == num)
				{
				}
				num = (short)761069569;
				if (num != 0)
				{
				}
				num = (short)668794880;
				short num3 = num;
				num = (short)1825570816;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobButtonKey_A41579.Value;
			}
			set
			{
				short num = (short)1457782786;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_E7;
					case 1:
						this.radErgoCfgSmartKeyFobButtonKey_A41579.Value = value;
						goto IL_D1;
					case 2:
					{
						num = (short)509713864;
						short num3 = num;
						num = (short)1724227016;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D1;
						default:
							num = (short)1062273025;
							if (num != 0)
							{
							}
							num = (short)514981888;
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
						break;
					}
					}
					IL_A2:
					if (!string.IsNullOrEmpty(value.Trim()))
					{
						num = (short)732889089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_D1:
					num = (short)1466433536;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E7:
				num = (short)1742077952;
				short num4 = num;
			}
		}

		// Token: 0x17003D86 RID: 15750
		// (get) Token: 0x06007794 RID: 30612 RVA: 0x006C2774 File Offset: 0x006C0974
		// (set) Token: 0x06007795 RID: 30613 RVA: 0x006C2828 File Offset: 0x006C0A28
		public string RadErgoCfgSmartKeyFobButtonKey_A41579_UIValue
		{
			get
			{
				short num = (short)1525461641;
				short num2 = num;
				num = (short)200848009;
				switch (num2 == num)
				{
				}
				num = (short)1268711424;
				if (num != 0)
				{
				}
				num = (short)965148672;
				short num3 = num;
				num = (short)1735786497;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobButtonKey_A41579.Value;
			}
			set
			{
				short num = (short)1811102324;
				short num2 = num;
				num = (short)406600308;
				switch (num2 == num)
				{
				}
				num = (short)1569849345;
				if (num != 0)
				{
				}
				num = (short)1078919168;
				short num3 = num;
				num = (short)1574502400;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobButtonKey_A41579.Value = value;
			}
		}

		// Token: 0x17003D87 RID: 15751
		// (get) Token: 0x06007796 RID: 30614 RVA: 0x006C28DC File Offset: 0x006C0ADC
		public global::AcpBusinessLayer.AcpKeyField RadErgoCfgSmartKeyFobButtonKey_A41579
		{
			get
			{
				short num = (short)872999321;
				short num2 = num;
				num = (short)419621273;
				switch (num2 == num)
				{
				}
				num = (short)1783365632;
				if (num != 0)
				{
				}
				num = (short)710606848;
				short num3 = num;
				num = (short)1857748993;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobButtonKey_A41579;
			}
		}

		// Token: 0x17003D88 RID: 15752
		// (get) Token: 0x06007797 RID: 30615 RVA: 0x006C2990 File Offset: 0x006C0B90
		// (set) Token: 0x06007798 RID: 30616 RVA: 0x006C2A44 File Offset: 0x006C0C44
		public bool RadErgoCfgSmartKeyFobButtonKey_A41579_Applicable
		{
			get
			{
				short num = (short)1238943404;
				short num2 = num;
				num = (short)594527916;
				switch (num2 == num)
				{
				}
				num = (short)877527040;
				if (num != 0)
				{
				}
				num = (short)630194176;
				short num3 = num;
				num = (short)748027905;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobButtonKey_A41579.Applicable;
			}
			set
			{
				short num = (short)2073974339;
				short num2 = num;
				num = (short)1593005635;
				switch (num2 == num)
				{
				}
				num = (short)549715969;
				if (num != 0)
				{
				}
				num = (short)906166272;
				short num3 = num;
				num = (short)973144064;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobButtonKey_A41579.Applicable = value;
			}
		}

		// Token: 0x17003D89 RID: 15753
		// (get) Token: 0x06007799 RID: 30617 RVA: 0x006C2AF8 File Offset: 0x006C0CF8
		// (set) Token: 0x0600779A RID: 30618 RVA: 0x006C2BAC File Offset: 0x006C0DAC
		public bool RadErgoCfgSmartKeyFobButtonKey_A41579_Valid
		{
			get
			{
				short num = (short)458467791;
				short num2 = num;
				num = (short)2056497615;
				switch (num2 == num)
				{
				}
				num = (short)1345585152;
				if (num != 0)
				{
				}
				num = (short)1386741760;
				short num3 = num;
				num = (short)242221057;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobButtonKey_A41579.Valid;
			}
			set
			{
				short num = (short)1546977281;
				if (num != 0)
				{
				}
				num = (short)1490589695;
				short num2 = num;
				num = (short)1074108415;
				switch (num2 == num)
				{
				}
				num = (short)1030160384;
				short num3 = num;
				num = (short)880148480;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobButtonKey_A41579.Valid = value;
			}
		}

		// Token: 0x17003D8A RID: 15754
		// (get) Token: 0x0600779B RID: 30619 RVA: 0x006C2C60 File Offset: 0x006C0E60
		// (set) Token: 0x0600779C RID: 30620 RVA: 0x006C2D14 File Offset: 0x006C0F14
		public bool RadErgoCfgSmartKeyFobButtonKey_A41579_Visible
		{
			get
			{
				short num = (short)545626745;
				short num2 = num;
				num = (short)1647745657;
				switch (num2 == num)
				{
				}
				num = (short)1894645761;
				if (num != 0)
				{
				}
				num = (short)1692270592;
				short num3 = num;
				num = (short)1485570048;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobButtonKey_A41579.Visible;
			}
			set
			{
				short num = (short)1463502838;
				short num2 = num;
				num = (short)1856718838;
				switch (num2 == num)
				{
				}
				num = (short)1383006208;
				if (num != 0)
				{
				}
				num = (short)525729792;
				short num3 = num;
				num = (short)377290753;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobButtonKey_A41579.Visible = value;
			}
		}

		// Token: 0x17003D8B RID: 15755
		// (get) Token: 0x0600779D RID: 30621 RVA: 0x006C2DC8 File Offset: 0x006C0FC8
		// (set) Token: 0x0600779E RID: 30622 RVA: 0x006C2E7C File Offset: 0x006C107C
		public bool RadErgoCfgSmartKeyFobButtonKey_A41579_Editable
		{
			get
			{
				short num = (short)1381722607;
				short num2 = num;
				num = (short)1915709935;
				switch (num2 == num)
				{
				}
				num = (short)705560577;
				if (num != 0)
				{
				}
				num = (short)2124087296;
				short num3 = num;
				num = (short)1003159552;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobButtonKey_A41579.Editable;
			}
			set
			{
				short num = (short)1435396414;
				short num2 = num;
				num = (short)232810814;
				switch (num2 == num)
				{
				}
				num = (short)1290141697;
				if (num != 0)
				{
				}
				num = (short)544407552;
				short num3 = num;
				num = (short)1068564480;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobButtonKey_A41579.Editable = value;
			}
		}

		// Token: 0x17003D8C RID: 15756
		// (get) Token: 0x0600779F RID: 30623 RVA: 0x006C2F38 File Offset: 0x006C1138
		internal string RadErgoCfgSmartKeyFobButtonKey_A41579_UILabel
		{
			get
			{
				short num = (short)1399311634;
				short num2 = num;
				num = (short)224578834;
				switch (num2 == num)
				{
				}
				num = (short)1011548161;
				if (num != 0)
				{
				}
				num = (short)897974272;
				short num3 = num;
				num = (short)250806272;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobButtonKey_A41579.UIName;
			}
		}

		// Token: 0x17003D8D RID: 15757
		// (get) Token: 0x060077A0 RID: 30624 RVA: 0x006C2FEC File Offset: 0x006C11EC
		// (set) Token: 0x060077A1 RID: 30625 RVA: 0x006C30A0 File Offset: 0x006C12A0
		internal bool RadErgoCfgSmartKeyFobButtonKey_A41579_HiddenStatic
		{
			get
			{
				short num = (short)1125505579;
				short num2 = num;
				num = (short)102160939;
				switch (num2 == num)
				{
				}
				num = (short)606928896;
				if (num != 0)
				{
				}
				num = (short)464584704;
				short num3 = num;
				num = (short)726859777;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobButtonKey_A41579.HiddenStatic;
			}
			set
			{
				short num = (short)198246401;
				if (num != 0)
				{
				}
				num = (short)627047722;
				short num2 = num;
				num = (short)963509546;
				switch (num2 == num)
				{
				}
				num = (short)489619456;
				short num3 = num;
				num = (short)2116550656;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobButtonKey_A41579.HiddenStatic = value;
			}
		}

		// Token: 0x17003D8E RID: 15758
		// (get) Token: 0x060077A2 RID: 30626 RVA: 0x006C3158 File Offset: 0x006C1358
		// (set) Token: 0x060077A3 RID: 30627 RVA: 0x006C320C File Offset: 0x006C140C
		internal bool RadErgoCfgSmartKeyFobButtonKey_A41579_HiddenDynamic
		{
			get
			{
				short num = (short)1063977165;
				short num2 = num;
				num = (short)828506317;
				switch (num2 == num)
				{
				}
				num = (short)1353383937;
				if (num != 0)
				{
				}
				num = (short)1411579904;
				short num3 = num;
				num = (short)1416691712;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobButtonKey_A41579.HiddenDynamic;
			}
			set
			{
				short num = (short)2098593793;
				if (num != 0)
				{
				}
				num = (short)650979056;
				short num2 = num;
				num = (short)653338352;
				switch (num2 == num)
				{
				}
				num = (short)1782710272;
				short num3 = num;
				num = (short)602537984;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobButtonKey_A41579.HiddenDynamic = value;
			}
		}

		// Token: 0x17003D8F RID: 15759
		// (get) Token: 0x060077A4 RID: 30628 RVA: 0x006C32C4 File Offset: 0x006C14C4
		public bool RadErgoCfgSmartKeyFobButtonKey_A41579_HasDiffs
		{
			get
			{
				short num = (short)1860824882;
				short num2 = num;
				num = (short)767160114;
				switch (num2 == num)
				{
				}
				num = (short)685899777;
				if (num != 0)
				{
				}
				num = (short)742981632;
				short num3 = num;
				num = (short)1593901056;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobButtonKey_A41579._HasDiffs;
			}
		}

		// Token: 0x17003D90 RID: 15760
		// (get) Token: 0x060077A5 RID: 30629 RVA: 0x006C337C File Offset: 0x006C157C
		// (set) Token: 0x060077A6 RID: 30630 RVA: 0x006C342C File Offset: 0x006C162C
		public int RadErgoCfgSmartKeyFobShortPressTimeValue
		{
			get
			{
				short num = (short)1945920908;
				short num2 = num;
				num = (short)698574220;
				switch (num2 == num)
				{
				}
				num = (short)879624193;
				if (num != 0)
				{
				}
				num = (short)1639317504;
				short num3 = num;
				num = (short)245628928;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobShortPressTime.Value;
			}
			set
			{
				short num = (short)749743834;
				short num2 = num;
				num = (short)2042310362;
				switch (num2 == num)
				{
				}
				num = (short)1945174017;
				if (num != 0)
				{
				}
				num = (short)1979318272;
				short num3 = num;
				num = (short)803340288;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobShortPressTime.Value = value;
			}
		}

		// Token: 0x17003D91 RID: 15761
		// (get) Token: 0x060077A7 RID: 30631 RVA: 0x006C34E0 File Offset: 0x006C16E0
		// (set) Token: 0x060077A8 RID: 30632 RVA: 0x006C3594 File Offset: 0x006C1794
		public string RadErgoCfgSmartKeyFobShortPressTime_UIValue
		{
			get
			{
				short num = (short)959747231;
				short num2 = num;
				num = (short)645174431;
				switch (num2 == num)
				{
				}
				num = (short)2124939264;
				if (num != 0)
				{
				}
				num = (short)1214316544;
				short num3 = num;
				num = (short)1588068353;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobShortPressTime.UIValue;
			}
			set
			{
				short num = (short)304961133;
				short num2 = num;
				num = (short)116020845;
				switch (num2 == num)
				{
				}
				num = (short)49086464;
				short num3 = num;
				num = (short)212271105;
				if (num != 0)
				{
				}
				num = (short)1440808960;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobShortPressTime.UIValue = value;
			}
		}

		// Token: 0x17003D92 RID: 15762
		// (get) Token: 0x060077A9 RID: 30633 RVA: 0x006C364C File Offset: 0x006C184C
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgSmartKeyFobShortPressTime
		{
			get
			{
				short num = (short)465396968;
				short num2 = num;
				num = (short)675898600;
				switch (num2 == num)
				{
				}
				num = (short)897187840;
				short num3 = num;
				num = (short)402063360;
				if (num != 0)
				{
				}
				num = (short)354484225;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobShortPressTime;
			}
		}

		// Token: 0x17003D93 RID: 15763
		// (get) Token: 0x060077AA RID: 30634 RVA: 0x006C36FC File Offset: 0x006C18FC
		// (set) Token: 0x060077AB RID: 30635 RVA: 0x006C37B0 File Offset: 0x006C19B0
		internal int RadErgoCfgSmartKeyFobShortPressTimeMin
		{
			get
			{
				short num = (short)1535897461;
				short num2 = num;
				num = (short)2066476917;
				switch (num2 == num)
				{
				}
				num = (short)1336672256;
				short num3 = num;
				num = (short)1459290113;
				if (num != 0)
				{
				}
				num = (short)108134400;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobShortPressTime.Min;
			}
			set
			{
				short num = (short)992608892;
				short num2 = num;
				num = (short)1201144444;
				switch (num2 == num)
				{
				}
				num = (short)1448476672;
				short num3 = num;
				num = (short)2128871425;
				if (num != 0)
				{
				}
				num = (short)671940608;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobShortPressTime.Min = value;
			}
		}

		// Token: 0x17003D94 RID: 15764
		// (get) Token: 0x060077AC RID: 30636 RVA: 0x006C3864 File Offset: 0x006C1A64
		// (set) Token: 0x060077AD RID: 30637 RVA: 0x006C3918 File Offset: 0x006C1B18
		internal int RadErgoCfgSmartKeyFobShortPressTimeMax
		{
			get
			{
				short num = (short)1348323378;
				short num2 = num;
				num = (short)271304754;
				switch (num2 == num)
				{
				}
				num = (short)85786624;
				short num3 = num;
				num = (short)586153985;
				if (num != 0)
				{
				}
				num = (short)458555392;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobShortPressTime.Max;
			}
			set
			{
				short num = (short)1977882885;
				short num2 = num;
				num = (short)504436997;
				switch (num2 == num)
				{
				}
				num = (short)35192832;
				short num3 = num;
				num = (short)729284608;
				if (num != 0)
				{
				}
				num = (short)1445789697;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobShortPressTime.Max = value;
			}
		}

		// Token: 0x17003D95 RID: 15765
		// (get) Token: 0x060077AE RID: 30638 RVA: 0x006C39D0 File Offset: 0x006C1BD0
		// (set) Token: 0x060077AF RID: 30639 RVA: 0x006C3A88 File Offset: 0x006C1C88
		internal int RadErgoCfgSmartKeyFobShortPressTimeStep
		{
			get
			{
				short num = (short)1345919307;
				short num2 = num;
				num = (short)218175819;
				switch (num2 == num)
				{
				}
				num = (short)2050097152;
				short num3 = num;
				num = (short)1784020992;
				if (num != 0)
				{
				}
				num = (short)216530945;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobShortPressTime.StepSize;
			}
			set
			{
				short num = (short)438370305;
				if (num != 0)
				{
				}
				num = (short)823449629;
				short num2 = num;
				num = (short)1472518173;
				switch (num2 == num)
				{
				default:
				{
					num = (short)659816448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)623902720;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobShortPressTime.StepSize = value;
			}
		}

		// Token: 0x17003D96 RID: 15766
		// (get) Token: 0x060077B0 RID: 30640 RVA: 0x006C3B3C File Offset: 0x006C1D3C
		// (set) Token: 0x060077B1 RID: 30641 RVA: 0x006C3BF4 File Offset: 0x006C1DF4
		public bool RadErgoCfgSmartKeyFobShortPressTime_Applicable
		{
			get
			{
				short num = (short)1431338213;
				short num2 = num;
				num = (short)1268808933;
				switch (num2 == num)
				{
				}
				num = (short)487915520;
				short num3 = num;
				num = (short)90570753;
				if (num != 0)
				{
				}
				num = (short)1938948096;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobShortPressTime.Applicable;
			}
			set
			{
				short num = (short)109706310;
				short num2 = num;
				num = (short)627178566;
				switch (num2 == num)
				{
				}
				num = (short)2120613888;
				short num3 = num;
				num = (short)1467613185;
				if (num != 0)
				{
				}
				num = (short)635764736;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobShortPressTime.Applicable = value;
			}
		}

		// Token: 0x17003D97 RID: 15767
		// (get) Token: 0x060077B2 RID: 30642 RVA: 0x006C3CA8 File Offset: 0x006C1EA8
		// (set) Token: 0x060077B3 RID: 30643 RVA: 0x006C3D5C File Offset: 0x006C1F5C
		public bool RadErgoCfgSmartKeyFobShortPressTime_Valid
		{
			get
			{
				short num = (short)1287323649;
				if (num != 0)
				{
				}
				num = (short)1616703675;
				short num2 = num;
				num = (short)1339617467;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1623785472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1462829056;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobShortPressTime.Valid;
			}
			set
			{
				short num = (short)290257139;
				short num2 = num;
				num = (short)1432221939;
				switch (num2 == num)
				{
				}
				num = (short)2042953728;
				short num3 = num;
				num = (short)85065729;
				if (num != 0)
				{
				}
				num = (short)2015363072;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobShortPressTime.Valid = value;
			}
		}

		// Token: 0x17003D98 RID: 15768
		// (get) Token: 0x060077B4 RID: 30644 RVA: 0x006C3E14 File Offset: 0x006C2014
		// (set) Token: 0x060077B5 RID: 30645 RVA: 0x006C3EC8 File Offset: 0x006C20C8
		public bool RadErgoCfgSmartKeyFobShortPressTime_Visible
		{
			get
			{
				short num = (short)1578359110;
				short num2 = num;
				num = (short)946526534;
				switch (num2 == num)
				{
				}
				num = (short)555483136;
				short num3 = num;
				num = (short)646316032;
				if (num != 0)
				{
				}
				num = (short)234291201;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobShortPressTime.Visible;
			}
			set
			{
				short num = (short)1438197602;
				short num2 = num;
				num = (short)2034247522;
				switch (num2 == num)
				{
				}
				num = (short)582221824;
				short num3 = num;
				num = (short)1327038465;
				if (num != 0)
				{
				}
				num = (short)1675034624;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobShortPressTime.Visible = value;
			}
		}

		// Token: 0x17003D99 RID: 15769
		// (get) Token: 0x060077B6 RID: 30646 RVA: 0x006C3F80 File Offset: 0x006C2180
		// (set) Token: 0x060077B7 RID: 30647 RVA: 0x006C4034 File Offset: 0x006C2234
		public bool RadErgoCfgSmartKeyFobShortPressTime_Editable
		{
			get
			{
				short num = (short)459036211;
				short num2 = num;
				num = (short)1526027827;
				switch (num2 == num)
				{
				}
				num = (short)1600782336;
				short num3 = num;
				num = (short)326041600;
				if (num != 0)
				{
				}
				num = (short)1094189057;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobShortPressTime.Editable;
			}
			set
			{
				short num = (short)2112769626;
				short num2 = num;
				num = (short)100617818;
				switch (num2 == num)
				{
				}
				num = (short)888733696;
				short num3 = num;
				num = (short)171573249;
				if (num != 0)
				{
				}
				num = (short)1345585152;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobShortPressTime.Editable = value;
			}
		}

		// Token: 0x17003D9A RID: 15770
		// (get) Token: 0x060077B8 RID: 30648 RVA: 0x006C40E8 File Offset: 0x006C22E8
		internal string RadErgoCfgSmartKeyFobShortPressTime_UILabel
		{
			get
			{
				short num = (short)1330363064;
				short num2 = num;
				num = (short)1682815672;
				switch (num2 == num)
				{
				}
				num = (short)1233518592;
				short num3 = num;
				num = (short)834142209;
				if (num != 0)
				{
				}
				num = (short)1883111424;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobShortPressTime.UIName;
			}
		}

		// Token: 0x17003D9B RID: 15771
		// (get) Token: 0x060077B9 RID: 30649 RVA: 0x006C41A0 File Offset: 0x006C23A0
		// (set) Token: 0x060077BA RID: 30650 RVA: 0x006C4254 File Offset: 0x006C2454
		internal bool RadErgoCfgSmartKeyFobShortPressTime_HiddenStatic
		{
			get
			{
				short num = (short)256758483;
				short num2 = num;
				num = (short)1590153939;
				switch (num2 == num)
				{
				}
				num = (short)740753408;
				short num3 = num;
				num = (short)825360385;
				if (num != 0)
				{
				}
				num = (short)648806400;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobShortPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)829161473;
				if (num != 0)
				{
				}
				num = (short)119757600;
				short num2 = num;
				num = (short)913201952;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2101018624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)42926080;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobShortPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17003D9C RID: 15772
		// (get) Token: 0x060077BB RID: 30651 RVA: 0x006C430C File Offset: 0x006C250C
		// (set) Token: 0x060077BC RID: 30652 RVA: 0x006C43C0 File Offset: 0x006C25C0
		internal bool RadErgoCfgSmartKeyFobShortPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)1521910865;
				short num2 = num;
				num = (short)1800111185;
				switch (num2 == num)
				{
				}
				num = (short)319750144;
				short num3 = num;
				num = (short)1613561857;
				if (num != 0)
				{
				}
				num = (short)1796079616;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobShortPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)706974896;
				short num2 = num;
				num = (short)460494000;
				switch (num2 == num)
				{
				}
				num = (short)893845504;
				short num3 = num;
				num = (short)1791361025;
				if (num != 0)
				{
				}
				num = (short)1141899264;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobShortPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17003D9D RID: 15773
		// (get) Token: 0x060077BD RID: 30653 RVA: 0x006C4478 File Offset: 0x006C2678
		public bool RadErgoCfgSmartKeyFobShortPressTime_HasDiffs
		{
			get
			{
				short num = (short)1107544840;
				short num2 = num;
				num = (short)45468424;
				switch (num2 == num)
				{
				}
				num = (short)1682833408;
				short num3 = num;
				num = (short)754778113;
				if (num != 0)
				{
				}
				num = (short)110886912;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobShortPressTime._HasDiffs;
			}
		}

		// Token: 0x17003D9E RID: 15774
		// (get) Token: 0x060077BE RID: 30654 RVA: 0x006C452C File Offset: 0x006C272C
		// (set) Token: 0x060077BF RID: 30655 RVA: 0x006C45E0 File Offset: 0x006C27E0
		public int RadErgoCfgSmartKeyFobLongPressTimeValue
		{
			get
			{
				short num = (short)542961512;
				short num2 = num;
				num = (short)1495920488;
				switch (num2 == num)
				{
				}
				num = (short)1385758720;
				short num3 = num;
				num = (short)60620801;
				if (num != 0)
				{
				}
				num = (short)989724672;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobLongPressTime.Value;
			}
			set
			{
				short num = (short)1179548945;
				short num2 = num;
				num = (short)1067547921;
				switch (num2 == num)
				{
				}
				num = (short)904462336;
				short num3 = num;
				num = (short)332136449;
				if (num != 0)
				{
				}
				num = (short)1772158976;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobLongPressTime.Value = value;
			}
		}

		// Token: 0x17003D9F RID: 15775
		// (get) Token: 0x060077C0 RID: 30656 RVA: 0x006C4698 File Offset: 0x006C2898
		// (set) Token: 0x060077C1 RID: 30657 RVA: 0x006C474C File Offset: 0x006C294C
		public string RadErgoCfgSmartKeyFobLongPressTime_UIValue
		{
			get
			{
				short num = (short)1569098804;
				short num2 = num;
				num = (short)1281002548;
				switch (num2 == num)
				{
				}
				num = (short)421724160;
				short num3 = num;
				num = (short)1827930112;
				if (num != 0)
				{
				}
				num = (short)1692925953;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobLongPressTime.UIValue;
			}
			set
			{
				short num = (short)1982728429;
				short num2 = num;
				num = (short)1530398957;
				switch (num2 == num)
				{
				}
				num = (short)1335885824;
				short num3 = num;
				num = (short)1667039233;
				if (num != 0)
				{
				}
				num = (short)2110783488;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobLongPressTime.UIValue = value;
			}
		}

		// Token: 0x17003DA0 RID: 15776
		// (get) Token: 0x060077C2 RID: 30658 RVA: 0x006C4804 File Offset: 0x006C2A04
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgSmartKeyFobLongPressTime
		{
			get
			{
				short num = (short)733324453;
				short num2 = num;
				num = (short)2044961957;
				switch (num2 == num)
				{
				}
				num = (short)538050560;
				short num3 = num;
				num = (short)1952382977;
				if (num != 0)
				{
				}
				num = (short)1701314560;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobLongPressTime;
			}
		}

		// Token: 0x17003DA1 RID: 15777
		// (get) Token: 0x060077C3 RID: 30659 RVA: 0x006C48B4 File Offset: 0x006C2AB4
		// (set) Token: 0x060077C4 RID: 30660 RVA: 0x006C496C File Offset: 0x006C2B6C
		internal int RadErgoCfgSmartKeyFobLongPressTimeMin
		{
			get
			{
				short num = (short)780973562;
				short num2 = num;
				num = (short)1581954554;
				switch (num2 == num)
				{
				}
				num = (short)1747976192;
				short num3 = num;
				num = (short)637468673;
				if (num != 0)
				{
				}
				num = (short)707395584;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobLongPressTime.Min;
			}
			set
			{
				short num = (short)1745478984;
				short num2 = num;
				num = (short)939320648;
				switch (num2 == num)
				{
				}
				num = (short)1093926912;
				short num3 = num;
				num = (short)1577189377;
				if (num != 0)
				{
				}
				num = (short)2008285184;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobLongPressTime.Min = value;
			}
		}

		// Token: 0x17003DA2 RID: 15778
		// (get) Token: 0x060077C5 RID: 30661 RVA: 0x006C4A24 File Offset: 0x006C2C24
		// (set) Token: 0x060077C6 RID: 30662 RVA: 0x006C4AD8 File Offset: 0x006C2CD8
		internal int RadErgoCfgSmartKeyFobLongPressTimeMax
		{
			get
			{
				short num = (short)2133524481;
				if (num != 0)
				{
				}
				num = (short)1115226687;
				short num2 = num;
				num = (short)593232447;
				switch (num2 == num)
				{
				default:
				{
					num = (short)382271488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1455947776;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobLongPressTime.Max;
			}
			set
			{
				short num = (short)1908946581;
				short num2 = num;
				num = (short)1615410837;
				switch (num2 == num)
				{
				}
				num = (short)1762000896;
				short num3 = num;
				num = (short)1829371905;
				if (num != 0)
				{
				}
				num = (short)62717952;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobLongPressTime.Max = value;
			}
		}

		// Token: 0x17003DA3 RID: 15779
		// (get) Token: 0x060077C7 RID: 30663 RVA: 0x006C4B8C File Offset: 0x006C2D8C
		// (set) Token: 0x060077C8 RID: 30664 RVA: 0x006C4C44 File Offset: 0x006C2E44
		internal int RadErgoCfgSmartKeyFobLongPressTimeStep
		{
			get
			{
				short num = (short)1491792633;
				short num2 = num;
				num = (short)893645561;
				switch (num2 == num)
				{
				}
				num = (short)765919232;
				short num3 = num;
				num = (short)603586561;
				if (num != 0)
				{
				}
				num = (short)977403904;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobLongPressTime.StepSize;
			}
			set
			{
				short num = (short)1107730328;
				short num2 = num;
				num = (short)283942808;
				switch (num2 == num)
				{
				}
				num = (short)1887895552;
				short num3 = num;
				num = (short)1703215105;
				if (num != 0)
				{
				}
				num = (short)1934229504;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobLongPressTime.StepSize = value;
			}
		}

		// Token: 0x17003DA4 RID: 15780
		// (get) Token: 0x060077C9 RID: 30665 RVA: 0x006C4CF8 File Offset: 0x006C2EF8
		// (set) Token: 0x060077CA RID: 30666 RVA: 0x006C4DAC File Offset: 0x006C2FAC
		public bool RadErgoCfgSmartKeyFobLongPressTime_Applicable
		{
			get
			{
				short num = (short)1910102675;
				short num2 = num;
				num = (short)1882315411;
				switch (num2 == num)
				{
				}
				num = (short)1902379008;
				short num3 = num;
				num = (short)1433796609;
				if (num != 0)
				{
				}
				num = (short)2004025344;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobLongPressTime.Applicable;
			}
			set
			{
				short num = (short)1112360794;
				short num2 = num;
				num = (short)2087143258;
				switch (num2 == num)
				{
				}
				num = (short)1998127104;
				short num3 = num;
				num = (short)1125253120;
				if (num != 0)
				{
				}
				num = (short)816840705;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobLongPressTime.Applicable = value;
			}
		}

		// Token: 0x17003DA5 RID: 15781
		// (get) Token: 0x060077CB RID: 30667 RVA: 0x006C4E60 File Offset: 0x006C3060
		// (set) Token: 0x060077CC RID: 30668 RVA: 0x006C4F14 File Offset: 0x006C3114
		public bool RadErgoCfgSmartKeyFobLongPressTime_Valid
		{
			get
			{
				short num = (short)668749216;
				short num2 = num;
				num = (short)1854492064;
				switch (num2 == num)
				{
				}
				num = (short)629538816;
				short num3 = num;
				num = (short)417136640;
				if (num != 0)
				{
				}
				num = (short)1228865537;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobLongPressTime.Valid;
			}
			set
			{
				short num = (short)1517636351;
				short num2 = num;
				num = (short)416893695;
				switch (num2 == num)
				{
				}
				num = (short)1919877120;
				short num3 = num;
				num = (short)203227137;
				if (num != 0)
				{
				}
				num = (short)1203568640;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobLongPressTime.Valid = value;
			}
		}

		// Token: 0x17003DA6 RID: 15782
		// (get) Token: 0x060077CD RID: 30669 RVA: 0x006C4FCC File Offset: 0x006C31CC
		// (set) Token: 0x060077CE RID: 30670 RVA: 0x006C5080 File Offset: 0x006C3280
		public bool RadErgoCfgSmartKeyFobLongPressTime_Visible
		{
			get
			{
				short num = (short)496428828;
				short num2 = num;
				num = (short)1779820316;
				switch (num2 == num)
				{
				}
				num = (short)1944911872;
				short num3 = num;
				num = (short)1781071873;
				if (num != 0)
				{
				}
				num = (short)1143144448;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobLongPressTime.Visible;
			}
			set
			{
				short num = (short)2012872313;
				short num2 = num;
				num = (short)1667497593;
				switch (num2 == num)
				{
				}
				num = (short)816644096;
				short num3 = num;
				num = (short)1356857345;
				if (num != 0)
				{
				}
				num = (short)567541760;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobLongPressTime.Visible = value;
			}
		}

		// Token: 0x17003DA7 RID: 15783
		// (get) Token: 0x060077CF RID: 30671 RVA: 0x006C5134 File Offset: 0x006C3334
		// (set) Token: 0x060077D0 RID: 30672 RVA: 0x006C51E8 File Offset: 0x006C33E8
		public bool RadErgoCfgSmartKeyFobLongPressTime_Editable
		{
			get
			{
				short num = (short)759643454;
				short num2 = num;
				num = (short)1593195838;
				switch (num2 == num)
				{
				}
				num = (short)1359609856;
				short num3 = num;
				num = (short)105644033;
				if (num != 0)
				{
				}
				num = (short)1720320000;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobLongPressTime.Editable;
			}
			set
			{
				short num = (short)1292275843;
				short num2 = num;
				num = (short)1458147459;
				switch (num2 == num)
				{
				}
				num = (short)2081619968;
				short num3 = num;
				num = (short)1778122753;
				if (num != 0)
				{
				}
				num = (short)1241120768;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobLongPressTime.Editable = value;
			}
		}

		// Token: 0x17003DA8 RID: 15784
		// (get) Token: 0x060077D1 RID: 30673 RVA: 0x006C529C File Offset: 0x006C349C
		internal string RadErgoCfgSmartKeyFobLongPressTime_UILabel
		{
			get
			{
				short num = (short)1552089089;
				if (num != 0)
				{
				}
				num = (short)1142341602;
				short num2 = num;
				num = (short)1688715234;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1330774016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1196228608;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobLongPressTime.UIName;
			}
		}

		// Token: 0x17003DA9 RID: 15785
		// (get) Token: 0x060077D2 RID: 30674 RVA: 0x006C5350 File Offset: 0x006C3550
		// (set) Token: 0x060077D3 RID: 30675 RVA: 0x006C5404 File Offset: 0x006C3604
		internal bool RadErgoCfgSmartKeyFobLongPressTime_HiddenStatic
		{
			get
			{
				short num = (short)1415257492;
				short num2 = num;
				num = (short)2131828116;
				switch (num2 == num)
				{
				}
				num = (short)1274478592;
				short num3 = num;
				num = (short)651886593;
				if (num != 0)
				{
				}
				num = (short)1077870592;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobLongPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)1874348975;
				short num2 = num;
				num = (short)207113135;
				switch (num2 == num)
				{
				}
				num = (short)681377792;
				short num3 = num;
				num = (short)1685258241;
				if (num != 0)
				{
				}
				num = (short)1659895808;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobLongPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17003DAA RID: 15786
		// (get) Token: 0x060077D4 RID: 30676 RVA: 0x006C54BC File Offset: 0x006C36BC
		// (set) Token: 0x060077D5 RID: 30677 RVA: 0x006C5570 File Offset: 0x006C3770
		internal bool RadErgoCfgSmartKeyFobLongPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)1705181185;
				if (num != 0)
				{
				}
				num = (short)1613789492;
				short num2 = num;
				num = (short)1546615092;
				switch (num2 == num)
				{
				default:
				{
					num = (short)826212352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)681181184;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobLongPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)1277390923;
				short num2 = num;
				num = (short)1477668939;
				switch (num2 == num)
				{
				}
				num = (short)307298304;
				short num3 = num;
				num = (short)552075265;
				if (num != 0)
				{
				}
				num = (short)1013907456;
				if (num != 0)
				{
				}
				this.radErgoCfgSmartKeyFobLongPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17003DAB RID: 15787
		// (get) Token: 0x060077D6 RID: 30678 RVA: 0x006C5628 File Offset: 0x006C3828
		public bool RadErgoCfgSmartKeyFobLongPressTime_HasDiffs
		{
			get
			{
				short num = (short)432010187;
				short num2 = num;
				num = (short)1168765899;
				switch (num2 == num)
				{
				}
				num = (short)1140719616;
				short num3 = num;
				num = (short)806486017;
				if (num != 0)
				{
				}
				num = (short)854851584;
				if (num != 0)
				{
				}
				return this.radErgoCfgSmartKeyFobLongPressTime._HasDiffs;
			}
		}

		// Token: 0x17003DAC RID: 15788
		// (get) Token: 0x060077D7 RID: 30679 RVA: 0x006C56DC File Offset: 0x006C38DC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1727378121;
				short num2 = num;
				num = (short)1768469193;
				switch (num2 == num)
				{
				}
				num = (short)2064318464;
				short num3 = num;
				num = (short)1587216385;
				if (num != 0)
				{
				}
				num = (short)1168637952;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x17003DAD RID: 15789
		// (get) Token: 0x060077D8 RID: 30680 RVA: 0x006C5798 File Offset: 0x006C3998
		public global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches RefSwitches
		{
			get
			{
				short num = (short)584951543;
				short num2 = num;
				num = (short)1382655735;
				switch (num2 == num)
				{
				}
				num = (short)1291714560;
				short num3 = num;
				num = (short)1010106369;
				if (num != 0)
				{
				}
				num = (short)2026504192;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2038)[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
			}
		}

		// Token: 0x17003DAE RID: 15790
		// (get) Token: 0x060077D9 RID: 30681 RVA: 0x006C5854 File Offset: 0x006C3A54
		public global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems RefMenuItems
		{
			get
			{
				short num = (short)1632809586;
				short num2 = num;
				num = (short)1592898162;
				switch (num2 == num)
				{
				}
				num = (short)474808320;
				short num3 = num;
				num = (short)2111111169;
				if (num != 0)
				{
				}
				num = (short)236650496;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2088)[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
			}
		}

		// Token: 0x17003DAF RID: 15791
		// (get) Token: 0x060077DA RID: 30682 RVA: 0x006C5914 File Offset: 0x006C3B14
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)1877765176;
				short num2 = num;
				num = (short)1519610936;
				switch (num2 == num)
				{
				}
				num = (short)2044002304;
				short num3 = num;
				num = (short)242876417;
				if (num != 0)
				{
				}
				num = (short)465371136;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x17003DB0 RID: 15792
		// (get) Token: 0x060077DB RID: 30683 RVA: 0x006C59D0 File Offset: 0x006C3BD0
		public global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide RefEmergencyWide
		{
			get
			{
				short num = (short)2127757313;
				if (num != 0)
				{
				}
				num = (short)1780882526;
				short num2 = num;
				num = (short)241114206;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1926955008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)934412288;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2032)[0] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide;
			}
		}

		// Token: 0x060077DC RID: 30684 RVA: 0x006C5A90 File Offset: 0x006C3C90
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
					goto IL_F0;
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)1684930563;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F0;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					goto IL_6F;
				case 3:
					num2 = (short)1844641793;
					if (num2 != 0)
					{
					}
					num2 = (short)1096089604;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)435814402;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F0;
				}
				goto IL_24;
				IL_6F:
				num2 = (short)1993670656;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_F0:
				num2 = (short)1372654187;
				short num3 = num2;
				num2 = (short)932448875;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_6F;
				case 1:
					goto IL_150;
				}
				break;
			}
			num2 = (short)1582891008;
			short num4 = num2;
			IL_150:
			num2 = (short)1134624768;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)140902401;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040031BA RID: 12730
		private global::AcpBusinessLayer.AcpField<string> radErgoCfgFobButtonName_A41573;

		// Token: 0x040031BB RID: 12731
		private global::AcpBusinessLayer.AcpListField radErgoCfgFobConventionalFeature_A41574;

		// Token: 0x040031BC RID: 12732
		private global::AcpBusinessLayer.AcpListField radErgoCfgFobTrunkingFeature_A41575;

		// Token: 0x040031BD RID: 12733
		private global::AcpBusinessLayer.AcpListField radErgoCfgFobConventionalBCO_A41577;

		// Token: 0x040031BE RID: 12734
		private global::AcpBusinessLayer.AcpListField radErgoCfgFobTrunkingBCO_A41578;

		// Token: 0x040031BF RID: 12735
		private global::AcpBusinessLayer.AcpKeyField radErgoCfgSmartKeyFobButtonKey_A41579;

		// Token: 0x040031C0 RID: 12736
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgSmartKeyFobShortPressTime;

		// Token: 0x040031C1 RID: 12737
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgSmartKeyFobLongPressTime;
	}
}
