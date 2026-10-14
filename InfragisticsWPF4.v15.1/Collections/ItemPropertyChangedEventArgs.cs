using System;
using System.ComponentModel;

namespace Infragistics.Collections
{
	// Token: 0x02000077 RID: 119
	public class ItemPropertyChangedEventArgs : global::System.ComponentModel.PropertyChangedEventArgs
	{
		// Token: 0x0600048E RID: 1166 RVA: 0x000132A0 File Offset: 0x000114A0
		public ItemPropertyChangedEventArgs(object item, string propertyName) : base(propertyName)
		{
			this._item = item;
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x000132B0 File Offset: 0x000114B0
		public object Item
		{
			get
			{
				return this._item;
			}
		}

		// Token: 0x040001BC RID: 444
		private object _item;
	}
}
