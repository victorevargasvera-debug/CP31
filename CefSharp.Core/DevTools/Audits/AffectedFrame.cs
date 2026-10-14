using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x0200034A RID: 842
	[global::System.Runtime.Serialization.DataContract]
	public class AffectedFrame : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x0600199B RID: 6555 RVA: 0x0001B898 File Offset: 0x00019A98
		// (set) Token: 0x0600199C RID: 6556 RVA: 0x0001B8A0 File Offset: 0x00019AA0
		[global::System.Runtime.Serialization.DataMember(Name = "frameId", IsRequired = true)]
		public string FrameId { get; set; }
	}
}
