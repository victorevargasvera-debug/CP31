using System;
using System.ComponentModel;
using System.Reflection;
using DevAge.ComponentModel.Converter;
using DevAge.ComponentModel.Validator;

namespace DevAge.Text.FixedLength
{
	// Token: 0x02000289 RID: 649
	internal class Utilities
	{
		// Token: 0x06002162 RID: 8546 RVA: 0x00076C9C File Offset: 0x00074E9C
		public static global::DevAge.ComponentModel.Validator.IValidator CreateValidator(global::System.Type type, global::DevAge.Text.FixedLength.ParseFormatAttribute parseAttributes)
		{
			bool allowNull;
			type = global::DevAge.Text.FixedLength.Utilities.GetBaseType(type, out allowNull);
			global::System.ComponentModel.TypeConverter converterFromPrimitiveType = global::DevAge.Text.FixedLength.Utilities.GetConverterFromPrimitiveType(type, parseAttributes);
			return new global::DevAge.ComponentModel.Validator.ValidatorTypeConverter(type, converterFromPrimitiveType)
			{
				CultureInfo = parseAttributes.CultureInfo,
				NullString = "",
				NullDisplayString = "",
				AllowNull = allowNull
			};
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x00076CF4 File Offset: 0x00074EF4
		private static global::System.Type GetBaseType(global::System.Type type, out bool isNullable)
		{
			if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(global::System.Nullable<>))
			{
				isNullable = true;
				return global::System.Nullable.GetUnderlyingType(type);
			}
			isNullable = false;
			return type;
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x00076D24 File Offset: 0x00074F24
		private static global::System.ComponentModel.TypeConverter GetConverterFromPrimitiveType(global::System.Type type, global::DevAge.Text.FixedLength.ParseFormatAttribute parseAttributes)
		{
			if (type == typeof(string))
			{
				return new global::System.ComponentModel.StringConverter();
			}
			if (type == typeof(int))
			{
				return new global::System.ComponentModel.Int32Converter();
			}
			if (type == typeof(double))
			{
				return new global::DevAge.ComponentModel.Converter.NumberTypeConverter(typeof(double), parseAttributes.NumberFormat);
			}
			if (type == typeof(decimal))
			{
				return new global::DevAge.ComponentModel.Converter.NumberTypeConverter(typeof(decimal), parseAttributes.NumberFormat);
			}
			if (type == typeof(global::System.DateTime))
			{
				return new global::DevAge.ComponentModel.Converter.DateTimeTypeConverter(parseAttributes.DateTimeFormat, new string[]
				{
					parseAttributes.DateTimeFormat
				});
			}
			throw new global::DevAge.Text.FixedLength.TypeNotSupportedException(type);
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x00076DE4 File Offset: 0x00074FE4
		public static global::DevAge.Text.FixedLength.FieldList ExtractFieldListFromType(global::System.Type classType)
		{
			global::DevAge.Text.FixedLength.FieldList fieldList = new global::DevAge.Text.FixedLength.FieldList();
			global::System.Reflection.PropertyInfo[] properties = classType.GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.GetProperty);
			foreach (global::System.Reflection.PropertyInfo propertyInfo in properties)
			{
				global::DevAge.Text.FixedLength.FieldAttribute fieldAttribute = null;
				global::DevAge.Text.FixedLength.ParseFormatAttribute parseFormatAttribute = null;
				object[] customAttributes = propertyInfo.GetCustomAttributes(typeof(global::DevAge.Text.FixedLength.FieldAttribute), true);
				if (customAttributes.Length > 0)
				{
					fieldAttribute = (global::DevAge.Text.FixedLength.FieldAttribute)customAttributes[0];
				}
				customAttributes = propertyInfo.GetCustomAttributes(typeof(global::DevAge.Text.FixedLength.ParseFormatAttribute), true);
				if (customAttributes.Length > 0)
				{
					parseFormatAttribute = (global::DevAge.Text.FixedLength.ParseFormatAttribute)customAttributes[0];
				}
				object[] customAttributes2 = propertyInfo.GetCustomAttributes(typeof(global::DevAge.Text.FixedLength.ValueMappingAttribute), true);
				object[] customAttributes3 = propertyInfo.GetCustomAttributes(typeof(global::DevAge.Text.FixedLength.StandardValueAttribute), true);
				if (fieldAttribute != null)
				{
					if (parseFormatAttribute == null)
					{
						parseFormatAttribute = new global::DevAge.Text.FixedLength.ParseFormatAttribute();
					}
					global::DevAge.ComponentModel.Validator.IValidator validator = global::DevAge.Text.FixedLength.Utilities.CreateValidator(propertyInfo.PropertyType, parseFormatAttribute);
					fieldList.Add(new global::DevAge.Text.FixedLength.Field(fieldAttribute.FieldIndex, propertyInfo.Name, fieldAttribute.Length, validator)
					{
						TrimBeforeParse = parseFormatAttribute.TrimBeforeParse
					});
					if (customAttributes2.Length > 0)
					{
						global::DevAge.ComponentModel.Validator.ValueMapping valueMapping = new global::DevAge.ComponentModel.Validator.ValueMapping();
						object[] array2 = new object[customAttributes2.Length];
						object[] array3 = new object[customAttributes2.Length];
						for (int j = 0; j < customAttributes2.Length; j++)
						{
							array2[j] = validator.ObjectToValue(((global::DevAge.Text.FixedLength.ValueMappingAttribute)customAttributes2[j]).FieldValue);
							array3[j] = ((global::DevAge.Text.FixedLength.ValueMappingAttribute)customAttributes2[j]).StringValue;
						}
						valueMapping.ThrowErrorIfNotFound = false;
						valueMapping.ValueList = array2;
						valueMapping.SpecialList = array3;
						valueMapping.SpecialType = typeof(string);
						valueMapping.BindValidator(validator);
					}
					if (customAttributes3.Length > 0)
					{
						object[] array4 = new object[customAttributes3.Length];
						for (int k = 0; k < customAttributes3.Length; k++)
						{
							array4[k] = ((global::DevAge.Text.FixedLength.StandardValueAttribute)customAttributes3[k]).StandardValue;
						}
						validator.StandardValues = array4;
						validator.StandardValuesExclusive = true;
					}
				}
			}
			return fieldList;
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x00076FF0 File Offset: 0x000751F0
		public static string ValidateRegExpSeparator(char separator)
		{
			if (separator == '\0')
			{
				return string.Empty;
			}
			char c = separator;
			if (c <= '?')
			{
				switch (c)
				{
				case '$':
				case '(':
				case ')':
				case '*':
				case '+':
					break;
				case '%':
				case '&':
				case '\'':
					goto IL_8C;
				default:
					if (c != '?')
					{
						goto IL_8C;
					}
					break;
				}
			}
			else
			{
				switch (c)
				{
				case '[':
				case '\\':
				case '^':
					break;
				case ']':
					goto IL_8C;
				default:
					switch (c)
					{
					case '{':
					case '|':
						break;
					default:
						goto IL_8C;
					}
					break;
				}
			}
			return "\\" + separator;
			IL_8C:
			return separator.ToString();
		}
	}
}
