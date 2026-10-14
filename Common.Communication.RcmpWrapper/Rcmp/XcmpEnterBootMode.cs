using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000070 RID: 112
	public class XcmpEnterBootMode : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000199 RID: 409 RVA: 0x00018AC8 File Offset: 0x00016CC8
		public XcmpEnterBootMode()
		{
			base.Opcode = 512;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00018AE8 File Offset: 0x00016CE8
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1808531456;
			short num2 = num;
			num = (short)1956927325;
			short num3 = num;
			num = (short)281106269;
			switch (num3 == num)
			{
			}
			num = (short)1155792897;
			if (num != 0)
			{
			}
			num = (short)1432092672;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode
			});
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00018BB0 File Offset: 0x00016DB0
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)379715584;
			short num2 = num;
			num = (short)1588510221;
			short num3 = num;
			num = (short)432782861;
			switch (num3 == num)
			{
			}
			num = (short)1290469376;
			if (num != 0)
			{
			}
			num = (short)1755840513;
			if (num != 0)
			{
			}
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
		}
	}
}
