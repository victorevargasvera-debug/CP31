using System;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000627 RID: 1575
	internal class IndefiniteLengthInputStream : global::Org.BouncyCastle.Asn1.LimitedInputStream
	{
		// Token: 0x06003A9C RID: 15004 RVA: 0x0010F21B File Offset: 0x0010D41B
		internal IndefiniteLengthInputStream(global::System.IO.Stream inStream, int limit) : base(inStream, limit)
		{
			this._lookAhead = this.RequireByte();
			this.CheckForEof();
		}

		// Token: 0x06003A9D RID: 15005 RVA: 0x0010F23F File Offset: 0x0010D43F
		internal void SetEofOn00(bool eofOn00)
		{
			this._eofOn00 = eofOn00;
			if (this._eofOn00)
			{
				this.CheckForEof();
			}
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x0010F257 File Offset: 0x0010D457
		private bool CheckForEof()
		{
			if (this._lookAhead != 0)
			{
				return this._lookAhead < 0;
			}
			if (this.RequireByte() != 0)
			{
				throw new global::System.IO.IOException("malformed end-of-contents marker");
			}
			this._lookAhead = -1;
			this.SetParentEofDetect(true);
			return true;
		}

		// Token: 0x06003A9F RID: 15007 RVA: 0x0010F290 File Offset: 0x0010D490
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (this._eofOn00 || count <= 1)
			{
				return base.Read(buffer, offset, count);
			}
			if (this._lookAhead < 0)
			{
				return 0;
			}
			int num = this._in.Read(buffer, offset + 1, count - 1);
			if (num <= 0)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			buffer[offset] = (byte)this._lookAhead;
			this._lookAhead = this.RequireByte();
			return num + 1;
		}

		// Token: 0x06003AA0 RID: 15008 RVA: 0x0010F2F2 File Offset: 0x0010D4F2
		public override int ReadByte()
		{
			if (this._eofOn00 && this.CheckForEof())
			{
				return -1;
			}
			int lookAhead = this._lookAhead;
			this._lookAhead = this.RequireByte();
			return lookAhead;
		}

		// Token: 0x06003AA1 RID: 15009 RVA: 0x0010F318 File Offset: 0x0010D518
		private int RequireByte()
		{
			int num = this._in.ReadByte();
			if (num < 0)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			return num;
		}

		// Token: 0x040019B3 RID: 6579
		private int _lookAhead;

		// Token: 0x040019B4 RID: 6580
		private bool _eofOn00 = true;
	}
}
