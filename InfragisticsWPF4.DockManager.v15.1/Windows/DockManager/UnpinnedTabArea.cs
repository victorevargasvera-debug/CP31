using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using Infragistics.Collections;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x020000D2 RID: 210
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class UnpinnedTabArea : global::System.Windows.Controls.TabControl, global::Infragistics.Windows.DockManager.IPaneContainer
	{
		// Token: 0x060006D7 RID: 1751 RVA: 0x0001FF0A File Offset: 0x0001E10A
		public UnpinnedTabArea()
		{
			this._logicalChildren = new global::System.Collections.Generic.List<object>();
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0001FF20 File Offset: 0x0001E120
		static UnpinnedTabArea()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.UnpinnedTabArea), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DockManager.UnpinnedTabArea)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.UnpinnedTabArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::Infragistics.Windows.DockManager.UnpinnedTabItemPanel));
			frameworkElementFactory.SetBinding(global::Infragistics.Windows.DockManager.UnpinnedTabItemPanel.TabStripPlacementProperty, new global::System.Windows.Data.Binding("TemplatedParent.TabStripPlacement")
			{
				Mode = global::System.Windows.Data.BindingMode.OneWay,
				RelativeSource = global::System.Windows.Data.RelativeSource.TemplatedParent
			});
			frameworkElementFactory.SetValue(global::System.Windows.Controls.Panel.IsItemsHostProperty, global::Infragistics.KnownBoxes.TrueBox);
			global::System.Windows.Controls.ItemsPanelTemplate itemsPanelTemplate = new global::System.Windows.Controls.ItemsPanelTemplate(frameworkElementFactory);
			itemsPanelTemplate.Seal();
			global::System.Windows.Controls.ItemsControl.ItemsPanelProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.UnpinnedTabArea), new global::System.Windows.FrameworkPropertyMetadata(itemsPanelTemplate));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.UnpinnedTabArea), global::System.Windows.FrameworkElement.RequestBringIntoViewEvent, new global::System.Windows.RequestBringIntoViewEventHandler(global::Infragistics.Windows.DockManager.UnpinnedTabArea.OnRequestBringIntoView));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.UnpinnedTabArea), global::System.Windows.FrameworkElement.ContextMenuOpeningEvent, new global::System.Windows.Controls.ContextMenuEventHandler(global::Infragistics.Windows.DockManager.UnpinnedTabArea.OnContextMenuOpening));
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.UnpinnedTabArea), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.UnpinnedTabArea.CoerceVisibility)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.UnpinnedTabArea), global::Infragistics.Windows.DockManager.DockManagerUtilities.VisibilityChangedEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.DockManager.UnpinnedTabArea.OnChildVisibilityChanged));
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x00020064 File Offset: 0x0001E264
		protected override void ClearContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			global::Infragistics.Windows.DockManager.PaneTabItem target = element as global::Infragistics.Windows.DockManager.PaneTabItem;
			global::System.Windows.Data.BindingOperations.ClearBinding(target, global::System.Windows.Controls.HeaderedContentControl.HeaderProperty);
			global::System.Windows.Data.BindingOperations.ClearBinding(target, global::System.Windows.Controls.HeaderedContentControl.HeaderTemplateProperty);
			global::System.Windows.Data.BindingOperations.ClearBinding(target, global::System.Windows.Controls.HeaderedContentControl.HeaderTemplateSelectorProperty);
			base.ClearContainerForItemOverride(element, item);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x000200A1 File Offset: 0x0001E2A1
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			return new global::Infragistics.Windows.DockManager.PaneTabItem();
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000200A8 File Offset: 0x0001E2A8
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			return item is global::Infragistics.Windows.DockManager.PaneTabItem;
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x000200B4 File Offset: 0x0001E2B4
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				if (this._logicalChildren.Count != 0)
				{
					return new global::Infragistics.Collections.MultiSourceEnumerator(new global::System.Collections.IEnumerator[]
					{
						base.LogicalChildren,
						this._logicalChildren.GetEnumerator()
					});
				}
				return base.LogicalChildren;
			}
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x000200FE File Offset: 0x0001E2FE
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			base.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
			global::Infragistics.Windows.DockManager.DockManagerUtilities.VerifyOwningToolWindow(this);
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00020118 File Offset: 0x0001E318
		protected override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			base.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
			base.OnItemsChanged(e);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0002012C File Offset: 0x0001E32C
		protected override void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			if (!(item is global::Infragistics.Windows.DockManager.ContentPane))
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_InvalidUnpinnedTabAreaChild"));
			}
			global::Infragistics.Windows.DockManager.PaneTabItem paneTabItem = element as global::Infragistics.Windows.DockManager.PaneTabItem;
			global::Infragistics.Windows.DockManager.ContentPane source = item as global::Infragistics.Windows.DockManager.ContentPane;
			paneTabItem.SetBinding(global::System.Windows.Controls.HeaderedContentControl.HeaderProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.ContentPane.TabHeaderProperty, global::System.Windows.Data.BindingMode.OneWay, source));
			paneTabItem.SetBinding(global::System.Windows.Controls.HeaderedContentControl.HeaderTemplateProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.ContentPane.TabHeaderTemplateProperty, global::System.Windows.Data.BindingMode.OneWay, source));
			paneTabItem.SetBinding(global::System.Windows.Controls.HeaderedContentControl.HeaderTemplateSelectorProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.ContentPane.TabHeaderTemplateSelectorProperty, global::System.Windows.Data.BindingMode.OneWay, source));
			global::System.Windows.Data.BindingOperations.SetBinding(element, global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.UIElement.VisibilityProperty, global::System.Windows.Data.BindingMode.OneWay, item));
			base.PrepareContainerForItemOverride(element, item);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000201C7 File Offset: 0x0001E3C7
		internal void AddLogicalChildInternal(object child)
		{
			base.AddLogicalChild(child);
			this._logicalChildren.Add(child);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x000201DC File Offset: 0x0001E3DC
		internal void RemoveLogicalChildInternal(object child)
		{
			base.RemoveLogicalChild(child);
			this._logicalChildren.Remove(child);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000201F2 File Offset: 0x0001E3F2
		private static object CoerceVisibility(global::System.Windows.DependencyObject d, object newValue)
		{
			return global::Infragistics.Windows.DockManager.DockManagerUtilities.ProcessCoerceVisibility(d, newValue);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x000201FC File Offset: 0x0001E3FC
		private static void OnChildVisibilityChanged(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.UnpinnedTabArea unpinnedTabArea = sender as global::Infragistics.Windows.DockManager.UnpinnedTabArea;
			if (sender != e.OriginalSource)
			{
				unpinnedTabArea.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
				e.Handled = true;
			}
			global::Infragistics.Windows.DockManager.DockManagerUtilities.VerifyOwningToolWindow(unpinnedTabArea);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00020234 File Offset: 0x0001E434
		private static void OnContextMenuOpening(object sender, global::System.Windows.Controls.ContextMenuEventArgs e)
		{
			global::Infragistics.Windows.DockManager.UnpinnedTabArea unpinnedTabArea = sender as global::Infragistics.Windows.DockManager.UnpinnedTabArea;
			if (global::Infragistics.Windows.Utilities.GetAncestorFromType(e.OriginalSource as global::System.Windows.DependencyObject, typeof(global::System.Windows.Controls.TabItem), true, unpinnedTabArea) != null)
			{
				return;
			}
			if (unpinnedTabArea != null && unpinnedTabArea.ContextMenu == null && unpinnedTabArea.ReadLocalValue(global::System.Windows.FrameworkElement.ContextMenuProperty) != null)
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane>();
				foreach (object obj in ((global::System.Collections.IEnumerable)unpinnedTabArea.Items))
				{
					global::Infragistics.Windows.DockManager.ContentPane contentPane = obj as global::Infragistics.Windows.DockManager.ContentPane;
					if (contentPane != null && contentPane.Visibility == global::System.Windows.Visibility.Visible)
					{
						list.Add(contentPane);
					}
				}
				if (list.Count == 0)
				{
					return;
				}
				global::System.Windows.Controls.ContextMenu contextMenu = new global::System.Windows.Controls.ContextMenu();
				contextMenu.SetValue(global::System.Windows.FrameworkElement.DefaultStyleKeyProperty, global::Infragistics.Windows.DockManager.XamDockManager.ContextMenuStyleKey);
				contextMenu.PlacementTarget = unpinnedTabArea;
				contextMenu.Placement = global::System.Windows.Controls.Primitives.PlacementMode.RelativePoint;
				global::System.Windows.Point point = default(global::System.Windows.Point);
				global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject;
				while (dependencyObject is global::System.Windows.ContentElement)
				{
					dependencyObject = global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject);
				}
				if (dependencyObject is global::System.Windows.UIElement)
				{
					point = unpinnedTabArea.TranslatePoint(point, (global::System.Windows.UIElement)dependencyObject);
				}
				contextMenu.HorizontalOffset = e.CursorLeft - point.X;
				contextMenu.VerticalOffset = e.CursorTop - point.Y;
				foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane2 in list)
				{
					global::System.Windows.Controls.MenuItem menuItem = new global::System.Windows.Controls.MenuItem();
					menuItem.Command = global::Infragistics.Windows.DockManager.ContentPaneCommands.ActivatePane;
					menuItem.CommandTarget = contentPane2;
					menuItem.CommandParameter = contentPane2;
					menuItem.Header = contentPane2.TabHeader;
					menuItem.HeaderTemplate = contentPane2.TabHeaderTemplate;
					menuItem.HeaderTemplateSelector = contentPane2.TabHeaderTemplateSelector;
					menuItem.SetValue(global::System.Windows.FrameworkElement.DefaultStyleKeyProperty, global::Infragistics.Windows.DockManager.XamDockManager.MenuItemStyleKey);
					contextMenu.Items.Add(menuItem);
				}
				if (contextMenu.Items.Count > 0)
				{
					contextMenu.IsOpen = true;
					e.Handled = true;
				}
			}
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x00020454 File Offset: 0x0001E654
		private static void OnRequestBringIntoView(object sender, global::System.Windows.RequestBringIntoViewEventArgs e)
		{
			global::Infragistics.Windows.DockManager.UnpinnedTabArea unpinnedTabArea = sender as global::Infragistics.Windows.DockManager.UnpinnedTabArea;
			unpinnedTabArea.OnRequestBringIntoView(e);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00020470 File Offset: 0x0001E670
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
					base.SelectedIndex = num;
					global::Infragistics.Windows.DockManager.ContentPane contentPane = tabControlChild as global::Infragistics.Windows.DockManager.ContentPane;
					if (contentPane != null)
					{
						global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
						if (dockManager != null && !dockManager.IsShowFlyoutSuspended && dockManager == global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this))
						{
							dockManager.ShowFlyout(contentPane, false, false);
						}
					}
				}
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060006E7 RID: 1767 RVA: 0x000204F3 File Offset: 0x0001E6F3
		global::System.Collections.IList global::Infragistics.Windows.DockManager.IPaneContainer.Panes
		{
			get
			{
				return base.Items;
			}
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x000204FB File Offset: 0x0001E6FB
		bool global::Infragistics.Windows.DockManager.IPaneContainer.RemovePane(object pane)
		{
			return false;
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060006E9 RID: 1769 RVA: 0x000204FE File Offset: 0x0001E6FE
		bool global::Infragistics.Windows.DockManager.IPaneContainer.CanBeRemoved
		{
			get
			{
				return false;
			}
		}

		// Token: 0x040003AD RID: 941
		private global::System.Collections.Generic.List<object> _logicalChildren;
	}
}
