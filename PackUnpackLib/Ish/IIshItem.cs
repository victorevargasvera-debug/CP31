using System;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x0200001E RID: 30
	public interface IIshItem
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000139 RID: 313
		global::Motorola.Acp.PackUnpack.Ish.IshItemName Name { get; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600013A RID: 314
		int Length { get; }
	}
}
