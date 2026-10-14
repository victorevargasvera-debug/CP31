using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

namespace Ionic.Zip
{
	// Token: 0x02000461 RID: 1121
	internal class WinZipAesCipherStream : global::System.IO.Stream
	{
		// Token: 0x06003040 RID: 12352 RVA: 0x000AAD30 File Offset: 0x000A8F30
		internal WinZipAesCipherStream(global::System.IO.Stream s, global::Ionic.Zip.WinZipAesCrypto cryptoParams, long length, global::Ionic.Zip.CryptoMode mode) : this(s, cryptoParams, mode)
		{
			this._length = length;
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x000AAD44 File Offset: 0x000A8F44
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
			this._aesCipher = new global::System.Security.Cryptography.RijndaelManaged();
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

		// Token: 0x06003042 RID: 12354 RVA: 0x000AAE98 File Offset: 0x000A9098
		private void XorInPlace(byte[] buffer, int offset, int count)
		{
			for (int i = 0; i < count; i++)
			{
				buffer[offset + i] = (this.counterOut[i] ^ buffer[offset + i]);
			}
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x000AAECC File Offset: 0x000A90CC
		private void WriteTransformOneBlock(byte[] buffer, int offset)
		{
			int nonce = this._nonce;
			this._nonce = nonce + 1;
			global::System.Array.Copy(global::System.BitConverter.GetBytes(nonce), 0, this.counter, 0, 4);
			this._xform.TransformBlock(this.counter, 0, 16, this.counterOut, 0);
			this.XorInPlace(buffer, offset, 16);
			this._mac.TransformBlock(buffer, offset, 16, null, 0);
		}

		// Token: 0x06003044 RID: 12356 RVA: 0x000AAF3C File Offset: 0x000A913C
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

		// Token: 0x06003045 RID: 12357 RVA: 0x000AAF74 File Offset: 0x000A9174
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

		// Token: 0x06003046 RID: 12358 RVA: 0x000AB024 File Offset: 0x000A9224
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

		// Token: 0x06003047 RID: 12359 RVA: 0x000AB114 File Offset: 0x000A9314
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

		// Token: 0x06003048 RID: 12360 RVA: 0x000AB14C File Offset: 0x000A934C
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

		// Token: 0x17000DD3 RID: 3539
		// (get) Token: 0x06003049 RID: 12361 RVA: 0x000AB21C File Offset: 0x000A941C
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

		// Token: 0x0600304A RID: 12362 RVA: 0x000AB280 File Offset: 0x000A9480
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

		// Token: 0x0600304B RID: 12363 RVA: 0x000AB460 File Offset: 0x000A9660
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
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x0600304C RID: 12364 RVA: 0x000AB4C4 File Offset: 0x000A96C4
		public override bool CanRead
		{
			get
			{
				return this._mode == global::Ionic.Zip.CryptoMode.Decrypt;
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x0600304D RID: 12365 RVA: 0x000AB4D8 File Offset: 0x000A96D8
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x0600304E RID: 12366 RVA: 0x000AB4DC File Offset: 0x000A96DC
		public override bool CanWrite
		{
			get
			{
				return this._mode == global::Ionic.Zip.CryptoMode.Encrypt;
			}
		}

		// Token: 0x0600304F RID: 12367 RVA: 0x000AB4E8 File Offset: 0x000A96E8
		public override void Flush()
		{
			this._s.Flush();
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x06003050 RID: 12368 RVA: 0x000AB4F8 File Offset: 0x000A96F8
		public override long Length
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x06003051 RID: 12369 RVA: 0x000AB500 File Offset: 0x000A9700
		// (set) Token: 0x06003052 RID: 12370 RVA: 0x000AB508 File Offset: 0x000A9708
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

		// Token: 0x06003053 RID: 12371 RVA: 0x000AB510 File Offset: 0x000A9710
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06003054 RID: 12372 RVA: 0x000AB518 File Offset: 0x000A9718
		public override void SetLength(long value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06003055 RID: 12373 RVA: 0x000AB520 File Offset: 0x000A9720
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

		// Token: 0x04001195 RID: 4501
		private global::Ionic.Zip.WinZipAesCrypto _params;

		// Token: 0x04001196 RID: 4502
		private global::System.IO.Stream _s;

		// Token: 0x04001197 RID: 4503
		private global::Ionic.Zip.CryptoMode _mode;

		// Token: 0x04001198 RID: 4504
		private int _nonce;

		// Token: 0x04001199 RID: 4505
		private bool _finalBlock;

		// Token: 0x0400119A RID: 4506
		internal global::System.Security.Cryptography.HMACSHA1 _mac;

		// Token: 0x0400119B RID: 4507
		internal global::System.Security.Cryptography.RijndaelManaged _aesCipher;

		// Token: 0x0400119C RID: 4508
		internal global::System.Security.Cryptography.ICryptoTransform _xform;

		// Token: 0x0400119D RID: 4509
		private const int BLOCK_SIZE_IN_BYTES = 16;

		// Token: 0x0400119E RID: 4510
		private byte[] counter = new byte[16];

		// Token: 0x0400119F RID: 4511
		private byte[] counterOut = new byte[16];

		// Token: 0x040011A0 RID: 4512
		private long _length;

		// Token: 0x040011A1 RID: 4513
		private long _totalBytesXferred;

		// Token: 0x040011A2 RID: 4514
		private byte[] _PendingWriteBlock;

		// Token: 0x040011A3 RID: 4515
		private int _pendingCount;

		// Token: 0x040011A4 RID: 4516
		private byte[] _iobuf;

		// Token: 0x040011A5 RID: 4517
		private object _outputLock = new object();
	}
}
