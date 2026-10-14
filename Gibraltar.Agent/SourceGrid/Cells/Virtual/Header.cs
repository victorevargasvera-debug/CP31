using System;
using SourceGrid.Cells.Controllers;
using SourceGrid.Cells.Views;

namespace SourceGrid.Cells.Virtual
{
	// Token: 0x020003C1 RID: 961
	internal abstract class Header : global::SourceGrid.Cells.Virtual.CellVirtual
	{
		// Token: 0x06002BF9 RID: 11257 RVA: 0x00093954 File Offset: 0x00091B54
		public Header()
		{
			this.View = global::SourceGrid.Cells.Views.Header.Default;
			base.AddController(global::SourceGrid.Cells.Controllers.Unselectable.Default);
			base.AddController(global::SourceGrid.Cells.Controllers.MouseInvalidate.Default);
			this.ResizeEnabled = true;
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x06002BFA RID: 11258 RVA: 0x00093994 File Offset: 0x00091B94
		// (set) Token: 0x06002BFB RID: 11259 RVA: 0x000939B0 File Offset: 0x00091BB0
		public bool ResizeEnabled
		{
			get
			{
				return base.FindController(typeof(global::SourceGrid.Cells.Controllers.Resizable)) == global::SourceGrid.Cells.Controllers.Resizable.ResizeBoth;
			}
			set
			{
				if (value == this.ResizeEnabled)
				{
					return;
				}
				if (value)
				{
					base.AddController(global::SourceGrid.Cells.Controllers.Resizable.ResizeBoth);
					return;
				}
				base.RemoveController(global::SourceGrid.Cells.Controllers.Resizable.ResizeBoth);
			}
		}
	}
}
