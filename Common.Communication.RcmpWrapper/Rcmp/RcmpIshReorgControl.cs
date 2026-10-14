using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000037 RID: 55
	public class RcmpIshReorgControl : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000C674 File Offset: 0x0000A874
		private byte Action
		{
			get
			{
				short num = (short)1480679426;
				short num2 = num;
				num = (short)1338466306;
				switch (num2 == num)
				{
				}
				num = (short)1999896577;
				if (num != 0)
				{
				}
				num = (short)872873984;
				if (num != 0)
				{
				}
				num = (short)66912256;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000C724 File Offset: 0x0000A924
		private byte LogicalPartition
		{
			get
			{
				short num = (short)67621319;
				short num2 = num;
				num = (short)1284755911;
				switch (num2 == num)
				{
				}
				num = (short)2101018625;
				if (num != 0)
				{
				}
				num = (short)1457979392;
				if (num != 0)
				{
				}
				num = (short)767754240;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000C7D4 File Offset: 0x0000A9D4
		public RcmpIshReorgControl(byte partition, byte action)
		{
			base.Opcode = 263;
			this.b = partition;
			this.a = action;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000C800 File Offset: 0x0000AA00
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1458307073;
			if (num != 0)
			{
			}
			num = (short)2132415219;
			short num2 = num;
			num = (short)1064702707;
			switch (num2 == num)
			{
			}
			num = (short)746127360;
			if (num != 0)
			{
			}
			num = (short)1519517696;
			short num3 = num;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.b,
				this.a
			});
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000C8E4 File Offset: 0x0000AAE4
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)698006858;
			short num2 = num;
			num = (short)1966390602;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_129:
				num = (short)804323329;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_60;
			default:
			{
				num = (short)688979968;
				short num4 = num;
				goto IL_60;
			}
			}
			for (;;)
			{
				IL_7F:
				num = (short)1793851393;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
					if (length > global::Motorola.Common.Communication.r.b())
					{
						num = (short)2105409538;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
					goto IL_107;
				}
				goto IL_B8;
			}
			IL_107:
			this.b = replyBuffer[offset + global::Motorola.Common.Communication.r.b()];
			this.a = replyBuffer[offset + global::Motorola.Common.Communication.r.b() + 1];
			goto IL_129;
			IL_60:
			num = (short)2086141952;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_B8;
			}
			goto IL_7F;
			IL_B8:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num = (short)180092928;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7F;
		}

		// Token: 0x04000101 RID: 257
		private byte a;

		// Token: 0x04000102 RID: 258
		private byte b;

		// Token: 0x02000038 RID: 56
		public enum Actions
		{
			// Token: 0x04000104 RID: 260
			Deep,
			// Token: 0x04000105 RID: 261
			Normal
		}
	}
}
