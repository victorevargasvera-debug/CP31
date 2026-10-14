using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001C RID: 28
	public class XcmpConnectivityTest : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00007150 File Offset: 0x00005350
		public XcmpConnectivityTest(global::Motorola.Common.Communication.ConnectFunction function, ushort length, byte[] data) : this((byte)function, length, data)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00007168 File Offset: 0x00005368
		private XcmpConnectivityTest(byte A_0, ushort A_1, byte[] A_2)
		{
			base.Opcode = 48;
			this.a = A_0;
			this.b = A_1;
			this.c = A_2;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00007198 File Offset: 0x00005398
		public byte ConnectFunction
		{
			get
			{
				short num = (short)621937660;
				short num2 = num;
				num = (short)449512444;
				switch (num2 == num)
				{
				default:
				{
					num = (short)585498624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1595932673;
				if (num != 0)
				{
				}
				num = (short)1142292480;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00007248 File Offset: 0x00005448
		public ushort FunctionDataLength
		{
			get
			{
				short num = (short)921647554;
				short num2 = num;
				num = (short)108542402;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1869414400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)702021633;
				if (num != 0)
				{
				}
				num = (short)689569792;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000072F8 File Offset: 0x000054F8
		private byte[] FunctionData
		{
			get
			{
				short num = (short)957980756;
				short num2 = num;
				num = (short)2080219220;
				switch (num2 == num)
				{
				default:
				{
					num = (short)979238912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2010906625;
				if (num != 0)
				{
				}
				num = (short)1739390976;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000073A8 File Offset: 0x000055A8
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)682600756;
			short num2 = num;
			num = (short)1527556404;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)430571520;
				short num3 = num;
				num = (short)1423507457;
				if (num != 0)
				{
				}
				num = (short)817823744;
				if (num != 0)
				{
				}
				if (this.c != null)
				{
					return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
					{
						base.Opcode,
						this.a,
						this.b,
						this.c
					});
				}
				break;
			}
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a,
				this.b
			});
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000074D4 File Offset: 0x000056D4
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_220;
					case 1:
					{
						num2 = (short)1622149311;
						short num3 = num2;
						num2 = (short)1909196991;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1501757441;
							if (num2 != 0)
							{
							}
							num2 = (short)1612447744;
							if (num2 != 0)
							{
							}
							if (this.c.Length != (int)this.b)
							{
								num2 = (short)1633288201;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_220;
						}
						break;
					}
					case 2:
						if (length >= global::Motorola.Common.Communication.r.b() + 3)
						{
							num2 = (short)76808203;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 3:
					{
						num2 = (short)537001984;
						short num4 = num2;
						num2 = (short)1053229057;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 4:
						if (this.c == null)
						{
							num2 = (short)1746403333;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_17E;
					case 5:
						this.c = new byte[(int)this.b];
						num2 = (short)1889468426;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num2 = (short)2048917512;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 7:
						if (length - 6 >= (int)this.b)
						{
							num2 = (short)2106916867;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 8:
						num2 = (short)1596063746;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 9:
						this.c = new byte[(int)this.b];
						num2 = (short)854851584;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 10:
						goto IL_17E;
					case 11:
						this.a = replyBuffer[offset + 3];
						this.b = (ushort)((int)replyBuffer[offset + 5] | (int)replyBuffer[offset + 4] << 8);
						num2 = (short)181796868;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 12:
						return;
					}
					break;
					IL_17E:
					num2 = (short)412614663;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_220:
					global::System.Array.Clear(this.c, 0, this.c.Length);
					global::System.Array.Copy(replyBuffer, offset + 6, this.c, 0, (int)this.b);
					num2 = (short)393228;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_44:
				base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
				num2 = (short)1261305862;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x0400007B RID: 123
		private byte a;

		// Token: 0x0400007C RID: 124
		private ushort b;

		// Token: 0x0400007D RID: 125
		private byte[] c;
	}
}
