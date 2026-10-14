using System;
using System.Collections;
using System.Collections.Generic;

namespace Gibraltar.Serialization
{
	// Token: 0x02000104 RID: 260
	internal class PacketCache : global::System.Collections.Generic.IEnumerable<global::Gibraltar.Serialization.ICachedPacket>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000AC3 RID: 2755 RVA: 0x0001A7AC File Offset: 0x000189AC
		public PacketCache()
		{
			this.m_Cache = new global::System.Collections.Generic.List<global::Gibraltar.Serialization.ICachedPacket>();
			this.m_Index = new global::System.Collections.Generic.Dictionary<global::System.Guid, int>();
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0001A7CC File Offset: 0x000189CC
		public int AddOrGet(global::Gibraltar.Serialization.ICachedPacket packet)
		{
			int count;
			if (this.m_Index.TryGetValue(packet.ID, out count))
			{
				return count;
			}
			count = this.m_Cache.Count;
			this.m_Cache.Add(packet);
			this.m_Index.Add(packet.ID, count);
			return count;
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0001A824 File Offset: 0x00018A24
		public bool Contains(global::Gibraltar.Serialization.ICachedPacket packet)
		{
			return this.m_Index.ContainsKey(packet.ID);
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000AC6 RID: 2758 RVA: 0x0001A838 File Offset: 0x00018A38
		public int Count
		{
			get
			{
				return this.m_Cache.Count;
			}
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0001A848 File Offset: 0x00018A48
		public void Clear()
		{
			this.m_Cache.Clear();
			this.m_Index.Clear();
		}

		// Token: 0x17000439 RID: 1081
		public global::Gibraltar.Serialization.ICachedPacket this[int index]
		{
			get
			{
				if (index < 0 || index >= this.m_Cache.Count)
				{
					return null;
				}
				return this.m_Cache[index];
			}
		}

		// Token: 0x1700043A RID: 1082
		public global::Gibraltar.Serialization.ICachedPacket this[global::System.Guid id]
		{
			get
			{
				int index;
				if (this.m_Index.TryGetValue(id, out index))
				{
					return this.m_Cache[index];
				}
				return null;
			}
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0001A8BC File Offset: 0x00018ABC
		global::System.Collections.Generic.IEnumerator<global::Gibraltar.Serialization.ICachedPacket> global::System.Collections.Generic.IEnumerable<global::Gibraltar.Serialization.ICachedPacket>.GetEnumerator()
		{
			return this.m_Cache.GetEnumerator();
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0001A8D0 File Offset: 0x00018AD0
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return ((global::System.Collections.Generic.IEnumerable<global::Gibraltar.Serialization.ICachedPacket>)this).GetEnumerator();
		}

		// Token: 0x040002EC RID: 748
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Serialization.ICachedPacket> m_Cache;

		// Token: 0x040002ED RID: 749
		private readonly global::System.Collections.Generic.Dictionary<global::System.Guid, int> m_Index;
	}
}
