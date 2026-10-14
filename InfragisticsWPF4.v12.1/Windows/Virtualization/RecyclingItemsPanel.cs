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
	// Token: 0x020001B8 RID: 440
	public abstract class RecyclingItemsPanel : global::System.Windows.Controls.VirtualizingPanel
	{
		// Token: 0x06000FA7 RID: 4007 RVA: 0x000388C3 File Offset: 0x00036AC3
		protected RecyclingItemsPanel() : this(false)
		{
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x000388CC File Offset: 0x00036ACC
		protected RecyclingItemsPanel(bool removeDeactivatedContainersOnCleanup)
		{
			this._removeDeactivatedContainersOnCleanup = removeDeactivatedContainersOnCleanup;
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x000388E4 File Offset: 0x00036AE4
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

		// Token: 0x06000FAA RID: 4010 RVA: 0x00038990 File Offset: 0x00036B90
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

		// Token: 0x06000FAB RID: 4011 RVA: 0x000389DC File Offset: 0x00036BDC
		private void OnZOrderChanged(object sender, global::System.EventArgs e)
		{
			this._zOrderDirty = true;
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x000389E5 File Offset: 0x00036BE5
		protected new void AddInternalChild(global::System.Windows.UIElement child)
		{
			if (!this.PerformRecyclingAdd(child))
			{
				base.AddInternalChild(child);
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000FAD RID: 4013 RVA: 0x000389F7 File Offset: 0x00036BF7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		public new global::System.Windows.Controls.UIElementCollection Children
		{
			get
			{
				return base.Children;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x000389FF File Offset: 0x00036BFF
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

		// Token: 0x06000FAF RID: 4015 RVA: 0x00038A1C File Offset: 0x00036C1C
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

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00038A7A File Offset: 0x00036C7A
		protected new void InsertInternalChild(int index, global::System.Windows.UIElement child)
		{
			if (!this.PerformRecyclingAdd(child))
			{
				base.InsertInternalChild(index, child);
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x00038A8D File Offset: 0x00036C8D
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

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00038AA8 File Offset: 0x00036CA8
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

		// Token: 0x06000FB3 RID: 4019 RVA: 0x00038B14 File Offset: 0x00036D14
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

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00038B83 File Offset: 0x00036D83
		protected new void RemoveInternalChildRange(int index, int range)
		{
			if (this.ItemContainerGenerationModeResolved != global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
			{
				base.RemoveInternalChildRange(index, range);
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x00038B98 File Offset: 0x00036D98
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

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x00038BCC File Offset: 0x00036DCC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(false)]
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

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x00038C07 File Offset: 0x00036E07
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public global::Infragistics.Windows.Controls.ItemContainerGenerationMode ItemContainerGenerationModeResolved
		{
			get
			{
				return this._cachedItemContainerGenerationMode;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000FB8 RID: 4024 RVA: 0x00038C0F File Offset: 0x00036E0F
		protected virtual bool IsOkToCleanupUnusedGeneratedElements
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000FB9 RID: 4025
		protected abstract int TotalVisibleGeneratedItems { get; }

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x00038C12 File Offset: 0x00036E12
		protected virtual int MaximumUnusedGeneratedItemsToKeep
		{
			get
			{
				return 50;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x00038C18 File Offset: 0x00036E18
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

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x00038C99 File Offset: 0x00036E99
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

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06000FBD RID: 4029 RVA: 0x00038CC4 File Offset: 0x00036EC4
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

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x00038CFA File Offset: 0x00036EFA
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

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06000FBF RID: 4031 RVA: 0x00038D14 File Offset: 0x00036F14
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

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00038D54 File Offset: 0x00036F54
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

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00038DB8 File Offset: 0x00036FB8
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

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00038E08 File Offset: 0x00037008
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

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00038E5C File Offset: 0x0003705C
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

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00038E88 File Offset: 0x00037088
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

		// Token: 0x06000FC5 RID: 4037 RVA: 0x00038EB2 File Offset: 0x000370B2
		protected void BeginGeneration(global::Infragistics.Windows.Selection.ScrollDirection scrollDirection)
		{
			this.BeginGeneration(scrollDirection, null);
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00038EBC File Offset: 0x000370BC
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

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00038FF4 File Offset: 0x000371F4
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

		// Token: 0x06000FC8 RID: 4040 RVA: 0x000391D0 File Offset: 0x000373D0
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

		// Token: 0x06000FC9 RID: 4041 RVA: 0x000391FC File Offset: 0x000373FC
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

		// Token: 0x06000FCA RID: 4042 RVA: 0x00039228 File Offset: 0x00037428
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

		// Token: 0x06000FCB RID: 4043 RVA: 0x00039290 File Offset: 0x00037490
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

		// Token: 0x06000FCC RID: 4044 RVA: 0x00039310 File Offset: 0x00037510
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

		// Token: 0x06000FCD RID: 4045
		protected abstract bool GetCanCleanupItem(int itemIndex);

		// Token: 0x06000FCE RID: 4046 RVA: 0x00039414 File Offset: 0x00037614
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

		// Token: 0x06000FCF RID: 4047 RVA: 0x00039460 File Offset: 0x00037660
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

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00039497 File Offset: 0x00037697
		protected virtual void OnNewElementRealized(global::System.Windows.UIElement element, int index)
		{
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0003949C File Offset: 0x0003769C
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

		// Token: 0x06000FD2 RID: 4050 RVA: 0x000394DC File Offset: 0x000376DC
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

		// Token: 0x06000FD3 RID: 4051 RVA: 0x00039518 File Offset: 0x00037718
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

		// Token: 0x06000FD4 RID: 4052 RVA: 0x00039568 File Offset: 0x00037768
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

		// Token: 0x06000FD5 RID: 4053 RVA: 0x000395AF File Offset: 0x000377AF
		private object OnPostResetVerification(object args)
		{
			if (this._pendingPostResetVerification != null)
			{
				this.BeginGeneration(global::Infragistics.Windows.Selection.ScrollDirection.Increment);
				this.EndGeneration();
			}
			return null;
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x000395C7 File Offset: 0x000377C7
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

		// Token: 0x06000FD7 RID: 4055 RVA: 0x000395FC File Offset: 0x000377FC
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

		// Token: 0x06000FD8 RID: 4056 RVA: 0x0003965F File Offset: 0x0003785F
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

		// Token: 0x0400080C RID: 2060
		private const int MAX_TICKS_IN_CLEANUP = 200;

		// Token: 0x0400080D RID: 2061
		private const int MAXIMUM_UNUSED_GENERATED_ITEMS_TO_KEEP = 50;

		// Token: 0x0400080E RID: 2062
		private bool _hasBeenPreloaded;

		// Token: 0x0400080F RID: 2063
		private bool _recyclingEventsWired;

		// Token: 0x04000810 RID: 2064
		private global::System.Windows.Threading.DispatcherOperation _pendingAsyncCleanup;

		// Token: 0x04000811 RID: 2065
		private global::System.Windows.Threading.DispatcherOperation _pendingPostResetVerification;

		// Token: 0x04000812 RID: 2066
		private global::System.Windows.Threading.DispatcherTimer _cleanupDelayTimer;

		// Token: 0x04000813 RID: 2067
		private global::System.Windows.Controls.ItemsControl _itemsControl;

		// Token: 0x04000814 RID: 2068
		private bool _zOrderDirty;

		// Token: 0x04000815 RID: 2069
		private bool _wasRecyclingOnLastGeneration;

		// Token: 0x04000816 RID: 2070
		private global::Infragistics.Windows.Controls.ItemContainerGenerationMode _cachedItemContainerGenerationMode = global::Infragistics.Windows.Controls.ItemContainerGenerationMode.PreLoad;

		// Token: 0x04000817 RID: 2071
		private global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.RecycleableContainerCollection _children;

		// Token: 0x04000818 RID: 2072
		private bool _isInCleanup;

		// Token: 0x04000819 RID: 2073
		private bool _removeDeactivatedContainersOnCleanup;

		// Token: 0x0400081A RID: 2074
		private static global::System.Windows.DependencyProperty ItemContainerGenerationModeProperty = global::Infragistics.Windows.Virtualization.RecyclingItemsControl.ItemContainerGenerationModeProperty.AddOwner(typeof(global::Infragistics.Windows.Virtualization.RecyclingItemsPanel), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.OnItemContainerGenerationModeChanged)));

		// Token: 0x020001B9 RID: 441
		private class ContainerEnumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x06000FDA RID: 4058 RVA: 0x000396A8 File Offset: 0x000378A8
			internal ContainerEnumerator(global::Infragistics.Windows.Virtualization.RecyclingItemsPanel panel, bool activeContainersOnly)
			{
				this._panel = panel;
				this._activeContainersOnly = activeContainersOnly;
				this._currentPosition = -1;
				this._currentItem = global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.ContainerEnumerator.UnsetObjectMarker;
			}

			// Token: 0x06000FDB RID: 4059 RVA: 0x000396D0 File Offset: 0x000378D0
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

			// Token: 0x06000FDC RID: 4060 RVA: 0x00039773 File Offset: 0x00037973
			public void Reset()
			{
				this._currentPosition = -1;
				this._currentItem = global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.ContainerEnumerator.UnsetObjectMarker;
			}

			// Token: 0x1700038A RID: 906
			// (get) Token: 0x06000FDD RID: 4061 RVA: 0x00039787 File Offset: 0x00037987
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

			// Token: 0x0400081B RID: 2075
			private global::Infragistics.Windows.Virtualization.RecyclingItemsPanel _panel;

			// Token: 0x0400081C RID: 2076
			private bool _activeContainersOnly;

			// Token: 0x0400081D RID: 2077
			private int _currentPosition;

			// Token: 0x0400081E RID: 2078
			private object _currentItem;

			// Token: 0x0400081F RID: 2079
			private static object UnsetObjectMarker = new object();
		}

		// Token: 0x020001BA RID: 442
		private class RecycleableContainerCollection : global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable
		{
			// Token: 0x06000FDF RID: 4063 RVA: 0x000397D1 File Offset: 0x000379D1
			internal RecycleableContainerCollection(global::Infragistics.Windows.Virtualization.RecyclingItemsPanel panel)
			{
				this._panel = panel;
			}

			// Token: 0x06000FE0 RID: 4064 RVA: 0x000397E0 File Offset: 0x000379E0
			int global::System.Collections.IList.Add(object value)
			{
				if (this._panel._wasRecyclingOnLastGeneration)
				{
					throw new global::System.NotSupportedException(global::SR.GetString("LE_NotSupportedException_11"));
				}
				return this._panel.InternalChildren.Add(value as global::System.Windows.UIElement);
			}

			// Token: 0x06000FE1 RID: 4065 RVA: 0x00039815 File Offset: 0x00037A15
			void global::System.Collections.IList.Clear()
			{
				if (this._panel._wasRecyclingOnLastGeneration)
				{
					throw new global::System.NotSupportedException(global::SR.GetString("LE_NotSupportedException_11"));
				}
				this._panel.InternalChildren.Clear();
			}

			// Token: 0x06000FE2 RID: 4066 RVA: 0x00039844 File Offset: 0x00037A44
			bool global::System.Collections.IList.Contains(object value)
			{
				return ((global::System.Collections.IList)this).IndexOf(value) >= 0;
			}

			// Token: 0x06000FE3 RID: 4067 RVA: 0x00039854 File Offset: 0x00037A54
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

			// Token: 0x06000FE4 RID: 4068 RVA: 0x000398B0 File Offset: 0x00037AB0
			void global::System.Collections.IList.Insert(int index, object value)
			{
				if (this._panel._wasRecyclingOnLastGeneration)
				{
					throw new global::System.NotSupportedException(global::SR.GetString("LE_NotSupportedException_11"));
				}
				this._panel.InternalChildren.Insert(index, value as global::System.Windows.UIElement);
			}

			// Token: 0x1700038B RID: 907
			// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x000398E6 File Offset: 0x00037AE6
			bool global::System.Collections.IList.IsFixedSize
			{
				get
				{
					return false;
				}
			}

			// Token: 0x1700038C RID: 908
			// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x000398E9 File Offset: 0x00037AE9
			bool global::System.Collections.IList.IsReadOnly
			{
				get
				{
					return this._panel._wasRecyclingOnLastGeneration;
				}
			}

			// Token: 0x06000FE7 RID: 4071 RVA: 0x000398F6 File Offset: 0x00037AF6
			void global::System.Collections.IList.Remove(object value)
			{
				if (this._panel._wasRecyclingOnLastGeneration)
				{
					throw new global::System.NotSupportedException(global::SR.GetString("LE_NotSupportedException_11"));
				}
				this._panel.InternalChildren.Remove(value as global::System.Windows.UIElement);
			}

			// Token: 0x06000FE8 RID: 4072 RVA: 0x0003992B File Offset: 0x00037B2B
			void global::System.Collections.IList.RemoveAt(int index)
			{
				if (this._panel._wasRecyclingOnLastGeneration)
				{
					throw new global::System.NotSupportedException(global::SR.GetString("LE_NotSupportedException_11"));
				}
				this._panel.InternalChildren.RemoveAt(index);
			}

			// Token: 0x1700038D RID: 909
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

			// Token: 0x06000FEB RID: 4075 RVA: 0x000399E4 File Offset: 0x00037BE4
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

			// Token: 0x1700038E RID: 910
			// (get) Token: 0x06000FEC RID: 4076 RVA: 0x00039A22 File Offset: 0x00037C22
			int global::System.Collections.ICollection.Count
			{
				get
				{
					return this._panel.CountOfActiveContainers;
				}
			}

			// Token: 0x1700038F RID: 911
			// (get) Token: 0x06000FED RID: 4077 RVA: 0x00039A2F File Offset: 0x00037C2F
			bool global::System.Collections.ICollection.IsSynchronized
			{
				get
				{
					return !this._panel._wasRecyclingOnLastGeneration && this._panel.InternalChildren.IsSynchronized;
				}
			}

			// Token: 0x17000390 RID: 912
			// (get) Token: 0x06000FEE RID: 4078 RVA: 0x00039A50 File Offset: 0x00037C50
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

			// Token: 0x06000FEF RID: 4079 RVA: 0x00039A71 File Offset: 0x00037C71
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				if (this._panel._wasRecyclingOnLastGeneration)
				{
					return new global::Infragistics.Windows.Virtualization.RecyclingItemsPanel.ContainerEnumerator(this._panel, true);
				}
				return this._panel.InternalChildren.GetEnumerator();
			}

			// Token: 0x04000820 RID: 2080
			private global::Infragistics.Windows.Virtualization.RecyclingItemsPanel _panel;
		}

		// Token: 0x020001BB RID: 443
		private enum AbortAction
		{
			// Token: 0x04000822 RID: 2082
			NoAbort,
			// Token: 0x04000823 RID: 2083
			AbortWithCleanup,
			// Token: 0x04000824 RID: 2084
			AbortWithNoCleanup
		}
	}
}
