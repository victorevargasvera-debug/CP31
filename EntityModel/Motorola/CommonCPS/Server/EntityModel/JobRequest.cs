using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000F0 RID: 240
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Runtime.Serialization.KnownType(typeof(global::Motorola.CommonCPS.Server.EntityModel.JobRequestBuilder))]
	[global::System.Serializable]
	public class JobRequest
	{
		// Token: 0x06000E8D RID: 3725 RVA: 0x0009AA5C File Offset: 0x00098C5C
		protected internal JobRequest()
		{
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x0009AA70 File Offset: 0x00098C70
		protected internal JobRequest(string name, global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType jobType, global::Motorola.CommonCPS.Server.CommonDBConstants.ConnectionMethod connectionMethod, global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption options)
		{
			this.SecurityFieldRequest = new global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest();
			this.IsFirmwareRecoverJob = false;
			this.IsFactoryReset = false;
			this.JobName = name;
			this.JobType = jobType;
			this.RadioProductFamily = (global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily)((radio.ProductFamily != null) ? radio.ProductFamily.Value : 0);
			this.ConnectionMethod = (int)connectionMethod;
			this.RadioUuid = radio.Uuid;
			this.DeviceID = ((radio != null) ? radio.DeviceID : null);
			this.SerialNumber = ((radio != null) ? radio.SerialNumber : null);
			this.ReadRadioOption = options;
			this.UserDefersAllowed = -1;
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x0009AB24 File Offset: 0x00098D24
		protected internal JobRequest(string name, int userDefersAllowed, global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.Server.CommonDBConstants.JobType jobType, global::Motorola.CommonCPS.Server.CommonDBConstants.ConnectionMethod connectionMethod, global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption options) : this(name, radio, jobType, connectionMethod, options)
		{
			this.UserDefersAllowed = userDefersAllowed;
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x0009AB48 File Offset: 0x00098D48
		protected internal JobRequest(string name, global::Motorola.CommonCPS.Server.EntityModel.MigrationRadioTemplateInfo radioInfo, global::Motorola.CommonCPS.Server.CommonDBConstants.ConnectionMethod connectionMethod)
		{
			this.ConnectionMethod = (int)connectionMethod;
			this.JobName = name;
			this.JobType = global::Motorola.CommonCPS.Server.CommonDBConstants.JobType.Read;
			this.RadioProductFamily = radioInfo.ProductFamily.Value;
			this.RadioUuid = radioInfo.RadioUuid.Value;
			this.ReadRadioOption = global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption.BothWithApply;
			this.SerialNumber = radioInfo.SerialNumber;
			this.DeviceID = radioInfo.SerialNumber;
			this.OldTemplateUuid = radioInfo.TemplateUuid.Value;
			this.OldTemplateName = radioInfo.TemplateName;
			this.OldPBAFileUuid = radioInfo.PBAFileUuid.Value;
			this.IsMigrationJob = true;
			this.IsFactoryReset = false;
			this.UserDefersAllowed = -1;
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x0009AC00 File Offset: 0x00098E00
		// (set) Token: 0x06000E92 RID: 3730 RVA: 0x0009ACB0 File Offset: 0x00098EB0
		[global::System.Runtime.Serialization.DataMember]
		public string JobName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)428802048;
				short num2 = num;
				num = (short)1393118713;
				short num3 = num;
				num = (short)1788694009;
				switch (num3 == num)
				{
				}
				num = (short)2049966080;
				if (num != 0)
				{
				}
				num = (short)1155727361;
				if (num != 0)
				{
				}
				return this.<JobName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)982908928;
				short num2 = num;
				num = (short)520420776;
				short num3 = num;
				num = (short)1997602216;
				switch (num3 == num)
				{
				}
				num = (short)1142358016;
				if (num != 0)
				{
				}
				num = (short)1747976193;
				if (num != 0)
				{
				}
				this.<JobName>k__BackingField = value;
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06000E93 RID: 3731 RVA: 0x0009AD60 File Offset: 0x00098F60
		// (set) Token: 0x06000E94 RID: 3732 RVA: 0x0009AE10 File Offset: 0x00099010
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobType JobType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1746993152;
				short num2 = num;
				num = (short)1274090385;
				short num3 = num;
				num = (short)1344344977;
				switch (num3 == num)
				{
				}
				num = (short)1000275969;
				if (num != 0)
				{
				}
				num = (short)874315776;
				if (num != 0)
				{
				}
				return this.<JobType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)1609700973;
				short num2 = num;
				num = (short)2135037549;
				switch (num2 == num)
				{
				}
				num = (short)1418854400;
				if (num != 0)
				{
				}
				num = (short)1638662145;
				if (num != 0)
				{
				}
				num = (short)979501056;
				short num3 = num;
				this.<JobType>k__BackingField = value;
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x06000E95 RID: 3733 RVA: 0x0009AEC4 File Offset: 0x000990C4
		// (set) Token: 0x06000E96 RID: 3734 RVA: 0x0009AF74 File Offset: 0x00099174
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily RadioProductFamily
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1864782284;
				short num2 = num;
				num = (short)1009734092;
				switch (num2 == num)
				{
				}
				num = (short)1337720833;
				if (num != 0)
				{
				}
				num = (short)1642070016;
				if (num != 0)
				{
				}
				num = (short)723648512;
				short num3 = num;
				return this.<RadioProductFamily>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)2097838040;
				short num2 = num;
				num = (short)95582168;
				switch (num2 == num)
				{
				}
				num = (short)11599872;
				if (num != 0)
				{
				}
				num = (short)2127036417;
				if (num != 0)
				{
				}
				num = (short)1703346176;
				short num3 = num;
				this.<RadioProductFamily>k__BackingField = value;
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x06000E97 RID: 3735 RVA: 0x0009B024 File Offset: 0x00099224
		// (set) Token: 0x06000E98 RID: 3736 RVA: 0x0009B0D4 File Offset: 0x000992D4
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime? ScheduleStartDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1381831364;
				short num2 = num;
				num = (short)219943620;
				switch (num2 == num)
				{
				}
				num = (short)1492975617;
				if (num != 0)
				{
				}
				num = (short)826408960;
				if (num != 0)
				{
				}
				num = (short)263061504;
				short num3 = num;
				return this.<ScheduleStartDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)1442788303;
				short num2 = num;
				num = (short)1680028623;
				switch (num2 == num)
				{
				}
				num = (short)2087845889;
				if (num != 0)
				{
				}
				num = (short)1611857920;
				if (num != 0)
				{
				}
				num = (short)1140457472;
				short num3 = num;
				this.<ScheduleStartDate>k__BackingField = value;
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x0009B180 File Offset: 0x00099380
		// (set) Token: 0x06000E9A RID: 3738 RVA: 0x0009B230 File Offset: 0x00099430
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime? ScheduleEndDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)495255553;
				if (num != 0)
				{
				}
				num = (short)608362155;
				short num2 = num;
				num = (short)1716313771;
				switch (num2 == num)
				{
				}
				num = (short)825753600;
				if (num != 0)
				{
				}
				num = (short)1801256960;
				short num3 = num;
				return this.<ScheduleEndDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)313287207;
				short num2 = num;
				num = (short)607740455;
				switch (num2 == num)
				{
				}
				num = (short)1192296448;
				if (num != 0)
				{
				}
				num = (short)750256129;
				if (num != 0)
				{
				}
				num = (short)250740736;
				short num3 = num;
				this.<ScheduleEndDate>k__BackingField = value;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x06000E9B RID: 3739 RVA: 0x0009B2E0 File Offset: 0x000994E0
		// (set) Token: 0x06000E9C RID: 3740 RVA: 0x0009B390 File Offset: 0x00099590
		[global::System.Runtime.Serialization.DataMember]
		public int ConnectionMethod
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)614368464;
				short num2 = num;
				num = (short)76383440;
				switch (num2 == num)
				{
				}
				num = (short)1352728577;
				if (num != 0)
				{
				}
				num = (short)771817472;
				if (num != 0)
				{
				}
				num = (short)1201930240;
				short num3 = num;
				return this.<ConnectionMethod>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)1526464513;
				if (num != 0)
				{
				}
				num = (short)1739798958;
				short num2 = num;
				num = (short)40647086;
				switch (num2 == num)
				{
				}
				num = (short)720961536;
				if (num != 0)
				{
				}
				num = (short)1968504832;
				short num3 = num;
				this.<ConnectionMethod>k__BackingField = value;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x06000E9D RID: 3741 RVA: 0x0009B440 File Offset: 0x00099640
		// (set) Token: 0x06000E9E RID: 3742 RVA: 0x0009B4F0 File Offset: 0x000996F0
		[global::System.Runtime.Serialization.DataMember]
		public int MatrixSwitchoverDelayTimer
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)921417003;
				short num2 = num;
				num = (short)2030875947;
				switch (num2 == num)
				{
				}
				num = (short)1620836352;
				if (num != 0)
				{
				}
				num = (short)1603207169;
				if (num != 0)
				{
				}
				num = (short)1869217792;
				short num3 = num;
				return this.<MatrixSwitchoverDelayTimer>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)1212055685;
				short num2 = num;
				num = (short)582779013;
				switch (num2 == num)
				{
				}
				num = (short)1465188352;
				if (num != 0)
				{
				}
				num = (short)1902313473;
				if (num != 0)
				{
				}
				num = (short)612368384;
				short num3 = num;
				this.<MatrixSwitchoverDelayTimer>k__BackingField = value;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06000E9F RID: 3743 RVA: 0x0009B5A0 File Offset: 0x000997A0
		// (set) Token: 0x06000EA0 RID: 3744 RVA: 0x0009B654 File Offset: 0x00099854
		[global::System.Runtime.Serialization.DataMember]
		public bool MatrixARSSuppression
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1090232727;
				short num2 = num;
				num = (short)198549911;
				switch (num2 == num)
				{
				}
				num = (short)594345985;
				if (num != 0)
				{
				}
				num = (short)101253120;
				if (num != 0)
				{
				}
				num = (short)1375469568;
				short num3 = num;
				return this.<MatrixARSSuppression>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)696651341;
				short num2 = num;
				num = (short)183832141;
				switch (num2 == num)
				{
				}
				num = (short)2138046465;
				if (num != 0)
				{
				}
				num = (short)2020343808;
				if (num != 0)
				{
				}
				num = (short)1454243840;
				short num3 = num;
				this.<MatrixARSSuppression>k__BackingField = value;
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06000EA1 RID: 3745 RVA: 0x0009B704 File Offset: 0x00099904
		// (set) Token: 0x06000EA2 RID: 3746 RVA: 0x0009B7B0 File Offset: 0x000999B0
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid RadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2059013668;
				short num2 = num;
				num = (short)1491734052;
				switch (num2 == num)
				{
				}
				num = (short)421593089;
				if (num != 0)
				{
				}
				num = (short)30670848;
				if (num != 0)
				{
				}
				num = (short)1239941120;
				short num3 = num;
				return this.<RadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)60873179;
				short num2 = num;
				num = (short)406772187;
				switch (num2 == num)
				{
				}
				num = (short)216727552;
				if (num != 0)
				{
				}
				num = (short)1552351233;
				if (num != 0)
				{
				}
				num = (short)75169792;
				short num3 = num;
				this.<RadioUuid>k__BackingField = value;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06000EA3 RID: 3747 RVA: 0x0009B860 File Offset: 0x00099A60
		// (set) Token: 0x06000EA4 RID: 3748 RVA: 0x0009B910 File Offset: 0x00099B10
		[global::System.Runtime.Serialization.DataMember]
		public string DeviceID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)184869818;
				short num2 = num;
				num = (short)680387514;
				switch (num2 == num)
				{
				}
				num = (short)1506476033;
				if (num != 0)
				{
				}
				num = (short)27525120;
				if (num != 0)
				{
				}
				num = (short)1979449344;
				short num3 = num;
				return this.<DeviceID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)2017415211;
				short num2 = num;
				num = (short)249778219;
				switch (num2 == num)
				{
				}
				num = (short)1526726657;
				if (num != 0)
				{
				}
				num = (short)470155264;
				if (num != 0)
				{
				}
				num = (short)729415680;
				short num3 = num;
				this.<DeviceID>k__BackingField = value;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06000EA5 RID: 3749 RVA: 0x0009B9C0 File Offset: 0x00099BC0
		// (set) Token: 0x06000EA6 RID: 3750 RVA: 0x0009BA70 File Offset: 0x00099C70
		[global::System.Runtime.Serialization.DataMember]
		public string SerialNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)961769425;
				short num2 = num;
				num = (short)1273589713;
				switch (num2 == num)
				{
				}
				num = (short)1027604480;
				if (num != 0)
				{
				}
				num = (short)63111169;
				if (num != 0)
				{
				}
				num = (short)458883072;
				short num3 = num;
				return this.<SerialNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)980619608;
				short num2 = num;
				num = (short)1651577176;
				switch (num2 == num)
				{
				}
				num = (short)974061569;
				if (num != 0)
				{
				}
				num = (short)1620180992;
				if (num != 0)
				{
				}
				num = (short)395051008;
				short num3 = num;
				this.<SerialNumber>k__BackingField = value;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x0009BB20 File Offset: 0x00099D20
		// (set) Token: 0x06000EA8 RID: 3752 RVA: 0x0009BBD0 File Offset: 0x00099DD0
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption ReadRadioOption
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1884959279;
				short num2 = num;
				num = (short)767177263;
				switch (num2 == num)
				{
				}
				num = (short)206045185;
				if (num != 0)
				{
				}
				num = (short)1021050880;
				if (num != 0)
				{
				}
				num = (short)307953664;
				short num3 = num;
				return this.<ReadRadioOption>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)1873488921;
				short num2 = num;
				num = (short)1731603481;
				switch (num2 == num)
				{
				}
				num = (short)1008009217;
				if (num != 0)
				{
				}
				num = (short)975110144;
				if (num != 0)
				{
				}
				num = (short)115015680;
				short num3 = num;
				this.<ReadRadioOption>k__BackingField = value;
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x0009BC80 File Offset: 0x00099E80
		// (set) Token: 0x06000EAA RID: 3754 RVA: 0x0009BD2C File Offset: 0x00099F2C
		[global::System.Runtime.Serialization.DataMember]
		public int JobsCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1748697089;
				if (num != 0)
				{
				}
				num = (short)1747367954;
				short num2 = num;
				num = (short)1533196306;
				switch (num2 == num)
				{
				}
				num = (short)833159168;
				if (num != 0)
				{
				}
				num = (short)1553203200;
				short num3 = num;
				return this.<JobsCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)1836358136;
				short num2 = num;
				num = (short)765499896;
				switch (num2 == num)
				{
				}
				num = (short)1683161089;
				if (num != 0)
				{
				}
				num = (short)1305542656;
				if (num != 0)
				{
				}
				num = (short)263127040;
				short num3 = num;
				this.<JobsCount>k__BackingField = value;
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x0009BDDC File Offset: 0x00099FDC
		// (set) Token: 0x06000EAC RID: 3756 RVA: 0x0009BE8C File Offset: 0x0009A08C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.SecurityFieldRequest SecurityFieldRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)253482777;
				short num2 = num;
				num = (short)1299961625;
				switch (num2 == num)
				{
				}
				num = (short)598278144;
				if (num != 0)
				{
				}
				num = (short)950272001;
				if (num != 0)
				{
				}
				num = (short)724107264;
				short num3 = num;
				return this.<SecurityFieldRequest>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)211880302;
				short num2 = num;
				num = (short)1012992366;
				switch (num2 == num)
				{
				}
				num = (short)1358233600;
				if (num != 0)
				{
				}
				num = (short)304611329;
				if (num != 0)
				{
				}
				num = (short)197394432;
				short num3 = num;
				this.<SecurityFieldRequest>k__BackingField = value;
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x0009BF40 File Offset: 0x0009A140
		// (set) Token: 0x06000EAE RID: 3758 RVA: 0x0009BFF0 File Offset: 0x0009A1F0
		[global::System.Runtime.Serialization.DataMember]
		public string RRPLogicalID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)706543617;
				if (num != 0)
				{
				}
				num = (short)123202337;
				short num2 = num;
				num = (short)39971617;
				switch (num2 == num)
				{
				}
				num = (short)1244594176;
				if (num != 0)
				{
				}
				num = (short)387907584;
				short num3 = num;
				return this.<RRPLogicalID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)704159963;
				short num2 = num;
				num = (short)963551451;
				switch (num2 == num)
				{
				}
				num = (short)1221656577;
				if (num != 0)
				{
				}
				num = (short)1777008640;
				short num3 = num;
				num = (short)982908928;
				if (num != 0)
				{
				}
				this.<RRPLogicalID>k__BackingField = value;
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x0009C0A0 File Offset: 0x0009A2A0
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x0009C154 File Offset: 0x0009A354
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? RestoreCPUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1642305075;
				short num2 = num;
				num = (short)1719637555;
				switch (num2 == num)
				{
				}
				num = (short)149356545;
				if (num != 0)
				{
				}
				num = (short)954400768;
				short num3 = num;
				num = (short)150405120;
				if (num != 0)
				{
				}
				return this.<RestoreCPUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)915320275;
				short num2 = num;
				num = (short)939503059;
				switch (num2 == num)
				{
				}
				num = (short)22151169;
				if (num != 0)
				{
				}
				num = (short)383320064;
				short num3 = num;
				num = (short)2075721728;
				if (num != 0)
				{
				}
				this.<RestoreCPUuid>k__BackingField = value;
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06000EB1 RID: 3761 RVA: 0x0009C204 File Offset: 0x0009A404
		// (set) Token: 0x06000EB2 RID: 3762 RVA: 0x0009C2B4 File Offset: 0x0009A4B4
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Configuration RestoreConfiguration
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1509169529;
				short num2 = num;
				num = (short)1095309689;
				switch (num2 == num)
				{
				}
				num = (short)448135169;
				if (num != 0)
				{
				}
				num = (short)491520000;
				short num3 = num;
				num = (short)945946624;
				if (num != 0)
				{
				}
				return this.<RestoreConfiguration>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)1285488641;
				if (num != 0)
				{
				}
				num = (short)1751357537;
				short num2 = num;
				num = (short)1678481505;
				switch (num2 == num)
				{
				}
				num = (short)734855168;
				short num3 = num;
				num = (short)578027520;
				if (num != 0)
				{
				}
				this.<RestoreConfiguration>k__BackingField = value;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x0009C364 File Offset: 0x0009A564
		// (set) Token: 0x06000EB4 RID: 3764 RVA: 0x0009C414 File Offset: 0x0009A614
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.Template RestoreTemplate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1127685607;
				short num2 = num;
				num = (short)1770397159;
				switch (num2 == num)
				{
				}
				num = (short)1961558017;
				if (num != 0)
				{
				}
				num = (short)971898880;
				short num3 = num;
				num = (short)935591936;
				if (num != 0)
				{
				}
				return this.<RestoreTemplate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)675422298;
				short num2 = num;
				num = (short)895688794;
				switch (num2 == num)
				{
				}
				num = (short)701759488;
				if (num != 0)
				{
				}
				num = (short)1852506112;
				short num3 = num;
				num = (short)551419905;
				if (num != 0)
				{
				}
				this.<RestoreTemplate>k__BackingField = value;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06000EB5 RID: 3765 RVA: 0x0009C4C4 File Offset: 0x0009A6C4
		// (set) Token: 0x06000EB6 RID: 3766 RVA: 0x0009C574 File Offset: 0x0009A774
		[global::System.Runtime.Serialization.DataMember]
		public byte[] UEFileContent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1064960001;
				if (num != 0)
				{
				}
				num = (short)1440408915;
				short num2 = num;
				num = (short)1709958483;
				switch (num2 == num)
				{
				}
				num = (short)1764163584;
				short num3 = num;
				num = (short)543227904;
				if (num != 0)
				{
				}
				return this.<UEFileContent>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)633077761;
				if (num != 0)
				{
				}
				num = (short)1935487269;
				short num2 = num;
				num = (short)1610232101;
				switch (num2 == num)
				{
				}
				num = (short)1363607552;
				short num3 = num;
				num = (short)483459072;
				if (num != 0)
				{
				}
				this.<UEFileContent>k__BackingField = value;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06000EB7 RID: 3767 RVA: 0x0009C628 File Offset: 0x0009A828
		// (set) Token: 0x06000EB8 RID: 3768 RVA: 0x0009C6D8 File Offset: 0x0009A8D8
		[global::System.Runtime.Serialization.DataMember]
		public bool IsUserCertUninstallAll
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)96023820;
				short num2 = num;
				num = (short)1134114060;
				switch (num2 == num)
				{
				}
				num = (short)544931841;
				if (num != 0)
				{
				}
				num = (short)249495552;
				short num3 = num;
				num = (short)149618688;
				if (num != 0)
				{
				}
				return this.<IsUserCertUninstallAll>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)1647050753;
				if (num != 0)
				{
				}
				num = (short)1886150214;
				short num2 = num;
				num = (short)1745903174;
				switch (num2 == num)
				{
				}
				num = (short)1911881728;
				short num3 = num;
				num = (short)949616640;
				if (num != 0)
				{
				}
				this.<IsUserCertUninstallAll>k__BackingField = value;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x0009C788 File Offset: 0x0009A988
		// (set) Token: 0x06000EBA RID: 3770 RVA: 0x0009C834 File Offset: 0x0009AA34
		[global::System.Runtime.Serialization.DataMember]
		public bool IsSysCertEnableAll
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1109983125;
				short num2 = num;
				num = (short)1170603925;
				switch (num2 == num)
				{
				}
				num = (short)619446273;
				if (num != 0)
				{
				}
				num = (short)1445265408;
				short num3 = num;
				num = (short)1188495360;
				if (num != 0)
				{
				}
				return this.<IsSysCertEnableAll>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)54121223;
				short num2 = num;
				num = (short)170054407;
				switch (num2 == num)
				{
				}
				num = (short)1849753601;
				if (num != 0)
				{
				}
				num = (short)842858496;
				short num3 = num;
				num = (short)321781760;
				if (num != 0)
				{
				}
				this.<IsSysCertEnableAll>k__BackingField = value;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x0009C8E4 File Offset: 0x0009AAE4
		// (set) Token: 0x06000EBC RID: 3772 RVA: 0x0009C994 File Offset: 0x0009AB94
		[global::System.Runtime.Serialization.DataMember]
		public bool IsSysCertDisableAll
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)540091935;
				short num2 = num;
				num = (short)538191391;
				switch (num2 == num)
				{
				}
				num = (short)858783744;
				if (num != 0)
				{
				}
				num = (short)1003945984;
				short num3 = num;
				num = (short)1834811393;
				if (num != 0)
				{
				}
				return this.<IsSysCertDisableAll>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)711415618;
				short num2 = num;
				num = (short)696670018;
				switch (num2 == num)
				{
				}
				num = (short)1067253761;
				if (num != 0)
				{
				}
				num = (short)49152000;
				short num3 = num;
				num = (short)507904000;
				if (num != 0)
				{
				}
				this.<IsSysCertDisableAll>k__BackingField = value;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x0009CA44 File Offset: 0x0009AC44
		// (set) Token: 0x06000EBE RID: 3774 RVA: 0x0009CAF4 File Offset: 0x0009ACF4
		[global::System.Runtime.Serialization.DataMember]
		public bool IsSROJob
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)662850934;
				short num2 = num;
				num = (short)1226526070;
				switch (num2 == num)
				{
				}
				num = (short)1760100353;
				if (num != 0)
				{
				}
				num = (short)1723334656;
				short num3 = num;
				num = (short)562233344;
				if (num != 0)
				{
				}
				return this.<IsSROJob>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)685930953;
				short num2 = num;
				num = (short)1107851721;
				switch (num2 == num)
				{
				}
				num = (short)1633878016;
				if (num != 0)
				{
				}
				num = (short)1118961664;
				short num3 = num;
				num = (short)1234108417;
				if (num != 0)
				{
				}
				this.<IsSROJob>k__BackingField = value;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06000EBF RID: 3775 RVA: 0x0009CBA4 File Offset: 0x0009ADA4
		// (set) Token: 0x06000EC0 RID: 3776 RVA: 0x0009CC54 File Offset: 0x0009AE54
		[global::System.Runtime.Serialization.DataMember]
		public bool IsFirmwareRecoverJob
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)616304834;
				short num2 = num;
				num = (short)2037256386;
				switch (num2 == num)
				{
				}
				num = (short)1864302593;
				if (num != 0)
				{
				}
				num = (short)1543241728;
				short num3 = num;
				num = (short)260505600;
				if (num != 0)
				{
				}
				return this.<IsFirmwareRecoverJob>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)929169409;
				if (num != 0)
				{
				}
				num = (short)1280018302;
				short num2 = num;
				num = (short)1386514302;
				switch (num2 == num)
				{
				}
				num = (short)1098186752;
				short num3 = num;
				num = (short)1105985536;
				if (num != 0)
				{
				}
				this.<IsFirmwareRecoverJob>k__BackingField = value;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06000EC1 RID: 3777 RVA: 0x0009CD08 File Offset: 0x0009AF08
		// (set) Token: 0x06000EC2 RID: 3778 RVA: 0x0009CDBC File Offset: 0x0009AFBC
		[global::System.Runtime.Serialization.DataMember]
		public string HostName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1683280481;
				short num2 = num;
				num = (short)2002637409;
				switch (num2 == num)
				{
				}
				num = (short)1833631745;
				if (num != 0)
				{
				}
				num = (short)415236096;
				short num3 = num;
				num = (short)1150746624;
				if (num != 0)
				{
				}
				return this.<HostName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)511180801;
				if (num != 0)
				{
				}
				num = (short)606220435;
				short num2 = num;
				num = (short)2119839891;
				switch (num2 == num)
				{
				}
				num = (short)1242365952;
				short num3 = num;
				num = (short)417398784;
				if (num != 0)
				{
				}
				this.<HostName>k__BackingField = value;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x0009CE6C File Offset: 0x0009B06C
		// (set) Token: 0x06000EC4 RID: 3780 RVA: 0x0009CF1C File Offset: 0x0009B11C
		[global::System.Runtime.Serialization.DataMember]
		public bool IsFactoryReset
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1044153097;
				short num2 = num;
				num = (short)1173127945;
				switch (num2 == num)
				{
				}
				num = (short)1386414081;
				if (num != 0)
				{
				}
				num = (short)1869152256;
				short num3 = num;
				num = (short)513015808;
				if (num != 0)
				{
				}
				return this.<IsFactoryReset>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)486383482;
				short num2 = num;
				num = (short)1356963706;
				switch (num2 == num)
				{
				}
				num = (short)883425281;
				if (num != 0)
				{
				}
				num = (short)1118699520;
				short num3 = num;
				num = (short)474152960;
				if (num != 0)
				{
				}
				this.<IsFactoryReset>k__BackingField = value;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x0009CFD0 File Offset: 0x0009B1D0
		// (set) Token: 0x06000EC6 RID: 3782 RVA: 0x0009D07C File Offset: 0x0009B27C
		[global::System.Runtime.Serialization.DataMember]
		public int UserDefersAllowed
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1590425085;
				short num2 = num;
				num = (short)402650621;
				switch (num2 == num)
				{
				}
				num = (short)501088257;
				if (num != 0)
				{
				}
				num = (short)981204992;
				short num3 = num;
				num = (short)2064252928;
				if (num != 0)
				{
				}
				return this.<UserDefersAllowed>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)1377497870;
				short num2 = num;
				num = (short)843248398;
				switch (num2 == num)
				{
				}
				num = (short)125829121;
				if (num != 0)
				{
				}
				num = (short)1069285376;
				short num3 = num;
				num = (short)1570242560;
				if (num != 0)
				{
				}
				this.<UserDefersAllowed>k__BackingField = value;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x0009D12C File Offset: 0x0009B32C
		// (set) Token: 0x06000EC8 RID: 3784 RVA: 0x0009D1DC File Offset: 0x0009B3DC
		[global::System.Runtime.Serialization.DataMember]
		public bool IsMigrationJob
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1700200449;
				if (num != 0)
				{
				}
				num = (short)2119794110;
				short num2 = num;
				num = (short)1546091966;
				switch (num2 == num)
				{
				}
				num = (short)1989083136;
				short num3 = num;
				num = (short)1553399808;
				if (num != 0)
				{
				}
				return this.<IsMigrationJob>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)2004237472;
				short num2 = num;
				num = (short)48118944;
				switch (num2 == num)
				{
				}
				num = (short)1624047617;
				if (num != 0)
				{
				}
				num = (short)146276352;
				short num3 = num;
				num = (short)1107361792;
				if (num != 0)
				{
				}
				this.<IsMigrationJob>k__BackingField = value;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x0009D28C File Offset: 0x0009B48C
		// (set) Token: 0x06000ECA RID: 3786 RVA: 0x0009D33C File Offset: 0x0009B53C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid OldTemplateUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1699990393;
				short num2 = num;
				num = (short)444910457;
				switch (num2 == num)
				{
				}
				num = (short)1414987777;
				if (num != 0)
				{
				}
				num = (short)602537984;
				short num3 = num;
				num = (short)1955528704;
				if (num != 0)
				{
				}
				return this.<OldTemplateUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)150136696;
				short num2 = num;
				num = (short)1367271288;
				switch (num2 == num)
				{
				}
				num = (short)230096896;
				if (num != 0)
				{
				}
				num = (short)2093219840;
				short num3 = num;
				num = (short)1701445633;
				if (num != 0)
				{
				}
				this.<OldTemplateUuid>k__BackingField = value;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x0009D3EC File Offset: 0x0009B5EC
		// (set) Token: 0x06000ECC RID: 3788 RVA: 0x0009D49C File Offset: 0x0009B69C
		[global::System.Runtime.Serialization.DataMember]
		public string OldTemplateName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1317101146;
				short num2 = num;
				num = (short)1574985306;
				switch (num2 == num)
				{
				}
				num = (short)327417856;
				if (num != 0)
				{
				}
				num = (short)2063138816;
				short num3 = num;
				num = (short)1554644993;
				if (num != 0)
				{
				}
				return this.<OldTemplateName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)539408340;
				short num2 = num;
				num = (short)1268234196;
				switch (num2 == num)
				{
				}
				num = (short)646119424;
				if (num != 0)
				{
				}
				num = (short)1416495104;
				short num3 = num;
				num = (short)1006567425;
				if (num != 0)
				{
				}
				this.<OldTemplateName>k__BackingField = value;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x0009D550 File Offset: 0x0009B750
		// (set) Token: 0x06000ECE RID: 3790 RVA: 0x0009D5FC File Offset: 0x0009B7FC
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid OldPBAFileUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1753522367;
				short num2 = num;
				num = (short)914071743;
				switch (num2 == num)
				{
				}
				num = (short)723582976;
				if (num != 0)
				{
				}
				num = (short)1533804544;
				short num3 = num;
				num = (short)202506241;
				if (num != 0)
				{
				}
				return this.<OldPBAFileUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)1670515030;
				short num2 = num;
				num = (short)323488086;
				switch (num2 == num)
				{
				}
				num = (short)1461452801;
				if (num != 0)
				{
				}
				num = (short)1656094720;
				short num3 = num;
				num = (short)1057423360;
				if (num != 0)
				{
				}
				this.<OldPBAFileUuid>k__BackingField = value;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x0009D6AC File Offset: 0x0009B8AC
		// (set) Token: 0x06000ED0 RID: 3792 RVA: 0x0009D758 File Offset: 0x0009B958
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid ConvertionConfigurationUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)436535297;
				if (num != 0)
				{
				}
				num = (short)1567049902;
				short num2 = num;
				num = (short)1155025070;
				switch (num2 == num)
				{
				}
				num = (short)175898624;
				short num3 = num;
				num = (short)1657405440;
				if (num != 0)
				{
				}
				return this.<ConvertionConfigurationUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)371015119;
				short num2 = num;
				num = (short)316620239;
				switch (num2 == num)
				{
				}
				num = (short)1132003328;
				if (num != 0)
				{
				}
				num = (short)1949892608;
				short num3 = num;
				num = (short)337510401;
				if (num != 0)
				{
				}
				this.<ConvertionConfigurationUuid>k__BackingField = value;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x0009D808 File Offset: 0x0009BA08
		// (set) Token: 0x06000ED2 RID: 3794 RVA: 0x0009D8B8 File Offset: 0x0009BAB8
		[global::System.Runtime.Serialization.DataMember]
		public byte[] PasswordResetFileContent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1333251059;
				short num2 = num;
				num = (short)1972685811;
				switch (num2 == num)
				{
				}
				num = (short)1153236993;
				if (num != 0)
				{
				}
				num = (short)552402944;
				short num3 = num;
				num = (short)794886144;
				if (num != 0)
				{
				}
				return this.<PasswordResetFileContent>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)1265686269;
				short num2 = num;
				num = (short)705156861;
				switch (num2 == num)
				{
				}
				num = (short)610926593;
				if (num != 0)
				{
				}
				num = (short)1448345600;
				short num3 = num;
				num = (short)341573632;
				if (num != 0)
				{
				}
				this.<PasswordResetFileContent>k__BackingField = value;
			}
		}

		// Token: 0x040006BE RID: 1726
		private const int DefaultUserDefersValue = -1;
	}
}
