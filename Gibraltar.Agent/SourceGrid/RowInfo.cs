using System;
using System.ComponentModel;

namespace SourceGrid
{
	// Token: 0x0200033D RID: 829
	internal class RowInfo
	{
		// Token: 0x060027F9 RID: 10233 RVA: 0x0008B4D0 File Offset: 0x000896D0
		public RowInfo(global::SourceGrid.GridVirtual p_Grid)
		{
			this.m_Grid = p_Grid;
			this.m_Height = this.Grid.DefaultHeight;
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x060027FA RID: 10234 RVA: 0x0008B4F8 File Offset: 0x000896F8
		// (set) Token: 0x060027FB RID: 10235 RVA: 0x0008B500 File Offset: 0x00089700
		public int Height
		{
			get
			{
				return this.m_Height;
			}
			set
			{
				if (value < 0)
				{
					value = 0;
				}
				if (this.m_Height != value)
				{
					this.m_Height = value;
					((global::SourceGrid.RowInfoCollection)this.m_Grid.Rows).OnRowHeightChanged(new global::SourceGrid.RowInfoEventArgs(this));
				}
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x060027FC RID: 10236 RVA: 0x0008B53C File Offset: 0x0008973C
		public int Index
		{
			get
			{
				return ((global::SourceGrid.RowInfoCollection)this.Grid.Rows).IndexOf(this);
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x060027FD RID: 10237 RVA: 0x0008B554 File Offset: 0x00089754
		[global::System.ComponentModel.Browsable(false)]
		public global::SourceGrid.GridVirtual Grid
		{
			get
			{
				return this.m_Grid;
			}
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x060027FE RID: 10238 RVA: 0x0008B55C File Offset: 0x0008975C
		public global::SourceGrid.Range Range
		{
			get
			{
				if (this.m_Grid == null)
				{
					throw new global::SourceGrid.SourceGridException("Invalid Grid object");
				}
				return new global::SourceGrid.Range(this.Index, 0, this.Index, this.Grid.Columns.Count - 1);
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x060027FF RID: 10239 RVA: 0x0008B5A8 File Offset: 0x000897A8
		// (set) Token: 0x06002800 RID: 10240 RVA: 0x0008B5B0 File Offset: 0x000897B0
		[global::System.ComponentModel.Browsable(false)]
		public object Tag
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

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06002801 RID: 10241 RVA: 0x0008B5BC File Offset: 0x000897BC
		// (set) Token: 0x06002802 RID: 10242 RVA: 0x0008B5C4 File Offset: 0x000897C4
		public global::SourceGrid.AutoSizeMode AutoSizeMode
		{
			get
			{
				return this.m_AutoSizeMode;
			}
			set
			{
				this.m_AutoSizeMode = value;
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06002803 RID: 10243 RVA: 0x0008B5D0 File Offset: 0x000897D0
		// (set) Token: 0x06002804 RID: 10244 RVA: 0x0008B5DC File Offset: 0x000897DC
		public bool Visible
		{
			get
			{
				return this.Height > 0;
			}
			set
			{
				if (value && !this.Visible)
				{
					this.Height = this.Grid.DefaultHeight;
					return;
				}
				if (!value && this.Visible)
				{
					this.Height = 0;
				}
			}
		}

		// Token: 0x04000DE6 RID: 3558
		private int m_Height;

		// Token: 0x04000DE7 RID: 3559
		private global::SourceGrid.GridVirtual m_Grid;

		// Token: 0x04000DE8 RID: 3560
		private object m_Tag;

		// Token: 0x04000DE9 RID: 3561
		private global::SourceGrid.AutoSizeMode m_AutoSizeMode = global::SourceGrid.AutoSizeMode.Default;
	}
}
