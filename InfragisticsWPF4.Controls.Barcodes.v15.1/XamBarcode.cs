using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Controls.Barcodes.AutomationPeers;
using Infragistics.Controls.Barcodes.VisualData;
using Infragistics.Themes;
using Infragistics.Windows;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000042 RID: 66
	[global::System.Windows.TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "ValidBarcode", GroupName = "GroupBarcode")]
	[global::System.Windows.TemplatePart(Name = "RootGrid", Type = typeof(global::System.Windows.Controls.Grid))]
	[global::System.Windows.TemplateVisualState(Name = "InvalidBarcode", GroupName = "GroupBarcode")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Pressed", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamBarcode", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV)]
	[global::System.Runtime.CompilerServices.Widget("QRCodeBarcode")]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public abstract class XamBarcode : global::System.Windows.Controls.Control, global::Infragistics.IUpdateVisualState
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x0001A2B3 File Offset: 0x000184B3
		internal virtual global::Infragistics.Controls.Barcodes.XamBarcodeView CreateView()
		{
			return new global::Infragistics.Controls.Barcodes.XamBarcodeView(this);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0001A2BB File Offset: 0x000184BB
		internal virtual void OnViewCreated(global::Infragistics.Controls.Barcodes.XamBarcodeView view)
		{
			this.View = view;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0001A2C4 File Offset: 0x000184C4
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x0001A2CC File Offset: 0x000184CC
		[global::System.Runtime.CompilerServices.DontObfuscate]
		internal virtual global::Infragistics.Controls.Barcodes.XamBarcodeView View { get; set; }

		// Token: 0x060001C8 RID: 456 RVA: 0x0001A2D8 File Offset: 0x000184D8
		static XamBarcode()
		{
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Controls.Barcodes.XamBarcode));
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0001A40C File Offset: 0x0001860C
		protected XamBarcode()
		{
			this._viewport = global::System.Windows.Rect.Empty;
			global::Infragistics.Controls.Barcodes.XamBarcodeView xamBarcodeView = this.CreateView();
			this.OnViewCreated(xamBarcodeView);
			xamBarcodeView.OnInit();
			this.ErrorMessageText = global::SR.GetString("ErrorMessageText");
			this.Interaction = new global::Infragistics.InteractionHelper(this);
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
			binding.Path = new global::System.Windows.PropertyPath("Background", new object[0]);
			binding.Source = this;
			base.SetBinding(global::Infragistics.Controls.Barcodes.XamBarcode.InnerBackgroundProperty, binding);
			global::System.Windows.Data.Binding binding2 = new global::System.Windows.Data.Binding();
			binding2.Path = new global::System.Windows.PropertyPath("Foreground", new object[0]);
			binding2.Source = this;
			base.SetBinding(global::Infragistics.Controls.Barcodes.XamBarcode.InnerForegroundProperty, binding2);
			global::Infragistics.Windows.Utilities.ValidateLicense(typeof(global::Infragistics.Controls.Barcodes.XamBarcode), this);
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0001A4CB File Offset: 0x000186CB
		// (set) Token: 0x060001CB RID: 459 RVA: 0x0001A4D3 File Offset: 0x000186D3
		private global::System.Windows.Controls.Grid RootGrid { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0001A4DC File Offset: 0x000186DC
		// (set) Token: 0x060001CD RID: 461 RVA: 0x0001A4E4 File Offset: 0x000186E4
		private bool SuspendDataUpdates
		{
			get
			{
				return this._suspendDataUpdates;
			}
			set
			{
				this._suspendDataUpdates = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0001A4ED File Offset: 0x000186ED
		// (set) Token: 0x060001CF RID: 463 RVA: 0x0001A4F5 File Offset: 0x000186F5
		private bool IsDataFake
		{
			get
			{
				return this._isDataFake;
			}
			set
			{
				this._isDataFake = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0001A4FE File Offset: 0x000186FE
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x0001A506 File Offset: 0x00018706
		internal string PropertyExceptionString
		{
			get
			{
				return this._propertyExceptionString;
			}
			set
			{
				this._propertyExceptionString = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x0001A50F File Offset: 0x0001870F
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x0001A517 File Offset: 0x00018717
		public bool IsValid
		{
			get
			{
				return this._isValid;
			}
			set
			{
				if (value != this._isValid)
				{
					this._isValid = value;
					this.UpdateVisualState(true);
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0001A530 File Offset: 0x00018730
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x0001A538 File Offset: 0x00018738
		protected internal global::System.Windows.Rect Viewport
		{
			get
			{
				return this._viewport;
			}
			set
			{
				global::System.Windows.Rect viewport = this._viewport;
				this._viewport = value;
				if (!viewport.Equals(this._viewport))
				{
					this.OnViewportChanged(viewport, this._viewport);
				}
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0001A56F File Offset: 0x0001876F
		private void OnViewportChanged(global::System.Windows.Rect oldViewport, global::System.Windows.Rect newViewport)
		{
			this.View.ScheduleArrange();
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0001A57C File Offset: 0x0001877C
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x0001A58E File Offset: 0x0001878E
		private global::System.Windows.Media.Brush InnerBackground
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Barcodes.XamBarcode.InnerBackgroundProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamBarcode.InnerBackgroundProperty, value);
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0001A59C File Offset: 0x0001879C
		private static void OnInnerBackgroundChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamBarcode)d).OnInnerBackgroundChanged((global::System.Windows.Media.Brush)e.OldValue, (global::System.Windows.Media.Brush)e.NewValue);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0001A5C1 File Offset: 0x000187C1
		private void OnInnerBackgroundChanged(global::System.Windows.Media.Brush oldValue, global::System.Windows.Media.Brush newValue)
		{
			this.UpdateBackground();
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0001A5C9 File Offset: 0x000187C9
		// (set) Token: 0x060001DC RID: 476 RVA: 0x0001A5DB File Offset: 0x000187DB
		private global::System.Windows.Media.Brush InnerForeground
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Controls.Barcodes.XamBarcode.InnerForegroundProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamBarcode.InnerForegroundProperty, value);
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0001A5E9 File Offset: 0x000187E9
		private static void OnInnerForegroundChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamBarcode)d).OnInnerForegroundChanged((global::System.Windows.Media.Brush)e.OldValue, (global::System.Windows.Media.Brush)e.NewValue);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0001A60E File Offset: 0x0001880E
		private void OnInnerForegroundChanged(global::System.Windows.Media.Brush oldValue, global::System.Windows.Media.Brush newValue)
		{
			this.UpdateForeground();
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0001A616 File Offset: 0x00018816
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x0001A628 File Offset: 0x00018828
		public string Data
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Barcodes.XamBarcode.DataProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamBarcode.DataProperty, value);
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0001A636 File Offset: 0x00018836
		private static void OnDataChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamBarcode)d).OnDataChanged((string)e.OldValue, (string)e.NewValue);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0001A65C File Offset: 0x0001885C
		private void OnDataChanged(string oldValue, string newValue)
		{
			if (!string.IsNullOrEmpty(newValue))
			{
				this.IsDataFake = false;
			}
			if (this.SuspendDataUpdates)
			{
				return;
			}
			this.View.ScheduleArrange();
			if (this.DataChanged != null)
			{
				this.DataChanged(this, new global::Infragistics.Controls.Barcodes.DataChangedEventArgs(newValue));
			}
			this.isDataChanged = true;
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0001A6AD File Offset: 0x000188AD
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x0001A6BF File Offset: 0x000188BF
		public string ErrorMessageText
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Barcodes.XamBarcode.ErrorMessageTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamBarcode.ErrorMessageTextProperty, value);
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0001A6CD File Offset: 0x000188CD
		private static void OnErrorMessageTextChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamBarcode)d).OnErrorMessageTextChanged((string)e.OldValue, (string)e.NewValue);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0001A6F2 File Offset: 0x000188F2
		private void OnErrorMessageTextChanged(string oldValue, string newValue)
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0001A6F4 File Offset: 0x000188F4
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x0001A706 File Offset: 0x00018906
		[global::System.Runtime.CompilerServices.WidgetDefaultString("uniform")]
		public global::System.Windows.Media.Stretch Stretch
		{
			get
			{
				return (global::System.Windows.Media.Stretch)base.GetValue(global::Infragistics.Controls.Barcodes.XamBarcode.StretchProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamBarcode.StretchProperty, value);
			}
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0001A719 File Offset: 0x00018919
		private static void OnStretchChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamBarcode)d).OnStretchChanged((global::System.Windows.Media.Stretch)e.OldValue, (global::System.Windows.Media.Stretch)e.NewValue);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0001A73E File Offset: 0x0001893E
		protected virtual void OnStretchChanged(global::System.Windows.Media.Stretch oldValue, global::System.Windows.Media.Stretch newValue)
		{
			base.InvalidateMeasure();
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0001A750 File Offset: 0x00018950
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.RootGrid = (base.GetTemplateChild("RootGrid") as global::System.Windows.Controls.Grid);
			if (this.RootGrid != null)
			{
				global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
				binding.Path = new global::System.Windows.PropertyPath("Background", new object[0]);
				binding.Source = this;
				this.RootGrid.SetBinding(global::System.Windows.Controls.Panel.BackgroundProperty, binding);
			}
			this.View.OnTemplateProvided((string n) => base.GetTemplateChild(n));
			this.Interaction.OnApplyTemplateBase();
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0001A7D8 File Offset: 0x000189D8
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Controls.Barcodes.AutomationPeers.XamBarcodeAutomationPeer(this);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0001A7E0 File Offset: 0x000189E0
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			global::System.Windows.Size result = base.ArrangeOverride(finalSize);
			bool isEmpty = this.Viewport.IsEmpty;
			this.Viewport = new global::System.Windows.Rect(0.0, 0.0, result.Width, result.Height);
			return result;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0001A830 File Offset: 0x00018A30
		protected internal virtual void UpdateBackground()
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0001A832 File Offset: 0x00018A32
		protected internal virtual void UpdateForeground()
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0001A834 File Offset: 0x00018A34
		protected internal virtual void ArrangeBarcode()
		{
			if (this.RootGrid == null || this.View.GetErrorTextBlock() == null)
			{
				return;
			}
			bool flag = this.ValidateParameters();
			if (global::Infragistics.Controls.Barcodes.XamBarcode.IsInDesignMode())
			{
				this.SuspendDataUpdates = true;
				if (string.IsNullOrEmpty(this.Data) || this.IsDataFake)
				{
					this.Data = this.GetDesignTimeFakeData();
					this.IsDataFake = true;
					flag = this.ValidateParameters();
				}
				this.SuspendDataUpdates = false;
			}
			else
			{
				this.IsDataFake = false;
			}
			if (!flag)
			{
				global::System.Exception e_;
				if (string.IsNullOrEmpty(this.PropertyExceptionString))
				{
					e_ = new global::System.Exception(this.ErrorMessageText);
				}
				else
				{
					e_ = new global::System.ArgumentException(this.PropertyExceptionString);
					this.PropertyExceptionString = string.Empty;
				}
				this.ErrorMessage(e_);
				return;
			}
			this.ClearWarnings();
		}

		// Token: 0x060001F1 RID: 497
		protected abstract string GetDesignTimeFakeData();

		// Token: 0x060001F2 RID: 498 RVA: 0x0001A8F0 File Offset: 0x00018AF0
		internal void ErrorMessage(string errorMessage)
		{
			this.IsValid = false;
			global::System.Windows.Controls.TextBlock errorTextBlock = this.View.GetErrorTextBlock();
			if (errorTextBlock != null)
			{
				errorTextBlock.Text = errorMessage;
				errorTextBlock.Visibility = global::System.Windows.Visibility.Visible;
				return;
			}
			this.PropertyExceptionString = errorMessage;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0001A92C File Offset: 0x00018B2C
		internal void ClearWarnings()
		{
			this.IsValid = true;
			global::System.Windows.Controls.TextBlock errorTextBlock = this.View.GetErrorTextBlock();
			errorTextBlock.Visibility = global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0001A954 File Offset: 0x00018B54
		protected virtual bool ValidateData(string data)
		{
			bool flag = string.IsNullOrEmpty(data);
			return global::Infragistics.Controls.Barcodes.XamBarcode.IsInDesignMode() || !flag;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0001A975 File Offset: 0x00018B75
		protected virtual bool ValidateParameters()
		{
			return this.ValidateData(this.Data);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0001A983 File Offset: 0x00018B83
		protected virtual void OnErrorMessageDisplaying(global::Infragistics.ErrorMessageDisplayingEventArgs args)
		{
			if (this.ErrorMessageDisplaying != null)
			{
				this.ErrorMessageDisplaying(this, args);
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0001A99A File Offset: 0x00018B9A
		internal virtual void ExportVisualDataInternal(global::Infragistics.Controls.Barcodes.VisualData.BarcodeVisualData barcodeVisualData)
		{
			barcodeVisualData.Viewport = this.Viewport;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0001A9A8 File Offset: 0x00018BA8
		internal void ErrorMessage(global::System.Exception e_)
		{
			string @string = global::SR.GetString("WarningString");
			string errorMessage = @string + e_.Message;
			global::Infragistics.ErrorMessageDisplayingEventArgs errorMessageDisplayingEventArgs = new global::Infragistics.ErrorMessageDisplayingEventArgs(errorMessage);
			this.OnErrorMessageDisplaying(errorMessageDisplayingEventArgs);
			this.ErrorMessage(errorMessageDisplayingEventArgs.ErrorMessage);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0001A9E8 File Offset: 0x00018BE8
		internal global::System.Windows.Point CalculateOffset(global::System.Windows.Size finalSize, global::System.Windows.Size controlSize)
		{
			global::System.Windows.Point result = new global::System.Windows.Point(0.0, 0.0);
			switch (base.VerticalAlignment)
			{
			case global::System.Windows.VerticalAlignment.Top:
				result.Y = 0.0;
				break;
			case global::System.Windows.VerticalAlignment.Center:
			case global::System.Windows.VerticalAlignment.Stretch:
				result.Y = (finalSize.Height - controlSize.Height) / 2.0;
				break;
			case global::System.Windows.VerticalAlignment.Bottom:
				result.Y = finalSize.Height - controlSize.Height;
				break;
			}
			switch (base.HorizontalAlignment)
			{
			case global::System.Windows.HorizontalAlignment.Left:
				result.X = 0.0;
				break;
			case global::System.Windows.HorizontalAlignment.Center:
			case global::System.Windows.HorizontalAlignment.Stretch:
				result.X = (finalSize.Width - controlSize.Width) / 2.0;
				break;
			case global::System.Windows.HorizontalAlignment.Right:
				result.X = finalSize.Width - controlSize.Width;
				break;
			}
			result.X = global::System.Math.Round(result.X - 0.5);
			result.Y = global::System.Math.Round(result.Y - 0.5);
			return result;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0001AB1C File Offset: 0x00018D1C
		protected static bool IsInDesignMode()
		{
			if (global::Infragistics.Controls.Barcodes.XamBarcode.isInDesignMode == null)
			{
				global::System.Windows.DependencyProperty isInDesignModeProperty = global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty;
				global::Infragistics.Controls.Barcodes.XamBarcode.isInDesignMode = new bool?((bool)global::System.ComponentModel.DependencyPropertyDescriptor.FromProperty(isInDesignModeProperty, typeof(global::System.Windows.FrameworkElement)).Metadata.DefaultValue);
			}
			return global::Infragistics.Controls.Barcodes.XamBarcode.isInDesignMode.Value;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0001AB6E File Offset: 0x00018D6E
		protected override void OnGotFocus(global::System.Windows.RoutedEventArgs e)
		{
			if (this.Interaction.AllowGotFocus(e))
			{
				this.Interaction.OnGotFocusBase();
				base.OnGotFocus(e);
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0001AB90 File Offset: 0x00018D90
		protected override void OnLostFocus(global::System.Windows.RoutedEventArgs e)
		{
			if (this.Interaction.AllowLostFocus(e))
			{
				this.Interaction.OnLostFocusBase();
				base.OnLostFocus(e);
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0001ABB2 File Offset: 0x00018DB2
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this.Interaction.AllowMouseEnter(e))
			{
				this.Interaction.OnMouseEnterBase();
				base.OnMouseEnter(e);
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0001ABD4 File Offset: 0x00018DD4
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this.Interaction.AllowMouseLeave(e))
			{
				this.Interaction.OnMouseLeaveBase();
				base.OnMouseLeave(e);
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0001ABF6 File Offset: 0x00018DF6
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.Interaction.AllowMouseLeftButtonDown(e))
			{
				this.Interaction.OnMouseLeftButtonDownBase();
				base.OnMouseLeftButtonDown(e);
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0001AC18 File Offset: 0x00018E18
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.Interaction.AllowMouseLeftButtonUp(e))
			{
				this.Interaction.OnMouseLeftButtonUpBase();
				base.OnMouseLeftButtonUp(e);
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0001AC3A File Offset: 0x00018E3A
		// (set) Token: 0x06000202 RID: 514 RVA: 0x0001AC42 File Offset: 0x00018E42
		private global::Infragistics.InteractionHelper Interaction { get; set; }

		// Token: 0x06000203 RID: 515 RVA: 0x0001AC4B File Offset: 0x00018E4B
		public void UpdateVisualState(bool useTransitions)
		{
			global::System.Windows.VisualStateManager.GoToState(this, this.IsValid ? "ValidBarcode" : "InvalidBarcode", useTransitions);
			this.Interaction.UpdateVisualStateBase(useTransitions);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0001AC75 File Offset: 0x00018E75
		void global::Infragistics.IUpdateVisualState.UpdateVisualState(bool useTransitions)
		{
			this.UpdateVisualState(useTransitions);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000205 RID: 517 RVA: 0x0001AC80 File Offset: 0x00018E80
		// (remove) Token: 0x06000206 RID: 518 RVA: 0x0001ACB8 File Offset: 0x00018EB8
		public event global::System.EventHandler<global::Infragistics.ErrorMessageDisplayingEventArgs> ErrorMessageDisplaying;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000207 RID: 519 RVA: 0x0001ACF0 File Offset: 0x00018EF0
		// (remove) Token: 0x06000208 RID: 520 RVA: 0x0001AD28 File Offset: 0x00018F28
		public event global::System.EventHandler<global::Infragistics.Controls.Barcodes.DataChangedEventArgs> DataChanged;

		// Token: 0x06000209 RID: 521 RVA: 0x0001AD5D File Offset: 0x00018F5D
		public static void RegisterResources(string name, global::System.Reflection.Assembly assembly)
		{
			global::SR.AddResource(name, assembly);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0001AD66 File Offset: 0x00018F66
		public static void UnregisterResources(string name)
		{
			global::SR.RemoveResource(name);
		}

		// Token: 0x040001A9 RID: 425
		private const string RootGridName = "RootGrid";

		// Token: 0x040001AA RID: 426
		private const string ErrorTextBlockName = "ErrorTextBlock";

		// Token: 0x040001AB RID: 427
		private const string GroupBarcode = "GroupBarcode";

		// Token: 0x040001AC RID: 428
		private const string StateValid = "ValidBarcode";

		// Token: 0x040001AD RID: 429
		private const string StateInvalid = "InvalidBarcode";

		// Token: 0x040001AE RID: 430
		private bool layoutUpdated;

		// Token: 0x040001AF RID: 431
		private bool isDataChanged;

		// Token: 0x040001B0 RID: 432
		private bool _suspendDataUpdates;

		// Token: 0x040001B1 RID: 433
		private bool _isDataFake;

		// Token: 0x040001B2 RID: 434
		private string _propertyExceptionString;

		// Token: 0x040001B3 RID: 435
		private bool _isValid;

		// Token: 0x040001B4 RID: 436
		private global::System.Windows.Rect _viewport;

		// Token: 0x040001B5 RID: 437
		private static readonly global::System.Windows.DependencyProperty InnerBackgroundProperty = global::System.Windows.DependencyProperty.Register("InnerBackground", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Barcodes.XamBarcode), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamBarcode.OnInnerBackgroundChanged)));

		// Token: 0x040001B6 RID: 438
		private static readonly global::System.Windows.DependencyProperty InnerForegroundProperty = global::System.Windows.DependencyProperty.Register("InnerForeground", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Controls.Barcodes.XamBarcode), new global::System.Windows.PropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamBarcode.OnInnerForegroundChanged)));

		// Token: 0x040001B7 RID: 439
		public static readonly global::System.Windows.DependencyProperty DataProperty = global::System.Windows.DependencyProperty.Register("Data", typeof(string), typeof(global::Infragistics.Controls.Barcodes.XamBarcode), new global::System.Windows.PropertyMetadata(string.Empty, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamBarcode.OnDataChanged)));

		// Token: 0x040001B8 RID: 440
		public static readonly global::System.Windows.DependencyProperty ErrorMessageTextProperty = global::System.Windows.DependencyProperty.Register("ErrorMessageText", typeof(string), typeof(global::Infragistics.Controls.Barcodes.XamBarcode), new global::System.Windows.PropertyMetadata(string.Empty, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamBarcode.OnErrorMessageTextChanged)));

		// Token: 0x040001B9 RID: 441
		public static readonly global::System.Windows.DependencyProperty StretchProperty = global::System.Windows.DependencyProperty.Register("Stretch", typeof(global::System.Windows.Media.Stretch), typeof(global::Infragistics.Controls.Barcodes.XamBarcode), new global::System.Windows.PropertyMetadata(global::System.Windows.Media.Stretch.Uniform, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamBarcode.OnStretchChanged)));

		// Token: 0x040001BA RID: 442
		private static bool? isInDesignMode;
	}
}
