using System;
using System.IO;
using System.Security;
using NLog.Common;

namespace NLog.Internal.FileAppenders
{
	// Token: 0x02000145 RID: 325
	[global::System.Security.SecuritySafeCritical]
	internal class SingleProcessFileAppender : global::NLog.Internal.FileAppenders.BaseFileAppender
	{
		// Token: 0x06000E93 RID: 3731 RVA: 0x000254A6 File Offset: 0x000236A6
		public SingleProcessFileAppender(string fileName, global::NLog.Internal.FileAppenders.ICreateFileParameters parameters) : base(fileName, parameters)
		{
			this._file = base.CreateFileStream(false);
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x000254BD File Offset: 0x000236BD
		public override void Write(byte[] bytes, int offset, int count)
		{
			if (this._file == null)
			{
				return;
			}
			this._file.Write(bytes, offset, count);
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x000254D6 File Offset: 0x000236D6
		public override void Flush()
		{
			if (this._file == null)
			{
				return;
			}
			this._file.Flush();
		}

		// Token: 0x06000E96 RID: 3734 RVA: 0x000254EC File Offset: 0x000236EC
		public override void Close()
		{
			if (this._file == null)
			{
				return;
			}
			global::NLog.Common.InternalLogger.Trace<string>("Closing '{0}'", base.FileName);
			try
			{
				this._file.Close();
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Warn(ex, "Failed to close file '{0}'", new object[]
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

		// Token: 0x06000E97 RID: 3735 RVA: 0x00025574 File Offset: 0x00023774
		public override global::System.DateTime? GetFileCreationTimeUtc()
		{
			return new global::System.DateTime?(base.CreationTimeUtc);
		}

		// Token: 0x06000E98 RID: 3736 RVA: 0x00025584 File Offset: 0x00023784
		public override long? GetFileLength()
		{
			if (this._file == null)
			{
				return null;
			}
			return new long?(this._file.Length);
		}

		// Token: 0x04000407 RID: 1031
		public static readonly global::NLog.Internal.FileAppenders.IFileAppenderFactory TheFactory = new global::NLog.Internal.FileAppenders.SingleProcessFileAppender.Factory();

		// Token: 0x04000408 RID: 1032
		private global::System.IO.FileStream _file;

		// Token: 0x0200022D RID: 557
		private class Factory : global::NLog.Internal.FileAppenders.IFileAppenderFactory
		{
			// Token: 0x06001361 RID: 4961 RVA: 0x0003270B File Offset: 0x0003090B
			global::NLog.Internal.FileAppenders.BaseFileAppender global::NLog.Internal.FileAppenders.IFileAppenderFactory.Open(string fileName, global::NLog.Internal.FileAppenders.ICreateFileParameters parameters)
			{
				return new global::NLog.Internal.FileAppenders.SingleProcessFileAppender(fileName, parameters);
			}
		}
	}
}
