using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000131 RID: 305
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class DesiredSizeDecorator : global::System.Windows.Controls.Decorator
	{
		// Token: 0x06000B49 RID: 2889 RVA: 0x00025638 File Offset: 0x00023838
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = base.MeasureOverride(availableSize);
			base.SetValue(global::Infragistics.Windows.Controls.DesiredSizeDecorator.ChildDesiredHeightPropertyKey, result.Height);
			base.SetValue(global::Infragistics.Windows.Controls.DesiredSizeDecorator.ChildDesiredWidthPropertyKey, result.Width);
			return result;
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000B4A RID: 2890 RVA: 0x0002567C File Offset: 0x0002387C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public double ChildDesiredHeight
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.DesiredSizeDecorator.ChildDesiredHeightProperty);
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x0002568E File Offset: 0x0002388E
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public double ChildDesiredWidth
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.DesiredSizeDecorator.ChildDesiredWidthProperty);
			}
		}

		// Token: 0x040004BD RID: 1213
		private static readonly global::System.Windows.DependencyPropertyKey ChildDesiredHeightPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ChildDesiredHeight", typeof(double), typeof(global::Infragistics.Windows.Controls.DesiredSizeDecorator), new global::System.Windows.FrameworkPropertyMetadata(double.NaN));

		// Token: 0x040004BE RID: 1214
		public static readonly global::System.Windows.DependencyProperty ChildDesiredHeightProperty = global::Infragistics.Windows.Controls.DesiredSizeDecorator.ChildDesiredHeightPropertyKey.DependencyProperty;

		// Token: 0x040004BF RID: 1215
		private static readonly global::System.Windows.DependencyPropertyKey ChildDesiredWidthPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ChildDesiredWidth", typeof(double), typeof(global::Infragistics.Windows.Controls.DesiredSizeDecorator), new global::System.Windows.FrameworkPropertyMetadata(double.NaN));

		// Token: 0x040004C0 RID: 1216
		public static readonly global::System.Windows.DependencyProperty ChildDesiredWidthProperty = global::Infragistics.Windows.Controls.DesiredSizeDecorator.ChildDesiredWidthPropertyKey.DependencyProperty;
	}
}
