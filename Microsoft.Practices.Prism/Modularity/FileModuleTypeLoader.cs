using System;
using System.Collections.Generic;
using System.IO;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x0200002A RID: 42
	public class FileModuleTypeLoader : global::Microsoft.Practices.Prism.Modularity.IModuleTypeLoader, global::System.IDisposable
	{
		// Token: 0x060000CD RID: 205 RVA: 0x0000438C File Offset: 0x0000258C
		public FileModuleTypeLoader() : this(new global::Microsoft.Practices.Prism.Modularity.AssemblyResolver())
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00004399 File Offset: 0x00002599
		public FileModuleTypeLoader(global::Microsoft.Practices.Prism.Modularity.IAssemblyResolver assemblyResolver)
		{
			this.assemblyResolver = assemblyResolver;
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060000CF RID: 207 RVA: 0x000043B4 File Offset: 0x000025B4
		// (remove) Token: 0x060000D0 RID: 208 RVA: 0x000043EC File Offset: 0x000025EC
		public event global::System.EventHandler<global::Microsoft.Practices.Prism.Modularity.ModuleDownloadProgressChangedEventArgs> ModuleDownloadProgressChanged;

		// Token: 0x060000D1 RID: 209 RVA: 0x00004421 File Offset: 0x00002621
		private void RaiseModuleDownloadProgressChanged(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo, long bytesReceived, long totalBytesToReceive)
		{
			this.RaiseModuleDownloadProgressChanged(new global::Microsoft.Practices.Prism.Modularity.ModuleDownloadProgressChangedEventArgs(moduleInfo, bytesReceived, totalBytesToReceive));
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00004431 File Offset: 0x00002631
		private void RaiseModuleDownloadProgressChanged(global::Microsoft.Practices.Prism.Modularity.ModuleDownloadProgressChangedEventArgs e)
		{
			if (this.ModuleDownloadProgressChanged != null)
			{
				this.ModuleDownloadProgressChanged(this, e);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060000D3 RID: 211 RVA: 0x00004448 File Offset: 0x00002648
		// (remove) Token: 0x060000D4 RID: 212 RVA: 0x00004480 File Offset: 0x00002680
		public event global::System.EventHandler<global::Microsoft.Practices.Prism.Modularity.LoadModuleCompletedEventArgs> LoadModuleCompleted;

		// Token: 0x060000D5 RID: 213 RVA: 0x000044B5 File Offset: 0x000026B5
		private void RaiseLoadModuleCompleted(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo, global::System.Exception error)
		{
			this.RaiseLoadModuleCompleted(new global::Microsoft.Practices.Prism.Modularity.LoadModuleCompletedEventArgs(moduleInfo, error));
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000044C4 File Offset: 0x000026C4
		private void RaiseLoadModuleCompleted(global::Microsoft.Practices.Prism.Modularity.LoadModuleCompletedEventArgs e)
		{
			if (this.LoadModuleCompleted != null)
			{
				this.LoadModuleCompleted(this, e);
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000044DB File Offset: 0x000026DB
		public bool CanLoadModuleType(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo)
		{
			if (moduleInfo == null)
			{
				throw new global::System.ArgumentNullException("moduleInfo");
			}
			return moduleInfo.Ref != null && moduleInfo.Ref.StartsWith("file://", global::System.StringComparison.Ordinal);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00004508 File Offset: 0x00002708
		public void LoadModuleType(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo)
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
					this.assemblyResolver.LoadAssemblyFrom(moduleInfo.Ref);
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

		// Token: 0x060000D9 RID: 217 RVA: 0x000045C8 File Offset: 0x000027C8
		private bool IsSuccessfullyDownloaded(global::System.Uri uri)
		{
			bool result;
			lock (this.downloadedUris)
			{
				result = this.downloadedUris.Contains(uri);
			}
			return result;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00004610 File Offset: 0x00002810
		private void RecordDownloadSuccess(global::System.Uri uri)
		{
			lock (this.downloadedUris)
			{
				this.downloadedUris.Add(uri);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00004658 File Offset: 0x00002858
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00004668 File Offset: 0x00002868
		protected virtual void Dispose(bool disposing)
		{
			global::System.IDisposable disposable = this.assemblyResolver as global::System.IDisposable;
			if (disposable != null)
			{
				disposable.Dispose();
			}
		}

		// Token: 0x0400003F RID: 63
		private const string RefFilePrefix = "file://";

		// Token: 0x04000040 RID: 64
		private readonly global::Microsoft.Practices.Prism.Modularity.IAssemblyResolver assemblyResolver;

		// Token: 0x04000041 RID: 65
		private global::System.Collections.Generic.HashSet<global::System.Uri> downloadedUris = new global::System.Collections.Generic.HashSet<global::System.Uri>();
	}
}
