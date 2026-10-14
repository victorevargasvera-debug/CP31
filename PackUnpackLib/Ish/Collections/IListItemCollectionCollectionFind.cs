using System;

namespace Motorola.Acp.PackUnpack.Ish.Collections
{
	// Token: 0x020000AD RID: 173
	public interface IListItemCollectionCollectionFind : global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection>
	{
		// Token: 0x170001C4 RID: 452
		global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection this[int index]
		{
			get;
		}

		// Token: 0x060006D1 RID: 1745
		global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollection Find(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType ishType, int id);

		// Token: 0x060006D2 RID: 1746
		global::Motorola.Acp.PackUnpack.Ish.Collections.ListItemCollectionCollection Find(global::Motorola.Acp.PackUnpack.Ish.ListHeaderType ishType);
	}
}
