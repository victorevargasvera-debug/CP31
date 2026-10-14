using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000045 RID: 69
	public class RcmpReadRadioKey : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0000FFD0 File Offset: 0x0000E1D0
		public byte[] RadioKey
		{
			get
			{
				short num = (short)1082579152;
				short num2 = num;
				num = (short)878172368;
				switch (num2 == num)
				{
				default:
				{
					num = (short)227016704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)23920640;
				if (num != 0)
				{
				}
				num = (short)436404225;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00010080 File Offset: 0x0000E280
		private void a()
		{
			short num = (short)502136836;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)43319296;
					short num3 = num;
					int num4;
					if (num4 >= this.a.Length)
					{
						num = (short)634322949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.a[num4] = 0;
					num4++;
					num = (short)1934753794;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					IL_5C:
					int num4 = 0;
					num = (short)1503657987;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_61;
				case 3:
					goto IL_61;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 5:
					goto IL_10C;
				}
				IL_3C:
				if (this.a != null)
				{
					num = (short)532021249;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_10C:
				num = (short)1507985598;
				short num5 = num;
				num = (short)1950812350;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_5C;
				default:
					goto IL_140;
				}
				IL_61:
				num = (short)709885952;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_140:
			num = (short)1017380864;
			if (num != 0)
			{
			}
			num = (short)66387969;
			if (num != 0)
			{
			}
			this.a = null;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00010210 File Offset: 0x0000E410
		public RcmpReadRadioKey()
		{
			base.Opcode = 768;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00010230 File Offset: 0x0000E430
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)2038555434;
			short num2 = num;
			num = (short)1433723690;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1433272320;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1253900289;
			if (num != 0)
			{
			}
			num = (short)1070858240;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode
			});
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000102F8 File Offset: 0x0000E4F8
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)1070006273;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_43;
			}
			for (;;)
			{
				IL_31:
				int num2;
				switch (num2)
				{
				case 0:
					goto IL_12B;
				case 1:
					goto IL_BD;
				case 2:
				{
					object[] array = new object[]
					{
						new byte[32]
					};
					global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
					this.a = (byte[])array[0];
					num = (short)606339072;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_43;
			}
			IL_BD:
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				goto IL_C5;
			}
			IL_12B:
			num = (short)224854016;
			short num3 = num;
			return;
			IL_43:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | 32768);
			num = (short)1862473675;
			short num4 = num;
			num = (short)1245321163;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_C5:
				num = (short)866648066;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			default:
			{
				num = (short)671612928;
				if (num != 0)
				{
				}
				num = (short)1451950081;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0400014D RID: 333
		private byte[] a;
	}
}
