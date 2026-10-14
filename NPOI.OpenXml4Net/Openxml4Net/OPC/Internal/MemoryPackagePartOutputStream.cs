using System;
using System.IO;

namespace NPOI.OpenXml4Net.OPC.Internal
{
	// Token: 0x02000024 RID: 36
	public class MemoryPackagePartOutputStream : global::System.IO.Stream
	{
		// Token: 0x0600018D RID: 397 RVA: 0x00007E1B File Offset: 0x0000601B
		public MemoryPackagePartOutputStream(global::NPOI.OpenXml4Net.OPC.Internal.MemoryPackagePart part)
		{
			this._part = part;
			this._part.data = new global::System.IO.MemoryStream();
			this._buff = this._part.data;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002150 File Offset: 0x00000350
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00007E4B File Offset: 0x0000604B
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00007E4E File Offset: 0x0000604E
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000191 RID: 401 RVA: 0x00007E4B File Offset: 0x0000604B
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00007E51 File Offset: 0x00006051
		public override long Length
		{
			get
			{
				return this._buff.Length;
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00007E5E File Offset: 0x0000605E
		public void Write(int b)
		{
			this._buff.WriteByte((byte)b);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00007E6D File Offset: 0x0000606D
		public override void SetLength(long value)
		{
			this._buff.SetLength(value);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00007E7B File Offset: 0x0000607B
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this._buff.Seek(offset, origin);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00007E8A File Offset: 0x0000608A
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00007E97 File Offset: 0x00006097
		public override long Position
		{
			get
			{
				return this._buff.Position;
			}
			set
			{
				this._buff.Position = value;
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00007EA5 File Offset: 0x000060A5
		public override void Close()
		{
			this.Flush();
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00007EAD File Offset: 0x000060AD
		public override void Flush()
		{
			this._buff.Flush();
			this._buff.Position = 0L;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00007EC7 File Offset: 0x000060C7
		public override void Write(byte[] b, int off, int len)
		{
			this._buff.Write(b, off, len);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00007ED7 File Offset: 0x000060D7
		public void Write(byte[] b)
		{
			this._buff.Write(b, (int)this._buff.Position, b.Length);
		}

		// Token: 0x040000A9 RID: 169
		private global::NPOI.OpenXml4Net.OPC.Internal.MemoryPackagePart _part;

		// Token: 0x040000AA RID: 170
		private global::System.IO.MemoryStream _buff;
	}
}
