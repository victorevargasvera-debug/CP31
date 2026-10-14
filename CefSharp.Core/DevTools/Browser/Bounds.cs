using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Browser
{
	// Token: 0x02000330 RID: 816
	[global::System.Runtime.Serialization.DataContract]
	public class Bounds : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x060018EB RID: 6379 RVA: 0x0001AD41 File Offset: 0x00018F41
		// (set) Token: 0x060018EC RID: 6380 RVA: 0x0001AD49 File Offset: 0x00018F49
		[global::System.Runtime.Serialization.DataMember(Name = "left", IsRequired = false)]
		public int? Left { get; set; }

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x0001AD52 File Offset: 0x00018F52
		// (set) Token: 0x060018EE RID: 6382 RVA: 0x0001AD5A File Offset: 0x00018F5A
		[global::System.Runtime.Serialization.DataMember(Name = "top", IsRequired = false)]
		public int? Top { get; set; }

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x0001AD63 File Offset: 0x00018F63
		// (set) Token: 0x060018F0 RID: 6384 RVA: 0x0001AD6B File Offset: 0x00018F6B
		[global::System.Runtime.Serialization.DataMember(Name = "width", IsRequired = false)]
		public int? Width { get; set; }

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x060018F1 RID: 6385 RVA: 0x0001AD74 File Offset: 0x00018F74
		// (set) Token: 0x060018F2 RID: 6386 RVA: 0x0001AD7C File Offset: 0x00018F7C
		[global::System.Runtime.Serialization.DataMember(Name = "height", IsRequired = false)]
		public int? Height { get; set; }

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x0001AD85 File Offset: 0x00018F85
		// (set) Token: 0x060018F4 RID: 6388 RVA: 0x0001ADA1 File Offset: 0x00018FA1
		public global::CefSharp.DevTools.Browser.WindowState? WindowState
		{
			get
			{
				return (global::CefSharp.DevTools.Browser.WindowState?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Browser.WindowState?), this.windowState);
			}
			set
			{
				this.windowState = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x0001ADB4 File Offset: 0x00018FB4
		// (set) Token: 0x060018F6 RID: 6390 RVA: 0x0001ADBC File Offset: 0x00018FBC
		[global::System.Runtime.Serialization.DataMember(Name = "windowState", IsRequired = false)]
		internal string windowState { get; set; }
	}
}
