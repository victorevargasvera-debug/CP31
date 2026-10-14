using System;
using System.Collections.Generic;

namespace Gibraltar
{
	// Token: 0x020000A3 RID: 163
	internal class BufferManager
	{
		// Token: 0x14000020 RID: 32
		// (add) Token: 0x060006DB RID: 1755 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		// (remove) Token: 0x060006DC RID: 1756 RVA: 0x0000C0E4 File Offset: 0x0000A2E4
		public event global::Gibraltar.BufferSizeEventHandler BufferExpanded;

		// Token: 0x060006DD RID: 1757 RVA: 0x0000C120 File Offset: 0x0000A320
		public BufferManager(int initialBuffers, int bufferSize)
		{
			this.m_BufferSize = bufferSize;
			this.m_FreeIndexPool = new global::System.Collections.Generic.Stack<byte[]>(initialBuffers);
			for (int i = 0; i < initialBuffers; i++)
			{
				this.AddBuffer();
			}
			this.m_TotalBuffers = (long)initialBuffers;
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0000C174 File Offset: 0x0000A374
		public byte[] AllocateBuffer()
		{
			object @lock = this.m_Lock;
			byte[] result;
			lock (@lock)
			{
				if (this.m_FreeIndexPool.Count == 0)
				{
					this.AddBuffer();
				}
				result = this.m_FreeIndexPool.Pop();
			}
			return result;
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0000C1D0 File Offset: 0x0000A3D0
		public void FreeBuffer(byte[] buffer)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_FreeIndexPool.Push(buffer);
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0000C214 File Offset: 0x0000A414
		protected void OnBufferExpanded(global::Gibraltar.BufferSizeEventArgs e)
		{
			global::Gibraltar.BufferSizeEventHandler bufferExpanded = this.BufferExpanded;
			if (bufferExpanded != null)
			{
				bufferExpanded(this, e);
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0000C23C File Offset: 0x0000A43C
		private void AddBuffer()
		{
			object @lock = this.m_Lock;
			long totalBuffers;
			lock (@lock)
			{
				this.m_FreeIndexPool.Push(new byte[this.m_BufferSize]);
				this.m_TotalBuffers += 1L;
				totalBuffers = this.m_TotalBuffers;
			}
			this.OnBufferExpanded(new global::Gibraltar.BufferSizeEventArgs(totalBuffers, this.m_BufferSize));
		}

		// Token: 0x04000124 RID: 292
		private readonly object m_Lock = new object();

		// Token: 0x04000125 RID: 293
		private readonly global::System.Collections.Generic.Stack<byte[]> m_FreeIndexPool;

		// Token: 0x04000126 RID: 294
		private readonly int m_BufferSize;

		// Token: 0x04000127 RID: 295
		private long m_TotalBuffers;
	}
}
