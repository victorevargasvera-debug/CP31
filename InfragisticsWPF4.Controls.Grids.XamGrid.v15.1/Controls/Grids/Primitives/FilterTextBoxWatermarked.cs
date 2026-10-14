using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200008D RID: 141
	[global::System.Windows.TemplateVisualState(GroupName = "WaterMarks", Name = "HideWaterMark")]
	[global::System.Windows.TemplateVisualState(GroupName = "ClearButtonStates", Name = "ShowClearButton")]
	[global::System.Windows.TemplateVisualState(GroupName = "ClearButtonStates", Name = "HideClearButton")]
	[global::System.Windows.TemplatePart(Name = "FilterTextBox", Type = typeof(global::Infragistics.Controls.Grids.Primitives.FilterTextBox))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(GroupName = "WaterMarks", Name = "ShowWaterMark")]
	public class FilterTextBoxWatermarked : global::System.Windows.Controls.Control, global::System.ComponentModel.INotifyPropertyChanged, global::Infragistics.ICommandTarget
	{
		// Token: 0x06000560 RID: 1376 RVA: 0x0001AE00 File Offset: 0x00019000
		static FilterTextBoxWatermarked()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.FilterTextBoxWatermarked), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.FilterTextBoxWatermarked)));
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0001AEA2 File Offset: 0x000190A2
		public FilterTextBoxWatermarked()
		{
			base.Loaded += this.FilterTextBoxWatermarked_Loaded;
			base.Unloaded += this.FilterTextBoxWatermarked_Unloaded;
			base.Focusable = false;
			base.IsTabStop = false;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0001AEDC File Offset: 0x000190DC
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this._filterTextBox != null)
			{
				this._filterTextBox.GotFocus -= this.FilterTextBox_GotFocus;
				this._filterTextBox.LostFocus -= this.FilterTextBox_LostFocus;
			}
			this._filterTextBox = (base.GetTemplateChild("FilterTextBox") as global::Infragistics.Controls.Grids.Primitives.FilterTextBox);
			if (this._filterTextBox != null)
			{
				this._filterTextBox.TextChanged += this.FilterTextBox_TextChanged;
				this._filterTextBox.GotFocus += this.FilterTextBox_GotFocus;
				this._filterTextBox.LostFocus += this.FilterTextBox_LostFocus;
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0001AF88 File Offset: 0x00019188
		protected override void OnLostFocus(global::System.Windows.RoutedEventArgs e)
		{
			base.OnLostFocus(e);
			this.EnsureVisualState();
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0001AF97 File Offset: 0x00019197
		protected override void OnGotFocus(global::System.Windows.RoutedEventArgs e)
		{
			base.OnGotFocus(e);
			global::System.Windows.VisualStateManager.GoToState(this, "HideWaterMark", false);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0001AFAD File Offset: 0x000191AD
		private void FilterTextBox_LostFocus(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.EnsureVisualState();
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0001AFB5 File Offset: 0x000191B5
		private void FilterTextBox_GotFocus(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.VisualStateManager.GoToState(this, "HideWaterMark", false);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0001AFC4 File Offset: 0x000191C4
		private void FilterTextBoxWatermarked_Unloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this._filterTextBox != null)
			{
				this._filterTextBox.GotFocus -= this.FilterTextBox_GotFocus;
				this._filterTextBox.LostFocus -= this.FilterTextBox_LostFocus;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x0001AFFC File Offset: 0x000191FC
		// (set) Token: 0x06000569 RID: 1385 RVA: 0x0001B00E File Offset: 0x0001920E
		public global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl FilterSelectionControl
		{
			get
			{
				return (global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl)base.GetValue(global::Infragistics.Controls.Grids.Primitives.FilterTextBoxWatermarked.FilterSelectionControlProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.FilterTextBoxWatermarked.FilterSelectionControlProperty, value);
			}
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0001B01C File Offset: 0x0001921C
		private static void FilterSelectionControlChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterTextBoxWatermarked filterTextBoxWatermarked = (global::Infragistics.Controls.Grids.Primitives.FilterTextBoxWatermarked)obj;
			filterTextBoxWatermarked.OnPropertyChanged("FilterSelectionControl");
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x0001B03B File Offset: 0x0001923B
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x0001B04D File Offset: 0x0001924D
		public string Watermark
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Grids.Primitives.FilterTextBoxWatermarked.WatermarkProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.FilterTextBoxWatermarked.WatermarkProperty, value);
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0001B05C File Offset: 0x0001925C
		private static void WatermarkChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterTextBoxWatermarked filterTextBoxWatermarked = (global::Infragistics.Controls.Grids.Primitives.FilterTextBoxWatermarked)obj;
			filterTextBoxWatermarked.OnPropertyChanged("Watermark");
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0001B07C File Offset: 0x0001927C
		protected virtual void EnsureVisualState()
		{
			if (this._filterTextBox != null)
			{
				if (this._filterTextBox.Text.Length == 0)
				{
					global::System.Windows.VisualStateManager.GoToState(this, "ShowWaterMark", false);
					global::System.Windows.VisualStateManager.GoToState(this, "HideClearButton", false);
				}
				else
				{
					global::System.Windows.VisualStateManager.GoToState(this, "HideWaterMark", false);
					global::System.Windows.VisualStateManager.GoToState(this, "ShowClearButton", false);
				}
			}
			this.EnsureClearButtonState();
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0001B0DF File Offset: 0x000192DF
		private void EnsureClearButtonState()
		{
			if (this._filterTextBox != null)
			{
				if (this._filterTextBox.Text.Length == 0)
				{
					global::System.Windows.VisualStateManager.GoToState(this, "HideClearButton", false);
					return;
				}
				global::System.Windows.VisualStateManager.GoToState(this, "ShowClearButton", false);
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0001B116 File Offset: 0x00019316
		private void FilterTextBox_TextChanged(object sender, global::System.Windows.Controls.TextChangedEventArgs e)
		{
			this.EnsureVisualState();
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0001B120 File Offset: 0x00019320
		private void FilterTextBoxWatermarked_Loaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this._filterTextBox != null)
			{
				this._filterTextBox.GotFocus -= this.FilterTextBox_GotFocus;
				this._filterTextBox.LostFocus -= this.FilterTextBox_LostFocus;
				this._filterTextBox.GotFocus += this.FilterTextBox_GotFocus;
				this._filterTextBox.LostFocus += this.FilterTextBox_LostFocus;
			}
			this.EnsureVisualState();
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06000572 RID: 1394 RVA: 0x0001B198 File Offset: 0x00019398
		// (remove) Token: 0x06000573 RID: 1395 RVA: 0x0001B1D0 File Offset: 0x000193D0
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000574 RID: 1396 RVA: 0x0001B205 File Offset: 0x00019405
		protected virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0001B221 File Offset: 0x00019421
		bool global::Infragistics.ICommandTarget.SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return this.SupportsCommand(command);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0001B22A File Offset: 0x0001942A
		object global::Infragistics.ICommandTarget.GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this.GetParameter(source);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0001B233 File Offset: 0x00019433
		protected virtual bool SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return command is global::Infragistics.Controls.Grids.Primitives.FilterMenuFilterTextBoxCommand;
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0001B23E File Offset: 0x0001943E
		protected virtual object GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this;
		}

		// Token: 0x04000177 RID: 375
		private global::Infragistics.Controls.Grids.Primitives.FilterTextBox _filterTextBox;

		// Token: 0x04000178 RID: 376
		public static readonly global::System.Windows.DependencyProperty FilterSelectionControlProperty = global::System.Windows.DependencyProperty.Register("FilterSelectionControl", typeof(global::Infragistics.Controls.Grids.Primitives.FilterSelectionControl), typeof(global::Infragistics.Controls.Grids.Primitives.FilterTextBoxWatermarked), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.FilterTextBoxWatermarked.FilterSelectionControlChanged)));

		// Token: 0x04000179 RID: 377
		public static readonly global::System.Windows.DependencyProperty WatermarkProperty = global::System.Windows.DependencyProperty.Register("Watermark", typeof(string), typeof(global::Infragistics.Controls.Grids.Primitives.FilterTextBoxWatermarked), new global::System.Windows.PropertyMetadata(global::Infragistics.SRGrid.GetString("Watermark"), new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.FilterTextBoxWatermarked.WatermarkChanged)));
	}
}
