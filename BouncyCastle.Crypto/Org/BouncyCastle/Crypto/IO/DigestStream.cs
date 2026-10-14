using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.IO
{
	// Token: 0x0200045C RID: 1116
	public class DigestStream : global::System.IO.Stream
	{
		// Token: 0x06002B49 RID: 11081 RVA: 0x000BA025 File Offset: 0x000B8225
		public DigestStream(global::System.IO.Stream stream, global::Org.BouncyCastle.Crypto.IDigest readDigest, global::Org.BouncyCastle.Crypto.IDigest writeDigest)
		{
			this.stream = stream;
			this.inDigest = readDigest;
			this.outDigest = writeDigest;
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x000BA042 File Offset: 0x000B8242
		public virtual global::Org.BouncyCastle.Crypto.IDigest ReadDigest()
		{
			return this.inDigest;
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x000BA04A File Offset: 0x000B824A
		public virtual global::Org.BouncyCastle.Crypto.IDigest WriteDigest()
		{
			return this.outDigest;
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x000BA054 File Offset: 0x000B8254
		public override int Read(byte[] buffer, int offset, int count)
		{
			int i = this.stream.Read(buffer, offset, count);
			if (this.inDigest != null && i > 0)
			{
				this.inDigest.BlockUpdate(buffer, offset, i);
			}
			return i;
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x000BA08C File Offset: 0x000B828C
		public override int ReadByte()
		{
			int b = this.stream.ReadByte();
			if (this.inDigest != null && b >= 0)
			{
				this.inDigest.Update((byte)b);
			}
			return b;
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x000BA0BF File Offset: 0x000B82BF
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this.outDigest != null && count > 0)
			{
				this.outDigest.BlockUpdate(buffer, offset, count);
			}
			this.stream.Write(buffer, offset, count);
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x000BA0E9 File Offset: 0x000B82E9
		public override void WriteByte(byte b)
		{
			if (this.outDigest != null)
			{
				this.outDigest.Update(b);
			}
			this.stream.WriteByte(b);
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06002B50 RID: 11088 RVA: 0x000BA10B File Offset: 0x000B830B
		public override bool CanRead
		{
			get
			{
				return this.stream.CanRead;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06002B51 RID: 11089 RVA: 0x000BA118 File Offset: 0x000B8318
		public override bool CanWrite
		{
			get
			{
				return this.stream.CanWrite;
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06002B52 RID: 11090 RVA: 0x000BA125 File Offset: 0x000B8325
		public override bool CanSeek
		{
			get
			{
				return this.stream.CanSeek;
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06002B53 RID: 11091 RVA: 0x000BA132 File Offset: 0x000B8332
		public override long Length
		{
			get
			{
				return this.stream.Length;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06002B54 RID: 11092 RVA: 0x000BA13F File Offset: 0x000B833F
		// (set) Token: 0x06002B55 RID: 11093 RVA: 0x000BA14C File Offset: 0x000B834C
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

		// Token: 0x06002B56 RID: 11094 RVA: 0x000BA15A File Offset: 0x000B835A
		public override void Close()
		{
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this.stream);
			base.Close();
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x000BA16D File Offset: 0x000B836D
		public override void Flush()
		{
			this.stream.Flush();
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x000BA17A File Offset: 0x000B837A
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this.stream.Seek(offset, origin);
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x000BA189 File Offset: 0x000B8389
		public override void SetLength(long length)
		{
			this.stream.SetLength(length);
		}

		// Token: 0x040011F4 RID: 4596
		protected readonly global::System.IO.Stream stream;

		// Token: 0x040011F5 RID: 4597
		protected readonly global::Org.BouncyCastle.Crypto.IDigest inDigest;

		// Token: 0x040011F6 RID: 4598
		protected readonly global::Org.BouncyCastle.Crypto.IDigest outDigest;
	}
}
