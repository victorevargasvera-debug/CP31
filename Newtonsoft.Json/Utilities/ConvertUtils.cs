using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000049 RID: 73
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal static class ConvertUtils
	{
		// Token: 0x06000467 RID: 1127 RVA: 0x00010EA4 File Offset: 0x0000F0A4
		public static global::Newtonsoft.Json.Utilities.PrimitiveTypeCode GetTypeCode(global::System.Type t)
		{
			bool flag;
			return global::Newtonsoft.Json.Utilities.ConvertUtils.GetTypeCode(t, out flag);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00010EBC File Offset: 0x0000F0BC
		public static global::Newtonsoft.Json.Utilities.PrimitiveTypeCode GetTypeCode(global::System.Type t, out bool isEnum)
		{
			global::Newtonsoft.Json.Utilities.PrimitiveTypeCode result;
			if (global::Newtonsoft.Json.Utilities.ConvertUtils.TypeCodeMap.TryGetValue(t, out result))
			{
				isEnum = false;
				return result;
			}
			if (t.IsEnum())
			{
				isEnum = true;
				return global::Newtonsoft.Json.Utilities.ConvertUtils.GetTypeCode(global::System.Enum.GetUnderlyingType(t));
			}
			if (global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullableType(t))
			{
				global::System.Type underlyingType = global::System.Nullable.GetUnderlyingType(t);
				if (underlyingType.IsEnum())
				{
					global::System.Type t2 = typeof(global::System.Nullable<>).MakeGenericType(new global::System.Type[]
					{
						global::System.Enum.GetUnderlyingType(underlyingType)
					});
					isEnum = true;
					return global::Newtonsoft.Json.Utilities.ConvertUtils.GetTypeCode(t2);
				}
			}
			isEnum = false;
			return global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Object;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00010F36 File Offset: 0x0000F136
		public static global::Newtonsoft.Json.Utilities.TypeInformation GetTypeInformation(global::System.IConvertible convertable)
		{
			return global::Newtonsoft.Json.Utilities.ConvertUtils.PrimitiveTypeCodes[(int)convertable.GetTypeCode()];
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00010F44 File Offset: 0x0000F144
		public static bool IsConvertible(global::System.Type t)
		{
			return typeof(global::System.IConvertible).IsAssignableFrom(t);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00010F56 File Offset: 0x0000F156
		public static global::System.TimeSpan ParseTimeSpan(string input)
		{
			return global::System.TimeSpan.Parse(input, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00010F64 File Offset: 0x0000F164
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private static global::System.Func<object, object> CreateCastConverter([global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			0,
			1,
			1
		})] global::Newtonsoft.Json.Utilities.StructMultiKey<global::System.Type, global::System.Type> t)
		{
			global::System.Type value = t.Value1;
			global::System.Type value2 = t.Value2;
			global::System.Reflection.MethodInfo method;
			if ((method = value2.GetMethod("op_Implicit", new global::System.Type[]
			{
				value
			})) == null)
			{
				method = value2.GetMethod("op_Explicit", new global::System.Type[]
				{
					value
				});
			}
			global::System.Reflection.MethodInfo methodInfo = method;
			if (methodInfo == null)
			{
				return null;
			}
			global::Newtonsoft.Json.Utilities.MethodCall<object, object> call = global::Newtonsoft.Json.Serialization.JsonTypeReflector.ReflectionDelegateFactory.CreateMethodCall<object>(methodInfo);
			return (object o) => call(null, new object[]
			{
				o
			});
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00010FDC File Offset: 0x0000F1DC
		internal static global::System.Numerics.BigInteger ToBigInteger(object value)
		{
			if (value is global::System.Numerics.BigInteger)
			{
				return (global::System.Numerics.BigInteger)value;
			}
			string text = value as string;
			if (text != null)
			{
				return global::System.Numerics.BigInteger.Parse(text, global::System.Globalization.CultureInfo.InvariantCulture);
			}
			if (value is float)
			{
				float value2 = (float)value;
				return new global::System.Numerics.BigInteger(value2);
			}
			if (value is double)
			{
				double value3 = (double)value;
				return new global::System.Numerics.BigInteger(value3);
			}
			if (value is decimal)
			{
				decimal value4 = (decimal)value;
				return new global::System.Numerics.BigInteger(value4);
			}
			if (value is int)
			{
				int value5 = (int)value;
				return new global::System.Numerics.BigInteger(value5);
			}
			if (value is long)
			{
				long value6 = (long)value;
				return new global::System.Numerics.BigInteger(value6);
			}
			if (value is uint)
			{
				uint value7 = (uint)value;
				return new global::System.Numerics.BigInteger(value7);
			}
			if (value is ulong)
			{
				ulong value8 = (ulong)value;
				return new global::System.Numerics.BigInteger(value8);
			}
			byte[] array = value as byte[];
			if (array != null)
			{
				return new global::System.Numerics.BigInteger(array);
			}
			throw new global::System.InvalidCastException("Cannot convert {0} to BigInteger.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value.GetType()));
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x000110E4 File Offset: 0x0000F2E4
		public static object FromBigInteger(global::System.Numerics.BigInteger i, global::System.Type targetType)
		{
			if (targetType == typeof(decimal))
			{
				return (decimal)i;
			}
			if (targetType == typeof(double))
			{
				return (double)i;
			}
			if (targetType == typeof(float))
			{
				return (float)i;
			}
			if (targetType == typeof(ulong))
			{
				return (ulong)i;
			}
			if (targetType == typeof(bool))
			{
				return i != 0L;
			}
			object result;
			try
			{
				result = global::System.Convert.ChangeType((long)i, targetType, global::System.Globalization.CultureInfo.InvariantCulture);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.InvalidOperationException("Can not convert from BigInteger to {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, targetType), innerException);
			}
			return result;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000111D0 File Offset: 0x0000F3D0
		public static object Convert(object initialValue, global::System.Globalization.CultureInfo culture, global::System.Type targetType)
		{
			object result;
			switch (global::Newtonsoft.Json.Utilities.ConvertUtils.TryConvertInternal(initialValue, culture, targetType, out result))
			{
			case global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.Success:
				return result;
			case global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.CannotConvertNull:
				throw new global::System.Exception("Can not convert null {0} into non-nullable {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, initialValue.GetType(), targetType));
			case global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.NotInstantiableType:
				throw new global::System.ArgumentException("Target type {0} is not a value type or a non-abstract class.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, targetType), "targetType");
			case global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.NoValidConversion:
				throw new global::System.InvalidOperationException("Can not convert from {0} to {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, initialValue.GetType(), targetType));
			default:
				throw new global::System.InvalidOperationException("Unexpected conversion result.");
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00011260 File Offset: 0x0000F460
		private static bool TryConvert([global::System.Runtime.CompilerServices.Nullable(2)] object initialValue, global::System.Globalization.CultureInfo culture, global::System.Type targetType, [global::System.Runtime.CompilerServices.Nullable(2)] out object value)
		{
			bool result;
			try
			{
				if (global::Newtonsoft.Json.Utilities.ConvertUtils.TryConvertInternal(initialValue, culture, targetType, out value) == global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.Success)
				{
					result = true;
				}
				else
				{
					value = null;
					result = false;
				}
			}
			catch
			{
				value = null;
				result = false;
			}
			return result;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0001129C File Offset: 0x0000F49C
		private static global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult TryConvertInternal([global::System.Runtime.CompilerServices.Nullable(2)] object initialValue, global::System.Globalization.CultureInfo culture, global::System.Type targetType, [global::System.Runtime.CompilerServices.Nullable(2)] out object value)
		{
			if (initialValue == null)
			{
				throw new global::System.ArgumentNullException("initialValue");
			}
			if (global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullableType(targetType))
			{
				targetType = global::System.Nullable.GetUnderlyingType(targetType);
			}
			global::System.Type type = initialValue.GetType();
			if (targetType == type)
			{
				value = initialValue;
				return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.Success;
			}
			if (global::Newtonsoft.Json.Utilities.ConvertUtils.IsConvertible(initialValue.GetType()) && global::Newtonsoft.Json.Utilities.ConvertUtils.IsConvertible(targetType))
			{
				if (targetType.IsEnum())
				{
					if (initialValue is string)
					{
						value = global::System.Enum.Parse(targetType, initialValue.ToString(), true);
						return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.Success;
					}
					if (global::Newtonsoft.Json.Utilities.ConvertUtils.IsInteger(initialValue))
					{
						value = global::System.Enum.ToObject(targetType, initialValue);
						return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.Success;
					}
				}
				value = global::System.Convert.ChangeType(initialValue, targetType, culture);
				return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.Success;
			}
			if (initialValue is global::System.DateTime)
			{
				global::System.DateTime dateTime = (global::System.DateTime)initialValue;
				if (targetType == typeof(global::System.DateTimeOffset))
				{
					value = new global::System.DateTimeOffset(dateTime);
					return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.Success;
				}
			}
			byte[] array = initialValue as byte[];
			if (array != null && targetType == typeof(global::System.Guid))
			{
				value = new global::System.Guid(array);
				return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.Success;
			}
			if (initialValue is global::System.Guid)
			{
				global::System.Guid guid = (global::System.Guid)initialValue;
				if (targetType == typeof(byte[]))
				{
					value = guid.ToByteArray();
					return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.Success;
				}
			}
			string text = initialValue as string;
			if (text != null)
			{
				if (targetType == typeof(global::System.Guid))
				{
					value = new global::System.Guid(text);
					return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.Success;
				}
				if (targetType == typeof(global::System.Uri))
				{
					value = new global::System.Uri(text, global::System.UriKind.RelativeOrAbsolute);
					return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.Success;
				}
				if (targetType == typeof(global::System.TimeSpan))
				{
					value = global::Newtonsoft.Json.Utilities.ConvertUtils.ParseTimeSpan(text);
					return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.Success;
				}
				if (targetType == typeof(byte[]))
				{
					value = global::System.Convert.FromBase64String(text);
					return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.Success;
				}
				if (targetType == typeof(global::System.Version))
				{
					global::System.Version version;
					if (global::Newtonsoft.Json.Utilities.ConvertUtils.VersionTryParse(text, out version))
					{
						value = version;
						return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.Success;
					}
					value = null;
					return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.NoValidConversion;
				}
				else if (typeof(global::System.Type).IsAssignableFrom(targetType))
				{
					value = global::System.Type.GetType(text, true);
					return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.Success;
				}
			}
			if (targetType == typeof(global::System.Numerics.BigInteger))
			{
				value = global::Newtonsoft.Json.Utilities.ConvertUtils.ToBigInteger(initialValue);
				return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.Success;
			}
			if (initialValue is global::System.Numerics.BigInteger)
			{
				global::System.Numerics.BigInteger i = (global::System.Numerics.BigInteger)initialValue;
				value = global::Newtonsoft.Json.Utilities.ConvertUtils.FromBigInteger(i, targetType);
				return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.Success;
			}
			global::System.ComponentModel.TypeConverter converter = global::System.ComponentModel.TypeDescriptor.GetConverter(type);
			if (converter != null && converter.CanConvertTo(targetType))
			{
				value = converter.ConvertTo(null, culture, initialValue, targetType);
				return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.Success;
			}
			global::System.ComponentModel.TypeConverter converter2 = global::System.ComponentModel.TypeDescriptor.GetConverter(targetType);
			if (converter2 != null && converter2.CanConvertFrom(type))
			{
				value = converter2.ConvertFrom(null, culture, initialValue);
				return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.Success;
			}
			if (initialValue == global::System.DBNull.Value)
			{
				if (global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullable(targetType))
				{
					value = global::Newtonsoft.Json.Utilities.ConvertUtils.EnsureTypeAssignable(null, type, targetType);
					return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.Success;
				}
				value = null;
				return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.CannotConvertNull;
			}
			else
			{
				if (targetType.IsInterface() || targetType.IsGenericTypeDefinition() || targetType.IsAbstract())
				{
					value = null;
					return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.NotInstantiableType;
				}
				value = null;
				return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertResult.NoValidConversion;
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00011554 File Offset: 0x0000F754
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static object ConvertOrCast([global::System.Runtime.CompilerServices.Nullable(2)] object initialValue, global::System.Globalization.CultureInfo culture, global::System.Type targetType)
		{
			if (targetType == typeof(object))
			{
				return initialValue;
			}
			if (initialValue == null && global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullable(targetType))
			{
				return null;
			}
			object result;
			if (global::Newtonsoft.Json.Utilities.ConvertUtils.TryConvert(initialValue, culture, targetType, out result))
			{
				return result;
			}
			return global::Newtonsoft.Json.Utilities.ConvertUtils.EnsureTypeAssignable(initialValue, global::Newtonsoft.Json.Utilities.ReflectionUtils.GetObjectType(initialValue), targetType);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x000115A0 File Offset: 0x0000F7A0
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		private static object EnsureTypeAssignable([global::System.Runtime.CompilerServices.Nullable(2)] object value, global::System.Type initialType, global::System.Type targetType)
		{
			if (value != null)
			{
				global::System.Type type = value.GetType();
				if (targetType.IsAssignableFrom(type))
				{
					return value;
				}
				global::System.Func<object, object> func = global::Newtonsoft.Json.Utilities.ConvertUtils.CastConverters.Get(new global::Newtonsoft.Json.Utilities.StructMultiKey<global::System.Type, global::System.Type>(type, targetType));
				if (func != null)
				{
					return func(value);
				}
			}
			else if (global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullable(targetType))
			{
				return null;
			}
			throw new global::System.ArgumentException("Could not cast or convert from {0} to {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, ((initialType != null) ? initialType.ToString() : null) ?? "{null}", targetType));
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00011613 File Offset: 0x0000F813
		public static bool VersionTryParse(string input, [global::System.Runtime.CompilerServices.Nullable(2)] [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out global::System.Version result)
		{
			return global::System.Version.TryParse(input, out result);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x0001161C File Offset: 0x0000F81C
		public static bool IsInteger(object value)
		{
			switch (global::Newtonsoft.Json.Utilities.ConvertUtils.GetTypeCode(value.GetType()))
			{
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SByte:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int16:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt16:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int32:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Byte:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt32:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int64:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt64:
				return true;
			}
			return false;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00011680 File Offset: 0x0000F880
		public static global::Newtonsoft.Json.Utilities.ParseResult Int32TryParse(char[] chars, int start, int length, out int value)
		{
			value = 0;
			if (length == 0)
			{
				return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
			}
			bool flag = chars[start] == '-';
			if (flag)
			{
				if (length == 1)
				{
					return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
				}
				start++;
				length--;
			}
			int num = start + length;
			if (length > 10 || (length == 10 && chars[start] - '0' > '\u0002'))
			{
				for (int i = start; i < num; i++)
				{
					int num2 = (int)(chars[i] - '0');
					if (num2 < 0 || num2 > 9)
					{
						return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
					}
				}
				return global::Newtonsoft.Json.Utilities.ParseResult.Overflow;
			}
			for (int j = start; j < num; j++)
			{
				int num3 = (int)(chars[j] - '0');
				if (num3 < 0 || num3 > 9)
				{
					return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
				}
				int num4 = 10 * value - num3;
				if (num4 > value)
				{
					for (j++; j < num; j++)
					{
						num3 = (int)(chars[j] - '0');
						if (num3 < 0 || num3 > 9)
						{
							return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
						}
					}
					return global::Newtonsoft.Json.Utilities.ParseResult.Overflow;
				}
				value = num4;
			}
			if (!flag)
			{
				if (value == -2147483648)
				{
					return global::Newtonsoft.Json.Utilities.ParseResult.Overflow;
				}
				value = -value;
			}
			return global::Newtonsoft.Json.Utilities.ParseResult.Success;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00011760 File Offset: 0x0000F960
		public static global::Newtonsoft.Json.Utilities.ParseResult Int64TryParse(char[] chars, int start, int length, out long value)
		{
			value = 0L;
			if (length == 0)
			{
				return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
			}
			bool flag = chars[start] == '-';
			if (flag)
			{
				if (length == 1)
				{
					return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
				}
				start++;
				length--;
			}
			int num = start + length;
			if (length > 19)
			{
				for (int i = start; i < num; i++)
				{
					int num2 = (int)(chars[i] - '0');
					if (num2 < 0 || num2 > 9)
					{
						return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
					}
				}
				return global::Newtonsoft.Json.Utilities.ParseResult.Overflow;
			}
			for (int j = start; j < num; j++)
			{
				int num3 = (int)(chars[j] - '0');
				if (num3 < 0 || num3 > 9)
				{
					return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
				}
				long num4 = 10L * value - (long)num3;
				if (num4 > value)
				{
					for (j++; j < num; j++)
					{
						num3 = (int)(chars[j] - '0');
						if (num3 < 0 || num3 > 9)
						{
							return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
						}
					}
					return global::Newtonsoft.Json.Utilities.ParseResult.Overflow;
				}
				value = num4;
			}
			if (!flag)
			{
				if (value == -9223372036854775808L)
				{
					return global::Newtonsoft.Json.Utilities.ParseResult.Overflow;
				}
				value = -value;
			}
			return global::Newtonsoft.Json.Utilities.ParseResult.Success;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0001183C File Offset: 0x0000FA3C
		public static global::Newtonsoft.Json.Utilities.ParseResult DecimalTryParse(char[] chars, int start, int length, out decimal value)
		{
			value = 0m;
			if (length == 0)
			{
				return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
			}
			bool flag = chars[start] == '-';
			if (flag)
			{
				if (length == 1)
				{
					return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
				}
				start++;
				length--;
			}
			int i = start;
			int num = start + length;
			int num2 = num;
			int num3 = num;
			int num4 = 0;
			ulong num5 = 0UL;
			ulong num6 = 0UL;
			int num7 = 0;
			int num8 = 0;
			char? c = null;
			bool? flag2 = null;
			while (i < num)
			{
				char c2 = chars[i];
				if (c2 == '.')
				{
					goto IL_74;
				}
				if (c2 != 'E' && c2 != 'e')
				{
					if (c2 < '0' || c2 > '9')
					{
						return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
					}
					if (i == start && c2 == '0')
					{
						i++;
						if (i != num)
						{
							c2 = chars[i];
							if (c2 == '.')
							{
								goto IL_74;
							}
							if (c2 != 'e' && c2 != 'E')
							{
								return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
							}
							goto IL_91;
						}
					}
					if (num7 < 29)
					{
						if (num7 == 28)
						{
							bool? flag3 = flag2;
							bool valueOrDefault;
							if (flag3 == null)
							{
								flag2 = new bool?(num5 > 7922816251426433759UL || (num5 == 7922816251426433759UL && (num6 > 354395033UL || (num6 == 354395033UL && c2 > '5'))));
								bool? flag4 = flag2;
								valueOrDefault = flag4.GetValueOrDefault();
							}
							else
							{
								valueOrDefault = flag3.GetValueOrDefault();
							}
							if (valueOrDefault)
							{
								goto IL_1FF;
							}
						}
						if (num7 < 19)
						{
							num5 = num5 * 10UL + (ulong)((long)(c2 - '0'));
						}
						else
						{
							num6 = num6 * 10UL + (ulong)((long)(c2 - '0'));
						}
						num7++;
						goto IL_217;
					}
					IL_1FF:
					if (c == null)
					{
						c = new char?(c2);
					}
					num8++;
					goto IL_217;
				}
				IL_91:
				if (i == start)
				{
					return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
				}
				if (i == num2)
				{
					return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
				}
				i++;
				if (i == num)
				{
					return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
				}
				if (num2 < num)
				{
					num3 = i - 1;
				}
				c2 = chars[i];
				bool flag5 = false;
				if (c2 != '+')
				{
					if (c2 == '-')
					{
						flag5 = true;
						i++;
					}
				}
				else
				{
					i++;
				}
				while (i < num)
				{
					c2 = chars[i];
					if (c2 < '0' || c2 > '9')
					{
						return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
					}
					int num9 = 10 * num4 + (int)(c2 - '0');
					if (num4 < num9)
					{
						num4 = num9;
					}
					i++;
				}
				if (flag5)
				{
					num4 = -num4;
				}
				IL_217:
				i++;
				continue;
				IL_74:
				if (i == start)
				{
					return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
				}
				if (i + 1 == num)
				{
					return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
				}
				if (num2 != num)
				{
					return global::Newtonsoft.Json.Utilities.ParseResult.Invalid;
				}
				num2 = i + 1;
				goto IL_217;
			}
			num4 += num8;
			num4 -= num3 - num2;
			if (num7 <= 19)
			{
				value = num5;
			}
			else
			{
				value = num5 / new decimal(1, 0, 0, false, (byte)(num7 - 19)) + num6;
			}
			if (num4 > 0)
			{
				num7 += num4;
				if (num7 > 29)
				{
					return global::Newtonsoft.Json.Utilities.ParseResult.Overflow;
				}
				if (num7 == 29)
				{
					if (num4 > 1)
					{
						value /= new decimal(1, 0, 0, false, (byte)(num4 - 1));
						if (value > 7922816251426433759354395033m)
						{
							return global::Newtonsoft.Json.Utilities.ParseResult.Overflow;
						}
					}
					else if (value == 7922816251426433759354395033m)
					{
						char? c3 = c;
						int? num10 = (c3 != null) ? new int?((int)c3.GetValueOrDefault()) : null;
						int num11 = 53;
						if (num10.GetValueOrDefault() > num11 & num10 != null)
						{
							return global::Newtonsoft.Json.Utilities.ParseResult.Overflow;
						}
					}
					value *= 10m;
				}
				else
				{
					value /= new decimal(1, 0, 0, false, (byte)num4);
				}
			}
			else
			{
				char? c3 = c;
				int? num10 = (c3 != null) ? new int?((int)c3.GetValueOrDefault()) : null;
				int num11 = 53;
				if ((num10.GetValueOrDefault() >= num11 & num10 != null) && num4 >= -28)
				{
					value = ++value;
				}
				if (num4 < 0)
				{
					if (num7 + num4 + 28 <= 0)
					{
						value = (flag ? 0m : 0m);
						return global::Newtonsoft.Json.Utilities.ParseResult.Success;
					}
					if (num4 >= -28)
					{
						value *= new decimal(1, 0, 0, false, (byte)(-(byte)num4));
					}
					else
					{
						value /= 10000000000000000000000000000m;
						value *= new decimal(1, 0, 0, false, (byte)(-num4 - 28));
					}
				}
			}
			if (flag)
			{
				value = -value;
			}
			return global::Newtonsoft.Json.Utilities.ParseResult.Success;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00011CD1 File Offset: 0x0000FED1
		public static bool TryConvertGuid(string s, out global::System.Guid g)
		{
			return global::System.Guid.TryParseExact(s, "D", out g);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00011CE0 File Offset: 0x0000FEE0
		public static bool TryHexTextToInt(char[] text, int start, int end, out int value)
		{
			value = 0;
			for (int i = start; i < end; i++)
			{
				char c = text[i];
				int num;
				if (c <= '9' && c >= '0')
				{
					num = (int)(c - '0');
				}
				else if (c <= 'F' && c >= 'A')
				{
					num = (int)(c - '7');
				}
				else
				{
					if (c > 'f' || c < 'a')
					{
						value = 0;
						return false;
					}
					num = (int)(c - 'W');
				}
				value += num << (end - 1 - i) * 4;
			}
			return true;
		}

		// Token: 0x0400018D RID: 397
		private static readonly global::System.Collections.Generic.Dictionary<global::System.Type, global::Newtonsoft.Json.Utilities.PrimitiveTypeCode> TypeCodeMap = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Newtonsoft.Json.Utilities.PrimitiveTypeCode>
		{
			{
				typeof(char),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Char
			},
			{
				typeof(char?),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.CharNullable
			},
			{
				typeof(bool),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Boolean
			},
			{
				typeof(bool?),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.BooleanNullable
			},
			{
				typeof(sbyte),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SByte
			},
			{
				typeof(sbyte?),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SByteNullable
			},
			{
				typeof(short),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int16
			},
			{
				typeof(short?),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int16Nullable
			},
			{
				typeof(ushort),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt16
			},
			{
				typeof(ushort?),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt16Nullable
			},
			{
				typeof(int),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int32
			},
			{
				typeof(int?),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int32Nullable
			},
			{
				typeof(byte),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Byte
			},
			{
				typeof(byte?),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.ByteNullable
			},
			{
				typeof(uint),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt32
			},
			{
				typeof(uint?),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt32Nullable
			},
			{
				typeof(long),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int64
			},
			{
				typeof(long?),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int64Nullable
			},
			{
				typeof(ulong),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt64
			},
			{
				typeof(ulong?),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt64Nullable
			},
			{
				typeof(float),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Single
			},
			{
				typeof(float?),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SingleNullable
			},
			{
				typeof(double),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Double
			},
			{
				typeof(double?),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DoubleNullable
			},
			{
				typeof(global::System.DateTime),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTime
			},
			{
				typeof(global::System.DateTime?),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeNullable
			},
			{
				typeof(global::System.DateTimeOffset),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeOffset
			},
			{
				typeof(global::System.DateTimeOffset?),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeOffsetNullable
			},
			{
				typeof(decimal),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Decimal
			},
			{
				typeof(decimal?),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DecimalNullable
			},
			{
				typeof(global::System.Guid),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Guid
			},
			{
				typeof(global::System.Guid?),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.GuidNullable
			},
			{
				typeof(global::System.TimeSpan),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.TimeSpan
			},
			{
				typeof(global::System.TimeSpan?),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.TimeSpanNullable
			},
			{
				typeof(global::System.Numerics.BigInteger),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.BigInteger
			},
			{
				typeof(global::System.Numerics.BigInteger?),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.BigIntegerNullable
			},
			{
				typeof(global::System.Uri),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Uri
			},
			{
				typeof(string),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.String
			},
			{
				typeof(byte[]),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Bytes
			},
			{
				typeof(global::System.DBNull),
				global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DBNull
			}
		};

		// Token: 0x0400018E RID: 398
		private static readonly global::Newtonsoft.Json.Utilities.TypeInformation[] PrimitiveTypeCodes = new global::Newtonsoft.Json.Utilities.TypeInformation[]
		{
			new global::Newtonsoft.Json.Utilities.TypeInformation(typeof(object), global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Empty),
			new global::Newtonsoft.Json.Utilities.TypeInformation(typeof(object), global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Object),
			new global::Newtonsoft.Json.Utilities.TypeInformation(typeof(object), global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DBNull),
			new global::Newtonsoft.Json.Utilities.TypeInformation(typeof(bool), global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Boolean),
			new global::Newtonsoft.Json.Utilities.TypeInformation(typeof(char), global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Char),
			new global::Newtonsoft.Json.Utilities.TypeInformation(typeof(sbyte), global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SByte),
			new global::Newtonsoft.Json.Utilities.TypeInformation(typeof(byte), global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Byte),
			new global::Newtonsoft.Json.Utilities.TypeInformation(typeof(short), global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int16),
			new global::Newtonsoft.Json.Utilities.TypeInformation(typeof(ushort), global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt16),
			new global::Newtonsoft.Json.Utilities.TypeInformation(typeof(int), global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int32),
			new global::Newtonsoft.Json.Utilities.TypeInformation(typeof(uint), global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt32),
			new global::Newtonsoft.Json.Utilities.TypeInformation(typeof(long), global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int64),
			new global::Newtonsoft.Json.Utilities.TypeInformation(typeof(ulong), global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt64),
			new global::Newtonsoft.Json.Utilities.TypeInformation(typeof(float), global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Single),
			new global::Newtonsoft.Json.Utilities.TypeInformation(typeof(double), global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Double),
			new global::Newtonsoft.Json.Utilities.TypeInformation(typeof(decimal), global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Decimal),
			new global::Newtonsoft.Json.Utilities.TypeInformation(typeof(global::System.DateTime), global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTime),
			new global::Newtonsoft.Json.Utilities.TypeInformation(typeof(object), global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Empty),
			new global::Newtonsoft.Json.Utilities.TypeInformation(typeof(string), global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.String)
		};

		// Token: 0x0400018F RID: 399
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			1,
			0,
			1,
			1,
			2,
			2,
			2
		})]
		private static readonly global::Newtonsoft.Json.Utilities.ThreadSafeStore<global::Newtonsoft.Json.Utilities.StructMultiKey<global::System.Type, global::System.Type>, global::System.Func<object, object>> CastConverters = new global::Newtonsoft.Json.Utilities.ThreadSafeStore<global::Newtonsoft.Json.Utilities.StructMultiKey<global::System.Type, global::System.Type>, global::System.Func<object, object>>(new global::System.Func<global::Newtonsoft.Json.Utilities.StructMultiKey<global::System.Type, global::System.Type>, global::System.Func<object, object>>(global::Newtonsoft.Json.Utilities.ConvertUtils.CreateCastConverter));

		// Token: 0x02000165 RID: 357
		[global::System.Runtime.CompilerServices.NullableContext(0)]
		internal enum ConvertResult
		{
			// Token: 0x04000678 RID: 1656
			Success,
			// Token: 0x04000679 RID: 1657
			CannotConvertNull,
			// Token: 0x0400067A RID: 1658
			NotInstantiableType,
			// Token: 0x0400067B RID: 1659
			NoValidConversion
		}
	}
}
