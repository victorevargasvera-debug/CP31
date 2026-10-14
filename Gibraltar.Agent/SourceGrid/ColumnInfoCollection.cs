using System;
using System.Collections;
using System.Collections.Generic;

namespace SourceGrid
{
	// Token: 0x0200033C RID: 828
	internal abstract class ColumnInfoCollection : global::SourceGrid.ColumnsBase, global::System.Collections.Generic.IEnumerable<global::SourceGrid.ColumnInfo>, global::System.Collections.IEnumerable
	{
		// Token: 0x060027DA RID: 10202 RVA: 0x0008B08C File Offset: 0x0008928C
		public ColumnInfoCollection(global::SourceGrid.GridVirtual grid) : base(grid)
		{
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x0008B0A0 File Offset: 0x000892A0
		public bool IsValidRange(int p_StartIndex, int p_Count)
		{
			return p_StartIndex < this.Count && p_StartIndex >= 0 && p_Count > 0 && p_StartIndex + p_Count <= this.Count;
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x0008B0D0 File Offset: 0x000892D0
		public bool IsValidRangeForInsert(int p_StartIndex, int p_Count)
		{
			return p_StartIndex <= this.Count && p_StartIndex >= 0 && p_Count > 0;
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x0008B0F0 File Offset: 0x000892F0
		protected void InsertRange(int p_StartIndex, global::SourceGrid.ColumnInfo[] columns)
		{
			if (!this.IsValidRangeForInsert(p_StartIndex, columns.Length))
			{
				throw new global::SourceGrid.SourceGridException("Invalid index");
			}
			for (int i = 0; i < columns.Length; i++)
			{
				this.m_List.Insert(p_StartIndex + i, columns[i]);
			}
			base.PerformLayout();
			this.OnColumnsAdded(new global::SourceGrid.IndexRangeEventArgs(p_StartIndex, columns.Length));
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x0008B158 File Offset: 0x00089358
		public void Remove(int p_Index)
		{
			this.RemoveRange(p_Index, 1);
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x0008B164 File Offset: 0x00089364
		public void RemoveRange(int p_StartIndex, int p_Count)
		{
			if (!this.IsValidRange(p_StartIndex, p_Count))
			{
				throw new global::SourceGrid.SourceGridException("Invalid index");
			}
			global::SourceGrid.IndexRangeEventArgs e = new global::SourceGrid.IndexRangeEventArgs(p_StartIndex, p_Count);
			this.OnColumnsRemoving(e);
			this.m_List.RemoveRange(p_StartIndex, p_Count);
			this.OnColumnsRemoved(e);
			base.PerformLayout();
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x0008B1B8 File Offset: 0x000893B8
		public void Move(int p_CurrentColumnPosition, int p_NewColumnPosition)
		{
			if (p_CurrentColumnPosition == p_NewColumnPosition)
			{
				return;
			}
			if (p_CurrentColumnPosition < p_NewColumnPosition)
			{
				for (int i = p_CurrentColumnPosition; i < p_NewColumnPosition; i++)
				{
					this.Swap(i, i + 1);
				}
				return;
			}
			for (int j = p_CurrentColumnPosition; j > p_NewColumnPosition; j--)
			{
				this.Swap(j, j - 1);
			}
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x0008B20C File Offset: 0x0008940C
		public void Swap(int p_ColumnIndex1, int p_ColumnIndex2)
		{
			if (p_ColumnIndex1 == p_ColumnIndex2)
			{
				return;
			}
			global::SourceGrid.ColumnInfo value = this[p_ColumnIndex1];
			global::SourceGrid.ColumnInfo value2 = this[p_ColumnIndex2];
			this.m_List[p_ColumnIndex1] = value2;
			this.m_List[p_ColumnIndex2] = value;
			base.PerformLayout();
		}

		// Token: 0x140000B1 RID: 177
		// (add) Token: 0x060027E2 RID: 10210 RVA: 0x0008B258 File Offset: 0x00089458
		// (remove) Token: 0x060027E3 RID: 10211 RVA: 0x0008B274 File Offset: 0x00089474
		public event global::SourceGrid.IndexRangeEventHandler ColumnsAdded;

		// Token: 0x060027E4 RID: 10212 RVA: 0x0008B290 File Offset: 0x00089490
		protected virtual void OnColumnsAdded(global::SourceGrid.IndexRangeEventArgs e)
		{
			if (this.ColumnsAdded != null)
			{
				this.ColumnsAdded(this, e);
			}
			base.ColumnsChanged();
		}

		// Token: 0x140000B2 RID: 178
		// (add) Token: 0x060027E5 RID: 10213 RVA: 0x0008B2B0 File Offset: 0x000894B0
		// (remove) Token: 0x060027E6 RID: 10214 RVA: 0x0008B2CC File Offset: 0x000894CC
		public event global::SourceGrid.IndexRangeEventHandler ColumnsRemoved;

		// Token: 0x060027E7 RID: 10215 RVA: 0x0008B2E8 File Offset: 0x000894E8
		protected virtual void OnColumnsRemoved(global::SourceGrid.IndexRangeEventArgs e)
		{
			if (this.ColumnsRemoved != null)
			{
				this.ColumnsRemoved(this, e);
			}
			base.ColumnsChanged();
		}

		// Token: 0x140000B3 RID: 179
		// (add) Token: 0x060027E8 RID: 10216 RVA: 0x0008B308 File Offset: 0x00089508
		// (remove) Token: 0x060027E9 RID: 10217 RVA: 0x0008B324 File Offset: 0x00089524
		public event global::SourceGrid.IndexRangeEventHandler ColumnsRemoving;

		// Token: 0x060027EA RID: 10218 RVA: 0x0008B340 File Offset: 0x00089540
		protected virtual void OnColumnsRemoving(global::SourceGrid.IndexRangeEventArgs e)
		{
			if (this.ColumnsRemoving != null)
			{
				this.ColumnsRemoving(this, e);
			}
		}

		// Token: 0x17000C30 RID: 3120
		public global::SourceGrid.ColumnInfo this[int p]
		{
			get
			{
				return this.m_List[p];
			}
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x0008B36C File Offset: 0x0008956C
		protected override void OnLayout()
		{
			base.OnLayout();
		}

		// Token: 0x140000B4 RID: 180
		// (add) Token: 0x060027ED RID: 10221 RVA: 0x0008B374 File Offset: 0x00089574
		// (remove) Token: 0x060027EE RID: 10222 RVA: 0x0008B390 File Offset: 0x00089590
		public event global::SourceGrid.ColumnInfoEventHandler ColumnWidthChanged;

		// Token: 0x060027EF RID: 10223 RVA: 0x0008B3AC File Offset: 0x000895AC
		public void OnColumnWidthChanged(global::SourceGrid.ColumnInfoEventArgs e)
		{
			base.PerformLayout();
			if (this.ColumnWidthChanged != null)
			{
				this.ColumnWidthChanged(this, e);
			}
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x0008B3CC File Offset: 0x000895CC
		public int IndexOf(global::SourceGrid.ColumnInfo p_Info)
		{
			return this.m_List.IndexOf(p_Info);
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x0008B3DC File Offset: 0x000895DC
		public void AutoSizeView()
		{
			global::System.Collections.Generic.List<int> list = base.Grid.Rows.RowsInsideRegion(base.Grid.DisplayRectangle.Y, base.Grid.DisplayRectangle.Height);
			if (list.Count > 0)
			{
				base.AutoSize(false, list[0], list[list.Count - 1]);
			}
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x0008B44C File Offset: 0x0008964C
		public void Clear()
		{
			if (this.Count > 0)
			{
				this.RemoveRange(0, this.Count);
			}
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x0008B468 File Offset: 0x00089668
		public override int GetWidth(int column)
		{
			return this[column].Width;
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x0008B478 File Offset: 0x00089678
		public override void SetWidth(int column, int width)
		{
			this[column].Width = width;
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x0008B488 File Offset: 0x00089688
		public override global::SourceGrid.AutoSizeMode GetAutoSizeMode(int column)
		{
			return this[column].AutoSizeMode;
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x060027F6 RID: 10230 RVA: 0x0008B498 File Offset: 0x00089698
		public override int Count
		{
			get
			{
				return this.m_List.Count;
			}
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x0008B4A8 File Offset: 0x000896A8
		public global::System.Collections.Generic.IEnumerator<global::SourceGrid.ColumnInfo> GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x0008B4BC File Offset: 0x000896BC
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x04000DE1 RID: 3553
		private global::System.Collections.Generic.List<global::SourceGrid.ColumnInfo> m_List = new global::System.Collections.Generic.List<global::SourceGrid.ColumnInfo>();
	}
}
