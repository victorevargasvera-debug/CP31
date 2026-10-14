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
	// Token: 0x020002C6 RID: 710
	[global::System.Windows.TemplatePart(Name = "PART_ScrollUp", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_ScrollDown", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.StyleTypedProperty(Property = "ScrollRightButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.ButtonBase))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplatePart(Name = "PART_ScrollLeft", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_ScrollRight", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_PagerContentPresenter", Type = typeof(global::Infragistics.Windows.Controls.PagerContentPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "ScrollLeftButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.ButtonBase))]
	[global::System.Windows.StyleTypedProperty(Property = "ScrollUpButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.ButtonBase))]
	[global::System.Windows.StyleTypedProperty(Property = "ScrollDownButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.ButtonBase))]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamPager", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV | global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.LOB)]
	public class XamPager : global::System.Windows.Controls.ScrollViewer
	{
		// Token: 0x06001C40 RID: 7232 RVA: 0x0006BDC4 File Offset: 0x00069FC4
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

		// Token: 0x06001C41 RID: 7233 RVA: 0x0006C054 File Offset: 0x0006A254
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

		// Token: 0x06001C42 RID: 7234 RVA: 0x0006C098 File Offset: 0x0006A298
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._scrollDownElement = (base.GetTemplateChild("PART_ScrollDown") as global::System.Windows.FrameworkElement);
			this._scrollUpElement = (base.GetTemplateChild("PART_ScrollUp") as global::System.Windows.FrameworkElement);
			this._scrollLeftElement = (base.GetTemplateChild("PART_ScrollLeft") as global::System.Windows.FrameworkElement);
			this._scrollRightElement = (base.GetTemplateChild("PART_ScrollRight") as global::System.Windows.FrameworkElement);
			this._contentPresenter = (base.GetTemplateChild("PART_PagerContentPresenter") as global::Infragistics.Windows.Controls.PagerContentPresenter);
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x0006C11C File Offset: 0x0006A31C
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

		// Token: 0x06001C44 RID: 7236 RVA: 0x0006C18C File Offset: 0x0006A38C
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

		// Token: 0x06001C45 RID: 7237 RVA: 0x0006C218 File Offset: 0x0006A418
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

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06001C46 RID: 7238 RVA: 0x0006C2AA File Offset: 0x0006A4AA
		// (set) Token: 0x06001C47 RID: 7239 RVA: 0x0006C2B2 File Offset: 0x0006A4B2
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

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x0006C2BB File Offset: 0x0006A4BB
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility ScrollLeftVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Controls.XamPager.ScrollLeftVisibilityProperty);
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x0006C2CD File Offset: 0x0006A4CD
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility ScrollRightVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Controls.XamPager.ScrollRightVisibilityProperty);
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x0006C2DF File Offset: 0x0006A4DF
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility ScrollUpVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Controls.XamPager.ScrollUpVisibilityProperty);
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06001C4B RID: 7243 RVA: 0x0006C2F1 File Offset: 0x0006A4F1
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Visibility ScrollDownVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Controls.XamPager.ScrollDownVisibilityProperty);
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x0006C303 File Offset: 0x0006A503
		// (set) Token: 0x06001C4D RID: 7245 RVA: 0x0006C315 File Offset: 0x0006A515
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

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x0006C323 File Offset: 0x0006A523
		// (set) Token: 0x06001C4F RID: 7247 RVA: 0x0006C335 File Offset: 0x0006A535
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

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x0006C343 File Offset: 0x0006A543
		// (set) Token: 0x06001C51 RID: 7249 RVA: 0x0006C355 File Offset: 0x0006A555
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

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x0006C363 File Offset: 0x0006A563
		// (set) Token: 0x06001C53 RID: 7251 RVA: 0x0006C375 File Offset: 0x0006A575
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

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x0006C384 File Offset: 0x0006A584
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

		// Token: 0x06001C55 RID: 7253 RVA: 0x0006C400 File Offset: 0x0006A600
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

		// Token: 0x06001C56 RID: 7254 RVA: 0x0006C444 File Offset: 0x0006A644
		private static void OnCanExecuteScrollCommand(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamPager xamPager = sender as global::Infragistics.Windows.Controls.XamPager;
			if (xamPager != null && xamPager.ScrollInfo != null)
			{
				global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo = xamPager.ScrollInfo;
				global::Infragistics.Windows.Controls.PagerContentPresenter contentPresenter = xamPager._contentPresenter;
			}
		}

		// Token: 0x06001C57 RID: 7255 RVA: 0x0006C474 File Offset: 0x0006A674
		private static void OnRequestBringIntoView(object sender, global::System.Windows.RequestBringIntoViewEventArgs e)
		{
			global::Infragistics.Windows.Controls.XamPager xamPager = sender as global::Infragistics.Windows.Controls.XamPager;
			xamPager.OnRequestBringIntoView(e);
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x0006C490 File Offset: 0x0006A690
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

		// Token: 0x06001C59 RID: 7257 RVA: 0x0006C6BC File Offset: 0x0006A8BC
		private static void OnScrollVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
		}

		// Token: 0x06001C5A RID: 7258 RVA: 0x0006C6C4 File Offset: 0x0006A8C4
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

		// Token: 0x06001C5B RID: 7259 RVA: 0x0006C860 File Offset: 0x0006AA60
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

		// Token: 0x06001C5C RID: 7260 RVA: 0x0006C908 File Offset: 0x0006AB08
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

		// Token: 0x04000DB4 RID: 3508
		private global::System.Windows.FrameworkElement _scrollLeftElement;

		// Token: 0x04000DB5 RID: 3509
		private global::System.Windows.FrameworkElement _scrollRightElement;

		// Token: 0x04000DB6 RID: 3510
		private global::System.Windows.FrameworkElement _scrollUpElement;

		// Token: 0x04000DB7 RID: 3511
		private global::System.Windows.FrameworkElement _scrollDownElement;

		// Token: 0x04000DB8 RID: 3512
		private global::Infragistics.Windows.Controls.PagerContentPresenter _contentPresenter;

		// Token: 0x04000DB9 RID: 3513
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x04000DBA RID: 3514
		private bool _ignoreBringIntoView;

		// Token: 0x04000DBB RID: 3515
		private static readonly global::System.Windows.DependencyPropertyKey ScrollLeftVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ScrollLeftVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamPager.OnScrollVisibilityChanged)));

		// Token: 0x04000DBC RID: 3516
		public static readonly global::System.Windows.DependencyProperty ScrollLeftVisibilityProperty = global::Infragistics.Windows.Controls.XamPager.ScrollLeftVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000DBD RID: 3517
		private static readonly global::System.Windows.DependencyPropertyKey ScrollRightVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ScrollRightVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamPager.OnScrollVisibilityChanged)));

		// Token: 0x04000DBE RID: 3518
		public static readonly global::System.Windows.DependencyProperty ScrollRightVisibilityProperty = global::Infragistics.Windows.Controls.XamPager.ScrollRightVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000DBF RID: 3519
		private static readonly global::System.Windows.DependencyPropertyKey ScrollUpVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ScrollUpVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamPager.OnScrollVisibilityChanged)));

		// Token: 0x04000DC0 RID: 3520
		public static readonly global::System.Windows.DependencyProperty ScrollUpVisibilityProperty = global::Infragistics.Windows.Controls.XamPager.ScrollUpVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000DC1 RID: 3521
		private static readonly global::System.Windows.DependencyPropertyKey ScrollDownVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ScrollDownVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.XamPager.OnScrollVisibilityChanged)));

		// Token: 0x04000DC2 RID: 3522
		public static readonly global::System.Windows.DependencyProperty ScrollDownVisibilityProperty = global::Infragistics.Windows.Controls.XamPager.ScrollDownVisibilityPropertyKey.DependencyProperty;

		// Token: 0x04000DC3 RID: 3523
		public static readonly global::System.Windows.DependencyProperty ScrollLeftButtonStyleProperty = global::System.Windows.DependencyProperty.Register("ScrollLeftButtonStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000DC4 RID: 3524
		public static readonly global::System.Windows.DependencyProperty ScrollRightButtonStyleProperty = global::System.Windows.DependencyProperty.Register("ScrollRightButtonStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000DC5 RID: 3525
		public static readonly global::System.Windows.DependencyProperty ScrollUpButtonStyleProperty = global::System.Windows.DependencyProperty.Register("ScrollUpButtonStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000DC6 RID: 3526
		public static readonly global::System.Windows.DependencyProperty ScrollDownButtonStyleProperty = global::System.Windows.DependencyProperty.Register("ScrollDownButtonStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.Controls.XamPager), new global::System.Windows.FrameworkPropertyMetadata(null));
	}
}
