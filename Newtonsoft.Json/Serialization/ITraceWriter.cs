using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000081 RID: 129
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	public interface ITraceWriter
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000681 RID: 1665
		global::System.Diagnostics.TraceLevel LevelFilter { get; }

		// Token: 0x06000682 RID: 1666
		void Trace(global::System.Diagnostics.TraceLevel level, string message, [global::System.Runtime.CompilerServices.Nullable(2)] global::System.Exception ex);
	}
}
