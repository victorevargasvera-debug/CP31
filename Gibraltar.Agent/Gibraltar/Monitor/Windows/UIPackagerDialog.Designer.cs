namespace Gibraltar.Monitor.Windows
{
	// Token: 0x020001E4 RID: 484
	internal partial class UIPackagerDialog : global::Gibraltar.Windows.UI.UIWizardDialog
	{
		// Token: 0x0600178E RID: 6030 RVA: 0x0004E134 File Offset: 0x0004C334
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x0004E15C File Offset: 0x0004C35C
		private void InitializeComponent()
		{
			((global::System.ComponentModel.ISupportInitialize)this.pageHeaderPicture).BeginInit();
			base.SuspendLayout();
			this.pageHeaderPicture.Image = global::Gibraltar.Monitor.Windows.UIResources.packaging_wizard_corner;
			this.pageHeaderPicture.Location = new global::System.Drawing.Point(425, 0);
			this.pageHeaderPicture.Size = new global::System.Drawing.Size(75, 75);
			this.pageHeaderPicture.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.pageHeaderPicture.Margin = new global::System.Windows.Forms.Padding(0);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.ClientSize = new global::System.Drawing.Size(500, 382);
			base.Name = "UIPackagerDialog";
			((global::System.ComponentModel.ISupportInitialize)this.pageHeaderPicture).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000815 RID: 2069
		private global::System.ComponentModel.IContainer components;
	}
}
