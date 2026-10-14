using System;
using System.Net;
using System.Net.Mail;

namespace NLog.Internal
{
	// Token: 0x02000111 RID: 273
	internal class MySmtpClient : global::System.Net.Mail.SmtpClient, global::NLog.Internal.ISmtpClient, global::System.IDisposable
	{
		// Token: 0x06000D1E RID: 3358 RVA: 0x0002074C File Offset: 0x0001E94C
		global::System.Net.Mail.SmtpDeliveryMethod global::NLog.Internal.ISmtpClient.get_DeliveryMethod()
		{
			return base.DeliveryMethod;
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00020754 File Offset: 0x0001E954
		void global::NLog.Internal.ISmtpClient.set_DeliveryMethod(global::System.Net.Mail.SmtpDeliveryMethod value)
		{
			base.DeliveryMethod = value;
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x0002075D File Offset: 0x0001E95D
		string global::NLog.Internal.ISmtpClient.get_Host()
		{
			return base.Host;
		}

		// Token: 0x06000D21 RID: 3361 RVA: 0x00020765 File Offset: 0x0001E965
		void global::NLog.Internal.ISmtpClient.set_Host(string value)
		{
			base.Host = value;
		}

		// Token: 0x06000D22 RID: 3362 RVA: 0x0002076E File Offset: 0x0001E96E
		int global::NLog.Internal.ISmtpClient.get_Port()
		{
			return base.Port;
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00020776 File Offset: 0x0001E976
		void global::NLog.Internal.ISmtpClient.set_Port(int value)
		{
			base.Port = value;
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x0002077F File Offset: 0x0001E97F
		int global::NLog.Internal.ISmtpClient.get_Timeout()
		{
			return base.Timeout;
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00020787 File Offset: 0x0001E987
		void global::NLog.Internal.ISmtpClient.set_Timeout(int value)
		{
			base.Timeout = value;
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00020790 File Offset: 0x0001E990
		global::System.Net.ICredentialsByHost global::NLog.Internal.ISmtpClient.get_Credentials()
		{
			return base.Credentials;
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00020798 File Offset: 0x0001E998
		void global::NLog.Internal.ISmtpClient.set_Credentials(global::System.Net.ICredentialsByHost value)
		{
			base.Credentials = value;
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x000207A1 File Offset: 0x0001E9A1
		bool global::NLog.Internal.ISmtpClient.get_EnableSsl()
		{
			return base.EnableSsl;
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x000207A9 File Offset: 0x0001E9A9
		void global::NLog.Internal.ISmtpClient.set_EnableSsl(bool value)
		{
			base.EnableSsl = value;
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x000207B2 File Offset: 0x0001E9B2
		void global::NLog.Internal.ISmtpClient.Send(global::System.Net.Mail.MailMessage msg)
		{
			base.Send(msg);
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x000207BB File Offset: 0x0001E9BB
		string global::NLog.Internal.ISmtpClient.get_PickupDirectoryLocation()
		{
			return base.PickupDirectoryLocation;
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x000207C3 File Offset: 0x0001E9C3
		void global::NLog.Internal.ISmtpClient.set_PickupDirectoryLocation(string value)
		{
			base.PickupDirectoryLocation = value;
		}
	}
}
