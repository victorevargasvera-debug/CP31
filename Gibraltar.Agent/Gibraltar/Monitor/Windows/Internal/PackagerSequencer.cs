using System;
using Gibraltar.Data;
using Gibraltar.Windows.UI;

namespace Gibraltar.Monitor.Windows.Internal
{
	// Token: 0x020001EA RID: 490
	internal class PackagerSequencer : global::Gibraltar.Windows.UI.IUIWizardSequencer
	{
		// Token: 0x06001806 RID: 6150 RVA: 0x000515EC File Offset: 0x0004F7EC
		internal PackagerSequencer(global::Gibraltar.Monitor.PackagerConfiguration configuration)
		{
			this.m_Configuration = configuration;
		}

		// Token: 0x06001807 RID: 6151 RVA: 0x000515FC File Offset: 0x0004F7FC
		public void Initialize(global::Gibraltar.Windows.UI.WizardEngine engine, object request)
		{
			this.m_Engine = engine;
			this.m_Request = (global::Gibraltar.Monitor.Windows.Internal.PackagerRequest)request;
		}

		// Token: 0x06001808 RID: 6152 RVA: 0x00051614 File Offset: 0x0004F814
		public global::Gibraltar.Windows.UI.IUIWizardPage MoveNext()
		{
			global::Gibraltar.Windows.UI.IUIWizardPage iuiwizardPage;
			if (this.m_Engine.CurrentPageIndex < this.m_Engine.Pages.Count - 1)
			{
				iuiwizardPage = this.m_Engine.Pages[this.m_Engine.CurrentPageIndex + 1];
				if (iuiwizardPage is global::Gibraltar.Monitor.Windows.Internal.UIPackagerTransport && this.CanUseServer())
				{
					this.m_Request.Transport = global::Gibraltar.Monitor.Windows.Internal.PackageTransport.Server;
					global::Gibraltar.Windows.UI.IUIWizardPage iuiwizardPage3;
					if (this.m_Engine.CurrentPageIndex >= this.m_Engine.Pages.Count - 2)
					{
						global::Gibraltar.Windows.UI.IUIWizardPage iuiwizardPage2 = this.m_Engine.FinishedPage;
						iuiwizardPage3 = iuiwizardPage2;
					}
					else
					{
						global::Gibraltar.Windows.UI.IUIWizardPage iuiwizardPage2 = this.m_Engine.Pages[this.m_Engine.CurrentPageIndex + 2];
						iuiwizardPage3 = iuiwizardPage2;
					}
					iuiwizardPage = iuiwizardPage3;
				}
			}
			else
			{
				iuiwizardPage = this.m_Engine.FinishedPage;
			}
			return iuiwizardPage;
		}

		// Token: 0x06001809 RID: 6153 RVA: 0x000516F0 File Offset: 0x0004F8F0
		public global::Gibraltar.Windows.UI.IUIWizardInputPage MovePrevious()
		{
			if (this.m_Engine.CurrentPageIndex > 0 && this.m_Engine.CurrentPage is global::Gibraltar.Windows.UI.IUIWizardInputPage)
			{
				return this.m_Engine.Pages[this.m_Engine.CurrentPageIndex - 1];
			}
			return null;
		}

		// Token: 0x0600180A RID: 6154 RVA: 0x00051748 File Offset: 0x0004F948
		private bool CanUseServer()
		{
			bool flag = this.m_Request.AllowServer;
			if (flag)
			{
				string text;
				flag = global::Gibraltar.Data.Packager.CanSendToServer(out text);
			}
			return flag;
		}

		// Token: 0x04000866 RID: 2150
		private readonly global::Gibraltar.Monitor.PackagerConfiguration m_Configuration;

		// Token: 0x04000867 RID: 2151
		private global::Gibraltar.Windows.UI.WizardEngine m_Engine;

		// Token: 0x04000868 RID: 2152
		private global::Gibraltar.Monitor.Windows.Internal.PackagerRequest m_Request;
	}
}
