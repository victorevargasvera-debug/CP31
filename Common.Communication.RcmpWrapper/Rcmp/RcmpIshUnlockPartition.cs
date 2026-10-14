using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000039 RID: 57
	public class RcmpIshUnlockPartition : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060000C0 RID: 192 RVA: 0x0000CA34 File Offset: 0x0000AC34
		public RcmpIshUnlockPartition(byte partition)
		{
			base.Opcode = 264;
			this.a = partition;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000CA5C File Offset: 0x0000AC5C
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1934263558;
			short num2 = num;
			num = (short)168658182;
			switch (num2 == num)
			{
			}
			num = (short)1116798977;
			if (num != 0)
			{
			}
			num = (short)1370619904;
			if (num != 0)
			{
			}
			num = (short)1316290560;
			short num3 = num;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a
			});
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000CB30 File Offset: 0x0000AD30
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)457019294;
			short num2 = num;
			num = (short)687312798;
			switch (num2 == num)
			{
			}
			num = (short)627507200;
			if (num != 0)
			{
			}
			num = (short)745865217;
			if (num != 0)
			{
			}
			num = (short)272695296;
			short num3 = num;
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
		}

		// Token: 0x04000106 RID: 262
		private byte a;
	}
}
