using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000044 RID: 68
	public class RcmpReadMemory : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000FB78 File Offset: 0x0000DD78
		private uint Address
		{
			get
			{
				short num = (short)30173308;
				short num2 = num;
				num = (short)1229154428;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1178009600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)651296769;
				if (num != 0)
				{
				}
				num = (short)425984000;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000FC2C File Offset: 0x0000DE2C
		public byte[] ByteData
		{
			get
			{
				short num = (short)1374659269;
				short num2 = num;
				num = (short)1334158021;
				switch (num2 == num)
				{
				default:
				{
					num = (short)197722112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1123942401;
				if (num != 0)
				{
				}
				num = (short)516882432;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000FCDC File Offset: 0x0000DEDC
		public RcmpReadMemory(uint address, ushort byteCount)
		{
			base.Opcode = 513;
			this.a = address;
			this.b = byteCount;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000FD08 File Offset: 0x0000DF08
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1268595107;
			short num2 = num;
			num = (short)1306605987;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1891303424;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)828506112;
			if (num != 0)
			{
			}
			num = (short)616235009;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a,
				this.b
			});
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000FDE8 File Offset: 0x0000DFE8
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_1D6;
				case 1:
				{
					num2 = (short)1633484800;
					short num3 = num2;
					object[] array = new object[]
					{
						global::Motorola.Common.Communication.r.d,
						global::Motorola.Common.Communication.r.a,
						global::Motorola.Common.Communication.r.c
					};
					global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
					this.a = (uint)array[0];
					this.b = (ushort)array[1];
					this.c = (byte[])array[2];
					num2 = (short)1620508675;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					num2 = (short)458487424;
					short num4 = num2;
					num2 = (short)1352398464;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_ED;
					default:
						num2 = (short)1893335040;
						if (num2 != 0)
						{
						}
						if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num2 = (short)1413283841;
							if (num2 != 0)
							{
							}
							num2 = (short)1977286657;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 3:
					if (this.c.Length != (int)this.b)
					{
						num2 = (short)1645674496;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_29;
			}
			IL_ED:
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("횔", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("떔뾞좠킢薤즦욨\udfaa趬쪮산욲풴\udbb6馸쾺튼龾ꏀ뫂뇄ꋆ諈꓊료ꇎꗐ", a_));
			IL_1D6:
			goto IL_ED;
			IL_29:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num2 = (short)409468930;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0400014A RID: 330
		private uint a;

		// Token: 0x0400014B RID: 331
		private ushort b;

		// Token: 0x0400014C RID: 332
		private byte[] c;
	}
}
