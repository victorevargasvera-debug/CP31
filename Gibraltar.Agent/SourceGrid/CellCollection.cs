using System;
using System.Collections;
using SourceGrid.Cells;

namespace SourceGrid
{
	// Token: 0x02000354 RID: 852
	internal class CellCollection : global::System.Collections.CollectionBase
	{
		// Token: 0x060029B7 RID: 10679 RVA: 0x0008F408 File Offset: 0x0008D608
		public CellCollection()
		{
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x0008F410 File Offset: 0x0008D610
		public CellCollection(global::SourceGrid.Cells.ICellVirtual[] items)
		{
			this.AddRange(items);
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x0008F420 File Offset: 0x0008D620
		public CellCollection(global::SourceGrid.CellCollection items)
		{
			this.AddRange(items);
		}

		// Token: 0x060029BA RID: 10682 RVA: 0x0008F430 File Offset: 0x0008D630
		public virtual void AddRange(global::SourceGrid.Cells.ICellVirtual[] items)
		{
			foreach (global::SourceGrid.Cells.ICellVirtual value in items)
			{
				base.List.Add(value);
			}
		}

		// Token: 0x060029BB RID: 10683 RVA: 0x0008F46C File Offset: 0x0008D66C
		public virtual void AddRange(global::SourceGrid.CellCollection items)
		{
			foreach (global::SourceGrid.Cells.ICellVirtual value in items)
			{
				base.List.Add(value);
			}
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x0008F4CC File Offset: 0x0008D6CC
		public virtual void Add(global::SourceGrid.Cells.ICellVirtual value)
		{
			base.List.Add(value);
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x0008F4DC File Offset: 0x0008D6DC
		public virtual bool Contains(global::SourceGrid.Cells.ICellVirtual value)
		{
			return base.List.Contains(value);
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x0008F4EC File Offset: 0x0008D6EC
		public virtual int IndexOf(global::SourceGrid.Cells.ICellVirtual value)
		{
			return base.List.IndexOf(value);
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x0008F4FC File Offset: 0x0008D6FC
		public virtual void Insert(int index, global::SourceGrid.Cells.ICellVirtual value)
		{
			base.List.Insert(index, value);
		}

		// Token: 0x17000C73 RID: 3187
		public virtual global::SourceGrid.Cells.ICellVirtual this[int index]
		{
			get
			{
				return (global::SourceGrid.Cells.ICellVirtual)base.List[index];
			}
			set
			{
				base.List[index] = value;
			}
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x0008F530 File Offset: 0x0008D730
		public virtual void Remove(global::SourceGrid.Cells.ICellVirtual value)
		{
			base.List.Remove(value);
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x0008F540 File Offset: 0x0008D740
		public new virtual global::SourceGrid.CellCollection.Enumerator GetEnumerator()
		{
			return new global::SourceGrid.CellCollection.Enumerator(this);
		}

		// Token: 0x020004D0 RID: 1232
		public class Enumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x06003443 RID: 13379 RVA: 0x000BC0F8 File Offset: 0x000BA2F8
			public Enumerator(global::SourceGrid.CellCollection collection)
			{
				this.wrapped = collection.GetEnumerator();
			}

			// Token: 0x17000F0B RID: 3851
			// (get) Token: 0x06003444 RID: 13380 RVA: 0x000BC10C File Offset: 0x000BA30C
			public global::SourceGrid.Cells.ICellVirtual Current
			{
				get
				{
					return (global::SourceGrid.Cells.ICellVirtual)this.wrapped.Current;
				}
			}

			// Token: 0x17000F0C RID: 3852
			// (get) Token: 0x06003445 RID: 13381 RVA: 0x000BC120 File Offset: 0x000BA320
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return (global::SourceGrid.Cells.ICellVirtual)this.wrapped.Current;
				}
			}

			// Token: 0x06003446 RID: 13382 RVA: 0x000BC134 File Offset: 0x000BA334
			public bool MoveNext()
			{
				return this.wrapped.MoveNext();
			}

			// Token: 0x06003447 RID: 13383 RVA: 0x000BC144 File Offset: 0x000BA344
			public void Reset()
			{
				this.wrapped.Reset();
			}

			// Token: 0x040013CC RID: 5068
			private global::System.Collections.IEnumerator wrapped;
		}
	}
}
