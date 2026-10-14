using System;

namespace AcpASKLib
{
	// Token: 0x02000032 RID: 50
	public class OtapData
	{
		// Token: 0x06000168 RID: 360 RVA: 0x00028070 File Offset: 0x00026270
		internal OtapData(byte A_0, int A_1, bool A_2)
		{
			this.a = A_0;
			this.b = A_1;
			this.c = A_2;
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00028098 File Offset: 0x00026298
		// (set) Token: 0x0600016A RID: 362 RVA: 0x0002814C File Offset: 0x0002634C
		internal byte OTAPKeyType
		{
			get
			{
				short num = (short)1115944762;
				short num2 = num;
				num = (short)1528362810;
				switch (num2 == num)
				{
				}
				num = (short)1118896128;
				short num3 = num;
				num = (short)244842497;
				if (num != 0)
				{
				}
				num = (short)421134336;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)472692621;
				short num2 = num;
				num = (short)485996429;
				switch (num2 == num)
				{
				}
				num = (short)831062016;
				short num3 = num;
				num = (short)584712193;
				if (num != 0)
				{
				}
				num = (short)1148715008;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600016B RID: 363 RVA: 0x000281FC File Offset: 0x000263FC
		// (set) Token: 0x0600016C RID: 364 RVA: 0x000282AC File Offset: 0x000264AC
		internal int SystemID
		{
			get
			{
				short num = (short)2067788875;
				short num2 = num;
				num = (short)551416907;
				switch (num2 == num)
				{
				}
				num = (short)157024256;
				short num3 = num;
				num = (short)133496833;
				if (num != 0)
				{
				}
				num = (short)1587412992;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)2076997387;
				short num2 = num;
				num = (short)682522379;
				switch (num2 == num)
				{
				}
				num = (short)673120256;
				short num3 = num;
				num = (short)1843593217;
				if (num != 0)
				{
				}
				num = (short)1357905920;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600016D RID: 365 RVA: 0x00028358 File Offset: 0x00026558
		// (set) Token: 0x0600016E RID: 366 RVA: 0x0002840C File Offset: 0x0002660C
		internal bool OTAPStatus
		{
			get
			{
				short num = (short)788517763;
				short num2 = num;
				num = (short)330421123;
				switch (num2 == num)
				{
				}
				num = (short)2042822656;
				short num3 = num;
				num = (short)1791557633;
				if (num != 0)
				{
				}
				num = (short)523436032;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)63304289;
				short num2 = num;
				num = (short)1784148577;
				switch (num2 == num)
				{
				}
				num = (short)724631552;
				short num3 = num;
				num = (short)1936457728;
				if (num != 0)
				{
				}
				num = (short)1922957313;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x040001B4 RID: 436
		private byte a;

		// Token: 0x040001B5 RID: 437
		private int b;

		// Token: 0x040001B6 RID: 438
		private bool c;
	}
}
