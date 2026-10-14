using System;

namespace Motorola.Acp.PackUnpack.Ish.Layouts
{
	// Token: 0x0200005E RID: 94
	public abstract class ReferenceFieldLayout : global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldLayout
	{
		// Token: 0x0600032B RID: 811 RVA: 0x000432CC File Offset: 0x000414CC
		protected ReferenceFieldLayout(string name, global::System.TypeCode typeCode, int offset) : base(name, typeCode, offset, global::Motorola.Acp.PackUnpack.Ish.Layouts.FieldJustification.Right)
		{
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600032C RID: 812
		public abstract global::Motorola.Acp.PackUnpack.Ish.IshType ReferencedIshType { get; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600032D RID: 813
		public abstract global::Motorola.Acp.PackUnpack.Ish.Layouts.ReferenceRelationship Relationship { get; }
	}
}
