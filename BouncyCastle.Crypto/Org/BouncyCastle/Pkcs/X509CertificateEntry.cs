using System;
using System.Collections;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Pkcs
{
	// Token: 0x020001B6 RID: 438
	public class X509CertificateEntry : global::Org.BouncyCastle.Pkcs.Pkcs12Entry
	{
		// Token: 0x06001083 RID: 4227 RVA: 0x000431F3 File Offset: 0x000413F3
		public X509CertificateEntry(global::Org.BouncyCastle.X509.X509Certificate cert) : base(global::Org.BouncyCastle.Utilities.Platform.CreateHashtable())
		{
			this.cert = cert;
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00043207 File Offset: 0x00041407
		[global::System.Obsolete]
		public X509CertificateEntry(global::Org.BouncyCastle.X509.X509Certificate cert, global::System.Collections.Hashtable attributes) : base(attributes)
		{
			this.cert = cert;
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00043217 File Offset: 0x00041417
		public X509CertificateEntry(global::Org.BouncyCastle.X509.X509Certificate cert, global::System.Collections.IDictionary attributes) : base(attributes)
		{
			this.cert = cert;
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x00043227 File Offset: 0x00041427
		public global::Org.BouncyCastle.X509.X509Certificate Certificate
		{
			get
			{
				return this.cert;
			}
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x00043230 File Offset: 0x00041430
		public override bool Equals(object obj)
		{
			global::Org.BouncyCastle.Pkcs.X509CertificateEntry other = obj as global::Org.BouncyCastle.Pkcs.X509CertificateEntry;
			return other != null && this.cert.Equals(other.cert);
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x0004325A File Offset: 0x0004145A
		public override int GetHashCode()
		{
			return ~this.cert.GetHashCode();
		}

		// Token: 0x040008B6 RID: 2230
		private readonly global::Org.BouncyCastle.X509.X509Certificate cert;
	}
}
