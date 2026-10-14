using System;
using System.ComponentModel;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000D2 RID: 210
	[global::NLog.LayoutRenderers.LayoutRenderer("processname")]
	[global::NLog.Config.AppDomainFixedOutput]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class ProcessNameLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x0001D22B File Offset: 0x0001B42B
		// (set) Token: 0x06000B9F RID: 2975 RVA: 0x0001D233 File Offset: 0x0001B433
		[global::System.ComponentModel.DefaultValue(false)]
		public bool FullName { get; set; }

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0001D23C File Offset: 0x0001B43C
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			string value = this.FullName ? global::NLog.Internal.ThreadIDHelper.Instance.CurrentProcessName : global::NLog.Internal.ThreadIDHelper.Instance.CurrentProcessBaseName;
			builder.Append(value);
		}
	}
}
