using System;

namespace Gibraltar.Server.Client
{
	// Token: 0x0200011C RID: 284
	internal class CredentialsRequiredEventArgs : global::System.EventArgs
	{
		// Token: 0x06000BAD RID: 2989 RVA: 0x0001DBB0 File Offset: 0x0001BDB0
		public CredentialsRequiredEventArgs(string endpointUri, global::System.Guid repositoryId, bool authFailed, global::Gibraltar.Server.Client.IWebAuthenticationProvider authenticationProvider)
		{
			this.EndpointUri = endpointUri;
			this.RepositoryId = repositoryId;
			this.AuthenticationProvider = authenticationProvider;
			this.Cancel = false;
			this.AuthenticationFailed = authFailed;
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x0001DBEC File Offset: 0x0001BDEC
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x0001DBF4 File Offset: 0x0001BDF4
		public string EndpointUri { get; private set; }

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x0001DC00 File Offset: 0x0001BE00
		// (set) Token: 0x06000BB1 RID: 2993 RVA: 0x0001DC08 File Offset: 0x0001BE08
		public global::System.Guid RepositoryId { get; private set; }

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x0001DC14 File Offset: 0x0001BE14
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x0001DC1C File Offset: 0x0001BE1C
		public bool AuthenticationFailed { get; private set; }

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x0001DC28 File Offset: 0x0001BE28
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x0001DC30 File Offset: 0x0001BE30
		public global::Gibraltar.Server.Client.IWebAuthenticationProvider AuthenticationProvider { get; set; }

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x0001DC3C File Offset: 0x0001BE3C
		// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x0001DC44 File Offset: 0x0001BE44
		public bool Cancel { get; set; }
	}
}
