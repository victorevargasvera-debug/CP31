using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Infragistics.Collections;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000106 RID: 262
	public class GroupByColumnsCollection : global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.Grids.Column>, global::System.Collections.Generic.IComparer<global::Infragistics.Controls.Grids.Column>, global::Infragistics.IProvideCustomPersistence
	{
		// Token: 0x06000887 RID: 2183 RVA: 0x00021D38 File Offset: 0x0001FF38
		private void RegisterColumn(global::Infragistics.Controls.Grids.Column column)
		{
			if (!this._groupByDictionary.ContainsKey(column.ColumnLayout))
			{
				this._groupByDictionary.Add(column.ColumnLayout, new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>());
			}
			global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list = this._groupByDictionary[column.ColumnLayout];
			if (!list.Contains(column))
			{
				list.Add(column);
			}
			list.Sort(this);
			this.DirtyFlag++;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00021DA8 File Offset: 0x0001FFA8
		private void UnregisterColumn(global::Infragistics.Controls.Grids.Column column)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = column.ColumnLayout;
			this._groupByDictionary[columnLayout].Remove(column);
			if (!this._groupByDictionary[columnLayout].Any<global::Infragistics.Controls.Grids.Column>())
			{
				this._groupByDictionary.Remove(columnLayout);
			}
			this.DirtyFlag++;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00021E00 File Offset: 0x00020000
		protected virtual void OnGroupingChanged(global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.Column> oldCollection, global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.Column> newCollection)
		{
			global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.ColumnLayout> collection = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.ColumnLayout>();
			foreach (global::Infragistics.Controls.Grids.Column column in oldCollection)
			{
				if (!collection.Contains(column.ColumnLayout))
				{
					collection.Add(column.ColumnLayout);
				}
			}
			foreach (global::Infragistics.Controls.Grids.Column column2 in newCollection)
			{
				if (!collection.Contains(column2.ColumnLayout))
				{
					collection.Add(column2.ColumnLayout);
				}
			}
			foreach (global::Infragistics.Controls.Grids.ColumnLayout columnLayout in collection)
			{
				columnLayout.InvalidateGroupBy();
			}
			this.Grid.OnGroupByCollectionChanged(oldCollection, newCollection);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00021F00 File Offset: 0x00020100
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
					column.ColumnLayout.Key,
					":",
					column.IsSorted,
					","
				});
			}
			return text;
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00021FA4 File Offset: 0x000201A4
		protected virtual void Load(object owner, string value)
		{
			if (value != null)
			{
				global::Infragistics.Controls.Grids.GroupBySettings groupBySettings = owner as global::Infragistics.Controls.Grids.GroupBySettings;
				if (groupBySettings != null && groupBySettings.Grid != null)
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
							if (array3.Length == 3)
							{
								global::Infragistics.Controls.Grids.ColumnLayout columnLayout = this.Grid.ColumnLayouts[array3[1]];
								if (columnLayout != null)
								{
									global::Infragistics.Controls.Grids.Column column = columnLayout.Columns.AllColumns[array3[0]] as global::Infragistics.Controls.Grids.Column;
									if (column != null)
									{
										column.IsGroupBy = true;
										column.SetSortedColumnStateInternally((global::Infragistics.Controls.Grids.SortDirection)global::System.Enum.Parse(typeof(global::Infragistics.Controls.Grids.SortDirection), array3[2], true), true);
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x00022095 File Offset: 0x00020295
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x0002209D File Offset: 0x0002029D
		public global::Infragistics.Controls.Grids.XamGrid Grid { get; protected internal set; }

		// Token: 0x1700029E RID: 670
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> this[global::Infragistics.Controls.Grids.ColumnLayout layout]
		{
			get
			{
				if (!this._groupByDictionary.ContainsKey(layout))
				{
					this._groupByDictionary.Add(layout, new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>());
				}
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column>(this._groupByDictionary[layout]);
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x000220D8 File Offset: 0x000202D8
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x000220E0 File Offset: 0x000202E0
		internal int DirtyFlag { get; private set; }

		// Token: 0x06000891 RID: 2193 RVA: 0x000220EC File Offset: 0x000202EC
		protected override void AddItem(int index, global::Infragistics.Controls.Grids.Column item)
		{
			if (item.CanBeGroupedBy && !this.Items.Contains(item))
			{
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();
				list.AddRange(this);
				if (this.Grid != null)
				{
					item.SetGroupBy(true);
				}
				base.AddItem(index, item);
				this.RegisterColumn(item);
				if (this.Grid != null)
				{
					this.OnGroupingChanged(list, this);
					this.Grid.InvalidateScrollPanel(false);
				}
			}
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00022156 File Offset: 0x00020356
		protected override void InsertItem(int index, global::Infragistics.Controls.Grids.Column item)
		{
			this.AddItem(index, item);
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00022160 File Offset: 0x00020360
		protected override bool RemoveItem(int index)
		{
			global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();
			list.AddRange(this);
			global::Infragistics.Controls.Grids.Column column = this.Items[index];
			bool result = base.RemoveItem(index);
			this.UnregisterColumn(column);
			if (this.Grid != null)
			{
				column.SetGroupBy(false);
			}
			if (this.Grid != null)
			{
				this.OnGroupingChanged(list, this);
				this.Grid.InvalidateScrollPanel(false);
				if (this.Grid.ConditionalFormattingSettings.AllowConditionalFormatting)
				{
					this.Grid.ResetPanelRows();
				}
			}
			return result;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x000221E0 File Offset: 0x000203E0
		protected override void ReplaceItem(int index, global::Infragistics.Controls.Grids.Column newItem)
		{
			global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();
			list.AddRange(this);
			global::Infragistics.Controls.Grids.Column column = this.Items[index];
			if (this.Grid != null)
			{
				column.SetGroupBy(false);
				newItem.SetGroupBy(true);
			}
			base.ReplaceItem(index, newItem);
			this.UnregisterColumn(column);
			this.RegisterColumn(newItem);
			if (this.Grid != null)
			{
				this.OnGroupingChanged(list, this);
				this.Grid.InvalidateScrollPanel(false);
			}
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00022250 File Offset: 0x00020450
		protected override void ResetItems()
		{
			global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();
			list.AddRange(this);
			if (this.Grid != null)
			{
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list2 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>(this.Items);
				foreach (global::Infragistics.Controls.Grids.Column column in list2)
				{
					column.SetGroupBy(false);
					this.UnregisterColumn(column);
				}
			}
			base.ResetItems();
			global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.ColumnLayout> list3 = this._groupByDictionary.Keys.ToList<global::Infragistics.Controls.Grids.ColumnLayout>();
			foreach (global::Infragistics.Controls.Grids.ColumnLayout key in list3)
			{
				if (!this._groupByDictionary[key].Any<global::Infragistics.Controls.Grids.Column>())
				{
					this._groupByDictionary.Remove(key);
				}
			}
			if (this.Grid != null)
			{
				this.OnGroupingChanged(list, this);
				this.Grid.InvalidateScrollPanel(false);
				if (this.Grid.ConditionalFormattingSettings.AllowConditionalFormatting)
				{
					this.Grid.ResetPanelRows();
				}
			}
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00022374 File Offset: 0x00020574
		protected virtual int Compare(global::Infragistics.Controls.Grids.Column x, global::Infragistics.Controls.Grids.Column y)
		{
			return this.IndexOf(x).CompareTo(this.IndexOf(y));
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00022397 File Offset: 0x00020597
		int global::System.Collections.Generic.IComparer<global::Infragistics.Controls.Grids.Column>.Compare(global::Infragistics.Controls.Grids.Column x, global::Infragistics.Controls.Grids.Column y)
		{
			return this.Compare(x, y);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x000223A1 File Offset: 0x000205A1
		string global::Infragistics.IProvideCustomPersistence.Save()
		{
			return this.Save();
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x000223A9 File Offset: 0x000205A9
		void global::Infragistics.IProvideCustomPersistence.Load(object owner, string value)
		{
			this.Load(owner, value);
		}

		// Token: 0x0400021B RID: 539
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Grids.ColumnLayout, global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>> _groupByDictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Grids.ColumnLayout, global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>>();
	}
}
