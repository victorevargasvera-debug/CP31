using System;
using System.Net;
using System.Net.Mail;

namespace NLog.Internal
{
	// Token: 0x02000109 RID: 265
	internal interface ISmtpClient : global::System.IDisposable
	{
		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000CE9 RID: 3305
		// (set) Token: 0x06000CEA RID: 3306
		global::System.Net.Mail.SmtpDeliveryMethod DeliveryMethod { get; set; }

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000CEB RID: 3307
		// (set) Token: 0x06000CEC RID: 3308
		string Host { get; set; }

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000CED RID: 3309
		// (set) Token: 0x06000CEE RID: 3310
		int Port { get; set; }

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000CEF RID: 3311
		// (set) Token: 0x06000CF0 RID: 3312
		int Timeout { get; set; }

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000CF1 RID: 3313
		// (set) Token: 0x06000CF2 RID: 3314
		global::System.Net.ICredentialsByHost Credentials { get; set; }

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000CF3 RID: 3315
		// (set) Token: 0x06000CF4 RID: 3316
		bool EnableSsl { get; set; }

		// Token: 0x06000CF5 RID: 3317
		void Send(global::System.Net.Mail.MailMessage msg);

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000CF6 RID: 3318
		// (set) Token: 0x06000CF7 RID: 3319
		string PickupDirectoryLocation { get; set; }
	}
}
