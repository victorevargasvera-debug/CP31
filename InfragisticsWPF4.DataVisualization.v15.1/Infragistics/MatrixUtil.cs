using System;
using System.Windows;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x020000A3 RID: 163
	public static class MatrixUtil
	{
		// Token: 0x06000739 RID: 1849 RVA: 0x000226B4 File Offset: 0x000208B4
		public static global::System.Windows.Media.Matrix GetInverse(this global::System.Windows.Media.Matrix matrix)
		{
			global::System.Windows.Media.Matrix result = default(global::System.Windows.Media.Matrix);
			double num = matrix.M11 * matrix.M22 - matrix.M21 * matrix.M12;
			if (num != 0.0)
			{
				result.M11 = matrix.M22 / num;
				result.M21 = -matrix.M21 / num;
				result.OffsetX = (matrix.M21 * matrix.OffsetY - matrix.OffsetX * matrix.M22) / num;
				result.M12 = -matrix.M12 / num;
				result.M22 = matrix.M11 / num;
				result.OffsetY = (matrix.OffsetX * matrix.M12 - matrix.M11 * matrix.OffsetY) / num;
			}
			return result;
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0002278C File Offset: 0x0002098C
		public static global::System.Windows.Rect Transform(this global::System.Windows.Media.Matrix matrix, global::System.Windows.Rect rc)
		{
			global::System.Windows.Point point = matrix.Transform(new global::System.Windows.Point(rc.Left, rc.Top));
			global::System.Windows.Point point2 = matrix.Transform(new global::System.Windows.Point(rc.Right, rc.Bottom));
			return new global::System.Windows.Rect(point, point2);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x000227D8 File Offset: 0x000209D8
		public static global::System.Windows.Media.Matrix Duplicate(this global::System.Windows.Media.Matrix matrix)
		{
			return new global::System.Windows.Media.Matrix
			{
				M11 = matrix.M11,
				M12 = matrix.M12,
				OffsetX = matrix.OffsetX,
				M21 = matrix.M21,
				M22 = matrix.M22,
				OffsetY = matrix.OffsetY
			};
		}
	}
}
