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
using System.Threading;
using System.Threading.Tasks;
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
	// Token: 0x020000A6 RID: 166
	internal static class GridUtilities
	{
		// Token: 0x06000865 RID: 2149 RVA: 0x00025438 File Offset: 0x00023638
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

		// Token: 0x06000866 RID: 2150 RVA: 0x0002546F File Offset: 0x0002366F
		public static bool AreClose(double x, double y)
		{
			return x == y || global::System.Math.Abs(x - y) < 1E-10;
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x0002548A File Offset: 0x0002368A
		public static bool AreClose(double x, double y, double tolerance)
		{
			return x == y || global::System.Math.Abs(x - y) <= tolerance;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x000254A0 File Offset: 0x000236A0
		public static bool AreClose(global::System.Windows.Size x, global::System.Windows.Size y)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(x.Width, y.Width) && global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(x.Height, y.Height);
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x000254CC File Offset: 0x000236CC
		public static bool AreClose(global::System.Windows.Rect x, global::System.Windows.Rect y)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(x.Width, y.Width) && global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(x.Height, y.Height) && global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(x.Left, y.Left) && global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(x.Top, y.Top);
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00025530 File Offset: 0x00023730
		public static bool AreClose(global::System.Windows.Thickness x, global::System.Windows.Thickness y)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(x.Left, y.Left) && global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(x.Top, y.Top) && global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(x.Right, y.Right) && global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(x.Bottom, y.Bottom);
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00025594 File Offset: 0x00023794
		internal static bool AreEqual(object item1, object item2)
		{
			if (item1 == item2)
			{
				return true;
			}
			global::System.Type type = (item1 != null) ? item1.GetType() : null;
			return type != null && type.IsValueType && object.Equals(item1, item2);
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x000255CE File Offset: 0x000237CE
		internal static bool AreEqual(string x, string y, bool considerNullAsEmptyString)
		{
			if (!considerNullAsEmptyString)
			{
				return x == y;
			}
			return (x ?? string.Empty) == (y ?? string.Empty);
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x000255F4 File Offset: 0x000237F4
		public static bool AreKeysEqual(string xxKey, string yyKey)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.AreKeysEqual(xxKey, yyKey, false);
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x000255FE File Offset: 0x000237FE
		public static bool AreKeysEqual(string xxKey, string yyKey, bool ignoreCase)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.Compare(xxKey, yyKey, ignoreCase) == 0 && !string.IsNullOrEmpty(xxKey) && !string.IsNullOrEmpty(yyKey);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0002561D File Offset: 0x0002381D
		public static bool AreSameTypeAndEqual(object x, object y)
		{
			return x == y || (x != null && y != null && x.GetType() == y.GetType() && object.Equals(x, y));
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00025647 File Offset: 0x00023847
		public static int ArrMax(int[] arr)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.ArrMax(arr, 0, arr.Length);
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00025654 File Offset: 0x00023854
		public static int ArrMax(int[] arr, int startIndex, int count)
		{
			int num = arr[startIndex];
			for (int i = 1; i < count; i++)
			{
				num = global::System.Math.Max(num, arr[startIndex + i]);
			}
			return num;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00025680 File Offset: 0x00023880
		public static double ArrSum(double[] arr, int startIndex, int count)
		{
			double num = 0.0;
			for (int i = 0; i < count; i++)
			{
				num += arr[startIndex + i];
			}
			return num;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x000256AC File Offset: 0x000238AC
		internal static global::System.Windows.Point AdjustPoint(global::System.Windows.Point pt, double dpiFactor, global::System.Windows.Thickness thickness)
		{
			pt.X = global::Infragistics.Windows.DataPresenter.GridUtilities.RoundToIntegralDevicePixel(dpiFactor, pt.X);
			pt.Y = global::Infragistics.Windows.DataPresenter.GridUtilities.RoundToIntegralDevicePixel(dpiFactor, pt.Y);
			pt.X -= dpiFactor * 0.5;
			pt.Y -= dpiFactor * 0.5;
			return pt;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00025714 File Offset: 0x00023914
		internal static double CalculateDpiOffsetAdjustment(double dpiFactor, double value, bool alwaysRoundUp = false)
		{
			double num = value % dpiFactor;
			if (global::Infragistics.CoreUtilities.AreClose(num, 0.0))
			{
				return 0.0;
			}
			if (global::Infragistics.CoreUtilities.AreClose(global::System.Math.Abs(num), dpiFactor))
			{
				return 0.0;
			}
			if (!alwaysRoundUp)
			{
				if (global::System.Math.Abs(num) < dpiFactor / 2.0)
				{
					return -num;
				}
				return (double)global::System.Math.Sign(num) * dpiFactor - num;
			}
			else
			{
				if (num < 0.0)
				{
					return -num;
				}
				return dpiFactor - num;
			}
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0002578F File Offset: 0x0002398F
		internal static double RoundToIntegralDevicePixel(double dpiFactor, double value)
		{
			return value + global::Infragistics.Windows.DataPresenter.GridUtilities.CalculateDpiOffsetAdjustment(dpiFactor, value, false);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0002579B File Offset: 0x0002399B
		public static int Compare(string xx, string yy, bool ignoreCase)
		{
			return string.Compare(xx, yy, ignoreCase, global::Infragistics.Windows.DataPresenter.GridUtilities.StringCompareCulture);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x000257AA File Offset: 0x000239AA
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

		// Token: 0x06000878 RID: 2168 RVA: 0x000257C8 File Offset: 0x000239C8
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

		// Token: 0x06000879 RID: 2169 RVA: 0x00025898 File Offset: 0x00023A98
		internal static bool Contains(global::System.Windows.Rect r, global::System.Windows.Point pt, bool horz)
		{
			return (horz && r.X <= pt.X && pt.X <= r.Right) || (!horz && r.Y <= pt.Y && pt.Y <= r.Bottom);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x000258F4 File Offset: 0x00023AF4
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

		// Token: 0x0600087B RID: 2171 RVA: 0x00025948 File Offset: 0x00023B48
		internal static bool ContainsExclusive(global::System.Windows.Rect rect, global::System.Windows.Point pt)
		{
			return (pt.X >= rect.X || global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(rect.X, pt.X)) && pt.X < rect.Right && !global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(rect.Right, pt.X) && (pt.Y >= rect.Y || global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(rect.Y, pt.Y)) && pt.Y < rect.Bottom && !global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(rect.Bottom, pt.Y);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x000259EC File Offset: 0x00023BEC
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

		// Token: 0x0600087D RID: 2173 RVA: 0x00025A48 File Offset: 0x00023C48
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

		// Token: 0x0600087E RID: 2174 RVA: 0x00025AD8 File Offset: 0x00023CD8
		internal static global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager CreateGridBagLayoutManager(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.LayoutManagerType type)
		{
			return new global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager(fieldLayout, type)
			{
				ExpandToFitHeight = true,
				ExpandToFitWidth = true
			};
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00025AFC File Offset: 0x00023CFC
		private static global::System.Windows.Data.MultiBinding CreateRecordBindingHelper(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
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
			binding.Source = fieldLayout;
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			binding.Path = new global::System.Windows.PropertyPath(global::Infragistics.Windows.DataPresenter.FieldLayout.RecordSelectorNumberSizeVersionProperty);
			multiBinding.Bindings.Add(binding);
			binding = new global::System.Windows.Data.Binding();
			binding.RelativeSource = global::System.Windows.Data.RelativeSource.Self;
			binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			binding.Path = new global::System.Windows.PropertyPath("DataContext", new object[0]);
			multiBinding.Bindings.Add(binding);
			return multiBinding;
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00025BDC File Offset: 0x00023DDC
		internal static global::System.Windows.Data.BindingBase CreateRecordContentMarginBinding(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool isHeader, global::System.Type targetType)
		{
			global::System.Windows.Data.MultiBinding multiBinding = global::Infragistics.Windows.DataPresenter.GridUtilities.CreateRecordBindingHelper(fieldLayout);
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
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

		// Token: 0x06000881 RID: 2177 RVA: 0x00025C54 File Offset: 0x00023E54
		internal static global::System.Windows.Data.BindingBase CreateRecordSelectorExtentBinding(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool isWidth, global::System.Type targetType)
		{
			global::System.Windows.Data.MultiBinding multiBinding = global::Infragistics.Windows.DataPresenter.GridUtilities.CreateRecordBindingHelper(fieldLayout);
			multiBinding.Mode = global::System.Windows.Data.BindingMode.OneWay;
			multiBinding.Converter = global::Infragistics.Windows.DataPresenter.GridUtilities.RecordSelectorExtentConverter.Instance;
			multiBinding.ConverterParameter = new object[]
			{
				isWidth,
				targetType
			};
			return multiBinding;
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00025C98 File Offset: 0x00023E98
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

		// Token: 0x06000883 RID: 2179 RVA: 0x00025D40 File Offset: 0x00023F40
		public static void CopyTo<T>(global::System.Collections.Generic.IEnumerable<T> items, T[] array, int arrayIndex)
		{
			foreach (T t in items)
			{
				array[arrayIndex++] = t;
			}
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00025D90 File Offset: 0x00023F90
		public static double Distance(global::System.Windows.Point a, global::System.Windows.Point b)
		{
			double num = a.X - b.X;
			double num2 = a.Y - b.Y;
			return global::System.Math.Sqrt(num * num + num2 * num2);
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00025DCC File Offset: 0x00023FCC
		internal static bool DoesElementContainPoint(global::System.Windows.FrameworkElement elem, global::System.Windows.Point p)
		{
			return p.X >= 0.0 && p.Y >= 0.0 && p.X < elem.ActualWidth && p.Y < elem.ActualHeight;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00025E20 File Offset: 0x00024020
		public static global::System.Windows.Point EnsureInElementBounds(global::System.Windows.Point point, global::System.Windows.FrameworkElement elem)
		{
			point.X = global::Infragistics.Windows.DataPresenter.GridUtilities.EnsureInRange(point.X, 0.0, elem.ActualWidth);
			point.Y = global::Infragistics.Windows.DataPresenter.GridUtilities.EnsureInRange(point.Y, 0.0, elem.ActualHeight);
			return point;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00025E72 File Offset: 0x00024072
		public static double EnsureInRange(double val, double min, double max)
		{
			return global::System.Math.Min(global::System.Math.Max(val, min), max);
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00025E84 File Offset: 0x00024084
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

		// Token: 0x06000889 RID: 2185 RVA: 0x00025EE0 File Offset: 0x000240E0
		public static global::System.Collections.Generic.IEnumerable<T> Filter<T>(global::System.Collections.Generic.IEnumerable<T> items, global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria criteria)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<T>(items, criteria, false);
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00025EEC File Offset: 0x000240EC
		public static global::System.Collections.Generic.IEnumerable<T> Filter<T>(global::System.Collections.Generic.IEnumerable<T> items, global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria criteria, bool flatten)
		{
			global::System.Collections.Generic.IEnumerable<T> enumerable = new global::Infragistics.Windows.DataPresenter.GridUtilities.NotifyCollectionEnumerable<T>(items, criteria);
			if (!flatten)
			{
				return enumerable;
			}
			return new global::System.Collections.Generic.List<T>(enumerable);
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00025F0C File Offset: 0x0002410C
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

		// Token: 0x0600088C RID: 2188 RVA: 0x00025F41 File Offset: 0x00024141
		public static string GetAttribute(global::System.Xml.XmlNode node, string attrib)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.GetAttribute(node, attrib, null);
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00025F4C File Offset: 0x0002414C
		public static string GetAttribute(global::System.Xml.XmlNode node, string attrib, string defaultValue)
		{
			global::System.Xml.XmlAttribute xmlAttribute = node.Attributes[attrib];
			if (xmlAttribute == null)
			{
				return null;
			}
			return xmlAttribute.Value;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00025F74 File Offset: 0x00024174
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

		// Token: 0x0600088F RID: 2191 RVA: 0x00025FF0 File Offset: 0x000241F0
		public static global::System.Collections.Generic.ICollection<TOutput> GetConvertedCollection<TInput, TOutput>(global::System.Collections.IEnumerable items, int itemsCount, global::System.Converter<TInput, TOutput> converter)
		{
			global::System.Collections.Generic.IEnumerable<TInput> e = new global::Infragistics.Collections.TypedEnumerable<TInput>(items);
			global::System.Collections.Generic.IEnumerable<TOutput> enumerable = new global::Infragistics.Windows.DataPresenter.GridUtilities.ConverterEnumerable<TInput, TOutput>(e, converter);
			return new global::Infragistics.Windows.DataPresenter.GridUtilities.EnumeratorCollection<TOutput>(enumerable, itemsCount);
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00026014 File Offset: 0x00024214
		internal static int GetCount(global::System.Collections.IEnumerable e)
		{
			global::System.Collections.ICollection collection = e as global::System.Collections.ICollection;
			if (collection != null)
			{
				return collection.Count;
			}
			return global::Infragistics.Windows.DataPresenter.GridUtilities.GetCountNonOptimized(e);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00026038 File Offset: 0x00024238
		internal static int GetCountNonOptimized(global::System.Collections.IEnumerable e)
		{
			int num = 0;
			foreach (object obj in e)
			{
				num++;
			}
			return num;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00026088 File Offset: 0x00024288
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

		// Token: 0x06000893 RID: 2195 RVA: 0x000260B0 File Offset: 0x000242B0
		public static global::System.Threading.Tasks.TaskScheduler GetCurrentTaskScheduler()
		{
			if (global::System.Threading.SynchronizationContext.Current != null)
			{
				return global::System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext();
			}
			return global::System.Threading.Tasks.TaskScheduler.Current;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x000260C4 File Offset: 0x000242C4
		internal static int GetSyncLockedCount(global::System.Collections.ArrayList list)
		{
			int count;
			lock (list.SyncRoot)
			{
				count = list.Count;
			}
			return count;
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00026108 File Offset: 0x00024308
		internal static global::Infragistics.Windows.DataPresenter.DataPresenterBase GetDataPresenter(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records)
		{
			if (records == null)
			{
				return null;
			}
			return global::Infragistics.Windows.DataPresenter.GridUtilities.GetDataPresenter(records.FieldLayout);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x0002611A File Offset: 0x0002431A
		internal static global::Infragistics.Windows.DataPresenter.DataPresenterBase GetDataPresenter(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			if (fl == null)
			{
				return null;
			}
			return fl.DataPresenter;
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00026127 File Offset: 0x00024327
		internal static global::System.Globalization.CultureInfo GetDefaultCulture(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
		{
			if (dp == null)
			{
				return null;
			}
			return dp.DefaultConverterCulture;
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00026134 File Offset: 0x00024334
		internal static global::System.Globalization.CultureInfo GetDefaultCulture(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.GetDefaultCulture((fl != null) ? fl.DataPresenter : null);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00026147 File Offset: 0x00024347
		internal static global::System.Globalization.CultureInfo GetDefaultCulture(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null)
			{
				return null;
			}
			return field.ConverterCultureResolved;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00026154 File Offset: 0x00024354
		internal static global::System.Globalization.CultureInfo GetDefaultCulture(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			if (field == null)
			{
				return global::Infragistics.Windows.DataPresenter.GridUtilities.GetDefaultCulture(fl);
			}
			return global::Infragistics.Windows.DataPresenter.GridUtilities.GetDefaultCulture(field);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00026166 File Offset: 0x00024366
		public static global::System.Collections.IEnumerable GetEmptyEnumerable()
		{
			return new global::Infragistics.Windows.DataPresenter.GridUtilities.EmptyEnumerable<object>();
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0002616D File Offset: 0x0002436D
		public static global::Infragistics.Windows.DataPresenter.FieldCollection GetFields(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			if (fieldLayout == null)
			{
				return null;
			}
			return fieldLayout.FieldsIfAllocated;
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x0002617A File Offset: 0x0002437A
		public static global::Infragistics.Windows.DataPresenter.Field GetField(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, string fieldName, bool throwException)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.GetField(global::Infragistics.Windows.DataPresenter.GridUtilities.GetFields(fieldLayout), fieldName, throwException);
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0002618C File Offset: 0x0002438C
		public static global::Infragistics.Windows.DataPresenter.Field GetField(global::Infragistics.Windows.DataPresenter.FieldCollection fields, string fieldName, bool throwException)
		{
			int num = (fields != null) ? fields.IndexOf(fieldName) : -1;
			if (num < 0 && fields != null && fields.Owner != null)
			{
				global::Infragistics.Windows.DataPresenter.PlaceholderField[] placeholderFields = fields.Owner.PlaceholderFields;
				if (placeholderFields != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = fields.Owner.AlignmentFieldLayout;
					if (alignmentFieldLayout != null)
					{
						int num2 = alignmentFieldLayout.Fields.IndexOf(fieldName);
						if (num2 >= 0)
						{
							global::Infragistics.Windows.DataPresenter.Field fieldFromMappedField = fields.Owner.GetFieldFromMappedField(alignmentFieldLayout.Fields[num2]);
							if (fieldFromMappedField != null)
							{
								return fieldFromMappedField;
							}
						}
					}
				}
			}
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

		// Token: 0x0600089F RID: 2207 RVA: 0x00026244 File Offset: 0x00024444
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

		// Token: 0x060008A0 RID: 2208 RVA: 0x000262A9 File Offset: 0x000244A9
		public static global::Infragistics.Windows.DataPresenter.FieldLayout GetFieldLayout(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null)
			{
				return null;
			}
			return field.Owner;
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x000262B8 File Offset: 0x000244B8
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

		// Token: 0x060008A2 RID: 2210 RVA: 0x000262FC File Offset: 0x000244FC
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

		// Token: 0x060008A3 RID: 2211 RVA: 0x0002634C File Offset: 0x0002454C
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

		// Token: 0x060008A4 RID: 2212 RVA: 0x000263B0 File Offset: 0x000245B0
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

		// Token: 0x060008A5 RID: 2213 RVA: 0x00026484 File Offset: 0x00024684
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

		// Token: 0x060008A6 RID: 2214 RVA: 0x000264F0 File Offset: 0x000246F0
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

		// Token: 0x060008A7 RID: 2215 RVA: 0x00026560 File Offset: 0x00024760
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

		// Token: 0x060008A8 RID: 2216 RVA: 0x00026570 File Offset: 0x00024770
		public static global::System.Windows.Rect GetElemRect(global::System.Windows.FrameworkElement ancestor, global::System.Windows.FrameworkElement elem)
		{
			global::System.Windows.Rect result = new global::System.Windows.Rect(elem.TranslatePoint(new global::System.Windows.Point(0.0, 0.0), ancestor), elem.RenderSize);
			return result;
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x000265AC File Offset: 0x000247AC
		internal static global::Infragistics.Windows.Controls.ExpansionIndicator GetExpansionIndicator(global::Infragistics.Windows.DataPresenter.RecordPresenter rp)
		{
			return global::Infragistics.Windows.Utilities.GetTemplateChild<global::Infragistics.Windows.Controls.ExpansionIndicator>(rp);
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x000265C4 File Offset: 0x000247C4
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

		// Token: 0x060008AB RID: 2219 RVA: 0x000265F9 File Offset: 0x000247F9
		internal static double GetNonPrimaryExtent(global::System.Windows.Size size, bool isVerticalOrientation)
		{
			if (isVerticalOrientation)
			{
				return size.Width;
			}
			return size.Height;
		}

		// Token: 0x060008AC RID: 2220 RVA: 0x00026610 File Offset: 0x00024810
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

		// Token: 0x060008AD RID: 2221 RVA: 0x0002666C File Offset: 0x0002486C
		internal static global::Infragistics.Windows.DataPresenter.RecordCollectionBase GetParentCollection(global::Infragistics.Windows.DataPresenter.RecordCollectionBase records)
		{
			global::Infragistics.Windows.DataPresenter.Record record = (records != null) ? records.ParentRecord : null;
			if (record == null)
			{
				return null;
			}
			return record.ParentCollection;
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x00026691 File Offset: 0x00024891
		internal static double GetPrimaryExtent(global::System.Windows.Size size, bool isVerticalOrientation)
		{
			if (isVerticalOrientation)
			{
				return size.Height;
			}
			return size.Width;
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x000266A8 File Offset: 0x000248A8
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

		// Token: 0x060008B0 RID: 2224 RVA: 0x0002673C File Offset: 0x0002493C
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

		// Token: 0x060008B1 RID: 2225 RVA: 0x000267A4 File Offset: 0x000249A4
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

		// Token: 0x060008B2 RID: 2226 RVA: 0x00026818 File Offset: 0x00024A18
		public static global::System.Collections.IEnumerable GetTrivialDescendants(global::System.Windows.DependencyObject elem)
		{
			global::System.Collections.Specialized.OrderedDictionary orderedDictionary = new global::System.Collections.Specialized.OrderedDictionary();
			orderedDictionary.Add(elem, elem);
			global::Infragistics.Windows.DataPresenter.GridUtilities.GetDescendantsHelper(elem, orderedDictionary);
			return orderedDictionary.Keys;
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00026840 File Offset: 0x00024A40
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

		// Token: 0x060008B4 RID: 2228 RVA: 0x00026930 File Offset: 0x00024B30
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

		// Token: 0x060008B5 RID: 2229 RVA: 0x000269AC File Offset: 0x00024BAC
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

		// Token: 0x060008B6 RID: 2230 RVA: 0x00026A10 File Offset: 0x00024C10
		internal static string GetValidationErrorText(global::System.Windows.Controls.ValidationError error)
		{
			string defaultString = (error.Exception != null) ? error.Exception.Message : null;
			return global::Infragistics.Windows.DataPresenter.GridUtilities.ToString(error.ErrorContent, defaultString);
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00026A40 File Offset: 0x00024C40
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

		// Token: 0x060008B8 RID: 2232 RVA: 0x00026AB0 File Offset: 0x00024CB0
		internal static global::Infragistics.Windows.DataPresenter.ViewBase GetView(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null)
			{
				return null;
			}
			return global::Infragistics.Windows.DataPresenter.GridUtilities.GetView(field.Owner);
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00026AC4 File Offset: 0x00024CC4
		internal static global::Infragistics.Windows.DataPresenter.ViewBase GetView(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenterBase = (fieldLayout != null) ? fieldLayout.DataPresenter : null;
			if (dataPresenterBase == null)
			{
				return null;
			}
			return dataPresenterBase.CurrentViewInternal;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00026AEC File Offset: 0x00024CEC
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

		// Token: 0x060008BB RID: 2235 RVA: 0x00026B58 File Offset: 0x00024D58
		internal static global::Infragistics.Windows.Helpers.HashSet ToSet(global::System.Collections.IEnumerable items)
		{
			global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet();
			hashSet.AddItems(items);
			return hashSet;
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00026B73 File Offset: 0x00024D73
		internal static bool HasSameItems(global::System.Collections.IEnumerable set1, global::System.Collections.IEnumerable set2)
		{
			return global::Infragistics.Windows.Helpers.HashSet.AreEqual(global::Infragistics.Windows.DataPresenter.GridUtilities.ToSet(set1), global::Infragistics.Windows.DataPresenter.GridUtilities.ToSet(set2));
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00026B86 File Offset: 0x00024D86
		internal static bool IncludesFixedButton(global::Infragistics.Windows.DataPresenter.FixedFieldUIType type)
		{
			return type == global::Infragistics.Windows.DataPresenter.FixedFieldUIType.ButtonAndSplitter || type == global::Infragistics.Windows.DataPresenter.FixedFieldUIType.Button;
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00026B94 File Offset: 0x00024D94
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

		// Token: 0x060008BF RID: 2239 RVA: 0x00026BC8 File Offset: 0x00024DC8
		internal static bool IsAddRecordTemplate(global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = record as global::Infragistics.Windows.DataPresenter.DataRecord;
			return dataRecord != null && dataRecord.IsAddRecordTemplate;
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00026BE8 File Offset: 0x00024DE8
		internal static bool IsLabelAboveBelowCell(global::Infragistics.Windows.DataPresenter.CellContentAlignment alignment)
		{
			bool result;
			bool flag;
			global::Infragistics.Windows.DataPresenter.GridUtilities.GetRelativeLabelPlacement(alignment, out result, out flag);
			return result;
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00026C00 File Offset: 0x00024E00
		internal static bool IsLabelLeftRightCell(global::Infragistics.Windows.DataPresenter.CellContentAlignment alignment)
		{
			bool flag;
			bool result;
			global::Infragistics.Windows.DataPresenter.GridUtilities.GetRelativeLabelPlacement(alignment, out flag, out result);
			return result;
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00026C18 File Offset: 0x00024E18
		internal static bool IsFixed(global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal fixedLocation)
		{
			return global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Top == fixedLocation || global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Bottom == fixedLocation;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00026C24 File Offset: 0x00024E24
		public static bool IsNullOrEmpty(object value)
		{
			if (value == null || global::System.DBNull.Value == value)
			{
				return true;
			}
			string text = value as string;
			return text != null && text.Length == 0;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00026C53 File Offset: 0x00024E53
		internal static bool IsObjectOfType(object obj, global::System.Type type)
		{
			return obj != null && global::Infragistics.Windows.DataPresenter.GridUtilities.IsObjectOfType(obj.GetType(), type);
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00026C66 File Offset: 0x00024E66
		internal static bool IsObjectOfType(global::System.Type objectType, global::System.Type typeToCheck)
		{
			return objectType == typeToCheck || typeToCheck.IsAssignableFrom(objectType);
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x00026C7C File Offset: 0x00024E7C
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

		// Token: 0x060008C7 RID: 2247 RVA: 0x00026CA8 File Offset: 0x00024EA8
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

		// Token: 0x060008C8 RID: 2248 RVA: 0x00026CD1 File Offset: 0x00024ED1
		internal static bool IsRecordOfType(global::Infragistics.Windows.DataPresenter.Record rcd, global::Infragistics.Windows.DataPresenter.RecordType rcdType)
		{
			return rcd != null && rcd.RecordType == rcdType && rcd.IsEnabledResolved && (rcdType != global::Infragistics.Windows.DataPresenter.RecordType.DataRecord || !((global::Infragistics.Windows.DataPresenter.DataRecord)rcd).IsAddRecordTemplate);
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00026D00 File Offset: 0x00024F00
		internal static bool IsRecordOfType(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.RecordType? rcdType, global::System.Type fallbackType)
		{
			if (rcdType != null)
			{
				return global::Infragistics.Windows.DataPresenter.GridUtilities.IsRecordOfType(record, rcdType.Value);
			}
			return record != null && fallbackType.IsAssignableFrom(record.GetType());
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00026D2C File Offset: 0x00024F2C
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

		// Token: 0x060008CB RID: 2251 RVA: 0x00026D74 File Offset: 0x00024F74
		internal static bool IsSerializable(object value)
		{
			return value != null && value.GetType().IsSerializable;
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00026D8C File Offset: 0x00024F8C
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

		// Token: 0x060008CD RID: 2253 RVA: 0x00026DF4 File Offset: 0x00024FF4
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

		// Token: 0x060008CE RID: 2254 RVA: 0x00026E30 File Offset: 0x00025030
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

		// Token: 0x060008CF RID: 2255 RVA: 0x00026E62 File Offset: 0x00025062
		internal static bool IsXmlNodeOptimized(object item)
		{
			return item != null && (global::Infragistics.Windows.DataPresenter.GridUtilities.s_isXmlAssemblyLoaded || item.GetType().FullName.StartsWith("System.Xml", global::System.StringComparison.Ordinal)) && global::Infragistics.Windows.DataPresenter.GridUtilities.IsXmlModeInternal(item);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00026E90 File Offset: 0x00025090
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private static bool IsXmlModeInternal(object item)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.s_isXmlAssemblyLoaded = true;
			return item is global::System.Xml.XmlNode;
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00026EA1 File Offset: 0x000250A1
		internal static void LogDebuggerError(string errorMsg)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.LogDebuggerError("Global", errorMsg);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00026EAE File Offset: 0x000250AE
		internal static void LogDebuggerError(string category, string errorMsg)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.LogDebuggerErrorHelper(category, errorMsg, 50);
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00026EB9 File Offset: 0x000250B9
		internal static void LogDebuggerWarning(string errorMsg)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.LogDebuggerWarning("Global", errorMsg);
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00026EC6 File Offset: 0x000250C6
		internal static void LogDebuggerWarning(string category, string errorMsg)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.LogDebuggerErrorHelper(category, errorMsg, 40);
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x00026ED1 File Offset: 0x000250D1
		private static void LogDebuggerErrorHelper(string category, string errorMsg, int level)
		{
			if (global::System.Diagnostics.Debugger.IsAttached && global::System.Diagnostics.Debugger.IsLogging())
			{
				global::System.Diagnostics.Debugger.Log(level, category, errorMsg);
			}
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x00026EEC File Offset: 0x000250EC
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

		// Token: 0x060008D7 RID: 2263 RVA: 0x00026FC8 File Offset: 0x000251C8
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

		// Token: 0x060008D8 RID: 2264 RVA: 0x00026FEB File Offset: 0x000251EB
		internal static void SuppressBringIntoView(global::System.Type classType)
		{
			global::System.Windows.EventManager.RegisterClassHandler(classType, global::System.Windows.FrameworkElement.RequestBringIntoViewEvent, new global::System.Windows.RequestBringIntoViewEventHandler(global::Infragistics.Windows.DataPresenter.GridUtilities.SuppressBringIntoViewImpl));
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x00027004 File Offset: 0x00025204
		private static void SuppressBringIntoViewImpl(object sender, global::System.Windows.RequestBringIntoViewEventArgs e)
		{
			if (e.OriginalSource == sender && e.TargetRect.IsEmpty)
			{
				e.Handled = true;
			}
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x00027034 File Offset: 0x00025234
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

		// Token: 0x060008DB RID: 2267 RVA: 0x000270D8 File Offset: 0x000252D8
		internal static void RaiseKeyNotFound()
		{
			throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_14"));
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x000270EC File Offset: 0x000252EC
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

		// Token: 0x060008DD RID: 2269 RVA: 0x00027134 File Offset: 0x00025334
		public static global::System.Collections.Generic.Dictionary<V, K> ReverseDictionary<K, V>(global::System.Collections.Generic.Dictionary<K, V> map)
		{
			global::System.Collections.Generic.Dictionary<V, K> dictionary = new global::System.Collections.Generic.Dictionary<V, K>();
			foreach (global::System.Collections.Generic.KeyValuePair<K, V> keyValuePair in map)
			{
				dictionary[keyValuePair.Value] = keyValuePair.Key;
			}
			return dictionary;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00027198 File Offset: 0x00025398
		internal static void SetCurrentValueIfSourceDefault(global::System.Windows.DependencyObject target, global::System.Windows.DependencyProperty property, object value)
		{
			if (global::System.Windows.DependencyPropertyHelper.GetValueSource(target, property).BaseValueSource == global::System.Windows.BaseValueSource.Default)
			{
				target.SetCurrentValue(property, value);
			}
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x000271C0 File Offset: 0x000253C0
		internal static void SetValue(bool[] arr, int startIndex, int count, bool value)
		{
			for (int i = 0; i < count; i++)
			{
				arr[startIndex + i] = value;
			}
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x000271E0 File Offset: 0x000253E0
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

		// Token: 0x060008E1 RID: 2273 RVA: 0x00027224 File Offset: 0x00025424
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

		// Token: 0x060008E2 RID: 2274 RVA: 0x00027270 File Offset: 0x00025470
		internal static void Swap(object[] arr, int i, int j)
		{
			object obj = arr[i];
			arr[i] = arr[j];
			arr[j] = obj;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x0002728C File Offset: 0x0002548C
		internal static void Swap(long[] arr, int i, int j)
		{
			long num = arr[i];
			arr[i] = arr[j];
			arr[j] = num;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x000272A8 File Offset: 0x000254A8
		internal static void Swap(global::Infragistics.Collections.SparseArray arr, int i, int j)
		{
			object value = arr[i];
			arr[i] = arr[j];
			arr[j] = value;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x000272D4 File Offset: 0x000254D4
		internal static void SwapValues(ref int x, ref int y)
		{
			int num = x;
			x = y;
			y = num;
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x000272EC File Offset: 0x000254EC
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

		// Token: 0x060008E7 RID: 2279 RVA: 0x0002734C File Offset: 0x0002554C
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

		// Token: 0x060008E8 RID: 2280 RVA: 0x000273B4 File Offset: 0x000255B4
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

		// Token: 0x060008E9 RID: 2281 RVA: 0x000273E0 File Offset: 0x000255E0
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

		// Token: 0x060008EA RID: 2282 RVA: 0x00027444 File Offset: 0x00025644
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

		// Token: 0x060008EB RID: 2283 RVA: 0x000274B4 File Offset: 0x000256B4
		internal static string ToString(object obj, string defaultString)
		{
			return global::Infragistics.Windows.DataPresenter.GridUtilities.ToString(obj, defaultString, null);
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x000274C0 File Offset: 0x000256C0
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

		// Token: 0x060008ED RID: 2285 RVA: 0x0002750C File Offset: 0x0002570C
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

		// Token: 0x060008EE RID: 2286 RVA: 0x000275B4 File Offset: 0x000257B4
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

		// Token: 0x060008EF RID: 2287 RVA: 0x00027654 File Offset: 0x00025854
		private static bool IsEnumFlags(global::System.Type enumType)
		{
			object[] customAttributes = enumType.GetCustomAttributes(typeof(global::System.FlagsAttribute), true);
			return customAttributes != null && customAttributes.Length > 0;
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x0002767E File Offset: 0x0002587E
		internal static void ValidateEnum(global::System.Type enumType, object enumVal)
		{
			if (!global::System.Enum.IsDefined(enumType, enumVal) && !global::Infragistics.Windows.DataPresenter.GridUtilities.IsEnumFlags(enumType))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException(enumType.Name, (int)enumVal, enumType);
			}
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x000276A4 File Offset: 0x000258A4
		internal static void ValidateEnum(string argumentName, global::System.Type enumType, object enumVal)
		{
			if (!global::System.Enum.IsDefined(enumType, enumVal) && !global::Infragistics.Windows.DataPresenter.GridUtilities.IsEnumFlags(enumType))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException(argumentName, (int)enumVal, enumType);
			}
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x000276C8 File Offset: 0x000258C8
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

		// Token: 0x060008F3 RID: 2291 RVA: 0x000276FC File Offset: 0x000258FC
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

		// Token: 0x060008F4 RID: 2292 RVA: 0x00027736 File Offset: 0x00025936
		public static bool ValidateNonNegativeInt(object newValue)
		{
			return !(newValue is int) || (int)newValue >= 0;
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x0002774C File Offset: 0x0002594C
		public static void ValidateNotNull(object value)
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException();
			}
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00027757 File Offset: 0x00025957
		public static void ValidateNotNull(object value, string paramName)
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException(paramName);
			}
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00027764 File Offset: 0x00025964
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

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x00027796 File Offset: 0x00025996
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

		// Token: 0x060008F9 RID: 2297 RVA: 0x000277AE File Offset: 0x000259AE
		public static global::Infragistics.Windows.DataPresenter.CellContentAlignment GetCellContentAlignment(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.DataPresenter.CellContentAlignment)d.GetValue(global::Infragistics.Windows.DataPresenter.GridUtilities.CellContentAlignmentProperty);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x000277C0 File Offset: 0x000259C0
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

		// Token: 0x060008FB RID: 2299 RVA: 0x000277F9 File Offset: 0x000259F9
		private static void OnCellContentAlignmentChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00027806 File Offset: 0x00025A06
		public static global::System.Windows.Visibility GetFieldVisibility(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.Visibility)d.GetValue(global::Infragistics.Windows.DataPresenter.GridUtilities.FieldVisibilityProperty);
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00027818 File Offset: 0x00025A18
		private static object OnCoerceFieldVisibility(global::System.Windows.DependencyObject d, object newValue)
		{
			return global::Infragistics.KnownBoxes.FromValue((global::System.Windows.Visibility)newValue);
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00027825 File Offset: 0x00025A25
		private static void OnFieldVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x00027832 File Offset: 0x00025A32
		internal static global::System.Globalization.CultureInfo StringCompareCulture
		{
			get
			{
				return global::System.Globalization.CultureInfo.CurrentCulture;
			}
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x0002783C File Offset: 0x00025A3C
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

		// Token: 0x06000901 RID: 2305 RVA: 0x000278C4 File Offset: 0x00025AC4
		private static void ProcessAsyncInvalidations()
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ProcessAsyncInvalidationsImpl();
			int num = 0;
			while (global::Infragistics.Windows.DataPresenter.GridUtilities._QueuedMeasureInvalidations.Count > 0)
			{
				if (num >= 100)
				{
					global::Infragistics.Windows.DataPresenter.GridUtilities._QueuedMeasureInvalidations.Clear();
					return;
				}
				num++;
				global::Infragistics.Windows.DataPresenter.GridUtilities.ProcessAsyncInvalidationsImpl();
			}
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00027904 File Offset: 0x00025B04
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

		// Token: 0x0400037D RID: 893
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Helpers.HashSet _QueuedMeasureInvalidations;

		// Token: 0x0400037E RID: 894
		private static bool s_isXmlAssemblyLoaded = false;

		// Token: 0x0400037F RID: 895
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility g_antirecursionUtility;

		// Token: 0x04000380 RID: 896
		private static readonly object CellContentAlignmentLabelOnly = global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelOnly;

		// Token: 0x04000381 RID: 897
		private static readonly object CellContentAlignmentValueOnly = global::Infragistics.Windows.DataPresenter.CellContentAlignment.ValueOnly;

		// Token: 0x04000382 RID: 898
		private static readonly object CellContentAlignmentDefault = global::Infragistics.Windows.DataPresenter.CellContentAlignment.Default;

		// Token: 0x04000383 RID: 899
		public static readonly global::System.Windows.DependencyProperty CellContentAlignmentProperty = global::System.Windows.DependencyProperty.RegisterAttached("CellContentAlignment", typeof(global::Infragistics.Windows.DataPresenter.CellContentAlignment), typeof(global::Infragistics.Windows.DataPresenter.GridUtilities), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.GridUtilities.CellContentAlignmentDefault, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GridUtilities.OnCellContentAlignmentChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GridUtilities.OnCoerceCellContentAlignment)));

		// Token: 0x04000384 RID: 900
		public static readonly global::System.Windows.DependencyProperty FieldVisibilityProperty = global::System.Windows.DependencyProperty.RegisterAttached("FieldVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.GridUtilities), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.GridUtilities.OnFieldVisibilityChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.GridUtilities.OnCoerceFieldVisibility)));

		// Token: 0x020000A7 RID: 167
		public class AggregateComparer<T> : global::System.Collections.Generic.IComparer<T>, global::System.Collections.IComparer
		{
			// Token: 0x06000904 RID: 2308 RVA: 0x00027A52 File Offset: 0x00025C52
			public AggregateComparer(params global::System.Collections.Generic.IComparer<T>[] comparers)
			{
				this._comparers = comparers;
			}

			// Token: 0x06000905 RID: 2309 RVA: 0x00027A64 File Offset: 0x00025C64
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

			// Token: 0x06000906 RID: 2310 RVA: 0x00027A9C File Offset: 0x00025C9C
			int global::System.Collections.IComparer.Compare(object x, object y)
			{
				return this.Compare((T)((object)x), (T)((object)y));
			}

			// Token: 0x04000385 RID: 901
			private global::System.Collections.Generic.IComparer<T>[] _comparers;
		}

		// Token: 0x020000A8 RID: 168
		public class AggregateEnumerable<T> : global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable
		{
			// Token: 0x06000907 RID: 2311 RVA: 0x00027AB0 File Offset: 0x00025CB0
			public AggregateEnumerable(params global::System.Collections.Generic.IEnumerable<T>[] enumerables)
			{
				this._enumerables = enumerables;
			}

			// Token: 0x06000908 RID: 2312 RVA: 0x00027ABF File Offset: 0x00025CBF
			public global::System.Collections.IEnumerator GetEnumerator()
			{
				return new global::Infragistics.Windows.DataPresenter.GridUtilities.AggregateEnumerable<T>.Enumerator(this._enumerables);
			}

			// Token: 0x06000909 RID: 2313 RVA: 0x00027ACC File Offset: 0x00025CCC
			global::System.Collections.Generic.IEnumerator<T> global::System.Collections.Generic.IEnumerable<!0>.GetEnumerator()
			{
				return new global::Infragistics.Windows.DataPresenter.GridUtilities.AggregateEnumerable<T>.Enumerator(this._enumerables);
			}

			// Token: 0x04000386 RID: 902
			private global::System.Collections.Generic.IEnumerable<T>[] _enumerables;

			// Token: 0x020000A9 RID: 169
			public class Enumerator : global::System.Collections.Generic.IEnumerator<T>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x0600090A RID: 2314 RVA: 0x00027AD9 File Offset: 0x00025CD9
				public Enumerator(params global::System.Collections.Generic.IEnumerable<T>[] enumerables)
				{
					this._enumerables = enumerables;
					this.Reset();
				}

				// Token: 0x0600090B RID: 2315 RVA: 0x00027AEE File Offset: 0x00025CEE
				public void Reset()
				{
					this._index = -1;
					this._current = null;
				}

				// Token: 0x0600090C RID: 2316 RVA: 0x00027B00 File Offset: 0x00025D00
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

				// Token: 0x1700021B RID: 539
				// (get) Token: 0x0600090D RID: 2317 RVA: 0x00027B80 File Offset: 0x00025D80
				public object Current
				{
					get
					{
						return (this._current != null) ? this._current.Current : default(T);
					}
				}

				// Token: 0x1700021C RID: 540
				// (get) Token: 0x0600090E RID: 2318 RVA: 0x00027BB0 File Offset: 0x00025DB0
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

				// Token: 0x0600090F RID: 2319 RVA: 0x00027BDA File Offset: 0x00025DDA
				public void Dispose()
				{
				}

				// Token: 0x04000387 RID: 903
				private global::System.Collections.Generic.IEnumerable<T>[] _enumerables;

				// Token: 0x04000388 RID: 904
				private int _index;

				// Token: 0x04000389 RID: 905
				private global::System.Collections.Generic.IEnumerator<T> _current;
			}
		}

		// Token: 0x020000AA RID: 170
		internal class AntirecursionUtility
		{
			// Token: 0x1700021D RID: 541
			// (get) Token: 0x06000910 RID: 2320 RVA: 0x00027BDC File Offset: 0x00025DDC
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

			// Token: 0x06000911 RID: 2321 RVA: 0x00027BF8 File Offset: 0x00025DF8
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

			// Token: 0x06000912 RID: 2322 RVA: 0x00027C38 File Offset: 0x00025E38
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

			// Token: 0x06000913 RID: 2323 RVA: 0x00027C89 File Offset: 0x00025E89
			public bool InProgress(object item, object flagId)
			{
				return this._map != null && this._map.ContainsKey(new global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility.ID(item, flagId));
			}

			// Token: 0x0400038A RID: 906
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility.ID, int> _map;

			// Token: 0x020000AB RID: 171
			private struct ID
			{
				// Token: 0x06000915 RID: 2325 RVA: 0x00027CAF File Offset: 0x00025EAF
				internal ID(object item, object flagId)
				{
					this._item = item;
					this._flagId = flagId;
				}

				// Token: 0x06000916 RID: 2326 RVA: 0x00027CBF File Offset: 0x00025EBF
				internal static int GetHashCode(object o)
				{
					if (o == null)
					{
						return 0;
					}
					return o.GetHashCode();
				}

				// Token: 0x06000917 RID: 2327 RVA: 0x00027CCC File Offset: 0x00025ECC
				public override int GetHashCode()
				{
					return global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility.ID.GetHashCode(this._item) ^ global::Infragistics.Windows.DataPresenter.GridUtilities.AntirecursionUtility.ID.GetHashCode(this._flagId);
				}

				// Token: 0x06000918 RID: 2328 RVA: 0x00027CE8 File Offset: 0x00025EE8
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

				// Token: 0x0400038B RID: 907
				internal object _item;

				// Token: 0x0400038C RID: 908
				internal object _flagId;
			}
		}

		// Token: 0x020000AC RID: 172
		public class ConverterEnumerable<TInput, TOutput> : global::System.Collections.Generic.IEnumerable<TOutput>, global::System.Collections.IEnumerable
		{
			// Token: 0x06000919 RID: 2329 RVA: 0x00027D25 File Offset: 0x00025F25
			public ConverterEnumerable(global::System.Collections.Generic.IEnumerable<TInput> e, global::System.Converter<TInput, TOutput> converter)
			{
				this._e = e;
				this._converter = converter;
			}

			// Token: 0x0600091A RID: 2330 RVA: 0x00027D3B File Offset: 0x00025F3B
			public global::System.Collections.Generic.IEnumerator<TOutput> GetEnumerator()
			{
				return new global::Infragistics.Windows.DataPresenter.GridUtilities.ConverterEnumerator<TInput, TOutput>(this._e.GetEnumerator(), this._converter);
			}

			// Token: 0x0600091B RID: 2331 RVA: 0x00027D53 File Offset: 0x00025F53
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x0400038D RID: 909
			private global::System.Collections.Generic.IEnumerable<TInput> _e;

			// Token: 0x0400038E RID: 910
			private global::System.Converter<TInput, TOutput> _converter;
		}

		// Token: 0x020000AD RID: 173
		public class ConverterEnumerator<TInput, TOutput> : global::System.Collections.Generic.IEnumerator<TOutput>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x0600091C RID: 2332 RVA: 0x00027D5B File Offset: 0x00025F5B
			public ConverterEnumerator(global::System.Collections.Generic.IEnumerator<TInput> e, global::System.Converter<TInput, TOutput> converter)
			{
				this._e = e;
				this._converter = converter;
			}

			// Token: 0x0600091D RID: 2333 RVA: 0x00027D71 File Offset: 0x00025F71
			public void Reset()
			{
				this._e.Reset();
			}

			// Token: 0x0600091E RID: 2334 RVA: 0x00027D7E File Offset: 0x00025F7E
			public bool MoveNext()
			{
				return this._e.MoveNext();
			}

			// Token: 0x1700021E RID: 542
			// (get) Token: 0x0600091F RID: 2335 RVA: 0x00027D8B File Offset: 0x00025F8B
			public TOutput Current
			{
				get
				{
					return this._converter(this._e.Current);
				}
			}

			// Token: 0x1700021F RID: 543
			// (get) Token: 0x06000920 RID: 2336 RVA: 0x00027DA3 File Offset: 0x00025FA3
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x06000921 RID: 2337 RVA: 0x00027DB0 File Offset: 0x00025FB0
			public void Dispose()
			{
			}

			// Token: 0x0400038F RID: 911
			private global::System.Collections.Generic.IEnumerator<TInput> _e;

			// Token: 0x04000390 RID: 912
			private global::System.Converter<TInput, TOutput> _converter;
		}

		// Token: 0x020000AE RID: 174
		public class EmptyEnumerable<T> : global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable
		{
			// Token: 0x06000923 RID: 2339 RVA: 0x00027DBA File Offset: 0x00025FBA
			public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
			{
				return new global::Infragistics.Windows.DataPresenter.GridUtilities.EmptyEnumerable<T>.Enumerator();
			}

			// Token: 0x06000924 RID: 2340 RVA: 0x00027DC1 File Offset: 0x00025FC1
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x020000AF RID: 175
			public class Enumerator : global::System.Collections.Generic.IEnumerator<!0>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x17000220 RID: 544
				// (get) Token: 0x06000926 RID: 2342 RVA: 0x00027DD1 File Offset: 0x00025FD1
				public T Current
				{
					get
					{
						throw new global::System.InvalidOperationException();
					}
				}

				// Token: 0x06000927 RID: 2343 RVA: 0x00027DD8 File Offset: 0x00025FD8
				public void Dispose()
				{
				}

				// Token: 0x17000221 RID: 545
				// (get) Token: 0x06000928 RID: 2344 RVA: 0x00027DDA File Offset: 0x00025FDA
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						throw new global::System.InvalidOperationException();
					}
				}

				// Token: 0x06000929 RID: 2345 RVA: 0x00027DE1 File Offset: 0x00025FE1
				public bool MoveNext()
				{
					return false;
				}

				// Token: 0x0600092A RID: 2346 RVA: 0x00027DE4 File Offset: 0x00025FE4
				public void Reset()
				{
				}
			}
		}

		// Token: 0x020000B0 RID: 176
		public class EnumeratorCollection<T> : global::System.Collections.Generic.ICollection<T>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable
		{
			// Token: 0x0600092B RID: 2347 RVA: 0x00027DE6 File Offset: 0x00025FE6
			public EnumeratorCollection(global::System.Collections.Generic.IEnumerable<T> enumerable, int count)
			{
				this._enumerable = enumerable;
				this._count = count;
			}

			// Token: 0x0600092C RID: 2348 RVA: 0x00027DFC File Offset: 0x00025FFC
			public void Add(T item)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x0600092D RID: 2349 RVA: 0x00027E03 File Offset: 0x00026003
			public void Clear()
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x0600092E RID: 2350 RVA: 0x00027E0A File Offset: 0x0002600A
			public bool Contains(T item)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x0600092F RID: 2351 RVA: 0x00027E11 File Offset: 0x00026011
			public void CopyTo(T[] array, int arrayIndex)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.CopyTo<T>(this._enumerable, array, arrayIndex);
			}

			// Token: 0x17000222 RID: 546
			// (get) Token: 0x06000930 RID: 2352 RVA: 0x00027E20 File Offset: 0x00026020
			public int Count
			{
				get
				{
					return this._count;
				}
			}

			// Token: 0x17000223 RID: 547
			// (get) Token: 0x06000931 RID: 2353 RVA: 0x00027E28 File Offset: 0x00026028
			public bool IsReadOnly
			{
				get
				{
					return true;
				}
			}

			// Token: 0x06000932 RID: 2354 RVA: 0x00027E2B File Offset: 0x0002602B
			public bool Remove(T item)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x06000933 RID: 2355 RVA: 0x00027E32 File Offset: 0x00026032
			public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
			{
				return this._enumerable.GetEnumerator();
			}

			// Token: 0x06000934 RID: 2356 RVA: 0x00027E3F File Offset: 0x0002603F
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this._enumerable.GetEnumerator();
			}

			// Token: 0x04000391 RID: 913
			private global::System.Collections.Generic.IEnumerable<T> _enumerable;

			// Token: 0x04000392 RID: 914
			private int _count;
		}

		// Token: 0x020000B1 RID: 177
		internal interface IMeetsCriteria
		{
			// Token: 0x06000935 RID: 2357
			bool MeetsCriteria(object item);
		}

		// Token: 0x020000B2 RID: 178
		internal class InvalidateStylesAsyncInfo
		{
			// Token: 0x04000393 RID: 915
			internal bool _bumpVersion;

			// Token: 0x04000394 RID: 916
			internal bool _regenerateTemplates;

			// Token: 0x04000395 RID: 917
			internal global::System.Windows.Threading.DispatcherOperation _dispatcherOperation;

			// Token: 0x04000396 RID: 918
			internal bool _bumpSpecialRecordsVersion;
		}

		// Token: 0x020000B3 RID: 179
		internal class MeetsCriteria_RecordFieldLayout : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
		{
			// Token: 0x06000937 RID: 2359 RVA: 0x00027E54 File Offset: 0x00026054
			internal MeetsCriteria_RecordFieldLayout(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
			{
				this._fieldLayout = fieldLayout;
			}

			// Token: 0x06000938 RID: 2360 RVA: 0x00027E64 File Offset: 0x00026064
			public bool MeetsCriteria(object item)
			{
				global::Infragistics.Windows.DataPresenter.Record record = (global::Infragistics.Windows.DataPresenter.Record)item;
				return this._fieldLayout == record.FieldLayout;
			}

			// Token: 0x04000397 RID: 919
			private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;
		}

		// Token: 0x020000B4 RID: 180
		internal class MeetsCriteria_FilteredInRecords : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
		{
			// Token: 0x06000939 RID: 2361 RVA: 0x00027E86 File Offset: 0x00026086
			public bool MeetsCriteria(object item)
			{
				return !((global::Infragistics.Windows.DataPresenter.Record)item).InternalIsFilteredOut_Verify;
			}
		}

		// Token: 0x020000B5 RID: 181
		internal class MeetsCriteria_RecordType : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
		{
			// Token: 0x0600093B RID: 2363 RVA: 0x00027E9E File Offset: 0x0002609E
			internal MeetsCriteria_RecordType(global::Infragistics.Windows.DataPresenter.RecordType recordType)
			{
				this._recordType = recordType;
			}

			// Token: 0x0600093C RID: 2364 RVA: 0x00027EB0 File Offset: 0x000260B0
			public bool MeetsCriteria(object item)
			{
				global::Infragistics.Windows.DataPresenter.Record record = (global::Infragistics.Windows.DataPresenter.Record)item;
				return this._recordType == record.RecordType;
			}

			// Token: 0x04000398 RID: 920
			private global::Infragistics.Windows.DataPresenter.RecordType _recordType;
		}

		// Token: 0x020000B6 RID: 182
		internal class MeetsCriteria_RecordVisible : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
		{
			// Token: 0x0600093D RID: 2365 RVA: 0x00027ED2 File Offset: 0x000260D2
			internal MeetsCriteria_RecordVisible() : this(false)
			{
			}

			// Token: 0x0600093E RID: 2366 RVA: 0x00027EDB File Offset: 0x000260DB
			internal MeetsCriteria_RecordVisible(bool ignoreFilteringLogic)
			{
				this._ignoreFilteringLogic = ignoreFilteringLogic;
			}

			// Token: 0x0600093F RID: 2367 RVA: 0x00027EEC File Offset: 0x000260EC
			public bool MeetsCriteria(object item)
			{
				global::Infragistics.Windows.DataPresenter.Record record = (global::Infragistics.Windows.DataPresenter.Record)item;
				global::System.Windows.Visibility visibility = this._ignoreFilteringLogic ? record.VisibilityResolved_NoFiltering : record.VisibilityResolved;
				return global::System.Windows.Visibility.Visible == visibility;
			}

			// Token: 0x04000399 RID: 921
			private bool _ignoreFilteringLogic;
		}

		// Token: 0x020000B7 RID: 183
		internal class MeetsCriteria_Type : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
		{
			// Token: 0x06000940 RID: 2368 RVA: 0x00027F1B File Offset: 0x0002611B
			internal MeetsCriteria_Type(global::System.Type type, bool allowSubtypes)
			{
				this._type = type;
				this._allowSubtypes = allowSubtypes;
			}

			// Token: 0x06000941 RID: 2369 RVA: 0x00027F31 File Offset: 0x00026131
			public bool MeetsCriteria(object item)
			{
				if (!this._allowSubtypes)
				{
					return item != null && this._type == item.GetType();
				}
				return global::Infragistics.Windows.DataPresenter.GridUtilities.IsObjectOfType(item, this._type);
			}

			// Token: 0x0400039A RID: 922
			private global::System.Type _type;

			// Token: 0x0400039B RID: 923
			private bool _allowSubtypes;
		}

		// Token: 0x020000B8 RID: 184
		internal class MeetsCriteria_Predicate<T> : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
		{
			// Token: 0x06000942 RID: 2370 RVA: 0x00027F5E File Offset: 0x0002615E
			internal MeetsCriteria_Predicate(global::System.Predicate<T> predicate)
			{
				this._predicate = predicate;
			}

			// Token: 0x06000943 RID: 2371 RVA: 0x00027F6D File Offset: 0x0002616D
			public bool MeetsCriteria(object item)
			{
				return item is T && this._predicate((T)((object)item));
			}

			// Token: 0x0400039C RID: 924
			private global::System.Predicate<T> _predicate;
		}

		// Token: 0x020000B9 RID: 185
		internal class MeetsCriteriaChain : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
		{
			// Token: 0x06000944 RID: 2372 RVA: 0x00027F8C File Offset: 0x0002618C
			internal MeetsCriteriaChain(global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria x, global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria y, bool combineUsingOr) : this(new global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria[]
			{
				x,
				y
			}, combineUsingOr)
			{
			}

			// Token: 0x06000945 RID: 2373 RVA: 0x00027FB0 File Offset: 0x000261B0
			internal MeetsCriteriaChain(global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria[] arr, bool combineUsingOr)
			{
				this._arr = arr;
				this._combineUsingOr = combineUsingOr;
			}

			// Token: 0x06000946 RID: 2374 RVA: 0x00027FC8 File Offset: 0x000261C8
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

			// Token: 0x0400039D RID: 925
			private global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria[] _arr;

			// Token: 0x0400039E RID: 926
			private bool _combineUsingOr;
		}

		// Token: 0x020000BA RID: 186
		internal class MeetsCriteriaComplement : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
		{
			// Token: 0x06000947 RID: 2375 RVA: 0x00028012 File Offset: 0x00026212
			internal MeetsCriteriaComplement(global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria i)
			{
				this._i = i;
			}

			// Token: 0x06000948 RID: 2376 RVA: 0x00028021 File Offset: 0x00026221
			public bool MeetsCriteria(object item)
			{
				return !this._i.MeetsCriteria(item);
			}

			// Token: 0x0400039F RID: 927
			private global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria _i;
		}

		// Token: 0x020000BB RID: 187
		internal class MeetsCriteriaEnumerator<T> : global::System.Collections.Generic.IEnumerator<!0>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06000949 RID: 2377 RVA: 0x00028032 File Offset: 0x00026232
			internal MeetsCriteriaEnumerator(global::System.Collections.Generic.IEnumerator<T> enumerator, global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria meetsCriteriaCallback)
			{
				this._enumerator = enumerator;
				this._meetsCriteriaCallback = meetsCriteriaCallback;
			}

			// Token: 0x0600094A RID: 2378 RVA: 0x00028048 File Offset: 0x00026248
			public void Reset()
			{
				this._enumerator.Reset();
				this._currentItem = default(T);
			}

			// Token: 0x0600094B RID: 2379 RVA: 0x00028064 File Offset: 0x00026264
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

			// Token: 0x17000224 RID: 548
			// (get) Token: 0x0600094C RID: 2380 RVA: 0x000280B6 File Offset: 0x000262B6
			public T Current
			{
				get
				{
					return this._currentItem;
				}
			}

			// Token: 0x17000225 RID: 549
			// (get) Token: 0x0600094D RID: 2381 RVA: 0x000280BE File Offset: 0x000262BE
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this._currentItem;
				}
			}

			// Token: 0x0600094E RID: 2382 RVA: 0x000280CB File Offset: 0x000262CB
			public void Dispose()
			{
				this.Reset();
			}

			// Token: 0x040003A0 RID: 928
			private global::System.Collections.Generic.IEnumerator<T> _enumerator;

			// Token: 0x040003A1 RID: 929
			private global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria _meetsCriteriaCallback;

			// Token: 0x040003A2 RID: 930
			private T _currentItem;

			// Token: 0x020000BC RID: 188
			internal class Enumerable : global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable
			{
				// Token: 0x0600094F RID: 2383 RVA: 0x000280D3 File Offset: 0x000262D3
				internal Enumerable(global::System.Collections.Generic.IEnumerable<T> e, global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria i)
				{
					this._e = (e ?? ((global::System.Collections.Generic.IEnumerable<!0>)new T[0]));
					this._i = i;
				}

				// Token: 0x06000950 RID: 2384 RVA: 0x000280F8 File Offset: 0x000262F8
				internal Enumerable(global::System.Collections.Generic.IEnumerable<T> e, global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria[] criteria, bool combineUsingOr) : this(e, new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteriaChain(criteria, combineUsingOr))
				{
				}

				// Token: 0x06000951 RID: 2385 RVA: 0x00028108 File Offset: 0x00026308
				public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
				{
					return new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteriaEnumerator<T>(this._e.GetEnumerator(), this._i);
				}

				// Token: 0x06000952 RID: 2386 RVA: 0x00028120 File Offset: 0x00026320
				global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
				{
					return this.GetEnumerator();
				}

				// Token: 0x040003A3 RID: 931
				private global::System.Collections.Generic.IEnumerable<T> _e;

				// Token: 0x040003A4 RID: 932
				private global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria _i;
			}
		}

		// Token: 0x020000BD RID: 189
		internal class MeetsCriteriaExcludeSingleItem : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
		{
			// Token: 0x06000953 RID: 2387 RVA: 0x00028128 File Offset: 0x00026328
			internal MeetsCriteriaExcludeSingleItem(object item)
			{
				this._item = item;
			}

			// Token: 0x06000954 RID: 2388 RVA: 0x00028137 File Offset: 0x00026337
			public bool MeetsCriteria(object o)
			{
				return this._item != o;
			}

			// Token: 0x040003A5 RID: 933
			private object _item;
		}

		// Token: 0x020000BE RID: 190
		// (Invoke) Token: 0x06000956 RID: 2390
		internal delegate void MethodDelegate();

		// Token: 0x020000BF RID: 191
		internal class NotifyCollectionEnumerable<T> : global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged
		{
			// Token: 0x06000959 RID: 2393 RVA: 0x00028145 File Offset: 0x00026345
			public NotifyCollectionEnumerable(global::System.Collections.Generic.IEnumerable<T> sourceItems) : this(sourceItems, null)
			{
			}

			// Token: 0x0600095A RID: 2394 RVA: 0x0002814F File Offset: 0x0002634F
			public NotifyCollectionEnumerable(global::System.Collections.Generic.IEnumerable<T> sourceItems, global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria filter)
			{
				this._sourceItems = sourceItems;
				this._filter = filter;
			}

			// Token: 0x17000226 RID: 550
			// (get) Token: 0x0600095B RID: 2395 RVA: 0x00028165 File Offset: 0x00026365
			// (set) Token: 0x0600095C RID: 2396 RVA: 0x0002816D File Offset: 0x0002636D
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

			// Token: 0x17000227 RID: 551
			// (get) Token: 0x0600095D RID: 2397 RVA: 0x00028176 File Offset: 0x00026376
			// (set) Token: 0x0600095E RID: 2398 RVA: 0x0002817E File Offset: 0x0002637E
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

			// Token: 0x0600095F RID: 2399 RVA: 0x00028196 File Offset: 0x00026396
			public void RaiseCollectionChanged()
			{
				if (this.CollectionChanged != null)
				{
					this.CollectionChanged(this, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
				}
			}

			// Token: 0x14000006 RID: 6
			// (add) Token: 0x06000960 RID: 2400 RVA: 0x000281B4 File Offset: 0x000263B4
			// (remove) Token: 0x06000961 RID: 2401 RVA: 0x000281EC File Offset: 0x000263EC
			public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

			// Token: 0x06000962 RID: 2402 RVA: 0x00028224 File Offset: 0x00026424
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

			// Token: 0x06000963 RID: 2403 RVA: 0x00028274 File Offset: 0x00026474
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x040003A6 RID: 934
			private global::System.Collections.Generic.IEnumerable<T> _sourceItems;

			// Token: 0x040003A7 RID: 935
			private global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria _filter;

			// Token: 0x040003A8 RID: 936
			private object _tag;
		}

		// Token: 0x020000C0 RID: 192
		public struct Range
		{
			// Token: 0x06000964 RID: 2404 RVA: 0x0002827C File Offset: 0x0002647C
			public Range(int start, int end)
			{
				this._start = start;
				this._end = end;
			}

			// Token: 0x17000228 RID: 552
			// (get) Token: 0x06000965 RID: 2405 RVA: 0x0002828C File Offset: 0x0002648C
			// (set) Token: 0x06000966 RID: 2406 RVA: 0x00028294 File Offset: 0x00026494
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

			// Token: 0x17000229 RID: 553
			// (get) Token: 0x06000967 RID: 2407 RVA: 0x0002829D File Offset: 0x0002649D
			// (set) Token: 0x06000968 RID: 2408 RVA: 0x000282A5 File Offset: 0x000264A5
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

			// Token: 0x040003AA RID: 938
			private int _start;

			// Token: 0x040003AB RID: 939
			private int _end;
		}

		// Token: 0x020000C1 RID: 193
		internal class RecordContentMarginConverter : global::System.Windows.Data.IMultiValueConverter
		{
			// Token: 0x06000969 RID: 2409 RVA: 0x000282B0 File Offset: 0x000264B0
			static RecordContentMarginConverter()
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.RecordContentMarginConverter.instance = new global::Infragistics.Windows.DataPresenter.GridUtilities.RecordContentMarginConverter();
			}

			// Token: 0x0600096A RID: 2410 RVA: 0x00028308 File Offset: 0x00026508
			private RecordContentMarginConverter()
			{
			}

			// Token: 0x1700022A RID: 554
			// (get) Token: 0x0600096B RID: 2411 RVA: 0x00028310 File Offset: 0x00026510
			internal static global::System.Windows.Data.IMultiValueConverter Instance
			{
				get
				{
					return global::Infragistics.Windows.DataPresenter.GridUtilities.RecordContentMarginConverter.instance;
				}
			}

			// Token: 0x0600096C RID: 2412 RVA: 0x00028318 File Offset: 0x00026518
			internal static void BumpVersion(global::System.Windows.DependencyObject d)
			{
				int num = (int)d.GetValue(global::Infragistics.Windows.DataPresenter.GridUtilities.RecordContentMarginConverter.VersionProperty);
				d.SetValue(global::Infragistics.Windows.DataPresenter.GridUtilities.RecordContentMarginConverter.VersionProperty, num + 1);
			}

			// Token: 0x0600096D RID: 2413 RVA: 0x0002834C File Offset: 0x0002654C
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
						num += fieldLayout.GetRecordSelectorExtent(record);
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

			// Token: 0x0600096E RID: 2414 RVA: 0x00028560 File Offset: 0x00026760
			public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
			{
				return new object[]
				{
					global::System.Windows.Data.Binding.DoNothing,
					global::System.Windows.Data.Binding.DoNothing
				};
			}

			// Token: 0x040003AC RID: 940
			private static readonly object PositiveInfinity = double.PositiveInfinity;

			// Token: 0x040003AD RID: 941
			private static readonly global::Infragistics.Windows.DataPresenter.GridUtilities.RecordContentMarginConverter instance;

			// Token: 0x040003AE RID: 942
			internal static readonly global::System.Windows.DependencyProperty VersionProperty = global::System.Windows.DependencyProperty.RegisterAttached("Version", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.GridUtilities.RecordContentMarginConverter), new global::System.Windows.FrameworkPropertyMetadata(0));
		}

		// Token: 0x020000C2 RID: 194
		internal class RecordSelectorExtentConverter : global::System.Windows.Data.IMultiValueConverter
		{
			// Token: 0x06000970 RID: 2416 RVA: 0x00028591 File Offset: 0x00026791
			private RecordSelectorExtentConverter()
			{
			}

			// Token: 0x1700022B RID: 555
			// (get) Token: 0x06000971 RID: 2417 RVA: 0x00028599 File Offset: 0x00026799
			internal static global::System.Windows.Data.IMultiValueConverter Instance
			{
				get
				{
					return global::Infragistics.Windows.DataPresenter.GridUtilities.RecordSelectorExtentConverter.instance;
				}
			}

			// Token: 0x06000972 RID: 2418 RVA: 0x000285A0 File Offset: 0x000267A0
			public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
			{
				double num = 0.0;
				object[] array = parameter as object[];
				bool flag = (bool)array[0];
				global::System.Type type = (global::System.Type)array[1];
				global::System.Windows.FrameworkElement frameworkElement = values[0] as global::System.Windows.FrameworkElement;
				if (frameworkElement == null)
				{
					return 0;
				}
				global::Infragistics.Windows.DataPresenter.RecordSelector recordSelector = frameworkElement as global::Infragistics.Windows.DataPresenter.RecordSelector;
				global::Infragistics.Windows.DataPresenter.Record record = null;
				if (recordSelector != null)
				{
					record = recordSelector.Record;
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.RecordPrefixArea recordPrefixArea = frameworkElement as global::Infragistics.Windows.DataPresenter.RecordPrefixArea;
					if (recordPrefixArea != null)
					{
						record = recordPrefixArea.Record;
						if (record == null)
						{
							global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = recordPrefixArea.FieldLayout;
							if (fieldLayout == null)
							{
								fieldLayout = (recordPrefixArea.DataContext as global::Infragistics.Windows.DataPresenter.FieldLayout);
								if (fieldLayout == null)
								{
									return 0;
								}
							}
							if (frameworkElement is global::Infragistics.Windows.DataPresenter.HeaderPrefixArea)
							{
								global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = global::Infragistics.Windows.Utilities.GetAncestorFromType(recordPrefixArea, typeof(global::Infragistics.Windows.DataPresenter.DataRecordPresenter), true, fieldLayout.DataPresenter) as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
								if (dataRecordPresenter != null)
								{
									record = dataRecordPresenter.Record;
								}
							}
							else if (frameworkElement is global::Infragistics.Windows.DataPresenter.SummaryRecordPrefixArea)
							{
								global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter summaryRecordPresenter = global::Infragistics.Windows.Utilities.GetAncestorFromType(recordPrefixArea, typeof(global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter), true, fieldLayout.DataPresenter) as global::Infragistics.Windows.DataPresenter.SummaryRecordPresenter;
								if (summaryRecordPresenter != null)
								{
									record = summaryRecordPresenter.Record;
								}
							}
						}
					}
				}
				if (record == null)
				{
					return 0;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = record.FieldLayout;
				if (fieldLayout2 != null)
				{
					return fieldLayout2.GetRecordSelectorExtent(record);
				}
				return num;
			}

			// Token: 0x06000973 RID: 2419 RVA: 0x000286DC File Offset: 0x000268DC
			public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
			{
				return new object[]
				{
					global::System.Windows.Data.Binding.DoNothing,
					global::System.Windows.Data.Binding.DoNothing
				};
			}

			// Token: 0x040003AF RID: 943
			private static readonly global::Infragistics.Windows.DataPresenter.GridUtilities.RecordSelectorExtentConverter instance = new global::Infragistics.Windows.DataPresenter.GridUtilities.RecordSelectorExtentConverter();
		}

		// Token: 0x020000C3 RID: 195
		internal class TreeViewFilterManager
		{
			// Token: 0x06000974 RID: 2420 RVA: 0x00028701 File Offset: 0x00026901
			internal TreeViewFilterManager(global::Infragistics.Windows.DataPresenter.DataPresenterBase presenter)
			{
				this._presenter = presenter;
				this._nestingStack = new global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.GridUtilities.TreeViewFilterManager.RecordLevelState>();
			}

			// Token: 0x1700022C RID: 556
			// (get) Token: 0x06000975 RID: 2421 RVA: 0x0002871B File Offset: 0x0002691B
			internal bool IsActive
			{
				get
				{
					return this._timer != null && this._timer.IsEnabled;
				}
			}

			// Token: 0x06000976 RID: 2422 RVA: 0x00028740 File Offset: 0x00026940
			internal bool Start()
			{
				this._nestingStack.Clear();
				global::Infragistics.Windows.DataPresenter.FieldLayout defaultFieldLayout = this._presenter.DefaultFieldLayout;
				if (defaultFieldLayout == null || !defaultFieldLayout.IsTreeView)
				{
					return false;
				}
				this._rootCollection = this._presenter.RecordManager.Current;
				if (this._rootCollection == null)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection recordFiltersResolved = this._presenter.RecordManager.RecordFiltersResolved;
				if (recordFiltersResolved == null)
				{
					return false;
				}
				this._hasActiveFilters = recordFiltersResolved.HasActiveFilters(defaultFieldLayout);
				if (!this._hasActiveFilters && this._modifiedRecordCount == 0 && this._lastModifiedRecordCount == 0)
				{
					return false;
				}
				if (this._modifiedRecordCount > 0)
				{
					this._lastModifiedRecordCount = this._modifiedRecordCount;
				}
				this._modifiedRecordCount = 0;
				global::Infragistics.Windows.DataPresenter.TreeView treeView = this._presenter.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.TreeView;
				if (treeView != null)
				{
					this._includeDescendantsOfFilteredInRecords = (treeView != null && treeView.ViewSettings.FilterResultsDisplayMode == global::Infragistics.Windows.DataPresenter.TreeViewFilterResultsDisplayMode.ShowWithAncestorsAndDescendants);
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.TreeReportView treeReportView = this._presenter.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.TreeReportView;
					this._includeDescendantsOfFilteredInRecords = (treeReportView != null && treeReportView.ViewSettingsResolved.FilterResultsDisplayMode == global::Infragistics.Windows.DataPresenter.TreeViewFilterResultsDisplayMode.ShowWithAncestorsAndDescendants);
				}
				if (!this._presenter.IsExportControl)
				{
					this._presenter.Dispatcher.BeginInvoke(new global::System.Action(delegate()
					{
						this._presenter.UpdateLayout();
					}), global::System.Windows.Threading.DispatcherPriority.Background, new object[0]);
				}
				this._nestingStack.Push(new global::Infragistics.Windows.DataPresenter.GridUtilities.TreeViewFilterManager.RecordLevelState(this._rootCollection));
				if (!this._presenter.IsExportControl)
				{
					if (this._timer == null)
					{
						this._timer = new global::System.Windows.Threading.DispatcherTimer(global::System.Windows.Threading.DispatcherPriority.Background);
						this._timer.Tick += this.OnTimerTick;
					}
					this._timer.Interval = global::System.TimeSpan.FromMilliseconds(5.0);
					this._timer.Start();
				}
				return true;
			}

			// Token: 0x06000977 RID: 2423 RVA: 0x000288E9 File Offset: 0x00026AE9
			internal void Stop()
			{
				if (this._timer != null)
				{
					this._timer.Stop();
				}
				this._nestingStack.Clear();
			}

			// Token: 0x06000978 RID: 2424 RVA: 0x0002890C File Offset: 0x00026B0C
			internal bool ProcessRecords(int maxTicksPerSlice = 50)
			{
				while (this._nestingStack.Count > 0)
				{
					global::Infragistics.Windows.DataPresenter.GridUtilities.TreeViewFilterManager.RecordLevelState recordLevelState = this._nestingStack.Peek();
					while (recordLevelState.CurrentIndex >= recordLevelState._collection.Count)
					{
						bool flag = this._hasActiveFilters && recordLevelState.HasFilteredInDescendant;
						if (!recordLevelState.WasExpandedStateSet)
						{
							global::Infragistics.Windows.DataPresenter.Record parentRecord = recordLevelState._collection.ParentRecord;
							if (parentRecord != null)
							{
								if (!this._includeDescendantsOfFilteredInRecords || !recordLevelState.HasFilteredInAncestor)
								{
									parentRecord.SetIsVisibleWhenFilteredOut(flag, true);
								}
								parentRecord.ExpandCollapse(flag, false, true);
								this._modifiedRecordCount++;
							}
						}
						this._nestingStack.Pop();
						if (this._nestingStack.Count == 0)
						{
							return false;
						}
						if (flag)
						{
							foreach (global::Infragistics.Windows.DataPresenter.GridUtilities.TreeViewFilterManager.RecordLevelState recordLevelState2 in this._nestingStack)
							{
								if (!recordLevelState2.WasExpandedStateSet)
								{
									recordLevelState2.WasExpandedStateSet = true;
									recordLevelState2.HasFilteredInDescendant = true;
									global::Infragistics.Windows.DataPresenter.Record parentRecord2 = recordLevelState2._collection.ParentRecord;
									if (parentRecord2 != null)
									{
										parentRecord2.SetIsVisibleWhenFilteredOut(true, true);
										parentRecord2.ExpandCollapse(true, false, true);
										this._modifiedRecordCount++;
									}
								}
							}
						}
						recordLevelState = this._nestingStack.Peek();
					}
					global::Infragistics.Windows.DataPresenter.Record record = recordLevelState._collection[recordLevelState.CurrentIndex];
					recordLevelState.CurrentIndex++;
					bool flag2 = false;
					if (record is global::Infragistics.Windows.DataPresenter.DataRecord && !record.InternalIsFilteredOut_Verify)
					{
						flag2 = true;
						recordLevelState.HasFilteredInDescendant = true;
					}
					global::Infragistics.Windows.DataPresenter.GridUtilities.TreeViewFilterManager.RecordLevelState recordLevelState3 = null;
					if (record.HasChildrenInternal)
					{
						global::Infragistics.Windows.DataPresenter.RecordCollectionBase childRecordsInternal = record.ChildRecordsInternal;
						if (childRecordsInternal != null)
						{
							recordLevelState3 = new global::Infragistics.Windows.DataPresenter.GridUtilities.TreeViewFilterManager.RecordLevelState(childRecordsInternal)
							{
								HasFilteredInAncestor = (flag2 || recordLevelState.HasFilteredInAncestor)
							};
							if (this._includeDescendantsOfFilteredInRecords)
							{
								bool flag3 = false;
								if (recordLevelState3.HasFilteredInAncestor)
								{
									this._modifiedRecordCount += recordLevelState3._collection.Count;
								}
								foreach (global::Infragistics.Windows.DataPresenter.Record record2 in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)recordLevelState3._collection))
								{
									if (record2.SetIsVisibleWhenFilteredOut(recordLevelState3.HasFilteredInAncestor, true))
									{
										flag3 = true;
									}
								}
								if (flag3)
								{
									recordLevelState3._viewableRecords.OnScrollCountDirtiedHelper();
								}
							}
						}
					}
					if (recordLevelState3 != null)
					{
						this._nestingStack.Push(recordLevelState3);
					}
					else
					{
						if (!this._includeDescendantsOfFilteredInRecords)
						{
							record.SetIsVisibleWhenFilteredOut(false, false);
						}
						record.ExpandCollapse(false, false, true);
					}
					int tickCount = global::System.Environment.TickCount;
					if (tickCount < this._startTickCount || tickCount > this._startTickCount + maxTicksPerSlice)
					{
						break;
					}
				}
				return this._nestingStack.Count > 0;
			}

			// Token: 0x06000979 RID: 2425 RVA: 0x00028BCC File Offset: 0x00026DCC
			internal void VerifyTimer()
			{
				if (this._timer == null)
				{
					return;
				}
				if (this._nestingStack.Count == 0)
				{
					this._lastModifiedRecordCount = (this._hasActiveFilters ? this._modifiedRecordCount : 0);
					this._modifiedRecordCount = 0;
					this._timer.Stop();
					return;
				}
				this._timer.Interval = global::System.TimeSpan.FromMilliseconds(20.0);
			}

			// Token: 0x0600097A RID: 2426 RVA: 0x00028C34 File Offset: 0x00026E34
			private void OnTimerTick(object sender, global::System.EventArgs e)
			{
				this._startTickCount = global::System.Environment.TickCount;
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollectionBase = this._presenter.RecordManager.Current;
				if (recordCollectionBase == null)
				{
					return;
				}
				if (this._presenter.IsExporting)
				{
					return;
				}
				if (this._nestingStack.Count == 0 || recordCollectionBase != this._rootCollection)
				{
					this._rootCollection = recordCollectionBase;
					this._nestingStack.Push(new global::Infragistics.Windows.DataPresenter.GridUtilities.TreeViewFilterManager.RecordLevelState(recordCollectionBase));
				}
				this.ProcessRecords(50);
				this.VerifyTimer();
			}

			// Token: 0x040003B0 RID: 944
			private const int TIMER_INITIAL_DELAY_MS = 5;

			// Token: 0x040003B1 RID: 945
			private const int TIMER_INTERVAL_MS = 20;

			// Token: 0x040003B2 RID: 946
			private const int MAX_TICKS_PER_SLICE = 50;

			// Token: 0x040003B3 RID: 947
			private readonly global::Infragistics.Windows.DataPresenter.DataPresenterBase _presenter;

			// Token: 0x040003B4 RID: 948
			private global::System.Windows.Threading.DispatcherTimer _timer;

			// Token: 0x040003B5 RID: 949
			private global::System.Collections.Generic.Stack<global::Infragistics.Windows.DataPresenter.GridUtilities.TreeViewFilterManager.RecordLevelState> _nestingStack;

			// Token: 0x040003B6 RID: 950
			private int _startTickCount;

			// Token: 0x040003B7 RID: 951
			private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _rootCollection;

			// Token: 0x040003B8 RID: 952
			private bool _hasActiveFilters;

			// Token: 0x040003B9 RID: 953
			private int _modifiedRecordCount;

			// Token: 0x040003BA RID: 954
			private int _lastModifiedRecordCount;

			// Token: 0x040003BB RID: 955
			private bool _includeDescendantsOfFilteredInRecords;

			// Token: 0x020000C4 RID: 196
			private class RecordLevelState
			{
				// Token: 0x1700022D RID: 557
				// (get) Token: 0x0600097C RID: 2428 RVA: 0x00028CAC File Offset: 0x00026EAC
				// (set) Token: 0x0600097D RID: 2429 RVA: 0x00028CB4 File Offset: 0x00026EB4
				internal int CurrentIndex { get; set; }

				// Token: 0x1700022E RID: 558
				// (get) Token: 0x0600097E RID: 2430 RVA: 0x00028CBD File Offset: 0x00026EBD
				// (set) Token: 0x0600097F RID: 2431 RVA: 0x00028CC5 File Offset: 0x00026EC5
				internal bool HasFilteredInAncestor { get; set; }

				// Token: 0x1700022F RID: 559
				// (get) Token: 0x06000980 RID: 2432 RVA: 0x00028CCE File Offset: 0x00026ECE
				// (set) Token: 0x06000981 RID: 2433 RVA: 0x00028CD6 File Offset: 0x00026ED6
				internal bool HasFilteredInDescendant { get; set; }

				// Token: 0x17000230 RID: 560
				// (get) Token: 0x06000982 RID: 2434 RVA: 0x00028CDF File Offset: 0x00026EDF
				// (set) Token: 0x06000983 RID: 2435 RVA: 0x00028CE7 File Offset: 0x00026EE7
				internal bool WasExpandedStateSet { get; set; }

				// Token: 0x17000231 RID: 561
				// (get) Token: 0x06000984 RID: 2436 RVA: 0x00028CF0 File Offset: 0x00026EF0
				// (set) Token: 0x06000985 RID: 2437 RVA: 0x00028CF8 File Offset: 0x00026EF8
				internal bool FirstPass { get; set; }

				// Token: 0x06000986 RID: 2438 RVA: 0x00028D01 File Offset: 0x00026F01
				internal RecordLevelState(global::Infragistics.Windows.DataPresenter.RecordCollectionBase collection)
				{
					this._collection = collection;
					this._viewableRecords = collection.ParentRecordManager.ViewableRecords;
				}

				// Token: 0x040003BC RID: 956
				internal readonly global::Infragistics.Windows.DataPresenter.RecordCollectionBase _collection;

				// Token: 0x040003BD RID: 957
				internal readonly global::Infragistics.Windows.DataPresenter.ViewableRecordCollection _viewableRecords;
			}
		}
	}
}
