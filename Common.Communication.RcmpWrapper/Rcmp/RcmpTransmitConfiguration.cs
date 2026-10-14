using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000055 RID: 85
	public class RcmpTransmitConfiguration : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000139 RID: 313 RVA: 0x00012FA0 File Offset: 0x000111A0
		public RcmpTransmitConfiguration(byte source, ushort? code)
		{
			base.Opcode = 2;
			this.a = source;
			this.b = code;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00012FC8 File Offset: 0x000111C8
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			while (this.b == null)
			{
				short num = (short)104385915;
				short num2 = num;
				num = (short)839568763;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)1482686464;
					short num3 = num;
					break;
				}
				}
				num = (short)53673984;
				if (num != 0)
				{
				}
				num = (short)1348141057;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
				{
					base.Opcode,
					this.a
				});
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a,
				this.b.Value
			});
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000130E8 File Offset: 0x000112E8
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)1905424546;
			short num2 = num;
			num = (short)1028421794;
			switch (num2 == num)
			{
			}
			num = (short)1331167233;
			if (num != 0)
			{
			}
			num = (short)1592197120;
			short num3 = num;
			num = (short)923860992;
			if (num != 0)
			{
			}
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, global::Motorola.Common.Communication.r.a() | base.Opcode);
		}

		// Token: 0x04000176 RID: 374
		private byte a;

		// Token: 0x04000177 RID: 375
		private ushort? b;
	}
}
