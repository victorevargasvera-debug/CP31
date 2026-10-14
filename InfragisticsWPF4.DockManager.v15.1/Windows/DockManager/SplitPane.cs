using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;
using Infragistics.Collections;
using Infragistics.Windows.Automation.Peers.DockManager;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000034 RID: 52
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.Markup.ContentProperty("Panes")]
	public class SplitPane : global::System.Windows.FrameworkElement, global::Infragistics.Windows.DockManager.ISplitElementCollectionOwner, global::Infragistics.Windows.DockManager.IContentPaneContainer, global::Infragistics.Windows.DockManager.IPaneContainer
	{
		// Token: 0x060002B6 RID: 694 RVA: 0x0000DC7A File Offset: 0x0000BE7A
		public SplitPane()
		{
			this._panes = new global::Infragistics.Windows.DockManager.ObservableSplitElementCollection<global::System.Windows.FrameworkElement>(this, global::Infragistics.Windows.DockManager.PaneSplitterMode.BetweenPanes);
			this._panes.CollectionChanged += this.OnChildrenCollectionChanged;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000DCA8 File Offset: 0x0000BEA8
		static SplitPane()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.SplitPane), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DockManager.SplitPane)));
			global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.SplitPane), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.SplitPane.OnPaneLocationChanged)));
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.SplitPane), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.SplitPane.OnVisibilityChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.SplitPane.CoerceVisibility)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DockManager.SplitPane), global::Infragistics.Windows.DockManager.DockManagerUtilities.VisibilityChangedEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.DockManager.SplitPane.OnChildVisibilityChanged));
			global::System.Windows.FrameworkElement.WidthProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.SplitPane), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.SplitPane.CoerceWidth)));
			global::System.Windows.FrameworkElement.HeightProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.SplitPane), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.SplitPane.CoerceHeight)));
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000DEDC File Offset: 0x0000C0DC
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.SplitPane.PaneInfo> paneInfos = this._paneInfos;
			global::Infragistics.Windows.DockManager.SplitPane.PrepareForArrange(paneInfos, finalSize, this.SplitterOrientation);
			bool flag = this.SplitterOrientation == global::System.Windows.Controls.Orientation.Horizontal;
			bool flag2 = global::Infragistics.Windows.DockManager.DockManagerUtilities.IsFloating(global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this));
			global::Infragistics.Windows.DockManager.PaneToolWindow paneToolWindow = global::Infragistics.Windows.Controls.ToolWindow.GetToolWindow(this) as global::Infragistics.Windows.DockManager.PaneToolWindow;
			global::System.Windows.WindowState windowState = (paneToolWindow == null) ? global::System.Windows.WindowState.Normal : paneToolWindow.WindowState;
			int i = 0;
			int num = paneInfos.Count * 2 - 1;
			while (i < num)
			{
				bool flag3 = i % 2 == 1;
				int index = i / 2;
				global::Infragistics.Windows.DockManager.SplitPane.PaneInfo paneInfo = paneInfos[index];
				global::System.Windows.FrameworkElement frameworkElement;
				global::System.Windows.Rect finalRect;
				if (flag3)
				{
					frameworkElement = paneInfo.Splitter;
					finalRect = paneInfo.SplitterRect;
				}
				else
				{
					frameworkElement = paneInfo.Pane;
					finalRect = paneInfo.PaneRect;
				}
				if (frameworkElement != null)
				{
					bool flag4;
					if (flag)
					{
						flag4 = (finalRect.Height < frameworkElement.DesiredSize.Height && !global::Infragistics.Windows.DockManager.DockManagerUtilities.AreClose(finalRect.Height, frameworkElement.DesiredSize.Height));
					}
					else
					{
						flag4 = (finalRect.Width < frameworkElement.DesiredSize.Width && !global::Infragistics.Windows.DockManager.DockManagerUtilities.AreClose(finalRect.Width, frameworkElement.DesiredSize.Width));
					}
					if (flag4)
					{
						this._isMeasuringChild = true;
						frameworkElement.Measure(finalRect.Size);
						this._isMeasuringChild = false;
					}
					if (flag2 && windowState == global::System.Windows.WindowState.Normal && frameworkElement is global::Infragistics.Windows.DockManager.ContentPane)
					{
						global::System.Windows.Size size = finalRect.Size;
						if (paneToolWindow != null && !paneToolWindow.IsUsingOSNonClientArea)
						{
							size = paneToolWindow.AddNonClientSize(size);
						}
						((global::Infragistics.Windows.DockManager.ContentPane)frameworkElement).LastFloatingSize = size;
					}
					frameworkElement.Arrange(finalRect);
				}
				i++;
			}
			return finalSize;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000E082 File Offset: 0x0000C282
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DockManager.SplitPaneAutomationPeer(this);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000E08C File Offset: 0x0000C28C
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			return this._panes.GetVisualChild(index);
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0000E0A8 File Offset: 0x0000C2A8
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				if (this.IncludePanesAsLogicalChildren)
				{
					return new global::Infragistics.Collections.MultiSourceEnumerator(new global::System.Collections.IEnumerator[]
					{
						this._panes.GetSplitterEnumerator(),
						this._panes.GetEnumerator()
					});
				}
				return this._panes.GetSplitterEnumerator();
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000E0F4 File Offset: 0x0000C2F4
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.SplitPane.PaneInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.SplitPane.PaneInfo>();
			bool flag = this.SplitterOrientation == global::System.Windows.Controls.Orientation.Horizontal;
			global::System.Windows.Size result = default(global::System.Windows.Size);
			double num = 0.0;
			int i = 0;
			int count = this._panes.Count;
			while (i < count)
			{
				global::System.Windows.FrameworkElement frameworkElement = this._panes[i];
				if (frameworkElement.Visibility != global::System.Windows.Visibility.Collapsed)
				{
					global::Infragistics.Windows.DockManager.SplitPane.PaneInfo paneInfo = new global::Infragistics.Windows.DockManager.SplitPane.PaneInfo();
					paneInfo.Pane = frameworkElement;
					global::System.Windows.Size relativeSize = global::Infragistics.Windows.DockManager.SplitPane.GetRelativeSize(frameworkElement);
					paneInfo.Weight = global::System.Math.Max(flag ? relativeSize.Height : relativeSize.Width, 1.0);
					list.Add(paneInfo);
					num += paneInfo.Weight;
					global::Infragistics.Windows.DockManager.PaneSplitter splitter = global::Infragistics.Windows.DockManager.PaneSplitter.GetSplitter(frameworkElement);
					if (splitter != null)
					{
						splitter.Measure(availableSize);
						paneInfo.Splitter = splitter;
						paneInfo.SplitterSize = splitter.DesiredSize;
						global::System.Windows.Size splitterSize = paneInfo.SplitterSize;
						if (flag)
						{
							result.Height += splitterSize.Height;
							if (result.Width < splitterSize.Width)
							{
								result.Width = splitterSize.Width;
							}
						}
						else
						{
							result.Width += splitterSize.Width;
							if (result.Height < splitterSize.Height)
							{
								result.Height = splitterSize.Height;
							}
						}
					}
				}
				i++;
			}
			bool flag2 = double.IsPositiveInfinity(availableSize.Width);
			bool flag3 = double.IsPositiveInfinity(availableSize.Height);
			if (flag && !flag3)
			{
				availableSize.Height = global::System.Math.Max(availableSize.Height - result.Height, 0.0);
			}
			else if (!flag && !flag2)
			{
				availableSize.Width = global::System.Math.Max(availableSize.Width - result.Width, 0.0);
			}
			bool flag4 = flag && !flag3;
			bool flag5 = !flag && !flag2;
			int j = 0;
			int count2 = list.Count;
			while (j < count2)
			{
				global::Infragistics.Windows.DockManager.SplitPane.PaneInfo paneInfo2 = list[j];
				global::System.Windows.FrameworkElement pane = paneInfo2.Pane;
				global::System.Windows.Size availableSize2 = availableSize;
				double num2 = paneInfo2.Weight / num;
				if (flag4)
				{
					availableSize2.Height *= num2;
				}
				else if (flag5)
				{
					availableSize2.Width *= num2;
				}
				pane.Measure(availableSize2);
				global::System.Windows.Size desiredSize = pane.DesiredSize;
				if (flag)
				{
					result.Height += desiredSize.Height;
					result.Width = global::System.Math.Max(result.Width, desiredSize.Width);
				}
				else
				{
					result.Width += desiredSize.Width;
					result.Height = global::System.Math.Max(result.Height, desiredSize.Height);
				}
				paneInfo2.PaneSize = desiredSize;
				j++;
			}
			this._paneInfos = list;
			return result;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000E3D7 File Offset: 0x0000C5D7
		protected override void OnChildDesiredSizeChanged(global::System.Windows.UIElement child)
		{
			if (this._isMeasuringChild)
			{
				return;
			}
			base.OnChildDesiredSizeChanged(child);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000E3E9 File Offset: 0x0000C5E9
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			base.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
			global::Infragistics.Windows.DockManager.DockManagerUtilities.VerifyOwningToolWindow(this);
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060002BF RID: 703 RVA: 0x0000E403 File Offset: 0x0000C603
		protected override int VisualChildrenCount
		{
			get
			{
				return this._panes.VisualChildrenCount;
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000E410 File Offset: 0x0000C610
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::Infragistics.Windows.DockManager.ContentPane))]
		[global::System.Windows.AttachedPropertyBrowsableForChildren(IncludeDescendants = true)]
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::Infragistics.Windows.DockManager.TabGroupPane))]
		public static bool GetIsInFillPane(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.DockManager.SplitPane.IsInFillPaneProperty);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000E422 File Offset: 0x0000C622
		private static void SetIsInFillPane(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.DockManager.SplitPane.IsInFillPanePropertyKey, value);
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x0000E435 File Offset: 0x0000C635
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::Infragistics.Collections.ObservableCollectionExtended<global::System.Windows.FrameworkElement> Panes
		{
			get
			{
				return this._panes;
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000E440 File Offset: 0x0000C640
		private static bool ValidateRelativeSize(object value)
		{
			global::System.Windows.Size size = (global::System.Windows.Size)value;
			return size.Width > 0.0 && size.Height > 0.0 && !double.IsInfinity(size.Width) && !double.IsInfinity(size.Height);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000E497 File Offset: 0x0000C697
		[global::System.Windows.AttachedPropertyBrowsableForChildren(IncludeDescendants = false)]
		public static global::System.Windows.Size GetRelativeSize(global::System.Windows.DependencyObject d)
		{
			return (global::System.Windows.Size)d.GetValue(global::Infragistics.Windows.DockManager.SplitPane.RelativeSizeProperty);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000E4A9 File Offset: 0x0000C6A9
		public static void SetRelativeSize(global::System.Windows.DependencyObject d, global::System.Windows.Size value)
		{
			d.SetValue(global::Infragistics.Windows.DockManager.SplitPane.RelativeSizeProperty, value);
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000E4BC File Offset: 0x0000C6BC
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x0000E4CE File Offset: 0x0000C6CE
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.Orientation SplitterOrientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.DockManager.SplitPane.SplitterOrientationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.SplitPane.SplitterOrientationProperty, value);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000E4E1 File Offset: 0x0000C6E1
		internal virtual bool IncludePanesAsLogicalChildren
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000E4E4 File Offset: 0x0000C6E4
		internal bool IsDockedLeftRight
		{
			get
			{
				global::Infragistics.Windows.DockManager.PaneLocation paneLocation = global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this);
				return paneLocation == global::Infragistics.Windows.DockManager.PaneLocation.DockedLeft || paneLocation == global::Infragistics.Windows.DockManager.PaneLocation.DockedRight;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0000E504 File Offset: 0x0000C704
		internal bool IsDockedTopBottom
		{
			get
			{
				global::Infragistics.Windows.DockManager.PaneLocation paneLocation = global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this);
				return paneLocation == global::Infragistics.Windows.DockManager.PaneLocation.DockedTop || paneLocation == global::Infragistics.Windows.DockManager.PaneLocation.DockedBottom;
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000E524 File Offset: 0x0000C724
		private static void OnIsFillPaneChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::System.Windows.FrameworkElement.WidthProperty);
			d.CoerceValue(global::System.Windows.FrameworkElement.HeightProperty);
			d.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
			d.SetValue(global::Infragistics.Windows.DockManager.SplitPane.IsInFillPanePropertyKey, true.Equals(e.NewValue) ? e.NewValue : global::System.Windows.DependencyProperty.UnsetValue);
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060002CC RID: 716 RVA: 0x0000E57D File Offset: 0x0000C77D
		internal bool IsFillPane
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.SplitPane.IsFillPaneProperty);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0000E590 File Offset: 0x0000C790
		internal double HeightToSerialize
		{
			get
			{
				if (this._uncoercedHeight is double && global::System.Windows.DependencyPropertyHelper.GetValueSource(this, global::System.Windows.FrameworkElement.HeightProperty).IsCoerced)
				{
					return (double)this._uncoercedHeight;
				}
				return base.Height;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0000E5D4 File Offset: 0x0000C7D4
		internal double WidthToSerialize
		{
			get
			{
				if (this._uncoercedWidth is double && global::System.Windows.DependencyPropertyHelper.GetValueSource(this, global::System.Windows.FrameworkElement.WidthProperty).IsCoerced)
				{
					return (double)this._uncoercedWidth;
				}
				return base.Width;
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000E615 File Offset: 0x0000C815
		private static object CoerceVisibility(global::System.Windows.DependencyObject d, object newValue)
		{
			return global::Infragistics.Windows.DockManager.DockManagerUtilities.ProcessCoerceVisibility(d, newValue);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000E620 File Offset: 0x0000C820
		private static object CoerceHeight(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.DockManager.SplitPane splitPane = (global::Infragistics.Windows.DockManager.SplitPane)d;
			return splitPane.CoerceWidthHeight(newValue, ref splitPane._uncoercedHeight);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000E644 File Offset: 0x0000C844
		private static object CoerceWidth(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.DockManager.SplitPane splitPane = (global::Infragistics.Windows.DockManager.SplitPane)d;
			return splitPane.CoerceWidthHeight(newValue, ref splitPane._uncoercedWidth);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000E665 File Offset: 0x0000C865
		private object CoerceWidthHeight(object newValue, ref object _uncoercedValue)
		{
			if (this.IsFillPane)
			{
				_uncoercedValue = newValue;
				return global::Infragistics.Windows.DockManager.SplitPane.NaN;
			}
			_uncoercedValue = null;
			return newValue;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000E67C File Offset: 0x0000C87C
		private void OnChildrenCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.DockManagerUtilities.InitializeCurrentContainer(this.Panes, this, e);
			base.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
			global::Infragistics.Windows.DockManager.DockManagerUtilities.VerifyOwningToolWindow(this);
			base.InvalidateMeasure();
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000E6A4 File Offset: 0x0000C8A4
		private static void OnChildVisibilityChanged(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.SplitPane splitPane = (global::Infragistics.Windows.DockManager.SplitPane)sender;
			if (e.OriginalSource != sender)
			{
				splitPane._panes.RefreshSplitterVisibility();
				splitPane.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
				e.Handled = true;
			}
			global::Infragistics.Windows.DockManager.DockManagerUtilities.VerifyOwningToolWindow(splitPane);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000E6E4 File Offset: 0x0000C8E4
		private static void OnPaneLocationChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.SplitPane splitPane = (global::Infragistics.Windows.DockManager.SplitPane)d;
			if ((global::Infragistics.Windows.DockManager.PaneLocation)e.NewValue == global::Infragistics.Windows.DockManager.PaneLocation.Document)
			{
				foreach (global::System.Windows.FrameworkElement frameworkElement in splitPane.Panes)
				{
					if (!(frameworkElement is global::Infragistics.Windows.DockManager.TabGroupPane) && !(frameworkElement is global::Infragistics.Windows.DockManager.SplitPane))
					{
						throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_InvalidDocumentSplitPaneChild"));
					}
				}
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000E760 File Offset: 0x0000C960
		private static void OnVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DockManager.DockManagerUtilities.RaiseVisibilityChanged(d, e);
			global::Infragistics.Windows.DockManager.SplitPane splitPane = (global::Infragistics.Windows.DockManager.SplitPane)d;
			if (splitPane.Parent is global::Infragistics.Windows.DockManager.XamDockManager)
			{
				((global::Infragistics.Windows.DockManager.XamDockManager)splitPane.Parent).VerifyFillPane();
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000E798 File Offset: 0x0000C998
		internal global::System.Windows.Rect PredictDrop(global::System.Windows.Size relativeSize, int paneIndex)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.SplitPane.PaneInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.SplitPane.PaneInfo>();
			bool flag = this.SplitterOrientation == global::System.Windows.Controls.Orientation.Horizontal;
			global::Infragistics.Windows.DockManager.SplitPane.PaneInfo paneInfo = new global::Infragistics.Windows.DockManager.SplitPane.PaneInfo();
			paneInfo.Weight = (flag ? relativeSize.Height : relativeSize.Width);
			global::System.Windows.Size splitterSize = global::System.Windows.Size.Empty;
			int i = 0;
			int count = this._panes.Count;
			while (i < count)
			{
				if (i == paneIndex)
				{
					list.Add(paneInfo);
				}
				global::System.Windows.FrameworkElement frameworkElement = this._panes[i];
				if (splitterSize.IsEmpty)
				{
					global::Infragistics.Windows.DockManager.PaneSplitter splitter = global::Infragistics.Windows.DockManager.PaneSplitter.GetSplitter(frameworkElement);
					if (splitter != null)
					{
						splitterSize = new global::System.Windows.Size(splitter.ActualWidth, splitter.ActualHeight);
					}
				}
				if (frameworkElement != null && frameworkElement.Visibility != global::System.Windows.Visibility.Collapsed)
				{
					global::Infragistics.Windows.DockManager.SplitPane.PaneInfo paneInfo2 = new global::Infragistics.Windows.DockManager.SplitPane.PaneInfo();
					global::System.Windows.Size relativeSize2 = global::Infragistics.Windows.DockManager.SplitPane.GetRelativeSize(frameworkElement);
					paneInfo2.Weight = (flag ? relativeSize2.Height : relativeSize2.Width);
					list.Add(paneInfo2);
				}
				i++;
			}
			if (paneIndex >= this._panes.Count)
			{
				list.Add(paneInfo);
			}
			if (splitterSize.IsEmpty)
			{
				splitterSize = global::Infragistics.Windows.DockManager.SplitPane.DefaultSplitterSize;
			}
			int j = 0;
			int num = list.Count - 1;
			while (j < num)
			{
				list[j].SplitterSize = splitterSize;
				j++;
			}
			global::Infragistics.Windows.DockManager.SplitPane.PrepareForArrange(list, new global::System.Windows.Size(base.ActualWidth, base.ActualHeight), this.SplitterOrientation);
			return paneInfo.PaneRect;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000E8F4 File Offset: 0x0000CAF4
		internal static global::System.Windows.Rect PredictDropNewSplit(global::System.Windows.Controls.Dock side, global::System.Windows.FrameworkElement siblingElement)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.SplitPane.PaneInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.SplitPane.PaneInfo>();
			bool flag = side == global::System.Windows.Controls.Dock.Left || side == global::System.Windows.Controls.Dock.Right;
			list.Add(new global::Infragistics.Windows.DockManager.SplitPane.PaneInfo
			{
				Weight = 100.0
			});
			global::Infragistics.Windows.DockManager.SplitPane.PaneInfo paneInfo = new global::Infragistics.Windows.DockManager.SplitPane.PaneInfo();
			paneInfo.Weight = 100.0;
			int index = (side == global::System.Windows.Controls.Dock.Left || side == global::System.Windows.Controls.Dock.Top) ? 0 : 1;
			list.Insert(index, paneInfo);
			list[0].SplitterSize = global::Infragistics.Windows.DockManager.SplitPane.DefaultSplitterSize;
			global::Infragistics.Windows.DockManager.SplitPane.PrepareForArrange(list, new global::System.Windows.Size(siblingElement.ActualWidth, siblingElement.ActualHeight), flag ? global::System.Windows.Controls.Orientation.Vertical : global::System.Windows.Controls.Orientation.Horizontal);
			return paneInfo.PaneRect;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000E990 File Offset: 0x0000CB90
		private static void PrepareForArrange(global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.SplitPane.PaneInfo> panes, global::System.Windows.Size finalSize, global::System.Windows.Controls.Orientation splitterOrientation)
		{
			global::System.Windows.Rect rect = new global::System.Windows.Rect(finalSize);
			bool flag = splitterOrientation == global::System.Windows.Controls.Orientation.Horizontal;
			double num = 0.0;
			double num2 = flag ? finalSize.Height : finalSize.Width;
			int i = 0;
			int count = panes.Count;
			while (i < count)
			{
				global::Infragistics.Windows.DockManager.SplitPane.PaneInfo paneInfo = panes[i];
				num2 = global::System.Math.Max(num2 - (flag ? paneInfo.SplitterSize.Height : paneInfo.SplitterSize.Width), 0.0);
				num += paneInfo.Weight;
				i++;
			}
			int j = 0;
			int num3 = panes.Count * 2 - 1;
			while (j < num3)
			{
				bool flag2 = j % 2 == 1;
				int index = j / 2;
				global::Infragistics.Windows.DockManager.SplitPane.PaneInfo paneInfo2 = panes[index];
				global::System.Windows.Size splitterSize;
				if (flag2)
				{
					splitterSize = paneInfo2.SplitterSize;
				}
				else
				{
					double num4 = num2 * (paneInfo2.Weight / num);
					splitterSize = new global::System.Windows.Size(num4, num4);
				}
				global::System.Windows.Size size = finalSize;
				if (flag)
				{
					size.Height = splitterSize.Height;
				}
				else
				{
					size.Width = splitterSize.Width;
				}
				global::System.Windows.Rect rect2 = new global::System.Windows.Rect(rect.Location, size);
				if (flag2)
				{
					paneInfo2.SplitterRect = rect2;
				}
				else
				{
					paneInfo2.PaneRect = rect2;
				}
				if (flag)
				{
					rect.Height = global::System.Math.Max(rect.Height - size.Height, 0.0);
					rect.Y += size.Height;
				}
				else
				{
					rect.Width -= global::System.Math.Max(rect.Width - size.Width, 0.0);
					rect.X += size.Width;
				}
				j++;
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000EB50 File Offset: 0x0000CD50
		void global::Infragistics.Windows.DockManager.ISplitElementCollectionOwner.OnElementAdding(global::System.Windows.FrameworkElement newElement)
		{
			if (!(newElement is global::Infragistics.Windows.DockManager.SplitPane) && !(newElement is global::Infragistics.Windows.DockManager.TabGroupPane) && !(newElement is global::Infragistics.Windows.DockManager.ContentPanePlaceholder) && !(newElement is global::Infragistics.Windows.DockManager.ContentPane))
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_InvalidSplitPaneChild"));
			}
			if (global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this) == global::Infragistics.Windows.DockManager.PaneLocation.Document && !(newElement is global::Infragistics.Windows.DockManager.TabGroupPane) && !(newElement is global::Infragistics.Windows.DockManager.SplitPane))
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_InvalidDocumentSplitPaneChild"));
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000EBB6 File Offset: 0x0000CDB6
		void global::Infragistics.Windows.DockManager.ISplitElementCollectionOwner.OnElementAdded(global::System.Windows.FrameworkElement newElement)
		{
			if (this.IncludePanesAsLogicalChildren)
			{
				base.AddLogicalChild(newElement);
			}
			base.AddVisualChild(newElement);
			global::Infragistics.Windows.DockManager.DockManagerUtilities.InitializeCurrentContainer(newElement, this);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000EBD8 File Offset: 0x0000CDD8
		void global::Infragistics.Windows.DockManager.ISplitElementCollectionOwner.OnElementRemoved(global::System.Windows.FrameworkElement oldElement)
		{
			if (this._paneInfos != null)
			{
				for (int i = 0; i < this._paneInfos.Count; i++)
				{
					if (this._paneInfos[i].Pane == oldElement)
					{
						this._paneInfos.RemoveAt(i);
						break;
					}
				}
			}
			base.RemoveVisualChild(oldElement);
			if (this.IncludePanesAsLogicalChildren)
			{
				base.RemoveLogicalChild(oldElement);
			}
			global::Infragistics.Windows.DockManager.DockManagerUtilities.InitializeCurrentContainer(oldElement, null);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000EC42 File Offset: 0x0000CE42
		global::Infragistics.Windows.DockManager.PaneSplitter global::Infragistics.Windows.DockManager.ISplitElementCollectionOwner.CreateSplitter()
		{
			return new global::Infragistics.Windows.DockManager.SplitPaneSplitter();
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000EC49 File Offset: 0x0000CE49
		void global::Infragistics.Windows.DockManager.ISplitElementCollectionOwner.OnSplitterAdded(global::Infragistics.Windows.DockManager.PaneSplitter splitter)
		{
			splitter.SetBinding(global::Infragistics.Windows.DockManager.PaneSplitter.OrientationProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.DockManager.SplitPane.SplitterOrientationProperty, global::System.Windows.Data.BindingMode.OneWay, this));
			base.AddVisualChild(splitter);
			base.AddLogicalChild(splitter);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000EC74 File Offset: 0x0000CE74
		void global::Infragistics.Windows.DockManager.ISplitElementCollectionOwner.OnSplitterRemoved(global::Infragistics.Windows.DockManager.PaneSplitter splitter)
		{
			if (this._paneInfos != null)
			{
				for (int i = 0; i < this._paneInfos.Count; i++)
				{
					if (this._paneInfos[i].Splitter == splitter)
					{
						this._paneInfos[i].Splitter = null;
						break;
					}
				}
			}
			global::System.Windows.Data.BindingOperations.ClearBinding(splitter, global::Infragistics.Windows.DockManager.PaneSplitter.OrientationProperty);
			base.RemoveLogicalChild(splitter);
			base.RemoveVisualChild(splitter);
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x0000ECE0 File Offset: 0x0000CEE0
		global::System.Windows.FrameworkElement global::Infragistics.Windows.DockManager.IContentPaneContainer.ContainerElement
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000ECE3 File Offset: 0x0000CEE3
		global::Infragistics.Windows.DockManager.PaneLocation global::Infragistics.Windows.DockManager.IContentPaneContainer.PaneLocation
		{
			get
			{
				return global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this);
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000ECEC File Offset: 0x0000CEEC
		void global::Infragistics.Windows.DockManager.IContentPaneContainer.RemoveContentPane(global::Infragistics.Windows.DockManager.ContentPane pane, bool replaceWithPlaceholder)
		{
			int num = global::Infragistics.Windows.DockManager.DockManagerUtilities.IndexOf(this.Panes, pane, true);
			if (num >= 0)
			{
				global::System.Windows.FrameworkElement frameworkElement = this.Panes[num];
				if (frameworkElement is global::Infragistics.Windows.DockManager.ContentPanePlaceholder && replaceWithPlaceholder)
				{
					return;
				}
				this.Panes.RemoveAt(num);
				if (replaceWithPlaceholder)
				{
					global::Infragistics.Windows.DockManager.ContentPanePlaceholder contentPanePlaceholder = new global::Infragistics.Windows.DockManager.ContentPanePlaceholder();
					contentPanePlaceholder.Initialize(pane);
					this.Panes.Insert(num, contentPanePlaceholder);
					if (pane.ReadLocalValue(global::Infragistics.Windows.DockManager.SplitPane.RelativeSizeProperty) != global::System.Windows.DependencyProperty.UnsetValue)
					{
						contentPanePlaceholder.SetValue(global::Infragistics.Windows.DockManager.SplitPane.RelativeSizeProperty, pane.ReadLocalValue(global::Infragistics.Windows.DockManager.SplitPane.RelativeSizeProperty));
					}
					pane.PlacementInfo.StorePlaceholder(contentPanePlaceholder);
					return;
				}
				if (frameworkElement is global::Infragistics.Windows.DockManager.ContentPanePlaceholder)
				{
					pane.PlacementInfo.RemovePlaceholder((global::Infragistics.Windows.DockManager.ContentPanePlaceholder)frameworkElement);
				}
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000EDA0 File Offset: 0x0000CFA0
		void global::Infragistics.Windows.DockManager.IContentPaneContainer.InsertContentPane(int? newIndex, global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			int num = global::Infragistics.Windows.DockManager.DockManagerUtilities.IndexOf(this.Panes, pane, true);
			if (num >= 0)
			{
				if (this.Panes[num] is global::Infragistics.Windows.DockManager.ContentPane)
				{
					return;
				}
				global::Infragistics.Windows.DockManager.ContentPanePlaceholder contentPanePlaceholder = this.Panes[num] as global::Infragistics.Windows.DockManager.ContentPanePlaceholder;
				this.Panes.RemoveAt(num);
				pane.PlacementInfo.RemovePlaceholder(contentPanePlaceholder);
				pane.SetValue(global::Infragistics.Windows.DockManager.SplitPane.RelativeSizeProperty, contentPanePlaceholder.ReadLocalValue(global::Infragistics.Windows.DockManager.SplitPane.RelativeSizeProperty));
			}
			else
			{
				num = this.Panes.Count;
			}
			if (newIndex != null)
			{
				num = global::System.Math.Max(0, global::System.Math.Min(this.Panes.Count, newIndex.Value));
			}
			this.Panes.Insert(num, pane);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000EE55 File Offset: 0x0000D055
		global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> global::Infragistics.Windows.DockManager.IContentPaneContainer.GetVisiblePanes()
		{
			return global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateVisiblePaneList(this.Panes);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000EE64 File Offset: 0x0000D064
		global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> global::Infragistics.Windows.DockManager.IContentPaneContainer.GetAllPanesForPaneAction(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			return new global::Infragistics.Windows.DockManager.ContentPane[]
			{
				pane
			};
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x0000EE7D File Offset: 0x0000D07D
		global::System.Collections.IList global::Infragistics.Windows.DockManager.IPaneContainer.Panes
		{
			get
			{
				return this.Panes;
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000EE88 File Offset: 0x0000D088
		bool global::Infragistics.Windows.DockManager.IPaneContainer.RemovePane(object pane)
		{
			global::System.Windows.FrameworkElement frameworkElement = pane as global::System.Windows.FrameworkElement;
			int num = (frameworkElement != null) ? this.Panes.IndexOf(frameworkElement) : -1;
			if (num >= 0)
			{
				this.Panes.RemoveAt(num);
			}
			return num >= 0;
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x0000EEC6 File Offset: 0x0000D0C6
		bool global::Infragistics.Windows.DockManager.IPaneContainer.CanBeRemoved
		{
			get
			{
				return this.Panes.Count == 0 && !global::Infragistics.Windows.DockManager.DockManagerUtilities.ShouldPreventPaneRemoval(this);
			}
		}

		// Token: 0x04000174 RID: 372
		private global::Infragistics.Windows.DockManager.ObservableSplitElementCollection<global::System.Windows.FrameworkElement> _panes;

		// Token: 0x04000175 RID: 373
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.SplitPane.PaneInfo> _paneInfos;

		// Token: 0x04000176 RID: 374
		private bool _isMeasuringChild;

		// Token: 0x04000177 RID: 375
		private static readonly global::System.Windows.Size DefaultSplitterSize = new global::System.Windows.Size(4.0, 4.0);

		// Token: 0x04000178 RID: 376
		private static readonly object NaN = double.NaN;

		// Token: 0x04000179 RID: 377
		private object _uncoercedWidth;

		// Token: 0x0400017A RID: 378
		private object _uncoercedHeight;

		// Token: 0x0400017B RID: 379
		internal static readonly global::System.Windows.DependencyPropertyKey IsInFillPanePropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsInFillPane", typeof(bool), typeof(global::Infragistics.Windows.DockManager.SplitPane), new global::System.Windows.FrameworkPropertyMetadata((bool)global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));

		// Token: 0x0400017C RID: 380
		public static readonly global::System.Windows.DependencyProperty IsInFillPaneProperty = global::Infragistics.Windows.DockManager.SplitPane.IsInFillPanePropertyKey.DependencyProperty;

		// Token: 0x0400017D RID: 381
		public static readonly global::System.Windows.DependencyProperty RelativeSizeProperty = global::System.Windows.DependencyProperty.RegisterAttached("RelativeSize", typeof(global::System.Windows.Size), typeof(global::Infragistics.Windows.DockManager.SplitPane), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.Size(100.0, 100.0), global::System.Windows.FrameworkPropertyMetadataOptions.AffectsParentMeasure), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.DockManager.SplitPane.ValidateRelativeSize));

		// Token: 0x0400017E RID: 382
		public static readonly global::System.Windows.DependencyProperty SplitterOrientationProperty = global::System.Windows.DependencyProperty.Register("SplitterOrientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DockManager.SplitPane), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Vertical, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure | global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange));

		// Token: 0x0400017F RID: 383
		internal static readonly global::System.Windows.DependencyPropertyKey IsFillPanePropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsFillPane", typeof(bool), typeof(global::Infragistics.Windows.DockManager.SplitPane), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.SplitPane.OnIsFillPaneChanged)));

		// Token: 0x04000180 RID: 384
		internal static readonly global::System.Windows.DependencyProperty IsFillPaneProperty = global::Infragistics.Windows.DockManager.SplitPane.IsFillPanePropertyKey.DependencyProperty;

		// Token: 0x02000035 RID: 53
		private class PaneInfo
		{
			// Token: 0x04000181 RID: 385
			internal global::System.Windows.FrameworkElement Pane;

			// Token: 0x04000182 RID: 386
			internal global::Infragistics.Windows.DockManager.PaneSplitter Splitter;

			// Token: 0x04000183 RID: 387
			internal double Weight;

			// Token: 0x04000184 RID: 388
			internal global::System.Windows.Size SplitterSize;

			// Token: 0x04000185 RID: 389
			internal global::System.Windows.Size PaneSize;

			// Token: 0x04000186 RID: 390
			internal global::System.Windows.Rect PaneRect;

			// Token: 0x04000187 RID: 391
			internal global::System.Windows.Rect SplitterRect;
		}
	}
}
