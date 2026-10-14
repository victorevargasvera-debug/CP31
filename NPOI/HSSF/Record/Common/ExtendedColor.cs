using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Common
{
	// Token: 0x0200045C RID: 1116
	public class ExtendedColor : global::System.ICloneable
	{
		// Token: 0x0600293D RID: 10557 RVA: 0x0007C659 File Offset: 0x0007A859
		public ExtendedColor()
		{
			this.type = global::NPOI.HSSF.Record.Common.ExtendedColor.TYPE_INDEXED;
			this.colorIndex = 0;
			this.tint = 0.0;
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x0007C684 File Offset: 0x0007A884
		public ExtendedColor(global::NPOI.Util.ILittleEndianInput in1)
		{
			this.type = in1.ReadInt();
			if (this.type == global::NPOI.HSSF.Record.Common.ExtendedColor.TYPE_INDEXED)
			{
				this.colorIndex = in1.ReadInt();
			}
			else if (this.type == global::NPOI.HSSF.Record.Common.ExtendedColor.TYPE_RGB)
			{
				this.rgba = new byte[4];
				in1.ReadFully(this.rgba);
			}
			else if (this.type == global::NPOI.HSSF.Record.Common.ExtendedColor.TYPE_THEMED)
			{
				this.themeIndex = in1.ReadInt();
			}
			else
			{
				in1.ReadInt();
			}
			this.tint = in1.ReadDouble();
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x0600293F RID: 10559 RVA: 0x0007C713 File Offset: 0x0007A913
		// (set) Token: 0x06002940 RID: 10560 RVA: 0x0007C71B File Offset: 0x0007A91B
		public int Type
		{
			get
			{
				return this.type;
			}
			set
			{
				this.type = value;
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06002941 RID: 10561 RVA: 0x0007C724 File Offset: 0x0007A924
		// (set) Token: 0x06002942 RID: 10562 RVA: 0x0007C72C File Offset: 0x0007A92C
		public int ColorIndex
		{
			get
			{
				return this.colorIndex;
			}
			set
			{
				this.colorIndex = value;
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x0007C735 File Offset: 0x0007A935
		// (set) Token: 0x06002944 RID: 10564 RVA: 0x0007C73D File Offset: 0x0007A93D
		public byte[] RGBA
		{
			get
			{
				return this.rgba;
			}
			set
			{
				this.rgba = ((value == null) ? null : ((byte[])value.Clone()));
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06002945 RID: 10565 RVA: 0x0007C756 File Offset: 0x0007A956
		// (set) Token: 0x06002946 RID: 10566 RVA: 0x0007C75E File Offset: 0x0007A95E
		public int ThemeIndex
		{
			get
			{
				return this.themeIndex;
			}
			set
			{
				this.themeIndex = value;
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06002947 RID: 10567 RVA: 0x0007C767 File Offset: 0x0007A967
		// (set) Token: 0x06002948 RID: 10568 RVA: 0x0007C76F File Offset: 0x0007A96F
		public double Tint
		{
			get
			{
				return this.tint;
			}
			set
			{
				if (this.tint < -1.0 || this.tint > 1.0)
				{
					throw new global::System.ArgumentException("Tint/Shade must be between -1 and +1");
				}
				this.tint = value;
			}
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x0007C7A8 File Offset: 0x0007A9A8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("    [Extended Color]\n");
			stringBuilder.Append("          .type  = ").Append(this.type).Append("\n");
			stringBuilder.Append("          .tint  = ").Append(this.tint).Append("\n");
			stringBuilder.Append("          .c_idx = ").Append(this.colorIndex).Append("\n");
			stringBuilder.Append("          .rgba  = ").Append(global::NPOI.Util.HexDump.ToHex(this.rgba)).Append("\n");
			stringBuilder.Append("          .t_idx = ").Append(this.themeIndex).Append("\n");
			stringBuilder.Append("    [/Extended Color]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x0007C884 File Offset: 0x0007AA84
		public object Clone()
		{
			global::NPOI.HSSF.Record.Common.ExtendedColor extendedColor = new global::NPOI.HSSF.Record.Common.ExtendedColor();
			extendedColor.type = this.type;
			extendedColor.tint = this.tint;
			if (this.type == global::NPOI.HSSF.Record.Common.ExtendedColor.TYPE_INDEXED)
			{
				extendedColor.colorIndex = this.colorIndex;
			}
			else if (this.type == global::NPOI.HSSF.Record.Common.ExtendedColor.TYPE_RGB)
			{
				extendedColor.rgba = new byte[4];
				global::System.Array.Copy(this.rgba, 0, extendedColor.rgba, 0, 4);
			}
			else if (this.type == global::NPOI.HSSF.Record.Common.ExtendedColor.TYPE_THEMED)
			{
				extendedColor.themeIndex = this.themeIndex;
			}
			return extendedColor;
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x0600294B RID: 10571 RVA: 0x0002C0F8 File Offset: 0x0002A2F8
		public int DataLength
		{
			get
			{
				return 16;
			}
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x0007C914 File Offset: 0x0007AB14
		public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this.type);
			if (this.type == global::NPOI.HSSF.Record.Common.ExtendedColor.TYPE_INDEXED)
			{
				out1.WriteInt(this.colorIndex);
			}
			else if (this.type == global::NPOI.HSSF.Record.Common.ExtendedColor.TYPE_RGB)
			{
				out1.Write(this.rgba);
			}
			else if (this.type == global::NPOI.HSSF.Record.Common.ExtendedColor.TYPE_THEMED)
			{
				out1.WriteInt(this.themeIndex);
			}
			else
			{
				out1.WriteInt(0);
			}
			out1.WriteDouble(this.tint);
		}

		// Token: 0x040011CB RID: 4555
		public static int TYPE_AUTO = 0;

		// Token: 0x040011CC RID: 4556
		public static int TYPE_INDEXED = 1;

		// Token: 0x040011CD RID: 4557
		public static int TYPE_RGB = 2;

		// Token: 0x040011CE RID: 4558
		public static int TYPE_THEMED = 3;

		// Token: 0x040011CF RID: 4559
		public static int TYPE_UNSET = 4;

		// Token: 0x040011D0 RID: 4560
		public static int THEME_DARK_1 = 0;

		// Token: 0x040011D1 RID: 4561
		public static int THEME_LIGHT_1 = 1;

		// Token: 0x040011D2 RID: 4562
		public static int THEME_DARK_2 = 2;

		// Token: 0x040011D3 RID: 4563
		public static int THEME_LIGHT_2 = 3;

		// Token: 0x040011D4 RID: 4564
		public static int THEME_ACCENT_1 = 4;

		// Token: 0x040011D5 RID: 4565
		public static int THEME_ACCENT_2 = 5;

		// Token: 0x040011D6 RID: 4566
		public static int THEME_ACCENT_3 = 6;

		// Token: 0x040011D7 RID: 4567
		public static int THEME_ACCENT_4 = 7;

		// Token: 0x040011D8 RID: 4568
		public static int THEME_ACCENT_5 = 8;

		// Token: 0x040011D9 RID: 4569
		public static int THEME_ACCENT_6 = 9;

		// Token: 0x040011DA RID: 4570
		public static int THEME_HYPERLINK = 10;

		// Token: 0x040011DB RID: 4571
		public static int THEME_FOLLOWED_HYPERLINK = 11;

		// Token: 0x040011DC RID: 4572
		public int type;

		// Token: 0x040011DD RID: 4573
		public int colorIndex;

		// Token: 0x040011DE RID: 4574
		public byte[] rgba;

		// Token: 0x040011DF RID: 4575
		public int themeIndex;

		// Token: 0x040011E0 RID: 4576
		private double tint;
	}
}
