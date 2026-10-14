using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000261 RID: 609
	public class CarouselPanelAdorner : global::Infragistics.Windows.Internal.AdornerEx
	{
		// Token: 0x0600192E RID: 6446 RVA: 0x0006189E File Offset: 0x0005FA9E
		internal CarouselPanelAdorner(global::System.Windows.FrameworkElement adornedElement) : base(adornedElement)
		{
		}

		// Token: 0x0600192F RID: 6447 RVA: 0x000618A8 File Offset: 0x0005FAA8
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			for (int i = 0; i < this.Children.Count; i++)
			{
				this.Children[i].Arrange(new global::System.Windows.Rect(new global::System.Windows.Point(0.0, 0.0), finalSize));
			}
			return base.ArrangeOverride(finalSize);
		}

		// Token: 0x06001930 RID: 6448 RVA: 0x00061900 File Offset: 0x0005FB00
		protected override global::System.Windows.Media.Visual GetVisualChild(int index)
		{
			if (index < 0 || index >= this.Children.Count)
			{
				return null;
			}
			return this.Children[index];
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x00061922 File Offset: 0x0005FB22
		protected override int VisualChildrenCount
		{
			get
			{
				return this.Children.Count;
			}
		}

		// Token: 0x06001932 RID: 6450 RVA: 0x0006192F File Offset: 0x0005FB2F
		internal void AddChildElement(global::System.Windows.UIElement childElement)
		{
			base.AddVisualChild(childElement);
			this.Children.Add(childElement);
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00061944 File Offset: 0x0005FB44
		internal void RemoveChildElement(global::System.Windows.UIElement childElement)
		{
			base.RemoveVisualChild(childElement);
			this.Children.Remove(childElement);
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x0006195A File Offset: 0x0005FB5A
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

		// Token: 0x04000CB0 RID: 3248
		private global::System.Collections.Generic.List<global::System.Windows.UIElement> _children;
	}
}
