using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Gibraltar.Data;
using Gibraltar.Windows.UI;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Windows
{
	// Token: 0x020001D9 RID: 473
	internal partial class AutoSendConsentDialog : Form
	{
		// Token: 0x0600168D RID: 5773 RVA: 0x000467A0 File Offset: 0x000449A0
		public AutoSendConsentDialog()
		{
			this.InitializeComponent();
			FormTools.ApplyOSFont(this);
			this.lblDescription.Font = FormTools.OSFont;
			this.linkPrivacyPolicy.Font = FormTools.OSFont;
			this.optOptIn.Font = FormTools.OSFont;
			this.optOptOut.Font = FormTools.OSFont;
			this.m_ReferenceTitle = this.Text;
			this.m_ReferenceCaption = this.lblCaption.Text;
			this.m_ReferenceDescription = this.lblDescription.Text;
			this.m_ReferenceLinkCaption = this.linkPrivacyPolicy.Text;
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00046844 File Offset: 0x00044A44
		public DialogResult UpdateConsent(AutoSendConsent consent, string privacyPolicyUrl, string serviceName, string companyName)
		{
			if (consent == null)
			{
				throw new ArgumentNullException("consent");
			}
			SessionSummary sessionSummary = Log.SessionSummary;
			this.m_ProductName = sessionSummary.Product;
			this.m_CompanyName = companyName;
			this.m_CeipName = serviceName;
			this.m_PrivacyPolicyUrl = privacyPolicyUrl;
			this.Text = this.PerformSubstitution(this.m_ReferenceTitle);
			this.lblCaption.Text = this.PerformSubstitution(this.m_ReferenceCaption);
			this.lblDescription.Text = this.PerformSubstitution(this.m_ReferenceDescription);
			if (string.IsNullOrEmpty(privacyPolicyUrl))
			{
				this.linkPrivacyPolicy.Visible = false;
			}
			else
			{
				this.linkPrivacyPolicy.Text = this.PerformSubstitution(this.m_ReferenceLinkCaption);
				this.linkPrivacyPolicy.Visible = true;
			}
			if (!consent.SelectionMade)
			{
				this.optOptIn.Checked = false;
				this.optOptOut.Checked = false;
			}
			else if (consent.OptIn)
			{
				this.optOptIn.Checked = true;
			}
			else
			{
				this.optOptOut.Checked = true;
			}
			this.ValidateData();
			DialogResult dialogResult = base.ShowDialog();
			if (dialogResult == DialogResult.OK)
			{
				consent.SelectionMade = true;
				consent.UserPrompts = 0;
				consent.OptIn = this.optOptIn.Checked;
				consent.IncludeDetails = consent.OptIn;
			}
			return dialogResult;
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x0004699C File Offset: 0x00044B9C
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			Icon icon = null;
			try
			{
				icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
			}
			catch
			{
			}
			if (icon != null)
			{
				base.Icon = icon;
				this.m_DisplayIcon = icon;
				return;
			}
			base.Icon = SystemIcons.Question;
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x000469F8 File Offset: 0x00044BF8
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			if (this.m_DisplayIcon != null)
			{
				this.messageFlowLayout.Left = this.messageFlowLayout.Margin.Left + this.m_DisplayIcon.Width + this.messageFlowLayout.Margin.Left;
				e.Graphics.DrawIcon(this.m_DisplayIcon, this.messageFlowLayout.Margin.Left, this.messageFlowLayout.Margin.Top);
				return;
			}
			Point point = new Point(this.messageFlowLayout.Margin.Top, this.messageFlowLayout.Margin.Right);
			if (this.messageFlowLayout.Location != point)
			{
				this.messageFlowLayout.Location = point;
				this.messageFlowLayout.Width = base.Width - (this.messageFlowLayout.Left + this.messageFlowLayout.Margin.Right);
			}
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x00046B14 File Offset: 0x00044D14
		private string PerformSubstitution(string original)
		{
			return original.Replace("{ProductName}", this.m_ProductName).Replace("{CompanyName}", this.m_CompanyName).Replace("{CeipName}", this.m_CeipName);
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x00046B48 File Offset: 0x00044D48
		private void ValidateData()
		{
			bool enabled = true;
			if (!this.optOptIn.Checked && !this.optOptOut.Checked)
			{
				enabled = false;
			}
			this.btnSave.Enabled = enabled;
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00046B8C File Offset: 0x00044D8C
		private void optOptIn_CheckedChanged(object sender, EventArgs e)
		{
			this.ValidateData();
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x00046B94 File Offset: 0x00044D94
		private void optOptOut_CheckedChanged(object sender, EventArgs e)
		{
			this.ValidateData();
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x00046B9C File Offset: 0x00044D9C
		private void linkPrivacyPolicy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (!string.IsNullOrEmpty(this.m_PrivacyPolicyUrl))
			{
				SessionSummary sessionSummary = Log.SessionSummary;
				Version applicationVersion = sessionSummary.ApplicationVersion;
				string text = string.Format("{0}?productName={1}&applicationName={2}&majorVer={3}&minorVer={4}", new object[]
				{
					this.m_PrivacyPolicyUrl,
					sessionSummary.Product,
					sessionSummary.Application,
					applicationVersion.Major,
					applicationVersion.Minor
				});
				if (applicationVersion.Build >= 0)
				{
					text += string.Format("&build={0}", applicationVersion.Build);
					if (applicationVersion.Revision >= 0)
					{
						text += string.Format("&revisionVer={0}", applicationVersion.Revision);
					}
				}
				try
				{
					Process.Start(text);
				}
				catch (Exception ex)
				{
					if (!Log.SilentMode)
					{
						Log.Write(LogMessageSeverity.Warning, LogWriteMode.Queued, ex, "Loupe.Agent.Consent", "Unable to display privacy policy web page", "While attempting to display the web page an exception was thrown.\r\nComplete URL: {0}\r\nException: {1}", new object[]
						{
							text,
							ex.Message
						});
					}
				}
			}
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x00046CB8 File Offset: 0x00044EB8
		private void messageFlowLayout_Resize(object sender, EventArgs e)
		{
			int num = this.messageFlowLayout.Top + this.messageFlowLayout.Height + this.messageFlowLayout.Margin.Bottom + this.buttonPanel.Height;
			base.Height = base.Height - base.ClientSize.Height + num;
		}

		// Token: 0x04000770 RID: 1904
		private const string ProductNameToken = "{ProductName}";

		// Token: 0x04000771 RID: 1905
		private const string CeipNameToken = "{CeipName}";

		// Token: 0x04000772 RID: 1906
		private const string CompanyNameToken = "{CompanyName}";

		// Token: 0x04000773 RID: 1907
		private readonly string m_ReferenceTitle;

		// Token: 0x04000774 RID: 1908
		private readonly string m_ReferenceCaption;

		// Token: 0x04000775 RID: 1909
		private readonly string m_ReferenceDescription;

		// Token: 0x04000776 RID: 1910
		private readonly string m_ReferenceLinkCaption;

		// Token: 0x04000777 RID: 1911
		private Icon m_DisplayIcon;

		// Token: 0x04000778 RID: 1912
		private string m_ProductName;

		// Token: 0x04000779 RID: 1913
		private string m_CompanyName;

		// Token: 0x0400077A RID: 1914
		private string m_CeipName;

		// Token: 0x0400077B RID: 1915
		private string m_PrivacyPolicyUrl;
	}
}
