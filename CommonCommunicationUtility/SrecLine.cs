using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000A RID: 10
	public sealed class SrecLine
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002F78 File Offset: 0x00001178
		public SrecLine(global::Motorola.Common.Communication.SrecType type, byte length, uint address, byte[] data, byte checksum)
		{
			this.a = type;
			this.b = length;
			this.c = address;
			this.e = checksum;
			this.d = data;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002FB0 File Offset: 0x000011B0
		public global::Motorola.Common.Communication.SrecType Type
		{
			get
			{
				short num = (short)927767781;
				short num2 = num;
				num = (short)536386789;
				switch (num2 == num)
				{
				}
				num = (short)381288449;
				if (num != 0)
				{
				}
				num = (short)491585536;
				if (num != 0)
				{
				}
				num = (short)1329332224;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00003064 File Offset: 0x00001264
		internal byte RecordLen
		{
			get
			{
				short num = (short)97749558;
				short num2 = num;
				num = (short)710576694;
				switch (num2 == num)
				{
				}
				num = (short)16252929;
				if (num != 0)
				{
				}
				num = (short)239075328;
				if (num != 0)
				{
				}
				num = (short)1518600192;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00003114 File Offset: 0x00001314
		public uint Address
		{
			get
			{
				short num = (short)146916697;
				short num2 = num;
				num = (short)218547545;
				switch (num2 == num)
				{
				}
				num = (short)976748544;
				if (num != 0)
				{
				}
				num = (short)1404960769;
				if (num != 0)
				{
				}
				num = (short)1558839296;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000031C4 File Offset: 0x000013C4
		private byte Checksum
		{
			get
			{
				short num = (short)1711411930;
				short num2 = num;
				num = (short)667816666;
				switch (num2 == num)
				{
				}
				num = (short)1461780480;
				if (num != 0)
				{
				}
				num = (short)1160118273;
				if (num != 0)
				{
				}
				num = (short)1529675776;
				short num3 = num;
				return this.e;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003278 File Offset: 0x00001478
		internal byte[] c()
		{
			short num = (short)218795033;
			short num2 = num;
			num = (short)804621337;
			switch (num2 == num)
			{
			}
			num = (short)678625281;
			if (num != 0)
			{
			}
			num = (short)152764416;
			if (num != 0)
			{
			}
			num = (short)1906900992;
			short num3 = num;
			return this.d;
		}

		// Token: 0x04000019 RID: 25
		private global::Motorola.Common.Communication.SrecType a;

		// Token: 0x0400001A RID: 26
		private byte b;

		// Token: 0x0400001B RID: 27
		private uint c;

		// Token: 0x0400001C RID: 28
		private byte[] d;

		// Token: 0x0400001D RID: 29
		private byte e;
	}
}
