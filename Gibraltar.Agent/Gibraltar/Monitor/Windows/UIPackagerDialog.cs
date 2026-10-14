using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Gibraltar.Monitor.Windows.Internal;
using Gibraltar.Windows.UI;

namespace Gibraltar.Monitor.Windows
{
	// Token: 0x020001E4 RID: 484
	internal partial class UIPackagerDialog : UIWizardDialog
	{
		// Token: 0x14000077 RID: 119
		// (add) Token: 0x06001782 RID: 6018 RVA: 0x0004DB80 File Offset: 0x0004BD80
		// (remove) Token: 0x06001783 RID: 6019 RVA: 0x0004DBBC File Offset: 0x0004BDBC
		private event EventHandler<UIPackagerDialog.DialogResultEventArgs> PackagerResult;

		// Token: 0x06001784 RID: 6020 RVA: 0x0004DBF8 File Offset: 0x0004BDF8
		public UIPackagerDialog() : this(false, null, null)
		{
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x0004DC04 File Offset: 0x0004BE04
		public UIPackagerDialog(string productName, string applicationName) : this(true, productName, applicationName)
		{
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x0004DC10 File Offset: 0x0004BE10
		private UIPackagerDialog(bool useProductName, string productName, string applicationName) : base("Health and Usage Reporting Wizard")
		{
			this.InitializeComponent();
			base.EnsureTopMost = true;
			this.m_Configuration = Log.Configuration.Packager;
			if (useProductName && string.IsNullOrEmpty(productName))
			{
				throw new ArgumentNullException("productName", "When specifying a specific product and application, the product name must be specified.");
			}
			this.m_Request = (useProductName ? new PackagerRequest(productName, applicationName) : new PackagerRequest());
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x0004DC94 File Offset: 0x0004BE94
		public static bool RaisePendingToFront()
		{
			object obj = UIPackagerDialog.s_PendingLock;
			bool result;
			lock (obj)
			{
				if (UIPackagerDialog.s_PendingDialog != null)
				{
					result = true;
					UIPackagerDialog.s_PendingDialog.BeginInvoke(new MethodInvoker(UIPackagerDialog.s_PendingDialog.RestoreToFront));
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x0004DCF8 File Offset: 0x0004BEF8
		public void SetEmailServer(string emailServer, int serverPort, bool useSsl, string emailServerUser, string emailServerPassword)
		{
			this.m_Request.EmailServer = emailServer;
			this.m_Request.ServerPort = serverPort;
			this.m_Request.UseSsl = useSsl;
			this.m_Request.EmailServerUser = emailServerUser;
			this.m_Request.EmailServerPassword = emailServerPassword;
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x0004DD48 File Offset: 0x0004BF48
		public DialogResult Send()
		{
			return this.Send(this.m_Configuration.AllowFile, this.m_Configuration.AllowRemovableMedia, this.m_Configuration.AllowEmail, this.m_Configuration.AllowServer, null, null, null);
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x0004DD90 File Offset: 0x0004BF90
		public DialogResult Send(bool allowFile, bool allowRemovableMedia, bool allowEmail, bool allowServer, string destinationAddress, string fromAddress, string fileNamePath)
		{
			if (this.m_DialogHasBeenUsed)
			{
				throw new InvalidOperationException("The packager dialog has already been used once to send a package and can't be reused.");
			}
			this.m_DialogHasBeenUsed = true;
			if (!string.IsNullOrEmpty(destinationAddress))
			{
				this.m_Request.DestinationEmailAddress = destinationAddress;
			}
			else if (!string.IsNullOrEmpty(this.m_Configuration.DestinationEmailAddress))
			{
				this.m_Request.DestinationEmailAddress = this.m_Configuration.DestinationEmailAddress;
			}
			if (!string.IsNullOrEmpty(fromAddress))
			{
				this.m_Request.FromEmailAddress = fromAddress;
			}
			else if (!string.IsNullOrEmpty(this.m_Configuration.FromEmailAddress))
			{
				this.m_Request.FromEmailAddress = this.m_Configuration.FromEmailAddress;
			}
			if (!string.IsNullOrEmpty(fileNamePath))
			{
				this.m_Request.FileNamePath = fileNamePath;
			}
			base.Initialize(this.m_Request);
			base.AddPage(new UIPackagerCriteria(this.m_Configuration));
			bool flag = false;
			if (allowFile)
			{
				this.m_Request.AllowFile = true;
				this.m_Request.Transport = PackageTransport.File;
				flag = true;
			}
			if (allowRemovableMedia)
			{
				this.m_Request.AllowRemovableMedia = true;
				this.m_Request.Transport = PackageTransport.RemovableMedia;
				flag = true;
			}
			if (allowEmail)
			{
				this.m_Request.AllowEmail = true;
				this.m_Request.Transport = PackageTransport.Email;
				flag = true;
			}
			if (allowServer)
			{
				this.m_Request.AllowServer = true;
				this.m_Request.Transport = PackageTransport.Server;
			}
			if (!flag && !allowServer)
			{
				throw new ConfigurationErrorsException("The current configuration disallows all packaging modes, effectively disabling the packager.");
			}
			if (flag)
			{
				base.AddPage(new UIPackagerTransport(this.m_Configuration, this.m_Request));
			}
			base.SetSequencer(new PackagerSequencer(this.m_Configuration));
			base.SetFinishedPage(new UIPackagerFinish(this.m_Configuration));
			return this.JoinShowDialog();
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x0004DF64 File Offset: 0x0004C164
		internal void RestoreToFront()
		{
			if (base.WindowState == FormWindowState.Minimized)
			{
				base.WindowState = FormWindowState.Normal;
			}
			base.TopMost = true;
			base.Visible = true;
			base.TopMost = base.EnsureTopMost;
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x0004DFA4 File Offset: 0x0004C1A4
		private DialogResult JoinShowDialog()
		{
			object resultLock = UIPackagerDialog.s_PendingLock;
			UIPackagerDialog uipackagerDialog;
			lock (resultLock)
			{
				if (UIPackagerDialog.s_PendingDialog == null)
				{
					UIPackagerDialog.s_PendingDialog = this;
					uipackagerDialog = null;
				}
				else
				{
					this.m_Result = DialogResult.None;
					uipackagerDialog = UIPackagerDialog.s_PendingDialog;
					UIPackagerDialog.s_PendingDialog.PackagerResult += this.UIPackagerDialog_PackagerResult;
					uipackagerDialog.BeginInvoke(new MethodInvoker(uipackagerDialog.RestoreToFront));
				}
				Monitor.PulseAll(UIPackagerDialog.s_PendingLock);
			}
			if (uipackagerDialog != null)
			{
				resultLock = this.m_ResultLock;
				lock (resultLock)
				{
					while (this.m_Result == DialogResult.None)
					{
						Monitor.Wait(this.m_ResultLock);
					}
					return this.m_Result;
				}
			}
			DialogResult result = base.ShowDialog();
			resultLock = UIPackagerDialog.s_PendingLock;
			EventHandler<UIPackagerDialog.DialogResultEventArgs> packagerResult;
			lock (resultLock)
			{
				packagerResult = this.PackagerResult;
				UIPackagerDialog.s_PendingDialog = null;
				Monitor.PulseAll(UIPackagerDialog.s_PendingLock);
			}
			if (packagerResult != null)
			{
				packagerResult(this, new UIPackagerDialog.DialogResultEventArgs(result));
			}
			return result;
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x0004E0D4 File Offset: 0x0004C2D4
		private void UIPackagerDialog_PackagerResult(object sender, UIPackagerDialog.DialogResultEventArgs e)
		{
			object resultLock = this.m_ResultLock;
			lock (resultLock)
			{
				this.m_Result = e.Result;
				if (this.m_Result == DialogResult.None)
				{
					this.m_Result = DialogResult.Cancel;
				}
				Monitor.PulseAll(this.m_ResultLock);
			}
		}

		// Token: 0x0400080D RID: 2061
		private readonly PackagerRequest m_Request;

		// Token: 0x0400080E RID: 2062
		private readonly PackagerConfiguration m_Configuration;

		// Token: 0x0400080F RID: 2063
		private bool m_DialogHasBeenUsed;

		// Token: 0x04000810 RID: 2064
		private static readonly object s_PendingLock = new object();

		// Token: 0x04000811 RID: 2065
		private static UIPackagerDialog s_PendingDialog;

		// Token: 0x04000812 RID: 2066
		private readonly object m_ResultLock = new object();

		// Token: 0x04000813 RID: 2067
		private DialogResult m_Result;

		// Token: 0x020004AE RID: 1198
		private class DialogResultEventArgs : EventArgs
		{
			// Token: 0x060033A2 RID: 13218 RVA: 0x000BAA54 File Offset: 0x000B8C54
			public DialogResultEventArgs(DialogResult result)
			{
				this.m_DialogResult = result;
			}

			// Token: 0x17000ED2 RID: 3794
			// (get) Token: 0x060033A3 RID: 13219 RVA: 0x000BAA64 File Offset: 0x000B8C64
			public DialogResult Result
			{
				get
				{
					return this.m_DialogResult;
				}
			}

			// Token: 0x0400139F RID: 5023
			private readonly DialogResult m_DialogResult;
		}
	}
}
