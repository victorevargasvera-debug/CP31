using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Infragistics.Collections;

namespace Infragistics
{
	// Token: 0x02000025 RID: 37
	public class CoreUtilities
	{
		// Token: 0x06000194 RID: 404 RVA: 0x00007993 File Offset: 0x00005B93
		protected CoreUtilities()
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000799B File Offset: 0x00005B9B
		internal static global::Infragistics.CoreUtilities.AntirecursionUtility Antirecursion
		{
			get
			{
				if (global::Infragistics.CoreUtilities.g_antirecursionUtility == null)
				{
					global::Infragistics.CoreUtilities.g_antirecursionUtility = new global::Infragistics.CoreUtilities.AntirecursionUtility();
				}
				return global::Infragistics.CoreUtilities.g_antirecursionUtility;
			}
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000079B3 File Offset: 0x00005BB3
		internal static bool AreClose(global::System.Windows.Point pt1, global::System.Windows.Point pt2)
		{
			return global::Infragistics.CoreUtilities.AreClose(pt1.X, pt2.X) && global::Infragistics.CoreUtilities.AreClose(pt1.Y, pt2.Y);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000079DF File Offset: 0x00005BDF
		internal static bool AreClose(global::System.Windows.Size x, global::System.Windows.Size y)
		{
			return global::Infragistics.CoreUtilities.AreClose(x.Width, y.Width) && global::Infragistics.CoreUtilities.AreClose(x.Height, y.Height);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00007A0B File Offset: 0x00005C0B
		internal static bool AreClose(double value1, double value2)
		{
			return value1 == value2 || global::System.Math.Abs(value1 - value2) < 1E-10;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00007A26 File Offset: 0x00005C26
		internal static bool LessThan(double x, double y)
		{
			return x < y && !global::Infragistics.CoreUtilities.AreClose(x, y);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00007A38 File Offset: 0x00005C38
		internal static bool GreaterThan(double x, double y)
		{
			return x > y && !global::Infragistics.CoreUtilities.AreClose(x, y);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00007A4A File Offset: 0x00005C4A
		internal static bool LessThanOrClose(double x, double y)
		{
			return x <= y || global::Infragistics.CoreUtilities.AreClose(x, y);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00007A59 File Offset: 0x00005C59
		internal static bool GreaterThanOrClose(double x, double y)
		{
			return x >= y || global::Infragistics.CoreUtilities.AreClose(x, y);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00007A68 File Offset: 0x00005C68
		internal static bool AreEqual<T>(global::System.Collections.Generic.IList<T> items1, global::System.Collections.Generic.IList<T> items2, global::System.Collections.Generic.IEqualityComparer<T> comparer = null)
		{
			if (items1 == items2)
			{
				return true;
			}
			if (items1 == null || items2 == null)
			{
				return false;
			}
			if (items1.Count != items2.Count)
			{
				return false;
			}
			if (comparer == null)
			{
				comparer = global::System.Collections.Generic.EqualityComparer<T>.Default;
			}
			int i = 0;
			int count = items1.Count;
			while (i < count)
			{
				if (!comparer.Equals(items1[i], items2[i]))
				{
					return false;
				}
				i++;
			}
			return true;
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00007AE0 File Offset: 0x00005CE0
		internal static int BinarySearch(global::System.Collections.Generic.IList<global::Infragistics.DateRange> ranges, global::System.DateTime date)
		{
			global::System.Func<global::System.Collections.Generic.IList<global::Infragistics.DateRange>, int, global::Infragistics.DateRange> rangeProviderCallback = (global::System.Collections.Generic.IList<global::Infragistics.DateRange> list, int index) => ranges[index];
			return global::Infragistics.CoreUtilities.BinarySearchDateRange<global::Infragistics.DateRange>(ranges, rangeProviderCallback, date, ranges.Count);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00007B20 File Offset: 0x00005D20
		internal static int BinarySearch<T>(global::System.Collections.Generic.IList<T> list, T item, global::System.Collections.Generic.IComparer<T> comparer, bool ignoreItem)
		{
			if (comparer == null)
			{
				comparer = global::System.Collections.Generic.Comparer<T>.Default;
			}
			int i = 0;
			int num = list.Count - 1;
			global::System.Collections.Generic.EqualityComparer<T> equalityComparer = (!ignoreItem) ? null : global::System.Collections.Generic.EqualityComparer<T>.Default;
			while (i <= num)
			{
				int num2 = (i + num) / 2;
				T t = list[num2];
				if (equalityComparer != null && equalityComparer.Equals(item, t))
				{
					if (num2 > i)
					{
						t = list[--num2];
					}
					else
					{
						if (num2 >= num)
						{
							return num2;
						}
						t = list[++num2];
					}
				}
				int num3 = comparer.Compare(t, item);
				if (num3 > 0)
				{
					num = num2 - 1;
				}
				else
				{
					if (num3 >= 0)
					{
						return num2;
					}
					i = num2 + 1;
				}
			}
			if (equalityComparer != null && i < list.Count - 1 && equalityComparer.Equals(item, list[i]))
			{
				return i;
			}
			return ~i;
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00007BE0 File Offset: 0x00005DE0
		internal static int BinarySearch<TItem, TComparison>(global::System.Collections.Generic.IList<TItem> items, global::System.Func<TItem, TComparison, int> comparer, TComparison value)
		{
			int i = 0;
			int num = items.Count - 1;
			while (i <= num)
			{
				int num2 = (i + num) / 2;
				TItem arg = items[num2];
				int num3 = comparer(arg, value);
				if (num3 > 0)
				{
					num = num2 - 1;
				}
				else
				{
					if (num3 >= 0)
					{
						return num2;
					}
					i = num2 + 1;
				}
			}
			return ~i;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00007C34 File Offset: 0x00005E34
		internal static int BinarySearchDateRange<T>(global::System.Collections.Generic.IList<T> rangeProviders, global::System.Func<global::System.Collections.Generic.IList<T>, int, global::Infragistics.DateRange> rangeProviderCallback, global::System.DateTime date, int count)
		{
			int i = 0;
			int num = count - 1;
			while (i <= num)
			{
				int num2 = (i + num) / 2;
				global::Infragistics.DateRange dateRange = rangeProviderCallback(rangeProviders, num2);
				if (dateRange.Start > date)
				{
					num = num2 - 1;
				}
				else
				{
					if (!(dateRange.End <= date))
					{
						return num2;
					}
					i = num2 + 1;
				}
			}
			return ~i;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00007C8C File Offset: 0x00005E8C
		public static global::System.Uri BuildEmbeddedResourceUri(global::System.Reflection.Assembly assembly, string resourcePath)
		{
			if (assembly == null)
			{
				throw new global::System.ArgumentNullException("assembly");
			}
			if (resourcePath == null)
			{
				throw new global::System.ArgumentNullException("resourcePath");
			}
			string fullName = assembly.FullName;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(fullName.Length + 15 + resourcePath.Length);
			stringBuilder.Append('/');
			stringBuilder.Append(fullName);
			stringBuilder.Append(";component/");
			stringBuilder.Append(resourcePath);
			return new global::System.Uri(stringBuilder.ToString(), global::System.UriKind.RelativeOrAbsolute);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00007D09 File Offset: 0x00005F09
		internal static double Clamp(double value, double min, double max)
		{
			if (value < min)
			{
				return min;
			}
			if (value > max)
			{
				return max;
			}
			return value;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00007D18 File Offset: 0x00005F18
		internal static bool Contains<T>(global::System.Collections.Generic.IEnumerable<T> e, T item)
		{
			global::System.Collections.Generic.IList<T> list = e as global::System.Collections.Generic.IList<T>;
			if (list != null)
			{
				return list.IndexOf(item) >= 0;
			}
			global::System.Collections.IList list2 = e as global::System.Collections.IList;
			if (list2 != null)
			{
				return list2.IndexOf(item) >= 0;
			}
			global::System.Collections.Generic.EqualityComparer<T> @default = global::System.Collections.Generic.EqualityComparer<T>.Default;
			foreach (T x in e)
			{
				if (@default.Equals(x, item))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00007DAC File Offset: 0x00005FAC
		internal static bool Contains(global::System.Collections.IEnumerable e, object item)
		{
			global::System.Collections.IList list = e as global::System.Collections.IList;
			if (list != null)
			{
				return list.IndexOf(item) >= 0;
			}
			foreach (object obj in e)
			{
				if (obj == item)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00007E1C File Offset: 0x0000601C
		internal static global::Infragistics.CoreUtilities.TypeConverterInfo GetTypeConverterInfo(global::System.Type objectType, global::System.Type convertToType)
		{
			if (global::Infragistics.CoreUtilities._lastInfoObjectType == objectType && global::Infragistics.CoreUtilities._lastInfoConvertToType == convertToType)
			{
				return global::Infragistics.CoreUtilities._lastTypeConverterInfo;
			}
			global::System.ComponentModel.TypeConverter typeConverter = (null != objectType) ? global::System.ComponentModel.TypeDescriptor.GetConverter(objectType) : null;
			global::System.ComponentModel.TypeConverter typeConverter2 = (null != convertToType) ? global::System.ComponentModel.TypeDescriptor.GetConverter(convertToType) : null;
			if (typeConverter != null || typeConverter2 != null)
			{
				bool isPrimitive = objectType.IsPrimitive;
				bool useConvertFromTypeConverterFirst = null != objectType && !isPrimitive;
				global::Infragistics.CoreUtilities.TypeConverterInfo typeConverterInfo = new global::Infragistics.CoreUtilities.TypeConverterInfo(typeConverter2, typeConverter, useConvertFromTypeConverterFirst);
				global::Infragistics.CoreUtilities._lastInfoObjectType = objectType;
				global::Infragistics.CoreUtilities._lastInfoConvertToType = convertToType;
				global::Infragistics.CoreUtilities._lastTypeConverterInfo = typeConverterInfo;
				return typeConverterInfo;
			}
			return null;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00007EB2 File Offset: 0x000060B2
		public static object ConvertDataValue(object valueToConvert, global::System.Type convertToType, global::System.IFormatProvider formatProvider, string format)
		{
			return global::Infragistics.CoreUtilities.ConvertDataValue(valueToConvert, convertToType, formatProvider, format, true);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00007EC0 File Offset: 0x000060C0
		internal static object ConvertDataValue(object valueToConvert, global::System.Type convertToType, global::System.IFormatProvider formatProvider, string format, bool useTypeConverters)
		{
			object obj = null;
			global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(convertToType);
			if (global::Infragistics.CoreUtilities.IsNull(valueToConvert))
			{
				obj = valueToConvert;
			}
			else if (null != underlyingType)
			{
				if (valueToConvert.GetType() == underlyingType || underlyingType.IsInstanceOfType(valueToConvert))
				{
					obj = valueToConvert;
					return obj;
				}
				if (obj == null)
				{
					global::Infragistics.CoreUtilities.TypeConverterInfo typeConverterInfo = useTypeConverters ? global::Infragistics.CoreUtilities.GetTypeConverterInfo(valueToConvert.GetType(), convertToType) : null;
					if (typeConverterInfo != null)
					{
						if (typeof(string) == underlyingType)
						{
							try
							{
								obj = global::Infragistics.CoreUtilities.ToString(valueToConvert, format, formatProvider, true);
							}
							catch (global::System.Exception)
							{
							}
						}
						for (int i = 0; i <= 1; i++)
						{
							if (obj == null)
							{
								if (i != 0 || !typeConverterInfo.useConvertFromTypeConverterFirst)
								{
									if (1 != i || typeConverterInfo.useConvertFromTypeConverterFirst)
									{
										goto IL_D5;
									}
								}
								try
								{
									if (typeConverterInfo.convertFromTypeConverter != null && typeConverterInfo.convertFromTypeConverter.CanConvertFrom(valueToConvert.GetType()))
									{
										obj = typeConverterInfo.convertFromTypeConverter.ConvertFrom(null, formatProvider as global::System.Globalization.CultureInfo, valueToConvert);
									}
								}
								catch (global::System.Exception)
								{
								}
							}
							IL_D5:
							if (obj == null)
							{
								if (i != 0 || typeConverterInfo.useConvertFromTypeConverterFirst)
								{
									if (1 != i || !typeConverterInfo.useConvertFromTypeConverterFirst)
									{
										goto IL_11F;
									}
								}
								try
								{
									if (typeConverterInfo.convertToTypeConverter != null && typeConverterInfo.convertToTypeConverter.CanConvertTo(underlyingType))
									{
										obj = typeConverterInfo.convertToTypeConverter.ConvertTo(null, formatProvider as global::System.Globalization.CultureInfo, valueToConvert, underlyingType);
									}
								}
								catch (global::System.Exception)
								{
								}
							}
							IL_11F:;
						}
					}
				}
				if (obj == null && typeof(global::System.Uri) == underlyingType)
				{
					try
					{
						obj = new global::System.Uri(valueToConvert.ToString());
					}
					catch (global::System.Exception)
					{
					}
				}
				if (obj == null && typeof(string) == underlyingType)
				{
					try
					{
						obj = global::Infragistics.CoreUtilities.ToString(valueToConvert, format, formatProvider, false);
					}
					catch (global::System.Exception)
					{
					}
				}
				bool isEnum = underlyingType.IsEnum;
				if (obj == null && isEnum)
				{
					global::System.Type underlyingType2 = global::System.Enum.GetUnderlyingType(underlyingType);
					object value = valueToConvert;
					if (underlyingType2 != valueToConvert.GetType())
					{
						value = (global::Infragistics.CoreUtilities.ConvertDataValue(valueToConvert, underlyingType2, formatProvider, format) ?? valueToConvert);
					}
					try
					{
						if (global::System.Enum.IsDefined(underlyingType, value))
						{
							if (valueToConvert is string)
							{
								try
								{
									obj = global::System.Enum.Parse(underlyingType, (string)valueToConvert, false);
								}
								catch
								{
								}
							}
							if (obj == null)
							{
								obj = global::System.Enum.ToObject(underlyingType, valueToConvert);
							}
						}
					}
					catch (global::System.Exception)
					{
					}
				}
				if (obj == null && valueToConvert is global::System.IConvertible)
				{
					string text = valueToConvert as string;
					if (global::Infragistics.CoreUtilities.lastNonConvertibleDataType != underlyingType || text == null)
					{
						if (obj == null)
						{
							try
							{
								obj = global::System.Convert.ChangeType(valueToConvert, underlyingType, formatProvider);
							}
							catch (global::System.Exception)
							{
								if (text != null && !typeof(global::System.IConvertible).IsAssignableFrom(underlyingType))
								{
									global::Infragistics.CoreUtilities.lastNonConvertibleDataType = underlyingType;
								}
							}
						}
						if (obj == null)
						{
							try
							{
								obj = global::System.Convert.ChangeType(valueToConvert, underlyingType);
							}
							catch (global::System.Exception)
							{
							}
						}
					}
				}
				if (obj == null && typeof(string) == underlyingType)
				{
					try
					{
						if (obj == null)
						{
							obj = valueToConvert.ToString();
						}
					}
					catch (global::System.Exception)
					{
					}
				}
			}
			return obj;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000081B4 File Offset: 0x000063B4
		internal static void CopyTo<T>(global::System.Collections.Generic.IEnumerable<T> source, T[] dest, int destStartIndex)
		{
			global::System.Collections.Generic.ICollection<T> collection = source as global::System.Collections.Generic.ICollection<T>;
			if (collection != null)
			{
				collection.CopyTo(dest, destStartIndex);
				return;
			}
			foreach (T t in source)
			{
				dest[destStartIndex++] = t;
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00008218 File Offset: 0x00006418
		internal static void CopyTo(global::System.Collections.IEnumerable source, global::System.Array dest, int destStartIndex)
		{
			foreach (object value in source)
			{
				dest.SetValue(value, destStartIndex++);
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00008270 File Offset: 0x00006470
		internal static global::System.Collections.Specialized.NotifyCollectionChangedEventArgs CreateAddRemoveNCCArgs(bool add, global::System.Collections.IList addRemoveMultiItems, int index)
		{
			global::System.Collections.Specialized.NotifyCollectionChangedAction action = add ? global::System.Collections.Specialized.NotifyCollectionChangedAction.Add : global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove;
			return new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(action, addRemoveMultiItems, index);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000828D File Offset: 0x0000648D
		public static global::System.Collections.Generic.IComparer<T> CreateComparer<T>(global::System.Comparison<T> comparison)
		{
			return new global::Infragistics.CoreUtilities.ComparisonComparer<T>(comparison);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00008295 File Offset: 0x00006495
		public static global::System.Collections.Generic.IComparer<T> CreateComparer<T>(global::System.Collections.IComparer comparer)
		{
			return (comparer as global::System.Collections.Generic.IComparer<T>) ?? new global::Infragistics.CoreUtilities.ComparerWrapper<T>(comparer);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000082A7 File Offset: 0x000064A7
		internal static global::System.Collections.Specialized.NotifyCollectionChangedEventArgs CreateReplaceNCCArgs(global::System.Collections.IList oldItems, global::System.Collections.IList newItems, int index)
		{
			return new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace, newItems, oldItems, index);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000082B2 File Offset: 0x000064B2
		internal static void DebuggerLog(int level, string category, string message)
		{
			global::System.Diagnostics.Debugger.Log(level, category, message);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000082BC File Offset: 0x000064BC
		internal static void EnsureIsANumber(double number)
		{
			if (double.IsNaN(number))
			{
				throw new global::System.ArgumentOutOfRangeException("number", "The value cannot be 'double.NaN'.");
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000082D6 File Offset: 0x000064D6
		internal static int GetCount(global::System.Collections.IEnumerable e)
		{
			return global::Infragistics.CoreUtilities.GetCount(e, false);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x000082E0 File Offset: 0x000064E0
		internal static int GetCount(global::System.Collections.IEnumerable e, bool nonOptimized)
		{
			if (!nonOptimized)
			{
				global::System.Collections.ICollection collection = e as global::System.Collections.ICollection;
				if (collection != null)
				{
					return collection.Count;
				}
			}
			int num = 0;
			if (e != null)
			{
				foreach (object obj in e)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00008348 File Offset: 0x00006548
		internal static T GetFirstItem<T>(global::System.Collections.Generic.IEnumerable<T> e)
		{
			if (e != null)
			{
				using (global::System.Collections.Generic.IEnumerator<T> enumerator = e.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						return enumerator.Current;
					}
				}
			}
			return default(T);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000839C File Offset: 0x0000659C
		internal static T GetFirstItem<T>(global::System.Collections.IEnumerable e, bool optimized)
		{
			if (e != null)
			{
				if (optimized)
				{
					global::System.Collections.Generic.IList<T> list = e as global::System.Collections.Generic.IList<T>;
					if (list != null)
					{
						if (list.Count <= 0)
						{
							return default(T);
						}
						return list[0];
					}
					else
					{
						global::System.Collections.IList list2 = e as global::System.Collections.IList;
						if (list2 != null)
						{
							if (list2.Count <= 0)
							{
								return default(T);
							}
							return (T)((object)list2[0]);
						}
					}
				}
				using (global::System.Collections.IEnumerator enumerator = e.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						return (T)((object)enumerator.Current);
					}
				}
			}
			return default(T);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000845C File Offset: 0x0000665C
		internal static bool IntersectsWith(global::System.Windows.Rect rect1, global::System.Windows.Rect rect2)
		{
			global::System.Windows.Rect rect3 = global::System.Windows.Rect.Intersect(rect1, rect2);
			return !rect3.IsEmpty && rect3.Y != rect1.Bottom && rect3.Y != rect2.Bottom && rect3.X != rect1.Right && rect3.X != rect2.Right;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x000084C1 File Offset: 0x000066C1
		internal static bool IsDebuggerLogging()
		{
			return global::System.Diagnostics.Debugger.IsAttached && global::System.Diagnostics.Debugger.IsLogging();
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000084D4 File Offset: 0x000066D4
		internal static bool IsKnownType(global::System.Type type)
		{
			if (type == null)
			{
				return false;
			}
			type = global::Infragistics.CoreUtilities.GetUnderlyingType(type);
			return type.IsPrimitive || typeof(decimal) == type || typeof(string) == type || typeof(global::System.DateTime) == type || typeof(global::System.DayOfWeek) == type || typeof(global::System.Windows.Media.Color) == type || typeof(global::System.Drawing.Color) == type || typeof(global::System.Windows.Media.Visual).IsAssignableFrom(type) || typeof(global::System.Windows.Media.Animation.Animatable).IsAssignableFrom(type);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000085AA File Offset: 0x000067AA
		internal static global::System.Collections.Generic.List<T> GetEnumValues<T>() where T : struct
		{
			return (from f in typeof(T).GetFields(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public)
			where f.IsLiteral
			select (T)((object)f.GetValue(null))).ToList<T>();
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000085E4 File Offset: 0x000067E4
		internal static int GetIndexOf(global::System.Collections.IEnumerable e, object item)
		{
			global::System.Collections.IList list = e as global::System.Collections.IList;
			if (list != null)
			{
				return list.IndexOf(item);
			}
			int num = 0;
			if (e != null)
			{
				foreach (object obj in e)
				{
					if (obj == item)
					{
						return num;
					}
					num++;
				}
				return -1;
			}
			return -1;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000865C File Offset: 0x0000685C
		internal static int GetIndexOf<T>(global::System.Collections.Generic.IEnumerable<T> e, T item)
		{
			global::System.Collections.Generic.IList<T> list = e as global::System.Collections.Generic.IList<T>;
			if (list != null)
			{
				return list.IndexOf(item);
			}
			global::System.Collections.IList list2 = e as global::System.Collections.IList;
			if (list2 != null)
			{
				return list2.IndexOf(item);
			}
			int num = 0;
			if (e != null)
			{
				global::System.Collections.Generic.EqualityComparer<T> @default = global::System.Collections.Generic.EqualityComparer<T>.Default;
				foreach (T x in e)
				{
					if (@default.Equals(x, item))
					{
						return num;
					}
					num++;
				}
				return -1;
			}
			return -1;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000086F0 File Offset: 0x000068F0
		internal static object GetItemAt(global::System.Collections.IEnumerable e, int index)
		{
			global::System.Collections.IList list = e as global::System.Collections.IList;
			if (list != null)
			{
				return list[index];
			}
			if (e != null)
			{
				foreach (object result in e)
				{
					if (index-- == 0)
					{
						return result;
					}
				}
			}
			return null;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00008760 File Offset: 0x00006960
		internal static bool GetItemAt<T>(global::System.Collections.Generic.IEnumerable<T> e, int index, out T item)
		{
			item = default(T);
			global::System.Collections.Generic.IList<T> list = e as global::System.Collections.Generic.IList<T>;
			if (list != null)
			{
				if (index >= list.Count)
				{
					return false;
				}
				item = list[index];
				return true;
			}
			else
			{
				global::System.Collections.IList list2 = e as global::System.Collections.IList;
				if (list2 == null)
				{
					if (e != null)
					{
						foreach (T t in e)
						{
							if (index-- == 0)
							{
								item = t;
								return true;
							}
						}
						return false;
					}
					return false;
				}
				if (index >= list2.Count)
				{
					return false;
				}
				item = (T)((object)list2[index]);
				return true;
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00008814 File Offset: 0x00006A14
		internal static T[] GetItemsInRange<T>(global::System.Collections.IEnumerable list, int startIndex, int count)
		{
			T[] array = new T[count];
			global::System.Collections.Generic.IList<T> list2 = list as global::System.Collections.Generic.IList<T>;
			if (list2 != null)
			{
				for (int i = 0; i < count; i++)
				{
					array[i] = list2[startIndex + i];
				}
			}
			else
			{
				global::System.Collections.IList list3 = list as global::System.Collections.IList;
				if (list3 == null)
				{
					throw new global::System.InvalidOperationException("Source must be an IList<T> or IList.");
				}
				for (int j = 0; j < count; j++)
				{
					array[j] = (T)((object)list3[startIndex + j]);
				}
			}
			return array;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00008890 File Offset: 0x00006A90
		public static global::System.Type GetUnderlyingType(global::System.Type type)
		{
			if (type == null)
			{
				return null;
			}
			global::System.Type underlyingType = global::System.Nullable.GetUnderlyingType(type);
			if (underlyingType != null)
			{
				type = underlyingType;
			}
			return type;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000088BC File Offset: 0x00006ABC
		public static object GetWeakReferenceTargetSafe(global::System.WeakReference weakReference)
		{
			if (weakReference != null)
			{
				try
				{
					return weakReference.Target;
				}
				catch (global::System.Exception)
				{
				}
			}
			return null;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000088EC File Offset: 0x00006AEC
		internal static bool HasItems(global::System.Collections.IEnumerable e)
		{
			if (e != null)
			{
				if (e is global::System.Collections.ICollection)
				{
					return ((global::System.Collections.ICollection)e).Count > 0;
				}
				if (e != null)
				{
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
			}
			return false;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00008958 File Offset: 0x00006B58
		internal static bool IsNull(object val)
		{
			return val == null || global::System.DBNull.Value == val;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00008967 File Offset: 0x00006B67
		internal static bool IsValueEmpty(object val)
		{
			return global::Infragistics.CoreUtilities.IsNull(val) || string.Empty == val as string || global::System.Windows.DependencyProperty.UnsetValue == val;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00008990 File Offset: 0x00006B90
		internal static void Normalize(ref global::System.DateTime start, ref global::System.DateTime end)
		{
			if (end < start)
			{
				global::System.DateTime dateTime = start;
				start = end;
				end = dateTime;
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000089CA File Offset: 0x00006BCA
		internal static void RaiseReadOnlyCollectionException()
		{
			throw new global::System.NotSupportedException("Collection is read-only.");
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000089D8 File Offset: 0x00006BD8
		public static void RemoveAll<T>(global::System.Collections.Generic.List<T> list, T itemToRemove)
		{
			int num = global::Infragistics.CoreUtilities.RemoveAllHelper<T>(list, itemToRemove);
			list.RemoveRange(num, list.Count - num);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000089FC File Offset: 0x00006BFC
		public static void RemoveAll<T>(global::System.Collections.Generic.IList<T> list, T itemToRemove)
		{
			int num = global::Infragistics.CoreUtilities.RemoveAllHelper<T>(list, itemToRemove);
			for (int i = list.Count - 1; i >= num; i--)
			{
				list.RemoveAt(i);
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00008A2C File Offset: 0x00006C2C
		public static void RemoveAll<T>(global::Infragistics.Collections.ObservableCollectionExtended<T> list, T itemToRemove)
		{
			list.BeginUpdate();
			try
			{
				int num = global::Infragistics.CoreUtilities.RemoveAllHelper<T>(list, itemToRemove);
				list.RemoveRange(num, list.Count - num);
			}
			finally
			{
				list.EndUpdate();
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00008A70 File Offset: 0x00006C70
		private static int RemoveAllHelper<T>(global::System.Collections.Generic.IList<T> list, T itemToRemove)
		{
			int num = 0;
			int count = list.Count;
			global::System.Collections.Generic.EqualityComparer<T> @default = global::System.Collections.Generic.EqualityComparer<T>.Default;
			for (int i = 0; i < count; i++)
			{
				if (@default.Equals(list[i], itemToRemove))
				{
					num++;
				}
				else if (num != 0)
				{
					list[i - num] = list[i];
				}
			}
			return count - num;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00008AC4 File Offset: 0x00006CC4
		internal static double RoundToIntegralValue(double value)
		{
			if (double.IsNaN(value) || double.IsInfinity(value))
			{
				return value;
			}
			if (value < 0.0)
			{
				double num = global::System.Math.Ceiling(value);
				if (value - num <= -0.5)
				{
					return num - 1.0;
				}
				return num;
			}
			else
			{
				double num2 = global::System.Math.Floor(value);
				if (value - num2 >= 0.5)
				{
					return num2 + 1.0;
				}
				return num2;
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00008B34 File Offset: 0x00006D34
		public static void SortMerge(object[] array, global::System.Collections.IComparer comparer)
		{
			global::Infragistics.CoreUtilities.SortMerge(array, null, comparer);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00008B3E File Offset: 0x00006D3E
		public static void SortMerge(object[] array, object[] tempArray, global::System.Collections.IComparer comparer)
		{
			global::Infragistics.CoreUtilities.SortMerge(array, tempArray, comparer, 0, array.Length - 1);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00008B50 File Offset: 0x00006D50
		public static void SortMerge(object[] array, object[] tempArray, global::System.Collections.IComparer comparer, int si, int ei)
		{
			if (array == null)
			{
				throw new global::System.ArgumentNullException("array");
			}
			if (comparer == null)
			{
				throw new global::System.ArgumentNullException("comparer");
			}
			if (tempArray == null)
			{
				tempArray = (object[])array.Clone();
			}
			else
			{
				global::System.Array.Copy(array, tempArray, array.Length);
			}
			global::Infragistics.CoreUtilities.SortMergeHelper<object>(array, tempArray, new global::Infragistics.CoreUtilities.ComparerWrapper<object>(comparer), si, ei);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00008BA8 File Offset: 0x00006DA8
		public static void SortMergeGeneric<T>(global::System.Collections.Generic.List<T> list, global::System.Collections.Generic.IComparer<T> comparer)
		{
			if (list == null)
			{
				throw new global::System.ArgumentNullException("list");
			}
			if (comparer == null)
			{
				throw new global::System.ArgumentNullException("comparer");
			}
			T[] array = list.ToArray();
			global::Infragistics.CoreUtilities.SortMergeGeneric<T>(array, null, comparer);
			list.Clear();
			list.AddRange(array);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00008BF0 File Offset: 0x00006DF0
		public static void SortMergeGeneric<T>(global::System.Collections.Generic.List<T> list, global::System.Collections.Generic.IComparer<T> comparer, int startIndex, int endIndex)
		{
			if (list == null)
			{
				throw new global::System.ArgumentNullException("list");
			}
			if (comparer == null)
			{
				throw new global::System.ArgumentNullException("comparer");
			}
			T[] array = new T[1 + endIndex - startIndex];
			list.CopyTo(startIndex, array, 0, array.Length);
			global::Infragistics.CoreUtilities.SortMergeGeneric<T>(array, null, comparer);
			for (int i = 0; i < array.Length; i++)
			{
				list[startIndex + i] = array[i];
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00008C56 File Offset: 0x00006E56
		public static void SortMergeGeneric<T>(T[] array, global::System.Collections.Generic.IComparer<T> comparer)
		{
			global::Infragistics.CoreUtilities.SortMergeGeneric<T>(array, null, comparer);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00008C60 File Offset: 0x00006E60
		public static void SortMergeGeneric<T>(T[] array, T[] tempArray, global::System.Collections.Generic.IComparer<T> comparer)
		{
			global::Infragistics.CoreUtilities.SortMergeGeneric<T>(array, tempArray, comparer, 0, array.Length - 1);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00008C70 File Offset: 0x00006E70
		public static void SortMergeGeneric<T>(T[] array, T[] tempArray, global::System.Collections.Generic.IComparer<T> comparer, int startIndex, int endIndex)
		{
			if (array == null)
			{
				throw new global::System.ArgumentNullException("arr");
			}
			if (comparer == null)
			{
				throw new global::System.ArgumentNullException("comparer");
			}
			if (tempArray == null)
			{
				tempArray = (T[])array.Clone();
			}
			else
			{
				global::System.Array.Copy(array, tempArray, array.Length);
			}
			global::Infragistics.CoreUtilities.SortMergeHelper<T>(array, tempArray, comparer, startIndex, endIndex);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00008CC0 File Offset: 0x00006EC0
		private static void SortMergeHelper<T>(T[] arr, T[] tmpArr, global::System.Collections.Generic.IComparer<T> comparer, int startIndex, int endIndex)
		{
			T t = default(T);
			T t2 = default(T);
			int i;
			int j;
			if (endIndex - startIndex < 6)
			{
				for (i = 1 + startIndex; i <= endIndex; i++)
				{
					t = arr[i];
					for (j = i; j > startIndex; j--)
					{
						t2 = arr[j - 1];
						if (comparer.Compare(t, t2) >= 0)
						{
							break;
						}
						arr[j] = t2;
					}
					if (i != j)
					{
						arr[j] = t;
					}
				}
				return;
			}
			int num = (startIndex + endIndex) / 2;
			global::Infragistics.CoreUtilities.SortMergeHelper<T>(tmpArr, arr, comparer, startIndex, num);
			global::Infragistics.CoreUtilities.SortMergeHelper<T>(tmpArr, arr, comparer, 1 + num, endIndex);
			i = startIndex;
			j = 1 + num;
			for (int k = startIndex; k <= endIndex; k++)
			{
				if (i <= num)
				{
					t = tmpArr[i];
				}
				if (j <= endIndex)
				{
					t2 = tmpArr[j];
				}
				if (j > endIndex || (i <= num && comparer.Compare(t, t2) <= 0))
				{
					arr[k] = t;
					i++;
				}
				else
				{
					arr[k] = t2;
					j++;
				}
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00008DB8 File Offset: 0x00006FB8
		internal static byte[] ReadData(global::System.IO.Stream stream)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			stream.CopyTo(memoryStream);
			byte[] result = memoryStream.ToArray();
			memoryStream.Dispose();
			return result;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00008DE0 File Offset: 0x00006FE0
		public static void Swap<T>(global::System.Collections.Generic.IList<T> arr, int x, int y)
		{
			T value = arr[x];
			arr[x] = arr[y];
			arr[y] = value;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00008E0C File Offset: 0x0000700C
		internal static void Swap<T>(ref T value1, ref T value2)
		{
			T t = value2;
			value2 = value1;
			value1 = t;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00008E33 File Offset: 0x00007033
		internal static char ToLower(char c, global::System.Globalization.CultureInfo culture)
		{
			return char.ToLower(c, culture);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00008E3C File Offset: 0x0000703C
		internal static char ToUpper(char c, global::System.Globalization.CultureInfo culture)
		{
			return char.ToUpper(c, culture);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00008E48 File Offset: 0x00007048
		internal static string ToString(object value, string format, global::System.IFormatProvider provider, bool ignoreFormatIfEmpty)
		{
			string text = null;
			if (provider != null)
			{
				global::System.ICustomFormatter customFormatter = provider.GetFormat(typeof(global::System.ICustomFormatter)) as global::System.ICustomFormatter;
				if (customFormatter != null)
				{
					text = customFormatter.Format(format, value, provider);
				}
			}
			if (text == null && value is global::System.IFormattable && (!ignoreFormatIfEmpty || !string.IsNullOrEmpty(format)))
			{
				text = ((global::System.IFormattable)value).ToString(format, provider);
			}
			return text;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00008EA4 File Offset: 0x000070A4
		internal static void Traverse(global::System.Collections.IEnumerable e)
		{
			foreach (object obj in e)
			{
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00008EEC File Offset: 0x000070EC
		private static bool IsEnumFlags(global::System.Type enumType)
		{
			object[] customAttributes = enumType.GetCustomAttributes(typeof(global::System.FlagsAttribute), true);
			return customAttributes != null && customAttributes.Length > 0;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00008F16 File Offset: 0x00007116
		internal static void ValidateEnum(global::System.Type enumType, object enumVal)
		{
			if (!global::System.Enum.IsDefined(enumType, enumVal) && !global::Infragistics.CoreUtilities.IsEnumFlags(enumType))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException(enumType.Name, (int)enumVal, enumType);
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00008F3C File Offset: 0x0000713C
		internal static void ValidateEnum(string argumentName, global::System.Type enumType, object enumVal)
		{
			if (!global::System.Enum.IsDefined(enumType, enumVal) && !global::Infragistics.CoreUtilities.IsEnumFlags(enumType))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException(argumentName, (int)enumVal, enumType);
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00008F5D File Offset: 0x0000715D
		internal static void ValidateIsNotNan(double value)
		{
			if (double.IsNaN(value))
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ValueCannotBeNan"));
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00008F77 File Offset: 0x00007177
		internal static void ValidateIsNotInfinity(double value)
		{
			if (double.IsInfinity(value))
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ValueCannotBeInfinity"));
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00008F91 File Offset: 0x00007191
		internal static void ValidateIsNotNegative(double value)
		{
			if (value < 0.0)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ValueCannotBeNegative"));
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00008FAF File Offset: 0x000071AF
		internal static void ValidateIsNotNegative(double value, string paramName)
		{
			if (value < 0.0)
			{
				throw new global::System.ArgumentException(paramName, global::SR.GetString("LE_ValueCannotBeNegative"));
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00008FCE File Offset: 0x000071CE
		internal static void ValidateNotEmpty(string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new global::System.ArgumentException();
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00008FDE File Offset: 0x000071DE
		internal static void ValidateNotEmpty(string value, string paramName)
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new global::System.ArgumentException(paramName);
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00008FEF File Offset: 0x000071EF
		internal static void ValidateNotNull(object value)
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException();
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00008FFA File Offset: 0x000071FA
		internal static void ValidateNotNull(object value, string paramName)
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException(paramName);
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00009006 File Offset: 0x00007206
		internal static void ValidateIsPositive(int value)
		{
			if (value <= 0)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ValueMustBePositiveIntegral"));
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000901C File Offset: 0x0000721C
		internal static void ValidateIsPositive(int value, string paramName)
		{
			if (value <= 0)
			{
				throw new global::System.ArgumentException(paramName, global::SR.GetString("LE_ValueMustBePositiveIntegral"));
			}
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00009033 File Offset: 0x00007233
		internal static void ValidateIsPositive(double value)
		{
			if (value <= 0.0)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ValueMustBePositive"));
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00009051 File Offset: 0x00007251
		internal static void ValidateIsPositive(double value, string paramName)
		{
			if (value <= 0.0)
			{
				throw new global::System.ArgumentException(paramName, global::SR.GetString("LE_ValueMustBePositive"));
			}
		}

		// Token: 0x04000098 RID: 152
		[global::System.ThreadStatic]
		private static global::Infragistics.CoreUtilities.AntirecursionUtility g_antirecursionUtility;

		// Token: 0x04000099 RID: 153
		[global::System.ThreadStatic]
		private static global::System.Type lastNonConvertibleDataType;

		// Token: 0x0400009A RID: 154
		[global::System.ThreadStatic]
		private static global::System.Type _lastInfoObjectType;

		// Token: 0x0400009B RID: 155
		[global::System.ThreadStatic]
		private static global::System.Type _lastInfoConvertToType;

		// Token: 0x0400009C RID: 156
		[global::System.ThreadStatic]
		private static global::Infragistics.CoreUtilities.TypeConverterInfo _lastTypeConverterInfo;

		// Token: 0x02000026 RID: 38
		internal class AggregateEnumerable<T> : global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable
		{
			// Token: 0x060001EB RID: 491 RVA: 0x00009070 File Offset: 0x00007270
			public AggregateEnumerable(params global::System.Collections.Generic.IEnumerable<T>[] enumerables) : this((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<T>>)enumerables)
			{
			}

			// Token: 0x060001EC RID: 492 RVA: 0x0000907E File Offset: 0x0000727E
			public AggregateEnumerable(global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<T>> enumerables)
			{
				this._enumerables = enumerables;
			}

			// Token: 0x060001ED RID: 493 RVA: 0x0000908D File Offset: 0x0000728D
			public global::System.Collections.IEnumerator GetEnumerator()
			{
				return new global::Infragistics.CoreUtilities.AggregateEnumerable<T>.Enumerator(this._enumerables);
			}

			// Token: 0x060001EE RID: 494 RVA: 0x0000909A File Offset: 0x0000729A
			global::System.Collections.Generic.IEnumerator<T> global::System.Collections.Generic.IEnumerable<!0>.GetEnumerator()
			{
				return new global::Infragistics.CoreUtilities.AggregateEnumerable<T>.Enumerator(this._enumerables);
			}

			// Token: 0x0400009D RID: 157
			private global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<T>> _enumerables;

			// Token: 0x02000027 RID: 39
			public class Enumerator : global::System.Collections.Generic.IEnumerator<T>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x060001EF RID: 495 RVA: 0x000090A7 File Offset: 0x000072A7
				public Enumerator(params global::System.Collections.Generic.IEnumerable<T>[] enumerables) : this((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<T>>)enumerables)
				{
				}

				// Token: 0x060001F0 RID: 496 RVA: 0x000090B5 File Offset: 0x000072B5
				public Enumerator(global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<T>> enumerables)
				{
					this._enumerables = ((enumerables != null) ? enumerables.GetEnumerator() : null);
				}

				// Token: 0x060001F1 RID: 497 RVA: 0x000090CF File Offset: 0x000072CF
				public void Reset()
				{
					if (this._enumerables != null)
					{
						this._enumerables.Reset();
					}
					this._current = null;
				}

				// Token: 0x060001F2 RID: 498 RVA: 0x000090EC File Offset: 0x000072EC
				public bool MoveNext()
				{
					if (this._current != null && this._current.MoveNext())
					{
						return true;
					}
					while (this._enumerables != null && this._enumerables.MoveNext())
					{
						global::System.Collections.Generic.IEnumerable<T> enumerable = this._enumerables.Current;
						if (enumerable != null)
						{
							this._current = enumerable.GetEnumerator();
							if (this._current.MoveNext())
							{
								return true;
							}
						}
					}
					return false;
				}

				// Token: 0x17000031 RID: 49
				// (get) Token: 0x060001F3 RID: 499 RVA: 0x00009150 File Offset: 0x00007350
				public T Current
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

				// Token: 0x17000032 RID: 50
				// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000917A File Offset: 0x0000737A
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						return this.Current;
					}
				}

				// Token: 0x060001F5 RID: 501 RVA: 0x00009187 File Offset: 0x00007387
				public void Dispose()
				{
				}

				// Token: 0x0400009E RID: 158
				private global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.IEnumerable<T>> _enumerables;

				// Token: 0x0400009F RID: 159
				private global::System.Collections.Generic.IEnumerator<T> _current;
			}
		}

		// Token: 0x02000028 RID: 40
		private sealed class ComparisonComparer<T> : global::System.Collections.Generic.IComparer<T>
		{
			// Token: 0x060001F6 RID: 502 RVA: 0x00009189 File Offset: 0x00007389
			internal ComparisonComparer(global::System.Comparison<T> comparison)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(comparison, "comparison");
				this._c = comparison;
			}

			// Token: 0x060001F7 RID: 503 RVA: 0x000091A3 File Offset: 0x000073A3
			public int Compare(T x, T y)
			{
				return this._c(x, y);
			}

			// Token: 0x040000A0 RID: 160
			private global::System.Comparison<T> _c;
		}

		// Token: 0x02000029 RID: 41
		internal class ConverterComparer<T, Z> : global::System.Collections.Generic.IComparer<T>
		{
			// Token: 0x060001F8 RID: 504 RVA: 0x000091B2 File Offset: 0x000073B2
			public ConverterComparer(global::System.Converter<T, Z> converter, global::System.Comparison<Z> comparison) : this(converter, global::Infragistics.CoreUtilities.CreateComparer<Z>(comparison))
			{
			}

			// Token: 0x060001F9 RID: 505 RVA: 0x000091C1 File Offset: 0x000073C1
			public ConverterComparer(global::System.Converter<T, Z> converter, global::System.Collections.Generic.IComparer<Z> comparer)
			{
				this._converter = converter;
				this._comparer = comparer;
			}

			// Token: 0x060001FA RID: 506 RVA: 0x000091D7 File Offset: 0x000073D7
			public int Compare(T i, T j)
			{
				return this._comparer.Compare(this._converter(i), this._converter(j));
			}

			// Token: 0x040000A1 RID: 161
			private global::System.Converter<T, Z> _converter;

			// Token: 0x040000A2 RID: 162
			private global::System.Collections.Generic.IComparer<Z> _comparer;
		}

		// Token: 0x0200002A RID: 42
		internal class EmptyEnumerable<T> : global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable
		{
			// Token: 0x060001FC RID: 508 RVA: 0x00009204 File Offset: 0x00007404
			public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
			{
				return new global::Infragistics.CoreUtilities.EmptyEnumerable<T>.Enumerator();
			}

			// Token: 0x060001FD RID: 509 RVA: 0x0000920B File Offset: 0x0000740B
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x0200002B RID: 43
			public class Enumerator : global::System.Collections.Generic.IEnumerator<T>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x17000033 RID: 51
				// (get) Token: 0x060001FF RID: 511 RVA: 0x0000921B File Offset: 0x0000741B
				public T Current
				{
					get
					{
						throw new global::System.InvalidOperationException();
					}
				}

				// Token: 0x06000200 RID: 512 RVA: 0x00009222 File Offset: 0x00007422
				public void Dispose()
				{
				}

				// Token: 0x17000034 RID: 52
				// (get) Token: 0x06000201 RID: 513 RVA: 0x00009224 File Offset: 0x00007424
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						throw new global::System.InvalidOperationException();
					}
				}

				// Token: 0x06000202 RID: 514 RVA: 0x0000922B File Offset: 0x0000742B
				public bool MoveNext()
				{
					return false;
				}

				// Token: 0x06000203 RID: 515 RVA: 0x0000922E File Offset: 0x0000742E
				public void Reset()
				{
				}
			}
		}

		// Token: 0x0200002C RID: 44
		internal class TypedList<T> : global::System.Collections.Generic.IList<!0>, global::System.Collections.Generic.ICollection<!0>, global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable
		{
			// Token: 0x06000204 RID: 516 RVA: 0x00009230 File Offset: 0x00007430
			internal TypedList(global::System.Collections.IList list)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(list);
				this._list = list;
			}

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x06000205 RID: 517 RVA: 0x00009245 File Offset: 0x00007445
			internal global::System.Collections.IList List
			{
				get
				{
					return this._list;
				}
			}

			// Token: 0x06000206 RID: 518 RVA: 0x0000924D File Offset: 0x0000744D
			public int IndexOf(T item)
			{
				return this._list.IndexOf(item);
			}

			// Token: 0x06000207 RID: 519 RVA: 0x00009260 File Offset: 0x00007460
			public void Insert(int index, T item)
			{
				this._list.Insert(index, item);
			}

			// Token: 0x06000208 RID: 520 RVA: 0x00009274 File Offset: 0x00007474
			public void RemoveAt(int index)
			{
				this._list.RemoveAt(index);
			}

			// Token: 0x17000036 RID: 54
			public T this[int index]
			{
				get
				{
					return (T)((object)this._list[index]);
				}
				set
				{
					this._list[index] = value;
				}
			}

			// Token: 0x0600020B RID: 523 RVA: 0x000092A9 File Offset: 0x000074A9
			public void Add(T item)
			{
				this._list.Add(item);
			}

			// Token: 0x0600020C RID: 524 RVA: 0x000092BD File Offset: 0x000074BD
			public void Clear()
			{
				this._list.Clear();
			}

			// Token: 0x0600020D RID: 525 RVA: 0x000092CA File Offset: 0x000074CA
			public bool Contains(T item)
			{
				return this._list.Contains(item);
			}

			// Token: 0x0600020E RID: 526 RVA: 0x000092DD File Offset: 0x000074DD
			public void CopyTo(T[] array, int arrayIndex)
			{
				global::Infragistics.CoreUtilities.CopyTo<T>(new global::Infragistics.Collections.TypedEnumerable<T>(this._list), array, arrayIndex);
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x0600020F RID: 527 RVA: 0x000092F1 File Offset: 0x000074F1
			public int Count
			{
				get
				{
					return this._list.Count;
				}
			}

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x06000210 RID: 528 RVA: 0x000092FE File Offset: 0x000074FE
			public bool IsReadOnly
			{
				get
				{
					return this._list.IsReadOnly;
				}
			}

			// Token: 0x06000211 RID: 529 RVA: 0x0000930C File Offset: 0x0000750C
			public bool Remove(T item)
			{
				int num = this._list.IndexOf(item);
				if (num >= 0)
				{
					this._list.RemoveAt(num);
				}
				return num >= 0;
			}

			// Token: 0x06000212 RID: 530 RVA: 0x00009342 File Offset: 0x00007542
			public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
			{
				return new global::Infragistics.Collections.TypedEnumerable<T>.Enumerator(this._list.GetEnumerator());
			}

			// Token: 0x06000213 RID: 531 RVA: 0x00009354 File Offset: 0x00007554
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this._list.GetEnumerator();
			}

			// Token: 0x040000A3 RID: 163
			private global::System.Collections.IList _list;
		}

		// Token: 0x0200002D RID: 45
		internal class ObservableTypedList<T> : global::Infragistics.CoreUtilities.TypedList<T>, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.ComponentModel.INotifyPropertyChanged
		{
			// Token: 0x06000214 RID: 532 RVA: 0x00009364 File Offset: 0x00007564
			internal ObservableTypedList(global::System.Collections.IList list) : base(list)
			{
				global::System.Collections.Specialized.INotifyCollectionChanged notifyCollectionChanged = list as global::System.Collections.Specialized.INotifyCollectionChanged;
				if (notifyCollectionChanged != null)
				{
					notifyCollectionChanged.CollectionChanged += this.OnCollectionChanged;
				}
				global::System.ComponentModel.INotifyPropertyChanged notifyPropertyChanged = list as global::System.ComponentModel.INotifyPropertyChanged;
				if (notifyPropertyChanged != null)
				{
					notifyPropertyChanged.PropertyChanged += this.OnCollectionPropertyChanged;
				}
			}

			// Token: 0x06000215 RID: 533 RVA: 0x000093B0 File Offset: 0x000075B0
			private void OnCollectionPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
			{
				global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
				if (propertyChanged != null)
				{
					propertyChanged(this, e);
				}
			}

			// Token: 0x06000216 RID: 534 RVA: 0x000093D0 File Offset: 0x000075D0
			private void OnCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
			{
				global::System.Collections.Specialized.NotifyCollectionChangedEventHandler collectionChanged = this.CollectionChanged;
				if (collectionChanged != null)
				{
					collectionChanged(this, e);
				}
			}

			// Token: 0x14000002 RID: 2
			// (add) Token: 0x06000217 RID: 535 RVA: 0x000093F0 File Offset: 0x000075F0
			// (remove) Token: 0x06000218 RID: 536 RVA: 0x00009428 File Offset: 0x00007628
			public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

			// Token: 0x14000003 RID: 3
			// (add) Token: 0x06000219 RID: 537 RVA: 0x00009460 File Offset: 0x00007660
			// (remove) Token: 0x0600021A RID: 538 RVA: 0x00009498 File Offset: 0x00007698
			public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;
		}

		// Token: 0x0200002E RID: 46
		internal class WildcardToRegexConverter
		{
			// Token: 0x0600021B RID: 539 RVA: 0x000094CD File Offset: 0x000076CD
			private WildcardToRegexConverter(string wildcard)
			{
				this._wildcard = wildcard;
				this._regex = new global::System.Text.StringBuilder(wildcard.Length);
			}

			// Token: 0x0600021C RID: 540 RVA: 0x000094F0 File Offset: 0x000076F0
			public static global::System.Text.RegularExpressions.Regex Convert(string wildcard, bool ignoreCase, bool matchWholeText = true)
			{
				string pattern;
				global::System.Text.RegularExpressions.RegexOptions regexOptions;
				global::System.Exception ex;
				global::Infragistics.CoreUtilities.WildcardToRegexConverter.Convert(wildcard, out pattern, out regexOptions, out ex, matchWholeText);
				if (ex == null)
				{
					if (ignoreCase)
					{
						regexOptions |= global::System.Text.RegularExpressions.RegexOptions.IgnoreCase;
					}
					return new global::System.Text.RegularExpressions.Regex(pattern, regexOptions);
				}
				return null;
			}

			// Token: 0x0600021D RID: 541 RVA: 0x00009520 File Offset: 0x00007720
			public static void Convert(string wildcard, out string regex, out global::System.Text.RegularExpressions.RegexOptions options, out global::System.Exception error, bool matchWholeText = true)
			{
				if (wildcard == null || wildcard.Length == 0)
				{
					options = global::System.Text.RegularExpressions.RegexOptions.None;
					regex = null;
					error = new global::System.Exception(global::SR.GetString("Filter_WildCard_Empty"));
					return;
				}
				global::Infragistics.CoreUtilities.WildcardToRegexConverter wildcardToRegexConverter = new global::Infragistics.CoreUtilities.WildcardToRegexConverter(wildcard);
				wildcardToRegexConverter._nonGreedy = !matchWholeText;
				wildcardToRegexConverter.Parse();
				if (wildcardToRegexConverter._error == null && wildcardToRegexConverter._regex.Length > 0)
				{
					regex = wildcardToRegexConverter._regex.ToString();
					if (matchWholeText)
					{
						regex = "^" + regex + "$";
					}
					options = (global::System.Text.RegularExpressions.RegexOptions.ExplicitCapture | global::System.Text.RegularExpressions.RegexOptions.Singleline);
					error = null;
					return;
				}
				error = new global::System.Exception(wildcardToRegexConverter._error);
				options = global::System.Text.RegularExpressions.RegexOptions.None;
				regex = null;
			}

			// Token: 0x0600021E RID: 542 RVA: 0x000095C0 File Offset: 0x000077C0
			private void Parse()
			{
				global::Infragistics.CoreUtilities.WildcardToRegexConverter.ParseState parseState = global::Infragistics.CoreUtilities.WildcardToRegexConverter.ParseState.Initial;
				int num = -1;
				global::System.Text.StringBuilder regex = this._regex;
				string wildcard = this._wildcard;
				for (int i = 0; i < wildcard.Length; i++)
				{
					char c = wildcard[i];
					if (global::Infragistics.CoreUtilities.WildcardToRegexConverter.ParseState.Bracket == parseState && ']' == c)
					{
						this.ParseSet(1 + num, i - 1);
						parseState = global::Infragistics.CoreUtilities.WildcardToRegexConverter.ParseState.Initial;
					}
					else if (parseState == global::Infragistics.CoreUtilities.WildcardToRegexConverter.ParseState.Initial && '[' == c)
					{
						num = i;
						parseState = global::Infragistics.CoreUtilities.WildcardToRegexConverter.ParseState.Bracket;
					}
					else if (parseState == global::Infragistics.CoreUtilities.WildcardToRegexConverter.ParseState.Initial && '#' == c)
					{
						regex.Append("\\d");
					}
					else if (parseState == global::Infragistics.CoreUtilities.WildcardToRegexConverter.ParseState.Initial && '?' == c)
					{
						regex.Append('.');
					}
					else if (parseState == global::Infragistics.CoreUtilities.WildcardToRegexConverter.ParseState.Initial && '*' == c)
					{
						regex.Append(".*");
						if (this._nonGreedy)
						{
							regex.Append('?');
						}
					}
					else if (parseState == global::Infragistics.CoreUtilities.WildcardToRegexConverter.ParseState.Initial)
					{
						if ("[]{}()\\.+*?^$".IndexOf(c) >= 0)
						{
							regex.Append('\\');
						}
						regex.Append(c);
					}
				}
			}

			// Token: 0x0600021F RID: 543 RVA: 0x000096AC File Offset: 0x000078AC
			private void ParseSet(int si, int ei)
			{
				global::System.Text.StringBuilder regex = this._regex;
				string wildcard = this._wildcard;
				int length = regex.Length;
				regex.Append('[');
				if ('!' == wildcard[si])
				{
					if (si == ei)
					{
						this._error = global::SR.GetString("Filter_WildCard_InvalidCharClass");
						return;
					}
					regex.Append('^');
					si++;
				}
				for (int i = si; i <= ei; i++)
				{
					char value = wildcard[i];
					if ("[]{}()\\.+*?^$".IndexOf(value) >= 0)
					{
						regex.Append('\\');
					}
					regex.Append(value);
				}
				regex.Append(']');
			}

			// Token: 0x040000A6 RID: 166
			private const string REGEX_SPECIAL_CHARS = "[]{}()\\.+*?^$";

			// Token: 0x040000A7 RID: 167
			private string _wildcard;

			// Token: 0x040000A8 RID: 168
			private global::System.Text.StringBuilder _regex;

			// Token: 0x040000A9 RID: 169
			private string _error;

			// Token: 0x040000AA RID: 170
			private bool _nonGreedy;

			// Token: 0x0200002F RID: 47
			private enum ParseState
			{
				// Token: 0x040000AC RID: 172
				Initial,
				// Token: 0x040000AD RID: 173
				Bracket
			}
		}

		// Token: 0x02000030 RID: 48
		internal class TypeConverterInfo
		{
			// Token: 0x06000220 RID: 544 RVA: 0x00009741 File Offset: 0x00007941
			internal TypeConverterInfo(global::System.ComponentModel.TypeConverter convertFromTypeConverter, global::System.ComponentModel.TypeConverter convertToTypeConverter, bool useConvertFromTypeConverterFirst)
			{
				this.convertFromTypeConverter = convertFromTypeConverter;
				this.convertToTypeConverter = convertToTypeConverter;
				this.useConvertFromTypeConverterFirst = useConvertFromTypeConverterFirst;
			}

			// Token: 0x040000AE RID: 174
			internal global::System.ComponentModel.TypeConverter convertFromTypeConverter;

			// Token: 0x040000AF RID: 175
			internal global::System.ComponentModel.TypeConverter convertToTypeConverter;

			// Token: 0x040000B0 RID: 176
			internal bool useConvertFromTypeConverterFirst;
		}

		// Token: 0x02000031 RID: 49
		private class ComparerWrapper<T> : global::System.Collections.Generic.IComparer<T>
		{
			// Token: 0x06000221 RID: 545 RVA: 0x0000975E File Offset: 0x0000795E
			public ComparerWrapper(global::System.Collections.IComparer comparer)
			{
				this.comparer = comparer;
			}

			// Token: 0x06000222 RID: 546 RVA: 0x0000976D File Offset: 0x0000796D
			public int Compare(T x, T y)
			{
				return this.comparer.Compare(x, y);
			}

			// Token: 0x040000B1 RID: 177
			private global::System.Collections.IComparer comparer;
		}

		// Token: 0x02000032 RID: 50
		internal class AntirecursionUtility
		{
			// Token: 0x17000039 RID: 57
			// (get) Token: 0x06000223 RID: 547 RVA: 0x00009786 File Offset: 0x00007986
			private global::System.Collections.Generic.Dictionary<global::Infragistics.CoreUtilities.AntirecursionUtility.ID, int> Map
			{
				get
				{
					if (this._map == null)
					{
						this._map = new global::System.Collections.Generic.Dictionary<global::Infragistics.CoreUtilities.AntirecursionUtility.ID, int>();
					}
					return this._map;
				}
			}

			// Token: 0x06000224 RID: 548 RVA: 0x000097A4 File Offset: 0x000079A4
			public bool Enter(object item, object flagId, bool disallowMultipleEntries)
			{
				global::Infragistics.CoreUtilities.AntirecursionUtility.ID key = new global::Infragistics.CoreUtilities.AntirecursionUtility.ID(item, flagId);
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

			// Token: 0x06000225 RID: 549 RVA: 0x000097E4 File Offset: 0x000079E4
			public void Exit(object item, object flagId)
			{
				global::Infragistics.CoreUtilities.AntirecursionUtility.ID key = new global::Infragistics.CoreUtilities.AntirecursionUtility.ID(item, flagId);
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

			// Token: 0x06000226 RID: 550 RVA: 0x00009835 File Offset: 0x00007A35
			public bool InProgress(object item, object flagId)
			{
				return this._map != null && this._map.ContainsKey(new global::Infragistics.CoreUtilities.AntirecursionUtility.ID(item, flagId));
			}

			// Token: 0x040000B2 RID: 178
			private global::System.Collections.Generic.Dictionary<global::Infragistics.CoreUtilities.AntirecursionUtility.ID, int> _map;

			// Token: 0x02000033 RID: 51
			private struct ID
			{
				// Token: 0x06000228 RID: 552 RVA: 0x0000985B File Offset: 0x00007A5B
				internal ID(object item, object flagId)
				{
					this._item = item;
					this._flagId = flagId;
				}

				// Token: 0x06000229 RID: 553 RVA: 0x0000986B File Offset: 0x00007A6B
				internal static int GetHashCode(object o)
				{
					if (o == null)
					{
						return 0;
					}
					return o.GetHashCode();
				}

				// Token: 0x0600022A RID: 554 RVA: 0x00009878 File Offset: 0x00007A78
				public override int GetHashCode()
				{
					return global::Infragistics.CoreUtilities.AntirecursionUtility.ID.GetHashCode(this._item) ^ global::Infragistics.CoreUtilities.AntirecursionUtility.ID.GetHashCode(this._flagId);
				}

				// Token: 0x0600022B RID: 555 RVA: 0x00009894 File Offset: 0x00007A94
				public override bool Equals(object obj)
				{
					if (obj is global::Infragistics.CoreUtilities.AntirecursionUtility.ID)
					{
						global::Infragistics.CoreUtilities.AntirecursionUtility.ID id = (global::Infragistics.CoreUtilities.AntirecursionUtility.ID)obj;
						if (id._item == this._item && id._flagId == this._flagId)
						{
							return true;
						}
					}
					return false;
				}

				// Token: 0x040000B3 RID: 179
				internal object _item;

				// Token: 0x040000B4 RID: 180
				internal object _flagId;
			}
		}
	}
}
