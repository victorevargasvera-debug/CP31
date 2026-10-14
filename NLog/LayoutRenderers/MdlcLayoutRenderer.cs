using System;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000C7 RID: 199
	[global::NLog.LayoutRenderers.LayoutRenderer("mdlc")]
	[global::NLog.Config.ThreadSafe]
	public class MdlcLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x0001CB30 File Offset: 0x0001AD30
		// (set) Token: 0x06000B56 RID: 2902 RVA: 0x0001CB38 File Offset: 0x0001AD38
		[global::NLog.Config.RequiredParameter]
		[global::NLog.Config.DefaultParameter]
		public string Item { get; set; }

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x0001CB41 File Offset: 0x0001AD41
		// (set) Token: 0x06000B58 RID: 2904 RVA: 0x0001CB49 File Offset: 0x0001AD49
		public string Format { get; set; }

		// Token: 0x06000B59 RID: 2905 RVA: 0x0001CB54 File Offset: 0x0001AD54
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			object @object = global::NLog.MappedDiagnosticsLogicalContext.GetObject(this.Item);
			global::System.IFormatProvider formatProvider = base.GetFormatProvider(logEvent, null);
			builder.AppendFormattedValue(@object, this.Format, formatProvider);
		}
	}
}
