using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x0200002D RID: 45
	public class RcmpBootWriteCommit : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000AEE8 File Offset: 0x000090E8
		public byte Status
		{
			get
			{
				short num = (short)582674883;
				short num2 = num;
				num = (short)689170883;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1565196288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)166854656;
				if (num != 0)
				{
				}
				num = (short)979107841;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000AF98 File Offset: 0x00009198
		public RcmpBootWriteCommit(global::Motorola.Common.Communication.Rcmp.BootCommitFunctionType function, uint[] ramAddress, uint[] flashAddress, uint[] payloadSize)
		{
			int a_ = 11;
			base..ctor();
			base.Opcode = 518;
			this.a = (byte)function;
			if (function != global::Motorola.Common.Communication.Rcmp.BootCommitFunctionType.QueryStatus)
			{
				if (ramAddress.Length != flashAddress.Length && ramAddress.Length != payloadSize.Length)
				{
					throw new global::System.ArgumentException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("\ude96펠욢욤펦覨쒬햮풰", a_));
				}
				int num = ramAddress.Length * 4 * 3;
				this.c = new byte[num];
				this.b = (byte)ramAddress.Length;
				for (int i = 0; i < ramAddress.Length; i++)
				{
					int num2;
					this.c[num2++] = (byte)(ramAddress[i] >> 24 & 255U);
					this.c[num2++] = (byte)(ramAddress[i] >> 16 & 255U);
					this.c[num2++] = (byte)(ramAddress[i] >> 8 & 255U);
					this.c[num2++] = (byte)(ramAddress[i] & 255U);
					this.c[num2++] = (byte)(flashAddress[i] >> 24 & 255U);
					this.c[num2++] = (byte)(flashAddress[i] >> 16 & 255U);
					this.c[num2++] = (byte)(flashAddress[i] >> 8 & 255U);
					this.c[num2++] = (byte)(flashAddress[i] & 255U);
					this.c[num2++] = (byte)(payloadSize[i] >> 24 & 255U);
					this.c[num2++] = (byte)(payloadSize[i] >> 16 & 255U);
					this.c[num2++] = (byte)(payloadSize[i] >> 8 & 255U);
					this.c[num2++] = (byte)(payloadSize[i] & 255U);
				}
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000B158 File Offset: 0x00009358
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			if (this.a == 1)
			{
				short num = (short)1266824156;
				short num2 = num;
				num = (short)1490629596;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A8;
				case 1:
					break;
				default:
				{
					num = (short)271384576;
					short num3 = num;
					break;
				}
				}
				num = (short)30408704;
				if (num != 0)
				{
				}
				num = (short)881459201;
				if (num != 0)
				{
				}
				IL_A8:
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
				this.b,
				this.c
			});
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000B278 File Offset: 0x00009478
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						object[] array = new object[]
						{
							global::Motorola.Common.Communication.r.b,
							global::Motorola.Common.Communication.r.b
						};
						global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
						this.d = (byte)array[1];
						num2 = (short)215140007;
						short num3 = num2;
						num2 = (short)578602663;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_36;
						default:
							num2 = (short)1085603841;
							if (num2 != 0)
							{
							}
							num2 = (short)1068892160;
							if (num2 != 0)
							{
							}
							num2 = (short)756219905;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						return;
					case 2:
					{
						num2 = (short)1926299648;
						short num4 = num2;
						if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num2 = (short)1400045568;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					}
					goto IL_1C;
				}
				return;
			}
			IL_1C:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			IL_36:
			num2 = (short)478478338;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040000E1 RID: 225
		private byte a;

		// Token: 0x040000E2 RID: 226
		private byte b;

		// Token: 0x040000E3 RID: 227
		private byte[] c;

		// Token: 0x040000E4 RID: 228
		private byte d;
	}
}
