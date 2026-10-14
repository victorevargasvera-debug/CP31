using System;
using System.Collections.Generic;

namespace Gibraltar
{
	// Token: 0x02000166 RID: 358
	internal class ItemListFilter<T>
	{
		// Token: 0x06000EDE RID: 3806 RVA: 0x00026720 File Offset: 0x00024920
		public ItemListFilter(global::Gibraltar.FilteredBindingList<T> target = null, global::Gibraltar.ListContains<T> comparer = null)
		{
			this.m_Target = target;
			this.m_Comparer = comparer;
			this.m_Predicate = ((this.m_Comparer == null) ? new global::System.Predicate<T>(this.PredicateDefaultComparer) : new global::System.Predicate<T>(this.PredicateWithComparer));
			if (this.m_Target != null)
			{
				this.m_Target.Filter = this.m_Predicate;
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000EDF RID: 3807 RVA: 0x00026790 File Offset: 0x00024990
		// (set) Token: 0x06000EE0 RID: 3808 RVA: 0x00026798 File Offset: 0x00024998
		public global::System.Collections.Generic.IList<T> Items
		{
			get
			{
				return this.m_List;
			}
			set
			{
				if (this.m_List == value)
				{
					return;
				}
				this.m_List = value;
				if (this.m_Target != null)
				{
					this.m_Target.Filter = this.m_Predicate;
				}
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000EE1 RID: 3809 RVA: 0x000267CC File Offset: 0x000249CC
		public global::System.Predicate<T> Predicate
		{
			get
			{
				return this.m_Predicate;
			}
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x000267D4 File Offset: 0x000249D4
		private bool PredicateWithComparer(T obj)
		{
			return this.m_List != null && this.m_List.Count != 0 && this.m_Comparer(this.m_List, obj);
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00026808 File Offset: 0x00024A08
		private bool PredicateDefaultComparer(T obj)
		{
			return this.m_List != null && this.m_List.Count != 0 && this.m_List.Contains(obj);
		}

		// Token: 0x040004F8 RID: 1272
		private readonly global::Gibraltar.FilteredBindingList<T> m_Target;

		// Token: 0x040004F9 RID: 1273
		private readonly global::Gibraltar.ListContains<T> m_Comparer;

		// Token: 0x040004FA RID: 1274
		private readonly global::System.Predicate<T> m_Predicate;

		// Token: 0x040004FB RID: 1275
		private global::System.Collections.Generic.IList<T> m_List;
	}
}
