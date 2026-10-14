using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200012A RID: 298
	public class SelectedColumnsCollection : global::Infragistics.Controls.Grids.SelectedCollectionBase<global::Infragistics.Controls.Grids.Column>, global::Infragistics.IProvideCustomPersistence
	{
		// Token: 0x060009D6 RID: 2518 RVA: 0x000263CB File Offset: 0x000245CB
		protected override void OnSelectionChanged(global::Infragistics.Controls.Grids.SelectedCollectionBase<global::Infragistics.Controls.Grids.Column> oldCollection, global::Infragistics.Controls.Grids.SelectedCollectionBase<global::Infragistics.Controls.Grids.Column> newCollection)
		{
			if (base.Grid != null)
			{
				base.Grid.OnSelectedColumnsCollectionChanged((global::Infragistics.Controls.Grids.SelectedColumnsCollection)oldCollection, (global::Infragistics.Controls.Grids.SelectedColumnsCollection)newCollection);
			}
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x000263EC File Offset: 0x000245EC
		protected override global::Infragistics.Controls.Grids.SelectedCollectionBase<global::Infragistics.Controls.Grids.Column> CreateNewInstance()
		{
			return new global::Infragistics.Controls.Grids.SelectedColumnsCollection();
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x000263F3 File Offset: 0x000245F3
		protected override void AddItem(int index, global::Infragistics.Controls.Grids.Column item)
		{
			if (item.SupportsActivationAndSelection)
			{
				base.AddItem(index, item);
			}
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00026405 File Offset: 0x00024605
		string global::Infragistics.IProvideCustomPersistence.Save()
		{
			return this.Save();
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x0002640D File Offset: 0x0002460D
		void global::Infragistics.IProvideCustomPersistence.Load(object owner, string value)
		{
			this.Load(owner, value);
		}

		// Token: 0x060009DB RID: 2523 RVA: 0x00026418 File Offset: 0x00024618
		protected virtual string Save()
		{
			string text = "";
			foreach (global::Infragistics.Controls.Grids.Column column in this)
			{
				string text2 = text;
				text = string.Concat(new string[]
				{
					text2,
					column.Key,
					":",
					column.ColumnLayout.Key,
					","
				});
			}
			return text;
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x000264A4 File Offset: 0x000246A4
		protected virtual void Load(object owner, string value)
		{
			if (value != null)
			{
				global::Infragistics.Controls.Grids.SelectionSettings selectionSettings = owner as global::Infragistics.Controls.Grids.SelectionSettings;
				if (selectionSettings != null && selectionSettings.Grid != null)
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
								global::Infragistics.Controls.Grids.ColumnLayout columnLayout = base.Grid.ColumnLayouts[array3[1]];
								if (columnLayout != null)
								{
									global::Infragistics.Controls.Grids.Column column = columnLayout.Columns.DataColumns[array3[0]];
									if (column != null)
									{
										this.Add(column);
									}
								}
							}
						}
					}
				}
			}
		}
	}
}
