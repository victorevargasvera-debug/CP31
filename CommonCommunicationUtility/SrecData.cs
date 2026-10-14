using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000003 RID: 3
	public sealed class SrecData
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002128 File Offset: 0x00000328
		public SrecData(uint length, uint address, byte[] dataArr, global::Motorola.Common.Communication.SrecType type)
		{
			this.a = length;
			this.b = address;
			this.c = new byte[length];
			this.d = type;
			if (dataArr != null)
			{
				global::System.Array.Copy(dataArr, this.c, (long)((ulong)length));
				return;
			}
			this.c = null;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002178 File Offset: 0x00000378
		public uint DataLen
		{
			get
			{
				short num = (short)301834199;
				short num2 = num;
				num = (short)880189399;
				switch (num2 == num)
				{
				}
				num = (short)1612513280;
				if (num != 0)
				{
				}
				num = (short)703725568;
				short num3 = num;
				num = (short)26476545;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002224 File Offset: 0x00000424
		public uint Address
		{
			get
			{
				short num = (short)1088214402;
				short num2 = num;
				num = (short)1899943298;
				switch (num2 == num)
				{
				}
				num = (short)800849920;
				if (num != 0)
				{
				}
				num = (short)1290797057;
				if (num != 0)
				{
				}
				num = (short)1507328000;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000022D4 File Offset: 0x000004D4
		public global::Motorola.Common.Communication.SrecType Type
		{
			get
			{
				short num = (short)332482560;
				short num2 = num;
				num = (short)413681664;
				switch (num2 == num)
				{
				}
				num = (short)1244069889;
				if (num != 0)
				{
				}
				num = (short)1413480448;
				if (num != 0)
				{
				}
				num = (short)1710751744;
				short num3 = num;
				return this.d;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002384 File Offset: 0x00000584
		public byte[] GetData()
		{
			short num = (short)2057348819;
			short num2 = num;
			num = (short)8562387;
			switch (num2 == num)
			{
			}
			num = (short)1034813441;
			if (num != 0)
			{
			}
			num = (short)921239552;
			if (num != 0)
			{
			}
			num = (short)841416704;
			short num3 = num;
			return this.c;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002434 File Offset: 0x00000634
		private void a()
		{
			short num = (short)1743781889;
			if (num != 0)
			{
			}
			num = (short)1137857431;
			short num2 = num;
			num = (short)2133676951;
			switch (num2 == num)
			{
			}
			num = (short)1323171840;
			if (num != 0)
			{
			}
			num = (short)1709506560;
			short num3 = num;
			this.c = null;
		}

		// Token: 0x04000003 RID: 3
		private uint a;

		// Token: 0x04000004 RID: 4
		private uint b;

		// Token: 0x04000005 RID: 5
		private byte[] c;

		// Token: 0x04000006 RID: 6
		private global::Motorola.Common.Communication.SrecType d;
	}
}
