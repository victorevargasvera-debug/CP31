using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x02000066 RID: 102
	public class FileSystemScanner
	{
		// Token: 0x06000459 RID: 1113 RVA: 0x00013538 File Offset: 0x00011738
		public FileSystemScanner(string filter)
		{
			this.fileFilter_ = new global::ICSharpCode.SharpZipLib.Core.PathFilter(filter);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0001354C File Offset: 0x0001174C
		public FileSystemScanner(string fileFilter, string directoryFilter)
		{
			this.fileFilter_ = new global::ICSharpCode.SharpZipLib.Core.PathFilter(fileFilter);
			this.directoryFilter_ = new global::ICSharpCode.SharpZipLib.Core.PathFilter(directoryFilter);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0001356C File Offset: 0x0001176C
		public FileSystemScanner(global::ICSharpCode.SharpZipLib.Core.IScanFilter fileFilter)
		{
			this.fileFilter_ = fileFilter;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0001357B File Offset: 0x0001177B
		public FileSystemScanner(global::ICSharpCode.SharpZipLib.Core.IScanFilter fileFilter, global::ICSharpCode.SharpZipLib.Core.IScanFilter directoryFilter)
		{
			this.fileFilter_ = fileFilter;
			this.directoryFilter_ = directoryFilter;
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600045D RID: 1117 RVA: 0x00013594 File Offset: 0x00011794
		// (remove) Token: 0x0600045E RID: 1118 RVA: 0x000135CC File Offset: 0x000117CC
		public event global::System.EventHandler<global::ICSharpCode.SharpZipLib.Core.DirectoryEventArgs> ProcessDirectory;

		// Token: 0x0600045F RID: 1119 RVA: 0x00013604 File Offset: 0x00011804
		private bool OnDirectoryFailure(string directory, global::System.Exception e)
		{
			global::ICSharpCode.SharpZipLib.Core.DirectoryFailureHandler directoryFailure = this.DirectoryFailure;
			bool flag = directoryFailure != null;
			if (flag)
			{
				global::ICSharpCode.SharpZipLib.Core.ScanFailureEventArgs scanFailureEventArgs = new global::ICSharpCode.SharpZipLib.Core.ScanFailureEventArgs(directory, e);
				directoryFailure(this, scanFailureEventArgs);
				this.alive_ = scanFailureEventArgs.ContinueRunning;
			}
			return flag;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0001363C File Offset: 0x0001183C
		private bool OnFileFailure(string file, global::System.Exception e)
		{
			bool flag = this.FileFailure != null;
			if (flag)
			{
				global::ICSharpCode.SharpZipLib.Core.ScanFailureEventArgs scanFailureEventArgs = new global::ICSharpCode.SharpZipLib.Core.ScanFailureEventArgs(file, e);
				this.FileFailure(this, scanFailureEventArgs);
				this.alive_ = scanFailureEventArgs.ContinueRunning;
			}
			return flag;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00013678 File Offset: 0x00011878
		private void OnProcessFile(string file)
		{
			global::ICSharpCode.SharpZipLib.Core.ProcessFileHandler processFile = this.ProcessFile;
			if (processFile != null)
			{
				global::ICSharpCode.SharpZipLib.Core.ScanEventArgs scanEventArgs = new global::ICSharpCode.SharpZipLib.Core.ScanEventArgs(file);
				processFile(this, scanEventArgs);
				this.alive_ = scanEventArgs.ContinueRunning;
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000136AC File Offset: 0x000118AC
		private void OnCompleteFile(string file)
		{
			global::ICSharpCode.SharpZipLib.Core.CompletedFileHandler completedFile = this.CompletedFile;
			if (completedFile != null)
			{
				global::ICSharpCode.SharpZipLib.Core.ScanEventArgs scanEventArgs = new global::ICSharpCode.SharpZipLib.Core.ScanEventArgs(file);
				completedFile(this, scanEventArgs);
				this.alive_ = scanEventArgs.ContinueRunning;
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x000136E0 File Offset: 0x000118E0
		private void OnProcessDirectory(string directory, bool hasMatchingFiles)
		{
			global::System.EventHandler<global::ICSharpCode.SharpZipLib.Core.DirectoryEventArgs> processDirectory = this.ProcessDirectory;
			if (processDirectory != null)
			{
				global::ICSharpCode.SharpZipLib.Core.DirectoryEventArgs directoryEventArgs = new global::ICSharpCode.SharpZipLib.Core.DirectoryEventArgs(directory, hasMatchingFiles);
				processDirectory(this, directoryEventArgs);
				this.alive_ = directoryEventArgs.ContinueRunning;
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00013713 File Offset: 0x00011913
		public void Scan(string directory, bool recurse)
		{
			this.alive_ = true;
			this.ScanDir(directory, recurse);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00013724 File Offset: 0x00011924
		private void ScanDir(string directory, bool recurse)
		{
			try
			{
				string[] files = global::System.IO.Directory.GetFiles(directory);
				bool flag = false;
				for (int i = 0; i < files.Length; i++)
				{
					if (!this.fileFilter_.IsMatch(files[i]))
					{
						files[i] = null;
					}
					else
					{
						flag = true;
					}
				}
				this.OnProcessDirectory(directory, flag);
				if (this.alive_ && flag)
				{
					foreach (string text in files)
					{
						try
						{
							if (text != null)
							{
								this.OnProcessFile(text);
								if (!this.alive_)
								{
									break;
								}
							}
						}
						catch (global::System.Exception e)
						{
							if (!this.OnFileFailure(text, e))
							{
								throw;
							}
						}
					}
				}
			}
			catch (global::System.Exception e2)
			{
				if (!this.OnDirectoryFailure(directory, e2))
				{
					throw;
				}
			}
			if (this.alive_ && recurse)
			{
				try
				{
					foreach (string text2 in global::System.IO.Directory.GetDirectories(directory))
					{
						if (this.directoryFilter_ == null || this.directoryFilter_.IsMatch(text2))
						{
							this.ScanDir(text2, true);
							if (!this.alive_)
							{
								break;
							}
						}
					}
				}
				catch (global::System.Exception e3)
				{
					if (!this.OnDirectoryFailure(directory, e3))
					{
						throw;
					}
				}
			}
		}

		// Token: 0x04000297 RID: 663
		public global::ICSharpCode.SharpZipLib.Core.ProcessFileHandler ProcessFile;

		// Token: 0x04000298 RID: 664
		public global::ICSharpCode.SharpZipLib.Core.CompletedFileHandler CompletedFile;

		// Token: 0x04000299 RID: 665
		public global::ICSharpCode.SharpZipLib.Core.DirectoryFailureHandler DirectoryFailure;

		// Token: 0x0400029A RID: 666
		public global::ICSharpCode.SharpZipLib.Core.FileFailureHandler FileFailure;

		// Token: 0x0400029B RID: 667
		private global::ICSharpCode.SharpZipLib.Core.IScanFilter fileFilter_;

		// Token: 0x0400029C RID: 668
		private global::ICSharpCode.SharpZipLib.Core.IScanFilter directoryFilter_;

		// Token: 0x0400029D RID: 669
		private bool alive_;
	}
}
