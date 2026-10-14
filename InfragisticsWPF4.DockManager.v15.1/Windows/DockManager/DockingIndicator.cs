using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000020 RID: 32
	[global::System.Windows.TemplatePart(Name = "PART_DockTop", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplatePart(Name = "PART_DockRight", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_DockCenter", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_DockBottom", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_DockLeft", Type = typeof(global::System.Windows.FrameworkElement))]
	public class DockingIndicator : global::System.Windows.Controls.Control
	{
		// Token: 0x060001A6 RID: 422 RVA: 0x000082F8 File Offset: 0x000064F8
		static DockingIndicator()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.DockingIndicator), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DockManager.DockingIndicator)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.DockingIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DockManager.DockingIndicator), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.DockingIndicator.OnIsEnabledChanged)));
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00008552 File Offset: 0x00006752
		private static object CoerceCanDockBottom(global::System.Windows.DependencyObject d, object newValue)
		{
			return global::Infragistics.Windows.DockManager.DockingIndicator.CoerceCanDockHelper(d, newValue, global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Bottom);
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000855C File Offset: 0x0000675C
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool CanDockBottom
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockBottomProperty);
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000856E File Offset: 0x0000676E
		private static object CoerceCanDockTop(global::System.Windows.DependencyObject d, object newValue)
		{
			return global::Infragistics.Windows.DockManager.DockingIndicator.CoerceCanDockHelper(d, newValue, global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Top);
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00008578 File Offset: 0x00006778
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool CanDockTop
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockTopProperty);
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000858A File Offset: 0x0000678A
		private static object CoerceCanDockLeft(global::System.Windows.DependencyObject d, object newValue)
		{
			return global::Infragistics.Windows.DockManager.DockingIndicator.CoerceCanDockHelper(d, newValue, global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Left);
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00008594 File Offset: 0x00006794
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool CanDockLeft
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockLeftProperty);
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000085A6 File Offset: 0x000067A6
		private static object CoerceCanDockRight(global::System.Windows.DependencyObject d, object newValue)
		{
			return global::Infragistics.Windows.DockManager.DockingIndicator.CoerceCanDockHelper(d, newValue, global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Right);
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001AF RID: 431 RVA: 0x000085B0 File Offset: 0x000067B0
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool CanDockRight
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockRightProperty);
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000085C2 File Offset: 0x000067C2
		private static object CoerceCanDockCenter(global::System.Windows.DependencyObject d, object newValue)
		{
			return global::Infragistics.Windows.DockManager.DockingIndicator.CoerceCanDockHelper(d, newValue, global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Center);
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x000085CC File Offset: 0x000067CC
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool CanDockCenter
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockCenterProperty);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x000085DE File Offset: 0x000067DE
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::Infragistics.Windows.DockManager.DockingIndicatorPosition>))]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.DockingIndicatorPosition? HotTrackPosition
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.DockingIndicatorPosition?)base.GetValue(global::Infragistics.Windows.DockManager.DockingIndicator.HotTrackPositionProperty);
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x000085F0 File Offset: 0x000067F0
		private static void OnPositionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockBottomProperty);
			d.CoerceValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockRightProperty);
			d.CoerceValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockTopProperty);
			d.CoerceValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockLeftProperty);
			d.CoerceValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockCenterProperty);
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00008629 File Offset: 0x00006829
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x0000863B File Offset: 0x0000683B
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DockManager.DockingIndicatorPosition Position
		{
			get
			{
				return (global::Infragistics.Windows.DockManager.DockingIndicatorPosition)base.GetValue(global::Infragistics.Windows.DockManager.DockingIndicator.PositionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DockManager.DockingIndicator.PositionProperty, value);
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00008650 File Offset: 0x00006850
		private static object CoerceCanDockHelper(global::System.Windows.DependencyObject d, object newValue, global::Infragistics.Windows.DockManager.DockingIndicatorPosition otherPosition)
		{
			if (false.Equals(newValue))
			{
				return newValue;
			}
			global::Infragistics.Windows.DockManager.DockingIndicatorPosition dockingIndicatorPosition = (global::Infragistics.Windows.DockManager.DockingIndicatorPosition)d.GetValue(global::Infragistics.Windows.DockManager.DockingIndicator.PositionProperty);
			if ((dockingIndicatorPosition == global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Center || dockingIndicatorPosition == otherPosition) && true.Equals(d.GetValue(global::System.Windows.UIElement.IsEnabledProperty)))
			{
				return newValue;
			}
			return global::Infragistics.KnownBoxes.FalseBox;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x000086A0 File Offset: 0x000068A0
		internal global::Infragistics.Windows.DockManager.DockingIndicatorPosition? GetPosition(global::System.Windows.Point point)
		{
			global::System.Windows.IInputElement inputElement = base.InputHitTest(point);
			if (inputElement != null)
			{
				global::Infragistics.Windows.DockManager.DockingIndicatorPosition position = this.Position;
				if (position != global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Center)
				{
					return new global::Infragistics.Windows.DockManager.DockingIndicatorPosition?(this.Position);
				}
				for (global::System.Windows.DependencyObject dependencyObject = inputElement as global::System.Windows.DependencyObject; dependencyObject != null; dependencyObject = global::Infragistics.Windows.Utilities.GetParent(dependencyObject))
				{
					string text = dependencyObject.GetValue(global::System.Windows.FrameworkElement.NameProperty) as string;
					string a;
					if (text != null && text.StartsWith("PART_Dock") && (a = text) != null)
					{
						if (a == "PART_DockLeft")
						{
							return new global::Infragistics.Windows.DockManager.DockingIndicatorPosition?(global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Left);
						}
						if (a == "PART_DockRight")
						{
							return new global::Infragistics.Windows.DockManager.DockingIndicatorPosition?(global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Right);
						}
						if (a == "PART_DockTop")
						{
							return new global::Infragistics.Windows.DockManager.DockingIndicatorPosition?(global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Top);
						}
						if (a == "PART_DockBottom")
						{
							return new global::Infragistics.Windows.DockManager.DockingIndicatorPosition?(global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Bottom);
						}
						if (a == "PART_DockCenter")
						{
							return new global::Infragistics.Windows.DockManager.DockingIndicatorPosition?(global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Center);
						}
					}
				}
			}
			return null;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00008787 File Offset: 0x00006987
		private static void OnIsEnabledChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockBottomProperty);
			d.CoerceValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockLeftProperty);
			d.CoerceValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockRightProperty);
			d.CoerceValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockTopProperty);
			d.CoerceValue(global::Infragistics.Windows.DockManager.DockingIndicator.CanDockCenterProperty);
		}

		// Token: 0x04000091 RID: 145
		internal static readonly global::System.Windows.DependencyPropertyKey CanDockBottomPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CanDockBottom", typeof(bool), typeof(global::Infragistics.Windows.DockManager.DockingIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.DockingIndicator.CoerceCanDockBottom)));

		// Token: 0x04000092 RID: 146
		public static readonly global::System.Windows.DependencyProperty CanDockBottomProperty = global::Infragistics.Windows.DockManager.DockingIndicator.CanDockBottomPropertyKey.DependencyProperty;

		// Token: 0x04000093 RID: 147
		internal static readonly global::System.Windows.DependencyPropertyKey CanDockTopPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CanDockTop", typeof(bool), typeof(global::Infragistics.Windows.DockManager.DockingIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.DockingIndicator.CoerceCanDockTop)));

		// Token: 0x04000094 RID: 148
		public static readonly global::System.Windows.DependencyProperty CanDockTopProperty = global::Infragistics.Windows.DockManager.DockingIndicator.CanDockTopPropertyKey.DependencyProperty;

		// Token: 0x04000095 RID: 149
		internal static readonly global::System.Windows.DependencyPropertyKey CanDockLeftPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CanDockLeft", typeof(bool), typeof(global::Infragistics.Windows.DockManager.DockingIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.DockingIndicator.CoerceCanDockLeft)));

		// Token: 0x04000096 RID: 150
		public static readonly global::System.Windows.DependencyProperty CanDockLeftProperty = global::Infragistics.Windows.DockManager.DockingIndicator.CanDockLeftPropertyKey.DependencyProperty;

		// Token: 0x04000097 RID: 151
		internal static readonly global::System.Windows.DependencyPropertyKey CanDockRightPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CanDockRight", typeof(bool), typeof(global::Infragistics.Windows.DockManager.DockingIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.DockingIndicator.CoerceCanDockRight)));

		// Token: 0x04000098 RID: 152
		public static readonly global::System.Windows.DependencyProperty CanDockRightProperty = global::Infragistics.Windows.DockManager.DockingIndicator.CanDockRightPropertyKey.DependencyProperty;

		// Token: 0x04000099 RID: 153
		internal static readonly global::System.Windows.DependencyPropertyKey CanDockCenterPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CanDockCenter", typeof(bool), typeof(global::Infragistics.Windows.DockManager.DockingIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DockManager.DockingIndicator.CoerceCanDockCenter)));

		// Token: 0x0400009A RID: 154
		public static readonly global::System.Windows.DependencyProperty CanDockCenterProperty = global::Infragistics.Windows.DockManager.DockingIndicator.CanDockCenterPropertyKey.DependencyProperty;

		// Token: 0x0400009B RID: 155
		internal static readonly global::System.Windows.DependencyPropertyKey HotTrackPositionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HotTrackPosition", typeof(global::Infragistics.Windows.DockManager.DockingIndicatorPosition?), typeof(global::Infragistics.Windows.DockManager.DockingIndicator), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400009C RID: 156
		public static readonly global::System.Windows.DependencyProperty HotTrackPositionProperty = global::Infragistics.Windows.DockManager.DockingIndicator.HotTrackPositionPropertyKey.DependencyProperty;

		// Token: 0x0400009D RID: 157
		public static readonly global::System.Windows.DependencyProperty PositionProperty = global::System.Windows.DependencyProperty.Register("Position", typeof(global::Infragistics.Windows.DockManager.DockingIndicatorPosition), typeof(global::Infragistics.Windows.DockManager.DockingIndicator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DockManager.DockingIndicatorPosition.Center, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DockManager.DockingIndicator.OnPositionChanged)));
	}
}
