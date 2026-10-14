using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000210 RID: 528
	internal class EqualityComparerWrapper : global::System.Collections.Generic.IEqualityComparer<object>
	{
		// Token: 0x06001FC3 RID: 8131 RVA: 0x00089E99 File Offset: 0x00088099
		internal EqualityComparerWrapper(global::System.Collections.IEqualityComparer comparer)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(comparer, "comparer");
			this._comparer = comparer;
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x00089EB3 File Offset: 0x000880B3
		bool global::System.Collections.Generic.IEqualityComparer<object>.Equals(object x, object y)
		{
			return this._comparer.Equals(x, y);
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x00089EC2 File Offset: 0x000880C2
		int global::System.Collections.Generic.IEqualityComparer<object>.GetHashCode(object obj)
		{
			return this._comparer.GetHashCode(obj);
		}

		// Token: 0x04000D5C RID: 3420
		private global::System.Collections.IEqualityComparer _comparer;
	}
}
