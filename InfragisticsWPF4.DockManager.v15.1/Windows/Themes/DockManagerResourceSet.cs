using System;
using System.Windows;
using Infragistics.Windows.DockManager;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000AE RID: 174
	public abstract class DockManagerResourceSet<T> : global::Infragistics.Windows.Themes.ResourceSet where T : global::Infragistics.Windows.Themes.ResourceSetLocator, new()
	{
		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x0001DC26 File Offset: 0x0001BE26
		public override string Grouping
		{
			get
			{
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.Location.Grouping;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x0001DC32 File Offset: 0x0001BE32
		public override string Theme
		{
			get
			{
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.Location.Theme;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060005F4 RID: 1524 RVA: 0x0001DC40 File Offset: 0x0001BE40
		public override global::System.Windows.ResourceDictionary Resources
		{
			get
			{
				global::System.Windows.ResourceDictionary resourcesInternal = global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal;
				base.VerifyResources();
				return resourcesInternal;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x0001DC5A File Offset: 0x0001BE5A
		private static global::System.Windows.ResourceDictionary ResourcesInternal
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_ResourcesInternal == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_ResourcesInternal = global::Infragistics.Windows.Utilities.CreateResourceSetDictionary(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.Location.Assembly, global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.Location.ResourcePath);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_ResourcesInternal;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060005F6 RID: 1526 RVA: 0x0001DC86 File Offset: 0x0001BE86
		public static global::Infragistics.Windows.Themes.ResourceSetLocator Location
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_Location == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_Location = global::System.Activator.CreateInstance<T>();
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_Location;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x0001DCA3 File Offset: 0x0001BEA3
		public static global::System.Windows.Style ContentPane
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_ContentPane == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_ContentPane = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DockManager.ContentPane)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_ContentPane;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060005F8 RID: 1528 RVA: 0x0001DCCF File Offset: 0x0001BECF
		public static global::System.Windows.Style DockingIndicator
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DockingIndicator == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DockingIndicator = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DockManager.DockingIndicator)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DockingIndicator;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x0001DCFB File Offset: 0x0001BEFB
		public static global::System.Windows.Style DocumentContentHost
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DocumentContentHost == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DocumentContentHost = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DockManager.DocumentContentHost)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DocumentContentHost;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x0001DD27 File Offset: 0x0001BF27
		public static global::System.Windows.Style PaneHeaderPresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneHeaderPresenter == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneHeaderPresenter = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DockManager.PaneHeaderPresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneHeaderPresenter;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060005FB RID: 1531 RVA: 0x0001DD53 File Offset: 0x0001BF53
		public static global::System.Windows.Style PaneNavigator
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneNavigator == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneNavigator = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DockManager.PaneNavigator)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneNavigator;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060005FC RID: 1532 RVA: 0x0001DD7F File Offset: 0x0001BF7F
		public static global::System.Windows.Style PaneSplitter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneSplitter == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneSplitter = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DockManager.PaneSplitter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneSplitter;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060005FD RID: 1533 RVA: 0x0001DDAB File Offset: 0x0001BFAB
		public static global::System.Windows.Style PaneTabItem
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneTabItem == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneTabItem = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DockManager.PaneTabItem)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneTabItem;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x0001DDD7 File Offset: 0x0001BFD7
		public static global::System.Windows.Style PaneToolWindow
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneToolWindow == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneToolWindow = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DockManager.PaneToolWindow)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneToolWindow;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x0001DE03 File Offset: 0x0001C003
		public static global::System.Windows.Style SplitPane
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_SplitPane == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_SplitPane = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DockManager.SplitPane)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_SplitPane;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000600 RID: 1536 RVA: 0x0001DE2F File Offset: 0x0001C02F
		public static global::System.Windows.Style TabGroupPane
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_TabGroupPane == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_TabGroupPane = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DockManager.TabGroupPane)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_TabGroupPane;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000601 RID: 1537 RVA: 0x0001DE5B File Offset: 0x0001C05B
		public static global::System.Windows.Style UnpinnedTabArea
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_UnpinnedTabArea == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_UnpinnedTabArea = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DockManager.UnpinnedTabArea)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_UnpinnedTabArea;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x0001DE87 File Offset: 0x0001C087
		public static global::System.Windows.Style UnpinnedTabFlyout
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_UnpinnedTabFlyout == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_UnpinnedTabFlyout = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DockManager.UnpinnedTabFlyout)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_UnpinnedTabFlyout;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x0001DEB3 File Offset: 0x0001C0B3
		public static global::System.Windows.Style XamDockManager
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_XamDockManager == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_XamDockManager = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.DockManager.XamDockManager)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_XamDockManager;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000604 RID: 1540 RVA: 0x0001DEDF File Offset: 0x0001C0DF
		public static global::System.Windows.Style PaneHeaderPresenterCloseButton
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneHeaderPresenterCloseButton == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneHeaderPresenterCloseButton = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, global::Infragistics.Windows.DockManager.PaneHeaderPresenter.CloseButtonStyleKey) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneHeaderPresenterCloseButton;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x0001DF06 File Offset: 0x0001C106
		public static global::System.Windows.Style PaneHeaderPresenterPositionMenuItem
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneHeaderPresenterPositionMenuItem == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneHeaderPresenterPositionMenuItem = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, global::Infragistics.Windows.DockManager.PaneHeaderPresenter.PositionMenuItemStyleKey) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneHeaderPresenterPositionMenuItem;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x0001DF2D File Offset: 0x0001C12D
		public static global::System.Windows.Style PaneHeaderPresenterPinButton
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneHeaderPresenterPinButton == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneHeaderPresenterPinButton = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, global::Infragistics.Windows.DockManager.PaneHeaderPresenter.PinButtonStyleKey) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneHeaderPresenterPinButton;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x0001DF54 File Offset: 0x0001C154
		public static global::System.Windows.Style PaneNavigatorPanelScrollUpButton
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneNavigatorPanelScrollUpButton == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneNavigatorPanelScrollUpButton = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.ScrollUpButtonStyleKey) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneNavigatorPanelScrollUpButton;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000608 RID: 1544 RVA: 0x0001DF7B File Offset: 0x0001C17B
		public static global::System.Windows.Style PaneNavigatorPanelScrollDownButton
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneNavigatorPanelScrollDownButton == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneNavigatorPanelScrollDownButton = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, global::Infragistics.Windows.DockManager.PaneNavigatorItemsPanel.ScrollDownButtonStyleKey) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneNavigatorPanelScrollDownButton;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x0001DFA2 File Offset: 0x0001C1A2
		public static global::System.Windows.Style PaneSplitterPreview
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneSplitterPreview == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneSplitterPreview = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, global::Infragistics.Windows.DockManager.PaneSplitter.PreviewStyleKey) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_PaneSplitterPreview;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600060A RID: 1546 RVA: 0x0001DFC9 File Offset: 0x0001C1C9
		public static global::System.Windows.Style TabGroupPaneDocumentCloseButton
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_TabGroupPaneDocumentCloseButton == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_TabGroupPaneDocumentCloseButton = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, global::Infragistics.Windows.DockManager.TabGroupPane.DocumentCloseButtonStyleKey) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_TabGroupPaneDocumentCloseButton;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600060B RID: 1547 RVA: 0x0001DFF0 File Offset: 0x0001C1F0
		public static global::System.Windows.Style TabGroupPaneDocumentFilesMenuItem
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_TabGroupPaneDocumentFilesMenuItem == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_TabGroupPaneDocumentFilesMenuItem = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, global::Infragistics.Windows.DockManager.TabGroupPane.DocumentFilesMenuItemStyleKey) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_TabGroupPaneDocumentFilesMenuItem;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600060C RID: 1548 RVA: 0x0001E017 File Offset: 0x0001C217
		public static global::System.Windows.Style TabGroupPanelDocumentPaneNavigatorButton
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_TabGroupPanelDocumentPaneNavigatorButton == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_TabGroupPanelDocumentPaneNavigatorButton = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, global::Infragistics.Windows.DockManager.TabGroupPane.DocumentPaneNavigatorButtonStyleKey) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_TabGroupPanelDocumentPaneNavigatorButton;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600060D RID: 1549 RVA: 0x0001E03E File Offset: 0x0001C23E
		public static global::System.Windows.Style DockManagerDropPreview
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DockManagerDropPreview == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DockManagerDropPreview = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, global::Infragistics.Windows.DockManager.XamDockManager.DropPreviewStyleKey) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DockManagerDropPreview;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x0001E065 File Offset: 0x0001C265
		public static global::System.Windows.Style DockManagerContextMenu
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DockManagerContextMenu == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DockManagerContextMenu = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, global::Infragistics.Windows.DockManager.XamDockManager.ContextMenuStyleKey) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DockManagerContextMenu;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600060F RID: 1551 RVA: 0x0001E08C File Offset: 0x0001C28C
		public static global::System.Windows.Style DockManagerMenuItemSeparator
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DockManagerMenuItemSeparator == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DockManagerMenuItemSeparator = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, global::Infragistics.Windows.DockManager.XamDockManager.MenuItemSeparatorStyleKey) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DockManagerMenuItemSeparator;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x0001E0B3 File Offset: 0x0001C2B3
		public static global::System.Windows.Style DockManagerMenuItem
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DockManagerMenuItem == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DockManagerMenuItem = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, global::Infragistics.Windows.DockManager.XamDockManager.MenuItemStyleKey) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DockManagerMenuItem;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000611 RID: 1553 RVA: 0x0001E0DA File Offset: 0x0001C2DA
		public static global::System.Windows.Style DockManagerToolTip
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DockManagerToolTip == null)
				{
					global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DockManagerToolTip = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.ResourcesInternal, global::Infragistics.Windows.DockManager.XamDockManager.ToolTipStyleKey) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.DockManagerResourceSet<T>.g_DockManagerToolTip;
			}
		}

		// Token: 0x0400036B RID: 875
		internal const string GroupingName = "DockManager";

		// Token: 0x0400036C RID: 876
		[global::System.ThreadStatic]
		private static global::System.Windows.ResourceDictionary g_ResourcesInternal;

		// Token: 0x0400036D RID: 877
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.ResourceSetLocator g_Location;

		// Token: 0x0400036E RID: 878
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_ContentPane;

		// Token: 0x0400036F RID: 879
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_DockingIndicator;

		// Token: 0x04000370 RID: 880
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_DocumentContentHost;

		// Token: 0x04000371 RID: 881
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_PaneHeaderPresenter;

		// Token: 0x04000372 RID: 882
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_PaneNavigator;

		// Token: 0x04000373 RID: 883
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_PaneSplitter;

		// Token: 0x04000374 RID: 884
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_PaneTabItem;

		// Token: 0x04000375 RID: 885
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_PaneToolWindow;

		// Token: 0x04000376 RID: 886
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_SplitPane;

		// Token: 0x04000377 RID: 887
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_TabGroupPane;

		// Token: 0x04000378 RID: 888
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_UnpinnedTabArea;

		// Token: 0x04000379 RID: 889
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_UnpinnedTabFlyout;

		// Token: 0x0400037A RID: 890
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_XamDockManager;

		// Token: 0x0400037B RID: 891
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_PaneHeaderPresenterCloseButton;

		// Token: 0x0400037C RID: 892
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_PaneHeaderPresenterPositionMenuItem;

		// Token: 0x0400037D RID: 893
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_PaneHeaderPresenterPinButton;

		// Token: 0x0400037E RID: 894
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_PaneNavigatorPanelScrollUpButton;

		// Token: 0x0400037F RID: 895
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_PaneNavigatorPanelScrollDownButton;

		// Token: 0x04000380 RID: 896
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_PaneSplitterPreview;

		// Token: 0x04000381 RID: 897
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_TabGroupPaneDocumentCloseButton;

		// Token: 0x04000382 RID: 898
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_TabGroupPaneDocumentFilesMenuItem;

		// Token: 0x04000383 RID: 899
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_TabGroupPanelDocumentPaneNavigatorButton;

		// Token: 0x04000384 RID: 900
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_DockManagerDropPreview;

		// Token: 0x04000385 RID: 901
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_DockManagerContextMenu;

		// Token: 0x04000386 RID: 902
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_DockManagerMenuItemSeparator;

		// Token: 0x04000387 RID: 903
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_DockManagerMenuItem;

		// Token: 0x04000388 RID: 904
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_DockManagerToolTip;
	}
}
