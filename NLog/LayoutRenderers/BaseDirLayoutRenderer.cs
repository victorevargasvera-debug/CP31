using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using NLog.Config;
using NLog.Internal;
using NLog.Internal.Fakeables;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000AA RID: 170
	[global::NLog.LayoutRenderers.LayoutRenderer("basedir")]
	[global::NLog.Config.AppDomainFixedOutput]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class BaseDirLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x0001A8FF File Offset: 0x00018AFF
		// (set) Token: 0x06000A5B RID: 2651 RVA: 0x0001A907 File Offset: 0x00018B07
		public bool ProcessDir { get; set; }

		// Token: 0x06000A5C RID: 2652 RVA: 0x0001A910 File Offset: 0x00018B10
		public BaseDirLayoutRenderer() : this(global::NLog.LogFactory.CurrentAppDomain)
		{
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x0001A91D File Offset: 0x00018B1D
		public BaseDirLayoutRenderer(global::NLog.Internal.Fakeables.IAppDomain appDomain)
		{
			this._baseDir = appDomain.BaseDirectory;
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0001A931 File Offset: 0x00018B31
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x0001A939 File Offset: 0x00018B39
		public string File { get; set; }

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x0001A942 File Offset: 0x00018B42
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x0001A94A File Offset: 0x00018B4A
		public string Dir { get; set; }

		// Token: 0x06000A62 RID: 2658 RVA: 0x0001A954 File Offset: 0x00018B54
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			string text = this._baseDir;
			if (this.ProcessDir)
			{
				string text2;
				if ((text2 = this._processDir) == null)
				{
					text2 = (this._processDir = global::System.IO.Path.GetDirectoryName(global::System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName));
				}
				text = text2;
			}
			if (text != null)
			{
				string value = global::NLog.Internal.PathHelpers.CombinePaths(text, this.Dir, this.File);
				builder.Append(value);
			}
		}

		// Token: 0x04000284 RID: 644
		private readonly string _baseDir;

		// Token: 0x04000285 RID: 645
		private string _processDir;
	}
}
