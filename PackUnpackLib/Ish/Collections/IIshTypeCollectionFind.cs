using System;

namespace Motorola.Acp.PackUnpack.Ish.Collections
{
	// Token: 0x020000A6 RID: 166
	public interface IIshTypeCollectionFind<T> : global::Motorola.Acp.PackUnpack.Ish.Collections.ICollectionFind<T> where T : global::Motorola.Acp.PackUnpack.Ish.IshType
	{
		// Token: 0x0600067E RID: 1662
		T Find(int value);
	}
}
