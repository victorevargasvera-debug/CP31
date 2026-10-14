using System;
using System.Windows.Forms;

namespace SourceGrid.Cells
{
	// Token: 0x0200039D RID: 925
	[global::System.Obsolete("I will soon remove this class. If you need to add a user control to the grid I suggest to manually add or remove it using the Grid.LinkedControls collection.")]
	internal class CellControl : global::SourceGrid.Cells.Cell
	{
		// Token: 0x06002B41 RID: 11073 RVA: 0x00091AF8 File Offset: 0x0008FCF8
		public CellControl(global::System.Windows.Forms.Control control) : base(null)
		{
			this.mControl = control;
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x00091B24 File Offset: 0x0008FD24
		public CellControl(global::System.Windows.Forms.Control control, global::SourceGrid.LinkedControlScrollMode scrollMode, bool useCellBorder) : this(control)
		{
			this.mControl = control;
			this.mScrollMode = scrollMode;
			this.mUseCellBorder = useCellBorder;
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x06002B43 RID: 11075 RVA: 0x00091B44 File Offset: 0x0008FD44
		public global::System.Windows.Forms.Control Control
		{
			get
			{
				return this.mControl;
			}
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x00091B4C File Offset: 0x0008FD4C
		public override void BindToGrid(global::SourceGrid.Grid p_grid, global::SourceGrid.Position p_Position)
		{
			base.BindToGrid(p_grid, p_Position);
			global::SourceGrid.LinkedControlValue linkedControlValue = new global::SourceGrid.LinkedControlValue(this.mControl, base.Range.Start);
			linkedControlValue.ScrollMode = this.mScrollMode;
			linkedControlValue.UseCellBorder = this.mUseCellBorder;
			base.Grid.LinkedControls.Add(linkedControlValue);
			base.Grid.ArrangeLinkedControls();
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x00091BB4 File Offset: 0x0008FDB4
		public override void UnBindToGrid()
		{
			if (base.Grid.LinkedControls.GetByControl(this.mControl) != null)
			{
				base.Grid.LinkedControls.Remove(base.Grid.LinkedControls.GetByControl(this.mControl));
			}
			base.UnBindToGrid();
		}

		// Token: 0x04000E8C RID: 3724
		private global::System.Windows.Forms.Control mControl;

		// Token: 0x04000E8D RID: 3725
		private global::SourceGrid.LinkedControlScrollMode mScrollMode = global::SourceGrid.LinkedControlScrollMode.BasedOnPosition;

		// Token: 0x04000E8E RID: 3726
		private bool mUseCellBorder = true;

		// Token: 0x04000E8F RID: 3727
		private global::System.Guid mControlGuid = global::System.Guid.NewGuid();
	}
}
