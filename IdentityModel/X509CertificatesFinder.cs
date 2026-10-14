using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace IdentityModel
{
	// Token: 0x02000029 RID: 41
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class X509CertificatesFinder
	{
		// Token: 0x06000027 RID: 39 RVA: 0x000027C8 File Offset: 0x000009C8
		public X509CertificatesFinder(global::System.Security.Cryptography.X509Certificates.StoreLocation location, global::System.Security.Cryptography.X509Certificates.StoreName name, global::System.Security.Cryptography.X509Certificates.X509FindType findType)
		{
			this._location = location;
			this._name = name;
			this._findType = findType;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000027E8 File Offset: 0x000009E8
		public global::System.Collections.Generic.IEnumerable<global::System.Security.Cryptography.X509Certificates.X509Certificate2> Find(object findValue, bool validOnly = true)
		{
			global::System.Security.Cryptography.X509Certificates.X509Store x509Store = new global::System.Security.Cryptography.X509Certificates.X509Store(this._name, this._location);
			x509Store.Open(global::System.Security.Cryptography.X509Certificates.OpenFlags.ReadOnly);
			global::System.Collections.Generic.IEnumerable<global::System.Security.Cryptography.X509Certificates.X509Certificate2> result;
			try
			{
				global::System.Collections.IEnumerable source = x509Store.Certificates.Find(this._findType, findValue, validOnly);
				x509Store.Close();
				result = source.Cast<global::System.Security.Cryptography.X509Certificates.X509Certificate2>();
			}
			finally
			{
				x509Store.Close();
			}
			return result;
		}

		// Token: 0x04000115 RID: 277
		private readonly global::System.Security.Cryptography.X509Certificates.StoreLocation _location;

		// Token: 0x04000116 RID: 278
		private readonly global::System.Security.Cryptography.X509Certificates.StoreName _name;

		// Token: 0x04000117 RID: 279
		private readonly global::System.Security.Cryptography.X509Certificates.X509FindType _findType;
	}
}
