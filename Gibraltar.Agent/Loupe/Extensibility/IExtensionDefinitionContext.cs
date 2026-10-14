using System;
using System.Drawing;

namespace Loupe.Extensibility
{
	// Token: 0x0200004A RID: 74
	internal interface IExtensionDefinitionContext
	{
		// Token: 0x06000460 RID: 1120
		void RegisterGlobalCommand(global::System.Type command);

		// Token: 0x06000461 RID: 1121
		void RegisterGlobalController(global::System.Type controller);

		// Token: 0x06000462 RID: 1122
		void RegisterLogMessageCommand(global::System.Type command);

		// Token: 0x06000463 RID: 1123
		void RegisterRepositoryCommand(global::System.Type command);

		// Token: 0x06000464 RID: 1124
		void RegisterRepositoryController(global::System.Type controller);

		// Token: 0x06000465 RID: 1125
		void RegisterSessionAnalyzer(global::System.Type analyzer);

		// Token: 0x06000466 RID: 1126
		void RegisterSessionCommand(global::System.Type command);

		// Token: 0x06000467 RID: 1127
		void RegisterSessionController(global::System.Type controller);

		// Token: 0x06000468 RID: 1128
		void RegisterSessionSummaryView(global::System.Type view, string label, string description, string toolTip);

		// Token: 0x06000469 RID: 1129
		void RegisterSessionSummaryView(global::System.Type view, string label, string description, string toolTip, global::System.Drawing.Icon icon);

		// Token: 0x0600046A RID: 1130
		void RegisterSessionView(global::System.Type view, string label, string description, string toolTip);

		// Token: 0x0600046B RID: 1131
		void RegisterSessionView(global::System.Type view, string label, string description, string toolTip, global::System.Drawing.Icon icon);

		// Token: 0x0600046C RID: 1132
		void RegisterRepositorySummaryView(global::System.Type view, string label, string description, string toolTip, global::System.Drawing.Icon icon);

		// Token: 0x0600046D RID: 1133
		void RegisterRepositoryExtension(global::System.Type extension);
	}
}
