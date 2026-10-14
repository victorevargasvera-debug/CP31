using System;
using System.Globalization;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Rcmp
{
	// Token: 0x02000042 RID: 66
	public class RcmpReadIshItem : global::Motorola.Common.Communication.RcmpBaseMessage, global::Motorola.Common.Communication.ISuperBundlerMessage
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000E530 File Offset: 0x0000C730
		public byte LogicalPartition
		{
			get
			{
				short num = (short)900705069;
				short num2 = num;
				num = (short)1347070765;
				switch (num2 == num)
				{
				}
				num = (short)1214316545;
				if (num != 0)
				{
				}
				num = (short)2018443264;
				if (num != 0)
				{
				}
				num = (short)1321074688;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000E5E0 File Offset: 0x0000C7E0
		public ushort IshType
		{
			get
			{
				short num = (short)233529405;
				short num2 = num;
				num = (short)1998807101;
				switch (num2 == num)
				{
				}
				num = (short)1188429824;
				if (num != 0)
				{
				}
				num = (short)1508900865;
				if (num != 0)
				{
				}
				num = (short)1725235200;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000E690 File Offset: 0x0000C890
		public ushort IshID
		{
			get
			{
				short num = (short)462214105;
				short num2 = num;
				num = (short)1730139097;
				switch (num2 == num)
				{
				}
				num = (short)193527809;
				if (num != 0)
				{
				}
				num = (short)1022427136;
				if (num != 0)
				{
				}
				num = (short)2015166464;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000E740 File Offset: 0x0000C940
		public ushort ItemSize
		{
			get
			{
				short num = (short)80344288;
				short num2 = num;
				num = (short)359724256;
				switch (num2 == num)
				{
				}
				num = (short)797900800;
				if (num != 0)
				{
				}
				num = (short)504627201;
				if (num != 0)
				{
				}
				num = (short)1576337408;
				short num3 = num;
				return this.f;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000E7F0 File Offset: 0x0000C9F0
		private ushort NumberOfBytes
		{
			get
			{
				short num = (short)115814188;
				short num2 = num;
				num = (short)1322921772;
				switch (num2 == num)
				{
				}
				num = (short)1923219456;
				if (num != 0)
				{
				}
				num = (short)1542389761;
				if (num != 0)
				{
				}
				num = (short)556269568;
				short num3 = num;
				return this.d;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000E8A4 File Offset: 0x0000CAA4
		public ushort Offset
		{
			get
			{
				short num = (short)466528055;
				short num2 = num;
				num = (short)1098360631;
				switch (num2 == num)
				{
				}
				num = (short)1490681856;
				if (num != 0)
				{
				}
				num = (short)655425537;
				if (num != 0)
				{
				}
				num = (short)678756352;
				short num3 = num;
				return this.e;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000E950 File Offset: 0x0000CB50
		public byte[] Data
		{
			get
			{
				short num = (short)740346487;
				short num2 = num;
				num = (short)1470286455;
				switch (num2 == num)
				{
				}
				num = (short)486408193;
				if (num != 0)
				{
				}
				num = (short)904724480;
				if (num != 0)
				{
				}
				num = (short)658243584;
				short num3 = num;
				return this.g;
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000EA00 File Offset: 0x0000CC00
		public RcmpReadIshItem(byte logicalPartition, ushort type, ushort id, ushort numberOfBytes, ushort offset)
		{
			base.Opcode = 256;
			this.a = logicalPartition;
			this.b = type;
			this.c = id;
			this.d = numberOfBytes;
			this.e = offset;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000EA44 File Offset: 0x0000CC44
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			short num = (short)941487000;
			short num2 = num;
			num = (short)1537405848;
			switch (num2 == num)
			{
			}
			num = (short)1830748160;
			if (num != 0)
			{
			}
			num = (short)1433731073;
			if (num != 0)
			{
			}
			num = (short)1610022912;
			short num3 = num;
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.a,
				this.b,
				this.c,
				this.d,
				this.e
			});
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000EB4C File Offset: 0x0000CD4C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			int a_ = 7;
			short num = (short)2087190528;
			short num2 = num;
			num = (short)286195713;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_82;
			}
			int num3;
			for (;;)
			{
				IL_64:
				switch (num3)
				{
				case 0:
					goto IL_1F6;
				case 1:
					return;
				case 2:
					if (base.ReplyResult != global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num = (short)1512701955;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F6;
				case 3:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("솒ﶘ뮚풜첞莢펦첨욪趬킰\udab2\ud9b4슶쮸\udeba螼龾", a_) + base.ReplyResult.ToString(), global::System.Array.Empty<object>());
					num = (short)1718157312;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_20D;
				case 5:
				{
					num = (short)1194158086;
					short num4 = num;
					num = (short)300115974;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_20D;
					default:
					{
						num = (short)292028416;
						if (num != 0)
						{
						}
						object[] array = new object[]
						{
							global::Motorola.Common.Communication.r.b,
							global::Motorola.Common.Communication.r.a,
							global::Motorola.Common.Communication.r.a,
							global::Motorola.Common.Communication.r.a,
							global::Motorola.Common.Communication.r.a,
							global::Motorola.Common.Communication.r.a,
							global::Motorola.Common.Communication.r.c
						};
						global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
						this.a = (byte)array[0];
						this.b = (ushort)array[1];
						this.c = (ushort)array[2];
						this.d = (ushort)array[3];
						this.e = (ushort)array[4];
						this.f = (ushort)array[5];
						this.g = (byte[])array[6];
						num = (short)1944715265;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				goto IL_82;
				IL_1F6:
				num = (short)1644822532;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_20D:
				if (length <= global::Motorola.Common.Communication.r.b())
				{
					break;
				}
				num = (short)12255237;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_82:
			base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
			num = (short)628293634;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_64;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000EDE0 File Offset: 0x0000CFE0
		public int MaxMessageSize
		{
			get
			{
				short num = (short)1412497373;
				short num2 = num;
				num = (short)1223753693;
				switch (num2 == num)
				{
				}
				num = (short)1538326528;
				if (num != 0)
				{
				}
				num = (short)511836161;
				if (num != 0)
				{
				}
				num = (short)41615360;
				short num3 = num;
				return global::Motorola.Common.Communication.Rcmp.RcmpReadIshItem.HeaderSize + (int)this.d;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000EE98 File Offset: 0x0000D098
		public static int HeaderSize
		{
			get
			{
				short num = (short)274030896;
				short num2 = num;
				num = (short)1611292976;
				switch (num2 == num)
				{
				}
				num = (short)820117505;
				if (num != 0)
				{
				}
				num = (short)1251016704;
				if (num != 0)
				{
				}
				num = (short)368050176;
				short num3 = num;
				return 14;
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000EF44 File Offset: 0x0000D144
		public override string ToString()
		{
			int a_ = 4;
			short num = (short)2097055326;
			short num2 = num;
			num = (short)1686210142;
			switch (num2 == num)
			{
			}
			num = (short)500826112;
			if (num != 0)
			{
			}
			num = (short)1078788097;
			if (num != 0)
			{
			}
			num = (short)777846784;
			short num3 = num;
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("ꊑ뺕좗ﮙ즟횡춣즥욧鞩힫龭춯麱쾵좷\udfb9膻얽뿁迅資럋﷍귏ﻑ髓ꏕ뗗룙맛곝꿟蓡ꛣ鿥鳧迩鿫폭误웱觳\udaf5럷鳹髻跽旿瘁㤃紅㴇眉​䜍搏眑礓䔕焗怙礛⌝嬟ᐡ夣ਥ稧伩尫䈭䤯怱儳䔵䴷嘹䠻̽㬿畁㥃潅", a_), new object[]
			{
				base.GetType().Name,
				this.LogicalPartition,
				this.IshType,
				this.IshID,
				this.NumberOfBytes,
				this.Offset,
				this.ItemSize,
				base.ReplyResult
			});
		}

		// Token: 0x0400013E RID: 318
		private byte a;

		// Token: 0x0400013F RID: 319
		private ushort b;

		// Token: 0x04000140 RID: 320
		private ushort c;

		// Token: 0x04000141 RID: 321
		private ushort d;

		// Token: 0x04000142 RID: 322
		private ushort e;

		// Token: 0x04000143 RID: 323
		private ushort f;

		// Token: 0x04000144 RID: 324
		private byte[] g;
	}
}
