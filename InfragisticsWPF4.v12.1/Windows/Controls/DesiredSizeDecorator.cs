using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000113 RID: 275
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class DesiredSizeDecorator : global::System.Windows.Controls.Decorator
	{
		// Token: 0x06000A4A RID: 2634 RVA: 0x00021A70 File Offset: 0x0001FC70
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = base.MeasureOverride(availableSize);
			base.SetValue(global::Infragistics.Windows.Controls.DesiredSizeDecorator.ChildDesiredHeightPropertyKey, result.Height);
			base.SetValue(global::Infragistics.Windows.Controls.DesiredSizeDecorator.ChildDesiredWidthPropertyKey, result.Width);
			return result;
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x00021AB4 File Offset: 0x0001FCB4
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public double ChildDesiredHeight
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.DesiredSizeDecorator.ChildDesiredHeightProperty);
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000A4C RID: 2636 RVA: 0x00021AC6 File Offset: 0x0001FCC6
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public double ChildDesiredWidth
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Controls.DesiredSizeDecorator.ChildDesiredWidthProperty);
			}
		}

		// Token: 0x0400040A RID: 1034
		private static readonly global::System.Windows.DependencyPropertyKey ChildDesiredHeightPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ChildDesiredHeight", typeof(double), typeof(global::Infragistics.Windows.Controls.DesiredSizeDecorator), new global::System.Windows.FrameworkPropertyMetadata(double.NaN));

		// Token: 0x0400040B RID: 1035
		public static readonly global::System.Windows.DependencyProperty ChildDesiredHeightProperty = global::Infragistics.Windows.Controls.DesiredSizeDecorator.ChildDesiredHeightPropertyKey.DependencyProperty;

		// Token: 0x0400040C RID: 1036
		private static readonly global::System.Windows.DependencyPropertyKey ChildDesiredWidthPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ChildDesiredWidth", typeof(double), typeof(global::Infragistics.Windows.Controls.DesiredSizeDecorator), new global::System.Windows.FrameworkPropertyMetadata(double.NaN));

		// Token: 0x0400040D RID: 1037
		public static readonly global::System.Windows.DependencyProperty ChildDesiredWidthProperty = global::Infragistics.Windows.Controls.DesiredSizeDecorator.ChildDesiredWidthPropertyKey.DependencyProperty;
	}
}
