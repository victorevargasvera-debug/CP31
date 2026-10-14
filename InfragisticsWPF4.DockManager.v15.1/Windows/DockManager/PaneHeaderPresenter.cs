using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Infragistics.Windows.DockManager.Dragging;
using Infragistics.Windows.Themes;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x0200007E RID: 126
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "ActiveDocument", GroupName = "ActiveStates")]
	[global::System.Windows.TemplatePart(Name = "PART_PositionMenuItem", Type = typeof(global::System.Windows.Controls.MenuItem))]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
	public class PaneHeaderPresenter : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x06000458 RID: 1112 RVA: 0x000185F0 File Offset: 0x000167F0
		static PaneHeaderPresenter()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DockManager.PaneHeaderPresenter)));
			global::System.Windows.FrameworkElement.DataContextProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.PaneHeaderPresenter.OnDataContextChanged)));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentStretchBox));
			global::System.Windows.Controls.Control.VerticalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VerticalAlignmentCenterBox));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.PaneHeaderPresenter), global::System.Windows.FrameworkElement.ContextMenuOpeningEvent, new global::System.Windows.Controls.ContextMenuEventHandler(global::Infragistics.Windows.DockManager.ContentPane.OnPaneContextMenuOpening));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.PaneHeaderPresenter), global::System.Windows.Input.Mouse.MouseDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Infragistics.Windows.DockManager.PaneHeaderPresenter.OnMouseButtonDown), true);
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.PaneHeaderPresenter), global::System.Windows.Controls.MenuItem.SubmenuOpenedEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.DockManager.PaneHeaderPresenter.OnSubmenuOpened));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.PaneHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.PaneHeaderPresenter.OnVisualStatePropertyChanged)));
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000187E8 File Offset: 0x000169E8
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this._positionMenuItem != null && this._hiddenMenuItem != null)
			{
				this._positionMenuItem.Items.Remove(this._hiddenMenuItem);
			}
			this._positionMenuItem = (base.GetTemplateChild("PART_PositionMenuItem") as global::System.Windows.Controls.MenuItem);
			if (this._positionMenuItem != null)
			{
				this._positionMenuItem.Items.Add(this.HiddenMenuItem);
			}
			this.InitializePaneProperty();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0001886F File Offset: 0x00016A6F
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.UpdateVisualStates();
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0001887E File Offset: 0x00016A7E
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.UpdateVisualStates();
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00018890 File Offset: 0x00016A90
		private static void OnPaneChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.PaneHeaderPresenter paneHeaderPresenter = target as global::Infragistics.Windows.DockManager.PaneHeaderPresenter;
			if (paneHeaderPresenter != null)
			{
				global::Infragistics.Windows.DockManager.ContentPane contentPane = e.OldValue as global::Infragistics.Windows.DockManager.ContentPane;
				if (contentPane != null)
				{
					contentPane.ClearHeader(paneHeaderPresenter);
				}
				global::Infragistics.Windows.DockManager.ContentPane contentPane2 = e.NewValue as global::Infragistics.Windows.DockManager.ContentPane;
				if (contentPane2 != null)
				{
					contentPane2.InitializeHeader(paneHeaderPresenter);
				}
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x000188D5 File Offset: 0x00016AD5
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DockManager.ContentPane Pane
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.ContentPane)base.GetValue(global::Infragistics.Windows.DockManager.PaneHeaderPresenter.PaneProperty);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x000188E7 File Offset: 0x00016AE7
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

		// Token: 0x0600045F RID: 1119 RVA: 0x00018910 File Offset: 0x00016B10
		protected virtual void SetVisualState(bool useTransitions)
		{
			if (base.IsEnabled)
			{
				if (base.IsMouseOver)
				{
					global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
					{
						"MouseOver",
						"Normal"
					});
				}
				else
				{
					global::System.Windows.VisualStateManager.GoToState(this, "Normal", useTransitions);
				}
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Disabled", useTransitions);
			}
			global::Infragistics.Windows.DockManager.ContentPane pane = this.Pane;
			if (pane == null)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Inactive", useTransitions);
				return;
			}
			if (pane.IsActivePane)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Active", useTransitions);
				return;
			}
			if (pane.IsActiveDocument)
			{
				global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
				{
					"ActiveDocument",
					"Inactive"
				});
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "Inactive", useTransitions);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000189D0 File Offset: 0x00016BD0
		private static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.PaneHeaderPresenter paneHeaderPresenter = target as global::Infragistics.Windows.DockManager.PaneHeaderPresenter;
			paneHeaderPresenter.UpdateVisualStates();
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000189EA File Offset: 0x00016BEA
		protected internal void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x000189F3 File Offset: 0x00016BF3
		protected internal void UpdateVisualStates(bool useTransitions)
		{
			if (!this._hasVisualStateGroups)
			{
				return;
			}
			if (!base.IsLoaded)
			{
				useTransitions = false;
			}
			this.SetVisualState(useTransitions);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00018A10 File Offset: 0x00016C10
		private void InitializePaneProperty()
		{
			global::Infragistics.Windows.DockManager.ContentPane value = (base.TemplatedParent as global::Infragistics.Windows.DockManager.ContentPane) ?? (base.DataContext as global::Infragistics.Windows.DockManager.ContentPane);
			base.SetValue(global::Infragistics.Windows.DockManager.PaneHeaderPresenter.PanePropertyKey, value);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00018A44 File Offset: 0x00016C44
		private static void OnDataContextChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.DockManager.PaneHeaderPresenter)d).InitializePaneProperty();
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00018A54 File Offset: 0x00016C54
		private static void OnMouseButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Infragistics.Windows.DockManager.PaneHeaderPresenter paneHeaderPresenter = sender as global::Infragistics.Windows.DockManager.PaneHeaderPresenter;
			global::Infragistics.Windows.DockManager.ContentPane contentPane = (paneHeaderPresenter != null) ? paneHeaderPresenter.Pane : null;
			if (contentPane != null)
			{
				bool handled = e.Handled;
				if (e.ChangedButton == global::System.Windows.Input.MouseButton.Left && !handled && e.ClickCount == 2)
				{
					global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(contentPane);
					if (dockManager != null && dockManager.ProcessPaneHeaderDoubleClick(contentPane))
					{
						e.Handled = true;
						return;
					}
				}
				if (contentPane.ActivateInternal())
				{
					e.Handled = true;
				}
				if (!handled)
				{
					global::Infragistics.Windows.DockManager.Dragging.DragManager.ProcessMouseDown(paneHeaderPresenter, e);
				}
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00018AC8 File Offset: 0x00016CC8
		private static void OnSubmenuOpened(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.PaneHeaderPresenter paneHeaderPresenter = sender as global::Infragistics.Windows.DockManager.PaneHeaderPresenter;
			if (paneHeaderPresenter != null && paneHeaderPresenter._positionMenuItem == e.OriginalSource && paneHeaderPresenter.Pane != null)
			{
				paneHeaderPresenter._positionMenuItem.Items.Clear();
				paneHeaderPresenter._positionMenuItem.Items.Add(paneHeaderPresenter.HiddenMenuItem);
				paneHeaderPresenter.Pane.InitializeMenu(paneHeaderPresenter._positionMenuItem.Items);
			}
		}

		// Token: 0x040002E1 RID: 737
		private global::System.Windows.Controls.MenuItem _positionMenuItem;

		// Token: 0x040002E2 RID: 738
		private global::System.Windows.Controls.MenuItem _hiddenMenuItem;

		// Token: 0x040002E3 RID: 739
		private bool _hasVisualStateGroups;

		// Token: 0x040002E4 RID: 740
		public static readonly global::System.Windows.ResourceKey CloseButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.PaneHeaderPresenter), "CloseButtonStyleKey");

		// Token: 0x040002E5 RID: 741
		public static readonly global::System.Windows.ResourceKey MaximizeButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.PaneHeaderPresenter), "MaximizeButtonStyleKey");

		// Token: 0x040002E6 RID: 742
		public static readonly global::System.Windows.ResourceKey MinimizeButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.PaneHeaderPresenter), "MinimizeButtonStyleKey");

		// Token: 0x040002E7 RID: 743
		public static readonly global::System.Windows.ResourceKey PositionMenuItemStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.PaneHeaderPresenter), "PositionMenuItemStyleKey");

		// Token: 0x040002E8 RID: 744
		public static readonly global::System.Windows.ResourceKey PinButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.DockManager.PaneHeaderPresenter), "PinButtonStyleKey");

		// Token: 0x040002E9 RID: 745
		private static readonly global::System.Windows.DependencyPropertyKey PanePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Pane", typeof(global::Infragistics.Windows.DockManager.ContentPane), typeof(global::Infragistics.Windows.DockManager.PaneHeaderPresenter), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.PaneHeaderPresenter.OnPaneChanged)));

		// Token: 0x040002EA RID: 746
		public static readonly global::System.Windows.DependencyProperty PaneProperty = global::Infragistics.Windows.DockManager.PaneHeaderPresenter.PanePropertyKey.DependencyProperty;
	}
}
