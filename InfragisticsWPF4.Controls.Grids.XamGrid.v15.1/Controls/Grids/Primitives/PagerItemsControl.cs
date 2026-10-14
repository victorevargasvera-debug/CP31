using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000110 RID: 272
	public class PagerItemsControl : global::System.Windows.Controls.ListBox
	{
		// Token: 0x0600093A RID: 2362 RVA: 0x00024CB5 File Offset: 0x00022EB5
		static PagerItemsControl()
		{
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.PagerItemsControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00024CDD File Offset: 0x00022EDD
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			return new global::Infragistics.Controls.Grids.Primitives.PagerItem();
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00024CE4 File Offset: 0x00022EE4
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			if (e.OriginalSource == this && global::System.Windows.Input.Mouse.Captured == this)
			{
				base.ReleaseMouseCapture();
			}
		}
	}
}
