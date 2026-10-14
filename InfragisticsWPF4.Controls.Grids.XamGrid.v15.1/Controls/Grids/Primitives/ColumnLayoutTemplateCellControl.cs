using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001F5 RID: 501
	public class ColumnLayoutTemplateCellControl : global::Infragistics.Controls.Grids.CellControl
	{
		// Token: 0x06000E16 RID: 3606 RVA: 0x00034980 File Offset: 0x00032B80
		protected override void AttachContent()
		{
			global::System.Windows.DataTemplate internalTemplate = base.Cell.Column.ColumnLayout.InternalTemplate;
			if (internalTemplate != null)
			{
				base.Content = base.Cell.Row.Data;
				base.ContentTemplate = internalTemplate;
			}
		}

		// Token: 0x06000E17 RID: 3607 RVA: 0x000349C3 File Offset: 0x00032BC3
		protected override void ReleaseContent()
		{
			base.ReleaseContent();
			base.Content = null;
			base.ContentTemplate = null;
		}
	}
}
