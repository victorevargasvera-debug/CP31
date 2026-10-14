using System;
using System.Collections.Generic;

namespace Motorola.Acp.PackUnpack.Ish.Collections
{
	// Token: 0x0200009B RID: 155
	public interface IIshItemCollectionFind<T, U> : global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<T> where T : global::Motorola.Acp.PackUnpack.Ish.IshItem where U : global::Motorola.Acp.PackUnpack.Ish.IshType
	{
		// Token: 0x060005DC RID: 1500
		T Find(int type, int id);

		// Token: 0x060005DD RID: 1501
		T Find(global::Motorola.Acp.PackUnpack.Ish.IshItemName name);

		// Token: 0x060005DE RID: 1502
		T Find(U ishType, int id);

		// Token: 0x060005DF RID: 1503
		global::System.Collections.Generic.ICollection<T> FindAll(U ishType);
	}
}
