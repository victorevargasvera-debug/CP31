using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200004C RID: 76
	public class RcmpRemoteConnect : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600011C RID: 284 RVA: 0x00011838 File Offset: 0x0000FA38
		public RcmpRemoteConnect(ushort deviceID)
		{
			base.Opcode = 36;
			this.a = deviceID;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0001185C File Offset: 0x0000FA5C
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)711267221;
			short num2 = num;
			num = (short)504107925;
			switch (num2 == num)
			{
			}
			num = (short)1196425217;
			if (num != 0)
			{
			}
			num = (short)2069757952;
			short num3 = num;
			num = (short)1043988480;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a
			});
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0001192C File Offset: 0x0000FB2C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)1144198825;
			short num2 = num;
			num = (short)833164969;
			switch (num2 == num)
			{
			}
			num = (short)650379265;
			if (num != 0)
			{
			}
			num = (short)81461248;
			short num3 = num;
			num = (short)1986527232;
			if (num != 0)
			{
			}
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
		}

		// Token: 0x04000165 RID: 357
		private ushort a;
	}
}
