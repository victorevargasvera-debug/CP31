using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CefSharp.ModelBinding;

namespace CefSharp.Internals
{
	// Token: 0x020000E2 RID: 226
	[global::System.Runtime.Serialization.DataContract]
	public class JavascriptObject
	{
		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x0000A1D2 File Offset: 0x000083D2
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x0000A1DA File Offset: 0x000083DA
		[global::System.Runtime.Serialization.DataMember]
		public long Id { get; set; }

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x0000A1E3 File Offset: 0x000083E3
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x0000A1EB File Offset: 0x000083EB
		[global::System.Runtime.Serialization.DataMember]
		public string Name { get; set; }

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x0000A1F4 File Offset: 0x000083F4
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x0000A1FC File Offset: 0x000083FC
		[global::System.Runtime.Serialization.DataMember]
		public string JavascriptName { get; set; }

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0000A205 File Offset: 0x00008405
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x0000A20D File Offset: 0x0000840D
		[global::System.Runtime.Serialization.DataMember]
		public bool IsAsync { get; set; }

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x0000A216 File Offset: 0x00008416
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x0000A21E File Offset: 0x0000841E
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::CefSharp.Internals.JavascriptMethod> Methods { get; private set; }

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x0000A227 File Offset: 0x00008427
		// (set) Token: 0x060006A7 RID: 1703 RVA: 0x0000A22F File Offset: 0x0000842F
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::CefSharp.Internals.JavascriptProperty> Properties { get; private set; }

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x0000A238 File Offset: 0x00008438
		// (set) Token: 0x060006A9 RID: 1705 RVA: 0x0000A240 File Offset: 0x00008440
		public bool RootObject { get; set; }

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x0000A249 File Offset: 0x00008449
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x0000A251 File Offset: 0x00008451
		public object Value { get; set; }

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x0000A25A File Offset: 0x0000845A
		// (set) Token: 0x060006AD RID: 1709 RVA: 0x0000A262 File Offset: 0x00008462
		public global::CefSharp.ModelBinding.IBinder Binder { get; set; }

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x0000A26B File Offset: 0x0000846B
		// (set) Token: 0x060006AF RID: 1711 RVA: 0x0000A273 File Offset: 0x00008473
		public global::CefSharp.ModelBinding.IMethodInterceptor MethodInterceptor { get; set; }

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x0000A27C File Offset: 0x0000847C
		// (set) Token: 0x060006B1 RID: 1713 RVA: 0x0000A284 File Offset: 0x00008484
		public global::CefSharp.ModelBinding.IPropertyInterceptor PropertyInterceptor { get; set; }

		// Token: 0x060006B2 RID: 1714 RVA: 0x0000A28D File Offset: 0x0000848D
		public JavascriptObject()
		{
			this.Methods = new global::System.Collections.Generic.List<global::CefSharp.Internals.JavascriptMethod>();
			this.Properties = new global::System.Collections.Generic.List<global::CefSharp.Internals.JavascriptProperty>();
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0000A2AB File Offset: 0x000084AB
		public override string ToString()
		{
			if (this.Value == null)
			{
				return base.ToString();
			}
			return this.Value.ToString();
		}
	}
}
