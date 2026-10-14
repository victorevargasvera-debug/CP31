using System;

namespace DevAge.ComponentModel
{
	// Token: 0x020002BA RID: 698
	internal class ConvertingObjectEventArgs : global::System.EventArgs
	{
		// Token: 0x06002277 RID: 8823 RVA: 0x000799CC File Offset: 0x00077BCC
		public ConvertingObjectEventArgs(object p_Value, global::System.Type p_DestinationType)
		{
			this.m_Value = p_Value;
			this.m_DestinationType = p_DestinationType;
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06002278 RID: 8824 RVA: 0x000799E4 File Offset: 0x00077BE4
		// (set) Token: 0x06002279 RID: 8825 RVA: 0x000799EC File Offset: 0x00077BEC
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

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x0600227A RID: 8826 RVA: 0x000799F8 File Offset: 0x00077BF8
		public global::System.Type DestinationType
		{
			get
			{
				return this.m_DestinationType;
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x00079A00 File Offset: 0x00077C00
		// (set) Token: 0x0600227C RID: 8828 RVA: 0x00079A08 File Offset: 0x00077C08
		public global::DevAge.ComponentModel.ConvertingStatus ConvertingStatus
		{
			get
			{
				return this.m_ConvertingStatus;
			}
			set
			{
				this.m_ConvertingStatus = value;
			}
		}

		// Token: 0x04000C66 RID: 3174
		private object m_Value;

		// Token: 0x04000C67 RID: 3175
		private global::System.Type m_DestinationType;

		// Token: 0x04000C68 RID: 3176
		private global::DevAge.ComponentModel.ConvertingStatus m_ConvertingStatus;
	}
}
