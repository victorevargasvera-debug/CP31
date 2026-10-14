using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace DevAge.Windows.Forms
{
	// Token: 0x020002CB RID: 715
	internal partial class ErrorDialogDetails : Form
	{
		// Token: 0x06002309 RID: 8969 RVA: 0x0007B1E0 File Offset: 0x000793E0
		public ErrorDialogDetails()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x0600230C RID: 8972 RVA: 0x0007B374 File Offset: 0x00079574
		// (set) Token: 0x0600230D RID: 8973 RVA: 0x0007B37C File Offset: 0x0007957C
		public Exception Exception
		{
			get
			{
				return this.m_Exception;
			}
			set
			{
				this.m_Exception = value;
			}
		}

		// Token: 0x0600230E RID: 8974 RVA: 0x0007B388 File Offset: 0x00079588
		public ErrorDialogDetails(Exception p_Exception, string p_Caption) : this()
		{
			this.Text = "Error Details - " + p_Caption;
			this.Exception = p_Exception;
		}

		// Token: 0x0600230F RID: 8975 RVA: 0x0007B3A8 File Offset: 0x000795A8
		public DialogResult ShowDialog(Exception p_Exception, string p_Caption)
		{
			this.Text = "Error Details - " + p_Caption;
			this.Exception = p_Exception;
			return base.ShowDialog();
		}

		// Token: 0x06002310 RID: 8976 RVA: 0x0007B3C8 File Offset: 0x000795C8
		public DialogResult ShowDialog(IWin32Window p_Owner, Exception p_Exception, string p_Caption)
		{
			this.Text = "Error Details - " + p_Caption;
			this.Exception = p_Exception;
			return base.ShowDialog(p_Owner);
		}

		// Token: 0x06002311 RID: 8977 RVA: 0x0007B3EC File Offset: 0x000795EC
		public static void Show(Exception p_Exception, string p_Caption)
		{
			ErrorDialogDetails errorDialogDetails = new ErrorDialogDetails(p_Exception, p_Caption);
			errorDialogDetails.ShowDialog();
		}

		// Token: 0x06002312 RID: 8978 RVA: 0x0007B40C File Offset: 0x0007960C
		private void ErrorDialogDetails_Load(object sender, EventArgs e)
		{
			try
			{
				if (this.m_Exception != null)
				{
					this.txtDetailsError.Text = this.m_Exception.ToString();
				}
				else
				{
					this.txtDetailsError.Text = "Exception is null";
				}
			}
			catch (Exception ex)
			{
				this.txtDetailsError.Text = "Error loading message:" + ex.ToString();
			}
		}

		// Token: 0x06002313 RID: 8979 RVA: 0x0007B488 File Offset: 0x00079688
		public static void Show(IWin32Window p_Owner, Exception p_Exception, string p_Caption)
		{
			ErrorDialogDetails errorDialogDetails = new ErrorDialogDetails(p_Exception, p_Caption);
			errorDialogDetails.ShowDialog(p_Owner);
		}

		// Token: 0x04000C8D RID: 3213
		private Exception m_Exception;
	}
}
