using System;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x0200028A RID: 650
	public class PushbackStream : global::System.IO.Stream
	{
		// Token: 0x0600118F RID: 4495 RVA: 0x00034DFB File Offset: 0x00032FFB
		public PushbackStream(global::System.IO.Stream s)
		{
			this.s = s;
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x00034E11 File Offset: 0x00033011
		protected override void Dispose(bool disposing)
		{
			this.s = null;
			base.Dispose(disposing);
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00034E21 File Offset: 0x00033021
		public override int ReadByte()
		{
			if (this.buf != -1)
			{
				int result = this.buf;
				this.buf = -1;
				return result;
			}
			return this.s.ReadByte();
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x00034E45 File Offset: 0x00033045
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (this.buf != -1 && count > 0)
			{
				buffer[offset] = (byte)this.buf;
				this.buf = -1;
				return 1;
			}
			return this.s.Read(buffer, offset, count);
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x00034E75 File Offset: 0x00033075
		public virtual void Unread(int b)
		{
			if (this.buf != -1)
			{
				throw new global::System.InvalidOperationException("Can only push back one byte");
			}
			this.buf = (b & 255);
			this.s.Position -= (long)b;
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x00034EAC File Offset: 0x000330AC
		public override bool CanRead
		{
			get
			{
				return this.s.CanRead;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x00034EB9 File Offset: 0x000330B9
		public override bool CanSeek
		{
			get
			{
				return this.s.CanSeek;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x00034EC6 File Offset: 0x000330C6
		public override bool CanWrite
		{
			get
			{
				return this.s.CanWrite;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x00034ED3 File Offset: 0x000330D3
		public override long Length
		{
			get
			{
				return this.s.Length;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x00034EE0 File Offset: 0x000330E0
		// (set) Token: 0x06001199 RID: 4505 RVA: 0x00034EED File Offset: 0x000330ED
		public override long Position
		{
			get
			{
				return this.s.Position;
			}
			set
			{
				this.s.Position = value;
			}
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x00034EFB File Offset: 0x000330FB
		public override void Close()
		{
			this.s.Close();
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00034F08 File Offset: 0x00033108
		public override void Flush()
		{
			this.s.Flush();
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x00034F15 File Offset: 0x00033115
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this.s.Seek(offset, origin);
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x00034F24 File Offset: 0x00033124
		public override void SetLength(long value)
		{
			this.s.SetLength(value);
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x00034F32 File Offset: 0x00033132
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.s.Write(buffer, offset, count);
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00034F42 File Offset: 0x00033142
		public override void WriteByte(byte value)
		{
			this.s.WriteByte(value);
		}

		// Token: 0x04000763 RID: 1891
		private int buf = -1;

		// Token: 0x04000764 RID: 1892
		private global::System.IO.Stream s;
	}
}
