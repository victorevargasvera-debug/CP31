using System;
using System.Collections.Generic;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000400 RID: 1024
	public class PaletteRecord : global::NPOI.HSSF.Record.StandardRecord
	{
		// Token: 0x06002532 RID: 9522 RVA: 0x0006FBFC File Offset: 0x0006DDFC
		public PaletteRecord()
		{
			global::NPOI.HSSF.Record.PColor[] array = global::NPOI.HSSF.Record.PaletteRecord.CreateDefaultPalette();
			this.field_2_colors = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.PColor>(array.Length);
			for (int i = 0; i < array.Length; i++)
			{
				this.field_2_colors.Add(array[i]);
			}
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x0006FC40 File Offset: 0x0006DE40
		public PaletteRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			short num = in1.ReadShort();
			this.field_2_colors = new global::System.Collections.Generic.List<global::NPOI.HSSF.Record.PColor>((int)num);
			for (int i = 0; i < (int)num; i++)
			{
				this.field_2_colors.Add(new global::NPOI.HSSF.Record.PColor(in1));
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x0006FC83 File Offset: 0x0006DE83
		public short NumColors
		{
			get
			{
				return (short)this.field_2_colors.Count;
			}
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x0006FC91 File Offset: 0x0006DE91
		public void ClearColors()
		{
			this.field_2_colors.Clear();
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x0006FCA0 File Offset: 0x0006DEA0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[PALETTE]\n");
			stringBuilder.Append("  numcolors     = ").Append(this.field_2_colors.Count).Append('\n');
			for (int i = 0; i < this.field_2_colors.Count; i++)
			{
				global::NPOI.HSSF.Record.PColor pcolor = this.field_2_colors[i];
				stringBuilder.Append("* colornum      = ").Append(i).Append('\n');
				stringBuilder.Append(pcolor.ToString());
				stringBuilder.Append("/*colornum      = ").Append(i).Append('\n');
			}
			stringBuilder.Append("[/PALETTE]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x0006FD58 File Offset: 0x0006DF58
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this.field_2_colors.Count);
			for (int i = 0; i < this.field_2_colors.Count; i++)
			{
				this.field_2_colors[i].Serialize(out1);
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x0006FD9E File Offset: 0x0006DF9E
		protected override int DataSize
		{
			get
			{
				return 2 + this.field_2_colors.Count * 4;
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x06002539 RID: 9529 RVA: 0x0006FDAF File Offset: 0x0006DFAF
		public override short Sid
		{
			get
			{
				return 146;
			}
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x0006FDB8 File Offset: 0x0006DFB8
		public byte[] GetColor(short byteIndex)
		{
			int num = (int)(byteIndex - 8);
			if (num < 0 || num >= this.field_2_colors.Count)
			{
				return null;
			}
			global::NPOI.HSSF.Record.PColor pcolor = this.field_2_colors[num];
			return new byte[]
			{
				pcolor._red,
				pcolor._green,
				pcolor._blue
			};
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x0006FE0C File Offset: 0x0006E00C
		public void SetColor(short byteIndex, byte red, byte green, byte blue)
		{
			int num = (int)(byteIndex - 8);
			if (num < 0 || num >= 56)
			{
				return;
			}
			while (this.field_2_colors.Count <= num)
			{
				this.field_2_colors.Add(new global::NPOI.HSSF.Record.PColor(0, 0, 0));
			}
			global::NPOI.HSSF.Record.PColor value = new global::NPOI.HSSF.Record.PColor((int)red, (int)green, (int)blue);
			this.field_2_colors[num] = value;
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x0006FE60 File Offset: 0x0006E060
		private static global::NPOI.HSSF.Record.PColor[] CreateDefaultPalette()
		{
			return new global::NPOI.HSSF.Record.PColor[]
			{
				global::NPOI.HSSF.Record.PaletteRecord.pc(0, 0, 0),
				global::NPOI.HSSF.Record.PaletteRecord.pc(255, 255, 255),
				global::NPOI.HSSF.Record.PaletteRecord.pc(255, 0, 0),
				global::NPOI.HSSF.Record.PaletteRecord.pc(0, 255, 0),
				global::NPOI.HSSF.Record.PaletteRecord.pc(0, 0, 255),
				global::NPOI.HSSF.Record.PaletteRecord.pc(255, 255, 0),
				global::NPOI.HSSF.Record.PaletteRecord.pc(255, 0, 255),
				global::NPOI.HSSF.Record.PaletteRecord.pc(0, 255, 255),
				global::NPOI.HSSF.Record.PaletteRecord.pc(128, 0, 0),
				global::NPOI.HSSF.Record.PaletteRecord.pc(0, 128, 0),
				global::NPOI.HSSF.Record.PaletteRecord.pc(0, 0, 128),
				global::NPOI.HSSF.Record.PaletteRecord.pc(128, 128, 0),
				global::NPOI.HSSF.Record.PaletteRecord.pc(128, 0, 128),
				global::NPOI.HSSF.Record.PaletteRecord.pc(0, 128, 128),
				global::NPOI.HSSF.Record.PaletteRecord.pc(192, 192, 192),
				global::NPOI.HSSF.Record.PaletteRecord.pc(128, 128, 128),
				global::NPOI.HSSF.Record.PaletteRecord.pc(153, 153, 255),
				global::NPOI.HSSF.Record.PaletteRecord.pc(153, 51, 102),
				global::NPOI.HSSF.Record.PaletteRecord.pc(255, 255, 204),
				global::NPOI.HSSF.Record.PaletteRecord.pc(204, 255, 255),
				global::NPOI.HSSF.Record.PaletteRecord.pc(102, 0, 102),
				global::NPOI.HSSF.Record.PaletteRecord.pc(255, 128, 128),
				global::NPOI.HSSF.Record.PaletteRecord.pc(0, 102, 204),
				global::NPOI.HSSF.Record.PaletteRecord.pc(204, 204, 255),
				global::NPOI.HSSF.Record.PaletteRecord.pc(0, 0, 128),
				global::NPOI.HSSF.Record.PaletteRecord.pc(255, 0, 255),
				global::NPOI.HSSF.Record.PaletteRecord.pc(255, 255, 0),
				global::NPOI.HSSF.Record.PaletteRecord.pc(0, 255, 255),
				global::NPOI.HSSF.Record.PaletteRecord.pc(128, 0, 128),
				global::NPOI.HSSF.Record.PaletteRecord.pc(128, 0, 0),
				global::NPOI.HSSF.Record.PaletteRecord.pc(0, 128, 128),
				global::NPOI.HSSF.Record.PaletteRecord.pc(0, 0, 255),
				global::NPOI.HSSF.Record.PaletteRecord.pc(0, 204, 255),
				global::NPOI.HSSF.Record.PaletteRecord.pc(204, 255, 255),
				global::NPOI.HSSF.Record.PaletteRecord.pc(204, 255, 204),
				global::NPOI.HSSF.Record.PaletteRecord.pc(255, 255, 153),
				global::NPOI.HSSF.Record.PaletteRecord.pc(153, 204, 255),
				global::NPOI.HSSF.Record.PaletteRecord.pc(255, 153, 204),
				global::NPOI.HSSF.Record.PaletteRecord.pc(204, 153, 255),
				global::NPOI.HSSF.Record.PaletteRecord.pc(255, 204, 153),
				global::NPOI.HSSF.Record.PaletteRecord.pc(51, 102, 255),
				global::NPOI.HSSF.Record.PaletteRecord.pc(51, 204, 204),
				global::NPOI.HSSF.Record.PaletteRecord.pc(153, 204, 0),
				global::NPOI.HSSF.Record.PaletteRecord.pc(255, 204, 0),
				global::NPOI.HSSF.Record.PaletteRecord.pc(255, 153, 0),
				global::NPOI.HSSF.Record.PaletteRecord.pc(255, 102, 0),
				global::NPOI.HSSF.Record.PaletteRecord.pc(102, 102, 153),
				global::NPOI.HSSF.Record.PaletteRecord.pc(150, 150, 150),
				global::NPOI.HSSF.Record.PaletteRecord.pc(0, 51, 102),
				global::NPOI.HSSF.Record.PaletteRecord.pc(51, 153, 102),
				global::NPOI.HSSF.Record.PaletteRecord.pc(0, 51, 0),
				global::NPOI.HSSF.Record.PaletteRecord.pc(51, 51, 0),
				global::NPOI.HSSF.Record.PaletteRecord.pc(153, 51, 0),
				global::NPOI.HSSF.Record.PaletteRecord.pc(153, 51, 102),
				global::NPOI.HSSF.Record.PaletteRecord.pc(51, 51, 153),
				global::NPOI.HSSF.Record.PaletteRecord.pc(51, 51, 51)
			};
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x000702AD File Offset: 0x0006E4AD
		private static global::NPOI.HSSF.Record.PColor pc(int r, int g, int b)
		{
			return new global::NPOI.HSSF.Record.PColor(r, g, b);
		}

		// Token: 0x04000FA3 RID: 4003
		public const short sid = 146;

		// Token: 0x04000FA4 RID: 4004
		public const byte STANDARD_PALETTE_SIZE = 56;

		// Token: 0x04000FA5 RID: 4005
		public const short FIRST_COLOR_INDEX = 8;

		// Token: 0x04000FA6 RID: 4006
		private global::System.Collections.Generic.List<global::NPOI.HSSF.Record.PColor> field_2_colors;
	}
}
