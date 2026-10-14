using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001E4 RID: 484
	public class AddNewRowCell : global::Infragistics.Controls.Grids.Cell
	{
		// Token: 0x06000D5E RID: 3422 RVA: 0x00031D68 File Offset: 0x0002FF68
		protected internal AddNewRowCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06000D5F RID: 3423 RVA: 0x00031D74 File Offset: 0x0002FF74
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style != null)
				{
					return this.Style;
				}
				if (base.Column != null && base.Column.AddNewRowCellStyle != null)
				{
					return base.Column.AddNewRowCellStyle;
				}
				return base.Row.ColumnLayout.AddNewRowSettings.StyleResolved;
			}
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x00031DC6 File Offset: 0x0002FFC6
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.AddNewRowCellControl();
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000D61 RID: 3425 RVA: 0x00031DCD File Offset: 0x0002FFCD
		protected internal override global::Infragistics.Controls.Grids.EditingSettingsBaseOverride EditingSettings
		{
			get
			{
				return base.Row.ColumnLayout.AddNewRowSettings;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x00031DDF File Offset: 0x0002FFDF
		protected override bool ResolveIsCellEditable
		{
			get
			{
				return base.Column.DataField.AllowEditingForAddNew;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000D63 RID: 3427 RVA: 0x00031DF1 File Offset: 0x0002FFF1
		public override bool IsEditable
		{
			get
			{
				return base.Column.AddNewRowEditorTemplate != null || base.IsEditable;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x00031E08 File Offset: 0x00030008
		protected internal override bool EnableCustomEditorBehaviors
		{
			get
			{
				return false;
			}
		}
	}
}
