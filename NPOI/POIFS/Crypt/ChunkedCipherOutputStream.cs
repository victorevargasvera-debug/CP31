using System;
using System.IO;
using NPOI.POIFS.EventFileSystem;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x020002F4 RID: 756
	public abstract class ChunkedCipherOutputStream : global::NPOI.Util.LittleEndianOutputStream
	{
		// Token: 0x060015C1 RID: 5569 RVA: 0x00040E3C File Offset: 0x0003F03C
		public global::System.IO.Stream GetStream()
		{
			return this.out1;
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00040E44 File Offset: 0x0003F044
		public ChunkedCipherOutputStream(global::NPOI.POIFS.FileSystem.DirectoryNode dir, int chunkSize, global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder builder, global::NPOI.POIFS.Crypt.Encryptor encryptor) : base(null)
		{
			this.chunkSize = chunkSize;
			this.chunkMask = chunkSize - 1;
			this.chunkBits = global::NPOI.Util.Number.BitCount(this.chunkMask);
			this._chunk = new byte[chunkSize];
			this.fileOut = global::NPOI.Util.TempFile.CreateTempFile("encrypted_package", "crypt");
			this.out1 = this.fileOut.Create();
			this.dir = dir;
			this.builder = builder;
			this.encryptor = encryptor;
			this._cipher = this.InitCipherForBlock(null, 0, false);
		}

		// Token: 0x060015C3 RID: 5571
		protected abstract global::NPOI.POIFS.Crypt.Cipher InitCipherForBlock(global::NPOI.POIFS.Crypt.Cipher existing, int block, bool lastChunk);

		// Token: 0x060015C4 RID: 5572
		protected abstract void CalculateChecksum(global::System.IO.FileInfo fileOut, int oleStreamSize);

		// Token: 0x060015C5 RID: 5573
		protected abstract void CreateEncryptionInfoEntry(global::NPOI.POIFS.FileSystem.DirectoryNode dir, global::System.IO.FileInfo tmpFile);

		// Token: 0x060015C6 RID: 5574 RVA: 0x00040ED0 File Offset: 0x0003F0D0
		public void Write(int b)
		{
			this.Write(new byte[]
			{
				(byte)b
			});
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00040EE3 File Offset: 0x0003F0E3
		public new void Write(byte[] b)
		{
			this.Write(b, 0, b.Length);
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00040EF0 File Offset: 0x0003F0F0
		public new void Write(byte[] b, int off, int len)
		{
			if (len == 0)
			{
				return;
			}
			if (len < 0 || b.Length < off + len)
			{
				throw new global::System.IO.IOException("not enough bytes in your input buffer");
			}
			while (len > 0)
			{
				int num = (int)(this._pos & (long)this.chunkMask);
				int num2 = global::System.Math.Min(this.chunkSize - num, len);
				global::System.Array.Copy(b, off, this._chunk, num, num2);
				this._pos += (long)num2;
				off += num2;
				len -= num2;
				if ((this._pos & (long)this.chunkMask) == 0L)
				{
					try
					{
						this.WriteChunk();
					}
					catch (global::System.Exception ex)
					{
						throw new global::System.IO.IOException(ex.Message);
					}
				}
			}
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x00040F98 File Offset: 0x0003F198
		protected void WriteChunk()
		{
			int num = (int)(this._pos & (long)this.chunkMask);
			int num2 = (int)(this._pos >> this.chunkBits);
			bool lastChunk;
			if (num == 0)
			{
				num2--;
				num = this.chunkSize;
				lastChunk = false;
			}
			else
			{
				lastChunk = true;
			}
			this._cipher = this.InitCipherForBlock(this._cipher, num2, lastChunk);
			int count = this._cipher.DoFinal(this._chunk, 0, num, this._chunk);
			this.out1.Write(this._chunk, 0, count);
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x0004101C File Offset: 0x0003F21C
		public new void Close()
		{
			try
			{
				this.WriteChunk();
				base.Close();
				int size = (int)(this.fileOut.Length + 8L);
				this.CalculateChecksum(this.fileOut, (int)this._pos);
				this.dir.CreateDocument(global::NPOI.POIFS.Crypt.Decryptor.DEFAULT_POIFS_ENTRY, size, new global::NPOI.POIFS.Crypt.ChunkedCipherOutputStream.EncryptedPackageWriter(this));
				this.CreateEncryptionInfoEntry(this.dir, this.fileOut);
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.IO.IOException(ex.Message);
			}
		}

		// Token: 0x040008C2 RID: 2242
		protected int chunkSize;

		// Token: 0x040008C3 RID: 2243
		protected int chunkMask;

		// Token: 0x040008C4 RID: 2244
		protected int chunkBits;

		// Token: 0x040008C5 RID: 2245
		private byte[] _chunk;

		// Token: 0x040008C6 RID: 2246
		private global::System.IO.FileInfo fileOut;

		// Token: 0x040008C7 RID: 2247
		private global::NPOI.POIFS.FileSystem.DirectoryNode dir;

		// Token: 0x040008C8 RID: 2248
		private long _pos;

		// Token: 0x040008C9 RID: 2249
		private global::NPOI.POIFS.Crypt.Cipher _cipher;

		// Token: 0x040008CA RID: 2250
		protected global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder builder;

		// Token: 0x040008CB RID: 2251
		protected global::NPOI.POIFS.Crypt.Encryptor encryptor;

		// Token: 0x020005B1 RID: 1457
		private class EncryptedPackageWriter : global::NPOI.POIFS.EventFileSystem.POIFSWriterListener
		{
			// Token: 0x060034AA RID: 13482 RVA: 0x000A3C9A File Offset: 0x000A1E9A
			public EncryptedPackageWriter(global::NPOI.POIFS.Crypt.ChunkedCipherOutputStream stream)
			{
				this.stream = stream;
			}

			// Token: 0x060034AB RID: 13483 RVA: 0x000A3CAC File Offset: 0x000A1EAC
			public void ProcessPOIFSWriterEvent(global::NPOI.POIFS.EventFileSystem.POIFSWriterEvent event1)
			{
				try
				{
					global::NPOI.POIFS.FileSystem.DocumentOutputStream documentOutputStream = event1.Stream;
					byte[] array = new byte[this.stream.chunkSize];
					global::NPOI.Util.LittleEndian.PutLong(array, 0, this.stream._pos);
					documentOutputStream.Write(array, 0, 8);
					global::System.IO.FileStream fileStream = this.stream.fileOut.Create();
					int count;
					while ((count = fileStream.Read(array, 0, array.Length)) != -1)
					{
						documentOutputStream.Write(array, 0, count);
					}
					fileStream.Close();
					documentOutputStream.Close();
					this.stream.fileOut.Delete();
				}
				catch (global::System.IO.IOException cause)
				{
					throw new global::NPOI.EncryptedDocumentException(cause);
				}
			}

			// Token: 0x04001942 RID: 6466
			private global::NPOI.POIFS.Crypt.ChunkedCipherOutputStream stream;
		}
	}
}
