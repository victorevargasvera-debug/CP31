using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000305 RID: 773
	[global::System.Runtime.Serialization.DataContract]
	public class MediaQuery : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x060017B0 RID: 6064 RVA: 0x00019C5B File Offset: 0x00017E5B
		// (set) Token: 0x060017B1 RID: 6065 RVA: 0x00019C63 File Offset: 0x00017E63
		[global::System.Runtime.Serialization.DataMember(Name = "expressions", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.MediaQueryExpression> Expressions { get; set; }

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x00019C6C File Offset: 0x00017E6C
		// (set) Token: 0x060017B3 RID: 6067 RVA: 0x00019C74 File Offset: 0x00017E74
		[global::System.Runtime.Serialization.DataMember(Name = "active", IsRequired = true)]
		public bool Active { get; set; }
	}
}
