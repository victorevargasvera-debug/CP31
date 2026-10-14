using System;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000044 RID: 68
	internal class SelectionStrategyContiguous : global::Infragistics.Controls.Primitives.SelectionStrategyExtended
	{
		// Token: 0x060002FA RID: 762 RVA: 0x0000EB1B File Offset: 0x0000CD1B
		public SelectionStrategyContiguous(global::Infragistics.Controls.Primitives.ISelectionHost selectionHost) : base(selectionHost)
		{
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002FB RID: 763 RVA: 0x0000EB24 File Offset: 0x0000CD24
		public override bool IsDiscontiguousAllowed
		{
			get
			{
				return false;
			}
		}
	}
}
