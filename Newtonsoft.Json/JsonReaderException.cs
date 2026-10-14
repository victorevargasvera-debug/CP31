using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Newtonsoft.Json
{
	// Token: 0x02000028 RID: 40
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	[global::System.Serializable]
	public class JsonReaderException : global::Newtonsoft.Json.JsonException
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00004B1A File Offset: 0x00002D1A
		public int LineNumber { get; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00004B22 File Offset: 0x00002D22
		public int LinePosition { get; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00004B2A File Offset: 0x00002D2A
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public string Path { [global::System.Runtime.CompilerServices.NullableContext(2)] get; }

		// Token: 0x0600012B RID: 299 RVA: 0x00004B32 File Offset: 0x00002D32
		public JsonReaderException()
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00004B3A File Offset: 0x00002D3A
		public JsonReaderException(string message) : base(message)
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00004B43 File Offset: 0x00002D43
		public JsonReaderException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00004B4D File Offset: 0x00002D4D
		public JsonReaderException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00004B57 File Offset: 0x00002D57
		public JsonReaderException(string message, string path, int lineNumber, int linePosition, [global::System.Runtime.CompilerServices.Nullable(2)] global::System.Exception innerException) : base(message, innerException)
		{
			this.Path = path;
			this.LineNumber = lineNumber;
			this.LinePosition = linePosition;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00004B78 File Offset: 0x00002D78
		internal static global::Newtonsoft.Json.JsonReaderException Create(global::Newtonsoft.Json.JsonReader reader, string message)
		{
			return global::Newtonsoft.Json.JsonReaderException.Create(reader, message, null);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00004B82 File Offset: 0x00002D82
		internal static global::Newtonsoft.Json.JsonReaderException Create(global::Newtonsoft.Json.JsonReader reader, string message, [global::System.Runtime.CompilerServices.Nullable(2)] global::System.Exception ex)
		{
			return global::Newtonsoft.Json.JsonReaderException.Create(reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, message, ex);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00004B98 File Offset: 0x00002D98
		internal static global::Newtonsoft.Json.JsonReaderException Create([global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.IJsonLineInfo lineInfo, string path, string message, [global::System.Runtime.CompilerServices.Nullable(2)] global::System.Exception ex)
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
			return new global::Newtonsoft.Json.JsonReaderException(message, path, lineNumber, linePosition, ex);
		}
	}
}
