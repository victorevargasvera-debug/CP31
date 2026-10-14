using System;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Esf
{
	// Token: 0x02000711 RID: 1809
	public class OtherHash : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x0600412F RID: 16687 RVA: 0x001273D2 File Offset: 0x001255D2
		public static global::Org.BouncyCastle.Asn1.Esf.OtherHash GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Esf.OtherHash)
			{
				return (global::Org.BouncyCastle.Asn1.Esf.OtherHash)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1OctetString)
			{
				return new global::Org.BouncyCastle.Asn1.Esf.OtherHash((global::Org.BouncyCastle.Asn1.Asn1OctetString)obj);
			}
			return new global::Org.BouncyCastle.Asn1.Esf.OtherHash(global::Org.BouncyCastle.Asn1.Esf.OtherHashAlgAndValue.GetInstance(obj));
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x00127405 File Offset: 0x00125605
		public OtherHash(byte[] sha1Hash)
		{
			if (sha1Hash == null)
			{
				throw new global::System.ArgumentNullException("sha1Hash");
			}
			this.sha1Hash = new global::Org.BouncyCastle.Asn1.DerOctetString(sha1Hash);
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x00127427 File Offset: 0x00125627
		public OtherHash(global::Org.BouncyCastle.Asn1.Asn1OctetString sha1Hash)
		{
			if (sha1Hash == null)
			{
				throw new global::System.ArgumentNullException("sha1Hash");
			}
			this.sha1Hash = sha1Hash;
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x00127444 File Offset: 0x00125644
		public OtherHash(global::Org.BouncyCastle.Asn1.Esf.OtherHashAlgAndValue otherHash)
		{
			if (otherHash == null)
			{
				throw new global::System.ArgumentNullException("otherHash");
			}
			this.otherHash = otherHash;
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06004133 RID: 16691 RVA: 0x00127461 File Offset: 0x00125661
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlgorithm
		{
			get
			{
				if (this.otherHash != null)
				{
					return this.otherHash.HashAlgorithm;
				}
				return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1);
			}
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x00127481 File Offset: 0x00125681
		public byte[] GetHashValue()
		{
			if (this.otherHash != null)
			{
				return this.otherHash.GetHashValue();
			}
			return this.sha1Hash.GetOctets();
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x001274A2 File Offset: 0x001256A2
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			if (this.otherHash != null)
			{
				return this.otherHash.ToAsn1Object();
			}
			return this.sha1Hash;
		}

		// Token: 0x04001F3C RID: 7996
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString sha1Hash;

		// Token: 0x04001F3D RID: 7997
		private readonly global::Org.BouncyCastle.Asn1.Esf.OtherHashAlgAndValue otherHash;
	}
}
