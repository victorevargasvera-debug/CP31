using System;

namespace SourceGrid
{
	// Token: 0x0200035F RID: 863
	internal class ScrollPositionChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06002A1B RID: 10779 RVA: 0x0008F9F4 File Offset: 0x0008DBF4
		public int NewValue
		{
			get
			{
				return this.m_NewValue;
			}
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06002A1C RID: 10780 RVA: 0x0008F9FC File Offset: 0x0008DBFC
		public int OldValue
		{
			get
			{
				return this.m_OldValue;
			}
		}

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06002A1D RID: 10781 RVA: 0x0008FA04 File Offset: 0x0008DC04
		public int Delta
		{
			get
			{
				return this.m_OldValue - this.m_NewValue;
			}
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x0008FA14 File Offset: 0x0008DC14
		public ScrollPositionChangedEventArgs(int p_NewValue, int p_OldValue)
		{
			this.m_NewValue = p_NewValue;
			this.m_OldValue = p_OldValue;
		}

		// Token: 0x04000E40 RID: 3648
		private int m_NewValue;

		// Token: 0x04000E41 RID: 3649
		private int m_OldValue;
	}
}
