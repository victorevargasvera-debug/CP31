using System;
using Loupe.Extensibility.Data;

namespace Loupe.Extensibility.Server
{
	// Token: 0x02000054 RID: 84
	internal class IssueEventArgs : global::System.EventArgs
	{
		// Token: 0x060004CC RID: 1228 RVA: 0x0000BFFC File Offset: 0x0000A1FC
		public IssueEventArgs(global::Loupe.Extensibility.Data.IIssue issue)
		{
			this.Issue = issue;
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x0000C00C File Offset: 0x0000A20C
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x0000C014 File Offset: 0x0000A214
		public global::Loupe.Extensibility.Data.IIssue Issue { get; private set; }
	}
}
