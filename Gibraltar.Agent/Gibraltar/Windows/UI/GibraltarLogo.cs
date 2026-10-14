using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Gibraltar.Windows.UI
{
	// Token: 0x020000CE RID: 206
	internal class GibraltarLogo : global::System.Windows.Forms.UserControl
	{
		// Token: 0x0600088D RID: 2189 RVA: 0x00012C58 File Offset: 0x00010E58
		public GibraltarLogo()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00012C68 File Offset: 0x00010E68
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00012C90 File Offset: 0x00010E90
		private void InitializeComponent()
		{
			this.contentPanel = new global::System.Windows.Forms.Panel();
			base.SuspendLayout();
			this.contentPanel.BackgroundImage = global::Gibraltar.Windows.UI.FancyButtons.gibraltar_small_logo;
			this.contentPanel.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			this.contentPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.contentPanel.Location = new global::System.Drawing.Point(0, 0);
			this.contentPanel.Name = "contentPanel";
			this.contentPanel.Size = new global::System.Drawing.Size(138, 21);
			this.contentPanel.TabIndex = 0;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Transparent;
			base.Controls.Add(this.contentPanel);
			this.DoubleBuffered = true;
			base.Margin = new global::System.Windows.Forms.Padding(0);
			this.MinimumSize = new global::System.Drawing.Size(138, 21);
			base.Name = "GibraltarLogo";
			base.Size = new global::System.Drawing.Size(138, 21);
			base.ResumeLayout(false);
		}

		// Token: 0x040001DC RID: 476
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040001DD RID: 477
		private global::System.Windows.Forms.Panel contentPanel;
	}
}
