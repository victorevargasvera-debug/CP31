using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics
{
	// Token: 0x020000A7 RID: 167
	public class PolygonUtil
	{
		// Token: 0x0600074C RID: 1868 RVA: 0x00023250 File Offset: 0x00021450
		public static bool PolygonContainsPoint(global::System.Collections.Generic.IList<global::System.Windows.Point> points, global::System.Windows.Point pt)
		{
			if (points == null)
			{
				return false;
			}
			int count = points.Count;
			if (count < 4)
			{
				return false;
			}
			bool flag = false;
			int i = 0;
			int index = count - 1;
			while (i < count)
			{
				if (points[i].Y > pt.Y != points[index].Y > pt.Y && pt.X < (points[index].X - points[i].X) * (pt.Y - points[i].Y) / (points[index].Y - points[i].Y) + points[i].X)
				{
					flag = !flag;
				}
				index = i++;
			}
			return flag;
		}
	}
}
