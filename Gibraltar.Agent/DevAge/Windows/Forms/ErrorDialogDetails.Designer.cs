namespace DevAge.Windows.Forms
{
	// Token: 0x020002CB RID: 715
	internal partial class ErrorDialogDetails : global::System.Windows.Forms.Form
	{
		// Token: 0x0600230A RID: 8970 RVA: 0x0007B1F0 File Offset: 0x000793F0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600230B RID: 8971 RVA: 0x0007B218 File Offset: 0x00079418
		private void InitializeComponent()
		{
			global::System.Resources.ResourceManager resourceManager = new global::System.Resources.ResourceManager(typeof(global::DevAge.Windows.Forms.ErrorDialogDetails));
			this.txtDetailsError = new global::System.Windows.Forms.TextBox();
			base.SuspendLayout();
			this.txtDetailsError.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.txtDetailsError.Location = new global::System.Drawing.Point(0, 0);
			this.txtDetailsError.MaxLength = 0;
			this.txtDetailsError.Multiline = true;
			this.txtDetailsError.Name = "txtDetailsError";
			this.txtDetailsError.ReadOnly = true;
			this.txtDetailsError.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.txtDetailsError.Size = new global::System.Drawing.Size(492, 371);
			this.txtDetailsError.TabIndex = 0;
			this.txtDetailsError.Text = "";
			this.txtDetailsError.WordWrap = false;
			this.AutoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			base.ClientSize = new global::System.Drawing.Size(492, 371);
			base.Controls.Add(this.txtDetailsError);
			base.Icon = (global::System.Drawing.Icon)resourceManager.GetObject("$this.Icon");
			base.Name = "ErrorDialogDetails";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Error Details";
			base.Load += new global::System.EventHandler(this.ErrorDialogDetails_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000C8B RID: 3211
		private global::System.Windows.Forms.TextBox txtDetailsError;

		// Token: 0x04000C8C RID: 3212
		private global::System.ComponentModel.Container components;
	}
}
