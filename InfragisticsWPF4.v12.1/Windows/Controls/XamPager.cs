using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Windows.Licensing;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000289 RID: 649
	[global::System.Windows.StyleTypedProperty(Property = "ScrollUpButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.ButtonBase))]
	[global::System.Windows.TemplatePart(Name = "PART_ScrollRight", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_ScrollLeft", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_ScrollDown", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_PagerContentPresenter", Type = typeof(global::Infragistics.Windows.Controls.PagerContentPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "ScrollLeftButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.ButtonBase))]
	[global::System.Windows.StyleTypedProperty(Property = "ScrollRightButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.ButtonBase))]
	[global::System.Windows.StyleTypedProperty(Property = "ScrollDownButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.ButtonBase))]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamPager", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV | global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.LOB)]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplatePart(Name = "PART_ScrollUp", Type = typeof(global::System.Windows.FrameworkElement))]
	public class XamPager : global::System.Windows.Controls.ScrollViewer
	{
		// Token: 0x06001A0F RID: 6671 RVA: 0x00064B68 File Offset: 0x00062D68
		static XamPager()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.XamPager)));
			global::System.Windows.Input.CanExecuteRoutedEventHandler canExecute = new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Infragistics.Windows.Controls.XamPager.OnCanExecuteScrollCommand);
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.Input.CommandBinding(global::System.Windows.Controls.Primitives.ScrollBar.LineLeftCommand, null, canExecute));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.Input.CommandBinding(global::System.Windows.Controls.Primitives.ScrollBar.LineRightCommand, null, canExecute));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.Input.CommandBinding(global::System.Windows.Controls.Primitives.ScrollBar.LineUpCommand, null, canExecute));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.Input.CommandBinding(global::System.Windows.Controls.Primitives.ScrollBar.LineDownCommand, null, canExecute));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.Controls.XamPager), global::System.Windows.FrameworkElement.RequestBringIntoViewEvent, new global::System.Windows.RequestBringIntoViewEventHandler(global::Infragistics.Windows.Controls.XamPager.OnRequestBringIntoView));
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x00064DF8 File Offset: 0x00062FF8
		public XamPager()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.Controls.XamPager), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x00064E3C File Offset: 0x0006303C
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._scrollDownElement = (base.GetTemplateChild("PART_ScrollDown") as global::System.Windows.FrameworkElement);
			this._scrollUpElement = (base.GetTemplateChild("PART_ScrollUp") as global::System.Windows.FrameworkElement);
			this._scrollLeftElement = (base.GetTemplateChild("PART_ScrollLeft") as global::System.Windows.FrameworkElement);
			this._scrollRightElement = (base.GetTemplateChild("PART_ScrollRight") as global::System.Windows.FrameworkElement);
			this._contentPresenter = (base.GetTemplateChild("PART_PagerContentPresenter") as global::Infragistics.Windows.Controls.PagerContentPresenter);
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x00064EC0 File Offset: 0x000630C0
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (!e.Handled && e.OriginalSource != this)
			{
				switch (e.Key)
				{
				case global::System.Windows.Input.Key.End:
				case global::System.Windows.Input.Key.Home:
					if (e.KeyboardDevice.Modifiers == global::System.Windows.Input.ModifierKeys.Control)
					{
						return;
					}
					break;
				case global::System.Windows.Input.Key.Left:
				case global::System.Windows.Input.Key.Up:
				case global::System.Windows.Input.Key.Right:
				case global::System.Windows.Input.Key.Down:
					if (!this.DoesParentHandleScrolling)
					{
						this.ProcessArrowKey(e);
						return;
					}
					break;
				}
			}
			base.OnKeyDown(e);
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x00064F30 File Offset: 0x00063130
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (e.Property == global::System.Windows.Controls.ScrollViewer.ComputedHorizontalScrollBarVisibilityProperty)
			{
				this.VerifyScrollHorizontalVisibility();
			}
			else if (e.Property == global::System.Windows.Controls.ScrollViewer.ComputedVerticalScrollBarVisibilityProperty)
			{
				this.VerifyScrollVerticalVisibility();
			}
			if (this._contentPresenter != null && (e.Property == global::Infragistics.Windows.Controls.XamPager.ScrollLeftVisibilityProperty || e.Property == global::Infragistics.Windows.Controls.XamPager.ScrollRightVisibilityProperty || e.Property == global::Infragistics.Windows.Controls.XamPager.ScrollUpVisibilityProperty || e.Property == global::Infragistics.Windows.Controls.XamPager.ScrollDownVisibilityProperty))
			{
				this._contentPresenter.InvalidateVisual();
			}
			base.OnPropertyChanged(e);
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x00064FBC File Offset: 0x000631BC
		protected override void OnScrollChanged(global::System.Windows.Controls.ScrollChangedEventArgs e)
		{
			this.VerifyScrollHorizontalVisibility();
			this.VerifyScrollVerticalVisibility();
			if (e.HorizontalChange != 0.0 || e.VerticalChange != 0.0)
			{
				global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
			}
			else
			{
				bool flag = e.ExtentWidth - e.ExtentWidthChange - (e.ViewportWidth - e.ViewportWidthChange) > 0.0;
				bool flag2 = e.ExtentWidth - e.ViewportWidth > 0.0;
				if (flag != flag2)
				{
					global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
				}
			}
			base.OnScrollChanged(e);
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001A15 RID: 6677 RVA: 0x0006504E File Offset: 0x0006324E
		// (set) Token: 0x06001A16 RID: 6678 RVA: 0x00065056 File Offset: 0x00063256
		internal global::System.Windows.Controls.Primitives.IScrollInfo ScrollInfoInternal
		{
			get
			{
				return base.ScrollInfo;
			}
			set
			{
				base.ScrollInfo = value;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x0006505F File Offset: 0x0006325F
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Visibility ScrollLeftVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Controls.XamPager.ScrollLeftVisibilityProperty);
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001A18 RID: 6680 RVA: 0x00065071 File Offset: 0x00063271
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Visibility ScrollRightVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Controls.XamPager.ScrollRightVisibilityProperty);
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001A19 RID: 6681 RVA: 0x00065083 File Offset: 0x00063283
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility ScrollUpVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Controls.XamPager.ScrollUpVisibilityProperty);
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x00065095 File Offset: 0x00063295
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility ScrollDownVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Controls.XamPager.ScrollDownVisibilityProperty);
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001A1B RID: 6683 RVA: 0x000650A7 File Offset: 0x000632A7
		// (set) Token: 0x06001A1C RID: 6684 RVA: 0x000650B9 File Offset: 0x000632B9
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style ScrollLeftButtonStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.Controls.XamPager.ScrollLeftButtonStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamPager.ScrollLeftButtonStyleProperty, value);
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x000650C7 File Offset: 0x000632C7
		// (set) Token: 0x06001A1E RID: 6686 RVA: 0x000650D9 File Offset: 0x000632D9
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style ScrollRightButtonStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.Controls.XamPager.ScrollRightButtonStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamPager.ScrollRightButtonStyleProperty, value);
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001A1F RID: 6687 RVA: 0x000650E7 File Offset: 0x000632E7
		// (set) Token: 0x06001A20 RID: 6688 RVA: 0x000650F9 File Offset: 0x000632F9
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style ScrollUpButtonStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.Controls.XamPager.ScrollUpButtonStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamPager.ScrollUpButtonStyleProperty, value);
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x00065107 File Offset: 0x00063307
		// (set) Token: 0x06001A22 RID: 6690 RVA: 0x00065119 File Offset: 0x00063319
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style ScrollDownButtonStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.Controls.XamPager.ScrollDownButtonStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.XamPager.ScrollDownButtonStyleProperty, value);
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06001A23 RID: 6691 RVA: 0x00065128 File Offset: 0x00063328
		private bool DoesParentHandleScrolling
		{
			get
			{
				global::System.Windows.Controls.Control control = base.TemplatedParent as global::System.Windows.Controls.Control;
				if (control != null)
				{
					try
					{
						global::System.Reflection.PropertyInfo property = typeof(global::System.Windows.Controls.Control).GetProperty("HandlesScrolling", global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
						if (null != property && global::Infragistics.KnownBoxes.TrueBox.Equals(property.GetValue(control, null)))
						{
							return true;
						}
					}
					catch (global::System.MethodAccessException)
					{
					}
					catch (global::System.Security.SecurityException)
					{
					}
					return false;
				}
				return false;
			}
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x000651A4 File Offset: 0x000633A4
		internal global::System.Windows.FrameworkElement GetScrollElement(global::Infragistics.Windows.Controls.PagerScrollDirection direction)
		{
			switch (direction)
			{
			case global::Infragistics.Windows.Controls.PagerScrollDirection.Up:
				return this._scrollUpElement;
			case global::Infragistics.Windows.Controls.PagerScrollDirection.Down:
				return this._scrollDownElement;
			case global::Infragistics.Windows.Controls.PagerScrollDirection.Left:
				return this._scrollLeftElement;
			case global::Infragistics.Windows.Controls.PagerScrollDirection.Right:
				return this._scrollRightElement;
			default:
				return null;
			}
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x000651E8 File Offset: 0x000633E8
		private static void OnCanExecuteScrollCommand(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamPager xamPager = sender as global::Infragistics.Windows.Controls.XamPager;
			if (xamPager != null && xamPager.ScrollInfo != null)
			{
				global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo = xamPager.ScrollInfo;
				global::Infragistics.Windows.Controls.PagerContentPresenter contentPresenter = xamPager._contentPresenter;
			}
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x00065218 File Offset: 0x00063418
		private static void OnRequestBringIntoView(object sender, global::System.Windows.RequestBringIntoViewEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamPager xamPager = sender as global::Infragistics.Windows.Controls.XamPager;
			xamPager.OnRequestBringIntoView(e);
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x00065234 File Offset: 0x00063434
		private void OnRequestBringIntoView(global::System.Windows.RequestBringIntoViewEventArgs e)
		{
			global::Infragistics.Windows.Controls.PagerContentPresenter contentPresenter = this._contentPresenter;
			if (!this._ignoreBringIntoView && contentPresenter != null && base.ScrollInfo != contentPresenter)
			{
				global::System.Windows.FrameworkElement frameworkElement = e.TargetObject as global::System.Windows.FrameworkElement;
				if (frameworkElement != null && contentPresenter.IsAncestorOf(frameworkElement))
				{
					global::System.Windows.Rect targetRect = e.TargetRect;
					if (targetRect.IsEmpty)
					{
						targetRect = new global::System.Windows.Rect(frameworkElement.RenderSize);
					}
					global::System.Windows.Rect rect = new global::System.Windows.Rect(contentPresenter.RenderSize);
					global::System.Windows.Rect rect2 = rect;
					contentPresenter.AdjustRect(ref rect, global::Infragistics.Windows.Controls.PagerScrollDirection.Left);
					contentPresenter.AdjustRect(ref rect, global::Infragistics.Windows.Controls.PagerScrollDirection.Right);
					contentPresenter.AdjustRect(ref rect, global::Infragistics.Windows.Controls.PagerScrollDirection.Up);
					contentPresenter.AdjustRect(ref rect, global::Infragistics.Windows.Controls.PagerScrollDirection.Down);
					global::System.Windows.Media.GeneralTransform generalTransform = contentPresenter.TransformToDescendant(frameworkElement);
					if (generalTransform == null)
					{
						return;
					}
					rect = generalTransform.TransformBounds(rect);
					rect2 = generalTransform.TransformBounds(rect2);
					global::System.Windows.Rect rect3 = global::System.Windows.Rect.Intersect(targetRect, rect2);
					global::System.Windows.Rect rect4 = global::System.Windows.Rect.Intersect(rect3, rect);
					if (rect4 == rect3)
					{
						return;
					}
					if (rect4.Width != rect3.Width)
					{
						double num = 0.0;
						if (rect3.Right > rect.Right)
						{
							targetRect.Width += rect3.Right - rect.Right;
						}
						if (rect3.Left - num - rect.Left < 0.0)
						{
							targetRect.X += rect3.Left - num - rect.Left;
						}
					}
					if (rect4.Height != rect3.Height)
					{
						double num2 = 0.0;
						if (rect3.Bottom > rect.Bottom)
						{
							targetRect.Height += rect3.Bottom - rect.Bottom;
						}
						if (rect3.Top - num2 - rect.Top < 0.0)
						{
							targetRect.Y += rect3.Top - num2 - rect.Top;
						}
					}
					e.Handled = true;
					this._ignoreBringIntoView = true;
					try
					{
						((global::System.Windows.FrameworkElement)e.TargetObject).BringIntoView(targetRect);
					}
					finally
					{
						this._ignoreBringIntoView = false;
					}
				}
			}
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x00065460 File Offset: 0x00063660
		private static void OnScrollVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00065468 File Offset: 0x00063668
		private void ProcessArrowKey(global::System.Windows.Input.KeyEventArgs e)
		{
			if (this._contentPresenter == null || !(e.OriginalSource is global::System.Windows.DependencyObject) || !this._contentPresenter.IsAncestorOf(e.OriginalSource as global::System.Windows.DependencyObject))
			{
				return;
			}
			global::System.Windows.Input.FocusNavigationDirection direction;
			switch (e.Key)
			{
			case global::System.Windows.Input.Key.Left:
				direction = global::System.Windows.Input.FocusNavigationDirection.Left;
				break;
			case global::System.Windows.Input.Key.Up:
				direction = global::System.Windows.Input.FocusNavigationDirection.Up;
				break;
			case global::System.Windows.Input.Key.Right:
				direction = global::System.Windows.Input.FocusNavigationDirection.Right;
				break;
			case global::System.Windows.Input.Key.Down:
				direction = global::System.Windows.Input.FocusNavigationDirection.Down;
				break;
			default:
				return;
			}
			global::System.Windows.DependencyObject dependencyObject = global::System.Windows.Input.Keyboard.FocusedElement as global::System.Windows.DependencyObject;
			global::System.Windows.DependencyObject dependencyObject2 = null;
			if (this._contentPresenter.IsDescendantInView(dependencyObject))
			{
				if (dependencyObject is global::System.Windows.UIElement)
				{
					dependencyObject2 = ((global::System.Windows.UIElement)dependencyObject).PredictFocus(direction);
				}
				else if (dependencyObject is global::System.Windows.ContentElement)
				{
					dependencyObject2 = ((global::System.Windows.ContentElement)dependencyObject).PredictFocus(direction);
				}
			}
			else if (this._contentPresenter != null)
			{
				dependencyObject2 = this._contentPresenter.PredictFocus(direction);
			}
			if (dependencyObject2 is global::System.Windows.IInputElement && this._contentPresenter.IsAncestorOf(dependencyObject2))
			{
				bool flag = this._contentPresenter.IsDescendantInView(dependencyObject2);
				if (!flag && e.KeyboardDevice.Modifiers == global::System.Windows.Input.ModifierKeys.None)
				{
					e.Handled = true;
					switch (e.Key)
					{
					case global::System.Windows.Input.Key.Left:
						if (base.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
						{
							base.LineRight();
						}
						else
						{
							base.LineLeft();
						}
						break;
					case global::System.Windows.Input.Key.Up:
						base.LineUp();
						break;
					case global::System.Windows.Input.Key.Right:
						if (base.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
						{
							base.LineLeft();
						}
						else
						{
							base.LineRight();
						}
						break;
					case global::System.Windows.Input.Key.Down:
						base.LineDown();
						break;
					}
					base.UpdateLayout();
					flag = this._contentPresenter.IsDescendantInView(dependencyObject2);
				}
				if (flag)
				{
					((global::System.Windows.IInputElement)dependencyObject2).Focus();
					e.Handled = true;
				}
			}
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x00065604 File Offset: 0x00063804
		private void VerifyScrollHorizontalVisibility()
		{
			object value;
			object value2;
			if (base.ComputedHorizontalScrollBarVisibility == global::System.Windows.Visibility.Visible && base.ScrollInfo != null)
			{
				double num = base.ScrollInfo.ExtentWidth - base.ScrollInfo.ViewportWidth;
				bool flag = base.HorizontalScrollBarVisibility == global::System.Windows.Controls.ScrollBarVisibility.Auto;
				value = ((flag && base.ScrollInfo.HorizontalOffset == 0.0) ? global::Infragistics.KnownBoxes.VisibilityCollapsedBox : global::Infragistics.KnownBoxes.VisibilityVisibleBox);
				value2 = ((flag && base.ScrollInfo.HorizontalOffset >= num) ? global::Infragistics.KnownBoxes.VisibilityCollapsedBox : global::Infragistics.KnownBoxes.VisibilityVisibleBox);
			}
			else
			{
				value2 = (value = global::Infragistics.KnownBoxes.VisibilityCollapsedBox);
			}
			base.SetValue(global::Infragistics.Windows.Controls.XamPager.ScrollLeftVisibilityPropertyKey, value);
			base.SetValue(global::Infragistics.Windows.Controls.XamPager.ScrollRightVisibilityPropertyKey, value2);
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x000656AC File Offset: 0x000638AC
		private void VerifyScrollVerticalVisibility()
		{
			object value;
			object value2;
			if (base.ComputedVerticalScrollBarVisibility == global::System.Windows.Visibility.Visible && base.ScrollInfo != null)
			{
				double num = base.ScrollInfo.ExtentHeight - base.ScrollInfo.ViewportHeight;
				bool flag = base.VerticalScrollBarVisibility == global::System.Windows.Controls.ScrollBarVisibility.Auto;
				value = ((flag && base.ScrollInfo.VerticalOffset == 0.0) ? global::Infragistics.KnownBoxes.VisibilityCollapsedBox : global::Infragistics.KnownBoxes.VisibilityVisibleBox);
				value2 = ((flag && base.ScrollInfo.VerticalOffset >= num) ? global::Infragistics.KnownBoxes.VisibilityCollapsedBox : global::Infragistics.KnownBoxes.VisibilityVisibleBox);
			}
			else
			{
				value2 = (value = global::Infragistics.KnownBoxes.VisibilityCollapsedBox);
			}
			base.SetValue(global::Infragistics.Windows.Controls.XamPager.ScrollUpVisibilityPropertyKey, value);
			base.SetValue(global::Infragistics.Windows.Controls.XamPager.ScrollDownVisibilityPropertyKey, value2);
		}

		// Token: 0x04000C41 RID: 3137
		private global::System.Windows.FrameworkElement _scrollLeftElement;

		// Token: 0x04000C42 RID: 3138
		private global::System.Windows.FrameworkElement _scrollRightElement;

		// Token: 0x04000C43 RID: 3139
		private global::System.Windows.FrameworkElement _scrollUpElement;

		// Token: 0x04000C44 RID: 3140
		private global::System.Windows.FrameworkElement _scrollDownElement;

		// Token: 0x04000C45 RID: 3141
		private global::Infragistics.Windows.Controls.PagerContentPresenter _contentPresenter;

		// Token: 0x04000C46 RID: 3142
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000C47 RID: 3143
		private bool _ignoreBringIntoView;

		// Token: 0x04000C48 RID: 3144
		private static readonly global::System.Windows.DependencyPropertyKey ScrollLeftVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ScrollLeftVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamPager.OnScrollVisibilityChanged)));

		// Token: 0x04000C49 RID: 3145
		public static readonly global::System.Windows.DependencyProperty ScrollLeftVisibilityProperty = global::Infragistics.Windows.Controls.XamPager.ScrollLeftVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000C4A RID: 3146
		private static readonly global::System.Windows.DependencyPropertyKey ScrollRightVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ScrollRightVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamPager.OnScrollVisibilityChanged)));

		// Token: 0x04000C4B RID: 3147
		public static readonly global::System.Windows.DependencyProperty ScrollRightVisibilityProperty = global::Infragistics.Windows.Controls.XamPager.ScrollRightVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000C4C RID: 3148
		private static readonly global::System.Windows.DependencyPropertyKey ScrollUpVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ScrollUpVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamPager.OnScrollVisibilityChanged)));

		// Token: 0x04000C4D RID: 3149
		public static readonly global::System.Windows.DependencyProperty ScrollUpVisibilityProperty = global::Infragistics.Windows.Controls.XamPager.ScrollUpVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000C4E RID: 3150
		private static readonly global::System.Windows.DependencyPropertyKey ScrollDownVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ScrollDownVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamPager.OnScrollVisibilityChanged)));

		// Token: 0x04000C4F RID: 3151
		public static readonly global::System.Windows.DependencyProperty ScrollDownVisibilityProperty = global::Infragistics.Windows.Controls.XamPager.ScrollDownVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000C50 RID: 3152
		public static readonly global::System.Windows.DependencyProperty ScrollLeftButtonStyleProperty = global::System.Windows.DependencyProperty.Register("ScrollLeftButtonStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C51 RID: 3153
		public static readonly global::System.Windows.DependencyProperty ScrollRightButtonStyleProperty = global::System.Windows.DependencyProperty.Register("ScrollRightButtonStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C52 RID: 3154
		public static readonly global::System.Windows.DependencyProperty ScrollUpButtonStyleProperty = global::System.Windows.DependencyProperty.Register("ScrollUpButtonStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000C53 RID: 3155
		public static readonly global::System.Windows.DependencyProperty ScrollDownButtonStyleProperty = global::System.Windows.DependencyProperty.Register("ScrollDownButtonStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.FrameworkPropertyMetadata(null));
	}
}
