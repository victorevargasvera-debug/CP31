using System;

namespace NLog.Internal.FileAppenders
{
	// Token: 0x02000143 RID: 323
	internal class NullAppender : global::NLog.Internal.FileAppenders.BaseFileAppender
	{
		// Token: 0x06000E85 RID: 3717 RVA: 0x000253AE File Offset: 0x000235AE
		public NullAppender(string fileName, global::NLog.Internal.FileAppenders.ICreateFileParameters createParameters) : base(fileName, createParameters)
		{
		}

		// Token: 0x06000E86 RID: 3718 RVA: 0x000253B8 File Offset: 0x000235B8
		public override void Close()
		{
		}

		// Token: 0x06000E87 RID: 3719 RVA: 0x000253BA File Offset: 0x000235BA
		public override void Flush()
		{
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x000253BC File Offset: 0x000235BC
		public override global::System.DateTime? GetFileCreationTimeUtc()
		{
			return new global::System.DateTime?(global::System.DateTime.UtcNow);
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x000253C8 File Offset: 0x000235C8
		public override long? GetFileLength()
		{
			return new long?(0L);
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x000253D1 File Offset: 0x000235D1
		public override void Write(byte[] bytes, int offset, int count)
		{
		}

		// Token: 0x04000405 RID: 1029
		public static readonly global::NLog.Internal.FileAppenders.IFileAppenderFactory TheFactory = new global::NLog.Internal.FileAppenders.NullAppender.Factory();

		// Token: 0x0200022B RID: 555
		private class Factory : global::NLog.Internal.FileAppenders.IFileAppenderFactory
		{
			// Token: 0x0600135D RID: 4957 RVA: 0x000326E9 File Offset: 0x000308E9
			global::NLog.Internal.FileAppenders.BaseFileAppender global::NLog.Internal.FileAppenders.IFileAppenderFactory.Open(string fileName, global::NLog.Internal.FileAppenders.ICreateFileParameters parameters)
			{
				return new global::NLog.Internal.FileAppenders.NullAppender(fileName, parameters);
			}
		}
	}
}
