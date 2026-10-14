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

namespace Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories
{
	// Token: 0x0200031F RID: 799
	[global::System.Serializable]
	public class KMButtonInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007C83 RID: 31875 RVA: 0x00722858 File Offset: 0x00720A58
		public KMButtonInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06007C84 RID: 31876 RVA: 0x00722874 File Offset: 0x00720A74
		protected KMButtonInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007C85 RID: 31877 RVA: 0x0072288C File Offset: 0x00720A8C
		public override void Init()
		{
			int a_ = 5;
			short num = (short)486980863;
			short num2 = num;
			num = (short)338017535;
			switch (num2 == num)
			{
			}
			num = (short)1869283328;
			if (num != 0)
			{
			}
			num = (short)2070937601;
			if (num != 0)
			{
			}
			num = (short)1922170880;
			short num3 = num;
			this.radErgoCfgKMConventionalKMButtonBCO_A19643 = new global::AcpBusinessLayer.AcpSparseLOVField(144, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.indexRadErgoCfgKMConventionalKMButtonBCO_A19643LovStrs, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.idRadErgoCfgKMConventionalKMButtonBCO_A19643LovStrs), this, global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗釙釛鷝迟賡鋣菥蛧黩藫臭黯鏱飳뷵뗷룹觻諽瓿洁樃䐅䬇䔉匋伍ℏ⬑∓∕⬗", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBCO, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.RadErgoCfgKMConventionalKMButtonBCO_A19643LovStrs);
			this.radErgoCfgKMConventionalKMButtonBCO_A19643.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgKMConventionalKMButtonBCO_A19643.DataTransferOrder = -1;
			this.radErgoCfgKMConventionalKMButtonFeature_A19646 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.indexRadErgoCfgKMConventionalKMButtonFeature_A19646LovStrs, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.idRadErgoCfgKMConventionalKMButtonFeature_A19646LovStrs), this, global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗釙釛鷝迟賡鋣菥蛧黩藫臭黯鏱飳뷵뗷룹觻諽瓿洁樃䀅洇欉砋笍戏眑䬓圕⤗⌙⨛⨝ᘟ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.RadErgoCfgKMConventionalKMButtonFeature_A19646LovStrs);
			this.radErgoCfgKMConventionalKMButtonFeature_A19646.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgKMConventionalKMButtonFeature_A19646.DataTransferOrder = 3;
			this.radErgoCfgKMTrunkingKMButtonBCO_A19745 = new global::AcpBusinessLayer.AcpSparseLOVField(144, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.indexRadErgoCfgKMTrunkingKMButtonBCO_A19745LovStrs, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.idRadErgoCfgKMTrunkingKMButtonBCO_A19745LovStrs), this, global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗釙釛諝鋟韡諣跥臧蓩诫ꗭ뷯냱至苵賷闹鋻볽䏿䴁嬃䜅㤇㌉㬋㨍┏", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.RadErgoCfgKMTrunkingKMButtonBCO_A19745LovStrs);
			this.radErgoCfgKMTrunkingKMButtonBCO_A19745.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgKMTrunkingKMButtonBCO_A19745.DataTransferOrder = -1;
			this.radErgoCfgKMTrunkingKMButtonFeature_A19746 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.indexRadErgoCfgKMTrunkingKMButtonFeature_A19746LovStrs, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.idRadErgoCfgKMTrunkingKMButtonFeature_A19746LovStrs), this, global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗釙釛諝鋟韡諣跥臧蓩诫ꗭ뷯냱至苵賷闹鋻룽旿持瀃猅稇漉匋伍ℏ⬑⌓∕⸗", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.RadErgoCfgKMTrunkingKMButtonFeature_A19746LovStrs);
			this.radErgoCfgKMTrunkingKMButtonFeature_A19746.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgKMTrunkingKMButtonFeature_A19746.DataTransferOrder = 5;
			this.radErgoCfgKMButtonKey_A22560 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗釙釛鳝闟雡郣觥蛧ꇩ觫韭꿯돱웳쓵췷쳹쳻", a_), global::CommonResources.AcgResources.ID_KEY, 20);
			this.radErgoCfgKMButtonKey_A22560.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgKMButtonKey_A22560.DataTransferOrder = -1;
			this.radErgoCfgKMButtonName_A22561 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_SIDETOPBUTTON, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗釙釛鳝闟雡郣觥蛧ꓩ跫菭闯귱뗳쓵쫷쿹쫻쿽", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.radErgoCfgKMButtonName_A22561.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radErgoCfgKMButtonName_A22561.DataTransferOrder = -1;
			this.radErgoCfgKMButtonShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗釙釛鳝闟雡郣觥蛧맩蓫臭苯蛱ꓳ蓵鷷觹迻꫽槿漁愃", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
			this.radErgoCfgKMButtonShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgKMButtonShortPressTime.DataTransferOrder = -1;
			this.radErgoCfgKMButtonShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.radErgoCfgKMButtonShortPressTime.ShowHexValue = false;
			this.radErgoCfgKMButtonShortPressTime.ValidateAcrossRecset = true;
			this.radErgoCfgKMButtonLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("铅꧇껉觋볍럏뷑韓냕뿗釙釛鳝闟雡郣觥蛧ꛩ菫胭韯ꋱ蛳鏵请觹ꣻ韽淿朁", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
			this.radErgoCfgKMButtonLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgKMButtonLongPressTime.DataTransferOrder = -1;
			this.radErgoCfgKMButtonLongPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.radErgoCfgKMButtonLongPressTime.ShowHexValue = false;
			this.radErgoCfgKMButtonLongPressTime.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跅藇軋믍꓏ꛑ믓룕", a_);
			base.Id = 10239;
			base.UIName = global::CommonResources.AcgResources.ID_KMBUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007C86 RID: 31878 RVA: 0x00722C0C File Offset: 0x00720E0C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)1454571536;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_354;
				case 1:
					if (producerFields != null)
					{
						num = (short)82771976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_779;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠꣢꣤돦鯨黪菬蓮飰鷲鋴볶듸맺裼课甀氂欄䄆氈樊礌税挐瘒䨔嘖⠘√⨜⬞ᜠ", a_)))
					{
						num = (short)81199117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_112;
				case 3:
					goto IL_306;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠꣢꣤ꗦ鳨鿪駬胮鿰뷲铴髶鳸ꓺ볼췾㌀㘂㌄㘆", a_)))
					{
						num = (short)693895180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_40D;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠꣢꣤ꓦ蛨藪鯬諮鿰蟲鳴飶韸髺釼듾䰀䄂瀄猆紈搊挌䤎琐爒愔或欘縚䈜帞ဠᨢጤጦἨ", a_)))
					{
						num = (short)1713897493;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_511;
				case 6:
					goto IL_5A8;
				case 7:
					this.radErgoCfgKMTrunkingKMButtonBCO_A19745 = new global::AcpBusinessLayer.AcpSparseLOVField(144, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.indexRadErgoCfgKMTrunkingKMButtonBCO_A19745LovStrs, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.idRadErgoCfgKMTrunkingKMButtonBCO_A19745LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠꣢꣤돦鯨黪菬蓮飰鷲鋴볶듸맺裼课甀氂欄䔆䨈䐊刌与‐⨒∔⌖Ⱈ", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.RadErgoCfgKMTrunkingKMButtonBCO_A19745LovStrs);
					this.radErgoCfgKMTrunkingKMButtonBCO_A19745.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgKMTrunkingKMButtonBCO_A19745.DataTransferOrder = -1;
					num = (short)1446838272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)671088654;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠꣢꣤ꗦ鳨鿪駬胮鿰뿲髴駶黸꯺迼髾爀瀂億渆搈渊", a_)))
					{
						num = (short)1605500954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_779;
				case 10:
					goto IL_15B;
				case 11:
					goto IL_511;
				case 12:
				{
					this.radErgoCfgKMButtonName_A22561 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_SIDETOPBUTTON, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠꣢꣤ꗦ鳨鿪駬胮鿰뷲铴髶鳸ꓺ볼췾㌀㘂㌄㘆", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.radErgoCfgKMButtonName_A22561.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgKMButtonName_A22561.DataTransferOrder = -1;
					num = (short)149553152;
					short num3 = num;
					num = (short)1337589775;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 13:
					this.radErgoCfgKMTrunkingKMButtonFeature_A19746 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.indexRadErgoCfgKMTrunkingKMButtonFeature_A19746LovStrs, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.idRadErgoCfgKMTrunkingKMButtonFeature_A19746LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠꣢꣤돦鯨黪菬蓮飰鷲鋴볶듸맺裼课甀氂欄䄆氈樊礌税挐瘒䨔嘖⠘√⨜⬞ᜠ", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.RadErgoCfgKMTrunkingKMButtonFeature_A19746LovStrs);
					this.radErgoCfgKMTrunkingKMButtonFeature_A19746.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgKMTrunkingKMButtonFeature_A19746.DataTransferOrder = 5;
					num = (short)2086338582;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠꣢꣤ꓦ蛨藪鯬諮鿰蟲鳴飶韸髺釼듾䰀䄂瀄猆紈搊挌䴎刐尒䨔嘖⠘√⬜⬞ሠ", a_)))
					{
						num = (short)1428094995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_15B;
				case 15:
					goto IL_40D;
				case 16:
					switch (0)
					{
					case 0:
						goto IL_9D;
					}
					continue;
				case 17:
					goto IL_C5;
				case 18:
					this.radErgoCfgKMButtonShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠꣢꣤ꗦ鳨鿪駬胮鿰ꃲ鷴飶诸迺근跾搀瀂瘄匆怈昊栌", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
					this.radErgoCfgKMButtonShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgKMButtonShortPressTime.DataTransferOrder = -1;
					this.radErgoCfgKMButtonShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.radErgoCfgKMButtonShortPressTime.ShowHexValue = false;
					this.radErgoCfgKMButtonShortPressTime.ValidateAcrossRecset = true;
					num = (short)506200067;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					this.radErgoCfgKMConventionalKMButtonBCO_A19643 = new global::AcpBusinessLayer.AcpSparseLOVField(144, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.indexRadErgoCfgKMConventionalKMButtonBCO_A19643LovStrs, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.idRadErgoCfgKMConventionalKMButtonBCO_A19643LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠꣢꣤ꓦ蛨藪鯬諮鿰蟲鳴飶韸髺釼듾䰀䄂瀄猆紈搊挌䴎刐尒䨔嘖⠘√⬜⬞ሠ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBCO, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.RadErgoCfgKMConventionalKMButtonBCO_A19643LovStrs);
					this.radErgoCfgKMConventionalKMButtonBCO_A19643.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgKMConventionalKMButtonBCO_A19643.DataTransferOrder = -1;
					num = (short)385613834;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠꣢꣤ꗦ鳨鿪駬胮鿰룲郴軶꛸뫺쿼췾㐀㔂㔄", a_)))
					{
						num = (short)2103443483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C5;
				case 21:
					this.radErgoCfgKMConventionalKMButtonFeature_A19646 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.indexRadErgoCfgKMConventionalKMButtonFeature_A19646LovStrs, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.idRadErgoCfgKMConventionalKMButtonFeature_A19646LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠꣢꣤ꓦ蛨藪鯬諮鿰蟲鳴飶韸髺釼듾䰀䄂瀄猆紈搊挌䤎琐爒愔或欘縚䈜帞ဠᨢጤጦἨ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.LOVs.RadErgoCfgKMConventionalKMButtonFeature_A19646LovStrs);
					this.radErgoCfgKMConventionalKMButtonFeature_A19646.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radErgoCfgKMConventionalKMButtonFeature_A19646.DataTransferOrder = 3;
					num = (short)1316683787;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					goto IL_112;
				case 23:
					goto IL_50C;
				case 24:
				{
					if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠꣢꣤돦鯨黪菬蓮飰鷲鋴볶듸맺裼课甀氂欄䔆䨈䐊刌与‐⨒∔⌖Ⱈ", a_)))
					{
						goto IL_354;
					}
					num = (short)1001313751;
					short num4 = num;
					num = (short)616879575;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5A8;
					default:
						num = (short)1582235648;
						if (num != 0)
						{
						}
						num = (short)2140340231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 25:
					num = (short)700973057;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠꣢꣤ꗦ鳨鿪駬胮鿰ꃲ鷴飶诸迺근跾搀瀂瘄匆怈昊栌", a_)))
					{
						num = (short)2104688658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_306;
				case 26:
					this.radErgoCfgKMButtonLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠꣢꣤ꗦ鳨鿪駬胮鿰뿲髴駶黸꯺迼髾爀瀂億渆搈渊", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
					this.radErgoCfgKMButtonLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgKMButtonLongPressTime.DataTransferOrder = -1;
					this.radErgoCfgKMButtonLongPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.radErgoCfgKMButtonLongPressTime.ShowHexValue = false;
					this.radErgoCfgKMButtonLongPressTime.ValidateAcrossRecset = true;
					num = (short)1229193239;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					this.radErgoCfgKMButtonKey_A22560 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鷎냐럒郔ꗖ뻘듚黜맞蛠꣢꣤ꗦ鳨鿪駬胮鿰룲郴軶꛸뫺쿼췾㐀㔂㔄", a_), global::CommonResources.AcgResources.ID_KEY, 20);
					this.radErgoCfgKMButtonKey_A22560.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgKMButtonKey_A22560.DataTransferOrder = -1;
					num = (short)948830225;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1358233606;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_C5:
				num = (short)1038876676;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_112:
				num = (short)817233940;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_15B:
				num = (short)719585285;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_306:
				num = (short)652279817;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_354:
				num = (short)1451294722;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_40D:
				num = (short)1148125209;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_511:
				num = (short)1704067096;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5A8:
				num = (short)1012269057;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_50C:
			IL_779:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓎鳐韔ꋖ귘꿚닜뇞", a_);
			base.Id = 10239;
			base.UIName = global::CommonResources.AcgResources.ID_KMBUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007C87 RID: 31879 RVA: 0x007233C4 File Offset: 0x007215C4
		public override void PopulateReferences()
		{
			short num = (short)558891009;
			if (num != 0)
			{
			}
			num = (short)1930625024;
			short num2 = num;
			num = (short)98386193;
			short num3 = num;
			num = (short)1820279057;
			switch (num3 == num)
			{
			}
			num = (short)722272256;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007C88 RID: 31880 RVA: 0x0072346C File Offset: 0x0072166C
		public override void DropReferences()
		{
			short num = (short)1597970487;
			short num2 = num;
			num = (short)497621047;
			switch (num2 == num)
			{
			default:
			{
				num = (short)589627392;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)678625281;
			if (num != 0)
			{
			}
			num = (short)1242169344;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007C89 RID: 31881 RVA: 0x00723518 File Offset: 0x00721718
		public override void SetConstraints()
		{
			short num = (short)1021247489;
			if (num != 0)
			{
			}
			num = (short)1580400640;
			short num2 = num;
			num = (short)1646846066;
			short num3 = num;
			num = (short)592961650;
			switch (num3 == num)
			{
			}
			num = (short)365428736;
			if (num != 0)
			{
			}
			this.radErgoCfgKMConventionalKMButtonFeature_A19646.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.ConConvFeatureIsSameAsTrk);
			this.radErgoCfgKMConventionalKMButtonFeature_A19646.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.ConSyncCnvKMBtnFeature);
			this.radErgoCfgKMTrunkingKMButtonFeature_A19746.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.ConKMTrunkingButtonIsValid);
			this.radErgoCfgKMTrunkingKMButtonFeature_A19746.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.ConSyncTrkKMBtnFeature);
			this.radErgoCfgKMTrunkingKMButtonFeature_A19746.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.ConSetEditabilityTrkFeature);
			this.radErgoCfgKMButtonName_A22561.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06007C8A RID: 31882 RVA: 0x0072364C File Offset: 0x0072184C
		public override void SetupDependencies()
		{
			short num = (short)2009858980;
			short num2 = num;
			num = (short)1374684068;
			switch (num2 == num)
			{
			default:
			{
				num = (short)368967680;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)317194241;
			if (num != 0)
			{
			}
			num = (short)760217600;
			if (num != 0)
			{
			}
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoCfgKMConventionalKMButtonFeature_A19646);
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561.AddDependentObject(this.radErgoCfgKMConventionalKMButtonFeature_A19646);
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550.AddDependentObject(this.radErgoCfgKMConventionalKMButtonFeature_A19646);
			this.radErgoCfgKMTrunkingKMButtonFeature_A19746.AddDependentObject(this.radErgoCfgKMConventionalKMButtonFeature_A19646);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radErgoCfgKMTrunkingKMButtonFeature_A19746);
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561.AddDependentObject(this.radErgoCfgKMTrunkingKMButtonFeature_A19746);
			this.radErgoCfgKMConventionalKMButtonFeature_A19646.AddDependentObject(this.radErgoCfgKMTrunkingKMButtonFeature_A19746);
			this.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550.AddDependentObject(this.radErgoCfgKMTrunkingKMButtonFeature_A19746);
			this.RefRadioWide.Features.RadWideFeaturesChannelFallbackEnable.AddDependentObject(this.radErgoCfgKMTrunkingKMButtonFeature_A19746);
			this.RefRadioWide.Features.RadWideFeaturesChannelFallbackEnable.AddDependentObject(this.radErgoCfgKMConventionalKMButtonFeature_A19646);
		}

		// Token: 0x17003FC5 RID: 16325
		// (get) Token: 0x06007C8B RID: 31883 RVA: 0x007237F8 File Offset: 0x007219F8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1073760253;
				short num2 = num;
				num = (short)1126647805;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1184497664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)16777217;
				if (num != 0)
				{
				}
				num = (short)543621120;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003FC6 RID: 16326
		// (get) Token: 0x06007C8C RID: 31884 RVA: 0x007238A4 File Offset: 0x00721AA4
		// (set) Token: 0x06007C8D RID: 31885 RVA: 0x00723958 File Offset: 0x00721B58
		public int RadErgoCfgKMConventionalKMButtonBCO_A19643Value
		{
			get
			{
				short num = (short)1707249923;
				short num2 = num;
				num = (short)1484296451;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1912864768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)58720257;
				if (num != 0)
				{
				}
				num = (short)564330496;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonBCO_A19643.Value;
			}
			set
			{
				short num = (short)1926294794;
				short num2 = num;
				num = (short)772861194;
				switch (num2 == num)
				{
				default:
				{
					num = (short)148570112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1920139264;
				if (num != 0)
				{
				}
				num = (short)831979521;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMButtonBCO_A19643.Value = value;
			}
		}

		// Token: 0x17003FC7 RID: 16327
		// (get) Token: 0x06007C8E RID: 31886 RVA: 0x00723A10 File Offset: 0x00721C10
		// (set) Token: 0x06007C8F RID: 31887 RVA: 0x00723AC4 File Offset: 0x00721CC4
		public string RadErgoCfgKMConventionalKMButtonBCO_A19643_UIValue
		{
			get
			{
				short num = (short)1543823321;
				short num2 = num;
				num = (short)1248387033;
				switch (num2 == num)
				{
				default:
				{
					num = (short)209649664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)970588161;
				if (num != 0)
				{
				}
				num = (short)1824129024;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonBCO_A19643.UIValue;
			}
			set
			{
				short num = (short)736506068;
				short num2 = num;
				num = (short)1683042516;
				switch (num2 == num)
				{
				default:
				{
					num = (short)716963840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)716046336;
				if (num != 0)
				{
				}
				num = (short)2105540609;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMButtonBCO_A19643.UIValue = value;
			}
		}

		// Token: 0x17003FC8 RID: 16328
		// (get) Token: 0x06007C90 RID: 31888 RVA: 0x00723B78 File Offset: 0x00721D78
		public global::AcpBusinessLayer.AcpListField RadErgoCfgKMConventionalKMButtonBCO_A19643
		{
			get
			{
				short num = (short)563675305;
				short num2 = num;
				num = (short)171835561;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1527054336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1837236225;
				if (num != 0)
				{
				}
				num = (short)747307008;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonBCO_A19643;
			}
		}

		// Token: 0x17003FC9 RID: 16329
		// (get) Token: 0x06007C91 RID: 31889 RVA: 0x00723C28 File Offset: 0x00721E28
		// (set) Token: 0x06007C92 RID: 31890 RVA: 0x00723CDC File Offset: 0x00721EDC
		public bool RadErgoCfgKMConventionalKMButtonBCO_A19643_Applicable
		{
			get
			{
				short num = (short)297436113;
				short num2 = num;
				num = (short)541492177;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1952907264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1598357505;
				if (num != 0)
				{
				}
				num = (short)1886650368;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonBCO_A19643.Applicable;
			}
			set
			{
				short num = (short)776931983;
				short num2 = num;
				num = (short)1909262991;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2109865984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)437387265;
				if (num != 0)
				{
				}
				num = (short)2122252288;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMButtonBCO_A19643.Applicable = value;
			}
		}

		// Token: 0x17003FCA RID: 16330
		// (get) Token: 0x06007C93 RID: 31891 RVA: 0x00723D90 File Offset: 0x00721F90
		// (set) Token: 0x06007C94 RID: 31892 RVA: 0x00723E48 File Offset: 0x00722048
		public bool RadErgoCfgKMConventionalKMButtonBCO_A19643_Valid
		{
			get
			{
				short num = (short)1438509847;
				short num2 = num;
				num = (short)316009239;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1912733696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1401487360;
				if (num != 0)
				{
				}
				num = (short)1937571841;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonBCO_A19643.Valid;
			}
			set
			{
				short num = (short)904450828;
				short num2 = num;
				num = (short)567202572;
				switch (num2 == num)
				{
				default:
				{
					num = (short)15204352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)229965825;
				if (num != 0)
				{
				}
				num = (short)1568997376;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMButtonBCO_A19643.Valid = value;
			}
		}

		// Token: 0x17003FCB RID: 16331
		// (get) Token: 0x06007C95 RID: 31893 RVA: 0x00723EFC File Offset: 0x007220FC
		// (set) Token: 0x06007C96 RID: 31894 RVA: 0x00723FB0 File Offset: 0x007221B0
		public bool RadErgoCfgKMConventionalKMButtonBCO_A19643_Visible
		{
			get
			{
				short num = (short)1616435639;
				short num2 = num;
				num = (short)262986167;
				switch (num2 == num)
				{
				default:
				{
					num = (short)314703872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)144637953;
				if (num != 0)
				{
				}
				num = (short)379453440;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonBCO_A19643.Visible;
			}
			set
			{
				short num = (short)933697762;
				short num2 = num;
				num = (short)1715149026;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1678966784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1031471104;
				if (num != 0)
				{
				}
				num = (short)549584897;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMButtonBCO_A19643.Visible = value;
			}
		}

		// Token: 0x17003FCC RID: 16332
		// (get) Token: 0x06007C97 RID: 31895 RVA: 0x00724068 File Offset: 0x00722268
		// (set) Token: 0x06007C98 RID: 31896 RVA: 0x00724118 File Offset: 0x00722318
		public bool RadErgoCfgKMConventionalKMButtonBCO_A19643_Editable
		{
			get
			{
				short num = (short)1067297394;
				short num2 = num;
				num = (short)828418674;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1019150336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)503644160;
				if (num != 0)
				{
				}
				num = (short)2084175873;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonBCO_A19643.Editable;
			}
			set
			{
				short num = (short)1895233969;
				short num2 = num;
				num = (short)706083249;
				switch (num2 == num)
				{
				default:
				{
					num = (short)999030784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1686962177;
				if (num != 0)
				{
				}
				num = (short)1412300800;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMButtonBCO_A19643.Editable = value;
			}
		}

		// Token: 0x17003FCD RID: 16333
		// (get) Token: 0x06007C99 RID: 31897 RVA: 0x007241CC File Offset: 0x007223CC
		internal string RadErgoCfgKMConventionalKMButtonBCO_A19643_UILabel
		{
			get
			{
				short num = (short)741765458;
				short num2 = num;
				num = (short)310669650;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1233387520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)866648065;
				if (num != 0)
				{
				}
				num = (short)309985280;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonBCO_A19643.UIName;
			}
		}

		// Token: 0x17003FCE RID: 16334
		// (get) Token: 0x06007C9A RID: 31898 RVA: 0x00724280 File Offset: 0x00722480
		// (set) Token: 0x06007C9B RID: 31899 RVA: 0x00724334 File Offset: 0x00722534
		internal bool RadErgoCfgKMConventionalKMButtonBCO_A19643_HiddenStatic
		{
			get
			{
				short num = (short)2125442500;
				short num2 = num;
				num = (short)2097196484;
				switch (num2 == num)
				{
				default:
				{
					num = (short)386924544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1122107393;
				if (num != 0)
				{
				}
				num = (short)1278869504;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonBCO_A19643.HiddenStatic;
			}
			set
			{
				short num = (short)610795521;
				if (num != 0)
				{
				}
				num = (short)790691840;
				short num2 = num;
				num = (short)2095507228;
				short num3 = num;
				num = (short)417785628;
				switch (num3 == num)
				{
				}
				num = (short)820314112;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMButtonBCO_A19643.HiddenStatic = value;
			}
		}

		// Token: 0x17003FCF RID: 16335
		// (get) Token: 0x06007C9C RID: 31900 RVA: 0x007243E8 File Offset: 0x007225E8
		// (set) Token: 0x06007C9D RID: 31901 RVA: 0x0072449C File Offset: 0x0072269C
		internal bool RadErgoCfgKMConventionalKMButtonBCO_A19643_HiddenDynamic
		{
			get
			{
				short num = (short)1408467636;
				short num2 = num;
				num = (short)622887604;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1208942592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1593704448;
				if (num != 0)
				{
				}
				num = (short)76611585;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonBCO_A19643.HiddenDynamic;
			}
			set
			{
				short num = (short)2114966681;
				short num2 = num;
				num = (short)1657853081;
				switch (num2 == num)
				{
				default:
				{
					num = (short)290455552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)330694657;
				if (num != 0)
				{
				}
				num = (short)701759488;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMButtonBCO_A19643.HiddenDynamic = value;
			}
		}

		// Token: 0x17003FD0 RID: 16336
		// (get) Token: 0x06007C9E RID: 31902 RVA: 0x00724550 File Offset: 0x00722750
		public bool RadErgoCfgKMConventionalKMButtonBCO_A19643_HasDiffs
		{
			get
			{
				short num = (short)52705259;
				short num2 = num;
				num = (short)146552811;
				switch (num2 == num)
				{
				default:
				{
					num = (short)30539776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1593376769;
				if (num != 0)
				{
				}
				num = (short)21692416;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonBCO_A19643._HasDiffs;
			}
		}

		// Token: 0x17003FD1 RID: 16337
		// (get) Token: 0x06007C9F RID: 31903 RVA: 0x00724604 File Offset: 0x00722804
		// (set) Token: 0x06007CA0 RID: 31904 RVA: 0x007246B8 File Offset: 0x007228B8
		public int RadErgoCfgKMConventionalKMButtonFeature_A19646Value
		{
			get
			{
				short num = (short)1214086617;
				short num2 = num;
				num = (short)259358169;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1391656960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1435500545;
				if (num != 0)
				{
				}
				num = (short)1433337856;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonFeature_A19646.Value;
			}
			set
			{
				short num = (short)1099694081;
				if (num != 0)
				{
				}
				num = (short)2030436352;
				short num2 = num;
				num = (short)984614579;
				short num3 = num;
				num = (short)876938931;
				switch (num3 == num)
				{
				}
				num = (short)2133131264;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMButtonFeature_A19646.Value = value;
			}
		}

		// Token: 0x17003FD2 RID: 16338
		// (get) Token: 0x06007CA1 RID: 31905 RVA: 0x00724770 File Offset: 0x00722970
		// (set) Token: 0x06007CA2 RID: 31906 RVA: 0x00724824 File Offset: 0x00722A24
		public string RadErgoCfgKMConventionalKMButtonFeature_A19646_UIValue
		{
			get
			{
				short num = (short)456789144;
				short num2 = num;
				num = (short)1163725976;
				switch (num2 == num)
				{
				}
				num = (short)832634881;
				if (num != 0)
				{
				}
				num = (short)987758592;
				short num3 = num;
				num = (short)506789888;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonFeature_A19646.UIValue;
			}
			set
			{
				short num = (short)543617765;
				short num2 = num;
				num = (short)1860432613;
				switch (num2 == num)
				{
				}
				num = (short)1357447169;
				if (num != 0)
				{
				}
				num = (short)1939800064;
				short num3 = num;
				num = (short)1238040576;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMButtonFeature_A19646.UIValue = value;
			}
		}

		// Token: 0x17003FD3 RID: 16339
		// (get) Token: 0x06007CA3 RID: 31907 RVA: 0x007248D8 File Offset: 0x00722AD8
		public global::AcpBusinessLayer.AcpListField RadErgoCfgKMConventionalKMButtonFeature_A19646
		{
			get
			{
				short num = (short)494495713;
				short num2 = num;
				num = (short)1250256865;
				switch (num2 == num)
				{
				}
				num = (short)1256718337;
				if (num != 0)
				{
				}
				num = (short)728563712;
				short num3 = num;
				num = (short)344719360;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonFeature_A19646;
			}
		}

		// Token: 0x17003FD4 RID: 16340
		// (get) Token: 0x06007CA4 RID: 31908 RVA: 0x00724984 File Offset: 0x00722B84
		// (set) Token: 0x06007CA5 RID: 31909 RVA: 0x00724A38 File Offset: 0x00722C38
		public bool RadErgoCfgKMConventionalKMButtonFeature_A19646_Applicable
		{
			get
			{
				short num = (short)1398470950;
				short num2 = num;
				num = (short)1483864358;
				switch (num2 == num)
				{
				}
				num = (short)1726808064;
				if (num != 0)
				{
				}
				num = (short)1537933312;
				short num3 = num;
				num = (short)1960574977;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonFeature_A19646.Applicable;
			}
			set
			{
				short num = (short)401801217;
				if (num != 0)
				{
				}
				num = (short)1975841772;
				short num2 = num;
				num = (short)821359596;
				switch (num2 == num)
				{
				}
				num = (short)784269312;
				short num3 = num;
				num = (short)1750007808;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMButtonFeature_A19646.Applicable = value;
			}
		}

		// Token: 0x17003FD5 RID: 16341
		// (get) Token: 0x06007CA6 RID: 31910 RVA: 0x00724AEC File Offset: 0x00722CEC
		// (set) Token: 0x06007CA7 RID: 31911 RVA: 0x00724BA4 File Offset: 0x00722DA4
		public bool RadErgoCfgKMConventionalKMButtonFeature_A19646_Valid
		{
			get
			{
				short num = (short)1083310081;
				if (num != 0)
				{
				}
				num = (short)701208600;
				short num2 = num;
				num = (short)539269144;
				switch (num2 == num)
				{
				}
				num = (short)821493760;
				short num3 = num;
				num = (short)1857617920;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonFeature_A19646.Valid;
			}
			set
			{
				short num = (short)935422130;
				short num2 = num;
				num = (short)25782450;
				switch (num2 == num)
				{
				}
				num = (short)236257281;
				if (num != 0)
				{
				}
				num = (short)1795620864;
				short num3 = num;
				num = (short)6946816;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMButtonFeature_A19646.Valid = value;
			}
		}

		// Token: 0x17003FD6 RID: 16342
		// (get) Token: 0x06007CA8 RID: 31912 RVA: 0x00724C58 File Offset: 0x00722E58
		// (set) Token: 0x06007CA9 RID: 31913 RVA: 0x00724D0C File Offset: 0x00722F0C
		public bool RadErgoCfgKMConventionalKMButtonFeature_A19646_Visible
		{
			get
			{
				short num = (short)370244354;
				short num2 = num;
				num = (short)758545154;
				switch (num2 == num)
				{
				}
				num = (short)1164509185;
				if (num != 0)
				{
				}
				num = (short)1963720704;
				short num3 = num;
				num = (short)705363968;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonFeature_A19646.Visible;
			}
			set
			{
				short num = (short)88574615;
				short num2 = num;
				num = (short)2139720343;
				switch (num2 == num)
				{
				}
				num = (short)1021968384;
				if (num != 0)
				{
				}
				num = (short)1472135168;
				short num3 = num;
				num = (short)1961558017;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMButtonFeature_A19646.Visible = value;
			}
		}

		// Token: 0x17003FD7 RID: 16343
		// (get) Token: 0x06007CAA RID: 31914 RVA: 0x00724DC4 File Offset: 0x00722FC4
		// (set) Token: 0x06007CAB RID: 31915 RVA: 0x00724E78 File Offset: 0x00723078
		public bool RadErgoCfgKMConventionalKMButtonFeature_A19646_Editable
		{
			get
			{
				short num = (short)1602383319;
				short num2 = num;
				num = (short)505507287;
				switch (num2 == num)
				{
				}
				num = (short)1261305856;
				if (num != 0)
				{
				}
				num = (short)225837056;
				short num3 = num;
				num = (short)385613825;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonFeature_A19646.Editable;
			}
			set
			{
				short num = (short)372021641;
				short num2 = num;
				num = (short)713267593;
				switch (num2 == num)
				{
				}
				num = (short)300154881;
				if (num != 0)
				{
				}
				num = (short)1510604800;
				short num3 = num;
				num = (short)1943601152;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMButtonFeature_A19646.Editable = value;
			}
		}

		// Token: 0x17003FD8 RID: 16344
		// (get) Token: 0x06007CAC RID: 31916 RVA: 0x00724F2C File Offset: 0x0072312C
		internal string RadErgoCfgKMConventionalKMButtonFeature_A19646_UILabel
		{
			get
			{
				short num = (short)1796939598;
				short num2 = num;
				num = (short)1018371918;
				switch (num2 == num)
				{
				}
				num = (short)1989541889;
				if (num != 0)
				{
				}
				num = (short)1714094080;
				short num3 = num;
				num = (short)270532608;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonFeature_A19646.UIName;
			}
		}

		// Token: 0x17003FD9 RID: 16345
		// (get) Token: 0x06007CAD RID: 31917 RVA: 0x00724FE0 File Offset: 0x007231E0
		// (set) Token: 0x06007CAE RID: 31918 RVA: 0x00725094 File Offset: 0x00723294
		internal bool RadErgoCfgKMConventionalKMButtonFeature_A19646_HiddenStatic
		{
			get
			{
				short num = (short)90331394;
				short num2 = num;
				num = (short)749099266;
				switch (num2 == num)
				{
				}
				num = (short)1848508417;
				if (num != 0)
				{
				}
				num = (short)1887240192;
				short num3 = num;
				num = (short)949551104;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonFeature_A19646.HiddenStatic;
			}
			set
			{
				short num = (short)1502412801;
				if (num != 0)
				{
				}
				num = (short)1513853190;
				short num2 = num;
				num = (short)1827246342;
				switch (num2 == num)
				{
				}
				num = (short)1526726656;
				short num3 = num;
				num = (short)26214400;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMButtonFeature_A19646.HiddenStatic = value;
			}
		}

		// Token: 0x17003FDA RID: 16346
		// (get) Token: 0x06007CAF RID: 31919 RVA: 0x00725148 File Offset: 0x00723348
		// (set) Token: 0x06007CB0 RID: 31920 RVA: 0x007251FC File Offset: 0x007233FC
		internal bool RadErgoCfgKMConventionalKMButtonFeature_A19646_HiddenDynamic
		{
			get
			{
				short num = (short)1879169302;
				short num2 = num;
				num = (short)69523734;
				switch (num2 == num)
				{
				}
				num = (short)1256849408;
				if (num != 0)
				{
				}
				num = (short)1324285952;
				short num3 = num;
				num = (short)256507905;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonFeature_A19646.HiddenDynamic;
			}
			set
			{
				short num = (short)1479928131;
				short num2 = num;
				num = (short)85125443;
				switch (num2 == num)
				{
				}
				num = (short)1785593856;
				if (num != 0)
				{
				}
				num = (short)751304704;
				short num3 = num;
				num = (short)830996481;
				if (num != 0)
				{
				}
				this.radErgoCfgKMConventionalKMButtonFeature_A19646.HiddenDynamic = value;
			}
		}

		// Token: 0x17003FDB RID: 16347
		// (get) Token: 0x06007CB1 RID: 31921 RVA: 0x007252B4 File Offset: 0x007234B4
		public bool RadErgoCfgKMConventionalKMButtonFeature_A19646_HasDiffs
		{
			get
			{
				short num = (short)110432351;
				short num2 = num;
				num = (short)317984863;
				switch (num2 == num)
				{
				}
				num = (short)365035521;
				if (num != 0)
				{
				}
				num = (short)1590099968;
				short num3 = num;
				num = (short)1099366400;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMConventionalKMButtonFeature_A19646._HasDiffs;
			}
		}

		// Token: 0x17003FDC RID: 16348
		// (get) Token: 0x06007CB2 RID: 31922 RVA: 0x00725368 File Offset: 0x00723568
		// (set) Token: 0x06007CB3 RID: 31923 RVA: 0x00725420 File Offset: 0x00723620
		public int RadErgoCfgKMTrunkingKMButtonBCO_A19745Value
		{
			get
			{
				short num = (short)546697792;
				short num2 = num;
				num = (short)1669526080;
				switch (num2 == num)
				{
				}
				num = (short)1597505537;
				if (num != 0)
				{
				}
				num = (short)1338900480;
				short num3 = num;
				num = (short)336723968;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonBCO_A19745.Value;
			}
			set
			{
				short num = (short)2077181616;
				short num2 = num;
				num = (short)238831280;
				switch (num2 == num)
				{
				}
				num = (short)1580924928;
				if (num != 0)
				{
				}
				num = (short)23461888;
				short num3 = num;
				num = (short)937492481;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMButtonBCO_A19745.Value = value;
			}
		}

		// Token: 0x17003FDD RID: 16349
		// (get) Token: 0x06007CB4 RID: 31924 RVA: 0x007254D8 File Offset: 0x007236D8
		// (set) Token: 0x06007CB5 RID: 31925 RVA: 0x0072558C File Offset: 0x0072378C
		public string RadErgoCfgKMTrunkingKMButtonBCO_A19745_UIValue
		{
			get
			{
				short num = (short)279258389;
				short num2 = num;
				num = (short)1703486741;
				switch (num2 == num)
				{
				}
				num = (short)1734868993;
				if (num != 0)
				{
				}
				num = (short)514260992;
				short num3 = num;
				num = (short)340066304;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonBCO_A19745.UIValue;
			}
			set
			{
				short num = (short)966721536;
				short num2 = num;
				num = (short)766754585;
				short num3 = num;
				num = (short)595115801;
				switch (num3 == num)
				{
				}
				num = (short)1207304192;
				if (num != 0)
				{
				}
				num = (short)1400438785;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMButtonBCO_A19745.UIValue = value;
			}
		}

		// Token: 0x17003FDE RID: 16350
		// (get) Token: 0x06007CB6 RID: 31926 RVA: 0x00725640 File Offset: 0x00723840
		public global::AcpBusinessLayer.AcpListField RadErgoCfgKMTrunkingKMButtonBCO_A19745
		{
			get
			{
				short num = (short)1568079872;
				short num2 = num;
				num = (short)1675172064;
				short num3 = num;
				num = (short)2050824416;
				switch (num3 == num)
				{
				}
				num = (short)1326579713;
				if (num != 0)
				{
				}
				num = (short)2059730944;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonBCO_A19745;
			}
		}

		// Token: 0x17003FDF RID: 16351
		// (get) Token: 0x06007CB7 RID: 31927 RVA: 0x007256F0 File Offset: 0x007238F0
		// (set) Token: 0x06007CB8 RID: 31928 RVA: 0x007257A4 File Offset: 0x007239A4
		public bool RadErgoCfgKMTrunkingKMButtonBCO_A19745_Applicable
		{
			get
			{
				short num = (short)385810432;
				short num2 = num;
				num = (short)1309933569;
				if (num != 0)
				{
				}
				num = (short)532507983;
				short num3 = num;
				num = (short)336096591;
				switch (num3 == num)
				{
				}
				num = (short)1599143936;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonBCO_A19745.Applicable;
			}
			set
			{
				short num = (short)1794834432;
				short num2 = num;
				num = (short)116832841;
				short num3 = num;
				num = (short)478722633;
				switch (num3 == num)
				{
				}
				num = (short)811008001;
				if (num != 0)
				{
				}
				num = (short)871759872;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMButtonBCO_A19745.Applicable = value;
			}
		}

		// Token: 0x17003FE0 RID: 16352
		// (get) Token: 0x06007CB9 RID: 31929 RVA: 0x00725858 File Offset: 0x00723A58
		// (set) Token: 0x06007CBA RID: 31930 RVA: 0x00725910 File Offset: 0x00723B10
		public bool RadErgoCfgKMTrunkingKMButtonBCO_A19745_Valid
		{
			get
			{
				short num = (short)1341325312;
				short num2 = num;
				num = (short)1108976668;
				short num3 = num;
				num = (short)600286236;
				switch (num3 == num)
				{
				}
				num = (short)324206593;
				if (num != 0)
				{
				}
				num = (short)1394606080;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonBCO_A19745.Valid;
			}
			set
			{
				short num = (short)2037710848;
				short num2 = num;
				num = (short)164936907;
				short num3 = num;
				num = (short)735755467;
				switch (num3 == num)
				{
				}
				num = (short)1733492737;
				if (num != 0)
				{
				}
				num = (short)735510528;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMButtonBCO_A19745.Valid = value;
			}
		}

		// Token: 0x17003FE1 RID: 16353
		// (get) Token: 0x06007CBB RID: 31931 RVA: 0x007259C4 File Offset: 0x00723BC4
		// (set) Token: 0x06007CBC RID: 31932 RVA: 0x00725A78 File Offset: 0x00723C78
		public bool RadErgoCfgKMTrunkingKMButtonBCO_A19745_Visible
		{
			get
			{
				short num = (short)626262016;
				short num2 = num;
				num = (short)130164226;
				short num3 = num;
				num = (short)566830594;
				switch (num3 == num)
				{
				}
				num = (short)1786511361;
				if (num != 0)
				{
				}
				num = (short)1439301632;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonBCO_A19745.Visible;
			}
			set
			{
				short num = (short)1211826176;
				short num2 = num;
				num = (short)1901137722;
				short num3 = num;
				num = (short)1251610426;
				switch (num3 == num)
				{
				}
				num = (short)826933249;
				if (num != 0)
				{
				}
				num = (short)1763180544;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMButtonBCO_A19745.Visible = value;
			}
		}

		// Token: 0x17003FE2 RID: 16354
		// (get) Token: 0x06007CBD RID: 31933 RVA: 0x00725B30 File Offset: 0x00723D30
		// (set) Token: 0x06007CBE RID: 31934 RVA: 0x00725BE4 File Offset: 0x00723DE4
		public bool RadErgoCfgKMTrunkingKMButtonBCO_A19745_Editable
		{
			get
			{
				short num = (short)1530855424;
				short num2 = num;
				num = (short)937094843;
				short num3 = num;
				num = (short)921300667;
				switch (num3 == num)
				{
				}
				num = (short)2050097153;
				if (num != 0)
				{
				}
				num = (short)602406912;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonBCO_A19745.Editable;
			}
			set
			{
				short num = (short)1329725440;
				short num2 = num;
				num = (short)409796609;
				if (num != 0)
				{
				}
				num = (short)1551416924;
				short num3 = num;
				num = (short)1248312924;
				switch (num3 == num)
				{
				}
				num = (short)2001076224;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMButtonBCO_A19745.Editable = value;
			}
		}

		// Token: 0x17003FE3 RID: 16355
		// (get) Token: 0x06007CBF RID: 31935 RVA: 0x00725C98 File Offset: 0x00723E98
		internal string RadErgoCfgKMTrunkingKMButtonBCO_A19745_UILabel
		{
			get
			{
				short num = (short)1980497920;
				short num2 = num;
				num = (short)1545076737;
				if (num != 0)
				{
				}
				num = (short)806962077;
				short num3 = num;
				num = (short)958350237;
				switch (num3 == num)
				{
				}
				num = (short)1204486144;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonBCO_A19745.UIName;
			}
		}

		// Token: 0x17003FE4 RID: 16356
		// (get) Token: 0x06007CC0 RID: 31936 RVA: 0x00725D48 File Offset: 0x00723F48
		// (set) Token: 0x06007CC1 RID: 31937 RVA: 0x00725DF8 File Offset: 0x00723FF8
		internal bool RadErgoCfgKMTrunkingKMButtonBCO_A19745_HiddenStatic
		{
			get
			{
				short num = (short)725549056;
				short num2 = num;
				num = (short)1261217926;
				short num3 = num;
				num = (short)1249552518;
				switch (num3 == num)
				{
				}
				num = (short)1966211072;
				if (num != 0)
				{
				}
				num = (short)904724481;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonBCO_A19745.HiddenStatic;
			}
			set
			{
				short num = (short)808452096;
				short num2 = num;
				num = (short)2015987147;
				short num3 = num;
				num = (short)224953803;
				switch (num3 == num)
				{
				}
				num = (short)46727169;
				if (num != 0)
				{
				}
				num = (short)1445134336;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMButtonBCO_A19745.HiddenStatic = value;
			}
		}

		// Token: 0x17003FE5 RID: 16357
		// (get) Token: 0x06007CC2 RID: 31938 RVA: 0x00725EB0 File Offset: 0x007240B0
		// (set) Token: 0x06007CC3 RID: 31939 RVA: 0x00725F64 File Offset: 0x00724164
		internal bool RadErgoCfgKMTrunkingKMButtonBCO_A19745_HiddenDynamic
		{
			get
			{
				short num = (short)7208960;
				short num2 = num;
				num = (short)1289044298;
				short num3 = num;
				num = (short)1065632074;
				switch (num3 == num)
				{
				}
				num = (short)1913323521;
				if (num != 0)
				{
				}
				num = (short)2106523648;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonBCO_A19745.HiddenDynamic;
			}
			set
			{
				short num = (short)1970536448;
				short num2 = num;
				num = (short)1654948970;
				short num3 = num;
				num = (short)221414506;
				switch (num3 == num)
				{
				}
				num = (short)1376452609;
				if (num != 0)
				{
				}
				num = (short)2129199104;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMButtonBCO_A19745.HiddenDynamic = value;
			}
		}

		// Token: 0x17003FE6 RID: 16358
		// (get) Token: 0x06007CC4 RID: 31940 RVA: 0x00726018 File Offset: 0x00724218
		public bool RadErgoCfgKMTrunkingKMButtonBCO_A19745_HasDiffs
		{
			get
			{
				short num = (short)582746112;
				short num2 = num;
				num = (short)372570661;
				short num3 = num;
				num = (short)1889139237;
				switch (num3 == num)
				{
				}
				num = (short)1106051073;
				if (num != 0)
				{
				}
				num = (short)1360330752;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonBCO_A19745._HasDiffs;
			}
		}

		// Token: 0x17003FE7 RID: 16359
		// (get) Token: 0x06007CC5 RID: 31941 RVA: 0x007260CC File Offset: 0x007242CC
		// (set) Token: 0x06007CC6 RID: 31942 RVA: 0x00726180 File Offset: 0x00724380
		public int RadErgoCfgKMTrunkingKMButtonFeature_A19746Value
		{
			get
			{
				short num = (short)1194786816;
				short num2 = num;
				num = (short)536311799;
				short num3 = num;
				num = (short)974616567;
				switch (num3 == num)
				{
				}
				num = (short)456327168;
				if (num != 0)
				{
				}
				num = (short)1333723137;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonFeature_A19746.Value;
			}
			set
			{
				short num = (short)1203044352;
				short num2 = num;
				num = (short)1153382317;
				short num3 = num;
				num = (short)1944139693;
				switch (num3 == num)
				{
				}
				num = (short)1293942785;
				if (num != 0)
				{
				}
				num = (short)1256652800;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMButtonFeature_A19746.Value = value;
			}
		}

		// Token: 0x17003FE8 RID: 16360
		// (get) Token: 0x06007CC7 RID: 31943 RVA: 0x00726234 File Offset: 0x00724434
		// (set) Token: 0x06007CC8 RID: 31944 RVA: 0x007262EC File Offset: 0x007244EC
		public string RadErgoCfgKMTrunkingKMButtonFeature_A19746_UIValue
		{
			get
			{
				short num = (short)391380992;
				short num2 = num;
				num = (short)1813515453;
				short num3 = num;
				num = (short)1311050941;
				switch (num3 == num)
				{
				}
				num = (short)3801089;
				if (num != 0)
				{
				}
				num = (short)829489152;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonFeature_A19746.UIValue;
			}
			set
			{
				short num = (short)358285312;
				short num2 = num;
				num = (short)732687288;
				short num3 = num;
				num = (short)1715596216;
				switch (num3 == num)
				{
				}
				num = (short)1872101377;
				if (num != 0)
				{
				}
				num = (short)1032060928;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMButtonFeature_A19746.UIValue = value;
			}
		}

		// Token: 0x17003FE9 RID: 16361
		// (get) Token: 0x06007CC9 RID: 31945 RVA: 0x007263A0 File Offset: 0x007245A0
		public global::AcpBusinessLayer.AcpListField RadErgoCfgKMTrunkingKMButtonFeature_A19746
		{
			get
			{
				short num = (short)1053491200;
				short num2 = num;
				num = (short)1528561665;
				if (num != 0)
				{
				}
				num = (short)1276158428;
				short num3 = num;
				num = (short)663593436;
				switch (num3 == num)
				{
				}
				num = (short)232456192;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonFeature_A19746;
			}
		}

		// Token: 0x17003FEA RID: 16362
		// (get) Token: 0x06007CCA RID: 31946 RVA: 0x00726454 File Offset: 0x00724654
		// (set) Token: 0x06007CCB RID: 31947 RVA: 0x00726508 File Offset: 0x00724708
		public bool RadErgoCfgKMTrunkingKMButtonFeature_A19746_Applicable
		{
			get
			{
				short num = (short)828469268;
				short num2 = num;
				num = (short)194342932;
				switch (num2 == num)
				{
				default:
				{
					num = (short)133103616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1758724096;
				if (num != 0)
				{
				}
				num = (short)2018967553;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonFeature_A19746.Applicable;
			}
			set
			{
				short num = (short)683493493;
				short num2 = num;
				num = (short)1698056309;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1772355584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)72744961;
				if (num != 0)
				{
				}
				num = (short)1612185600;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMButtonFeature_A19746.Applicable = value;
			}
		}

		// Token: 0x17003FEB RID: 16363
		// (get) Token: 0x06007CCC RID: 31948 RVA: 0x007265BC File Offset: 0x007247BC
		// (set) Token: 0x06007CCD RID: 31949 RVA: 0x00726670 File Offset: 0x00724870
		public bool RadErgoCfgKMTrunkingKMButtonFeature_A19746_Valid
		{
			get
			{
				short num = (short)87452640;
				short num2 = num;
				num = (short)48458720;
				switch (num2 == num)
				{
				default:
				{
					num = (short)315228160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1529413633;
				if (num != 0)
				{
				}
				num = (short)112394240;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonFeature_A19746.Valid;
			}
			set
			{
				short num = (short)1360166745;
				short num2 = num;
				num = (short)1459388249;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2029125632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1028521985;
				if (num != 0)
				{
				}
				num = (short)1455161344;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMButtonFeature_A19746.Valid = value;
			}
		}

		// Token: 0x17003FEC RID: 16364
		// (get) Token: 0x06007CCE RID: 31950 RVA: 0x00726724 File Offset: 0x00724924
		// (set) Token: 0x06007CCF RID: 31951 RVA: 0x007267DC File Offset: 0x007249DC
		public bool RadErgoCfgKMTrunkingKMButtonFeature_A19746_Visible
		{
			get
			{
				short num = (short)1680444196;
				short num2 = num;
				num = (short)189696804;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1237450752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)347865089;
				if (num != 0)
				{
				}
				num = (short)655556608;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonFeature_A19746.Visible;
			}
			set
			{
				short num = (short)1828519937;
				if (num != 0)
				{
				}
				num = (short)763887616;
				short num2 = num;
				num = (short)34447534;
				short num3 = num;
				num = (short)1637785774;
				switch (num3 == num)
				{
				}
				num = (short)2132738048;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMButtonFeature_A19746.Visible = value;
			}
		}

		// Token: 0x17003FED RID: 16365
		// (get) Token: 0x06007CD0 RID: 31952 RVA: 0x00726894 File Offset: 0x00724A94
		// (set) Token: 0x06007CD1 RID: 31953 RVA: 0x0072694C File Offset: 0x00724B4C
		public bool RadErgoCfgKMTrunkingKMButtonFeature_A19746_Editable
		{
			get
			{
				short num = (short)802086988;
				short num2 = num;
				num = (short)1834672204;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1933443072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)661848065;
				if (num != 0)
				{
				}
				num = (short)1212612608;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonFeature_A19746.Editable;
			}
			set
			{
				short num = (short)409851053;
				short num2 = num;
				num = (short)411751597;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2100625408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1287847937;
				if (num != 0)
				{
				}
				num = (short)132841472;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMButtonFeature_A19746.Editable = value;
			}
		}

		// Token: 0x17003FEE RID: 16366
		// (get) Token: 0x06007CD2 RID: 31954 RVA: 0x00726A04 File Offset: 0x00724C04
		internal string RadErgoCfgKMTrunkingKMButtonFeature_A19746_UILabel
		{
			get
			{
				short num = (short)62127576;
				short num2 = num;
				num = (short)1564999128;
				switch (num2 == num)
				{
				default:
				{
					num = (short)766246912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)179372033;
				if (num != 0)
				{
				}
				num = (short)975568896;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonFeature_A19746.UIName;
			}
		}

		// Token: 0x17003FEF RID: 16367
		// (get) Token: 0x06007CD3 RID: 31955 RVA: 0x00726AB8 File Offset: 0x00724CB8
		// (set) Token: 0x06007CD4 RID: 31956 RVA: 0x00726B6C File Offset: 0x00724D6C
		internal bool RadErgoCfgKMTrunkingKMButtonFeature_A19746_HiddenStatic
		{
			get
			{
				short num = (short)1179349589;
				short num2 = num;
				num = (short)1727689301;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1345650688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1040515073;
				if (num != 0)
				{
				}
				num = (short)685309952;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic;
			}
			set
			{
				short num = (short)1528430593;
				if (num != 0)
				{
				}
				num = (short)397017088;
				short num2 = num;
				num = (short)1552015960;
				short num3 = num;
				num = (short)1763828312;
				switch (num3 == num)
				{
				}
				num = (short)1645608960;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic = value;
			}
		}

		// Token: 0x17003FF0 RID: 16368
		// (get) Token: 0x06007CD5 RID: 31957 RVA: 0x00726C24 File Offset: 0x00724E24
		// (set) Token: 0x06007CD6 RID: 31958 RVA: 0x00726CD8 File Offset: 0x00724ED8
		internal bool RadErgoCfgKMTrunkingKMButtonFeature_A19746_HiddenDynamic
		{
			get
			{
				short num = (short)1939075387;
				short num2 = num;
				num = (short)1413738811;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1250164736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)715063297;
				if (num != 0)
				{
				}
				num = (short)1002635264;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenDynamic;
			}
			set
			{
				short num = (short)979130563;
				short num2 = num;
				num = (short)863656131;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1626996736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)104202240;
				if (num != 0)
				{
				}
				num = (short)1968963585;
				if (num != 0)
				{
				}
				this.radErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenDynamic = value;
			}
		}

		// Token: 0x17003FF1 RID: 16369
		// (get) Token: 0x06007CD7 RID: 31959 RVA: 0x00726D90 File Offset: 0x00724F90
		public bool RadErgoCfgKMTrunkingKMButtonFeature_A19746_HasDiffs
		{
			get
			{
				short num = (short)1805975553;
				if (num != 0)
				{
				}
				num = (short)883163136;
				short num2 = num;
				num = (short)1807173529;
				short num3 = num;
				num = (short)3164057;
				switch (num3 == num)
				{
				}
				num = (short)478019584;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMTrunkingKMButtonFeature_A19746._HasDiffs;
			}
		}

		// Token: 0x17003FF2 RID: 16370
		// (get) Token: 0x06007CD8 RID: 31960 RVA: 0x00726E44 File Offset: 0x00725044
		// (set) Token: 0x06007CD9 RID: 31961 RVA: 0x00726EF8 File Offset: 0x007250F8
		public string RadErgoCfgKMButtonKey_A22560Value
		{
			get
			{
				short num = (short)607974328;
				short num2 = num;
				num = (short)1950872504;
				switch (num2 == num)
				{
				default:
				{
					num = (short)981925888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1864171521;
				if (num != 0)
				{
				}
				num = (short)1653080064;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonKey_A22560.Value;
			}
			set
			{
				short num = (short)1768751104;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1377404310;
						short num3 = num;
						num = (short)601195926;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1712324608;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_7A;
							}
							continue;
						}
						break;
					}
					case 1:
						goto IL_E6;
					case 2:
						this.radErgoCfgKMButtonKey_A22560.Value = value;
						num = (short)1275854849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7A:
					num = (short)1398603777;
					if (num != 0)
					{
					}
					if (string.IsNullOrEmpty(value.Trim()))
					{
						return;
					}
					num = (short)252903426;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E6:
				num = (short)2017787904;
				short num4 = num;
			}
		}

		// Token: 0x17003FF3 RID: 16371
		// (get) Token: 0x06007CDA RID: 31962 RVA: 0x00727018 File Offset: 0x00725218
		// (set) Token: 0x06007CDB RID: 31963 RVA: 0x007270D0 File Offset: 0x007252D0
		public string RadErgoCfgKMButtonKey_A22560_UIValue
		{
			get
			{
				short num = (short)1328393624;
				short num2 = num;
				num = (short)160738712;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1875640320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2132082688;
				if (num != 0)
				{
				}
				num = (short)236060673;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonKey_A22560.Value;
			}
			set
			{
				short num = (short)1189106954;
				short num2 = num;
				num = (short)1904891146;
				switch (num2 == num)
				{
				default:
				{
					num = (short)359530496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1685520385;
				if (num != 0)
				{
				}
				num = (short)396886016;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonKey_A22560.Value = value;
			}
		}

		// Token: 0x17003FF4 RID: 16372
		// (get) Token: 0x06007CDC RID: 31964 RVA: 0x00727188 File Offset: 0x00725388
		public global::AcpBusinessLayer.AcpKeyField RadErgoCfgKMButtonKey_A22560
		{
			get
			{
				short num = (short)1506031392;
				short num2 = num;
				num = (short)1009006368;
				switch (num2 == num)
				{
				default:
				{
					num = (short)108920832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)283115521;
				if (num != 0)
				{
				}
				num = (short)1201930240;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonKey_A22560;
			}
		}

		// Token: 0x17003FF5 RID: 16373
		// (get) Token: 0x06007CDD RID: 31965 RVA: 0x00727238 File Offset: 0x00725438
		// (set) Token: 0x06007CDE RID: 31966 RVA: 0x007272EC File Offset: 0x007254EC
		public bool RadErgoCfgKMButtonKey_A22560_Applicable
		{
			get
			{
				short num = (short)1819374102;
				short num2 = num;
				num = (short)2143842838;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1006436352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)587005952;
				if (num != 0)
				{
				}
				num = (short)1166344193;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonKey_A22560.Applicable;
			}
			set
			{
				short num = (short)1991203191;
				short num2 = num;
				num = (short)1666668919;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1146421248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1454243841;
				if (num != 0)
				{
				}
				num = (short)689766400;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonKey_A22560.Applicable = value;
			}
		}

		// Token: 0x17003FF6 RID: 16374
		// (get) Token: 0x06007CDF RID: 31967 RVA: 0x007273A0 File Offset: 0x007255A0
		// (set) Token: 0x06007CE0 RID: 31968 RVA: 0x00727458 File Offset: 0x00725658
		public bool RadErgoCfgKMButtonKey_A22560_Valid
		{
			get
			{
				short num = (short)1500417095;
				short num2 = num;
				num = (short)1212451911;
				switch (num2 == num)
				{
				default:
				{
					num = (short)473432064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)221773824;
				if (num != 0)
				{
				}
				num = (short)1359806465;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonKey_A22560.Valid;
			}
			set
			{
				short num = (short)590400570;
				short num2 = num;
				num = (short)1418710074;
				switch (num2 == num)
				{
				default:
				{
					num = (short)441319424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1266155521;
				if (num != 0)
				{
				}
				num = (short)131858432;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonKey_A22560.Valid = value;
			}
		}

		// Token: 0x17003FF7 RID: 16375
		// (get) Token: 0x06007CE1 RID: 31969 RVA: 0x00727510 File Offset: 0x00725710
		// (set) Token: 0x06007CE2 RID: 31970 RVA: 0x007275C8 File Offset: 0x007257C8
		public bool RadErgoCfgKMButtonKey_A22560_Visible
		{
			get
			{
				short num = (short)722020921;
				short num2 = num;
				num = (short)468003385;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1796210688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1519779840;
				if (num != 0)
				{
				}
				num = (short)604307457;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonKey_A22560.Visible;
			}
			set
			{
				short num = (short)1533931778;
				short num2 = num;
				num = (short)502198530;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1681719296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)163512321;
				if (num != 0)
				{
				}
				num = (short)30932992;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonKey_A22560.Visible = value;
			}
		}

		// Token: 0x17003FF8 RID: 16376
		// (get) Token: 0x06007CE3 RID: 31971 RVA: 0x0072767C File Offset: 0x0072587C
		// (set) Token: 0x06007CE4 RID: 31972 RVA: 0x00727734 File Offset: 0x00725934
		public bool RadErgoCfgKMButtonKey_A22560_Editable
		{
			get
			{
				short num = (short)1514117507;
				short num2 = num;
				num = (short)1172871555;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2135228416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)889651200;
				if (num != 0)
				{
				}
				num = (short)1371930625;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonKey_A22560.Editable;
			}
			set
			{
				short num = (short)749213624;
				short num2 = num;
				num = (short)1753880504;
				switch (num2 == num)
				{
				}
				num = (short)1960640512;
				if (num != 0)
				{
				}
				num = (short)1970929664;
				short num3 = num;
				num = (short)750649345;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonKey_A22560.Editable = value;
			}
		}

		// Token: 0x17003FF9 RID: 16377
		// (get) Token: 0x06007CE5 RID: 31973 RVA: 0x007277E8 File Offset: 0x007259E8
		internal string RadErgoCfgKMButtonKey_A22560_UILabel
		{
			get
			{
				short num = (short)1786645659;
				short num2 = num;
				num = (short)305728667;
				switch (num2 == num)
				{
				}
				num = (short)1467088897;
				if (num != 0)
				{
				}
				num = (short)183500800;
				short num3 = num;
				num = (short)1883504640;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonKey_A22560.UIName;
			}
		}

		// Token: 0x17003FFA RID: 16378
		// (get) Token: 0x06007CE6 RID: 31974 RVA: 0x0072789C File Offset: 0x00725A9C
		// (set) Token: 0x06007CE7 RID: 31975 RVA: 0x00727950 File Offset: 0x00725B50
		internal bool RadErgoCfgKMButtonKey_A22560_HiddenStatic
		{
			get
			{
				short num = (short)2038030065;
				short num2 = num;
				num = (short)1252122353;
				switch (num2 == num)
				{
				}
				num = (short)1450049537;
				if (num != 0)
				{
				}
				num = (short)801374208;
				short num3 = num;
				num = (short)1101004800;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonKey_A22560.HiddenStatic;
			}
			set
			{
				short num = (short)111374667;
				short num2 = num;
				num = (short)1260286283;
				switch (num2 == num)
				{
				}
				num = (short)981729280;
				if (num != 0)
				{
				}
				num = (short)1880489984;
				short num3 = num;
				num = (short)1800798209;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonKey_A22560.HiddenStatic = value;
			}
		}

		// Token: 0x17003FFB RID: 16379
		// (get) Token: 0x06007CE8 RID: 31976 RVA: 0x00727A04 File Offset: 0x00725C04
		// (set) Token: 0x06007CE9 RID: 31977 RVA: 0x00727ABC File Offset: 0x00725CBC
		internal bool RadErgoCfgKMButtonKey_A22560_HiddenDynamic
		{
			get
			{
				short num = (short)1865744385;
				if (num != 0)
				{
				}
				num = (short)148625585;
				short num2 = num;
				num = (short)288938161;
				switch (num2 == num)
				{
				}
				num = (short)1521876992;
				short num3 = num;
				num = (short)2011758592;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonKey_A22560.HiddenDynamic;
			}
			set
			{
				short num = (short)149611907;
				short num2 = num;
				num = (short)277603715;
				switch (num2 == num)
				{
				}
				num = (short)445972481;
				if (num != 0)
				{
				}
				num = (short)1823080448;
				short num3 = num;
				num = (short)883097600;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonKey_A22560.HiddenDynamic = value;
			}
		}

		// Token: 0x17003FFC RID: 16380
		// (get) Token: 0x06007CEA RID: 31978 RVA: 0x00727B70 File Offset: 0x00725D70
		public bool RadErgoCfgKMButtonKey_A22560_HasDiffs
		{
			get
			{
				short num = (short)544627447;
				short num2 = num;
				num = (short)1475762935;
				switch (num2 == num)
				{
				}
				num = (short)1663041537;
				if (num != 0)
				{
				}
				num = (short)1885077504;
				short num3 = num;
				num = (short)1234305024;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonKey_A22560._HasDiffs;
			}
		}

		// Token: 0x17003FFD RID: 16381
		// (get) Token: 0x06007CEB RID: 31979 RVA: 0x00727C24 File Offset: 0x00725E24
		// (set) Token: 0x06007CEC RID: 31980 RVA: 0x00727CD8 File Offset: 0x00725ED8
		public string RadErgoCfgKMButtonName_A22561Value
		{
			get
			{
				short num = (short)1974633273;
				short num2 = num;
				num = (short)1559790393;
				switch (num2 == num)
				{
				}
				num = (short)798949377;
				if (num != 0)
				{
				}
				num = (short)541065216;
				short num3 = num;
				num = (short)104529920;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonName_A22561.Value;
			}
			set
			{
				short num = (short)188632837;
				short num2 = num;
				num = (short)1387941637;
				switch (num2 == num)
				{
				}
				num = (short)1707802625;
				if (num != 0)
				{
				}
				num = (short)1193410560;
				short num3 = num;
				num = (short)1849819136;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonName_A22561.Value = value;
			}
		}

		// Token: 0x17003FFE RID: 16382
		// (get) Token: 0x06007CED RID: 31981 RVA: 0x00727D90 File Offset: 0x00725F90
		public global::AcpBusinessLayer.AcpField<string> RadErgoCfgKMButtonName_A22561
		{
			get
			{
				short num = (short)644075627;
				short num2 = num;
				num = (short)979882091;
				switch (num2 == num)
				{
				}
				num = (short)68222976;
				if (num != 0)
				{
				}
				num = (short)818806784;
				short num3 = num;
				num = (short)1044447233;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonName_A22561;
			}
		}

		// Token: 0x17003FFF RID: 16383
		// (get) Token: 0x06007CEE RID: 31982 RVA: 0x00727E40 File Offset: 0x00726040
		// (set) Token: 0x06007CEF RID: 31983 RVA: 0x00727EF4 File Offset: 0x007260F4
		public string RadErgoCfgKMButtonName_A22561_UIValue
		{
			get
			{
				short num = (short)683475310;
				short num2 = num;
				num = (short)271450478;
				switch (num2 == num)
				{
				}
				num = (short)382795777;
				if (num != 0)
				{
				}
				num = (short)1273102336;
				short num3 = num;
				num = (short)975765504;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonName_A22561.Value;
			}
			set
			{
				short num = (short)45234927;
				short num2 = num;
				num = (short)1970158319;
				switch (num2 == num)
				{
				}
				num = (short)1760886785;
				if (num != 0)
				{
				}
				num = (short)1151795200;
				short num3 = num;
				num = (short)916389888;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonName_A22561.Value = value;
			}
		}

		// Token: 0x17004000 RID: 16384
		// (get) Token: 0x06007CF0 RID: 31984 RVA: 0x00727FAC File Offset: 0x007261AC
		// (set) Token: 0x06007CF1 RID: 31985 RVA: 0x00728064 File Offset: 0x00726264
		public bool RadErgoCfgKMButtonName_A22561_Applicable
		{
			get
			{
				short num = (short)1156061431;
				short num2 = num;
				num = (short)2071664887;
				switch (num2 == num)
				{
				}
				num = (short)759824384;
				if (num != 0)
				{
				}
				num = (short)1569456128;
				short num3 = num;
				num = (short)1591803905;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonName_A22561.Applicable;
			}
			set
			{
				short num = (short)1569594397;
				short num2 = num;
				num = (short)621878301;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1061945344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1101922305;
				if (num != 0)
				{
				}
				num = (short)27459584;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonName_A22561.Applicable = value;
			}
		}

		// Token: 0x17004001 RID: 16385
		// (get) Token: 0x06007CF2 RID: 31986 RVA: 0x0072811C File Offset: 0x0072631C
		// (set) Token: 0x06007CF3 RID: 31987 RVA: 0x007281D4 File Offset: 0x007263D4
		public bool RadErgoCfgKMButtonName_A22561_Valid
		{
			get
			{
				short num = (short)1130233857;
				if (num != 0)
				{
				}
				num = (short)1232535552;
				short num2 = num;
				num = (short)1551386038;
				short num3 = num;
				num = (short)614221238;
				switch (num3 == num)
				{
				}
				num = (short)1149763584;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonName_A22561.Valid;
			}
			set
			{
				short num = (short)1977957005;
				short num2 = num;
				num = (short)547240589;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1955725312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)785907713;
				if (num != 0)
				{
				}
				num = (short)321847296;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonName_A22561.Valid = value;
			}
		}

		// Token: 0x17004002 RID: 16386
		// (get) Token: 0x06007CF4 RID: 31988 RVA: 0x0072828C File Offset: 0x0072648C
		// (set) Token: 0x06007CF5 RID: 31989 RVA: 0x00728344 File Offset: 0x00726544
		public bool RadErgoCfgKMButtonName_A22561_Visible
		{
			get
			{
				short num = (short)28766434;
				short num2 = num;
				num = (short)1233383650;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1993932800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1372782593;
				if (num != 0)
				{
				}
				num = (short)632291328;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonName_A22561.Visible;
			}
			set
			{
				short num = (short)756108295;
				short num2 = num;
				num = (short)786844679;
				switch (num2 == num)
				{
				default:
				{
					num = (short)970457088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)696516609;
				if (num != 0)
				{
				}
				num = (short)73138176;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonName_A22561.Visible = value;
			}
		}

		// Token: 0x17004003 RID: 16387
		// (get) Token: 0x06007CF6 RID: 31990 RVA: 0x007283F8 File Offset: 0x007265F8
		// (set) Token: 0x06007CF7 RID: 31991 RVA: 0x007284AC File Offset: 0x007266AC
		public bool RadErgoCfgKMButtonName_A22561_Editable
		{
			get
			{
				short num = (short)1842962757;
				short num2 = num;
				num = (short)1854038341;
				switch (num2 == num)
				{
				default:
				{
					num = (short)277282816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)704643072;
				if (num != 0)
				{
				}
				num = (short)591855617;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonName_A22561.Editable;
			}
			set
			{
				short num = (short)738965323;
				short num2 = num;
				num = (short)695056203;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1249705984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1968570369;
				if (num != 0)
				{
				}
				num = (short)14155776;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonName_A22561.Editable = value;
			}
		}

		// Token: 0x17004004 RID: 16388
		// (get) Token: 0x06007CF8 RID: 31992 RVA: 0x00728564 File Offset: 0x00726764
		internal string RadErgoCfgKMButtonName_A22561_UILabel
		{
			get
			{
				short num = (short)696986887;
				short num2 = num;
				num = (short)73739527;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1240465408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)145162241;
				if (num != 0)
				{
				}
				num = (short)557645824;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonName_A22561.UIName;
			}
		}

		// Token: 0x17004005 RID: 16389
		// (get) Token: 0x06007CF9 RID: 31993 RVA: 0x00728618 File Offset: 0x00726818
		// (set) Token: 0x06007CFA RID: 31994 RVA: 0x007286CC File Offset: 0x007268CC
		internal bool RadErgoCfgKMButtonName_A22561_HiddenStatic
		{
			get
			{
				short num = (short)282851760;
				short num2 = num;
				num = (short)891812272;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1201209344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2132279297;
				if (num != 0)
				{
				}
				num = (short)1792278528;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonName_A22561.HiddenStatic;
			}
			set
			{
				short num = (short)1205637298;
				short num2 = num;
				num = (short)279154866;
				switch (num2 == num)
				{
				default:
				{
					num = (short)361955328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1203830785;
				if (num != 0)
				{
				}
				num = (short)1933049856;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonName_A22561.HiddenStatic = value;
			}
		}

		// Token: 0x17004006 RID: 16390
		// (get) Token: 0x06007CFB RID: 31995 RVA: 0x00728780 File Offset: 0x00726980
		// (set) Token: 0x06007CFC RID: 31996 RVA: 0x00728838 File Offset: 0x00726A38
		internal bool RadErgoCfgKMButtonName_A22561_HiddenDynamic
		{
			get
			{
				short num = (short)1497986190;
				short num2 = num;
				num = (short)1206744206;
				switch (num2 == num)
				{
				default:
				{
					num = (short)330629120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1701052416;
				if (num != 0)
				{
				}
				num = (short)1918959617;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonName_A22561.HiddenDynamic;
			}
			set
			{
				short num = (short)1752943199;
				short num2 = num;
				num = (short)658033247;
				switch (num2 == num)
				{
				default:
				{
					num = (short)159973376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1173618688;
				if (num != 0)
				{
				}
				num = (short)566820865;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonName_A22561.HiddenDynamic = value;
			}
		}

		// Token: 0x17004007 RID: 16391
		// (get) Token: 0x06007CFD RID: 31997 RVA: 0x007288E8 File Offset: 0x00726AE8
		public bool RadErgoCfgKMButtonName_A22561_HasDiffs
		{
			get
			{
				short num = (short)1876484771;
				short num2 = num;
				num = (short)250667683;
				switch (num2 == num)
				{
				default:
				{
					num = (short)359858176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)980287488;
				if (num != 0)
				{
				}
				num = (short)1620574209;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonName_A22561._HasDiffs;
			}
		}

		// Token: 0x17004008 RID: 16392
		// (get) Token: 0x06007CFE RID: 31998 RVA: 0x0072899C File Offset: 0x00726B9C
		// (set) Token: 0x06007CFF RID: 31999 RVA: 0x00728A4C File Offset: 0x00726C4C
		public int RadErgoCfgKMButtonShortPressTimeValue
		{
			get
			{
				short num = (short)404739484;
				short num2 = num;
				num = (short)1353831836;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1117454336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1995702272;
				if (num != 0)
				{
				}
				num = (short)607125505;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonShortPressTime.Value;
			}
			set
			{
				short num = (short)917731746;
				short num2 = num;
				num = (short)1568504226;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1835991040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2115371008;
				if (num != 0)
				{
				}
				num = (short)1911291905;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonShortPressTime.Value = value;
			}
		}

		// Token: 0x17004009 RID: 16393
		// (get) Token: 0x06007D00 RID: 32000 RVA: 0x00728B00 File Offset: 0x00726D00
		// (set) Token: 0x06007D01 RID: 32001 RVA: 0x00728BB4 File Offset: 0x00726DB4
		public string RadErgoCfgKMButtonShortPressTime_UIValue
		{
			get
			{
				short num = (short)1818249316;
				short num2 = num;
				num = (short)298731620;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1187708928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)561184768;
				if (num != 0)
				{
				}
				num = (short)1588527105;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonShortPressTime.UIValue;
			}
			set
			{
				short num = (short)280421325;
				short num2 = num;
				num = (short)42132429;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1563164672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1168048128;
				if (num != 0)
				{
				}
				num = (short)2091515905;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonShortPressTime.UIValue = value;
			}
		}

		// Token: 0x1700400A RID: 16394
		// (get) Token: 0x06007D02 RID: 32002 RVA: 0x00728C6C File Offset: 0x00726E6C
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgKMButtonShortPressTime
		{
			get
			{
				short num = (short)201555003;
				short num2 = num;
				num = (short)262896699;
				switch (num2 == num)
				{
				default:
				{
					num = (short)139329536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)104923136;
				if (num != 0)
				{
				}
				num = (short)1670578177;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonShortPressTime;
			}
		}

		// Token: 0x1700400B RID: 16395
		// (get) Token: 0x06007D03 RID: 32003 RVA: 0x00728D1C File Offset: 0x00726F1C
		// (set) Token: 0x06007D04 RID: 32004 RVA: 0x00728DD4 File Offset: 0x00726FD4
		internal int RadErgoCfgKMButtonShortPressTimeMin
		{
			get
			{
				short num = (short)307446182;
				short num2 = num;
				num = (short)1007370662;
				switch (num2 == num)
				{
				default:
				{
					num = (short)737148928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)537853953;
				if (num != 0)
				{
				}
				num = (short)419168256;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonShortPressTime.Min;
			}
			set
			{
				short num = (short)1781567062;
				short num2 = num;
				num = (short)1883737686;
				switch (num2 == num)
				{
				default:
				{
					num = (short)504168448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1950023680;
				if (num != 0)
				{
				}
				num = (short)630456321;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonShortPressTime.Min = value;
			}
		}

		// Token: 0x1700400C RID: 16396
		// (get) Token: 0x06007D05 RID: 32005 RVA: 0x00728E88 File Offset: 0x00727088
		// (set) Token: 0x06007D06 RID: 32006 RVA: 0x00728F3C File Offset: 0x0072713C
		internal int RadErgoCfgKMButtonShortPressTimeMax
		{
			get
			{
				short num = (short)548467105;
				short num2 = num;
				num = (short)1420161441;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1799815168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1263271936;
				if (num != 0)
				{
				}
				num = (short)1769996289;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonShortPressTime.Max;
			}
			set
			{
				short num = (short)289341441;
				if (num != 0)
				{
				}
				num = (short)1868890112;
				short num2 = num;
				num = (short)1894287606;
				short num3 = num;
				num = (short)1622575350;
				switch (num3 == num)
				{
				}
				num = (short)1968701440;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonShortPressTime.Max = value;
			}
		}

		// Token: 0x1700400D RID: 16397
		// (get) Token: 0x06007D07 RID: 32007 RVA: 0x00728FF8 File Offset: 0x007271F8
		// (set) Token: 0x06007D08 RID: 32008 RVA: 0x007290AC File Offset: 0x007272AC
		internal int RadErgoCfgKMButtonShortPressTimeStep
		{
			get
			{
				short num = (short)1408368641;
				if (num != 0)
				{
				}
				num = (short)1387331584;
				short num2 = num;
				num = (short)1634653104;
				short num3 = num;
				num = (short)1461375920;
				switch (num3 == num)
				{
				}
				num = (short)197394432;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonShortPressTime.StepSize;
			}
			set
			{
				short num = (short)392167425;
				if (num != 0)
				{
				}
				num = (short)1686306816;
				short num2 = num;
				num = (short)1010169276;
				short num3 = num;
				num = (short)2094134716;
				switch (num3 == num)
				{
				}
				num = (short)620756992;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonShortPressTime.StepSize = value;
			}
		}

		// Token: 0x1700400E RID: 16398
		// (get) Token: 0x06007D09 RID: 32009 RVA: 0x00729160 File Offset: 0x00727360
		// (set) Token: 0x06007D0A RID: 32010 RVA: 0x00729218 File Offset: 0x00727418
		public bool RadErgoCfgKMButtonShortPressTime_Applicable
		{
			get
			{
				short num = (short)983141517;
				short num2 = num;
				num = (short)416451725;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1955397632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1127677953;
				if (num != 0)
				{
				}
				num = (short)1958477824;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonShortPressTime.Applicable;
			}
			set
			{
				short num = (short)568826275;
				short num2 = num;
				num = (short)1247975843;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1423376384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)873070593;
				if (num != 0)
				{
				}
				num = (short)1289093120;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonShortPressTime.Applicable = value;
			}
		}

		// Token: 0x1700400F RID: 16399
		// (get) Token: 0x06007D0B RID: 32011 RVA: 0x007292D0 File Offset: 0x007274D0
		// (set) Token: 0x06007D0C RID: 32012 RVA: 0x00729384 File Offset: 0x00727584
		public bool RadErgoCfgKMButtonShortPressTime_Valid
		{
			get
			{
				short num = (short)1819606229;
				short num2 = num;
				num = (short)1936129237;
				switch (num2 == num)
				{
				default:
				{
					num = (short)784334848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1425473536;
				if (num != 0)
				{
				}
				num = (short)313589761;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonShortPressTime.Valid;
			}
			set
			{
				short num = (short)693698561;
				if (num != 0)
				{
				}
				num = (short)2134742596;
				short num2 = num;
				num = (short)1858311748;
				switch (num2 == num)
				{
				}
				num = (short)673120256;
				short num3 = num;
				num = (short)1582104576;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonShortPressTime.Valid = value;
			}
		}

		// Token: 0x17004010 RID: 16400
		// (get) Token: 0x06007D0D RID: 32013 RVA: 0x0072943C File Offset: 0x0072763C
		// (set) Token: 0x06007D0E RID: 32014 RVA: 0x007294F0 File Offset: 0x007276F0
		public bool RadErgoCfgKMButtonShortPressTime_Visible
		{
			get
			{
				short num = (short)1674565002;
				short num2 = num;
				num = (short)1690621322;
				switch (num2 == num)
				{
				}
				num = (short)142934016;
				if (num != 0)
				{
				}
				num = (short)886177792;
				short num3 = num;
				num = (short)698155009;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonShortPressTime.Visible;
			}
			set
			{
				short num = (short)287897748;
				short num2 = num;
				num = (short)27261076;
				switch (num2 == num)
				{
				}
				num = (short)1211826176;
				if (num != 0)
				{
				}
				num = (short)2048851968;
				short num3 = num;
				num = (short)96993281;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonShortPressTime.Visible = value;
			}
		}

		// Token: 0x17004011 RID: 16401
		// (get) Token: 0x06007D0F RID: 32015 RVA: 0x007295A4 File Offset: 0x007277A4
		// (set) Token: 0x06007D10 RID: 32016 RVA: 0x00729658 File Offset: 0x00727858
		public bool RadErgoCfgKMButtonShortPressTime_Editable
		{
			get
			{
				short num = (short)1100096332;
				short num2 = num;
				num = (short)83370828;
				switch (num2 == num)
				{
				}
				num = (short)1483603969;
				if (num != 0)
				{
				}
				num = (short)1145962496;
				short num3 = num;
				num = (short)1184235520;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonShortPressTime.Editable;
			}
			set
			{
				short num = (short)1927054375;
				short num2 = num;
				num = (short)109478951;
				switch (num2 == num)
				{
				}
				num = (short)548601856;
				if (num != 0)
				{
				}
				num = (short)1879834624;
				short num3 = num;
				num = (short)1072103425;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonShortPressTime.Editable = value;
			}
		}

		// Token: 0x17004012 RID: 16402
		// (get) Token: 0x06007D11 RID: 32017 RVA: 0x0072970C File Offset: 0x0072790C
		internal string RadErgoCfgKMButtonShortPressTime_UILabel
		{
			get
			{
				short num = (short)1955033768;
				short num2 = num;
				num = (short)2041737896;
				switch (num2 == num)
				{
				}
				num = (short)1393033216;
				if (num != 0)
				{
				}
				num = (short)1402535936;
				short num3 = num;
				num = (short)1479933953;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonShortPressTime.UIName;
			}
		}

		// Token: 0x17004013 RID: 16403
		// (get) Token: 0x06007D12 RID: 32018 RVA: 0x007297C0 File Offset: 0x007279C0
		// (set) Token: 0x06007D13 RID: 32019 RVA: 0x00729874 File Offset: 0x00727A74
		internal bool RadErgoCfgKMButtonShortPressTime_HiddenStatic
		{
			get
			{
				short num = (short)449199122;
				short num2 = num;
				num = (short)2009283602;
				switch (num2 == num)
				{
				}
				num = (short)2146500608;
				if (num != 0)
				{
				}
				num = (short)174915584;
				short num3 = num;
				num = (short)278659073;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonShortPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)930290435;
				short num2 = num;
				num = (short)1730878211;
				switch (num2 == num)
				{
				}
				num = (short)1719795712;
				if (num != 0)
				{
				}
				num = (short)764870656;
				short num3 = num;
				num = (short)1930231809;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonShortPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17004014 RID: 16404
		// (get) Token: 0x06007D14 RID: 32020 RVA: 0x00729928 File Offset: 0x00727B28
		// (set) Token: 0x06007D15 RID: 32021 RVA: 0x007299DC File Offset: 0x00727BDC
		internal bool RadErgoCfgKMButtonShortPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)146746463;
				short num2 = num;
				num = (short)677063775;
				switch (num2 == num)
				{
				}
				num = (short)1681588224;
				if (num != 0)
				{
				}
				num = (short)213647360;
				short num3 = num;
				num = (short)1944387585;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonShortPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)1630609130;
				short num2 = num;
				num = (short)1809915626;
				switch (num2 == num)
				{
				}
				num = (short)1040646145;
				if (num != 0)
				{
				}
				num = (short)1150091264;
				short num3 = num;
				num = (short)1685061632;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonShortPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17004015 RID: 16405
		// (get) Token: 0x06007D16 RID: 32022 RVA: 0x00729A90 File Offset: 0x00727C90
		public bool RadErgoCfgKMButtonShortPressTime_HasDiffs
		{
			get
			{
				short num = (short)191470436;
				short num2 = num;
				num = (short)1115069284;
				switch (num2 == num)
				{
				}
				num = (short)1146945537;
				if (num != 0)
				{
				}
				num = (short)1622867968;
				short num3 = num;
				num = (short)569704448;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonShortPressTime._HasDiffs;
			}
		}

		// Token: 0x17004016 RID: 16406
		// (get) Token: 0x06007D17 RID: 32023 RVA: 0x00729B44 File Offset: 0x00727D44
		// (set) Token: 0x06007D18 RID: 32024 RVA: 0x00729BFC File Offset: 0x00727DFC
		public int RadErgoCfgKMButtonLongPressTimeValue
		{
			get
			{
				short num = (short)1700167730;
				short num2 = num;
				num = (short)1280933938;
				switch (num2 == num)
				{
				}
				num = (short)592773121;
				if (num != 0)
				{
				}
				num = (short)409468928;
				short num3 = num;
				num = (short)37224448;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonLongPressTime.Value;
			}
			set
			{
				short num = (short)1548929268;
				short num2 = num;
				num = (short)471976180;
				switch (num2 == num)
				{
				}
				num = (short)960954368;
				if (num != 0)
				{
				}
				num = (short)900792320;
				short num3 = num;
				num = (short)1734737921;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonLongPressTime.Value = value;
			}
		}

		// Token: 0x17004017 RID: 16407
		// (get) Token: 0x06007D19 RID: 32025 RVA: 0x00729CB4 File Offset: 0x00727EB4
		// (set) Token: 0x06007D1A RID: 32026 RVA: 0x00729D6C File Offset: 0x00727F6C
		public string RadErgoCfgKMButtonLongPressTime_UIValue
		{
			get
			{
				short num = (short)1140865463;
				short num2 = num;
				num = (short)201210295;
				switch (num2 == num)
				{
				}
				num = (short)1781465089;
				if (num != 0)
				{
				}
				num = (short)513671168;
				short num3 = num;
				num = (short)72941568;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonLongPressTime.UIValue;
			}
			set
			{
				short num = (short)1992256635;
				short num2 = num;
				num = (short)1266314363;
				switch (num2 == num)
				{
				}
				num = (short)1034158081;
				if (num != 0)
				{
				}
				num = (short)2068971520;
				short num3 = num;
				num = (short)1406861312;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonLongPressTime.UIValue = value;
			}
		}

		// Token: 0x17004018 RID: 16408
		// (get) Token: 0x06007D1B RID: 32027 RVA: 0x00729E20 File Offset: 0x00728020
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgKMButtonLongPressTime
		{
			get
			{
				short num = (short)60300807;
				short num2 = num;
				num = (short)349052423;
				switch (num2 == num)
				{
				}
				num = (short)1300299777;
				if (num != 0)
				{
				}
				num = (short)2003435520;
				short num3 = num;
				num = (short)271777792;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonLongPressTime;
			}
		}

		// Token: 0x17004019 RID: 16409
		// (get) Token: 0x06007D1C RID: 32028 RVA: 0x00729ED0 File Offset: 0x007280D0
		// (set) Token: 0x06007D1D RID: 32029 RVA: 0x00729F84 File Offset: 0x00728184
		internal int RadErgoCfgKMButtonLongPressTimeMin
		{
			get
			{
				short num = (short)292060137;
				short num2 = num;
				num = (short)1225030633;
				switch (num2 == num)
				{
				}
				num = (short)1549860864;
				if (num != 0)
				{
				}
				num = (short)379518976;
				short num3 = num;
				num = (short)687865857;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonLongPressTime.Min;
			}
			set
			{
				short num = (short)2117036642;
				short num2 = num;
				num = (short)268135010;
				switch (num2 == num)
				{
				}
				num = (short)1555759104;
				if (num != 0)
				{
				}
				num = (short)1721040896;
				short num3 = num;
				num = (short)483983361;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonLongPressTime.Min = value;
			}
		}

		// Token: 0x1700401A RID: 16410
		// (get) Token: 0x06007D1E RID: 32030 RVA: 0x0072A038 File Offset: 0x00728238
		// (set) Token: 0x06007D1F RID: 32031 RVA: 0x0072A0EC File Offset: 0x007282EC
		internal int RadErgoCfgKMButtonLongPressTimeMax
		{
			get
			{
				short num = (short)1274652395;
				short num2 = num;
				num = (short)345024235;
				switch (num2 == num)
				{
				}
				num = (short)1237516289;
				if (num != 0)
				{
				}
				num = (short)1205010432;
				short num3 = num;
				num = (short)419889152;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonLongPressTime.Max;
			}
			set
			{
				short num = (short)1437791757;
				short num2 = num;
				num = (short)338556429;
				switch (num2 == num)
				{
				}
				num = (short)1942683649;
				if (num != 0)
				{
				}
				num = (short)1713700864;
				short num3 = num;
				num = (short)1694564352;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonLongPressTime.Max = value;
			}
		}

		// Token: 0x1700401B RID: 16411
		// (get) Token: 0x06007D20 RID: 32032 RVA: 0x0072A1A0 File Offset: 0x007283A0
		// (set) Token: 0x06007D21 RID: 32033 RVA: 0x0072A258 File Offset: 0x00728458
		internal int RadErgoCfgKMButtonLongPressTimeStep
		{
			get
			{
				short num = (short)1943998438;
				short num2 = num;
				num = (short)885133286;
				switch (num2 == num)
				{
				}
				num = (short)1502543873;
				if (num != 0)
				{
				}
				num = (short)942669824;
				short num3 = num;
				num = (short)332660736;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonLongPressTime.StepSize;
			}
			set
			{
				short num = (short)1585184768;
				short num2 = num;
				num = (short)2074534228;
				short num3 = num;
				num = (short)1992286548;
				switch (num3 == num)
				{
				}
				num = (short)778174465;
				if (num != 0)
				{
				}
				num = (short)750977024;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonLongPressTime.StepSize = value;
			}
		}

		// Token: 0x1700401C RID: 16412
		// (get) Token: 0x06007D22 RID: 32034 RVA: 0x0072A30C File Offset: 0x0072850C
		// (set) Token: 0x06007D23 RID: 32035 RVA: 0x0072A3C0 File Offset: 0x007285C0
		public bool RadErgoCfgKMButtonLongPressTime_Applicable
		{
			get
			{
				short num = (short)916324352;
				short num2 = num;
				num = (short)308755156;
				short num3 = num;
				num = (short)1797995220;
				switch (num3 == num)
				{
				}
				num = (short)1340866561;
				if (num != 0)
				{
				}
				num = (short)757596160;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonLongPressTime.Applicable;
			}
			set
			{
				short num = (short)1872822272;
				short num2 = num;
				num = (short)1125083959;
				short num3 = num;
				num = (short)1992911671;
				switch (num3 == num)
				{
				}
				num = (short)1042743297;
				if (num != 0)
				{
				}
				num = (short)567803904;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonLongPressTime.Applicable = value;
			}
		}

		// Token: 0x1700401D RID: 16413
		// (get) Token: 0x06007D24 RID: 32036 RVA: 0x0072A474 File Offset: 0x00728674
		// (set) Token: 0x06007D25 RID: 32037 RVA: 0x0072A528 File Offset: 0x00728728
		public bool RadErgoCfgKMButtonLongPressTime_Valid
		{
			get
			{
				short num = (short)1351548928;
				short num2 = num;
				num = (short)1605828609;
				if (num != 0)
				{
				}
				num = (short)1506300976;
				short num3 = num;
				num = (short)123622448;
				switch (num3 == num)
				{
				}
				num = (short)561184768;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonLongPressTime.Valid;
			}
			set
			{
				short num = (short)1838022656;
				short num2 = num;
				num = (short)1794293703;
				short num3 = num;
				num = (short)181059527;
				switch (num3 == num)
				{
				}
				num = (short)891551745;
				if (num != 0)
				{
				}
				num = (short)1568342016;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonLongPressTime.Valid = value;
			}
		}

		// Token: 0x1700401E RID: 16414
		// (get) Token: 0x06007D26 RID: 32038 RVA: 0x0072A5DC File Offset: 0x007287DC
		// (set) Token: 0x06007D27 RID: 32039 RVA: 0x0072A690 File Offset: 0x00728890
		public bool RadErgoCfgKMButtonLongPressTime_Visible
		{
			get
			{
				short num = (short)891027456;
				short num2 = num;
				num = (short)1014672537;
				short num3 = num;
				num = (short)913484953;
				switch (num3 == num)
				{
				}
				num = (short)697171969;
				if (num != 0)
				{
				}
				num = (short)530710528;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonLongPressTime.Visible;
			}
			set
			{
				short num = (short)2018246656;
				short num2 = num;
				num = (short)291710805;
				short num3 = num;
				num = (short)1043408725;
				switch (num3 == num)
				{
				}
				num = (short)407699456;
				if (num != 0)
				{
				}
				num = (short)634257409;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonLongPressTime.Visible = value;
			}
		}

		// Token: 0x1700401F RID: 16415
		// (get) Token: 0x06007D28 RID: 32040 RVA: 0x0072A748 File Offset: 0x00728948
		// (set) Token: 0x06007D29 RID: 32041 RVA: 0x0072A7FC File Offset: 0x007289FC
		public bool RadErgoCfgKMButtonLongPressTime_Editable
		{
			get
			{
				short num = (short)56098816;
				short num2 = num;
				num = (short)1554682662;
				short num3 = num;
				num = (short)1429836582;
				switch (num3 == num)
				{
				}
				num = (short)544407553;
				if (num != 0)
				{
				}
				num = (short)459079680;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonLongPressTime.Editable;
			}
			set
			{
				short num = (short)1394606080;
				short num2 = num;
				num = (short)148599301;
				short num3 = num;
				num = (short)1805349381;
				switch (num3 == num)
				{
				}
				num = (short)459800576;
				if (num != 0)
				{
				}
				num = (short)233832449;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonLongPressTime.Editable = value;
			}
		}

		// Token: 0x17004020 RID: 16416
		// (get) Token: 0x06007D2A RID: 32042 RVA: 0x0072A8B4 File Offset: 0x00728AB4
		internal string RadErgoCfgKMButtonLongPressTime_UILabel
		{
			get
			{
				short num = (short)1752694784;
				short num2 = num;
				num = (short)625820880;
				short num3 = num;
				num = (short)1468351696;
				switch (num3 == num)
				{
				}
				num = (short)452657153;
				if (num != 0)
				{
				}
				num = (short)1613889536;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonLongPressTime.UIName;
			}
		}

		// Token: 0x17004021 RID: 16417
		// (get) Token: 0x06007D2B RID: 32043 RVA: 0x0072A968 File Offset: 0x00728B68
		// (set) Token: 0x06007D2C RID: 32044 RVA: 0x0072AA1C File Offset: 0x00728C1C
		internal bool RadErgoCfgKMButtonLongPressTime_HiddenStatic
		{
			get
			{
				short num = (short)1432682496;
				short num2 = num;
				num = (short)1767859284;
				short num3 = num;
				num = (short)573727828;
				switch (num3 == num)
				{
				}
				num = (short)1098448896;
				if (num != 0)
				{
				}
				num = (short)652410881;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonLongPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)1558577152;
				short num2 = num;
				num = (short)110277220;
				short num3 = num;
				num = (short)927904356;
				switch (num3 == num)
				{
				}
				num = (short)1734672384;
				if (num != 0)
				{
				}
				num = (short)385286145;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonLongPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17004022 RID: 16418
		// (get) Token: 0x06007D2D RID: 32045 RVA: 0x0072AAD4 File Offset: 0x00728CD4
		// (set) Token: 0x06007D2E RID: 32046 RVA: 0x0072AB88 File Offset: 0x00728D88
		internal bool RadErgoCfgKMButtonLongPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)1569587200;
				short num2 = num;
				num = (short)570975343;
				short num3 = num;
				num = (short)1782539375;
				switch (num3 == num)
				{
				}
				num = (short)1916665857;
				if (num != 0)
				{
				}
				num = (short)280363008;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonLongPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)848429056;
				short num2 = num;
				num = (short)282403078;
				short num3 = num;
				num = (short)1668227334;
				switch (num3 == num)
				{
				}
				num = (short)1117126657;
				if (num != 0)
				{
				}
				num = (short)402128896;
				if (num != 0)
				{
				}
				this.radErgoCfgKMButtonLongPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17004023 RID: 16419
		// (get) Token: 0x06007D2F RID: 32047 RVA: 0x0072AC3C File Offset: 0x00728E3C
		public bool RadErgoCfgKMButtonLongPressTime_HasDiffs
		{
			get
			{
				short num = (short)572653568;
				short num2 = num;
				num = (short)1712412541;
				short num3 = num;
				num = (short)931092349;
				switch (num3 == num)
				{
				}
				num = (short)1720320000;
				if (num != 0)
				{
				}
				num = (short)537001985;
				if (num != 0)
				{
				}
				return this.radErgoCfgKMButtonLongPressTime._HasDiffs;
			}
		}

		// Token: 0x17004024 RID: 16420
		// (get) Token: 0x06007D30 RID: 32048 RVA: 0x0072ACF0 File Offset: 0x00728EF0
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)36306944;
				short num2 = num;
				num = (short)1944256795;
				short num3 = num;
				num = (short)294715675;
				switch (num3 == num)
				{
				}
				num = (short)1639448577;
				if (num != 0)
				{
				}
				num = (short)736165888;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x17004025 RID: 16421
		// (get) Token: 0x06007D31 RID: 32049 RVA: 0x0072ADB0 File Offset: 0x00728FB0
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)437321728;
				short num2 = num;
				num = (short)293666817;
				if (num != 0)
				{
				}
				num = (short)539520357;
				short num3 = num;
				num = (short)870215013;
				switch (num3 == num)
				{
				}
				num = (short)2128478208;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x06007D32 RID: 32050 RVA: 0x0072AE70 File Offset: 0x00729070
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						if (base.ParentRecset == null)
						{
							return result;
						}
						num2 = (short)489222246;
						short num3 = num2;
						num2 = (short)1637478502;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num2 = (short)778829824;
							if (num2 != 0)
							{
							}
							num2 = (short)295698432;
							short num4 = num2;
							num2 = (short)1516437507;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						return result;
					case 2:
						num2 = (short)1416822785;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1931673601;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						num2 = (short)955645956;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1140850690;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				IL_24:
				result = null;
				num2 = (short)1671692288;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x040037CF RID: 14287
		private global::AcpBusinessLayer.AcpListField radErgoCfgKMConventionalKMButtonBCO_A19643;

		// Token: 0x040037D0 RID: 14288
		private global::AcpBusinessLayer.AcpListField radErgoCfgKMConventionalKMButtonFeature_A19646;

		// Token: 0x040037D1 RID: 14289
		private global::AcpBusinessLayer.AcpListField radErgoCfgKMTrunkingKMButtonBCO_A19745;

		// Token: 0x040037D2 RID: 14290
		private global::AcpBusinessLayer.AcpListField radErgoCfgKMTrunkingKMButtonFeature_A19746;

		// Token: 0x040037D3 RID: 14291
		private global::AcpBusinessLayer.AcpKeyField radErgoCfgKMButtonKey_A22560;

		// Token: 0x040037D4 RID: 14292
		private global::AcpBusinessLayer.AcpField<string> radErgoCfgKMButtonName_A22561;

		// Token: 0x040037D5 RID: 14293
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgKMButtonShortPressTime;

		// Token: 0x040037D6 RID: 14294
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgKMButtonLongPressTime;
	}
}
