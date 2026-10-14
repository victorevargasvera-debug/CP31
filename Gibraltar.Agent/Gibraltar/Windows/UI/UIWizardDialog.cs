using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using Gibraltar.Monitor;
using Gibraltar.Windows.UI.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Windows.UI
{
	// Token: 0x02000171 RID: 369
	internal partial class UIWizardDialog : Form
	{
		// Token: 0x06000F3A RID: 3898 RVA: 0x00027540 File Offset: 0x00025740
		[Obsolete]
		public UIWizardDialog() : this("UI Wizard Dialog Title")
		{
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x00027550 File Offset: 0x00025750
		public UIWizardDialog(string title)
		{
			this.InitializeComponent();
			FormTools.ApplyOSFont(this);
			this.btnPrevious.Enabled = false;
			this.btnNext.Enabled = false;
			this.m_Title = title;
			if (this._DesignMode)
			{
				return;
			}
			this.m_WizardEngine = new WizardEngine(title);
			this.m_WizardEngine.CurrentPageChanged += this.WizardSequencer_CurrentPageChanged;
			this.m_WizardEngine.FinishEnabledChanged += this.WizardSequencer_FinishEnabledChanged;
			this.m_WizardEngine.NextEnabledChanged += this.WizardSequencer_NextEnabledChanged;
			this.m_WizardEngine.PreviousEnabledChanged += this.WizardSequencer_PreviousEnabledChanged;
			this.m_WizardEngine.TitleChanged += this.WizardSequencer_TitleChanged;
			this.m_WizardEngine.CaptionChanged += this.WizardSequencer_CaptionChanged;
			this.m_WizardEngine.Finished += this.WizardSequencer_Finished;
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x0002764C File Offset: 0x0002584C
		protected void AddPage(IUIWizardInputPage newPage)
		{
			if (newPage == null)
			{
				throw new ArgumentNullException("newPage");
			}
			newPage.Initialize(this.m_Request);
			this.m_WizardEngine.AddPage(newPage);
			((UserControl)newPage).BackColor = this.wizardDisplayPanel.BackColor;
			FormTools.ApplyOSFont((UserControl)newPage);
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x000276A8 File Offset: 0x000258A8
		protected void SetSequencer(IUIWizardSequencer sequencer)
		{
			if (sequencer == null)
			{
				throw new ArgumentNullException("sequencer");
			}
			sequencer.Initialize(this.m_WizardEngine, this.m_Request);
			this.m_WizardEngine.SetSequencer(sequencer);
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x000276DC File Offset: 0x000258DC
		protected void SetFinishedPage(IUIWizardFinishPage newPage)
		{
			if (newPage == null)
			{
				throw new ArgumentNullException("newPage");
			}
			newPage.Initialize(this.m_Request);
			this.m_WizardEngine.SetFinishedPage(newPage);
			((UserControl)newPage).BackColor = this.wizardDisplayPanel.BackColor;
			FormTools.ApplyOSFont((UserControl)newPage);
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x00027738 File Offset: 0x00025938
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x00027740 File Offset: 0x00025940
		protected bool EnsureTopMost { get; set; }

		// Token: 0x06000F41 RID: 3905 RVA: 0x0002774C File Offset: 0x0002594C
		protected void Initialize(object request)
		{
			this.m_Request = request;
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00027758 File Offset: 0x00025958
		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			if (this._DesignMode)
			{
				return;
			}
			this.DisplayWizard();
			base.TopMost = this.EnsureTopMost;
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x00027790 File Offset: 0x00025990
		private bool _DesignMode
		{
			get
			{
				return this.GetService(typeof(IDesignerHost)) != null || LicenseManager.UsageMode == LicenseUsageMode.Designtime;
			}
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x000277B4 File Offset: 0x000259B4
		private void DisplayPage(IUIWizardPage page)
		{
			if (this.m_DisplayedPage != null)
			{
				this.m_DisplayedPage.Visible = false;
				this.m_DisplayedPage = null;
			}
			this.m_DisplayedPage = (UserControl)page;
			if (!this.wizardDisplayPanel.Contains(this.m_DisplayedPage))
			{
				this.wizardDisplayPanel.Controls.Add(this.m_DisplayedPage);
				this.m_DisplayedPage.Visible = true;
				this.m_DisplayedPage.Dock = DockStyle.Fill;
				return;
			}
			this.m_DisplayedPage.Visible = true;
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x00027840 File Offset: 0x00025A40
		private void DisplayWizard()
		{
			this.Text = this.m_Title;
			try
			{
				this.m_WizardEngine.Start();
			}
			catch (Exception ex)
			{
				Log.Write(LogMessageSeverity.Verbose, LogWriteMode.Queued, ex, "Gibraltar.User Interface", "Unable to Display Wizard", "While displaying the wizard an exception was thrown ({0}): {1}", new object[]
				{
					ex.GetType().FullName,
					ex.Message
				});
			}
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x000278B4 File Offset: 0x00025AB4
		private void OnFinished(AsyncTaskResultEventArgs e)
		{
			IUIWizardFinishPage iuiwizardFinishPage = this.m_DisplayedPage as IUIWizardFinishPage;
			if (e.Result == AsyncTaskResult.Error || (iuiwizardFinishPage != null && !iuiwizardFinishPage.AutoClose))
			{
				if (this.m_DisplayedPage != null)
				{
					this.m_DisplayedPage.Visible = false;
					this.m_DisplayedPage = null;
				}
				this.m_DisplayedPage = new UIWizardResultPage(e);
				this.wizardDisplayPanel.Controls.Add(this.m_DisplayedPage);
				this.m_DisplayedPage.Visible = true;
				this.m_DisplayedPage.Dock = DockStyle.Fill;
				this.btnNext.Text = "&Close";
				this.m_CloseOnNext = true;
				this.btnNext.Enabled = true;
				this.btnCancel.Enabled = false;
			}
			else
			{
				this.tmrAutoClose.Enabled = true;
			}
			AsyncTaskResult result = e.Result;
			switch (result)
			{
			case AsyncTaskResult.Canceled:
				this.btnNext.DialogResult = DialogResult.Cancel;
				return;
			case AsyncTaskResult.Error:
				this.btnNext.DialogResult = DialogResult.Abort;
				return;
			case AsyncTaskResult.Canceled | AsyncTaskResult.Error:
				goto IL_11B;
			case AsyncTaskResult.Warning:
				break;
			default:
				if (result != AsyncTaskResult.Information && result != AsyncTaskResult.Success)
				{
					goto IL_11B;
				}
				break;
			}
			this.btnNext.DialogResult = DialogResult.OK;
			return;
			IL_11B:
			this.btnNext.DialogResult = DialogResult.Abort;
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x000279EC File Offset: 0x00025BEC
		private void WizardSequencer_PreviousEnabledChanged(object sender, EventArgs e)
		{
			this.btnPrevious.Enabled = this.m_WizardEngine.PreviousEnabled;
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00027A04 File Offset: 0x00025C04
		private void WizardSequencer_NextEnabledChanged(object sender, EventArgs e)
		{
			this.btnNext.Enabled = (this.m_WizardEngine.NextEnabled || this.m_WizardEngine.FinishEnabled);
			if (this.m_WizardEngine.NextEnabled)
			{
				this.btnNext.Text = "&Next >";
			}
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00027A64 File Offset: 0x00025C64
		private void WizardSequencer_FinishEnabledChanged(object sender, EventArgs e)
		{
			this.btnNext.Enabled = (this.m_WizardEngine.NextEnabled || this.m_WizardEngine.FinishEnabled);
			if (this.m_WizardEngine.FinishEnabled)
			{
				this.btnNext.Text = "&Finish";
			}
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x00027AC4 File Offset: 0x00025CC4
		private void WizardSequencer_Finished(object sender, AsyncTaskResultEventArgs e)
		{
			this.OnFinished(e);
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x00027AD0 File Offset: 0x00025CD0
		private void WizardSequencer_TitleChanged(object sender, EventArgs e)
		{
			this.Text = this.m_WizardEngine.Title;
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00027AE4 File Offset: 0x00025CE4
		private void WizardSequencer_CaptionChanged(object sender, EventArgs e)
		{
			this.lblStepCaption.Text = this.m_WizardEngine.Caption;
			this.lblStepDescription.Text = this.m_WizardEngine.Instructions;
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00027B24 File Offset: 0x00025D24
		private void WizardSequencer_CurrentPageChanged(object sender, EventArgs e)
		{
			this.DisplayPage(this.m_WizardEngine.CurrentPage);
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00027B38 File Offset: 0x00025D38
		private void btnPrevious_Click(object sender, EventArgs e)
		{
			this.m_WizardEngine.MovePrevious();
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00027B48 File Offset: 0x00025D48
		private void btnNext_Click(object sender, EventArgs e)
		{
			if (this.m_CloseOnNext)
			{
				base.DialogResult = this.btnNext.DialogResult;
				base.Close();
				return;
			}
			this.m_WizardEngine.MoveNext();
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00027B78 File Offset: 0x00025D78
		private void tmrAutoClose_Tick(object sender, EventArgs e)
		{
			base.DialogResult = this.btnNext.DialogResult;
			base.Close();
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00027B94 File Offset: 0x00025D94
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.DialogResult = this.btnCancel.DialogResult;
			base.Close();
		}

		// Token: 0x04000515 RID: 1301
		protected const string FinishText = "&Finish";

		// Token: 0x04000516 RID: 1302
		protected const string NextText = "&Next >";

		// Token: 0x04000517 RID: 1303
		protected const string CloseText = "&Close";

		// Token: 0x04000518 RID: 1304
		private readonly WizardEngine m_WizardEngine;

		// Token: 0x04000519 RID: 1305
		private readonly string m_Title;

		// Token: 0x0400051A RID: 1306
		private object m_Request;

		// Token: 0x0400051B RID: 1307
		private UserControl m_DisplayedPage;

		// Token: 0x0400051C RID: 1308
		private bool m_CloseOnNext;
	}
}
