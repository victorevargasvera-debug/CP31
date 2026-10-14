using System;
using System.Windows;

namespace Infragistics.Controls.Layouts.Primitives
{
	// Token: 0x0200003E RID: 62
	public abstract class LayoutManagerBase
	{
		// Token: 0x060002A1 RID: 673 RVA: 0x0000AFA1 File Offset: 0x000091A1
		public LayoutManagerBase()
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000AFAC File Offset: 0x000091AC
		internal static global::System.Windows.Rect GetContainerBoundsHelper(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer container, object containerContext, global::Infragistics.Controls.Layouts.Primitives.LayoutManagerBase lm)
		{
			global::System.Windows.Rect bounds = container.GetBounds(containerContext);
			bool flag = double.IsInfinity(bounds.Width) || double.IsNaN(bounds.Width);
			bool flag2 = double.IsInfinity(bounds.Height) || double.IsNaN(bounds.Height);
			if (flag || flag2)
			{
				global::System.Windows.Size size = lm.CalculatePreferredSize(container, containerContext);
				if (flag)
				{
					bounds.Width = size.Width;
				}
				if (flag2)
				{
					bounds.Height = size.Height;
				}
			}
			return bounds;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000B02F File Offset: 0x0000922F
		internal void InternalOnLayoutChanged()
		{
			this.OnLayoutChanged();
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000B037 File Offset: 0x00009237
		internal void InternalValidateConstraints(object constraint)
		{
			this.ValidateConstraintObject(constraint);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000B040 File Offset: 0x00009240
		protected virtual void OnLayoutChanged()
		{
			this.InvalidateLayout();
		}

		// Token: 0x060002A6 RID: 678
		protected abstract void ValidateConstraintObject(object constraint);

		// Token: 0x060002A7 RID: 679
		public abstract global::System.Windows.Size CalculateMaximumSize(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer container, object containerContext);

		// Token: 0x060002A8 RID: 680
		public abstract global::System.Windows.Size CalculateMinimumSize(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer container, object containerContext);

		// Token: 0x060002A9 RID: 681
		public abstract global::System.Windows.Size CalculatePreferredSize(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer container, object containerContext);

		// Token: 0x060002AA RID: 682 RVA: 0x0000B048 File Offset: 0x00009248
		public virtual void InvalidateLayout()
		{
		}

		// Token: 0x060002AB RID: 683
		public abstract void LayoutContainer(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer container, object containerContext);

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0000B04A File Offset: 0x0000924A
		public global::Infragistics.Controls.Layouts.Primitives.LayoutItemsCollection LayoutItems
		{
			get
			{
				if (this._layoutItems == null)
				{
					this._layoutItems = new global::Infragistics.Controls.Layouts.Primitives.LayoutItemsCollection(this);
				}
				return this._layoutItems;
			}
		}

		// Token: 0x040000A9 RID: 169
		private global::Infragistics.Controls.Layouts.Primitives.LayoutItemsCollection _layoutItems;
	}
}
