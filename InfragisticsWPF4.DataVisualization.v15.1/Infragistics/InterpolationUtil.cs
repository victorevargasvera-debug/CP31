using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics
{
	// Token: 0x0200009E RID: 158
	public class InterpolationUtil
	{
		// Token: 0x060006F8 RID: 1784 RVA: 0x0001FC64 File Offset: 0x0001DE64
		public static global::System.Collections.Generic.List<global::System.Windows.Point> InterpolatePoints(global::System.Collections.Generic.List<global::System.Windows.Point> interpolatedPoints, double p, global::System.Collections.Generic.List<global::System.Windows.Point> minPoints, global::System.Collections.Generic.List<global::System.Windows.Point> maxPoints)
		{
			double num = 1.0 - p;
			if (interpolatedPoints == null)
			{
				interpolatedPoints = new global::System.Collections.Generic.List<global::System.Windows.Point>();
			}
			if (minPoints == null)
			{
				minPoints = new global::System.Collections.Generic.List<global::System.Windows.Point>();
			}
			int count = minPoints.Count;
			int count2 = maxPoints.Count;
			int num2 = global::System.Math.Max(count, count2);
			int count3 = interpolatedPoints.Count;
			if (count3 < num2)
			{
				interpolatedPoints.InsertRange(count3, new global::System.Windows.Point[num2 - count3]);
			}
			if (count3 > num2)
			{
				interpolatedPoints.RemoveRange(num2, count3 - num2);
			}
			for (int i = 0; i < global::System.Math.Min(count, count2); i++)
			{
				interpolatedPoints[i] = new global::System.Windows.Point(minPoints[i].X * num + maxPoints[i].X * p, minPoints[i].Y * num + maxPoints[i].Y * p);
			}
			if (count < count2)
			{
				global::System.Windows.Point point = (count > 0) ? minPoints[count - 1] : new global::System.Windows.Point(0.0, 0.0);
				for (int j = count; j < count2; j++)
				{
					interpolatedPoints[j] = new global::System.Windows.Point(point.X * num + maxPoints[j].X * p, point.Y * num + maxPoints[j].Y * p);
				}
			}
			if (count > count2)
			{
				global::System.Windows.Point point2 = (count2 > 0) ? maxPoints[count2 - 1] : new global::System.Windows.Point(0.0, 0.0);
				for (int k = count2; k < count; k++)
				{
					interpolatedPoints[k] = (interpolatedPoints[k] = new global::System.Windows.Point(minPoints[k].X * num + point2.X * p, minPoints[k].Y * num + point2.Y * p));
				}
			}
			return interpolatedPoints;
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0001FE60 File Offset: 0x0001E060
		public static global::System.Collections.Generic.List<T> InterpolateValues<T>(global::System.Collections.Generic.List<T> interpolatedValues, double p, global::System.Collections.Generic.List<T> minValues, global::System.Collections.Generic.List<T> maxValues, global::System.Func<T> createEmpty, global::System.Func<double, double, T, T, T> interpolate)
		{
			double arg = 1.0 - p;
			if (interpolatedValues == null)
			{
				interpolatedValues = new global::System.Collections.Generic.List<T>();
			}
			if (minValues == null)
			{
				minValues = new global::System.Collections.Generic.List<T>();
			}
			int count = minValues.Count;
			int count2 = maxValues.Count;
			int num = global::System.Math.Max(count, count2);
			if (interpolatedValues.Count < num)
			{
				int num2 = num - interpolatedValues.Count;
				T[] collection = new T[num2];
				interpolatedValues.InsertRange(interpolatedValues.Count, collection);
			}
			if (interpolatedValues.Count > num)
			{
				interpolatedValues.RemoveRange(num, interpolatedValues.Count - num);
			}
			for (int i = 0; i < global::System.Math.Min(count, count2); i++)
			{
				interpolatedValues[i] = interpolate(p, arg, minValues[i], maxValues[i]);
			}
			if (count < count2)
			{
				T arg2 = (count > 0) ? minValues[count - 1] : createEmpty();
				for (int j = count; j < count2; j++)
				{
					interpolatedValues[j] = interpolate(p, arg, arg2, maxValues[j]);
				}
			}
			if (count > count2)
			{
				T arg3 = (count2 > 0) ? maxValues[count2 - 1] : createEmpty();
				for (int k = count2; k < count; k++)
				{
					interpolatedValues[k] = interpolate(p, arg, minValues[k], arg3);
				}
			}
			return interpolatedValues;
		}
	}
}
