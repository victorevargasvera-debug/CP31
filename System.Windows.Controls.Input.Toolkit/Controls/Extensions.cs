using System;
using System.Windows.Media;

namespace System.Windows.Controls
{
	// Token: 0x02000009 RID: 9
	internal static class Extensions
	{
		// Token: 0x06000059 RID: 89 RVA: 0x0000340C File Offset: 0x0000160C
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

		// Token: 0x0600005A RID: 90 RVA: 0x000034FC File Offset: 0x000016FC
		public static bool Contains(this string s, string value, global::System.StringComparison comparison)
		{
			return s.IndexOf(value, comparison) >= 0;
		}
	}
}
