using System;
using System.Collections.Generic;

namespace CefSharp
{
	// Token: 0x0200009B RID: 155
	public struct ResolveCallbackResult
	{
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x00006C48 File Offset: 0x00004E48
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x00006C50 File Offset: 0x00004E50
		public global::CefSharp.CefErrorCode Result { get; private set; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x00006C59 File Offset: 0x00004E59
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x00006C61 File Offset: 0x00004E61
		public global::System.Collections.Generic.IList<string> ResolvedIpAddresses { get; private set; }

		// Token: 0x06000474 RID: 1140 RVA: 0x00006C6A File Offset: 0x00004E6A
		public ResolveCallbackResult(global::CefSharp.CefErrorCode result, global::System.Collections.Generic.IList<string> resolvedIpAddresses)
		{
			this = default(global::CefSharp.ResolveCallbackResult);
			this.Result = result;
			this.ResolvedIpAddresses = resolvedIpAddresses;
		}
	}
}
