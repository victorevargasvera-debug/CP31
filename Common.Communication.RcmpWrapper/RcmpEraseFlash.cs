using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000A RID: 10
	public class RcmpEraseFlash : global::Motorola.Common.Communication.RcmpBaseMessage, global::Motorola.Common.Communication.ISuperBundlerMessage
	{
		// Token: 0x0600002C RID: 44 RVA: 0x000054B4 File Offset: 0x000036B4
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)385941505;
			if (num != 0)
			{
			}
			num = (short)1775943543;
			short num2 = num;
			num = (short)1753530231;
			switch (num2 == num)
			{
			}
			num = (short)1554972672;
			short num3 = num;
			num = (short)664141824;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.b,
				this.a
			});
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00005598 File Offset: 0x00003798
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					object[] array = new object[]
					{
						global::Motorola.Common.Communication.r.d,
						global::Motorola.Common.Communication.r.d
					};
					global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
					this.b = (uint)array[0];
					this.a = (uint)array[1];
					num2 = (short)1917911041;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_122;
				case 2:
				{
					num2 = (short)739442688;
					short num3 = num2;
					num2 = (short)1821245441;
					if (num2 != 0)
					{
					}
					if (length > global::Motorola.Common.Communication.r.b())
					{
						num2 = (short)1635188736;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				}
				goto IL_1C;
			}
			IL_122:
			num2 = (short)1488173194;
			short num4 = num2;
			num2 = (short)1915598986;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1C:
				base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
				num2 = (short)680656898;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
				num2 = (short)93847552;
				if (num2 != 0)
				{
				}
				break;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00005714 File Offset: 0x00003914
		public int MaxMessageSize
		{
			get
			{
				short num = (short)890306561;
				if (num != 0)
				{
				}
				num = (short)2014642176;
				short num2 = num;
				num = (short)962274454;
				short num3 = num;
				num = (short)4596886;
				switch (num3 == num)
				{
				}
				num = (short)1566638080;
				if (num != 0)
				{
				}
				return 11;
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000057C4 File Offset: 0x000039C4
		public RcmpEraseFlash(uint startAddress, uint endAddress)
		{
			base.Opcode = 515;
			this.b = startAddress;
			this.a = endAddress;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000057F0 File Offset: 0x000039F0
		private uint EndAddress
		{
			get
			{
				short num = (short)2858642;
				short num2 = num;
				num = (short)1536073362;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1388773376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)339476480;
				if (num != 0)
				{
				}
				num = (short)1557856257;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000058A4 File Offset: 0x00003AA4
		private uint StartAddress
		{
			get
			{
				short num = (short)1281652613;
				short num2 = num;
				num = (short)591165317;
				switch (num2 == num)
				{
				default:
				{
					num = (short)63242240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)383582208;
				if (num != 0)
				{
				}
				num = (short)427491329;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x04000010 RID: 16
		private uint a;

		// Token: 0x04000011 RID: 17
		private uint b;
	}
}
