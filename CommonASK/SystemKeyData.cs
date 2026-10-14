using System;
using System.Globalization;
using ASK.Interface;

namespace CommonASK
{
	// Token: 0x02000009 RID: 9
	public class SystemKeyData : global::ASK.Interface.ISystemKeyData
	{
		// Token: 0x06000047 RID: 71 RVA: 0x000054E8 File Offset: 0x000036E8
		public SystemKeyData(global::ASK.Interface.KeyAccessLevelType aclvl, string serialNum, bool otapEnabled, global::ASK.Interface.KeySource src, int id, global::ASK.Interface.KeyType type, string uuid, bool bWriteProtected)
		{
			int a_ = 6;
			base..ctor();
			this.a = aclvl;
			this.b = serialNum;
			this.c = otapEnabled;
			this.d = src;
			this.e = id;
			this.f = id.ToString(global::CommonASK.SystemKeyHelper.b("娡", a_), global::System.Globalization.CultureInfo.InvariantCulture);
			this.g = type;
			this.h = uuid;
			this.i = bWriteProtected;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00005564 File Offset: 0x00003764
		public global::ASK.Interface.KeyAccessLevelType AccessLevelType
		{
			get
			{
				short num = (short)1118440470;
				short num2 = num;
				num = (short)636685334;
				switch (num2 == num)
				{
				}
				num = (short)827654144;
				if (num != 0)
				{
				}
				num = (short)472907777;
				if (num != 0)
				{
				}
				num = (short)536805376;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00005614 File Offset: 0x00003814
		public string iBtnSerialNum
		{
			get
			{
				short num = (short)641345614;
				short num2 = num;
				num = (short)610740302;
				switch (num2 == num)
				{
				}
				num = (short)2031616000;
				if (num != 0)
				{
				}
				num = (short)780599297;
				if (num != 0)
				{
				}
				num = (short)941555712;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000056C4 File Offset: 0x000038C4
		public bool OtapEnabled
		{
			get
			{
				short num = (short)1391066892;
				short num2 = num;
				num = (short)492961548;
				switch (num2 == num)
				{
				}
				num = (short)250085376;
				if (num != 0)
				{
				}
				num = (short)1034944513;
				if (num != 0)
				{
				}
				num = (short)292683776;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00005774 File Offset: 0x00003974
		public global::ASK.Interface.KeySource Source
		{
			get
			{
				short num = (short)811697852;
				short num2 = num;
				num = (short)475891388;
				switch (num2 == num)
				{
				}
				num = (short)1340342273;
				if (num != 0)
				{
				}
				num = (short)251330560;
				if (num != 0)
				{
				}
				num = (short)1587609600;
				short num3 = num;
				return this.d;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00005824 File Offset: 0x00003A24
		public int SystemID
		{
			get
			{
				short num = (short)473039379;
				short num2 = num;
				num = (short)1729888787;
				switch (num2 == num)
				{
				}
				num = (short)603455489;
				if (num != 0)
				{
				}
				num = (short)657260544;
				if (num != 0)
				{
				}
				num = (short)450232320;
				short num3 = num;
				return this.e;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000058D4 File Offset: 0x00003AD4
		public string SystemIDHex
		{
			get
			{
				short num = (short)870688588;
				short num2 = num;
				num = (short)390506316;
				switch (num2 == num)
				{
				}
				num = (short)413401088;
				if (num != 0)
				{
				}
				num = (short)2003959809;
				if (num != 0)
				{
				}
				num = (short)1091895296;
				short num3 = num;
				return this.f;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00005984 File Offset: 0x00003B84
		public global::ASK.Interface.KeyType Type
		{
			get
			{
				short num = (short)1394208634;
				short num2 = num;
				num = (short)21688186;
				switch (num2 == num)
				{
				}
				num = (short)2114060289;
				if (num != 0)
				{
				}
				num = (short)970326016;
				if (num != 0)
				{
				}
				num = (short)1567096832;
				short num3 = num;
				return this.g;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00005A34 File Offset: 0x00003C34
		public string UuId
		{
			get
			{
				short num = (short)172330075;
				short num2 = num;
				num = (short)384142427;
				switch (num2 == num)
				{
				}
				num = (short)949354497;
				if (num != 0)
				{
				}
				num = (short)2124152832;
				if (num != 0)
				{
				}
				num = (short)718143488;
				short num3 = num;
				return this.h;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00005AE8 File Offset: 0x00003CE8
		public bool WriteProtectEnabled
		{
			get
			{
				short num = (short)320711567;
				short num2 = num;
				num = (short)268807055;
				switch (num2 == num)
				{
				}
				num = (short)695926785;
				if (num != 0)
				{
				}
				num = (short)1559953408;
				if (num != 0)
				{
				}
				num = (short)1098055680;
				short num3 = num;
				return this.i;
			}
		}

		// Token: 0x0400001C RID: 28
		private global::ASK.Interface.KeyAccessLevelType a;

		// Token: 0x0400001D RID: 29
		private string b;

		// Token: 0x0400001E RID: 30
		private bool c;

		// Token: 0x0400001F RID: 31
		private global::ASK.Interface.KeySource d;

		// Token: 0x04000020 RID: 32
		private int e;

		// Token: 0x04000021 RID: 33
		private string f;

		// Token: 0x04000022 RID: 34
		private global::ASK.Interface.KeyType g;

		// Token: 0x04000023 RID: 35
		private string h;

		// Token: 0x04000024 RID: 36
		private bool i;
	}
}
