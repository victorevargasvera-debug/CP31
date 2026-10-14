using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.ServiceModel.CallBack
{
	// Token: 0x0200000B RID: 11
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ServerEventInfo
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00003F6C File Offset: 0x0000216C
		public ServerEventInfo()
		{
			this.EventEntries = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.ServiceModel.CallBack.ServerEventEntry>();
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003F8C File Offset: 0x0000218C
		// (set) Token: 0x0600002A RID: 42 RVA: 0x0000403C File Offset: 0x0000223C
		[global::System.Runtime.Serialization.DataMember]
		public string SenderId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)657448842;
				short num2 = num;
				num = (short)1859444618;
				switch (num2 == num)
				{
				}
				num = (short)2028732416;
				if (num != 0)
				{
				}
				num = (short)1049624576;
				short num3 = num;
				num = (short)1958477825;
				if (num != 0)
				{
				}
				return this.<SenderId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)49306516;
				short num2 = num;
				num = (short)790911892;
				switch (num2 == num)
				{
				}
				num = (short)2043871232;
				if (num != 0)
				{
				}
				num = (short)2065563648;
				short num3 = num;
				num = (short)683278337;
				if (num != 0)
				{
				}
				this.<SenderId>k__BackingField = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000040F0 File Offset: 0x000022F0
		// (set) Token: 0x0600002C RID: 44 RVA: 0x0000419C File Offset: 0x0000239C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier Pac
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1224123242;
				short num2 = num;
				num = (short)737518442;
				switch (num2 == num)
				{
				}
				num = (short)803209217;
				if (num != 0)
				{
				}
				num = (short)728825856;
				short num3 = num;
				num = (short)1398079488;
				if (num != 0)
				{
				}
				return this.<Pac>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1604911105;
				if (num != 0)
				{
				}
				num = (short)1121830503;
				short num2 = num;
				num = (short)1558103655;
				switch (num2 == num)
				{
				}
				num = (short)817692672;
				short num3 = num;
				num = (short)1740111872;
				if (num != 0)
				{
				}
				this.<Pac>k__BackingField = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00004250 File Offset: 0x00002450
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00004300 File Offset: 0x00002500
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.SendFrom SendFrom
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)409364568;
				short num2 = num;
				num = (short)1679517784;
				switch (num2 == num)
				{
				}
				num = (short)1752498177;
				if (num != 0)
				{
				}
				num = (short)578158592;
				short num3 = num;
				num = (short)862978048;
				if (num != 0)
				{
				}
				return this.<SendFrom>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)959053825;
				if (num != 0)
				{
				}
				num = (short)762808942;
				short num2 = num;
				num = (short)1776847470;
				switch (num2 == num)
				{
				}
				num = (short)1696399360;
				short num3 = num;
				num = (short)1097465856;
				if (num != 0)
				{
				}
				this.<SendFrom>k__BackingField = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000043B0 File Offset: 0x000025B0
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00004464 File Offset: 0x00002664
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.ServiceModel.CallBack.ServerEventEntry> EventEntries
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1386034024;
				short num2 = num;
				num = (short)818623336;
				switch (num2 == num)
				{
				}
				num = (short)2006974465;
				if (num != 0)
				{
				}
				num = (short)191365120;
				short num3 = num;
				num = (short)2101805056;
				if (num != 0)
				{
				}
				return this.<EventEntries>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1473839105;
				if (num != 0)
				{
				}
				num = (short)1785384307;
				short num2 = num;
				num = (short)1442172275;
				switch (num2 == num)
				{
				}
				num = (short)1756168192;
				short num3 = num;
				num = (short)1627914240;
				if (num != 0)
				{
				}
				this.<EventEntries>k__BackingField = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00004514 File Offset: 0x00002714
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000045C4 File Offset: 0x000027C4
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime FireDatetime
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)89194497;
				if (num != 0)
				{
				}
				num = (short)1922278007;
				short num2 = num;
				num = (short)239444599;
				switch (num2 == num)
				{
				}
				num = (short)766902272;
				short num3 = num;
				num = (short)1808596992;
				if (num != 0)
				{
				}
				return this.<FireDatetime>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2018566487;
				short num2 = num;
				num = (short)2091442519;
				switch (num2 == num)
				{
				}
				num = (short)2090598401;
				if (num != 0)
				{
				}
				num = (short)684851200;
				short num3 = num;
				num = (short)1185153024;
				if (num != 0)
				{
				}
				this.<FireDatetime>k__BackingField = value;
			}
		}
	}
}
