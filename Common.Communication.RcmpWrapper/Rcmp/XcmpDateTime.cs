using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200006D RID: 109
	public class XcmpDateTime : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000190 RID: 400 RVA: 0x000182CC File Offset: 0x000164CC
		public XcmpDateTime(global::System.DateTime dt)
		{
			base.Opcode = 1074;
			double totalMinutes = global::System.TimeZone.CurrentTimeZone.GetUtcOffset(dt).TotalMinutes;
			this.a = 1;
			this.c = 0;
			this.n = (byte)(totalMinutes / 15.0);
			this.m = (ushort)dt.DayOfYear;
			this.l = (byte)dt.DayOfWeek;
			int num = dt.Year - 1900;
			this.j = (byte)num;
			this.i = (byte)dt.Month;
			this.i -= 1;
			this.h = (byte)dt.Day;
			this.g = (byte)dt.Hour;
			this.f = (byte)dt.Minute;
			this.e = (byte)dt.Second;
			this.d = (ushort)((byte)dt.Millisecond);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000183B4 File Offset: 0x000165B4
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1225064448;
			short num2 = num;
			num = (short)2024573970;
			short num3 = num;
			num = (short)1638632466;
			switch (num3 == num)
			{
			}
			num = (short)509935617;
			if (num != 0)
			{
			}
			num = (short)20840448;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a,
				this.b,
				this.c,
				this.d,
				this.e,
				this.f,
				this.g,
				this.h,
				this.i,
				this.j,
				this.k,
				this.l,
				this.m,
				this.n
			});
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00018544 File Offset: 0x00016744
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)1556742144;
			short num2 = num;
			num = (short)321206205;
			short num3 = num;
			num = (short)175912893;
			switch (num3 == num)
			{
			}
			num = (short)2095513601;
			if (num != 0)
			{
			}
			num = (short)1541472256;
			if (num != 0)
			{
			}
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			this.a = replyBuffer[offset + 3];
			this.b = replyBuffer[offset + 4];
			this.c = replyBuffer[offset + 5];
			this.d = (ushort)((int)replyBuffer[offset + 6] | (int)replyBuffer[offset + 7] << 8);
			this.e = replyBuffer[offset + 8];
			this.f = replyBuffer[offset + 9];
			this.g = replyBuffer[offset + 10];
			this.h = replyBuffer[offset + 11];
			this.i = replyBuffer[offset + 12];
			this.j = replyBuffer[offset + 13];
			this.k = replyBuffer[offset + 14];
			this.l = replyBuffer[offset + 15];
			this.m = (ushort)((int)replyBuffer[offset + 16] | (int)replyBuffer[offset + 17] << 8);
			this.n = replyBuffer[offset + 18];
		}

		// Token: 0x0400021D RID: 541
		private byte a;

		// Token: 0x0400021E RID: 542
		private byte b;

		// Token: 0x0400021F RID: 543
		private byte c;

		// Token: 0x04000220 RID: 544
		private ushort d;

		// Token: 0x04000221 RID: 545
		private byte e;

		// Token: 0x04000222 RID: 546
		private byte f;

		// Token: 0x04000223 RID: 547
		private byte g;

		// Token: 0x04000224 RID: 548
		private byte h;

		// Token: 0x04000225 RID: 549
		private byte i;

		// Token: 0x04000226 RID: 550
		private byte j;

		// Token: 0x04000227 RID: 551
		private byte k;

		// Token: 0x04000228 RID: 552
		private byte l;

		// Token: 0x04000229 RID: 553
		private ushort m;

		// Token: 0x0400022A RID: 554
		private byte n;
	}
}
