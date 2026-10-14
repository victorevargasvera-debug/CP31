using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.ScanList
{
	// Token: 0x0200011E RID: 286
	[global::System.Serializable]
	public class ScanListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06002A14 RID: 10772 RVA: 0x00290E94 File Offset: 0x0028F094
		public ScanListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x00290EB0 File Offset: 0x0028F0B0
		protected ScanListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06002A16 RID: 10774 RVA: 0x00290EC8 File Offset: 0x0028F0C8
		public override void Init()
		{
			int a_ = 2;
			short num = (short)1908471585;
			short num2 = num;
			num = (short)1152841505;
			switch (num2 == num)
			{
			}
			num = (short)1558708224;
			short num3 = num;
			num = (short)2091581440;
			if (num != 0)
			{
			}
			num = (short)990773249;
			if (num != 0)
			{
			}
			this.scanLstScanListZone_A9718 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("郂ꛄꛆꟈ蟊뻌믎苐냒듔맖闘닚껜ꯞ믠賢诤苦뛨ꫪ퓬\ud8ee샰쯲", a_), global::CommonResources.AcgResources.ID_ZONE, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.scanLstScanListZone_A9718.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.scanLstScanListZone_A9718.DataTransferOrder = 2;
			this.scanLstScanListZone_A9718.ValidateAcrossRecset = true;
			this.scanLstScanListZone_A9718.KeyNameField = true;
			this.scanLstScanListKeyofScanListMBRTable_A12673 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("郂ꛄꛆꟈ蟊뻌믎苐냒듔맖闘닚껜ꯞꫠ蛢鳤裦迨룪軬軮鿰뿲鳴蓶跸뛺뿼귾唀戂朄欆氈吊䰌㸎⌐┒∔␖", a_), global::CommonResources.AcgResources.ID_SCANLISTMEMBER);
			this.scanLstScanListKeyofScanListMBRTable_A12673.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.scanLstScanListKeyofScanListMBRTable_A12673.DataTransferOrder = -1;
			this.scanLstScanListChannel_A7620 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("郂ꛄꛆꟈ蟊뻌믎苐냒듔맖闘닚껜ꯞꋠ询蓤触蟨軪臬냮냰쓲쏴엶째", a_), global::CommonResources.AcgResources.ID_CHANNEL, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.scanLstScanListChannel_A7620.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.scanLstScanListChannel_A7620.DataTransferOrder = 7;
			this.scanLstScanListChannel_A7620.KeyNameField = true;
			this.scanLstScanListLTEInterferingFreqPresent_A42196 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("郂ꛄꛆꟈ蟊뻌믎苐냒듔맖闘닚껜ꯞ균럢ꃤ껦蟨鿪裬鷮韰雲蟴黶韸鳺민跾搀爂唄甆氈砊栌愎攐䰒吔⌖⬘⨚␜⤞", a_), global::CommonResources.AcgResources.ID_LTEINTERFERINGFREQPRESENT);
			this.scanLstScanListLTEInterferingFreqPresent_A42196.IgnoreOnCompare = true;
			this.scanLstScanListLTEInterferingFreqPresent_A42196.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.scanLstScanListLTEInterferingFreqPresent_A42196.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("郂ꛄꛆꟈ背꫎볐뇒냔ꗖ律韚드곞闠", a_);
			base.Id = 10133;
			base.UIName = global::CommonResources.AcgResources.ID_SCANMEMBERLIST;
			base.DataTransferOrder = 1;
			this.b();
		}

		// Token: 0x06002A17 RID: 10775 RVA: 0x002910EC File Offset: 0x0028F2EC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 15;
			short num = (short)1108344839;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)342556685;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.scanLstScanListChannel_A7620 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("菏뇑뗓룕铗꧙꣛距菟菡諣ꫥ臧駩飫귭飯鏱髳飵鷷雹ꏻ뿽㟿㐁㘃㘅", a_), global::CommonResources.AcgResources.ID_CHANNEL, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.scanLstScanListChannel_A7620.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.scanLstScanListChannel_A7620.DataTransferOrder = 7;
					this.scanLstScanListChannel_A7620.KeyNameField = true;
					num = (short)321781771;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菏뇑뗓룕铗꧙꣛距菟菡諣ꫥ臧駩飫귭飯鏱髳飵鷷雹ꏻ뿽㟿㐁㘃㘅", a_)))
					{
						num = (short)1088618497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FA;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菏뇑뗓룕铗꧙꣛距菟菡諣ꫥ臧駩飫ꗭ闯诱鯳郵꯷駹鷻都䳿欁眃爅䔇䠉帋娍焏瀑砓猕䜗嬙ⴛⰝᘟᔡᜣ", a_)))
					{
						num = (short)1865220111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2CE;
				case 4:
				{
					num = (short)2039979788;
					short num3 = num;
					num = (short)43360012;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_44B;
					default:
						num = (short)1718222848;
						if (num != 0)
						{
						}
						this.scanLstScanListLTEInterferingFreqPresent_A42196 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("菏뇑뗓룕铗꧙꣛距菟菡諣ꫥ臧駩飫ꋭꓯ럱뷳飵賷鿹軻飽旿瀁洃栅漇䰉縋欍意䈑易猕欗缙爛樝缟挡ဣᐥᤧጩᨫ", a_), global::CommonResources.AcgResources.ID_LTEINTERFERINGFREQPRESENT);
						this.scanLstScanListLTEInterferingFreqPresent_A42196.IgnoreOnCompare = true;
						this.scanLstScanListLTEInterferingFreqPresent_A42196.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
						this.scanLstScanListLTEInterferingFreqPresent_A42196.DataTransferOrder = -1;
						num = (short)1987575822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					this.scanLstScanListZone_A9718 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("菏뇑뗓룕铗꧙꣛距菟菡諣ꫥ臧駩飫듭鿯鳱釳꧵맷쏹쯻쿽㣿", a_), global::CommonResources.AcgResources.ID_ZONE, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.scanLstScanListZone_A9718.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.scanLstScanListZone_A9718.DataTransferOrder = 2;
					this.scanLstScanListZone_A9718.ValidateAcrossRecset = true;
					this.scanLstScanListZone_A9718.KeyNameField = true;
					num = (short)1572601864;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菏뇑뗓룕铗꧙꣛距菟菡諣ꫥ臧駩飫듭鿯鳱釳꧵맷쏹쯻쿽㣿", a_)))
					{
						num = (short)119209989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_380;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_6F;
					}
					continue;
				case 8:
					goto IL_44B;
				case 9:
					num = (short)489684998;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_2CE;
				case 11:
					goto IL_1FA;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("菏뇑뗓룕铗꧙꣛距菟菡諣ꫥ臧駩飫ꋭꓯ럱뷳飵賷鿹軻飽旿瀁洃栅漇䰉縋欍意䈑易猕欗缙爛樝缟挡ဣᐥᤧጩᨫ", a_)))
					{
						num = (short)1001848836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_450;
				case 13:
					if (producerFields != null)
					{
						num = (short)492568585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_450;
				case 14:
					goto IL_37B;
				case 15:
					this.scanLstScanListKeyofScanListMBRTable_A12673 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("菏뇑뗓룕铗꧙꣛距菟菡諣ꫥ臧駩飫ꗭ闯诱鯳郵꯷駹鷻都䳿欁眃爅䔇䠉帋娍焏瀑砓猕䜗嬙ⴛⰝᘟᔡᜣ", a_), global::CommonResources.AcgResources.ID_SCANLISTMEMBER);
					this.scanLstScanListKeyofScanListMBRTable_A12673.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.scanLstScanListKeyofScanListMBRTable_A12673.DataTransferOrder = -1;
					num = (short)1199439882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6F:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1333854208;
					short num4 = num;
					num = (short)1767047169;
					if (num != 0)
					{
					}
					num = (short)19529728;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1FA:
				num = (short)507904012;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2CE:
				num = (short)595918850;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_380:
				num = (short)1588789251;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_44B:
				goto IL_380;
			}
			IL_37B:
			IL_450:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菏뇑뗓룕韙맛돝苟蟡難웥ꓧ菩鿫髭", a_);
			base.Id = 10133;
			base.UIName = global::CommonResources.AcgResources.ID_SCANMEMBERLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x0029157C File Offset: 0x0028F77C
		public override void PopulateReferences()
		{
			short num = (short)513293846;
			short num2 = num;
			num = (short)678510102;
			switch (num2 == num)
			{
			}
			num = (short)1933901824;
			short num3 = num;
			num = (short)376176641;
			if (num != 0)
			{
			}
			num = (short)551878656;
			if (num != 0)
			{
			}
			this.scanLstScanListZone_A9718.SetRecset(this.a(2051));
			this.scanLstScanListZone_A9718.AddSlaveField(this.scanLstScanListChannel_A7620, 10114);
		}

		// Token: 0x06002A19 RID: 10777 RVA: 0x00291650 File Offset: 0x0028F850
		public override void DropReferences()
		{
			short num = (short)496688216;
			short num2 = num;
			num = (short)1675811928;
			switch (num2 == num)
			{
			}
			num = (short)798687232;
			short num3 = num;
			num = (short)1473970177;
			if (num != 0)
			{
			}
			num = (short)232652800;
			if (num != 0)
			{
			}
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x002916F8 File Offset: 0x0028F8F8
		public override void SetConstraints()
		{
			short num = (short)492398560;
			short num2 = num;
			num = (short)1096640480;
			switch (num2 == num)
			{
			}
			num = (short)1127415808;
			short num3 = num;
			num = (short)1278148608;
			if (num != 0)
			{
			}
			num = (short)1990852609;
			if (num != 0)
			{
			}
			this.scanLstScanListZone_A9718.ValidateAcrossRecset = true;
			this.scanLstScanListZone_A9718.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConIsScanZoneMbrRecRefValid);
			this.scanLstScanListKeyofScanListMBRTable_A12673.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.scanLstScanListChannel_A7620.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConScanMrbZnIsNotUnassigned);
			this.scanLstScanListChannel_A7620.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.ConIsScanChanMbrRecRefValid);
			this.scanLstScanListLTEInterferingFreqPresent_A42196.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.SetLTEInterferenceFreqInUse);
			this.scanLstScanListLTEInterferingFreqPresent_A42196.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x00291834 File Offset: 0x0028FA34
		public override void SetupDependencies()
		{
			short num = (short)1491533824;
			short num2 = num;
			num = (short)1432823616;
			short num3 = num;
			num = (short)104671040;
			switch (num3 == num)
			{
			}
			num = (short)219807744;
			if (num != 0)
			{
			}
			num = (short)274661377;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList = base.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList;
			scanList.General.ScanLstGeneralScanType_A9058.AddDependentObject(this.scanLstScanListZone_A9718);
			this.scanLstScanListZone_A9718.AddDependentObject(this.scanLstScanListChannel_A7620);
			scanList.General.ScanLstGeneralScanType_A9058.AddDependentObject(this.scanLstScanListChannel_A7620);
			scanList.Advanced.ScanLstAdvancedTxSteering_A9572.AddDependentObject(this.scanLstScanListChannel_A7620);
			scanList.General.ScanLstGeneralRecord_A8921.AddDependentObject(this.scanLstScanListChannel_A7620);
			this.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.scanLstScanListChannel_A7620);
			this.scanLstScanListZone_A9718.AddDependentObject((base.ParentRecset.ParentSection.Parent[10131] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General).ScanLstGeneralDesignatedDataMember_A7829);
			this.scanLstScanListZone_A9718.AddDependentObject((base.ParentRecset.ParentSection.Parent[10131] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General).ScanLstGeneralDesignatedVoiceTxMember_A7830);
			this.scanLstScanListZone_A9718.AddDependentObject((base.ParentRecset.ParentSection.Parent[10131] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General).ScanLstGeneralPriorityMember1_A8747);
			this.scanLstScanListZone_A9718.AddDependentObject((base.ParentRecset.ParentSection.Parent[10131] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General).ScanLstGeneralPriorityMember2_A8749);
			this.scanLstScanListChannel_A7620.AddDependentObject((base.ParentRecset.ParentSection.Parent[10131] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General).ScanLstGeneralDesignatedDataMember_A7829);
			this.scanLstScanListChannel_A7620.AddDependentObject((base.ParentRecset.ParentSection.Parent[10131] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General).ScanLstGeneralDesignatedVoiceTxMember_A7830);
			this.scanLstScanListChannel_A7620.AddDependentObject((base.ParentRecset.ParentSection.Parent[10131] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General).ScanLstGeneralPriorityMember1_A8747);
			this.scanLstScanListChannel_A7620.AddDependentObject((base.ParentRecset.ParentSection.Parent[10131] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General).ScanLstGeneralPriorityMember2_A8749);
		}

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x06002A1C RID: 10780 RVA: 0x00291AFC File Offset: 0x0028FCFC
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment ZoneChannelAssignmentForScanLstScanListZone_A9718
		{
			get
			{
				short num = (short)678952960;
				short num2 = num;
				num = (short)2094229285;
				short num3 = num;
				num = (short)1064855333;
				switch (num3 == num)
				{
				}
				num = (short)1082130432;
				if (num != 0)
				{
				}
				num = (short)1069875201;
				if (num != 0)
				{
				}
				return this.scanLstScanListZone_A9718.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
			}
		}

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x06002A1D RID: 10781 RVA: 0x00291BB4 File Offset: 0x0028FDB4
		public global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner ChannelAssignmentListInnerSectionForScanLstScanListChannel_A7620
		{
			get
			{
				short num = (short)1438973952;
				short num2 = num;
				num = (short)1037314327;
				short num3 = num;
				num = (short)1242376471;
				switch (num3 == num)
				{
				}
				num = (short)1830289409;
				if (num != 0)
				{
				}
				num = (short)1431306240;
				if (num != 0)
				{
				}
				return this.scanLstScanListChannel_A7620.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
			}
		}

		// Token: 0x17001512 RID: 5394
		// (get) Token: 0x06002A1E RID: 10782 RVA: 0x00291C6C File Offset: 0x0028FE6C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1916862464;
				short num2 = num;
				num = (short)711959707;
				short num3 = num;
				num = (short)1309975707;
				switch (num3 == num)
				{
				}
				num = (short)370081793;
				if (num != 0)
				{
				}
				num = (short)1755774976;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17001513 RID: 5395
		// (get) Token: 0x06002A1F RID: 10783 RVA: 0x00291D18 File Offset: 0x0028FF18
		// (set) Token: 0x06002A20 RID: 10784 RVA: 0x00291DCC File Offset: 0x0028FFCC
		public int ScanLstScanListZone_A9718Value
		{
			get
			{
				short num = (short)1344733184;
				short num2 = num;
				num = (short)453897571;
				short num3 = num;
				num = (short)1193340259;
				switch (num3 == num)
				{
				}
				num = (short)1042350080;
				if (num != 0)
				{
				}
				num = (short)1715798017;
				if (num != 0)
				{
				}
				return this.scanLstScanListZone_A9718.Value;
			}
			set
			{
				short num = (short)1316749312;
				short num2 = num;
				num = (short)431653701;
				short num3 = num;
				num = (short)217940805;
				switch (num3 == num)
				{
				}
				num = (short)768475137;
				if (num != 0)
				{
				}
				num = (short)413138944;
				if (num != 0)
				{
				}
				this.scanLstScanListZone_A9718.Value = value;
			}
		}

		// Token: 0x17001514 RID: 5396
		// (get) Token: 0x06002A21 RID: 10785 RVA: 0x00291E84 File Offset: 0x00290084
		// (set) Token: 0x06002A22 RID: 10786 RVA: 0x00291F38 File Offset: 0x00290138
		public string ScanLstScanListZone_A9718_UIValue
		{
			get
			{
				short num = (short)1735917568;
				short num2 = num;
				num = (short)2012830904;
				short num3 = num;
				num = (short)1457806520;
				switch (num3 == num)
				{
				}
				num = (short)1753153537;
				if (num != 0)
				{
				}
				num = (short)2125922304;
				if (num != 0)
				{
				}
				return this.scanLstScanListZone_A9718.UIValue;
			}
			set
			{
				short num = (short)1760231424;
				short num2 = num;
				num = (short)1133397612;
				short num3 = num;
				num = (short)1459963500;
				switch (num3 == num)
				{
				}
				num = (short)1053818881;
				if (num != 0)
				{
				}
				num = (short)27787264;
				if (num != 0)
				{
				}
				this.scanLstScanListZone_A9718.UIValue = value;
			}
		}

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x06002A23 RID: 10787 RVA: 0x00291FEC File Offset: 0x002901EC
		public global::AcpBusinessLayer.AcpRecRefField ScanLstScanListZone_A9718
		{
			get
			{
				short num = (short)957808640;
				short num2 = num;
				num = (short)1016143745;
				short num3 = num;
				num = (short)38805377;
				switch (num3 == num)
				{
				}
				num = (short)1001717761;
				if (num != 0)
				{
				}
				num = (short)1592786944;
				if (num != 0)
				{
				}
				return this.scanLstScanListZone_A9718;
			}
		}

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x06002A24 RID: 10788 RVA: 0x00292098 File Offset: 0x00290298
		// (set) Token: 0x06002A25 RID: 10789 RVA: 0x0029214C File Offset: 0x0029034C
		public bool ScanLstScanListZone_A9718_Applicable
		{
			get
			{
				short num = (short)1925185536;
				short num2 = num;
				num = (short)538793305;
				short num3 = num;
				num = (short)1004033369;
				switch (num3 == num)
				{
				}
				num = (short)199753728;
				if (num != 0)
				{
				}
				num = (short)1671888897;
				if (num != 0)
				{
				}
				return this.scanLstScanListZone_A9718.Applicable;
			}
			set
			{
				short num = (short)446955520;
				short num2 = num;
				num = (short)577080137;
				short num3 = num;
				num = (short)29199177;
				switch (num3 == num)
				{
				}
				num = (short)1795883009;
				if (num != 0)
				{
				}
				num = (short)1562836992;
				if (num != 0)
				{
				}
				this.scanLstScanListZone_A9718.Applicable = value;
			}
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x06002A26 RID: 10790 RVA: 0x00292204 File Offset: 0x00290404
		// (set) Token: 0x06002A27 RID: 10791 RVA: 0x002922B8 File Offset: 0x002904B8
		public bool ScanLstScanListZone_A9718_Valid
		{
			get
			{
				short num = (short)1399390208;
				short num2 = num;
				num = (short)716199656;
				short num3 = num;
				num = (short)1971017448;
				switch (num3 == num)
				{
				}
				num = (short)1143668736;
				if (num != 0)
				{
				}
				num = (short)1753481217;
				if (num != 0)
				{
				}
				return this.scanLstScanListZone_A9718.Valid;
			}
			set
			{
				short num = (short)1531576320;
				short num2 = num;
				num = (short)1190042905;
				short num3 = num;
				num = (short)753966361;
				switch (num3 == num)
				{
				}
				num = (short)1648295937;
				if (num != 0)
				{
				}
				num = (short)819855360;
				if (num != 0)
				{
				}
				this.scanLstScanListZone_A9718.Valid = value;
			}
		}

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x06002A28 RID: 10792 RVA: 0x00292370 File Offset: 0x00290570
		// (set) Token: 0x06002A29 RID: 10793 RVA: 0x00292424 File Offset: 0x00290624
		public bool ScanLstScanListZone_A9718_Visible
		{
			get
			{
				short num = (short)1375272960;
				short num2 = num;
				num = (short)1224698695;
				short num3 = num;
				num = (short)1672375111;
				switch (num3 == num)
				{
				}
				num = (short)505348096;
				if (num != 0)
				{
				}
				num = (short)279117825;
				if (num != 0)
				{
				}
				return this.scanLstScanListZone_A9718.Visible;
			}
			set
			{
				short num = (short)1748762624;
				short num2 = num;
				num = (short)959226823;
				short num3 = num;
				num = (short)1950786503;
				switch (num3 == num)
				{
				}
				num = (short)474677249;
				if (num != 0)
				{
				}
				num = (short)1011417088;
				if (num != 0)
				{
				}
				this.scanLstScanListZone_A9718.Visible = value;
			}
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x06002A2A RID: 10794 RVA: 0x002924DC File Offset: 0x002906DC
		// (set) Token: 0x06002A2B RID: 10795 RVA: 0x0029258C File Offset: 0x0029078C
		public bool ScanLstScanListZone_A9718_Editable
		{
			get
			{
				short num = (short)2056519680;
				short num2 = num;
				num = (short)1178008921;
				short num3 = num;
				num = (short)1176567129;
				switch (num3 == num)
				{
				}
				num = (short)2136408065;
				if (num != 0)
				{
				}
				num = (short)56492032;
				if (num != 0)
				{
				}
				return this.scanLstScanListZone_A9718.Editable;
			}
			set
			{
				short num = (short)233373696;
				short num2 = num;
				num = (short)916972228;
				short num3 = num;
				num = (short)1973740228;
				switch (num3 == num)
				{
				}
				num = (short)557056000;
				if (num != 0)
				{
				}
				num = (short)1462042625;
				if (num != 0)
				{
				}
				this.scanLstScanListZone_A9718.Editable = value;
			}
		}

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x06002A2C RID: 10796 RVA: 0x00292640 File Offset: 0x00290840
		internal string ScanLstScanListZone_A9718_UILabel
		{
			get
			{
				short num = (short)27328512;
				short num2 = num;
				num = (short)2126241226;
				short num3 = num;
				num = (short)424795594;
				switch (num3 == num)
				{
				}
				num = (short)626262017;
				if (num != 0)
				{
				}
				num = (short)505020416;
				if (num != 0)
				{
				}
				return this.scanLstScanListZone_A9718.UIName;
			}
		}

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x06002A2D RID: 10797 RVA: 0x002926F4 File Offset: 0x002908F4
		// (set) Token: 0x06002A2E RID: 10798 RVA: 0x002927A8 File Offset: 0x002909A8
		internal bool ScanLstScanListZone_A9718_HiddenStatic
		{
			get
			{
				short num = (short)344195072;
				short num2 = num;
				num = (short)1537146881;
				if (num != 0)
				{
				}
				num = (short)1995304952;
				short num3 = num;
				num = (short)671739896;
				switch (num3 == num)
				{
				}
				num = (short)1087832064;
				if (num != 0)
				{
				}
				return this.scanLstScanListZone_A9718.HiddenStatic;
			}
			set
			{
				short num = (short)390922240;
				short num2 = num;
				num = (short)802157767;
				short num3 = num;
				num = (short)1436808391;
				switch (num3 == num)
				{
				}
				num = (short)785514497;
				if (num != 0)
				{
				}
				num = (short)384499712;
				if (num != 0)
				{
				}
				this.scanLstScanListZone_A9718.HiddenStatic = value;
			}
		}

		// Token: 0x1700151C RID: 5404
		// (get) Token: 0x06002A2F RID: 10799 RVA: 0x00292860 File Offset: 0x00290A60
		// (set) Token: 0x06002A30 RID: 10800 RVA: 0x00292918 File Offset: 0x00290B18
		internal bool ScanLstScanListZone_A9718_HiddenDynamic
		{
			get
			{
				short num = (short)798031872;
				short num2 = num;
				num = (short)534430797;
				short num3 = num;
				num = (short)1630061645;
				switch (num3 == num)
				{
				}
				num = (short)1532690433;
				if (num != 0)
				{
				}
				num = (short)1302331392;
				if (num != 0)
				{
				}
				return this.scanLstScanListZone_A9718.HiddenDynamic;
			}
			set
			{
				short num = (short)857800704;
				short num2 = num;
				num = (short)1808905387;
				short num3 = num;
				num = (short)1725150379;
				switch (num3 == num)
				{
				}
				num = (short)700448769;
				if (num != 0)
				{
				}
				num = (short)199950336;
				if (num != 0)
				{
				}
				this.scanLstScanListZone_A9718.HiddenDynamic = value;
			}
		}

		// Token: 0x1700151D RID: 5405
		// (get) Token: 0x06002A31 RID: 10801 RVA: 0x002929D0 File Offset: 0x00290BD0
		public bool ScanLstScanListZone_A9718_HasDiffs
		{
			get
			{
				short num = (short)1827405824;
				short num2 = num;
				num = (short)1310803900;
				short num3 = num;
				num = (short)2079934396;
				switch (num3 == num)
				{
				}
				num = (short)957022209;
				if (num != 0)
				{
				}
				num = (short)1078394880;
				if (num != 0)
				{
				}
				return this.scanLstScanListZone_A9718._HasDiffs;
			}
		}

		// Token: 0x1700151E RID: 5406
		// (get) Token: 0x06002A32 RID: 10802 RVA: 0x00292A88 File Offset: 0x00290C88
		// (set) Token: 0x06002A33 RID: 10803 RVA: 0x00292B40 File Offset: 0x00290D40
		public string ScanLstScanListKeyofScanListMBRTable_A12673Value
		{
			get
			{
				short num = (short)1362952192;
				short num2 = num;
				num = (short)1529679272;
				short num3 = num;
				num = (short)325586344;
				switch (num3 == num)
				{
				}
				num = (short)1655635968;
				if (num != 0)
				{
				}
				num = (short)54132737;
				if (num != 0)
				{
				}
				return this.scanLstScanListKeyofScanListMBRTable_A12673.Value;
			}
			set
			{
				short num = (short)939655170;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)522846208;
						short num3 = num;
						num = (short)644791290;
						short num4 = num;
						num = (short)1770306554;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_D7;
						}
						break;
					}
					case 1:
						this.scanLstScanListKeyofScanListMBRTable_A12673.Value = value;
						num = (short)1048510464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						return;
					}
					num = (short)1422131201;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D7:
				num = (short)527958017;
				if (num != 0)
				{
				}
				num = (short)562495488;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x06002A34 RID: 10804 RVA: 0x00292C64 File Offset: 0x00290E64
		// (set) Token: 0x06002A35 RID: 10805 RVA: 0x00292D18 File Offset: 0x00290F18
		public string ScanLstScanListKeyofScanListMBRTable_A12673_UIValue
		{
			get
			{
				short num = (short)956694528;
				short num2 = num;
				num = (short)1258926025;
				short num3 = num;
				num = (short)156610505;
				switch (num3 == num)
				{
				}
				num = (short)944832513;
				if (num != 0)
				{
				}
				num = (short)271908864;
				if (num != 0)
				{
				}
				return this.scanLstScanListKeyofScanListMBRTable_A12673.Value;
			}
			set
			{
				short num = (short)1154154496;
				short num2 = num;
				num = (short)152721267;
				short num3 = num;
				num = (short)1609455475;
				switch (num3 == num)
				{
				}
				num = (short)453967873;
				if (num != 0)
				{
				}
				num = (short)1883832320;
				if (num != 0)
				{
				}
				this.scanLstScanListKeyofScanListMBRTable_A12673.Value = value;
			}
		}

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x06002A36 RID: 10806 RVA: 0x00292DD0 File Offset: 0x00290FD0
		public global::AcpBusinessLayer.AcpKeyField ScanLstScanListKeyofScanListMBRTable_A12673
		{
			get
			{
				short num = (short)2065891328;
				short num2 = num;
				num = (short)628109980;
				short num3 = num;
				num = (short)1405760156;
				switch (num3 == num)
				{
				}
				num = (short)430833664;
				if (num != 0)
				{
				}
				num = (short)593690625;
				if (num != 0)
				{
				}
				return this.scanLstScanListKeyofScanListMBRTable_A12673;
			}
		}

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x06002A37 RID: 10807 RVA: 0x00292E80 File Offset: 0x00291080
		// (set) Token: 0x06002A38 RID: 10808 RVA: 0x00292F34 File Offset: 0x00291134
		public bool ScanLstScanListKeyofScanListMBRTable_A12673_Applicable
		{
			get
			{
				short num = (short)1717239808;
				short num2 = num;
				num = (short)150077441;
				if (num != 0)
				{
				}
				num = (short)655546433;
				short num3 = num;
				num = (short)1570166849;
				switch (num3 == num)
				{
				}
				num = (short)1120862208;
				if (num != 0)
				{
				}
				return this.scanLstScanListKeyofScanListMBRTable_A12673.Applicable;
			}
			set
			{
				short num = (short)31522816;
				short num2 = num;
				num = (short)1349386241;
				if (num != 0)
				{
				}
				num = (short)789777651;
				short num3 = num;
				num = (short)200150259;
				switch (num3 == num)
				{
				}
				num = (short)1999175680;
				if (num != 0)
				{
				}
				this.scanLstScanListKeyofScanListMBRTable_A12673.Applicable = value;
			}
		}

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x06002A39 RID: 10809 RVA: 0x00292FE8 File Offset: 0x002911E8
		// (set) Token: 0x06002A3A RID: 10810 RVA: 0x0029309C File Offset: 0x0029129C
		public bool ScanLstScanListKeyofScanListMBRTable_A12673_Valid
		{
			get
			{
				short num = (short)139984896;
				short num2 = num;
				num = (short)1194534538;
				short num3 = num;
				num = (short)1321019018;
				switch (num3 == num)
				{
				}
				num = (short)1590165505;
				if (num != 0)
				{
				}
				num = (short)92733440;
				if (num != 0)
				{
				}
				return this.scanLstScanListKeyofScanListMBRTable_A12673.Valid;
			}
			set
			{
				short num = (short)489881600;
				short num2 = num;
				num = (short)423748403;
				short num3 = num;
				num = (short)233890611;
				switch (num3 == num)
				{
				}
				num = (short)2068643841;
				if (num != 0)
				{
				}
				num = (short)53018624;
				if (num != 0)
				{
				}
				this.scanLstScanListKeyofScanListMBRTable_A12673.Valid = value;
			}
		}

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x06002A3B RID: 10811 RVA: 0x00293150 File Offset: 0x00291350
		// (set) Token: 0x06002A3C RID: 10812 RVA: 0x00293204 File Offset: 0x00291404
		public bool ScanLstScanListKeyofScanListMBRTable_A12673_Visible
		{
			get
			{
				short num = (short)1727528960;
				short num2 = num;
				num = (short)1953682765;
				short num3 = num;
				num = (short)123852109;
				switch (num3 == num)
				{
				}
				num = (short)1030291457;
				if (num != 0)
				{
				}
				num = (short)816513024;
				if (num != 0)
				{
				}
				return this.scanLstScanListKeyofScanListMBRTable_A12673.Visible;
			}
			set
			{
				short num = (short)1721827328;
				short num2 = num;
				num = (short)1475895903;
				short num3 = num;
				num = (short)1106535007;
				switch (num3 == num)
				{
				}
				num = (short)1236271104;
				if (num != 0)
				{
				}
				num = (short)604438529;
				if (num != 0)
				{
				}
				this.scanLstScanListKeyofScanListMBRTable_A12673.Visible = value;
			}
		}

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x06002A3D RID: 10813 RVA: 0x002932BC File Offset: 0x002914BC
		// (set) Token: 0x06002A3E RID: 10814 RVA: 0x00293370 File Offset: 0x00291570
		public bool ScanLstScanListKeyofScanListMBRTable_A12673_Editable
		{
			get
			{
				short num = (short)779616256;
				short num2 = num;
				num = (short)2030099109;
				short num3 = num;
				num = (short)2120932005;
				switch (num3 == num)
				{
				}
				num = (short)863633409;
				if (num != 0)
				{
				}
				num = (short)1430978560;
				if (num != 0)
				{
				}
				return this.scanLstScanListKeyofScanListMBRTable_A12673.Editable;
			}
			set
			{
				short num = (short)874512384;
				short num2 = num;
				num = (short)965624383;
				short num3 = num;
				num = (short)1873756735;
				switch (num3 == num)
				{
				}
				num = (short)975765505;
				if (num != 0)
				{
				}
				num = (short)1469382656;
				if (num != 0)
				{
				}
				this.scanLstScanListKeyofScanListMBRTable_A12673.Editable = value;
			}
		}

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x06002A3F RID: 10815 RVA: 0x00293424 File Offset: 0x00291624
		internal string ScanLstScanListKeyofScanListMBRTable_A12673_UILabel
		{
			get
			{
				short num = (short)509280256;
				short num2 = num;
				num = (short)1799769960;
				short num3 = num;
				num = (short)619859816;
				switch (num3 == num)
				{
				}
				num = (short)1394147329;
				if (num != 0)
				{
				}
				num = (short)589561856;
				if (num != 0)
				{
				}
				return this.scanLstScanListKeyofScanListMBRTable_A12673.UIName;
			}
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x06002A40 RID: 10816 RVA: 0x002934D8 File Offset: 0x002916D8
		// (set) Token: 0x06002A41 RID: 10817 RVA: 0x0029358C File Offset: 0x0029178C
		internal bool ScanLstScanListKeyofScanListMBRTable_A12673_HiddenStatic
		{
			get
			{
				short num = (short)1926955008;
				short num2 = num;
				num = (short)190775297;
				if (num != 0)
				{
				}
				num = (short)1456963331;
				short num3 = num;
				num = (short)1971748611;
				switch (num3 == num)
				{
				}
				num = (short)1382809600;
				if (num != 0)
				{
				}
				return this.scanLstScanListKeyofScanListMBRTable_A12673.HiddenStatic;
			}
			set
			{
				short num = (short)835059712;
				short num2 = num;
				num = (short)785933896;
				short num3 = num;
				num = (short)85943880;
				switch (num3 == num)
				{
				}
				num = (short)497811457;
				if (num != 0)
				{
				}
				num = (short)455999488;
				if (num != 0)
				{
				}
				this.scanLstScanListKeyofScanListMBRTable_A12673.HiddenStatic = value;
			}
		}

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x06002A42 RID: 10818 RVA: 0x00293640 File Offset: 0x00291840
		// (set) Token: 0x06002A43 RID: 10819 RVA: 0x002936F4 File Offset: 0x002918F4
		internal bool ScanLstScanListKeyofScanListMBRTable_A12673_HiddenDynamic
		{
			get
			{
				short num = (short)1340997632;
				short num2 = num;
				num = (short)1201622443;
				short num3 = num;
				num = (short)931745195;
				switch (num3 == num)
				{
				}
				num = (short)181862400;
				if (num != 0)
				{
				}
				num = (short)338362369;
				if (num != 0)
				{
				}
				return this.scanLstScanListKeyofScanListMBRTable_A12673.HiddenDynamic;
			}
			set
			{
				short num = (short)1437270016;
				short num2 = num;
				num = (short)1311848114;
				short num3 = num;
				num = (short)384251570;
				switch (num3 == num)
				{
				}
				num = (short)1046609921;
				if (num != 0)
				{
				}
				num = (short)708247552;
				if (num != 0)
				{
				}
				this.scanLstScanListKeyofScanListMBRTable_A12673.HiddenDynamic = value;
			}
		}

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x06002A44 RID: 10820 RVA: 0x002937AC File Offset: 0x002919AC
		public bool ScanLstScanListKeyofScanListMBRTable_A12673_HasDiffs
		{
			get
			{
				short num = (short)1863385088;
				short num2 = num;
				num = (short)937164801;
				if (num != 0)
				{
				}
				num = (short)110551488;
				short num3 = num;
				num = (short)1432019392;
				switch (num3 == num)
				{
				}
				num = (short)548339712;
				if (num != 0)
				{
				}
				return this.scanLstScanListKeyofScanListMBRTable_A12673._HasDiffs;
			}
		}

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x06002A45 RID: 10821 RVA: 0x00293860 File Offset: 0x00291A60
		// (set) Token: 0x06002A46 RID: 10822 RVA: 0x00293910 File Offset: 0x00291B10
		public int ScanLstScanListChannel_A7620Value
		{
			get
			{
				short num = (short)1063256064;
				short num2 = num;
				num = (short)175899311;
				short num3 = num;
				num = (short)842662575;
				switch (num3 == num)
				{
				}
				num = (short)1910112256;
				if (num != 0)
				{
				}
				num = (short)2114453505;
				if (num != 0)
				{
				}
				return this.scanLstScanListChannel_A7620.Value;
			}
			set
			{
				short num = (short)1535508480;
				short num2 = num;
				num = (short)829901138;
				short num3 = num;
				num = (short)1536575826;
				switch (num3 == num)
				{
				}
				num = (short)576847873;
				if (num != 0)
				{
				}
				num = (short)861274112;
				if (num != 0)
				{
				}
				this.scanLstScanListChannel_A7620.Value = value;
			}
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x06002A47 RID: 10823 RVA: 0x002939C8 File Offset: 0x00291BC8
		// (set) Token: 0x06002A48 RID: 10824 RVA: 0x00293A80 File Offset: 0x00291C80
		public string ScanLstScanListChannel_A7620_UIValue
		{
			get
			{
				short num = (short)1866137600;
				short num2 = num;
				num = (short)359137281;
				if (num != 0)
				{
				}
				num = (short)1212424691;
				short num3 = num;
				num = (short)1797333491;
				switch (num3 == num)
				{
				}
				num = (short)1055588352;
				if (num != 0)
				{
				}
				return this.scanLstScanListChannel_A7620.UIValue;
			}
			set
			{
				short num = (short)937426944;
				short num2 = num;
				num = (short)2085632521;
				short num3 = num;
				num = (short)1308047881;
				switch (num3 == num)
				{
				}
				num = (short)1881014272;
				if (num != 0)
				{
				}
				num = (short)689176577;
				if (num != 0)
				{
				}
				this.scanLstScanListChannel_A7620.UIValue = value;
			}
		}

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x06002A49 RID: 10825 RVA: 0x00293B34 File Offset: 0x00291D34
		public global::AcpBusinessLayer.AcpRecRefField ScanLstScanListChannel_A7620
		{
			get
			{
				short num = (short)88604672;
				short num2 = num;
				num = (short)241005464;
				short num3 = num;
				num = (short)2133488536;
				switch (num3 == num)
				{
				}
				num = (short)1198325760;
				if (num != 0)
				{
				}
				num = (short)1507590145;
				if (num != 0)
				{
				}
				return this.scanLstScanListChannel_A7620;
			}
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x06002A4A RID: 10826 RVA: 0x00293BE0 File Offset: 0x00291DE0
		// (set) Token: 0x06002A4B RID: 10827 RVA: 0x00293C94 File Offset: 0x00291E94
		public bool ScanLstScanListChannel_A7620_Applicable
		{
			get
			{
				short num = (short)835584000;
				short num2 = num;
				num = (short)1401740823;
				short num3 = num;
				num = (short)1731452439;
				switch (num3 == num)
				{
				}
				num = (short)131073;
				if (num != 0)
				{
				}
				num = (short)732692480;
				if (num != 0)
				{
				}
				return this.scanLstScanListChannel_A7620.Applicable;
			}
			set
			{
				short num = (short)871956480;
				short num2 = num;
				num = (short)43061599;
				short num3 = num;
				num = (short)1868435807;
				switch (num3 == num)
				{
				}
				num = (short)2111897601;
				if (num != 0)
				{
				}
				num = (short)492961792;
				if (num != 0)
				{
				}
				this.scanLstScanListChannel_A7620.Applicable = value;
			}
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x06002A4C RID: 10828 RVA: 0x00293D4C File Offset: 0x00291F4C
		// (set) Token: 0x06002A4D RID: 10829 RVA: 0x00293E00 File Offset: 0x00292000
		public bool ScanLstScanListChannel_A7620_Valid
		{
			get
			{
				short num = (short)500760576;
				short num2 = num;
				num = (short)1414840257;
				short num3 = num;
				num = (short)971489217;
				switch (num3 == num)
				{
				}
				num = (short)8126464;
				if (num != 0)
				{
				}
				num = (short)1998848001;
				if (num != 0)
				{
				}
				return this.scanLstScanListChannel_A7620.Valid;
			}
			set
			{
				short num = (short)572850176;
				short num2 = num;
				num = (short)454825053;
				short num3 = num;
				num = (short)2085819485;
				switch (num3 == num)
				{
				}
				num = (short)11468800;
				if (num != 0)
				{
				}
				num = (short)284819457;
				if (num != 0)
				{
				}
				this.scanLstScanListChannel_A7620.Valid = value;
			}
		}

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x06002A4E RID: 10830 RVA: 0x00293EB8 File Offset: 0x002920B8
		// (set) Token: 0x06002A4F RID: 10831 RVA: 0x00293F6C File Offset: 0x0029216C
		public bool ScanLstScanListChannel_A7620_Visible
		{
			get
			{
				short num = (short)1888288768;
				short num2 = num;
				num = (short)570999106;
				short num3 = num;
				num = (short)1866907970;
				switch (num3 == num)
				{
				}
				num = (short)869007360;
				if (num != 0)
				{
				}
				num = (short)2038235137;
				if (num != 0)
				{
				}
				return this.scanLstScanListChannel_A7620.Visible;
			}
			set
			{
				short num = (short)1140129792;
				short num2 = num;
				num = (short)1501777438;
				short num3 = num;
				num = (short)1228754462;
				switch (num3 == num)
				{
				}
				num = (short)317063169;
				if (num != 0)
				{
				}
				num = (short)876740608;
				if (num != 0)
				{
				}
				this.scanLstScanListChannel_A7620.Visible = value;
			}
		}

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x06002A50 RID: 10832 RVA: 0x00294024 File Offset: 0x00292224
		// (set) Token: 0x06002A51 RID: 10833 RVA: 0x002940DC File Offset: 0x002922DC
		public bool ScanLstScanListChannel_A7620_Editable
		{
			get
			{
				short num = (short)861667328;
				short num2 = num;
				num = (short)744351633;
				short num3 = num;
				num = (short)971958161;
				switch (num3 == num)
				{
				}
				num = (short)1583022081;
				if (num != 0)
				{
				}
				num = (short)838991872;
				if (num != 0)
				{
				}
				return this.scanLstScanListChannel_A7620.Editable;
			}
			set
			{
				short num = (short)1439498240;
				short num2 = num;
				num = (short)870622099;
				short num3 = num;
				num = (short)1126146963;
				switch (num3 == num)
				{
				}
				num = (short)1742012417;
				if (num != 0)
				{
				}
				num = (short)1546584064;
				if (num != 0)
				{
				}
				this.scanLstScanListChannel_A7620.Editable = value;
			}
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x06002A52 RID: 10834 RVA: 0x00294190 File Offset: 0x00292390
		internal string ScanLstScanListChannel_A7620_UILabel
		{
			get
			{
				short num = (short)978190336;
				short num2 = num;
				num = (short)1895854740;
				short num3 = num;
				num = (short)1828352660;
				switch (num3 == num)
				{
				}
				num = (short)94371840;
				if (num != 0)
				{
				}
				num = (short)1164050433;
				if (num != 0)
				{
				}
				return this.scanLstScanListChannel_A7620.UIName;
			}
		}

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x06002A53 RID: 10835 RVA: 0x00294244 File Offset: 0x00292444
		// (set) Token: 0x06002A54 RID: 10836 RVA: 0x002942F8 File Offset: 0x002924F8
		internal bool ScanLstScanListChannel_A7620_HiddenStatic
		{
			get
			{
				short num = (short)1192238953;
				short num2 = num;
				num = (short)602939241;
				switch (num2 == num)
				{
				default:
				{
					num = (short)795410432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1273036801;
				if (num != 0)
				{
				}
				num = (short)771620864;
				if (num != 0)
				{
				}
				return this.scanLstScanListChannel_A7620.HiddenStatic;
			}
			set
			{
				short num = (short)255859566;
				short num2 = num;
				num = (short)1529355118;
				switch (num2 == num)
				{
				default:
				{
					num = (short)480313344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)126746625;
				if (num != 0)
				{
				}
				num = (short)1793196032;
				if (num != 0)
				{
				}
				this.scanLstScanListChannel_A7620.HiddenStatic = value;
			}
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x06002A55 RID: 10837 RVA: 0x002943AC File Offset: 0x002925AC
		// (set) Token: 0x06002A56 RID: 10838 RVA: 0x00294460 File Offset: 0x00292660
		internal bool ScanLstScanListChannel_A7620_HiddenDynamic
		{
			get
			{
				short num = (short)215738529;
				short num2 = num;
				num = (short)814475425;
				switch (num2 == num)
				{
				default:
				{
					num = (short)14876672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)684523521;
				if (num != 0)
				{
				}
				num = (short)1065091072;
				if (num != 0)
				{
				}
				return this.scanLstScanListChannel_A7620.HiddenDynamic;
			}
			set
			{
				short num = (short)243875226;
				short num2 = num;
				num = (short)91110810;
				switch (num2 == num)
				{
				default:
				{
					num = (short)228392960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)479985665;
				if (num != 0)
				{
				}
				num = (short)1677131776;
				if (num != 0)
				{
				}
				this.scanLstScanListChannel_A7620.HiddenDynamic = value;
			}
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x06002A57 RID: 10839 RVA: 0x00294514 File Offset: 0x00292714
		public bool ScanLstScanListChannel_A7620_HasDiffs
		{
			get
			{
				short num = (short)1422983169;
				if (num != 0)
				{
				}
				num = (short)271777792;
				short num2 = num;
				num = (short)2005609426;
				short num3 = num;
				num = (short)1053567954;
				switch (num3 == num)
				{
				}
				num = (short)1389821952;
				if (num != 0)
				{
				}
				return this.scanLstScanListChannel_A7620._HasDiffs;
			}
		}

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x06002A58 RID: 10840 RVA: 0x002945C8 File Offset: 0x002927C8
		// (set) Token: 0x06002A59 RID: 10841 RVA: 0x0029467C File Offset: 0x0029287C
		public bool ScanLstScanListLTEInterferingFreqPresent_A42196Value
		{
			get
			{
				short num = (short)2023631387;
				short num2 = num;
				num = (short)1057303067;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1661468672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1962016769;
				if (num != 0)
				{
				}
				num = (short)75169792;
				if (num != 0)
				{
				}
				return this.scanLstScanListLTEInterferingFreqPresent_A42196.Value;
			}
			set
			{
				short num = (short)818834986;
				short num2 = num;
				num = (short)303459882;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1701445632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)984743937;
				if (num != 0)
				{
				}
				num = (short)249233408;
				if (num != 0)
				{
				}
				this.scanLstScanListLTEInterferingFreqPresent_A42196.Value = value;
			}
		}

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x06002A5A RID: 10842 RVA: 0x00294734 File Offset: 0x00292934
		public global::AcpBusinessLayer.AcpField<bool> ScanLstScanListLTEInterferingFreqPresent_A42196
		{
			get
			{
				short num = (short)2081886862;
				short num2 = num;
				num = (short)985338510;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1944256512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)981663745;
				if (num != 0)
				{
				}
				num = (short)2059862016;
				if (num != 0)
				{
				}
				return this.scanLstScanListLTEInterferingFreqPresent_A42196;
			}
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x06002A5B RID: 10843 RVA: 0x002947E4 File Offset: 0x002929E4
		// (set) Token: 0x06002A5C RID: 10844 RVA: 0x00294898 File Offset: 0x00292A98
		public bool ScanLstScanListLTEInterferingFreqPresent_A42196_UIValue
		{
			get
			{
				short num = (short)380776142;
				short num2 = num;
				num = (short)1749429966;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1367408640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)644415489;
				if (num != 0)
				{
				}
				num = (short)1604190208;
				if (num != 0)
				{
				}
				return this.scanLstScanListLTEInterferingFreqPresent_A42196.Value;
			}
			set
			{
				short num = (short)1291452417;
				if (num != 0)
				{
				}
				num = (short)959447040;
				short num2 = num;
				num = (short)1165469718;
				short num3 = num;
				num = (short)763996182;
				switch (num3 == num)
				{
				}
				num = (short)39845888;
				if (num != 0)
				{
				}
				this.scanLstScanListLTEInterferingFreqPresent_A42196.Value = value;
			}
		}

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x06002A5D RID: 10845 RVA: 0x0029494C File Offset: 0x00292B4C
		// (set) Token: 0x06002A5E RID: 10846 RVA: 0x00294A00 File Offset: 0x00292C00
		public bool ScanLstScanListLTEInterferingFreqPresent_A42196_Applicable
		{
			get
			{
				short num = (short)578191771;
				short num2 = num;
				num = (short)769491355;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2042757120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)58982401;
				if (num != 0)
				{
				}
				num = (short)529268736;
				if (num != 0)
				{
				}
				return this.scanLstScanListLTEInterferingFreqPresent_A42196.Applicable;
			}
			set
			{
				short num = (short)1782594234;
				short num2 = num;
				num = (short)1995389626;
				switch (num2 == num)
				{
				default:
				{
					num = (short)772341760;
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
				num = (short)1016332288;
				if (num != 0)
				{
				}
				this.scanLstScanListLTEInterferingFreqPresent_A42196.Applicable = value;
			}
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x06002A5F RID: 10847 RVA: 0x00294AB4 File Offset: 0x00292CB4
		// (set) Token: 0x06002A60 RID: 10848 RVA: 0x00294B68 File Offset: 0x00292D68
		public bool ScanLstScanListLTEInterferingFreqPresent_A42196_Valid
		{
			get
			{
				short num = (short)1592103074;
				short num2 = num;
				num = (short)585797794;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1044316160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)973406209;
				if (num != 0)
				{
				}
				num = (short)566165504;
				if (num != 0)
				{
				}
				return this.scanLstScanListLTEInterferingFreqPresent_A42196.Valid;
			}
			set
			{
				short num = (short)2139906439;
				short num2 = num;
				num = (short)357196167;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1730740224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1381761025;
				if (num != 0)
				{
				}
				num = (short)552730624;
				if (num != 0)
				{
				}
				this.scanLstScanListLTEInterferingFreqPresent_A42196.Valid = value;
			}
		}

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x06002A61 RID: 10849 RVA: 0x00294C20 File Offset: 0x00292E20
		// (set) Token: 0x06002A62 RID: 10850 RVA: 0x00294CD4 File Offset: 0x00292ED4
		public bool ScanLstScanListLTEInterferingFreqPresent_A42196_Visible
		{
			get
			{
				short num = (short)1764535793;
				short num2 = num;
				num = (short)1378987505;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1462435840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1808859137;
				if (num != 0)
				{
				}
				num = (short)329318400;
				if (num != 0)
				{
				}
				return this.scanLstScanListLTEInterferingFreqPresent_A42196.Visible;
			}
			set
			{
				short num = (short)1579508672;
				short num2 = num;
				num = (short)1093755840;
				switch (num2 == num)
				{
				default:
				{
					num = (short)985202688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2080636928;
				if (num != 0)
				{
				}
				num = (short)1033371649;
				if (num != 0)
				{
				}
				this.scanLstScanListLTEInterferingFreqPresent_A42196.Visible = value;
			}
		}

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x06002A63 RID: 10851 RVA: 0x00294D88 File Offset: 0x00292F88
		// (set) Token: 0x06002A64 RID: 10852 RVA: 0x00294E38 File Offset: 0x00293038
		public bool ScanLstScanListLTEInterferingFreqPresent_A42196_Editable
		{
			get
			{
				short num = (short)638613377;
				short num2 = num;
				num = (short)52983681;
				switch (num2 == num)
				{
				default:
				{
					num = (short)117178368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1010630657;
				if (num != 0)
				{
				}
				num = (short)1979842560;
				if (num != 0)
				{
				}
				return this.scanLstScanListLTEInterferingFreqPresent_A42196.Editable;
			}
			set
			{
				short num = (short)1384775681;
				if (num != 0)
				{
				}
				num = (short)1047527424;
				short num2 = num;
				num = (short)783917644;
				short num3 = num;
				num = (short)40215116;
				switch (num3 == num)
				{
				}
				num = (short)899612672;
				if (num != 0)
				{
				}
				this.scanLstScanListLTEInterferingFreqPresent_A42196.Editable = value;
			}
		}

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x06002A65 RID: 10853 RVA: 0x00294EF0 File Offset: 0x002930F0
		internal string ScanLstScanListLTEInterferingFreqPresent_A42196_UILabel
		{
			get
			{
				short num = (short)1656405524;
				short num2 = num;
				num = (short)384482836;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1732706304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1990328321;
				if (num != 0)
				{
				}
				num = (short)1366163456;
				if (num != 0)
				{
				}
				return this.scanLstScanListLTEInterferingFreqPresent_A42196.UIName;
			}
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x06002A66 RID: 10854 RVA: 0x00294FA8 File Offset: 0x002931A8
		// (set) Token: 0x06002A67 RID: 10855 RVA: 0x00295060 File Offset: 0x00293260
		internal bool ScanLstScanListLTEInterferingFreqPresent_A42196_HiddenStatic
		{
			get
			{
				short num = (short)1176567809;
				if (num != 0)
				{
				}
				num = (short)1796341760;
				short num2 = num;
				num = (short)1115939468;
				short num3 = num;
				num = (short)1862460044;
				switch (num3 == num)
				{
				}
				num = (short)2085683200;
				if (num != 0)
				{
				}
				return this.scanLstScanListLTEInterferingFreqPresent_A42196.HiddenStatic;
			}
			set
			{
				short num = (short)84587003;
				short num2 = num;
				num = (short)988066299;
				switch (num2 == num)
				{
				default:
				{
					num = (short)431095808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)248643585;
				if (num != 0)
				{
				}
				num = (short)1954938880;
				if (num != 0)
				{
				}
				this.scanLstScanListLTEInterferingFreqPresent_A42196.HiddenStatic = value;
			}
		}

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x06002A68 RID: 10856 RVA: 0x00295114 File Offset: 0x00293314
		// (set) Token: 0x06002A69 RID: 10857 RVA: 0x002951C4 File Offset: 0x002933C4
		internal bool ScanLstScanListLTEInterferingFreqPresent_A42196_HiddenDynamic
		{
			get
			{
				short num = (short)1661730410;
				short num2 = num;
				num = (short)550305386;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1897725952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1571094529;
				if (num != 0)
				{
				}
				num = (short)1477181440;
				if (num != 0)
				{
				}
				return this.scanLstScanListLTEInterferingFreqPresent_A42196.HiddenDynamic;
			}
			set
			{
				short num = (short)488172469;
				short num2 = num;
				num = (short)910027701;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2105671680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1708457984;
				if (num != 0)
				{
				}
				num = (short)1639383041;
				if (num != 0)
				{
				}
				this.scanLstScanListLTEInterferingFreqPresent_A42196.HiddenDynamic = value;
			}
		}

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x06002A6A RID: 10858 RVA: 0x0029527C File Offset: 0x0029347C
		public bool ScanLstScanListLTEInterferingFreqPresent_A42196_HasDiffs
		{
			get
			{
				short num = (short)2024833520;
				short num2 = num;
				num = (short)1606779376;
				switch (num2 == num)
				{
				default:
				{
					num = (short)43319296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)514654208;
				if (num != 0)
				{
				}
				num = (short)1141440513;
				if (num != 0)
				{
				}
				return this.scanLstScanListLTEInterferingFreqPresent_A42196._HasDiffs;
			}
		}

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x06002A6B RID: 10859 RVA: 0x00295330 File Offset: 0x00293530
		public global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide RefDVRSWide
		{
			get
			{
				short num = (short)1870543920;
				short num2 = num;
				num = (short)930692144;
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
				num = (short)1904214017;
				if (num != 0)
				{
				}
				num = (short)474284032;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide;
			}
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x002953EC File Offset: 0x002935EC
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
					num2 = (short)2066808835;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_FF;
				case 2:
				{
					num2 = (short)83492865;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1371175259;
					short num3 = num2;
					num2 = (short)125794651;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_46;
					default:
						num2 = (short)1708457984;
						if (num2 != 0)
						{
						}
						num2 = (short)812646401;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1395064834;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					if (base.ParentRecset != null)
					{
						goto IL_46;
					}
					return result;
				}
				goto IL_24;
				IL_46:
				num2 = (short)34340864;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_FF:
			num2 = (short)1534984192;
			short num4 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)1796472836;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x0029556C File Offset: 0x0029376C
		private void b()
		{
			short num = (short)1035608381;
			short num2 = num;
			num = (short)2024874301;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1640955904;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1279000577;
			if (num != 0)
			{
			}
			num = (short)1943470080;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x0029561C File Offset: 0x0029381C
		private void a()
		{
			short num = (short)1177163903;
			short num2 = num;
			num = (short)2075203711;
			switch (num2 == num)
			{
			default:
			{
				num = (short)234094592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)377683969;
			if (num != 0)
			{
			}
			num = (short)993656832;
			if (num != 0)
			{
			}
			base.PropertyChanged += global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection.CalculateValidityOnInvalids_Handler;
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x002956D4 File Offset: 0x002938D4
		public static void CalculateValidityOnInvalids_Handler(object section, global::System.ComponentModel.PropertyChangedEventArgs label)
		{
			int a_ = 5;
			short num = (short)2042494976;
			switch (num)
			{
			default:
			{
				num = (short)368640002;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide dvrswide;
					global::AcpCommonLib.IAcpRecordset feature;
					switch (num2)
					{
					case 0:
						goto IL_2C6;
					case 1:
						if (dvrswide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
						{
							num = (short)472317963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D9;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_9E;
						}
						continue;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset;
						if (scanListInnerRecset != null)
						{
							num = (short)1564409863;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D9;
					}
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = scanListInnerRecset.GetEnumerator();
						num = (short)2130903054;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)81199105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (!global::AcpCommonLib.ConstraintManager.Suspended)
						{
							num = (short)2141126660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
						num = (short)1915551756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = scanListInnerRecset.GetEnumerator();
						num = (short)1883439117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (feature != null)
						{
							num = (short)536674304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D9;
					case 10:
						if (section != null)
						{
							num = (short)1499136018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
						goto IL_5C7;
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection scanListInnerSection;
						if ((scanListInnerSection.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList).General.ScanLstGeneralScanType_A9058.Value == 4)
						{
							num = (short)581107720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D9;
					}
					case 13:
						try
						{
							num = (short)1851523076;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)504625302;
									short num3 = num;
									num = (short)1372321942;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1894449152;
										if (num != 0)
										{
										}
										break;
									}
									break;
								}
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1259274243;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									(((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10133] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection).ScanLstScanListChannel_A7620.CalculateValidity();
									num = (short)1055064064;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_253;
								case 3:
									num = (short)1792868354;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_176;
									}
									continue;
								}
								IL_1FC:
								num = (short)455606273;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_176:
								goto IL_1FC;
							}
							IL_253:
							goto IL_D9;
						}
						finally
						{
							num = (short)1153368066;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_2C3;
								case 1:
									enumerator.Dispose();
									num = (short)400621568;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_28B;
									}
									continue;
								}
								IL_28B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)375390209;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2C3:;
						}
						goto IL_2C6;
					case 14:
						try
						{
							num = (short)1665335302;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									if (!acpRecRefField.Valid)
									{
										num = (short)602275845;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)160956419;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_555;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)310509569;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField = (((global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner)enumerator.Current)[10133] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection).ScanLstScanListChannel_A7620;
									num = (short)2082865152;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									acpRecRefField.CalculateValidity();
									num = (short)195821570;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_482;
									}
									continue;
								}
								IL_484:
								num = (short)375848964;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_482:
								goto IL_484;
							}
							IL_555:
							return;
						}
						finally
						{
							num = (short)1982005250;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_5C4;
								case 1:
									enumerator.Dispose();
									num = (short)2106458112;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_58D;
									}
									continue;
								}
								IL_58D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1874198529;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5C4:;
						}
						goto IL_5C7;
					case 15:
						num = (short)9961473;
						if (num != 0)
						{
						}
						num = (short)558759942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						num = (short)1009909760;
						short num4 = num;
						num = (short)382861322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (dvrswide != null)
						{
							num = (short)856817669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D9;
					case 18:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection scanListInnerSection = section as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection;
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset = scanListInnerSection.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset;
						feature = global::AcpCommonLib.FeatureManager.GetFeature(4142);
						num = (short)775749641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset;
						if (scanListInnerRecset != null)
						{
							num = (short)1602682895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					IL_9E:
					if (label.PropertyName == global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ苍ꏏꛑ蟓뗕맗듙郛럝鏟雡꟣軥觧蓩苫语鳯귱뗳쇵컷죹쳻ꇽ嗿䬁刃朅搇缉椋", a_))
					{
						num = (short)1488388112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_D9:
					num = (short)1340538899;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2C6:
					dvrswide = (feature[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide);
					num = (short)744095761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5C7:
					num = (short)2034302979;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x04000FC2 RID: 4034
		private global::AcpBusinessLayer.AcpRecRefField scanLstScanListZone_A9718;

		// Token: 0x04000FC3 RID: 4035
		private global::AcpBusinessLayer.AcpKeyField scanLstScanListKeyofScanListMBRTable_A12673;

		// Token: 0x04000FC4 RID: 4036
		private global::AcpBusinessLayer.AcpRecRefField scanLstScanListChannel_A7620;

		// Token: 0x04000FC5 RID: 4037
		private global::AcpBusinessLayer.AcpField<bool> scanLstScanListLTEInterferingFreqPresent_A42196;
	}
}
