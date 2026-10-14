using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000057 RID: 87
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal static class EnumUtils
	{
		// Token: 0x0600050A RID: 1290 RVA: 0x000152A0 File Offset: 0x000134A0
		private static global::Newtonsoft.Json.Utilities.EnumInfo InitializeValuesAndNames([global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			0,
			1,
			2
		})] global::Newtonsoft.Json.Utilities.StructMultiKey<global::System.Type, global::Newtonsoft.Json.Serialization.NamingStrategy> key)
		{
			global::System.Type value = key.Value1;
			string[] names = global::System.Enum.GetNames(value);
			string[] array = new string[names.Length];
			ulong[] array2 = new ulong[names.Length];
			for (int i = 0; i < names.Length; i++)
			{
				string text = names[i];
				global::System.Reflection.FieldInfo field = value.GetField(text, global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic);
				array2[i] = global::Newtonsoft.Json.Utilities.EnumUtils.ToUInt64(field.GetValue(null));
				string text2 = (from global::System.Runtime.Serialization.EnumMemberAttribute a in field.GetCustomAttributes(typeof(global::System.Runtime.Serialization.EnumMemberAttribute), true)
				select a.Value).SingleOrDefault<string>();
				bool hasSpecifiedName = text2 != null;
				string text3 = text2 ?? text;
				if (global::System.Array.IndexOf<string>(array, text3, 0, i) != -1)
				{
					throw new global::System.InvalidOperationException("Enum name '{0}' already exists on enum '{1}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text3, value.Name));
				}
				array[i] = ((key.Value2 != null) ? key.Value2.GetPropertyName(text3, hasSpecifiedName) : text3);
			}
			return new global::Newtonsoft.Json.Utilities.EnumInfo(value.IsDefined(typeof(global::System.FlagsAttribute), false), array2, names, array);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x000153BC File Offset: 0x000135BC
		[global::System.Runtime.CompilerServices.NullableContext(0)]
		[return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			0
		})]
		public static global::System.Collections.Generic.IList<T> GetFlagsValues<T>(T value) where T : struct
		{
			global::System.Type typeFromHandle = typeof(T);
			if (!typeFromHandle.IsDefined(typeof(global::System.FlagsAttribute), false))
			{
				throw new global::System.ArgumentException("Enum type {0} is not a set of flags.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, typeFromHandle));
			}
			global::System.Type underlyingType = global::System.Enum.GetUnderlyingType(value.GetType());
			ulong num = global::Newtonsoft.Json.Utilities.EnumUtils.ToUInt64(value);
			global::Newtonsoft.Json.Utilities.EnumInfo enumValuesAndNames = global::Newtonsoft.Json.Utilities.EnumUtils.GetEnumValuesAndNames(typeFromHandle);
			global::System.Collections.Generic.IList<T> list = new global::System.Collections.Generic.List<T>();
			for (int i = 0; i < enumValuesAndNames.Values.Length; i++)
			{
				ulong num2 = enumValuesAndNames.Values[i];
				if ((num & num2) == num2 && num2 != 0UL)
				{
					list.Add((T)((object)global::System.Convert.ChangeType(num2, underlyingType, global::System.Globalization.CultureInfo.CurrentCulture)));
				}
			}
			if (list.Count == 0)
			{
				if (enumValuesAndNames.Values.Any((ulong v) => v == 0UL))
				{
					list.Add(default(T));
				}
			}
			return list;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x000154BE File Offset: 0x000136BE
		public static bool TryToString(global::System.Type enumType, object value, bool camelCase, [global::System.Runtime.CompilerServices.Nullable(2)] [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out string name)
		{
			return global::Newtonsoft.Json.Utilities.EnumUtils.TryToString(enumType, value, camelCase ? global::Newtonsoft.Json.Utilities.EnumUtils._camelCaseNamingStrategy : null, out name);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000154D4 File Offset: 0x000136D4
		public static bool TryToString(global::System.Type enumType, object value, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, [global::System.Runtime.CompilerServices.Nullable(2)] [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out string name)
		{
			global::Newtonsoft.Json.Utilities.EnumInfo enumInfo = global::Newtonsoft.Json.Utilities.EnumUtils.ValuesAndNamesPerEnum.Get(new global::Newtonsoft.Json.Utilities.StructMultiKey<global::System.Type, global::Newtonsoft.Json.Serialization.NamingStrategy>(enumType, namingStrategy));
			ulong num = global::Newtonsoft.Json.Utilities.EnumUtils.ToUInt64(value);
			if (enumInfo.IsFlags)
			{
				name = global::Newtonsoft.Json.Utilities.EnumUtils.InternalFlagsFormat(enumInfo, num);
				return name != null;
			}
			int num2 = global::System.Array.BinarySearch<ulong>(enumInfo.Values, num);
			if (num2 >= 0)
			{
				name = enumInfo.ResolvedNames[num2];
				return true;
			}
			name = null;
			return false;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00015534 File Offset: 0x00013734
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		private static string InternalFlagsFormat(global::Newtonsoft.Json.Utilities.EnumInfo entry, ulong result)
		{
			string[] resolvedNames = entry.ResolvedNames;
			ulong[] values = entry.Values;
			int num = values.Length - 1;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			bool flag = true;
			ulong num2 = result;
			while (num >= 0 && (num != 0 || values[num] != 0UL))
			{
				if ((result & values[num]) == values[num])
				{
					result -= values[num];
					if (!flag)
					{
						stringBuilder.Insert(0, ", ");
					}
					string value = resolvedNames[num];
					stringBuilder.Insert(0, value);
					flag = false;
				}
				num--;
			}
			string result2;
			if (result != 0UL)
			{
				result2 = null;
			}
			else if (num2 == 0UL)
			{
				if (values.Length != 0 && values[0] == 0UL)
				{
					result2 = resolvedNames[0];
				}
				else
				{
					result2 = null;
				}
			}
			else
			{
				result2 = stringBuilder.ToString();
			}
			return result2;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x000155D2 File Offset: 0x000137D2
		public static global::Newtonsoft.Json.Utilities.EnumInfo GetEnumValuesAndNames(global::System.Type enumType)
		{
			return global::Newtonsoft.Json.Utilities.EnumUtils.ValuesAndNamesPerEnum.Get(new global::Newtonsoft.Json.Utilities.StructMultiKey<global::System.Type, global::Newtonsoft.Json.Serialization.NamingStrategy>(enumType, null));
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000155E8 File Offset: 0x000137E8
		private static ulong ToUInt64(object value)
		{
			bool flag;
			switch (global::Newtonsoft.Json.Utilities.ConvertUtils.GetTypeCode(value.GetType(), out flag))
			{
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Char:
				return (ulong)((char)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Boolean:
				return (ulong)global::System.Convert.ToByte((bool)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SByte:
				return (ulong)((long)((sbyte)value));
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int16:
				return (ulong)((long)((short)value));
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt16:
				return (ulong)((ushort)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int32:
				return (ulong)((long)((int)value));
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Byte:
				return (ulong)((byte)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt32:
				return (ulong)((uint)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int64:
				return (ulong)((long)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt64:
				return (ulong)value;
			}
			throw new global::System.InvalidOperationException("Unknown enum type.");
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x000156B8 File Offset: 0x000138B8
		public static object ParseEnum(global::System.Type enumType, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, string value, bool disallowNumber)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(enumType, "enumType");
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(value, "value");
			if (!enumType.IsEnum())
			{
				throw new global::System.ArgumentException("Type provided must be an Enum.", "enumType");
			}
			global::Newtonsoft.Json.Utilities.EnumInfo enumInfo = global::Newtonsoft.Json.Utilities.EnumUtils.ValuesAndNamesPerEnum.Get(new global::Newtonsoft.Json.Utilities.StructMultiKey<global::System.Type, global::Newtonsoft.Json.Serialization.NamingStrategy>(enumType, namingStrategy));
			string[] names = enumInfo.Names;
			string[] resolvedNames = enumInfo.ResolvedNames;
			ulong[] values = enumInfo.Values;
			int? num = global::Newtonsoft.Json.Utilities.EnumUtils.FindIndexByName(resolvedNames, value, 0, value.Length, global::System.StringComparison.Ordinal);
			if (num != null)
			{
				return global::System.Enum.ToObject(enumType, values[num.Value]);
			}
			int num2 = -1;
			for (int i = 0; i < value.Length; i++)
			{
				if (!char.IsWhiteSpace(value[i]))
				{
					num2 = i;
					break;
				}
			}
			if (num2 == -1)
			{
				throw new global::System.ArgumentException("Must specify valid information for parsing in the string.");
			}
			char c = value[num2];
			if (char.IsDigit(c) || c == '-' || c == '+')
			{
				global::System.Type underlyingType = global::System.Enum.GetUnderlyingType(enumType);
				value = value.Trim();
				object obj = null;
				try
				{
					obj = global::System.Convert.ChangeType(value, underlyingType, global::System.Globalization.CultureInfo.InvariantCulture);
				}
				catch (global::System.FormatException)
				{
				}
				if (obj != null)
				{
					if (disallowNumber)
					{
						throw new global::System.FormatException("Integer string '{0}' is not allowed.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value));
					}
					return global::System.Enum.ToObject(enumType, obj);
				}
			}
			ulong num3 = 0UL;
			int j = num2;
			while (j <= value.Length)
			{
				int num4 = value.IndexOf(',', j);
				if (num4 == -1)
				{
					num4 = value.Length;
				}
				int num5 = num4;
				while (j < num4)
				{
					if (!char.IsWhiteSpace(value[j]))
					{
						break;
					}
					j++;
				}
				while (num5 > j && char.IsWhiteSpace(value[num5 - 1]))
				{
					num5--;
				}
				int valueSubstringLength = num5 - j;
				num = global::Newtonsoft.Json.Utilities.EnumUtils.MatchName(value, names, resolvedNames, j, valueSubstringLength, global::System.StringComparison.Ordinal);
				if (num == null)
				{
					num = global::Newtonsoft.Json.Utilities.EnumUtils.MatchName(value, names, resolvedNames, j, valueSubstringLength, global::System.StringComparison.OrdinalIgnoreCase);
				}
				if (num == null)
				{
					num = global::Newtonsoft.Json.Utilities.EnumUtils.FindIndexByName(resolvedNames, value, 0, value.Length, global::System.StringComparison.OrdinalIgnoreCase);
					if (num != null)
					{
						return global::System.Enum.ToObject(enumType, values[num.Value]);
					}
					throw new global::System.ArgumentException("Requested value '{0}' was not found.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value));
				}
				else
				{
					num3 |= values[num.Value];
					j = num4 + 1;
				}
			}
			return global::System.Enum.ToObject(enumType, num3);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00015900 File Offset: 0x00013B00
		private static int? MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, global::System.StringComparison comparison)
		{
			int? result = global::Newtonsoft.Json.Utilities.EnumUtils.FindIndexByName(resolvedNames, value, valueIndex, valueSubstringLength, comparison);
			if (result == null)
			{
				result = global::Newtonsoft.Json.Utilities.EnumUtils.FindIndexByName(enumNames, value, valueIndex, valueSubstringLength, comparison);
			}
			return result;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00015934 File Offset: 0x00013B34
		private static int? FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, global::System.StringComparison comparison)
		{
			for (int i = 0; i < enumNames.Length; i++)
			{
				if (enumNames[i].Length == valueSubstringLength && string.Compare(enumNames[i], 0, value, valueIndex, valueSubstringLength, comparison) == 0)
				{
					return new int?(i);
				}
			}
			return null;
		}

		// Token: 0x040001C6 RID: 454
		private const char EnumSeparatorChar = ',';

		// Token: 0x040001C7 RID: 455
		private const string EnumSeparatorString = ", ";

		// Token: 0x040001C8 RID: 456
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			0,
			1,
			2,
			1
		})]
		private static readonly global::Newtonsoft.Json.Utilities.ThreadSafeStore<global::Newtonsoft.Json.Utilities.StructMultiKey<global::System.Type, global::Newtonsoft.Json.Serialization.NamingStrategy>, global::Newtonsoft.Json.Utilities.EnumInfo> ValuesAndNamesPerEnum = new global::Newtonsoft.Json.Utilities.ThreadSafeStore<global::Newtonsoft.Json.Utilities.StructMultiKey<global::System.Type, global::Newtonsoft.Json.Serialization.NamingStrategy>, global::Newtonsoft.Json.Utilities.EnumInfo>(new global::System.Func<global::Newtonsoft.Json.Utilities.StructMultiKey<global::System.Type, global::Newtonsoft.Json.Serialization.NamingStrategy>, global::Newtonsoft.Json.Utilities.EnumInfo>(global::Newtonsoft.Json.Utilities.EnumUtils.InitializeValuesAndNames));

		// Token: 0x040001C9 RID: 457
		private static global::Newtonsoft.Json.Serialization.CamelCaseNamingStrategy _camelCaseNamingStrategy = new global::Newtonsoft.Json.Serialization.CamelCaseNamingStrategy();
	}
}
