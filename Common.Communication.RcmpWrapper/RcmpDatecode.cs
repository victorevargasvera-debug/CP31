using System;
using Motorola.Common.Communication.Rcmp;

namespace Motorola.Common.Communication
{
	// Token: 0x02000009 RID: 9
	public class RcmpDatecode : global::Motorola.Common.Communication.RcmpBaseMessage
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00004D00 File Offset: 0x00002F00
		public RcmpDatecode(byte operation, byte[] datecode, ushort source)
		{
			base.Opcode = 25;
			this.c = operation;
			if (datecode != null)
			{
				this.a = new byte[datecode.Length];
				datecode.CopyTo(this.a, 0);
			}
			byte[] bytes = global::System.BitConverter.GetBytes(source);
			if (bytes != null)
			{
				this.b = bytes[0];
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00004D5C File Offset: 0x00002F5C
		// (set) Token: 0x06000027 RID: 39 RVA: 0x00004E0C File Offset: 0x0000300C
		private byte Operation
		{
			get
			{
				short num = (short)1720489710;
				short num2 = num;
				num = (short)240883438;
				switch (num2 == num)
				{
				}
				num = (short)1016397825;
				if (num != 0)
				{
				}
				num = (short)1278083072;
				short num3 = num;
				num = (short)327024640;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1462888118;
				short num2 = num;
				num = (short)1356261046;
				switch (num2 == num)
				{
				}
				num = (short)464912384;
				if (num != 0)
				{
				}
				num = (short)351207424;
				short num3 = num;
				num = (short)995164161;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00004EB8 File Offset: 0x000030B8
		private byte[] Datecode
		{
			get
			{
				short num = (short)1820983296;
				short num2 = num;
				if (this.a == null)
				{
					num = (short)684195841;
					if (num != 0)
					{
					}
					num = (short)1581560490;
					short num3 = num;
					num = (short)1852748458;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)624230400;
						if (num != 0)
						{
						}
						return null;
					}
				}
				byte[] array = new byte[this.a.Length];
				this.a.CopyTo(array, 0);
				return array;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00004F88 File Offset: 0x00003188
		private ushort Source
		{
			get
			{
				short num = (short)1430141361;
				short num2 = num;
				num = (short)857881009;
				switch (num2 == num)
				{
				}
				num = (short)977797120;
				if (num != 0)
				{
				}
				num = (short)293273600;
				short num3 = num;
				num = (short)638648321;
				if (num != 0)
				{
				}
				byte[] array = new byte[2];
				array[0] = this.b;
				return global::System.BitConverter.ToUInt16(array, 0);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00005048 File Offset: 0x00003248
		public override int BuildCommandMessage(byte[] buffer, int offset)
		{
			int a_ = 17;
			short num = (short)1474756609;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.c == 1)
					{
						num = (short)1204092930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_162;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 2:
					num = (short)1388052489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1C5;
				case 4:
					goto IL_D8;
				case 5:
					goto IL_15D;
				case 6:
				{
					if (this.a == null)
					{
						num = (short)1719926785;
						if (num != 0)
						{
						}
						num = (short)1372192771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1428249408;
					short num3 = num;
					num = (short)1606245184;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C0;
					default:
						goto IL_241;
					}
					break;
				}
				case 7:
					if (this.a != null)
					{
						num = (short)244973573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_162;
				case 8:
					num = (short)801767431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (this.a == null)
					{
						goto IL_C0;
					}
					goto IL_162;
				}
				IL_55:
				if (this.c == 0)
				{
					num = (short)1535115272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)224919552;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C0:
				num = (short)610992132;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_162:
				num = (short)1813577734;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D8:
			throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("\ud99cﺞ햠욢욤좦춨캪", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("\udc9c욠횢좤슦잨\udfaa趬즮\udeb0솲閴\ud8b8쾺\ud8bc\udcbe껀Ꟃꃄꃈ룊ꇎꓐ뿒맔뿘듚꿜￞뛠釢賤鏦賨쯪ꋬ鿮铰臲铴菶郸铺鏼賾", a_));
			IL_15D:
			throw new global::System.ArgumentException(global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("\ud99cﺞ햠욢욤좦춨캪", a_), global::Motorola.Common.Communication.Rcmp.XcmpWriteTTSLanguagePack.b("\udc9c욠횢좤슦잨\udfaa趬즮\udeb0솲閴\ud8b8쾺\ud8bc\udcbe껀Ꟃꃄꃈ룊ꇎ뻐꟒맖곘럚뇜￞蟠賢韤쟦믨軪賬诮퇰볲藴鋶诸髺觼雾渀洂瘄", a_));
			IL_1C5:
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.c
			});
			IL_241:
			num = (short)617938944;
			short num4 = num;
			num = (short)296681472;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.r.a(buffer, offset, new object[]
			{
				base.Opcode,
				this.c,
				this.a,
				this.b
			});
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00005314 File Offset: 0x00003514
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
				{
					object[] array = new object[]
					{
						global::Motorola.Common.Communication.r.c
					};
					global::Motorola.Common.Communication.r.a(replyBuffer, offset + global::Motorola.Common.Communication.r.b(), length - global::Motorola.Common.Communication.r.b(), array);
					this.a = new byte[length - 1 - global::Motorola.Common.Communication.r.b()];
					global::System.Array.Copy((byte[])array[0], 0, this.a, 0, length - 1 - global::Motorola.Common.Communication.r.b());
					this.b = ((byte[])array[0])[length - 1 - global::Motorola.Common.Communication.r.b()];
					num2 = (short)1604780033;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_F2;
				case 2:
					if (base.ReplyResult == global::Motorola.Common.Communication.RcmpReplyResult.Success)
					{
						num2 = (short)1772814336;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_167;
				}
				goto IL_1C;
			}
			IL_F2:
			num2 = (short)1734736210;
			short num3 = num2;
			num2 = (short)1490549074;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1C:
				base.ReplyResult = global::Motorola.Common.Communication.r.a(replyBuffer, offset, base.Opcode | global::Motorola.Common.Communication.r.a());
				num2 = (short)1159790594;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
				num2 = (short)1790181377;
				if (num2 != 0)
				{
				}
				num2 = (short)134873088;
				if (num2 != 0)
				{
				}
				break;
			}
			IL_167:
			num2 = (short)207880192;
			short num4 = num2;
		}

		// Token: 0x0400000D RID: 13
		private byte[] a;

		// Token: 0x0400000E RID: 14
		private byte b;

		// Token: 0x0400000F RID: 15
		private byte c;
	}
}
