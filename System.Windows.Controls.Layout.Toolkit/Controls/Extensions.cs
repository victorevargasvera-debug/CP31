using System;
using System.Windows.Media;

namespace System.Windows.Controls
{
	// Token: 0x02000007 RID: 7
	internal static class Extensions
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002C94 File Offset: 0x00000E94
		public static bool Invert(this global::System.Windows.Media.Matrix m, out global::System.Windows.Media.Matrix outputMatrix)
		{
			double num = m.M11 * m.M22 - m.M12 * m.M21;
			if (num == 0.0)
			{
				outputMatrix = m;
				return false;
			}
			global::System.Windows.Media.Matrix matrix = m;
			m.M11 = matrix.M22 / num;
			m.M12 = -1.0 * matrix.M12 / num;
			m.M21 = -1.0 * matrix.M21 / num;
			m.M22 = matrix.M11 / num;
			m.OffsetX = (matrix.OffsetY * matrix.M21 - matrix.OffsetX * matrix.M22) / num;
			m.OffsetY = (matrix.OffsetX * matrix.M12 - matrix.OffsetY * matrix.M11) / num;
			outputMatrix = m;
			return true;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002D84 File Offset: 0x00000F84
		public static bool Contains(this string s, string value, global::System.StringComparison comparison)
		{
			return s.IndexOf(value, comparison) >= 0;
		}
	}
}
