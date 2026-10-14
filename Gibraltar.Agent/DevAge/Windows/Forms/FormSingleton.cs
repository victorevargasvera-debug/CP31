using System;
using System.Windows.Forms;

namespace DevAge.Windows.Forms
{
	// Token: 0x020002DF RID: 735
	internal class FormSingleton
	{
		// Token: 0x06002394 RID: 9108 RVA: 0x0007C4A8 File Offset: 0x0007A6A8
		public FormSingleton(global::System.Type p_FormType, object[] p_Args)
		{
			this.m_FormType = p_FormType;
			this.m_Args = p_Args;
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x0007C4C0 File Offset: 0x0007A6C0
		public global::System.Windows.Forms.Form GetForm()
		{
			if (this.m_Form == null)
			{
				this.m_Form = (global::System.Windows.Forms.Form)global::System.Activator.CreateInstance(this.m_FormType, this.m_Args);
				this.m_Form.CreateControl();
				this.m_Form.Closed += this.m_Form_Closed;
			}
			return this.m_Form;
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x0007C520 File Offset: 0x0007A720
		public bool IsFormCreated
		{
			get
			{
				return this.m_Form != null;
			}
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x0007C530 File Offset: 0x0007A730
		private void m_Form_Closed(object sender, global::System.EventArgs e)
		{
			this.m_Form.Closed -= this.m_Form_Closed;
			this.m_Form = null;
		}

		// Token: 0x04000CA1 RID: 3233
		private global::System.Type m_FormType;

		// Token: 0x04000CA2 RID: 3234
		private object[] m_Args;

		// Token: 0x04000CA3 RID: 3235
		private global::System.Windows.Forms.Form m_Form;
	}
}
