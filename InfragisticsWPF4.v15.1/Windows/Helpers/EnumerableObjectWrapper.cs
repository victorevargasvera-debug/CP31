using System;
using System.Collections;
using System.ComponentModel;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x02000190 RID: 400
	public class EnumerableObjectWrapper : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x06000D5C RID: 3420 RVA: 0x0002BF1E File Offset: 0x0002A11E
		public EnumerableObjectWrapper(global::System.Collections.IEnumerable items) : this(items, null)
		{
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x0002BF28 File Offset: 0x0002A128
		public EnumerableObjectWrapper(global::System.Collections.IEnumerable items, string name)
		{
			if (items == null)
			{
				throw new global::System.ArgumentNullException("items");
			}
			if (items is string)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ArgumentException_22"));
			}
			this._items = items;
			if (name != null)
			{
				this._name = name;
				return;
			}
			global::System.ComponentModel.ITypedList typedList = this._items as global::System.ComponentModel.ITypedList;
			if (typedList != null)
			{
				this._name = typedList.GetListName(null);
				return;
			}
			this._name = items.ToString();
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x0002BF9C File Offset: 0x0002A19C
		public global::System.Collections.IEnumerable Items
		{
			get
			{
				return this._items;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x0002BFA4 File Offset: 0x0002A1A4
		// (set) Token: 0x06000D60 RID: 3424 RVA: 0x0002BFAC File Offset: 0x0002A1AC
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (value != this._name)
				{
					this._name = value;
					base.RaisePropertyChangedEvent("Name");
				}
			}
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x0002BFD0 File Offset: 0x0002A1D0
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.Helpers.EnumerableObjectWrapper enumerableObjectWrapper = obj as global::Infragistics.Windows.Helpers.EnumerableObjectWrapper;
			return enumerableObjectWrapper != null && enumerableObjectWrapper._items == this._items;
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0002BFF7 File Offset: 0x0002A1F7
		public override int GetHashCode()
		{
			return this._items.GetHashCode();
		}

		// Token: 0x04000669 RID: 1641
		private string _name;

		// Token: 0x0400066A RID: 1642
		private global::System.Collections.IEnumerable _items;
	}
}
