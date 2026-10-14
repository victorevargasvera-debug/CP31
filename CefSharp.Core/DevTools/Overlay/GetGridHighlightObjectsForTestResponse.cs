using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001D8 RID: 472
	[global::System.Runtime.Serialization.DataContract]
	public class GetGridHighlightObjectsForTestResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06000E37 RID: 3639 RVA: 0x00010278 File Offset: 0x0000E478
		// (set) Token: 0x06000E38 RID: 3640 RVA: 0x00010280 File Offset: 0x0000E480
		[global::System.Runtime.Serialization.DataMember]
		internal object highlights { get; set; }

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x06000E39 RID: 3641 RVA: 0x00010289 File Offset: 0x0000E489
		public object Highlights
		{
			get
			{
				return this.highlights;
			}
		}
	}
}
