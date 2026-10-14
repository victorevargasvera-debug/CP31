using System;
using System.IO;
using System.Security.Cryptography;
using ICSharpCode.SharpZipLib.Encryption;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	// Token: 0x0200003D RID: 61
	public class DeflaterOutputStream : global::System.IO.Stream
	{
		// Token: 0x0600027E RID: 638 RVA: 0x0000D89F File Offset: 0x0000BA9F
		public DeflaterOutputStream(global::System.IO.Stream baseOutputStream) : this(baseOutputStream, new global::ICSharpCode.SharpZipLib.Zip.Compression.Deflater(), 512)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000D8B2 File Offset: 0x0000BAB2
		public DeflaterOutputStream(global::System.IO.Stream baseOutputStream, global::ICSharpCode.SharpZipLib.Zip.Compression.Deflater deflater) : this(baseOutputStream, deflater, 512)
		{
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000D8C4 File Offset: 0x0000BAC4
		public DeflaterOutputStream(global::System.IO.Stream baseOutputStream, global::ICSharpCode.SharpZipLib.Zip.Compression.Deflater deflater, int bufferSize)
		{
			if (baseOutputStream == null)
			{
				throw new global::System.ArgumentNullException("baseOutputStream");
			}
			if (!baseOutputStream.CanWrite)
			{
				throw new global::System.ArgumentException("Must support writing", "baseOutputStream");
			}
			if (bufferSize < 512)
			{
				throw new global::System.ArgumentOutOfRangeException("bufferSize");
			}
			this.baseOutputStream_ = baseOutputStream;
			this.buffer_ = new byte[bufferSize];
			if (deflater == null)
			{
				throw new global::System.ArgumentNullException("deflater");
			}
			this.deflater_ = deflater;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000D940 File Offset: 0x0000BB40
		public virtual void Finish()
		{
			this.deflater_.Finish();
			while (!this.deflater_.IsFinished)
			{
				int num = this.deflater_.Deflate(this.buffer_, 0, this.buffer_.Length);
				if (num <= 0)
				{
					break;
				}
				if (this.cryptoTransform_ != null)
				{
					this.EncryptBlock(this.buffer_, 0, num);
				}
				this.baseOutputStream_.Write(this.buffer_, 0, num);
			}
			if (!this.deflater_.IsFinished)
			{
				throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Can't deflate all input?");
			}
			this.baseOutputStream_.Flush();
			if (this.cryptoTransform_ != null)
			{
				if (this.cryptoTransform_ is global::ICSharpCode.SharpZipLib.Encryption.ZipAESTransform)
				{
					this.AESAuthCode = ((global::ICSharpCode.SharpZipLib.Encryption.ZipAESTransform)this.cryptoTransform_).GetAuthCode();
				}
				this.cryptoTransform_.Dispose();
				this.cryptoTransform_ = null;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0000DA0F File Offset: 0x0000BC0F
		// (set) Token: 0x06000283 RID: 643 RVA: 0x0000DA17 File Offset: 0x0000BC17
		public bool IsStreamOwner { get; set; } = true;

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0000DA20 File Offset: 0x0000BC20
		public bool CanPatchEntries
		{
			get
			{
				return this.baseOutputStream_.CanSeek;
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000DA2D File Offset: 0x0000BC2D
		protected void EncryptBlock(byte[] buffer, int offset, int length)
		{
			this.cryptoTransform_.TransformBlock(buffer, 0, length, buffer, 0);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000DA40 File Offset: 0x0000BC40
		protected void Deflate()
		{
			this.Deflate(false);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000DA4C File Offset: 0x0000BC4C
		private void Deflate(bool flushing)
		{
			while (flushing || !this.deflater_.IsNeedingInput)
			{
				int num = this.deflater_.Deflate(this.buffer_, 0, this.buffer_.Length);
				if (num <= 0)
				{
					break;
				}
				if (this.cryptoTransform_ != null)
				{
					this.EncryptBlock(this.buffer_, 0, num);
				}
				this.baseOutputStream_.Write(this.buffer_, 0, num);
			}
			if (!this.deflater_.IsNeedingInput)
			{
				throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("DeflaterOutputStream can't deflate all input?");
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0000DACB File Offset: 0x0000BCCB
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0000DACE File Offset: 0x0000BCCE
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0000DAD1 File Offset: 0x0000BCD1
		public override bool CanWrite
		{
			get
			{
				return this.baseOutputStream_.CanWrite;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0000DADE File Offset: 0x0000BCDE
		public override long Length
		{
			get
			{
				return this.baseOutputStream_.Length;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000DAEB File Offset: 0x0000BCEB
		// (set) Token: 0x0600028D RID: 653 RVA: 0x0000DAF8 File Offset: 0x0000BCF8
		public override long Position
		{
			get
			{
				return this.baseOutputStream_.Position;
			}
			set
			{
				throw new global::System.NotSupportedException("Position property not supported");
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000DB04 File Offset: 0x0000BD04
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException("DeflaterOutputStream Seek not supported");
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000DB10 File Offset: 0x0000BD10
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException("DeflaterOutputStream SetLength not supported");
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000DB1C File Offset: 0x0000BD1C
		public override int ReadByte()
		{
			throw new global::System.NotSupportedException("DeflaterOutputStream ReadByte not supported");
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000DB28 File Offset: 0x0000BD28
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException("DeflaterOutputStream Read not supported");
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000DB34 File Offset: 0x0000BD34
		public override void Flush()
		{
			this.deflater_.Flush();
			this.Deflate(true);
			this.baseOutputStream_.Flush();
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000DB54 File Offset: 0x0000BD54
		protected override void Dispose(bool disposing)
		{
			if (!this.isClosed_)
			{
				this.isClosed_ = true;
				try
				{
					this.Finish();
					if (this.cryptoTransform_ != null)
					{
						this.GetAuthCodeIfAES();
						this.cryptoTransform_.Dispose();
						this.cryptoTransform_ = null;
					}
				}
				finally
				{
					if (this.IsStreamOwner)
					{
						this.baseOutputStream_.Dispose();
					}
				}
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000DBBC File Offset: 0x0000BDBC
		protected void GetAuthCodeIfAES()
		{
			if (this.cryptoTransform_ is global::ICSharpCode.SharpZipLib.Encryption.ZipAESTransform)
			{
				this.AESAuthCode = ((global::ICSharpCode.SharpZipLib.Encryption.ZipAESTransform)this.cryptoTransform_).GetAuthCode();
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000DBE4 File Offset: 0x0000BDE4
		public override void WriteByte(byte value)
		{
			this.Write(new byte[]
			{
				value
			}, 0, 1);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000DC05 File Offset: 0x0000BE05
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.deflater_.SetInput(buffer, offset, count);
			this.Deflate();
		}

		// Token: 0x040001A9 RID: 425
		protected global::System.Security.Cryptography.ICryptoTransform cryptoTransform_;

		// Token: 0x040001AA RID: 426
		protected byte[] AESAuthCode;

		// Token: 0x040001AB RID: 427
		private byte[] buffer_;

		// Token: 0x040001AC RID: 428
		protected global::ICSharpCode.SharpZipLib.Zip.Compression.Deflater deflater_;

		// Token: 0x040001AD RID: 429
		protected global::System.IO.Stream baseOutputStream_;

		// Token: 0x040001AE RID: 430
		private bool isClosed_;
	}
}
