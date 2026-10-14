using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.IO
{
	// Token: 0x02000460 RID: 1120
	public class SignerStream : global::System.IO.Stream
	{
		// Token: 0x06002B73 RID: 11123 RVA: 0x000BA37C File Offset: 0x000B857C
		public SignerStream(global::System.IO.Stream stream, global::Org.BouncyCastle.Crypto.ISigner readSigner, global::Org.BouncyCastle.Crypto.ISigner writeSigner)
		{
			this.stream = stream;
			this.inSigner = readSigner;
			this.outSigner = writeSigner;
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x000BA399 File Offset: 0x000B8599
		public virtual global::Org.BouncyCastle.Crypto.ISigner ReadSigner()
		{
			return this.inSigner;
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x000BA3A1 File Offset: 0x000B85A1
		public virtual global::Org.BouncyCastle.Crypto.ISigner WriteSigner()
		{
			return this.outSigner;
		}

		// Token: 0x06002B76 RID: 11126 RVA: 0x000BA3AC File Offset: 0x000B85AC
		public override int Read(byte[] buffer, int offset, int count)
		{
			int i = this.stream.Read(buffer, offset, count);
			if (this.inSigner != null && i > 0)
			{
				this.inSigner.BlockUpdate(buffer, offset, i);
			}
			return i;
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x000BA3E4 File Offset: 0x000B85E4
		public override int ReadByte()
		{
			int b = this.stream.ReadByte();
			if (this.inSigner != null && b >= 0)
			{
				this.inSigner.Update((byte)b);
			}
			return b;
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x000BA417 File Offset: 0x000B8617
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this.outSigner != null && count > 0)
			{
				this.outSigner.BlockUpdate(buffer, offset, count);
			}
			this.stream.Write(buffer, offset, count);
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x000BA441 File Offset: 0x000B8641
		public override void WriteByte(byte b)
		{
			if (this.outSigner != null)
			{
				this.outSigner.Update(b);
			}
			this.stream.WriteByte(b);
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06002B7A RID: 11130 RVA: 0x000BA463 File Offset: 0x000B8663
		public override bool CanRead
		{
			get
			{
				return this.stream.CanRead;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06002B7B RID: 11131 RVA: 0x000BA470 File Offset: 0x000B8670
		public override bool CanWrite
		{
			get
			{
				return this.stream.CanWrite;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06002B7C RID: 11132 RVA: 0x000BA47D File Offset: 0x000B867D
		public override bool CanSeek
		{
			get
			{
				return this.stream.CanSeek;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06002B7D RID: 11133 RVA: 0x000BA48A File Offset: 0x000B868A
		public override long Length
		{
			get
			{
				return this.stream.Length;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06002B7E RID: 11134 RVA: 0x000BA497 File Offset: 0x000B8697
		// (set) Token: 0x06002B7F RID: 11135 RVA: 0x000BA4A4 File Offset: 0x000B86A4
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

		// Token: 0x06002B80 RID: 11136 RVA: 0x000BA4B2 File Offset: 0x000B86B2
		public override void Close()
		{
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this.stream);
			base.Close();
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x000BA4C5 File Offset: 0x000B86C5
		public override void Flush()
		{
			this.stream.Flush();
		}

		// Token: 0x06002B82 RID: 11138 RVA: 0x000BA4D2 File Offset: 0x000B86D2
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this.stream.Seek(offset, origin);
		}

		// Token: 0x06002B83 RID: 11139 RVA: 0x000BA4E1 File Offset: 0x000B86E1
		public override void SetLength(long length)
		{
			this.stream.SetLength(length);
		}

		// Token: 0x040011FC RID: 4604
		protected readonly global::System.IO.Stream stream;

		// Token: 0x040011FD RID: 4605
		protected readonly global::Org.BouncyCastle.Crypto.ISigner inSigner;

		// Token: 0x040011FE RID: 4606
		protected readonly global::Org.BouncyCastle.Crypto.ISigner outSigner;
	}
}
