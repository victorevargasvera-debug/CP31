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

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000385 RID: 901
	[global::System.Serializable]
	public class ResponseSelectorListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600847B RID: 33915 RVA: 0x007B0080 File Offset: 0x007AE280
		public ResponseSelectorListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600847C RID: 33916 RVA: 0x007B009C File Offset: 0x007AE29C
		protected ResponseSelectorListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600847D RID: 33917 RVA: 0x007B00B4 File Offset: 0x007AE2B4
		public override void Init()
		{
			int a_ = 10;
			short num = (short)127283749;
			short num2 = num;
			num = (short)590688805;
			switch (num2 == num)
			{
			}
			num = (short)2030370817;
			if (num != 0)
			{
			}
			num = (short)1611530240;
			if (num != 0)
			{
			}
			num = (short)1310064640;
			short num3 = num;
			this.cHO9PursuitKnobMode_A36683 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_MODE0, this, global::AllFeatures.CodeplugGuid.b("裊藌胎菒ꃔꗖ꫘껚드ꯞꫠ跢諤藦ꓨ蓪觬諮껰닲웴쇶쿸쏺컼", a_), global::CommonResources.AcgResources.ID_NAME, 100);
			this.cHO9PursuitKnobMode_A36683.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO9PursuitKnobMode_A36683.DataTransferOrder = -1;
			this.cHO9PursuitKnobAction_A36684 = new global::AcpBusinessLayer.AcpSparseLOVField(206, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexCHO9PursuitKnobAction_A36684LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idCHO9PursuitKnobAction_A36684LovStrs), this, global::AllFeatures.CodeplugGuid.b("裊藌胎菒ꃔꗖ꫘껚드ꯞꫠ跢諤藦꣨裪駬蛮黰鷲ꫴ뛶쫸췺쯼쟾㔀", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.CHO9PursuitKnobAction_A36684LovStrs);
			this.cHO9PursuitKnobAction_A36684.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO9PursuitKnobAction_A36684.DataTransferOrder = 4;
			this.cHO9PursuitKnobIndex_A36685 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("裊藌胎菒ꃔꗖ꫘껚드ꯞꫠ跢諤藦ꃨ藪觬諮觰곲듴쓶쿸췺염쫾", a_), global::CommonResources.AcgResources.ID_INDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.cHO9PursuitKnobIndex_A36685.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.cHO9PursuitKnobIndex_A36685.DataTransferOrder = 5;
			this.cHO9PursuitKnobSecondaryIndex_A36823 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("裊藌胎菒ꃔꗖ꫘껚드ꯞꫠ跢諤藦뫨軪軬胮鿰韲铴藶胸닺鏼鯾搀笂娄䘆㨈㴊㔌㴎∐", a_), global::CommonResources.AcgResources.ID_SECONDARYINDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.cHO9PursuitKnobSecondaryIndex_A36823.IgnoreOnCompare = true;
			this.cHO9PursuitKnobSecondaryIndex_A36823.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cHO9PursuitKnobSecondaryIndex_A36823.DataTransferOrder = -1;
			this.cHO9PursuitKnobTertiaryIndex_A37025 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("裊藌胎菒ꃔꗖ꫘껚드ꯞꫠ跢諤藦뷨軪鿬鯮飰鋲蟴軶냸闺駼髾礀専䐄㐆㸈㬊㼌㨎", a_), global::CommonResources.AcgResources.ID_TERTIARYINDEX, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.cHO9PursuitKnobTertiaryIndex_A37025.IgnoreOnCompare = true;
			this.cHO9PursuitKnobTertiaryIndex_A37025.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.cHO9PursuitKnobTertiaryIndex_A37025.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("駊꣌볎ꇐ볒믔ꓖ볘ﯚ軜뫞跠蛢蛤鏦蛨駪", a_);
			base.Id = 10625;
			base.UIName = global::CommonResources.AcgResources.ID_RESPONSESELECTOR;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600847E RID: 33918 RVA: 0x007B0324 File Offset: 0x007AE524
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)1816789007;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賎駐鳒蟖곘꧚껜꫞裠韢껤触蛨觪곬賮藰髲髴駶꛸뫺컼짾㜀㬂㄄", a_)))
					{
						num = (short)658898956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EA;
				case 1:
					goto IL_4C4;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賎駐鳒蟖곘꧚껜꫞裠韢껤触蛨觪ꓬ臮闰雲跴ꣶ룸죺쯼짾㤀㘂", a_)))
					{
						num = (short)233766930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9C;
				case 3:
					if (producerFields != null)
					{
						num = (short)1976762381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_510;
				case 4:
					this.cHO9PursuitKnobMode_A36683 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_MODE0, this, global::AllFeatures.CodeplugGuid.b("賎駐鳒蟖곘꧚껜꫞裠韢껤触蛨觪ꃬ胮闰雲ꫴ뛶쫸췺쯼쟾㈀", a_), global::CommonResources.AcgResources.ID_NAME, 100);
					this.cHO9PursuitKnobMode_A36683.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHO9PursuitKnobMode_A36683.DataTransferOrder = -1;
					num = (short)1727922177;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賎駐鳒蟖곘꧚껜꫞裠韢껤触蛨觪맬諮菰蟲鳴零诸苺듼釾攀昂約堆䠈㠊㨌㼎⌐☒", a_)))
					{
						num = (short)969932800;
						short num3 = num;
						num = (short)325386249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_510;
				case 6:
					goto IL_9C;
				case 7:
					this.cHO9PursuitKnobSecondaryIndex_A36823 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("賎駐鳒蟖곘꧚껜꫞裠韢껤触蛨觪뻬諮鋰鳲鯴鏶飸觺蓼뛾漀朂怄缆嘈䨊㸌㤎⤐ℒ☔", a_), global::CommonResources.AcgResources.ID_SECONDARYINDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.cHO9PursuitKnobSecondaryIndex_A36823.IgnoreOnCompare = true;
					this.cHO9PursuitKnobSecondaryIndex_A36823.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.cHO9PursuitKnobSecondaryIndex_A36823.DataTransferOrder = -1;
					num = (short)340131856;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賎駐鳒蟖곘꧚껜꫞裠韢껤触蛨觪ꃬ胮闰雲ꫴ뛶쫸췺쯼쟾㈀", a_)))
					{
						num = (short)962723844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4C4;
				case 9:
				{
					num = (short)1919019254;
					short num4 = num;
					num = (short)1308027126;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_233;
					default:
						num = (short)971571201;
						if (num != 0)
						{
						}
						num = (short)656343040;
						if (num != 0)
						{
						}
						this.cHO9PursuitKnobTertiaryIndex_A37025 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("賎駐鳒蟖곘꧚껜꫞裠韢껤触蛨觪맬諮菰蟲鳴零诸苺듼釾攀昂約堆䠈㠊㨌㼎⌐☒", a_), global::CommonResources.AcgResources.ID_TERTIARYINDEX, new string[]
						{
							global::CommonResources.AcgResources.ID_UNASSIGNED
						}, new int[1], true, false);
						this.cHO9PursuitKnobTertiaryIndex_A37025.IgnoreOnCompare = true;
						this.cHO9PursuitKnobTertiaryIndex_A37025.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.cHO9PursuitKnobTertiaryIndex_A37025.DataTransferOrder = -1;
						num = (short)1887174673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("賎駐鳒蟖곘꧚껜꫞裠韢껤触蛨觪뻬諮鋰鳲鯴鏶飸觺蓼뛾漀朂怄缆嘈䨊㸌㤎⤐ℒ☔", a_)))
					{
						num = (short)1146159111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_184;
				case 11:
					goto IL_EA;
				case 12:
					this.cHO9PursuitKnobAction_A36684 = new global::AcpBusinessLayer.AcpSparseLOVField(206, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.indexCHO9PursuitKnobAction_A36684LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.idCHO9PursuitKnobAction_A36684LovStrs), this, global::AllFeatures.CodeplugGuid.b("賎駐鳒蟖곘꧚껜꫞裠韢껤触蛨觪곬賮藰髲髴駶꛸뫺컼짾㜀㬂㄄", a_), global::CommonResources.AcgResources.ID_FEATURE, global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.LOVs.CHO9PursuitKnobAction_A36684LovStrs);
					this.cHO9PursuitKnobAction_A36684.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHO9PursuitKnobAction_A36684.DataTransferOrder = 4;
					num = (short)1695809547;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_233;
				case 14:
					num = (short)38862851;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					switch (0)
					{
					case 0:
						goto IL_79;
					}
					continue;
				case 16:
					goto IL_184;
				case 17:
					goto IL_391;
				case 18:
					this.cHO9PursuitKnobIndex_A36685 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("賎駐鳒蟖곘꧚껜꫞裠韢껤触蛨觪ꓬ臮闰雲跴ꣶ룸죺쯼짾㤀㘂", a_), global::CommonResources.AcgResources.ID_INDEX, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.cHO9PursuitKnobIndex_A36685.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.cHO9PursuitKnobIndex_A36685.DataTransferOrder = 5;
					num = (short)1012269062;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_79:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)986710030;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9C:
				num = (short)740032522;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EA:
				num = (short)1722023938;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_184:
				num = (short)897384453;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_233:
				num = (short)1099890696;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4C4:
				num = (short)1150025728;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_391:
			IL_510:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鷎듐ꃒꗔ룖럘꣚룜￞닠蛢觤苦諨鿪苬鷮", a_);
			base.Id = 10625;
			base.UIName = global::CommonResources.AcgResources.ID_RESPONSESELECTOR;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600847F RID: 33919 RVA: 0x007B0874 File Offset: 0x007AEA74
		public override void PopulateReferences()
		{
			short num = (short)1833289393;
			short num2 = num;
			num = (short)1643366065;
			switch (num2 == num)
			{
			}
			num = (short)751697921;
			if (num != 0)
			{
			}
			num = (short)1099431936;
			if (num != 0)
			{
			}
			num = (short)582549504;
			short num3 = num;
			this.cHO9PursuitKnobIndex_A36685.SetRecset(this.a(4008));
		}

		// Token: 0x06008480 RID: 33920 RVA: 0x007B0934 File Offset: 0x007AEB34
		public override void DropReferences()
		{
			short num = (short)1614298382;
			short num2 = num;
			num = (short)1561869582;
			switch (num2 == num)
			{
			}
			num = (short)1622343680;
			if (num != 0)
			{
			}
			num = (short)1261568001;
			if (num != 0)
			{
			}
			num = (short)1046085632;
			short num3 = num;
		}

		// Token: 0x06008481 RID: 33921 RVA: 0x007B09E0 File Offset: 0x007AEBE0
		public override void SetConstraints()
		{
			short num = (short)159907841;
			if (num != 0)
			{
			}
			num = (short)1285192923;
			short num2 = num;
			num = (short)557546715;
			switch (num2 == num)
			{
			}
			num = (short)640024576;
			if (num != 0)
			{
			}
			num = (short)2001272832;
			short num3 = num;
			this.cHO9PursuitKnobMode_A36683.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.cHO9PursuitKnobAction_A36684.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableApp);
			this.cHO9PursuitKnobAction_A36684.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableEditable);
			this.cHO9PursuitKnobIndex_A36685.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableApp);
			this.cHO9PursuitKnobIndex_A36685.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConResponseSelectorIndexValid);
			this.cHO9PursuitKnobIndex_A36685.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.ConStandaloneRadioSystemEnableEditable);
		}

		// Token: 0x06008482 RID: 33922 RVA: 0x007B0B14 File Offset: 0x007AED14
		public override void SetupDependencies()
		{
			short num = (short)1438114830;
			short num2 = num;
			num = (short)1376183310;
			switch (num2 == num)
			{
			}
			num = (short)553189377;
			if (num != 0)
			{
			}
			num = (short)621608960;
			if (num != 0)
			{
			}
			num = (short)204210176;
			short num3 = num;
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cHO9PursuitKnobAction_A36684);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.cHO9PursuitKnobIndex_A36685);
		}

		// Token: 0x17004364 RID: 17252
		// (get) Token: 0x06008483 RID: 33923 RVA: 0x007B0BF8 File Offset: 0x007AEDF8
		public global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation ActionConsolidationForCHO9PursuitKnobIndex_A36685
		{
			get
			{
				short num = (short)939438640;
				short num2 = num;
				num = (short)1835840048;
				switch (num2 == num)
				{
				}
				num = (short)370999297;
				if (num != 0)
				{
				}
				num = (short)1911095296;
				if (num != 0)
				{
				}
				num = (short)1502674944;
				short num3 = num;
				return this.cHO9PursuitKnobIndex_A36685.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation;
			}
		}

		// Token: 0x17004365 RID: 17253
		// (get) Token: 0x06008484 RID: 33924 RVA: 0x007B0CB4 File Offset: 0x007AEEB4
		public bool HasDiffs
		{
			get
			{
				short num = (short)241031155;
				short num2 = num;
				num = (short)141613043;
				switch (num2 == num)
				{
				}
				num = (short)2071855104;
				if (num != 0)
				{
				}
				num = (short)299171841;
				if (num != 0)
				{
				}
				num = (short)1145569280;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17004366 RID: 17254
		// (get) Token: 0x06008485 RID: 33925 RVA: 0x007B0D64 File Offset: 0x007AEF64
		// (set) Token: 0x06008486 RID: 33926 RVA: 0x007B0E18 File Offset: 0x007AF018
		public string CHO9PursuitKnobMode_A36683Value
		{
			get
			{
				short num = (short)1235484673;
				if (num != 0)
				{
				}
				num = (short)820666361;
				short num2 = num;
				num = (short)1886347257;
				switch (num2 == num)
				{
				}
				num = (short)1158414336;
				if (num != 0)
				{
				}
				num = (short)518520832;
				short num3 = num;
				return this.cHO9PursuitKnobMode_A36683.Value;
			}
			set
			{
				short num = (short)1823753774;
				short num2 = num;
				num = (short)2086422062;
				switch (num2 == num)
				{
				}
				num = (short)1136459777;
				if (num != 0)
				{
				}
				num = (short)1586888704;
				if (num != 0)
				{
				}
				num = (short)1169031168;
				short num3 = num;
				this.cHO9PursuitKnobMode_A36683.Value = value;
			}
		}

		// Token: 0x17004367 RID: 17255
		// (get) Token: 0x06008487 RID: 33927 RVA: 0x007B0ECC File Offset: 0x007AF0CC
		public global::AcpBusinessLayer.AcpField<string> CHO9PursuitKnobMode_A36683
		{
			get
			{
				short num = (short)1246498643;
				short num2 = num;
				num = (short)663359315;
				switch (num2 == num)
				{
				}
				num = (short)1659961345;
				if (num != 0)
				{
				}
				num = (short)1279524864;
				if (num != 0)
				{
				}
				num = (short)219086848;
				short num3 = num;
				return this.cHO9PursuitKnobMode_A36683;
			}
		}

		// Token: 0x17004368 RID: 17256
		// (get) Token: 0x06008488 RID: 33928 RVA: 0x007B0F80 File Offset: 0x007AF180
		// (set) Token: 0x06008489 RID: 33929 RVA: 0x007B1034 File Offset: 0x007AF234
		public string CHO9PursuitKnobMode_A36683_UIValue
		{
			get
			{
				short num = (short)752680961;
				if (num != 0)
				{
				}
				num = (short)1652895413;
				short num2 = num;
				num = (short)925314741;
				switch (num2 == num)
				{
				}
				num = (short)1026359296;
				if (num != 0)
				{
				}
				num = (short)1779630080;
				short num3 = num;
				return this.cHO9PursuitKnobMode_A36683.Value;
			}
			set
			{
				short num = (short)1310336927;
				short num2 = num;
				num = (short)1999513503;
				switch (num2 == num)
				{
				}
				num = (short)1632043008;
				if (num != 0)
				{
				}
				num = (short)1752760321;
				if (num != 0)
				{
				}
				num = (short)650575872;
				short num3 = num;
				this.cHO9PursuitKnobMode_A36683.Value = value;
			}
		}

		// Token: 0x17004369 RID: 17257
		// (get) Token: 0x0600848A RID: 33930 RVA: 0x007B10E8 File Offset: 0x007AF2E8
		// (set) Token: 0x0600848B RID: 33931 RVA: 0x007B11A0 File Offset: 0x007AF3A0
		public bool CHO9PursuitKnobMode_A36683_Applicable
		{
			get
			{
				short num = (short)361644255;
				short num2 = num;
				num = (short)1363362015;
				switch (num2 == num)
				{
				}
				num = (short)1889271809;
				if (num != 0)
				{
				}
				num = (short)800129024;
				if (num != 0)
				{
				}
				num = (short)1414266880;
				short num3 = num;
				return this.cHO9PursuitKnobMode_A36683.Applicable;
			}
			set
			{
				short num = (short)565253996;
				short num2 = num;
				num = (short)1054349164;
				switch (num2 == num)
				{
				}
				num = (short)817954817;
				if (num != 0)
				{
				}
				num = (short)890503168;
				if (num != 0)
				{
				}
				num = (short)151060480;
				short num3 = num;
				this.cHO9PursuitKnobMode_A36683.Applicable = value;
			}
		}

		// Token: 0x1700436A RID: 17258
		// (get) Token: 0x0600848C RID: 33932 RVA: 0x007B1258 File Offset: 0x007AF458
		// (set) Token: 0x0600848D RID: 33933 RVA: 0x007B1310 File Offset: 0x007AF510
		public bool CHO9PursuitKnobMode_A36683_Valid
		{
			get
			{
				short num = (short)591462401;
				if (num != 0)
				{
				}
				num = (short)846657089;
				short num2 = num;
				num = (short)1056044609;
				switch (num2 == num)
				{
				}
				num = (short)1581645824;
				if (num != 0)
				{
				}
				num = (short)1170145280;
				short num3 = num;
				return this.cHO9PursuitKnobMode_A36683.Valid;
			}
			set
			{
				short num = (short)56622490;
				short num2 = num;
				num = (short)1053490586;
				switch (num2 == num)
				{
				}
				num = (short)1757478912;
				if (num != 0)
				{
				}
				num = (short)1246756865;
				if (num != 0)
				{
				}
				num = (short)1130758144;
				short num3 = num;
				this.cHO9PursuitKnobMode_A36683.Valid = value;
			}
		}

		// Token: 0x1700436B RID: 17259
		// (get) Token: 0x0600848E RID: 33934 RVA: 0x007B13C4 File Offset: 0x007AF5C4
		// (set) Token: 0x0600848F RID: 33935 RVA: 0x007B1478 File Offset: 0x007AF678
		public bool CHO9PursuitKnobMode_A36683_Visible
		{
			get
			{
				short num = (short)1132300536;
				short num2 = num;
				num = (short)56658168;
				switch (num2 == num)
				{
				}
				num = (short)964034561;
				if (num != 0)
				{
				}
				num = (short)277217280;
				if (num != 0)
				{
				}
				num = (short)157679616;
				short num3 = num;
				return this.cHO9PursuitKnobMode_A36683.Visible;
			}
			set
			{
				short num = (short)363781279;
				short num2 = num;
				num = (short)1596513439;
				switch (num2 == num)
				{
				}
				num = (short)1801191425;
				if (num != 0)
				{
				}
				num = (short)952303616;
				if (num != 0)
				{
				}
				num = (short)1399193600;
				short num3 = num;
				this.cHO9PursuitKnobMode_A36683.Visible = value;
			}
		}

		// Token: 0x1700436C RID: 17260
		// (get) Token: 0x06008490 RID: 33936 RVA: 0x007B152C File Offset: 0x007AF72C
		// (set) Token: 0x06008491 RID: 33937 RVA: 0x007B15E0 File Offset: 0x007AF7E0
		public bool CHO9PursuitKnobMode_A36683_Editable
		{
			get
			{
				short num = (short)93429598;
				short num2 = num;
				num = (short)238853982;
				switch (num2 == num)
				{
				}
				num = (short)360382465;
				if (num != 0)
				{
				}
				num = (short)126156800;
				if (num != 0)
				{
				}
				num = (short)294584320;
				short num3 = num;
				return this.cHO9PursuitKnobMode_A36683.Editable;
			}
			set
			{
				short num = (short)423880908;
				short num2 = num;
				num = (short)1323231436;
				switch (num2 == num)
				{
				}
				num = (short)1547173888;
				if (num != 0)
				{
				}
				num = (short)958726145;
				if (num != 0)
				{
				}
				num = (short)927268864;
				short num3 = num;
				this.cHO9PursuitKnobMode_A36683.Editable = value;
			}
		}

		// Token: 0x1700436D RID: 17261
		// (get) Token: 0x06008492 RID: 33938 RVA: 0x007B1694 File Offset: 0x007AF894
		internal string CHO9PursuitKnobMode_A36683_UILabel
		{
			get
			{
				short num = (short)1704980578;
				short num2 = num;
				num = (short)1419636834;
				switch (num2 == num)
				{
				}
				num = (short)1374224384;
				if (num != 0)
				{
				}
				num = (short)2013921281;
				if (num != 0)
				{
				}
				num = (short)1867513856;
				short num3 = num;
				return this.cHO9PursuitKnobMode_A36683.UIName;
			}
		}

		// Token: 0x1700436E RID: 17262
		// (get) Token: 0x06008493 RID: 33939 RVA: 0x007B1748 File Offset: 0x007AF948
		// (set) Token: 0x06008494 RID: 33940 RVA: 0x007B17FC File Offset: 0x007AF9FC
		internal bool CHO9PursuitKnobMode_A36683_HiddenStatic
		{
			get
			{
				short num = (short)1429029718;
				short num2 = num;
				num = (short)4604758;
				switch (num2 == num)
				{
				}
				num = (short)557383681;
				if (num != 0)
				{
				}
				num = (short)216137728;
				if (num != 0)
				{
				}
				num = (short)1670840320;
				short num3 = num;
				return this.cHO9PursuitKnobMode_A36683.HiddenStatic;
			}
			set
			{
				short num = (short)1021554156;
				short num2 = num;
				num = (short)164212204;
				switch (num2 == num)
				{
				}
				num = (short)543031297;
				if (num != 0)
				{
				}
				num = (short)700907520;
				if (num != 0)
				{
				}
				num = (short)931004416;
				short num3 = num;
				this.cHO9PursuitKnobMode_A36683.HiddenStatic = value;
			}
		}

		// Token: 0x1700436F RID: 17263
		// (get) Token: 0x06008495 RID: 33941 RVA: 0x007B18B0 File Offset: 0x007AFAB0
		// (set) Token: 0x06008496 RID: 33942 RVA: 0x007B1968 File Offset: 0x007AFB68
		internal bool CHO9PursuitKnobMode_A36683_HiddenDynamic
		{
			get
			{
				short num = (short)2105087586;
				short num2 = num;
				num = (short)284628578;
				switch (num2 == num)
				{
				}
				num = (short)1518403584;
				if (num != 0)
				{
				}
				num = (short)668336129;
				if (num != 0)
				{
				}
				num = (short)423886848;
				short num3 = num;
				return this.cHO9PursuitKnobMode_A36683.HiddenDynamic;
			}
			set
			{
				short num = (short)114205569;
				short num2 = num;
				num = (short)723624833;
				switch (num2 == num)
				{
				}
				num = (short)168886273;
				if (num != 0)
				{
				}
				num = (short)201261056;
				if (num != 0)
				{
				}
				num = (short)2059206656;
				short num3 = num;
				this.cHO9PursuitKnobMode_A36683.HiddenDynamic = value;
			}
		}

		// Token: 0x17004370 RID: 17264
		// (get) Token: 0x06008497 RID: 33943 RVA: 0x007B1A1C File Offset: 0x007AFC1C
		public bool CHO9PursuitKnobMode_A36683_HasDiffs
		{
			get
			{
				short num = (short)580719937;
				short num2 = num;
				num = (short)1409881409;
				switch (num2 == num)
				{
				}
				num = (short)1528627201;
				if (num != 0)
				{
				}
				num = (short)265486336;
				if (num != 0)
				{
				}
				num = (short)1946550272;
				short num3 = num;
				return this.cHO9PursuitKnobMode_A36683._HasDiffs;
			}
		}

		// Token: 0x17004371 RID: 17265
		// (get) Token: 0x06008498 RID: 33944 RVA: 0x007B1AD0 File Offset: 0x007AFCD0
		// (set) Token: 0x06008499 RID: 33945 RVA: 0x007B1B84 File Offset: 0x007AFD84
		public int CHO9PursuitKnobAction_A36684Value
		{
			get
			{
				short num = (short)1226951858;
				short num2 = num;
				num = (short)534105266;
				switch (num2 == num)
				{
				}
				num = (short)1635057665;
				if (num != 0)
				{
				}
				num = (short)632487936;
				if (num != 0)
				{
				}
				num = (short)951320576;
				short num3 = num;
				return this.cHO9PursuitKnobAction_A36684.Value;
			}
			set
			{
				short num = (short)1868875929;
				short num2 = num;
				num = (short)2137507993;
				switch (num2 == num)
				{
				}
				num = (short)1692336129;
				if (num != 0)
				{
				}
				num = (short)1729495040;
				if (num != 0)
				{
				}
				num = (short)385679360;
				short num3 = num;
				this.cHO9PursuitKnobAction_A36684.Value = value;
			}
		}

		// Token: 0x17004372 RID: 17266
		// (get) Token: 0x0600849A RID: 33946 RVA: 0x007B1C38 File Offset: 0x007AFE38
		// (set) Token: 0x0600849B RID: 33947 RVA: 0x007B1CEC File Offset: 0x007AFEEC
		public string CHO9PursuitKnobAction_A36684_UIValue
		{
			get
			{
				short num = (short)1046033049;
				short num2 = num;
				num = (short)1234186905;
				switch (num2 == num)
				{
				}
				num = (short)960823297;
				if (num != 0)
				{
				}
				num = (short)1952841728;
				if (num != 0)
				{
				}
				num = (short)493813760;
				short num3 = num;
				return this.cHO9PursuitKnobAction_A36684.UIValue;
			}
			set
			{
				short num = (short)1589248001;
				if (num != 0)
				{
				}
				num = (short)547014877;
				short num2 = num;
				num = (short)257673437;
				switch (num2 == num)
				{
				}
				num = (short)1543831552;
				if (num != 0)
				{
				}
				num = (short)1659699200;
				short num3 = num;
				this.cHO9PursuitKnobAction_A36684.UIValue = value;
			}
		}

		// Token: 0x17004373 RID: 17267
		// (get) Token: 0x0600849C RID: 33948 RVA: 0x007B1DA4 File Offset: 0x007AFFA4
		public global::AcpBusinessLayer.AcpListField CHO9PursuitKnobAction_A36684
		{
			get
			{
				short num = (short)1269039105;
				if (num != 0)
				{
				}
				num = (short)1330597748;
				short num2 = num;
				num = (short)2041532276;
				switch (num2 == num)
				{
				}
				num = (short)588513280;
				if (num != 0)
				{
				}
				num = (short)381222912;
				short num3 = num;
				return this.cHO9PursuitKnobAction_A36684;
			}
		}

		// Token: 0x17004374 RID: 17268
		// (get) Token: 0x0600849D RID: 33949 RVA: 0x007B1E54 File Offset: 0x007B0054
		// (set) Token: 0x0600849E RID: 33950 RVA: 0x007B1F08 File Offset: 0x007B0108
		public bool CHO9PursuitKnobAction_A36684_Applicable
		{
			get
			{
				short num = (short)767023976;
				short num2 = num;
				num = (short)1901976424;
				switch (num2 == num)
				{
				}
				num = (short)31850496;
				if (num != 0)
				{
				}
				num = (short)240910337;
				if (num != 0)
				{
				}
				num = (short)24051712;
				short num3 = num;
				return this.cHO9PursuitKnobAction_A36684.Applicable;
			}
			set
			{
				short num = (short)291237677;
				short num2 = num;
				num = (short)1922494253;
				switch (num2 == num)
				{
				}
				num = (short)475463681;
				if (num != 0)
				{
				}
				num = (short)1835401216;
				if (num != 0)
				{
				}
				num = (short)657129472;
				short num3 = num;
				this.cHO9PursuitKnobAction_A36684.Applicable = value;
			}
		}

		// Token: 0x17004375 RID: 17269
		// (get) Token: 0x0600849F RID: 33951 RVA: 0x007B1FC0 File Offset: 0x007B01C0
		// (set) Token: 0x060084A0 RID: 33952 RVA: 0x007B2074 File Offset: 0x007B0274
		public bool CHO9PursuitKnobAction_A36684_Valid
		{
			get
			{
				short num = (short)929917524;
				short num2 = num;
				num = (short)400386644;
				switch (num2 == num)
				{
				}
				num = (short)1875705857;
				if (num != 0)
				{
				}
				num = (short)688324608;
				if (num != 0)
				{
				}
				num = (short)50855936;
				short num3 = num;
				return this.cHO9PursuitKnobAction_A36684.Valid;
			}
			set
			{
				short num = (short)481097070;
				short num2 = num;
				num = (short)910488942;
				switch (num2 == num)
				{
				}
				num = (short)648740865;
				if (num != 0)
				{
				}
				num = (short)1210646528;
				if (num != 0)
				{
				}
				num = (short)1110638592;
				short num3 = num;
				this.cHO9PursuitKnobAction_A36684.Valid = value;
			}
		}

		// Token: 0x17004376 RID: 17270
		// (get) Token: 0x060084A1 RID: 33953 RVA: 0x007B212C File Offset: 0x007B032C
		// (set) Token: 0x060084A2 RID: 33954 RVA: 0x007B21E0 File Offset: 0x007B03E0
		public bool CHO9PursuitKnobAction_A36684_Visible
		{
			get
			{
				short num = (short)270201464;
				short num2 = num;
				num = (short)1216148088;
				switch (num2 == num)
				{
				}
				num = (short)1616183297;
				if (num != 0)
				{
				}
				num = (short)13565952;
				if (num != 0)
				{
				}
				num = (short)76283904;
				short num3 = num;
				return this.cHO9PursuitKnobAction_A36684.Visible;
			}
			set
			{
				short num = (short)1603562141;
				short num2 = num;
				num = (short)1032612509;
				switch (num2 == num)
				{
				}
				num = (short)924975105;
				if (num != 0)
				{
				}
				num = (short)1803157504;
				if (num != 0)
				{
				}
				num = (short)2122711040;
				short num3 = num;
				this.cHO9PursuitKnobAction_A36684.Visible = value;
			}
		}

		// Token: 0x17004377 RID: 17271
		// (get) Token: 0x060084A3 RID: 33955 RVA: 0x007B2298 File Offset: 0x007B0498
		// (set) Token: 0x060084A4 RID: 33956 RVA: 0x007B234C File Offset: 0x007B054C
		public bool CHO9PursuitKnobAction_A36684_Editable
		{
			get
			{
				short num = (short)167319184;
				short num2 = num;
				num = (short)1752897168;
				switch (num2 == num)
				{
				}
				num = (short)2087124992;
				if (num != 0)
				{
				}
				num = (short)63242241;
				if (num != 0)
				{
				}
				num = (short)1427636224;
				short num3 = num;
				return this.cHO9PursuitKnobAction_A36684.Editable;
			}
			set
			{
				short num = (short)1002872410;
				short num2 = num;
				num = (short)491560538;
				switch (num2 == num)
				{
				}
				num = (short)91947008;
				if (num != 0)
				{
				}
				num = (short)1851392001;
				if (num != 0)
				{
				}
				num = (short)2071134208;
				short num3 = num;
				this.cHO9PursuitKnobAction_A36684.Editable = value;
			}
		}

		// Token: 0x17004378 RID: 17272
		// (get) Token: 0x060084A5 RID: 33957 RVA: 0x007B2400 File Offset: 0x007B0600
		internal string CHO9PursuitKnobAction_A36684_UILabel
		{
			get
			{
				short num = (short)121583281;
				short num2 = num;
				num = (short)400701105;
				switch (num2 == num)
				{
				}
				num = (short)986316801;
				if (num != 0)
				{
				}
				num = (short)195362816;
				if (num != 0)
				{
				}
				num = (short)170459136;
				short num3 = num;
				return this.cHO9PursuitKnobAction_A36684.UIName;
			}
		}

		// Token: 0x17004379 RID: 17273
		// (get) Token: 0x060084A6 RID: 33958 RVA: 0x007B24B8 File Offset: 0x007B06B8
		// (set) Token: 0x060084A7 RID: 33959 RVA: 0x007B2570 File Offset: 0x007B0770
		internal bool CHO9PursuitKnobAction_A36684_HiddenStatic
		{
			get
			{
				short num = (short)705965322;
				short num2 = num;
				num = (short)1316302090;
				switch (num2 == num)
				{
				}
				num = (short)68157441;
				if (num != 0)
				{
				}
				num = (short)1144717312;
				if (num != 0)
				{
				}
				num = (short)849281024;
				short num3 = num;
				return this.cHO9PursuitKnobAction_A36684.HiddenStatic;
			}
			set
			{
				short num = (short)868834623;
				short num2 = num;
				num = (short)190995775;
				switch (num2 == num)
				{
				}
				num = (short)962527232;
				if (num != 0)
				{
				}
				num = (short)1703936001;
				if (num != 0)
				{
				}
				num = (short)1720713216;
				short num3 = num;
				this.cHO9PursuitKnobAction_A36684.HiddenStatic = value;
			}
		}

		// Token: 0x1700437A RID: 17274
		// (get) Token: 0x060084A8 RID: 33960 RVA: 0x007B2628 File Offset: 0x007B0828
		// (set) Token: 0x060084A9 RID: 33961 RVA: 0x007B26DC File Offset: 0x007B08DC
		internal bool CHO9PursuitKnobAction_A36684_HiddenDynamic
		{
			get
			{
				short num = (short)1878136994;
				short num2 = num;
				num = (short)1210194082;
				switch (num2 == num)
				{
				}
				num = (short)1469775873;
				if (num != 0)
				{
				}
				num = (short)357171200;
				if (num != 0)
				{
				}
				num = (short)400097280;
				short num3 = num;
				return this.cHO9PursuitKnobAction_A36684.HiddenDynamic;
			}
			set
			{
				short num = (short)169207176;
				short num2 = num;
				num = (short)215278984;
				switch (num2 == num)
				{
				}
				num = (short)1644363776;
				if (num != 0)
				{
				}
				num = (short)388104193;
				if (num != 0)
				{
				}
				num = (short)186974208;
				short num3 = num;
				this.cHO9PursuitKnobAction_A36684.HiddenDynamic = value;
			}
		}

		// Token: 0x1700437B RID: 17275
		// (get) Token: 0x060084AA RID: 33962 RVA: 0x007B2790 File Offset: 0x007B0990
		public bool CHO9PursuitKnobAction_A36684_HasDiffs
		{
			get
			{
				short num = (short)257718892;
				short num2 = num;
				num = (short)424835692;
				switch (num2 == num)
				{
				}
				num = (short)256835585;
				if (num != 0)
				{
				}
				num = (short)1777336320;
				if (num != 0)
				{
				}
				num = (short)1183580160;
				short num3 = num;
				return this.cHO9PursuitKnobAction_A36684._HasDiffs;
			}
		}

		// Token: 0x1700437C RID: 17276
		// (get) Token: 0x060084AB RID: 33963 RVA: 0x007B2844 File Offset: 0x007B0A44
		// (set) Token: 0x060084AC RID: 33964 RVA: 0x007B28F8 File Offset: 0x007B0AF8
		public int CHO9PursuitKnobIndex_A36685Value
		{
			get
			{
				short num = (short)705295718;
				short num2 = num;
				num = (short)1474032998;
				switch (num2 == num)
				{
				}
				num = (short)771555329;
				if (num != 0)
				{
				}
				num = (short)1972371456;
				if (num != 0)
				{
				}
				num = (short)889126912;
				short num3 = num;
				return this.cHO9PursuitKnobIndex_A36685.Value;
			}
			set
			{
				short num = (short)921395106;
				short num2 = num;
				num = (short)1173708706;
				switch (num2 == num)
				{
				}
				num = (short)1129054209;
				if (num != 0)
				{
				}
				num = (short)1904869376;
				if (num != 0)
				{
				}
				num = (short)150274048;
				short num3 = num;
				this.cHO9PursuitKnobIndex_A36685.Value = value;
			}
		}

		// Token: 0x1700437D RID: 17277
		// (get) Token: 0x060084AD RID: 33965 RVA: 0x007B29B0 File Offset: 0x007B0BB0
		// (set) Token: 0x060084AE RID: 33966 RVA: 0x007B2A68 File Offset: 0x007B0C68
		public string CHO9PursuitKnobIndex_A36685_UIValue
		{
			get
			{
				short num = (short)742448104;
				short num2 = num;
				num = (short)56351720;
				switch (num2 == num)
				{
				}
				num = (short)817299457;
				if (num != 0)
				{
				}
				num = (short)1337851904;
				if (num != 0)
				{
				}
				num = (short)1811087360;
				short num3 = num;
				return this.cHO9PursuitKnobIndex_A36685.UIValue;
			}
			set
			{
				short num = (short)128778241;
				if (num != 0)
				{
				}
				num = (short)381177522;
				short num2 = num;
				num = (short)968445618;
				switch (num2 == num)
				{
				}
				num = (short)597229568;
				if (num != 0)
				{
				}
				num = (short)419692544;
				short num3 = num;
				this.cHO9PursuitKnobIndex_A36685.UIValue = value;
			}
		}

		// Token: 0x1700437E RID: 17278
		// (get) Token: 0x060084AF RID: 33967 RVA: 0x007B2B1C File Offset: 0x007B0D1C
		public global::AcpBusinessLayer.AcpRecRefField CHO9PursuitKnobIndex_A36685
		{
			get
			{
				short num = (short)1944263135;
				short num2 = num;
				num = (short)91822559;
				switch (num2 == num)
				{
				}
				num = (short)555548673;
				if (num != 0)
				{
				}
				num = (short)48234496;
				if (num != 0)
				{
				}
				num = (short)230490112;
				short num3 = num;
				return this.cHO9PursuitKnobIndex_A36685;
			}
		}

		// Token: 0x1700437F RID: 17279
		// (get) Token: 0x060084B0 RID: 33968 RVA: 0x007B2BD0 File Offset: 0x007B0DD0
		// (set) Token: 0x060084B1 RID: 33969 RVA: 0x007B2C88 File Offset: 0x007B0E88
		public bool CHO9PursuitKnobIndex_A36685_Applicable
		{
			get
			{
				short num = (short)1424696270;
				short num2 = num;
				num = (short)1338057678;
				switch (num2 == num)
				{
				}
				num = (short)571473920;
				if (num != 0)
				{
				}
				num = (short)423821313;
				if (num != 0)
				{
				}
				num = (short)1657405440;
				short num3 = num;
				return this.cHO9PursuitKnobIndex_A36685.Applicable;
			}
			set
			{
				short num = (short)155416522;
				short num2 = num;
				num = (short)1810331594;
				switch (num2 == num)
				{
				}
				num = (short)1845886976;
				if (num != 0)
				{
				}
				num = (short)1109721089;
				if (num != 0)
				{
				}
				num = (short)1046347776;
				short num3 = num;
				this.cHO9PursuitKnobIndex_A36685.Applicable = value;
			}
		}

		// Token: 0x17004380 RID: 17280
		// (get) Token: 0x060084B2 RID: 33970 RVA: 0x007B2D3C File Offset: 0x007B0F3C
		// (set) Token: 0x060084B3 RID: 33971 RVA: 0x007B2DF4 File Offset: 0x007B0FF4
		public bool CHO9PursuitKnobIndex_A36685_Valid
		{
			get
			{
				short num = (short)247472408;
				short num2 = num;
				num = (short)218964248;
				switch (num2 == num)
				{
				}
				num = (short)1822425088;
				if (num != 0)
				{
				}
				num = (short)651231233;
				if (num != 0)
				{
				}
				num = (short)359792640;
				short num3 = num;
				return this.cHO9PursuitKnobIndex_A36685.Valid;
			}
			set
			{
				short num = (short)762543402;
				short num2 = num;
				num = (short)2033745194;
				switch (num2 == num)
				{
				}
				num = (short)321585153;
				if (num != 0)
				{
				}
				num = (short)83689472;
				if (num != 0)
				{
				}
				num = (short)420610048;
				short num3 = num;
				this.cHO9PursuitKnobIndex_A36685.Valid = value;
			}
		}

		// Token: 0x17004381 RID: 17281
		// (get) Token: 0x060084B4 RID: 33972 RVA: 0x007B2EAC File Offset: 0x007B10AC
		// (set) Token: 0x060084B5 RID: 33973 RVA: 0x007B2F60 File Offset: 0x007B1160
		public bool CHO9PursuitKnobIndex_A36685_Visible
		{
			get
			{
				short num = (short)762200515;
				short num2 = num;
				num = (short)1967866307;
				switch (num2 == num)
				{
				}
				num = (short)451084289;
				if (num != 0)
				{
				}
				num = (short)151388160;
				if (num != 0)
				{
				}
				num = (short)1563557888;
				short num3 = num;
				return this.cHO9PursuitKnobIndex_A36685.Visible;
			}
			set
			{
				short num = (short)713532832;
				short num2 = num;
				num = (short)469869984;
				switch (num2 == num)
				{
				}
				num = (short)1920860161;
				if (num != 0)
				{
				}
				num = (short)55508992;
				if (num != 0)
				{
				}
				num = (short)797245440;
				short num3 = num;
				this.cHO9PursuitKnobIndex_A36685.Visible = value;
			}
		}

		// Token: 0x17004382 RID: 17282
		// (get) Token: 0x060084B6 RID: 33974 RVA: 0x007B3010 File Offset: 0x007B1210
		// (set) Token: 0x060084B7 RID: 33975 RVA: 0x007B30C8 File Offset: 0x007B12C8
		public bool CHO9PursuitKnobIndex_A36685_Editable
		{
			get
			{
				short num = (short)91095041;
				if (num != 0)
				{
				}
				num = (short)1570248900;
				short num2 = num;
				num = (short)654776516;
				switch (num2 == num)
				{
				}
				num = (short)1208549376;
				if (num != 0)
				{
				}
				num = (short)1854013440;
				short num3 = num;
				return this.cHO9PursuitKnobIndex_A36685.Editable;
			}
			set
			{
				short num = (short)2043750060;
				short num2 = num;
				num = (short)296887980;
				switch (num2 == num)
				{
				}
				num = (short)434765825;
				if (num != 0)
				{
				}
				num = (short)7995392;
				if (num != 0)
				{
				}
				num = (short)141361152;
				short num3 = num;
				this.cHO9PursuitKnobIndex_A36685.Editable = value;
			}
		}

		// Token: 0x17004383 RID: 17283
		// (get) Token: 0x060084B8 RID: 33976 RVA: 0x007B317C File Offset: 0x007B137C
		internal string CHO9PursuitKnobIndex_A36685_UILabel
		{
			get
			{
				short num = (short)1905449305;
				short num2 = num;
				num = (short)285202777;
				switch (num2 == num)
				{
				}
				num = (short)967442432;
				short num3 = num;
				num = (short)961740801;
				if (num != 0)
				{
				}
				num = (short)4194304;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobIndex_A36685.UIName;
			}
		}

		// Token: 0x17004384 RID: 17284
		// (get) Token: 0x060084B9 RID: 33977 RVA: 0x007B3230 File Offset: 0x007B1430
		// (set) Token: 0x060084BA RID: 33978 RVA: 0x007B32E4 File Offset: 0x007B14E4
		internal bool CHO9PursuitKnobIndex_A36685_HiddenStatic
		{
			get
			{
				short num = (short)1463930572;
				short num2 = num;
				num = (short)1150471884;
				switch (num2 == num)
				{
				}
				num = (short)723714048;
				short num3 = num;
				num = (short)789905408;
				if (num != 0)
				{
				}
				num = (short)983302145;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobIndex_A36685.HiddenStatic;
			}
			set
			{
				short num = (short)395568510;
				short num2 = num;
				num = (short)91481470;
				switch (num2 == num)
				{
				}
				num = (short)1862795264;
				short num3 = num;
				num = (short)1953562625;
				if (num != 0)
				{
				}
				num = (short)1428160512;
				if (num != 0)
				{
				}
				this.cHO9PursuitKnobIndex_A36685.HiddenStatic = value;
			}
		}

		// Token: 0x17004385 RID: 17285
		// (get) Token: 0x060084BB RID: 33979 RVA: 0x007B3398 File Offset: 0x007B1598
		// (set) Token: 0x060084BC RID: 33980 RVA: 0x007B344C File Offset: 0x007B164C
		internal bool CHO9PursuitKnobIndex_A36685_HiddenDynamic
		{
			get
			{
				short num = (short)41488218;
				short num2 = num;
				num = (short)240652122;
				switch (num2 == num)
				{
				}
				num = (short)2117599232;
				short num3 = num;
				num = (short)962461697;
				if (num != 0)
				{
				}
				num = (short)1693515776;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobIndex_A36685.HiddenDynamic;
			}
			set
			{
				short num = (short)956050783;
				short num2 = num;
				num = (short)2046635359;
				switch (num2 == num)
				{
				}
				num = (short)357498880;
				short num3 = num;
				num = (short)276037632;
				if (num != 0)
				{
				}
				num = (short)1560346625;
				if (num != 0)
				{
				}
				this.cHO9PursuitKnobIndex_A36685.HiddenDynamic = value;
			}
		}

		// Token: 0x17004386 RID: 17286
		// (get) Token: 0x060084BD RID: 33981 RVA: 0x007B3500 File Offset: 0x007B1700
		public bool CHO9PursuitKnobIndex_A36685_HasDiffs
		{
			get
			{
				short num = (short)832404816;
				short num2 = num;
				num = (short)1178893648;
				switch (num2 == num)
				{
				}
				num = (short)1769799680;
				short num3 = num;
				num = (short)1160445953;
				if (num != 0)
				{
				}
				num = (short)1396244480;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobIndex_A36685._HasDiffs;
			}
		}

		// Token: 0x17004387 RID: 17287
		// (get) Token: 0x060084BE RID: 33982 RVA: 0x007B35B8 File Offset: 0x007B17B8
		// (set) Token: 0x060084BF RID: 33983 RVA: 0x007B3670 File Offset: 0x007B1870
		public int CHO9PursuitKnobSecondaryIndex_A36823Value
		{
			get
			{
				short num = (short)1674887134;
				short num2 = num;
				num = (short)966246366;
				switch (num2 == num)
				{
				}
				num = (short)1791688704;
				short num3 = num;
				num = (short)1348599809;
				if (num != 0)
				{
				}
				num = (short)888406016;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobSecondaryIndex_A36823.Value;
			}
			set
			{
				short num = (short)375083853;
				short num2 = num;
				num = (short)1572033357;
				switch (num2 == num)
				{
				}
				num = (short)1717895168;
				short num3 = num;
				num = (short)2017132545;
				if (num != 0)
				{
				}
				num = (short)977600512;
				if (num != 0)
				{
				}
				this.cHO9PursuitKnobSecondaryIndex_A36823.Value = value;
			}
		}

		// Token: 0x17004388 RID: 17288
		// (get) Token: 0x060084C0 RID: 33984 RVA: 0x007B3728 File Offset: 0x007B1928
		// (set) Token: 0x060084C1 RID: 33985 RVA: 0x007B37DC File Offset: 0x007B19DC
		public string CHO9PursuitKnobSecondaryIndex_A36823_UIValue
		{
			get
			{
				short num = (short)389560434;
				short num2 = num;
				num = (short)1466120306;
				switch (num2 == num)
				{
				}
				num = (short)1135149056;
				short num3 = num;
				num = (short)923533313;
				if (num != 0)
				{
				}
				num = (short)428736512;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobSecondaryIndex_A36823.UIValue;
			}
			set
			{
				short num = (short)558880395;
				short num2 = num;
				num = (short)1166136971;
				switch (num2 == num)
				{
				}
				num = (short)890503168;
				short num3 = num;
				num = (short)1262092288;
				if (num != 0)
				{
				}
				num = (short)390397953;
				if (num != 0)
				{
				}
				this.cHO9PursuitKnobSecondaryIndex_A36823.UIValue = value;
			}
		}

		// Token: 0x17004389 RID: 17289
		// (get) Token: 0x060084C2 RID: 33986 RVA: 0x007B3890 File Offset: 0x007B1A90
		public global::AcpBusinessLayer.AcpRecRefField CHO9PursuitKnobSecondaryIndex_A36823
		{
			get
			{
				short num = (short)472850942;
				short num2 = num;
				num = (short)434315774;
				switch (num2 == num)
				{
				}
				num = (short)12779520;
				short num3 = num;
				num = (short)1660747776;
				if (num != 0)
				{
				}
				num = (short)492044289;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobSecondaryIndex_A36823;
			}
		}

		// Token: 0x1700438A RID: 17290
		// (get) Token: 0x060084C3 RID: 33987 RVA: 0x007B393C File Offset: 0x007B1B3C
		// (set) Token: 0x060084C4 RID: 33988 RVA: 0x007B39F0 File Offset: 0x007B1BF0
		public bool CHO9PursuitKnobSecondaryIndex_A36823_Applicable
		{
			get
			{
				short num = (short)340394953;
				short num2 = num;
				num = (short)1260323785;
				switch (num2 == num)
				{
				}
				num = (short)998375424;
				short num3 = num;
				num = (short)166592512;
				if (num != 0)
				{
				}
				num = (short)2063728641;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobSecondaryIndex_A36823.Applicable;
			}
			set
			{
				short num = (short)1206227709;
				short num2 = num;
				num = (short)919507709;
				switch (num2 == num)
				{
				}
				num = (short)405143552;
				short num3 = num;
				num = (short)293339137;
				if (num != 0)
				{
				}
				num = (short)1478295552;
				if (num != 0)
				{
				}
				this.cHO9PursuitKnobSecondaryIndex_A36823.Applicable = value;
			}
		}

		// Token: 0x1700438B RID: 17291
		// (get) Token: 0x060084C5 RID: 33989 RVA: 0x007B3AA4 File Offset: 0x007B1CA4
		// (set) Token: 0x060084C6 RID: 33990 RVA: 0x007B3B58 File Offset: 0x007B1D58
		public bool CHO9PursuitKnobSecondaryIndex_A36823_Valid
		{
			get
			{
				short num = (short)1292202600;
				short num2 = num;
				num = (short)188641896;
				switch (num2 == num)
				{
				}
				num = (short)1670447104;
				short num3 = num;
				num = (short)938737665;
				if (num != 0)
				{
				}
				num = (short)840105984;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobSecondaryIndex_A36823.Valid;
			}
			set
			{
				short num = (short)1799306820;
				short num2 = num;
				num = (short)2041986628;
				switch (num2 == num)
				{
				}
				num = (short)688193536;
				short num3 = num;
				num = (short)437649408;
				if (num != 0)
				{
				}
				num = (short)1598816257;
				if (num != 0)
				{
				}
				this.cHO9PursuitKnobSecondaryIndex_A36823.Valid = value;
			}
		}

		// Token: 0x1700438C RID: 17292
		// (get) Token: 0x060084C7 RID: 33991 RVA: 0x007B3C0C File Offset: 0x007B1E0C
		// (set) Token: 0x060084C8 RID: 33992 RVA: 0x007B3CC0 File Offset: 0x007B1EC0
		public bool CHO9PursuitKnobSecondaryIndex_A36823_Visible
		{
			get
			{
				short num = (short)1197631661;
				short num2 = num;
				num = (short)122579117;
				switch (num2 == num)
				{
				}
				num = (short)367722496;
				short num3 = num;
				num = (short)598212608;
				if (num != 0)
				{
				}
				num = (short)727056385;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobSecondaryIndex_A36823.Visible;
			}
			set
			{
				short num = (short)416398274;
				short num2 = num;
				num = (short)465681346;
				switch (num2 == num)
				{
				}
				num = (short)1837432832;
				short num3 = num;
				num = (short)1587544065;
				if (num != 0)
				{
				}
				num = (short)1454047232;
				if (num != 0)
				{
				}
				this.cHO9PursuitKnobSecondaryIndex_A36823.Visible = value;
			}
		}

		// Token: 0x1700438D RID: 17293
		// (get) Token: 0x060084C9 RID: 33993 RVA: 0x007B3D78 File Offset: 0x007B1F78
		// (set) Token: 0x060084CA RID: 33994 RVA: 0x007B3E2C File Offset: 0x007B202C
		public bool CHO9PursuitKnobSecondaryIndex_A36823_Editable
		{
			get
			{
				short num = (short)310285091;
				short num2 = num;
				num = (short)1144165155;
				switch (num2 == num)
				{
				}
				num = (short)1682374656;
				short num3 = num;
				num = (short)767557633;
				if (num != 0)
				{
				}
				num = (short)2090008576;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobSecondaryIndex_A36823.Editable;
			}
			set
			{
				short num = (short)542911155;
				short num2 = num;
				num = (short)829565619;
				switch (num2 == num)
				{
				}
				num = (short)732889088;
				short num3 = num;
				num = (short)1681719296;
				if (num != 0)
				{
				}
				num = (short)1566834689;
				if (num != 0)
				{
				}
				this.cHO9PursuitKnobSecondaryIndex_A36823.Editable = value;
			}
		}

		// Token: 0x1700438E RID: 17294
		// (get) Token: 0x060084CB RID: 33995 RVA: 0x007B3EE8 File Offset: 0x007B20E8
		internal string CHO9PursuitKnobSecondaryIndex_A36823_UILabel
		{
			get
			{
				short num = (short)1730070627;
				short num2 = num;
				num = (short)606914659;
				switch (num2 == num)
				{
				}
				num = (short)2057306112;
				short num3 = num;
				num = (short)111345665;
				if (num != 0)
				{
				}
				num = (short)266665984;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobSecondaryIndex_A36823.UIName;
			}
		}

		// Token: 0x1700438F RID: 17295
		// (get) Token: 0x060084CC RID: 33996 RVA: 0x007B3FA0 File Offset: 0x007B21A0
		// (set) Token: 0x060084CD RID: 33997 RVA: 0x007B4054 File Offset: 0x007B2254
		internal bool CHO9PursuitKnobSecondaryIndex_A36823_HiddenStatic
		{
			get
			{
				short num = (short)906599413;
				short num2 = num;
				num = (short)2144508917;
				switch (num2 == num)
				{
				}
				num = (short)96141312;
				short num3 = num;
				num = (short)1692270593;
				if (num != 0)
				{
				}
				num = (short)293273600;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobSecondaryIndex_A36823.HiddenStatic;
			}
			set
			{
				short num = (short)408202778;
				short num2 = num;
				num = (short)1321643546;
				switch (num2 == num)
				{
				}
				num = (short)592707584;
				short num3 = num;
				num = (short)1767505921;
				if (num != 0)
				{
				}
				num = (short)1101398016;
				if (num != 0)
				{
				}
				this.cHO9PursuitKnobSecondaryIndex_A36823.HiddenStatic = value;
			}
		}

		// Token: 0x17004390 RID: 17296
		// (get) Token: 0x060084CE RID: 33998 RVA: 0x007B4108 File Offset: 0x007B2308
		// (set) Token: 0x060084CF RID: 33999 RVA: 0x007B41C0 File Offset: 0x007B23C0
		internal bool CHO9PursuitKnobSecondaryIndex_A36823_HiddenDynamic
		{
			get
			{
				short num = (short)979088799;
				short num2 = num;
				num = (short)593933727;
				switch (num2 == num)
				{
				}
				num = (short)518979584;
				short num3 = num;
				num = (short)368902144;
				if (num != 0)
				{
				}
				num = (short)1566638081;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobSecondaryIndex_A36823.HiddenDynamic;
			}
			set
			{
				short num = (short)469299401;
				short num2 = num;
				num = (short)169013449;
				switch (num2 == num)
				{
				}
				num = (short)1460994048;
				short num3 = num;
				num = (short)1486225409;
				if (num != 0)
				{
				}
				num = (short)328925184;
				if (num != 0)
				{
				}
				this.cHO9PursuitKnobSecondaryIndex_A36823.HiddenDynamic = value;
			}
		}

		// Token: 0x17004391 RID: 17297
		// (get) Token: 0x060084D0 RID: 34000 RVA: 0x007B4274 File Offset: 0x007B2474
		public bool CHO9PursuitKnobSecondaryIndex_A36823_HasDiffs
		{
			get
			{
				short num = (short)1618246118;
				short num2 = num;
				num = (short)1173846502;
				switch (num2 == num)
				{
				}
				num = (short)2003697664;
				short num3 = num;
				num = (short)698941441;
				if (num != 0)
				{
				}
				num = (short)233963520;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobSecondaryIndex_A36823._HasDiffs;
			}
		}

		// Token: 0x17004392 RID: 17298
		// (get) Token: 0x060084D1 RID: 34001 RVA: 0x007B432C File Offset: 0x007B252C
		// (set) Token: 0x060084D2 RID: 34002 RVA: 0x007B43E0 File Offset: 0x007B25E0
		public int CHO9PursuitKnobTertiaryIndex_A37025Value
		{
			get
			{
				short num = (short)1928075449;
				short num2 = num;
				num = (short)936843449;
				switch (num2 == num)
				{
				}
				num = (short)553189376;
				short num3 = num;
				num = (short)124649472;
				if (num != 0)
				{
				}
				num = (short)1538588673;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobTertiaryIndex_A37025.Value;
			}
			set
			{
				short num = (short)2041029903;
				short num2 = num;
				num = (short)438674703;
				switch (num2 == num)
				{
				}
				num = (short)1219821568;
				short num3 = num;
				num = (short)784662529;
				if (num != 0)
				{
				}
				num = (short)1729495040;
				if (num != 0)
				{
				}
				this.cHO9PursuitKnobTertiaryIndex_A37025.Value = value;
			}
		}

		// Token: 0x17004393 RID: 17299
		// (get) Token: 0x060084D3 RID: 34003 RVA: 0x007B4498 File Offset: 0x007B2698
		// (set) Token: 0x060084D4 RID: 34004 RVA: 0x007B454C File Offset: 0x007B274C
		public string CHO9PursuitKnobTertiaryIndex_A37025_UIValue
		{
			get
			{
				short num = (short)1567086506;
				short num2 = num;
				num = (short)1650841514;
				switch (num2 == num)
				{
				}
				num = (short)128647168;
				short num3 = num;
				num = (short)517144577;
				if (num != 0)
				{
				}
				num = (short)176160768;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobTertiaryIndex_A37025.UIValue;
			}
			set
			{
				short num = (short)965476353;
				if (num != 0)
				{
				}
				num = (short)404666959;
				short num2 = num;
				num = (short)1015331407;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1671233536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)636289024;
				if (num != 0)
				{
				}
				this.cHO9PursuitKnobTertiaryIndex_A37025.UIValue = value;
			}
		}

		// Token: 0x17004394 RID: 17300
		// (get) Token: 0x060084D5 RID: 34005 RVA: 0x007B4600 File Offset: 0x007B2800
		public global::AcpBusinessLayer.AcpRecRefField CHO9PursuitKnobTertiaryIndex_A37025
		{
			get
			{
				short num = (short)880439810;
				short num2 = num;
				num = (short)467759618;
				switch (num2 == num)
				{
				}
				num = (short)1630470144;
				short num3 = num;
				num = (short)960233472;
				if (num != 0)
				{
				}
				num = (short)1507459073;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobTertiaryIndex_A37025;
			}
		}

		// Token: 0x17004395 RID: 17301
		// (get) Token: 0x060084D6 RID: 34006 RVA: 0x007B46B0 File Offset: 0x007B28B0
		// (set) Token: 0x060084D7 RID: 34007 RVA: 0x007B4768 File Offset: 0x007B2968
		public bool CHO9PursuitKnobTertiaryIndex_A37025_Applicable
		{
			get
			{
				short num = (short)757082256;
				short num2 = num;
				num = (short)866592912;
				switch (num2 == num)
				{
				}
				num = (short)944701440;
				short num3 = num;
				num = (short)832569344;
				if (num != 0)
				{
				}
				num = (short)268435457;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobTertiaryIndex_A37025.Applicable;
			}
			set
			{
				short num = (short)52318157;
				short num2 = num;
				num = (short)131616717;
				switch (num2 == num)
				{
				}
				num = (short)1656553472;
				short num3 = num;
				num = (short)141623296;
				if (num != 0)
				{
				}
				num = (short)1603010561;
				if (num != 0)
				{
				}
				this.cHO9PursuitKnobTertiaryIndex_A37025.Applicable = value;
			}
		}

		// Token: 0x17004396 RID: 17302
		// (get) Token: 0x060084D8 RID: 34008 RVA: 0x007B4820 File Offset: 0x007B2A20
		// (set) Token: 0x060084D9 RID: 34009 RVA: 0x007B48D4 File Offset: 0x007B2AD4
		public bool CHO9PursuitKnobTertiaryIndex_A37025_Valid
		{
			get
			{
				short num = (short)1435631617;
				if (num != 0)
				{
				}
				num = (short)1186781619;
				short num2 = num;
				num = (short)1740364211;
				switch (num2 == num)
				{
				default:
				{
					num = (short)422576128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1134100480;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobTertiaryIndex_A37025.Valid;
			}
			set
			{
				short num = (short)1912995841;
				if (num != 0)
				{
				}
				num = (short)1734558704;
				short num2 = num;
				num = (short)472335344;
				switch (num2 == num)
				{
				default:
				{
					num = (short)5636096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)548470784;
				if (num != 0)
				{
				}
				this.cHO9PursuitKnobTertiaryIndex_A37025.Valid = value;
			}
		}

		// Token: 0x17004397 RID: 17303
		// (get) Token: 0x060084DA RID: 34010 RVA: 0x007B498C File Offset: 0x007B2B8C
		// (set) Token: 0x060084DB RID: 34011 RVA: 0x007B4A40 File Offset: 0x007B2C40
		public bool CHO9PursuitKnobTertiaryIndex_A37025_Visible
		{
			get
			{
				short num = (short)1476934966;
				short num2 = num;
				num = (short)1033321782;
				switch (num2 == num)
				{
				}
				num = (short)663683072;
				short num3 = num;
				num = (short)696713217;
				if (num != 0)
				{
				}
				num = (short)719257600;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobTertiaryIndex_A37025.Visible;
			}
			set
			{
				short num = (short)1663160205;
				short num2 = num;
				num = (short)1295241101;
				switch (num2 == num)
				{
				}
				num = (short)1120010240;
				short num3 = num;
				num = (short)1922367488;
				if (num != 0)
				{
				}
				num = (short)1384710145;
				if (num != 0)
				{
				}
				this.cHO9PursuitKnobTertiaryIndex_A37025.Visible = value;
			}
		}

		// Token: 0x17004398 RID: 17304
		// (get) Token: 0x060084DC RID: 34012 RVA: 0x007B4AF4 File Offset: 0x007B2CF4
		// (set) Token: 0x060084DD RID: 34013 RVA: 0x007B4BAC File Offset: 0x007B2DAC
		public bool CHO9PursuitKnobTertiaryIndex_A37025_Editable
		{
			get
			{
				short num = (short)1706754049;
				if (num != 0)
				{
				}
				num = (short)318722354;
				short num2 = num;
				num = (short)1360482610;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2105278464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)994574336;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobTertiaryIndex_A37025.Editable;
			}
			set
			{
				short num = (short)508428289;
				if (num != 0)
				{
				}
				num = (short)156966320;
				short num2 = num;
				num = (short)537468336;
				switch (num2 == num)
				{
				default:
				{
					num = (short)421527552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)879755264;
				if (num != 0)
				{
				}
				this.cHO9PursuitKnobTertiaryIndex_A37025.Editable = value;
			}
		}

		// Token: 0x17004399 RID: 17305
		// (get) Token: 0x060084DE RID: 34014 RVA: 0x007B4C60 File Offset: 0x007B2E60
		internal string CHO9PursuitKnobTertiaryIndex_A37025_UILabel
		{
			get
			{
				short num = (short)2029989855;
				short num2 = num;
				num = (short)1776168927;
				switch (num2 == num)
				{
				}
				num = (short)1986199552;
				short num3 = num;
				num = (short)853475328;
				if (num != 0)
				{
				}
				num = (short)147718145;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobTertiaryIndex_A37025.UIName;
			}
		}

		// Token: 0x1700439A RID: 17306
		// (get) Token: 0x060084DF RID: 34015 RVA: 0x007B4D14 File Offset: 0x007B2F14
		// (set) Token: 0x060084E0 RID: 34016 RVA: 0x007B4DCC File Offset: 0x007B2FCC
		internal bool CHO9PursuitKnobTertiaryIndex_A37025_HiddenStatic
		{
			get
			{
				short num = (short)590322513;
				short num2 = num;
				num = (short)163093329;
				switch (num2 == num)
				{
				}
				num = (short)360185856;
				short num3 = num;
				num = (short)983498752;
				if (num != 0)
				{
				}
				num = (short)1798963201;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobTertiaryIndex_A37025.HiddenStatic;
			}
			set
			{
				short num = (short)899098026;
				short num2 = num;
				num = (short)977151402;
				switch (num2 == num)
				{
				}
				num = (short)2030108672;
				short num3 = num;
				num = (short)1628897281;
				if (num != 0)
				{
				}
				num = (short)7864320;
				if (num != 0)
				{
				}
				this.cHO9PursuitKnobTertiaryIndex_A37025.HiddenStatic = value;
			}
		}

		// Token: 0x1700439B RID: 17307
		// (get) Token: 0x060084E1 RID: 34017 RVA: 0x007B4E80 File Offset: 0x007B3080
		// (set) Token: 0x060084E2 RID: 34018 RVA: 0x007B4F34 File Offset: 0x007B3134
		internal bool CHO9PursuitKnobTertiaryIndex_A37025_HiddenDynamic
		{
			get
			{
				short num = (short)1329080095;
				short num2 = num;
				num = (short)2016945951;
				switch (num2 == num)
				{
				}
				num = (short)210173952;
				short num3 = num;
				num = (short)199426049;
				if (num != 0)
				{
				}
				num = (short)884080640;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobTertiaryIndex_A37025.HiddenDynamic;
			}
			set
			{
				short num = (short)2009513203;
				short num2 = num;
				num = (short)409255155;
				switch (num2 == num)
				{
				}
				num = (short)1086652416;
				short num3 = num;
				num = (short)906166272;
				if (num != 0)
				{
				}
				num = (short)1826226177;
				if (num != 0)
				{
				}
				this.cHO9PursuitKnobTertiaryIndex_A37025.HiddenDynamic = value;
			}
		}

		// Token: 0x1700439C RID: 17308
		// (get) Token: 0x060084E3 RID: 34019 RVA: 0x007B4FE8 File Offset: 0x007B31E8
		public bool CHO9PursuitKnobTertiaryIndex_A37025_HasDiffs
		{
			get
			{
				short num = (short)1146652950;
				short num2 = num;
				num = (short)989759766;
				switch (num2 == num)
				{
				}
				num = (short)1240924160;
				short num3 = num;
				num = (short)339869696;
				if (num != 0)
				{
				}
				num = (short)779550721;
				if (num != 0)
				{
				}
				return this.cHO9PursuitKnobTertiaryIndex_A37025._HasDiffs;
			}
		}

		// Token: 0x1700439D RID: 17309
		// (get) Token: 0x060084E4 RID: 34020 RVA: 0x007B509C File Offset: 0x007B329C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)445889001;
				short num2 = num;
				num = (short)2062531049;
				switch (num2 == num)
				{
				}
				num = (short)515178496;
				short num3 = num;
				num = (short)169738241;
				if (num != 0)
				{
				}
				num = (short)1823014912;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x060084E5 RID: 34021 RVA: 0x007B515C File Offset: 0x007B335C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1033063145;
			short num2 = num;
			num = (short)1210075881;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_C0:
				num = (short)11862019;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1069613056;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_95;
				}
				break;
			}
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				num = (short)1878392833;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
					return result;
				case 1:
					num = (short)1438973954;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)2094661636;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 3:
					if (base.ParentRecset != null)
					{
						num = (short)387776513;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1443364864;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_95;
			}
			return result;
			IL_95:
			num = (short)842334208;
			short num4 = num;
			result = null;
			goto IL_C0;
		}

		// Token: 0x04003E78 RID: 15992
		private global::AcpBusinessLayer.AcpField<string> cHO9PursuitKnobMode_A36683;

		// Token: 0x04003E79 RID: 15993
		private global::AcpBusinessLayer.AcpListField cHO9PursuitKnobAction_A36684;

		// Token: 0x04003E7A RID: 15994
		private global::AcpBusinessLayer.AcpRecRefField cHO9PursuitKnobIndex_A36685;

		// Token: 0x04003E7B RID: 15995
		private global::AcpBusinessLayer.AcpRecRefField cHO9PursuitKnobSecondaryIndex_A36823;

		// Token: 0x04003E7C RID: 15996
		private global::AcpBusinessLayer.AcpRecRefField cHO9PursuitKnobTertiaryIndex_A37025;
	}
}
