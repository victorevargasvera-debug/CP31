using System;
using System.IO;

namespace Ionic.Zip
{
	// Token: 0x0200004A RID: 74
	internal class ZipCipherStream : global::System.IO.Stream
	{
		// Token: 0x06000336 RID: 822 RVA: 0x00013056 File Offset: 0x00011256
		public ZipCipherStream(global::System.IO.Stream s, global::Ionic.Zip.ZipCrypto cipher, global::Ionic.Zip.CryptoMode mode)
		{
			if (s == null)
			{
				throw new global::System.ArgumentNullException("s");
			}
			this._cipher = cipher;
			this._s = s;
			this._mode = mode;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00013084 File Offset: 0x00011284
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

		// Token: 0x06000338 RID: 824 RVA: 0x000130EC File Offset: 0x000112EC
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

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000339 RID: 825 RVA: 0x00013161 File Offset: 0x00011361
		public override bool CanRead
		{
			get
			{
				return this._mode == global::Ionic.Zip.CryptoMode.Decrypt;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600033A RID: 826 RVA: 0x000060A5 File Offset: 0x000042A5
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600033B RID: 827 RVA: 0x0001316C File Offset: 0x0001136C
		public override bool CanWrite
		{
			get
			{
				return this._mode == global::Ionic.Zip.CryptoMode.Encrypt;
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00002061 File Offset: 0x00000261
		public override void Flush()
		{
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0000A809 File Offset: 0x00008A09
		public override long Length
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0000A809 File Offset: 0x00008A09
		// (set) Token: 0x0600033F RID: 831 RVA: 0x0000A809 File Offset: 0x00008A09
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

		// Token: 0x06000340 RID: 832 RVA: 0x0000A809 File Offset: 0x00008A09
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000A809 File Offset: 0x00008A09
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x04000232 RID: 562
		private global::Ionic.Zip.ZipCrypto _cipher;

		// Token: 0x04000233 RID: 563
		private global::System.IO.Stream _s;

		// Token: 0x04000234 RID: 564
		private global::Ionic.Zip.CryptoMode _mode;
	}
}
