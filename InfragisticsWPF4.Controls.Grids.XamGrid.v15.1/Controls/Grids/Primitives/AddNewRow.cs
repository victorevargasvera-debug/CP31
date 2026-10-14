using System;
using System.Data;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200026D RID: 621
	public class AddNewRow : global::Infragistics.Controls.Grids.Row
	{
		// Token: 0x06001465 RID: 5221 RVA: 0x0004BE74 File Offset: 0x0004A074
		protected internal AddNewRow(global::Infragistics.Controls.Grids.RowsManager manager) : base(-1, manager, null)
		{
			base.FixedPositionSortOrder = 2;
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x0004BE86 File Offset: 0x0004A086
		public override global::Infragistics.Controls.Grids.RowType RowType
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowType.AddNewRow;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x0004BE8C File Offset: 0x0004A08C
		public override global::Infragistics.Controls.Grids.RowHeight HeightResolved
		{
			get
			{
				if (base.Height != null)
				{
					return base.Height.Value;
				}
				return this.ColumnLayout.AddNewRowSettings.AddNewRowHeightResolved;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x0004BEC8 File Offset: 0x0004A0C8
		public override bool HasChildren
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x0004BECB File Offset: 0x0004A0CB
		protected internal override global::Infragistics.Controls.Grids.EditingType AllowEditing
		{
			get
			{
				return global::Infragistics.Controls.Grids.EditingType.Row;
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x0004BECE File Offset: 0x0004A0CE
		protected internal override bool AllowSelection
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x0004BED1 File Offset: 0x0004A0D1
		protected internal override bool IsStandAloneRow
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x0004BED4 File Offset: 0x0004A0D4
		protected internal override bool IsStandAloneRowResolved
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x0004BED7 File Offset: 0x0004A0D7
		protected internal override bool RequiresFixedRowSeparator
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x0004BEDA File Offset: 0x0004A0DA
		protected internal void SetData(object data)
		{
			base.Data = data;
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x0004BEE4 File Offset: 0x0004A0E4
		protected internal bool IsRowDirty
		{
			get
			{
				if (base.Data != null)
				{
					if (this.ColumnLayout.Grid.ItemsSource is global::System.Data.DataView)
					{
						this.ColumnLayout.DefaultDataObject = null;
					}
					object obj = this.ColumnLayout.DefaultDataObject;
					if (obj == null)
					{
						obj = ((global::Infragistics.Controls.Grids.RowsManager)base.Manager).GenerateNewObject(global::Infragistics.Controls.Grids.RowType.DataRow);
						this.ColumnLayout.DefaultDataObject = obj;
					}
					if (obj != null && base.Data != null)
					{
						foreach (global::Infragistics.Controls.Grids.CellBase cellBase in this.VisibleCells)
						{
							global::Infragistics.Controls.Grids.Cell cell = cellBase as global::Infragistics.Controls.Grids.Cell;
							if (cell != null && cell.IsEditable)
							{
								object obj2 = global::Infragistics.DataManagerBase.ResolveValueFromPropertyPath(cell.Column.Key, base.Data);
								object obj3 = global::Infragistics.DataManagerBase.ResolveValueFromPropertyPath(cell.Column.Key, obj);
								if (obj2 != obj3 && (!(cell.Column.DataType == typeof(string)) || !string.IsNullOrEmpty((string)obj2) || !string.IsNullOrEmpty(obj3 as string)))
								{
									if (obj2 == null && obj3 != null)
									{
										return true;
									}
									if (obj2 != null && obj3 == null)
									{
										return true;
									}
									if (!obj2.Equals(obj3))
									{
										return true;
									}
								}
							}
						}
						return false;
					}
				}
				return false;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x0004C050 File Offset: 0x0004A250
		protected internal override bool AllowKeyboardNavigation
		{
			get
			{
				return true;
			}
		}
	}
}
