using System;
using Motorola.Common.Communication.Rcmp;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001E RID: 30
	public class XcmpNetworkInfConfig : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000059 RID: 89 RVA: 0x000077E4 File Offset: 0x000059E4
		public XcmpNetworkInfConfig(global::Motorola.Common.Communication.IPFunction function, byte ifIndex, string IPAddr, string SubnetMask, string GatewayIP)
		{
			int a_ = 7;
			base..ctor();
			base.Opcode = 1076;
			this.a = function;
			this.b = ifIndex;
			if (!string.IsNullOrEmpty(IPAddr) && !string.IsNullOrEmpty(SubnetMask))
			{
				if (!string.IsNullOrEmpty(GatewayIP))
				{
					this.c = this.a(IPAddr);
					this.d = this.a(SubnetMask);
					this.e = this.a(GatewayIP);
					return;
				}
			}
			throw new global::System.ArgumentException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("朗랖붜풠쾢즤", a_));
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00007878 File Offset: 0x00005A78
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1593380854;
			short num2 = num;
			num = (short)1990856694;
			switch (num2 == num)
			{
			}
			num = (short)1066729473;
			if (num != 0)
			{
			}
			num = (short)37814272;
			if (num != 0)
			{
			}
			num = (short)873267200;
			short num3 = num;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.a,
				this.b,
				this.c,
				this.d,
				this.e
			});
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00007984 File Offset: 0x00005B84
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			switch (0)
			{
			case 0:
				goto IL_4B;
			}
			short num;
			int num2;
			for (;;)
			{
				IL_0A:
				num = (short)508559361;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)910414364;
					short num3 = num;
					num = (short)1479332380;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_86;
					default:
						num = (short)1554120704;
						if (num != 0)
						{
						}
						this.a = (global::Motorola.Common.Communication.IPFunction)replyBuffer[offset + 3];
						this.b = replyBuffer[offset + 4];
						num = (short)55574532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					if (length >= global::Motorola.Common.Communication.r.b() + 3)
					{
						num = (short)91553792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						goto IL_86;
					}
					return;
				case 3:
				{
					num = (short)698548224;
					short num4 = num;
					num = (short)1600651265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					return;
				}
				goto IL_4B;
				IL_86:
				num = (short)1601110019;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_4B:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num = (short)1889533954;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00007B14 File Offset: 0x00005D14
		private uint a(string IPAddr)
		{
			int a_ = 1;
			short num = (short)698548224;
			switch (num)
			{
			default:
			{
				num = (short)1030291457;
				if (num != 0)
				{
				}
				num = (short)1775042562;
				int num2 = (int)((global::System.IntPtr)num);
				uint num5;
				for (;;)
				{
					int num4;
					string[] array;
					switch (num2)
					{
					case 0:
					{
						num = (short)435293829;
						short num3 = num;
						num = (short)885395077;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A2;
						default:
							goto IL_19A;
						}
						break;
					}
					case 1:
						if (num4 >= array.Length)
						{
							num = (short)640811008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A2;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_89;
						}
						continue;
					case 3:
						goto IL_100;
					case 4:
						goto IL_100;
					}
					goto IL_89;
					IL_A2:
					string value = array[num4];
					num5 = (num5 << 8) + global::System.Convert.ToUInt32(value, 10);
					num4++;
					num = (short)869597187;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_89:
					string[] array2 = IPAddr.Split(new char[]
					{
						'.'
					});
					if (array2.Length != 4)
					{
						break;
					}
					num5 = 0U;
					array = array2;
					num4 = 0;
					num = (short)202047492;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_100:
					num = (short)620298240;
					short num6 = num;
					num = (short)2014248961;
					num2 = (int)((global::System.IntPtr)num);
				}
				throw new global::System.ArgumentException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("쒌ﾎ놐ﮖﺚ붜튠莢쮤좦\udda8讪馬辮슰횲횴쎶킸풺펼첾", a_));
				IL_19A:
				num = (short)104660992;
				if (num != 0)
				{
				}
				return num5;
			}
			}
		}

		// Token: 0x04000081 RID: 129
		private global::Motorola.Common.Communication.IPFunction a;

		// Token: 0x04000082 RID: 130
		private byte b;

		// Token: 0x04000083 RID: 131
		private uint c;

		// Token: 0x04000084 RID: 132
		private uint d;

		// Token: 0x04000085 RID: 133
		private uint e;
	}
}
