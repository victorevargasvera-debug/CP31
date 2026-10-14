namespace DevAge.Windows.Forms
{
	// Token: 0x0200032D RID: 813
	internal partial class DropDown : global::System.Windows.Forms.Form
	{
		// Token: 0x06002655 RID: 9813 RVA: 0x00084BFC File Offset: 0x00082DFC
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x00084C24 File Offset: 0x00082E24
		private void InitializeComponent()
		{
			this.panelContainer = new global::System.Windows.Forms.Panel();
			base.SuspendLayout();
			this.panelContainer.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelContainer.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelContainer.Location = new global::System.Drawing.Point(0, 0);
			this.panelContainer.Name = "panelContainer";
			this.panelContainer.Size = new global::System.Drawing.Size(84, 48);
			this.panelContainer.TabIndex = 0;
			this.AutoScaleBaseSize = new global::System.Drawing.Size(5, 13);
			base.ClientSize = new global::System.Drawing.Size(84, 48);
			base.ControlBox = false;
			base.Controls.Add(this.panelContainer);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "ctlDropDownCustom";
			base.ShowInTaskbar = false;
			this.Text = "ctlDropDownCustom";
			base.Visible = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			base.Deactivate += new global::System.EventHandler(this.DropDown_Deactivate);
			base.Layout += new global::System.Windows.Forms.LayoutEventHandler(this.DropDown_Layout);
			base.ResumeLayout(false);
		}

		// Token: 0x04000D82 RID: 3458
		private global::System.Windows.Forms.Panel panelContainer;

		// Token: 0x04000D83 RID: 3459
		private global::System.ComponentModel.Container components;
	}
}
