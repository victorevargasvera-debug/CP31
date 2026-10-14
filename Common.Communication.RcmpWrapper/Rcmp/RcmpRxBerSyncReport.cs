using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000051 RID: 81
	public class RcmpRxBerSyncReport : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000128 RID: 296 RVA: 0x00011F68 File Offset: 0x00010168
		public RcmpRxBerSyncReport(byte? slot)
		{
			base.Opcode = 23;
			this.b = slot;
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00011F8C File Offset: 0x0001018C
		private byte[] Report
		{
			get
			{
				short num = (short)1710890873;
				short num2 = num;
				num = (short)1208754041;
				switch (num2 == num)
				{
				}
				num = (short)1371930625;
				if (num != 0)
				{
				}
				num = (short)1565851648;
				short num3 = num;
				num = (short)476971008;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600012A RID: 298 RVA: 0x0001203C File Offset: 0x0001023C
		private byte? Slot
		{
			get
			{
				short num = (short)36863767;
				short num2 = num;
				num = (short)759463703;
				switch (num2 == num)
				{
				}
				num = (short)47382529;
				if (num != 0)
				{
				}
				num = (short)336789504;
				short num3 = num;
				num = (short)1330446336;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000120EC File Offset: 0x000102EC
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num;
			while (this.b != null)
			{
				num = (short)319908701;
				short num2 = num;
				num = (short)36793181;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					break;
				default:
				{
					num = (short)1461846016;
					short num3 = num;
					break;
				}
				}
				num = (short)1025310720;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
				{
					base.Opcode,
					this.b.Value
				});
			}
			num = (short)377225217;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode
			});
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000121F4 File Offset: 0x000103F4
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_73;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_13:
				num = (short)34427419;
				short num2 = num;
				num = (short)600527387;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)332464128;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						num = (short)91226114;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_A4;
					case 2:
						if (replyBuffer.Length >= offset + length)
						{
							num = (short)490733571;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F0;
					case 3:
						goto IL_1A1;
					}
					goto IL_73;
				}
				IL_A4:
				num = (short)713228289;
				if (num != 0)
				{
				}
				if (base.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
				{
					return;
				}
				num = (short)994574336;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_F0:
			num = (short)1015087104;
			short num4 = num;
			throw new global::System.ArgumentOutOfRangeException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("ﾒ練ﺘ", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("\uda92ﮔ爵슠힢薤쮦첨얪쪬\udbae\ud9b0鎲\udab4얶馸풺\udbbc\ud9be닀ꛂ뇄뿈꫊ꇌ뫎듐﷔룖뿘뷚껜뫞闠쏢커쟦藨軪菬裮藰鯲\udcf4ퟶ쟸\udbfa鿼諾最攂怄甆✈䜊栌愎瘐朒純", a_));
			IL_1A1:
			this.a = new byte[length - global::Motorola.Common.Communication.r.b()];
			global::System.Buffer.BlockCopy(replyBuffer, 3, this.a, 0, this.a.Length);
			return;
			IL_73:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num = (short)2490369;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x0400016D RID: 365
		private byte[] a;

		// Token: 0x0400016E RID: 366
		private byte? b;
	}
}
