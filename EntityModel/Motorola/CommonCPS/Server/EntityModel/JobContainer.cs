using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200003F RID: 63
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.ReadWriteJobContainer))]
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.BatchOperationJobContainer))]
	[global::System.Serializable]
	public class JobContainer : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x06000593 RID: 1427 RVA: 0x0003F06C File Offset: 0x0003D26C
		public JobContainer()
		{
			this.Jobs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Job>();
			this.IsMigrationJob = false;
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x0003F094 File Offset: 0x0003D294
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x0003F144 File Offset: 0x0003D344
		[global::System.Runtime.Serialization.DataMember]
		public string JobName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1450739802;
				short num2 = num;
				num = (short)1876592730;
				switch (num2 == num)
				{
				}
				num = (short)656211968;
				if (num != 0)
				{
				}
				num = (short)536870912;
				short num3 = num;
				num = (short)1681850369;
				if (num != 0)
				{
				}
				return this.<JobName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)919868256;
				short num2 = num;
				num = (short)1888949088;
				switch (num2 == num)
				{
				}
				num = (short)424083457;
				if (num != 0)
				{
				}
				num = (short)1049690112;
				short num3 = num;
				num = (short)1563623424;
				if (num != 0)
				{
				}
				this.<JobName>k__BackingField = value;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x0003F1F4 File Offset: 0x0003D3F4
		// (set) Token: 0x06000597 RID: 1431 RVA: 0x0003F2A4 File Offset: 0x0003D4A4
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime? ScheduleStartDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)631294473;
				short num2 = num;
				num = (short)2104609289;
				switch (num2 == num)
				{
				}
				num = (short)1441988608;
				if (num != 0)
				{
				}
				num = (short)291110912;
				short num3 = num;
				num = (short)543817729;
				if (num != 0)
				{
				}
				return this.<ScheduleStartDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1906866348;
				short num2 = num;
				num = (short)1967028396;
				switch (num2 == num)
				{
				}
				num = (short)1639645185;
				if (num != 0)
				{
				}
				num = (short)1937113088;
				short num3 = num;
				num = (short)1940127744;
				if (num != 0)
				{
				}
				this.<ScheduleStartDate>k__BackingField = value;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x0003F354 File Offset: 0x0003D554
		// (set) Token: 0x06000599 RID: 1433 RVA: 0x0003F404 File Offset: 0x0003D604
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime? ScheduleEndDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)382205824;
				short num2 = num;
				num = (short)6553472;
				switch (num2 == num)
				{
				}
				num = (short)413728768;
				if (num != 0)
				{
				}
				num = (short)928972800;
				short num3 = num;
				num = (short)1522794497;
				if (num != 0)
				{
				}
				return this.<ScheduleEndDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)812793334;
				short num2 = num;
				num = (short)1857764854;
				switch (num2 == num)
				{
				}
				num = (short)969211904;
				if (num != 0)
				{
				}
				num = (short)429195264;
				short num3 = num;
				num = (short)792068097;
				if (num != 0)
				{
				}
				this.<ScheduleEndDate>k__BackingField = value;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x0003F4B8 File Offset: 0x0003D6B8
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x0003F568 File Offset: 0x0003D768
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobType JobType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)579155802;
				short num2 = num;
				num = (short)1146828634;
				switch (num2 == num)
				{
				}
				num = (short)1503985665;
				if (num != 0)
				{
				}
				num = (short)407830528;
				short num3 = num;
				num = (short)1054736384;
				if (num != 0)
				{
				}
				return this.<JobType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)445230970;
				short num2 = num;
				num = (short)1246605178;
				switch (num2 == num)
				{
				}
				num = (short)1024983040;
				if (num != 0)
				{
				}
				num = (short)614662144;
				short num3 = num;
				num = (short)1226506241;
				if (num != 0)
				{
				}
				this.<JobType>k__BackingField = value;
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x0003F618 File Offset: 0x0003D818
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x0003F6C4 File Offset: 0x0003D8C4
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime? CreateDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)405818074;
				short num2 = num;
				num = (short)1424509658;
				switch (num2 == num)
				{
				}
				num = (short)649920513;
				if (num != 0)
				{
				}
				num = (short)1383596032;
				short num3 = num;
				num = (short)1622081536;
				if (num != 0)
				{
				}
				return this.<CreateDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2129978843;
				short num2 = num;
				num = (short)777250267;
				switch (num2 == num)
				{
				}
				num = (short)1061355521;
				if (num != 0)
				{
				}
				num = (short)465240064;
				short num3 = num;
				num = (short)1838022656;
				if (num != 0)
				{
				}
				this.<CreateDate>k__BackingField = value;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x0003F774 File Offset: 0x0003D974
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x0003F824 File Offset: 0x0003DA24
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus JobContainerStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)646745102;
				short num2 = num;
				num = (short)635079694;
				switch (num2 == num)
				{
				}
				num = (short)490274817;
				if (num != 0)
				{
				}
				num = (short)1282736128;
				short num3 = num;
				num = (short)2139553792;
				if (num != 0)
				{
				}
				return this.<JobContainerStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)138432634;
				short num2 = num;
				num = (short)607146106;
				switch (num2 == num)
				{
				}
				num = (short)462880768;
				if (num != 0)
				{
				}
				num = (short)1894580224;
				short num3 = num;
				num = (short)2139226113;
				if (num != 0)
				{
				}
				this.<JobContainerStatus>k__BackingField = value;
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0003F8D8 File Offset: 0x0003DAD8
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x0003F988 File Offset: 0x0003DB88
		[global::System.Runtime.Serialization.DataMember]
		public int? JobsCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)994714056;
				short num2 = num;
				num = (short)932061640;
				switch (num2 == num)
				{
				}
				num = (short)535101440;
				if (num != 0)
				{
				}
				num = (short)1002700800;
				short num3 = num;
				num = (short)1705050113;
				if (num != 0)
				{
				}
				return this.<JobsCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)141117246;
				short num2 = num;
				num = (short)1587955518;
				switch (num2 == num)
				{
				}
				num = (short)543358977;
				if (num != 0)
				{
				}
				num = (short)798228480;
				short num3 = num;
				num = (short)1304428544;
				if (num != 0)
				{
				}
				this.<JobsCount>k__BackingField = value;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0003FA3C File Offset: 0x0003DC3C
		// (set) Token: 0x060005A3 RID: 1443 RVA: 0x0003FAEC File Offset: 0x0003DCEC
		[global::System.Runtime.Serialization.DataMember]
		public int? FinishedJobsCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)868910497;
				short num2 = num;
				num = (short)1333626273;
				switch (num2 == num)
				{
				}
				num = (short)1122631680;
				if (num != 0)
				{
				}
				num = (short)854523904;
				short num3 = num;
				num = (short)997064705;
				if (num != 0)
				{
				}
				return this.<FinishedJobsCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)779201975;
				short num2 = num;
				num = (short)1906224567;
				switch (num2 == num)
				{
				}
				num = (short)200998912;
				if (num != 0)
				{
				}
				num = (short)67960832;
				short num3 = num;
				num = (short)1288241153;
				if (num != 0)
				{
				}
				this.<FinishedJobsCount>k__BackingField = value;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060005A4 RID: 1444 RVA: 0x0003FB9C File Offset: 0x0003DD9C
		// (set) Token: 0x060005A5 RID: 1445 RVA: 0x0003FC48 File Offset: 0x0003DE48
		[global::System.Runtime.Serialization.DataMember]
		public int? FailedJobsCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1212366818;
				short num2 = num;
				num = (short)702889954;
				switch (num2 == num)
				{
				}
				num = (short)608043009;
				if (num != 0)
				{
				}
				num = (short)1181941760;
				short num3 = num;
				num = (short)1973551104;
				if (num != 0)
				{
				}
				return this.<FailedJobsCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)367601226;
				short num2 = num;
				num = (short)1063724618;
				switch (num2 == num)
				{
				}
				num = (short)1410400257;
				if (num != 0)
				{
				}
				num = (short)455999488;
				short num3 = num;
				num = (short)1631780864;
				if (num != 0)
				{
				}
				this.<FailedJobsCount>k__BackingField = value;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060005A6 RID: 1446 RVA: 0x0003FCFC File Offset: 0x0003DEFC
		// (set) Token: 0x060005A7 RID: 1447 RVA: 0x0003FDAC File Offset: 0x0003DFAC
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Job> Jobs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1969422337;
				if (num != 0)
				{
				}
				num = (short)1309785185;
				short num2 = num;
				num = (short)1927920737;
				switch (num2 == num)
				{
				}
				num = (short)290717696;
				short num3 = num;
				num = (short)173342720;
				if (num != 0)
				{
				}
				return this.<Jobs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1471443618;
				short num2 = num;
				num = (short)966226594;
				switch (num2 == num)
				{
				}
				num = (short)318832640;
				if (num != 0)
				{
				}
				num = (short)1998848000;
				short num3 = num;
				num = (short)579665921;
				if (num != 0)
				{
				}
				this.<Jobs>k__BackingField = value;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x0003FE5C File Offset: 0x0003E05C
		// (set) Token: 0x060005A9 RID: 1449 RVA: 0x0003FF0C File Offset: 0x0003E10C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier Pac
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)193276337;
				short num2 = num;
				num = (short)1715022257;
				switch (num2 == num)
				{
				}
				num = (short)146014208;
				if (num != 0)
				{
				}
				num = (short)1700331520;
				short num3 = num;
				num = (short)1840644097;
				if (num != 0)
				{
				}
				return this.<Pac>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1558183937;
				if (num != 0)
				{
				}
				num = (short)696643712;
				short num2 = num;
				num = (short)566816896;
				switch (num2 == num)
				{
				}
				num = (short)46596096;
				short num3 = num;
				num = (short)1999896576;
				if (num != 0)
				{
				}
				this.<Pac>k__BackingField = value;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060005AA RID: 1450 RVA: 0x0003FFBC File Offset: 0x0003E1BC
		// (set) Token: 0x060005AB RID: 1451 RVA: 0x0004006C File Offset: 0x0003E26C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode WorkMode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)864800567;
				short num2 = num;
				num = (short)2140458807;
				switch (num2 == num)
				{
				}
				num = (short)2059075585;
				if (num != 0)
				{
				}
				num = (short)597032960;
				short num3 = num;
				num = (short)1476984832;
				if (num != 0)
				{
				}
				return this.<WorkMode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1657554738;
				short num2 = num;
				num = (short)173754162;
				switch (num2 == num)
				{
				}
				num = (short)573505537;
				if (num != 0)
				{
				}
				num = (short)1423376384;
				short num3 = num;
				num = (short)1449852928;
				if (num != 0)
				{
				}
				this.<WorkMode>k__BackingField = value;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x0004011C File Offset: 0x0003E31C
		// (set) Token: 0x060005AD RID: 1453 RVA: 0x000401CC File Offset: 0x0003E3CC
		[global::System.Runtime.Serialization.DataMember]
		public bool IsMigrationJob
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1159171380;
				short num2 = num;
				num = (short)481332532;
				switch (num2 == num)
				{
				}
				num = (short)488439809;
				if (num != 0)
				{
				}
				num = (short)347013120;
				short num3 = num;
				num = (short)551485440;
				if (num != 0)
				{
				}
				return this.<IsMigrationJob>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1203641849;
				short num2 = num;
				num = (short)930749945;
				switch (num2 == num)
				{
				}
				num = (short)1124466689;
				if (num != 0)
				{
				}
				num = (short)1726545920;
				short num3 = num;
				num = (short)345899008;
				if (num != 0)
				{
				}
				this.<IsMigrationJob>k__BackingField = value;
			}
		}
	}
}
