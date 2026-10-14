using System;
using System.IO;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005B9 RID: 1465
	public class PgpPublicKeyEncryptedData : global::Org.BouncyCastle.Bcpg.OpenPgp.PgpEncryptedData
	{
		// Token: 0x060036C3 RID: 14019 RVA: 0x001036A8 File Offset: 0x001018A8
		internal PgpPublicKeyEncryptedData(global::Org.BouncyCastle.Bcpg.PublicKeyEncSessionPacket keyData, global::Org.BouncyCastle.Bcpg.InputStreamPacket encData) : base(encData)
		{
			this.keyData = keyData;
		}

		// Token: 0x060036C4 RID: 14020 RVA: 0x001036B8 File Offset: 0x001018B8
		private static global::Org.BouncyCastle.Crypto.IBufferedCipher GetKeyCipher(global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag algorithm)
		{
			global::Org.BouncyCastle.Crypto.IBufferedCipher cipher;
			try
			{
				if (algorithm - global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.RsaGeneral > 1)
				{
					if (algorithm != global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalEncrypt && algorithm != global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.ElGamalGeneral)
					{
						throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("unknown asymmetric algorithm: " + algorithm.ToString());
					}
					cipher = global::Org.BouncyCastle.Security.CipherUtilities.GetCipher("ElGamal/ECB/PKCS1Padding");
				}
				else
				{
					cipher = global::Org.BouncyCastle.Security.CipherUtilities.GetCipher("RSA//PKCS1Padding");
				}
			}
			catch (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException ex)
			{
				throw ex;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Exception creating cipher", e);
			}
			return cipher;
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x0010373C File Offset: 0x0010193C
		private bool ConfirmCheckSum(byte[] sessionInfo)
		{
			int check = 0;
			for (int i = 1; i != sessionInfo.Length - 2; i++)
			{
				check += (int)(sessionInfo[i] & byte.MaxValue);
			}
			return sessionInfo[sessionInfo.Length - 2] == (byte)(check >> 8) && sessionInfo[sessionInfo.Length - 1] == (byte)check;
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x060036C6 RID: 14022 RVA: 0x00103781 File Offset: 0x00101981
		public long KeyId
		{
			get
			{
				return this.keyData.KeyId;
			}
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x0010378E File Offset: 0x0010198E
		public global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag GetSymmetricAlgorithm(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPrivateKey privKey)
		{
			return (global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag)this.RecoverSessionData(privKey)[0];
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x0010379C File Offset: 0x0010199C
		public global::System.IO.Stream GetDataStream(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPrivateKey privKey)
		{
			byte[] sessionData = this.RecoverSessionData(privKey);
			if (!this.ConfirmCheckSum(sessionData))
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpKeyValidationException("key checksum failed");
			}
			global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag symmAlg = (global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag)sessionData[0];
			if (symmAlg == global::Org.BouncyCastle.Bcpg.SymmetricKeyAlgorithmTag.Null)
			{
				return this.encData.GetInputStream();
			}
			string cipherName = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.GetSymmetricCipherName(symmAlg);
			string cName = cipherName;
			global::Org.BouncyCastle.Crypto.IBufferedCipher cipher;
			try
			{
				if (this.encData is global::Org.BouncyCastle.Bcpg.SymmetricEncIntegrityPacket)
				{
					cName += "/CFB/NoPadding";
				}
				else
				{
					cName += "/OpenPGPCFB/NoPadding";
				}
				cipher = global::Org.BouncyCastle.Security.CipherUtilities.GetCipher(cName);
			}
			catch (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException ex)
			{
				throw ex;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("exception creating cipher", e);
			}
			global::System.IO.Stream encStream;
			try
			{
				global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key = global::Org.BouncyCastle.Security.ParameterUtilities.CreateKeyParameter(cipherName, sessionData, 1, sessionData.Length - 3);
				byte[] iv = new byte[cipher.GetBlockSize()];
				cipher.Init(false, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(key, iv));
				this.encStream = global::Org.BouncyCastle.Bcpg.BcpgInputStream.Wrap(new global::Org.BouncyCastle.Crypto.IO.CipherStream(this.encData.GetInputStream(), cipher, null));
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
				int num = this.encStream.ReadByte();
				int v2 = this.encStream.ReadByte();
				if (num < 0 || v2 < 0)
				{
					throw new global::System.IO.EndOfStreamException("unexpected end of stream.");
				}
				encStream = this.encStream;
			}
			catch (global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException ex2)
			{
				throw ex2;
			}
			catch (global::System.Exception e2)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("Exception starting decryption", e2);
			}
			return encStream;
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x00103950 File Offset: 0x00101B50
		private byte[] RecoverSessionData(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPrivateKey privKey)
		{
			byte[][] secKeyData = this.keyData.GetEncSessionKey();
			if (this.keyData.Algorithm != global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.EC)
			{
				global::Org.BouncyCastle.Crypto.IBufferedCipher cipher = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyEncryptedData.GetKeyCipher(this.keyData.Algorithm);
				try
				{
					cipher.Init(false, privKey.Key);
				}
				catch (global::Org.BouncyCastle.Security.InvalidKeyException e)
				{
					throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("error setting asymmetric cipher", e);
				}
				if (this.keyData.Algorithm == global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.RsaEncrypt || this.keyData.Algorithm == global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag.RsaGeneral)
				{
					byte[] bi = secKeyData[0];
					cipher.ProcessBytes(bi, 2, bi.Length - 2);
				}
				else
				{
					int size = (((global::Org.BouncyCastle.Crypto.Parameters.ElGamalPrivateKeyParameters)privKey.Key).Parameters.P.BitLength + 7) / 8;
					global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyEncryptedData.ProcessEncodedMpi(cipher, size, secKeyData[0]);
					global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKeyEncryptedData.ProcessEncodedMpi(cipher, size, secKeyData[1]);
				}
				byte[] result;
				try
				{
					result = cipher.DoFinal();
				}
				catch (global::System.Exception e2)
				{
					throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("exception decrypting secret key", e2);
				}
				return result;
			}
			global::Org.BouncyCastle.Bcpg.ECDHPublicBcpgKey ecdhpublicBcpgKey = (global::Org.BouncyCastle.Bcpg.ECDHPublicBcpgKey)privKey.PublicKeyPacket.Key;
			global::Org.BouncyCastle.Asn1.X9.X9ECParameters x9ECParameters = global::Org.BouncyCastle.Crypto.Generators.ECKeyPairGenerator.FindECCurveByOid(ecdhpublicBcpgKey.CurveOid);
			byte[] enc = secKeyData[0];
			int pLen = (((int)(enc[0] & byte.MaxValue) << 8) + (int)(enc[1] & byte.MaxValue) + 7) / 8;
			if (2 + pLen + 1 > enc.Length)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("encoded length out of range");
			}
			byte[] pEnc = new byte[pLen];
			global::System.Array.Copy(enc, 2, pEnc, 0, pLen);
			int keyLen = (int)enc[pLen + 2];
			if (2 + pLen + 1 + keyLen > enc.Length)
			{
				throw new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpException("encoded length out of range");
			}
			byte[] keyEnc = new byte[keyLen];
			global::System.Array.Copy(enc, 2 + pLen + 1, keyEnc, 0, keyEnc.Length);
			global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = x9ECParameters.Curve.DecodePoint(pEnc);
			global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters privKeyParams = (global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)privKey.Key;
			global::Org.BouncyCastle.Math.EC.ECPoint S = ecpoint.Multiply(privKeyParams.D).Normalize();
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter key = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(global::Org.BouncyCastle.Bcpg.OpenPgp.Rfc6637Utilities.CreateKey(privKey.PublicKeyPacket, S));
			global::Org.BouncyCastle.Crypto.IWrapper wrapper = global::Org.BouncyCastle.Bcpg.OpenPgp.PgpUtilities.CreateWrapper(ecdhpublicBcpgKey.SymmetricKeyAlgorithm);
			wrapper.Init(false, key);
			return global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPad.UnpadSessionData(wrapper.Unwrap(keyEnc, 0, keyEnc.Length));
		}

		// Token: 0x060036CA RID: 14026 RVA: 0x00103B4C File Offset: 0x00101D4C
		private static void ProcessEncodedMpi(global::Org.BouncyCastle.Crypto.IBufferedCipher cipher, int size, byte[] mpiEnc)
		{
			if (mpiEnc.Length - 2 > size)
			{
				cipher.ProcessBytes(mpiEnc, 3, mpiEnc.Length - 3);
				return;
			}
			byte[] tmp = new byte[size];
			global::System.Array.Copy(mpiEnc, 2, tmp, tmp.Length - (mpiEnc.Length - 2), mpiEnc.Length - 2);
			cipher.ProcessBytes(tmp, 0, tmp.Length);
		}

		// Token: 0x040018E5 RID: 6373
		private global::Org.BouncyCastle.Bcpg.PublicKeyEncSessionPacket keyData;
	}
}
