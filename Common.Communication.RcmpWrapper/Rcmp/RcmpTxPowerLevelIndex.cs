using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000057 RID: 87
	public class RcmpTxPowerLevelIndex : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600013F RID: 319 RVA: 0x00013394 File Offset: 0x00011594
		public RcmpTxPowerLevelIndex(byte level)
		{
			base.Opcode = 6;
			this.a = level;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000133B8 File Offset: 0x000115B8
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)99562518;
			short num2 = num;
			num = (short)865022998;
			switch (num2 == num)
			{
			}
			num = (short)604045312;
			if (num != 0)
			{
			}
			num = (short)343998464;
			short num3 = num;
			num = (short)433979393;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a
			});
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00013490 File Offset: 0x00011690
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)1114898433;
			if (num != 0)
			{
			}
			num = (short)1908075988;
			short num2 = num;
			num = (short)605547988;
			switch (num2 == num)
			{
			}
			num = (short)45285376;
			short num3 = num;
			num = (short)1551630336;
			if (num != 0)
			{
			}
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
		}

		// Token: 0x0400017B RID: 379
		private byte a;
	}
}
