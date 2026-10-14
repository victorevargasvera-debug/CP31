using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.AutomationPeers;
using Infragistics.Windows.Automation.Peers.DockManager;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DockManager.Dragging;
using Infragistics.Windows.DockManager.Events;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x020000CF RID: 207
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplatePart(Name = "PART_FilesMenuItem", Type = typeof(global::System.Windows.Controls.MenuItem))]
	[global::System.Windows.TemplatePart(Name = "PART_HeaderArea", Type = typeof(global::System.Windows.FrameworkElement))]
	public class TabGroupPane : global::System.Windows.Controls.TabControl, global::Infragistics.Windows.DockManager.IContentPaneContainer, global::Infragistics.Windows.DockManager.IPaneContainer
	{
		// Token: 0x06000684 RID: 1668 RVA: 0x0001E5B4 File Offset: 0x0001C7B4
		static TabGroupPane()
		{
			global::Infragistics.Windows.DockManager.TabGroupPane.FilesMenuOpeningEvent = global::System.Windows.EventManager.RegisterRoutedEvent("FilesMenuOpening", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.FilesMenuOpeningEventArgs>), typeof(global::Infragistics.Windows.DockManager.TabGroupPane));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.TabGroupPane), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DockManager.TabGroupPane)));
			global::System.Windows.FrameworkElement.HorizontalAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.TabGroupPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentStretchBox));
			global::System.Windows.FrameworkElement.VerticalAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.TabGroupPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VerticalAlignmentStretchBox));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.TabGroupPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::Infragistics.Windows.Controls.TabItemPanel));
			global::System.Windows.Data.RelativeSource relativeSource = new global::System.Windows.Data.RelativeSource(global::System.Windows.Data.RelativeSourceMode.FindAncestor, typeof(global::Infragistics.Windows.DockManager.TabGroupPane), 1);
			frameworkElementFactory.SetBinding(global::System.Windows.Controls.TabControl.TabStripPlacementProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.Controls.TabControl.TabStripPlacementProperty, global::System.Windows.Data.BindingMode.OneWay, relativeSource));
			frameworkElementFactory.SetBinding(global::Infragistics.Windows.Controls.TabItemPanel.TabLayoutStyleProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.TabItemPanel.TabLayoutStyleProperty, global::System.Windows.Data.BindingMode.OneWay, relativeSource));
			frameworkElementFactory.SetBinding(global::Infragistics.Windows.Controls.TabItemPanel.MinimumTabExtentProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Controls.TabItemPanel.MinimumTabExtentProperty, global::System.Windows.Data.BindingMode.OneWay, relativeSource));
			frameworkElementFactory.SetValue(global::System.Windows.Controls.Panel.IsItemsHostProperty, global::Infragistics.KnownBoxes.TrueBox);
			global::System.Windows.Controls.ItemsPanelTemplate itemsPanelTemplate = new global::System.Windows.Controls.ItemsPanelTemplate(frameworkElementFactory);
			itemsPanelTemplate.Seal();
			global::System.Windows.Controls.ItemsControl.ItemsPanelProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.TabGroupPane), new global::System.Windows.FrameworkPropertyMetadata(itemsPanelTemplate));
			global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.TabGroupPane), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.TabGroupPane.OnPaneLocationChanged)));
			global::System.Windows.Controls.Primitives.Selector.SelectedIndexProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.TabGroupPane), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.TabGroupPane.OnSelectedIndexChanged)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.TabGroupPane), global::System.Windows.Controls.MenuItem.SubmenuOpenedEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.DockManager.TabGroupPane.OnSubmenuOpened));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.TabGroupPane), global::System.Windows.FrameworkElement.RequestBringIntoViewEvent, new global::System.Windows.RequestBringIntoViewEventHandler(global::Infragistics.Windows.DockManager.TabGroupPane.OnRequestBringIntoView));
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.TabGroupPane), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.TabGroupPane.OnVisibilityChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.TabGroupPane.CoerceVisibility)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.TabGroupPane), global::Infragistics.Windows.DockManager.DockManagerUtilities.VisibilityChangedEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.DockManager.TabGroupPane.OnChildVisibilityChanged));
			global::System.Windows.Controls.ItemsControl.ItemsSourceProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.TabGroupPane), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.TabGroupPane.CoerceItemsSource)));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.DockManager.TabGroupPane), new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.DockManager.TabGroupPane.CloseSelectedItemCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.DockManager.TabGroupPane.OnExecuteCommand), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.DockManager.TabGroupPane.OnCanExecuteCommand)));
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0001E904 File Offset: 0x0001CB04
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size arrangeBounds)
		{
			global::Infragistics.Windows.DockManager.DockManagerUtilities.InitializePaneFloatingSize(this, base.Items, arrangeBounds);
			return base.ArrangeOverride(arrangeBounds);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0001E91A File Offset: 0x0001CB1A
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DockManager.TabGroupPaneAutomationPeer(this);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0001E924 File Offset: 0x0001CB24
		protected override void ClearContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			global::Infragistics.Windows.DockManager.PaneTabItem target = element as global::Infragistics.Windows.DockManager.PaneTabItem;
			global::System.Windows.Data.BindingOperations.ClearBinding(target, global::System.Windows.Controls.HeaderedContentControl.HeaderProperty);
			global::System.Windows.Data.BindingOperations.ClearBinding(target, global::System.Windows.Controls.HeaderedContentControl.HeaderTemplateProperty);
			global::System.Windows.Data.BindingOperations.ClearBinding(target, global::System.Windows.Controls.HeaderedContentControl.HeaderTemplateSelectorProperty);
			base.ClearContainerForItemOverride(element, item);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0001E961 File Offset: 0x0001CB61
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			return new global::Infragistics.Windows.DockManager.PaneTabItem();
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0001E968 File Offset: 0x0001CB68
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			return item is global::Infragistics.Windows.DockManager.PaneTabItem;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0001E974 File Offset: 0x0001CB74
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this._filesMenuItem != null && this._hiddenMenuItem != null)
			{
				this._filesMenuItem.Items.Remove(this._hiddenMenuItem);
			}
			this._filesMenuItem = (base.GetTemplateChild("PART_FilesMenuItem") as global::System.Windows.Controls.MenuItem);
			if (this._filesMenuItem != null)
			{
				this._filesMenuItem.Items.Add(this.HiddenMenuItem);
			}
			this._headerArea = (base.GetTemplateChild("PART_HeaderArea") as global::System.Windows.FrameworkElement);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0001E9F8 File Offset: 0x0001CBF8
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == global::System.Windows.Input.Key.Down && global::System.Windows.Input.Keyboard.Modifiers == (global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control) && this._filesMenuItem != null)
			{
				this._filesMenuItem.IsSubmenuOpen = true;
				this._filesMenuItem.Focus();
				e.Handled = true;
			}
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0001EA33 File Offset: 0x0001CC33
		protected override void OnInitialized(global::System.EventArgs e)
		{
			if (base.ItemContainerGenerator != null)
			{
				base.ItemContainerGenerator.StatusChanged += this.OnGeneratorStatusChanged;
			}
			base.OnInitialized(e);
			base.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
			global::Infragistics.Windows.DockManager.DockManagerUtilities.VerifyOwningToolWindow(this);
			this.VerifyTabAreaVisibility();
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0001EA74 File Offset: 0x0001CC74
		protected override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
				using (global::System.Collections.IEnumerator enumerator = e.NewItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object item = enumerator.Current;
						this.VerifyItem(item);
					}
					goto IL_60;
				}
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
				goto IL_60;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				break;
			default:
				goto IL_60;
			}
			this.VerifyAllItems();
			IL_60:
			this.FixupFilesMenu(e);
			if (!this._isMovingItem)
			{
				this.ClearItemsSnapshot();
			}
			global::Infragistics.Windows.DockManager.DockManagerUtilities.InitializeCurrentContainer(base.Items, this, e);
			base.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
			global::Infragistics.Windows.DockManager.DockManagerUtilities.VerifyOwningToolWindow(this);
			this.VerifyTabAreaVisibility();
			this.VerifySelectedItem();
			base.OnItemsChanged(e);
			this.VerifySelectedContent();
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0001EB40 File Offset: 0x0001CD40
		protected override void OnSelectionChanged(global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			if (this._initializingSelection)
			{
				return;
			}
			if (this.EnsureSelectedDocumentIsInViewImpl(false))
			{
				return;
			}
			global::Infragistics.Windows.DockManager.DockManagerUtilities.VerifyOwningToolWindow(this);
			base.OnSelectionChanged(e);
			this.VerifyActivePanes();
			this.RefreshSelectedTabPeerChildren();
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0001EB6E File Offset: 0x0001CD6E
		protected override void OnVisualParentChanged(global::System.Windows.DependencyObject oldParent)
		{
			this.VerifyAllItems();
			base.OnVisualParentChanged(oldParent);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0001EB80 File Offset: 0x0001CD80
		protected override void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			this.VerifyItem(item);
			if (!(item is global::Infragistics.Windows.DockManager.ContentPanePlaceholder))
			{
				global::Infragistics.Windows.DockManager.PaneTabItem paneTabItem = element as global::Infragistics.Windows.DockManager.PaneTabItem;
				global::Infragistics.Windows.DockManager.ContentPane source = item as global::Infragistics.Windows.DockManager.ContentPane;
				paneTabItem.SetBinding(global::System.Windows.Controls.HeaderedContentControl.HeaderProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.ContentPane.TabHeaderProperty, global::System.Windows.Data.BindingMode.OneWay, source));
				paneTabItem.SetBinding(global::System.Windows.Controls.HeaderedContentControl.HeaderTemplateProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.ContentPane.TabHeaderTemplateProperty, global::System.Windows.Data.BindingMode.OneWay, source));
				paneTabItem.SetBinding(global::System.Windows.Controls.HeaderedContentControl.HeaderTemplateSelectorProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.ContentPane.TabHeaderTemplateSelectorProperty, global::System.Windows.Data.BindingMode.OneWay, source));
			}
			global::System.Windows.Data.BindingOperations.SetBinding(element, global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.UIElement.VisibilityProperty, global::System.Windows.Data.BindingMode.OneWay, item));
			base.PrepareContainerForItemOverride(element, item);
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x0001EC12 File Offset: 0x0001CE12
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsTabItemAreaVisible
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.TabGroupPane.IsTabItemAreaVisibleProperty);
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x0001EC24 File Offset: 0x0001CE24
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x0001EC2C File Offset: 0x0001CE2C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.Browsable(false)]
		public new global::System.Collections.IEnumerable ItemsSource
		{
			get
			{
				return base.ItemsSource;
			}
			set
			{
				base.ItemsSource = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x0001EC38 File Offset: 0x0001CE38
		internal bool ContainsActivePane
		{
			get
			{
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
				return dockManager != null && this.ContainsPane(dockManager.ActivePaneManager.GetLastActivePane());
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000695 RID: 1685 RVA: 0x0001EC64 File Offset: 0x0001CE64
		internal bool ContainsActiveDocument
		{
			get
			{
				if (global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this) != global::Infragistics.Windows.DockManager.PaneLocation.Document)
				{
					return false;
				}
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
				return dockManager != null && this.ContainsPane(dockManager.ActivePaneManager.GetActiveDocument());
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x0001EC99 File Offset: 0x0001CE99
		internal global::System.Windows.FrameworkElement HeaderArea
		{
			get
			{
				return this._headerArea;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x0001ECA1 File Offset: 0x0001CEA1
		internal bool IsMovingItem
		{
			get
			{
				return this._isMovingItem;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x0001ECA9 File Offset: 0x0001CEA9
		private bool CanVerifyItems
		{
			get
			{
				return !global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this) || global::System.Windows.Media.VisualTreeHelper.GetParent(this) != null;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x0001ECC1 File Offset: 0x0001CEC1
		private global::System.Collections.IList CurrentItemsCollection
		{
			get
			{
				this.VerifyItemsSnapshot();
				return this._itemsSnapshot ?? base.Items;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x0001ECD9 File Offset: 0x0001CED9
		private global::System.Windows.Controls.MenuItem HiddenMenuItem
		{
			get
			{
				if (this._hiddenMenuItem == null)
				{
					this._hiddenMenuItem = new global::System.Windows.Controls.MenuItem();
					this._hiddenMenuItem.Visibility = global::System.Windows.Visibility.Collapsed;
				}
				return this._hiddenMenuItem;
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0001ED00 File Offset: 0x0001CF00
		private bool CanRepositionSelectedItem(bool checkClip)
		{
			if (!base.IsInitialized)
			{
				return false;
			}
			if (base.SelectedIndex < 0)
			{
				return false;
			}
			if (global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this) != global::Infragistics.Windows.DockManager.PaneLocation.Document)
			{
				return false;
			}
			global::System.Windows.Controls.TabItem selectedTabItem = this.GetSelectedTabItem();
			if (selectedTabItem != null)
			{
				bool flag = true;
				if (checkClip)
				{
					global::System.Windows.Media.Geometry clip = global::System.Windows.Media.VisualTreeHelper.GetClip(selectedTabItem);
					if (clip == global::System.Windows.Media.Geometry.Empty)
					{
						flag = false;
					}
					else if (clip is global::System.Windows.Media.RectangleGeometry)
					{
						global::System.Windows.Rect rect = ((global::System.Windows.Media.RectangleGeometry)clip).Rect;
						if (rect.Height <= 0.0 || rect.Width <= 0.0)
						{
							flag = false;
						}
					}
				}
				if (flag)
				{
					return false;
				}
			}
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager == null)
			{
				return false;
			}
			switch (dockManager.DragManager.DragState)
			{
			case global::Infragistics.Windows.DockManager.Dragging.DragState.Dragging:
			case global::Infragistics.Windows.DockManager.Dragging.DragState.ProcessingDrop:
				return false;
			default:
			{
				bool result = false;
				int i = 0;
				while (i < base.Items.Count)
				{
					global::System.Windows.DependencyObject dependencyObject = base.ItemContainerGenerator.ContainerFromIndex(i);
					if (dependencyObject != null)
					{
						if (!(global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject) is global::Infragistics.Windows.DockManager.DocumentTabPanel))
						{
							return false;
						}
						result = true;
						break;
					}
					else
					{
						i++;
					}
				}
				return result;
			}
			}
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0001EE0B File Offset: 0x0001D00B
		private void ClearItemsSnapshot()
		{
			this._itemsSnapshot = null;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0001EE14 File Offset: 0x0001D014
		private void ClearSelectionProperties()
		{
			if (base.Items.IsEmpty == base.HasItems)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::System.Threading.SendOrPostCallback(this.VerifySelectedItem), this);
				return;
			}
			base.SelectedItem = null;
			base.SelectedValue = null;
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0001EE54 File Offset: 0x0001D054
		private static object CoerceItemsSource(global::System.Windows.DependencyObject d, object newValue)
		{
			if (newValue != null && global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(d) && (newValue is string || newValue is global::System.Collections.Generic.IList<string>))
			{
				return new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane>
				{
					new global::Infragistics.Windows.DockManager.ContentPane
					{
						Header = "ContentPane"
					},
					new global::Infragistics.Windows.DockManager.ContentPane
					{
						Header = "ContentPane"
					}
				};
			}
			return newValue;
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0001EEB5 File Offset: 0x0001D0B5
		private static object CoerceVisibility(global::System.Windows.DependencyObject d, object newValue)
		{
			return global::Infragistics.Windows.DockManager.DockManagerUtilities.ProcessCoerceVisibility(d, newValue);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0001EEC0 File Offset: 0x0001D0C0
		private bool ContainsPane(global::Infragistics.Windows.DockManager.ContentPane contentPane)
		{
			if (contentPane == null)
			{
				return false;
			}
			global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = global::System.Windows.LogicalTreeHelper.GetParent(contentPane) as global::Infragistics.Windows.DockManager.TabGroupPane;
			return tabGroupPane == this && base.Items.IndexOf(contentPane) >= 0;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0001EEF6 File Offset: 0x0001D0F6
		internal void EnsureSelectedDocumentIsInView()
		{
			this.EnsureSelectedDocumentIsInViewImpl(true);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0001EF00 File Offset: 0x0001D100
		private bool EnsureSelectedDocumentIsInViewImpl(bool checkClip)
		{
			if (this.CanRepositionSelectedItem(checkClip))
			{
				try
				{
					this._initializingSelection = true;
					this.MoveItemToFront(base.SelectedIndex);
				}
				finally
				{
					this._initializingSelection = false;
				}
				base.SelectedIndex = 0;
				return true;
			}
			return false;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0001EF50 File Offset: 0x0001D150
		private void FixupFilesMenu(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this._filesMenuItem != null && !this._filesMenuItem.IsSubmenuOpen)
			{
				switch (e.Action)
				{
				case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
				case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
					this._filesMenuItem.Items.Clear();
					this._filesMenuItem.Items.Add(this.HiddenMenuItem);
					break;
				case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0001EFBC File Offset: 0x0001D1BC
		private int GetSelectableTabIndex(int startingIndex)
		{
			int count = base.Items.Count;
			startingIndex = global::System.Math.Max(global::System.Math.Min(startingIndex, count - 1), 0);
			int i = startingIndex;
			int count2 = base.Items.Count;
			while (i < count2)
			{
				global::System.Windows.FrameworkElement frameworkElement = base.Items[i] as global::System.Windows.FrameworkElement;
				if (frameworkElement != null && frameworkElement.Visibility == global::System.Windows.Visibility.Visible)
				{
					return i;
				}
				i++;
			}
			for (int j = startingIndex - 1; j >= 0; j--)
			{
				global::System.Windows.FrameworkElement frameworkElement2 = base.Items[j] as global::System.Windows.FrameworkElement;
				if (frameworkElement2 != null && frameworkElement2.Visibility == global::System.Windows.Visibility.Visible)
				{
					return j;
				}
			}
			return -1;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0001F054 File Offset: 0x0001D254
		private global::System.Windows.Controls.TabItem GetSelectedTabItem()
		{
			global::System.Windows.Controls.TabItem tabItem = base.SelectedItem as global::System.Windows.Controls.TabItem;
			if (tabItem == null && base.SelectedIndex >= 0)
			{
				tabItem = (base.ItemContainerGenerator.ContainerFromIndex(base.SelectedIndex) as global::System.Windows.Controls.TabItem);
			}
			return tabItem;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0001F094 File Offset: 0x0001D294
		private bool InitializeSelectedIndex()
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager == null || dockManager.IsLoadingLayout)
			{
				return false;
			}
			int num = -1;
			global::System.DateTime dateTime = global::System.DateTime.MinValue;
			int i = 0;
			int count = base.Items.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DockManager.ContentPane contentPane = base.Items[i] as global::Infragistics.Windows.DockManager.ContentPane;
				if (contentPane != null && contentPane.Visibility != global::System.Windows.Visibility.Collapsed)
				{
					global::System.DateTime lastActivatedTime = contentPane.LastActivatedTime;
					if (num < 0 || !(dateTime > lastActivatedTime))
					{
						num = i;
						dateTime = lastActivatedTime;
					}
				}
				i++;
			}
			if (num < 0 || dateTime == global::System.DateTime.MinValue)
			{
				int num2 = base.SelectedIndex;
				if (num2 < 0)
				{
					num2 = this._previousSelectedIndex;
				}
				num = this.GetSelectableTabIndex(num2);
				if (num < 0)
				{
					return false;
				}
			}
			base.SelectedIndex = num;
			return true;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0001F154 File Offset: 0x0001D354
		private void MoveItemToFront(int index)
		{
			if (index == 0)
			{
				return;
			}
			bool isMovingItem = this._isMovingItem;
			this._isMovingItem = true;
			this.VerifyItemsSnapshot();
			try
			{
				object insertItem = base.Items[index];
				base.Items.RemoveAt(index);
				base.Items.Insert(0, insertItem);
			}
			finally
			{
				this._isMovingItem = isMovingItem;
			}
			base.UpdateLayout();
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0001F1C0 File Offset: 0x0001D3C0
		private static void OnChildVisibilityChanged(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = sender as global::Infragistics.Windows.DockManager.TabGroupPane;
			if (sender != e.OriginalSource)
			{
				global::Infragistics.Windows.DockManager.ContentPane contentPane = e.OriginalSource as global::Infragistics.Windows.DockManager.ContentPane;
				if (contentPane != null && contentPane == tabGroupPane.SelectedItem)
				{
					int count = tabGroupPane.Items.Count;
					global::System.DateTime t = global::System.DateTime.MinValue;
					int num = -1;
					for (int i = 0; i < count; i++)
					{
						global::Infragistics.Windows.DockManager.ContentPane contentPane2 = tabGroupPane.Items[i] as global::Infragistics.Windows.DockManager.ContentPane;
						if (contentPane2 != null && contentPane2.Visibility == global::System.Windows.Visibility.Visible && contentPane2.IsEnabled && contentPane2.LastActivatedTime > t)
						{
							t = contentPane2.LastActivatedTime;
							num = i;
						}
					}
					if (num < 0 && count > 0)
					{
						int num2 = global::System.Math.Max(0, global::System.Math.Min(tabGroupPane.SelectedIndex, count - 1));
						int j = num2;
						int num3 = num2 + count - 1;
						while (j < num3)
						{
							int num4 = j % count;
							global::Infragistics.Windows.DockManager.ContentPane contentPane3 = tabGroupPane.Items[num4] as global::Infragistics.Windows.DockManager.ContentPane;
							if (contentPane3 != null && contentPane3.Visibility == global::System.Windows.Visibility.Visible && contentPane3.IsEnabled)
							{
								num = num4;
								break;
							}
							j++;
						}
					}
					if (num >= 0)
					{
						tabGroupPane.SelectedIndex = num;
					}
				}
				tabGroupPane.VerifyTabAreaVisibility();
				tabGroupPane.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
				e.Handled = true;
			}
			global::Infragistics.Windows.DockManager.DockManagerUtilities.VerifyOwningToolWindow(tabGroupPane);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0001F304 File Offset: 0x0001D504
		private static void OnCanExecuteCommand(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = (global::Infragistics.Windows.DockManager.TabGroupPane)sender;
			if (e.Command == global::Infragistics.Windows.DockManager.TabGroupPane.CloseSelectedItemCommand)
			{
				global::Infragistics.Windows.DockManager.ContentPane contentPane = tabGroupPane.SelectedItem as global::Infragistics.Windows.DockManager.ContentPane;
				e.CanExecute = (contentPane != null && contentPane.AllowClose);
				e.Handled = true;
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0001F34C File Offset: 0x0001D54C
		private static void OnExecuteCommand(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = (global::Infragistics.Windows.DockManager.TabGroupPane)sender;
			if (e.Command == global::Infragistics.Windows.DockManager.TabGroupPane.CloseSelectedItemCommand)
			{
				global::Infragistics.Windows.DockManager.ContentPane contentPane = tabGroupPane.SelectedItem as global::Infragistics.Windows.DockManager.ContentPane;
				if (contentPane != null)
				{
					e.Handled = contentPane.ExecuteCommand(global::Infragistics.Windows.DockManager.ContentPaneCommands.Close);
				}
			}
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0001F38D File Offset: 0x0001D58D
		private void OnGeneratorStatusChanged(object sender, global::System.EventArgs e)
		{
			if (base.ItemContainerGenerator.Status == global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
			{
				this.VerifySelectedItem();
			}
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0001F3A4 File Offset: 0x0001D5A4
		private void OnLayoutUpdated(object sender, global::System.EventArgs e)
		{
			base.LayoutUpdated -= this.OnLayoutUpdated;
			if (this._isRefreshSelectedTabPeerPending)
			{
				this._isRefreshSelectedTabPeerPending = false;
				global::System.Windows.Controls.TabItem selectedTabItem = this.GetSelectedTabItem();
				if (selectedTabItem != null)
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(selectedTabItem);
					if (automationPeer != null && automationPeer.EventsSource != null)
					{
						automationPeer.EventsSource.ResetChildrenCache();
					}
				}
			}
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0001F3F9 File Offset: 0x0001D5F9
		private static void OnPaneLocationChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.DockManager.TabGroupPane)d).VerifyTabAreaVisibility();
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0001F408 File Offset: 0x0001D608
		private static void OnRequestBringIntoView(object sender, global::System.Windows.RequestBringIntoViewEventArgs e)
		{
			global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = sender as global::Infragistics.Windows.DockManager.TabGroupPane;
			tabGroupPane.OnRequestBringIntoView(e);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0001F424 File Offset: 0x0001D624
		private void OnRequestBringIntoView(global::System.Windows.RequestBringIntoViewEventArgs e)
		{
			global::System.Windows.DependencyObject tabControlChild = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetTabControlChild(e.TargetObject, this);
			if (tabControlChild != null && !(tabControlChild is global::System.Windows.Controls.TabItem))
			{
				int num = base.Items.IndexOf(tabControlChild);
				if (num >= 0)
				{
					global::System.Windows.FrameworkElement frameworkElement = tabControlChild as global::System.Windows.FrameworkElement;
					if (frameworkElement != null && frameworkElement.Visibility != global::System.Windows.Visibility.Visible)
					{
						return;
					}
					global::System.Windows.Controls.TabItem tabItem = base.ItemContainerGenerator.ContainerFromIndex(num) as global::System.Windows.Controls.TabItem;
					global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
					if (dockManager != null && dockManager.IsActivatingPane && (tabItem == null || !tabItem.IsKeyboardFocusWithin))
					{
						return;
					}
					if (tabItem == null && base.ItemContainerGenerator.Status == global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated && global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this) == global::Infragistics.Windows.DockManager.PaneLocation.Document)
					{
						if (!base.IsVisible)
						{
							base.BringIntoView();
							e.Handled = true;
						}
						base.UpdateLayout();
						if (!(base.ItemContainerGenerator.ContainerFromIndex(num) is global::System.Windows.Controls.TabItem))
						{
							this.MoveItemToFront(num);
							num = 0;
							e.Handled = true;
						}
					}
					base.SelectedIndex = num;
				}
			}
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0001F50C File Offset: 0x0001D70C
		private static void OnSelectedIndexChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = d as global::Infragistics.Windows.DockManager.TabGroupPane;
			int num = (int)e.NewValue;
			if (num >= 0)
			{
				tabGroupPane._previousSelectedIndex = num;
			}
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0001F538 File Offset: 0x0001D738
		private static void OnSubmenuOpened(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = sender as global::Infragistics.Windows.DockManager.TabGroupPane;
			if (tabGroupPane != null && tabGroupPane._filesMenuItem == e.OriginalSource)
			{
				global::System.Windows.Controls.ItemCollection items = tabGroupPane._filesMenuItem.Items;
				items.Clear();
				items.Add(tabGroupPane.HiddenMenuItem);
				object[] array = new object[tabGroupPane.Items.Count];
				tabGroupPane.Items.CopyTo(array, 0);
				global::Infragistics.CoreUtilities.SortMergeGeneric<object>(array, global::Infragistics.Windows.DockManager.TabGroupPane.TabHeaderComparer.Instance);
				foreach (object obj in array)
				{
					global::Infragistics.Windows.DockManager.ContentPane contentPane = obj as global::Infragistics.Windows.DockManager.ContentPane;
					if (contentPane != null && contentPane.Visibility != global::System.Windows.Visibility.Collapsed)
					{
						global::System.Windows.Controls.MenuItem menuItem = new global::System.Windows.Controls.MenuItem();
						menuItem.Tag = contentPane;
						menuItem.Header = contentPane.TabHeader;
						menuItem.HeaderTemplate = contentPane.TabHeaderTemplate;
						menuItem.HeaderTemplateSelector = contentPane.TabHeaderTemplateSelector;
						menuItem.Command = global::Infragistics.Windows.DockManager.ContentPaneCommands.ActivatePane;
						menuItem.CommandTarget = contentPane;
						menuItem.CommandParameter = contentPane;
						menuItem.SetValue(global::System.Windows.FrameworkElement.DefaultStyleKeyProperty, global::Infragistics.Windows.DockManager.XamDockManager.MenuItemStyleKey);
						if (contentPane.HasImage)
						{
							menuItem.Icon = new global::Infragistics.Windows.Controls.AutoDisabledImage
							{
								Source = contentPane.Image
							};
						}
						items.Add(menuItem);
					}
				}
				tabGroupPane.RaiseFilesMenuOpening(new global::Infragistics.Windows.DockManager.Events.FilesMenuOpeningEventArgs(items));
			}
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0001F690 File Offset: 0x0001D890
		private static void OnVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = (global::Infragistics.Windows.DockManager.TabGroupPane)d;
			global::Infragistics.Windows.DockManager.DockManagerUtilities.RaiseVisibilityChanged(d, e);
			tabGroupPane.VerifyTabAreaVisibility();
			tabGroupPane.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DockManager.DockManagerUtilities.MethodInvoker(tabGroupPane.VerifySelectedItem));
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0001F6CB File Offset: 0x0001D8CB
		private void RefreshSelectedTabPeerChildren()
		{
			if (this._isRefreshSelectedTabPeerPending)
			{
				return;
			}
			this._isRefreshSelectedTabPeerPending = true;
			base.LayoutUpdated -= this.OnLayoutUpdated;
			base.LayoutUpdated += this.OnLayoutUpdated;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0001F704 File Offset: 0x0001D904
		private void VerifyActivePanes()
		{
			global::Infragistics.Windows.DockManager.ContentPane contentPane = base.SelectedItem as global::Infragistics.Windows.DockManager.ContentPane;
			if (contentPane == null || contentPane.IsActivating || contentPane.IsKeyboardFocusWithinEx)
			{
				return;
			}
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null && dockManager.IsClosingPanes)
			{
				return;
			}
			if (dockManager == null)
			{
				return;
			}
			bool containsActivePane = this.ContainsActivePane;
			if (containsActivePane && dockManager.ActivePane != null)
			{
				contentPane.ActivateInternal(true, true);
				return;
			}
			if (this.ContainsActiveDocument)
			{
				dockManager.ActivePaneManager.SetActiveDocument(contentPane);
				return;
			}
			if (containsActivePane)
			{
				dockManager.ActivePaneManager.MoveToFront(contentPane);
			}
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0001F788 File Offset: 0x0001D988
		private void VerifyAllItems()
		{
			if (!this.CanVerifyItems)
			{
				return;
			}
			foreach (object item in ((global::System.Collections.IEnumerable)base.Items))
			{
				this.VerifyItem(item);
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0001F7E8 File Offset: 0x0001D9E8
		private void VerifyItem(object item)
		{
			if (item is global::Infragistics.Windows.DockManager.ContentPanePlaceholder || item is global::Infragistics.Windows.DockManager.ContentPane)
			{
				return;
			}
			if (!this.CanVerifyItems)
			{
				return;
			}
			throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_InvalidTabGroupPaneChild"));
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0001F814 File Offset: 0x0001DA14
		private void VerifyItemsSnapshot()
		{
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null && dockManager.ActivePaneManager.IsInNavigationMode)
			{
				int navigationModeVersion = dockManager.ActivePaneManager.NavigationModeVersion;
				if (navigationModeVersion != this._navigationModeVersion || this._itemsSnapshot == null)
				{
					this._navigationModeVersion = navigationModeVersion;
					object[] array = new object[base.Items.Count];
					base.Items.CopyTo(array, 0);
					this._itemsSnapshot = array;
					return;
				}
			}
			else
			{
				this.ClearItemsSnapshot();
			}
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0001F888 File Offset: 0x0001DA88
		[global::System.Diagnostics.Conditional("DEBUG")]
		private void VerifyNotUsingSnapshot()
		{
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0001F88A File Offset: 0x0001DA8A
		private void VerifySelectedItem()
		{
			this.VerifySelectedItem(null);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0001F894 File Offset: 0x0001DA94
		private void VerifySelectedItem(object param)
		{
			if (base.ItemContainerGenerator.Status != global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
			{
				return;
			}
			int selectedIndex = base.SelectedIndex;
			global::System.Windows.Controls.TabItem tabItem = (selectedIndex >= 0) ? (base.ItemContainerGenerator.ContainerFromIndex(selectedIndex) as global::System.Windows.Controls.TabItem) : null;
			if (tabItem == null)
			{
				if (selectedIndex >= 0 && selectedIndex < base.Items.Count)
				{
					global::System.Windows.FrameworkElement frameworkElement = base.Items[selectedIndex] as global::System.Windows.FrameworkElement;
					if (frameworkElement != null && frameworkElement.Visibility == global::System.Windows.Visibility.Visible)
					{
						return;
					}
				}
				if (!this.InitializeSelectedIndex() && param == null)
				{
					this.ClearSelectionProperties();
					return;
				}
			}
			else if (tabItem.Visibility == global::System.Windows.Visibility.Collapsed && !this.InitializeSelectedIndex() && param == null)
			{
				this.ClearSelectionProperties();
			}
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0001F930 File Offset: 0x0001DB30
		private void VerifySelectedContent()
		{
			object selectedItem = base.SelectedItem;
			global::System.Windows.Controls.TabItem tabItem = selectedItem as global::System.Windows.Controls.TabItem;
			if (tabItem == null && selectedItem != null)
			{
				tabItem = (base.ItemContainerGenerator.ContainerFromItem(selectedItem) as global::System.Windows.Controls.TabItem);
			}
			if (tabItem != null && base.SelectedContent != tabItem.Content)
			{
				base.OnApplyTemplate();
			}
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0001F97C File Offset: 0x0001DB7C
		private void VerifyTabAreaVisibility()
		{
			int num = 0;
			int i = 0;
			int count = base.Items.Count;
			while (i < count)
			{
				global::System.Windows.UIElement uielement = base.Items[i] as global::System.Windows.UIElement;
				if (uielement != null && uielement.Visibility == global::System.Windows.Visibility.Visible)
				{
					num++;
					if (num > 1)
					{
						break;
					}
				}
				i++;
			}
			bool flag = false;
			if (num == 1)
			{
				switch (global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this))
				{
				case global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft:
				case global::Infragistics.Windows.DockManager.PaneLocation.DockedRight:
				case global::Infragistics.Windows.DockManager.PaneLocation.DockedTop:
				case global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom:
				case global::Infragistics.Windows.DockManager.PaneLocation.Floating:
				case global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly:
					flag = true;
					break;
				}
			}
			base.SetValue(global::Infragistics.Windows.DockManager.TabGroupPane.IsTabItemAreaVisiblePropertyKey, flag ? global::Infragistics.KnownBoxes.FalseBox : global::System.Windows.DependencyProperty.UnsetValue);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0001FA18 File Offset: 0x0001DC18
		protected virtual void OnFilesMenuOpening(global::Infragistics.Windows.DockManager.Events.FilesMenuOpeningEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0001FA21 File Offset: 0x0001DC21
		internal void RaiseFilesMenuOpening(global::Infragistics.Windows.DockManager.Events.FilesMenuOpeningEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DockManager.TabGroupPane.FilesMenuOpeningEvent;
			args.Source = this;
			this.OnFilesMenuOpening(args);
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060006BF RID: 1727 RVA: 0x0001FA3C File Offset: 0x0001DC3C
		// (remove) Token: 0x060006C0 RID: 1728 RVA: 0x0001FA4A File Offset: 0x0001DC4A
		public event global::System.EventHandler<global::Infragistics.Windows.DockManager.Events.FilesMenuOpeningEventArgs> FilesMenuOpening
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DockManager.TabGroupPane.FilesMenuOpeningEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DockManager.TabGroupPane.FilesMenuOpeningEvent, value);
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x0001FA58 File Offset: 0x0001DC58
		global::System.Windows.FrameworkElement global::Infragistics.Windows.DockManager.IContentPaneContainer.ContainerElement
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x0001FA5B File Offset: 0x0001DC5B
		global::Infragistics.Windows.DockManager.PaneLocation global::Infragistics.Windows.DockManager.IContentPaneContainer.PaneLocation
		{
			get
			{
				return global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this);
			}
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0001FA64 File Offset: 0x0001DC64
		void global::Infragistics.Windows.DockManager.IContentPaneContainer.RemoveContentPane(global::Infragistics.Windows.DockManager.ContentPane pane, bool replaceWithPlaceholder)
		{
			int num = global::Infragistics.Windows.DockManager.DockManagerUtilities.IndexOf(base.Items, pane, true);
			if (num >= 0)
			{
				object obj = base.Items[num];
				if (obj is global::Infragistics.Windows.DockManager.ContentPanePlaceholder && replaceWithPlaceholder)
				{
					return;
				}
				if (num == base.SelectedIndex)
				{
					base.SelectedIndex = -1;
				}
				base.Items.RemoveAt(num);
				if (replaceWithPlaceholder)
				{
					global::Infragistics.Windows.DockManager.ContentPanePlaceholder contentPanePlaceholder = new global::Infragistics.Windows.DockManager.ContentPanePlaceholder();
					contentPanePlaceholder.Initialize(pane);
					base.Items.Insert(num, contentPanePlaceholder);
					if (pane.ReadLocalValue(global::Infragistics.Windows.DockManager.SplitPane.RelativeSizeProperty) != global::System.Windows.DependencyProperty.UnsetValue)
					{
						contentPanePlaceholder.SetValue(global::Infragistics.Windows.DockManager.SplitPane.RelativeSizeProperty, pane.ReadLocalValue(global::Infragistics.Windows.DockManager.SplitPane.RelativeSizeProperty));
					}
					pane.PlacementInfo.StorePlaceholder(contentPanePlaceholder);
				}
				else if (obj is global::Infragistics.Windows.DockManager.ContentPanePlaceholder)
				{
					pane.PlacementInfo.RemovePlaceholder((global::Infragistics.Windows.DockManager.ContentPanePlaceholder)obj);
				}
				this.VerifySelectedItem();
				this.VerifySelectedContent();
				global::Infragistics.AutomationPeers.ItemsControlPeerHelper.OnItemRemoved(this, pane);
			}
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0001FB3C File Offset: 0x0001DD3C
		void global::Infragistics.Windows.DockManager.IContentPaneContainer.InsertContentPane(int? newIndex, global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			int num = global::Infragistics.Windows.DockManager.DockManagerUtilities.IndexOf(base.Items, pane, true);
			bool flag = false;
			if (num >= 0)
			{
				if (base.Items[num] is global::Infragistics.Windows.DockManager.ContentPane)
				{
					return;
				}
				flag = (num == base.SelectedIndex);
				global::Infragistics.Windows.DockManager.ContentPanePlaceholder contentPanePlaceholder = base.Items[num] as global::Infragistics.Windows.DockManager.ContentPanePlaceholder;
				base.Items.RemoveAt(num);
				pane.PlacementInfo.RemovePlaceholder(contentPanePlaceholder);
				pane.SetValue(global::Infragistics.Windows.DockManager.SplitPane.RelativeSizeProperty, contentPanePlaceholder.ReadLocalValue(global::Infragistics.Windows.DockManager.SplitPane.RelativeSizeProperty));
			}
			else
			{
				num = base.Items.Count;
			}
			if (newIndex != null)
			{
				num = global::System.Math.Max(0, global::System.Math.Min(base.Items.Count, newIndex.Value));
			}
			base.Items.Insert(num, pane);
			if (flag)
			{
				base.SelectedIndex = num;
			}
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0001FC07 File Offset: 0x0001DE07
		global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> global::Infragistics.Windows.DockManager.IContentPaneContainer.GetVisiblePanes()
		{
			return global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateVisiblePaneList(base.Items);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0001FC14 File Offset: 0x0001DE14
		global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> global::Infragistics.Windows.DockManager.IContentPaneContainer.GetAllPanesForPaneAction(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			if (global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this) == global::Infragistics.Windows.DockManager.PaneLocation.Document)
			{
				return new global::Infragistics.Windows.DockManager.ContentPane[]
				{
					pane
				};
			}
			return ((global::Infragistics.Windows.DockManager.IContentPaneContainer)this).GetVisiblePanes();
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x0001FC3D File Offset: 0x0001DE3D
		global::System.Collections.IList global::Infragistics.Windows.DockManager.IPaneContainer.Panes
		{
			get
			{
				return this.CurrentItemsCollection;
			}
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0001FC48 File Offset: 0x0001DE48
		bool global::Infragistics.Windows.DockManager.IPaneContainer.RemovePane(object pane)
		{
			int num = base.Items.IndexOf(pane);
			if (num >= 0)
			{
				base.Items.RemoveAt(num);
				global::Infragistics.AutomationPeers.ItemsControlPeerHelper.OnItemRemoved(this, pane);
			}
			return num >= 0;
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x0001FC80 File Offset: 0x0001DE80
		bool global::Infragistics.Windows.DockManager.IPaneContainer.CanBeRemoved
		{
			get
			{
				return base.Items.Count == 0 && !global::Infragistics.Windows.DockManager.DockManagerUtilities.ShouldPreventPaneRemoval(this);
			}
		}

		// Token: 0x04000399 RID: 921
		private global::System.Windows.Controls.MenuItem _filesMenuItem;

		// Token: 0x0400039A RID: 922
		private global::System.Windows.Controls.MenuItem _hiddenMenuItem;

		// Token: 0x0400039B RID: 923
		private bool _initializingSelection;

		// Token: 0x0400039C RID: 924
		private bool _isMovingItem;

		// Token: 0x0400039D RID: 925
		private int _navigationModeVersion;

		// Token: 0x0400039E RID: 926
		private global::System.Collections.IList _itemsSnapshot;

		// Token: 0x0400039F RID: 927
		private global::System.Windows.FrameworkElement _headerArea;

		// Token: 0x040003A0 RID: 928
		private bool _isRefreshSelectedTabPeerPending;

		// Token: 0x040003A1 RID: 929
		private int _previousSelectedIndex;

		// Token: 0x040003A2 RID: 930
		public static readonly global::System.Windows.ResourceKey DockableTabGroupTemplateKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.TabGroupPane), "DockableTabGroupTemplateKey");

		// Token: 0x040003A3 RID: 931
		public static readonly global::System.Windows.ResourceKey DocumentTabGroupTemplateKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.TabGroupPane), "DocumentTabGroupTemplateKey");

		// Token: 0x040003A4 RID: 932
		public static readonly global::System.Windows.ResourceKey DocumentCloseButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.TabGroupPane), "DocumentCloseButtonStyleKey");

		// Token: 0x040003A5 RID: 933
		public static readonly global::System.Windows.ResourceKey DocumentFilesMenuItemStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.TabGroupPane), "DocumentFilesMenuItemStyleKey");

		// Token: 0x040003A6 RID: 934
		public static readonly global::System.Windows.ResourceKey DocumentPaneNavigatorButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.TabGroupPane), "DocumentPaneNavigatorButtonStyleKey");

		// Token: 0x040003A7 RID: 935
		public static readonly global::System.Windows.Input.RoutedCommand CloseSelectedItemCommand = new global::System.Windows.Input.RoutedCommand("CloseSelectedItem", typeof(global::Infragistics.Windows.DockManager.TabGroupPane));

		// Token: 0x040003A8 RID: 936
		private static readonly global::System.Windows.DependencyPropertyKey IsTabItemAreaVisiblePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsTabItemAreaVisible", typeof(bool), typeof(global::Infragistics.Windows.DockManager.TabGroupPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x040003A9 RID: 937
		public static readonly global::System.Windows.DependencyProperty IsTabItemAreaVisibleProperty = global::Infragistics.Windows.DockManager.TabGroupPane.IsTabItemAreaVisiblePropertyKey.DependencyProperty;

		// Token: 0x020000D0 RID: 208
		private class TabHeaderComparer : global::System.Collections.Generic.IComparer<object>
		{
			// Token: 0x060006CA RID: 1738 RVA: 0x0001FC9A File Offset: 0x0001DE9A
			private TabHeaderComparer()
			{
			}

			// Token: 0x060006CB RID: 1739 RVA: 0x0001FCA4 File Offset: 0x0001DEA4
			int global::System.Collections.Generic.IComparer<object>.Compare(object x, object y)
			{
				global::Infragistics.Windows.DockManager.ContentPane contentPane = x as global::Infragistics.Windows.DockManager.ContentPane;
				global::Infragistics.Windows.DockManager.ContentPane contentPane2 = y as global::Infragistics.Windows.DockManager.ContentPane;
				if (contentPane == null && contentPane2 == null)
				{
					return 0;
				}
				if (contentPane == null)
				{
					return -1;
				}
				if (contentPane2 == null)
				{
					return 1;
				}
				object tabHeader = contentPane.TabHeader;
				object tabHeader2 = contentPane2.TabHeader;
				if (tabHeader == null && tabHeader2 == null)
				{
					return 0;
				}
				if (tabHeader == null)
				{
					return -1;
				}
				if (tabHeader2 == null)
				{
					return 1;
				}
				if (tabHeader.GetType() == tabHeader2.GetType())
				{
					global::System.IComparable comparable = tabHeader as global::System.IComparable;
					if (comparable != null)
					{
						comparable.CompareTo(tabHeader2);
					}
				}
				string strA = tabHeader.ToString();
				string strB = tabHeader2.ToString();
				return string.Compare(strA, strB, global::System.StringComparison.Ordinal);
			}

			// Token: 0x040003AB RID: 939
			internal static readonly global::System.Collections.Generic.IComparer<object> Instance = new global::Infragistics.Windows.DockManager.TabGroupPane.TabHeaderComparer();
		}
	}
}
