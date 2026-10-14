using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000056 RID: 86
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class JobContainerSummary : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00047964 File Offset: 0x00045B64
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x00047A14 File Offset: 0x00045C14
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("JobName", typeof(global::Motorola.CommonCPS.Server.EntityModel.JobContainer))]
		public string JobName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)872172645;
				short num2 = num;
				num = (short)1250905189;
				switch (num2 == num)
				{
				}
				num = (short)1993408512;
				short num3 = num;
				num = (short)2109603841;
				if (num != 0)
				{
				}
				num = (short)392560640;
				if (num != 0)
				{
				}
				return this.<JobName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)523165280;
				short num2 = num;
				num = (short)35774048;
				switch (num2 == num)
				{
				}
				num = (short)2001207296;
				short num3 = num;
				num = (short)1145896961;
				if (num != 0)
				{
				}
				num = (short)2127888384;
				if (num != 0)
				{
				}
				this.<JobName>k__BackingField = value;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00047AC4 File Offset: 0x00045CC4
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00047B74 File Offset: 0x00045D74
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ScheduleStartDate", typeof(global::Motorola.CommonCPS.Server.EntityModel.JobContainer))]
		public global::System.DateTime? ScheduleStartDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)971479833;
				short num2 = num;
				num = (short)1729534745;
				switch (num2 == num)
				{
				}
				num = (short)823525376;
				short num3 = num;
				num = (short)888995840;
				if (num != 0)
				{
				}
				num = (short)1213923329;
				if (num != 0)
				{
				}
				return this.<ScheduleStartDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2046861733;
				short num2 = num;
				num = (short)1708106149;
				switch (num2 == num)
				{
				}
				num = (short)116719616;
				short num3 = num;
				num = (short)683409409;
				if (num != 0)
				{
				}
				num = (short)386990080;
				if (num != 0)
				{
				}
				this.<ScheduleStartDate>k__BackingField = value;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00047C24 File Offset: 0x00045E24
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00047CD4 File Offset: 0x00045ED4
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("ScheduleEndDate", typeof(global::Motorola.CommonCPS.Server.EntityModel.JobContainer))]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime? ScheduleEndDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)150250082;
				short num2 = num;
				num = (short)1946395234;
				switch (num2 == num)
				{
				}
				num = (short)1198718976;
				short num3 = num;
				num = (short)1433993217;
				if (num != 0)
				{
				}
				num = (short)1367801856;
				if (num != 0)
				{
				}
				return this.<ScheduleEndDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1322162381;
				short num2 = num;
				num = (short)571513037;
				switch (num2 == num)
				{
				}
				num = (short)753074176;
				short num3 = num;
				num = (short)877527041;
				if (num != 0)
				{
				}
				num = (short)668205056;
				if (num != 0)
				{
				}
				this.<ScheduleEndDate>k__BackingField = value;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00047D88 File Offset: 0x00045F88
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x00047E34 File Offset: 0x00046034
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("JobType", typeof(global::Motorola.CommonCPS.Server.EntityModel.JobContainer))]
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobType JobType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)947752298;
				short num2 = num;
				num = (short)1857523050;
				switch (num2 == num)
				{
				}
				num = (short)1002373120;
				short num3 = num;
				num = (short)1536884736;
				if (num != 0)
				{
				}
				num = (short)492830721;
				if (num != 0)
				{
				}
				return this.<JobType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)962520862;
				short num2 = num;
				num = (short)195815198;
				switch (num2 == num)
				{
				}
				num = (short)1764491264;
				short num3 = num;
				num = (short)1244266497;
				if (num != 0)
				{
				}
				num = (short)980484096;
				if (num != 0)
				{
				}
				this.<JobType>k__BackingField = value;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x00047EE4 File Offset: 0x000460E4
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00047F94 File Offset: 0x00046194
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("CreateDate", typeof(global::Motorola.CommonCPS.Server.EntityModel.JobContainer))]
		public global::System.DateTime CreateDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2146679460;
				short num2 = num;
				num = (short)1349696164;
				switch (num2 == num)
				{
				}
				num = (short)1466171392;
				short num3 = num;
				num = (short)1529675777;
				if (num != 0)
				{
				}
				num = (short)394592256;
				if (num != 0)
				{
				}
				return this.<CreateDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)648321588;
				short num2 = num;
				num = (short)790534708;
				switch (num2 == num)
				{
				}
				num = (short)1102905344;
				short num3 = num;
				num = (short)2134507521;
				if (num != 0)
				{
				}
				num = (short)373227520;
				if (num != 0)
				{
				}
				this.<CreateDate>k__BackingField = value;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00048044 File Offset: 0x00046244
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x000480F0 File Offset: 0x000462F0
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("JobContainerStatus", typeof(global::Motorola.CommonCPS.Server.EntityModel.JobContainer))]
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobContainerStatus JobContainerStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)998258486;
				short num2 = num;
				num = (short)905787190;
				switch (num2 == num)
				{
				}
				num = (short)126812160;
				short num3 = num;
				num = (short)1579220992;
				if (num != 0)
				{
				}
				num = (short)878837761;
				if (num != 0)
				{
				}
				return this.<JobContainerStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)945987860;
				short num2 = num;
				num = (short)704422164;
				switch (num2 == num)
				{
				}
				num = (short)45613056;
				short num3 = num;
				num = (short)1147142145;
				if (num != 0)
				{
				}
				num = (short)2134835200;
				if (num != 0)
				{
				}
				this.<JobContainerStatus>k__BackingField = value;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x000481A4 File Offset: 0x000463A4
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x00048250 File Offset: 0x00046450
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("JobsCount", typeof(global::Motorola.CommonCPS.Server.EntityModel.JobContainer))]
		public int? ItemsCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)557552023;
				short num2 = num;
				num = (short)1235915159;
				switch (num2 == num)
				{
				}
				num = (short)1869676544;
				short num3 = num;
				num = (short)155320321;
				if (num != 0)
				{
				}
				num = (short)1612054528;
				if (num != 0)
				{
				}
				return this.<ItemsCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1892367965;
				short num2 = num;
				num = (short)2024554077;
				switch (num2 == num)
				{
				}
				num = (short)2040004608;
				short num3 = num;
				num = (short)644808704;
				if (num != 0)
				{
				}
				num = (short)135135233;
				if (num != 0)
				{
				}
				this.<ItemsCount>k__BackingField = value;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x00048300 File Offset: 0x00046500
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x000483B4 File Offset: 0x000465B4
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("FinishedJobsCount", typeof(global::Motorola.CommonCPS.Server.EntityModel.JobContainer))]
		[global::System.Runtime.Serialization.DataMember]
		public int? FinishedJobsCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1252109898;
				short num2 = num;
				num = (short)1219735114;
				switch (num2 == num)
				{
				}
				num = (short)1614348288;
				short num3 = num;
				num = (short)800587777;
				if (num != 0)
				{
				}
				num = (short)1729495040;
				if (num != 0)
				{
				}
				return this.<FinishedJobsCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)269907755;
				short num2 = num;
				num = (short)1379694379;
				switch (num2 == num)
				{
				}
				num = (short)121896960;
				short num3 = num;
				num = (short)1363148801;
				if (num != 0)
				{
				}
				num = (short)481558528;
				if (num != 0)
				{
				}
				this.<FinishedJobsCount>k__BackingField = value;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x00048464 File Offset: 0x00046664
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x00048514 File Offset: 0x00046714
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("FailedJobsCount", typeof(global::Motorola.CommonCPS.Server.EntityModel.JobContainer))]
		[global::System.Runtime.Serialization.DataMember]
		public int? FailedJobsCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1046877104;
				short num2 = num;
				num = (short)189404080;
				switch (num2 == num)
				{
				}
				num = (short)687603712;
				short num3 = num;
				num = (short)509542401;
				if (num != 0)
				{
				}
				num = (short)1644691456;
				if (num != 0)
				{
				}
				return this.<FailedJobsCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)352148798;
				short num2 = num;
				num = (short)101276990;
				switch (num2 == num)
				{
				}
				num = (short)626130944;
				short num3 = num;
				num = (short)319815681;
				if (num != 0)
				{
				}
				num = (short)264044544;
				if (num != 0)
				{
				}
				this.<FailedJobsCount>k__BackingField = value;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x000485C8 File Offset: 0x000467C8
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x00048678 File Offset: 0x00046878
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("Pac", typeof(global::Motorola.CommonCPS.Server.EntityModel.JobContainer))]
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier Pac
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)990471934;
				short num2 = num;
				num = (short)1105749758;
				switch (num2 == num)
				{
				}
				num = (short)22347776;
				short num3 = num;
				num = (short)1776943105;
				if (num != 0)
				{
				}
				num = (short)1479081984;
				if (num != 0)
				{
				}
				return this.<Pac>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)759038917;
				short num2 = num;
				num = (short)282657733;
				switch (num2 == num)
				{
				}
				num = (short)228524032;
				short num3 = num;
				num = (short)1137311744;
				if (num != 0)
				{
				}
				num = (short)616038401;
				if (num != 0)
				{
				}
				this.<Pac>k__BackingField = value;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x0004872C File Offset: 0x0004692C
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x000487DC File Offset: 0x000469DC
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("WorkMode", typeof(global::Motorola.CommonCPS.Server.EntityModel.JobContainer))]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode WorkMode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)696938183;
				short num2 = num;
				num = (short)351694535;
				switch (num2 == num)
				{
				}
				num = (short)1802108928;
				short num3 = num;
				num = (short)967770112;
				if (num != 0)
				{
				}
				num = (short)103809025;
				if (num != 0)
				{
				}
				return this.<WorkMode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1352964057;
				short num2 = num;
				num = (short)371300313;
				switch (num2 == num)
				{
				}
				num = (short)950009856;
				short num3 = num;
				num = (short)1413611521;
				if (num != 0)
				{
				}
				num = (short)1059913728;
				if (num != 0)
				{
				}
				this.<WorkMode>k__BackingField = value;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x00048890 File Offset: 0x00046A90
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x00048940 File Offset: 0x00046B40
		[global::Motorola.CommonCPS.Server.EntityModel.SummaryFieldDefinition("IsMigrationJob", typeof(global::Motorola.CommonCPS.Server.EntityModel.JobContainer))]
		[global::System.Runtime.Serialization.DataMember]
		public bool IsMigrationJob
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)36914216;
				short num2 = num;
				num = (short)496780328;
				switch (num2 == num)
				{
				}
				num = (short)1032978432;
				short num3 = num;
				num = (short)399769601;
				if (num != 0)
				{
				}
				num = (short)532742144;
				if (num != 0)
				{
				}
				return this.<IsMigrationJob>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)254378710;
				short num2 = num;
				num = (short)459309782;
				switch (num2 == num)
				{
				}
				num = (short)587071488;
				short num3 = num;
				num = (short)1580662785;
				if (num != 0)
				{
				}
				num = (short)915079168;
				if (num != 0)
				{
				}
				this.<IsMigrationJob>k__BackingField = value;
			}
		}
	}
}
