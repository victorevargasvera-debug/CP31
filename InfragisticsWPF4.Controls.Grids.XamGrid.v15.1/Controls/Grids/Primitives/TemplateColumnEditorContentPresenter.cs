using System;
using System.Windows.Controls;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000266 RID: 614
	public sealed class TemplateColumnEditorContentPresenter : global::System.Windows.Controls.ContentPresenter
	{
		// Token: 0x060013D0 RID: 5072 RVA: 0x0004A9E8 File Offset: 0x00048BE8
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			global::Infragistics.Controls.Grids.CellControl control = this.Control;
			if (control != null)
			{
				control.RefreshEditorBindings();
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060013D1 RID: 5073 RVA: 0x0004AA0B File Offset: 0x00048C0B
		// (set) Token: 0x060013D2 RID: 5074 RVA: 0x0004AA13 File Offset: 0x00048C13
		internal global::Infragistics.Controls.Grids.CellControl Control { get; set; }
	}
}
