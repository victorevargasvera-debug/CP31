using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000056 RID: 86
	public class RcmpTxFrequency : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600013C RID: 316 RVA: 0x000131AC File Offset: 0x000113AC
		public RcmpTxFrequency(uint frequency, byte bandwidth, byte deviation)
		{
			base.Opcode = 11;
			this.a = frequency;
			this.b = bandwidth;
			this.c = deviation;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000131DC File Offset: 0x000113DC
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)2095594844;
			short num2 = num;
			num = (short)1156136284;
			switch (num2 == num)
			{
			}
			num = (short)1934229505;
			if (num != 0)
			{
			}
			num = (short)265879552;
			short num3 = num;
			num = (short)508690432;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a,
				this.b,
				this.c
			});
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000132CC File Offset: 0x000114CC
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)1339040162;
			short num2 = num;
			num = (short)589111714;
			switch (num2 == num)
			{
			}
			num = (short)1536884737;
			if (num != 0)
			{
			}
			num = (short)1721237504;
			short num3 = num;
			num = (short)967835648;
			if (num != 0)
			{
			}
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
		}

		// Token: 0x04000178 RID: 376
		private uint a;

		// Token: 0x04000179 RID: 377
		private byte b;

		// Token: 0x0400017A RID: 378
		private byte c;
	}
}
