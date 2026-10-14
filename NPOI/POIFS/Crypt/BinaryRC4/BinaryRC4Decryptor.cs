using System;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI.POIFS.Crypt.BinaryRC4
{
	// Token: 0x0200031A RID: 794
	public class BinaryRC4Decryptor : global::NPOI.POIFS.Crypt.Decryptor
	{
		// Token: 0x06001702 RID: 5890 RVA: 0x00044837 File Offset: 0x00042A37
		protected internal BinaryRC4Decryptor(global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4EncryptionInfoBuilder builder) : base(builder)
		{
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x00044848 File Offset: 0x00042A48
		public override bool VerifyPassword(string password)
		{
			global::NPOI.POIFS.Crypt.EncryptionVerifier verifier = this.builder.GetVerifier();
			global::NPOI.POIFS.Crypt.ISecretKey secretKey = global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4Decryptor.GenerateSecretKey(password, verifier);
			try
			{
				global::NPOI.POIFS.Crypt.Cipher cipher = global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4Decryptor.InitCipherForBlock(null, 0, this.builder, secretKey, global::NPOI.POIFS.Crypt.Cipher.DECRYPT_MODE);
				byte[] encryptedVerifier = verifier.EncryptedVerifier;
				byte[] array = new byte[encryptedVerifier.Length];
				cipher.Update(encryptedVerifier, 0, encryptedVerifier.Length, array);
				base.SetVerifier(array);
				byte[] encryptedVerifierHash = verifier.EncryptedVerifierHash;
				byte[] b = cipher.DoFinal(encryptedVerifierHash);
				if (global::NPOI.Util.Arrays.Equals(global::NPOI.POIFS.Crypt.CryptoFunctions.GetMessageDigest(verifier.HashAlgorithm).Digest(array), b))
				{
					base.SetSecretKey(secretKey);
					return true;
				}
			}
			catch (global::System.Exception cause)
			{
				throw new global::NPOI.EncryptedDocumentException(cause);
			}
			return false;
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x000448F4 File Offset: 0x00042AF4
		protected internal static global::NPOI.POIFS.Crypt.Cipher InitCipherForBlock(global::NPOI.POIFS.Crypt.Cipher cipher, int block, global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder builder, global::NPOI.POIFS.Crypt.ISecretKey skey, int encryptMode)
		{
			global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm = builder.GetVerifier().HashAlgorithm;
			byte[] array = new byte[4];
			global::NPOI.Util.LittleEndian.PutUInt(array, 0, (long)block);
			global::NPOI.POIFS.Crypt.ISecretKey key = new global::NPOI.POIFS.Crypt.SecretKeySpec(global::NPOI.POIFS.Crypt.CryptoFunctions.GenerateKey(skey.GetEncoded(), hashAlgorithm, array, 16), skey.GetAlgorithm());
			if (cipher == null)
			{
				global::NPOI.POIFS.Crypt.EncryptionHeader header = builder.GetHeader();
				cipher = global::NPOI.POIFS.Crypt.CryptoFunctions.GetCipher(key, header.CipherAlgorithm, null, null, encryptMode);
			}
			else
			{
				cipher.Init(encryptMode, key);
			}
			return cipher;
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x00044960 File Offset: 0x00042B60
		protected internal static global::NPOI.POIFS.Crypt.ISecretKey GenerateSecretKey(string password, global::NPOI.POIFS.Crypt.EncryptionVerifier ver)
		{
			if (password.Length > 255)
			{
				password = password.Substring(0, 255);
			}
			global::NPOI.POIFS.Crypt.MessageDigest messageDigest = global::NPOI.POIFS.Crypt.CryptoFunctions.GetMessageDigest(ver.HashAlgorithm);
			byte[] array = messageDigest.Digest(global::NPOI.Util.StringUtil.GetToUnicodeLE(password));
			byte[] salt = ver.Salt;
			messageDigest.Reset();
			for (int i = 0; i < 16; i++)
			{
				messageDigest.Update(array, 0, 5);
				messageDigest.Update(salt);
			}
			array = new byte[5];
			global::System.Array.Copy(messageDigest.Digest(), 0, array, 0, 5);
			return new global::NPOI.POIFS.Crypt.SecretKeySpec(array, ver.CipherAlgorithm.jceId);
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x000449F4 File Offset: 0x00042BF4
		public override global::NPOI.Util.InputStream GetDataStream(global::NPOI.POIFS.FileSystem.DirectoryNode dir)
		{
			global::NPOI.POIFS.FileSystem.DocumentInputStream documentInputStream = dir.CreateDocumentInputStream(global::NPOI.POIFS.Crypt.Decryptor.DEFAULT_POIFS_ENTRY);
			this._length = documentInputStream.ReadLong();
			new global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4Decryptor.BinaryRC4CipherInputStream(documentInputStream, this._length, this);
			throw new global::System.NotImplementedException("BinaryRC4CipherInputStream should be derived from InputStream");
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x00044A31 File Offset: 0x00042C31
		public override long GetLength()
		{
			if (this._length == -1L)
			{
				throw new global::System.InvalidOperationException("Decryptor.DataStream was not called");
			}
			return this._length;
		}

		// Token: 0x0400096A RID: 2410
		private long _length = -1L;

		// Token: 0x020005C0 RID: 1472
		private class BinaryRC4CipherInputStream : global::NPOI.POIFS.Crypt.ChunkedCipherInputStream
		{
			// Token: 0x060034DF RID: 13535 RVA: 0x000A475C File Offset: 0x000A295C
			protected override global::NPOI.POIFS.Crypt.Cipher InitCipherForBlock(global::NPOI.POIFS.Crypt.Cipher existing, int block)
			{
				return global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4Decryptor.InitCipherForBlock(existing, block, this.decryptor.builder, this.decryptor.GetSecretKey(), global::NPOI.POIFS.Crypt.Cipher.DECRYPT_MODE);
			}

			// Token: 0x060034E0 RID: 13536 RVA: 0x000A4780 File Offset: 0x000A2980
			public BinaryRC4CipherInputStream(global::NPOI.POIFS.FileSystem.DocumentInputStream stream, long size, global::NPOI.POIFS.Crypt.Decryptor decryptor) : base(stream, size, 512, decryptor.builder, decryptor)
			{
				this.decryptor = decryptor;
			}
		}
	}
}
