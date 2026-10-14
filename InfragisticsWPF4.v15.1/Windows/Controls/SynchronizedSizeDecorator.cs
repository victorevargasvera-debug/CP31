using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020001C5 RID: 453
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SynchronizedSizeDecorator : global::System.Windows.Controls.Decorator
	{
		// Token: 0x06000F81 RID: 3969 RVA: 0x00033D10 File Offset: 0x00031F10
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size size = base.MeasureOverride(availableSize);
			this._lastActualDesired = size;
			global::Infragistics.Windows.Controls.SynchronizedSizeDecorator target = this.Target;
			if (target != null && target != this)
			{
				if (!target.IsMeasureValid && !target._isMeasuringTarget)
				{
					try
					{
						this._isMeasuringTarget = true;
						target.Measure(availableSize);
					}
					finally
					{
						this._isMeasuringTarget = false;
					}
				}
				global::System.Windows.Size size2 = target._isMeasuringTarget ? target._lastActualDesired : target.DesiredSize;
				bool flag = false;
				if (this.SynchronizeWidth && !global::Infragistics.CoreUtilities.AreClose(size.Width, size2.Width))
				{
					if (size.Width < size2.Width)
					{
						size.Width = size2.Width;
					}
					else
					{
						flag = true;
					}
				}
				if (this.SynchronizeHeight && !global::Infragistics.CoreUtilities.AreClose(size.Height, size2.Height))
				{
					if (size.Height < size2.Height)
					{
						size.Height = size2.Height;
					}
					else
					{
						flag = true;
					}
				}
				if (flag)
				{
					target.InvalidateMeasure();
				}
			}
			return size;
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00033E1C File Offset: 0x0003201C
		protected override void OnChildDesiredSizeChanged(global::System.Windows.UIElement child)
		{
			global::Infragistics.Windows.Controls.SynchronizedSizeDecorator target = this.Target;
			if (target != null)
			{
				target.InvalidateMeasure();
			}
			base.OnChildDesiredSizeChanged(child);
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000F83 RID: 3971 RVA: 0x00033E40 File Offset: 0x00032040
		// (set) Token: 0x06000F84 RID: 3972 RVA: 0x00033E52 File Offset: 0x00032052
		[global::System.ComponentModel.Bindable(true)]
		public bool SynchronizeHeight
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.SynchronizedSizeDecorator.SynchronizeHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.SynchronizedSizeDecorator.SynchronizeHeightProperty, value);
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x00033E65 File Offset: 0x00032065
		// (set) Token: 0x06000F86 RID: 3974 RVA: 0x00033E77 File Offset: 0x00032077
		[global::System.ComponentModel.Bindable(true)]
		public bool SynchronizeWidth
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Controls.SynchronizedSizeDecorator.SynchronizeWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.SynchronizedSizeDecorator.SynchronizeWidthProperty, value);
			}
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00033E8C File Offset: 0x0003208C
		private static object CoerceTarget(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Controls.SynchronizedSizeDecorator synchronizedSizeDecorator = (global::Infragistics.Windows.Controls.SynchronizedSizeDecorator)d;
			global::Infragistics.Windows.Controls.SynchronizedSizeDecorator synchronizedSizeDecorator2 = (global::Infragistics.Windows.Controls.SynchronizedSizeDecorator)newValue;
			if (newValue != null && (synchronizedSizeDecorator2.IsAncestorOf(synchronizedSizeDecorator) || synchronizedSizeDecorator2.IsDescendantOf(synchronizedSizeDecorator)))
			{
				throw new global::System.InvalidOperationException();
			}
			return newValue;
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000F88 RID: 3976 RVA: 0x00033EC3 File Offset: 0x000320C3
		// (set) Token: 0x06000F89 RID: 3977 RVA: 0x00033ED5 File Offset: 0x000320D5
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.SynchronizedSizeDecorator Target
		{
			get
			{
				return (global::Infragistics.Windows.Controls.SynchronizedSizeDecorator)base.GetValue(global::Infragistics.Windows.Controls.SynchronizedSizeDecorator.TargetProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Controls.SynchronizedSizeDecorator.TargetProperty, value);
			}
		}

		// Token: 0x04000855 RID: 2133
		private bool _isMeasuringTarget;

		// Token: 0x04000856 RID: 2134
		private global::System.Windows.Size _lastActualDesired;

		// Token: 0x04000857 RID: 2135
		public static readonly global::System.Windows.DependencyProperty SynchronizeHeightProperty = global::System.Windows.DependencyProperty.Register("SynchronizeHeight", typeof(bool), typeof(global::Infragistics.Windows.Controls.SynchronizedSizeDecorator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x04000858 RID: 2136
		public static readonly global::System.Windows.DependencyProperty SynchronizeWidthProperty = global::System.Windows.DependencyProperty.Register("SynchronizeWidth", typeof(bool), typeof(global::Infragistics.Windows.Controls.SynchronizedSizeDecorator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x04000859 RID: 2137
		public static readonly global::System.Windows.DependencyProperty TargetProperty = global::System.Windows.DependencyProperty.Register("Target", typeof(global::Infragistics.Windows.Controls.SynchronizedSizeDecorator), typeof(global::Infragistics.Windows.Controls.SynchronizedSizeDecorator), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.SynchronizedSizeDecorator.CoerceTarget)));
	}
}
