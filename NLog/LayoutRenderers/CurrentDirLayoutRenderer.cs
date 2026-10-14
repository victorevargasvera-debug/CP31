using System;
using System.IO;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000AF RID: 175
	[global::NLog.LayoutRenderers.LayoutRenderer("currentdir")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class CurrentDirLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000A8D RID: 2701 RVA: 0x0001ADB8 File Offset: 0x00018FB8
		// (set) Token: 0x06000A8E RID: 2702 RVA: 0x0001ADC0 File Offset: 0x00018FC0
		public string File { get; set; }

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000A8F RID: 2703 RVA: 0x0001ADC9 File Offset: 0x00018FC9
		// (set) Token: 0x06000A90 RID: 2704 RVA: 0x0001ADD1 File Offset: 0x00018FD1
		public string Dir { get; set; }

		// Token: 0x06000A91 RID: 2705 RVA: 0x0001ADDC File Offset: 0x00018FDC
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			string value = global::NLog.Internal.PathHelpers.CombinePaths(global::System.IO.Directory.GetCurrentDirectory(), this.Dir, this.File);
			builder.Append(value);
		}
	}
}
