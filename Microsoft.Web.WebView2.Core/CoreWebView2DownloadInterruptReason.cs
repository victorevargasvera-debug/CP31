using System;

namespace Microsoft.Web.WebView2.Core
{
	// Token: 0x02000022 RID: 34
	public enum CoreWebView2DownloadInterruptReason
	{
		// Token: 0x040000C6 RID: 198
		None,
		// Token: 0x040000C7 RID: 199
		FileFailed,
		// Token: 0x040000C8 RID: 200
		FileAccessDenied,
		// Token: 0x040000C9 RID: 201
		FileNoSpace,
		// Token: 0x040000CA RID: 202
		FileNameTooLong,
		// Token: 0x040000CB RID: 203
		FileTooLarge,
		// Token: 0x040000CC RID: 204
		FileMalicious,
		// Token: 0x040000CD RID: 205
		FileTransientError,
		// Token: 0x040000CE RID: 206
		FileBlockedByPolicy,
		// Token: 0x040000CF RID: 207
		FileSecurityCheckFailed,
		// Token: 0x040000D0 RID: 208
		FileTooShort,
		// Token: 0x040000D1 RID: 209
		FileHashMismatch,
		// Token: 0x040000D2 RID: 210
		NetworkFailed,
		// Token: 0x040000D3 RID: 211
		NetworkTimeout,
		// Token: 0x040000D4 RID: 212
		NetworkDisconnected,
		// Token: 0x040000D5 RID: 213
		NetworkServerDown,
		// Token: 0x040000D6 RID: 214
		NetworkInvalidRequest,
		// Token: 0x040000D7 RID: 215
		ServerFailed,
		// Token: 0x040000D8 RID: 216
		ServerNoRange,
		// Token: 0x040000D9 RID: 217
		ServerBadContent,
		// Token: 0x040000DA RID: 218
		ServerUnauthorized,
		// Token: 0x040000DB RID: 219
		ServerCertificateProblem,
		// Token: 0x040000DC RID: 220
		ServerForbidden,
		// Token: 0x040000DD RID: 221
		ServerUnexpectedResponse,
		// Token: 0x040000DE RID: 222
		ServerContentLengthMismatch,
		// Token: 0x040000DF RID: 223
		ServerCrossOriginRedirect,
		// Token: 0x040000E0 RID: 224
		UserCanceled,
		// Token: 0x040000E1 RID: 225
		UserShutdown,
		// Token: 0x040000E2 RID: 226
		UserPaused,
		// Token: 0x040000E3 RID: 227
		DownloadProcessCrashed
	}
}
