using System;

namespace NPOI.Util
{
	// Token: 0x02000295 RID: 661
	public class Units
	{
		// Token: 0x06001221 RID: 4641 RVA: 0x0003644A File Offset: 0x0003464A
		public static int ToEMU(double value)
		{
			return (int)global::System.Math.Round((double)global::NPOI.Util.Units.EMU_PER_POINT * value);
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x0003645A File Offset: 0x0003465A
		public static int PixelToEMU(int pixels)
		{
			return pixels * global::NPOI.Util.Units.EMU_PER_PIXEL;
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x00036463 File Offset: 0x00034663
		public static double ToPoints(long emu)
		{
			return (double)emu / (double)global::NPOI.Util.Units.EMU_PER_POINT;
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x00036470 File Offset: 0x00034670
		public static double FixedPointToDecimal(int fixedPoint)
		{
			double num = (double)(fixedPoint >> 16);
			int num2 = fixedPoint & 65535;
			return num + (double)num2 / 65536.0;
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x00036498 File Offset: 0x00034698
		public static int DoubleToFixedPoint(double floatPoint)
		{
			double num = floatPoint % 1.0;
			int num2 = (int)global::System.Math.Floor(floatPoint - num);
			int num3 = (int)global::System.Math.Round(num * 65536.0, global::System.MidpointRounding.ToEven);
			return num2 << 16 | (num3 & 65535);
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x000364D8 File Offset: 0x000346D8
		public static double MasterToPoints(int masterDPI)
		{
			return (double)masterDPI * (double)global::NPOI.Util.Units.POINT_DPI / (double)global::NPOI.Util.Units.MASTER_DPI;
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x000364EA File Offset: 0x000346EA
		public static int PointsToMaster(double points)
		{
			points *= (double)global::NPOI.Util.Units.MASTER_DPI;
			points /= (double)global::NPOI.Util.Units.POINT_DPI;
			return (int)global::System.Math.Round(points, global::System.MidpointRounding.ToEven);
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x00036508 File Offset: 0x00034708
		public static int PointsToPixel(double points)
		{
			points *= (double)global::NPOI.Util.Units.PIXEL_DPI;
			points /= (double)global::NPOI.Util.Units.POINT_DPI;
			return (int)global::System.Math.Round(points, global::System.MidpointRounding.ToEven);
		}

		// Token: 0x06001229 RID: 4649 RVA: 0x00036526 File Offset: 0x00034726
		public static double PixelToPoints(int pixel)
		{
			return (double)pixel * (double)global::NPOI.Util.Units.POINT_DPI / (double)global::NPOI.Util.Units.PIXEL_DPI;
		}

		// Token: 0x0400077D RID: 1917
		public static int EMU_PER_PIXEL = 9525;

		// Token: 0x0400077E RID: 1918
		public static int EMU_PER_POINT = 12700;

		// Token: 0x0400077F RID: 1919
		public static int EMU_PER_CENTIMETER = 360000;

		// Token: 0x04000780 RID: 1920
		public static int MASTER_DPI = 576;

		// Token: 0x04000781 RID: 1921
		public static int PIXEL_DPI = 96;

		// Token: 0x04000782 RID: 1922
		public static int POINT_DPI = 72;
	}
}
