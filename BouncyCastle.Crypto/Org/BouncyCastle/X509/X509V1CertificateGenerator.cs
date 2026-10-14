using System;
using System.Collections;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.X509
{
	// Token: 0x0200001E RID: 30
	public class X509V1CertificateGenerator
	{
		// Token: 0x0600013E RID: 318 RVA: 0x00009122 File Offset: 0x00007322
		public X509V1CertificateGenerator()
		{
			this.tbsGen = new global::Org.BouncyCastle.Asn1.X509.V1TbsCertificateGenerator();
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00009135 File Offset: 0x00007335
		public void Reset()
		{
			this.tbsGen = new global::Org.BouncyCastle.Asn1.X509.V1TbsCertificateGenerator();
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00009142 File Offset: 0x00007342
		public void SetSerialNumber(global::Org.BouncyCastle.Math.BigInteger serialNumber)
		{
			if (serialNumber.SignValue <= 0)
			{
				throw new global::System.ArgumentException("serial number must be a positive integer", "serialNumber");
			}
			this.tbsGen.SetSerialNumber(new global::Org.BouncyCastle.Asn1.DerInteger(serialNumber));
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000916E File Offset: 0x0000736E
		public void SetIssuerDN(global::Org.BouncyCastle.Asn1.X509.X509Name issuer)
		{
			this.tbsGen.SetIssuer(issuer);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000917C File Offset: 0x0000737C
		public void SetNotBefore(global::System.DateTime date)
		{
			this.tbsGen.SetStartDate(new global::Org.BouncyCastle.Asn1.X509.Time(date));
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000918F File Offset: 0x0000738F
		public void SetNotAfter(global::System.DateTime date)
		{
			this.tbsGen.SetEndDate(new global::Org.BouncyCastle.Asn1.X509.Time(date));
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000091A2 File Offset: 0x000073A2
		public void SetSubjectDN(global::Org.BouncyCastle.Asn1.X509.X509Name subject)
		{
			this.tbsGen.SetSubject(subject);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000091B0 File Offset: 0x000073B0
		public void SetPublicKey(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
		{
			try
			{
				this.tbsGen.SetSubjectPublicKeyInfo(global::Org.BouncyCastle.X509.SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(publicKey));
			}
			catch (global::System.Exception e)
			{
				throw new global::System.ArgumentException("unable to process key - " + e.ToString());
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000091F8 File Offset: 0x000073F8
		[global::System.Obsolete("Not needed if Generate used with an ISignatureFactory")]
		public void SetSignatureAlgorithm(string signatureAlgorithm)
		{
			this.signatureAlgorithm = signatureAlgorithm;
			try
			{
				this.sigOID = global::Org.BouncyCastle.X509.X509Utilities.GetAlgorithmOid(signatureAlgorithm);
			}
			catch (global::System.Exception)
			{
				throw new global::System.ArgumentException("Unknown signature type requested", "signatureAlgorithm");
			}
			this.sigAlgId = global::Org.BouncyCastle.X509.X509Utilities.GetSigAlgID(this.sigOID, signatureAlgorithm);
			this.tbsGen.SetSignature(this.sigAlgId);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00009260 File Offset: 0x00007460
		[global::System.Obsolete("Use Generate with an ISignatureFactory")]
		public global::Org.BouncyCastle.X509.X509Certificate Generate(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey)
		{
			return this.Generate(privateKey, null);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000926A File Offset: 0x0000746A
		[global::System.Obsolete("Use Generate with an ISignatureFactory")]
		public global::Org.BouncyCastle.X509.X509Certificate Generate(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			return this.Generate(new global::Org.BouncyCastle.Crypto.Operators.Asn1SignatureFactory(this.signatureAlgorithm, privateKey, random));
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00009280 File Offset: 0x00007480
		public global::Org.BouncyCastle.X509.X509Certificate Generate(global::Org.BouncyCastle.Crypto.ISignatureFactory signatureCalculatorFactory)
		{
			this.tbsGen.SetSignature((global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)signatureCalculatorFactory.AlgorithmDetails);
			global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure tbsCert = this.tbsGen.GenerateTbsCertificate();
			global::Org.BouncyCastle.Crypto.IStreamCalculator streamCalculator = signatureCalculatorFactory.CreateCalculator();
			byte[] encoded = tbsCert.GetDerEncoded();
			streamCalculator.Stream.Write(encoded, 0, encoded.Length);
			global::Org.BouncyCastle.Utilities.Platform.Dispose(streamCalculator.Stream);
			return this.GenerateJcaObject(tbsCert, (global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)signatureCalculatorFactory.AlgorithmDetails, ((global::Org.BouncyCastle.Crypto.IBlockResult)streamCalculator.GetResult()).Collect());
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000092FA File Offset: 0x000074FA
		private global::Org.BouncyCastle.X509.X509Certificate GenerateJcaObject(global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure tbsCert, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlg, byte[] signature)
		{
			return new global::Org.BouncyCastle.X509.X509Certificate(new global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure(tbsCert, sigAlg, new global::Org.BouncyCastle.Asn1.DerBitString(signature)));
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000930E File Offset: 0x0000750E
		public global::System.Collections.IEnumerable SignatureAlgNames
		{
			get
			{
				return global::Org.BouncyCastle.X509.X509Utilities.GetAlgNames();
			}
		}

		// Token: 0x040000AF RID: 175
		private global::Org.BouncyCastle.Asn1.X509.V1TbsCertificateGenerator tbsGen;

		// Token: 0x040000B0 RID: 176
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier sigOID;

		// Token: 0x040000B1 RID: 177
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgId;

		// Token: 0x040000B2 RID: 178
		private string signatureAlgorithm;
	}
}
