using System;
using System.Collections.Generic;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Windows.UI
{
	// Token: 0x02000170 RID: 368
	internal class WizardEngine
	{
		// Token: 0x14000057 RID: 87
		// (add) Token: 0x06000F0B RID: 3851 RVA: 0x00026A28 File Offset: 0x00024C28
		// (remove) Token: 0x06000F0C RID: 3852 RVA: 0x00026A64 File Offset: 0x00024C64
		public event global::System.EventHandler CurrentPageChanged;

		// Token: 0x14000058 RID: 88
		// (add) Token: 0x06000F0D RID: 3853 RVA: 0x00026AA0 File Offset: 0x00024CA0
		// (remove) Token: 0x06000F0E RID: 3854 RVA: 0x00026ADC File Offset: 0x00024CDC
		public event global::System.EventHandler NextEnabledChanged;

		// Token: 0x14000059 RID: 89
		// (add) Token: 0x06000F0F RID: 3855 RVA: 0x00026B18 File Offset: 0x00024D18
		// (remove) Token: 0x06000F10 RID: 3856 RVA: 0x00026B54 File Offset: 0x00024D54
		public event global::System.EventHandler PreviousEnabledChanged;

		// Token: 0x1400005A RID: 90
		// (add) Token: 0x06000F11 RID: 3857 RVA: 0x00026B90 File Offset: 0x00024D90
		// (remove) Token: 0x06000F12 RID: 3858 RVA: 0x00026BCC File Offset: 0x00024DCC
		public event global::System.EventHandler FinishEnabledChanged;

		// Token: 0x1400005B RID: 91
		// (add) Token: 0x06000F13 RID: 3859 RVA: 0x00026C08 File Offset: 0x00024E08
		// (remove) Token: 0x06000F14 RID: 3860 RVA: 0x00026C44 File Offset: 0x00024E44
		public event global::System.EventHandler TitleChanged;

		// Token: 0x1400005C RID: 92
		// (add) Token: 0x06000F15 RID: 3861 RVA: 0x00026C80 File Offset: 0x00024E80
		// (remove) Token: 0x06000F16 RID: 3862 RVA: 0x00026CBC File Offset: 0x00024EBC
		public event global::System.EventHandler CaptionChanged;

		// Token: 0x1400005D RID: 93
		// (add) Token: 0x06000F17 RID: 3863 RVA: 0x00026CF8 File Offset: 0x00024EF8
		// (remove) Token: 0x06000F18 RID: 3864 RVA: 0x00026D34 File Offset: 0x00024F34
		public event global::System.EventHandler<global::Gibraltar.AsyncTaskResultEventArgs> Finished;

		// Token: 0x06000F19 RID: 3865 RVA: 0x00026D70 File Offset: 0x00024F70
		public WizardEngine(string title)
		{
			this.m_WizardTitle = title;
			this.m_CurrentPageIndex = -1;
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x00026D94 File Offset: 0x00024F94
		public void AddPage(global::Gibraltar.Windows.UI.IUIWizardInputPage newPage)
		{
			if (this.m_Locked)
			{
				throw new global::System.InvalidOperationException("The wizard is currently read-only and can't have any pages changed.");
			}
			this.m_WizardPages.Add(newPage);
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00026DB8 File Offset: 0x00024FB8
		public void SetFinishedPage(global::Gibraltar.Windows.UI.IUIWizardFinishPage newPage)
		{
			if (this.m_Locked)
			{
				throw new global::System.InvalidOperationException("The wizard is currently read-only and can't have any pages changed.");
			}
			this.m_FinishedPage = newPage;
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00026DD8 File Offset: 0x00024FD8
		public void SetSequencer(global::Gibraltar.Windows.UI.IUIWizardSequencer sequencer)
		{
			if (this.m_Locked)
			{
				throw new global::System.InvalidOperationException("The wizard is currently read-only and can't have its sequencer changed.");
			}
			this.m_Sequencer = sequencer;
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x00026DF8 File Offset: 0x00024FF8
		public void Start()
		{
			if (this.m_Sequencer == null)
			{
				global::Gibraltar.Windows.UI.WizardEngine.DefaultSequencer defaultSequencer = new global::Gibraltar.Windows.UI.WizardEngine.DefaultSequencer();
				this.SetSequencer(defaultSequencer);
				defaultSequencer.Initialize(this, null);
			}
			if (this.m_FinishedPage == null)
			{
				throw new global::System.InvalidOperationException("There is no finished page defined for the wizard.");
			}
			this.m_Locked = true;
			if (this.m_WizardPages.Count > 0)
			{
				this.SetCurrentPage(this.m_WizardPages[0]);
				return;
			}
			this.SetCurrentPage(this.m_FinishedPage);
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x00026E78 File Offset: 0x00025078
		public void MoveNext()
		{
			if (this.m_CurrentPage == null)
			{
				throw new global::System.InvalidOperationException("There is no current page to move next from.");
			}
			if (!this.m_CurrentPage.IsValid)
			{
				throw new global::System.InvalidOperationException("The current page does not allow moving next at this time.");
			}
			try
			{
				if (((global::Gibraltar.Windows.UI.IUIWizardInputPage)this.m_CurrentPage).Store())
				{
					global::Gibraltar.Windows.UI.IUIWizardPage currentPage = this.m_Sequencer.MoveNext();
					this.SetCurrentPage(currentPage);
				}
			}
			catch (global::System.Exception ex)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Gibraltar.User Interface", "Wizard error moving to next page", "While asking page {0} to move next it reported an exception.  The wizard will not proceed to the next page.\r\nException ({1}): {2}", new object[]
				{
					this.m_CurrentPage.Name,
					ex.GetType().FullName,
					ex.Message
				});
			}
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x00026F3C File Offset: 0x0002513C
		public void MovePrevious()
		{
			if (this.m_CurrentPage == null)
			{
				throw new global::System.InvalidOperationException("There is no current page to move previous from.");
			}
			if (this.m_CurrentPage is global::Gibraltar.Windows.UI.IUIWizardFinishPage || this.m_CurrentPageIndex == 0)
			{
				throw new global::System.InvalidOperationException("The current page does not allow moving previous at this time.");
			}
			try
			{
				global::Gibraltar.Windows.UI.IUIWizardPage currentPage = this.m_Sequencer.MovePrevious();
				this.SetCurrentPage(currentPage);
			}
			catch (global::System.Exception ex)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Gibraltar.User Interface", "Wizard error moving to previous page", "While asking page {0} to move previous it reported an exception.  The wizard will not proceed to the previous page.\r\nException ({1}): {2}", new object[]
				{
					this.m_CurrentPage.Name,
					ex.GetType().FullName,
					ex.Message
				});
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x00026FF8 File Offset: 0x000251F8
		public global::Gibraltar.Windows.UI.IUIWizardPage CurrentPage
		{
			get
			{
				return this.m_CurrentPage;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x00027000 File Offset: 0x00025200
		public global::Gibraltar.Windows.UI.IUIWizardFinishPage FinishedPage
		{
			get
			{
				return this.m_FinishedPage;
			}
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x00027008 File Offset: 0x00025208
		public int CurrentPageIndex
		{
			get
			{
				return this.m_CurrentPageIndex;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x00027010 File Offset: 0x00025210
		public bool CurrentPageIsNull
		{
			get
			{
				return this.m_CurrentPage == null;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x0002701C File Offset: 0x0002521C
		public bool NextEnabled
		{
			get
			{
				return this.m_NextEnabled;
			}
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x00027024 File Offset: 0x00025224
		public bool PreviousEnabled
		{
			get
			{
				return this.m_PreviousEnabled;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06000F26 RID: 3878 RVA: 0x0002702C File Offset: 0x0002522C
		public bool FinishEnabled
		{
			get
			{
				return this.m_FinishEnabled;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x00027034 File Offset: 0x00025234
		public string Title
		{
			get
			{
				return this.m_Title;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06000F28 RID: 3880 RVA: 0x0002703C File Offset: 0x0002523C
		public string Caption
		{
			get
			{
				return this.m_Caption;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x00027044 File Offset: 0x00025244
		public string Instructions
		{
			get
			{
				return this.m_Instructions;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000F2A RID: 3882 RVA: 0x0002704C File Offset: 0x0002524C
		public global::System.Collections.Generic.List<global::Gibraltar.Windows.UI.IUIWizardInputPage> Pages
		{
			get
			{
				return this.m_WizardPages;
			}
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x00027054 File Offset: 0x00025254
		protected virtual void OnCurrentPageChanged()
		{
			global::System.EventHandler currentPageChanged = this.CurrentPageChanged;
			if (currentPageChanged != null)
			{
				currentPageChanged(this, new global::System.EventArgs());
			}
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x00027080 File Offset: 0x00025280
		protected virtual void OnNextEnabledChanged()
		{
			global::System.EventHandler nextEnabledChanged = this.NextEnabledChanged;
			if (nextEnabledChanged != null)
			{
				nextEnabledChanged(this, new global::System.EventArgs());
			}
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x000270AC File Offset: 0x000252AC
		protected virtual void OnPreviousEnabledChanged()
		{
			global::System.EventHandler previousEnabledChanged = this.PreviousEnabledChanged;
			if (previousEnabledChanged != null)
			{
				previousEnabledChanged(this, new global::System.EventArgs());
			}
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x000270D8 File Offset: 0x000252D8
		protected virtual void OnFinishEnabledChanged()
		{
			global::System.EventHandler finishEnabledChanged = this.FinishEnabledChanged;
			if (finishEnabledChanged != null)
			{
				finishEnabledChanged(this, new global::System.EventArgs());
			}
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x00027104 File Offset: 0x00025304
		protected virtual void OnFinished(global::Gibraltar.AsyncTaskResultEventArgs e)
		{
			global::System.EventHandler<global::Gibraltar.AsyncTaskResultEventArgs> finished = this.Finished;
			if (finished != null)
			{
				finished(this, e);
			}
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x0002712C File Offset: 0x0002532C
		protected virtual void OnTitleChanged()
		{
			global::System.EventHandler titleChanged = this.TitleChanged;
			if (titleChanged != null)
			{
				titleChanged(this, new global::System.EventArgs());
			}
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00027158 File Offset: 0x00025358
		protected virtual void OnCaptionChanged()
		{
			global::System.EventHandler captionChanged = this.CaptionChanged;
			if (captionChanged != null)
			{
				captionChanged(this, new global::System.EventArgs());
			}
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00027184 File Offset: 0x00025384
		protected virtual string CalculateTitle()
		{
			string text = this.m_WizardTitle ?? string.Empty;
			if (this.m_WizardPages.Count > 0)
			{
				if (this.m_CurrentPage is global::Gibraltar.Windows.UI.IUIWizardFinishPage)
				{
					text += string.Format(global::Gibraltar.FileSystemTools.UICultureFormat, " Step {0} of {1}", new object[]
					{
						this.m_WizardPages.Count + 1,
						this.m_WizardPages.Count + 1
					});
				}
				else
				{
					text += string.Format(global::Gibraltar.FileSystemTools.UICultureFormat, " Step {0} of {1}", new object[]
					{
						this.m_CurrentPageIndex + 1,
						this.m_WizardPages.Count + 1
					});
				}
			}
			return text;
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00027258 File Offset: 0x00025458
		private void SetCaption()
		{
			this.m_Caption = this.m_CurrentPage.Title;
			this.m_Instructions = this.m_CurrentPage.Instructions;
			this.OnCaptionChanged();
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00027284 File Offset: 0x00025484
		private void SetTitle()
		{
			string title = this.m_Title;
			this.m_Title = this.CalculateTitle();
			this.m_Instructions = this.m_CurrentPage.Instructions;
			if (string.Compare(this.m_Title, title) != 0)
			{
				this.OnTitleChanged();
			}
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x000272D0 File Offset: 0x000254D0
		private void SetCurrentPage(global::Gibraltar.Windows.UI.IUIWizardPage newPage)
		{
			if (newPage == null)
			{
				throw new global::System.ArgumentNullException("newPage");
			}
			if (this.m_CurrentPage != null)
			{
				this.m_CurrentPage.IsValidChanged -= this.CurrentPage_IsValidChanged;
			}
			this.m_CurrentPage = newPage;
			if (this.m_CurrentPage is global::Gibraltar.Windows.UI.IUIWizardInputPage)
			{
				this.m_CurrentPageIndex = this.m_WizardPages.IndexOf((global::Gibraltar.Windows.UI.IUIWizardInputPage)this.m_CurrentPage);
			}
			this.m_CurrentPage.IsValidChanged += this.CurrentPage_IsValidChanged;
			try
			{
				this.m_CurrentPage.OnEnter();
			}
			catch (global::System.Exception ex)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Gibraltar.User Interface", "Wizard error upon entering new page", "Unable to enter wizard page {0} due to an exception.  Page will be displayed anyway, but erratic user results can be expected.\r\nException ({1}): {2}", new object[]
				{
					this.m_CurrentPage.Name,
					ex.GetType().FullName,
					ex.Message
				});
			}
			this.SetTitle();
			this.SetCaption();
			if (this.m_CurrentPage is global::Gibraltar.Windows.UI.IUIWizardFinishPage)
			{
				this.SetCanMovePrevious(false);
				this.SetCanMoveNext(false);
				this.SetCanFinish(this.m_CurrentPage.IsValid);
			}
			else
			{
				this.SetCanMovePrevious(true);
				this.SetCanMoveNext(this.m_CurrentPage.IsValid);
				this.SetCanFinish(false);
			}
			this.OnCurrentPageChanged();
			if (this.m_CurrentPage is global::Gibraltar.Windows.UI.IUIWizardFinishPage)
			{
				global::Gibraltar.AsyncTaskResultEventArgs e = ((global::Gibraltar.Windows.UI.IUIWizardFinishPage)this.m_CurrentPage).Finish();
				this.OnFinished(e);
			}
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00027450 File Offset: 0x00025650
		private void SetCanMovePrevious(bool newValue)
		{
			bool flag = newValue;
			if (this.m_CurrentPage == null)
			{
				flag = false;
			}
			if (this.m_CurrentPageIndex == 0)
			{
				flag = false;
			}
			if (flag != this.m_PreviousEnabled)
			{
				this.m_PreviousEnabled = flag;
				this.OnPreviousEnabledChanged();
			}
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00027498 File Offset: 0x00025698
		private void SetCanMoveNext(bool newValue)
		{
			bool flag = newValue;
			if (this.m_CurrentPage == null)
			{
				flag = false;
			}
			if (this.m_CurrentPage == this.m_FinishedPage)
			{
				flag = false;
			}
			if (flag != this.m_NextEnabled)
			{
				this.m_NextEnabled = flag;
				this.OnNextEnabledChanged();
			}
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x000274E4 File Offset: 0x000256E4
		private void SetCanFinish(bool newValue)
		{
			bool flag = newValue;
			if (this.m_CurrentPage == null)
			{
				flag = false;
			}
			if (flag != this.m_FinishEnabled)
			{
				this.m_FinishEnabled = flag;
				this.OnFinishEnabledChanged();
			}
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00027520 File Offset: 0x00025720
		private void CurrentPage_IsValidChanged(object sender, global::System.EventArgs e)
		{
			if (sender == this.m_CurrentPage)
			{
				this.SetCanMoveNext(this.m_CurrentPage.IsValid);
			}
		}

		// Token: 0x04000501 RID: 1281
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Windows.UI.IUIWizardInputPage> m_WizardPages = new global::System.Collections.Generic.List<global::Gibraltar.Windows.UI.IUIWizardInputPage>();

		// Token: 0x04000502 RID: 1282
		private readonly string m_WizardTitle;

		// Token: 0x04000503 RID: 1283
		private global::Gibraltar.Windows.UI.IUIWizardPage m_CurrentPage;

		// Token: 0x04000504 RID: 1284
		private int m_CurrentPageIndex;

		// Token: 0x04000505 RID: 1285
		private global::Gibraltar.Windows.UI.IUIWizardFinishPage m_FinishedPage;

		// Token: 0x04000506 RID: 1286
		private bool m_Locked;

		// Token: 0x04000507 RID: 1287
		private string m_Title;

		// Token: 0x04000508 RID: 1288
		private string m_Caption;

		// Token: 0x04000509 RID: 1289
		private string m_Instructions;

		// Token: 0x0400050A RID: 1290
		private bool m_NextEnabled;

		// Token: 0x0400050B RID: 1291
		private bool m_PreviousEnabled;

		// Token: 0x0400050C RID: 1292
		private bool m_FinishEnabled;

		// Token: 0x0400050D RID: 1293
		private global::Gibraltar.Windows.UI.IUIWizardSequencer m_Sequencer;

		// Token: 0x0200049E RID: 1182
		private class DefaultSequencer : global::Gibraltar.Windows.UI.IUIWizardSequencer
		{
			// Token: 0x06003341 RID: 13121 RVA: 0x000B9FC4 File Offset: 0x000B81C4
			public void Initialize(global::Gibraltar.Windows.UI.WizardEngine engine, object request)
			{
				this.m_Engine = engine;
				this.m_Request = request;
			}

			// Token: 0x06003342 RID: 13122 RVA: 0x000B9FD4 File Offset: 0x000B81D4
			public global::Gibraltar.Windows.UI.IUIWizardPage MoveNext()
			{
				if (this.m_Engine.CurrentPageIndex < this.m_Engine.Pages.Count - 1)
				{
					return this.m_Engine.Pages[this.m_Engine.CurrentPageIndex + 1];
				}
				return this.m_Engine.FinishedPage;
			}

			// Token: 0x06003343 RID: 13123 RVA: 0x000BA030 File Offset: 0x000B8230
			public global::Gibraltar.Windows.UI.IUIWizardInputPage MovePrevious()
			{
				if (this.m_Engine.CurrentPageIndex > 0 && this.m_Engine.CurrentPage is global::Gibraltar.Windows.UI.IUIWizardInputPage)
				{
					return this.m_Engine.Pages[this.m_Engine.CurrentPageIndex - 1];
				}
				return null;
			}

			// Token: 0x0400137D RID: 4989
			private global::Gibraltar.Windows.UI.WizardEngine m_Engine;

			// Token: 0x0400137E RID: 4990
			private object m_Request;
		}
	}
}
