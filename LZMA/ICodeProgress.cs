using System;

namespace SevenZip
{
	// Token: 0x02000006 RID: 6
	public interface ICodeProgress
	{
		// Token: 0x0600000E RID: 14
		void SetProgress(long inSize, long outSize);
	}
}
