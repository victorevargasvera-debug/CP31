using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200009B RID: 155
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class MemoryTraceWriter : global::Newtonsoft.Json.Serialization.ITraceWriter
	{
		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x000238FD File Offset: 0x00021AFD
		// (set) Token: 0x0600081A RID: 2074 RVA: 0x00023905 File Offset: 0x00021B05
		public global::System.Diagnostics.TraceLevel LevelFilter { get; set; }

		// Token: 0x0600081B RID: 2075 RVA: 0x0002390E File Offset: 0x00021B0E
		public MemoryTraceWriter()
		{
			this.LevelFilter = global::System.Diagnostics.TraceLevel.Verbose;
			this._traceMessages = new global::System.Collections.Generic.Queue<string>();
			this._lock = new object();
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00023934 File Offset: 0x00021B34
		public void Trace(global::System.Diagnostics.TraceLevel level, string message, [global::System.Runtime.CompilerServices.Nullable(2)] global::System.Exception ex)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(global::System.DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff", global::System.Globalization.CultureInfo.InvariantCulture));
			stringBuilder.Append(" ");
			stringBuilder.Append(level.ToString("g"));
			stringBuilder.Append(" ");
			stringBuilder.Append(message);
			string item = stringBuilder.ToString();
			object @lock = this._lock;
			lock (@lock)
			{
				if (this._traceMessages.Count >= 1000)
				{
					this._traceMessages.Dequeue();
				}
				this._traceMessages.Enqueue(item);
			}
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x000239F8 File Offset: 0x00021BF8
		public global::System.Collections.Generic.IEnumerable<string> GetTraceMessages()
		{
			return this._traceMessages;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00023A00 File Offset: 0x00021C00
		public override string ToString()
		{
			object @lock = this._lock;
			string result;
			lock (@lock)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				foreach (string value in this._traceMessages)
				{
					if (stringBuilder.Length > 0)
					{
						stringBuilder.AppendLine();
					}
					stringBuilder.Append(value);
				}
				result = stringBuilder.ToString();
			}
			return result;
		}

		// Token: 0x040002C2 RID: 706
		private readonly global::System.Collections.Generic.Queue<string> _traceMessages;

		// Token: 0x040002C3 RID: 707
		private readonly object _lock;
	}
}
