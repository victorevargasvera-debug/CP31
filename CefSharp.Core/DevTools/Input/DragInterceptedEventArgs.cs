using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Input
{
	// Token: 0x02000269 RID: 617
	[global::System.Runtime.Serialization.DataContract]
	public class DragInterceptedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x000148AA File Offset: 0x00012AAA
		// (set) Token: 0x0600130B RID: 4875 RVA: 0x000148B2 File Offset: 0x00012AB2
		[global::System.Runtime.Serialization.DataMember(Name = "data", IsRequired = true)]
		public global::CefSharp.DevTools.Input.DragData Data { get; private set; }
	}
}
