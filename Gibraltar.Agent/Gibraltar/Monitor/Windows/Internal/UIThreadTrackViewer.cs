using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Gibraltar.Monitor.Windows.Internal
{
	// Token: 0x020001ED RID: 493
	internal class UIThreadTrackViewer : global::System.Windows.Forms.UserControl
	{
		// Token: 0x0600183C RID: 6204 RVA: 0x000537D4 File Offset: 0x000519D4
		public UIThreadTrackViewer()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x000537E4 File Offset: 0x000519E4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x0005380C File Offset: 0x00051A0C
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Window;
			base.Name = "UIThreadTrackViewer";
			base.Size = new global::System.Drawing.Size(305, 100);
			base.ResumeLayout(false);
		}

		// Token: 0x0400088B RID: 2187
		private global::System.ComponentModel.IContainer components;
	}
}
