using System;
using System.Diagnostics;

namespace Gibraltar.Serialization
{
	// Token: 0x0200010C RID: 268
	[global::System.Diagnostics.DebuggerDisplay("Name: {QualifiedTypeName} Packets: {PacketCount} Total Bytes: {PacketSize}")]
	internal class PacketTypeStorageSummary : global::System.IComparable
	{
		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x0001C03C File Offset: 0x0001A23C
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x0001C044 File Offset: 0x0001A244
		public string QualifiedTypeName { get; private set; }

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x0001C050 File Offset: 0x0001A250
		// (set) Token: 0x06000B13 RID: 2835 RVA: 0x0001C058 File Offset: 0x0001A258
		public string TypeName { get; private set; }

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x0001C064 File Offset: 0x0001A264
		// (set) Token: 0x06000B15 RID: 2837 RVA: 0x0001C06C File Offset: 0x0001A26C
		public int PacketCount { get; set; }

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x0001C078 File Offset: 0x0001A278
		// (set) Token: 0x06000B17 RID: 2839 RVA: 0x0001C080 File Offset: 0x0001A280
		public long PacketSize { get; set; }

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x0001C08C File Offset: 0x0001A28C
		public long AveragePacketSize
		{
			get
			{
				if (this.PacketCount <= 0)
				{
					return this.PacketSize;
				}
				return (long)global::System.Math.Ceiling((double)this.PacketSize / (double)this.PacketCount);
			}
		}

		// Token: 0x06000B19 RID: 2841 RVA: 0x0001C0B8 File Offset: 0x0001A2B8
		public PacketTypeStorageSummary(global::Gibraltar.Serialization.PacketDefinition packetDefinition)
		{
			this.QualifiedTypeName = packetDefinition.QualifiedTypeName;
			this.TypeName = packetDefinition.TypeName;
			this.PacketCount = packetDefinition.PacketCount;
			this.PacketSize = packetDefinition.PacketSize;
		}

		// Token: 0x06000B1A RID: 2842 RVA: 0x0001C100 File Offset: 0x0001A300
		public int CompareTo(object obj)
		{
			global::Gibraltar.Serialization.PacketTypeStorageSummary packetTypeStorageSummary = (global::Gibraltar.Serialization.PacketTypeStorageSummary)obj;
			if (this.PacketSize == packetTypeStorageSummary.PacketSize)
			{
				return packetTypeStorageSummary.PacketCount - this.PacketCount;
			}
			return (int)(packetTypeStorageSummary.PacketSize - this.PacketSize);
		}
	}
}
