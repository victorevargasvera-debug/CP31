using System;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x0200025C RID: 604
	internal class CloseIgnoringInputStream : global::System.IO.Stream
	{
		// Token: 0x06000F07 RID: 3847 RVA: 0x0002C412 File Offset: 0x0002A612
		public CloseIgnoringInputStream(global::System.IO.Stream stream)
		{
			this._is = stream;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x0002C421 File Offset: 0x0002A621
		public int Read()
		{
			return this._is.ReadByte();
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x0002C42E File Offset: 0x0002A62E
		public override int Read(byte[] b, int off, int len)
		{
			return this._is.Read(b, off, len);
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void Close()
		{
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void Flush()
		{
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x0002C43E File Offset: 0x0002A63E
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void SetLength(long value)
		{
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000F0F RID: 3855 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool CanSeek
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000F10 RID: 3856 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000F11 RID: 3857 RVA: 0x0002C442 File Offset: 0x0002A642
		public override long Length
		{
			get
			{
				return this._is.Length;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x0002C44F File Offset: 0x0002A64F
		// (set) Token: 0x06000F13 RID: 3859 RVA: 0x0002C45C File Offset: 0x0002A65C
		public override long Position
		{
			get
			{
				return this._is.Position;
			}
			set
			{
				this._is.Position = value;
			}
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		// Token: 0x040006C5 RID: 1733
		private global::System.IO.Stream _is;
	}
}
