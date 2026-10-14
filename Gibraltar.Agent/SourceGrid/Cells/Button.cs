using System;
using SourceGrid.Cells.Controllers;
using SourceGrid.Cells.Views;

namespace SourceGrid.Cells
{
	// Token: 0x0200039F RID: 927
	internal class Button : global::SourceGrid.Cells.Cell
	{
		// Token: 0x06002B47 RID: 11079 RVA: 0x00091C2C File Offset: 0x0008FE2C
		public Button(object p_Value) : base(p_Value)
		{
			this.View = global::SourceGrid.Cells.Views.Button.Default;
			base.AddController(global::SourceGrid.Cells.Controllers.MouseInvalidate.Default);
		}
	}
}
