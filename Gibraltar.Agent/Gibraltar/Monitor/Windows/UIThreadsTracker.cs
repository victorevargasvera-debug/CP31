using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Gibraltar.Monitor.Windows
{
	// Token: 0x020001DE RID: 478
	internal class UIThreadsTracker : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060016E0 RID: 5856 RVA: 0x0004A3B0 File Offset: 0x000485B0
		public UIThreadsTracker()
		{
			this.InitializeComponent();
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x0004A3C0 File Offset: 0x000485C0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x0004A3E8 File Offset: 0x000485E8
		private void InitializeComponent()
		{
			this.flowThreads = new global::System.Windows.Forms.FlowLayoutPanel();
			base.SuspendLayout();
			this.flowThreads.AutoSize = true;
			this.flowThreads.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.flowThreads.FlowDirection = global::System.Windows.Forms.FlowDirection.TopDown;
			this.flowThreads.Location = new global::System.Drawing.Point(0, 0);
			this.flowThreads.Name = "flowThreads";
			this.flowThreads.Size = new global::System.Drawing.Size(305, 400);
			this.flowThreads.TabIndex = 1;
			this.flowThreads.WrapContents = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Window;
			base.Controls.Add(this.flowThreads);
			base.Margin = new global::System.Windows.Forms.Padding(0);
			base.Name = "UIThreadsTracker";
			base.Size = new global::System.Drawing.Size(305, 400);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040007C0 RID: 1984
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040007C1 RID: 1985
		private global::System.Windows.Forms.FlowLayoutPanel flowThreads;
	}
}
