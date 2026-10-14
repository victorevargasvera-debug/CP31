using System;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000080 RID: 128
	public class RcmpReadWriteCodeplugAttribute : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060001C7 RID: 455 RVA: 0x0001B9B8 File Offset: 0x00019BB8
		public RcmpReadWriteCodeplugAttribute(byte operation, byte attribute, byte[] attributeData)
		{
			base.Opcode = 55;
			this.a = operation;
			this.b = attribute;
			this.c = 0;
			if (attributeData != null)
			{
				this.c = (byte)attributeData.Length;
				this.d = new byte[attributeData.Length];
				attributeData.CopyTo(this.d, 0);
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0001BA14 File Offset: 0x00019C14
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			int a_ = 2;
			short num = (short)951386112;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2031812609;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_7C;
					}
					continue;
				case 1:
					num = (short)1890779142;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)935995881;
					short num3 = num;
					num = (short)171256297;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_26B;
					default:
						num = (short)1182203904;
						if (num != 0)
						{
						}
						num = (short)300875783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_149;
				case 4:
					goto IL_26B;
				case 5:
					if (this.d == null)
					{
						num = (short)1317994505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_291;
				case 6:
					if (this.d == null)
					{
						num = (short)1494220803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_218;
				case 7:
					if (this.d != null)
					{
						num = (short)1691680776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_218;
				case 8:
					goto IL_213;
				case 9:
					goto IL_24E;
				}
				IL_7C:
				if (this.a == 1)
				{
					num = (short)1739587586;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1542651908;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_218:
				num = (short)1491730437;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_26B:
				if (this.a != 2)
				{
					goto IL_218;
				}
				num = (short)1884291073;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_149:
			throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("쾍ﾕ流ﮝ肟얣튥즧", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("쾍ﮕﶗ뺝욟춡횣蚥쮧\udaa9貫쾭쒯욱욳\udfb5\udab7쾹좻\udbbdꯁ럃ꛇ뿉ꃋꋍ듑믓ꓕ跙껛럝铟蟡쓣ꧥ飧迩黫迭蓯鯱鯳飵请", a_));
			IL_213:
			num = (short)1192427520;
			short num4 = num;
			throw new global::System.ArgumentException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("쾍ﾕ流ﮝ肟얣튥즧", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("쾍ﮕﶗ뺝욟춡횣蚥쮧\udaa9貫쾭쒯욱욳\udfb5\udab7쾹좻\udbbdꯁ럃ꛇꗉ룋뻏ꟑ룓뫕볙돛곝샟냡臣蟥賧쫩ꏫ黭闯胱闳苵釷闹鋻跽", a_));
			IL_24E:
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a,
				this.b,
				this.c
			});
			IL_291:
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a,
				this.b,
				this.c,
				this.d
			});
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0001BD00 File Offset: 0x00019F00
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)1898974903;
			short num2 = num;
			num = (short)1890455223;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_152:
				num = (short)571146240;
				short num3 = num;
				num = (short)524419074;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)226885632;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				break;
			}
			for (;;)
			{
				IL_54:
				switch (num4)
				{
				case 0:
					if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num = (short)133890049;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_DC;
				case 2:
					return;
				}
				goto IL_66;
			}
			IL_DC:
			object[] array = new object[]
			{
				global::Motorola.Common.Communication.r.b,
				global::Motorola.Common.Communication.r.b,
				global::Motorola.Common.Communication.r.b,
				global::Motorola.Common.Communication.r.c
			};
			global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
			this.a = (byte)array[0];
			this.b = (byte)array[1];
			this.c = (byte)array[2];
			this.d = (byte[])array[3];
			goto IL_152;
			IL_66:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num = (short)1665990657;
			if (num != 0)
			{
			}
			num = (short)1580990464;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_54;
		}

		// Token: 0x04000288 RID: 648
		private byte a;

		// Token: 0x04000289 RID: 649
		private byte b;

		// Token: 0x0400028A RID: 650
		private byte c;

		// Token: 0x0400028B RID: 651
		private byte[] d;
	}
}
