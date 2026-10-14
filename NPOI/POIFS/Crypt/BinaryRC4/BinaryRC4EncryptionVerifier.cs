using System;
using NPOI.POIFS.Crypt.Standard;
using NPOI.Util;

namespace NPOI.POIFS.Crypt.BinaryRC4
{
	// Token: 0x0200031D RID: 797
	public class BinaryRC4EncryptionVerifier : global::NPOI.POIFS.Crypt.EncryptionVerifier, global::NPOI.POIFS.Crypt.Standard.EncryptionRecord
	{
		// Token: 0x06001716 RID: 5910 RVA: 0x00044B84 File Offset: 0x00042D84
		protected internal BinaryRC4EncryptionVerifier()
		{
			base.SpinCount = -1;
			base.CipherAlgorithm = global::NPOI.POIFS.Crypt.CipherAlgorithm.rc4;
			base.ChainingMode = null;
			base.EncryptedKey = null;
			base.HashAlgorithm = global::NPOI.POIFS.Crypt.HashAlgorithm.md5;
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x00044BB8 File Offset: 0x00042DB8
		protected internal BinaryRC4EncryptionVerifier(global::NPOI.Util.ILittleEndianInput is1)
		{
			byte[] array = new byte[16];
			is1.ReadFully(array);
			this.SetSalt(array);
			byte[] array2 = new byte[16];
			is1.ReadFully(array2);
			base.EncryptedVerifier = array2;
			byte[] array3 = new byte[16];
			is1.ReadFully(array3);
			base.EncryptedVerifierHash = array3;
			base.SpinCount = -1;
			base.CipherAlgorithm = global::NPOI.POIFS.Crypt.CipherAlgorithm.rc4;
			base.ChainingMode = null;
			base.EncryptedKey = null;
			base.HashAlgorithm = global::NPOI.POIFS.Crypt.HashAlgorithm.md5;
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x00043AB6 File Offset: 0x00041CB6
		protected internal void SetSalt(byte[] salt)
		{
			if (salt == null || salt.Length != 16)
			{
				throw new global::NPOI.EncryptedDocumentException("invalid verifier salt");
			}
			base.Salt = salt;
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00044C38 File Offset: 0x00042E38
		public void Write(global::NPOI.Util.LittleEndianByteArrayOutputStream bos)
		{
			byte[] salt = base.Salt;
			bos.Write(salt);
			byte[] encryptedVerifier = base.EncryptedVerifier;
			bos.Write(encryptedVerifier);
			byte[] encryptedVerifierHash = base.EncryptedVerifierHash;
			bos.Write(encryptedVerifierHash);
		}
	}
}
