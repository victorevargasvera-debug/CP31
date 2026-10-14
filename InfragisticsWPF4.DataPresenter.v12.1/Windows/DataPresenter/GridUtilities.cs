using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Windows.Threading;
using System.Xml;
using Infragistics.Collections;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter.Calculations;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000A0 RID: 160
	internal static class GridUtilities
	{
		// Token: 0x060007D8 RID: 2008 RVA: 0x00022330 File Offset: 0x00020530
		public static T[] Aggregate<T>(params global::System.Collections.Generic.IEnumerable<T>[] collections)
		{
			global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>();
			foreach (global::System.Collections.Generic.IEnumerable<T> enumerable in collections)
			{
				if (enumerable != null)
				{
					list.AddRange(enumerable);
				}
			}
			return list.ToArray();
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00022367 File Offset: 0x00020567
		public static bool AreClose(double x, double y)
		{
			return x == y || global::System.Math.Abs(x - y) < 1E-10;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00022382 File Offset: 0x00020582
		public static bool AreClose(double x, double y, double tolerance)
		{
			return x == y || global::System.Math.Abs(x - y) <= tolerance;
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00022398 File Offset: 0x00020598
		public static bool AreClose(global::System.Windows.Size x, global::System.Windows.Size y)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(x.Width, y.Width) && global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(x.Height, y.Height);
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x000223C4 File Offset: 0x000205C4
		public static bool AreClose(global::System.Windows.Rect x, global::System.Windows.Rect y)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(x.Width, y.Width) && global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(x.Height, y.Height) && global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(x.Left, y.Left) && global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(x.Top, y.Top);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00022428 File Offset: 0x00020628
		public static bool AreClose(global::System.Windows.Thickness x, global::System.Windows.Thickness y)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(x.Left, y.Left) && global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(x.Top, y.Top) && global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(x.Right, y.Right) && global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(x.Bottom, y.Bottom);
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0002248C File Offset: 0x0002068C
		internal static bool AreEqual(object item1, object item2)
		{
			if (item1 == item2)
			{
				return true;
			}
			global::System.Type type = (item1 != null) ? item1.GetType() : null;
			return type != null && type.IsValueType && object.Equals(item1, item2);
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x000224C6 File Offset: 0x000206C6
		internal static bool AreEqual(string x, string y, bool considerNullAsEmptyString)
		{
			if (!considerNullAsEmptyString)
			{
				return x == y;
			}
			return (x ?? string.Empty) == (y ?? string.Empty);
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x000224EC File Offset: 0x000206EC
		public static bool AreKeysEqual(string xxKey, string yyKey)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.AreKeysEqual(xxKey, yyKey, false);
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x000224F6 File Offset: 0x000206F6
		public static bool AreKeysEqual(string xxKey, string yyKey, bool ignoreCase)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.Compare(xxKey, yyKey, ignoreCase) == 0 && !string.IsNullOrEmpty(xxKey) && !string.IsNullOrEmpty(yyKey);
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00022515 File Offset: 0x00020715
		public static bool AreSameTypeAndEqual(object x, object y)
		{
			return x == y || (x != null && y != null && x.GetType() == y.GetType() && object.Equals(x, y));
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0002253F File Offset: 0x0002073F
		public static int ArrMax(int[] arr)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.ArrMax(arr, 0, arr.Length);
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0002254C File Offset: 0x0002074C
		public static int ArrMax(int[] arr, int startIndex, int count)
		{
			int num = arr[startIndex];
			for (int i = 1; i < count; i++)
			{
				num = global::System.Math.Max(num, arr[startIndex + i]);
			}
			return num;
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00022578 File Offset: 0x00020778
		public static double ArrSum(double[] arr, int startIndex, int count)
		{
			double num = 0.0;
			for (int i = 0; i < count; i++)
			{
				num += arr[startIndex + i];
			}
			return num;
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000225A4 File Offset: 0x000207A4
		public static int Compare(string xx, string yy, bool ignoreCase)
		{
			return string.Compare(xx, yy, ignoreCase, global::Infragistics.Windows.DataPresenter.GridUtilities.StringCompareCulture);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x000225B3 File Offset: 0x000207B3
		public static int Compare(global::Infragistics.Windows.DataPresenter.FixedFieldLocation x, global::Infragistics.Windows.DataPresenter.FixedFieldLocation y)
		{
			if (x == y)
			{
				return 0;
			}
			if (x == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge)
			{
				return -1;
			}
			if (x == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge)
			{
				return 1;
			}
			if (y == global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge)
			{
				return 1;
			}
			return -1;
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x000225D0 File Offset: 0x000207D0
		public static bool CompareLists(global::System.Collections.IEnumerable xList, global::System.Collections.IEnumerable yList)
		{
			int num = (xList is global::System.Collections.IList) ? ((global::System.Collections.IList)xList).Count : -1;
			int num2 = (yList is global::System.Collections.IList) ? ((global::System.Collections.IList)yList).Count : -1;
			if (num >= 0 && num2 >= 0 && num != num2)
			{
				return false;
			}
			if (xList == null)
			{
				xList = global::Infragistics.Windows.DataPresenter.GridUtilities.GetEmptyEnumerable();
			}
			if (yList == null)
			{
				yList = global::Infragistics.Windows.DataPresenter.GridUtilities.GetEmptyEnumerable();
			}
			global::System.Collections.IEnumerator enumerator = yList.GetEnumerator();
			foreach (object obj in xList)
			{
				if (!enumerator.MoveNext())
				{
					return false;
				}
				if (enumerator.Current != obj)
				{
					return false;
				}
			}
			return !enumerator.MoveNext();
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x000226A0 File Offset: 0x000208A0
		internal static bool Contains(global::System.Windows.Rect r, global::System.Windows.Point pt, bool horz)
		{
			return (horz && r.X <= pt.X && pt.X <= r.Right) || (!horz && r.Y <= pt.Y && pt.Y <= r.Bottom);
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x000226FC File Offset: 0x000208FC
		internal static bool Contains(global::System.Collections.IEnumerable e, object item)
		{
			foreach (object obj in e)
			{
				if (obj == item)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00022750 File Offset: 0x00020950
		internal static bool ContainsExclusive(global::System.Windows.Rect rect, global::System.Windows.Point pt)
		{
			return (pt.X >= rect.X || global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(rect.X, pt.X)) && pt.X < rect.Right && !global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(rect.Right, pt.X) && (pt.Y >= rect.Y || global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(rect.Y, pt.Y)) && pt.Y < rect.Bottom && !global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(rect.Bottom, pt.Y);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x000227F4 File Offset: 0x000209F4
		private static void CoerceCollapsedCellVisibility(global::System.Windows.DependencyObject d, ref object newValue)
		{
			global::Infragistics.Windows.DataPresenter.Field field = null;
			global::Infragistics.Windows.DataPresenter.Record record = null;
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = d as global::Infragistics.Windows.DataPresenter.CellValuePresenter;
			if (cellValuePresenter != null)
			{
				field = cellValuePresenter.Field;
				record = cellValuePresenter.Record;
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.CellPresenter cellPresenter = d as global::Infragistics.Windows.DataPresenter.CellPresenter;
				if (cellPresenter != null)
				{
					field = cellPresenter.Field;
					record = cellPresenter.Record;
				}
			}
			if (record != null && field != null && record.ShouldCollapseCell(field))
			{
				newValue = global::Infragistics.KnownBoxes.VisibilityHiddenBox;
			}
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00022850 File Offset: 0x00020A50
		internal static object CoerceFieldElementVisibility(global::System.Windows.DependencyObject d, object newValue)
		{
			if (newValue == null || !global::System.Windows.Visibility.Collapsed.Equals(newValue))
			{
				global::System.Windows.Visibility fieldVisibility = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldVisibility(d);
				switch (fieldVisibility)
				{
				case global::System.Windows.Visibility.Hidden:
					newValue = global::Infragistics.KnownBoxes.VisibilityHiddenBox;
					break;
				case global::System.Windows.Visibility.Collapsed:
					newValue = global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
					break;
				}
				if (fieldVisibility != global::System.Windows.Visibility.Collapsed)
				{
					global::Infragistics.Windows.DataPresenter.CellContentAlignment cellContentAlignment = global::Infragistics.Windows.DataPresenter.GridUtilities.GetCellContentAlignment(d);
					if (cellContentAlignment != global::Infragistics.Windows.DataPresenter.CellContentAlignment.Default)
					{
						if (d is global::Infragistics.Windows.DataPresenter.LabelPresenter)
						{
							if (cellContentAlignment == global::Infragistics.Windows.DataPresenter.CellContentAlignment.ValueOnly)
							{
								newValue = global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
							}
						}
						else if (cellContentAlignment == global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelOnly)
						{
							newValue = global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
						}
					}
					if (!global::System.Windows.Visibility.Collapsed.Equals(newValue))
					{
						global::Infragistics.Windows.DataPresenter.GridUtilities.CoerceCollapsedCellVisibility(d, ref newValue);
					}
				}
			}
			return newValue;
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x000228E0 File Offset: 0x00020AE0
		internal static global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager CreateGridBagLayoutManager(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.LayoutManagerType type)
		{
			return new global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager(fieldLayout, type)
			{
				ExpandToFitHeight = true,
				ExpandToFitWidth = true
			};
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00022904 File Offset: 0x00020B04
		internal static global::System.Windows.Data.BindingBase CreateRecordContentMarginBinding(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool isHeader, global::System.Type targetType)
		{
			if (fieldLayout == null)
			{
				return null;
			}
			global::System.Windows.Data.MultiBinding multiBinding = new global::System.Windows.Data.MultiBinding();
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
			binding.RelativeSource = global::System.Windows.Data.RelativeSource.Self;
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			multiBinding.Bindings.Add(binding);
			binding = new global::System.Windows.Data.Binding();
			binding.Source = fieldLayout;
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			binding.Path = new global::System.Windows.PropertyPath("RecordIndentVersion", new object[0]);
			multiBinding.Bindings.Add(binding);
			binding = new global::System.Windows.Data.Binding();
			binding.RelativeSource = global::System.Windows.Data.RelativeSource.Self;
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			binding.Path = new global::System.Windows.PropertyPath("DataContext", new object[0]);
			multiBinding.Bindings.Add(binding);
			binding = new global::System.Windows.Data.Binding();
			binding.RelativeSource = global::System.Windows.Data.RelativeSource.Self;
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			binding.Path = new global::System.Windows.PropertyPath(global::Infragistics.Windows.DataPresenter.GridUtilities.RecordContentMarginConverter.VersionProperty);
			multiBinding.Bindings.Add(binding);
			multiBinding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			multiBinding.Converter = global::Infragistics.Windows.DataPresenter.GridUtilities.RecordContentMarginConverter.Instance;
			multiBinding.ConverterParameter = new object[]
			{
				global::Infragistics.KnownBoxes.FromValue(isHeader),
				targetType
			};
			return multiBinding;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00022A14 File Offset: 0x00020C14
		internal static void CopyNonSerializableSettings(object target, object source)
		{
			if (target == null || source == null)
			{
				return;
			}
			global::System.Type type = target.GetType();
			if (source.GetType() != type)
			{
				return;
			}
			global::System.Reflection.PropertyInfo[] properties = type.GetProperties(global::System.Reflection.BindingFlags.DeclaredOnly | global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.GetProperty | global::System.Reflection.BindingFlags.SetProperty);
			foreach (global::System.Reflection.PropertyInfo propertyInfo in properties)
			{
				if (propertyInfo.CanRead && propertyInfo.CanWrite)
				{
					object[] customAttributes = propertyInfo.GetCustomAttributes(typeof(global::System.ComponentModel.DesignerSerializationVisibilityAttribute), false);
					if (customAttributes.Length == 1 && customAttributes[0] is global::System.ComponentModel.DesignerSerializationVisibilityAttribute && ((global::System.ComponentModel.DesignerSerializationVisibilityAttribute)customAttributes[0]).Visibility == global::System.ComponentModel.DesignerSerializationVisibility.Hidden)
					{
						object value = propertyInfo.GetValue(source, null);
						propertyInfo.SetValue(target, value, null);
					}
				}
			}
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00022ABC File Offset: 0x00020CBC
		public static void CopyTo<T>(global::System.Collections.Generic.IEnumerable<T> items, T[] array, int arrayIndex)
		{
			foreach (T t in items)
			{
				array[arrayIndex++] = t;
			}
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00022B0C File Offset: 0x00020D0C
		public static double Distance(global::System.Windows.Point a, global::System.Windows.Point b)
		{
			double num = a.X - b.X;
			double num2 = a.Y - b.Y;
			return global::System.Math.Sqrt(num * num + num2 * num2);
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00022B48 File Offset: 0x00020D48
		internal static bool DoesElementContainPoint(global::System.Windows.FrameworkElement elem, global::System.Windows.Point p)
		{
			return p.X >= 0.0 && p.Y >= 0.0 && p.X < elem.ActualWidth && p.Y < elem.ActualHeight;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00022B9C File Offset: 0x00020D9C
		public static global::System.Windows.Point EnsureInElementBounds(global::System.Windows.Point point, global::System.Windows.FrameworkElement elem)
		{
			point.X = global::Infragistics.Windows.DataPresenter.GridUtilities.EnsureInRange(point.X, 0.0, elem.ActualWidth);
			point.Y = global::Infragistics.Windows.DataPresenter.GridUtilities.EnsureInRange(point.Y, 0.0, elem.ActualHeight);
			return point;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00022BEE File Offset: 0x00020DEE
		public static double EnsureInRange(double val, double min, double max)
		{
			return global::System.Math.Min(global::System.Math.Max(val, min), max);
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00022C00 File Offset: 0x00020E00
		public static global::System.Collections.Generic.IEnumerable<T> Filter<T>(global::System.Collections.Generic.IEnumerable<T> items, global::System.Predicate<T> condition)
		{
			global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>();
			if (items != null)
			{
				foreach (T t in items)
				{
					if (condition(t))
					{
						list.Add(t);
					}
				}
			}
			return list;
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00022C5C File Offset: 0x00020E5C
		public static global::System.Collections.Generic.IEnumerable<T> Filter<T>(global::System.Collections.Generic.IEnumerable<T> items, global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria criteria)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<T>(items, criteria, false);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x00022C68 File Offset: 0x00020E68
		public static global::System.Collections.Generic.IEnumerable<T> Filter<T>(global::System.Collections.Generic.IEnumerable<T> items, global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria criteria, bool flatten)
		{
			global::System.Collections.Generic.IEnumerable<T> enumerable = new global::Infragistics.Windows.DataPresenter.GridUtilities.NotifyCollectionEnumerable<T>(items, criteria);
			if (!flatten)
			{
				return enumerable;
			}
			return new global::System.Collections.Generic.List<T>(enumerable);
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00022C88 File Offset: 0x00020E88
		internal static bool FocusTrivialAncestor(global::System.Windows.DependencyObject elem)
		{
			while (elem != null)
			{
				global::System.Windows.IInputElement inputElement = elem as global::System.Windows.IInputElement;
				if (inputElement != null && inputElement.Focusable)
				{
					return inputElement.Focus();
				}
				elem = global::Infragistics.Windows.Utilities.GetParent(elem, false);
			}
			return false;
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00022CBD File Offset: 0x00020EBD
		public static string GetAttribute(global::System.Xml.XmlNode node, string attrib)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.GetAttribute(node, attrib, null);
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00022CC8 File Offset: 0x00020EC8
		public static string GetAttribute(global::System.Xml.XmlNode node, string attrib, string defaultValue)
		{
			global::System.Xml.XmlAttribute xmlAttribute = node.Attributes[attrib];
			if (xmlAttribute == null)
			{
				return null;
			}
			return xmlAttribute.Value;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00022CF0 File Offset: 0x00020EF0
		internal static global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel GetCellPanel(global::Infragistics.Windows.DataPresenter.RecordPresenter rp, bool header)
		{
			if (rp == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel result = null;
			if (header && rp != null && rp.FieldLayout != null && rp.FieldLayout.LabelLocationResolved == global::Infragistics.Windows.DataPresenter.LabelLocation.InCells)
			{
				header = false;
			}
			global::System.Windows.FrameworkElement frameworkElement;
			if (!header)
			{
				global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = rp as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
				if (dataRecordPresenter != null)
				{
					global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel associatedVirtualizingDataRecordCellPanel = dataRecordPresenter.AssociatedVirtualizingDataRecordCellPanel;
					if (associatedVirtualizingDataRecordCellPanel != null)
					{
						return associatedVirtualizingDataRecordCellPanel;
					}
				}
				frameworkElement = rp.GetRecordContentSite();
			}
			else
			{
				frameworkElement = rp.GetHeaderContentSite();
			}
			if (frameworkElement != null)
			{
				result = (global::Infragistics.Windows.Utilities.GetDescendantFromType(frameworkElement, typeof(global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel), true) as global::Infragistics.Windows.DataPresenter.VirtualizingDataRecordCellPanel);
			}
			return result;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00022D6C File Offset: 0x00020F6C
		public static global::System.Collections.Generic.ICollection<TOutput> GetConvertedCollection<TInput, TOutput>(global::System.Collections.IEnumerable items, int itemsCount, global::System.Converter<TInput, TOutput> converter)
		{
			global::System.Collections.Generic.IEnumerable<TInput> e = new global::Infragistics.Collections.TypedEnumerable<TInput>(items);
			global::System.Collections.Generic.IEnumerable<TOutput> enumerable = new global::Infragistics.Windows.DataPresenter.GridUtilities.ConverterEnumerable<TInput, TOutput>(e, converter);
			return new global::Infragistics.Windows.DataPresenter.GridUtilities.EnumeratorCollection<TOutput>(enumerable, itemsCount);
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x00022D90 File Offset: 0x00020F90
		internal static int GetCount(global::System.Collections.IEnumerable e)
		{
			global::System.Collections.ICollection collection = e as global::System.Collections.ICollection;
			if (collection != null)
			{
				return collection.Count;
			}
			return global::Infragistics.Windows.DataPresenter.GridUtilities.GetCountNonOptimized(e);
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x00022DB4 File Offset: 0x00020FB4
		internal static int GetCountNonOptimized(global::System.Collections.IEnumerable e)
		{
			int num = 0;
			foreach (object obj in e)
			{
				num++;
			}
			return num;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00022E04 File Offset: 0x00021004
		internal static int GetCount(object[] arr, object value)
		{
			int num = 0;
			for (int i = 0; i < arr.Length; i++)
			{
				if (value == arr[i])
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x00022E2C File Offset: 0x0002102C
		internal static int GetSyncLockedCount(global::System.Collections.ArrayList list)
		{
			int count;
			lock (list.SyncRoot)
			{
				count = list.Count;
			}
			return count;
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00022E70 File Offset: 0x00021070
		internal static global::Infragistics.Windows.DataPresenter.DataPresenterBase GetDataPresenter(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records)
		{
			if (records == null)
			{
				return null;
			}
			return global::Infragistics.Windows.DataPresenter.GridUtilities.GetDataPresenter(records.FieldLayout);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00022E82 File Offset: 0x00021082
		internal static global::Infragistics.Windows.DataPresenter.DataPresenterBase GetDataPresenter(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			if (fl == null)
			{
				return null;
			}
			return fl.DataPresenter;
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00022E8F File Offset: 0x0002108F
		internal static global::System.Globalization.CultureInfo GetDefaultCulture(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
		{
			if (dp == null)
			{
				return null;
			}
			return dp.DefaultConverterCulture;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00022E9C File Offset: 0x0002109C
		internal static global::System.Globalization.CultureInfo GetDefaultCulture(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.GetDefaultCulture((fl != null) ? fl.DataPresenter : null);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00022EAF File Offset: 0x000210AF
		internal static global::System.Globalization.CultureInfo GetDefaultCulture(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null)
			{
				return null;
			}
			return field.ConverterCultureResolved;
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00022EBC File Offset: 0x000210BC
		internal static global::System.Globalization.CultureInfo GetDefaultCulture(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			if (field == null)
			{
				return global::Infragistics.Windows.DataPresenter.GridUtilities.GetDefaultCulture(fl);
			}
			return global::Infragistics.Windows.DataPresenter.GridUtilities.GetDefaultCulture(field);
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x00022ECE File Offset: 0x000210CE
		public static global::System.Collections.IEnumerable GetEmptyEnumerable()
		{
			return new global::Infragistics.Windows.DataPresenter.GridUtilities.EmptyEnumerable<object>();
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00022ED5 File Offset: 0x000210D5
		public static global::Infragistics.Windows.DataPresenter.FieldCollection GetFields(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			if (fieldLayout == null)
			{
				return null;
			}
			return fieldLayout.FieldsIfAllocated;
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00022EE2 File Offset: 0x000210E2
		public static global::Infragistics.Windows.DataPresenter.Field GetField(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, string fieldName, bool throwException)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.GetField(global::Infragistics.Windows.DataPresenter.GridUtilities.GetFields(fieldLayout), fieldName, throwException);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x00022EF4 File Offset: 0x000210F4
		public static global::Infragistics.Windows.DataPresenter.Field GetField(global::Infragistics.Windows.DataPresenter.FieldCollection fields, string fieldName, bool throwException)
		{
			int num = (fields != null) ? fields.IndexOf(fieldName) : -1;
			global::Infragistics.Windows.DataPresenter.Field field = (num >= 0) ? fields[num] : null;
			if (throwException && field == null)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_MissingField", new object[]
				{
					fieldName
				}), "fieldName");
			}
			return field;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00022F48 File Offset: 0x00021148
		internal static global::Infragistics.Windows.DataPresenter.Field GetFieldFromControl(global::System.Windows.UIElement ctrl)
		{
			global::Infragistics.Windows.DataPresenter.DataItemPresenter dataItemPresenter = ctrl as global::Infragistics.Windows.DataPresenter.DataItemPresenter;
			if (dataItemPresenter != null)
			{
				return dataItemPresenter.Field;
			}
			global::Infragistics.Windows.DataPresenter.CellPresenterBase cellPresenterBase = ctrl as global::Infragistics.Windows.DataPresenter.CellPresenterBase;
			if (cellPresenterBase != null)
			{
				return cellPresenterBase.Field;
			}
			global::Infragistics.Windows.DataPresenter.Field field = ctrl.GetValue(global::Infragistics.Windows.DataPresenter.DataItemPresenter.FieldProperty) as global::Infragistics.Windows.DataPresenter.Field;
			if (field == null)
			{
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor = global::System.ComponentModel.TypeDescriptor.GetProperties(ctrl)["Field"];
				if (propertyDescriptor != null)
				{
					field = (propertyDescriptor.GetValue(ctrl) as global::Infragistics.Windows.DataPresenter.Field);
				}
			}
			return field;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00022FAD File Offset: 0x000211AD
		public static global::Infragistics.Windows.DataPresenter.FieldLayout GetFieldLayout(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null)
			{
				return null;
			}
			return field.Owner;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00022FBC File Offset: 0x000211BC
		public static global::Infragistics.Windows.DataPresenter.FieldLayout GetFieldLayout(global::Infragistics.Windows.DataPresenter.Record recordContext, global::Infragistics.Windows.DataPresenter.Field fieldContext, global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordsContext, global::Infragistics.Windows.DataPresenter.RecordManager recordManagerContext)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = null;
			if (fieldLayout == null && recordContext != null)
			{
				fieldLayout = recordContext.FieldLayout;
			}
			if (fieldLayout == null && fieldContext != null)
			{
				fieldLayout = fieldContext.Owner;
			}
			if (fieldLayout == null && recordContext != null)
			{
				fieldLayout = recordContext.FieldLayout;
			}
			if (fieldLayout == null && recordManagerContext != null)
			{
				fieldLayout = recordManagerContext.FieldLayout;
			}
			return fieldLayout;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00023000 File Offset: 0x00021200
		public static global::Infragistics.Windows.DataPresenter.FieldLayout GetFieldLayout(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			if (item is global::Infragistics.Windows.DataPresenter.Field)
			{
				return ((global::Infragistics.Windows.DataPresenter.Field)item).Owner;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Cell)
			{
				return ((global::Infragistics.Windows.DataPresenter.Cell)item).Field.Owner;
			}
			if (item is global::Infragistics.Windows.DataPresenter.Record)
			{
				return ((global::Infragistics.Windows.DataPresenter.Record)item).FieldLayout;
			}
			return null;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00023050 File Offset: 0x00021250
		internal static global::Infragistics.Windows.DataPresenter.RecordManager GetFieldRecordManager(global::System.Windows.FrameworkElement element, global::Infragistics.Windows.DataPresenter.Field field, bool canAssumeRootManager)
		{
			if (element == null || field == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			if (owner == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = global::Infragistics.Windows.DataPresenter.HeaderPresenter.GetRecordManager(element);
			if (recordManager != null)
			{
				return recordManager;
			}
			global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = element as global::Infragistics.Windows.DataPresenter.RecordPresenter;
			if (recordPresenter == null)
			{
				recordPresenter = (global::Infragistics.Windows.Utilities.GetAncestorFromType(element, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true) as global::Infragistics.Windows.DataPresenter.RecordPresenter);
			}
			if (recordPresenter != null)
			{
				return global::Infragistics.Windows.DataPresenter.GridUtilities.GetRPRecordManager(recordPresenter, owner, canAssumeRootManager);
			}
			return global::Infragistics.Windows.DataPresenter.GridUtilities.GetElementRecordManager(element, owner, canAssumeRootManager);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x000230B4 File Offset: 0x000212B4
		internal static global::Infragistics.Windows.DataPresenter.RecordManager GetRPRecordManager(global::Infragistics.Windows.DataPresenter.RecordPresenter rp, global::Infragistics.Windows.DataPresenter.FieldLayout fl, bool canAssumeRootManager)
		{
			if (rp == null || fl == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = fl.DataPresenter;
			if (dataPresenter == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = rp.Record as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (dataRecord != null && dataRecord.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.DataRecord)
			{
				return dataRecord.RecordManager;
			}
			global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord = rp.Record as global::Infragistics.Windows.DataPresenter.HeaderRecord;
			if (headerRecord == null)
			{
				if (!dataPresenter.IsFlatView && dataPresenter.CurrentViewInternal is global::Infragistics.Windows.DataPresenter.GridView)
				{
					global::Infragistics.Windows.DataPresenter.GridViewPanelAdorner gridViewPanelAdorner = global::Infragistics.Windows.Utilities.GetAncestorFromType(rp, typeof(global::Infragistics.Windows.DataPresenter.GridViewPanelAdorner), true, dataPresenter) as global::Infragistics.Windows.DataPresenter.GridViewPanelAdorner;
					if (gridViewPanelAdorner != null && gridViewPanelAdorner.GridViewPanel != null)
					{
						return global::Infragistics.Windows.DataPresenter.GridUtilities.GetElementRecordManager(gridViewPanelAdorner.GridViewPanel, fl, canAssumeRootManager);
					}
				}
				return global::Infragistics.Windows.DataPresenter.GridUtilities.GetElementRecordManager(rp, fl, canAssumeRootManager);
			}
			global::Infragistics.Windows.DataPresenter.Record attachedToRecord = headerRecord.AttachedToRecord;
			if (attachedToRecord == null)
			{
				return dataPresenter.RecordManager;
			}
			global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = attachedToRecord as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
			if (expandableFieldRecord != null)
			{
				return expandableFieldRecord.ChildRecordManagerIfNeeded;
			}
			return attachedToRecord.ParentCollection.ParentRecordManager;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00023188 File Offset: 0x00021388
		internal static global::Infragistics.Windows.DataPresenter.RecordManager GetElementRecordManager(global::System.Windows.FrameworkElement element, global::Infragistics.Windows.DataPresenter.FieldLayout fl, bool canAssumeRootManager)
		{
			if (element == null || fl == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = fl.DataPresenter;
			if (dataPresenter == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = global::Infragistics.Windows.Utilities.GetAncestorFromType(element, typeof(global::Infragistics.Windows.DataPresenter.RecordListControl), true) as global::Infragistics.Windows.DataPresenter.RecordListControl;
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager;
			if (recordListControl == null)
			{
				if (!canAssumeRootManager)
				{
					return null;
				}
				recordManager = dataPresenter.RecordManager;
				if (recordManager == null || !recordManager.ContainsFieldLayout(fl))
				{
					return null;
				}
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = recordListControl.ViewableRecords;
				if (viewableRecords == null)
				{
					return null;
				}
				recordManager = viewableRecords.RecordManager;
			}
			return recordManager;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x000231F4 File Offset: 0x000213F4
		internal static T GetFirstItem<T>(global::System.Collections.Generic.IEnumerable<T> e)
		{
			if (e != null)
			{
				global::System.Collections.Generic.IList<T> list = e as global::System.Collections.Generic.IList<T>;
				if (list != null)
				{
					if (list.Count > 0)
					{
						return list[0];
					}
				}
				else
				{
					using (global::System.Collections.Generic.IEnumerator<T> enumerator = e.GetEnumerator())
					{
						if (enumerator.MoveNext())
						{
							return enumerator.Current;
						}
					}
				}
			}
			return default(T);
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00023264 File Offset: 0x00021464
		internal static global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal GetFixedRecordLocation(bool top, bool isFixed)
		{
			if (!isFixed)
			{
				return global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.None;
			}
			if (!top)
			{
				return global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Bottom;
			}
			return global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Top;
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x00023274 File Offset: 0x00021474
		public static global::System.Windows.Rect GetElemRect(global::System.Windows.FrameworkElement ancestor, global::System.Windows.FrameworkElement elem)
		{
			global::System.Windows.Rect result = new global::System.Windows.Rect(elem.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), ancestor), elem.RenderSize);
			return result;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x000232B0 File Offset: 0x000214B0
		internal static global::Infragistics.Windows.Controls.ExpansionIndicator GetExpansionIndicator(global::Infragistics.Windows.DataPresenter.RecordPresenter rp)
		{
			return global::Infragistics.Windows.Utilities.GetTemplateChild<global::Infragistics.Windows.Controls.ExpansionIndicator>(rp);
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x000232C8 File Offset: 0x000214C8
		internal static global::System.Windows.DependencyObject GetImmediateDescendant(global::System.Windows.DependencyObject descendant, global::System.Windows.DependencyObject ancestor)
		{
			while (descendant is global::System.Windows.ContentElement)
			{
				descendant = global::System.Windows.LogicalTreeHelper.GetParent(descendant);
			}
			while (descendant != null)
			{
				global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(descendant);
				if (parent == ancestor)
				{
					return descendant;
				}
				descendant = parent;
			}
			return null;
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x000232FD File Offset: 0x000214FD
		internal static double GetNonPrimaryExtent(global::System.Windows.Size size, bool isVerticalOrientation)
		{
			if (isVerticalOrientation)
			{
				return size.Width;
			}
			return size.Height;
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00023314 File Offset: 0x00021514
		public static object GetOneAndOnlyOneItem(global::System.Collections.IEnumerable e)
		{
			object obj = null;
			foreach (object obj2 in e)
			{
				if (obj != null)
				{
					return null;
				}
				obj = obj2;
			}
			return obj;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00023370 File Offset: 0x00021570
		internal static double GetPrimaryExtent(global::System.Windows.Size size, bool isVerticalOrientation)
		{
			if (isVerticalOrientation)
			{
				return size.Height;
			}
			return size.Width;
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00023384 File Offset: 0x00021584
		internal static global::Infragistics.Windows.DataPresenter.RecordType? GetRecordTypeFromType(global::System.Type type)
		{
			if (typeof(global::Infragistics.Windows.DataPresenter.FilterRecord).IsAssignableFrom(type))
			{
				return new global::Infragistics.Windows.DataPresenter.RecordType?(global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord);
			}
			if (typeof(global::Infragistics.Windows.DataPresenter.DataRecord).IsAssignableFrom(type))
			{
				return new global::Infragistics.Windows.DataPresenter.RecordType?(global::Infragistics.Windows.DataPresenter.RecordType.DataRecord);
			}
			if (typeof(global::Infragistics.Windows.DataPresenter.GroupByRecord).IsAssignableFrom(type))
			{
				return new global::Infragistics.Windows.DataPresenter.RecordType?(global::Infragistics.Windows.DataPresenter.RecordType.GroupByField);
			}
			if (typeof(global::Infragistics.Windows.DataPresenter.SummaryRecord).IsAssignableFrom(type))
			{
				return new global::Infragistics.Windows.DataPresenter.RecordType?(global::Infragistics.Windows.DataPresenter.RecordType.SummaryRecord);
			}
			if (typeof(global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord).IsAssignableFrom(type))
			{
				return new global::Infragistics.Windows.DataPresenter.RecordType?(global::Infragistics.Windows.DataPresenter.RecordType.ExpandableFieldRecord);
			}
			return null;
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00023418 File Offset: 0x00021618
		internal static void GetRelativeLabelPlacement(global::Infragistics.Windows.DataPresenter.CellContentAlignment contentAlignment, out bool isLabelAboveOrBelow, out bool isLabelLeftOrRight)
		{
			isLabelAboveOrBelow = false;
			isLabelLeftOrRight = false;
			switch (contentAlignment)
			{
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignLeft:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignCenter:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueAlignRight:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelAboveValueStretch:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignLeft:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignCenter:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueAlignRight:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelBelowValueStretch:
				isLabelAboveOrBelow = true;
				return;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueAlignTop:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueAlignMiddle:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueAlignBottom:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelLeftOfValueStretch:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueAlignTop:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueAlignMiddle:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueAlignBottom:
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelRightOfValueStretch:
				isLabelLeftOrRight = true;
				return;
			default:
				return;
			}
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00023480 File Offset: 0x00021680
		public static global::System.Windows.DependencyObject GetTrivialDescendantOfType(global::System.Windows.DependencyObject ancestor, global::System.Type type, bool allowSubtypes)
		{
			foreach (object obj in global::Infragistics.Windows.DataPresenter.GridUtilities.GetTrivialDescendants(ancestor))
			{
				global::System.Windows.DependencyObject dependencyObject = (global::System.Windows.DependencyObject)obj;
				if (allowSubtypes ? global::Infragistics.Windows.DataPresenter.GridUtilities.IsObjectOfType(dependencyObject, type) : (type == dependencyObject.GetType()))
				{
					return dependencyObject;
				}
			}
			return null;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x000234F4 File Offset: 0x000216F4
		public static global::System.Collections.IEnumerable GetTrivialDescendants(global::System.Windows.DependencyObject elem)
		{
			global::System.Collections.Specialized.OrderedDictionary orderedDictionary = new global::System.Collections.Specialized.OrderedDictionary();
			orderedDictionary.Add(elem, elem);
			global::Infragistics.Windows.DataPresenter.GridUtilities.GetDescendantsHelper(elem, orderedDictionary);
			return orderedDictionary.Keys;
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x0002351C File Offset: 0x0002171C
		private static void GetDescendantsHelper(global::System.Windows.DependencyObject elem, global::System.Collections.Specialized.OrderedDictionary orderedTable)
		{
			if (elem != null)
			{
				int count = orderedTable.Count;
				if (elem is global::System.Windows.Media.Visual || elem is global::System.Windows.Media.Media3D.Visual3D)
				{
					int childrenCount = global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(elem);
					for (int i = 0; i < childrenCount; i++)
					{
						global::System.Windows.DependencyObject child = global::System.Windows.Media.VisualTreeHelper.GetChild(elem, i);
						if (child != null && !orderedTable.Contains(child))
						{
							orderedTable.Add(child, child);
						}
					}
				}
				foreach (object obj in global::System.Windows.LogicalTreeHelper.GetChildren(elem))
				{
					global::System.Windows.DependencyObject dependencyObject = obj as global::System.Windows.DependencyObject;
					if (dependencyObject != null && !orderedTable.Contains(dependencyObject))
					{
						orderedTable.Add(dependencyObject, dependencyObject);
					}
				}
				int j = count;
				int count2 = orderedTable.Count;
				while (j < count2)
				{
					global::Infragistics.Windows.DataPresenter.GridUtilities.GetDescendantsHelper((global::System.Windows.DependencyObject)orderedTable[j], orderedTable);
					j++;
				}
			}
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x0002360C File Offset: 0x0002180C
		public static global::System.Collections.IEnumerable GetTrivialDescendantsOfType(global::System.Windows.DependencyObject ancestor, global::System.Type type, bool allowSubtypes)
		{
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			foreach (object obj in global::Infragistics.Windows.DataPresenter.GridUtilities.GetTrivialDescendants(ancestor))
			{
				global::System.Windows.DependencyObject dependencyObject = (global::System.Windows.DependencyObject)obj;
				if (allowSubtypes ? global::Infragistics.Windows.DataPresenter.GridUtilities.IsObjectOfType(dependencyObject, type) : (type == dependencyObject.GetType()))
				{
					arrayList.Add(dependencyObject);
				}
			}
			return arrayList;
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00023688 File Offset: 0x00021888
		public static global::System.Windows.Rect GetUnionRect(global::System.Windows.FrameworkElement ancestor, global::System.Collections.IEnumerable frameworkElems)
		{
			global::System.Windows.Rect result = default(global::System.Windows.Rect);
			foreach (object obj in frameworkElems)
			{
				global::System.Windows.FrameworkElement elem = (global::System.Windows.FrameworkElement)obj;
				result.Union(global::Infragistics.Windows.DataPresenter.GridUtilities.GetElemRect(ancestor, elem));
			}
			return result;
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x000236EC File Offset: 0x000218EC
		internal static string GetValidationErrorText(global::System.Windows.Controls.ValidationError error)
		{
			string defaultString = (error.Exception != null) ? error.Exception.Message : null;
			return global::Infragistics.Windows.DataPresenter.GridUtilities.ToString(error.ErrorContent, defaultString);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0002371C File Offset: 0x0002191C
		internal static string GetValidationErrorText(global::System.Collections.Generic.IList<global::System.Windows.Controls.ValidationError> errors)
		{
			int count = errors.Count;
			if (count <= 0)
			{
				return null;
			}
			if (1 == count)
			{
				return global::Infragistics.Windows.DataPresenter.GridUtilities.GetValidationErrorText(errors[0]);
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = 0; i < count; i++)
			{
				string validationErrorText = global::Infragistics.Windows.DataPresenter.GridUtilities.GetValidationErrorText(errors[i]);
				if (!string.IsNullOrEmpty(validationErrorText))
				{
					if (stringBuilder.Length > 0)
					{
						stringBuilder.AppendLine();
					}
					stringBuilder.Append(validationErrorText);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0002378C File Offset: 0x0002198C
		internal static global::Infragistics.Windows.DataPresenter.ViewBase GetView(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null)
			{
				return null;
			}
			return global::Infragistics.Windows.DataPresenter.GridUtilities.GetView(field.Owner);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x000237A0 File Offset: 0x000219A0
		internal static global::Infragistics.Windows.DataPresenter.ViewBase GetView(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (fieldLayout != null) ? fieldLayout.DataPresenter : null;
			if (dataPresenterBase == null)
			{
				return null;
			}
			return dataPresenterBase.CurrentViewInternal;
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x000237C8 File Offset: 0x000219C8
		public static bool HasItems(global::System.Collections.IEnumerable e)
		{
			if (e != null)
			{
				if (e is global::System.Collections.ICollection)
				{
					return ((global::System.Collections.ICollection)e).Count > 0;
				}
				using (global::System.Collections.IEnumerator enumerator = e.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						return true;
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00023834 File Offset: 0x00021A34
		internal static global::Infragistics.Windows.Helpers.HashSet ToSet(global::System.Collections.IEnumerable items)
		{
			global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet();
			hashSet.AddItems(items);
			return hashSet;
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0002384F File Offset: 0x00021A4F
		internal static bool HasSameItems(global::System.Collections.IEnumerable set1, global::System.Collections.IEnumerable set2)
		{
			return global::Infragistics.Windows.Helpers.HashSet.AreEqual(global::Infragistics.Windows.DataPresenter.GridUtilities.ToSet(set1), global::Infragistics.Windows.DataPresenter.GridUtilities.ToSet(set2));
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00023862 File Offset: 0x00021A62
		internal static bool IncludesFixedButton(global::Infragistics.Windows.DataPresenter.FixedFieldUIType type)
		{
			return type == global::Infragistics.Windows.DataPresenter.FixedFieldUIType.ButtonAndSplitter || type == global::Infragistics.Windows.DataPresenter.FixedFieldUIType.Button;
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00023870 File Offset: 0x00021A70
		internal static int IndexOfReferenceComparison(global::System.Collections.IList list, object obj)
		{
			int i = 0;
			int count = list.Count;
			while (i < count)
			{
				if (object.ReferenceEquals(obj, list[i]))
				{
					return i;
				}
				i++;
			}
			return -1;
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x000238A4 File Offset: 0x00021AA4
		internal static bool IsAddRecordTemplate(global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = record as global::Infragistics.Windows.DataPresenter.DataRecord;
			return dataRecord != null && dataRecord.IsAddRecordTemplate;
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x000238C4 File Offset: 0x00021AC4
		internal static bool IsLabelAboveBelowCell(global::Infragistics.Windows.DataPresenter.CellContentAlignment alignment)
		{
			bool result;
			bool flag;
			global::Infragistics.Windows.DataPresenter.GridUtilities.GetRelativeLabelPlacement(alignment, out result, out flag);
			return result;
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x000238DC File Offset: 0x00021ADC
		internal static bool IsLabelLeftRightCell(global::Infragistics.Windows.DataPresenter.CellContentAlignment alignment)
		{
			bool flag;
			bool result;
			global::Infragistics.Windows.DataPresenter.GridUtilities.GetRelativeLabelPlacement(alignment, out flag, out result);
			return result;
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x000238F4 File Offset: 0x00021AF4
		internal static bool IsFixed(global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal fixedLocation)
		{
			return global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Top == fixedLocation || global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Bottom == fixedLocation;
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00023900 File Offset: 0x00021B00
		public static bool IsNullOrEmpty(object value)
		{
			if (value == null || global::System.DBNull.Value == value)
			{
				return true;
			}
			string text = value as string;
			return text != null && text.Length == 0;
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0002392F File Offset: 0x00021B2F
		internal static bool IsObjectOfType(object obj, global::System.Type type)
		{
			return obj != null && global::Infragistics.Windows.DataPresenter.GridUtilities.IsObjectOfType(obj.GetType(), type);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00023942 File Offset: 0x00021B42
		internal static bool IsObjectOfType(global::System.Type objectType, global::System.Type typeToCheck)
		{
			return objectType == typeToCheck || typeToCheck.IsAssignableFrom(objectType);
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00023958 File Offset: 0x00021B58
		internal static bool IsObjectOfType(global::System.Type objectType, global::System.Type[] typesToCheck)
		{
			for (int i = 0; i < typesToCheck.Length; i++)
			{
				if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsObjectOfType(objectType, typesToCheck[i]))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00023984 File Offset: 0x00021B84
		internal static bool IsObjectOfType(object obj, global::System.Type[] typesToCheck)
		{
			for (int i = 0; i < typesToCheck.Length; i++)
			{
				if (global::Infragistics.Windows.DataPresenter.GridUtilities.IsObjectOfType(obj, typesToCheck[i]))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x000239AD File Offset: 0x00021BAD
		internal static bool IsRecordOfType(global::Infragistics.Windows.DataPresenter.Record rcd, global::Infragistics.Windows.DataPresenter.RecordType rcdType)
		{
			return rcd != null && rcd.RecordType == rcdType && rcd.IsEnabledResolved && (rcdType != global::Infragistics.Windows.DataPresenter.RecordType.DataRecord || !((global::Infragistics.Windows.DataPresenter.DataRecord)rcd).IsAddRecordTemplate);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000239DC File Offset: 0x00021BDC
		internal static bool IsRecordOfType(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.RecordType? rcdType, global::System.Type fallbackType)
		{
			if (rcdType != null)
			{
				return global::Infragistics.Windows.DataPresenter.GridUtilities.IsRecordOfType(record, rcdType.Value);
			}
			return record != null && fallbackType.IsAssignableFrom(record.GetType());
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00023A08 File Offset: 0x00021C08
		internal static bool IsSameSortCriteria(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldSortDescription> x, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldSortDescription> y)
		{
			if (x.Count != y.Count)
			{
				return false;
			}
			int i = 0;
			int count = x.Count;
			while (i < count)
			{
				if (!global::Infragistics.Windows.DataPresenter.FieldSortDescription.AreEqual(x[i], y[i]))
				{
					return false;
				}
				i++;
			}
			return true;
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00023A50 File Offset: 0x00021C50
		internal static bool IsSerializable(object value)
		{
			return value != null && value.GetType().IsSerializable;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00023A68 File Offset: 0x00021C68
		internal static bool IsTemplateRecords(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (records != null) ? records.FieldLayout : null;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (fieldLayout != null) ? fieldLayout.DataPresenter : null;
			global::Infragistics.Windows.DataPresenter.FieldLayoutCollection fieldLayoutCollection = (dataPresenterBase != null) ? dataPresenterBase.FieldLayoutsIfAllocated : null;
			if (fieldLayoutCollection != null)
			{
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase templateDataRecords = fieldLayoutCollection.TemplateDataRecords;
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase templateGroupByRecords = fieldLayoutCollection.TemplateGroupByRecords;
				return records == templateDataRecords || records == templateGroupByRecords || global::Infragistics.Windows.DataPresenter.GridUtilities.IsTrivialDescendantOf(templateDataRecords, records) || global::Infragistics.Windows.DataPresenter.GridUtilities.IsTrivialDescendantOf(templateGroupByRecords, records);
			}
			return false;
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00023AD0 File Offset: 0x00021CD0
		internal static bool IsTrivialDescendantOf(global::Infragistics.Windows.DataPresenter.RecordCollectionBase ancestor, global::Infragistics.Windows.DataPresenter.RecordCollectionBase descendant)
		{
			if (ancestor == descendant)
			{
				return true;
			}
			global::Infragistics.Windows.DataPresenter.Record record = (descendant != null) ? descendant.ParentRecord : null;
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase descendant2 = (record != null) ? record.ParentCollection : null;
			return record != null && global::Infragistics.Windows.DataPresenter.GridUtilities.IsTrivialDescendantOf(ancestor, descendant2);
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00023B0C File Offset: 0x00021D0C
		internal static bool IsVariableHeightRecordMode(global::Infragistics.Windows.DataPresenter.DataRecordSizingMode mode)
		{
			switch (mode)
			{
			case global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.Fixed:
			case global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.SizableSynchronized:
				return false;
			case global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.IndividuallySizable:
			case global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.SizedToContentAndFixed:
			case global::Infragistics.Windows.DataPresenter.DataRecordSizingMode.SizedToContentAndIndividuallySizable:
				return true;
			default:
				return false;
			}
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00023B3E File Offset: 0x00021D3E
		internal static bool IsXmlNodeOptimized(object item)
		{
			return item != null && (global::Infragistics.Windows.DataPresenter.GridUtilities.s_isXmlAssemblyLoaded || item.GetType().FullName.StartsWith("System.Xml", global::System.StringComparison.Ordinal)) && global::Infragistics.Windows.DataPresenter.GridUtilities.IsXmlModeInternal(item);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00023B6C File Offset: 0x00021D6C
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static bool IsXmlModeInternal(object item)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.s_isXmlAssemblyLoaded = true;
			return item is global::System.Xml.XmlNode;
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00023B7D File Offset: 0x00021D7D
		internal static void LogDebuggerError(string errorMsg)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.LogDebuggerError("Global", errorMsg);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00023B8A File Offset: 0x00021D8A
		internal static void LogDebuggerError(string category, string errorMsg)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.LogDebuggerErrorHelper(category, errorMsg, 50);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00023B95 File Offset: 0x00021D95
		internal static void LogDebuggerWarning(string errorMsg)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.LogDebuggerWarning("Global", errorMsg);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00023BA2 File Offset: 0x00021DA2
		internal static void LogDebuggerWarning(string category, string errorMsg)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.LogDebuggerErrorHelper(category, errorMsg, 40);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00023BAD File Offset: 0x00021DAD
		private static void LogDebuggerErrorHelper(string category, string errorMsg, int level)
		{
			if (global::System.Diagnostics.Debugger.IsAttached && global::System.Diagnostics.Debugger.IsLogging())
			{
				global::System.Diagnostics.Debugger.Log(level, category, errorMsg);
			}
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00023BC8 File Offset: 0x00021DC8
		internal static bool MoveFixedRecords(global::Infragistics.Windows.DataPresenter.Record[] records)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
			int num = 0;
			for (int i = 0; i < records.Length; i++)
			{
				global::Infragistics.Windows.DataPresenter.Record record = records[i];
				global::Infragistics.Windows.DataPresenter.FixedRecordLocation fixedLocation = record.FixedLocation;
				if (fixedLocation != global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable)
				{
					if (fixedLocation == global::Infragistics.Windows.DataPresenter.FixedRecordLocation.FixedToTop)
					{
						list.Add(record);
					}
					else
					{
						list2.Add(record);
					}
					records[i] = null;
					num++;
				}
				else if (num != 0)
				{
					records[i - num] = record;
				}
			}
			if (num > 0)
			{
				global::System.Array.Copy(records, 0, records, list.Count, records.Length - list.Count - list2.Count);
				for (int j = 0; j < list.Count; j++)
				{
					records[j] = list[j];
				}
				for (int k = 0; k < list2.Count; k++)
				{
					records[records.Length - list2.Count + k] = list2[k];
				}
			}
			return num > 0;
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00023CA4 File Offset: 0x00021EA4
		internal static void NotifyCalcAdapter(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp, object sender, string propName, object extraInfo)
		{
			if (dp != null)
			{
				global::Infragistics.Windows.DataPresenter.Calculations.IDataPresenterCalculationAdapterInternal calculationAdapter = dp._calculationAdapter;
				if (calculationAdapter != null)
				{
					calculationAdapter.OnPropertyValueChanged(sender, propName, extraInfo);
				}
			}
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00023CC7 File Offset: 0x00021EC7
		internal static void SuppressBringIntoView(global::System.Type classType)
		{
			global::System.Windows.EventManager.RegisterClassHandler(classType, global::System.Windows.FrameworkElement.RequestBringIntoViewEvent, new global::System.Windows.RequestBringIntoViewEventHandler(global::Infragistics.Windows.DataPresenter.GridUtilities.SuppressBringIntoViewImpl));
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00023CE0 File Offset: 0x00021EE0
		private static void SuppressBringIntoViewImpl(object sender, global::System.Windows.RequestBringIntoViewEventArgs e)
		{
			if (e.OriginalSource == sender && e.TargetRect.IsEmpty)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00023D10 File Offset: 0x00021F10
		internal static T ParseFlaggedEnumFromString<T>(string enumValues, string seperator)
		{
			string[] array = (!string.IsNullOrEmpty(enumValues)) ? enumValues.Split(new string[]
			{
				seperator
			}, global::System.StringSplitOptions.RemoveEmptyEntries) : null;
			long num = 0L;
			if (array != null)
			{
				foreach (string value in array)
				{
					try
					{
						T t = (T)((object)global::System.Enum.Parse(typeof(T), value));
						long num2 = global::System.Convert.ToInt64(t);
						num |= num2;
					}
					catch
					{
					}
				}
			}
			return (T)((object)global::System.Enum.ToObject(typeof(T), num));
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x00023DB4 File Offset: 0x00021FB4
		internal static void RaiseKeyNotFound()
		{
			throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_14"));
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00023DC8 File Offset: 0x00021FC8
		internal static T[] RemoveAll<T>(T[] arr, T val)
		{
			global::System.Collections.Generic.EqualityComparer<T> @default = global::System.Collections.Generic.EqualityComparer<T>.Default;
			global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>();
			foreach (T t in arr)
			{
				if (!@default.Equals(t, val))
				{
					list.Add(t);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00023E10 File Offset: 0x00022010
		public static global::System.Collections.Generic.Dictionary<V, K> ReverseDictionary<K, V>(global::System.Collections.Generic.Dictionary<K, V> map)
		{
			global::System.Collections.Generic.Dictionary<V, K> dictionary = new global::System.Collections.Generic.Dictionary<V, K>();
			foreach (global::System.Collections.Generic.KeyValuePair<K, V> keyValuePair in map)
			{
				dictionary[keyValuePair.Value] = keyValuePair.Key;
			}
			return dictionary;
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x00023E74 File Offset: 0x00022074
		internal static void SetValue(bool[] arr, int startIndex, int count, bool value)
		{
			for (int i = 0; i < count; i++)
			{
				arr[startIndex + i] = value;
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00023E94 File Offset: 0x00022094
		internal static bool SetIsTextSearchEnabled(global::Infragistics.Windows.Editors.XamComboEditor comboEditor, global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator)
		{
			if (comboEditor == null)
			{
				return false;
			}
			global::System.Windows.Controls.ComboBox comboBox = comboEditor.ComboBox;
			if (comboBox == null)
			{
				return false;
			}
			switch (comparisonOperator)
			{
			case global::Infragistics.Windows.Controls.ComparisonOperator.Equals:
			case global::Infragistics.Windows.Controls.ComparisonOperator.NotEquals:
				comboBox.IsTextSearchEnabled = true;
				break;
			default:
				comboBox.IsTextSearchEnabled = false;
				break;
			}
			return true;
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x00023ED8 File Offset: 0x000220D8
		internal static bool ShouldSerialize(global::System.Windows.DependencyObject d)
		{
			global::System.Windows.LocalValueEnumerator localValueEnumerator = d.GetLocalValueEnumerator();
			while (localValueEnumerator.MoveNext())
			{
				global::System.Windows.LocalValueEntry localValueEntry = localValueEnumerator.Current;
				if (!object.Equals(localValueEntry.Property.DefaultMetadata.DefaultValue, localValueEntry.Value))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00023F24 File Offset: 0x00022124
		internal static void Swap(object[] arr, int i, int j)
		{
			object obj = arr[i];
			arr[i] = arr[j];
			arr[j] = obj;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00023F40 File Offset: 0x00022140
		internal static void Swap(long[] arr, int i, int j)
		{
			long num = arr[i];
			arr[i] = arr[j];
			arr[j] = num;
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00023F5C File Offset: 0x0002215C
		internal static void Swap(global::Infragistics.Collections.SparseArray arr, int i, int j)
		{
			object value = arr[i];
			arr[i] = arr[j];
			arr[j] = value;
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00023F88 File Offset: 0x00022188
		internal static void SwapValues(ref int x, ref int y)
		{
			int num = x;
			x = y;
			y = num;
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00023FA0 File Offset: 0x000221A0
		public static T[] ToArray<T>(global::System.Collections.IEnumerable items)
		{
			global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>();
			foreach (object obj in items)
			{
				T item = (T)((object)obj);
				list.Add(item);
			}
			return list.ToArray();
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00024000 File Offset: 0x00022200
		public static T[] ToArray<T>(params global::System.Collections.Generic.IEnumerable<T>[] enumerables)
		{
			global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>();
			foreach (object obj in new global::Infragistics.Windows.DataPresenter.GridUtilities.AggregateEnumerable<T>(enumerables))
			{
				T item = (T)((object)obj);
				list.Add(item);
			}
			return list.ToArray();
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00024068 File Offset: 0x00022268
		public static T[] ToArray<T>(global::System.Collections.Generic.IList<T> list)
		{
			if (list == null)
			{
				return new T[0];
			}
			T[] array = new T[list.Count];
			list.CopyTo(array, 0);
			return array;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00024094 File Offset: 0x00022294
		public static global::System.Collections.Generic.List<T> ToList<T>(global::System.Collections.Generic.IEnumerable<T> items, bool returnNullIfEmpty)
		{
			global::System.Collections.Generic.List<T> list = returnNullIfEmpty ? null : new global::System.Collections.Generic.List<T>();
			if (items != null)
			{
				foreach (T item in items)
				{
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<T>();
					}
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x000240F8 File Offset: 0x000222F8
		public static global::System.Collections.Generic.List<T> ToList<T>(global::System.Collections.IEnumerable items, bool returnNullIfEmpty)
		{
			global::System.Collections.Generic.List<T> list = returnNullIfEmpty ? null : new global::System.Collections.Generic.List<T>();
			if (items != null)
			{
				foreach (object obj in items)
				{
					T item = (T)((object)obj);
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<T>();
					}
					list.Add(item);
				}
			}
			return list;
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00024168 File Offset: 0x00022368
		internal static string ToString(object obj, string defaultString)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.ToString(obj, defaultString, null);
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00024174 File Offset: 0x00022374
		internal static string ToString(object obj, string defaultString, global::System.IFormatProvider formatProvider)
		{
			if (obj != null)
			{
				global::System.IFormattable formattable = obj as global::System.IFormattable;
				string text;
				if (formattable != null)
				{
					text = formattable.ToString(null, formatProvider);
				}
				else
				{
					text = obj.ToString();
				}
				if (!string.IsNullOrEmpty(text))
				{
					string b = obj.GetType().ToString();
					if (text != b)
					{
						return text;
					}
				}
			}
			return defaultString;
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x000241C0 File Offset: 0x000223C0
		internal static string ToStringFromFlaggedEnum(global::System.Enum enumVal, string seperator)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Type type = enumVal.GetType();
			long num = global::System.Convert.ToInt64(enumVal);
			foreach (object value in global::System.Enum.GetValues(type))
			{
				long num2 = global::System.Convert.ToInt64(value);
				if (num2 == (num2 & num))
				{
					string name = global::System.Enum.GetName(type, num2);
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append(seperator);
					}
					stringBuilder.Append(name);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00024268 File Offset: 0x00022468
		internal static global::System.Windows.Rect Union(ref global::System.Windows.Rect rect1, ref global::System.Windows.Rect rect2)
		{
			global::System.Windows.Rect result = global::System.Windows.Rect.Union(rect1, rect2);
			if (global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(rect1.X, rect2.X) && global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(rect1.Width, rect2.Width))
			{
				result.X = rect1.X;
				result.Width = rect1.Width;
			}
			if (global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(rect1.Y, rect2.Y) && global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(rect1.Height, rect2.Height))
			{
				result.Y = rect1.Y;
				result.Height = rect1.Height;
			}
			return result;
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00024308 File Offset: 0x00022508
		private static bool IsEnumFlags(global::System.Type enumType)
		{
			object[] customAttributes = enumType.GetCustomAttributes(typeof(global::System.FlagsAttribute), true);
			return customAttributes != null && customAttributes.Length > 0;
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00024332 File Offset: 0x00022532
		internal static void ValidateEnum(global::System.Type enumType, object enumVal)
		{
			if (!global::System.Enum.IsDefined(enumType, enumVal) && !global::Infragistics.Windows.DataPresenter.GridUtilities.IsEnumFlags(enumType))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException(enumType.Name, (int)enumVal, enumType);
			}
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00024358 File Offset: 0x00022558
		internal static void ValidateEnum(string argumentName, global::System.Type enumType, object enumVal)
		{
			if (!global::System.Enum.IsDefined(enumType, enumVal) && !global::Infragistics.Windows.DataPresenter.GridUtilities.IsEnumFlags(enumType))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException(argumentName, (int)enumVal, enumType);
			}
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x0002437C File Offset: 0x0002257C
		public static void ValidateNonNegative(int val)
		{
			if (val < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ValueCannotBeNegative", new object[]
				{
					val
				}));
			}
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x000243B0 File Offset: 0x000225B0
		public static void ValidateNonNegative(double val)
		{
			if (val < 0.0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ValueCannotBeNegative", new object[]
				{
					val
				}));
			}
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x000243EA File Offset: 0x000225EA
		public static bool ValidateNonNegativeInt(object newValue)
		{
			return !(newValue is int) || (int)newValue >= 0;
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00024400 File Offset: 0x00022600
		public static void ValidateNotNull(object value)
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException();
			}
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x0002440B File Offset: 0x0002260B
		public static void ValidateNotNull(object value, string paramName)
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException(paramName);
			}
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00024418 File Offset: 0x00022618
		public static void ValidatePositive(int val)
		{
			if (val <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ValueMustBePositive", new object[]
				{
					val
				}));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x0002444A File Offset: 0x0002264A
		internal static global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility Antirecursion
		{
			get
			{
				if (global::Infragistics.Windows.DataPresenter.GridUtilities.g_antirecursionUtility == null)
				{
					global::Infragistics.Windows.DataPresenter.GridUtilities.g_antirecursionUtility = new global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility();
				}
				return global::Infragistics.Windows.DataPresenter.GridUtilities.g_antirecursionUtility;
			}
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00024462 File Offset: 0x00022662
		public static global::Infragistics.Windows.DataPresenter.CellContentAlignment GetCellContentAlignment(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.DataPresenter.CellContentAlignment)d.GetValue(global::Infragistics.Windows.DataPresenter.GridUtilities.CellContentAlignmentProperty);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00024474 File Offset: 0x00022674
		private static object OnCoerceCellContentAlignment(global::System.Windows.DependencyObject d, object newValue)
		{
			switch ((global::Infragistics.Windows.DataPresenter.CellContentAlignment)newValue)
			{
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelOnly:
				return global::Infragistics.Windows.DataPresenter.GridUtilities.CellContentAlignmentLabelOnly;
			case global::Infragistics.Windows.DataPresenter.CellContentAlignment.ValueOnly:
				return global::Infragistics.Windows.DataPresenter.GridUtilities.CellContentAlignmentValueOnly;
			default:
				return global::Infragistics.Windows.DataPresenter.GridUtilities.CellContentAlignmentDefault;
			}
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x000244AD File Offset: 0x000226AD
		private static void OnCellContentAlignmentChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x000244BA File Offset: 0x000226BA
		public static global::System.Windows.Visibility GetFieldVisibility(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.Visibility)d.GetValue(global::Infragistics.Windows.DataPresenter.GridUtilities.FieldVisibilityProperty);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x000244CC File Offset: 0x000226CC
		private static object OnCoerceFieldVisibility(global::System.Windows.DependencyObject d, object newValue)
		{
			return global::Infragistics.KnownBoxes.FromValue((global::System.Windows.Visibility)newValue);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x000244D9 File Offset: 0x000226D9
		private static void OnFieldVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x000244E6 File Offset: 0x000226E6
		internal static global::System.Globalization.CultureInfo StringCompareCulture
		{
			get
			{
				return global::System.Globalization.CultureInfo.CurrentCulture;
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x000244F0 File Offset: 0x000226F0
		internal static void InvalidateMeasureAsynch(global::System.Windows.UIElement element)
		{
			if (element == null || !element.IsMeasureValid)
			{
				return;
			}
			if (!element.IsVisible && element.GetValue(global::System.Windows.FrameworkElement.DataContextProperty) == null)
			{
				return;
			}
			if (global::Infragistics.Windows.DataPresenter.DataPresenterBase.ProcessCellInvalidationsSynchronously)
			{
				element.InvalidateMeasure();
				element.InvalidateArrange();
				return;
			}
			if (global::Infragistics.Windows.DataPresenter.GridUtilities._QueuedMeasureInvalidations == null)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities._QueuedMeasureInvalidations = new global::Infragistics.Windows.Helpers.HashSet();
			}
			global::Infragistics.Windows.DataPresenter.GridUtilities._QueuedMeasureInvalidations.Add(element);
			if (global::Infragistics.Windows.DataPresenter.GridUtilities._QueuedMeasureInvalidations.Count == 1)
			{
				element.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.DataBind, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(global::Infragistics.Windows.DataPresenter.GridUtilities.ProcessAsyncInvalidations));
			}
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00024578 File Offset: 0x00022778
		private static void ProcessAsyncInvalidations()
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ProcessAsyncInvalidationsImpl();
			int num = 0;
			while (global::Infragistics.Windows.DataPresenter.GridUtilities._QueuedMeasureInvalidations.Count > 0)
			{
				if (num >= 9)
				{
					global::Infragistics.Windows.DataPresenter.GridUtilities._QueuedMeasureInvalidations.Clear();
					return;
				}
				num++;
				global::Infragistics.Windows.DataPresenter.GridUtilities.ProcessAsyncInvalidationsImpl();
			}
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x000245B8 File Offset: 0x000227B8
		private static void ProcessAsyncInvalidationsImpl()
		{
			int count = global::Infragistics.Windows.DataPresenter.GridUtilities._QueuedMeasureInvalidations.Count;
			global::System.Windows.UIElement uielement = null;
			foreach (object obj in global::Infragistics.Windows.DataPresenter.GridUtilities._QueuedMeasureInvalidations)
			{
				global::System.Windows.UIElement uielement2 = (global::System.Windows.UIElement)obj;
				uielement = uielement2;
				try
				{
					uielement2.InvalidateMeasure();
					uielement2.InvalidateArrange();
				}
				catch (global::System.Exception)
				{
				}
			}
			global::Infragistics.Windows.DataPresenter.GridUtilities._QueuedMeasureInvalidations.Clear();
			if (uielement != null)
			{
				uielement.UpdateLayout();
			}
		}

		// Token: 0x04000336 RID: 822
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Helpers.HashSet _QueuedMeasureInvalidations;

		// Token: 0x04000337 RID: 823
		private static bool s_isXmlAssemblyLoaded = false;

		// Token: 0x04000338 RID: 824
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility g_antirecursionUtility;

		// Token: 0x04000339 RID: 825
		private static readonly object CellContentAlignmentLabelOnly = global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelOnly;

		// Token: 0x0400033A RID: 826
		private static readonly object CellContentAlignmentValueOnly = global::Infragistics.Windows.DataPresenter.CellContentAlignment.ValueOnly;

		// Token: 0x0400033B RID: 827
		private static readonly object CellContentAlignmentDefault = global::Infragistics.Windows.DataPresenter.CellContentAlignment.Default;

		// Token: 0x0400033C RID: 828
		public static readonly global::System.Windows.DependencyProperty CellContentAlignmentProperty = global::System.Windows.DependencyProperty.RegisterAttached("CellContentAlignment", typeof(global::Infragistics.Windows.DataPresenter.CellContentAlignment), typeof(global::Infragistics.Windows.DataPresenter.GridUtilities), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.GridUtilities.CellContentAlignmentDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GridUtilities.OnCellContentAlignmentChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GridUtilities.OnCoerceCellContentAlignment)));

		// Token: 0x0400033D RID: 829
		public static readonly global::System.Windows.DependencyProperty FieldVisibilityProperty = global::System.Windows.DependencyProperty.RegisterAttached("FieldVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.GridUtilities), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GridUtilities.OnFieldVisibilityChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GridUtilities.OnCoerceFieldVisibility)));

		// Token: 0x020000A1 RID: 161
		public class AggregateComparer<T> : global::System.Collections.Generic.IComparer<T>, global::System.Collections.IComparer
		{
			// Token: 0x0600086F RID: 2159 RVA: 0x00024706 File Offset: 0x00022906
			public AggregateComparer(params global::System.Collections.Generic.IComparer<T>[] comparers)
			{
				this._comparers = comparers;
			}

			// Token: 0x06000870 RID: 2160 RVA: 0x00024718 File Offset: 0x00022918
			public int Compare(T x, T y)
			{
				for (int i = 0; i < this._comparers.Length; i++)
				{
					global::System.Collections.Generic.IComparer<T> comparer = this._comparers[i];
					int num = comparer.Compare(x, y);
					if (num != 0)
					{
						return num;
					}
				}
				return 0;
			}

			// Token: 0x06000871 RID: 2161 RVA: 0x00024750 File Offset: 0x00022950
			int global::System.Collections.IComparer.Compare(object x, object y)
			{
				return this.Compare((T)((object)x), (T)((object)y));
			}

			// Token: 0x0400033E RID: 830
			private global::System.Collections.Generic.IComparer<T>[] _comparers;
		}

		// Token: 0x020000A2 RID: 162
		public class AggregateEnumerable<T> : global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable
		{
			// Token: 0x06000872 RID: 2162 RVA: 0x00024764 File Offset: 0x00022964
			public AggregateEnumerable(params global::System.Collections.Generic.IEnumerable<T>[] enumerables)
			{
				this._enumerables = enumerables;
			}

			// Token: 0x06000873 RID: 2163 RVA: 0x00024773 File Offset: 0x00022973
			public global::System.Collections.IEnumerator GetEnumerator()
			{
				return new global::Infragistics.Windows.DataPresenter.GridUtilities.AggregateEnumerable<T>.Enumerator(this._enumerables);
			}

			// Token: 0x06000874 RID: 2164 RVA: 0x00024780 File Offset: 0x00022980
			global::System.Collections.Generic.IEnumerator<T> global::System.Collections.Generic.IEnumerable<!0>.GetEnumerator()
			{
				return new global::Infragistics.Windows.DataPresenter.GridUtilities.AggregateEnumerable<T>.Enumerator(this._enumerables);
			}

			// Token: 0x0400033F RID: 831
			private global::System.Collections.Generic.IEnumerable<T>[] _enumerables;

			// Token: 0x020000A3 RID: 163
			public class Enumerator : global::System.Collections.Generic.IEnumerator<T>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x06000875 RID: 2165 RVA: 0x0002478D File Offset: 0x0002298D
				public Enumerator(params global::System.Collections.Generic.IEnumerable<T>[] enumerables)
				{
					this._enumerables = enumerables;
					this.Reset();
				}

				// Token: 0x06000876 RID: 2166 RVA: 0x000247A2 File Offset: 0x000229A2
				public void Reset()
				{
					this._index = -1;
					this._current = null;
				}

				// Token: 0x06000877 RID: 2167 RVA: 0x000247B4 File Offset: 0x000229B4
				public bool MoveNext()
				{
					if (this._current != null && this._current.MoveNext())
					{
						return true;
					}
					while (this._enumerables != null && ++this._index < this._enumerables.Length)
					{
						global::System.Collections.Generic.IEnumerable<T> enumerable = this._enumerables[this._index];
						if (enumerable != null)
						{
							this._current = enumerable.GetEnumerator();
							this._current.Reset();
							if (this._current.MoveNext())
							{
								return true;
							}
						}
					}
					return false;
				}

				// Token: 0x170001F5 RID: 501
				// (get) Token: 0x06000878 RID: 2168 RVA: 0x00024834 File Offset: 0x00022A34
				public object Current
				{
					get
					{
						return (this._current != null) ? this._current.Current : default(T);
					}
				}

				// Token: 0x170001F6 RID: 502
				// (get) Token: 0x06000879 RID: 2169 RVA: 0x00024864 File Offset: 0x00022A64
				T global::System.Collections.Generic.IEnumerator<!0>.Current
				{
					get
					{
						if (this._current == null)
						{
							return default(T);
						}
						return this._current.Current;
					}
				}

				// Token: 0x0600087A RID: 2170 RVA: 0x0002488E File Offset: 0x00022A8E
				public void Dispose()
				{
				}

				// Token: 0x04000340 RID: 832
				private global::System.Collections.Generic.IEnumerable<T>[] _enumerables;

				// Token: 0x04000341 RID: 833
				private int _index;

				// Token: 0x04000342 RID: 834
				private global::System.Collections.Generic.IEnumerator<T> _current;
			}
		}

		// Token: 0x020000A4 RID: 164
		internal class AntirecursionUtility
		{
			// Token: 0x170001F7 RID: 503
			// (get) Token: 0x0600087B RID: 2171 RVA: 0x00024890 File Offset: 0x00022A90
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility.ID, int> Map
			{
				get
				{
					if (this._map == null)
					{
						this._map = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility.ID, int>();
					}
					return this._map;
				}
			}

			// Token: 0x0600087C RID: 2172 RVA: 0x000248AC File Offset: 0x00022AAC
			public bool Enter(object item, object flagId, bool disallowMultipleEntries)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility.ID key = new global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility.ID(item, flagId);
				int num;
				if (this.Map.TryGetValue(key, out num))
				{
					if (disallowMultipleEntries)
					{
						return false;
					}
				}
				else
				{
					num = 0;
				}
				this.Map[key] = 1 + num;
				return true;
			}

			// Token: 0x0600087D RID: 2173 RVA: 0x000248EC File Offset: 0x00022AEC
			public void Exit(object item, object flagId)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility.ID key = new global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility.ID(item, flagId);
				int num;
				if (this._map != null && this._map.TryGetValue(key, out num))
				{
					num--;
					if (num <= 0)
					{
						this._map.Remove(key);
						return;
					}
					this._map[key] = num;
				}
			}

			// Token: 0x0600087E RID: 2174 RVA: 0x0002493D File Offset: 0x00022B3D
			public bool InProgress(object item, object flagId)
			{
				return this._map != null && this._map.ContainsKey(new global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility.ID(item, flagId));
			}

			// Token: 0x04000343 RID: 835
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility.ID, int> _map;

			// Token: 0x020000A5 RID: 165
			private struct ID
			{
				// Token: 0x06000880 RID: 2176 RVA: 0x00024963 File Offset: 0x00022B63
				internal ID(object item, object flagId)
				{
					this._item = item;
					this._flagId = flagId;
				}

				// Token: 0x06000881 RID: 2177 RVA: 0x00024973 File Offset: 0x00022B73
				internal static int GetHashCode(object o)
				{
					if (o == null)
					{
						return 0;
					}
					return o.GetHashCode();
				}

				// Token: 0x06000882 RID: 2178 RVA: 0x00024980 File Offset: 0x00022B80
				public override int GetHashCode()
				{
					return global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility.ID.GetHashCode(this._item) ^ global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility.ID.GetHashCode(this._flagId);
				}

				// Token: 0x06000883 RID: 2179 RVA: 0x0002499C File Offset: 0x00022B9C
				public override bool Equals(object obj)
				{
					if (obj is global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility.ID)
					{
						global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility.ID id = (global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility.ID)obj;
						if (id._item == this._item && id._flagId == this._flagId)
						{
							return true;
						}
					}
					return false;
				}

				// Token: 0x04000344 RID: 836
				internal object _item;

				// Token: 0x04000345 RID: 837
				internal object _flagId;
			}
		}

		// Token: 0x020000A6 RID: 166
		public class ConverterEnumerable<TInput, TOutput> : global::System.Collections.Generic.IEnumerable<TOutput>, global::System.Collections.IEnumerable
		{
			// Token: 0x06000884 RID: 2180 RVA: 0x000249D9 File Offset: 0x00022BD9
			public ConverterEnumerable(global::System.Collections.Generic.IEnumerable<TInput> e, global::System.Converter<TInput, TOutput> converter)
			{
				this._e = e;
				this._converter = converter;
			}

			// Token: 0x06000885 RID: 2181 RVA: 0x000249EF File Offset: 0x00022BEF
			public global::System.Collections.Generic.IEnumerator<TOutput> GetEnumerator()
			{
				return new global::Infragistics.Windows.DataPresenter.GridUtilities.ConverterEnumerator<TInput, TOutput>(this._e.GetEnumerator(), this._converter);
			}

			// Token: 0x06000886 RID: 2182 RVA: 0x00024A07 File Offset: 0x00022C07
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x04000346 RID: 838
			private global::System.Collections.Generic.IEnumerable<TInput> _e;

			// Token: 0x04000347 RID: 839
			private global::System.Converter<TInput, TOutput> _converter;
		}

		// Token: 0x020000A7 RID: 167
		public class ConverterEnumerator<TInput, TOutput> : global::System.Collections.Generic.IEnumerator<TOutput>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06000887 RID: 2183 RVA: 0x00024A0F File Offset: 0x00022C0F
			public ConverterEnumerator(global::System.Collections.Generic.IEnumerator<TInput> e, global::System.Converter<TInput, TOutput> converter)
			{
				this._e = e;
				this._converter = converter;
			}

			// Token: 0x06000888 RID: 2184 RVA: 0x00024A25 File Offset: 0x00022C25
			public void Reset()
			{
				this._e.Reset();
			}

			// Token: 0x06000889 RID: 2185 RVA: 0x00024A32 File Offset: 0x00022C32
			public bool MoveNext()
			{
				return this._e.MoveNext();
			}

			// Token: 0x170001F8 RID: 504
			// (get) Token: 0x0600088A RID: 2186 RVA: 0x00024A3F File Offset: 0x00022C3F
			public TOutput Current
			{
				get
				{
					return this._converter(this._e.Current);
				}
			}

			// Token: 0x170001F9 RID: 505
			// (get) Token: 0x0600088B RID: 2187 RVA: 0x00024A57 File Offset: 0x00022C57
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x0600088C RID: 2188 RVA: 0x00024A64 File Offset: 0x00022C64
			public void Dispose()
			{
			}

			// Token: 0x04000348 RID: 840
			private global::System.Collections.Generic.IEnumerator<TInput> _e;

			// Token: 0x04000349 RID: 841
			private global::System.Converter<TInput, TOutput> _converter;
		}

		// Token: 0x020000A8 RID: 168
		public class EmptyEnumerable<T> : global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable
		{
			// Token: 0x0600088E RID: 2190 RVA: 0x00024A6E File Offset: 0x00022C6E
			public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
			{
				return new global::Infragistics.Windows.DataPresenter.GridUtilities.EmptyEnumerable<T>.Enumerator();
			}

			// Token: 0x0600088F RID: 2191 RVA: 0x00024A75 File Offset: 0x00022C75
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x020000A9 RID: 169
			public class Enumerator : global::System.Collections.Generic.IEnumerator<!0>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x170001FA RID: 506
				// (get) Token: 0x06000891 RID: 2193 RVA: 0x00024A85 File Offset: 0x00022C85
				public T Current
				{
					get
					{
						throw new global::System.InvalidOperationException();
					}
				}

				// Token: 0x06000892 RID: 2194 RVA: 0x00024A8C File Offset: 0x00022C8C
				public void Dispose()
				{
				}

				// Token: 0x170001FB RID: 507
				// (get) Token: 0x06000893 RID: 2195 RVA: 0x00024A8E File Offset: 0x00022C8E
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						throw new global::System.InvalidOperationException();
					}
				}

				// Token: 0x06000894 RID: 2196 RVA: 0x00024A95 File Offset: 0x00022C95
				public bool MoveNext()
				{
					return false;
				}

				// Token: 0x06000895 RID: 2197 RVA: 0x00024A98 File Offset: 0x00022C98
				public void Reset()
				{
				}
			}
		}

		// Token: 0x020000AA RID: 170
		public class EnumeratorCollection<T> : global::System.Collections.Generic.ICollection<T>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable
		{
			// Token: 0x06000896 RID: 2198 RVA: 0x00024A9A File Offset: 0x00022C9A
			public EnumeratorCollection(global::System.Collections.Generic.IEnumerable<T> enumerable, int count)
			{
				this._enumerable = enumerable;
				this._count = count;
			}

			// Token: 0x06000897 RID: 2199 RVA: 0x00024AB0 File Offset: 0x00022CB0
			public void Add(T item)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x06000898 RID: 2200 RVA: 0x00024AB7 File Offset: 0x00022CB7
			public void Clear()
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x06000899 RID: 2201 RVA: 0x00024ABE File Offset: 0x00022CBE
			public bool Contains(T item)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x0600089A RID: 2202 RVA: 0x00024AC5 File Offset: 0x00022CC5
			public void CopyTo(T[] array, int arrayIndex)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.CopyTo<T>(this._enumerable, array, arrayIndex);
			}

			// Token: 0x170001FC RID: 508
			// (get) Token: 0x0600089B RID: 2203 RVA: 0x00024AD4 File Offset: 0x00022CD4
			public int Count
			{
				get
				{
					return this._count;
				}
			}

			// Token: 0x170001FD RID: 509
			// (get) Token: 0x0600089C RID: 2204 RVA: 0x00024ADC File Offset: 0x00022CDC
			public bool IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x0600089D RID: 2205 RVA: 0x00024ADF File Offset: 0x00022CDF
			public bool Remove(T item)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x0600089E RID: 2206 RVA: 0x00024AE6 File Offset: 0x00022CE6
			public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
			{
				return this._enumerable.GetEnumerator();
			}

			// Token: 0x0600089F RID: 2207 RVA: 0x00024AF3 File Offset: 0x00022CF3
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this._enumerable.GetEnumerator();
			}

			// Token: 0x0400034A RID: 842
			private global::System.Collections.Generic.IEnumerable<T> _enumerable;

			// Token: 0x0400034B RID: 843
			private int _count;
		}

		// Token: 0x020000AB RID: 171
		internal interface IMeetsCriteria
		{
			// Token: 0x060008A0 RID: 2208
			bool MeetsCriteria(object item);
		}

		// Token: 0x020000AC RID: 172
		internal class InvalidateStylesAsyncInfo
		{
			// Token: 0x0400034C RID: 844
			internal bool _bumpVersion;

			// Token: 0x0400034D RID: 845
			internal bool _regenerateTemplates;

			// Token: 0x0400034E RID: 846
			internal global::System.Windows.Threading.DispatcherOperation _dispatcherOperation;

			// Token: 0x0400034F RID: 847
			internal bool _bumpSpecialRecordsVersion;
		}

		// Token: 0x020000AD RID: 173
		internal class MeetsCriteria_RecordFieldLayout : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
		{
			// Token: 0x060008A2 RID: 2210 RVA: 0x00024B08 File Offset: 0x00022D08
			internal MeetsCriteria_RecordFieldLayout(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
			{
				this._fieldLayout = fieldLayout;
			}

			// Token: 0x060008A3 RID: 2211 RVA: 0x00024B18 File Offset: 0x00022D18
			public bool MeetsCriteria(object item)
			{
				global::Infragistics.Windows.DataPresenter.Record record = (global::Infragistics.Windows.DataPresenter.Record)item;
				return this._fieldLayout == record.FieldLayout;
			}

			// Token: 0x04000350 RID: 848
			private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;
		}

		// Token: 0x020000AE RID: 174
		internal class MeetsCriteria_FilteredInRecords : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
		{
			// Token: 0x060008A4 RID: 2212 RVA: 0x00024B3A File Offset: 0x00022D3A
			public bool MeetsCriteria(object item)
			{
				return !((global::Infragistics.Windows.DataPresenter.Record)item).InternalIsFilteredOut_Verify;
			}
		}

		// Token: 0x020000AF RID: 175
		internal class MeetsCriteria_RecordType : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
		{
			// Token: 0x060008A6 RID: 2214 RVA: 0x00024B52 File Offset: 0x00022D52
			internal MeetsCriteria_RecordType(global::Infragistics.Windows.DataPresenter.RecordType recordType)
			{
				this._recordType = recordType;
			}

			// Token: 0x060008A7 RID: 2215 RVA: 0x00024B64 File Offset: 0x00022D64
			public bool MeetsCriteria(object item)
			{
				global::Infragistics.Windows.DataPresenter.Record record = (global::Infragistics.Windows.DataPresenter.Record)item;
				return this._recordType == record.RecordType;
			}

			// Token: 0x04000351 RID: 849
			private global::Infragistics.Windows.DataPresenter.RecordType _recordType;
		}

		// Token: 0x020000B0 RID: 176
		internal class MeetsCriteria_RecordVisible : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
		{
			// Token: 0x060008A8 RID: 2216 RVA: 0x00024B86 File Offset: 0x00022D86
			internal MeetsCriteria_RecordVisible() : this(false)
			{
			}

			// Token: 0x060008A9 RID: 2217 RVA: 0x00024B8F File Offset: 0x00022D8F
			internal MeetsCriteria_RecordVisible(bool ignoreFilteringLogic)
			{
				this._ignoreFilteringLogic = ignoreFilteringLogic;
			}

			// Token: 0x060008AA RID: 2218 RVA: 0x00024BA0 File Offset: 0x00022DA0
			public bool MeetsCriteria(object item)
			{
				global::Infragistics.Windows.DataPresenter.Record record = (global::Infragistics.Windows.DataPresenter.Record)item;
				global::System.Windows.Visibility visibility = this._ignoreFilteringLogic ? record.VisibilityResolved_NoFiltering : record.VisibilityResolved;
				return global::System.Windows.Visibility.Visible == visibility;
			}

			// Token: 0x04000352 RID: 850
			private bool _ignoreFilteringLogic;
		}

		// Token: 0x020000B1 RID: 177
		internal class MeetsCriteria_Type : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
		{
			// Token: 0x060008AB RID: 2219 RVA: 0x00024BCF File Offset: 0x00022DCF
			internal MeetsCriteria_Type(global::System.Type type, bool allowSubtypes)
			{
				this._type = type;
				this._allowSubtypes = allowSubtypes;
			}

			// Token: 0x060008AC RID: 2220 RVA: 0x00024BE5 File Offset: 0x00022DE5
			public bool MeetsCriteria(object item)
			{
				if (!this._allowSubtypes)
				{
					return item != null && this._type == item.GetType();
				}
				return global::Infragistics.Windows.DataPresenter.GridUtilities.IsObjectOfType(item, this._type);
			}

			// Token: 0x04000353 RID: 851
			private global::System.Type _type;

			// Token: 0x04000354 RID: 852
			private bool _allowSubtypes;
		}

		// Token: 0x020000B2 RID: 178
		internal class MeetsCriteria_Predicate<T> : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
		{
			// Token: 0x060008AD RID: 2221 RVA: 0x00024C12 File Offset: 0x00022E12
			internal MeetsCriteria_Predicate(global::System.Predicate<T> predicate)
			{
				this._predicate = predicate;
			}

			// Token: 0x060008AE RID: 2222 RVA: 0x00024C21 File Offset: 0x00022E21
			public bool MeetsCriteria(object item)
			{
				return item is T && this._predicate((T)((object)item));
			}

			// Token: 0x04000355 RID: 853
			private global::System.Predicate<T> _predicate;
		}

		// Token: 0x020000B3 RID: 179
		internal class MeetsCriteriaChain : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
		{
			// Token: 0x060008AF RID: 2223 RVA: 0x00024C40 File Offset: 0x00022E40
			internal MeetsCriteriaChain(global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria x, global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria y, bool combineUsingOr) : this(new global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria[]
			{
				x,
				y
			}, combineUsingOr)
			{
			}

			// Token: 0x060008B0 RID: 2224 RVA: 0x00024C64 File Offset: 0x00022E64
			internal MeetsCriteriaChain(global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria[] arr, bool combineUsingOr)
			{
				this._arr = arr;
				this._combineUsingOr = combineUsingOr;
			}

			// Token: 0x060008B1 RID: 2225 RVA: 0x00024C7C File Offset: 0x00022E7C
			public bool MeetsCriteria(object item)
			{
				for (int i = 0; i < this._arr.Length; i++)
				{
					bool flag = this._arr[i].MeetsCriteria(item);
					if (this._combineUsingOr)
					{
						if (flag)
						{
							return true;
						}
					}
					else if (!flag)
					{
						return false;
					}
				}
				return !this._combineUsingOr;
			}

			// Token: 0x04000356 RID: 854
			private global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria[] _arr;

			// Token: 0x04000357 RID: 855
			private bool _combineUsingOr;
		}

		// Token: 0x020000B4 RID: 180
		internal class MeetsCriteriaComplement : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
		{
			// Token: 0x060008B2 RID: 2226 RVA: 0x00024CC6 File Offset: 0x00022EC6
			internal MeetsCriteriaComplement(global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria i)
			{
				this._i = i;
			}

			// Token: 0x060008B3 RID: 2227 RVA: 0x00024CD5 File Offset: 0x00022ED5
			public bool MeetsCriteria(object item)
			{
				return !this._i.MeetsCriteria(item);
			}

			// Token: 0x04000358 RID: 856
			private global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria _i;
		}

		// Token: 0x020000B5 RID: 181
		internal class MeetsCriteriaEnumerator<T> : global::System.Collections.Generic.IEnumerator<!0>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x060008B4 RID: 2228 RVA: 0x00024CE6 File Offset: 0x00022EE6
			internal MeetsCriteriaEnumerator(global::System.Collections.Generic.IEnumerator<T> enumerator, global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria meetsCriteriaCallback)
			{
				this._enumerator = enumerator;
				this._meetsCriteriaCallback = meetsCriteriaCallback;
			}

			// Token: 0x060008B5 RID: 2229 RVA: 0x00024CFC File Offset: 0x00022EFC
			public void Reset()
			{
				this._enumerator.Reset();
				this._currentItem = default(T);
			}

			// Token: 0x060008B6 RID: 2230 RVA: 0x00024D18 File Offset: 0x00022F18
			public bool MoveNext()
			{
				while (this._enumerator.MoveNext())
				{
					this._currentItem = this._enumerator.Current;
					if (this._meetsCriteriaCallback.MeetsCriteria(this._currentItem))
					{
						return true;
					}
				}
				this._currentItem = default(T);
				return false;
			}

			// Token: 0x170001FE RID: 510
			// (get) Token: 0x060008B7 RID: 2231 RVA: 0x00024D6A File Offset: 0x00022F6A
			public T Current
			{
				get
				{
					return this._currentItem;
				}
			}

			// Token: 0x170001FF RID: 511
			// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00024D72 File Offset: 0x00022F72
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this._currentItem;
				}
			}

			// Token: 0x060008B9 RID: 2233 RVA: 0x00024D7F File Offset: 0x00022F7F
			public void Dispose()
			{
				this.Reset();
			}

			// Token: 0x04000359 RID: 857
			private global::System.Collections.Generic.IEnumerator<T> _enumerator;

			// Token: 0x0400035A RID: 858
			private global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria _meetsCriteriaCallback;

			// Token: 0x0400035B RID: 859
			private T _currentItem;

			// Token: 0x020000B6 RID: 182
			internal class Enumerable : global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable
			{
				// Token: 0x060008BA RID: 2234 RVA: 0x00024D87 File Offset: 0x00022F87
				internal Enumerable(global::System.Collections.Generic.IEnumerable<T> e, global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria i)
				{
					this._e = (e ?? ((global::System.Collections.Generic.IEnumerable<!0>)new T[0]));
					this._i = i;
				}

				// Token: 0x060008BB RID: 2235 RVA: 0x00024DAC File Offset: 0x00022FAC
				internal Enumerable(global::System.Collections.Generic.IEnumerable<T> e, global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria[] criteria, bool combineUsingOr) : this(e, new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteriaChain(criteria, combineUsingOr))
				{
				}

				// Token: 0x060008BC RID: 2236 RVA: 0x00024DBC File Offset: 0x00022FBC
				public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
				{
					return new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteriaEnumerator<T>(this._e.GetEnumerator(), this._i);
				}

				// Token: 0x060008BD RID: 2237 RVA: 0x00024DD4 File Offset: 0x00022FD4
				global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
				{
					return this.GetEnumerator();
				}

				// Token: 0x0400035C RID: 860
				private global::System.Collections.Generic.IEnumerable<T> _e;

				// Token: 0x0400035D RID: 861
				private global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria _i;
			}
		}

		// Token: 0x020000B7 RID: 183
		internal class MeetsCriteriaExcludeSingleItem : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
		{
			// Token: 0x060008BE RID: 2238 RVA: 0x00024DDC File Offset: 0x00022FDC
			internal MeetsCriteriaExcludeSingleItem(object item)
			{
				this._item = item;
			}

			// Token: 0x060008BF RID: 2239 RVA: 0x00024DEB File Offset: 0x00022FEB
			public bool MeetsCriteria(object o)
			{
				return this._item != o;
			}

			// Token: 0x0400035E RID: 862
			private object _item;
		}

		// Token: 0x020000B8 RID: 184
		// (Invoke) Token: 0x060008C1 RID: 2241
		internal delegate void MethodDelegate();

		// Token: 0x020000B9 RID: 185
		internal class NotifyCollectionEnumerable<T> : global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged
		{
			// Token: 0x060008C4 RID: 2244 RVA: 0x00024DF9 File Offset: 0x00022FF9
			public NotifyCollectionEnumerable(global::System.Collections.Generic.IEnumerable<T> sourceItems) : this(sourceItems, null)
			{
			}

			// Token: 0x060008C5 RID: 2245 RVA: 0x00024E03 File Offset: 0x00023003
			public NotifyCollectionEnumerable(global::System.Collections.Generic.IEnumerable<T> sourceItems, global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria filter)
			{
				this._sourceItems = sourceItems;
				this._filter = filter;
			}

			// Token: 0x17000200 RID: 512
			// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00024E19 File Offset: 0x00023019
			// (set) Token: 0x060008C7 RID: 2247 RVA: 0x00024E21 File Offset: 0x00023021
			public object Tag
			{
				get
				{
					return this._tag;
				}
				set
				{
					this._tag = value;
				}
			}

			// Token: 0x17000201 RID: 513
			// (get) Token: 0x060008C8 RID: 2248 RVA: 0x00024E2A File Offset: 0x0002302A
			// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00024E32 File Offset: 0x00023032
			public global::System.Collections.Generic.IEnumerable<T> SourceItems
			{
				get
				{
					return this._sourceItems;
				}
				set
				{
					if (this._sourceItems != value)
					{
						this._sourceItems = value;
						this.RaiseCollectionChanged();
					}
				}
			}

			// Token: 0x060008CA RID: 2250 RVA: 0x00024E4A File Offset: 0x0002304A
			public void RaiseCollectionChanged()
			{
				if (this.CollectionChanged != null)
				{
					this.CollectionChanged(this, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
				}
			}

			// Token: 0x14000005 RID: 5
			// (add) Token: 0x060008CB RID: 2251 RVA: 0x00024E68 File Offset: 0x00023068
			// (remove) Token: 0x060008CC RID: 2252 RVA: 0x00024EA0 File Offset: 0x000230A0
			public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

			// Token: 0x060008CD RID: 2253 RVA: 0x00024ED8 File Offset: 0x000230D8
			public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
			{
				if (this._sourceItems == null)
				{
					return ((global::System.Collections.Generic.IEnumerable<!0>)new T[0]).GetEnumerator();
				}
				if (this._filter == null)
				{
					return this._sourceItems.GetEnumerator();
				}
				return new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteriaEnumerator<T>(this._sourceItems.GetEnumerator(), this._filter);
			}

			// Token: 0x060008CE RID: 2254 RVA: 0x00024F28 File Offset: 0x00023128
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x0400035F RID: 863
			private global::System.Collections.Generic.IEnumerable<T> _sourceItems;

			// Token: 0x04000360 RID: 864
			private global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria _filter;

			// Token: 0x04000361 RID: 865
			private object _tag;
		}

		// Token: 0x020000BA RID: 186
		public struct Range
		{
			// Token: 0x060008CF RID: 2255 RVA: 0x00024F30 File Offset: 0x00023130
			public Range(int start, int end)
			{
				this._start = start;
				this._end = end;
			}

			// Token: 0x17000202 RID: 514
			// (get) Token: 0x060008D0 RID: 2256 RVA: 0x00024F40 File Offset: 0x00023140
			// (set) Token: 0x060008D1 RID: 2257 RVA: 0x00024F48 File Offset: 0x00023148
			public int Start
			{
				get
				{
					return this._start;
				}
				set
				{
					this._start = value;
				}
			}

			// Token: 0x17000203 RID: 515
			// (get) Token: 0x060008D2 RID: 2258 RVA: 0x00024F51 File Offset: 0x00023151
			// (set) Token: 0x060008D3 RID: 2259 RVA: 0x00024F59 File Offset: 0x00023159
			public int End
			{
				get
				{
					return this._end;
				}
				set
				{
					this._end = value;
				}
			}

			// Token: 0x04000363 RID: 867
			private int _start;

			// Token: 0x04000364 RID: 868
			private int _end;
		}

		// Token: 0x020000BB RID: 187
		internal class RecordContentMarginConverter : global::System.Windows.Data.IMultiValueConverter
		{
			// Token: 0x060008D4 RID: 2260 RVA: 0x00024F64 File Offset: 0x00023164
			static RecordContentMarginConverter()
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.RecordContentMarginConverter.instance = new global::Infragistics.Windows.DataPresenter.GridUtilities.RecordContentMarginConverter();
			}

			// Token: 0x060008D5 RID: 2261 RVA: 0x00024FBC File Offset: 0x000231BC
			private RecordContentMarginConverter()
			{
			}

			// Token: 0x17000204 RID: 516
			// (get) Token: 0x060008D6 RID: 2262 RVA: 0x00024FC4 File Offset: 0x000231C4
			internal static global::System.Windows.Data.IMultiValueConverter Instance
			{
				get
				{
					return global::Infragistics.Windows.DataPresenter.GridUtilities.RecordContentMarginConverter.instance;
				}
			}

			// Token: 0x060008D7 RID: 2263 RVA: 0x00024FCC File Offset: 0x000231CC
			internal static void BumpVersion(global::System.Windows.DependencyObject d)
			{
				int num = (int)d.GetValue(global::Infragistics.Windows.DataPresenter.GridUtilities.RecordContentMarginConverter.VersionProperty);
				d.SetValue(global::Infragistics.Windows.DataPresenter.GridUtilities.RecordContentMarginConverter.VersionProperty, num + 1);
			}

			// Token: 0x060008D8 RID: 2264 RVA: 0x00025000 File Offset: 0x00023200
			public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				global::System.Windows.Thickness thickness = default(global::System.Windows.Thickness);
				object[] array = parameter as object[];
				bool flag = (bool)array[0];
				global::System.Type left = (global::System.Type)array[1];
				global::System.Windows.FrameworkElement frameworkElement = values[0] as global::System.Windows.FrameworkElement;
				if (frameworkElement == null)
				{
					return thickness;
				}
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = frameworkElement as global::Infragistics.Windows.DataPresenter.RecordPresenter;
				if (recordPresenter == null)
				{
					recordPresenter = (global::Infragistics.Windows.Utilities.GetAncestorFromType(frameworkElement, typeof(global::Infragistics.Windows.DataPresenter.RecordPresenter), true) as global::Infragistics.Windows.DataPresenter.RecordPresenter);
					if (recordPresenter == null)
					{
						return thickness;
					}
				}
				if (!flag && recordPresenter is global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter && left != typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter))
				{
					return thickness;
				}
				global::Infragistics.Windows.DataPresenter.Record record = recordPresenter.Record;
				if (record == null)
				{
					return thickness;
				}
				global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = global::Infragistics.Windows.Utilities.GetAncestorFromType(recordPresenter, typeof(global::Infragistics.Windows.DataPresenter.RecordListControl), true) as global::Infragistics.Windows.DataPresenter.RecordListControl;
				if (recordListControl == null)
				{
					return thickness;
				}
				global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord = record as global::Infragistics.Windows.DataPresenter.HeaderRecord;
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordCollection = recordListControl.ItemsSource as global::Infragistics.Windows.DataPresenter.ViewableRecordCollection;
				if (viewableRecordCollection == null)
				{
					global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection flatScrollRecordsCollection = recordListControl.ItemsSource as global::Infragistics.Windows.DataPresenter.FlatScrollRecordsCollection;
					if (flatScrollRecordsCollection != null)
					{
						global::Infragistics.Windows.DataPresenter.Record record2 = null;
						if (headerRecord != null)
						{
							record2 = headerRecord.RecordForLayoutCalculations;
						}
						if (record2 == null)
						{
							record2 = record;
						}
						viewableRecordCollection = record2.ParentCollection.ViewableRecords;
					}
				}
				if (viewableRecordCollection == null && !(recordPresenter is global::Infragistics.Windows.DataPresenter.GroupByRecordPresenter) && (viewableRecordCollection != null || !(recordPresenter is global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter)))
				{
					return thickness;
				}
				if (viewableRecordCollection != null && headerRecord == null && (!(recordPresenter is global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter) || frameworkElement is global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter))
				{
					switch (viewableRecordCollection.RecordCollection.RecordsType)
					{
					case global::Infragistics.Windows.DataPresenter.RecordType.GroupByField:
					case global::Infragistics.Windows.DataPresenter.RecordType.GroupByFieldLayout:
					{
						int count = viewableRecordCollection.Count;
						if (count > 0)
						{
							record = viewableRecordCollection[0];
						}
						break;
					}
					}
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = record.FieldLayout;
				if (fieldLayout == null)
				{
					return thickness;
				}
				double num = record.CalculateExtraOffsetInGroupBy(flag);
				if (frameworkElement is global::Infragistics.Windows.DataPresenter.GroupBySummariesPresenter)
				{
					global::Infragistics.Windows.DataPresenter.RecordSelectorLocation recordSelectorLocationResolved = fieldLayout.RecordSelectorLocationResolved;
					if (recordSelectorLocationResolved == global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.LeftOfCellArea && !fieldLayout.IsHorizontal)
					{
						num += fieldLayout.RecordSelectorExtentResolved;
					}
				}
				if (num > 0.0)
				{
					if (fieldLayout.IsHorizontal)
					{
						thickness.Top = num;
					}
					else
					{
						thickness.Left = num;
					}
				}
				return thickness;
			}

			// Token: 0x060008D9 RID: 2265 RVA: 0x00025214 File Offset: 0x00023414
			public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
			{
				return new object[]
				{
					global::System.Windows.Data.Binding.DoNothing,
					global::System.Windows.Data.Binding.DoNothing
				};
			}

			// Token: 0x04000365 RID: 869
			private static readonly object PositiveInfinity = double.PositiveInfinity;

			// Token: 0x04000366 RID: 870
			private static readonly global::Infragistics.Windows.DataPresenter.GridUtilities.RecordContentMarginConverter instance;

			// Token: 0x04000367 RID: 871
			internal static readonly global::System.Windows.DependencyProperty VersionProperty = global::System.Windows.DependencyProperty.RegisterAttached("Version", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.GridUtilities.RecordContentMarginConverter), new global::System.Windows.FrameworkPropertyMetadata(0));
		}
	}
}
