using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x0200001F RID: 31
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	[global::System.Serializable]
	public class JsonException : global::System.Exception
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00002FA1 File Offset: 0x000011A1
		public JsonException()
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002FA9 File Offset: 0x000011A9
		public JsonException(string message) : base(message)
		{
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002FB2 File Offset: 0x000011B2
		public JsonException(string message, [global::System.Runtime.CompilerServices.Nullable(2)] global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002FBC File Offset: 0x000011BC
		public JsonException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002FC6 File Offset: 0x000011C6
		internal static global::Newtonsoft.Json.JsonException Create(global::Newtonsoft.Json.IJsonLineInfo lineInfo, string path, string message)
		{
			message = global::Newtonsoft.Json.JsonPosition.FormatMessage(lineInfo, path, message);
			return new global::Newtonsoft.Json.JsonException(message);
		}
	}
}
