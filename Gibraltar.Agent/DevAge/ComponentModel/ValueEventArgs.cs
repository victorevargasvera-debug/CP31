using System;

namespace DevAge.ComponentModel
{
	// Token: 0x020002BD RID: 701
	internal class ValueEventArgs : global::System.EventArgs
	{
		// Token: 0x06002281 RID: 8833 RVA: 0x00079A14 File Offset: 0x00077C14
		public ValueEventArgs(object p_Value)
		{
			this.m_Value = p_Value;
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06002282 RID: 8834 RVA: 0x00079A24 File Offset: 0x00077C24
		// (set) Token: 0x06002283 RID: 8835 RVA: 0x00079A2C File Offset: 0x00077C2C
		public object Value
		{
			get
			{
				return this.m_Value;
			}
			set
			{
				this.m_Value = value;
			}
		}

		// Token: 0x04000C6D RID: 3181
		private object m_Value;
	}
}
