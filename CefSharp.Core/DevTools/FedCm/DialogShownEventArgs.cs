using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.FedCm
{
	// Token: 0x0200009D RID: 157
	[global::System.Runtime.Serialization.DataContract]
	public class DialogShownEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x000086D8 File Offset: 0x000068D8
		// (set) Token: 0x0600059B RID: 1435 RVA: 0x000086E0 File Offset: 0x000068E0
		[global::System.Runtime.Serialization.DataMember(Name = "dialogId", IsRequired = true)]
		public string DialogId { get; private set; }

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600059C RID: 1436 RVA: 0x000086E9 File Offset: 0x000068E9
		// (set) Token: 0x0600059D RID: 1437 RVA: 0x000086F1 File Offset: 0x000068F1
		[global::System.Runtime.Serialization.DataMember(Name = "accounts", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.FedCm.Account> Accounts { get; private set; }

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600059E RID: 1438 RVA: 0x000086FA File Offset: 0x000068FA
		// (set) Token: 0x0600059F RID: 1439 RVA: 0x00008702 File Offset: 0x00006902
		[global::System.Runtime.Serialization.DataMember(Name = "title", IsRequired = true)]
		public string Title { get; private set; }

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x0000870B File Offset: 0x0000690B
		// (set) Token: 0x060005A1 RID: 1441 RVA: 0x00008713 File Offset: 0x00006913
		[global::System.Runtime.Serialization.DataMember(Name = "subtitle", IsRequired = false)]
		public string Subtitle { get; private set; }
	}
}
