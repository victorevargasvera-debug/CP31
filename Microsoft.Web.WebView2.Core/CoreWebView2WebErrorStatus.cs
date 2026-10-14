using System;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000015 RID: 21
	public enum CoreWebView2WebErrorStatus
	{
		// Token: 0x0400005F RID: 95
		Unknown,
		// Token: 0x04000060 RID: 96
		CertificateCommonNameIsIncorrect,
		// Token: 0x04000061 RID: 97
		CertificateExpired,
		// Token: 0x04000062 RID: 98
		ClientCertificateContainsErrors,
		// Token: 0x04000063 RID: 99
		CertificateRevoked,
		// Token: 0x04000064 RID: 100
		CertificateIsInvalid,
		// Token: 0x04000065 RID: 101
		ServerUnreachable,
		// Token: 0x04000066 RID: 102
		Timeout,
		// Token: 0x04000067 RID: 103
		ErrorHttpInvalidServerResponse,
		// Token: 0x04000068 RID: 104
		ConnectionAborted,
		// Token: 0x04000069 RID: 105
		ConnectionReset,
		// Token: 0x0400006A RID: 106
		Disconnected,
		// Token: 0x0400006B RID: 107
		CannotConnect,
		// Token: 0x0400006C RID: 108
		HostNameNotResolved,
		// Token: 0x0400006D RID: 109
		OperationCanceled,
		// Token: 0x0400006E RID: 110
		RedirectFailed,
		// Token: 0x0400006F RID: 111
		UnexpectedError
	}
}
