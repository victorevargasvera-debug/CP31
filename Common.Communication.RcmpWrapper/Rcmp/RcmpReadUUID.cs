using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000046 RID: 70
	public class RcmpReadUUID : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000106 RID: 262 RVA: 0x0001045C File Offset: 0x0000E65C
		public byte[] UUID
		{
			get
			{
				if (this.a == null)
				{
					short num = (short)1396545345;
					short num2 = num;
					num = (short)521705281;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1555103745;
						if (num != 0)
						{
						}
						num = (short)2130968576;
						short num3 = num;
						num = (short)633667584;
						if (num != 0)
						{
						}
						return null;
					}
					}
				}
				byte[] array = new byte[this.a.Length];
				global::System.Buffer.BlockCopy(this.a, 0, array, 0, this.a.Length);
				return array;
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00010538 File Offset: 0x0000E738
		public RcmpReadUUID()
		{
			base.Opcode = 18;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00010554 File Offset: 0x0000E754
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1373912909;
			short num2 = num;
			num = (short)934821709;
			switch (num2 == num)
			{
			default:
			{
				num = (short)458620928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1935998976;
			if (num != 0)
			{
			}
			num = (short)1828782081;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode
			});
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00010618 File Offset: 0x0000E818
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)518979588;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)493879297;
					if (num2 != 0)
					{
					}
					object[] array = new object[]
					{
						new byte[16]
					};
					global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
					this.a = (byte[])array[0];
					goto IL_D1;
				}
				case 2:
					goto IL_152;
				case 3:
					if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)749404160;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_152;
				case 4:
					if (length == global::Motorola.Common.Communication.r.b() + 16)
					{
						num2 = (short)1836580864;
						short num3 = num2;
						num2 = (short)2103115777;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_152;
				}
				goto IL_24;
				IL_D1:
				num2 = (short)153550850;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_152:
				num2 = (short)1509891206;
				short num4 = num2;
				num2 = (short)440081542;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D1;
				default:
					goto IL_187;
				}
			}
			IL_187:
			num2 = (short)1875509248;
			if (num2 != 0)
			{
			}
			return;
			IL_24:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num2 = (short)1615396867;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400014E RID: 334
		private byte[] a;
	}
}
