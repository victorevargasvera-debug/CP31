using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200002B RID: 43
	public class RcmpBootJumpExecution : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600009B RID: 155 RVA: 0x0000AD28 File Offset: 0x00008F28
		public RcmpBootJumpExecution(uint address)
		{
			base.Opcode = 516;
			this.a = address;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000AD50 File Offset: 0x00008F50
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)913944983;
			short num2 = num;
			num = (short)1366208919;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1522991104;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1709834241;
			if (num != 0)
			{
			}
			num = (short)2109669376;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a
			});
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000AE24 File Offset: 0x00009024
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)326121579;
			short num2 = num;
			num = (short)2083666027;
			switch (num2 == num)
			{
			default:
			{
				num = (short)929693696;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1838022657;
			if (num != 0)
			{
			}
			num = (short)1576402944;
			if (num != 0)
			{
			}
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
		}

		// Token: 0x040000DA RID: 218
		private uint a;
	}
}
