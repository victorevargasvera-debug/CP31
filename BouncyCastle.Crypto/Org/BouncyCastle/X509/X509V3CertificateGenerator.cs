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
using Org.BouncyCastle.X509.Extension;

namespace Org.BouncyCastle.X509
{
	// Token: 0x02000022 RID: 34
	public class X509V3CertificateGenerator
	{
		// Token: 0x0600018A RID: 394 RVA: 0x00009D04 File Offset: 0x00007F04
		public X509V3CertificateGenerator()
		{
			this.tbsGen = new global::Org.BouncyCastle.Asn1.X509.V3TbsCertificateGenerator();
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00009D22 File Offset: 0x00007F22
		public void Reset()
		{
			this.tbsGen = new global::Org.BouncyCastle.Asn1.X509.V3TbsCertificateGenerator();
			this.extGenerator.Reset();
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00009D3A File Offset: 0x00007F3A
		public void SetSerialNumber(global::Org.BouncyCastle.Math.BigInteger serialNumber)
		{
			if (serialNumber.SignValue <= 0)
			{
				throw new global::System.ArgumentException("serial number must be a positive integer", "serialNumber");
			}
			this.tbsGen.SetSerialNumber(new global::Org.BouncyCastle.Asn1.DerInteger(serialNumber));
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00009D66 File Offset: 0x00007F66
		public void SetIssuerDN(global::Org.BouncyCastle.Asn1.X509.X509Name issuer)
		{
			this.tbsGen.SetIssuer(issuer);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00009D74 File Offset: 0x00007F74
		public void SetNotBefore(global::System.DateTime date)
		{
			this.tbsGen.SetStartDate(new global::Org.BouncyCastle.Asn1.X509.Time(date));
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00009D87 File Offset: 0x00007F87
		public void SetNotAfter(global::System.DateTime date)
		{
			this.tbsGen.SetEndDate(new global::Org.BouncyCastle.Asn1.X509.Time(date));
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00009D9A File Offset: 0x00007F9A
		public void SetSubjectDN(global::Org.BouncyCastle.Asn1.X509.X509Name subject)
		{
			this.tbsGen.SetSubject(subject);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00009DA8 File Offset: 0x00007FA8
		public void SetPublicKey(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey)
		{
			this.tbsGen.SetSubjectPublicKeyInfo(global::Org.BouncyCastle.X509.SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(publicKey));
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00009DBC File Offset: 0x00007FBC
		[global::System.Obsolete("Not needed if Generate used with an ISignatureFactory")]
		public void SetSignatureAlgorithm(string signatureAlgorithm)
		{
			this.signatureAlgorithm = signatureAlgorithm;
			try
			{
				this.sigOid = global::Org.BouncyCastle.X509.X509Utilities.GetAlgorithmOid(signatureAlgorithm);
			}
			catch (global::System.Exception)
			{
				throw new global::System.ArgumentException("Unknown signature type requested: " + signatureAlgorithm);
			}
			this.sigAlgId = global::Org.BouncyCastle.X509.X509Utilities.GetSigAlgID(this.sigOid, signatureAlgorithm);
			this.tbsGen.SetSignature(this.sigAlgId);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00009E24 File Offset: 0x00008024
		public void SetSubjectUniqueID(bool[] uniqueID)
		{
			this.tbsGen.SetSubjectUniqueID(this.booleanToBitString(uniqueID));
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00009E38 File Offset: 0x00008038
		public void SetIssuerUniqueID(bool[] uniqueID)
		{
			this.tbsGen.SetIssuerUniqueID(this.booleanToBitString(uniqueID));
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00009E4C File Offset: 0x0000804C
		private global::Org.BouncyCastle.Asn1.DerBitString booleanToBitString(bool[] id)
		{
			byte[] bytes = new byte[(id.Length + 7) / 8];
			for (int i = 0; i != id.Length; i++)
			{
				if (id[i])
				{
					byte[] array = bytes;
					int num = i / 8;
					array[num] |= (byte)(1 << 7 - i % 8);
				}
			}
			int pad = id.Length % 8;
			if (pad == 0)
			{
				return new global::Org.BouncyCastle.Asn1.DerBitString(bytes);
			}
			return new global::Org.BouncyCastle.Asn1.DerBitString(bytes, 8 - pad);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00009EAB File Offset: 0x000080AB
		public void AddExtension(string oid, bool critical, global::Org.BouncyCastle.Asn1.Asn1Encodable extensionValue)
		{
			this.extGenerator.AddExtension(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(oid), critical, extensionValue);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00009EC0 File Offset: 0x000080C0
		public void AddExtension(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, bool critical, global::Org.BouncyCastle.Asn1.Asn1Encodable extensionValue)
		{
			this.extGenerator.AddExtension(oid, critical, extensionValue);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00009ED0 File Offset: 0x000080D0
		public void AddExtension(string oid, bool critical, byte[] extensionValue)
		{
			this.extGenerator.AddExtension(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(oid), critical, new global::Org.BouncyCastle.Asn1.DerOctetString(extensionValue));
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00009EEA File Offset: 0x000080EA
		public void AddExtension(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, bool critical, byte[] extensionValue)
		{
			this.extGenerator.AddExtension(oid, critical, new global::Org.BouncyCastle.Asn1.DerOctetString(extensionValue));
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00009EFF File Offset: 0x000080FF
		public void CopyAndAddExtension(string oid, bool critical, global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			this.CopyAndAddExtension(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(oid), critical, cert);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00009F10 File Offset: 0x00008110
		public void CopyAndAddExtension(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, bool critical, global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			global::Org.BouncyCastle.Asn1.Asn1OctetString extValue = cert.GetExtensionValue(oid);
			if (extValue == null)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateParsingException("extension " + ((oid != null) ? oid.ToString() : null) + " not present");
			}
			try
			{
				global::Org.BouncyCastle.Asn1.Asn1Encodable value = global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.FromExtensionValue(extValue);
				this.AddExtension(oid, critical, value);
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateParsingException(e.Message, e);
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00009F7C File Offset: 0x0000817C
		[global::System.Obsolete("Use Generate with an ISignatureFactory")]
		public global::Org.BouncyCastle.X509.X509Certificate Generate(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey)
		{
			return this.Generate(privateKey, null);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00009F86 File Offset: 0x00008186
		[global::System.Obsolete("Use Generate with an ISignatureFactory")]
		public global::Org.BouncyCastle.X509.X509Certificate Generate(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.Security.SecureRandom random)
		{
			return this.Generate(new global::Org.BouncyCastle.Crypto.Operators.Asn1SignatureFactory(this.signatureAlgorithm, privateKey, random));
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00009F9C File Offset: 0x0000819C
		public global::Org.BouncyCastle.X509.X509Certificate Generate(global::Org.BouncyCastle.Crypto.ISignatureFactory signatureCalculatorFactory)
		{
			this.tbsGen.SetSignature((global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)signatureCalculatorFactory.AlgorithmDetails);
			if (!this.extGenerator.IsEmpty)
			{
				this.tbsGen.SetExtensions(this.extGenerator.Generate());
			}
			global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure tbsCert = this.tbsGen.GenerateTbsCertificate();
			global::Org.BouncyCastle.Crypto.IStreamCalculator streamCalculator = signatureCalculatorFactory.CreateCalculator();
			byte[] encoded = tbsCert.GetDerEncoded();
			streamCalculator.Stream.Write(encoded, 0, encoded.Length);
			global::Org.BouncyCastle.Utilities.Platform.Dispose(streamCalculator.Stream);
			return this.GenerateJcaObject(tbsCert, (global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)signatureCalculatorFactory.AlgorithmDetails, ((global::Org.BouncyCastle.Crypto.IBlockResult)streamCalculator.GetResult()).Collect());
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000A039 File Offset: 0x00008239
		private global::Org.BouncyCastle.X509.X509Certificate GenerateJcaObject(global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure tbsCert, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlg, byte[] signature)
		{
			return new global::Org.BouncyCastle.X509.X509Certificate(new global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure(tbsCert, sigAlg, new global::Org.BouncyCastle.Asn1.DerBitString(signature)));
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0000A04D File Offset: 0x0000824D
		public global::System.Collections.IEnumerable SignatureAlgNames
		{
			get
			{
				return global::Org.BouncyCastle.X509.X509Utilities.GetAlgNames();
			}
		}

		// Token: 0x040000C0 RID: 192
		private readonly global::Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator extGenerator = new global::Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator();

		// Token: 0x040000C1 RID: 193
		private global::Org.BouncyCastle.Asn1.X509.V3TbsCertificateGenerator tbsGen;

		// Token: 0x040000C2 RID: 194
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier sigOid;

		// Token: 0x040000C3 RID: 195
		private global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgId;

		// Token: 0x040000C4 RID: 196
		private string signatureAlgorithm;
	}
}
