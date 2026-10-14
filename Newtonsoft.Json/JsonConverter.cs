using System;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json
{
	// Token: 0x0200001A RID: 26
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public abstract class JsonConverter
	{
		// Token: 0x06000081 RID: 129
		public abstract void WriteJson(global::Newtonsoft.Json.JsonWriter writer, [global::System.Runtime.CompilerServices.Nullable(2)] object value, global::Newtonsoft.Json.JsonSerializer serializer);

		// Token: 0x06000082 RID: 130
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public abstract object ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, [global::System.Runtime.CompilerServices.Nullable(2)] object existingValue, global::Newtonsoft.Json.JsonSerializer serializer);

		// Token: 0x06000083 RID: 131
		public abstract bool CanConvert(global::System.Type objectType);

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00002E5B File Offset: 0x0000105B
		public virtual bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00002E5E File Offset: 0x0000105E
		public virtual bool CanWrite
		{
			get
			{
				return true;
			}
		}
	}
}
