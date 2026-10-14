using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.IO
{
	// Token: 0x0200045E RID: 1118
	public class MacStream : global::System.IO.Stream
	{
		// Token: 0x06002B5E RID: 11102 RVA: 0x000BA1D0 File Offset: 0x000B83D0
		public MacStream(global::System.IO.Stream stream, global::Org.BouncyCastle.Crypto.IMac readMac, global::Org.BouncyCastle.Crypto.IMac writeMac)
		{
			this.stream = stream;
			this.inMac = readMac;
			this.outMac = writeMac;
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x000BA1ED File Offset: 0x000B83ED
		public virtual global::Org.BouncyCastle.Crypto.IMac ReadMac()
		{
			return this.inMac;
		}

		// Token: 0x06002B60 RID: 11104 RVA: 0x000BA1F5 File Offset: 0x000B83F5
		public virtual global::Org.BouncyCastle.Crypto.IMac WriteMac()
		{
			return this.outMac;
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x000BA200 File Offset: 0x000B8400
		public override int Read(byte[] buffer, int offset, int count)
		{
			int i = this.stream.Read(buffer, offset, count);
			if (this.inMac != null && i > 0)
			{
				this.inMac.BlockUpdate(buffer, offset, i);
			}
			return i;
		}

		// Token: 0x06002B62 RID: 11106 RVA: 0x000BA238 File Offset: 0x000B8438
		public override int ReadByte()
		{
			int b = this.stream.ReadByte();
			if (this.inMac != null && b >= 0)
			{
				this.inMac.Update((byte)b);
			}
			return b;
		}

		// Token: 0x06002B63 RID: 11107 RVA: 0x000BA26B File Offset: 0x000B846B
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this.outMac != null && count > 0)
			{
				this.outMac.BlockUpdate(buffer, offset, count);
			}
			this.stream.Write(buffer, offset, count);
		}

		// Token: 0x06002B64 RID: 11108 RVA: 0x000BA295 File Offset: 0x000B8495
		public override void WriteByte(byte b)
		{
			if (this.outMac != null)
			{
				this.outMac.Update(b);
			}
			this.stream.WriteByte(b);
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06002B65 RID: 11109 RVA: 0x000BA2B7 File Offset: 0x000B84B7
		public override bool CanRead
		{
			get
			{
				return this.stream.CanRead;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06002B66 RID: 11110 RVA: 0x000BA2C4 File Offset: 0x000B84C4
		public override bool CanWrite
		{
			get
			{
				return this.stream.CanWrite;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06002B67 RID: 11111 RVA: 0x000BA2D1 File Offset: 0x000B84D1
		public override bool CanSeek
		{
			get
			{
				return this.stream.CanSeek;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06002B68 RID: 11112 RVA: 0x000BA2DE File Offset: 0x000B84DE
		public override long Length
		{
			get
			{
				return this.stream.Length;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x06002B69 RID: 11113 RVA: 0x000BA2EB File Offset: 0x000B84EB
		// (set) Token: 0x06002B6A RID: 11114 RVA: 0x000BA2F8 File Offset: 0x000B84F8
		public override long Position
		{
			get
			{
				return this.stream.Position;
			}
			set
			{
				this.stream.Position = value;
			}
		}

		// Token: 0x06002B6B RID: 11115 RVA: 0x000BA306 File Offset: 0x000B8506
		public override void Close()
		{
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this.stream);
			base.Close();
		}

		// Token: 0x06002B6C RID: 11116 RVA: 0x000BA319 File Offset: 0x000B8519
		public override void Flush()
		{
			this.stream.Flush();
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x000BA326 File Offset: 0x000B8526
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this.stream.Seek(offset, origin);
		}

		// Token: 0x06002B6E RID: 11118 RVA: 0x000BA335 File Offset: 0x000B8535
		public override void SetLength(long length)
		{
			this.stream.SetLength(length);
		}

		// Token: 0x040011F8 RID: 4600
		protected readonly global::System.IO.Stream stream;

		// Token: 0x040011F9 RID: 4601
		protected readonly global::Org.BouncyCastle.Crypto.IMac inMac;

		// Token: 0x040011FA RID: 4602
		protected readonly global::Org.BouncyCastle.Crypto.IMac outMac;
	}
}
