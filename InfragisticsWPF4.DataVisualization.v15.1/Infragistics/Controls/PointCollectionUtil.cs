using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace Infragistics.Controls
{
	// Token: 0x020000A6 RID: 166
	public static class PointCollectionUtil
	{
		// Token: 0x06000741 RID: 1857 RVA: 0x00022D58 File Offset: 0x00020F58
		public static void FlattenTo(this global::System.Collections.Generic.IList<global::System.Windows.Point> points, global::System.Collections.Generic.IList<global::System.Windows.Point> list, double E)
		{
			if (list == null)
			{
				return;
			}
			list.Clear();
			if (points.Count >= 2)
			{
				global::System.Collections.Generic.IList<int> list2 = global::Infragistics.Flattener.Flatten(points.Count, (int i) => points[i].X, (int i) => points[i].Y, E);
				foreach (int index in list2)
				{
					list.Add(points[index]);
				}
			}
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00022E14 File Offset: 0x00021014
		public static global::System.Windows.Rect GetBounds(this global::System.Collections.Generic.IEnumerable<global::System.Windows.Point> points)
		{
			double num = double.PositiveInfinity;
			double num2 = double.PositiveInfinity;
			double num3 = double.NegativeInfinity;
			double num4 = double.NegativeInfinity;
			foreach (global::System.Windows.Point point in points)
			{
				num = global::System.Math.Min(num, point.X);
				num2 = global::System.Math.Min(num2, point.Y);
				num3 = global::System.Math.Max(num3, point.X);
				num4 = global::System.Math.Max(num4, point.Y);
			}
			if (double.IsInfinity(num) || double.IsInfinity(num2) || double.IsInfinity(num2) || double.IsInfinity(num4))
			{
				return global::System.Windows.Rect.Empty;
			}
			return new global::System.Windows.Rect(num, num2, num3 - num, num4 - num2);
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00022EF0 File Offset: 0x000210F0
		public static global::System.Windows.Rect GetBounds(this global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<global::System.Windows.Point>> points)
		{
			global::System.Windows.Rect empty = global::System.Windows.Rect.Empty;
			foreach (global::System.Collections.Generic.IEnumerable<global::System.Windows.Point> points2 in points)
			{
				empty.Union(points2.GetBounds());
			}
			return empty;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00022F48 File Offset: 0x00021148
		public static global::System.Windows.Rect GetBounds(this global::System.Collections.Generic.IList<global::System.Windows.Point> points)
		{
			double num = double.PositiveInfinity;
			double num2 = double.PositiveInfinity;
			double num3 = double.NegativeInfinity;
			double num4 = double.NegativeInfinity;
			for (int i = 0; i < points.Count; i++)
			{
				global::System.Windows.Point point = points[i];
				num = global::System.Math.Min(num, point.X);
				num2 = global::System.Math.Min(num2, point.Y);
				num3 = global::System.Math.Max(num3, point.X);
				num4 = global::System.Math.Max(num4, point.Y);
			}
			if (double.IsInfinity(num) || double.IsInfinity(num2) || double.IsInfinity(num2) || double.IsInfinity(num4))
			{
				return global::System.Windows.Rect.Empty;
			}
			return new global::System.Windows.Rect(num, num2, num3 - num, num4 - num2);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x00023008 File Offset: 0x00021208
		public static global::System.Windows.Rect GetBounds(this global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Windows.Point>> points)
		{
			global::System.Windows.Rect empty = global::System.Windows.Rect.Empty;
			for (int i = 0; i < points.Count; i++)
			{
				global::System.Collections.Generic.List<global::System.Windows.Point> points2 = points[i];
				empty.Union(points2.GetBounds());
			}
			return empty;
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00023044 File Offset: 0x00021244
		public static global::System.Windows.Rect GetBounds(this global::System.Collections.Generic.List<global::System.Windows.Media.PointCollection> points)
		{
			global::System.Windows.Rect empty = global::System.Windows.Rect.Empty;
			for (int i = 0; i < points.Count; i++)
			{
				global::System.Windows.Media.PointCollection points2 = points[i];
				empty.Union(points2.GetBounds());
			}
			return empty;
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00023080 File Offset: 0x00021280
		public static void ClipTo(this global::System.Collections.Generic.IList<global::System.Windows.Point> points, global::System.Collections.Generic.IList<global::System.Windows.Point> list, global::Infragistics.Clipper clipper)
		{
			int count = points.Count;
			for (int i = 0; i < count; i++)
			{
				clipper.Add(points[i]);
			}
			clipper.Target = null;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x000230B4 File Offset: 0x000212B4
		public static global::System.Windows.Point GetCentroid(this global::System.Collections.Generic.IEnumerable<global::System.Windows.Point> points)
		{
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			foreach (global::System.Windows.Point point in points)
			{
				num += point.X;
				num2 += point.Y;
				num3 += 1.0;
			}
			return new global::System.Windows.Point(num / num3, num2 / num3);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00023144 File Offset: 0x00021344
		public static global::System.Windows.Media.PointCollection ToPointCollection(this global::System.Collections.Generic.IEnumerable<global::System.Windows.Point> points)
		{
			global::System.Windows.Media.PointCollection pointCollection = new global::System.Windows.Media.PointCollection();
			foreach (global::System.Windows.Point value in points)
			{
				pointCollection.Add(value);
			}
			return pointCollection;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00023194 File Offset: 0x00021394
		public static global::System.Collections.Generic.List<global::System.Windows.Point> ToPointList(this global::System.Collections.Generic.IEnumerable<global::System.Windows.Point> points)
		{
			global::System.Collections.Generic.List<global::System.Windows.Point> list = new global::System.Collections.Generic.List<global::System.Windows.Point>();
			foreach (global::System.Windows.Point item in points)
			{
				list.Add(item);
			}
			return list;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x000231E4 File Offset: 0x000213E4
		public static global::System.Collections.Generic.List<global::System.Windows.Media.PointCollection> ToPointCollections(this global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Windows.Point>> points)
		{
			global::System.Collections.Generic.List<global::System.Windows.Media.PointCollection> list = new global::System.Collections.Generic.List<global::System.Windows.Media.PointCollection>();
			int count = points.Count;
			for (int i = 0; i < count; i++)
			{
				global::System.Collections.Generic.List<global::System.Windows.Point> list2 = points[i];
				global::System.Windows.Media.PointCollection pointCollection = new global::System.Windows.Media.PointCollection();
				int count2 = list2.Count;
				for (int j = 0; j < count2; j++)
				{
					global::System.Windows.Point value = list2[j];
					pointCollection.Add(value);
				}
				list.Add(pointCollection);
			}
			return list;
		}
	}
}
