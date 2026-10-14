using System;
using System.IO;
using System.Security;
using System.Security.AccessControl;
using System.Threading;
using NLog.Common;

namespace NLog.Internal.FileAppenders
{
	// Token: 0x02000146 RID: 326
	[global::System.Security.SecuritySafeCritical]
	internal class WindowsMultiProcessFileAppender : global::NLog.Internal.FileAppenders.BaseMutexFileAppender
	{
		// Token: 0x06000E9A RID: 3738 RVA: 0x000255C0 File Offset: 0x000237C0
		public WindowsMultiProcessFileAppender(string fileName, global::NLog.Internal.FileAppenders.ICreateFileParameters parameters) : base(fileName, parameters)
		{
			try
			{
				this.CreateAppendOnlyFile(fileName);
				this._fileCharacteristicsHelper = global::NLog.Internal.FileCharacteristicsHelper.CreateHelper(parameters.ForceManaged);
			}
			catch
			{
				if (this._fileStream != null)
				{
					this._fileStream.Dispose();
				}
				this._fileStream = null;
				throw;
			}
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x0002561C File Offset: 0x0002381C
		private void CreateAppendOnlyFile(string fileName)
		{
			string directoryName = global::System.IO.Path.GetDirectoryName(fileName);
			if (!global::System.IO.Directory.Exists(directoryName))
			{
				if (!base.CreateFileParameters.CreateDirs)
				{
					throw new global::System.IO.DirectoryNotFoundException(directoryName);
				}
				global::System.IO.Directory.CreateDirectory(directoryName);
			}
			global::System.IO.FileShare fileShare = global::System.IO.FileShare.ReadWrite;
			if (base.CreateFileParameters.EnableFileDelete)
			{
				fileShare |= global::System.IO.FileShare.Delete;
			}
			try
			{
				bool flag = global::System.IO.File.Exists(fileName);
				this._fileStream = new global::System.IO.FileStream(fileName, global::System.IO.FileMode.Append, global::System.Security.AccessControl.FileSystemRights.AppendData | global::System.Security.AccessControl.FileSystemRights.Synchronize, fileShare, 1, global::System.IO.FileOptions.None);
				long position = this._fileStream.Position;
				if (flag || position > 0L)
				{
					base.CreationTimeUtc = global::System.IO.File.GetCreationTimeUtc(base.FileName);
					if (base.CreationTimeUtc < global::System.DateTime.UtcNow - global::System.TimeSpan.FromSeconds(2.0) && position == 0L)
					{
						global::System.Threading.Thread.Sleep(50);
						base.CreationTimeUtc = global::System.IO.File.GetCreationTimeUtc(base.FileName);
					}
				}
				else
				{
					base.CreationTimeUtc = global::System.DateTime.UtcNow;
					global::System.IO.File.SetCreationTimeUtc(base.FileName, base.CreationTimeUtc);
				}
			}
			catch
			{
				if (this._fileStream != null)
				{
					this._fileStream.Dispose();
				}
				this._fileStream = null;
				throw;
			}
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x00025734 File Offset: 0x00023934
		public override void Write(byte[] bytes, int offset, int count)
		{
			if (this._fileStream != null)
			{
				this._fileStream.Write(bytes, offset, count);
			}
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x0002574C File Offset: 0x0002394C
		public override void Close()
		{
			if (this._fileStream == null)
			{
				return;
			}
			global::NLog.Common.InternalLogger.Trace<string>("Closing '{0}'", base.FileName);
			try
			{
				global::System.IO.FileStream fileStream = this._fileStream;
				if (fileStream != null)
				{
					fileStream.Dispose();
				}
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Warn(ex, "Failed to close file '{0}'", new object[]
				{
					base.FileName
				});
				global::System.Threading.Thread.Sleep(1);
			}
			finally
			{
				this._fileStream = null;
			}
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x000257CC File Offset: 0x000239CC
		public override void Flush()
		{
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x000257CE File Offset: 0x000239CE
		public override global::System.DateTime? GetFileCreationTimeUtc()
		{
			return new global::System.DateTime?(base.CreationTimeUtc);
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x000257DC File Offset: 0x000239DC
		public override long? GetFileLength()
		{
			global::NLog.Internal.FileCharacteristics fileCharacteristics = this.GetFileCharacteristics();
			if (fileCharacteristics == null)
			{
				return null;
			}
			return new long?(fileCharacteristics.FileLength);
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00025808 File Offset: 0x00023A08
		private global::NLog.Internal.FileCharacteristics GetFileCharacteristics()
		{
			return this._fileCharacteristicsHelper.GetFileCharacteristics(base.FileName, this._fileStream);
		}

		// Token: 0x04000409 RID: 1033
		public static readonly global::NLog.Internal.FileAppenders.IFileAppenderFactory TheFactory = new global::NLog.Internal.FileAppenders.WindowsMultiProcessFileAppender.Factory();

		// Token: 0x0400040A RID: 1034
		private global::System.IO.FileStream _fileStream;

		// Token: 0x0400040B RID: 1035
		private readonly global::NLog.Internal.FileCharacteristicsHelper _fileCharacteristicsHelper;

		// Token: 0x0200022E RID: 558
		private class Factory : global::NLog.Internal.FileAppenders.IFileAppenderFactory
		{
			// Token: 0x06001363 RID: 4963 RVA: 0x0003271C File Offset: 0x0003091C
			global::NLog.Internal.FileAppenders.BaseFileAppender global::NLog.Internal.FileAppenders.IFileAppenderFactory.Open(string fileName, global::NLog.Internal.FileAppenders.ICreateFileParameters parameters)
			{
				return new global::NLog.Internal.FileAppenders.WindowsMultiProcessFileAppender(fileName, parameters);
			}
		}
	}
}
