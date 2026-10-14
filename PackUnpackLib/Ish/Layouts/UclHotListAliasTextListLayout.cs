using System;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x02000070 RID: 112
	public class UclHotListAliasTextListLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.ListLayout
	{
		// Token: 0x0600035E RID: 862 RVA: 0x00045028 File Offset: 0x00043228
		public UclHotListAliasTextListLayout(string name, global::Motorola.Acp.PackUnpack.Ish.UclHotListAliasTextListHeaderType headerType, global::Motorola.Acp.PackUnpack.Ish.UclHotListAliasTextListListletType listletType, int listCapacity, int headerCapacity, int listletCapacity, int headerDataAreaSize, int listEntrySize) : base(name, headerType, listletType, listCapacity, headerCapacity, listletCapacity, headerDataAreaSize, listEntrySize)
		{
		}
	}
}
