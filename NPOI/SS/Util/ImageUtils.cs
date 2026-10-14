using System;
using System.Drawing;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.Util;

namespace NPOI.SS.Util
{
	// Token: 0x02000012 RID: 18
	public class ImageUtils
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x00003FC8 File Offset: 0x000021C8
		public static global::System.Drawing.Size GetImageDimension(global::System.IO.Stream is1)
		{
			global::System.Drawing.Size result;
			using (global::System.Drawing.Image image = global::System.Drawing.Image.FromStream(is1))
			{
				int[] resolution = global::NPOI.SS.Util.ImageUtils.GetResolution(image);
				if (resolution[0] == 0)
				{
					resolution[0] = global::NPOI.SS.Util.ImageUtils.PIXEL_DPI;
				}
				if (resolution[1] == 0)
				{
					resolution[1] = global::NPOI.SS.Util.ImageUtils.PIXEL_DPI;
				}
				result = new global::System.Drawing.Size
				{
					Width = image.Width * global::NPOI.SS.Util.ImageUtils.PIXEL_DPI / resolution[0],
					Height = image.Height * global::NPOI.SS.Util.ImageUtils.PIXEL_DPI / resolution[1]
				};
			}
			return result;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00004054 File Offset: 0x00002254
		public static global::System.Drawing.Size GetImageDimension(global::System.IO.Stream is1, global::NPOI.SS.UserModel.PictureType type)
		{
			global::System.Drawing.Size result = default(global::System.Drawing.Size);
			if (type - global::NPOI.SS.UserModel.PictureType.JPEG <= 2)
			{
				using (global::System.Drawing.Image image = global::System.Drawing.Image.FromStream(is1))
				{
					int[] resolution = global::NPOI.SS.Util.ImageUtils.GetResolution(image);
					if (resolution[0] == 0)
					{
						resolution[0] = global::NPOI.SS.Util.ImageUtils.PIXEL_DPI;
					}
					if (resolution[1] == 0)
					{
						resolution[1] = global::NPOI.SS.Util.ImageUtils.PIXEL_DPI;
					}
					result.Width = image.Width * global::NPOI.SS.Util.ImageUtils.PIXEL_DPI / resolution[0];
					result.Height = image.Height * global::NPOI.SS.Util.ImageUtils.PIXEL_DPI / resolution[1];
					return result;
				}
			}
			global::NPOI.SS.Util.ImageUtils.logger.Log(5, "Only JPEG, PNG and DIB pictures can be automatically sized");
			return result;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000040F8 File Offset: 0x000022F8
		public static int[] GetResolution(global::System.Drawing.Image r)
		{
			return new int[]
			{
				(int)r.HorizontalResolution,
				(int)r.VerticalResolution
			};
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00004114 File Offset: 0x00002314
		public static global::System.Drawing.Size SetPreferredSize(global::NPOI.SS.UserModel.IPicture picture, double scaleX, double scaleY)
		{
			global::NPOI.SS.UserModel.IClientAnchor clientAnchor = picture.ClientAnchor;
			bool flag = clientAnchor is global::NPOI.HSSF.UserModel.HSSFClientAnchor;
			global::NPOI.SS.UserModel.IPictureData pictureData = picture.PictureData;
			global::NPOI.SS.UserModel.ISheet sheet = picture.Sheet;
			global::System.Drawing.Size imageDimension = global::NPOI.SS.Util.ImageUtils.GetImageDimension(new global::System.IO.MemoryStream(pictureData.Data), pictureData.PictureType);
			global::System.Drawing.Size dimensionFromAnchor = global::NPOI.SS.Util.ImageUtils.GetDimensionFromAnchor(picture);
			double num = (scaleX == double.MaxValue) ? ((double)imageDimension.Width) : ((double)(dimensionFromAnchor.Width / global::NPOI.Util.Units.EMU_PER_PIXEL) * scaleX);
			double num2 = (scaleY == double.MaxValue) ? ((double)imageDimension.Height) : ((double)(dimensionFromAnchor.Height / global::NPOI.Util.Units.EMU_PER_PIXEL) * scaleY);
			int num3 = clientAnchor.Col1;
			int num4 = 0;
			double num5 = (double)sheet.GetColumnWidthInPixels(num3++);
			if (flag)
			{
				num5 *= 1.0 - (double)clientAnchor.Dx1 / 1024.0;
			}
			else
			{
				num5 -= (double)clientAnchor.Dx1 / (double)global::NPOI.Util.Units.EMU_PER_PIXEL;
			}
			while (num5 < num)
			{
				num5 += (double)sheet.GetColumnWidthInPixels(num3++);
			}
			if (num5 > num)
			{
				double num6 = (double)sheet.GetColumnWidthInPixels(--num3);
				double num7 = num5 - num;
				if (flag)
				{
					num4 = (int)((num6 - num7) / num6 * 1024.0);
				}
				else
				{
					num4 = (int)((num6 - num7) * (double)global::NPOI.Util.Units.EMU_PER_PIXEL);
				}
				if (num4 < 0)
				{
					num4 = 0;
				}
			}
			clientAnchor.Col2 = num3;
			clientAnchor.Dx2 = num4;
			int num8 = clientAnchor.Row1;
			int num9 = 0;
			double num10 = global::NPOI.SS.Util.ImageUtils.GetRowHeightInPixels(sheet, num8++);
			if (flag)
			{
				num10 *= 1.0 - (double)clientAnchor.Dy1 / 256.0;
			}
			else
			{
				num10 -= (double)clientAnchor.Dy1 / (double)global::NPOI.Util.Units.EMU_PER_PIXEL;
			}
			while (num10 < num2)
			{
				num10 += global::NPOI.SS.Util.ImageUtils.GetRowHeightInPixels(sheet, num8++);
			}
			if (num10 > num2)
			{
				double rowHeightInPixels = global::NPOI.SS.Util.ImageUtils.GetRowHeightInPixels(sheet, --num8);
				double num11 = num10 - num2;
				if (flag)
				{
					num9 = (int)((rowHeightInPixels - num11) / rowHeightInPixels * 256.0);
				}
				else
				{
					num9 = (int)((rowHeightInPixels - num11) * (double)global::NPOI.Util.Units.EMU_PER_PIXEL);
				}
				if (num9 < 0)
				{
					num9 = 0;
				}
			}
			clientAnchor.Row2 = num8;
			clientAnchor.Dy2 = num9;
			return new global::System.Drawing.Size((int)global::System.Math.Round(num * (double)global::NPOI.Util.Units.EMU_PER_PIXEL), (int)global::System.Math.Round(num2 * (double)global::NPOI.Util.Units.EMU_PER_PIXEL));
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00004380 File Offset: 0x00002580
		public static global::System.Drawing.Size GetDimensionFromAnchor(global::NPOI.SS.UserModel.IPicture picture)
		{
			global::NPOI.SS.UserModel.IClientAnchor clientAnchor = picture.ClientAnchor;
			bool flag = clientAnchor is global::NPOI.HSSF.UserModel.HSSFClientAnchor;
			global::NPOI.SS.UserModel.ISheet sheet = picture.Sheet;
			int i = clientAnchor.Col1;
			double num = (double)sheet.GetColumnWidthInPixels(i++);
			if (flag)
			{
				num *= 1.0 - (double)clientAnchor.Dx1 / 1024.0;
			}
			else
			{
				num -= (double)clientAnchor.Dx1 / (double)global::NPOI.Util.Units.EMU_PER_PIXEL;
			}
			while (i < clientAnchor.Col2)
			{
				num += (double)sheet.GetColumnWidthInPixels(i++);
			}
			if (flag)
			{
				num += (double)(sheet.GetColumnWidthInPixels(i) * (float)clientAnchor.Dx2) / 1024.0;
			}
			else
			{
				num += (double)clientAnchor.Dx2 / (double)global::NPOI.Util.Units.EMU_PER_PIXEL;
			}
			int j = clientAnchor.Row1;
			double num2 = global::NPOI.SS.Util.ImageUtils.GetRowHeightInPixels(sheet, j++);
			if (flag)
			{
				num2 *= 1.0 - (double)clientAnchor.Dy1 / 256.0;
			}
			else
			{
				num2 -= (double)clientAnchor.Dy1 / (double)global::NPOI.Util.Units.EMU_PER_PIXEL;
			}
			while (j < clientAnchor.Row2)
			{
				num2 += global::NPOI.SS.Util.ImageUtils.GetRowHeightInPixels(sheet, j++);
			}
			if (flag)
			{
				num2 += global::NPOI.SS.Util.ImageUtils.GetRowHeightInPixels(sheet, j) * (double)clientAnchor.Dy2 / 256.0;
			}
			else
			{
				num2 += (double)clientAnchor.Dy2 / (double)global::NPOI.Util.Units.EMU_PER_PIXEL;
			}
			num *= (double)global::NPOI.Util.Units.EMU_PER_PIXEL;
			num2 *= (double)global::NPOI.Util.Units.EMU_PER_PIXEL;
			return new global::System.Drawing.Size((int)global::System.Math.Round(num), (int)global::System.Math.Round(num2));
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00004524 File Offset: 0x00002724
		private static double GetRowHeightInPixels(global::NPOI.SS.UserModel.ISheet sheet, int rowNum)
		{
			global::NPOI.SS.UserModel.IRow row = sheet.GetRow(rowNum);
			return (double)(global::NPOI.Util.Units.ToEMU((double)((row == null) ? sheet.DefaultRowHeightInPoints : row.HeightInPoints)) / global::NPOI.Util.Units.EMU_PER_PIXEL);
		}

		// Token: 0x04000027 RID: 39
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.SS.Util.ImageUtils));

		// Token: 0x04000028 RID: 40
		public static int PIXEL_DPI = 96;
	}
}
