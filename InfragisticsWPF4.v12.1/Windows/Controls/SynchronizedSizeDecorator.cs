using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200019D RID: 413
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class SynchronizedSizeDecorator : global::System.Windows.Controls.Decorator
	{
		// Token: 0x06000E2A RID: 3626 RVA: 0x0002F300 File Offset: 0x0002D500
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

		// Token: 0x06000E2B RID: 3627 RVA: 0x0002F40C File Offset: 0x0002D60C
		protected override void OnChildDesiredSizeChanged(global::System.Windows.UIElement child)
		{
			global::Infragistics.Windows.Controls.SynchronizedSizeDecorator target = this.Target;
			if (target != null)
			{
				target.InvalidateMeasure();
			}
			base.OnChildDesiredSizeChanged(child);
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000E2C RID: 3628 RVA: 0x0002F430 File Offset: 0x0002D630
		// (set) Token: 0x06000E2D RID: 3629 RVA: 0x0002F442 File Offset: 0x0002D642
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

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x0002F455 File Offset: 0x0002D655
		// (set) Token: 0x06000E2F RID: 3631 RVA: 0x0002F467 File Offset: 0x0002D667
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

		// Token: 0x06000E30 RID: 3632 RVA: 0x0002F47C File Offset: 0x0002D67C
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

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x0002F4B3 File Offset: 0x0002D6B3
		// (set) Token: 0x06000E32 RID: 3634 RVA: 0x0002F4C5 File Offset: 0x0002D6C5
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

		// Token: 0x04000729 RID: 1833
		private bool _isMeasuringTarget;

		// Token: 0x0400072A RID: 1834
		private global::System.Windows.Size _lastActualDesired;

		// Token: 0x0400072B RID: 1835
		public static readonly global::System.Windows.DependencyProperty SynchronizeHeightProperty = global::System.Windows.DependencyProperty.Register("SynchronizeHeight", typeof(bool), typeof(global::Infragistics.Windows.Controls.SynchronizedSizeDecorator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x0400072C RID: 1836
		public static readonly global::System.Windows.DependencyProperty SynchronizeWidthProperty = global::System.Windows.DependencyProperty.Register("SynchronizeWidth", typeof(bool), typeof(global::Infragistics.Windows.Controls.SynchronizedSizeDecorator), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure));

		// Token: 0x0400072D RID: 1837
		public static readonly global::System.Windows.DependencyProperty TargetProperty = global::System.Windows.DependencyProperty.Register("Target", typeof(global::Infragistics.Windows.Controls.SynchronizedSizeDecorator), typeof(global::Infragistics.Windows.Controls.SynchronizedSizeDecorator), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsMeasure, null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Controls.SynchronizedSizeDecorator.CoerceTarget)));
	}
}
