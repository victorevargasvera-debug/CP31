using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NLog.Common;
using NLog.Config;

namespace NLog.Internal
{
	// Token: 0x02000113 RID: 275
	internal static class ObjectGraphScanner
	{
		// Token: 0x06000D35 RID: 3381 RVA: 0x000207CC File Offset: 0x0001E9CC
		public static global::System.Collections.Generic.List<T> FindReachableObjects<T>(bool aggressiveSearch, params object[] rootObjects) where T : class
		{
			if (global::NLog.Common.InternalLogger.IsTraceEnabled)
			{
				global::NLog.Common.InternalLogger.Trace<global::System.Type>("FindReachableObject<{0}>:", typeof(T));
			}
			global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>();
			global::System.Collections.Generic.HashSet<object> visitedObjects = new global::System.Collections.Generic.HashSet<object>();
			foreach (object o in rootObjects)
			{
				global::NLog.Internal.ObjectGraphScanner.ScanProperties<T>(aggressiveSearch, list, o, 0, visitedObjects);
			}
			return list.ToList<T>();
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x00020828 File Offset: 0x0001EA28
		private static void ScanProperties<T>(bool aggressiveSearch, global::System.Collections.Generic.List<T> result, object o, int level, global::System.Collections.Generic.HashSet<object> visitedObjects) where T : class
		{
			if (o == null)
			{
				return;
			}
			global::System.Type type = o.GetType();
			try
			{
				if (type == null || !type.IsDefined(typeof(global::NLog.Config.NLogConfigurationItemAttribute), true))
				{
					return;
				}
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Info(ex, "{0}Type reflection not possible for: {1}. Maybe because of .NET Native.", new object[]
				{
					new string(' ', level),
					o.ToString()
				});
				return;
			}
			if (visitedObjects.Contains(o))
			{
				return;
			}
			visitedObjects.Add(o);
			if (global::NLog.Common.InternalLogger.IsTraceEnabled)
			{
				global::NLog.Common.InternalLogger.Trace<string, string, object>("{0}Scanning {1} '{2}'", new string(' ', level), type.Name, o);
			}
			T item;
			if ((item = (o as T)) != null)
			{
				result.Add(item);
				if (!aggressiveSearch)
				{
					return;
				}
			}
			foreach (global::System.Reflection.PropertyInfo propertyInfo in global::NLog.Internal.PropertyHelper.GetAllReadableProperties(type))
			{
				if (!(propertyInfo == null) && !(propertyInfo.PropertyType == null) && !propertyInfo.PropertyType.IsPrimitive() && !propertyInfo.PropertyType.IsEnum() && !(propertyInfo.PropertyType == typeof(string)))
				{
					try
					{
						if (propertyInfo.IsDefined(typeof(global::NLog.Config.NLogConfigurationIgnorePropertyAttribute), true))
						{
							goto IL_274;
						}
					}
					catch (global::System.Exception ex2)
					{
						global::NLog.Common.InternalLogger.Info(ex2, "{0}Type reflection not possible for property {1}. Maybe because of .NET Native.", new object[]
						{
							new string(' ', level + 1),
							propertyInfo.Name
						});
						goto IL_274;
					}
					object value = propertyInfo.GetValue(o, null);
					if (value != null)
					{
						if (global::NLog.Common.InternalLogger.IsTraceEnabled)
						{
							global::NLog.Common.InternalLogger.Trace("{0}Scanning Property {1} '{2}' {3}", new object[]
							{
								new string(' ', level + 1),
								propertyInfo.Name,
								value.ToString(),
								propertyInfo.PropertyType.Namespace
							});
						}
						global::System.Collections.IList list;
						global::System.Collections.IEnumerable enumerable;
						if ((list = (value as global::System.Collections.IList)) != null)
						{
							object syncRoot = list.SyncRoot;
							global::System.Collections.Generic.List<object> list2;
							lock (syncRoot)
							{
								list2 = new global::System.Collections.Generic.List<object>(list.Count);
								for (int j = 0; j < list.Count; j++)
								{
									object item2 = list[j];
									list2.Add(item2);
								}
							}
							global::NLog.Internal.ObjectGraphScanner.ScanPropertiesList<T>(aggressiveSearch, result, list2, level + 1, visitedObjects);
						}
						else if ((enumerable = (value as global::System.Collections.IEnumerable)) != null)
						{
							global::System.Collections.Generic.IList<object> elements = (enumerable as global::System.Collections.Generic.IList<object>) ?? enumerable.Cast<object>().ToList<object>();
							global::NLog.Internal.ObjectGraphScanner.ScanPropertiesList<T>(aggressiveSearch, result, elements, level + 1, visitedObjects);
						}
						else
						{
							global::NLog.Internal.ObjectGraphScanner.ScanProperties<T>(aggressiveSearch, result, value, level + 1, visitedObjects);
						}
					}
				}
				IL_274:;
			}
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00020AE0 File Offset: 0x0001ECE0
		private static void ScanPropertiesList<T>(bool aggressiveSearch, global::System.Collections.Generic.List<T> result, global::System.Collections.Generic.IEnumerable<object> elements, int level, global::System.Collections.Generic.HashSet<object> visitedObjects) where T : class
		{
			foreach (object o in elements)
			{
				global::NLog.Internal.ObjectGraphScanner.ScanProperties<T>(aggressiveSearch, result, o, level, visitedObjects);
			}
		}
	}
}
