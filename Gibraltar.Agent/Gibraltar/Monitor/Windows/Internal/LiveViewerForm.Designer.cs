namespace Gibraltar.Monitor.Windows.Internal
{
	// Token: 0x020001EF RID: 495
	internal partial class LiveViewerForm : global::System.Windows.Forms.Form
	{
		// Token: 0x06001859 RID: 6233 RVA: 0x0005404C File Offset: 0x0005224C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00054074 File Offset: 0x00052274
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Gibraltar.Monitor.Windows.Internal.LiveViewerForm));
			base.SuspendLayout();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(928, 678);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "LiveViewerForm";
			this.Text = "Live View";
			base.ResumeLayout(false);
		}

		// Token: 0x04000896 RID: 2198
		private global::System.ComponentModel.IContainer components;
	}
}
