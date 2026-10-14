using System;
using System.Text;
using NLog.Config;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000BC RID: 188
	[global::NLog.LayoutRenderers.LayoutRenderer("install-context")]
	[global::NLog.Config.ThreadSafe]
	public class InstallContextLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x0001BC0C File Offset: 0x00019E0C
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x0001BC14 File Offset: 0x00019E14
		[global::NLog.Config.RequiredParameter]
		[global::NLog.Config.DefaultParameter]
		public string Parameter { get; set; }

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0001BC20 File Offset: 0x00019E20
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			object value;
			if (logEvent.Properties.TryGetValue(this.Parameter, out value))
			{
				global::System.IFormatProvider formatProvider = base.GetFormatProvider(logEvent, null);
				builder.Append(global::System.Convert.ToString(value, formatProvider));
			}
		}
	}
}
