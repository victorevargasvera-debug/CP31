using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000028 RID: 40
	public abstract class BaseArchiveStorage : global::ICSharpCode.SharpZipLib.Zip.IArchiveStorage
	{
		// Token: 0x0600018C RID: 396 RVA: 0x00007FED File Offset: 0x000061ED
		protected BaseArchiveStorage(global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode updateMode)
		{
			this.updateMode_ = updateMode;
		}

		// Token: 0x0600018D RID: 397
		public abstract global::System.IO.Stream GetTemporaryOutput();

		// Token: 0x0600018E RID: 398
		public abstract global::System.IO.Stream ConvertTemporaryToFinal();

		// Token: 0x0600018F RID: 399
		public abstract global::System.IO.Stream MakeTemporaryCopy(global::System.IO.Stream stream);

		// Token: 0x06000190 RID: 400
		public abstract global::System.IO.Stream OpenForDirectUpdate(global::System.IO.Stream stream);

		// Token: 0x06000191 RID: 401
		public abstract void Dispose();

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00007FFC File Offset: 0x000061FC
		public global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode UpdateMode
		{
			get
			{
				return this.updateMode_;
			}
		}

		// Token: 0x040000E4 RID: 228
		private readonly global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode updateMode_;
	}
}
