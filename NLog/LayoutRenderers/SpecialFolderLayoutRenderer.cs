using System;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000D8 RID: 216
	[global::NLog.LayoutRenderers.LayoutRenderer("specialfolder")]
	[global::NLog.Config.AppDomainFixedOutput]
	[global::NLog.Config.ThreadSafe]
	public class SpecialFolderLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x0001D8D8 File Offset: 0x0001BAD8
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x0001D8E0 File Offset: 0x0001BAE0
		[global::NLog.Config.DefaultParameter]
		public global::System.Environment.SpecialFolder Folder { get; set; }

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x0001D8E9 File Offset: 0x0001BAE9
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x0001D8F1 File Offset: 0x0001BAF1
		public string File { get; set; }

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000BCD RID: 3021 RVA: 0x0001D8FA File Offset: 0x0001BAFA
		// (set) Token: 0x06000BCE RID: 3022 RVA: 0x0001D902 File Offset: 0x0001BB02
		public string Dir { get; set; }

		// Token: 0x06000BCF RID: 3023 RVA: 0x0001D90C File Offset: 0x0001BB0C
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			string value = global::NLog.Internal.PathHelpers.CombinePaths(global::System.Environment.GetFolderPath(this.Folder), this.Dir, this.File);
			builder.Append(value);
		}
	}
}
