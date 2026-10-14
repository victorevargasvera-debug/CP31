using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000137 RID: 311
	[global::System.Windows.TemplatePart(Name = "Popup", Type = typeof(global::System.Windows.Controls.Primitives.Popup))]
	public class HeaderDropDownControl : global::System.Windows.Controls.ContentControl, global::Infragistics.ICommandTarget
	{
		// Token: 0x06000A48 RID: 2632 RVA: 0x00027588 File Offset: 0x00025788
		static HeaderDropDownControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00027672 File Offset: 0x00025872
		public HeaderDropDownControl()
		{
			base.Loaded += this.HeaderDropDownControl_Loaded;
			base.Unloaded += this.HeaderDropDownControl_Unloaded;
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x0002769E File Offset: 0x0002589E
		private void HeaderDropDownControl_LayoutUpdated(object sender, global::System.EventArgs e)
		{
			if (this._cell != this._owner.Cell)
			{
				this.IsOpen = false;
			}
			if (this.IsOpen && this._popup != null)
			{
				this.InvalidateElementOutofPopup();
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x000276D0 File Offset: 0x000258D0
		// (set) Token: 0x06000A4C RID: 2636 RVA: 0x000276E2 File Offset: 0x000258E2
		public bool IsOpen
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl.IsOpenProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl.IsOpenProperty, value);
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x0002772C File Offset: 0x0002592C
		private static void IsOpenChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl hdd = (global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl)obj;
			bool isOpen = (bool)e.NewValue;
			if (hdd._xamGrid == null)
			{
				if (hdd._popup != null && isOpen)
				{
					hdd._popup.IsOpen = true;
				}
				global::System.Windows.DependencyObject parent = global::System.Windows.Media.VisualTreeHelper.GetParent(hdd);
				while (parent != null && hdd._xamGrid == null)
				{
					parent = global::System.Windows.Media.VisualTreeHelper.GetParent(parent);
					hdd._xamGrid = (parent as global::Infragistics.Controls.Grids.XamGrid);
					if (hdd._owner == null)
					{
						hdd._owner = (parent as global::Infragistics.Controls.Grids.Primitives.CellControlBase);
					}
				}
			}
			global::System.Windows.UIElement rootVisual = global::Infragistics.PlatformProxy.GetRootVisual(hdd._xamGrid);
			if (hdd._popup != null)
			{
				if (isOpen)
				{
					hdd._popup.IsOpen = isOpen;
				}
				else
				{
					hdd.Dispatcher.BeginInvoke(new global::System.Action(delegate()
					{
						hdd._popup.IsOpen = isOpen;
					}), new object[0]);
				}
			}
			if (isOpen)
			{
				hdd.InvalidateElementOutofPopup();
				hdd._rootVis = rootVisual;
				rootVisual.AddHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(hdd.HeaderDropDownControl_MouseLeftButtonDown), true);
				rootVisual.AddHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(hdd.HeaderDropDownControl_MouseLeftButtonUp), true);
				global::Infragistics.Controls.PresentationUtilities.AddHandler(rootVisual, hdd, global::System.Windows.UIElement.KeyDownEvent, new global::System.Windows.Input.KeyEventHandler(hdd.KeyDownHandler), true);
				global::Infragistics.Controls.PresentationUtilities.AddHandler(hdd, hdd, global::System.Windows.UIElement.KeyDownEvent, new global::System.Windows.Input.KeyEventHandler(hdd.KeyDownHandler), true);
				global::System.Windows.FrameworkElement frameworkElement = hdd.Content as global::System.Windows.FrameworkElement;
				if (frameworkElement != null)
				{
					frameworkElement.SizeChanged += hdd.Content_SizeChanged;
					global::Infragistics.Controls.PresentationUtilities.AddHandler(frameworkElement, hdd, global::System.Windows.UIElement.KeyDownEvent, new global::System.Windows.Input.KeyEventHandler(hdd.KeyDownHandler), true);
				}
				if (hdd._xamGrid != null)
				{
					hdd._xamGrid.RegisterOpenHeaderDropDownControl(hdd);
				}
				if (hdd._owner != null)
				{
					hdd._cell = hdd._owner.Cell;
					hdd.LayoutUpdated += hdd.HeaderDropDownControl_LayoutUpdated;
				}
				global::System.Windows.Controls.Control ctrl = frameworkElement as global::System.Windows.Controls.Control;
				if (ctrl != null)
				{
					ctrl.Dispatcher.BeginInvoke(new global::System.Action(delegate()
					{
						ctrl.Focus();
					}), new object[0]);
				}
				hdd.AlignPopupHorizontal();
				hdd.AlignPopupVertical();
				return;
			}
			hdd._rootVis.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(hdd.HeaderDropDownControl_MouseLeftButtonDown));
			hdd._rootVis.RemoveHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(hdd.HeaderDropDownControl_MouseLeftButtonUp));
			global::Infragistics.Controls.PresentationUtilities.RemoveHandler(hdd._rootVis, hdd, global::System.Windows.UIElement.KeyDownEvent, new global::System.Windows.Input.KeyEventHandler(hdd.KeyDownHandler));
			hdd._rootVis = null;
			global::Infragistics.Controls.PresentationUtilities.RemoveHandler(hdd, hdd, global::System.Windows.UIElement.KeyDownEvent, new global::System.Windows.Input.KeyEventHandler(hdd.KeyDownHandler));
			global::System.Windows.FrameworkElement frameworkElement2 = hdd.Content as global::System.Windows.FrameworkElement;
			if (frameworkElement2 != null)
			{
				frameworkElement2.SizeChanged -= hdd.Content_SizeChanged;
				global::Infragistics.Controls.PresentationUtilities.RemoveHandler(frameworkElement2, hdd, global::System.Windows.UIElement.KeyDownEvent, new global::System.Windows.Input.KeyEventHandler(hdd.KeyDownHandler));
			}
			if (hdd._xamGrid != null)
			{
				hdd._xamGrid.RegisterOpenHeaderDropDownControl(null);
			}
			if (hdd._owner != null)
			{
				hdd.LayoutUpdated -= hdd.HeaderDropDownControl_LayoutUpdated;
			}
			hdd._xamGrid = null;
			hdd._owner = null;
			hdd._cell = null;
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x00027BC1 File Offset: 0x00025DC1
		public global::Infragistics.Controls.Grids.CellBase Cell
		{
			get
			{
				return this._cell;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x00027BC9 File Offset: 0x00025DC9
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x00027BDB File Offset: 0x00025DDB
		public bool AllowResizing
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl.AllowResizingProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl.AllowResizingProperty, value);
			}
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00027BF0 File Offset: 0x00025DF0
		private static void AllowResizingChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl headerDropDownControl = (global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl)obj;
			headerDropDownControl.EnsureVisualStates();
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00027C0C File Offset: 0x00025E0C
		public override void OnApplyTemplate()
		{
			if (this._popup != null)
			{
				this._popup.Closed -= this.Popup_Closed;
			}
			this._popup = (base.GetTemplateChild("Popup") as global::System.Windows.Controls.Primitives.Popup);
			if (this._popup != null)
			{
				this._popup.AllowsTransparency = true;
				this._popup.StaysOpen = false;
				this._popup.Closed += this.Popup_Closed;
				global::System.Windows.UIElement child = this._popup.Child;
				if (child != null)
				{
					global::Infragistics.Controls.Grids.Primitives.HeaderDropDownContentRootPanel headerDropDownContentRootPanel = new global::Infragistics.Controls.Grids.Primitives.HeaderDropDownContentRootPanel();
					this._popup.Child = headerDropDownContentRootPanel;
					headerDropDownContentRootPanel.Children.Add(child);
				}
				this._popupRootElement = (this._popup.Child as global::System.Windows.FrameworkElement);
			}
			base.OnApplyTemplate();
			this.EnsureVisualStates();
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x00027CD5 File Offset: 0x00025ED5
		protected override void OnMouseDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseDown(e);
			e.Handled = true;
		}

		// Token: 0x06000A54 RID: 2644 RVA: 0x00027CE5 File Offset: 0x00025EE5
		protected override void OnMouseUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseUp(e);
			e.Handled = true;
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00027CF5 File Offset: 0x00025EF5
		protected virtual bool SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return command is global::Infragistics.Controls.Grids.Primitives.ShowCustomFilterDialogFilterMenuConditionalCommand || command is global::Infragistics.Controls.Grids.Primitives.ShowCompoundFilterDialogFilterMenuConditionalCommand || command is global::Infragistics.Controls.Grids.Primitives.PopupCommandBase;
		}

		// Token: 0x06000A56 RID: 2646 RVA: 0x00027D12 File Offset: 0x00025F12
		protected virtual object GetParameter(global::Infragistics.Controls.CommandSource command)
		{
			return this;
		}

		// Token: 0x06000A57 RID: 2647 RVA: 0x00027D15 File Offset: 0x00025F15
		protected virtual void InvalidateElementOutofPopup()
		{
			if (this._isLoaded && this.IsOpen)
			{
				global::System.Windows.Controls.Primitives.Popup popup = this._popup;
			}
		}

		// Token: 0x06000A58 RID: 2648 RVA: 0x00027D30 File Offset: 0x00025F30
		private void AlignPopupHorizontal()
		{
			double num = 1.0;
			global::System.Windows.FrameworkElement frameworkElement = (global::System.Windows.FrameworkElement)base.Content;
			double width = frameworkElement.DesiredSize.Width;
			global::System.Windows.UIElement rootVisual = global::Infragistics.PlatformProxy.GetRootVisual(this);
			double refferPoint = 0.0;
			if (rootVisual != null)
			{
				global::System.Windows.Media.GeneralTransform generalTransform = base.TransformToVisual(rootVisual);
				refferPoint = generalTransform.Transform(new global::System.Windows.Point(0.0, 0.0)).X;
			}
			if (num == 0.0 || width == 0.0)
			{
				return;
			}
			double horizontalOffset = global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl.DefineHorizontalOffset(refferPoint, num, width);
			this._popup.HorizontalOffset = horizontalOffset;
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00027DDB File Offset: 0x00025FDB
		private static double DefineHorizontalOffset(double refferPoint, double rootWidth, double popupContentWidth)
		{
			return global::System.Math.Min(refferPoint, 0.0);
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00027DEC File Offset: 0x00025FEC
		private void AlignPopupVertical()
		{
			double num = 1.0;
			global::System.Windows.FrameworkElement frameworkElement = (global::System.Windows.FrameworkElement)base.Content;
			double height = frameworkElement.DesiredSize.Height;
			global::System.Windows.FrameworkElement frameworkElement2 = base.Parent as global::System.Windows.FrameworkElement;
			global::System.Windows.UIElement rootVisual = global::Infragistics.PlatformProxy.GetRootVisual(this);
			double num2 = 0.0;
			double parentHeight = 0.0;
			if (frameworkElement2 != null)
			{
				parentHeight = frameworkElement2.ActualHeight;
			}
			global::System.Windows.Point point = new global::System.Windows.Point(0.0, 0.0);
			if (rootVisual != null)
			{
				if (frameworkElement2 != null)
				{
					global::System.Windows.Media.GeneralTransform generalTransform = frameworkElement2.TransformToVisual(rootVisual);
					point = generalTransform.Transform(new global::System.Windows.Point(0.0, 0.0));
				}
				global::System.Windows.Media.GeneralTransform generalTransform2 = base.TransformToVisual(rootVisual);
				num2 = generalTransform2.Transform(new global::System.Windows.Point(0.0, 0.0)).Y;
			}
			if (num == 0.0 || height == 0.0)
			{
				return;
			}
			double verticalOffset = global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl.DefineVerticalOffset(num2, num, height, parentHeight, num2 - point.Y);
			this._popup.VerticalOffset = verticalOffset;
		}

		// Token: 0x06000A5B RID: 2651 RVA: 0x00027F0E File Offset: 0x0002610E
		private static double DefineVerticalOffset(double refferPoint, double rootHeight, double popupContentHeight, double parentHeight, double offsetDelta)
		{
			return offsetDelta;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00027F12 File Offset: 0x00026112
		private void EnsureVisualStates()
		{
			if (this.AllowResizing)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Resizable", false);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "NotResizable", false);
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00027F38 File Offset: 0x00026138
		private void HeaderDropDownControl_MouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.DependencyObject dependencyObject = e.OriginalSource as global::System.Windows.DependencyObject;
			bool flag = false;
			while (dependencyObject != null)
			{
				global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl headerDropDownControl = dependencyObject as global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl;
				if (headerDropDownControl != null)
				{
					if (headerDropDownControl == this)
					{
						flag = true;
						break;
					}
					if (headerDropDownControl.IsOpen)
					{
						this.IsOpen = false;
						break;
					}
				}
				global::System.Windows.DependencyObject parent = global::Infragistics.PlatformProxy.GetParent(dependencyObject);
				if (parent == null)
				{
					global::System.Windows.FrameworkElement frameworkElement = dependencyObject as global::System.Windows.FrameworkElement;
					if (frameworkElement != null)
					{
						dependencyObject = frameworkElement.Parent;
					}
					else
					{
						dependencyObject = parent;
					}
				}
				else
				{
					dependencyObject = parent;
				}
			}
			this._isMouseDownInside = flag;
			if (!flag)
			{
				this.IsOpen = false;
			}
		}

		// Token: 0x06000A5E RID: 2654 RVA: 0x00027FB2 File Offset: 0x000261B2
		private void HeaderDropDownControl_MouseLeftButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this._isMouseDownInside = false;
		}

		// Token: 0x06000A5F RID: 2655 RVA: 0x00027FBC File Offset: 0x000261BC
		private void Content_SizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			global::System.Windows.FrameworkElement frameworkElement = (global::System.Windows.FrameworkElement)sender;
			if (frameworkElement.DesiredSize.Width != 0.0)
			{
				this.AlignPopupHorizontal();
			}
			if (frameworkElement.DesiredSize.Height != 0.0)
			{
				this.AlignPopupVertical();
			}
		}

		// Token: 0x06000A60 RID: 2656 RVA: 0x0002800E File Offset: 0x0002620E
		private void KeyDownHandler(object sender, global::System.Windows.Input.KeyEventArgs e)
		{
			if (!e.Handled && e.Key == global::System.Windows.Input.Key.Escape)
			{
				this.IsOpen = false;
				e.Handled = true;
			}
		}

		// Token: 0x06000A61 RID: 2657 RVA: 0x00028030 File Offset: 0x00026230
		private void ElementOutofPopup_MouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this.IsOpen = false;
		}

		// Token: 0x06000A62 RID: 2658 RVA: 0x00028039 File Offset: 0x00026239
		private void HeaderDropDownControl_Unloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this._isLoaded = false;
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00028042 File Offset: 0x00026242
		private void HeaderDropDownControl_Loaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this._isLoaded = true;
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x0002804B File Offset: 0x0002624B
		private void Popup_Closed(object sender, global::System.EventArgs e)
		{
			if (!this._isMouseDownInside)
			{
				this.IsOpen = false;
			}
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x0002805C File Offset: 0x0002625C
		bool global::Infragistics.ICommandTarget.SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return this.SupportsCommand(command);
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x00028065 File Offset: 0x00026265
		object global::Infragistics.ICommandTarget.GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this.GetParameter(source);
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x0002806E File Offset: 0x0002626E
		// (set) Token: 0x06000A68 RID: 2664 RVA: 0x0002807B File Offset: 0x0002627B
		public object OpenButtonContent
		{
			get
			{
				return base.GetValue(global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl.OpenButtonContentProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl.OpenButtonContentProperty, value);
			}
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x00028089 File Offset: 0x00026289
		private static void OpenButtonContentChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x0400027D RID: 637
		private global::System.Windows.Controls.Primitives.Popup _popup;

		// Token: 0x0400027E RID: 638
		private global::Infragistics.Controls.Grids.XamGrid _xamGrid;

		// Token: 0x0400027F RID: 639
		private global::Infragistics.Controls.Grids.Primitives.CellControlBase _owner;

		// Token: 0x04000280 RID: 640
		private global::Infragistics.Controls.Grids.CellBase _cell;

		// Token: 0x04000281 RID: 641
		private global::System.Windows.FrameworkElement _popupRootElement;

		// Token: 0x04000282 RID: 642
		private global::System.Windows.UIElement _rootVis;

		// Token: 0x04000283 RID: 643
		private bool _isLoaded;

		// Token: 0x04000284 RID: 644
		private bool _isMouseDownInside;

		// Token: 0x04000285 RID: 645
		public static readonly global::System.Windows.DependencyProperty IsOpenProperty = global::System.Windows.DependencyProperty.Register("IsOpen", typeof(bool), typeof(global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl.IsOpenChanged)));

		// Token: 0x04000286 RID: 646
		public static readonly global::System.Windows.DependencyProperty AllowResizingProperty = global::System.Windows.DependencyProperty.Register("AllowResizing", typeof(bool), typeof(global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl.AllowResizingChanged)));

		// Token: 0x04000287 RID: 647
		public static readonly global::System.Windows.DependencyProperty OpenButtonContentProperty = global::System.Windows.DependencyProperty.Register("OpenButtonContent", typeof(object), typeof(global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl.OpenButtonContentChanged)));
	}
}
