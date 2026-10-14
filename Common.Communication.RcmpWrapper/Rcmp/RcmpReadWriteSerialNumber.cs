using System;
using System.Text;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000049 RID: 73
	public class RcmpReadWriteSerialNumber : global::Motorola.Common.Communication.RcmpBaseMessage, global::Motorola.Common.Communication.ISuperBundlerMessage
	{
		// Token: 0x0600010F RID: 271 RVA: 0x00010DB0 File Offset: 0x0000EFB0
		public RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType operation, string serialNumber)
		{
			int a_ = 1;
			base..ctor();
			base.Opcode = 17;
			this.b = operation;
			if (serialNumber != null)
			{
				this.a = global::System.Text.Encoding.ASCII.GetBytes(serialNumber + global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("趌", a_));
				if (this.a.Length > 11)
				{
					throw new global::System.ArgumentException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("ﺌ朗ﮖ힘ﶞ쒠톢薤캦\udaa8讪솬삮\udfb0풲킴얶馸쾺햼\udebe꿀", a_) + 11.ToString() + global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("권", a_));
				}
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00010E44 File Offset: 0x0000F044
		public RcmpReadWriteSerialNumber(global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType operation, byte[] rawSerialNumber)
		{
			base.Opcode = 17;
			this.b = operation;
			if (rawSerialNumber != null)
			{
				this.a = new byte[rawSerialNumber.Length];
				rawSerialNumber.CopyTo(this.a, 0);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00010E88 File Offset: 0x0000F088
		public string SerialNumber
		{
			get
			{
				short num = (short)1216937985;
				if (num != 0)
				{
				}
				if (this.a == null)
				{
					num = (short)1930092705;
					short num2 = num;
					num = (short)1253695649;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)780861440;
						short num3 = num;
						num = (short)139460608;
						if (num != 0)
						{
						}
						return null;
					}
					}
				}
				int length = 10;
				int offset = 0;
				return global::System.Convert.ToBase64String(this.a, offset, length);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000112 RID: 274 RVA: 0x00010F4C File Offset: 0x0000F14C
		public byte[] SerialRawBytes
		{
			get
			{
				if (this.a != null)
				{
					short num = (short)1453914513;
					short num2 = num;
					num = (short)1591081361;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2039414785;
						if (num != 0)
						{
						}
						num = (short)837746688;
						short num3 = num;
						num = (short)1251344384;
						if (num != 0)
						{
						}
						byte[] array = new byte[this.a.Length];
						this.a.CopyTo(array, 0);
						return array;
					}
					}
				}
				return null;
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0001101C File Offset: 0x0000F21C
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			int a_ = 1;
			short num = (short)102629382;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1343225857;
					if (num != 0)
					{
					}
					if (this.a != null)
					{
						num = (short)2042953730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_74;
				case 1:
				{
					num = (short)526015607;
					short num3 = num;
					num = (short)487218295;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13B;
					default:
						num = (short)1060241408;
						if (num != 0)
						{
						}
						if (this.a == null)
						{
							num = (short)902365184;
							short num4 = num;
							num = (short)63766531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_234;
					}
					break;
				}
				case 2:
					goto IL_1C4;
				case 3:
					goto IL_11F;
				case 4:
					num = (short)809172992;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_15D;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					continue;
				case 7:
					goto IL_13B;
				}
				IL_4E:
				if (this.b % global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadESN == global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType.ReadRadioSerialNumber)
				{
					num = (short)833814532;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)449642503;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_74:
				num = (short)692387841;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_13B:
				if (this.a != null)
				{
					goto IL_74;
				}
				num = (short)315031557;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_11F:
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.b
			});
			IL_15D:
			throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("\ude8c朗ﮖ힘ﶞ쒠톢", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("첌ﶎ붜咽캠톢薤풦첨\ud9aa쒬캮\uddb0鎲\udbb4슶풸\ud9ba\ud8bc춾ꫂ뛄ꟈ뻊ꇌꏎ뗒뫔ꗖ律賚꿜뛞闠蛢엤꣦駨軪鿬軮藰髲髴駶諸", a_));
			IL_1C4:
			throw new global::System.ArgumentException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("\ude8c朗ﮖ힘ﶞ쒠톢", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("첌ﶎ붜咽캠톢薤풦첨\ud9aa쒬캮\uddb0鎲\udbb4슶풸\ud9ba\ud8bc춾ꫂ뛄ꟈ꓊만뿐ꛒ맔믖律뷚닜귞쇠뇢胤蛦跨쯪ꋬ鿮铰臲铴菶郸铺鏼賾", a_));
			IL_234:
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.b,
				this.a
			});
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00011290 File Offset: 0x0000F490
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
					goto IL_12E;
				case 1:
					goto IL_C2;
				case 2:
				{
					object[] array = new object[]
					{
						global::Motorola.Common.Communication.r.c
					};
					global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
					this.a = (byte[])array[0];
					num2 = (short)217513984;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			IL_C2:
			if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
			{
				goto IL_CA;
			}
			IL_12E:
			num2 = (short)1785266176;
			short num3 = num2;
			return;
			IL_1C:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num2 = (short)1538598512;
			short num4 = num2;
			num2 = (short)430057072;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_CA:
				num2 = (short)89522178;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)234160129;
				if (num2 != 0)
				{
				}
				num2 = (short)950075392;
				if (num2 != 0)
				{
				}
				num2 = (short)1106378753;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000115 RID: 277 RVA: 0x000113F8 File Offset: 0x0000F5F8
		public int MaxMessageSize
		{
			get
			{
				short num = (short)980484097;
				if (num != 0)
				{
				}
				num = (short)555024384;
				short num2 = num;
				num = (short)1563662722;
				short num3 = num;
				num = (short)1080203650;
				switch (num3 == num)
				{
				}
				num = (short)1369636864;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.r.b() + 11;
			}
		}

		// Token: 0x0400015F RID: 351
		private byte[] a;

		// Token: 0x04000160 RID: 352
		private global::Motorola.Common.Communication.Rcmp.SerialNumberOperationType b;

		// Token: 0x04000161 RID: 353
		private const int c = 11;
	}
}
