using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000054 RID: 84
	public class RcmpTransmit : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000136 RID: 310 RVA: 0x00012DE8 File Offset: 0x00010FE8
		public RcmpTransmit(byte microphoneSelection)
		{
			base.Opcode = 4;
			this.a = microphoneSelection;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00012E0C File Offset: 0x0001100C
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1544028161;
			if (num != 0)
			{
			}
			num = (short)641550097;
			short num2 = num;
			num = (short)1023952657;
			switch (num2 == num)
			{
			}
			num = (short)217251840;
			short num3 = num;
			num = (short)1351614464;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a
			});
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00012EE0 File Offset: 0x000110E0
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)173134293;
			short num2 = num;
			num = (short)1213714901;
			switch (num2 == num)
			{
			}
			num = (short)135725057;
			if (num != 0)
			{
			}
			num = (short)2020802560;
			short num3 = num;
			num = (short)40763392;
			if (num != 0)
			{
			}
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
		}

		// Token: 0x04000175 RID: 373
		private byte a;
	}
}
