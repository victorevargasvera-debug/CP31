using System;
using System.Collections;
using System.Collections.Generic;

namespace Gibraltar.Serialization
{
	// Token: 0x020000F4 RID: 244
	internal class FieldDefinitionCollection : global::System.Collections.Generic.IList<global::Gibraltar.Serialization.FieldDefinition>, global::System.Collections.Generic.ICollection<global::Gibraltar.Serialization.FieldDefinition>, global::System.Collections.Generic.IEnumerable<global::Gibraltar.Serialization.FieldDefinition>, global::System.Collections.IEnumerable
	{
		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x000186B0 File Offset: 0x000168B0
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x000186B8 File Offset: 0x000168B8
		public bool Locked
		{
			get
			{
				return this.m_Locked;
			}
			set
			{
				if (value)
				{
					this.m_Locked = value;
				}
			}
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x000186C8 File Offset: 0x000168C8
		public global::System.Collections.Generic.IEnumerator<global::Gibraltar.Serialization.FieldDefinition> GetEnumerator()
		{
			return this.m_DefinitionsList.GetEnumerator();
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x000186DC File Offset: 0x000168DC
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x000186E4 File Offset: 0x000168E4
		public void Add(string fieldName, global::System.Type type)
		{
			this.Add(fieldName, global::Gibraltar.Serialization.PacketDefinition.GetSerializableType(type));
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x000186F4 File Offset: 0x000168F4
		public void Add(string fieldName, global::Gibraltar.Serialization.FieldType fieldType)
		{
			global::Gibraltar.Serialization.FieldDefinition item = new global::Gibraltar.Serialization.FieldDefinition(fieldName, fieldType);
			this.Add(item);
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00018714 File Offset: 0x00016914
		public void Add(global::Gibraltar.Serialization.FieldDefinition item)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_DefinitionsByName.ContainsKey(item.Name))
				{
					throw new global::System.ArgumentException("There is already a field definition with the provided name.", "item");
				}
				this.m_DefinitionsByName.Add(item.Name, item);
				this.m_DefinitionsList.Add(item);
				this.m_IndexByName.Add(item.Name, this.m_DefinitionsList.Count - 1);
			}
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x000187AC File Offset: 0x000169AC
		public void Clear()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_DefinitionsByName.Clear();
				this.m_DefinitionsList.Clear();
				this.m_IndexByName.Clear();
			}
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x00018804 File Offset: 0x00016A04
		public bool Contains(global::Gibraltar.Serialization.FieldDefinition item)
		{
			return this.m_DefinitionsByName.ContainsKey(item.Name);
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x00018818 File Offset: 0x00016A18
		public bool ContainsKey(string fieldName)
		{
			return this.m_DefinitionsByName.ContainsKey(fieldName);
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x00018828 File Offset: 0x00016A28
		public void CopyTo(global::Gibraltar.Serialization.FieldDefinition[] array, int arrayIndex)
		{
			this.m_DefinitionsList.CopyTo(array, arrayIndex);
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x00018838 File Offset: 0x00016A38
		public bool Remove(global::Gibraltar.Serialization.FieldDefinition item)
		{
			bool result = false;
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_DefinitionsList.Remove(item))
				{
					result = true;
				}
				if (this.m_DefinitionsByName.Remove(item.Name))
				{
					result = true;
				}
				this.m_IndexByName.Clear();
				int num = 0;
				foreach (global::Gibraltar.Serialization.FieldDefinition fieldDefinition in this.m_DefinitionsList)
				{
					this.m_IndexByName.Add(fieldDefinition.Name, num++);
				}
			}
			return result;
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x00018900 File Offset: 0x00016B00
		public int Count
		{
			get
			{
				return this.m_DefinitionsList.Count;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000A01 RID: 2561 RVA: 0x00018910 File Offset: 0x00016B10
		public bool IsReadOnly
		{
			get
			{
				return this.m_Locked;
			}
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00018918 File Offset: 0x00016B18
		public int IndexOf(global::Gibraltar.Serialization.FieldDefinition item)
		{
			return this.m_DefinitionsList.IndexOf(item);
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00018928 File Offset: 0x00016B28
		public int IndexOf(string fieldName)
		{
			int result;
			try
			{
				result = this.m_IndexByName[fieldName];
			}
			catch (global::System.Exception)
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x00018960 File Offset: 0x00016B60
		public void Insert(int index, global::Gibraltar.Serialization.FieldDefinition item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00018968 File Offset: 0x00016B68
		public void RemoveAt(int index)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x17000423 RID: 1059
		public global::Gibraltar.Serialization.FieldDefinition this[int index]
		{
			get
			{
				return this.m_DefinitionsList[index];
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000424 RID: 1060
		public global::Gibraltar.Serialization.FieldDefinition this[string fieldName]
		{
			get
			{
				return this.m_DefinitionsByName[fieldName];
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x04000292 RID: 658
		private global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Serialization.FieldDefinition> m_DefinitionsByName = new global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Serialization.FieldDefinition>();

		// Token: 0x04000293 RID: 659
		private global::System.Collections.Generic.Dictionary<string, int> m_IndexByName = new global::System.Collections.Generic.Dictionary<string, int>();

		// Token: 0x04000294 RID: 660
		private global::System.Collections.Generic.List<global::Gibraltar.Serialization.FieldDefinition> m_DefinitionsList = new global::System.Collections.Generic.List<global::Gibraltar.Serialization.FieldDefinition>();

		// Token: 0x04000295 RID: 661
		private readonly object m_Lock = new object();

		// Token: 0x04000296 RID: 662
		private bool m_Locked;
	}
}
