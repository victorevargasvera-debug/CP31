using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200020F RID: 527
	internal class ReferenceEqualityComparer : global::System.Collections.Generic.IEqualityComparer<object>
	{
		// Token: 0x06001FBF RID: 8127 RVA: 0x00089E72 File Offset: 0x00088072
		bool global::System.Collections.Generic.IEqualityComparer<object>.Equals(object x, object y)
		{
			return x == y;
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x00089E78 File Offset: 0x00088078
		int global::System.Collections.Generic.IEqualityComparer<object>.GetHashCode(object obj)
		{
			if (obj == null)
			{
				return 0;
			}
			return obj.GetHashCode();
		}

		// Token: 0x04000D5B RID: 3419
		internal static readonly global::Infragistics.Windows.DataPresenter.ReferenceEqualityComparer Instance = new global::Infragistics.Windows.DataPresenter.ReferenceEqualityComparer();
	}
}
