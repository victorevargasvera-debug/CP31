using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000203 RID: 515
	internal class ListKey<T>
	{
		// Token: 0x06001C41 RID: 7233 RVA: 0x0007804C File Offset: 0x0007624C
		internal ListKey(global::System.Collections.Generic.IList<T> list)
		{
			this._list = list;
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x0007805C File Offset: 0x0007625C
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

		// Token: 0x06001C43 RID: 7235 RVA: 0x000780C0 File Offset: 0x000762C0
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

		// Token: 0x04000BBE RID: 3006
		internal readonly global::System.Collections.Generic.IList<T> _list;
	}
}
