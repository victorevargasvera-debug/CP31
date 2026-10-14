using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006B7 RID: 1719
	public class Pbkdf2Params : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003EE0 RID: 16096 RVA: 0x0011E3BC File Offset: 0x0011C5BC
		public static global::Org.BouncyCastle.Asn1.Pkcs.Pbkdf2Params GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.Pkcs.Pbkdf2Params)
			{
				return (global::Org.BouncyCastle.Asn1.Pkcs.Pbkdf2Params)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Pkcs.Pbkdf2Params((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x0011E40C File Offset: 0x0011C60C
		public Pbkdf2Params(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count < 2 || seq.Count > 4)
			{
				throw new global::System.ArgumentException("Wrong number of elements in sequence", "seq");
			}
			this.octStr = (global::Org.BouncyCastle.Asn1.Asn1OctetString)seq[0];
			this.iterationCount = (global::Org.BouncyCastle.Asn1.DerInteger)seq[1];
			global::Org.BouncyCastle.Asn1.Asn1Encodable kl = null;
			global::Org.BouncyCastle.Asn1.Asn1Encodable d = null;
			if (seq.Count > 3)
			{
				kl = seq[2];
				d = seq[3];
			}
			else if (seq.Count > 2)
			{
				if (seq[2] is global::Org.BouncyCastle.Asn1.DerInteger)
				{
					kl = seq[2];
				}
				else
				{
					d = seq[2];
				}
			}
			if (kl != null)
			{
				this.keyLength = (global::Org.BouncyCastle.Asn1.DerInteger)kl;
			}
			if (d != null)
			{
				this.prf = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(d);
			}
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x0011E4CB File Offset: 0x0011C6CB
		public Pbkdf2Params(byte[] salt, int iterationCount)
		{
			this.octStr = new global::Org.BouncyCastle.Asn1.DerOctetString(salt);
			this.iterationCount = new global::Org.BouncyCastle.Asn1.DerInteger(iterationCount);
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x0011E4EB File Offset: 0x0011C6EB
		public Pbkdf2Params(byte[] salt, int iterationCount, int keyLength) : this(salt, iterationCount)
		{
			this.keyLength = new global::Org.BouncyCastle.Asn1.DerInteger(keyLength);
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x0011E501 File Offset: 0x0011C701
		public Pbkdf2Params(byte[] salt, int iterationCount, int keyLength, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier prf) : this(salt, iterationCount, keyLength)
		{
			this.prf = prf;
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x0011E514 File Offset: 0x0011C714
		public Pbkdf2Params(byte[] salt, int iterationCount, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier prf) : this(salt, iterationCount)
		{
			this.prf = prf;
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x0011E525 File Offset: 0x0011C725
		public byte[] GetSalt()
		{
			return this.octStr.GetOctets();
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06003EE7 RID: 16103 RVA: 0x0011E532 File Offset: 0x0011C732
		public global::Org.BouncyCastle.Math.BigInteger IterationCount
		{
			get
			{
				return this.iterationCount.Value;
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06003EE8 RID: 16104 RVA: 0x0011E53F File Offset: 0x0011C73F
		public global::Org.BouncyCastle.Math.BigInteger KeyLength
		{
			get
			{
				if (this.keyLength != null)
				{
					return this.keyLength.Value;
				}
				return null;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06003EE9 RID: 16105 RVA: 0x0011E556 File Offset: 0x0011C756
		public bool IsDefaultPrf
		{
			get
			{
				return this.prf == null || this.prf.Equals(global::Org.BouncyCastle.Asn1.Pkcs.Pbkdf2Params.algid_hmacWithSHA1);
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06003EEA RID: 16106 RVA: 0x0011E572 File Offset: 0x0011C772
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier Prf
		{
			get
			{
				if (this.prf == null)
				{
					return global::Org.BouncyCastle.Asn1.Pkcs.Pbkdf2Params.algid_hmacWithSHA1;
				}
				return this.prf;
			}
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x0011E588 File Offset: 0x0011C788
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.octStr,
				this.iterationCount
			});
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.keyLength
			});
			if (!this.IsDefaultPrf)
			{
				v.Add(this.prf);
			}
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001C7F RID: 7295
		private static global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algid_hmacWithSHA1 = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha1, global::Org.BouncyCastle.Asn1.DerNull.Instance);

		// Token: 0x04001C80 RID: 7296
		private readonly global::Org.BouncyCastle.Asn1.Asn1OctetString octStr;

		// Token: 0x04001C81 RID: 7297
		private readonly global::Org.BouncyCastle.Asn1.DerInteger iterationCount;

		// Token: 0x04001C82 RID: 7298
		private readonly global::Org.BouncyCastle.Asn1.DerInteger keyLength;

		// Token: 0x04001C83 RID: 7299
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier prf;
	}
}
