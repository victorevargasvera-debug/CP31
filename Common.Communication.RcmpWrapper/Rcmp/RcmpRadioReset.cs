using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200003D RID: 61
	public class RcmpRadioReset : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060000CD RID: 205 RVA: 0x0000D32C File Offset: 0x0000B52C
		public RcmpRadioReset()
		{
			base.Opcode = 13;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000D348 File Offset: 0x0000B548
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)237147771;
			short num2 = num;
			num = (short)972068475;
			switch (num2 == num)
			{
			}
			num = (short)635043841;
			if (num != 0)
			{
			}
			num = (short)1264189440;
			if (num != 0)
			{
			}
			num = (short)700121088;
			short num3 = num;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode
			});
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000D40C File Offset: 0x0000B60C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)711589889;
			if (num != 0)
			{
			}
			num = (short)884053106;
			short num2 = num;
			num = (short)928355442;
			switch (num2 == num)
			{
			}
			num = (short)340262912;
			if (num != 0)
			{
			}
			num = (short)935395328;
			short num3 = num;
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
		}
	}
}
