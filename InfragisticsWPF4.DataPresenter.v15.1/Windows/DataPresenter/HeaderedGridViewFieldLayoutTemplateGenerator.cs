using System;
using System.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000310 RID: 784
	public class HeaderedGridViewFieldLayoutTemplateGenerator : global::Infragistics.Windows.DataPresenter.GridViewFieldLayoutTemplateGenerator
	{
		// Token: 0x060025DB RID: 9691 RVA: 0x000A8E9B File Offset: 0x000A709B
		public HeaderedGridViewFieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::System.Windows.Controls.Orientation orientation) : base(fieldLayout, orientation)
		{
		}

		// Token: 0x17000B4F RID: 2895
		// (get) Token: 0x060025DC RID: 9692 RVA: 0x000A8EA5 File Offset: 0x000A70A5
		public override bool SupportsLabelHeaders
		{
			get
			{
				return true;
			}
		}
	}
}
