using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace Gibraltar
{
	// Token: 0x020000B1 RID: 177
	internal class EmailMessage
	{
		// Token: 0x0600073A RID: 1850 RVA: 0x0000D0FC File Offset: 0x0000B2FC
		public EmailMessage(string fromAddress)
		{
			if (string.IsNullOrEmpty(fromAddress))
			{
				throw new global::System.ArgumentNullException("fromAddress");
			}
			this.FromAddress = fromAddress;
			this.Priority = global::System.Net.Mail.MailPriority.Normal;
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0000D150 File Offset: 0x0000B350
		public EmailMessage(string fromAddress, string emailServer)
		{
			if (string.IsNullOrEmpty(fromAddress))
			{
				throw new global::System.ArgumentNullException("fromAddress");
			}
			this.FromAddress = fromAddress;
			this.Priority = global::System.Net.Mail.MailPriority.Normal;
			this.EmailServer = global::Gibraltar.EmailMessage.StandardizeEmptyString(emailServer);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0000D1B0 File Offset: 0x0000B3B0
		public EmailMessage(string fromAddress, string emailServer, string emailServerUser, string emailServerPassword)
		{
			if (string.IsNullOrEmpty(fromAddress))
			{
				throw new global::System.ArgumentNullException("fromAddress");
			}
			this.FromAddress = fromAddress;
			this.Priority = global::System.Net.Mail.MailPriority.Normal;
			this.EmailServer = global::Gibraltar.EmailMessage.StandardizeEmptyString(emailServer);
			if (!string.IsNullOrEmpty(this.EmailServer))
			{
				this.EmailServerPassword = global::Gibraltar.EmailMessage.StandardizeEmptyString(emailServerPassword);
				if (!string.IsNullOrEmpty(this.EmailServerPassword))
				{
					this.EmailServerUser = global::Gibraltar.EmailMessage.StandardizeEmptyString(emailServerUser);
				}
			}
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0000D248 File Offset: 0x0000B448
		public EmailMessage(string fromAddress, string emailServer, string emailServerUser, string emailServerPassword, int serverPort, bool useSsl) : this(fromAddress, emailServer, emailServerUser, emailServerPassword)
		{
			this.ServerPort = serverPort;
			this.UseSsl = useSsl;
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0000D268 File Offset: 0x0000B468
		public string SanitizeFileName(string originalFileName)
		{
			string text = originalFileName;
			foreach (char oldChar in global::System.IO.Path.GetInvalidFileNameChars())
			{
				text = text.Replace(oldChar, '_');
			}
			return text;
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0000D2A4 File Offset: 0x0000B4A4
		public void AddAddress(string newAddress)
		{
			string text = global::Gibraltar.EmailMessage.StandardizeEmptyString(newAddress);
			if (text != null)
			{
				this.m_Addresses.Add(text);
			}
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0000D2D0 File Offset: 0x0000B4D0
		public void AddAttachment(string fileNamePath)
		{
			if (global::Gibraltar.EmailMessage.StandardizeEmptyString(fileNamePath) != null)
			{
				this.m_Attachments.Add(new global::Gibraltar.NameValuePair<string>(fileNamePath, string.Empty));
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0000D2F4 File Offset: 0x0000B4F4
		public void AddAttachment(string fileNamePath, string displayName)
		{
			if (global::Gibraltar.EmailMessage.StandardizeEmptyString(fileNamePath) != null)
			{
				this.m_Attachments.Add(new global::Gibraltar.NameValuePair<string>(fileNamePath, displayName));
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x0000D314 File Offset: 0x0000B514
		// (set) Token: 0x06000743 RID: 1859 RVA: 0x0000D31C File Offset: 0x0000B51C
		public string Body { get; set; }

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x0000D328 File Offset: 0x0000B528
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x0000D330 File Offset: 0x0000B530
		public string EmailServer { get; private set; }

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x0000D33C File Offset: 0x0000B53C
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x0000D344 File Offset: 0x0000B544
		public string EmailServerUser { get; private set; }

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x0000D350 File Offset: 0x0000B550
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x0000D358 File Offset: 0x0000B558
		public string EmailServerPassword { get; private set; }

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x0000D364 File Offset: 0x0000B564
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x0000D36C File Offset: 0x0000B56C
		public string FromAddress { get; set; }

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x0000D378 File Offset: 0x0000B578
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x0000D380 File Offset: 0x0000B580
		public int ServerPort { get; set; }

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x0600074E RID: 1870 RVA: 0x0000D38C File Offset: 0x0000B58C
		// (set) Token: 0x0600074F RID: 1871 RVA: 0x0000D394 File Offset: 0x0000B594
		public bool UseSsl { get; set; }

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x0000D3A0 File Offset: 0x0000B5A0
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x0000D3A8 File Offset: 0x0000B5A8
		public bool IsBodyHTML { get; set; }

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x0000D3B4 File Offset: 0x0000B5B4
		// (set) Token: 0x06000753 RID: 1875 RVA: 0x0000D3BC File Offset: 0x0000B5BC
		public global::System.Net.Mail.MailPriority Priority { get; set; }

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x0000D3D0 File Offset: 0x0000B5D0
		public string Subject { get; set; }

		// Token: 0x06000756 RID: 1878 RVA: 0x0000D3DC File Offset: 0x0000B5DC
		public void Send()
		{
			this.SendEmail();
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0000D3E4 File Offset: 0x0000B5E4
		private static string StandardizeEmptyString(string original)
		{
			if (string.IsNullOrEmpty(original))
			{
				return null;
			}
			string text = original.Trim();
			if (string.IsNullOrEmpty(text))
			{
				return null;
			}
			return text;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0000D418 File Offset: 0x0000B618
		private void SendEmail()
		{
			global::System.Collections.Generic.List<global::System.IO.Stream> list = new global::System.Collections.Generic.List<global::System.IO.Stream>();
			try
			{
				using (global::System.Net.Mail.MailMessage mailMessage = new global::System.Net.Mail.MailMessage())
				{
					mailMessage.From = new global::System.Net.Mail.MailAddress(this.FromAddress);
					foreach (string address in this.m_Addresses)
					{
						mailMessage.To.Add(new global::System.Net.Mail.MailAddress(address));
					}
					mailMessage.Subject = this.Subject;
					mailMessage.IsBodyHtml = this.IsBodyHTML;
					mailMessage.Priority = this.Priority;
					mailMessage.Body = this.Body;
					foreach (global::Gibraltar.NameValuePair<string> nameValuePair in this.m_Attachments)
					{
						global::System.Net.Mail.Attachment item;
						if (string.IsNullOrEmpty(nameValuePair.Value))
						{
							item = new global::System.Net.Mail.Attachment(nameValuePair.Name);
						}
						else
						{
							global::System.IO.Stream stream = global::System.IO.File.OpenRead(nameValuePair.Name);
							list.Add(stream);
							item = new global::System.Net.Mail.Attachment(stream, nameValuePair.Value);
						}
						mailMessage.Attachments.Add(item);
					}
					this.GetSmtpClient().Send(mailMessage);
				}
			}
			finally
			{
				foreach (global::System.IO.Stream stream2 in list)
				{
					stream2.Dispose();
				}
			}
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0000D618 File Offset: 0x0000B818
		private global::System.Net.Mail.SmtpClient GetSmtpClient()
		{
			global::System.Net.Mail.SmtpClient smtpClient = string.IsNullOrEmpty(this.EmailServer) ? new global::System.Net.Mail.SmtpClient() : ((this.ServerPort == 0) ? new global::System.Net.Mail.SmtpClient(this.EmailServer) : new global::System.Net.Mail.SmtpClient(this.EmailServer, this.ServerPort));
			smtpClient.Credentials = ((!string.IsNullOrEmpty(this.EmailServerPassword)) ? new global::System.Net.NetworkCredential(this.EmailServerUser, this.EmailServerPassword) : global::System.Net.CredentialCache.DefaultNetworkCredentials);
			smtpClient.EnableSsl = this.UseSsl;
			smtpClient.Timeout = 600000;
			return smtpClient;
		}

		// Token: 0x04000157 RID: 343
		private readonly global::System.Collections.Generic.List<string> m_Addresses = new global::System.Collections.Generic.List<string>();

		// Token: 0x04000158 RID: 344
		private readonly global::System.Collections.Generic.List<global::Gibraltar.NameValuePair<string>> m_Attachments = new global::System.Collections.Generic.List<global::Gibraltar.NameValuePair<string>>();
	}
}
