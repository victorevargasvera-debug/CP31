using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DevAge.Windows.Forms
{
	// Token: 0x02000325 RID: 805
	internal class DevAgeNumericUpDown : global::System.Windows.Forms.NumericUpDown
	{
		// Token: 0x0600260D RID: 9741 RVA: 0x00083FC0 File Offset: 0x000821C0
		public DevAgeNumericUpDown()
		{
			this.InitializeComponent();
			base.UserEdit = true;
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x00083FD8 File Offset: 0x000821D8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x00084000 File Offset: 0x00082200
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x00084010 File Offset: 0x00082210
		protected override void OnValidated(global::System.EventArgs e)
		{
			base.OnValidated(e);
			base.ParseEditText();
		}

		// Token: 0x04000D6C RID: 3436
		private global::System.ComponentModel.IContainer components;
	}
}
