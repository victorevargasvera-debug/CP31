using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.X509
{
	// Token: 0x0200000C RID: 12
	public interface IX509AttributeCertificate : global::Org.BouncyCastle.X509.IX509Extension
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600008D RID: 141
		int Version { get; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600008E RID: 142
		global::Org.BouncyCastle.Math.BigInteger SerialNumber { get; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600008F RID: 143
		global::System.DateTime NotBefore { get; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000090 RID: 144
		global::System.DateTime NotAfter { get; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000091 RID: 145
		global::Org.BouncyCastle.X509.AttributeCertificateHolder Holder { get; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000092 RID: 146
		global::Org.BouncyCastle.X509.AttributeCertificateIssuer Issuer { get; }

		// Token: 0x06000093 RID: 147
		global::Org.BouncyCastle.X509.X509Attribute[] GetAttributes();

		// Token: 0x06000094 RID: 148
		global::Org.BouncyCastle.X509.X509Attribute[] GetAttributes(string oid);

		// Token: 0x06000095 RID: 149
		bool[] GetIssuerUniqueID();

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000096 RID: 150
		bool IsValidNow { get; }

		// Token: 0x06000097 RID: 151
		bool IsValid(global::System.DateTime date);

		// Token: 0x06000098 RID: 152
		void CheckValidity();

		// Token: 0x06000099 RID: 153
		void CheckValidity(global::System.DateTime date);

		// Token: 0x0600009A RID: 154
		byte[] GetSignature();

		// Token: 0x0600009B RID: 155
		void Verify(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey);

		// Token: 0x0600009C RID: 156
		byte[] GetEncoded();
	}
}
