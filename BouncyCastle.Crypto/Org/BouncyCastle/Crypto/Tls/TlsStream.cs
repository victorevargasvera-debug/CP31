using System;
using System.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000390 RID: 912
	internal class TlsStream : global::System.IO.Stream
	{
		// Token: 0x060024EB RID: 9451 RVA: 0x000A0307 File Offset: 0x0009E507
		internal TlsStream(global::Org.BouncyCastle.Crypto.Tls.TlsProtocol handler)
		{
			this.handler = handler;
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x000A0316 File Offset: 0x0009E516
		public override bool CanRead
		{
			get
			{
				return !this.handler.IsClosed;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x060024ED RID: 9453 RVA: 0x000A0326 File Offset: 0x0009E526
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060024EE RID: 9454 RVA: 0x000A0329 File Offset: 0x0009E529
		public override bool CanWrite
		{
			get
			{
				return !this.handler.IsClosed;
			}
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x000A0339 File Offset: 0x0009E539
		public override void Close()
		{
			this.handler.Close();
			base.Close();
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x000A034C File Offset: 0x0009E54C
		public override void Flush()
		{
			this.handler.Flush();
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060024F1 RID: 9457 RVA: 0x000A0359 File Offset: 0x0009E559
		public override long Length
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060024F2 RID: 9458 RVA: 0x000A0360 File Offset: 0x0009E560
		// (set) Token: 0x060024F3 RID: 9459 RVA: 0x000A0367 File Offset: 0x0009E567
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

		// Token: 0x060024F4 RID: 9460 RVA: 0x000A036E File Offset: 0x0009E56E
		public override int Read(byte[] buf, int off, int len)
		{
			return this.handler.ReadApplicationData(buf, off, len);
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x000A0380 File Offset: 0x0009E580
		public override int ReadByte()
		{
			byte[] buf = new byte[1];
			if (this.Read(buf, 0, 1) <= 0)
			{
				return -1;
			}
			return (int)buf[0];
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x000A03A5 File Offset: 0x0009E5A5
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x000A03AC File Offset: 0x0009E5AC
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x000A03B3 File Offset: 0x0009E5B3
		public override void Write(byte[] buf, int off, int len)
		{
			this.handler.WriteData(buf, off, len);
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x000A03C3 File Offset: 0x0009E5C3
		public override void WriteByte(byte b)
		{
			this.handler.WriteData(new byte[]
			{
				b
			}, 0, 1);
		}

		// Token: 0x04000ED6 RID: 3798
		private readonly global::Org.BouncyCastle.Crypto.Tls.TlsProtocol handler;
	}
}
