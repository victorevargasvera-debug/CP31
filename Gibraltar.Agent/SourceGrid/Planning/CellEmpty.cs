using System;
using SourceGrid.Cells;

namespace SourceGrid.Planning
{
	// Token: 0x020003F5 RID: 1013
	internal class CellEmpty : global::SourceGrid.Cells.Cell
	{
		// Token: 0x06002CFF RID: 11519 RVA: 0x00097D5C File Offset: 0x00095F5C
		public CellEmpty(global::System.DateTime start, global::System.DateTime end) : base(null)
		{
			this.m_Start = start;
			this.m_End = end;
		}

		// Token: 0x17000D20 RID: 3360
		// (get) Token: 0x06002D00 RID: 11520 RVA: 0x00097D74 File Offset: 0x00095F74
		public global::System.DateTime Start
		{
			get
			{
				return this.m_Start;
			}
		}

		// Token: 0x17000D21 RID: 3361
		// (get) Token: 0x06002D01 RID: 11521 RVA: 0x00097D7C File Offset: 0x00095F7C
		public global::System.DateTime End
		{
			get
			{
				return this.m_End;
			}
		}

		// Token: 0x04000F4B RID: 3915
		private global::System.DateTime m_Start;

		// Token: 0x04000F4C RID: 3916
		private global::System.DateTime m_End;
	}
}
