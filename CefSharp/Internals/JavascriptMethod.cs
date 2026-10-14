using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.Internals
{
	// Token: 0x020000E1 RID: 225
	[global::System.Runtime.Serialization.DataContract]
	public class JavascriptMethod
	{
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x0000A130 File Offset: 0x00008330
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x0000A138 File Offset: 0x00008338
		public global::System.Func<object, object[], object> Function { get; set; }

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x0000A141 File Offset: 0x00008341
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x0000A149 File Offset: 0x00008349
		[global::System.Runtime.Serialization.DataMember]
		public long Id { get; set; }

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x0000A152 File Offset: 0x00008352
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x0000A15A File Offset: 0x0000835A
		[global::System.Runtime.Serialization.DataMember]
		public string ManagedName { get; set; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x0000A163 File Offset: 0x00008363
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x0000A16B File Offset: 0x0000836B
		[global::System.Runtime.Serialization.DataMember]
		public string JavascriptName { get; set; }

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x0000A174 File Offset: 0x00008374
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x0000A17C File Offset: 0x0000837C
		public global::System.Collections.Generic.List<global::CefSharp.Internals.MethodParameter> Parameters { get; set; }

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x0000A185 File Offset: 0x00008385
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x0000A18D File Offset: 0x0000838D
		public bool HasParamArray { get; set; }

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x0000A196 File Offset: 0x00008396
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x0000A19E File Offset: 0x0000839E
		public int ParameterCount { get; set; }

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x0000A1A7 File Offset: 0x000083A7
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x0000A1AF File Offset: 0x000083AF
		public global::System.Type ReturnType { get; set; }

		// Token: 0x0600069A RID: 1690 RVA: 0x0000A1B8 File Offset: 0x000083B8
		public override string ToString()
		{
			return this.ManagedName ?? base.ToString();
		}
	}
}
