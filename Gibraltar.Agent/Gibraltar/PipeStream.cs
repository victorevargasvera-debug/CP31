using System;
using System.IO;

namespace Gibraltar
{
	// Token: 0x020000B7 RID: 183
	internal class PipeStream : global::System.IO.MemoryStream
	{
		// Token: 0x060007C2 RID: 1986 RVA: 0x0000F580 File Offset: 0x0000D780
		public PipeStream()
		{
			this.m_InitialCapacity = 0;
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0000F59C File Offset: 0x0000D79C
		public PipeStream(int capacity) : base(capacity)
		{
			this.m_InitialCapacity = capacity;
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x0000F5B8 File Offset: 0x0000D7B8
		public long UnreadLength
		{
			get
			{
				object @lock = this.m_Lock;
				long result;
				lock (@lock)
				{
					result = this.Length - this.Position;
				}
				return result;
			}
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0000F600 File Offset: 0x0000D800
		public void Append(byte[] buffer, int offset, int count)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				long position = this.Position;
				try
				{
					this.Position = this.Length;
					base.Write(buffer, offset, count);
				}
				finally
				{
					this.Position = position;
				}
			}
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0000F668 File Offset: 0x0000D868
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.Append(buffer, offset, count);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0000F674 File Offset: 0x0000D874
		public long Trim()
		{
			object @lock = this.m_Lock;
			long result;
			lock (@lock)
			{
				long position = this.Position;
				long length = this.Length;
				long num = length - position;
				if (position == 0L || length == 0L || (double)num / (double)length > 0.5)
				{
					result = 0L;
				}
				else
				{
					byte[] buffer = this.GetBuffer();
					this.SetLength(0L);
					this.Capacity = 0;
					if (this.m_InitialCapacity > 0)
					{
						this.Capacity = this.m_InitialCapacity;
					}
					if (num > 0L)
					{
						base.Write(buffer, (int)position, (int)num);
						this.Position = 0L;
					}
					result = position;
				}
			}
			return result;
		}

		// Token: 0x04000186 RID: 390
		private readonly object m_Lock = new object();

		// Token: 0x04000187 RID: 391
		private readonly int m_InitialCapacity;
	}
}
