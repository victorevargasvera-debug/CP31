using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001D9 RID: 473
	[global::System.Runtime.Serialization.DataContract]
	public class GetSourceOrderHighlightObjectForTestResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000E3B RID: 3643 RVA: 0x00010299 File Offset: 0x0000E499
		// (set) Token: 0x06000E3C RID: 3644 RVA: 0x000102A1 File Offset: 0x0000E4A1
		[global::System.Runtime.Serialization.DataMember]
		internal object highlight { get; set; }

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000E3D RID: 3645 RVA: 0x000102AA File Offset: 0x0000E4AA
		public object Highlight
		{
			get
			{
				return this.highlight;
			}
		}
	}
}
