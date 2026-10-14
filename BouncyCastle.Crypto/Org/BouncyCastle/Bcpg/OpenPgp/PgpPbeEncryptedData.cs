using System;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005B6 RID: 1462
	public class PgpPbeEncryptedData : global::Org.BouncyCastle.Bcpg.OpenPgp.PgpEncryptedData
	{
		// Token: 0x06003689 RID: 13961 RVA: 0x00101FD5 File Offset: 0x001001D5
		internal PgpPbeEncryptedData(global::Org.BouncyCastle.Bcpg.SymmetricKeyEncSessionPacket keyData, global::Org.BouncyCastle.Bcpg.InputStreamPacket encData) : base(encData)
		{
			this.keyData = keyData;
		}

		// Token: 0x0600368A RID: 13962 RVA: 0x00101FE5 File Offset: 0x001001E5
		public override global::System.IO.Stream GetInputStream()
		{
			return this.encData.GetInputStream();
		}

		// Token: 0x0600368B RID: 13963 RVA: 0x00101FF2 File Offset: 0x001001F2
		public global::System.IO.Stream GetDataStream(char[] passPhrase)
		{
			return this.DoGetDataStream(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.EncodePassPhrase(passPhrase, false), true);
		}

		// Token: 0x0600368C RID: 13964 RVA: 0x00102002 File Offset: 0x00100202
		public global::System.IO.Stream GetDataStreamUtf8(char[] passPhrase)
		{
			return this.DoGetDataStream(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.EncodePassPhrase(passPhrase, true), true);
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x00102012 File Offset: 0x00100212
		public global::System.IO.Stream GetDataStreamRaw(byte[] rawPassPhrase)
		{
			return this.DoGetDataStream(rawPassPhrase, false);
		}

		// Token: 0x0600368E RID: 13966 RVA: 0x0010201C File Offset: 0x0010021C
		internal global::System.IO.Stream DoGetDataStream(byte[] rawPassPhrase, bool clearPassPhrase)
		{
			global::System.IO.Stream encStream;
			try
			{
				global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag keyAlgorithm = this.keyData.EncAlgorithm;
				global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.DoMakeKeyFromPassPhrase(keyAlgorithm, this.keyData.S2k, rawPassPhrase, clearPassPhrase);
				byte[] secKeyData = this.keyData.GetSecKeyData();
				if (secKeyData != null && secKeyData.Length != 0)
				{
					global::Org.BouncyCastle.Crypto.IBufferedCipher keyCipher = global::Org.BouncyCastle.Security.CipherUtilities.GetCipher(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetSymmetricCipherName(keyAlgorithm) + "/CFB/NoPadding");
					keyCipher.Init(false, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(key, new byte[keyCipher.GetBlockSize()]));
					byte[] keyBytes = keyCipher.DoFinal(secKeyData);
					keyAlgorithm = (global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag)keyBytes[0];
					key = global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetSymmetricCipherName(keyAlgorithm), keyBytes, 1, keyBytes.Length - 1);
				}
				global::Org.BouncyCastle.Crypto.IBufferedCipher c = this.CreateStreamCipher(keyAlgorithm);
				byte[] iv = new byte[c.GetBlockSize()];
				c.Init(false, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(key, iv));
				this.encStream = global::Org.BouncyCastle.Bcpg.BcpgInputStream.Wrap(new global::Org.BouncyCastle.Crypto.IO.CipherStream(this.encData.GetInputStream(), c, null));
				if (this.encData is global::Org.BouncyCastle.Bcpg.SymmetricEncIntegrityPacket)
				{
					this.truncStream = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpEncryptedData.TruncatedStream(this.encStream);
					global::Org.BouncyCastle.Crypto.IDigest digest = global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetDigestName(global::Org.BouncyCastle.Bcpg.HashAlgorithmTag.Sha1));
					this.encStream = new global::Org.BouncyCastle.Crypto.IO.DigestStream(this.truncStream, digest, null);
				}
				if (global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(this.encStream, iv, 0, iv.Length) < iv.Length)
				{
					throw new global::System.IO.EndOfStreamException("unexpected end of stream.");
				}
				int v = this.encStream.ReadByte();
				int v2 = this.encStream.ReadByte();
				if (v < 0 || v2 < 0)
				{
					throw new global::System.IO.EndOfStreamException("unexpected end of stream.");
				}
				bool flag = iv[iv.Length - 2] == (byte)v && iv[iv.Length - 1] == (byte)v2;
				bool zeroesCheckPassed = v == 0 && v2 == 0;
				if (!flag && !zeroesCheckPassed)
				{
					throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpDataValidationException("quick check failed.");
				}
				encStream = this.encStream;
			}
			catch (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException ex)
			{
				throw ex;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Exception creating cipher", e);
			}
			return encStream;
		}

		// Token: 0x0600368F RID: 13967 RVA: 0x00102214 File Offset: 0x00100414
		private global::Org.BouncyCastle.Crypto.IBufferedCipher CreateStreamCipher(global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag keyAlgorithm)
		{
			string mode = (this.encData is global::Org.BouncyCastle.Bcpg.SymmetricEncIntegrityPacket) ? "CFB" : "OpenPGPCFB";
			return global::Org.BouncyCastle.Security.CipherUtilities.GetCipher(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetSymmetricCipherName(keyAlgorithm) + "/" + mode + "/NoPadding");
		}

		// Token: 0x040018D6 RID: 6358
		private readonly global::Org.BouncyCastle.Bcpg.SymmetricKeyEncSessionPacket keyData;
	}
}
