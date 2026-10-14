using System;
using System.Collections;
using System.IO;
using System.Text;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Ess;
using Org.BouncyCastle.Asn1.Oiw;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Tsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.X509.Store;

namespace Org.BouncyCastle.Tsp
{
	// Token: 0x02000080 RID: 128
	public class TimeStampTokenGenerator
	{
		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x0001739C File Offset: 0x0001559C
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x000173A4 File Offset: 0x000155A4
		public global::Org.BouncyCastle.Tsp.Resolution Resolution
		{
			get
			{
				return this.resolution;
			}
			set
			{
				this.resolution = value;
			}
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x000173AD File Offset: 0x000155AD
		public TimeStampTokenGenerator(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key, global::Org.BouncyCastle.X509.X509Certificate cert, string digestOID, string tsaPolicyOID) : this(key, cert, digestOID, tsaPolicyOID, null, null)
		{
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x000173BC File Offset: 0x000155BC
		public TimeStampTokenGenerator(global::Org.BouncyCastle.Cms.SignerInfoGenerator signerInfoGen, global::Org.BouncyCastle.Crypto.IDigestFactory digestCalculator, global::Org.BouncyCastle.Asn1.DerObjectIdentifier tsaPolicy, bool isIssuerSerialIncluded)
		{
			this.signerInfoGenerator = signerInfoGen;
			this.digestCalculator = digestCalculator;
			this.tsaPolicyOID = tsaPolicy;
			if (this.signerInfoGenerator.certificate == null)
			{
				throw new global::System.ArgumentException("SignerInfoGenerator must have an associated certificate");
			}
			global::Org.BouncyCastle.X509.X509Certificate assocCert = this.signerInfoGenerator.certificate;
			global::Org.BouncyCastle.Tsp.TspUtil.ValidateCertificate(assocCert);
			try
			{
				global::Org.BouncyCastle.Crypto.IStreamCalculator calculator = digestCalculator.CreateCalculator();
				global::System.IO.Stream stream = calculator.Stream;
				byte[] certEnc = assocCert.GetEncoded();
				stream.Write(certEnc, 0, certEnc.Length);
				stream.Flush();
				global::Org.BouncyCastle.Utilities.Platform.Dispose(stream);
				if (((global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)digestCalculator.AlgorithmDetails).Algorithm.Equals(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1))
				{
					global::Org.BouncyCastle.Asn1.Ess.EssCertID essCertID = new global::Org.BouncyCastle.Asn1.Ess.EssCertID(((global::Org.BouncyCastle.Crypto.IBlockResult)calculator.GetResult()).Collect(), isIssuerSerialIncluded ? new global::Org.BouncyCastle.Asn1.X509.IssuerSerial(new global::Org.BouncyCastle.Asn1.X509.GeneralNames(new global::Org.BouncyCastle.Asn1.X509.GeneralName(assocCert.IssuerDN)), new global::Org.BouncyCastle.Asn1.DerInteger(assocCert.SerialNumber)) : null);
					this.signerInfoGenerator = signerInfoGen.NewBuilder().WithSignedAttributeGenerator(new global::Org.BouncyCastle.Tsp.TimeStampTokenGenerator.TableGen(signerInfoGen, essCertID)).Build(signerInfoGen.contentSigner, signerInfoGen.certificate);
				}
				else
				{
					new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(((global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)digestCalculator.AlgorithmDetails).Algorithm);
					global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2 essCertID2 = new global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2(((global::Org.BouncyCastle.Crypto.IBlockResult)calculator.GetResult()).Collect(), isIssuerSerialIncluded ? new global::Org.BouncyCastle.Asn1.X509.IssuerSerial(new global::Org.BouncyCastle.Asn1.X509.GeneralNames(new global::Org.BouncyCastle.Asn1.X509.GeneralName(assocCert.IssuerDN)), new global::Org.BouncyCastle.Asn1.DerInteger(assocCert.SerialNumber)) : null);
					this.signerInfoGenerator = signerInfoGen.NewBuilder().WithSignedAttributeGenerator(new global::Org.BouncyCastle.Tsp.TimeStampTokenGenerator.TableGen2(signerInfoGen, essCertID2)).Build(signerInfoGen.contentSigner, signerInfoGen.certificate);
				}
			}
			catch (global::System.Exception ex)
			{
				throw new global::Org.BouncyCastle.Tsp.TspException("Exception processing certificate", ex);
			}
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x0001757C File Offset: 0x0001577C
		public TimeStampTokenGenerator(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key, global::Org.BouncyCastle.X509.X509Certificate cert, string digestOID, string tsaPolicyOID, global::Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, global::Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr) : this(global::Org.BouncyCastle.Tsp.TimeStampTokenGenerator.makeInfoGenerator(key, cert, digestOID, signedAttr, unsignedAttr), global::Org.BouncyCastle.Crypto.Operators.Asn1DigestFactory.Get(global::Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1), (tsaPolicyOID != null) ? new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(tsaPolicyOID) : null, false)
		{
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x000175AC File Offset: 0x000157AC
		internal static global::Org.BouncyCastle.Cms.SignerInfoGenerator makeInfoGenerator(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key, global::Org.BouncyCastle.X509.X509Certificate cert, string digestOID, global::Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, global::Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
		{
			global::Org.BouncyCastle.Tsp.TspUtil.ValidateCertificate(cert);
			global::System.Collections.IDictionary signedAttrs;
			if (signedAttr != null)
			{
				signedAttrs = signedAttr.ToDictionary();
			}
			else
			{
				signedAttrs = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
			}
			global::Org.BouncyCastle.Crypto.Operators.Asn1SignatureFactory sigfact = new global::Org.BouncyCastle.Crypto.Operators.Asn1SignatureFactory(global::Org.BouncyCastle.Cms.CmsSignedHelper.Instance.GetDigestAlgName(digestOID) + "with" + global::Org.BouncyCastle.Cms.CmsSignedHelper.Instance.GetEncryptionAlgName(global::Org.BouncyCastle.Cms.CmsSignedHelper.Instance.GetEncOid(key, digestOID)), key);
			return new global::Org.BouncyCastle.Cms.SignerInfoGeneratorBuilder().WithSignedAttributeGenerator(new global::Org.BouncyCastle.Cms.DefaultSignedAttributeTableGenerator(new global::Org.BouncyCastle.Asn1.Cms.AttributeTable(signedAttrs))).WithUnsignedAttributeGenerator(new global::Org.BouncyCastle.Cms.SimpleAttributeTableGenerator(unsignedAttr)).Build(sigfact, cert);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0001762B File Offset: 0x0001582B
		public void SetCertificates(global::Org.BouncyCastle.X509.Store.IX509Store certificates)
		{
			this.x509Certs = certificates;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00017634 File Offset: 0x00015834
		public void SetCrls(global::Org.BouncyCastle.X509.Store.IX509Store crls)
		{
			this.x509Crls = crls;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x0001763D File Offset: 0x0001583D
		public void SetAccuracySeconds(int accuracySeconds)
		{
			this.accuracySeconds = accuracySeconds;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00017646 File Offset: 0x00015846
		public void SetAccuracyMillis(int accuracyMillis)
		{
			this.accuracyMillis = accuracyMillis;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x0001764F File Offset: 0x0001584F
		public void SetAccuracyMicros(int accuracyMicros)
		{
			this.accuracyMicros = accuracyMicros;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00017658 File Offset: 0x00015858
		public void SetOrdering(bool ordering)
		{
			this.ordering = ordering;
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00017661 File Offset: 0x00015861
		public void SetTsa(global::Org.BouncyCastle.Asn1.X509.GeneralName tsa)
		{
			this.tsa = tsa;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0001766A File Offset: 0x0001586A
		public global::Org.BouncyCastle.Tsp.TimeStampToken Generate(global::Org.BouncyCastle.Tsp.TimeStampRequest request, global::Org.BouncyCastle.Math.BigInteger serialNumber, global::System.DateTime genTime)
		{
			return this.Generate(request, serialNumber, genTime, null);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00017678 File Offset: 0x00015878
		public global::Org.BouncyCastle.Tsp.TimeStampToken Generate(global::Org.BouncyCastle.Tsp.TimeStampRequest request, global::Org.BouncyCastle.Math.BigInteger serialNumber, global::System.DateTime genTime, global::Org.BouncyCastle.Asn1.X509.X509Extensions additionalExtensions)
		{
			global::Org.BouncyCastle.Asn1.Tsp.MessageImprint messageImprint = new global::Org.BouncyCastle.Asn1.Tsp.MessageImprint(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(request.MessageImprintAlgOid), global::Org.BouncyCastle.Asn1.DerNull.Instance), request.GetMessageImprintDigest());
			global::Org.BouncyCastle.Asn1.Tsp.Accuracy accuracy = null;
			if (this.accuracySeconds > 0 || this.accuracyMillis > 0 || this.accuracyMicros > 0)
			{
				global::Org.BouncyCastle.Asn1.DerInteger seconds = null;
				if (this.accuracySeconds > 0)
				{
					seconds = new global::Org.BouncyCastle.Asn1.DerInteger(this.accuracySeconds);
				}
				global::Org.BouncyCastle.Asn1.DerInteger millis = null;
				if (this.accuracyMillis > 0)
				{
					millis = new global::Org.BouncyCastle.Asn1.DerInteger(this.accuracyMillis);
				}
				global::Org.BouncyCastle.Asn1.DerInteger micros = null;
				if (this.accuracyMicros > 0)
				{
					micros = new global::Org.BouncyCastle.Asn1.DerInteger(this.accuracyMicros);
				}
				accuracy = new global::Org.BouncyCastle.Asn1.Tsp.Accuracy(seconds, millis, micros);
			}
			global::Org.BouncyCastle.Asn1.DerBoolean derOrdering = null;
			if (this.ordering)
			{
				derOrdering = global::Org.BouncyCastle.Asn1.DerBoolean.GetInstance(this.ordering);
			}
			global::Org.BouncyCastle.Asn1.DerInteger nonce = null;
			if (request.Nonce != null)
			{
				nonce = new global::Org.BouncyCastle.Asn1.DerInteger(request.Nonce);
			}
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier tsaPolicy = this.tsaPolicyOID;
			if (request.ReqPolicy != null)
			{
				tsaPolicy = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(request.ReqPolicy);
			}
			if (tsaPolicy == null)
			{
				throw new global::Org.BouncyCastle.Tsp.TspValidationException("request contains no policy", 256);
			}
			global::Org.BouncyCastle.Asn1.X509.X509Extensions respExtensions = request.Extensions;
			if (additionalExtensions != null)
			{
				global::Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator extGen = new global::Org.BouncyCastle.Asn1.X509.X509ExtensionsGenerator();
				if (respExtensions != null)
				{
					foreach (object obj in respExtensions.ExtensionOids)
					{
						global::Org.BouncyCastle.Asn1.DerObjectIdentifier id = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(obj);
						extGen.AddExtension(id, respExtensions.GetExtension(global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(id)));
					}
				}
				foreach (object obj2 in additionalExtensions.ExtensionOids)
				{
					global::Org.BouncyCastle.Asn1.DerObjectIdentifier id2 = global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(obj2);
					extGen.AddExtension(id2, additionalExtensions.GetExtension(global::Org.BouncyCastle.Asn1.DerObjectIdentifier.GetInstance(id2)));
				}
				respExtensions = extGen.Generate();
			}
			global::Org.BouncyCastle.Asn1.DerGeneralizedTime generalizedTime;
			if (this.resolution != global::Org.BouncyCastle.Tsp.Resolution.R_SECONDS)
			{
				generalizedTime = new global::Org.BouncyCastle.Asn1.DerGeneralizedTime(this.createGeneralizedTime(genTime));
			}
			else
			{
				generalizedTime = new global::Org.BouncyCastle.Asn1.DerGeneralizedTime(genTime);
			}
			global::Org.BouncyCastle.Asn1.Tsp.TstInfo tstInfo = new global::Org.BouncyCastle.Asn1.Tsp.TstInfo(tsaPolicy, messageImprint, new global::Org.BouncyCastle.Asn1.DerInteger(serialNumber), generalizedTime, accuracy, derOrdering, nonce, this.tsa, respExtensions);
			global::Org.BouncyCastle.Tsp.TimeStampToken result;
			try
			{
				global::Org.BouncyCastle.Cms.CmsSignedDataGenerator signedDataGenerator = new global::Org.BouncyCastle.Cms.CmsSignedDataGenerator();
				byte[] derEncodedTstInfo = tstInfo.GetDerEncoded();
				if (request.CertReq)
				{
					signedDataGenerator.AddCertificates(this.x509Certs);
				}
				signedDataGenerator.AddCrls(this.x509Crls);
				signedDataGenerator.AddSignerInfoGenerator(this.signerInfoGenerator);
				result = new global::Org.BouncyCastle.Tsp.TimeStampToken(signedDataGenerator.Generate(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdCTTstInfo.Id, new global::Org.BouncyCastle.Cms.CmsProcessableByteArray(derEncodedTstInfo), true));
			}
			catch (global::Org.BouncyCastle.Cms.CmsException cmsEx)
			{
				throw new global::Org.BouncyCastle.Tsp.TspException("Error generating time-stamp token", cmsEx);
			}
			catch (global::System.IO.IOException e)
			{
				throw new global::Org.BouncyCastle.Tsp.TspException("Exception encoding info", e);
			}
			catch (global::Org.BouncyCastle.X509.Store.X509StoreException e2)
			{
				throw new global::Org.BouncyCastle.Tsp.TspException("Exception handling CertStore", e2);
			}
			return result;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00017954 File Offset: 0x00015B54
		private string createGeneralizedTime(global::System.DateTime genTime)
		{
			string format = "yyyyMMddHHmmss.fff";
			global::System.Text.StringBuilder sBuild = new global::System.Text.StringBuilder(genTime.ToString(format));
			int dotIndex = sBuild.ToString().IndexOf(".");
			if (dotIndex < 0)
			{
				sBuild.Append("Z");
				return sBuild.ToString();
			}
			switch (this.resolution)
			{
			case global::Org.BouncyCastle.Tsp.Resolution.R_TENTHS_OF_SECONDS:
				if (sBuild.Length > dotIndex + 2)
				{
					sBuild.Remove(dotIndex + 2, sBuild.Length - (dotIndex + 2));
				}
				break;
			case global::Org.BouncyCastle.Tsp.Resolution.R_HUNDREDTHS_OF_SECONDS:
				if (sBuild.Length > dotIndex + 3)
				{
					sBuild.Remove(dotIndex + 3, sBuild.Length - (dotIndex + 3));
				}
				break;
			}
			while (sBuild[sBuild.Length - 1] == '0')
			{
				sBuild.Remove(sBuild.Length - 1, 1);
			}
			if (sBuild.Length - 1 == dotIndex)
			{
				sBuild.Remove(sBuild.Length - 1, 1);
			}
			sBuild.Append("Z");
			return sBuild.ToString();
		}

		// Token: 0x040002C1 RID: 705
		private int accuracySeconds = -1;

		// Token: 0x040002C2 RID: 706
		private int accuracyMillis = -1;

		// Token: 0x040002C3 RID: 707
		private int accuracyMicros = -1;

		// Token: 0x040002C4 RID: 708
		private bool ordering;

		// Token: 0x040002C5 RID: 709
		private global::Org.BouncyCastle.Asn1.X509.GeneralName tsa;

		// Token: 0x040002C6 RID: 710
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier tsaPolicyOID;

		// Token: 0x040002C7 RID: 711
		private global::Org.BouncyCastle.X509.Store.IX509Store x509Certs;

		// Token: 0x040002C8 RID: 712
		private global::Org.BouncyCastle.X509.Store.IX509Store x509Crls;

		// Token: 0x040002C9 RID: 713
		private global::Org.BouncyCastle.Cms.SignerInfoGenerator signerInfoGenerator;

		// Token: 0x040002CA RID: 714
		private global::Org.BouncyCastle.Crypto.IDigestFactory digestCalculator;

		// Token: 0x040002CB RID: 715
		private global::Org.BouncyCastle.Tsp.Resolution resolution;

		// Token: 0x0200079E RID: 1950
		private class TableGen : global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator
		{
			// Token: 0x060044FE RID: 17662 RVA: 0x001325D8 File Offset: 0x001307D8
			public TableGen(global::Org.BouncyCastle.Cms.SignerInfoGenerator infoGen, global::Org.BouncyCastle.Asn1.Ess.EssCertID essCertID)
			{
				this.infoGen = infoGen;
				this.essCertID = essCertID;
			}

			// Token: 0x060044FF RID: 17663 RVA: 0x001325F0 File Offset: 0x001307F0
			public global::Org.BouncyCastle.Asn1.Cms.AttributeTable GetAttributes(global::System.Collections.IDictionary parameters)
			{
				global::Org.BouncyCastle.Asn1.Cms.AttributeTable tab = this.infoGen.signedGen.GetAttributes(parameters);
				if (tab[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAASigningCertificate] == null)
				{
					return tab.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAASigningCertificate, new global::Org.BouncyCastle.Asn1.Ess.SigningCertificate(this.essCertID));
				}
				return tab;
			}

			// Token: 0x040022E7 RID: 8935
			private readonly global::Org.BouncyCastle.Cms.SignerInfoGenerator infoGen;

			// Token: 0x040022E8 RID: 8936
			private readonly global::Org.BouncyCastle.Asn1.Ess.EssCertID essCertID;
		}

		// Token: 0x0200079F RID: 1951
		private class TableGen2 : global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator
		{
			// Token: 0x06004500 RID: 17664 RVA: 0x00132634 File Offset: 0x00130834
			public TableGen2(global::Org.BouncyCastle.Cms.SignerInfoGenerator infoGen, global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2 essCertID)
			{
				this.infoGen = infoGen;
				this.essCertID = essCertID;
			}

			// Token: 0x06004501 RID: 17665 RVA: 0x0013264C File Offset: 0x0013084C
			public global::Org.BouncyCastle.Asn1.Cms.AttributeTable GetAttributes(global::System.Collections.IDictionary parameters)
			{
				global::Org.BouncyCastle.Asn1.Cms.AttributeTable tab = this.infoGen.signedGen.GetAttributes(parameters);
				if (tab[global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAASigningCertificateV2] == null)
				{
					return tab.Add(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdAASigningCertificateV2, new global::Org.BouncyCastle.Asn1.Ess.SigningCertificateV2(this.essCertID));
				}
				return tab;
			}

			// Token: 0x040022E9 RID: 8937
			private readonly global::Org.BouncyCastle.Cms.SignerInfoGenerator infoGen;

			// Token: 0x040022EA RID: 8938
			private readonly global::Org.BouncyCastle.Asn1.Ess.EssCertIDv2 essCertID;
		}
	}
}
