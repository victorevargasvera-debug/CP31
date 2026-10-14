using System;

namespace SpecialFeatures.Flashport.FlashkeyLib
{
	// Token: 0x02000101 RID: 257
	internal sealed class FieldLayout
	{
		// Token: 0x06000E51 RID: 3665 RVA: 0x000031FD File Offset: 0x000013FD
		internal FieldLayout(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType name, int size, int offset, global::System.TypeCode typeCode)
		{
			this.a = name;
			this.b = size;
			this.c = offset;
			this.d = typeCode;
			this.e = global::SpecialFeatures.Flashport.FlashkeyLib.StringEncoding.NotSupported;
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x00003229 File Offset: 0x00001429
		internal FieldLayout(global::SpecialFeatures.Flashport.FlashkeyLib.FieldType name, int size, int offset, global::System.TypeCode typeCode, global::SpecialFeatures.Flashport.FlashkeyLib.StringEncoding encoding)
		{
			this.a = name;
			this.b = size;
			this.c = offset;
			this.d = typeCode;
			this.e = encoding;
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x00142F10 File Offset: 0x00141110
		internal int Size
		{
			get
			{
				short num = (short)444852906;
				short num2 = num;
				num = (short)104131242;
				switch (num2 == num)
				{
				}
				num = (short)1404305408;
				short num3 = num;
				num = (short)58916865;
				if (num != 0)
				{
				}
				num = (short)1041760256;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x00142FC0 File Offset: 0x001411C0
		internal int Offset
		{
			get
			{
				short num = (short)1557628533;
				short num2 = num;
				num = (short)415925877;
				switch (num2 == num)
				{
				}
				num = (short)115802112;
				short num3 = num;
				num = (short)552402945;
				if (num != 0)
				{
				}
				num = (short)652607488;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x00143070 File Offset: 0x00141270
		internal global::SpecialFeatures.Flashport.FlashkeyLib.FieldType Name
		{
			get
			{
				short num = (short)1891756202;
				short num2 = num;
				num = (short)1694427306;
				switch (num2 == num)
				{
				}
				num = (short)896008192;
				short num3 = num;
				num = (short)1612251137;
				if (num != 0)
				{
				}
				num = (short)983498752;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x00143120 File Offset: 0x00141320
		internal global::System.TypeCode TCode
		{
			get
			{
				short num = (short)1032346535;
				short num2 = num;
				num = (short)719018919;
				switch (num2 == num)
				{
				}
				num = (short)1100873728;
				short num3 = num;
				num = (short)502071297;
				if (num != 0)
				{
				}
				num = (short)1960706048;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x001431D0 File Offset: 0x001413D0
		internal global::SpecialFeatures.Flashport.FlashkeyLib.StringEncoding Encoding
		{
			get
			{
				short num = (short)1101972732;
				short num2 = num;
				num = (short)701154556;
				switch (num2 == num)
				{
				}
				num = (short)783941632;
				short num3 = num;
				num = (short)1574961153;
				if (num != 0)
				{
				}
				num = (short)656867328;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x04000788 RID: 1928
		private global::SpecialFeatures.Flashport.FlashkeyLib.FieldType a;

		// Token: 0x04000789 RID: 1929
		private int b;

		// Token: 0x0400078A RID: 1930
		private int c;

		// Token: 0x0400078B RID: 1931
		private global::System.TypeCode d;

		// Token: 0x0400078C RID: 1932
		private global::SpecialFeatures.Flashport.FlashkeyLib.StringEncoding e;
	}
}
