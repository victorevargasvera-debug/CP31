using System;
using SourceGrid.Cells.Controllers;
using SourceGrid.Cells.Views;

namespace SourceGrid.Cells.Virtual
{
	// Token: 0x0200039E RID: 926
	internal abstract class Button : global::SourceGrid.Cells.Virtual.CellVirtual
	{
		// Token: 0x06002B46 RID: 11078 RVA: 0x00091C0C File Offset: 0x0008FE0C
		public Button()
		{
			this.View = global::SourceGrid.Cells.Views.Button.Default;
			base.AddController(global::SourceGrid.Cells.Controllers.MouseInvalidate.Default);
		}
	}
}
