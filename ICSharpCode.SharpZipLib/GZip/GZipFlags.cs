using System;

namespace ICSharpCode.SharpZipLib.GZip
{
	// Token: 0x02000051 RID: 81
	[global::System.Flags]
	public enum GZipFlags : byte
	{
		// Token: 0x04000266 RID: 614
		FTEXT = 1,
		// Token: 0x04000267 RID: 615
		FHCRC = 2,
		// Token: 0x04000268 RID: 616
		FEXTRA = 4,
		// Token: 0x04000269 RID: 617
		FNAME = 8,
		// Token: 0x0400026A RID: 618
		FCOMMENT = 16
	}
}
