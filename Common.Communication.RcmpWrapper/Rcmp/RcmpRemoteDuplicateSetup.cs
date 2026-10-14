using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200004F RID: 79
	public class RcmpRemoteDuplicateSetup : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000122 RID: 290 RVA: 0x00011B98 File Offset: 0x0000FD98
		public RcmpRemoteDuplicateSetup(global::Motorola.Common.Communication.Rcmp.RemoteDuplicateFunctionType function)
		{
			base.Opcode = 519;
			this.a = (byte)function;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00011BC0 File Offset: 0x0000FDC0
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1572375058;
			short num2 = num;
			num = (short)1750436370;
			switch (num2 == num)
			{
			}
			num = (short)1865023489;
			if (num != 0)
			{
			}
			num = (short)87556096;
			short num3 = num;
			num = (short)616431616;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a
			});
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00011C90 File Offset: 0x0000FE90
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)158573382;
			short num2 = num;
			num = (short)1640276806;
			switch (num2 == num)
			{
			}
			num = (short)1814757376;
			if (num != 0)
			{
			}
			num = (short)1207631872;
			short num3 = num;
			num = (short)385679361;
			if (num != 0)
			{
			}
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
		}

		// Token: 0x0400016A RID: 362
		private byte a;
	}
}
