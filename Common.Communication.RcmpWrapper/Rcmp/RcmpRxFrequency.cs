using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000052 RID: 82
	public class RcmpRxFrequency : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600012D RID: 301 RVA: 0x000123A4 File Offset: 0x000105A4
		public RcmpRxFrequency(uint frequency, byte bandwidth, byte sif)
		{
			base.Opcode = 10;
			this.a = frequency;
			this.b = bandwidth;
			this.c = sif;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000123D4 File Offset: 0x000105D4
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)2146107393;
			if (num != 0)
			{
			}
			num = (short)972551560;
			short num2 = num;
			num = (short)1057420680;
			switch (num2 == num)
			{
			}
			num = (short)1067515904;
			short num3 = num;
			num = (short)563347456;
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

		// Token: 0x0600012F RID: 303 RVA: 0x000124C0 File Offset: 0x000106C0
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)1871294646;
			short num2 = num;
			num = (short)1209708726;
			switch (num2 == num)
			{
			}
			num = (short)614465537;
			if (num != 0)
			{
			}
			num = (short)543031296;
			short num3 = num;
			num = (short)1106968576;
			if (num != 0)
			{
			}
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
		}

		// Token: 0x0400016F RID: 367
		private uint a;

		// Token: 0x04000170 RID: 368
		private byte b;

		// Token: 0x04000171 RID: 369
		private byte c;
	}
}
