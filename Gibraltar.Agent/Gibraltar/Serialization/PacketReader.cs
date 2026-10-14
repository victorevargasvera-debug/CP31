using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Gibraltar.Data;
using Gibraltar.Serialization.Internal;

namespace Gibraltar.Serialization
{
	// Token: 0x02000109 RID: 265
	internal class PacketReader : global::Gibraltar.Serialization.IPacketReader, global::System.IDisposable
	{
		// Token: 0x06000AF3 RID: 2803 RVA: 0x0001B8D0 File Offset: 0x00019AD0
		public PacketReader(global::System.IO.Stream stream, bool inputIsReadOnly) : this(stream, inputIsReadOnly, (int)global::Gibraltar.Data.FileHeader.DefaultMajorVersion, (int)global::Gibraltar.Data.FileHeader.DefaultMinorVersion)
		{
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x0001B8E4 File Offset: 0x00019AE4
		public PacketReader(global::System.IO.Stream stream, bool inputIsReadOnly, int majorVersion, int minorVersion)
		{
			this.m_Stream = stream;
			this.m_InputIsReadOnly = inputIsReadOnly;
			this.m_MajorVersion = majorVersion;
			this.m_MinorVersion = minorVersion;
			this.m_Reader = new global::Gibraltar.Serialization.FieldReader(stream, new global::Gibraltar.Serialization.UniqueStringList(), majorVersion, minorVersion);
			this.m_cachedTypes = new global::Gibraltar.Serialization.PacketDefinitionList();
			this.m_PacketFactory = new global::Gibraltar.Serialization.Internal.PacketFactory();
			if (inputIsReadOnly && this.m_Stream != null)
			{
				this.m_StreamLength = this.m_Stream.Length;
			}
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x0001B964 File Offset: 0x00019B64
		public PacketReader(byte[] data) : this(new global::System.IO.MemoryStream(data), true)
		{
			this.m_ReleaseStream = true;
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x0001B97C File Offset: 0x00019B7C
		public bool DataAvailable
		{
			get
			{
				long num = this.m_InputIsReadOnly ? this.m_StreamLength : this.m_Stream.Length;
				if (this.m_Stream.Position + 1L >= num)
				{
					return false;
				}
				bool result;
				try
				{
					int num2 = (int)this.m_Reader.PeekUInt64();
					result = (num - this.m_Stream.Position >= (long)num2);
				}
				catch (global::System.Exception)
				{
					result = false;
				}
				return result;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x0001BA04 File Offset: 0x00019C04
		public long Position
		{
			get
			{
				return this.m_Stream.Position;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x0001BA14 File Offset: 0x00019C14
		public long Length
		{
			get
			{
				if (!this.m_InputIsReadOnly)
				{
					return this.m_Stream.Length;
				}
				return this.m_StreamLength;
			}
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0001BA34 File Offset: 0x00019C34
		public global::Gibraltar.Serialization.IPacket Read()
		{
			int num = (int)this.m_Reader.ReadUInt64();
			if (num < 1)
			{
				throw new global::Gibraltar.Serialization.GibraltarSerializationException("The size of the next packet is smaller than 1 byte or negative, which can't be correct.  The packet stream is corrupted.", true);
			}
			byte[] buffer = new byte[num];
			this.m_Stream.Read(buffer, 0, num);
			global::Gibraltar.Serialization.IFieldReader fieldReader = new global::Gibraltar.Serialization.FieldReader(new global::System.IO.MemoryStream(buffer), this.m_Reader.Strings, this.m_MajorVersion, this.m_MinorVersion);
			int num2 = (int)fieldReader.ReadUInt32();
			global::Gibraltar.Serialization.PacketDefinition packetDefinition;
			if (num2 >= this.m_cachedTypes.Count)
			{
				packetDefinition = global::Gibraltar.Serialization.PacketDefinition.ReadPacketDefinition(fieldReader);
				if (string.IsNullOrEmpty(packetDefinition.TypeName))
				{
					throw new global::Gibraltar.Serialization.GibraltarSerializationException("The type name of the definition is null, which can't be correct.  The packet stream is corrupted.", true);
				}
				this.m_cachedTypes.Add(packetDefinition);
				this.m_cachedTypes.Commit();
			}
			else
			{
				packetDefinition = this.m_cachedTypes[num2];
			}
			return this.m_PacketFactory.GetPacketFactory(packetDefinition.TypeName).CreatePacket(packetDefinition, fieldReader);
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0001BB24 File Offset: 0x00019D24
		public global::Gibraltar.Serialization.IPacket ReadPacket(global::System.IO.Stream packetStream)
		{
			this.m_Reader.ReplaceStream(packetStream);
			int num = (int)this.m_Reader.ReadUInt32();
			global::Gibraltar.Serialization.PacketDefinition packetDefinition;
			if (num >= this.m_cachedTypes.Count)
			{
				packetDefinition = global::Gibraltar.Serialization.PacketDefinition.ReadPacketDefinition(this.m_Reader);
				if (string.IsNullOrEmpty(packetDefinition.TypeName))
				{
					throw new global::Gibraltar.Serialization.GibraltarSerializationException("The type name of the definition is null, which can't be correct.  The packet stream is corrupted.", true);
				}
				this.m_cachedTypes.Add(packetDefinition);
				this.m_cachedTypes.Commit();
			}
			else
			{
				packetDefinition = this.m_cachedTypes[num];
			}
			global::Gibraltar.Serialization.PacketDefinition packetDefinition2 = packetDefinition;
			int packetCount = packetDefinition2.PacketCount;
			packetDefinition2.PacketCount = packetCount + 1;
			packetDefinition.PacketSize += packetStream.Length;
			return this.m_PacketFactory.GetPacketFactory(packetDefinition.TypeName).CreatePacket(packetDefinition, this.m_Reader);
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0001BBF0 File Offset: 0x00019DF0
		public global::System.Collections.Generic.List<global::Gibraltar.Serialization.PacketTypeStorageSummary> GetStorageSummary()
		{
			global::System.Collections.Generic.List<global::Gibraltar.Serialization.PacketTypeStorageSummary> list = new global::System.Collections.Generic.List<global::Gibraltar.Serialization.PacketTypeStorageSummary>();
			foreach (object obj in this.m_cachedTypes)
			{
				global::Gibraltar.Serialization.PacketTypeStorageSummary item = new global::Gibraltar.Serialization.PacketTypeStorageSummary((global::Gibraltar.Serialization.PacketDefinition)obj);
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0001BC60 File Offset: 0x00019E60
		public void RegisterType(global::System.Type type)
		{
			this.m_PacketFactory.RegisterType(type);
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0001BC70 File Offset: 0x00019E70
		public void RegisterFactory(string typeName, global::Gibraltar.Serialization.IPacketFactory factory)
		{
			this.m_PacketFactory.RegisterFactory(typeName, factory);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0001BC80 File Offset: 0x00019E80
		public void RegisterAssembly(global::System.Reflection.Assembly assembly)
		{
			this.m_PacketFactory.RegisterAssembly(assembly);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0001BC90 File Offset: 0x00019E90
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0001BCA0 File Offset: 0x00019EA0
		protected virtual void Dispose(bool releaseManaged)
		{
			if (!this.m_WeAreDisposed)
			{
				this.m_WeAreDisposed = true;
				if (releaseManaged && this.m_ReleaseStream)
				{
					if (this.m_Stream != null)
					{
						this.m_Stream.Dispose();
					}
					this.m_ReleaseStream = false;
				}
			}
		}

		// Token: 0x04000301 RID: 769
		private readonly global::System.IO.Stream m_Stream;

		// Token: 0x04000302 RID: 770
		private readonly bool m_InputIsReadOnly;

		// Token: 0x04000303 RID: 771
		private readonly global::Gibraltar.Serialization.FieldReader m_Reader;

		// Token: 0x04000304 RID: 772
		private readonly global::Gibraltar.Serialization.PacketDefinitionList m_cachedTypes;

		// Token: 0x04000305 RID: 773
		private readonly global::Gibraltar.Serialization.Internal.PacketFactory m_PacketFactory;

		// Token: 0x04000306 RID: 774
		private bool m_ReleaseStream;

		// Token: 0x04000307 RID: 775
		private bool m_WeAreDisposed;

		// Token: 0x04000308 RID: 776
		private long m_StreamLength;

		// Token: 0x04000309 RID: 777
		private readonly int m_MajorVersion;

		// Token: 0x0400030A RID: 778
		private readonly int m_MinorVersion;
	}
}
