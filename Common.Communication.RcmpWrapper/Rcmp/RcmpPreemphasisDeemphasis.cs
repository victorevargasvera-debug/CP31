using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200003C RID: 60
	public class RcmpPreemphasisDeemphasis : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060000CA RID: 202 RVA: 0x0000D174 File Offset: 0x0000B374
		public RcmpPreemphasisDeemphasis(byte control)
		{
			base.Opcode = 7;
			this.a = control;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000D198 File Offset: 0x0000B398
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1994063873;
			if (num != 0)
			{
			}
			num = (short)871665894;
			short num2 = num;
			num = (short)424120550;
			switch (num2 == num)
			{
			}
			num = (short)433324032;
			if (num != 0)
			{
			}
			num = (short)437125120;
			short num3 = num;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a
			});
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000D268 File Offset: 0x0000B468
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)704150824;
			short num2 = num;
			num = (short)1300397352;
			switch (num2 == num)
			{
			}
			num = (short)2033778688;
			if (num != 0)
			{
			}
			num = (short)684523521;
			if (num != 0)
			{
			}
			num = (short)1472069632;
			short num3 = num;
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
		}

		// Token: 0x0400010D RID: 269
		private byte a;
	}
}
