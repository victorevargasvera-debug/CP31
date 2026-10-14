using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x02000033 RID: 51
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	[global::System.Serializable]
	public class JsonWriterException : global::Newtonsoft.Json.JsonException
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000414 RID: 1044 RVA: 0x00010083 File Offset: 0x0000E283
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public string Path { [global::System.Runtime.CompilerServices.NullableContext(2)] get; }

		// Token: 0x06000415 RID: 1045 RVA: 0x0001008B File Offset: 0x0000E28B
		public JsonWriterException()
		{
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00010093 File Offset: 0x0000E293
		public JsonWriterException(string message) : base(message)
		{
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0001009C File Offset: 0x0000E29C
		public JsonWriterException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000100A6 File Offset: 0x0000E2A6
		public JsonWriterException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000100B0 File Offset: 0x0000E2B0
		public JsonWriterException(string message, string path, [global::System.Runtime.CompilerServices.Nullable(2)] global::System.Exception innerException) : base(message, innerException)
		{
			this.Path = path;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000100C1 File Offset: 0x0000E2C1
		internal static global::Newtonsoft.Json.JsonWriterException Create(global::Newtonsoft.Json.JsonWriter writer, string message, [global::System.Runtime.CompilerServices.Nullable(2)] global::System.Exception ex)
		{
			return global::Newtonsoft.Json.JsonWriterException.Create(writer.ContainerPath, message, ex);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000100D0 File Offset: 0x0000E2D0
		internal static global::Newtonsoft.Json.JsonWriterException Create(string path, string message, [global::System.Runtime.CompilerServices.Nullable(2)] global::System.Exception ex)
		{
			message = global::Newtonsoft.Json.JsonPosition.FormatMessage(null, path, message);
			return new global::Newtonsoft.Json.JsonWriterException(message, path, ex);
		}
	}
}
