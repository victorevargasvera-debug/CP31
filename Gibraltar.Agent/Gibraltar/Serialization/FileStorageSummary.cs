using System;
using System.Collections.Generic;

namespace Gibraltar.Serialization
{
	// Token: 0x0200010A RID: 266
	internal class FileStorageSummary
	{
		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x0001BCF4 File Offset: 0x00019EF4
		// (set) Token: 0x06000B02 RID: 2818 RVA: 0x0001BCFC File Offset: 0x00019EFC
		public long TotalRawFileSize { get; private set; }

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x0001BD08 File Offset: 0x00019F08
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x0001BD10 File Offset: 0x00019F10
		public long TotalPacketSize { get; private set; }

		// Token: 0x06000B05 RID: 2821 RVA: 0x0001BD1C File Offset: 0x00019F1C
		public void Merge(global::System.Collections.Generic.List<global::Gibraltar.Serialization.PacketTypeStorageSummary> packetTypes, global::Gibraltar.Serialization.FragmentStorageSummary fragment)
		{
			this.FragmentList.Add(fragment);
			foreach (global::Gibraltar.Serialization.PacketTypeStorageSummary packetTypeStorageSummary in packetTypes)
			{
				bool flag = false;
				foreach (global::Gibraltar.Serialization.PacketTypeStorageSummary packetTypeStorageSummary2 in this.PacketList)
				{
					if (string.CompareOrdinal(packetTypeStorageSummary2.QualifiedTypeName, packetTypeStorageSummary.QualifiedTypeName) == 0)
					{
						packetTypeStorageSummary2.PacketCount += packetTypeStorageSummary.PacketCount;
						packetTypeStorageSummary2.PacketSize += packetTypeStorageSummary.PacketSize;
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					this.PacketList.Add(packetTypeStorageSummary);
				}
			}
		}

		// Token: 0x06000B06 RID: 2822 RVA: 0x0001BE14 File Offset: 0x0001A014
		public void Summarize()
		{
			this.PacketList.Sort();
			this.FragmentList.Sort();
			this.TotalRawFileSize = 0L;
			foreach (global::Gibraltar.Serialization.FragmentStorageSummary fragmentStorageSummary in this.FragmentList)
			{
				this.TotalRawFileSize += fragmentStorageSummary.FragmentSize;
			}
			this.TotalPacketSize = 0L;
			foreach (global::Gibraltar.Serialization.PacketTypeStorageSummary packetTypeStorageSummary in this.PacketList)
			{
				this.TotalPacketSize += packetTypeStorageSummary.PacketSize;
			}
			long num = this.TotalRawFileSize;
			for (int i = this.PacketList.Count - 1; i >= 1; i--)
			{
				global::Gibraltar.Serialization.PacketTypeStorageSummary packetTypeStorageSummary2 = this.PacketList[i];
				double num2 = (double)packetTypeStorageSummary2.PacketSize / (double)this.TotalPacketSize;
				packetTypeStorageSummary2.PacketSize = (long)global::System.Math.Round((double)this.TotalRawFileSize * num2);
				num -= packetTypeStorageSummary2.PacketSize;
			}
			if (this.PacketList.Count > 0)
			{
				this.PacketList[0].PacketSize = num;
			}
		}

		// Token: 0x0400030B RID: 779
		public readonly global::System.Collections.Generic.List<global::Gibraltar.Serialization.PacketTypeStorageSummary> PacketList = new global::System.Collections.Generic.List<global::Gibraltar.Serialization.PacketTypeStorageSummary>();

		// Token: 0x0400030C RID: 780
		public readonly global::System.Collections.Generic.List<global::Gibraltar.Serialization.FragmentStorageSummary> FragmentList = new global::System.Collections.Generic.List<global::Gibraltar.Serialization.FragmentStorageSummary>();
	}
}
