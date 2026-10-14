using System;
using System.IO;
using NPOI.POIFS.Crypt.Standard;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI.POIFS.Crypt.BinaryRC4
{
	// Token: 0x0200031E RID: 798
	public class BinaryRC4Encryptor : global::NPOI.POIFS.Crypt.Encryptor
	{
		// Token: 0x0600171A RID: 5914 RVA: 0x00044C6F File Offset: 0x00042E6F
		protected internal BinaryRC4Encryptor(global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4EncryptionInfoBuilder builder)
		{
			this.builder = builder;
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x00044C80 File Offset: 0x00042E80
		public override void ConfirmPassword(string password)
		{
			global::System.Random random = new global::System.Random();
			byte[] array = new byte[16];
			byte[] array2 = new byte[16];
			random.NextBytes(array);
			random.NextBytes(array2);
			this.ConfirmPassword(password, null, null, array2, array, null);
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x00044CBC File Offset: 0x00042EBC
		public override void ConfirmPassword(string password, byte[] keySpec, byte[] keySalt, byte[] verifier, byte[] verifierSalt, byte[] integritySalt)
		{
			global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4EncryptionVerifier verifier2 = this.builder.GetVerifier();
			verifier2.SetSalt(verifierSalt);
			global::NPOI.POIFS.Crypt.ISecretKey secretKey = global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4Decryptor.GenerateSecretKey(password, verifier2);
			base.SetSecretKey(secretKey);
			try
			{
				global::NPOI.POIFS.Crypt.Cipher cipher = global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4Decryptor.InitCipherForBlock(null, 0, this.builder, secretKey, global::NPOI.POIFS.Crypt.Cipher.ENCRYPT_MODE);
				byte[] array = new byte[16];
				cipher.Update(verifier, 0, 16, array);
				verifier2.EncryptedVerifier = array;
				byte[] block = global::NPOI.POIFS.Crypt.CryptoFunctions.GetMessageDigest(verifier2.HashAlgorithm).Digest(verifier);
				byte[] encryptedVerifierHash = cipher.DoFinal(block);
				verifier2.EncryptedVerifierHash = encryptedVerifierHash;
			}
			catch (global::System.Exception cause)
			{
				throw new global::NPOI.EncryptedDocumentException("Password Confirmation failed", cause);
			}
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x00044D60 File Offset: 0x00042F60
		public override global::NPOI.Util.OutputStream GetDataStream(global::NPOI.POIFS.FileSystem.DirectoryNode dir)
		{
			global::System.IO.Stream @out = new global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4Encryptor.BinaryRC4CipherOutputStream(dir, this.builder, this).out1;
			throw new global::System.NotImplementedException("BinaryRC4CipherOutputStream should be derived from OutputStream");
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x00044D7F File Offset: 0x00042F7F
		protected int GetKeySizeInBytes()
		{
			return this.builder.GetHeader().KeySize / 8;
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x00044D94 File Offset: 0x00042F94
		protected internal void CreateEncryptionInfoEntry(global::NPOI.POIFS.FileSystem.DirectoryNode dir)
		{
			global::NPOI.POIFS.Crypt.DataSpaceMapUtils.AddDefaultDataSpace(dir);
			global::NPOI.POIFS.Crypt.EncryptionInfo encryptionInfo = this.builder.GetEncryptionInfo();
			global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4EncryptionHeader header = this.builder.GetHeader();
			global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4EncryptionVerifier verifier = this.builder.GetVerifier();
			global::NPOI.POIFS.Crypt.Standard.EncryptionRecord @out = new global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4Encryptor.EncryptionRecordInternal(encryptionInfo, header, verifier);
			global::NPOI.POIFS.Crypt.DataSpaceMapUtils.CreateEncryptionEntry(dir, "EncryptionInfo", @out);
		}

		// Token: 0x04000970 RID: 2416
		private global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4EncryptionInfoBuilder builder;

		// Token: 0x020005C1 RID: 1473
		protected class BinaryRC4CipherOutputStream : global::NPOI.POIFS.Crypt.ChunkedCipherOutputStream
		{
			// Token: 0x060034E1 RID: 13537 RVA: 0x000A479D File Offset: 0x000A299D
			protected override global::NPOI.POIFS.Crypt.Cipher InitCipherForBlock(global::NPOI.POIFS.Crypt.Cipher cipher, int block, bool lastChunk)
			{
				return global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4Decryptor.InitCipherForBlock(cipher, block, this.builder, this.encryptor.GetSecretKey(), global::NPOI.POIFS.Crypt.Cipher.ENCRYPT_MODE);
			}

			// Token: 0x060034E2 RID: 13538 RVA: 0x00019A7F File Offset: 0x00017C7F
			protected override void CalculateChecksum(global::System.IO.FileInfo file, int i)
			{
			}

			// Token: 0x060034E3 RID: 13539 RVA: 0x000A47BC File Offset: 0x000A29BC
			protected override void CreateEncryptionInfoEntry(global::NPOI.POIFS.FileSystem.DirectoryNode dir, global::System.IO.FileInfo tmpFile)
			{
				((global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4Encryptor)this.encryptor).CreateEncryptionInfoEntry(dir);
			}

			// Token: 0x060034E4 RID: 13540 RVA: 0x000A47CF File Offset: 0x000A29CF
			public BinaryRC4CipherOutputStream(global::NPOI.POIFS.FileSystem.DirectoryNode dir, global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4EncryptionInfoBuilder builder, global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4Encryptor encryptor) : base(dir, 512, builder, encryptor)
			{
			}
		}

		// Token: 0x020005C2 RID: 1474
		private class EncryptionRecordInternal : global::NPOI.POIFS.Crypt.Standard.EncryptionRecord
		{
			// Token: 0x060034E5 RID: 13541 RVA: 0x000A47DF File Offset: 0x000A29DF
			public EncryptionRecordInternal(global::NPOI.POIFS.Crypt.EncryptionInfo info, global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4EncryptionHeader header, global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4EncryptionVerifier verifier)
			{
				this.info = info;
				this.header = header;
				this.verifier = verifier;
			}

			// Token: 0x060034E6 RID: 13542 RVA: 0x000A47FC File Offset: 0x000A29FC
			public void Write(global::NPOI.Util.LittleEndianByteArrayOutputStream bos)
			{
				bos.WriteShort(this.info.VersionMajor);
				bos.WriteShort(this.info.VersionMinor);
				this.header.Write(bos);
				this.verifier.Write(bos);
			}

			// Token: 0x04001974 RID: 6516
			private global::NPOI.POIFS.Crypt.EncryptionInfo info;

			// Token: 0x04001975 RID: 6517
			private global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4EncryptionHeader header;

			// Token: 0x04001976 RID: 6518
			private global::NPOI.POIFS.Crypt.BinaryRC4.BinaryRC4EncryptionVerifier verifier;
		}
	}
}
