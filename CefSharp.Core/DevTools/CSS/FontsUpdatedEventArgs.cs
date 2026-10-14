using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000314 RID: 788
	[global::System.Runtime.Serialization.DataContract]
	public class FontsUpdatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x0001A169 File Offset: 0x00018369
		// (set) Token: 0x0600183C RID: 6204 RVA: 0x0001A171 File Offset: 0x00018371
		[global::System.Runtime.Serialization.DataMember(Name = "font", IsRequired = false)]
		public global::CefSharp.DevTools.CSS.FontFace Font { get; private set; }
	}
}
