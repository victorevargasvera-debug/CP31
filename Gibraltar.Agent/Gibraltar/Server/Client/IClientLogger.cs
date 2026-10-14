using System;
using Loupe.Extensibility.Data;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000128 RID: 296
	internal interface IClientLogger
	{
		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06000C19 RID: 3097
		bool SilentMode { get; }

		// Token: 0x06000C1A RID: 3098
		void Write(global::Loupe.Extensibility.Data.LogMessageSeverity severity, string category, string caption, string description, params object[] args);

		// Token: 0x06000C1B RID: 3099
		void Write(global::Loupe.Extensibility.Data.LogMessageSeverity severity, global::System.Exception exception, bool attributeToException, string category, string caption, string description, params object[] args);
	}
}
