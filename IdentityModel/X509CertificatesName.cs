using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace IdentityModel
{
	// Token: 0x0200002B RID: 43
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class X509CertificatesName
	{
		// Token: 0x0600002F RID: 47 RVA: 0x000028A8 File Offset: 0x00000AA8
		public X509CertificatesName(global::System.Security.Cryptography.X509Certificates.StoreLocation location, global::System.Security.Cryptography.X509Certificates.StoreName name)
		{
			this._location = location;
			this._name = name;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000028C0 File Offset: 0x00000AC0
		public global::IdentityModel.X509CertificatesFinder Thumbprint
		{
			get
			{
				return new global::IdentityModel.X509CertificatesFinder(this._location, this._name, global::System.Security.Cryptography.X509Certificates.X509FindType.FindByThumbprint);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000028D4 File Offset: 0x00000AD4
		public global::IdentityModel.X509CertificatesFinder SubjectDistinguishedName
		{
			get
			{
				return new global::IdentityModel.X509CertificatesFinder(this._location, this._name, global::System.Security.Cryptography.X509Certificates.X509FindType.FindBySubjectDistinguishedName);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000028E8 File Offset: 0x00000AE8
		public global::IdentityModel.X509CertificatesFinder SerialNumber
		{
			get
			{
				return new global::IdentityModel.X509CertificatesFinder(this._location, this._name, global::System.Security.Cryptography.X509Certificates.X509FindType.FindBySerialNumber);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000028FC File Offset: 0x00000AFC
		public global::IdentityModel.X509CertificatesFinder IssuerName
		{
			get
			{
				return new global::IdentityModel.X509CertificatesFinder(this._location, this._name, global::System.Security.Cryptography.X509Certificates.X509FindType.FindByIssuerName);
			}
		}

		// Token: 0x04000119 RID: 281
		private readonly global::System.Security.Cryptography.X509Certificates.StoreLocation _location;

		// Token: 0x0400011A RID: 282
		private readonly global::System.Security.Cryptography.X509Certificates.StoreName _name;
	}
}
