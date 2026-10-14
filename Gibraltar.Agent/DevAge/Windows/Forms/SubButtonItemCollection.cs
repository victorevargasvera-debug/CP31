using System;
using System.Collections;

namespace DevAge.Windows.Forms
{
	// Token: 0x02000324 RID: 804
	internal class SubButtonItemCollection : global::System.Collections.CollectionBase
	{
		// Token: 0x06002600 RID: 9728 RVA: 0x00083E80 File Offset: 0x00082080
		public SubButtonItemCollection()
		{
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x00083E88 File Offset: 0x00082088
		public SubButtonItemCollection(global::DevAge.Windows.Forms.SubButtonItem[] items)
		{
			this.AddRange(items);
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x00083E98 File Offset: 0x00082098
		public SubButtonItemCollection(global::DevAge.Windows.Forms.SubButtonItemCollection items)
		{
			this.AddRange(items);
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x00083EA8 File Offset: 0x000820A8
		public virtual void AddRange(global::DevAge.Windows.Forms.SubButtonItem[] items)
		{
			foreach (global::DevAge.Windows.Forms.SubButtonItem value in items)
			{
				base.List.Add(value);
			}
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x00083EE4 File Offset: 0x000820E4
		public virtual void AddRange(global::DevAge.Windows.Forms.SubButtonItemCollection items)
		{
			foreach (global::DevAge.Windows.Forms.SubButtonItem value in items)
			{
				base.List.Add(value);
			}
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x00083F44 File Offset: 0x00082144
		public virtual void Add(global::DevAge.Windows.Forms.SubButtonItem value)
		{
			base.List.Add(value);
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x00083F54 File Offset: 0x00082154
		public virtual bool Contains(global::DevAge.Windows.Forms.SubButtonItem value)
		{
			return base.List.Contains(value);
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x00083F64 File Offset: 0x00082164
		public virtual int IndexOf(global::DevAge.Windows.Forms.SubButtonItem value)
		{
			return base.List.IndexOf(value);
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x00083F74 File Offset: 0x00082174
		public virtual void Insert(int index, global::DevAge.Windows.Forms.SubButtonItem value)
		{
			base.List.Insert(index, value);
		}

		// Token: 0x17000BD1 RID: 3025
		public virtual global::DevAge.Windows.Forms.SubButtonItem this[int index]
		{
			get
			{
				return (global::DevAge.Windows.Forms.SubButtonItem)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x00083FA8 File Offset: 0x000821A8
		public virtual void Remove(global::DevAge.Windows.Forms.SubButtonItem value)
		{
			base.List.Remove(value);
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x00083FB8 File Offset: 0x000821B8
		public new virtual global::DevAge.Windows.Forms.SubButtonItemCollection.Enumerator GetEnumerator()
		{
			return new global::DevAge.Windows.Forms.SubButtonItemCollection.Enumerator(this);
		}

		// Token: 0x020004C3 RID: 1219
		public class Enumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x06003408 RID: 13320 RVA: 0x000BB784 File Offset: 0x000B9984
			public Enumerator(global::DevAge.Windows.Forms.SubButtonItemCollection collection)
			{
				this.wrapped = collection.GetEnumerator();
			}

			// Token: 0x17000EFF RID: 3839
			// (get) Token: 0x06003409 RID: 13321 RVA: 0x000BB798 File Offset: 0x000B9998
			public global::DevAge.Windows.Forms.SubButtonItem Current
			{
				get
				{
					return (global::DevAge.Windows.Forms.SubButtonItem)this.wrapped.Current;
				}
			}

			// Token: 0x17000F00 RID: 3840
			// (get) Token: 0x0600340A RID: 13322 RVA: 0x000BB7AC File Offset: 0x000B99AC
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return (global::DevAge.Windows.Forms.SubButtonItem)this.wrapped.Current;
				}
			}

			// Token: 0x0600340B RID: 13323 RVA: 0x000BB7C0 File Offset: 0x000B99C0
			public bool MoveNext()
			{
				return this.wrapped.MoveNext();
			}

			// Token: 0x0600340C RID: 13324 RVA: 0x000BB7D0 File Offset: 0x000B99D0
			public void Reset()
			{
				this.wrapped.Reset();
			}

			// Token: 0x040013B7 RID: 5047
			private global::System.Collections.IEnumerator wrapped;
		}
	}
}
