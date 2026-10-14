using System;
using System.Collections;
using System.Collections.Generic;

namespace Gibraltar.Serialization
{
	// Token: 0x020000FF RID: 255
	internal sealed class PacketDefinitionList : global::System.Collections.Generic.IEnumerable<global::Gibraltar.Serialization.PacketDefinition>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000AAB RID: 2731 RVA: 0x0001A5E8 File Offset: 0x000187E8
		public PacketDefinitionList()
		{
			this.m_List = new global::System.Collections.Generic.List<global::Gibraltar.Serialization.PacketDefinition>();
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x0001A5FC File Offset: 0x000187FC
		public int Count
		{
			get
			{
				return this.m_List.Count;
			}
		}

		// Token: 0x17000433 RID: 1075
		public global::Gibraltar.Serialization.PacketDefinition this[int index]
		{
			get
			{
				return this.m_List[index];
			}
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x0001A61C File Offset: 0x0001881C
		public int IndexOf(global::Gibraltar.Serialization.IPacket packet)
		{
			string text = packet.GetType().Name;
			global::Gibraltar.Serialization.IDynamicPacket dynamicPacket;
			if (packet is global::Gibraltar.Serialization.GenericPacket)
			{
				text = packet.GetPacketDefinition().QualifiedTypeName;
			}
			else if ((dynamicPacket = (packet as global::Gibraltar.Serialization.IDynamicPacket)) != null)
			{
				text = text + "+" + dynamicPacket.DynamicTypeName;
			}
			return this.IndexOf(text);
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0001A67C File Offset: 0x0001887C
		public int IndexOf(string qualifiedTypeName)
		{
			for (int i = 0; i < this.m_List.Count; i++)
			{
				if (qualifiedTypeName == this.m_List[i].QualifiedTypeName)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0001A6C8 File Offset: 0x000188C8
		public int Add(global::Gibraltar.Serialization.PacketDefinition item)
		{
			int num = this.IndexOf(item.QualifiedTypeName);
			if (num >= 0)
			{
				global::Gibraltar.ErrorNotifier.Notify(this, new global::System.ArgumentException("A PacketDefinition for " + item.QualifiedTypeName + " is already registered."));
				this.m_List[num] = item;
				return num;
			}
			this.m_List.Add(item);
			return this.Count - 1;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0001A730 File Offset: 0x00018930
		public void Commit()
		{
			this.m_CommittedListSize = this.m_List.Count;
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0001A744 File Offset: 0x00018944
		public void Rollback()
		{
			if (this.m_List.Count > this.m_CommittedListSize)
			{
				int count = this.m_List.Count - this.m_CommittedListSize;
				this.m_List.RemoveRange(this.m_CommittedListSize, count);
			}
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0001A790 File Offset: 0x00018990
		global::System.Collections.Generic.IEnumerator<global::Gibraltar.Serialization.PacketDefinition> global::System.Collections.Generic.IEnumerable<global::Gibraltar.Serialization.PacketDefinition>.GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x0001A7A4 File Offset: 0x000189A4
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return ((global::System.Collections.Generic.IEnumerable<global::Gibraltar.Serialization.PacketDefinition>)this).GetEnumerator();
		}

		// Token: 0x040002EA RID: 746
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Serialization.PacketDefinition> m_List;

		// Token: 0x040002EB RID: 747
		private int m_CommittedListSize;
	}
}
