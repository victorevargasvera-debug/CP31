using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using Microsoft.Practices.Prism.Modularity;

namespace Microsoft.Practices.Prism.MefExtensions.Modularity
{
	// Token: 0x02000007 RID: 7
	[global::System.ComponentModel.Composition.Export]
	public class MefFileModuleTypeLoader : global::Microsoft.Practices.Prism.Modularity.IModuleTypeLoader
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600001F RID: 31 RVA: 0x00002674 File Offset: 0x00000874
		// (remove) Token: 0x06000020 RID: 32 RVA: 0x000026AC File Offset: 0x000008AC
		public virtual event global::System.EventHandler<global::Microsoft.Practices.Prism.Modularity.ModuleDownloadProgressChangedEventArgs> ModuleDownloadProgressChanged;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000021 RID: 33 RVA: 0x000026E4 File Offset: 0x000008E4
		// (remove) Token: 0x06000022 RID: 34 RVA: 0x0000271C File Offset: 0x0000091C
		public virtual event global::System.EventHandler<global::Microsoft.Practices.Prism.Modularity.LoadModuleCompletedEventArgs> LoadModuleCompleted;

		// Token: 0x06000023 RID: 35 RVA: 0x00002751 File Offset: 0x00000951
		public virtual bool CanLoadModuleType(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo)
		{
			if (moduleInfo == null)
			{
				throw new global::System.ArgumentNullException("moduleInfo");
			}
			return moduleInfo.Ref != null && moduleInfo.Ref.StartsWith("file://", global::System.StringComparison.Ordinal);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000277C File Offset: 0x0000097C
		public virtual void LoadModuleType(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo)
		{
			if (moduleInfo == null)
			{
				throw new global::System.ArgumentNullException("moduleInfo");
			}
			try
			{
				global::System.Uri uri = new global::System.Uri(moduleInfo.Ref, global::System.UriKind.RelativeOrAbsolute);
				if (this.IsSuccessfullyDownloaded(uri))
				{
					this.RaiseLoadModuleCompleted(moduleInfo, null);
				}
				else
				{
					string text = moduleInfo.Ref.Substring("file://".Length + 1);
					long num = -1L;
					if (global::System.IO.File.Exists(text))
					{
						global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(text);
						num = fileInfo.Length;
					}
					this.RaiseModuleDownloadProgressChanged(moduleInfo, 0L, num);
					this.aggregateCatalog.Catalogs.Add(new global::System.ComponentModel.Composition.Hosting.AssemblyCatalog(text));
					this.RaiseModuleDownloadProgressChanged(moduleInfo, num, num);
					this.RecordDownloadSuccess(uri);
					this.RaiseLoadModuleCompleted(moduleInfo, null);
				}
			}
			catch (global::System.Exception error)
			{
				this.RaiseLoadModuleCompleted(moduleInfo, error);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002840 File Offset: 0x00000A40
		private void RaiseModuleDownloadProgressChanged(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo, long bytesReceived, long totalBytesToReceive)
		{
			this.RaiseModuleDownloadProgressChanged(new global::Microsoft.Practices.Prism.Modularity.ModuleDownloadProgressChangedEventArgs(moduleInfo, bytesReceived, totalBytesToReceive));
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002850 File Offset: 0x00000A50
		private void RaiseModuleDownloadProgressChanged(global::Microsoft.Practices.Prism.Modularity.ModuleDownloadProgressChangedEventArgs e)
		{
			if (this.ModuleDownloadProgressChanged != null)
			{
				this.ModuleDownloadProgressChanged(this, e);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002867 File Offset: 0x00000A67
		private void RaiseLoadModuleCompleted(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo, global::System.Exception error)
		{
			this.RaiseLoadModuleCompleted(new global::Microsoft.Practices.Prism.Modularity.LoadModuleCompletedEventArgs(moduleInfo, error));
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002876 File Offset: 0x00000A76
		private void RaiseLoadModuleCompleted(global::Microsoft.Practices.Prism.Modularity.LoadModuleCompletedEventArgs e)
		{
			if (this.LoadModuleCompleted != null)
			{
				this.LoadModuleCompleted(this, e);
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002890 File Offset: 0x00000A90
		private bool IsSuccessfullyDownloaded(global::System.Uri uri)
		{
			bool result;
			lock (this.downloadedUris)
			{
				result = this.downloadedUris.Contains(uri);
			}
			return result;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000028D8 File Offset: 0x00000AD8
		private void RecordDownloadSuccess(global::System.Uri uri)
		{
			lock (this.downloadedUris)
			{
				this.downloadedUris.Add(uri);
			}
		}

		// Token: 0x04000004 RID: 4
		private const string RefFilePrefix = "file://";

		// Token: 0x04000005 RID: 5
		private readonly global::System.Collections.Generic.HashSet<global::System.Uri> downloadedUris = new global::System.Collections.Generic.HashSet<global::System.Uri>();

		// Token: 0x04000006 RID: 6
		[global::System.ComponentModel.Composition.Import(AllowRecomposition = false)]
		private global::System.ComponentModel.Composition.Hosting.AggregateCatalog aggregateCatalog;
	}
}
