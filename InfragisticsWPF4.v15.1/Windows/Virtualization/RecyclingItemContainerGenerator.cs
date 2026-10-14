using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.Virtualization
{
	// Token: 0x0200024E RID: 590
	public sealed class RecyclingItemContainerGenerator : global::System.Windows.Controls.Primitives.IItemContainerGenerator
	{
		// Token: 0x0600178F RID: 6031 RVA: 0x00059644 File Offset: 0x00057844
		internal RecyclingItemContainerGenerator(global::Infragistics.Windows.Virtualization.RecyclingItemsControl recyclingItemsControl)
		{
			if (recyclingItemsControl == null)
			{
				throw new global::System.ArgumentNullException("recyclingItemsControl", global::SR.GetString("LE_RecyclingGenerator_1"));
			}
			this._recyclingItemsControl = recyclingItemsControl;
			this._deactivatedContainers = new global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference>();
			this._activeContainersInUse = new global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference>();
			this.InitializeIndexMap();
			((global::System.Collections.Specialized.INotifyCollectionChanged)this.Items).CollectionChanged += this.OnItemCollectionChanged;
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x000596AC File Offset: 0x000578AC
		private void OnItemCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
			{
				object[] items = new object[e.NewItems.Count];
				if (e.NewStartingIndex > this._indexMap.Count)
				{
					this._indexMap.Expand(e.NewStartingIndex);
				}
				this._indexMap.InsertRange(e.NewStartingIndex, items);
				return;
			}
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
			{
				int num;
				global::System.Collections.IList list;
				if (e.NewItems != null)
				{
					num = e.NewStartingIndex;
					list = e.NewItems;
				}
				else
				{
					num = e.OldStartingIndex;
					list = e.OldItems;
				}
				int num2 = num + list.Count - 1;
				if (num2 >= this._indexMap.Count)
				{
					this.OnItemCollectionChanged(sender, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
					return;
				}
				for (int i = num; i <= num2; i++)
				{
					global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = this._indexMap[i] as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference;
					if (containerReference != null)
					{
						this.ClearContainerReference(containerReference, false, true, true);
					}
				}
				this._indexMap.RemoveRange(num, list.Count);
				return;
			}
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
			{
				int num3 = e.NewStartingIndex + e.NewItems.Count - 1;
				for (int j = e.NewStartingIndex; j <= num3; j++)
				{
					global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference2 = this._indexMap[j] as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference;
					if (containerReference2 != null)
					{
						this.ClearContainerReference(containerReference2, false, true, true);
						this._indexMap[j] = null;
					}
				}
				return;
			}
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
			{
				global::System.Collections.IList list2;
				if (e.NewItems != null)
				{
					list2 = e.NewItems;
				}
				else
				{
					list2 = e.OldItems;
				}
				object[] array = new object[list2.Count];
				for (int k = 0; k < array.Length; k++)
				{
					global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference3 = this._indexMap[k + e.OldStartingIndex] as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference;
					if (containerReference3 != null)
					{
						array[k] = containerReference3;
					}
				}
				this._indexMap.RemoveRange(e.OldStartingIndex, list2.Count);
				this._indexMap.InsertRange(e.NewStartingIndex, array);
				break;
			}
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				if (this._referencesBeforeLastReset == null)
				{
					this._referencesBeforeLastReset = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference>();
				}
				foreach (object obj in this._indexMap.NonNullItems)
				{
					global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference4 = (global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference)obj;
					object item = containerReference4.Item;
					if (item != null)
					{
						this._referencesBeforeLastReset[item] = containerReference4;
					}
				}
				if (this._deactivatedContainersNotInIndexMap != null)
				{
					foreach (global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference5 in this._deactivatedContainersNotInIndexMap)
					{
						object item2 = containerReference5.Item;
						if (item2 != null)
						{
							this._referencesBeforeLastReset[item2] = containerReference5;
						}
					}
					this._deactivatedContainersNotInIndexMap = null;
				}
				this._indexMap.Clear();
				this._indexMap.Expand(this.Items.Count);
				this._activeContainersInUse.Clear();
				this._deactivatedContainers.Clear();
				if (this._activeContainersInUseByZorder != null)
				{
					this._activeContainersInUseByZorder.Clear();
				}
				if (this._resetOperationPending == null && this._recyclingItemsControl != null)
				{
					this._resetOperationPending = this._recyclingItemsControl.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Input, new global::Infragistics.Windows.Internal.PropertyValueTracker.MethodInvoker(this.ProcessPendingReset));
					return;
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x00059A14 File Offset: 0x00057C14
		private void OnZorderChanged()
		{
			this._isZOrderDirty = true;
			if (this.ZOrderChanged != null)
			{
				this.ZOrderChanged(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x06001792 RID: 6034 RVA: 0x00059A38 File Offset: 0x00057C38
		// (remove) Token: 0x06001793 RID: 6035 RVA: 0x00059A70 File Offset: 0x00057C70
		public event global::System.EventHandler<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerDiscardedEventArgs> ContainerDiscarded;

		// Token: 0x14000032 RID: 50
		// (add) Token: 0x06001794 RID: 6036 RVA: 0x00059AA8 File Offset: 0x00057CA8
		// (remove) Token: 0x06001795 RID: 6037 RVA: 0x00059AE0 File Offset: 0x00057CE0
		public event global::System.EventHandler StatusChanged;

		// Token: 0x14000033 RID: 51
		// (add) Token: 0x06001796 RID: 6038 RVA: 0x00059B18 File Offset: 0x00057D18
		// (remove) Token: 0x06001797 RID: 6039 RVA: 0x00059B50 File Offset: 0x00057D50
		internal event global::System.EventHandler ZOrderChanged;

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x00059B88 File Offset: 0x00057D88
		public int CountOfAllContainers
		{
			get
			{
				int num = this.CountOfActiveContainers;
				if (this._recyclableContainersList != null)
				{
					num += this._recyclableContainersList.Count;
				}
				else
				{
					num += this._deactivatedContainers.Count;
					if (this._referencesBeforeLastReset != null)
					{
						num += this._referencesBeforeLastReset.Count;
					}
				}
				return num;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x00059BDC File Offset: 0x00057DDC
		public int CountOfActiveContainers
		{
			get
			{
				int num = this._activeContainersInUse.Count;
				if (this._currentGenerator != null)
				{
					num += this._currentGenerator.CountOfGeneratedItems;
				}
				return num;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x00059C0C File Offset: 0x00057E0C
		public global::System.Windows.Controls.Primitives.GeneratorStatus Status
		{
			get
			{
				return this._status;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x00059C14 File Offset: 0x00057E14
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> ActiveContainersInUseByZorder
		{
			get
			{
				if (this._activeContainersInUseByZorder == null)
				{
					this._activeContainersInUseByZorder = new global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference>();
				}
				else if (this._isZOrderDirty || this._activeContainersInUse.Count != this._activeContainersInUseByZorder.Count)
				{
					this._activeContainersInUseByZorder.Clear();
				}
				if (this._activeContainersInUseByZorder.Count == 0)
				{
					this._isZOrderDirty = false;
					int count = this._activeContainersInUse.Count;
					if (count > 0)
					{
						if (count == 1)
						{
							this._activeContainersInUseByZorder.Add(this._activeContainersInUse[0]);
						}
						else
						{
							for (int i = 0; i < count; i++)
							{
								this._activeContainersInUse[i]._originalIndex = i;
							}
							global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference[] array = new global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference[count];
							this._activeContainersInUse.CopyTo(array);
							global::Infragistics.CoreUtilities.SortMerge(array, new global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ZOrderComparer());
							this._activeContainersInUseByZorder.AddRange(array);
						}
					}
				}
				return this._activeContainersInUseByZorder;
			}
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x00059CF0 File Offset: 0x00057EF0
		private static global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference GetContainerReference(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference)d.GetValue(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReferenceProperty);
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x00059D02 File Offset: 0x00057F02
		private global::System.Windows.Controls.ItemCollection Items
		{
			get
			{
				return this._recyclingItemsControl.Items;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x00059D0F File Offset: 0x00057F0F
		internal bool IsInRemoveAll
		{
			get
			{
				return this._isInRemoveAll;
			}
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x00059D17 File Offset: 0x00057F17
		public void BeginGeneration(global::Infragistics.Windows.Selection.ScrollDirection scrollDirection)
		{
			this.BeginGeneration(scrollDirection, null);
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x00059D24 File Offset: 0x00057F24
		public void BeginGeneration(global::Infragistics.Windows.Selection.ScrollDirection scrollDirection, global::System.Collections.IEnumerable itemsExpectedToBeGenerated)
		{
			if (this._isGenerating)
			{
				this.EndGeneration();
			}
			if (this._isGenerating)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_RecyclingGenerator_2"));
			}
			if (this._resetOperationPending != null)
			{
				this._resetOperationPending.Abort();
				this._resetOperationPending = null;
			}
			this._scrollDirection = scrollDirection;
			this.PlaceAllActiveContainersInLimbo(itemsExpectedToBeGenerated);
			this._isGenerating = true;
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x00059D88 File Offset: 0x00057F88
		public global::System.Windows.DependencyObject ContainerFromIndex(int index)
		{
			if (index < 0 || index >= this._indexMap.Count)
			{
				return null;
			}
			global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = this._indexMap[index] as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference;
			if (containerReference == null || containerReference.IsDeactivated)
			{
				return null;
			}
			return containerReference.Container;
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x00059DD0 File Offset: 0x00057FD0
		public global::System.Windows.DependencyObject ContainerFromItem(object item)
		{
			global::System.Windows.DependencyObject dependencyObject = this.ContainerFromIndex(this._recyclingItemsControl.Items.IndexOf(item));
			global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference;
			if (dependencyObject == null && this._referencesBeforeLastReset != null && this._referencesBeforeLastReset.TryGetValue(item, out containerReference))
			{
				dependencyObject = containerReference.Container;
			}
			return dependencyObject;
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x00059E18 File Offset: 0x00058018
		public void DeactivateAllContainers()
		{
			this.DeactivateAllContainersInUse();
			this.DeactivateAllContainersInLimbo();
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x00059E26 File Offset: 0x00058026
		public void DeactivateContainer(global::System.Windows.DependencyObject container)
		{
			this.DeactivateContainerHelper(container, true);
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x00059E30 File Offset: 0x00058030
		private void DeactivateContainerHelper(global::System.Windows.DependencyObject container, bool removeFromRecyclableCache)
		{
			global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.GetContainerReference(container);
			if (containerReference == null)
			{
				return;
			}
			this.DeactivateContainerHelper(containerReference);
			int num = this._activeContainersInUse.IndexOf(containerReference);
			if (num >= 0)
			{
				this._activeContainersInUse.RemoveAt(num);
			}
			else if (removeFromRecyclableCache)
			{
				this.RemoveContainerFromRecyclableCache(containerReference);
			}
			if (this._activeContainersInUseByZorder != null)
			{
				num = this._activeContainersInUseByZorder.IndexOf(containerReference);
				if (num >= 0)
				{
					this._activeContainersInUseByZorder.RemoveAt(num);
				}
			}
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x00059E9E File Offset: 0x0005809E
		private void DeactivateContainerHelper(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference cr)
		{
			cr.IsDeactivated = true;
			this._recyclingItemsControl.DeactivateContainer(cr.Container, cr.Item);
			this._deactivatedContainers.Add(cr);
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x00059ECC File Offset: 0x000580CC
		public void EndGeneration()
		{
			this._isGenerating = false;
			if (this._activeContainersInUseByZorder != null)
			{
				this._activeContainersInUseByZorder.Clear();
			}
			this.DeactivateAllContainersInLimbo();
			this._referencesBeforeLastReset = null;
			this._referencesBeforeLastResetList = null;
			this._recyclableContainers = null;
			this._recyclableContainersList = null;
			this._recyclableContainersListFiltered = null;
			this._recyclableContainersDups = null;
			this._indexMap.Compact();
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x00059F30 File Offset: 0x00058130
		public int IndexFromContainer(global::System.Windows.DependencyObject container)
		{
			if (container == null)
			{
				throw new global::System.ArgumentNullException("container");
			}
			global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.GetContainerReference(container);
			if (containerReference == null || containerReference.IsDeactivated)
			{
				return -1;
			}
			return this._indexMap.IndexOf(containerReference);
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x00059F6C File Offset: 0x0005816C
		public object ItemFromContainer(global::System.Windows.DependencyObject container)
		{
			if (container == null)
			{
				throw new global::System.ArgumentNullException("container");
			}
			global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.GetContainerReference(container);
			if (containerReference == null || containerReference.IsDeactivated)
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			int num = this._indexMap.IndexOf(containerReference);
			if (num < 0)
			{
				return global::System.Windows.DependencyProperty.UnsetValue;
			}
			return containerReference.Item;
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x00059FBC File Offset: 0x000581BC
		public void RemoveAllDeactivatedContainers()
		{
			this._deactivatedContainersNotInIndexMap = null;
			for (int i = this._deactivatedContainers.Count - 1; i >= 0; i = this._deactivatedContainers.Count - 1)
			{
				global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference cr = this._deactivatedContainers[i];
				this._deactivatedContainers.RemoveAt(i);
				this.ClearContainerReference(cr, true, true, true);
			}
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x0005A018 File Offset: 0x00058218
		public void VerifyAllDeactivatedContainers()
		{
			if (this._deactivatedContainers.Count < 1)
			{
				return;
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> list = null;
			foreach (global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference in this._deactivatedContainers)
			{
				bool? flag = this._recyclingItemsControl.IsStillValid(containerReference.Container, containerReference.Item);
				if (flag != null && !flag.Value)
				{
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference>();
					}
					list.Add(containerReference);
				}
			}
			if (list == null)
			{
				return;
			}
			if (list.Count == this._deactivatedContainers.Count)
			{
				this._deactivatedContainersNotInIndexMap = null;
			}
			foreach (global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference2 in list)
			{
				this._deactivatedContainers.Remove(containerReference2);
				if (this._deactivatedContainersNotInIndexMap != null)
				{
					this._deactivatedContainersNotInIndexMap.Remove(containerReference2);
				}
				this.ClearContainerReference(containerReference2, true, true, true);
			}
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x0005A134 File Offset: 0x00058334
		internal global::System.Windows.DependencyObject GetContainer(int index, bool isIndexBasedOnZOrder)
		{
			global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = this.GetContainerReference(index, isIndexBasedOnZOrder);
			if (containerReference != null)
			{
				return containerReference.Container;
			}
			return null;
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x0005A158 File Offset: 0x00058358
		private global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference GetContainerReference(int index, bool isIndexBasedOnZOrder)
		{
			int num = this.CountOfActiveContainers;
			if (index < num)
			{
				if (this._currentGenerator != null)
				{
					return this._currentGenerator.GetActiveContainerReference(index, isIndexBasedOnZOrder);
				}
				if (isIndexBasedOnZOrder)
				{
					return this.ActiveContainersInUseByZorder[index];
				}
				return this._activeContainersInUse[index];
			}
			else
			{
				index -= num;
				num = this._deactivatedContainers.Count;
				if (index < num)
				{
					return this._deactivatedContainers[index];
				}
				index -= num;
				if (this._recyclableContainersList != null)
				{
					num = this._recyclableContainersList.Count;
					if (index < num)
					{
						return this._recyclableContainersList[index];
					}
				}
				else if (this._referencesBeforeLastReset != null)
				{
					int count = this._referencesBeforeLastReset.Count;
					if (index < count)
					{
						if (this._referencesBeforeLastResetList == null || this._referencesBeforeLastResetList.Count != count)
						{
							this._referencesBeforeLastResetList = new global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference>(this._referencesBeforeLastReset.Values);
						}
						return this._referencesBeforeLastResetList[index];
					}
				}
				return null;
			}
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x0005A244 File Offset: 0x00058444
		private global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference GetContainerReferenceHelper(int index, global::System.Collections.Generic.LinkedList<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> llist)
		{
			global::System.Collections.Generic.LinkedListNode<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> linkedListNode = llist.First;
			while (index > 0)
			{
				linkedListNode = linkedListNode.Next;
				index--;
			}
			return linkedListNode.Value;
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x0005A270 File Offset: 0x00058470
		internal int GetIndexOfContainerInActiveList(global::System.Windows.DependencyObject container, bool isIndexBasedOnZOrder)
		{
			global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.GetContainerReference(container);
			if (containerReference != null)
			{
				return -1;
			}
			if (this._currentGenerator != null)
			{
				return this._currentGenerator.GetIndexOfActiveContainerReference(containerReference, isIndexBasedOnZOrder);
			}
			if (isIndexBasedOnZOrder)
			{
				return this.ActiveContainersInUseByZorder.IndexOf(containerReference);
			}
			return this._activeContainersInUse.IndexOf(containerReference);
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x0005A2BC File Offset: 0x000584BC
		internal void OnContainerAddedToVisualTree(global::System.Windows.DependencyObject container)
		{
			if (this._currentGenerator == null)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_RecyclingGenerator_3"));
			}
			global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.GetContainerReference(container);
			if (containerReference == null)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_RecyclingGenerator_4"));
			}
			this._currentGenerator.OnContainerAddedToVisualTree(containerReference);
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x0005A308 File Offset: 0x00058508
		private void ClearContainerReference(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference cr, bool removeFromMap, bool removeFromCache, bool removeFromRecyclingCache)
		{
			if (removeFromMap)
			{
				int num = this._indexMap.IndexOf(cr);
				if (num >= 0)
				{
					this._indexMap[num] = null;
				}
			}
			if (removeFromCache)
			{
				int num = this._activeContainersInUse.IndexOf(cr);
				if (num >= 0)
				{
					this._activeContainersInUse.RemoveAt(num);
				}
				else
				{
					num = this._deactivatedContainers.IndexOf(cr);
					if (num >= 0)
					{
						this._deactivatedContainers.RemoveAt(num);
					}
					if (this._deactivatedContainersNotInIndexMap != null)
					{
						num = this._deactivatedContainersNotInIndexMap.IndexOf(cr);
						if (num >= 0)
						{
							this._deactivatedContainersNotInIndexMap.RemoveAt(num);
						}
					}
					if (removeFromRecyclingCache)
					{
						this.RemoveContainerFromRecyclableCache(cr);
					}
				}
				if (this._activeContainersInUseByZorder != null)
				{
					num = this._activeContainersInUseByZorder.IndexOf(cr);
					if (num >= 0)
					{
						this._activeContainersInUseByZorder.RemoveAt(num);
					}
				}
			}
			cr.Generator = null;
			cr.Container.ClearValue(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReferenceProperty);
			if (!cr.IsItemItsOwnContainer)
			{
				cr.Container.SetValue(global::System.Windows.FrameworkElement.DataContextProperty, null);
			}
			this._recyclingItemsControl.ClearContainerForItemInternal(cr.Container, cr.Item);
			if (this.ContainerDiscarded != null)
			{
				this.ContainerDiscarded(this, new global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerDiscardedEventArgs(cr.Container));
			}
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x0005A434 File Offset: 0x00058634
		private global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference CreateNewContainerReference(object item)
		{
			bool flag = this._recyclingItemsControl.IsItemItsOwnContainerInternal(item);
			global::System.Windows.DependencyObject container;
			if (flag)
			{
				container = (item as global::System.Windows.DependencyObject);
			}
			else
			{
				container = this._recyclingItemsControl.GetContainerForItemInternal(item);
			}
			global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = new global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference(container, flag);
			if (!flag)
			{
				containerReference.Item = item;
			}
			this.ConnectContainerToItem(containerReference);
			return containerReference;
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x0005A484 File Offset: 0x00058684
		private void ConnectContainerToItem(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference cr)
		{
			global::System.Windows.DependencyObject container = cr.Container;
			container.SetValue(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReferenceProperty, cr);
			cr.Generator = this;
			if (!cr.IsItemItsOwnContainer)
			{
				container.SetValue(global::System.Windows.FrameworkElement.DataContextProperty, cr.Item);
			}
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x0005A4C4 File Offset: 0x000586C4
		private void DeactivateAllContainersInLimbo()
		{
			if (this._recyclableContainersList == null)
			{
				return;
			}
			int count = this._recyclableContainersList.Count;
			if (count < 1)
			{
				return;
			}
			int count2 = this._recyclingItemsControl.Items.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference cr = this._recyclableContainersList[i];
				this.DeactivateLimboedContainer(count2, cr);
			}
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x0005A520 File Offset: 0x00058720
		private void DeactivateLimboedContainer(int itemCount, global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference cr)
		{
			if (this._referencesBeforeLastReset == null)
			{
				if (!cr.IsDeactivated)
				{
					this.DeactivateContainerHelper(cr);
					return;
				}
			}
			else if (itemCount > 0 && !this.HasContainerBeenCleared(cr) && this._recyclingItemsControl.ShouldDeactivateContainer(cr.Container, cr.Item))
			{
				bool flag = this._indexMap.Contains(cr);
				if (!flag)
				{
					int num = this._recyclingItemsControl.Items.IndexOf(cr.Item);
					if (num >= 0 && this._indexMap[num] == null)
					{
						this._indexMap[num] = cr;
						flag = true;
					}
				}
				bool flag2 = flag;
				if (!flag)
				{
					int maxDeactivatedContainersWithoutIndexes = this._recyclingItemsControl.MaxDeactivatedContainersWithoutIndexes;
					if (0 < maxDeactivatedContainersWithoutIndexes)
					{
						if (this._deactivatedContainersNotInIndexMap == null)
						{
							this._deactivatedContainersNotInIndexMap = new global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference>();
						}
						if (this._deactivatedContainersNotInIndexMap.Count < maxDeactivatedContainersWithoutIndexes)
						{
							this._deactivatedContainersNotInIndexMap.Add(cr);
							flag2 = true;
						}
					}
				}
				if (flag2)
				{
					this.DeactivateContainerHelper(cr);
					return;
				}
				this.ClearContainerReference(cr, true, true, false);
				return;
			}
			else
			{
				this.ClearContainerReference(cr, true, true, false);
			}
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x0005A624 File Offset: 0x00058824
		private void DeactivateAllContainersInUse()
		{
			int count = this._activeContainersInUse.Count;
			if (count < 1)
			{
				return;
			}
			for (int i = 0; i < count; i++)
			{
				this.DeactivateContainerHelper(this._activeContainersInUse[i]);
			}
			this._activeContainersInUse.Clear();
			if (this._activeContainersInUseByZorder != null)
			{
				this._activeContainersInUseByZorder.Clear();
			}
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x0005A680 File Offset: 0x00058880
		private object GetItem(global::System.Windows.DependencyObject container)
		{
			global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.GetContainerReference(container);
			if (containerReference == null)
			{
				return null;
			}
			return containerReference.Item;
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x0005A6A0 File Offset: 0x000588A0
		private object GetItem(global::System.Windows.DependencyObject container, out int index)
		{
			global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.GetContainerReference(container);
			if (containerReference != null)
			{
				return this.GetItem(containerReference, out index);
			}
			index = -1;
			return null;
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x0005A6C4 File Offset: 0x000588C4
		private object GetItem(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference cr, out int index)
		{
			index = this._indexMap.IndexOf(cr);
			if (index < 0)
			{
				return null;
			}
			return this.Items[index];
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x0005A6F5 File Offset: 0x000588F5
		private bool HasContainerBeenCleared(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference cr)
		{
			return cr.Container == null || cr.Container.GetValue(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReferenceProperty) == null;
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x0005A714 File Offset: 0x00058914
		private void InitializeIndexMap()
		{
			this._indexMap = new global::Infragistics.Collections.SparseArray(20, 1f, true);
			this._indexMap.Expand(this.Items.Count);
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x0005A73F File Offset: 0x0005893F
		private bool IsContainerCompatibleWithItem(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference cr, object item)
		{
			if (cr.IsItemItsOwnContainer)
			{
				return item == cr.Item;
			}
			return this._recyclingItemsControl.IsContainerCompatibleWithItem(cr.Container, item);
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x0005A768 File Offset: 0x00058968
		private void PlaceAllActiveContainersInLimbo(global::System.Collections.IEnumerable itemsExpectedToBeGenerated)
		{
			global::Infragistics.Windows.Helpers.HashSet hashSet = null;
			if (itemsExpectedToBeGenerated != null)
			{
				hashSet = new global::Infragistics.Windows.Helpers.HashSet();
				hashSet.AddItems(itemsExpectedToBeGenerated);
				if (hashSet.Count == 0)
				{
					hashSet = null;
				}
			}
			int count = this._activeContainersInUse.Count;
			int count2 = this._deactivatedContainers.Count;
			int num = (this._referencesBeforeLastReset != null) ? this._referencesBeforeLastReset.Count : 0;
			this._recyclableContainers = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference>();
			this._recyclableContainersList = new global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference>(count + count2 + num);
			this._recyclableContainersListFiltered = new global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference>(count + count2 + num);
			global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference>();
			if (count > 0)
			{
				this._recyclableContainersList.AddRange(this._activeContainersInUse);
			}
			if (num > 0)
			{
				this._recyclableContainersList.AddRange(this._referencesBeforeLastReset.Values);
			}
			if (count2 > 0)
			{
				this._recyclableContainersList.AddRange(this._deactivatedContainers);
			}
			int count3 = this._recyclableContainersList.Count;
			for (int i = 0; i < count3; i++)
			{
				global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = this._recyclableContainersList[i];
				object item = containerReference.Item;
				if (item == null || this._recyclableContainers.ContainsKey(item))
				{
					if (this._recyclableContainersDups == null)
					{
						this._recyclableContainersDups = new global::Infragistics.Windows.Helpers.HashSet();
					}
					this._recyclableContainersDups.Add(containerReference);
				}
				else
				{
					this._recyclableContainers[item] = containerReference;
				}
				if (containerReference.IsDeactivated)
				{
					list.Add(containerReference);
				}
				else if (hashSet == null || !hashSet.Exists(item))
				{
					this._recyclableContainersListFiltered.Add(containerReference);
				}
			}
			if (this._recyclableContainersListFiltered.Count > 1)
			{
				if (hashSet == null && this._scrollDirection == global::Infragistics.Windows.Selection.ScrollDirection.Decrement)
				{
					this._recyclableContainersListFiltered.Reverse();
				}
				else
				{
					global::Infragistics.Windows.Utilities.RandomizeList<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference>(this._recyclableContainersListFiltered);
				}
			}
			if (list.Count > 0)
			{
				if (hashSet == null)
				{
					this._recyclableContainersListFiltered.InsertRange(0, list);
				}
				else
				{
					this._recyclableContainersListFiltered.AddRange(list);
				}
			}
			this._activeContainersInUse.Clear();
			if (this._activeContainersInUseByZorder != null)
			{
				this._activeContainersInUseByZorder.Clear();
			}
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x0005A960 File Offset: 0x00058B60
		private void ProcessPendingReset()
		{
			if (this._resetOperationPending == null)
			{
				return;
			}
			this._resetOperationPending = null;
			if (this._referencesBeforeLastReset != null)
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference>();
				foreach (global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference in this._referencesBeforeLastReset.Values)
				{
					bool? flag = this._recyclingItemsControl.IsStillValid(containerReference.Container, containerReference.Item);
					if (flag != null && !flag.Value)
					{
						list.Add(containerReference);
					}
				}
				foreach (global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference2 in list)
				{
					if (containerReference2.Item != null)
					{
						this._referencesBeforeLastReset.Remove(containerReference2.Item);
						this.ClearContainerReference(containerReference2, false, false, false);
					}
				}
			}
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x0005AA60 File Offset: 0x00058C60
		private bool RemoveContainerFromCache(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference cr)
		{
			bool flag = this.RemoveContainerFromRecyclableCache(cr);
			if ((!flag || cr.IsDeactivated) && this._deactivatedContainers.Remove(cr))
			{
				if (this._deactivatedContainersNotInIndexMap != null)
				{
					this._deactivatedContainersNotInIndexMap.Remove(cr);
				}
				return true;
			}
			if (flag)
			{
				return true;
			}
			bool flag2 = this._activeContainersInUse.Remove(cr);
			if (flag2 && this._activeContainersInUseByZorder != null)
			{
				this._activeContainersInUseByZorder.Remove(cr);
			}
			return flag2;
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x0005AAD0 File Offset: 0x00058CD0
		private bool RemoveContainerFromRecyclableCache(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference cr)
		{
			if (this._recyclableContainers == null || !this._recyclableContainers.Remove(cr.Item))
			{
				if (this._recyclableContainersDups == null || !this._recyclableContainersDups.Exists(cr))
				{
					return false;
				}
				this._recyclableContainersDups.Remove(cr);
				if (this._recyclableContainersDups.Count == 0)
				{
					this._recyclableContainersDups = null;
				}
			}
			this._recyclableContainersListFiltered.Remove(cr);
			this._recyclableContainersList.Remove(cr);
			return true;
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x0005AB50 File Offset: 0x00058D50
		private void SetItemContainerStyle(global::System.Windows.DependencyObject container, object item)
		{
			if (!(container is global::System.Windows.FrameworkElement))
			{
				return;
			}
			if (!(bool)container.GetValue(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.IsStyleSetFromItemContainerStyleProperty) && global::System.Windows.DependencyProperty.UnsetValue != container.ReadLocalValue(global::System.Windows.FrameworkElement.StyleProperty))
			{
				return;
			}
			global::System.Windows.Style style = this._recyclingItemsControl.ItemContainerStyle;
			if (style == null)
			{
				global::System.Windows.Controls.StyleSelector itemContainerStyleSelector = this._recyclingItemsControl.ItemContainerStyleSelector;
				if (itemContainerStyleSelector != null)
				{
					style = itemContainerStyleSelector.SelectStyle(item, container);
				}
			}
			if (style != null)
			{
				if (style.TargetType != null && !style.TargetType.IsInstanceOfType(item))
				{
					throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidStyleTargetType", new object[]
					{
						style.TargetType,
						container.GetType()
					}));
				}
				container.SetValue(global::System.Windows.FrameworkElement.StyleProperty, style);
			}
			else
			{
				container.ClearValue(global::System.Windows.FrameworkElement.StyleProperty);
			}
			container.SetValue(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.IsStyleSetFromItemContainerStyleProperty, global::Infragistics.KnownBoxes.FromValue(style != null));
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x0005AC33 File Offset: 0x00058E33
		private void SetStatus(global::System.Windows.Controls.Primitives.GeneratorStatus status)
		{
			if (this._status != status)
			{
				this._status = status;
				if (this.StatusChanged != null)
				{
					this.StatusChanged(this, global::System.EventArgs.Empty);
				}
			}
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x0005AC60 File Offset: 0x00058E60
		public global::System.Windows.DependencyObject GenerateNext()
		{
			if (this._currentGenerator == null)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_RecyclingGenerator_5"));
			}
			bool flag;
			return this._currentGenerator.GenerateNext(true, out flag);
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x0005AC93 File Offset: 0x00058E93
		public global::System.Windows.DependencyObject GenerateNext(out bool isNewlyRealized)
		{
			if (this._currentGenerator == null)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_RecyclingGenerator_5"));
			}
			return this._currentGenerator.GenerateNext(false, out isNewlyRealized);
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x0005ACBC File Offset: 0x00058EBC
		public global::System.Windows.Controls.Primitives.GeneratorPosition GeneratorPositionFromIndex(int itemIndex)
		{
			if (itemIndex < 0 || itemIndex >= this.Items.Count)
			{
				return new global::System.Windows.Controls.Primitives.GeneratorPosition(-1, global::System.Math.Max(0, itemIndex + 1));
			}
			int count = this._activeContainersInUse.Count;
			int index = -1;
			int num = -1;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = this._activeContainersInUse[i];
				if (containerReference != null)
				{
					int num2 = this._indexMap.IndexOf(containerReference);
					if (num2 < 0)
					{
						break;
					}
					if (num2 == itemIndex)
					{
						return new global::System.Windows.Controls.Primitives.GeneratorPosition(i, 0);
					}
					if (num2 > itemIndex)
					{
						break;
					}
					num = num2;
					index = i;
				}
			}
			return new global::System.Windows.Controls.Primitives.GeneratorPosition(index, global::System.Math.Max(0, itemIndex - num));
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x0005AD55 File Offset: 0x00058F55
		global::System.Windows.Controls.ItemContainerGenerator global::System.Windows.Controls.Primitives.IItemContainerGenerator.GetItemContainerGeneratorForPanel(global::System.Windows.Controls.Panel panel)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x0005AD5C File Offset: 0x00058F5C
		public int IndexFromGeneratorPosition(global::System.Windows.Controls.Primitives.GeneratorPosition position)
		{
			int index = position.Index;
			if (index < 0)
			{
				return index + position.Offset;
			}
			int countOfAllContainers = this.CountOfAllContainers;
			if (index >= countOfAllContainers)
			{
				return index + position.Offset;
			}
			global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = this.GetContainerReference(index, false);
			if (containerReference == null)
			{
				return index + position.Offset;
			}
			int num = this._indexMap.IndexOf(containerReference);
			if (num < 0)
			{
				return index + position.Offset;
			}
			return num + position.Offset;
		}

		// Token: 0x060017C8 RID: 6088 RVA: 0x0005ADD0 File Offset: 0x00058FD0
		public void PrepareItemContainer(global::System.Windows.DependencyObject container)
		{
			object item = this.GetItem(container);
			if (this._recyclingItemsControl.ShouldApplyItemContainerStyleInternal(container, item))
			{
				this.SetItemContainerStyle(container, item);
			}
			this._recyclingItemsControl.PrepareContainerForItemInternal(container, item);
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x0005AE0C File Offset: 0x0005900C
		public void Remove(global::System.Windows.Controls.Primitives.GeneratorPosition position, int count)
		{
			if (position.Offset != 0)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_RecyclingGenerator_6"), "position");
			}
			if (count < 1)
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_RecyclingGenerator_7"), "count");
			}
			int num = global::System.Math.Max(0, position.Index);
			int num2 = num + count - 1;
			int count2 = this._indexMap.Count;
			if (num2 >= count2)
			{
				num2 = count2 - 1;
			}
			for (int i = num; i <= num2; i++)
			{
				global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = this._indexMap[i] as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference;
				if (containerReference != null)
				{
					this.ClearContainerReference(containerReference, false, true, true);
					this._indexMap[i] = null;
				}
			}
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x0005AEB4 File Offset: 0x000590B4
		public void RemoveAll()
		{
			this._isInRemoveAll = true;
			try
			{
				foreach (object obj in this._indexMap.NonNullItems)
				{
					global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference cr = (global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference)obj;
					this.ClearContainerReference(cr, false, false, false);
				}
				if (this._recyclableContainers != null)
				{
					foreach (global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference cr2 in this._recyclableContainersList)
					{
						this.ClearContainerReference(cr2, false, false, false);
					}
					this._recyclableContainers = null;
					this._recyclableContainersList = null;
					this._recyclableContainersListFiltered = null;
					this._recyclableContainersDups = null;
				}
				else if (this._referencesBeforeLastReset != null)
				{
					foreach (global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference cr3 in this._referencesBeforeLastReset.Values)
					{
						this.ClearContainerReference(cr3, false, false, false);
					}
				}
				this._referencesBeforeLastReset = null;
				this._referencesBeforeLastResetList = null;
				this._activeContainersInUse.Clear();
				this._deactivatedContainers.Clear();
				this._deactivatedContainersNotInIndexMap = null;
				if (this._activeContainersInUseByZorder != null)
				{
					this._activeContainersInUseByZorder.Clear();
				}
				this._indexMap.Clear();
				this._indexMap.Expand(this.Items.Count);
			}
			finally
			{
				this._isInRemoveAll = false;
			}
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x0005B084 File Offset: 0x00059284
		public global::System.IDisposable StartAt(global::System.Windows.Controls.Primitives.GeneratorPosition position, global::System.Windows.Controls.Primitives.GeneratorDirection direction, bool allowStartAtRealizedItem)
		{
			if (this._currentGenerator != null)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_RecyclingGenerator_8"));
			}
			if (!this._isGenerating)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_RecyclingGenerator_9"));
			}
			this._currentGenerator = new global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.RecyclingGenerator(this, position, direction, allowStartAtRealizedItem);
			return this._currentGenerator;
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x0005B0D6 File Offset: 0x000592D6
		public global::System.IDisposable StartAt(global::System.Windows.Controls.Primitives.GeneratorPosition position, global::System.Windows.Controls.Primitives.GeneratorDirection direction)
		{
			if (!this._isGenerating)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_BeginGenerationNotCalled"));
			}
			return ((global::System.Windows.Controls.Primitives.IItemContainerGenerator)this).StartAt(position, direction, false);
		}

		// Token: 0x04000C0B RID: 3083
		private global::System.Windows.Threading.DispatcherOperation _resetOperationPending;

		// Token: 0x04000C0C RID: 3084
		private global::Infragistics.Windows.Virtualization.RecyclingItemsControl _recyclingItemsControl;

		// Token: 0x04000C0D RID: 3085
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> _deactivatedContainers;

		// Token: 0x04000C0E RID: 3086
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> _activeContainersInUse;

		// Token: 0x04000C0F RID: 3087
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> _activeContainersInUseByZorder;

		// Token: 0x04000C10 RID: 3088
		private global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> _recyclableContainers;

		// Token: 0x04000C11 RID: 3089
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> _recyclableContainersList;

		// Token: 0x04000C12 RID: 3090
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> _recyclableContainersListFiltered;

		// Token: 0x04000C13 RID: 3091
		private global::Infragistics.Windows.Helpers.HashSet _recyclableContainersDups;

		// Token: 0x04000C14 RID: 3092
		private global::Infragistics.Collections.SparseArray _indexMap;

		// Token: 0x04000C15 RID: 3093
		private global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> _referencesBeforeLastReset;

		// Token: 0x04000C16 RID: 3094
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> _referencesBeforeLastResetList;

		// Token: 0x04000C17 RID: 3095
		private global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.RecyclingGenerator _currentGenerator;

		// Token: 0x04000C18 RID: 3096
		private global::System.Windows.Controls.Primitives.GeneratorStatus _status;

		// Token: 0x04000C19 RID: 3097
		private global::Infragistics.Windows.Selection.ScrollDirection _scrollDirection;

		// Token: 0x04000C1A RID: 3098
		private bool _isGenerating;

		// Token: 0x04000C1B RID: 3099
		private bool _isZOrderDirty;

		// Token: 0x04000C1C RID: 3100
		private bool _isInRemoveAll;

		// Token: 0x04000C1D RID: 3101
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> _deactivatedContainersNotInIndexMap;

		// Token: 0x04000C21 RID: 3105
		private static readonly global::System.Windows.DependencyProperty ContainerReferenceProperty = global::System.Windows.DependencyProperty.RegisterAttached("ContainerReference", typeof(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference), typeof(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C22 RID: 3106
		private static readonly global::System.Windows.DependencyProperty IsStyleSetFromItemContainerStyleProperty = global::System.Windows.DependencyProperty.RegisterAttached("IsStyleSetFromItemContainerStyle", typeof(bool), typeof(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0200024F RID: 591
		private class ContainerReference : global::System.Windows.DependencyObject, global::Infragistics.Collections.ISparseArrayItem
		{
			// Token: 0x060017CE RID: 6094 RVA: 0x0005B160 File Offset: 0x00059360
			internal ContainerReference(global::System.Windows.DependencyObject container, bool isItemItsOwnContainer)
			{
				this._container = container;
				this._isItemItsOwnContainer = isItemItsOwnContainer;
				if (this._isItemItsOwnContainer)
				{
					this._item = this._container;
				}
				if (container is global::System.Windows.UIElement)
				{
					global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
					binding.Mode = global::System.Windows.Data.BindingMode.OneWay;
					binding.Path = new global::System.Windows.PropertyPath(global::System.Windows.Controls.Panel.ZIndexProperty);
					binding.Source = container;
					global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference.ZIndexProperty, binding);
				}
			}

			// Token: 0x060017CF RID: 6095 RVA: 0x0005B1CE File Offset: 0x000593CE
			public override string ToString()
			{
				return string.Format("Item:{0} Container:{1}", this.Item, this.Container);
			}

			// Token: 0x17000550 RID: 1360
			// (get) Token: 0x060017D0 RID: 6096 RVA: 0x0005B1E6 File Offset: 0x000593E6
			internal global::System.Windows.DependencyObject Container
			{
				get
				{
					return this._container;
				}
			}

			// Token: 0x17000551 RID: 1361
			// (get) Token: 0x060017D1 RID: 6097 RVA: 0x0005B1EE File Offset: 0x000593EE
			// (set) Token: 0x060017D2 RID: 6098 RVA: 0x0005B1F6 File Offset: 0x000593F6
			internal global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator Generator
			{
				get
				{
					return this._generator;
				}
				set
				{
					this._generator = value;
				}
			}

			// Token: 0x17000552 RID: 1362
			// (get) Token: 0x060017D3 RID: 6099 RVA: 0x0005B1FF File Offset: 0x000593FF
			// (set) Token: 0x060017D4 RID: 6100 RVA: 0x0005B208 File Offset: 0x00059408
			internal bool IsDeactivated
			{
				get
				{
					return this._isDeactivated;
				}
				set
				{
					if (this._isDeactivated != value)
					{
						this._isDeactivated = value;
						if (this._isItemItsOwnContainer)
						{
							return;
						}
						global::System.Windows.UIElement uielement = this._container as global::System.Windows.UIElement;
						if (uielement != null)
						{
							if (this._isDeactivated)
							{
								this._cachedVisibilityLocalValue = uielement.ReadLocalValue(global::System.Windows.UIElement.VisibilityProperty);
								uielement.SetValue(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.KnownBoxes.VisibilityCollapsedBox);
								if (this._cachedVisibilityLocalValue is global::System.Windows.Data.BindingExpressionBase)
								{
									this._cachedVisibilityLocalValue = ((global::System.Windows.Data.BindingExpressionBase)this._cachedVisibilityLocalValue).ParentBindingBase;
									return;
								}
							}
							else
							{
								if (this._cachedVisibilityLocalValue is global::System.Windows.Visibility)
								{
									uielement.SetValue(global::System.Windows.UIElement.VisibilityProperty, this._cachedVisibilityLocalValue);
								}
								else if (this._cachedVisibilityLocalValue is global::System.Windows.Data.BindingBase)
								{
									global::System.Windows.FrameworkElement frameworkElement = uielement as global::System.Windows.FrameworkElement;
									if (frameworkElement != null)
									{
										frameworkElement.SetBinding(global::System.Windows.UIElement.VisibilityProperty, (global::System.Windows.Data.BindingBase)this._cachedVisibilityLocalValue);
									}
									else
									{
										uielement.ClearValue(global::System.Windows.UIElement.VisibilityProperty);
									}
								}
								else
								{
									uielement.ClearValue(global::System.Windows.UIElement.VisibilityProperty);
								}
								this._cachedVisibilityLocalValue = null;
							}
						}
					}
				}
			}

			// Token: 0x17000553 RID: 1363
			// (get) Token: 0x060017D5 RID: 6101 RVA: 0x0005B302 File Offset: 0x00059502
			// (set) Token: 0x060017D6 RID: 6102 RVA: 0x0005B30A File Offset: 0x0005950A
			internal bool IsInVisualTree
			{
				get
				{
					return this._isInVisualTree;
				}
				set
				{
					if (this._isInVisualTree != value)
					{
						this._isInVisualTree = value;
					}
				}
			}

			// Token: 0x17000554 RID: 1364
			// (get) Token: 0x060017D7 RID: 6103 RVA: 0x0005B31C File Offset: 0x0005951C
			internal bool IsItemItsOwnContainer
			{
				get
				{
					return this._isItemItsOwnContainer;
				}
			}

			// Token: 0x17000555 RID: 1365
			// (get) Token: 0x060017D8 RID: 6104 RVA: 0x0005B324 File Offset: 0x00059524
			// (set) Token: 0x060017D9 RID: 6105 RVA: 0x0005B32C File Offset: 0x0005952C
			internal object Item
			{
				get
				{
					return this._item;
				}
				set
				{
					this._item = value;
				}
			}

			// Token: 0x060017DA RID: 6106 RVA: 0x0005B338 File Offset: 0x00059538
			private static void OnZIndexPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
				global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = d as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference;
				if (containerReference != null && containerReference._generator != null)
				{
					containerReference._generator.OnZorderChanged();
				}
			}

			// Token: 0x17000556 RID: 1366
			// (get) Token: 0x060017DB RID: 6107 RVA: 0x0005B362 File Offset: 0x00059562
			// (set) Token: 0x060017DC RID: 6108 RVA: 0x0005B374 File Offset: 0x00059574
			public int ZIndex
			{
				get
				{
					return (int)base.GetValue(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference.ZIndexProperty);
				}
				set
				{
					base.SetValue(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference.ZIndexProperty, value);
				}
			}

			// Token: 0x060017DD RID: 6109 RVA: 0x0005B387 File Offset: 0x00059587
			object global::Infragistics.Collections.ISparseArrayItem.GetOwnerData(global::Infragistics.Collections.SparseArray context)
			{
				return this._sparseArrayData;
			}

			// Token: 0x060017DE RID: 6110 RVA: 0x0005B38F File Offset: 0x0005958F
			void global::Infragistics.Collections.ISparseArrayItem.SetOwnerData(object ownerData, global::Infragistics.Collections.SparseArray context)
			{
				this._sparseArrayData = ownerData;
			}

			// Token: 0x04000C23 RID: 3107
			private object _sparseArrayData;

			// Token: 0x04000C24 RID: 3108
			private global::System.Windows.DependencyObject _container;

			// Token: 0x04000C25 RID: 3109
			private object _item;

			// Token: 0x04000C26 RID: 3110
			private object _cachedVisibilityLocalValue;

			// Token: 0x04000C27 RID: 3111
			private bool _isDeactivated;

			// Token: 0x04000C28 RID: 3112
			private bool _isInVisualTree;

			// Token: 0x04000C29 RID: 3113
			private bool _isItemItsOwnContainer;

			// Token: 0x04000C2A RID: 3114
			internal int _originalIndex;

			// Token: 0x04000C2B RID: 3115
			private global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator _generator;

			// Token: 0x04000C2C RID: 3116
			public static readonly global::System.Windows.DependencyProperty ZIndexProperty = global::System.Windows.DependencyProperty.Register("ZIndex", typeof(int), typeof(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference.OnZIndexPropertyChanged)));
		}

		// Token: 0x02000250 RID: 592
		private class RecyclingGenerator : global::System.IDisposable
		{
			// Token: 0x060017E0 RID: 6112 RVA: 0x0005B3D4 File Offset: 0x000595D4
			internal RecyclingGenerator(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator owner, global::System.Windows.Controls.Primitives.GeneratorPosition position, global::System.Windows.Controls.Primitives.GeneratorDirection direction, bool allowStartAtRealizedItem)
			{
				this._owner = owner;
				this._position = position;
				this._direction = direction;
				this._currentIndex = position.Index;
				int index = position.Index;
				int num = position.Offset;
				this._generatedContainers = new global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference>();
				if (index >= 0)
				{
					int countOfActiveContainers = this._owner.CountOfActiveContainers;
					if (index < countOfActiveContainers)
					{
						global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = this._owner.GetContainerReference(index, false);
						if (containerReference != null)
						{
							this._currentIndex = this._owner._indexMap.IndexOf(containerReference);
						}
					}
				}
				if (num == 0)
				{
					if (this._currentIndex == -1)
					{
						if (direction == global::System.Windows.Controls.Primitives.GeneratorDirection.Backward)
						{
							this._currentIndex = this._owner.Items.Count - 1;
						}
						else
						{
							this._currentIndex = 0;
						}
					}
					if (!allowStartAtRealizedItem && this._owner._indexMap[this._currentIndex] != null)
					{
						if (direction == global::System.Windows.Controls.Primitives.GeneratorDirection.Backward)
						{
							num = -1;
						}
						else
						{
							num = 1;
						}
					}
				}
				else if (num < 0 && this._currentIndex < 0)
				{
					if (direction == global::System.Windows.Controls.Primitives.GeneratorDirection.Backward)
					{
						this._currentIndex = this._owner.Items.Count;
					}
					else
					{
						this._currentIndex = -1;
					}
				}
				this._currentIndex += num;
				this._startIndex = this._currentIndex;
				this._owner.SetStatus(global::System.Windows.Controls.Primitives.GeneratorStatus.GeneratingContainers);
			}

			// Token: 0x17000557 RID: 1367
			// (get) Token: 0x060017E1 RID: 6113 RVA: 0x0005B510 File Offset: 0x00059710
			internal int CountOfGeneratedItems
			{
				get
				{
					int num = this._generatedContainers.Count;
					if (this._newlyCreatedContainerNotInVisualTree != null)
					{
						num--;
					}
					return num;
				}
			}

			// Token: 0x17000558 RID: 1368
			// (get) Token: 0x060017E2 RID: 6114 RVA: 0x0005B538 File Offset: 0x00059738
			private int InsertAtIndexInActiveList
			{
				get
				{
					int count = this._owner._activeContainersInUse.Count;
					int num = 0;
					while (num < count && this._owner._indexMap.IndexOf(this._owner._activeContainersInUse[num]) <= this._startIndex)
					{
						num++;
					}
					return num;
				}
			}

			// Token: 0x060017E3 RID: 6115 RVA: 0x0005B58C File Offset: 0x0005978C
			private void CalculateNextIndex()
			{
				if (this._direction == global::System.Windows.Controls.Primitives.GeneratorDirection.Backward)
				{
					this._currentIndex--;
					return;
				}
				this._currentIndex++;
			}

			// Token: 0x060017E4 RID: 6116 RVA: 0x0005B5B4 File Offset: 0x000597B4
			internal global::System.Windows.DependencyObject GenerateNext(bool returnNullIfAlreadyRealized, out bool isNewlyRealized)
			{
				if (this._newlyCreatedContainerNotInVisualTree != null)
				{
					throw new global::System.InvalidOperationException(global::SR.GetString("LE_RecyclingGenerator_10"));
				}
				isNewlyRealized = false;
				if (this._currentIndex < 0 || this._currentIndex >= this._owner.Items.Count)
				{
					return null;
				}
				if (this._currentIndex >= this._owner._indexMap.Count)
				{
					this._owner._indexMap.Expand(this._currentIndex + 1);
				}
				global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = this._owner._indexMap[this._currentIndex] as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference;
				if (containerReference != null && !object.Equals(this._owner.Items[this._currentIndex], containerReference.Item))
				{
					if (containerReference.Container != null && !containerReference.IsDeactivated)
					{
						this._owner.DeactivateContainer(containerReference.Container);
					}
					this._owner._indexMap[this._currentIndex] = null;
					containerReference = null;
				}
				if (containerReference != null)
				{
					this._owner.RemoveContainerFromCache(containerReference);
					if (containerReference.IsDeactivated)
					{
						containerReference.IsDeactivated = false;
						this._owner._recyclingItemsControl.ReactivateContainer(containerReference.Container, containerReference.Item);
					}
					if (returnNullIfAlreadyRealized)
					{
						this._generatedContainers.Add(containerReference);
						this.CalculateNextIndex();
						return null;
					}
				}
				else
				{
					bool flag = false;
					bool flag2 = false;
					object obj = this._owner.Items[this._currentIndex];
					if (obj == null)
					{
						return null;
					}
					if (this._owner._recyclableContainers != null)
					{
						global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference2;
						if (this._owner._recyclableContainers.TryGetValue(obj, out containerReference2))
						{
							containerReference = containerReference2;
						}
						else
						{
							if (this._owner._recyclableContainersDups != null)
							{
								foreach (object obj2 in this._owner._recyclableContainersDups)
								{
									global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference3 = (global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference)obj2;
									if (object.Equals(obj, containerReference3.Item))
									{
										containerReference = containerReference3;
										break;
									}
								}
							}
							if (containerReference == null)
							{
								int count = this._owner._recyclableContainersListFiltered.Count;
								for (int i = 0; i < count; i++)
								{
									containerReference2 = this._owner._recyclableContainersListFiltered[i];
									if (this._owner.IsContainerCompatibleWithItem(containerReference2, obj))
									{
										containerReference = containerReference2;
										flag2 = true;
										break;
									}
								}
							}
						}
					}
					if (containerReference == null)
					{
						containerReference = this._owner.CreateNewContainerReference(obj);
						isNewlyRealized = true;
						this._newlyCreatedContainerNotInVisualTree = containerReference;
					}
					else
					{
						this._owner.RemoveContainerFromCache(containerReference);
					}
					int num = this._owner._indexMap.IndexOf(containerReference);
					if (num >= 0 && num != this._currentIndex)
					{
						this._owner._indexMap[num] = null;
					}
					this._owner._indexMap[this._currentIndex] = containerReference;
					if (containerReference.IsDeactivated)
					{
						if (!flag2)
						{
							flag = true;
						}
						containerReference.IsDeactivated = false;
					}
					containerReference.Item = obj;
					if (flag)
					{
						this._owner._recyclingItemsControl.ReactivateContainer(containerReference.Container, containerReference.Item);
					}
					else if (flag2)
					{
						this._owner.ConnectContainerToItem(containerReference);
						this._owner._recyclingItemsControl.ReuseContainerForNewItem(containerReference.Container, containerReference.Item);
					}
				}
				this._generatedContainers.Add(containerReference);
				this.CalculateNextIndex();
				return containerReference.Container;
			}

			// Token: 0x060017E5 RID: 6117 RVA: 0x0005B908 File Offset: 0x00059B08
			internal global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference GetActiveContainerReference(int index, bool isIndexBasedOnZOrder)
			{
				int countOfActiveContainers = this._owner.CountOfActiveContainers;
				int count = this._generatedContainers.Count;
				int insertAtIndexInActiveList = this.InsertAtIndexInActiveList;
				global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> list;
				if (isIndexBasedOnZOrder)
				{
					list = this._owner.ActiveContainersInUseByZorder;
				}
				else
				{
					list = this._owner._activeContainersInUse;
				}
				if (count == 0 || index < insertAtIndexInActiveList)
				{
					return list[index];
				}
				if (index >= insertAtIndexInActiveList + count)
				{
					return list[index - count];
				}
				index -= insertAtIndexInActiveList;
				if (this._direction == global::System.Windows.Controls.Primitives.GeneratorDirection.Backward && count > 1)
				{
					index = count - (1 + index);
				}
				return this._generatedContainers[index];
			}

			// Token: 0x060017E6 RID: 6118 RVA: 0x0005B998 File Offset: 0x00059B98
			internal int GetIndexOfActiveContainerReference(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference cr, bool isIndexBasedOnZOrder)
			{
				int countOfActiveContainers = this._owner.CountOfActiveContainers;
				int count = this._generatedContainers.Count;
				int insertAtIndexInActiveList = this.InsertAtIndexInActiveList;
				global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> list;
				if (isIndexBasedOnZOrder)
				{
					list = this._owner.ActiveContainersInUseByZorder;
				}
				else
				{
					list = this._owner._activeContainersInUse;
				}
				int num = list.IndexOf(cr);
				if (num >= 0)
				{
					if (num >= insertAtIndexInActiveList)
					{
						num += count;
					}
					return num;
				}
				num = list.IndexOf(cr);
				if (num < 0)
				{
					return -1;
				}
				if (this._direction == global::System.Windows.Controls.Primitives.GeneratorDirection.Backward && count > 1)
				{
					num = count - (1 + num);
				}
				return num + insertAtIndexInActiveList;
			}

			// Token: 0x060017E7 RID: 6119 RVA: 0x0005BA1C File Offset: 0x00059C1C
			internal void OnContainerAddedToVisualTree(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference cr)
			{
				if (cr.IsInVisualTree)
				{
					throw new global::System.InvalidOperationException(global::SR.GetString("LE_RecyclingGenerator_11"));
				}
				if (cr != this._newlyCreatedContainerNotInVisualTree)
				{
					throw new global::System.InvalidOperationException(global::SR.GetString("LE_RecyclingGenerator_12"));
				}
				cr.IsInVisualTree = true;
				this._newlyCreatedContainerNotInVisualTree = null;
			}

			// Token: 0x060017E8 RID: 6120 RVA: 0x0005BA68 File Offset: 0x00059C68
			public void Dispose()
			{
				if (this._newlyCreatedContainerNotInVisualTree != null)
				{
					throw new global::System.InvalidOperationException(global::SR.GetString("LE_RecyclingGenerator_10"));
				}
				this._owner._currentGenerator = null;
				this._owner.SetStatus(global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated);
				int num = this._generatedContainers.Count;
				if (num > 0)
				{
					if (num == 1)
					{
						if (this._owner._activeContainersInUse.Contains(this._generatedContainers[0]))
						{
							this._generatedContainers.Clear();
							num = 0;
						}
					}
					else if (this._owner._activeContainersInUse.Count > 0)
					{
						global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet();
						hashSet.AddItems(this._owner._activeContainersInUse);
						for (int i = num - 1; i >= 0; i--)
						{
							if (hashSet.Exists(this._generatedContainers[i]))
							{
								this._generatedContainers.RemoveAt(i);
								num--;
							}
						}
					}
					if (this._direction == global::System.Windows.Controls.Primitives.GeneratorDirection.Backward && num > 1)
					{
						this._generatedContainers.Reverse();
					}
					if (num > 0)
					{
						this._owner._activeContainersInUse.InsertRange(this.InsertAtIndexInActiveList, this._generatedContainers);
					}
				}
			}

			// Token: 0x04000C2D RID: 3117
			private global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator _owner;

			// Token: 0x04000C2E RID: 3118
			private global::System.Windows.Controls.Primitives.GeneratorPosition _position;

			// Token: 0x04000C2F RID: 3119
			private global::System.Windows.Controls.Primitives.GeneratorDirection _direction;

			// Token: 0x04000C30 RID: 3120
			private global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference _newlyCreatedContainerNotInVisualTree;

			// Token: 0x04000C31 RID: 3121
			private int _currentIndex;

			// Token: 0x04000C32 RID: 3122
			private int _startIndex;

			// Token: 0x04000C33 RID: 3123
			private global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> _generatedContainers;
		}

		// Token: 0x02000251 RID: 593
		private class ZOrderComparer : global::System.Collections.IComparer
		{
			// Token: 0x060017E9 RID: 6121 RVA: 0x0005BB80 File Offset: 0x00059D80
			public int Compare(object x, object y)
			{
				global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = x as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference;
				global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference2 = y as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference;
				if (containerReference == containerReference2)
				{
					return 0;
				}
				if (containerReference == null || containerReference2 == null)
				{
					if (containerReference == null)
					{
						return -1;
					}
					return 1;
				}
				else
				{
					int zindex = containerReference.ZIndex;
					int zindex2 = containerReference2.ZIndex;
					if (zindex < zindex2)
					{
						return -1;
					}
					if (zindex > zindex2)
					{
						return 1;
					}
					if (containerReference._originalIndex < containerReference2._originalIndex)
					{
						return -1;
					}
					return 1;
				}
			}
		}

		// Token: 0x02000252 RID: 594
		public class ContainerDiscardedEventArgs : global::System.Windows.RoutedEventArgs
		{
			// Token: 0x060017EB RID: 6123 RVA: 0x0005BBE1 File Offset: 0x00059DE1
			internal ContainerDiscardedEventArgs(global::System.Windows.DependencyObject container)
			{
				this._container = container;
			}

			// Token: 0x17000559 RID: 1369
			// (get) Token: 0x060017EC RID: 6124 RVA: 0x0005BBF0 File Offset: 0x00059DF0
			public global::System.Windows.DependencyObject Container
			{
				get
				{
					return this._container;
				}
			}

			// Token: 0x04000C34 RID: 3124
			private global::System.Windows.DependencyObject _container;
		}
	}
}
