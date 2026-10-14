using System;
using System.Collections.Generic;
using System.IO;
using NPOI.HPSF;
using NPOI.POIFS.Crypt.Standard;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI.POIFS.Crypt.CryptoAPI
{
	// Token: 0x02000319 RID: 793
	public class CryptoAPIEncryptor : global::NPOI.POIFS.Crypt.Encryptor
	{
		// Token: 0x060016FB RID: 5883 RVA: 0x00044417 File Offset: 0x00042617
		protected internal CryptoAPIEncryptor(global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptionInfoBuilder builder)
		{
			this.builder = builder;
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x00044428 File Offset: 0x00042628
		public override void ConfirmPassword(string password)
		{
			global::System.Random random = new global::System.Random();
			byte[] array = new byte[16];
			byte[] array2 = new byte[16];
			random.NextBytes(array);
			random.NextBytes(array2);
			this.ConfirmPassword(password, null, null, array2, array, null);
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00044464 File Offset: 0x00042664
		public override void ConfirmPassword(string password, byte[] keySpec, byte[] keySalt, byte[] verifier, byte[] verifierSalt, byte[] integritySalt)
		{
			global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptionVerifier verifier2 = this.builder.GetVerifier();
			verifier2.SetSalt(verifierSalt);
			global::NPOI.POIFS.Crypt.ISecretKey secretKey = global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor.GenerateSecretKey(password, verifier2);
			base.SetSecretKey(secretKey);
			try
			{
				global::NPOI.POIFS.Crypt.Cipher cipher = this.InitCipherForBlock(null, 0);
				byte[] array = new byte[verifier.Length];
				cipher.Update(verifier, 0, verifier.Length, array);
				verifier2.SetEncryptedVerifier(array);
				byte[] block = global::NPOI.POIFS.Crypt.CryptoFunctions.GetMessageDigest(verifier2.HashAlgorithm).Digest(verifier);
				byte[] encryptedVerifierHash = cipher.DoFinal(block);
				verifier2.SetEncryptedVerifierHash(encryptedVerifierHash);
			}
			catch (global::System.Exception cause)
			{
				throw new global::NPOI.EncryptedDocumentException("Password Confirmation failed", cause);
			}
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x00044500 File Offset: 0x00042700
		public global::NPOI.POIFS.Crypt.Cipher InitCipherForBlock(global::NPOI.POIFS.Crypt.Cipher cipher, int block)
		{
			return global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor.InitCipherForBlock(cipher, block, this.builder, base.GetSecretKey(), global::NPOI.POIFS.Crypt.Cipher.ENCRYPT_MODE);
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x0004451C File Offset: 0x0004271C
		public override global::NPOI.Util.OutputStream GetDataStream(global::NPOI.POIFS.FileSystem.DirectoryNode dir)
		{
			global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptor.CipherByteArrayOutputStream cipherByteArrayOutputStream = new global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptor.CipherByteArrayOutputStream(this);
			byte[] array = new byte[8];
			cipherByteArrayOutputStream.Write(array, 0, 8);
			string[] array2 = new string[]
			{
				"\u0005SummaryInformation",
				"\u0005DocumentSummaryInformation"
			};
			global::System.Collections.Generic.List<global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor.StreamDescriptorEntry> list = new global::System.Collections.Generic.List<global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor.StreamDescriptorEntry>();
			int num = 0;
			foreach (string text in array2)
			{
				if (dir.HasEntry(text))
				{
					global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor.StreamDescriptorEntry streamDescriptorEntry = new global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor.StreamDescriptorEntry();
					streamDescriptorEntry.block = num;
					streamDescriptorEntry.streamOffset = (int)cipherByteArrayOutputStream.Length;
					streamDescriptorEntry.streamName = text;
					streamDescriptorEntry.flags = global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor.StreamDescriptorEntry.flagStream.SetValue(0, 1);
					streamDescriptorEntry.reserved2 = 0;
					cipherByteArrayOutputStream.SetBlock(num);
					global::NPOI.POIFS.FileSystem.DocumentInputStream documentInputStream = dir.CreateDocumentInputStream(text);
					global::NPOI.Util.IOUtils.Copy(documentInputStream, cipherByteArrayOutputStream);
					documentInputStream.Close();
					streamDescriptorEntry.streamSize = (int)(cipherByteArrayOutputStream.Length - (long)streamDescriptorEntry.streamOffset);
					list.Add(streamDescriptorEntry);
					dir.GetEntry(text).Delete();
					num++;
				}
			}
			int num2 = (int)cipherByteArrayOutputStream.Length;
			cipherByteArrayOutputStream.SetBlock(0);
			global::NPOI.Util.LittleEndian.PutUInt(array, 0, (long)list.Count);
			cipherByteArrayOutputStream.Write(array, 0, 4);
			foreach (global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor.StreamDescriptorEntry streamDescriptorEntry2 in list)
			{
				global::NPOI.Util.LittleEndian.PutUInt(array, 0, (long)streamDescriptorEntry2.streamOffset);
				cipherByteArrayOutputStream.Write(array, 0, 4);
				global::NPOI.Util.LittleEndian.PutUInt(array, 0, (long)streamDescriptorEntry2.streamSize);
				cipherByteArrayOutputStream.Write(array, 0, 4);
				global::NPOI.Util.LittleEndian.PutUShort(array, 0, streamDescriptorEntry2.block);
				cipherByteArrayOutputStream.Write(array, 0, 2);
				global::NPOI.Util.LittleEndian.PutUByte(array, 0, (short)streamDescriptorEntry2.streamName.Length);
				cipherByteArrayOutputStream.Write(array, 0, 1);
				global::NPOI.Util.LittleEndian.PutUByte(array, 0, (short)streamDescriptorEntry2.flags);
				cipherByteArrayOutputStream.Write(array, 0, 1);
				global::NPOI.Util.LittleEndian.PutUInt(array, 0, (long)streamDescriptorEntry2.reserved2);
				cipherByteArrayOutputStream.Write(array, 0, 4);
				byte[] toUnicodeLE = global::NPOI.Util.StringUtil.GetToUnicodeLE(streamDescriptorEntry2.streamName);
				cipherByteArrayOutputStream.Write(toUnicodeLE, 0, toUnicodeLE.Length);
				global::NPOI.Util.LittleEndian.PutShort(array, 0, 0);
				cipherByteArrayOutputStream.Write(array, 0, 2);
			}
			int num3 = (int)cipherByteArrayOutputStream.Length;
			int num4 = num3 - num2;
			global::NPOI.Util.LittleEndian.PutUInt(array, 0, (long)num2);
			global::NPOI.Util.LittleEndian.PutUInt(array, 4, (long)num4);
			cipherByteArrayOutputStream.Reset();
			cipherByteArrayOutputStream.SetBlock(0);
			cipherByteArrayOutputStream.Write(array, 0, 8);
			cipherByteArrayOutputStream.SetSize((long)num3);
			dir.CreateDocument("EncryptedSummary", new global::System.IO.MemoryStream(cipherByteArrayOutputStream.GetBuf(), 0, num3));
			global::NPOI.HPSF.DocumentSummaryInformation documentSummaryInformation = global::NPOI.HPSF.PropertySetFactory.NewDocumentSummaryInformation();
			try
			{
				documentSummaryInformation.Write(dir, "\u0005DocumentSummaryInformation");
			}
			catch (global::NPOI.HPSF.WritingNotSupportedException ex)
			{
				throw new global::System.IO.IOException(ex.Message);
			}
			throw new global::System.NotImplementedException("CipherByteArrayOutputStream should be derived from OutputStream");
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x000447D8 File Offset: 0x000429D8
		protected int GetKeySizeInBytes()
		{
			return this.builder.GetHeader().KeySize / 8;
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x000447EC File Offset: 0x000429EC
		protected void CreateEncryptionInfoEntry(global::NPOI.POIFS.FileSystem.DirectoryNode dir)
		{
			global::NPOI.POIFS.Crypt.DataSpaceMapUtils.AddDefaultDataSpace(dir);
			global::NPOI.POIFS.Crypt.EncryptionInfo encryptionInfo = this.builder.GetEncryptionInfo();
			global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptionHeader header = this.builder.GetHeader();
			global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptionVerifier verifier = this.builder.GetVerifier();
			global::NPOI.POIFS.Crypt.Standard.EncryptionRecord @out = new global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptor.EncryptionRecordInternal(encryptionInfo, header, verifier);
			global::NPOI.POIFS.Crypt.DataSpaceMapUtils.CreateEncryptionEntry(dir, "EncryptionInfo", @out);
		}

		// Token: 0x04000969 RID: 2409
		private global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptionInfoBuilder builder;

		// Token: 0x020005BE RID: 1470
		private class EncryptionRecordInternal : global::NPOI.POIFS.Crypt.Standard.EncryptionRecord
		{
			// Token: 0x060034D6 RID: 13526 RVA: 0x000A4607 File Offset: 0x000A2807
			public EncryptionRecordInternal(global::NPOI.POIFS.Crypt.EncryptionInfo info, global::NPOI.POIFS.Crypt.Standard.StandardEncryptionHeader header, global::NPOI.POIFS.Crypt.Standard.StandardEncryptionVerifier verifier)
			{
				this.info = info;
				this.header = header;
				this.verifier = verifier;
			}

			// Token: 0x060034D7 RID: 13527 RVA: 0x000A4624 File Offset: 0x000A2824
			public void Write(global::NPOI.Util.LittleEndianByteArrayOutputStream bos)
			{
				bos.WriteShort(this.info.VersionMajor);
				bos.WriteShort(this.info.VersionMinor);
				this.header.Write(bos);
				this.verifier.Write(bos);
			}

			// Token: 0x0400196E RID: 6510
			private global::NPOI.POIFS.Crypt.EncryptionInfo info;

			// Token: 0x0400196F RID: 6511
			private global::NPOI.POIFS.Crypt.Standard.StandardEncryptionHeader header;

			// Token: 0x04001970 RID: 6512
			private global::NPOI.POIFS.Crypt.Standard.StandardEncryptionVerifier verifier;
		}

		// Token: 0x020005BF RID: 1471
		private class CipherByteArrayOutputStream : global::NPOI.Util.ByteArrayOutputStream
		{
			// Token: 0x060034D8 RID: 13528 RVA: 0x000A4660 File Offset: 0x000A2860
			public CipherByteArrayOutputStream(global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptor encryptor)
			{
				this.encryptor = encryptor;
			}

			// Token: 0x060034D9 RID: 13529 RVA: 0x000A467B File Offset: 0x000A287B
			public CipherByteArrayOutputStream()
			{
				this.SetBlock(0);
			}

			// Token: 0x060034DA RID: 13530 RVA: 0x000A4696 File Offset: 0x000A2896
			public byte[] GetBuf()
			{
				return base.ToArray();
			}

			// Token: 0x060034DB RID: 13531 RVA: 0x000A469E File Offset: 0x000A289E
			public void SetSize(long count)
			{
				base.SetLength(count);
			}

			// Token: 0x060034DC RID: 13532 RVA: 0x000A46A7 File Offset: 0x000A28A7
			public void SetBlock(int block)
			{
				this.cipher = this.encryptor.InitCipherForBlock(this.cipher, block);
			}

			// Token: 0x060034DD RID: 13533 RVA: 0x000A46C4 File Offset: 0x000A28C4
			public new void Write(int b)
			{
				try
				{
					this.oneByte[0] = (byte)b;
					this.cipher.Update(this.oneByte, 0, 1, this.oneByte, 0);
					base.Write(this.oneByte);
				}
				catch (global::System.Exception cause)
				{
					throw new global::NPOI.EncryptedDocumentException(cause);
				}
			}

			// Token: 0x060034DE RID: 13534 RVA: 0x000A471C File Offset: 0x000A291C
			public new void Write(byte[] b, int off, int len)
			{
				try
				{
					this.cipher.Update(b, off, len, b, off);
					base.Write(b, off, len);
				}
				catch (global::System.Exception cause)
				{
					throw new global::NPOI.EncryptedDocumentException(cause);
				}
			}

			// Token: 0x04001971 RID: 6513
			private global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptor encryptor;

			// Token: 0x04001972 RID: 6514
			private global::NPOI.POIFS.Crypt.Cipher cipher;

			// Token: 0x04001973 RID: 6515
			private byte[] oneByte = new byte[1];
		}
	}
}
