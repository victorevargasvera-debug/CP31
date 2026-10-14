using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x0200041E RID: 1054
	public class Asn1DigestFactory : global::Org.BouncyCastle.Crypto.IDigestFactory
	{
		// Token: 0x060028F5 RID: 10485 RVA: 0x000ADDA3 File Offset: 0x000ABFA3
		public static global::Org.BouncyCastle.Crypto.Operators.Asn1DigestFactory Get(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			return new global::Org.BouncyCastle.Crypto.Operators.Asn1DigestFactory(global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(oid), oid);
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x000ADDB4 File Offset: 0x000ABFB4
		public static global::Org.BouncyCastle.Crypto.Operators.Asn1DigestFactory Get(string mechanism)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid = global::Org.BouncyCastle.Security.DigestUtilities.GetObjectIdentifier(mechanism);
			return new global::Org.BouncyCastle.Crypto.Operators.Asn1DigestFactory(global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(oid), oid);
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x000ADDD4 File Offset: 0x000ABFD4
		public Asn1DigestFactory(global::Org.BouncyCastle.Crypto.IDigest digest, global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
		{
			this.mDigest = digest;
			this.mOid = oid;
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060028F8 RID: 10488 RVA: 0x000ADDEA File Offset: 0x000ABFEA
		public virtual object AlgorithmDetails
		{
			get
			{
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(this.mOid);
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060028F9 RID: 10489 RVA: 0x000ADDF7 File Offset: 0x000ABFF7
		public virtual int DigestLength
		{
			get
			{
				return this.mDigest.GetDigestSize();
			}
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x000ADE04 File Offset: 0x000AC004
		public virtual global::Org.BouncyCastle.Crypto.IStreamCalculator CreateCalculator()
		{
			return new global::Org.BouncyCastle.Crypto.Operators.DfDigestStream(this.mDigest);
		}

		// Token: 0x0400109A RID: 4250
		private readonly global::Org.BouncyCastle.Crypto.IDigest mDigest;

		// Token: 0x0400109B RID: 4251
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier mOid;
	}
}
