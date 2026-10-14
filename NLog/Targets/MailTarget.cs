using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Text;
using JetBrains.Annotations;
using NLog.Common;
using NLog.Config;
using NLog.Internal;
using NLog.Layouts;

namespace NLog.Targets
{
	// Token: 0x02000042 RID: 66
	[global::NLog.Targets.Target("Mail")]
	public class MailTarget : global::NLog.Targets.TargetWithLayoutHeaderAndFooter
	{
		// Token: 0x0600064F RID: 1615 RVA: 0x0000F85C File Offset: 0x0000DA5C
		public MailTarget()
		{
			this.Body = "${message}${newline}";
			this.Subject = "Message from NLog on ${machinename}";
			this.Encoding = global::System.Text.Encoding.UTF8;
			this.SmtpPort = 25;
			this.SmtpAuthentication = global::NLog.Targets.SmtpAuthenticationMode.None;
			this.Timeout = 10000;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x0000F8B4 File Offset: 0x0000DAB4
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x0000F928 File Offset: 0x0000DB28
		internal global::System.Net.Configuration.SmtpSection SmtpSection
		{
			get
			{
				if (this._currentailSettings == null)
				{
					try
					{
						this._currentailSettings = (global::System.Configuration.ConfigurationManager.GetSection("system.net/mailSettings/smtp") as global::System.Net.Configuration.SmtpSection);
					}
					catch (global::System.Exception ex)
					{
						global::NLog.Common.InternalLogger.Warn(ex, "MailTarget(Name={0}): Reading 'From' from .config failed.", new object[]
						{
							base.Name
						});
						if (ex.MustBeRethrown())
						{
							throw;
						}
						this._currentailSettings = new global::System.Net.Configuration.SmtpSection();
					}
				}
				return this._currentailSettings;
			}
			set
			{
				this._currentailSettings = value;
			}
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0000F931 File Offset: 0x0000DB31
		public MailTarget(string name) : this()
		{
			base.Name = name;
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000653 RID: 1619 RVA: 0x0000F940 File Offset: 0x0000DB40
		// (set) Token: 0x06000654 RID: 1620 RVA: 0x0000F97B File Offset: 0x0000DB7B
		public global::NLog.Layouts.Layout From
		{
			get
			{
				if (!this.UseSystemNetMailSettings || this._from != null)
				{
					return this._from;
				}
				string from = this.SmtpSection.From;
				if (from == null)
				{
					return null;
				}
				return from;
			}
			set
			{
				this._from = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000655 RID: 1621 RVA: 0x0000F984 File Offset: 0x0000DB84
		// (set) Token: 0x06000656 RID: 1622 RVA: 0x0000F98C File Offset: 0x0000DB8C
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Layouts.Layout To { get; set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x0000F995 File Offset: 0x0000DB95
		// (set) Token: 0x06000658 RID: 1624 RVA: 0x0000F99D File Offset: 0x0000DB9D
		public global::NLog.Layouts.Layout CC { get; set; }

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x0000F9A6 File Offset: 0x0000DBA6
		// (set) Token: 0x0600065A RID: 1626 RVA: 0x0000F9AE File Offset: 0x0000DBAE
		public global::NLog.Layouts.Layout Bcc { get; set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600065B RID: 1627 RVA: 0x0000F9B7 File Offset: 0x0000DBB7
		// (set) Token: 0x0600065C RID: 1628 RVA: 0x0000F9BF File Offset: 0x0000DBBF
		public bool AddNewLines { get; set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600065D RID: 1629 RVA: 0x0000F9C8 File Offset: 0x0000DBC8
		// (set) Token: 0x0600065E RID: 1630 RVA: 0x0000F9D0 File Offset: 0x0000DBD0
		[global::System.ComponentModel.DefaultValue("Message from NLog on ${machinename}")]
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Layouts.Layout Subject { get; set; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600065F RID: 1631 RVA: 0x0000F9D9 File Offset: 0x0000DBD9
		// (set) Token: 0x06000660 RID: 1632 RVA: 0x0000F9E1 File Offset: 0x0000DBE1
		[global::System.ComponentModel.DefaultValue("${message}${newline}")]
		public global::NLog.Layouts.Layout Body
		{
			get
			{
				return this.Layout;
			}
			set
			{
				this.Layout = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x0000F9EA File Offset: 0x0000DBEA
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x0000F9F2 File Offset: 0x0000DBF2
		[global::System.ComponentModel.DefaultValue("UTF8")]
		public global::System.Text.Encoding Encoding { get; set; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x0000F9FB File Offset: 0x0000DBFB
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x0000FA03 File Offset: 0x0000DC03
		[global::System.ComponentModel.DefaultValue(false)]
		public bool Html { get; set; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x0000FA0C File Offset: 0x0000DC0C
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x0000FA14 File Offset: 0x0000DC14
		public global::NLog.Layouts.Layout SmtpServer { get; set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0000FA1D File Offset: 0x0000DC1D
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x0000FA25 File Offset: 0x0000DC25
		[global::System.ComponentModel.DefaultValue("None")]
		public global::NLog.Targets.SmtpAuthenticationMode SmtpAuthentication { get; set; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x0000FA2E File Offset: 0x0000DC2E
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x0000FA36 File Offset: 0x0000DC36
		public global::NLog.Layouts.Layout SmtpUserName { get; set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x0000FA3F File Offset: 0x0000DC3F
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x0000FA47 File Offset: 0x0000DC47
		public global::NLog.Layouts.Layout SmtpPassword { get; set; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x0000FA50 File Offset: 0x0000DC50
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x0000FA58 File Offset: 0x0000DC58
		[global::System.ComponentModel.DefaultValue(false)]
		public bool EnableSsl { get; set; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x0000FA61 File Offset: 0x0000DC61
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x0000FA69 File Offset: 0x0000DC69
		[global::System.ComponentModel.DefaultValue(25)]
		public int SmtpPort { get; set; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000671 RID: 1649 RVA: 0x0000FA72 File Offset: 0x0000DC72
		// (set) Token: 0x06000672 RID: 1650 RVA: 0x0000FA7A File Offset: 0x0000DC7A
		[global::System.ComponentModel.DefaultValue(false)]
		public bool UseSystemNetMailSettings { get; set; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000673 RID: 1651 RVA: 0x0000FA83 File Offset: 0x0000DC83
		// (set) Token: 0x06000674 RID: 1652 RVA: 0x0000FA8B File Offset: 0x0000DC8B
		[global::System.ComponentModel.DefaultValue(global::System.Net.Mail.SmtpDeliveryMethod.Network)]
		public global::System.Net.Mail.SmtpDeliveryMethod DeliveryMethod { get; set; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x0000FA94 File Offset: 0x0000DC94
		// (set) Token: 0x06000676 RID: 1654 RVA: 0x0000FA9C File Offset: 0x0000DC9C
		[global::System.ComponentModel.DefaultValue(null)]
		public string PickupDirectoryLocation { get; set; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x0000FAA5 File Offset: 0x0000DCA5
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x0000FAAD File Offset: 0x0000DCAD
		public global::NLog.Layouts.Layout Priority { get; set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x0000FAB6 File Offset: 0x0000DCB6
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x0000FABE File Offset: 0x0000DCBE
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ReplaceNewlineWithBrTagInHtml { get; set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x0000FAC7 File Offset: 0x0000DCC7
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x0000FACF File Offset: 0x0000DCCF
		[global::System.ComponentModel.DefaultValue(10000)]
		public int Timeout { get; set; }

		// Token: 0x0600067D RID: 1661 RVA: 0x0000FAD8 File Offset: 0x0000DCD8
		internal virtual global::NLog.Internal.ISmtpClient CreateSmtpClient()
		{
			return new global::NLog.Internal.MySmtpClient();
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0000FADF File Offset: 0x0000DCDF
		protected override void Write(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			this.Write(new global::NLog.Common.AsyncLogEventInfo[]
			{
				logEvent
			});
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0000FAF5 File Offset: 0x0000DCF5
		[global::System.Obsolete("Instead override Write(IList<AsyncLogEventInfo> logEvents. Marked obsolete on NLog 4.5")]
		protected override void Write(global::NLog.Common.AsyncLogEventInfo[] logEvents)
		{
			this.Write(logEvents);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0000FB00 File Offset: 0x0000DD00
		protected override void Write(global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo> logEvents)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo>> keyValuePair in logEvents.BucketSort((global::NLog.Common.AsyncLogEventInfo c) => this.GetSmtpSettingsKey(c.LogEvent)))
			{
				global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo> value = keyValuePair.Value;
				this.ProcessSingleMailMessage(value);
			}
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0000FB6C File Offset: 0x0000DD6C
		protected override void InitializeTarget()
		{
			this.CheckRequiredParameters();
			base.InitializeTarget();
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0000FB7C File Offset: 0x0000DD7C
		private void ProcessSingleMailMessage([global::JetBrains.Annotations.NotNull] global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo> events)
		{
			try
			{
				if (events.Count == 0)
				{
					throw new global::NLog.NLogRuntimeException("We need at least one event.");
				}
				global::NLog.LogEventInfo logEvent = events[0].LogEvent;
				global::NLog.LogEventInfo logEvent2 = events[events.Count - 1].LogEvent;
				global::System.Text.StringBuilder stringBuilder = this.CreateBodyBuffer(events, logEvent, logEvent2);
				using (global::System.Net.Mail.MailMessage mailMessage = this.CreateMailMessage(logEvent2, stringBuilder.ToString()))
				{
					using (global::NLog.Internal.ISmtpClient smtpClient = this.CreateSmtpClient())
					{
						if (!this.UseSystemNetMailSettings)
						{
							this.ConfigureMailClient(logEvent2, smtpClient);
						}
						if (smtpClient.EnableSsl)
						{
							global::NLog.Common.InternalLogger.Debug("MailTarget(Name={0}): Sending mail to {1} using {2}:{3} (ssl=true)", new object[]
							{
								base.Name,
								mailMessage.To,
								smtpClient.Host,
								smtpClient.Port
							});
						}
						else
						{
							global::NLog.Common.InternalLogger.Debug("MailTarget(Name={0}): Sending mail to {1} using {2}:{3} (ssl=false)", new object[]
							{
								base.Name,
								mailMessage.To,
								smtpClient.Host,
								smtpClient.Port
							});
						}
						global::NLog.Common.InternalLogger.Trace<string, string>("MailTarget(Name={0}):   Subject: '{1}'", base.Name, mailMessage.Subject);
						global::NLog.Common.InternalLogger.Trace<string, string>("MailTarget(Name={0}):   From: '{1}'", base.Name, mailMessage.From.ToString());
						smtpClient.Send(mailMessage);
						foreach (global::NLog.Common.AsyncLogEventInfo asyncLogEventInfo in events)
						{
							asyncLogEventInfo.Continuation(null);
						}
					}
				}
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Error(ex, "MailTarget(Name={0}): Error sending mail.", new object[]
				{
					base.Name
				});
				if (ex.MustBeRethrown())
				{
					throw;
				}
				foreach (global::NLog.Common.AsyncLogEventInfo asyncLogEventInfo2 in events)
				{
					asyncLogEventInfo2.Continuation(ex);
				}
			}
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0000FDE8 File Offset: 0x0000DFE8
		private global::System.Text.StringBuilder CreateBodyBuffer(global::System.Collections.Generic.IEnumerable<global::NLog.Common.AsyncLogEventInfo> events, global::NLog.LogEventInfo firstEvent, global::NLog.LogEventInfo lastEvent)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (base.Header != null)
			{
				stringBuilder.Append(base.Header.Render(firstEvent));
				if (this.AddNewLines)
				{
					stringBuilder.Append("\n");
				}
			}
			foreach (global::NLog.Common.AsyncLogEventInfo asyncLogEventInfo in events)
			{
				stringBuilder.Append(this.Layout.Render(asyncLogEventInfo.LogEvent));
				if (this.AddNewLines)
				{
					stringBuilder.Append("\n");
				}
			}
			if (base.Footer != null)
			{
				stringBuilder.Append(base.Footer.Render(lastEvent));
				if (this.AddNewLines)
				{
					stringBuilder.Append("\n");
				}
			}
			return stringBuilder;
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0000FEBC File Offset: 0x0000E0BC
		internal void ConfigureMailClient(global::NLog.LogEventInfo lastEvent, global::NLog.Internal.ISmtpClient client)
		{
			this.CheckRequiredParameters();
			if (this.SmtpServer == null && string.IsNullOrEmpty(this.PickupDirectoryLocation))
			{
				throw new global::NLog.NLogRuntimeException(string.Format("After the processing of the MailTarget's '{0}' property it appears to be empty. The email message will not be sent.", "SmtpServer/PickupDirectoryLocation"));
			}
			if (this.DeliveryMethod == global::System.Net.Mail.SmtpDeliveryMethod.Network && this.SmtpServer == null)
			{
				throw new global::NLog.NLogRuntimeException(string.Format("After the processing of the MailTarget's '{0}' property it appears to be empty. The email message will not be sent.", "SmtpServer"));
			}
			if (this.DeliveryMethod == global::System.Net.Mail.SmtpDeliveryMethod.SpecifiedPickupDirectory && string.IsNullOrEmpty(this.PickupDirectoryLocation))
			{
				throw new global::NLog.NLogRuntimeException(string.Format("After the processing of the MailTarget's '{0}' property it appears to be empty. The email message will not be sent.", "PickupDirectoryLocation"));
			}
			if (this.SmtpServer != null && this.DeliveryMethod == global::System.Net.Mail.SmtpDeliveryMethod.Network)
			{
				string text = this.SmtpServer.Render(lastEvent);
				if (string.IsNullOrEmpty(text))
				{
					throw new global::NLog.NLogRuntimeException(string.Format("After the processing of the MailTarget's '{0}' property it appears to be empty. The email message will not be sent.", "SmtpServer"));
				}
				client.Host = text;
				client.Port = this.SmtpPort;
				client.EnableSsl = this.EnableSsl;
				if (this.SmtpAuthentication == global::NLog.Targets.SmtpAuthenticationMode.Ntlm)
				{
					global::NLog.Common.InternalLogger.Trace<string>("MailTarget(Name={0}):   Using NTLM authentication.", base.Name);
					client.Credentials = global::System.Net.CredentialCache.DefaultNetworkCredentials;
				}
				else if (this.SmtpAuthentication == global::NLog.Targets.SmtpAuthenticationMode.Basic)
				{
					string text2 = this.SmtpUserName.Render(lastEvent);
					string text3 = this.SmtpPassword.Render(lastEvent);
					global::NLog.Common.InternalLogger.Trace<string, string, string>("MailTarget(Name={0}):   Using basic authentication: Username='{1}' Password='{2}'", base.Name, text2, new string('*', text3.Length));
					client.Credentials = new global::System.Net.NetworkCredential(text2, text3);
				}
			}
			if (!string.IsNullOrEmpty(this.PickupDirectoryLocation) && this.DeliveryMethod == global::System.Net.Mail.SmtpDeliveryMethod.SpecifiedPickupDirectory)
			{
				client.PickupDirectoryLocation = global::NLog.Targets.MailTarget.ConvertDirectoryLocation(this.PickupDirectoryLocation);
			}
			client.DeliveryMethod = this.DeliveryMethod;
			client.Timeout = this.Timeout;
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0001005C File Offset: 0x0000E25C
		internal static string ConvertDirectoryLocation(string pickupDirectoryLocation)
		{
			if (!pickupDirectoryLocation.StartsWith("~/"))
			{
				return pickupDirectoryLocation;
			}
			string baseDirectory = global::System.AppDomain.CurrentDomain.BaseDirectory;
			string path = pickupDirectoryLocation.Substring("~/".Length).Replace('/', global::System.IO.Path.DirectorySeparatorChar);
			return global::System.IO.Path.Combine(baseDirectory, path);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x000100A8 File Offset: 0x0000E2A8
		private void CheckRequiredParameters()
		{
			if (!this.UseSystemNetMailSettings && this.SmtpServer == null && this.DeliveryMethod == global::System.Net.Mail.SmtpDeliveryMethod.Network)
			{
				throw new global::NLog.NLogConfigurationException("The MailTarget's '{0}' properties are not set - but needed because useSystemNetMailSettings=false and DeliveryMethod=Network. The email message will not be sent.", new object[]
				{
					"SmtpServer"
				});
			}
			if (!this.UseSystemNetMailSettings && string.IsNullOrEmpty(this.PickupDirectoryLocation) && this.DeliveryMethod == global::System.Net.Mail.SmtpDeliveryMethod.SpecifiedPickupDirectory)
			{
				throw new global::NLog.NLogConfigurationException("The MailTarget's '{0}' properties are not set - but needed because useSystemNetMailSettings=false and DeliveryMethod=SpecifiedPickupDirectory. The email message will not be sent.", new object[]
				{
					"PickupDirectoryLocation"
				});
			}
			if (this.From == null)
			{
				throw new global::NLog.NLogConfigurationException("After the processing of the MailTarget's '{0}' property it appears to be empty. The email message will not be sent.", new object[]
				{
					"From"
				});
			}
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00010140 File Offset: 0x0000E340
		private string GetSmtpSettingsKey(global::NLog.LogEventInfo logEvent)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::NLog.Targets.MailTarget.AppendLayout(stringBuilder, logEvent, this.From);
			global::NLog.Targets.MailTarget.AppendLayout(stringBuilder, logEvent, this.To);
			global::NLog.Targets.MailTarget.AppendLayout(stringBuilder, logEvent, this.CC);
			global::NLog.Targets.MailTarget.AppendLayout(stringBuilder, logEvent, this.Bcc);
			global::NLog.Targets.MailTarget.AppendLayout(stringBuilder, logEvent, this.SmtpServer);
			global::NLog.Targets.MailTarget.AppendLayout(stringBuilder, logEvent, this.SmtpPassword);
			global::NLog.Targets.MailTarget.AppendLayout(stringBuilder, logEvent, this.SmtpUserName);
			return stringBuilder.ToString();
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x000101B2 File Offset: 0x0000E3B2
		private static void AppendLayout(global::System.Text.StringBuilder sb, global::NLog.LogEventInfo logEvent, global::NLog.Layouts.Layout layout)
		{
			sb.Append("|");
			if (layout != null)
			{
				sb.Append(layout.Render(logEvent));
			}
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x000101D4 File Offset: 0x0000E3D4
		private global::System.Net.Mail.MailMessage CreateMailMessage(global::NLog.LogEventInfo lastEvent, string body)
		{
			global::System.Net.Mail.MailMessage mailMessage = new global::System.Net.Mail.MailMessage();
			global::NLog.Layouts.Layout from = this.From;
			string text = (from != null) ? from.Render(lastEvent) : null;
			if (string.IsNullOrEmpty(text))
			{
				throw new global::NLog.NLogRuntimeException("After the processing of the MailTarget's '{0}' property it appears to be empty. The email message will not be sent.", new object[]
				{
					"From"
				});
			}
			mailMessage.From = new global::System.Net.Mail.MailAddress(text);
			bool flag = global::NLog.Targets.MailTarget.AddAddresses(mailMessage.To, this.To, lastEvent);
			bool flag2 = global::NLog.Targets.MailTarget.AddAddresses(mailMessage.CC, this.CC, lastEvent);
			bool flag3 = global::NLog.Targets.MailTarget.AddAddresses(mailMessage.Bcc, this.Bcc, lastEvent);
			if (!flag && !flag2 && !flag3)
			{
				throw new global::NLog.NLogRuntimeException("After the processing of the MailTarget's '{0}' property it appears to be empty. The email message will not be sent.", new object[]
				{
					"To/Cc/Bcc"
				});
			}
			mailMessage.Subject = ((this.Subject == null) ? string.Empty : this.Subject.Render(lastEvent).Trim());
			mailMessage.BodyEncoding = this.Encoding;
			mailMessage.IsBodyHtml = this.Html;
			if (this.Priority != null)
			{
				string text2 = this.Priority.Render(lastEvent);
				global::System.Net.Mail.MailPriority priority;
				if (global::NLog.Common.ConversionHelpers.TryParseEnum<global::System.Net.Mail.MailPriority>(text2, out priority, global::System.Net.Mail.MailPriority.Normal))
				{
					mailMessage.Priority = priority;
				}
				else
				{
					mailMessage.Priority = global::System.Net.Mail.MailPriority.Normal;
					global::NLog.Common.InternalLogger.Warn<string, string>("MailTarget(Name={0}): Could not convert '{1}' to MailPriority, valid values are Low, Normal and High. Using normal priority as fallback.", base.Name, text2);
				}
			}
			mailMessage.Body = body;
			if (mailMessage.IsBodyHtml && this.ReplaceNewlineWithBrTagInHtml && mailMessage.Body != null)
			{
				mailMessage.Body = mailMessage.Body.Replace(global::NLog.Internal.EnvironmentHelper.NewLine, "<br/>");
			}
			return mailMessage;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00010340 File Offset: 0x0000E540
		private static bool AddAddresses(global::System.Net.Mail.MailAddressCollection mailAddressCollection, global::NLog.Layouts.Layout layout, global::NLog.LogEventInfo logEvent)
		{
			bool result = false;
			if (layout != null)
			{
				foreach (string addresses in layout.Render(logEvent).Split(new char[]
				{
					';'
				}, global::System.StringSplitOptions.RemoveEmptyEntries))
				{
					mailAddressCollection.Add(addresses);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0400011D RID: 285
		private const string RequiredPropertyIsEmptyFormat = "After the processing of the MailTarget's '{0}' property it appears to be empty. The email message will not be sent.";

		// Token: 0x0400011E RID: 286
		private global::NLog.Layouts.Layout _from;

		// Token: 0x0400011F RID: 287
		private global::System.Net.Configuration.SmtpSection _currentailSettings;
	}
}
