using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Menus
{
	// Token: 0x0200003B RID: 59
	internal class ReferenceEqualityComparer : global::System.Collections.Generic.IEqualityComparer<object>
	{
		// Token: 0x06000347 RID: 839 RVA: 0x0000ED16 File Offset: 0x0000CF16
		bool global::System.Collections.Generic.IEqualityComparer<object>.Equals(object x, object y)
		{
			return x == y;
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000ED1C File Offset: 0x0000CF1C
		int global::System.Collections.Generic.IEqualityComparer<object>.GetHashCode(object obj)
		{
			if (obj == null)
			{
				return 0;
			}
			return obj.GetHashCode();
		}

		// Token: 0x04000114 RID: 276
		internal static readonly global::Infragistics.Controls.Menus.ReferenceEqualityComparer Instance = new global::Infragistics.Controls.Menus.ReferenceEqualityComparer();
	}
}
