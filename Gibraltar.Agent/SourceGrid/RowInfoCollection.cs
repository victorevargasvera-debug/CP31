using System;
using System.Collections;
using System.Collections.Generic;

namespace SourceGrid
{
	// Token: 0x0200033F RID: 831
	internal abstract class RowInfoCollection : global::SourceGrid.RowsBase, global::System.Collections.Generic.IEnumerable<global::SourceGrid.RowInfo>, global::System.Collections.IEnumerable
	{
		// Token: 0x06002823 RID: 10275 RVA: 0x0008BDF0 File Offset: 0x00089FF0
		public RowInfoCollection(global::SourceGrid.GridVirtual grid) : base(grid)
		{
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x0008BE04 File Offset: 0x0008A004
		public bool IsValidRange(int p_StartIndex, int p_Count)
		{
			return p_StartIndex < this.Count && p_StartIndex >= 0 && p_Count > 0 && p_StartIndex + p_Count <= this.Count;
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x0008BE34 File Offset: 0x0008A034
		public bool IsValidRangeForInsert(int p_StartIndex, int p_Count)
		{
			return p_StartIndex <= this.Count && p_StartIndex >= 0 && p_Count > 0;
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x0008BE54 File Offset: 0x0008A054
		protected void InsertRange(int p_StartIndex, global::SourceGrid.RowInfo[] rows)
		{
			if (!this.IsValidRangeForInsert(p_StartIndex, rows.Length))
			{
				throw new global::SourceGrid.SourceGridException("Invalid index");
			}
			for (int i = 0; i < rows.Length; i++)
			{
				this.m_List.Insert(p_StartIndex + i, rows[i]);
			}
			base.PerformLayout();
			this.OnRowsAdded(new global::SourceGrid.IndexRangeEventArgs(p_StartIndex, rows.Length));
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x0008BEBC File Offset: 0x0008A0BC
		public void Remove(int p_Index)
		{
			this.RemoveRange(p_Index, 1);
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x0008BEC8 File Offset: 0x0008A0C8
		public void RemoveRange(int p_StartIndex, int p_Count)
		{
			if (!this.IsValidRange(p_StartIndex, p_Count))
			{
				throw new global::SourceGrid.SourceGridException("Invalid index");
			}
			global::SourceGrid.IndexRangeEventArgs e = new global::SourceGrid.IndexRangeEventArgs(p_StartIndex, p_Count);
			this.OnRowsRemoving(e);
			this.m_List.RemoveRange(p_StartIndex, p_Count);
			this.OnRowsRemoved(e);
			base.PerformLayout();
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x0008BF1C File Offset: 0x0008A11C
		public void Move(int p_CurrentRowPosition, int p_NewRowPosition)
		{
			if (p_CurrentRowPosition == p_NewRowPosition)
			{
				return;
			}
			if (p_CurrentRowPosition < p_NewRowPosition)
			{
				for (int i = p_CurrentRowPosition; i < p_NewRowPosition; i++)
				{
					this.Swap(i, i + 1);
				}
				return;
			}
			for (int j = p_CurrentRowPosition; j > p_NewRowPosition; j--)
			{
				this.Swap(j, j - 1);
			}
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x0008BF70 File Offset: 0x0008A170
		public void Swap(int p_RowIndex1, int p_RowIndex2)
		{
			if (p_RowIndex1 == p_RowIndex2)
			{
				return;
			}
			global::SourceGrid.RowInfo value = this[p_RowIndex1];
			global::SourceGrid.RowInfo value2 = this[p_RowIndex2];
			this.m_List[p_RowIndex1] = value2;
			this.m_List[p_RowIndex2] = value;
			base.PerformLayout();
		}

		// Token: 0x140000B5 RID: 181
		// (add) Token: 0x0600282B RID: 10283 RVA: 0x0008BFBC File Offset: 0x0008A1BC
		// (remove) Token: 0x0600282C RID: 10284 RVA: 0x0008BFD8 File Offset: 0x0008A1D8
		public event global::SourceGrid.IndexRangeEventHandler RowsAdded;

		// Token: 0x0600282D RID: 10285 RVA: 0x0008BFF4 File Offset: 0x0008A1F4
		protected virtual void OnRowsAdded(global::SourceGrid.IndexRangeEventArgs e)
		{
			if (this.RowsAdded != null)
			{
				this.RowsAdded(this, e);
			}
			base.RowsChanged();
		}

		// Token: 0x140000B6 RID: 182
		// (add) Token: 0x0600282E RID: 10286 RVA: 0x0008C014 File Offset: 0x0008A214
		// (remove) Token: 0x0600282F RID: 10287 RVA: 0x0008C030 File Offset: 0x0008A230
		public event global::SourceGrid.IndexRangeEventHandler RowsRemoved;

		// Token: 0x06002830 RID: 10288 RVA: 0x0008C04C File Offset: 0x0008A24C
		protected virtual void OnRowsRemoved(global::SourceGrid.IndexRangeEventArgs e)
		{
			if (this.RowsRemoved != null)
			{
				this.RowsRemoved(this, e);
			}
			base.RowsChanged();
		}

		// Token: 0x140000B7 RID: 183
		// (add) Token: 0x06002831 RID: 10289 RVA: 0x0008C06C File Offset: 0x0008A26C
		// (remove) Token: 0x06002832 RID: 10290 RVA: 0x0008C088 File Offset: 0x0008A288
		public event global::SourceGrid.IndexRangeEventHandler RowsRemoving;

		// Token: 0x06002833 RID: 10291 RVA: 0x0008C0A4 File Offset: 0x0008A2A4
		protected virtual void OnRowsRemoving(global::SourceGrid.IndexRangeEventArgs e)
		{
			if (this.RowsRemoving != null)
			{
				this.RowsRemoving(this, e);
			}
		}

		// Token: 0x17000C3D RID: 3133
		public global::SourceGrid.RowInfo this[int p]
		{
			get
			{
				return this.m_List[p];
			}
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x0008C0D0 File Offset: 0x0008A2D0
		protected override void OnLayout()
		{
			base.OnLayout();
		}

		// Token: 0x140000B8 RID: 184
		// (add) Token: 0x06002836 RID: 10294 RVA: 0x0008C0D8 File Offset: 0x0008A2D8
		// (remove) Token: 0x06002837 RID: 10295 RVA: 0x0008C0F4 File Offset: 0x0008A2F4
		public event global::SourceGrid.RowInfoEventHandler RowHeightChanged;

		// Token: 0x06002838 RID: 10296 RVA: 0x0008C110 File Offset: 0x0008A310
		public void OnRowHeightChanged(global::SourceGrid.RowInfoEventArgs e)
		{
			base.PerformLayout();
			if (this.RowHeightChanged != null)
			{
				this.RowHeightChanged(this, e);
			}
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x0008C130 File Offset: 0x0008A330
		public int IndexOf(global::SourceGrid.RowInfo p_Info)
		{
			return this.m_List.IndexOf(p_Info);
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x0008C140 File Offset: 0x0008A340
		public void AutoSizeView()
		{
			global::System.Collections.Generic.List<int> list = base.Grid.Columns.ColumnsInsideRegion(base.Grid.DisplayRectangle.X, base.Grid.DisplayRectangle.Width);
			if (list.Count > 0)
			{
				base.AutoSize(false, list[0], list[list.Count - 1]);
			}
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x0008C1B0 File Offset: 0x0008A3B0
		public void Clear()
		{
			if (this.Count > 0)
			{
				this.RemoveRange(0, this.Count);
			}
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x0008C1CC File Offset: 0x0008A3CC
		public override int GetHeight(int row)
		{
			return this[row].Height;
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x0008C1DC File Offset: 0x0008A3DC
		public override void SetHeight(int row, int height)
		{
			this[row].Height = height;
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x0008C1EC File Offset: 0x0008A3EC
		public override global::SourceGrid.AutoSizeMode GetAutoSizeMode(int row)
		{
			return this[row].AutoSizeMode;
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x0600283F RID: 10303 RVA: 0x0008C1FC File Offset: 0x0008A3FC
		public override int Count
		{
			get
			{
				return this.m_List.Count;
			}
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x0008C20C File Offset: 0x0008A40C
		public global::System.Collections.Generic.IEnumerator<global::SourceGrid.RowInfo> GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x0008C220 File Offset: 0x0008A420
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x04000DEC RID: 3564
		private global::System.Collections.Generic.List<global::SourceGrid.RowInfo> m_List = new global::System.Collections.Generic.List<global::SourceGrid.RowInfo>();
	}
}
