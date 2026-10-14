using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200055B RID: 1371
	public class SignerInformation
	{
		// Token: 0x06003478 RID: 13432 RVA: 0x000FA8CC File Offset: 0x000F8ACC
		internal SignerInformation(global::Org.BouncyCastle.Asn1.Cms.SignerInfo info, global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentType, global::Org.BouncyCastle.Cms.CmsProcessable content, global::Org.BouncyCastle.Cms.IDigestCalculator digestCalculator)
		{
			this.info = info;
			this.sid = new global::Org.BouncyCastle.Cms.SignerID();
			this.contentType = contentType;
			this.isCounterSignature = (contentType == null);
			try
			{
				global::Org.BouncyCastle.Asn1.Cms.SignerIdentifier s = info.SignerID;
				if (s.IsTagged)
				{
					global::Org.BouncyCastle.Asn1.Asn1OctetString octs = global::Org.BouncyCastle.Asn1.Asn1OctetString.GetInstance(s.ID);
					this.sid.SubjectKeyIdentifier = octs.GetEncoded();
				}
				else
				{
					global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber iAnds = global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber.GetInstance(s.ID);
					this.sid.Issuer = iAnds.Name;
					this.sid.SerialNumber = iAnds.SerialNumber.Value;
				}
			}
			catch (global::System.IO.IOException)
			{
				throw new global::System.ArgumentException("invalid sid in SignerInfo");
			}
			this.digestAlgorithm = info.DigestAlgorithm;
			this.signedAttributeSet = info.AuthenticatedAttributes;
			this.unsignedAttributeSet = info.UnauthenticatedAttributes;
			this.encryptionAlgorithm = info.DigestEncryptionAlgorithm;
			this.signature = (byte[])info.EncryptedDigest.GetOctets().Clone();
			this.content = content;
			this.calculatedDigest = ((digestCalculator != null) ? digestCalculator.GetDigest() : null);
		}

		// Token: 0x06003479 RID: 13433 RVA: 0x000FA9E8 File Offset: 0x000F8BE8
		protected SignerInformation(global::Org.BouncyCastle.Cms.SignerInformation baseInfo)
		{
			this.info = baseInfo.info;
			this.content = baseInfo.content;
			this.contentType = baseInfo.contentType;
			this.isCounterSignature = baseInfo.IsCounterSignature;
			this.sid = baseInfo.sid;
			this.digestAlgorithm = this.info.DigestAlgorithm;
			this.signedAttributeSet = this.info.AuthenticatedAttributes;
			this.unsignedAttributeSet = this.info.UnauthenticatedAttributes;
			this.encryptionAlgorithm = this.info.DigestEncryptionAlgorithm;
			this.signature = (byte[])this.info.EncryptedDigest.GetOctets().Clone();
			this.calculatedDigest = baseInfo.calculatedDigest;
			this.signedAttributeTable = baseInfo.signedAttributeTable;
			this.unsignedAttributeTable = baseInfo.unsignedAttributeTable;
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x0600347A RID: 13434 RVA: 0x000FAABF File Offset: 0x000F8CBF
		public bool IsCounterSignature
		{
			get
			{
				return this.isCounterSignature;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x0600347B RID: 13435 RVA: 0x000FAAC7 File Offset: 0x000F8CC7
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier ContentType
		{
			get
			{
				return this.contentType;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x0600347C RID: 13436 RVA: 0x000FAACF File Offset: 0x000F8CCF
		public global::Org.BouncyCastle.Cms.SignerID SignerID
		{
			get
			{
				return this.sid;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600347D RID: 13437 RVA: 0x000FAAD7 File Offset: 0x000F8CD7
		public int Version
		{
			get
			{
				return this.info.Version.IntValueExact;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600347E RID: 13438 RVA: 0x000FAAE9 File Offset: 0x000F8CE9
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier DigestAlgorithmID
		{
			get
			{
				return this.digestAlgorithm;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x0600347F RID: 13439 RVA: 0x000FAAF1 File Offset: 0x000F8CF1
		public string DigestAlgOid
		{
			get
			{
				return this.digestAlgorithm.Algorithm.Id;
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06003480 RID: 13440 RVA: 0x000FAB04 File Offset: 0x000F8D04
		public global::Org.BouncyCastle.Asn1.Asn1Object DigestAlgParams
		{
			get
			{
				global::Org.BouncyCastle.Asn1.Asn1Encodable ae = this.digestAlgorithm.Parameters;
				if (ae != null)
				{
					return ae.ToAsn1Object();
				}
				return null;
			}
		}

		// Token: 0x06003481 RID: 13441 RVA: 0x000FAB28 File Offset: 0x000F8D28
		public byte[] GetContentDigest()
		{
			if (this.resultDigest == null)
			{
				throw new global::System.InvalidOperationException("method can only be called after verify.");
			}
			return (byte[])this.resultDigest.Clone();
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06003482 RID: 13442 RVA: 0x000FAB4D File Offset: 0x000F8D4D
		public global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier EncryptionAlgorithmID
		{
			get
			{
				return this.encryptionAlgorithm;
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06003483 RID: 13443 RVA: 0x000FAB55 File Offset: 0x000F8D55
		public string EncryptionAlgOid
		{
			get
			{
				return this.encryptionAlgorithm.Algorithm.Id;
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06003484 RID: 13444 RVA: 0x000FAB68 File Offset: 0x000F8D68
		public global::Org.BouncyCastle.Asn1.Asn1Object EncryptionAlgParams
		{
			get
			{
				global::Org.BouncyCastle.Asn1.Asn1Encodable ae = this.encryptionAlgorithm.Parameters;
				if (ae != null)
				{
					return ae.ToAsn1Object();
				}
				return null;
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06003485 RID: 13445 RVA: 0x000FAB8C File Offset: 0x000F8D8C
		public global::Org.BouncyCastle.Asn1.Cms.AttributeTable SignedAttributes
		{
			get
			{
				if (this.signedAttributeSet != null && this.signedAttributeTable == null)
				{
					this.signedAttributeTable = new global::Org.BouncyCastle.Asn1.Cms.AttributeTable(this.signedAttributeSet);
				}
				return this.signedAttributeTable;
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06003486 RID: 13446 RVA: 0x000FABB5 File Offset: 0x000F8DB5
		public global::Org.BouncyCastle.Asn1.Cms.AttributeTable UnsignedAttributes
		{
			get
			{
				if (this.unsignedAttributeSet != null && this.unsignedAttributeTable == null)
				{
					this.unsignedAttributeTable = new global::Org.BouncyCastle.Asn1.Cms.AttributeTable(this.unsignedAttributeSet);
				}
				return this.unsignedAttributeTable;
			}
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x000FABDE File Offset: 0x000F8DDE
		public byte[] GetSignature()
		{
			return (byte[])this.signature.Clone();
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x000FABF0 File Offset: 0x000F8DF0
		public global::Org.BouncyCastle.Cms.SignerInformationStore GetCounterSignatures()
		{
			global::Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttributeTable = this.UnsignedAttributes;
			if (unsignedAttributeTable == null)
			{
				return new global::Org.BouncyCastle.Cms.SignerInformationStore(global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(0));
			}
			global::System.Collections.IList counterSignatures = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			foreach (object obj in unsignedAttributeTable.GetAll(global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.CounterSignature))
			{
				global::Org.BouncyCastle.Asn1.Asn1Set attrValues = ((global::Org.BouncyCastle.Asn1.Cms.Attribute)obj).AttrValues;
				int count = attrValues.Count;
				foreach (object obj2 in attrValues)
				{
					global::Org.BouncyCastle.Asn1.Cms.SignerInfo si = global::Org.BouncyCastle.Asn1.Cms.SignerInfo.GetInstance(((global::Org.BouncyCastle.Asn1.Asn1Encodable)obj2).ToAsn1Object());
					string digestName = global::Org.BouncyCastle.Cms.CmsSignedHelper.Instance.GetDigestAlgName(si.DigestAlgorithm.Algorithm.Id);
					counterSignatures.Add(new global::Org.BouncyCastle.Cms.SignerInformation(si, null, null, new global::Org.BouncyCastle.Cms.CounterSignatureDigestCalculator(digestName, this.GetSignature())));
				}
			}
			return new global::Org.BouncyCastle.Cms.SignerInformationStore(counterSignatures);
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x000FAD04 File Offset: 0x000F8F04
		public virtual byte[] GetEncodedSignedAttributes()
		{
			if (this.signedAttributeSet != null)
			{
				return this.signedAttributeSet.GetEncoded("DER");
			}
			return null;
		}

		// Token: 0x0600348A RID: 13450 RVA: 0x000FAD20 File Offset: 0x000F8F20
		private bool DoVerify(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key)
		{
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier sigAlgOid = this.encryptionAlgorithm.Algorithm;
			global::Org.BouncyCastle.Asn1.Asn1Encodable sigParams = this.encryptionAlgorithm.Parameters;
			string digestName = global::Org.BouncyCastle.Cms.SignerInformation.Helper.GetDigestAlgName(this.EncryptionAlgOid);
			if (digestName.Equals(sigAlgOid.Id))
			{
				digestName = global::Org.BouncyCastle.Cms.SignerInformation.Helper.GetDigestAlgName(this.DigestAlgOid);
			}
			global::Org.BouncyCastle.Crypto.IDigest digest = global::Org.BouncyCastle.Cms.SignerInformation.Helper.GetDigestInstance(digestName);
			global::Org.BouncyCastle.Crypto.ISigner sig;
			if (sigAlgOid.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss))
			{
				if (sigParams == null)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("RSASSA-PSS signature must specify algorithm parameters");
				}
				try
				{
					global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters pss = global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.GetInstance(sigParams.ToAsn1Object());
					if (!pss.HashAlgorithm.Algorithm.Equals(this.digestAlgorithm.Algorithm))
					{
						throw new global::Org.BouncyCastle.Cms.CmsException("RSASSA-PSS signature parameters specified incorrect hash algorithm");
					}
					if (!pss.MaskGenAlgorithm.Algorithm.Equals(global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdMgf1))
					{
						throw new global::Org.BouncyCastle.Cms.CmsException("RSASSA-PSS signature parameters specified unknown MGF");
					}
					global::Org.BouncyCastle.Crypto.IDigest pssDigest = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(pss.HashAlgorithm.Algorithm);
					int saltLength = pss.SaltLength.IntValueExact;
					if (!global::Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.DefaultTrailerField.Equals(pss.TrailerField))
					{
						throw new global::Org.BouncyCastle.Cms.CmsException("RSASSA-PSS signature parameters must have trailerField of 1");
					}
					global::Org.BouncyCastle.Crypto.IAsymmetricBlockCipher rsa = new global::Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine();
					if (this.signedAttributeSet == null && this.calculatedDigest != null)
					{
						sig = global::Org.BouncyCastle.Crypto.Signers.PssSigner.CreateRawSigner(rsa, pssDigest, pssDigest, saltLength, 188);
					}
					else
					{
						sig = new global::Org.BouncyCastle.Crypto.Signers.PssSigner(rsa, pssDigest, saltLength);
					}
					goto IL_181;
				}
				catch (global::System.Exception e)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("failed to set RSASSA-PSS signature parameters", e);
				}
			}
			string signatureName = digestName + "with" + global::Org.BouncyCastle.Cms.SignerInformation.Helper.GetEncryptionAlgName(this.EncryptionAlgOid);
			sig = global::Org.BouncyCastle.Cms.SignerInformation.Helper.GetSignatureInstance(signatureName);
			IL_181:
			try
			{
				if (this.calculatedDigest != null)
				{
					this.resultDigest = this.calculatedDigest;
				}
				else
				{
					if (this.content != null)
					{
						this.content.Write(new global::Org.BouncyCastle.Crypto.IO.DigestSink(digest));
					}
					else if (this.signedAttributeSet == null)
					{
						throw new global::Org.BouncyCastle.Cms.CmsException("data not encapsulated in signature - use detached constructor.");
					}
					this.resultDigest = global::Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest);
				}
			}
			catch (global::System.IO.IOException e2)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("can't process mime object to create signature.", e2);
			}
			global::Org.BouncyCastle.Asn1.Asn1Object validContentType = this.GetSingleValuedSignedAttribute(global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.ContentType, "content-type");
			if (validContentType == null)
			{
				if (!this.isCounterSignature && this.signedAttributeSet != null)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("The content-type attribute type MUST be present whenever signed attributes are present in signed-data");
				}
			}
			else
			{
				if (this.isCounterSignature)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("[For counter signatures,] the signedAttributes field MUST NOT contain a content-type attribute");
				}
				if (!(validContentType is global::Org.BouncyCastle.Asn1.DerObjectIdentifier))
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("content-type attribute value not of ASN.1 type 'OBJECT IDENTIFIER'");
				}
				if (!((global::Org.BouncyCastle.Asn1.DerObjectIdentifier)validContentType).Equals(this.contentType))
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("content-type attribute value does not match eContentType");
				}
			}
			global::Org.BouncyCastle.Asn1.Asn1Object validMessageDigest = this.GetSingleValuedSignedAttribute(global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.MessageDigest, "message-digest");
			if (validMessageDigest == null)
			{
				if (this.signedAttributeSet != null)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("the message-digest signed attribute type MUST be present when there are any signed attributes present");
				}
			}
			else
			{
				if (!(validMessageDigest is global::Org.BouncyCastle.Asn1.Asn1OctetString))
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("message-digest attribute value not of ASN.1 type 'OCTET STRING'");
				}
				global::Org.BouncyCastle.Asn1.Asn1OctetString signedMessageDigest = (global::Org.BouncyCastle.Asn1.Asn1OctetString)validMessageDigest;
				if (!global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.resultDigest, signedMessageDigest.GetOctets()))
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("message-digest attribute value does not match calculated value");
				}
			}
			global::Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttrTable = this.SignedAttributes;
			if (signedAttrTable != null && signedAttrTable.GetAll(global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.CounterSignature).Count > 0)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("A countersignature attribute MUST NOT be a signed attribute");
			}
			global::Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttrTable = this.UnsignedAttributes;
			if (unsignedAttrTable != null)
			{
				using (global::System.Collections.IEnumerator enumerator = unsignedAttrTable.GetAll(global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.CounterSignature).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (((global::Org.BouncyCastle.Asn1.Cms.Attribute)enumerator.Current).AttrValues.Count < 1)
						{
							throw new global::Org.BouncyCastle.Cms.CmsException("A countersignature attribute MUST contain at least one AttributeValue");
						}
					}
				}
			}
			bool result;
			try
			{
				sig.Init(false, key);
				if (this.signedAttributeSet == null)
				{
					if (this.calculatedDigest != null)
					{
						if (sig is global::Org.BouncyCastle.Crypto.Signers.PssSigner)
						{
							sig.BlockUpdate(this.resultDigest, 0, this.resultDigest.Length);
							goto IL_3F6;
						}
						return this.VerifyDigest(this.resultDigest, key, this.GetSignature());
					}
					else
					{
						if (this.content == null)
						{
							goto IL_3F6;
						}
						try
						{
							this.content.Write(new global::Org.BouncyCastle.Crypto.IO.SignerSink(sig));
							goto IL_3F6;
						}
						catch (global::Org.BouncyCastle.Security.SignatureException e3)
						{
							string str = "signature problem: ";
							global::Org.BouncyCastle.Security.SignatureException ex = e3;
							throw new global::Org.BouncyCastle.Cms.CmsStreamException(str + ((ex != null) ? ex.ToString() : null));
						}
					}
				}
				byte[] tmp = this.GetEncodedSignedAttributes();
				sig.BlockUpdate(tmp, 0, tmp.Length);
				IL_3F6:
				result = sig.VerifySignature(this.GetSignature());
			}
			catch (global::Org.BouncyCastle.Security.InvalidKeyException e4)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("key not appropriate to signature in message.", e4);
			}
			catch (global::System.IO.IOException e5)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("can't process mime object to create signature.", e5);
			}
			catch (global::Org.BouncyCastle.Security.SignatureException e6)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("invalid signature format in message: " + e6.Message, e6);
			}
			return result;
		}

		// Token: 0x0600348B RID: 13451 RVA: 0x000FB1C8 File Offset: 0x000F93C8
		private bool IsNull(global::Org.BouncyCastle.Asn1.Asn1Encodable o)
		{
			return o is global::Org.BouncyCastle.Asn1.Asn1Null || o == null;
		}

		// Token: 0x0600348C RID: 13452 RVA: 0x000FB1D8 File Offset: 0x000F93D8
		private global::Org.BouncyCastle.Asn1.X509.DigestInfo DerDecode(byte[] encoding)
		{
			if (encoding[0] != 48)
			{
				throw new global::System.IO.IOException("not a digest info object");
			}
			global::Org.BouncyCastle.Asn1.X509.DigestInfo instance = global::Org.BouncyCastle.Asn1.X509.DigestInfo.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(encoding));
			if (instance.GetEncoded().Length != encoding.Length)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("malformed RSA signature");
			}
			return instance;
		}

		// Token: 0x0600348D RID: 13453 RVA: 0x000FB210 File Offset: 0x000F9410
		private bool VerifyDigest(byte[] digest, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter key, byte[] signature)
		{
			string algorithm = global::Org.BouncyCastle.Cms.SignerInformation.Helper.GetEncryptionAlgName(this.EncryptionAlgOid);
			bool result;
			try
			{
				if (algorithm.Equals("RSA"))
				{
					global::Org.BouncyCastle.Crypto.IBufferedCipher bufferedCipher = global::Org.BouncyCastle.Cms.CmsEnvelopedHelper.Instance.CreateAsymmetricCipher("RSA/ECB/PKCS1Padding");
					bufferedCipher.Init(false, key);
					byte[] decrypt = bufferedCipher.DoFinal(signature);
					global::Org.BouncyCastle.Asn1.X509.DigestInfo digInfo = this.DerDecode(decrypt);
					if (!digInfo.AlgorithmID.Algorithm.Equals(this.digestAlgorithm.Algorithm))
					{
						result = false;
					}
					else if (!this.IsNull(digInfo.AlgorithmID.Parameters))
					{
						result = false;
					}
					else
					{
						byte[] sigHash = digInfo.GetDigest();
						result = global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(digest, sigHash);
					}
				}
				else
				{
					if (!algorithm.Equals("DSA"))
					{
						throw new global::Org.BouncyCastle.Cms.CmsException("algorithm: " + algorithm + " not supported in base signatures.");
					}
					global::Org.BouncyCastle.Crypto.ISigner signer = global::Org.BouncyCastle.Security.SignerUtilities.GetSigner("NONEwithDSA");
					signer.Init(false, key);
					signer.BlockUpdate(digest, 0, digest.Length);
					result = signer.VerifySignature(signature);
				}
			}
			catch (global::Org.BouncyCastle.Security.SecurityUtilityException ex)
			{
				throw ex;
			}
			catch (global::Org.BouncyCastle.Security.GeneralSecurityException e)
			{
				string str = "Exception processing signature: ";
				global::Org.BouncyCastle.Security.GeneralSecurityException ex2 = e;
				throw new global::Org.BouncyCastle.Cms.CmsException(str + ((ex2 != null) ? ex2.ToString() : null), e);
			}
			catch (global::System.IO.IOException e2)
			{
				string str2 = "Exception decoding signature: ";
				global::System.IO.IOException ex3 = e2;
				throw new global::Org.BouncyCastle.Cms.CmsException(str2 + ((ex3 != null) ? ex3.ToString() : null), e2);
			}
			return result;
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x000FB370 File Offset: 0x000F9570
		public bool Verify(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter pubKey)
		{
			if (pubKey.IsPrivate)
			{
				throw new global::System.ArgumentException("Expected public key", "pubKey");
			}
			this.GetSigningTime();
			return this.DoVerify(pubKey);
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x000FB398 File Offset: 0x000F9598
		public bool Verify(global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			global::Org.BouncyCastle.Asn1.Cms.Time signingTime = this.GetSigningTime();
			if (signingTime != null)
			{
				cert.CheckValidity(signingTime.Date);
			}
			return this.DoVerify(cert.GetPublicKey());
		}

		// Token: 0x06003490 RID: 13456 RVA: 0x000FB3C7 File Offset: 0x000F95C7
		public global::Org.BouncyCastle.Asn1.Cms.SignerInfo ToSignerInfo()
		{
			return this.info;
		}

		// Token: 0x06003491 RID: 13457 RVA: 0x000FB3D0 File Offset: 0x000F95D0
		private global::Org.BouncyCastle.Asn1.Asn1Object GetSingleValuedSignedAttribute(global::Org.BouncyCastle.Asn1.DerObjectIdentifier attrOID, string printableName)
		{
			global::Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttrTable = this.UnsignedAttributes;
			if (unsignedAttrTable != null && unsignedAttrTable.GetAll(attrOID).Count > 0)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("The " + printableName + " attribute MUST NOT be an unsigned attribute");
			}
			global::Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttrTable = this.SignedAttributes;
			if (signedAttrTable == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v = signedAttrTable.GetAll(attrOID);
			int count = v.Count;
			if (count == 0)
			{
				return null;
			}
			if (count != 1)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("The SignedAttributes in a signerInfo MUST NOT include multiple instances of the " + printableName + " attribute");
			}
			global::Org.BouncyCastle.Asn1.Asn1Set attrValues = ((global::Org.BouncyCastle.Asn1.Cms.Attribute)v[0]).AttrValues;
			if (attrValues.Count != 1)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("A " + printableName + " attribute MUST have a single attribute value");
			}
			return attrValues[0].ToAsn1Object();
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x000FB484 File Offset: 0x000F9684
		private global::Org.BouncyCastle.Asn1.Cms.Time GetSigningTime()
		{
			global::Org.BouncyCastle.Asn1.Asn1Object validSigningTime = this.GetSingleValuedSignedAttribute(global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.SigningTime, "signing-time");
			if (validSigningTime == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.Cms.Time instance;
			try
			{
				instance = global::Org.BouncyCastle.Asn1.Cms.Time.GetInstance(validSigningTime);
			}
			catch (global::System.ArgumentException)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("signing-time attribute value not a valid 'Time' structure");
			}
			return instance;
		}

		// Token: 0x06003493 RID: 13459 RVA: 0x000FB4D0 File Offset: 0x000F96D0
		public static global::Org.BouncyCastle.Cms.SignerInformation ReplaceUnsignedAttributes(global::Org.BouncyCastle.Cms.SignerInformation signerInformation, global::Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttributes)
		{
			global::Org.BouncyCastle.Asn1.Cms.SignerInfo sInfo = signerInformation.info;
			global::Org.BouncyCastle.Asn1.Asn1Set unsignedAttr = null;
			if (unsignedAttributes != null)
			{
				unsignedAttr = new global::Org.BouncyCastle.Asn1.DerSet(unsignedAttributes.ToAsn1EncodableVector());
			}
			return new global::Org.BouncyCastle.Cms.SignerInformation(new global::Org.BouncyCastle.Asn1.Cms.SignerInfo(sInfo.SignerID, sInfo.DigestAlgorithm, sInfo.AuthenticatedAttributes, sInfo.DigestEncryptionAlgorithm, sInfo.EncryptedDigest, unsignedAttr), signerInformation.contentType, signerInformation.content, null);
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x000FB52C File Offset: 0x000F972C
		public static global::Org.BouncyCastle.Cms.SignerInformation AddCounterSigners(global::Org.BouncyCastle.Cms.SignerInformation signerInformation, global::Org.BouncyCastle.Cms.SignerInformationStore counterSigners)
		{
			global::Org.BouncyCastle.Asn1.Cms.SignerInfo sInfo = signerInformation.info;
			global::Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttr = signerInformation.UnsignedAttributes;
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector v;
			if (unsignedAttr != null)
			{
				v = unsignedAttr.ToAsn1EncodableVector();
			}
			else
			{
				v = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			}
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector sigs = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			foreach (object obj in counterSigners.GetSigners())
			{
				global::Org.BouncyCastle.Cms.SignerInformation sigInf = (global::Org.BouncyCastle.Cms.SignerInformation)obj;
				sigs.Add(sigInf.ToSignerInfo());
			}
			v.Add(new global::Org.BouncyCastle.Asn1.Cms.Attribute(global::Org.BouncyCastle.Asn1.Cms.CmsAttributes.CounterSignature, new global::Org.BouncyCastle.Asn1.DerSet(sigs)));
			return new global::Org.BouncyCastle.Cms.SignerInformation(new global::Org.BouncyCastle.Asn1.Cms.SignerInfo(sInfo.SignerID, sInfo.DigestAlgorithm, sInfo.AuthenticatedAttributes, sInfo.DigestEncryptionAlgorithm, sInfo.EncryptedDigest, new global::Org.BouncyCastle.Asn1.DerSet(v)), signerInformation.contentType, signerInformation.content, null);
		}

		// Token: 0x04001776 RID: 6006
		private static readonly global::Org.BouncyCastle.Cms.CmsSignedHelper Helper = global::Org.BouncyCastle.Cms.CmsSignedHelper.Instance;

		// Token: 0x04001777 RID: 6007
		private global::Org.BouncyCastle.Cms.SignerID sid;

		// Token: 0x04001778 RID: 6008
		private global::Org.BouncyCastle.Cms.CmsProcessable content;

		// Token: 0x04001779 RID: 6009
		private byte[] signature;

		// Token: 0x0400177A RID: 6010
		private global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentType;

		// Token: 0x0400177B RID: 6011
		private byte[] calculatedDigest;

		// Token: 0x0400177C RID: 6012
		private byte[] resultDigest;

		// Token: 0x0400177D RID: 6013
		private global::Org.BouncyCastle.Asn1.Cms.AttributeTable signedAttributeTable;

		// Token: 0x0400177E RID: 6014
		private global::Org.BouncyCastle.Asn1.Cms.AttributeTable unsignedAttributeTable;

		// Token: 0x0400177F RID: 6015
		private readonly bool isCounterSignature;

		// Token: 0x04001780 RID: 6016
		protected global::Org.BouncyCastle.Asn1.Cms.SignerInfo info;

		// Token: 0x04001781 RID: 6017
		protected global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestAlgorithm;

		// Token: 0x04001782 RID: 6018
		protected global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier encryptionAlgorithm;

		// Token: 0x04001783 RID: 6019
		protected readonly global::Org.BouncyCastle.Asn1.Asn1Set signedAttributeSet;

		// Token: 0x04001784 RID: 6020
		protected readonly global::Org.BouncyCastle.Asn1.Asn1Set unsignedAttributeSet;
	}
}
