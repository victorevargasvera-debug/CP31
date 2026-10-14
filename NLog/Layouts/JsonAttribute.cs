using System;
using NLog.Config;
using NLog.LayoutRenderers.Wrappers;

namespace NLog.Layouts
{
	// Token: 0x0200009D RID: 157
	[global::NLog.Config.NLogConfigurationItem]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class JsonAttribute
	{
		// Token: 0x060009AE RID: 2478 RVA: 0x00018BE4 File Offset: 0x00016DE4
		public JsonAttribute() : this(null, null, true)
		{
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x00018BEF File Offset: 0x00016DEF
		public JsonAttribute(string name, global::NLog.Layouts.Layout layout) : this(name, layout, true)
		{
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00018BFA File Offset: 0x00016DFA
		public JsonAttribute(string name, global::NLog.Layouts.Layout layout, bool encode)
		{
			this.Name = name;
			this.Layout = layout;
			this.Encode = encode;
			this.IncludeEmptyValue = false;
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00018C29 File Offset: 0x00016E29
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x00018C31 File Offset: 0x00016E31
		[global::NLog.Config.RequiredParameter]
		public string Name { get; set; }

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x00018C3A File Offset: 0x00016E3A
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x00018C47 File Offset: 0x00016E47
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Layouts.Layout Layout
		{
			get
			{
				return this.LayoutWrapper.Inner;
			}
			set
			{
				this.LayoutWrapper.Inner = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x00018C55 File Offset: 0x00016E55
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x00018C62 File Offset: 0x00016E62
		public bool Encode
		{
			get
			{
				return this.LayoutWrapper.JsonEncode;
			}
			set
			{
				this.LayoutWrapper.JsonEncode = value;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x00018C70 File Offset: 0x00016E70
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x00018C7D File Offset: 0x00016E7D
		public bool EscapeUnicode
		{
			get
			{
				return this.LayoutWrapper.EscapeUnicode;
			}
			set
			{
				this.LayoutWrapper.EscapeUnicode = value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x00018C8B File Offset: 0x00016E8B
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x00018C93 File Offset: 0x00016E93
		public bool IncludeEmptyValue { get; set; }

		// Token: 0x04000252 RID: 594
		internal readonly global::NLog.LayoutRenderers.Wrappers.JsonEncodeLayoutRendererWrapper LayoutWrapper = new global::NLog.LayoutRenderers.Wrappers.JsonEncodeLayoutRendererWrapper();
	}
}
