using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infragistics.Collections;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000252 RID: 594
	public class GroupColumnsCollection : global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.Grids.Column>, global::Infragistics.IProvidePersistenceLookupKeys, global::Infragistics.IProvidePropertyPersistenceSettings
	{
		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x0004770F File Offset: 0x0004590F
		// (set) Token: 0x060012E5 RID: 4837 RVA: 0x00047718 File Offset: 0x00045918
		public virtual global::Infragistics.Controls.Grids.ColumnLayout ColumnLayout
		{
			get
			{
				return this._colLayout;
			}
			protected internal set
			{
				if (this._colLayout != value)
				{
					global::Infragistics.Controls.Grids.ColumnLayout colLayout = this._colLayout;
					this._colLayout = value;
					if (this._colLayout != null)
					{
						foreach (global::Infragistics.Controls.Grids.Column columnBase in this.Items)
						{
							this._colLayout.OnColumnAdded(columnBase);
						}
					}
				}
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x060012E6 RID: 4838 RVA: 0x0004778C File Offset: 0x0004598C
		protected virtual global::System.Collections.Generic.List<string> PropertiesToIgnore
		{
			get
			{
				if (this._propertiesThatShouldntBePersisted == null)
				{
					this._propertiesThatShouldntBePersisted = new global::System.Collections.Generic.List<string>
					{
						"AllColumns",
						"AllVisibleColumns"
					};
				}
				return this._propertiesThatShouldntBePersisted;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x000477CA File Offset: 0x000459CA
		protected virtual global::System.Collections.Generic.List<string> PriorityProperties
		{
			get
			{
				return null;
			}
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x000477CD File Offset: 0x000459CD
		protected override void AddItem(int index, global::Infragistics.Controls.Grids.Column item)
		{
			if (!item.IsMoving && this.ColumnLayout != null)
			{
				this.ColumnLayout.OnColumnAdded(item);
			}
			base.AddItem(index, item);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x000477F3 File Offset: 0x000459F3
		public override void Insert(int index, global::Infragistics.Controls.Grids.Column item)
		{
			this.AddItem(index, item);
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x00047800 File Offset: 0x00045A00
		protected override bool RemoveItem(int index)
		{
			global::Infragistics.Controls.Grids.Column column = this.Items[index];
			if (!column.IsMoving)
			{
				this.ColumnLayout.OnColumnRemoved(column);
			}
			if (this.ColumnLayout.Grid != null)
			{
				this.ColumnLayout.Grid.InvalidateScrollPanel(true);
			}
			return base.RemoveItem(index);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00047854 File Offset: 0x00045A54
		protected override void ResetItems()
		{
			base.ResetItems();
			global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allColumns = this.AllColumns;
			foreach (global::Infragistics.Controls.Grids.ColumnBase columnBase in allColumns)
			{
				this.ColumnLayout.OnColumnRemoved(columnBase);
			}
			if (this.ColumnLayout != null && this.ColumnLayout.Grid != null)
			{
				this.ColumnLayout.Grid.InvalidateScrollPanel(true);
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x000478D4 File Offset: 0x00045AD4
		public global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> AllColumns
		{
			get
			{
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();
				foreach (global::Infragistics.Controls.Grids.Column column in this.Items)
				{
					list.Add(column);
					global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allColumns = column.AllColumns;
					foreach (global::Infragistics.Controls.Grids.Column item in allColumns)
					{
						list.Add(item);
					}
				}
				return new global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column>(list);
			}
		}

		// Token: 0x170005B5 RID: 1461
		public global::Infragistics.Controls.Grids.Column this[string key]
		{
			get
			{
				foreach (global::Infragistics.Controls.Grids.Column column in this.Items)
				{
					if (column.Key == key)
					{
						return column;
					}
				}
				return null;
			}
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x000479D4 File Offset: 0x00045BD4
		protected virtual global::System.Collections.ObjectModel.Collection<string> GetLookupKeys()
		{
			global::System.Collections.ObjectModel.Collection<string> collection = new global::System.Collections.ObjectModel.Collection<string>();
			foreach (global::Infragistics.Controls.Grids.ColumnBase columnBase in this.Items)
			{
				collection.Add(columnBase.Key);
			}
			return collection;
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x00047A30 File Offset: 0x00045C30
		protected virtual bool CanRehydrate(global::System.Collections.ObjectModel.Collection<string> lookupKeys)
		{
			if (lookupKeys == null || lookupKeys.Count != this.Items.Count)
			{
				return false;
			}
			bool flag = false;
			global::System.Collections.Generic.Dictionary<string, global::Infragistics.Controls.Grids.Column> dictionary = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Controls.Grids.Column>();
			for (int i = 0; i < lookupKeys.Count; i++)
			{
				string key = lookupKeys[i];
				global::Infragistics.Controls.Grids.Column column = this[key];
				dictionary.Add(key, column);
				if (this[key] == null)
				{
					return false;
				}
				if (this.IndexOf(column) != i)
				{
					flag = true;
				}
			}
			if (flag)
			{
				foreach (string text in lookupKeys)
				{
					global::Infragistics.Controls.Grids.ColumnBase columnBase = base[0];
					global::Infragistics.Controls.Grids.Column column2 = columnBase as global::Infragistics.Controls.Grids.Column;
					if (column2 != null)
					{
						column2.IsMoving = true;
					}
					this.RemoveItemSilently(0);
					if (column2 != null)
					{
						column2.IsMoving = false;
					}
				}
				for (int j = 0; j < lookupKeys.Count; j++)
				{
					global::Infragistics.Controls.Grids.Column item = dictionary[lookupKeys[j]];
					this.AddItemSilently(j, item);
				}
			}
			return true;
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00047B44 File Offset: 0x00045D44
		protected virtual void FinishedLoadingPersistence()
		{
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x00047B46 File Offset: 0x00045D46
		global::System.Collections.ObjectModel.Collection<string> global::Infragistics.IProvidePersistenceLookupKeys.GetLookupKeys()
		{
			return this.GetLookupKeys();
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00047B4E File Offset: 0x00045D4E
		bool global::Infragistics.IProvidePersistenceLookupKeys.CanRehydrate(global::System.Collections.ObjectModel.Collection<string> lookupKeys)
		{
			return this.CanRehydrate(lookupKeys);
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x00047B57 File Offset: 0x00045D57
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PropertiesToIgnore
		{
			get
			{
				return this.PropertiesToIgnore;
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x00047B5F File Offset: 0x00045D5F
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PriorityProperties
		{
			get
			{
				return this.PriorityProperties;
			}
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x00047B67 File Offset: 0x00045D67
		void global::Infragistics.IProvidePropertyPersistenceSettings.FinishedLoadingPersistence()
		{
			this.FinishedLoadingPersistence();
		}

		// Token: 0x040005DD RID: 1501
		private global::Infragistics.Controls.Grids.ColumnLayout _colLayout;

		// Token: 0x040005DE RID: 1502
		private global::System.Collections.Generic.List<string> _propertiesThatShouldntBePersisted;
	}
}
