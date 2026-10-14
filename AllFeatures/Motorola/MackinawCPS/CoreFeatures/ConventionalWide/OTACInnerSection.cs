using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x02000555 RID: 1365
	[global::System.Serializable]
	public class OTACInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B6A5 RID: 46757 RVA: 0x00A907F8 File Offset: 0x00A8E9F8
		public OTACInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600B6A6 RID: 46758 RVA: 0x00A90814 File Offset: 0x00A8EA14
		protected OTACInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B6A7 RID: 46759 RVA: 0x00A9082C File Offset: 0x00A8EA2C
		public override void Init()
		{
			int a_ = 8;
			short num = (short)1861873913;
			short num2 = num;
			num = (short)142209273;
			switch (num2 == num)
			{
			}
			num = (short)289079296;
			short num3 = num;
			num = (short)1760100353;
			if (num != 0)
			{
			}
			num = (short)1663959040;
			if (num != 0)
			{
			}
			this.cnvWideASTROOTACChannel_A8629 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞껠럢ꓤꓦꫨ菪賬臮鿰雲駴ꣶ룸쏺쯼췾㠀", a_), global::CommonResources.AcgResources.ID_CHANNEL, new string[]
			{
				global::CommonResources.AcgResources.ID_UNPR,
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[]
			{
				0,
				65535
			}, true, false);
			this.cnvWideASTROOTACChannel_A8629.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvWideASTROOTACChannel_A8629.DataTransferOrder = 26;
			this.cnvWideASTROOTACZone_A8645 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞껠럢ꓤꓦ돨蓪菬諮껰닲췴쇶췸컺", a_), global::CommonResources.AcgResources.ID_ZONE, new string[]
			{
				global::CommonResources.AcgResources.ID_UNPR
			}, new int[1], true, false);
			this.cnvWideASTROOTACZone_A8645.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvWideASTROOTACZone_A8645.DataTransferOrder = 2;
			this.cnvWideASTROOTACPosition_A19768 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("諈ꗊ믌风룐럒냔雖諘迚远郞껠럢ꓤꓦ맨蓪黬蛮藰髲髴駶꛸뫺쳼웾㘀㔂㴄", a_), global::CommonResources.AcgResources.ID_POSITION, 100);
			this.cnvWideASTROOTACPosition_A19768.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.cnvWideASTROOTACPosition_A19768.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛈鿊賌賎", a_);
			base.Id = 10056;
			base.UIName = global::CommonResources.AcgResources.ID_OTAC;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600B6A8 RID: 46760 RVA: 0x00A909F4 File Offset: 0x00A8EBF4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 18;
			short num = (short)237043722;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1903165440;
				short num3 = num;
				switch (num2)
				{
				case 0:
					this.cnvWideASTROOTACPosition_A19768 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ軘닚맜뫞ꃠ냢뇤뗦ꛨꓪ맬껮닰ꏲ髴蓶郸迺铼郾漀専䐄㘆〈㰊㬌㜎", a_), global::CommonResources.AcgResources.ID_POSITION, 100);
					this.cnvWideASTROOTACPosition_A19768.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvWideASTROOTACPosition_A19768.DataTransferOrder = -1;
					num = (short)490930184;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_2B5;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郒믔ꇖ軘닚맜뫞ꃠ냢뇤뗦ꛨꓪ맬껮닰ꏲ髴蓶郸迺铼郾漀専䐄㘆〈㰊㬌㜎", a_)))
					{
						num = (short)1572470784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37D;
				case 3:
					num = (short)942080012;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_11A;
				case 5:
				{
					if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郒믔ꇖ軘닚맜뫞ꃠ냢뇤뗦ꛨꓪ맬껮닰꧲髴駶鳸ꓺ볼쟾㜀㜂〄", a_)))
					{
						goto IL_2B5;
					}
					num = (short)364349631;
					short num4 = num;
					num = (short)1986496703;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					default:
						num = (short)1304821760;
						if (num != 0)
						{
						}
						num = (short)983367691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郒믔ꇖ軘닚맜뫞ꃠ냢뇤뗦ꛨꓪ맬껮닰냲鷴零韸闺飼鏾帀䈂㴄ㄆ㬈㈊", a_)))
					{
						num = (short)297271297;
						if (num != 0)
						{
						}
						num = (short)203358217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_11A;
				case 7:
					num = (short)1146421254;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_277;
				case 9:
					this.cnvWideASTROOTACChannel_A8629 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ軘닚맜뫞ꃠ냢뇤뗦ꛨꓪ맬껮닰냲鷴零韸闺飼鏾帀䈂㴄ㄆ㬈㈊", a_), global::CommonResources.AcgResources.ID_CHANNEL, new string[]
					{
						global::CommonResources.AcgResources.ID_UNPR,
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[]
					{
						0,
						65535
					}, true, false);
					this.cnvWideASTROOTACChannel_A8629.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvWideASTROOTACChannel_A8629.DataTransferOrder = 26;
					num = (short)1885798404;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_1D;
				case 11:
					this.cnvWideASTROOTACZone_A8645 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("郒믔ꇖ軘닚맜뫞ꃠ냢뇤뗦ꛨꓪ맬껮닰꧲髴駶鳸ꓺ볼쟾㜀㜂〄", a_), global::CommonResources.AcgResources.ID_ZONE, new string[]
					{
						global::CommonResources.AcgResources.ID_UNPR
					}, new int[1], true, false);
					this.cnvWideASTROOTACZone_A8645.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.cnvWideASTROOTACZone_A8645.DataTransferOrder = 2;
					num = (short)1024917505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (producerFields != null)
					{
						num = (short)563675143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37D;
				}
				goto IL_8A;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_8A:
					if (!global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						goto IL_37D;
					}
					num = (short)215351299;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_11A:
				num = (short)195428357;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B5:
				num = (short)632946690;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_277:
			IL_37D:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鳒臔雖高", a_);
			base.Id = 10056;
			base.UIName = global::CommonResources.AcgResources.ID_OTAC;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600B6A9 RID: 46761 RVA: 0x00A90DB0 File Offset: 0x00A8EFB0
		public override void PopulateReferences()
		{
			short num = (short)1133314032;
			short num2 = num;
			num = (short)2015625200;
			switch (num2 == num)
			{
			default:
			{
				num = (short)79953920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2040791041;
			if (num != 0)
			{
			}
			num = (short)941752320;
			if (num != 0)
			{
			}
			this.cnvWideASTROOTACZone_A8645.SetRecset(this.a(2051));
			this.cnvWideASTROOTACZone_A8645.AddSlaveField(this.cnvWideASTROOTACChannel_A8629, 10114);
		}

		// Token: 0x0600B6AA RID: 46762 RVA: 0x00A90E88 File Offset: 0x00A8F088
		public override void DropReferences()
		{
			short num = (short)74461495;
			short num2 = num;
			num = (short)1408381239;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1601634304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)576913409;
			if (num != 0)
			{
			}
			num = (short)579600384;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B6AB RID: 46763 RVA: 0x00A90F34 File Offset: 0x00A8F134
		public override void SetConstraints()
		{
			short num = (short)1123947529;
			short num2 = num;
			num = (short)1305023497;
			switch (num2 == num)
			{
			default:
			{
				num = (short)917045248;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2121138177;
			if (num != 0)
			{
			}
			num = (short)1402142720;
			if (num != 0)
			{
			}
			this.cnvWideASTROOTACChannel_A8629.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideConstraints.ConASTROOTACChannelApplicable);
			this.cnvWideASTROOTACChannel_A8629.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideConstraints.ConCheckOtacChanValidity);
			this.cnvWideASTROOTACZone_A8645.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideConstraints.ConZoneReferencedIsNormalOrDynamicOneBased);
			this.cnvWideASTROOTACPosition_A19768.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x0600B6AC RID: 46764 RVA: 0x00A91038 File Offset: 0x00A8F238
		public override void SetupDependencies()
		{
			short num = (short)1388249089;
			if (num != 0)
			{
			}
			num = (short)132055040;
			short num2 = num;
			num = (short)413870937;
			short num3 = num;
			num = (short)1372007257;
			switch (num3 == num)
			{
			}
			num = (short)754974720;
			if (num != 0)
			{
			}
			this.cnvWideASTROOTACZone_A8645.AddDependentObject(this.cnvWideASTROOTACChannel_A8629);
		}

		// Token: 0x17005B8B RID: 23435
		// (get) Token: 0x0600B6AD RID: 46765 RVA: 0x00A910F4 File Offset: 0x00A8F2F4
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner ChannelAssignmentListInnerSectionForCnvWideASTROOTACChannel_A8629
		{
			get
			{
				short num = (short)1286793591;
				short num2 = num;
				num = (short)319089015;
				switch (num2 == num)
				{
				default:
				{
					num = (short)247922688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)918749184;
				if (num != 0)
				{
				}
				num = (short)948699137;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACChannel_A8629.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
			}
		}

		// Token: 0x17005B8C RID: 23436
		// (get) Token: 0x0600B6AE RID: 46766 RVA: 0x00A911AC File Offset: 0x00A8F3AC
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment ZoneChannelAssignmentForCnvWideASTROOTACZone_A8645
		{
			get
			{
				short num = (short)1526970115;
				short num2 = num;
				num = (short)1073985283;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1617428480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)124321793;
				if (num != 0)
				{
				}
				num = (short)953352192;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACZone_A8645.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
			}
		}

		// Token: 0x17005B8D RID: 23437
		// (get) Token: 0x0600B6AF RID: 46767 RVA: 0x00A91264 File Offset: 0x00A8F464
		public bool HasDiffs
		{
			get
			{
				short num = (short)28477570;
				short num2 = num;
				num = (short)327125122;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1701707776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)49741825;
				if (num != 0)
				{
				}
				num = (short)699203584;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17005B8E RID: 23438
		// (get) Token: 0x0600B6B0 RID: 46768 RVA: 0x00A91314 File Offset: 0x00A8F514
		// (set) Token: 0x0600B6B1 RID: 46769 RVA: 0x00A913CC File Offset: 0x00A8F5CC
		public int CnvWideASTROOTACChannel_A8629Value
		{
			get
			{
				short num = (short)1726089533;
				short num2 = num;
				num = (short)599329085;
				switch (num2 == num)
				{
				default:
				{
					num = (short)656736256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)157286401;
				if (num != 0)
				{
				}
				num = (short)2041446400;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACChannel_A8629.Value;
			}
			set
			{
				short num = (short)1677293892;
				short num2 = num;
				num = (short)948140356;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1754529792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)34209793;
				if (num != 0)
				{
				}
				num = (short)546832384;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACChannel_A8629.Value = value;
			}
		}

		// Token: 0x17005B8F RID: 23439
		// (get) Token: 0x0600B6B2 RID: 46770 RVA: 0x00A91480 File Offset: 0x00A8F680
		// (set) Token: 0x0600B6B3 RID: 46771 RVA: 0x00A91534 File Offset: 0x00A8F734
		public string CnvWideASTROOTACChannel_A8629_UIValue
		{
			get
			{
				short num = (short)544224668;
				short num2 = num;
				num = (short)1918711196;
				switch (num2 == num)
				{
				default:
				{
					num = (short)263585792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1755119616;
				if (num != 0)
				{
				}
				num = (short)1862533121;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACChannel_A8629.UIValue;
			}
			set
			{
				short num = (short)869970263;
				short num2 = num;
				num = (short)448377175;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2062352384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)907935745;
				if (num != 0)
				{
				}
				num = (short)1161560064;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACChannel_A8629.UIValue = value;
			}
		}

		// Token: 0x17005B90 RID: 23440
		// (get) Token: 0x0600B6B4 RID: 46772 RVA: 0x00A915E8 File Offset: 0x00A8F7E8
		public global::AcpBusinessLayer.AcpRecRefField CnvWideASTROOTACChannel_A8629
		{
			get
			{
				short num = (short)211200121;
				short num2 = num;
				num = (short)9218169;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1359675392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1391394816;
				if (num != 0)
				{
				}
				num = (short)1043791873;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACChannel_A8629;
			}
		}

		// Token: 0x17005B91 RID: 23441
		// (get) Token: 0x0600B6B5 RID: 46773 RVA: 0x00A91698 File Offset: 0x00A8F898
		// (set) Token: 0x0600B6B6 RID: 46774 RVA: 0x00A9174C File Offset: 0x00A8F94C
		public bool CnvWideASTROOTACChannel_A8629_Applicable
		{
			get
			{
				short num = (short)498918403;
				short num2 = num;
				num = (short)957408259;
				switch (num2 == num)
				{
				default:
				{
					num = (short)187367424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1852833793;
				if (num != 0)
				{
				}
				num = (short)1068564480;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACChannel_A8629.Applicable;
			}
			set
			{
				short num = (short)1256608681;
				short num2 = num;
				num = (short)1445090217;
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
				num = (short)2062614529;
				if (num != 0)
				{
				}
				num = (short)422182912;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACChannel_A8629.Applicable = value;
			}
		}

		// Token: 0x17005B92 RID: 23442
		// (get) Token: 0x0600B6B7 RID: 46775 RVA: 0x00A91800 File Offset: 0x00A8FA00
		// (set) Token: 0x0600B6B8 RID: 46776 RVA: 0x00A918B4 File Offset: 0x00A8FAB4
		public bool CnvWideASTROOTACChannel_A8629_Valid
		{
			get
			{
				short num = (short)564802712;
				short num2 = num;
				num = (short)715273368;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1624506368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1821310976;
				if (num != 0)
				{
				}
				num = (short)912982017;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACChannel_A8629.Valid;
			}
			set
			{
				short num = (short)1098186753;
				if (num != 0)
				{
				}
				num = (short)832634880;
				short num2 = num;
				num = (short)863982117;
				short num3 = num;
				num = (short)1147884069;
				switch (num3 == num)
				{
				}
				num = (short)2125266944;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACChannel_A8629.Valid = value;
			}
		}

		// Token: 0x17005B93 RID: 23443
		// (get) Token: 0x0600B6B9 RID: 46777 RVA: 0x00A91968 File Offset: 0x00A8FB68
		// (set) Token: 0x0600B6BA RID: 46778 RVA: 0x00A91A1C File Offset: 0x00A8FC1C
		public bool CnvWideASTROOTACChannel_A8629_Visible
		{
			get
			{
				short num = (short)1244009624;
				short num2 = num;
				num = (short)383390872;
				switch (num2 == num)
				{
				default:
				{
					num = (short)417202176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1310785537;
				if (num != 0)
				{
				}
				num = (short)1826881536;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACChannel_A8629.Visible;
			}
			set
			{
				short num = (short)51443181;
				short num2 = num;
				num = (short)1266021869;
				switch (num2 == num)
				{
				default:
				{
					num = (short)755957760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)362872833;
				if (num != 0)
				{
				}
				num = (short)1576468480;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACChannel_A8629.Visible = value;
			}
		}

		// Token: 0x17005B94 RID: 23444
		// (get) Token: 0x0600B6BB RID: 46779 RVA: 0x00A91AD4 File Offset: 0x00A8FCD4
		// (set) Token: 0x0600B6BC RID: 46780 RVA: 0x00A91B8C File Offset: 0x00A8FD8C
		public bool CnvWideASTROOTACChannel_A8629_Editable
		{
			get
			{
				short num = (short)1572171279;
				short num2 = num;
				num = (short)1033989647;
				switch (num2 == num)
				{
				default:
				{
					num = (short)269746176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1172635648;
				if (num != 0)
				{
				}
				num = (short)1621819393;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACChannel_A8629.Editable;
			}
			set
			{
				short num = (short)1356180107;
				short num2 = num;
				num = (short)898083467;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1652293632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1582759937;
				if (num != 0)
				{
				}
				num = (short)251461632;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACChannel_A8629.Editable = value;
			}
		}

		// Token: 0x17005B95 RID: 23445
		// (get) Token: 0x0600B6BD RID: 46781 RVA: 0x00A91C40 File Offset: 0x00A8FE40
		internal string CnvWideASTROOTACChannel_A8629_UILabel
		{
			get
			{
				short num = (short)1200724343;
				short num2 = num;
				num = (short)1366137207;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1203830784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1383661569;
				if (num != 0)
				{
				}
				num = (short)1969946624;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACChannel_A8629.UIName;
			}
		}

		// Token: 0x17005B96 RID: 23446
		// (get) Token: 0x0600B6BE RID: 46782 RVA: 0x00A91CF0 File Offset: 0x00A8FEF0
		// (set) Token: 0x0600B6BF RID: 46783 RVA: 0x00A91DA4 File Offset: 0x00A8FFA4
		internal bool CnvWideASTROOTACChannel_A8629_HiddenStatic
		{
			get
			{
				short num = (short)1322837567;
				short num2 = num;
				num = (short)170518079;
				switch (num2 == num)
				{
				default:
				{
					num = (short)798818304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1905065984;
				if (num != 0)
				{
				}
				num = (short)72155137;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACChannel_A8629.HiddenStatic;
			}
			set
			{
				short num = (short)1931411457;
				if (num != 0)
				{
				}
				num = (short)1038680064;
				short num2 = num;
				num = (short)1208091872;
				short num3 = num;
				num = (short)583140576;
				switch (num3 == num)
				{
				}
				num = (short)937951232;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACChannel_A8629.HiddenStatic = value;
			}
		}

		// Token: 0x17005B97 RID: 23447
		// (get) Token: 0x0600B6C0 RID: 46784 RVA: 0x00A91E58 File Offset: 0x00A90058
		// (set) Token: 0x0600B6C1 RID: 46785 RVA: 0x00A91F0C File Offset: 0x00A9010C
		internal bool CnvWideASTROOTACChannel_A8629_HiddenDynamic
		{
			get
			{
				short num = (short)1604396941;
				short num2 = num;
				num = (short)1969891213;
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
				num = (short)2113142785;
				if (num != 0)
				{
				}
				num = (short)2043019264;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACChannel_A8629.HiddenDynamic;
			}
			set
			{
				short num = (short)734668648;
				short num2 = num;
				num = (short)168896360;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1624834048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)379977729;
				if (num != 0)
				{
				}
				num = (short)2027945984;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACChannel_A8629.HiddenDynamic = value;
			}
		}

		// Token: 0x17005B98 RID: 23448
		// (get) Token: 0x0600B6C2 RID: 46786 RVA: 0x00A91FC4 File Offset: 0x00A901C4
		public bool CnvWideASTROOTACChannel_A8629_HasDiffs
		{
			get
			{
				short num = (short)1311047681;
				if (num != 0)
				{
				}
				num = (short)600768512;
				short num2 = num;
				num = (short)1138515773;
				short num3 = num;
				num = (short)779312957;
				switch (num3 == num)
				{
				}
				num = (short)2033975296;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACChannel_A8629._HasDiffs;
			}
		}

		// Token: 0x17005B99 RID: 23449
		// (get) Token: 0x0600B6C3 RID: 46787 RVA: 0x00A9207C File Offset: 0x00A9027C
		// (set) Token: 0x0600B6C4 RID: 46788 RVA: 0x00A92130 File Offset: 0x00A90330
		public int CnvWideASTROOTACZone_A8645Value
		{
			get
			{
				short num = (short)1851459251;
				short num2 = num;
				num = (short)1239025331;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1460928512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)922746881;
				if (num != 0)
				{
				}
				num = (short)494600192;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACZone_A8645.Value;
			}
			set
			{
				short num = (short)570104234;
				short num2 = num;
				num = (short)1377900970;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1003814912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)568328192;
				if (num != 0)
				{
				}
				num = (short)609746945;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACZone_A8645.Value = value;
			}
		}

		// Token: 0x17005B9A RID: 23450
		// (get) Token: 0x0600B6C5 RID: 46789 RVA: 0x00A921E4 File Offset: 0x00A903E4
		// (set) Token: 0x0600B6C6 RID: 46790 RVA: 0x00A92294 File Offset: 0x00A90494
		public string CnvWideASTROOTACZone_A8645_UIValue
		{
			get
			{
				short num = (short)1361472622;
				short num2 = num;
				num = (short)2054777966;
				switch (num2 == num)
				{
				default:
				{
					num = (short)792199168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1182138368;
				if (num != 0)
				{
				}
				num = (short)1328414721;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACZone_A8645.UIValue;
			}
			set
			{
				short num = (short)1231052210;
				short num2 = num;
				num = (short)1120689586;
				switch (num2 == num)
				{
				default:
				{
					num = (short)379846656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2130509825;
				if (num != 0)
				{
				}
				num = (short)1938227200;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACZone_A8645.UIValue = value;
			}
		}

		// Token: 0x17005B9B RID: 23451
		// (get) Token: 0x0600B6C7 RID: 46791 RVA: 0x00A9234C File Offset: 0x00A9054C
		public global::AcpBusinessLayer.AcpRecRefField CnvWideASTROOTACZone_A8645
		{
			get
			{
				short num = (short)1307564749;
				short num2 = num;
				num = (short)237492941;
				switch (num2 == num)
				{
				default:
				{
					num = (short)350748672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)819462145;
				if (num != 0)
				{
				}
				num = (short)1658126336;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACZone_A8645;
			}
		}

		// Token: 0x17005B9C RID: 23452
		// (get) Token: 0x0600B6C8 RID: 46792 RVA: 0x00A92400 File Offset: 0x00A90600
		// (set) Token: 0x0600B6C9 RID: 46793 RVA: 0x00A924B0 File Offset: 0x00A906B0
		public bool CnvWideASTROOTACZone_A8645_Applicable
		{
			get
			{
				short num = (short)2069692417;
				if (num != 0)
				{
				}
				num = (short)355991552;
				short num2 = num;
				num = (short)1453421756;
				short num3 = num;
				num = (short)1455649980;
				switch (num3 == num)
				{
				}
				num = (short)2113470464;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACZone_A8645.Applicable;
			}
			set
			{
				short num = (short)1129865278;
				short num2 = num;
				num = (short)1030119486;
				switch (num2 == num)
				{
				default:
				{
					num = (short)378011648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1286406145;
				if (num != 0)
				{
				}
				num = (short)1460600832;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACZone_A8645.Applicable = value;
			}
		}

		// Token: 0x17005B9D RID: 23453
		// (get) Token: 0x0600B6CA RID: 46794 RVA: 0x00A92564 File Offset: 0x00A90764
		// (set) Token: 0x0600B6CB RID: 46795 RVA: 0x00A92618 File Offset: 0x00A90818
		public bool CnvWideASTROOTACZone_A8645_Valid
		{
			get
			{
				short num = (short)606961318;
				short num2 = num;
				num = (short)151813798;
				switch (num2 == num)
				{
				default:
				{
					num = (short)870449152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1822752769;
				if (num != 0)
				{
				}
				num = (short)1054605312;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACZone_A8645.Valid;
			}
			set
			{
				short num = (short)320602113;
				if (num != 0)
				{
				}
				num = (short)281018368;
				short num2 = num;
				num = (short)1425450578;
				short num3 = num;
				num = (short)449554002;
				switch (num3 == num)
				{
				}
				num = (short)1463877632;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACZone_A8645.Valid = value;
			}
		}

		// Token: 0x17005B9E RID: 23454
		// (get) Token: 0x0600B6CC RID: 46796 RVA: 0x00A926CC File Offset: 0x00A908CC
		// (set) Token: 0x0600B6CD RID: 46797 RVA: 0x00A92780 File Offset: 0x00A90980
		public bool CnvWideASTROOTACZone_A8645_Visible
		{
			get
			{
				short num = (short)996775277;
				short num2 = num;
				num = (short)1752667501;
				switch (num2 == num)
				{
				default:
				{
					num = (short)503906304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1743650816;
				if (num != 0)
				{
				}
				num = (short)2076049409;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACZone_A8645.Visible;
			}
			set
			{
				short num = (short)2065780944;
				short num2 = num;
				num = (short)1707954384;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2139422720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)163971073;
				if (num != 0)
				{
				}
				num = (short)1619263488;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACZone_A8645.Visible = value;
			}
		}

		// Token: 0x17005B9F RID: 23455
		// (get) Token: 0x0600B6CE RID: 46798 RVA: 0x00A92834 File Offset: 0x00A90A34
		// (set) Token: 0x0600B6CF RID: 46799 RVA: 0x00A928E8 File Offset: 0x00A90AE8
		public bool CnvWideASTROOTACZone_A8645_Editable
		{
			get
			{
				short num = (short)958536430;
				short num2 = num;
				num = (short)1296243438;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1591476224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1580597248;
				if (num != 0)
				{
				}
				num = (short)1701838849;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACZone_A8645.Editable;
			}
			set
			{
				short num = (short)208465054;
				short num2 = num;
				num = (short)1583017118;
				switch (num2 == num)
				{
				default:
				{
					num = (short)629276672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1544749056;
				if (num != 0)
				{
				}
				num = (short)353370113;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACZone_A8645.Editable = value;
			}
		}

		// Token: 0x17005BA0 RID: 23456
		// (get) Token: 0x0600B6D0 RID: 46800 RVA: 0x00A929A0 File Offset: 0x00A90BA0
		internal string CnvWideASTROOTACZone_A8645_UILabel
		{
			get
			{
				short num = (short)439973606;
				short num2 = num;
				num = (short)950957798;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1450180608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)374538241;
				if (num != 0)
				{
				}
				num = (short)2082013184;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACZone_A8645.UIName;
			}
		}

		// Token: 0x17005BA1 RID: 23457
		// (get) Token: 0x0600B6D1 RID: 46801 RVA: 0x00A92A54 File Offset: 0x00A90C54
		// (set) Token: 0x0600B6D2 RID: 46802 RVA: 0x00A92B04 File Offset: 0x00A90D04
		internal bool CnvWideASTROOTACZone_A8645_HiddenStatic
		{
			get
			{
				short num = (short)828702721;
				if (num != 0)
				{
				}
				num = (short)1022951424;
				short num2 = num;
				num = (short)1535052041;
				short num3 = num;
				num = (short)1498810633;
				switch (num3 == num)
				{
				}
				num = (short)1824587776;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACZone_A8645.HiddenStatic;
			}
			set
			{
				short num = (short)2682821;
				short num2 = num;
				num = (short)163377093;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2093940736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)821952513;
				if (num != 0)
				{
				}
				num = (short)380239872;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACZone_A8645.HiddenStatic = value;
			}
		}

		// Token: 0x17005BA2 RID: 23458
		// (get) Token: 0x0600B6D3 RID: 46803 RVA: 0x00A92BB8 File Offset: 0x00A90DB8
		// (set) Token: 0x0600B6D4 RID: 46804 RVA: 0x00A92C6C File Offset: 0x00A90E6C
		internal bool CnvWideASTROOTACZone_A8645_HiddenDynamic
		{
			get
			{
				short num = (short)1137302014;
				short num2 = num;
				num = (short)1942804990;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1644429312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)497549313;
				if (num != 0)
				{
				}
				num = (short)628817920;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACZone_A8645.HiddenDynamic;
			}
			set
			{
				short num = (short)1077334183;
				short num2 = num;
				num = (short)900059303;
				switch (num2 == num)
				{
				default:
				{
					num = (short)319422464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)372375553;
				if (num != 0)
				{
				}
				num = (short)1731133440;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACZone_A8645.HiddenDynamic = value;
			}
		}

		// Token: 0x17005BA3 RID: 23459
		// (get) Token: 0x0600B6D5 RID: 46805 RVA: 0x00A92D24 File Offset: 0x00A90F24
		public bool CnvWideASTROOTACZone_A8645_HasDiffs
		{
			get
			{
				short num = (short)1033785387;
				short num2 = num;
				num = (short)493899819;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1515651072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)173539328;
				if (num != 0)
				{
				}
				num = (short)1944322049;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACZone_A8645._HasDiffs;
			}
		}

		// Token: 0x17005BA4 RID: 23460
		// (get) Token: 0x0600B6D6 RID: 46806 RVA: 0x00A92DDC File Offset: 0x00A90FDC
		// (set) Token: 0x0600B6D7 RID: 46807 RVA: 0x00A92E90 File Offset: 0x00A91090
		public string CnvWideASTROOTACPosition_A19768Value
		{
			get
			{
				short num = (short)978133558;
				short num2 = num;
				num = (short)1944592950;
				switch (num2 == num)
				{
				default:
				{
					num = (short)27525120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)426311681;
				if (num != 0)
				{
				}
				num = (short)313982976;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACPosition_A19768.Value;
			}
			set
			{
				short num = (short)1664090114;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.cnvWideASTROOTACPosition_A19768.Value = value;
						num = (short)1009844225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					num = (short)2010361936;
					short num3 = num;
					num = (short)1910943824;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1883963392;
						if (num != 0)
						{
						}
						num = (short)1579220992;
						short num4 = num;
						num = (short)2052915201;
						if (num != 0)
						{
						}
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)307625984;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x17005BA5 RID: 23461
		// (get) Token: 0x0600B6D8 RID: 46808 RVA: 0x00A92FB8 File Offset: 0x00A911B8
		// (set) Token: 0x0600B6D9 RID: 46809 RVA: 0x00A93070 File Offset: 0x00A91270
		public string CnvWideASTROOTACPosition_A19768_UIValue
		{
			get
			{
				short num = (short)1831731201;
				if (num != 0)
				{
				}
				num = (short)1221173279;
				short num2 = num;
				num = (short)681287711;
				switch (num2 == num)
				{
				}
				num = (short)1205796864;
				short num3 = num;
				num = (short)1502740480;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACPosition_A19768.Value;
			}
			set
			{
				short num = (short)1206189834;
				short num2 = num;
				num = (short)295894794;
				switch (num2 == num)
				{
				}
				num = (short)219414528;
				if (num != 0)
				{
				}
				num = (short)1007747072;
				short num3 = num;
				num = (short)1129709569;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACPosition_A19768.Value = value;
			}
		}

		// Token: 0x17005BA6 RID: 23462
		// (get) Token: 0x0600B6DA RID: 46810 RVA: 0x00A93128 File Offset: 0x00A91328
		public global::AcpBusinessLayer.AcpKeyField CnvWideASTROOTACPosition_A19768
		{
			get
			{
				short num = (short)1104303524;
				short num2 = num;
				num = (short)843797924;
				switch (num2 == num)
				{
				}
				num = (short)1840906241;
				if (num != 0)
				{
				}
				num = (short)251002880;
				short num3 = num;
				num = (short)410386432;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACPosition_A19768;
			}
		}

		// Token: 0x17005BA7 RID: 23463
		// (get) Token: 0x0600B6DB RID: 46811 RVA: 0x00A931D8 File Offset: 0x00A913D8
		// (set) Token: 0x0600B6DC RID: 46812 RVA: 0x00A9328C File Offset: 0x00A9148C
		public bool CnvWideASTROOTACPosition_A19768_Applicable
		{
			get
			{
				short num = (short)152764417;
				if (num != 0)
				{
				}
				num = (short)673056892;
				short num2 = num;
				num = (short)1130825852;
				switch (num2 == num)
				{
				}
				num = (short)876609536;
				short num3 = num;
				num = (short)1619197952;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACPosition_A19768.Applicable;
			}
			set
			{
				short num = (short)189857793;
				if (num != 0)
				{
				}
				num = (short)1644883845;
				short num2 = num;
				num = (short)418770821;
				switch (num2 == num)
				{
				}
				num = (short)236126208;
				short num3 = num;
				num = (short)1227554816;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACPosition_A19768.Applicable = value;
			}
		}

		// Token: 0x17005BA8 RID: 23464
		// (get) Token: 0x0600B6DD RID: 46813 RVA: 0x00A93344 File Offset: 0x00A91544
		// (set) Token: 0x0600B6DE RID: 46814 RVA: 0x00A933FC File Offset: 0x00A915FC
		public bool CnvWideASTROOTACPosition_A19768_Valid
		{
			get
			{
				short num = (short)1072175077;
				short num2 = num;
				num = (short)1207703525;
				switch (num2 == num)
				{
				}
				num = (short)1087635457;
				if (num != 0)
				{
				}
				num = (short)1741160448;
				short num3 = num;
				num = (short)1755447296;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACPosition_A19768.Valid;
			}
			set
			{
				short num = (short)1595229805;
				short num2 = num;
				num = (short)168838765;
				switch (num2 == num)
				{
				}
				num = (short)505741313;
				if (num != 0)
				{
				}
				num = (short)1927217152;
				short num3 = num;
				num = (short)1615003648;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACPosition_A19768.Valid = value;
			}
		}

		// Token: 0x17005BA9 RID: 23465
		// (get) Token: 0x0600B6DF RID: 46815 RVA: 0x00A934B4 File Offset: 0x00A916B4
		// (set) Token: 0x0600B6E0 RID: 46816 RVA: 0x00A9356C File Offset: 0x00A9176C
		public bool CnvWideASTROOTACPosition_A19768_Visible
		{
			get
			{
				short num = (short)1144188743;
				short num2 = num;
				num = (short)1691217735;
				switch (num2 == num)
				{
				}
				num = (short)720830465;
				if (num != 0)
				{
				}
				num = (short)797507584;
				short num3 = num;
				num = (short)1603862528;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACPosition_A19768.Visible;
			}
			set
			{
				short num = (short)2002590128;
				short num2 = num;
				num = (short)1426659760;
				switch (num2 == num)
				{
				}
				num = (short)156827649;
				if (num != 0)
				{
				}
				num = (short)1324417024;
				short num3 = num;
				num = (short)637861888;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACPosition_A19768.Visible = value;
			}
		}

		// Token: 0x17005BAA RID: 23466
		// (get) Token: 0x0600B6E1 RID: 46817 RVA: 0x00A93628 File Offset: 0x00A91828
		// (set) Token: 0x0600B6E2 RID: 46818 RVA: 0x00A936DC File Offset: 0x00A918DC
		public bool CnvWideASTROOTACPosition_A19768_Editable
		{
			get
			{
				short num = (short)2085432406;
				short num2 = num;
				num = (short)251669590;
				switch (num2 == num)
				{
				}
				num = (short)758841345;
				if (num != 0)
				{
				}
				num = (short)793378816;
				short num3 = num;
				num = (short)971636736;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACPosition_A19768.Editable;
			}
			set
			{
				short num = (short)1727261819;
				short num2 = num;
				num = (short)858057851;
				switch (num2 == num)
				{
				}
				num = (short)216793089;
				if (num != 0)
				{
				}
				num = (short)1657405440;
				short num3 = num;
				num = (short)1812135936;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACPosition_A19768.Editable = value;
			}
		}

		// Token: 0x17005BAB RID: 23467
		// (get) Token: 0x0600B6E3 RID: 46819 RVA: 0x00A93794 File Offset: 0x00A91994
		internal string CnvWideASTROOTACPosition_A19768_UILabel
		{
			get
			{
				short num = (short)234095601;
				short num2 = num;
				num = (short)2062353393;
				switch (num2 == num)
				{
				}
				num = (short)593625089;
				if (num != 0)
				{
				}
				num = (short)1371471872;
				short num3 = num;
				num = (short)1620443136;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACPosition_A19768.UIName;
			}
		}

		// Token: 0x17005BAC RID: 23468
		// (get) Token: 0x0600B6E4 RID: 46820 RVA: 0x00A93848 File Offset: 0x00A91A48
		// (set) Token: 0x0600B6E5 RID: 46821 RVA: 0x00A938FC File Offset: 0x00A91AFC
		internal bool CnvWideASTROOTACPosition_A19768_HiddenStatic
		{
			get
			{
				short num = (short)2045479481;
				short num2 = num;
				num = (short)1605143097;
				switch (num2 == num)
				{
				}
				num = (short)796262401;
				if (num != 0)
				{
				}
				num = (short)1551433728;
				short num3 = num;
				num = (short)733151232;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACPosition_A19768.HiddenStatic;
			}
			set
			{
				short num = (short)1894776833;
				if (num != 0)
				{
				}
				num = (short)1060679760;
				short num2 = num;
				num = (short)327659600;
				switch (num2 == num)
				{
				}
				num = (short)998309888;
				short num3 = num;
				num = (short)686161920;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACPosition_A19768.HiddenStatic = value;
			}
		}

		// Token: 0x17005BAD RID: 23469
		// (get) Token: 0x0600B6E6 RID: 46822 RVA: 0x00A939B0 File Offset: 0x00A91BB0
		// (set) Token: 0x0600B6E7 RID: 46823 RVA: 0x00A93A64 File Offset: 0x00A91C64
		internal bool CnvWideASTROOTACPosition_A19768_HiddenDynamic
		{
			get
			{
				short num = (short)1617850072;
				short num2 = num;
				num = (short)1290628824;
				switch (num2 == num)
				{
				}
				num = (short)1483014144;
				if (num != 0)
				{
				}
				num = (short)777388032;
				short num3 = num;
				num = (short)1843068929;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACPosition_A19768.HiddenDynamic;
			}
			set
			{
				short num = (short)2058067150;
				short num2 = num;
				num = (short)1896979662;
				switch (num2 == num)
				{
				}
				num = (short)598081537;
				if (num != 0)
				{
				}
				num = (short)1854013440;
				short num3 = num;
				num = (short)174456832;
				if (num != 0)
				{
				}
				this.cnvWideASTROOTACPosition_A19768.HiddenDynamic = value;
			}
		}

		// Token: 0x17005BAE RID: 23470
		// (get) Token: 0x0600B6E8 RID: 46824 RVA: 0x00A93B14 File Offset: 0x00A91D14
		public bool CnvWideASTROOTACPosition_A19768_HasDiffs
		{
			get
			{
				short num = (short)1968184209;
				short num2 = num;
				num = (short)1922309009;
				switch (num2 == num)
				{
				}
				num = (short)1899823104;
				if (num != 0)
				{
				}
				num = (short)779812864;
				short num3 = num;
				num = (short)667877377;
				if (num != 0)
				{
				}
				return this.cnvWideASTROOTACPosition_A19768._HasDiffs;
			}
		}

		// Token: 0x0600B6E9 RID: 46825 RVA: 0x00A93BC8 File Offset: 0x00A91DC8
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
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)1530550991;
					short num3 = num2;
					num2 = (short)1013340879;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9A;
					default:
						num2 = (short)1761345536;
						if (num2 != 0)
						{
						}
						num2 = (short)1528299524;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (base.ParentRecset != null)
					{
						goto IL_9A;
					}
					return result;
				case 2:
					return result;
				case 3:
					num2 = (short)1233649664;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1538916354;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_9A:
				num2 = (short)202964995;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			num2 = (short)102170624;
			short num4 = num2;
			result = null;
			num2 = (short)1503002625;
			if (num2 != 0)
			{
			}
			num2 = (short)391774209;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040058C3 RID: 22723
		private global::AcpBusinessLayer.AcpRecRefField cnvWideASTROOTACChannel_A8629;

		// Token: 0x040058C4 RID: 22724
		private global::AcpBusinessLayer.AcpRecRefField cnvWideASTROOTACZone_A8645;

		// Token: 0x040058C5 RID: 22725
		private global::AcpBusinessLayer.AcpKeyField cnvWideASTROOTACPosition_A19768;
	}
}
