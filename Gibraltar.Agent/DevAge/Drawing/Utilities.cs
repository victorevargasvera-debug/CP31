using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace DevAge.Drawing
{
	// Token: 0x020002FF RID: 767
	internal static class Utilities
	{
		// Token: 0x060024A2 RID: 9378 RVA: 0x0007F8AC File Offset: 0x0007DAAC
		public static void DrawRoundedRectangle(global::System.Drawing.Graphics g, global::DevAge.Drawing.RoundedRectangle roundRect, global::System.Drawing.Pen pen)
		{
			int num = (int)pen.Width;
			global::System.Drawing.Rectangle rect = new global::System.Drawing.Rectangle(roundRect.Rectangle.X + num / 2, roundRect.Rectangle.Y + num / 2, roundRect.Rectangle.Width - num, roundRect.Rectangle.Height - num);
			global::DevAge.Drawing.RoundedRectangle roundedRectangle = new global::DevAge.Drawing.RoundedRectangle(rect, roundRect.RoundValue);
			g.DrawPath(pen, roundedRectangle.ToGraphicsPath());
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x0007F934 File Offset: 0x0007DB34
		public static void FillRoundedRectangle(global::System.Drawing.Graphics g, global::DevAge.Drawing.RoundedRectangle roundRect, global::System.Drawing.Brush brush)
		{
			global::System.Drawing.Rectangle rect = new global::System.Drawing.Rectangle(roundRect.Rectangle.X, roundRect.Rectangle.Y, roundRect.Rectangle.Width - 1, roundRect.Rectangle.Height - 1);
			global::DevAge.Drawing.RoundedRectangle roundedRectangle = new global::DevAge.Drawing.RoundedRectangle(rect, roundRect.RoundValue);
			g.FillRegion(brush, new global::System.Drawing.Region(roundedRectangle.ToGraphicsPath()));
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x0007F9B0 File Offset: 0x0007DBB0
		public static void DrawGradient3DBorder(global::System.Drawing.Graphics g, global::System.Drawing.Rectangle p_HeaderRectangle, global::System.Drawing.Color p_BackColor, global::System.Drawing.Color p_DarkColor, global::System.Drawing.Color p_LightColor, int p_DarkGradientNumber, int p_LightGradientNumber, global::DevAge.Drawing.Gradient3DBorderStyle p_Style)
		{
			global::System.Drawing.Color p_EndColor;
			int p_NumberOfGradients;
			global::System.Drawing.Color p_EndColor2;
			int p_NumberOfGradients2;
			if (p_Style == global::DevAge.Drawing.Gradient3DBorderStyle.Raised)
			{
				p_EndColor = p_LightColor;
				p_NumberOfGradients = p_LightGradientNumber;
				p_EndColor2 = p_DarkColor;
				p_NumberOfGradients2 = p_DarkGradientNumber;
			}
			else
			{
				p_EndColor = p_DarkColor;
				p_NumberOfGradients = p_DarkGradientNumber;
				p_EndColor2 = p_LightColor;
				p_NumberOfGradients2 = p_LightGradientNumber;
			}
			global::System.Drawing.Color[] array = global::DevAge.Drawing.Utilities.CalculateColorGradient(p_BackColor, p_EndColor, p_NumberOfGradients);
			using (global::System.Drawing.Pen pen = new global::System.Drawing.Pen(array[0]))
			{
				for (int i = 0; i < array.Length; i++)
				{
					pen.Color = array[array.Length - (i + 1)];
					g.DrawLine(pen, p_HeaderRectangle.Left + i, p_HeaderRectangle.Top + i, p_HeaderRectangle.Right - (i + 1), p_HeaderRectangle.Top + i);
					g.DrawLine(pen, p_HeaderRectangle.Left + i, p_HeaderRectangle.Top + i, p_HeaderRectangle.Left + i, p_HeaderRectangle.Bottom - (i + 1));
				}
			}
			global::System.Drawing.Color[] array2 = global::DevAge.Drawing.Utilities.CalculateColorGradient(p_BackColor, p_EndColor2, p_NumberOfGradients2);
			using (global::System.Drawing.Pen pen2 = new global::System.Drawing.Pen(array2[0]))
			{
				for (int j = 0; j < array2.Length; j++)
				{
					pen2.Color = array2[array2.Length - (j + 1)];
					g.DrawLine(pen2, p_HeaderRectangle.Left + j, p_HeaderRectangle.Bottom - (j + 1), p_HeaderRectangle.Right - (j + 1), p_HeaderRectangle.Bottom - (j + 1));
					g.DrawLine(pen2, p_HeaderRectangle.Right - (j + 1), p_HeaderRectangle.Top + j, p_HeaderRectangle.Right - (j + 1), p_HeaderRectangle.Bottom - (j + 1));
				}
			}
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x0007FB9C File Offset: 0x0007DD9C
		public static global::System.Drawing.Color[] CalculateColorGradient(global::System.Drawing.Color p_StartColor, global::System.Drawing.Color p_EndColor, int p_NumberOfGradients)
		{
			if (p_NumberOfGradients < 2)
			{
				throw new global::System.ArgumentException("Invalid Number of gradients, must be 2 or more");
			}
			global::System.Drawing.Color[] array = new global::System.Drawing.Color[p_NumberOfGradients];
			array[0] = p_StartColor;
			array[array.Length - 1] = p_EndColor;
			float num = (float)(p_EndColor.A - p_StartColor.A) / (float)p_NumberOfGradients;
			float num2 = (float)(p_EndColor.R - p_StartColor.R) / (float)p_NumberOfGradients;
			float num3 = (float)(p_EndColor.G - p_StartColor.G) / (float)p_NumberOfGradients;
			float num4 = (float)(p_EndColor.B - p_StartColor.B) / (float)p_NumberOfGradients;
			for (int i = 1; i < array.Length - 1; i++)
			{
				array[i] = global::System.Drawing.Color.FromArgb((int)((float)p_StartColor.A + num * (float)i), (int)((float)p_StartColor.R + num2 * (float)i), (int)((float)p_StartColor.G + num3 * (float)i), (int)((float)p_StartColor.B + num4 * (float)i));
			}
			return array;
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x0007FC9C File Offset: 0x0007DE9C
		public static global::System.Drawing.Color CalculateMiddleColor(global::System.Drawing.Color p_StartColor, global::System.Drawing.Color p_EndColor)
		{
			return global::DevAge.Drawing.Utilities.CalculateColorGradient(p_StartColor, p_EndColor, 3)[1];
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x0007FCB4 File Offset: 0x0007DEB4
		public static global::System.Drawing.Color CalculateLightDarkColor(global::System.Drawing.Color source, float light)
		{
			if (light == 0f)
			{
				return source;
			}
			if (light > 1f || light < -1f)
			{
				throw new global::System.ArgumentException("Must be between 1 and -1", "light");
			}
			float num;
			float num2;
			float num3;
			if (light < 0f)
			{
				num = (float)source.R / 100f;
				num2 = (float)source.G / 100f;
				num3 = (float)source.B / 100f;
			}
			else
			{
				num = (float)(byte.MaxValue - source.R) / 100f;
				num2 = (float)(byte.MaxValue - source.G) / 100f;
				num3 = (float)(byte.MaxValue - source.B) / 100f;
			}
			int num4 = (int)source.R + (int)(num * light * 100f);
			int num5 = (int)source.G + (int)(num2 * light * 100f);
			int num6 = (int)source.B + (int)(num3 * light * 100f);
			if (num4 > 255)
			{
				num4 = 255;
			}
			else if (num4 < 0)
			{
				num4 = 0;
			}
			if (num5 > 255)
			{
				num5 = 255;
			}
			else if (num5 < 0)
			{
				num5 = 0;
			}
			if (num6 > 255)
			{
				num6 = 255;
			}
			else if (num6 < 0)
			{
				num6 = 0;
			}
			return global::System.Drawing.Color.FromArgb((int)source.A, num4, num5, num6);
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x0007FE28 File Offset: 0x0007E028
		public static global::DevAge.Drawing.ContentAlignment StringFormatToContentAlignment(global::System.Drawing.StringFormat p_StringFormat)
		{
			if (global::DevAge.Drawing.Utilities.IsBottom(p_StringFormat) && global::DevAge.Drawing.Utilities.IsLeft(p_StringFormat))
			{
				return global::DevAge.Drawing.ContentAlignment.BottomLeft;
			}
			if (global::DevAge.Drawing.Utilities.IsBottom(p_StringFormat) && global::DevAge.Drawing.Utilities.IsRight(p_StringFormat))
			{
				return global::DevAge.Drawing.ContentAlignment.BottomRight;
			}
			if (global::DevAge.Drawing.Utilities.IsBottom(p_StringFormat) && global::DevAge.Drawing.Utilities.IsCenter(p_StringFormat))
			{
				return global::DevAge.Drawing.ContentAlignment.BottomCenter;
			}
			if (global::DevAge.Drawing.Utilities.IsTop(p_StringFormat) && global::DevAge.Drawing.Utilities.IsLeft(p_StringFormat))
			{
				return global::DevAge.Drawing.ContentAlignment.TopLeft;
			}
			if (global::DevAge.Drawing.Utilities.IsTop(p_StringFormat) && global::DevAge.Drawing.Utilities.IsRight(p_StringFormat))
			{
				return global::DevAge.Drawing.ContentAlignment.TopRight;
			}
			if (global::DevAge.Drawing.Utilities.IsTop(p_StringFormat) && global::DevAge.Drawing.Utilities.IsCenter(p_StringFormat))
			{
				return global::DevAge.Drawing.ContentAlignment.TopCenter;
			}
			if (global::DevAge.Drawing.Utilities.IsMiddle(p_StringFormat) && global::DevAge.Drawing.Utilities.IsLeft(p_StringFormat))
			{
				return global::DevAge.Drawing.ContentAlignment.MiddleLeft;
			}
			if (global::DevAge.Drawing.Utilities.IsMiddle(p_StringFormat) && global::DevAge.Drawing.Utilities.IsRight(p_StringFormat))
			{
				return global::DevAge.Drawing.ContentAlignment.MiddleRight;
			}
			return global::DevAge.Drawing.ContentAlignment.MiddleCenter;
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x0007FF0C File Offset: 0x0007E10C
		public static void ApplyContentAlignmentToStringFormat(global::DevAge.Drawing.ContentAlignment pAlignment, global::System.Drawing.StringFormat stringFormat)
		{
			if (global::DevAge.Drawing.Utilities.IsBottom(pAlignment))
			{
				stringFormat.LineAlignment = global::System.Drawing.StringAlignment.Far;
			}
			else if (global::DevAge.Drawing.Utilities.IsMiddle(pAlignment))
			{
				stringFormat.LineAlignment = global::System.Drawing.StringAlignment.Center;
			}
			else
			{
				stringFormat.LineAlignment = global::System.Drawing.StringAlignment.Near;
			}
			if (global::DevAge.Drawing.Utilities.IsRight(pAlignment))
			{
				stringFormat.Alignment = global::System.Drawing.StringAlignment.Far;
				return;
			}
			if (global::DevAge.Drawing.Utilities.IsCenter(pAlignment))
			{
				stringFormat.Alignment = global::System.Drawing.StringAlignment.Center;
				return;
			}
			stringFormat.Alignment = global::System.Drawing.StringAlignment.Near;
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x0007FF80 File Offset: 0x0007E180
		public static bool IsBottom(global::DevAge.Drawing.ContentAlignment a)
		{
			return a == global::DevAge.Drawing.ContentAlignment.BottomCenter || a == global::DevAge.Drawing.ContentAlignment.BottomLeft || a == global::DevAge.Drawing.ContentAlignment.BottomRight;
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x0007FFA4 File Offset: 0x0007E1A4
		public static bool IsTop(global::DevAge.Drawing.ContentAlignment a)
		{
			return a == global::DevAge.Drawing.ContentAlignment.TopCenter || a == global::DevAge.Drawing.ContentAlignment.TopLeft || a == global::DevAge.Drawing.ContentAlignment.TopRight;
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x0007FFBC File Offset: 0x0007E1BC
		public static bool IsMiddle(global::DevAge.Drawing.ContentAlignment a)
		{
			return a == global::DevAge.Drawing.ContentAlignment.MiddleCenter || a == global::DevAge.Drawing.ContentAlignment.MiddleLeft || a == global::DevAge.Drawing.ContentAlignment.MiddleRight;
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x0007FFD8 File Offset: 0x0007E1D8
		public static bool IsCenter(global::DevAge.Drawing.ContentAlignment a)
		{
			return a == global::DevAge.Drawing.ContentAlignment.BottomCenter || a == global::DevAge.Drawing.ContentAlignment.MiddleCenter || a == global::DevAge.Drawing.ContentAlignment.TopCenter;
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x0007FFF4 File Offset: 0x0007E1F4
		public static bool IsLeft(global::DevAge.Drawing.ContentAlignment a)
		{
			return a == global::DevAge.Drawing.ContentAlignment.BottomLeft || a == global::DevAge.Drawing.ContentAlignment.MiddleLeft || a == global::DevAge.Drawing.ContentAlignment.TopLeft;
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x00080010 File Offset: 0x0007E210
		public static bool IsRight(global::DevAge.Drawing.ContentAlignment a)
		{
			return a == global::DevAge.Drawing.ContentAlignment.BottomRight || a == global::DevAge.Drawing.ContentAlignment.MiddleRight || a == global::DevAge.Drawing.ContentAlignment.TopRight;
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x0008002C File Offset: 0x0007E22C
		public static bool IsBottom(global::System.Drawing.StringFormat a)
		{
			return a.LineAlignment == global::System.Drawing.StringAlignment.Far;
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x00080038 File Offset: 0x0007E238
		public static bool IsTop(global::System.Drawing.StringFormat a)
		{
			return a.LineAlignment == global::System.Drawing.StringAlignment.Near;
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x00080044 File Offset: 0x0007E244
		public static bool IsMiddle(global::System.Drawing.StringFormat a)
		{
			return a.LineAlignment == global::System.Drawing.StringAlignment.Center;
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x00080050 File Offset: 0x0007E250
		public static bool IsCenter(global::System.Drawing.StringFormat a)
		{
			return a.Alignment == global::System.Drawing.StringAlignment.Center;
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x0008005C File Offset: 0x0007E25C
		public static bool IsLeft(global::System.Drawing.StringFormat a)
		{
			return a.Alignment == global::System.Drawing.StringAlignment.Near;
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x00080068 File Offset: 0x0007E268
		public static bool IsRight(global::System.Drawing.StringFormat a)
		{
			return a.Alignment == global::System.Drawing.StringAlignment.Far;
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x00080074 File Offset: 0x0007E274
		public static byte[] ImageToBytes(global::System.Drawing.Image img, global::System.Drawing.Imaging.ImageFormat imgFormat)
		{
			if (img == null)
			{
				return new byte[0];
			}
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				img.Save(memoryStream, imgFormat);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x000800C8 File Offset: 0x0007E2C8
		public static global::System.Drawing.Image BytesToImage(byte[] bytes)
		{
			if (bytes == null || bytes.Length == 0)
			{
				return null;
			}
			global::System.Drawing.Image result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(bytes))
			{
				result = global::System.Drawing.Image.FromStream(memoryStream);
			}
			return result;
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x00080118 File Offset: 0x0007E318
		public static global::System.Drawing.Image CreateDisabledImage(global::System.Drawing.Image image, global::System.Drawing.Color background)
		{
			if (image == null)
			{
				return null;
			}
			global::System.Drawing.Size size = image.Size;
			if (global::DevAge.Drawing.Utilities.t_DisabledImageAttr == null)
			{
				float[][] array = new float[5][];
				array[0] = new float[]
				{
					0.2125f,
					0.2125f,
					0.2125f,
					0f,
					0f
				};
				array[1] = new float[]
				{
					0.2577f,
					0.2577f,
					0.2577f,
					0f,
					0f
				};
				array[2] = new float[]
				{
					0.0361f,
					0.0361f,
					0.0361f,
					0f,
					0f
				};
				float[] array2 = new float[5];
				array2[3] = 1f;
				array[3] = array2;
				array[4] = new float[]
				{
					0.38f,
					0.38f,
					0.38f,
					0f,
					1f
				};
				global::System.Drawing.Imaging.ColorMatrix colorMatrix = new global::System.Drawing.Imaging.ColorMatrix(array);
				global::DevAge.Drawing.Utilities.t_DisabledImageAttr = new global::System.Drawing.Imaging.ImageAttributes();
				global::DevAge.Drawing.Utilities.t_DisabledImageAttr.ClearColorKey();
				global::DevAge.Drawing.Utilities.t_DisabledImageAttr.SetColorMatrix(colorMatrix);
			}
			global::System.Drawing.Bitmap bitmap = new global::System.Drawing.Bitmap(image.Width, image.Height);
			using (global::System.Drawing.Graphics graphics = global::System.Drawing.Graphics.FromImage(bitmap))
			{
				graphics.DrawImage(image, new global::System.Drawing.Rectangle(0, 0, size.Width, size.Height), 0, 0, size.Width, size.Height, global::System.Drawing.GraphicsUnit.Pixel, global::DevAge.Drawing.Utilities.t_DisabledImageAttr);
			}
			return bitmap;
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x00080248 File Offset: 0x0007E448
		public static global::System.Drawing.SizeF CheckMeasure(global::System.Drawing.SizeF measureSize, global::System.Drawing.SizeF minSize, global::System.Drawing.SizeF maxSize)
		{
			if (minSize.Width > 0f && measureSize.Width < minSize.Width)
			{
				measureSize.Width = minSize.Width;
			}
			if (minSize.Height > 0f && measureSize.Height < minSize.Height)
			{
				measureSize.Height = minSize.Height;
			}
			if (maxSize.Width > 0f && measureSize.Width > maxSize.Width)
			{
				measureSize.Width = maxSize.Width;
			}
			if (maxSize.Height > 0f && measureSize.Height > maxSize.Height)
			{
				measureSize.Height = maxSize.Height;
			}
			return measureSize;
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x00080324 File Offset: 0x0007E524
		public static global::System.Drawing.Size SizeFToSize(global::System.Drawing.SizeF sizef)
		{
			return new global::System.Drawing.Size((int)global::System.Math.Ceiling((double)sizef.Width), (int)global::System.Math.Ceiling((double)sizef.Height));
		}

		// Token: 0x04000CDC RID: 3292
		[global::System.ThreadStatic]
		private static global::System.Drawing.Imaging.ImageAttributes t_DisabledImageAttr;
	}
}
