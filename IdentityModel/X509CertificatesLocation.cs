using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace IdentityModel
{
	// Token: 0x0200002A RID: 42
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class X509CertificatesLocation
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00002848 File Offset: 0x00000A48
		public X509CertificatesLocation(global::System.Security.Cryptography.X509Certificates.StoreLocation location)
		{
			this._location = location;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00002858 File Offset: 0x00000A58
		public global::IdentityModel.X509CertificatesName My
		{
			get
			{
				return new global::IdentityModel.X509CertificatesName(this._location, global::System.Security.Cryptography.X509Certificates.StoreName.My);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002868 File Offset: 0x00000A68
		public global::IdentityModel.X509CertificatesName AddressBook
		{
			get
			{
				return new global::IdentityModel.X509CertificatesName(this._location, global::System.Security.Cryptography.X509Certificates.StoreName.AddressBook);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002878 File Offset: 0x00000A78
		public global::IdentityModel.X509CertificatesName TrustedPeople
		{
			get
			{
				return new global::IdentityModel.X509CertificatesName(this._location, global::System.Security.Cryptography.X509Certificates.StoreName.TrustedPeople);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002888 File Offset: 0x00000A88
		public global::IdentityModel.X509CertificatesName TrustedPublisher
		{
			get
			{
				return new global::IdentityModel.X509CertificatesName(this._location, global::System.Security.Cryptography.X509Certificates.StoreName.TrustedPublisher);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002898 File Offset: 0x00000A98
		public global::IdentityModel.X509CertificatesName CertificateAuthority
		{
			get
			{
				return new global::IdentityModel.X509CertificatesName(this._location, global::System.Security.Cryptography.X509Certificates.StoreName.CertificateAuthority);
			}
		}

		// Token: 0x04000118 RID: 280
		private readonly global::System.Security.Cryptography.X509Certificates.StoreLocation _location;
	}
}
