using System;
using System.IO;

namespace SevenZip
{
	// Token: 0x02000007 RID: 7
	public interface ICoder
	{
		// Token: 0x0600000F RID: 15
		void Code(global::System.IO.Stream inStream, global::System.IO.Stream outStream, long inSize, long outSize, global::SevenZip.ICodeProgress progress);
	}
}
