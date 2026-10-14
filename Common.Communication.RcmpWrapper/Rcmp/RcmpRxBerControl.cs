using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000050 RID: 80
	public class RcmpRxBerControl : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000125 RID: 293 RVA: 0x00011D58 File Offset: 0x0000FF58
		public RcmpRxBerControl(byte operation, byte? frameCount)
		{
			base.Opcode = 22;
			this.a = operation;
			this.b = frameCount;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00011D84 File Offset: 0x0000FF84
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			while (this.b != null)
			{
				short num = (short)190755063;
				short num2 = num;
				num = (short)1126150391;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)1552482304;
					short num3 = num;
					break;
				}
				}
				num = (short)1157627905;
				if (num != 0)
				{
				}
				num = (short)1318715392;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
				{
					base.Opcode,
					this.a,
					this.b.Value
				});
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a
			});
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00011EA4 File Offset: 0x000100A4
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)713512912;
			short num2 = num;
			num = (short)215701456;
			switch (num2 == num)
			{
			}
			num = (short)1390346240;
			if (num != 0)
			{
			}
			num = (short)1862795264;
			short num3 = num;
			num = (short)1084882945;
			if (num != 0)
			{
			}
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
		}

		// Token: 0x0400016B RID: 363
		private byte a;

		// Token: 0x0400016C RID: 364
		private byte? b;
	}
}
