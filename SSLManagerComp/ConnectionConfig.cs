using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using SSLMangrComp.Packets;

namespace SSLMangrComp
{
	// Token: 0x02000008 RID: 8
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class ConnectionConfig
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00003244 File Offset: 0x00001444
		// (set) Token: 0x06000013 RID: 19 RVA: 0x000032F4 File Offset: 0x000014F4
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Net.IPAddress PnIp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)637468673;
				if (num != 0)
				{
				}
				num = (short)254886264;
				short num2 = num;
				num = (short)1052393848;
				switch (num2 == num)
				{
				}
				num = (short)1888092160;
				short num3 = num;
				num = (short)668925952;
				if (num != 0)
				{
				}
				return this.<PnIp>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)556641105;
				short num2 = num;
				num = (short)1335143249;
				switch (num2 == num)
				{
				}
				num = (short)884932609;
				if (num != 0)
				{
				}
				num = (short)54853632;
				short num3 = num;
				num = (short)1260650496;
				if (num != 0)
				{
				}
				this.<PnIp>k__BackingField = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000033A8 File Offset: 0x000015A8
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00003454 File Offset: 0x00001654
		[global::System.Runtime.Serialization.DataMember]
		public int PnPort
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)185737262;
				short num2 = num;
				num = (short)1063133230;
				switch (num2 == num)
				{
				}
				num = (short)1704198145;
				if (num != 0)
				{
				}
				num = (short)1806434304;
				short num3 = num;
				num = (short)1279524864;
				if (num != 0)
				{
				}
				return this.<PnPort>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1822738838;
				short num2 = num;
				num = (short)46844310;
				switch (num2 == num)
				{
				}
				num = (short)2135556097;
				if (num != 0)
				{
				}
				num = (short)737017856;
				short num3 = num;
				num = (short)1296891904;
				if (num != 0)
				{
				}
				this.<PnPort>k__BackingField = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00003508 File Offset: 0x00001708
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000035B8 File Offset: 0x000017B8
		[global::System.Runtime.Serialization.DataMember]
		public string hostName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1079382352;
				short num2 = num;
				num = (short)1282478416;
				switch (num2 == num)
				{
				}
				num = (short)1532428289;
				if (num != 0)
				{
				}
				num = (short)616628224;
				short num3 = num;
				num = (short)1268842496;
				if (num != 0)
				{
				}
				return this.<hostName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)509608004;
				short num2 = num;
				num = (short)711589956;
				switch (num2 == num)
				{
				}
				num = (short)711131137;
				if (num != 0)
				{
				}
				num = (short)1749811200;
				short num3 = num;
				num = (short)963379200;
				if (num != 0)
				{
				}
				this.<hostName>k__BackingField = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00003664 File Offset: 0x00001864
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00003710 File Offset: 0x00001910
		[global::System.Runtime.Serialization.DataMember]
		public int Expiration
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1906835673;
				short num2 = num;
				num = (short)521797849;
				switch (num2 == num)
				{
				}
				num = (short)1163395072;
				if (num != 0)
				{
				}
				num = (short)1031864320;
				short num3 = num;
				num = (short)750059521;
				if (num != 0)
				{
				}
				return this.<Expiration>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1429110420;
				short num2 = num;
				num = (short)152665748;
				switch (num2 == num)
				{
				}
				num = (short)1539964929;
				if (num != 0)
				{
				}
				num = (short)646381568;
				short num3 = num;
				num = (short)471859200;
				if (num != 0)
				{
				}
				this.<Expiration>k__BackingField = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000037C0 File Offset: 0x000019C0
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00003870 File Offset: 0x00001A70
		[global::System.Runtime.Serialization.DataMember]
		public global::SSLMangrComp.Packets.SubscriptionType SubscriptionMode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1180069940;
				short num2 = num;
				num = (short)188313652;
				switch (num2 == num)
				{
				}
				num = (short)2074673153;
				if (num != 0)
				{
				}
				num = (short)2107703296;
				short num3 = num;
				num = (short)1814036480;
				if (num != 0)
				{
				}
				return this.<SubscriptionMode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1206852737;
				short num2 = num;
				num = (short)1002445953;
				switch (num2 == num)
				{
				}
				num = (short)2078605313;
				if (num != 0)
				{
				}
				num = (short)1449590784;
				short num3 = num;
				num = (short)581173248;
				if (num != 0)
				{
				}
				this.<SubscriptionMode>k__BackingField = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001C RID: 28 RVA: 0x0000391C File Offset: 0x00001B1C
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000039CC File Offset: 0x00001BCC
		[global::System.Runtime.Serialization.DataMember]
		public global::SSLMangrComp.Packets.EntitiesTypes EntityType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)454351930;
				short num2 = num;
				num = (short)885775418;
				switch (num2 == num)
				{
				}
				num = (short)1586626560;
				if (num != 0)
				{
				}
				num = (short)735182848;
				short num3 = num;
				num = (short)289210369;
				if (num != 0)
				{
				}
				return this.<EntityType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)651228191;
				short num2 = num;
				num = (short)613086239;
				switch (num2 == num)
				{
				}
				num = (short)933560321;
				if (num != 0)
				{
				}
				num = (short)1740701696;
				short num3 = num;
				num = (short)1366228992;
				if (num != 0)
				{
				}
				this.<EntityType>k__BackingField = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00003A7C File Offset: 0x00001C7C
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00003B30 File Offset: 0x00001D30
		[global::System.Runtime.Serialization.DataMember]
		public string EntityValue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)443536432;
				short num2 = num;
				num = (short)1304679472;
				switch (num2 == num)
				{
				}
				num = (short)1080295425;
				if (num != 0)
				{
				}
				num = (short)133693440;
				if (num != 0)
				{
				}
				num = (short)1133838336;
				short num3 = num;
				return this.<EntityValue>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1677595301;
				short num2 = num;
				num = (short)113447589;
				switch (num2 == num)
				{
				}
				num = (short)1500971008;
				if (num != 0)
				{
				}
				num = (short)125698049;
				if (num != 0)
				{
				}
				num = (short)1385103360;
				short num3 = num;
				this.<EntityValue>k__BackingField = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00003BE0 File Offset: 0x00001DE0
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00003C90 File Offset: 0x00001E90
		[global::System.Runtime.Serialization.DataMember]
		public int ConnectionAttemptTimeout
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1457248913;
				short num2 = num;
				num = (short)407558801;
				switch (num2 == num)
				{
				}
				num = (short)1040187393;
				if (num != 0)
				{
				}
				num = (short)290324480;
				if (num != 0)
				{
				}
				num = (short)1424293888;
				short num3 = num;
				return this.<ConnectionAttemptTimeout>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)718340097;
				if (num != 0)
				{
				}
				num = (short)989707929;
				short num2 = num;
				num = (short)1666301593;
				switch (num2 == num)
				{
				}
				num = (short)2122711040;
				if (num != 0)
				{
				}
				num = (short)148504576;
				short num3 = num;
				this.<ConnectionAttemptTimeout>k__BackingField = value;
			}
		}
	}
}
