using System;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x02000266 RID: 614
	public class FilterInputStream : global::NPOI.Util.InputStream
	{
		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000FF1 RID: 4081 RVA: 0x00008C75 File Offset: 0x00006E75
		public override bool CanRead
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x00008C75 File Offset: 0x00006E75
		public override bool CanSeek
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x00008C75 File Offset: 0x00006E75
		public override bool CanWrite
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x00008C75 File Offset: 0x00006E75
		public override long Length
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000FF5 RID: 4085 RVA: 0x00031415 File Offset: 0x0002F615
		// (set) Token: 0x06000FF6 RID: 4086 RVA: 0x0003141D File Offset: 0x0002F61D
		public override long Position { get; set; }

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00031426 File Offset: 0x0002F626
		protected FilterInputStream(global::NPOI.Util.InputStream input)
		{
			this.input = input;
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00031437 File Offset: 0x0002F637
		public override int Read()
		{
			return this.input.Read();
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0002B8CF File Offset: 0x00029ACF
		public override int Read(byte[] b)
		{
			return this.Read(b, 0, b.Length);
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00031446 File Offset: 0x0002F646
		public override int Read(byte[] b, int off, int len)
		{
			return this.input.Read(b, off, len);
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00031458 File Offset: 0x0002F658
		public override long Skip(long n)
		{
			return this.input.Skip(n);
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00031468 File Offset: 0x0002F668
		public int available()
		{
			return this.input.Available();
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00031477 File Offset: 0x0002F677
		public override void Close()
		{
			this.input.Close();
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00031486 File Offset: 0x0002F686
		public override void Mark(int readlimit)
		{
			this.input.Mark(readlimit);
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00031496 File Offset: 0x0002F696
		public override void Reset()
		{
			this.input.Reset();
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x000314A5 File Offset: 0x0002F6A5
		public override bool MarkSupported()
		{
			return this.input.MarkSupported();
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00008C75 File Offset: 0x00006E75
		public override void Flush()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x00008C75 File Offset: 0x00006E75
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00008C75 File Offset: 0x00006E75
		public override void SetLength(long value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00008C75 File Offset: 0x00006E75
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000722 RID: 1826
		protected volatile global::NPOI.Util.InputStream input;
	}
}
