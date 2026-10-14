using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DevAge.Windows.Forms
{
	// Token: 0x020002FB RID: 763
	internal partial class ErrorDialog : Form
	{
		// Token: 0x0600247C RID: 9340 RVA: 0x0007F15C File Offset: 0x0007D35C
		public ErrorDialog()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x0600247F RID: 9343 RVA: 0x0007F4E0 File Offset: 0x0007D6E0
		// (set) Token: 0x06002480 RID: 9344 RVA: 0x0007F4E8 File Offset: 0x0007D6E8
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

		// Token: 0x06002481 RID: 9345 RVA: 0x0007F4F4 File Offset: 0x0007D6F4
		public ErrorDialog(Exception p_Exception, string p_Caption) : this()
		{
			this.Text = p_Caption;
			this.Exception = p_Exception;
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x0007F50C File Offset: 0x0007D70C
		public DialogResult ShowDialog(Exception p_Exception, string p_Caption)
		{
			this.Text = p_Caption;
			this.Exception = p_Exception;
			return base.ShowDialog();
		}

		// Token: 0x06002483 RID: 9347 RVA: 0x0007F524 File Offset: 0x0007D724
		public DialogResult ShowDialog(IWin32Window p_Owner, Exception p_Exception, string p_Caption)
		{
			this.Text = p_Caption;
			this.Exception = p_Exception;
			return base.ShowDialog(p_Owner);
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x0007F53C File Offset: 0x0007D73C
		public static void Show(Exception p_Exception, string p_Caption)
		{
			ErrorDialog errorDialog = new ErrorDialog(p_Exception, p_Caption);
			errorDialog.ShowDialog();
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x0007F55C File Offset: 0x0007D75C
		private void linkDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				ErrorDialogDetails errorDialogDetails = new ErrorDialogDetails(this.Exception, this.Text);
				errorDialogDetails.ShowDialog(this);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x0007F5A0 File Offset: 0x0007D7A0
		private void ErrorDialog_Load(object sender, EventArgs e)
		{
			try
			{
				if (this.m_Exception != null)
				{
					this.lblErrorMessage.Text = this.m_Exception.Message;
				}
				else
				{
					this.lblErrorMessage.Text = "Exception is null";
				}
			}
			catch (Exception ex)
			{
				this.lblErrorMessage.Text = "Error loading message:" + ex.Message;
			}
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x0007F61C File Offset: 0x0007D81C
		public static void Show(IWin32Window p_Owner, Exception p_Exception, string p_Caption)
		{
			ErrorDialog errorDialog = new ErrorDialog(p_Exception, p_Caption);
			errorDialog.ShowDialog(p_Owner);
		}

		// Token: 0x04000CD8 RID: 3288
		private Exception m_Exception;
	}
}
