using System;
using System.Collections.Generic;
using System.Text;
using NLog.Common;
using NLog.Config;
using NLog.Layouts;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000E1 RID: 225
	[global::NLog.LayoutRenderers.LayoutRenderer("var")]
	[global::NLog.Config.ThreadSafe]
	public class VariableLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x0001DD6F File Offset: 0x0001BF6F
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x0001DD77 File Offset: 0x0001BF77
		[global::NLog.Config.RequiredParameter]
		[global::NLog.Config.DefaultParameter]
		public string Name { get; set; }

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x0001DD80 File Offset: 0x0001BF80
		// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x0001DD88 File Offset: 0x0001BF88
		public string Default { get; set; }

		// Token: 0x06000BF8 RID: 3064 RVA: 0x0001DD94 File Offset: 0x0001BF94
		protected override void InitializeLayoutRenderer()
		{
			global::NLog.Layouts.SimpleLayout simpleLayout;
			if (this.TryGetLayout(out simpleLayout) && simpleLayout != null)
			{
				simpleLayout.Initialize(base.LoggingConfiguration);
				if (!simpleLayout.ThreadSafe)
				{
					global::NLog.Common.InternalLogger.Warn<string, global::NLog.Layouts.SimpleLayout>("${{var={0}}} should be declared as <variable name=\"var_{0}\" value=\"...\" /> and used like this ${var_{{0}}}. Because of unsafe Layout={1}", this.Name, simpleLayout);
				}
			}
			base.InitializeLayoutRenderer();
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x0001DDDC File Offset: 0x0001BFDC
		private bool TryGetLayout(out global::NLog.Layouts.SimpleLayout layout)
		{
			layout = null;
			if (this.Name != null)
			{
				global::NLog.Config.LoggingConfiguration loggingConfiguration = base.LoggingConfiguration;
				bool flag;
				if (loggingConfiguration == null)
				{
					flag = false;
				}
				else
				{
					global::System.Collections.Generic.IDictionary<string, global::NLog.Layouts.SimpleLayout> variables = loggingConfiguration.Variables;
					flag = (((variables != null) ? new bool?(variables.TryGetValue(this.Name, out layout)) : null) == true);
				}
				if (flag)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x0001DE44 File Offset: 0x0001C044
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			if (this.Name != null)
			{
				global::NLog.Layouts.SimpleLayout simpleLayout;
				if (this.TryGetLayout(out simpleLayout))
				{
					if (simpleLayout != null)
					{
						simpleLayout.RenderAppendBuilder(logEvent, builder, false);
						return;
					}
				}
				else if (this.Default != null)
				{
					builder.Append(this.Default);
				}
			}
		}
	}
}
