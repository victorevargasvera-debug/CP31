using System;
using System.Text;
using NLog.Config;
using NLog.LayoutRenderers;

namespace NLog.Layouts
{
	// Token: 0x020000A3 RID: 163
	[global::NLog.Layouts.Layout("Log4JXmlEventLayout")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	[global::NLog.Config.AppDomainFixedOutput]
	public class Log4JXmlEventLayout : global::NLog.Layouts.Layout, global::NLog.IIncludeContext
	{
		// Token: 0x06000A14 RID: 2580 RVA: 0x00019F7B File Offset: 0x0001817B
		public Log4JXmlEventLayout()
		{
			this.Renderer = new global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer();
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x06000A15 RID: 2581 RVA: 0x00019F8E File Offset: 0x0001818E
		// (set) Token: 0x06000A16 RID: 2582 RVA: 0x00019F96 File Offset: 0x00018196
		public global::NLog.LayoutRenderers.Log4JXmlEventLayoutRenderer Renderer { get; private set; }

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000A17 RID: 2583 RVA: 0x00019F9F File Offset: 0x0001819F
		// (set) Token: 0x06000A18 RID: 2584 RVA: 0x00019FAC File Offset: 0x000181AC
		public bool IncludeMdc
		{
			get
			{
				return this.Renderer.IncludeMdc;
			}
			set
			{
				this.Renderer.IncludeMdc = value;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000A19 RID: 2585 RVA: 0x00019FBA File Offset: 0x000181BA
		// (set) Token: 0x06000A1A RID: 2586 RVA: 0x00019FC7 File Offset: 0x000181C7
		public bool IncludeAllProperties
		{
			get
			{
				return this.Renderer.IncludeAllProperties;
			}
			set
			{
				this.Renderer.IncludeAllProperties = value;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000A1B RID: 2587 RVA: 0x00019FD5 File Offset: 0x000181D5
		// (set) Token: 0x06000A1C RID: 2588 RVA: 0x00019FE2 File Offset: 0x000181E2
		public bool IncludeNdc
		{
			get
			{
				return this.Renderer.IncludeNdc;
			}
			set
			{
				this.Renderer.IncludeNdc = value;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x00019FF0 File Offset: 0x000181F0
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x00019FFD File Offset: 0x000181FD
		public bool IncludeMdlc
		{
			get
			{
				return this.Renderer.IncludeMdlc;
			}
			set
			{
				this.Renderer.IncludeMdlc = value;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x0001A00B File Offset: 0x0001820B
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x0001A018 File Offset: 0x00018218
		public bool IncludeNdlc
		{
			get
			{
				return this.Renderer.IncludeNdlc;
			}
			set
			{
				this.Renderer.IncludeNdlc = value;
			}
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x0001A026 File Offset: 0x00018226
		internal override void PrecalculateBuilder(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
		{
			base.PrecalculateBuilderInternal(logEvent, target);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x0001A030 File Offset: 0x00018230
		protected override string GetFormattedMessage(global::NLog.LogEventInfo logEvent)
		{
			return base.RenderAllocateBuilder(logEvent, null);
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x0001A03A File Offset: 0x0001823A
		protected override void RenderFormattedMessage(global::NLog.LogEventInfo logEvent, global::System.Text.StringBuilder target)
		{
			this.Renderer.RenderAppendBuilder(logEvent, target);
		}
	}
}
