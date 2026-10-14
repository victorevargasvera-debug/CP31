using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000012 RID: 18
	[global::System.Runtime.Serialization.DataContract(Name = "Job")]
	[global::System.Serializable]
	public class JobContainerDetail
	{
		// Token: 0x06000078 RID: 120 RVA: 0x00007374 File Offset: 0x00005574
		public JobContainerDetail()
		{
			this.JobDetailResources = new global::Motorola.CommonCPS.Server.EntityModel.JobDetailResources();
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00007394 File Offset: 0x00005594
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00007444 File Offset: 0x00005644
		[global::System.Runtime.Serialization.DataMember]
		public string JobId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1746403328;
				short num2 = num;
				num = (short)897169594;
				short num3 = num;
				num = (short)448444602;
				switch (num3 == num)
				{
				}
				num = (short)683540481;
				if (num != 0)
				{
				}
				num = (short)749404160;
				if (num != 0)
				{
				}
				return this.<JobId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)417726464;
				short num2 = num;
				num = (short)478456648;
				short num3 = num;
				num = (short)1151773512;
				switch (num3 == num)
				{
				}
				num = (short)1648099329;
				if (num != 0)
				{
				}
				num = (short)710213632;
				if (num != 0)
				{
				}
				this.<JobId>k__BackingField = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000074F8 File Offset: 0x000056F8
		// (set) Token: 0x0600007C RID: 124 RVA: 0x000075A8 File Offset: 0x000057A8
		[global::System.Runtime.Serialization.DataMember]
		public string JobName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)757071872;
				short num2 = num;
				num = (short)1145058297;
				short num3 = num;
				num = (short)1363424249;
				switch (num3 == num)
				{
				}
				num = (short)1628766209;
				if (num != 0)
				{
				}
				num = (short)314048512;
				if (num != 0)
				{
				}
				return this.<JobName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)703463424;
				short num2 = num;
				num = (short)115655355;
				short num3 = num;
				num = (short)463454907;
				switch (num3 == num)
				{
				}
				num = (short)2144206849;
				if (num != 0)
				{
				}
				num = (short)1396703232;
				if (num != 0)
				{
				}
				this.<JobName>k__BackingField = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00007658 File Offset: 0x00005858
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00007708 File Offset: 0x00005908
		[global::System.Runtime.Serialization.DataMember]
		public string JobType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1152057344;
				short num2 = num;
				num = (short)2069977952;
				short num3 = num;
				num = (short)1096571744;
				switch (num3 == num)
				{
				}
				num = (short)1284308993;
				if (num != 0)
				{
				}
				num = (short)935460864;
				if (num != 0)
				{
				}
				return this.<JobType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)569573376;
				short num2 = num;
				num = (short)658579343;
				short num3 = num;
				num = (short)1508319119;
				switch (num3 == num)
				{
				}
				num = (short)1303379969;
				if (num != 0)
				{
				}
				num = (short)619118592;
				if (num != 0)
				{
				}
				this.<JobType>k__BackingField = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000077BC File Offset: 0x000059BC
		// (set) Token: 0x06000080 RID: 128 RVA: 0x0000786C File Offset: 0x00005A6C
		[global::System.Runtime.Serialization.DataMember]
		public string JobStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)264044544;
				short num2 = num;
				num = (short)421745616;
				short num3 = num;
				num = (short)1783976912;
				switch (num3 == num)
				{
				}
				num = (short)1101791232;
				if (num != 0)
				{
				}
				num = (short)2107179009;
				if (num != 0)
				{
				}
				return this.<JobStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)366673920;
				short num2 = num;
				num = (short)14671550;
				short num3 = num;
				num = (short)759815870;
				switch (num3 == num)
				{
				}
				num = (short)707133440;
				if (num != 0)
				{
				}
				num = (short)1638400001;
				if (num != 0)
				{
				}
				this.<JobStatus>k__BackingField = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00007918 File Offset: 0x00005B18
		// (set) Token: 0x06000082 RID: 130 RVA: 0x000079CC File Offset: 0x00005BCC
		[global::System.Runtime.Serialization.DataMember]
		public string ScheduleStartDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)606208000;
				short num2 = num;
				num = (short)717989847;
				short num3 = num;
				num = (short)1942202327;
				switch (num3 == num)
				{
				}
				num = (short)298778625;
				if (num != 0)
				{
				}
				num = (short)2119303168;
				if (num != 0)
				{
				}
				return this.<ScheduleStartDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1484587008;
				short num2 = num;
				num = (short)1589772289;
				if (num != 0)
				{
				}
				num = (short)1216677546;
				short num3 = num;
				num = (short)1587938986;
				switch (num3 == num)
				{
				}
				num = (short)800587776;
				if (num != 0)
				{
				}
				this.<ScheduleStartDate>k__BackingField = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00007A80 File Offset: 0x00005C80
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00007B30 File Offset: 0x00005D30
		[global::System.Runtime.Serialization.DataMember]
		public string ScheduleEndDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)628817920;
				short num2 = num;
				num = (short)559718258;
				short num3 = num;
				num = (short)185573234;
				switch (num3 == num)
				{
				}
				num = (short)2011627521;
				if (num != 0)
				{
				}
				num = (short)1467678720;
				if (num != 0)
				{
				}
				return this.<ScheduleEndDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)80347136;
				short num2 = num;
				num = (short)3418089;
				short num3 = num;
				num = (short)828188649;
				switch (num3 == num)
				{
				}
				num = (short)555614208;
				if (num != 0)
				{
				}
				num = (short)1940914177;
				if (num != 0)
				{
				}
				this.<ScheduleEndDate>k__BackingField = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00007BE0 File Offset: 0x00005DE0
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00007C90 File Offset: 0x00005E90
		[global::System.Runtime.Serialization.DataMember]
		public string CreatedDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2008350720;
				short num2 = num;
				num = (short)1910406495;
				short num3 = num;
				num = (short)1713470815;
				switch (num3 == num)
				{
				}
				num = (short)1785135105;
				if (num != 0)
				{
				}
				num = (short)1723072512;
				if (num != 0)
				{
				}
				return this.<CreatedDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)793640960;
				short num2 = num;
				num = (short)341268741;
				short num3 = num;
				num = (short)171333893;
				switch (num3 == num)
				{
				}
				num = (short)935657472;
				if (num != 0)
				{
				}
				num = (short)198770689;
				if (num != 0)
				{
				}
				this.<CreatedDate>k__BackingField = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00007D44 File Offset: 0x00005F44
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00007DF4 File Offset: 0x00005FF4
		[global::System.Runtime.Serialization.DataMember]
		public string JobDetailCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2084634624;
				short num2 = num;
				num = (short)217317377;
				if (num != 0)
				{
				}
				num = (short)728445006;
				short num3 = num;
				num = (short)792997966;
				switch (num3 == num)
				{
				}
				num = (short)768475136;
				if (num != 0)
				{
				}
				return this.<JobDetailCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)614662144;
				short num2 = num;
				num = (short)685475667;
				short num3 = num;
				num = (short)368346963;
				switch (num3 == num)
				{
				}
				num = (short)1715666945;
				if (num != 0)
				{
				}
				num = (short)753598464;
				if (num != 0)
				{
				}
				this.<JobDetailCount>k__BackingField = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00007EA4 File Offset: 0x000060A4
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00007F50 File Offset: 0x00006150
		[global::System.Runtime.Serialization.DataMember]
		public string FinishedJobDetailCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1908342784;
				short num2 = num;
				num = (short)353034053;
				short num3 = num;
				num = (short)26795845;
				switch (num3 == num)
				{
				}
				num = (short)1704198145;
				if (num != 0)
				{
				}
				num = (short)927203328;
				if (num != 0)
				{
				}
				return this.<FinishedJobDetailCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1208352768;
				short num2 = num;
				num = (short)90302780;
				short num3 = num;
				num = (short)398584124;
				switch (num3 == num)
				{
				}
				num = (short)1358495745;
				if (num != 0)
				{
				}
				num = (short)1414987776;
				if (num != 0)
				{
				}
				this.<FinishedJobDetailCount>k__BackingField = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00008000 File Offset: 0x00006200
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000080B0 File Offset: 0x000062B0
		[global::System.Runtime.Serialization.DataMember]
		public string FailedJobDetailCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1434779648;
				short num2 = num;
				num = (short)923520172;
				short num3 = num;
				num = (short)2006502572;
				switch (num3 == num)
				{
				}
				num = (short)209518592;
				if (num != 0)
				{
				}
				num = (short)428408833;
				if (num != 0)
				{
				}
				return this.<FailedJobDetailCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1048182784;
				short num2 = num;
				num = (short)693532870;
				short num3 = num;
				num = (short)2054322374;
				switch (num3 == num)
				{
				}
				num = (short)463994881;
				if (num != 0)
				{
				}
				num = (short)220725248;
				if (num != 0)
				{
				}
				this.<FailedJobDetailCount>k__BackingField = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00008160 File Offset: 0x00006360
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00008210 File Offset: 0x00006410
		[global::System.Runtime.Serialization.DataMember]
		public string Link
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1607991296;
				short num2 = num;
				num = (short)1996240934;
				short num3 = num;
				num = (short)1764177958;
				switch (num3 == num)
				{
				}
				num = (short)1680867329;
				if (num != 0)
				{
				}
				num = (short)1012596736;
				if (num != 0)
				{
				}
				return this.<Link>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1941110784;
				short num2 = num;
				num = (short)121849387;
				short num3 = num;
				num = (short)1399670315;
				switch (num3 == num)
				{
				}
				num = (short)2007433217;
				if (num != 0)
				{
				}
				num = (short)1256718336;
				if (num != 0)
				{
				}
				this.<Link>k__BackingField = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000082C0 File Offset: 0x000064C0
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00008370 File Offset: 0x00006570
		[global::System.Runtime.Serialization.DataMember(Name = "JobDetails")]
		public global::Motorola.CommonCPS.Server.EntityModel.JobDetailResources JobDetailResources
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)344719360;
				short num2 = num;
				num = (short)1622212609;
				if (num != 0)
				{
				}
				num = (short)1896390768;
				short num3 = num;
				num = (short)641572976;
				switch (num3 == num)
				{
				}
				num = (short)1508245504;
				if (num != 0)
				{
				}
				return this.<JobDetailResources>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)214892544;
				short num2 = num;
				num = (short)1241795673;
				short num3 = num;
				num = (short)1210535001;
				switch (num3 == num)
				{
				}
				num = (short)771883008;
				if (num != 0)
				{
				}
				num = (short)511442945;
				if (num != 0)
				{
				}
				this.<JobDetailResources>k__BackingField = value;
			}
		}
	}
}
