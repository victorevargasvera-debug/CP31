using System;
using System.IO;
using System.Security;
using System.Threading;
using NLog.Common;

namespace NLog.Internal.FileAppenders
{
	// Token: 0x02000142 RID: 322
	[global::System.Security.SecuritySafeCritical]
	internal class MutexMultiProcessFileAppender : global::NLog.Internal.FileAppenders.BaseMutexFileAppender
	{
		// Token: 0x06000E7D RID: 3709 RVA: 0x00025170 File Offset: 0x00023370
		public MutexMultiProcessFileAppender(string fileName, global::NLog.Internal.FileAppenders.ICreateFileParameters parameters) : base(fileName, parameters)
		{
			try
			{
				this._mutex = base.CreateSharableMutex("FileLock");
				this._fileStream = base.CreateFileStream(true);
				this._fileCharacteristicsHelper = global::NLog.Internal.FileCharacteristicsHelper.CreateHelper(parameters.ForceManaged);
			}
			catch
			{
				if (this._mutex != null)
				{
					this._mutex.Close();
					this._mutex = null;
				}
				if (this._fileStream != null)
				{
					this._fileStream.Close();
					this._fileStream = null;
				}
				throw;
			}
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00025200 File Offset: 0x00023400
		public override void Write(byte[] bytes, int offset, int count)
		{
			if (this._mutex == null || this._fileStream == null)
			{
				return;
			}
			try
			{
				this._mutex.WaitOne();
			}
			catch (global::System.Threading.AbandonedMutexException)
			{
			}
			try
			{
				this._fileStream.Seek(0L, global::System.IO.SeekOrigin.End);
				this._fileStream.Write(bytes, offset, count);
				this._fileStream.Flush();
			}
			finally
			{
				this._mutex.ReleaseMutex();
			}
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00025284 File Offset: 0x00023484
		public override void Close()
		{
			if (this._mutex == null && this._fileStream == null)
			{
				return;
			}
			global::NLog.Common.InternalLogger.Trace<string>("Closing '{0}'", base.FileName);
			try
			{
				global::System.Threading.Mutex mutex = this._mutex;
				if (mutex != null)
				{
					mutex.Close();
				}
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Warn(ex, "Failed to close mutex: '{0}'", new object[]
				{
					base.FileName
				});
			}
			finally
			{
				this._mutex = null;
			}
			try
			{
				global::System.IO.FileStream fileStream = this._fileStream;
				if (fileStream != null)
				{
					fileStream.Close();
				}
			}
			catch (global::System.Exception ex2)
			{
				global::NLog.Common.InternalLogger.Warn(ex2, "Failed to close file: '{0}'", new object[]
				{
					base.FileName
				});
				global::NLog.Common.AsyncHelpers.WaitForDelay(global::System.TimeSpan.FromMilliseconds(1.0));
			}
			finally
			{
				this._fileStream = null;
			}
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00025368 File Offset: 0x00023568
		public override void Flush()
		{
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x0002536A File Offset: 0x0002356A
		public override global::System.DateTime? GetFileCreationTimeUtc()
		{
			return new global::System.DateTime?(base.CreationTimeUtc);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00025377 File Offset: 0x00023577
		public override long? GetFileLength()
		{
			return new long?(this.GetFileCharacteristics().FileLength);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00025389 File Offset: 0x00023589
		private global::NLog.Internal.FileCharacteristics GetFileCharacteristics()
		{
			return this._fileCharacteristicsHelper.GetFileCharacteristics(base.FileName, this._fileStream);
		}

		// Token: 0x04000401 RID: 1025
		public static readonly global::NLog.Internal.FileAppenders.IFileAppenderFactory TheFactory = new global::NLog.Internal.FileAppenders.MutexMultiProcessFileAppender.Factory();

		// Token: 0x04000402 RID: 1026
		private global::System.IO.FileStream _fileStream;

		// Token: 0x04000403 RID: 1027
		private readonly global::NLog.Internal.FileCharacteristicsHelper _fileCharacteristicsHelper;

		// Token: 0x04000404 RID: 1028
		private global::System.Threading.Mutex _mutex;

		// Token: 0x0200022A RID: 554
		private class Factory : global::NLog.Internal.FileAppenders.IFileAppenderFactory
		{
			// Token: 0x0600135B RID: 4955 RVA: 0x000326D8 File Offset: 0x000308D8
			global::NLog.Internal.FileAppenders.BaseFileAppender global::NLog.Internal.FileAppenders.IFileAppenderFactory.Open(string fileName, global::NLog.Internal.FileAppenders.ICreateFileParameters parameters)
			{
				return new global::NLog.Internal.FileAppenders.MutexMultiProcessFileAppender(fileName, parameters);
			}
		}
	}
}
