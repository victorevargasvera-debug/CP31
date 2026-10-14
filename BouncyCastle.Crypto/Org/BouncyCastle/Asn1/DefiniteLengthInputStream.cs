using System;
using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005FF RID: 1535
	internal class DefiniteLengthInputStream : global::Org.BouncyCastle.Asn1.LimitedInputStream
	{
		// Token: 0x06003932 RID: 14642 RVA: 0x0010B87E File Offset: 0x00109A7E
		internal DefiniteLengthInputStream(global::System.IO.Stream inStream, int length, int limit) : base(inStream, limit)
		{
			if (length <= 0)
			{
				if (length < 0)
				{
					throw new global::System.ArgumentException("negative lengths not allowed", "length");
				}
				this.SetParentEofDetect(true);
			}
			this._originalLength = length;
			this._remaining = length;
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06003933 RID: 14643 RVA: 0x0010B8B5 File Offset: 0x00109AB5
		internal int Remaining
		{
			get
			{
				return this._remaining;
			}
		}

		// Token: 0x06003934 RID: 14644 RVA: 0x0010B8C0 File Offset: 0x00109AC0
		public override int ReadByte()
		{
			if (this._remaining == 0)
			{
				return -1;
			}
			int num = this._in.ReadByte();
			if (num < 0)
			{
				throw new global::System.IO.EndOfStreamException("DEF length " + this._originalLength.ToString() + " object truncated by " + this._remaining.ToString());
			}
			int num2 = this._remaining - 1;
			this._remaining = num2;
			if (num2 == 0)
			{
				this.SetParentEofDetect(true);
			}
			return num;
		}

		// Token: 0x06003935 RID: 14645 RVA: 0x0010B930 File Offset: 0x00109B30
		public override int Read(byte[] buf, int off, int len)
		{
			if (this._remaining == 0)
			{
				return 0;
			}
			int toRead = global::System.Math.Min(len, this._remaining);
			int numRead = this._in.Read(buf, off, toRead);
			if (numRead < 1)
			{
				throw new global::System.IO.EndOfStreamException("DEF length " + this._originalLength.ToString() + " object truncated by " + this._remaining.ToString());
			}
			if ((this._remaining -= numRead) == 0)
			{
				this.SetParentEofDetect(true);
			}
			return numRead;
		}

		// Token: 0x06003936 RID: 14646 RVA: 0x0010B9B0 File Offset: 0x00109BB0
		internal void ReadAllIntoByteArray(byte[] buf)
		{
			if (this._remaining != buf.Length)
			{
				throw new global::System.ArgumentException("buffer length not right for data");
			}
			if (this._remaining == 0)
			{
				return;
			}
			int limit = this.Limit;
			if (this._remaining >= limit)
			{
				throw new global::System.IO.IOException("corrupted stream - out of bounds length found: " + this._remaining.ToString() + " >= " + limit.ToString());
			}
			if ((this._remaining -= global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(this._in, buf)) != 0)
			{
				throw new global::System.IO.EndOfStreamException("DEF length " + this._originalLength.ToString() + " object truncated by " + this._remaining.ToString());
			}
			this.SetParentEofDetect(true);
		}

		// Token: 0x06003937 RID: 14647 RVA: 0x0010BA68 File Offset: 0x00109C68
		internal byte[] ToArray()
		{
			if (this._remaining == 0)
			{
				return global::Org.BouncyCastle.Asn1.DefiniteLengthInputStream.EmptyBytes;
			}
			int limit = this.Limit;
			if (this._remaining >= limit)
			{
				throw new global::System.IO.IOException("corrupted stream - out of bounds length found: " + this._remaining.ToString() + " >= " + limit.ToString());
			}
			byte[] bytes = new byte[this._remaining];
			if ((this._remaining -= global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(this._in, bytes)) != 0)
			{
				throw new global::System.IO.EndOfStreamException("DEF length " + this._originalLength.ToString() + " object truncated by " + this._remaining.ToString());
			}
			this.SetParentEofDetect(true);
			return bytes;
		}

		// Token: 0x0400197C RID: 6524
		private static readonly byte[] EmptyBytes = new byte[0];

		// Token: 0x0400197D RID: 6525
		private readonly int _originalLength;

		// Token: 0x0400197E RID: 6526
		private int _remaining;
	}
}
