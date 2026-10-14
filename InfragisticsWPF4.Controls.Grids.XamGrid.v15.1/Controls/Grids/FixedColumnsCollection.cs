using System;
using Infragistics.Collections;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000F6 RID: 246
	public class FixedColumnsCollection : global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.Grids.Column>, global::Infragistics.IProvideCustomPersistence
	{
		// Token: 0x06000802 RID: 2050 RVA: 0x00020914 File Offset: 0x0001EB14
		public FixedColumnsCollection(global::Infragistics.Controls.Grids.FixedState direction)
		{
			this.Direction = direction;
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00020923 File Offset: 0x0001EB23
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x0002092B File Offset: 0x0001EB2B
		protected global::Infragistics.Controls.Grids.FixedState Direction { get; set; }

		// Token: 0x06000805 RID: 2053 RVA: 0x00020934 File Offset: 0x0001EB34
		protected override void AddItem(int index, global::Infragistics.Controls.Grids.Column item)
		{
			if (item != null)
			{
				if (item.IsFixed == this.Direction)
				{
					int num = this.Items.IndexOf(item);
					if (num != -1)
					{
						if (index < this.Items.Count)
						{
							this.Items.Remove(item);
							this.Items.Insert(index, item);
							if (item.ColumnLayout != null && item.ColumnLayout.Grid != null)
							{
								item.ColumnLayout.Grid.InvalidateScrollPanel(false);
								return;
							}
						}
					}
					else
					{
						if (item.ParentColumn != null)
						{
							item.IsFixed = global::Infragistics.Controls.Grids.FixedState.NotFixed;
							return;
						}
						base.AddItem(index, item);
						return;
					}
				}
				else
				{
					item.SetFixedColumnState(this.Direction);
				}
			}
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000209DB File Offset: 0x0001EBDB
		protected override void InsertItem(int index, global::Infragistics.Controls.Grids.Column item)
		{
			this.AddItem(index, item);
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x000209E8 File Offset: 0x0001EBE8
		protected override bool RemoveItem(int index)
		{
			bool result = false;
			if (index >= 0 && index < this.Items.Count)
			{
				global::Infragistics.Controls.Grids.Column column = this.Items[index];
				result = (column != null && column.SetFixedColumnState(global::Infragistics.Controls.Grids.FixedState.NotFixed));
			}
			return result;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00020A28 File Offset: 0x0001EC28
		protected override void ResetItems()
		{
			int count = this.Items.Count;
			for (int i = count - 1; i >= 0; i--)
			{
				this.RemoveItem(i);
			}
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00020A57 File Offset: 0x0001EC57
		protected internal virtual void AddItemSilently(global::Infragistics.Controls.Grids.Column item)
		{
			if (!this.Items.Contains(item))
			{
				this.AddItemSilently(base.Count, item);
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00020A74 File Offset: 0x0001EC74
		protected internal virtual void RemoveItemSilently(global::Infragistics.Controls.Grids.Column item)
		{
			int num = this.Items.IndexOf(item);
			if (num != -1)
			{
				this.RemoveItemSilently(num);
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00020A9C File Offset: 0x0001EC9C
		protected virtual string Save()
		{
			string text = "";
			foreach (global::Infragistics.Controls.Grids.Column column in this)
			{
				text = text + column.Key + ",";
			}
			return text;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00020AF8 File Offset: 0x0001ECF8
		protected virtual void Load(object owner, string value)
		{
			if (value != null)
			{
				global::Infragistics.Controls.Grids.FixedColumnSettingsOverride fixedColumnSettingsOverride = owner as global::Infragistics.Controls.Grids.FixedColumnSettingsOverride;
				if (fixedColumnSettingsOverride != null && fixedColumnSettingsOverride.ColumnLayout != null)
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
							global::Infragistics.Controls.Grids.Column column = fixedColumnSettingsOverride.ColumnLayout.Columns.DataColumns[text];
							if (column != null)
							{
								column.IsFixed = this.Direction;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00020B82 File Offset: 0x0001ED82
		string global::Infragistics.IProvideCustomPersistence.Save()
		{
			return this.Save();
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00020B8A File Offset: 0x0001ED8A
		void global::Infragistics.IProvideCustomPersistence.Load(object owner, string value)
		{
			this.Load(owner, value);
		}
	}
}
