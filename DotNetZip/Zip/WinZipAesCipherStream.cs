using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

namespace Ionic.Zip
{
	// Token: 0x02000046 RID: 70
	internal class WinZipAesCipherStream : global::System.IO.Stream
	{
		// Token: 0x06000318 RID: 792 RVA: 0x00012632 File Offset: 0x00010832
		internal WinZipAesCipherStream(global::System.IO.Stream s, global::Ionic.Zip.WinZipAesCrypto cryptoParams, long length, global::Ionic.Zip.CryptoMode mode) : this(s, cryptoParams, mode)
		{
			if (s == null)
			{
				throw new global::System.ArgumentNullException("s");
			}
			this._length = length;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00012654 File Offset: 0x00010854
		internal WinZipAesCipherStream(global::System.IO.Stream s, global::Ionic.Zip.WinZipAesCrypto cryptoParams, global::Ionic.Zip.CryptoMode mode)
		{
			this._params = cryptoParams;
			this._s = s;
			this._mode = mode;
			this._nonce = 1;
			if (this._params == null)
			{
				throw new global::Ionic.Zip.BadPasswordException("Supply a password to use AES encryption.");
			}
			int num = this._params.KeyBytes.Length * 8;
			if (num != 256 && num != 128 && num != 192)
			{
				throw new global::System.ArgumentOutOfRangeException("keysize", "size of key must be 128, 192, or 256");
			}
			this._mac = new global::System.Security.Cryptography.HMACSHA1(this._params.MacIv);
			this._aesCipher = global::System.Security.Cryptography.Aes.Create();
			this._aesCipher.BlockSize = 128;
			this._aesCipher.KeySize = num;
			this._aesCipher.Mode = global::System.Security.Cryptography.CipherMode.ECB;
			this._aesCipher.Padding = global::System.Security.Cryptography.PaddingMode.None;
			byte[] rgbIV = new byte[16];
			this._xform = this._aesCipher.CreateEncryptor(this._params.KeyBytes, rgbIV);
			if (this._mode == global::Ionic.Zip.CryptoMode.Encrypt)
			{
				this._iobuf = new byte[2048];
				this._PendingWriteBlock = new byte[16];
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00012794 File Offset: 0x00010994
		private void XorInPlace(byte[] buffer, int offset, int count)
		{
			for (int i = 0; i < count; i++)
			{
				buffer[offset + i] = (this.counterOut[i] ^ buffer[offset + i]);
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000127C4 File Offset: 0x000109C4
		private void WriteTransformOneBlock(byte[] buffer, int offset)
		{
			int nonce = this._nonce;
			this._nonce = nonce + 1;
			global::System.Array.Copy(global::System.BitConverter.GetBytes(nonce), 0, this.counter, 0, 4);
			this._xform.TransformBlock(this.counter, 0, 16, this.counterOut, 0);
			this.XorInPlace(buffer, offset, 16);
			this._mac.TransformBlock(buffer, offset, 16, null, 0);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00012830 File Offset: 0x00010A30
		private void WriteTransformBlocks(byte[] buffer, int offset, int count)
		{
			int num = offset;
			int num2 = count + offset;
			while (num < buffer.Length && num < num2)
			{
				this.WriteTransformOneBlock(buffer, num);
				num += 16;
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0001285C File Offset: 0x00010A5C
		private void WriteTransformFinalBlock()
		{
			if (this._pendingCount == 0)
			{
				throw new global::System.InvalidOperationException("No bytes available.");
			}
			if (this._finalBlock)
			{
				throw new global::System.InvalidOperationException("The final block has already been transformed.");
			}
			int nonce = this._nonce;
			this._nonce = nonce + 1;
			global::System.Array.Copy(global::System.BitConverter.GetBytes(nonce), 0, this.counter, 0, 4);
			this.counterOut = this._xform.TransformFinalBlock(this.counter, 0, 16);
			this.XorInPlace(this._PendingWriteBlock, 0, this._pendingCount);
			this._mac.TransformFinalBlock(this._PendingWriteBlock, 0, this._pendingCount);
			this._finalBlock = true;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00012900 File Offset: 0x00010B00
		private int ReadTransformOneBlock(byte[] buffer, int offset, int last)
		{
			if (this._finalBlock)
			{
				throw new global::System.NotSupportedException();
			}
			int num = last - offset;
			int num2 = (num > 16) ? 16 : num;
			int nonce = this._nonce;
			this._nonce = nonce + 1;
			global::System.Array.Copy(global::System.BitConverter.GetBytes(nonce), 0, this.counter, 0, 4);
			if (num2 == num && this._length > 0L && this._totalBytesXferred + (long)last == this._length)
			{
				this._mac.TransformFinalBlock(buffer, offset, num2);
				this.counterOut = this._xform.TransformFinalBlock(this.counter, 0, 16);
				this._finalBlock = true;
			}
			else
			{
				this._mac.TransformBlock(buffer, offset, num2, null, 0);
				this._xform.TransformBlock(this.counter, 0, 16, this.counterOut, 0);
			}
			this.XorInPlace(buffer, offset, num2);
			return num2;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000129D8 File Offset: 0x00010BD8
		private void ReadTransformBlocks(byte[] buffer, int offset, int count)
		{
			int num = offset;
			int num2 = count + offset;
			while (num < buffer.Length && num < num2)
			{
				int num3 = this.ReadTransformOneBlock(buffer, num, num2);
				num += num3;
			}
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00012A08 File Offset: 0x00010C08
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (this._mode == global::Ionic.Zip.CryptoMode.Encrypt)
			{
				throw new global::System.NotSupportedException();
			}
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (offset < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("offset", "Must not be less than zero.");
			}
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("count", "Must not be less than zero.");
			}
			if (buffer.Length < offset + count)
			{
				throw new global::System.ArgumentException("The buffer is too small");
			}
			int count2 = count;
			if (this._totalBytesXferred >= this._length)
			{
				return 0;
			}
			long num = this._length - this._totalBytesXferred;
			if (num < (long)count)
			{
				count2 = (int)num;
			}
			int num2 = this._s.Read(buffer, offset, count2);
			this.ReadTransformBlocks(buffer, offset, count2);
			this._totalBytesXferred += (long)num2;
			return num2;
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000321 RID: 801 RVA: 0x00012ABC File Offset: 0x00010CBC
		public byte[] FinalAuthentication
		{
			get
			{
				if (!this._finalBlock)
				{
					if (this._totalBytesXferred != 0L)
					{
						throw new global::Ionic.Zip.BadStateException("The final hash has not been computed.");
					}
					byte[] buffer = new byte[0];
					this._mac.ComputeHash(buffer);
				}
				byte[] array = new byte[10];
				global::System.Array.Copy(this._mac.Hash, 0, array, 0, 10);
				return array;
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00012B18 File Offset: 0x00010D18
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this._finalBlock)
			{
				throw new global::System.InvalidOperationException("The final block has already been transformed.");
			}
			if (this._mode == global::Ionic.Zip.CryptoMode.Decrypt)
			{
				throw new global::System.NotSupportedException();
			}
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (offset < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("offset", "Must not be less than zero.");
			}
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("count", "Must not be less than zero.");
			}
			if (buffer.Length < offset + count)
			{
				throw new global::System.ArgumentException("The offset and count are too large");
			}
			if (count == 0)
			{
				return;
			}
			if (count + this._pendingCount <= 16)
			{
				global::System.Buffer.BlockCopy(buffer, offset, this._PendingWriteBlock, this._pendingCount, count);
				this._pendingCount += count;
				return;
			}
			int num = count;
			int num2 = offset;
			if (this._pendingCount != 0)
			{
				int num3 = 16 - this._pendingCount;
				if (num3 > 0)
				{
					global::System.Buffer.BlockCopy(buffer, offset, this._PendingWriteBlock, this._pendingCount, num3);
					num -= num3;
					num2 += num3;
				}
				this.WriteTransformOneBlock(this._PendingWriteBlock, 0);
				this._s.Write(this._PendingWriteBlock, 0, 16);
				this._totalBytesXferred += 16L;
				this._pendingCount = 0;
			}
			int num4 = (num - 1) / 16;
			this._pendingCount = num - num4 * 16;
			global::System.Buffer.BlockCopy(buffer, num2 + num - this._pendingCount, this._PendingWriteBlock, 0, this._pendingCount);
			num -= this._pendingCount;
			this._totalBytesXferred += (long)num;
			if (num4 > 0)
			{
				do
				{
					int num5 = this._iobuf.Length;
					if (num5 > num)
					{
						num5 = num;
					}
					global::System.Buffer.BlockCopy(buffer, num2, this._iobuf, 0, num5);
					this.WriteTransformBlocks(this._iobuf, 0, num5);
					this._s.Write(this._iobuf, 0, num5);
					num -= num5;
					num2 += num5;
				}
				while (num > 0);
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00012CD0 File Offset: 0x00010ED0
		public override void Close()
		{
			if (this._pendingCount > 0)
			{
				this.WriteTransformFinalBlock();
				this._s.Write(this._PendingWriteBlock, 0, this._pendingCount);
				this._totalBytesXferred += (long)this._pendingCount;
				this._pendingCount = 0;
			}
			this._s.Close();
			this._xform.Dispose();
			this._aesCipher.Dispose();
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00012D40 File Offset: 0x00010F40
		public override bool CanRead
		{
			get
			{
				return this._mode == global::Ionic.Zip.CryptoMode.Decrypt;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000325 RID: 805 RVA: 0x000060A5 File Offset: 0x000042A5
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00012D4E File Offset: 0x00010F4E
		public override bool CanWrite
		{
			get
			{
				return this._mode == global::Ionic.Zip.CryptoMode.Encrypt;
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00012D59 File Offset: 0x00010F59
		public override void Flush()
		{
			this._s.Flush();
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000328 RID: 808 RVA: 0x000060ED File Offset: 0x000042ED
		public override long Length
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000329 RID: 809 RVA: 0x000060ED File Offset: 0x000042ED
		// (set) Token: 0x0600032A RID: 810 RVA: 0x000060ED File Offset: 0x000042ED
		public override long Position
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x000060ED File Offset: 0x000042ED
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000060ED File Offset: 0x000042ED
		public override void SetLength(long value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00012D68 File Offset: 0x00010F68
		[global::System.Diagnostics.Conditional("Trace")]
		private void TraceOutput(string format, params object[] varParams)
		{
			object outputLock = this._outputLock;
			lock (outputLock)
			{
				int hashCode = global::System.Threading.Thread.CurrentThread.GetHashCode();
				global::System.Console.ForegroundColor = hashCode % 8 + global::System.ConsoleColor.DarkGray;
				global::System.Console.Write("{0:000} WZACS ", hashCode);
				global::System.Console.WriteLine(format, varParams);
				global::System.Console.ResetColor();
			}
		}

		// Token: 0x0400020F RID: 527
		private global::Ionic.Zip.WinZipAesCrypto _params;

		// Token: 0x04000210 RID: 528
		private global::System.IO.Stream _s;

		// Token: 0x04000211 RID: 529
		private global::Ionic.Zip.CryptoMode _mode;

		// Token: 0x04000212 RID: 530
		private int _nonce;

		// Token: 0x04000213 RID: 531
		private bool _finalBlock;

		// Token: 0x04000214 RID: 532
		internal global::System.Security.Cryptography.HMACSHA1 _mac;

		// Token: 0x04000215 RID: 533
		internal global::System.Security.Cryptography.Aes _aesCipher;

		// Token: 0x04000216 RID: 534
		internal global::System.Security.Cryptography.ICryptoTransform _xform;

		// Token: 0x04000217 RID: 535
		private const int BLOCK_SIZE_IN_BYTES = 16;

		// Token: 0x04000218 RID: 536
		private byte[] counter = new byte[16];

		// Token: 0x04000219 RID: 537
		private byte[] counterOut = new byte[16];

		// Token: 0x0400021A RID: 538
		private long _length;

		// Token: 0x0400021B RID: 539
		private long _totalBytesXferred;

		// Token: 0x0400021C RID: 540
		private byte[] _PendingWriteBlock;

		// Token: 0x0400021D RID: 541
		private int _pendingCount;

		// Token: 0x0400021E RID: 542
		private byte[] _iobuf;

		// Token: 0x0400021F RID: 543
		private object _outputLock = new object();
	}
}
