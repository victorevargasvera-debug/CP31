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
	// Token: 0x0200051F RID: 1311
	public class CmsAuthenticatedDataStreamGenerator : global::Org.BouncyCastle.Cms.CmsAuthenticatedGenerator
	{
		// Token: 0x060032E0 RID: 13024 RVA: 0x000F3127 File Offset: 0x000F1327
		public CmsAuthenticatedDataStreamGenerator()
		{
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x000F312F File Offset: 0x000F132F
		public CmsAuthenticatedDataStreamGenerator(global::Org.BouncyCastle.Security.SecureRandom rand) : base(rand)
		{
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x000F3138 File Offset: 0x000F1338
		public void SetBufferSize(int bufferSize)
		{
			this._bufferSize = bufferSize;
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x000F3141 File Offset: 0x000F1341
		public void SetBerEncodeRecipients(bool berEncodeRecipientSet)
		{
			this._berEncodeRecipientSet = berEncodeRecipientSet;
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x000F314C File Offset: 0x000F134C
		private global::System.IO.Stream Open(global::System.IO.Stream outStr, string macOid, global::Org.BouncyCastle.Crypto.CipherKeyGenerator keyGen)
		{
			byte[] encKeyBytes = keyGen.GenerateKey();
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter encKey = global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(macOid, encKeyBytes);
			global::Org.BouncyCastle.Asn1.Asn1Encodable asn1Params = this.GenerateAsn1Parameters(macOid, encKeyBytes);
			global::Org.BouncyCastle.Crypto.ICipherParameters cipherParameters;
			global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier macAlgId = this.GetAlgorithmIdentifier(macOid, encKey, asn1Params, out cipherParameters);
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
			return this.Open(outStr, macAlgId, encKey, recipientInfos);
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x000F322C File Offset: 0x000F142C
		protected global::System.IO.Stream Open(global::System.IO.Stream outStr, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier macAlgId, global::Org.BouncyCastle.Crypto.ICipherParameters cipherParameters, global::Org.BouncyCastle.Asn1.Asn1EncodableVector recipientInfos)
		{
			global::System.IO.Stream result;
			try
			{
				global::Org.BouncyCastle.Asn1.BerSequenceGenerator cGen = new global::Org.BouncyCastle.Asn1.BerSequenceGenerator(outStr);
				cGen.AddObject(global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.AuthenticatedData);
				global::Org.BouncyCastle.Asn1.BerSequenceGenerator authGen = new global::Org.BouncyCastle.Asn1.BerSequenceGenerator(cGen.GetRawOutputStream(), 0, true);
				authGen.AddObject(new global::Org.BouncyCastle.Asn1.DerInteger(global::Org.BouncyCastle.Asn1.Cms.AuthenticatedData.CalculateVersion(null)));
				global::System.IO.Stream authRaw = authGen.GetRawOutputStream();
				global::Org.BouncyCastle.Asn1.Asn1Generator recipGen = this._berEncodeRecipientSet ? new global::Org.BouncyCastle.Asn1.BerSetGenerator(authRaw) : new global::Org.BouncyCastle.Asn1.DerSetGenerator(authRaw);
				foreach (object obj in recipientInfos)
				{
					global::Org.BouncyCastle.Asn1.Asn1Encodable ae = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj;
					recipGen.AddObject(ae);
				}
				recipGen.Close();
				authGen.AddObject(macAlgId);
				global::Org.BouncyCastle.Asn1.BerSequenceGenerator eiGen = new global::Org.BouncyCastle.Asn1.BerSequenceGenerator(authRaw);
				eiGen.AddObject(global::Org.BouncyCastle.Asn1.Cms.CmsObjectIdentifiers.Data);
				global::System.IO.Stream output = global::Org.BouncyCastle.Cms.CmsUtilities.CreateBerOctetOutputStream(eiGen.GetRawOutputStream(), 0, true, this._bufferSize);
				global::Org.BouncyCastle.Crypto.IMac mac = global::Org.BouncyCastle.Security.MacUtilities.GetMac(macAlgId.Algorithm);
				mac.Init(cipherParameters);
				result = new global::Org.BouncyCastle.Cms.CmsAuthenticatedDataStreamGenerator.CmsAuthenticatedDataOutputStream(new global::Org.BouncyCastle.Utilities.IO.TeeOutputStream(output, new global::Org.BouncyCastle.Crypto.IO.MacSink(mac)), mac, cGen, authGen, eiGen);
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

		// Token: 0x060032E6 RID: 13030 RVA: 0x000F3394 File Offset: 0x000F1594
		public global::System.IO.Stream Open(global::System.IO.Stream outStr, string encryptionOid)
		{
			global::Org.BouncyCastle.Crypto.CipherKeyGenerator keyGen = global::Org.BouncyCastle.Security.GeneratorUtilities.GetKeyGenerator(encryptionOid);
			keyGen.Init(new global::Org.BouncyCastle.Crypto.KeyGenerationParameters(this.rand, keyGen.DefaultStrength));
			return this.Open(outStr, encryptionOid, keyGen);
		}

		// Token: 0x060032E7 RID: 13031 RVA: 0x000F33C8 File Offset: 0x000F15C8
		public global::System.IO.Stream Open(global::System.IO.Stream outStr, string encryptionOid, int keySize)
		{
			global::Org.BouncyCastle.Crypto.CipherKeyGenerator keyGen = global::Org.BouncyCastle.Security.GeneratorUtilities.GetKeyGenerator(encryptionOid);
			keyGen.Init(new global::Org.BouncyCastle.Crypto.KeyGenerationParameters(this.rand, keySize));
			return this.Open(outStr, encryptionOid, keyGen);
		}

		// Token: 0x040016A5 RID: 5797
		private int _bufferSize;

		// Token: 0x040016A6 RID: 5798
		private bool _berEncodeRecipientSet;

		// Token: 0x02000838 RID: 2104
		private class CmsAuthenticatedDataOutputStream : global::Org.BouncyCastle.Utilities.IO.BaseOutputStream
		{
			// Token: 0x06004706 RID: 18182 RVA: 0x00139F45 File Offset: 0x00138145
			public CmsAuthenticatedDataOutputStream(global::System.IO.Stream macStream, global::Org.BouncyCastle.Crypto.IMac mac, global::Org.BouncyCastle.Asn1.BerSequenceGenerator cGen, global::Org.BouncyCastle.Asn1.BerSequenceGenerator authGen, global::Org.BouncyCastle.Asn1.BerSequenceGenerator eiGen)
			{
				this.macStream = macStream;
				this.mac = mac;
				this.cGen = cGen;
				this.authGen = authGen;
				this.eiGen = eiGen;
			}

			// Token: 0x06004707 RID: 18183 RVA: 0x00139F72 File Offset: 0x00138172
			public override void WriteByte(byte b)
			{
				this.macStream.WriteByte(b);
			}

			// Token: 0x06004708 RID: 18184 RVA: 0x00139F80 File Offset: 0x00138180
			public override void Write(byte[] bytes, int off, int len)
			{
				this.macStream.Write(bytes, off, len);
			}

			// Token: 0x06004709 RID: 18185 RVA: 0x00139F90 File Offset: 0x00138190
			public override void Close()
			{
				global::Org.BouncyCastle.Utilities.Platform.Dispose(this.macStream);
				this.eiGen.Close();
				byte[] macOctets = global::Org.BouncyCastle.Security.MacUtilities.DoFinal(this.mac);
				this.authGen.AddObject(new global::Org.BouncyCastle.Asn1.DerOctetString(macOctets));
				this.authGen.Close();
				this.cGen.Close();
				base.Close();
			}

			// Token: 0x0400257B RID: 9595
			private readonly global::System.IO.Stream macStream;

			// Token: 0x0400257C RID: 9596
			private readonly global::Org.BouncyCastle.Crypto.IMac mac;

			// Token: 0x0400257D RID: 9597
			private readonly global::Org.BouncyCastle.Asn1.BerSequenceGenerator cGen;

			// Token: 0x0400257E RID: 9598
			private readonly global::Org.BouncyCastle.Asn1.BerSequenceGenerator authGen;

			// Token: 0x0400257F RID: 9599
			private readonly global::Org.BouncyCastle.Asn1.BerSequenceGenerator eiGen;
		}
	}
}
