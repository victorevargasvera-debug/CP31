using System;
using Motorola.Common.Communication.Rcmp;

namespace Motorola.Common.Communication
{
	// Token: 0x02000011 RID: 17
	public class RcmpWriteMemory : global::Motorola.Common.Communication.RcmpBaseMessage, global::Motorola.Common.Communication.ISuperBundlerMessage
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00006C5C File Offset: 0x00004E5C
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)314456836;
			short num2 = num;
			num = (short)1037449988;
			switch (num2 == num)
			{
			default:
			{
				num = (short)472973312;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1392181249;
			if (num != 0)
			{
			}
			num = (short)1804140544;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.b,
				this.a,
				this.c
			});
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00006D48 File Offset: 0x00004F48
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1996292096;
					short num3 = num2;
					num2 = (short)2083848193;
					if (num2 != 0)
					{
					}
					if (length > global::Motorola.Common.Communication.r.b())
					{
						num2 = (short)1466302466;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 1:
					return;
				case 2:
				{
					num2 = (short)97821762;
					short num4 = num2;
					num2 = (short)1172874306;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)845873152;
						if (num2 != 0)
						{
						}
						object[] array = new object[]
						{
							global::Motorola.Common.Communication.r.d,
							global::Motorola.Common.Communication.r.a
						};
						global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
						this.b = (uint)array[0];
						this.a = (ushort)array[1];
						num2 = (short)475856897;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num2 = (short)1951072256;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00006EC0 File Offset: 0x000050C0
		public int MaxMessageSize
		{
			get
			{
				short num = (short)1123162195;
				short num2 = num;
				num = (short)1779177555;
				switch (num2 == num)
				{
				default:
				{
					num = (short)811073536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)644546560;
				if (num != 0)
				{
				}
				num = (short)921370625;
				if (num != 0)
				{
				}
				return 9;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00006F6C File Offset: 0x0000516C
		public RcmpWriteMemory(uint address, ushort byteCount, byte[] byteData)
		{
			int a_ = 15;
			base..ctor();
			base.Opcode = 514;
			if (byteData == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("連쒠쒤펦좨", a_));
			}
			if ((int)byteCount != byteData.Length)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("連쒠쪤튦잨\udfaa", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("ﾚﲜ삠莢횤캦펨캪趬욮슰鎲\udbb4\ud8b6춸鮺\ud8bc캾듀ꋂ꧄뷈꓊귎꣐꟒냔铖뛘껚돜ꯞ", a_));
			}
			this.b = address;
			this.a = byteCount;
			this.c = byteData;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00006FEC File Offset: 0x000051EC
		private uint Address
		{
			get
			{
				short num = (short)208484492;
				short num2 = num;
				num = (short)299120780;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1608908800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1776943105;
				if (num != 0)
				{
				}
				num = (short)681246720;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000051 RID: 81 RVA: 0x0000709C File Offset: 0x0000529C
		private ushort ByteCount
		{
			get
			{
				short num = (short)493846062;
				short num2 = num;
				num = (short)448233006;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1077542912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)286326785;
				if (num != 0)
				{
				}
				num = (short)2116485120;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x0400004B RID: 75
		private ushort a;

		// Token: 0x0400004C RID: 76
		private uint b;

		// Token: 0x0400004D RID: 77
		private byte[] c;
	}
}
