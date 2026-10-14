using System;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;

namespace Microsoft.Expression.Interactivity.Layout
{
	// Token: 0x0200001D RID: 29
	public class AdornerContainer : global::System.Windows.Documents.Adorner
	{
		// Token: 0x06000114 RID: 276 RVA: 0x000075B3 File Offset: 0x000057B3
		public AdornerContainer(global::System.Windows.UIElement adornedElement) : base(adornedElement)
		{
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000075BC File Offset: 0x000057BC
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			if (this.child != null)
			{
				this.child.Arrange(new global::System.Windows.Rect(finalSize));
			}
			return finalSize;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000116 RID: 278 RVA: 0x000075D8 File Offset: 0x000057D8
		// (set) Token: 0x06000117 RID: 279 RVA: 0x000075E0 File Offset: 0x000057E0
		public global::System.Windows.UIElement Child
		{
			get
			{
				return this.child;
			}
			set
			{
				base.AddVisualChild(value);
				this.child = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000118 RID: 280 RVA: 0x000075F0 File Offset: 0x000057F0
		protected override int VisualChildrenCount
		{
			get
			{
				if (this.child != null)
				{
					return 1;
				}
				return 0;
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000075FD File Offset: 0x000057FD
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (index == 0 && this.child != null)
			{
				return this.child;
			}
			return base.GetVisualChild(index);
		}

		// Token: 0x0400005E RID: 94
		private global::System.Windows.UIElement child;
	}
}
