using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Infragistics.Collections
{
	// Token: 0x02000008 RID: 8
	public class SparseArray : global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00002B31 File Offset: 0x00000D31
		public SparseArray() : this(40)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002B3B File Offset: 0x00000D3B
		public SparseArray(bool useOwnerData) : this(40, 0.25f, useOwnerData)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002B4B File Offset: 0x00000D4B
		public SparseArray(int factor) : this(factor, 0.25f)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002B59 File Offset: 0x00000D59
		public SparseArray(int factor, float growthFactor) : this(factor, growthFactor, false)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002B64 File Offset: 0x00000D64
		public SparseArray(int factor, float growthFactor, bool useOwnerData) : this(factor, growthFactor, useOwnerData, false)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002B70 File Offset: 0x00000D70
		public SparseArray(bool manageScrollCounts, int factor, float growthFactor) : this(factor, growthFactor, true, manageScrollCounts)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002B7C File Offset: 0x00000D7C
		protected SparseArray(int factor, float growthFactor, bool useOwnerData, bool manageScrollCounts)
		{
			if (factor < 2)
			{
				throw new global::System.ArgumentOutOfRangeException("factor", global::Infragistics.Collections.SparseArray.GetString("LE_ArgumentOutOfRangeException_1"));
			}
			if (growthFactor <= 0f || growthFactor > 1f)
			{
				throw new global::System.ArgumentOutOfRangeException("growthFactor", global::Infragistics.Collections.SparseArray.GetString("LE_ArgumentOutOfRangeException_2"));
			}
			this.factor = factor;
			this.growBy = global::System.Math.Max(1, (int)((float)factor * growthFactor));
			this.useOwnerData = (useOwnerData || manageScrollCounts);
			this.manageScrollCounts = manageScrollCounts;
			this._cacheScrollCounts = this.manageScrollCounts;
			this.tree = this.CreateNode();
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002C13 File Offset: 0x00000E13
		public int Count
		{
			get
			{
				return this.tree.TotalCount;
			}
		}

		// Token: 0x17000011 RID: 17
		public object this[int index]
		{
			get
			{
				return this.GetItem(index, null);
			}
			set
			{
				this.SetItemHelper(index, value, false);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00002C35 File Offset: 0x00000E35
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002C38 File Offset: 0x00000E38
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00002C3B File Offset: 0x00000E3B
		public global::System.Collections.IEnumerable NonNullItems
		{
			get
			{
				return new global::Infragistics.Collections.SparseArray.NonNullEnumerable(this);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002C44 File Offset: 0x00000E44
		public void Expand(int newCount)
		{
			if (newCount < this.Count)
			{
				throw new global::System.ArgumentOutOfRangeException("newCount", global::Infragistics.Collections.SparseArray.GetString("LE_ArgumentOutOfRangeException_3"));
			}
			int num = newCount - this.Count;
			global::Infragistics.Collections.SparseArray.Node right = this.tree;
			while (right.right != null)
			{
				right.rightCount += num;
				right = right.right;
			}
			bool setIsNodeDirtyFlag = false;
			if (right.count < this.factor)
			{
				int num2 = global::System.Math.Min(num, this.factor - right.count);
				this.Lend(null, right, num2, false);
				num -= num2;
				setIsNodeDirtyFlag = true;
			}
			right.rightCount += num;
			this.DirtyScrollCount(right, setIsNodeDirtyFlag, true);
			this.MaintainAncestors(right);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002CF0 File Offset: 0x00000EF0
		public int Add(object item)
		{
			global::Infragistics.Collections.SparseArray.Node right = this.tree;
			while (right.right != null)
			{
				right.rightCount++;
				right = right.right;
			}
			if (right.rightCount <= 0)
			{
				this.Array_Insert(right, right.count, item);
				this.DirtyScrollCount_OverallScrollCountChanged(right);
				this.FixupNode(right);
			}
			else
			{
				right.rightCount++;
				if (item != null)
				{
					this.SetItemHelper(this.Count - 1, item, true);
				}
				else
				{
					this.DirtyScrollCount(right, false, true);
				}
			}
			return this.Count - 1;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002D80 File Offset: 0x00000F80
		public void Insert(int index, object item)
		{
			if (index >= 0 && index < this.Count)
			{
				int index2 = index;
				global::Infragistics.Collections.SparseArray.Node nodeContainingIndex = this.GetNodeContainingIndex(ref index, null != item);
				if (nodeContainingIndex != null)
				{
					this.Array_Insert(nodeContainingIndex, index, item);
					this.ApplyDeltaToAncestors(nodeContainingIndex, 1);
					this.FixupNode(nodeContainingIndex);
					return;
				}
				this.ApplyDeltaToDescendantPath(index2, 1);
				return;
			}
			else
			{
				if (this.Count == index)
				{
					this.Add(item);
					return;
				}
				throw new global::System.ArgumentOutOfRangeException("index");
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002DED File Offset: 0x00000FED
		public void AddRange(global::System.Collections.ICollection items)
		{
			this.InsertRange(this.Count, items);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002DFC File Offset: 0x00000FFC
		public void InsertRange(int index, global::System.Collections.ICollection items)
		{
			if (index < 0)
			{
				this.ValidateIndex(index);
			}
			if (index > this.Count)
			{
				this.ValidateIndex(index);
			}
			int count = items.Count;
			if (count > 0)
			{
				this.Expand(this.Count + count);
				for (int i = this.Count - 1 - count; i >= index; i--)
				{
					this[i + count] = this[i];
				}
				global::System.Collections.IEnumerator enumerator = items.GetEnumerator();
				enumerator.Reset();
				bool flag = true;
				while (flag && enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					int num = index;
					global::Infragistics.Collections.SparseArray.Node nodeContainingIndex = this.GetNodeContainingIndex(ref num, null != obj);
					index++;
					if (nodeContainingIndex != null)
					{
						object[] itemsArray = nodeContainingIndex.ItemsArray;
						itemsArray[num++] = obj;
						this.SetOwnerDataHelper(obj, nodeContainingIndex);
						while (num < nodeContainingIndex.count && (flag = enumerator.MoveNext()))
						{
							obj = enumerator.Current;
							this.SetOwnerDataHelper(obj, nodeContainingIndex);
							itemsArray[num++] = obj;
							index++;
						}
						this.DirtyScrollCount_OverallScrollCountChanged(nodeContainingIndex);
					}
				}
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002F10 File Offset: 0x00001110
		public void RemoveAt(int index)
		{
			this.ValidateIndex(index);
			int index2 = index;
			global::Infragistics.Collections.SparseArray.Node nodeContainingIndex = this.GetNodeContainingIndex(ref index, false);
			if (nodeContainingIndex != null)
			{
				this.Array_Remove(nodeContainingIndex, index);
				this.ApplyDeltaToAncestors(nodeContainingIndex, -1);
				this.FixupNode(nodeContainingIndex);
				return;
			}
			this.ApplyDeltaToDescendantPath(index2, -1);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002F54 File Offset: 0x00001154
		public void Move(object item, int newIndex)
		{
			int num = this.IndexOf(item);
			if (num < 0)
			{
				throw new global::System.ArgumentException();
			}
			this.MoveHelper(num, newIndex, item, true);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002F7D File Offset: 0x0000117D
		public void Move(int itemIndex, int newIndex)
		{
			this.MoveHelper(itemIndex, newIndex, null, false);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002F8C File Offset: 0x0000118C
		private void MoveHelper(int itemIndex, int newIndex, object item, bool itemIsSpecified)
		{
			this.ValidateIndex(itemIndex);
			this.ValidateIndex(newIndex);
			if (!itemIsSpecified)
			{
				item = this.GetItem(itemIndex);
			}
			bool flag = this.onScrollCountChangedCalledBefore;
			this.onScrollCountChangedCalledBefore = true;
			try
			{
				this.RemoveAt(itemIndex);
				this.Insert(newIndex, item);
			}
			finally
			{
				this.onScrollCountChangedCalledBefore = flag;
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002FEC File Offset: 0x000011EC
		public int IndexOf(object item)
		{
			if (this.useOwnerData)
			{
				global::Infragistics.Collections.SparseArray.Node node = this.GetOwnerDataHelper(item) as global::Infragistics.Collections.SparseArray.Node;
				if (node != null)
				{
					int nodeStartIndex = this.GetNodeStartIndex(node);
					if (nodeStartIndex >= 0 && node.arr != null)
					{
						int num = global::System.Array.IndexOf<object>(node.arr, item, 0, node.count);
						if (num >= 0)
						{
							return nodeStartIndex + num;
						}
					}
				}
				return -1;
			}
			return this.IndexOf(this.tree, item);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003050 File Offset: 0x00001250
		public void RemoveRange(int index, int count)
		{
			if (count > 0)
			{
				int num = index + count - 1;
				this.ValidateIndex(index);
				this.ValidateIndex(num);
				this.RemoveRangeHelper(index, num);
				return;
			}
			if (count == 0)
			{
				return;
			}
			throw new global::System.ArgumentOutOfRangeException("count", global::Infragistics.Collections.SparseArray.GetString("LE_ArgumentOutOfRangeException_4"));
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003098 File Offset: 0x00001298
		public void Remove(object value)
		{
			int num = this.IndexOf(value);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000030B8 File Offset: 0x000012B8
		public bool Contains(object value)
		{
			return this.IndexOf(value) >= 0;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000030C7 File Offset: 0x000012C7
		public void Clear()
		{
			this.Clear(true);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000030D0 File Offset: 0x000012D0
		private void Clear(bool raiseOnScrollCountChanged)
		{
			this.ClearOwnerDataTreeWide(this.tree);
			this.tree = this.CreateNode();
			if (raiseOnScrollCountChanged)
			{
				this.OnScrollCountChanged();
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000030F3 File Offset: 0x000012F3
		public void CopyTo(global::System.Array array, int index)
		{
			this.CopyTo(array, index, null);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003100 File Offset: 0x00001300
		public void CopyTo(global::System.Array array, int index, global::Infragistics.Collections.ICreateItemCallback callback)
		{
			if (array.Length - index < this.Count)
			{
				throw new global::System.ArgumentException(global::Infragistics.Collections.SparseArray.GetString("LE_ArgumentException_3"), "array");
			}
			if (callback == null)
			{
				this.CopyToHelper(this.tree, array, ref index);
				return;
			}
			global::System.Collections.IEnumerator enumerator = this.GetEnumerator(callback);
			while (enumerator.MoveNext())
			{
				object value = enumerator.Current;
				array.SetValue(value, index++);
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003169 File Offset: 0x00001369
		public object[] ToArray()
		{
			return (object[])this.ToArray(typeof(object));
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003180 File Offset: 0x00001380
		public global::System.Array ToArray(global::System.Type type)
		{
			global::System.Array array = global::System.Array.CreateInstance(type, this.Count);
			this.CopyTo(array, 0);
			return array;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000031A3 File Offset: 0x000013A3
		public object GetItem(int index)
		{
			return this.GetItem(index, null);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000031B0 File Offset: 0x000013B0
		public object GetItem(int index, global::Infragistics.Collections.ICreateItemCallback createItemCallback)
		{
			this.ValidateIndex(index);
			int num = index;
			global::Infragistics.Collections.SparseArray.Node nodeContainingIndex = this.GetNodeContainingIndex(ref num, null != createItemCallback);
			if (nodeContainingIndex == null)
			{
				return null;
			}
			if (createItemCallback != null && (nodeContainingIndex.arr == null || nodeContainingIndex.arr[num] == null))
			{
				return this.CreateItemHelper(createItemCallback, nodeContainingIndex, num, index);
			}
			if (nodeContainingIndex.arr == null)
			{
				return null;
			}
			return nodeContainingIndex.arr[num];
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000320D File Offset: 0x0000140D
		public void Reverse()
		{
			this.Reverse(0, this.Count);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000321C File Offset: 0x0000141C
		public void Reverse(int index, int count)
		{
			if (count < 1)
			{
				return;
			}
			int i = index;
			int num = index + count - 1;
			this.ValidateIndex(i);
			this.ValidateIndex(num);
			while (i < num)
			{
				object value = this[i];
				this[i] = this[num];
				this[num] = value;
				i++;
				num--;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00003270 File Offset: 0x00001470
		public void Sort()
		{
			this.Sort(null);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000327C File Offset: 0x0000147C
		public void Sort(global::System.Collections.IComparer comparer)
		{
			object[] array = (object[])this.ToArray(typeof(object));
			global::Infragistics.CoreUtilities.SortMerge(array, (comparer != null) ? comparer : global::System.Collections.Generic.Comparer<object>.Default);
			this.ReplaceAllItems(array);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000032B8 File Offset: 0x000014B8
		public void SortGeneric<T>(global::System.Collections.Generic.IComparer<T> comparer)
		{
			T[] array = (T[])this.ToArray(typeof(T));
			global::Infragistics.CoreUtilities.SortMergeGeneric<T>(array, comparer);
			this.ReplaceAllItems(array);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000032EC File Offset: 0x000014EC
		public void Compact()
		{
			bool flag = this.CompactHelper(this.tree);
			if (flag && this.manageScrollCounts)
			{
				this.scrollCountInfoDirtyOnAllNodes = true;
				this.EnsureScrollCountCalculated();
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003320 File Offset: 0x00001520
		private bool CompactHelper(global::Infragistics.Collections.SparseArray.Node n)
		{
			bool flag = false;
			if (n == null)
			{
				return flag;
			}
			flag = (this.CompactHelper(n.left) || flag);
			flag = (this.CompactHelper(n.right) || flag);
			if (this.Array_AreAllItemsNull(n))
			{
				flag = (this.RemoveEmptyNode(n) || flag);
			}
			return flag;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003374 File Offset: 0x00001574
		private bool RemoveEmptyNode(global::Infragistics.Collections.SparseArray.Node n)
		{
			bool flag = n == this.tree;
			bool flag2;
			if (n.left != null && n.right != null)
			{
				flag2 = (n.leftCount < n.rightCount);
			}
			else if (n.left != null)
			{
				flag2 = false;
			}
			else if (n.right != null)
			{
				flag2 = true;
			}
			else
			{
				if (n.parent != null)
				{
					if (n == n.parent.left)
					{
						n.parent.left = null;
					}
					else if (n == n.parent.right)
					{
						n.parent.right = null;
					}
					return true;
				}
				return false;
			}
			global::Infragistics.Collections.SparseArray.Node node = flag2 ? this.RotateLeft(n) : this.RotateRight(n);
			if (flag)
			{
				this.tree = node;
			}
			this.RemoveEmptyNode(n);
			return true;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003430 File Offset: 0x00001630
		protected virtual object GetOwnerData(object item)
		{
			global::Infragistics.Collections.ISparseArrayItem sparseArrayItem = item as global::Infragistics.Collections.ISparseArrayItem;
			if (sparseArrayItem == null)
			{
				return null;
			}
			return sparseArrayItem.GetOwnerData(this);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003450 File Offset: 0x00001650
		protected virtual void SetOwnerData(object item, object ownerData)
		{
			global::Infragistics.Collections.ISparseArrayItem sparseArrayItem = item as global::Infragistics.Collections.ISparseArrayItem;
			if (sparseArrayItem != null)
			{
				sparseArrayItem.SetOwnerData(ownerData, this);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000346F File Offset: 0x0000166F
		public int GetVisibleCount()
		{
			this.EnsureScrollCountCalculated();
			return ((global::Infragistics.Collections.SparseArray.NodeExtended)this.tree).TotalVisibleCount;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00003487 File Offset: 0x00001687
		public int GetScrollCount()
		{
			this.EnsureScrollCountCalculated();
			return ((global::Infragistics.Collections.SparseArray.NodeExtended)this.tree).TotalScrollCount;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000349F File Offset: 0x0000169F
		public int GetVisibleIndexOf(global::Infragistics.Collections.ISparseArrayMultiItem item)
		{
			return this.GetVisibleIndexOf(item, false);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000034AC File Offset: 0x000016AC
		private static int CountDescretePoints(int[] arr, int startIndex, int endIndex)
		{
			int num = 0;
			int num2 = 0;
			for (int i = startIndex; i <= endIndex; i++)
			{
				int num3 = arr[i];
				if (num2 != num3)
				{
					num++;
				}
				num2 = num3;
			}
			return num;
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000034D8 File Offset: 0x000016D8
		public int GetVisibleIndexOf(global::Infragistics.Collections.ISparseArrayMultiItem item, bool ignoreItemHiddenState)
		{
			if (!this.manageScrollCounts)
			{
				throw new global::System.InvalidOperationException();
			}
			this.EnsureScrollCountCalculated();
			if (!ignoreItemHiddenState && item.ScrollCount <= 0)
			{
				return -1;
			}
			global::Infragistics.Collections.SparseArray.NodeExtended nodeExtended = this.GetOwnerDataHelper(item) as global::Infragistics.Collections.SparseArray.NodeExtended;
			if (nodeExtended != null)
			{
				int nodeStartVisibleIndex = this.GetNodeStartVisibleIndex(nodeExtended);
				if (nodeStartVisibleIndex >= 0)
				{
					int num = 0;
					if (nodeExtended.arr != null)
					{
						bool flag = false;
						int[] scrollCounts;
						if (this._cacheScrollCounts && global::Infragistics.Collections.SparseArray.NodeExtendedWithScrollCountCache.g_dirtyFlag != (scrollCounts = nodeExtended.ScrollCounts))
						{
							int num2 = global::System.Array.IndexOf<object>(nodeExtended.arr, item);
							flag = (num2 >= 0);
							if (flag)
							{
								num = ((scrollCounts != null) ? global::Infragistics.Collections.SparseArray.CountDescretePoints(scrollCounts, 0, num2 - 1) : num2);
							}
						}
						else
						{
							int num3 = 0;
							while (!flag && num3 < nodeExtended.count)
							{
								global::Infragistics.Collections.ISparseArrayMultiItem sparseArrayMultiItem = (global::Infragistics.Collections.ISparseArrayMultiItem)nodeExtended.arr[num3];
								if (sparseArrayMultiItem != item)
								{
									num += global::Infragistics.Collections.SparseArray.GetItemVisibleCount(sparseArrayMultiItem);
								}
								else
								{
									flag = true;
								}
								num3++;
							}
						}
						if (flag)
						{
							return nodeStartVisibleIndex + num;
						}
					}
				}
			}
			return -1;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x000035C4 File Offset: 0x000017C4
		public int GetVisibleIndexOf(int itemIndex, bool ignoreItemHiddenState)
		{
			if (!this.manageScrollCounts)
			{
				throw new global::System.InvalidOperationException();
			}
			this.EnsureScrollCountCalculated();
			int num = itemIndex;
			global::Infragistics.Collections.SparseArray.NodeExtended nodeExtended = this.GetNodeContainingIndex(ref num, true) as global::Infragistics.Collections.SparseArray.NodeExtended;
			if (nodeExtended != null && num >= 0)
			{
				int num2 = this.GetNodeStartVisibleIndex(nodeExtended);
				if (num2 >= 0)
				{
					if (nodeExtended.arr == null)
					{
						return num2 + num;
					}
					int[] scrollCounts;
					if (this._cacheScrollCounts && global::Infragistics.Collections.SparseArray.NodeExtendedWithScrollCountCache.g_dirtyFlag != (scrollCounts = nodeExtended.ScrollCounts))
					{
						int num3 = (scrollCounts != null) ? global::Infragistics.Collections.SparseArray.CountDescretePoints(scrollCounts, 0, num - 1) : num;
						int num4 = (scrollCounts == null) ? 1 : (scrollCounts[num] - ((num > 0) ? scrollCounts[num - 1] : 0));
						if (!ignoreItemHiddenState && num4 <= 0)
						{
							return -1;
						}
						return num2 + num3;
					}
					else
					{
						int i = 0;
						while (i < nodeExtended.count)
						{
							global::Infragistics.Collections.ISparseArrayMultiItem item = (global::Infragistics.Collections.ISparseArrayMultiItem)nodeExtended.arr[i];
							int itemVisibleCount = global::Infragistics.Collections.SparseArray.GetItemVisibleCount(item);
							if (num == i)
							{
								if (!ignoreItemHiddenState && itemVisibleCount <= 0)
								{
									return -1;
								}
								return num2;
							}
							else
							{
								num2 += itemVisibleCount;
								i++;
							}
						}
					}
				}
			}
			return -1;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000036B3 File Offset: 0x000018B3
		public int GetScrollIndexOf(global::Infragistics.Collections.ISparseArrayMultiItem item)
		{
			return this.GetScrollIndexOf(item, false);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000036C0 File Offset: 0x000018C0
		public int GetScrollIndexOf(global::Infragistics.Collections.ISparseArrayMultiItem item, bool ignoreItemHiddenState)
		{
			if (!this.manageScrollCounts)
			{
				throw new global::System.InvalidOperationException();
			}
			this.EnsureScrollCountCalculated();
			if (!ignoreItemHiddenState && item.ScrollCount <= 0)
			{
				return -1;
			}
			global::Infragistics.Collections.SparseArray.NodeExtended nodeExtended = this.GetOwnerDataHelper(item) as global::Infragistics.Collections.SparseArray.NodeExtended;
			if (nodeExtended != null)
			{
				int nodeStartScrollIndex = this.GetNodeStartScrollIndex(nodeExtended);
				if (nodeStartScrollIndex >= 0)
				{
					int num = 0;
					if (nodeExtended.arr != null)
					{
						bool flag = false;
						int[] scrollCounts;
						if (this._cacheScrollCounts && global::Infragistics.Collections.SparseArray.NodeExtendedWithScrollCountCache.g_dirtyFlag != (scrollCounts = nodeExtended.ScrollCounts))
						{
							int num2 = global::System.Array.IndexOf<object>(nodeExtended.arr, item);
							flag = (num2 >= 0);
							num = ((num2 > 0) ? ((scrollCounts != null) ? scrollCounts[num2 - 1] : num2) : 0);
						}
						else
						{
							int num3 = 0;
							while (!flag && num3 < nodeExtended.count)
							{
								global::Infragistics.Collections.ISparseArrayMultiItem sparseArrayMultiItem = (global::Infragistics.Collections.ISparseArrayMultiItem)nodeExtended.arr[num3];
								if (sparseArrayMultiItem != item)
								{
									num += global::Infragistics.Collections.SparseArray.GetItemScrollCount(sparseArrayMultiItem);
								}
								else
								{
									flag = true;
								}
								num3++;
							}
						}
						if (flag)
						{
							return nodeStartScrollIndex + num;
						}
					}
				}
			}
			return -1;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000037AC File Offset: 0x000019AC
		protected object GetItemAtVisibleIndexOffset(global::Infragistics.Collections.ISparseArrayMultiItem startItem, int offset, global::Infragistics.Collections.ICreateItemCallback createItemCallback)
		{
			int visibleIndexOf = this.GetVisibleIndexOf(startItem, true);
			if (visibleIndexOf < 0)
			{
				return null;
			}
			return this.GetItemAtVisibleIndex(visibleIndexOf + offset, createItemCallback);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000037D4 File Offset: 0x000019D4
		protected object GetItemAtVisibleIndex(int visibleIndex, global::Infragistics.Collections.ICreateItemCallback createItemCallback)
		{
			if (!this.manageScrollCounts)
			{
				throw new global::System.InvalidOperationException();
			}
			if (visibleIndex < 0 || visibleIndex >= this.GetVisibleCount())
			{
				return null;
			}
			int i = visibleIndex;
			int num = 0;
			while (i < this.GetVisibleCount())
			{
				num++;
				visibleIndex = i;
				global::Infragistics.Collections.SparseArray.NodeExtended nodeExtended = (global::Infragistics.Collections.SparseArray.NodeExtended)this.tree;
				bool flag = false;
				global::Infragistics.Collections.SparseArray.NodeExtended nodeExtended2 = null;
				while (nodeExtended != null)
				{
					nodeExtended2 = nodeExtended;
					if (visibleIndex < nodeExtended.leftVisibleCount)
					{
						flag = true;
						nodeExtended = (global::Infragistics.Collections.SparseArray.NodeExtended)nodeExtended.left;
					}
					else
					{
						visibleIndex -= nodeExtended.leftVisibleCount;
						if (visibleIndex < nodeExtended.visibleCount)
						{
							break;
						}
						visibleIndex -= nodeExtended.visibleCount;
						nodeExtended = (global::Infragistics.Collections.SparseArray.NodeExtended)nodeExtended.right;
						flag = false;
					}
				}
				if (nodeExtended == null)
				{
					if (createItemCallback == null)
					{
						return null;
					}
					int num2 = this.GetNodeStartIndex(nodeExtended2);
					if (flag)
					{
						num2 -= (nodeExtended2.leftVisibleCount - visibleIndex) / 1;
						num2 = global::System.Math.Max(0, num2);
					}
					else
					{
						num2 += nodeExtended2.count;
						num2 += visibleIndex / 1;
						num2 = global::System.Math.Min(this.Count - 1, num2);
					}
					this.GetNodeContainingIndex(ref num2, true);
					if (num > this.Count)
					{
						return null;
					}
				}
				else
				{
					if (nodeExtended.arr == null && createItemCallback == null)
					{
						return null;
					}
					int num3 = 0;
					bool flag2 = false;
					int[] array = null;
					if (this._cacheScrollCounts)
					{
						array = nodeExtended.ScrollCounts;
						flag2 = (global::Infragistics.Collections.SparseArray.NodeExtendedWithScrollCountCache.g_dirtyFlag != array);
					}
					bool flag3 = false;
					for (int j = 0; j < nodeExtended.count; j++)
					{
						global::Infragistics.Collections.ISparseArrayMultiItem sparseArrayMultiItem = (global::Infragistics.Collections.ISparseArrayMultiItem)nodeExtended.ItemsArray[j];
						int num5;
						if (flag2)
						{
							int num4 = (array != null) ? array[j] : (num3 + 1);
							num5 = ((num4 - num3 > 0) ? 1 : 0);
							num3 = num4;
						}
						else
						{
							num5 = global::Infragistics.Collections.SparseArray.GetItemVisibleCount(sparseArrayMultiItem);
						}
						if (visibleIndex < num5)
						{
							if (sparseArrayMultiItem == null && createItemCallback != null)
							{
								int overallIndex = this.GetNodeStartIndex(nodeExtended) + j;
								sparseArrayMultiItem = (global::Infragistics.Collections.ISparseArrayMultiItem)this.CreateItemHelper(createItemCallback, nodeExtended, j, overallIndex);
								if (sparseArrayMultiItem != null)
								{
									flag2 = false;
									flag3 = true;
									j--;
									goto IL_1BF;
								}
							}
							return sparseArrayMultiItem;
						}
						visibleIndex -= num5;
						IL_1BF:;
					}
					if (!flag3)
					{
						return null;
					}
				}
			}
			return null;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000039C8 File Offset: 0x00001BC8
		protected object GetItemAtScrollIndex(int scrollIndex, global::Infragistics.Collections.ICreateItemCallback createItemCallback)
		{
			int num;
			return this.GetItemAtScrollIndexHelper(scrollIndex, createItemCallback, true, out num);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000039E0 File Offset: 0x00001BE0
		protected object GetItemContainingScrollIndex(ref int scrollIndex, global::Infragistics.Collections.ICreateItemCallback createItemCallback)
		{
			int num;
			object itemAtScrollIndexHelper = this.GetItemAtScrollIndexHelper(scrollIndex, createItemCallback, false, out num);
			if (num >= 0)
			{
				scrollIndex = num;
			}
			return itemAtScrollIndexHelper;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003A04 File Offset: 0x00001C04
		private object GetItemAtScrollIndexHelper(int scrollIndex, global::Infragistics.Collections.ICreateItemCallback createItemCallback, bool traverseHierarchy, out int offsetIntoItem)
		{
			offsetIntoItem = -1;
			if (!this.manageScrollCounts)
			{
				throw new global::System.InvalidOperationException();
			}
			if (scrollIndex < 0 || scrollIndex >= this.GetScrollCount())
			{
				return null;
			}
			int i = scrollIndex;
			int num = 0;
			while (i < this.GetScrollCount())
			{
				num++;
				scrollIndex = i;
				global::Infragistics.Collections.SparseArray.NodeExtended nodeExtended = (global::Infragistics.Collections.SparseArray.NodeExtended)this.tree;
				bool flag = false;
				global::Infragistics.Collections.SparseArray.NodeExtended nodeExtended2 = null;
				while (nodeExtended != null)
				{
					nodeExtended2 = nodeExtended;
					if (scrollIndex < nodeExtended.leftScrollCount)
					{
						flag = true;
						nodeExtended = (global::Infragistics.Collections.SparseArray.NodeExtended)nodeExtended.left;
					}
					else
					{
						scrollIndex -= nodeExtended.leftScrollCount;
						if (scrollIndex < nodeExtended.scrollCount)
						{
							break;
						}
						scrollIndex -= nodeExtended.scrollCount;
						nodeExtended = (global::Infragistics.Collections.SparseArray.NodeExtended)nodeExtended.right;
						flag = false;
					}
				}
				if (nodeExtended == null)
				{
					if (createItemCallback == null)
					{
						return null;
					}
					int num2 = this.GetNodeStartIndex(nodeExtended2);
					if (flag)
					{
						num2 -= (nodeExtended2.leftScrollCount - scrollIndex) / 1;
						num2 = global::System.Math.Max(0, num2);
					}
					else
					{
						num2 += nodeExtended2.count;
						num2 += scrollIndex / 1;
						num2 = global::System.Math.Min(this.Count - 1, num2);
					}
					this.GetNodeContainingIndex(ref num2, true);
					if (num > this.Count)
					{
						return null;
					}
				}
				else
				{
					if (nodeExtended.arr == null && createItemCallback == null)
					{
						return null;
					}
					int num3 = 0;
					bool flag2 = false;
					int[] array = null;
					if (this._cacheScrollCounts)
					{
						array = nodeExtended.ScrollCounts;
						flag2 = (global::Infragistics.Collections.SparseArray.NodeExtendedWithScrollCountCache.g_dirtyFlag != array);
					}
					bool flag3 = false;
					for (int j = 0; j < nodeExtended.count; j++)
					{
						global::Infragistics.Collections.ISparseArrayMultiItem sparseArrayMultiItem = (global::Infragistics.Collections.ISparseArrayMultiItem)nodeExtended.ItemsArray[j];
						int num5;
						if (flag2)
						{
							int num4 = (array != null) ? array[j] : (num3 + 1);
							num5 = num4 - num3;
							num3 = num4;
						}
						else
						{
							num5 = global::Infragistics.Collections.SparseArray.GetItemScrollCount(sparseArrayMultiItem);
						}
						if (scrollIndex < num5)
						{
							if (sparseArrayMultiItem == null && createItemCallback != null)
							{
								int overallIndex = this.GetNodeStartIndex(nodeExtended) + j;
								sparseArrayMultiItem = (global::Infragistics.Collections.ISparseArrayMultiItem)this.CreateItemHelper(createItemCallback, nodeExtended, j, overallIndex);
								if (sparseArrayMultiItem != null)
								{
									flag2 = false;
									flag3 = true;
									j--;
									goto IL_1D0;
								}
							}
							offsetIntoItem = scrollIndex;
							if (!traverseHierarchy || sparseArrayMultiItem == null)
							{
								return sparseArrayMultiItem;
							}
							return sparseArrayMultiItem.GetItemAtScrollIndex(scrollIndex);
						}
						else
						{
							scrollIndex -= num5;
						}
						IL_1D0:;
					}
					if (!flag3)
					{
						return null;
					}
				}
			}
			return null;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003C08 File Offset: 0x00001E08
		public void NotifyItemScrollCountChanged(global::Infragistics.Collections.ISparseArrayMultiItem item)
		{
			if (item != null && !this.scrollCountInfoDirtyOnAllNodes)
			{
				global::Infragistics.Collections.SparseArray.NodeExtended nodeExtended = this.GetOwnerDataHelper(item) as global::Infragistics.Collections.SparseArray.NodeExtended;
				if (nodeExtended != null)
				{
					this.DirtyScrollCount_OverallScrollCountChanged(nodeExtended);
				}
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003C37 File Offset: 0x00001E37
		protected void DirtyScrollCountInfo()
		{
			if (!this.scrollCountInfoDirtyOnAllNodes)
			{
				this.scrollCountInfoDirtyOnAllNodes = true;
				this.OnScrollCountChanged();
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003C4E File Offset: 0x00001E4E
		protected virtual void OnScrollCountChanged()
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003C50 File Offset: 0x00001E50
		protected virtual void OnItemCreated(object item, int index)
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003C52 File Offset: 0x00001E52
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void OnDeserializationComplete()
		{
			if (this.useOwnerData && this.tree != null)
			{
				this.SetOwnerDataTreeWide(this.tree);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003C70 File Offset: 0x00001E70
		protected global::System.Collections.IEnumerable GetVisibleItems(global::Infragistics.Collections.ICreateItemCallback createItemCallback)
		{
			return new global::Infragistics.Collections.SparseArray.VisibleItemsEnumerator.Enumerable(this, createItemCallback);
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000086 RID: 134 RVA: 0x00003C79 File Offset: 0x00001E79
		protected bool InCalculatingScrollCount
		{
			get
			{
				return this._inEnsureScrollCountCalculated;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003C81 File Offset: 0x00001E81
		internal static string GetString(string name)
		{
			return global::Infragistics.Collections.SparseArray.GetString(name, null);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00003C8A File Offset: 0x00001E8A
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00003C93 File Offset: 0x00001E93
		private int MaxFactor
		{
			get
			{
				return 2 * this.factor - 1;
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003C9F File Offset: 0x00001E9F
		private void ValidateIndex(int index)
		{
			if (index < 0 || index >= this.Count)
			{
				throw new global::System.IndexOutOfRangeException();
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00003CB4 File Offset: 0x00001EB4
		private void SetItemHelper(int index, object item, bool performingAdd)
		{
			this.ValidateIndex(index);
			global::Infragistics.Collections.SparseArray.Node nodeContainingIndex = this.GetNodeContainingIndex(ref index, null != item);
			if (nodeContainingIndex != null)
			{
				object[] itemsArray = nodeContainingIndex.ItemsArray;
				bool flag = false;
				if (this.manageScrollCounts)
				{
					flag = true;
					if (itemsArray[index] == null)
					{
						int itemScrollCount = global::Infragistics.Collections.SparseArray.GetItemScrollCount((global::Infragistics.Collections.ISparseArrayMultiItem)item);
						if (itemScrollCount == (performingAdd ? 0 : 1))
						{
							flag = false;
						}
					}
				}
				itemsArray[index] = item;
				this.SetOwnerDataHelper(item, nodeContainingIndex);
				if (flag)
				{
					this.DirtyScrollCount_OverallScrollCountChanged(nodeContainingIndex);
				}
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00003D28 File Offset: 0x00001F28
		private void ApplyDeltaToAncestors(global::Infragistics.Collections.SparseArray.Node n, int delta)
		{
			global::Infragistics.Collections.SparseArray.Node node = n;
			while (n.parent != null)
			{
				if (n == n.parent.left)
				{
					n.parent.leftCount += delta;
				}
				else
				{
					n.parent.rightCount += delta;
				}
				n = n.parent;
			}
			this.DirtyScrollCount_OverallScrollCountChanged(node);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00003D88 File Offset: 0x00001F88
		private void ApplyDeltaToDescendantPath(int index, int delta)
		{
			global::Infragistics.Collections.SparseArray.Node node = this.tree;
			global::Infragistics.Collections.SparseArray.Node node2 = null;
			while (node != null)
			{
				node2 = node;
				if (index < node.leftCount)
				{
					node.leftCount += delta;
					node = node.left;
				}
				else
				{
					index -= node.leftCount;
					if (index < node.count)
					{
						break;
					}
					index -= node.count;
					node.rightCount += delta;
					node = node.right;
				}
			}
			this.DirtyScrollCount(node2, false, true);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003E00 File Offset: 0x00002000
		private void GetNodeContainingIndeces(ref int xIndex, ref int yIndex, out global::Infragistics.Collections.SparseArray.Node xNode, out global::Infragistics.Collections.SparseArray.Node yNode)
		{
			int num = xIndex;
			int num2 = xIndex;
			xNode = this.GetNodeContainingIndex(ref xIndex, true);
			yNode = this.GetNodeContainingIndex(ref yIndex, false);
			if (yNode == null)
			{
				xIndex = num;
				yIndex = num2;
				yNode = this.GetNodeContainingIndex(ref yIndex, true);
				xNode = this.GetNodeContainingIndex(ref xIndex, true);
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003E48 File Offset: 0x00002048
		private void RemoveRangeHelper(int startIndex, int endIndex)
		{
			while (startIndex <= endIndex)
			{
				int num = startIndex;
				int num2 = endIndex;
				global::Infragistics.Collections.SparseArray.Node node;
				global::Infragistics.Collections.SparseArray.Node node2;
				this.GetNodeContainingIndeces(ref num, ref num2, out node, out node2);
				if (node == node2)
				{
					int num3 = 1 + num2 - num;
					this.Array_RemoveRange(node, num, num3, true);
					this.ApplyDeltaToAncestors(node, -num3);
					this.FixupNode(node);
					endIndex -= num3;
				}
				else if (num == 0 || node2.count - 1 == num2)
				{
					global::Infragistics.Collections.SparseArray.Node node3 = (num == 0) ? node : node2;
					int count = node3.count;
					this.Array_RemoveRange(node3, 0, count, true);
					this.ApplyDeltaToAncestors(node3, -count);
					this.FixupNode(node3);
					endIndex -= count;
				}
				else
				{
					this.RemoveRangeHelper(startIndex, endIndex - (num2 + 1));
					endIndex = startIndex + num2;
				}
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003EFA File Offset: 0x000020FA
		private bool CanBorrow(global::Infragistics.Collections.SparseArray.Node n, int itemCount)
		{
			return n.count - itemCount >= this.factor;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003F10 File Offset: 0x00002110
		private object[] Expand_Collapse(global::Infragistics.Collections.SparseArray.Node n, int capacity)
		{
			object[] arr = n.arr;
			int num = (arr != null) ? arr.Length : 0;
			if (capacity <= num && num - capacity < this.growBy)
			{
				return arr;
			}
			int num2 = capacity / this.growBy * this.growBy;
			if (num2 < capacity)
			{
				num2 += this.growBy;
			}
			if (num2 > this.MaxFactor + 1)
			{
				num2 = global::System.Math.Max(capacity, this.MaxFactor + 1);
			}
			object[] result = arr;
			n.arr = new object[num2];
			return result;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003F85 File Offset: 0x00002185
		private object GetOwnerDataHelper(object item)
		{
			if (!this.useOwnerData || item == null)
			{
				return null;
			}
			return this.GetOwnerData(item);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00003F9B File Offset: 0x0000219B
		private void SetOwnerDataHelper(global::Infragistics.Collections.SparseArray.Node n, int startIndex, int count)
		{
			this.SetOwnerDataHelper(n.arr, n, startIndex, count);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00003FAC File Offset: 0x000021AC
		private void SetOwnerDataHelper(object[] arr, object ownerData, int startIndex, int count)
		{
			if (this.useOwnerData && arr != null)
			{
				count += startIndex;
				for (int i = startIndex; i < count; i++)
				{
					this.SetOwnerDataHelper(arr[i], ownerData);
				}
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003FE1 File Offset: 0x000021E1
		private void SetOwnerDataHelper(object item, object ownerData)
		{
			if (this.useOwnerData && item != null)
			{
				this.SetOwnerData(item, ownerData);
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00003FF6 File Offset: 0x000021F6
		private void ClearOwnerData(global::Infragistics.Collections.SparseArray.Node n, int startIndex, int count)
		{
			if (n != null)
			{
				this.ClearOwnerData(n.arr, startIndex, count);
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00004009 File Offset: 0x00002209
		private void ClearOwnerData(object[] arr, int startIndex, int count)
		{
			this.SetOwnerDataHelper(arr, null, startIndex, count);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00004018 File Offset: 0x00002218
		private void Array_Insert(global::Infragistics.Collections.SparseArray.Node n, int index, object item)
		{
			if (n.arr != null || item != null)
			{
				object[] array = this.Expand_Collapse(n, 1 + n.count);
				if (array != null)
				{
					if (array != n.arr && index > 0)
					{
						global::System.Array.Copy(array, 0, n.arr, 0, index);
					}
					if (index < n.count)
					{
						global::System.Array.Copy(array, index, n.arr, index + 1, n.count - index);
					}
				}
				n.arr[index] = item;
				this.SetOwnerDataHelper(item, n);
			}
			n.count++;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000409F File Offset: 0x0000229F
		private void Array_Remove(global::Infragistics.Collections.SparseArray.Node n, int index)
		{
			this.Array_RemoveRange(n, index, 1, true);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000040AC File Offset: 0x000022AC
		private void Array_RemoveRange(global::Infragistics.Collections.SparseArray.Node n, int index, int count, bool clearOwnerData)
		{
			if (n.arr != null)
			{
				if (count < n.count)
				{
					object[] array = this.Expand_Collapse(n, n.count - count);
					if (array != n.arr && index > 0)
					{
						global::System.Array.Copy(array, 0, n.arr, 0, index);
					}
					if (clearOwnerData)
					{
						this.ClearOwnerData(array, index, count);
					}
					if (index + count < n.count)
					{
						global::System.Array.Copy(array, index + count, n.arr, index, n.count - (index + count));
					}
					if (array == n.arr)
					{
						global::System.Array.Clear(array, n.count - count, count);
					}
				}
				else
				{
					if (clearOwnerData)
					{
						this.ClearOwnerData(n, 0, n.count);
					}
					n.arr = null;
				}
			}
			n.count -= count;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000416C File Offset: 0x0000236C
		private void Array_InsertRange(global::Infragistics.Collections.SparseArray.Node dest, int destIndex, global::Infragistics.Collections.SparseArray.Node src, int srcIndex, int count)
		{
			if (dest.arr != null || (src != null && src.arr != null))
			{
				object[] array = this.Expand_Collapse(dest, count + dest.count);
				if (array != dest.arr && destIndex > 0 && array != null)
				{
					global::System.Array.Copy(array, 0, dest.arr, 0, destIndex);
				}
				if (destIndex < dest.count && array != null)
				{
					global::System.Array.Copy(array, destIndex, dest.arr, destIndex + count, dest.count - destIndex);
				}
				if (src != null && src.arr != null)
				{
					global::System.Array.Copy(src.arr, srcIndex, dest.arr, destIndex, count);
					this.SetOwnerDataHelper(dest, destIndex, count);
				}
				else if (array == dest.arr)
				{
					global::System.Array.Clear(array, destIndex, count);
				}
			}
			dest.count += count;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00004238 File Offset: 0x00002438
		private bool Array_AreAllItemsNull(global::Infragistics.Collections.SparseArray.Node n)
		{
			object[] arr = n.arr;
			if (arr != null)
			{
				for (int i = 0; i < arr.Length; i++)
				{
					if (arr[i] != null)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00004268 File Offset: 0x00002468
		private void Lend(global::Infragistics.Collections.SparseArray.Node nodeFrom, global::Infragistics.Collections.SparseArray.Node nodeTo, int itemsToLend, bool toLeft)
		{
			if (nodeTo.count == 0 && nodeFrom != null && itemsToLend == nodeFrom.count)
			{
				nodeTo.arr = nodeFrom.arr;
				nodeFrom.arr = null;
				nodeTo.count = nodeFrom.count;
				nodeFrom.count = 0;
				this.SetOwnerDataHelper(nodeTo, 0, nodeTo.count);
				return;
			}
			if (toLeft)
			{
				this.Array_InsertRange(nodeTo, 0, nodeFrom, (nodeFrom != null) ? (nodeFrom.count - itemsToLend) : 0, itemsToLend);
				if (nodeFrom != null)
				{
					this.Array_RemoveRange(nodeFrom, nodeFrom.count - itemsToLend, itemsToLend, false);
					return;
				}
			}
			else
			{
				this.Array_InsertRange(nodeTo, nodeTo.count, nodeFrom, 0, itemsToLend);
				if (nodeFrom != null)
				{
					this.Array_RemoveRange(nodeFrom, 0, itemsToLend, false);
				}
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000430C File Offset: 0x0000250C
		private static global::Infragistics.Collections.SparseArray.Node GetMaximum(global::Infragistics.Collections.SparseArray.Node n)
		{
			if (n != null)
			{
				while (n.right != null)
				{
					n = n.right;
				}
			}
			return n;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00004324 File Offset: 0x00002524
		private static global::Infragistics.Collections.SparseArray.Node GetMinimum(global::Infragistics.Collections.SparseArray.Node n)
		{
			if (n != null)
			{
				while (n.left != null)
				{
					n = n.left;
				}
			}
			return n;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000433C File Offset: 0x0000253C
		private static global::Infragistics.Collections.SparseArray.Node GetPredecessor(global::Infragistics.Collections.SparseArray.Node n)
		{
			if (n.left != null)
			{
				return global::Infragistics.Collections.SparseArray.GetMaximum(n.left);
			}
			while (n.parent != null)
			{
				if (n == n.parent.right)
				{
					return n.parent;
				}
				n = n.parent;
			}
			return null;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00004378 File Offset: 0x00002578
		private static global::Infragistics.Collections.SparseArray.Node GetSuccessor(global::Infragistics.Collections.SparseArray.Node n)
		{
			if (n.right != null)
			{
				return global::Infragistics.Collections.SparseArray.GetMinimum(n.right);
			}
			while (n.parent != null)
			{
				if (n == n.parent.left)
				{
					return n.parent;
				}
				n = n.parent;
			}
			return null;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000043B4 File Offset: 0x000025B4
		private void FixupNode(global::Infragistics.Collections.SparseArray.Node n)
		{
			while (n != null)
			{
				if (n.count >= this.factor)
				{
					break;
				}
				int num = this.factor - n.count;
				int num2 = num;
				if (n.parent == null && n.leftCount == 0 && n.rightCount == 0)
				{
					break;
				}
				global::Infragistics.Collections.SparseArray.Node node;
				if (n.parent != null && ((n == n.parent.left && n.rightCount == 0) || (n == n.parent.right && n.leftCount == 0)))
				{
					if (this.CanBorrow(n.parent, num))
					{
						this.Lend(n.parent, n, num, n != n.parent.left);
						if (n == n.parent.left)
						{
							n.parent.leftCount += num;
						}
						else
						{
							n.parent.rightCount += num;
						}
						this.DirtyScrollCount(n);
					}
					else
					{
						int num3 = n.count;
						if (num3 > 0)
						{
							this.Lend(n, n.parent, num3, n.parent.left == n);
						}
						if (n == n.parent.left)
						{
							n.parent.leftCount -= num3;
							n.parent.left = n.left;
							if (n.left != null)
							{
								n.left.parent = n.parent;
							}
						}
						else
						{
							n.parent.rightCount -= num3;
							n.parent.right = n.right;
							if (n.right != null)
							{
								n.right.parent = n.parent;
							}
						}
					}
					node = n.parent;
					n = null;
				}
				else
				{
					bool flag = n.leftCount > n.rightCount;
					if (flag)
					{
						if (n.left == null)
						{
							int num3 = global::System.Math.Min(n.leftCount, num);
							this.Lend(null, n, num3, true);
							num -= num3;
							n.leftCount -= num3;
							node = n;
						}
						else
						{
							global::Infragistics.Collections.SparseArray.Node node2 = global::Infragistics.Collections.SparseArray.GetMaximum(n.left);
							int num3;
							if (node2.rightCount > 0)
							{
								num3 = global::System.Math.Min(node2.rightCount, num);
								this.Lend(null, n, num3, true);
								node2.rightCount -= num3;
								num -= num3;
							}
							if (num > 0)
							{
								num3 = (this.CanBorrow(node2, num) ? num : node2.count);
								this.Lend(node2, n, num3, true);
								num -= num3;
							}
							node = node2;
							if (node2.count == 0)
							{
								if (node2 == node2.parent.left)
								{
									node2.parent.left = node2.left;
								}
								else
								{
									node2.parent.right = node2.left;
								}
								if (node2.left != null)
								{
									node2.left.parent = node2.parent;
								}
								node = node2.parent;
							}
							num3 = num2 - num;
							n.leftCount -= num3;
							while (node2.parent != n)
							{
								node2 = node2.parent;
								node2.rightCount -= num3;
							}
						}
					}
					else if (n.right == null)
					{
						int num3 = global::System.Math.Min(n.rightCount, num);
						this.Lend(null, n, num3, false);
						num -= num3;
						n.rightCount -= num3;
						node = n;
					}
					else
					{
						global::Infragistics.Collections.SparseArray.Node node3 = global::Infragistics.Collections.SparseArray.GetMinimum(n.right);
						int num3;
						if (node3.leftCount > 0)
						{
							num3 = global::System.Math.Min(node3.leftCount, num);
							this.Lend(null, n, num3, false);
							node3.leftCount -= num3;
							num -= num3;
						}
						if (num > 0)
						{
							num3 = (this.CanBorrow(node3, num) ? num : node3.count);
							this.Lend(node3, n, num3, false);
							num -= num3;
						}
						node = node3;
						if (node3.count == 0)
						{
							if (node3 == node3.parent.left)
							{
								node3.parent.left = node3.right;
							}
							else
							{
								node3.parent.right = node3.right;
							}
							if (node3.right != null)
							{
								node3.right.parent = node3.parent;
							}
							node = node3.parent;
						}
						num3 = num2 - num;
						n.rightCount -= num3;
						while (node3.parent != n)
						{
							node3 = node3.parent;
							node3.leftCount -= num3;
						}
					}
				}
				if (node != null)
				{
					this.DirtyScrollCount(node);
					if (n != null && node != n)
					{
						this.DirtyScrollCount(n);
					}
					this.MaintainAncestors(node);
				}
			}
			while (n != null && n.count > this.MaxFactor)
			{
				global::Infragistics.Collections.SparseArray.Node node4 = this.CreateNode();
				bool flag2 = n.leftCount < n.rightCount;
				this.Lend(n, node4, this.factor, !flag2);
				if (flag2)
				{
					n.leftCount += node4.count;
					if (n.left == null)
					{
						n.left = node4;
						node4.parent = n;
					}
					else
					{
						global::Infragistics.Collections.SparseArray.Node node5 = n.left;
						node5.rightCount += node4.count;
						while (node5.right != null)
						{
							node5 = node5.right;
							node5.rightCount += node4.count;
						}
						node5.right = node4;
						node4.parent = node5;
					}
					if (node4 == node4.parent.left)
					{
						node4.leftCount = node4.parent.leftCount - node4.count;
					}
					else
					{
						node4.leftCount = node4.parent.rightCount - node4.count;
					}
				}
				else
				{
					n.rightCount += node4.count;
					if (n.right == null)
					{
						n.right = node4;
						node4.parent = n;
					}
					else
					{
						global::Infragistics.Collections.SparseArray.Node node6 = n.right;
						node6.leftCount += node4.count;
						while (node6.left != null)
						{
							node6 = node6.left;
							node6.leftCount += node4.count;
						}
						node6.left = node4;
						node4.parent = node6;
					}
					if (node4 == node4.parent.right)
					{
						node4.rightCount = node4.parent.rightCount - node4.count;
					}
					else
					{
						node4.rightCount = node4.parent.leftCount - node4.count;
					}
				}
				this.DirtyScrollCount(n);
				this.DirtyScrollCount(node4);
				if (node4.parent != null)
				{
					this.MaintainAncestors(node4.parent);
				}
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00004A4C File Offset: 0x00002C4C
		private global::Infragistics.Collections.SparseArray.Node RotateLeft(global::Infragistics.Collections.SparseArray.Node p)
		{
			global::Infragistics.Collections.SparseArray.Node right = p.right;
			if (right != null)
			{
				if (p == this.tree)
				{
					this.tree = right;
				}
				else if (p == p.parent.left)
				{
					p.parent.left = right;
				}
				else if (p == p.parent.right)
				{
					p.parent.right = right;
				}
				right.parent = p.parent;
				p.parent = right;
				p.right = right.left;
				right.left = p;
				if (p.right != null)
				{
					p.right.parent = p;
				}
				p.rightCount = right.leftCount;
				right.leftCount = p.TotalCount;
			}
			return right;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00004B04 File Offset: 0x00002D04
		private global::Infragistics.Collections.SparseArray.Node RotateRight(global::Infragistics.Collections.SparseArray.Node p)
		{
			global::Infragistics.Collections.SparseArray.Node left = p.left;
			if (left != null)
			{
				if (p == this.tree)
				{
					this.tree = left;
				}
				else if (p == p.parent.left)
				{
					p.parent.left = left;
				}
				else if (p == p.parent.right)
				{
					p.parent.right = left;
				}
				left.parent = p.parent;
				p.parent = left;
				p.left = left.right;
				left.right = p;
				if (p.left != null)
				{
					p.left.parent = p;
				}
				p.leftCount = left.rightCount;
				left.rightCount = p.TotalCount;
			}
			return left;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00004BBC File Offset: 0x00002DBC
		private void Maintain(global::Infragistics.Collections.SparseArray.Node p)
		{
			while (p != null)
			{
				global::Infragistics.Collections.SparseArray.Node node = null;
				if (p.rightCount > p.leftCount && p.right != null)
				{
					int num = p.leftCount + p.count + p.right.leftCount;
					int num2 = p.right.rightCount;
					if (global::System.Math.Abs(num2 - num) < p.rightCount - p.leftCount)
					{
						node = this.RotateLeft(p);
					}
					else if (this.factor + p.rightCount >= (this.factor + p.leftCount) * 4)
					{
						global::Infragistics.Collections.SparseArray.Node right = p.right;
						if (this.RotateRight(right) != null)
						{
							this.DirtyScrollCount(right, false, false);
							node = this.RotateLeft(p);
						}
					}
				}
				if (p.leftCount > p.rightCount && node == null && p.left != null)
				{
					int num = p.left.leftCount;
					int num2 = p.count + p.rightCount + p.left.rightCount;
					if (global::System.Math.Abs(num - num2) < p.leftCount - p.rightCount)
					{
						node = this.RotateRight(p);
					}
					else if (this.factor + p.leftCount >= (this.factor + p.rightCount) * 4)
					{
						global::Infragistics.Collections.SparseArray.Node left = p.left;
						if (this.RotateLeft(left) != null)
						{
							this.DirtyScrollCount(left, false, false);
							node = this.RotateRight(p);
						}
					}
				}
				if (node != null)
				{
					this.DirtyScrollCount(p, false, false);
					this.Maintain(p);
				}
				p = node;
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004D39 File Offset: 0x00002F39
		private void MaintainAncestors(global::Infragistics.Collections.SparseArray.Node n)
		{
			while (n != null)
			{
				this.Maintain(n);
				n = n.parent;
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00004D50 File Offset: 0x00002F50
		private global::Infragistics.Collections.SparseArray.Node GetNodeContainingIndex(ref int indexVal, bool forceCreation)
		{
			global::Infragistics.Collections.SparseArray.Node node = null;
			global::Infragistics.Collections.SparseArray.Node node2 = this.tree;
			int num = indexVal;
			bool flag = false;
			while (node2 != null)
			{
				node = node2;
				if (num < node2.leftCount)
				{
					node2 = node2.left;
					flag = true;
				}
				else
				{
					num -= node2.leftCount;
					if (num < node2.count)
					{
						break;
					}
					num -= node2.count;
					node2 = node2.right;
					flag = false;
				}
			}
			if (node2 == null && forceCreation)
			{
				bool flag2 = true;
				if (flag)
				{
					if (node.leftCount < this.factor)
					{
						if (this.CanBorrow(node, this.factor - node.leftCount))
						{
							node2 = (node.left = this.CreateNode(node));
							node2.count = node.leftCount;
							this.Lend(node, node2, this.factor - node.leftCount, false);
							node.leftCount = node2.count;
						}
						else
						{
							this.Lend(null, node, node.leftCount, true);
							node.leftCount = 0;
							node2 = node;
						}
					}
					else
					{
						node2 = (node.left = this.CreateNode(node));
						node2.leftCount = this.factor * (num / this.factor);
						node2.count = this.factor;
						if (node2.leftCount + node2.count > node.leftCount)
						{
							node2.leftCount = node.leftCount - this.factor;
						}
						node2.rightCount = node.leftCount - (node2.leftCount + node2.count);
						num -= node2.leftCount;
						flag2 = false;
					}
				}
				else if (node.rightCount < this.factor)
				{
					int num2 = this.factor - node.rightCount;
					if (this.CanBorrow(node, num2))
					{
						node2 = (node.right = this.CreateNode(node));
						node2.count = node.rightCount;
						this.Lend(node, node2, num2, true);
						node.rightCount = node2.count;
						num += num2;
					}
					else
					{
						num += node.count;
						this.Lend(null, node, node.rightCount, false);
						node.rightCount = 0;
						node2 = node;
					}
				}
				else
				{
					node2 = (node.right = this.CreateNode(node));
					node2.leftCount = this.factor * (num / this.factor);
					node2.count = this.factor;
					if (node2.leftCount + node2.count > node.rightCount)
					{
						node2.leftCount = node.rightCount - this.factor;
					}
					node2.rightCount = node.rightCount - (node2.leftCount + node2.count);
					num -= node2.leftCount;
					flag2 = false;
				}
				if (this.manageScrollCounts)
				{
					global::Infragistics.Collections.SparseArray.NodeExtended nodeExtended = (global::Infragistics.Collections.SparseArray.NodeExtended)node2;
					if (!flag2)
					{
						nodeExtended.leftScrollCount = (nodeExtended.leftVisibleCount = node2.leftCount);
						nodeExtended.scrollCount = (nodeExtended.visibleCount = node2.count);
						nodeExtended.rightScrollCount = (nodeExtended.rightVisibleCount = node2.rightCount);
						nodeExtended.ScrollCounts = null;
					}
					else
					{
						this.DirtyScrollCount(node2);
					}
				}
				if (node2 != node)
				{
					if (flag2)
					{
						this.DirtyScrollCount(node);
					}
					this.Maintain(node);
				}
			}
			indexVal = num;
			return node2;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00005054 File Offset: 0x00003254
		private int GetNodeStartIndex(global::Infragistics.Collections.SparseArray.Node n)
		{
			int num = n.leftCount;
			while (n.parent != null)
			{
				if (n == n.parent.right)
				{
					num += n.parent.leftCount + n.parent.count;
				}
				else if (n != n.parent.left)
				{
					return -1;
				}
				n = n.parent;
			}
			if (n != this.tree)
			{
				num = -1;
			}
			return num;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000050C0 File Offset: 0x000032C0
		private int IndexOf(global::Infragistics.Collections.SparseArray.Node n, object item)
		{
			if (n.left != null)
			{
				int num = this.IndexOf(n.left, item);
				if (num >= 0)
				{
					return num;
				}
			}
			else if (item == null && n.leftCount > 0)
			{
				return 0;
			}
			if (n.arr != null)
			{
				int num = global::System.Array.IndexOf<object>(n.arr, item, 0, n.count);
				if (num >= 0)
				{
					return num + n.leftCount;
				}
			}
			else if (item == null && n.count > 0)
			{
				return n.leftCount;
			}
			if (n.right != null)
			{
				int num = this.IndexOf(n.right, item);
				if (num >= 0)
				{
					return num + n.leftCount + n.count;
				}
			}
			else if (item == null && n.rightCount > 0)
			{
				return n.leftCount + n.count;
			}
			return -1;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00005178 File Offset: 0x00003378
		private void ClearOwnerDataTreeWide(global::Infragistics.Collections.SparseArray.Node n)
		{
			if (n.left != null)
			{
				this.ClearOwnerDataTreeWide(n.left);
			}
			this.ClearOwnerData(n, 0, n.count);
			if (n.right != null)
			{
				this.ClearOwnerDataTreeWide(n.right);
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000051B0 File Offset: 0x000033B0
		private void SetOwnerDataTreeWide(global::Infragistics.Collections.SparseArray.Node n)
		{
			if (n.left != null)
			{
				this.SetOwnerDataTreeWide(n.left);
			}
			this.SetOwnerDataHelper(n, 0, n.count);
			if (n.right != null)
			{
				this.SetOwnerDataTreeWide(n.right);
			}
		}

		// Token: 0x060000AC RID: 172 RVA: 0x000051E8 File Offset: 0x000033E8
		private void CopyToHelper(global::Infragistics.Collections.SparseArray.Node n, global::System.Array array, ref int index)
		{
			if (n.left != null)
			{
				this.CopyToHelper(n.left, array, ref index);
			}
			else if (n.leftCount > 0)
			{
				global::System.Array.Clear(array, index, n.leftCount);
				index += n.leftCount;
			}
			if (n.arr != null)
			{
				global::System.Array.Copy(n.arr, 0, array, index, n.count);
			}
			else
			{
				global::System.Array.Clear(array, index, n.count);
			}
			index += n.count;
			if (n.right != null)
			{
				this.CopyToHelper(n.right, array, ref index);
				return;
			}
			if (n.rightCount > 0)
			{
				global::System.Array.Clear(array, index, n.rightCount);
				index += n.rightCount;
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000052A0 File Offset: 0x000034A0
		private global::Infragistics.Collections.SparseArray.Node CreateNode()
		{
			return this.CreateNode(null);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000052A9 File Offset: 0x000034A9
		private global::Infragistics.Collections.SparseArray.Node CreateNode(global::Infragistics.Collections.SparseArray.Node parent)
		{
			if (!this.manageScrollCounts)
			{
				return new global::Infragistics.Collections.SparseArray.Node(parent);
			}
			if (this._cacheScrollCounts)
			{
				return new global::Infragistics.Collections.SparseArray.NodeExtendedWithScrollCountCache((global::Infragistics.Collections.SparseArray.NodeExtendedWithScrollCountCache)parent);
			}
			return new global::Infragistics.Collections.SparseArray.NodeExtended((global::Infragistics.Collections.SparseArray.NodeExtended)parent);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000052DC File Offset: 0x000034DC
		private int GetNodeStartVisibleIndex(global::Infragistics.Collections.SparseArray.NodeExtended n)
		{
			int num = n.leftVisibleCount;
			while (n.parent != null)
			{
				global::Infragistics.Collections.SparseArray.NodeExtended nodeExtended = (global::Infragistics.Collections.SparseArray.NodeExtended)n.parent;
				if (n == nodeExtended.right)
				{
					num += nodeExtended.leftVisibleCount + nodeExtended.visibleCount;
				}
				else if (n != nodeExtended.left)
				{
					return -1;
				}
				n = nodeExtended;
			}
			if (n != this.tree)
			{
				num = -1;
			}
			return num;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000533C File Offset: 0x0000353C
		private int GetNodeStartScrollIndex(global::Infragistics.Collections.SparseArray.NodeExtended n)
		{
			int num = n.leftScrollCount;
			while (n.parent != null)
			{
				global::Infragistics.Collections.SparseArray.NodeExtended nodeExtended = (global::Infragistics.Collections.SparseArray.NodeExtended)n.parent;
				if (n == nodeExtended.right)
				{
					num += nodeExtended.leftScrollCount + nodeExtended.scrollCount;
				}
				else if (n != nodeExtended.left)
				{
					return -1;
				}
				n = nodeExtended;
			}
			if (n != this.tree)
			{
				num = -1;
			}
			return num;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000539C File Offset: 0x0000359C
		private object CreateItemHelper(global::Infragistics.Collections.ICreateItemCallback createItemCallback, global::Infragistics.Collections.SparseArray.Node node, int nodeIndex, int overallIndex)
		{
			object obj = node.ItemsArray[nodeIndex];
			object obj2 = createItemCallback.CreateItem(this, overallIndex);
			node.ItemsArray[nodeIndex] = obj2;
			this.SetOwnerDataHelper(obj2, node);
			if (obj2 != null)
			{
				if (this.manageScrollCounts)
				{
					global::Infragistics.Collections.ISparseArrayMultiItem item = (global::Infragistics.Collections.ISparseArrayMultiItem)obj2;
					global::Infragistics.Collections.ISparseArrayMultiItem item2 = (global::Infragistics.Collections.ISparseArrayMultiItem)obj;
					int visibleDelta = global::Infragistics.Collections.SparseArray.GetItemVisibleCount(item) - global::Infragistics.Collections.SparseArray.GetItemVisibleCount(item2);
					int scrollDelta = global::Infragistics.Collections.SparseArray.GetItemScrollCount(item) - global::Infragistics.Collections.SparseArray.GetItemScrollCount(item2);
					this.ApplyScrollDelta((global::Infragistics.Collections.SparseArray.NodeExtended)node, visibleDelta, scrollDelta);
				}
				this.OnItemCreated(obj2, overallIndex);
			}
			return obj2;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00005420 File Offset: 0x00003620
		private void ApplyScrollDelta(global::Infragistics.Collections.SparseArray.NodeExtended node, int visibleDelta, int scrollDelta)
		{
			if (visibleDelta != 0 || scrollDelta != 0)
			{
				global::Infragistics.Collections.SparseArray.NodeExtended nodeExtended = node;
				nodeExtended.visibleCount += visibleDelta;
				nodeExtended.scrollCount += scrollDelta;
				nodeExtended.ScrollCounts = global::Infragistics.Collections.SparseArray.NodeExtendedWithScrollCountCache.g_dirtyFlag;
				while (nodeExtended.parent != null)
				{
					global::Infragistics.Collections.SparseArray.NodeExtended nodeExtended2 = (global::Infragistics.Collections.SparseArray.NodeExtended)nodeExtended.parent;
					if (nodeExtended == nodeExtended2.left)
					{
						nodeExtended2.leftVisibleCount += visibleDelta;
						nodeExtended2.leftScrollCount += scrollDelta;
					}
					else
					{
						nodeExtended2.rightVisibleCount += visibleDelta;
						nodeExtended2.rightScrollCount += scrollDelta;
					}
					nodeExtended = nodeExtended2;
				}
				this.OnScrollCountChanged();
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000054C0 File Offset: 0x000036C0
		private static int GetItemVisibleCount(global::Infragistics.Collections.ISparseArrayMultiItem item)
		{
			if (item == null)
			{
				return 1;
			}
			if (item.ScrollCount <= 0)
			{
				return 0;
			}
			return 1;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000054D3 File Offset: 0x000036D3
		private static int GetItemScrollCount(global::Infragistics.Collections.ISparseArrayMultiItem item)
		{
			if (item == null)
			{
				return 1;
			}
			return item.ScrollCount;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000054E0 File Offset: 0x000036E0
		private void EnsureScrollCountCalculated()
		{
			bool inEnsureScrollCountCalculated = this._inEnsureScrollCountCalculated;
			this._inEnsureScrollCountCalculated = true;
			try
			{
				this.EnsureScrollCountCalculatedHelper((global::Infragistics.Collections.SparseArray.NodeExtended)this.tree);
				this.scrollCountInfoDirtyOnAllNodes = false;
				this.onScrollCountChangedCalledBefore = false;
			}
			finally
			{
				this._inEnsureScrollCountCalculated = inEnsureScrollCountCalculated;
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00005538 File Offset: 0x00003738
		private void EnsureScrollCountCalculatedHelper(global::Infragistics.Collections.SparseArray.NodeExtended n)
		{
			if (n.isLeftDirty || this.scrollCountInfoDirtyOnAllNodes)
			{
				global::Infragistics.Collections.SparseArray.NodeExtended nodeExtended = (global::Infragistics.Collections.SparseArray.NodeExtended)n.left;
				if (nodeExtended != null)
				{
					this.EnsureScrollCountCalculatedHelper(nodeExtended);
					n.leftVisibleCount = nodeExtended.TotalVisibleCount;
					n.leftScrollCount = nodeExtended.TotalScrollCount;
				}
				else
				{
					n.leftVisibleCount = n.leftCount;
					n.leftScrollCount = n.leftCount;
				}
			}
			if (n.isNodeDirty || this.scrollCountInfoDirtyOnAllNodes)
			{
				if (n.arr == null)
				{
					n.visibleCount = n.count;
					n.scrollCount = n.count;
					n.ScrollCounts = null;
				}
				else
				{
					int num = 0;
					int num2 = 0;
					int[] array = null;
					if (this._cacheScrollCounts)
					{
						array = n.ScrollCounts;
						if (array == null || array.Length != n.count)
						{
							array = new int[n.count];
						}
						n.ScrollCounts = global::Infragistics.Collections.SparseArray.NodeExtendedWithScrollCountCache.g_dirtyFlag;
					}
					for (int i = 0; i < n.count; i++)
					{
						global::Infragistics.Collections.ISparseArrayMultiItem sparseArrayMultiItem = (global::Infragistics.Collections.ISparseArrayMultiItem)n.arr[i];
						if (sparseArrayMultiItem != null)
						{
							int scrollCount = sparseArrayMultiItem.ScrollCount;
							if (scrollCount < 0)
							{
								throw new global::System.InvalidOperationException(global::Infragistics.Collections.SparseArray.GetString("LE_InvalidOperationException_2"));
							}
							num += ((scrollCount > 0) ? 1 : 0);
							num2 += scrollCount;
						}
						else
						{
							num++;
							num2++;
						}
						if (array != null)
						{
							array[i] = num2;
						}
					}
					n.visibleCount = num;
					n.scrollCount = num2;
					n.ScrollCounts = array;
				}
			}
			if (n.isRightDirty || this.scrollCountInfoDirtyOnAllNodes)
			{
				global::Infragistics.Collections.SparseArray.NodeExtended nodeExtended2 = (global::Infragistics.Collections.SparseArray.NodeExtended)n.right;
				if (nodeExtended2 != null)
				{
					this.EnsureScrollCountCalculatedHelper(nodeExtended2);
					n.rightVisibleCount = nodeExtended2.TotalVisibleCount;
					n.rightScrollCount = nodeExtended2.TotalScrollCount;
				}
				else
				{
					n.rightVisibleCount = n.rightCount;
					n.rightScrollCount = n.rightCount;
				}
			}
			n.isLeftDirty = (n.isNodeDirty = (n.isRightDirty = false));
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000570F File Offset: 0x0000390F
		private void DirtyScrollCount(global::Infragistics.Collections.SparseArray.Node node)
		{
			this.DirtyScrollCount(node, true, false);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000571A File Offset: 0x0000391A
		private void DirtyScrollCount_OverallScrollCountChanged(global::Infragistics.Collections.SparseArray.Node node)
		{
			this.DirtyScrollCount(node, true, true);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00005728 File Offset: 0x00003928
		private void DirtyScrollCount(global::Infragistics.Collections.SparseArray.Node node, bool setIsNodeDirtyFlag, bool overallScrollCountChanged)
		{
			if (this.manageScrollCounts && !this.scrollCountInfoDirtyOnAllNodes && node != null)
			{
				global::Infragistics.Collections.SparseArray.NodeExtended nodeExtended = (global::Infragistics.Collections.SparseArray.NodeExtended)node;
				nodeExtended.isLeftDirty = (nodeExtended.isRightDirty = true);
				if (setIsNodeDirtyFlag)
				{
					nodeExtended.isNodeDirty = true;
					nodeExtended.ScrollCounts = global::Infragistics.Collections.SparseArray.NodeExtendedWithScrollCountCache.g_dirtyFlag;
				}
				while (nodeExtended.parent != null)
				{
					global::Infragistics.Collections.SparseArray.NodeExtended nodeExtended2 = (global::Infragistics.Collections.SparseArray.NodeExtended)nodeExtended.parent;
					if (nodeExtended == nodeExtended2.left)
					{
						if (nodeExtended2.isLeftDirty)
						{
							break;
						}
						nodeExtended2.isLeftDirty = true;
					}
					else
					{
						if (nodeExtended2.isRightDirty)
						{
							break;
						}
						nodeExtended2.isRightDirty = true;
					}
					nodeExtended = nodeExtended2;
				}
				if (overallScrollCountChanged && !this.onScrollCountChangedCalledBefore)
				{
					this.onScrollCountChangedCalledBefore = true;
					this.OnScrollCountChanged();
				}
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000057D8 File Offset: 0x000039D8
		private void ReplaceAllItems(global::System.Collections.ICollection newItems)
		{
			bool flag = this.onScrollCountChangedCalledBefore;
			this.onScrollCountChangedCalledBefore = true;
			try
			{
				this.Clear(false);
				this.AddRange(newItems);
			}
			finally
			{
				this.onScrollCountChangedCalledBefore = flag;
			}
			this.DirtyScrollCountInfo();
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000BB RID: 187 RVA: 0x00005824 File Offset: 0x00003A24
		bool global::System.Collections.IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00005827 File Offset: 0x00003A27
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000582A File Offset: 0x00003A2A
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return new global::Infragistics.Collections.SparseArray.Enumerator(this);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00005832 File Offset: 0x00003A32
		public global::System.Collections.IEnumerator GetEnumerator(global::Infragistics.Collections.ICreateItemCallback createItemCallback)
		{
			return new global::Infragistics.Collections.SparseArray.CreateItemEnumerator(this, createItemCallback);
		}

		// Token: 0x04000014 RID: 20
		private const int DEFAULT_FACTOR = 40;

		// Token: 0x04000015 RID: 21
		private const float DEFAULT_GROWTH_FACTOR = 0.25f;

		// Token: 0x04000016 RID: 22
		private const int NULL_ITEM_VISIBLE_COUNT = 1;

		// Token: 0x04000017 RID: 23
		private const int NULL_ITEM_SCROLL_COUNT = 1;

		// Token: 0x04000018 RID: 24
		private global::Infragistics.Collections.SparseArray.Node tree;

		// Token: 0x04000019 RID: 25
		private int factor;

		// Token: 0x0400001A RID: 26
		private int growBy;

		// Token: 0x0400001B RID: 27
		private bool scrollCountInfoDirtyOnAllNodes;

		// Token: 0x0400001C RID: 28
		private bool useOwnerData;

		// Token: 0x0400001D RID: 29
		private bool manageScrollCounts;

		// Token: 0x0400001E RID: 30
		private bool onScrollCountChangedCalledBefore;

		// Token: 0x0400001F RID: 31
		private bool _inEnsureScrollCountCalculated;

		// Token: 0x04000020 RID: 32
		private bool _cacheScrollCounts;

		// Token: 0x02000009 RID: 9
		private class Node
		{
			// Token: 0x060000BF RID: 191 RVA: 0x0000583B File Offset: 0x00003A3B
			internal Node()
			{
			}

			// Token: 0x060000C0 RID: 192 RVA: 0x00005843 File Offset: 0x00003A43
			internal Node(global::Infragistics.Collections.SparseArray.Node parent)
			{
				this.parent = parent;
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x060000C1 RID: 193 RVA: 0x00005852 File Offset: 0x00003A52
			internal int TotalCount
			{
				get
				{
					return this.leftCount + this.rightCount + this.count;
				}
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x060000C2 RID: 194 RVA: 0x00005868 File Offset: 0x00003A68
			internal object[] ItemsArray
			{
				get
				{
					if (this.arr == null)
					{
						return this.arr = new object[this.count];
					}
					return this.arr;
				}
			}

			// Token: 0x060000C3 RID: 195 RVA: 0x00005898 File Offset: 0x00003A98
			public override string ToString()
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				stringBuilder.Append(base.GetType().Name).Append(" ").Append(this.GetHashCode());
				stringBuilder.Append(" ").Append((this.parent != null) ? ((this == this.parent.left) ? "lc" : ((this == this.parent.right) ? "rc" : "invalid")) : "no parent");
				return stringBuilder.ToString();
			}

			// Token: 0x04000021 RID: 33
			internal global::Infragistics.Collections.SparseArray.Node parent;

			// Token: 0x04000022 RID: 34
			internal global::Infragistics.Collections.SparseArray.Node left;

			// Token: 0x04000023 RID: 35
			internal global::Infragistics.Collections.SparseArray.Node right;

			// Token: 0x04000024 RID: 36
			internal int leftCount;

			// Token: 0x04000025 RID: 37
			internal int rightCount;

			// Token: 0x04000026 RID: 38
			internal int count;

			// Token: 0x04000027 RID: 39
			internal object[] arr;
		}

		// Token: 0x0200000A RID: 10
		private class NodeExtended : global::Infragistics.Collections.SparseArray.Node
		{
			// Token: 0x060000C4 RID: 196 RVA: 0x00005927 File Offset: 0x00003B27
			internal NodeExtended()
			{
			}

			// Token: 0x060000C5 RID: 197 RVA: 0x0000592F File Offset: 0x00003B2F
			internal NodeExtended(global::Infragistics.Collections.SparseArray.NodeExtended parent) : base(parent)
			{
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x060000C6 RID: 198 RVA: 0x00005938 File Offset: 0x00003B38
			internal int TotalVisibleCount
			{
				get
				{
					return this.leftVisibleCount + this.visibleCount + this.rightVisibleCount;
				}
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000594E File Offset: 0x00003B4E
			internal int TotalScrollCount
			{
				get
				{
					return this.leftScrollCount + this.scrollCount + this.rightScrollCount;
				}
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000C8 RID: 200 RVA: 0x00005964 File Offset: 0x00003B64
			// (set) Token: 0x060000C9 RID: 201 RVA: 0x00005967 File Offset: 0x00003B67
			internal virtual int[] ScrollCounts
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			// Token: 0x04000028 RID: 40
			internal int visibleCount;

			// Token: 0x04000029 RID: 41
			internal int leftVisibleCount;

			// Token: 0x0400002A RID: 42
			internal int rightVisibleCount;

			// Token: 0x0400002B RID: 43
			internal int scrollCount;

			// Token: 0x0400002C RID: 44
			internal int leftScrollCount;

			// Token: 0x0400002D RID: 45
			internal int rightScrollCount;

			// Token: 0x0400002E RID: 46
			internal bool isNodeDirty;

			// Token: 0x0400002F RID: 47
			internal bool isLeftDirty;

			// Token: 0x04000030 RID: 48
			internal bool isRightDirty;
		}

		// Token: 0x0200000B RID: 11
		private class NodeExtendedWithScrollCountCache : global::Infragistics.Collections.SparseArray.NodeExtended
		{
			// Token: 0x060000CA RID: 202 RVA: 0x00005969 File Offset: 0x00003B69
			internal NodeExtendedWithScrollCountCache()
			{
			}

			// Token: 0x060000CB RID: 203 RVA: 0x0000597C File Offset: 0x00003B7C
			internal NodeExtendedWithScrollCountCache(global::Infragistics.Collections.SparseArray.NodeExtended parent) : base(parent)
			{
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000CC RID: 204 RVA: 0x00005990 File Offset: 0x00003B90
			// (set) Token: 0x060000CD RID: 205 RVA: 0x00005998 File Offset: 0x00003B98
			internal override int[] ScrollCounts
			{
				get
				{
					return this._scrollCounts;
				}
				set
				{
					this._scrollCounts = value;
				}
			}

			// Token: 0x04000031 RID: 49
			internal static int[] g_dirtyFlag = new int[0];

			// Token: 0x04000032 RID: 50
			private int[] _scrollCounts = global::Infragistics.Collections.SparseArray.NodeExtendedWithScrollCountCache.g_dirtyFlag;
		}

		// Token: 0x0200000C RID: 12
		private class Enumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x060000CF RID: 207 RVA: 0x000059AE File Offset: 0x00003BAE
			internal Enumerator(global::Infragistics.Collections.SparseArray sarr)
			{
				this.sarr = sarr;
				((global::System.Collections.IEnumerator)this).Reset();
			}

			// Token: 0x060000D0 RID: 208 RVA: 0x000059CA File Offset: 0x00003BCA
			private void EnsureNotExhausted()
			{
				if (this.currNode == null)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Collections.SparseArray.GetString("LE_InvalidOperationException_1"));
				}
			}

			// Token: 0x060000D1 RID: 209 RVA: 0x000059E4 File Offset: 0x00003BE4
			void global::System.Collections.IEnumerator.Reset()
			{
				this.currNode = global::Infragistics.Collections.SparseArray.GetMinimum(this.sarr.tree);
				this.nodeIndex = -this.currNode.leftCount - 1;
			}

			// Token: 0x060000D2 RID: 210 RVA: 0x00005A10 File Offset: 0x00003C10
			bool global::System.Collections.IEnumerator.MoveNext()
			{
				this.EnsureNotExhausted();
				this.nodeIndex++;
				if (this.nodeIndex < this.currNode.count)
				{
					return true;
				}
				if (this.nodeIndex < this.currNode.count + this.currNode.rightCount && this.currNode.right == null)
				{
					return true;
				}
				this.currNode = global::Infragistics.Collections.SparseArray.GetSuccessor(this.currNode);
				if (this.currNode != null)
				{
					this.nodeIndex = ((this.currNode.left == null) ? (-this.currNode.leftCount) : 0);
				}
				return null != this.currNode;
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000D3 RID: 211 RVA: 0x00005ABC File Offset: 0x00003CBC
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					this.EnsureNotExhausted();
					if (this.nodeIndex < 0 || this.nodeIndex >= this.currNode.count || this.currNode.arr == null)
					{
						return null;
					}
					return this.currNode.arr[this.nodeIndex];
				}
			}

			// Token: 0x04000033 RID: 51
			private global::Infragistics.Collections.SparseArray sarr;

			// Token: 0x04000034 RID: 52
			private int nodeIndex = -1;

			// Token: 0x04000035 RID: 53
			private global::Infragistics.Collections.SparseArray.Node currNode;
		}

		// Token: 0x0200000D RID: 13
		private class CreateItemEnumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x060000D4 RID: 212 RVA: 0x00005B0C File Offset: 0x00003D0C
			internal CreateItemEnumerator(global::Infragistics.Collections.SparseArray sarr, global::Infragistics.Collections.ICreateItemCallback createItemCallback)
			{
				this.sarr = sarr;
				this.createItemCallback = createItemCallback;
				((global::System.Collections.IEnumerator)this).Reset();
			}

			// Token: 0x060000D5 RID: 213 RVA: 0x00005B2F File Offset: 0x00003D2F
			private void EnsureNotExhausted()
			{
				if (this.index >= this.sarr.Count)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Collections.SparseArray.GetString("LE_InvalidOperationException_1"));
				}
			}

			// Token: 0x060000D6 RID: 214 RVA: 0x00005B54 File Offset: 0x00003D54
			void global::System.Collections.IEnumerator.Reset()
			{
				this.index = -1;
			}

			// Token: 0x060000D7 RID: 215 RVA: 0x00005B5D File Offset: 0x00003D5D
			bool global::System.Collections.IEnumerator.MoveNext()
			{
				this.EnsureNotExhausted();
				this.index++;
				return this.index < this.sarr.Count;
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000D8 RID: 216 RVA: 0x00005B86 File Offset: 0x00003D86
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					this.EnsureNotExhausted();
					return this.sarr.GetItem(this.index, this.createItemCallback);
				}
			}

			// Token: 0x04000036 RID: 54
			private global::Infragistics.Collections.SparseArray sarr;

			// Token: 0x04000037 RID: 55
			private int index = -1;

			// Token: 0x04000038 RID: 56
			private global::Infragistics.Collections.ICreateItemCallback createItemCallback;
		}

		// Token: 0x0200000E RID: 14
		private class NonNullEnumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x060000D9 RID: 217 RVA: 0x00005BA5 File Offset: 0x00003DA5
			internal NonNullEnumerator(global::Infragistics.Collections.SparseArray sarr)
			{
				this.sarr = sarr;
				((global::System.Collections.IEnumerator)this).Reset();
			}

			// Token: 0x060000DA RID: 218 RVA: 0x00005BC1 File Offset: 0x00003DC1
			private void EnsureNotExhausted()
			{
				if (this.currNode == null)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Collections.SparseArray.GetString("LE_InvalidOperationException_1"));
				}
			}

			// Token: 0x060000DB RID: 219 RVA: 0x00005BDB File Offset: 0x00003DDB
			void global::System.Collections.IEnumerator.Reset()
			{
				this.currNode = global::Infragistics.Collections.SparseArray.GetMinimum(this.sarr.tree);
				this.nodeIndex = -1;
			}

			// Token: 0x060000DC RID: 220 RVA: 0x00005BFC File Offset: 0x00003DFC
			bool global::System.Collections.IEnumerator.MoveNext()
			{
				this.EnsureNotExhausted();
				this.nodeIndex++;
				while (this.currNode != null && (this.nodeIndex >= this.currNode.count || this.currNode.arr == null || this.currNode.arr[this.nodeIndex] == null))
				{
					this.nodeIndex++;
					if (this.nodeIndex >= this.currNode.count)
					{
						this.currNode = global::Infragistics.Collections.SparseArray.GetSuccessor(this.currNode);
						this.nodeIndex = 0;
					}
				}
				return null != this.currNode;
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000DD RID: 221 RVA: 0x00005CA0 File Offset: 0x00003EA0
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					this.EnsureNotExhausted();
					if (this.currNode.arr == null)
					{
						return null;
					}
					return this.currNode.arr[this.nodeIndex];
				}
			}

			// Token: 0x04000039 RID: 57
			private global::Infragistics.Collections.SparseArray sarr;

			// Token: 0x0400003A RID: 58
			private int nodeIndex = -1;

			// Token: 0x0400003B RID: 59
			private global::Infragistics.Collections.SparseArray.Node currNode;
		}

		// Token: 0x0200000F RID: 15
		private class NonNullEnumerable : global::System.Collections.IEnumerable
		{
			// Token: 0x060000DE RID: 222 RVA: 0x00005CC9 File Offset: 0x00003EC9
			internal NonNullEnumerable(global::Infragistics.Collections.SparseArray sarr)
			{
				this.sarr = sarr;
			}

			// Token: 0x060000DF RID: 223 RVA: 0x00005CD8 File Offset: 0x00003ED8
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return new global::Infragistics.Collections.SparseArray.NonNullEnumerator(this.sarr);
			}

			// Token: 0x0400003C RID: 60
			private global::Infragistics.Collections.SparseArray sarr;
		}

		// Token: 0x02000010 RID: 16
		private class VisibleItemsEnumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x060000E0 RID: 224 RVA: 0x00005CE5 File Offset: 0x00003EE5
			internal VisibleItemsEnumerator(global::Infragistics.Collections.SparseArray sarr, global::Infragistics.Collections.ICreateItemCallback createItemCallback)
			{
				if (!sarr.manageScrollCounts)
				{
					throw new global::System.InvalidOperationException("Sparse array doesn't manage visible counts!");
				}
				this._sarr = sarr;
				this._createItemCallback = createItemCallback;
				this.Reset();
			}

			// Token: 0x060000E1 RID: 225 RVA: 0x00005D14 File Offset: 0x00003F14
			public void Reset()
			{
				this._current = null;
				this._visibleIndex = -1;
			}

			// Token: 0x060000E2 RID: 226 RVA: 0x00005D24 File Offset: 0x00003F24
			public bool MoveNext()
			{
				while (++this._visibleIndex < this._sarr.GetVisibleCount())
				{
					this._current = this._sarr.GetItemAtVisibleIndex(this._visibleIndex, this._createItemCallback);
					if (this._current != null)
					{
						return true;
					}
				}
				return false;
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000E3 RID: 227 RVA: 0x00005D79 File Offset: 0x00003F79
			public object Current
			{
				get
				{
					return this._current;
				}
			}

			// Token: 0x0400003D RID: 61
			private global::Infragistics.Collections.SparseArray _sarr;

			// Token: 0x0400003E RID: 62
			private object _current;

			// Token: 0x0400003F RID: 63
			private int _visibleIndex;

			// Token: 0x04000040 RID: 64
			private global::Infragistics.Collections.ICreateItemCallback _createItemCallback;

			// Token: 0x02000011 RID: 17
			internal class Enumerable : global::System.Collections.IEnumerable
			{
				// Token: 0x060000E4 RID: 228 RVA: 0x00005D81 File Offset: 0x00003F81
				internal Enumerable(global::Infragistics.Collections.SparseArray sarr, global::Infragistics.Collections.ICreateItemCallback createItemCallback)
				{
					this._sarr = sarr;
					this._createItemCallback = createItemCallback;
				}

				// Token: 0x060000E5 RID: 229 RVA: 0x00005D97 File Offset: 0x00003F97
				public global::System.Collections.IEnumerator GetEnumerator()
				{
					return new global::Infragistics.Collections.SparseArray.VisibleItemsEnumerator(this._sarr, this._createItemCallback);
				}

				// Token: 0x04000041 RID: 65
				private global::Infragistics.Collections.SparseArray _sarr;

				// Token: 0x04000042 RID: 66
				private global::Infragistics.Collections.ICreateItemCallback _createItemCallback;
			}
		}
	}
}
