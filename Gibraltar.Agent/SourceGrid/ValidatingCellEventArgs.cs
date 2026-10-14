using System;

namespace SourceGrid
{
	// Token: 0x0200035D RID: 861
	internal class ValidatingCellEventArgs : global::SourceGrid.CellCancelEventArgs
	{
		// Token: 0x06002A14 RID: 10772 RVA: 0x0008F9D0 File Offset: 0x0008DBD0
		public ValidatingCellEventArgs(global::SourceGrid.CellContext pCellContext, object p_NewValue) : base(pCellContext)
		{
			this.m_NewValue = p_NewValue;
		}

		// Token: 0x17000C96 RID: 3222
		// (get) Token: 0x06002A15 RID: 10773 RVA: 0x0008F9E0 File Offset: 0x0008DBE0
		// (set) Token: 0x06002A16 RID: 10774 RVA: 0x0008F9E8 File Offset: 0x0008DBE8
		public object NewValue
		{
			get
			{
				return this.m_NewValue;
			}
			set
			{
				this.m_NewValue = value;
			}
		}

		// Token: 0x04000E3F RID: 3647
		private object m_NewValue;
	}
}
