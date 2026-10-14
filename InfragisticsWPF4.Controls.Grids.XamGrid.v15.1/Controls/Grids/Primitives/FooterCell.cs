using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200020E RID: 526
	public class FooterCell : global::Infragistics.Controls.Grids.CellBase
	{
		// Token: 0x06000EF2 RID: 3826 RVA: 0x00038B0E File Offset: 0x00036D0E
		protected internal FooterCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00038B18 File Offset: 0x00036D18
		protected internal override void EnsureCurrentState()
		{
			if (base.Control != null)
			{
				global::Infragistics.Controls.Grids.Column column = base.Column;
				if (column != null)
				{
					if (column.IsFixed != global::Infragistics.Controls.Grids.FixedState.NotFixed)
					{
						base.Control.GoToState("Fixed", false);
					}
					else
					{
						base.Control.GoToState("Unfixed", false);
					}
				}
			}
			base.EnsureCurrentState();
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x00038B6B File Offset: 0x00036D6B
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style == null)
				{
					return base.Column.FooterStyleResolved;
				}
				return this.Style;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x00038B87 File Offset: 0x00036D87
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x00038B8C File Offset: 0x00036D8C
		protected override string RecyclingIdentifier
		{
			get
			{
				global::Infragistics.Controls.Grids.ColumnLayout columnLayout = base.Column.ColumnLayout;
				if (columnLayout.Grid != null && columnLayout.Grid.Panel != null && ((columnLayout.Grid.CellControlGenerationModeInternal == global::Infragistics.Controls.Grids.CellControlGenerationMode.Recycle && !columnLayout.Grid.IsCellControlGenerationModeJustChanged) || (columnLayout.Grid.CellControlGenerationMode == global::Infragistics.Controls.Grids.CellControlGenerationMode.Virtualize && columnLayout.Grid.IsCellControlGenerationModeJustChanged)))
				{
					return string.Concat(new string[]
					{
						base.Row.RowType.ToString(),
						"_",
						base.Column.TypeName,
						"_",
						base.Column.ColumnLayout.Key
					});
				}
				return string.Concat(new string[]
				{
					base.Row.RowType.ToString(),
					"_",
					base.Column.Key,
					"_",
					base.Column.ColumnLayout.Key
				});
			}
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x00038CA2 File Offset: 0x00036EA2
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.FooterCellControl();
		}
	}
}
