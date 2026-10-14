using System;
using System.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002D1 RID: 721
	public class HeaderedGridViewFieldLayoutTemplateGenerator : global::Infragistics.Windows.DataPresenter.GridViewFieldLayoutTemplateGenerator
	{
		// Token: 0x06002247 RID: 8775 RVA: 0x00095A3B File Offset: 0x00093C3B
		public HeaderedGridViewFieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::System.Windows.Controls.Orientation orientation) : base(fieldLayout, orientation)
		{
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06002248 RID: 8776 RVA: 0x00095A45 File Offset: 0x00093C45
		public override bool SupportsLabelHeaders
		{
			get
			{
				return true;
			}
		}
	}
}
