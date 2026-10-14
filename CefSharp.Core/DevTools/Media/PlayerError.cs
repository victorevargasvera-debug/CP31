using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Media
{
	// Token: 0x020000B8 RID: 184
	[global::System.Runtime.Serialization.DataContract]
	public class PlayerError : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x00008F7B File Offset: 0x0000717B
		// (set) Token: 0x06000638 RID: 1592 RVA: 0x00008F83 File Offset: 0x00007183
		[global::System.Runtime.Serialization.DataMember(Name = "errorType", IsRequired = true)]
		public string ErrorType { get; set; }

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x00008F8C File Offset: 0x0000718C
		// (set) Token: 0x0600063A RID: 1594 RVA: 0x00008F94 File Offset: 0x00007194
		[global::System.Runtime.Serialization.DataMember(Name = "code", IsRequired = true)]
		public int Code { get; set; }

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x00008F9D File Offset: 0x0000719D
		// (set) Token: 0x0600063C RID: 1596 RVA: 0x00008FA5 File Offset: 0x000071A5
		[global::System.Runtime.Serialization.DataMember(Name = "stack", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Media.PlayerErrorSourceLocation> Stack { get; set; }

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x00008FAE File Offset: 0x000071AE
		// (set) Token: 0x0600063E RID: 1598 RVA: 0x00008FB6 File Offset: 0x000071B6
		[global::System.Runtime.Serialization.DataMember(Name = "cause", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Media.PlayerError> Cause { get; set; }

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600063F RID: 1599 RVA: 0x00008FBF File Offset: 0x000071BF
		// (set) Token: 0x06000640 RID: 1600 RVA: 0x00008FC7 File Offset: 0x000071C7
		[global::System.Runtime.Serialization.DataMember(Name = "data", IsRequired = true)]
		public object Data { get; set; }
	}
}
