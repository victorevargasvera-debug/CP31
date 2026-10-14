using System;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x02000031 RID: 49
	public interface IListNode
	{
		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001A6 RID: 422
		global::Motorola.Acp.PackUnpack.Ish.IshItemName Next { get; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001A7 RID: 423
		global::Motorola.Acp.PackUnpack.Ish.DataArea Entries { get; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001A8 RID: 424
		int Count { get; }
	}
}
