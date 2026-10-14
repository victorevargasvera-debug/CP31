using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Gibraltar.Data;
using Gibraltar.Windows.UI;

namespace Gibraltar.Monitor.Windows.Internal
{
	// Token: 0x020001F2 RID: 498
	internal class UIPackagerCriteria : global::System.Windows.Forms.UserControl, global::Gibraltar.Windows.UI.IUIWizardInputPage, global::Gibraltar.Windows.UI.IUIWizardPage
	{
		// Token: 0x0600187E RID: 6270 RVA: 0x000542EC File Offset: 0x000524EC
		public UIPackagerCriteria(global::Gibraltar.Monitor.PackagerConfiguration configuration)
		{
			this.m_Configuration = configuration;
			this.InitializeComponent();
			global::Gibraltar.Windows.UI.FormTools.ApplyOSFont(this);
		}

		// Token: 0x1400007C RID: 124
		// (add) Token: 0x0600187F RID: 6271 RVA: 0x00054308 File Offset: 0x00052508
		// (remove) Token: 0x06001880 RID: 6272 RVA: 0x00054344 File Offset: 0x00052544
		public event global::System.EventHandler IsValidChanged;

		// Token: 0x06001881 RID: 6273 RVA: 0x00054380 File Offset: 0x00052580
		public void Initialize(object requestData)
		{
			this.m_Request = (global::Gibraltar.Monitor.Windows.Internal.PackagerRequest)requestData;
			this.m_NextEnabled = false;
			if (!this.m_Request.CoversCurrentApplication)
			{
				this.m_AllowActiveSession = false;
				this.optJustThisSession.Visible = false;
				this.lblJustThisSession.Visible = false;
				this.runningAppNotePanel.Visible = true;
				this.runningAppNotePanel.Width = this.mainLayoutPanel.Width - this.mainLayoutPanel.Margin.Left - this.mainLayoutPanel.Margin.Right;
				return;
			}
			this.m_AllowActiveSession = true;
			this.optJustThisSession.Visible = true;
			this.lblJustThisSession.Visible = true;
			this.runningAppNotePanel.Visible = false;
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x0005444C File Offset: 0x0005264C
		public string Title
		{
			get
			{
				return "Pick Sessions to Send";
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x00054454 File Offset: 0x00052654
		public string Instructions
		{
			get
			{
				return "Select what sessions should be included in this package.";
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x0005445C File Offset: 0x0005265C
		public bool IsValid
		{
			get
			{
				return this.m_NextEnabled;
			}
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x00054464 File Offset: 0x00052664
		public bool Store()
		{
			if (this.optAllSessions.Checked)
			{
				this.m_Request.Criteria = (this.m_AllowActiveSession ? global::Gibraltar.Data.SessionCriteria.AllSessions : global::Gibraltar.Data.SessionCriteria.AllSessions);
			}
			else if (this.optJustThisSession.Checked)
			{
				this.m_Request.Criteria = global::Gibraltar.Data.SessionCriteria.ActiveSession;
			}
			else if (this.optNewSessions.Checked)
			{
				this.m_Request.Criteria = (this.m_AllowActiveSession ? (global::Gibraltar.Data.SessionCriteria.NewSessions | global::Gibraltar.Data.SessionCriteria.ActiveSession) : global::Gibraltar.Data.SessionCriteria.NewSessions);
			}
			return true;
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x000544FC File Offset: 0x000526FC
		public void OnEnter()
		{
			if ((this.m_Request.Criteria & global::Gibraltar.Data.SessionCriteria.AllSessions) == global::Gibraltar.Data.SessionCriteria.AllSessions)
			{
				this.optAllSessions.Checked = true;
			}
			else if ((this.m_Request.Criteria & global::Gibraltar.Data.SessionCriteria.NewSessions) == global::Gibraltar.Data.SessionCriteria.NewSessions)
			{
				this.optNewSessions.Checked = true;
			}
			else if ((this.m_Request.Criteria & global::Gibraltar.Data.SessionCriteria.ActiveSession) == global::Gibraltar.Data.SessionCriteria.ActiveSession && this.optJustThisSession.Visible)
			{
				this.optJustThisSession.Checked = true;
			}
			else
			{
				this.optNewSessions.Checked = true;
				this.optAllSessions.Checked = false;
				this.optJustThisSession.Checked = false;
			}
			this.ValidateData();
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x000545B8 File Offset: 0x000527B8
		protected void OnIsValidChanged()
		{
			global::System.EventHandler isValidChanged = this.IsValidChanged;
			if (isValidChanged != null)
			{
				isValidChanged(this, new global::System.EventArgs());
			}
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x000545E4 File Offset: 0x000527E4
		private void ValidateData()
		{
			bool nextEnabled = true;
			if (!this.optAllSessions.Checked && !this.optJustThisSession.Checked && !this.optNewSessions.Checked)
			{
				nextEnabled = false;
			}
			this.SetNextEnabled(nextEnabled);
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x00054630 File Offset: 0x00052830
		private void SetNextEnabled(bool enabled)
		{
			if (enabled == this.m_NextEnabled)
			{
				return;
			}
			this.m_NextEnabled = enabled;
			this.OnIsValidChanged();
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x0005464C File Offset: 0x0005284C
		private void optJustThisSession_Validating(object sender, global::System.ComponentModel.CancelEventArgs e)
		{
			this.ValidateData();
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x00054654 File Offset: 0x00052854
		private void optNewSessions_Validating(object sender, global::System.ComponentModel.CancelEventArgs e)
		{
			this.ValidateData();
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0005465C File Offset: 0x0005285C
		private void optAllSessions_Validating(object sender, global::System.ComponentModel.CancelEventArgs e)
		{
			this.ValidateData();
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00054664 File Offset: 0x00052864
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x0005468C File Offset: 0x0005288C
		private void InitializeComponent()
		{
			this.optJustThisSession = new global::System.Windows.Forms.RadioButton();
			this.optAllSessions = new global::System.Windows.Forms.RadioButton();
			this.optNewSessions = new global::System.Windows.Forms.RadioButton();
			this.mainLayoutPanel = new global::System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new global::System.Windows.Forms.Label();
			this.lblJustThisSession = new global::System.Windows.Forms.Label();
			this.lblAllInformation = new global::System.Windows.Forms.Label();
			this.runningAppNotePanel = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.lblRunningAppNote = new global::System.Windows.Forms.Label();
			this.mainLayoutPanel.SuspendLayout();
			this.runningAppNotePanel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.optJustThisSession.AutoSize = true;
			this.optJustThisSession.BackColor = global::System.Drawing.Color.Transparent;
			this.optJustThisSession.Location = new global::System.Drawing.Point(3, 58);
			this.optJustThisSession.Name = "optJustThisSession";
			this.optJustThisSession.Size = new global::System.Drawing.Size(101, 17);
			this.optJustThisSession.TabIndex = 0;
			this.optJustThisSession.TabStop = true;
			this.optJustThisSession.Text = "Just this session";
			this.optJustThisSession.UseVisualStyleBackColor = false;
			this.optJustThisSession.Validating += this.optJustThisSession_Validating;
			this.optAllSessions.AutoSize = true;
			this.optAllSessions.BackColor = global::System.Drawing.Color.Transparent;
			this.optAllSessions.Location = new global::System.Drawing.Point(3, 113);
			this.optAllSessions.Name = "optAllSessions";
			this.optAllSessions.Size = new global::System.Drawing.Size(178, 17);
			this.optAllSessions.TabIndex = 1;
			this.optAllSessions.TabStop = true;
			this.optAllSessions.Text = "All information for this application";
			this.optAllSessions.UseVisualStyleBackColor = false;
			this.optAllSessions.Validating += this.optAllSessions_Validating;
			this.optNewSessions.AutoSize = true;
			this.optNewSessions.BackColor = global::System.Drawing.Color.Transparent;
			this.optNewSessions.Location = new global::System.Drawing.Point(3, 3);
			this.optNewSessions.Name = "optNewSessions";
			this.optNewSessions.Size = new global::System.Drawing.Size(201, 17);
			this.optNewSessions.TabIndex = 2;
			this.optNewSessions.TabStop = true;
			this.optNewSessions.Text = "Unsent information for this application";
			this.optNewSessions.UseVisualStyleBackColor = false;
			this.optNewSessions.Validating += this.optNewSessions_Validating;
			this.mainLayoutPanel.Controls.Add(this.optNewSessions);
			this.mainLayoutPanel.Controls.Add(this.label1);
			this.mainLayoutPanel.Controls.Add(this.optJustThisSession);
			this.mainLayoutPanel.Controls.Add(this.lblJustThisSession);
			this.mainLayoutPanel.Controls.Add(this.optAllSessions);
			this.mainLayoutPanel.Controls.Add(this.lblAllInformation);
			this.mainLayoutPanel.Controls.Add(this.runningAppNotePanel);
			this.mainLayoutPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.mainLayoutPanel.FlowDirection = global::System.Windows.Forms.FlowDirection.TopDown;
			this.mainLayoutPanel.Location = new global::System.Drawing.Point(0, 0);
			this.mainLayoutPanel.Name = "mainLayoutPanel";
			this.mainLayoutPanel.Size = new global::System.Drawing.Size(416, 253);
			this.mainLayoutPanel.TabIndex = 3;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(3, 23);
			this.label1.Margin = new global::System.Windows.Forms.Padding(3, 0, 3, 6);
			this.label1.Name = "label1";
			this.label1.Padding = new global::System.Windows.Forms.Padding(16, 0, 0, 0);
			this.label1.Size = new global::System.Drawing.Size(410, 26);
			this.label1.TabIndex = 7;
			this.label1.Text = "Session information stored on the local computer that has not been sent before will be sent along with this active application session.";
			this.lblJustThisSession.AutoSize = true;
			this.lblJustThisSession.Location = new global::System.Drawing.Point(3, 78);
			this.lblJustThisSession.Margin = new global::System.Windows.Forms.Padding(3, 0, 3, 6);
			this.lblJustThisSession.Name = "lblJustThisSession";
			this.lblJustThisSession.Padding = new global::System.Windows.Forms.Padding(16, 0, 0, 0);
			this.lblJustThisSession.Size = new global::System.Drawing.Size(409, 26);
			this.lblJustThisSession.TabIndex = 5;
			this.lblJustThisSession.Text = "Only information about this active application session will be sent.  This will include everything that has happened up to the point where you click Finish in this wizard.";
			this.lblAllInformation.AutoSize = true;
			this.lblAllInformation.Location = new global::System.Drawing.Point(3, 133);
			this.lblAllInformation.Margin = new global::System.Windows.Forms.Padding(3, 0, 3, 6);
			this.lblAllInformation.Name = "lblAllInformation";
			this.lblAllInformation.Padding = new global::System.Windows.Forms.Padding(16, 0, 0, 0);
			this.lblAllInformation.Size = new global::System.Drawing.Size(409, 26);
			this.lblAllInformation.TabIndex = 6;
			this.lblAllInformation.Text = "Any session information stored on the local computer for this application, including this active session, will be sent even if it has been sent before.";
			this.runningAppNotePanel.Controls.Add(this.pictureBox1);
			this.runningAppNotePanel.Controls.Add(this.lblRunningAppNote);
			this.runningAppNotePanel.Location = new global::System.Drawing.Point(3, 174);
			this.runningAppNotePanel.Margin = new global::System.Windows.Forms.Padding(3, 9, 3, 3);
			this.runningAppNotePanel.Name = "runningAppNotePanel";
			this.runningAppNotePanel.Size = new global::System.Drawing.Size(395, 56);
			this.runningAppNotePanel.TabIndex = 4;
			this.pictureBox1.Image = global::Gibraltar.Monitor.Windows.UIResources.info;
			this.pictureBox1.Location = new global::System.Drawing.Point(5, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(50, 49);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.lblRunningAppNote.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lblRunningAppNote.Location = new global::System.Drawing.Point(61, 3);
			this.lblRunningAppNote.Name = "lblRunningAppNote";
			this.lblRunningAppNote.Size = new global::System.Drawing.Size(331, 49);
			this.lblRunningAppNote.TabIndex = 3;
			this.lblRunningAppNote.Text = "Information about any active (running) application will not be included in this package.  Exit any copy of the application that you want to include.  ";
			this.lblRunningAppNote.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.mainLayoutPanel);
			base.Name = "UIPackagerCriteria";
			base.Size = new global::System.Drawing.Size(416, 253);
			this.mainLayoutPanel.ResumeLayout(false);
			this.mainLayoutPanel.PerformLayout();
			this.runningAppNotePanel.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x00054D8C File Offset: 0x00052F8C
		string global::Gibraltar.Windows.UI.IUIWizardPage.get_Name()
		{
			return base.Name;
		}

		// Token: 0x040008AC RID: 2220
		private const string m_Title = "Pick Sessions to Send";

		// Token: 0x040008AD RID: 2221
		private const string m_Instructions = "Select what sessions should be included in this package.";

		// Token: 0x040008AE RID: 2222
		private readonly global::Gibraltar.Monitor.PackagerConfiguration m_Configuration;

		// Token: 0x040008AF RID: 2223
		private global::Gibraltar.Monitor.Windows.Internal.PackagerRequest m_Request;

		// Token: 0x040008B0 RID: 2224
		private bool m_NextEnabled;

		// Token: 0x040008B1 RID: 2225
		private bool m_AllowActiveSession;

		// Token: 0x040008B3 RID: 2227
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040008B4 RID: 2228
		private global::System.Windows.Forms.RadioButton optJustThisSession;

		// Token: 0x040008B5 RID: 2229
		private global::System.Windows.Forms.RadioButton optAllSessions;

		// Token: 0x040008B6 RID: 2230
		private global::System.Windows.Forms.RadioButton optNewSessions;

		// Token: 0x040008B7 RID: 2231
		private global::System.Windows.Forms.FlowLayoutPanel mainLayoutPanel;

		// Token: 0x040008B8 RID: 2232
		private global::System.Windows.Forms.Panel runningAppNotePanel;

		// Token: 0x040008B9 RID: 2233
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040008BA RID: 2234
		private global::System.Windows.Forms.Label lblRunningAppNote;

		// Token: 0x040008BB RID: 2235
		private global::System.Windows.Forms.Label lblJustThisSession;

		// Token: 0x040008BC RID: 2236
		private global::System.Windows.Forms.Label lblAllInformation;

		// Token: 0x040008BD RID: 2237
		private global::System.Windows.Forms.Label label1;
	}
}
