using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001FA RID: 506
	public class ConditionalFormattingUnboundCell : global::Infragistics.Controls.Grids.Primitives.UnboundCell
	{
		// Token: 0x06000E5D RID: 3677 RVA: 0x0003590A File Offset: 0x00033B0A
		public ConditionalFormattingUnboundCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00035914 File Offset: 0x00033B14
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.ConditionalStyle != null && base.Row.ColumnLayout.Grid.ConditionalFormattingSettings.AllowConditionalFormatting)
				{
					return this.ConditionalStyle;
				}
				if (this.Style != null)
				{
					return this.Style;
				}
				global::Infragistics.Controls.Grids.Row row = base.Row as global::Infragistics.Controls.Grids.Row;
				if (row != null)
				{
					if (row.ConditionalCellStyle != null && base.Row.ColumnLayout.Grid.ConditionalFormattingSettings.AllowConditionalFormatting)
					{
						return row.ConditionalCellStyle;
					}
					if (row.CellStyle != null)
					{
						return row.CellStyle;
					}
				}
				return base.Column.CellStyleResolved;
			}
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x000359AF File Offset: 0x00033BAF
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.ConditionalFormattingCellControl();
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x000359B6 File Offset: 0x00033BB6
		protected internal override global::System.Windows.Data.IValueConverter CreateCellBindingConverter()
		{
			return new global::Infragistics.Controls.Grids.Primitives.ConditionalFormattingUnboundCell.ConditionalFormattingUnboundCellBindingConverter();
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x000359BD File Offset: 0x00033BBD
		protected internal override void EnsureCurrentState()
		{
			base.EnsureCurrentState();
			if (base.Control != null)
			{
				base.Control.EnsureCurrentState();
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x000359D8 File Offset: 0x00033BD8
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x000359E0 File Offset: 0x00033BE0
		protected internal global::System.Windows.Style ConditionalStyle { get; set; }

		// Token: 0x020001FB RID: 507
		internal class ConditionalFormattingUnboundCellBindingConverter : global::System.Windows.Data.IValueConverter
		{
			// Token: 0x06000E64 RID: 3684 RVA: 0x000359EC File Offset: 0x00033BEC
			public virtual object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				global::Infragistics.Controls.Grids.ConditionalFormattingCellControl conditionalFormattingCellControl = (global::Infragistics.Controls.Grids.ConditionalFormattingCellControl)parameter;
				global::Infragistics.Controls.Grids.Primitives.ConditionalFormattingUnboundCell conditionalFormattingUnboundCell = (global::Infragistics.Controls.Grids.Primitives.ConditionalFormattingUnboundCell)conditionalFormattingCellControl.Cell;
				global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
				if (conditionalFormattingUnboundCell.Control != null)
				{
					global::Infragistics.Controls.Grids.Column column = conditionalFormattingUnboundCell.Column;
					global::Infragistics.Controls.Grids.ColumnLayout columnLayout = column.ColumnLayout;
					if (columnLayout.Grid.ConditionalFormattingSettings.AllowConditionalFormatting)
					{
						bool flag = conditionalFormattingUnboundCell.ConditionalStyle != null;
						conditionalFormattingUnboundCell.ConditionalStyle = null;
						global::Infragistics.Controls.Grids.Row row = (global::Infragistics.Controls.Grids.Row)conditionalFormattingUnboundCell.Row;
						conditionalFormattingUnboundCell.Control.EnsureCurrentState();
						global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy> cellScopedConditions = conditionalFormattingUnboundCell.Row.Manager.GetCellScopedConditions(column.Key);
						global::System.Collections.Generic.List<global::System.Windows.SetterBase> list = new global::System.Collections.Generic.List<global::System.Windows.SetterBase>();
						foreach (global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy conditionalFormattingRuleProxy in cellScopedConditions)
						{
							global::System.Windows.Style style = conditionalFormattingRuleProxy.EvaluateCondition(row.Data, value);
							if (style != null)
							{
								if (conditionalFormattingRuleProxy.Parent.StyleScope == global::Infragistics.Controls.Grids.StyleScope.Cell)
								{
									list.AddRange(style.Setters);
								}
								visibility = conditionalFormattingRuleProxy.Parent.CellValueVisibility;
								if (conditionalFormattingRuleProxy.Parent.IsTerminalRule)
								{
									break;
								}
							}
						}
						if (list.Count > 0)
						{
							global::System.Windows.Style style2 = new global::System.Windows.Style(typeof(global::Infragistics.Controls.Grids.ConditionalFormattingCellControl));
							style2.BasedOn = conditionalFormattingUnboundCell.ResolveStyle;
							for (int i = list.Count - 1; i >= 0; i--)
							{
								global::System.Windows.Setter setter = new global::System.Windows.Setter();
								global::System.Windows.Setter setter2 = (global::System.Windows.Setter)list[i];
								setter.Property = setter2.Property;
								setter.Value = setter2.Value;
								style2.Setters.Add(setter);
							}
							conditionalFormattingUnboundCell.ConditionalStyle = style2;
							flag = true;
						}
						flag = (flag && !row.SkipApplyStyle);
						if (flag)
						{
							conditionalFormattingUnboundCell.ApplyStyle();
						}
					}
				}
				conditionalFormattingUnboundCell.RaiseCellControlAttachedEvent();
				if (visibility == global::System.Windows.Visibility.Collapsed)
				{
					return "";
				}
				global::Infragistics.Controls.Grids.Column resolveColumn = conditionalFormattingUnboundCell.ResolveColumn;
				if (resolveColumn.ValueConverter != null)
				{
					value = resolveColumn.ValueConverter.Convert(value, targetType, resolveColumn.ValueConverterParameter, culture);
				}
				else if (conditionalFormattingUnboundCell.Control != null && conditionalFormattingUnboundCell.Control.ContentProvider != null)
				{
					value = conditionalFormattingUnboundCell.Control.ContentProvider.ApplyFormatting(value, resolveColumn, culture);
				}
				if (value == null && !string.IsNullOrEmpty(resolveColumn.DataField.NullDisplayText))
				{
					value = resolveColumn.DataField.NullDisplayText;
				}
				return value;
			}

			// Token: 0x06000E65 RID: 3685 RVA: 0x00035C4C File Offset: 0x00033E4C
			public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				global::Infragistics.Controls.Grids.Cell cell = (global::Infragistics.Controls.Grids.Cell)parameter;
				global::Infragistics.Controls.Grids.Column resolveColumn = cell.ResolveColumn;
				if (resolveColumn.ValueConverter != null)
				{
					return resolveColumn.ValueConverter.ConvertBack(value, targetType, resolveColumn.ValueConverterParameter, culture);
				}
				return value;
			}
		}
	}
}
