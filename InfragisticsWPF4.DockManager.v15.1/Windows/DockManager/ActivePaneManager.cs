using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000008 RID: 8
	internal class ActivePaneManager : global::System.Windows.DependencyObject
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002754 File Offset: 0x00000954
		static ActivePaneManager()
		{
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.ContentPane), global::System.Windows.Input.Keyboard.GotKeyboardFocusEvent, new global::System.Windows.Input.KeyboardFocusChangedEventHandler(global::Infragistics.Windows.DockManager.ActivePaneManager.OnContentPaneGotKeyboardFocus), true);
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.ContentPane), global::System.Windows.Input.FocusManager.GotFocusEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.DockManager.ActivePaneManager.OnPaneGotOrLostFocus), true);
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.ContentPane), global::System.Windows.Input.FocusManager.LostFocusEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.DockManager.ActivePaneManager.OnPaneGotOrLostFocus), true);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000295C File Offset: 0x00000B5C
		internal ActivePaneManager(global::Infragistics.Windows.DockManager.XamDockManager dockManager)
		{
			this._dockManager = dockManager;
			this._panes = new global::System.Collections.Generic.LinkedList<global::Infragistics.Windows.DockManager.ContentPane>();
			this._panesToRemove = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane>();
			this._placeholdersToRemove = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPanePlaceholder>();
			global::System.Windows.RoutedEventHandler value = new global::System.Windows.RoutedEventHandler(this.OnDockManagerLoadStateChanged);
			this._dockManager.Loaded += value;
			this._dockManager.Unloaded += value;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000029BC File Offset: 0x00000BBC
		public bool CanNavigatePanes
		{
			get
			{
				return null != this.GetPaneInActivationOrder(null, true, true, global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisibleExceptDocument, true);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000029D0 File Offset: 0x00000BD0
		public bool CanNavigateDocuments
		{
			get
			{
				global::Infragistics.Windows.DockManager.ContentPane activeDocument = this.GetActiveDocument();
				return activeDocument != null && (this.GetPaneInActivationOrder(activeDocument, false, true, global::Infragistics.Windows.DockManager.PaneFilterFlags.Document, true) != null || activeDocument != this.GetPaneInActivationOrder(null, true, true, global::Infragistics.Windows.DockManager.PaneFilterFlags.Document, true));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002A09 File Offset: 0x00000C09
		internal bool HasActivatablePanes
		{
			get
			{
				return null != this.GetPaneInActivationOrder(null, true, true, global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisible, true);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002A1D File Offset: 0x00000C1D
		public static bool GetIsActiveDocument(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DockManager.ActivePaneManager.IsActiveDocumentProperty);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002A2F File Offset: 0x00000C2F
		public static bool GetIsActivePane(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DockManager.ActivePaneManager.IsActivePaneProperty);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002A41 File Offset: 0x00000C41
		private static void OnIsDockManagerWindowActiveChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.DockManager.ActivePaneManager)d).OnWindowActivationChanged();
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002A4E File Offset: 0x00000C4E
		public bool IsDockManagerWindowActive
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.ActivePaneManager.IsDockManagerWindowActiveProperty);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002A60 File Offset: 0x00000C60
		private static void OnIsKeyboardFocusWithinExChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.ContentPane contentPane = d as global::Infragistics.Windows.DockManager.ContentPane;
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(contentPane);
			bool flag = true.Equals(e.NewValue) && null != dockManager;
			global::Infragistics.Windows.DockManager.FocusWatcher focusWatcher = (global::Infragistics.Windows.DockManager.FocusWatcher)contentPane.GetValue(global::Infragistics.Windows.DockManager.ActivePaneManager.FocusWatcherProperty);
			if (focusWatcher == null && flag && dockManager != null)
			{
				focusWatcher = new global::Infragistics.Windows.DockManager.ActivePaneManager.PaneFocusWatcher(contentPane);
				contentPane.SetValue(global::Infragistics.Windows.DockManager.ActivePaneManager.FocusWatcherProperty, focusWatcher);
			}
			else if (focusWatcher != null && (dockManager == null || !flag))
			{
				focusWatcher.Dispose();
				contentPane.ClearValue(global::Infragistics.Windows.DockManager.ActivePaneManager.FocusWatcherProperty);
			}
			if (dockManager != null)
			{
				global::Infragistics.Windows.DockManager.ActivePaneManager activePaneManager = dockManager.ActivePaneManager;
				if (!flag && activePaneManager._activePane != contentPane)
				{
					return;
				}
				activePaneManager.OnContentPaneStateChanged(contentPane);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002B03 File Offset: 0x00000D03
		public static bool GetIsKeyboardFocusWithinEx(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DockManager.ActivePaneManager.IsKeyboardFocusWithinExProperty);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002B15 File Offset: 0x00000D15
		// (set) Token: 0x0600002D RID: 45 RVA: 0x00002B20 File Offset: 0x00000D20
		public bool IsInNavigationMode
		{
			get
			{
				return this._isInNavigationMode;
			}
			set
			{
				if (value != this._isInNavigationMode)
				{
					this._isInNavigationMode = value;
					if (value)
					{
						this._navigationModeVersion++;
						this.CreateNavigationModeFocusWatcher();
						return;
					}
					this.DisposeNavigationModeFocusWatcher();
					if (this._activePane != null)
					{
						this.MovePaneToHead(this._activePane);
					}
				}
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00002B6F File Offset: 0x00000D6F
		internal bool IsVerificationSuspended
		{
			get
			{
				return this._suspendVerificationCount > 0;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002B7A File Offset: 0x00000D7A
		public int NavigationModeVersion
		{
			get
			{
				return this._navigationModeVersion;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002B82 File Offset: 0x00000D82
		public global::Infragistics.Windows.DockManager.ContentPane GetActiveDocument()
		{
			return this._activeDocument;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002B8A File Offset: 0x00000D8A
		public global::Infragistics.Windows.DockManager.ContentPane GetActivePane()
		{
			return this._activePane;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002B92 File Offset: 0x00000D92
		internal bool ActivateNextDocument(global::Infragistics.Windows.DockManager.ContentPane pane, bool next)
		{
			return this.ActivateNextItem(pane, next, true);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002B9D File Offset: 0x00000D9D
		internal bool ActivateNextPane(global::Infragistics.Windows.DockManager.ContentPane pane, bool next)
		{
			return this.ActivateNextItem(pane, next, false);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002BA8 File Offset: 0x00000DA8
		internal global::Infragistics.Windows.DockManager.ContentPane GetInitialPaneNavigatorItem(bool startWithDocuments, int offset)
		{
			global::Infragistics.Windows.DockManager.ContentPane contentPane = startWithDocuments ? this._activeDocument : this._activePane;
			if (!startWithDocuments && (contentPane == null || contentPane.IsDocument))
			{
				contentPane = this.GetNextActivePane(null, true, global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisibleExceptDocument, global::Infragistics.Windows.DockManager.PaneNavigationOrder.ActivationOrder, false, true);
				if (contentPane == null)
				{
					contentPane = this._activeDocument;
				}
			}
			else if (!startWithDocuments || contentPane == null || contentPane.IsKeyboardFocusWithinEx)
			{
				if (contentPane != null)
				{
					if (offset != 0)
					{
						contentPane = this.GetNextActivePane(contentPane, offset > 0, startWithDocuments ? global::Infragistics.Windows.DockManager.PaneFilterFlags.Document : global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisibleExceptDocument);
					}
				}
				else
				{
					global::Infragistics.Windows.DockManager.PaneFilterFlags filter = startWithDocuments ? global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisibleExceptDocument : global::Infragistics.Windows.DockManager.PaneFilterFlags.Document;
					contentPane = this.GetNextActivePane(null, true, filter, global::Infragistics.Windows.DockManager.PaneNavigationOrder.ActivationOrder, false, true);
				}
			}
			return contentPane;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002C30 File Offset: 0x00000E30
		internal global::Infragistics.Windows.DockManager.ContentPane GetLastActivePane()
		{
			if (this._activePane == null)
			{
				return this.GetNextActivePane(null, true, global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisible, global::Infragistics.Windows.DockManager.PaneNavigationOrder.ActivationOrder, false, true);
			}
			return this._activePane;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002D80 File Offset: 0x00000F80
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DockManager.ContentPane> GetPanes(global::Infragistics.Windows.DockManager.PaneFilterFlags filter, global::Infragistics.Windows.DockManager.PaneNavigationOrder order, bool ensureActivatable)
		{
			global::Infragistics.Windows.DockManager.ContentPane pane = null;
			while ((pane = this.GetNextActivePane(pane, true, filter, order, false, ensureActivatable)) != null)
			{
				yield return pane;
			}
			yield break;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002DB2 File Offset: 0x00000FB2
		internal void MoveToFront(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			if (this._activePane != null || pane == null)
			{
				return;
			}
			if (this._panes.Remove(pane))
			{
				this._panes.AddFirst(pane);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002DDC File Offset: 0x00000FDC
		internal void OnPaneAdded(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			int num = this._panesToRemove.IndexOf(pane);
			if (num >= 0)
			{
				this._panesToRemove.RemoveAt(num);
				return;
			}
			if (this._panes.Contains(pane))
			{
				return;
			}
			this._panes.AddLast(pane);
			if (pane.PaneLocation != global::Infragistics.Windows.DockManager.PaneLocation.Unknown)
			{
				this.VerifyActiveDocument(false);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002E34 File Offset: 0x00001034
		internal void OnPlaceholderAdded(global::Infragistics.Windows.DockManager.ContentPanePlaceholder placeholder)
		{
			int num = this._placeholdersToRemove.IndexOf(placeholder);
			if (num >= 0)
			{
				this._placeholdersToRemove.RemoveAt(num);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002E5E File Offset: 0x0000105E
		internal void OnPaneRemoved(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			this._panesToRemove.Add(pane);
			if (this._panesToRemove.Count == 1)
			{
				this._dockManager.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::Infragistics.Windows.DockManager.DockManagerUtilities.MethodInvoker(this.ProcessPaneRemoval));
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002E98 File Offset: 0x00001098
		internal void OnPlaceholderRemoved(global::Infragistics.Windows.DockManager.ContentPanePlaceholder placeholder)
		{
			this._placeholdersToRemove.Add(placeholder);
			if (this._placeholdersToRemove.Count == 1)
			{
				this._dockManager.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::Infragistics.Windows.DockManager.DockManagerUtilities.MethodInvoker(this.ProcessPaneRemoval));
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002ED2 File Offset: 0x000010D2
		internal void ProcessPendingOperations()
		{
			this.ProcessPaneRemoval();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002EDC File Offset: 0x000010DC
		private void ProcessPaneRemoval()
		{
			if (!this._dockManager.IsLoaded)
			{
				return;
			}
			if (this._dockManager.DockPanel != null)
			{
				this._dockManager.ApplyTemplate();
			}
			global::Infragistics.Windows.DockManager.ContentPanePlaceholder[] array = this._placeholdersToRemove.ToArray();
			this._placeholdersToRemove.Clear();
			if (array.Length > 0)
			{
				foreach (global::Infragistics.Windows.DockManager.ContentPanePlaceholder contentPanePlaceholder in array)
				{
					global::Infragistics.Windows.DockManager.ContentPane pane = contentPanePlaceholder.Pane;
					if (pane != null && !global::Infragistics.Windows.DockManager.DockManagerUtilities.IsValidDockManagerElement(this._dockManager, contentPanePlaceholder))
					{
						if (contentPanePlaceholder == pane.PlacementInfo.DockedEdgePlaceholder && !pane.IsPinned)
						{
							this._dockManager.MovePaneToPinnedContainer(pane, true);
						}
						else
						{
							pane.PlacementInfo.RemovePlaceholder(contentPanePlaceholder);
						}
					}
				}
			}
			global::Infragistics.Windows.DockManager.ContentPane[] array2 = this._panesToRemove.ToArray();
			this._panesToRemove.Clear();
			if (array2.Length > 0)
			{
				int j = 0;
				int num = array2.Length;
				while (j < num)
				{
					global::Infragistics.Windows.DockManager.ContentPane contentPane = array2[j];
					if (!global::Infragistics.Windows.DockManager.DockManagerUtilities.IsValidDockManagerElement(this._dockManager, contentPane))
					{
						this._panes.Remove(contentPane);
						this._dockManager.ClosePaneHelper(contentPane, global::Infragistics.Windows.DockManager.PaneCloseAction.RemovePane, false, false);
					}
					j++;
				}
				this.VerifyActivePane(true);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002FFC File Offset: 0x000011FC
		internal void RebuildPaneList()
		{
			this._panes.Clear();
			global::Infragistics.Windows.DockManager.PaneFilterFlags filter = global::Infragistics.Windows.DockManager.PaneFilterFlags.All;
			global::Infragistics.Windows.DockManager.ContentPane contentPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetFirstLastPane(this._dockManager, true, filter);
			if (contentPane != null)
			{
				global::System.Collections.Generic.LinkedListNode<global::Infragistics.Windows.DockManager.ContentPane> node = this._panes.AddFirst(contentPane);
				while ((contentPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetNextPreviousPane(contentPane, false, true, null, filter)) != null)
				{
					node = this._panes.AddAfter(node, contentPane);
				}
			}
			global::Infragistics.Windows.DockManager.ContentPane keyboardFocusedPane = this.GetKeyboardFocusedPane();
			if (keyboardFocusedPane != null)
			{
				this.OnContentPaneStateChanged(keyboardFocusedPane);
			}
			this.VerifyActiveDocument(true);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000306C File Offset: 0x0000126C
		internal void RefreshActivePaneSortOrder(global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> oldOrder)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane>(this._panes.Count);
			foreach (global::Infragistics.Windows.DockManager.ContentPane item in this._panes)
			{
				list.Add(item);
			}
			this._panes.Clear();
			global::Infragistics.CoreUtilities.SortMergeGeneric<global::Infragistics.Windows.DockManager.ContentPane>(list, new global::Infragistics.Windows.DockManager.ActivePaneManager.LastActivatedTimeComparer(oldOrder));
			foreach (global::Infragistics.Windows.DockManager.ContentPane value in list)
			{
				this._panes.AddFirst(value);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000312C File Offset: 0x0000132C
		internal void ResetActivePanesAfterLoad(bool canChangeActivePane)
		{
			global::Infragistics.Windows.DockManager.ContentPane contentPane = null;
			global::Infragistics.Windows.DockManager.ContentPane contentPane2 = null;
			foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane3 in this.GetPanes(global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisible, global::Infragistics.Windows.DockManager.PaneNavigationOrder.ActivationOrder, true))
			{
				if (contentPane3.PaneLocation != global::Infragistics.Windows.DockManager.PaneLocation.Unpinned)
				{
					global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = global::System.Windows.LogicalTreeHelper.GetParent(contentPane3) as global::Infragistics.Windows.DockManager.TabGroupPane;
					if (tabGroupPane == null || contentPane3 == tabGroupPane.SelectedItem)
					{
						if (contentPane == null)
						{
							contentPane = contentPane3;
						}
						if (contentPane3.PaneLocation == global::Infragistics.Windows.DockManager.PaneLocation.Document)
						{
							contentPane2 = contentPane3;
						}
						if (contentPane2 != null)
						{
							break;
						}
					}
				}
			}
			if (!canChangeActivePane)
			{
				contentPane = this._activePane;
				if (this._activePane != null && !this._activePane.CanActivate)
				{
					contentPane = this.GetNextActivePane(null, true, global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisible, global::Infragistics.Windows.DockManager.PaneNavigationOrder.ActivationOrder, false, true);
				}
			}
			else if (contentPane == null)
			{
				contentPane = this.GetLastActivePane();
			}
			this.SetActivePaneImpl(contentPane, contentPane2);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000031F4 File Offset: 0x000013F4
		internal void ResumeVerification()
		{
			this._suspendVerificationCount--;
			if (this._suspendVerificationCount == 0)
			{
				this.VerifyActivePane();
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003212 File Offset: 0x00001412
		internal void SetActiveDocument(global::Infragistics.Windows.DockManager.ContentPane cp)
		{
			this.SetActivePaneImpl(this._activePane, cp);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003221 File Offset: 0x00001421
		internal void SuspendVerification()
		{
			this._suspendVerificationCount++;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003231 File Offset: 0x00001431
		internal void VerifyActivePane()
		{
			this.VerifyActivePane(false);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000323C File Offset: 0x0000143C
		private void VerifyActivePane(bool verifySelectedTab)
		{
			if (this.IsVerificationSuspended)
			{
				return;
			}
			if (this._dockManager.IsLoadingLayout)
			{
				return;
			}
			global::Infragistics.Windows.DockManager.ContentPane activePane = this._activePane;
			global::Infragistics.Windows.DockManager.ContentPane activeDocument = this._activeDocument;
			global::Infragistics.Windows.DockManager.ContentPane contentPane = this._activePane;
			global::Infragistics.Windows.DockManager.ContentPane contentPane2 = this._activeDocument;
			if (activePane != null)
			{
				global::Infragistics.Windows.DockManager.PaneFilterFlags filter = (activePane == activeDocument) ? global::Infragistics.Windows.DockManager.PaneFilterFlags.Document : global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisibleExceptDocument;
				if (global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(activePane) != this._dockManager)
				{
					contentPane = this.GetPaneInActivationOrder(activePane, false, true, filter, true);
				}
				else if (activePane.Visibility == global::System.Windows.Visibility.Collapsed)
				{
					contentPane = this.GetNextActivePane(activePane, true, filter);
				}
				else
				{
					contentPane = activePane;
				}
				if (contentPane == null)
				{
					contentPane = this.GetPaneInActivationOrder(null, true, true, global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisible, true);
				}
				if (contentPane != null && global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(contentPane) != this._dockManager)
				{
					contentPane = null;
				}
				if (contentPane != null && this.GetKeyboardFocusedPane() == null)
				{
					global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(this._dockManager);
					if (focusScope != null)
					{
						global::System.Windows.DependencyObject dependencyObject = global::System.Windows.Input.FocusManager.GetFocusedElement(focusScope) as global::System.Windows.DependencyObject;
						if (dependencyObject != null && !(dependencyObject is global::Infragistics.Windows.DockManager.XamDockManager) && global::Infragistics.Windows.DockManager.ActivePaneManager.GetDockManagerPane(dependencyObject, this._dockManager) == null && global::Infragistics.Windows.Utilities.IsDescendantOf(focusScope, dependencyObject, true))
						{
							contentPane = null;
						}
					}
				}
			}
			if (activeDocument != null)
			{
				if (global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(activeDocument) != this._dockManager)
				{
					contentPane2 = this.GetPaneInActivationOrder(activeDocument, false, true, global::Infragistics.Windows.DockManager.PaneFilterFlags.Document, true);
				}
				else if (this._activeDocument.Visibility == global::System.Windows.Visibility.Collapsed || global::Infragistics.Windows.DockManager.PaneLocation.Document != this._activeDocument.PaneLocation)
				{
					contentPane2 = this.GetNextActivePane(activeDocument, true, global::Infragistics.Windows.DockManager.PaneFilterFlags.Document);
				}
				else
				{
					contentPane2 = activeDocument;
				}
				if (contentPane2 != null && global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(contentPane2) != this._dockManager)
				{
					contentPane2 = null;
				}
			}
			if (activePane != contentPane || activeDocument != contentPane2)
			{
				bool suppressFlyoutDuringActivate = false;
				if (contentPane != null)
				{
					suppressFlyoutDuringActivate = contentPane.SuppressFlyoutDuringActivate;
					contentPane.SuppressFlyoutDuringActivate = true;
				}
				try
				{
					this.SetActivePaneImpl(contentPane, contentPane2);
					if (contentPane != null && contentPane == this._activePane)
					{
						if (activePane.IsKeyboardFocusWithinEx || (global::System.Windows.Input.Keyboard.FocusedElement == null && this.GetKeyboardFocusedPane() == null))
						{
							contentPane.ActivateInternal(false, contentPane.PaneLocation != global::Infragistics.Windows.DockManager.PaneLocation.Unpinned);
						}
						else if (contentPane.PaneLocation != global::Infragistics.Windows.DockManager.PaneLocation.Unpinned)
						{
							contentPane.BringIntoView();
							contentPane.UpdateLayout();
						}
					}
				}
				finally
				{
					if (contentPane != null)
					{
						contentPane.SuppressFlyoutDuringActivate = suppressFlyoutDuringActivate;
					}
				}
				if (contentPane2 != null && contentPane2 != contentPane && contentPane2 == this._activeDocument)
				{
					contentPane2.BringIntoView();
					contentPane2.UpdateLayout();
				}
			}
			this.VerifyActiveDocument(false);
			if (verifySelectedTab && !this._dockManager.IsClosingPanes)
			{
				this.VerifyTabIsSelected(this._activePane);
				this.VerifyTabIsSelected(this._activeDocument);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003474 File Offset: 0x00001674
		internal void VerifyHasPreprocessHandler()
		{
			if (this._dockManager.IsLoaded && this._dockManager.HasHwndHost)
			{
				if (this._preprocessHandler != null || !global::Infragistics.Windows.DockManager.ActivePaneManager._canCreatePreprocessHandler)
				{
					return;
				}
				try
				{
					this._preprocessHandler = this.CreatePreprocessHandler();
					return;
				}
				catch (global::System.Security.SecurityException)
				{
					global::Infragistics.Windows.DockManager.ActivePaneManager._canCreatePreprocessHandler = false;
					return;
				}
			}
			if (this._preprocessHandler != null)
			{
				this._preprocessHandler.Dispose();
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000034E4 File Offset: 0x000016E4
		private bool ActivateNextItem(global::Infragistics.Windows.DockManager.ContentPane pane, bool next, bool document)
		{
			global::Infragistics.Windows.DockManager.PaneFilterFlags filter = document ? global::Infragistics.Windows.DockManager.PaneFilterFlags.Document : global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisibleExceptDocument;
			global::Infragistics.Windows.DockManager.ContentPane contentPane;
			if (pane == null || document != pane.IsDocument)
			{
				contentPane = (document ? this.GetActiveDocument() : this.GetActivePane());
				if (!document && (contentPane == null || contentPane.IsDocument))
				{
					contentPane = this.GetPaneInActivationOrder(null, true, true, filter, true);
				}
			}
			else
			{
				contentPane = this.GetNextActivePane(pane, next, filter);
			}
			return contentPane != null && contentPane.ActivateInternal();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000354B File Offset: 0x0000174B
		private void ClearActivePane()
		{
			this.SetActivePane(null);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00003554 File Offset: 0x00001754
		private void CreateNavigationModeFocusWatcher()
		{
			this.DisposeNavigationModeFocusWatcher();
			this._navigationModeFocusWatcher = new global::Infragistics.Windows.DockManager.KeyEventFocusWatcher();
			this._navigationModeFocusWatcher.KeyEvent += this.OnNavigationModeFocusKeyEvent;
			this._navigationModeFocusWatcher.FocusedElementChanged += this.OnNavigationModeFocusChanged;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000035A0 File Offset: 0x000017A0
		private void CreateActivePaneFocusWatcher()
		{
			this.DisposeActivePaneFocusWatcher();
			this._activePaneFocusWatcher = new global::Infragistics.Windows.DockManager.FocusWatcher();
			this._activePaneFocusWatcher.FocusedElementChanged += this.OnKeyboardFocusedElementChanged;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000035CA File Offset: 0x000017CA
		private void DisposeActivePaneFocusWatcher()
		{
			if (this._activePaneFocusWatcher != null)
			{
				this._activePaneFocusWatcher.FocusedElementChanged -= this.OnKeyboardFocusedElementChanged;
				this._activePaneFocusWatcher.Dispose();
				this._activePaneFocusWatcher = null;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003600 File Offset: 0x00001800
		private void DisposeNavigationModeFocusWatcher()
		{
			if (this._navigationModeFocusWatcher != null)
			{
				this._navigationModeFocusWatcher.KeyEvent -= this.OnNavigationModeFocusKeyEvent;
				this._navigationModeFocusWatcher.FocusedElementChanged -= this.OnNavigationModeFocusChanged;
				this._navigationModeFocusWatcher.Dispose();
				this._navigationModeFocusWatcher = null;
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003655 File Offset: 0x00001855
		private static global::Infragistics.Windows.DockManager.ContentPane GetDockManagerPane(global::System.Windows.IInputElement element, global::Infragistics.Windows.DockManager.XamDockManager dockManager)
		{
			return global::Infragistics.Windows.DockManager.ActivePaneManager.GetDockManagerPane(element as global::System.Windows.DependencyObject, dockManager);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00003663 File Offset: 0x00001863
		private static global::Infragistics.Windows.DockManager.ContentPane GetDockManagerPane(global::System.Windows.DependencyObject d, global::Infragistics.Windows.DockManager.XamDockManager dockManager)
		{
			if (d != null)
			{
				return global::Infragistics.Windows.DockManager.ActivePaneManager.GetDockManagerPane((d as global::Infragistics.Windows.DockManager.ContentPane) ?? ((global::Infragistics.Windows.DockManager.ContentPane)global::Infragistics.Windows.Utilities.GetAncestorFromType(d, typeof(global::Infragistics.Windows.DockManager.ContentPane), true, dockManager)), dockManager);
			}
			return null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003694 File Offset: 0x00001894
		private static global::Infragistics.Windows.DockManager.ContentPane GetDockManagerPane(global::Infragistics.Windows.DockManager.ContentPane pane, global::Infragistics.Windows.DockManager.XamDockManager dockManager)
		{
			while (pane != null && global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(pane) != dockManager)
			{
				global::System.Windows.DependencyObject parent = global::Infragistics.Windows.Utilities.GetParent(pane);
				if (parent == null)
				{
					return null;
				}
				pane = (global::Infragistics.Windows.Utilities.GetAncestorFromType(parent, typeof(global::Infragistics.Windows.DockManager.ContentPane), true, dockManager) as global::Infragistics.Windows.DockManager.ContentPane);
			}
			return pane;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000036D8 File Offset: 0x000018D8
		private global::Infragistics.Windows.DockManager.ContentPane GetFocusedPane(global::System.Windows.DependencyObject focusScopeChild)
		{
			global::Infragistics.Windows.DockManager.ContentPane result = null;
			if (focusScopeChild != null)
			{
				global::System.Windows.DependencyObject focusScope = global::System.Windows.Input.FocusManager.GetFocusScope(focusScopeChild);
				global::System.Windows.IInputElement element = (focusScope != null) ? global::System.Windows.Input.FocusManager.GetFocusedElement(focusScope) : null;
				result = global::Infragistics.Windows.DockManager.ActivePaneManager.GetDockManagerPane(element, this._dockManager);
			}
			return result;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000370C File Offset: 0x0000190C
		private global::Infragistics.Windows.DockManager.ContentPane GetKeyboardFocusedPane()
		{
			global::System.Windows.DependencyObject dependencyObject = global::System.Windows.Input.Keyboard.FocusedElement as global::System.Windows.DependencyObject;
			global::Infragistics.Windows.DockManager.ContentPane result = null;
			if (dependencyObject != null)
			{
				result = global::Infragistics.Windows.DockManager.ActivePaneManager.GetDockManagerPane(dependencyObject, this._dockManager);
			}
			else
			{
				foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane in this._panes)
				{
					if (contentPane.HasFocusInHwndHost() && contentPane.Visibility == global::System.Windows.Visibility.Visible)
					{
						result = contentPane;
						break;
					}
				}
			}
			return result;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000378C File Offset: 0x0000198C
		private global::Infragistics.Windows.DockManager.ContentPane GetNextActivePane(global::Infragistics.Windows.DockManager.ContentPane pane, bool next, global::Infragistics.Windows.DockManager.PaneFilterFlags filter)
		{
			return this.GetNextActivePane(pane, next, filter, this._dockManager.NavigationOrder, true, true);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000037A4 File Offset: 0x000019A4
		private global::Infragistics.Windows.DockManager.ContentPane GetNextActivePane(global::Infragistics.Windows.DockManager.ContentPane pane, bool next, global::Infragistics.Windows.DockManager.PaneFilterFlags filter, global::Infragistics.Windows.DockManager.PaneNavigationOrder order, bool wrap, bool ensureActivatable)
		{
			global::Infragistics.Windows.DockManager.ContentPane contentPane;
			if (order == global::Infragistics.Windows.DockManager.PaneNavigationOrder.VisibleOrder)
			{
				contentPane = pane;
				global::Infragistics.Windows.DockManager.ContentPane contentPane2 = null;
				while ((contentPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetNextPreviousPane(contentPane, wrap, next, this._dockManager, filter)) != null)
				{
					if (contentPane2 == contentPane)
					{
						contentPane = null;
						break;
					}
					if (contentPane2 == null)
					{
						contentPane2 = contentPane;
					}
					if (global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(contentPane) == this._dockManager && (!ensureActivatable || contentPane.CanActivate))
					{
						break;
					}
				}
			}
			else
			{
				contentPane = this.GetPaneInActivationOrder(pane, pane == null, next, filter, ensureActivatable);
				if (wrap && contentPane == null && pane != null)
				{
					contentPane = this.GetPaneInActivationOrder(null, true, next, filter, ensureActivatable);
				}
			}
			return contentPane;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003824 File Offset: 0x00001A24
		private global::System.Collections.Generic.LinkedListNode<global::Infragistics.Windows.DockManager.ContentPane> GetActivationOrderNode(global::System.Collections.Generic.LinkedListNode<global::Infragistics.Windows.DockManager.ContentPane> node, bool startWithNode, bool next, global::Infragistics.Windows.DockManager.PaneFilterFlags filter, bool ensureActivatable)
		{
			if (node == null)
			{
				node = (next ? this._panes.First : this._panes.Last);
				startWithNode = true;
			}
			if (node != null && !startWithNode)
			{
				node = (next ? node.Next : node.Previous);
			}
			global::Infragistics.Windows.DockManager.ContentPane contentPane = null;
			while (node != null)
			{
				global::Infragistics.Windows.DockManager.ContentPane value = node.Value;
				if (contentPane == value)
				{
					return null;
				}
				if (contentPane == null)
				{
					contentPane = value;
				}
				if (global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(value) == this._dockManager && (!ensureActivatable || value.CanActivate) && global::Infragistics.Windows.DockManager.DockManagerUtilities.MeetsCriteria(value, filter))
				{
					return node;
				}
				node = (next ? node.Next : node.Previous);
			}
			return null;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000038C0 File Offset: 0x00001AC0
		private global::Infragistics.Windows.DockManager.ContentPane GetPaneInActivationOrder(global::Infragistics.Windows.DockManager.ContentPane pane, bool startWithPane, bool next, global::Infragistics.Windows.DockManager.PaneFilterFlags filter, bool ensureActivatable)
		{
			global::System.Collections.Generic.LinkedListNode<global::Infragistics.Windows.DockManager.ContentPane> node = (pane != null) ? this._panes.Find(pane) : null;
			global::System.Collections.Generic.LinkedListNode<global::Infragistics.Windows.DockManager.ContentPane> activationOrderNode = this.GetActivationOrderNode(node, startWithPane, next, filter, ensureActivatable);
			if (activationOrderNode == null)
			{
				return null;
			}
			return activationOrderNode.Value;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000038FC File Offset: 0x00001AFC
		private bool IsKeyboardFocusWithinNestedParentFocusScope(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			global::System.Windows.DependencyObject parent = global::Infragistics.Windows.Utilities.GetParent(pane, true);
			global::System.Windows.DependencyObject dependencyObject = (parent != null) ? global::System.Windows.Input.FocusManager.GetFocusScope(parent) : null;
			global::System.Windows.IInputElement focusedElement = global::System.Windows.Input.Keyboard.FocusedElement;
			global::System.Windows.DependencyObject dependencyObject2 = focusedElement as global::System.Windows.DependencyObject;
			global::System.Windows.DependencyObject dependencyObject3 = (dependencyObject2 != null) ? global::System.Windows.Input.FocusManager.GetFocusScope(dependencyObject2) : null;
			if (dependencyObject3 != dependencyObject)
			{
				while (dependencyObject3 != null)
				{
					if (dependencyObject3 is global::Infragistics.Windows.DockManager.ContentPane && !global::Infragistics.Windows.Utilities.IsDescendantOf(pane, dependencyObject2, true, true))
					{
						return false;
					}
					dependencyObject3 = global::Infragistics.Windows.Utilities.GetParent(dependencyObject3);
					if (dependencyObject3 != null)
					{
						dependencyObject3 = global::System.Windows.Input.FocusManager.GetFocusScope(dependencyObject3);
						if (dependencyObject3 == dependencyObject)
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003978 File Offset: 0x00001B78
		private void MovePaneToHead(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			if (!this._isInNavigationMode)
			{
				this._panes.Remove(pane);
				this._panes.AddFirst(pane);
				pane.LastActivatedTime = global::System.DateTime.Now;
				return;
			}
			if (global::System.Windows.Input.Keyboard.IsKeyUp(global::System.Windows.Input.Key.LeftCtrl) && global::System.Windows.Input.Keyboard.IsKeyUp(global::System.Windows.Input.Key.RightCtrl) && global::System.Windows.Input.Keyboard.IsKeyUp(global::System.Windows.Input.Key.LeftAlt) && global::System.Windows.Input.Keyboard.IsKeyUp(global::System.Windows.Input.Key.RightCtrl))
			{
				this.IsInNavigationMode = false;
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000039E0 File Offset: 0x00001BE0
		private static void OnContentPaneGotKeyboardFocus(object sender, global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.ContentPane contentPane = sender as global::Infragistics.Windows.DockManager.ContentPane;
			global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(contentPane) as global::Infragistics.Windows.DockManager.PaneToolWindow;
			if (paneToolWindow != null)
			{
				paneToolWindow.LastActivePane = contentPane;
			}
			bool flag = e.OldFocus == null;
			bool suppressFlyoutDuringActivate = contentPane.SuppressFlyoutDuringActivate;
			try
			{
				if (flag)
				{
					contentPane.SuppressFlyoutDuringActivate = true;
				}
				contentPane.SetValue(global::Infragistics.Windows.DockManager.ActivePaneManager.IsKeyboardFocusWithinExPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
			}
			finally
			{
				if (flag)
				{
					contentPane.SuppressFlyoutDuringActivate = suppressFlyoutDuringActivate;
				}
			}
			global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(contentPane);
			if (parent == null)
			{
				return;
			}
			global::System.Windows.Input.FocusManager.GetFocusScope(parent);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003A68 File Offset: 0x00001C68
		private void OnContentPaneStateChanged(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			if (pane == null)
			{
				return;
			}
			bool flag = false;
			bool flag2 = false;
			if (this._dockManager != global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(pane))
			{
				flag = false;
			}
			else if (global::Infragistics.Windows.DockManager.ActivePaneManager.GetIsKeyboardFocusWithinEx(pane) || pane.HasFocusInHwndHost())
			{
				flag = true;
			}
			else if (pane.Visibility != global::System.Windows.Visibility.Visible)
			{
				flag = false;
			}
			else if (this.IsKeyboardFocusWithinNestedParentFocusScope(pane) && (this._activePane == null || !global::Infragistics.Windows.DockManager.ActivePaneManager.GetIsKeyboardFocusWithinEx(this._activePane)))
			{
				if (global::Infragistics.Windows.DockManager.DockManagerUtilities.IsFloating(global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(pane)))
				{
					global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(pane) as global::Infragistics.Windows.DockManager.PaneToolWindow;
					if (paneToolWindow.IsActive)
					{
						flag = true;
						flag2 = true;
					}
				}
				else if (this.IsDockManagerWindowActive || global::System.Windows.Window.GetWindow(pane) == null)
				{
					flag = true;
					flag2 = true;
				}
			}
			if (flag2 && this._activePaneFocusWatcher == null)
			{
				this.CreateActivePaneFocusWatcher();
			}
			else if (!flag2 && this._activePaneFocusWatcher != null)
			{
				this.DisposeActivePaneFocusWatcher();
			}
			if (flag)
			{
				this.SetActivePane(pane);
				return;
			}
			if (pane == this._activePane)
			{
				this.ClearActivePane();
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003B48 File Offset: 0x00001D48
		private void OnDockManagerLoadStateChanged(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.VerifyDockManagerWindowBindings();
			if (this._dockManager.IsLoaded)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, new global::Infragistics.Windows.DockManager.DockManagerUtilities.MethodInvoker(this.ProcessPaneRemoval));
				this.VerifyHasPreprocessHandler();
				this.VerifyActiveDocument(false);
				return;
			}
			this.DisposeActivePaneFocusWatcher();
			this.DisposeNavigationModeFocusWatcher();
			this.VerifyHasPreprocessHandler();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00003BA2 File Offset: 0x00001DA2
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private global::System.IDisposable CreatePreprocessHandler()
		{
			return new global::Infragistics.Windows.DockManager.ActivePaneManager.WeakPreprocessMessage(this);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00003BAA File Offset: 0x00001DAA
		private object OnEvaluateEndNavigationMode(object param)
		{
			if (param == this._navigationModeFocusWatcher && this._activePane == null)
			{
				this.IsInNavigationMode = false;
			}
			return null;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003BC8 File Offset: 0x00001DC8
		private void OnFocusHwndChanged()
		{
			foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane in this._panes)
			{
				if (contentPane.HasFocusInHwndHost())
				{
					this.OnContentPaneStateChanged(contentPane);
					return;
				}
			}
			if (this._activePane != null)
			{
				this.OnContentPaneStateChanged(this._activePane);
				return;
			}
			this.VerifyActivePane();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003C40 File Offset: 0x00001E40
		private void OnKeyboardFocusedElementChanged(object sender, global::System.Windows.RoutedPropertyChangedEventArgs<global::System.Windows.IInputElement> e)
		{
			if (this._activePane != null)
			{
				this.OnContentPaneStateChanged(this._activePane);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003C56 File Offset: 0x00001E56
		private void OnNavigationModeFocusChanged(object sender, global::System.Windows.RoutedPropertyChangedEventArgs<global::System.Windows.IInputElement> e)
		{
			if (e.NewValue == null)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.ApplicationIdle, new global::System.Windows.Threading.DispatcherOperationCallback(this.OnEvaluateEndNavigationMode), sender);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003C7C File Offset: 0x00001E7C
		private void OnNavigationModeFocusKeyEvent(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.RoutedEvent == global::System.Windows.Input.Keyboard.PreviewKeyUpEvent && e.KeyboardDevice.GetKeyStates(global::System.Windows.Input.Key.LeftAlt) == global::System.Windows.Input.KeyStates.None && e.KeyboardDevice.GetKeyStates(global::System.Windows.Input.Key.LeftCtrl) == global::System.Windows.Input.KeyStates.None && e.KeyboardDevice.GetKeyStates(global::System.Windows.Input.Key.RightAlt) == global::System.Windows.Input.KeyStates.None && e.KeyboardDevice.GetKeyStates(global::System.Windows.Input.Key.RightCtrl) == global::System.Windows.Input.KeyStates.None)
			{
				this.IsInNavigationMode = false;
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003CDC File Offset: 0x00001EDC
		private static void OnPaneGotOrLostFocus(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (e.OriginalSource == sender)
			{
				global::Infragistics.Windows.DockManager.ContentPane contentPane = sender as global::Infragistics.Windows.DockManager.ContentPane;
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(contentPane);
				if (dockManager != null)
				{
					dockManager.ActivePaneManager.OnContentPaneStateChanged(contentPane);
				}
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003D10 File Offset: 0x00001F10
		internal void OnPaneLocationChanged(global::Infragistics.Windows.DockManager.ContentPane pane, global::Infragistics.Windows.DockManager.PaneLocation oldLocation, global::Infragistics.Windows.DockManager.PaneLocation newLocation)
		{
			if (pane == this._activeDocument && newLocation != global::Infragistics.Windows.DockManager.PaneLocation.Document)
			{
				this.VerifyActivePane();
				return;
			}
			if (pane == this._activePane && newLocation == global::Infragistics.Windows.DockManager.PaneLocation.Document)
			{
				this.SetActivePaneImpl(this._activePane, this._activePane);
				return;
			}
			if (this._activeDocument == null && newLocation == global::Infragistics.Windows.DockManager.PaneLocation.Document)
			{
				this.VerifyActiveDocument(false);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003D64 File Offset: 0x00001F64
		internal void OnToolWindowActivationChanged(global::Infragistics.Windows.Controls.ToolWindow window)
		{
			this.OnWindowActivationChanged();
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003D6C File Offset: 0x00001F6C
		private void OnWindowActivationChanged()
		{
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.DockManager.DockManagerUtilities.MethodInvoker(this.OnWindowActivationChangedImpl));
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003D88 File Offset: 0x00001F88
		private void OnWindowActivationChangedImpl()
		{
			if (!this.IsDockManagerWindowActive)
			{
				if (this._activePane != null)
				{
					this.OnContentPaneStateChanged(this._activePane);
					return;
				}
			}
			else if (this._activePane == null)
			{
				global::Infragistics.Windows.DockManager.ContentPane focusedPane = this.GetFocusedPane(this._dockManager);
				if (focusedPane != null)
				{
					this.OnContentPaneStateChanged(focusedPane);
				}
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003DD1 File Offset: 0x00001FD1
		[global::System.Diagnostics.Conditional("DEBUG_ACTIVATION")]
		private static void Output(object value, string category)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003DD3 File Offset: 0x00001FD3
		[global::System.Diagnostics.Conditional("DEBUG_ACTIVATION")]
		private static void OutputIf(bool condition, object value, string category)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003DD8 File Offset: 0x00001FD8
		private void SetActivePane(global::Infragistics.Windows.DockManager.ContentPane newActivePane)
		{
			if (newActivePane == null && this._activePane != null)
			{
				if (this._pendingClearActivePane == null || this._pendingClearActivePane.Status == global::System.Windows.Threading.DispatcherOperationStatus.Completed)
				{
					this._pendingClearActivePane = this._dockManager.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.DockManager.DockManagerUtilities.PaneMethodInvoker(this.DelayedClearActivePane), this._activePane);
				}
				return;
			}
			this.SetActivePaneImpl(newActivePane, (newActivePane != null && newActivePane.IsDocument) ? newActivePane : this._activeDocument);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003E4C File Offset: 0x0000204C
		private void DelayedClearActivePane(global::Infragistics.Windows.DockManager.ContentPane oldActivePane)
		{
			if (oldActivePane == this._activePane && this._activePane != null && global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(oldActivePane) == this._dockManager && !global::Infragistics.Windows.DockManager.ActivePaneManager.GetIsKeyboardFocusWithinEx(oldActivePane))
			{
				this.SetActivePaneImpl(null, this._activeDocument);
				return;
			}
			this.VerifyActivePane();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003E8C File Offset: 0x0000208C
		private void SetActivePaneImpl(global::Infragistics.Windows.DockManager.ContentPane newActivePane, global::Infragistics.Windows.DockManager.ContentPane newActiveDocument)
		{
			if (this._pendingClearActivePane != null)
			{
				this._pendingClearActivePane.Abort();
				this._pendingClearActivePane = null;
			}
			global::Infragistics.Windows.DockManager.ContentPane activePane = this._activePane;
			global::Infragistics.Windows.DockManager.ContentPane activeDocument = this._activeDocument;
			global::Infragistics.Windows.DockManager.DocumentContentHost documentContentHost = this._dockManager.DocumentContentHost;
			bool flag = newActivePane != activePane;
			bool flag2 = newActiveDocument != activeDocument;
			if (!flag && !flag2)
			{
				return;
			}
			this._activePane = newActivePane;
			if (flag2)
			{
				this._activeDocument = newActiveDocument;
			}
			if (newActivePane != null && flag)
			{
				this.MovePaneToHead(newActivePane);
			}
			else if (newActiveDocument != null && activePane == null && newActivePane == null && this._panes.Count > 0 && activeDocument == this._panes.First.Value)
			{
				this.MoveToFront(newActiveDocument);
			}
			base.SetValue(global::Infragistics.Windows.DockManager.ActivePaneManager.ActivePanePropertyKey, newActivePane);
			if (flag2)
			{
				base.SetValue(global::Infragistics.Windows.DockManager.ActivePaneManager.ActiveDocumentPropertyKey, newActiveDocument);
			}
			if (flag2)
			{
				if (activeDocument != null)
				{
					activeDocument.ClearValue(global::Infragistics.Windows.DockManager.ActivePaneManager.IsActiveDocumentPropertyKey);
				}
				if (newActiveDocument != null)
				{
					newActiveDocument.SetValue(global::Infragistics.Windows.DockManager.ActivePaneManager.IsActiveDocumentPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				}
			}
			if (flag)
			{
				if (activePane != null)
				{
					activePane.ClearValue(global::Infragistics.Windows.DockManager.ActivePaneManager.IsActivePanePropertyKey);
				}
				if (newActivePane != null)
				{
					newActivePane.SetValue(global::Infragistics.Windows.DockManager.ActivePaneManager.IsActivePanePropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				}
			}
			if (flag2 && documentContentHost != null)
			{
				documentContentHost.SetValue(global::Infragistics.Windows.DockManager.ActivePaneManager.ActiveDocumentPropertyKey, newActiveDocument);
			}
			this._dockManager.SetValue(global::Infragistics.Windows.DockManager.ActivePaneManager.ActivePanePropertyKey, newActivePane);
			if (flag && activePane != null)
			{
				activePane.ClearValue(global::Infragistics.Windows.DockManager.ActivePaneManager.IsKeyboardFocusWithinExPropertyKey);
			}
			if (flag)
			{
				global::Infragistics.Windows.DockManager.ContentPane contentPane = activePane;
				global::Infragistics.Windows.DockManager.ContentPane currentFlyoutPane = this._dockManager.CurrentFlyoutPane;
				if (contentPane == null && currentFlyoutPane != null && currentFlyoutPane != this._dockManager.ActivePane)
				{
					contentPane = this._dockManager.CurrentFlyoutPane;
				}
				if (global::System.Windows.Input.Keyboard.FocusedElement == null && this.GetKeyboardFocusedPane() == null)
				{
					contentPane = null;
				}
				else if (contentPane == null && this._lastActivePane != null)
				{
					contentPane = (global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._lastActivePane) as global::Infragistics.Windows.DockManager.ContentPane);
					if (contentPane == newActivePane)
					{
						contentPane = null;
					}
					this._lastActivePane = null;
				}
				if (contentPane != null)
				{
					this._dockManager.HideFlyout(contentPane, false, true, true, false, true);
					this._lastActivePane = null;
				}
				if (activePane != null && newActivePane == null && global::System.Windows.Input.Keyboard.FocusedElement == null)
				{
					this._lastActivePane = new global::System.WeakReference(activePane);
				}
				if (newActivePane != null && newActivePane == this._activePane)
				{
					switch (global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(newActivePane))
					{
					case global::Infragistics.Windows.DockManager.PaneLocation.Floating:
					case global::Infragistics.Windows.DockManager.PaneLocation.FloatingOnly:
					{
						global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(newActivePane) as global::Infragistics.Windows.DockManager.PaneToolWindow;
						if (paneToolWindow != null)
						{
							paneToolWindow.LastActivePane = newActivePane;
						}
						break;
					}
					case global::Infragistics.Windows.DockManager.PaneLocation.Unpinned:
						if (!newActivePane.SuppressFlyoutDuringActivate && !this._dockManager.IsShowFlyoutSuspended)
						{
							this._dockManager.ShowFlyout(newActivePane, false, false);
						}
						break;
					}
				}
			}
			if (flag && newActivePane != null)
			{
				global::System.Windows.FrameworkElement focusedHwndHost = newActivePane.GetFocusedHwndHost();
				if (focusedHwndHost != null && global::Infragistics.Windows.Utilities.IsDescendantOf(this._dockManager, focusedHwndHost, true))
				{
					this._dockManager.EnsureIsFocusedElement(focusedHwndHost);
				}
			}
			if (flag && this._activePane == newActivePane && newActivePane != null && global::Infragistics.Windows.DockManager.DockManagerUtilities.IsFloating(newActivePane.PaneLocation))
			{
				global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow2 = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(newActivePane) as global::Infragistics.Windows.DockManager.PaneToolWindow;
				if (paneToolWindow2 != null && paneToolWindow2.IsActive)
				{
					paneToolWindow2.ClearDragHelperFocusedElement();
				}
			}
			if (flag2 && documentContentHost != null)
			{
				documentContentHost.RaiseActiveDocumentChanged(new global::System.Windows.RoutedPropertyChangedEventArgs<global::Infragistics.Windows.DockManager.ContentPane>(activeDocument, newActiveDocument));
			}
			if (flag)
			{
				this._dockManager.RaiseActivePaneChanged(new global::System.Windows.RoutedPropertyChangedEventArgs<global::Infragistics.Windows.DockManager.ContentPane>(activePane, newActivePane));
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004184 File Offset: 0x00002384
		private void VerifyDockManagerWindowBindings()
		{
			global::System.Windows.Window window = global::System.Windows.Window.GetWindow(this._dockManager);
			if (window == null)
			{
				global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Infragistics.Windows.DockManager.ActivePaneManager.IsDockManagerWindowActiveProperty);
				return;
			}
			global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Windows.DockManager.ActivePaneManager.IsDockManagerWindowActiveProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.Window.IsActiveProperty, global::System.Windows.Data.BindingMode.OneWay, window));
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000041C4 File Offset: 0x000023C4
		internal void VerifyActiveDocument(bool force)
		{
			if (this._dockManager.IsLoaded || force)
			{
				global::Infragistics.Windows.DockManager.ContentPane contentPane = this._activeDocument;
				global::Infragistics.Windows.DockManager.DocumentContentHost documentContentHost = this._dockManager.DocumentContentHost;
				if (documentContentHost != null && contentPane == null)
				{
					global::Infragistics.Windows.DockManager.ContentPane focusedPane = this.GetFocusedPane(documentContentHost);
					if (focusedPane != null && focusedPane.IsDocument)
					{
						contentPane = focusedPane;
					}
					else
					{
						global::Infragistics.Windows.DockManager.ContentPane contentPane2 = null;
						while ((contentPane = this.GetPaneInActivationOrder(contentPane, contentPane2 == null, true, global::Infragistics.Windows.DockManager.PaneFilterFlags.Document, true)) != null)
						{
							if (contentPane == contentPane2)
							{
								contentPane = null;
								break;
							}
							if (contentPane2 == null)
							{
								contentPane2 = contentPane;
							}
							if (contentPane.IsVisible)
							{
								global::System.Windows.DependencyObject parent = global::System.Windows.LogicalTreeHelper.GetParent(contentPane);
								if (!(parent is global::Infragistics.Windows.DockManager.TabGroupPane))
								{
									break;
								}
								global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = parent as global::Infragistics.Windows.DockManager.TabGroupPane;
								global::System.Windows.Controls.TabItem tabItem = tabGroupPane.ItemContainerGenerator.ContainerFromItem(contentPane) as global::System.Windows.Controls.TabItem;
								if (tabItem != null && tabItem.IsSelected)
								{
									break;
								}
							}
						}
					}
				}
				if (this._activeDocument != contentPane)
				{
					this.SetActivePaneImpl(this._activePane, contentPane);
				}
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00004294 File Offset: 0x00002494
		private void VerifyTabIsSelected(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			if (pane == null)
			{
				return;
			}
			global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = global::System.Windows.LogicalTreeHelper.GetParent(pane) as global::Infragistics.Windows.DockManager.TabGroupPane;
			if (tabGroupPane == null)
			{
				return;
			}
			int selectedIndex = tabGroupPane.Items.IndexOf(pane);
			tabGroupPane.SelectedIndex = selectedIndex;
		}

		// Token: 0x0400000B RID: 11
		private global::System.Collections.Generic.LinkedList<global::Infragistics.Windows.DockManager.ContentPane> _panes;

		// Token: 0x0400000C RID: 12
		private global::Infragistics.Windows.DockManager.XamDockManager _dockManager;

		// Token: 0x0400000D RID: 13
		private bool _isInNavigationMode;

		// Token: 0x0400000E RID: 14
		private global::Infragistics.Windows.DockManager.ContentPane _activePane;

		// Token: 0x0400000F RID: 15
		private global::Infragistics.Windows.DockManager.ContentPane _activeDocument;

		// Token: 0x04000010 RID: 16
		private int _navigationModeVersion;

		// Token: 0x04000011 RID: 17
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane> _panesToRemove;

		// Token: 0x04000012 RID: 18
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPanePlaceholder> _placeholdersToRemove;

		// Token: 0x04000013 RID: 19
		private global::Infragistics.Windows.DockManager.KeyEventFocusWatcher _navigationModeFocusWatcher;

		// Token: 0x04000014 RID: 20
		private global::Infragistics.Windows.DockManager.FocusWatcher _activePaneFocusWatcher;

		// Token: 0x04000015 RID: 21
		private int _suspendVerificationCount;

		// Token: 0x04000016 RID: 22
		private global::System.WeakReference _lastActivePane;

		// Token: 0x04000017 RID: 23
		private global::System.IDisposable _preprocessHandler;

		// Token: 0x04000018 RID: 24
		private static bool _canCreatePreprocessHandler = true;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Threading.DispatcherOperation _pendingClearActivePane;

		// Token: 0x0400001A RID: 26
		private static readonly global::System.Windows.DependencyPropertyKey ActiveDocumentPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("ActiveDocument", typeof(global::Infragistics.Windows.DockManager.ContentPane), typeof(global::Infragistics.Windows.DockManager.ActivePaneManager), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400001B RID: 27
		public static readonly global::System.Windows.DependencyProperty ActiveDocumentProperty = global::Infragistics.Windows.DockManager.ActivePaneManager.ActiveDocumentPropertyKey.DependencyProperty;

		// Token: 0x0400001C RID: 28
		private static readonly global::System.Windows.DependencyPropertyKey ActivePanePropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("ActivePane", typeof(global::Infragistics.Windows.DockManager.ContentPane), typeof(global::Infragistics.Windows.DockManager.ActivePaneManager), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400001D RID: 29
		public static readonly global::System.Windows.DependencyProperty ActivePaneProperty = global::Infragistics.Windows.DockManager.ActivePaneManager.ActivePanePropertyKey.DependencyProperty;

		// Token: 0x0400001E RID: 30
		internal static readonly global::System.Windows.DependencyPropertyKey IsActiveDocumentPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsActiveDocument", typeof(bool), typeof(global::Infragistics.Windows.DockManager.ActivePaneManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x0400001F RID: 31
		public static readonly global::System.Windows.DependencyProperty IsActiveDocumentProperty = global::Infragistics.Windows.DockManager.ActivePaneManager.IsActiveDocumentPropertyKey.DependencyProperty;

		// Token: 0x04000020 RID: 32
		internal static readonly global::System.Windows.DependencyPropertyKey IsActivePanePropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsActivePane", typeof(bool), typeof(global::Infragistics.Windows.DockManager.ActivePaneManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x04000021 RID: 33
		public static readonly global::System.Windows.DependencyProperty IsActivePaneProperty = global::Infragistics.Windows.DockManager.ActivePaneManager.IsActivePanePropertyKey.DependencyProperty;

		// Token: 0x04000022 RID: 34
		private static readonly global::System.Windows.DependencyProperty IsDockManagerWindowActiveProperty = global::System.Windows.DependencyProperty.Register("IsDockManagerWindowActive", typeof(bool), typeof(global::Infragistics.Windows.DockManager.ActivePaneManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.ActivePaneManager.OnIsDockManagerWindowActiveChanged)));

		// Token: 0x04000023 RID: 35
		public static readonly global::System.Windows.DependencyProperty FocusWatcherProperty = global::System.Windows.DependencyProperty.RegisterAttached("FocusWatcher", typeof(global::Infragistics.Windows.DockManager.FocusWatcher), typeof(global::Infragistics.Windows.DockManager.ActivePaneManager), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000024 RID: 36
		private static readonly global::System.Windows.DependencyPropertyKey IsKeyboardFocusWithinExPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsKeyboardFocusWithinEx", typeof(bool), typeof(global::Infragistics.Windows.DockManager.ActivePaneManager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.ActivePaneManager.OnIsKeyboardFocusWithinExChanged)));

		// Token: 0x04000025 RID: 37
		public static readonly global::System.Windows.DependencyProperty IsKeyboardFocusWithinExProperty = global::Infragistics.Windows.DockManager.ActivePaneManager.IsKeyboardFocusWithinExPropertyKey.DependencyProperty;

		// Token: 0x02000009 RID: 9
		private class PaneEnumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DockManager.ContentPane>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x0600006E RID: 110 RVA: 0x000042C9 File Offset: 0x000024C9
			internal PaneEnumerator(global::Infragistics.Windows.DockManager.ActivePaneManager manager) : this(manager, global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisible)
			{
			}

			// Token: 0x0600006F RID: 111 RVA: 0x000042D4 File Offset: 0x000024D4
			internal PaneEnumerator(global::Infragistics.Windows.DockManager.ActivePaneManager manager, global::Infragistics.Windows.DockManager.PaneFilterFlags filter) : this(manager, filter, manager._dockManager.NavigationOrder)
			{
			}

			// Token: 0x06000070 RID: 112 RVA: 0x000042E9 File Offset: 0x000024E9
			internal PaneEnumerator(global::Infragistics.Windows.DockManager.ActivePaneManager manager, global::Infragistics.Windows.DockManager.PaneFilterFlags filter, global::Infragistics.Windows.DockManager.PaneNavigationOrder navigationOrder) : this(manager, filter, navigationOrder, true)
			{
			}

			// Token: 0x06000071 RID: 113 RVA: 0x000042F5 File Offset: 0x000024F5
			internal PaneEnumerator(global::Infragistics.Windows.DockManager.ActivePaneManager manager, global::Infragistics.Windows.DockManager.PaneFilterFlags filter, global::Infragistics.Windows.DockManager.PaneNavigationOrder navigationOrder, bool ensureActivatable)
			{
				global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(manager, "manager");
				this._manager = manager;
				this._filter = filter;
				this._order = navigationOrder;
				this._ensureActivatable = ensureActivatable;
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000072 RID: 114 RVA: 0x00004325 File Offset: 0x00002525
			public global::Infragistics.Windows.DockManager.ContentPane Current
			{
				get
				{
					if (this._isComplete == null)
					{
						throw new global::System.InvalidOperationException();
					}
					if (this._isComplete.Value)
					{
						throw new global::System.InvalidOperationException();
					}
					return this._current;
				}
			}

			// Token: 0x06000073 RID: 115 RVA: 0x00004353 File Offset: 0x00002553
			public void Dispose()
			{
				this._current = null;
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000074 RID: 116 RVA: 0x0000435C File Offset: 0x0000255C
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x06000075 RID: 117 RVA: 0x00004364 File Offset: 0x00002564
			public bool MoveNext()
			{
				if (this._isComplete == null || !this._isComplete.Value)
				{
					this._current = this._manager.GetNextActivePane(this._current, true, this._filter, this._order, false, this._ensureActivatable);
					this._isComplete = new bool?(this._current == null);
				}
				return !this._isComplete.Value;
			}

			// Token: 0x06000076 RID: 118 RVA: 0x000043D8 File Offset: 0x000025D8
			public void Reset()
			{
				this._isComplete = null;
				this._current = null;
			}

			// Token: 0x04000026 RID: 38
			private global::Infragistics.Windows.DockManager.ContentPane _current;

			// Token: 0x04000027 RID: 39
			private global::Infragistics.Windows.DockManager.ActivePaneManager _manager;

			// Token: 0x04000028 RID: 40
			private bool? _isComplete;

			// Token: 0x04000029 RID: 41
			private global::Infragistics.Windows.DockManager.PaneFilterFlags _filter;

			// Token: 0x0400002A RID: 42
			private global::Infragistics.Windows.DockManager.PaneNavigationOrder _order;

			// Token: 0x0400002B RID: 43
			private bool _ensureActivatable;
		}

		// Token: 0x0200000A RID: 10
		private class LastActivatedTimeComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DockManager.ContentPane>
		{
			// Token: 0x06000077 RID: 119 RVA: 0x000043ED File Offset: 0x000025ED
			internal LastActivatedTimeComparer(global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> previousPaneOrder)
			{
				this._previousPaneOrder = previousPaneOrder;
			}

			// Token: 0x06000078 RID: 120 RVA: 0x000043FC File Offset: 0x000025FC
			public int Compare(global::Infragistics.Windows.DockManager.ContentPane x, global::Infragistics.Windows.DockManager.ContentPane y)
			{
				if (x == y && x == null)
				{
					return 0;
				}
				if (x == null)
				{
					return -1;
				}
				if (y == null)
				{
					return 1;
				}
				int num = x.LastActivatedTime.CompareTo(y.LastActivatedTime);
				if (num == 0 && this._previousPaneOrder != null)
				{
					int num2 = this._previousPaneOrder.IndexOf(x);
					int num3 = this._previousPaneOrder.IndexOf(y);
					if (num2 != num3)
					{
						if (num3 < 0)
						{
							num = 1;
						}
						else if (num2 < 0)
						{
							num = -1;
						}
						else
						{
							num = num3.CompareTo(num2);
						}
					}
				}
				return num;
			}

			// Token: 0x0400002C RID: 44
			private global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> _previousPaneOrder;
		}

		// Token: 0x0200000B RID: 11
		private class WeakPreprocessMessage : global::System.WeakReference, global::System.IDisposable
		{
			// Token: 0x06000079 RID: 121 RVA: 0x00004474 File Offset: 0x00002674
			internal WeakPreprocessMessage(global::Infragistics.Windows.DockManager.ActivePaneManager manager) : base(manager)
			{
				global::System.Windows.Interop.ComponentDispatcher.ThreadPreprocessMessage += this.OnThreadPreprocessMessage;
			}

			// Token: 0x0600007A RID: 122
			[global::System.Security.SuppressUnmanagedCodeSecurity]
			[global::System.Runtime.InteropServices.DllImport("user32.dll")]
			private static extern global::System.IntPtr GetFocus();

			// Token: 0x0600007B RID: 123 RVA: 0x00004490 File Offset: 0x00002690
			private void OnThreadPreprocessMessage(ref global::System.Windows.Interop.MSG msg, ref bool handled)
			{
				global::System.IntPtr focus = global::Infragistics.Windows.DockManager.ActivePaneManager.WeakPreprocessMessage.GetFocus();
				if (focus != this._focusHwnd)
				{
					global::Infragistics.Windows.DockManager.ActivePaneManager activePaneManager = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this) as global::Infragistics.Windows.DockManager.ActivePaneManager;
					if (activePaneManager != null)
					{
						this._focusHwnd = focus;
						activePaneManager.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.DockManager.DockManagerUtilities.MethodInvoker(activePaneManager.OnFocusHwndChanged));
						return;
					}
					this.Dispose();
				}
			}

			// Token: 0x0600007C RID: 124 RVA: 0x000044E8 File Offset: 0x000026E8
			public void Dispose()
			{
				try
				{
					global::System.Security.Permissions.UIPermission uipermission = new global::System.Security.Permissions.UIPermission(global::System.Security.Permissions.PermissionState.Unrestricted);
					try
					{
						uipermission.Assert();
					}
					catch (global::System.InvalidOperationException)
					{
					}
					global::System.Windows.Interop.ComponentDispatcher.ThreadPreprocessMessage -= this.OnThreadPreprocessMessage;
				}
				catch (global::System.Security.SecurityException)
				{
				}
			}

			// Token: 0x0400002D RID: 45
			private global::System.IntPtr _focusHwnd;
		}

		// Token: 0x0200000D RID: 13
		private class PaneFocusWatcher : global::Infragistics.Windows.DockManager.FocusWatcher
		{
			// Token: 0x0600008E RID: 142 RVA: 0x000048D3 File Offset: 0x00002AD3
			internal PaneFocusWatcher(global::Infragistics.Windows.DockManager.ContentPane pane)
			{
				global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(pane, "pane");
				this._pane = pane;
			}

			// Token: 0x0600008F RID: 143 RVA: 0x000048F0 File Offset: 0x00002AF0
			protected override void OnFocusElementChanged(global::System.Windows.IInputElement oldElement, global::System.Windows.IInputElement newElement)
			{
				global::Infragistics.Windows.DockManager.XamDockManager xamDockManager = (newElement is global::System.Windows.DependencyObject) ? global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager((global::System.Windows.DependencyObject)newElement) : null;
				global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this._pane);
				bool flag = true;
				if (xamDockManager != null && dockManager != null)
				{
					global::Infragistics.Windows.DockManager.ContentPane dockManagerPane = global::Infragistics.Windows.DockManager.ActivePaneManager.GetDockManagerPane(newElement, dockManager);
					flag = (dockManagerPane != this._pane);
				}
				if (flag)
				{
					this._pane.ClearValue(global::Infragistics.Windows.DockManager.ActivePaneManager.IsKeyboardFocusWithinExPropertyKey);
				}
				base.OnFocusElementChanged(oldElement, newElement);
			}

			// Token: 0x04000033 RID: 51
			private global::Infragistics.Windows.DockManager.ContentPane _pane;
		}
	}
}
