using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001BA RID: 442
	internal class EventMetricValueDefinitionCollection : global::Loupe.Extensibility.Data.IEventMetricValueDefinitionCollection, global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IEventMetricValueDefinition>, global::System.Collections.Generic.ICollection<global::Loupe.Extensibility.Data.IEventMetricValueDefinition>, global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IEventMetricValueDefinition>, global::System.Collections.IEnumerable
	{
		// Token: 0x1400006B RID: 107
		// (add) Token: 0x0600141E RID: 5150 RVA: 0x0003B334 File Offset: 0x00039534
		// (remove) Token: 0x0600141F RID: 5151 RVA: 0x0003B370 File Offset: 0x00039570
		public event global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IEventMetricValueDefinitionCollection, global::Loupe.Extensibility.Data.IEventMetricValueDefinition>> CollectionChanged;

		// Token: 0x06001420 RID: 5152 RVA: 0x0003B3AC File Offset: 0x000395AC
		internal EventMetricValueDefinitionCollection(global::Gibraltar.Monitor.EventMetricDefinition definition)
		{
			this.m_Definition = definition;
		}

		// Token: 0x06001421 RID: 5153 RVA: 0x0003B3D4 File Offset: 0x000395D4
		public global::Gibraltar.Monitor.EventMetricValueDefinition Add(string name, global::System.Type type)
		{
			return this.Add(name, type, null, null);
		}

		// Token: 0x06001422 RID: 5154 RVA: 0x0003B3E0 File Offset: 0x000395E0
		public global::Gibraltar.Monitor.EventMetricValueDefinition Add(string name, global::System.Type type, string caption, string description)
		{
			object @lock = this.m_Definition.Lock;
			global::Gibraltar.Monitor.EventMetricValueDefinition result;
			lock (@lock)
			{
				if (this.IsReadOnly)
				{
					throw new global::System.NotSupportedException("The collection is read-only");
				}
				if (string.IsNullOrEmpty(name))
				{
					throw new global::System.ArgumentNullException("name");
				}
				if (type == null)
				{
					throw new global::System.ArgumentNullException("type");
				}
				if (this.m_Dictionary.ContainsKey(name))
				{
					throw new global::System.ArgumentException("There is already a value definition with the provided name.", "name");
				}
				global::Gibraltar.Monitor.Internal.EventMetricValueDefinitionPacket packet = new global::Gibraltar.Monitor.Internal.EventMetricValueDefinitionPacket(this.m_Definition.Packet, name, type, caption, description);
				global::Gibraltar.Monitor.EventMetricValueDefinition eventMetricValueDefinition = new global::Gibraltar.Monitor.EventMetricValueDefinition(this.m_Definition, packet);
				this.Add(eventMetricValueDefinition);
				result = eventMetricValueDefinition;
			}
			return result;
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06001423 RID: 5155 RVA: 0x0003B4A8 File Offset: 0x000396A8
		public global::Loupe.Extensibility.Data.IEventMetricDefinition Definition
		{
			get
			{
				return this.m_Definition;
			}
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0003B4B0 File Offset: 0x000396B0
		public bool ContainsKey(string name)
		{
			if (this.IsReadOnly)
			{
				return this.m_Dictionary.ContainsKey(name);
			}
			object @lock = this.m_Definition.Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_Dictionary.ContainsKey(name);
			}
			return result;
		}

		// Token: 0x06001425 RID: 5157 RVA: 0x0003B514 File Offset: 0x00039714
		public bool TryGetValue(string name, out global::Loupe.Extensibility.Data.IEventMetricValueDefinition value)
		{
			if (this.IsReadOnly)
			{
				return this.m_Dictionary.TryGetValue(name, out value);
			}
			object @lock = this.m_Definition.Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_Dictionary.TryGetValue(name, out value);
			}
			return result;
		}

		// Token: 0x06001426 RID: 5158 RVA: 0x0003B578 File Offset: 0x00039778
		public int IndexOf(string name)
		{
			global::Loupe.Extensibility.Data.IEventMetricValueDefinition item = this[name];
			return this.IndexOf(item);
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x0003B598 File Offset: 0x00039798
		global::System.Collections.Generic.IEnumerator<global::Loupe.Extensibility.Data.IEventMetricValueDefinition> global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IEventMetricValueDefinition>.GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x0003B5AC File Offset: 0x000397AC
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x0003B5C0 File Offset: 0x000397C0
		public int IndexOf(global::Loupe.Extensibility.Data.IEventMetricValueDefinition item)
		{
			if (this.m_Definition.IsReadOnly)
			{
				int num = ((global::Gibraltar.Monitor.EventMetricValueDefinition)item).MyIndex;
				if (num < 0)
				{
					num = this.m_List.IndexOf(item);
					if (num >= 0)
					{
						((global::Gibraltar.Monitor.EventMetricValueDefinition)item).MyIndex = num;
					}
				}
				return num;
			}
			object @lock = this.m_Definition.Lock;
			int result;
			lock (@lock)
			{
				result = this.m_List.IndexOf(item);
			}
			return result;
		}

		// Token: 0x0600142A RID: 5162 RVA: 0x0003B650 File Offset: 0x00039850
		public void Insert(int index, global::Loupe.Extensibility.Data.IEventMetricValueDefinition item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600142B RID: 5163 RVA: 0x0003B658 File Offset: 0x00039858
		public void RemoveAt(int index)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x17000741 RID: 1857
		public global::Loupe.Extensibility.Data.IEventMetricValueDefinition this[int index]
		{
			get
			{
				if (this.IsReadOnly)
				{
					return this.m_List[index];
				}
				object @lock = this.m_Definition.Lock;
				global::Loupe.Extensibility.Data.IEventMetricValueDefinition result;
				lock (@lock)
				{
					result = this.m_List[index];
				}
				return result;
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000742 RID: 1858
		public global::Loupe.Extensibility.Data.IEventMetricValueDefinition this[string name]
		{
			get
			{
				if (this.IsReadOnly)
				{
					return this.m_Dictionary[name];
				}
				object @lock = this.m_Definition.Lock;
				global::Loupe.Extensibility.Data.IEventMetricValueDefinition result;
				lock (@lock)
				{
					result = this.m_Dictionary[name];
				}
				return result;
			}
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x0003B730 File Offset: 0x00039930
		public void Add(global::Loupe.Extensibility.Data.IEventMetricValueDefinition item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			if ((global::Gibraltar.Monitor.EventMetricDefinition)item.Definition != this.m_Definition)
			{
				throw new global::System.ArgumentException("The provided value definition item is not associated with our metric definition", "item");
			}
			object @lock = this.m_Definition.Lock;
			lock (@lock)
			{
				if (this.m_Dictionary.ContainsKey(item.Name))
				{
					throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "There is already a value definition item with the name {0}", new object[]
					{
						item.Name
					}), "item");
				}
				this.m_List.Add(item);
				this.m_Dictionary.Add(item.Name, item);
			}
			this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IEventMetricValueDefinitionCollection, global::Loupe.Extensibility.Data.IEventMetricValueDefinition>(this, item, global::Gibraltar.Monitor.CollectionAction.Added));
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x0003B814 File Offset: 0x00039A14
		public void Clear()
		{
			object @lock = this.m_Definition.Lock;
			lock (@lock)
			{
				if (this.IsReadOnly)
				{
					throw new global::System.NotSupportedException("The collection is read-only");
				}
				this.m_Dictionary.Clear();
				this.m_List.Clear();
			}
			this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IEventMetricValueDefinitionCollection, global::Loupe.Extensibility.Data.IEventMetricValueDefinition>(this, null, global::Gibraltar.Monitor.CollectionAction.Cleared));
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x0003B88C File Offset: 0x00039A8C
		public bool Contains(global::Loupe.Extensibility.Data.IEventMetricValueDefinition item)
		{
			if (this.IsReadOnly)
			{
				return this.m_List.Contains(item);
			}
			object @lock = this.m_Definition.Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_List.Contains(item);
			}
			return result;
		}

		// Token: 0x06001432 RID: 5170 RVA: 0x0003B8F0 File Offset: 0x00039AF0
		public void CopyTo(global::Loupe.Extensibility.Data.IEventMetricValueDefinition[] array, int arrayIndex)
		{
			if (this.IsReadOnly)
			{
				this.m_List.CopyTo(array, arrayIndex);
				return;
			}
			object @lock = this.m_Definition.Lock;
			lock (@lock)
			{
				this.m_List.CopyTo(array, arrayIndex);
			}
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x0003B954 File Offset: 0x00039B54
		public global::Loupe.Extensibility.Data.IEventMetricValueDefinition[] ToArray()
		{
			if (this.IsReadOnly)
			{
				return this.m_List.ToArray();
			}
			object @lock = this.m_Definition.Lock;
			global::Loupe.Extensibility.Data.IEventMetricValueDefinition[] result;
			lock (@lock)
			{
				result = this.m_List.ToArray();
			}
			return result;
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001434 RID: 5172 RVA: 0x0003B9B4 File Offset: 0x00039BB4
		public int Count
		{
			get
			{
				if (this.IsReadOnly)
				{
					return this.m_List.Count;
				}
				object @lock = this.m_Definition.Lock;
				int count;
				lock (@lock)
				{
					count = this.m_List.Count;
				}
				return count;
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x0003BA14 File Offset: 0x00039C14
		public bool IsReadOnly
		{
			get
			{
				return this.m_Definition.IsReadOnly;
			}
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x0003BA24 File Offset: 0x00039C24
		public bool Remove(global::Loupe.Extensibility.Data.IEventMetricValueDefinition item)
		{
			bool flag = false;
			object @lock = this.m_Definition.Lock;
			lock (@lock)
			{
				if (this.IsReadOnly)
				{
					throw new global::System.NotSupportedException("The collection is read-only");
				}
				if (this.m_Dictionary.ContainsKey(item.Name))
				{
					this.m_Dictionary.Remove(item.Name);
					flag = true;
				}
				if (this.m_List.Contains(item))
				{
					this.m_List.Remove(item);
					flag = true;
				}
			}
			if (flag)
			{
				this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IEventMetricValueDefinitionCollection, global::Loupe.Extensibility.Data.IEventMetricValueDefinition>(this, item, global::Gibraltar.Monitor.CollectionAction.Removed));
			}
			return flag;
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x0003BAD8 File Offset: 0x00039CD8
		public void SetAllIndex()
		{
			object @lock = this.m_Definition.Lock;
			lock (@lock)
			{
				if (this.IsReadOnly)
				{
					int num = 0;
					foreach (global::Loupe.Extensibility.Data.IEventMetricValueDefinition eventMetricValueDefinition in this.m_List)
					{
						((global::Gibraltar.Monitor.EventMetricValueDefinition)eventMetricValueDefinition).MyIndex = num;
						num++;
					}
				}
			}
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x0003BB70 File Offset: 0x00039D70
		protected virtual void OnCollectionChanged(global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IEventMetricValueDefinitionCollection, global::Loupe.Extensibility.Data.IEventMetricValueDefinition> e)
		{
			global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IEventMetricValueDefinitionCollection, global::Loupe.Extensibility.Data.IEventMetricValueDefinition>> collectionChanged = this.CollectionChanged;
			if (collectionChanged != null)
			{
				collectionChanged(this, e);
			}
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x0003BB98 File Offset: 0x00039D98
		internal global::Gibraltar.Monitor.EventMetricValueDefinition Add(global::Gibraltar.Monitor.Internal.EventMetricValueDefinitionPacket packet)
		{
			if (string.IsNullOrEmpty(packet.Name))
			{
				throw new global::System.ArgumentNullException("packet");
			}
			if (packet.Type == null)
			{
				throw new global::System.ArgumentNullException("packet");
			}
			object @lock = this.m_Definition.Lock;
			global::Gibraltar.Monitor.EventMetricValueDefinition result;
			lock (@lock)
			{
				if (this.m_Dictionary.ContainsKey(packet.Name))
				{
					throw new global::System.ArgumentException("There is already a value definition with the provided name.", "packet");
				}
				global::Gibraltar.Monitor.EventMetricValueDefinition eventMetricValueDefinition = new global::Gibraltar.Monitor.EventMetricValueDefinition(this.m_Definition, packet);
				this.Add(eventMetricValueDefinition);
				result = eventMetricValueDefinition;
			}
			return result;
		}

		// Token: 0x040006A2 RID: 1698
		private readonly global::System.Collections.Generic.Dictionary<string, global::Loupe.Extensibility.Data.IEventMetricValueDefinition> m_Dictionary = new global::System.Collections.Generic.Dictionary<string, global::Loupe.Extensibility.Data.IEventMetricValueDefinition>();

		// Token: 0x040006A3 RID: 1699
		private readonly global::System.Collections.Generic.List<global::Loupe.Extensibility.Data.IEventMetricValueDefinition> m_List = new global::System.Collections.Generic.List<global::Loupe.Extensibility.Data.IEventMetricValueDefinition>();

		// Token: 0x040006A4 RID: 1700
		private readonly global::Gibraltar.Monitor.EventMetricDefinition m_Definition;
	}
}
