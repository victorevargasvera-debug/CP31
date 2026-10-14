using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x020000A8 RID: 168
	public static class PolySimplification
	{
		// Token: 0x0600074E RID: 1870 RVA: 0x00023344 File Offset: 0x00021544
		public static int VertexReduction(global::System.Tuple<double[], double[]> points, double tolerance)
		{
			double[] item = points.Item1;
			double[] item2 = points.Item2;
			if (item.Length == 0)
			{
				return 0;
			}
			int num = 0;
			int num2 = 0;
			double num3 = tolerance * tolerance;
			num++;
			for (int i = 0; i < item.Length; i++)
			{
				double num4 = item[i] - item[num2];
				double num5 = item2[i] - item2[num2];
				double num6 = num4 * num4 + num5 * num5;
				if (num6 > num3)
				{
					item[num] = item[i];
					item2[num] = item2[i];
					num++;
					num2 = i;
				}
			}
			return num;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x000233C4 File Offset: 0x000215C4
		private static double SquareDistance(global::System.Windows.Point p1, global::System.Windows.Point p2)
		{
			double num = p2.X - p1.X;
			double num2 = p2.Y - p1.Y;
			return num * num + num2 * num2;
		}
	}
}
