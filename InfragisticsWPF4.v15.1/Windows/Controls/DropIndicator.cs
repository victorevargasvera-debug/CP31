using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000133 RID: 307
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class DropIndicator : global::System.Windows.Controls.Control
	{
		// Token: 0x06000B4D RID: 2893 RVA: 0x00025738 File Offset: 0x00023938
		static DropIndicator()
		{
			global::Infragistics.Windows.Controls.DropIndicator.DropTargetInitializeEvent = global::System.Windows.EventManager.RegisterRoutedEvent("DropTargetInitialize", global::System.Windows.RoutingStrategy.Direct, typeof(global::System.EventHandler<global::System.Windows.RoutedEventArgs>), typeof(global::Infragistics.Windows.Controls.DropIndicator));
			global::Infragistics.Windows.Controls.DropIndicator.DropTargetEnterEvent = global::System.Windows.EventManager.RegisterRoutedEvent("DropTargetEnter", global::System.Windows.RoutingStrategy.Direct, typeof(global::System.EventHandler<global::System.Windows.RoutedEventArgs>), typeof(global::Infragistics.Windows.Controls.DropIndicator));
			global::Infragistics.Windows.Controls.DropIndicator.DropTargetLeaveEvent = global::System.Windows.EventManager.RegisterRoutedEvent("DropTargetLeave", global::System.Windows.RoutingStrategy.Direct, typeof(global::System.EventHandler<global::System.Windows.RoutedEventArgs>), typeof(global::Infragistics.Windows.Controls.DropIndicator));
			global::Infragistics.Windows.Controls.DropIndicator.DropLocationProperty = global::System.Windows.DependencyProperty.Register("DropLocation", typeof(global::Infragistics.Windows.Controls.DropLocation?), typeof(global::Infragistics.Windows.Controls.DropIndicator), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Controls.DropIndicator.OnDropLocationChanged)));
			global::Infragistics.Windows.Controls.DropIndicator.DropTargetHeightProperty = global::System.Windows.DependencyProperty.Register("DropTargetHeight", typeof(double), typeof(global::Infragistics.Windows.Controls.DropIndicator), new global::System.Windows.FrameworkPropertyMetadata(double.NaN));
			global::Infragistics.Windows.Controls.DropIndicator.DropTargetWidthProperty = global::System.Windows.DependencyProperty.Register("DropTargetWidth", typeof(double), typeof(global::Infragistics.Windows.Controls.DropIndicator), new global::System.Windows.FrameworkPropertyMetadata(double.NaN));
			global::Infragistics.Windows.Controls.DropIndicator.OrientationPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Orientation", typeof(global::System.Windows.Controls.Orientation?), typeof(global::Infragistics.Windows.Controls.DropIndicator), new global::System.Windows.FrameworkPropertyMetadata(null));
			global::Infragistics.Windows.Controls.DropIndicator.OrientationProperty = global::Infragistics.Windows.Controls.DropIndicator.OrientationPropertyKey.DependencyProperty;
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.DropIndicator), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Controls.DropIndicator)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Controls.DropIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x000258D3 File Offset: 0x00023AD3
		protected virtual void OnDropTargetInitialize(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x000258DC File Offset: 0x00023ADC
		internal void RaiseDropTargetInitialize(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.DropIndicator.DropTargetInitializeEvent;
			args.Source = this;
			this.OnDropTargetInitialize(args);
			this._wasInitializeEventRaised = true;
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06000B51 RID: 2897 RVA: 0x000258FE File Offset: 0x00023AFE
		// (remove) Token: 0x06000B52 RID: 2898 RVA: 0x0002590C File Offset: 0x00023B0C
		public event global::System.EventHandler<global::System.Windows.RoutedEventArgs> DropTargetInitialize
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Controls.DropIndicator.DropTargetInitializeEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Controls.DropIndicator.DropTargetInitializeEvent, value);
			}
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0002591A File Offset: 0x00023B1A
		protected virtual void OnDropTargetEnter(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00025923 File Offset: 0x00023B23
		internal void RaiseDropTargetEnter(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.DropIndicator.DropTargetEnterEvent;
			args.Source = this;
			this.OnDropTargetEnter(args);
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06000B55 RID: 2901 RVA: 0x0002593E File Offset: 0x00023B3E
		// (remove) Token: 0x06000B56 RID: 2902 RVA: 0x0002594C File Offset: 0x00023B4C
		public event global::System.EventHandler<global::System.Windows.RoutedEventArgs> DropTargetEnter
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Controls.DropIndicator.DropTargetEnterEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Controls.DropIndicator.DropTargetEnterEvent, value);
			}
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x0002595A File Offset: 0x00023B5A
		protected virtual void OnDropTargetLeave(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00025963 File Offset: 0x00023B63
		internal void RaiseDropTargetLeave(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.DropIndicator.DropTargetLeaveEvent;
			args.Source = this;
			this.OnDropTargetLeave(args);
		}

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x06000B59 RID: 2905 RVA: 0x0002597E File Offset: 0x00023B7E
		// (remove) Token: 0x06000B5A RID: 2906 RVA: 0x0002598C File Offset: 0x00023B8C
		public event global::System.EventHandler<global::System.Windows.RoutedEventArgs> DropTargetLeave
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Controls.DropIndicator.DropTargetLeaveEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Controls.DropIndicator.DropTargetLeaveEvent, value);
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x0002599A File Offset: 0x00023B9A
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x000259AC File Offset: 0x00023BAC
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.Controls.DropLocation? DropLocation
		{
			get
			{
				return (global::Infragistics.Windows.Controls.DropLocation?)base.GetValue(global::Infragistics.Windows.Controls.DropIndicator.DropLocationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.DropIndicator.DropLocationProperty, value);
			}
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x000259C0 File Offset: 0x00023BC0
		private static void OnDropLocationChanged(global::System.Windows.DependencyObject dependencyObject, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Controls.DropLocation? dropLocation = (global::Infragistics.Windows.Controls.DropLocation?)e.NewValue;
			global::System.Windows.Controls.Orientation? orientation = null;
			if (dropLocation != null)
			{
				global::Infragistics.Windows.Controls.DropLocation value = dropLocation.Value;
				if (global::Infragistics.Windows.Controls.DropLocation.AboveTarget == value || global::Infragistics.Windows.Controls.DropLocation.BelowTarget == value)
				{
					orientation = new global::System.Windows.Controls.Orientation?(global::System.Windows.Controls.Orientation.Horizontal);
				}
				else if (global::Infragistics.Windows.Controls.DropLocation.LeftOfTarget == value || global::Infragistics.Windows.Controls.DropLocation.RightOfTarget == value)
				{
					orientation = new global::System.Windows.Controls.Orientation?(global::System.Windows.Controls.Orientation.Vertical);
				}
			}
			dependencyObject.SetValue(global::Infragistics.Windows.Controls.DropIndicator.OrientationPropertyKey, orientation);
			global::Infragistics.Windows.Controls.DropIndicator dropIndicator = dependencyObject as global::Infragistics.Windows.Controls.DropIndicator;
			if (dropIndicator != null && dropIndicator.IsLoaded)
			{
				if (!dropIndicator._wasInitializeEventRaised)
				{
					dropIndicator.RaiseDropTargetInitialize(new global::System.Windows.RoutedEventArgs());
					if (dropLocation == null)
					{
						return;
					}
				}
				if (dropLocation == null || dropLocation.Value == global::Infragistics.Windows.Controls.DropLocation.None)
				{
					dropIndicator.RaiseDropTargetLeave(new global::System.Windows.RoutedEventArgs());
					return;
				}
				dropIndicator.RaiseDropTargetEnter(new global::System.Windows.RoutedEventArgs());
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x00025A7E File Offset: 0x00023C7E
		// (set) Token: 0x06000B5F RID: 2911 RVA: 0x00025A90 File Offset: 0x00023C90
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public double DropTargetHeight
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.DropIndicator.DropTargetHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.DropIndicator.DropTargetHeightProperty, value);
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x00025AA3 File Offset: 0x00023CA3
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x00025AB5 File Offset: 0x00023CB5
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public double DropTargetWidth
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.DropIndicator.DropTargetWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.DropIndicator.DropTargetWidthProperty, value);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x00025AC8 File Offset: 0x00023CC8
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.Orientation? Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation?)base.GetValue(global::Infragistics.Windows.Controls.DropIndicator.OrientationProperty);
			}
		}

		// Token: 0x040004C8 RID: 1224
		private bool _wasInitializeEventRaised;

		// Token: 0x040004CC RID: 1228
		public static readonly global::System.Windows.DependencyProperty DropLocationProperty;

		// Token: 0x040004CD RID: 1229
		public static readonly global::System.Windows.DependencyProperty DropTargetHeightProperty;

		// Token: 0x040004CE RID: 1230
		public static readonly global::System.Windows.DependencyProperty DropTargetWidthProperty;

		// Token: 0x040004CF RID: 1231
		private static readonly global::System.Windows.DependencyPropertyKey OrientationPropertyKey;

		// Token: 0x040004D0 RID: 1232
		public static readonly global::System.Windows.DependencyProperty OrientationProperty;
	}
}
