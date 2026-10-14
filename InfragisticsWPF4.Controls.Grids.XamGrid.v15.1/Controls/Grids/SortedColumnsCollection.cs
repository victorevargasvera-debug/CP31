using System;
using System.Collections.Specialized;
using Infragistics.Collections;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200012D RID: 301
	public class SortedColumnsCollection : global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.Grids.Column>, global::Infragistics.IProvideCustomPersistence
	{
		// Token: 0x170002F3 RID: 755
		public global::Infragistics.Controls.Grids.Column this[string columnKey]
		{
			get
			{
				if (!string.IsNullOrEmpty(columnKey) || base.Count == 0)
				{
					foreach (global::Infragistics.Controls.Grids.Column column in this)
					{
						if (column.Key == columnKey)
						{
							return column;
						}
					}
				}
				return null;
			}
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00026A2C File Offset: 0x00024C2C
		protected internal virtual void AddItemSilently(global::Infragistics.Controls.Grids.Column item)
		{
			if (!this.Items.Contains(item))
			{
				this.AddItemSilently(base.Count, item);
			}
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00026A49 File Offset: 0x00024C49
		protected internal virtual void InsertItemSilently(global::Infragistics.Controls.Grids.Column item, int index)
		{
			if (!this.Items.Contains(item))
			{
				this.AddItemSilently(index, item);
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00026A64 File Offset: 0x00024C64
		protected internal virtual void RemoveItemSilently(global::Infragistics.Controls.Grids.Column item)
		{
			int num = this.Items.IndexOf(item);
			if (num != -1)
			{
				this.RemoveItemSilently(num);
			}
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00026A8C File Offset: 0x00024C8C
		protected internal virtual void ClearSilently()
		{
			int count = this.Items.Count;
			for (int i = count - 1; i >= 0; i--)
			{
				global::Infragistics.Controls.Grids.Column column = this.Items[i];
				column.SetSortedColumnStateSilent(global::Infragistics.Controls.Grids.SortDirection.None);
				this.RemoveItemSilently(column);
			}
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x00026AD0 File Offset: 0x00024CD0
		protected virtual string Save()
		{
			string text = "";
			foreach (global::Infragistics.Controls.Grids.Column column in this)
			{
				object obj = text;
				text = string.Concat(new object[]
				{
					obj,
					column.Key,
					":",
					column.IsSorted,
					","
				});
			}
			return text;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00026B5C File Offset: 0x00024D5C
		protected virtual void Load(object owner, string value)
		{
			if (value != null)
			{
				global::Infragistics.Controls.Grids.SortingSettingsOverride sortingSettingsOverride = owner as global::Infragistics.Controls.Grids.SortingSettingsOverride;
				if (sortingSettingsOverride != null && sortingSettingsOverride.ColumnLayout != null)
				{
					this.Clear();
					string[] array = value.Split(new char[]
					{
						','
					});
					foreach (string text in array)
					{
						if (text.Length > 0)
						{
							string[] array3 = text.Split(new char[]
							{
								':'
							});
							if (array3.Length == 2)
							{
								global::Infragistics.Controls.Grids.Column column = sortingSettingsOverride.ColumnLayout.Columns.DataColumns[array3[0]];
								if (column != null)
								{
									column.IsSorted = (global::Infragistics.Controls.Grids.SortDirection)global::System.Enum.Parse(typeof(global::Infragistics.Controls.Grids.SortDirection), array3[1], true);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00026C24 File Offset: 0x00024E24
		protected override bool RemoveItem(int index)
		{
			global::Infragistics.Controls.Grids.Column column = this.Items[index];
			bool result = column.SetSortedColumnState(global::Infragistics.Controls.Grids.SortDirection.None);
			this.OnNotifyCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, column, index));
			return result;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00026C58 File Offset: 0x00024E58
		protected override void ResetItems()
		{
			int count = this.Items.Count;
			for (int i = count - 1; i >= 0; i--)
			{
				this.RemoveItem(i);
			}
			if (count > 0)
			{
				this.OnNotifyCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
			}
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00026C97 File Offset: 0x00024E97
		protected override void AddItem(int index, global::Infragistics.Controls.Grids.Column item)
		{
			if (item != null && item.CanBeSorted)
			{
				item.SetSortedColumnState(item.NextSortDirection);
				this.OnNotifyCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, item, index));
			}
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00026CBF File Offset: 0x00024EBF
		protected override void InsertItem(int index, global::Infragistics.Controls.Grids.Column item)
		{
			if (item != null)
			{
				item.SetSortedColumnStateInternally(item.NextSortDirection, true, index);
				this.OnNotifyCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, item, index));
			}
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x00026CE1 File Offset: 0x00024EE1
		string global::Infragistics.IProvideCustomPersistence.Save()
		{
			return this.Save();
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00026CE9 File Offset: 0x00024EE9
		void global::Infragistics.IProvideCustomPersistence.Load(object owner, string value)
		{
			this.Load(owner, value);
		}
	}
}
