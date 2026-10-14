using System;
using System.IO;

namespace Ionic.Zip
{
	// Token: 0x02000465 RID: 1125
	internal class ZipCipherStream : global::System.IO.Stream
	{
		// Token: 0x0600305E RID: 12382 RVA: 0x000AB84C File Offset: 0x000A9A4C
		public ZipCipherStream(global::System.IO.Stream s, global::Ionic.Zip.ZipCrypto cipher, global::Ionic.Zip.CryptoMode mode)
		{
			this._cipher = cipher;
			this._s = s;
			this._mode = mode;
		}

		// Token: 0x0600305F RID: 12383 RVA: 0x000AB86C File Offset: 0x000A9A6C
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (this._mode == global::Ionic.Zip.CryptoMode.Encrypt)
			{
				throw new global::System.NotSupportedException("This stream does not encrypt via Read()");
			}
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			byte[] array = new byte[count];
			int num = this._s.Read(array, 0, count);
			byte[] array2 = this._cipher.DecryptMessage(array, num);
			for (int i = 0; i < num; i++)
			{
				buffer[offset + i] = array2[i];
			}
			return num;
		}

		// Token: 0x06003060 RID: 12384 RVA: 0x000AB8E0 File Offset: 0x000A9AE0
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this._mode == global::Ionic.Zip.CryptoMode.Decrypt)
			{
				throw new global::System.NotSupportedException("This stream does not Decrypt via Write()");
			}
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (count == 0)
			{
				return;
			}
			byte[] array;
			if (offset != 0)
			{
				array = new byte[count];
				for (int i = 0; i < count; i++)
				{
					array[i] = buffer[offset + i];
				}
			}
			else
			{
				array = buffer;
			}
			byte[] array2 = this._cipher.EncryptMessage(array, count);
			this._s.Write(array2, 0, array2.Length);
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x06003061 RID: 12385 RVA: 0x000AB96C File Offset: 0x000A9B6C
		public override bool CanRead
		{
			get
			{
				return this._mode == global::Ionic.Zip.CryptoMode.Decrypt;
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x06003062 RID: 12386 RVA: 0x000AB978 File Offset: 0x000A9B78
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x06003063 RID: 12387 RVA: 0x000AB97C File Offset: 0x000A9B7C
		public override bool CanWrite
		{
			get
			{
				return this._mode == global::Ionic.Zip.CryptoMode.Encrypt;
			}
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x000AB988 File Offset: 0x000A9B88
		public override void Flush()
		{
		}

		// Token: 0x17000DDD RID: 3549
		// (get) Token: 0x06003065 RID: 12389 RVA: 0x000AB98C File Offset: 0x000A9B8C
		public override long Length
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000DDE RID: 3550
		// (get) Token: 0x06003066 RID: 12390 RVA: 0x000AB994 File Offset: 0x000A9B94
		// (set) Token: 0x06003067 RID: 12391 RVA: 0x000AB99C File Offset: 0x000A9B9C
		public override long Position
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x000AB9A4 File Offset: 0x000A9BA4
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06003069 RID: 12393 RVA: 0x000AB9AC File Offset: 0x000A9BAC
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x040011B8 RID: 4536
		private global::Ionic.Zip.ZipCrypto _cipher;

		// Token: 0x040011B9 RID: 4537
		private global::System.IO.Stream _s;

		// Token: 0x040011BA RID: 4538
		private global::Ionic.Zip.CryptoMode _mode;
	}
}
