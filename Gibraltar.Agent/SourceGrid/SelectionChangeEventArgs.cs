using System;

namespace SourceGrid
{
	// Token: 0x0200037C RID: 892
	internal class SelectionChangeEventArgs : global::System.EventArgs
	{
		// Token: 0x06002A82 RID: 10882 RVA: 0x0008FC04 File Offset: 0x0008DE04
		public SelectionChangeEventArgs(global::SourceGrid.SelectionChangeEventType p_Type, global::SourceGrid.Range p_Range)
		{
			this.m_Type = p_Type;
			this.m_Range = p_Range;
		}

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06002A83 RID: 10883 RVA: 0x0008FC1C File Offset: 0x0008DE1C
		public global::SourceGrid.Range Range
		{
			get
			{
				return this.m_Range;
			}
		}

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06002A84 RID: 10884 RVA: 0x0008FC24 File Offset: 0x0008DE24
		public global::SourceGrid.SelectionChangeEventType EventType
		{
			get
			{
				return this.m_Type;
			}
		}

		// Token: 0x04000E54 RID: 3668
		private global::SourceGrid.Range m_Range;

		// Token: 0x04000E55 RID: 3669
		private global::SourceGrid.SelectionChangeEventType m_Type;
	}
}
