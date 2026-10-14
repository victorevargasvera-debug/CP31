using System;
using System.Text;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200003B RID: 59
	public class RcmpMemoryStreamWrite : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060000C7 RID: 199 RVA: 0x0000CF54 File Offset: 0x0000B154
		public RcmpMemoryStreamWrite(string fileID, uint sizeOfDataBlock)
		{
			int a_ = 1;
			base..ctor();
			base.Opcode = 1089;
			this.c = global::System.Text.Encoding.ASCII.GetBytes(fileID);
			if (this.c.Length > 4)
			{
				throw new global::System.ArgumentException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("쮌﶐떔\ude96\udd98뮚膠쾢쪤즦캨캪\udfac辮얰\udbb2풴\ud9b6馸", a_) + 4.ToString() + global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("권", a_));
			}
			this.b = sizeOfDataBlock;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000CFD0 File Offset: 0x0000B1D0
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)119996820;
			short num2 = num;
			num = (short)1968308628;
			switch (num2 == num)
			{
			}
			num = (short)2086862849;
			if (num != 0)
			{
			}
			num = (short)30146560;
			if (num != 0)
			{
			}
			num = (short)1471414272;
			short num3 = num;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.c,
				this.b
			});
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)300285953;
			if (num != 0)
			{
			}
			num = (short)1838158902;
			short num2 = num;
			num = (short)824185910;
			switch (num2 == num)
			{
			}
			num = (short)2023096320;
			if (num != 0)
			{
			}
			num = (short)1685651456;
			short num3 = num;
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
		}

		// Token: 0x0400010A RID: 266
		private const int a = 4;

		// Token: 0x0400010B RID: 267
		private uint b;

		// Token: 0x0400010C RID: 268
		private byte[] c;
	}
}
