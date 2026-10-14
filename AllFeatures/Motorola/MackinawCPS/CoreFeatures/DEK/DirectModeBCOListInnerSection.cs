using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x0200033C RID: 828
	[global::System.Serializable]
	public class DirectModeBCOListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007F5C RID: 32604 RVA: 0x0075369C File Offset: 0x0075189C
		public DirectModeBCOListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06007F5D RID: 32605 RVA: 0x007536B8 File Offset: 0x007518B8
		protected DirectModeBCOListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007F5E RID: 32606 RVA: 0x007536D0 File Offset: 0x007518D0
		public override void Init()
		{
			int a_ = 12;
			short num = (short)1797335506;
			short num2 = num;
			num = (short)805710290;
			switch (num2 == num)
			{
			}
			num = (short)2040725504;
			if (num != 0)
			{
			}
			num = (short)197394432;
			short num3 = num;
			num = (short)80936961;
			if (num != 0)
			{
			}
			this.dEKDirectModeBCO_A8534 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.indexDEKDirectModeBCO_A8534LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.idDEKDirectModeBCO_A8534LovStrs), this, global::AllFeatures.CodeplugGuid.b("觌諎髐韒볔ꗖ볘룚꧜鋞軠蟢胤ꗦꫨꓪ달껮짰웲웴쏶", a_), global::CommonResources.AcgResources.ID_DIRECTMODEBCO, true, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.DEKDirectModeBCO_A8534LovStrs);
			this.dEKDirectModeBCO_A8534.IgnoreOnCompare = true;
			this.dEKDirectModeBCO_A8534.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dEKDirectModeBCO_A8534.DataTransferOrder = -1;
			this.dEKDirectModeZone_A8538 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("觌諎髐韒볔ꗖ볘룚꧜鋞軠蟢胤뷦蛨藪裬냮냰쯲샴쓶쇸", a_), global::CommonResources.AcgResources.ID_DIRECTMODEZONE, null, null, true, false);
			this.dEKDirectModeZone_A8538.IgnoreOnCompare = true;
			this.dEKDirectModeZone_A8538.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dEKDirectModeZone_A8538.DataTransferOrder = -1;
			this.dEKDirectModeChannel_A8535 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("觌諎髐韒볔ꗖ볘룚꧜鋞軠蟢胤ꓦ臨諪菬臮铰鿲ꫴ뛶쇸컺컼쫾", a_), global::CommonResources.AcgResources.ID_DIRECTMODECHANNEL, null, null, true, false);
			this.dEKDirectModeChannel_A8535.IgnoreOnCompare = true;
			this.dEKDirectModeChannel_A8535.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dEKDirectModeChannel_A8535.DataTransferOrder = -1;
			this.dEKDirectModeKey_A21200 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("觌諎髐韒볔ꗖ볘룚꧜鋞軠蟢胤곦賨鋪달껮쏰싲쟴쟶째", a_), global::CommonResources.AcgResources.ID_DIRECTMODEKEY);
			this.dEKDirectModeKey_A21200.IgnoreOnCompare = true;
			this.dEKDirectModeKey_A21200.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dEKDirectModeKey_A21200.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("觌ꛎꏐ뛒뛔ꏖ律雚닜믞蓠쏢꟤ꓦꛨ쯪ꇬ蛮苰蟲", a_);
			base.Id = 10238;
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTMODEBCOLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007F5F RID: 32607 RVA: 0x007538DC File Offset: 0x00751ADC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 10;
			short num = (short)282984462;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_34D;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迊裌蓎闐뫒꟔닖뫘꿚郜냞藠蛢뿤裦蟨軪달껮짰웲웴쿶", a_)))
					{
						num = (short)1819738116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_257;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迊裌蓎闐뫒꟔닖뫘꿚郜냞藠蛢ꛤ迦裨藪菬諮鷰곲듴쿶쳸죺주", a_)))
					{
						num = (short)1667956742;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CE;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迊裌蓎闐뫒꟔닖뫘꿚郜냞藠蛢껤苦部듪곬\uddee샰쇲열쟶", a_)))
					{
						num = (short)1672740871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_438;
				case 4:
					this.dEKDirectModeZone_A8538 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("迊裌蓎闐뫒꟔닖뫘꿚郜냞藠蛢뿤裦蟨軪달껮짰웲웴쿶", a_), global::CommonResources.AcgResources.ID_DIRECTMODEZONE, null, null, true, false);
					this.dEKDirectModeZone_A8538.IgnoreOnCompare = true;
					this.dEKDirectModeZone_A8538.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dEKDirectModeZone_A8538.DataTransferOrder = -1;
					num = (short)1451098125;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_21C;
				case 6:
					this.dEKDirectModeChannel_A8535 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("迊裌蓎闐뫒꟔닖뫘꿚郜냞藠蛢ꛤ迦裨藪菬諮鷰곲듴쿶쳸죺주", a_), global::CommonResources.AcgResources.ID_DIRECTMODECHANNEL, null, null, true, false);
					this.dEKDirectModeChannel_A8535.IgnoreOnCompare = true;
					this.dEKDirectModeChannel_A8535.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dEKDirectModeChannel_A8535.DataTransferOrder = -1;
					num = (short)1897201673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					this.dEKDirectModeKey_A21200 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("迊裌蓎闐뫒꟔닖뫘꿚郜냞藠蛢껤苦部듪곬\uddee샰쇲열쟶", a_), global::CommonResources.AcgResources.ID_DIRECTMODEKEY);
					this.dEKDirectModeKey_A21200.IgnoreOnCompare = true;
					this.dEKDirectModeKey_A21200.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dEKDirectModeKey_A21200.DataTransferOrder = -1;
					num = (short)1903099912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_348;
				case 9:
				{
					num = (short)857735168;
					short num3 = num;
					goto IL_1CE;
				}
				case 10:
					num = (short)915341327;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					this.dEKDirectModeBCO_A8534 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.indexDEKDirectModeBCO_A8534LovStrs, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.idDEKDirectModeBCO_A8534LovStrs), this, global::AllFeatures.CodeplugGuid.b("迊裌蓎闐뫒꟔닖뫘꿚郜냞藠蛢꟤ꓦꛨ듪곬ퟮ쓰샲쇴", a_), global::CommonResources.AcgResources.ID_DIRECTMODEBCO, true, global::Motorola.MackinawCPS.CoreFeatures.DEK.LOVs.DEKDirectModeBCO_A8534LovStrs);
					this.dEKDirectModeBCO_A8534.IgnoreOnCompare = true;
					this.dEKDirectModeBCO_A8534.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dEKDirectModeBCO_A8534.DataTransferOrder = -1;
					num = (short)670957569;
					if (num != 0)
					{
					}
					num = (short)437125120;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (producerFields != null)
					{
						num = (short)1749024778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_438;
				case 13:
					goto IL_257;
				case 14:
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("迊裌蓎闐뫒꟔닖뫘꿚郜냞藠蛢꟤ꓦꛨ듪곬ퟮ쓰샲쇴", a_)))
					{
						num = (short)41025547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_34D;
				}
				IL_6D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)532480005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1CE:
				num = (short)990904323;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_21C:
				num = (short)217120780;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_257:
				num = (short)1485478578;
				short num4 = num;
				num = (short)649632434;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_21C;
				default:
					num = (short)1731788800;
					if (num != 0)
					{
					}
					num = (short)1417347074;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_34D:
				num = (short)468320257;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_348:
			IL_438:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迊꓌뷎듐냒ꇔ铘듚맜뫞쇠ꇢꛤ꣦짨꟪蓬鳮藰", a_);
			base.Id = 10238;
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTMODEBCOLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007F60 RID: 32608 RVA: 0x00753D54 File Offset: 0x00751F54
		public override void PopulateReferences()
		{
			short num = (short)2018691509;
			short num2 = num;
			num = (short)1721616821;
			switch (num2 == num)
			{
			}
			num = (short)1973944320;
			short num3 = num;
			num = (short)1565982721;
			if (num != 0)
			{
			}
			num = (short)1622999040;
			if (num != 0)
			{
			}
			this.dEKDirectModeZone_A8538.SetRecset(this.a(2051));
			this.dEKDirectModeZone_A8538.AddSlaveField(this.dEKDirectModeChannel_A8535, 10114);
		}

		// Token: 0x06007F61 RID: 32609 RVA: 0x00753E28 File Offset: 0x00752028
		public override void DropReferences()
		{
			short num = (short)1459856577;
			short num2 = num;
			num = (short)416195777;
			switch (num2 == num)
			{
			}
			num = (short)899743744;
			short num3 = num;
			num = (short)320667649;
			if (num != 0)
			{
			}
			num = (short)332660736;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007F62 RID: 32610 RVA: 0x00753ED0 File Offset: 0x007520D0
		public override void SetConstraints()
		{
			short num = (short)1810686720;
			short num2 = num;
			num = (short)185524992;
			switch (num2 == num)
			{
			}
			num = (short)1714946048;
			short num3 = num;
			num = (short)1955069953;
			if (num != 0)
			{
			}
			num = (short)745209856;
			if (num != 0)
			{
			}
			this.dEKDirectModeZone_A8538.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.conReturnTrueIfViewSetToLabtool);
			this.dEKDirectModeZone_A8538.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.conReturnTrueIfViewSetToLabtoolEditbl);
			this.dEKDirectModeChannel_A8535.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.conReturnTrueIfViewSetToLabtool);
			this.dEKDirectModeChannel_A8535.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKConstraints.conReturnTrueIfViewSetToLabtoolEditbl);
		}

		// Token: 0x06007F63 RID: 32611 RVA: 0x00753FD4 File Offset: 0x007521D4
		public override void SetupDependencies()
		{
			short num = (short)1621172774;
			short num2 = num;
			num = (short)1127555622;
			switch (num2 == num)
			{
			}
			num = (short)64552960;
			short num3 = num;
			num = (short)435748865;
			if (num != 0)
			{
			}
			num = (short)959971328;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004126 RID: 16678
		// (get) Token: 0x06007F64 RID: 32612 RVA: 0x00754080 File Offset: 0x00752280
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment ZoneChannelAssignmentForDEKDirectModeZone_A8538
		{
			get
			{
				short num = (short)1240989697;
				if (num != 0)
				{
				}
				num = (short)187464716;
				short num2 = num;
				num = (short)999062540;
				switch (num2 == num)
				{
				default:
				{
					num = (short)455999488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)105709568;
				if (num != 0)
				{
				}
				return this.dEKDirectModeZone_A8538.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
			}
		}

		// Token: 0x17004127 RID: 16679
		// (get) Token: 0x06007F65 RID: 32613 RVA: 0x0075413C File Offset: 0x0075233C
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner ChannelAssignmentListInnerSectionForDEKDirectModeChannel_A8535
		{
			get
			{
				short num = (short)2050089047;
				short num2 = num;
				num = (short)273277015;
				switch (num2 == num)
				{
				}
				num = (short)639303680;
				short num3 = num;
				num = (short)382926849;
				if (num != 0)
				{
				}
				num = (short)1951924224;
				if (num != 0)
				{
				}
				return this.dEKDirectModeChannel_A8535.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
			}
		}

		// Token: 0x17004128 RID: 16680
		// (get) Token: 0x06007F66 RID: 32614 RVA: 0x007541F8 File Offset: 0x007523F8
		public bool HasDiffs
		{
			get
			{
				short num = (short)688148634;
				short num2 = num;
				num = (short)550457498;
				switch (num2 == num)
				{
				}
				num = (short)1814953984;
				short num3 = num;
				num = (short)1507524609;
				if (num != 0)
				{
				}
				num = (short)507969536;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004129 RID: 16681
		// (get) Token: 0x06007F67 RID: 32615 RVA: 0x007542A8 File Offset: 0x007524A8
		// (set) Token: 0x06007F68 RID: 32616 RVA: 0x0075435C File Offset: 0x0075255C
		public int DEKDirectModeBCO_A8534Value
		{
			get
			{
				short num = (short)1350818606;
				short num2 = num;
				num = (short)677501742;
				switch (num2 == num)
				{
				}
				num = (short)2039611392;
				short num3 = num;
				num = (short)106102785;
				if (num != 0)
				{
				}
				num = (short)1032978432;
				if (num != 0)
				{
				}
				return this.dEKDirectModeBCO_A8534.Value;
			}
			set
			{
				short num = (short)537762552;
				short num2 = num;
				num = (short)709401336;
				switch (num2 == num)
				{
				}
				num = (short)1661272064;
				short num3 = num;
				num = (short)46071808;
				if (num != 0)
				{
				}
				num = (short)535560193;
				if (num != 0)
				{
				}
				this.dEKDirectModeBCO_A8534.Value = value;
			}
		}

		// Token: 0x1700412A RID: 16682
		// (get) Token: 0x06007F69 RID: 32617 RVA: 0x00754410 File Offset: 0x00752610
		// (set) Token: 0x06007F6A RID: 32618 RVA: 0x007544C8 File Offset: 0x007526C8
		public string DEKDirectModeBCO_A8534_UIValue
		{
			get
			{
				short num = (short)984788001;
				short num2 = num;
				num = (short)1586998305;
				switch (num2 == num)
				{
				}
				num = (short)1137115136;
				short num3 = num;
				num = (short)1170931713;
				if (num != 0)
				{
				}
				num = (short)860815360;
				if (num != 0)
				{
				}
				return this.dEKDirectModeBCO_A8534.UIValue;
			}
			set
			{
				short num = (short)1561526273;
				if (num != 0)
				{
				}
				num = (short)1510904162;
				short num2 = num;
				num = (short)1902481762;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1826291712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)263258112;
				if (num != 0)
				{
				}
				this.dEKDirectModeBCO_A8534.UIValue = value;
			}
		}

		// Token: 0x1700412B RID: 16683
		// (get) Token: 0x06007F6B RID: 32619 RVA: 0x00754580 File Offset: 0x00752780
		public global::AcpBusinessLayer.AcpListField DEKDirectModeBCO_A8534
		{
			get
			{
				short num = (short)502923265;
				if (num != 0)
				{
				}
				num = (short)51592239;
				short num2 = num;
				num = (short)314391599;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1253572608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)48889856;
				if (num != 0)
				{
				}
				return this.dEKDirectModeBCO_A8534;
			}
		}

		// Token: 0x1700412C RID: 16684
		// (get) Token: 0x06007F6C RID: 32620 RVA: 0x00754630 File Offset: 0x00752830
		// (set) Token: 0x06007F6D RID: 32621 RVA: 0x007546E4 File Offset: 0x007528E4
		public bool DEKDirectModeBCO_A8534_Applicable
		{
			get
			{
				short num = (short)555010912;
				short num2 = num;
				num = (short)72338272;
				switch (num2 == num)
				{
				}
				num = (short)1342832640;
				short num3 = num;
				num = (short)1568669697;
				if (num != 0)
				{
				}
				num = (short)698810368;
				if (num != 0)
				{
				}
				return this.dEKDirectModeBCO_A8534.Applicable;
			}
			set
			{
				short num = (short)157286401;
				if (num != 0)
				{
				}
				num = (short)1389580699;
				short num2 = num;
				num = (short)644632987;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1921449984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)662044672;
				if (num != 0)
				{
				}
				this.dEKDirectModeBCO_A8534.Applicable = value;
			}
		}

		// Token: 0x1700412D RID: 16685
		// (get) Token: 0x06007F6E RID: 32622 RVA: 0x00754798 File Offset: 0x00752998
		// (set) Token: 0x06007F6F RID: 32623 RVA: 0x00754850 File Offset: 0x00752A50
		public bool DEKDirectModeBCO_A8534_Valid
		{
			get
			{
				short num = (short)1914549783;
				short num2 = num;
				num = (short)1230878231;
				switch (num2 == num)
				{
				}
				num = (short)908197888;
				short num3 = num;
				num = (short)790495232;
				if (num != 0)
				{
				}
				num = (short)1275199489;
				if (num != 0)
				{
				}
				return this.dEKDirectModeBCO_A8534.Valid;
			}
			set
			{
				short num = (short)906424751;
				short num2 = num;
				num = (short)394785199;
				switch (num2 == num)
				{
				}
				num = (short)1168179200;
				short num3 = num;
				num = (short)592642049;
				if (num != 0)
				{
				}
				num = (short)62455808;
				if (num != 0)
				{
				}
				this.dEKDirectModeBCO_A8534.Valid = value;
			}
		}

		// Token: 0x1700412E RID: 16686
		// (get) Token: 0x06007F70 RID: 32624 RVA: 0x00754908 File Offset: 0x00752B08
		// (set) Token: 0x06007F71 RID: 32625 RVA: 0x007549C0 File Offset: 0x00752BC0
		public bool DEKDirectModeBCO_A8534_Visible
		{
			get
			{
				short num = (short)421222789;
				short num2 = num;
				num = (short)552032645;
				switch (num2 == num)
				{
				}
				num = (short)523501568;
				short num3 = num;
				num = (short)1998585857;
				if (num != 0)
				{
				}
				num = (short)470548480;
				if (num != 0)
				{
				}
				return this.dEKDirectModeBCO_A8534.Visible;
			}
			set
			{
				short num = (short)1571684353;
				if (num != 0)
				{
				}
				num = (short)308122991;
				short num2 = num;
				num = (short)35427695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)705888256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1129185280;
				if (num != 0)
				{
				}
				this.dEKDirectModeBCO_A8534.Visible = value;
			}
		}

		// Token: 0x1700412F RID: 16687
		// (get) Token: 0x06007F72 RID: 32626 RVA: 0x00754A78 File Offset: 0x00752C78
		// (set) Token: 0x06007F73 RID: 32627 RVA: 0x00754B2C File Offset: 0x00752D2C
		public bool DEKDirectModeBCO_A8534_Editable
		{
			get
			{
				short num = (short)594345985;
				if (num != 0)
				{
				}
				num = (short)686920605;
				short num2 = num;
				num = (short)128619421;
				switch (num2 == num)
				{
				default:
				{
					num = (short)611581952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1161887744;
				if (num != 0)
				{
				}
				return this.dEKDirectModeBCO_A8534.Editable;
			}
			set
			{
				short num = (short)126343661;
				short num2 = num;
				num = (short)140564973;
				switch (num2 == num)
				{
				}
				num = (short)751960064;
				short num3 = num;
				num = (short)348454913;
				if (num != 0)
				{
				}
				num = (short)1793130496;
				if (num != 0)
				{
				}
				this.dEKDirectModeBCO_A8534.Editable = value;
			}
		}

		// Token: 0x17004130 RID: 16688
		// (get) Token: 0x06007F74 RID: 32628 RVA: 0x00754BE0 File Offset: 0x00752DE0
		internal string DEKDirectModeBCO_A8534_UILabel
		{
			get
			{
				short num = (short)2063728641;
				if (num != 0)
				{
				}
				num = (short)840242559;
				short num2 = num;
				num = (short)193009023;
				switch (num2 == num)
				{
				default:
				{
					num = (short)722272256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)808648704;
				if (num != 0)
				{
				}
				return this.dEKDirectModeBCO_A8534.UIName;
			}
		}

		// Token: 0x17004131 RID: 16689
		// (get) Token: 0x06007F75 RID: 32629 RVA: 0x00754C98 File Offset: 0x00752E98
		// (set) Token: 0x06007F76 RID: 32630 RVA: 0x00754D4C File Offset: 0x00752F4C
		internal bool DEKDirectModeBCO_A8534_HiddenStatic
		{
			get
			{
				short num = (short)792899035;
				short num2 = num;
				num = (short)936553947;
				switch (num2 == num)
				{
				}
				num = (short)254345216;
				short num3 = num;
				num = (short)1966473217;
				if (num != 0)
				{
				}
				num = (short)1468727296;
				if (num != 0)
				{
				}
				return this.dEKDirectModeBCO_A8534.HiddenStatic;
			}
			set
			{
				short num = (short)1060782570;
				short num2 = num;
				num = (short)1289306602;
				switch (num2 == num)
				{
				}
				num = (short)129302528;
				short num3 = num;
				num = (short)1065418752;
				if (num != 0)
				{
				}
				num = (short)964427777;
				if (num != 0)
				{
				}
				this.dEKDirectModeBCO_A8534.HiddenStatic = value;
			}
		}

		// Token: 0x17004132 RID: 16690
		// (get) Token: 0x06007F77 RID: 32631 RVA: 0x00754E04 File Offset: 0x00753004
		// (set) Token: 0x06007F78 RID: 32632 RVA: 0x00754EB8 File Offset: 0x007530B8
		internal bool DEKDirectModeBCO_A8534_HiddenDynamic
		{
			get
			{
				short num = (short)1388529874;
				short num2 = num;
				num = (short)1274104018;
				switch (num2 == num)
				{
				}
				num = (short)1514864640;
				short num3 = num;
				num = (short)2020409345;
				if (num != 0)
				{
				}
				num = (short)928120832;
				if (num != 0)
				{
				}
				return this.dEKDirectModeBCO_A8534.HiddenDynamic;
			}
			set
			{
				short num = (short)528352673;
				short num2 = num;
				num = (short)1140786593;
				switch (num2 == num)
				{
				}
				num = (short)2117599232;
				short num3 = num;
				num = (short)481165313;
				if (num != 0)
				{
				}
				num = (short)1596325888;
				if (num != 0)
				{
				}
				this.dEKDirectModeBCO_A8534.HiddenDynamic = value;
			}
		}

		// Token: 0x17004133 RID: 16691
		// (get) Token: 0x06007F79 RID: 32633 RVA: 0x00754F70 File Offset: 0x00753170
		public bool DEKDirectModeBCO_A8534_HasDiffs
		{
			get
			{
				short num = (short)2114453505;
				if (num != 0)
				{
				}
				num = (short)1123473907;
				short num2 = num;
				num = (short)743037427;
				switch (num2 == num)
				{
				default:
				{
					num = (short)133955584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1141964800;
				if (num != 0)
				{
				}
				return this.dEKDirectModeBCO_A8534._HasDiffs;
			}
		}

		// Token: 0x17004134 RID: 16692
		// (get) Token: 0x06007F7A RID: 32634 RVA: 0x00755024 File Offset: 0x00753224
		// (set) Token: 0x06007F7B RID: 32635 RVA: 0x007550D8 File Offset: 0x007532D8
		public int DEKDirectModeZone_A8538Value
		{
			get
			{
				short num = (short)1097535185;
				short num2 = num;
				num = (short)1343885009;
				switch (num2 == num)
				{
				}
				num = (short)532348928;
				short num3 = num;
				num = (short)881393665;
				if (num != 0)
				{
				}
				num = (short)58654720;
				if (num != 0)
				{
				}
				return this.dEKDirectModeZone_A8538.Value;
			}
			set
			{
				short num = (short)1588136498;
				short num2 = num;
				num = (short)1041828402;
				switch (num2 == num)
				{
				}
				num = (short)408289280;
				short num3 = num;
				num = (short)1115160577;
				if (num != 0)
				{
				}
				num = (short)609353728;
				if (num != 0)
				{
				}
				this.dEKDirectModeZone_A8538.Value = value;
			}
		}

		// Token: 0x17004135 RID: 16693
		// (get) Token: 0x06007F7C RID: 32636 RVA: 0x0075518C File Offset: 0x0075338C
		// (set) Token: 0x06007F7D RID: 32637 RVA: 0x00755240 File Offset: 0x00753440
		public string DEKDirectModeZone_A8538_UIValue
		{
			get
			{
				short num = (short)80585592;
				short num2 = num;
				num = (short)1547936632;
				switch (num2 == num)
				{
				}
				num = (short)971898880;
				short num3 = num;
				num = (short)1279393793;
				if (num != 0)
				{
				}
				num = (short)1657077760;
				if (num != 0)
				{
				}
				return this.dEKDirectModeZone_A8538.UIValue;
			}
			set
			{
				short num = (short)1564016641;
				if (num != 0)
				{
				}
				num = (short)1355188916;
				short num2 = num;
				num = (short)1046907572;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1642659840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)134217728;
				if (num != 0)
				{
				}
				this.dEKDirectModeZone_A8538.UIValue = value;
			}
		}

		// Token: 0x17004136 RID: 16694
		// (get) Token: 0x06007F7E RID: 32638 RVA: 0x007552F4 File Offset: 0x007534F4
		public global::AcpBusinessLayer.AcpRecRefField DEKDirectModeZone_A8538
		{
			get
			{
				short num = (short)1441534437;
				short num2 = num;
				num = (short)1266094565;
				switch (num2 == num)
				{
				}
				num = (short)1290993664;
				short num3 = num;
				num = (short)119341057;
				if (num != 0)
				{
				}
				num = (short)989003776;
				if (num != 0)
				{
				}
				return this.dEKDirectModeZone_A8538;
			}
		}

		// Token: 0x17004137 RID: 16695
		// (get) Token: 0x06007F7F RID: 32639 RVA: 0x007553A4 File Offset: 0x007535A4
		// (set) Token: 0x06007F80 RID: 32640 RVA: 0x0075545C File Offset: 0x0075365C
		public bool DEKDirectModeZone_A8538_Applicable
		{
			get
			{
				short num = (short)1789445254;
				short num2 = num;
				num = (short)1718797446;
				switch (num2 == num)
				{
				}
				num = (short)1934295040;
				short num3 = num;
				num = (short)2137194497;
				if (num != 0)
				{
				}
				num = (short)2002190336;
				if (num != 0)
				{
				}
				return this.dEKDirectModeZone_A8538.Applicable;
			}
			set
			{
				short num = (short)993745559;
				short num2 = num;
				num = (short)1949522583;
				switch (num2 == num)
				{
				}
				num = (short)345309184;
				short num3 = num;
				num = (short)1934557185;
				if (num != 0)
				{
				}
				num = (short)631373824;
				if (num != 0)
				{
				}
				this.dEKDirectModeZone_A8538.Applicable = value;
			}
		}

		// Token: 0x17004138 RID: 16696
		// (get) Token: 0x06007F81 RID: 32641 RVA: 0x00755510 File Offset: 0x00753710
		// (set) Token: 0x06007F82 RID: 32642 RVA: 0x007555C4 File Offset: 0x007537C4
		public bool DEKDirectModeZone_A8538_Valid
		{
			get
			{
				short num = (short)579338812;
				short num2 = num;
				num = (short)1212219964;
				switch (num2 == num)
				{
				}
				num = (short)2127101952;
				short num3 = num;
				num = (short)887357441;
				if (num != 0)
				{
				}
				num = (short)1519910912;
				if (num != 0)
				{
				}
				return this.dEKDirectModeZone_A8538.Valid;
			}
			set
			{
				short num = (short)1522459909;
				short num2 = num;
				num = (short)887743749;
				switch (num2 == num)
				{
				}
				num = (short)122355712;
				short num3 = num;
				num = (short)526843905;
				if (num != 0)
				{
				}
				num = (short)1145569280;
				if (num != 0)
				{
				}
				this.dEKDirectModeZone_A8538.Valid = value;
			}
		}

		// Token: 0x17004139 RID: 16697
		// (get) Token: 0x06007F83 RID: 32643 RVA: 0x00755678 File Offset: 0x00753878
		// (set) Token: 0x06007F84 RID: 32644 RVA: 0x00755730 File Offset: 0x00753930
		public bool DEKDirectModeZone_A8538_Visible
		{
			get
			{
				short num = (short)952862848;
				short num2 = num;
				num = (short)271681664;
				switch (num2 == num)
				{
				}
				num = (short)260898816;
				short num3 = num;
				num = (short)376766465;
				if (num != 0)
				{
				}
				num = (short)916848640;
				if (num != 0)
				{
				}
				return this.dEKDirectModeZone_A8538.Visible;
			}
			set
			{
				short num = (short)1876699456;
				short num2 = num;
				num = (short)2132748608;
				switch (num2 == num)
				{
				}
				num = (short)1531052032;
				short num3 = num;
				num = (short)1193148417;
				if (num != 0)
				{
				}
				num = (short)815792128;
				if (num != 0)
				{
				}
				this.dEKDirectModeZone_A8538.Visible = value;
			}
		}

		// Token: 0x1700413A RID: 16698
		// (get) Token: 0x06007F85 RID: 32645 RVA: 0x007557E4 File Offset: 0x007539E4
		// (set) Token: 0x06007F86 RID: 32646 RVA: 0x00755898 File Offset: 0x00753A98
		public bool DEKDirectModeZone_A8538_Editable
		{
			get
			{
				short num = (short)1945442336;
				short num2 = num;
				num = (short)914888736;
				switch (num2 == num)
				{
				}
				num = (short)1665204224;
				short num3 = num;
				num = (short)665780224;
				if (num != 0)
				{
				}
				num = (short)239337473;
				if (num != 0)
				{
				}
				return this.dEKDirectModeZone_A8538.Editable;
			}
			set
			{
				short num = (short)2058173449;
				short num2 = num;
				num = (short)133315593;
				switch (num2 == num)
				{
				}
				num = (short)560660480;
				short num3 = num;
				num = (short)945160193;
				if (num != 0)
				{
				}
				num = (short)1347158016;
				if (num != 0)
				{
				}
				this.dEKDirectModeZone_A8538.Editable = value;
			}
		}

		// Token: 0x1700413B RID: 16699
		// (get) Token: 0x06007F87 RID: 32647 RVA: 0x0075594C File Offset: 0x00753B4C
		internal string DEKDirectModeZone_A8538_UILabel
		{
			get
			{
				short num = (short)1252745827;
				short num2 = num;
				num = (short)592208483;
				switch (num2 == num)
				{
				}
				num = (short)482148352;
				short num3 = num;
				num = (short)867434497;
				if (num != 0)
				{
				}
				num = (short)1121189888;
				if (num != 0)
				{
				}
				return this.dEKDirectModeZone_A8538.UIName;
			}
		}

		// Token: 0x1700413C RID: 16700
		// (get) Token: 0x06007F88 RID: 32648 RVA: 0x00755A00 File Offset: 0x00753C00
		// (set) Token: 0x06007F89 RID: 32649 RVA: 0x00755AB4 File Offset: 0x00753CB4
		internal bool DEKDirectModeZone_A8538_HiddenStatic
		{
			get
			{
				short num = (short)580658043;
				short num2 = num;
				num = (short)1236542331;
				switch (num2 == num)
				{
				}
				num = (short)1071972352;
				short num3 = num;
				num = (short)1556348929;
				if (num != 0)
				{
				}
				num = (short)1653800960;
				if (num != 0)
				{
				}
				return this.dEKDirectModeZone_A8538.HiddenStatic;
			}
			set
			{
				short num = (short)471223078;
				short num2 = num;
				num = (short)300436262;
				switch (num2 == num)
				{
				}
				num = (short)530317313;
				if (num != 0)
				{
				}
				num = (short)874119168;
				if (num != 0)
				{
				}
				num = (short)397606912;
				short num3 = num;
				this.dEKDirectModeZone_A8538.HiddenStatic = value;
			}
		}

		// Token: 0x1700413D RID: 16701
		// (get) Token: 0x06007F8A RID: 32650 RVA: 0x00755B68 File Offset: 0x00753D68
		// (set) Token: 0x06007F8B RID: 32651 RVA: 0x00755C1C File Offset: 0x00753E1C
		internal bool DEKDirectModeZone_A8538_HiddenDynamic
		{
			get
			{
				short num = (short)732372220;
				short num2 = num;
				num = (short)1739332860;
				switch (num2 == num)
				{
				}
				num = (short)1887043584;
				if (num != 0)
				{
				}
				num = (short)873463809;
				if (num != 0)
				{
				}
				num = (short)2077032448;
				short num3 = num;
				return this.dEKDirectModeZone_A8538.HiddenDynamic;
			}
			set
			{
				short num = (short)874624851;
				short num2 = num;
				num = (short)530691923;
				switch (num2 == num)
				{
				}
				num = (short)1042415616;
				if (num != 0)
				{
				}
				num = (short)323682305;
				if (num != 0)
				{
				}
				num = (short)362741760;
				short num3 = num;
				this.dEKDirectModeZone_A8538.HiddenDynamic = value;
			}
		}

		// Token: 0x1700413E RID: 16702
		// (get) Token: 0x06007F8C RID: 32652 RVA: 0x00755CD4 File Offset: 0x00753ED4
		public bool DEKDirectModeZone_A8538_HasDiffs
		{
			get
			{
				short num = (short)226289773;
				short num2 = num;
				num = (short)1145759853;
				switch (num2 == num)
				{
				}
				num = (short)150405121;
				if (num != 0)
				{
				}
				num = (short)899416064;
				if (num != 0)
				{
				}
				num = (short)60817408;
				short num3 = num;
				return this.dEKDirectModeZone_A8538._HasDiffs;
			}
		}

		// Token: 0x1700413F RID: 16703
		// (get) Token: 0x06007F8D RID: 32653 RVA: 0x00755D88 File Offset: 0x00753F88
		// (set) Token: 0x06007F8E RID: 32654 RVA: 0x00755E3C File Offset: 0x0075403C
		public int DEKDirectModeChannel_A8535Value
		{
			get
			{
				short num = (short)834207692;
				short num2 = num;
				num = (short)501481420;
				switch (num2 == num)
				{
				}
				num = (short)795017217;
				if (num != 0)
				{
				}
				num = (short)38273024;
				if (num != 0)
				{
				}
				num = (short)1025966080;
				short num3 = num;
				return this.dEKDirectModeChannel_A8535.Value;
			}
			set
			{
				short num = (short)95347532;
				short num2 = num;
				num = (short)332587852;
				switch (num2 == num)
				{
				}
				num = (short)2085814272;
				if (num != 0)
				{
				}
				num = (short)2004353025;
				if (num != 0)
				{
				}
				num = (short)781189120;
				short num3 = num;
				this.dEKDirectModeChannel_A8535.Value = value;
			}
		}

		// Token: 0x17004140 RID: 16704
		// (get) Token: 0x06007F8F RID: 32655 RVA: 0x00755EF0 File Offset: 0x007540F0
		// (set) Token: 0x06007F90 RID: 32656 RVA: 0x00755FA4 File Offset: 0x007541A4
		public string DEKDirectModeChannel_A8535_UIValue
		{
			get
			{
				short num = (short)506687259;
				short num2 = num;
				num = (short)2036952859;
				switch (num2 == num)
				{
				}
				num = (short)1747779584;
				if (num != 0)
				{
				}
				num = (short)1388380161;
				if (num != 0)
				{
				}
				num = (short)113508352;
				short num3 = num;
				return this.dEKDirectModeChannel_A8535.UIValue;
			}
			set
			{
				short num = (short)1830736553;
				short num2 = num;
				num = (short)796971689;
				switch (num2 == num)
				{
				}
				num = (short)665387009;
				if (num != 0)
				{
				}
				num = (short)1161756672;
				if (num != 0)
				{
				}
				num = (short)764739584;
				short num3 = num;
				this.dEKDirectModeChannel_A8535.UIValue = value;
			}
		}

		// Token: 0x17004141 RID: 16705
		// (get) Token: 0x06007F91 RID: 32657 RVA: 0x0075605C File Offset: 0x0075425C
		public global::AcpBusinessLayer.AcpRecRefField DEKDirectModeChannel_A8535
		{
			get
			{
				short num = (short)832145517;
				short num2 = num;
				num = (short)1426229357;
				switch (num2 == num)
				{
				}
				num = (short)1654063104;
				if (num != 0)
				{
				}
				num = (short)552534017;
				if (num != 0)
				{
				}
				num = (short)1947336704;
				short num3 = num;
				return this.dEKDirectModeChannel_A8535;
			}
		}

		// Token: 0x17004142 RID: 16706
		// (get) Token: 0x06007F92 RID: 32658 RVA: 0x00756110 File Offset: 0x00754310
		// (set) Token: 0x06007F93 RID: 32659 RVA: 0x007561C4 File Offset: 0x007543C4
		public bool DEKDirectModeChannel_A8535_Applicable
		{
			get
			{
				short num = (short)1241468057;
				short num2 = num;
				num = (short)316427417;
				switch (num2 == num)
				{
				}
				num = (short)1407647745;
				if (num != 0)
				{
				}
				num = (short)446955520;
				if (num != 0)
				{
				}
				num = (short)1183842304;
				short num3 = num;
				return this.dEKDirectModeChannel_A8535.Applicable;
			}
			set
			{
				short num = (short)474152961;
				if (num != 0)
				{
				}
				num = (short)136945829;
				short num2 = num;
				num = (short)871276709;
				switch (num2 == num)
				{
				}
				num = (short)665714688;
				if (num != 0)
				{
				}
				num = (short)405798912;
				short num3 = num;
				this.dEKDirectModeChannel_A8535.Applicable = value;
			}
		}

		// Token: 0x17004143 RID: 16707
		// (get) Token: 0x06007F94 RID: 32660 RVA: 0x00756278 File Offset: 0x00754478
		// (set) Token: 0x06007F95 RID: 32661 RVA: 0x0075632C File Offset: 0x0075452C
		public bool DEKDirectModeChannel_A8535_Valid
		{
			get
			{
				short num = (short)1510655866;
				short num2 = num;
				num = (short)401917818;
				switch (num2 == num)
				{
				}
				num = (short)951189504;
				if (num != 0)
				{
				}
				num = (short)211419137;
				if (num != 0)
				{
				}
				num = (short)356909056;
				short num3 = num;
				return this.dEKDirectModeChannel_A8535.Valid;
			}
			set
			{
				short num = (short)500912100;
				short num2 = num;
				num = (short)1371033572;
				switch (num2 == num)
				{
				}
				num = (short)469303297;
				if (num != 0)
				{
				}
				num = (short)1456799744;
				if (num != 0)
				{
				}
				num = (short)2060976128;
				short num3 = num;
				this.dEKDirectModeChannel_A8535.Valid = value;
			}
		}

		// Token: 0x17004144 RID: 16708
		// (get) Token: 0x06007F96 RID: 32662 RVA: 0x007563E0 File Offset: 0x007545E0
		// (set) Token: 0x06007F97 RID: 32663 RVA: 0x00756498 File Offset: 0x00754698
		public bool DEKDirectModeChannel_A8535_Visible
		{
			get
			{
				short num = (short)2084013362;
				short num2 = num;
				num = (short)1105167666;
				switch (num2 == num)
				{
				}
				num = (short)853016576;
				if (num != 0)
				{
				}
				num = (short)574357505;
				if (num != 0)
				{
				}
				num = (short)1723334656;
				short num3 = num;
				return this.dEKDirectModeChannel_A8535.Visible;
			}
			set
			{
				short num = (short)901716953;
				short num2 = num;
				num = (short)1324162009;
				switch (num2 == num)
				{
				}
				num = (short)1576402944;
				if (num != 0)
				{
				}
				num = (short)859504641;
				if (num != 0)
				{
				}
				num = (short)176357376;
				short num3 = num;
				this.dEKDirectModeChannel_A8535.Visible = value;
			}
		}

		// Token: 0x17004145 RID: 16709
		// (get) Token: 0x06007F98 RID: 32664 RVA: 0x0075654C File Offset: 0x0075474C
		// (set) Token: 0x06007F99 RID: 32665 RVA: 0x00756600 File Offset: 0x00754800
		public bool DEKDirectModeChannel_A8535_Editable
		{
			get
			{
				short num = (short)1182294743;
				short num2 = num;
				num = (short)1994220247;
				switch (num2 == num)
				{
				}
				num = (short)408092673;
				if (num != 0)
				{
				}
				num = (short)827916288;
				if (num != 0)
				{
				}
				num = (short)1055522816;
				short num3 = num;
				return this.dEKDirectModeChannel_A8535.Editable;
			}
			set
			{
				short num = (short)2110233133;
				short num2 = num;
				num = (short)1942002221;
				switch (num2 == num)
				{
				}
				num = (short)32440320;
				if (num != 0)
				{
				}
				num = (short)1571487745;
				if (num != 0)
				{
				}
				num = (short)1070465024;
				short num3 = num;
				this.dEKDirectModeChannel_A8535.Editable = value;
			}
		}

		// Token: 0x17004146 RID: 16710
		// (get) Token: 0x06007F9A RID: 32666 RVA: 0x007566B8 File Offset: 0x007548B8
		internal string DEKDirectModeChannel_A8535_UILabel
		{
			get
			{
				short num = (short)906501252;
				short num2 = num;
				num = (short)2112560260;
				switch (num2 == num)
				{
				}
				num = (short)101842944;
				if (num != 0)
				{
				}
				num = (short)1682505729;
				if (num != 0)
				{
				}
				num = (short)1219166208;
				short num3 = num;
				return this.dEKDirectModeChannel_A8535.UIName;
			}
		}

		// Token: 0x17004147 RID: 16711
		// (get) Token: 0x06007F9B RID: 32667 RVA: 0x0075676C File Offset: 0x0075496C
		// (set) Token: 0x06007F9C RID: 32668 RVA: 0x00756820 File Offset: 0x00754A20
		internal bool DEKDirectModeChannel_A8535_HiddenStatic
		{
			get
			{
				short num = (short)1498415105;
				if (num != 0)
				{
				}
				num = (short)1180672537;
				short num2 = num;
				num = (short)722969113;
				switch (num2 == num)
				{
				}
				num = (short)1884684288;
				if (num != 0)
				{
				}
				num = (short)2072772608;
				short num3 = num;
				return this.dEKDirectModeChannel_A8535.HiddenStatic;
			}
			set
			{
				short num = (short)519229830;
				short num2 = num;
				num = (short)993251718;
				switch (num2 == num)
				{
				}
				num = (short)1592983553;
				if (num != 0)
				{
				}
				num = (short)490864640;
				if (num != 0)
				{
				}
				num = (short)1020985344;
				short num3 = num;
				this.dEKDirectModeChannel_A8535.HiddenStatic = value;
			}
		}

		// Token: 0x17004148 RID: 16712
		// (get) Token: 0x06007F9D RID: 32669 RVA: 0x007568D4 File Offset: 0x00754AD4
		// (set) Token: 0x06007F9E RID: 32670 RVA: 0x0075698C File Offset: 0x00754B8C
		internal bool DEKDirectModeChannel_A8535_HiddenDynamic
		{
			get
			{
				short num = (short)2075608680;
				short num2 = num;
				num = (short)1405240936;
				switch (num2 == num)
				{
				}
				num = (short)964755456;
				if (num != 0)
				{
				}
				num = (short)1511063553;
				if (num != 0)
				{
				}
				num = (short)1656684544;
				short num3 = num;
				return this.dEKDirectModeChannel_A8535.HiddenDynamic;
			}
			set
			{
				short num = (short)1316749313;
				if (num != 0)
				{
				}
				num = (short)1276524470;
				short num2 = num;
				num = (short)511522742;
				switch (num2 == num)
				{
				}
				num = (short)1822425088;
				if (num != 0)
				{
				}
				num = (short)1319829504;
				short num3 = num;
				this.dEKDirectModeChannel_A8535.HiddenDynamic = value;
			}
		}

		// Token: 0x17004149 RID: 16713
		// (get) Token: 0x06007F9F RID: 32671 RVA: 0x00756A44 File Offset: 0x00754C44
		public bool DEKDirectModeChannel_A8535_HasDiffs
		{
			get
			{
				short num = (short)661852227;
				short num2 = num;
				num = (short)93065283;
				switch (num2 == num)
				{
				}
				num = (short)1358168064;
				if (num != 0)
				{
				}
				num = (short)514850817;
				if (num != 0)
				{
				}
				num = (short)602472448;
				short num3 = num;
				return this.dEKDirectModeChannel_A8535._HasDiffs;
			}
		}

		// Token: 0x1700414A RID: 16714
		// (get) Token: 0x06007FA0 RID: 32672 RVA: 0x00756AFC File Offset: 0x00754CFC
		// (set) Token: 0x06007FA1 RID: 32673 RVA: 0x00756BB4 File Offset: 0x00754DB4
		public string DEKDirectModeKey_A21200Value
		{
			get
			{
				short num = (short)1705417276;
				short num2 = num;
				num = (short)1641126460;
				switch (num2 == num)
				{
				}
				num = (short)1478295552;
				if (num != 0)
				{
				}
				num = (short)970784769;
				if (num != 0)
				{
				}
				num = (short)844759040;
				short num3 = num;
				return this.dEKDirectModeKey_A21200.Value;
			}
			set
			{
				short num = (short)1146617856;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)50135040;
					short num3 = num;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_5B;
						}
						continue;
					case 1:
					{
						num = (short)661507292;
						short num4 = num;
						num = (short)1746848988;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7F;
						default:
							goto IL_DA;
						}
						break;
					}
					case 2:
						goto IL_7F;
					}
					IL_5B:
					if (!string.IsNullOrEmpty(value.Trim()))
					{
						num = (short)792461314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_7F:
					this.dEKDirectModeKey_A21200.Value = value;
					num = (short)1752170497;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_DA:
				num = (short)1813643265;
				if (num != 0)
				{
				}
				num = (short)2038431744;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700414B RID: 16715
		// (get) Token: 0x06007FA2 RID: 32674 RVA: 0x00756CDC File Offset: 0x00754EDC
		// (set) Token: 0x06007FA3 RID: 32675 RVA: 0x00756D90 File Offset: 0x00754F90
		public string DEKDirectModeKey_A21200_UIValue
		{
			get
			{
				short num = (short)1819664791;
				short num2 = num;
				num = (short)575005079;
				switch (num2 == num)
				{
				}
				num = (short)2036137985;
				if (num != 0)
				{
				}
				num = (short)486801408;
				if (num != 0)
				{
				}
				num = (short)1972436992;
				short num3 = num;
				return this.dEKDirectModeKey_A21200.Value;
			}
			set
			{
				short num = (short)368888099;
				short num2 = num;
				num = (short)159369507;
				switch (num2 == num)
				{
				}
				num = (short)1194590209;
				if (num != 0)
				{
				}
				num = (short)391577600;
				if (num != 0)
				{
				}
				num = (short)38338560;
				short num3 = num;
				this.dEKDirectModeKey_A21200.Value = value;
			}
		}

		// Token: 0x1700414C RID: 16716
		// (get) Token: 0x06007FA4 RID: 32676 RVA: 0x00756E44 File Offset: 0x00755044
		public global::AcpBusinessLayer.AcpKeyField DEKDirectModeKey_A21200
		{
			get
			{
				short num = (short)899968150;
				short num2 = num;
				num = (short)545746070;
				switch (num2 == num)
				{
				}
				num = (short)1928855553;
				if (num != 0)
				{
				}
				num = (short)1924005888;
				if (num != 0)
				{
				}
				num = (short)195362816;
				short num3 = num;
				return this.dEKDirectModeKey_A21200;
			}
		}

		// Token: 0x1700414D RID: 16717
		// (get) Token: 0x06007FA5 RID: 32677 RVA: 0x00756EF4 File Offset: 0x007550F4
		// (set) Token: 0x06007FA6 RID: 32678 RVA: 0x00756FA8 File Offset: 0x007551A8
		public bool DEKDirectModeKey_A21200_Applicable
		{
			get
			{
				short num = (short)240517121;
				if (num != 0)
				{
				}
				num = (short)1808870806;
				short num2 = num;
				num = (short)1483353494;
				switch (num2 == num)
				{
				}
				num = (short)936443904;
				if (num != 0)
				{
				}
				num = (short)330629120;
				short num3 = num;
				return this.dEKDirectModeKey_A21200.Applicable;
			}
			set
			{
				short num = (short)1608253441;
				if (num != 0)
				{
				}
				num = (short)777504879;
				short num2 = num;
				num = (short)730908783;
				switch (num2 == num)
				{
				}
				num = (short)1185021952;
				if (num != 0)
				{
				}
				num = (short)694222848;
				short num3 = num;
				this.dEKDirectModeKey_A21200.Applicable = value;
			}
		}

		// Token: 0x1700414E RID: 16718
		// (get) Token: 0x06007FA7 RID: 32679 RVA: 0x00757058 File Offset: 0x00755258
		// (set) Token: 0x06007FA8 RID: 32680 RVA: 0x0075710C File Offset: 0x0075530C
		public bool DEKDirectModeKey_A21200_Valid
		{
			get
			{
				short num = (short)713245028;
				short num2 = num;
				num = (short)1505444196;
				switch (num2 == num)
				{
				}
				num = (short)1438777345;
				if (num != 0)
				{
				}
				num = (short)951713792;
				if (num != 0)
				{
				}
				num = (short)678166528;
				short num3 = num;
				return this.dEKDirectModeKey_A21200.Valid;
			}
			set
			{
				short num = (short)409622885;
				short num2 = num;
				num = (short)1868912997;
				switch (num2 == num)
				{
				}
				num = (short)2020999169;
				if (num != 0)
				{
				}
				num = (short)1821179904;
				if (num != 0)
				{
				}
				num = (short)729612288;
				short num3 = num;
				this.dEKDirectModeKey_A21200.Valid = value;
			}
		}

		// Token: 0x1700414F RID: 16719
		// (get) Token: 0x06007FA9 RID: 32681 RVA: 0x007571C4 File Offset: 0x007553C4
		// (set) Token: 0x06007FAA RID: 32682 RVA: 0x00757278 File Offset: 0x00755478
		public bool DEKDirectModeKey_A21200_Visible
		{
			get
			{
				short num = (short)862662969;
				short num2 = num;
				num = (short)807481657;
				switch (num2 == num)
				{
				}
				num = (short)810352641;
				if (num != 0)
				{
				}
				num = (short)1237581824;
				if (num != 0)
				{
				}
				num = (short)418643968;
				short num3 = num;
				return this.dEKDirectModeKey_A21200.Visible;
			}
			set
			{
				short num = (short)1163919361;
				if (num != 0)
				{
				}
				num = (short)697349746;
				short num2 = num;
				num = (short)1049081458;
				switch (num2 == num)
				{
				}
				num = (short)1513488384;
				if (num != 0)
				{
				}
				num = (short)1843331072;
				short num3 = num;
				this.dEKDirectModeKey_A21200.Visible = value;
			}
		}

		// Token: 0x17004150 RID: 16720
		// (get) Token: 0x06007FAB RID: 32683 RVA: 0x00757330 File Offset: 0x00755530
		// (set) Token: 0x06007FAC RID: 32684 RVA: 0x007573E8 File Offset: 0x007555E8
		public bool DEKDirectModeKey_A21200_Editable
		{
			get
			{
				short num = (short)294898265;
				short num2 = num;
				num = (short)839830105;
				switch (num2 == num)
				{
				}
				num = (short)269221888;
				if (num != 0)
				{
				}
				num = (short)486735873;
				if (num != 0)
				{
				}
				num = (short)1811218432;
				short num3 = num;
				return this.dEKDirectModeKey_A21200.Editable;
			}
			set
			{
				short num = (short)506433758;
				short num2 = num;
				num = (short)717066462;
				switch (num2 == num)
				{
				}
				num = (short)266862593;
				if (num != 0)
				{
				}
				num = (short)1747845120;
				if (num != 0)
				{
				}
				num = (short)1290141696;
				short num3 = num;
				this.dEKDirectModeKey_A21200.Editable = value;
			}
		}

		// Token: 0x17004151 RID: 16721
		// (get) Token: 0x06007FAD RID: 32685 RVA: 0x0075749C File Offset: 0x0075569C
		internal string DEKDirectModeKey_A21200_UILabel
		{
			get
			{
				short num = (short)686131862;
				short num2 = num;
				num = (short)1651804822;
				switch (num2 == num)
				{
				}
				num = (short)872808448;
				if (num != 0)
				{
				}
				num = (short)1867644929;
				if (num != 0)
				{
				}
				num = (short)2138243072;
				short num3 = num;
				return this.dEKDirectModeKey_A21200.UIName;
			}
		}

		// Token: 0x17004152 RID: 16722
		// (get) Token: 0x06007FAE RID: 32686 RVA: 0x00757550 File Offset: 0x00755750
		// (set) Token: 0x06007FAF RID: 32687 RVA: 0x00757604 File Offset: 0x00755804
		internal bool DEKDirectModeKey_A21200_HiddenStatic
		{
			get
			{
				short num = (short)1379295333;
				short num2 = num;
				num = (short)875651173;
				switch (num2 == num)
				{
				}
				num = (short)290586625;
				if (num != 0)
				{
				}
				num = (short)1190330368;
				if (num != 0)
				{
				}
				num = (short)1795948544;
				short num3 = num;
				return this.dEKDirectModeKey_A21200.HiddenStatic;
			}
			set
			{
				short num = (short)2135556097;
				if (num != 0)
				{
				}
				num = (short)73729493;
				short num2 = num;
				num = (short)777520597;
				switch (num2 == num)
				{
				}
				num = (short)806027264;
				if (num != 0)
				{
				}
				num = (short)1942093824;
				short num3 = num;
				this.dEKDirectModeKey_A21200.HiddenStatic = value;
			}
		}

		// Token: 0x17004153 RID: 16723
		// (get) Token: 0x06007FB0 RID: 32688 RVA: 0x007576BC File Offset: 0x007558BC
		// (set) Token: 0x06007FB1 RID: 32689 RVA: 0x00757774 File Offset: 0x00755974
		internal bool DEKDirectModeKey_A21200_HiddenDynamic
		{
			get
			{
				short num = (short)619706023;
				short num2 = num;
				num = (short)484701863;
				switch (num2 == num)
				{
				}
				num = (short)1662582785;
				if (num != 0)
				{
				}
				num = (short)303759360;
				if (num != 0)
				{
				}
				num = (short)769392640;
				short num3 = num;
				return this.dEKDirectModeKey_A21200.HiddenDynamic;
			}
			set
			{
				short num = (short)1662951349;
				short num2 = num;
				num = (short)917872565;
				switch (num2 == num)
				{
				}
				num = (short)1073676289;
				if (num != 0)
				{
				}
				num = (short)1266876416;
				if (num != 0)
				{
				}
				num = (short)319422464;
				short num3 = num;
				this.dEKDirectModeKey_A21200.HiddenDynamic = value;
			}
		}

		// Token: 0x17004154 RID: 16724
		// (get) Token: 0x06007FB2 RID: 32690 RVA: 0x00757828 File Offset: 0x00755A28
		public bool DEKDirectModeKey_A21200_HasDiffs
		{
			get
			{
				short num = (short)386676616;
				short num2 = num;
				num = (short)1097676680;
				switch (num2 == num)
				{
				}
				num = (short)867827712;
				if (num != 0)
				{
				}
				num = (short)453115905;
				if (num != 0)
				{
				}
				num = (short)2015887360;
				short num3 = num;
				return this.dEKDirectModeKey_A21200._HasDiffs;
			}
		}

		// Token: 0x06007FB3 RID: 32691 RVA: 0x007578D8 File Offset: 0x00755AD8
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
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1711341571;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)379912194;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					num2 = (short)1135607812;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_FF;
				case 4:
					goto IL_13F;
				}
				goto IL_24;
			}
			IL_FF:
			num2 = (short)1254424577;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)2093095690;
			short num3 = num2;
			num2 = (short)2113936138;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_13F:
				if (base.ParentRecset.ContainerDoc != null)
				{
					num2 = (short)2121203712;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				return result;
			case 1:
				break;
			default:
			{
				num2 = (short)558891008;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)789381120;
			if (num2 != 0)
			{
			}
			num2 = (short)136118273;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040039AD RID: 14765
		private global::AcpBusinessLayer.AcpListField dEKDirectModeBCO_A8534;

		// Token: 0x040039AE RID: 14766
		private global::AcpBusinessLayer.AcpRecRefField dEKDirectModeZone_A8538;

		// Token: 0x040039AF RID: 14767
		private global::AcpBusinessLayer.AcpRecRefField dEKDirectModeChannel_A8535;

		// Token: 0x040039B0 RID: 14768
		private global::AcpBusinessLayer.AcpKeyField dEKDirectModeKey_A21200;
	}
}
