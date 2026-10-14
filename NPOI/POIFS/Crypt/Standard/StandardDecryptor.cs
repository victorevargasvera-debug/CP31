using System;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI.POIFS.Crypt.Standard
{
	// Token: 0x0200030C RID: 780
	public class StandardDecryptor : global::NPOI.POIFS.Crypt.Decryptor
	{
		// Token: 0x06001696 RID: 5782 RVA: 0x000430BD File Offset: 0x000412BD
		internal StandardDecryptor(global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder builder) : base(builder)
		{
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x000430D0 File Offset: 0x000412D0
		public override bool VerifyPassword(string password)
		{
			global::NPOI.POIFS.Crypt.EncryptionVerifier verifier = this.builder.GetVerifier();
			global::NPOI.POIFS.Crypt.ISecretKey secretKey = global::NPOI.POIFS.Crypt.Standard.StandardDecryptor.GenerateSecretKey(password, verifier, base.GetKeySizeInBytes());
			global::NPOI.POIFS.Crypt.Cipher cipher = this.GetCipher(secretKey);
			bool result;
			try
			{
				byte[] encryptedVerifier = verifier.EncryptedVerifier;
				byte[] array = cipher.DoFinal(encryptedVerifier);
				base.SetVerifier(array);
				byte[] array2 = global::NPOI.POIFS.Crypt.CryptoFunctions.GetMessageDigest(verifier.HashAlgorithm).Digest(array);
				byte[] encryptedVerifierHash = verifier.EncryptedVerifierHash;
				byte[] b = global::NPOI.Util.Arrays.CopyOf(cipher.DoFinal(encryptedVerifierHash), array2.Length);
				if (global::NPOI.Util.Arrays.Equals(array2, b))
				{
					base.SetSecretKey(secretKey);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (global::System.Exception cause)
			{
				throw new global::NPOI.EncryptedDocumentException(cause);
			}
			return result;
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x0004317C File Offset: 0x0004137C
		protected internal static global::NPOI.POIFS.Crypt.ISecretKey GenerateSecretKey(string password, global::NPOI.POIFS.Crypt.EncryptionVerifier ver, int keySize)
		{
			global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm = ver.HashAlgorithm;
			byte[] passwordHash = global::NPOI.POIFS.Crypt.CryptoFunctions.HashPassword(password, hashAlgorithm, ver.Salt, ver.SpinCount);
			byte[] array = new byte[4];
			global::NPOI.Util.LittleEndian.PutInt(array, 0, 0);
			byte[] hash = global::NPOI.POIFS.Crypt.CryptoFunctions.GenerateKey(passwordHash, hashAlgorithm, array, hashAlgorithm.hashSize);
			byte[] array2 = global::NPOI.POIFS.Crypt.Standard.StandardDecryptor.FillAndXor(hash, 54);
			byte[] array3 = global::NPOI.POIFS.Crypt.Standard.StandardDecryptor.FillAndXor(hash, 92);
			byte[] array4 = new byte[array2.Length + array3.Length];
			global::System.Array.Copy(array2, 0, array4, 0, array2.Length);
			global::System.Array.Copy(array3, 0, array4, array2.Length, array3.Length);
			return new global::NPOI.POIFS.Crypt.SecretKeySpec(global::NPOI.Util.Arrays.CopyOf(array4, keySize), ver.CipherAlgorithm.jceId);
		}

		// Token: 0x06001699 RID: 5785 RVA: 0x00043214 File Offset: 0x00041414
		protected static byte[] FillAndXor(byte[] hash, byte FillByte)
		{
			byte[] array = new byte[64];
			global::NPOI.Util.Arrays.Fill(array, FillByte);
			for (int i = 0; i < hash.Length; i++)
			{
				array[i] ^= hash[i];
			}
			return global::NPOI.POIFS.Crypt.CryptoFunctions.GetMessageDigest(global::NPOI.POIFS.Crypt.HashAlgorithm.sha1).Digest(array);
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x0004325C File Offset: 0x0004145C
		private global::NPOI.POIFS.Crypt.Cipher GetCipher(global::NPOI.POIFS.Crypt.ISecretKey key)
		{
			global::NPOI.POIFS.Crypt.EncryptionHeader header = this.builder.GetHeader();
			global::NPOI.POIFS.Crypt.ChainingMode chainingMode = header.ChainingMode;
			return global::NPOI.POIFS.Crypt.CryptoFunctions.GetCipher(key, header.CipherAlgorithm, chainingMode, null, global::NPOI.POIFS.Crypt.Cipher.DECRYPT_MODE);
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x00043290 File Offset: 0x00041490
		public override global::NPOI.Util.InputStream GetDataStream(global::NPOI.POIFS.FileSystem.DirectoryNode dir)
		{
			global::NPOI.POIFS.FileSystem.DocumentInputStream documentInputStream = dir.CreateDocumentInputStream(global::NPOI.POIFS.Crypt.Encryptor.DEFAULT_POIFS_ENTRY);
			this._length = documentInputStream.ReadLong();
			if (base.GetSecretKey() == null)
			{
				this.VerifyPassword(null);
			}
			int blockSize = this.builder.GetHeader().CipherAlgorithm.blockSize;
			long size = (this._length / (long)blockSize + 1L) * (long)blockSize;
			global::NPOI.POIFS.Crypt.Cipher cipher = this.GetCipher(base.GetSecretKey());
			return new global::NPOI.Util.BoundedInputStream(new global::NPOI.POIFS.Crypt.Standard.CipherInputStream(new global::NPOI.Util.BoundedInputStream(documentInputStream, size), cipher), this._length);
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x00043310 File Offset: 0x00041510
		public override long GetLength()
		{
			if (this._length == -1L)
			{
				throw new global::System.InvalidOperationException("Decryptor.DataStream was not called");
			}
			return this._length;
		}

		// Token: 0x0400094D RID: 2381
		private long _length = -1L;
	}
}
