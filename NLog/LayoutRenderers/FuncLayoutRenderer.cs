using System;
using System.Text;
using NLog.Config;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000B6 RID: 182
	public class FuncLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000AD5 RID: 2773 RVA: 0x0001B850 File Offset: 0x00019A50
		public FuncLayoutRenderer(string layoutRendererName, global::System.Func<global::NLog.LogEventInfo, global::NLog.Config.LoggingConfiguration, object> renderMethod)
		{
			this.RenderMethod = renderMethod;
			this.LayoutRendererName = layoutRendererName;
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000AD6 RID: 2774 RVA: 0x0001B866 File Offset: 0x00019A66
		// (set) Token: 0x06000AD7 RID: 2775 RVA: 0x0001B86E File Offset: 0x00019A6E
		public string LayoutRendererName { get; set; }

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0001B877 File Offset: 0x00019A77
		// (set) Token: 0x06000AD9 RID: 2777 RVA: 0x0001B87F File Offset: 0x00019A7F
		public global::System.Func<global::NLog.LogEventInfo, global::NLog.Config.LoggingConfiguration, object> RenderMethod { get; private set; }

		// Token: 0x06000ADA RID: 2778 RVA: 0x0001B888 File Offset: 0x00019A88
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			if (this.RenderMethod != null)
			{
				builder.Append(this.RenderMethod(logEvent, base.LoggingConfiguration));
			}
		}
	}
}
