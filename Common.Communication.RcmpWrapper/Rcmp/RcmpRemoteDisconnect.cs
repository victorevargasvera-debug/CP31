using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200004D RID: 77
	public class RcmpRemoteDisconnect : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600011F RID: 287 RVA: 0x000119F0 File Offset: 0x0000FBF0
		public RcmpRemoteDisconnect()
		{
			base.Opcode = 37;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00011A0C File Offset: 0x0000FC0C
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)740263649;
			short num2 = num;
			num = (short)554075873;
			switch (num2 == num)
			{
			}
			num = (short)2099380225;
			if (num != 0)
			{
			}
			num = (short)1865285632;
			short num3 = num;
			num = (short)1019346944;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode
			});
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00011AD4 File Offset: 0x0000FCD4
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)437599325;
			short num2 = num;
			num = (short)128138333;
			switch (num2 == num)
			{
			}
			num = (short)474677249;
			if (num != 0)
			{
			}
			num = (short)106692608;
			short num3 = num;
			num = (short)996540416;
			if (num != 0)
			{
			}
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
		}
	}
}
