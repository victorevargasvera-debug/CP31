using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000237 RID: 567
	internal class ListKey<T>
	{
		// Token: 0x060020BF RID: 8383 RVA: 0x0008E404 File Offset: 0x0008C604
		internal ListKey(global::System.Collections.Generic.IList<T> list)
		{
			this._list = list;
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x0008E414 File Offset: 0x0008C614
		public override int GetHashCode()
		{
			int num = 0;
			if (this._list != null)
			{
				foreach (T t in this._list)
				{
					num ^= t.GetHashCode();
				}
			}
			return num;
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x0008E478 File Offset: 0x0008C678
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.DataPresenter.ListKey<T> listKey = obj as global::Infragistics.Windows.DataPresenter.ListKey<T>;
			if (listKey != null)
			{
				global::System.Collections.Generic.IList<T> list = this._list;
				global::System.Collections.Generic.IList<T> list2 = listKey._list;
				return global::Infragistics.CoreUtilities.AreEqual<T>(list, list2, null);
			}
			return false;
		}

		// Token: 0x04000DDA RID: 3546
		internal readonly global::System.Collections.Generic.IList<T> _list;
	}
}
