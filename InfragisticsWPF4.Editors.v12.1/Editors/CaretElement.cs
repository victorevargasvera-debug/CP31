using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200008C RID: 140
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CaretElement : global::System.Windows.Controls.Control
	{
		// Token: 0x0600084D RID: 2125 RVA: 0x00025998 File Offset: 0x00023B98
		static CaretElement()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CaretElement), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.CaretElement)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CaretElement), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00025A46 File Offset: 0x00023C46
		public CaretElement()
		{
			base.Loaded += this.OnLoadedHandler;
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00025A60 File Offset: 0x00023C60
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size arrangeBounds)
		{
			global::System.Windows.Size result = base.ArrangeOverride(arrangeBounds);
			this._hasBeenArranged = true;
			return result;
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x00025A7D File Offset: 0x00023C7D
		// (set) Token: 0x06000851 RID: 2129 RVA: 0x00025A8F File Offset: 0x00023C8F
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool BlinkVisibility
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CaretElement.BlinkVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.CaretElement.BlinkVisibilityProperty, value);
			}
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00025AA4 File Offset: 0x00023CA4
		private static void OnBlinkVisibilityChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CaretElement caretElement = (global::Infragistics.Windows.Editors.CaretElement)dependencyObject;
			bool flag = (bool)e.NewValue;
			caretElement.Visibility = (flag ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Hidden);
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00025AD2 File Offset: 0x00023CD2
		private void OnLoadedHandler(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this._hasBeenLoaded = true;
			base.Loaded -= this.OnLoadedHandler;
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00025AED File Offset: 0x00023CED
		internal void ResetCaretBlinking()
		{
			if (this._hasBeenLoaded && this._hasBeenArranged)
			{
				this.RaiseResetBlinking();
			}
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00025B08 File Offset: 0x00023D08
		private void RaiseResetBlinking()
		{
			base.RaiseEvent(new global::System.Windows.RoutedEventArgs
			{
				RoutedEvent = global::Infragistics.Windows.Editors.CaretElement.ResetBlinkingEvent,
				Source = this
			});
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x00025B34 File Offset: 0x00023D34
		public static global::System.Windows.Duration CaretBlinkDuration
		{
			get
			{
				int num = global::Infragistics.Windows.Utilities.CaretBlinkTime;
				if (num <= 0)
				{
					num = 0;
				}
				return new global::System.Windows.Duration(global::System.TimeSpan.FromMilliseconds((double)(2 * num)));
			}
		}

		// Token: 0x040002BB RID: 699
		private bool _hasBeenArranged;

		// Token: 0x040002BC RID: 700
		private bool _hasBeenLoaded;

		// Token: 0x040002BD RID: 701
		public static readonly global::System.Windows.DependencyProperty BlinkVisibilityProperty = global::System.Windows.DependencyProperty.Register("BlinkVisibility", typeof(bool), typeof(global::Infragistics.Windows.Editors.CaretElement), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CaretElement.OnBlinkVisibilityChanged), null));

		// Token: 0x040002BE RID: 702
		public static readonly global::System.Windows.RoutedEvent ResetBlinkingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ResetBlinking", global::System.Windows.RoutingStrategy.Direct, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Infragistics.Windows.Editors.CaretElement));
	}
}
