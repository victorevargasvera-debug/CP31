using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using MS.Internal;

namespace Microsoft.Windows.Controls
{
	// Token: 0x02000008 RID: 8
	public abstract class DataGridColumn : global::System.Windows.DependencyObject
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000028B7 File Offset: 0x00000AB7
		// (set) Token: 0x0600005A RID: 90 RVA: 0x000028C4 File Offset: 0x00000AC4
		public object Header
		{
			get
			{
				return base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.HeaderProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.HeaderProperty, value);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000028D2 File Offset: 0x00000AD2
		// (set) Token: 0x0600005C RID: 92 RVA: 0x000028E4 File Offset: 0x00000AE4
		public global::System.Windows.Style HeaderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.HeaderStyleProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.HeaderStyleProperty, value);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000028F4 File Offset: 0x00000AF4
		private static object OnCoerceHeaderStyle(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = d as global::Microsoft.Windows.Controls.DataGridColumn;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridColumn, baseValue, global::Microsoft.Windows.Controls.DataGridColumn.HeaderStyleProperty, dataGridColumn.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.ColumnHeaderStyleProperty);
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0000291F File Offset: 0x00000B1F
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002931 File Offset: 0x00000B31
		public string HeaderStringFormat
		{
			get
			{
				return (string)base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.HeaderStringFormatProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.HeaderStringFormatProperty, value);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000293F File Offset: 0x00000B3F
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00002951 File Offset: 0x00000B51
		public global::System.Windows.DataTemplate HeaderTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.HeaderTemplateProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.HeaderTemplateProperty, value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000295F File Offset: 0x00000B5F
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00002971 File Offset: 0x00000B71
		public global::System.Windows.Controls.DataTemplateSelector HeaderTemplateSelector
		{
			get
			{
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.HeaderTemplateSelectorProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.HeaderTemplateSelectorProperty, value);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000064 RID: 100 RVA: 0x0000297F File Offset: 0x00000B7F
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00002991 File Offset: 0x00000B91
		public global::System.Windows.Style CellStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.CellStyleProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.CellStyleProperty, value);
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000029A0 File Offset: 0x00000BA0
		private static object OnCoerceCellStyle(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = d as global::Microsoft.Windows.Controls.DataGridColumn;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridColumn, baseValue, global::Microsoft.Windows.Controls.DataGridColumn.CellStyleProperty, dataGridColumn.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.CellStyleProperty);
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000029CB File Offset: 0x00000BCB
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000029DD File Offset: 0x00000BDD
		public bool IsReadOnly
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.IsReadOnlyProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.IsReadOnlyProperty, value);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000029F0 File Offset: 0x00000BF0
		private static object OnCoerceIsReadOnly(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = d as global::Microsoft.Windows.Controls.DataGridColumn;
			return dataGridColumn.OnCoerceIsReadOnly((bool)baseValue);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002A15 File Offset: 0x00000C15
		protected virtual bool OnCoerceIsReadOnly(bool baseValue)
		{
			return (bool)global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(this, baseValue, global::Microsoft.Windows.Controls.DataGridColumn.IsReadOnlyProperty, this.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.IsReadOnlyProperty);
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00002A38 File Offset: 0x00000C38
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002A4A File Offset: 0x00000C4A
		public global::Microsoft.Windows.Controls.DataGridLength Width
		{
			get
			{
				return (global::Microsoft.Windows.Controls.DataGridLength)base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.WidthProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.WidthProperty, value);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002A60 File Offset: 0x00000C60
		internal void SetWidthInternal(global::Microsoft.Windows.Controls.DataGridLength width)
		{
			bool ignoreRedistributionOnWidthChange = this._ignoreRedistributionOnWidthChange;
			this._ignoreRedistributionOnWidthChange = true;
			try
			{
				this.Width = width;
			}
			finally
			{
				this._ignoreRedistributionOnWidthChange = ignoreRedistributionOnWidthChange;
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002A9C File Offset: 0x00000C9C
		private static void OnWidthPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = (global::Microsoft.Windows.Controls.DataGridColumn)d;
			global::Microsoft.Windows.Controls.DataGridLength dataGridLength = (global::Microsoft.Windows.Controls.DataGridLength)e.OldValue;
			global::Microsoft.Windows.Controls.DataGridLength dataGridLength2 = (global::Microsoft.Windows.Controls.DataGridLength)e.NewValue;
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = dataGridColumn.DataGridOwner;
			if (dataGridOwner != null && !global::MS.Internal.DoubleUtil.AreClose(dataGridLength.DisplayValue, dataGridLength2.DisplayValue))
			{
				dataGridOwner.InternalColumns.InvalidateAverageColumnWidth();
			}
			if (dataGridColumn._processingWidthChange)
			{
				dataGridColumn.CoerceValue(global::Microsoft.Windows.Controls.DataGridColumn.ActualWidthProperty);
				return;
			}
			dataGridColumn._processingWidthChange = true;
			if (dataGridLength.IsStar != dataGridLength2.IsStar)
			{
				dataGridColumn.CoerceValue(global::Microsoft.Windows.Controls.DataGridColumn.MaxWidthProperty);
			}
			try
			{
				if (dataGridOwner != null && (dataGridLength2.IsStar ^ dataGridLength.IsStar))
				{
					dataGridOwner.InternalColumns.InvalidateHasVisibleStarColumns();
				}
				dataGridColumn.NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.Cells | global::Microsoft.Windows.Controls.NotificationTarget.CellsPresenter | global::Microsoft.Windows.Controls.NotificationTarget.Columns | global::Microsoft.Windows.Controls.NotificationTarget.ColumnCollection | global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeaders | global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeadersPresenter);
				if (dataGridOwner != null && !dataGridColumn._ignoreRedistributionOnWidthChange && dataGridColumn.IsVisible)
				{
					if (!dataGridLength2.IsStar && !dataGridLength2.IsAbsolute)
					{
						global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
						double displayValue = global::Microsoft.Windows.Controls.DataGridHelper.CoerceToMinMax(width.DesiredValue, dataGridColumn.MinWidth, dataGridColumn.MaxWidth);
						dataGridColumn.SetWidthInternal(new global::Microsoft.Windows.Controls.DataGridLength(width.Value, width.UnitType, width.DesiredValue, displayValue));
					}
					dataGridOwner.InternalColumns.RedistributeColumnWidthsOnWidthChangeOfColumn(dataGridColumn, (global::Microsoft.Windows.Controls.DataGridLength)e.OldValue);
				}
			}
			finally
			{
				dataGridColumn._processingWidthChange = false;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002BF0 File Offset: 0x00000DF0
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00002C02 File Offset: 0x00000E02
		public double MinWidth
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.MinWidthProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.MinWidthProperty, value);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002C18 File Offset: 0x00000E18
		private static void OnMinWidthPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = (global::Microsoft.Windows.Controls.DataGridColumn)d;
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = dataGridColumn.DataGridOwner;
			dataGridColumn.NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.Columns);
			if (dataGridOwner != null && dataGridColumn.IsVisible)
			{
				dataGridOwner.InternalColumns.RedistributeColumnWidthsOnMinWidthChangeOfColumn(dataGridColumn, (double)e.OldValue);
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002C5F File Offset: 0x00000E5F
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002C71 File Offset: 0x00000E71
		public double MaxWidth
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.MaxWidthProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.MaxWidthProperty, value);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002C84 File Offset: 0x00000E84
		private static void OnMaxWidthPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = (global::Microsoft.Windows.Controls.DataGridColumn)d;
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = dataGridColumn.DataGridOwner;
			dataGridColumn.NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.Columns);
			if (dataGridOwner != null && dataGridColumn.IsVisible)
			{
				dataGridOwner.InternalColumns.RedistributeColumnWidthsOnMaxWidthChangeOfColumn(dataGridColumn, (double)e.OldValue);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002CCB File Offset: 0x00000ECB
		private static double CoerceDesiredOrDisplayWidthValue(double widthValue, double memberValue, global::Microsoft.Windows.Controls.DataGridLengthUnitType type)
		{
			if (global::MS.Internal.DoubleUtil.IsNaN(memberValue))
			{
				if (type == global::Microsoft.Windows.Controls.DataGridLengthUnitType.Pixel)
				{
					memberValue = widthValue;
				}
				else if (type == global::Microsoft.Windows.Controls.DataGridLengthUnitType.Auto || type == global::Microsoft.Windows.Controls.DataGridLengthUnitType.SizeToCells || type == global::Microsoft.Windows.Controls.DataGridLengthUnitType.SizeToHeader)
				{
					memberValue = 0.0;
				}
			}
			return memberValue;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002CF8 File Offset: 0x00000EF8
		private static object OnCoerceWidth(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = d as global::Microsoft.Windows.Controls.DataGridColumn;
			global::Microsoft.Windows.Controls.DataGridLength dataGridLength = (global::Microsoft.Windows.Controls.DataGridLength)global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridColumn, baseValue, global::Microsoft.Windows.Controls.DataGridColumn.WidthProperty, dataGridColumn.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.ColumnWidthProperty);
			double desiredValue = global::Microsoft.Windows.Controls.DataGridColumn.CoerceDesiredOrDisplayWidthValue(dataGridLength.Value, dataGridLength.DesiredValue, dataGridLength.UnitType);
			double num = global::Microsoft.Windows.Controls.DataGridColumn.CoerceDesiredOrDisplayWidthValue(dataGridLength.Value, dataGridLength.DisplayValue, dataGridLength.UnitType);
			num = (global::MS.Internal.DoubleUtil.IsNaN(num) ? num : global::Microsoft.Windows.Controls.DataGridHelper.CoerceToMinMax(num, dataGridColumn.MinWidth, dataGridColumn.MaxWidth));
			if (global::MS.Internal.DoubleUtil.IsNaN(num) || global::MS.Internal.DoubleUtil.AreClose(num, dataGridLength.DisplayValue))
			{
				return dataGridLength;
			}
			return new global::Microsoft.Windows.Controls.DataGridLength(dataGridLength.Value, dataGridLength.UnitType, desiredValue, num);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002DB8 File Offset: 0x00000FB8
		private static object OnCoerceMinWidth(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = d as global::Microsoft.Windows.Controls.DataGridColumn;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridColumn, baseValue, global::Microsoft.Windows.Controls.DataGridColumn.MinWidthProperty, dataGridColumn.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.MinColumnWidthProperty);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002DE4 File Offset: 0x00000FE4
		private static object OnCoerceMaxWidth(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = d as global::Microsoft.Windows.Controls.DataGridColumn;
			double num = (double)global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridColumn, baseValue, global::Microsoft.Windows.Controls.DataGridColumn.MaxWidthProperty, dataGridColumn.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.MaxColumnWidthProperty);
			if (double.IsPositiveInfinity(num) && dataGridColumn.Width.IsStar)
			{
				return 10000.0;
			}
			return num;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002E44 File Offset: 0x00001044
		private static bool ValidateMinWidth(object v)
		{
			double num = (double)v;
			return num >= 0.0 && !global::MS.Internal.DoubleUtil.IsNaN(num) && !double.IsPositiveInfinity(num);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002E78 File Offset: 0x00001078
		private static bool ValidateMaxWidth(object v)
		{
			double num = (double)v;
			return num >= 0.0 && !global::MS.Internal.DoubleUtil.IsNaN(num);
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002EA3 File Offset: 0x000010A3
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002EB5 File Offset: 0x000010B5
		public double ActualWidth
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.ActualWidthProperty);
			}
			private set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.ActualWidthPropertyKey, value);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002EC8 File Offset: 0x000010C8
		private static object OnCoerceActualWidth(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = (global::Microsoft.Windows.Controls.DataGridColumn)d;
			double num = (double)baseValue;
			double minWidth = dataGridColumn.MinWidth;
			double maxWidth = dataGridColumn.MaxWidth;
			global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
			if (width.IsAbsolute)
			{
				num = width.DisplayValue;
			}
			if (num < minWidth)
			{
				num = minWidth;
			}
			else if (num > maxWidth)
			{
				num = maxWidth;
			}
			return num;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002F20 File Offset: 0x00001120
		internal double GetConstraintWidth(bool isHeader)
		{
			global::Microsoft.Windows.Controls.DataGridLength width = this.Width;
			if (!global::MS.Internal.DoubleUtil.IsNaN(width.DisplayValue))
			{
				return width.DisplayValue;
			}
			if (width.IsAbsolute || width.IsStar || (width.IsSizeToCells && isHeader) || (width.IsSizeToHeader && !isHeader))
			{
				return this.ActualWidth;
			}
			return double.PositiveInfinity;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002F84 File Offset: 0x00001184
		internal void UpdateDesiredWidthForAutoColumn(bool isHeader, double pixelWidth)
		{
			global::Microsoft.Windows.Controls.DataGridLength width = this.Width;
			double minWidth = this.MinWidth;
			double maxWidth = this.MaxWidth;
			double num = global::Microsoft.Windows.Controls.DataGridHelper.CoerceToMinMax(pixelWidth, minWidth, maxWidth);
			if (width.IsAuto || (width.IsSizeToCells && !isHeader) || (width.IsSizeToHeader && isHeader))
			{
				if (global::MS.Internal.DoubleUtil.IsNaN(width.DesiredValue) || global::MS.Internal.DoubleUtil.LessThan(width.DesiredValue, pixelWidth))
				{
					if (global::MS.Internal.DoubleUtil.IsNaN(width.DisplayValue))
					{
						this.SetWidthInternal(new global::Microsoft.Windows.Controls.DataGridLength(width.Value, width.UnitType, pixelWidth, num));
					}
					else
					{
						double value = global::Microsoft.Windows.Controls.DataGridHelper.CoerceToMinMax(width.DesiredValue, minWidth, maxWidth);
						this.SetWidthInternal(new global::Microsoft.Windows.Controls.DataGridLength(width.Value, width.UnitType, pixelWidth, width.DisplayValue));
						if (global::MS.Internal.DoubleUtil.AreClose(value, width.DisplayValue))
						{
							this.DataGridOwner.InternalColumns.RecomputeColumnWidthsOnColumnResize(this, pixelWidth - width.DisplayValue, true);
						}
					}
					width = this.Width;
				}
				if (global::MS.Internal.DoubleUtil.IsNaN(width.DisplayValue))
				{
					if (this.ActualWidth < num)
					{
						this.ActualWidth = num;
						return;
					}
				}
				else if (!global::MS.Internal.DoubleUtil.AreClose(this.ActualWidth, width.DisplayValue))
				{
					this.ActualWidth = width.DisplayValue;
				}
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000030C4 File Offset: 0x000012C4
		internal void UpdateWidthForStarColumn(double displayWidth, double desiredWidth, double starValue)
		{
			global::Microsoft.Windows.Controls.DataGridLength width = this.Width;
			if (!global::MS.Internal.DoubleUtil.AreClose(displayWidth, width.DisplayValue) || !global::MS.Internal.DoubleUtil.AreClose(desiredWidth, width.DesiredValue) || !global::MS.Internal.DoubleUtil.AreClose(width.Value, starValue))
			{
				this.SetWidthInternal(new global::Microsoft.Windows.Controls.DataGridLength(starValue, width.UnitType, desiredWidth, displayWidth));
				this.ActualWidth = displayWidth;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003124 File Offset: 0x00001324
		public global::System.Windows.FrameworkElement GetCellContent(object dataItem)
		{
			if (dataItem == null)
			{
				throw new global::System.ArgumentNullException("dataItem");
			}
			if (this._dataGridOwner != null)
			{
				global::Microsoft.Windows.Controls.DataGridRow dataGridRow = this._dataGridOwner.ItemContainerGenerator.ContainerFromItem(dataItem) as global::Microsoft.Windows.Controls.DataGridRow;
				if (dataGridRow != null)
				{
					return this.GetCellContent(dataGridRow);
				}
			}
			return null;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000316C File Offset: 0x0000136C
		public global::System.Windows.FrameworkElement GetCellContent(global::Microsoft.Windows.Controls.DataGridRow dataGridRow)
		{
			if (dataGridRow == null)
			{
				throw new global::System.ArgumentNullException("dataGridRow");
			}
			if (this._dataGridOwner != null)
			{
				int num = this._dataGridOwner.Columns.IndexOf(this);
				if (num >= 0)
				{
					global::Microsoft.Windows.Controls.DataGridCell dataGridCell = dataGridRow.TryGetCell(num);
					if (dataGridCell != null)
					{
						return dataGridCell.Content as global::System.Windows.FrameworkElement;
					}
				}
			}
			return null;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000031BD File Offset: 0x000013BD
		internal global::System.Windows.FrameworkElement BuildVisualTree(bool isEditing, object dataItem, global::Microsoft.Windows.Controls.DataGridCell cell)
		{
			if (isEditing)
			{
				return this.GenerateEditingElement(cell, dataItem);
			}
			return this.GenerateElement(cell, dataItem);
		}

		// Token: 0x06000084 RID: 132
		protected abstract global::System.Windows.FrameworkElement GenerateElement(global::Microsoft.Windows.Controls.DataGridCell cell, object dataItem);

		// Token: 0x06000085 RID: 133
		protected abstract global::System.Windows.FrameworkElement GenerateEditingElement(global::Microsoft.Windows.Controls.DataGridCell cell, object dataItem);

		// Token: 0x06000086 RID: 134 RVA: 0x000031D3 File Offset: 0x000013D3
		protected virtual object PrepareCellForEdit(global::System.Windows.FrameworkElement editingElement, global::System.Windows.RoutedEventArgs editingEventArgs)
		{
			return null;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000031D6 File Offset: 0x000013D6
		protected virtual void CancelCellEdit(global::System.Windows.FrameworkElement editingElement, object uneditedValue)
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000031D8 File Offset: 0x000013D8
		protected virtual bool CommitCellEdit(global::System.Windows.FrameworkElement editingElement)
		{
			return true;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000031DC File Offset: 0x000013DC
		internal void BeginEdit(global::System.Windows.FrameworkElement editingElement, global::System.Windows.RoutedEventArgs e)
		{
			if (editingElement != null)
			{
				editingElement.UpdateLayout();
				object value = this.PrepareCellForEdit(editingElement, e);
				global::Microsoft.Windows.Controls.DataGridColumn.SetOriginalValue(editingElement, value);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003202 File Offset: 0x00001402
		internal void CancelEdit(global::System.Windows.FrameworkElement editingElement)
		{
			if (editingElement != null)
			{
				this.CancelCellEdit(editingElement, global::Microsoft.Windows.Controls.DataGridColumn.GetOriginalValue(editingElement));
				global::Microsoft.Windows.Controls.DataGridColumn.ClearOriginalValue(editingElement);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000321A File Offset: 0x0000141A
		internal bool CommitEdit(global::System.Windows.FrameworkElement editingElement)
		{
			if (editingElement == null)
			{
				return true;
			}
			if (this.CommitCellEdit(editingElement))
			{
				global::Microsoft.Windows.Controls.DataGridColumn.ClearOriginalValue(editingElement);
				return true;
			}
			return false;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003233 File Offset: 0x00001433
		private static object GetOriginalValue(global::System.Windows.DependencyObject obj)
		{
			return obj.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.OriginalValueProperty);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003240 File Offset: 0x00001440
		private static void SetOriginalValue(global::System.Windows.DependencyObject obj, object value)
		{
			obj.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.OriginalValueProperty, value);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000324E File Offset: 0x0000144E
		private static void ClearOriginalValue(global::System.Windows.DependencyObject obj)
		{
			obj.ClearValue(global::Microsoft.Windows.Controls.DataGridColumn.OriginalValueProperty);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000325B File Offset: 0x0000145B
		internal static void OnNotifyCellPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGridColumn)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.Cells | global::Microsoft.Windows.Controls.NotificationTarget.Columns);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000326B File Offset: 0x0000146B
		private static void OnNotifyColumnHeaderPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGridColumn)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.Columns | global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeaders);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000327C File Offset: 0x0000147C
		private static void OnNotifyColumnPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGridColumn)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.Columns);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000328C File Offset: 0x0000148C
		internal void NotifyPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e, global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			if (global::Microsoft.Windows.Controls.DataGridHelper.ShouldNotifyColumns(target))
			{
				target &= ~global::Microsoft.Windows.Controls.NotificationTarget.Columns;
				if (e.Property == global::Microsoft.Windows.Controls.DataGrid.MaxColumnWidthProperty || e.Property == global::Microsoft.Windows.Controls.DataGridColumn.MaxWidthProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridColumn.MaxWidthProperty);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.MinColumnWidthProperty || e.Property == global::Microsoft.Windows.Controls.DataGridColumn.MinWidthProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridColumn.MinWidthProperty);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.ColumnWidthProperty || e.Property == global::Microsoft.Windows.Controls.DataGridColumn.WidthProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridColumn.WidthProperty);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.ColumnHeaderStyleProperty || e.Property == global::Microsoft.Windows.Controls.DataGridColumn.HeaderStyleProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridColumn.HeaderStyleProperty);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.CellStyleProperty || e.Property == global::Microsoft.Windows.Controls.DataGridColumn.CellStyleProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridColumn.CellStyleProperty);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.IsReadOnlyProperty || e.Property == global::Microsoft.Windows.Controls.DataGridColumn.IsReadOnlyProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridColumn.IsReadOnlyProperty);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.DragIndicatorStyleProperty || e.Property == global::Microsoft.Windows.Controls.DataGridColumn.DragIndicatorStyleProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridColumn.DragIndicatorStyleProperty);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGridColumn.DisplayIndexProperty)
				{
					base.CoerceValue(global::Microsoft.Windows.Controls.DataGridColumn.IsFrozenProperty);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.CanUserSortColumnsProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridColumn.CanUserSortProperty);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.CanUserResizeColumnsProperty || e.Property == global::Microsoft.Windows.Controls.DataGridColumn.CanUserResizeProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridColumn.CanUserResizeProperty);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.CanUserReorderColumnsProperty || e.Property == global::Microsoft.Windows.Controls.DataGridColumn.CanUserReorderProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridColumn.CanUserReorderProperty);
				}
				if (e.Property == global::Microsoft.Windows.Controls.DataGridColumn.WidthProperty || e.Property == global::Microsoft.Windows.Controls.DataGridColumn.MinWidthProperty || e.Property == global::Microsoft.Windows.Controls.DataGridColumn.MaxWidthProperty)
				{
					base.CoerceValue(global::Microsoft.Windows.Controls.DataGridColumn.ActualWidthProperty);
				}
			}
			if (target != global::Microsoft.Windows.Controls.NotificationTarget.None)
			{
				global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = (global::Microsoft.Windows.Controls.DataGridColumn)d;
				global::Microsoft.Windows.Controls.DataGrid dataGridOwner = dataGridColumn.DataGridOwner;
				if (dataGridOwner != null)
				{
					dataGridOwner.NotifyPropertyChanged(d, e, target);
				}
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000034B8 File Offset: 0x000016B8
		protected void NotifyPropertyChanged(string propertyName)
		{
			if (this.DataGridOwner != null)
			{
				this.DataGridOwner.NotifyPropertyChanged(this, propertyName, default(global::System.Windows.DependencyPropertyChangedEventArgs), global::Microsoft.Windows.Controls.NotificationTarget.RefreshCellContent);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000034E8 File Offset: 0x000016E8
		internal static void NotifyPropertyChangeForRefreshContent(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGridColumn)d).NotifyPropertyChanged(e.Property.Name);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003501 File Offset: 0x00001701
		protected internal virtual void RefreshCellContent(global::System.Windows.FrameworkElement element, string propertyName)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003504 File Offset: 0x00001704
		internal void SyncProperties()
		{
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridColumn.MinWidthProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridColumn.MaxWidthProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridColumn.WidthProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridColumn.HeaderStyleProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridColumn.CellStyleProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridColumn.IsReadOnlyProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridColumn.DragIndicatorStyleProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridColumn.CanUserSortProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridColumn.CanUserReorderProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridColumn.CanUserResizeProperty);
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000357F File Offset: 0x0000177F
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00003587 File Offset: 0x00001787
		protected internal global::Microsoft.Windows.Controls.DataGrid DataGridOwner
		{
			get
			{
				return this._dataGridOwner;
			}
			internal set
			{
				this._dataGridOwner = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00003590 File Offset: 0x00001790
		// (set) Token: 0x0600009A RID: 154 RVA: 0x000035A2 File Offset: 0x000017A2
		public int DisplayIndex
		{
			get
			{
				return (int)base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.DisplayIndexProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.DisplayIndexProperty, value);
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000035B8 File Offset: 0x000017B8
		private static object OnCoerceDisplayIndex(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = (global::Microsoft.Windows.Controls.DataGridColumn)d;
			if (dataGridColumn.DataGridOwner != null)
			{
				dataGridColumn.DataGridOwner.ValidateDisplayIndex(dataGridColumn, (int)baseValue);
			}
			return baseValue;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000035E7 File Offset: 0x000017E7
		private static void DisplayIndexChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGridColumn)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.Cells | global::Microsoft.Windows.Controls.NotificationTarget.CellsPresenter | global::Microsoft.Windows.Controls.NotificationTarget.Columns | global::Microsoft.Windows.Controls.NotificationTarget.ColumnCollection | global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeaders | global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeadersPresenter);
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600009D RID: 157 RVA: 0x000035F8 File Offset: 0x000017F8
		// (set) Token: 0x0600009E RID: 158 RVA: 0x0000360A File Offset: 0x0000180A
		public string SortMemberPath
		{
			get
			{
				return (string)base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.SortMemberPathProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.SortMemberPathProperty, value);
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00003618 File Offset: 0x00001818
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0000362A File Offset: 0x0000182A
		public bool CanUserSort
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.CanUserSortProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.CanUserSortProperty, value);
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00003640 File Offset: 0x00001840
		internal static object OnCoerceCanUserSort(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = d as global::Microsoft.Windows.Controls.DataGridColumn;
			global::System.Windows.ValueSource valueSource = global::System.Windows.DependencyPropertyHelper.GetValueSource(dataGridColumn, global::Microsoft.Windows.Controls.DataGridColumn.CanUserSortProperty);
			bool flag = valueSource.IsAnimated || valueSource.IsCoerced || valueSource.IsExpression;
			if (dataGridColumn.DataGridOwner != null)
			{
				global::System.Windows.ValueSource valueSource2 = global::System.Windows.DependencyPropertyHelper.GetValueSource(dataGridColumn.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.CanUserSortColumnsProperty);
				bool flag2 = valueSource2.IsAnimated || valueSource2.IsCoerced || valueSource2.IsExpression;
				if (valueSource2.BaseValueSource == valueSource.BaseValueSource && !flag && flag2)
				{
					return dataGridColumn.DataGridOwner.GetValue(global::Microsoft.Windows.Controls.DataGrid.CanUserSortColumnsProperty);
				}
			}
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridColumn, baseValue, global::Microsoft.Windows.Controls.DataGridColumn.CanUserSortProperty, dataGridColumn.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.CanUserSortColumnsProperty);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000036F3 File Offset: 0x000018F3
		private static void OnCanUserSortPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (!global::Microsoft.Windows.Controls.DataGridHelper.IsPropertyTransferEnabled(d, global::Microsoft.Windows.Controls.DataGridColumn.CanUserSortProperty))
			{
				global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(d, global::Microsoft.Windows.Controls.DataGridColumn.CanUserSortProperty);
			}
			((global::Microsoft.Windows.Controls.DataGridColumn)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeaders);
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000371C File Offset: 0x0000191C
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000372E File Offset: 0x0000192E
		public global::System.ComponentModel.ListSortDirection? SortDirection
		{
			get
			{
				return (global::System.ComponentModel.ListSortDirection?)base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.SortDirectionProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.SortDirectionProperty, value);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00003741 File Offset: 0x00001941
		private static void OnNotifySortPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGridColumn)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeaders);
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00003752 File Offset: 0x00001952
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00003764 File Offset: 0x00001964
		public bool IsAutoGenerated
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.IsAutoGeneratedProperty);
			}
			internal set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.IsAutoGeneratedPropertyKey, value);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00003778 File Offset: 0x00001978
		internal static global::Microsoft.Windows.Controls.DataGridColumn CreateDefaultColumn(global::System.ComponentModel.ItemPropertyInfo itemProperty)
		{
			global::Microsoft.Windows.Controls.DataGridComboBoxColumn dataGridComboBoxColumn = null;
			global::System.Type propertyType = itemProperty.PropertyType;
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn;
			if (propertyType.IsEnum)
			{
				dataGridComboBoxColumn = new global::Microsoft.Windows.Controls.DataGridComboBoxColumn();
				dataGridComboBoxColumn.ItemsSource = global::System.Enum.GetValues(propertyType);
				dataGridColumn = dataGridComboBoxColumn;
			}
			else if (typeof(string).IsAssignableFrom(propertyType))
			{
				dataGridColumn = new global::Microsoft.Windows.Controls.DataGridTextColumn();
			}
			else if (typeof(bool).IsAssignableFrom(propertyType))
			{
				dataGridColumn = new global::Microsoft.Windows.Controls.DataGridCheckBoxColumn();
			}
			else if (typeof(global::System.Uri).IsAssignableFrom(propertyType))
			{
				dataGridColumn = new global::Microsoft.Windows.Controls.DataGridHyperlinkColumn();
			}
			else
			{
				dataGridColumn = new global::Microsoft.Windows.Controls.DataGridTextColumn();
			}
			if (!typeof(global::System.IComparable).IsAssignableFrom(propertyType))
			{
				dataGridColumn.CanUserSort = false;
			}
			dataGridColumn.Header = itemProperty.Name;
			global::Microsoft.Windows.Controls.DataGridBoundColumn dataGridBoundColumn = dataGridColumn as global::Microsoft.Windows.Controls.DataGridBoundColumn;
			if (dataGridBoundColumn != null || dataGridComboBoxColumn != null)
			{
				global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding(itemProperty.Name);
				if (dataGridComboBoxColumn != null)
				{
					dataGridComboBoxColumn.SelectedItemBinding = binding;
				}
				else
				{
					dataGridBoundColumn.Binding = binding;
				}
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor = itemProperty.Descriptor as global::System.ComponentModel.PropertyDescriptor;
				if (propertyDescriptor != null)
				{
					if (propertyDescriptor.IsReadOnly)
					{
						binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
						dataGridColumn.IsReadOnly = true;
					}
				}
				else
				{
					global::System.Reflection.PropertyInfo propertyInfo = itemProperty.Descriptor as global::System.Reflection.PropertyInfo;
					if (propertyInfo != null && !propertyInfo.CanWrite)
					{
						binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
						dataGridColumn.IsReadOnly = true;
					}
				}
			}
			return dataGridColumn;
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000038AB File Offset: 0x00001AAB
		// (set) Token: 0x060000AA RID: 170 RVA: 0x000038BD File Offset: 0x00001ABD
		public bool IsFrozen
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.IsFrozenProperty);
			}
			internal set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.IsFrozenPropertyKey, value);
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000038D0 File Offset: 0x00001AD0
		private static void OnNotifyFrozenPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGridColumn)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeaders);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000038E4 File Offset: 0x00001AE4
		private static object OnCoerceIsFrozen(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = (global::Microsoft.Windows.Controls.DataGridColumn)d;
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = dataGridColumn.DataGridOwner;
			if (dataGridOwner == null)
			{
				return baseValue;
			}
			if (dataGridColumn.DisplayIndex < dataGridOwner.FrozenColumnCount)
			{
				return true;
			}
			return false;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000391F File Offset: 0x00001B1F
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00003931 File Offset: 0x00001B31
		public bool CanUserReorder
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.CanUserReorderProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.CanUserReorderProperty, value);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00003944 File Offset: 0x00001B44
		private static object OnCoerceCanUserReorder(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = d as global::Microsoft.Windows.Controls.DataGridColumn;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridColumn, baseValue, global::Microsoft.Windows.Controls.DataGridColumn.CanUserReorderProperty, dataGridColumn.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.CanUserReorderColumnsProperty);
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0000396F File Offset: 0x00001B6F
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00003981 File Offset: 0x00001B81
		public global::System.Windows.Style DragIndicatorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.DragIndicatorStyleProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.DragIndicatorStyleProperty, value);
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00003990 File Offset: 0x00001B90
		private static object OnCoerceDragIndicatorStyle(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = d as global::Microsoft.Windows.Controls.DataGridColumn;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridColumn, baseValue, global::Microsoft.Windows.Controls.DataGridColumn.DragIndicatorStyleProperty, dataGridColumn.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.DragIndicatorStyleProperty);
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x000039BB File Offset: 0x00001BBB
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x000039C3 File Offset: 0x00001BC3
		public virtual global::System.Windows.Data.BindingBase ClipboardContentBinding
		{
			get
			{
				return this._clipboardContentBinding;
			}
			set
			{
				this._clipboardContentBinding = value;
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000039CC File Offset: 0x00001BCC
		public virtual object OnCopyingCellClipboardContent(object item)
		{
			object obj = null;
			global::System.Windows.Data.BindingBase clipboardContentBinding = this.ClipboardContentBinding;
			if (clipboardContentBinding != null)
			{
				global::System.Windows.FrameworkElement frameworkElement = new global::System.Windows.FrameworkElement();
				frameworkElement.DataContext = item;
				frameworkElement.SetBinding(global::Microsoft.Windows.Controls.DataGridColumn.CellValueProperty, clipboardContentBinding);
				obj = frameworkElement.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.CellValueProperty);
			}
			if (this.CopyingCellClipboardContent != null)
			{
				global::Microsoft.Windows.Controls.DataGridCellClipboardEventArgs dataGridCellClipboardEventArgs = new global::Microsoft.Windows.Controls.DataGridCellClipboardEventArgs(item, this, obj);
				this.CopyingCellClipboardContent(this, dataGridCellClipboardEventArgs);
				obj = dataGridCellClipboardEventArgs.Content;
			}
			return obj;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00003A34 File Offset: 0x00001C34
		public virtual void OnPastingCellClipboardContent(object item, object cellContent)
		{
			global::System.Windows.Data.BindingBase clipboardContentBinding = this.ClipboardContentBinding;
			if (clipboardContentBinding != null)
			{
				if (this.PastingCellClipboardContent != null)
				{
					global::Microsoft.Windows.Controls.DataGridCellClipboardEventArgs dataGridCellClipboardEventArgs = new global::Microsoft.Windows.Controls.DataGridCellClipboardEventArgs(item, this, cellContent);
					this.PastingCellClipboardContent(this, dataGridCellClipboardEventArgs);
					cellContent = dataGridCellClipboardEventArgs.Content;
				}
				if (cellContent != null)
				{
					global::System.Windows.FrameworkElement frameworkElement = new global::System.Windows.FrameworkElement();
					frameworkElement.DataContext = item;
					frameworkElement.SetBinding(global::Microsoft.Windows.Controls.DataGridColumn.CellValueProperty, clipboardContentBinding);
					frameworkElement.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.CellValueProperty, cellContent);
					global::System.Windows.Data.BindingExpression bindingExpression = frameworkElement.GetBindingExpression(global::Microsoft.Windows.Controls.DataGridColumn.CellValueProperty);
					bindingExpression.UpdateSource();
				}
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000B7 RID: 183 RVA: 0x00003AAC File Offset: 0x00001CAC
		// (remove) Token: 0x060000B8 RID: 184 RVA: 0x00003AC5 File Offset: 0x00001CC5
		public event global::System.EventHandler<global::Microsoft.Windows.Controls.DataGridCellClipboardEventArgs> CopyingCellClipboardContent;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000B9 RID: 185 RVA: 0x00003ADE File Offset: 0x00001CDE
		// (remove) Token: 0x060000BA RID: 186 RVA: 0x00003AF7 File Offset: 0x00001CF7
		public event global::System.EventHandler<global::Microsoft.Windows.Controls.DataGridCellClipboardEventArgs> PastingCellClipboardContent;

		// Token: 0x060000BB RID: 187 RVA: 0x00003B10 File Offset: 0x00001D10
		internal virtual void OnInput(global::System.Windows.Input.InputEventArgs e)
		{
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003B14 File Offset: 0x00001D14
		internal void BeginEdit(global::System.Windows.Input.InputEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = this.DataGridOwner;
			if (dataGridOwner != null && dataGridOwner.BeginEdit(e))
			{
				e.Handled = true;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000BD RID: 189 RVA: 0x00003B3B File Offset: 0x00001D3B
		// (set) Token: 0x060000BE RID: 190 RVA: 0x00003B4D File Offset: 0x00001D4D
		public bool CanUserResize
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.CanUserResizeProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.CanUserResizeProperty, value);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00003B60 File Offset: 0x00001D60
		private static object OnCoerceCanUserResize(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = d as global::Microsoft.Windows.Controls.DataGridColumn;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridColumn, baseValue, global::Microsoft.Windows.Controls.DataGridColumn.CanUserResizeProperty, dataGridColumn.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.CanUserResizeColumnsProperty);
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00003B8B File Offset: 0x00001D8B
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00003B9D File Offset: 0x00001D9D
		public global::System.Windows.Visibility Visibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Microsoft.Windows.Controls.DataGridColumn.VisibilityProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridColumn.VisibilityProperty, value);
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003BB0 File Offset: 0x00001DB0
		private static void OnVisibilityPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs eventArgs)
		{
			global::System.Windows.Visibility visibility = (global::System.Windows.Visibility)eventArgs.OldValue;
			global::System.Windows.Visibility visibility2 = (global::System.Windows.Visibility)eventArgs.NewValue;
			if (visibility != global::System.Windows.Visibility.Visible && visibility2 != global::System.Windows.Visibility.Visible)
			{
				return;
			}
			((global::Microsoft.Windows.Controls.DataGridColumn)d).NotifyPropertyChanged(d, eventArgs, global::Microsoft.Windows.Controls.NotificationTarget.CellsPresenter | global::Microsoft.Windows.Controls.NotificationTarget.ColumnCollection | global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeaders | global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeadersPresenter);
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x00003BED File Offset: 0x00001DED
		internal bool IsVisible
		{
			get
			{
				return this.Visibility == global::System.Windows.Visibility.Visible;
			}
		}

		// Token: 0x04000009 RID: 9
		private const double _starMaxWidth = 10000.0;

		// Token: 0x0400000A RID: 10
		public static readonly global::System.Windows.DependencyProperty HeaderProperty = global::System.Windows.DependencyProperty.Register("Header", typeof(object), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnNotifyColumnHeaderPropertyChanged)));

		// Token: 0x0400000B RID: 11
		public static readonly global::System.Windows.DependencyProperty HeaderStyleProperty = global::System.Windows.DependencyProperty.Register("HeaderStyle", typeof(global::System.Windows.Style), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnNotifyColumnHeaderPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnCoerceHeaderStyle)));

		// Token: 0x0400000C RID: 12
		public static readonly global::System.Windows.DependencyProperty HeaderStringFormatProperty = global::System.Windows.DependencyProperty.Register("HeaderStringFormat", typeof(string), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnNotifyColumnHeaderPropertyChanged)));

		// Token: 0x0400000D RID: 13
		public static readonly global::System.Windows.DependencyProperty HeaderTemplateProperty = global::System.Windows.DependencyProperty.Register("HeaderTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnNotifyColumnHeaderPropertyChanged)));

		// Token: 0x0400000E RID: 14
		public static readonly global::System.Windows.DependencyProperty HeaderTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register("HeaderTemplateSelector", typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnNotifyColumnHeaderPropertyChanged)));

		// Token: 0x0400000F RID: 15
		public static readonly global::System.Windows.DependencyProperty CellStyleProperty = global::System.Windows.DependencyProperty.Register("CellStyle", typeof(global::System.Windows.Style), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnNotifyCellPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnCoerceCellStyle)));

		// Token: 0x04000010 RID: 16
		public static readonly global::System.Windows.DependencyProperty IsReadOnlyProperty = global::System.Windows.DependencyProperty.Register("IsReadOnly", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnNotifyCellPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnCoerceIsReadOnly)));

		// Token: 0x04000011 RID: 17
		public static readonly global::System.Windows.DependencyProperty WidthProperty = global::System.Windows.DependencyProperty.Register("Width", typeof(global::Microsoft.Windows.Controls.DataGridLength), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.DataGridLength.Auto, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnWidthPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnCoerceWidth)));

		// Token: 0x04000012 RID: 18
		public static readonly global::System.Windows.DependencyProperty MinWidthProperty = global::System.Windows.DependencyProperty.Register("MinWidth", typeof(double), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(20.0, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnMinWidthPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnCoerceMinWidth)), new global::System.Windows.ValidateValueCallback(global::Microsoft.Windows.Controls.DataGridColumn.ValidateMinWidth));

		// Token: 0x04000013 RID: 19
		public static readonly global::System.Windows.DependencyProperty MaxWidthProperty = global::System.Windows.DependencyProperty.Register("MaxWidth", typeof(double), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(double.PositiveInfinity, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnMaxWidthPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnCoerceMaxWidth)), new global::System.Windows.ValidateValueCallback(global::Microsoft.Windows.Controls.DataGridColumn.ValidateMaxWidth));

		// Token: 0x04000014 RID: 20
		private static readonly global::System.Windows.DependencyPropertyKey ActualWidthPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ActualWidth", typeof(double), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(0.0, null, new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnCoerceActualWidth)));

		// Token: 0x04000015 RID: 21
		public static readonly global::System.Windows.DependencyProperty ActualWidthProperty = global::Microsoft.Windows.Controls.DataGridColumn.ActualWidthPropertyKey.DependencyProperty;

		// Token: 0x04000016 RID: 22
		private static readonly global::System.Windows.DependencyProperty OriginalValueProperty = global::System.Windows.DependencyProperty.RegisterAttached("OriginalValue", typeof(object), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000017 RID: 23
		public static readonly global::System.Windows.DependencyProperty DisplayIndexProperty = global::System.Windows.DependencyProperty.Register("DisplayIndex", typeof(int), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(-1, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.DisplayIndexChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnCoerceDisplayIndex)));

		// Token: 0x04000018 RID: 24
		public static readonly global::System.Windows.DependencyProperty SortMemberPathProperty = global::System.Windows.DependencyProperty.Register("SortMemberPath", typeof(string), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(string.Empty));

		// Token: 0x04000019 RID: 25
		public static readonly global::System.Windows.DependencyProperty CanUserSortProperty = global::System.Windows.DependencyProperty.Register("CanUserSort", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnCanUserSortPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnCoerceCanUserSort)));

		// Token: 0x0400001A RID: 26
		public static readonly global::System.Windows.DependencyProperty SortDirectionProperty = global::System.Windows.DependencyProperty.Register("SortDirection", typeof(global::System.ComponentModel.ListSortDirection?), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnNotifySortPropertyChanged)));

		// Token: 0x0400001B RID: 27
		private static readonly global::System.Windows.DependencyPropertyKey IsAutoGeneratedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsAutoGenerated", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(false));

		// Token: 0x0400001C RID: 28
		public static readonly global::System.Windows.DependencyProperty IsAutoGeneratedProperty = global::Microsoft.Windows.Controls.DataGridColumn.IsAutoGeneratedPropertyKey.DependencyProperty;

		// Token: 0x0400001D RID: 29
		private static readonly global::System.Windows.DependencyPropertyKey IsFrozenPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFrozen", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnNotifyFrozenPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnCoerceIsFrozen)));

		// Token: 0x0400001E RID: 30
		public static readonly global::System.Windows.DependencyProperty IsFrozenProperty = global::Microsoft.Windows.Controls.DataGridColumn.IsFrozenPropertyKey.DependencyProperty;

		// Token: 0x0400001F RID: 31
		public static readonly global::System.Windows.DependencyProperty CanUserReorderProperty = global::System.Windows.DependencyProperty.Register("CanUserReorder", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnNotifyColumnPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnCoerceCanUserReorder)));

		// Token: 0x04000020 RID: 32
		public static readonly global::System.Windows.DependencyProperty DragIndicatorStyleProperty = global::System.Windows.DependencyProperty.Register("DragIndicatorStyle", typeof(global::System.Windows.Style), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnNotifyColumnPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnCoerceDragIndicatorStyle)));

		// Token: 0x04000021 RID: 33
		private static readonly global::System.Windows.DependencyProperty CellValueProperty = global::System.Windows.DependencyProperty.RegisterAttached("CellValue", typeof(object), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000024 RID: 36
		public static readonly global::System.Windows.DependencyProperty CanUserResizeProperty = global::System.Windows.DependencyProperty.Register("CanUserResize", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnNotifyColumnHeaderPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnCoerceCanUserResize)));

		// Token: 0x04000025 RID: 37
		public static readonly global::System.Windows.DependencyProperty VisibilityProperty = global::System.Windows.DependencyProperty.Register("Visibility", typeof(global::System.Windows.Visibility), typeof(global::Microsoft.Windows.Controls.DataGridColumn), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridColumn.OnVisibilityPropertyChanged)));

		// Token: 0x04000026 RID: 38
		private global::Microsoft.Windows.Controls.DataGrid _dataGridOwner;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Data.BindingBase _clipboardContentBinding;

		// Token: 0x04000028 RID: 40
		private bool _ignoreRedistributionOnWidthChange;

		// Token: 0x04000029 RID: 41
		private bool _processingWidthChange;
	}
}
