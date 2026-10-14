using System;
using NPOI.POIFS.FileSystem;
using NPOI.Util;
using Org.BouncyCastle.X509;

namespace NPOI.POIFS.Crypt.Agile
{
	// Token: 0x02000113 RID: 275
	public class AgileDecryptor : global::NPOI.POIFS.Crypt.Decryptor
	{
		// Token: 0x06000F9F RID: 3999 RVA: 0x00036CE3 File Offset: 0x00034EE3
		protected internal AgileDecryptor(global::NPOI.POIFS.Crypt.Agile.AgileEncryptionInfoBuilder builder) : base(builder)
		{
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00036CF4 File Offset: 0x00034EF4
		public override bool VerifyPassword(string password)
		{
			global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier agileEncryptionVerifier = (global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier)this.builder.GetVerifier();
			global::NPOI.POIFS.Crypt.Agile.AgileEncryptionHeader agileEncryptionHeader = (global::NPOI.POIFS.Crypt.Agile.AgileEncryptionHeader)this.builder.GetHeader();
			global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm = agileEncryptionHeader.HashAlgorithm;
			global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm = agileEncryptionHeader.CipherAlgorithm;
			int blockSize = agileEncryptionHeader.BlockSize;
			int size = agileEncryptionHeader.KeySize / 8;
			byte[] pwHash = global::NPOI.POIFS.Crypt.CryptoFunctions.HashPassword(password, agileEncryptionVerifier.HashAlgorithm, agileEncryptionVerifier.Salt, agileEncryptionVerifier.SpinCount);
			byte[] array = global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.hashInput(this.builder, pwHash, global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.kVerifierInputBlock, agileEncryptionVerifier.EncryptedVerifier, global::NPOI.POIFS.Crypt.Cipher.DECRYPT_MODE);
			base.SetVerifier(array);
			byte[] b = global::NPOI.POIFS.Crypt.CryptoFunctions.GetMessageDigest(hashAlgorithm).Digest(array);
			object block = global::NPOI.POIFS.Crypt.CryptoFunctions.GetBlock0(global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.hashInput(this.builder, pwHash, global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.kHashedVerifierBlock, agileEncryptionVerifier.EncryptedVerifierHash, global::NPOI.POIFS.Crypt.Cipher.DECRYPT_MODE), hashAlgorithm.hashSize);
			global::NPOI.POIFS.Crypt.SecretKeySpec secretKeySpec = new global::NPOI.POIFS.Crypt.SecretKeySpec(global::NPOI.POIFS.Crypt.CryptoFunctions.GetBlock0(global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.hashInput(this.builder, pwHash, global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.kCryptoKeyBlock, agileEncryptionVerifier.EncryptedKey, global::NPOI.POIFS.Crypt.Cipher.DECRYPT_MODE), size), agileEncryptionVerifier.CipherAlgorithm.jceId);
			byte[] vec = global::NPOI.POIFS.Crypt.CryptoFunctions.GenerateIv(hashAlgorithm, agileEncryptionHeader.KeySalt, global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.kIntegrityKeyBlock, blockSize);
			byte[] array2 = global::NPOI.POIFS.Crypt.CryptoFunctions.GetCipher(secretKeySpec, cipherAlgorithm, agileEncryptionVerifier.ChainingMode, vec, global::NPOI.POIFS.Crypt.Cipher.DECRYPT_MODE).DoFinal(agileEncryptionHeader.GetEncryptedHmacKey());
			array2 = global::NPOI.POIFS.Crypt.CryptoFunctions.GetBlock0(array2, hashAlgorithm.hashSize);
			vec = global::NPOI.POIFS.Crypt.CryptoFunctions.GenerateIv(hashAlgorithm, agileEncryptionHeader.KeySalt, global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.kIntegrityValueBlock, blockSize);
			byte[] array3 = global::NPOI.POIFS.Crypt.CryptoFunctions.GetCipher(secretKeySpec, cipherAlgorithm, agileEncryptionVerifier.ChainingMode, vec, global::NPOI.POIFS.Crypt.Cipher.DECRYPT_MODE).DoFinal(agileEncryptionHeader.GetEncryptedHmacValue());
			array3 = global::NPOI.POIFS.Crypt.CryptoFunctions.GetBlock0(array3, hashAlgorithm.hashSize);
			if (global::NPOI.Util.Arrays.Equals(block, b))
			{
				base.SetSecretKey(secretKeySpec);
				base.SetIntegrityHmacKey(array2);
				base.SetIntegrityHmacValue(array3);
				return true;
			}
			return false;
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00036EA4 File Offset: 0x000350A4
		public bool VerifyPassword(global::NPOI.POIFS.Crypt.Agile.KeyPair keyPair, global::Org.BouncyCastle.X509.X509Certificate x509)
		{
			global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier agileEncryptionVerifier = (global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier)this.builder.GetVerifier();
			global::NPOI.POIFS.Crypt.Agile.AgileEncryptionHeader agileEncryptionHeader = (global::NPOI.POIFS.Crypt.Agile.AgileEncryptionHeader)this.builder.GetHeader();
			global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm = agileEncryptionHeader.HashAlgorithm;
			global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm = agileEncryptionHeader.CipherAlgorithm;
			int blockSize = agileEncryptionHeader.BlockSize;
			global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier.AgileCertificateEntry agileCertificateEntry = null;
			foreach (global::NPOI.POIFS.Crypt.Agile.AgileEncryptionVerifier.AgileCertificateEntry agileCertificateEntry2 in agileEncryptionVerifier.GetCertificates())
			{
				if (x509.Equals(agileCertificateEntry2.x509))
				{
					agileCertificateEntry = agileCertificateEntry2;
					break;
				}
			}
			if (agileCertificateEntry == null)
			{
				return false;
			}
			global::NPOI.POIFS.Crypt.Cipher instance = global::NPOI.POIFS.Crypt.Cipher.GetInstance("RSA");
			instance.Init(global::NPOI.POIFS.Crypt.Cipher.DECRYPT_MODE, keyPair.getPrivate());
			global::NPOI.POIFS.Crypt.SecretKeySpec secretKeySpec = new global::NPOI.POIFS.Crypt.SecretKeySpec(instance.DoFinal(agileCertificateEntry.encryptedKey), agileEncryptionVerifier.CipherAlgorithm.jceId);
			global::NPOI.POIFS.Crypt.CryptoFunctions.Mac mac = global::NPOI.POIFS.Crypt.CryptoFunctions.GetMac(hashAlgorithm);
			mac.Init(secretKeySpec);
			byte[] b = mac.DoFinal(agileCertificateEntry.x509.GetEncoded());
			byte[] vec = global::NPOI.POIFS.Crypt.CryptoFunctions.GenerateIv(hashAlgorithm, agileEncryptionHeader.KeySalt, global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.kIntegrityKeyBlock, blockSize);
			byte[] array = global::NPOI.POIFS.Crypt.CryptoFunctions.GetCipher(secretKeySpec, cipherAlgorithm, agileEncryptionVerifier.ChainingMode, vec, global::NPOI.POIFS.Crypt.Cipher.DECRYPT_MODE).DoFinal(agileEncryptionHeader.GetEncryptedHmacKey());
			array = global::NPOI.POIFS.Crypt.CryptoFunctions.GetBlock0(array, hashAlgorithm.hashSize);
			vec = global::NPOI.POIFS.Crypt.CryptoFunctions.GenerateIv(hashAlgorithm, agileEncryptionHeader.KeySalt, global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.kIntegrityValueBlock, blockSize);
			byte[] array2 = global::NPOI.POIFS.Crypt.CryptoFunctions.GetCipher(secretKeySpec, cipherAlgorithm, agileEncryptionVerifier.ChainingMode, vec, global::NPOI.POIFS.Crypt.Cipher.DECRYPT_MODE).DoFinal(agileEncryptionHeader.GetEncryptedHmacValue());
			array2 = global::NPOI.POIFS.Crypt.CryptoFunctions.GetBlock0(array2, hashAlgorithm.hashSize);
			if (global::NPOI.Util.Arrays.Equals(agileCertificateEntry.certVerifier, b))
			{
				base.SetSecretKey(secretKeySpec);
				base.SetIntegrityHmacKey(array);
				base.SetIntegrityHmacValue(array2);
				return true;
			}
			return false;
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x0003705C File Offset: 0x0003525C
		protected internal static int GetNextBlockSize(int inputLen, int blockSize)
		{
			int i;
			for (i = blockSize; i < inputLen; i += blockSize)
			{
			}
			return i;
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00037078 File Offset: 0x00035278
		protected internal static byte[] hashInput(global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder builder, byte[] pwHash, byte[] blockKey, byte[] inputKey, int cipherMode)
		{
			global::NPOI.POIFS.Crypt.EncryptionVerifier verifier = builder.GetVerifier();
			global::NPOI.POIFS.Crypt.Agile.AgileDecryptor agileDecryptor = (global::NPOI.POIFS.Crypt.Agile.AgileDecryptor)builder.GetDecryptor();
			int keySizeInBytes = agileDecryptor.GetKeySizeInBytes();
			int blockSizeInBytes = agileDecryptor.GetBlockSizeInBytes();
			global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm = verifier.HashAlgorithm;
			byte[] salt = verifier.Salt;
			global::NPOI.POIFS.Crypt.ISecretKey key = new global::NPOI.POIFS.Crypt.SecretKeySpec(global::NPOI.POIFS.Crypt.CryptoFunctions.GenerateKey(pwHash, hashAlgorithm, blockKey, keySizeInBytes), verifier.CipherAlgorithm.jceId);
			byte[] vec = global::NPOI.POIFS.Crypt.CryptoFunctions.GenerateIv(hashAlgorithm, salt, null, blockSizeInBytes);
			global::NPOI.POIFS.Crypt.Cipher cipher = global::NPOI.POIFS.Crypt.CryptoFunctions.GetCipher(key, verifier.CipherAlgorithm, verifier.ChainingMode, vec, cipherMode);
			byte[] result;
			try
			{
				inputKey = global::NPOI.POIFS.Crypt.CryptoFunctions.GetBlock0(inputKey, global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.GetNextBlockSize(inputKey.Length, blockSizeInBytes));
				result = cipher.DoFinal(inputKey);
			}
			catch (global::System.Exception cause)
			{
				throw new global::NPOI.EncryptedDocumentException(cause);
			}
			return result;
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x00037124 File Offset: 0x00035324
		public override global::NPOI.Util.InputStream GetDataStream(global::NPOI.POIFS.FileSystem.DirectoryNode dir)
		{
			global::NPOI.POIFS.FileSystem.DocumentInputStream documentInputStream = dir.CreateDocumentInputStream(global::NPOI.POIFS.Crypt.Decryptor.DEFAULT_POIFS_ENTRY);
			this._length = documentInputStream.ReadLong();
			new global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.AgileCipherInputStream(documentInputStream, this._length, this.builder, this);
			throw new global::System.NotImplementedException("AgileCipherInputStream should be derived from InputStream");
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00037167 File Offset: 0x00035367
		public override long GetLength()
		{
			if (this._length == -1L)
			{
				throw new global::System.InvalidOperationException("EcmaDecryptor.DataStream was not called");
			}
			return this._length;
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00037184 File Offset: 0x00035384
		protected internal static global::NPOI.POIFS.Crypt.Cipher InitCipherForBlock(global::NPOI.POIFS.Crypt.Cipher existing, int block, bool lastChunk, global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder builder, global::NPOI.POIFS.Crypt.ISecretKey skey, int encryptionMode)
		{
			global::NPOI.POIFS.Crypt.EncryptionHeader header = builder.GetHeader();
			if (existing == null || lastChunk)
			{
				string padding = lastChunk ? "PKCS5PAdding" : "NoPAdding";
				existing = global::NPOI.POIFS.Crypt.CryptoFunctions.GetCipher(skey, header.CipherAlgorithm, header.ChainingMode, header.KeySalt, encryptionMode, padding);
			}
			byte[] array = new byte[4];
			global::NPOI.Util.LittleEndian.PutInt(array, 0, block);
			byte[] array2 = global::NPOI.POIFS.Crypt.CryptoFunctions.GenerateIv(header.HashAlgorithm, header.KeySalt, array, header.BlockSize);
			global::NPOI.POIFS.Crypt.AlgorithmParameterSpec aps;
			if (header.CipherAlgorithm == global::NPOI.POIFS.Crypt.CipherAlgorithm.rc2)
			{
				aps = new global::NPOI.POIFS.Crypt.RC2ParameterSpec(skey.GetEncoded().Length * 8, array2);
			}
			else
			{
				aps = new global::NPOI.POIFS.Crypt.IvParameterSpec(array2);
			}
			existing.Init(encryptionMode, skey, aps);
			return existing;
		}

		// Token: 0x040004CB RID: 1227
		private long _length = -1L;

		// Token: 0x040004CC RID: 1228
		protected internal static byte[] kVerifierInputBlock = new byte[]
		{
			254,
			167,
			210,
			118,
			59,
			75,
			158,
			121
		};

		// Token: 0x040004CD RID: 1229
		protected internal static byte[] kHashedVerifierBlock = new byte[]
		{
			215,
			170,
			15,
			109,
			48,
			97,
			52,
			78
		};

		// Token: 0x040004CE RID: 1230
		protected internal static byte[] kCryptoKeyBlock = new byte[]
		{
			20,
			110,
			11,
			231,
			171,
			172,
			208,
			214
		};

		// Token: 0x040004CF RID: 1231
		protected internal static byte[] kIntegrityKeyBlock = new byte[]
		{
			95,
			178,
			173,
			1,
			12,
			185,
			225,
			246
		};

		// Token: 0x040004D0 RID: 1232
		protected internal static byte[] kIntegrityValueBlock = new byte[]
		{
			160,
			103,
			127,
			2,
			178,
			44,
			132,
			51
		};

		// Token: 0x0200014F RID: 335
		private class AgileCipherInputStream : global::NPOI.POIFS.Crypt.ChunkedCipherInputStream
		{
			// Token: 0x0600107D RID: 4221 RVA: 0x000394D7 File Offset: 0x000376D7
			public AgileCipherInputStream(global::NPOI.POIFS.FileSystem.DocumentInputStream stream, long size, global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder builder, global::NPOI.POIFS.Crypt.Agile.AgileDecryptor decryptor) : base(stream, size, 4096, builder, decryptor)
			{
				this.builder = builder;
				this.decryptor = decryptor;
			}

			// Token: 0x0600107E RID: 4222 RVA: 0x000394F8 File Offset: 0x000376F8
			protected override global::NPOI.POIFS.Crypt.Cipher InitCipherForBlock(global::NPOI.POIFS.Crypt.Cipher cipher, int block)
			{
				return global::NPOI.POIFS.Crypt.Agile.AgileDecryptor.InitCipherForBlock(cipher, block, false, this.builder, this.decryptor.GetSecretKey(), global::NPOI.POIFS.Crypt.Cipher.DECRYPT_MODE);
			}
		}
	}
}
