using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000E0 RID: 224
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public abstract class CustomCreationConverter<[global::System.Runtime.CompilerServices.Nullable(2)] T> : global::Newtonsoft.Json.JsonConverter
	{
		// Token: 0x06000C2E RID: 3118 RVA: 0x00030D11 File Offset: 0x0002EF11
		public override void WriteJson(global::Newtonsoft.Json.JsonWriter writer, [global::System.Runtime.CompilerServices.Nullable(2)] object value, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			throw new global::System.NotSupportedException("CustomCreationConverter should only be used while deserializing.");
		}

		// Token: 0x06000C2F RID: 3119 RVA: 0x00030D20 File Offset: 0x0002EF20
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public override object ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, [global::System.Runtime.CompilerServices.Nullable(2)] object existingValue, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.Null)
			{
				return null;
			}
			T t = this.Create(objectType);
			if (t == null)
			{
				throw new global::Newtonsoft.Json.JsonSerializationException("No object created.");
			}
			serializer.Populate(reader, t);
			return t;
		}

		// Token: 0x06000C30 RID: 3120
		public abstract T Create(global::System.Type objectType);

		// Token: 0x06000C31 RID: 3121 RVA: 0x00030D68 File Offset: 0x0002EF68
		public override bool CanConvert(global::System.Type objectType)
		{
			return typeof(T).IsAssignableFrom(objectType);
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x00030D7A File Offset: 0x0002EF7A
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}
	}
}
