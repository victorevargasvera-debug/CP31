using System;
using System.IO;
using NPOI.POIFS.EventFileSystem;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI.POIFS.Crypt.Standard
{
	// Token: 0x02000313 RID: 787
	public class StandardEncryptor : global::NPOI.POIFS.Crypt.Encryptor
	{
		// Token: 0x060016D2 RID: 5842 RVA: 0x00043B44 File Offset: 0x00041D44
		protected internal StandardEncryptor(global::NPOI.POIFS.Crypt.Standard.StandardEncryptionInfoBuilder builder)
		{
			this.builder = builder;
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x00043B54 File Offset: 0x00041D54
		public override void ConfirmPassword(string password)
		{
			global::System.Random random = new global::System.Random();
			byte[] array = new byte[16];
			byte[] array2 = new byte[16];
			random.NextBytes(array);
			random.NextBytes(array2);
			this.ConfirmPassword(password, null, null, array, array2, null);
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x00043B90 File Offset: 0x00041D90
		public override void ConfirmPassword(string password, byte[] keySpec, byte[] keySalt, byte[] verifier, byte[] verifierSalt, byte[] integritySalt)
		{
			global::NPOI.POIFS.Crypt.Standard.StandardEncryptionVerifier verifier2 = this.builder.GetVerifier();
			verifier2.SetSalt(verifierSalt);
			global::NPOI.POIFS.Crypt.ISecretKey secretKey = global::NPOI.POIFS.Crypt.Standard.StandardDecryptor.GenerateSecretKey(password, verifier2, this.GetKeySizeInBytes());
			base.SetSecretKey(secretKey);
			global::NPOI.POIFS.Crypt.Cipher cipher = this.GetCipher(secretKey, null);
			try
			{
				byte[] encryptedVerifier = cipher.DoFinal(verifier);
				byte[] source = global::NPOI.POIFS.Crypt.CryptoFunctions.GetMessageDigest(verifier2.HashAlgorithm).Digest(verifier);
				int encryptedVerifierHashLength = verifier2.CipherAlgorithm.encryptedVerifierHashLength;
				byte[] encryptedVerifierHash = cipher.DoFinal(global::NPOI.Util.Arrays.CopyOf(source, encryptedVerifierHashLength));
				verifier2.SetEncryptedVerifier(encryptedVerifier);
				verifier2.SetEncryptedVerifierHash(encryptedVerifierHash);
			}
			catch (global::System.Exception cause)
			{
				throw new global::NPOI.EncryptedDocumentException("Password Confirmation failed", cause);
			}
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x00043C3C File Offset: 0x00041E3C
		private global::NPOI.POIFS.Crypt.Cipher GetCipher(global::NPOI.POIFS.Crypt.ISecretKey key, string padding)
		{
			global::NPOI.POIFS.Crypt.EncryptionVerifier verifier = this.builder.GetVerifier();
			return global::NPOI.POIFS.Crypt.CryptoFunctions.GetCipher(key, verifier.CipherAlgorithm, verifier.ChainingMode, null, global::NPOI.POIFS.Crypt.Cipher.ENCRYPT_MODE, padding);
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x00043C6E File Offset: 0x00041E6E
		public override global::NPOI.Util.OutputStream GetDataStream(global::NPOI.POIFS.FileSystem.DirectoryNode dir)
		{
			this.CreateEncryptionInfoEntry(dir);
			global::NPOI.POIFS.Crypt.DataSpaceMapUtils.AddDefaultDataSpace(dir);
			new global::NPOI.POIFS.Crypt.Standard.StandardEncryptor.StandardCipherOutputStream(dir, this);
			throw new global::System.NotImplementedException("StandardCipherOutputStream should be derived from OutputStream");
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x00043C8F File Offset: 0x00041E8F
		protected int GetKeySizeInBytes()
		{
			return this.builder.GetHeader().KeySize / 8;
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x00043CA4 File Offset: 0x00041EA4
		protected internal void CreateEncryptionInfoEntry(global::NPOI.POIFS.FileSystem.DirectoryNode dir)
		{
			global::NPOI.POIFS.Crypt.EncryptionInfo encryptionInfo = this.builder.GetEncryptionInfo();
			global::NPOI.POIFS.Crypt.Standard.StandardEncryptionHeader header = this.builder.GetHeader();
			global::NPOI.POIFS.Crypt.Standard.StandardEncryptionVerifier verifier = this.builder.GetVerifier();
			global::NPOI.POIFS.Crypt.Standard.EncryptionRecord @out = new global::NPOI.POIFS.Crypt.Standard.StandardEncryptor.EncryptionRecordInternal(encryptionInfo, header, verifier);
			global::NPOI.POIFS.Crypt.DataSpaceMapUtils.CreateEncryptionEntry(dir, "EncryptionInfo", @out);
		}

		// Token: 0x0400095D RID: 2397
		private global::NPOI.POIFS.Crypt.Standard.StandardEncryptionInfoBuilder builder;

		// Token: 0x020005BA RID: 1466
		protected class StandardCipherOutputStream : global::NPOI.Util.ByteArrayOutputStream, global::NPOI.POIFS.EventFileSystem.POIFSWriterListener
		{
			// Token: 0x060034C7 RID: 13511 RVA: 0x000A4328 File Offset: 0x000A2528
			protected internal StandardCipherOutputStream(global::NPOI.POIFS.FileSystem.DirectoryNode dir, global::NPOI.POIFS.Crypt.Standard.StandardEncryptor encryptor)
			{
				this.encryptor = encryptor;
				this.dir = dir;
				this.fileOut = global::NPOI.Util.TempFile.CreateTempFile("encrypted_package", "crypt");
				this.rawStream = new global::System.IO.FileStream(this.fileOut.FullName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.ReadWrite);
				global::NPOI.POIFS.Crypt.Standard.CipherOutputStream cipherOutputStream = new global::NPOI.POIFS.Crypt.Standard.CipherOutputStream(this.rawStream, encryptor.GetCipher(encryptor.GetSecretKey(), "PKCS5Padding"));
				this.out1 = cipherOutputStream;
			}

			// Token: 0x060034C8 RID: 13512 RVA: 0x000A439A File Offset: 0x000A259A
			public override void Write(byte[] b, int off, int len)
			{
				this.out1.Write(b, off, len);
				this.countBytes += (long)len;
			}

			// Token: 0x060034C9 RID: 13513 RVA: 0x000A43B9 File Offset: 0x000A25B9
			public override void Write(int b)
			{
				this.out1.Write(b);
				this.countBytes += 1L;
			}

			// Token: 0x060034CA RID: 13514 RVA: 0x000A43D6 File Offset: 0x000A25D6
			public override void Close()
			{
				base.Close();
				this.WriteToPOIFS();
			}

			// Token: 0x060034CB RID: 13515 RVA: 0x000A43E4 File Offset: 0x000A25E4
			private void WriteToPOIFS()
			{
				int size = (int)(this.fileOut.Length + 8L);
				this.dir.CreateDocument(global::NPOI.POIFS.Crypt.Encryptor.DEFAULT_POIFS_ENTRY, size, this);
			}

			// Token: 0x060034CC RID: 13516 RVA: 0x000A4414 File Offset: 0x000A2614
			public void ProcessPOIFSWriterEvent(global::NPOI.POIFS.EventFileSystem.POIFSWriterEvent event1)
			{
				try
				{
					global::NPOI.Util.LittleEndianOutputStream littleEndianOutputStream = new global::NPOI.Util.LittleEndianOutputStream(event1.Stream);
					littleEndianOutputStream.WriteLong(this.countBytes);
					long position = this.rawStream.Position;
					global::NPOI.Util.IOUtils.Copy(this.rawStream, littleEndianOutputStream.out1);
					this.rawStream.Position = position;
					this.fileOut.Delete();
					littleEndianOutputStream.Close();
				}
				catch (global::System.IO.IOException cause)
				{
					throw new global::NPOI.EncryptedDocumentException(cause);
				}
			}

			// Token: 0x0400195C RID: 6492
			private global::NPOI.POIFS.Crypt.Standard.StandardEncryptor encryptor;

			// Token: 0x0400195D RID: 6493
			protected long countBytes;

			// Token: 0x0400195E RID: 6494
			protected global::System.IO.FileInfo fileOut;

			// Token: 0x0400195F RID: 6495
			protected global::NPOI.POIFS.FileSystem.DirectoryNode dir;

			// Token: 0x04001960 RID: 6496
			private global::NPOI.Util.ByteArrayOutputStream out1;

			// Token: 0x04001961 RID: 6497
			private global::System.IO.FileStream rawStream;
		}

		// Token: 0x020005BB RID: 1467
		private class EncryptionRecordInternal : global::NPOI.POIFS.Crypt.Standard.EncryptionRecord
		{
			// Token: 0x060034CD RID: 13517 RVA: 0x000A448C File Offset: 0x000A268C
			public EncryptionRecordInternal(global::NPOI.POIFS.Crypt.EncryptionInfo info, global::NPOI.POIFS.Crypt.Standard.StandardEncryptionHeader header, global::NPOI.POIFS.Crypt.Standard.StandardEncryptionVerifier verifier)
			{
				this.info = info;
				this.header = header;
				this.verifier = verifier;
			}

			// Token: 0x060034CE RID: 13518 RVA: 0x000A44AC File Offset: 0x000A26AC
			public void Write(global::NPOI.Util.LittleEndianByteArrayOutputStream bos)
			{
				bos.WriteShort(this.info.VersionMajor);
				bos.WriteShort(this.info.VersionMinor);
				bos.WriteInt(this.info.EncryptionFlags);
				this.header.Write(bos);
				this.verifier.Write(bos);
			}

			// Token: 0x04001962 RID: 6498
			private global::NPOI.POIFS.Crypt.EncryptionInfo info;

			// Token: 0x04001963 RID: 6499
			private global::NPOI.POIFS.Crypt.Standard.StandardEncryptionHeader header;

			// Token: 0x04001964 RID: 6500
			private global::NPOI.POIFS.Crypt.Standard.StandardEncryptionVerifier verifier;
		}
	}
}
