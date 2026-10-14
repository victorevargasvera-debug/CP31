using System;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x02000267 RID: 615
	public class FilterOutputStream : global::NPOI.Util.OutputStream
	{
		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001005 RID: 4101 RVA: 0x00008C75 File Offset: 0x00006E75
		public override bool CanRead
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001006 RID: 4102 RVA: 0x00008C75 File Offset: 0x00006E75
		public override bool CanSeek
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06001007 RID: 4103 RVA: 0x00008C75 File Offset: 0x00006E75
		public override bool CanWrite
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001008 RID: 4104 RVA: 0x00008C75 File Offset: 0x00006E75
		public override long Length
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x000314B4 File Offset: 0x0002F6B4
		// (set) Token: 0x0600100A RID: 4106 RVA: 0x000314BC File Offset: 0x0002F6BC
		public override long Position { get; set; }

		// Token: 0x0600100B RID: 4107 RVA: 0x000314C5 File Offset: 0x0002F6C5
		public FilterOutputStream(global::NPOI.Util.OutputStream output)
		{
			this.output = output;
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x000314D4 File Offset: 0x0002F6D4
		public override void Write(int b)
		{
			this.output.Write(b);
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0002BC27 File Offset: 0x00029E27
		public override void Write(byte[] b)
		{
			this.Write(b, 0, b.Length);
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x000314E4 File Offset: 0x0002F6E4
		public override void Write(byte[] b, int off, int len)
		{
			if ((off | len | b.Length - (len + off) | off + len) < 0)
			{
				throw new global::System.IndexOutOfRangeException();
			}
			for (int i = 0; i < len; i++)
			{
				this.Write((int)b[off + i]);
			}
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00031520 File Offset: 0x0002F720
		public override void Flush()
		{
			this.output.Flush();
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x0003152D File Offset: 0x0002F72D
		public override void Close()
		{
			this.Flush();
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00008C75 File Offset: 0x00006E75
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x00008C75 File Offset: 0x00006E75
		public override void SetLength(long value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x00008C75 File Offset: 0x00006E75
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000724 RID: 1828
		protected global::NPOI.Util.OutputStream output;
	}
}
