using System;
using System.Drawing;
using SourceGrid.Cells.Editors;
using SourceGrid.Cells.Models;
using SourceGrid.Cells.Virtual;

namespace SourceGrid.Cells
{
	// Token: 0x02000358 RID: 856
	internal class Cell : global::SourceGrid.Cells.Virtual.CellVirtual, global::SourceGrid.Cells.ICell, global::SourceGrid.Cells.ICellVirtual
	{
		// Token: 0x060029EF RID: 10735 RVA: 0x0008F670 File Offset: 0x0008D870
		public Cell() : this(null)
		{
		}

		// Token: 0x060029F0 RID: 10736 RVA: 0x0008F67C File Offset: 0x0008D87C
		public Cell(object cellValue)
		{
			base.Model = new global::SourceGrid.Cells.Models.ModelContainer();
			base.Model.ValueModel = new global::SourceGrid.Cells.Models.ValueModel();
			base.Model.AddModel(new global::SourceGrid.Cells.Models.ToolTip());
			base.Model.AddModel(new global::SourceGrid.Cells.Models.Image());
			this.Value = cellValue;
		}

		// Token: 0x060029F1 RID: 10737 RVA: 0x0008F6E4 File Offset: 0x0008D8E4
		public Cell(object cellValue, global::System.Type pType) : this(cellValue)
		{
			base.Editor = global::SourceGrid.Cells.Editors.Factory.Create(pType);
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x0008F6FC File Offset: 0x0008D8FC
		public Cell(object cellValue, global::SourceGrid.Cells.Editors.EditorBase pEditor) : this(cellValue)
		{
			base.Editor = pEditor;
		}

		// Token: 0x060029F3 RID: 10739 RVA: 0x0008F70C File Offset: 0x0008D90C
		public virtual void BindToGrid(global::SourceGrid.Grid p_grid, global::SourceGrid.Position p_Position)
		{
			this.mGrid = p_grid;
			this.mRow = this.Grid.Rows[p_Position.Row];
			this.mColumn = this.Grid.Columns[p_Position.Column];
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x0008F760 File Offset: 0x0008D960
		public virtual void UnBindToGrid()
		{
			this.mGrid = null;
			this.mColumn = null;
			this.mRow = null;
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x060029F5 RID: 10741 RVA: 0x0008F778 File Offset: 0x0008D978
		public global::SourceGrid.Grid Grid
		{
			get
			{
				return this.mGrid;
			}
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x060029F6 RID: 10742 RVA: 0x0008F780 File Offset: 0x0008D980
		public global::SourceGrid.Grid.GridColumn Column
		{
			get
			{
				return this.mColumn;
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x060029F7 RID: 10743 RVA: 0x0008F788 File Offset: 0x0008D988
		public global::SourceGrid.Grid.GridRow Row
		{
			get
			{
				return this.mRow;
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x060029F8 RID: 10744 RVA: 0x0008F790 File Offset: 0x0008D990
		public global::SourceGrid.Range Range
		{
			get
			{
				if (this.Grid == null)
				{
					return global::SourceGrid.Range.Empty;
				}
				int index = this.Column.Index;
				int index2 = this.Row.Index;
				return new global::SourceGrid.Range(index2, index, index2 + this.RowSpan - 1, index + this.ColumnSpan - 1);
			}
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x0008F7E8 File Offset: 0x0008D9E8
		protected global::SourceGrid.CellContext GetContext()
		{
			return new global::SourceGrid.CellContext(this.Grid, this.Range.Start, this);
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x060029FA RID: 10746 RVA: 0x0008F814 File Offset: 0x0008DA14
		public virtual string DisplayText
		{
			get
			{
				return this.GetContext().DisplayText;
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x060029FB RID: 10747 RVA: 0x0008F834 File Offset: 0x0008DA34
		// (set) Token: 0x060029FC RID: 10748 RVA: 0x0008F85C File Offset: 0x0008DA5C
		public virtual object Value
		{
			get
			{
				return base.Model.ValueModel.GetValue(this.GetContext());
			}
			set
			{
				base.Model.ValueModel.SetValue(this.GetContext(), value);
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x060029FD RID: 10749 RVA: 0x0008F884 File Offset: 0x0008DA84
		// (set) Token: 0x060029FE RID: 10750 RVA: 0x0008F88C File Offset: 0x0008DA8C
		public virtual object Tag
		{
			get
			{
				return this.m_Tag;
			}
			set
			{
				this.m_Tag = value;
			}
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x0008F898 File Offset: 0x0008DA98
		public override string ToString()
		{
			return this.DisplayText;
		}

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06002A00 RID: 10752 RVA: 0x0008F8A0 File Offset: 0x0008DAA0
		// (set) Token: 0x06002A01 RID: 10753 RVA: 0x0008F8A8 File Offset: 0x0008DAA8
		public int ColumnSpan
		{
			get
			{
				return this.mColumnSpan;
			}
			set
			{
				if (value < 1)
				{
					throw new global::System.ArgumentOutOfRangeException("ColumnSpan");
				}
				if (value > global::SourceGrid.Grid.MaxSpan)
				{
					throw new global::SourceGrid.SourceGridException("ColumnSpan must be smaller than Grid.MaxSpan property. Increase the property or use a smaller column span.");
				}
				this.mColumnSpan = value;
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06002A02 RID: 10754 RVA: 0x0008F8DC File Offset: 0x0008DADC
		// (set) Token: 0x06002A03 RID: 10755 RVA: 0x0008F8E4 File Offset: 0x0008DAE4
		public int RowSpan
		{
			get
			{
				return this.mRowSpan;
			}
			set
			{
				if (value < 1)
				{
					throw new global::System.ArgumentOutOfRangeException("RowSpan");
				}
				if (value > global::SourceGrid.Grid.MaxSpan)
				{
					throw new global::SourceGrid.SourceGridException("RowSpan must be smaller than Grid.MaxSpan property. Increase the property or use a smaller row span.");
				}
				this.mRowSpan = value;
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x06002A04 RID: 10756 RVA: 0x0008F918 File Offset: 0x0008DB18
		private global::SourceGrid.Cells.Models.ToolTip ToolTipModel
		{
			get
			{
				return (global::SourceGrid.Cells.Models.ToolTip)base.Model.FindModel(typeof(global::SourceGrid.Cells.Models.ToolTip));
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x06002A05 RID: 10757 RVA: 0x0008F934 File Offset: 0x0008DB34
		// (set) Token: 0x06002A06 RID: 10758 RVA: 0x0008F944 File Offset: 0x0008DB44
		public string ToolTipText
		{
			get
			{
				return this.ToolTipModel.ToolTipText;
			}
			set
			{
				this.ToolTipModel.ToolTipText = value;
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06002A07 RID: 10759 RVA: 0x0008F954 File Offset: 0x0008DB54
		private global::SourceGrid.Cells.Models.Image ImageModel
		{
			get
			{
				return (global::SourceGrid.Cells.Models.Image)base.Model.FindModel(typeof(global::SourceGrid.Cells.Models.Image));
			}
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06002A08 RID: 10760 RVA: 0x0008F970 File Offset: 0x0008DB70
		// (set) Token: 0x06002A09 RID: 10761 RVA: 0x0008F980 File Offset: 0x0008DB80
		public global::System.Drawing.Image Image
		{
			get
			{
				return this.ImageModel.ImageValue;
			}
			set
			{
				this.ImageModel.ImageValue = value;
			}
		}

		// Token: 0x04000E37 RID: 3639
		private global::SourceGrid.Grid mGrid;

		// Token: 0x04000E38 RID: 3640
		private global::SourceGrid.Grid.GridColumn mColumn;

		// Token: 0x04000E39 RID: 3641
		private global::SourceGrid.Grid.GridRow mRow;

		// Token: 0x04000E3A RID: 3642
		private object m_Tag;

		// Token: 0x04000E3B RID: 3643
		private int mColumnSpan = 1;

		// Token: 0x04000E3C RID: 3644
		private int mRowSpan = 1;
	}
}
