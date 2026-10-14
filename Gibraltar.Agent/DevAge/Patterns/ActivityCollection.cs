using System;
using System.Collections;

namespace DevAge.Patterns
{
	// Token: 0x020002AC RID: 684
	internal class ActivityCollection : global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x060021EF RID: 8687 RVA: 0x0007832C File Offset: 0x0007652C
		public ActivityCollection(global::DevAge.Patterns.IActivity parentActivity)
		{
			this.mParentActivity = parentActivity;
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x00078348 File Offset: 0x00076548
		private void CheckParent()
		{
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x060021F1 RID: 8689 RVA: 0x0007834C File Offset: 0x0007654C
		public int Count
		{
			get
			{
				return this.mList.Count;
			}
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x0007835C File Offset: 0x0007655C
		public virtual bool Contains(global::DevAge.Patterns.IActivity value)
		{
			return this.mList.Contains(value);
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x0007836C File Offset: 0x0007656C
		public virtual int IndexOf(global::DevAge.Patterns.IActivity value)
		{
			return this.mList.IndexOf(value);
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x0007837C File Offset: 0x0007657C
		public virtual void Add(global::DevAge.Patterns.IActivity value)
		{
			this.Insert(this.Count, value);
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x0007838C File Offset: 0x0007658C
		public virtual void Insert(int index, global::DevAge.Patterns.IActivity value)
		{
			this.CheckParent();
			this.mList.Insert(index, value);
			value.Parent = this.mParentActivity;
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x000783B0 File Offset: 0x000765B0
		public virtual void Remove(global::DevAge.Patterns.IActivity value)
		{
			this.CheckParent();
			this.mList.Remove(value);
			value.Parent = null;
		}

		// Token: 0x17000B01 RID: 2817
		public virtual global::DevAge.Patterns.IActivity this[int index]
		{
			get
			{
				return (global::DevAge.Patterns.IActivity)this.mList[index];
			}
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x000783E0 File Offset: 0x000765E0
		public virtual global::DevAge.Patterns.ActivityCollection.Enumerator GetEnumerator()
		{
			return new global::DevAge.Patterns.ActivityCollection.Enumerator(this);
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x060021F9 RID: 8697 RVA: 0x000783E8 File Offset: 0x000765E8
		public bool IsSynchronized
		{
			get
			{
				return this.mList.IsSynchronized;
			}
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x000783F8 File Offset: 0x000765F8
		public void CopyTo(global::System.Array array, int index)
		{
			this.mList.CopyTo(array, index);
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x060021FB RID: 8699 RVA: 0x00078408 File Offset: 0x00076608
		public object SyncRoot
		{
			get
			{
				return this.mList.SyncRoot;
			}
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x00078418 File Offset: 0x00076618
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000C57 RID: 3159
		private global::System.Collections.ArrayList mList = new global::System.Collections.ArrayList();

		// Token: 0x04000C58 RID: 3160
		private global::DevAge.Patterns.IActivity mParentActivity;

		// Token: 0x020004C1 RID: 1217
		public class Enumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x06003402 RID: 13314 RVA: 0x000BB6E4 File Offset: 0x000B98E4
			public Enumerator(global::DevAge.Patterns.ActivityCollection collection)
			{
				this.wrapped = collection.mList.GetEnumerator();
			}

			// Token: 0x17000EFD RID: 3837
			// (get) Token: 0x06003403 RID: 13315 RVA: 0x000BB700 File Offset: 0x000B9900
			public global::DevAge.Patterns.IActivity Current
			{
				get
				{
					return (global::DevAge.Patterns.IActivity)this.wrapped.Current;
				}
			}

			// Token: 0x17000EFE RID: 3838
			// (get) Token: 0x06003404 RID: 13316 RVA: 0x000BB714 File Offset: 0x000B9914
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return (global::DevAge.Patterns.IActivity)this.wrapped.Current;
				}
			}

			// Token: 0x06003405 RID: 13317 RVA: 0x000BB728 File Offset: 0x000B9928
			public bool MoveNext()
			{
				return this.wrapped.MoveNext();
			}

			// Token: 0x06003406 RID: 13318 RVA: 0x000BB738 File Offset: 0x000B9938
			public void Reset()
			{
				this.wrapped.Reset();
			}

			// Token: 0x040013B3 RID: 5043
			private global::System.Collections.IEnumerator wrapped;
		}
	}
}
