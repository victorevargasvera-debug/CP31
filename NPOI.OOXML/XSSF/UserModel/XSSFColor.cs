using System;
using System.Drawing;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200006F RID: 111
	public class XSSFColor : global::NPOI.SS.UserModel.ExtendedColor
	{
		// Token: 0x06000557 RID: 1367 RVA: 0x0001494E File Offset: 0x00012B4E
		public XSSFColor(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color color)
		{
			this.ctColor = color;
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0001495D File Offset: 0x00012B5D
		public XSSFColor()
		{
			this.ctColor = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color();
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00014970 File Offset: 0x00012B70
		public XSSFColor(global::System.Drawing.Color clr) : this()
		{
			this.ctColor.SetRgb(clr.R, clr.G, clr.B);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00014998 File Offset: 0x00012B98
		public XSSFColor(byte[] rgb) : this()
		{
			this.ctColor.SetRgb(rgb);
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x000149AC File Offset: 0x00012BAC
		public XSSFColor(global::NPOI.SS.UserModel.IndexedColors indexedColor) : this()
		{
			this.ctColor.indexed = (uint)indexedColor.Index;
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x000149C5 File Offset: 0x00012BC5
		// (set) Token: 0x0600055D RID: 1373 RVA: 0x000149D2 File Offset: 0x00012BD2
		public override bool IsAuto
		{
			get
			{
				return this.ctColor.auto;
			}
			set
			{
				this.ctColor.auto = value;
				this.ctColor.autoSpecified = true;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x000149EC File Offset: 0x00012BEC
		public override bool IsIndexed
		{
			get
			{
				return this.ctColor.IsSetIndexed();
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x000149F9 File Offset: 0x00012BF9
		public override bool IsRGB
		{
			get
			{
				return this.ctColor.IsSetRgb();
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x00014A06 File Offset: 0x00012C06
		public override bool IsThemed
		{
			get
			{
				return this.ctColor.IsSetTheme();
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00014A13 File Offset: 0x00012C13
		public bool HasAlpha
		{
			get
			{
				return this.ctColor.IsSetRgb() && this.ctColor.rgb.Length == 4;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00014A34 File Offset: 0x00012C34
		public bool HasTint
		{
			get
			{
				return this.ctColor.IsSetTint() && this.ctColor.tint != 0.0;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x00014A5E File Offset: 0x00012C5E
		public override short Index
		{
			get
			{
				if (!this.ctColor.indexedSpecified)
				{
					return 0;
				}
				return (short)this.ctColor.indexed;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x00014A7B File Offset: 0x00012C7B
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x00014A83 File Offset: 0x00012C83
		public short Indexed
		{
			get
			{
				return this.Index;
			}
			set
			{
				this.ctColor.indexed = (uint)value;
				this.ctColor.indexedSpecified = true;
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00014A9D File Offset: 0x00012C9D
		[global::System.Obsolete("use property RGB")]
		public byte[] GetRgb()
		{
			return this.RGB;
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00014AA5 File Offset: 0x00012CA5
		protected override byte[] StoredRBG
		{
			get
			{
				return this.ctColor.rgb;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00014AB4 File Offset: 0x00012CB4
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x00014AE7 File Offset: 0x00012CE7
		public override byte[] RGB
		{
			get
			{
				byte[] rgborARGB = base.GetRGBOrARGB();
				if (rgborARGB == null)
				{
					return null;
				}
				if (rgborARGB.Length == 4)
				{
					byte[] array = new byte[3];
					global::System.Array.Copy(rgborARGB, 1, array, 0, 3);
					return array;
				}
				return rgborARGB;
			}
			set
			{
				this.ctColor.SetRgb(value);
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x00014AF8 File Offset: 0x00012CF8
		public override byte[] ARGB
		{
			get
			{
				byte[] rgborARGB = base.GetRGBOrARGB();
				if (rgborARGB == null)
				{
					return null;
				}
				if (rgborARGB.Length == 3)
				{
					byte[] array = new byte[4];
					array[0] = byte.MaxValue;
					global::System.Array.Copy(rgborARGB, 0, array, 1, 3);
					return array;
				}
				return rgborARGB;
			}
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00014B33 File Offset: 0x00012D33
		[global::System.Obsolete("use property ARGB")]
		public byte[] GetARgb()
		{
			return this.ARGB;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00014B3C File Offset: 0x00012D3C
		public byte[] GetRgbWithTint()
		{
			byte[] array = this.ctColor.GetRgb();
			if (array != null)
			{
				if (array.Length == 4)
				{
					byte[] array2 = new byte[3];
					global::System.Array.Copy(array, 1, array2, 0, 3);
					array = array2;
				}
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = global::NPOI.XSSF.UserModel.XSSFColor.ApplyTint((int)(array[i] & byte.MaxValue), this.ctColor.tint);
				}
			}
			return array;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00014B9C File Offset: 0x00012D9C
		private static byte ApplyTint(int lum, double tint)
		{
			if (tint > 0.0)
			{
				return (byte)((double)lum * (1.0 - tint) + (255.0 - 255.0 * (1.0 - tint)));
			}
			if (tint < 0.0)
			{
				return (byte)((double)lum * (1.0 + tint));
			}
			return (byte)lum;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00014AE7 File Offset: 0x00012CE7
		public void SetRgb(byte[] rgb)
		{
			this.ctColor.SetRgb(rgb);
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x00014C03 File Offset: 0x00012E03
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x00014C1F File Offset: 0x00012E1F
		public override int Theme
		{
			get
			{
				if (!this.ctColor.themeSpecified)
				{
					return 0;
				}
				return (int)this.ctColor.theme;
			}
			set
			{
				this.ctColor.theme = (uint)value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x00014C2D File Offset: 0x00012E2D
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x00014C3A File Offset: 0x00012E3A
		public override double Tint
		{
			get
			{
				return this.ctColor.tint;
			}
			set
			{
				this.ctColor.tint = value;
				this.ctColor.tintSpecified = true;
			}
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00014C54 File Offset: 0x00012E54
		internal global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color GetCTColor()
		{
			return this.ctColor;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00014C5C File Offset: 0x00012E5C
		public static global::NPOI.XSSF.UserModel.XSSFColor ToXSSFColor(global::NPOI.SS.UserModel.IColor color)
		{
			if (color != null && !(color is global::NPOI.XSSF.UserModel.XSSFColor))
			{
				throw new global::System.ArgumentException("Only XSSFColor objects are supported");
			}
			return (global::NPOI.XSSF.UserModel.XSSFColor)color;
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00014C7A File Offset: 0x00012E7A
		private bool SameIndexed(global::NPOI.XSSF.UserModel.XSSFColor other)
		{
			return this.IsIndexed == other.IsIndexed && (!this.IsIndexed || this.Indexed == other.Indexed);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00014CA4 File Offset: 0x00012EA4
		private bool SameARGB(global::NPOI.XSSF.UserModel.XSSFColor other)
		{
			return this.IsRGB == other.IsRGB && (!this.IsRGB || global::NPOI.Util.Arrays.Equals(this.ARGB, other.ARGB));
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00014CD1 File Offset: 0x00012ED1
		private bool SameTheme(global::NPOI.XSSF.UserModel.XSSFColor other)
		{
			return this.IsThemed == other.IsThemed && (!this.IsThemed || this.Theme == other.Theme);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00014CFB File Offset: 0x00012EFB
		private bool SameTint(global::NPOI.XSSF.UserModel.XSSFColor other)
		{
			return this.HasTint == other.HasTint && (!this.HasTint || this.Tint == other.Tint);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00014D25 File Offset: 0x00012F25
		private bool SameAuto(global::NPOI.XSSF.UserModel.XSSFColor other)
		{
			return this.IsAuto == other.IsAuto;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00014D35 File Offset: 0x00012F35
		public override int GetHashCode()
		{
			return this.ctColor.ToString().GetHashCode();
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00014D48 File Offset: 0x00012F48
		public override bool Equals(object o)
		{
			if (o == null || !(o is global::NPOI.XSSF.UserModel.XSSFColor))
			{
				return false;
			}
			global::NPOI.XSSF.UserModel.XSSFColor other = (global::NPOI.XSSF.UserModel.XSSFColor)o;
			return this.SameARGB(other) && this.SameTheme(other) && this.SameIndexed(other) && this.SameTint(other) && this.SameAuto(other);
		}

		// Token: 0x040002AE RID: 686
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_Color ctColor;
	}
}
