using System;
using Motorola.Common.Communication.Rcmp;

namespace Motorola.Common.Communication
{
	// Token: 0x02000024 RID: 36
	public class XcmpRadioUpdateControl : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000068 RID: 104 RVA: 0x000086C8 File Offset: 0x000068C8
		public XcmpRadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction action)
		{
			this.d = 9;
			this.f = "";
			base..ctor();
			base.Opcode = 268;
			this.a = action;
			this.b = byte.MaxValue;
			this.c = byte.MaxValue;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00008718 File Offset: 0x00006918
		public XcmpRadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction action, byte type)
		{
			this.d = 9;
			this.f = "";
			base..ctor();
			base.Opcode = 268;
			this.a = action;
			this.c = type;
			this.b = byte.MaxValue;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00008764 File Offset: 0x00006964
		public XcmpRadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction action, byte[] resetPasswordBytes)
		{
			this.d = 9;
			this.f = "";
			base..ctor();
			base.Opcode = 268;
			this.a = action;
			this.h = 188;
			this.g = resetPasswordBytes;
			this.b = byte.MaxValue;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000087BC File Offset: 0x000069BC
		public XcmpRadioUpdateControl(global::Motorola.Common.Communication.UpdateControlAction action, ushort tg, string version)
		{
			int a_ = 8;
			this.d = 9;
			this.f = "";
			base..ctor();
			if (this.d != version.Length)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("솓ﲗﮙﮝ肟쮣좥\udca7\ud8a9쎫슭邯쒱톳쒵쮷펹펻킽듁ꗃ꫅뷇꿉", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("ﮙ벛즟\ud8a1솣蚥솧\ud9a9貫삭\udfaf욱钳펵즷쾹\uddbb튽뛁ꯃ", a_) + this.d.ToString());
			}
			base.Opcode = 268;
			this.a = action;
			this.e = tg;
			this.f = version;
			this.b = byte.MaxValue;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00008858 File Offset: 0x00006A58
		public byte Value
		{
			get
			{
				short num = (short)579896335;
				short num2 = num;
				num = (short)206996495;
				switch (num2 == num)
				{
				}
				num = (short)97320961;
				if (num != 0)
				{
				}
				num = (short)1897332736;
				short num3 = num;
				num = (short)1803091968;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00008908 File Offset: 0x00006B08
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1468137476;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.a == global::Motorola.Common.Communication.UpdateControlAction.PasswordReset)
					{
						num = (short)2075918341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2019819521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1167706208;
					short num3 = num;
					num = (short)1161087072;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1565523969;
						if (num != 0)
						{
						}
						num = (short)513212416;
						if (num != 0)
						{
						}
						if (this.c == 255)
						{
							goto IL_23B;
						}
						break;
					}
					num = (short)1518993410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_112;
				case 3:
					goto IL_5F;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 5:
					goto IL_236;
				}
				IL_3D:
				if (this.a == global::Motorola.Common.Communication.UpdateControlAction.SetDownloadTGVersion)
				{
					num = (short)339607555;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1487667200;
					short num4 = num;
					num = (short)1734934528;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_5F:
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.a,
				this.e,
				this.f
			});
			IL_112:
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.a,
				this.c
			});
			IL_236:
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.a,
				this.h,
				this.g
			});
			IL_23B:
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.a
			});
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00008B7C File Offset: 0x00006D7C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					num2 = (short)1511984493;
					short num3 = num2;
					num2 = (short)308415853;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15A;
					default:
					{
						num2 = (short)2075262977;
						if (num2 != 0)
						{
						}
						num2 = (short)1829765120;
						if (num2 != 0)
						{
						}
						num2 = (short)488570880;
						short num4 = num2;
						if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
						{
							num2 = (short)783417348;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					}
					break;
				}
				case 2:
				{
					object[] array = new object[]
					{
						global::Motorola.Common.Communication.r.b,
						global::Motorola.Common.Communication.r.b
					};
					global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
					this.a = (global::Motorola.Common.Communication.UpdateControlAction)array[0];
					this.b = (byte)array[1];
					goto IL_15A;
				}
				case 3:
					if (length == global::Motorola.Common.Communication.r.b() + 2)
					{
						num2 = (short)858718210;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					num2 = (short)1927479299;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_15A:
				num2 = (short)343670784;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_24:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num2 = (short)1319698433;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040000B2 RID: 178
		private global::Motorola.Common.Communication.UpdateControlAction a;

		// Token: 0x040000B3 RID: 179
		private byte b;

		// Token: 0x040000B4 RID: 180
		private byte c;

		// Token: 0x040000B5 RID: 181
		private int d;

		// Token: 0x040000B6 RID: 182
		private ushort e;

		// Token: 0x040000B7 RID: 183
		private string f;

		// Token: 0x040000B8 RID: 184
		private byte[] g;

		// Token: 0x040000B9 RID: 185
		private ushort h;
	}
}
