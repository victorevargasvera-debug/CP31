using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Loupe.Extensibility.Data;

namespace Loupe.Extensibility
{
	// Token: 0x0200004D RID: 77
	internal interface ILog
	{
		// Token: 0x06000479 RID: 1145
		void Critical(string category, string caption, string description, params object[] args);

		// Token: 0x0600047A RID: 1146
		void Critical(global::System.Exception exception, string category, string caption, string description, params object[] args);

		// Token: 0x0600047B RID: 1147
		void Error(global::System.Exception exception, string category, string caption, string description, params object[] args);

		// Token: 0x0600047C RID: 1148
		void Error(string category, string caption, string description, params object[] args);

		// Token: 0x0600047D RID: 1149
		void Warning(global::System.Exception exception, string category, string caption, string description, params object[] args);

		// Token: 0x0600047E RID: 1150
		void Warning(string category, string caption, string description, params object[] args);

		// Token: 0x0600047F RID: 1151
		void Information(global::System.Exception exception, string category, string caption, string description, params object[] args);

		// Token: 0x06000480 RID: 1152
		void Information(string category, string caption, string description, params object[] args);

		// Token: 0x06000481 RID: 1153
		void Verbose(global::System.Exception exception, string category, string caption, string description, params object[] args);

		// Token: 0x06000482 RID: 1154
		void Verbose(string category, string caption, string description, params object[] args);

		// Token: 0x06000483 RID: 1155
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		void RecordException(global::System.Exception exception, string category, bool canContinue);

		// Token: 0x06000484 RID: 1156
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		global::System.Windows.Forms.DialogResult ReportException(global::System.Exception exception, string category, bool canContinue, bool waitForResponse);

		// Token: 0x06000485 RID: 1157
		void Write(global::Loupe.Extensibility.Data.LogMessageSeverity severity, int skipFrames, global::System.Exception exception, string detailsXml, string category, string caption, string description, params object[] args);
	}
}
