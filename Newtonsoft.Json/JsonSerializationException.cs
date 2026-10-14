using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x0200002A RID: 42
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	[global::System.Serializable]
	public class JsonSerializationException : global::Newtonsoft.Json.JsonException
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00004BE0 File Offset: 0x00002DE0
		public int LineNumber { get; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00004BE8 File Offset: 0x00002DE8
		public int LinePosition { get; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public string Path { [global::System.Runtime.CompilerServices.NullableContext(2)] get; }

		// Token: 0x06000137 RID: 311 RVA: 0x00004BF8 File Offset: 0x00002DF8
		public JsonSerializationException()
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00004C00 File Offset: 0x00002E00
		public JsonSerializationException(string message) : base(message)
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00004C09 File Offset: 0x00002E09
		public JsonSerializationException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00004C13 File Offset: 0x00002E13
		public JsonSerializationException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00004C1D File Offset: 0x00002E1D
		public JsonSerializationException(string message, string path, int lineNumber, int linePosition, [global::System.Runtime.CompilerServices.Nullable(2)] global::System.Exception innerException) : base(message, innerException)
		{
			this.Path = path;
			this.LineNumber = lineNumber;
			this.LinePosition = linePosition;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00004C3E File Offset: 0x00002E3E
		internal static global::Newtonsoft.Json.JsonSerializationException Create(global::Newtonsoft.Json.JsonReader reader, string message)
		{
			return global::Newtonsoft.Json.JsonSerializationException.Create(reader, message, null);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00004C48 File Offset: 0x00002E48
		internal static global::Newtonsoft.Json.JsonSerializationException Create(global::Newtonsoft.Json.JsonReader reader, string message, [global::System.Runtime.CompilerServices.Nullable(2)] global::System.Exception ex)
		{
			return global::Newtonsoft.Json.JsonSerializationException.Create(reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, message, ex);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00004C60 File Offset: 0x00002E60
		internal static global::Newtonsoft.Json.JsonSerializationException Create([global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.IJsonLineInfo lineInfo, string path, string message, [global::System.Runtime.CompilerServices.Nullable(2)] global::System.Exception ex)
		{
			message = global::Newtonsoft.Json.JsonPosition.FormatMessage(lineInfo, path, message);
			int lineNumber;
			int linePosition;
			if (lineInfo != null && lineInfo.HasLineInfo())
			{
				lineNumber = lineInfo.LineNumber;
				linePosition = lineInfo.LinePosition;
			}
			else
			{
				lineNumber = 0;
				linePosition = 0;
			}
			return new global::Newtonsoft.Json.JsonSerializationException(message, path, lineNumber, linePosition, ex);
		}
	}
}
