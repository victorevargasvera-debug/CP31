using System;
using System.IO;
using System.Text;
using NLog.Common;
using NLog.Config;
using NLog.Internal;
using NLog.Layouts;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000B5 RID: 181
	[global::NLog.LayoutRenderers.LayoutRenderer("file-contents")]
	public class FileContentsLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000ACE RID: 2766 RVA: 0x0001B728 File Offset: 0x00019928
		public FileContentsLayoutRenderer()
		{
			this.Encoding = global::System.Text.Encoding.Default;
			this._lastFileName = string.Empty;
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x0001B746 File Offset: 0x00019946
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x0001B74E File Offset: 0x0001994E
		[global::NLog.Config.DefaultParameter]
		public global::NLog.Layouts.Layout FileName { get; set; }

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0001B757 File Offset: 0x00019957
		// (set) Token: 0x06000AD2 RID: 2770 RVA: 0x0001B75F File Offset: 0x0001995F
		public global::System.Text.Encoding Encoding { get; set; }

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0001B768 File Offset: 0x00019968
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			lock (this)
			{
				string text = this.FileName.Render(logEvent);
				if (text != this._lastFileName)
				{
					this._currentFileContents = this.ReadFileContents(text);
					this._lastFileName = text;
				}
			}
			builder.Append(this._currentFileContents);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0001B7DC File Offset: 0x000199DC
		private string ReadFileContents(string fileName)
		{
			string result;
			try
			{
				using (global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(fileName, this.Encoding))
				{
					result = streamReader.ReadToEnd();
				}
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Error(ex, "Cannot read file contents of '{0}'.", new object[]
				{
					fileName
				});
				if (ex.MustBeRethrown())
				{
					throw;
				}
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x040002B0 RID: 688
		private string _lastFileName;

		// Token: 0x040002B1 RID: 689
		private string _currentFileContents;
	}
}
