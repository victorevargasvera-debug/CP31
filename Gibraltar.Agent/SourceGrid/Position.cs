using System;

namespace SourceGrid
{
	// Token: 0x020003E5 RID: 997
	[global::System.Serializable]
	internal struct Position
	{
		// Token: 0x06002C83 RID: 11395 RVA: 0x00095D7C File Offset: 0x00093F7C
		public Position(int row, int col)
		{
			this.m_Row = row;
			this.m_Col = col;
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x06002C85 RID: 11397 RVA: 0x00095D9C File Offset: 0x00093F9C
		public int Row
		{
			get
			{
				return this.m_Row;
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06002C86 RID: 11398 RVA: 0x00095DA4 File Offset: 0x00093FA4
		public int Column
		{
			get
			{
				return this.m_Col;
			}
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x00095DAC File Offset: 0x00093FAC
		public bool IsEmpty()
		{
			return this.Equals(global::SourceGrid.Position.Empty);
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x00095DBC File Offset: 0x00093FBC
		public override int GetHashCode()
		{
			return this.Row;
		}

		// Token: 0x06002C89 RID: 11401 RVA: 0x00095DC4 File Offset: 0x00093FC4
		public bool Equals(global::SourceGrid.Position p_Position)
		{
			return this.m_Col == p_Position.m_Col && this.m_Row == p_Position.m_Row;
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x00095DEC File Offset: 0x00093FEC
		public override bool Equals(object obj)
		{
			return this.Equals((global::SourceGrid.Position)obj);
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x00095DFC File Offset: 0x00093FFC
		public static bool operator ==(global::SourceGrid.Position Left, global::SourceGrid.Position Right)
		{
			return Left.Equals(Right);
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x00095E08 File Offset: 0x00094008
		public static bool operator !=(global::SourceGrid.Position Left, global::SourceGrid.Position Right)
		{
			return !Left.Equals(Right);
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x00095E18 File Offset: 0x00094018
		public override string ToString()
		{
			return this.Row.ToString() + ";" + this.Column.ToString();
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x00095E50 File Offset: 0x00094050
		public static global::SourceGrid.Position Min(global::SourceGrid.Position p_Position1, global::SourceGrid.Position p_Position2)
		{
			int row;
			if (p_Position1.Row < p_Position2.Row)
			{
				row = p_Position1.Row;
			}
			else
			{
				row = p_Position2.Row;
			}
			int column;
			if (p_Position1.Column < p_Position2.Column)
			{
				column = p_Position1.Column;
			}
			else
			{
				column = p_Position2.Column;
			}
			return new global::SourceGrid.Position(row, column);
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x00095EB8 File Offset: 0x000940B8
		public static global::SourceGrid.Position Max(global::SourceGrid.Position p_Position1, global::SourceGrid.Position p_Position2)
		{
			int row;
			if (p_Position1.Row > p_Position2.Row)
			{
				row = p_Position1.Row;
			}
			else
			{
				row = p_Position2.Row;
			}
			int column;
			if (p_Position1.Column > p_Position2.Column)
			{
				column = p_Position1.Column;
			}
			else
			{
				column = p_Position2.Column;
			}
			return new global::SourceGrid.Position(row, column);
		}

		// Token: 0x04000F21 RID: 3873
		public const int c_EmptyIndex = -1;

		// Token: 0x04000F22 RID: 3874
		private int m_Row;

		// Token: 0x04000F23 RID: 3875
		private int m_Col;

		// Token: 0x04000F24 RID: 3876
		public static readonly global::SourceGrid.Position Empty = new global::SourceGrid.Position(-1, -1);
	}
}
