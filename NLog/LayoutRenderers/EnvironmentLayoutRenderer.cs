using System;
using System.Collections.Generic;
using System.Text;
using NLog.Config;
using NLog.Internal;
using NLog.Layouts;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000B1 RID: 177
	[global::NLog.LayoutRenderers.LayoutRenderer("environment")]
	[global::NLog.Config.ThreadSafe]
	public class EnvironmentLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x0001AFC3 File Offset: 0x000191C3
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x0001AFCB File Offset: 0x000191CB
		[global::NLog.Config.RequiredParameter]
		[global::NLog.Config.DefaultParameter]
		public string Variable { get; set; }

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x0001AFD4 File Offset: 0x000191D4
		// (set) Token: 0x06000A9F RID: 2719 RVA: 0x0001AFDC File Offset: 0x000191DC
		public string Default { get; set; }

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0001AFE8 File Offset: 0x000191E8
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			if (this.Variable != null)
			{
				string text = global::NLog.Internal.EnvironmentHelper.GetSafeEnvironmentVariable(this.Variable);
				if (string.IsNullOrEmpty(text))
				{
					text = this.Default;
				}
				if (!string.IsNullOrEmpty(text))
				{
					global::System.Collections.Generic.KeyValuePair<string, global::NLog.Layouts.SimpleLayout> cachedValue = this._cachedValue;
					if (string.CompareOrdinal(cachedValue.Key, text) != 0)
					{
						cachedValue = new global::System.Collections.Generic.KeyValuePair<string, global::NLog.Layouts.SimpleLayout>(text, new global::NLog.Layouts.SimpleLayout(text));
						this._cachedValue = cachedValue;
					}
					cachedValue.Value.RenderAppendBuilder(logEvent, builder, false);
				}
			}
		}

		// Token: 0x040002A1 RID: 673
		private global::System.Collections.Generic.KeyValuePair<string, global::NLog.Layouts.SimpleLayout> _cachedValue;
	}
}
