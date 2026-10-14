using System;
using System.Windows;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x020001AC RID: 428
	public abstract class StyleSelectorHelperBase
	{
		// Token: 0x06000E67 RID: 3687 RVA: 0x0002E313 File Offset: 0x0002C513
		protected StyleSelectorHelperBase(global::System.Windows.DependencyObject target)
		{
			this._target = target;
			if (!(target is global::System.Windows.FrameworkContentElement) && !(target is global::System.Windows.FrameworkElement))
			{
				throw new global::System.NotSupportedException(global::SR.GetString("LE_NotSupportedException_3"));
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000E68 RID: 3688
		public abstract global::System.Windows.Style Style { get; }

		// Token: 0x06000E69 RID: 3689 RVA: 0x0002E344 File Offset: 0x0002C544
		public void InvalidateStyle()
		{
			global::System.Windows.Style style = this.Style;
			global::System.Windows.FrameworkContentElement frameworkContentElement = this._target as global::System.Windows.FrameworkContentElement;
			global::System.Windows.FrameworkElement frameworkElement = this._target as global::System.Windows.FrameworkElement;
			if (style == null)
			{
				if (frameworkElement != null)
				{
					frameworkElement.ClearValue(global::System.Windows.FrameworkElement.StyleProperty);
					return;
				}
				frameworkContentElement.ClearValue(global::System.Windows.FrameworkContentElement.StyleProperty);
				return;
			}
			else
			{
				if (frameworkElement != null)
				{
					frameworkElement.Style = style;
					return;
				}
				frameworkContentElement.Style = style;
				return;
			}
		}

		// Token: 0x040007ED RID: 2029
		private global::System.Windows.DependencyObject _target;
	}
}
