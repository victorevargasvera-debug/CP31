using System;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000058 RID: 88
	public class RcmpUnlockSecurity : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000142 RID: 322 RVA: 0x00013550 File Offset: 0x00011750
		public RcmpUnlockSecurity(byte[] radioKey)
		{
			if (radioKey == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			}
			base.Opcode = 769;
			this.a = radioKey;
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00013584 File Offset: 0x00011784
		private byte[] RadioKey
		{
			get
			{
				short num = (short)2024518871;
				short num2 = num;
				num = (short)2044703959;
				switch (num2 == num)
				{
				}
				num = (short)2044329985;
				if (num != 0)
				{
				}
				num = (short)1994850304;
				short num3 = num;
				num = (short)1689124864;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00013630 File Offset: 0x00011830
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			int a_ = 13;
			short num;
			if (this.a == null)
			{
				for (;;)
				{
					num = (short)408254830;
					short num2 = num;
					num = (short)826898798;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_4B;
					}
				}
				IL_4B:
				num = (short)188219393;
				if (num != 0)
				{
				}
				num = (short)707067904;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("쮘漢列캠삤\udea6", a_));
			}
			num = (short)281935872;
			short num3 = num;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a
			});
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00013728 File Offset: 0x00011928
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)75756082;
			short num2 = num;
			num = (short)1275851314;
			switch (num2 == num)
			{
			}
			num = (short)1840119808;
			if (num != 0)
			{
			}
			num = (short)301531136;
			short num3 = num;
			num = (short)1729691649;
			if (num != 0)
			{
			}
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | 32768);
		}

		// Token: 0x0400017C RID: 380
		private byte[] a;
	}
}
