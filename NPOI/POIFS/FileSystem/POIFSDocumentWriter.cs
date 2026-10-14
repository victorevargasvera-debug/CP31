using System;
using System.IO;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002F0 RID: 752
	[global::System.Obsolete]
	public class POIFSDocumentWriter : global::System.IO.Stream
	{
		// Token: 0x06001597 RID: 5527 RVA: 0x00040A0B File Offset: 0x0003EC0B
		public POIFSDocumentWriter(global::System.IO.Stream stream, int limit)
		{
			this.stream = stream;
			this.limit = limit;
			this.written = 0;
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00040A28 File Offset: 0x0003EC28
		public override void Close()
		{
			this.stream.Close();
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x00040A35 File Offset: 0x0003EC35
		public override void Flush()
		{
			this.stream.Flush();
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x00040A42 File Offset: 0x0003EC42
		private void LimitCheck(int toBeWritten)
		{
			if (this.written + toBeWritten > this.limit)
			{
				throw new global::System.IO.IOException("tried to write too much data");
			}
			this.written += toBeWritten;
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00008C75 File Offset: 0x00006E75
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x0002C43E File Offset: 0x0002A63E
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x00008C75 File Offset: 0x00006E75
		public override void SetLength(long value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x00040A6D File Offset: 0x0003EC6D
		public void Write(int b)
		{
			this.LimitCheck(1);
			this.stream.WriteByte((byte)b);
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x0002BC27 File Offset: 0x00029E27
		public void Write(byte[] b)
		{
			this.Write(b, 0, b.Length);
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x00040A83 File Offset: 0x0003EC83
		public override void Write(byte[] b, int off, int len)
		{
			this.LimitCheck(len);
			this.stream.Write(b, off, len);
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00040A9A File Offset: 0x0003EC9A
		public override void WriteByte(byte b)
		{
			this.LimitCheck(1);
			this.stream.WriteByte(b);
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00040AB0 File Offset: 0x0003ECB0
		public virtual void WriteFiller(int totalLimit, byte fill)
		{
			if (totalLimit > this.written)
			{
				byte[] array = new byte[totalLimit - this.written];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = fill;
				}
				this.stream.Write(array, 0, array.Length);
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060015A3 RID: 5539 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060015A4 RID: 5540 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060015A5 RID: 5541 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x00040AF6 File Offset: 0x0003ECF6
		public override long Length
		{
			get
			{
				return this.stream.Length;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x00040B03 File Offset: 0x0003ED03
		// (set) Token: 0x060015A8 RID: 5544 RVA: 0x00040B10 File Offset: 0x0003ED10
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

		// Token: 0x040008B0 RID: 2224
		private int limit;

		// Token: 0x040008B1 RID: 2225
		private global::System.IO.Stream stream;

		// Token: 0x040008B2 RID: 2226
		private int written;
	}
}
