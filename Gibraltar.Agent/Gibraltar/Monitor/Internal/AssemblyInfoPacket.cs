using System;
using System.Reflection;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x020001F9 RID: 505
	internal class AssemblyInfoPacket : global::Gibraltar.Monitor.Internal.GibraltarCachedPacket, global::Gibraltar.Serialization.IPacket, global::System.IEquatable<global::Gibraltar.Monitor.Internal.AssemblyInfoPacket>
	{
		// Token: 0x060018EB RID: 6379 RVA: 0x00057EB0 File Offset: 0x000560B0
		public AssemblyInfoPacket() : base(true)
		{
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x00057EBC File Offset: 0x000560BC
		// (set) Token: 0x060018ED RID: 6381 RVA: 0x00057EC4 File Offset: 0x000560C4
		public string CultureName
		{
			get
			{
				return this.m_CultureName;
			}
			set
			{
				this.m_CultureName = value;
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x00057ED0 File Offset: 0x000560D0
		// (set) Token: 0x060018EF RID: 6383 RVA: 0x00057ED8 File Offset: 0x000560D8
		public string FullName
		{
			get
			{
				return this.m_FullName;
			}
			set
			{
				this.m_FullName = value;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x00057EE4 File Offset: 0x000560E4
		// (set) Token: 0x060018F1 RID: 6385 RVA: 0x00057EEC File Offset: 0x000560EC
		public string ImageRuntimeVersion
		{
			get
			{
				return this.m_ImageRuntimeVersion;
			}
			set
			{
				this.m_ImageRuntimeVersion = value;
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x00057EF8 File Offset: 0x000560F8
		// (set) Token: 0x060018F3 RID: 6387 RVA: 0x00057F00 File Offset: 0x00056100
		public string Location
		{
			get
			{
				return this.m_Location;
			}
			set
			{
				this.m_Location = value;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x00057F0C File Offset: 0x0005610C
		// (set) Token: 0x060018F5 RID: 6389 RVA: 0x00057F14 File Offset: 0x00056114
		public string Name
		{
			get
			{
				return this.m_Name;
			}
			set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x00057F20 File Offset: 0x00056120
		// (set) Token: 0x060018F7 RID: 6391 RVA: 0x00057F28 File Offset: 0x00056128
		public global::System.Reflection.ProcessorArchitecture ProcessorArchitecture
		{
			get
			{
				return this.m_ProcessorArchitecture;
			}
			set
			{
				this.m_ProcessorArchitecture = value;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x00057F34 File Offset: 0x00056134
		// (set) Token: 0x060018F9 RID: 6393 RVA: 0x00057F3C File Offset: 0x0005613C
		public bool GlobalAssemblyCache
		{
			get
			{
				return this.m_GlobalAssemblyCache;
			}
			set
			{
				this.m_GlobalAssemblyCache = value;
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x00057F48 File Offset: 0x00056148
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x00057F50 File Offset: 0x00056150
		public string Version
		{
			get
			{
				return this.m_Version;
			}
			set
			{
				this.m_Version = value;
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x00057F5C File Offset: 0x0005615C
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x00057F64 File Offset: 0x00056164
		public string FileVersion
		{
			get
			{
				return this.m_FileVersion;
			}
			set
			{
				this.m_FileVersion = value;
			}
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00057F70 File Offset: 0x00056170
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.AssemblyInfoPacket);
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x00057F80 File Offset: 0x00056180
		public bool Equals(global::Gibraltar.Monitor.Internal.AssemblyInfoPacket other)
		{
			return other != null && (this.CultureName == other.CultureName && this.FullName == other.FullName && this.ImageRuntimeVersion == other.ImageRuntimeVersion && this.GlobalAssemblyCache == other.GlobalAssemblyCache && this.Location == other.Location && this.Name == other.Name && this.ProcessorArchitecture == other.ProcessorArchitecture && this.Version == other.Version && this.FileVersion == other.FileVersion) && base.Equals(other);
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x00058060 File Offset: 0x00056260
		public override int GetHashCode()
		{
			return base.GetHashCode() ^ this.m_FullName.GetHashCode();
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x00058074 File Offset: 0x00056274
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x00058078 File Offset: 0x00056278
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, false)
			{
				Fields = 
				{
					{
						"FullName",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"Name",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"Version",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"CultureName",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"ProcessorArchitecture",
						global::Gibraltar.Serialization.FieldType.Int32
					},
					{
						"GlobalAssemblyCache",
						global::Gibraltar.Serialization.FieldType.Bool
					},
					{
						"Location",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"FileVersion",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"ImageRuntimeVersion",
						global::Gibraltar.Serialization.FieldType.String
					}
				}
			};
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00058138 File Offset: 0x00056338
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("FullName", this.m_FullName);
			packet.SetField("Name", this.m_Name);
			packet.SetField("Version", this.m_Version);
			packet.SetField("CultureName", this.m_CultureName);
			packet.SetField("ProcessorArchitecture", this.m_ProcessorArchitecture);
			packet.SetField("GlobalAssemblyCache", this.m_GlobalAssemblyCache);
			packet.SetField("Location", this.m_Location);
			packet.SetField("FileVersion", this.m_FileVersion);
			packet.SetField("ImageRuntimeVersion", this.m_ImageRuntimeVersion);
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x000581EC File Offset: 0x000563EC
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				packet.GetField("FullName", out this.m_FullName);
				packet.GetField("Name", out this.m_Name);
				packet.GetField("Version", out this.m_Version);
				packet.GetField("CultureName", out this.m_CultureName);
				int processorArchitecture;
				packet.GetField("ProcessorArchitecture", out processorArchitecture);
				this.m_ProcessorArchitecture = (global::System.Reflection.ProcessorArchitecture)processorArchitecture;
				packet.GetField("GlobalAssemblyCache", out this.m_GlobalAssemblyCache);
				packet.GetField("Location", out this.m_Location);
				packet.GetField("FileVersion", out this.m_FileVersion);
				packet.GetField("ImageRuntimeVersion", out this.m_ImageRuntimeVersion);
			}
		}

		// Token: 0x0400090A RID: 2314
		private string m_CultureName;

		// Token: 0x0400090B RID: 2315
		private string m_FullName;

		// Token: 0x0400090C RID: 2316
		private string m_ImageRuntimeVersion;

		// Token: 0x0400090D RID: 2317
		private bool m_GlobalAssemblyCache;

		// Token: 0x0400090E RID: 2318
		private string m_Location;

		// Token: 0x0400090F RID: 2319
		private string m_Name;

		// Token: 0x04000910 RID: 2320
		private global::System.Reflection.ProcessorArchitecture m_ProcessorArchitecture;

		// Token: 0x04000911 RID: 2321
		private string m_Version;

		// Token: 0x04000912 RID: 2322
		private string m_FileVersion;

		// Token: 0x04000913 RID: 2323
		private const int SerializationVersion = 1;
	}
}
