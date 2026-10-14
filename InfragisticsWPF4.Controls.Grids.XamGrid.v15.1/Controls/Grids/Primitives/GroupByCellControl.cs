using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000212 RID: 530
	public class GroupByCellControl : global::Infragistics.Controls.Grids.Primitives.CellControlBase
	{
		// Token: 0x06000F11 RID: 3857 RVA: 0x00039279 File Offset: 0x00037479
		public GroupByCellControl()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Grids.Primitives.GroupByCellControl);
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x00039294 File Offset: 0x00037494
		protected internal override void EnsureContent()
		{
			global::System.Windows.FrameworkElement frameworkElement = base.Content as global::System.Windows.FrameworkElement;
			double num = 0.0;
			double num2 = 0.0;
			if (frameworkElement != null)
			{
				num = frameworkElement.ActualHeight;
				num2 = frameworkElement.ActualWidth;
			}
			if (this._content != null)
			{
				global::System.Windows.Data.Binding cellBinding = this.ResolveBinding(true);
				global::System.Windows.FrameworkElement frameworkElement2 = this._content.GenerateGroupByCellContent((global::Infragistics.Controls.Grids.Primitives.GroupByCell)base.Cell, cellBinding);
				if (frameworkElement2 != null)
				{
					base.Content = frameworkElement2;
					if (frameworkElement2.Width != num2 || frameworkElement2.Height != num)
					{
						base.Cell.Row.ActualHeight = 0.0;
					}
				}
			}
			base.EnsureContent();
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x0003933C File Offset: 0x0003753C
		protected override void AttachContent()
		{
			global::Infragistics.Controls.Grids.Primitives.GroupByRow groupByRow = (global::Infragistics.Controls.Grids.Primitives.GroupByRow)base.Cell.Row;
			global::Infragistics.Controls.Grids.Column groupedColumn = ((global::Infragistics.Controls.Grids.RowsManager)groupByRow.Manager).GroupedColumn;
			if (groupedColumn == null)
			{
				return;
			}
			global::System.Windows.DataTemplate groupByItemTemplate = groupedColumn.GroupByItemTemplate;
			if (groupByItemTemplate == null)
			{
				this._contentElement = null;
			}
			if (this._prevColumn != groupedColumn)
			{
				this._content = groupedColumn.GenerateContentProvider();
				if (groupByItemTemplate != null)
				{
					this._contentElement = (groupByItemTemplate.LoadContent() as global::System.Windows.FrameworkElement);
					base.Content = this._contentElement;
				}
				else
				{
					this._contentElement = null;
					base.Content = null;
				}
				this._prevColumn = groupedColumn;
			}
			if (this._contentElement != null)
			{
				this._contentElement.DataContext = groupByRow.GroupByData;
				return;
			}
			global::System.Windows.Data.Binding binding = this.ResolveBinding(true);
			global::System.Windows.FrameworkElement frameworkElement = this._content.GenerateGroupByCellContent((global::Infragistics.Controls.Grids.Primitives.GroupByCell)base.Cell, binding);
			if (frameworkElement != null)
			{
				base.Content = frameworkElement;
				return;
			}
			binding = this.ResolveBinding(false);
			base.SetBinding(global::System.Windows.Controls.ContentControl.ContentProperty, binding);
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x00039429 File Offset: 0x00037629
		public override global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase ContentProvider
		{
			get
			{
				return this._content;
			}
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00039431 File Offset: 0x00037631
		protected internal override global::System.Windows.Data.Binding ResolveBinding()
		{
			return this.ResolveBinding(false);
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x0003943C File Offset: 0x0003763C
		private global::System.Windows.Data.Binding ResolveBinding(bool overrideUseValue)
		{
			global::Infragistics.Controls.Grids.Primitives.GroupByRow groupByRow = (global::Infragistics.Controls.Grids.Primitives.GroupByRow)base.Cell.Row;
			global::System.Windows.Data.Binding binding = null;
			global::Infragistics.GroupByDataContext groupByData = groupByRow.GroupByData;
			if (groupByData != null)
			{
				global::System.Windows.Data.IValueConverter valueConverter = null;
				if (!overrideUseValue && groupByRow.ColumnLayout.Grid.GroupBySettings.DisplayCountOnGroupedRow)
				{
					global::Infragistics.Controls.Grids.Column resolveColumn = ((global::Infragistics.Controls.Grids.Cell)base.Cell).ResolveColumn;
					if (resolveColumn != null && !(resolveColumn is global::Infragistics.Controls.Grids.UnboundColumn) && resolveColumn.ValueConverter != null)
					{
						valueConverter = resolveColumn.ValueConverter;
						binding = new global::System.Windows.Data.Binding();
						binding.Path = new global::System.Windows.PropertyPath("Value", new object[0]);
					}
					else
					{
						binding = new global::System.Windows.Data.Binding();
						binding.Path = new global::System.Windows.PropertyPath("DisplayValue", new object[0]);
					}
				}
				else
				{
					binding = new global::System.Windows.Data.Binding();
					binding.Path = new global::System.Windows.PropertyPath("Value", new object[0]);
				}
				binding.Source = groupByData;
				binding.Mode = global::System.Windows.Data.BindingMode.OneTime;
				binding.ConverterCulture = global::System.Globalization.CultureInfo.CurrentCulture;
				binding.ConverterParameter = base.Cell;
				binding.Converter = new global::Infragistics.Controls.Grids.Primitives.GroupByCellControl.GroupByCellBindingConverter(valueConverter, groupByData.DisplayValueStringFormat, groupByData.Count);
			}
			return binding;
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x0003954E File Offset: 0x0003774E
		protected override void ReleaseContent()
		{
			base.ReleaseContent();
			if (this._contentElement != null)
			{
				this._contentElement.DataContext = null;
			}
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x0003956C File Offset: 0x0003776C
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			if (base.Cell != null && !(base.Cell.Column is global::Infragistics.Controls.Grids.Primitives.FillerColumn))
			{
				base.Cell.Row.ColumnLayout.Grid.ActiveCell = base.Cell;
			}
		}

		// Token: 0x040004D3 RID: 1235
		private global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase _content;

		// Token: 0x040004D4 RID: 1236
		private global::Infragistics.Controls.Grids.Column _prevColumn;

		// Token: 0x040004D5 RID: 1237
		private global::System.Windows.FrameworkElement _contentElement;

		// Token: 0x02000213 RID: 531
		internal class GroupByCellBindingConverter : global::Infragistics.Controls.Grids.Cell.CellBindingConverter
		{
			// Token: 0x06000F19 RID: 3865 RVA: 0x000395BA File Offset: 0x000377BA
			public GroupByCellBindingConverter(global::System.Windows.Data.IValueConverter valueConverter, string stringFormat, int count)
			{
				this._valueConverter = valueConverter;
				this._stringFormat = stringFormat;
				this._count = count;
			}

			// Token: 0x06000F1A RID: 3866 RVA: 0x000395D8 File Offset: 0x000377D8
			public override object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				global::Infragistics.Controls.Grids.Cell cell = (global::Infragistics.Controls.Grids.Cell)parameter;
				global::Infragistics.Controls.Grids.Column resolveColumn = cell.ResolveColumn;
				if (this._valueConverter != null)
				{
					object obj = this._valueConverter.Convert(value, targetType, resolveColumn.ValueConverterParameter, culture);
					return string.Format(this._stringFormat, obj ?? string.Empty, this._count);
				}
				object obj2 = value;
				if (cell.Control != null && cell.Control.ContentProvider != null)
				{
					obj2 = cell.Control.ContentProvider.ApplyFormatting(value, resolveColumn, culture);
				}
				if (obj2 is global::System.IConvertible)
				{
					return global::System.Convert.ChangeType(obj2, typeof(string), global::System.Globalization.CultureInfo.CurrentCulture);
				}
				return obj2;
			}

			// Token: 0x040004D6 RID: 1238
			private readonly global::System.Windows.Data.IValueConverter _valueConverter;

			// Token: 0x040004D7 RID: 1239
			private readonly string _stringFormat;

			// Token: 0x040004D8 RID: 1240
			private readonly int _count;
		}
	}
}
