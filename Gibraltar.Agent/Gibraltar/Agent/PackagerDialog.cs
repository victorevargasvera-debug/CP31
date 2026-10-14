using System;
using System.Windows.Forms;
using Gibraltar.Monitor;
using Gibraltar.Monitor.Windows;

namespace Gibraltar.Agent
{
	// Token: 0x0200000F RID: 15
	public sealed class PackagerDialog
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x000046D4 File Offset: 0x000028D4
		public PackagerDialog()
		{
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000046DC File Offset: 0x000028DC
		public PackagerDialog(string productName, string applicationName)
		{
			this.m_UseProductFilter = true;
			this.m_ProductName = productName;
			this.m_ApplicationName = applicationName;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x000046FC File Offset: 0x000028FC
		public global::System.Windows.Forms.DialogResult Send()
		{
			global::System.Windows.Forms.DialogResult result;
			using (global::Gibraltar.Monitor.Windows.UIPackagerDialog packagerDialog = this.GetPackagerDialog())
			{
				result = packagerDialog.Send();
			}
			return result;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000473C File Offset: 0x0000293C
		public global::System.Windows.Forms.DialogResult SendEmail()
		{
			global::System.Windows.Forms.DialogResult result;
			using (global::Gibraltar.Monitor.Windows.UIPackagerDialog packagerDialog = this.GetPackagerDialog())
			{
				result = packagerDialog.Send(false, false, true, false, null, null, null);
			}
			return result;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00004784 File Offset: 0x00002984
		public global::System.Windows.Forms.DialogResult SendEmail(string destinationAddress, string fromAddress)
		{
			global::System.Windows.Forms.DialogResult result;
			using (global::Gibraltar.Monitor.Windows.UIPackagerDialog packagerDialog = this.GetPackagerDialog())
			{
				result = packagerDialog.Send(false, false, true, false, destinationAddress, fromAddress, null);
			}
			return result;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000047CC File Offset: 0x000029CC
		public global::System.Windows.Forms.DialogResult SendToFile()
		{
			global::System.Windows.Forms.DialogResult result;
			using (global::Gibraltar.Monitor.Windows.UIPackagerDialog packagerDialog = this.GetPackagerDialog())
			{
				result = packagerDialog.Send(true, false, false, false, null, null, null);
			}
			return result;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00004814 File Offset: 0x00002A14
		public global::System.Windows.Forms.DialogResult SendToFile(string fileNamePath)
		{
			global::System.Windows.Forms.DialogResult result;
			using (global::Gibraltar.Monitor.Windows.UIPackagerDialog packagerDialog = this.GetPackagerDialog())
			{
				result = packagerDialog.Send(true, false, false, false, null, null, fileNamePath);
			}
			return result;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000485C File Offset: 0x00002A5C
		public global::System.Windows.Forms.DialogResult SendToServer()
		{
			global::System.Windows.Forms.DialogResult result;
			using (global::Gibraltar.Monitor.Windows.UIPackagerDialog packagerDialog = this.GetPackagerDialog())
			{
				result = packagerDialog.Send(false, false, false, true, null, null, null);
			}
			return result;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000048A4 File Offset: 0x00002AA4
		public void SetEmailServer(string emailServer, int serverPort, bool useSsl, string emailServerUser, string emailServerPassword)
		{
			this.m_EmailServer = emailServer;
			this.m_ServerPort = serverPort;
			this.m_UseSsl = useSsl;
			this.m_EmailServerUser = emailServerUser;
			this.m_EmailServerPassword = emailServerPassword;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000048CC File Offset: 0x00002ACC
		private global::Gibraltar.Monitor.Windows.UIPackagerDialog GetPackagerDialog()
		{
			global::Gibraltar.Monitor.Log.IsLoggingActive(false);
			global::Gibraltar.Monitor.Windows.UIPackagerDialog uipackagerDialog = this.m_UseProductFilter ? new global::Gibraltar.Monitor.Windows.UIPackagerDialog(this.m_ProductName, this.m_ApplicationName) : new global::Gibraltar.Monitor.Windows.UIPackagerDialog();
			if (!string.IsNullOrEmpty(this.m_EmailServer))
			{
				uipackagerDialog.SetEmailServer(this.m_EmailServer, this.m_ServerPort, this.m_UseSsl, this.m_EmailServerUser, this.m_EmailServerPassword);
			}
			return uipackagerDialog;
		}

		// Token: 0x04000035 RID: 53
		private readonly bool m_UseProductFilter;

		// Token: 0x04000036 RID: 54
		private readonly string m_ProductName;

		// Token: 0x04000037 RID: 55
		private readonly string m_ApplicationName;

		// Token: 0x04000038 RID: 56
		private string m_EmailServer;

		// Token: 0x04000039 RID: 57
		private int m_ServerPort;

		// Token: 0x0400003A RID: 58
		private bool m_UseSsl;

		// Token: 0x0400003B RID: 59
		private string m_EmailServerUser;

		// Token: 0x0400003C RID: 60
		private string m_EmailServerPassword;
	}
}
