using System;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x0200004C RID: 76
	public class X509SigningCredentials : global::Microsoft.IdentityModel.Tokens.SigningCredentials
	{
		// Token: 0x0600023A RID: 570 RVA: 0x00008A2F File Offset: 0x00006C2F
		public X509SigningCredentials(global::System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) : base(certificate)
		{
			this.Certificate = certificate;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00008A3F File Offset: 0x00006C3F
		public X509SigningCredentials(global::System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, string algorithm) : base(certificate, algorithm)
		{
			this.Certificate = certificate;
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00008A50 File Offset: 0x00006C50
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00008A58 File Offset: 0x00006C58
		public global::System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get; private set; }
	}
}
