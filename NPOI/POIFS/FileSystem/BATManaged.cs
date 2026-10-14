using System;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002E3 RID: 739
	public interface BATManaged
	{
		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001501 RID: 5377
		int CountBlocks { get; }

		// Token: 0x170003FA RID: 1018
		// (set) Token: 0x06001502 RID: 5378
		int StartBlock { set; }
	}
}
