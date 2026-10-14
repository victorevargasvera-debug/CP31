using System;

namespace SpecialFeatures.Programming
{
	// Token: 0x0200008C RID: 140
	public class OTAPPrescenceResult
	{
		// Token: 0x06000A81 RID: 2689 RVA: 0x00002C83 File Offset: 0x00000E83
		public OTAPPrescenceResult(global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE subscriber_prescence, string subscriber_deviceID, string foundIPAddress, string pnErr)
		{
			this.a = subscriber_prescence;
			this.b = subscriber_deviceID;
			this.c = foundIPAddress;
			this.d = pnErr;
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000A82 RID: 2690 RVA: 0x000C2B24 File Offset: 0x000C0D24
		internal global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE DevicePrescence
		{
			get
			{
				short num = (short)1127925102;
				short num2 = num;
				num = (short)119260526;
				switch (num2 == num)
				{
				}
				num = (short)6750209;
				if (num != 0)
				{
				}
				num = (short)770703360;
				short num3 = num;
				num = (short)294453248;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x000C2BD4 File Offset: 0x000C0DD4
		internal string DeviceID
		{
			get
			{
				short num = (short)1486749697;
				if (num != 0)
				{
				}
				num = (short)1579358421;
				short num2 = num;
				num = (short)56563925;
				switch (num2 == num)
				{
				}
				num = (short)2053898240;
				short num3 = num;
				num = (short)1457913856;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000A84 RID: 2692 RVA: 0x000C2C84 File Offset: 0x000C0E84
		internal string DeviceIPAddress
		{
			get
			{
				short num = (short)789017096;
				short num2 = num;
				num = (short)638546440;
				switch (num2 == num)
				{
				}
				num = (short)514916353;
				if (num != 0)
				{
				}
				num = (short)2016477184;
				short num3 = num;
				num = (short)1384054784;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x000C2D34 File Offset: 0x000C0F34
		internal string NetworkError
		{
			get
			{
				short num = (short)800467912;
				short num2 = num;
				num = (short)2121542600;
				switch (num2 == num)
				{
				}
				num = (short)1742274561;
				if (num != 0)
				{
				}
				num = (short)105316352;
				short num3 = num;
				num = (short)687472640;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x04000447 RID: 1095
		private global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE a;

		// Token: 0x04000448 RID: 1096
		private string b;

		// Token: 0x04000449 RID: 1097
		private string c;

		// Token: 0x0400044A RID: 1098
		private string d = string.Empty;
	}
}
