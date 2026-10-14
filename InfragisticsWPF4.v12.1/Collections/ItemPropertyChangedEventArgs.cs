using System;
using System.ComponentModel;

namespace Infragistics.Collections
{
	// Token: 0x02000060 RID: 96
	public class ItemPropertyChangedEventArgs : global::System.ComponentModel.PropertyChangedEventArgs
	{
		// Token: 0x060003D9 RID: 985 RVA: 0x00010C1E File Offset: 0x0000EE1E
		public ItemPropertyChangedEventArgs(object item, string propertyName) : base(propertyName)
		{
			this._item = item;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00010C2E File Offset: 0x0000EE2E
		public object Item
		{
			get
			{
				return this._item;
			}
		}

		// Token: 0x0400014E RID: 334
		private object _item;
	}
}
