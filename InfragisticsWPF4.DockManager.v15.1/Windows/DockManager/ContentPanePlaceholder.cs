using System;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x0200001D RID: 29
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class ContentPanePlaceholder : global::System.Windows.FrameworkElement
	{
		// Token: 0x06000192 RID: 402 RVA: 0x000080E0 File Offset: 0x000062E0
		static ContentPanePlaceholder()
		{
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.ContentPanePlaceholder), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.ContentPanePlaceholder.CoerceVisibility)));
			global::Infragistics.Windows.DockManager.XamDockManager.DockManagerPropertyKey.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.ContentPanePlaceholder), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.ContentPanePlaceholder.OnDockManagerChanged)));
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000815E File Offset: 0x0000635E
		public override string ToString()
		{
			if (this.Pane == null)
			{
				return "ContentPanePlaceholder";
			}
			return "ContentPanePlaceholder: " + this.Pane.ToString();
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00008183 File Offset: 0x00006383
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DockManager.PaneLocation PaneLocation
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.PaneLocation)base.GetValue(global::Infragistics.Windows.DockManager.ContentPane.PaneLocationProperty);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00008195 File Offset: 0x00006395
		// (set) Token: 0x06000197 RID: 407 RVA: 0x0000819D File Offset: 0x0000639D
		internal global::Infragistics.Windows.DockManager.IContentPaneContainer Container
		{
			get
			{
				return this._container;
			}
			set
			{
				this._container = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000198 RID: 408 RVA: 0x000081A6 File Offset: 0x000063A6
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DockManager.ContentPane Pane
		{
			get
			{
				return this._pane;
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000081AE File Offset: 0x000063AE
		internal void Initialize(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			this._pane = pane;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000081B7 File Offset: 0x000063B7
		internal bool IsPane(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			return pane == this._pane;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000081C2 File Offset: 0x000063C2
		private static object CoerceVisibility(global::System.Windows.DependencyObject d, object newValue)
		{
			return global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000081CC File Offset: 0x000063CC
		private static void OnDockManagerChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.ContentPanePlaceholder contentPanePlaceholder = d as global::Infragistics.Windows.DockManager.ContentPanePlaceholder;
			if (global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(contentPanePlaceholder) != e.NewValue)
			{
				return;
			}
			global::Infragistics.Windows.DockManager.XamDockManager xamDockManager = e.OldValue as global::Infragistics.Windows.DockManager.XamDockManager;
			global::Infragistics.Windows.DockManager.XamDockManager xamDockManager2 = e.NewValue as global::Infragistics.Windows.DockManager.XamDockManager;
			if (xamDockManager != null)
			{
				xamDockManager.ActivePaneManager.OnPlaceholderRemoved(contentPanePlaceholder);
			}
			if (xamDockManager2 != null)
			{
				xamDockManager2.ActivePaneManager.OnPlaceholderAdded(contentPanePlaceholder);
			}
		}

		// Token: 0x0400008C RID: 140
		private global::Infragistics.Windows.DockManager.ContentPane _pane;

		// Token: 0x0400008D RID: 141
		private global::Infragistics.Windows.DockManager.IContentPaneContainer _container;

		// Token: 0x0400008E RID: 142
		public static readonly global::System.Windows.DependencyProperty PaneLocationProperty = global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationProperty.AddOwner(typeof(global::Infragistics.Windows.DockManager.ContentPanePlaceholder));
	}
}
