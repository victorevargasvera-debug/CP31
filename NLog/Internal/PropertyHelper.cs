using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Text;
using NLog.Common;
using NLog.Conditions;
using NLog.Config;
using NLog.Layouts;

namespace NLog.Internal
{
	// Token: 0x02000119 RID: 281
	internal static class PropertyHelper
	{
		// Token: 0x06000D66 RID: 3430 RVA: 0x0002146C File Offset: 0x0001F66C
		internal static void SetPropertyFromString(object obj, string propertyName, string value, global::NLog.Config.ConfigurationItemFactory configurationItemFactory)
		{
			global::NLog.Common.InternalLogger.Debug<string, string, string>("Setting '{0}.{1}' to '{2}'", obj.GetType().Name, propertyName, value);
			global::System.Reflection.PropertyInfo propertyInfo;
			if (!global::NLog.Internal.PropertyHelper.TryGetPropertyInfo(obj, propertyName, out propertyInfo))
			{
				throw new global::System.NotSupportedException(string.Format("Parameter {0} not supported on {1}", propertyName, obj.GetType().Name));
			}
			try
			{
				if (propertyInfo.IsDefined(typeof(global::NLog.Config.ArrayParameterAttribute), false))
				{
					throw new global::System.NotSupportedException(string.Format("Parameter {0} of {1} is an array and cannot be assigned a scalar value.", propertyName, obj.GetType().Name));
				}
				global::System.Type type = propertyInfo.PropertyType;
				type = (global::System.Nullable.GetUnderlyingType(type) ?? type);
				object value2;
				if (!global::NLog.Internal.PropertyHelper.TryNLogSpecificConversion(type, value, out value2, configurationItemFactory) && !global::NLog.Internal.PropertyHelper.TryGetEnumValue(type, value, out value2, true) && !global::NLog.Internal.PropertyHelper.TrySpecialConversion(type, value, out value2) && !global::NLog.Internal.PropertyHelper.TryImplicitConversion(type, value, out value2) && !global::NLog.Internal.PropertyHelper.TryFlatListConversion(type, value, out value2) && !global::NLog.Internal.PropertyHelper.TryTypeConverterConversion(type, value, out value2))
				{
					value2 = global::System.Convert.ChangeType(value, type, global::System.Globalization.CultureInfo.InvariantCulture);
				}
				propertyInfo.SetValue(obj, value2, null);
			}
			catch (global::System.Reflection.TargetInvocationException ex)
			{
				throw new global::NLog.NLogConfigurationException(string.Format("Error when setting property '{0}' on {1}", propertyInfo.Name, obj), ex.InnerException);
			}
			catch (global::System.Exception ex2)
			{
				global::NLog.Common.InternalLogger.Warn(ex2, "Error when setting property '{0}' on '{1}'", new object[]
				{
					propertyInfo.Name,
					obj
				});
				if (ex2.MustBeRethrownImmediately())
				{
					throw;
				}
				throw new global::NLog.NLogConfigurationException(string.Format("Error when setting property '{0}' on {1}", propertyInfo.Name, obj), ex2);
			}
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x000215D8 File Offset: 0x0001F7D8
		internal static bool IsArrayProperty(global::System.Type t, string propertyName)
		{
			global::System.Reflection.PropertyInfo propertyInfo;
			if (!global::NLog.Internal.PropertyHelper.TryGetPropertyInfo(t, propertyName, out propertyInfo))
			{
				throw new global::System.NotSupportedException(string.Format("Parameter {0} not supported on {1}", propertyName, t.Name));
			}
			return propertyInfo.IsDefined(typeof(global::NLog.Config.ArrayParameterAttribute), false);
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00021618 File Offset: 0x0001F818
		internal static bool TryGetPropertyInfo(object obj, string propertyName, out global::System.Reflection.PropertyInfo result)
		{
			global::System.Reflection.PropertyInfo property = obj.GetType().GetProperty(propertyName, global::System.Reflection.BindingFlags.IgnoreCase | global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public);
			if (property != null)
			{
				result = property;
				return true;
			}
			global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.Dictionary<string, global::System.Reflection.PropertyInfo>> obj2 = global::NLog.Internal.PropertyHelper.parameterInfoCache;
			bool result2;
			lock (obj2)
			{
				global::System.Type type = obj.GetType();
				global::System.Collections.Generic.Dictionary<string, global::System.Reflection.PropertyInfo> dictionary;
				if (!global::NLog.Internal.PropertyHelper.parameterInfoCache.TryGetValue(type, out dictionary))
				{
					dictionary = global::NLog.Internal.PropertyHelper.BuildPropertyInfoDictionary(type);
					global::NLog.Internal.PropertyHelper.parameterInfoCache[type] = dictionary;
				}
				result2 = dictionary.TryGetValue(propertyName, out result);
			}
			return result2;
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x000216A8 File Offset: 0x0001F8A8
		internal static global::System.Type GetArrayItemType(global::System.Reflection.PropertyInfo propInfo)
		{
			global::NLog.Config.ArrayParameterAttribute customAttribute = propInfo.GetCustomAttribute<global::NLog.Config.ArrayParameterAttribute>();
			if (customAttribute == null)
			{
				return null;
			}
			return customAttribute.ItemType;
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x000216BB File Offset: 0x0001F8BB
		internal static global::System.Reflection.PropertyInfo[] GetAllReadableProperties(global::System.Type type)
		{
			return type.GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public);
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x000216C8 File Offset: 0x0001F8C8
		internal static void CheckRequiredParameters(object o)
		{
			foreach (global::System.Reflection.PropertyInfo propertyInfo in global::NLog.Internal.PropertyHelper.GetAllReadableProperties(o.GetType()))
			{
				if (propertyInfo.IsDefined(typeof(global::NLog.Config.RequiredParameterAttribute), false) && propertyInfo.GetValue(o, null) == null)
				{
					throw new global::NLog.NLogConfigurationException(string.Format("Required parameter '{0}' on '{1}' was not specified.", propertyInfo.Name, o));
				}
			}
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00021728 File Offset: 0x0001F928
		private static bool TryImplicitConversion(global::System.Type resultType, string value, out object result)
		{
			try
			{
				if (global::System.Type.GetTypeCode(resultType) != global::System.TypeCode.Object)
				{
					result = null;
					return false;
				}
				global::System.Reflection.MethodInfo method = resultType.GetMethod("op_Implicit", global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public, null, new global::System.Type[]
				{
					value.GetType()
				}, null);
				if (method == null || !resultType.IsAssignableFrom(method.ReturnType))
				{
					result = null;
					return false;
				}
				result = method.Invoke(null, new object[]
				{
					value
				});
				return true;
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Warn(ex, "Implicit Conversion Failed of {0} to {1}", new object[]
				{
					value,
					resultType
				});
			}
			result = null;
			return false;
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x000217CC File Offset: 0x0001F9CC
		private static bool TryNLogSpecificConversion(global::System.Type propertyType, string value, out object newValue, global::NLog.Config.ConfigurationItemFactory configurationItemFactory)
		{
			if (propertyType == typeof(global::NLog.Layouts.Layout) || propertyType == typeof(global::NLog.Layouts.SimpleLayout))
			{
				newValue = new global::NLog.Layouts.SimpleLayout(value, configurationItemFactory);
				return true;
			}
			if (propertyType == typeof(global::NLog.Conditions.ConditionExpression))
			{
				newValue = global::NLog.Conditions.ConditionParser.ParseExpression(value, configurationItemFactory);
				return true;
			}
			newValue = null;
			return false;
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x0002182C File Offset: 0x0001FA2C
		private static bool TryGetEnumValue(global::System.Type resultType, string value, out object result, bool flagsEnumAllowed)
		{
			if (!resultType.IsEnum())
			{
				result = null;
				return false;
			}
			if (flagsEnumAllowed && resultType.IsDefined(typeof(global::System.FlagsAttribute), false))
			{
				ulong num = 0UL;
				foreach (string text in value.Split(new char[]
				{
					','
				}))
				{
					global::System.Reflection.FieldInfo field = resultType.GetField(text.Trim(), global::System.Reflection.BindingFlags.IgnoreCase | global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.FlattenHierarchy);
					if (field == null)
					{
						throw new global::NLog.NLogConfigurationException(string.Format("Invalid enumeration value '{0}'.", value));
					}
					num |= global::System.Convert.ToUInt64(field.GetValue(null), global::System.Globalization.CultureInfo.InvariantCulture);
				}
				result = global::System.Convert.ChangeType(num, global::System.Enum.GetUnderlyingType(resultType), global::System.Globalization.CultureInfo.InvariantCulture);
				result = global::System.Enum.ToObject(resultType, result);
				return true;
			}
			global::System.Reflection.FieldInfo field2 = resultType.GetField(value, global::System.Reflection.BindingFlags.IgnoreCase | global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.FlattenHierarchy);
			if (field2 == null)
			{
				throw new global::NLog.NLogConfigurationException(string.Format("Invalid enumeration value '{0}'.", value));
			}
			result = field2.GetValue(null);
			return true;
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00021920 File Offset: 0x0001FB20
		private static bool TrySpecialConversion(global::System.Type type, string value, out object newValue)
		{
			if (type == typeof(global::System.Text.Encoding))
			{
				value = value.Trim();
				newValue = global::System.Text.Encoding.GetEncoding(value);
				return true;
			}
			if (type == typeof(global::System.Globalization.CultureInfo))
			{
				value = value.Trim();
				newValue = new global::System.Globalization.CultureInfo(value);
				return true;
			}
			if (type == typeof(global::System.Type))
			{
				value = value.Trim();
				newValue = global::System.Type.GetType(value, true);
				return true;
			}
			newValue = null;
			return false;
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x000219A0 File Offset: 0x0001FBA0
		private static bool TryFlatListConversion(global::System.Type type, string valueRaw, out object newValue)
		{
			if (type.IsGenericType())
			{
				global::System.Type genericTypeDefinition = type.GetGenericTypeDefinition();
				bool flag = genericTypeDefinition == typeof(global::System.Collections.Generic.ISet<>) || genericTypeDefinition == typeof(global::System.Collections.Generic.HashSet<>);
				if (flag || genericTypeDefinition == typeof(global::System.Collections.Generic.List<>) || genericTypeDefinition == typeof(global::System.Collections.Generic.IList<>) || genericTypeDefinition == typeof(global::System.Collections.Generic.IEnumerable<>))
				{
					global::System.Type type2 = type.GetGenericArguments()[0];
					global::System.Type type3 = flag ? typeof(global::System.Collections.Generic.HashSet<>) : typeof(global::System.Collections.Generic.List<>);
					global::System.Type type4 = type2;
					global::System.Type type5 = type3.MakeGenericType(new global::System.Type[]
					{
						type4
					});
					object obj = global::System.Activator.CreateInstance(type5);
					if (obj == null)
					{
						throw new global::NLog.NLogConfigurationException("Cannot create instance of {0} for value {1}", new object[]
						{
							type.ToString(),
							valueRaw
						});
					}
					global::System.Collections.Generic.IEnumerable<string> enumerable = valueRaw.SplitQuoted(',', '\'', '\\');
					global::System.Reflection.MethodInfo method = type5.GetMethod("Add", global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public);
					if (method == null)
					{
						throw new global::NLog.NLogConfigurationException("Add method on type {0} for value {1} not found", new object[]
						{
							type.ToString(),
							valueRaw
						});
					}
					foreach (string value in enumerable)
					{
						if (!global::NLog.Internal.PropertyHelper.TryGetEnumValue(type2, value, out newValue, false) && !global::NLog.Internal.PropertyHelper.TrySpecialConversion(type2, value, out newValue) && !global::NLog.Internal.PropertyHelper.TryImplicitConversion(type2, value, out newValue) && !global::NLog.Internal.PropertyHelper.TryTypeConverterConversion(type2, value, out newValue))
						{
							newValue = global::System.Convert.ChangeType(value, type2, global::System.Globalization.CultureInfo.InvariantCulture);
						}
						method.Invoke(obj, new object[]
						{
							newValue
						});
					}
					newValue = obj;
					return true;
				}
			}
			newValue = null;
			return false;
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00021B60 File Offset: 0x0001FD60
		private static bool TryTypeConverterConversion(global::System.Type type, string value, out object newValue)
		{
			global::System.ComponentModel.TypeConverter converter = global::System.ComponentModel.TypeDescriptor.GetConverter(type);
			if (converter.CanConvertFrom(typeof(string)))
			{
				newValue = converter.ConvertFromInvariantString(value);
				return true;
			}
			newValue = null;
			return false;
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x00021B98 File Offset: 0x0001FD98
		private static bool TryGetPropertyInfo(global::System.Type targetType, string propertyName, out global::System.Reflection.PropertyInfo result)
		{
			if (!string.IsNullOrEmpty(propertyName))
			{
				global::System.Reflection.PropertyInfo property = targetType.GetProperty(propertyName, global::System.Reflection.BindingFlags.IgnoreCase | global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public);
				if (property != null)
				{
					result = property;
					return true;
				}
			}
			global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.Dictionary<string, global::System.Reflection.PropertyInfo>> obj = global::NLog.Internal.PropertyHelper.parameterInfoCache;
			bool result2;
			lock (obj)
			{
				global::System.Collections.Generic.Dictionary<string, global::System.Reflection.PropertyInfo> dictionary;
				if (!global::NLog.Internal.PropertyHelper.parameterInfoCache.TryGetValue(targetType, out dictionary))
				{
					dictionary = global::NLog.Internal.PropertyHelper.BuildPropertyInfoDictionary(targetType);
					global::NLog.Internal.PropertyHelper.parameterInfoCache[targetType] = dictionary;
				}
				result2 = dictionary.TryGetValue(propertyName, out result);
			}
			return result2;
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00021C20 File Offset: 0x0001FE20
		private static global::System.Collections.Generic.Dictionary<string, global::System.Reflection.PropertyInfo> BuildPropertyInfoDictionary(global::System.Type t)
		{
			global::System.Collections.Generic.Dictionary<string, global::System.Reflection.PropertyInfo> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Reflection.PropertyInfo>(global::System.StringComparer.OrdinalIgnoreCase);
			foreach (global::System.Reflection.PropertyInfo propertyInfo in global::NLog.Internal.PropertyHelper.GetAllReadableProperties(t))
			{
				global::NLog.Config.ArrayParameterAttribute customAttribute = propertyInfo.GetCustomAttribute<global::NLog.Config.ArrayParameterAttribute>();
				if (customAttribute != null)
				{
					dictionary[customAttribute.ElementName] = propertyInfo;
				}
				else
				{
					dictionary[propertyInfo.Name] = propertyInfo;
				}
				if (propertyInfo.IsDefined(typeof(global::NLog.Config.DefaultParameterAttribute), false))
				{
					dictionary[string.Empty] = propertyInfo;
				}
			}
			return dictionary;
		}

		// Token: 0x040003B1 RID: 945
		private static global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.Dictionary<string, global::System.Reflection.PropertyInfo>> parameterInfoCache = new global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.Dictionary<string, global::System.Reflection.PropertyInfo>>();
	}
}
