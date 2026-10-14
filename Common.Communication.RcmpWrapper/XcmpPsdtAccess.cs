using System;
using System.Text;
using Motorola.Common.Communication.Rcmp;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001F RID: 31
	public class XcmpPsdtAccess : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00007CD4 File Offset: 0x00005ED4
		public XcmpPsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction action)
		{
			base.Opcode = 267;
			this.a = action;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00007CFC File Offset: 0x00005EFC
		public XcmpPsdtAccess(global::Motorola.Common.Communication.PsdtAccessAction action, string psdtSrcSectionId, string psdtTgtSectionId)
		{
			int a_ = 19;
			this..ctor(action);
			this.b = global::System.Text.Encoding.ASCII.GetBytes(psdtSrcSectionId);
			this.c = global::System.Text.Encoding.ASCII.GetBytes(psdtTgtSectionId);
			if (this.b.Length <= 4)
			{
				if (this.c.Length <= 4)
				{
					return;
				}
			}
			throw new global::System.ArgumentException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("쾞螦삨\ud8aa趬쎮\udeb0\uddb2튴튶쮸鮺즼ힾꃀ귂", a_) + 4.ToString() + global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("뾞쎠\udaa2톤슦\udaa8", a_));
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00007D88 File Offset: 0x00005F88
		public uint PsdtAddress
		{
			get
			{
				short num = (short)1894797156;
				short num2 = num;
				num = (short)1471696740;
				switch (num2 == num)
				{
				}
				num = (short)260505601;
				if (num != 0)
				{
				}
				num = (short)1397948416;
				short num3 = num;
				num = (short)508362752;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00007E38 File Offset: 0x00006038
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1154429171;
			short num2 = num;
			num = (short)2025730291;
			switch (num2 == num)
			{
			}
			num = (short)1536425984;
			if (num != 0)
			{
			}
			num = (short)631111680;
			short num3 = num;
			num = (short)484311041;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.a,
				this.b,
				this.c
			});
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00007F1C File Offset: 0x0000611C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)1369636864;
			short num2 = num;
			num = (short)1076636850;
			short num3 = num;
			num = (short)364194994;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_19B:
				num = (short)435879936;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1900675072;
				if (num != 0)
				{
				}
				num = (short)1736769536;
				num4 = (int)num;
				switch (num4)
				{
				default:
					num = (short)292487169;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_106;
					}
					break;
				}
				break;
			}
			for (;;)
			{
				IL_C3:
				object[] array;
				switch (num4)
				{
				case 0:
					if (this.a == global::Motorola.Common.Communication.PsdtAccessAction.GetEndAddress)
					{
						num = (short)1081802763;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num = (short)1444544519;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
				{
					int num5 = 0;
					num = (short)242548750;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					return;
				case 4:
					goto IL_383;
				case 5:
				{
					int num5;
					if (num5 >= 4)
					{
						num = (short)1801322504;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.c[num5] = (byte)array[num5 + 5];
					num5++;
					num = (short)2109865996;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_19B;
				case 7:
				{
					array = new object[]
					{
						global::Motorola.Common.Communication.r.b,
						global::Motorola.Common.Communication.r.b,
						global::Motorola.Common.Communication.r.b,
						global::Motorola.Common.Communication.r.b,
						global::Motorola.Common.Communication.r.b,
						global::Motorola.Common.Communication.r.b,
						global::Motorola.Common.Communication.r.b,
						global::Motorola.Common.Communication.r.b,
						global::Motorola.Common.Communication.r.b
					};
					global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
					this.a = (global::Motorola.Common.Communication.PsdtAccessAction)array[0];
					int num6 = 0;
					num = (short)1815281674;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					num = (short)1685389325;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
				{
					int num6;
					if (num6 >= 4)
					{
						num = (short)1961492482;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.b[num6] = (byte)array[num6 + 1];
					num6++;
					num = (short)1591476228;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					goto IL_383;
				case 11:
					goto IL_317;
				case 12:
					goto IL_2DA;
				case 13:
					if (this.a != global::Motorola.Common.Communication.PsdtAccessAction.GetStartAddress)
					{
						num = (short)1702559750;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_317;
				case 14:
					goto IL_2DA;
				}
				goto IL_106;
				IL_2DA:
				num = (short)767754245;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_317:
				int num7 = global::Motorola.Common.Communication.r.b() + 9;
				array = new object[]
				{
					global::Motorola.Common.Communication.r.d
				};
				global::Motorola.Common.Communication.r.a(replyBuffer, offset + num7, length - num7, array);
				this.d = (uint)array[0];
				num = (short)1420165123;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_383:
				num = (short)50855945;
				num4 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_106:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num = (short)458817537;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_C3;
		}

		// Token: 0x04000086 RID: 134
		private global::Motorola.Common.Communication.PsdtAccessAction a;

		// Token: 0x04000087 RID: 135
		private byte[] b;

		// Token: 0x04000088 RID: 136
		private byte[] c;

		// Token: 0x04000089 RID: 137
		private uint d;

		// Token: 0x0400008A RID: 138
		private const uint e = 1U;

		// Token: 0x0400008B RID: 139
		private const uint f = 2U;

		// Token: 0x0400008C RID: 140
		private const int g = 4;
	}
}
