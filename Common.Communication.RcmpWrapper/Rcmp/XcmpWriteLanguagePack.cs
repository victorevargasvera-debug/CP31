using System;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000087 RID: 135
	public class XcmpWriteLanguagePack : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060001E7 RID: 487 RVA: 0x0001E174 File Offset: 0x0001C374
		public XcmpWriteLanguagePack(global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation operation, string languagePackID, byte[] languagePackPayloadUnit, bool bigEndianForPackID = false)
		{
			if (operation == global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation.AddLanguagePackStart)
			{
				if (string.IsNullOrEmpty(languagePackID))
				{
					goto IL_20;
				}
			}
			if (operation != global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation.AddLanguagePackUnit || languagePackPayloadUnit != null)
			{
				base.Opcode = 43;
				this.a = operation;
				this.b = languagePackID;
				this.c = languagePackPayloadUnit;
				this.d = bigEndianForPackID;
				base.ReadTimeout = 50000;
				return;
			}
			IL_20:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0001E1D8 File Offset: 0x0001C3D8
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)769327107;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.a == global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation.AddLanguagePackEnd)
					{
						num = (short)884146178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C5;
				case 1:
					goto IL_54;
				case 2:
					goto IL_113;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				IL_35:
				if (this.a == global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation.AddLanguagePackStart)
				{
					num = (short)881065985;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1937833984;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_54:
			byte[] array = new byte[16];
			global::System.Array.Clear(array, 0, array.Length);
			global::Motorola.Common.Communication.r.a(this.b, array, 0, this.d);
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				(byte)this.a,
				array,
				0
			});
			IL_113:
			num = (short)1767505920;
			short num3 = num;
			num = (short)781320193;
			if (num != 0)
			{
			}
			num = (short)1818879282;
			short num4 = num;
			num = (short)1654514994;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1C5:
				return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
				{
					base.Opcode,
					(byte)this.a,
					(ushort)this.c.Length,
					this.c
				});
			default:
				num = (short)1995177984;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
				{
					base.Opcode,
					(byte)this.a,
					0
				});
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0001E3F0 File Offset: 0x0001C5F0
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)1228132505;
			short num2 = num;
			num = (short)738906265;
			switch (num2 == num)
			{
			}
			num = (short)1087176704;
			if (num != 0)
			{
			}
			num = (short)1993146369;
			if (num != 0)
			{
			}
			num = (short)537067520;
			short num3 = num;
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | 32768);
		}

		// Token: 0x040002A2 RID: 674
		private global::Motorola.Common.Communication.Rcmp.LanguagePackControlOperation a;

		// Token: 0x040002A3 RID: 675
		private string b;

		// Token: 0x040002A4 RID: 676
		private byte[] c;

		// Token: 0x040002A5 RID: 677
		private bool d;
	}
}
