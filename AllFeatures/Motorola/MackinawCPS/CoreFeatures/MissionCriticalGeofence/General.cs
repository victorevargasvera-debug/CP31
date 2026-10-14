using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence
{
	// Token: 0x0200026C RID: 620
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06006E66 RID: 28262 RVA: 0x0062650C File Offset: 0x0062470C
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06006E67 RID: 28263 RVA: 0x0062654C File Offset: 0x0062474C
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06006E68 RID: 28264 RVA: 0x00626564 File Offset: 0x00624764
		public override void Init()
		{
			int a_ = 15;
			short num = (short)316632447;
			short num2 = num;
			num = (short)1637510527;
			switch (num2 == num)
			{
			}
			num = (short)229834752;
			short num3 = num;
			num = (short)415367169;
			if (num != 0)
			{
			}
			num = (short)1226571776;
			if (num != 0)
			{
			}
			this.geofenceAliasName_42867 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("韏럑믓냕뷗듙뿛믝ꇟ軡跣蟥鯧ꓩ跫菭闯귱샳쓵샷쳹쯻", a_), global::CommonResources.AcgResources.ID_GEOFENCEALIASNAME, 14);
			this.geofenceAliasName_42867.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.geofenceAliasName_42867.DataTransferOrder = 91;
			this.mcGeofencePriority_42879 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鷏뇑鏓돕럗볙맛냝菟蟡듣铥臧藩黫蟭蓯诱꯳싵쫷싹쯻쟽", a_), global::CommonResources.AcgResources.ID_PRIORITY, 1, 100, null, null, 0, 1);
			this.mcGeofencePriority_42879.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.mcGeofencePriority_42879.DataTransferOrder = 92;
			this.mcGeofencePriority_42879.ValidateAcrossRecset = true;
			this.mcGeofencePriority_42879.ShowHexValue = false;
			this.mcGeofenceEntryAction_42887 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鷏뇑鏓돕럗볙맛냝菟蟡ꇣ裥鳧飩闫꿭鏯蛱鷳駵雷ꗹ죻쳽㣿㨁㌃", a_), global::CommonResources.AcgResources.ID_ENTRYACTION, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.mcGeofenceEntryAction_42887.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.mcGeofenceEntryAction_42887.DataTransferOrder = 94;
			this.mcGeofenceExitAction_42888 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鷏뇑鏓돕럗볙맛냝菟蟡ꇣ黥臧黩귫跭蓯鯱鯳飵ꟷ컹컻웽㣿㨁", a_), global::CommonResources.AcgResources.ID_EXITACTION, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.mcGeofenceExitAction_42888.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.mcGeofenceExitAction_42888.DataTransferOrder = 95;
			this.mcGeofenceRadiusInMeters_42890 = new global::AcpBusinessLayer.AcpCustomRangeField(10, this, global::AllFeatures.CodeplugGuid.b("鷏뇑鏓돕럗볙맛냝菟蟡뛣蟥賧菩駫鷭맯鳱맳鏵賷鿹軻跽忿㘁㘃㸅ㄇ㨉", a_), global::CommonResources.AcgResources.ID_RADIUSMETERS, 0, 5000000, 1, null, null);
			this.mcGeofenceRadiusInMeters_42890.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.mcGeofenceRadiusInMeters_42890.DataTransferOrder = 93;
			this.mcGeofenceRadiusInMeters_42890.AddCustomValue(0, global::CommonResources.AcgResources.ID_DISABLED);
			this.mcGeofenceRadiusInMeters_42890.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("韏럑뫓돕꫗믙냛", a_);
			base.Id = 10810;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06006E69 RID: 28265 RVA: 0x006267D4 File Offset: 0x006249D4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)2111766528;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_7A;
					}
					continue;
				case 1:
					goto IL_113;
				case 2:
					if (producerFields != null)
					{
						num = (short)513146894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4FD;
				case 3:
					this.mcGeofenceRadiusInMeters_42890 = new global::AcpBusinessLayer.AcpCustomRangeField(10, this, global::AllFeatures.CodeplugGuid.b("軂ꛄ胆곈꓊ꯌ꫎뿐냒냔藖룘뿚드꫞鋠ꫢ诤ꫦ賨鿪裬鷮苰곲쇴엶쇸싺췼", a_), global::CommonResources.AcgResources.ID_RADIUSMETERS, null, null);
					this.mcGeofenceRadiusInMeters_42890.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.mcGeofenceRadiusInMeters_42890.DataTransferOrder = 93;
					this.mcGeofenceRadiusInMeters_42890.AddCustomValue(0, global::CommonResources.AcgResources.ID_DISABLED);
					this.mcGeofenceRadiusInMeters_42890.ShowHexValue = false;
					num = (short)63045650;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)368836609;
					if (num != 0)
					{
					}
					num = (short)765132800;
					short num3 = num;
					num = (short)1779105794;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					this.mcGeofenceEntryAction_42887 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("軂ꛄ胆곈꓊ꯌ꫎뿐냒냔鋖럘꿚꿜ꛞꃠ胢釤軦蛨藪달\udbee쏰쯲췴샶", a_), global::CommonResources.AcgResources.ID_ENTRYACTION, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.mcGeofenceEntryAction_42887.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.mcGeofenceEntryAction_42887.DataTransferOrder = 94;
					num = (short)1840840715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_4B1;
				case 7:
					this.mcGeofencePriority_42879 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("軂ꛄ胆곈꓊ꯌ꫎뿐냒냔蟖ꯘ닚닜귞裠韢鳤룦\udde8\ud9ea헬\ud8ee죰", a_), global::CommonResources.AcgResources.ID_PRIORITY, null, null, 0, 1);
					this.mcGeofencePriority_42879.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.mcGeofencePriority_42879.DataTransferOrder = 92;
					this.mcGeofencePriority_42879.ValidateAcrossRecset = true;
					this.mcGeofencePriority_42879.ShowHexValue = false;
					num = (short)678690817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					num = (short)794727144;
					short num4 = num;
					num = (short)804623080;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1144324096;
						if (num != 0)
						{
						}
						break;
					}
					this.geofenceAliasName_42867 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("蓂ꃄ꣆꿈껊ꏌ곎듐鋒맔뻖룘꣚鏜뻞賠蛢뫤폦\udbe8폪\udbec\ud8ee", a_), global::CommonResources.AcgResources.ID_GEOFENCEALIASNAME, 14);
					this.geofenceAliasName_42867.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.geofenceAliasName_42867.DataTransferOrder = 91;
					num = (short)20054022;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軂ꛄ胆곈꓊ꯌ꫎뿐냒냔鋖ꇘ닚꧜點苠韢賤裦蟨듪\ud9ec\uddee짰쯲췴", a_)))
					{
						num = (short)1963851792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F2;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軂ꛄ胆곈꓊ꯌ꫎뿐냒냔蟖ꯘ닚닜귞裠韢鳤룦\udde8\ud9ea헬\ud8ee죰", a_)))
					{
						num = (short)955514887;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_113;
				case 11:
					goto IL_C7;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軂ꛄ胆곈꓊ꯌ꫎뿐냒냔藖룘뿚드꫞鋠ꫢ诤ꫦ賨鿪裬鷮苰곲쇴엶쇸싺췼", a_)))
					{
						num = (short)153223171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4FD;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("軂ꛄ胆곈꓊ꯌ꫎뿐냒냔鋖럘꿚꿜ꛞꃠ胢釤軦蛨藪달\udbee쏰쯲췴샶", a_)))
					{
						num = (short)973275141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C7;
				case 14:
					num = (short)448921617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_1F2;
				case 16:
					this.mcGeofenceExitAction_42888 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("軂ꛄ胆곈꓊ꯌ꫎뿐냒냔鋖ꇘ닚꧜點苠韢賤裦蟨듪\ud9ec\uddee짰쯲췴", a_), global::CommonResources.AcgResources.ID_EXITACTION, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.mcGeofenceExitAction_42888.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.mcGeofenceExitAction_42888.DataTransferOrder = 95;
					num = (short)645267471;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓂ꃄ꣆꿈껊ꏌ곎듐鋒맔뻖룘꣚鏜뻞賠蛢뫤폦\udbe8폪\udbec\ud8ee", a_)))
					{
						num = (short)1226506248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4B1;
				case 18:
					goto IL_37D;
				}
				IL_7A:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1240924164;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_C7:
				num = (short)848887817;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_113:
				num = (short)1087832077;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F2:
				num = (short)1045889036;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4B1:
				num = (short)481165322;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_37D:
			IL_4FD:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓂ꃄ꧆곈맊곌ꏎ", a_);
			base.Id = 10810;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06006E6A RID: 28266 RVA: 0x00626D10 File Offset: 0x00624F10
		public override void PopulateReferences()
		{
			short num = (short)536211114;
			short num2 = num;
			num = (short)1509813930;
			switch (num2 == num)
			{
			}
			num = (short)1112276992;
			short num3 = num;
			num = (short)839778304;
			if (num != 0)
			{
			}
			num = (short)882900993;
			if (num != 0)
			{
			}
			this.mcGeofenceEntryAction_42887.SetRecset(this.a(4008));
			this.mcGeofenceExitAction_42888.SetRecset(this.a(4008));
		}

		// Token: 0x06006E6B RID: 28267 RVA: 0x00626DE4 File Offset: 0x00624FE4
		public override void DropReferences()
		{
			short num = (short)205615450;
			short num2 = num;
			num = (short)1684238682;
			switch (num2 == num)
			{
			}
			num = (short)1223950336;
			short num3 = num;
			num = (short)829095937;
			if (num != 0)
			{
			}
			num = (short)1933967360;
			if (num != 0)
			{
			}
		}

		// Token: 0x06006E6C RID: 28268 RVA: 0x00626E90 File Offset: 0x00625090
		public override void SetConstraints()
		{
			short num = (short)711635222;
			short num2 = num;
			num = (short)485994774;
			switch (num2 == num)
			{
			}
			num = (short)1701576704;
			short num3 = num;
			num = (short)1410203649;
			if (num != 0)
			{
			}
			num = (short)1266810880;
			if (num != 0)
			{
			}
			this.geofenceAliasName_42867.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceConstraints.ConLocationEnableIsEnabled);
			this.mcGeofencePriority_42879.ValidateAcrossRecset = true;
			this.mcGeofencePriority_42879.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceConstraints.ConLocationEnableIsEnabled);
			this.mcGeofencePriority_42879.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceConstraints.conGeofencePriorityValid);
			this.mcGeofenceEntryAction_42887.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceConstraints.ConLocationEnableIsEnabled);
			this.mcGeofenceEntryAction_42887.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceConstraints.conEntryActionValid);
			this.mcGeofenceExitAction_42888.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceConstraints.ConLocationEnableIsEnabled);
			this.mcGeofenceExitAction_42888.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceConstraints.conExitActionValid);
			this.mcGeofenceRadiusInMeters_42890.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceConstraints.conGeofenceRadiusApplicable);
			this.mcGeofenceRadiusInMeters_42890.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceConstraints.conGeofenceRadiusValid);
			this.mcGeofenceRadiusInMeters_42890.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceConstraints.conGeofenceRadiusEditable);
		}

		// Token: 0x06006E6D RID: 28269 RVA: 0x0062702C File Offset: 0x0062522C
		public override void SetupDependencies()
		{
			short num = (short)1304757856;
			short num2 = num;
			num = (short)639501920;
			switch (num2 == num)
			{
			}
			num = (short)1431633920;
			short num3 = num;
			num = (short)1012858880;
			if (num != 0)
			{
			}
			num = (short)1916010497;
			if (num != 0)
			{
			}
			this.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.AddDependentObject(this.geofenceAliasName_42867);
			this.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.AddDependentObject(this.mcGeofencePriority_42879);
			this.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.AddDependentObject(this.mcGeofenceEntryAction_42887);
			this.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.AddDependentObject(this.mcGeofenceExitAction_42888);
			this.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.AddDependentObject(this.mcGeofenceRadiusInMeters_42890);
		}

		// Token: 0x17003914 RID: 14612
		// (get) Token: 0x06006E6E RID: 28270 RVA: 0x00627160 File Offset: 0x00625360
		public global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation ActionConsolidationForMcGeofenceEntryAction_42887
		{
			get
			{
				short num = (short)787888762;
				short num2 = num;
				num = (short)1843477114;
				switch (num2 == num)
				{
				}
				num = (short)1870266368;
				short num3 = num;
				num = (short)1336279041;
				if (num != 0)
				{
				}
				num = (short)1686372352;
				if (num != 0)
				{
				}
				return this.mcGeofenceEntryAction_42887.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation;
			}
		}

		// Token: 0x17003915 RID: 14613
		// (get) Token: 0x06006E6F RID: 28271 RVA: 0x00627218 File Offset: 0x00625418
		public global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation ActionConsolidationForMcGeofenceExitAction_42888
		{
			get
			{
				short num = (short)1597317414;
				short num2 = num;
				num = (short)881074470;
				switch (num2 == num)
				{
				}
				num = (short)1075314688;
				short num3 = num;
				num = (short)2002255872;
				if (num != 0)
				{
				}
				num = (short)1220018177;
				if (num != 0)
				{
				}
				return this.mcGeofenceExitAction_42888.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation;
			}
		}

		// Token: 0x17003916 RID: 14614
		// (get) Token: 0x06006E70 RID: 28272 RVA: 0x006272D4 File Offset: 0x006254D4
		public bool HasDiffs
		{
			get
			{
				short num = (short)756651048;
				short num2 = num;
				num = (short)1669829672;
				switch (num2 == num)
				{
				}
				num = (short)1087373312;
				short num3 = num;
				num = (short)364773377;
				if (num != 0)
				{
				}
				num = (short)237371392;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003917 RID: 14615
		// (get) Token: 0x06006E71 RID: 28273 RVA: 0x00627384 File Offset: 0x00625584
		// (set) Token: 0x06006E72 RID: 28274 RVA: 0x00627438 File Offset: 0x00625638
		public string GeofenceAliasName_42867Value
		{
			get
			{
				short num = (short)471466936;
				short num2 = num;
				num = (short)1116341176;
				switch (num2 == num)
				{
				}
				num = (short)145555456;
				short num3 = num;
				num = (short)2005598209;
				if (num != 0)
				{
				}
				num = (short)754778112;
				if (num != 0)
				{
				}
				return this.geofenceAliasName_42867.Value;
			}
			set
			{
				short num = (short)735838208;
				short num2 = num;
				num = (short)493289473;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						this.geofenceAliasName_42867.Value = value;
						num = (short)706871298;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5B;
						}
						continue;
					case 2:
						goto IL_A2;
					}
					IL_5B:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						goto IL_ED;
					}
					num = (short)533069824;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_A2:
				num = (short)2029672212;
				short num4 = num;
				num = (short)1597331220;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1435107328;
					if (num != 0)
					{
					}
					break;
				}
				IL_ED:
				num = (short)910360577;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17003918 RID: 14616
		// (get) Token: 0x06006E73 RID: 28275 RVA: 0x0062755C File Offset: 0x0062575C
		// (set) Token: 0x06006E74 RID: 28276 RVA: 0x0062760C File Offset: 0x0062580C
		public string GeofenceAliasName_42867_UIValue
		{
			get
			{
				short num = (short)1070166083;
				short num2 = num;
				num = (short)93352003;
				switch (num2 == num)
				{
				}
				num = (short)1251868672;
				short num3 = num;
				num = (short)1503002624;
				if (num != 0)
				{
				}
				num = (short)1396441089;
				if (num != 0)
				{
				}
				return this.geofenceAliasName_42867.Value;
			}
			set
			{
				short num = (short)412207313;
				short num2 = num;
				num = (short)1061210321;
				switch (num2 == num)
				{
				}
				num = (short)987103232;
				short num3 = num;
				num = (short)1426259969;
				if (num != 0)
				{
				}
				num = (short)1986068480;
				if (num != 0)
				{
				}
				this.geofenceAliasName_42867.Value = value;
			}
		}

		// Token: 0x17003919 RID: 14617
		// (get) Token: 0x06006E75 RID: 28277 RVA: 0x006276C4 File Offset: 0x006258C4
		public global::AcpBusinessLayer.AcpKeyField GeofenceAliasName_42867
		{
			get
			{
				short num = (short)1586560744;
				short num2 = num;
				num = (short)224394984;
				switch (num2 == num)
				{
				}
				num = (short)1953038336;
				short num3 = num;
				num = (short)86966273;
				if (num != 0)
				{
				}
				num = (short)206831616;
				if (num != 0)
				{
				}
				return this.geofenceAliasName_42867;
			}
		}

		// Token: 0x1700391A RID: 14618
		// (get) Token: 0x06006E76 RID: 28278 RVA: 0x00627778 File Offset: 0x00625978
		// (set) Token: 0x06006E77 RID: 28279 RVA: 0x0062782C File Offset: 0x00625A2C
		public bool GeofenceAliasName_42867_Applicable
		{
			get
			{
				short num = (short)2076105067;
				short num2 = num;
				num = (short)404871531;
				switch (num2 == num)
				{
				}
				num = (short)69664768;
				short num3 = num;
				num = (short)145293313;
				if (num != 0)
				{
				}
				num = (short)555679744;
				if (num != 0)
				{
				}
				return this.geofenceAliasName_42867.Applicable;
			}
			set
			{
				short num = (short)977774850;
				short num2 = num;
				num = (short)1068607746;
				switch (num2 == num)
				{
				}
				num = (short)2051080192;
				short num3 = num;
				num = (short)44630016;
				if (num != 0)
				{
				}
				num = (short)49610753;
				if (num != 0)
				{
				}
				this.geofenceAliasName_42867.Applicable = value;
			}
		}

		// Token: 0x1700391B RID: 14619
		// (get) Token: 0x06006E78 RID: 28280 RVA: 0x006278E0 File Offset: 0x00625AE0
		// (set) Token: 0x06006E79 RID: 28281 RVA: 0x00627998 File Offset: 0x00625B98
		public bool GeofenceAliasName_42867_Valid
		{
			get
			{
				short num = (short)1767645023;
				short num2 = num;
				num = (short)1596202847;
				switch (num2 == num)
				{
				}
				num = (short)1127415808;
				short num3 = num;
				num = (short)1076035584;
				if (num != 0)
				{
				}
				num = (short)1430257665;
				if (num != 0)
				{
				}
				return this.geofenceAliasName_42867.Valid;
			}
			set
			{
				short num = (short)1389226944;
				short num2 = num;
				num = (short)1997073344;
				switch (num2 == num)
				{
				}
				num = (short)214433792;
				short num3 = num;
				num = (short)1055916032;
				if (num != 0)
				{
				}
				num = (short)976289793;
				if (num != 0)
				{
				}
				this.geofenceAliasName_42867.Valid = value;
			}
		}

		// Token: 0x1700391C RID: 14620
		// (get) Token: 0x06006E7A RID: 28282 RVA: 0x00627A50 File Offset: 0x00625C50
		// (set) Token: 0x06006E7B RID: 28283 RVA: 0x00627B08 File Offset: 0x00625D08
		public bool GeofenceAliasName_42867_Visible
		{
			get
			{
				short num = (short)2112385279;
				short num2 = num;
				num = (short)1005416703;
				switch (num2 == num)
				{
				}
				num = (short)90505216;
				short num3 = num;
				num = (short)2135883777;
				if (num != 0)
				{
				}
				num = (short)1880489984;
				if (num != 0)
				{
				}
				return this.geofenceAliasName_42867.Visible;
			}
			set
			{
				short num = (short)1357696039;
				short num2 = num;
				num = (short)1388366887;
				switch (num2 == num)
				{
				}
				num = (short)1731264512;
				short num3 = num;
				num = (short)104005633;
				if (num != 0)
				{
				}
				num = (short)1886322688;
				if (num != 0)
				{
				}
				this.geofenceAliasName_42867.Visible = value;
			}
		}

		// Token: 0x1700391D RID: 14621
		// (get) Token: 0x06006E7C RID: 28284 RVA: 0x00627BBC File Offset: 0x00625DBC
		// (set) Token: 0x06006E7D RID: 28285 RVA: 0x00627C70 File Offset: 0x00625E70
		public bool GeofenceAliasName_42867_Editable
		{
			get
			{
				short num = (short)916909779;
				short num2 = num;
				num = (short)1860169427;
				switch (num2 == num)
				{
				}
				num = (short)433258496;
				short num3 = num;
				num = (short)638713857;
				if (num != 0)
				{
				}
				num = (short)1825701888;
				if (num != 0)
				{
				}
				return this.geofenceAliasName_42867.Editable;
			}
			set
			{
				short num = (short)1455246273;
				short num2 = num;
				num = (short)2089700289;
				switch (num2 == num)
				{
				}
				num = (short)583008256;
				short num3 = num;
				num = (short)1042677760;
				if (num != 0)
				{
				}
				num = (short)971636737;
				if (num != 0)
				{
				}
				this.geofenceAliasName_42867.Editable = value;
			}
		}

		// Token: 0x1700391E RID: 14622
		// (get) Token: 0x06006E7E RID: 28286 RVA: 0x00627D2C File Offset: 0x00625F2C
		internal string GeofenceAliasName_42867_UILabel
		{
			get
			{
				short num = (short)1274055721;
				short num2 = num;
				num = (short)140151849;
				switch (num2 == num)
				{
				}
				num = (short)1072300032;
				short num3 = num;
				num = (short)1083834369;
				if (num != 0)
				{
				}
				num = (short)1085472768;
				if (num != 0)
				{
				}
				return this.geofenceAliasName_42867.UIName;
			}
		}

		// Token: 0x1700391F RID: 14623
		// (get) Token: 0x06006E7F RID: 28287 RVA: 0x00627DE0 File Offset: 0x00625FE0
		// (set) Token: 0x06006E80 RID: 28288 RVA: 0x00627E94 File Offset: 0x00626094
		internal bool GeofenceAliasName_42867_HiddenStatic
		{
			get
			{
				short num = (short)806420481;
				if (num != 0)
				{
				}
				num = (short)91427719;
				short num2 = num;
				num = (short)2125730695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1620705280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1201012736;
				if (num != 0)
				{
				}
				return this.geofenceAliasName_42867.HiddenStatic;
			}
			set
			{
				short num = (short)51713660;
				short num2 = num;
				num = (short)1535448700;
				switch (num2 == num)
				{
				}
				num = (short)982122496;
				short num3 = num;
				num = (short)1423900673;
				if (num != 0)
				{
				}
				num = (short)1233387520;
				if (num != 0)
				{
				}
				this.geofenceAliasName_42867.HiddenStatic = value;
			}
		}

		// Token: 0x17003920 RID: 14624
		// (get) Token: 0x06006E81 RID: 28289 RVA: 0x00627F48 File Offset: 0x00626148
		// (set) Token: 0x06006E82 RID: 28290 RVA: 0x00627FFC File Offset: 0x006261FC
		internal bool GeofenceAliasName_42867_HiddenDynamic
		{
			get
			{
				short num = (short)1724521696;
				short num2 = num;
				num = (short)2058296544;
				switch (num2 == num)
				{
				}
				num = (short)1069285376;
				short num3 = num;
				num = (short)554369025;
				if (num != 0)
				{
				}
				num = (short)1483603968;
				if (num != 0)
				{
				}
				return this.geofenceAliasName_42867.HiddenDynamic;
			}
			set
			{
				short num = (short)1727359119;
				short num2 = num;
				num = (short)1931176079;
				switch (num2 == num)
				{
				}
				num = (short)262340608;
				short num3 = num;
				num = (short)341573632;
				if (num != 0)
				{
				}
				num = (short)271581185;
				if (num != 0)
				{
				}
				this.geofenceAliasName_42867.HiddenDynamic = value;
			}
		}

		// Token: 0x17003921 RID: 14625
		// (get) Token: 0x06006E83 RID: 28291 RVA: 0x006280B4 File Offset: 0x006262B4
		public bool GeofenceAliasName_42867_HasDiffs
		{
			get
			{
				short num = (short)1192724602;
				short num2 = num;
				num = (short)1545832570;
				switch (num2 == num)
				{
				}
				num = (short)1826750464;
				short num3 = num;
				num = (short)423493632;
				if (num != 0)
				{
				}
				num = (short)686161921;
				if (num != 0)
				{
				}
				return this.geofenceAliasName_42867._HasDiffs;
			}
		}

		// Token: 0x17003922 RID: 14626
		// (get) Token: 0x06006E84 RID: 28292 RVA: 0x0062816C File Offset: 0x0062636C
		// (set) Token: 0x06006E85 RID: 28293 RVA: 0x00628224 File Offset: 0x00626424
		public int McGeofencePriority_42879Value
		{
			get
			{
				short num = (short)994157812;
				short num2 = num;
				num = (short)1080927476;
				switch (num2 == num)
				{
				}
				num = (short)1002242048;
				short num3 = num;
				num = (short)2057633792;
				if (num != 0)
				{
				}
				num = (short)1115947009;
				if (num != 0)
				{
				}
				return this.mcGeofencePriority_42879.Value;
			}
			set
			{
				short num = (short)1134808147;
				short num2 = num;
				num = (short)578931795;
				switch (num2 == num)
				{
				}
				num = (short)2123628544;
				short num3 = num;
				num = (short)711327745;
				if (num != 0)
				{
				}
				num = (short)372768768;
				if (num != 0)
				{
				}
				this.mcGeofencePriority_42879.Value = value;
			}
		}

		// Token: 0x17003923 RID: 14627
		// (get) Token: 0x06006E86 RID: 28294 RVA: 0x006282D8 File Offset: 0x006264D8
		public global::AcpBusinessLayer.AcpSimpleRangeField McGeofencePriority_42879
		{
			get
			{
				short num = (short)2006415892;
				short num2 = num;
				num = (short)263420436;
				switch (num2 == num)
				{
				}
				num = (short)1099169792;
				short num3 = num;
				num = (short)1830617089;
				if (num != 0)
				{
				}
				num = (short)244580352;
				if (num != 0)
				{
				}
				return this.mcGeofencePriority_42879;
			}
		}

		// Token: 0x17003924 RID: 14628
		// (get) Token: 0x06006E87 RID: 28295 RVA: 0x00628388 File Offset: 0x00626588
		// (set) Token: 0x06006E88 RID: 28296 RVA: 0x0062843C File Offset: 0x0062663C
		public string McGeofencePriority_42879_UIValue
		{
			get
			{
				short num = (short)539747618;
				short num2 = num;
				num = (short)530572578;
				switch (num2 == num)
				{
				}
				num = (short)475725824;
				short num3 = num;
				num = (short)1256783872;
				if (num != 0)
				{
				}
				num = (short)1791426561;
				if (num != 0)
				{
				}
				return this.mcGeofencePriority_42879.UIValue;
			}
			set
			{
				short num = (short)2109827558;
				short num2 = num;
				num = (short)711748070;
				switch (num2 == num)
				{
				}
				num = (short)9175040;
				short num3 = num;
				num = (short)604176385;
				if (num != 0)
				{
				}
				num = (short)948895744;
				if (num != 0)
				{
				}
				this.mcGeofencePriority_42879.UIValue = value;
			}
		}

		// Token: 0x17003925 RID: 14629
		// (get) Token: 0x06006E89 RID: 28297 RVA: 0x006284F0 File Offset: 0x006266F0
		// (set) Token: 0x06006E8A RID: 28298 RVA: 0x006285A4 File Offset: 0x006267A4
		internal int McGeofencePriority_42879Min
		{
			get
			{
				short num = (short)1380157810;
				short num2 = num;
				num = (short)816089458;
				switch (num2 == num)
				{
				}
				num = (short)1751252992;
				short num3 = num;
				num = (short)1901723649;
				if (num != 0)
				{
				}
				num = (short)1607663616;
				if (num != 0)
				{
				}
				return this.mcGeofencePriority_42879.Min;
			}
			set
			{
				short num = (short)1276526425;
				short num2 = num;
				num = (short)1447051097;
				switch (num2 == num)
				{
				}
				num = (short)1785659392;
				short num3 = num;
				num = (short)380370945;
				if (num != 0)
				{
				}
				num = (short)343277568;
				if (num != 0)
				{
				}
				this.mcGeofencePriority_42879.Min = value;
			}
		}

		// Token: 0x17003926 RID: 14630
		// (get) Token: 0x06006E8B RID: 28299 RVA: 0x00628658 File Offset: 0x00626858
		// (set) Token: 0x06006E8C RID: 28300 RVA: 0x00628710 File Offset: 0x00626910
		internal int McGeofencePriority_42879Max
		{
			get
			{
				short num = (short)1665417031;
				short num2 = num;
				num = (short)830553927;
				switch (num2 == num)
				{
				}
				num = (short)2113470464;
				short num3 = num;
				num = (short)2115108864;
				if (num != 0)
				{
				}
				num = (short)1853751297;
				if (num != 0)
				{
				}
				return this.mcGeofencePriority_42879.Max;
			}
			set
			{
				short num = (short)769055537;
				short num2 = num;
				num = (short)345037617;
				switch (num2 == num)
				{
				}
				num = (short)634978304;
				short num3 = num;
				num = (short)704643072;
				if (num != 0)
				{
				}
				num = (short)1091371009;
				if (num != 0)
				{
				}
				this.mcGeofencePriority_42879.Max = value;
			}
		}

		// Token: 0x17003927 RID: 14631
		// (get) Token: 0x06006E8D RID: 28301 RVA: 0x006287C8 File Offset: 0x006269C8
		// (set) Token: 0x06006E8E RID: 28302 RVA: 0x0062887C File Offset: 0x00626A7C
		internal int McGeofencePriority_42879Step
		{
			get
			{
				short num = (short)13401112;
				short num2 = num;
				num = (short)2000256024;
				switch (num2 == num)
				{
				}
				num = (short)2010972160;
				short num3 = num;
				num = (short)2049638401;
				if (num != 0)
				{
				}
				num = (short)831389696;
				if (num != 0)
				{
				}
				return this.mcGeofencePriority_42879.StepSize;
			}
			set
			{
				short num = (short)959773637;
				short num2 = num;
				num = (short)225967045;
				switch (num2 == num)
				{
				}
				num = (short)186974208;
				short num3 = num;
				num = (short)2023096321;
				if (num != 0)
				{
				}
				num = (short)891224064;
				if (num != 0)
				{
				}
				this.mcGeofencePriority_42879.StepSize = value;
			}
		}

		// Token: 0x17003928 RID: 14632
		// (get) Token: 0x06006E8F RID: 28303 RVA: 0x00628930 File Offset: 0x00626B30
		// (set) Token: 0x06006E90 RID: 28304 RVA: 0x006289E4 File Offset: 0x00626BE4
		public bool McGeofencePriority_42879_Applicable
		{
			get
			{
				short num = (short)1277235456;
				short num2 = num;
				num = (short)1826689280;
				switch (num2 == num)
				{
				}
				num = (short)1839071232;
				short num3 = num;
				num = (short)669319169;
				if (num != 0)
				{
				}
				num = (short)1187446784;
				if (num != 0)
				{
				}
				return this.mcGeofencePriority_42879.Applicable;
			}
			set
			{
				short num = (short)107316553;
				short num2 = num;
				num = (short)1562019145;
				switch (num2 == num)
				{
				}
				num = (short)1174339584;
				short num3 = num;
				num = (short)1418133505;
				if (num != 0)
				{
				}
				num = (short)1597571072;
				if (num != 0)
				{
				}
				this.mcGeofencePriority_42879.Applicable = value;
			}
		}

		// Token: 0x17003929 RID: 14633
		// (get) Token: 0x06006E91 RID: 28305 RVA: 0x00628A9C File Offset: 0x00626C9C
		// (set) Token: 0x06006E92 RID: 28306 RVA: 0x00628B54 File Offset: 0x00626D54
		public bool McGeofencePriority_42879_Valid
		{
			get
			{
				short num = (short)1173852829;
				short num2 = num;
				num = (short)205820573;
				switch (num2 == num)
				{
				}
				num = (short)1300365312;
				short num3 = num;
				num = (short)1738932225;
				if (num != 0)
				{
				}
				num = (short)1951465472;
				if (num != 0)
				{
				}
				return this.mcGeofencePriority_42879.Valid;
			}
			set
			{
				short num = (short)1161128754;
				short num2 = num;
				num = (short)557017906;
				switch (num2 == num)
				{
				}
				num = (short)1941176320;
				short num3 = num;
				num = (short)671547393;
				if (num != 0)
				{
				}
				num = (short)450232320;
				if (num != 0)
				{
				}
				this.mcGeofencePriority_42879.Valid = value;
			}
		}

		// Token: 0x1700392A RID: 14634
		// (get) Token: 0x06006E93 RID: 28307 RVA: 0x00628C08 File Offset: 0x00626E08
		// (set) Token: 0x06006E94 RID: 28308 RVA: 0x00628CC0 File Offset: 0x00626EC0
		public bool McGeofencePriority_42879_Visible
		{
			get
			{
				short num = (short)347537409;
				if (num != 0)
				{
				}
				num = (short)1675874717;
				short num2 = num;
				num = (short)1281020317;
				switch (num2 == num)
				{
				default:
				{
					num = (short)358678528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1275396096;
				if (num != 0)
				{
				}
				return this.mcGeofencePriority_42879.Visible;
			}
			set
			{
				short num = (short)619550704;
				short num2 = num;
				num = (short)1100781552;
				switch (num2 == num)
				{
				}
				num = (short)1199243264;
				short num3 = num;
				num = (short)1118371841;
				if (num != 0)
				{
				}
				num = (short)10944512;
				if (num != 0)
				{
				}
				this.mcGeofencePriority_42879.Visible = value;
			}
		}

		// Token: 0x1700392B RID: 14635
		// (get) Token: 0x06006E95 RID: 28309 RVA: 0x00628D78 File Offset: 0x00626F78
		// (set) Token: 0x06006E96 RID: 28310 RVA: 0x00628E30 File Offset: 0x00627030
		public bool McGeofencePriority_42879_Editable
		{
			get
			{
				short num = (short)1737411270;
				short num2 = num;
				num = (short)1037814470;
				switch (num2 == num)
				{
				}
				num = (short)1277820928;
				short num3 = num;
				num = (short)382861313;
				if (num != 0)
				{
				}
				num = (short)413073408;
				if (num != 0)
				{
				}
				return this.mcGeofencePriority_42879.Editable;
			}
			set
			{
				short num = (short)1871477706;
				short num2 = num;
				num = (short)1487305674;
				switch (num2 == num)
				{
				}
				num = (short)1851916288;
				short num3 = num;
				num = (short)1955594241;
				if (num != 0)
				{
				}
				num = (short)177864704;
				if (num != 0)
				{
				}
				this.mcGeofencePriority_42879.Editable = value;
			}
		}

		// Token: 0x1700392C RID: 14636
		// (get) Token: 0x06006E97 RID: 28311 RVA: 0x00628EE4 File Offset: 0x006270E4
		internal string McGeofencePriority_42879_UILabel
		{
			get
			{
				short num = (short)9183353;
				short num2 = num;
				num = (short)2089754745;
				switch (num2 == num)
				{
				}
				num = (short)1172373504;
				short num3 = num;
				num = (short)168296448;
				if (num != 0)
				{
				}
				num = (short)546766849;
				if (num != 0)
				{
				}
				return this.mcGeofencePriority_42879.UIName;
			}
		}

		// Token: 0x1700392D RID: 14637
		// (get) Token: 0x06006E98 RID: 28312 RVA: 0x00628F94 File Offset: 0x00627194
		// (set) Token: 0x06006E99 RID: 28313 RVA: 0x0062904C File Offset: 0x0062724C
		internal bool McGeofencePriority_42879_HiddenStatic
		{
			get
			{
				short num = (short)378085226;
				short num2 = num;
				num = (short)438443882;
				switch (num2 == num)
				{
				}
				num = (short)716308480;
				short num3 = num;
				num = (short)649461760;
				if (num != 0)
				{
				}
				num = (short)2071789569;
				if (num != 0)
				{
				}
				return this.mcGeofencePriority_42879.HiddenStatic;
			}
			set
			{
				short num = (short)1027588787;
				short num2 = num;
				num = (short)914080435;
				switch (num2 == num)
				{
				}
				num = (short)1407385600;
				short num3 = num;
				num = (short)1575813121;
				if (num != 0)
				{
				}
				num = (short)2068512768;
				if (num != 0)
				{
				}
				this.mcGeofencePriority_42879.HiddenStatic = value;
			}
		}

		// Token: 0x1700392E RID: 14638
		// (get) Token: 0x06006E9A RID: 28314 RVA: 0x00629104 File Offset: 0x00627304
		// (set) Token: 0x06006E9B RID: 28315 RVA: 0x006291B4 File Offset: 0x006273B4
		internal bool McGeofencePriority_42879_HiddenDynamic
		{
			get
			{
				short num = (short)1648033793;
				if (num != 0)
				{
				}
				num = (short)955709492;
				short num2 = num;
				num = (short)713750580;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1045233664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)629407744;
				if (num != 0)
				{
				}
				return this.mcGeofencePriority_42879.HiddenDynamic;
			}
			set
			{
				short num = (short)946706508;
				short num2 = num;
				num = (short)1970706508;
				switch (num2 == num)
				{
				}
				num = (short)857800704;
				short num3 = num;
				num = (short)317652992;
				if (num != 0)
				{
				}
				num = (short)1865678849;
				if (num != 0)
				{
				}
				this.mcGeofencePriority_42879.HiddenDynamic = value;
			}
		}

		// Token: 0x1700392F RID: 14639
		// (get) Token: 0x06006E9C RID: 28316 RVA: 0x0062926C File Offset: 0x0062746C
		public bool McGeofencePriority_42879_HasDiffs
		{
			get
			{
				short num = (short)92012545;
				if (num != 0)
				{
				}
				num = (short)300298540;
				short num2 = num;
				num = (short)2095788332;
				switch (num2 == num)
				{
				default:
				{
					num = (short)139722752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1469513728;
				if (num != 0)
				{
				}
				return this.mcGeofencePriority_42879._HasDiffs;
			}
		}

		// Token: 0x17003930 RID: 14640
		// (get) Token: 0x06006E9D RID: 28317 RVA: 0x00629320 File Offset: 0x00627520
		// (set) Token: 0x06006E9E RID: 28318 RVA: 0x006293D8 File Offset: 0x006275D8
		public int McGeofenceEntryAction_42887Value
		{
			get
			{
				short num = (short)751067191;
				short num2 = num;
				num = (short)791830583;
				switch (num2 == num)
				{
				}
				num = (short)741605376;
				short num3 = num;
				num = (short)1168048129;
				if (num != 0)
				{
				}
				num = (short)795148288;
				if (num != 0)
				{
				}
				return this.mcGeofenceEntryAction_42887.Value;
			}
			set
			{
				short num = (short)99851434;
				short num2 = num;
				num = (short)888904874;
				switch (num2 == num)
				{
				}
				num = (short)1099956224;
				short num3 = num;
				num = (short)393543681;
				if (num != 0)
				{
				}
				num = (short)586350592;
				if (num != 0)
				{
				}
				this.mcGeofenceEntryAction_42887.Value = value;
			}
		}

		// Token: 0x17003931 RID: 14641
		// (get) Token: 0x06006E9F RID: 28319 RVA: 0x00629490 File Offset: 0x00627690
		// (set) Token: 0x06006EA0 RID: 28320 RVA: 0x00629544 File Offset: 0x00627744
		public string McGeofenceEntryAction_42887_UIValue
		{
			get
			{
				short num = (short)1187520958;
				short num2 = num;
				num = (short)1268982206;
				switch (num2 == num)
				{
				}
				num = (short)981073920;
				short num3 = num;
				num = (short)1827930113;
				if (num != 0)
				{
				}
				num = (short)617807872;
				if (num != 0)
				{
				}
				return this.mcGeofenceEntryAction_42887.UIValue;
			}
			set
			{
				short num = (short)1235486398;
				short num2 = num;
				num = (short)1797457598;
				switch (num2 == num)
				{
				}
				num = (short)618463232;
				short num3 = num;
				num = (short)248578048;
				if (num != 0)
				{
				}
				num = (short)1938882561;
				if (num != 0)
				{
				}
				this.mcGeofenceEntryAction_42887.UIValue = value;
			}
		}

		// Token: 0x17003932 RID: 14642
		// (get) Token: 0x06006EA1 RID: 28321 RVA: 0x006295F4 File Offset: 0x006277F4
		public global::AcpBusinessLayer.AcpRecRefField McGeofenceEntryAction_42887
		{
			get
			{
				short num = (short)1062722339;
				short num2 = num;
				num = (short)1440602915;
				switch (num2 == num)
				{
				}
				num = (short)1344077824;
				short num3 = num;
				num = (short)1742602240;
				if (num != 0)
				{
				}
				num = (short)272236545;
				if (num != 0)
				{
				}
				return this.mcGeofenceEntryAction_42887;
			}
		}

		// Token: 0x17003933 RID: 14643
		// (get) Token: 0x06006EA2 RID: 28322 RVA: 0x006296A4 File Offset: 0x006278A4
		// (set) Token: 0x06006EA3 RID: 28323 RVA: 0x0062975C File Offset: 0x0062795C
		public bool McGeofenceEntryAction_42887_Applicable
		{
			get
			{
				short num = (short)874011357;
				short num2 = num;
				num = (short)226843357;
				switch (num2 == num)
				{
				}
				num = (short)661323776;
				short num3 = num;
				num = (short)1422196736;
				if (num != 0)
				{
				}
				num = (short)383778817;
				if (num != 0)
				{
				}
				return this.mcGeofenceEntryAction_42887.Applicable;
			}
			set
			{
				short num = (short)1098814518;
				short num2 = num;
				num = (short)415470646;
				switch (num2 == num)
				{
				}
				num = (short)2014052352;
				short num3 = num;
				num = (short)285540353;
				if (num != 0)
				{
				}
				num = (short)1300627456;
				if (num != 0)
				{
				}
				this.mcGeofenceEntryAction_42887.Applicable = value;
			}
		}

		// Token: 0x17003934 RID: 14644
		// (get) Token: 0x06006EA4 RID: 28324 RVA: 0x00629814 File Offset: 0x00627A14
		// (set) Token: 0x06006EA5 RID: 28325 RVA: 0x006298C8 File Offset: 0x00627AC8
		public bool McGeofenceEntryAction_42887_Valid
		{
			get
			{
				short num = (short)1798086096;
				short num2 = num;
				num = (short)817536464;
				switch (num2 == num)
				{
				}
				num = (short)2079129600;
				short num3 = num;
				num = (short)171180032;
				if (num != 0)
				{
				}
				num = (short)1241776129;
				if (num != 0)
				{
				}
				return this.mcGeofenceEntryAction_42887.Valid;
			}
			set
			{
				short num = (short)940159488;
				short num2 = num;
				num = (short)1621930496;
				switch (num2 == num)
				{
				}
				num = (short)1735327744;
				short num3 = num;
				num = (short)1038548993;
				if (num != 0)
				{
				}
				num = (short)1951465472;
				if (num != 0)
				{
				}
				this.mcGeofenceEntryAction_42887.Valid = value;
			}
		}

		// Token: 0x17003935 RID: 14645
		// (get) Token: 0x06006EA6 RID: 28326 RVA: 0x0062997C File Offset: 0x00627B7C
		// (set) Token: 0x06006EA7 RID: 28327 RVA: 0x00629A30 File Offset: 0x00627C30
		public bool McGeofenceEntryAction_42887_Visible
		{
			get
			{
				short num = (short)141065265;
				short num2 = num;
				num = (short)1997569073;
				switch (num2 == num)
				{
				}
				num = (short)1954873344;
				short num3 = num;
				num = (short)2146500609;
				if (num != 0)
				{
				}
				num = (short)534380544;
				if (num != 0)
				{
				}
				return this.mcGeofenceEntryAction_42887.Visible;
			}
			set
			{
				short num = (short)1284753365;
				short num2 = num;
				num = (short)104253397;
				switch (num2 == num)
				{
				}
				num = (short)915931136;
				short num3 = num;
				num = (short)400162816;
				if (num != 0)
				{
				}
				num = (short)453967873;
				if (num != 0)
				{
				}
				this.mcGeofenceEntryAction_42887.Visible = value;
			}
		}

		// Token: 0x17003936 RID: 14646
		// (get) Token: 0x06006EA8 RID: 28328 RVA: 0x00629AE8 File Offset: 0x00627CE8
		// (set) Token: 0x06006EA9 RID: 28329 RVA: 0x00629B9C File Offset: 0x00627D9C
		public bool McGeofenceEntryAction_42887_Editable
		{
			get
			{
				short num = (short)1940687268;
				short num2 = num;
				num = (short)951814564;
				switch (num2 == num)
				{
				}
				num = (short)1632567296;
				short num3 = num;
				num = (short)1314455552;
				if (num != 0)
				{
				}
				num = (short)356450305;
				if (num != 0)
				{
				}
				return this.mcGeofenceEntryAction_42887.Editable;
			}
			set
			{
				short num = (short)1722446321;
				short num2 = num;
				num = (short)1007186417;
				switch (num2 == num)
				{
				}
				num = (short)622002176;
				short num3 = num;
				num = (short)686948353;
				if (num != 0)
				{
				}
				num = (short)1817378816;
				if (num != 0)
				{
				}
				this.mcGeofenceEntryAction_42887.Editable = value;
			}
		}

		// Token: 0x17003937 RID: 14647
		// (get) Token: 0x06006EAA RID: 28330 RVA: 0x00629C50 File Offset: 0x00627E50
		internal string McGeofenceEntryAction_42887_UILabel
		{
			get
			{
				short num = (short)1821771357;
				short num2 = num;
				num = (short)1050205;
				switch (num2 == num)
				{
				}
				num = (short)1756299264;
				short num3 = num;
				num = (short)629669889;
				if (num != 0)
				{
				}
				num = (short)1131413504;
				if (num != 0)
				{
				}
				return this.mcGeofenceEntryAction_42887.UIName;
			}
		}

		// Token: 0x17003938 RID: 14648
		// (get) Token: 0x06006EAB RID: 28331 RVA: 0x00629D04 File Offset: 0x00627F04
		// (set) Token: 0x06006EAC RID: 28332 RVA: 0x00629DBC File Offset: 0x00627FBC
		internal bool McGeofenceEntryAction_42887_HiddenStatic
		{
			get
			{
				short num = (short)459931649;
				if (num != 0)
				{
				}
				num = (short)1598439262;
				short num2 = num;
				num = (short)1913798494;
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
				num = (short)2003632128;
				if (num != 0)
				{
				}
				return this.mcGeofenceEntryAction_42887.HiddenStatic;
			}
			set
			{
				short num = (short)866631566;
				short num2 = num;
				num = (short)201834382;
				switch (num2 == num)
				{
				}
				num = (short)266141696;
				short num3 = num;
				num = (short)1614741504;
				if (num != 0)
				{
				}
				num = (short)159186945;
				if (num != 0)
				{
				}
				this.mcGeofenceEntryAction_42887.HiddenStatic = value;
			}
		}

		// Token: 0x17003939 RID: 14649
		// (get) Token: 0x06006EAD RID: 28333 RVA: 0x00629E74 File Offset: 0x00628074
		// (set) Token: 0x06006EAE RID: 28334 RVA: 0x00629F24 File Offset: 0x00628124
		internal bool McGeofenceEntryAction_42887_HiddenDynamic
		{
			get
			{
				short num = (short)712612387;
				short num2 = num;
				num = (short)346200611;
				switch (num2 == num)
				{
				}
				num = (short)209584128;
				short num3 = num;
				num = (short)387252224;
				if (num != 0)
				{
				}
				num = (short)1995964417;
				if (num != 0)
				{
				}
				return this.mcGeofenceEntryAction_42887.HiddenDynamic;
			}
			set
			{
				short num = (short)1497235457;
				if (num != 0)
				{
				}
				num = (short)1419890128;
				short num2 = num;
				num = (short)1245367760;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1525481472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)461111296;
				if (num != 0)
				{
				}
				this.mcGeofenceEntryAction_42887.HiddenDynamic = value;
			}
		}

		// Token: 0x1700393A RID: 14650
		// (get) Token: 0x06006EAF RID: 28335 RVA: 0x00629FDC File Offset: 0x006281DC
		public bool McGeofenceEntryAction_42887_HasDiffs
		{
			get
			{
				short num = (short)542810951;
				short num2 = num;
				num = (short)2089657159;
				switch (num2 == num)
				{
				}
				num = (short)126812160;
				short num3 = num;
				num = (short)813105153;
				if (num != 0)
				{
				}
				num = (short)352190464;
				if (num != 0)
				{
				}
				return this.mcGeofenceEntryAction_42887._HasDiffs;
			}
		}

		// Token: 0x1700393B RID: 14651
		// (get) Token: 0x06006EB0 RID: 28336 RVA: 0x0062A094 File Offset: 0x00628294
		// (set) Token: 0x06006EB1 RID: 28337 RVA: 0x0062A148 File Offset: 0x00628348
		public int McGeofenceExitAction_42888Value
		{
			get
			{
				short num = (short)1503784955;
				short num2 = num;
				num = (short)1450176507;
				switch (num2 == num)
				{
				}
				num = (short)45678592;
				short num3 = num;
				num = (short)1774780417;
				if (num != 0)
				{
				}
				num = (short)1250033664;
				if (num != 0)
				{
				}
				return this.mcGeofenceExitAction_42888.Value;
			}
			set
			{
				short num = (short)1851416574;
				short num2 = num;
				num = (short)1884839934;
				switch (num2 == num)
				{
				}
				num = (short)1845821440;
				short num3 = num;
				num = (short)623837184;
				if (num != 0)
				{
				}
				num = (short)1443954689;
				if (num != 0)
				{
				}
				this.mcGeofenceExitAction_42888.Value = value;
			}
		}

		// Token: 0x1700393C RID: 14652
		// (get) Token: 0x06006EB2 RID: 28338 RVA: 0x0062A1FC File Offset: 0x006283FC
		// (set) Token: 0x06006EB3 RID: 28339 RVA: 0x0062A2B0 File Offset: 0x006284B0
		public string McGeofenceExitAction_42888_UIValue
		{
			get
			{
				short num = (short)346179293;
				short num2 = num;
				num = (short)115820253;
				switch (num2 == num)
				{
				}
				num = (short)1693450240;
				short num3 = num;
				num = (short)713490433;
				if (num != 0)
				{
				}
				num = (short)1797193728;
				if (num != 0)
				{
				}
				return this.mcGeofenceExitAction_42888.UIValue;
			}
			set
			{
				short num = (short)2015058998;
				short num2 = num;
				num = (short)166419510;
				switch (num2 == num)
				{
				}
				num = (short)1503526912;
				short num3 = num;
				num = (short)514850816;
				if (num != 0)
				{
				}
				num = (short)1784938497;
				if (num != 0)
				{
				}
				this.mcGeofenceExitAction_42888.UIValue = value;
			}
		}

		// Token: 0x1700393D RID: 14653
		// (get) Token: 0x06006EB4 RID: 28340 RVA: 0x0062A364 File Offset: 0x00628564
		public global::AcpBusinessLayer.AcpRecRefField McGeofenceExitAction_42888
		{
			get
			{
				short num = (short)999547022;
				short num2 = num;
				num = (short)236839054;
				switch (num2 == num)
				{
				}
				num = (short)486014976;
				short num3 = num;
				num = (short)2016804865;
				if (num != 0)
				{
				}
				num = (short)1121255424;
				if (num != 0)
				{
				}
				return this.mcGeofenceExitAction_42888;
			}
		}

		// Token: 0x1700393E RID: 14654
		// (get) Token: 0x06006EB5 RID: 28341 RVA: 0x0062A414 File Offset: 0x00628614
		// (set) Token: 0x06006EB6 RID: 28342 RVA: 0x0062A4CC File Offset: 0x006286CC
		public bool McGeofenceExitAction_42888_Applicable
		{
			get
			{
				short num = (short)45005452;
				short num2 = num;
				num = (short)1904917132;
				switch (num2 == num)
				{
				}
				num = (short)973406208;
				short num3 = num;
				num = (short)535363585;
				if (num != 0)
				{
				}
				num = (short)2102001664;
				if (num != 0)
				{
				}
				return this.mcGeofenceExitAction_42888.Applicable;
			}
			set
			{
				short num = (short)1155890071;
				short num2 = num;
				num = (short)837712791;
				switch (num2 == num)
				{
				}
				num = (short)1938554880;
				short num3 = num;
				num = (short)709689345;
				if (num != 0)
				{
				}
				num = (short)1963130880;
				if (num != 0)
				{
				}
				this.mcGeofenceExitAction_42888.Applicable = value;
			}
		}

		// Token: 0x1700393F RID: 14655
		// (get) Token: 0x06006EB7 RID: 28343 RVA: 0x0062A580 File Offset: 0x00628780
		// (set) Token: 0x06006EB8 RID: 28344 RVA: 0x0062A638 File Offset: 0x00628838
		public bool McGeofenceExitAction_42888_Valid
		{
			get
			{
				short num = (short)729369526;
				short num2 = num;
				num = (short)1908755382;
				switch (num2 == num)
				{
				}
				num = (short)172687360;
				short num3 = num;
				num = (short)608370688;
				if (num != 0)
				{
				}
				num = (short)1540751361;
				if (num != 0)
				{
				}
				return this.mcGeofenceExitAction_42888.Valid;
			}
			set
			{
				short num = (short)238592277;
				short num2 = num;
				num = (short)1354014997;
				switch (num2 == num)
				{
				}
				num = (short)490668032;
				short num3 = num;
				num = (short)1271005184;
				if (num != 0)
				{
				}
				num = (short)1429274625;
				if (num != 0)
				{
				}
				this.mcGeofenceExitAction_42888.Valid = value;
			}
		}

		// Token: 0x17003940 RID: 14656
		// (get) Token: 0x06006EB9 RID: 28345 RVA: 0x0062A6EC File Offset: 0x006288EC
		// (set) Token: 0x06006EBA RID: 28346 RVA: 0x0062A7A0 File Offset: 0x006289A0
		public bool McGeofenceExitAction_42888_Visible
		{
			get
			{
				short num = (short)546373633;
				if (num != 0)
				{
				}
				num = (short)1916946453;
				short num2 = num;
				num = (short)2043889685;
				switch (num2 == num)
				{
				default:
				{
					num = (short)347930624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)209190912;
				if (num != 0)
				{
				}
				return this.mcGeofenceExitAction_42888.Visible;
			}
			set
			{
				short num = (short)1843789825;
				if (num != 0)
				{
				}
				num = (short)207382799;
				short num2 = num;
				num = (short)311519503;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1391394816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1493172224;
				if (num != 0)
				{
				}
				this.mcGeofenceExitAction_42888.Visible = value;
			}
		}

		// Token: 0x17003941 RID: 14657
		// (get) Token: 0x06006EBB RID: 28347 RVA: 0x0062A854 File Offset: 0x00628A54
		// (set) Token: 0x06006EBC RID: 28348 RVA: 0x0062A908 File Offset: 0x00628B08
		public bool McGeofenceExitAction_42888_Editable
		{
			get
			{
				short num = (short)1877598785;
				short num2 = num;
				num = (short)1689641537;
				switch (num2 == num)
				{
				}
				num = (short)1168179200;
				short num3 = num;
				num = (short)270860289;
				if (num != 0)
				{
				}
				num = (short)853213184;
				if (num != 0)
				{
				}
				return this.mcGeofenceExitAction_42888.Editable;
			}
			set
			{
				short num = (short)2103170079;
				short num2 = num;
				num = (short)1813697567;
				switch (num2 == num)
				{
				}
				num = (short)1900806144;
				short num3 = num;
				num = (short)154009601;
				if (num != 0)
				{
				}
				num = (short)2126512128;
				if (num != 0)
				{
				}
				this.mcGeofenceExitAction_42888.Editable = value;
			}
		}

		// Token: 0x17003942 RID: 14658
		// (get) Token: 0x06006EBD RID: 28349 RVA: 0x0062A9C0 File Offset: 0x00628BC0
		internal string McGeofenceExitAction_42888_UILabel
		{
			get
			{
				short num = (short)1097130440;
				short num2 = num;
				num = (short)665117128;
				switch (num2 == num)
				{
				}
				num = (short)1437270016;
				short num3 = num;
				num = (short)461570049;
				if (num != 0)
				{
				}
				num = (short)767492096;
				if (num != 0)
				{
				}
				return this.mcGeofenceExitAction_42888.UIName;
			}
		}

		// Token: 0x17003943 RID: 14659
		// (get) Token: 0x06006EBE RID: 28350 RVA: 0x0062AA78 File Offset: 0x00628C78
		// (set) Token: 0x06006EBF RID: 28351 RVA: 0x0062AB30 File Offset: 0x00628D30
		internal bool McGeofenceExitAction_42888_HiddenStatic
		{
			get
			{
				short num = (short)1195160565;
				short num2 = num;
				num = (short)1131590645;
				switch (num2 == num)
				{
				}
				num = (short)982843392;
				short num3 = num;
				num = (short)766377984;
				if (num != 0)
				{
				}
				num = (short)746323969;
				if (num != 0)
				{
				}
				return this.mcGeofenceExitAction_42888.HiddenStatic;
			}
			set
			{
				short num = (short)1656490415;
				short num2 = num;
				num = (short)2006387119;
				switch (num2 == num)
				{
				}
				num = (short)2001534976;
				short num3 = num;
				num = (short)105185280;
				if (num != 0)
				{
				}
				num = (short)794361857;
				if (num != 0)
				{
				}
				this.mcGeofenceExitAction_42888.HiddenStatic = value;
			}
		}

		// Token: 0x17003944 RID: 14660
		// (get) Token: 0x06006EC0 RID: 28352 RVA: 0x0062ABE4 File Offset: 0x00628DE4
		// (set) Token: 0x06006EC1 RID: 28353 RVA: 0x0062AC9C File Offset: 0x00628E9C
		internal bool McGeofenceExitAction_42888_HiddenDynamic
		{
			get
			{
				short num = (short)1077406920;
				short num2 = num;
				num = (short)1579150536;
				switch (num2 == num)
				{
				}
				num = (short)99876864;
				short num3 = num;
				num = (short)16646145;
				if (num != 0)
				{
				}
				num = (short)1569259520;
				if (num != 0)
				{
				}
				return this.mcGeofenceExitAction_42888.HiddenDynamic;
			}
			set
			{
				short num = (short)919797761;
				if (num != 0)
				{
				}
				num = (short)762125723;
				short num2 = num;
				num = (short)335093147;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1847066624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1545273344;
				if (num != 0)
				{
				}
				this.mcGeofenceExitAction_42888.HiddenDynamic = value;
			}
		}

		// Token: 0x17003945 RID: 14661
		// (get) Token: 0x06006EC2 RID: 28354 RVA: 0x0062AD50 File Offset: 0x00628F50
		public bool McGeofenceExitAction_42888_HasDiffs
		{
			get
			{
				short num = (short)508887041;
				if (num != 0)
				{
				}
				num = (short)1434990728;
				short num2 = num;
				num = (short)610744456;
				switch (num2 == num)
				{
				default:
				{
					num = (short)551419904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)577306624;
				if (num != 0)
				{
				}
				return this.mcGeofenceExitAction_42888._HasDiffs;
			}
		}

		// Token: 0x17003946 RID: 14662
		// (get) Token: 0x06006EC3 RID: 28355 RVA: 0x0062AE08 File Offset: 0x00629008
		// (set) Token: 0x06006EC4 RID: 28356 RVA: 0x0062AEBC File Offset: 0x006290BC
		public int McGeofenceRadiusInMeters_42890Value
		{
			get
			{
				short num = (short)31326222;
				short num2 = num;
				num = (short)1033764878;
				switch (num2 == num)
				{
				}
				num = (short)282525696;
				short num3 = num;
				num = (short)1640038400;
				if (num != 0)
				{
				}
				num = (short)1259601921;
				if (num != 0)
				{
				}
				return this.mcGeofenceRadiusInMeters_42890.Value;
			}
			set
			{
				short num = (short)1019486522;
				short num2 = num;
				num = (short)1937383738;
				switch (num2 == num)
				{
				}
				num = (short)1079705600;
				short num3 = num;
				num = (short)625999873;
				if (num != 0)
				{
				}
				num = (short)1470300160;
				if (num != 0)
				{
				}
				this.mcGeofenceRadiusInMeters_42890.Value = value;
			}
		}

		// Token: 0x17003947 RID: 14663
		// (get) Token: 0x06006EC5 RID: 28357 RVA: 0x0062AF70 File Offset: 0x00629170
		public global::AcpBusinessLayer.AcpCustomRangeField McGeofenceRadiusInMeters_42890
		{
			get
			{
				short num = (short)852322190;
				short num2 = num;
				num = (short)1074620302;
				switch (num2 == num)
				{
				}
				num = (short)1673330688;
				if (num != 0)
				{
				}
				num = (short)86179840;
				short num3 = num;
				num = (short)1105985537;
				if (num != 0)
				{
				}
				return this.mcGeofenceRadiusInMeters_42890;
			}
		}

		// Token: 0x17003948 RID: 14664
		// (get) Token: 0x06006EC6 RID: 28358 RVA: 0x0062B020 File Offset: 0x00629220
		// (set) Token: 0x06006EC7 RID: 28359 RVA: 0x0062B0D4 File Offset: 0x006292D4
		public string McGeofenceRadiusInMeters_42890_UIValue
		{
			get
			{
				short num = (short)736391983;
				short num2 = num;
				num = (short)1231778607;
				switch (num2 == num)
				{
				}
				num = (short)1256914945;
				if (num != 0)
				{
				}
				num = (short)1273430016;
				short num3 = num;
				num = (short)1198522368;
				if (num != 0)
				{
				}
				return this.mcGeofenceRadiusInMeters_42890.UIValue;
			}
			set
			{
				short num = (short)278909769;
				short num2 = num;
				num = (short)1275843401;
				switch (num2 == num)
				{
				}
				num = (short)1352269825;
				if (num != 0)
				{
				}
				num = (short)1622736896;
				short num3 = num;
				num = (short)1900544;
				if (num != 0)
				{
				}
				this.mcGeofenceRadiusInMeters_42890.UIValue = value;
			}
		}

		// Token: 0x17003949 RID: 14665
		// (get) Token: 0x06006EC8 RID: 28360 RVA: 0x0062B188 File Offset: 0x00629388
		// (set) Token: 0x06006EC9 RID: 28361 RVA: 0x0062B240 File Offset: 0x00629440
		internal int McGeofenceRadiusInMeters_42890Min
		{
			get
			{
				short num = (short)990516843;
				short num2 = num;
				num = (short)1032787563;
				switch (num2 == num)
				{
				}
				num = (short)575078401;
				if (num != 0)
				{
				}
				num = (short)727318528;
				short num3 = num;
				num = (short)1236467712;
				if (num != 0)
				{
				}
				return this.mcGeofenceRadiusInMeters_42890.Min;
			}
			set
			{
				short num = (short)1781244765;
				short num2 = num;
				num = (short)1049273181;
				switch (num2 == num)
				{
				}
				num = (short)1628372993;
				if (num != 0)
				{
				}
				num = (short)1195704320;
				short num3 = num;
				num = (short)1533280256;
				if (num != 0)
				{
				}
				this.mcGeofenceRadiusInMeters_42890.Min = value;
			}
		}

		// Token: 0x1700394A RID: 14666
		// (get) Token: 0x06006ECA RID: 28362 RVA: 0x0062B2F8 File Offset: 0x006294F8
		// (set) Token: 0x06006ECB RID: 28363 RVA: 0x0062B3AC File Offset: 0x006295AC
		internal int McGeofenceRadiusInMeters_42890Max
		{
			get
			{
				short num = (short)2121287673;
				short num2 = num;
				num = (short)356206585;
				switch (num2 == num)
				{
				}
				num = (short)2069626881;
				if (num != 0)
				{
				}
				num = (short)134545408;
				short num3 = num;
				num = (short)497418240;
				if (num != 0)
				{
				}
				return this.mcGeofenceRadiusInMeters_42890.Max;
			}
			set
			{
				short num = (short)1418012158;
				short num2 = num;
				num = (short)566502910;
				switch (num2 == num)
				{
				}
				num = (short)975962113;
				if (num != 0)
				{
				}
				num = (short)334692352;
				short num3 = num;
				num = (short)825032704;
				if (num != 0)
				{
				}
				this.mcGeofenceRadiusInMeters_42890.Max = value;
			}
		}

		// Token: 0x1700394B RID: 14667
		// (get) Token: 0x06006ECC RID: 28364 RVA: 0x0062B460 File Offset: 0x00629660
		// (set) Token: 0x06006ECD RID: 28365 RVA: 0x0062B514 File Offset: 0x00629714
		internal int McGeofenceRadiusInMeters_42890Step
		{
			get
			{
				short num = (short)1771110401;
				if (num != 0)
				{
				}
				num = (short)1159316585;
				short num2 = num;
				num = (short)429442153;
				switch (num2 == num)
				{
				}
				num = (short)720240640;
				short num3 = num;
				num = (short)856555520;
				if (num != 0)
				{
				}
				return this.mcGeofenceRadiusInMeters_42890.StepSize;
			}
			set
			{
				short num = (short)233061483;
				short num2 = num;
				num = (short)337132651;
				switch (num2 == num)
				{
				}
				num = (short)382402561;
				if (num != 0)
				{
				}
				num = (short)1208156160;
				short num3 = num;
				num = (short)963772416;
				if (num != 0)
				{
				}
				this.mcGeofenceRadiusInMeters_42890.StepSize = value;
			}
		}

		// Token: 0x1700394C RID: 14668
		// (get) Token: 0x06006ECE RID: 28366 RVA: 0x0062B5C8 File Offset: 0x006297C8
		// (set) Token: 0x06006ECF RID: 28367 RVA: 0x0062B67C File Offset: 0x0062987C
		public bool McGeofenceRadiusInMeters_42890_Applicable
		{
			get
			{
				short num = (short)11428075;
				short num2 = num;
				num = (short)110321899;
				switch (num2 == num)
				{
				}
				num = (short)2088763393;
				if (num != 0)
				{
				}
				num = (short)1545994240;
				short num3 = num;
				num = (short)395575296;
				if (num != 0)
				{
				}
				return this.mcGeofenceRadiusInMeters_42890.Applicable;
			}
			set
			{
				short num = (short)1808465921;
				if (num != 0)
				{
				}
				num = (short)106530119;
				short num2 = num;
				num = (short)812418375;
				switch (num2 == num)
				{
				}
				num = (short)1202257920;
				short num3 = num;
				num = (short)1445855232;
				if (num != 0)
				{
				}
				this.mcGeofenceRadiusInMeters_42890.Applicable = value;
			}
		}

		// Token: 0x1700394D RID: 14669
		// (get) Token: 0x06006ED0 RID: 28368 RVA: 0x0062B730 File Offset: 0x00629930
		// (set) Token: 0x06006ED1 RID: 28369 RVA: 0x0062B7E0 File Offset: 0x006299E0
		public bool McGeofenceRadiusInMeters_42890_Valid
		{
			get
			{
				short num = (short)46068962;
				short num2 = num;
				num = (short)1797846242;
				switch (num2 == num)
				{
				}
				num = (short)1702363137;
				if (num != 0)
				{
				}
				num = (short)396099584;
				short num3 = num;
				num = (short)1896808448;
				if (num != 0)
				{
				}
				return this.mcGeofenceRadiusInMeters_42890.Valid;
			}
			set
			{
				short num = (short)1536578797;
				short num2 = num;
				num = (short)875844845;
				switch (num2 == num)
				{
				}
				num = (short)818872321;
				if (num != 0)
				{
				}
				num = (short)950730752;
				short num3 = num;
				num = (short)1231486976;
				if (num != 0)
				{
				}
				this.mcGeofenceRadiusInMeters_42890.Valid = value;
			}
		}

		// Token: 0x1700394E RID: 14670
		// (get) Token: 0x06006ED2 RID: 28370 RVA: 0x0062B894 File Offset: 0x00629A94
		// (set) Token: 0x06006ED3 RID: 28371 RVA: 0x0062B948 File Offset: 0x00629B48
		public bool McGeofenceRadiusInMeters_42890_Visible
		{
			get
			{
				short num = (short)107849808;
				short num2 = num;
				num = (short)177449040;
				switch (num2 == num)
				{
				}
				num = (short)1666449409;
				if (num != 0)
				{
				}
				num = (short)1431175168;
				short num3 = num;
				num = (short)595722240;
				if (num != 0)
				{
				}
				return this.mcGeofenceRadiusInMeters_42890.Visible;
			}
			set
			{
				short num = (short)1732247553;
				if (num != 0)
				{
				}
				num = (short)936300845;
				short num2 = num;
				num = (short)387371309;
				switch (num2 == num)
				{
				}
				num = (short)1607204864;
				short num3 = num;
				num = (short)1385562112;
				if (num != 0)
				{
				}
				this.mcGeofenceRadiusInMeters_42890.Visible = value;
			}
		}

		// Token: 0x1700394F RID: 14671
		// (get) Token: 0x06006ED4 RID: 28372 RVA: 0x0062B9FC File Offset: 0x00629BFC
		// (set) Token: 0x06006ED5 RID: 28373 RVA: 0x0062BAB4 File Offset: 0x00629CB4
		public bool McGeofenceRadiusInMeters_42890_Editable
		{
			get
			{
				short num = (short)713693529;
				short num2 = num;
				num = (short)576526681;
				switch (num2 == num)
				{
				}
				num = (short)761528320;
				if (num != 0)
				{
				}
				num = (short)367460352;
				short num3 = num;
				num = (short)300744705;
				if (num != 0)
				{
				}
				return this.mcGeofenceRadiusInMeters_42890.Editable;
			}
			set
			{
				short num = (short)1108230260;
				short num2 = num;
				num = (short)1702379636;
				switch (num2 == num)
				{
				}
				num = (short)277807105;
				if (num != 0)
				{
				}
				num = (short)1931870208;
				short num3 = num;
				num = (short)793182208;
				if (num != 0)
				{
				}
				this.mcGeofenceRadiusInMeters_42890.Editable = value;
			}
		}

		// Token: 0x17003950 RID: 14672
		// (get) Token: 0x06006ED6 RID: 28374 RVA: 0x0062BB6C File Offset: 0x00629D6C
		internal string McGeofenceRadiusInMeters_42890_UILabel
		{
			get
			{
				short num = (short)61161775;
				short num2 = num;
				num = (short)1530282287;
				switch (num2 == num)
				{
				}
				num = (short)430833665;
				if (num != 0)
				{
				}
				num = (short)1710751744;
				short num3 = num;
				num = (short)981008384;
				if (num != 0)
				{
				}
				return this.mcGeofenceRadiusInMeters_42890.UIName;
			}
		}

		// Token: 0x17003951 RID: 14673
		// (get) Token: 0x06006ED7 RID: 28375 RVA: 0x0062BC20 File Offset: 0x00629E20
		// (set) Token: 0x06006ED8 RID: 28376 RVA: 0x0062BCD4 File Offset: 0x00629ED4
		internal bool McGeofenceRadiusInMeters_42890_HiddenStatic
		{
			get
			{
				short num = (short)2028293170;
				short num2 = num;
				num = (short)694701106;
				switch (num2 == num)
				{
				}
				num = (short)850460673;
				if (num != 0)
				{
				}
				num = (short)468189184;
				short num3 = num;
				num = (short)166854656;
				if (num != 0)
				{
				}
				return this.mcGeofenceRadiusInMeters_42890.HiddenStatic;
			}
			set
			{
				short num = (short)1407868811;
				short num2 = num;
				num = (short)2007523211;
				switch (num2 == num)
				{
				}
				num = (short)1399259137;
				if (num != 0)
				{
				}
				num = (short)1838546944;
				short num3 = num;
				num = (short)137035776;
				if (num != 0)
				{
				}
				this.mcGeofenceRadiusInMeters_42890.HiddenStatic = value;
			}
		}

		// Token: 0x17003952 RID: 14674
		// (get) Token: 0x06006ED9 RID: 28377 RVA: 0x0062BD8C File Offset: 0x00629F8C
		// (set) Token: 0x06006EDA RID: 28378 RVA: 0x0062BE40 File Offset: 0x0062A040
		internal bool McGeofenceRadiusInMeters_42890_HiddenDynamic
		{
			get
			{
				short num = (short)979107841;
				if (num != 0)
				{
				}
				num = (short)1459228455;
				short num2 = num;
				num = (short)644353831;
				switch (num2 == num)
				{
				}
				num = (short)147980288;
				short num3 = num;
				num = (short)1633550336;
				if (num != 0)
				{
				}
				return this.mcGeofenceRadiusInMeters_42890.HiddenDynamic;
			}
			set
			{
				short num = (short)2123821856;
				short num2 = num;
				num = (short)783479584;
				switch (num2 == num)
				{
				}
				num = (short)470876161;
				if (num != 0)
				{
				}
				num = (short)1779892224;
				short num3 = num;
				num = (short)1957822464;
				if (num != 0)
				{
				}
				this.mcGeofenceRadiusInMeters_42890.HiddenDynamic = value;
			}
		}

		// Token: 0x17003953 RID: 14675
		// (get) Token: 0x06006EDB RID: 28379 RVA: 0x0062BEF4 File Offset: 0x0062A0F4
		public bool McGeofenceRadiusInMeters_42890_HasDiffs
		{
			get
			{
				short num = (short)652432827;
				short num2 = num;
				num = (short)607016379;
				switch (num2 == num)
				{
				}
				num = (short)1774125057;
				if (num != 0)
				{
				}
				num = (short)1027407872;
				short num3 = num;
				num = (short)1004732416;
				if (num != 0)
				{
				}
				return this.mcGeofenceRadiusInMeters_42890._HasDiffs;
			}
		}

		// Token: 0x17003954 RID: 14676
		// (get) Token: 0x06006EDC RID: 28380 RVA: 0x0062BFA8 File Offset: 0x0062A1A8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1169443057;
				short num2 = num;
				num = (short)1447053553;
				switch (num2 == num)
				{
				}
				num = (short)397737985;
				if (num != 0)
				{
				}
				num = (short)551354368;
				short num3 = num;
				num = (short)1262223360;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06006EDD RID: 28381 RVA: 0x0062C06C File Offset: 0x0062A26C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_9B;
			}
			short num;
			int num4;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)236165616;
				short num2 = num;
				num = (short)1256036848;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_107;
				case 1:
					break;
				default:
				{
					num = (short)304218112;
					short num3 = num;
					break;
				}
				}
				num = (short)293142528;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					num = (short)1693515777;
					if (num != 0)
					{
					}
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1235288068;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 1:
					if (base.ParentRecset != null)
					{
						num = (short)1003683843;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					return result;
				case 3:
					goto IL_107;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)850657282;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_9B;
				IL_107:
				num = (short)1206845440;
				num4 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_9B:
			result = null;
			num = (short)1746272257;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04002AEB RID: 10987
		private global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset innerRecset;

		// Token: 0x04002AEC RID: 10988
		private global::AcpBusinessLayer.AcpKeyField geofenceAliasName_42867;

		// Token: 0x04002AED RID: 10989
		private global::AcpBusinessLayer.AcpSimpleRangeField mcGeofencePriority_42879;

		// Token: 0x04002AEE RID: 10990
		private global::AcpBusinessLayer.AcpRecRefField mcGeofenceEntryAction_42887;

		// Token: 0x04002AEF RID: 10991
		private global::AcpBusinessLayer.AcpRecRefField mcGeofenceExitAction_42888;

		// Token: 0x04002AF0 RID: 10992
		private global::AcpBusinessLayer.AcpCustomRangeField mcGeofenceRadiusInMeters_42890;
	}
}
