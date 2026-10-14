using System;
using System.IO;
using System.Reflection;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000CD RID: 205
	[global::NLog.LayoutRenderers.LayoutRenderer("nlogdir")]
	[global::NLog.Config.AppDomainFixedOutput]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class NLogDirLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000B7D RID: 2941 RVA: 0x0001CF24 File Offset: 0x0001B124
		static NLogDirLayoutRenderer()
		{
			global::System.Reflection.Assembly assembly = typeof(global::NLog.LogManager).GetAssembly();
			global::NLog.LayoutRenderers.NLogDirLayoutRenderer.NLogDir = global::System.IO.Path.GetDirectoryName((!string.IsNullOrEmpty(assembly.Location)) ? assembly.Location : new global::System.Uri(assembly.CodeBase).LocalPath);
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x0001CF70 File Offset: 0x0001B170
		// (set) Token: 0x06000B7F RID: 2943 RVA: 0x0001CF78 File Offset: 0x0001B178
		public string File { get; set; }

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x0001CF81 File Offset: 0x0001B181
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x0001CF89 File Offset: 0x0001B189
		public string Dir { get; set; }

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x0001CF92 File Offset: 0x0001B192
		// (set) Token: 0x06000B83 RID: 2947 RVA: 0x0001CF99 File Offset: 0x0001B199
		private static string NLogDir { get; set; }

		// Token: 0x06000B84 RID: 2948 RVA: 0x0001CFA1 File Offset: 0x0001B1A1
		protected override void InitializeLayoutRenderer()
		{
			this._nlogCombinedPath = null;
			base.InitializeLayoutRenderer();
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x0001CFB0 File Offset: 0x0001B1B0
		protected override void CloseLayoutRenderer()
		{
			this._nlogCombinedPath = null;
			base.CloseLayoutRenderer();
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x0001CFC0 File Offset: 0x0001B1C0
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			string text;
			if ((text = this._nlogCombinedPath) == null)
			{
				text = (this._nlogCombinedPath = global::NLog.Internal.PathHelpers.CombinePaths(global::NLog.LayoutRenderers.NLogDirLayoutRenderer.NLogDir, this.Dir, this.File));
			}
			string value = text;
			builder.Append(value);
		}

		// Token: 0x040002FC RID: 764
		private string _nlogCombinedPath;
	}
}
