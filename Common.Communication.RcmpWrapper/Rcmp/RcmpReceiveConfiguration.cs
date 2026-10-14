using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200004B RID: 75
	public class RcmpReceiveConfiguration : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000119 RID: 281 RVA: 0x00011668 File Offset: 0x0000F868
		public RcmpReceiveConfiguration(byte source, params byte[] type)
		{
			base.Opcode = 3;
			this.a = source;
			this.b = type;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00011690 File Offset: 0x0000F890
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1070901411;
			short num2 = num;
			num = (short)832415907;
			switch (num2 == num)
			{
			}
			num = (short)793509889;
			if (num != 0)
			{
			}
			num = (short)1081933824;
			short num3 = num;
			num = (short)12976128;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a,
				this.b
			});
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00011770 File Offset: 0x0000F970
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)1216015091;
			short num2 = num;
			num = (short)848489203;
			switch (num2 == num)
			{
			}
			num = (short)1236205569;
			if (num != 0)
			{
			}
			num = (short)1208942592;
			short num3 = num;
			num = (short)841482240;
			if (num != 0)
			{
			}
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, global::Motorola.Common.Communication.r.a() | base.Opcode);
		}

		// Token: 0x04000163 RID: 355
		private byte a;

		// Token: 0x04000164 RID: 356
		private byte[] b;
	}
}
