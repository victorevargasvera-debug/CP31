using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000025 RID: 37
	public class XcmpTransferData : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00008D3C File Offset: 0x00006F3C
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00008DEC File Offset: 0x00006FEC
		public byte[] Data
		{
			get
			{
				short num = (short)1687058849;
				short num2 = num;
				num = (short)956201377;
				switch (num2 == num)
				{
				}
				num = (short)413138944;
				short num3 = num;
				num = (short)1974796289;
				if (num != 0)
				{
				}
				num = (short)974520320;
				if (num != 0)
				{
				}
				return this.d;
			}
			private set
			{
				short num = (short)130048211;
				short num2 = num;
				num = (short)106193107;
				switch (num2 == num)
				{
				}
				num = (short)2137915392;
				short num3 = num;
				num = (short)2047934465;
				if (num != 0)
				{
				}
				num = (short)952696832;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00008E9C File Offset: 0x0000709C
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00008F4C File Offset: 0x0000714C
		public ushort Length
		{
			get
			{
				short num = (short)748073153;
				short num2 = num;
				num = (short)1421127873;
				switch (num2 == num)
				{
				}
				num = (short)441712640;
				short num3 = num;
				num = (short)1248198657;
				if (num != 0)
				{
				}
				num = (short)1071775744;
				if (num != 0)
				{
				}
				return this.c;
			}
			private set
			{
				short num = (short)1973253746;
				short num2 = num;
				num = (short)212760178;
				switch (num2 == num)
				{
				}
				num = (short)295567360;
				short num3 = num;
				num = (short)577830912;
				if (num != 0)
				{
				}
				num = (short)380960769;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00008FF8 File Offset: 0x000071F8
		// (set) Token: 0x06000074 RID: 116 RVA: 0x000090A8 File Offset: 0x000072A8
		private ushort SeqNum
		{
			get
			{
				short num = (short)220827001;
				short num2 = num;
				num = (short)158764409;
				switch (num2 == num)
				{
				}
				num = (short)404946944;
				short num3 = num;
				num = (short)1999896577;
				if (num != 0)
				{
				}
				num = (short)554434560;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1340255917;
				short num2 = num;
				num = (short)1821879981;
				switch (num2 == num)
				{
				}
				num = (short)846594048;
				short num3 = num;
				num = (short)43450369;
				if (num != 0)
				{
				}
				num = (short)539688960;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00009158 File Offset: 0x00007358
		public XcmpTransferData(ushort Sequence, byte Type, ushort Length, byte[] Data)
		{
			base.Opcode = 1094;
			this.b = Sequence;
			this.a = Type;
			this.c = Length;
			this.d = Data;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00009194 File Offset: 0x00007394
		public static int RequestHeaderLength
		{
			get
			{
				short num = (short)84236071;
				short num2 = num;
				num = (short)881940263;
				switch (num2 == num)
				{
				}
				num = (short)1074724864;
				short num3 = num;
				num = (short)769654785;
				if (num != 0)
				{
				}
				num = (short)1585643520;
				if (num != 0)
				{
				}
				return 7;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00009240 File Offset: 0x00007440
		public static int ReplyHeaderLength
		{
			get
			{
				short num = (short)1919932298;
				short num2 = num;
				num = (short)936433546;
				switch (num2 == num)
				{
				}
				num = (short)226033664;
				short num3 = num;
				num = (short)92405761;
				if (num != 0)
				{
				}
				num = (short)247070720;
				if (num != 0)
				{
				}
				return 8;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000092EC File Offset: 0x000074EC
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1418526721;
			if (num != 0)
			{
			}
			if (this.d != null)
			{
				num = (short)843638873;
				short num2 = num;
				num = (short)775481433;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)288489472;
					if (num != 0)
					{
					}
					num = (short)1720844288;
					short num3 = num;
					return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
					{
						base.Opcode,
						this.a,
						this.b,
						this.c,
						this.d
					});
				}
				}
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a,
				this.b,
				this.c
			});
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00009434 File Offset: 0x00007634
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (length - 8 >= (int)this.c)
					{
						num2 = (short)1562247170;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
					num2 = (short)811204617;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)149487617;
					if (num2 != 0)
					{
					}
					if (length >= global::Motorola.Common.Communication.r.b() + 4)
					{
						num2 = (short)732626956;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					goto IL_E7;
				case 5:
					if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.TransferComplete)
					{
						goto IL_227;
					}
					return;
				case 6:
				{
					num2 = (short)1664604840;
					short num3 = num2;
					num2 = (short)1672796840;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_227;
					default:
						num2 = (short)1895825408;
						if (num2 != 0)
						{
						}
						this.d = new byte[(int)this.c];
						num2 = (short)1799749636;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 7:
					num2 = (short)532152325;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (this.d == null)
					{
						num2 = (short)1840447494;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E7;
				case 9:
					if (this.d.Length < length - 8)
					{
						num2 = (short)56033294;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BC;
				case 10:
					goto IL_129;
				case 11:
					if (base.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)1798569991;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_129;
				case 12:
				{
					num2 = (short)670236672;
					short num4 = num2;
					this.a = replyBuffer[offset + 3];
					this.b = (ushort)((int)replyBuffer[offset + 5] | (int)replyBuffer[offset + 4] << 8);
					this.c = (ushort)((int)replyBuffer[offset + 7] | (int)replyBuffer[offset + 6] << 8);
					num2 = (short)1608056840;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 13:
					goto IL_1BC;
				case 14:
					this.d = new byte[(int)this.c];
					num2 = (short)1066926093;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_4C;
				IL_E7:
				num2 = (short)59244544;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_129:
				num2 = (short)1139212291;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1BC:
				global::System.Array.Clear(this.d, 0, this.d.Length);
				global::System.Array.Copy(replyBuffer, offset + 8, this.d, 0, (int)this.c);
				num2 = (short)1643577345;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_227:
				num2 = (short)756088842;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_4C:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num2 = (short)355926027;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040000BA RID: 186
		private byte a;

		// Token: 0x040000BB RID: 187
		private ushort b;

		// Token: 0x040000BC RID: 188
		private ushort c;

		// Token: 0x040000BD RID: 189
		private byte[] d;

		// Token: 0x02000026 RID: 38
		public enum DataType : byte
		{
			// Token: 0x040000BF RID: 191
			None,
			// Token: 0x040000C0 RID: 192
			Nand,
			// Token: 0x040000C1 RID: 193
			FTL,
			// Token: 0x040000C2 RID: 194
			File,
			// Token: 0x040000C3 RID: 195
			Fxp,
			// Token: 0x040000C4 RID: 196
			CompressFile
		}
	}
}
