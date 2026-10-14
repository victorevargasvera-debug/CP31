using System;

namespace DevAge.Windows.Forms
{
	// Token: 0x02000321 RID: 801
	internal class SubButtonItemEventArgs : global::System.EventArgs
	{
		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x060025E7 RID: 9703 RVA: 0x00083CA8 File Offset: 0x00081EA8
		// (set) Token: 0x060025E8 RID: 9704 RVA: 0x00083CB0 File Offset: 0x00081EB0
		public global::DevAge.Windows.Forms.SubButtonItem ButtonItem
		{
			get
			{
				return this.m_SubItem;
			}
			set
			{
				this.m_SubItem = value;
			}
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x00083CBC File Offset: 0x00081EBC
		public SubButtonItemEventArgs(global::DevAge.Windows.Forms.SubButtonItem p_Item)
		{
			this.m_SubItem = p_Item;
		}

		// Token: 0x04000D67 RID: 3431
		private global::DevAge.Windows.Forms.SubButtonItem m_SubItem;
	}
}
