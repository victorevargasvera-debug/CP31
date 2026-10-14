using System;
using System.IO;
using System.Security;
using NPOI.Util;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x020002F3 RID: 755
	public abstract class ChunkedCipherInputStream : global::NPOI.Util.LittleEndianInputStream
	{
		// Token: 0x060015B7 RID: 5559 RVA: 0x00040BF4 File Offset: 0x0003EDF4
		public ChunkedCipherInputStream(global::NPOI.Util.ILittleEndianInput stream, long size, int chunkSize, global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder builder, global::NPOI.POIFS.Crypt.Decryptor decryptor) : base((global::System.IO.Stream)stream)
		{
			this._size = size;
			this.chunkSize = chunkSize;
			this.chunkMask = chunkSize - 1;
			this.chunkBits = global::NPOI.Util.Number.BitCount(this.chunkMask);
			this.builder = builder;
			this.decryptor = decryptor;
			this._cipher = this.InitCipherForBlock(null, 0);
		}

		// Token: 0x060015B8 RID: 5560
		protected abstract global::NPOI.POIFS.Crypt.Cipher InitCipherForBlock(global::NPOI.POIFS.Crypt.Cipher existing, int block);

		// Token: 0x060015B9 RID: 5561 RVA: 0x00040C54 File Offset: 0x0003EE54
		public int Read()
		{
			byte[] array = new byte[1];
			if (base.Read(array) == 1)
			{
				return (int)array[0];
			}
			return -1;
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00040C78 File Offset: 0x0003EE78
		public new int Read(byte[] b, int off, int len)
		{
			int num = 0;
			if (this.Available() <= 0)
			{
				return -1;
			}
			while (len > 0)
			{
				if (this._chunk == null)
				{
					try
					{
						this._chunk = this.NextChunk();
					}
					catch (global::System.Security.SecurityException ex)
					{
						throw new global::NPOI.EncryptedDocumentException(ex.Message, ex);
					}
				}
				int num2 = (int)((long)this.chunkSize - (this._pos & (long)this.chunkMask));
				int num3 = this.Available();
				if (num3 == 0)
				{
					return num;
				}
				num2 = global::System.Math.Min(num3, global::System.Math.Min(num2, len));
				global::System.Array.Copy(this._chunk, (int)(this._pos & (long)this.chunkMask), b, off, num2);
				off += num2;
				len -= num2;
				this._pos += (long)num2;
				if ((this._pos & (long)this.chunkMask) == 0L)
				{
					this._chunk = null;
				}
				num += num2;
			}
			return num;
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00040D54 File Offset: 0x0003EF54
		public new long Skip(long n)
		{
			long pos = this._pos;
			long num = global::System.Math.Min((long)this.Available(), n);
			if (((this._pos + num ^ pos) & (long)(~(long)this.chunkMask)) != 0L)
			{
				this._chunk = null;
			}
			this._pos += num;
			return num;
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00040DA1 File Offset: 0x0003EFA1
		public new int Available()
		{
			return (int)(this._size - this._pos);
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00006EB4 File Offset: 0x000050B4
		public bool MarkSupported()
		{
			return false;
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x000098C8 File Offset: 0x00007AC8
		public new void Mark(int Readlimit)
		{
			throw new global::System.InvalidOperationException();
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x000098C8 File Offset: 0x00007AC8
		public new void Reset()
		{
			throw new global::System.InvalidOperationException();
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x00040DB4 File Offset: 0x0003EFB4
		private byte[] NextChunk()
		{
			int num = (int)(this._pos >> this.chunkBits);
			this.InitCipherForBlock(this._cipher, num);
			if (this._lastIndex != num)
			{
				base.Skip((long)((long)(num - this._lastIndex) << this.chunkBits));
			}
			byte[] array = new byte[global::System.Math.Min(base.Available(), this.chunkSize)];
			base.Read(array, 0, array.Length);
			this._lastIndex = num + 1;
			return this._cipher.DoFinal(array);
		}

		// Token: 0x040008B8 RID: 2232
		private int chunkSize;

		// Token: 0x040008B9 RID: 2233
		private int chunkMask;

		// Token: 0x040008BA RID: 2234
		private int chunkBits;

		// Token: 0x040008BB RID: 2235
		private int _lastIndex;

		// Token: 0x040008BC RID: 2236
		private long _pos;

		// Token: 0x040008BD RID: 2237
		private long _size;

		// Token: 0x040008BE RID: 2238
		private byte[] _chunk;

		// Token: 0x040008BF RID: 2239
		private global::NPOI.POIFS.Crypt.Cipher _cipher;

		// Token: 0x040008C0 RID: 2240
		protected global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder builder;

		// Token: 0x040008C1 RID: 2241
		protected global::NPOI.POIFS.Crypt.Decryptor decryptor;
	}
}
