using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Windows.Controls.Primitives;
using MS.Internal;

namespace Microsoft.Windows.Controls
{
	// Token: 0x02000037 RID: 55
	internal static class DataGridHelper
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x0000B0B0 File Offset: 0x000092B0
		public static global::System.Windows.Size SubtractFromSize(global::System.Windows.Size size, double thickness, bool height)
		{
			if (height)
			{
				return new global::System.Windows.Size(size.Width, global::System.Math.Max(0.0, size.Height - thickness));
			}
			return new global::System.Windows.Size(global::System.Math.Max(0.0, size.Width - thickness), size.Height);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000B108 File Offset: 0x00009308
		public static bool IsGridLineVisible(global::Microsoft.Windows.Controls.DataGrid dataGrid, bool isHorizontal)
		{
			if (dataGrid != null)
			{
				switch (dataGrid.GridLinesVisibility)
				{
				case global::Microsoft.Windows.Controls.DataGridGridLinesVisibility.All:
					return true;
				case global::Microsoft.Windows.Controls.DataGridGridLinesVisibility.Horizontal:
					return isHorizontal;
				case global::Microsoft.Windows.Controls.DataGridGridLinesVisibility.None:
					return false;
				case global::Microsoft.Windows.Controls.DataGridGridLinesVisibility.Vertical:
					return !isHorizontal;
				}
			}
			return false;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000B145 File Offset: 0x00009345
		public static bool ShouldNotifyCells(global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			return global::Microsoft.Windows.Controls.DataGridHelper.TestTarget(target, global::Microsoft.Windows.Controls.NotificationTarget.Cells);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000B14E File Offset: 0x0000934E
		public static bool ShouldNotifyCellsPresenter(global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			return global::Microsoft.Windows.Controls.DataGridHelper.TestTarget(target, global::Microsoft.Windows.Controls.NotificationTarget.CellsPresenter);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000B157 File Offset: 0x00009357
		public static bool ShouldNotifyColumns(global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			return global::Microsoft.Windows.Controls.DataGridHelper.TestTarget(target, global::Microsoft.Windows.Controls.NotificationTarget.Columns);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000B160 File Offset: 0x00009360
		public static bool ShouldNotifyColumnHeaders(global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			return global::Microsoft.Windows.Controls.DataGridHelper.TestTarget(target, global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeaders);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000B16A File Offset: 0x0000936A
		public static bool ShouldNotifyColumnHeadersPresenter(global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			return global::Microsoft.Windows.Controls.DataGridHelper.TestTarget(target, global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeadersPresenter);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0000B174 File Offset: 0x00009374
		public static bool ShouldNotifyColumnCollection(global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			return global::Microsoft.Windows.Controls.DataGridHelper.TestTarget(target, global::Microsoft.Windows.Controls.NotificationTarget.ColumnCollection);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000B17D File Offset: 0x0000937D
		public static bool ShouldNotifyDataGrid(global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			return global::Microsoft.Windows.Controls.DataGridHelper.TestTarget(target, global::Microsoft.Windows.Controls.NotificationTarget.DataGrid);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000B187 File Offset: 0x00009387
		public static bool ShouldNotifyDetailsPresenter(global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			return global::Microsoft.Windows.Controls.DataGridHelper.TestTarget(target, global::Microsoft.Windows.Controls.NotificationTarget.DetailsPresenter);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000B194 File Offset: 0x00009394
		public static bool ShouldRefreshCellContent(global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			return global::Microsoft.Windows.Controls.DataGridHelper.TestTarget(target, global::Microsoft.Windows.Controls.NotificationTarget.RefreshCellContent);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000B1A1 File Offset: 0x000093A1
		public static bool ShouldNotifyRowHeaders(global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			return global::Microsoft.Windows.Controls.DataGridHelper.TestTarget(target, global::Microsoft.Windows.Controls.NotificationTarget.RowHeaders);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000B1AE File Offset: 0x000093AE
		public static bool ShouldNotifyRows(global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			return global::Microsoft.Windows.Controls.DataGridHelper.TestTarget(target, global::Microsoft.Windows.Controls.NotificationTarget.Rows);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0000B1BC File Offset: 0x000093BC
		public static bool ShouldNotifyRowSubtree(global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			global::Microsoft.Windows.Controls.NotificationTarget value = global::Microsoft.Windows.Controls.NotificationTarget.Cells | global::Microsoft.Windows.Controls.NotificationTarget.CellsPresenter | global::Microsoft.Windows.Controls.NotificationTarget.DetailsPresenter | global::Microsoft.Windows.Controls.NotificationTarget.RefreshCellContent | global::Microsoft.Windows.Controls.NotificationTarget.RowHeaders | global::Microsoft.Windows.Controls.NotificationTarget.Rows;
			return global::Microsoft.Windows.Controls.DataGridHelper.TestTarget(target, value);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000B1D6 File Offset: 0x000093D6
		private static bool TestTarget(global::Microsoft.Windows.Controls.NotificationTarget target, global::Microsoft.Windows.Controls.NotificationTarget value)
		{
			return (target & value) != global::Microsoft.Windows.Controls.NotificationTarget.None;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000B1E4 File Offset: 0x000093E4
		public static T FindParent<T>(global::System.Windows.FrameworkElement element) where T : global::System.Windows.FrameworkElement
		{
			for (global::System.Windows.FrameworkElement frameworkElement = element.TemplatedParent as global::System.Windows.FrameworkElement; frameworkElement != null; frameworkElement = (frameworkElement.TemplatedParent as global::System.Windows.FrameworkElement))
			{
				T t = frameworkElement as T;
				if (t != null)
				{
					return t;
				}
			}
			return default(T);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000B230 File Offset: 0x00009430
		public static T FindVisualParent<T>(global::System.Windows.UIElement element) where T : global::System.Windows.UIElement
		{
			for (global::System.Windows.UIElement uielement = element; uielement != null; uielement = (global::System.Windows.Media.VisualTreeHelper.GetParent(uielement) as global::System.Windows.UIElement))
			{
				T t = uielement as T;
				if (t != null)
				{
					return t;
				}
			}
			return default(T);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000B270 File Offset: 0x00009470
		public static bool TreeHasFocusAndTabStop(global::System.Windows.DependencyObject element)
		{
			if (element == null)
			{
				return false;
			}
			global::System.Windows.UIElement uielement = element as global::System.Windows.UIElement;
			if (uielement != null)
			{
				if (uielement.Focusable && global::System.Windows.Input.KeyboardNavigation.GetIsTabStop(uielement))
				{
					return true;
				}
			}
			else
			{
				global::System.Windows.ContentElement contentElement = element as global::System.Windows.ContentElement;
				if (contentElement != null && contentElement.Focusable && global::System.Windows.Input.KeyboardNavigation.GetIsTabStop(contentElement))
				{
					return true;
				}
			}
			int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(element);
			for (int i = 0; i < childrenCount; i++)
			{
				global::System.Windows.DependencyObject child = global::System.Windows.Media.VisualTreeHelper.GetChild(element, i);
				if (global::Microsoft.Windows.Controls.DataGridHelper.TreeHasFocusAndTabStop(child))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000B2E4 File Offset: 0x000094E4
		public static void OnColumnWidthChanged(global::Microsoft.Windows.Controls.IProvideDataGridColumn cell, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)cell;
			global::Microsoft.Windows.Controls.DataGridColumn column = cell.Column;
			bool flag = cell is global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader;
			if (column != null)
			{
				global::Microsoft.Windows.Controls.DataGridLength width = column.Width;
				if (width.IsAuto || (!flag && width.IsSizeToCells) || (flag && width.IsSizeToHeader))
				{
					global::Microsoft.Windows.Controls.DataGridLength dataGridLength = (global::Microsoft.Windows.Controls.DataGridLength)e.OldValue;
					double num;
					if (dataGridLength.UnitType != width.UnitType)
					{
						double constraintWidth = column.GetConstraintWidth(flag);
						if (!global::MS.Internal.DoubleUtil.AreClose(uielement.DesiredSize.Width, constraintWidth))
						{
							uielement.InvalidateMeasure();
							uielement.Measure(new global::System.Windows.Size(constraintWidth, double.PositiveInfinity));
						}
						num = uielement.DesiredSize.Width;
					}
					else
					{
						num = dataGridLength.DesiredValue;
					}
					if (global::MS.Internal.DoubleUtil.IsNaN(width.DesiredValue) || global::MS.Internal.DoubleUtil.LessThan(width.DesiredValue, num))
					{
						column.SetWidthInternal(new global::Microsoft.Windows.Controls.DataGridLength(width.Value, width.UnitType, num, width.DisplayValue));
					}
				}
			}
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000B400 File Offset: 0x00009600
		public static global::System.Windows.Media.Geometry GetFrozenClipForCell(global::Microsoft.Windows.Controls.IProvideDataGridColumn cell)
		{
			global::Microsoft.Windows.Controls.DataGridCellsPanel parentPanelForCell = global::Microsoft.Windows.Controls.DataGridHelper.GetParentPanelForCell(cell);
			if (parentPanelForCell != null)
			{
				return parentPanelForCell.GetFrozenClipForChild((global::System.Windows.UIElement)cell);
			}
			return null;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000B428 File Offset: 0x00009628
		public static global::Microsoft.Windows.Controls.DataGridCellsPanel GetParentPanelForCell(global::Microsoft.Windows.Controls.IProvideDataGridColumn cell)
		{
			global::System.Windows.UIElement reference = (global::System.Windows.UIElement)cell;
			return global::System.Windows.Media.VisualTreeHelper.GetParent(reference) as global::Microsoft.Windows.Controls.DataGridCellsPanel;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000B448 File Offset: 0x00009648
		public static double GetParentCellsPanelHorizontalOffset(global::Microsoft.Windows.Controls.IProvideDataGridColumn cell)
		{
			global::Microsoft.Windows.Controls.DataGridCellsPanel parentPanelForCell = global::Microsoft.Windows.Controls.DataGridHelper.GetParentPanelForCell(cell);
			if (parentPanelForCell != null)
			{
				return parentPanelForCell.ComputeCellsPanelHorizontalOffset();
			}
			return 0.0;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000B470 File Offset: 0x00009670
		public static bool IsDefaultValue(global::System.Windows.DependencyObject d, global::System.Windows.DependencyProperty dp)
		{
			return global::System.Windows.DependencyPropertyHelper.GetValueSource(d, dp).BaseValueSource == global::System.Windows.BaseValueSource.Default;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000B48F File Offset: 0x0000968F
		public static object GetCoercedTransferPropertyValue(global::System.Windows.DependencyObject baseObject, object baseValue, global::System.Windows.DependencyProperty baseProperty, global::System.Windows.DependencyObject parentObject, global::System.Windows.DependencyProperty parentProperty)
		{
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(baseObject, baseValue, baseProperty, parentObject, parentProperty, null, null);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000B4A0 File Offset: 0x000096A0
		public static object GetCoercedTransferPropertyValue(global::System.Windows.DependencyObject baseObject, object baseValue, global::System.Windows.DependencyProperty baseProperty, global::System.Windows.DependencyObject parentObject, global::System.Windows.DependencyProperty parentProperty, global::System.Windows.DependencyObject grandParentObject, global::System.Windows.DependencyProperty grandParentProperty)
		{
			object result = baseValue;
			if (global::Microsoft.Windows.Controls.DataGridHelper.IsPropertyTransferEnabled(baseObject, baseProperty))
			{
				global::System.Windows.BaseValueSource baseValueSource = global::System.Windows.DependencyPropertyHelper.GetValueSource(baseObject, baseProperty).BaseValueSource;
				if (parentObject != null)
				{
					global::System.Windows.ValueSource valueSource = global::System.Windows.DependencyPropertyHelper.GetValueSource(parentObject, parentProperty);
					if (valueSource.BaseValueSource > baseValueSource)
					{
						result = parentObject.GetValue(parentProperty);
						baseValueSource = valueSource.BaseValueSource;
					}
				}
				if (grandParentObject != null)
				{
					global::System.Windows.ValueSource valueSource2 = global::System.Windows.DependencyPropertyHelper.GetValueSource(grandParentObject, grandParentProperty);
					if (valueSource2.BaseValueSource > baseValueSource)
					{
						result = grandParentObject.GetValue(grandParentProperty);
						baseValueSource = valueSource2.BaseValueSource;
					}
				}
			}
			return result;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000B51C File Offset: 0x0000971C
		public static void TransferProperty(global::System.Windows.DependencyObject d, global::System.Windows.DependencyProperty p)
		{
			global::System.Collections.Generic.Dictionary<global::System.Windows.DependencyProperty, bool> propertyTransferEnabledMapForObject = global::Microsoft.Windows.Controls.DataGridHelper.GetPropertyTransferEnabledMapForObject(d);
			propertyTransferEnabledMapForObject[p] = true;
			d.CoerceValue(p);
			propertyTransferEnabledMapForObject[p] = false;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000B548 File Offset: 0x00009748
		private static global::System.Collections.Generic.Dictionary<global::System.Windows.DependencyProperty, bool> GetPropertyTransferEnabledMapForObject(global::System.Windows.DependencyObject d)
		{
			global::System.Collections.Generic.Dictionary<global::System.Windows.DependencyProperty, bool> dictionary = global::Microsoft.Windows.Controls.DataGridHelper._propertyTransferEnabledMap[d] as global::System.Collections.Generic.Dictionary<global::System.Windows.DependencyProperty, bool>;
			if (dictionary == null)
			{
				dictionary = new global::System.Collections.Generic.Dictionary<global::System.Windows.DependencyProperty, bool>();
				global::Microsoft.Windows.Controls.DataGridHelper._propertyTransferEnabledMap.SetWeak(d, dictionary);
			}
			return dictionary;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000B57C File Offset: 0x0000977C
		internal static bool IsPropertyTransferEnabled(global::System.Windows.DependencyObject d, global::System.Windows.DependencyProperty p)
		{
			global::System.Collections.Generic.Dictionary<global::System.Windows.DependencyProperty, bool> dictionary = global::Microsoft.Windows.Controls.DataGridHelper._propertyTransferEnabledMap[d] as global::System.Collections.Generic.Dictionary<global::System.Windows.DependencyProperty, bool>;
			bool flag;
			return dictionary != null && dictionary.TryGetValue(p, out flag) && flag;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000B5AC File Offset: 0x000097AC
		public static string GetTheme(global::System.Windows.FrameworkElement element)
		{
			object obj = element.ReadLocalValue(global::Microsoft.Windows.Controls.DataGridHelper.ThemeProperty);
			if (obj == global::System.Windows.DependencyProperty.UnsetValue)
			{
				element.SetResourceReference(global::Microsoft.Windows.Controls.DataGridHelper.ThemeProperty, global::Microsoft.Windows.Controls.DataGridHelper._themeKey);
			}
			return (string)element.GetValue(global::Microsoft.Windows.Controls.DataGridHelper.ThemeProperty);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000B5ED File Offset: 0x000097ED
		public static void HookThemeChange(global::System.Type type, global::System.Windows.PropertyChangedCallback propertyChangedCallback)
		{
			global::Microsoft.Windows.Controls.DataGridHelper.ThemeProperty.OverrideMetadata(type, new global::System.Windows.FrameworkPropertyMetadata(string.Empty, propertyChangedCallback));
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000B608 File Offset: 0x00009808
		internal static bool IsOneWay(global::System.Windows.Data.BindingBase bindingBase)
		{
			if (bindingBase == null)
			{
				return false;
			}
			global::System.Windows.Data.Binding binding = bindingBase as global::System.Windows.Data.Binding;
			if (binding != null)
			{
				return binding.Mode == global::System.Windows.Data.BindingMode.OneWay;
			}
			global::System.Windows.Data.MultiBinding multiBinding = bindingBase as global::System.Windows.Data.MultiBinding;
			if (multiBinding != null)
			{
				return multiBinding.Mode == global::System.Windows.Data.BindingMode.OneWay;
			}
			global::System.Windows.Data.PriorityBinding priorityBinding = bindingBase as global::System.Windows.Data.PriorityBinding;
			if (priorityBinding != null)
			{
				global::System.Collections.ObjectModel.Collection<global::System.Windows.Data.BindingBase> bindings = priorityBinding.Bindings;
				int count = bindings.Count;
				for (int i = 0; i < count; i++)
				{
					if (global::Microsoft.Windows.Controls.DataGridHelper.IsOneWay(bindings[i]))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000B680 File Offset: 0x00009880
		internal static void EnsureTwoWayIfNotOneWay(global::System.Windows.Data.BindingBase bindingBase)
		{
			if (bindingBase == null)
			{
				return;
			}
			global::System.Windows.Data.Binding binding = bindingBase as global::System.Windows.Data.Binding;
			if (binding != null)
			{
				if (binding.Mode != global::System.Windows.Data.BindingMode.OneWay)
				{
					if (binding.Mode != global::System.Windows.Data.BindingMode.TwoWay)
					{
						binding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
					}
					if (binding.UpdateSourceTrigger != global::System.Windows.Data.UpdateSourceTrigger.Explicit)
					{
						binding.UpdateSourceTrigger = global::System.Windows.Data.UpdateSourceTrigger.Explicit;
					}
				}
				return;
			}
			global::System.Windows.Data.MultiBinding multiBinding = bindingBase as global::System.Windows.Data.MultiBinding;
			if (multiBinding != null)
			{
				if (multiBinding.Mode != global::System.Windows.Data.BindingMode.OneWay)
				{
					if (multiBinding.Mode != global::System.Windows.Data.BindingMode.TwoWay)
					{
						multiBinding.Mode = global::System.Windows.Data.BindingMode.TwoWay;
					}
					if (multiBinding.UpdateSourceTrigger != global::System.Windows.Data.UpdateSourceTrigger.Explicit)
					{
						multiBinding.UpdateSourceTrigger = global::System.Windows.Data.UpdateSourceTrigger.Explicit;
					}
				}
				return;
			}
			global::System.Windows.Data.PriorityBinding priorityBinding = bindingBase as global::System.Windows.Data.PriorityBinding;
			if (priorityBinding != null)
			{
				global::System.Collections.ObjectModel.Collection<global::System.Windows.Data.BindingBase> bindings = priorityBinding.Bindings;
				int count = bindings.Count;
				for (int i = 0; i < count; i++)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.EnsureTwoWayIfNotOneWay(bindings[i]);
				}
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000B72E File Offset: 0x0000992E
		internal static global::System.Windows.Data.BindingExpression GetBindingExpression(global::System.Windows.FrameworkElement element, global::System.Windows.DependencyProperty dp)
		{
			if (element != null)
			{
				return element.GetBindingExpression(dp);
			}
			return null;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000B73C File Offset: 0x0000993C
		internal static void UpdateSource(global::System.Windows.FrameworkElement element, global::System.Windows.DependencyProperty dp)
		{
			global::System.Windows.Data.BindingExpression bindingExpression = global::Microsoft.Windows.Controls.DataGridHelper.GetBindingExpression(element, dp);
			if (bindingExpression != null)
			{
				bindingExpression.UpdateSource();
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0000B75C File Offset: 0x0000995C
		internal static void UpdateTarget(global::System.Windows.FrameworkElement element, global::System.Windows.DependencyProperty dp)
		{
			global::System.Windows.Data.BindingExpression bindingExpression = global::Microsoft.Windows.Controls.DataGridHelper.GetBindingExpression(element, dp);
			if (bindingExpression != null)
			{
				bindingExpression.UpdateTarget();
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000B77A File Offset: 0x0000997A
		internal static void SyncColumnProperty(global::System.Windows.DependencyObject column, global::System.Windows.DependencyObject content, global::System.Windows.DependencyProperty contentProperty, global::System.Windows.DependencyProperty columnProperty)
		{
			if (global::Microsoft.Windows.Controls.DataGridHelper.IsDefaultValue(column, columnProperty))
			{
				content.ClearValue(contentProperty);
				return;
			}
			content.SetValue(contentProperty, column.GetValue(columnProperty));
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000B79B File Offset: 0x0000999B
		internal static string GetPathFromBinding(global::System.Windows.Data.Binding binding)
		{
			if (binding != null)
			{
				if (!string.IsNullOrEmpty(binding.XPath))
				{
					return binding.XPath;
				}
				if (binding.Path != null)
				{
					return binding.Path.Path;
				}
			}
			return null;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000B7C9 File Offset: 0x000099C9
		public static bool AreRowHeadersVisible(global::Microsoft.Windows.Controls.DataGridHeadersVisibility headersVisibility)
		{
			return (headersVisibility & global::Microsoft.Windows.Controls.DataGridHeadersVisibility.Row) == global::Microsoft.Windows.Controls.DataGridHeadersVisibility.Row;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000B7D1 File Offset: 0x000099D1
		public static double CoerceToMinMax(double value, double minValue, double maxValue)
		{
			value = global::System.Math.Max(value, minValue);
			value = global::System.Math.Min(value, maxValue);
			return value;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000B7E8 File Offset: 0x000099E8
		public static bool HasNonEscapeCharacters(global::System.Windows.Input.TextCompositionEventArgs textArgs)
		{
			if (textArgs != null)
			{
				string text = textArgs.Text;
				int i = 0;
				int length = text.Length;
				while (i < length)
				{
					if (text[i] != '\u001b')
					{
						return true;
					}
					i++;
				}
			}
			return false;
		}

		// Token: 0x040000D1 RID: 209
		private const char _escapeChar = '\u001b';

		// Token: 0x040000D2 RID: 210
		private static global::Microsoft.Windows.Controls.WeakHashtable _propertyTransferEnabledMap = new global::Microsoft.Windows.Controls.WeakHashtable();

		// Token: 0x040000D3 RID: 211
		private static readonly global::System.Windows.DependencyProperty ThemeProperty = global::System.Windows.DependencyProperty.RegisterAttached("Theme", typeof(string), typeof(global::Microsoft.Windows.Controls.DataGridHelper), new global::System.Windows.FrameworkPropertyMetadata(string.Empty));

		// Token: 0x040000D4 RID: 212
		private static global::System.Windows.ComponentResourceKey _themeKey = new global::System.Windows.ComponentResourceKey(typeof(global::Microsoft.Windows.Controls.DataGrid), "Theme");
	}
}
