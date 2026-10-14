using System;
using System.Text;

namespace NLog.Internal
{
	// Token: 0x02000107 RID: 263
	internal interface ILogMessageFormatter
	{
		// Token: 0x06000CE5 RID: 3301
		string FormatMessage(global::NLog.LogEventInfo logEvent);

		// Token: 0x06000CE6 RID: 3302
		bool HasProperties(global::NLog.LogEventInfo logEvent);

		// Token: 0x06000CE7 RID: 3303
		void AppendFormattedMessage(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder builder);
	}
}
