using System;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x02000058 RID: 88
	public interface IChildLayout<T> : global::Motorola.Acp.PackUnpack.Ish.Layouts.ILayout
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600031A RID: 794
		T Parent { get; }
	}
}
