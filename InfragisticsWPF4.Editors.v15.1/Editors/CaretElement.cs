using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000093 RID: 147
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CaretElement : global::System.Windows.Controls.Control
	{
		// Token: 0x060008BA RID: 2234 RVA: 0x00027734 File Offset: 0x00025934
		static CaretElement()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CaretElement), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.CaretElement)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CaretElement), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x000277E2 File Offset: 0x000259E2
		public CaretElement()
		{
			base.Loaded += this.OnLoadedHandler;
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x000277FC File Offset: 0x000259FC
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size arrangeBounds)
		{
			global::System.Windows.Size result = base.ArrangeOverride(arrangeBounds);
			this._hasBeenArranged = true;
			return result;
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x00027819 File Offset: 0x00025A19
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x0002782B File Offset: 0x00025A2B
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

		// Token: 0x060008BF RID: 2239 RVA: 0x00027840 File Offset: 0x00025A40
		private static void OnBlinkVisibilityChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CaretElement caretElement = (global::Infragistics.Windows.Editors.CaretElement)dependencyObject;
			bool flag = (bool)e.NewValue;
			caretElement.Visibility = (flag ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Hidden);
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0002786E File Offset: 0x00025A6E
		private void OnLoadedHandler(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this._hasBeenLoaded = true;
			base.Loaded -= this.OnLoadedHandler;
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00027889 File Offset: 0x00025A89
		internal void ResetCaretBlinking()
		{
			if (this._hasBeenLoaded && this._hasBeenArranged)
			{
				this.RaiseResetBlinking();
			}
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x000278A4 File Offset: 0x00025AA4
		private void RaiseResetBlinking()
		{
			base.RaiseEvent(new global::System.Windows.RoutedEventArgs
			{
				RoutedEvent = global::Infragistics.Windows.Editors.CaretElement.ResetBlinkingEvent,
				Source = this
			});
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x000278D0 File Offset: 0x00025AD0
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

		// Token: 0x040002F1 RID: 753
		private bool _hasBeenArranged;

		// Token: 0x040002F2 RID: 754
		private bool _hasBeenLoaded;

		// Token: 0x040002F3 RID: 755
		public static readonly global::System.Windows.DependencyProperty BlinkVisibilityProperty = global::System.Windows.DependencyProperty.Register("BlinkVisibility", typeof(bool), typeof(global::Infragistics.Windows.Editors.CaretElement), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CaretElement.OnBlinkVisibilityChanged), null));

		// Token: 0x040002F4 RID: 756
		public static readonly global::System.Windows.RoutedEvent ResetBlinkingEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ResetBlinking", global::System.Windows.RoutingStrategy.Direct, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Infragistics.Windows.Editors.CaretElement));
	}
}
