using System;
using System.ComponentModel;

namespace SourceGrid
{
	// Token: 0x0200033A RID: 826
	internal class ColumnInfo
	{
		// Token: 0x060027B0 RID: 10160 RVA: 0x0008A76C File Offset: 0x0008896C
		public ColumnInfo(global::SourceGrid.GridVirtual p_Grid)
		{
			this.m_Grid = p_Grid;
			this.m_Width = this.Grid.DefaultWidth;
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x060027B1 RID: 10161 RVA: 0x0008A794 File Offset: 0x00088994
		// (set) Token: 0x060027B2 RID: 10162 RVA: 0x0008A79C File Offset: 0x0008899C
		public int Width
		{
			get
			{
				return this.m_Width;
			}
			set
			{
				if (value < 0)
				{
					value = 0;
				}
				if (this.m_Width != value)
				{
					this.m_Width = value;
					((global::SourceGrid.ColumnInfoCollection)this.Grid.Columns).OnColumnWidthChanged(new global::SourceGrid.ColumnInfoEventArgs(this));
				}
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x060027B3 RID: 10163 RVA: 0x0008A7D8 File Offset: 0x000889D8
		public int Index
		{
			get
			{
				return ((global::SourceGrid.ColumnInfoCollection)this.Grid.Columns).IndexOf(this);
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x060027B4 RID: 10164 RVA: 0x0008A7F0 File Offset: 0x000889F0
		[global::System.ComponentModel.Browsable(false)]
		public global::SourceGrid.GridVirtual Grid
		{
			get
			{
				return this.m_Grid;
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x060027B5 RID: 10165 RVA: 0x0008A7F8 File Offset: 0x000889F8
		public global::SourceGrid.Range Range
		{
			get
			{
				if (this.m_Grid == null)
				{
					throw new global::SourceGrid.SourceGridException("Invalid Grid object");
				}
				return new global::SourceGrid.Range(0, this.Index, this.Grid.Rows.Count - 1, this.Index);
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x060027B6 RID: 10166 RVA: 0x0008A844 File Offset: 0x00088A44
		// (set) Token: 0x060027B7 RID: 10167 RVA: 0x0008A84C File Offset: 0x00088A4C
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

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x060027B8 RID: 10168 RVA: 0x0008A858 File Offset: 0x00088A58
		// (set) Token: 0x060027B9 RID: 10169 RVA: 0x0008A860 File Offset: 0x00088A60
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

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x0008A86C File Offset: 0x00088A6C
		// (set) Token: 0x060027BB RID: 10171 RVA: 0x0008A878 File Offset: 0x00088A78
		public bool Visible
		{
			get
			{
				return this.Width > 0;
			}
			set
			{
				if (value && !this.Visible)
				{
					this.Width = this.Grid.DefaultWidth;
					return;
				}
				if (!value && this.Visible)
				{
					this.Width = 0;
				}
			}
		}

		// Token: 0x04000DDB RID: 3547
		private int m_Width;

		// Token: 0x04000DDC RID: 3548
		private global::SourceGrid.GridVirtual m_Grid;

		// Token: 0x04000DDD RID: 3549
		private object m_Tag;

		// Token: 0x04000DDE RID: 3550
		private global::SourceGrid.AutoSizeMode m_AutoSizeMode = global::SourceGrid.AutoSizeMode.Default;
	}
}
