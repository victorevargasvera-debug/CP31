using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Features.Converters;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;
using Motorola.MackinawCPS.CoreFeatures.MenuItems;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.Switches;

namespace Motorola.MackinawCPS.CoreFeatures.Buttons
{
	// Token: 0x02000415 RID: 1045
	[global::System.Serializable]
	public class PortableButtonInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008EC8 RID: 36552 RVA: 0x0086BB04 File Offset: 0x00869D04
		public PortableButtonInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06008EC9 RID: 36553 RVA: 0x0086BB20 File Offset: 0x00869D20
		protected PortableButtonInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008ECA RID: 36554 RVA: 0x0086BB38 File Offset: 0x00869D38
		public override void Init()
		{
			int a_ = 18;
			short num = (short)397803520;
			short num2 = num;
			num = (short)436789343;
			short num3 = num;
			num = (short)248766559;
			switch (num3 == num)
			{
			}
			num = (short)237240320;
			if (num != 0)
			{
			}
			num = (short)1669070849;
			if (num != 0)
			{
			}
			this.btnGeneralConventionalBCO_A19543 = new global::AcpBusinessLayer.AcpSparseLOVField(148, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnGeneralConventionalBCO_A19543LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnGeneralConventionalBCO_A19543LovStrs), this, global::AllFeatures.CodeplugGuid.b("釒ꇔ맖默뻚돜뫞鏠苢觤ꓦ蛨藪鯬諮鿰蟲鳴飶韸髺釼뷾䈀䰂娄䘆㠈㈊㠌㬎∐", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBCO, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnGeneralConventionalBCO_A19543LovStrs);
			this.btnGeneralConventionalBCO_A19543.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.btnGeneralConventionalBCO_A19543.DataTransferOrder = 31;
			this.btnTrunkingPortableTrunkingBCO_A19545 = new global::AcpBusinessLayer.AcpSparseLOVField(148, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnTrunkingPortableTrunkingBCO_A19545LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnTrunkingPortableTrunkingBCO_A19545LovStrs), this, global::AllFeatures.CodeplugGuid.b("釒ꇔ맖跘꧚꣜뇞諠諢诤胦맨蓪鿬鯮郰釲駴鋶그觺裼釾樀樂欄怆䬈䠊䈌倎倐−Ⱄ∖ⴘ⸚", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnTrunkingPortableTrunkingBCO_A19545LovStrs);
			this.btnTrunkingPortableTrunkingBCO_A19545.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.btnTrunkingPortableTrunkingBCO_A19545.DataTransferOrder = 32;
			this.btnPortableButtonKey_A22557 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("釒ꇔ맖觘듚꿜ꯞ胠臢觤苦ꯨ黪駬鯮黰鷲뻴鋶胸ꓺ볼췾㌀㘂〄〆", a_), global::CommonResources.AcgResources.ID_KEY, 14);
			this.btnPortableButtonKey_A22557.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.btnPortableButtonKey_A22557.DataTransferOrder = 4;
			this.btnPortableButtonName_A22558 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_TOPBUTTON, this, global::AllFeatures.CodeplugGuid.b("釒ꇔ맖觘듚꿜ꯞ胠臢觤苦ꯨ黪駬鯮黰鷲믴零铸黺ꋼ뻾㌀㄂〄㈆ㄈ", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.btnPortableButtonName_A22558.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.btnPortableButtonName_A22558.DataTransferOrder = -1;
			this.btnGeneralConventionalFeature_A19544 = new global::AcpBusinessLayer.AcpSparseLOVField(24, new global::Features.Converters.ZoneBankSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnGeneralConventionalFeature_A19544LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnGeneralConventionalFeature_A19544LovStrs), this, global::AllFeatures.CodeplugGuid.b("釒ꇔ맖默뻚돜뫞鏠苢觤ꓦ蛨藪鯬諮鿰蟲鳴飶韸髺釼맾搀戂焄爆笈渊刌与‐⨒—⌖ⴘ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnGeneralConventionalFeature_A19544LovStrs);
			this.btnGeneralConventionalFeature_A19544.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.btnGeneralConventionalFeature_A19544.DataTransferOrder = 2;
			this.btnGeneralConventionalFeature_A19544.ValidateAcrossRecset = true;
			this.btnTrunkingPortableButtonFeature_A19546 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Features.Converters.ZoneBankSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnTrunkingPortableButtonFeature_A19546LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnTrunkingPortableButtonFeature_A19546LovStrs), this, global::AllFeatures.CodeplugGuid.b("釒ꇔ맖跘꧚꣜뇞諠諢诤胦맨蓪鿬鯮郰釲駴鋶미軺觼课渀洂䌄戆栈缊砌紎琐䰒吔☖‘⸚⤜⤞", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnTrunkingPortableButtonFeature_A19546LovStrs);
			this.btnTrunkingPortableButtonFeature_A19546.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.btnTrunkingPortableButtonFeature_A19546.DataTransferOrder = 3;
			this.btnTrunkingPortableButtonFeature_A19546.ValidateAcrossRecset = true;
			this.btnTopButtonShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("釒ꇔ맖跘듚규鷞铠韢釤裦蟨룪藬胮菰蟲ꗴ藶鳸裺軼꯾栀渂怄", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
			this.btnTopButtonShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.btnTopButtonShortPressTime.DataTransferOrder = 33;
			this.btnTopButtonShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.btnTopButtonShortPressTime.ShowHexValue = false;
			this.btnTopButtonShortPressTime.ValidateAcrossRecset = true;
			this.btnPortableTopButtonLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("釒ꇔ맖觘듚꿜ꯞ胠臢觤苦뷨蓪鷬귮蓰蟲致飶韸럺鋼釾昀匂眄戆稈砊夌明簐瘒", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
			this.btnPortableTopButtonLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.btnPortableTopButtonLongPressTime.DataTransferOrder = 34;
			((global::AcpBusinessLayer.AcpSimpleRangeField)this.btnPortableTopButtonLongPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
			this.btnPortableTopButtonLongPressTime.ShowHexValue = false;
			this.btnPortableTopButtonLongPressTime.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菒뫔ꗖ귘뫚뿜돞蓠쏢꟤鋦鷨鿪苬臮", a_);
			base.Id = 10092;
			base.UIName = global::CommonResources.AcgResources.ID_PORTABLEBUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008ECB RID: 36555 RVA: 0x0086BED4 File Offset: 0x0086A0D4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)1402798100;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臂뇄꧆軈껊ꏌ꫎ꏐ닒맔铖뛘뗚ꯜ뫞迠韢賤裦蟨諪臬ꧮ铰鋲致苶诸黺ꋼ뻾\u3000㨂〄㌆㴈", a_)))
					{
						num = (short)1480065033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C3;
				case 1:
					this.btnPortableButtonName_A22558 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_TOPBUTTON, this, global::AllFeatures.CodeplugGuid.b("臂뇄꧆駈꓊뿌믎냐뇒맔닖鯘껚꧜ꯞ軠跢ꯤ蛦蓨軪달껮쏰쇲샴싶쇸", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.btnPortableButtonName_A22558.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.btnPortableButtonName_A22558.DataTransferOrder = -1;
					num = (short)554762266;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_36A;
				case 3:
					goto IL_49C;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臂뇄꧆駈꓊뿌믎냐뇒맔닖鯘껚꧜ꯞ軠跢껤苦部듪곬\uddee쏰웲샴샶", a_)))
					{
						num = (short)1395851286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B8;
				case 5:
					this.btnTrunkingPortableButtonFeature_A19546 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::Features.Converters.ZoneBankSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnTrunkingPortableButtonFeature_A19546LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnTrunkingPortableButtonFeature_A19546LovStrs), this, global::AllFeatures.CodeplugGuid.b("臂뇄꧆鷈맊료ꇎ뫐뫒믔냖觘듚꿜ꯞ胠臢觤苦ꯨ黪駬鯮黰鷲돴鋶飸迺裼跾搀専䐄㘆〈㸊㤌㤎", a_), global::CommonResources.AcgResources.ID_TRUNKINGFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnTrunkingPortableButtonFeature_A19546LovStrs);
					this.btnTrunkingPortableButtonFeature_A19546.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.btnTrunkingPortableButtonFeature_A19546.DataTransferOrder = 3;
					this.btnTrunkingPortableButtonFeature_A19546.ValidateAcrossRecset = true;
					num = (short)731578371;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.btnTrunkingPortableTrunkingBCO_A19545 = new global::AcpBusinessLayer.AcpSparseLOVField(148, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnTrunkingPortableTrunkingBCO_A19545LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnTrunkingPortableTrunkingBCO_A19545LovStrs), this, global::AllFeatures.CodeplugGuid.b("臂뇄꧆鷈맊료ꇎ뫐뫒믔냖觘듚꿜ꯞ胠臢觤苦뷨駪飬臮髰髲鯴郶미룺닼ꃾ䀀㈂㰄㈆㴈㸊", a_), global::CommonResources.AcgResources.ID_TRUNKINGBCO, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnTrunkingPortableTrunkingBCO_A19545LovStrs);
					this.btnTrunkingPortableTrunkingBCO_A19545.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.btnTrunkingPortableTrunkingBCO_A19545.DataTransferOrder = 32;
					num = (short)399376400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臂뇄꧆鷈맊료ꇎ뫐뫒믔냖觘듚꿜ꯞ胠臢觤苦ꯨ黪駬鯮黰鷲돴鋶飸迺裼跾搀専䐄㘆〈㸊㤌㤎", a_)))
					{
						num = (short)1795620869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_49C;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臂뇄꧆駈꓊뿌믎냐뇒맔닖鯘껚꧜ꯞ軠跢ꯤ蛦蓨軪달껮쏰쇲샴싶쇸", a_)))
					{
						num = (short)938672129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_111;
				case 9:
					num = (short)482476033;
					if (num != 0)
					{
					}
					this.btnGeneralConventionalFeature_A19544 = new global::AcpBusinessLayer.AcpSparseLOVField(24, new global::Features.Converters.ZoneBankSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnGeneralConventionalFeature_A19544LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnGeneralConventionalFeature_A19544LovStrs), this, global::AllFeatures.CodeplugGuid.b("臂뇄꧆軈껊ꏌ꫎ꏐ닒맔铖뛘뗚ꯜ뫞迠韢賤裦蟨諪臬ꧮ铰鋲致苶诸黺ꋼ뻾\u3000㨂〄㌆㴈", a_), global::CommonResources.AcgResources.ID_CONVENTIONALFEATURE, true, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnGeneralConventionalFeature_A19544LovStrs);
					this.btnGeneralConventionalFeature_A19544.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.btnGeneralConventionalFeature_A19544.DataTransferOrder = 2;
					this.btnGeneralConventionalFeature_A19544.ValidateAcrossRecset = true;
					num = (short)1013907466;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_C3;
				case 11:
				{
					num = (short)1959399543;
					short num3 = num;
					num = (short)731385975;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_674;
					default:
						num = (short)337117184;
						if (num != 0)
						{
						}
						this.btnTopButtonShortPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("臂뇄꧆鷈꓊뷌跎ꓐ꟒ꇔ룖럘裚뗜냞鏠韢뗤闦賨飪黬믮飰黲郴", a_), global::CommonResources.AcgResources.ID_SHORTPRESSTIME, 0, 124, null, null, 0, 50);
						this.btnTopButtonShortPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.btnTopButtonShortPressTime.DataTransferOrder = 33;
						this.btnTopButtonShortPressTime.AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
						this.btnTopButtonShortPressTime.ShowHexValue = false;
						this.btnTopButtonShortPressTime.ValidateAcrossRecset = true;
						num = (short)203227138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臂뇄꧆鷈맊료ꇎ뫐뫒믔냖觘듚꿜ꯞ胠臢觤苦뷨駪飬臮髰髲鯴郶미룺닼ꃾ䀀㈂㰄㈆㴈㸊", a_)))
					{
						num = (short)229638150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_580;
				case 13:
					this.btnGeneralConventionalBCO_A19543 = new global::AcpBusinessLayer.AcpSparseLOVField(148, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.indexBtnGeneralConventionalBCO_A19543LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.idBtnGeneralConventionalBCO_A19543LovStrs), this, global::AllFeatures.CodeplugGuid.b("臂뇄꧆軈껊ꏌ꫎ꏐ닒맔铖뛘뗚ꯜ뫞迠韢賤裦蟨諪臬귮닰볲ꫴ뛶죸싺주쯾㈀", a_), global::CommonResources.AcgResources.ID_CONVENTIONALBCO, global::Motorola.MackinawCPS.CoreFeatures.Buttons.LOVs.BtnGeneralConventionalBCO_A19543LovStrs);
					this.btnGeneralConventionalBCO_A19543.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.btnGeneralConventionalBCO_A19543.DataTransferOrder = 31;
					num = (short)180879385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臂뇄꧆鷈꓊뷌跎ꓐ꟒ꇔ룖럘裚뗜냞鏠韢뗤闦賨飪黬믮飰黲郴", a_)))
					{
						num = (short)315621387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_36A;
				case 15:
					goto IL_57B;
				case 16:
					goto IL_580;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臂뇄꧆駈꓊뿌믎냐뇒맔닖跘듚규鷞铠韢釤裦蟨꟪苬臮雰ꏲ蟴鋶諸裺ꧼ雾氀昂", a_)))
					{
						num = (short)500170779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79C;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("臂뇄꧆軈껊ꏌ꫎ꏐ닒맔铖뛘뗚ꯜ뫞迠韢賤裦蟨諪臬귮닰볲ꫴ뛶죸싺주쯾㈀", a_)))
					{
						num = (short)681902093;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_182;
				case 19:
					num = (short)197459989;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					switch (0)
					{
					case 0:
						goto IL_9D;
					}
					continue;
				case 21:
					if (producerFields != null)
					{
						num = (short)131465240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_79C;
				case 22:
					goto IL_674;
				case 23:
					goto IL_3B8;
				case 24:
					num = (short)900399122;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					goto IL_182;
				case 26:
					goto IL_111;
				case 27:
					this.btnPortableTopButtonLongPressTime = new global::AcpBusinessLayer.AcpSimpleRangeField(255, this, global::AllFeatures.CodeplugGuid.b("臂뇄꧆駈꓊뿌믎냐뇒맔닖跘듚규鷞铠韢釤裦蟨꟪苬臮雰ꏲ蟴鋶諸裺ꧼ雾氀昂", a_), global::CommonResources.AcgResources.ID_LONGPRESSTIME, 0, 25, null, null, 0, 250);
					this.btnPortableTopButtonLongPressTime.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.btnPortableTopButtonLongPressTime.DataTransferOrder = 34;
					((global::AcpBusinessLayer.AcpSimpleRangeField)this.btnPortableTopButtonLongPressTime).AddCustomValue(255, global::CommonResources.AcgResources.ID_RADIOWIDE);
					this.btnPortableTopButtonLongPressTime.ShowHexValue = false;
					this.btnPortableTopButtonLongPressTime.ValidateAcrossRecset = true;
					num = (short)861863951;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)824180755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_C3:
				num = (short)1652817927;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_111:
				num = (short)1227292672;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_182:
				num = (short)1880293388;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_36A:
				num = (short)1824325649;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3B8:
				num = (short)707002368;
				short num4 = num;
				num = (short)170524680;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_49C:
				num = (short)1033371662;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_580:
				num = (short)623706116;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_674:
				this.btnPortableButtonKey_A22557 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("臂뇄꧆駈꓊뿌믎냐뇒맔닖鯘껚꧜ꯞ軠跢껤苦部듪곬\uddee쏰웲샴샶", a_), global::CommonResources.AcgResources.ID_KEY, 14);
				this.btnPortableButtonKey_A22557.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
				this.btnPortableButtonKey_A22557.DataTransferOrder = 4;
				num = (short)814219287;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_57B:
			IL_79C:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏂꫄뗆뷈꫊꿌ꏎ듐韔ꋖ귘꿚닜뇞", a_);
			base.Id = 10092;
			base.UIName = global::CommonResources.AcgResources.ID_PORTABLEBUTTON;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008ECC RID: 36556 RVA: 0x0086C6B0 File Offset: 0x0086A8B0
		public override void PopulateReferences()
		{
			short num = (short)1688581023;
			short num2 = num;
			num = (short)178434975;
			switch (num2 == num)
			{
			default:
			{
				num = (short)896925696;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)945750016;
			if (num != 0)
			{
			}
			num = (short)1287454721;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008ECD RID: 36557 RVA: 0x0086C758 File Offset: 0x0086A958
		public override void DropReferences()
		{
			short num = (short)1831366841;
			short num2 = num;
			num = (short)234582201;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1436745728;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)765722625;
			if (num != 0)
			{
			}
			num = (short)206897152;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008ECE RID: 36558 RVA: 0x0086C804 File Offset: 0x0086AA04
		public override void SetConstraints()
		{
			short num = (short)1942618113;
			if (num != 0)
			{
			}
			num = (short)307953664;
			short num2 = num;
			num = (short)673923842;
			short num3 = num;
			num = (short)1488143106;
			switch (num3 == num)
			{
			}
			num = (short)2105933824;
			if (num != 0)
			{
			}
			this.btnPortableButtonName_A22558.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.btnGeneralConventionalFeature_A19544.ValidateAcrossRecset = true;
			this.btnGeneralConventionalFeature_A19544.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.ConConventionalPortableFeaturesSelect);
			this.btnGeneralConventionalFeature_A19544.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.conUpdateFieldsDepOnCnvButton);
			this.btnTrunkingPortableButtonFeature_A19546.ValidateAcrossRecset = true;
			this.btnTrunkingPortableButtonFeature_A19546.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.ConTrunkingPortableFeaturesSelect);
			this.btnTrunkingPortableButtonFeature_A19546.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.conSetEditabilityPortTrkFeature);
			this.btnTrunkingPortableButtonFeature_A19546.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.conSetValueRSMOrangeTrk);
			this.BtnTopButtonShortPressTime.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.BtnShortPressAndLongPressIsApplicable);
			this.BtnTopButtonShortPressTime.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.RadConfigPortableButtonShortPressDurIsValid);
			this.BtnPortableTopButtonLongPressTime.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.BtnShortPressAndLongPressIsApplicable);
			this.BtnPortableTopButtonLongPressTime.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.RadConfigPortableButtonLongPressDurIsValid);
		}

		// Token: 0x06008ECF RID: 36559 RVA: 0x0086C9AC File Offset: 0x0086ABAC
		public override void SetupDependencies()
		{
			switch (0)
			{
			case 0:
				goto IL_90;
			}
			short num;
			int num4;
			global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
			for (;;)
			{
				IL_0A:
				num = (short)848655986;
				short num2 = num;
				num = (short)1184003698;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_ADE;
				case 1:
					break;
				default:
				{
					num = (short)479133696;
					short num3 = num;
					break;
				}
				}
				num = (short)1567162368;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
				{
					global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2045);
					if (feature == null)
					{
						num = (short)1171193857;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					acpFeatureNode = feature[0];
					if (acpFeatureNode == null)
					{
						num = (short)1105133570;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AE1;
				}
				case 1:
					goto IL_AB7;
				case 2:
					goto IL_ADE;
				}
				goto IL_90;
			}
			IL_AB7:
			object obj = null;
			goto IL_AED;
			IL_ADE:
			obj = null;
			goto IL_AED;
			IL_AE1:
			obj = acpFeatureNode[10105];
			IL_AED:
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features = obj as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features;
			if (features != null)
			{
				features.RadWideFeaturesChannelFallbackEnable.AddDependentObject(this.btnGeneralConventionalFeature_A19544);
			}
			if (features == null)
			{
				return;
			}
			features.RadWideFeaturesChannelFallbackEnable.AddDependentObject(this.btnTrunkingPortableButtonFeature_A19546);
			return;
			IL_90:
			num = (short)1153171457;
			if (num != 0)
			{
			}
			this.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836.AddDependentObject(this.btnGeneralConventionalFeature_A19544);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.AddDependentObject(this.btnGeneralConventionalFeature_A19544);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.AddDependentObject(this.btnGeneralConventionalFeature_A19544);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.AddDependentObject(this.btnGeneralConventionalFeature_A19544);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.AddDependentObject(this.btnGeneralConventionalFeature_A19544);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.AddDependentObject(this.btnGeneralConventionalFeature_A19544);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.AddDependentObject(this.btnGeneralConventionalFeature_A19544);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.AddDependentObject(this.btnGeneralConventionalFeature_A19544);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.AddDependentObject(this.btnGeneralConventionalFeature_A19544);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.AddDependentObject(this.btnGeneralConventionalFeature_A19544);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.AddDependentObject(this.btnGeneralConventionalFeature_A19544);
			this.btnTrunkingPortableButtonFeature_A19546.AddDependentObject(this.btnGeneralConventionalFeature_A19544);
			this.RefMenuItems.General.DispMenuConventionalSelectedMenuItems_A21736.AddDependentObject(this.btnGeneralConventionalFeature_A19544);
			this.RefMenuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.AddDependentObject(this.btnGeneralConventionalFeature_A19544);
			this.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.AddDependentObject(this.btnGeneralConventionalFeature_A19544);
			this.RefRadioWide.Features.RadCfgVirtualPartnerMode.AddDependentObject(this.btnGeneralConventionalFeature_A19544);
			this.RefRadioWide.Features.RadWideFeaturesVoiceControlPriority.AddDependentObject(this.btnGeneralConventionalFeature_A19544);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.AddDependentObject(this.btnGeneralConventionalFeature_A19544);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.AddDependentObject(this.btnTrunkingPortableButtonFeature_A19546);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.AddDependentObject(this.btnTrunkingPortableButtonFeature_A19546);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.AddDependentObject(this.btnTrunkingPortableButtonFeature_A19546);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.AddDependentObject(this.btnTrunkingPortableButtonFeature_A19546);
			this.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.AddDependentObject(this.btnTrunkingPortableButtonFeature_A19546);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.AddDependentObject(this.btnTrunkingPortableButtonFeature_A19546);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.AddDependentObject(this.btnTrunkingPortableButtonFeature_A19546);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.AddDependentObject(this.btnTrunkingPortableButtonFeature_A19546);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.AddDependentObject(this.btnTrunkingPortableButtonFeature_A19546);
			this.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.AddDependentObject(this.btnTrunkingPortableButtonFeature_A19546);
			this.btnGeneralConventionalFeature_A19544.AddDependentObject(this.btnTrunkingPortableButtonFeature_A19546);
			this.btnPortableButtonName_A22558.AddDependentObject(this.btnTrunkingPortableButtonFeature_A19546);
			this.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836.AddDependentObject(this.btnTrunkingPortableButtonFeature_A19546);
			this.RefMenuItems.General.DispMenuConventionalSelectedMenuItems_A21736.AddDependentObject(this.btnTrunkingPortableButtonFeature_A19546);
			this.RefMenuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.AddDependentObject(this.btnTrunkingPortableButtonFeature_A19546);
			this.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.AddDependentObject(this.btnTrunkingPortableButtonFeature_A19546);
			this.RefEmergencyWide.ManDown.EmerWideManDownTrigger_A40001.AddDependentObject(this.btnTrunkingPortableButtonFeature_A19546);
			this.RefRadioWide.Features.RadCfgVirtualPartnerMode.AddDependentObject(this.btnTrunkingPortableButtonFeature_A19546);
			this.RefRadioWide.Features.RadWideFeaturesVoiceControlPriority.AddDependentObject(this.btnTrunkingPortableButtonFeature_A19546);
			this.btnTrunkingPortableTrunkingBCO_A19545.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition2_A9467);
			this.btnTrunkingPortableTrunkingBCO_A19545.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition3_A9468);
			this.btnTrunkingPortableTrunkingBCO_A19545.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition1_A9466);
			this.btnTrunkingPortableTrunkingBCO_A19545.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition4_A21534);
			this.btnTrunkingPortableTrunkingBCO_A19545.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition5_A21535);
			this.btnGeneralConventionalFeature_A19544.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition1_A7734);
			this.btnGeneralConventionalFeature_A19544.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition2_A7735);
			this.btnGeneralConventionalFeature_A19544.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition3_A7737);
			this.btnGeneralConventionalFeature_A19544.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition2_A9467);
			this.btnGeneralConventionalFeature_A19544.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition3_A9468);
			this.btnGeneralConventionalFeature_A19544.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition1_A9466);
			this.btnGeneralConventionalFeature_A19544.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10100] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Location).RadWideLocationUserSelectableLocationEnable_A9605);
			this.btnGeneralConventionalFeature_A19544.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition4_A21534);
			this.btnGeneralConventionalFeature_A19544.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition5_A21535);
			this.btnGeneralConventionalFeature_A19544.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition4_A21530);
			this.btnGeneralConventionalFeature_A19544.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition5_A21531);
			this.btnGeneralConventionalFeature_A19544.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2088)[0][10024] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.General).DispMenuTrunkingSelectedMenuItems_A21735);
			this.btnGeneralConventionalFeature_A19544.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2088)[0][10024] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.General).DispMenuConventionalSelectedMenuItems_A21736);
			this.btnTrunkingPortableButtonFeature_A19546.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition1_A7734);
			this.btnTrunkingPortableButtonFeature_A19546.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition2_A7735);
			this.btnTrunkingPortableButtonFeature_A19546.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition3_A7737);
			this.btnTrunkingPortableButtonFeature_A19546.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition2_A9467);
			this.btnTrunkingPortableButtonFeature_A19546.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition3_A9468);
			this.btnTrunkingPortableButtonFeature_A19546.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition1_A9466);
			this.btnTrunkingPortableButtonFeature_A19546.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10100] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Location).RadWideLocationUserSelectableLocationEnable_A9605);
			this.btnTrunkingPortableButtonFeature_A19546.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition4_A21534);
			this.btnTrunkingPortableButtonFeature_A19546.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10088] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches).SwitchTrunkingSwitchesPosition5_A21535);
			this.btnTrunkingPortableButtonFeature_A19546.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition4_A21530);
			this.btnTrunkingPortableButtonFeature_A19546.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2038)[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).SwitchConventionalSwitchesPosition5_A21531);
			this.btnTrunkingPortableButtonFeature_A19546.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2088)[0][10024] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.General).DispMenuTrunkingSelectedMenuItems_A21735);
			this.btnTrunkingPortableButtonFeature_A19546.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2088)[0][10024] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.General).DispMenuConventionalSelectedMenuItems_A21736);
			num = (short)1388249088;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x17004814 RID: 18452
		// (get) Token: 0x06008ED0 RID: 36560 RVA: 0x0086D4E0 File Offset: 0x0086B6E0
		public bool HasDiffs
		{
			get
			{
				short num = (short)454752544;
				short num2 = num;
				num = (short)34732320;
				switch (num2 == num)
				{
				default:
				{
					num = (short)438829056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)451739648;
				if (num != 0)
				{
				}
				num = (short)251723777;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004815 RID: 18453
		// (get) Token: 0x06008ED1 RID: 36561 RVA: 0x0086D594 File Offset: 0x0086B794
		// (set) Token: 0x06008ED2 RID: 36562 RVA: 0x0086D648 File Offset: 0x0086B848
		public int BtnGeneralConventionalBCO_A19543Value
		{
			get
			{
				short num = (short)1533968888;
				short num2 = num;
				num = (short)2099085816;
				switch (num2 == num)
				{
				default:
				{
					num = (short)733872128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1361248257;
				if (num != 0)
				{
				}
				num = (short)686948352;
				if (num != 0)
				{
				}
				return this.btnGeneralConventionalBCO_A19543.Value;
			}
			set
			{
				short num = (short)843434402;
				short num2 = num;
				num = (short)1215613346;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1680343040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1224540160;
				if (num != 0)
				{
				}
				num = (short)1566900225;
				if (num != 0)
				{
				}
				this.btnGeneralConventionalBCO_A19543.Value = value;
			}
		}

		// Token: 0x17004816 RID: 18454
		// (get) Token: 0x06008ED3 RID: 36563 RVA: 0x0086D6FC File Offset: 0x0086B8FC
		// (set) Token: 0x06008ED4 RID: 36564 RVA: 0x0086D7B4 File Offset: 0x0086B9B4
		public string BtnGeneralConventionalBCO_A19543_UIValue
		{
			get
			{
				short num = (short)382585192;
				short num2 = num;
				num = (short)290965864;
				switch (num2 == num)
				{
				default:
				{
					num = (short)623968256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)92274688;
				if (num != 0)
				{
				}
				num = (short)1344339969;
				if (num != 0)
				{
				}
				return this.btnGeneralConventionalBCO_A19543.UIValue;
			}
			set
			{
				short num = (short)1227788227;
				short num2 = num;
				num = (short)967348163;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1051394048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)412680193;
				if (num != 0)
				{
				}
				num = (short)770310144;
				if (num != 0)
				{
				}
				this.btnGeneralConventionalBCO_A19543.UIValue = value;
			}
		}

		// Token: 0x17004817 RID: 18455
		// (get) Token: 0x06008ED5 RID: 36565 RVA: 0x0086D86C File Offset: 0x0086BA6C
		public global::AcpBusinessLayer.AcpListField BtnGeneralConventionalBCO_A19543
		{
			get
			{
				short num = (short)985000430;
				short num2 = num;
				num = (short)2037770734;
				switch (num2 == num)
				{
				default:
				{
					num = (short)336003072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)111017985;
				if (num != 0)
				{
				}
				num = (short)111804416;
				if (num != 0)
				{
				}
				return this.btnGeneralConventionalBCO_A19543;
			}
		}

		// Token: 0x17004818 RID: 18456
		// (get) Token: 0x06008ED6 RID: 36566 RVA: 0x0086D91C File Offset: 0x0086BB1C
		// (set) Token: 0x06008ED7 RID: 36567 RVA: 0x0086D9D0 File Offset: 0x0086BBD0
		public bool BtnGeneralConventionalBCO_A19543_Applicable
		{
			get
			{
				short num = (short)925749705;
				short num2 = num;
				num = (short)1111085513;
				switch (num2 == num)
				{
				default:
				{
					num = (short)134152192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1154613249;
				if (num != 0)
				{
				}
				num = (short)387645440;
				if (num != 0)
				{
				}
				return this.btnGeneralConventionalBCO_A19543.Applicable;
			}
			set
			{
				short num = (short)1605346396;
				short num2 = num;
				num = (short)858563676;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1654128640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)342753281;
				if (num != 0)
				{
				}
				num = (short)1121189888;
				if (num != 0)
				{
				}
				this.btnGeneralConventionalBCO_A19543.Applicable = value;
			}
		}

		// Token: 0x17004819 RID: 18457
		// (get) Token: 0x06008ED8 RID: 36568 RVA: 0x0086DA84 File Offset: 0x0086BC84
		// (set) Token: 0x06008ED9 RID: 36569 RVA: 0x0086DB38 File Offset: 0x0086BD38
		public bool BtnGeneralConventionalBCO_A19543_Valid
		{
			get
			{
				short num = (short)1283747173;
				short num2 = num;
				num = (short)2068475237;
				switch (num2 == num)
				{
				default:
				{
					num = (short)643563520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1177092097;
				if (num != 0)
				{
				}
				num = (short)562823168;
				if (num != 0)
				{
				}
				return this.btnGeneralConventionalBCO_A19543.Valid;
			}
			set
			{
				short num = (short)1005584385;
				if (num != 0)
				{
				}
				num = (short)1353908224;
				short num2 = num;
				num = (short)1125144318;
				short num3 = num;
				num = (short)1444501246;
				switch (num3 == num)
				{
				}
				num = (short)1642266624;
				if (num != 0)
				{
				}
				this.btnGeneralConventionalBCO_A19543.Valid = value;
			}
		}

		// Token: 0x1700481A RID: 18458
		// (get) Token: 0x06008EDA RID: 36570 RVA: 0x0086DBF0 File Offset: 0x0086BDF0
		// (set) Token: 0x06008EDB RID: 36571 RVA: 0x0086DCA8 File Offset: 0x0086BEA8
		public bool BtnGeneralConventionalBCO_A19543_Visible
		{
			get
			{
				short num = (short)1218576385;
				if (num != 0)
				{
				}
				num = (short)1774190592;
				short num2 = num;
				num = (short)2128023981;
				short num3 = num;
				num = (short)1595478445;
				switch (num3 == num)
				{
				}
				num = (short)907673600;
				if (num != 0)
				{
				}
				return this.btnGeneralConventionalBCO_A19543.Visible;
			}
			set
			{
				short num = (short)509626660;
				short num2 = num;
				num = (short)719079716;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1639448576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1428553729;
				if (num != 0)
				{
				}
				num = (short)1327104000;
				if (num != 0)
				{
				}
				this.btnGeneralConventionalBCO_A19543.Visible = value;
			}
		}

		// Token: 0x1700481B RID: 18459
		// (get) Token: 0x06008EDC RID: 36572 RVA: 0x0086DD60 File Offset: 0x0086BF60
		// (set) Token: 0x06008EDD RID: 36573 RVA: 0x0086DE10 File Offset: 0x0086C010
		public bool BtnGeneralConventionalBCO_A19543_Editable
		{
			get
			{
				short num = (short)626982913;
				if (num != 0)
				{
				}
				num = (short)1882587136;
				short num2 = num;
				num = (short)1531552165;
				short num3 = num;
				num = (short)260415909;
				switch (num3 == num)
				{
				}
				num = (short)1490550784;
				if (num != 0)
				{
				}
				return this.btnGeneralConventionalBCO_A19543.Editable;
			}
			set
			{
				short num = (short)1113622264;
				short num2 = num;
				num = (short)666928888;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1812004864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)487915521;
				if (num != 0)
				{
				}
				num = (short)650575872;
				if (num != 0)
				{
				}
				this.btnGeneralConventionalBCO_A19543.Editable = value;
			}
		}

		// Token: 0x1700481C RID: 18460
		// (get) Token: 0x06008EDE RID: 36574 RVA: 0x0086DEC4 File Offset: 0x0086C0C4
		internal string BtnGeneralConventionalBCO_A19543_UILabel
		{
			get
			{
				short num = (short)2137869205;
				short num2 = num;
				num = (short)425741205;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1697185792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1944715264;
				if (num != 0)
				{
				}
				num = (short)1053491201;
				if (num != 0)
				{
				}
				return this.btnGeneralConventionalBCO_A19543.UIName;
			}
		}

		// Token: 0x1700481D RID: 18461
		// (get) Token: 0x06008EDF RID: 36575 RVA: 0x0086DF78 File Offset: 0x0086C178
		// (set) Token: 0x06008EE0 RID: 36576 RVA: 0x0086E02C File Offset: 0x0086C22C
		internal bool BtnGeneralConventionalBCO_A19543_HiddenStatic
		{
			get
			{
				short num = (short)1249008717;
				short num2 = num;
				num = (short)2009226317;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2128543744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)441253889;
				if (num != 0)
				{
				}
				num = (short)802291712;
				if (num != 0)
				{
				}
				return this.btnGeneralConventionalBCO_A19543.HiddenStatic;
			}
			set
			{
				short num = (short)2076246017;
				if (num != 0)
				{
				}
				num = (short)75563008;
				short num2 = num;
				num = (short)1265696665;
				short num3 = num;
				num = (short)1931739033;
				switch (num3 == num)
				{
				}
				num = (short)496238592;
				if (num != 0)
				{
				}
				this.btnGeneralConventionalBCO_A19543.HiddenStatic = value;
			}
		}

		// Token: 0x1700481E RID: 18462
		// (get) Token: 0x06008EE1 RID: 36577 RVA: 0x0086E0E4 File Offset: 0x0086C2E4
		// (set) Token: 0x06008EE2 RID: 36578 RVA: 0x0086E198 File Offset: 0x0086C398
		internal bool BtnGeneralConventionalBCO_A19543_HiddenDynamic
		{
			get
			{
				short num = (short)2061198688;
				short num2 = num;
				num = (short)446391648;
				switch (num2 == num)
				{
				default:
				{
					num = (short)607715328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1330642945;
				if (num != 0)
				{
				}
				num = (short)583663616;
				if (num != 0)
				{
				}
				return this.btnGeneralConventionalBCO_A19543.HiddenDynamic;
			}
			set
			{
				short num = (short)1665945515;
				short num2 = num;
				num = (short)1479364523;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1644560384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)172359680;
				if (num != 0)
				{
				}
				num = (short)1376714753;
				if (num != 0)
				{
				}
				this.btnGeneralConventionalBCO_A19543.HiddenDynamic = value;
			}
		}

		// Token: 0x1700481F RID: 18463
		// (get) Token: 0x06008EE3 RID: 36579 RVA: 0x0086E250 File Offset: 0x0086C450
		public bool BtnGeneralConventionalBCO_A19543_HasDiffs
		{
			get
			{
				short num = (short)1182947473;
				short num2 = num;
				num = (short)56973457;
				switch (num2 == num)
				{
				default:
				{
					num = (short)838860800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1590886401;
				if (num != 0)
				{
				}
				num = (short)970588160;
				if (num != 0)
				{
				}
				return this.btnGeneralConventionalBCO_A19543._HasDiffs;
			}
		}

		// Token: 0x17004820 RID: 18464
		// (get) Token: 0x06008EE4 RID: 36580 RVA: 0x0086E308 File Offset: 0x0086C508
		// (set) Token: 0x06008EE5 RID: 36581 RVA: 0x0086E3BC File Offset: 0x0086C5BC
		public int BtnTrunkingPortableTrunkingBCO_A19545Value
		{
			get
			{
				short num = (short)1945209488;
				short num2 = num;
				num = (short)448957072;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1984692224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1836908545;
				if (num != 0)
				{
				}
				num = (short)1953890304;
				if (num != 0)
				{
				}
				return this.btnTrunkingPortableTrunkingBCO_A19545.Value;
			}
			set
			{
				short num = (short)2004647235;
				short num2 = num;
				num = (short)1159560515;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1985413120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1965883393;
				if (num != 0)
				{
				}
				num = (short)416088064;
				if (num != 0)
				{
				}
				this.btnTrunkingPortableTrunkingBCO_A19545.Value = value;
			}
		}

		// Token: 0x17004821 RID: 18465
		// (get) Token: 0x06008EE6 RID: 36582 RVA: 0x0086E470 File Offset: 0x0086C670
		// (set) Token: 0x06008EE7 RID: 36583 RVA: 0x0086E524 File Offset: 0x0086C724
		public string BtnTrunkingPortableTrunkingBCO_A19545_UIValue
		{
			get
			{
				short num = (short)1383955052;
				short num2 = num;
				num = (short)2101049964;
				switch (num2 == num)
				{
				default:
				{
					num = (short)185532416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)31916033;
				if (num != 0)
				{
				}
				num = (short)1762459648;
				if (num != 0)
				{
				}
				return this.btnTrunkingPortableTrunkingBCO_A19545.UIValue;
			}
			set
			{
				short num = (short)487981057;
				if (num != 0)
				{
				}
				num = (short)468123648;
				short num2 = num;
				num = (short)822494884;
				short num3 = num;
				num = (short)1892370084;
				switch (num3 == num)
				{
				}
				num = (short)1411317760;
				if (num != 0)
				{
				}
				this.btnTrunkingPortableTrunkingBCO_A19545.UIValue = value;
			}
		}

		// Token: 0x17004822 RID: 18466
		// (get) Token: 0x06008EE8 RID: 36584 RVA: 0x0086E5DC File Offset: 0x0086C7DC
		public global::AcpBusinessLayer.AcpListField BtnTrunkingPortableTrunkingBCO_A19545
		{
			get
			{
				short num = (short)191316370;
				short num2 = num;
				num = (short)1809531282;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1537081344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1027211265;
				if (num != 0)
				{
				}
				num = (short)2080964608;
				if (num != 0)
				{
				}
				return this.btnTrunkingPortableTrunkingBCO_A19545;
			}
		}

		// Token: 0x17004823 RID: 18467
		// (get) Token: 0x06008EE9 RID: 36585 RVA: 0x0086E68C File Offset: 0x0086C88C
		// (set) Token: 0x06008EEA RID: 36586 RVA: 0x0086E740 File Offset: 0x0086C940
		public bool BtnTrunkingPortableTrunkingBCO_A19545_Applicable
		{
			get
			{
				short num = (short)193668911;
				short num2 = num;
				num = (short)1859790639;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1963851776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)929955841;
				if (num != 0)
				{
				}
				num = (short)216334336;
				if (num != 0)
				{
				}
				return this.btnTrunkingPortableTrunkingBCO_A19545.Applicable;
			}
			set
			{
				short num = (short)646075204;
				short num2 = num;
				num = (short)920605508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)706674688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)15204353;
				if (num != 0)
				{
				}
				num = (short)3670016;
				if (num != 0)
				{
				}
				this.btnTrunkingPortableTrunkingBCO_A19545.Applicable = value;
			}
		}

		// Token: 0x17004824 RID: 18468
		// (get) Token: 0x06008EEB RID: 36587 RVA: 0x0086E7F4 File Offset: 0x0086C9F4
		// (set) Token: 0x06008EEC RID: 36588 RVA: 0x0086E8A8 File Offset: 0x0086CAA8
		public bool BtnTrunkingPortableTrunkingBCO_A19545_Valid
		{
			get
			{
				short num = (short)1004470273;
				if (num != 0)
				{
				}
				num = (short)287113216;
				short num2 = num;
				num = (short)964558321;
				short num3 = num;
				num = (short)957742577;
				switch (num3 == num)
				{
				}
				num = (short)523763712;
				if (num != 0)
				{
				}
				return this.btnTrunkingPortableTrunkingBCO_A19545.Valid;
			}
			set
			{
				short num = (short)403306599;
				short num2 = num;
				num = (short)2133915751;
				switch (num2 == num)
				{
				default:
				{
					num = (short)657588224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)391839745;
				if (num != 0)
				{
				}
				num = (short)2001993728;
				if (num != 0)
				{
				}
				this.btnTrunkingPortableTrunkingBCO_A19545.Valid = value;
			}
		}

		// Token: 0x17004825 RID: 18469
		// (get) Token: 0x06008EED RID: 36589 RVA: 0x0086E960 File Offset: 0x0086CB60
		// (set) Token: 0x06008EEE RID: 36590 RVA: 0x0086EA14 File Offset: 0x0086CC14
		public bool BtnTrunkingPortableTrunkingBCO_A19545_Visible
		{
			get
			{
				short num = (short)925507940;
				short num2 = num;
				num = (short)663953764;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1512833024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)240910337;
				if (num != 0)
				{
				}
				num = (short)1556217856;
				if (num != 0)
				{
				}
				return this.btnTrunkingPortableTrunkingBCO_A19545.Visible;
			}
			set
			{
				short num = (short)1496383489;
				if (num != 0)
				{
				}
				num = (short)1397410333;
				short num2 = num;
				num = (short)1620429341;
				switch (num2 == num)
				{
				}
				num = (short)826736640;
				if (num != 0)
				{
				}
				num = (short)1934491648;
				short num3 = num;
				this.btnTrunkingPortableTrunkingBCO_A19545.Visible = value;
			}
		}

		// Token: 0x17004826 RID: 18470
		// (get) Token: 0x06008EEF RID: 36591 RVA: 0x0086EACC File Offset: 0x0086CCCC
		// (set) Token: 0x06008EF0 RID: 36592 RVA: 0x0086EB80 File Offset: 0x0086CD80
		public bool BtnTrunkingPortableTrunkingBCO_A19545_Editable
		{
			get
			{
				short num = (short)227719791;
				short num2 = num;
				num = (short)1021885039;
				switch (num2 == num)
				{
				}
				num = (short)2097348609;
				if (num != 0)
				{
				}
				num = (short)253034496;
				if (num != 0)
				{
				}
				num = (short)2109931520;
				short num3 = num;
				return this.btnTrunkingPortableTrunkingBCO_A19545.Editable;
			}
			set
			{
				short num = (short)1448869889;
				if (num != 0)
				{
				}
				num = (short)1957841918;
				short num2 = num;
				num = (short)1984383998;
				switch (num2 == num)
				{
				}
				num = (short)1364721664;
				if (num != 0)
				{
				}
				num = (short)1084948480;
				short num3 = num;
				this.btnTrunkingPortableTrunkingBCO_A19545.Editable = value;
			}
		}

		// Token: 0x17004827 RID: 18471
		// (get) Token: 0x06008EF1 RID: 36593 RVA: 0x0086EC34 File Offset: 0x0086CE34
		internal string BtnTrunkingPortableTrunkingBCO_A19545_UILabel
		{
			get
			{
				short num = (short)1508335436;
				short num2 = num;
				num = (short)1433231180;
				switch (num2 == num)
				{
				}
				num = (short)166133760;
				if (num != 0)
				{
				}
				num = (short)923205633;
				if (num != 0)
				{
				}
				num = (short)1665466368;
				short num3 = num;
				return this.btnTrunkingPortableTrunkingBCO_A19545.UIName;
			}
		}

		// Token: 0x17004828 RID: 18472
		// (get) Token: 0x06008EF2 RID: 36594 RVA: 0x0086ECE8 File Offset: 0x0086CEE8
		// (set) Token: 0x06008EF3 RID: 36595 RVA: 0x0086EDA0 File Offset: 0x0086CFA0
		internal bool BtnTrunkingPortableTrunkingBCO_A19545_HiddenStatic
		{
			get
			{
				short num = (short)1953972647;
				short num2 = num;
				num = (short)1732723111;
				switch (num2 == num)
				{
				}
				num = (short)669384705;
				if (num != 0)
				{
				}
				num = (short)1338441728;
				if (num != 0)
				{
				}
				num = (short)335806464;
				short num3 = num;
				return this.btnTrunkingPortableTrunkingBCO_A19545.HiddenStatic;
			}
			set
			{
				short num = (short)315407820;
				short num2 = num;
				num = (short)759545292;
				switch (num2 == num)
				{
				}
				num = (short)1638400000;
				if (num != 0)
				{
				}
				num = (short)1896546305;
				if (num != 0)
				{
				}
				num = (short)946929664;
				short num3 = num;
				this.btnTrunkingPortableTrunkingBCO_A19545.HiddenStatic = value;
			}
		}

		// Token: 0x17004829 RID: 18473
		// (get) Token: 0x06008EF4 RID: 36596 RVA: 0x0086EE54 File Offset: 0x0086D054
		// (set) Token: 0x06008EF5 RID: 36597 RVA: 0x0086EF08 File Offset: 0x0086D108
		internal bool BtnTrunkingPortableTrunkingBCO_A19545_HiddenDynamic
		{
			get
			{
				short num = (short)2140274689;
				if (num != 0)
				{
				}
				num = (short)1304136079;
				short num2 = num;
				num = (short)1785432463;
				switch (num2 == num)
				{
				}
				num = (short)1832648704;
				if (num != 0)
				{
				}
				num = (short)1363542016;
				short num3 = num;
				return this.btnTrunkingPortableTrunkingBCO_A19545.HiddenDynamic;
			}
			set
			{
				short num = (short)1500477455;
				short num2 = num;
				num = (short)1949202447;
				switch (num2 == num)
				{
				}
				num = (short)65798145;
				if (num != 0)
				{
				}
				num = (short)115802112;
				if (num != 0)
				{
				}
				num = (short)1114701824;
				short num3 = num;
				this.btnTrunkingPortableTrunkingBCO_A19545.HiddenDynamic = value;
			}
		}

		// Token: 0x1700482A RID: 18474
		// (get) Token: 0x06008EF6 RID: 36598 RVA: 0x0086EFC0 File Offset: 0x0086D1C0
		public bool BtnTrunkingPortableTrunkingBCO_A19545_HasDiffs
		{
			get
			{
				short num = (short)517734401;
				if (num != 0)
				{
				}
				num = (short)657654054;
				short num2 = num;
				num = (short)1746862374;
				switch (num2 == num)
				{
				}
				num = (short)1028849664;
				if (num != 0)
				{
				}
				num = (short)659161088;
				short num3 = num;
				return this.btnTrunkingPortableTrunkingBCO_A19545._HasDiffs;
			}
		}

		// Token: 0x1700482B RID: 18475
		// (get) Token: 0x06008EF7 RID: 36599 RVA: 0x0086F078 File Offset: 0x0086D278
		// (set) Token: 0x06008EF8 RID: 36600 RVA: 0x0086F12C File Offset: 0x0086D32C
		public string BtnPortableButtonKey_A22557Value
		{
			get
			{
				short num = (short)1611955988;
				short num2 = num;
				num = (short)2005499668;
				switch (num2 == num)
				{
				}
				num = (short)1696464897;
				if (num != 0)
				{
				}
				num = (short)1518927872;
				if (num != 0)
				{
				}
				num = (short)1922695168;
				short num3 = num;
				return this.btnPortableButtonKey_A22557.Value;
			}
			set
			{
				short num = (short)1377173505;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						this.btnPortableButtonKey_A22557.Value = value;
						num = (short)1239869710;
						short num3 = num;
						num = (short)2115954958;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1164640256;
							if (num != 0)
							{
							}
							num = (short)890765314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					case 2:
						goto IL_C6;
					}
					IL_32:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						return;
					}
					num = (short)1846607872;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C6:
				num = (short)2031943681;
				if (num != 0)
				{
				}
				num = (short)1549008896;
				short num4 = num;
			}
		}

		// Token: 0x1700482C RID: 18476
		// (get) Token: 0x06008EF9 RID: 36601 RVA: 0x0086F254 File Offset: 0x0086D454
		// (set) Token: 0x06008EFA RID: 36602 RVA: 0x0086F30C File Offset: 0x0086D50C
		public string BtnPortableButtonKey_A22557_UIValue
		{
			get
			{
				short num = (short)1808167336;
				short num2 = num;
				num = (short)1207202216;
				switch (num2 == num)
				{
				}
				num = (short)1359347713;
				if (num != 0)
				{
				}
				num = (short)401932288;
				if (num != 0)
				{
				}
				num = (short)947191808;
				short num3 = num;
				return this.btnPortableButtonKey_A22557.Value;
			}
			set
			{
				short num = (short)1435531214;
				short num2 = num;
				num = (short)460748750;
				switch (num2 == num)
				{
				}
				num = (short)606994433;
				if (num != 0)
				{
				}
				num = (short)1366884352;
				if (num != 0)
				{
				}
				num = (short)602472448;
				short num3 = num;
				this.btnPortableButtonKey_A22557.Value = value;
			}
		}

		// Token: 0x1700482D RID: 18477
		// (get) Token: 0x06008EFB RID: 36603 RVA: 0x0086F3C0 File Offset: 0x0086D5C0
		public global::AcpBusinessLayer.AcpKeyField BtnPortableButtonKey_A22557
		{
			get
			{
				short num = (short)839153559;
				short num2 = num;
				num = (short)1334212503;
				switch (num2 == num)
				{
				}
				num = (short)1622802433;
				if (num != 0)
				{
				}
				num = (short)398983168;
				if (num != 0)
				{
				}
				num = (short)1582825472;
				short num3 = num;
				return this.btnPortableButtonKey_A22557;
			}
		}

		// Token: 0x1700482E RID: 18478
		// (get) Token: 0x06008EFC RID: 36604 RVA: 0x0086F474 File Offset: 0x0086D674
		// (set) Token: 0x06008EFD RID: 36605 RVA: 0x0086F528 File Offset: 0x0086D728
		public bool BtnPortableButtonKey_A22557_Applicable
		{
			get
			{
				short num = (short)1866761892;
				short num2 = num;
				num = (short)572491428;
				switch (num2 == num)
				{
				}
				num = (short)1655504896;
				if (num != 0)
				{
				}
				num = (short)839909377;
				if (num != 0)
				{
				}
				num = (short)973340672;
				short num3 = num;
				return this.btnPortableButtonKey_A22557.Applicable;
			}
			set
			{
				short num = (short)390545255;
				short num2 = num;
				num = (short)1316634471;
				switch (num2 == num)
				{
				}
				num = (short)323944449;
				if (num != 0)
				{
				}
				num = (short)413597696;
				if (num != 0)
				{
				}
				num = (short)347865088;
				short num3 = num;
				this.btnPortableButtonKey_A22557.Applicable = value;
			}
		}

		// Token: 0x1700482F RID: 18479
		// (get) Token: 0x06008EFE RID: 36606 RVA: 0x0086F5DC File Offset: 0x0086D7DC
		// (set) Token: 0x06008EFF RID: 36607 RVA: 0x0086F690 File Offset: 0x0086D890
		public bool BtnPortableButtonKey_A22557_Valid
		{
			get
			{
				short num = (short)978976769;
				if (num != 0)
				{
				}
				num = (short)1048291589;
				short num2 = num;
				num = (short)1989781765;
				switch (num2 == num)
				{
				}
				num = (short)1931542528;
				if (num != 0)
				{
				}
				num = (short)509083648;
				short num3 = num;
				return this.btnPortableButtonKey_A22557.Valid;
			}
			set
			{
				short num = (short)1528284465;
				short num2 = num;
				num = (short)172606769;
				switch (num2 == num)
				{
				}
				num = (short)1419444224;
				if (num != 0)
				{
				}
				num = (short)521928705;
				if (num != 0)
				{
				}
				num = (short)1963851776;
				short num3 = num;
				this.btnPortableButtonKey_A22557.Valid = value;
			}
		}

		// Token: 0x17004830 RID: 18480
		// (get) Token: 0x06008F00 RID: 36608 RVA: 0x0086F744 File Offset: 0x0086D944
		// (set) Token: 0x06008F01 RID: 36609 RVA: 0x0086F7F8 File Offset: 0x0086D9F8
		public bool BtnPortableButtonKey_A22557_Visible
		{
			get
			{
				short num = (short)443678721;
				if (num != 0)
				{
				}
				num = (short)879873280;
				short num2 = num;
				num = (short)1958726912;
				switch (num2 == num)
				{
				}
				num = (short)62783488;
				if (num != 0)
				{
				}
				num = (short)1746141184;
				short num3 = num;
				return this.btnPortableButtonKey_A22557.Visible;
			}
			set
			{
				short num = (short)1897759762;
				short num2 = num;
				num = (short)596149266;
				switch (num2 == num)
				{
				}
				num = (short)1095958529;
				if (num != 0)
				{
				}
				num = (short)1394671616;
				if (num != 0)
				{
				}
				num = (short)178585600;
				short num3 = num;
				this.btnPortableButtonKey_A22557.Visible = value;
			}
		}

		// Token: 0x17004831 RID: 18481
		// (get) Token: 0x06008F02 RID: 36610 RVA: 0x0086F8AC File Offset: 0x0086DAAC
		// (set) Token: 0x06008F03 RID: 36611 RVA: 0x0086F964 File Offset: 0x0086DB64
		public bool BtnPortableButtonKey_A22557_Editable
		{
			get
			{
				short num = (short)2094141661;
				short num2 = num;
				num = (short)600117469;
				switch (num2 == num)
				{
				}
				num = (short)1931608065;
				if (num != 0)
				{
				}
				num = (short)1091502080;
				if (num != 0)
				{
				}
				num = (short)168558592;
				short num3 = num;
				return this.btnPortableButtonKey_A22557.Editable;
			}
			set
			{
				short num = (short)98782783;
				short num2 = num;
				num = (short)1176522303;
				switch (num2 == num)
				{
				}
				num = (short)1493041153;
				if (num != 0)
				{
				}
				num = (short)471728128;
				if (num != 0)
				{
				}
				num = (short)1075642368;
				short num3 = num;
				this.btnPortableButtonKey_A22557.Editable = value;
			}
		}

		// Token: 0x17004832 RID: 18482
		// (get) Token: 0x06008F04 RID: 36612 RVA: 0x0086FA18 File Offset: 0x0086DC18
		internal string BtnPortableButtonKey_A22557_UILabel
		{
			get
			{
				short num = (short)1758667022;
				short num2 = num;
				num = (short)2085560590;
				switch (num2 == num)
				{
				}
				num = (short)2131951616;
				if (num != 0)
				{
				}
				num = (short)1775697921;
				if (num != 0)
				{
				}
				num = (short)955514880;
				short num3 = num;
				return this.btnPortableButtonKey_A22557.UIName;
			}
		}

		// Token: 0x17004833 RID: 18483
		// (get) Token: 0x06008F05 RID: 36613 RVA: 0x0086FACC File Offset: 0x0086DCCC
		// (set) Token: 0x06008F06 RID: 36614 RVA: 0x0086FB80 File Offset: 0x0086DD80
		internal bool BtnPortableButtonKey_A22557_HiddenStatic
		{
			get
			{
				short num = (short)1401612913;
				short num2 = num;
				num = (short)442755697;
				switch (num2 == num)
				{
				}
				num = (short)1201078273;
				if (num != 0)
				{
				}
				num = (short)971964416;
				if (num != 0)
				{
				}
				num = (short)1216479232;
				short num3 = num;
				return this.btnPortableButtonKey_A22557.HiddenStatic;
			}
			set
			{
				short num = (short)1111883777;
				if (num != 0)
				{
				}
				num = (short)1195043810;
				short num2 = num;
				num = (short)357034978;
				switch (num2 == num)
				{
				}
				num = (short)1796931584;
				if (num != 0)
				{
				}
				num = (short)2091974656;
				short num3 = num;
				this.btnPortableButtonKey_A22557.HiddenStatic = value;
			}
		}

		// Token: 0x17004834 RID: 18484
		// (get) Token: 0x06008F07 RID: 36615 RVA: 0x0086FC38 File Offset: 0x0086DE38
		// (set) Token: 0x06008F08 RID: 36616 RVA: 0x0086FCF0 File Offset: 0x0086DEF0
		internal bool BtnPortableButtonKey_A22557_HiddenDynamic
		{
			get
			{
				short num = (short)50035677;
				short num2 = num;
				num = (short)1320713181;
				switch (num2 == num)
				{
				}
				num = (short)1203961857;
				if (num != 0)
				{
				}
				num = (short)248250368;
				if (num != 0)
				{
				}
				num = (short)254672896;
				short num3 = num;
				return this.btnPortableButtonKey_A22557.HiddenDynamic;
			}
			set
			{
				short num = (short)1403977729;
				if (num != 0)
				{
				}
				num = (short)1058801548;
				short num2 = num;
				num = (short)439814028;
				switch (num2 == num)
				{
				}
				num = (short)972423168;
				if (num != 0)
				{
				}
				num = (short)424607744;
				short num3 = num;
				this.btnPortableButtonKey_A22557.HiddenDynamic = value;
			}
		}

		// Token: 0x17004835 RID: 18485
		// (get) Token: 0x06008F09 RID: 36617 RVA: 0x0086FDA8 File Offset: 0x0086DFA8
		public bool BtnPortableButtonKey_A22557_HasDiffs
		{
			get
			{
				short num = (short)1578861309;
				short num2 = num;
				num = (short)720667389;
				switch (num2 == num)
				{
				}
				num = (short)1263403009;
				if (num != 0)
				{
				}
				num = (short)1604059136;
				if (num != 0)
				{
				}
				num = (short)1540751360;
				short num3 = num;
				return this.btnPortableButtonKey_A22557._HasDiffs;
			}
		}

		// Token: 0x17004836 RID: 18486
		// (get) Token: 0x06008F0A RID: 36618 RVA: 0x0086FE5C File Offset: 0x0086E05C
		// (set) Token: 0x06008F0B RID: 36619 RVA: 0x0086FF10 File Offset: 0x0086E110
		public string BtnPortableButtonName_A22558Value
		{
			get
			{
				short num = (short)1724549077;
				short num2 = num;
				num = (short)1047824341;
				switch (num2 == num)
				{
				}
				num = (short)1630076929;
				if (num != 0)
				{
				}
				num = (short)1616117760;
				if (num != 0)
				{
				}
				num = (short)1371340800;
				short num3 = num;
				return this.btnPortableButtonName_A22558.Value;
			}
			set
			{
				short num = (short)2107402388;
				short num2 = num;
				num = (short)1047095444;
				switch (num2 == num)
				{
				}
				num = (short)2119958529;
				if (num != 0)
				{
				}
				num = (short)1949433856;
				if (num != 0)
				{
				}
				num = (short)134676480;
				short num3 = num;
				this.btnPortableButtonName_A22558.Value = value;
			}
		}

		// Token: 0x17004837 RID: 18487
		// (get) Token: 0x06008F0C RID: 36620 RVA: 0x0086FFC4 File Offset: 0x0086E1C4
		public global::AcpBusinessLayer.AcpField<string> BtnPortableButtonName_A22558
		{
			get
			{
				short num = (short)1393727146;
				short num2 = num;
				num = (short)649434794;
				switch (num2 == num)
				{
				}
				num = (short)517668864;
				if (num != 0)
				{
				}
				num = (short)1430978561;
				if (num != 0)
				{
				}
				num = (short)1270218752;
				short num3 = num;
				return this.btnPortableButtonName_A22558;
			}
		}

		// Token: 0x17004838 RID: 18488
		// (get) Token: 0x06008F0D RID: 36621 RVA: 0x00870070 File Offset: 0x0086E270
		// (set) Token: 0x06008F0E RID: 36622 RVA: 0x00870124 File Offset: 0x0086E324
		public string BtnPortableButtonName_A22558_UIValue
		{
			get
			{
				short num = (short)2092159960;
				short num2 = num;
				num = (short)197055448;
				switch (num2 == num)
				{
				}
				num = (short)944439297;
				if (num != 0)
				{
				}
				num = (short)780468224;
				if (num != 0)
				{
				}
				num = (short)287834112;
				short num3 = num;
				return this.btnPortableButtonName_A22558.Value;
			}
			set
			{
				short num = (short)1581034484;
				short num2 = num;
				num = (short)988130292;
				switch (num2 == num)
				{
				}
				num = (short)1529937920;
				if (num != 0)
				{
				}
				num = (short)926679041;
				if (num != 0)
				{
				}
				num = (short)1107886080;
				short num3 = num;
				this.btnPortableButtonName_A22558.Value = value;
			}
		}

		// Token: 0x17004839 RID: 18489
		// (get) Token: 0x06008F0F RID: 36623 RVA: 0x008701D8 File Offset: 0x0086E3D8
		// (set) Token: 0x06008F10 RID: 36624 RVA: 0x00870290 File Offset: 0x0086E490
		public bool BtnPortableButtonName_A22558_Applicable
		{
			get
			{
				short num = (short)93408256;
				short num2 = num;
				num = (short)1663519744;
				switch (num2 == num)
				{
				}
				num = (short)1007943681;
				if (num != 0)
				{
				}
				num = (short)70123520;
				if (num != 0)
				{
				}
				num = (short)564264960;
				short num3 = num;
				return this.btnPortableButtonName_A22558.Applicable;
			}
			set
			{
				short num = (short)281382112;
				short num2 = num;
				num = (short)1127976160;
				switch (num2 == num)
				{
				}
				num = (short)2113667072;
				if (num != 0)
				{
				}
				num = (short)1988100097;
				if (num != 0)
				{
				}
				num = (short)701038592;
				short num3 = num;
				this.btnPortableButtonName_A22558.Applicable = value;
			}
		}

		// Token: 0x1700483A RID: 18490
		// (get) Token: 0x06008F11 RID: 36625 RVA: 0x00870344 File Offset: 0x0086E544
		// (set) Token: 0x06008F12 RID: 36626 RVA: 0x008703F8 File Offset: 0x0086E5F8
		public bool BtnPortableButtonName_A22558_Valid
		{
			get
			{
				short num = (short)1549227837;
				short num2 = num;
				num = (short)1350063933;
				switch (num2 == num)
				{
				}
				num = (short)696254465;
				if (num != 0)
				{
				}
				num = (short)1597702144;
				if (num != 0)
				{
				}
				num = (short)1115357184;
				short num3 = num;
				return this.btnPortableButtonName_A22558.Valid;
			}
			set
			{
				short num = (short)651623718;
				short num2 = num;
				num = (short)250674470;
				switch (num2 == num)
				{
				}
				num = (short)1176240129;
				if (num != 0)
				{
				}
				num = (short)1025703936;
				if (num != 0)
				{
				}
				num = (short)612433920;
				short num3 = num;
				this.btnPortableButtonName_A22558.Valid = value;
			}
		}

		// Token: 0x1700483B RID: 18491
		// (get) Token: 0x06008F13 RID: 36627 RVA: 0x008704AC File Offset: 0x0086E6AC
		// (set) Token: 0x06008F14 RID: 36628 RVA: 0x00870560 File Offset: 0x0086E760
		public bool BtnPortableButtonName_A22558_Visible
		{
			get
			{
				short num = (short)973750873;
				short num2 = num;
				num = (short)1253982809;
				switch (num2 == num)
				{
				}
				num = (short)1012924417;
				if (num != 0)
				{
				}
				num = (short)790102016;
				if (num != 0)
				{
				}
				num = (short)1752236032;
				short num3 = num;
				return this.btnPortableButtonName_A22558.Visible;
			}
			set
			{
				short num = (short)1573650433;
				if (num != 0)
				{
				}
				num = (short)270812496;
				short num2 = num;
				num = (short)582305104;
				switch (num2 == num)
				{
				}
				num = (short)294453248;
				if (num != 0)
				{
				}
				num = (short)1480130560;
				short num3 = num;
				this.btnPortableButtonName_A22558.Visible = value;
			}
		}

		// Token: 0x1700483C RID: 18492
		// (get) Token: 0x06008F15 RID: 36629 RVA: 0x00870614 File Offset: 0x0086E814
		// (set) Token: 0x06008F16 RID: 36630 RVA: 0x008706C8 File Offset: 0x0086E8C8
		public bool BtnPortableButtonName_A22558_Editable
		{
			get
			{
				short num = (short)550538696;
				short num2 = num;
				num = (short)1992723912;
				switch (num2 == num)
				{
				}
				num = (short)2111438848;
				if (num != 0)
				{
				}
				num = (short)2088828929;
				if (num != 0)
				{
				}
				num = (short)624820224;
				short num3 = num;
				return this.btnPortableButtonName_A22558.Editable;
			}
			set
			{
				short num = (short)387240637;
				short num2 = num;
				num = (short)848941757;
				switch (num2 == num)
				{
				}
				num = (short)1964179457;
				if (num != 0)
				{
				}
				num = (short)482017280;
				if (num != 0)
				{
				}
				num = (short)1572274176;
				short num3 = num;
				this.btnPortableButtonName_A22558.Editable = value;
			}
		}

		// Token: 0x1700483D RID: 18493
		// (get) Token: 0x06008F17 RID: 36631 RVA: 0x00870784 File Offset: 0x0086E984
		internal string BtnPortableButtonName_A22558_UILabel
		{
			get
			{
				short num = (short)626231177;
				short num2 = num;
				num = (short)1752205193;
				switch (num2 == num)
				{
				}
				num = (short)1789132800;
				if (num != 0)
				{
				}
				num = (short)790757377;
				if (num != 0)
				{
				}
				num = (short)1024065536;
				short num3 = num;
				return this.btnPortableButtonName_A22558.UIName;
			}
		}

		// Token: 0x1700483E RID: 18494
		// (get) Token: 0x06008F18 RID: 36632 RVA: 0x00870838 File Offset: 0x0086EA38
		// (set) Token: 0x06008F19 RID: 36633 RVA: 0x008708EC File Offset: 0x0086EAEC
		internal bool BtnPortableButtonName_A22558_HiddenStatic
		{
			get
			{
				short num = (short)647980089;
				short num2 = num;
				num = (short)86860857;
				switch (num2 == num)
				{
				}
				num = (short)91553793;
				if (num != 0)
				{
				}
				num = (short)1503854592;
				if (num != 0)
				{
				}
				num = (short)1716387840;
				short num3 = num;
				return this.btnPortableButtonName_A22558.HiddenStatic;
			}
			set
			{
				short num = (short)21626881;
				if (num != 0)
				{
				}
				num = (short)142856342;
				short num2 = num;
				num = (short)2138034326;
				switch (num2 == num)
				{
				}
				num = (short)2085289984;
				if (num != 0)
				{
				}
				num = (short)1790640128;
				short num3 = num;
				this.btnPortableButtonName_A22558.HiddenStatic = value;
			}
		}

		// Token: 0x1700483F RID: 18495
		// (get) Token: 0x06008F1A RID: 36634 RVA: 0x008709A0 File Offset: 0x0086EBA0
		// (set) Token: 0x06008F1B RID: 36635 RVA: 0x00870A58 File Offset: 0x0086EC58
		internal bool BtnPortableButtonName_A22558_HiddenDynamic
		{
			get
			{
				short num = (short)672624514;
				short num2 = num;
				num = (short)843411330;
				switch (num2 == num)
				{
				}
				num = (short)623509505;
				if (num != 0)
				{
				}
				num = (short)1754005504;
				if (num != 0)
				{
				}
				num = (short)1895235584;
				short num3 = num;
				return this.btnPortableButtonName_A22558.HiddenDynamic;
			}
			set
			{
				short num = (short)1832261863;
				short num2 = num;
				num = (short)1550325991;
				switch (num2 == num)
				{
				}
				num = (short)1236992001;
				if (num != 0)
				{
				}
				num = (short)1232994304;
				if (num != 0)
				{
				}
				num = (short)146538496;
				short num3 = num;
				this.btnPortableButtonName_A22558.HiddenDynamic = value;
			}
		}

		// Token: 0x17004840 RID: 18496
		// (get) Token: 0x06008F1C RID: 36636 RVA: 0x00870B10 File Offset: 0x0086ED10
		public bool BtnPortableButtonName_A22558_HasDiffs
		{
			get
			{
				short num = (short)1480918389;
				short num2 = num;
				num = (short)611452277;
				switch (num2 == num)
				{
				}
				num = (short)1521745921;
				if (num != 0)
				{
				}
				num = (short)1650065408;
				if (num != 0)
				{
				}
				num = (short)1476460544;
				short num3 = num;
				return this.btnPortableButtonName_A22558._HasDiffs;
			}
		}

		// Token: 0x17004841 RID: 18497
		// (get) Token: 0x06008F1D RID: 36637 RVA: 0x00870BC8 File Offset: 0x0086EDC8
		// (set) Token: 0x06008F1E RID: 36638 RVA: 0x00870C7C File Offset: 0x0086EE7C
		public int BtnGeneralConventionalFeature_A19544Value
		{
			get
			{
				short num = (short)418775764;
				short num2 = num;
				num = (short)1847853780;
				switch (num2 == num)
				{
				}
				num = (short)1592393729;
				if (num != 0)
				{
				}
				num = (short)1145372672;
				if (num != 0)
				{
				}
				num = (short)1430454272;
				short num3 = num;
				return this.btnGeneralConventionalFeature_A19544.Value;
			}
			set
			{
				short num = (short)616677376;
				short num2 = num;
				num = (short)316391424;
				switch (num2 == num)
				{
				}
				num = (short)1932328961;
				if (num != 0)
				{
				}
				num = (short)125698048;
				if (num != 0)
				{
				}
				num = (short)216858624;
				short num3 = num;
				this.btnGeneralConventionalFeature_A19544.Value = value;
			}
		}

		// Token: 0x17004842 RID: 18498
		// (get) Token: 0x06008F1F RID: 36639 RVA: 0x00870D34 File Offset: 0x0086EF34
		// (set) Token: 0x06008F20 RID: 36640 RVA: 0x00870DE8 File Offset: 0x0086EFE8
		public string BtnGeneralConventionalFeature_A19544_UIValue
		{
			get
			{
				short num = (short)566231595;
				short num2 = num;
				num = (short)1994850859;
				switch (num2 == num)
				{
				}
				num = (short)979173377;
				if (num != 0)
				{
				}
				num = (short)1894055936;
				if (num != 0)
				{
				}
				num = (short)778305536;
				short num3 = num;
				return this.btnGeneralConventionalFeature_A19544.UIValue;
			}
			set
			{
				short num = (short)585661993;
				short num2 = num;
				num = (short)1457946153;
				switch (num2 == num)
				{
				}
				num = (short)1394868225;
				if (num != 0)
				{
				}
				num = (short)1956511744;
				if (num != 0)
				{
				}
				num = (short)1838940160;
				short num3 = num;
				this.btnGeneralConventionalFeature_A19544.UIValue = value;
			}
		}

		// Token: 0x17004843 RID: 18499
		// (get) Token: 0x06008F21 RID: 36641 RVA: 0x00870EA0 File Offset: 0x0086F0A0
		public global::AcpBusinessLayer.AcpListField BtnGeneralConventionalFeature_A19544
		{
			get
			{
				short num = (short)519474707;
				short num2 = num;
				num = (short)1420922387;
				switch (num2 == num)
				{
				}
				num = (short)782434304;
				if (num != 0)
				{
				}
				num = (short)960495617;
				if (num != 0)
				{
				}
				num = (short)1501233152;
				short num3 = num;
				return this.btnGeneralConventionalFeature_A19544;
			}
		}

		// Token: 0x17004844 RID: 18500
		// (get) Token: 0x06008F22 RID: 36642 RVA: 0x00870F4C File Offset: 0x0086F14C
		// (set) Token: 0x06008F23 RID: 36643 RVA: 0x00871000 File Offset: 0x0086F200
		public bool BtnGeneralConventionalFeature_A19544_Applicable
		{
			get
			{
				short num = (short)595197953;
				if (num != 0)
				{
				}
				num = (short)86782192;
				short num2 = num;
				num = (short)2072326384;
				switch (num2 == num)
				{
				}
				num = (short)1785987072;
				if (num != 0)
				{
				}
				num = (short)2005008384;
				short num3 = num;
				return this.btnGeneralConventionalFeature_A19544.Applicable;
			}
			set
			{
				short num = (short)66352213;
				short num2 = num;
				num = (short)1556182101;
				switch (num2 == num)
				{
				}
				num = (short)837353473;
				if (num != 0)
				{
				}
				num = (short)1716781056;
				if (num != 0)
				{
				}
				num = (short)1901068288;
				short num3 = num;
				this.btnGeneralConventionalFeature_A19544.Applicable = value;
			}
		}

		// Token: 0x17004845 RID: 18501
		// (get) Token: 0x06008F24 RID: 36644 RVA: 0x008710B4 File Offset: 0x0086F2B4
		// (set) Token: 0x06008F25 RID: 36645 RVA: 0x00871168 File Offset: 0x0086F368
		public bool BtnGeneralConventionalFeature_A19544_Valid
		{
			get
			{
				short num = (short)2104692870;
				short num2 = num;
				num = (short)2036863110;
				switch (num2 == num)
				{
				}
				num = (short)2007891968;
				if (num != 0)
				{
				}
				num = (short)1098317825;
				if (num != 0)
				{
				}
				num = (short)1188233216;
				short num3 = num;
				return this.btnGeneralConventionalFeature_A19544.Valid;
			}
			set
			{
				short num = (short)716798942;
				short num2 = num;
				num = (short)1440054238;
				switch (num2 == num)
				{
				}
				num = (short)523108352;
				if (num != 0)
				{
				}
				num = (short)212926465;
				if (num != 0)
				{
				}
				num = (short)235405312;
				short num3 = num;
				this.btnGeneralConventionalFeature_A19544.Valid = value;
			}
		}

		// Token: 0x17004846 RID: 18502
		// (get) Token: 0x06008F26 RID: 36646 RVA: 0x0087121C File Offset: 0x0086F41C
		// (set) Token: 0x06008F27 RID: 36647 RVA: 0x008712D0 File Offset: 0x0086F4D0
		public bool BtnGeneralConventionalFeature_A19544_Visible
		{
			get
			{
				short num = (short)967809377;
				short num2 = num;
				num = (short)1936759137;
				switch (num2 == num)
				{
				}
				num = (short)1912602625;
				if (num != 0)
				{
				}
				num = (short)1237319680;
				if (num != 0)
				{
				}
				num = (short)26607616;
				short num3 = num;
				return this.btnGeneralConventionalFeature_A19544.Visible;
			}
			set
			{
				short num = (short)179593612;
				short num2 = num;
				num = (short)1786405260;
				switch (num2 == num)
				{
				}
				num = (short)362872833;
				if (num != 0)
				{
				}
				num = (short)913309696;
				if (num != 0)
				{
				}
				num = (short)347275264;
				short num3 = num;
				this.btnGeneralConventionalFeature_A19544.Visible = value;
			}
		}

		// Token: 0x17004847 RID: 18503
		// (get) Token: 0x06008F28 RID: 36648 RVA: 0x00871384 File Offset: 0x0086F584
		// (set) Token: 0x06008F29 RID: 36649 RVA: 0x00871438 File Offset: 0x0086F638
		public bool BtnGeneralConventionalFeature_A19544_Editable
		{
			get
			{
				short num = (short)1137144682;
				short num2 = num;
				num = (short)691106666;
				switch (num2 == num)
				{
				}
				num = (short)1246035968;
				if (num != 0)
				{
				}
				num = (short)1221197825;
				if (num != 0)
				{
				}
				num = (short)1486290944;
				short num3 = num;
				return this.btnGeneralConventionalFeature_A19544.Editable;
			}
			set
			{
				short num = (short)1049085386;
				short num2 = num;
				num = (short)2017379786;
				switch (num2 == num)
				{
				}
				num = (short)357433344;
				if (num != 0)
				{
				}
				num = (short)1037697025;
				if (num != 0)
				{
				}
				num = (short)339607552;
				short num3 = num;
				this.btnGeneralConventionalFeature_A19544.Editable = value;
			}
		}

		// Token: 0x17004848 RID: 18504
		// (get) Token: 0x06008F2A RID: 36650 RVA: 0x008714EC File Offset: 0x0086F6EC
		internal string BtnGeneralConventionalFeature_A19544_UILabel
		{
			get
			{
				short num = (short)1864611392;
				short num2 = num;
				num = (short)1452652096;
				switch (num2 == num)
				{
				}
				num = (short)1758920704;
				if (num != 0)
				{
				}
				num = (short)1568997377;
				if (num != 0)
				{
				}
				num = (short)107282432;
				short num3 = num;
				return this.btnGeneralConventionalFeature_A19544.UIName;
			}
		}

		// Token: 0x17004849 RID: 18505
		// (get) Token: 0x06008F2B RID: 36651 RVA: 0x008715A4 File Offset: 0x0086F7A4
		// (set) Token: 0x06008F2C RID: 36652 RVA: 0x00871658 File Offset: 0x0086F858
		internal bool BtnGeneralConventionalFeature_A19544_HiddenStatic
		{
			get
			{
				short num = (short)116786834;
				short num2 = num;
				num = (short)225773202;
				switch (num2 == num)
				{
				}
				num = (short)1523056641;
				if (num != 0)
				{
				}
				num = (short)592445440;
				if (num != 0)
				{
				}
				num = (short)3866624;
				short num3 = num;
				return this.btnGeneralConventionalFeature_A19544.HiddenStatic;
			}
			set
			{
				short num = (short)1023209529;
				short num2 = num;
				num = (short)1081143353;
				switch (num2 == num)
				{
				}
				num = (short)711196672;
				if (num != 0)
				{
				}
				num = (short)1287979009;
				if (num != 0)
				{
				}
				num = (short)898170880;
				short num3 = num;
				this.btnGeneralConventionalFeature_A19544.HiddenStatic = value;
			}
		}

		// Token: 0x1700484A RID: 18506
		// (get) Token: 0x06008F2D RID: 36653 RVA: 0x0087170C File Offset: 0x0086F90C
		// (set) Token: 0x06008F2E RID: 36654 RVA: 0x008717C0 File Offset: 0x0086F9C0
		internal bool BtnGeneralConventionalFeature_A19544_HiddenDynamic
		{
			get
			{
				short num = (short)2726033;
				short num2 = num;
				num = (short)588486801;
				switch (num2 == num)
				{
				}
				num = (short)736755712;
				if (num != 0)
				{
				}
				num = (short)231211009;
				if (num != 0)
				{
				}
				num = (short)24051712;
				short num3 = num;
				return this.btnGeneralConventionalFeature_A19544.HiddenDynamic;
			}
			set
			{
				short num = (short)1226958954;
				short num2 = num;
				num = (short)1290594410;
				switch (num2 == num)
				{
				}
				num = (short)1402601472;
				if (num != 0)
				{
				}
				num = (short)516947969;
				if (num != 0)
				{
				}
				num = (short)1628307456;
				short num3 = num;
				this.btnGeneralConventionalFeature_A19544.HiddenDynamic = value;
			}
		}

		// Token: 0x1700484B RID: 18507
		// (get) Token: 0x06008F2F RID: 36655 RVA: 0x00871874 File Offset: 0x0086FA74
		public bool BtnGeneralConventionalFeature_A19544_HasDiffs
		{
			get
			{
				short num = (short)851252534;
				short num2 = num;
				num = (short)93066550;
				switch (num2 == num)
				{
				}
				num = (short)2083323905;
				if (num != 0)
				{
				}
				num = (short)1221591040;
				if (num != 0)
				{
				}
				num = (short)499515392;
				short num3 = num;
				return this.btnGeneralConventionalFeature_A19544._HasDiffs;
			}
		}

		// Token: 0x1700484C RID: 18508
		// (get) Token: 0x06008F30 RID: 36656 RVA: 0x0087192C File Offset: 0x0086FB2C
		// (set) Token: 0x06008F31 RID: 36657 RVA: 0x008719DC File Offset: 0x0086FBDC
		public int BtnTrunkingPortableButtonFeature_A19546Value
		{
			get
			{
				short num = (short)1152763315;
				short num2 = num;
				num = (short)739427763;
				switch (num2 == num)
				{
				}
				num = (short)990511104;
				if (num != 0)
				{
				}
				num = (short)1472266241;
				if (num != 0)
				{
				}
				num = (short)434962432;
				short num3 = num;
				return this.btnTrunkingPortableButtonFeature_A19546.Value;
			}
			set
			{
				short num = (short)1457859533;
				short num2 = num;
				num = (short)697314253;
				switch (num2 == num)
				{
				}
				num = (short)829095936;
				if (num != 0)
				{
				}
				num = (short)1580335105;
				if (num != 0)
				{
				}
				num = (short)2118385664;
				short num3 = num;
				this.btnTrunkingPortableButtonFeature_A19546.Value = value;
			}
		}

		// Token: 0x1700484D RID: 18509
		// (get) Token: 0x06008F32 RID: 36658 RVA: 0x00871A90 File Offset: 0x0086FC90
		// (set) Token: 0x06008F33 RID: 36659 RVA: 0x00871B48 File Offset: 0x0086FD48
		public string BtnTrunkingPortableButtonFeature_A19546_UIValue
		{
			get
			{
				short num = (short)1449585335;
				short num2 = num;
				num = (short)1865607863;
				switch (num2 == num)
				{
				}
				num = (short)195428353;
				if (num != 0)
				{
				}
				num = (short)2130182144;
				if (num != 0)
				{
				}
				num = (short)727973888;
				short num3 = num;
				return this.btnTrunkingPortableButtonFeature_A19546.UIValue;
			}
			set
			{
				short num = (short)1736835073;
				if (num != 0)
				{
				}
				num = (short)1564421990;
				short num2 = num;
				num = (short)1762144102;
				switch (num2 == num)
				{
				}
				num = (short)1008467968;
				if (num != 0)
				{
				}
				num = (short)1634140160;
				short num3 = num;
				this.btnTrunkingPortableButtonFeature_A19546.UIValue = value;
			}
		}

		// Token: 0x1700484E RID: 18510
		// (get) Token: 0x06008F34 RID: 36660 RVA: 0x00871BFC File Offset: 0x0086FDFC
		public global::AcpBusinessLayer.AcpListField BtnTrunkingPortableButtonFeature_A19546
		{
			get
			{
				short num = (short)1156382721;
				if (num != 0)
				{
				}
				num = (short)472400449;
				short num2 = num;
				num = (short)939541057;
				switch (num2 == num)
				{
				}
				num = (short)921763840;
				if (num != 0)
				{
				}
				num = (short)1826291712;
				short num3 = num;
				return this.btnTrunkingPortableButtonFeature_A19546;
			}
		}

		// Token: 0x1700484F RID: 18511
		// (get) Token: 0x06008F35 RID: 36661 RVA: 0x00871CAC File Offset: 0x0086FEAC
		// (set) Token: 0x06008F36 RID: 36662 RVA: 0x00871D64 File Offset: 0x0086FF64
		public bool BtnTrunkingPortableButtonFeature_A19546_Applicable
		{
			get
			{
				short num = (short)2118543019;
				short num2 = num;
				num = (short)1238656683;
				switch (num2 == num)
				{
				}
				num = (short)1551761408;
				if (num != 0)
				{
				}
				num = (short)509739009;
				if (num != 0)
				{
				}
				num = (short)1166475264;
				short num3 = num;
				return this.btnTrunkingPortableButtonFeature_A19546.Applicable;
			}
			set
			{
				short num = (short)1264877537;
				short num2 = num;
				num = (short)1250328545;
				switch (num2 == num)
				{
				}
				num = (short)1562968064;
				if (num != 0)
				{
				}
				num = (short)1340473345;
				if (num != 0)
				{
				}
				num = (short)594280448;
				short num3 = num;
				this.btnTrunkingPortableButtonFeature_A19546.Applicable = value;
			}
		}

		// Token: 0x17004850 RID: 18512
		// (get) Token: 0x06008F37 RID: 36663 RVA: 0x00871E18 File Offset: 0x00870018
		// (set) Token: 0x06008F38 RID: 36664 RVA: 0x00871ECC File Offset: 0x008700CC
		public bool BtnTrunkingPortableButtonFeature_A19546_Valid
		{
			get
			{
				short num = (short)2113536001;
				if (num != 0)
				{
				}
				num = (short)976830264;
				short num2 = num;
				num = (short)930234168;
				switch (num2 == num)
				{
				}
				num = (short)225247232;
				if (num != 0)
				{
				}
				num = (short)1284964352;
				short num3 = num;
				return this.btnTrunkingPortableButtonFeature_A19546.Valid;
			}
			set
			{
				short num = (short)1587851605;
				short num2 = num;
				num = (short)1066053973;
				switch (num2 == num)
				{
				}
				num = (short)1461911552;
				if (num != 0)
				{
				}
				num = (short)1873936385;
				if (num != 0)
				{
				}
				num = (short)1386676224;
				short num3 = num;
				this.btnTrunkingPortableButtonFeature_A19546.Valid = value;
			}
		}

		// Token: 0x17004851 RID: 18513
		// (get) Token: 0x06008F39 RID: 36665 RVA: 0x00871F84 File Offset: 0x00870184
		// (set) Token: 0x06008F3A RID: 36666 RVA: 0x00872038 File Offset: 0x00870238
		public bool BtnTrunkingPortableButtonFeature_A19546_Visible
		{
			get
			{
				short num = (short)1804962132;
				short num2 = num;
				num = (short)355633492;
				switch (num2 == num)
				{
				}
				num = (short)1022296065;
				if (num != 0)
				{
				}
				num = (short)1835008;
				if (num != 0)
				{
				}
				num = (short)1168113664;
				short num3 = num;
				return this.btnTrunkingPortableButtonFeature_A19546.Visible;
			}
			set
			{
				short num = (short)53537285;
				short num2 = num;
				num = (short)110029317;
				switch (num2 == num)
				{
				}
				num = (short)636157953;
				if (num != 0)
				{
				}
				num = (short)1595670528;
				if (num != 0)
				{
				}
				num = (short)100859904;
				short num3 = num;
				this.btnTrunkingPortableButtonFeature_A19546.Visible = value;
			}
		}

		// Token: 0x17004852 RID: 18514
		// (get) Token: 0x06008F3B RID: 36667 RVA: 0x008720EC File Offset: 0x008702EC
		// (set) Token: 0x06008F3C RID: 36668 RVA: 0x008721A4 File Offset: 0x008703A4
		public bool BtnTrunkingPortableButtonFeature_A19546_Editable
		{
			get
			{
				short num = (short)808538231;
				short num2 = num;
				num = (short)1477464183;
				switch (num2 == num)
				{
				}
				num = (short)315949056;
				if (num != 0)
				{
				}
				num = (short)1787953153;
				if (num != 0)
				{
				}
				num = (short)1158742016;
				short num3 = num;
				return this.btnTrunkingPortableButtonFeature_A19546.Editable;
			}
			set
			{
				short num = (short)1451753473;
				if (num != 0)
				{
				}
				num = (short)56392431;
				short num2 = num;
				num = (short)625048303;
				switch (num2 == num)
				{
				}
				num = (short)1952907264;
				if (num != 0)
				{
				}
				num = (short)823328768;
				short num3 = num;
				this.btnTrunkingPortableButtonFeature_A19546.Editable = value;
			}
		}

		// Token: 0x17004853 RID: 18515
		// (get) Token: 0x06008F3D RID: 36669 RVA: 0x00872258 File Offset: 0x00870458
		internal string BtnTrunkingPortableButtonFeature_A19546_UILabel
		{
			get
			{
				short num = (short)423088890;
				short num2 = num;
				num = (short)240505594;
				switch (num2 == num)
				{
				}
				num = (short)1417740289;
				if (num != 0)
				{
				}
				num = (short)1015349248;
				if (num != 0)
				{
				}
				num = (short)1737031680;
				short num3 = num;
				return this.btnTrunkingPortableButtonFeature_A19546.UIName;
			}
		}

		// Token: 0x17004854 RID: 18516
		// (get) Token: 0x06008F3E RID: 36670 RVA: 0x00872310 File Offset: 0x00870510
		// (set) Token: 0x06008F3F RID: 36671 RVA: 0x008723C4 File Offset: 0x008705C4
		internal bool BtnTrunkingPortableButtonFeature_A19546_HiddenStatic
		{
			get
			{
				short num = (short)2111373313;
				if (num != 0)
				{
				}
				num = (short)954037863;
				short num2 = num;
				num = (short)746354279;
				switch (num2 == num)
				{
				}
				num = (short)1212874752;
				if (num != 0)
				{
				}
				num = (short)449708032;
				short num3 = num;
				return this.btnTrunkingPortableButtonFeature_A19546.HiddenStatic;
			}
			set
			{
				short num = (short)784925879;
				short num2 = num;
				num = (short)427689143;
				switch (num2 == num)
				{
				}
				num = (short)1576206337;
				if (num != 0)
				{
				}
				num = (short)536281088;
				if (num != 0)
				{
				}
				num = (short)1347223552;
				short num3 = num;
				this.btnTrunkingPortableButtonFeature_A19546.HiddenStatic = value;
			}
		}

		// Token: 0x17004855 RID: 18517
		// (get) Token: 0x06008F40 RID: 36672 RVA: 0x00872478 File Offset: 0x00870678
		// (set) Token: 0x06008F41 RID: 36673 RVA: 0x0087252C File Offset: 0x0087072C
		internal bool BtnTrunkingPortableButtonFeature_A19546_HiddenDynamic
		{
			get
			{
				short num = (short)1090372348;
				short num2 = num;
				num = (short)358400764;
				switch (num2 == num)
				{
				}
				num = (short)1396178945;
				if (num != 0)
				{
				}
				num = (short)1944977408;
				if (num != 0)
				{
				}
				num = (short)1750401024;
				short num3 = num;
				return this.btnTrunkingPortableButtonFeature_A19546.HiddenDynamic;
			}
			set
			{
				short num = (short)1241186305;
				if (num != 0)
				{
				}
				num = (short)803964330;
				short num2 = num;
				num = (short)1232307626;
				switch (num2 == num)
				{
				}
				num = (short)117178368;
				if (num != 0)
				{
				}
				num = (short)905314304;
				short num3 = num;
				this.btnTrunkingPortableButtonFeature_A19546.HiddenDynamic = value;
			}
		}

		// Token: 0x17004856 RID: 18518
		// (get) Token: 0x06008F42 RID: 36674 RVA: 0x008725E0 File Offset: 0x008707E0
		public bool BtnTrunkingPortableButtonFeature_A19546_HasDiffs
		{
			get
			{
				short num = (short)394652266;
				short num2 = num;
				num = (short)935062122;
				switch (num2 == num)
				{
				}
				num = (short)950730752;
				if (num != 0)
				{
				}
				num = (short)935460865;
				if (num != 0)
				{
				}
				num = (short)2048262144;
				short num3 = num;
				return this.btnTrunkingPortableButtonFeature_A19546._HasDiffs;
			}
		}

		// Token: 0x17004857 RID: 18519
		// (get) Token: 0x06008F43 RID: 36675 RVA: 0x00872694 File Offset: 0x00870894
		// (set) Token: 0x06008F44 RID: 36676 RVA: 0x00872748 File Offset: 0x00870948
		public int BtnPortableTopButtonLongPressTimeValue
		{
			get
			{
				short num = (short)2073821185;
				if (num != 0)
				{
				}
				num = (short)330238102;
				short num2 = num;
				num = (short)1791035542;
				switch (num2 == num)
				{
				}
				num = (short)191823872;
				if (num != 0)
				{
				}
				num = (short)1378156544;
				short num3 = num;
				return this.btnPortableTopButtonLongPressTime.Value;
			}
			set
			{
				short num = (short)127205377;
				if (num != 0)
				{
				}
				num = (short)1055695591;
				short num2 = num;
				num = (short)1888920295;
				switch (num2 == num)
				{
				}
				num = (short)2122645504;
				if (num != 0)
				{
				}
				num = (short)1404043264;
				short num3 = num;
				this.btnPortableTopButtonLongPressTime.Value = value;
			}
		}

		// Token: 0x17004858 RID: 18520
		// (get) Token: 0x06008F45 RID: 36677 RVA: 0x00872800 File Offset: 0x00870A00
		// (set) Token: 0x06008F46 RID: 36678 RVA: 0x008728B4 File Offset: 0x00870AB4
		public string BtnPortableTopButtonLongPressTime_UIValue
		{
			get
			{
				short num = (short)1524774815;
				short num2 = num;
				num = (short)184235935;
				switch (num2 == num)
				{
				}
				num = (short)1296498689;
				if (num != 0)
				{
				}
				num = (short)536936448;
				if (num != 0)
				{
				}
				num = (short)2026307584;
				short num3 = num;
				return this.btnPortableTopButtonLongPressTime.UIValue;
			}
			set
			{
				short num = (short)726350713;
				short num2 = num;
				num = (short)554384249;
				switch (num2 == num)
				{
				}
				num = (short)1020723201;
				if (num != 0)
				{
				}
				num = (short)844627968;
				if (num != 0)
				{
				}
				num = (short)2010185728;
				short num3 = num;
				this.btnPortableTopButtonLongPressTime.UIValue = value;
			}
		}

		// Token: 0x17004859 RID: 18521
		// (get) Token: 0x06008F47 RID: 36679 RVA: 0x0087296C File Offset: 0x00870B6C
		public global::AcpBusinessLayer.AcpCustomRangeField BtnPortableTopButtonLongPressTime
		{
			get
			{
				short num = (short)1998983426;
				short num2 = num;
				num = (short)519835906;
				switch (num2 == num)
				{
				}
				num = (short)1934753793;
				if (num != 0)
				{
				}
				num = (short)1855848448;
				if (num != 0)
				{
				}
				num = (short)991494144;
				short num3 = num;
				return this.btnPortableTopButtonLongPressTime;
			}
		}

		// Token: 0x1700485A RID: 18522
		// (get) Token: 0x06008F48 RID: 36680 RVA: 0x00872A1C File Offset: 0x00870C1C
		// (set) Token: 0x06008F49 RID: 36681 RVA: 0x00872AD4 File Offset: 0x00870CD4
		public bool BtnPortableTopButtonLongPressTime_Applicable
		{
			get
			{
				short num = (short)925564929;
				if (num != 0)
				{
				}
				num = (short)1637924316;
				short num2 = num;
				num = (short)752008668;
				switch (num2 == num)
				{
				}
				num = (short)505610240;
				if (num != 0)
				{
				}
				num = (short)735051776;
				short num3 = num;
				return this.btnPortableTopButtonLongPressTime.Applicable;
			}
			set
			{
				short num = (short)1990695833;
				short num2 = num;
				num = (short)1458740121;
				switch (num2 == num)
				{
				}
				num = (short)1873215488;
				if (num != 0)
				{
				}
				num = (short)214433793;
				if (num != 0)
				{
				}
				num = (short)2008350720;
				short num3 = num;
				this.btnPortableTopButtonLongPressTime.Applicable = value;
			}
		}

		// Token: 0x1700485B RID: 18523
		// (get) Token: 0x06008F4A RID: 36682 RVA: 0x00872B8C File Offset: 0x00870D8C
		// (set) Token: 0x06008F4B RID: 36683 RVA: 0x00872C3C File Offset: 0x00870E3C
		public bool BtnPortableTopButtonLongPressTime_Valid
		{
			get
			{
				short num = (short)2138754798;
				short num2 = num;
				num = (short)1292160750;
				switch (num2 == num)
				{
				}
				num = (short)85655553;
				if (num != 0)
				{
				}
				num = (short)884867072;
				if (num != 0)
				{
				}
				num = (short)815005696;
				short num3 = num;
				return this.btnPortableTopButtonLongPressTime.Valid;
			}
			set
			{
				short num = (short)629800961;
				if (num != 0)
				{
				}
				num = (short)1914142598;
				short num2 = num;
				num = (short)2067562374;
				switch (num2 == num)
				{
				}
				num = (short)305659904;
				if (num != 0)
				{
				}
				num = (short)1290665984;
				short num3 = num;
				this.btnPortableTopButtonLongPressTime.Valid = value;
			}
		}

		// Token: 0x1700485C RID: 18524
		// (get) Token: 0x06008F4C RID: 36684 RVA: 0x00872CF4 File Offset: 0x00870EF4
		// (set) Token: 0x06008F4D RID: 36685 RVA: 0x00872DA8 File Offset: 0x00870FA8
		public bool BtnPortableTopButtonLongPressTime_Visible
		{
			get
			{
				short num = (short)1931466631;
				short num2 = num;
				num = (short)2102450055;
				switch (num2 == num)
				{
				}
				num = (short)1784348673;
				if (num != 0)
				{
				}
				num = (short)129499136;
				if (num != 0)
				{
				}
				num = (short)1134821376;
				short num3 = num;
				return this.btnPortableTopButtonLongPressTime.Visible;
			}
			set
			{
				short num = (short)1972305921;
				if (num != 0)
				{
				}
				num = (short)1847184426;
				short num2 = num;
				num = (short)2029046826;
				switch (num2 == num)
				{
				}
				num = (short)1140129792;
				if (num != 0)
				{
				}
				num = (short)1628110848;
				short num3 = num;
				this.btnPortableTopButtonLongPressTime.Visible = value;
			}
		}

		// Token: 0x1700485D RID: 18525
		// (get) Token: 0x06008F4E RID: 36686 RVA: 0x00872E5C File Offset: 0x0087105C
		// (set) Token: 0x06008F4F RID: 36687 RVA: 0x00872F10 File Offset: 0x00871110
		public bool BtnPortableTopButtonLongPressTime_Editable
		{
			get
			{
				short num = (short)1696241487;
				short num2 = num;
				num = (short)1102354255;
				switch (num2 == num)
				{
				}
				num = (short)1847394304;
				if (num != 0)
				{
				}
				num = (short)443285505;
				if (num != 0)
				{
				}
				num = (short)944701440;
				short num3 = num;
				return this.btnPortableTopButtonLongPressTime.Editable;
			}
			set
			{
				short num = (short)41667495;
				short num2 = num;
				num = (short)974965671;
				switch (num2 == num)
				{
				}
				num = (short)1097334784;
				if (num != 0)
				{
				}
				num = (short)466223105;
				if (num != 0)
				{
				}
				num = (short)1601306624;
				short num3 = num;
				this.btnPortableTopButtonLongPressTime.Editable = value;
			}
		}

		// Token: 0x1700485E RID: 18526
		// (get) Token: 0x06008F50 RID: 36688 RVA: 0x00872FC4 File Offset: 0x008711C4
		internal string BtnPortableTopButtonLongPressTime_UILabel
		{
			get
			{
				short num = (short)569573377;
				if (num != 0)
				{
				}
				num = (short)1721034795;
				short num2 = num;
				num = (short)2018371627;
				switch (num2 == num)
				{
				}
				num = (short)1723924480;
				if (num != 0)
				{
				}
				num = (short)84344832;
				short num3 = num;
				return this.btnPortableTopButtonLongPressTime.UIName;
			}
		}

		// Token: 0x1700485F RID: 18527
		// (get) Token: 0x06008F51 RID: 36689 RVA: 0x0087307C File Offset: 0x0087127C
		// (set) Token: 0x06008F52 RID: 36690 RVA: 0x00873130 File Offset: 0x00871330
		internal bool BtnPortableTopButtonLongPressTime_HiddenStatic
		{
			get
			{
				short num = (short)890264139;
				short num2 = num;
				num = (short)927816267;
				switch (num2 == num)
				{
				}
				num = (short)499253248;
				if (num != 0)
				{
				}
				num = (short)516685825;
				if (num != 0)
				{
				}
				num = (short)1284833280;
				short num3 = num;
				return this.btnPortableTopButtonLongPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)582898484;
				short num2 = num;
				num = (short)1808487220;
				switch (num2 == num)
				{
				}
				num = (short)2144927745;
				if (num != 0)
				{
				}
				num = (short)1789329408;
				if (num != 0)
				{
				}
				num = (short)1733951488;
				short num3 = num;
				this.btnPortableTopButtonLongPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x17004860 RID: 18528
		// (get) Token: 0x06008F53 RID: 36691 RVA: 0x008731E8 File Offset: 0x008713E8
		// (set) Token: 0x06008F54 RID: 36692 RVA: 0x0087329C File Offset: 0x0087149C
		internal bool BtnPortableTopButtonLongPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)92461479;
				short num2 = num;
				num = (short)1556732327;
				switch (num2 == num)
				{
				}
				num = (short)1328676865;
				if (num != 0)
				{
				}
				num = (short)1987575808;
				short num3 = num;
				num = (short)240517120;
				if (num != 0)
				{
				}
				return this.btnPortableTopButtonLongPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)1130436637;
				short num2 = num;
				num = (short)1823348765;
				switch (num2 == num)
				{
				}
				num = (short)417988609;
				if (num != 0)
				{
				}
				num = (short)542507008;
				short num3 = num;
				num = (short)2135293952;
				if (num != 0)
				{
				}
				this.btnPortableTopButtonLongPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x17004861 RID: 18529
		// (get) Token: 0x06008F55 RID: 36693 RVA: 0x00873354 File Offset: 0x00871554
		public bool BtnlPortableTopButtonLongPressTime_HasDiffs
		{
			get
			{
				short num = (short)6590618;
				short num2 = num;
				num = (short)531206298;
				switch (num2 == num)
				{
				}
				num = (short)1133576193;
				if (num != 0)
				{
				}
				num = (short)875495424;
				short num3 = num;
				num = (short)1091829760;
				if (num != 0)
				{
				}
				return this.btnPortableTopButtonLongPressTime._HasDiffs;
			}
		}

		// Token: 0x17004862 RID: 18530
		// (get) Token: 0x06008F56 RID: 36694 RVA: 0x00873408 File Offset: 0x00871608
		// (set) Token: 0x06008F57 RID: 36695 RVA: 0x008734C0 File Offset: 0x008716C0
		public int BtnTopButtonShortPressTimeValue
		{
			get
			{
				short num = (short)647561217;
				if (num != 0)
				{
				}
				num = (short)1038532585;
				short num2 = num;
				num = (short)1605222377;
				switch (num2 == num)
				{
				}
				num = (short)821297152;
				short num3 = num;
				num = (short)190447616;
				if (num != 0)
				{
				}
				return this.btnTopButtonShortPressTime.Value;
			}
			set
			{
				short num = (short)931927934;
				short num2 = num;
				num = (short)1238833022;
				switch (num2 == num)
				{
				}
				num = (short)1174208513;
				if (num != 0)
				{
				}
				num = (short)781582336;
				short num3 = num;
				num = (short)762249216;
				if (num != 0)
				{
				}
				this.btnTopButtonShortPressTime.Value = value;
			}
		}

		// Token: 0x17004863 RID: 18531
		// (get) Token: 0x06008F58 RID: 36696 RVA: 0x00873578 File Offset: 0x00871778
		// (set) Token: 0x06008F59 RID: 36697 RVA: 0x00873628 File Offset: 0x00871828
		public string BtnTopButtonShortPressTime_UIValue
		{
			get
			{
				short num = (short)1229524530;
				short num2 = num;
				num = (short)1930694194;
				switch (num2 == num)
				{
				}
				num = (short)1207042048;
				if (num != 0)
				{
				}
				num = (short)2008416256;
				short num3 = num;
				num = (short)112918529;
				if (num != 0)
				{
				}
				return this.btnTopButtonShortPressTime.UIValue;
			}
			set
			{
				short num = (short)1424424961;
				if (num != 0)
				{
				}
				num = (short)413331896;
				short num2 = num;
				num = (short)1607266744;
				switch (num2 == num)
				{
				}
				num = (short)842006528;
				short num3 = num;
				num = (short)890109952;
				if (num != 0)
				{
				}
				this.btnTopButtonShortPressTime.UIValue = value;
			}
		}

		// Token: 0x17004864 RID: 18532
		// (get) Token: 0x06008F5A RID: 36698 RVA: 0x008736DC File Offset: 0x008718DC
		public global::AcpBusinessLayer.AcpSimpleRangeField BtnTopButtonShortPressTime
		{
			get
			{
				short num = (short)557630208;
				short num2 = num;
				num = (short)642040576;
				switch (num2 == num)
				{
				}
				num = (short)1735196673;
				if (num != 0)
				{
				}
				num = (short)1939931136;
				short num3 = num;
				num = (short)449511424;
				if (num != 0)
				{
				}
				return this.btnTopButtonShortPressTime;
			}
		}

		// Token: 0x17004865 RID: 18533
		// (get) Token: 0x06008F5B RID: 36699 RVA: 0x0087378C File Offset: 0x0087198C
		// (set) Token: 0x06008F5C RID: 36700 RVA: 0x00873844 File Offset: 0x00871A44
		internal int BtnTopButtonShortPressTimeMin
		{
			get
			{
				short num = (short)453543730;
				short num2 = num;
				num = (short)929335090;
				switch (num2 == num)
				{
				}
				num = (short)330825729;
				if (num != 0)
				{
				}
				num = (short)401408000;
				short num3 = num;
				num = (short)424345600;
				if (num != 0)
				{
				}
				return this.btnTopButtonShortPressTime.Min;
			}
			set
			{
				short num = (short)1866989569;
				if (num != 0)
				{
				}
				num = (short)1900909016;
				short num2 = num;
				num = (short)327848408;
				switch (num2 == num)
				{
				}
				num = (short)158072832;
				short num3 = num;
				num = (short)267124736;
				if (num != 0)
				{
				}
				this.btnTopButtonShortPressTime.Min = value;
			}
		}

		// Token: 0x17004866 RID: 18534
		// (get) Token: 0x06008F5D RID: 36701 RVA: 0x008738FC File Offset: 0x00871AFC
		// (set) Token: 0x06008F5E RID: 36702 RVA: 0x008739B0 File Offset: 0x00871BB0
		internal int BtnTopButtonShortPressTimeMax
		{
			get
			{
				short num = (short)1309886697;
				short num2 = num;
				num = (short)760170729;
				switch (num2 == num)
				{
				}
				num = (short)1472528384;
				if (num != 0)
				{
				}
				num = (short)1956577280;
				short num3 = num;
				num = (short)76218369;
				if (num != 0)
				{
				}
				return this.btnTopButtonShortPressTime.Max;
			}
			set
			{
				short num = (short)2614941;
				short num2 = num;
				num = (short)861267613;
				switch (num2 == num)
				{
				}
				num = (short)422772737;
				if (num != 0)
				{
				}
				num = (short)890306560;
				short num3 = num;
				num = (short)39059456;
				if (num != 0)
				{
				}
				this.btnTopButtonShortPressTime.Max = value;
			}
		}

		// Token: 0x17004867 RID: 18535
		// (get) Token: 0x06008F5F RID: 36703 RVA: 0x00873A64 File Offset: 0x00871C64
		// (set) Token: 0x06008F60 RID: 36704 RVA: 0x00873B18 File Offset: 0x00871D18
		internal int BtnTopButtonShortPressTimeStep
		{
			get
			{
				short num = (short)1136697455;
				short num2 = num;
				num = (short)41525359;
				switch (num2 == num)
				{
				}
				num = (short)776536065;
				if (num != 0)
				{
				}
				num = (short)78184448;
				short num3 = num;
				num = (short)1481703424;
				if (num != 0)
				{
				}
				return this.btnTopButtonShortPressTime.StepSize;
			}
			set
			{
				short num = (short)428494690;
				short num2 = num;
				num = (short)1710116706;
				switch (num2 == num)
				{
				}
				num = (short)2125135872;
				if (num != 0)
				{
				}
				num = (short)1518403584;
				short num3 = num;
				num = (short)1659174913;
				if (num != 0)
				{
				}
				this.btnTopButtonShortPressTime.StepSize = value;
			}
		}

		// Token: 0x17004868 RID: 18536
		// (get) Token: 0x06008F61 RID: 36705 RVA: 0x00873BCC File Offset: 0x00871DCC
		// (set) Token: 0x06008F62 RID: 36706 RVA: 0x00873C80 File Offset: 0x00871E80
		public bool BtnTopButtonShortPressTime_Applicable
		{
			get
			{
				short num = (short)1551630337;
				if (num != 0)
				{
				}
				num = (short)1114157448;
				short num2 = num;
				num = (short)1408283016;
				switch (num2 == num)
				{
				}
				num = (short)1176829952;
				short num3 = num;
				num = (short)26542080;
				if (num != 0)
				{
				}
				return this.btnTopButtonShortPressTime.Applicable;
			}
			set
			{
				short num = (short)1912226709;
				short num2 = num;
				num = (short)1884046229;
				switch (num2 == num)
				{
				}
				num = (short)1807089665;
				if (num != 0)
				{
				}
				num = (short)433127424;
				short num3 = num;
				num = (short)922157056;
				if (num != 0)
				{
				}
				this.btnTopButtonShortPressTime.Applicable = value;
			}
		}

		// Token: 0x17004869 RID: 18537
		// (get) Token: 0x06008F63 RID: 36707 RVA: 0x00873D34 File Offset: 0x00871F34
		// (set) Token: 0x06008F64 RID: 36708 RVA: 0x00873DEC File Offset: 0x00871FEC
		public bool BtnTopButtonShortPressTime_Valid
		{
			get
			{
				short num = (short)1301179023;
				short num2 = num;
				num = (short)1655007887;
				switch (num2 == num)
				{
				}
				num = (short)1647116288;
				if (num != 0)
				{
				}
				num = (short)2120876032;
				short num3 = num;
				num = (short)2424833;
				if (num != 0)
				{
				}
				return this.btnTopButtonShortPressTime.Valid;
			}
			set
			{
				short num = (short)2004987431;
				short num2 = num;
				num = (short)932556327;
				switch (num2 == num)
				{
				}
				num = (short)667615233;
				if (num != 0)
				{
				}
				num = (short)1086521344;
				short num3 = num;
				num = (short)1130364928;
				if (num != 0)
				{
				}
				this.btnTopButtonShortPressTime.Valid = value;
			}
		}

		// Token: 0x1700486A RID: 18538
		// (get) Token: 0x06008F65 RID: 36709 RVA: 0x00873EA0 File Offset: 0x008720A0
		// (set) Token: 0x06008F66 RID: 36710 RVA: 0x00873F58 File Offset: 0x00872158
		public bool BtnTopButtonShortPressTime_Visible
		{
			get
			{
				short num = (short)1577181139;
				short num2 = num;
				num = (short)973791187;
				switch (num2 == num)
				{
				}
				num = (short)1032454144;
				if (num != 0)
				{
				}
				num = (short)627310592;
				short num3 = num;
				num = (short)1755054081;
				if (num != 0)
				{
				}
				return this.btnTopButtonShortPressTime.Visible;
			}
			set
			{
				short num = (short)1192718927;
				short num2 = num;
				num = (short)1806332495;
				switch (num2 == num)
				{
				}
				num = (short)1983905793;
				if (num != 0)
				{
				}
				num = (short)55902208;
				short num3 = num;
				num = (short)1774452736;
				if (num != 0)
				{
				}
				this.btnTopButtonShortPressTime.Visible = value;
			}
		}

		// Token: 0x1700486B RID: 18539
		// (get) Token: 0x06008F67 RID: 36711 RVA: 0x00874010 File Offset: 0x00872210
		// (set) Token: 0x06008F68 RID: 36712 RVA: 0x008740C8 File Offset: 0x008722C8
		public bool BtnTopButtonShortPressTime_Editable
		{
			get
			{
				short num = (short)1471057428;
				short num2 = num;
				num = (short)1139838484;
				switch (num2 == num)
				{
				}
				num = (short)450625537;
				if (num != 0)
				{
				}
				num = (short)251265024;
				short num3 = num;
				num = (short)48496640;
				if (num != 0)
				{
				}
				return this.btnTopButtonShortPressTime.Editable;
			}
			set
			{
				short num = (short)1719791699;
				short num2 = num;
				num = (short)858517587;
				switch (num2 == num)
				{
				}
				num = (short)714735617;
				if (num != 0)
				{
				}
				num = (short)1312751616;
				short num3 = num;
				num = (short)586350592;
				if (num != 0)
				{
				}
				this.btnTopButtonShortPressTime.Editable = value;
			}
		}

		// Token: 0x1700486C RID: 18540
		// (get) Token: 0x06008F69 RID: 36713 RVA: 0x0087417C File Offset: 0x0087237C
		internal string BtnTopButtonShortPressTime_UILabel
		{
			get
			{
				short num = (short)1344929793;
				if (num != 0)
				{
				}
				num = (short)36100532;
				short num2 = num;
				num = (short)1620629940;
				switch (num2 == num)
				{
				}
				num = (short)1956970496;
				short num3 = num;
				num = (short)1560281088;
				if (num != 0)
				{
				}
				return this.btnTopButtonShortPressTime.UIName;
			}
		}

		// Token: 0x1700486D RID: 18541
		// (get) Token: 0x06008F6A RID: 36714 RVA: 0x00874230 File Offset: 0x00872430
		// (set) Token: 0x06008F6B RID: 36715 RVA: 0x008742E8 File Offset: 0x008724E8
		internal bool BtnTopButtonShortPressTime_HiddenStatic
		{
			get
			{
				short num = (short)104792065;
				if (num != 0)
				{
				}
				num = (short)1545826697;
				short num2 = num;
				num = (short)672690569;
				switch (num2 == num)
				{
				}
				num = (short)1104674816;
				short num3 = num;
				num = (short)954073088;
				if (num != 0)
				{
				}
				return this.btnTopButtonShortPressTime.HiddenStatic;
			}
			set
			{
				short num = (short)1722263208;
				short num2 = num;
				num = (short)1951901352;
				switch (num2 == num)
				{
				}
				num = (short)375128065;
				if (num != 0)
				{
				}
				num = (short)1061289984;
				short num3 = num;
				num = (short)2008481792;
				if (num != 0)
				{
				}
				this.btnTopButtonShortPressTime.HiddenStatic = value;
			}
		}

		// Token: 0x1700486E RID: 18542
		// (get) Token: 0x06008F6C RID: 36716 RVA: 0x0087439C File Offset: 0x0087259C
		// (set) Token: 0x06008F6D RID: 36717 RVA: 0x00874450 File Offset: 0x00872650
		internal bool BtnTopButtonShortPressTime_HiddenDynamic
		{
			get
			{
				short num = (short)1546753981;
				short num2 = num;
				num = (short)2141624253;
				switch (num2 == num)
				{
				}
				num = (short)1195835393;
				if (num != 0)
				{
				}
				num = (short)915406848;
				short num3 = num;
				num = (short)1718812672;
				if (num != 0)
				{
				}
				return this.btnTopButtonShortPressTime.HiddenDynamic;
			}
			set
			{
				short num = (short)1290666074;
				short num2 = num;
				num = (short)1261895770;
				switch (num2 == num)
				{
				}
				num = (short)1962934272;
				if (num != 0)
				{
				}
				num = (short)1091108864;
				short num3 = num;
				num = (short)606142465;
				if (num != 0)
				{
				}
				this.btnTopButtonShortPressTime.HiddenDynamic = value;
			}
		}

		// Token: 0x1700486F RID: 18543
		// (get) Token: 0x06008F6E RID: 36718 RVA: 0x00874504 File Offset: 0x00872704
		public bool BtnTopButtonShortPressTime_HasDiffs
		{
			get
			{
				short num = (short)378496944;
				short num2 = num;
				num = (short)1885956016;
				switch (num2 == num)
				{
				}
				num = (short)573702144;
				if (num != 0)
				{
				}
				num = (short)1312817152;
				short num3 = num;
				num = (short)2032861185;
				if (num != 0)
				{
				}
				return this.btnTopButtonShortPressTime._HasDiffs;
			}
		}

		// Token: 0x17004870 RID: 18544
		// (get) Token: 0x06008F6F RID: 36719 RVA: 0x008745B8 File Offset: 0x008727B8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1451812138;
				short num2 = num;
				num = (short)2092492074;
				switch (num2 == num)
				{
				}
				num = (short)1633288192;
				if (num != 0)
				{
				}
				num = (short)851705856;
				short num3 = num;
				num = (short)1239154689;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x17004871 RID: 18545
		// (get) Token: 0x06008F70 RID: 36720 RVA: 0x00874678 File Offset: 0x00872878
		public global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches RefSwitches
		{
			get
			{
				short num = (short)1754722820;
				short num2 = num;
				num = (short)146338308;
				switch (num2 == num)
				{
				}
				num = (short)1855913985;
				if (num != 0)
				{
				}
				num = (short)1069547520;
				short num3 = num;
				num = (short)1156317184;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2038)[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
			}
		}

		// Token: 0x17004872 RID: 18546
		// (get) Token: 0x06008F71 RID: 36721 RVA: 0x00874734 File Offset: 0x00872934
		public global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems RefMenuItems
		{
			get
			{
				short num = (short)1135746653;
				short num2 = num;
				num = (short)1700798045;
				switch (num2 == num)
				{
				}
				num = (short)650379264;
				if (num != 0)
				{
				}
				num = (short)1550254080;
				short num3 = num;
				num = (short)1200488449;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2088)[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
			}
		}

		// Token: 0x17004873 RID: 18547
		// (get) Token: 0x06008F72 RID: 36722 RVA: 0x008747F0 File Offset: 0x008729F0
		public global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide RefEmergencyWide
		{
			get
			{
				short num = (short)1502373964;
				short num2 = num;
				num = (short)1987995724;
				switch (num2 == num)
				{
				}
				num = (short)449118208;
				if (num != 0)
				{
				}
				num = (short)1024655360;
				short num3 = num;
				num = (short)1704198145;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2032)[0] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide;
			}
		}

		// Token: 0x17004874 RID: 18548
		// (get) Token: 0x06008F73 RID: 36723 RVA: 0x008748AC File Offset: 0x00872AAC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)821297153;
				if (num != 0)
				{
				}
				num = (short)983048355;
				short num2 = num;
				num = (short)269426851;
				switch (num2 == num)
				{
				}
				num = (short)1434779648;
				short num3 = num;
				num = (short)1527119872;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x06008F74 RID: 36724 RVA: 0x0087496C File Offset: 0x00872B6C
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
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1222311939;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)1677459460;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					return result;
				case 3:
				{
					num2 = (short)1583415297;
					if (num2 != 0)
					{
					}
					num2 = (short)1464467456;
					short num3 = num2;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1129185282;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					num2 = (short)2101149696;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return result;
			for (;;)
			{
				IL_24:
				result = null;
				num2 = (short)192577478;
				short num4 = num2;
				num2 = (short)1657176006;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_5B;
				}
			}
			IL_5B:
			num2 = (short)1271398400;
			if (num2 != 0)
			{
			}
			num2 = (short)2002452481;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400477D RID: 18301
		private global::AcpBusinessLayer.AcpListField btnGeneralConventionalBCO_A19543;

		// Token: 0x0400477E RID: 18302
		private global::AcpBusinessLayer.AcpListField btnTrunkingPortableTrunkingBCO_A19545;

		// Token: 0x0400477F RID: 18303
		private global::AcpBusinessLayer.AcpKeyField btnPortableButtonKey_A22557;

		// Token: 0x04004780 RID: 18304
		private global::AcpBusinessLayer.AcpField<string> btnPortableButtonName_A22558;

		// Token: 0x04004781 RID: 18305
		private global::AcpBusinessLayer.AcpListField btnGeneralConventionalFeature_A19544;

		// Token: 0x04004782 RID: 18306
		private global::AcpBusinessLayer.AcpListField btnTrunkingPortableButtonFeature_A19546;

		// Token: 0x04004783 RID: 18307
		private global::AcpBusinessLayer.AcpCustomRangeField btnPortableTopButtonLongPressTime;

		// Token: 0x04004784 RID: 18308
		private global::AcpBusinessLayer.AcpSimpleRangeField btnTopButtonShortPressTime;
	}
}
