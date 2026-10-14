using System;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000007 RID: 7
	public class FastZipEvents
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000017 RID: 23 RVA: 0x0000217C File Offset: 0x0000037C
		// (remove) Token: 0x06000018 RID: 24 RVA: 0x000021B4 File Offset: 0x000003B4
		public event global::System.EventHandler<global::ICSharpCode.SharpZipLib.Core.DirectoryEventArgs> ProcessDirectory;

		// Token: 0x06000019 RID: 25 RVA: 0x000021EC File Offset: 0x000003EC
		public bool OnDirectoryFailure(string directory, global::System.Exception e)
		{
			bool result = false;
			global::ICSharpCode.SharpZipLib.Core.DirectoryFailureHandler directoryFailure = this.DirectoryFailure;
			if (directoryFailure != null)
			{
				global::ICSharpCode.SharpZipLib.Core.ScanFailureEventArgs scanFailureEventArgs = new global::ICSharpCode.SharpZipLib.Core.ScanFailureEventArgs(directory, e);
				directoryFailure(this, scanFailureEventArgs);
				result = scanFailureEventArgs.ContinueRunning;
			}
			return result;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002220 File Offset: 0x00000420
		public bool OnFileFailure(string file, global::System.Exception e)
		{
			global::ICSharpCode.SharpZipLib.Core.FileFailureHandler fileFailure = this.FileFailure;
			bool flag = fileFailure != null;
			if (flag)
			{
				global::ICSharpCode.SharpZipLib.Core.ScanFailureEventArgs scanFailureEventArgs = new global::ICSharpCode.SharpZipLib.Core.ScanFailureEventArgs(file, e);
				fileFailure(this, scanFailureEventArgs);
				flag = scanFailureEventArgs.ContinueRunning;
			}
			return flag;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002254 File Offset: 0x00000454
		public bool OnProcessFile(string file)
		{
			bool result = true;
			global::ICSharpCode.SharpZipLib.Core.ProcessFileHandler processFile = this.ProcessFile;
			if (processFile != null)
			{
				global::ICSharpCode.SharpZipLib.Core.ScanEventArgs scanEventArgs = new global::ICSharpCode.SharpZipLib.Core.ScanEventArgs(file);
				processFile(this, scanEventArgs);
				result = scanEventArgs.ContinueRunning;
			}
			return result;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002284 File Offset: 0x00000484
		public bool OnCompletedFile(string file)
		{
			bool result = true;
			global::ICSharpCode.SharpZipLib.Core.CompletedFileHandler completedFile = this.CompletedFile;
			if (completedFile != null)
			{
				global::ICSharpCode.SharpZipLib.Core.ScanEventArgs scanEventArgs = new global::ICSharpCode.SharpZipLib.Core.ScanEventArgs(file);
				completedFile(this, scanEventArgs);
				result = scanEventArgs.ContinueRunning;
			}
			return result;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000022B4 File Offset: 0x000004B4
		public bool OnProcessDirectory(string directory, bool hasMatchingFiles)
		{
			bool result = true;
			global::System.EventHandler<global::ICSharpCode.SharpZipLib.Core.DirectoryEventArgs> processDirectory = this.ProcessDirectory;
			if (processDirectory != null)
			{
				global::ICSharpCode.SharpZipLib.Core.DirectoryEventArgs directoryEventArgs = new global::ICSharpCode.SharpZipLib.Core.DirectoryEventArgs(directory, hasMatchingFiles);
				processDirectory(this, directoryEventArgs);
				result = directoryEventArgs.ContinueRunning;
			}
			return result;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000022E5 File Offset: 0x000004E5
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000022ED File Offset: 0x000004ED
		public global::System.TimeSpan ProgressInterval
		{
			get
			{
				return this.progressInterval_;
			}
			set
			{
				this.progressInterval_ = value;
			}
		}

		// Token: 0x04000005 RID: 5
		public global::ICSharpCode.SharpZipLib.Core.ProcessFileHandler ProcessFile;

		// Token: 0x04000006 RID: 6
		public global::ICSharpCode.SharpZipLib.Core.ProgressHandler Progress;

		// Token: 0x04000007 RID: 7
		public global::ICSharpCode.SharpZipLib.Core.CompletedFileHandler CompletedFile;

		// Token: 0x04000008 RID: 8
		public global::ICSharpCode.SharpZipLib.Core.DirectoryFailureHandler DirectoryFailure;

		// Token: 0x04000009 RID: 9
		public global::ICSharpCode.SharpZipLib.Core.FileFailureHandler FileFailure;

		// Token: 0x0400000A RID: 10
		private global::System.TimeSpan progressInterval_ = global::System.TimeSpan.FromSeconds(3.0);
	}
}
