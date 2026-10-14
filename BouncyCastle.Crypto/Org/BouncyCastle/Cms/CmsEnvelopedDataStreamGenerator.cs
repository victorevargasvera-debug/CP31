using System;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x0200052B RID: 1323
	public class CmsEnvelopedDataStreamGenerator : global::Org.BouncyCastle.Cms.CmsEnvelopedGenerator
	{
		// Token: 0x06003317 RID: 13079 RVA: 0x000F3EF7 File Offset: 0x000F20F7
		public CmsEnvelopedDataStreamGenerator()
		{
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x000F3EFF File Offset: 0x000F20FF
		public CmsEnvelopedDataStreamGenerator(global::Org.BouncyCastle.Security.SecureRandom rand) : base(rand)
		{
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x000F3F08 File Offset: 0x000F2108
		public void SetBufferSize(int bufferSize)
		{
			this._bufferSize = bufferSize;
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x000F3F11 File Offset: 0x000F2111
		public void SetBerEncodeRecipients(bool berEncodeRecipientSet)
		{
			this._berEncodeRecipientSet = berEncodeRecipientSet;
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x0600331B RID: 13083 RVA: 0x000F3F1A File Offset: 0x000F211A
		private global::Org.BouncyCastle.Asn1.DerInteger Version
		{
			get
			{
				return new global::Org.BouncyCastle.Asn1.DerInteger((this._originatorInfo != null || this._unprotectedAttributes != null) ? 2 : 0);
			}
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x000F3F38 File Offset: 0x000F2138
		private global::System.IO.Stream Open(global::System.IO.Stream outStream, string encryptionOid, global::Org.BouncyCastle.Crypto.CipherKeyGenerator keyGen)
		{
			byte[] encKeyBytes = keyGen.GenerateKey();
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter encKey = global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(encryptionOid, encKeyBytes);
			global::Org.BouncyCastle.Asn1.Asn1Encodable asn1Params = this.GenerateAsn1Parameters(encryptionOid, encKeyBytes);
			global::Org.BouncyCastle.Crypto.ICipherParameters cipherParameters;
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier encAlgID = this.GetAlgorithmIdentifier(encryptionOid, encKey, asn1Params, out cipherParameters);
			global::Org.BouncyCastle.Asn1.Asn1EncodableVector recipientInfos = new global::Org.BouncyCastle.Asn1.Asn1EncodableVector();
			foreach (object obj in this.recipientInfoGenerators)
			{
				global::Org.BouncyCastle.Cms.RecipientInfoGenerator rig = (global::Org.BouncyCastle.Cms.RecipientInfoGenerator)obj;
				try
				{
					recipientInfos.Add(rig.Generate(encKey, this.rand));
				}
				catch (global::Org.BouncyCastle.Security.InvalidKeyException e)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("key inappropriate for algorithm.", e);
				}
				catch (global::Org.BouncyCastle.Security.GeneralSecurityException e2)
				{
					throw new global::Org.BouncyCastle.Cms.CmsException("error making encrypted content.", e2);
				}
			}
			return this.Open(outStream, encAlgID, cipherParameters, recipientInfos);
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x000F4018 File Offset: 0x000F2218
		private global::System.IO.Stream Open(global::System.IO.Stream outStream, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier encAlgID, global::Org.BouncyCastle.Crypto.ICipherParameters cipherParameters, global::Org.BouncyCastle.Asn1.Asn1EncodableVector recipientInfos)
		{
			global::System.IO.Stream result;
			try
			{
				global::Org.BouncyCastle.Asn1.BerSequenceGenerator cGen = new global::Org.BouncyCastle.Asn1.BerSequenceGenerator(outStream);
				cGen.AddObject(global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.EnvelopedData);
				global::Org.BouncyCastle.Asn1.BerSequenceGenerator envGen = new global::Org.BouncyCastle.Asn1.BerSequenceGenerator(cGen.GetRawOutputStream(), 0, true);
				envGen.AddObject(this.Version);
				global::System.IO.Stream envRaw = envGen.GetRawOutputStream();
				global::Org.BouncyCastle.Asn1.Asn1Generator recipGen = this._berEncodeRecipientSet ? new global::Org.BouncyCastle.Asn1.BerSetGenerator(envRaw) : new global::Org.BouncyCastle.Asn1.DerSetGenerator(envRaw);
				foreach (object obj in recipientInfos)
				{
					global::Org.BouncyCastle.Asn1.Asn1Encodable ae = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj;
					recipGen.AddObject(ae);
				}
				recipGen.Close();
				global::Org.BouncyCastle.Asn1.BerSequenceGenerator eiGen = new global::Org.BouncyCastle.Asn1.BerSequenceGenerator(envRaw);
				eiGen.AddObject(global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.Data);
				eiGen.AddObject(encAlgID);
				global::System.IO.Stream stream = global::Org.BouncyCastle.Cms.CmsUtilities.CreateBerOctetOutputStream(eiGen.GetRawOutputStream(), 0, false, this._bufferSize);
				global::Org.BouncyCastle.Crypto.IBufferedCipher cipher = global::Org.BouncyCastle.Security.CipherUtilities.GetCipher(encAlgID.Algorithm);
				cipher.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(cipherParameters, this.rand));
				global::Org.BouncyCastle.Crypto.IO.CipherStream cOut = new global::Org.BouncyCastle.Crypto.IO.CipherStream(stream, null, cipher);
				result = new global::Org.BouncyCastle.Cms.CmsEnvelopedDataStreamGenerator.CmsEnvelopedDataOutputStream(this, cOut, cGen, envGen, eiGen);
			}
			catch (global::Org.BouncyCastle.Security.SecurityUtilityException e)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("couldn't create cipher.", e);
			}
			catch (global::Org.BouncyCastle.Security.InvalidKeyException e2)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("key invalid in message.", e2);
			}
			catch (global::System.IO.IOException e3)
			{
				throw new global::Org.BouncyCastle.Cms.CmsException("exception decoding algorithm parameters.", e3);
			}
			return result;
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x000F4184 File Offset: 0x000F2384
		public global::System.IO.Stream Open(global::System.IO.Stream outStream, string encryptionOid)
		{
			global::Org.BouncyCastle.Crypto.CipherKeyGenerator keyGen = global::Org.BouncyCastle.Security.GeneratorUtilities.GetKeyGenerator(encryptionOid);
			keyGen.Init(new global::Org.BouncyCastle.Crypto.KeyGenerationParameters(this.rand, keyGen.DefaultStrength));
			return this.Open(outStream, encryptionOid, keyGen);
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x000F41B8 File Offset: 0x000F23B8
		public global::System.IO.Stream Open(global::System.IO.Stream outStream, string encryptionOid, int keySize)
		{
			global::Org.BouncyCastle.Crypto.CipherKeyGenerator keyGen = global::Org.BouncyCastle.Security.GeneratorUtilities.GetKeyGenerator(encryptionOid);
			keyGen.Init(new global::Org.BouncyCastle.Crypto.KeyGenerationParameters(this.rand, keySize));
			return this.Open(outStream, encryptionOid, keyGen);
		}

		// Token: 0x040016C3 RID: 5827
		private object _originatorInfo;

		// Token: 0x040016C4 RID: 5828
		private object _unprotectedAttributes;

		// Token: 0x040016C5 RID: 5829
		private int _bufferSize;

		// Token: 0x040016C6 RID: 5830
		private bool _berEncodeRecipientSet;

		// Token: 0x0200083B RID: 2107
		private class CmsEnvelopedDataOutputStream : global::Org.BouncyCastle.Utilities.IO.BaseOutputStream
		{
			// Token: 0x06004712 RID: 18194 RVA: 0x0013A08E File Offset: 0x0013828E
			public CmsEnvelopedDataOutputStream(global::Org.BouncyCastle.Cms.CmsEnvelopedGenerator outer, global::Org.BouncyCastle.Crypto.IO.CipherStream outStream, global::Org.BouncyCastle.Asn1.BerSequenceGenerator cGen, global::Org.BouncyCastle.Asn1.BerSequenceGenerator envGen, global::Org.BouncyCastle.Asn1.BerSequenceGenerator eiGen)
			{
				this._outer = outer;
				this._out = outStream;
				this._cGen = cGen;
				this._envGen = envGen;
				this._eiGen = eiGen;
			}

			// Token: 0x06004713 RID: 18195 RVA: 0x0013A0BB File Offset: 0x001382BB
			public override void WriteByte(byte b)
			{
				this._out.WriteByte(b);
			}

			// Token: 0x06004714 RID: 18196 RVA: 0x0013A0C9 File Offset: 0x001382C9
			public override void Write(byte[] bytes, int off, int len)
			{
				this._out.Write(bytes, off, len);
			}

			// Token: 0x06004715 RID: 18197 RVA: 0x0013A0DC File Offset: 0x001382DC
			public override void Close()
			{
				global::Org.BouncyCastle.Utilities.Platform.Dispose(this._out);
				this._eiGen.Close();
				if (this._outer.unprotectedAttributeGenerator != null)
				{
					global::Org.BouncyCastle.Asn1.Asn1Set unprotectedAttrs = new global::Org.BouncyCastle.Asn1.BerSet(this._outer.unprotectedAttributeGenerator.GetAttributes(global::Org.BouncyCastle.Utilities.Platform.CreateHashtable()).ToAsn1EncodableVector());
					this._envGen.AddObject(new global::Org.BouncyCastle.Asn1.DerTaggedObject(false, 1, unprotectedAttrs));
				}
				this._envGen.Close();
				this._cGen.Close();
				base.Close();
			}

			// Token: 0x04002585 RID: 9605
			private readonly global::Org.BouncyCastle.Cms.CmsEnvelopedGenerator _outer;

			// Token: 0x04002586 RID: 9606
			private readonly global::Org.BouncyCastle.Crypto.IO.CipherStream _out;

			// Token: 0x04002587 RID: 9607
			private readonly global::Org.BouncyCastle.Asn1.BerSequenceGenerator _cGen;

			// Token: 0x04002588 RID: 9608
			private readonly global::Org.BouncyCastle.Asn1.BerSequenceGenerator _envGen;

			// Token: 0x04002589 RID: 9609
			private readonly global::Org.BouncyCastle.Asn1.BerSequenceGenerator _eiGen;
		}
	}
}
