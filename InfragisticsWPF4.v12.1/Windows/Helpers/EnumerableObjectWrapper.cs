using System;
using System.Collections;
using System.ComponentModel;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x0200016E RID: 366
	public class EnumerableObjectWrapper : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x06000C47 RID: 3143 RVA: 0x00027D96 File Offset: 0x00025F96
		public EnumerableObjectWrapper(global::System.Collections.IEnumerable items) : this(items, null)
		{
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x00027DA0 File Offset: 0x00025FA0
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

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x00027E14 File Offset: 0x00026014
		public global::System.Collections.IEnumerable Items
		{
			get
			{
				return this._items;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x00027E1C File Offset: 0x0002601C
		// (set) Token: 0x06000C4B RID: 3147 RVA: 0x00027E24 File Offset: 0x00026024
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

		// Token: 0x06000C4C RID: 3148 RVA: 0x00027E48 File Offset: 0x00026048
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.Helpers.EnumerableObjectWrapper enumerableObjectWrapper = obj as global::Infragistics.Windows.Helpers.EnumerableObjectWrapper;
			return enumerableObjectWrapper != null && enumerableObjectWrapper._items == this._items;
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x00027E6F File Offset: 0x0002606F
		public override int GetHashCode()
		{
			return this._items.GetHashCode();
		}

		// Token: 0x040005A4 RID: 1444
		private string _name;

		// Token: 0x040005A5 RID: 1445
		private global::System.Collections.IEnumerable _items;
	}
}
