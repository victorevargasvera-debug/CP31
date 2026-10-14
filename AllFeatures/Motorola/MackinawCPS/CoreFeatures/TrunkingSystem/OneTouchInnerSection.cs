using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x0200009F RID: 159
	[global::System.Serializable]
	public class OneTouchInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060011FF RID: 4607 RVA: 0x001132D0 File Offset: 0x001114D0
		public OneTouchInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x001132EC File Offset: 0x001114EC
		protected OneTouchInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00113304 File Offset: 0x00111504
		public override void Init()
		{
			int a_ = 0;
			short num = (short)536477696;
			short num2 = num;
			num = (short)309737030;
			short num3 = num;
			num = (short)999831110;
			switch (num3 == num)
			{
			}
			num = (short)694550528;
			if (num != 0)
			{
			}
			num = (short)414187521;
			if (num != 0)
			{
			}
			this.trkSysOneTouchFeature_A8614 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.indexTrkSysOneTouchFeature_A8614LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.idTrkSysOneTouchFeature_A8614LovStrs), this, global::AllFeatures.CodeplugGuid.b("闀뇂껄铆냈룊苌ꇎ듐蟒뫔ꋖ뫘돚鯜뫞胠韢郤闦賨듪곬ퟮ쟰싲쇴", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysOneTouchFeature_A8614LovStrs);
			this.trkSysOneTouchFeature_A8614.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysOneTouchFeature_A8614.DataTransferOrder = 89;
			this.trkSysOneTouchButton_A19763 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("闀뇂껄铆냈룊苌ꇎ듐蟒뫔ꋖ뫘돚鿜꫞闠韢諤触뛨ꫪ\udcec훮웰엲웴", a_), global::CommonResources.AcgResources.ID_BUTTON, 100);
			this.trkSysOneTouchButton_A19763.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysOneTouchButton_A19763.DataTransferOrder = -1;
			this.trkSysOneTouchIndex_A8618 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄铆냈룊苌ꇎ듐蟒뫔ꋖ뫘돚铜뇞藠蛢鷤룦꣨폪\udbec\udeee짰", a_), global::CommonResources.AcgResources.ID_INDEX, 1, 100, null, null, 0, 1);
			this.trkSysOneTouchIndex_A8618.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysOneTouchIndex_A8618.DataTransferOrder = 67;
			this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("闀뇂껄铆냈룊苌ꇎ듐蟒뫔ꋖ뫘돚鳜뷞菠釢胤釦胨諪駬諮闰볲鯴鋶그铺裼鳾椀䈂椄渆栈砊刌与⤐┒✔┖", a_), global::CommonResources.AcgResources.ID_ABBREVIATEDONETOUCHALIAS, 4);
			this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.DataTransferOrder = 90;
			this.trkSysOneTouchIndex_A8618.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闀뇂냄꧆ꋈꋊꏌ꣎鳒믔닖律迚닜꫞苠询", a_);
			base.Id = 10166;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGONETOUCH;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x001134FC File Offset: 0x001116FC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 16;
			short num = (short)221773829;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)728301575;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚鋜뇞蓠럢諤鋦諨菪곬跮鏰臲郴臶郸髺觼髾攀䰂欄戆崈搊砌氎礐划礔縖砘栚䈜帞ᤠᔢᜤᔦ", a_), global::CommonResources.AcgResources.ID_ABBREVIATEDONETOUCHALIAS, 4);
					this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.DataTransferOrder = 90;
					num = (short)1510211592;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)961282048;
					short num3 = num;
					this.trkSysOneTouchFeature_A8614 = new global::AcpBusinessLayer.AcpSparseLOVField(38, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.indexTrkSysOneTouchFeature_A8614LovStrs, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.idTrkSysOneTouchFeature_A8614LovStrs), this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚鋜뇞蓠럢諤鋦諨菪꯬諮郰蟲胴藶鳸ꓺ볼쟾㜀㈂㄄", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysOneTouchFeature_A8614LovStrs);
					this.trkSysOneTouchFeature_A8614.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysOneTouchFeature_A8614.DataTransferOrder = 89;
					num = (short)1949040646;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_2B1;
				case 4:
				{
					if (producerFields == null)
					{
						goto IL_41B;
					}
					num = (short)1816558190;
					short num4 = num;
					num = (short)1421179502;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2B1;
					default:
						num = (short)362676224;
						if (num != 0)
						{
						}
						num = (short)1538719744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_6E;
					}
					continue;
				case 6:
					goto IL_337;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚鋜뇞蓠럢諤鋦諨菪꯬諮郰蟲胴藶鳸ꓺ볼쟾㜀㈂㄄", a_)))
					{
						num = (short)1426718722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_337;
				case 8:
					goto IL_332;
				case 9:
					goto IL_199;
				case 10:
					num = (short)838598660;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					this.trkSysOneTouchButton_A19763 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚鋜뇞蓠럢諤鋦諨菪꿬髮藰蟲髴駶꛸뫺쳼웾㘀㔂㘄", a_), global::CommonResources.AcgResources.ID_BUTTON, 100);
					this.trkSysOneTouchButton_A19763.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysOneTouchButton_A19763.DataTransferOrder = -1;
					num = (short)1037238287;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚鋜뇞蓠럢諤鋦諨菪ꓬ臮闰雲跴ꣶ룸쏺쯼컾㤀", a_)))
					{
						num = (short)79888387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_199;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚鋜뇞蓠럢諤鋦諨菪꿬髮藰蟲髴駶꛸뫺쳼웾㘀㔂㘄", a_)))
					{
						num = (short)1379139595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26A;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚鋜뇞蓠럢諤鋦諨菪곬跮鏰臲郴臶郸髺觼髾攀䰂欄戆崈搊砌氎礐划礔縖砘栚䈜帞ᤠᔢᜤᔦ", a_)))
					{
						num = (short)1554776065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_41B;
				case 15:
					goto IL_26A;
				}
				IL_6E:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1965031434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_199:
				num = (short)1609695246;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_26A:
				num = (short)1022427148;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B1:
				num = (short)1956904961;
				if (num != 0)
				{
				}
				this.trkSysOneTouchIndex_A8618 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("藐ꇒ뻔蓖ꃘ꣚鋜뇞蓠럢諤鋦諨菪ꓬ臮闰雲跴ꣶ룸쏺쯼컾㤀", a_), global::CommonResources.AcgResources.ID_INDEX, null, null, 0, 1);
				this.trkSysOneTouchIndex_A8618.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
				this.trkSysOneTouchIndex_A8618.DataTransferOrder = 67;
				this.trkSysOneTouchIndex_A8618.ShowHexValue = false;
				num = (short)708968457;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_337:
				num = (short)2053439501;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_332:
			IL_41B:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藐ꇒꃔ맖님닚돜룞쇠곢诤苦짨뿪苬髮鋰鯲", a_);
			base.Id = 10166;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGONETOUCH;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x00113958 File Offset: 0x00111B58
		public override void PopulateReferences()
		{
			short num = (short)1989410816;
			short num2 = num;
			num = (short)1186660353;
			if (num != 0)
			{
			}
			num = (short)416648131;
			short num3 = num;
			num = (short)1438026691;
			switch (num3 == num)
			{
			}
			num = (short)777977856;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00113A04 File Offset: 0x00111C04
		public override void DropReferences()
		{
			short num = (short)110166016;
			short num2 = num;
			num = (short)586160747;
			short num3 = num;
			num = (short)1799756395;
			switch (num3 == num)
			{
			}
			num = (short)1506279424;
			if (num != 0)
			{
			}
			num = (short)131334145;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00113AB0 File Offset: 0x00111CB0
		public override void SetConstraints()
		{
			short num = (short)100401152;
			short num2 = num;
			num = (short)1821080886;
			short num3 = num;
			num = (short)163126;
			switch (num3 == num)
			{
			}
			num = (short)1602289665;
			if (num != 0)
			{
			}
			num = (short)1627389952;
			if (num != 0)
			{
			}
			this.trkSysOneTouchFeature_A8614.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.conOneTchBtnIsStsAndStsAlsIsEnOrMsgAndMsgAlsEnAndTrkSysTypeNotAstro25OrNotStsOrMsg);
			this.trkSysOneTouchButton_A19763.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.trkSysOneTouchIndex_A8618.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConOneTouchBtnIsNotSetToDisabled);
			this.trkSysOneTouchIndex_A8618.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConIsTrkOneTouchIndexValid);
			this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConIsTrkSysOneTouchAbbreviatedOneTouchAlias);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00113BCC File Offset: 0x00111DCC
		public override void SetupDependencies()
		{
			short num = (short)1291649024;
			short num2 = num;
			num = (short)613113741;
			short num3 = num;
			num = (short)1575313293;
			switch (num3 == num)
			{
			}
			num = (short)1526267905;
			if (num != 0)
			{
			}
			num = (short)1338114048;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
			trunkingSystem.StatusAlias.TrkSysStatusAliasStatusAliasEnable_A9195.AddDependentObject(this.trkSysOneTouchFeature_A8614);
			trunkingSystem.MessageAlias.TrkSysMessageAliasMessageAliasEnable_A8505.AddDependentObject(this.trkSysOneTouchFeature_A8614);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysOneTouchFeature_A8614);
			this.RefDisplayAndMenu.Advanced.RadioErgDispAdvanceStatusAutoExit_42158.AddDependentObject(this.trkSysOneTouchFeature_A8614);
			this.RefRadioErgonomicsWide.HomeMode.RadErgoWideHomeModeHomeModeSelection_A8202.AddDependentObject(this.trkSysOneTouchFeature_A8614);
			this.RefDisplayAndMenu.Advanced.RadErgoWideDispMenu_A21430.AddDependentObject(this.trkSysOneTouchFeature_A8614);
			this.trkSysOneTouchFeature_A8614.AddDependentObject(this.trkSysOneTouchIndex_A8618);
			trunkingSystem.General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysOneTouchIndex_A8618);
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06001207 RID: 4615 RVA: 0x00113D4C File Offset: 0x00111F4C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1154416640;
				short num2 = num;
				num = (short)2010841089;
				if (num != 0)
				{
				}
				num = (short)333559418;
				short num3 = num;
				num = (short)1086436986;
				switch (num3 == num)
				{
				}
				num = (short)642121728;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06001208 RID: 4616 RVA: 0x00113DFC File Offset: 0x00111FFC
		// (set) Token: 0x06001209 RID: 4617 RVA: 0x00113EB0 File Offset: 0x001120B0
		public int TrkSysOneTouchFeature_A8614Value
		{
			get
			{
				short num = (short)1778843648;
				short num2 = num;
				num = (short)1468825148;
				short num3 = num;
				num = (short)1010138684;
				switch (num3 == num)
				{
				}
				num = (short)2073231360;
				if (num != 0)
				{
				}
				num = (short)1847328769;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchFeature_A8614.Value;
			}
			set
			{
				short num = (short)9437184;
				short num2 = num;
				num = (short)1511390640;
				short num3 = num;
				num = (short)2082667952;
				switch (num3 == num)
				{
				}
				num = (short)570228736;
				if (num != 0)
				{
				}
				num = (short)1466564609;
				if (num != 0)
				{
				}
				this.trkSysOneTouchFeature_A8614.Value = value;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x00113F68 File Offset: 0x00112168
		// (set) Token: 0x0600120B RID: 4619 RVA: 0x0011401C File Offset: 0x0011221C
		public string TrkSysOneTouchFeature_A8614_UIValue
		{
			get
			{
				short num = (short)412745728;
				short num2 = num;
				num = (short)1904520434;
				short num3 = num;
				num = (short)2001775858;
				switch (num3 == num)
				{
				}
				num = (short)250937345;
				if (num != 0)
				{
				}
				num = (short)515375104;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchFeature_A8614.UIValue;
			}
			set
			{
				short num = (short)518651904;
				short num2 = num;
				num = (short)248276513;
				short num3 = num;
				num = (short)622290465;
				switch (num3 == num)
				{
				}
				num = (short)1971257345;
				if (num != 0)
				{
				}
				num = (short)1211695104;
				if (num != 0)
				{
				}
				this.trkSysOneTouchFeature_A8614.UIValue = value;
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x001140D0 File Offset: 0x001122D0
		public global::AcpBusinessLayer.AcpListField TrkSysOneTouchFeature_A8614
		{
			get
			{
				short num = (short)1226506240;
				short num2 = num;
				num = (short)1130359710;
				short num3 = num;
				num = (short)1320414110;
				switch (num3 == num)
				{
				}
				num = (short)301924353;
				if (num != 0)
				{
				}
				num = (short)235798528;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchFeature_A8614;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x00114180 File Offset: 0x00112380
		// (set) Token: 0x0600120E RID: 4622 RVA: 0x00114234 File Offset: 0x00112434
		public bool TrkSysOneTouchFeature_A8614_Applicable
		{
			get
			{
				short num = (short)69140480;
				short num2 = num;
				num = (short)1687381276;
				short num3 = num;
				num = (short)626287900;
				switch (num3 == num)
				{
				}
				num = (short)1588396033;
				if (num != 0)
				{
				}
				num = (short)834600960;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchFeature_A8614.Applicable;
			}
			set
			{
				short num = (short)1893531648;
				short num2 = num;
				num = (short)746374085;
				short num3 = num;
				num = (short)1984545733;
				switch (num3 == num)
				{
				}
				num = (short)1356005376;
				if (num != 0)
				{
				}
				num = (short)1839726593;
				if (num != 0)
				{
				}
				this.trkSysOneTouchFeature_A8614.Applicable = value;
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x0600120F RID: 4623 RVA: 0x001142E8 File Offset: 0x001124E8
		// (set) Token: 0x06001210 RID: 4624 RVA: 0x001143A0 File Offset: 0x001125A0
		public bool TrkSysOneTouchFeature_A8614_Valid
		{
			get
			{
				short num = (short)672987285;
				short num2 = num;
				num = (short)1668544661;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1239482368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1338834945;
				if (num != 0)
				{
				}
				num = (short)500432896;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchFeature_A8614.Valid;
			}
			set
			{
				short num = (short)460494825;
				short num2 = num;
				num = (short)356947945;
				switch (num2 == num)
				{
				default:
				{
					num = (short)273088512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1819934720;
				if (num != 0)
				{
				}
				num = (short)1444413441;
				if (num != 0)
				{
				}
				this.trkSysOneTouchFeature_A8614.Valid = value;
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001211 RID: 4625 RVA: 0x00114458 File Offset: 0x00112658
		// (set) Token: 0x06001212 RID: 4626 RVA: 0x0011450C File Offset: 0x0011270C
		public bool TrkSysOneTouchFeature_A8614_Visible
		{
			get
			{
				short num = (short)1442660969;
				short num2 = num;
				num = (short)606814825;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1754005504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1307770881;
				if (num != 0)
				{
				}
				num = (short)1817378816;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchFeature_A8614.Visible;
			}
			set
			{
				short num = (short)1451950081;
				if (num != 0)
				{
				}
				num = (short)1413414912;
				short num2 = num;
				num = (short)570195713;
				short num3 = num;
				num = (short)703561473;
				switch (num3 == num)
				{
				}
				num = (short)783745024;
				if (num != 0)
				{
				}
				this.trkSysOneTouchFeature_A8614.Visible = value;
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001213 RID: 4627 RVA: 0x001145C0 File Offset: 0x001127C0
		// (set) Token: 0x06001214 RID: 4628 RVA: 0x00114674 File Offset: 0x00112874
		public bool TrkSysOneTouchFeature_A8614_Editable
		{
			get
			{
				short num = (short)1933836747;
				short num2 = num;
				num = (short)1401225675;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2074673152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1328873472;
				if (num != 0)
				{
				}
				num = (short)1341980673;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchFeature_A8614.Editable;
			}
			set
			{
				short num = (short)1851114001;
				short num2 = num;
				num = (short)843301393;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1470496768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)48627713;
				if (num != 0)
				{
				}
				num = (short)91815936;
				if (num != 0)
				{
				}
				this.trkSysOneTouchFeature_A8614.Editable = value;
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x00114728 File Offset: 0x00112928
		internal string TrkSysOneTouchFeature_A8614_UILabel
		{
			get
			{
				short num = (short)1227809269;
				short num2 = num;
				num = (short)391569909;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1515126784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1031864321;
				if (num != 0)
				{
				}
				num = (short)1542717440;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchFeature_A8614.UIName;
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06001216 RID: 4630 RVA: 0x001147DC File Offset: 0x001129DC
		// (set) Token: 0x06001217 RID: 4631 RVA: 0x00114890 File Offset: 0x00112A90
		internal bool TrkSysOneTouchFeature_A8614_HiddenStatic
		{
			get
			{
				short num = (short)1199831373;
				short num2 = num;
				num = (short)151976269;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1189806080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1512898561;
				if (num != 0)
				{
				}
				num = (short)106561536;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchFeature_A8614.HiddenStatic;
			}
			set
			{
				short num = (short)324287607;
				short num2 = num;
				num = (short)1321090167;
				switch (num2 == num)
				{
				default:
				{
					num = (short)594214912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)560136193;
				if (num != 0)
				{
				}
				num = (short)13762560;
				if (num != 0)
				{
				}
				this.trkSysOneTouchFeature_A8614.HiddenStatic = value;
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06001218 RID: 4632 RVA: 0x00114948 File Offset: 0x00112B48
		// (set) Token: 0x06001219 RID: 4633 RVA: 0x00114A00 File Offset: 0x00112C00
		internal bool TrkSysOneTouchFeature_A8614_HiddenDynamic
		{
			get
			{
				short num = (short)488395979;
				short num2 = num;
				num = (short)551179467;
				switch (num2 == num)
				{
				default:
				{
					num = (short)586350592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)560529409;
				if (num != 0)
				{
				}
				num = (short)1822556160;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchFeature_A8614.HiddenDynamic;
			}
			set
			{
				short num = (short)401494546;
				short num2 = num;
				num = (short)968774162;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1281818624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1980366849;
				if (num != 0)
				{
				}
				num = (short)265355264;
				if (num != 0)
				{
				}
				this.trkSysOneTouchFeature_A8614.HiddenDynamic = value;
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x0600121A RID: 4634 RVA: 0x00114AB8 File Offset: 0x00112CB8
		public bool TrkSysOneTouchFeature_A8614_HasDiffs
		{
			get
			{
				short num = (short)613154817;
				if (num != 0)
				{
				}
				num = (short)1295646720;
				short num2 = num;
				num = (short)1817744121;
				short num3 = num;
				num = (short)107909881;
				switch (num3 == num)
				{
				}
				num = (short)42139648;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchFeature_A8614._HasDiffs;
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x00114B6C File Offset: 0x00112D6C
		// (set) Token: 0x0600121C RID: 4636 RVA: 0x00114C20 File Offset: 0x00112E20
		public string TrkSysOneTouchButton_A19763Value
		{
			get
			{
				short num = (short)386968979;
				short num2 = num;
				num = (short)324971923;
				switch (num2 == num)
				{
				default:
				{
					num = (short)781778944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)660144129;
				if (num != 0)
				{
				}
				num = (short)393543680;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchButton_A19763.Value;
			}
			set
			{
				short num = (short)1817444353;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)2000364277;
					short num3 = num;
					num = (short)249897717;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1216413696;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_E7;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_7A;
							}
							continue;
						case 2:
							num = (short)1146290177;
							if (num != 0)
							{
							}
							this.trkSysOneTouchButton_A19763.Value = value;
							num = (short)1719926784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					IL_7A:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)1062600706;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E7:
				num = (short)857735168;
				short num4 = num;
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x0600121D RID: 4637 RVA: 0x00114D40 File Offset: 0x00112F40
		// (set) Token: 0x0600121E RID: 4638 RVA: 0x00114DF8 File Offset: 0x00112FF8
		public string TrkSysOneTouchButton_A19763_UIValue
		{
			get
			{
				short num = (short)1993509860;
				short num2 = num;
				num = (short)1428261860;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1515782144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)756613121;
				if (num != 0)
				{
				}
				num = (short)2056126464;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchButton_A19763.Value;
			}
			set
			{
				short num = (short)147060260;
				short num2 = num;
				num = (short)1813706276;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1807679488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)728563713;
				if (num != 0)
				{
				}
				num = (short)1003421696;
				if (num != 0)
				{
				}
				this.trkSysOneTouchButton_A19763.Value = value;
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x0600121F RID: 4639 RVA: 0x00114EB0 File Offset: 0x001130B0
		public global::AcpBusinessLayer.AcpKeyField TrkSysOneTouchButton_A19763
		{
			get
			{
				short num = (short)765383364;
				short num2 = num;
				num = (short)1061671620;
				switch (num2 == num)
				{
				default:
				{
					num = (short)113442816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)793116672;
				if (num != 0)
				{
				}
				num = (short)162136065;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchButton_A19763;
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06001220 RID: 4640 RVA: 0x00114F60 File Offset: 0x00113160
		// (set) Token: 0x06001221 RID: 4641 RVA: 0x00115014 File Offset: 0x00113214
		public bool TrkSysOneTouchButton_A19763_Applicable
		{
			get
			{
				short num = (short)215483061;
				short num2 = num;
				num = (short)1165755061;
				switch (num2 == num)
				{
				default:
				{
					num = (short)609419264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)385679361;
				if (num != 0)
				{
				}
				num = (short)493486080;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchButton_A19763.Applicable;
			}
			set
			{
				short num = (short)738716647;
				short num2 = num;
				num = (short)820177895;
				switch (num2 == num)
				{
				default:
				{
					num = (short)24707072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)908787713;
				if (num != 0)
				{
				}
				num = (short)603717632;
				if (num != 0)
				{
				}
				this.trkSysOneTouchButton_A19763.Applicable = value;
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x06001222 RID: 4642 RVA: 0x001150CC File Offset: 0x001132CC
		// (set) Token: 0x06001223 RID: 4643 RVA: 0x00115180 File Offset: 0x00113380
		public bool TrkSysOneTouchButton_A19763_Valid
		{
			get
			{
				short num = (short)1733216443;
				short num2 = num;
				num = (short)11323579;
				switch (num2 == num)
				{
				default:
				{
					num = (short)426180608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2100166657;
				if (num != 0)
				{
				}
				num = (short)1494810624;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchButton_A19763.Valid;
			}
			set
			{
				short num = (short)1138440844;
				short num2 = num;
				num = (short)673331852;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1044971520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)450756609;
				if (num != 0)
				{
				}
				num = (short)459407360;
				if (num != 0)
				{
				}
				this.trkSysOneTouchButton_A19763.Valid = value;
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06001224 RID: 4644 RVA: 0x00115238 File Offset: 0x00113438
		// (set) Token: 0x06001225 RID: 4645 RVA: 0x001152EC File Offset: 0x001134EC
		public bool TrkSysOneTouchButton_A19763_Visible
		{
			get
			{
				short num = (short)2115239937;
				if (num != 0)
				{
				}
				num = (short)742457344;
				short num2 = num;
				num = (short)674644984;
				short num3 = num;
				num = (short)1131758584;
				switch (num3 == num)
				{
				}
				num = (short)1081606144;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchButton_A19763.Visible;
			}
			set
			{
				short num = (short)1860600495;
				short num2 = num;
				num = (short)1324647087;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1516896256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1881538561;
				if (num != 0)
				{
				}
				num = (short)855048192;
				if (num != 0)
				{
				}
				this.trkSysOneTouchButton_A19763.Visible = value;
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06001226 RID: 4646 RVA: 0x001153A4 File Offset: 0x001135A4
		// (set) Token: 0x06001227 RID: 4647 RVA: 0x00115458 File Offset: 0x00113658
		public bool TrkSysOneTouchButton_A19763_Editable
		{
			get
			{
				short num = (short)786315829;
				short num2 = num;
				num = (short)2063809077;
				switch (num2 == num)
				{
				default:
				{
					num = (short)16973824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1898315777;
				if (num != 0)
				{
				}
				num = (short)776339456;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchButton_A19763.Editable;
			}
			set
			{
				short num = (short)1909790295;
				short num2 = num;
				num = (short)1599739479;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1591934976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2132017153;
				if (num != 0)
				{
				}
				num = (short)1648820224;
				if (num != 0)
				{
				}
				this.trkSysOneTouchButton_A19763.Editable = value;
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x00115510 File Offset: 0x00113710
		internal string TrkSysOneTouchButton_A19763_UILabel
		{
			get
			{
				short num = (short)501522354;
				short num2 = num;
				num = (short)1917951922;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1064697856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)275251200;
				if (num != 0)
				{
				}
				num = (short)418512897;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchButton_A19763.UIName;
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06001229 RID: 4649 RVA: 0x001155C4 File Offset: 0x001137C4
		// (set) Token: 0x0600122A RID: 4650 RVA: 0x00115678 File Offset: 0x00113878
		internal bool TrkSysOneTouchButton_A19763_HiddenStatic
		{
			get
			{
				short num = (short)735349176;
				short num2 = num;
				num = (short)2058717624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)699269120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)151126017;
				if (num != 0)
				{
				}
				num = (short)742785024;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchButton_A19763.HiddenStatic;
			}
			set
			{
				short num = (short)972881921;
				if (num != 0)
				{
				}
				num = (short)1198194688;
				short num2 = num;
				num = (short)166259619;
				short num3 = num;
				num = (short)668199843;
				switch (num3 == num)
				{
				}
				num = (short)251002880;
				if (num != 0)
				{
				}
				this.trkSysOneTouchButton_A19763.HiddenStatic = value;
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x0600122B RID: 4651 RVA: 0x0011572C File Offset: 0x0011392C
		// (set) Token: 0x0600122C RID: 4652 RVA: 0x001157E0 File Offset: 0x001139E0
		internal bool TrkSysOneTouchButton_A19763_HiddenDynamic
		{
			get
			{
				short num = (short)557756598;
				short num2 = num;
				num = (short)586264758;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1481113600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1162084353;
				if (num != 0)
				{
				}
				num = (short)1016332288;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchButton_A19763.HiddenDynamic;
			}
			set
			{
				short num = (short)655876752;
				short num2 = num;
				num = (short)1709433488;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1246887936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)581238785;
				if (num != 0)
				{
				}
				num = (short)1425014784;
				if (num != 0)
				{
				}
				this.trkSysOneTouchButton_A19763.HiddenDynamic = value;
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x0011589C File Offset: 0x00113A9C
		public bool TrkSysOneTouchButton_A19763_HasDiffs
		{
			get
			{
				short num = (short)1318578308;
				short num2 = num;
				num = (short)1373759620;
				switch (num2 == num)
				{
				default:
				{
					num = (short)719978496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1158414337;
				if (num != 0)
				{
				}
				num = (short)482344960;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchButton_A19763._HasDiffs;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x0600122E RID: 4654 RVA: 0x00115954 File Offset: 0x00113B54
		// (set) Token: 0x0600122F RID: 4655 RVA: 0x00115A08 File Offset: 0x00113C08
		public int TrkSysOneTouchIndex_A8618Value
		{
			get
			{
				short num = (short)1062696858;
				short num2 = num;
				num = (short)537950106;
				switch (num2 == num)
				{
				default:
				{
					num = (short)253493248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1431830529;
				if (num != 0)
				{
				}
				num = (short)769261568;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchIndex_A8618.Value;
			}
			set
			{
				short num = (short)546152205;
				short num2 = num;
				num = (short)1566023437;
				switch (num2 == num)
				{
				default:
				{
					num = (short)954662912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1865416705;
				if (num != 0)
				{
				}
				num = (short)979894272;
				if (num != 0)
				{
				}
				this.trkSysOneTouchIndex_A8618.Value = value;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x06001230 RID: 4656 RVA: 0x00115AC0 File Offset: 0x00113CC0
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkSysOneTouchIndex_A8618
		{
			get
			{
				short num = (short)1557004289;
				if (num != 0)
				{
				}
				num = (short)345899008;
				short num2 = num;
				num = (short)72379938;
				short num3 = num;
				num = (short)2144890402;
				switch (num3 == num)
				{
				}
				num = (short)498466816;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchIndex_A8618;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06001231 RID: 4657 RVA: 0x00115B70 File Offset: 0x00113D70
		// (set) Token: 0x06001232 RID: 4658 RVA: 0x00115C24 File Offset: 0x00113E24
		public string TrkSysOneTouchIndex_A8618_UIValue
		{
			get
			{
				short num = (short)150601729;
				if (num != 0)
				{
				}
				num = (short)911605760;
				short num2 = num;
				num = (short)1814493522;
				short num3 = num;
				num = (short)556464466;
				switch (num3 == num)
				{
				}
				num = (short)1828716544;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchIndex_A8618.UIValue;
			}
			set
			{
				short num = (short)1662058497;
				if (num != 0)
				{
				}
				num = (short)964296704;
				short num2 = num;
				num = (short)984220070;
				short num3 = num;
				num = (short)598081958;
				switch (num3 == num)
				{
				}
				num = (short)523501568;
				if (num != 0)
				{
				}
				this.trkSysOneTouchIndex_A8618.UIValue = value;
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06001233 RID: 4659 RVA: 0x00115CDC File Offset: 0x00113EDC
		// (set) Token: 0x06001234 RID: 4660 RVA: 0x00115D90 File Offset: 0x00113F90
		internal int TrkSysOneTouchIndex_A8618Min
		{
			get
			{
				short num = (short)1362680995;
				short num2 = num;
				num = (short)595451043;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1275527168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)417726464;
				if (num != 0)
				{
				}
				num = (short)1662517249;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchIndex_A8618.Min;
			}
			set
			{
				short num = (short)1236066528;
				short num2 = num;
				num = (short)26534112;
				switch (num2 == num)
				{
				default:
				{
					num = (short)952238080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)716898304;
				if (num != 0)
				{
				}
				num = (short)1284571137;
				if (num != 0)
				{
				}
				this.trkSysOneTouchIndex_A8618.Min = value;
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x00115E48 File Offset: 0x00114048
		// (set) Token: 0x06001236 RID: 4662 RVA: 0x00115EFC File Offset: 0x001140FC
		internal int TrkSysOneTouchIndex_A8618Max
		{
			get
			{
				short num = (short)994861113;
				short num2 = num;
				num = (short)1394761785;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1964244992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1474691073;
				if (num != 0)
				{
				}
				num = (short)1539964928;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchIndex_A8618.Max;
			}
			set
			{
				short num = (short)1836778202;
				short num2 = num;
				num = (short)1956774618;
				switch (num2 == num)
				{
				default:
				{
					num = (short)746192896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1019740161;
				if (num != 0)
				{
				}
				num = (short)1606352896;
				if (num != 0)
				{
				}
				this.trkSysOneTouchIndex_A8618.Max = value;
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001237 RID: 4663 RVA: 0x00115FB0 File Offset: 0x001141B0
		// (set) Token: 0x06001238 RID: 4664 RVA: 0x00116064 File Offset: 0x00114264
		internal int TrkSysOneTouchIndex_A8618Step
		{
			get
			{
				short num = (short)993816115;
				short num2 = num;
				num = (short)404319795;
				switch (num2 == num)
				{
				default:
				{
					num = (short)405536768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1515520001;
				if (num != 0)
				{
				}
				num = (short)1862991872;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchIndex_A8618.StepSize;
			}
			set
			{
				short num = (short)1020148985;
				short num2 = num;
				num = (short)1745501433;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1395851264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)332857345;
				if (num != 0)
				{
				}
				num = (short)1440874496;
				if (num != 0)
				{
				}
				this.trkSysOneTouchIndex_A8618.StepSize = value;
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x0011611C File Offset: 0x0011431C
		// (set) Token: 0x0600123A RID: 4666 RVA: 0x001161D0 File Offset: 0x001143D0
		public bool TrkSysOneTouchIndex_A8618_Applicable
		{
			get
			{
				short num = (short)1558183937;
				if (num != 0)
				{
				}
				num = (short)1692598272;
				short num2 = num;
				num = (short)720256502;
				short num3 = num;
				num = (short)28589558;
				switch (num3 == num)
				{
				}
				num = (short)252051456;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchIndex_A8618.Applicable;
			}
			set
			{
				short num = (short)669726456;
				short num2 = num;
				num = (short)279459576;
				switch (num2 == num)
				{
				default:
				{
					num = (short)992149504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1303511041;
				if (num != 0)
				{
				}
				num = (short)1861615616;
				if (num != 0)
				{
				}
				this.trkSysOneTouchIndex_A8618.Applicable = value;
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x00116280 File Offset: 0x00114480
		// (set) Token: 0x0600123C RID: 4668 RVA: 0x00116338 File Offset: 0x00114538
		public bool TrkSysOneTouchIndex_A8618_Valid
		{
			get
			{
				short num = (short)1107347544;
				short num2 = num;
				num = (short)253610072;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2078408704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1504051201;
				if (num != 0)
				{
				}
				num = (short)2049441792;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchIndex_A8618.Valid;
			}
			set
			{
				short num = (short)890694205;
				short num2 = num;
				num = (short)444525117;
				switch (num2 == num)
				{
				default:
				{
					num = (short)620625920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)601686017;
				if (num != 0)
				{
				}
				num = (short)1537015808;
				if (num != 0)
				{
				}
				this.trkSysOneTouchIndex_A8618.Valid = value;
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x001163F0 File Offset: 0x001145F0
		// (set) Token: 0x0600123E RID: 4670 RVA: 0x001164A4 File Offset: 0x001146A4
		public bool TrkSysOneTouchIndex_A8618_Visible
		{
			get
			{
				short num = (short)680636922;
				short num2 = num;
				num = (short)1501999610;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1577451520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)468123649;
				if (num != 0)
				{
				}
				num = (short)438829056;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchIndex_A8618.Visible;
			}
			set
			{
				short num = (short)1156223877;
				short num2 = num;
				num = (short)843879301;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1132658688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1292697601;
				if (num != 0)
				{
				}
				num = (short)1356595200;
				if (num != 0)
				{
				}
				this.trkSysOneTouchIndex_A8618.Visible = value;
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x0011655C File Offset: 0x0011475C
		// (set) Token: 0x06001240 RID: 4672 RVA: 0x00116610 File Offset: 0x00114810
		public bool TrkSysOneTouchIndex_A8618_Editable
		{
			get
			{
				short num = (short)284488279;
				short num2 = num;
				num = (short)1939010135;
				switch (num2 == num)
				{
				default:
				{
					num = (short)618987520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)594018305;
				if (num != 0)
				{
				}
				num = (short)335216640;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchIndex_A8618.Editable;
			}
			set
			{
				short num = (short)643106699;
				short num2 = num;
				num = (short)1647052683;
				switch (num2 == num)
				{
				}
				num = (short)92864513;
				if (num != 0)
				{
				}
				num = (short)1968373760;
				short num3 = num;
				num = (short)969015296;
				if (num != 0)
				{
				}
				this.trkSysOneTouchIndex_A8618.Editable = value;
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x001166C4 File Offset: 0x001148C4
		internal string TrkSysOneTouchIndex_A8618_UILabel
		{
			get
			{
				short num = (short)352246317;
				short num2 = num;
				num = (short)1720900141;
				switch (num2 == num)
				{
				}
				num = (short)1443561472;
				if (num != 0)
				{
				}
				num = (short)533331968;
				short num3 = num;
				num = (short)1672216577;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchIndex_A8618.UIName;
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x00116774 File Offset: 0x00114974
		// (set) Token: 0x06001243 RID: 4675 RVA: 0x00116828 File Offset: 0x00114A28
		internal bool TrkSysOneTouchIndex_A8618_HiddenStatic
		{
			get
			{
				short num = (short)256009068;
				short num2 = num;
				num = (short)1551721324;
				switch (num2 == num)
				{
				}
				num = (short)371261441;
				if (num != 0)
				{
				}
				num = (short)1798373376;
				short num3 = num;
				num = (short)360054784;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchIndex_A8618.HiddenStatic;
			}
			set
			{
				short num = (short)1598685111;
				short num2 = num;
				num = (short)209321911;
				switch (num2 == num)
				{
				}
				num = (short)772407296;
				if (num != 0)
				{
				}
				num = (short)1550254080;
				short num3 = num;
				num = (short)658767873;
				if (num != 0)
				{
				}
				this.trkSysOneTouchIndex_A8618.HiddenStatic = value;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x001168DC File Offset: 0x00114ADC
		// (set) Token: 0x06001245 RID: 4677 RVA: 0x0011698C File Offset: 0x00114B8C
		internal bool TrkSysOneTouchIndex_A8618_HiddenDynamic
		{
			get
			{
				short num = (short)13933664;
				short num2 = num;
				num = (short)1597283424;
				switch (num2 == num)
				{
				}
				num = (short)1907818496;
				if (num != 0)
				{
				}
				num = (short)1519190016;
				short num3 = num;
				num = (short)1729036289;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchIndex_A8618.HiddenDynamic;
			}
			set
			{
				short num = (short)926744577;
				if (num != 0)
				{
				}
				num = (short)1167427897;
				short num2 = num;
				num = (short)6916409;
				switch (num2 == num)
				{
				}
				num = (short)280363008;
				short num3 = num;
				num = (short)1678639104;
				if (num != 0)
				{
				}
				this.trkSysOneTouchIndex_A8618.HiddenDynamic = value;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x00116A44 File Offset: 0x00114C44
		public bool TrkSysOneTouchIndex_A8618_HasDiffs
		{
			get
			{
				short num = (short)772453532;
				short num2 = num;
				num = (short)2052699292;
				switch (num2 == num)
				{
				}
				num = (short)69926913;
				if (num != 0)
				{
				}
				num = (short)419299328;
				short num3 = num;
				num = (short)132120576;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchIndex_A8618._HasDiffs;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x00116AFC File Offset: 0x00114CFC
		// (set) Token: 0x06001248 RID: 4680 RVA: 0x00116BB4 File Offset: 0x00114DB4
		public string TrkSysOneTouchAbbreviatedOneTouchAlias_A8622Value
		{
			get
			{
				short num = (short)1473320249;
				short num2 = num;
				num = (short)1729566009;
				switch (num2 == num)
				{
				}
				num = (short)2054684673;
				if (num != 0)
				{
				}
				num = (short)1120731136;
				short num3 = num;
				num = (short)1349124096;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.Value;
			}
			set
			{
				short num = (short)1176504371;
				short num2 = num;
				num = (short)767297587;
				switch (num2 == num)
				{
				}
				num = (short)90505217;
				if (num != 0)
				{
				}
				num = (short)1970143232;
				short num3 = num;
				num = (short)1304952832;
				if (num != 0)
				{
				}
				this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.Value = value;
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x00116C68 File Offset: 0x00114E68
		public global::AcpBusinessLayer.AcpField<string> TrkSysOneTouchAbbreviatedOneTouchAlias_A8622
		{
			get
			{
				short num = (short)558524585;
				short num2 = num;
				num = (short)1332177065;
				switch (num2 == num)
				{
				}
				num = (short)834797568;
				if (num != 0)
				{
				}
				num = (short)1935802368;
				short num3 = num;
				num = (short)2093678593;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622;
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x00116D18 File Offset: 0x00114F18
		// (set) Token: 0x0600124B RID: 4683 RVA: 0x00116DCC File Offset: 0x00114FCC
		public string TkSysOneTouchAbbreviatedOneTouchAlias_A8622
		{
			get
			{
				short num = (short)1582366721;
				if (num != 0)
				{
				}
				num = (short)856908313;
				short num2 = num;
				num = (short)392454681;
				switch (num2 == num)
				{
				}
				num = (short)2107899904;
				short num3 = num;
				num = (short)1657995264;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.Value;
			}
			set
			{
				short num = (short)568408153;
				short num2 = num;
				num = (short)1623472217;
				switch (num2 == num)
				{
				}
				num = (short)613154816;
				if (num != 0)
				{
				}
				num = (short)1170538496;
				short num3 = num;
				num = (short)2032074753;
				if (num != 0)
				{
				}
				this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.Value = value;
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x00116E84 File Offset: 0x00115084
		// (set) Token: 0x0600124D RID: 4685 RVA: 0x00116F38 File Offset: 0x00115138
		public bool TrkSysOneTouchAbbreviatedOneTouchAlias_A8622_Applicable
		{
			get
			{
				short num = (short)768276050;
				short num2 = num;
				num = (short)244315730;
				switch (num2 == num)
				{
				}
				num = (short)1674706945;
				if (num != 0)
				{
				}
				num = (short)1130627072;
				short num3 = num;
				num = (short)922353664;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.Applicable;
			}
			set
			{
				short num = (short)1587759255;
				short num2 = num;
				num = (short)1962363031;
				switch (num2 == num)
				{
				}
				num = (short)837550081;
				if (num != 0)
				{
				}
				num = (short)426639360;
				short num3 = num;
				num = (short)1982791680;
				if (num != 0)
				{
				}
				this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.Applicable = value;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x00116FE8 File Offset: 0x001151E8
		// (set) Token: 0x0600124F RID: 4687 RVA: 0x0011709C File Offset: 0x0011529C
		public bool TrkSysOneTouchAbbreviatedOneTouchAlias_A8622_Valid
		{
			get
			{
				short num = (short)1452693991;
				short num2 = num;
				num = (short)1889098215;
				switch (num2 == num)
				{
				}
				num = (short)226361345;
				if (num != 0)
				{
				}
				num = (short)1397751808;
				short num3 = num;
				num = (short)1430781952;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.Valid;
			}
			set
			{
				short num = (short)1190985729;
				if (num != 0)
				{
				}
				num = (short)892693575;
				short num2 = num;
				num = (short)1462987847;
				switch (num2 == num)
				{
				}
				num = (short)430637056;
				short num3 = num;
				num = (short)1163657216;
				if (num != 0)
				{
				}
				this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.Valid = value;
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x00117154 File Offset: 0x00115354
		// (set) Token: 0x06001251 RID: 4689 RVA: 0x00117204 File Offset: 0x00115404
		public bool TrkSysOneTouchAbbreviatedOneTouchAlias_A8622_Visible
		{
			get
			{
				short num = (short)1521932920;
				short num2 = num;
				num = (short)536861304;
				switch (num2 == num)
				{
				}
				num = (short)60162049;
				if (num != 0)
				{
				}
				num = (short)1328283648;
				short num3 = num;
				num = (short)1007484928;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.Visible;
			}
			set
			{
				short num = (short)528085996;
				short num2 = num;
				num = (short)68482028;
				switch (num2 == num)
				{
				}
				num = (short)89849856;
				if (num != 0)
				{
				}
				num = (short)1989148672;
				short num3 = num;
				num = (short)1103822849;
				if (num != 0)
				{
				}
				this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.Visible = value;
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x001172BC File Offset: 0x001154BC
		// (set) Token: 0x06001253 RID: 4691 RVA: 0x00117370 File Offset: 0x00115570
		public bool TrkSysOneTouchAbbreviatedOneTouchAlias_A8622_Editable
		{
			get
			{
				short num = (short)2068397937;
				short num2 = num;
				num = (short)2020425585;
				switch (num2 == num)
				{
				}
				num = (short)639107073;
				if (num != 0)
				{
				}
				num = (short)1440808960;
				short num3 = num;
				num = (short)198836224;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.Editable;
			}
			set
			{
				short num = (short)1458973091;
				short num2 = num;
				num = (short)600779171;
				switch (num2 == num)
				{
				}
				num = (short)1872822273;
				if (num != 0)
				{
				}
				num = (short)2066939904;
				short num3 = num;
				num = (short)1200816128;
				if (num != 0)
				{
				}
				this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.Editable = value;
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x00117428 File Offset: 0x00115628
		internal string TrkSysOneTouchAbbreviatedOneTouchAlias_A8622_UILabel
		{
			get
			{
				short num = (short)1055099453;
				short num2 = num;
				num = (short)1173916221;
				switch (num2 == num)
				{
				}
				num = (short)1198456833;
				if (num != 0)
				{
				}
				num = (short)1130496000;
				short num3 = num;
				num = (short)757530624;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.UIName;
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x001174DC File Offset: 0x001156DC
		// (set) Token: 0x06001256 RID: 4694 RVA: 0x00117590 File Offset: 0x00115790
		internal bool TrkSysOneTouchAbbreviatedOneTouchAlias_A8622_A19664_HiddenStatic
		{
			get
			{
				short num = (short)1473059200;
				short num2 = num;
				num = (short)1988696448;
				switch (num2 == num)
				{
				}
				num = (short)1503526913;
				if (num != 0)
				{
				}
				num = (short)948961280;
				short num3 = num;
				num = (short)1511456768;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.HiddenStatic;
			}
			set
			{
				short num = (short)861598180;
				short num2 = num;
				num = (short)1969877476;
				switch (num2 == num)
				{
				}
				num = (short)835059712;
				if (num != 0)
				{
				}
				num = (short)1986199552;
				short num3 = num;
				num = (short)953417729;
				if (num != 0)
				{
				}
				this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.HiddenStatic = value;
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x00117644 File Offset: 0x00115844
		// (set) Token: 0x06001258 RID: 4696 RVA: 0x001176F8 File Offset: 0x001158F8
		internal bool CnvPerOneTouchAbbreviatedOneTouchAlias_A19664_HiddenDynamic
		{
			get
			{
				short num = (short)2124939265;
				if (num != 0)
				{
				}
				num = (short)1574543995;
				short num2 = num;
				num = (short)895853179;
				switch (num2 == num)
				{
				}
				num = (short)1751908352;
				short num3 = num;
				num = (short)1173487616;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.HiddenDynamic;
			}
			set
			{
				short num = (short)1721100557;
				short num2 = num;
				num = (short)424667405;
				switch (num2 == num)
				{
				}
				num = (short)1976893440;
				if (num != 0)
				{
				}
				num = (short)191954944;
				short num3 = num;
				num = (short)1826816001;
				if (num != 0)
				{
				}
				this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622.HiddenDynamic = value;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x001177AC File Offset: 0x001159AC
		public bool TrkSysOneTouchAbbreviatedOneTouchAlias_A8622_HasDiffs
		{
			get
			{
				short num = (short)1914329736;
				short num2 = num;
				num = (short)2004769416;
				switch (num2 == num)
				{
				}
				num = (short)80871425;
				if (num != 0)
				{
				}
				num = (short)1320157184;
				short num3 = num;
				num = (short)1329397760;
				if (num != 0)
				{
				}
				return this.trkSysOneTouchAbbreviatedOneTouchAlias_A8622._HasDiffs;
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x0011785C File Offset: 0x00115A5C
		public global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu RefDisplayAndMenu
		{
			get
			{
				short num = (short)949616641;
				if (num != 0)
				{
				}
				num = (short)2093809042;
				short num2 = num;
				num = (short)476511634;
				switch (num2 == num)
				{
				}
				num = (short)2080047104;
				short num3 = num;
				num = (short)1126891520;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2010)[0] as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu;
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x00117918 File Offset: 0x00115B18
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)809240065;
				short num2 = num;
				num = (short)691734017;
				switch (num2 == num)
				{
				}
				num = (short)2013528064;
				if (num != 0)
				{
				}
				num = (short)887750656;
				short num3 = num;
				num = (short)242679809;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x001179D8 File Offset: 0x00115BD8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						if (base.ParentRecset.ContainerDoc == null)
						{
							return result;
						}
						num2 = (short)1348291511;
						short num3 = num2;
						num2 = (short)1320176567;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_26;
						default:
							num2 = (short)2053177344;
							if (num2 != 0)
							{
							}
							num2 = (short)172097539;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						if (base.ParentRecset != null)
						{
							num2 = (short)785448960;
							short num4 = num2;
							num2 = (short)277741570;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 2:
						num2 = (short)1411907585;
						if (num2 != 0)
						{
						}
						num2 = (short)289341440;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)230752260;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						return result;
					}
					goto IL_24;
				}
				return result;
			}
			IL_24:
			result = null;
			IL_26:
			num2 = (short)143327233;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000450 RID: 1104
		private global::AcpBusinessLayer.AcpListField trkSysOneTouchFeature_A8614;

		// Token: 0x04000451 RID: 1105
		private global::AcpBusinessLayer.AcpKeyField trkSysOneTouchButton_A19763;

		// Token: 0x04000452 RID: 1106
		private global::AcpBusinessLayer.AcpSimpleRangeField trkSysOneTouchIndex_A8618;

		// Token: 0x04000453 RID: 1107
		private global::AcpBusinessLayer.AcpField<string> trkSysOneTouchAbbreviatedOneTouchAlias_A8622;
	}
}
