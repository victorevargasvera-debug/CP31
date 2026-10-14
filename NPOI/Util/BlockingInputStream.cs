using System;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x02000256 RID: 598
	public class BlockingInputStream : global::System.IO.Stream
	{
		// Token: 0x06000E9D RID: 3741 RVA: 0x0002B778 File Offset: 0x00029978
		public BlockingInputStream(global::System.IO.Stream stream)
		{
			this.stream = stream;
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0002B787 File Offset: 0x00029987
		public int Available()
		{
			return (int)(this.stream.Length - this.stream.Position);
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x0002B7A1 File Offset: 0x000299A1
		public void close()
		{
			this.stream.Close();
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00008C75 File Offset: 0x00006E75
		public void Mark(int readLimit)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00006EB4 File Offset: 0x000050B4
		public bool MarkSupported()
		{
			return false;
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x0002B7AE File Offset: 0x000299AE
		public int Read()
		{
			return this.stream.ReadByte();
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0002B7BC File Offset: 0x000299BC
		public int Read(byte[] bf)
		{
			int i = 0;
			int num = 4611;
			while (i < bf.Length)
			{
				num = this.stream.ReadByte();
				if (num == -1)
				{
					break;
				}
				bf[i++] = (byte)num;
			}
			if (i == 0 && num == -1)
			{
				return -1;
			}
			return i;
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x0002B7FC File Offset: 0x000299FC
		public override int Read(byte[] bf, int s, int l)
		{
			return this.stream.Read(bf, s, l);
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x0002B80C File Offset: 0x00029A0C
		public void Reset()
		{
			this.stream.Seek(0L, global::System.IO.SeekOrigin.Begin);
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x0002B81D File Offset: 0x00029A1D
		public long Skip(long n)
		{
			return this.stream.Seek(n, global::System.IO.SeekOrigin.Begin);
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000EA7 RID: 3751 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool CanSeek
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000EA9 RID: 3753 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void Flush()
		{
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x0002B82C File Offset: 0x00029A2C
		public override long Length
		{
			get
			{
				return this.stream.Length;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000EAC RID: 3756 RVA: 0x0002B839 File Offset: 0x00029A39
		// (set) Token: 0x06000EAD RID: 3757 RVA: 0x0002B846 File Offset: 0x00029A46
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

		// Token: 0x06000EAE RID: 3758 RVA: 0x0002B854 File Offset: 0x00029A54
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this.stream.Seek(offset, origin);
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x0002B863 File Offset: 0x00029A63
		public override void SetLength(long value)
		{
			this.stream.SetLength(value);
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00008C75 File Offset: 0x00006E75
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x040006AA RID: 1706
		protected global::System.IO.Stream stream;
	}
}
