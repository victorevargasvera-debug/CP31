using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Security
{
	// Token: 0x02000154 RID: 340
	[global::System.Runtime.Serialization.DataContract]
	public class SecurityStateChangedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0000D2B8 File Offset: 0x0000B4B8
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x0000D2D4 File Offset: 0x0000B4D4
		public global::CefSharp.DevTools.Security.SecurityState SecurityState
		{
			get
			{
				return (global::CefSharp.DevTools.Security.SecurityState)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Security.SecurityState), this.securityState);
			}
			set
			{
				this.securityState = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0000D2E7 File Offset: 0x0000B4E7
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x0000D2EF File Offset: 0x0000B4EF
		[global::System.Runtime.Serialization.DataMember(Name = "securityState", IsRequired = true)]
		internal string securityState { get; private set; }

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x0000D2F8 File Offset: 0x0000B4F8
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x0000D300 File Offset: 0x0000B500
		[global::System.Runtime.Serialization.DataMember(Name = "schemeIsCryptographic", IsRequired = true)]
		public bool SchemeIsCryptographic { get; private set; }

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000AB3 RID: 2739 RVA: 0x0000D309 File Offset: 0x0000B509
		// (set) Token: 0x06000AB4 RID: 2740 RVA: 0x0000D311 File Offset: 0x0000B511
		[global::System.Runtime.Serialization.DataMember(Name = "explanations", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Security.SecurityStateExplanation> Explanations { get; private set; }

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0000D31A File Offset: 0x0000B51A
		// (set) Token: 0x06000AB6 RID: 2742 RVA: 0x0000D322 File Offset: 0x0000B522
		[global::System.Runtime.Serialization.DataMember(Name = "insecureContentStatus", IsRequired = true)]
		public global::CefSharp.DevTools.Security.InsecureContentStatus InsecureContentStatus { get; private set; }

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0000D32B File Offset: 0x0000B52B
		// (set) Token: 0x06000AB8 RID: 2744 RVA: 0x0000D333 File Offset: 0x0000B533
		[global::System.Runtime.Serialization.DataMember(Name = "summary", IsRequired = false)]
		public string Summary { get; private set; }
	}
}
