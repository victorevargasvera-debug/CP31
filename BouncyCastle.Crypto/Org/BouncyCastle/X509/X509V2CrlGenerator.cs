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
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.X509
{
	// Token: 0x02000021 RID: 33
	public class X509V2CrlGenerator
	{
		// Token: 0x06000176 RID: 374 RVA: 0x000099F7 File Offset: 0x00007BF7
		public X509V2CrlGenerator()
		{
			this.tbsGen = new global::Org.BouncyCastle.Asn1.X509.V2TbsCertListGenerator();
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00009A15 File Offset: 0x00007C15
		public void Reset()
		{
			this.tbsGen = new global::Org.BouncyCastle.Asn1.X509.V2TbsCertListGenerator();
			this.extGenerator.Reset();
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00009A2D File Offset: 0x00007C2D
		public void SetIssuerDN(global::Org.BouncyCastle.Asn1.X509.X509Name issuer)
		{
			this.tbsGen.SetIssuer(issuer);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00009A3B File Offset: 0x00007C3B
		public void SetThisUpdate(global::System.DateTime date)
		{
			this.tbsGen.SetThisUpdate(new global::Org.BouncyCastle.Asn1.X509.Time(date));
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00009A4E File Offset: 0x00007C4E
		public void SetNextUpdate(global::System.DateTime date)
		{
			this.tbsGen.SetNextUpdate(new global::Org.BouncyCastle.Asn1.X509.Time(date));
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00009A61 File Offset: 0x00007C61
		public void AddCrlEntry(global::Org.BouncyCastle.Math.BigInteger userCertificate, global::System.DateTime revocationDate, int reason)
		{
			this.tbsGen.AddCrlEntry(new global::Org.BouncyCastle.Asn1.DerInteger(userCertificate), new global::Org.BouncyCastle.Asn1.X509.Time(revocationDate), reason);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00009A7B File Offset: 0x00007C7B
		public void AddCrlEntry(global::Org.BouncyCastle.Math.BigInteger userCertificate, global::System.DateTime revocationDate, int reason, global::System.DateTime invalidityDate)
		{
			this.tbsGen.AddCrlEntry(new global::Org.BouncyCastle.Asn1.DerInteger(userCertificate), new global::Org.BouncyCastle.Asn1.X509.Time(revocationDate), reason, new global::Org.BouncyCastle.Asn1.DerGeneralizedTime(invalidityDate));
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00009A9C File Offset: 0x00007C9C
		public void AddCrlEntry(global::Org.BouncyCastle.Math.BigInteger userCertificate, global::System.DateTime revocationDate, global::Org.BouncyCastle.Asn1.X509.X509Extensions extensions)
		{
			this.tbsGen.AddCrlEntry(new global::Org.BouncyCastle.Asn1.DerInteger(userCertificate), new global::Org.BouncyCastle.Asn1.X509.Time(revocationDate), extensions);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00009AB8 File Offset: 0x00007CB8
		public void AddCrl(global::Org.BouncyCastle.X509.X509Crl other)
		{
			if (other == null)
			{
				throw new global::System.ArgumentNullException("other");
			}
			global::Org.BouncyCastle.Utilities.Collections.ISet revocations = other.GetRevokedCertificates();
			if (revocations != null)
			{
				foreach (object obj in revocations)
				{
					global::Org.BouncyCastle.X509.X509CrlEntry entry = (global::Org.BouncyCastle.X509.X509CrlEntry)obj;
					try
					{
						this.tbsGen.AddCrlEntry(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(entry.GetEncoded())));
					}
					catch (global::System.IO.IOException e)
					{
						throw new global::Org.BouncyCastle.Security.Certificates.CrlException("exception processing encoding of CRL", e);
					}
				}
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00009B58 File Offset: 0x00007D58
		[global::System.Obsolete("Not needed if Generate used with an ISignatureFactory")]
		public void SetSignatureAlgorithm(string signatureAlgorithm)
		{
			this.signatureAlgorithm = signatureAlgorithm;
			try
			{
				this.sigOID = global::Org.BouncyCastle.X509.X509Utilities.GetAlgorithmOid(signatureAlgorithm);
			}
			catch (global::System.Exception e)
			{
				throw new global::System.ArgumentException("Unknown signature type requested", e);
			}
			this.sigAlgId = global::Org.BouncyCastle.X509.X509Utilities.GetSigAlgID(this.sigOID, signatureAlgorithm);
			this.tbsGen.SetSignature(this.sigAlgId);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00009BBC File Offset: 0x00007DBC
		public void AddExtension(string oid, bool critical, global::Org.BouncyCastle.Asn1.Asn1Encodable extensionValue)
		{
			this.extGenerator.AddExtension(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(oid), critical, extensionValue);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00009BD1 File Offset: 0x00007DD1
		public void AddExtension(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, bool critical, global::Org.BouncyCastle.Asn1.Asn1Encodable extensionValue)
		{
			this.extGenerator.AddExtension(oid, critical, extensionValue);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00009BE1 File Offset: 0x00007DE1
		public void AddExtension(string oid, bool critical, byte[] extensionValue)
		{
			this.extGenerator.AddExtension(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(oid), critical, new global::Org.BouncyCastle.Asn1.DerOctetString(extensionValue));
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00009BFB File Offset: 0x00007DFB
		public void AddExtension(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, bool critical, byte[] extensionValue)
		{
			this.extGenerator.AddExtension(oid, critical, new global::Org.BouncyCastle.Asn1.DerOctetString(extensionValue));
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00009C10 File Offset: 0x00007E10
		[global::System.Obsolete("Use Generate with an ISignatureFactory")]
		public global::Org.BouncyCastle.X509.X509Crl Generate(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey)
		{
			return this.Generate(privateKey, null);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00009C1A File Offset: 0x00007E1A
		[global::System.Obsolete("Use Generate with an ISignatureFactory")]
		public global::Org.BouncyCastle.X509.X509Crl Generate(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			return this.Generate(new global::Org.BouncyCastle.Crypto.Operators.Asn1SignatureFactory(this.signatureAlgorithm, privateKey, random));
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00009C30 File Offset: 0x00007E30
		public global::Org.BouncyCastle.X509.X509Crl Generate(global::Org.BouncyCastle.Crypto.ISignatureFactory signatureCalculatorFactory)
		{
			this.tbsGen.SetSignature((global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)signatureCalculatorFactory.AlgorithmDetails);
			global::Org.BouncyCastle.Asn1.X509.TbsCertificateList tbsCertList = this.GenerateCertList();
			global::Org.BouncyCastle.Crypto.IStreamCalculator streamCalculator = signatureCalculatorFactory.CreateCalculator();
			byte[] encoded = tbsCertList.GetDerEncoded();
			streamCalculator.Stream.Write(encoded, 0, encoded.Length);
			global::Org.BouncyCastle.Utilities.Platform.Dispose(streamCalculator.Stream);
			return this.GenerateJcaObject(tbsCertList, (global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)signatureCalculatorFactory.AlgorithmDetails, ((global::Org.BouncyCastle.Crypto.IBlockResult)streamCalculator.GetResult()).Collect());
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00009CA5 File Offset: 0x00007EA5
		private global::Org.BouncyCastle.Asn1.X509.TbsCertificateList GenerateCertList()
		{
			if (!this.extGenerator.IsEmpty)
			{
				this.tbsGen.SetExtensions(this.extGenerator.Generate());
			}
			return this.tbsGen.GenerateTbsCertList();
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00009CD5 File Offset: 0x00007ED5
		private global::Org.BouncyCastle.X509.X509Crl GenerateJcaObject(global::Org.BouncyCastle.Asn1.X509.TbsCertificateList tbsCrl, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier algId, byte[] signature)
		{
			return new global::Org.BouncyCastle.X509.X509Crl(global::Org.BouncyCastle.Asn1.X509.CertificateList.GetInstance(new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				tbsCrl,
				algId,
				new global::Org.BouncyCastle.Asn1.DerBitString(signature)
			})));
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00009CFD File Offset: 0x00007EFD
		public global::System.Collections.IEnumerable SignatureAlgNames
		{
			get
			{
				return global::Org.BouncyCastle.X509.X509Utilities.GetAlgNames();
			}
		}

		// Token: 0x040000BB RID: 187
		private readonly global::Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator extGenerator = new global::Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator();

		// Token: 0x040000BC RID: 188
		private global::Org.BouncyCastle.Asn1.X509.V2TbsCertListGenerator tbsGen;

		// Token: 0x040000BD RID: 189
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier sigOID;

		// Token: 0x040000BE RID: 190
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgId;

		// Token: 0x040000BF RID: 191
		private string signatureAlgorithm;
	}
}
