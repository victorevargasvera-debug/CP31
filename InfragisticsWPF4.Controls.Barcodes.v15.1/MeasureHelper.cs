using System;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000016 RID: 22
	internal static class MeasureHelper
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000BD04 File Offset: 0x00009F04
		public static double XDpi
		{
			get
			{
				return 96.0;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000088 RID: 136 RVA: 0x0000BD0F File Offset: 0x00009F0F
		public static double YDpi
		{
			get
			{
				return 96.0;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000BD1C File Offset: 0x00009F1C
		public static double GetXPixels(double milimeters)
		{
			double xdpi = global::Infragistics.Controls.Barcodes.MeasureHelper.XDpi;
			return global::Infragistics.Controls.Barcodes.MeasureHelper.ConvertToInch(milimeters * xdpi);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000BD38 File Offset: 0x00009F38
		public static double GetYPixels(double milimeters)
		{
			double ydpi = global::Infragistics.Controls.Barcodes.MeasureHelper.YDpi;
			return global::Infragistics.Controls.Barcodes.MeasureHelper.ConvertToInch(milimeters * ydpi);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000BD53 File Offset: 0x00009F53
		public static double GetXMilimeters(double pixels)
		{
			return global::Infragistics.Controls.Barcodes.MeasureHelper.ConvertToMilimeters(pixels / global::Infragistics.Controls.Barcodes.MeasureHelper.XDpi);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000BD61 File Offset: 0x00009F61
		public static double GetYMilimenters(double pixels)
		{
			return global::Infragistics.Controls.Barcodes.MeasureHelper.ConvertToMilimeters(pixels / global::Infragistics.Controls.Barcodes.MeasureHelper.YDpi);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000BD6F File Offset: 0x00009F6F
		public static double ConvertToInch(double milimeters)
		{
			return milimeters / 25.4;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000BD7C File Offset: 0x00009F7C
		public static double ConvertToMilimeters(double inches)
		{
			return inches * 25.4;
		}
	}
}
