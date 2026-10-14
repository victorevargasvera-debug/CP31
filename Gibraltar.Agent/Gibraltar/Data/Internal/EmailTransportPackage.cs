using System;
using System.IO;
using System.Net.Mail;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Data.Internal
{
	// Token: 0x02000260 RID: 608
	internal class EmailTransportPackage : global::Gibraltar.Data.Internal.TransportPackageBase
	{
		// Token: 0x06001F06 RID: 7942 RVA: 0x000709A0 File Offset: 0x0006EBA0
		public EmailTransportPackage(string product, string application, global::Gibraltar.Data.SimplePackage package) : base(product, application, package)
		{
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06001F07 RID: 7943 RVA: 0x000709AC File Offset: 0x0006EBAC
		// (set) Token: 0x06001F08 RID: 7944 RVA: 0x000709B4 File Offset: 0x0006EBB4
		public string EmailFromAddress { get; set; }

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06001F09 RID: 7945 RVA: 0x000709C0 File Offset: 0x0006EBC0
		// (set) Token: 0x06001F0A RID: 7946 RVA: 0x000709C8 File Offset: 0x0006EBC8
		public string EmailServer { get; set; }

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06001F0B RID: 7947 RVA: 0x000709D4 File Offset: 0x0006EBD4
		// (set) Token: 0x06001F0C RID: 7948 RVA: 0x000709DC File Offset: 0x0006EBDC
		public string EmailServerUser { get; set; }

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06001F0D RID: 7949 RVA: 0x000709E8 File Offset: 0x0006EBE8
		// (set) Token: 0x06001F0E RID: 7950 RVA: 0x000709F0 File Offset: 0x0006EBF0
		public string EmailServerPassword { get; set; }

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06001F0F RID: 7951 RVA: 0x000709FC File Offset: 0x0006EBFC
		// (set) Token: 0x06001F10 RID: 7952 RVA: 0x00070A04 File Offset: 0x0006EC04
		public string EmailToAddress { get; set; }

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06001F11 RID: 7953 RVA: 0x00070A10 File Offset: 0x0006EC10
		// (set) Token: 0x06001F12 RID: 7954 RVA: 0x00070A18 File Offset: 0x0006EC18
		public string EmailSubject { get; set; }

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06001F13 RID: 7955 RVA: 0x00070A24 File Offset: 0x0006EC24
		// (set) Token: 0x06001F14 RID: 7956 RVA: 0x00070A2C File Offset: 0x0006EC2C
		public int EmailServerPort { get; set; }

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06001F15 RID: 7957 RVA: 0x00070A38 File Offset: 0x0006EC38
		// (set) Token: 0x06001F16 RID: 7958 RVA: 0x00070A40 File Offset: 0x0006EC40
		public bool? EmailUseSsl { get; set; }

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06001F17 RID: 7959 RVA: 0x00070A4C File Offset: 0x0006EC4C
		protected string PackageFileNamePath
		{
			get
			{
				return this.m_TemporaryFileNamePath;
			}
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x00070A54 File Offset: 0x0006EC54
		protected void PreparePackage(global::Gibraltar.ProgressMonitorStack progressMonitors)
		{
			if (base.Package.IsDirty && string.IsNullOrEmpty(base.Package.FileNamePath))
			{
				string tempFileName = global::System.IO.Path.GetTempFileName();
				global::System.IO.File.Delete(tempFileName);
				base.Package.Save(progressMonitors, tempFileName);
			}
			this.m_TemporaryFileNamePath = base.Package.FileNamePath;
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x00070AB4 File Offset: 0x0006ECB4
		protected override global::Gibraltar.Data.PackageSendEventArgs OnSend(global::Gibraltar.ProgressMonitorStack progressMonitors)
		{
			int fileSize = 0;
			global::System.Exception exception = null;
			string message;
			global::Gibraltar.AsyncTaskResult result;
			try
			{
				this.PreparePackage(progressMonitors);
				global::System.Net.Mail.MailPriority priority = base.HasProblemSessions ? global::System.Net.Mail.MailPriority.High : global::System.Net.Mail.MailPriority.Normal;
				global::Gibraltar.EmailMessage emailMessage = new global::Gibraltar.EmailMessage(this.EmailFromAddress, this.EmailServer, this.EmailServerUser, this.EmailServerPassword, this.EmailServerPort, this.EmailUseSsl.Value);
				string text = string.Format(global::Gibraltar.FileSystemTools.UICultureFormat, "{0}{1}{2} Sessions.{3}", new object[]
				{
					base.Product,
					string.IsNullOrEmpty(base.Application) ? string.Empty : " ",
					base.Application,
					"glp"
				});
				text = emailMessage.SanitizeFileName(text);
				emailMessage.AddAddress(this.EmailToAddress);
				emailMessage.AddAttachment(this.PackageFileNamePath, text);
				emailMessage.Subject = (string.IsNullOrEmpty(this.EmailSubject) ? base.Package.Caption : this.EmailSubject);
				emailMessage.Body = base.Package.Description;
				emailMessage.Priority = priority;
				emailMessage.Send();
				message = string.Format(global::Gibraltar.FileSystemTools.UICultureFormat, "Email successfully sent to {0}", new object[]
				{
					this.EmailToAddress
				});
				result = global::Gibraltar.AsyncTaskResult.Success;
				fileSize = (int)new global::System.IO.FileInfo(this.PackageFileNamePath).Length;
			}
			catch (global::System.Exception ex)
			{
				result = global::Gibraltar.AsyncTaskResult.Error;
				message = "Unable to send email.\r\n\r\nIt's possible that your mail server is unavailable, your Internet connection is unavailable, or that Antivirus software on your computer is blocking email.\r\n\r\nVerify that you have an active Internet connection and that you don't have software on your computer that will block applications sending email.";
				exception = ex;
			}
			return new global::Gibraltar.Data.PackageSendEventArgs(fileSize, result, message, exception);
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00070C4C File Offset: 0x0006EE4C
		protected override void Dispose(bool releaseManaged)
		{
			base.Dispose(releaseManaged);
			if (releaseManaged)
			{
				try
				{
					global::System.IO.File.Delete(this.m_TemporaryFileNamePath);
				}
				catch (global::System.Exception ex)
				{
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Packager", "Unable to delete temporary working email package file", "Unable to delete temporary working package at {0} due to an exception ({1}): {2}", new object[]
						{
							this.m_TemporaryFileNamePath,
							ex.GetType().FullName,
							ex.Message
						});
					}
				}
			}
		}

		// Token: 0x04000BB0 RID: 2992
		private string m_TemporaryFileNamePath;
	}
}
