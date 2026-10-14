using System;
using System.IO;

namespace Gibraltar.Messaging.Net
{
	// Token: 0x0200024E RID: 590
	internal class NetworkSerializer : global::System.IDisposable
	{
		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06001D9B RID: 7579 RVA: 0x00068774 File Offset: 0x00066974
		public byte[] UnusedData
		{
			get
			{
				object @lock = this.m_Lock;
				byte[] result;
				lock (@lock)
				{
					if (this.m_Stream.Position == 0L)
					{
						result = this.m_Stream.ToArray();
					}
					else
					{
						long num = this.m_Stream.Length - this.m_Stream.Position;
						byte[] array = null;
						if (num > 0L)
						{
							array = new byte[this.m_Stream.Length - this.m_Stream.Position];
							long position = this.m_Stream.Position;
							this.m_Stream.Read(array, 0, array.Length);
							this.m_Stream.Position = position;
						}
						result = array;
					}
				}
				return result;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x00068838 File Offset: 0x00066A38
		public bool HaveUnusedData
		{
			get
			{
				object @lock = this.m_Lock;
				bool result;
				lock (@lock)
				{
					result = (this.m_Stream.Length > 0L);
				}
				return result;
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001D9D RID: 7581 RVA: 0x00068880 File Offset: 0x00066A80
		public int BytesRequred
		{
			get
			{
				return this.m_BytesRequired;
			}
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x00068888 File Offset: 0x00066A88
		public void AppendData(byte[] buffer, int length)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				long position = this.m_Stream.Position;
				this.m_Stream.Position = this.m_Stream.Length;
				this.m_Stream.Write(buffer, 0, length);
				this.m_Stream.Position = position;
			}
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x000688FC File Offset: 0x00066AFC
		public global::Gibraltar.Messaging.Net.NetworkMessage ReadNext()
		{
			object @lock = this.m_Lock;
			global::Gibraltar.Messaging.Net.NetworkMessage result;
			lock (@lock)
			{
				global::Gibraltar.Messaging.Net.NetworkMessage networkMessage = null;
				int num;
				global::Gibraltar.Messaging.Net.NetworkMessageTypeCode networkMessageTypeCode;
				global::System.Version version;
				if (global::Gibraltar.Messaging.Net.NetworkMessage.ReadHeader(this.m_Stream, out num, out networkMessageTypeCode, out version) && this.m_Stream.Length - this.m_Stream.Position >= (long)num)
				{
					networkMessage = global::Gibraltar.Messaging.Net.NetworkMessage.Read(this.m_Stream);
				}
				if (this.m_Stream.Length != this.m_Stream.Position)
				{
					this.m_BytesRequired = num - (int)(this.m_Stream.Length - this.m_Stream.Position);
				}
				else
				{
					this.m_Stream.Position = 0L;
					this.m_Stream.SetLength(0L);
					this.m_BytesRequired = 0;
				}
				result = networkMessage;
			}
			return result;
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x000689DC File Offset: 0x00066BDC
		public void Dispose()
		{
			this.m_Stream.Dispose();
		}

		// Token: 0x04000B07 RID: 2823
		private readonly object m_Lock = new object();

		// Token: 0x04000B08 RID: 2824
		private readonly global::System.IO.MemoryStream m_Stream = new global::System.IO.MemoryStream();

		// Token: 0x04000B09 RID: 2825
		private int m_BytesRequired;
	}
}
