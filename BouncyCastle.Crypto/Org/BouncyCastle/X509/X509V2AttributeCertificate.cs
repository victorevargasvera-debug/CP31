using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.X509
{
	// Token: 0x0200001F RID: 31
	public class X509V2AttributeCertificate : global::Org.BouncyCastle.X509.X509ExtensionBase, global::Org.BouncyCastle.X509.IX509AttributeCertificate, global::Org.BouncyCastle.X509.IX509Extension
	{
		// Token: 0x0600014C RID: 332 RVA: 0x00009318 File Offset: 0x00007518
		private static global::Org.BouncyCastle.Asn1.X509.AttributeCertificate GetObject(global::System.IO.Stream input)
		{
			global::Org.BouncyCastle.Asn1.X509.AttributeCertificate instance;
			try
			{
				instance = global::Org.BouncyCastle.Asn1.X509.AttributeCertificate.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromStream(input));
			}
			catch (global::System.IO.IOException ex)
			{
				throw ex;
			}
			catch (global::System.Exception e)
			{
				throw new global::System.IO.IOException("exception decoding certificate structure", e);
			}
			return instance;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00009360 File Offset: 0x00007560
		public X509V2AttributeCertificate(global::System.IO.Stream encIn) : this(global::Org.BouncyCastle.X509.X509V2AttributeCertificate.GetObject(encIn))
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000936E File Offset: 0x0000756E
		public X509V2AttributeCertificate(byte[] encoded) : this(new global::System.IO.MemoryStream(encoded, false))
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00009380 File Offset: 0x00007580
		internal X509V2AttributeCertificate(global::Org.BouncyCastle.Asn1.X509.AttributeCertificate cert)
		{
			this.cert = cert;
			try
			{
				this.notAfter = cert.ACInfo.AttrCertValidityPeriod.NotAfterTime.ToDateTime();
				this.notBefore = cert.ACInfo.AttrCertValidityPeriod.NotBeforeTime.ToDateTime();
			}
			catch (global::System.Exception e)
			{
				throw new global::System.IO.IOException("invalid data structure in certificate!", e);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000093F0 File Offset: 0x000075F0
		public virtual int Version
		{
			get
			{
				return this.cert.ACInfo.Version.IntValueExact + 1;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00009409 File Offset: 0x00007609
		public virtual global::Org.BouncyCastle.Math.BigInteger SerialNumber
		{
			get
			{
				return this.cert.ACInfo.SerialNumber.Value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00009420 File Offset: 0x00007620
		public virtual global::Org.BouncyCastle.X509.AttributeCertificateHolder Holder
		{
			get
			{
				return new global::Org.BouncyCastle.X509.AttributeCertificateHolder((global::Org.BouncyCastle.Asn1.Asn1Sequence)this.cert.ACInfo.Holder.ToAsn1Object());
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00009441 File Offset: 0x00007641
		public virtual global::Org.BouncyCastle.X509.AttributeCertificateIssuer Issuer
		{
			get
			{
				return new global::Org.BouncyCastle.X509.AttributeCertificateIssuer(this.cert.ACInfo.Issuer);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00009458 File Offset: 0x00007658
		public virtual global::System.DateTime NotBefore
		{
			get
			{
				return this.notBefore;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00009460 File Offset: 0x00007660
		public virtual global::System.DateTime NotAfter
		{
			get
			{
				return this.notAfter;
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00009468 File Offset: 0x00007668
		public virtual bool[] GetIssuerUniqueID()
		{
			global::Org.BouncyCastle.Asn1.DerBitString id = this.cert.ACInfo.IssuerUniqueID;
			if (id != null)
			{
				byte[] bytes = id.GetBytes();
				bool[] boolId = new bool[bytes.Length * 8 - id.PadBits];
				for (int i = 0; i != boolId.Length; i++)
				{
					boolId[i] = (((int)bytes[i / 8] & 128 >> i % 8) != 0);
				}
				return boolId;
			}
			return null;
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000157 RID: 343 RVA: 0x000094CB File Offset: 0x000076CB
		public virtual bool IsValidNow
		{
			get
			{
				return this.IsValid(global::System.DateTime.UtcNow);
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000094D8 File Offset: 0x000076D8
		public virtual bool IsValid(global::System.DateTime date)
		{
			return date.CompareTo(this.NotBefore) >= 0 && date.CompareTo(this.NotAfter) <= 0;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000094FF File Offset: 0x000076FF
		public virtual void CheckValidity()
		{
			this.CheckValidity(global::System.DateTime.UtcNow);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000950C File Offset: 0x0000770C
		public virtual void CheckValidity(global::System.DateTime date)
		{
			if (date.CompareTo(this.NotAfter) > 0)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateExpiredException("certificate expired on " + this.NotAfter.ToString());
			}
			if (date.CompareTo(this.NotBefore) < 0)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateNotYetValidException("certificate not valid until " + this.NotBefore.ToString());
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00009575 File Offset: 0x00007775
		public virtual global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier SignatureAlgorithm
		{
			get
			{
				return this.cert.SignatureAlgorithm;
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00009582 File Offset: 0x00007782
		public virtual byte[] GetSignature()
		{
			return this.cert.GetSignatureOctets();
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000958F File Offset: 0x0000778F
		public virtual void Verify(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key)
		{
			this.CheckSignature(new global::Org.BouncyCastle.Crypto.Operators.Asn1VerifierFactory(this.cert.SignatureAlgorithm, key));
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000095A8 File Offset: 0x000077A8
		public virtual void Verify(global::Org.BouncyCastle.Crypto.IVerifierFactoryProvider verifierProvider)
		{
			this.CheckSignature(verifierProvider.CreateVerifierFactory(this.cert.SignatureAlgorithm));
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000095C4 File Offset: 0x000077C4
		protected virtual void CheckSignature(global::Org.BouncyCastle.Crypto.IVerifierFactory verifier)
		{
			if (!this.cert.SignatureAlgorithm.Equals(this.cert.ACInfo.Signature))
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateException("Signature algorithm in certificate info not same as outer certificate");
			}
			global::Org.BouncyCastle.Crypto.IStreamCalculator streamCalculator = verifier.CreateCalculator();
			try
			{
				byte[] b = this.cert.ACInfo.GetEncoded();
				streamCalculator.Stream.Write(b, 0, b.Length);
				global::Org.BouncyCastle.Utilities.Platform.Dispose(streamCalculator.Stream);
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Security.SignatureException("Exception encoding certificate info object", e);
			}
			if (!((global::Org.BouncyCastle.Crypto.IVerifier)streamCalculator.GetResult()).IsVerified(this.GetSignature()))
			{
				throw new global::Org.BouncyCastle.Security.InvalidKeyException("Public key presented not for certificate signature");
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00009674 File Offset: 0x00007874
		public virtual byte[] GetEncoded()
		{
			return this.cert.GetEncoded();
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00009681 File Offset: 0x00007881
		protected override global::Org.BouncyCastle.Asn1.X509.X509Extensions GetX509Extensions()
		{
			return this.cert.ACInfo.Extensions;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00009694 File Offset: 0x00007894
		public virtual global::Org.BouncyCastle.X509.X509Attribute[] GetAttributes()
		{
			global::Org.BouncyCastle.Asn1.Asn1Sequence seq = this.cert.ACInfo.Attributes;
			global::Org.BouncyCastle.X509.X509Attribute[] attrs = new global::Org.BouncyCastle.X509.X509Attribute[seq.Count];
			for (int i = 0; i != seq.Count; i++)
			{
				attrs[i] = new global::Org.BouncyCastle.X509.X509Attribute(seq[i]);
			}
			return attrs;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000096E0 File Offset: 0x000078E0
		public virtual global::Org.BouncyCastle.X509.X509Attribute[] GetAttributes(string oid)
		{
			global::Org.BouncyCastle.Asn1.Asn1Sequence seq = this.cert.ACInfo.Attributes;
			global::System.Collections.IList list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			for (int i = 0; i != seq.Count; i++)
			{
				global::Org.BouncyCastle.X509.X509Attribute attr = new global::Org.BouncyCastle.X509.X509Attribute(seq[i]);
				if (attr.Oid.Equals(oid))
				{
					list.Add(attr);
				}
			}
			if (list.Count < 1)
			{
				return null;
			}
			global::Org.BouncyCastle.X509.X509Attribute[] result = new global::Org.BouncyCastle.X509.X509Attribute[list.Count];
			for (int j = 0; j < list.Count; j++)
			{
				result[j] = (global::Org.BouncyCastle.X509.X509Attribute)list[j];
			}
			return result;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000977C File Offset: 0x0000797C
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.X509.X509V2AttributeCertificate other = obj as global::Org.BouncyCastle.X509.X509V2AttributeCertificate;
			return other != null && this.cert.Equals(other.cert);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000097AC File Offset: 0x000079AC
		public override int GetHashCode()
		{
			return this.cert.GetHashCode();
		}

		// Token: 0x040000B3 RID: 179
		private readonly global::Org.BouncyCastle.Asn1.X509.AttributeCertificate cert;

		// Token: 0x040000B4 RID: 180
		private readonly global::System.DateTime notBefore;

		// Token: 0x040000B5 RID: 181
		private readonly global::System.DateTime notAfter;
	}
}
