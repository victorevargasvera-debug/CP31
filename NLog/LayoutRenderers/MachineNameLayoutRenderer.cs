using System;
using System.Text;
using NLog.Common;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000C5 RID: 197
	[global::NLog.LayoutRenderers.LayoutRenderer("machinename")]
	[global::NLog.Config.AppDomainFixedOutput]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class MachineNameLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x0001CA43 File Offset: 0x0001AC43
		// (set) Token: 0x06000B4B RID: 2891 RVA: 0x0001CA4B File Offset: 0x0001AC4B
		internal string MachineName { get; private set; }

		// Token: 0x06000B4C RID: 2892 RVA: 0x0001CA54 File Offset: 0x0001AC54
		protected override void InitializeLayoutRenderer()
		{
			base.InitializeLayoutRenderer();
			try
			{
				this.MachineName = global::NLog.Internal.EnvironmentHelper.GetMachineName();
				if (string.IsNullOrEmpty(this.MachineName))
				{
					global::NLog.Common.InternalLogger.Info("MachineName is not available.");
				}
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Error(ex, "Error getting machine name.");
				if (ex.MustBeRethrown())
				{
					throw;
				}
				this.MachineName = string.Empty;
			}
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0001CABC File Offset: 0x0001ACBC
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			builder.Append(this.MachineName);
		}
	}
}
