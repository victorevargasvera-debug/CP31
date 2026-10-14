using System;
using DevAge.Drawing;
using DevAge.Drawing.VisualElements;

namespace SourceGrid.Cells.Views
{
	// Token: 0x0200034F RID: 847
	[global::System.Serializable]
	internal class Button : global::SourceGrid.Cells.Views.Cell
	{
		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x0600296E RID: 10606 RVA: 0x0008E180 File Offset: 0x0008C380
		public new static global::SourceGrid.Cells.Views.Button Default
		{
			get
			{
				if (global::SourceGrid.Cells.Views.Button.t_Default == null)
				{
					global::SourceGrid.Cells.Views.Button.t_Default = new global::SourceGrid.Cells.Views.Button();
				}
				return global::SourceGrid.Cells.Views.Button.t_Default;
			}
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x0008E19C File Offset: 0x0008C39C
		public Button()
		{
			this.Background = new global::DevAge.Drawing.VisualElements.ButtonThemed();
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x0008E1B0 File Offset: 0x0008C3B0
		public Button(global::SourceGrid.Cells.Views.Button p_Source) : base(p_Source)
		{
			this.Background = (global::DevAge.Drawing.VisualElements.IButton)p_Source.Background.Clone();
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x0008E1E0 File Offset: 0x0008C3E0
		public override object Clone()
		{
			return new global::SourceGrid.Cells.Views.Button(this);
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x06002972 RID: 10610 RVA: 0x0008E1E8 File Offset: 0x0008C3E8
		// (set) Token: 0x06002973 RID: 10611 RVA: 0x0008E1F8 File Offset: 0x0008C3F8
		public new global::DevAge.Drawing.VisualElements.IButton Background
		{
			get
			{
				return (global::DevAge.Drawing.VisualElements.IButton)base.Background;
			}
			set
			{
				base.Background = value;
			}
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x0008E204 File Offset: 0x0008C404
		protected override void PrepareView(global::SourceGrid.CellContext context)
		{
			base.PrepareView(context);
			if (context.CellRange.Contains(context.Grid.MouseDownPosition))
			{
				this.Background.Style = global::DevAge.Drawing.ButtonStyle.Pressed;
				return;
			}
			if (context.CellRange.Contains(context.Grid.MouseCellPosition))
			{
				this.Background.Style = global::DevAge.Drawing.ButtonStyle.Hot;
				return;
			}
			if (context.CellRange.Contains(context.Grid.Selection.ActivePosition))
			{
				this.Background.Style = global::DevAge.Drawing.ButtonStyle.Focus;
				return;
			}
			this.Background.Style = global::DevAge.Drawing.ButtonStyle.Normal;
		}

		// Token: 0x04000E30 RID: 3632
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Views.Button t_Default;
	}
}
