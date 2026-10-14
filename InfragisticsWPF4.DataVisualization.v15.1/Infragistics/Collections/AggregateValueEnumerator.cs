using System;
using System.Collections;

namespace Infragistics.Collections
{
	// Token: 0x02000004 RID: 4
	internal class AggregateValueEnumerator : global::System.Collections.IEnumerator
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000024F5 File Offset: 0x000006F5
		public AggregateValueEnumerator(global::Infragistics.Collections.AggregateValueCollection parent)
		{
			if (parent == null)
			{
				throw new global::System.ArgumentNullException("parent");
			}
			this.Parent = parent;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002512 File Offset: 0x00000712
		// (set) Token: 0x06000011 RID: 17 RVA: 0x0000251A File Offset: 0x0000071A
		private global::Infragistics.Collections.AggregateValueCollection Parent { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002523 File Offset: 0x00000723
		// (set) Token: 0x06000013 RID: 19 RVA: 0x0000252B File Offset: 0x0000072B
		private int CurrentValueSourceIndex { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002534 File Offset: 0x00000734
		// (set) Token: 0x06000015 RID: 21 RVA: 0x0000253C File Offset: 0x0000073C
		private global::System.Collections.IEnumerator CurrentValueSourceEnumerator { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002545 File Offset: 0x00000745
		public object Current
		{
			get
			{
				if (this.CurrentValueSourceEnumerator != null)
				{
					return this.CurrentValueSourceEnumerator.Current;
				}
				return null;
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000255C File Offset: 0x0000075C
		public bool MoveNext()
		{
			if (this.Parent.ItemsSources == null)
			{
				return false;
			}
			if (this.CurrentValueSourceEnumerator != null)
			{
				bool flag = this.CurrentValueSourceEnumerator.MoveNext();
				if (flag)
				{
					return true;
				}
				this.CurrentValueSourceIndex++;
			}
			if (this.Parent.ItemsSources.Count > this.CurrentValueSourceIndex)
			{
				global::Infragistics.Collections.AggregateValueSource aggregateValueSource = this.Parent.ItemsSources[this.CurrentValueSourceIndex];
				if (aggregateValueSource.ValueColumn != null)
				{
					this.CurrentValueSourceEnumerator = aggregateValueSource.ValueColumn.GetEnumerator();
					return this.MoveNext();
				}
			}
			return false;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000025EF File Offset: 0x000007EF
		public void Reset()
		{
			this.CurrentValueSourceEnumerator = null;
			this.CurrentValueSourceIndex = 0;
		}
	}
}
