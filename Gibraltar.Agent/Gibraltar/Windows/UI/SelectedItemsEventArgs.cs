using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Gibraltar.Windows.UI
{
	// Token: 0x020000CA RID: 202
	internal class SelectedItemsEventArgs<T> : global::System.EventArgs
	{
		// Token: 0x0600087A RID: 2170 RVA: 0x0001274C File Offset: 0x0001094C
		public SelectedItemsEventArgs(global::System.Collections.Generic.IList<T> selectedItems)
		{
			this.m_SelectedItems = new global::System.Collections.ObjectModel.ReadOnlyCollection<T>(selectedItems);
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x00012760 File Offset: 0x00010960
		public global::System.Collections.Generic.IList<T> SelectedItems
		{
			get
			{
				return this.m_SelectedItems;
			}
		}

		// Token: 0x040001D6 RID: 470
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<T> m_SelectedItems;
	}
}
