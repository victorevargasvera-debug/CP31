using System;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ess
{
	// Token: 0x020006FD RID: 1789
	public class EssCertIDv2 : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060040AE RID: 16558 RVA: 0x001255BC File Offset: 0x001237BC
		public static global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2 GetInstance(object obj)
		{
			if (obj == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2 existing = obj as global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2;
			if (existing != null)
			{
				return existing;
			}
			return new global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x001255E8 File Offset: 0x001237E8
		private EssCertIDv2(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count > 3)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString(), "seq");
			}
			int count = 0;
			if (seq[0] is global::Org.BouncyCastle.Asn1.Asn1OctetString)
			{
				this.hashAlgorithm = global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2.DefaultAlgID;
			}
			else
			{
				this.hashAlgorithm = global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier.GetInstance(seq[count++].ToAsn1Object());
			}
			this.certHash = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(seq[count++].ToAsn1Object()).GetOctets();
			if (seq.Count > count)
			{
				this.issuerSerial = global::Org.BouncyCastle.Asn1.X509.IssuerSerial.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(seq[count].ToAsn1Object()));
			}
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x001256A4 File Offset: 0x001238A4
		public EssCertIDv2(byte[] certHash) : this(null, certHash, null)
		{
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x001256AF File Offset: 0x001238AF
		public EssCertIDv2(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId, byte[] certHash) : this(algId, certHash, null)
		{
		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x001256BA File Offset: 0x001238BA
		public EssCertIDv2(byte[] certHash, global::Org.BouncyCastle.Asn1.X509.IssuerSerial issuerSerial) : this(null, certHash, issuerSerial)
		{
		}

		// Token: 0x060040B3 RID: 16563 RVA: 0x001256C5 File Offset: 0x001238C5
		public EssCertIDv2(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId, byte[] certHash, global::Org.BouncyCastle.Asn1.X509.IssuerSerial issuerSerial)
		{
			if (algId == null)
			{
				this.hashAlgorithm = global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2.DefaultAlgID;
			}
			else
			{
				this.hashAlgorithm = algId;
			}
			this.certHash = certHash;
			this.issuerSerial = issuerSerial;
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x060040B4 RID: 16564 RVA: 0x001256F2 File Offset: 0x001238F2
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier HashAlgorithm
		{
			get
			{
				return this.hashAlgorithm;
			}
		}

		// Token: 0x060040B5 RID: 16565 RVA: 0x001256FA File Offset: 0x001238FA
		public byte[] GetCertHash()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.certHash);
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x060040B6 RID: 16566 RVA: 0x00125707 File Offset: 0x00123907
		public global::Org.BouncyCastle.Asn1.X509.IssuerSerial IssuerSerial
		{
			get
			{
				return this.issuerSerial;
			}
		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x00125710 File Offset: 0x00123910
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			if (!this.hashAlgorithm.Equals(global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2.DefaultAlgID))
			{
				v.Add(this.hashAlgorithm);
			}
			v.Add(new global::Org.BouncyCastle.Asn1.DerOctetString(this.certHash).ToAsn1Object());
			v.AddOptional(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.issuerSerial
			});
			return new global::Org.BouncyCastle.Asn1.DerSequence(v);
		}

		// Token: 0x04001F05 RID: 7941
		private readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgorithm;

		// Token: 0x04001F06 RID: 7942
		private readonly byte[] certHash;

		// Token: 0x04001F07 RID: 7943
		private readonly global::Org.BouncyCastle.Asn1.X509.IssuerSerial issuerSerial;

		// Token: 0x04001F08 RID: 7944
		private static readonly global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DefaultAlgID = new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256);
	}
}
