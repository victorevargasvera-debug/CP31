using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000027 RID: 39
	public interface IArchiveStorage
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000186 RID: 390
		global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode UpdateMode { get; }

		// Token: 0x06000187 RID: 391
		global::System.IO.Stream GetTemporaryOutput();

		// Token: 0x06000188 RID: 392
		global::System.IO.Stream ConvertTemporaryToFinal();

		// Token: 0x06000189 RID: 393
		global::System.IO.Stream MakeTemporaryCopy(global::System.IO.Stream stream);

		// Token: 0x0600018A RID: 394
		global::System.IO.Stream OpenForDirectUpdate(global::System.IO.Stream stream);

		// Token: 0x0600018B RID: 395
		void Dispose();
	}
}
