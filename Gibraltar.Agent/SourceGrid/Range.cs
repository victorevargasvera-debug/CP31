using System;

namespace SourceGrid
{
	// Token: 0x020003C6 RID: 966
	[global::System.Serializable]
	internal struct Range
	{
		// Token: 0x06002C0D RID: 11277 RVA: 0x00093E70 File Offset: 0x00092070
		public Range(global::SourceGrid.Position p_Start, global::SourceGrid.Position p_End)
		{
			this = new global::SourceGrid.Range(p_Start, p_End, true);
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x00093E7C File Offset: 0x0009207C
		public Range(int p_StartRow, int p_StartCol, int p_EndRow, int p_EndCol)
		{
			this.m_Start = new global::SourceGrid.Position(p_StartRow, p_StartCol);
			this.m_End = new global::SourceGrid.Position(p_EndRow, p_EndCol);
			this.Normalize();
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x00093EA0 File Offset: 0x000920A0
		private Range(global::SourceGrid.Position p_Start, global::SourceGrid.Position p_End, bool p_bCheck)
		{
			this.m_Start = p_Start;
			this.m_End = p_End;
			if (p_bCheck)
			{
				this.Normalize();
			}
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x06002C11 RID: 11281 RVA: 0x00093ED4 File Offset: 0x000920D4
		public global::SourceGrid.Position Start
		{
			get
			{
				return this.m_Start;
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06002C12 RID: 11282 RVA: 0x00093EDC File Offset: 0x000920DC
		public global::SourceGrid.Position End
		{
			get
			{
				return this.m_End;
			}
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x00093EE4 File Offset: 0x000920E4
		public void MoveTo(global::SourceGrid.Position p_StartPosition)
		{
			int columnsCount = this.ColumnsCount;
			int rowsCount = this.RowsCount;
			this.m_Start = p_StartPosition;
			this.RowsCount = rowsCount;
			this.ColumnsCount = columnsCount;
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06002C14 RID: 11284 RVA: 0x00093F18 File Offset: 0x00092118
		// (set) Token: 0x06002C15 RID: 11285 RVA: 0x00093F34 File Offset: 0x00092134
		public int ColumnsCount
		{
			get
			{
				return this.m_End.Column - this.m_Start.Column + 1;
			}
			set
			{
				if (value <= 0)
				{
					throw new global::SourceGrid.SourceGridException("Invalid columns count");
				}
				this.m_End = new global::SourceGrid.Position(this.m_End.Row, this.m_Start.Column + value - 1);
			}
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06002C16 RID: 11286 RVA: 0x00093F70 File Offset: 0x00092170
		// (set) Token: 0x06002C17 RID: 11287 RVA: 0x00093F8C File Offset: 0x0009218C
		public int RowsCount
		{
			get
			{
				return this.m_End.Row - this.m_Start.Row + 1;
			}
			set
			{
				if (value <= 0)
				{
					throw new global::SourceGrid.SourceGridException("Invalid columns count");
				}
				this.m_End = new global::SourceGrid.Position(this.m_Start.Row + value - 1, this.m_End.Column);
			}
		}

		// Token: 0x06002C18 RID: 11288 RVA: 0x00093FC8 File Offset: 0x000921C8
		public Range(global::SourceGrid.Position p_SinglePosition)
		{
			this = new global::SourceGrid.Range(p_SinglePosition, p_SinglePosition, false);
		}

		// Token: 0x06002C19 RID: 11289 RVA: 0x00093FD4 File Offset: 0x000921D4
		private void Normalize()
		{
			int row;
			if (this.m_Start.Row < this.m_End.Row)
			{
				row = this.m_Start.Row;
			}
			else
			{
				row = this.m_End.Row;
			}
			int column;
			if (this.m_Start.Column < this.m_End.Column)
			{
				column = this.m_Start.Column;
			}
			else
			{
				column = this.m_End.Column;
			}
			int row2;
			if (this.m_Start.Row > this.m_End.Row)
			{
				row2 = this.m_Start.Row;
			}
			else
			{
				row2 = this.m_End.Row;
			}
			int column2;
			if (this.m_Start.Column > this.m_End.Column)
			{
				column2 = this.m_Start.Column;
			}
			else
			{
				column2 = this.m_End.Column;
			}
			this.m_Start = new global::SourceGrid.Position(row, column);
			this.m_End = new global::SourceGrid.Position(row2, column2);
		}

		// Token: 0x06002C1A RID: 11290 RVA: 0x000940E0 File Offset: 0x000922E0
		public bool ContainsRow(int p_Row)
		{
			return p_Row >= this.m_Start.Row && p_Row <= this.m_End.Row;
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x00094108 File Offset: 0x00092308
		public bool ContainsColumn(int p_Col)
		{
			return p_Col >= this.m_Start.Column && p_Col <= this.m_End.Column;
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x00094130 File Offset: 0x00092330
		public bool Contains(global::SourceGrid.Position p_Position)
		{
			int row = p_Position.Row;
			int column = p_Position.Column;
			return row >= this.m_Start.Row && column >= this.m_Start.Column && row <= this.m_End.Row && column <= this.m_End.Column;
		}

		// Token: 0x06002C1D RID: 11293 RVA: 0x00094198 File Offset: 0x00092398
		public bool Contains(global::SourceGrid.Range p_Range)
		{
			return this.Contains(p_Range.Start) && this.Contains(p_Range.End);
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x000941BC File Offset: 0x000923BC
		public bool IsEmpty()
		{
			return this.Start.IsEmpty() || this.End.IsEmpty();
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x000941F0 File Offset: 0x000923F0
		public static bool operator ==(global::SourceGrid.Range Left, global::SourceGrid.Range Right)
		{
			return Left.Equals(Right);
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x000941FC File Offset: 0x000923FC
		public static bool operator !=(global::SourceGrid.Range Left, global::SourceGrid.Range Right)
		{
			return !Left.Equals(Right);
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x0009420C File Offset: 0x0009240C
		public override int GetHashCode()
		{
			return this.m_Start.Row;
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x0009421C File Offset: 0x0009241C
		public bool Equals(global::SourceGrid.Range p_Range)
		{
			return this.Start.Equals(p_Range.Start) && this.End.Equals(p_Range.End);
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x00094260 File Offset: 0x00092460
		public override bool Equals(object obj)
		{
			return this.Equals((global::SourceGrid.Range)obj);
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x00094270 File Offset: 0x00092470
		public global::SourceGrid.PositionCollection GetCellsPositions()
		{
			global::SourceGrid.PositionCollection positionCollection = new global::SourceGrid.PositionCollection();
			for (int i = this.Start.Row; i <= this.End.Row; i++)
			{
				for (int j = this.Start.Column; j <= this.End.Column; j++)
				{
					positionCollection.Add(new global::SourceGrid.Position(i, j));
				}
			}
			return positionCollection;
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x000942F0 File Offset: 0x000924F0
		public override string ToString()
		{
			return this.Start.ToString() + " to " + this.End.ToString();
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x00094334 File Offset: 0x00092534
		public static global::SourceGrid.RangeRegion Union(global::SourceGrid.Range p_Range1, global::SourceGrid.Range p_Range2)
		{
			return new global::SourceGrid.RangeRegion
			{
				p_Range1,
				p_Range2
			};
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x0009435C File Offset: 0x0009255C
		public static global::SourceGrid.Range GetBounds(global::SourceGrid.Range p_Range1, global::SourceGrid.Range p_Range2)
		{
			if (p_Range1.IsEmpty())
			{
				return p_Range2;
			}
			if (p_Range2.IsEmpty())
			{
				return p_Range1;
			}
			return new global::SourceGrid.Range(global::SourceGrid.Position.Min(p_Range1.Start, p_Range2.Start), global::SourceGrid.Position.Max(p_Range1.End, p_Range2.End), false);
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x000943B8 File Offset: 0x000925B8
		public static global::SourceGrid.Range Intersect(global::SourceGrid.Range p_Range1, global::SourceGrid.Range p_Range2)
		{
			if (p_Range1.IsEmpty() || p_Range2.IsEmpty())
			{
				return global::SourceGrid.Range.Empty;
			}
			global::SourceGrid.Position p_Start = global::SourceGrid.Position.Max(p_Range1.Start, p_Range2.Start);
			global::SourceGrid.Position p_End = global::SourceGrid.Position.Min(p_Range1.End, p_Range2.End);
			if (p_Start.Column > p_End.Column || p_Start.Row > p_End.Row)
			{
				return global::SourceGrid.Range.Empty;
			}
			return new global::SourceGrid.Range(p_Start, p_End, false);
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x00094444 File Offset: 0x00092644
		public global::SourceGrid.Range Intersect(global::SourceGrid.Range p_Range)
		{
			return global::SourceGrid.Range.Intersect(this, p_Range);
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x00094454 File Offset: 0x00092654
		public static bool IntersectsWith(global::SourceGrid.Range p_Range1, global::SourceGrid.Range p_Range2)
		{
			return !global::SourceGrid.Range.Intersect(p_Range1, p_Range2).IsEmpty();
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x00094478 File Offset: 0x00092678
		public bool IntersectsWith(global::SourceGrid.Range p_Range)
		{
			return global::SourceGrid.Range.IntersectsWith(this, p_Range);
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x00094488 File Offset: 0x00092688
		public global::SourceGrid.RangeRegion Exclude(global::SourceGrid.Range range)
		{
			global::SourceGrid.Range range2 = this.Intersect(range);
			global::SourceGrid.RangeRegion rangeRegion;
			if (range2.IsEmpty())
			{
				rangeRegion = new global::SourceGrid.RangeRegion(this);
			}
			else
			{
				rangeRegion = new global::SourceGrid.RangeRegion();
				if (this.Start.Row < range2.Start.Row && this.Start.Column < range2.Start.Column)
				{
					rangeRegion.Add(new global::SourceGrid.Range(this.Start.Row, this.Start.Column, range2.Start.Row - 1, range2.Start.Column - 1));
				}
				if (this.Start.Row < range2.Start.Row)
				{
					rangeRegion.Add(new global::SourceGrid.Range(this.Start.Row, range2.Start.Column, range2.Start.Row - 1, range2.End.Column));
				}
				if (this.Start.Row < range2.Start.Row && this.End.Column > range2.End.Column)
				{
					rangeRegion.Add(new global::SourceGrid.Range(this.Start.Row, range2.End.Column + 1, range2.Start.Row - 1, this.End.Column));
				}
				if (this.Start.Column < range2.Start.Column)
				{
					rangeRegion.Add(new global::SourceGrid.Range(range2.Start.Row, this.Start.Column, range2.End.Row, range2.Start.Column - 1));
				}
				if (this.End.Column > range2.End.Column)
				{
					rangeRegion.Add(new global::SourceGrid.Range(range2.Start.Row, range2.End.Column + 1, range2.End.Row, this.End.Column));
				}
				if (this.End.Row > range2.End.Row && this.Start.Column < range2.Start.Column)
				{
					rangeRegion.Add(new global::SourceGrid.Range(range2.End.Row + 1, this.Start.Column, this.End.Row, range2.Start.Column - 1));
				}
				if (this.End.Row > range2.End.Row)
				{
					rangeRegion.Add(new global::SourceGrid.Range(range2.End.Row + 1, range2.Start.Column, this.End.Row, range2.End.Column));
				}
				if (this.End.Row > range2.End.Row && this.End.Column > range2.End.Column)
				{
					rangeRegion.Add(new global::SourceGrid.Range(range2.End.Row + 1, range2.End.Column + 1, this.End.Row, this.End.Column));
				}
			}
			return rangeRegion;
		}

		// Token: 0x04000EAF RID: 3759
		private global::SourceGrid.Position m_Start;

		// Token: 0x04000EB0 RID: 3760
		private global::SourceGrid.Position m_End;

		// Token: 0x04000EB1 RID: 3761
		public static readonly global::SourceGrid.Range Empty = new global::SourceGrid.Range(global::SourceGrid.Position.Empty, global::SourceGrid.Position.Empty, false);
	}
}
