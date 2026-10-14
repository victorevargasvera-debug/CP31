using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200022C RID: 556
	public class CarouselPanelAdorner : global::Infragistics.Windows.Internal.AdornerEx
	{
		// Token: 0x0600172C RID: 5932 RVA: 0x0005AE24 File Offset: 0x00059024
		internal CarouselPanelAdorner(global::System.Windows.FrameworkElement adornedElement) : base(adornedElement)
		{
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x0005AE30 File Offset: 0x00059030
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			for (int i = 0; i < this.Children.Count; i++)
			{
				this.Children[i].Arrange(new global::System.Windows.Rect(new global::System.Windows.Point(0.0, 0.0), finalSize));
			}
			return base.ArrangeOverride(finalSize);
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x0005AE88 File Offset: 0x00059088
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (index < 0 || index >= this.Children.Count)
			{
				return null;
			}
			return this.Children[index];
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x0005AEAA File Offset: 0x000590AA
		protected override int VisualChildrenCount
		{
			get
			{
				return this.Children.Count;
			}
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x0005AEB7 File Offset: 0x000590B7
		internal void AddChildElement(global::System.Windows.UIElement childElement)
		{
			base.AddVisualChild(childElement);
			this.Children.Add(childElement);
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x0005AECC File Offset: 0x000590CC
		internal void RemoveChildElement(global::System.Windows.UIElement childElement)
		{
			base.RemoveVisualChild(childElement);
			this.Children.Remove(childElement);
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x0005AEE2 File Offset: 0x000590E2
		private global::System.Collections.Generic.List<global::System.Windows.UIElement> Children
		{
			get
			{
				if (this._children == null)
				{
					this._children = new global::System.Collections.Generic.List<global::System.Windows.UIElement>(3);
				}
				return this._children;
			}
		}

		// Token: 0x04000B4D RID: 2893
		private global::System.Collections.Generic.List<global::System.Windows.UIElement> _children;
	}
}
