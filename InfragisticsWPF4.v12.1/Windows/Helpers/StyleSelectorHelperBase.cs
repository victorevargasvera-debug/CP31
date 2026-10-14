using System;
using System.Windows;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x02000187 RID: 391
	public abstract class StyleSelectorHelperBase
	{
		// Token: 0x06000D1D RID: 3357 RVA: 0x00029C1F File Offset: 0x00027E1F
		protected StyleSelectorHelperBase(global::System.Windows.DependencyObject target)
		{
			this._target = target;
			if (!(target is global::System.Windows.FrameworkContentElement) && !(target is global::System.Windows.FrameworkElement))
			{
				throw new global::System.NotSupportedException(global::SR.GetString("LE_NotSupportedException_3"));
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000D1E RID: 3358
		public abstract global::System.Windows.Style Style { get; }

		// Token: 0x06000D1F RID: 3359 RVA: 0x00029C50 File Offset: 0x00027E50
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

		// Token: 0x040006C7 RID: 1735
		private global::System.Windows.DependencyObject _target;
	}
}
