using System;

namespace ASK.Core
{
	// Token: 0x02000025 RID: 37
	public class OtapData
	{
		// Token: 0x0600016B RID: 363 RVA: 0x00029AF8 File Offset: 0x00027CF8
		public OtapData(byte keytype, int sysID, bool otap)
		{
			this.a = keytype;
			this.b = sysID;
			this.c = otap;
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00029B20 File Offset: 0x00027D20
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00029BD0 File Offset: 0x00027DD0
		public byte OTAPKeyType
		{
			get
			{
				short num = (short)304287644;
				short num2 = num;
				num = (short)749277084;
				switch (num2 == num)
				{
				default:
				{
					num = (short)164298752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1243807744;
				if (num != 0)
				{
				}
				num = (short)1065615361;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1988442664;
				short num2 = num;
				num = (short)1492531752;
				switch (num2 == num)
				{
				}
				num = (short)46071809;
				if (num != 0)
				{
				}
				num = (short)1258618880;
				short num3 = num;
				num = (short)688586752;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00029C7C File Offset: 0x00027E7C
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00029D2C File Offset: 0x00027F2C
		public int SystemID
		{
			get
			{
				short num = (short)935194369;
				short num2 = num;
				num = (short)186707713;
				switch (num2 == num)
				{
				}
				num = (short)462422017;
				if (num != 0)
				{
				}
				num = (short)1155792896;
				short num3 = num;
				num = (short)108789760;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)339057162;
				short num2 = num;
				num = (short)205167114;
				switch (num2 == num)
				{
				}
				num = (short)1438842880;
				if (num != 0)
				{
				}
				num = (short)1884225536;
				short num3 = num;
				num = (short)725024769;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000170 RID: 368 RVA: 0x00029DDC File Offset: 0x00027FDC
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00029E8C File Offset: 0x0002808C
		public bool OTAPStatus
		{
			get
			{
				short num = (short)585916082;
				short num2 = num;
				num = (short)409362098;
				switch (num2 == num)
				{
				}
				num = (short)1180041217;
				if (num != 0)
				{
				}
				num = (short)1152188416;
				short num3 = num;
				num = (short)1600389120;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1171087203;
				short num2 = num;
				num = (short)1438867299;
				switch (num2 == num)
				{
				}
				num = (short)547291137;
				if (num != 0)
				{
				}
				num = (short)1074790400;
				short num3 = num;
				num = (short)1339555840;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x040000CD RID: 205
		private byte a;

		// Token: 0x040000CE RID: 206
		private int b;

		// Token: 0x040000CF RID: 207
		private bool c;
	}
}
