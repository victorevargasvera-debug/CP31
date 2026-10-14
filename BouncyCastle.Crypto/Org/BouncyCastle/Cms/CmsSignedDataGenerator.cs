using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Operators;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000537 RID: 1335
	public class CmsSignedDataGenerator : global::Org.BouncyCastle.Cms.CmsSignedGenerator
	{
		// Token: 0x06003376 RID: 13174 RVA: 0x000F50D8 File Offset: 0x000F32D8
		public CmsSignedDataGenerator()
		{
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x000F50EB File Offset: 0x000F32EB
		public CmsSignedDataGenerator(global::Org.BouncyCastle.Security.SecureRandom rand) : base(rand)
		{
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x000F50FF File Offset: 0x000F32FF
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.X509.X509Certificate cert, string digestOID)
		{
			this.AddSigner(privateKey, cert, global::Org.BouncyCastle.Cms.CmsSignedDataGenerator.Helper.GetEncOid(privateKey, digestOID), digestOID);
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x000F5116 File Offset: 0x000F3316
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.X509.X509Certificate cert, string encryptionOID, string digestOID)
		{
			this.doAddSigner(privateKey, global::Org.BouncyCastle.Cms.CmsSignedGenerator.GetSignerIdentifier(cert), encryptionOID, digestOID, new global::Org.BouncyCastle.Cms.DefaultSignedAttributeTableGenerator(), null, null);
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x000F512F File Offset: 0x000F332F
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string digestOID)
		{
			this.AddSigner(privateKey, subjectKeyID, global::Org.BouncyCastle.Cms.CmsSignedDataGenerator.Helper.GetEncOid(privateKey, digestOID), digestOID);
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x000F5146 File Offset: 0x000F3346
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string encryptionOID, string digestOID)
		{
			this.doAddSigner(privateKey, global::Org.BouncyCastle.Cms.CmsSignedGenerator.GetSignerIdentifier(subjectKeyID), encryptionOID, digestOID, new global::Org.BouncyCastle.Cms.DefaultSignedAttributeTableGenerator(), null, null);
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x000F515F File Offset: 0x000F335F
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.X509.X509Certificate cert, string digestOID, global::Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, global::Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
		{
			this.AddSigner(privateKey, cert, global::Org.BouncyCastle.Cms.CmsSignedDataGenerator.Helper.GetEncOid(privateKey, digestOID), digestOID, signedAttr, unsignedAttr);
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x000F517A File Offset: 0x000F337A
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.X509.X509Certificate cert, string encryptionOID, string digestOID, global::Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, global::Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
		{
			this.doAddSigner(privateKey, global::Org.BouncyCastle.Cms.CmsSignedGenerator.GetSignerIdentifier(cert), encryptionOID, digestOID, new global::Org.BouncyCastle.Cms.DefaultSignedAttributeTableGenerator(signedAttr), new global::Org.BouncyCastle.Cms.SimpleAttributeTableGenerator(unsignedAttr), signedAttr);
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x000F519C File Offset: 0x000F339C
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string digestOID, global::Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, global::Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
		{
			this.AddSigner(privateKey, subjectKeyID, global::Org.BouncyCastle.Cms.CmsSignedDataGenerator.Helper.GetEncOid(privateKey, digestOID), digestOID, signedAttr, unsignedAttr);
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x000F51B7 File Offset: 0x000F33B7
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string encryptionOID, string digestOID, global::Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, global::Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
		{
			this.doAddSigner(privateKey, global::Org.BouncyCastle.Cms.CmsSignedGenerator.GetSignerIdentifier(subjectKeyID), encryptionOID, digestOID, new global::Org.BouncyCastle.Cms.DefaultSignedAttributeTableGenerator(signedAttr), new global::Org.BouncyCastle.Cms.SimpleAttributeTableGenerator(unsignedAttr), signedAttr);
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x000F51D9 File Offset: 0x000F33D9
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.X509.X509Certificate cert, string digestOID, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator signedAttrGen, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsignedAttrGen)
		{
			this.AddSigner(privateKey, cert, global::Org.BouncyCastle.Cms.CmsSignedDataGenerator.Helper.GetEncOid(privateKey, digestOID), digestOID, signedAttrGen, unsignedAttrGen);
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x000F51F4 File Offset: 0x000F33F4
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.X509.X509Certificate cert, string encryptionOID, string digestOID, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator signedAttrGen, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsignedAttrGen)
		{
			this.doAddSigner(privateKey, global::Org.BouncyCastle.Cms.CmsSignedGenerator.GetSignerIdentifier(cert), encryptionOID, digestOID, signedAttrGen, unsignedAttrGen, null);
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x000F520B File Offset: 0x000F340B
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string digestOID, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator signedAttrGen, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsignedAttrGen)
		{
			this.AddSigner(privateKey, subjectKeyID, global::Org.BouncyCastle.Cms.CmsSignedDataGenerator.Helper.GetEncOid(privateKey, digestOID), digestOID, signedAttrGen, unsignedAttrGen);
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x000F5226 File Offset: 0x000F3426
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string encryptionOID, string digestOID, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator signedAttrGen, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsignedAttrGen)
		{
			this.doAddSigner(privateKey, global::Org.BouncyCastle.Cms.CmsSignedGenerator.GetSignerIdentifier(subjectKeyID), encryptionOID, digestOID, signedAttrGen, unsignedAttrGen, null);
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x000F523D File Offset: 0x000F343D
		public void AddSignerInfoGenerator(global::Org.BouncyCastle.Cms.SignerInfoGenerator signerInfoGenerator)
		{
			this.signerInfs.Add(new global::Org.BouncyCastle.Cms.CmsSignedDataGenerator.SignerInf(this, signerInfoGenerator.contentSigner, signerInfoGenerator.sigId, signerInfoGenerator.signedGen, signerInfoGenerator.unsignedGen, null));
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x000F526C File Offset: 0x000F346C
		private void doAddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier signerIdentifier, string encryptionOID, string digestOID, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator signedAttrGen, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsignedAttrGen, global::Org.BouncyCastle.Asn1.Cms.AttributeTable baseSignedTable)
		{
			this.signerInfs.Add(new global::Org.BouncyCastle.Cms.CmsSignedDataGenerator.SignerInf(this, privateKey, signerIdentifier, digestOID, encryptionOID, signedAttrGen, unsignedAttrGen, baseSignedTable));
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x000F5296 File Offset: 0x000F3496
		public global::Org.BouncyCastle.Cms.CmsSignedData Generate(global::Org.BouncyCastle.Cms.CmsProcessable content)
		{
			return this.Generate(content, false);
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x000F52A0 File Offset: 0x000F34A0
		public global::Org.BouncyCastle.Cms.CmsSignedData Generate(string signedContentType, global::Org.BouncyCastle.Cms.CmsProcessable content, bool encapsulate)
		{
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector digestAlgs = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector signerInfos = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			this._digests.Clear();
			foreach (object obj in this._signers)
			{
				global::Org.BouncyCastle.Cms.SignerInformation signer = (global::Org.BouncyCastle.Cms.SignerInformation)obj;
				digestAlgs.Add(global::Org.BouncyCastle.Cms.CmsSignedDataGenerator.Helper.FixAlgID(signer.DigestAlgorithmID));
				signerInfos.Add(signer.ToSignerInfo());
			}
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentTypeOid = (signedContentType == null) ? null : new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(signedContentType);
			foreach (object obj2 in this.signerInfs)
			{
				global::Org.BouncyCastle.Cms.CmsSignedDataGenerator.SignerInf signer2 = (global::Org.BouncyCastle.Cms.CmsSignedDataGenerator.SignerInf)obj2;
				try
				{
					digestAlgs.Add(signer2.DigestAlgorithmID);
					signerInfos.Add(signer2.ToSignerInfo(contentTypeOid, content, this.rand));
				}
				catch (global::System.IO.IOException e)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("encoding error.", e);
				}
				catch (global::Org.BouncyCastle.Security.InvalidKeyException e2)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("key inappropriate for signature.", e2);
				}
				catch (global::Org.BouncyCastle.Security.SignatureException e3)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("error creating signature.", e3);
				}
				catch (global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException e4)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("error creating sid.", e4);
				}
			}
			global::Org.BouncyCastle.Asn1.Asn1Set certificates = null;
			if (this._certs.Count != 0)
			{
				certificates = (base.UseDerForCerts ? global::Org.BouncyCastle.Cms.CmsUtilities.CreateDerSetFromList(this._certs) : global::Org.BouncyCastle.Cms.CmsUtilities.CreateBerSetFromList(this._certs));
			}
			global::Org.BouncyCastle.Asn1.Asn1Set certrevlist = null;
			if (this._crls.Count != 0)
			{
				certrevlist = (base.UseDerForCrls ? global::Org.BouncyCastle.Cms.CmsUtilities.CreateDerSetFromList(this._crls) : global::Org.BouncyCastle.Cms.CmsUtilities.CreateBerSetFromList(this._crls));
			}
			global::Org.BouncyCastle.Asn1.Asn1OctetString octs = null;
			if (encapsulate)
			{
				global::System.IO.MemoryStream bOut = new global::System.IO.MemoryStream();
				if (content != null)
				{
					try
					{
						content.Write(bOut);
					}
					catch (global::System.IO.IOException e5)
					{
						throw new global::Org.BouncyCastle.Cms.CmsException("encapsulation error.", e5);
					}
				}
				octs = new global::Org.BouncyCastle.Asn1.BerOctetString(bOut.ToArray());
			}
			global::Org.BouncyCastle.Asn1.Cms.ContentInfo encInfo = new global::Org.BouncyCastle.Asn1.Cms.ContentInfo(contentTypeOid, octs);
			global::Org.BouncyCastle.Asn1.Cms.SignedData sd = new global::Org.BouncyCastle.Asn1.Cms.SignedData(new global::Org.BouncyCastle.Asn1.DerSet(digestAlgs), encInfo, certificates, certrevlist, new global::Org.BouncyCastle.Asn1.DerSet(signerInfos));
			global::Org.BouncyCastle.Asn1.Cms.ContentInfo contentInfo = new global::Org.BouncyCastle.Asn1.Cms.ContentInfo(global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.SignedData, sd);
			return new global::Org.BouncyCastle.Cms.CmsSignedData(content, contentInfo);
		}

		// Token: 0x06003388 RID: 13192 RVA: 0x000F54FC File Offset: 0x000F36FC
		public global::Org.BouncyCastle.Cms.CmsSignedData Generate(global::Org.BouncyCastle.Cms.CmsProcessable content, bool encapsulate)
		{
			return this.Generate(global::Org.BouncyCastle.Cms.CmsSignedGenerator.Data, content, encapsulate);
		}

		// Token: 0x06003389 RID: 13193 RVA: 0x000F550B File Offset: 0x000F370B
		public global::Org.BouncyCastle.Cms.SignerInformationStore GenerateCounterSigners(global::Org.BouncyCastle.Cms.SignerInformation signer)
		{
			return this.Generate(null, new global::Org.BouncyCastle.Cms.CmsProcessableByteArray(signer.GetSignature()), false).GetSignerInfos();
		}

		// Token: 0x040016F6 RID: 5878
		private static readonly global::Org.BouncyCastle.Cms.CmsSignedHelper Helper = global::Org.BouncyCastle.Cms.CmsSignedHelper.Instance;

		// Token: 0x040016F7 RID: 5879
		private readonly global::System.Collections.IList signerInfs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x0200083E RID: 2110
		private class SignerInf
		{
			// Token: 0x0600471E RID: 18206 RVA: 0x0013A3C0 File Offset: 0x001385C0
			internal SignerInf(global::Org.BouncyCastle.Cms.CmsSignedGenerator outer, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key, global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier signerIdentifier, string digestOID, string encOID, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator sAttr, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsAttr, global::Org.BouncyCastle.Asn1.Cms.AttributeTable baseSignedTable)
			{
				string signatureName = global::Org.BouncyCastle.Cms.CmsSignedDataGenerator.Helper.GetDigestAlgName(digestOID) + "with" + global::Org.BouncyCastle.Cms.CmsSignedDataGenerator.Helper.GetEncryptionAlgName(encOID);
				this.outer = outer;
				this.sigCalc = new global::Org.BouncyCastle.Crypto.Operators.Asn1SignatureFactory(signatureName, key);
				this.signerIdentifier = signerIdentifier;
				this.digestOID = digestOID;
				this.encOID = encOID;
				this.sAttr = sAttr;
				this.unsAttr = unsAttr;
				this.baseSignedTable = baseSignedTable;
			}

			// Token: 0x0600471F RID: 18207 RVA: 0x0013A43C File Offset: 0x0013863C
			internal SignerInf(global::Org.BouncyCastle.Cms.CmsSignedGenerator outer, global::Org.BouncyCastle.Crypto.ISignatureFactory sigCalc, global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier signerIdentifier, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator sAttr, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsAttr, global::Org.BouncyCastle.Asn1.Cms.AttributeTable baseSignedTable)
			{
				this.outer = outer;
				this.sigCalc = sigCalc;
				this.signerIdentifier = signerIdentifier;
				this.digestOID = new global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder().find((global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)sigCalc.AlgorithmDetails).Algorithm.Id;
				this.encOID = ((global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier)sigCalc.AlgorithmDetails).Algorithm.Id;
				this.sAttr = sAttr;
				this.unsAttr = unsAttr;
				this.baseSignedTable = baseSignedTable;
			}

			// Token: 0x17000AB7 RID: 2743
			// (get) Token: 0x06004720 RID: 18208 RVA: 0x0013A4BC File Offset: 0x001386BC
			internal global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DigestAlgorithmID
			{
				get
				{
					return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(this.digestOID), global::Org.BouncyCastle.Asn1.DerNull.Instance);
				}
			}

			// Token: 0x17000AB8 RID: 2744
			// (get) Token: 0x06004721 RID: 18209 RVA: 0x0013A4D3 File Offset: 0x001386D3
			internal global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator SignedAttributes
			{
				get
				{
					return this.sAttr;
				}
			}

			// Token: 0x17000AB9 RID: 2745
			// (get) Token: 0x06004722 RID: 18210 RVA: 0x0013A4DB File Offset: 0x001386DB
			internal global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator UnsignedAttributes
			{
				get
				{
					return this.unsAttr;
				}
			}

			// Token: 0x06004723 RID: 18211 RVA: 0x0013A4E4 File Offset: 0x001386E4
			internal global::Org.BouncyCastle.Asn1.Cms.SignerInfo ToSignerInfo(global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentType, global::Org.BouncyCastle.Cms.CmsProcessable content, global::Org.BouncyCastle.Security.SecureRandom random)
			{
				global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digAlgId = this.DigestAlgorithmID;
				string digestName = global::Org.BouncyCastle.Cms.CmsSignedDataGenerator.Helper.GetDigestAlgName(this.digestOID);
				string algorithm = digestName + "with" + global::Org.BouncyCastle.Cms.CmsSignedDataGenerator.Helper.GetEncryptionAlgName(this.encOID);
				byte[] hash;
				if (this.outer._digests.Contains(this.digestOID))
				{
					hash = (byte[])this.outer._digests[this.digestOID];
				}
				else
				{
					global::Org.BouncyCastle.Crypto.IDigest dig = global::Org.BouncyCastle.Cms.CmsSignedDataGenerator.Helper.GetDigestInstance(digestName);
					if (content != null)
					{
						content.Write(new global::Org.BouncyCastle.Crypto.IO.DigestSink(dig));
					}
					hash = global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(dig);
					this.outer._digests.Add(this.digestOID, hash.Clone());
				}
				global::Org.BouncyCastle.Crypto.IStreamCalculator streamCalculator = this.sigCalc.CreateCalculator();
				global::System.IO.Stream sigStr = new global::System.IO.BufferedStream(streamCalculator.Stream);
				global::Org.BouncyCastle.Asn1.Asn1Set signedAttr = null;
				if (this.sAttr != null)
				{
					global::System.Collections.IDictionary parameters = this.outer.GetBaseParameters(contentType, digAlgId, hash);
					global::Org.BouncyCastle.Asn1.Cms.AttributeTable signed = this.sAttr.GetAttributes(parameters);
					if (contentType == null && signed != null && signed[global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.ContentType] != null)
					{
						global::System.Collections.IDictionary dictionary = signed.ToDictionary();
						dictionary.Remove(global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.ContentType);
						signed = new global::Org.BouncyCastle.Asn1.Cms.AttributeTable(dictionary);
					}
					signedAttr = this.outer.GetAttributeSet(signed);
					signedAttr.EncodeTo(sigStr, "DER");
				}
				else if (content != null)
				{
					content.Write(sigStr);
				}
				global::Org.BouncyCastle.Utilities.Platform.Dispose(sigStr);
				byte[] sigBytes = ((global::Org.BouncyCastle.Crypto.IBlockResult)streamCalculator.GetResult()).Collect();
				global::Org.BouncyCastle.Asn1.Asn1Set unsignedAttr = null;
				if (this.unsAttr != null)
				{
					global::System.Collections.IDictionary baseParameters = this.outer.GetBaseParameters(contentType, digAlgId, hash);
					baseParameters[global::Org.BouncyCastle.Cms.CmsAttributeTableParameter.Signature] = sigBytes.Clone();
					global::Org.BouncyCastle.Asn1.Cms.AttributeTable unsigned = this.unsAttr.GetAttributes(baseParameters);
					unsignedAttr = this.outer.GetAttributeSet(unsigned);
				}
				global::Org.BouncyCastle.Asn1.Asn1Encodable sigX509Parameters = global::Org.BouncyCastle.Security.SignerUtilities.GetDefaultX509Parameters(algorithm);
				global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier encAlgId = global::Org.BouncyCastle.Cms.CmsSignedDataGenerator.Helper.GetEncAlgorithmIdentifier(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(this.encOID), sigX509Parameters);
				return new global::Org.BouncyCastle.Asn1.Cms.SignerInfo(this.signerIdentifier, digAlgId, signedAttr, encAlgId, new global::Org.BouncyCastle.Asn1.DerOctetString(sigBytes), unsignedAttr);
			}

			// Token: 0x04002590 RID: 9616
			private readonly global::Org.BouncyCastle.Cms.CmsSignedGenerator outer;

			// Token: 0x04002591 RID: 9617
			private readonly global::Org.BouncyCastle.Crypto.ISignatureFactory sigCalc;

			// Token: 0x04002592 RID: 9618
			private readonly global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier signerIdentifier;

			// Token: 0x04002593 RID: 9619
			private readonly string digestOID;

			// Token: 0x04002594 RID: 9620
			private readonly string encOID;

			// Token: 0x04002595 RID: 9621
			private readonly global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator sAttr;

			// Token: 0x04002596 RID: 9622
			private readonly global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsAttr;

			// Token: 0x04002597 RID: 9623
			private readonly global::Org.BouncyCastle.Asn1.Cms.AttributeTable baseSignedTable;
		}
	}
}
