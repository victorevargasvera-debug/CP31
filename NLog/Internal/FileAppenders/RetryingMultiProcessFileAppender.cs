using System;
using System.IO;
using System.Security;

namespace NLog.Internal.FileAppenders
{
	// Token: 0x02000144 RID: 324
	[global::System.Security.SecuritySafeCritical]
	internal class RetryingMultiProcessFileAppender : global::NLog.Internal.FileAppenders.BaseMutexFileAppender
	{
		// Token: 0x06000E8C RID: 3724 RVA: 0x000253DF File Offset: 0x000235DF
		public RetryingMultiProcessFileAppender(string fileName, global::NLog.Internal.FileAppenders.ICreateFileParameters parameters) : base(fileName, parameters)
		{
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x000253EC File Offset: 0x000235EC
		public override void Write(byte[] bytes, int offset, int count)
		{
			using (global::System.IO.FileStream fileStream = base.CreateFileStream(false))
			{
				fileStream.Write(bytes, offset, count);
			}
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00025428 File Offset: 0x00023628
		public override void Flush()
		{
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x0002542A File Offset: 0x0002362A
		public override void Close()
		{
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x0002542C File Offset: 0x0002362C
		public override global::System.DateTime? GetFileCreationTimeUtc()
		{
			global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(base.FileName);
			if (fileInfo.Exists)
			{
				return new global::System.DateTime?(fileInfo.GetCreationTimeUtc());
			}
			return null;
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00025464 File Offset: 0x00023664
		public override long? GetFileLength()
		{
			global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(base.FileName);
			if (fileInfo.Exists)
			{
				return new long?(fileInfo.Length);
			}
			return null;
		}

		// Token: 0x04000406 RID: 1030
		public static readonly global::NLog.Internal.FileAppenders.IFileAppenderFactory TheFactory = new global::NLog.Internal.FileAppenders.RetryingMultiProcessFileAppender.Factory();

		// Token: 0x0200022C RID: 556
		private class Factory : global::NLog.Internal.FileAppenders.IFileAppenderFactory
		{
			// Token: 0x0600135F RID: 4959 RVA: 0x000326FA File Offset: 0x000308FA
			global::NLog.Internal.FileAppenders.BaseFileAppender global::NLog.Internal.FileAppenders.IFileAppenderFactory.Open(string fileName, global::NLog.Internal.FileAppenders.ICreateFileParameters parameters)
			{
				return new global::NLog.Internal.FileAppenders.RetryingMultiProcessFileAppender(fileName, parameters);
			}
		}
	}
}
