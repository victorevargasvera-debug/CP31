using System;
using System.IO;
using System.Security.Cryptography;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	// Token: 0x0200003E RID: 62
	public class InflaterInputBuffer
	{
		// Token: 0x06000297 RID: 663 RVA: 0x0000DC1B File Offset: 0x0000BE1B
		public InflaterInputBuffer(global::System.IO.Stream stream) : this(stream, 4096)
		{
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000DC29 File Offset: 0x0000BE29
		public InflaterInputBuffer(global::System.IO.Stream stream, int bufferSize)
		{
			this.inputStream = stream;
			if (bufferSize < 1024)
			{
				bufferSize = 1024;
			}
			this.rawData = new byte[bufferSize];
			this.clearText = this.rawData;
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0000DC5F File Offset: 0x0000BE5F
		public int RawLength
		{
			get
			{
				return this.rawLength;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600029A RID: 666 RVA: 0x0000DC67 File Offset: 0x0000BE67
		public byte[] RawData
		{
			get
			{
				return this.rawData;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0000DC6F File Offset: 0x0000BE6F
		public int ClearTextLength
		{
			get
			{
				return this.clearTextLength;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000DC77 File Offset: 0x0000BE77
		public byte[] ClearText
		{
			get
			{
				return this.clearText;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0000DC7F File Offset: 0x0000BE7F
		// (set) Token: 0x0600029E RID: 670 RVA: 0x0000DC87 File Offset: 0x0000BE87
		public int Available
		{
			get
			{
				return this.available;
			}
			set
			{
				this.available = value;
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000DC90 File Offset: 0x0000BE90
		public void SetInflaterInput(global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater inflater)
		{
			if (this.available > 0)
			{
				inflater.SetInput(this.clearText, this.clearTextLength - this.available, this.available);
				this.available = 0;
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000DCC4 File Offset: 0x0000BEC4
		public void Fill()
		{
			this.rawLength = 0;
			int num = this.rawData.Length;
			while (num > 0 && this.inputStream.CanRead)
			{
				int num2 = this.inputStream.Read(this.rawData, this.rawLength, num);
				if (num2 <= 0)
				{
					break;
				}
				this.rawLength += num2;
				num -= num2;
			}
			if (this.cryptoTransform != null)
			{
				this.clearTextLength = this.cryptoTransform.TransformBlock(this.rawData, 0, this.rawLength, this.clearText, 0);
			}
			else
			{
				this.clearTextLength = this.rawLength;
			}
			this.available = this.clearTextLength;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000DD6A File Offset: 0x0000BF6A
		public int ReadRawBuffer(byte[] buffer)
		{
			return this.ReadRawBuffer(buffer, 0, buffer.Length);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000DD78 File Offset: 0x0000BF78
		public int ReadRawBuffer(byte[] outBuffer, int offset, int length)
		{
			if (length < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("length");
			}
			int num = offset;
			int i = length;
			while (i > 0)
			{
				if (this.available <= 0)
				{
					this.Fill();
					if (this.available <= 0)
					{
						return 0;
					}
				}
				int num2 = global::System.Math.Min(i, this.available);
				global::System.Array.Copy(this.rawData, this.rawLength - this.available, outBuffer, num, num2);
				num += num2;
				i -= num2;
				this.available -= num2;
			}
			return length;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000DDF8 File Offset: 0x0000BFF8
		public int ReadClearTextBuffer(byte[] outBuffer, int offset, int length)
		{
			if (length < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("length");
			}
			int num = offset;
			int i = length;
			while (i > 0)
			{
				if (this.available <= 0)
				{
					this.Fill();
					if (this.available <= 0)
					{
						return 0;
					}
				}
				int num2 = global::System.Math.Min(i, this.available);
				global::System.Array.Copy(this.clearText, this.clearTextLength - this.available, outBuffer, num, num2);
				num += num2;
				i -= num2;
				this.available -= num2;
			}
			return length;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000DE78 File Offset: 0x0000C078
		public byte ReadLeByte()
		{
			if (this.available <= 0)
			{
				this.Fill();
				if (this.available <= 0)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("EOF in header");
				}
			}
			byte result = this.rawData[this.rawLength - this.available];
			this.available--;
			return result;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000DECA File Offset: 0x0000C0CA
		public int ReadLeShort()
		{
			return (int)this.ReadLeByte() | (int)this.ReadLeByte() << 8;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000DEDB File Offset: 0x0000C0DB
		public int ReadLeInt()
		{
			return this.ReadLeShort() | this.ReadLeShort() << 16;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000DEED File Offset: 0x0000C0ED
		public long ReadLeLong()
		{
			return (long)((ulong)this.ReadLeInt() | (ulong)((ulong)((long)this.ReadLeInt()) << 32));
		}

		// Token: 0x1700009B RID: 155
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x0000DF04 File Offset: 0x0000C104
		public global::System.Security.Cryptography.ICryptoTransform CryptoTransform
		{
			set
			{
				this.cryptoTransform = value;
				if (this.cryptoTransform != null)
				{
					if (this.rawData == this.clearText)
					{
						if (this.internalClearText == null)
						{
							this.internalClearText = new byte[this.rawData.Length];
						}
						this.clearText = this.internalClearText;
					}
					this.clearTextLength = this.rawLength;
					if (this.available > 0)
					{
						this.cryptoTransform.TransformBlock(this.rawData, this.rawLength - this.available, this.available, this.clearText, this.rawLength - this.available);
						return;
					}
				}
				else
				{
					this.clearText = this.rawData;
					this.clearTextLength = this.rawLength;
				}
			}
		}

		// Token: 0x040001AF RID: 431
		private int rawLength;

		// Token: 0x040001B0 RID: 432
		private byte[] rawData;

		// Token: 0x040001B1 RID: 433
		private int clearTextLength;

		// Token: 0x040001B2 RID: 434
		private byte[] clearText;

		// Token: 0x040001B3 RID: 435
		private byte[] internalClearText;

		// Token: 0x040001B4 RID: 436
		private int available;

		// Token: 0x040001B5 RID: 437
		private global::System.Security.Cryptography.ICryptoTransform cryptoTransform;

		// Token: 0x040001B6 RID: 438
		private global::System.IO.Stream inputStream;
	}
}
