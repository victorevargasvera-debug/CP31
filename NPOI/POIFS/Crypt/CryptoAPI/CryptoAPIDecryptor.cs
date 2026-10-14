using System;
using System.IO;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI.POIFS.Crypt.CryptoAPI
{
	// Token: 0x02000315 RID: 789
	public class CryptoAPIDecryptor : global::NPOI.POIFS.Crypt.Decryptor
	{
		// Token: 0x060016E0 RID: 5856 RVA: 0x00043E84 File Offset: 0x00042084
		protected internal CryptoAPIDecryptor(global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIEncryptionInfoBuilder builder) : base(builder)
		{
			this._length = -1L;
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00043E98 File Offset: 0x00042098
		public override bool VerifyPassword(string password)
		{
			global::NPOI.POIFS.Crypt.EncryptionVerifier verifier = this.builder.GetVerifier();
			global::NPOI.POIFS.Crypt.ISecretKey secretKey = global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor.GenerateSecretKey(password, verifier);
			try
			{
				global::NPOI.POIFS.Crypt.Cipher cipher = global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor.InitCipherForBlock(null, 0, this.builder, secretKey, global::NPOI.POIFS.Crypt.Cipher.DECRYPT_MODE);
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

		// Token: 0x060016E2 RID: 5858 RVA: 0x00043F44 File Offset: 0x00042144
		public global::NPOI.POIFS.Crypt.Cipher InitCipherForBlock(global::NPOI.POIFS.Crypt.Cipher cipher, int block)
		{
			return global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor.InitCipherForBlock(cipher, block, this.builder, base.GetSecretKey(), global::NPOI.POIFS.Crypt.Cipher.DECRYPT_MODE);
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00043F60 File Offset: 0x00042160
		protected internal static global::NPOI.POIFS.Crypt.Cipher InitCipherForBlock(global::NPOI.POIFS.Crypt.Cipher cipher, int block, global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder builder, global::NPOI.POIFS.Crypt.ISecretKey skey, int encryptMode)
		{
			global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm = builder.GetVerifier().HashAlgorithm;
			byte[] array = new byte[4];
			global::NPOI.Util.LittleEndian.PutUInt(array, 0, (long)block);
			global::NPOI.POIFS.Crypt.MessageDigest messageDigest = global::NPOI.POIFS.Crypt.CryptoFunctions.GetMessageDigest(hashAlgorithm);
			messageDigest.Update(skey.GetEncoded());
			byte[] array2 = messageDigest.Digest(array);
			global::NPOI.POIFS.Crypt.EncryptionHeader header = builder.GetHeader();
			int keySize = header.KeySize;
			array2 = global::NPOI.POIFS.Crypt.CryptoFunctions.GetBlock0(array2, keySize / 8);
			if (keySize == 40)
			{
				array2 = global::NPOI.POIFS.Crypt.CryptoFunctions.GetBlock0(array2, 16);
			}
			global::NPOI.POIFS.Crypt.ISecretKey key = new global::NPOI.POIFS.Crypt.SecretKeySpec(array2, skey.GetAlgorithm());
			if (cipher == null)
			{
				cipher = global::NPOI.POIFS.Crypt.CryptoFunctions.GetCipher(key, header.CipherAlgorithm, null, null, encryptMode);
			}
			else
			{
				cipher.Init(encryptMode, key);
			}
			return cipher;
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00043FF8 File Offset: 0x000421F8
		protected internal static global::NPOI.POIFS.Crypt.ISecretKey GenerateSecretKey(string password, global::NPOI.POIFS.Crypt.EncryptionVerifier ver)
		{
			if (password.Length > 255)
			{
				password = password.Substring(0, 255);
			}
			global::NPOI.POIFS.Crypt.MessageDigest messageDigest = global::NPOI.POIFS.Crypt.CryptoFunctions.GetMessageDigest(ver.HashAlgorithm);
			messageDigest.Update(ver.Salt);
			return new global::NPOI.POIFS.Crypt.SecretKeySpec(messageDigest.Digest(global::NPOI.Util.StringUtil.GetToUnicodeLE(password)), ver.CipherAlgorithm.jceId);
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x00044054 File Offset: 0x00042254
		public override global::NPOI.Util.InputStream GetDataStream(global::NPOI.POIFS.FileSystem.DirectoryNode dir)
		{
			global::NPOI.POIFS.FileSystem.NPOIFSFileSystem npoifsfileSystem = new global::NPOI.POIFS.FileSystem.NPOIFSFileSystem();
			global::NPOI.POIFS.FileSystem.DocumentNode document = (global::NPOI.POIFS.FileSystem.DocumentNode)dir.GetEntry("EncryptedSummary");
			global::NPOI.POIFS.FileSystem.DocumentInputStream documentInputStream = dir.CreateDocumentInputStream(document);
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			global::NPOI.Util.IOUtils.Copy(documentInputStream, memoryStream);
			documentInputStream.Close();
			global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor.SeekableMemoryStream seekableMemoryStream = new global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor.SeekableMemoryStream(memoryStream.ToArray());
			global::NPOI.Util.LittleEndianInputStream littleEndianInputStream = new global::NPOI.Util.LittleEndianInputStream(seekableMemoryStream);
			int num = (int)littleEndianInputStream.ReadUInt();
			littleEndianInputStream.ReadUInt();
			seekableMemoryStream.Seek((long)(num - 8), global::System.IO.SeekOrigin.Current);
			seekableMemoryStream.SetBlock(0);
			int num2 = (int)littleEndianInputStream.ReadUInt();
			global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor.StreamDescriptorEntry[] array = new global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor.StreamDescriptorEntry[num2];
			for (int i = 0; i < num2; i++)
			{
				global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor.StreamDescriptorEntry streamDescriptorEntry = new global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor.StreamDescriptorEntry();
				array[i] = streamDescriptorEntry;
				streamDescriptorEntry.streamOffset = (int)littleEndianInputStream.ReadUInt();
				streamDescriptorEntry.streamSize = (int)littleEndianInputStream.ReadUInt();
				streamDescriptorEntry.block = littleEndianInputStream.ReadUShort();
				int nChars = littleEndianInputStream.ReadUByte();
				streamDescriptorEntry.flags = littleEndianInputStream.ReadUByte();
				global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor.StreamDescriptorEntry.flagStream.IsSet(streamDescriptorEntry.flags);
				streamDescriptorEntry.reserved2 = littleEndianInputStream.ReadInt();
				streamDescriptorEntry.streamName = global::NPOI.Util.StringUtil.ReadUnicodeLE(littleEndianInputStream, nChars);
				littleEndianInputStream.ReadShort();
			}
			foreach (global::NPOI.POIFS.Crypt.CryptoAPI.CryptoAPIDecryptor.StreamDescriptorEntry streamDescriptorEntry2 in array)
			{
				seekableMemoryStream.Seek(streamDescriptorEntry2.streamOffset);
				seekableMemoryStream.SetBlock(streamDescriptorEntry2.block);
				global::System.IO.Stream stream = new global::System.IO.BufferedStream(seekableMemoryStream, streamDescriptorEntry2.streamSize);
				npoifsfileSystem.CreateDocument(stream, streamDescriptorEntry2.streamName);
			}
			littleEndianInputStream.Close();
			memoryStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
			npoifsfileSystem.WriteFileSystem(memoryStream);
			npoifsfileSystem.Close();
			this._length = memoryStream.Length;
			new global::NPOI.Util.ByteArrayInputStream(memoryStream.ToArray());
			throw new global::System.NotImplementedException("ByteArrayInputStream should be derived from InputStream");
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00044217 File Offset: 0x00042417
		public override long GetLength()
		{
			if (this._length == -1L)
			{
				throw new global::System.InvalidOperationException("Decryptor.DataStream was not called");
			}
			return this._length;
		}

		// Token: 0x04000963 RID: 2403
		private long _length;

		// Token: 0x020005BC RID: 1468
		private class SeekableMemoryStream : global::System.IO.MemoryStream
		{
			// Token: 0x060034CF RID: 13519 RVA: 0x000A4504 File Offset: 0x000A2704
			public void Seek(int pos)
			{
				if ((long)pos > this.Length)
				{
					throw new global::System.IndexOutOfRangeException(string.Format("seek position({0}) is greater than stream length({1})", pos, this.Length));
				}
				throw new global::System.NotImplementedException();
			}

			// Token: 0x060034D0 RID: 13520 RVA: 0x00008C75 File Offset: 0x00006E75
			public void SetBlock(int block)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x060034D1 RID: 13521 RVA: 0x000A4538 File Offset: 0x000A2738
			public int Read()
			{
				int num = base.ReadByte();
				if (num == -1)
				{
					return -1;
				}
				this.oneByte[0] = (byte)num;
				try
				{
					this.cipher.Update(this.oneByte, 0, 1, this.oneByte);
				}
				catch (global::System.Exception cause)
				{
					throw new global::NPOI.EncryptedDocumentException(cause);
				}
				return (int)this.oneByte[0];
			}

			// Token: 0x060034D2 RID: 13522 RVA: 0x000A4598 File Offset: 0x000A2798
			public override int Read(byte[] b, int off, int len)
			{
				int num = base.Read(b, off, len);
				if (num == -1)
				{
					return -1;
				}
				try
				{
					this.cipher.Update(b, off, num, b, off);
				}
				catch (global::System.Exception cause)
				{
					throw new global::NPOI.EncryptedDocumentException(cause);
				}
				return num;
			}

			// Token: 0x060034D3 RID: 13523 RVA: 0x000A45E0 File Offset: 0x000A27E0
			public SeekableMemoryStream(byte[] buf) : base(buf)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x04001965 RID: 6501
			private global::NPOI.POIFS.Crypt.Cipher cipher;

			// Token: 0x04001966 RID: 6502
			private byte[] oneByte = new byte[1];
		}

		// Token: 0x020005BD RID: 1469
		internal class StreamDescriptorEntry
		{
			// Token: 0x04001967 RID: 6503
			internal static global::NPOI.Util.BitField flagStream = global::NPOI.Util.BitFieldFactory.GetInstance(1);

			// Token: 0x04001968 RID: 6504
			internal int streamOffset;

			// Token: 0x04001969 RID: 6505
			internal int streamSize;

			// Token: 0x0400196A RID: 6506
			internal int block;

			// Token: 0x0400196B RID: 6507
			internal int flags;

			// Token: 0x0400196C RID: 6508
			internal int reserved2;

			// Token: 0x0400196D RID: 6509
			internal string streamName;
		}
	}
}
