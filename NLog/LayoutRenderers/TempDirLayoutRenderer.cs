using System;
using System.IO;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000DB RID: 219
	[global::NLog.LayoutRenderers.LayoutRenderer("tempdir")]
	[global::NLog.Config.AppDomainFixedOutput]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class TempDirLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000BDF RID: 3039 RVA: 0x0001DB71 File Offset: 0x0001BD71
		// (set) Token: 0x06000BE0 RID: 3040 RVA: 0x0001DB79 File Offset: 0x0001BD79
		public string File { get; set; }

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000BE1 RID: 3041 RVA: 0x0001DB82 File Offset: 0x0001BD82
		// (set) Token: 0x06000BE2 RID: 3042 RVA: 0x0001DB8A File Offset: 0x0001BD8A
		public string Dir { get; set; }

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0001DB94 File Offset: 0x0001BD94
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			string value = global::NLog.Internal.PathHelpers.CombinePaths(global::NLog.LayoutRenderers.TempDirLayoutRenderer.tempDir, this.Dir, this.File);
			builder.Append(value);
		}

		// Token: 0x0400034B RID: 843
		private static string tempDir = global::System.IO.Path.GetTempPath();
	}
}
