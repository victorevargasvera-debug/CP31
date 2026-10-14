using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000EB RID: 235
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class StringEnumConverter : global::Newtonsoft.Json.JsonConverter
	{
		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x00032621 File Offset: 0x00030821
		// (set) Token: 0x06000C72 RID: 3186 RVA: 0x00032633 File Offset: 0x00030833
		[global::System.Obsolete("StringEnumConverter.CamelCaseText is obsolete. Set StringEnumConverter.NamingStrategy with CamelCaseNamingStrategy instead.")]
		public bool CamelCaseText
		{
			get
			{
				return this.NamingStrategy is global::Newtonsoft.Json.Serialization.CamelCaseNamingStrategy;
			}
			set
			{
				if (value)
				{
					if (this.NamingStrategy is global::Newtonsoft.Json.Serialization.CamelCaseNamingStrategy)
					{
						return;
					}
					this.NamingStrategy = new global::Newtonsoft.Json.Serialization.CamelCaseNamingStrategy();
					return;
				}
				else
				{
					if (!(this.NamingStrategy is global::Newtonsoft.Json.Serialization.CamelCaseNamingStrategy))
					{
						return;
					}
					this.NamingStrategy = null;
					return;
				}
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000C73 RID: 3187 RVA: 0x00032667 File Offset: 0x00030867
		// (set) Token: 0x06000C74 RID: 3188 RVA: 0x0003266F File Offset: 0x0003086F
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public global::Newtonsoft.Json.Serialization.NamingStrategy NamingStrategy { [global::System.Runtime.CompilerServices.NullableContext(2)] get; [global::System.Runtime.CompilerServices.NullableContext(2)] set; }

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000C75 RID: 3189 RVA: 0x00032678 File Offset: 0x00030878
		// (set) Token: 0x06000C76 RID: 3190 RVA: 0x00032680 File Offset: 0x00030880
		public bool AllowIntegerValues { get; set; } = true;

		// Token: 0x06000C77 RID: 3191 RVA: 0x00032689 File Offset: 0x00030889
		public StringEnumConverter()
		{
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00032698 File Offset: 0x00030898
		[global::System.Obsolete("StringEnumConverter(bool) is obsolete. Create a converter with StringEnumConverter(NamingStrategy, bool) instead.")]
		public StringEnumConverter(bool camelCaseText)
		{
			if (camelCaseText)
			{
				this.NamingStrategy = new global::Newtonsoft.Json.Serialization.CamelCaseNamingStrategy();
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x000326B5 File Offset: 0x000308B5
		public StringEnumConverter(global::Newtonsoft.Json.Serialization.NamingStrategy namingStrategy, bool allowIntegerValues = true)
		{
			this.NamingStrategy = namingStrategy;
			this.AllowIntegerValues = allowIntegerValues;
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x000326D2 File Offset: 0x000308D2
		public StringEnumConverter(global::System.Type namingStrategyType)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(namingStrategyType, "namingStrategyType");
			this.NamingStrategy = global::Newtonsoft.Json.Serialization.JsonTypeReflector.CreateNamingStrategyInstance(namingStrategyType, null);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x000326F9 File Offset: 0x000308F9
		public StringEnumConverter(global::System.Type namingStrategyType, object[] namingStrategyParameters)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(namingStrategyType, "namingStrategyType");
			this.NamingStrategy = global::Newtonsoft.Json.Serialization.JsonTypeReflector.CreateNamingStrategyInstance(namingStrategyType, namingStrategyParameters);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00032720 File Offset: 0x00030920
		public StringEnumConverter(global::System.Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(namingStrategyType, "namingStrategyType");
			this.NamingStrategy = global::Newtonsoft.Json.Serialization.JsonTypeReflector.CreateNamingStrategyInstance(namingStrategyType, namingStrategyParameters);
			this.AllowIntegerValues = allowIntegerValues;
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x00032750 File Offset: 0x00030950
		public override void WriteJson(global::Newtonsoft.Json.JsonWriter writer, [global::System.Runtime.CompilerServices.Nullable(2)] object value, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			global::System.Enum @enum = (global::System.Enum)value;
			string value2;
			if (global::Newtonsoft.Json.Utilities.EnumUtils.TryToString(@enum.GetType(), value, this.NamingStrategy, out value2))
			{
				writer.WriteValue(value2);
				return;
			}
			if (!this.AllowIntegerValues)
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(null, writer.ContainerPath, "Integer value {0} is not allowed.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, @enum.ToString("D")), null);
			}
			writer.WriteValue(value);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x000327C4 File Offset: 0x000309C4
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public override object ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, [global::System.Runtime.CompilerServices.Nullable(2)] object existingValue, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (reader.TokenType != global::Newtonsoft.Json.JsonToken.Null)
			{
				bool flag = global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullableType(objectType);
				global::System.Type type = flag ? global::System.Nullable.GetUnderlyingType(objectType) : objectType;
				try
				{
					if (reader.TokenType == global::Newtonsoft.Json.JsonToken.String)
					{
						object value = reader.Value;
						string value2 = (value != null) ? value.ToString() : null;
						if (global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(value2) && flag)
						{
							return null;
						}
						return global::Newtonsoft.Json.Utilities.EnumUtils.ParseEnum(type, this.NamingStrategy, value2, !this.AllowIntegerValues);
					}
					else if (reader.TokenType == global::Newtonsoft.Json.JsonToken.Integer)
					{
						if (!this.AllowIntegerValues)
						{
							throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Integer value {0} is not allowed.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reader.Value));
						}
						return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertOrCast(reader.Value, global::System.Globalization.CultureInfo.InvariantCulture, type);
					}
				}
				catch (global::System.Exception ex)
				{
					throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Error converting value {0} to type '{1}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Utilities.MiscellaneousUtils.ToString(reader.Value), objectType), ex);
				}
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected token {0} when parsing enum.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reader.TokenType));
			}
			if (!global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullableType(objectType))
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot convert null value to {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, objectType));
			}
			return null;
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x000328F8 File Offset: 0x00030AF8
		public override bool CanConvert(global::System.Type objectType)
		{
			return (global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullableType(objectType) ? global::System.Nullable.GetUnderlyingType(objectType) : objectType).IsEnum();
		}
	}
}
