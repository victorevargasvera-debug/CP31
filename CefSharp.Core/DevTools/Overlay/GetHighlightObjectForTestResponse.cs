using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001D7 RID: 471
	[global::System.Runtime.Serialization.DataContract]
	public class GetHighlightObjectForTestResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x00010257 File Offset: 0x0000E457
		// (set) Token: 0x06000E34 RID: 3636 RVA: 0x0001025F File Offset: 0x0000E45F
		[global::System.Runtime.Serialization.DataMember]
		internal object highlight { get; set; }

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06000E35 RID: 3637 RVA: 0x00010268 File Offset: 0x0000E468
		public object Highlight
		{
			get
			{
				return this.highlight;
			}
		}
	}
}
