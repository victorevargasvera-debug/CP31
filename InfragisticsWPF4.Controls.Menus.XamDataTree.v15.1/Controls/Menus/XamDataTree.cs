using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.AutomationPeers;
using Infragistics.Collections;
using Infragistics.Controls.Menus.Primitives;
using Infragistics.Controls.Primitives;
using Infragistics.DragDrop;
using Infragistics.Themes;
using Infragistics.Windows;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000039 RID: 57
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::System.Windows.TemplatePart(Name = "Bd", Type = typeof(global::System.Windows.Controls.Border))]
	[global::System.ComponentModel.ComplexBindingProperties("ItemsSource")]
	[global::System.Windows.StyleTypedProperty(Property = "ActiveNodeIndicatorStyle", StyleTargetType = typeof(global::Infragistics.Controls.Menus.Primitives.ActiveNodeIndicator))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamDataTree")]
	public class XamDataTree : global::System.Windows.Controls.Control, global::System.ComponentModel.INotifyPropertyChanged, global::Infragistics.IProvideScrollInfo, global::Infragistics.Controls.ISupportScrollHelper
	{
		// Token: 0x06000241 RID: 577 RVA: 0x0000A1BC File Offset: 0x000083BC
		static XamDataTree()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Menus.XamDataTree), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Menus.XamDataTree)));
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Controls.Menus.XamDataTree));
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000A6E8 File Offset: 0x000088E8
		public XamDataTree()
		{
			if (global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
			{
				new global::Infragistics.DragDrop.DragObject();
			}
			base.IsEnabledChanged += this.XamDataTree_IsEnabledChanged;
			global::Infragistics.Windows.Utilities.ValidateLicense(typeof(global::Infragistics.Controls.Menus.XamDataTree), this);
			this._nodesManager = new global::Infragistics.Controls.Menus.XamDataTreeNodesManager(this);
			base.Loaded += this.XamDataTree_Loaded;
			base.Unloaded += this.XamDataTree_Unloaded;
			this._editCellValues = new global::System.Collections.Generic.Dictionary<string, object>();
			this._originalNodeValues = new global::System.Collections.Generic.Dictionary<string, object>();
			base.AddHandler(global::System.Windows.UIElement.KeyDownEvent, new global::System.Windows.Input.KeyEventHandler(this.XamDataTree_KeyDown), true);
			base.AddHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.XamDataTree_MouseLeftButtonDown), true);
			this._nodeExpanderTimer = new global::System.Windows.Threading.DispatcherTimer();
			this._nodeExpanderTimer.Tick += this.NodeExpanderTimer_Tick;
			this._nodeExpanderTimer.Interval = global::System.TimeSpan.FromMilliseconds(500.0);
			this._dropTarget = new global::Infragistics.DragDrop.DropTarget();
			global::Infragistics.DragDrop.DragDropManager.SetDropTarget(this, this._dropTarget);
			this._dropTarget.IsDropTarget = true;
			this.ReflectChangesOverModel = true;
			this._fillSelectedDataItems = true;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000A824 File Offset: 0x00008A24
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this._panel != null)
			{
				this._panel.ResetNodes();
				this._panel.Children.Clear();
			}
			this._panel = (base.GetTemplateChild("NodesPanel") as global::Infragistics.Controls.Menus.Primitives.NodesPanel);
			if (this._panel != null)
			{
				this._panel.Tree = this;
			}
			if (this._verticalScrollbar != null)
			{
				this._verticalScrollbar.Scroll -= this.VerticalScrollbar_Scroll;
			}
			this._verticalScrollbar = (base.GetTemplateChild("VerticalScrollBar") as global::System.Windows.Controls.Primitives.ScrollBar);
			if (this._verticalScrollbar != null)
			{
				this._verticalScrollbar.Scroll += this.VerticalScrollbar_Scroll;
				this._verticalScrollbar.Orientation = global::System.Windows.Controls.Orientation.Vertical;
			}
			if (this._horizontalScrollbar != null)
			{
				this._horizontalScrollbar.Scroll -= this.HorizontalScrollbar_Scroll;
			}
			this._horizontalScrollbar = (base.GetTemplateChild("HorizontalScrollBar") as global::System.Windows.Controls.Primitives.ScrollBar);
			if (this._horizontalScrollbar != null)
			{
				this._horizontalScrollbar.Orientation = global::System.Windows.Controls.Orientation.Horizontal;
				this._horizontalScrollbar.Scroll += this.HorizontalScrollbar_Scroll;
			}
			this._scrollHelper = new global::Infragistics.Controls.TouchScrollHelper(this._panel, this);
			this._scrollHelper.IsEnabled = this.IsTouchSupportEnabled;
			this._panel.SetCurrentValue(global::System.Windows.UIElement.IsManipulationEnabledProperty, this.IsTouchSupportEnabled);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000A982 File Offset: 0x00008B82
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			this._mouseIsOver = true;
			base.OnMouseEnter(e);
			if (this._selectNodesTimer != null)
			{
				this._selectNodesTimer.Stop();
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000A9A8 File Offset: 0x00008BA8
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			this._mouseIsOver = false;
			if (this._dragSelectType != global::Infragistics.Controls.Menus.TreeDragSelectType.None)
			{
				bool isMouseCaptured = base.IsMouseCaptured;
				if (this.SelectionSettings.NodeSelection == global::Infragistics.Controls.Menus.TreeSelectionType.Multiple && isMouseCaptured)
				{
					if (this._selectNodesTimer == null)
					{
						this._selectNodesTimer = new global::System.Windows.Threading.DispatcherTimer();
						this._selectNodesTimer.Tick += this.SelectRowsCellsTimer_Tick;
						this._selectNodesTimer.Interval = global::System.TimeSpan.FromMilliseconds(0.0);
					}
					this._selectNodesTimer.Start();
				}
			}
			base.OnMouseLeave(e);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000AA34 File Offset: 0x00008C34
		protected override void OnMouseWheel(global::System.Windows.Input.MouseWheelEventArgs e)
		{
			bool mouseIsOver = this._mouseIsOver;
			if (mouseIsOver)
			{
				bool flag = false;
				int num = (e.Delta < 0) ? 1 : -1;
				if (this._verticalScrollbar != null && this._verticalScrollbar.Visibility == global::System.Windows.Visibility.Visible)
				{
					flag = true;
					this._verticalScrollbar.Value += this._verticalScrollbar.SmallChange * (double)num;
				}
				else if (this._horizontalScrollbar != null && this._horizontalScrollbar.Visibility == global::System.Windows.Visibility.Visible)
				{
					flag = true;
					this._horizontalScrollbar.Value += this._horizontalScrollbar.SmallChange * (double)num;
				}
				if (flag)
				{
					this.InvalidateScrollPanel(false);
					e.Handled = true;
				}
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000AAE0 File Offset: 0x00008CE0
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			this._lostCaptureDuringMouseDown = true;
			if (this._dragSelectType == global::Infragistics.Controls.Menus.TreeDragSelectType.Node)
			{
				bool resetMouseDownCell = true;
				global::System.Windows.Point position = e.GetPosition(null);
				if (this._mouseDownPoint != null)
				{
					global::System.Windows.Point value = this._mouseDownPoint.Value;
					if (position.X == value.X && position.Y == value.Y)
					{
						resetMouseDownCell = false;
					}
				}
				this.EndSelectionDrag(resetMouseDownCell);
			}
			base.OnLostMouseCapture(e);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000AB50 File Offset: 0x00008D50
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseMove(e);
			global::System.Windows.Point position = e.GetPosition(null);
			if (this._mouseDownPoint != null)
			{
				global::System.Windows.Point value = this._mouseDownPoint.Value;
				if (position.X != value.X && position.Y != value.Y)
				{
					this._mouseDownNode = null;
				}
			}
			if (!this._mouseIsOver && this._dragSelectType != global::Infragistics.Controls.Menus.TreeDragSelectType.None)
			{
				this._mousePosition = e.GetPosition(this);
			}
			global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl = this.GetNodeFromSource(e.OriginalSource as global::System.Windows.DependencyObject);
			bool flag = base.IsMouseCaptured;
			if (!flag && xamDataTreeNodeControl != null && xamDataTreeNodeControl.IsMouseCaptured)
			{
				xamDataTreeNodeControl = null;
				flag = true;
			}
			if (flag)
			{
				global::System.Windows.Media.HitTestResult hitTestResult = global::System.Windows.Media.VisualTreeHelper.HitTest(this, e.GetPosition(this));
				if (xamDataTreeNodeControl == null && hitTestResult != null && hitTestResult.VisualHit != null)
				{
					xamDataTreeNodeControl = this.GetNodeFromSource(hitTestResult.VisualHit);
				}
				if (hitTestResult == null)
				{
					this._mouseIsOver = false;
					if (this._dragSelectType != global::Infragistics.Controls.Menus.TreeDragSelectType.None && this.SelectionSettings.NodeSelection == global::Infragistics.Controls.Menus.TreeSelectionType.Multiple)
					{
						if (this._selectNodesTimer == null)
						{
							this._selectNodesTimer = new global::System.Windows.Threading.DispatcherTimer();
							this._selectNodesTimer.Tick += this.SelectRowsCellsTimer_Tick;
							this._selectNodesTimer.Interval = global::System.TimeSpan.FromMilliseconds(0.0);
						}
						this._selectNodesTimer.Start();
					}
				}
				else
				{
					this._mouseIsOver = true;
					if (this._selectNodesTimer != null)
					{
						this._selectNodesTimer.Stop();
					}
				}
			}
			if (xamDataTreeNodeControl != null)
			{
				if (xamDataTreeNodeControl.Node != this._mouseOverNode)
				{
					this.InvalidateMouseOverNode();
					if (xamDataTreeNodeControl.Node != null)
					{
						this._mouseOverNode = xamDataTreeNodeControl.Node;
						this._mouseOverNode.IsMouseOver = true;
						if (this._mouseOverNode.Control != null)
						{
							this._mouseOverNode.Control.InternalCellMouseEnter(this._mouseOverNode);
						}
					}
				}
				if (this._dragSelectType != global::Infragistics.Controls.Menus.TreeDragSelectType.None && xamDataTreeNodeControl.Node != null && xamDataTreeNodeControl.Node.IsDraggableResolved && !this.IsNodeDragging)
				{
					xamDataTreeNodeControl.Node.OnNodeDragging(this._dragSelectType);
				}
				if (xamDataTreeNodeControl.Node != null)
				{
					xamDataTreeNodeControl.Node.OnNodeMouseMove(e);
				}
			}
			else
			{
				this.InvalidateMouseOverNode();
			}
			if (this.IsNodeDragging)
			{
				this._mousePosition = e.GetPosition(this);
				if (global::Infragistics.DragDrop.DragDropManager.IsDragging)
				{
					if (this._scrollNodesTimer == null)
					{
						this._scrollNodesTimer = new global::System.Windows.Threading.DispatcherTimer();
						this._scrollNodesTimer.Tick += this.ScrollNodesTimer_Tick;
						this._scrollNodesTimer.Interval = global::System.TimeSpan.FromMilliseconds(0.0);
					}
					this._scrollNodesTimer.Start();
					return;
				}
				if (this._scrollNodesTimer != null)
				{
					this._scrollNodesTimer.Stop();
					return;
				}
			}
			else if (this._scrollNodesTimer != null)
			{
				this._scrollNodesTimer.Stop();
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000ADF3 File Offset: 0x00008FF3
		protected override void OnGotFocus(global::System.Windows.RoutedEventArgs e)
		{
			base.OnGotFocus(e);
			if (!this._skipDefaultActivation)
			{
				this.SetDefaultActiveNode();
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000AE0C File Offset: 0x0000900C
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.Controls.Border border = e.OriginalSource as global::System.Windows.Controls.Border;
			if (border != null && border.Name == "Bd" && this.CurrentEditNode != null && !this.ExitEditMode(false))
			{
				this._lastCancelledExitEditEvent = global::System.DateTime.Now;
			}
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000AE5D File Offset: 0x0000905D
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.AutomationPeers.XamDataTreeAutomationPeer(this);
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0000AE65 File Offset: 0x00009065
		// (set) Token: 0x0600024D RID: 589 RVA: 0x0000AE72 File Offset: 0x00009072
		public global::System.Collections.IEnumerable ItemsSource
		{
			get
			{
				return this._nodesManager.ItemsSource;
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.ItemsSourceProperty, value);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000AE80 File Offset: 0x00009080
		private static void ItemsSourceChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = (global::Infragistics.Controls.Menus.XamDataTree)obj;
			if (e.OldValue != null)
			{
				xamDataTree._ignoreActiveNodeChange = true;
				global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(xamDataTree, global::Infragistics.Controls.Menus.XamDataTree.ActiveDataItemProperty, null);
				xamDataTree._ignoreActiveNodeChange = false;
			}
			if (xamDataTree.IsLoaded)
			{
				xamDataTree._fillSelectedDataItems = false;
				xamDataTree.ApplyItemSource((global::System.Collections.IEnumerable)e.NewValue);
				xamDataTree._fillSelectedDataItems = true;
			}
			if (xamDataTree.IsLoaded)
			{
				xamDataTree.ProcessIsSelectedMemberPath(xamDataTree.NodesManager, (global::System.Collections.IEnumerable)e.NewValue);
			}
			if (xamDataTree.SelectedDataItems != null && !xamDataTree._deferClearingSelectionOnItemsSourceChanged && e.OldValue != null && e.NewValue != null)
			{
				xamDataTree.SyncSelectionOnNewItemSourceApplied((global::System.Collections.IEnumerable)e.NewValue);
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000AFA4 File Offset: 0x000091A4
		private void SyncSelectionOnNewItemSourceApplied(global::System.Collections.IEnumerable itemSource)
		{
			if (this.SelectedDataItems != null)
			{
				global::System.Collections.Generic.List<object> selectedDataItemsArray = this.SelectedDataItems.Cast<object>().ToList<object>();
				bool flag;
				if (itemSource != null)
				{
					global::System.Collections.Generic.List<object> second = itemSource.Cast<object>().ToList<object>();
					global::System.Collections.Generic.IEnumerable<object> source = selectedDataItemsArray.Except(second);
					flag = source.Any<object>();
					if (flag && source.Count<object>() < selectedDataItemsArray.Count)
					{
						object[] array = source.ToArray<object>();
						foreach (object item in array)
						{
							selectedDataItemsArray.Remove(item);
						}
					}
				}
				else
				{
					selectedDataItemsArray.Clear();
					flag = true;
				}
				if (flag)
				{
					this._deferClearingSelectionOnItemsSourceChanged = true;
					base.Dispatcher.BeginInvoke(new global::System.Action(delegate()
					{
						if (this._deferClearingSelectionOnItemsSourceChanged)
						{
							global::Infragistics.Controls.Menus.SelectedNodesCollection selectedNodesCollection = new global::Infragistics.Controls.Menus.SelectedNodesCollection();
							selectedNodesCollection.InternalAddRangeSilently(this.SelectionSettings.SelectedNodes);
							this.SetSelectedDataItemsExternal(selectedDataItemsArray.ToArray());
							this.OnSelectedNodesCollectionChanged(selectedNodesCollection, this.SelectionSettings.SelectedNodes);
						}
					}), new object[0]);
				}
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0000B096 File Offset: 0x00009296
		// (set) Token: 0x06000251 RID: 593 RVA: 0x0000B0A8 File Offset: 0x000092A8
		public int MaxDepth
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.MaxDepthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.MaxDepthProperty, value);
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000B0BB File Offset: 0x000092BB
		private static void MaxDepthChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000B0BD File Offset: 0x000092BD
		public global::Infragistics.Controls.Menus.GlobalNodeLayoutCollection GlobalNodeLayouts
		{
			get
			{
				if (this._globalNodeLayouts == null)
				{
					this._globalNodeLayouts = new global::Infragistics.Controls.Menus.GlobalNodeLayoutCollection(this);
					this._globalNodeLayouts.CollectionChanged += this.NodeLayouts_CollectionChanged;
				}
				return this._globalNodeLayouts;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0000B0F0 File Offset: 0x000092F0
		public global::Infragistics.Controls.Menus.NodeLayoutCollection NodeLayouts
		{
			get
			{
				return this._nodesManager.NodeLayout.NodeLayouts;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0000B102 File Offset: 0x00009302
		// (set) Token: 0x06000256 RID: 598 RVA: 0x0000B114 File Offset: 0x00009314
		public string DisplayMemberPath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.DisplayMemberPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.DisplayMemberPathProperty, value);
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000B124 File Offset: 0x00009324
		private static void DisplayMemberPathChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = (global::Infragistics.Controls.Menus.XamDataTree)obj;
			xamDataTree.InvalidateScrollPanel(true, false, true);
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0000B141 File Offset: 0x00009341
		// (set) Token: 0x06000259 RID: 601 RVA: 0x0000B153 File Offset: 0x00009353
		public string CheckBoxMemberPath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.CheckBoxMemberPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.CheckBoxMemberPathProperty, value);
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000B164 File Offset: 0x00009364
		private static void CheckBoxMemberPathChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = (global::Infragistics.Controls.Menus.XamDataTree)obj;
			xamDataTree.OnPropertyChanged("CheckBoxMemberPath");
			xamDataTree.OnPropertyChanged("CheckBoxMemberPathResolved");
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000B190 File Offset: 0x00009390
		private static void OnIsEnabledMemberPathChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = (global::Infragistics.Controls.Menus.XamDataTree)d;
			xamDataTree.OnPropertyChanged("IsEnabledMemberPath");
			xamDataTree.OnPropertyChanged("IsEnabledMemberPathResolved");
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0000B1BA File Offset: 0x000093BA
		// (set) Token: 0x0600025D RID: 605 RVA: 0x0000B1CC File Offset: 0x000093CC
		public string IsEnabledMemberPath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.IsEnabledMemberPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.IsEnabledMemberPathProperty, value);
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0000B1DA File Offset: 0x000093DA
		// (set) Token: 0x0600025F RID: 607 RVA: 0x0000B1EC File Offset: 0x000093EC
		public string IsExpandedMemberPath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.IsExpandedMemberPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.IsExpandedMemberPathProperty, value);
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000B1FC File Offset: 0x000093FC
		private static void IsExpandedMemberPathChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = (global::Infragistics.Controls.Menus.XamDataTree)obj;
			xamDataTree.OnPropertyChanged("IsExpandedMemberPath");
			xamDataTree.OnPropertyChanged("IsExpandedMemberPathResolved");
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000261 RID: 609 RVA: 0x0000B226 File Offset: 0x00009426
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Menus.XamDataTreeNodesCollection Nodes
		{
			get
			{
				return this._nodesManager.Nodes;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0000B233 File Offset: 0x00009433
		// (set) Token: 0x06000263 RID: 611 RVA: 0x0000B245 File Offset: 0x00009445
		public double Indentation
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.IndentationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.IndentationProperty, value);
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000B258 File Offset: 0x00009458
		private static void IndentationChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = (global::Infragistics.Controls.Menus.XamDataTree)obj;
			xamDataTree.OnPropertyChanged("Indentation");
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0000B277 File Offset: 0x00009477
		// (set) Token: 0x06000266 RID: 614 RVA: 0x0000B289 File Offset: 0x00009489
		public global::System.Windows.DataTemplate ItemTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.ItemTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.ItemTemplateProperty, value);
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000B298 File Offset: 0x00009498
		private static void ItemTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = (global::Infragistics.Controls.Menus.XamDataTree)obj;
			xamDataTree.OnPropertyChanged("ItemTemplate");
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0000B2B7 File Offset: 0x000094B7
		// (set) Token: 0x06000269 RID: 617 RVA: 0x0000B2BF File Offset: 0x000094BF
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Menus.XamDataTreeNode ActiveNode
		{
			get
			{
				return this._activeNode;
			}
			set
			{
				this.SetActiveNode(value, global::Infragistics.Controls.Menus.TreeInvokeAction.Code, true);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0000B2CA File Offset: 0x000094CA
		// (set) Token: 0x0600026B RID: 619 RVA: 0x0000B2D7 File Offset: 0x000094D7
		public object ActiveDataItem
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.ActiveDataItemProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.ActiveDataItemProperty, value);
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000B2E8 File Offset: 0x000094E8
		private static void ActiveDataItemChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = (global::Infragistics.Controls.Menus.XamDataTree)obj;
			xamDataTree.ActiveDataItemResolved = e.NewValue;
			xamDataTree._oldDataItem = e.OldValue;
			if (!xamDataTree._ignoreActiveNodeChange)
			{
				xamDataTree.SetActiveNodeWhenLoadedNodes();
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000B324 File Offset: 0x00009524
		// (set) Token: 0x0600026E RID: 622 RVA: 0x0000B32C File Offset: 0x0000952C
		protected internal global::Infragistics.Controls.Menus.XamDataTreeNode CurrentEditNode { get; set; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0000B335 File Offset: 0x00009535
		// (set) Token: 0x06000270 RID: 624 RVA: 0x0000B347 File Offset: 0x00009547
		public bool ShowActiveNodeIndicator
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.ShowActiveNodeIndicatorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.ShowActiveNodeIndicatorProperty, value);
			}
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000B35C File Offset: 0x0000955C
		private static void ShowActiveNodeIndicatorChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = (global::Infragistics.Controls.Menus.XamDataTree)obj;
			xamDataTree.OnPropertyChanged("ShowActiveNodeIndicator");
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0000B37B File Offset: 0x0000957B
		// (set) Token: 0x06000273 RID: 627 RVA: 0x0000B3A2 File Offset: 0x000095A2
		public global::Infragistics.Controls.Menus.TreeSelectionSettings SelectionSettings
		{
			get
			{
				if (this._selectionSettings == null)
				{
					this._selectionSettings = new global::Infragistics.Controls.Menus.TreeSelectionSettings();
				}
				this._selectionSettings.Tree = this;
				return this._selectionSettings;
			}
			set
			{
				if (value != this._selectionSettings)
				{
					this._selectionSettings = value;
					this.OnPropertyChanged("SelectionSettings");
				}
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0000B3BF File Offset: 0x000095BF
		// (set) Token: 0x06000275 RID: 629 RVA: 0x0000B3D1 File Offset: 0x000095D1
		public global::System.Windows.Style ActiveNodeIndicatorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.ActiveNodeIndicatorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.ActiveNodeIndicatorStyleProperty, value);
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000B3E0 File Offset: 0x000095E0
		private static void ActiveNodeIndicatorStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = (global::Infragistics.Controls.Menus.XamDataTree)obj;
			xamDataTree.OnPropertyChanged("ActiveNodeIndicatorStyle");
			xamDataTree.ResetPanelNodes(true);
			xamDataTree.InvalidateScrollPanel(false);
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0000B40D File Offset: 0x0000960D
		// (set) Token: 0x06000278 RID: 632 RVA: 0x0000B41F File Offset: 0x0000961F
		public global::System.Windows.Style NodeStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.NodeStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.NodeStyleProperty, value);
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000B430 File Offset: 0x00009630
		private static void NodeStyleChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = (global::Infragistics.Controls.Menus.XamDataTree)obj;
			xamDataTree.OnPropertyChanged("NodeStyle");
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0000B44F File Offset: 0x0000964F
		// (set) Token: 0x0600027B RID: 635 RVA: 0x0000B476 File Offset: 0x00009676
		public global::Infragistics.Controls.Menus.TreeEditingSettings EditingSettings
		{
			get
			{
				if (this._editingSettings == null)
				{
					this._editingSettings = new global::Infragistics.Controls.Menus.TreeEditingSettings();
				}
				this._editingSettings.Tree = this;
				return this._editingSettings;
			}
			set
			{
				if (value != this._editingSettings)
				{
					this._editingSettings = value;
					this.OnPropertyChanged("EditingSettings");
				}
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0000B493 File Offset: 0x00009693
		// (set) Token: 0x0600027D RID: 637 RVA: 0x0000B4D4 File Offset: 0x000096D4
		public global::Infragistics.Controls.Menus.CheckBoxSettings CheckBoxSettings
		{
			get
			{
				if (this._checkBoxSettings == null)
				{
					this._checkBoxSettings = new global::Infragistics.Controls.Menus.CheckBoxSettings();
					this._checkBoxSettings.PropertyChanged += this.CheckBoxSettings_PropertyChanged;
				}
				this._checkBoxSettings.Tree = this;
				return this._checkBoxSettings;
			}
			set
			{
				if (value != this._checkBoxSettings)
				{
					if (this._checkBoxSettings != null)
					{
						this._checkBoxSettings.PropertyChanged -= this.CheckBoxSettings_PropertyChanged;
					}
					this._checkBoxSettings = value;
					if (this._checkBoxSettings != null)
					{
						this._checkBoxSettings.PropertyChanged += this.CheckBoxSettings_PropertyChanged;
					}
					this.OnPropertyChanged("CheckBoxSettings");
				}
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000B53A File Offset: 0x0000973A
		private void CheckBoxSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.OnPropertyChanged(e.PropertyName);
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0000B548 File Offset: 0x00009748
		// (set) Token: 0x06000280 RID: 640 RVA: 0x0000B55A File Offset: 0x0000975A
		public bool IsDraggable
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.IsDraggableProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.IsDraggableProperty, value);
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000B570 File Offset: 0x00009770
		private static void IsDraggableChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = (global::Infragistics.Controls.Menus.XamDataTree)obj;
			xamDataTree.OnPropertyChanged("IsDraggable");
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0000B58F File Offset: 0x0000978F
		// (set) Token: 0x06000283 RID: 643 RVA: 0x0000B5A1 File Offset: 0x000097A1
		public bool IsDropTarget
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.IsDropTargetProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.IsDropTargetProperty, value);
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000B5B4 File Offset: 0x000097B4
		private static void IsDropTargetChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = (global::Infragistics.Controls.Menus.XamDataTree)obj;
			xamDataTree.OnPropertyChanged("IsDropTarget");
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0000B5D3 File Offset: 0x000097D3
		// (set) Token: 0x06000286 RID: 646 RVA: 0x0000B5E5 File Offset: 0x000097E5
		public global::System.Windows.Visibility NodeLineVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.NodeLineVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.NodeLineVisibilityProperty, value);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000B5F8 File Offset: 0x000097F8
		private static void NodeLineVisibilityChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = (global::Infragistics.Controls.Menus.XamDataTree)obj;
			xamDataTree.OnPropertyChanged("NodeLineVisibility");
			if (xamDataTree.IsLoaded)
			{
				xamDataTree.InvalidateScrollPanel(true, true);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0000B627 File Offset: 0x00009827
		// (set) Token: 0x06000289 RID: 649 RVA: 0x0000B639 File Offset: 0x00009839
		public global::System.Windows.DataTemplate ExpandedIconTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.ExpandedIconTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.ExpandedIconTemplateProperty, value);
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000B648 File Offset: 0x00009848
		private static void ExpandedIconTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = (global::Infragistics.Controls.Menus.XamDataTree)obj;
			xamDataTree.OnPropertyChanged("ExpandedIconTemplate");
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0000B667 File Offset: 0x00009867
		// (set) Token: 0x0600028C RID: 652 RVA: 0x0000B679 File Offset: 0x00009879
		public global::System.Windows.DataTemplate CollapsedIconTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.CollapsedIconTemplateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.CollapsedIconTemplateProperty, value);
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000B688 File Offset: 0x00009888
		private static void CollapsedIconTemplateChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = (global::Infragistics.Controls.Menus.XamDataTree)obj;
			xamDataTree.OnPropertyChanged("CollapsedIconTemplate");
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000B6A7 File Offset: 0x000098A7
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0000B6B9 File Offset: 0x000098B9
		public bool EnsureNodeExpansion
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.EnsureNodeExpansionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.EnsureNodeExpansionProperty, value);
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000B6CC File Offset: 0x000098CC
		private static void EnsureNodeExpansionChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = (global::Infragistics.Controls.Menus.XamDataTree)obj;
			xamDataTree.OnPropertyChanged("EnsureNodeExpansion");
			if ((bool)e.NewValue)
			{
				xamDataTree.NodesManager.EnsureExpandedChildNodesAreRegistered();
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000291 RID: 657 RVA: 0x0000B704 File Offset: 0x00009904
		// (set) Token: 0x06000292 RID: 658 RVA: 0x0000B716 File Offset: 0x00009916
		public bool AllowDragDropCopy
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.AllowDragDropCopyProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.AllowDragDropCopyProperty, value);
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000B72C File Offset: 0x0000992C
		private static void OnIsTouchSupportEnabledChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = (global::Infragistics.Controls.Menus.XamDataTree)d;
			if (xamDataTree._scrollHelper != null)
			{
				xamDataTree._scrollHelper.IsEnabled = (bool)e.NewValue;
			}
			if (xamDataTree._panel != null)
			{
				xamDataTree._panel.SetCurrentValue(global::System.Windows.UIElement.IsManipulationEnabledProperty, global::Infragistics.KnownBoxes.FromValue((bool)e.NewValue));
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000B788 File Offset: 0x00009988
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0000B79A File Offset: 0x0000999A
		public bool IsTouchSupportEnabled
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.IsTouchSupportEnabledProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.IsTouchSupportEnabledProperty, value);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000B7AD File Offset: 0x000099AD
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0000B7BF File Offset: 0x000099BF
		public global::System.Windows.Style DefaultEditorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.DefaultEditorStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.DefaultEditorStyleProperty, value);
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000298 RID: 664 RVA: 0x0000B7CD File Offset: 0x000099CD
		// (set) Token: 0x06000299 RID: 665 RVA: 0x0000B7DF File Offset: 0x000099DF
		public object[] SelectedDataItems
		{
			get
			{
				return (object[])base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.SelectedDataItemsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.SelectedDataItemsProperty, value);
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000B7ED File Offset: 0x000099ED
		private static void OnSelectedDataItemsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Menus.XamDataTree)d).OnSelectedDataItemsChanged((object[])e.OldValue, (object[])e.NewValue);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000B812 File Offset: 0x00009A12
		private void OnSelectedDataItemsChanged(object[] oldValue, object[] newValue)
		{
			if (!this._isSettingSelectedDataItems && this.Nodes != null && this.Nodes.Count > 0)
			{
				this.SetSelectedDataItemsExternal(newValue);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000B839 File Offset: 0x00009A39
		// (set) Token: 0x0600029D RID: 669 RVA: 0x0000B84B File Offset: 0x00009A4B
		public string IsSelectedMemberPath
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.IsSelectedMemberPathProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Menus.XamDataTree.IsSelectedMemberPathProperty, value);
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000B859 File Offset: 0x00009A59
		private static void OnIsSelectedMemberPathChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Menus.XamDataTree)d).OnIsSelectedMemberPathChanged((string)e.OldValue, (string)e.NewValue);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000B87E File Offset: 0x00009A7E
		private void OnIsSelectedMemberPathChanged(string oldValue, string newValue)
		{
			this.ReflectChangesOverModel = string.IsNullOrEmpty(oldValue);
			this.IsSelectedMemberPathResolved = newValue;
			if (this.IsLoaded)
			{
				this.UpdateTreeSelectedItemsBySelectedMemberPath();
			}
			this.ReflectChangesOverModel = true;
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000B8A8 File Offset: 0x00009AA8
		protected internal global::System.Windows.Controls.Primitives.ScrollBar VerticalScrollBar
		{
			get
			{
				return this._verticalScrollbar;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		protected internal global::System.Windows.Controls.Primitives.ScrollBar HorizontalScrollBar
		{
			get
			{
				return this._horizontalScrollbar;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000B8B8 File Offset: 0x00009AB8
		protected internal global::Infragistics.Controls.Menus.XamDataTreeNodesManager NodesManager
		{
			get
			{
				return this._nodesManager;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0000B8C0 File Offset: 0x00009AC0
		protected internal global::Infragistics.Controls.Menus.Primitives.NodesPanel Panel
		{
			get
			{
				return this._panel;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		protected internal bool IsNodeDragging
		{
			get
			{
				return this.CurrentDraggingNode != null;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000B8D8 File Offset: 0x00009AD8
		internal global::Infragistics.Controls.Menus.InternalNodesCollection InternalNodes
		{
			get
			{
				if (this._internalNodes == null)
				{
					this._internalNodes = new global::Infragistics.Controls.Menus.InternalNodesCollection
					{
						RootNodesManager = this._nodesManager
					};
				}
				return this._internalNodes;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000B90C File Offset: 0x00009B0C
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x0000B914 File Offset: 0x00009B14
		internal new bool IsLoaded
		{
			get
			{
				return this._isLoaded;
			}
			set
			{
				this._isLoaded = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000B91D File Offset: 0x00009B1D
		internal global::System.Collections.Generic.Dictionary<string, object> EditNodeValues
		{
			get
			{
				return this._editCellValues;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000B925 File Offset: 0x00009B25
		// (set) Token: 0x060002AA RID: 682 RVA: 0x0000B92D File Offset: 0x00009B2D
		internal int NodeLayoutAddedToGlobalNodeLayoutCollectionCount { get; set; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0000B936 File Offset: 0x00009B36
		// (set) Token: 0x060002AC RID: 684 RVA: 0x0000B93E File Offset: 0x00009B3E
		internal global::Infragistics.Controls.Menus.XamDataTreeNode CurrentDraggingNode { get; set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002AD RID: 685 RVA: 0x0000B947 File Offset: 0x00009B47
		// (set) Token: 0x060002AE RID: 686 RVA: 0x0000B94F File Offset: 0x00009B4F
		internal string IsSelectedMemberPathResolved { get; set; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002AF RID: 687 RVA: 0x0000B958 File Offset: 0x00009B58
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x0000B960 File Offset: 0x00009B60
		internal bool ReflectChangesOverModel { get; set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0000B969 File Offset: 0x00009B69
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x0000B971 File Offset: 0x00009B71
		private object ActiveDataItemResolved { get; set; }

		// Token: 0x060002B3 RID: 691 RVA: 0x0000B97A File Offset: 0x00009B7A
		public void InvalidateScrollPanel(bool reset)
		{
			this.InvalidateScrollPanel(reset, false, false);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000B985 File Offset: 0x00009B85
		public void EnterEditMode(global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			this.EnterEditModeInternal(node);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000B98F File Offset: 0x00009B8F
		public bool ExitEditMode(bool cancel)
		{
			return this.ExitEditModeInternal(cancel);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x0000B998 File Offset: 0x00009B98
		protected internal void InvalidateScrollPanel(bool reset, bool resetVisibleNodes)
		{
			this.InvalidateScrollPanel(reset, false, resetVisibleNodes);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000B9A4 File Offset: 0x00009BA4
		protected internal void InvalidateScrollPanel(bool reset, bool resetScrollPosition, bool resetVisibleNodes)
		{
			if (this._panel != null)
			{
				this._panel.InvalidateMeasure();
				if (reset)
				{
					this._panel.ResetCachedScrollInfo(resetVisibleNodes);
				}
				if (resetScrollPosition)
				{
					if (this._horizontalScrollbar != null)
					{
						this._horizontalScrollbar.Value = 0.0;
					}
					if (this._verticalScrollbar != null)
					{
						this._verticalScrollbar.Value = 0.0;
					}
				}
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000BA0E File Offset: 0x00009C0E
		protected internal void ResetPanelNodes()
		{
			this.ResetPanelNodes(false);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000BA17 File Offset: 0x00009C17
		protected internal void ResetPanelNodes(bool releaseNodesPanels)
		{
			if (this.Panel != null)
			{
				this.Panel.ResetNodes(releaseNodesPanels);
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000BA2D File Offset: 0x00009C2D
		protected internal virtual void SetActiveNode(global::Infragistics.Controls.Menus.XamDataTreeNode node, global::Infragistics.Controls.Menus.TreeInvokeAction action)
		{
			this.SetActiveNode(node, action, false);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000BA38 File Offset: 0x00009C38
		protected internal virtual void SetActiveNode(global::Infragistics.Controls.Menus.XamDataTreeNode node, global::Infragistics.Controls.Menus.TreeInvokeAction action, bool scrollToView)
		{
			this.SetActiveNodeInternal(node, action, scrollToView);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000BA44 File Offset: 0x00009C44
		internal virtual bool SetActiveNodeInternal(global::Infragistics.Controls.Menus.XamDataTreeNode node, global::Infragistics.Controls.Menus.TreeInvokeAction action, bool scrollToView)
		{
			if (node == null && this.ActiveNode == null)
			{
				return false;
			}
			if (node != null && !node.IsEnabled)
			{
				return false;
			}
			bool result = false;
			if (this._activeNode != node)
			{
				global::Infragistics.Controls.Menus.ActiveNodeChangingEventArgs activeNodeChangingEventArgs = new global::Infragistics.Controls.Menus.ActiveNodeChangingEventArgs
				{
					OriginalActiveTreeNode = this.ActiveNode,
					NewActiveTreeNode = node
				};
				global::Infragistics.Controls.Menus.ActiveNodeChangedEventArgs args = new global::Infragistics.Controls.Menus.ActiveNodeChangedEventArgs
				{
					OriginalActiveTreeNode = this.ActiveNode,
					NewActiveTreeNode = node
				};
				this.OnActiveNodeChanging(activeNodeChangingEventArgs);
				if (!activeNodeChangingEventArgs.Cancel)
				{
					global::Infragistics.Controls.Menus.XamDataTreeNode activeNode = this._activeNode;
					this._activeNode = node;
					if (activeNode != null)
					{
						if (activeNode.IsEditing)
						{
							activeNode.NodeLayout.Tree.ExitEditMode(false);
						}
						activeNode.EnsureCurrentState();
						activeNode.RaiseIsActiveChanged();
					}
					if (this._activeNode != null)
					{
						this._activeNode.EnsureCurrentState();
						if (scrollToView)
						{
							this.ScrollNodeIntoView(node);
						}
						global::Infragistics.Controls.Menus.TreeEditingSettingsOverride editingSettings = this._activeNode.NodeLayout.EditingSettings;
						if (editingSettings.AllowEditingResolved && editingSettings.IsOnNodeActiveEditingEnabledResolved)
						{
							this.EnterEditModeInternal(this._activeNode);
						}
						this._activeNode.EnsureCurrentState();
						this._activeNode.RaiseIsActiveChanged();
					}
					object newValue;
					if (this._activeNode == null)
					{
						newValue = null;
					}
					else
					{
						newValue = this._activeNode.Data;
					}
					this._ignoreActiveNodeChange = true;
					global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(this, global::Infragistics.Controls.Menus.XamDataTree.ActiveDataItemProperty, newValue);
					this._ignoreActiveNodeChange = false;
					this.OnPropertyChanged("ActiveNode");
					this.OnActiveNodeChanged(args);
					result = true;
				}
			}
			bool flag = false;
			if (node != null && node.Control != null)
			{
				global::System.Windows.DependencyObject dependencyObject = global::Infragistics.PlatformProxy.GetFocusedElement(this) as global::System.Windows.DependencyObject;
				if (dependencyObject != null)
				{
					while (!flag && dependencyObject != null)
					{
						if (dependencyObject == node.Control)
						{
							flag = true;
						}
						else
						{
							dependencyObject = global::Infragistics.PlatformProxy.GetParent(dependencyObject);
						}
					}
				}
				if (!flag)
				{
					global::System.Windows.Controls.Control control = node.Control.Content as global::System.Windows.Controls.Control;
					if (control != null && control.IsHitTestVisible)
					{
						flag = control.Focus();
					}
				}
				if (!flag)
				{
					base.Dispatcher.BeginInvoke(new global::Infragistics.Controls.Menus.XamDataTreeUtilities.MethodInvoker(this.FocusActiveNode), null);
				}
			}
			return result;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000BC40 File Offset: 0x00009E40
		protected internal virtual bool EnterEditModeInternal(global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			if (node != null && !this._enteringEditMode)
			{
				if (node.IsHeader)
				{
					return false;
				}
				if (!node.IsEditing)
				{
					global::Infragistics.Controls.Menus.NodesManager manager = node.Manager;
					if (manager != null && !manager.DataManager.SupportsEditing)
					{
						return false;
					}
					this._enteringEditMode = true;
					if (this.ExitEditModeInternal(false))
					{
						if (string.IsNullOrEmpty(node.NodeLayout.DisplayMemberPathResolved) && node.NodeLayout.EditorTemplate == null)
						{
							this._enteringEditMode = false;
							return false;
						}
						if (!this.OnNodeEnteringEditMode(node))
						{
							global::System.ComponentModel.IEditableObject editableObject = node.Data as global::System.ComponentModel.IEditableObject;
							if (editableObject != null)
							{
								editableObject.BeginEdit();
							}
							this.EditNodeValues.Clear();
							this._originalNodeValues.Clear();
							this.ActiveNode = node;
							if (node.Control != null && !node.Control.IsEnabled)
							{
								this._enteringEditMode = false;
								return false;
							}
							object value = node.Value;
							this.EditNodeValues.Add(node.NodeLayout.DisplayMemberPathResolved, value);
							this._originalNodeValues.Add(node.NodeLayout.DisplayMemberPathResolved, value);
							if (node.Control == null)
							{
								this.Panel.RenderNode(node, double.PositiveInfinity);
								this.Panel.ScrollNodeIntoView(node);
							}
							node.EnterEditMode(true);
							this.OnNodeEnteredEditMode(node, node.Control.Content as global::System.Windows.FrameworkElement);
							this.AttachMouseDownToRootVis();
							this.InvalidateScrollPanel(false);
							this._enteringEditMode = false;
							return true;
						}
					}
					this._enteringEditMode = false;
				}
			}
			return false;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000BDC0 File Offset: 0x00009FC0
		protected internal virtual bool ExitEditModeInternal(bool cancel)
		{
			if (this.CurrentEditNode != null)
			{
				global::Infragistics.Controls.Menus.XamDataTreeNode currentEditNode = this.CurrentEditNode;
				global::System.Windows.FrameworkElement editor = null;
				if (currentEditNode.Control != null)
				{
					editor = (currentEditNode.Control.Content as global::System.Windows.FrameworkElement);
				}
				else
				{
					cancel = true;
				}
				this.EditNodeValues[currentEditNode.NodeLayout.DisplayMemberPathResolved] = currentEditNode.ResolveValueFromEditor();
				object newValue = this.EditNodeValues[currentEditNode.NodeLayout.DisplayMemberPathResolved];
				if (cancel)
				{
					newValue = this._originalNodeValues[currentEditNode.NodeLayout.DisplayMemberPathResolved];
				}
				global::Infragistics.Controls.Menus.TreeExitEditingEventArgs treeExitEditingEventArgs = new global::Infragistics.Controls.Menus.TreeExitEditingEventArgs
				{
					Node = currentEditNode,
					NewValue = newValue,
					EditingCanceled = cancel,
					Editor = editor
				};
				this.OnNodeExitEditingMode(treeExitEditingEventArgs);
				if (treeExitEditingEventArgs.Cancel)
				{
					return false;
				}
				this.CurrentEditNode = null;
				if (!currentEditNode.ExitEditMode(treeExitEditingEventArgs.NewValue, cancel))
				{
					global::System.Windows.FrameworkElement frameworkElement = this._editorRootVisual;
					if (frameworkElement == null)
					{
						frameworkElement = (this._editorRootVisual = (global::Infragistics.PlatformProxy.GetRootVisual(this) as global::System.Windows.FrameworkElement));
					}
					if (frameworkElement != null)
					{
						frameworkElement.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.RootVis_NodeEditing_MouseLeftButtonDown));
						frameworkElement.AddHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.RootVis_NodeEditing_MouseLeftButtonDown), true);
					}
					this.CurrentEditNode = currentEditNode;
					this.ScrollNodeIntoView(currentEditNode);
					return false;
				}
				global::System.ComponentModel.IEditableObject editableObject = currentEditNode.Data as global::System.ComponentModel.IEditableObject;
				if (editableObject != null)
				{
					if (cancel)
					{
						editableObject.CancelEdit();
					}
					else
					{
						editableObject.EndEdit();
					}
				}
				global::Infragistics.Controls.Menus.NodesManager manager = currentEditNode.Manager;
				if (manager != null)
				{
					if (cancel)
					{
						manager.DataManager.CancelEdit();
					}
					else
					{
						manager.DataManager.CommitEdit();
					}
				}
				this.OnExitedEditMode(currentEditNode);
				global::System.Windows.FrameworkElement editorRootVisual = this._editorRootVisual;
				if (editorRootVisual != null)
				{
					editorRootVisual.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.RootVis_NodeEditing_MouseLeftButtonDown));
					this._editorRootVisual = null;
				}
				this.InvalidateScrollPanel(false);
			}
			return true;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0000BF94 File Offset: 0x0000A194
		protected internal void UnselectNode(global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode)
		{
			global::Infragistics.Controls.Menus.SelectedNodesCollection selectedNodes = this.SelectionSettings.SelectedNodes;
			if (selectedNodes.Contains(xamDataTreeNode))
			{
				selectedNodes.Remove(xamDataTreeNode);
				this.UpdateItemSelectedMemberPathValue(xamDataTreeNode, false);
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000BFC8 File Offset: 0x0000A1C8
		protected internal bool SelectNode(global::Infragistics.Controls.Menus.XamDataTreeNode node, global::Infragistics.Controls.Menus.TreeInvokeAction action)
		{
			if (node == null || !node.IsEnabled)
			{
				return true;
			}
			global::Infragistics.Controls.Menus.SelectedNodesCollection selectedNodesCollection = new global::Infragistics.Controls.Menus.SelectedNodesCollection();
			bool result = false;
			global::Infragistics.Controls.Menus.TreeSelectionType treeSelectionType = this.SelectionSettings.NodeSelection;
			selectedNodesCollection.InternalAddRangeSilently(this.SelectionSettings.SelectedNodes);
			bool flag = (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Shift) == global::System.Windows.Input.ModifierKeys.Shift || action == global::Infragistics.Controls.Menus.TreeInvokeAction.MouseMove;
			bool flag2 = (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Control) == global::System.Windows.Input.ModifierKeys.Control || action == global::Infragistics.Controls.Menus.TreeInvokeAction.Code;
			if (treeSelectionType == global::Infragistics.Controls.Menus.TreeSelectionType.None && action == global::Infragistics.Controls.Menus.TreeInvokeAction.Code)
			{
				treeSelectionType = global::Infragistics.Controls.Menus.TreeSelectionType.Single;
			}
			if (treeSelectionType != global::Infragistics.Controls.Menus.TreeSelectionType.None)
			{
				global::Infragistics.Controls.Menus.SelectedNodesCollection selectedNodes = this.SelectionSettings.SelectedNodes;
				if (treeSelectionType == global::Infragistics.Controls.Menus.TreeSelectionType.Single)
				{
					selectedNodes.InternalResetItemsSilently();
					selectedNodes.SelectItem(node, false);
				}
				else if (flag && treeSelectionType == global::Infragistics.Controls.Menus.TreeSelectionType.Multiple)
				{
					if (flag)
					{
						if (selectedNodes.Count > 0)
						{
							global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = selectedNodes.PivotItem;
							if (xamDataTreeNode == null)
							{
								xamDataTreeNode = selectedNodes[selectedNodes.Count - 1];
							}
							int num = this.InternalNodes.IndexOf(xamDataTreeNode);
							int num2 = this.InternalNodes.IndexOf(node);
							if (selectedNodes.PivotItem != null)
							{
								int count = selectedNodes.ShiftSelectedItems.Count;
								for (int i = count - 1; i >= 0; i--)
								{
									int index = selectedNodes.IndexOf(selectedNodes.ShiftSelectedItems[i]);
									selectedNodes.InternalRemoveItemSilently(index);
								}
							}
							if (num < num2)
							{
								for (int j = num; j <= num2; j++)
								{
									global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode2 = this.InternalNodes[j];
									if (xamDataTreeNode2 != null)
									{
										selectedNodes.SelectItem(xamDataTreeNode2, true);
									}
								}
							}
							else
							{
								for (int k = num; k >= num2; k--)
								{
									global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode3 = this.InternalNodes[k];
									if (xamDataTreeNode3 != null)
									{
										selectedNodes.SelectItem(xamDataTreeNode3, true);
									}
								}
							}
						}
						else
						{
							selectedNodes.SelectItem(node, true);
						}
					}
					else if (flag2)
					{
						if (action == global::Infragistics.Controls.Menus.TreeInvokeAction.Click)
						{
							if (selectedNodes.Contains(node))
							{
								int index2 = selectedNodes.IndexOf(node);
								selectedNodes.InternalRemoveItemSilently(index2);
								result = true;
							}
							else
							{
								selectedNodes.SelectItem(node, false);
							}
						}
					}
					else
					{
						selectedNodes.InternalResetItemsSilently();
						selectedNodes.SelectItem(node, false);
					}
				}
				else if (flag2)
				{
					if (selectedNodes.Contains(node))
					{
						int index3 = selectedNodes.IndexOf(node);
						selectedNodes.InternalRemoveItemSilently(index3);
						result = true;
					}
					else
					{
						selectedNodes.SelectItem(node, false);
					}
				}
				else
				{
					selectedNodes.InternalResetItemsSilently();
					selectedNodes.SelectItem(node, false);
				}
				this._selectedItems = this.SelectionSettings.SelectedNodes.ToList<global::Infragistics.Controls.Menus.XamDataTreeNode>();
				this.SetSelectedDataItemsInternal();
				this.OnSelectedNodesCollectionChanged(selectedNodesCollection, this.SelectionSettings.SelectedNodes);
				this.InvalidateScrollPanel(false);
			}
			return result;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000C248 File Offset: 0x0000A448
		private void ApplyItemSource(global::System.Collections.IEnumerable itemSource)
		{
			if (this._nodesManager.ItemsSource != itemSource)
			{
				this._activeNode = null;
				this._nodesManager.ItemsSource = itemSource;
				if (this.HorizontalScrollBar != null)
				{
					this.HorizontalScrollBar.Value = 0.0;
					this.HorizontalScrollBar.Visibility = global::System.Windows.Visibility.Collapsed;
				}
				if (this.VerticalScrollBar != null)
				{
					this.VerticalScrollBar.Value = 0.0;
					this.VerticalScrollBar.Visibility = global::System.Windows.Visibility.Collapsed;
				}
			}
			this.InvalidateScrollPanel(true);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000C2CD File Offset: 0x0000A4CD
		internal global::Infragistics.Controls.Menus.XamDataTreeNodeControl GetNodeFromSource(global::System.Windows.DependencyObject obj)
		{
			return global::Infragistics.Controls.Menus.XamDataTree.GetNodeFromSource(obj, this);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000C2D8 File Offset: 0x0000A4D8
		internal static global::Infragistics.Controls.Menus.XamDataTreeNodeControl GetNodeFromSource(global::System.Windows.DependencyObject obj, global::Infragistics.Controls.Menus.XamDataTree sourceTree)
		{
			global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl = obj as global::Infragistics.Controls.Menus.XamDataTreeNodeControl;
			bool flag = xamDataTreeNodeControl != null;
			while (obj != null && xamDataTreeNodeControl == null)
			{
				global::System.Windows.DependencyObject parent = global::Infragistics.PlatformProxy.GetParent(obj);
				obj = parent;
				xamDataTreeNodeControl = (obj as global::Infragistics.Controls.Menus.XamDataTreeNodeControl);
				if (xamDataTreeNodeControl != null && xamDataTreeNodeControl.Node != null && xamDataTreeNodeControl.Node.NodeLayout != null && xamDataTreeNodeControl.Node.NodeLayout.Tree == sourceTree)
				{
					break;
				}
				xamDataTreeNodeControl = null;
				global::System.Windows.Controls.ContentPresenter contentPresenter = obj as global::System.Windows.Controls.ContentPresenter;
				if (contentPresenter != null)
				{
					flag = true;
				}
				if (obj is global::Infragistics.Controls.Primitives.ExpansionIndicator || obj is global::Infragistics.Controls.Menus.Primitives.NodeLineControl || obj is global::Infragistics.Controls.Menus.Primitives.NodeLineTerminator || obj is global::Infragistics.Controls.Menus.Primitives.NodeLinePanel)
				{
					break;
				}
				if (obj is global::System.Windows.Controls.ContentControl)
				{
					global::System.Windows.Controls.ContentControl contentControl = (global::System.Windows.Controls.ContentControl)obj;
					if (contentControl.Name == "ExpandedIcon" || contentControl.Name == "CollapsedIcon")
					{
						break;
					}
				}
			}
			if (!flag)
			{
				return null;
			}
			return xamDataTreeNodeControl;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000C3A8 File Offset: 0x0000A5A8
		private void EndSelectionDrag(bool resetMouseDownCell)
		{
			this._dragSelectType = global::Infragistics.Controls.Menus.TreeDragSelectType.None;
			base.ReleaseMouseCapture();
			if (this._selectNodesTimer != null)
			{
				this._selectNodesTimer.Stop();
			}
			if (resetMouseDownCell)
			{
				this._mouseDownNode = null;
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		private void FocusActiveNode()
		{
			if (this.ActiveNode != null && this.ActiveNode.Control != null)
			{
				this.ActiveNode.Control.Focus();
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000C3FC File Offset: 0x0000A5FC
		public void ScrollNodeIntoView(global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			if (node != null && this.Panel != null)
			{
				this.Panel.ScrollNodeIntoView(node);
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000C418 File Offset: 0x0000A618
		private void SetDefaultActiveNode()
		{
			if (this.CurrentEditNode == null && this.ActiveNode == null && this.Nodes.Count > 0)
			{
				for (int i = 0; i < this.Nodes.Count; i++)
				{
					global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = this.Nodes[i];
					if (xamDataTreeNode.IsEnabled)
					{
						this.SetActiveNode(xamDataTreeNode, global::Infragistics.Controls.Menus.TreeInvokeAction.Code);
						return;
					}
				}
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000C477 File Offset: 0x0000A677
		private void AttachMouseDownToRootVis()
		{
			base.Dispatcher.BeginInvoke(new global::System.Action(this.AttachMouseDownToRootVis_Helper), new object[0]);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000C498 File Offset: 0x0000A698
		private void AttachMouseDownToRootVis_Helper()
		{
			if (this.CurrentEditNode != null)
			{
				global::System.Windows.FrameworkElement frameworkElement = global::Infragistics.PlatformProxy.GetRootVisual(this) as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					frameworkElement.AddHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.RootVis_NodeEditing_MouseLeftButtonDown), true);
					this._editorRootVisual = frameworkElement;
				}
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000C4DB File Offset: 0x0000A6DB
		private void SetActiveNodeWhenLoadedNodes()
		{
			if (!this._ignoreActiveNodeChange)
			{
				this._shouldStopRecursion = false;
				this.SetActiveNodeByDataItem(this.Nodes, this.ActiveDataItemResolved, this._oldDataItem);
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000C504 File Offset: 0x0000A704
		internal void SetActiveNodeByDataItem(global::Infragistics.Controls.Menus.XamDataTreeNodesCollection nodesCollection, object dataItem, object oldDataItem)
		{
			if (nodesCollection == null)
			{
				return;
			}
			if (dataItem == null)
			{
				this.ActiveNode = null;
				this.OnPropertyChanged("ActiveDataItem");
				return;
			}
			foreach (global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode in nodesCollection)
			{
				if (this._shouldStopRecursion)
				{
					break;
				}
				if (xamDataTreeNode.Data.Equals(dataItem))
				{
					this.SetActiveNode(xamDataTreeNode, global::Infragistics.Controls.Menus.TreeInvokeAction.Code, true);
					this._oldDataItem = dataItem;
					this._shouldStopRecursion = true;
					this.OnPropertyChanged("ActiveDataItem");
					break;
				}
				this.SetActiveNodeByDataItem(xamDataTreeNode.Nodes, dataItem, oldDataItem);
				if (!this._shouldStopRecursion)
				{
					this._ignoreActiveNodeChange = true;
					global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(this, global::Infragistics.Controls.Menus.XamDataTree.ActiveDataItemProperty, oldDataItem);
					this._ignoreActiveNodeChange = false;
				}
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000C5CC File Offset: 0x0000A7CC
		internal void SetSelectedDataItemsExternal(object[] newItems)
		{
			this._pendingSelectedDataItemsOperation = ((newItems != null) ? newItems : global::System.DBNull.Value);
			this.ProcessPendingSelectedDataItems();
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
		private void ProcessPendingSelectedDataItems()
		{
			bool isInitialized = base.IsInitialized;
			bool flag = this.ItemsSource == null && this.SelectedDataItems != null && this.SelectedDataItems.Count<object>() > 0;
			if ((this.ItemsSource == null && !flag) || !isInitialized)
			{
				return;
			}
			bool flag2 = false;
			object[] array = this._pendingSelectedDataItemsOperation as object[];
			try
			{
				global::Infragistics.Controls.Menus.XamDataTreeNode[] nodesFromItems = this.GetNodesFromItems(array, true);
				if (nodesFromItems == null || nodesFromItems.Length == 0)
				{
					this.SelectionSettings.SelectedNodes.InternalResetItemsSilently();
					this._selectedItems.Clear();
					flag2 = (array != null);
				}
				else
				{
					global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode>();
					list.AddRange(nodesFromItems);
					if (this.SelectNewSelection(list))
					{
						flag2 = true;
					}
				}
			}
			finally
			{
				this._pendingSelectedDataItemsOperation = null;
				if (flag2)
				{
					this.SetSelectedDataItemsInternal();
				}
			}
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000C6BC File Offset: 0x0000A8BC
		private bool SelectNewSelection(global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode> nodes)
		{
			if (nodes.Count == 0)
			{
				return false;
			}
			global::Infragistics.Controls.Menus.SelectedNodesCollection selectedNodesCollection = new global::Infragistics.Controls.Menus.SelectedNodesCollection();
			selectedNodesCollection.InternalAddRangeSilently(this.SelectionSettings.SelectedNodes);
			global::Infragistics.Controls.Menus.SelectedNodesCollection selectedNodes = this.SelectionSettings.SelectedNodes;
			selectedNodes.InternalResetItemsSilently();
			foreach (global::Infragistics.Controls.Menus.XamDataTreeNode item in nodes)
			{
				selectedNodes.SelectItem(item, false);
			}
			this.OnSelectedNodesCollectionChanged(selectedNodesCollection, this.SelectionSettings.SelectedNodes);
			this._selectedItems = nodes;
			return true;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000C758 File Offset: 0x0000A958
		public global::Infragistics.Controls.Menus.XamDataTreeNode[] GetNodesFromItems(object[] items, bool recursive)
		{
			global::Infragistics.Controls.Menus.DataItemNodeMap dataItemNodeMap = new global::Infragistics.Controls.Menus.DataItemNodeMap(items);
			if (dataItemNodeMap._itemsRemainingToBeMapped == 0)
			{
				return new global::Infragistics.Controls.Menus.XamDataTreeNode[0];
			}
			this.NodesManager.LoadItemNodeMap(dataItemNodeMap, recursive, null);
			global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode>(dataItemNodeMap._map.Count);
			if (dataItemNodeMap._dataItemsForComparison != null && dataItemNodeMap._itemsRemainingToBeMapped == 0)
			{
				for (int i = 0; i < dataItemNodeMap._dataItemsForComparison.Length; i++)
				{
					global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode;
					if (dataItemNodeMap._map.TryGetValue(dataItemNodeMap._dataItemsForComparison[i], out xamDataTreeNode) && xamDataTreeNode != null)
					{
						list.Add(xamDataTreeNode);
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000C7E4 File Offset: 0x0000A9E4
		internal void SetSelectedDataItemsInternal()
		{
			if (this.VerifyPendingSelectedDataItems())
			{
				return;
			}
			this._isSettingSelectedDataItems = true;
			try
			{
				object[] selectedDataItems = this.SelectedDataItems;
				int num = (selectedDataItems != null) ? selectedDataItems.Length : 0;
				global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
				bool flag = false;
				if (this._selectedItems != null && this._selectedItems.Count > 0)
				{
					global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode> selectedItems = this._selectedItems;
					int count = selectedItems.Count;
					flag = (num != count);
					list = new global::System.Collections.Generic.List<object>(count);
					for (int i = 0; i < count; i++)
					{
						global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = selectedItems[i];
						if (xamDataTreeNode != null && xamDataTreeNode.Data != null)
						{
							object data = xamDataTreeNode.Data;
							list.Add(data);
							if (!flag)
							{
								flag = (data != selectedDataItems[i]);
							}
						}
						else
						{
							flag = true;
						}
					}
				}
				if (!flag)
				{
					flag = ((list != null) ? (list.Count != num) : (num > 0));
				}
				if (flag)
				{
					object[] newValue = (list != null) ? list.ToArray() : null;
					global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(this, global::Infragistics.Controls.Menus.XamDataTree.SelectedDataItemsProperty, newValue);
				}
			}
			finally
			{
				this._isSettingSelectedDataItems = false;
			}
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000C8F0 File Offset: 0x0000AAF0
		private void UpdateModelItems(global::Infragistics.Controls.Menus.SelectedNodesCollection previousSelectedNodesCollection, global::Infragistics.Controls.Menus.SelectedNodesCollection currentSelectedNodesCollection)
		{
			global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Menus.XamDataTreeNode> enumerable = previousSelectedNodesCollection.Except(currentSelectedNodesCollection);
			global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Menus.XamDataTreeNode> enumerable2 = currentSelectedNodesCollection.Except(previousSelectedNodesCollection);
			foreach (global::Infragistics.Controls.Menus.XamDataTreeNode node in enumerable2)
			{
				this.UpdateItemSelectedMemberPathValue(node, true);
			}
			foreach (global::Infragistics.Controls.Menus.XamDataTreeNode node2 in enumerable)
			{
				this.UpdateItemSelectedMemberPathValue(node2, false);
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000C98C File Offset: 0x0000AB8C
		private bool VerifyPendingSelectedDataItems()
		{
			if (this._pendingSelectedDataItemsOperation == null)
			{
				return false;
			}
			object[] array = this._pendingSelectedDataItemsOperation as object[];
			if (this.SelectionSettings.SelectedNodes == null || this.SelectionSettings.SelectedNodes.Count <= 0)
			{
				return array == null || array.Length <= 0;
			}
			if (array == null || array.Length == 0)
			{
				return false;
			}
			global::Infragistics.Controls.Menus.SelectedNodesCollection selectedNodes = this.SelectionSettings.SelectedNodes;
			int count = selectedNodes.Count;
			bool flag = count == array.Length;
			if (flag)
			{
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = selectedNodes[i];
					if (xamDataTreeNode == null || array[i] != xamDataTreeNode.Data)
					{
						flag = false;
						break;
					}
				}
			}
			return flag;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000CA34 File Offset: 0x0000AC34
		private void UpdateItemSelectedMemberPathValue(global::Infragistics.Controls.Menus.XamDataTreeNode node, bool isSelectedValue)
		{
			if (node == null || node.Manager == null || node.Manager.DataManager == null || global::Infragistics.DragDrop.DragDropManager.IsDragging || node.Data == null || node.NodeLayout == null || string.IsNullOrEmpty(node.NodeLayout.IsSelectedMemberPathResolved) || !this.ReflectChangesOverModel)
			{
				return;
			}
			object data = node.Data;
			global::Infragistics.DataManagerBase dataManager = node.Manager.DataManager;
			string isSelectedMemberPathResolved = node.NodeLayout.IsSelectedMemberPathResolved;
			if (!this.IsMemberPathValidInType(isSelectedMemberPathResolved, dataManager.CachedTypedInfo))
			{
				return;
			}
			global::System.Type left = global::Infragistics.DataManagerBase.ResolvePropertyTypeFromPropertyName(isSelectedMemberPathResolved, dataManager.CachedTypedInfo);
			if (left != typeof(bool))
			{
				return;
			}
			global::System.Type type = data.GetType();
			global::System.Reflection.PropertyInfo property = type.GetProperty(isSelectedMemberPathResolved);
			bool flag;
			if (property == null)
			{
				global::System.ComponentModel.PropertyDescriptorCollection propertyDescriptors = dataManager.CachedTypedInfo.PropertyDescriptors;
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor = propertyDescriptors[isSelectedMemberPathResolved];
				flag = bool.Parse(propertyDescriptor.GetValue(data).ToString());
			}
			else
			{
				flag = bool.Parse(property.GetValue(data, null).ToString());
			}
			if (flag != isSelectedValue)
			{
				node.SupressPropertyChangedEvent = true;
				if (property == null)
				{
					global::System.ComponentModel.PropertyDescriptorCollection propertyDescriptors2 = dataManager.CachedTypedInfo.PropertyDescriptors;
					global::System.ComponentModel.PropertyDescriptor propertyDescriptor2 = propertyDescriptors2[isSelectedMemberPathResolved];
					propertyDescriptor2.SetValue(data, isSelectedValue);
				}
				else
				{
					property.SetValue(data, isSelectedValue, null);
				}
				node.SupressPropertyChangedEvent = false;
			}
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000CB8C File Offset: 0x0000AD8C
		private void EnsureAllLayoutsWithIsSelectedMemberPathAreLoaded()
		{
			if (this._layoutsToGetSelectedDataItems.Count == 0)
			{
				if (string.IsNullOrEmpty(this.IsSelectedMemberPathResolved))
				{
					this.RegisterNodeLayoutsTree(this.GlobalNodeLayouts, true);
					if (this._layoutsToGetSelectedDataItems.Count == 0)
					{
						return;
					}
				}
				else if (this.GlobalNodeLayouts.Count > 0)
				{
					this.RegisterNodeLayoutsTree(this.GlobalNodeLayouts, false);
				}
			}
			this.EnsureNodeLayoutLoaded(this.Nodes.ToList<global::Infragistics.Controls.Menus.XamDataTreeNode>(), this._layoutsToGetSelectedDataItems);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000CC00 File Offset: 0x0000AE00
		private void RegisterNodeLayoutsTree(global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.Menus.NodeLayout> layouts, bool checkIsSelectedMember)
		{
			this._alreadyIteratedLayouts = new global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.NodeLayout>();
			this.RegisterNodeLayoutsTreeAux(this.GlobalNodeLayouts, true);
			this._alreadyIteratedLayouts.Clear();
			this._alreadyIteratedLayouts = null;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000CC2C File Offset: 0x0000AE2C
		private void RegisterNodeLayoutsTreeAux(global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.Menus.NodeLayout> layouts, bool checkIsSelectedMember)
		{
			foreach (global::Infragistics.Controls.Menus.NodeLayout nodeLayout in layouts)
			{
				if (!this._alreadyIteratedLayouts.Contains(nodeLayout))
				{
					this._alreadyIteratedLayouts.Add(nodeLayout);
				}
				if (checkIsSelectedMember)
				{
					if (!string.IsNullOrEmpty(nodeLayout.IsSelectedMemberPathResolved))
					{
						this.RegisterLayoutForSelectedDataItems(nodeLayout);
					}
				}
				else
				{
					this.RegisterLayoutForSelectedDataItems(nodeLayout);
				}
				if (nodeLayout.NodeLayouts.Count > 0)
				{
					if (nodeLayout.IsDefinedGlobally && nodeLayout.NodeLayouts.Contains(nodeLayout))
					{
						break;
					}
					if (!this._alreadyIteratedLayouts.Contains(nodeLayout))
					{
						this.RegisterNodeLayoutsTreeAux(nodeLayout.NodeLayouts, checkIsSelectedMember);
					}
				}
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
		internal void EnsureNodeLayoutLoaded(global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode> nodes, global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.NodeLayout> layoutsToLoad = null)
		{
			if (layoutsToLoad == null)
			{
				layoutsToLoad = this._layoutsToGetSelectedDataItems;
			}
			if (layoutsToLoad.Count == 0 || nodes == null)
			{
				return;
			}
			foreach (global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode in nodes)
			{
				if (xamDataTreeNode.HasChildren)
				{
					global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.NodeLayout> layoutsToLoad2 = layoutsToLoad;
					if (this.GlobalNodeLayouts.Count <= this.NodeLayoutAddedToGlobalNodeLayoutCollectionCount)
					{
						layoutsToLoad2 = layoutsToLoad.Except(new global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.NodeLayout>
						{
							xamDataTreeNode.Nodes[0].NodeLayout
						}).ToList<global::Infragistics.Controls.Menus.NodeLayout>();
					}
					this.EnsureNodeLayoutLoaded(xamDataTreeNode.Nodes.ToList<global::Infragistics.Controls.Menus.XamDataTreeNode>(), layoutsToLoad2);
				}
			}
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000CDAC File Offset: 0x0000AFAC
		internal void FillSelectedItemsBySelectedMemberPath(string isSelectedMemberPath, global::System.Collections.IEnumerable itemsSource, global::Infragistics.Controls.Menus.NodesManager manager)
		{
			if (manager == null || manager.DataManager == null || !this._fillSelectedDataItems || this.SelectionSettings.NodeSelection == global::Infragistics.Controls.Menus.TreeSelectionType.None)
			{
				return;
			}
			if (!string.IsNullOrEmpty(isSelectedMemberPath))
			{
				global::Infragistics.CachedTypedInfo cachedTypedInfo = manager.DataManager.CachedTypedInfo;
				this.VerifyMemberPathInType(isSelectedMemberPath, cachedTypedInfo);
				global::System.Type left = global::Infragistics.DataManagerBase.ResolvePropertyTypeFromPropertyName(isSelectedMemberPath, cachedTypedInfo);
				if (left == null || left != typeof(bool))
				{
					return;
				}
				global::System.Type right = null;
				global::System.Reflection.PropertyInfo propertyInfo = null;
				global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
				foreach (object obj in itemsSource)
				{
					global::System.Type type = obj.GetType();
					global::System.Reflection.PropertyInfo propertyInfo2;
					if (type == right)
					{
						propertyInfo2 = propertyInfo;
					}
					else
					{
						right = type;
						propertyInfo2 = (propertyInfo = type.GetProperty(isSelectedMemberPath));
					}
					bool flag;
					if (propertyInfo2 == null)
					{
						global::System.ComponentModel.PropertyDescriptorCollection propertyDescriptors = cachedTypedInfo.PropertyDescriptors;
						global::System.ComponentModel.PropertyDescriptor propertyDescriptor = propertyDescriptors[isSelectedMemberPath];
						flag = (bool)propertyDescriptor.GetValue(obj);
					}
					else
					{
						flag = (bool)propertyInfo2.GetValue(obj, null);
					}
					if (flag)
					{
						list.Add(obj);
					}
				}
				global::Infragistics.Controls.Menus.SelectedNodesCollection selectedNodesCollection = new global::Infragistics.Controls.Menus.SelectedNodesCollection();
				if (this.SelectionSettings.NodeSelection == global::Infragistics.Controls.Menus.TreeSelectionType.Single && list.Count > 0)
				{
					global::System.Collections.Generic.List<object> list2 = list.ToList<object>();
					this.SelectionSettings.SelectedNodes.InternalResetItemsSilently();
					list.RemoveRange(0, list.Count - 1);
					list2 = list2.Except(list.ToList<object>()).ToList<object>();
					if (list2.Count > 0)
					{
						global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode> managerNodesFromItems = manager.GetManagerNodesFromItems(list2);
						foreach (global::Infragistics.Controls.Menus.XamDataTreeNode item in managerNodesFromItems)
						{
							selectedNodesCollection.InternalAddItemSilently(selectedNodesCollection.Count, item);
						}
					}
				}
				global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode> managerNodesFromItems2 = manager.GetManagerNodesFromItems(list);
				foreach (global::Infragistics.Controls.Menus.XamDataTreeNode item2 in managerNodesFromItems2)
				{
					if (!this.SelectionSettings.SelectedNodes.Contains(item2))
					{
						this.SelectionSettings.SelectedNodes.SelectItem(item2, false);
					}
				}
				this._selectedItems = this.SelectionSettings.SelectedNodes.ToList<global::Infragistics.Controls.Menus.XamDataTreeNode>();
				this.SetSelectedDataItemsInternal();
				if (selectedNodesCollection.Count > 0)
				{
					bool reflectChangesOverModel = this.ReflectChangesOverModel;
					this.ReflectChangesOverModel = true;
					this.UpdateModelItems(selectedNodesCollection, this.SelectionSettings.SelectedNodes);
					this.ReflectChangesOverModel = reflectChangesOverModel;
				}
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000D068 File Offset: 0x0000B268
		private void VerifyMemberPathInType(string memberPath, global::Infragistics.CachedTypedInfo typedInfo)
		{
			if (!string.IsNullOrEmpty(memberPath) && !this.IsMemberPathValidInType(memberPath, typedInfo))
			{
				throw new global::System.ArgumentException(string.Format(global::Infragistics.SRDataTree.GetString("InvalidMember"), memberPath, typedInfo.CachedType.Name));
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		internal bool IsMemberPathValidInType(string memberPath, global::Infragistics.CachedTypedInfo typedInfo)
		{
			bool result = false;
			if (!string.IsNullOrEmpty(memberPath))
			{
				result = false;
				try
				{
					global::System.Type left = global::Infragistics.DataManagerBase.ResolvePropertyTypeFromPropertyName(memberPath, typedInfo);
					if (left != null)
					{
						result = true;
					}
				}
				catch
				{
				}
			}
			return result;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000D0F4 File Offset: 0x0000B2F4
		private void ProcessIsSelectedMemberPath(global::Infragistics.Controls.Menus.NodesManager manager, global::System.Collections.IEnumerable itemsSource)
		{
			global::Infragistics.Controls.Menus.SelectedNodesCollection selectedNodesCollection = new global::Infragistics.Controls.Menus.SelectedNodesCollection();
			selectedNodesCollection.InternalAddRangeSilently(this.SelectionSettings.SelectedNodes);
			this.EnsureAllLayoutsWithIsSelectedMemberPathAreLoaded();
			if (this._layoutsToGetSelectedDataItems.Count == 0)
			{
				return;
			}
			if (!string.IsNullOrEmpty(this.IsSelectedMemberPathResolved))
			{
				this.FillSelectedItemsBySelectedMemberPath(this.IsSelectedMemberPathResolved, itemsSource, manager);
			}
			if (selectedNodesCollection.Count > 0 || this.SelectionSettings.SelectedNodes.Count > 0)
			{
				this.OnSelectedNodesCollectionChanged(selectedNodesCollection, this.SelectionSettings.SelectedNodes);
			}
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000D178 File Offset: 0x0000B378
		private void UpdateNodesSelectedDataItems(global::Infragistics.Controls.Menus.XamDataTreeNodesCollection nodes)
		{
			foreach (global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode in nodes)
			{
				xamDataTreeNode.Manager.FillManagerSelectedItemsBySelectedMemberPath();
				if (xamDataTreeNode.Nodes.Count > 0)
				{
					this.UpdateNodesSelectedDataItems(xamDataTreeNode.Nodes);
				}
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000D1E0 File Offset: 0x0000B3E0
		private void UpdateTreeSelectedItemsBySelectedMemberPath()
		{
			global::Infragistics.Controls.Menus.SelectedNodesCollection selectedNodesCollection = new global::Infragistics.Controls.Menus.SelectedNodesCollection();
			selectedNodesCollection.InternalAddRangeSilently(this.SelectionSettings.SelectedNodes);
			this.SelectionSettings.SelectedNodes.InternalResetItemsSilently();
			foreach (global::Infragistics.Controls.Menus.NodeLayout layout in this.GlobalNodeLayouts)
			{
				this.UpdateLayoutSelectedItemsBySelectedMemberPath(layout, false, false);
			}
			this.OnSelectedNodesCollectionChanged(selectedNodesCollection, this.SelectionSettings.SelectedNodes);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000D268 File Offset: 0x0000B468
		internal void SetupPossibleExpandingNode(global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			if (node == null)
			{
				this._nodeExpanderTimer.Stop();
				this._draggingExpansionNode = null;
				return;
			}
			if (node != this._draggingExpansionNode && !node.IsExpanded && node.HasChildren)
			{
				this._nodeExpanderTimer.Stop();
				this._draggingExpansionNode = node;
				this._nodeExpanderTimer.Start();
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000D2C1 File Offset: 0x0000B4C1
		internal void CancelDragScrolling()
		{
			if (this._scrollNodesTimer != null)
			{
				this._scrollNodesTimer.Stop();
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000D2D6 File Offset: 0x0000B4D6
		internal void InvalidateMouseOverNode()
		{
			if (this._mouseOverNode != null)
			{
				this._mouseOverNode.IsMouseOver = false;
				if (this._mouseOverNode.Control != null)
				{
					this._mouseOverNode.Control.InternalCellMouseLeave(this._mouseOverNode);
				}
				this._mouseOverNode = null;
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000D316 File Offset: 0x0000B516
		internal void UpdateSelectedItems()
		{
			if (this.SelectionSettings.SelectedNodes != null && this._selectedItems != null)
			{
				this._selectedItems = this.SelectionSettings.SelectedNodes.ToList<global::Infragistics.Controls.Menus.XamDataTreeNode>();
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000D343 File Offset: 0x0000B543
		internal void RegisterLayoutForSelectedDataItems(global::Infragistics.Controls.Menus.NodeLayout layout)
		{
			if (layout == null || this._layoutsToGetSelectedDataItems.Contains(layout))
			{
				return;
			}
			this._layoutsToGetSelectedDataItems.Add(layout);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000D363 File Offset: 0x0000B563
		internal void UnregisterLayoutForSelectedDataItems(global::Infragistics.Controls.Menus.NodeLayout layout)
		{
			if (layout == null || !this._layoutsToGetSelectedDataItems.Contains(layout))
			{
				return;
			}
			this._layoutsToGetSelectedDataItems.Remove(layout);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000D384 File Offset: 0x0000B584
		internal void UpdateLayoutSelectedItemsBySelectedMemberPath(global::Infragistics.Controls.Menus.NodeLayout layout, bool fireSelectedChangedEvent = true, bool resetPreviouslySelectedItems = true)
		{
			global::Infragistics.Controls.Menus.SelectedNodesCollection selectedNodesCollection = new global::Infragistics.Controls.Menus.SelectedNodesCollection();
			selectedNodesCollection.InternalAddRangeSilently(this.SelectionSettings.SelectedNodes);
			if (resetPreviouslySelectedItems)
			{
				this.SelectionSettings.SelectedNodes.InternalResetItemsSilently();
			}
			this.UpdateNodesSelectedDataItems(this.Nodes);
			if (fireSelectedChangedEvent)
			{
				this.OnSelectedNodesCollectionChanged(selectedNodesCollection, this.SelectionSettings.SelectedNodes);
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000D3DC File Offset: 0x0000B5DC
		public static void RegisterResources(string name, global::System.Reflection.Assembly assembly)
		{
			global::SR.AddResource(name, assembly);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000D3E5 File Offset: 0x0000B5E5
		public static void UnregisterResources(string name)
		{
			global::SR.RemoveResource(name);
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060002E7 RID: 743 RVA: 0x0000D3F0 File Offset: 0x0000B5F0
		// (remove) Token: 0x060002E8 RID: 744 RVA: 0x0000D428 File Offset: 0x0000B628
		public event global::System.EventHandler<global::Infragistics.Controls.Menus.InitializeNodeEventArgs> InitializeNode;

		// Token: 0x060002E9 RID: 745 RVA: 0x0000D460 File Offset: 0x0000B660
		protected internal virtual void OnInitializeNode(global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			if (this.InitializeNode != null)
			{
				this.InitializeNode(this, new global::Infragistics.Controls.Menus.InitializeNodeEventArgs
				{
					Node = node
				});
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060002EA RID: 746 RVA: 0x0000D490 File Offset: 0x0000B690
		// (remove) Token: 0x060002EB RID: 747 RVA: 0x0000D4C8 File Offset: 0x0000B6C8
		public event global::System.EventHandler<global::Infragistics.Controls.Menus.CancellableNodeExpansionChangedEventArgs> NodeExpansionChanging;

		// Token: 0x060002EC RID: 748 RVA: 0x0000D500 File Offset: 0x0000B700
		protected internal virtual bool OnNodeExpansionChanging(global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			if (this.NodeExpansionChanging != null)
			{
				global::Infragistics.Controls.Menus.CancellableNodeExpansionChangedEventArgs cancellableNodeExpansionChangedEventArgs = new global::Infragistics.Controls.Menus.CancellableNodeExpansionChangedEventArgs
				{
					Node = node
				};
				this.NodeExpansionChanging(this, cancellableNodeExpansionChangedEventArgs);
				return cancellableNodeExpansionChangedEventArgs.Cancel;
			}
			return false;
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060002ED RID: 749 RVA: 0x0000D53C File Offset: 0x0000B73C
		// (remove) Token: 0x060002EE RID: 750 RVA: 0x0000D574 File Offset: 0x0000B774
		public event global::System.EventHandler<global::Infragistics.Controls.Menus.NodeExpansionChangedEventArgs> NodeExpansionChanged;

		// Token: 0x060002EF RID: 751 RVA: 0x0000D5AC File Offset: 0x0000B7AC
		protected internal virtual void OnNodeExpansionChanged(global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			if (this.NodeExpansionChanged != null)
			{
				this.NodeExpansionChanged(this, new global::Infragistics.Controls.Menus.NodeExpansionChangedEventArgs
				{
					Node = node
				});
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060002F0 RID: 752 RVA: 0x0000D5DC File Offset: 0x0000B7DC
		// (remove) Token: 0x060002F1 RID: 753 RVA: 0x0000D614 File Offset: 0x0000B814
		public event global::System.EventHandler<global::Infragistics.Controls.Menus.NodeEventArgs> NodeCheckedChanged;

		// Token: 0x060002F2 RID: 754 RVA: 0x0000D64C File Offset: 0x0000B84C
		protected internal virtual void OnNodeCheckChanged(global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			if (this.NodeCheckedChanged != null)
			{
				this.NodeCheckedChanged(this, new global::Infragistics.Controls.Menus.NodeEventArgs
				{
					Node = node
				});
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060002F3 RID: 755 RVA: 0x0000D67C File Offset: 0x0000B87C
		// (remove) Token: 0x060002F4 RID: 756 RVA: 0x0000D6B4 File Offset: 0x0000B8B4
		public event global::System.EventHandler<global::Infragistics.Controls.Menus.NodeLayoutAssignedEventArgs> NodeLayoutAssigned;

		// Token: 0x060002F5 RID: 757 RVA: 0x0000D6E9 File Offset: 0x0000B8E9
		protected internal virtual void OnNodeLayoutAssigned(global::Infragistics.Controls.Menus.NodeLayoutAssignedEventArgs args)
		{
			if (this.NodeLayoutAssigned != null)
			{
				this.NodeLayoutAssigned(this, args);
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060002F6 RID: 758 RVA: 0x0000D700 File Offset: 0x0000B900
		// (remove) Token: 0x060002F7 RID: 759 RVA: 0x0000D738 File Offset: 0x0000B938
		public event global::System.EventHandler<global::Infragistics.Controls.Menus.ActiveNodeChangedEventArgs> ActiveNodeChanged;

		// Token: 0x060002F8 RID: 760 RVA: 0x0000D76D File Offset: 0x0000B96D
		protected internal virtual void OnActiveNodeChanged(global::Infragistics.Controls.Menus.ActiveNodeChangedEventArgs args)
		{
			if (this.ActiveNodeChanged != null)
			{
				this.ActiveNodeChanged(this, args);
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060002F9 RID: 761 RVA: 0x0000D784 File Offset: 0x0000B984
		// (remove) Token: 0x060002FA RID: 762 RVA: 0x0000D7BC File Offset: 0x0000B9BC
		public event global::System.EventHandler<global::Infragistics.Controls.Menus.ActiveNodeChangingEventArgs> ActiveNodeChanging;

		// Token: 0x060002FB RID: 763 RVA: 0x0000D7F1 File Offset: 0x0000B9F1
		protected internal virtual void OnActiveNodeChanging(global::Infragistics.Controls.Menus.ActiveNodeChangingEventArgs args)
		{
			if (this.ActiveNodeChanging != null)
			{
				this.ActiveNodeChanging(this, args);
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060002FC RID: 764 RVA: 0x0000D808 File Offset: 0x0000BA08
		// (remove) Token: 0x060002FD RID: 765 RVA: 0x0000D840 File Offset: 0x0000BA40
		public event global::System.EventHandler<global::Infragistics.Controls.Menus.BeginEditingNodeEventArgs> NodeEnteringEditMode;

		// Token: 0x060002FE RID: 766 RVA: 0x0000D878 File Offset: 0x0000BA78
		protected internal virtual bool OnNodeEnteringEditMode(global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			if (this.NodeEnteringEditMode != null)
			{
				global::Infragistics.Controls.Menus.BeginEditingNodeEventArgs beginEditingNodeEventArgs = new global::Infragistics.Controls.Menus.BeginEditingNodeEventArgs
				{
					Node = node
				};
				this.NodeEnteringEditMode(this, beginEditingNodeEventArgs);
				return beginEditingNodeEventArgs.Cancel;
			}
			return false;
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060002FF RID: 767 RVA: 0x0000D8B4 File Offset: 0x0000BAB4
		// (remove) Token: 0x06000300 RID: 768 RVA: 0x0000D8EC File Offset: 0x0000BAEC
		public event global::System.EventHandler<global::Infragistics.Controls.Menus.TreeEditingNodeEventArgs> NodeEnteredEditMode;

		// Token: 0x06000301 RID: 769 RVA: 0x0000D924 File Offset: 0x0000BB24
		protected internal virtual void OnNodeEnteredEditMode(global::Infragistics.Controls.Menus.XamDataTreeNode node, global::System.Windows.FrameworkElement editor)
		{
			if (this.NodeEnteredEditMode != null)
			{
				this.NodeEnteredEditMode(this, new global::Infragistics.Controls.Menus.TreeEditingNodeEventArgs
				{
					Node = node,
					Editor = editor
				});
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000302 RID: 770 RVA: 0x0000D95C File Offset: 0x0000BB5C
		// (remove) Token: 0x06000303 RID: 771 RVA: 0x0000D994 File Offset: 0x0000BB94
		public event global::System.EventHandler<global::Infragistics.Controls.Menus.TreeExitEditingEventArgs> NodeExitingEditMode;

		// Token: 0x06000304 RID: 772 RVA: 0x0000D9C9 File Offset: 0x0000BBC9
		protected internal virtual void OnNodeExitEditingMode(global::Infragistics.Controls.Menus.TreeExitEditingEventArgs args)
		{
			if (this.NodeExitingEditMode != null)
			{
				this.NodeExitingEditMode(this, args);
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000305 RID: 773 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		// (remove) Token: 0x06000306 RID: 774 RVA: 0x0000DA18 File Offset: 0x0000BC18
		public event global::System.EventHandler<global::Infragistics.Controls.Menus.NodeValidationErrorEventArgs> NodeEditingValidationFailed;

		// Token: 0x06000307 RID: 775 RVA: 0x0000DA50 File Offset: 0x0000BC50
		protected internal virtual bool OnNodeEditingValidationFailed(global::Infragistics.Controls.Menus.XamDataTreeNode node, global::System.Windows.Controls.ValidationErrorEventArgs args)
		{
			if (this.NodeEditingValidationFailed != null)
			{
				global::Infragistics.Controls.Menus.NodeValidationErrorEventArgs nodeValidationErrorEventArgs = new global::Infragistics.Controls.Menus.NodeValidationErrorEventArgs
				{
					ValidationErrorEventArgs = args,
					Node = node
				};
				this.NodeEditingValidationFailed(this, nodeValidationErrorEventArgs);
				return nodeValidationErrorEventArgs.Handled;
			}
			return false;
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000308 RID: 776 RVA: 0x0000DA90 File Offset: 0x0000BC90
		// (remove) Token: 0x06000309 RID: 777 RVA: 0x0000DAC8 File Offset: 0x0000BCC8
		public event global::System.EventHandler<global::Infragistics.Controls.Menus.NodeEventArgs> NodeExitedEditMode;

		// Token: 0x0600030A RID: 778 RVA: 0x0000DB00 File Offset: 0x0000BD00
		protected internal virtual void OnExitedEditMode(global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			if (this.NodeExitedEditMode != null)
			{
				this.NodeExitedEditMode(this, new global::Infragistics.Controls.Menus.NodeEventArgs
				{
					Node = node
				});
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x0600030B RID: 779 RVA: 0x0000DB30 File Offset: 0x0000BD30
		// (remove) Token: 0x0600030C RID: 780 RVA: 0x0000DB68 File Offset: 0x0000BD68
		public event global::System.EventHandler<global::Infragistics.DragDrop.DragDropStartEventArgs> NodeDraggingStart;

		// Token: 0x0600030D RID: 781 RVA: 0x0000DB9D File Offset: 0x0000BD9D
		protected internal virtual void OnNodeDraggingStart(global::Infragistics.DragDrop.DragDropStartEventArgs e)
		{
			if (this.NodeDraggingStart != null)
			{
				this.NodeDraggingStart(this, e);
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x0600030E RID: 782 RVA: 0x0000DBB4 File Offset: 0x0000BDB4
		// (remove) Token: 0x0600030F RID: 783 RVA: 0x0000DBEC File Offset: 0x0000BDEC
		public event global::System.EventHandler<global::Infragistics.DragDrop.DragDropEventArgs> NodeDragCancel;

		// Token: 0x06000310 RID: 784 RVA: 0x0000DC21 File Offset: 0x0000BE21
		protected internal virtual void OnNodeDragCancel(global::Infragistics.DragDrop.DragDropEventArgs args)
		{
			if (this.NodeDragCancel != null)
			{
				this.NodeDragCancel(this, args);
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000311 RID: 785 RVA: 0x0000DC38 File Offset: 0x0000BE38
		// (remove) Token: 0x06000312 RID: 786 RVA: 0x0000DC70 File Offset: 0x0000BE70
		public event global::System.EventHandler<global::Infragistics.DragDrop.DragDropEventArgs> NodeDragEnd;

		// Token: 0x06000313 RID: 787 RVA: 0x0000DCA5 File Offset: 0x0000BEA5
		protected internal virtual void OnNodeDragEnd(global::Infragistics.DragDrop.DragDropEventArgs e)
		{
			if (this.NodeDragEnd != null)
			{
				this.NodeDragEnd(this, e);
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000314 RID: 788 RVA: 0x0000DCBC File Offset: 0x0000BEBC
		// (remove) Token: 0x06000315 RID: 789 RVA: 0x0000DCF4 File Offset: 0x0000BEF4
		public event global::System.EventHandler<global::Infragistics.Controls.Menus.TreeDropEventArgs> NodeDragDrop;

		// Token: 0x06000316 RID: 790 RVA: 0x0000DD29 File Offset: 0x0000BF29
		protected internal virtual void OnNodeDragDrop(global::Infragistics.Controls.Menus.TreeDropEventArgs e)
		{
			if (this.NodeDragDrop != null)
			{
				this.NodeDragDrop(this, e);
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000317 RID: 791 RVA: 0x0000DD40 File Offset: 0x0000BF40
		// (remove) Token: 0x06000318 RID: 792 RVA: 0x0000DD78 File Offset: 0x0000BF78
		public event global::System.EventHandler<global::Infragistics.Controls.Menus.NodeSelectionEventArgs> SelectedNodesCollectionChanged;

		// Token: 0x06000319 RID: 793 RVA: 0x0000DDB0 File Offset: 0x0000BFB0
		internal void OnSelectedNodesCollectionChanged(global::Infragistics.Controls.Menus.SelectedNodesCollection selectedNodesCollection, global::Infragistics.Controls.Menus.SelectedNodesCollection selectedNodesCollection_2)
		{
			this._deferClearingSelectionOnItemsSourceChanged = false;
			this.UpdateModelItems(selectedNodesCollection, selectedNodesCollection_2);
			if (this.SelectedNodesCollectionChanged != null)
			{
				global::Infragistics.Controls.Menus.NodeSelectionEventArgs nodeSelectionEventArgs = new global::Infragistics.Controls.Menus.NodeSelectionEventArgs();
				nodeSelectionEventArgs.OriginalSelectedNodes = selectedNodesCollection;
				nodeSelectionEventArgs.CurrentSelectedNodes = selectedNodesCollection_2;
				this.SelectedNodesCollectionChanged(this, nodeSelectionEventArgs);
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600031A RID: 794 RVA: 0x0000DDF8 File Offset: 0x0000BFF8
		// (remove) Token: 0x0600031B RID: 795 RVA: 0x0000DE30 File Offset: 0x0000C030
		public event global::System.EventHandler<global::Infragistics.Controls.Menus.TreeDataObjectCreationEventArgs> DataObjectRequested;

		// Token: 0x0600031C RID: 796 RVA: 0x0000DE68 File Offset: 0x0000C068
		protected internal virtual void OnDataObjectRequested(global::Infragistics.HandleableObjectGenerationEventArgs args, global::Infragistics.Controls.Menus.NodeLayout nodeLayout, global::Infragistics.Controls.Menus.XamDataTreeNode parentNode)
		{
			global::Infragistics.Controls.Menus.TreeDataObjectCreationEventArgs treeDataObjectCreationEventArgs = new global::Infragistics.Controls.Menus.TreeDataObjectCreationEventArgs();
			treeDataObjectCreationEventArgs.ObjectType = args.ObjectType;
			treeDataObjectCreationEventArgs.NodeLayout = nodeLayout;
			treeDataObjectCreationEventArgs.ParentNode = parentNode;
			treeDataObjectCreationEventArgs.CollectionType = args.CollectionType;
			if (this.DataObjectRequested != null)
			{
				this.DataObjectRequested(this, treeDataObjectCreationEventArgs);
			}
			args.NewObject = treeDataObjectCreationEventArgs.NewObject;
			if (args.NewObject != null)
			{
				args.Handled = true;
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x0600031D RID: 797 RVA: 0x0000DED4 File Offset: 0x0000C0D4
		// (remove) Token: 0x0600031E RID: 798 RVA: 0x0000DF0C File Offset: 0x0000C10C
		protected internal event global::System.EventHandler<global::Infragistics.Controls.Menus.CancellableNodeDeletionEventArgs> NodeDeleting;

		// Token: 0x0600031F RID: 799 RVA: 0x0000DF41 File Offset: 0x0000C141
		protected internal virtual void OnNodeDeleting(global::Infragistics.Controls.Menus.CancellableNodeDeletionEventArgs args)
		{
			if (this.NodeDeleting != null)
			{
				this.NodeDeleting(this, args);
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06000320 RID: 800 RVA: 0x0000DF58 File Offset: 0x0000C158
		// (remove) Token: 0x06000321 RID: 801 RVA: 0x0000DF90 File Offset: 0x0000C190
		protected internal event global::System.EventHandler<global::Infragistics.Controls.Menus.NodeDeletedEventArgs> NodeDeleted;

		// Token: 0x06000322 RID: 802 RVA: 0x0000DFC8 File Offset: 0x0000C1C8
		protected internal virtual void OnNodeDeleted(global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			if (this.NodeDeleted != null)
			{
				global::Infragistics.Controls.Menus.NodeDeletedEventArgs nodeDeletedEventArgs = new global::Infragistics.Controls.Menus.NodeDeletedEventArgs();
				nodeDeletedEventArgs.Node = node;
				this.NodeDeleted(this, nodeDeletedEventArgs);
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000DFF8 File Offset: 0x0000C1F8
		private void XamDataTree_Loaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::System.Collections.IEnumerable enumerable = (global::System.Collections.IEnumerable)base.GetValue(global::Infragistics.Controls.Menus.XamDataTree.ItemsSourceProperty);
			if (enumerable != null)
			{
				this._fillSelectedDataItems = false;
				this.ApplyItemSource(enumerable);
				this._fillSelectedDataItems = true;
				if (!this._isSettingSelectedDataItems && this.Nodes != null && this.Nodes.Count > 0 && this.SelectedDataItems != null && this.SelectedDataItems.Count<object>() > 0 && this.SelectionSettings.SelectedNodes != null && this.SelectionSettings.SelectedNodes.Count == 0)
				{
					this.SetSelectedDataItemsExternal(this.SelectedDataItems);
				}
			}
			this.IsLoaded = true;
			global::Infragistics.Controls.Menus.XamDataTree xamDataTree = sender as global::Infragistics.Controls.Menus.XamDataTree;
			if (this.ActiveDataItemResolved != null)
			{
				if (this._activeNode != null)
				{
					xamDataTree._ignoreActiveNodeChange = true;
					global::Infragistics.DependencyPropertyUtilities.SetCurrentValue(xamDataTree, global::Infragistics.Controls.Menus.XamDataTree.ActiveDataItemProperty, this._activeNode.Data);
					xamDataTree._ignoreActiveNodeChange = false;
				}
				else
				{
					this.SetActiveNodeWhenLoadedNodes();
				}
			}
			if (this._pendingSelectedDataItemsOperation != null)
			{
				this.ProcessPendingSelectedDataItems();
			}
			if (enumerable != null)
			{
				this.ProcessIsSelectedMemberPath(this.NodesManager, this.ItemsSource);
			}
			this._parentUIElement = global::Infragistics.PlatformProxy.GetRootVisual(this);
			if (this._parentUIElement != null)
			{
				this._parentUIElement.AddHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.XamDataTree_MouseLeftButtonUp), true);
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000E12C File Offset: 0x0000C32C
		private void XamDataTree_Unloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this._isLoaded = false;
			if (this.CurrentEditNode != null && this.CurrentEditNode.IsEditing)
			{
				this.ExitEditMode(true);
			}
			if (this._parentUIElement != null)
			{
				this._parentUIElement.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.XamDataTree_MouseLeftButtonUp));
				this._parentUIElement = null;
			}
			if (this._selectNodesTimer != null)
			{
				this._selectNodesTimer.Stop();
			}
			if (this._scrollNodesTimer != null)
			{
				this._scrollNodesTimer.Stop();
			}
			if (this._nodeExpanderTimer != null)
			{
				this._nodeExpanderTimer.Stop();
			}
			if (!global::Infragistics.Windows.Utilities.HasLoadedAncestor(this))
			{
				this.ResetPanelNodes(true);
			}
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000E1D0 File Offset: 0x0000C3D0
		private void HorizontalScrollbar_Scroll(object sender, global::System.Windows.Controls.Primitives.ScrollEventArgs e)
		{
			this.InvalidateScrollPanel(true, false);
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000E1DA File Offset: 0x0000C3DA
		private void VerticalScrollbar_Scroll(object sender, global::System.Windows.Controls.Primitives.ScrollEventArgs e)
		{
			this.InvalidateScrollPanel(false);
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000E1E4 File Offset: 0x0000C3E4
		private void NodeLayouts_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
			{
				using (global::System.Collections.IEnumerator enumerator = e.NewItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						global::Infragistics.Controls.Menus.NodeLayout nodeLayout = (global::Infragistics.Controls.Menus.NodeLayout)obj;
						nodeLayout.Tree = this;
					}
					return;
				}
			}
			if (e.OldItems != null)
			{
				foreach (object obj2 in e.OldItems)
				{
					global::Infragistics.Controls.Menus.NodeLayout nodeLayout2 = (global::Infragistics.Controls.Menus.NodeLayout)obj2;
					nodeLayout2.Tree = null;
				}
			}
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000E29C File Offset: 0x0000C49C
		private void XamDataTree_MouseLeftButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this._mouseDownPoint = null;
			this.EndSelectionDrag(false);
			if (this._mouseDownNode != null)
			{
				global::Infragistics.Controls.Menus.XamDataTreeNodeControl nodeFromSource = this.GetNodeFromSource(e.OriginalSource as global::System.Windows.DependencyObject);
				if (nodeFromSource != null && nodeFromSource.Node == this._mouseDownNode)
				{
					base.ReleaseMouseCapture();
					this._mouseDownNode.OnNodeClick();
				}
				this._mouseDownNode = null;
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000E2FF File Offset: 0x0000C4FF
		private void XamDataTree_KeyDown(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			if (e.Handled)
			{
				return;
			}
			if (this.CurrentEditNode != null)
			{
				e.Handled = this.CurrentEditNode.HandleKeyDown(e);
				return;
			}
			if (this.ActiveNode != null)
			{
				e.Handled = this.ActiveNode.HandleKeyDown(e);
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000E340 File Offset: 0x0000C540
		private void RootVis_NodeEditing_MouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject;
			global::Infragistics.Controls.Menus.XamDataTreeNodeControl nodeFromSource = this.GetNodeFromSource(dependencyObject);
			if (nodeFromSource == null && dependencyObject != null && global::Infragistics.PlatformProxy.GetParent(dependencyObject) == null)
			{
				return;
			}
			if (this.CurrentEditNode != null)
			{
			}
			if ((nodeFromSource == null || nodeFromSource.Node == null || this.CurrentEditNode != nodeFromSource.Node) && global::System.DateTime.Now - this._lastCancelledExitEditEvent > global::System.TimeSpan.FromSeconds(1.0))
			{
				this.ExitEditMode(false);
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000E3C0 File Offset: 0x0000C5C0
		private void XamDataTree_MouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			bool flag = false;
			long ticks = global::System.DateTime.Now.Ticks;
			this._mouseDownPoint = new global::System.Windows.Point?(e.GetPosition(null));
			if (this.CurrentEditNode != null)
			{
				bool flag2 = false;
				for (global::System.Windows.DependencyObject parent = global::Infragistics.PlatformProxy.GetParent(e.OriginalSource as global::System.Windows.DependencyObject); parent != null; parent = global::Infragistics.PlatformProxy.GetParent(parent))
				{
					if (parent == this.CurrentEditNode.Control)
					{
						flag2 = true;
						break;
					}
				}
				if (flag2)
				{
					return;
				}
			}
			this._skipDefaultActivation = true;
			if (!e.Handled)
			{
				base.Focus();
			}
			else if (!global::Infragistics.Controls.Menus.XamDataTreeNodeControl.IsFocusedControlInsideEditor(this))
			{
				base.Focus();
			}
			this._skipDefaultActivation = false;
			global::Infragistics.Controls.Menus.XamDataTreeNodeControl nodeFromSource = this.GetNodeFromSource(e.OriginalSource as global::System.Windows.DependencyObject);
			if (nodeFromSource != null && nodeFromSource.Node != null)
			{
				if (ticks - this._doubleClickTimeStamp <= 4000000L && nodeFromSource.Node == this._doubleClickNode)
				{
					flag = true;
				}
				this._doubleClickTimeStamp = global::System.DateTime.Now.Ticks;
				global::Infragistics.Controls.Menus.XamDataTreeNode node = nodeFromSource.Node;
				if (flag)
				{
					if (node == null || !node.IsEditing)
					{
						node.OnNodeDoubleClick();
					}
					this._doubleClickNode = (this._mouseDownNode = null);
					return;
				}
				if (!node.IsEditing)
				{
					this._lostCaptureDuringMouseDown = false;
					this._dragSelectType = node.OnNodeMouseDown(e);
					if (this._lostCaptureDuringMouseDown)
					{
						this._dragSelectType = global::Infragistics.Controls.Menus.TreeDragSelectType.None;
					}
					this._doubleClickNode = (this._mouseDownNode = node);
					return;
				}
			}
			else
			{
				this._doubleClickNode = (this._mouseDownNode = null);
			}
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000E53C File Offset: 0x0000C73C
		private void SelectRowsCellsTimer_Tick(object sender, global::System.EventArgs e)
		{
			global::System.Windows.Rect rect = global::System.Windows.Rect.Empty;
			try
			{
				global::System.Windows.Media.GeneralTransform generalTransform = this._panel.TransformToVisual(this);
				global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(this._panel);
				rect = generalTransform.TransformBounds(layoutSlot);
			}
			catch (global::System.ArgumentException)
			{
			}
			if (rect.IsEmpty)
			{
				this._selectNodesTimer.Stop();
				return;
			}
			double y = rect.Y;
			double num = y + this._panel.ActualHeight;
			double x = rect.X;
			double num2 = x + this._panel.ActualWidth;
			double num3 = this._mousePosition.Y;
			if (num3 < y)
			{
				num3 = y;
			}
			else if (num3 > num)
			{
				num3 = num - 1.0;
			}
			global::System.Collections.Generic.IEnumerable<global::System.Windows.UIElement> elementsFromPoint = global::Infragistics.PlatformProxy.GetElementsFromPoint(new global::System.Windows.Point(x, num3), this._panel);
			foreach (global::System.Windows.UIElement uielement in elementsFromPoint)
			{
				if (uielement is global::Infragistics.Controls.Menus.XamDataTreeNodeControl)
				{
					break;
				}
			}
			double num4 = this._mousePosition.X;
			if (num4 < x)
			{
				num4 = x;
			}
			else if (num4 > num2)
			{
				num4 = num2 - 1.0;
			}
			if (this._verticalScrollbar != null)
			{
				if (this._mousePosition.Y < y)
				{
					this._verticalScrollbar.Value -= 1.0;
				}
				else if (this._mousePosition.Y > num)
				{
					this._verticalScrollbar.Value += 1.0;
				}
			}
			elementsFromPoint = global::Infragistics.PlatformProxy.GetElementsFromPoint(new global::System.Windows.Point(num4, num3), this._panel);
			global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl = null;
			foreach (global::System.Windows.UIElement uielement2 in elementsFromPoint)
			{
				xamDataTreeNodeControl = (uielement2 as global::Infragistics.Controls.Menus.XamDataTreeNodeControl);
				if (xamDataTreeNodeControl != null)
				{
					break;
				}
			}
			if (xamDataTreeNodeControl != null && xamDataTreeNodeControl.Node != null && !this.IsNodeDragging && this._dragSelectType == global::Infragistics.Controls.Menus.TreeDragSelectType.Node)
			{
				this.SelectNode(xamDataTreeNodeControl.Node, global::Infragistics.Controls.Menus.TreeInvokeAction.MouseMove);
			}
			this.InvalidateScrollPanel(false);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000E770 File Offset: 0x0000C970
		private void XamDataTree_IsEnabledChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			this.InvalidateScrollPanel(false, true);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000E77C File Offset: 0x0000C97C
		private void ScrollNodesTimer_Tick(object sender, global::System.EventArgs e)
		{
			global::System.Windows.Rect rect = global::System.Windows.Rect.Empty;
			try
			{
				global::System.Windows.Media.GeneralTransform generalTransform = this._panel.TransformToVisual(this);
				global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(this._panel);
				rect = generalTransform.TransformBounds(layoutSlot);
			}
			catch (global::System.ArgumentException)
			{
			}
			if (rect.IsEmpty)
			{
				this._scrollNodesTimer.Stop();
				return;
			}
			if (!global::Infragistics.DragDrop.DragDropManager.IsDragging)
			{
				this._scrollNodesTimer.Stop();
				return;
			}
			double y = rect.Y;
			double num = y + this._panel.ActualHeight;
			double x = rect.X;
			double num2 = x + this._panel.ActualWidth;
			double num3 = this._mousePosition.Y;
			if (num3 < y)
			{
				num3 = y;
			}
			else if (num3 > num)
			{
				num3 = num - 1.0;
			}
			global::System.Collections.Generic.IEnumerable<global::System.Windows.UIElement> elementsFromPoint = global::Infragistics.PlatformProxy.GetElementsFromPoint(new global::System.Windows.Point(x, num3), this._panel);
			foreach (global::System.Windows.UIElement uielement in elementsFromPoint)
			{
				if (uielement is global::Infragistics.Controls.Menus.XamDataTreeNodeControl)
				{
					break;
				}
			}
			double x2 = this._mousePosition.X;
			if (x2 > x && x2 < num2 && this._verticalScrollbar != null)
			{
				int num4 = global::System.Convert.ToInt32(this.Panel.ActualHeight * 0.25);
				if (num4 > 40)
				{
					num4 = 40;
				}
				if (this._mousePosition.Y < y + (double)num4 && this._mousePosition.Y >= y)
				{
					this._verticalScrollbar.Value -= 0.1;
				}
				else if (this._mousePosition.Y > num - (double)num4 && this._mousePosition.Y <= num)
				{
					this._verticalScrollbar.Value += 0.1;
				}
			}
			this.InvalidateScrollPanel(false);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000E978 File Offset: 0x0000CB78
		private void NodeExpanderTimer_Tick(object sender, global::System.EventArgs e)
		{
			this._nodeExpanderTimer.Stop();
			if (this._draggingExpansionNode != null)
			{
				this._draggingExpansionNode.IsExpanded = true;
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000E99C File Offset: 0x0000CB9C
		internal void DragSource_DragOver(object sender, global::Infragistics.DragDrop.DragDropMoveEventArgs e)
		{
			if (this.Nodes.Count == 0)
			{
				global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl = e.DragSource as global::Infragistics.Controls.Menus.XamDataTreeNodeControl;
				if (xamDataTreeNodeControl != null)
				{
					if (global::Infragistics.Controls.Menus.XamDataTreeNodeControl.EnsureNodeCanBeAddedToCollection(this.NodesManager.DataManager, xamDataTreeNodeControl.Node))
					{
						e.OperationType = new global::Infragistics.DragDrop.OperationType?(global::Infragistics.DragDrop.OperationType.Move);
						global::System.Windows.VisualStateManager.GoToState(xamDataTreeNodeControl, "DropOnto", false);
						return;
					}
					e.OperationType = new global::Infragistics.DragDrop.OperationType?(global::Infragistics.DragDrop.OperationType.DropNotAllowed);
					global::System.Windows.VisualStateManager.GoToState(xamDataTreeNodeControl, "NoDrop", false);
				}
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000331 RID: 817 RVA: 0x0000EA10 File Offset: 0x0000CC10
		// (remove) Token: 0x06000332 RID: 818 RVA: 0x0000EA48 File Offset: 0x0000CC48
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000333 RID: 819 RVA: 0x0000EA7D File Offset: 0x0000CC7D
		protected virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0000EA99 File Offset: 0x0000CC99
		global::System.Windows.Controls.Primitives.ScrollBar global::Infragistics.IProvideScrollInfo.VerticalScrollBar
		{
			get
			{
				return this.VerticalScrollBar;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000335 RID: 821 RVA: 0x0000EAA1 File Offset: 0x0000CCA1
		global::System.Windows.Controls.Primitives.ScrollBar global::Infragistics.IProvideScrollInfo.HorizontalScrollBar
		{
			get
			{
				return this.HorizontalScrollBar;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000EAA9 File Offset: 0x0000CCA9
		global::Infragistics.Controls.ScrollType global::Infragistics.Controls.ISupportScrollHelper.VerticalScrollType
		{
			get
			{
				return global::Infragistics.Controls.ScrollType.Item;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000337 RID: 823 RVA: 0x0000EAAC File Offset: 0x0000CCAC
		global::Infragistics.Controls.ScrollType global::Infragistics.Controls.ISupportScrollHelper.HorizontalScrollType
		{
			get
			{
				return global::Infragistics.Controls.ScrollType.Pixel;
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000EAB0 File Offset: 0x0000CCB0
		double global::Infragistics.Controls.ISupportScrollHelper.GetFirstItemHeight()
		{
			if (this._panel != null && this._panel.VisibleNodes.Count > 0)
			{
				return this._panel.VisibleNodes[0].Control.DesiredSize.Height;
			}
			return 0.0;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000EB05 File Offset: 0x0000CD05
		double global::Infragistics.Controls.ISupportScrollHelper.GetFirstItemWidth()
		{
			return 0.0;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000EB10 File Offset: 0x0000CD10
		void global::Infragistics.Controls.ISupportScrollHelper.InvalidateScrollLayout()
		{
			this.InvalidateScrollPanel(false);
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x0600033B RID: 827 RVA: 0x0000EB19 File Offset: 0x0000CD19
		// (set) Token: 0x0600033C RID: 828 RVA: 0x0000EB38 File Offset: 0x0000CD38
		double global::Infragistics.Controls.ISupportScrollHelper.VerticalValue
		{
			get
			{
				if (this.VerticalScrollBar != null)
				{
					return this.VerticalScrollBar.Value;
				}
				return 0.0;
			}
			set
			{
				if (this.VerticalScrollBar != null)
				{
					this.VerticalScrollBar.Value = value;
				}
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0000EB4E File Offset: 0x0000CD4E
		double global::Infragistics.Controls.ISupportScrollHelper.VerticalMax
		{
			get
			{
				if (this.VerticalScrollBar != null)
				{
					return this.VerticalScrollBar.Maximum;
				}
				return 0.0;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0000EB6D File Offset: 0x0000CD6D
		// (set) Token: 0x0600033F RID: 831 RVA: 0x0000EB8C File Offset: 0x0000CD8C
		double global::Infragistics.Controls.ISupportScrollHelper.HorizontalValue
		{
			get
			{
				if (this.HorizontalScrollBar != null)
				{
					return this.HorizontalScrollBar.Value;
				}
				return 0.0;
			}
			set
			{
				if (this.HorizontalScrollBar != null)
				{
					this.HorizontalScrollBar.Value = value;
				}
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0000EBA2 File Offset: 0x0000CDA2
		double global::Infragistics.Controls.ISupportScrollHelper.HorizontalMax
		{
			get
			{
				if (this.HorizontalScrollBar != null)
				{
					return this.HorizontalScrollBar.Maximum;
				}
				return 0.0;
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000EBC1 File Offset: 0x0000CDC1
		private bool CanScroll(global::System.Windows.Controls.Primitives.ScrollBar sb)
		{
			return sb != null && sb.IsEnabled && sb.ViewportSize > 0.0 && sb.Maximum > sb.Minimum;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000EBF0 File Offset: 0x0000CDF0
		global::Infragistics.Controls.TouchScrollMode global::Infragistics.Controls.ISupportScrollHelper.GetScrollModeFromPoint(global::System.Windows.Point point, global::System.Windows.UIElement elementDirectlyOver)
		{
			if (!this.IsTouchSupportEnabled)
			{
				return global::Infragistics.Controls.TouchScrollMode.None;
			}
			bool flag = this.CanScroll(this.HorizontalScrollBar);
			bool flag2 = this.CanScroll(this.VerticalScrollBar);
			if (flag)
			{
				if (!flag2)
				{
					return global::Infragistics.Controls.TouchScrollMode.Horizontal;
				}
				return global::Infragistics.Controls.TouchScrollMode.Both;
			}
			else
			{
				if (!flag2)
				{
					return global::Infragistics.Controls.TouchScrollMode.None;
				}
				return global::Infragistics.Controls.TouchScrollMode.Vertical;
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000EC31 File Offset: 0x0000CE31
		void global::Infragistics.Controls.ISupportScrollHelper.OnPanComplete()
		{
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000EC33 File Offset: 0x0000CE33
		void global::Infragistics.Controls.ISupportScrollHelper.OnStateChanged(global::Infragistics.Controls.TouchState newState, global::Infragistics.Controls.TouchState oldState)
		{
		}

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Controls.Primitives.ScrollBar _verticalScrollbar;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Controls.Primitives.ScrollBar _horizontalScrollbar;

		// Token: 0x040000B4 RID: 180
		private global::Infragistics.Controls.Menus.Primitives.NodesPanel _panel;

		// Token: 0x040000B5 RID: 181
		private global::Infragistics.Controls.Menus.XamDataTreeNodesManager _nodesManager;

		// Token: 0x040000B6 RID: 182
		private bool _mouseIsOver;

		// Token: 0x040000B7 RID: 183
		private bool _enteringEditMode;

		// Token: 0x040000B8 RID: 184
		private bool _isLoaded;

		// Token: 0x040000B9 RID: 185
		private bool _skipDefaultActivation;

		// Token: 0x040000BA RID: 186
		private bool _ignoreActiveNodeChange;

		// Token: 0x040000BB RID: 187
		private bool _shouldStopRecursion;

		// Token: 0x040000BC RID: 188
		private bool _deferClearingSelectionOnItemsSourceChanged;

		// Token: 0x040000BD RID: 189
		private bool _fillSelectedDataItems;

		// Token: 0x040000BE RID: 190
		private global::Infragistics.Controls.Menus.InternalNodesCollection _internalNodes;

		// Token: 0x040000BF RID: 191
		private global::Infragistics.Controls.Menus.GlobalNodeLayoutCollection _globalNodeLayouts;

		// Token: 0x040000C0 RID: 192
		private global::Infragistics.Controls.Menus.TreeEditingSettings _editingSettings;

		// Token: 0x040000C1 RID: 193
		private global::Infragistics.Controls.Menus.TreeSelectionSettings _selectionSettings;

		// Token: 0x040000C2 RID: 194
		private global::Infragistics.Controls.Menus.XamDataTreeNode _activeNode;

		// Token: 0x040000C3 RID: 195
		private global::Infragistics.Controls.Menus.TreeDragSelectType _dragSelectType;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Point _mousePosition;

		// Token: 0x040000C5 RID: 197
		private object _oldDataItem;

		// Token: 0x040000C6 RID: 198
		private global::Infragistics.Controls.Menus.CheckBoxSettings _checkBoxSettings;

		// Token: 0x040000C7 RID: 199
		private global::Infragistics.Controls.Menus.XamDataTreeNode _mouseOverNode;

		// Token: 0x040000C8 RID: 200
		private global::System.Collections.Generic.Dictionary<string, object> _editCellValues;

		// Token: 0x040000C9 RID: 201
		private global::System.Collections.Generic.Dictionary<string, object> _originalNodeValues;

		// Token: 0x040000CA RID: 202
		private long _doubleClickTimeStamp;

		// Token: 0x040000CB RID: 203
		private global::Infragistics.Controls.Menus.XamDataTreeNode _doubleClickNode;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Threading.DispatcherTimer _selectNodesTimer;

		// Token: 0x040000CD RID: 205
		private global::System.Windows.FrameworkElement _editorRootVisual;

		// Token: 0x040000CE RID: 206
		private global::System.Windows.UIElement _parentUIElement;

		// Token: 0x040000CF RID: 207
		private global::System.Windows.Threading.DispatcherTimer _scrollNodesTimer;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Threading.DispatcherTimer _nodeExpanderTimer;

		// Token: 0x040000D1 RID: 209
		private global::Infragistics.Controls.Menus.XamDataTreeNode _draggingExpansionNode;

		// Token: 0x040000D2 RID: 210
		private global::System.DateTime _lastCancelledExitEditEvent;

		// Token: 0x040000D3 RID: 211
		private global::Infragistics.DragDrop.DropTarget _dropTarget;

		// Token: 0x040000D4 RID: 212
		private global::Infragistics.DragDrop.DragSource _dragSource;

		// Token: 0x040000D5 RID: 213
		private global::Infragistics.Controls.TouchScrollHelper _scrollHelper;

		// Token: 0x040000D6 RID: 214
		private object _pendingSelectedDataItemsOperation;

		// Token: 0x040000D7 RID: 215
		private bool _isSettingSelectedDataItems;

		// Token: 0x040000D8 RID: 216
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode> _selectedItems = new global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode>();

		// Token: 0x040000D9 RID: 217
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.NodeLayout> _layoutsToGetSelectedDataItems = new global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.NodeLayout>();

		// Token: 0x040000DA RID: 218
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.NodeLayout> _alreadyIteratedLayouts;

		// Token: 0x040000DB RID: 219
		private bool _lostCaptureDuringMouseDown;

		// Token: 0x040000DC RID: 220
		public static readonly global::System.Windows.DependencyProperty ItemsSourceProperty = global::System.Windows.DependencyProperty.Register("ItemsSource", typeof(global::System.Collections.IEnumerable), typeof(global::Infragistics.Controls.Menus.XamDataTree), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.ItemsSourceChanged)));

		// Token: 0x040000DD RID: 221
		public static readonly global::System.Windows.DependencyProperty MaxDepthProperty = global::System.Windows.DependencyProperty.Register("MaxDepth", typeof(int), typeof(global::Infragistics.Controls.Menus.XamDataTree), new global::System.Windows.PropertyMetadata(int.MaxValue, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.MaxDepthChanged)));

		// Token: 0x040000DE RID: 222
		public static readonly global::System.Windows.DependencyProperty DisplayMemberPathProperty = global::System.Windows.DependencyProperty.Register("DisplayMemberPath", typeof(string), typeof(global::Infragistics.Controls.Menus.XamDataTree), new global::System.Windows.PropertyMetadata("", new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.DisplayMemberPathChanged)));

		// Token: 0x040000DF RID: 223
		public static readonly global::System.Windows.DependencyProperty CheckBoxMemberPathProperty = global::System.Windows.DependencyProperty.Register("CheckBoxMemberPath", typeof(string), typeof(global::Infragistics.Controls.Menus.XamDataTree), new global::System.Windows.PropertyMetadata("", new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.CheckBoxMemberPathChanged)));

		// Token: 0x040000E0 RID: 224
		public static readonly global::System.Windows.DependencyProperty IsEnabledMemberPathProperty = global::Infragistics.DependencyPropertyUtilities.Register("IsEnabledMemberPath", typeof(string), typeof(global::Infragistics.Controls.Menus.XamDataTree), global::Infragistics.DependencyPropertyUtilities.CreateMetadata("", new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.OnIsEnabledMemberPathChanged)));

		// Token: 0x040000E1 RID: 225
		public static readonly global::System.Windows.DependencyProperty IsExpandedMemberPathProperty = global::System.Windows.DependencyProperty.Register("IsExpandedMemberPath", typeof(string), typeof(global::Infragistics.Controls.Menus.XamDataTree), new global::System.Windows.PropertyMetadata("", new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.IsExpandedMemberPathChanged)));

		// Token: 0x040000E2 RID: 226
		public static readonly global::System.Windows.DependencyProperty IndentationProperty = global::System.Windows.DependencyProperty.Register("Indentation", typeof(double), typeof(global::Infragistics.Controls.Menus.XamDataTree), new global::System.Windows.PropertyMetadata(21.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.IndentationChanged)));

		// Token: 0x040000E3 RID: 227
		public static readonly global::System.Windows.DependencyProperty ItemTemplateProperty = global::System.Windows.DependencyProperty.Register("ItemTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Menus.XamDataTree), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.ItemTemplateChanged)));

		// Token: 0x040000E4 RID: 228
		public static readonly global::System.Windows.DependencyProperty ActiveDataItemProperty = global::System.Windows.DependencyProperty.Register("ActiveDataItem", typeof(object), typeof(global::Infragistics.Controls.Menus.XamDataTree), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.ActiveDataItemChanged)));

		// Token: 0x040000E5 RID: 229
		public static readonly global::System.Windows.DependencyProperty ShowActiveNodeIndicatorProperty = global::System.Windows.DependencyProperty.Register("ShowActiveNodeIndicator", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamDataTree), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.ShowActiveNodeIndicatorChanged)));

		// Token: 0x040000E6 RID: 230
		public static readonly global::System.Windows.DependencyProperty ActiveNodeIndicatorStyleProperty = global::System.Windows.DependencyProperty.Register("ActiveNodeIndicatorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Menus.XamDataTree), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.ActiveNodeIndicatorStyleChanged)));

		// Token: 0x040000E7 RID: 231
		public static readonly global::System.Windows.DependencyProperty NodeStyleProperty = global::System.Windows.DependencyProperty.Register("NodeStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Menus.XamDataTree), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.NodeStyleChanged)));

		// Token: 0x040000E8 RID: 232
		public static readonly global::System.Windows.DependencyProperty IsDraggableProperty = global::System.Windows.DependencyProperty.Register("IsDraggable", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamDataTree), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.IsDraggableChanged)));

		// Token: 0x040000E9 RID: 233
		public static readonly global::System.Windows.DependencyProperty IsDropTargetProperty = global::System.Windows.DependencyProperty.Register("IsDropTarget", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamDataTree), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.IsDropTargetChanged)));

		// Token: 0x040000EA RID: 234
		public static readonly global::System.Windows.DependencyProperty NodeLineVisibilityProperty = global::System.Windows.DependencyProperty.Register("NodeLineVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Menus.XamDataTree), new global::System.Windows.PropertyMetadata(global::System.Windows.Visibility.Collapsed, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.NodeLineVisibilityChanged)));

		// Token: 0x040000EB RID: 235
		public static readonly global::System.Windows.DependencyProperty ExpandedIconTemplateProperty = global::System.Windows.DependencyProperty.Register("ExpandedIconTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Menus.XamDataTree), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.ExpandedIconTemplateChanged)));

		// Token: 0x040000EC RID: 236
		public static readonly global::System.Windows.DependencyProperty CollapsedIconTemplateProperty = global::System.Windows.DependencyProperty.Register("CollapsedIconTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Infragistics.Controls.Menus.XamDataTree), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.CollapsedIconTemplateChanged)));

		// Token: 0x040000ED RID: 237
		public static readonly global::System.Windows.DependencyProperty EnsureNodeExpansionProperty = global::System.Windows.DependencyProperty.Register("EnsureNodeExpansion", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamDataTree), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.EnsureNodeExpansionChanged)));

		// Token: 0x040000EE RID: 238
		public static readonly global::System.Windows.DependencyProperty AllowDragDropCopyProperty = global::System.Windows.DependencyProperty.Register("AllowDragDropCopy", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamDataTree), new global::System.Windows.PropertyMetadata(true));

		// Token: 0x040000EF RID: 239
		public static readonly global::System.Windows.DependencyProperty IsTouchSupportEnabledProperty = global::Infragistics.DependencyPropertyUtilities.Register("IsTouchSupportEnabled", typeof(bool), typeof(global::Infragistics.Controls.Menus.XamDataTree), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.OnIsTouchSupportEnabledChanged)));

		// Token: 0x040000F0 RID: 240
		public static readonly global::System.Windows.DependencyProperty DefaultEditorStyleProperty = global::System.Windows.DependencyProperty.Register("DefaultEditorStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Menus.XamDataTree), null);

		// Token: 0x040000F1 RID: 241
		public static readonly global::System.Windows.DependencyProperty SelectedDataItemsProperty = global::System.Windows.DependencyProperty.Register("SelectedDataItems", typeof(object[]), typeof(global::Infragistics.Controls.Menus.XamDataTree), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.OnSelectedDataItemsChanged), global::Infragistics.DependencyPropertyUtilities.MetadataOptionFlags.BindsTwoWayByDefault));

		// Token: 0x040000F2 RID: 242
		public static readonly global::System.Windows.DependencyProperty IsSelectedMemberPathProperty = global::System.Windows.DependencyProperty.Register("IsSelectedMemberPath", typeof(string), typeof(global::Infragistics.Controls.Menus.XamDataTree), new global::System.Windows.PropertyMetadata(string.Empty, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Menus.XamDataTree.OnIsSelectedMemberPathChanged)));

		// Token: 0x04000107 RID: 263
		private global::Infragistics.Controls.Menus.XamDataTreeNode _mouseDownNode;

		// Token: 0x04000108 RID: 264
		private global::System.Windows.Point? _mouseDownPoint;
	}
}
