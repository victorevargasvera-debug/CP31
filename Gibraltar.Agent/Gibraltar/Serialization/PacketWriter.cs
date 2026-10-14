using System;
using System.IO;
using Gibraltar.Data;

namespace Gibraltar.Serialization
{
	// Token: 0x0200010D RID: 269
	internal class PacketWriter : global::Gibraltar.Serialization.IPacketWriter, global::System.IDisposable
	{
		// Token: 0x06000B1B RID: 2843 RVA: 0x0001C148 File Offset: 0x0001A348
		public PacketWriter(global::System.IO.Stream stream) : this(stream, (int)global::Gibraltar.Data.FileHeader.DefaultMajorVersion, (int)global::Gibraltar.Data.FileHeader.DefaultMinorVersion)
		{
		}

		// Token: 0x06000B1C RID: 2844 RVA: 0x0001C15C File Offset: 0x0001A35C
		public PacketWriter(global::System.IO.Stream stream, int majorVersion, int minorVersion)
		{
			this.m_Stream = stream;
			this.m_Writer = new global::Gibraltar.Serialization.FieldWriter(stream, new global::Gibraltar.Serialization.UniqueStringList(), majorVersion, minorVersion);
			this.m_Buffer = new global::System.IO.MemoryStream();
			this.m_BufferWriter = new global::Gibraltar.Serialization.FieldWriter(this.m_Buffer, this.m_Writer.Strings, majorVersion, minorVersion);
			this.m_CachedTypes = new global::Gibraltar.Serialization.PacketDefinitionList();
			this.m_PacketCache = new global::Gibraltar.Serialization.PacketCache();
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x0001C1CC File Offset: 0x0001A3CC
		public long Position
		{
			get
			{
				return this.m_Stream.Position;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x0001C1DC File Offset: 0x0001A3DC
		public long Length
		{
			get
			{
				return this.m_Stream.Length;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x0001C1EC File Offset: 0x0001A3EC
		public global::Gibraltar.Serialization.PacketCache PacketCache
		{
			get
			{
				return this.m_PacketCache;
			}
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0001C1F4 File Offset: 0x0001A3F4
		public void Write(global::Gibraltar.Serialization.IPacket packet)
		{
			global::Gibraltar.Serialization.ICachedPacket cachedPacket = packet as global::Gibraltar.Serialization.ICachedPacket;
			if (cachedPacket != null && this.m_PacketCache.Contains(cachedPacket))
			{
				return;
			}
			int num = this.m_CachedTypes.IndexOf(packet);
			global::Gibraltar.Serialization.PacketDefinition packetDefinition;
			if (num < 0)
			{
				packetDefinition = global::Gibraltar.Serialization.PacketDefinition.CreatePacketDefinition(packet);
			}
			else
			{
				packetDefinition = this.m_CachedTypes[num];
			}
			foreach (global::Gibraltar.Serialization.IPacket packet2 in packetDefinition.GetRequiredPackets(packet).Values)
			{
				this.Write(packet2);
			}
			try
			{
				this.m_Buffer.SetLength(0L);
				this.m_Buffer.Position = 0L;
				int num2 = this.m_CachedTypes.IndexOf(packet);
				global::Gibraltar.Serialization.PacketDefinition packetDefinition2;
				if (num2 < 0)
				{
					packetDefinition2 = global::Gibraltar.Serialization.PacketDefinition.CreatePacketDefinition(packet);
					num2 = this.m_CachedTypes.Count;
					this.m_CachedTypes.Add(packetDefinition2);
					this.m_BufferWriter.Write((uint)num2);
					packetDefinition2.WriteDefinition(this.m_BufferWriter);
				}
				else
				{
					this.m_BufferWriter.Write((uint)num2);
					packetDefinition2 = this.m_CachedTypes[num2];
				}
				if (packetDefinition2.IsCachable)
				{
					this.m_PacketCache.AddOrGet(cachedPacket);
				}
				packetDefinition2.WriteFields(packet, this.m_BufferWriter);
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
				this.Rollback();
				throw;
			}
			int num3 = (int)this.m_Buffer.Position;
			global::System.IO.MemoryStream memoryStream = global::Gibraltar.Serialization.FieldWriter.WriteLength((long)num3);
			int num4 = (int)memoryStream.Length;
			byte[] array = new byte[num4 + num3];
			memoryStream.Position = 0L;
			memoryStream.Read(array, 0, num4);
			this.m_Buffer.Position = 0L;
			this.m_Buffer.Read(array, num4, num3);
			this.m_Stream.Write(array, 0, array.Length);
			this.Commit();
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0001C3EC File Offset: 0x0001A5EC
		private void Commit()
		{
			this.m_CachedTypes.Commit();
			this.m_Writer.Commit();
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x0001C404 File Offset: 0x0001A604
		private void Rollback()
		{
			this.m_CachedTypes.Rollback();
			this.m_Writer.Rollback();
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x0001C41C File Offset: 0x0001A61C
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x0001C42C File Offset: 0x0001A62C
		protected virtual void Dispose(bool releaseManaged)
		{
			if (!this.m_WeAreDisposed)
			{
				this.m_WeAreDisposed = true;
				if (releaseManaged)
				{
					this.m_Buffer.Dispose();
				}
			}
		}

		// Token: 0x04000316 RID: 790
		private readonly global::System.IO.Stream m_Stream;

		// Token: 0x04000317 RID: 791
		private readonly global::Gibraltar.Serialization.IFieldWriter m_Writer;

		// Token: 0x04000318 RID: 792
		private readonly global::System.IO.MemoryStream m_Buffer;

		// Token: 0x04000319 RID: 793
		private readonly global::Gibraltar.Serialization.IFieldWriter m_BufferWriter;

		// Token: 0x0400031A RID: 794
		private readonly global::Gibraltar.Serialization.PacketDefinitionList m_CachedTypes;

		// Token: 0x0400031B RID: 795
		private readonly global::Gibraltar.Serialization.PacketCache m_PacketCache;

		// Token: 0x0400031C RID: 796
		private bool m_WeAreDisposed;
	}
}
