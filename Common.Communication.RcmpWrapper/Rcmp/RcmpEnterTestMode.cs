using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000030 RID: 48
	public class RcmpEnterTestMode : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x0000BE88 File Offset: 0x0000A088
		public RcmpEnterTestMode()
		{
			base.Opcode = 12;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000BEA4 File Offset: 0x0000A0A4
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)867063207;
			short num2 = num;
			num = (short)534140327;
			switch (num2 == num)
			{
			}
			num = (short)1600192512;
			if (num != 0)
			{
			}
			num = (short)1905065985;
			if (num != 0)
			{
			}
			num = (short)868024320;
			short num3 = num;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode
			});
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000BF68 File Offset: 0x0000A168
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)641073153;
			if (num != 0)
			{
			}
			num = (short)83633285;
			short num2 = num;
			num = (short)1546855557;
			switch (num2 == num)
			{
			}
			num = (short)1836711936;
			if (num != 0)
			{
			}
			num = (short)1783889920;
			short num3 = num;
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
		}
	}
}
