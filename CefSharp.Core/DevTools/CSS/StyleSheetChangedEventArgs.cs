using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000316 RID: 790
	[global::System.Runtime.Serialization.DataContract]
	public class StyleSheetChangedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06001841 RID: 6209 RVA: 0x0001A19B File Offset: 0x0001839B
		// (set) Token: 0x06001842 RID: 6210 RVA: 0x0001A1A3 File Offset: 0x000183A3
		[global::System.Runtime.Serialization.DataMember(Name = "styleSheetId", IsRequired = true)]
		public string StyleSheetId { get; private set; }
	}
}
