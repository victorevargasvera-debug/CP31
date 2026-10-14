using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Infragistics.Collections;

namespace Infragistics
{
	// Token: 0x0200001A RID: 26
	public class CoreUtilities
	{
		// Token: 0x0600013A RID: 314 RVA: 0x00006B14 File Offset: 0x00004D14
		protected CoreUtilities()
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00006B1C File Offset: 0x00004D1C
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

		// Token: 0x0600013C RID: 316 RVA: 0x00006B34 File Offset: 0x00004D34
		internal static bool AreClose(global::System.Windows.Point pt1, global::System.Windows.Point pt2)
		{
			return global::Infragistics.CoreUtilities.AreClose(pt1.X, pt2.X) && global::Infragistics.CoreUtilities.AreClose(pt1.Y, pt2.Y);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00006B60 File Offset: 0x00004D60
		internal static bool AreClose(global::System.Windows.Size x, global::System.Windows.Size y)
		{
			return global::Infragistics.CoreUtilities.AreClose(x.Width, y.Width) && global::Infragistics.CoreUtilities.AreClose(x.Height, y.Height);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00006B8C File Offset: 0x00004D8C
		internal static bool AreClose(double value1, double value2)
		{
			return value1 == value2 || global::System.Math.Abs(value1 - value2) < 1E-10;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00006BA7 File Offset: 0x00004DA7
		internal static bool LessThan(double x, double y)
		{
			return x < y && !global::Infragistics.CoreUtilities.AreClose(x, y);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00006BB9 File Offset: 0x00004DB9
		internal static bool GreaterThan(double x, double y)
		{
			return x > y && !global::Infragistics.CoreUtilities.AreClose(x, y);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00006BCB File Offset: 0x00004DCB
		internal static bool LessThanOrClose(double x, double y)
		{
			return x <= y || global::Infragistics.CoreUtilities.AreClose(x, y);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00006BDA File Offset: 0x00004DDA
		internal static bool GreaterThanOrClose(double x, double y)
		{
			return x >= y || global::Infragistics.CoreUtilities.AreClose(x, y);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00006BEC File Offset: 0x00004DEC
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

		// Token: 0x06000144 RID: 324 RVA: 0x00006C64 File Offset: 0x00004E64
		internal static int BinarySearch(global::System.Collections.Generic.IList<global::Infragistics.DateRange> ranges, global::System.DateTime date)
		{
			global::System.Func<global::System.Collections.Generic.IList<global::Infragistics.DateRange>, int, global::Infragistics.DateRange> rangeProviderCallback = (global::System.Collections.Generic.IList<global::Infragistics.DateRange> list, int index) => ranges[index];
			return global::Infragistics.CoreUtilities.BinarySearchDateRange<global::Infragistics.DateRange>(ranges, rangeProviderCallback, date, ranges.Count);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00006CA4 File Offset: 0x00004EA4
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

		// Token: 0x06000146 RID: 326 RVA: 0x00006D64 File Offset: 0x00004F64
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

		// Token: 0x06000147 RID: 327 RVA: 0x00006DB8 File Offset: 0x00004FB8
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

		// Token: 0x06000148 RID: 328 RVA: 0x00006E10 File Offset: 0x00005010
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

		// Token: 0x06000149 RID: 329 RVA: 0x00006E90 File Offset: 0x00005090
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

		// Token: 0x0600014A RID: 330 RVA: 0x00006F24 File Offset: 0x00005124
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

		// Token: 0x0600014B RID: 331 RVA: 0x00006F94 File Offset: 0x00005194
		internal static global::Infragistics.CoreUtilities.TypeConverterInfo GetTypeConverterInfo(global::System.Type objectType, global::System.Type convertToType)
		{
			global::System.ComponentModel.TypeConverter typeConverter = (null != objectType) ? global::System.ComponentModel.TypeDescriptor.GetConverter(objectType) : null;
			global::System.ComponentModel.TypeConverter typeConverter2 = (null != convertToType) ? global::System.ComponentModel.TypeDescriptor.GetConverter(convertToType) : null;
			if (typeConverter != null || typeConverter2 != null)
			{
				bool useConvertFromTypeConverterFirst = null != objectType && !objectType.IsPrimitive;
				return new global::Infragistics.CoreUtilities.TypeConverterInfo(typeConverter2, typeConverter, useConvertFromTypeConverterFirst);
			}
			return null;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00006FF1 File Offset: 0x000051F1
		public static object ConvertDataValue(object valueToConvert, global::System.Type convertToType, global::System.IFormatProvider formatProvider, string format)
		{
			return global::Infragistics.CoreUtilities.ConvertDataValue(valueToConvert, convertToType, formatProvider, format, true);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00007000 File Offset: 0x00005200
		internal static object ConvertDataValue(object valueToConvert, global::System.Type convertToType, global::System.IFormatProvider formatProvider, string format, bool useTypeConverters)
		{
			object obj = null;
			global::System.Type underlyingType = global::Infragistics.CoreUtilities.GetUnderlyingType(convertToType);
			if (valueToConvert == null || valueToConvert is global::System.DBNull)
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
										goto IL_D8;
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
							IL_D8:
							if (obj == null)
							{
								if (i != 0 || typeConverterInfo.useConvertFromTypeConverterFirst)
								{
									if (1 != i || !typeConverterInfo.useConvertFromTypeConverterFirst)
									{
										goto IL_122;
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
							IL_122:;
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
				if (obj == null && underlyingType.IsEnum)
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
							obj = global::System.Enum.ToObject(underlyingType, valueToConvert);
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

		// Token: 0x0600014E RID: 334 RVA: 0x000072C8 File Offset: 0x000054C8
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

		// Token: 0x0600014F RID: 335 RVA: 0x0000732C File Offset: 0x0000552C
		internal static void CopyTo(global::System.Collections.IEnumerable source, global::System.Array dest, int destStartIndex)
		{
			foreach (object value in source)
			{
				dest.SetValue(value, destStartIndex++);
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00007384 File Offset: 0x00005584
		internal static global::System.Collections.Specialized.NotifyCollectionChangedEventArgs CreateAddRemoveNCCArgs(bool add, global::System.Collections.IList addRemoveMultiItems, int index)
		{
			global::System.Collections.Specialized.NotifyCollectionChangedAction action = add ? global::System.Collections.Specialized.NotifyCollectionChangedAction.Add : global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove;
			return new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(action, addRemoveMultiItems, index);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000073A1 File Offset: 0x000055A1
		public static global::System.Collections.Generic.IComparer<T> CreateComparer<T>(global::System.Comparison<T> comparison)
		{
			return new global::Infragistics.CoreUtilities.ComparisonComparer<T>(comparison);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000073A9 File Offset: 0x000055A9
		public static global::System.Collections.Generic.IComparer<T> CreateComparer<T>(global::System.Collections.IComparer comparer)
		{
			return (comparer as global::System.Collections.Generic.IComparer<T>) ?? new global::Infragistics.CoreUtilities.ComparerWrapper<T>(comparer);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000073BB File Offset: 0x000055BB
		internal static global::System.Collections.Specialized.NotifyCollectionChangedEventArgs CreateReplaceNCCArgs(global::System.Collections.IList oldItems, global::System.Collections.IList newItems, int index)
		{
			return new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace, newItems, oldItems, index);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000073C6 File Offset: 0x000055C6
		internal static void EnsureIsANumber(double number)
		{
			if (double.IsNaN(number))
			{
				throw new global::System.ArgumentOutOfRangeException("number", "The value cannot be 'double.NaN'.");
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000073E0 File Offset: 0x000055E0
		internal static int GetCount(global::System.Collections.IEnumerable e)
		{
			return global::Infragistics.CoreUtilities.GetCount(e, false);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000073EC File Offset: 0x000055EC
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

		// Token: 0x06000157 RID: 343 RVA: 0x00007454 File Offset: 0x00005654
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

		// Token: 0x06000158 RID: 344 RVA: 0x000074A8 File Offset: 0x000056A8
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

		// Token: 0x06000159 RID: 345 RVA: 0x00007568 File Offset: 0x00005768
		internal static bool IsKnownType(global::System.Type type)
		{
			if (type == null)
			{
				return false;
			}
			type = global::Infragistics.CoreUtilities.GetUnderlyingType(type);
			return type.IsPrimitive || typeof(decimal) == type || typeof(string) == type || typeof(global::System.DateTime) == type || typeof(global::System.DayOfWeek) == type || typeof(global::System.Windows.Media.Color) == type || typeof(global::System.Drawing.Color) == type || typeof(global::System.Windows.Media.Visual).IsAssignableFrom(type) || typeof(global::System.Windows.Media.Animation.Animatable).IsAssignableFrom(type);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00007628 File Offset: 0x00005828
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

		// Token: 0x0600015B RID: 347 RVA: 0x000076A0 File Offset: 0x000058A0
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

		// Token: 0x0600015C RID: 348 RVA: 0x00007734 File Offset: 0x00005934
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

		// Token: 0x0600015D RID: 349 RVA: 0x000077A4 File Offset: 0x000059A4
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

		// Token: 0x0600015E RID: 350 RVA: 0x00007858 File Offset: 0x00005A58
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

		// Token: 0x0600015F RID: 351 RVA: 0x000078D4 File Offset: 0x00005AD4
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

		// Token: 0x06000160 RID: 352 RVA: 0x00007900 File Offset: 0x00005B00
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

		// Token: 0x06000161 RID: 353 RVA: 0x00007930 File Offset: 0x00005B30
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

		// Token: 0x06000162 RID: 354 RVA: 0x0000799C File Offset: 0x00005B9C
		internal static bool IsValueEmpty(object val)
		{
			return val == null || global::System.DBNull.Value == val || string.Empty == val as string || global::System.Windows.DependencyProperty.UnsetValue == val;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000079C8 File Offset: 0x00005BC8
		internal static void Normalize(ref global::System.DateTime start, ref global::System.DateTime end)
		{
			if (end < start)
			{
				global::System.DateTime dateTime = start;
				start = end;
				end = dateTime;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00007A02 File Offset: 0x00005C02
		internal static void RaiseReadOnlyCollectionException()
		{
			throw new global::System.NotSupportedException("Collection is read-only.");
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00007A10 File Offset: 0x00005C10
		public static void RemoveAll<T>(global::System.Collections.Generic.List<T> list, T itemToRemove)
		{
			int num = global::Infragistics.CoreUtilities.RemoveAllHelper<T>(list, itemToRemove);
			list.RemoveRange(num, list.Count - num);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00007A34 File Offset: 0x00005C34
		public static void RemoveAll<T>(global::System.Collections.Generic.IList<T> list, T itemToRemove)
		{
			int num = global::Infragistics.CoreUtilities.RemoveAllHelper<T>(list, itemToRemove);
			for (int i = list.Count - 1; i >= num; i--)
			{
				list.RemoveAt(i);
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00007A64 File Offset: 0x00005C64
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

		// Token: 0x06000168 RID: 360 RVA: 0x00007AA8 File Offset: 0x00005CA8
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

		// Token: 0x06000169 RID: 361 RVA: 0x00007AFC File Offset: 0x00005CFC
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

		// Token: 0x0600016A RID: 362 RVA: 0x00007B6C File Offset: 0x00005D6C
		public static void SortMerge(object[] array, global::System.Collections.IComparer comparer)
		{
			global::Infragistics.CoreUtilities.SortMerge(array, null, comparer);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00007B76 File Offset: 0x00005D76
		public static void SortMerge(object[] array, object[] tempArray, global::System.Collections.IComparer comparer)
		{
			global::Infragistics.CoreUtilities.SortMerge(array, tempArray, comparer, 0, array.Length - 1);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00007B88 File Offset: 0x00005D88
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

		// Token: 0x0600016D RID: 365 RVA: 0x00007BE0 File Offset: 0x00005DE0
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

		// Token: 0x0600016E RID: 366 RVA: 0x00007C28 File Offset: 0x00005E28
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

		// Token: 0x0600016F RID: 367 RVA: 0x00007C8E File Offset: 0x00005E8E
		public static void SortMergeGeneric<T>(T[] array, global::System.Collections.Generic.IComparer<T> comparer)
		{
			global::Infragistics.CoreUtilities.SortMergeGeneric<T>(array, null, comparer);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00007C98 File Offset: 0x00005E98
		public static void SortMergeGeneric<T>(T[] array, T[] tempArray, global::System.Collections.Generic.IComparer<T> comparer)
		{
			global::Infragistics.CoreUtilities.SortMergeGeneric<T>(array, tempArray, comparer, 0, array.Length - 1);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00007CA8 File Offset: 0x00005EA8
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

		// Token: 0x06000172 RID: 370 RVA: 0x00007CF8 File Offset: 0x00005EF8
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

		// Token: 0x06000173 RID: 371 RVA: 0x00007DF0 File Offset: 0x00005FF0
		public static void Swap<T>(global::System.Collections.Generic.IList<T> arr, int x, int y)
		{
			T value = arr[x];
			arr[x] = arr[y];
			arr[y] = value;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00007E1C File Offset: 0x0000601C
		internal static void Swap<T>(ref T value1, ref T value2)
		{
			T t = value2;
			value2 = value1;
			value1 = t;
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00007E44 File Offset: 0x00006044
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

		// Token: 0x06000176 RID: 374 RVA: 0x00007EA0 File Offset: 0x000060A0
		internal static void Traverse(global::System.Collections.IEnumerable e)
		{
			foreach (object obj in e)
			{
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00007EE8 File Offset: 0x000060E8
		private static bool IsEnumFlags(global::System.Type enumType)
		{
			object[] customAttributes = enumType.GetCustomAttributes(typeof(global::System.FlagsAttribute), true);
			return customAttributes != null && customAttributes.Length > 0;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00007F12 File Offset: 0x00006112
		internal static void ValidateEnum(global::System.Type enumType, object enumVal)
		{
			if (!global::System.Enum.IsDefined(enumType, enumVal) && !global::Infragistics.CoreUtilities.IsEnumFlags(enumType))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException(enumType.Name, (int)enumVal, enumType);
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00007F38 File Offset: 0x00006138
		internal static void ValidateEnum(string argumentName, global::System.Type enumType, object enumVal)
		{
			if (!global::System.Enum.IsDefined(enumType, enumVal) && !global::Infragistics.CoreUtilities.IsEnumFlags(enumType))
			{
				throw new global::System.ComponentModel.InvalidEnumArgumentException(argumentName, (int)enumVal, enumType);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00007F59 File Offset: 0x00006159
		internal static void ValidateIsNotNan(double value)
		{
			if (double.IsNaN(value))
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ValueCannotBeNan"));
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00007F73 File Offset: 0x00006173
		internal static void ValidateIsNotInfinity(double value)
		{
			if (double.IsInfinity(value))
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ValueCannotBeInfinity"));
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00007F8D File Offset: 0x0000618D
		internal static void ValidateIsNotNegative(double value)
		{
			if (value < 0.0)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_ValueCannotBeNegative"));
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00007FAB File Offset: 0x000061AB
		internal static void ValidateIsNotNegative(double value, string paramName)
		{
			if (value < 0.0)
			{
				throw new global::System.ArgumentException(paramName, global::SR.GetString("LE_ValueCannotBeNegative"));
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00007FCA File Offset: 0x000061CA
		internal static void ValidateNotEmpty(string value)
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new global::System.ArgumentException();
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00007FDA File Offset: 0x000061DA
		internal static void ValidateNotEmpty(string value, string paramName)
		{
			if (string.IsNullOrEmpty(value))
			{
				throw new global::System.ArgumentException(paramName);
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00007FEB File Offset: 0x000061EB
		internal static void ValidateNotNull(object value)
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException();
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00007FF6 File Offset: 0x000061F6
		internal static void ValidateNotNull(object value, string paramName)
		{
			if (value == null)
			{
				throw new global::System.ArgumentNullException(paramName);
			}
		}

		// Token: 0x0400005C RID: 92
		[global::System.ThreadStatic]
		private static global::Infragistics.CoreUtilities.AntirecursionUtility g_antirecursionUtility;

		// Token: 0x0400005D RID: 93
		[global::System.ThreadStatic]
		private static global::System.Type lastNonConvertibleDataType;

		// Token: 0x0200001B RID: 27
		internal class AggregateEnumerable<T> : global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable
		{
			// Token: 0x06000182 RID: 386 RVA: 0x00008002 File Offset: 0x00006202
			public AggregateEnumerable(params global::System.Collections.Generic.IEnumerable<T>[] enumerables) : this((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<T>>)enumerables)
			{
			}

			// Token: 0x06000183 RID: 387 RVA: 0x00008010 File Offset: 0x00006210
			public AggregateEnumerable(global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<T>> enumerables)
			{
				this._enumerables = enumerables;
			}

			// Token: 0x06000184 RID: 388 RVA: 0x0000801F File Offset: 0x0000621F
			public global::System.Collections.IEnumerator GetEnumerator()
			{
				return new global::Infragistics.CoreUtilities.AggregateEnumerable<T>.Enumerator(this._enumerables);
			}

			// Token: 0x06000185 RID: 389 RVA: 0x0000802C File Offset: 0x0000622C
			global::System.Collections.Generic.IEnumerator<T> global::System.Collections.Generic.IEnumerable<!0>.GetEnumerator()
			{
				return new global::Infragistics.CoreUtilities.AggregateEnumerable<T>.Enumerator(this._enumerables);
			}

			// Token: 0x0400005E RID: 94
			private global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<T>> _enumerables;

			// Token: 0x0200001C RID: 28
			public class Enumerator : global::System.Collections.Generic.IEnumerator<T>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x06000186 RID: 390 RVA: 0x00008039 File Offset: 0x00006239
				public Enumerator(params global::System.Collections.Generic.IEnumerable<T>[] enumerables) : this((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<T>>)enumerables)
				{
				}

				// Token: 0x06000187 RID: 391 RVA: 0x00008047 File Offset: 0x00006247
				public Enumerator(global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.IEnumerable<T>> enumerables)
				{
					this._enumerables = ((enumerables != null) ? enumerables.GetEnumerator() : null);
				}

				// Token: 0x06000188 RID: 392 RVA: 0x00008061 File Offset: 0x00006261
				public void Reset()
				{
					if (this._enumerables != null)
					{
						this._enumerables.Reset();
					}
					this._current = null;
				}

				// Token: 0x06000189 RID: 393 RVA: 0x00008080 File Offset: 0x00006280
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

				// Token: 0x17000028 RID: 40
				// (get) Token: 0x0600018A RID: 394 RVA: 0x000080E4 File Offset: 0x000062E4
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

				// Token: 0x17000029 RID: 41
				// (get) Token: 0x0600018B RID: 395 RVA: 0x0000810E File Offset: 0x0000630E
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						return this.Current;
					}
				}

				// Token: 0x0600018C RID: 396 RVA: 0x0000811B File Offset: 0x0000631B
				public void Dispose()
				{
				}

				// Token: 0x0400005F RID: 95
				private global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.IEnumerable<T>> _enumerables;

				// Token: 0x04000060 RID: 96
				private global::System.Collections.Generic.IEnumerator<T> _current;
			}
		}

		// Token: 0x0200001D RID: 29
		private sealed class ComparisonComparer<T> : global::System.Collections.Generic.IComparer<T>
		{
			// Token: 0x0600018D RID: 397 RVA: 0x0000811D File Offset: 0x0000631D
			internal ComparisonComparer(global::System.Comparison<T> comparison)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(comparison, "comparison");
				this._c = comparison;
			}

			// Token: 0x0600018E RID: 398 RVA: 0x00008137 File Offset: 0x00006337
			public int Compare(T x, T y)
			{
				return this._c(x, y);
			}

			// Token: 0x04000061 RID: 97
			private global::System.Comparison<T> _c;
		}

		// Token: 0x0200001E RID: 30
		internal class ConverterComparer<T, Z> : global::System.Collections.Generic.IComparer<T>
		{
			// Token: 0x0600018F RID: 399 RVA: 0x00008146 File Offset: 0x00006346
			public ConverterComparer(global::System.Converter<T, Z> converter, global::System.Comparison<Z> comparison) : this(converter, global::Infragistics.CoreUtilities.CreateComparer<Z>(comparison))
			{
			}

			// Token: 0x06000190 RID: 400 RVA: 0x00008155 File Offset: 0x00006355
			public ConverterComparer(global::System.Converter<T, Z> converter, global::System.Collections.Generic.IComparer<Z> comparer)
			{
				this._converter = converter;
				this._comparer = comparer;
			}

			// Token: 0x06000191 RID: 401 RVA: 0x0000816B File Offset: 0x0000636B
			public int Compare(T i, T j)
			{
				return this._comparer.Compare(this._converter(i), this._converter(j));
			}

			// Token: 0x04000062 RID: 98
			private global::System.Converter<T, Z> _converter;

			// Token: 0x04000063 RID: 99
			private global::System.Collections.Generic.IComparer<Z> _comparer;
		}

		// Token: 0x0200001F RID: 31
		internal class EmptyEnumerable<T> : global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable
		{
			// Token: 0x06000193 RID: 403 RVA: 0x00008198 File Offset: 0x00006398
			public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
			{
				return new global::Infragistics.CoreUtilities.EmptyEnumerable<T>.Enumerator();
			}

			// Token: 0x06000194 RID: 404 RVA: 0x0000819F File Offset: 0x0000639F
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x02000020 RID: 32
			public class Enumerator : global::System.Collections.Generic.IEnumerator<T>, global::System.IDisposable, global::System.Collections.IEnumerator
			{
				// Token: 0x1700002A RID: 42
				// (get) Token: 0x06000196 RID: 406 RVA: 0x000081AF File Offset: 0x000063AF
				public T Current
				{
					get
					{
						throw new global::System.InvalidOperationException();
					}
				}

				// Token: 0x06000197 RID: 407 RVA: 0x000081B6 File Offset: 0x000063B6
				public void Dispose()
				{
				}

				// Token: 0x1700002B RID: 43
				// (get) Token: 0x06000198 RID: 408 RVA: 0x000081B8 File Offset: 0x000063B8
				object global::System.Collections.IEnumerator.Current
				{
					get
					{
						throw new global::System.InvalidOperationException();
					}
				}

				// Token: 0x06000199 RID: 409 RVA: 0x000081BF File Offset: 0x000063BF
				public bool MoveNext()
				{
					return false;
				}

				// Token: 0x0600019A RID: 410 RVA: 0x000081C2 File Offset: 0x000063C2
				public void Reset()
				{
				}
			}
		}

		// Token: 0x02000021 RID: 33
		internal class TypedList<T> : global::System.Collections.Generic.IList<!0>, global::System.Collections.Generic.ICollection<!0>, global::System.Collections.Generic.IEnumerable<T>, global::System.Collections.IEnumerable
		{
			// Token: 0x0600019B RID: 411 RVA: 0x000081C4 File Offset: 0x000063C4
			internal TypedList(global::System.Collections.IList list)
			{
				global::Infragistics.CoreUtilities.ValidateNotNull(list);
				this._list = list;
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x0600019C RID: 412 RVA: 0x000081D9 File Offset: 0x000063D9
			internal global::System.Collections.IList List
			{
				get
				{
					return this._list;
				}
			}

			// Token: 0x0600019D RID: 413 RVA: 0x000081E1 File Offset: 0x000063E1
			public int IndexOf(T item)
			{
				return this._list.IndexOf(item);
			}

			// Token: 0x0600019E RID: 414 RVA: 0x000081F4 File Offset: 0x000063F4
			public void Insert(int index, T item)
			{
				this._list.Insert(index, item);
			}

			// Token: 0x0600019F RID: 415 RVA: 0x00008208 File Offset: 0x00006408
			public void RemoveAt(int index)
			{
				this._list.RemoveAt(index);
			}

			// Token: 0x1700002D RID: 45
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

			// Token: 0x060001A2 RID: 418 RVA: 0x0000823D File Offset: 0x0000643D
			public void Add(T item)
			{
				this._list.Add(item);
			}

			// Token: 0x060001A3 RID: 419 RVA: 0x00008251 File Offset: 0x00006451
			public void Clear()
			{
				this._list.Clear();
			}

			// Token: 0x060001A4 RID: 420 RVA: 0x0000825E File Offset: 0x0000645E
			public bool Contains(T item)
			{
				return this._list.Contains(item);
			}

			// Token: 0x060001A5 RID: 421 RVA: 0x00008271 File Offset: 0x00006471
			public void CopyTo(T[] array, int arrayIndex)
			{
				global::Infragistics.CoreUtilities.CopyTo<T>(this, array, arrayIndex);
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000827B File Offset: 0x0000647B
			public int Count
			{
				get
				{
					return this._list.Count;
				}
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x060001A7 RID: 423 RVA: 0x00008288 File Offset: 0x00006488
			public bool IsReadOnly
			{
				get
				{
					return this._list.IsReadOnly;
				}
			}

			// Token: 0x060001A8 RID: 424 RVA: 0x00008298 File Offset: 0x00006498
			public bool Remove(T item)
			{
				int num = this._list.IndexOf(item);
				if (num >= 0)
				{
					this._list.RemoveAt(num);
				}
				return num >= 0;
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x000082CE File Offset: 0x000064CE
			public global::System.Collections.Generic.IEnumerator<T> GetEnumerator()
			{
				return new global::Infragistics.Collections.TypedEnumerable<T>.Enumerator(this._list.GetEnumerator());
			}

			// Token: 0x060001AA RID: 426 RVA: 0x000082E0 File Offset: 0x000064E0
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this._list.GetEnumerator();
			}

			// Token: 0x04000064 RID: 100
			private global::System.Collections.IList _list;
		}

		// Token: 0x02000022 RID: 34
		internal class ObservableTypedList<T> : global::Infragistics.CoreUtilities.TypedList<T>, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.ComponentModel.INotifyPropertyChanged
		{
			// Token: 0x060001AB RID: 427 RVA: 0x000082F0 File Offset: 0x000064F0
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

			// Token: 0x060001AC RID: 428 RVA: 0x0000833C File Offset: 0x0000653C
			private void OnCollectionPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
			{
				global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
				if (propertyChanged != null)
				{
					propertyChanged(this, e);
				}
			}

			// Token: 0x060001AD RID: 429 RVA: 0x0000835C File Offset: 0x0000655C
			private void OnCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
			{
				global::System.Collections.Specialized.NotifyCollectionChangedEventHandler collectionChanged = this.CollectionChanged;
				if (collectionChanged != null)
				{
					collectionChanged(this, e);
				}
			}

			// Token: 0x14000002 RID: 2
			// (add) Token: 0x060001AE RID: 430 RVA: 0x0000837C File Offset: 0x0000657C
			// (remove) Token: 0x060001AF RID: 431 RVA: 0x000083B4 File Offset: 0x000065B4
			public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

			// Token: 0x14000003 RID: 3
			// (add) Token: 0x060001B0 RID: 432 RVA: 0x000083EC File Offset: 0x000065EC
			// (remove) Token: 0x060001B1 RID: 433 RVA: 0x00008424 File Offset: 0x00006624
			public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;
		}

		// Token: 0x02000023 RID: 35
		internal class TypeConverterInfo
		{
			// Token: 0x060001B2 RID: 434 RVA: 0x00008459 File Offset: 0x00006659
			internal TypeConverterInfo(global::System.ComponentModel.TypeConverter convertFromTypeConverter, global::System.ComponentModel.TypeConverter convertToTypeConverter, bool useConvertFromTypeConverterFirst)
			{
				this.convertFromTypeConverter = convertFromTypeConverter;
				this.convertToTypeConverter = convertToTypeConverter;
				this.useConvertFromTypeConverterFirst = useConvertFromTypeConverterFirst;
			}

			// Token: 0x04000067 RID: 103
			internal global::System.ComponentModel.TypeConverter convertFromTypeConverter;

			// Token: 0x04000068 RID: 104
			internal global::System.ComponentModel.TypeConverter convertToTypeConverter;

			// Token: 0x04000069 RID: 105
			internal bool useConvertFromTypeConverterFirst;
		}

		// Token: 0x02000024 RID: 36
		private class ComparerWrapper<T> : global::System.Collections.Generic.IComparer<T>
		{
			// Token: 0x060001B3 RID: 435 RVA: 0x00008476 File Offset: 0x00006676
			public ComparerWrapper(global::System.Collections.IComparer comparer)
			{
				this.comparer = comparer;
			}

			// Token: 0x060001B4 RID: 436 RVA: 0x00008485 File Offset: 0x00006685
			public int Compare(T x, T y)
			{
				return this.comparer.Compare(x, y);
			}

			// Token: 0x0400006A RID: 106
			private global::System.Collections.IComparer comparer;
		}

		// Token: 0x02000025 RID: 37
		internal class AntirecursionUtility
		{
			// Token: 0x17000030 RID: 48
			// (get) Token: 0x060001B5 RID: 437 RVA: 0x0000849E File Offset: 0x0000669E
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

			// Token: 0x060001B6 RID: 438 RVA: 0x000084BC File Offset: 0x000066BC
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

			// Token: 0x060001B7 RID: 439 RVA: 0x000084FC File Offset: 0x000066FC
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

			// Token: 0x060001B8 RID: 440 RVA: 0x0000854D File Offset: 0x0000674D
			public bool InProgress(object item, object flagId)
			{
				return this._map != null && this._map.ContainsKey(new global::Infragistics.CoreUtilities.AntirecursionUtility.ID(item, flagId));
			}

			// Token: 0x0400006B RID: 107
			private global::System.Collections.Generic.Dictionary<global::Infragistics.CoreUtilities.AntirecursionUtility.ID, int> _map;

			// Token: 0x02000026 RID: 38
			private struct ID
			{
				// Token: 0x060001BA RID: 442 RVA: 0x00008573 File Offset: 0x00006773
				internal ID(object item, object flagId)
				{
					this._item = item;
					this._flagId = flagId;
				}

				// Token: 0x060001BB RID: 443 RVA: 0x00008583 File Offset: 0x00006783
				internal static int GetHashCode(object o)
				{
					if (o == null)
					{
						return 0;
					}
					return o.GetHashCode();
				}

				// Token: 0x060001BC RID: 444 RVA: 0x00008590 File Offset: 0x00006790
				public override int GetHashCode()
				{
					return global::Infragistics.CoreUtilities.AntirecursionUtility.ID.GetHashCode(this._item) ^ global::Infragistics.CoreUtilities.AntirecursionUtility.ID.GetHashCode(this._flagId);
				}

				// Token: 0x060001BD RID: 445 RVA: 0x000085AC File Offset: 0x000067AC
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

				// Token: 0x0400006C RID: 108
				internal object _item;

				// Token: 0x0400006D RID: 109
				internal object _flagId;
			}
		}
	}
}
