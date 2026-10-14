using System;
using System.Collections.Generic;

namespace ASK.Core
{
	// Token: 0x02000011 RID: 17
	public class AccessRecordData
	{
		// Token: 0x06000097 RID: 151 RVA: 0x00010D10 File Offset: 0x0000EF10
		public AccessRecordData(int pK, byte[] fc, global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> rg)
		{
			this.a = pK;
			this.b = fc;
			this.c = rg;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00010D38 File Offset: 0x0000EF38
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00010DEC File Offset: 0x0000EFEC
		public int PrimaryKey
		{
			get
			{
				short num = (short)95092736;
				short num2 = num;
				num = (short)1362338842;
				short num3 = num;
				num = (short)542614554;
				switch (num3 == num)
				{
				}
				num = (short)1651441664;
				if (num != 0)
				{
				}
				num = (short)929169409;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)817233920;
				short num2 = num;
				num = (short)102698408;
				short num3 = num;
				num = (short)959647144;
				switch (num3 == num)
				{
				}
				num = (short)1160970241;
				if (num != 0)
				{
				}
				num = (short)1723006976;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00010E9C File Offset: 0x0000F09C
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00010F4C File Offset: 0x0000F14C
		public byte[] FieldCode
		{
			get
			{
				short num = (short)1449918464;
				short num2 = num;
				num = (short)173375630;
				short num3 = num;
				num = (short)257130638;
				switch (num3 == num)
				{
				}
				num = (short)1741684737;
				if (num != 0)
				{
				}
				num = (short)1379270656;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1804337152;
				short num2 = num;
				num = (short)2129330177;
				if (num != 0)
				{
				}
				num = (short)710516009;
				short num3 = num;
				num = (short)576625961;
				switch (num3 == num)
				{
				}
				num = (short)567345152;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00010FFC File Offset: 0x0000F1FC
		// (set) Token: 0x0600009D RID: 157 RVA: 0x000110AC File Offset: 0x0000F2AC
		public global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> Ranges
		{
			get
			{
				short num = (short)1712586752;
				short num2 = num;
				num = (short)783598072;
				short num3 = num;
				num = (short)858374648;
				switch (num3 == num)
				{
				}
				num = (short)188743681;
				if (num != 0)
				{
				}
				num = (short)1503657984;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)2107899904;
				short num2 = num;
				num = (short)242346581;
				short num3 = num;
				num = (short)739502677;
				switch (num3 == num)
				{
				}
				num = (short)626720769;
				if (num != 0)
				{
				}
				num = (short)1895825408;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x04000031 RID: 49
		private int a;

		// Token: 0x04000032 RID: 50
		private byte[] b;

		// Token: 0x04000033 RID: 51
		private global::System.Collections.Generic.Dictionary<ushort, global::ASK.Core.FieldValueRangeRecSet> c;
	}
}
