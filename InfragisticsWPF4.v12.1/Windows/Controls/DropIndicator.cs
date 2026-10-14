using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000115 RID: 277
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class DropIndicator : global::System.Windows.Controls.Control
	{
		// Token: 0x06000A4E RID: 2638 RVA: 0x00021B70 File Offset: 0x0001FD70
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

		// Token: 0x06000A50 RID: 2640 RVA: 0x00021D0B File Offset: 0x0001FF0B
		protected virtual void OnDropTargetInitialize(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00021D14 File Offset: 0x0001FF14
		internal void RaiseDropTargetInitialize(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.DropIndicator.DropTargetInitializeEvent;
			args.Source = this;
			this.OnDropTargetInitialize(args);
			this._wasInitializeEventRaised = true;
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x06000A52 RID: 2642 RVA: 0x00021D36 File Offset: 0x0001FF36
		// (remove) Token: 0x06000A53 RID: 2643 RVA: 0x00021D44 File Offset: 0x0001FF44
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

		// Token: 0x06000A54 RID: 2644 RVA: 0x00021D52 File Offset: 0x0001FF52
		protected virtual void OnDropTargetEnter(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06000A55 RID: 2645 RVA: 0x00021D5B File Offset: 0x0001FF5B
		internal void RaiseDropTargetEnter(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.DropIndicator.DropTargetEnterEvent;
			args.Source = this;
			this.OnDropTargetEnter(args);
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x06000A56 RID: 2646 RVA: 0x00021D76 File Offset: 0x0001FF76
		// (remove) Token: 0x06000A57 RID: 2647 RVA: 0x00021D84 File Offset: 0x0001FF84
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

		// Token: 0x06000A58 RID: 2648 RVA: 0x00021D92 File Offset: 0x0001FF92
		protected virtual void OnDropTargetLeave(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06000A59 RID: 2649 RVA: 0x00021D9B File Offset: 0x0001FF9B
		internal void RaiseDropTargetLeave(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Controls.DropIndicator.DropTargetLeaveEvent;
			args.Source = this;
			this.OnDropTargetLeave(args);
		}

		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06000A5A RID: 2650 RVA: 0x00021DB6 File Offset: 0x0001FFB6
		// (remove) Token: 0x06000A5B RID: 2651 RVA: 0x00021DC4 File Offset: 0x0001FFC4
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

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00021DD2 File Offset: 0x0001FFD2
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x00021DE4 File Offset: 0x0001FFE4
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x06000A5E RID: 2654 RVA: 0x00021DF8 File Offset: 0x0001FFF8
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

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x00021EB6 File Offset: 0x000200B6
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x00021EC8 File Offset: 0x000200C8
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
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

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x00021EDB File Offset: 0x000200DB
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x00021EED File Offset: 0x000200ED
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x00021F00 File Offset: 0x00020100
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Controls.Orientation? Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation?)base.GetValue(global::Infragistics.Windows.Controls.DropIndicator.OrientationProperty);
			}
		}

		// Token: 0x04000415 RID: 1045
		private bool _wasInitializeEventRaised;

		// Token: 0x04000419 RID: 1049
		public static readonly global::System.Windows.DependencyProperty DropLocationProperty;

		// Token: 0x0400041A RID: 1050
		public static readonly global::System.Windows.DependencyProperty DropTargetHeightProperty;

		// Token: 0x0400041B RID: 1051
		public static readonly global::System.Windows.DependencyProperty DropTargetWidthProperty;

		// Token: 0x0400041C RID: 1052
		private static readonly global::System.Windows.DependencyPropertyKey OrientationPropertyKey;

		// Token: 0x0400041D RID: 1053
		public static readonly global::System.Windows.DependencyProperty OrientationProperty;
	}
}
