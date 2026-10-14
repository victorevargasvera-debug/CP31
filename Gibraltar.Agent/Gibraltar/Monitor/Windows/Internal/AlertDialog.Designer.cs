namespace Gibraltar.Monitor.Windows.Internal
{
	// Token: 0x020001E6 RID: 486
	internal partial class AlertDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x060017AD RID: 6061 RVA: 0x0004EF84 File Offset: 0x0004D184
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x0004EFAC File Offset: 0x0004D1AC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Gibraltar.Monitor.Windows.Internal.AlertDialog));
			this.buttonPanel = new global::System.Windows.Forms.Panel();
			this.lblButtonDivider = new global::System.Windows.Forms.Label();
			this.lblShowHideDetails = new global::System.Windows.Forms.Label();
			this.vistaEmulationImages = new global::System.Windows.Forms.ImageList(this.components);
			this.btnRestart = new global::System.Windows.Forms.Button();
			this.btnClose = new global::System.Windows.Forms.Button();
			this.lblMainInstruction = new global::System.Windows.Forms.Label();
			this.messageFlowLayout = new global::System.Windows.Forms.FlowLayoutPanel();
			this.lblErrorSummary = new global::System.Windows.Forms.Label();
			this.chkIgnoreAllProblems = new global::System.Windows.Forms.CheckBox();
			this.chkReportProblems = new global::System.Windows.Forms.CheckBox();
			this.exceptionListViewer = new global::Gibraltar.Monitor.Windows.Internal.ExceptionListViewer();
			this.buttonPanel.SuspendLayout();
			this.messageFlowLayout.SuspendLayout();
			base.SuspendLayout();
			this.buttonPanel.BackColor = global::System.Drawing.SystemColors.ButtonFace;
			this.buttonPanel.Controls.Add(this.lblButtonDivider);
			this.buttonPanel.Controls.Add(this.lblShowHideDetails);
			this.buttonPanel.Controls.Add(this.btnRestart);
			this.buttonPanel.Controls.Add(this.btnClose);
			this.buttonPanel.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.buttonPanel.Location = new global::System.Drawing.Point(0, 289);
			this.buttonPanel.Name = "buttonPanel";
			this.buttonPanel.Size = new global::System.Drawing.Size(462, 50);
			this.buttonPanel.TabIndex = 0;
			this.lblButtonDivider.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblButtonDivider.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblButtonDivider.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.lblButtonDivider.Location = new global::System.Drawing.Point(0, 0);
			this.lblButtonDivider.Name = "lblButtonDivider";
			this.lblButtonDivider.Size = new global::System.Drawing.Size(462, 2);
			this.lblButtonDivider.TabIndex = 9;
			this.lblShowHideDetails.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.lblShowHideDetails.ImageIndex = 3;
			this.lblShowHideDetails.ImageList = this.vistaEmulationImages;
			this.lblShowHideDetails.Location = new global::System.Drawing.Point(12, 13);
			this.lblShowHideDetails.Name = "lblShowHideDetails";
			this.lblShowHideDetails.Size = new global::System.Drawing.Size(106, 23);
			this.lblShowHideDetails.TabIndex = 4;
			this.lblShowHideDetails.Text = "        More options";
			this.lblShowHideDetails.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.lblShowHideDetails.Click += new global::System.EventHandler(this.lblShowHideDetails_Click);
			this.lblShowHideDetails.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.lblShowHideDetails_MouseDown);
			this.lblShowHideDetails.MouseEnter += new global::System.EventHandler(this.lblShowHideDetails_MouseEnter);
			this.lblShowHideDetails.MouseLeave += new global::System.EventHandler(this.lblShowHideDetails_MouseLeave);
			this.lblShowHideDetails.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.lblShowHideDetails_MouseUp);
			this.vistaEmulationImages.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("vistaEmulationImages.ImageStream");
			this.vistaEmulationImages.TransparentColor = global::System.Drawing.Color.Fuchsia;
			this.vistaEmulationImages.Images.SetKeyName(0, "arrow_up_bw");
			this.vistaEmulationImages.Images.SetKeyName(1, "arrow_up_color");
			this.vistaEmulationImages.Images.SetKeyName(2, "arrow_up_color_pressed");
			this.vistaEmulationImages.Images.SetKeyName(3, "arrow_down_bw");
			this.vistaEmulationImages.Images.SetKeyName(4, "arrow_down_color");
			this.vistaEmulationImages.Images.SetKeyName(5, "arrow_down_color_pressed");
			this.vistaEmulationImages.Images.SetKeyName(6, "green_arrow.bmp");
			this.btnRestart.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnRestart.DialogResult = global::System.Windows.Forms.DialogResult.Abort;
			this.btnRestart.Location = new global::System.Drawing.Point(251, 9);
			this.btnRestart.Name = "btnRestart";
			this.btnRestart.Size = new global::System.Drawing.Size(117, 27);
			this.btnRestart.TabIndex = 1;
			this.btnRestart.Text = "&Restart Application";
			this.btnRestart.UseVisualStyleBackColor = true;
			this.btnRestart.Click += new global::System.EventHandler(this.btnRestart_Click);
			this.btnClose.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnClose.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new global::System.Drawing.Point(374, 9);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new global::System.Drawing.Size(76, 27);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new global::System.EventHandler(this.btnClose_Click);
			this.lblMainInstruction.AutoSize = true;
			this.lblMainInstruction.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblMainInstruction.ForeColor = global::System.Drawing.Color.RoyalBlue;
			this.lblMainInstruction.Location = new global::System.Drawing.Point(0, 0);
			this.lblMainInstruction.Margin = new global::System.Windows.Forms.Padding(0, 0, 0, 6);
			this.lblMainInstruction.Name = "lblMainInstruction";
			this.lblMainInstruction.Size = new global::System.Drawing.Size(376, 40);
			this.lblMainInstruction.TabIndex = 2;
			this.lblMainInstruction.Text = "{Application Name} has encountered an unexpected problem";
			this.messageFlowLayout.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.messageFlowLayout.Controls.Add(this.lblMainInstruction);
			this.messageFlowLayout.Controls.Add(this.lblErrorSummary);
			this.messageFlowLayout.FlowDirection = global::System.Windows.Forms.FlowDirection.TopDown;
			this.messageFlowLayout.Location = new global::System.Drawing.Point(70, 12);
			this.messageFlowLayout.Name = "messageFlowLayout";
			this.messageFlowLayout.Size = new global::System.Drawing.Size(379, 74);
			this.messageFlowLayout.TabIndex = 3;
			this.messageFlowLayout.WrapContents = false;
			this.lblErrorSummary.AutoSize = true;
			this.lblErrorSummary.Location = new global::System.Drawing.Point(0, 46);
			this.lblErrorSummary.Margin = new global::System.Windows.Forms.Padding(0, 0, 0, 6);
			this.lblErrorSummary.Name = "lblErrorSummary";
			this.lblErrorSummary.Size = new global::System.Drawing.Size(328, 13);
			this.lblErrorSummary.TabIndex = 3;
			this.lblErrorSummary.Text = "<Short display message from the exception if we can figure one out>";
			this.chkIgnoreAllProblems.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.chkIgnoreAllProblems.Location = new global::System.Drawing.Point(74, 266);
			this.chkIgnoreAllProblems.Margin = new global::System.Windows.Forms.Padding(3, 9, 3, 3);
			this.chkIgnoreAllProblems.Name = "chkIgnoreAllProblems";
			this.chkIgnoreAllProblems.Size = new global::System.Drawing.Size(375, 17);
			this.chkIgnoreAllProblems.TabIndex = 4;
			this.chkIgnoreAllProblems.Text = "&Ignore any new problems for the remainder of this session";
			this.chkIgnoreAllProblems.UseVisualStyleBackColor = false;
			this.chkIgnoreAllProblems.CheckedChanged += new global::System.EventHandler(this.chkIgnoreAllProblems_CheckedChanged);
			this.chkReportProblems.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.chkReportProblems.Location = new global::System.Drawing.Point(74, 237);
			this.chkReportProblems.Margin = new global::System.Windows.Forms.Padding(3, 9, 3, 3);
			this.chkReportProblems.Name = "chkReportProblems";
			this.chkReportProblems.Size = new global::System.Drawing.Size(375, 17);
			this.chkReportProblems.TabIndex = 6;
			this.chkReportProblems.Text = "&Automatically report these problems at the end of the session";
			this.chkReportProblems.UseVisualStyleBackColor = false;
			this.chkReportProblems.CheckedChanged += new global::System.EventHandler(this.chkReportProblems_CheckedChanged);
			this.exceptionListViewer.Font = new global::System.Drawing.Font("Segoe UI", 8.25f);
			this.exceptionListViewer.Location = new global::System.Drawing.Point(12, 92);
			this.exceptionListViewer.Name = "exceptionListViewer";
			this.exceptionListViewer.Size = new global::System.Drawing.Size(437, 121);
			this.exceptionListViewer.TabIndex = 5;
			base.AcceptButton = this.btnClose;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.Window;
			base.CancelButton = this.btnClose;
			base.ClientSize = new global::System.Drawing.Size(462, 339);
			base.Controls.Add(this.chkReportProblems);
			base.Controls.Add(this.exceptionListViewer);
			base.Controls.Add(this.messageFlowLayout);
			base.Controls.Add(this.chkIgnoreAllProblems);
			base.Controls.Add(this.buttonPanel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AlertDialog";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AlertDialog";
			base.TopMost = true;
			this.buttonPanel.ResumeLayout(false);
			this.messageFlowLayout.ResumeLayout(false);
			this.messageFlowLayout.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000826 RID: 2086
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000827 RID: 2087
		private global::System.Windows.Forms.Panel buttonPanel;

		// Token: 0x04000828 RID: 2088
		private global::System.Windows.Forms.Button btnRestart;

		// Token: 0x04000829 RID: 2089
		private global::System.Windows.Forms.Button btnClose;

		// Token: 0x0400082A RID: 2090
		private global::System.Windows.Forms.ImageList vistaEmulationImages;

		// Token: 0x0400082B RID: 2091
		private global::System.Windows.Forms.Label lblShowHideDetails;

		// Token: 0x0400082C RID: 2092
		private global::System.Windows.Forms.Label lblMainInstruction;

		// Token: 0x0400082D RID: 2093
		private global::System.Windows.Forms.FlowLayoutPanel messageFlowLayout;

		// Token: 0x0400082E RID: 2094
		private global::System.Windows.Forms.Label lblErrorSummary;

		// Token: 0x0400082F RID: 2095
		private global::System.Windows.Forms.CheckBox chkIgnoreAllProblems;

		// Token: 0x04000830 RID: 2096
		private global::Gibraltar.Monitor.Windows.Internal.ExceptionListViewer exceptionListViewer;

		// Token: 0x04000831 RID: 2097
		private global::System.Windows.Forms.Label lblButtonDivider;

		// Token: 0x04000832 RID: 2098
		private global::System.Windows.Forms.CheckBox chkReportProblems;
	}
}
