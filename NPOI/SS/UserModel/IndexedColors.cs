using System;
using System.Collections.Generic;
using System.Text;
using NPOI.HSSF.Util;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000043 RID: 67
	public class IndexedColors
	{
		// Token: 0x0600026A RID: 618 RVA: 0x0000A276 File Offset: 0x00008476
		private IndexedColors(int idx, global::NPOI.HSSF.Util.HSSFColor color)
		{
			this.index = idx;
			this.hssfColor = color;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000A28C File Offset: 0x0000848C
		static IndexedColors()
		{
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("black", global::NPOI.SS.UserModel.IndexedColors.Black);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("white", global::NPOI.SS.UserModel.IndexedColors.White);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("red", global::NPOI.SS.UserModel.IndexedColors.Red);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("brightgreen", global::NPOI.SS.UserModel.IndexedColors.BrightGreen);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("blue", global::NPOI.SS.UserModel.IndexedColors.Blue);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("yellow", global::NPOI.SS.UserModel.IndexedColors.Yellow);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("pink", global::NPOI.SS.UserModel.IndexedColors.Pink);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("turquoise", global::NPOI.SS.UserModel.IndexedColors.Turquoise);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("darkred", global::NPOI.SS.UserModel.IndexedColors.DarkRed);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("green", global::NPOI.SS.UserModel.IndexedColors.Green);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("darkblue", global::NPOI.SS.UserModel.IndexedColors.DarkBlue);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("darkyellow", global::NPOI.SS.UserModel.IndexedColors.DarkYellow);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("violet", global::NPOI.SS.UserModel.IndexedColors.Violet);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("teal", global::NPOI.SS.UserModel.IndexedColors.Teal);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("grey25percent", global::NPOI.SS.UserModel.IndexedColors.Grey25Percent);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("grey50percent", global::NPOI.SS.UserModel.IndexedColors.Grey50Percent);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("cornflowerblue", global::NPOI.SS.UserModel.IndexedColors.CornflowerBlue);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("maroon", global::NPOI.SS.UserModel.IndexedColors.Maroon);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("lemonchiffon", global::NPOI.SS.UserModel.IndexedColors.LemonChiffon);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("orchid", global::NPOI.SS.UserModel.IndexedColors.Orchid);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("coral", global::NPOI.SS.UserModel.IndexedColors.Coral);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("royalblue", global::NPOI.SS.UserModel.IndexedColors.RoyalBlue);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("lightcornflowerblue", global::NPOI.SS.UserModel.IndexedColors.LightCornflowerBlue);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("skyblue", global::NPOI.SS.UserModel.IndexedColors.SkyBlue);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("lightturquoise", global::NPOI.SS.UserModel.IndexedColors.LightTurquoise);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("lightgreen", global::NPOI.SS.UserModel.IndexedColors.LightGreen);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("lightyellow", global::NPOI.SS.UserModel.IndexedColors.LightYellow);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("paleblue", global::NPOI.SS.UserModel.IndexedColors.PaleBlue);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("rose", global::NPOI.SS.UserModel.IndexedColors.Rose);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("lavender", global::NPOI.SS.UserModel.IndexedColors.Lavender);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("tan", global::NPOI.SS.UserModel.IndexedColors.Tan);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("lightblue", global::NPOI.SS.UserModel.IndexedColors.LightBlue);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("aqua", global::NPOI.SS.UserModel.IndexedColors.Aqua);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("lime", global::NPOI.SS.UserModel.IndexedColors.Lime);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("gold", global::NPOI.SS.UserModel.IndexedColors.Gold);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("lightorange", global::NPOI.SS.UserModel.IndexedColors.LightOrange);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("orange", global::NPOI.SS.UserModel.IndexedColors.Orange);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("bluegrey", global::NPOI.SS.UserModel.IndexedColors.BlueGrey);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("grey40percent", global::NPOI.SS.UserModel.IndexedColors.Grey40Percent);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("darkteal", global::NPOI.SS.UserModel.IndexedColors.DarkTeal);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("seagreen", global::NPOI.SS.UserModel.IndexedColors.SeaGreen);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("darkgreen", global::NPOI.SS.UserModel.IndexedColors.DarkGreen);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("olivergreen", global::NPOI.SS.UserModel.IndexedColors.OliveGreen);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("brown", global::NPOI.SS.UserModel.IndexedColors.Brown);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("plum", global::NPOI.SS.UserModel.IndexedColors.Plum);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("indigo", global::NPOI.SS.UserModel.IndexedColors.Indigo);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("grey80percent", global::NPOI.SS.UserModel.IndexedColors.Grey80Percent);
			global::NPOI.SS.UserModel.IndexedColors.mappingName.Add("automatic", global::NPOI.SS.UserModel.IndexedColors.Automatic);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex = new global::System.Collections.Generic.Dictionary<int, global::NPOI.SS.UserModel.IndexedColors>();
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(8, global::NPOI.SS.UserModel.IndexedColors.Black);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(9, global::NPOI.SS.UserModel.IndexedColors.White);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(10, global::NPOI.SS.UserModel.IndexedColors.Red);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(11, global::NPOI.SS.UserModel.IndexedColors.BrightGreen);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(12, global::NPOI.SS.UserModel.IndexedColors.Blue);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(13, global::NPOI.SS.UserModel.IndexedColors.Yellow);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(14, global::NPOI.SS.UserModel.IndexedColors.Pink);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(15, global::NPOI.SS.UserModel.IndexedColors.Turquoise);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(16, global::NPOI.SS.UserModel.IndexedColors.DarkRed);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(17, global::NPOI.SS.UserModel.IndexedColors.Green);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(18, global::NPOI.SS.UserModel.IndexedColors.DarkBlue);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(19, global::NPOI.SS.UserModel.IndexedColors.DarkYellow);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(20, global::NPOI.SS.UserModel.IndexedColors.Violet);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(21, global::NPOI.SS.UserModel.IndexedColors.Teal);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(22, global::NPOI.SS.UserModel.IndexedColors.Grey25Percent);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(23, global::NPOI.SS.UserModel.IndexedColors.Grey50Percent);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(24, global::NPOI.SS.UserModel.IndexedColors.CornflowerBlue);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(25, global::NPOI.SS.UserModel.IndexedColors.Maroon);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(26, global::NPOI.SS.UserModel.IndexedColors.LemonChiffon);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(28, global::NPOI.SS.UserModel.IndexedColors.Orchid);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(29, global::NPOI.SS.UserModel.IndexedColors.Coral);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(30, global::NPOI.SS.UserModel.IndexedColors.RoyalBlue);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(31, global::NPOI.SS.UserModel.IndexedColors.LightCornflowerBlue);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(40, global::NPOI.SS.UserModel.IndexedColors.SkyBlue);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(41, global::NPOI.SS.UserModel.IndexedColors.LightTurquoise);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(42, global::NPOI.SS.UserModel.IndexedColors.LightGreen);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(43, global::NPOI.SS.UserModel.IndexedColors.LightYellow);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(44, global::NPOI.SS.UserModel.IndexedColors.PaleBlue);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(45, global::NPOI.SS.UserModel.IndexedColors.Rose);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(46, global::NPOI.SS.UserModel.IndexedColors.Lavender);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(47, global::NPOI.SS.UserModel.IndexedColors.Tan);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(48, global::NPOI.SS.UserModel.IndexedColors.LightBlue);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(49, global::NPOI.SS.UserModel.IndexedColors.Aqua);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(50, global::NPOI.SS.UserModel.IndexedColors.Lime);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(51, global::NPOI.SS.UserModel.IndexedColors.Gold);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(52, global::NPOI.SS.UserModel.IndexedColors.LightOrange);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(53, global::NPOI.SS.UserModel.IndexedColors.Orange);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(54, global::NPOI.SS.UserModel.IndexedColors.BlueGrey);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(55, global::NPOI.SS.UserModel.IndexedColors.Grey40Percent);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(56, global::NPOI.SS.UserModel.IndexedColors.DarkTeal);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(57, global::NPOI.SS.UserModel.IndexedColors.SeaGreen);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(58, global::NPOI.SS.UserModel.IndexedColors.DarkGreen);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(59, global::NPOI.SS.UserModel.IndexedColors.OliveGreen);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(60, global::NPOI.SS.UserModel.IndexedColors.Brown);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(61, global::NPOI.SS.UserModel.IndexedColors.Plum);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(62, global::NPOI.SS.UserModel.IndexedColors.Indigo);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(63, global::NPOI.SS.UserModel.IndexedColors.Grey80Percent);
			global::NPOI.SS.UserModel.IndexedColors.mappingIndex.Add(64, global::NPOI.SS.UserModel.IndexedColors.Automatic);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000ACCB File Offset: 0x00008ECB
		public static global::NPOI.SS.UserModel.IndexedColors ValueOf(string colorName)
		{
			if (global::NPOI.SS.UserModel.IndexedColors.mappingName.ContainsKey(colorName.ToLower()))
			{
				return global::NPOI.SS.UserModel.IndexedColors.mappingName[colorName.ToLower()];
			}
			return null;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000ACF1 File Offset: 0x00008EF1
		public static global::NPOI.SS.UserModel.IndexedColors ValueOf(int index)
		{
			if (global::NPOI.SS.UserModel.IndexedColors.mappingIndex.ContainsKey(index))
			{
				return global::NPOI.SS.UserModel.IndexedColors.mappingIndex[index];
			}
			throw new global::System.ArgumentException("Illegal IndexedColor index: " + index.ToString());
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000AD22 File Offset: 0x00008F22
		public static global::NPOI.SS.UserModel.IndexedColors FromInt(int index)
		{
			return global::NPOI.SS.UserModel.IndexedColors.ValueOf(index);
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0000AD2A File Offset: 0x00008F2A
		public byte[] RGB
		{
			get
			{
				return this.hssfColor.RGB;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0000AD38 File Offset: 0x00008F38
		public string HexString
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(7);
				stringBuilder.Append('#');
				foreach (byte b in this.hssfColor.RGB)
				{
					stringBuilder.Append(b.ToString("x2"));
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000271 RID: 625 RVA: 0x0000AD8C File Offset: 0x00008F8C
		public short Index
		{
			get
			{
				return (short)this.index;
			}
		}

		// Token: 0x04000119 RID: 281
		public static readonly global::NPOI.SS.UserModel.IndexedColors Black = new global::NPOI.SS.UserModel.IndexedColors(8, new global::NPOI.HSSF.Util.HSSFColor.Black());

		// Token: 0x0400011A RID: 282
		public static readonly global::NPOI.SS.UserModel.IndexedColors White = new global::NPOI.SS.UserModel.IndexedColors(9, new global::NPOI.HSSF.Util.HSSFColor.White());

		// Token: 0x0400011B RID: 283
		public static readonly global::NPOI.SS.UserModel.IndexedColors Red = new global::NPOI.SS.UserModel.IndexedColors(10, new global::NPOI.HSSF.Util.HSSFColor.Red());

		// Token: 0x0400011C RID: 284
		public static readonly global::NPOI.SS.UserModel.IndexedColors BrightGreen = new global::NPOI.SS.UserModel.IndexedColors(11, new global::NPOI.HSSF.Util.HSSFColor.BrightGreen());

		// Token: 0x0400011D RID: 285
		public static readonly global::NPOI.SS.UserModel.IndexedColors Blue = new global::NPOI.SS.UserModel.IndexedColors(12, new global::NPOI.HSSF.Util.HSSFColor.Blue());

		// Token: 0x0400011E RID: 286
		public static readonly global::NPOI.SS.UserModel.IndexedColors Yellow = new global::NPOI.SS.UserModel.IndexedColors(13, new global::NPOI.HSSF.Util.HSSFColor.Yellow());

		// Token: 0x0400011F RID: 287
		public static readonly global::NPOI.SS.UserModel.IndexedColors Pink = new global::NPOI.SS.UserModel.IndexedColors(14, new global::NPOI.HSSF.Util.HSSFColor.Pink());

		// Token: 0x04000120 RID: 288
		public static readonly global::NPOI.SS.UserModel.IndexedColors Turquoise = new global::NPOI.SS.UserModel.IndexedColors(15, new global::NPOI.HSSF.Util.HSSFColor.Turquoise());

		// Token: 0x04000121 RID: 289
		public static readonly global::NPOI.SS.UserModel.IndexedColors DarkRed = new global::NPOI.SS.UserModel.IndexedColors(16, new global::NPOI.HSSF.Util.HSSFColor.DarkRed());

		// Token: 0x04000122 RID: 290
		public static readonly global::NPOI.SS.UserModel.IndexedColors Green = new global::NPOI.SS.UserModel.IndexedColors(17, new global::NPOI.HSSF.Util.HSSFColor.Green());

		// Token: 0x04000123 RID: 291
		public static readonly global::NPOI.SS.UserModel.IndexedColors DarkBlue = new global::NPOI.SS.UserModel.IndexedColors(18, new global::NPOI.HSSF.Util.HSSFColor.DarkBlue());

		// Token: 0x04000124 RID: 292
		public static readonly global::NPOI.SS.UserModel.IndexedColors DarkYellow = new global::NPOI.SS.UserModel.IndexedColors(19, new global::NPOI.HSSF.Util.HSSFColor.DarkYellow());

		// Token: 0x04000125 RID: 293
		public static readonly global::NPOI.SS.UserModel.IndexedColors Violet = new global::NPOI.SS.UserModel.IndexedColors(20, new global::NPOI.HSSF.Util.HSSFColor.Violet());

		// Token: 0x04000126 RID: 294
		public static readonly global::NPOI.SS.UserModel.IndexedColors Teal = new global::NPOI.SS.UserModel.IndexedColors(21, new global::NPOI.HSSF.Util.HSSFColor.Teal());

		// Token: 0x04000127 RID: 295
		public static readonly global::NPOI.SS.UserModel.IndexedColors Grey25Percent = new global::NPOI.SS.UserModel.IndexedColors(22, new global::NPOI.HSSF.Util.HSSFColor.Grey25Percent());

		// Token: 0x04000128 RID: 296
		public static readonly global::NPOI.SS.UserModel.IndexedColors Grey50Percent = new global::NPOI.SS.UserModel.IndexedColors(23, new global::NPOI.HSSF.Util.HSSFColor.Grey50Percent());

		// Token: 0x04000129 RID: 297
		public static readonly global::NPOI.SS.UserModel.IndexedColors CornflowerBlue = new global::NPOI.SS.UserModel.IndexedColors(24, new global::NPOI.HSSF.Util.HSSFColor.CornflowerBlue());

		// Token: 0x0400012A RID: 298
		public static readonly global::NPOI.SS.UserModel.IndexedColors Maroon = new global::NPOI.SS.UserModel.IndexedColors(25, new global::NPOI.HSSF.Util.HSSFColor.Maroon());

		// Token: 0x0400012B RID: 299
		public static readonly global::NPOI.SS.UserModel.IndexedColors LemonChiffon = new global::NPOI.SS.UserModel.IndexedColors(26, new global::NPOI.HSSF.Util.HSSFColor.LemonChiffon());

		// Token: 0x0400012C RID: 300
		public static readonly global::NPOI.SS.UserModel.IndexedColors Orchid = new global::NPOI.SS.UserModel.IndexedColors(28, new global::NPOI.HSSF.Util.HSSFColor.Orchid());

		// Token: 0x0400012D RID: 301
		public static readonly global::NPOI.SS.UserModel.IndexedColors Coral = new global::NPOI.SS.UserModel.IndexedColors(29, new global::NPOI.HSSF.Util.HSSFColor.Coral());

		// Token: 0x0400012E RID: 302
		public static readonly global::NPOI.SS.UserModel.IndexedColors RoyalBlue = new global::NPOI.SS.UserModel.IndexedColors(30, new global::NPOI.HSSF.Util.HSSFColor.RoyalBlue());

		// Token: 0x0400012F RID: 303
		public static readonly global::NPOI.SS.UserModel.IndexedColors LightCornflowerBlue = new global::NPOI.SS.UserModel.IndexedColors(31, new global::NPOI.HSSF.Util.HSSFColor.LightCornflowerBlue());

		// Token: 0x04000130 RID: 304
		public static readonly global::NPOI.SS.UserModel.IndexedColors SkyBlue = new global::NPOI.SS.UserModel.IndexedColors(40, new global::NPOI.HSSF.Util.HSSFColor.SkyBlue());

		// Token: 0x04000131 RID: 305
		public static readonly global::NPOI.SS.UserModel.IndexedColors LightTurquoise = new global::NPOI.SS.UserModel.IndexedColors(41, new global::NPOI.HSSF.Util.HSSFColor.LightTurquoise());

		// Token: 0x04000132 RID: 306
		public static readonly global::NPOI.SS.UserModel.IndexedColors LightGreen = new global::NPOI.SS.UserModel.IndexedColors(42, new global::NPOI.HSSF.Util.HSSFColor.LightGreen());

		// Token: 0x04000133 RID: 307
		public static readonly global::NPOI.SS.UserModel.IndexedColors LightYellow = new global::NPOI.SS.UserModel.IndexedColors(43, new global::NPOI.HSSF.Util.HSSFColor.LightYellow());

		// Token: 0x04000134 RID: 308
		public static readonly global::NPOI.SS.UserModel.IndexedColors PaleBlue = new global::NPOI.SS.UserModel.IndexedColors(44, new global::NPOI.HSSF.Util.HSSFColor.PaleBlue());

		// Token: 0x04000135 RID: 309
		public static readonly global::NPOI.SS.UserModel.IndexedColors Rose = new global::NPOI.SS.UserModel.IndexedColors(45, new global::NPOI.HSSF.Util.HSSFColor.Rose());

		// Token: 0x04000136 RID: 310
		public static readonly global::NPOI.SS.UserModel.IndexedColors Lavender = new global::NPOI.SS.UserModel.IndexedColors(46, new global::NPOI.HSSF.Util.HSSFColor.Lavender());

		// Token: 0x04000137 RID: 311
		public static readonly global::NPOI.SS.UserModel.IndexedColors Tan = new global::NPOI.SS.UserModel.IndexedColors(47, new global::NPOI.HSSF.Util.HSSFColor.Tan());

		// Token: 0x04000138 RID: 312
		public static readonly global::NPOI.SS.UserModel.IndexedColors LightBlue = new global::NPOI.SS.UserModel.IndexedColors(48, new global::NPOI.HSSF.Util.HSSFColor.LightBlue());

		// Token: 0x04000139 RID: 313
		public static readonly global::NPOI.SS.UserModel.IndexedColors Aqua = new global::NPOI.SS.UserModel.IndexedColors(49, new global::NPOI.HSSF.Util.HSSFColor.Aqua());

		// Token: 0x0400013A RID: 314
		public static readonly global::NPOI.SS.UserModel.IndexedColors Lime = new global::NPOI.SS.UserModel.IndexedColors(50, new global::NPOI.HSSF.Util.HSSFColor.Lime());

		// Token: 0x0400013B RID: 315
		public static readonly global::NPOI.SS.UserModel.IndexedColors Gold = new global::NPOI.SS.UserModel.IndexedColors(51, new global::NPOI.HSSF.Util.HSSFColor.Gold());

		// Token: 0x0400013C RID: 316
		public static readonly global::NPOI.SS.UserModel.IndexedColors LightOrange = new global::NPOI.SS.UserModel.IndexedColors(52, new global::NPOI.HSSF.Util.HSSFColor.LightOrange());

		// Token: 0x0400013D RID: 317
		public static readonly global::NPOI.SS.UserModel.IndexedColors Orange = new global::NPOI.SS.UserModel.IndexedColors(53, new global::NPOI.HSSF.Util.HSSFColor.Orange());

		// Token: 0x0400013E RID: 318
		public static readonly global::NPOI.SS.UserModel.IndexedColors BlueGrey = new global::NPOI.SS.UserModel.IndexedColors(54, new global::NPOI.HSSF.Util.HSSFColor.BlueGrey());

		// Token: 0x0400013F RID: 319
		public static readonly global::NPOI.SS.UserModel.IndexedColors Grey40Percent = new global::NPOI.SS.UserModel.IndexedColors(55, new global::NPOI.HSSF.Util.HSSFColor.Grey40Percent());

		// Token: 0x04000140 RID: 320
		public static readonly global::NPOI.SS.UserModel.IndexedColors DarkTeal = new global::NPOI.SS.UserModel.IndexedColors(56, new global::NPOI.HSSF.Util.HSSFColor.DarkTeal());

		// Token: 0x04000141 RID: 321
		public static readonly global::NPOI.SS.UserModel.IndexedColors SeaGreen = new global::NPOI.SS.UserModel.IndexedColors(57, new global::NPOI.HSSF.Util.HSSFColor.SeaGreen());

		// Token: 0x04000142 RID: 322
		public static readonly global::NPOI.SS.UserModel.IndexedColors DarkGreen = new global::NPOI.SS.UserModel.IndexedColors(58, new global::NPOI.HSSF.Util.HSSFColor.DarkGreen());

		// Token: 0x04000143 RID: 323
		public static readonly global::NPOI.SS.UserModel.IndexedColors OliveGreen = new global::NPOI.SS.UserModel.IndexedColors(59, new global::NPOI.HSSF.Util.HSSFColor.OliveGreen());

		// Token: 0x04000144 RID: 324
		public static readonly global::NPOI.SS.UserModel.IndexedColors Brown = new global::NPOI.SS.UserModel.IndexedColors(60, new global::NPOI.HSSF.Util.HSSFColor.Brown());

		// Token: 0x04000145 RID: 325
		public static readonly global::NPOI.SS.UserModel.IndexedColors Plum = new global::NPOI.SS.UserModel.IndexedColors(61, new global::NPOI.HSSF.Util.HSSFColor.Plum());

		// Token: 0x04000146 RID: 326
		public static readonly global::NPOI.SS.UserModel.IndexedColors Indigo = new global::NPOI.SS.UserModel.IndexedColors(62, new global::NPOI.HSSF.Util.HSSFColor.Indigo());

		// Token: 0x04000147 RID: 327
		public static readonly global::NPOI.SS.UserModel.IndexedColors Grey80Percent = new global::NPOI.SS.UserModel.IndexedColors(63, new global::NPOI.HSSF.Util.HSSFColor.Grey80Percent());

		// Token: 0x04000148 RID: 328
		public static readonly global::NPOI.SS.UserModel.IndexedColors Automatic = new global::NPOI.SS.UserModel.IndexedColors(64, new global::NPOI.HSSF.Util.HSSFColor.Automatic());

		// Token: 0x04000149 RID: 329
		private int index;

		// Token: 0x0400014A RID: 330
		private global::NPOI.HSSF.Util.HSSFColor hssfColor;

		// Token: 0x0400014B RID: 331
		private static global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.UserModel.IndexedColors> mappingName = new global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.UserModel.IndexedColors>();

		// Token: 0x0400014C RID: 332
		private static global::System.Collections.Generic.Dictionary<int, global::NPOI.SS.UserModel.IndexedColors> mappingIndex;
	}
}
