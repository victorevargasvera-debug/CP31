using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.Utilities.IO;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000539 RID: 1337
	public class CmsSignedDataStreamGenerator : global::Org.BouncyCastle.Cms.CmsSignedGenerator
	{
		// Token: 0x0600339C RID: 13212 RVA: 0x000F5AF1 File Offset: 0x000F3CF1
		public CmsSignedDataStreamGenerator()
		{
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x000F5B25 File Offset: 0x000F3D25
		public CmsSignedDataStreamGenerator(global::Org.BouncyCastle.Security.SecureRandom rand) : base(rand)
		{
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x000F5B5A File Offset: 0x000F3D5A
		public void SetBufferSize(int bufferSize)
		{
			this._bufferSize = bufferSize;
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x000F5B63 File Offset: 0x000F3D63
		public void AddDigests(params string[] digestOids)
		{
			this.AddDigests(digestOids);
		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x000F5B6C File Offset: 0x000F3D6C
		public void AddDigests(global::System.Collections.IEnumerable digestOids)
		{
			foreach (object obj in digestOids)
			{
				string digestOid = (string)obj;
				this.ConfigureDigest(digestOid);
			}
		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x000F5BC0 File Offset: 0x000F3DC0
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.X509.X509Certificate cert, string digestOid)
		{
			this.AddSigner(privateKey, cert, digestOid, new global::Org.BouncyCastle.Cms.DefaultSignedAttributeTableGenerator(), null);
		}

		// Token: 0x060033A2 RID: 13218 RVA: 0x000F5BD1 File Offset: 0x000F3DD1
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.X509.X509Certificate cert, string encryptionOid, string digestOid)
		{
			this.AddSigner(privateKey, cert, encryptionOid, digestOid, new global::Org.BouncyCastle.Cms.DefaultSignedAttributeTableGenerator(), null);
		}

		// Token: 0x060033A3 RID: 13219 RVA: 0x000F5BE4 File Offset: 0x000F3DE4
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.X509.X509Certificate cert, string digestOid, global::Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, global::Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
		{
			this.AddSigner(privateKey, cert, digestOid, new global::Org.BouncyCastle.Cms.DefaultSignedAttributeTableGenerator(signedAttr), new global::Org.BouncyCastle.Cms.SimpleAttributeTableGenerator(unsignedAttr));
		}

		// Token: 0x060033A4 RID: 13220 RVA: 0x000F5BFD File Offset: 0x000F3DFD
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.X509.X509Certificate cert, string encryptionOid, string digestOid, global::Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, global::Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
		{
			this.AddSigner(privateKey, cert, encryptionOid, digestOid, new global::Org.BouncyCastle.Cms.DefaultSignedAttributeTableGenerator(signedAttr), new global::Org.BouncyCastle.Cms.SimpleAttributeTableGenerator(unsignedAttr));
		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x000F5C18 File Offset: 0x000F3E18
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.X509.X509Certificate cert, string digestOid, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator signedAttrGenerator, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsignedAttrGenerator)
		{
			this.AddSigner(privateKey, cert, global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.Helper.GetEncOid(privateKey, digestOid), digestOid, signedAttrGenerator, unsignedAttrGenerator);
		}

		// Token: 0x060033A6 RID: 13222 RVA: 0x000F5C33 File Offset: 0x000F3E33
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.X509.X509Certificate cert, string encryptionOid, string digestOid, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator signedAttrGenerator, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsignedAttrGenerator)
		{
			this.DoAddSigner(privateKey, global::Org.BouncyCastle.Cms.CmsSignedGenerator.GetSignerIdentifier(cert), encryptionOid, digestOid, signedAttrGenerator, unsignedAttrGenerator);
		}

		// Token: 0x060033A7 RID: 13223 RVA: 0x000F5C49 File Offset: 0x000F3E49
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string digestOid)
		{
			this.AddSigner(privateKey, subjectKeyID, digestOid, new global::Org.BouncyCastle.Cms.DefaultSignedAttributeTableGenerator(), null);
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x000F5C5A File Offset: 0x000F3E5A
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string encryptionOid, string digestOid)
		{
			this.AddSigner(privateKey, subjectKeyID, encryptionOid, digestOid, new global::Org.BouncyCastle.Cms.DefaultSignedAttributeTableGenerator(), null);
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x000F5C6D File Offset: 0x000F3E6D
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string digestOid, global::Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttr, global::Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr)
		{
			this.AddSigner(privateKey, subjectKeyID, digestOid, new global::Org.BouncyCastle.Cms.DefaultSignedAttributeTableGenerator(signedAttr), new global::Org.BouncyCastle.Cms.SimpleAttributeTableGenerator(unsignedAttr));
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x000F5C86 File Offset: 0x000F3E86
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string digestOid, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator signedAttrGenerator, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsignedAttrGenerator)
		{
			this.AddSigner(privateKey, subjectKeyID, global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.Helper.GetEncOid(privateKey, digestOid), digestOid, signedAttrGenerator, unsignedAttrGenerator);
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x000F5CA1 File Offset: 0x000F3EA1
		public void AddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, byte[] subjectKeyID, string encryptionOid, string digestOid, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator signedAttrGenerator, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsignedAttrGenerator)
		{
			this.DoAddSigner(privateKey, global::Org.BouncyCastle.Cms.CmsSignedGenerator.GetSignerIdentifier(subjectKeyID), encryptionOid, digestOid, signedAttrGenerator, unsignedAttrGenerator);
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x000F5CB8 File Offset: 0x000F3EB8
		private void DoAddSigner(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier signerIdentifier, string encryptionOid, string digestOid, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator signedAttrGenerator, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsignedAttrGenerator)
		{
			this.ConfigureDigest(digestOid);
			global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.SignerInfoGeneratorImpl signerInf = new global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.SignerInfoGeneratorImpl(this, privateKey, signerIdentifier, digestOid, encryptionOid, signedAttrGenerator, unsignedAttrGenerator);
			this._signerInfs.Add(new global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.DigestAndSignerInfoGeneratorHolder(signerInf, digestOid));
		}

		// Token: 0x060033AD RID: 13229 RVA: 0x000F5CF1 File Offset: 0x000F3EF1
		internal override void AddSignerCallback(global::Org.BouncyCastle.Cms.SignerInformation si)
		{
			this.RegisterDigestOid(si.DigestAlgorithmID.Algorithm.Id);
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x000F5D09 File Offset: 0x000F3F09
		public global::System.IO.Stream Open(global::System.IO.Stream outStream)
		{
			return this.Open(outStream, false);
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x000F5D13 File Offset: 0x000F3F13
		public global::System.IO.Stream Open(global::System.IO.Stream outStream, bool encapsulate)
		{
			return this.Open(outStream, global::Org.BouncyCastle.Cms.CmsSignedGenerator.Data, encapsulate);
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x000F5D22 File Offset: 0x000F3F22
		public global::System.IO.Stream Open(global::System.IO.Stream outStream, bool encapsulate, global::System.IO.Stream dataOutputStream)
		{
			return this.Open(outStream, global::Org.BouncyCastle.Cms.CmsSignedGenerator.Data, encapsulate, dataOutputStream);
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x000F5D32 File Offset: 0x000F3F32
		public global::System.IO.Stream Open(global::System.IO.Stream outStream, string signedContentType, bool encapsulate)
		{
			return this.Open(outStream, signedContentType, encapsulate, null);
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x000F5D40 File Offset: 0x000F3F40
		public global::System.IO.Stream Open(global::System.IO.Stream outStream, string signedContentType, bool encapsulate, global::System.IO.Stream dataOutputStream)
		{
			if (outStream == null)
			{
				throw new global::System.ArgumentNullException("outStream");
			}
			if (!outStream.CanWrite)
			{
				throw new global::System.ArgumentException("Expected writeable stream", "outStream");
			}
			if (dataOutputStream != null && !dataOutputStream.CanWrite)
			{
				throw new global::System.ArgumentException("Expected writeable stream", "dataOutputStream");
			}
			this._messageDigestsLocked = true;
			global::Org.BouncyCastle.Asn1.BerSequenceGenerator sGen = new global::Org.BouncyCastle.Asn1.BerSequenceGenerator(outStream);
			sGen.AddObject(global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.SignedData);
			global::Org.BouncyCastle.Asn1.BerSequenceGenerator sigGen = new global::Org.BouncyCastle.Asn1.BerSequenceGenerator(sGen.GetRawOutputStream(), 0, true);
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentTypeOid = (signedContentType == null) ? null : new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(signedContentType);
			sigGen.AddObject(this.CalculateVersion(contentTypeOid));
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector digestAlgs = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			foreach (object obj in this._messageDigestOids)
			{
				string digestOid = (string)obj;
				digestAlgs.Add(new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(digestOid), global::Org.BouncyCastle.Asn1.DerNull.Instance));
			}
			byte[] tmp = new global::Org.BouncyCastle.Asn1.DerSet(digestAlgs).GetEncoded();
			sigGen.GetRawOutputStream().Write(tmp, 0, tmp.Length);
			global::Org.BouncyCastle.Asn1.BerSequenceGenerator eiGen = new global::Org.BouncyCastle.Asn1.BerSequenceGenerator(sigGen.GetRawOutputStream());
			eiGen.AddObject(contentTypeOid);
			global::System.IO.Stream encapStream = encapsulate ? global::Org.BouncyCastle.Cms.CmsUtilities.CreateBerOctetOutputStream(eiGen.GetRawOutputStream(), 0, true, this._bufferSize) : null;
			global::System.IO.Stream teeStream = global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.GetSafeTeeOutputStream(dataOutputStream, encapStream);
			global::System.IO.Stream digStream = global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.AttachDigestsToOutputStream(this._messageDigests.Values, teeStream);
			return new global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.CmsSignedDataOutputStream(this, digStream, signedContentType, sGen, sigGen, eiGen);
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x000F5EBC File Offset: 0x000F40BC
		private void RegisterDigestOid(string digestOid)
		{
			if (this._messageDigestsLocked)
			{
				if (!this._messageDigestOids.Contains(digestOid))
				{
					throw new global::System.InvalidOperationException("Cannot register new digest OIDs after the data stream is opened");
				}
			}
			else
			{
				this._messageDigestOids.Add(digestOid);
			}
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x000F5EEC File Offset: 0x000F40EC
		private void ConfigureDigest(string digestOid)
		{
			this.RegisterDigestOid(digestOid);
			string digestName = global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.Helper.GetDigestAlgName(digestOid);
			if ((global::Org.BouncyCastle.Crypto.IDigest)this._messageDigests[digestName] == null)
			{
				if (this._messageDigestsLocked)
				{
					throw new global::System.InvalidOperationException("Cannot configure new digests after the data stream is opened");
				}
				global::Org.BouncyCastle.Crypto.IDigest dig = global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.Helper.GetDigestInstance(digestName);
				this._messageDigests[digestName] = dig;
			}
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x000F5F50 File Offset: 0x000F4150
		internal void Generate(global::System.IO.Stream outStream, string eContentType, bool encapsulate, global::System.IO.Stream dataOutputStream, global::Org.BouncyCastle.Cms.CmsProcessable content)
		{
			global::System.IO.Stream signedOut = this.Open(outStream, eContentType, encapsulate, dataOutputStream);
			if (content != null)
			{
				content.Write(signedOut);
			}
			global::Org.BouncyCastle.Utilities.Platform.Dispose(signedOut);
		}

		// Token: 0x060033B6 RID: 13238 RVA: 0x000F5F7C File Offset: 0x000F417C
		private global::Org.BouncyCastle.Asn1.DerInteger CalculateVersion(global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentOid)
		{
			bool otherCert = false;
			bool otherCrl = false;
			bool attrCertV1Found = false;
			bool attrCertV2Found = false;
			if (this._certs != null)
			{
				foreach (object obj in this._certs)
				{
					if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
					{
						global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagged = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj;
						if (tagged.TagNo == 1)
						{
							attrCertV1Found = true;
						}
						else if (tagged.TagNo == 2)
						{
							attrCertV2Found = true;
						}
						else if (tagged.TagNo == 3)
						{
							otherCert = true;
							break;
						}
					}
				}
			}
			if (otherCert)
			{
				return new global::Org.BouncyCastle.Asn1.DerInteger(5);
			}
			if (this._crls != null)
			{
				using (global::System.Collections.IEnumerator enumerator = this._crls.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
						{
							otherCrl = true;
							break;
						}
					}
				}
			}
			if (otherCrl)
			{
				return new global::Org.BouncyCastle.Asn1.DerInteger(5);
			}
			if (attrCertV2Found)
			{
				return new global::Org.BouncyCastle.Asn1.DerInteger(4);
			}
			if (attrCertV1Found || !global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.Data.Equals(contentOid) || this.CheckForVersion3(this._signers))
			{
				return new global::Org.BouncyCastle.Asn1.DerInteger(3);
			}
			return new global::Org.BouncyCastle.Asn1.DerInteger(1);
		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x000F60BC File Offset: 0x000F42BC
		private bool CheckForVersion3(global::System.Collections.IList signerInfos)
		{
			using (global::System.Collections.IEnumerator enumerator = signerInfos.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (global::Org.BouncyCastle.Asn1.Cms.SignerInfo.GetInstance(((global::Org.BouncyCastle.Cms.SignerInformation)enumerator.Current).ToSignerInfo()).Version.IntValueExact == 3)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x000F6128 File Offset: 0x000F4328
		private static global::System.IO.Stream AttachDigestsToOutputStream(global::System.Collections.ICollection digests, global::System.IO.Stream s)
		{
			global::System.IO.Stream result = s;
			foreach (object obj in digests)
			{
				global::Org.BouncyCastle.Crypto.IDigest digest = (global::Org.BouncyCastle.Crypto.IDigest)obj;
				result = global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.GetSafeTeeOutputStream(result, new global::Org.BouncyCastle.Crypto.IO.DigestSink(digest));
			}
			return result;
		}

		// Token: 0x060033B9 RID: 13241 RVA: 0x000F6188 File Offset: 0x000F4388
		private static global::System.IO.Stream GetSafeOutputStream(global::System.IO.Stream s)
		{
			if (s == null)
			{
				return new global::Org.BouncyCastle.Utilities.IO.NullOutputStream();
			}
			return s;
		}

		// Token: 0x060033BA RID: 13242 RVA: 0x000F6194 File Offset: 0x000F4394
		private static global::System.IO.Stream GetSafeTeeOutputStream(global::System.IO.Stream s1, global::System.IO.Stream s2)
		{
			if (s1 == null)
			{
				return global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.GetSafeOutputStream(s2);
			}
			if (s2 == null)
			{
				return global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.GetSafeOutputStream(s1);
			}
			return new global::Org.BouncyCastle.Utilities.IO.TeeOutputStream(s1, s2);
		}

		// Token: 0x04001705 RID: 5893
		private static readonly global::Org.BouncyCastle.Cms.CmsSignedHelper Helper = global::Org.BouncyCastle.Cms.CmsSignedHelper.Instance;

		// Token: 0x04001706 RID: 5894
		private readonly global::System.Collections.IList _signerInfs = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x04001707 RID: 5895
		private readonly global::Org.BouncyCastle.Utilities.Collections.ISet _messageDigestOids = new global::Org.BouncyCastle.Utilities.Collections.HashSet();

		// Token: 0x04001708 RID: 5896
		private readonly global::System.Collections.IDictionary _messageDigests = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04001709 RID: 5897
		private readonly global::System.Collections.IDictionary _messageHashes = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x0400170A RID: 5898
		private bool _messageDigestsLocked;

		// Token: 0x0400170B RID: 5899
		private int _bufferSize;

		// Token: 0x0200083F RID: 2111
		private class DigestAndSignerInfoGeneratorHolder
		{
			// Token: 0x06004724 RID: 18212 RVA: 0x0013A6CF File Offset: 0x001388CF
			internal DigestAndSignerInfoGeneratorHolder(global::Org.BouncyCastle.Cms.ISignerInfoGenerator signerInf, string digestOID)
			{
				this.signerInf = signerInf;
				this.digestOID = digestOID;
			}

			// Token: 0x17000ABA RID: 2746
			// (get) Token: 0x06004725 RID: 18213 RVA: 0x0013A6E5 File Offset: 0x001388E5
			internal global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DigestAlgorithm
			{
				get
				{
					return new global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(this.digestOID), global::Org.BouncyCastle.Asn1.DerNull.Instance);
				}
			}

			// Token: 0x04002598 RID: 9624
			internal readonly global::Org.BouncyCastle.Cms.ISignerInfoGenerator signerInf;

			// Token: 0x04002599 RID: 9625
			internal readonly string digestOID;
		}

		// Token: 0x02000840 RID: 2112
		private class SignerInfoGeneratorImpl : global::Org.BouncyCastle.Cms.ISignerInfoGenerator
		{
			// Token: 0x06004726 RID: 18214 RVA: 0x0013A6FC File Offset: 0x001388FC
			internal SignerInfoGeneratorImpl(global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator outer, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key, global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier signerIdentifier, string digestOID, string encOID, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator sAttr, global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator unsAttr)
			{
				this.outer = outer;
				this._signerIdentifier = signerIdentifier;
				this._digestOID = digestOID;
				this._encOID = encOID;
				this._sAttr = sAttr;
				this._unsAttr = unsAttr;
				this._encName = global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.Helper.GetEncryptionAlgName(this._encOID);
				string signatureName = global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.Helper.GetDigestAlgName(this._digestOID) + "with" + this._encName;
				if (this._sAttr != null)
				{
					this._sig = global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.Helper.GetSignatureInstance(signatureName);
				}
				else if (this._encName.Equals("RSA"))
				{
					this._sig = global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.Helper.GetSignatureInstance("RSA");
				}
				else
				{
					if (!this._encName.Equals("DSA"))
					{
						throw new global::Org.BouncyCastle.Security.SignatureException("algorithm: " + this._encName + " not supported in base signatures.");
					}
					this._sig = global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.Helper.GetSignatureInstance("NONEwithDSA");
				}
				this._sig.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(key, outer.rand));
			}

			// Token: 0x06004727 RID: 18215 RVA: 0x0013A814 File Offset: 0x00138A14
			public global::Org.BouncyCastle.Asn1.Cms.SignerInfo Generate(global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentType, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestAlgorithm, byte[] calculatedDigest)
			{
				global::Org.BouncyCastle.Asn1.Cms.SignerInfo result;
				try
				{
					string algorithm = global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.Helper.GetDigestAlgName(this._digestOID) + "with" + this._encName;
					byte[] bytesToSign = calculatedDigest;
					global::Org.BouncyCastle.Asn1.Asn1Set signedAttr = null;
					if (this._sAttr != null)
					{
						global::System.Collections.IDictionary parameters = this.outer.GetBaseParameters(contentType, digestAlgorithm, calculatedDigest);
						global::Org.BouncyCastle.Asn1.Cms.AttributeTable signed = this._sAttr.GetAttributes(parameters);
						if (contentType == null && signed != null && signed[global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.ContentType] != null)
						{
							global::System.Collections.IDictionary dictionary = signed.ToDictionary();
							dictionary.Remove(global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.ContentType);
							signed = new global::Org.BouncyCastle.Asn1.Cms.AttributeTable(dictionary);
						}
						signedAttr = this.outer.GetAttributeSet(signed);
						bytesToSign = signedAttr.GetEncoded("DER");
					}
					else if (this._encName.Equals("RSA"))
					{
						bytesToSign = new global::Org.BouncyCastle.Asn1.X509.DigestInfo(digestAlgorithm, calculatedDigest).GetEncoded("DER");
					}
					this._sig.BlockUpdate(bytesToSign, 0, bytesToSign.Length);
					byte[] sigBytes = this._sig.GenerateSignature();
					global::Org.BouncyCastle.Asn1.Asn1Set unsignedAttr = null;
					if (this._unsAttr != null)
					{
						global::System.Collections.IDictionary parameters2 = this.outer.GetBaseParameters(contentType, digestAlgorithm, calculatedDigest);
						parameters2[global::Org.BouncyCastle.Cms.CmsAttributeTableParameter.Signature] = sigBytes.Clone();
						global::Org.BouncyCastle.Asn1.Cms.AttributeTable unsigned = this._unsAttr.GetAttributes(parameters2);
						unsignedAttr = this.outer.GetAttributeSet(unsigned);
					}
					global::Org.BouncyCastle.Asn1.Asn1Encodable sigX509Parameters = global::Org.BouncyCastle.Security.SignerUtilities.GetDefaultX509Parameters(algorithm);
					global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestEncryptionAlgorithm = global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.Helper.GetEncAlgorithmIdentifier(new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(this._encOID), sigX509Parameters);
					result = new global::Org.BouncyCastle.Asn1.Cms.SignerInfo(this._signerIdentifier, digestAlgorithm, signedAttr, digestEncryptionAlgorithm, new global::Org.BouncyCastle.Asn1.DerOctetString(sigBytes), unsignedAttr);
				}
				catch (global::System.IO.IOException e)
				{
					throw new global::Org.BouncyCastle.Cms.CmsStreamException("encoding error.", e);
				}
				catch (global::Org.BouncyCastle.Security.SignatureException e2)
				{
					throw new global::Org.BouncyCastle.Cms.CmsStreamException("error creating signature.", e2);
				}
				return result;
			}

			// Token: 0x0400259A RID: 9626
			private readonly global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator outer;

			// Token: 0x0400259B RID: 9627
			private readonly global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier _signerIdentifier;

			// Token: 0x0400259C RID: 9628
			private readonly string _digestOID;

			// Token: 0x0400259D RID: 9629
			private readonly string _encOID;

			// Token: 0x0400259E RID: 9630
			private readonly global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator _sAttr;

			// Token: 0x0400259F RID: 9631
			private readonly global::Org.BouncyCastle.Cms.CmsAttributeTableGenerator _unsAttr;

			// Token: 0x040025A0 RID: 9632
			private readonly string _encName;

			// Token: 0x040025A1 RID: 9633
			private readonly global::Org.BouncyCastle.Crypto.ISigner _sig;
		}

		// Token: 0x02000841 RID: 2113
		private class CmsSignedDataOutputStream : global::Org.BouncyCastle.Utilities.IO.BaseOutputStream
		{
			// Token: 0x06004728 RID: 18216 RVA: 0x0013A9D0 File Offset: 0x00138BD0
			public CmsSignedDataOutputStream(global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator outer, global::System.IO.Stream outStream, string contentOID, global::Org.BouncyCastle.Asn1.BerSequenceGenerator sGen, global::Org.BouncyCastle.Asn1.BerSequenceGenerator sigGen, global::Org.BouncyCastle.Asn1.BerSequenceGenerator eiGen)
			{
				this.outer = outer;
				this._out = outStream;
				this._contentOID = new global::Org.BouncyCastle.Asn1.DerObjectIdentifier(contentOID);
				this._sGen = sGen;
				this._sigGen = sigGen;
				this._eiGen = eiGen;
			}

			// Token: 0x06004729 RID: 18217 RVA: 0x0013AA0A File Offset: 0x00138C0A
			public override void WriteByte(byte b)
			{
				this._out.WriteByte(b);
			}

			// Token: 0x0600472A RID: 18218 RVA: 0x0013AA18 File Offset: 0x00138C18
			public override void Write(byte[] bytes, int off, int len)
			{
				this._out.Write(bytes, off, len);
			}

			// Token: 0x0600472B RID: 18219 RVA: 0x0013AA28 File Offset: 0x00138C28
			public override void Close()
			{
				this.DoClose();
				base.Close();
			}

			// Token: 0x0600472C RID: 18220 RVA: 0x0013AA38 File Offset: 0x00138C38
			private void DoClose()
			{
				global::Org.BouncyCastle.Utilities.Platform.Dispose(this._out);
				this._eiGen.Close();
				this.outer._digests.Clear();
				if (this.outer._certs.Count > 0)
				{
					global::Org.BouncyCastle.Asn1.Asn1Set certs = this.outer.UseDerForCerts ? global::Org.BouncyCastle.Cms.CmsUtilities.CreateDerSetFromList(this.outer._certs) : global::Org.BouncyCastle.Cms.CmsUtilities.CreateBerSetFromList(this.outer._certs);
					global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.CmsSignedDataOutputStream.WriteToGenerator(this._sigGen, new global::Org.BouncyCastle.Asn1.BerTaggedObject(false, 0, certs));
				}
				if (this.outer._crls.Count > 0)
				{
					global::Org.BouncyCastle.Asn1.Asn1Set crls = this.outer.UseDerForCrls ? global::Org.BouncyCastle.Cms.CmsUtilities.CreateDerSetFromList(this.outer._crls) : global::Org.BouncyCastle.Cms.CmsUtilities.CreateBerSetFromList(this.outer._crls);
					global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.CmsSignedDataOutputStream.WriteToGenerator(this._sigGen, new global::Org.BouncyCastle.Asn1.BerTaggedObject(false, 1, crls));
				}
				foreach (object obj in this.outer._messageDigests)
				{
					global::System.Collections.DictionaryEntry de = (global::System.Collections.DictionaryEntry)obj;
					this.outer._messageHashes.Add(de.Key, global::Org.BouncyCastle.Security.DigestUtilities.DoFinal((global::Org.BouncyCastle.Crypto.IDigest)de.Value));
				}
				global::Org.BouncyCastle.Asn1.Asn1EncodableVector signerInfos = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
				foreach (object obj2 in this.outer._signerInfs)
				{
					global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.DigestAndSignerInfoGeneratorHolder holder = (global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.DigestAndSignerInfoGeneratorHolder)obj2;
					global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestAlgorithm = holder.DigestAlgorithm;
					byte[] calculatedDigest = (byte[])this.outer._messageHashes[global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.Helper.GetDigestAlgName(holder.digestOID)];
					this.outer._digests[holder.digestOID] = calculatedDigest.Clone();
					signerInfos.Add(holder.signerInf.Generate(this._contentOID, digestAlgorithm, calculatedDigest));
				}
				foreach (object obj3 in this.outer._signers)
				{
					global::Org.BouncyCastle.Cms.SignerInformation signer = (global::Org.BouncyCastle.Cms.SignerInformation)obj3;
					signerInfos.Add(signer.ToSignerInfo());
				}
				global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator.CmsSignedDataOutputStream.WriteToGenerator(this._sigGen, new global::Org.BouncyCastle.Asn1.DerSet(signerInfos));
				this._sigGen.Close();
				this._sGen.Close();
			}

			// Token: 0x0600472D RID: 18221 RVA: 0x0013ACD4 File Offset: 0x00138ED4
			private static void WriteToGenerator(global::Org.BouncyCastle.Asn1.Asn1Generator ag, global::Org.BouncyCastle.Asn1.Asn1Encodable ae)
			{
				byte[] encoded = ae.GetEncoded();
				ag.GetRawOutputStream().Write(encoded, 0, encoded.Length);
			}

			// Token: 0x040025A2 RID: 9634
			private readonly global::Org.BouncyCastle.Cms.CmsSignedDataStreamGenerator outer;

			// Token: 0x040025A3 RID: 9635
			private global::System.IO.Stream _out;

			// Token: 0x040025A4 RID: 9636
			private global::Org.BouncyCastle.Asn1.DerObjectIdentifier _contentOID;

			// Token: 0x040025A5 RID: 9637
			private global::Org.BouncyCastle.Asn1.BerSequenceGenerator _sGen;

			// Token: 0x040025A6 RID: 9638
			private global::Org.BouncyCastle.Asn1.BerSequenceGenerator _sigGen;

			// Token: 0x040025A7 RID: 9639
			private global::Org.BouncyCastle.Asn1.BerSequenceGenerator _eiGen;
		}
	}
}
