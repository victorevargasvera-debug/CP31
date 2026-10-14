using System;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish.Collections
{
	// Token: 0x020000B6 RID: 182
	public interface IStructureLayoutCollectionFind<T, V> : global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<T> where T : global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout where V : global::Motorola.Acp.PackUnpack.Ish.IshType
	{
		// Token: 0x0600071A RID: 1818
		T Find(int type);

		// Token: 0x0600071B RID: 1819
		T Find(V ishType);
	}
}
