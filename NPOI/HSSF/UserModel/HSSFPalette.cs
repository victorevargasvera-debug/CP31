using System;
using System.Text;
using NPOI.HSSF.Record;
using NPOI.HSSF.Util;
using NPOI.Util;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200037F RID: 895
	public class HSSFPalette
	{
		// Token: 0x06001C77 RID: 7287 RVA: 0x00056928 File Offset: 0x00054B28
		public HSSFPalette(global::NPOI.HSSF.Record.PaletteRecord palette)
		{
			this.palette = palette;
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x00056938 File Offset: 0x00054B38
		public global::NPOI.HSSF.Util.HSSFColor GetColor(short index)
		{
			if (index == 64)
			{
				return global::NPOI.HSSF.Util.HSSFColor.Automatic.GetInstance();
			}
			byte[] color = this.palette.GetColor(index);
			if (color != null)
			{
				return new global::NPOI.HSSF.UserModel.HSSFPalette.CustomColor(index, color);
			}
			return null;
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x0005696C File Offset: 0x00054B6C
		public global::NPOI.HSSF.Util.HSSFColor FindColor(byte red, byte green, byte blue)
		{
			byte[] color = this.palette.GetColor(8);
			short num = 8;
			while (color != null)
			{
				if (color[0] == red && color[1] == green && color[2] == blue)
				{
					return new global::NPOI.HSSF.UserModel.HSSFPalette.CustomColor(num, color);
				}
				color = this.palette.GetColor(num += 1);
			}
			return null;
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x000569BC File Offset: 0x00054BBC
		public global::NPOI.HSSF.Util.HSSFColor FindSimilarColor(byte red, byte green, byte blue)
		{
			global::NPOI.HSSF.Util.HSSFColor result = null;
			int num = int.MaxValue;
			byte[] color = this.palette.GetColor(8);
			short num2 = 8;
			while (color != null)
			{
				int num3 = global::System.Math.Abs((int)(red - color[0])) + global::System.Math.Abs((int)(green - color[1])) + global::System.Math.Abs((int)(blue - color[2]));
				if (num3 < num)
				{
					num = num3;
					result = this.GetColor(num2);
				}
				color = this.palette.GetColor(num2 += 1);
			}
			return result;
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x00056A2A File Offset: 0x00054C2A
		public void SetColorAtIndex(short index, byte red, byte green, byte blue)
		{
			this.palette.SetColor(index, red, green, blue);
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x00056A3C File Offset: 0x00054C3C
		public global::NPOI.HSSF.Util.HSSFColor AddColor(byte red, byte green, byte blue)
		{
			byte[] color = this.palette.GetColor(8);
			short num = 8;
			while (num < 64)
			{
				if (color == null)
				{
					this.SetColorAtIndex(num, red, green, blue);
					return this.GetColor(num);
				}
				color = this.palette.GetColor(num += 1);
			}
			throw new global::System.Exception("Could not Find free color index");
		}

		// Token: 0x04000B65 RID: 2917
		private global::NPOI.HSSF.Record.PaletteRecord palette;

		// Token: 0x02000603 RID: 1539
		private class CustomColor : global::NPOI.HSSF.Util.HSSFColor
		{
			// Token: 0x0600363C RID: 13884 RVA: 0x000A5BDD File Offset: 0x000A3DDD
			public CustomColor(short byteOffset, byte[] colors) : this(byteOffset, colors[0], colors[1], colors[2])
			{
			}

			// Token: 0x0600363D RID: 13885 RVA: 0x000A5BEF File Offset: 0x000A3DEF
			public CustomColor(short byteOffset, byte red, byte green, byte blue)
			{
				this.byteOffset = byteOffset;
				this.red = red;
				this.green = green;
				this.blue = blue;
			}

			// Token: 0x17000E12 RID: 3602
			// (get) Token: 0x0600363E RID: 13886 RVA: 0x000A5C14 File Offset: 0x000A3E14
			public override short Indexed
			{
				get
				{
					return this.byteOffset;
				}
			}

			// Token: 0x0600363F RID: 13887 RVA: 0x000A5C1C File Offset: 0x000A3E1C
			public override byte[] GetTriplet()
			{
				return new byte[]
				{
					this.red & byte.MaxValue,
					this.green & byte.MaxValue,
					this.blue & byte.MaxValue
				};
			}

			// Token: 0x06003640 RID: 13888 RVA: 0x000A5C54 File Offset: 0x000A3E54
			public override string GetHexString()
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				stringBuilder.Append(this.GetGnumericPart(this.red));
				stringBuilder.Append(':');
				stringBuilder.Append(this.GetGnumericPart(this.green));
				stringBuilder.Append(':');
				stringBuilder.Append(this.GetGnumericPart(this.blue));
				return stringBuilder.ToString();
			}

			// Token: 0x06003641 RID: 13889 RVA: 0x000A5CB8 File Offset: 0x000A3EB8
			private string GetGnumericPart(byte color)
			{
				string text;
				if (color == 0)
				{
					text = "0";
				}
				else
				{
					int num = (int)(color & byte.MaxValue);
					num = (num << 8 | num);
					text = global::NPOI.Util.StringUtil.ToHexString(num).ToUpper();
					while (text.Length < 4)
					{
						text = "0" + text;
					}
				}
				return text;
			}

			// Token: 0x04001A47 RID: 6727
			private short byteOffset;

			// Token: 0x04001A48 RID: 6728
			private byte red;

			// Token: 0x04001A49 RID: 6729
			private byte green;

			// Token: 0x04001A4A RID: 6730
			private byte blue;
		}
	}
}
