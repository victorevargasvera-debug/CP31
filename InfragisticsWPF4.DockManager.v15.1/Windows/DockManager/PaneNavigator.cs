using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using Infragistics.Windows.Commands;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x0200007F RID: 127
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class PaneNavigator : global::System.Windows.Controls.Control
	{
		// Token: 0x06000467 RID: 1127 RVA: 0x00018B34 File Offset: 0x00016D34
		static PaneNavigator()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneNavigator), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DockManager.PaneNavigator)));
			global::System.Windows.Input.FocusManager.IsFocusScopeProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneNavigator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.PaneNavigator), global::System.Windows.Controls.Primitives.Selector.SelectedEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.DockManager.PaneNavigator.OnListBoxItemSelected), true);
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.DockManager.PaneNavigator), new global::System.Windows.Input.CommandBinding(global::Infragistics.Windows.DockManager.ContentPaneCommands.ActivatePane, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Infragistics.Windows.DockManager.PaneNavigator.OnExecuteCommand), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.DockManager.PaneNavigator.OnCanExecuteCommand)));
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00018C81 File Offset: 0x00016E81
		public PaneNavigator() : this(null)
		{
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00018C8C File Offset: 0x00016E8C
		private PaneNavigator(global::Infragistics.Windows.DockManager.XamDockManager dockManager)
		{
			this._dockManager = dockManager;
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane>();
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane>();
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> list3 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane>();
			if (dockManager != null)
			{
				foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane in dockManager.ActivePaneManager.GetPanes(global::Infragistics.Windows.DockManager.PaneFilterFlags.AllVisible, dockManager.NavigationOrder, true))
				{
					if (contentPane.IsDocument)
					{
						list2.Add(contentPane);
					}
					else
					{
						list.Add(contentPane);
					}
					list3.Add(contentPane);
				}
			}
			this._panes = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DockManager.ContentPane>(list);
			this._documents = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DockManager.ContentPane>(list2);
			this._allPanes = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DockManager.ContentPane>(list3);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00018D4C File Offset: 0x00016F4C
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusWithinChanged(e);
			if (false.Equals(e.NewValue))
			{
				this.Close(true);
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00018D7C File Offset: 0x00016F7C
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnKeyDown(e);
			global::System.Windows.Input.Key key = (e.Key == global::System.Windows.Input.Key.System) ? e.SystemKey : e.Key;
			if (key == global::System.Windows.Input.Key.Escape)
			{
				this.Close(true);
				e.Handled = true;
				return;
			}
			if (key == global::System.Windows.Input.Key.Return)
			{
				this.Close(false);
				e.Handled = true;
				return;
			}
			if (key == global::System.Windows.Input.Key.F7 && (global::System.Windows.Input.Keyboard.Modifiers & (global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Windows)) == global::System.Windows.Input.ModifierKeys.Alt)
			{
				global::System.Windows.IInputElement focusedElement = global::System.Windows.Input.Keyboard.FocusedElement;
				if (focusedElement != null)
				{
					global::System.Windows.Input.FocusNavigationDirection focusNavigationDirection = ((global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Shift) == global::System.Windows.Input.ModifierKeys.None) ? global::System.Windows.Input.FocusNavigationDirection.Next : global::System.Windows.Input.FocusNavigationDirection.Previous;
					global::System.Windows.Input.TraversalRequest request = new global::System.Windows.Input.TraversalRequest(focusNavigationDirection);
					if (global::Infragistics.Windows.DockManager.DockManagerUtilities.MoveFocus(focusedElement as global::System.Windows.DependencyObject, request))
					{
						e.Handled = true;
					}
				}
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00018E18 File Offset: 0x00017018
		protected override void OnPreviewKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			base.OnPreviewKeyUp(e);
			if (this.IsOpen && this._closeWhenModifiersReleased)
			{
				switch ((e.Key == global::System.Windows.Input.Key.System) ? e.SystemKey : e.Key)
				{
				case global::System.Windows.Input.Key.LeftCtrl:
				case global::System.Windows.Input.Key.RightCtrl:
				case global::System.Windows.Input.Key.LeftAlt:
				case global::System.Windows.Input.Key.RightAlt:
					if (e.KeyboardDevice.IsKeyUp(global::System.Windows.Input.Key.LeftAlt) && e.KeyboardDevice.IsKeyUp(global::System.Windows.Input.Key.LeftCtrl) && e.KeyboardDevice.IsKeyUp(global::System.Windows.Input.Key.RightAlt) && e.KeyboardDevice.IsKeyUp(global::System.Windows.Input.Key.RightCtrl))
					{
						this.Close(false);
					}
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00018EBA File Offset: 0x000170BA
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DockManager.ContentPane> AllPanes
		{
			get
			{
				return this._allPanes;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x00018EC2 File Offset: 0x000170C2
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DockManager.ContentPane> Documents
		{
			get
			{
				return this._documents;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00018ECA File Offset: 0x000170CA
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DockManager.ContentPane> Panes
		{
			get
			{
				return this._panes;
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00018ED4 File Offset: 0x000170D4
		private static void OnSelectedPaneChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.PaneNavigator paneNavigator = (global::Infragistics.Windows.DockManager.PaneNavigator)d;
			if (e.NewValue != null && !paneNavigator.AllPanes.Contains((global::Infragistics.Windows.DockManager.ContentPane)e.NewValue))
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_InvalidateNavigatorSelectedPane"));
			}
			global::Infragistics.Windows.DockManager.ContentPane contentPane = e.NewValue as global::Infragistics.Windows.DockManager.ContentPane;
			bool flag = contentPane != null && contentPane.ActualWidth / contentPane.ActualHeight > 1.2;
			bool flag2 = contentPane != null && contentPane.IsDocument;
			paneNavigator.SetValue(global::Infragistics.Windows.DockManager.PaneNavigator.SelectedPaneAspectRatioIsWidePropertyKey, flag);
			paneNavigator.SetValue(global::Infragistics.Windows.DockManager.PaneNavigator.SelectedPaneIsDocumentPropertyKey, flag2);
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x00018F75 File Offset: 0x00017175
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00018F87 File Offset: 0x00017187
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.ContentPane SelectedPane
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.ContentPane)base.GetValue(global::Infragistics.Windows.DockManager.PaneNavigator.SelectedPaneProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.PaneNavigator.SelectedPaneProperty, value);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00018F95 File Offset: 0x00017195
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool SelectedPaneAspectRatioIsWide
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.PaneNavigator.SelectedPaneAspectRatioIsWideProperty);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00018FA7 File Offset: 0x000171A7
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool SelectedPaneIsDocument
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.PaneNavigator.SelectedPaneIsDocumentProperty);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00018FB9 File Offset: 0x000171B9
		internal bool IsOpen
		{
			get
			{
				return this._popup != null && this._popup.IsOpen;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x00018FD0 File Offset: 0x000171D0
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x00018FD8 File Offset: 0x000171D8
		private global::System.Windows.Controls.Primitives.Popup Popup
		{
			get
			{
				return this._popup;
			}
			set
			{
				if (value != this._popup)
				{
					if (this._popup != null)
					{
						this._popup.Opened -= this.OnPopupOpened;
					}
					this._popup = value;
					if (this._popup != null)
					{
						this._popup.Opened += this.OnPopupOpened;
					}
				}
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00019034 File Offset: 0x00017234
		internal void Close(bool cancel)
		{
			if (this.IsOpen)
			{
				global::System.Windows.Controls.Primitives.Popup popup = this.Popup;
				this.Popup = null;
				popup.IsOpen = false;
				if (!cancel && this.SelectedPane != null)
				{
					this.SelectedPane.ActivateInternal(false, true, true);
					return;
				}
				if (base.IsKeyboardFocusWithin)
				{
					global::Infragistics.Windows.DockManager.ContentPane lastActivePane = this._dockManager.ActivePaneManager.GetLastActivePane();
					if (lastActivePane != null)
					{
						lastActivePane.ActivateInternal(true);
						return;
					}
					global::System.Windows.Input.Keyboard.Focus(null);
				}
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x000190A8 File Offset: 0x000172A8
		internal static void ProcessKeyDown(global::Infragistics.Windows.DockManager.XamDockManager dockManager, global::System.Windows.Input.KeyEventArgs e)
		{
			global::System.Windows.Input.Key key = (e.Key == global::System.Windows.Input.Key.System) ? e.SystemKey : e.Key;
			bool flag = false;
			global::System.Windows.Input.Key key2 = key;
			if (key2 != global::System.Windows.Input.Key.Tab)
			{
				if (key2 != global::System.Windows.Input.Key.F7)
				{
					return;
				}
				if (global::System.Windows.Input.ModifierKeys.Alt != (global::System.Windows.Input.Keyboard.Modifiers & (global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Windows)))
				{
					return;
				}
				flag = true;
			}
			else if (global::System.Windows.Input.ModifierKeys.Control != (global::System.Windows.Input.Keyboard.Modifiers & (global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Windows)))
			{
				return;
			}
			if (!dockManager.ActivePaneManager.HasActivatablePanes)
			{
				return;
			}
			bool flag2 = global::System.Windows.Input.ModifierKeys.Shift == (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Shift);
			global::Infragistics.Windows.DockManager.PaneNavigatorStartInfo paneNavigatorStartInfo = new global::Infragistics.Windows.DockManager.PaneNavigatorStartInfo();
			paneNavigatorStartInfo.ActivationOffset = (flag2 ? -1 : 1);
			paneNavigatorStartInfo.StartWithDocuments = new bool?(!flag);
			paneNavigatorStartInfo.CloseWhenModifiersRelease = true;
			global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo = new global::Infragistics.Windows.Commands.ExecuteCommandInfo(global::Infragistics.Windows.DockManager.DockManagerCommands.ShowPaneNavigator, paneNavigatorStartInfo, dockManager);
			if (((global::Infragistics.Windows.Commands.ICommandHost)dockManager).Execute(commandInfo))
			{
				e.Handled = true;
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00019160 File Offset: 0x00017360
		internal static bool Show(global::Infragistics.Windows.DockManager.XamDockManager dockManager, global::Infragistics.Windows.DockManager.PaneNavigatorStartInfo startInfo)
		{
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(dockManager, "dockManager");
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(startInfo, "startInfo");
			global::Infragistics.Windows.DockManager.PaneNavigator paneNavigator = new global::Infragistics.Windows.DockManager.PaneNavigator(dockManager);
			global::System.Windows.Controls.Primitives.Popup popup = new global::System.Windows.Controls.Primitives.Popup();
			popup.PlacementTarget = dockManager;
			popup.Placement = global::System.Windows.Controls.Primitives.PlacementMode.Center;
			popup.Child = paneNavigator;
			popup.StaysOpen = false;
			popup.AllowsTransparency = true;
			global::Infragistics.Windows.DockManager.ContentPane contentPane;
			if (startInfo.StartWithDocuments == null)
			{
				if ((contentPane = dockManager.ActivePane) == null)
				{
					contentPane = (dockManager.ActivePaneManager.GetActiveDocument() ?? dockManager.ActivePaneManager.GetLastActivePane());
				}
			}
			else
			{
				contentPane = dockManager.ActivePaneManager.GetInitialPaneNavigatorItem(startInfo.StartWithDocuments.Value, startInfo.ActivationOffset);
			}
			global::Infragistics.Windows.DockManager.ContentPane selectedPane = contentPane;
			paneNavigator.Popup = popup;
			paneNavigator._closeWhenModifiersReleased = startInfo.CloseWhenModifiersRelease;
			paneNavigator.SelectedPane = selectedPane;
			popup.IsOpen = true;
			paneNavigator.ClearValue(global::Infragistics.Windows.DockManager.PaneNavigator.SelectedPaneProperty);
			dockManager.TransferFocusOutOfHwndHost();
			paneNavigator.Focus();
			if (!paneNavigator.IsKeyboardFocusWithin)
			{
				paneNavigator.Close(true);
			}
			return paneNavigator.IsKeyboardFocusWithin;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00019258 File Offset: 0x00017458
		private static void OnCanExecuteCommand(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			if (e.Command == global::Infragistics.Windows.DockManager.ContentPaneCommands.ActivatePane)
			{
				global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject;
				global::Infragistics.Windows.DockManager.ContentPane contentPane = (dependencyObject != null) ? (dependencyObject.GetValue(global::System.Windows.FrameworkElement.DataContextProperty) as global::Infragistics.Windows.DockManager.ContentPane) : null;
				e.Handled = true;
				e.CanExecute = (contentPane != null && contentPane.CanActivate);
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x000192B0 File Offset: 0x000174B0
		private static void OnExecuteCommand(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.PaneNavigator paneNavigator = sender as global::Infragistics.Windows.DockManager.PaneNavigator;
			if (e.Command == global::Infragistics.Windows.DockManager.ContentPaneCommands.ActivatePane)
			{
				global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject;
				global::Infragistics.Windows.DockManager.ContentPane contentPane = (dependencyObject != null) ? (dependencyObject.GetValue(global::System.Windows.FrameworkElement.DataContextProperty) as global::Infragistics.Windows.DockManager.ContentPane) : null;
				if (contentPane != null && contentPane.CanActivate)
				{
					paneNavigator.SelectedPane = contentPane;
					paneNavigator.Close(false);
					e.Handled = true;
				}
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00019314 File Offset: 0x00017514
		private static void OnListBoxItemSelected(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.PaneNavigator paneNavigator = e.Source as global::Infragistics.Windows.DockManager.PaneNavigator;
			if (paneNavigator != null && !paneNavigator.IsLoaded)
			{
				global::System.Windows.Controls.ListBoxItem listBoxItem = e.OriginalSource as global::System.Windows.Controls.ListBoxItem;
				if (listBoxItem != null)
				{
					listBoxItem.Focus();
				}
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x0001934E File Offset: 0x0001754E
		private void OnPopupOpened(object sender, global::System.EventArgs e)
		{
			global::Infragistics.Windows.Controls.PopupHelper.BringToFront(sender as global::System.Windows.Controls.Primitives.Popup);
		}

		// Token: 0x040002EB RID: 747
		private const global::System.Windows.Input.ModifierKeys AllExceptShift = global::System.Windows.Input.ModifierKeys.Alt | global::System.Windows.Input.ModifierKeys.Control | global::System.Windows.Input.ModifierKeys.Windows;

		// Token: 0x040002EC RID: 748
		private global::Infragistics.Windows.DockManager.XamDockManager _dockManager;

		// Token: 0x040002ED RID: 749
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DockManager.ContentPane> _panes;

		// Token: 0x040002EE RID: 750
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DockManager.ContentPane> _documents;

		// Token: 0x040002EF RID: 751
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DockManager.ContentPane> _allPanes;

		// Token: 0x040002F0 RID: 752
		private global::System.Windows.Controls.Primitives.Popup _popup;

		// Token: 0x040002F1 RID: 753
		private bool _closeWhenModifiersReleased;

		// Token: 0x040002F2 RID: 754
		public static readonly global::System.Windows.DependencyProperty SelectedPaneProperty = global::System.Windows.DependencyProperty.Register("SelectedPane", typeof(global::Infragistics.Windows.DockManager.ContentPane), typeof(global::Infragistics.Windows.DockManager.PaneNavigator), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.PaneNavigator.OnSelectedPaneChanged)));

		// Token: 0x040002F3 RID: 755
		private static readonly global::System.Windows.DependencyPropertyKey SelectedPaneAspectRatioIsWidePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SelectedPaneAspectRatioIsWide", typeof(bool), typeof(global::Infragistics.Windows.DockManager.PaneNavigator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040002F4 RID: 756
		public static readonly global::System.Windows.DependencyProperty SelectedPaneAspectRatioIsWideProperty = global::Infragistics.Windows.DockManager.PaneNavigator.SelectedPaneAspectRatioIsWidePropertyKey.DependencyProperty;

		// Token: 0x040002F5 RID: 757
		private static readonly global::System.Windows.DependencyPropertyKey SelectedPaneIsDocumentPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SelectedPaneIsDocument", typeof(bool), typeof(global::Infragistics.Windows.DockManager.PaneNavigator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040002F6 RID: 758
		public static readonly global::System.Windows.DependencyProperty SelectedPaneIsDocumentProperty = global::Infragistics.Windows.DockManager.PaneNavigator.SelectedPaneIsDocumentPropertyKey.DependencyProperty;
	}
}
