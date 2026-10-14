using System;
using System.IO;

namespace Gibraltar.Serialization.Internal
{
	// Token: 0x02000114 RID: 276
	internal class SimpleMemoryStream : global::System.IO.MemoryStream
	{
		// Token: 0x06000B84 RID: 2948 RVA: 0x0001D388 File Offset: 0x0001B588
		public SimpleMemoryStream(int size)
		{
			this.m_Buffer = new byte[size];
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x0001D39C File Offset: 0x0001B59C
		// (set) Token: 0x06000B86 RID: 2950 RVA: 0x0001D3A4 File Offset: 0x0001B5A4
		public override long Position
		{
			get
			{
				return this.m_Position;
			}
			set
			{
				this.m_Position = value;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x0001D3B0 File Offset: 0x0001B5B0
		public override long Length
		{
			get
			{
				return this.m_Length;
			}
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0001D3B8 File Offset: 0x0001B5B8
		public void SetLength(int length)
		{
			this.m_Length = (long)length;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0001D3C4 File Offset: 0x0001B5C4
		public override byte[] GetBuffer()
		{
			return this.m_Buffer;
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0001D3CC File Offset: 0x0001B5CC
		public override int Read(byte[] array, int offset, int count)
		{
			long num = this.m_Length - this.m_Position;
			if ((long)count > num)
			{
				count = (int)num;
			}
			global::System.Buffer.BlockCopy(this.m_Buffer, (int)this.m_Position, array, offset, count);
			this.m_Position += (long)count;
			return count;
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0001D41C File Offset: 0x0001B61C
		public override int ReadByte()
		{
			if (this.m_Position < this.m_Length)
			{
				byte[] buffer = this.m_Buffer;
				long position = this.m_Position;
				this.m_Position = position + 1L;
				return buffer[(int)(checked((global::System.IntPtr)position))];
			}
			return -1;
		}

		// Token: 0x0400033B RID: 827
		private readonly byte[] m_Buffer;

		// Token: 0x0400033C RID: 828
		private long m_Position;

		// Token: 0x0400033D RID: 829
		private long m_Length;
	}
}
