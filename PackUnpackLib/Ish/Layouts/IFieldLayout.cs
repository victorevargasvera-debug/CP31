using System;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x0200005C RID: 92
	public interface IFieldLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.IChildLayout<global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaLayout>, global::Motorola.Acp.PackUnpack.Ish.Layouts.ILayout
	{
		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000323 RID: 803
		global::System.TypeCode Type { get; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000324 RID: 804
		int Offset { get; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000325 RID: 805
		int Size { get; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000326 RID: 806
		global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification Justification { get; }
	}
}
