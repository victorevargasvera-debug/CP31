using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000257 RID: 599
	internal class UriComparer : global::System.Collections.Generic.IComparer<global::System.Uri>
	{
		// Token: 0x06001338 RID: 4920 RVA: 0x0004856D File Offset: 0x0004676D
		public int Compare(global::System.Uri x, global::System.Uri y)
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
			return string.Compare(x.OriginalString, y.OriginalString, global::System.StringComparison.CurrentCulture);
		}
	}
}
