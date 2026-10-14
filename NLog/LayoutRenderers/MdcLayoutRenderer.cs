using System;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000C6 RID: 198
	[global::NLog.LayoutRenderers.LayoutRenderer("mdc")]
	[global::NLog.Config.ThreadSafe]
	public class MdcLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x0001CAD3 File Offset: 0x0001ACD3
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x0001CADB File Offset: 0x0001ACDB
		[global::NLog.Config.RequiredParameter]
		[global::NLog.Config.DefaultParameter]
		public string Item { get; set; }

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x0001CAE4 File Offset: 0x0001ACE4
		// (set) Token: 0x06000B52 RID: 2898 RVA: 0x0001CAEC File Offset: 0x0001ACEC
		public string Format { get; set; }

		// Token: 0x06000B53 RID: 2899 RVA: 0x0001CAF8 File Offset: 0x0001ACF8
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			object @object = global::NLog.MappedDiagnosticsContext.GetObject(this.Item);
			global::System.IFormatProvider formatProvider = base.GetFormatProvider(logEvent, null);
			builder.AppendFormattedValue(@object, this.Format, formatProvider);
		}
	}
}
