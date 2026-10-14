using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000E7 RID: 231
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class IsoDateTimeConverter : global::Newtonsoft.Json.Converters.DateTimeConverterBase
	{
		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00031C77 File Offset: 0x0002FE77
		// (set) Token: 0x06000C56 RID: 3158 RVA: 0x00031C7F File Offset: 0x0002FE7F
		public global::System.Globalization.DateTimeStyles DateTimeStyles
		{
			get
			{
				return this._dateTimeStyles;
			}
			set
			{
				this._dateTimeStyles = value;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00031C88 File Offset: 0x0002FE88
		// (set) Token: 0x06000C58 RID: 3160 RVA: 0x00031C99 File Offset: 0x0002FE99
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public string DateTimeFormat
		{
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				return this._dateTimeFormat ?? string.Empty;
			}
			[global::System.Runtime.CompilerServices.NullableContext(2)]
			set
			{
				this._dateTimeFormat = (global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(value) ? null : value);
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00031CAD File Offset: 0x0002FEAD
		// (set) Token: 0x06000C5A RID: 3162 RVA: 0x00031CBE File Offset: 0x0002FEBE
		public global::System.Globalization.CultureInfo Culture
		{
			get
			{
				return this._culture ?? global::System.Globalization.CultureInfo.CurrentCulture;
			}
			set
			{
				this._culture = value;
			}
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x00031CC8 File Offset: 0x0002FEC8
		public override void WriteJson(global::Newtonsoft.Json.JsonWriter writer, [global::System.Runtime.CompilerServices.Nullable(2)] object value, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			string value2;
			if (value is global::System.DateTime)
			{
				global::System.DateTime dateTime = (global::System.DateTime)value;
				if ((this._dateTimeStyles & global::System.Globalization.DateTimeStyles.AdjustToUniversal) == global::System.Globalization.DateTimeStyles.AdjustToUniversal || (this._dateTimeStyles & global::System.Globalization.DateTimeStyles.AssumeUniversal) == global::System.Globalization.DateTimeStyles.AssumeUniversal)
				{
					dateTime = dateTime.ToUniversalTime();
				}
				value2 = dateTime.ToString(this._dateTimeFormat ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK", this.Culture);
			}
			else
			{
				if (!(value is global::System.DateTimeOffset))
				{
					throw new global::Newtonsoft.Json.JsonSerializationException("Unexpected value when converting date. Expected DateTime or DateTimeOffset, got {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Utilities.ReflectionUtils.GetObjectType(value)));
				}
				global::System.DateTimeOffset dateTimeOffset = (global::System.DateTimeOffset)value;
				if ((this._dateTimeStyles & global::System.Globalization.DateTimeStyles.AdjustToUniversal) == global::System.Globalization.DateTimeStyles.AdjustToUniversal || (this._dateTimeStyles & global::System.Globalization.DateTimeStyles.AssumeUniversal) == global::System.Globalization.DateTimeStyles.AssumeUniversal)
				{
					dateTimeOffset = dateTimeOffset.ToUniversalTime();
				}
				value2 = dateTimeOffset.ToString(this._dateTimeFormat ?? "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK", this.Culture);
			}
			writer.WriteValue(value2);
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00031D98 File Offset: 0x0002FF98
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public override object ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, [global::System.Runtime.CompilerServices.Nullable(2)] object existingValue, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			bool flag = global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullableType(objectType);
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.Null)
			{
				if (!flag)
				{
					throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot convert null value to {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, objectType));
				}
				return null;
			}
			else
			{
				global::System.Type left = flag ? global::System.Nullable.GetUnderlyingType(objectType) : objectType;
				if (reader.TokenType == global::Newtonsoft.Json.JsonToken.Date)
				{
					if (left == typeof(global::System.DateTimeOffset))
					{
						if (!(reader.Value is global::System.DateTimeOffset))
						{
							return new global::System.DateTimeOffset((global::System.DateTime)reader.Value);
						}
						return reader.Value;
					}
					else
					{
						object value = reader.Value;
						if (value is global::System.DateTimeOffset)
						{
							return ((global::System.DateTimeOffset)value).DateTime;
						}
						return reader.Value;
					}
				}
				else
				{
					if (reader.TokenType != global::Newtonsoft.Json.JsonToken.String)
					{
						throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected token parsing date. Expected String, got {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reader.TokenType));
					}
					object value2 = reader.Value;
					string text = (value2 != null) ? value2.ToString() : null;
					if (global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(text) && flag)
					{
						return null;
					}
					if (left == typeof(global::System.DateTimeOffset))
					{
						if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(this._dateTimeFormat))
						{
							return global::System.DateTimeOffset.ParseExact(text, this._dateTimeFormat, this.Culture, this._dateTimeStyles);
						}
						return global::System.DateTimeOffset.Parse(text, this.Culture, this._dateTimeStyles);
					}
					else
					{
						if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(this._dateTimeFormat))
						{
							return global::System.DateTime.ParseExact(text, this._dateTimeFormat, this.Culture, this._dateTimeStyles);
						}
						return global::System.DateTime.Parse(text, this.Culture, this._dateTimeStyles);
					}
				}
			}
		}

		// Token: 0x040003DC RID: 988
		private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";

		// Token: 0x040003DD RID: 989
		private global::System.Globalization.DateTimeStyles _dateTimeStyles = global::System.Globalization.DateTimeStyles.RoundtripKind;

		// Token: 0x040003DE RID: 990
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private string _dateTimeFormat;

		// Token: 0x040003DF RID: 991
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private global::System.Globalization.CultureInfo _culture;
	}
}
