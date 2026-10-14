using System;
using System.IO;
using System.Threading;

namespace Gibraltar.Serialization.Internal
{
	// Token: 0x02000111 RID: 273
	internal class BufferedMemoryStream : global::System.IO.Stream
	{
		// Token: 0x06000B6E RID: 2926 RVA: 0x0001CF84 File Offset: 0x0001B184
		public BufferedMemoryStream(global::System.IO.Stream stream)
		{
			this.m_FileStream = stream;
			this.m_Length = this.m_FileStream.Length;
			this.m_Position = 0L;
			this.m_MemoryStream1 = new global::Gibraltar.Serialization.Internal.SimpleMemoryStream(65536);
			this.m_MemoryStream2 = new global::Gibraltar.Serialization.Internal.SimpleMemoryStream(65536);
			this.m_MemoryStream = this.m_MemoryStream1;
			this.BeginRead();
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0001D004 File Offset: 0x0001B204
		private void BeginRead()
		{
			global::Gibraltar.Serialization.Internal.SimpleMemoryStream memoryStream = this.m_MemoryStream;
			this.m_MemoryStream = ((this.m_MemoryStream == this.m_MemoryStream1) ? this.m_MemoryStream2 : this.m_MemoryStream1);
			memoryStream.SetLength(0);
			memoryStream.Position = 0L;
			byte[] buffer = memoryStream.GetBuffer();
			this.m_ReadStatus = this.m_FileStream.BeginRead(buffer, 0, 65536, new global::System.AsyncCallback(this.ReadCompleteHandler), memoryStream);
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0001D080 File Offset: 0x0001B280
		private void ReadCompleteHandler(global::System.IAsyncResult ar)
		{
			if (!ar.IsCompleted)
			{
				return;
			}
			try
			{
				global::System.Threading.Monitor.Enter(this.m_WaitObject);
				global::Gibraltar.Serialization.Internal.SimpleMemoryStream simpleMemoryStream = (global::Gibraltar.Serialization.Internal.SimpleMemoryStream)ar.AsyncState;
				int length = this.m_FileStream.EndRead(ar);
				simpleMemoryStream.SetLength(length);
				simpleMemoryStream.Position = 0L;
				this.m_ReadStatus = null;
				global::System.Threading.Monitor.Pulse(this.m_WaitObject);
			}
			finally
			{
				global::System.Threading.Monitor.Exit(this.m_WaitObject);
			}
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0001D100 File Offset: 0x0001B300
		public override int Read(byte[] buffer, int offset, int count)
		{
			long num = this.m_MemoryStream.Length - this.m_MemoryStream.Position;
			int num2 = 0;
			if (num > 0L)
			{
				num2 = this.m_MemoryStream.Read(buffer, offset, count);
			}
			if (num2 == count)
			{
				this.m_Position += (long)num2;
				return num2;
			}
			int result;
			try
			{
				global::System.Threading.Monitor.Enter(this.m_WaitObject);
				if (this.m_ReadStatus != null)
				{
					global::System.Threading.Monitor.Wait(this.m_WaitObject);
				}
				if (this.m_FileStream.Position < this.m_FileStream.Length)
				{
					this.BeginRead();
				}
				else
				{
					this.m_MemoryStream = ((this.m_MemoryStream == this.m_MemoryStream1) ? this.m_MemoryStream2 : this.m_MemoryStream1);
				}
				if (this.m_MemoryStream.Length - this.m_MemoryStream.Position > 0L)
				{
					int offset2 = offset + num2;
					int count2 = count - num2;
					int num3 = this.m_MemoryStream.Read(buffer, offset2, count2);
					num2 += num3;
				}
				this.m_Position += (long)num2;
				result = num2;
			}
			finally
			{
				global::System.Threading.Monitor.Exit(this.m_WaitObject);
			}
			return result;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x0001D234 File Offset: 0x0001B434
		public override int ReadByte()
		{
			if (this.Read(this.m_ByteBuffer, 0, 1) == 0)
			{
				return -1;
			}
			return (int)this.m_ByteBuffer[0];
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0001D254 File Offset: 0x0001B454
		public override void Flush()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0001D25C File Offset: 0x0001B45C
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x0001D264 File Offset: 0x0001B464
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x0001D26C File Offset: 0x0001B46C
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0001D274 File Offset: 0x0001B474
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x0001D278 File Offset: 0x0001B478
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x0001D27C File Offset: 0x0001B47C
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x0001D280 File Offset: 0x0001B480
		public override long Length
		{
			get
			{
				return this.m_Length;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0001D288 File Offset: 0x0001B488
		// (set) Token: 0x06000B7C RID: 2940 RVA: 0x0001D290 File Offset: 0x0001B490
		public override long Position
		{
			get
			{
				return this.m_Position;
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x0400032F RID: 815
		private const int BufferSize = 65536;

		// Token: 0x04000330 RID: 816
		private readonly global::System.IO.Stream m_FileStream;

		// Token: 0x04000331 RID: 817
		private readonly global::Gibraltar.Serialization.Internal.SimpleMemoryStream m_MemoryStream1;

		// Token: 0x04000332 RID: 818
		private readonly global::Gibraltar.Serialization.Internal.SimpleMemoryStream m_MemoryStream2;

		// Token: 0x04000333 RID: 819
		private global::Gibraltar.Serialization.Internal.SimpleMemoryStream m_MemoryStream;

		// Token: 0x04000334 RID: 820
		private readonly byte[] m_ByteBuffer = new byte[1];

		// Token: 0x04000335 RID: 821
		private readonly object m_WaitObject = new object();

		// Token: 0x04000336 RID: 822
		private global::System.IAsyncResult m_ReadStatus;

		// Token: 0x04000337 RID: 823
		private readonly long m_Length;

		// Token: 0x04000338 RID: 824
		private long m_Position;
	}
}
