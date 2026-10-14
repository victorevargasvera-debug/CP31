using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200025A RID: 602
	internal class BitmapImageComparer : global::System.Collections.Generic.IComparer<global::System.Windows.Media.Imaging.BitmapImage>, global::System.Collections.Generic.IEqualityComparer<global::System.Windows.Media.Imaging.BitmapImage>
	{
		// Token: 0x06001350 RID: 4944 RVA: 0x00048960 File Offset: 0x00046B60
		public int Compare(global::System.Windows.Media.Imaging.BitmapImage x, global::System.Windows.Media.Imaging.BitmapImage y)
		{
			if (x == null && y == null)
			{
				return 0;
			}
			if (x == null)
			{
				return -1;
			}
			if (y == null)
			{
				return 1;
			}
			return global::System.Uri.Compare(x.UriSource, y.UriSource, global::System.UriComponents.AbsoluteUri, global::System.UriFormat.SafeUnescaped, global::System.StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x00048996 File Offset: 0x00046B96
		public bool Equals(global::System.Windows.Media.Imaging.BitmapImage x, global::System.Windows.Media.Imaging.BitmapImage y)
		{
			return this.Compare(x, y) == 0;
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x000489A4 File Offset: 0x00046BA4
		public int GetHashCode(global::System.Windows.Media.Imaging.BitmapImage obj)
		{
			int num = 0;
			global::System.Uri uriSource = obj.UriSource;
			if (uriSource != null)
			{
				num = uriSource.GetHashCode();
			}
			if (num == 0)
			{
				num = obj.GetHashCode();
			}
			return num;
		}
	}
}
