using System;
using System.Globalization;
using System.Windows.Data;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000231 RID: 561
	internal class UnboundCellBindingConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000FAF RID: 4015 RVA: 0x0003B408 File Offset: 0x00039608
		public virtual object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::Infragistics.Controls.Grids.Primitives.CellControlBase cellControlBase = (global::Infragistics.Controls.Grids.Primitives.CellControlBase)parameter;
			global::Infragistics.Controls.Grids.Cell cell = (global::Infragistics.Controls.Grids.Cell)cellControlBase.Cell;
			if (cell != null)
			{
				bool flag = cell.Control == null;
				if (flag)
				{
					cell.Control = cellControlBase;
				}
				cell.RaiseCellControlAttachedEvent();
				global::Infragistics.Controls.Grids.Column resolveColumn = cell.ResolveColumn;
				if (resolveColumn.ValueConverter != null)
				{
					value = resolveColumn.ValueConverter.Convert(value, targetType, resolveColumn.ValueConverterParameter, culture);
				}
				else if (cellControlBase.ContentProvider != null)
				{
					value = cellControlBase.ContentProvider.ApplyFormatting(value, resolveColumn, culture);
				}
				if (flag)
				{
					cell.Control = null;
				}
			}
			return value;
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x0003B494 File Offset: 0x00039694
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			global::Infragistics.Controls.Grids.Primitives.CellControlBase cellControlBase = (global::Infragistics.Controls.Grids.Primitives.CellControlBase)parameter;
			global::Infragistics.Controls.Grids.Cell cell = (global::Infragistics.Controls.Grids.Cell)cellControlBase.Cell;
			if (cell != null)
			{
				global::Infragistics.Controls.Grids.Column resolveColumn = cell.ResolveColumn;
				if (resolveColumn.ValueConverter != null)
				{
					return resolveColumn.ValueConverter.ConvertBack(value, targetType, resolveColumn.ValueConverterParameter, culture);
				}
			}
			return value;
		}
	}
}
