using System;
using System.IO.Compression;

namespace SpecialFeatures.Comms.Util
{
	// Token: 0x0200017B RID: 379
	public interface IIOCompressionHelper
	{
		// Token: 0x060012C6 RID: 4806
		global::System.IO.Compression.ZipArchive OpenRead(string path);
	}
}
