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
	// Token: 0x0200021B RID: 539
	public sealed class RecyclingItemContainerGenerator : global::System.Windows.Controls.Primitives.IItemContainerGenerator
	{
		// Token: 0x06001591 RID: 5521 RVA: 0x00052C80 File Offset: 0x00050E80
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

		// Token: 0x06001592 RID: 5522 RVA: 0x00052CE8 File Offset: 0x00050EE8
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

		// Token: 0x06001593 RID: 5523 RVA: 0x00053050 File Offset: 0x00051250
		private void OnZorderChanged()
		{
			this._isZOrderDirty = true;
			if (this.ZOrderChanged != null)
			{
				this.ZOrderChanged(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x1400002F RID: 47
		// (add) Token: 0x06001594 RID: 5524 RVA: 0x00053074 File Offset: 0x00051274
		// (remove) Token: 0x06001595 RID: 5525 RVA: 0x000530AC File Offset: 0x000512AC
		public event global::System.EventHandler<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerDiscardedEventArgs> ContainerDiscarded;

		// Token: 0x14000030 RID: 48
		// (add) Token: 0x06001596 RID: 5526 RVA: 0x000530E4 File Offset: 0x000512E4
		// (remove) Token: 0x06001597 RID: 5527 RVA: 0x0005311C File Offset: 0x0005131C
		public event global::System.EventHandler StatusChanged;

		// Token: 0x14000031 RID: 49
		// (add) Token: 0x06001598 RID: 5528 RVA: 0x00053154 File Offset: 0x00051354
		// (remove) Token: 0x06001599 RID: 5529 RVA: 0x0005318C File Offset: 0x0005138C
		internal event global::System.EventHandler ZOrderChanged;

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600159A RID: 5530 RVA: 0x000531C4 File Offset: 0x000513C4
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

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x00053218 File Offset: 0x00051418
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

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x0600159C RID: 5532 RVA: 0x00053248 File Offset: 0x00051448
		public global::System.Windows.Controls.Primitives.GeneratorStatus Status
		{
			get
			{
				return this._status;
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x00053250 File Offset: 0x00051450
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

		// Token: 0x0600159E RID: 5534 RVA: 0x0005332C File Offset: 0x0005152C
		private static global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference GetContainerReference(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference)d.GetValue(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReferenceProperty);
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x0005333E File Offset: 0x0005153E
		private global::System.Windows.Controls.ItemCollection Items
		{
			get
			{
				return this._recyclingItemsControl.Items;
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x0005334B File Offset: 0x0005154B
		internal bool IsInRemoveAll
		{
			get
			{
				return this._isInRemoveAll;
			}
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x00053353 File Offset: 0x00051553
		public void BeginGeneration(global::Infragistics.Windows.Selection.ScrollDirection scrollDirection)
		{
			this.BeginGeneration(scrollDirection, null);
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x00053360 File Offset: 0x00051560
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

		// Token: 0x060015A3 RID: 5539 RVA: 0x000533C4 File Offset: 0x000515C4
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

		// Token: 0x060015A4 RID: 5540 RVA: 0x0005340C File Offset: 0x0005160C
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

		// Token: 0x060015A5 RID: 5541 RVA: 0x00053454 File Offset: 0x00051654
		public void DeactivateAllContainers()
		{
			this.DeactivateAllContainersInUse();
			this.DeactivateAllContainersInLimbo();
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00053462 File Offset: 0x00051662
		public void DeactivateContainer(global::System.Windows.DependencyObject container)
		{
			this.DeactivateContainerHelper(container, true);
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x0005346C File Offset: 0x0005166C
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

		// Token: 0x060015A8 RID: 5544 RVA: 0x000534DA File Offset: 0x000516DA
		private void DeactivateContainerHelper(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference cr)
		{
			cr.IsDeactivated = true;
			this._recyclingItemsControl.DeactivateContainer(cr.Container, cr.Item);
			this._deactivatedContainers.Add(cr);
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x00053508 File Offset: 0x00051708
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

		// Token: 0x060015AA RID: 5546 RVA: 0x0005356C File Offset: 0x0005176C
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

		// Token: 0x060015AB RID: 5547 RVA: 0x000535A8 File Offset: 0x000517A8
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

		// Token: 0x060015AC RID: 5548 RVA: 0x000535F8 File Offset: 0x000517F8
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

		// Token: 0x060015AD RID: 5549 RVA: 0x00053654 File Offset: 0x00051854
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

		// Token: 0x060015AE RID: 5550 RVA: 0x00053770 File Offset: 0x00051970
		internal global::System.Windows.DependencyObject GetContainer(int index, bool isIndexBasedOnZOrder)
		{
			global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = this.GetContainerReference(index, isIndexBasedOnZOrder);
			if (containerReference != null)
			{
				return containerReference.Container;
			}
			return null;
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x00053794 File Offset: 0x00051994
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

		// Token: 0x060015B0 RID: 5552 RVA: 0x00053880 File Offset: 0x00051A80
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

		// Token: 0x060015B1 RID: 5553 RVA: 0x000538AC File Offset: 0x00051AAC
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

		// Token: 0x060015B2 RID: 5554 RVA: 0x000538F8 File Offset: 0x00051AF8
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

		// Token: 0x060015B3 RID: 5555 RVA: 0x00053944 File Offset: 0x00051B44
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

		// Token: 0x060015B4 RID: 5556 RVA: 0x00053A70 File Offset: 0x00051C70
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

		// Token: 0x060015B5 RID: 5557 RVA: 0x00053AC0 File Offset: 0x00051CC0
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

		// Token: 0x060015B6 RID: 5558 RVA: 0x00053B00 File Offset: 0x00051D00
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

		// Token: 0x060015B7 RID: 5559 RVA: 0x00053B5C File Offset: 0x00051D5C
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

		// Token: 0x060015B8 RID: 5560 RVA: 0x00053C60 File Offset: 0x00051E60
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

		// Token: 0x060015B9 RID: 5561 RVA: 0x00053CBC File Offset: 0x00051EBC
		private object GetItem(global::System.Windows.DependencyObject container)
		{
			global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.GetContainerReference(container);
			if (containerReference == null)
			{
				return null;
			}
			return containerReference.Item;
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00053CDC File Offset: 0x00051EDC
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

		// Token: 0x060015BB RID: 5563 RVA: 0x00053D00 File Offset: 0x00051F00
		private object GetItem(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference cr, out int index)
		{
			index = this._indexMap.IndexOf(cr);
			if (index < 0)
			{
				return null;
			}
			return this.Items[index];
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00053D31 File Offset: 0x00051F31
		private bool HasContainerBeenCleared(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference cr)
		{
			return cr.Container == null || cr.Container.GetValue(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReferenceProperty) == null;
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00053D50 File Offset: 0x00051F50
		private void InitializeIndexMap()
		{
			this._indexMap = new global::Infragistics.Collections.SparseArray(20, 1f, true);
			this._indexMap.Expand(this.Items.Count);
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00053D7B File Offset: 0x00051F7B
		private bool IsContainerCompatibleWithItem(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference cr, object item)
		{
			if (cr.IsItemItsOwnContainer)
			{
				return item == cr.Item;
			}
			return this._recyclingItemsControl.IsContainerCompatibleWithItem(cr.Container, item);
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00053DA4 File Offset: 0x00051FA4
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

		// Token: 0x060015C0 RID: 5568 RVA: 0x00053F9C File Offset: 0x0005219C
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

		// Token: 0x060015C1 RID: 5569 RVA: 0x0005409C File Offset: 0x0005229C
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

		// Token: 0x060015C2 RID: 5570 RVA: 0x0005410C File Offset: 0x0005230C
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

		// Token: 0x060015C3 RID: 5571 RVA: 0x0005418C File Offset: 0x0005238C
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

		// Token: 0x060015C4 RID: 5572 RVA: 0x0005426F File Offset: 0x0005246F
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

		// Token: 0x060015C5 RID: 5573 RVA: 0x0005429C File Offset: 0x0005249C
		public global::System.Windows.DependencyObject GenerateNext()
		{
			if (this._currentGenerator == null)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_RecyclingGenerator_5"));
			}
			bool flag;
			return this._currentGenerator.GenerateNext(true, out flag);
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x000542CF File Offset: 0x000524CF
		public global::System.Windows.DependencyObject GenerateNext(out bool isNewlyRealized)
		{
			if (this._currentGenerator == null)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_RecyclingGenerator_5"));
			}
			return this._currentGenerator.GenerateNext(false, out isNewlyRealized);
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x000542F8 File Offset: 0x000524F8
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

		// Token: 0x060015C8 RID: 5576 RVA: 0x00054391 File Offset: 0x00052591
		global::System.Windows.Controls.ItemContainerGenerator global::System.Windows.Controls.Primitives.IItemContainerGenerator.GetItemContainerGeneratorForPanel(global::System.Windows.Controls.Panel panel)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x00054398 File Offset: 0x00052598
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

		// Token: 0x060015CA RID: 5578 RVA: 0x0005440C File Offset: 0x0005260C
		public void PrepareItemContainer(global::System.Windows.DependencyObject container)
		{
			object item = this.GetItem(container);
			if (this._recyclingItemsControl.ShouldApplyItemContainerStyleInternal(container, item))
			{
				this.SetItemContainerStyle(container, item);
			}
			this._recyclingItemsControl.PrepareContainerForItemInternal(container, item);
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00054448 File Offset: 0x00052648
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

		// Token: 0x060015CC RID: 5580 RVA: 0x000544F0 File Offset: 0x000526F0
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

		// Token: 0x060015CD RID: 5581 RVA: 0x000546C0 File Offset: 0x000528C0
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

		// Token: 0x060015CE RID: 5582 RVA: 0x00054712 File Offset: 0x00052912
		public global::System.IDisposable StartAt(global::System.Windows.Controls.Primitives.GeneratorPosition position, global::System.Windows.Controls.Primitives.GeneratorDirection direction)
		{
			if (!this._isGenerating)
			{
				throw new global::System.InvalidOperationException(global::SR.GetString("LE_BeginGenerationNotCalled"));
			}
			return ((global::System.Windows.Controls.Primitives.IItemContainerGenerator)this).StartAt(position, direction, false);
		}

		// Token: 0x04000AA9 RID: 2729
		private global::System.Windows.Threading.DispatcherOperation _resetOperationPending;

		// Token: 0x04000AAA RID: 2730
		private global::Infragistics.Windows.Virtualization.RecyclingItemsControl _recyclingItemsControl;

		// Token: 0x04000AAB RID: 2731
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> _deactivatedContainers;

		// Token: 0x04000AAC RID: 2732
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> _activeContainersInUse;

		// Token: 0x04000AAD RID: 2733
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> _activeContainersInUseByZorder;

		// Token: 0x04000AAE RID: 2734
		private global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> _recyclableContainers;

		// Token: 0x04000AAF RID: 2735
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> _recyclableContainersList;

		// Token: 0x04000AB0 RID: 2736
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> _recyclableContainersListFiltered;

		// Token: 0x04000AB1 RID: 2737
		private global::Infragistics.Windows.Helpers.HashSet _recyclableContainersDups;

		// Token: 0x04000AB2 RID: 2738
		private global::Infragistics.Collections.SparseArray _indexMap;

		// Token: 0x04000AB3 RID: 2739
		private global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> _referencesBeforeLastReset;

		// Token: 0x04000AB4 RID: 2740
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> _referencesBeforeLastResetList;

		// Token: 0x04000AB5 RID: 2741
		private global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.RecyclingGenerator _currentGenerator;

		// Token: 0x04000AB6 RID: 2742
		private global::System.Windows.Controls.Primitives.GeneratorStatus _status;

		// Token: 0x04000AB7 RID: 2743
		private global::Infragistics.Windows.Selection.ScrollDirection _scrollDirection;

		// Token: 0x04000AB8 RID: 2744
		private bool _isGenerating;

		// Token: 0x04000AB9 RID: 2745
		private bool _isZOrderDirty;

		// Token: 0x04000ABA RID: 2746
		private bool _isInRemoveAll;

		// Token: 0x04000ABB RID: 2747
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> _deactivatedContainersNotInIndexMap;

		// Token: 0x04000ABF RID: 2751
		private static readonly global::System.Windows.DependencyProperty ContainerReferenceProperty = global::System.Windows.DependencyProperty.RegisterAttached("ContainerReference", typeof(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference), typeof(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000AC0 RID: 2752
		private static readonly global::System.Windows.DependencyProperty IsStyleSetFromItemContainerStyleProperty = global::System.Windows.DependencyProperty.RegisterAttached("IsStyleSetFromItemContainerStyle", typeof(bool), typeof(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0200021C RID: 540
		private class ContainerReference : global::System.Windows.DependencyObject, global::Infragistics.Collections.ISparseArrayItem
		{
			// Token: 0x060015D0 RID: 5584 RVA: 0x0005479C File Offset: 0x0005299C
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

			// Token: 0x060015D1 RID: 5585 RVA: 0x0005480A File Offset: 0x00052A0A
			public override string ToString()
			{
				return string.Format("Item:{0} Container:{1}", this.Item, this.Container);
			}

			// Token: 0x170004D4 RID: 1236
			// (get) Token: 0x060015D2 RID: 5586 RVA: 0x00054822 File Offset: 0x00052A22
			internal global::System.Windows.DependencyObject Container
			{
				get
				{
					return this._container;
				}
			}

			// Token: 0x170004D5 RID: 1237
			// (get) Token: 0x060015D3 RID: 5587 RVA: 0x0005482A File Offset: 0x00052A2A
			// (set) Token: 0x060015D4 RID: 5588 RVA: 0x00054832 File Offset: 0x00052A32
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

			// Token: 0x170004D6 RID: 1238
			// (get) Token: 0x060015D5 RID: 5589 RVA: 0x0005483B File Offset: 0x00052A3B
			// (set) Token: 0x060015D6 RID: 5590 RVA: 0x00054844 File Offset: 0x00052A44
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

			// Token: 0x170004D7 RID: 1239
			// (get) Token: 0x060015D7 RID: 5591 RVA: 0x0005493E File Offset: 0x00052B3E
			// (set) Token: 0x060015D8 RID: 5592 RVA: 0x00054946 File Offset: 0x00052B46
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

			// Token: 0x170004D8 RID: 1240
			// (get) Token: 0x060015D9 RID: 5593 RVA: 0x00054958 File Offset: 0x00052B58
			internal bool IsItemItsOwnContainer
			{
				get
				{
					return this._isItemItsOwnContainer;
				}
			}

			// Token: 0x170004D9 RID: 1241
			// (get) Token: 0x060015DA RID: 5594 RVA: 0x00054960 File Offset: 0x00052B60
			// (set) Token: 0x060015DB RID: 5595 RVA: 0x00054968 File Offset: 0x00052B68
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

			// Token: 0x060015DC RID: 5596 RVA: 0x00054974 File Offset: 0x00052B74
			private static void OnZIndexPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
			{
				global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference containerReference = d as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference;
				if (containerReference != null && containerReference._generator != null)
				{
					containerReference._generator.OnZorderChanged();
				}
			}

			// Token: 0x170004DA RID: 1242
			// (get) Token: 0x060015DD RID: 5597 RVA: 0x0005499E File Offset: 0x00052B9E
			// (set) Token: 0x060015DE RID: 5598 RVA: 0x000549B0 File Offset: 0x00052BB0
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

			// Token: 0x060015DF RID: 5599 RVA: 0x000549C3 File Offset: 0x00052BC3
			object global::Infragistics.Collections.ISparseArrayItem.GetOwnerData(global::Infragistics.Collections.SparseArray context)
			{
				return this._sparseArrayData;
			}

			// Token: 0x060015E0 RID: 5600 RVA: 0x000549CB File Offset: 0x00052BCB
			void global::Infragistics.Collections.ISparseArrayItem.SetOwnerData(object ownerData, global::Infragistics.Collections.SparseArray context)
			{
				this._sparseArrayData = ownerData;
			}

			// Token: 0x04000AC1 RID: 2753
			private object _sparseArrayData;

			// Token: 0x04000AC2 RID: 2754
			private global::System.Windows.DependencyObject _container;

			// Token: 0x04000AC3 RID: 2755
			private object _item;

			// Token: 0x04000AC4 RID: 2756
			private object _cachedVisibilityLocalValue;

			// Token: 0x04000AC5 RID: 2757
			private bool _isDeactivated;

			// Token: 0x04000AC6 RID: 2758
			private bool _isInVisualTree;

			// Token: 0x04000AC7 RID: 2759
			private bool _isItemItsOwnContainer;

			// Token: 0x04000AC8 RID: 2760
			internal int _originalIndex;

			// Token: 0x04000AC9 RID: 2761
			private global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator _generator;

			// Token: 0x04000ACA RID: 2762
			public static readonly global::System.Windows.DependencyProperty ZIndexProperty = global::System.Windows.DependencyProperty.Register("ZIndex", typeof(int), typeof(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference.OnZIndexPropertyChanged)));
		}

		// Token: 0x0200021D RID: 541
		private class RecyclingGenerator : global::System.IDisposable
		{
			// Token: 0x060015E2 RID: 5602 RVA: 0x00054A10 File Offset: 0x00052C10
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

			// Token: 0x170004DB RID: 1243
			// (get) Token: 0x060015E3 RID: 5603 RVA: 0x00054B4C File Offset: 0x00052D4C
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

			// Token: 0x170004DC RID: 1244
			// (get) Token: 0x060015E4 RID: 5604 RVA: 0x00054B74 File Offset: 0x00052D74
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

			// Token: 0x060015E5 RID: 5605 RVA: 0x00054BC8 File Offset: 0x00052DC8
			private void CalculateNextIndex()
			{
				if (this._direction == global::System.Windows.Controls.Primitives.GeneratorDirection.Backward)
				{
					this._currentIndex--;
					return;
				}
				this._currentIndex++;
			}

			// Token: 0x060015E6 RID: 5606 RVA: 0x00054BF0 File Offset: 0x00052DF0
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

			// Token: 0x060015E7 RID: 5607 RVA: 0x00054EE4 File Offset: 0x000530E4
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

			// Token: 0x060015E8 RID: 5608 RVA: 0x00054F74 File Offset: 0x00053174
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

			// Token: 0x060015E9 RID: 5609 RVA: 0x00054FF8 File Offset: 0x000531F8
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

			// Token: 0x060015EA RID: 5610 RVA: 0x00055044 File Offset: 0x00053244
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

			// Token: 0x04000ACB RID: 2763
			private global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator _owner;

			// Token: 0x04000ACC RID: 2764
			private global::System.Windows.Controls.Primitives.GeneratorPosition _position;

			// Token: 0x04000ACD RID: 2765
			private global::System.Windows.Controls.Primitives.GeneratorDirection _direction;

			// Token: 0x04000ACE RID: 2766
			private global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference _newlyCreatedContainerNotInVisualTree;

			// Token: 0x04000ACF RID: 2767
			private int _currentIndex;

			// Token: 0x04000AD0 RID: 2768
			private int _startIndex;

			// Token: 0x04000AD1 RID: 2769
			private global::System.Collections.Generic.List<global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerReference> _generatedContainers;
		}

		// Token: 0x0200021E RID: 542
		private class ZOrderComparer : global::System.Collections.IComparer
		{
			// Token: 0x060015EB RID: 5611 RVA: 0x0005515C File Offset: 0x0005335C
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

		// Token: 0x0200021F RID: 543
		public class ContainerDiscardedEventArgs : global::System.Windows.RoutedEventArgs
		{
			// Token: 0x060015ED RID: 5613 RVA: 0x000551BD File Offset: 0x000533BD
			internal ContainerDiscardedEventArgs(global::System.Windows.DependencyObject container)
			{
				this._container = container;
			}

			// Token: 0x170004DD RID: 1245
			// (get) Token: 0x060015EE RID: 5614 RVA: 0x000551CC File Offset: 0x000533CC
			public global::System.Windows.DependencyObject Container
			{
				get
				{
					return this._container;
				}
			}

			// Token: 0x04000AD2 RID: 2770
			private global::System.Windows.DependencyObject _container;
		}
	}
}
