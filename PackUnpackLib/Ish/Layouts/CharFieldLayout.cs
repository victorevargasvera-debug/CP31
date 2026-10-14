using System;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x02000054 RID: 84
	public class CharFieldLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout
	{
		// Token: 0x0600030A RID: 778 RVA: 0x0004214C File Offset: 0x0004034C
		public CharFieldLayout(string name, global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding encoding, int byteOffset)
		{
			int a_ = 8;
			base..ctor(name, global::System.TypeCode.Char, byteOffset, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification.Right);
			if (encoding != global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding.Unicode)
			{
				if (encoding != global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding.Ascii)
				{
					throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("爵쾠삢쪤쎦삨얪쪬", a_));
				}
				this.a = 1;
			}
			else
			{
				this.a = 2;
			}
			this.b = encoding;
			this.c = null;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x000421AC File Offset: 0x000403AC
		public CharFieldLayout(string name, global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding encoding, int byteOffset, global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble nibble)
		{
			int a_ = 6;
			base..ctor(name, global::System.TypeCode.Char, byteOffset, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification.Right);
			if (!global::System.Enum.IsDefined(typeof(global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble), nibble))
			{
				throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("쎠솢즤슦", a_));
			}
			if (encoding - global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding.Bcd <= 1)
			{
				this.a = 1;
				this.c = new global::Motorola.Acp.PackUnpack.Ish.Layouts.IntMask((int)nibble, 4);
				this.b = encoding;
				this.d = nibble;
				return;
			}
			throw new global::System.ArgumentException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("슠첢솤캦잨첪", a_));
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0004223C File Offset: 0x0004043C
		public override int Size
		{
			get
			{
				short num = (short)1124506051;
				short num2 = num;
				num = (short)366516675;
				switch (num2 == num)
				{
				}
				num = (short)2078015489;
				if (num != 0)
				{
				}
				num = (short)308674560;
				if (num != 0)
				{
				}
				num = (short)1365966848;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600030D RID: 781 RVA: 0x000422EC File Offset: 0x000404EC
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding Encoding
		{
			get
			{
				short num = (short)1894885746;
				short num2 = num;
				num = (short)891595122;
				switch (num2 == num)
				{
				}
				num = (short)1698365441;
				if (num != 0)
				{
				}
				num = (short)2073034752;
				if (num != 0)
				{
				}
				num = (short)782434304;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0004239C File Offset: 0x0004059C
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble Nibble
		{
			get
			{
				short num = (short)540199238;
				short num2 = num;
				num = (short)1502071110;
				switch (num2 == num)
				{
				}
				num = (short)1514930177;
				if (num != 0)
				{
				}
				num = (short)871366656;
				if (num != 0)
				{
				}
				num = (short)616497152;
				short num3 = num;
				return this.d;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600030F RID: 783 RVA: 0x0004244C File Offset: 0x0004064C
		public global::Motorola.Acp.PackUnpack.Ish.Layouts.IntMask Mask
		{
			get
			{
				short num = (short)264429158;
				short num2 = num;
				num = (short)769515110;
				switch (num2 == num)
				{
				}
				num = (short)1217658881;
				if (num != 0)
				{
				}
				num = (short)758906880;
				if (num != 0)
				{
				}
				num = (short)55508992;
				short num3 = num;
				return this.c;
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x000424FC File Offset: 0x000406FC
		protected override int GetId()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			uint num3;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (this.c != null)
					{
						num2 = (short)653393922;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return (int)num3;
				case 1:
					return (int)num3;
				case 2:
					goto IL_CF;
				}
				goto IL_1C;
			}
			return (int)num3;
			IL_1C:
			num2 = (short)921880941;
			short num4 = num2;
			num2 = (short)469879149;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_CF:
				num2 = (short)1834942465;
				if (num2 != 0)
				{
				}
				num3 &= 536870911U;
				num3 |= (uint)((uint)this.c.BitOffset << 29);
				num2 = (short)569704449;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)272171008;
				if (num2 != 0)
				{
				}
				num2 = (short)164102144;
				short num5 = num2;
				num3 = (uint)base.GetId();
				num2 = (short)1572405248;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x04000110 RID: 272
		private int a;

		// Token: 0x04000111 RID: 273
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.CharEncoding b;

		// Token: 0x04000112 RID: 274
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.IntMask c;

		// Token: 0x04000113 RID: 275
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.Nibble d;
	}
}
