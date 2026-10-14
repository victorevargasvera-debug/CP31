using System;
using Motorola.Acp.PackUnpack.Ish.Loggers;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x0200003D RID: 61
	public class PartitionIOProvider
	{
		// Token: 0x0600026F RID: 623 RVA: 0x0003834C File Offset: 0x0003654C
		internal PartitionIOProvider(global::Motorola.Acp.PackUnpack.Ish.PartitionType A_0, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader A_1, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamWriter A_2, global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger A_3)
		{
			this.a = A_0;
			this.b = A_1;
			this.c = A_2;
			this.d = A_3;
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0003837C File Offset: 0x0003657C
		internal global::Motorola.Acp.PackUnpack.Ish.PartitionType PartitionType
		{
			get
			{
				short num = (short)374945840;
				short num2 = num;
				num = (short)933640240;
				switch (num2 == num)
				{
				}
				num = (short)1707409409;
				if (num != 0)
				{
				}
				num = (short)1973616640;
				if (num != 0)
				{
				}
				num = (short)433258496;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00038428 File Offset: 0x00036628
		internal global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader Reader
		{
			get
			{
				short num = (short)899080969;
				short num2 = num;
				num = (short)2000610057;
				switch (num2 == num)
				{
				}
				num = (short)1130823681;
				if (num != 0)
				{
				}
				num = (short)1239023616;
				if (num != 0)
				{
				}
				num = (short)520486912;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000272 RID: 626 RVA: 0x000384D8 File Offset: 0x000366D8
		internal global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamWriter Writer
		{
			get
			{
				short num = (short)327858421;
				short num2 = num;
				num = (short)1685305589;
				switch (num2 == num)
				{
				}
				num = (short)1090519041;
				if (num != 0)
				{
				}
				num = (short)1929510912;
				if (num != 0)
				{
				}
				num = (short)2131230720;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00038588 File Offset: 0x00036788
		internal global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger Logger
		{
			get
			{
				short num = (short)1612092742;
				short num2 = num;
				num = (short)1418761542;
				switch (num2 == num)
				{
				}
				num = (short)1156055040;
				if (num != 0)
				{
				}
				num = (short)1898119169;
				if (num != 0)
				{
				}
				num = (short)466026496;
				short num3 = num;
				return this.d;
			}
		}

		// Token: 0x040000E3 RID: 227
		private global::Motorola.Acp.PackUnpack.Ish.PartitionType a;

		// Token: 0x040000E4 RID: 228
		private global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader b;

		// Token: 0x040000E5 RID: 229
		private global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamWriter c;

		// Token: 0x040000E6 RID: 230
		private global::Motorola.Acp.PackUnpack.Ish.Loggers.PartitionLogger d;
	}
}
