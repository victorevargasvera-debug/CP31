using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000317 RID: 791
	[global::System.Runtime.Serialization.DataContract]
	public class StyleSheetRemovedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x0001A1B4 File Offset: 0x000183B4
		// (set) Token: 0x06001845 RID: 6213 RVA: 0x0001A1BC File Offset: 0x000183BC
		[global::System.Runtime.Serialization.DataMember(Name = "styleSheetId", IsRequired = true)]
		public string StyleSheetId { get; private set; }
	}
}
