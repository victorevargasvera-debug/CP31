using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.DOM;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001B1 RID: 433
	[global::System.Runtime.Serialization.DataContract]
	public class GetLayoutMetricsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x0000E911 File Offset: 0x0000CB11
		// (set) Token: 0x06000CDB RID: 3291 RVA: 0x0000E919 File Offset: 0x0000CB19
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Page.LayoutViewport layoutViewport { get; set; }

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x0000E922 File Offset: 0x0000CB22
		public global::CefSharp.DevTools.Page.LayoutViewport LayoutViewport
		{
			get
			{
				return this.layoutViewport;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000CDD RID: 3293 RVA: 0x0000E92A File Offset: 0x0000CB2A
		// (set) Token: 0x06000CDE RID: 3294 RVA: 0x0000E932 File Offset: 0x0000CB32
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Page.VisualViewport visualViewport { get; set; }

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x0000E93B File Offset: 0x0000CB3B
		public global::CefSharp.DevTools.Page.VisualViewport VisualViewport
		{
			get
			{
				return this.visualViewport;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x0000E943 File Offset: 0x0000CB43
		// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x0000E94B File Offset: 0x0000CB4B
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.DOM.Rect contentSize { get; set; }

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x0000E954 File Offset: 0x0000CB54
		public global::CefSharp.DevTools.DOM.Rect ContentSize
		{
			get
			{
				return this.contentSize;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x0000E95C File Offset: 0x0000CB5C
		// (set) Token: 0x06000CE4 RID: 3300 RVA: 0x0000E964 File Offset: 0x0000CB64
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Page.LayoutViewport cssLayoutViewport { get; set; }

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x0000E96D File Offset: 0x0000CB6D
		public global::CefSharp.DevTools.Page.LayoutViewport CssLayoutViewport
		{
			get
			{
				return this.cssLayoutViewport;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x0000E975 File Offset: 0x0000CB75
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x0000E97D File Offset: 0x0000CB7D
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Page.VisualViewport cssVisualViewport { get; set; }

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x0000E986 File Offset: 0x0000CB86
		public global::CefSharp.DevTools.Page.VisualViewport CssVisualViewport
		{
			get
			{
				return this.cssVisualViewport;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x0000E98E File Offset: 0x0000CB8E
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x0000E996 File Offset: 0x0000CB96
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.DOM.Rect cssContentSize { get; set; }

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x0000E99F File Offset: 0x0000CB9F
		public global::CefSharp.DevTools.DOM.Rect CssContentSize
		{
			get
			{
				return this.cssContentSize;
			}
		}
	}
}
