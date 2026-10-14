using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x0200001B RID: 27
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public abstract class JsonConverter<[global::System.Runtime.CompilerServices.Nullable(2)] T> : global::Newtonsoft.Json.JsonConverter
	{
		// Token: 0x06000087 RID: 135 RVA: 0x00002E6C File Offset: 0x0000106C
		public sealed override void WriteJson(global::Newtonsoft.Json.JsonWriter writer, [global::System.Runtime.CompilerServices.Nullable(2)] object value, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (!((value != null) ? (value is T) : global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullable(typeof(T))))
			{
				throw new global::Newtonsoft.Json.JsonSerializationException("Converter cannot write specified value to JSON. {0} is required.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, typeof(T)));
			}
			this.WriteJson(writer, (T)((object)value), serializer);
		}

		// Token: 0x06000088 RID: 136
		public abstract void WriteJson(global::Newtonsoft.Json.JsonWriter writer, [global::System.Runtime.CompilerServices.Nullable(2)] T value, global::Newtonsoft.Json.JsonSerializer serializer);

		// Token: 0x06000089 RID: 137 RVA: 0x00002EC8 File Offset: 0x000010C8
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public sealed override object ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, [global::System.Runtime.CompilerServices.Nullable(2)] object existingValue, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			bool flag = existingValue == null;
			if (!flag && !(existingValue is T))
			{
				throw new global::Newtonsoft.Json.JsonSerializationException("Converter cannot read JSON with the specified existing value. {0} is required.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, typeof(T)));
			}
			return this.ReadJson(reader, objectType, flag ? default(T) : ((T)((object)existingValue)), !flag, serializer);
		}

		// Token: 0x0600008A RID: 138
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public abstract T ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, [global::System.Runtime.CompilerServices.Nullable(2)] T existingValue, bool hasExistingValue, global::Newtonsoft.Json.JsonSerializer serializer);

		// Token: 0x0600008B RID: 139 RVA: 0x00002F2B File Offset: 0x0000112B
		public sealed override bool CanConvert(global::System.Type objectType)
		{
			return typeof(T).IsAssignableFrom(objectType);
		}
	}
}
