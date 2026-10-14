using System;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish
{
	// Token: 0x02000021 RID: 33
	public interface IIshItemFactory<TItem, TType, TLayout> where TItem : global::Motorola.Acp.PackUnpack.Ish.IshItem where TType : global::Motorola.Acp.PackUnpack.Ish.IshType where TLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout
	{
		// Token: 0x06000140 RID: 320
		global::Motorola.Acp.PackUnpack.Ish.IshItem CreateItem(global::Motorola.Acp.PackUnpack.Ish.IshType type, int id, global::Motorola.Acp.PackUnpack.Ish.Layouts.StructureLayout layout, int length, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader);

		// Token: 0x06000141 RID: 321
		TItem CreateItem(TType ishType, int id, TLayout layout, int length, global::Motorola.Acp.PackUnpack.Ish.ByteBufferStreamReader reader);
	}
}
