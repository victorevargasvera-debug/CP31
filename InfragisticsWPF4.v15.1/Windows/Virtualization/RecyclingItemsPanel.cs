using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.Virtualization
{
	// Token: 0x020001E6 RID: 486
	public abstract class RecyclingItemsPanel : global::System.Windows.Controls.VirtualizingPanel
	{
		// Token: 0x06001174 RID: 4468 RVA: 0x0003DEBD File Offset: 0x0003C0BD
		protected RecyclingItemsPanel() : this(false)
		{
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x0003DEC6 File Offset: 0x0003C0C6
		protected RecyclingItemsPanel(bool removeDeactivatedContainersOnCleanup)
		{
			this._removeDeactivatedContainersOnCleanup = removeDeactivatedContainersOnCleanup;
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0003DEDC File Offset: 0x0003C0DC
		private void OnContainerDiscarded(object sender, global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator.ContainerDiscardedEventArgs e)
		{
			this._zOrderDirty = true;
			if (global::System.Windows.LogicalTreeHelper.GetParent(e.Container) == this)
			{
				base.RemoveLogicalChild(e.Container);
			}
			if (e.Container is global::System.Windows.Media.Visual)
			{
				base.RemoveVisualChild(e.Container as global::System.Windows.Media.Visual);
			}
			global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator recyclingItemContainerGenerator = sender as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator;
			if (recyclingItemContainerGenerator != null && recyclingItemContainerGenerator.IsInRemoveAll)
			{
				base.InvalidateMeasure();
			}
			global::System.Windows.IInputElement inputElement = e.Container as global::System.Windows.IInputElement;
			if (inputElement != null && inputElement.IsKeyboardFocusWithin)
			{
				for (global::System.Windows.DependencyObject parent = global::Infragistics.Windows.Utilities.GetParent(this, true); parent != null; parent = global::Infragistics.Windows.Utilities.GetParent(parent, true))
				{
					global::System.Windows.IInputElement inputElement2 = parent as global::System.Windows.IInputElement;
					if (inputElement2 != null && inputElement2.Focusable)
					{
						inputElement2.Focus();
						return;
					}
				}
			}
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x0003DF88 File Offset: 0x0003C188
		private static void OnItemContainerGenerationModeChanged(global::System.Windows.DependencyObject item, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Virtualization.RecyclingItemsPanel recyclingItemsPanel = item as global::Infragistics.Windows.Virtualization.RecyclingItemsPanel;
			recyclingItemsPanel._cachedItemContainerGenerationMode = (global::Infragistics.Windows.Controls.ItemContainerGenerationMode)e.NewValue;
			recyclingItemsPanel._hasBeenPreloaded = false;
			recyclingItemsPanel.InvalidateMeasure();
			bool flag = recyclingItemsPanel._cachedItemContainerGenerationMode == global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle;
			if (flag != recyclingItemsPanel._wasRecyclingOnLastGeneration)
			{
				recyclingItemsPanel.OnIsRecyclingStateChanged();
			}
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x0003DFD4 File Offset: 0x0003C1D4
		private void OnZOrderChanged(object sender, global::System.EventArgs e)
		{
			this._zOrderDirty = true;
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x0003DFDD File Offset: 0x0003C1DD
		protected new void AddInternalChild(global::System.Windows.UIElement child)
		{
			if (!this.PerformRecyclingAdd(child))
			{
				base.AddInternalChild(child);
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x0003DFEF File Offset: 0x0003C1EF
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Windows.Controls.UIElementCollection Children
		{
			get
			{
				return base.Children;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x0003DFF7 File Offset: 0x0003C1F7
		public global::System.Collections.IList ChildElements
		{
			get
			{
				if (this._children == null)
				{
					this._children = new global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.RecycleableContainerCollection(this);
				}
				return this._children;
			}
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x0003E014 File Offset: 0x0003C214
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (this._wasRecyclingOnLastGeneration)
			{
				global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator recyclingItemContainerGenerator = this.ActiveItemContainerGenerator as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator;
				if (recyclingItemContainerGenerator != null)
				{
					if (this._zOrderDirty && base.InternalChildren.Count > 0)
					{
						this._zOrderDirty = false;
						base.GetVisualChild(0);
					}
					return recyclingItemContainerGenerator.GetContainer(index, true) as global::System.Windows.Media.Visual;
				}
			}
			return base.GetVisualChild(index);
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x0003E072 File Offset: 0x0003C272
		protected new void InsertInternalChild(int index, global::System.Windows.UIElement child)
		{
			if (!this.PerformRecyclingAdd(child))
			{
				base.InsertInternalChild(index, child);
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x0003E085 File Offset: 0x0003C285
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				if (this.ItemContainerGenerationModeResolved == global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
				{
					return new global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.ContainerEnumerator(this, false);
				}
				return base.LogicalChildren;
			}
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x0003E0A0 File Offset: 0x0003C2A0
		protected override void OnIsItemsHostChanged(bool oldIsItemsHost, bool newIsItemsHost)
		{
			if (!newIsItemsHost && oldIsItemsHost && this._recyclingEventsWired)
			{
				global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator recyclingItemContainerGenerator = this.ActiveItemContainerGenerator as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator;
				if (recyclingItemContainerGenerator != null)
				{
					this._recyclingEventsWired = false;
					recyclingItemContainerGenerator.DeactivateAllContainers();
					recyclingItemContainerGenerator.RemoveAllDeactivatedContainers();
					recyclingItemContainerGenerator.ContainerDiscarded -= this.OnContainerDiscarded;
					recyclingItemContainerGenerator.ZOrderChanged -= this.OnZOrderChanged;
				}
			}
			base.OnIsItemsHostChanged(oldIsItemsHost, newIsItemsHost);
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x0003E10C File Offset: 0x0003C30C
		protected override void OnItemsChanged(object sender, global::System.Windows.Controls.Primitives.ItemsChangedEventArgs args)
		{
			global::System.Collections.Specialized.NotifyCollectionChangedAction action = args.Action;
			if (action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
			{
				this._hasBeenPreloaded = false;
				this._zOrderDirty = true;
				if (this._pendingPostResetVerification == null && this.ItemContainerGenerationModeResolved == global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
				{
					if (global::Infragistics.Windows.Utilities.AllowsAsyncOperations(this))
					{
						this.OnPostResetVerification(null);
					}
					else
					{
						this._pendingPostResetVerification = base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::System.Windows.Threading.DispatcherOperationCallback(this.OnPostResetVerification), null);
					}
				}
			}
			base.OnItemsChanged(sender, args);
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x0003E17B File Offset: 0x0003C37B
		protected new void RemoveInternalChildRange(int index, int range)
		{
			if (this.ItemContainerGenerationModeResolved != global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
			{
				base.RemoveInternalChildRange(index, range);
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001182 RID: 4482 RVA: 0x0003E190 File Offset: 0x0003C390
		protected override int VisualChildrenCount
		{
			get
			{
				if (this._wasRecyclingOnLastGeneration)
				{
					global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator recyclingItemContainerGenerator = this.ActiveItemContainerGenerator as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator;
					if (recyclingItemContainerGenerator != null)
					{
						return recyclingItemContainerGenerator.CountOfAllContainers;
					}
				}
				return base.VisualChildrenCount;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x0003E1C4 File Offset: 0x0003C3C4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Controls.Primitives.IItemContainerGenerator ActiveItemContainerGenerator
		{
			get
			{
				global::System.Windows.Controls.ItemsControl itemsControl = this.ItemsControl;
				if (itemsControl == null)
				{
					return null;
				}
				if (this._wasRecyclingOnLastGeneration && itemsControl is global::Infragistics.Windows.Virtualization.RecyclingItemsControl)
				{
					return ((global::Infragistics.Windows.Virtualization.RecyclingItemsControl)itemsControl).RecyclingItemContainerGenerator;
				}
				return itemsControl.ItemContainerGenerator;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001184 RID: 4484 RVA: 0x0003E1FF File Offset: 0x0003C3FF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.Controls.ItemContainerGenerationMode ItemContainerGenerationModeResolved
		{
			get
			{
				return this._cachedItemContainerGenerationMode;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x0003E207 File Offset: 0x0003C407
		protected virtual bool IsOkToCleanupUnusedGeneratedElements
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001186 RID: 4486
		protected abstract int TotalVisibleGeneratedItems { get; }

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x0003E20A File Offset: 0x0003C40A
		protected virtual int MaximumUnusedGeneratedItemsToKeep
		{
			get
			{
				return 50;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x0003E210 File Offset: 0x0003C410
		internal global::System.Windows.Controls.ItemsControl ItemsControl
		{
			get
			{
				if (this._itemsControl == null)
				{
					this._itemsControl = global::System.Windows.Controls.ItemsControl.GetItemsOwner(this);
					if (this._itemsControl is global::Infragistics.Windows.Virtualization.RecyclingItemsControl)
					{
						base.SetBinding(global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.ItemContainerGenerationModeProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Virtualization.RecyclingItemsControl.ItemContainerGenerationModeProperty, global::System.Windows.Data.BindingMode.OneWay, this._itemsControl));
						this._cachedItemContainerGenerationMode = ((global::Infragistics.Windows.Virtualization.RecyclingItemsControl)this._itemsControl).ItemContainerGenerationMode;
					}
					else if (this._itemsControl == null)
					{
						this._cachedItemContainerGenerationMode = global::Infragistics.Windows.Controls.ItemContainerGenerationMode.PreLoad;
					}
					else
					{
						this._cachedItemContainerGenerationMode = global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Virtualize;
					}
				}
				return this._itemsControl;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x0003E291 File Offset: 0x0003C491
		internal int TotalItems
		{
			get
			{
				if (this.ItemsControl != null && this.ItemsControl.HasItems)
				{
					return this.ItemsControl.Items.Count;
				}
				return 0;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x0003E2BC File Offset: 0x0003C4BC
		private int CountOfActiveContainers
		{
			get
			{
				if (this._wasRecyclingOnLastGeneration)
				{
					global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator recyclingItemContainerGenerator = this.ActiveItemContainerGenerator as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator;
					if (recyclingItemContainerGenerator != null)
					{
						return recyclingItemContainerGenerator.CountOfActiveContainers;
					}
				}
				return base.InternalChildren.Count;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x0003E2F2 File Offset: 0x0003C4F2
		private int TotalGeneratedChildrenCount
		{
			get
			{
				if (!base.IsItemsHost)
				{
					return 0;
				}
				return base.InternalChildren.Count;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x0003E30C File Offset: 0x0003C50C
		private int UnderlyingItemsCount
		{
			get
			{
				global::Infragistics.Windows.Virtualization.RecyclingItemsControl recyclingItemsControl = this.ItemsControl as global::Infragistics.Windows.Virtualization.RecyclingItemsControl;
				if (recyclingItemsControl != null)
				{
					return recyclingItemsControl.UnderlyingItemsCount;
				}
				if (this._itemsControl != null)
				{
					return this._itemsControl.Items.Count;
				}
				return 0;
			}
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x0003E34C File Offset: 0x0003C54C
		public global::System.Windows.DependencyObject ContainerFromIndex(int index)
		{
			if (!base.IsItemsHost)
			{
				return this.ChildElements[index] as global::System.Windows.DependencyObject;
			}
			global::System.Windows.Controls.Primitives.IItemContainerGenerator activeItemContainerGenerator = this.ActiveItemContainerGenerator;
			global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator recyclingItemContainerGenerator = activeItemContainerGenerator as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator;
			if (recyclingItemContainerGenerator != null)
			{
				return recyclingItemContainerGenerator.ContainerFromIndex(index);
			}
			global::System.Windows.Controls.ItemContainerGenerator itemContainerGenerator = activeItemContainerGenerator as global::System.Windows.Controls.ItemContainerGenerator;
			if (itemContainerGenerator != null)
			{
				return itemContainerGenerator.ContainerFromIndex(index);
			}
			return this.ChildElements[index] as global::System.Windows.DependencyObject;
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x0003E3B0 File Offset: 0x0003C5B0
		public global::System.Windows.DependencyObject ContainerFromItem(object item)
		{
			if (!base.IsItemsHost)
			{
				return item as global::System.Windows.DependencyObject;
			}
			global::System.Windows.Controls.Primitives.IItemContainerGenerator activeItemContainerGenerator = this.ActiveItemContainerGenerator;
			global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator recyclingItemContainerGenerator = activeItemContainerGenerator as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator;
			if (recyclingItemContainerGenerator != null)
			{
				return recyclingItemContainerGenerator.ContainerFromItem(item);
			}
			global::System.Windows.Controls.ItemContainerGenerator itemContainerGenerator = activeItemContainerGenerator as global::System.Windows.Controls.ItemContainerGenerator;
			if (itemContainerGenerator != null)
			{
				return itemContainerGenerator.ContainerFromItem(item);
			}
			return item as global::System.Windows.DependencyObject;
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x0003E400 File Offset: 0x0003C600
		public object ItemFromContainer(global::System.Windows.DependencyObject container)
		{
			if (container == null)
			{
				throw new global::System.ArgumentNullException("container");
			}
			if (!base.IsItemsHost)
			{
				return container;
			}
			global::System.Windows.Controls.Primitives.IItemContainerGenerator activeItemContainerGenerator = this.ActiveItemContainerGenerator;
			global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator recyclingItemContainerGenerator = activeItemContainerGenerator as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator;
			if (recyclingItemContainerGenerator != null)
			{
				return recyclingItemContainerGenerator.ItemFromContainer(container);
			}
			global::System.Windows.Controls.ItemContainerGenerator itemContainerGenerator = activeItemContainerGenerator as global::System.Windows.Controls.ItemContainerGenerator;
			if (itemContainerGenerator != null)
			{
				return itemContainerGenerator.ItemFromContainer(container);
			}
			return container;
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x0003E454 File Offset: 0x0003C654
		public void RemoveAllDeactivatedContainers()
		{
			if (this.ItemContainerGenerationModeResolved == global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
			{
				global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator recyclingItemContainerGenerator = this.ActiveItemContainerGenerator as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator;
				if (recyclingItemContainerGenerator != null)
				{
					recyclingItemContainerGenerator.RemoveAllDeactivatedContainers();
				}
			}
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x0003E480 File Offset: 0x0003C680
		public void VerifyAllDeactivatedContainers()
		{
			if (this.ItemContainerGenerationModeResolved == global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
			{
				global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator recyclingItemContainerGenerator = this.ActiveItemContainerGenerator as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator;
				if (recyclingItemContainerGenerator != null)
				{
					recyclingItemContainerGenerator.VerifyAllDeactivatedContainers();
				}
			}
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x0003E4AA File Offset: 0x0003C6AA
		protected void BeginGeneration(global::Infragistics.Windows.Selection.ScrollDirection scrollDirection)
		{
			this.BeginGeneration(scrollDirection, null);
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x0003E4B4 File Offset: 0x0003C6B4
		protected void BeginGeneration(global::Infragistics.Windows.Selection.ScrollDirection scrollDirection, global::System.Collections.IEnumerable itemsExpectedToBeGenerated)
		{
			this._wasRecyclingOnLastGeneration = false;
			this._pendingPostResetVerification = null;
			if (this.ItemsControl == null)
			{
				return;
			}
			int count = base.InternalChildren.Count;
			global::Infragistics.Windows.Controls.ItemContainerGenerationMode itemContainerGenerationModeResolved = this.ItemContainerGenerationModeResolved;
			if (itemContainerGenerationModeResolved != global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
			{
				if (itemContainerGenerationModeResolved != global::Infragistics.Windows.Controls.ItemContainerGenerationMode.PreLoad)
				{
					return;
				}
				bool flag = base.InternalChildren.Count == 0;
				if (this._hasBeenPreloaded && !flag)
				{
					return;
				}
				global::System.Windows.Controls.Primitives.IItemContainerGenerator activeItemContainerGenerator = this.ActiveItemContainerGenerator;
				using (activeItemContainerGenerator.StartAt(activeItemContainerGenerator.GeneratorPositionFromIndex(0), global::System.Windows.Controls.Primitives.GeneratorDirection.Forward, true))
				{
					int num = 0;
					int underlyingItemsCount = this.UnderlyingItemsCount;
					do
					{
						bool flag2;
						global::System.Windows.FrameworkElement frameworkElement = activeItemContainerGenerator.GenerateNext(out flag2) as global::System.Windows.FrameworkElement;
						if (frameworkElement == null)
						{
							break;
						}
						if (flag2)
						{
							base.InsertInternalChild(num, frameworkElement);
							activeItemContainerGenerator.PrepareItemContainer(frameworkElement);
						}
						num++;
					}
					while (num < underlyingItemsCount);
				}
				this._hasBeenPreloaded = true;
				return;
			}
			else
			{
				this._wasRecyclingOnLastGeneration = true;
				global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator recyclingItemContainerGenerator = this.ActiveItemContainerGenerator as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator;
				if (recyclingItemContainerGenerator != null)
				{
					if (!this._recyclingEventsWired)
					{
						this._recyclingEventsWired = true;
						recyclingItemContainerGenerator.ContainerDiscarded += this.OnContainerDiscarded;
						recyclingItemContainerGenerator.ZOrderChanged += this.OnZOrderChanged;
					}
					recyclingItemContainerGenerator.BeginGeneration(scrollDirection, itemsExpectedToBeGenerated);
					return;
				}
				this._wasRecyclingOnLastGeneration = false;
				return;
			}
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x0003E5EC File Offset: 0x0003C7EC
		protected bool CleanupUnusedGeneratedElements()
		{
			if (this._isInCleanup)
			{
				return false;
			}
			if (!base.IsItemsHost || this.ItemContainerGenerationModeResolved != global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Virtualize)
			{
				if (this._removeDeactivatedContainersOnCleanup)
				{
					this.RemoveAllDeactivatedContainers();
				}
				return false;
			}
			this._isInCleanup = true;
			try
			{
				int tickCount = global::System.Environment.TickCount;
				int num = this.TotalGeneratedChildrenCount;
				int totalVisibleGeneratedItems = this.TotalVisibleGeneratedItems;
				int num2 = num - totalVisibleGeneratedItems;
				if (num2 > this.MaximumUnusedGeneratedItemsToKeep)
				{
					global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
					global::System.Windows.Controls.Primitives.IItemContainerGenerator activeItemContainerGenerator = this.ActiveItemContainerGenerator;
					for (int i = 0; i < num; i++)
					{
						if (this.ShouldAbortCleanup(tickCount) != global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.AbortAction.NoAbort)
						{
							return num2 > this.MaximumUnusedGeneratedItemsToKeep;
						}
						if (!internalChildren[i].IsKeyboardFocusWithin)
						{
							int itemIndexFromChildIndex = this.GetItemIndexFromChildIndex(i);
							if (this.GetCanCleanupItem(itemIndexFromChildIndex))
							{
								int num3 = itemIndexFromChildIndex;
								int num4 = 1;
								int num5 = i + 1;
								while (num5 < num && !internalChildren[num5].IsKeyboardFocusWithin)
								{
									global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.AbortAction abortAction = this.ShouldAbortCleanup(tickCount);
									if (abortAction != global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.AbortAction.NoAbort)
									{
										if (abortAction == global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.AbortAction.AbortWithCleanup)
										{
											activeItemContainerGenerator.Remove(new global::System.Windows.Controls.Primitives.GeneratorPosition(i, 0), num4);
											this.RemoveInternalChildRange(i, num4);
											num2 -= num4;
											num -= num4;
										}
										return num2 > this.MaximumUnusedGeneratedItemsToKeep;
									}
									itemIndexFromChildIndex = this.GetItemIndexFromChildIndex(num5);
									if (!this.GetCanCleanupItem(itemIndexFromChildIndex) || itemIndexFromChildIndex != num3 + 1 || num2 - num4 <= this.MaximumUnusedGeneratedItemsToKeep)
									{
										break;
									}
									num3 = itemIndexFromChildIndex;
									num4++;
									num5++;
								}
								activeItemContainerGenerator.Remove(new global::System.Windows.Controls.Primitives.GeneratorPosition(i, 0), num4);
								this.RemoveInternalChildRange(i, num4);
								num2 -= num4;
								num -= num4;
								i--;
							}
							if (num2 <= this.MaximumUnusedGeneratedItemsToKeep)
							{
								break;
							}
						}
					}
				}
			}
			finally
			{
				this._isInCleanup = false;
			}
			return false;
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x0003E7C8 File Offset: 0x0003C9C8
		public void DeactivateAllContainers()
		{
			if (this.ItemContainerGenerationModeResolved == global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
			{
				global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator recyclingItemContainerGenerator = this.ActiveItemContainerGenerator as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator;
				if (recyclingItemContainerGenerator != null)
				{
					recyclingItemContainerGenerator.DeactivateAllContainers();
				}
			}
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x0003E7F4 File Offset: 0x0003C9F4
		public void DeactivateContainer(global::System.Windows.DependencyObject container)
		{
			if (this.ItemContainerGenerationModeResolved == global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
			{
				global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator recyclingItemContainerGenerator = this.ActiveItemContainerGenerator as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator;
				if (recyclingItemContainerGenerator != null)
				{
					recyclingItemContainerGenerator.DeactivateContainer(container);
				}
			}
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x0003E820 File Offset: 0x0003CA20
		protected void EndGeneration()
		{
			switch (this.ItemContainerGenerationModeResolved)
			{
			case global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle:
			{
				global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator recyclingItemContainerGenerator = this.ActiveItemContainerGenerator as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator;
				if (recyclingItemContainerGenerator != null)
				{
					recyclingItemContainerGenerator.EndGeneration();
					this._zOrderDirty = true;
					if (base.InternalChildren.Count == 0 && recyclingItemContainerGenerator.CountOfActiveContainers > 0)
					{
						base.AddInternalChild(new global::System.Windows.FrameworkElement());
						return;
					}
				}
				break;
			}
			case global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Virtualize:
				this.TriggerCleanupOfUnusedGeneratedItems(true);
				break;
			default:
				return;
			}
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x0003E888 File Offset: 0x0003CA88
		protected void InvalidateZOrder()
		{
			if (this.ItemContainerGenerationModeResolved != global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle || this.CountOfActiveContainers < 2)
			{
				return;
			}
			this._zOrderDirty = true;
			if (base.InternalChildren.Count == 0)
			{
				base.AddInternalChild(new global::System.Windows.FrameworkElement());
			}
			if (base.InternalChildren.Count > 0)
			{
				global::System.Windows.UIElement uielement = base.InternalChildren[0];
				int num = (int)uielement.GetValue(global::System.Windows.Controls.Panel.ZIndexProperty);
				uielement.SetValue(global::System.Windows.Controls.Panel.ZIndexProperty, num + 1);
			}
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x0003E908 File Offset: 0x0003CB08
		protected void TriggerCleanupOfUnusedGeneratedItems(bool useDelay)
		{
			if (!base.IsItemsHost)
			{
				return;
			}
			if (!global::Infragistics.Windows.Utilities.AllowsAsyncOperations(this))
			{
				this.OnAsyncCleanUp(null);
				return;
			}
			if (useDelay)
			{
				bool flag = true;
				if (this._pendingAsyncCleanup != null)
				{
					flag = this._pendingAsyncCleanup.Abort();
					if (flag)
					{
						this._pendingAsyncCleanup = null;
					}
				}
				if (flag)
				{
					if (this._cleanupDelayTimer == null)
					{
						this._cleanupDelayTimer = new global::System.Windows.Threading.DispatcherTimer();
						this._cleanupDelayTimer.Tick += this.OnCleanupDelayExpired;
						this._cleanupDelayTimer.Interval = global::System.TimeSpan.FromMilliseconds(500.0);
						this._cleanupDelayTimer.Start();
						base.Unloaded += this.OnUnloaded;
						return;
					}
					if (this._removeDeactivatedContainersOnCleanup && this.ItemContainerGenerationModeResolved == global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
					{
						this._cleanupDelayTimer.Stop();
						this._cleanupDelayTimer.Start();
						return;
					}
				}
			}
			else if (this._pendingAsyncCleanup == null)
			{
				this._pendingAsyncCleanup = base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Background, new global::System.Windows.Threading.DispatcherOperationCallback(this.OnAsyncCleanUp), null);
			}
		}

		// Token: 0x0600119A RID: 4506
		protected abstract bool GetCanCleanupItem(int itemIndex);

		// Token: 0x0600119B RID: 4507 RVA: 0x0003EA0C File Offset: 0x0003CC0C
		protected int GetChildIndexFromItemIndex(int itemIndex)
		{
			if (!base.IsItemsHost)
			{
				return itemIndex;
			}
			global::System.Windows.Controls.Primitives.IItemContainerGenerator activeItemContainerGenerator = this.ActiveItemContainerGenerator;
			if (activeItemContainerGenerator == null)
			{
				return itemIndex;
			}
			global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
			global::System.Windows.Controls.Primitives.GeneratorPosition generatorPosition = activeItemContainerGenerator.GeneratorPositionFromIndex(itemIndex);
			if (generatorPosition.Offset != 0)
			{
				return generatorPosition.Index + 1;
			}
			return generatorPosition.Index;
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x0003EA58 File Offset: 0x0003CC58
		protected int GetItemIndexFromChildIndex(int childIndex)
		{
			if (!base.IsItemsHost)
			{
				return childIndex;
			}
			global::System.Windows.Controls.Primitives.IItemContainerGenerator activeItemContainerGenerator = this.ActiveItemContainerGenerator;
			if (activeItemContainerGenerator == null)
			{
				return childIndex;
			}
			global::System.Windows.Controls.UIElementCollection internalChildren = base.InternalChildren;
			return activeItemContainerGenerator.IndexFromGeneratorPosition(new global::System.Windows.Controls.Primitives.GeneratorPosition(childIndex, 0));
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x0003EA8F File Offset: 0x0003CC8F
		protected virtual void OnNewElementRealized(global::System.Windows.UIElement element, int index)
		{
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x0003EA94 File Offset: 0x0003CC94
		private global::System.Windows.Media.Visual GetChildElement(int index)
		{
			if (this.ItemContainerGenerationModeResolved == global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
			{
				global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator recyclingItemContainerGenerator = this.ActiveItemContainerGenerator as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator;
				if (recyclingItemContainerGenerator != null)
				{
					return recyclingItemContainerGenerator.GetContainer(index, false) as global::System.Windows.Media.Visual;
				}
			}
			return base.Children[index];
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0003EAD4 File Offset: 0x0003CCD4
		private object OnAsyncCleanUp(object args)
		{
			bool flag = false;
			try
			{
				flag = this.CleanupUnusedGeneratedElements();
			}
			finally
			{
				this._pendingAsyncCleanup = null;
			}
			if (flag)
			{
				this.TriggerCleanupOfUnusedGeneratedItems(true);
			}
			return null;
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x0003EB10 File Offset: 0x0003CD10
		private void OnCleanupDelayExpired(object sender, global::System.EventArgs e)
		{
			bool flag = false;
			try
			{
				flag = this.CleanupUnusedGeneratedElements();
			}
			finally
			{
				if (!flag)
				{
					base.Unloaded -= this.OnUnloaded;
					this._cleanupDelayTimer.Stop();
					this._cleanupDelayTimer = null;
				}
			}
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x0003EB60 File Offset: 0x0003CD60
		private void OnIsRecyclingStateChanged()
		{
			int count = base.InternalChildren.Count;
			if (count > 0)
			{
				base.RemoveInternalChildRange(0, count);
			}
			if (this._wasRecyclingOnLastGeneration)
			{
				global::Infragistics.Windows.Virtualization.RecyclingItemsControl recyclingItemsControl = this.ItemsControl as global::Infragistics.Windows.Virtualization.RecyclingItemsControl;
				if (recyclingItemsControl != null)
				{
					recyclingItemsControl.RecyclingItemContainerGenerator.RemoveAll();
				}
			}
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x0003EBA7 File Offset: 0x0003CDA7
		private object OnPostResetVerification(object args)
		{
			if (this._pendingPostResetVerification != null)
			{
				this.BeginGeneration(global::Infragistics.Windows.Selection.ScrollDirection.Increment);
				this.EndGeneration();
			}
			return null;
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x0003EBBF File Offset: 0x0003CDBF
		private void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Unloaded -= this.OnUnloaded;
			if (this._cleanupDelayTimer != null)
			{
				this._cleanupDelayTimer.Stop();
				this._cleanupDelayTimer = null;
				this.CleanupUnusedGeneratedElements();
			}
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x0003EBF4 File Offset: 0x0003CDF4
		private bool PerformRecyclingAdd(global::System.Windows.UIElement child)
		{
			if (this.ItemContainerGenerationModeResolved == global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
			{
				global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator recyclingItemContainerGenerator = this.ActiveItemContainerGenerator as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator;
				if (recyclingItemContainerGenerator != null)
				{
					if (global::System.Windows.LogicalTreeHelper.GetParent(child) == null)
					{
						base.AddLogicalChild(child);
					}
					base.AddVisualChild(child);
					recyclingItemContainerGenerator.OnContainerAddedToVisualTree(child);
					this._zOrderDirty = true;
					if (base.InternalChildren.Count == 0)
					{
						base.AddInternalChild(new global::System.Windows.FrameworkElement());
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0003EC57 File Offset: 0x0003CE57
		private global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.AbortAction ShouldAbortCleanup(int tickAtStartOfCleanup)
		{
			if (global::System.Environment.TickCount - tickAtStartOfCleanup > 200)
			{
				return global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.AbortAction.AbortWithCleanup;
			}
			if (!this.IsOkToCleanupUnusedGeneratedElements)
			{
				return global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.AbortAction.AbortWithNoCleanup;
			}
			return global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.AbortAction.NoAbort;
		}

		// Token: 0x0400094B RID: 2379
		private const int MAX_TICKS_IN_CLEANUP = 200;

		// Token: 0x0400094C RID: 2380
		private const int MAXIMUM_UNUSED_GENERATED_ITEMS_TO_KEEP = 50;

		// Token: 0x0400094D RID: 2381
		private bool _hasBeenPreloaded;

		// Token: 0x0400094E RID: 2382
		private bool _recyclingEventsWired;

		// Token: 0x0400094F RID: 2383
		private global::System.Windows.Threading.DispatcherOperation _pendingAsyncCleanup;

		// Token: 0x04000950 RID: 2384
		private global::System.Windows.Threading.DispatcherOperation _pendingPostResetVerification;

		// Token: 0x04000951 RID: 2385
		private global::System.Windows.Threading.DispatcherTimer _cleanupDelayTimer;

		// Token: 0x04000952 RID: 2386
		private global::System.Windows.Controls.ItemsControl _itemsControl;

		// Token: 0x04000953 RID: 2387
		private bool _zOrderDirty;

		// Token: 0x04000954 RID: 2388
		private bool _wasRecyclingOnLastGeneration;

		// Token: 0x04000955 RID: 2389
		private global::Infragistics.Windows.Controls.ItemContainerGenerationMode _cachedItemContainerGenerationMode = global::Infragistics.Windows.Controls.ItemContainerGenerationMode.PreLoad;

		// Token: 0x04000956 RID: 2390
		private global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.RecycleableContainerCollection _children;

		// Token: 0x04000957 RID: 2391
		private bool _isInCleanup;

		// Token: 0x04000958 RID: 2392
		private bool _removeDeactivatedContainersOnCleanup;

		// Token: 0x04000959 RID: 2393
		private static global::System.Windows.DependencyProperty ItemContainerGenerationModeProperty = global::Infragistics.Windows.Virtualization.RecyclingItemsControl.ItemContainerGenerationModeProperty.AddOwner(typeof(global::Infragistics.Windows.Virtualization.RecyclingItemsPanel), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.OnItemContainerGenerationModeChanged)));

		// Token: 0x020001E7 RID: 487
		private class ContainerEnumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x060011A7 RID: 4519 RVA: 0x0003ECA0 File Offset: 0x0003CEA0
			internal ContainerEnumerator(global::Infragistics.Windows.Virtualization.RecyclingItemsPanel panel, bool activeContainersOnly)
			{
				this._panel = panel;
				this._activeContainersOnly = activeContainersOnly;
				this._currentPosition = -1;
				this._currentItem = global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.ContainerEnumerator.UnsetObjectMarker;
			}

			// Token: 0x060011A8 RID: 4520 RVA: 0x0003ECC8 File Offset: 0x0003CEC8
			public bool MoveNext()
			{
				int num;
				if (this._activeContainersOnly)
				{
					num = this._panel.CountOfActiveContainers;
				}
				else
				{
					num = this._panel.VisualChildrenCount;
				}
				while (this._currentPosition < num - 1)
				{
					this._currentPosition++;
					this._currentItem = this._panel.GetVisualChild(this._currentPosition);
					if (this._activeContainersOnly || (this._currentItem is global::System.Windows.Media.Visual && global::System.Windows.LogicalTreeHelper.GetParent(this._currentItem as global::System.Windows.Media.Visual) == this._panel))
					{
						return true;
					}
				}
				this._currentPosition = num;
				this._currentItem = global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.ContainerEnumerator.UnsetObjectMarker;
				return false;
			}

			// Token: 0x060011A9 RID: 4521 RVA: 0x0003ED6B File Offset: 0x0003CF6B
			public void Reset()
			{
				this._currentPosition = -1;
				this._currentItem = global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.ContainerEnumerator.UnsetObjectMarker;
			}

			// Token: 0x170003FB RID: 1019
			// (get) Token: 0x060011AA RID: 4522 RVA: 0x0003ED7F File Offset: 0x0003CF7F
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					if (this._currentItem != global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.ContainerEnumerator.UnsetObjectMarker)
					{
						return this._currentItem;
					}
					if (this._currentPosition == -1)
					{
						throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidOperationException_3"));
					}
					throw new global::System.InvalidOperationException(global::SR.GetString("LE_InvalidOperationException_4"));
				}
			}

			// Token: 0x0400095A RID: 2394
			private global::Infragistics.Windows.Virtualization.RecyclingItemsPanel _panel;

			// Token: 0x0400095B RID: 2395
			private bool _activeContainersOnly;

			// Token: 0x0400095C RID: 2396
			private int _currentPosition;

			// Token: 0x0400095D RID: 2397
			private object _currentItem;

			// Token: 0x0400095E RID: 2398
			private static object UnsetObjectMarker = new object();
		}

		// Token: 0x020001E8 RID: 488
		private class RecycleableContainerCollection : global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable
		{
			// Token: 0x060011AC RID: 4524 RVA: 0x0003EDC9 File Offset: 0x0003CFC9
			internal RecycleableContainerCollection(global::Infragistics.Windows.Virtualization.RecyclingItemsPanel panel)
			{
				this._panel = panel;
			}

			// Token: 0x060011AD RID: 4525 RVA: 0x0003EDD8 File Offset: 0x0003CFD8
			int global::System.Collections.IList.Add(object value)
			{
				if (this._panel._wasRecyclingOnLastGeneration)
				{
					throw new global::System.NotSupportedException(global::SR.GetString("LE_NotSupportedException_11"));
				}
				return this._panel.InternalChildren.Add(value as global::System.Windows.UIElement);
			}

			// Token: 0x060011AE RID: 4526 RVA: 0x0003EE0D File Offset: 0x0003D00D
			void global::System.Collections.IList.Clear()
			{
				if (this._panel._wasRecyclingOnLastGeneration)
				{
					throw new global::System.NotSupportedException(global::SR.GetString("LE_NotSupportedException_11"));
				}
				this._panel.InternalChildren.Clear();
			}

			// Token: 0x060011AF RID: 4527 RVA: 0x0003EE3C File Offset: 0x0003D03C
			bool global::System.Collections.IList.Contains(object value)
			{
				return ((global::System.Collections.IList)this).IndexOf(value) >= 0;
			}

			// Token: 0x060011B0 RID: 4528 RVA: 0x0003EE4C File Offset: 0x0003D04C
			int global::System.Collections.IList.IndexOf(object value)
			{
				if (!(value is global::System.Windows.UIElement))
				{
					return -1;
				}
				if (this._panel._wasRecyclingOnLastGeneration)
				{
					global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator recyclingItemContainerGenerator = this._panel.ActiveItemContainerGenerator as global::Infragistics.Windows.Virtualization.RecyclingItemContainerGenerator;
					if (recyclingItemContainerGenerator != null)
					{
						return recyclingItemContainerGenerator.GetIndexOfContainerInActiveList(value as global::System.Windows.DependencyObject, false);
					}
				}
				return this._panel.InternalChildren.IndexOf(value as global::System.Windows.UIElement);
			}

			// Token: 0x060011B1 RID: 4529 RVA: 0x0003EEA8 File Offset: 0x0003D0A8
			void global::System.Collections.IList.Insert(int index, object value)
			{
				if (this._panel._wasRecyclingOnLastGeneration)
				{
					throw new global::System.NotSupportedException(global::SR.GetString("LE_NotSupportedException_11"));
				}
				this._panel.InternalChildren.Insert(index, value as global::System.Windows.UIElement);
			}

			// Token: 0x170003FC RID: 1020
			// (get) Token: 0x060011B2 RID: 4530 RVA: 0x0003EEDE File Offset: 0x0003D0DE
			bool global::System.Collections.IList.IsFixedSize
			{
				get
				{
					return false;
				}
			}

			// Token: 0x170003FD RID: 1021
			// (get) Token: 0x060011B3 RID: 4531 RVA: 0x0003EEE1 File Offset: 0x0003D0E1
			bool global::System.Collections.IList.IsReadOnly
			{
				get
				{
					return this._panel._wasRecyclingOnLastGeneration;
				}
			}

			// Token: 0x060011B4 RID: 4532 RVA: 0x0003EEEE File Offset: 0x0003D0EE
			void global::System.Collections.IList.Remove(object value)
			{
				if (this._panel._wasRecyclingOnLastGeneration)
				{
					throw new global::System.NotSupportedException(global::SR.GetString("LE_NotSupportedException_11"));
				}
				this._panel.InternalChildren.Remove(value as global::System.Windows.UIElement);
			}

			// Token: 0x060011B5 RID: 4533 RVA: 0x0003EF23 File Offset: 0x0003D123
			void global::System.Collections.IList.RemoveAt(int index)
			{
				if (this._panel._wasRecyclingOnLastGeneration)
				{
					throw new global::System.NotSupportedException(global::SR.GetString("LE_NotSupportedException_11"));
				}
				this._panel.InternalChildren.RemoveAt(index);
			}

			// Token: 0x170003FE RID: 1022
			object global::System.Collections.IList.this[int index]
			{
				get
				{
					if (!this._panel._wasRecyclingOnLastGeneration)
					{
						return this._panel.InternalChildren[index];
					}
					if (index < 0 || index >= this._panel.CountOfActiveContainers)
					{
						throw new global::System.IndexOutOfRangeException();
					}
					return this._panel.GetChildElement(index);
				}
				set
				{
					if (this._panel._wasRecyclingOnLastGeneration)
					{
						throw new global::System.NotSupportedException(global::SR.GetString("LE_NotSupportedException_11"));
					}
					this._panel.InternalChildren[index] = (value as global::System.Windows.UIElement);
				}
			}

			// Token: 0x060011B8 RID: 4536 RVA: 0x0003EFDC File Offset: 0x0003D1DC
			void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
			{
				int count = ((global::System.Collections.ICollection)this).Count;
				int num = index;
				int i = 0;
				while (i < count)
				{
					if (num >= array.Length)
					{
						return;
					}
					array.SetValue(((global::System.Collections.IList)this)[i], num);
					i++;
					num++;
				}
			}

			// Token: 0x170003FF RID: 1023
			// (get) Token: 0x060011B9 RID: 4537 RVA: 0x0003F01A File Offset: 0x0003D21A
			int global::System.Collections.ICollection.Count
			{
				get
				{
					return this._panel.CountOfActiveContainers;
				}
			}

			// Token: 0x17000400 RID: 1024
			// (get) Token: 0x060011BA RID: 4538 RVA: 0x0003F027 File Offset: 0x0003D227
			bool global::System.Collections.ICollection.IsSynchronized
			{
				get
				{
					return !this._panel._wasRecyclingOnLastGeneration && this._panel.InternalChildren.IsSynchronized;
				}
			}

			// Token: 0x17000401 RID: 1025
			// (get) Token: 0x060011BB RID: 4539 RVA: 0x0003F048 File Offset: 0x0003D248
			object global::System.Collections.ICollection.SyncRoot
			{
				get
				{
					if (this._panel._wasRecyclingOnLastGeneration)
					{
						return this;
					}
					return this._panel.InternalChildren.SyncRoot;
				}
			}

			// Token: 0x060011BC RID: 4540 RVA: 0x0003F069 File Offset: 0x0003D269
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				if (this._panel._wasRecyclingOnLastGeneration)
				{
					return new global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.ContainerEnumerator(this._panel, true);
				}
				return this._panel.InternalChildren.GetEnumerator();
			}

			// Token: 0x0400095F RID: 2399
			private global::Infragistics.Windows.Virtualization.RecyclingItemsPanel _panel;
		}

		// Token: 0x020001E9 RID: 489
		private enum AbortAction
		{
			// Token: 0x04000961 RID: 2401
			NoAbort,
			// Token: 0x04000962 RID: 2402
			AbortWithCleanup,
			// Token: 0x04000963 RID: 2403
			AbortWithNoCleanup
		}
	}
}
