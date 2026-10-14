using System;

namespace NLog.Targets
{
	// Token: 0x0200003C RID: 60
	public interface IFileCompressor
	{
		// Token: 0x06000612 RID: 1554
		void CompressFile(string fileName, string archiveFileName);
	}
}
