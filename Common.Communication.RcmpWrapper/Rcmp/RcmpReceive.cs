using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200004A RID: 74
	public class RcmpReceive : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000116 RID: 278 RVA: 0x000114AC File Offset: 0x0000F6AC
		public RcmpReceive(byte speakerControl)
		{
			base.Opcode = 5;
			this.a = speakerControl;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000114D0 File Offset: 0x0000F6D0
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1839573123;
			short num2 = num;
			num = (short)1683269763;
			switch (num2 == num)
			{
			default:
			{
				num = (short)993394688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1834680320;
			if (num != 0)
			{
			}
			num = (short)788791297;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a
			});
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000115A4 File Offset: 0x0000F7A4
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)435983958;
			short num2 = num;
			num = (short)1157535318;
			switch (num2 == num)
			{
			}
			num = (short)1297219585;
			if (num != 0)
			{
			}
			num = (short)1874198528;
			short num3 = num;
			num = (short)1643511808;
			if (num != 0)
			{
			}
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
		}

		// Token: 0x04000162 RID: 354
		private byte a;
	}
}
