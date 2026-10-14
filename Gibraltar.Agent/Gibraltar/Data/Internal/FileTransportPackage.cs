using System;
using System.Globalization;
using System.IO;

namespace Gibraltar.Data.Internal
{
	// Token: 0x02000261 RID: 609
	internal class FileTransportPackage : global::Gibraltar.Data.Internal.TransportPackageBase
	{
		// Token: 0x06001F1B RID: 7963 RVA: 0x00070CD4 File Offset: 0x0006EED4
		public FileTransportPackage(string product, string application, global::Gibraltar.Data.SimplePackage package, string fileNamePath) : base(product, application, package)
		{
			if (string.IsNullOrEmpty(fileNamePath))
			{
				throw new global::System.ArgumentNullException("fileNamePath");
			}
			this.FileNamePath = fileNamePath;
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06001F1C RID: 7964 RVA: 0x00070D00 File Offset: 0x0006EF00
		// (set) Token: 0x06001F1D RID: 7965 RVA: 0x00070D08 File Offset: 0x0006EF08
		public string FileNamePath { get; private set; }

		// Token: 0x06001F1E RID: 7966 RVA: 0x00070D14 File Offset: 0x0006EF14
		protected override global::Gibraltar.Data.PackageSendEventArgs OnSend(global::Gibraltar.ProgressMonitorStack progressMonitors)
		{
			int fileSize = 0;
			global::System.Exception exception = null;
			global::Gibraltar.AsyncTaskResult result;
			string message;
			try
			{
				base.Package.Save(progressMonitors, this.FileNamePath);
				result = global::Gibraltar.AsyncTaskResult.Success;
				fileSize = (int)global::Gibraltar.FileSystemTools.GetFileSize(this.FileNamePath);
				message = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Package written to file {0}", new object[]
				{
					global::System.IO.Path.GetFileNameWithoutExtension(this.FileNamePath)
				});
			}
			catch (global::System.Exception ex)
			{
				result = global::Gibraltar.AsyncTaskResult.Error;
				message = "Unable to save the package to disk.\r\n\r\nIt's possible that you don't have sufficient access to the directory to write the file or the media is read-only.";
				exception = ex;
			}
			return new global::Gibraltar.Data.PackageSendEventArgs(fileSize, result, message, exception);
		}
	}
}
