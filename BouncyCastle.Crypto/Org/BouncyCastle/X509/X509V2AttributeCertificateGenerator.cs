using System;
using System.Collections;
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
	// Token: 0x02000020 RID: 32
	public class X509V2AttributeCertificateGenerator
	{
		// Token: 0x06000166 RID: 358 RVA: 0x000097B9 File Offset: 0x000079B9
		public X509V2AttributeCertificateGenerator()
		{
			this.acInfoGen = new global::Org.BouncyCastle.Asn1.X509.V2AttributeCertificateInfoGenerator();
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000097D7 File Offset: 0x000079D7
		public void Reset()
		{
			this.acInfoGen = new global::Org.BouncyCastle.Asn1.X509.V2AttributeCertificateInfoGenerator();
			this.extGenerator.Reset();
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000097EF File Offset: 0x000079EF
		public void SetHolder(global::Org.BouncyCastle.X509.AttributeCertificateHolder holder)
		{
			this.acInfoGen.SetHolder(holder.holder);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00009802 File Offset: 0x00007A02
		public void SetIssuer(global::Org.BouncyCastle.X509.AttributeCertificateIssuer issuer)
		{
			this.acInfoGen.SetIssuer(global::Org.BouncyCastle.Asn1.X509.AttCertIssuer.GetInstance(issuer.form));
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000981A File Offset: 0x00007A1A
		public void SetSerialNumber(global::Org.BouncyCastle.Math.BigInteger serialNumber)
		{
			this.acInfoGen.SetSerialNumber(new global::Org.BouncyCastle.Asn1.DerInteger(serialNumber));
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000982D File Offset: 0x00007A2D
		public void SetNotBefore(global::System.DateTime date)
		{
			this.acInfoGen.SetStartDate(new global::Org.BouncyCastle.Asn1.DerGeneralizedTime(date));
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00009840 File Offset: 0x00007A40
		public void SetNotAfter(global::System.DateTime date)
		{
			this.acInfoGen.SetEndDate(new global::Org.BouncyCastle.Asn1.DerGeneralizedTime(date));
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00009854 File Offset: 0x00007A54
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
				throw new global::System.ArgumentException("Unknown signature type requested");
			}
			this.sigAlgId = global::Org.BouncyCastle.X509.X509Utilities.GetSigAlgID(this.sigOID, signatureAlgorithm);
			this.acInfoGen.SetSignature(this.sigAlgId);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000098B8 File Offset: 0x00007AB8
		public void AddAttribute(global::Org.BouncyCastle.X509.X509Attribute attribute)
		{
			this.acInfoGen.AddAttribute(global::Org.BouncyCastle.Asn1.X509.AttributeX509.GetInstance(attribute.ToAsn1Object()));
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000098D0 File Offset: 0x00007AD0
		public void SetIssuerUniqueId(bool[] iui)
		{
			throw global::Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException("SetIssuerUniqueId()");
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000098DC File Offset: 0x00007ADC
		public void AddExtension(string oid, bool critical, global::Org.BouncyCastle.Asn1.Asn1Encodable extensionValue)
		{
			this.extGenerator.AddExtension(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(oid), critical, extensionValue);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x000098F1 File Offset: 0x00007AF1
		public void AddExtension(string oid, bool critical, byte[] extensionValue)
		{
			this.extGenerator.AddExtension(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(oid), critical, extensionValue);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00009906 File Offset: 0x00007B06
		[global::System.Obsolete("Use Generate with an ISignatureFactory")]
		public global::Org.BouncyCastle.X509.IX509AttributeCertificate Generate(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey)
		{
			return this.Generate(privateKey, null);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00009910 File Offset: 0x00007B10
		[global::System.Obsolete("Use Generate with an ISignatureFactory")]
		public global::Org.BouncyCastle.X509.IX509AttributeCertificate Generate(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			return this.Generate(new global::Org.BouncyCastle.Crypto.Operators.Asn1SignatureFactory(this.signatureAlgorithm, privateKey, random));
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00009928 File Offset: 0x00007B28
		public global::Org.BouncyCastle.X509.IX509AttributeCertificate Generate(global::Org.BouncyCastle.Crypto.ISignatureFactory signatureCalculatorFactory)
		{
			if (!this.extGenerator.IsEmpty)
			{
				this.acInfoGen.SetExtensions(this.extGenerator.Generate());
			}
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgID = (global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)signatureCalculatorFactory.AlgorithmDetails;
			this.acInfoGen.SetSignature(sigAlgID);
			global::Org.BouncyCastle.Asn1.X509.AttributeCertificateInfo acInfo = this.acInfoGen.GenerateAttributeCertificateInfo();
			byte[] encoded = acInfo.GetDerEncoded();
			global::Org.BouncyCastle.Crypto.IStreamCalculator streamCalculator = signatureCalculatorFactory.CreateCalculator();
			streamCalculator.Stream.Write(encoded, 0, encoded.Length);
			global::Org.BouncyCastle.Utilities.Platform.Dispose(streamCalculator.Stream);
			global::Org.BouncyCastle.X509.IX509AttributeCertificate result;
			try
			{
				global::Org.BouncyCastle.Asn1.DerBitString signatureValue = new global::Org.BouncyCastle.Asn1.DerBitString(((global::Org.BouncyCastle.Crypto.IBlockResult)streamCalculator.GetResult()).Collect());
				result = new global::Org.BouncyCastle.X509.X509V2AttributeCertificate(new global::Org.BouncyCastle.Asn1.X509.AttributeCertificate(acInfo, sigAlgID, signatureValue));
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException("constructed invalid certificate", e);
			}
			return result;
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000175 RID: 373 RVA: 0x000099F0 File Offset: 0x00007BF0
		public global::System.Collections.IEnumerable SignatureAlgNames
		{
			get
			{
				return global::Org.BouncyCastle.X509.X509Utilities.GetAlgNames();
			}
		}

		// Token: 0x040000B6 RID: 182
		private readonly global::Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator extGenerator = new global::Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator();

		// Token: 0x040000B7 RID: 183
		private global::Org.BouncyCastle.Asn1.X509.V2AttributeCertificateInfoGenerator acInfoGen;

		// Token: 0x040000B8 RID: 184
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier sigOID;

		// Token: 0x040000B9 RID: 185
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgId;

		// Token: 0x040000BA RID: 186
		private string signatureAlgorithm;
	}
}
