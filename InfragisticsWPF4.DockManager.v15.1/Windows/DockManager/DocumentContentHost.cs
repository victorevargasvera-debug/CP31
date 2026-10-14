using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using Infragistics.Collections;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000031 RID: 49
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplatePart(Name = "PART_Panel", Type = typeof(global::Infragistics.Windows.DockManager.DocumentContentHostPanel))]
	[global::System.Windows.Markup.ContentProperty("Panes")]
	public class DocumentContentHost : global::System.Windows.Controls.Control, global::System.Windows.Markup.IAddChild, global::Infragistics.Windows.DockManager.IPaneContainer
	{
		// Token: 0x0600028D RID: 653 RVA: 0x0000D414 File Offset: 0x0000B614
		static DocumentContentHost()
		{
			global::Infragistics.Windows.DockManager.DocumentContentHost.ActiveDocumentChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ActiveDocumentChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedPropertyChangedEventHandler<global::Infragistics.Windows.DockManager.ContentPane>), typeof(global::Infragistics.Windows.DockManager.DocumentContentHost));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.DocumentContentHost), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DockManager.DocumentContentHost)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.DocumentContentHost), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.DocumentContentHost), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentStretchBox));
			global::System.Windows.Controls.Control.VerticalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.DocumentContentHost), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VerticalAlignmentStretchBox));
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000D50C File Offset: 0x0000B70C
		public DocumentContentHost()
		{
			this._panes = new global::Infragistics.Windows.DockManager.QueuedObservableCollection<global::Infragistics.Windows.DockManager.SplitPane>();
			this._panes.CollectionChanged += this.OnPanesCollectionChanged;
			this._panes.CollectionChanged += this.OnPanesCollectionChangedAfterHost;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000D564 File Offset: 0x0000B764
		public override void OnApplyTemplate()
		{
			using (global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateMoveReplacement<global::Infragistics.Windows.DockManager.SplitPane>(this._logicalChildren))
			{
				this.OnApplyTemplateImpl();
			}
			this._hasAppliedTemplate = true;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
		private void OnApplyTemplateImpl()
		{
			global::Infragistics.Windows.DockManager.SplitPane[] array = null;
			if (this._hasAppliedTemplate)
			{
				array = new global::Infragistics.Windows.DockManager.SplitPane[this._logicalChildren.Count];
				this._logicalChildren.CopyTo(array, 0);
				for (int i = array.Length - 1; i >= 0; i--)
				{
					this._logicalChildren.RemoveAt(i);
					base.RemoveLogicalChild(array[i]);
				}
			}
			if (this._panel != null)
			{
				this._panel.Host = null;
			}
			base.OnApplyTemplate();
			this._panel = (base.GetTemplateChild("PART_Panel") as global::Infragistics.Windows.DockManager.DocumentContentHostPanel);
			if (this._panel != null)
			{
				this._panel.Host = this;
				this._panes.CollectionChanged -= this.OnPanesCollectionChangedAfterHost;
				this._panes.CollectionChanged += this.OnPanesCollectionChangedAfterHost;
			}
			if (array != null)
			{
				foreach (global::Infragistics.Windows.DockManager.SplitPane splitPane in array)
				{
					this._logicalChildren.Add(splitPane);
					base.AddLogicalChild(splitPane);
				}
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000D69C File Offset: 0x0000B89C
		protected override global::System.Windows.Media.HitTestResult HitTestCore(global::System.Windows.Media.PointHitTestParameters hitTestParameters)
		{
			global::System.Windows.Rect rect = new global::System.Windows.Rect(default(global::System.Windows.Point), base.RenderSize);
			if (rect.Contains(hitTestParameters.HitPoint))
			{
				return new global::System.Windows.Media.PointHitTestResult(this, hitTestParameters.HitPoint);
			}
			return base.HitTestCore(hitTestParameters);
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000292 RID: 658 RVA: 0x0000D6E4 File Offset: 0x0000B8E4
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				if (base.LogicalChildren != null)
				{
					return new global::Infragistics.Collections.MultiSourceEnumerator(new global::System.Collections.IEnumerator[]
					{
						this._logicalChildren.GetEnumerator(),
						base.LogicalChildren
					});
				}
				return this._logicalChildren.GetEnumerator();
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0000D729 File Offset: 0x0000B929
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.ContentPane ActiveDocument
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.ContentPane)base.GetValue(global::Infragistics.Windows.DockManager.DocumentContentHost.ActiveDocumentProperty);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000D73B File Offset: 0x0000B93B
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DockManager.SplitPane> Panes
		{
			get
			{
				return this._panes;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000D743 File Offset: 0x0000B943
		internal global::Infragistics.Windows.DockManager.DocumentContentHostPanel Panel
		{
			get
			{
				return this._panel;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000D74B File Offset: 0x0000B94B
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0000D75D File Offset: 0x0000B95D
		internal global::System.Windows.Controls.Orientation RootSplitterOrientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.DockManager.DocumentContentHost.RootSplitterOrientationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.DocumentContentHost.RootSplitterOrientationProperty, value);
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000D770 File Offset: 0x0000B970
		internal global::Infragistics.Windows.DockManager.IContentPaneContainer GetContainerForPane(global::Infragistics.Windows.DockManager.ContentPane pane, bool createIfNull)
		{
			if (pane.IsDocument)
			{
				return pane.PlacementInfo.CurrentContainer;
			}
			global::Infragistics.Windows.DockManager.ContentPane activeDocument = this.ActiveDocument;
			global::Infragistics.Windows.DockManager.IContentPaneContainer contentPaneContainer = null;
			if (activeDocument != null)
			{
				contentPaneContainer = activeDocument.PlacementInfo.CurrentContainer;
			}
			if (contentPaneContainer == null)
			{
				contentPaneContainer = this.GetFirstLeafTabGroup();
				if (contentPaneContainer == null && createIfNull)
				{
					global::Infragistics.Windows.DockManager.SplitPane splitPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateSplitPane(global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this));
					global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateTabGroup(global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this));
					splitPane.Panes.Add(tabGroupPane);
					this.Panes.Add(splitPane);
					contentPaneContainer = tabGroupPane;
				}
			}
			return contentPaneContainer;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000D7EC File Offset: 0x0000B9EC
		private global::Infragistics.Windows.DockManager.IContentPaneContainer GetFirstLeafTabGroup()
		{
			global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = null;
			foreach (global::Infragistics.Windows.DockManager.SplitPane pane in this.Panes)
			{
				tabGroupPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetTabGroupPane(pane);
				if (tabGroupPane != null)
				{
					break;
				}
			}
			return tabGroupPane;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000D840 File Offset: 0x0000BA40
		private void OnPanesCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.QueuedObservableCollection<global::Infragistics.Windows.DockManager.SplitPane>.QueuedNotifyCollectionChangedEventArgs queuedNotifyCollectionChangedEventArgs = e as global::Infragistics.Windows.DockManager.QueuedObservableCollection<global::Infragistics.Windows.DockManager.SplitPane>.QueuedNotifyCollectionChangedEventArgs;
			foreach (global::Infragistics.Windows.DockManager.SplitPane splitPane in queuedNotifyCollectionChangedEventArgs.ItemsAdded)
			{
				this._logicalChildren.Add(splitPane);
				base.AddLogicalChild(splitPane);
			}
			global::Infragistics.Windows.DockManager.XamDockManager dockManager = global::Infragistics.Windows.DockManager.XamDockManager.GetDockManager(this);
			if (dockManager != null && dockManager.IsLoadingLayout)
			{
				foreach (global::Infragistics.Windows.DockManager.SplitPane splitPane2 in queuedNotifyCollectionChangedEventArgs.ItemsRemoved)
				{
					this._logicalChildren.Remove(splitPane2);
					base.RemoveLogicalChild(splitPane2);
				}
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000D908 File Offset: 0x0000BB08
		private void OnPanesCollectionChangedAfterHost(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.QueuedObservableCollection<global::Infragistics.Windows.DockManager.SplitPane>.QueuedNotifyCollectionChangedEventArgs queuedNotifyCollectionChangedEventArgs = e as global::Infragistics.Windows.DockManager.QueuedObservableCollection<global::Infragistics.Windows.DockManager.SplitPane>.QueuedNotifyCollectionChangedEventArgs;
			foreach (global::Infragistics.Windows.DockManager.SplitPane splitPane in queuedNotifyCollectionChangedEventArgs.ItemsRemoved)
			{
				if (this._logicalChildren.Remove(splitPane))
				{
					base.RemoveLogicalChild(splitPane);
				}
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000D96C File Offset: 0x0000BB6C
		protected virtual void OnActiveDocumentChanged(global::System.Windows.RoutedPropertyChangedEventArgs<global::Infragistics.Windows.DockManager.ContentPane> args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000D975 File Offset: 0x0000BB75
		internal void RaiseActiveDocumentChanged(global::System.Windows.RoutedPropertyChangedEventArgs<global::Infragistics.Windows.DockManager.ContentPane> args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DockManager.DocumentContentHost.ActiveDocumentChangedEvent;
			args.Source = this;
			this.OnActiveDocumentChanged(args);
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600029E RID: 670 RVA: 0x0000D990 File Offset: 0x0000BB90
		// (remove) Token: 0x0600029F RID: 671 RVA: 0x0000D99E File Offset: 0x0000BB9E
		public event global::System.Windows.RoutedPropertyChangedEventHandler<global::Infragistics.Windows.DockManager.ContentPane> ActiveDocumentChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DockManager.DocumentContentHost.ActiveDocumentChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DockManager.DocumentContentHost.ActiveDocumentChangedEvent, value);
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000D9AC File Offset: 0x0000BBAC
		void global::System.Windows.Markup.IAddChild.AddChild(object value)
		{
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(value, "value");
			global::Infragistics.Windows.DockManager.SplitPane splitPane = value as global::Infragistics.Windows.DockManager.SplitPane;
			if (splitPane == null)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_InvalidDocumentContentHostChild"));
			}
			this.Panes.Add(splitPane);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000D9EA File Offset: 0x0000BBEA
		void global::System.Windows.Markup.IAddChild.AddText(string text)
		{
			throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_InvalidDocumentContentHostChild"));
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000D9FB File Offset: 0x0000BBFB
		global::System.Collections.IList global::Infragistics.Windows.DockManager.IPaneContainer.Panes
		{
			get
			{
				return this.Panes;
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000DA04 File Offset: 0x0000BC04
		bool global::Infragistics.Windows.DockManager.IPaneContainer.RemovePane(object pane)
		{
			global::Infragistics.Windows.DockManager.SplitPane splitPane = pane as global::Infragistics.Windows.DockManager.SplitPane;
			if (splitPane != null)
			{
				int num = this.Panes.IndexOf(splitPane);
				if (num >= 0)
				{
					this.Panes.RemoveAt(num);
					return true;
				}
			}
			return false;
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0000DA3B File Offset: 0x0000BC3B
		bool global::Infragistics.Windows.DockManager.IPaneContainer.CanBeRemoved
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0400016B RID: 363
		private global::Infragistics.Windows.DockManager.DocumentContentHostPanel _panel;

		// Token: 0x0400016C RID: 364
		private global::Infragistics.Windows.DockManager.QueuedObservableCollection<global::Infragistics.Windows.DockManager.SplitPane> _panes;

		// Token: 0x0400016D RID: 365
		private global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.SplitPane> _logicalChildren = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.SplitPane>();

		// Token: 0x0400016E RID: 366
		private bool _hasAppliedTemplate;

		// Token: 0x0400016F RID: 367
		public static readonly global::System.Windows.DependencyProperty ActiveDocumentProperty = global::Infragistics.Windows.DockManager.ActivePaneManager.ActiveDocumentProperty.AddOwner(typeof(global::Infragistics.Windows.DockManager.DocumentContentHost));

		// Token: 0x04000170 RID: 368
		internal static readonly global::System.Windows.DependencyProperty RootSplitterOrientationProperty = global::System.Windows.DependencyProperty.Register("RootSplitterOrientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DockManager.DocumentContentHost), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Vertical));
	}
}
