using System;
using System.IO;
using System.Security;
using NLog.Common;

namespace NLog.Internal.FileAppenders
{
	// Token: 0x0200013E RID: 318
	[global::System.Security.SecuritySafeCritical]
	internal class CountingSingleProcessFileAppender : global::NLog.Internal.FileAppenders.BaseFileAppender
	{
		// Token: 0x06000E4F RID: 3663 RVA: 0x000246E8 File Offset: 0x000228E8
		public CountingSingleProcessFileAppender(string fileName, global::NLog.Internal.FileAppenders.ICreateFileParameters parameters) : base(fileName, parameters)
		{
			global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(fileName);
			this._currentFileLength = (fileInfo.Exists ? fileInfo.Length : 0L);
			this._file = base.CreateFileStream(false);
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x0002472C File Offset: 0x0002292C
		public override void Close()
		{
			if (this._file != null)
			{
				global::NLog.Common.InternalLogger.Trace<string>("Closing '{0}'", base.FileName);
				try
				{
					this._file.Close();
				}
				catch (global::System.Exception ex)
				{
					global::NLog.Common.InternalLogger.Warn(ex, "Failed to close file: '{0}'", new object[]
					{
						base.FileName
					});
					global::NLog.Common.AsyncHelpers.WaitForDelay(global::System.TimeSpan.FromMilliseconds(1.0));
				}
				finally
				{
					this._file = null;
				}
			}
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x000247B0 File Offset: 0x000229B0
		public override void Flush()
		{
			if (this._file == null)
			{
				return;
			}
			this._file.Flush();
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x000247C6 File Offset: 0x000229C6
		public override global::System.DateTime? GetFileCreationTimeUtc()
		{
			return new global::System.DateTime?(base.CreationTimeUtc);
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x000247D3 File Offset: 0x000229D3
		public override long? GetFileLength()
		{
			return new long?(this._currentFileLength);
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x000247E0 File Offset: 0x000229E0
		public override void Write(byte[] bytes, int offset, int count)
		{
			if (this._file == null)
			{
				return;
			}
			this._currentFileLength += (long)count;
			this._file.Write(bytes, offset, count);
		}

		// Token: 0x040003F4 RID: 1012
		public static readonly global::NLog.Internal.FileAppenders.IFileAppenderFactory TheFactory = new global::NLog.Internal.FileAppenders.CountingSingleProcessFileAppender.Factory();

		// Token: 0x040003F5 RID: 1013
		private global::System.IO.FileStream _file;

		// Token: 0x040003F6 RID: 1014
		private long _currentFileLength;

		// Token: 0x02000227 RID: 551
		private class Factory : global::NLog.Internal.FileAppenders.IFileAppenderFactory
		{
			// Token: 0x06001351 RID: 4945 RVA: 0x00032679 File Offset: 0x00030879
			global::NLog.Internal.FileAppenders.BaseFileAppender global::NLog.Internal.FileAppenders.IFileAppenderFactory.Open(string fileName, global::NLog.Internal.FileAppenders.ICreateFileParameters parameters)
			{
				return new global::NLog.Internal.FileAppenders.CountingSingleProcessFileAppender(fileName, parameters);
			}
		}
	}
}
