using System;
using System.Collections.Generic;

namespace NPOI.XSSF.Model
{
	// Token: 0x020000EA RID: 234
	public class ThemeElement
	{
		// Token: 0x06000E87 RID: 3719 RVA: 0x000324BA File Offset: 0x000306BA
		public static global::NPOI.XSSF.Model.ThemeElement ById(int idx)
		{
			if (idx >= global::NPOI.XSSF.Model.ThemeElement.values.Count || idx < 0)
			{
				return global::NPOI.XSSF.Model.ThemeElement.UNKNOWN;
			}
			return global::NPOI.XSSF.Model.ThemeElement.values[idx];
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x000324DE File Offset: 0x000306DE
		private ThemeElement(int idx, string name)
		{
			this.idx = idx;
			this.name = name;
			global::NPOI.XSSF.Model.ThemeElement.values.Add(idx, this);
		}

		// Token: 0x04000443 RID: 1091
		private static global::System.Collections.Generic.SortedDictionary<int, global::NPOI.XSSF.Model.ThemeElement> values = new global::System.Collections.Generic.SortedDictionary<int, global::NPOI.XSSF.Model.ThemeElement>();

		// Token: 0x04000444 RID: 1092
		public static global::NPOI.XSSF.Model.ThemeElement LT1 = new global::NPOI.XSSF.Model.ThemeElement(0, "Lt1");

		// Token: 0x04000445 RID: 1093
		public static global::NPOI.XSSF.Model.ThemeElement DK1 = new global::NPOI.XSSF.Model.ThemeElement(1, "Dk1");

		// Token: 0x04000446 RID: 1094
		public static global::NPOI.XSSF.Model.ThemeElement LT2 = new global::NPOI.XSSF.Model.ThemeElement(2, "Lt2");

		// Token: 0x04000447 RID: 1095
		public static global::NPOI.XSSF.Model.ThemeElement DK2 = new global::NPOI.XSSF.Model.ThemeElement(3, "Dk2");

		// Token: 0x04000448 RID: 1096
		public static global::NPOI.XSSF.Model.ThemeElement ACCENT1 = new global::NPOI.XSSF.Model.ThemeElement(4, "Accent1");

		// Token: 0x04000449 RID: 1097
		public static global::NPOI.XSSF.Model.ThemeElement ACCENT2 = new global::NPOI.XSSF.Model.ThemeElement(5, "Accent2");

		// Token: 0x0400044A RID: 1098
		public static global::NPOI.XSSF.Model.ThemeElement ACCENT3 = new global::NPOI.XSSF.Model.ThemeElement(6, "Accent3");

		// Token: 0x0400044B RID: 1099
		public static global::NPOI.XSSF.Model.ThemeElement ACCENT4 = new global::NPOI.XSSF.Model.ThemeElement(7, "Accent4");

		// Token: 0x0400044C RID: 1100
		public static global::NPOI.XSSF.Model.ThemeElement ACCENT5 = new global::NPOI.XSSF.Model.ThemeElement(8, "Accent5");

		// Token: 0x0400044D RID: 1101
		public static global::NPOI.XSSF.Model.ThemeElement ACCENT6 = new global::NPOI.XSSF.Model.ThemeElement(9, "Accent6");

		// Token: 0x0400044E RID: 1102
		public static global::NPOI.XSSF.Model.ThemeElement HLINK = new global::NPOI.XSSF.Model.ThemeElement(10, "Hlink");

		// Token: 0x0400044F RID: 1103
		public static global::NPOI.XSSF.Model.ThemeElement FOLHLINK = new global::NPOI.XSSF.Model.ThemeElement(11, "FolHlink");

		// Token: 0x04000450 RID: 1104
		public static global::NPOI.XSSF.Model.ThemeElement UNKNOWN = new global::NPOI.XSSF.Model.ThemeElement(-1, null);

		// Token: 0x04000451 RID: 1105
		public int idx;

		// Token: 0x04000452 RID: 1106
		public string name;
	}
}
