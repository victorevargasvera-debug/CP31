using System;
using System.Windows.Data;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001F9 RID: 505
	public class UnboundCell : global::Infragistics.Controls.Grids.Cell
	{
		// Token: 0x06000E58 RID: 3672 RVA: 0x0003582D File Offset: 0x00033A2D
		public UnboundCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000E59 RID: 3673 RVA: 0x00035838 File Offset: 0x00033A38
		public override object Value
		{
			get
			{
				global::Infragistics.Controls.Grids.UnboundColumn unboundColumn = base.Column as global::Infragistics.Controls.Grids.UnboundColumn;
				if (unboundColumn != null && unboundColumn.ValueConverter != null)
				{
					global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
					binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
					binding.ConverterParameter = unboundColumn.ValueConverterParameter;
					binding.Converter = unboundColumn.ValueConverter;
					binding.Source = base.Row.Data;
					global::Infragistics.Controls.Grids.Cell.CellValueObject cellValueObject = new global::Infragistics.Controls.Grids.Cell.CellValueObject();
					cellValueObject.SetBinding(global::Infragistics.Controls.Grids.Cell.CellValueObject.ValueProperty, binding);
					return cellValueObject.Value;
				}
				return null;
			}
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x000358AD File Offset: 0x00033AAD
		protected internal override global::System.Windows.Data.IValueConverter CreateCellBindingConverter()
		{
			return new global::Infragistics.Controls.Grids.Primitives.UnboundCellBindingConverter();
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000E5B RID: 3675 RVA: 0x000358B4 File Offset: 0x00033AB4
		protected internal override bool ShouldClearDataContext
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x000358B8 File Offset: 0x00033AB8
		public override void Refresh()
		{
			if (base.Control != null)
			{
				object dataContext = base.Control.DataContext;
				base.Control.DataContext = null;
				if (dataContext is global::Infragistics.Controls.Grids.UnboundColumnDataContext)
				{
					((global::Infragistics.Controls.Grids.UnboundColumnDataContext)dataContext).Value = this.Value;
				}
				base.Control.DataContext = dataContext;
			}
		}
	}
}
