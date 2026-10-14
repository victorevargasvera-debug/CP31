using System;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000089 RID: 137
	public class XcmpWriteTTSLanguagePack : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x060001EA RID: 490 RVA: 0x0001E4B8 File Offset: 0x0001C6B8
		public XcmpWriteTTSLanguagePack(global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation operation, string languagePackID, byte[] languagePackPayloadUnit, bool bigEndianForPackID = false)
		{
			if (operation == global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation.AddTTSLanguagePackStart)
			{
				if (string.IsNullOrEmpty(languagePackID))
				{
					goto IL_23;
				}
			}
			if (operation != global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation.AddTTSLanguagePackUnit || languagePackPayloadUnit != null)
			{
				base.Opcode = 43;
				this.a = operation;
				this.b = languagePackID;
				this.c = languagePackPayloadUnit;
				this.d = bigEndianForPackID;
				return;
			}
			IL_23:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.InvalidArgument);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0001E514 File Offset: 0x0001C714
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)1650327555;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.a == global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation.AddTTSLanguagePackEnd)
					{
						num = (short)1459421186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C6;
				case 1:
					goto IL_57;
				case 2:
					goto IL_115;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_36;
					}
					continue;
				}
				IL_36:
				if (this.a == global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation.AddTTSLanguagePackStart)
				{
					num = (short)2067202049;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1031471104;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_57:
			num = (short)1732050945;
			if (num != 0)
			{
			}
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
			IL_115:
			num = (short)244711424;
			short num3 = num;
			num = (short)1724596165;
			short num4 = num;
			num = (short)628965317;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1C6:
				return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
				{
					base.Opcode,
					(byte)this.a,
					(ushort)this.c.Length,
					this.c
				});
			default:
				num = (short)751501312;
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

		// Token: 0x060001EC RID: 492 RVA: 0x0001E72C File Offset: 0x0001C92C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)811678560;
			short num2 = num;
			num = (short)1200569184;
			switch (num2 == num)
			{
			}
			num = (short)477822977;
			if (num != 0)
			{
			}
			num = (short)1938620416;
			if (num != 0)
			{
			}
			num = (short)1129512960;
			short num3 = num;
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | 32768);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0001E7F0 File Offset: 0x0001C9F0
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1641939234 + A_1) + (global::System.IntPtr)63 + (global::System.IntPtr)5 + (global::System.IntPtr)10 + (global::System.IntPtr)27);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_63;
			}
			IL_30:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_63:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_30;
		}

		// Token: 0x040002AC RID: 684
		private global::Motorola.Common.Communication.Rcmp.TTSLanguagePackControlOperation a;

		// Token: 0x040002AD RID: 685
		private string b;

		// Token: 0x040002AE RID: 686
		private byte[] c;

		// Token: 0x040002AF RID: 687
		private bool d;
	}
}
