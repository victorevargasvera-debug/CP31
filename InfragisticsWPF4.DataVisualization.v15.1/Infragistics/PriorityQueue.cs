using System;
using System.ComponentModel;

namespace Infragistics
{
	// Token: 0x020000AE RID: 174
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class PriorityQueue<T>
	{
		// Token: 0x06000781 RID: 1921 RVA: 0x000239F4 File Offset: 0x00021BF4
		public PriorityQueue()
		{
			this.Count = 0;
			this.Capacity = 15;
			this.heap = new global::Infragistics.PriorityQueue<T>.HeapItem[this.Capacity];
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00023A1C File Offset: 0x00021C1C
		public T Dequeue()
		{
			if (this.Count == 0)
			{
				throw new global::System.InvalidOperationException();
			}
			T item = this.heap[0].Item;
			this.Count--;
			this.TrickleDown(0, this.heap[this.Count]);
			return item;
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00023A75 File Offset: 0x00021C75
		public void Enqueue(T item, double priority)
		{
			if (this.Count == this.Capacity)
			{
				this.GrowHeap();
			}
			this.Count++;
			this.BubbleUp(this.Count - 1, new global::Infragistics.PriorityQueue<T>.HeapItem(item, priority));
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00023AAE File Offset: 0x00021CAE
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00023AB6 File Offset: 0x00021CB6
		public int Count { get; private set; }

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x00023ABF File Offset: 0x00021CBF
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x00023AC7 File Offset: 0x00021CC7
		private int Capacity { get; set; }

		// Token: 0x06000788 RID: 1928 RVA: 0x00023AD0 File Offset: 0x00021CD0
		private void BubbleUp(int index, global::Infragistics.PriorityQueue<T>.HeapItem he)
		{
			int num = global::Infragistics.PriorityQueue<T>.Parent(index);
			while (index > 0 && this.heap[num].Priority < he.Priority)
			{
				this.heap[index] = this.heap[num];
				index = num;
				num = global::Infragistics.PriorityQueue<T>.Parent(index);
			}
			this.heap[index] = he;
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00023B44 File Offset: 0x00021D44
		private void TrickleDown(int index, global::Infragistics.PriorityQueue<T>.HeapItem he)
		{
			for (int i = global::Infragistics.PriorityQueue<T>.LeftChild(index); i < this.Count; i = global::Infragistics.PriorityQueue<T>.LeftChild(index))
			{
				if (i + 1 < this.Count && this.heap[i].Priority < this.heap[i + 1].Priority)
				{
					i++;
				}
				this.heap[index] = this.heap[i];
				index = i;
			}
			this.BubbleUp(index, he);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00023BCC File Offset: 0x00021DCC
		private void GrowHeap()
		{
			this.Capacity = this.Capacity * 2 + 1;
			global::Infragistics.PriorityQueue<T>.HeapItem[] destinationArray = new global::Infragistics.PriorityQueue<T>.HeapItem[this.Capacity];
			global::System.Array.Copy(this.heap, 0, destinationArray, 0, this.Count);
			this.heap = destinationArray;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00023C10 File Offset: 0x00021E10
		private static int Parent(int index)
		{
			return (index - 1) / 2;
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00023C17 File Offset: 0x00021E17
		private static int LeftChild(int index)
		{
			return index * 2 + 1;
		}

		// Token: 0x040002C8 RID: 712
		private global::Infragistics.PriorityQueue<T>.HeapItem[] heap;

		// Token: 0x020000AF RID: 175
		private struct HeapItem
		{
			// Token: 0x0600078D RID: 1933 RVA: 0x00023C1E File Offset: 0x00021E1E
			public HeapItem(T item, double priority)
			{
				this = default(global::Infragistics.PriorityQueue<T>.HeapItem);
				this.Item = item;
				this.Priority = priority;
			}

			// Token: 0x170001C1 RID: 449
			// (get) Token: 0x0600078E RID: 1934 RVA: 0x00023C35 File Offset: 0x00021E35
			// (set) Token: 0x0600078F RID: 1935 RVA: 0x00023C3D File Offset: 0x00021E3D
			public T Item { get; private set; }

			// Token: 0x170001C2 RID: 450
			// (get) Token: 0x06000790 RID: 1936 RVA: 0x00023C46 File Offset: 0x00021E46
			// (set) Token: 0x06000791 RID: 1937 RVA: 0x00023C4E File Offset: 0x00021E4E
			public double Priority { get; private set; }
		}
	}
}
