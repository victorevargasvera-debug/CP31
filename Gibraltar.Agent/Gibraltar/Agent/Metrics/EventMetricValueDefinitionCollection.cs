using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Agent.Metrics
{
	// Token: 0x02000024 RID: 36
	internal sealed class EventMetricValueDefinitionCollection : global::System.Collections.Generic.IList<global::Gibraltar.Agent.Metrics.EventMetricValueDefinition>, global::System.Collections.Generic.ICollection<global::Gibraltar.Agent.Metrics.EventMetricValueDefinition>, global::System.Collections.Generic.IEnumerable<global::Gibraltar.Agent.Metrics.EventMetricValueDefinition>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000224 RID: 548 RVA: 0x000079B8 File Offset: 0x00005BB8
		internal EventMetricValueDefinitionCollection(global::Gibraltar.Agent.Metrics.EventMetricDefinition definition)
		{
			this.m_Definition = definition;
			this.m_WrappedCollection = (global::Gibraltar.Monitor.EventMetricValueDefinitionCollection)definition.WrappedDefinition.Values;
			this.m_WrappedCollection.CollectionChanged += this.WrappedCollection_CollectionChanged;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00007A10 File Offset: 0x00005C10
		public global::Gibraltar.Agent.Metrics.EventMetricValueDefinition Add(string name, global::System.Type type)
		{
			return this.Add(name, type, global::Gibraltar.Agent.Metrics.SummaryFunction.Count, null, null, null);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00007A20 File Offset: 0x00005C20
		public global::Gibraltar.Agent.Metrics.EventMetricValueDefinition Add(string name, global::System.Type type, global::Gibraltar.Agent.Metrics.SummaryFunction summaryFunction, string unitCaption, string caption, string description)
		{
			object @lock = this.m_Definition.Lock;
			global::Gibraltar.Agent.Metrics.EventMetricValueDefinition result;
			lock (@lock)
			{
				if (this.IsReadOnly)
				{
					throw new global::System.Data.ReadOnlyException("The collection is read-only");
				}
				if (string.IsNullOrEmpty(name))
				{
					throw new global::System.ArgumentNullException("name");
				}
				if (type == null)
				{
					throw new global::System.ArgumentNullException("type");
				}
				if (this.ContainsKey(name))
				{
					throw new global::System.ArgumentException("There is already a value definition with the provided name.", "name");
				}
				global::Gibraltar.Agent.Metrics.EventMetricValueDefinition eventMetricValueDefinition = this.Externalize(this.m_WrappedCollection.Add(name, type, caption, description));
				eventMetricValueDefinition.SummaryFunction = summaryFunction;
				eventMetricValueDefinition.UnitCaption = unitCaption;
				result = eventMetricValueDefinition;
			}
			return result;
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00007ADC File Offset: 0x00005CDC
		public global::Gibraltar.Agent.Metrics.EventMetricDefinition Definition
		{
			get
			{
				return this.m_Definition;
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00007AE4 File Offset: 0x00005CE4
		public bool ContainsKey(string name)
		{
			return this.m_WrappedCollection.ContainsKey(name);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00007AF4 File Offset: 0x00005CF4
		public bool TryGetValue(string name, out global::Gibraltar.Agent.Metrics.EventMetricValueDefinition value)
		{
			object @lock = this.m_Definition.Lock;
			bool result;
			lock (@lock)
			{
				global::Loupe.Extensibility.Data.IEventMetricValueDefinition valueDefinition;
				bool flag = this.m_WrappedCollection.TryGetValue(name, out valueDefinition);
				value = (flag ? this.Externalize(valueDefinition) : null);
				result = flag;
			}
			return result;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00007B58 File Offset: 0x00005D58
		global::System.Collections.Generic.IEnumerator<global::Gibraltar.Agent.Metrics.EventMetricValueDefinition> global::System.Collections.Generic.IEnumerable<global::Gibraltar.Agent.Metrics.EventMetricValueDefinition>.GetEnumerator()
		{
			global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IEventMetricValueDefinition> wrappedCollection = this.m_WrappedCollection;
			return new global::Gibraltar.Agent.Metrics.EventMetricValueDefinitionCollection.Enumerator(this, wrappedCollection.GetEnumerator());
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00007B7C File Offset: 0x00005D7C
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IEventMetricValueDefinition> wrappedCollection = this.m_WrappedCollection;
			return new global::Gibraltar.Agent.Metrics.EventMetricValueDefinitionCollection.Enumerator(this, wrappedCollection.GetEnumerator());
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00007BA0 File Offset: 0x00005DA0
		public int IndexOf(global::Gibraltar.Agent.Metrics.EventMetricValueDefinition item)
		{
			object @lock = this.m_Definition.Lock;
			int result;
			lock (@lock)
			{
				result = this.m_WrappedCollection.IndexOf(item.WrappedValueDefinition);
			}
			return result;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00007BF0 File Offset: 0x00005DF0
		public void Insert(int index, global::Gibraltar.Agent.Metrics.EventMetricValueDefinition item)
		{
			throw new global::System.NotSupportedException("Setting an object by index is not supported.");
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00007BFC File Offset: 0x00005DFC
		public void RemoveAt(int index)
		{
			throw new global::System.NotSupportedException("Removing an object by index is not supported.");
		}

		// Token: 0x170000B4 RID: 180
		public global::Gibraltar.Agent.Metrics.EventMetricValueDefinition this[int index]
		{
			get
			{
				object @lock = this.m_Definition.Lock;
				global::Gibraltar.Agent.Metrics.EventMetricValueDefinition result;
				lock (@lock)
				{
					result = this.Externalize(this.m_WrappedCollection[index]);
				}
				return result;
			}
			set
			{
				throw new global::System.NotSupportedException("Setting an object by index is not supported");
			}
		}

		// Token: 0x170000B5 RID: 181
		public global::Gibraltar.Agent.Metrics.EventMetricValueDefinition this[string name]
		{
			get
			{
				object @lock = this.m_Definition.Lock;
				global::Gibraltar.Agent.Metrics.EventMetricValueDefinition result;
				lock (@lock)
				{
					result = this.Externalize(this.m_WrappedCollection[name]);
				}
				return result;
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00007CB4 File Offset: 0x00005EB4
		public void Add(global::Gibraltar.Agent.Metrics.EventMetricValueDefinition item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			if (item.Definition != this.m_Definition)
			{
				throw new global::System.ArgumentException("The provided value definition item is not associated with our metric definition", "item");
			}
			object @lock = this.m_Definition.Lock;
			lock (@lock)
			{
				if (this.ContainsKey(item.Name))
				{
					throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "There is already a value definition item with the name {0}", new object[]
					{
						item.Name
					}), "item");
				}
				this.m_WrappedCollection.Add(item.WrappedValueDefinition);
				this.m_Externalized[item.WrappedValueDefinition] = item;
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00007D80 File Offset: 0x00005F80
		public void Clear()
		{
			object @lock = this.m_Definition.Lock;
			lock (@lock)
			{
				if (this.IsReadOnly)
				{
					throw new global::System.Data.ReadOnlyException("The collection is read-only");
				}
				this.m_WrappedCollection.Clear();
				this.m_Externalized.Clear();
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00007DE8 File Offset: 0x00005FE8
		public bool Contains(global::Gibraltar.Agent.Metrics.EventMetricValueDefinition item)
		{
			return this.m_WrappedCollection.Contains(item.WrappedValueDefinition);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00007DFC File Offset: 0x00005FFC
		public void CopyTo(global::Gibraltar.Agent.Metrics.EventMetricValueDefinition[] array, int arrayIndex)
		{
			int num = array.Length - arrayIndex;
			if (num <= 0)
			{
				return;
			}
			object @lock = this.m_Definition.Lock;
			lock (@lock)
			{
				global::Loupe.Extensibility.Data.IEventMetricValueDefinition[] array2 = this.m_WrappedCollection.ToArray();
				if (num > array2.Length)
				{
					num = array2.Length;
				}
				for (int i = 0; i < num; i++)
				{
					array[arrayIndex + i] = this.Externalize(array2[i]);
				}
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00007E84 File Offset: 0x00006084
		public global::Gibraltar.Agent.Metrics.EventMetricValueDefinition[] ToArray()
		{
			object @lock = this.m_Definition.Lock;
			global::Gibraltar.Agent.Metrics.EventMetricValueDefinition[] result;
			lock (@lock)
			{
				if (this.m_ValuesList == null)
				{
					global::Loupe.Extensibility.Data.IEventMetricValueDefinition[] array = this.m_WrappedCollection.ToArray();
					int num = array.Length;
					this.m_ValuesList = new global::System.Collections.Generic.List<global::Gibraltar.Agent.Metrics.EventMetricValueDefinition>(num);
					for (int i = 0; i < num; i++)
					{
						this.m_ValuesList[i] = this.Externalize(array[i]);
					}
				}
				result = this.m_ValuesList.ToArray();
			}
			return result;
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00007F20 File Offset: 0x00006120
		public int Count
		{
			get
			{
				return this.m_WrappedCollection.Count;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00007F30 File Offset: 0x00006130
		public bool IsReadOnly
		{
			get
			{
				return this.m_Definition.IsReadOnly;
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00007F40 File Offset: 0x00006140
		public bool Remove(global::Gibraltar.Agent.Metrics.EventMetricValueDefinition item)
		{
			object @lock = this.m_Definition.Lock;
			bool result;
			lock (@lock)
			{
				if (this.IsReadOnly)
				{
					throw new global::System.Data.ReadOnlyException("The collection is read-only");
				}
				result = this.m_WrappedCollection.Remove(item.WrappedValueDefinition);
			}
			return result;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00007FA4 File Offset: 0x000061A4
		private void WrappedCollection_CollectionChanged(object sender, global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IEventMetricValueDefinitionCollection, global::Loupe.Extensibility.Data.IEventMetricValueDefinition> e1)
		{
			object @lock = this.m_Definition.Lock;
			lock (@lock)
			{
				this.m_ValuesList = null;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00007FE8 File Offset: 0x000061E8
		internal global::Gibraltar.Monitor.EventMetricValueDefinitionCollection WrappedCollection
		{
			get
			{
				return this.m_WrappedCollection;
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00007FF0 File Offset: 0x000061F0
		internal global::Gibraltar.Agent.Metrics.EventMetricValueDefinition Externalize(global::Loupe.Extensibility.Data.IEventMetricValueDefinition valueDefinition)
		{
			if (valueDefinition == null)
			{
				return null;
			}
			object @lock = this.m_Definition.Lock;
			global::Gibraltar.Agent.Metrics.EventMetricValueDefinition result;
			lock (@lock)
			{
				global::Gibraltar.Agent.Metrics.EventMetricValueDefinition eventMetricValueDefinition;
				if (!this.m_Externalized.TryGetValue(valueDefinition, out eventMetricValueDefinition))
				{
					eventMetricValueDefinition = new global::Gibraltar.Agent.Metrics.EventMetricValueDefinition(this.m_Definition, (global::Gibraltar.Monitor.EventMetricValueDefinition)valueDefinition);
					this.m_Externalized[valueDefinition] = eventMetricValueDefinition;
				}
				result = eventMetricValueDefinition;
			}
			return result;
		}

		// Token: 0x04000079 RID: 121
		private readonly global::Gibraltar.Monitor.EventMetricValueDefinitionCollection m_WrappedCollection;

		// Token: 0x0400007A RID: 122
		private readonly global::System.Collections.Generic.Dictionary<global::Loupe.Extensibility.Data.IEventMetricValueDefinition, global::Gibraltar.Agent.Metrics.EventMetricValueDefinition> m_Externalized = new global::System.Collections.Generic.Dictionary<global::Loupe.Extensibility.Data.IEventMetricValueDefinition, global::Gibraltar.Agent.Metrics.EventMetricValueDefinition>();

		// Token: 0x0400007B RID: 123
		private readonly global::Gibraltar.Agent.Metrics.EventMetricDefinition m_Definition;

		// Token: 0x0400007C RID: 124
		private global::System.Collections.Generic.List<global::Gibraltar.Agent.Metrics.EventMetricValueDefinition> m_ValuesList;

		// Token: 0x02000486 RID: 1158
		private class Enumerator : global::System.Collections.Generic.IEnumerator<global::Gibraltar.Agent.Metrics.EventMetricValueDefinition>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x060032DD RID: 13021 RVA: 0x000B948C File Offset: 0x000B768C
			public Enumerator(global::Gibraltar.Agent.Metrics.EventMetricValueDefinitionCollection collection, global::System.Collections.Generic.IEnumerator<global::Loupe.Extensibility.Data.IEventMetricValueDefinition> enumerator)
			{
				this.m_Collection = collection;
				this.m_Enumerator = enumerator;
			}

			// Token: 0x060032DE RID: 13022 RVA: 0x000B94A4 File Offset: 0x000B76A4
			public void Dispose()
			{
				this.m_Enumerator.Dispose();
			}

			// Token: 0x060032DF RID: 13023 RVA: 0x000B94B4 File Offset: 0x000B76B4
			public bool MoveNext()
			{
				return this.m_Enumerator.MoveNext();
			}

			// Token: 0x060032E0 RID: 13024 RVA: 0x000B94C4 File Offset: 0x000B76C4
			public void Reset()
			{
				this.m_Enumerator.Reset();
			}

			// Token: 0x17000EA9 RID: 3753
			// (get) Token: 0x060032E1 RID: 13025 RVA: 0x000B94D4 File Offset: 0x000B76D4
			public global::Gibraltar.Agent.Metrics.EventMetricValueDefinition Current
			{
				get
				{
					return this.m_Collection.Externalize(this.m_Enumerator.Current);
				}
			}

			// Token: 0x17000EAA RID: 3754
			// (get) Token: 0x060032E2 RID: 13026 RVA: 0x000B94EC File Offset: 0x000B76EC
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x040012E0 RID: 4832
			private readonly global::System.Collections.Generic.IEnumerator<global::Loupe.Extensibility.Data.IEventMetricValueDefinition> m_Enumerator;

			// Token: 0x040012E1 RID: 4833
			private readonly global::Gibraltar.Agent.Metrics.EventMetricValueDefinitionCollection m_Collection;
		}
	}
}
