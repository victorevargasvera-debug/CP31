using System;
using System.Windows;

namespace Infragistics.Controls.Layouts.Primitives
{
	// Token: 0x02000052 RID: 82
	public abstract class LayoutManagerBase
	{
		// Token: 0x06000332 RID: 818 RVA: 0x0000CA2D File Offset: 0x0000AC2D
		public LayoutManagerBase()
		{
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000CA38 File Offset: 0x0000AC38
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

		// Token: 0x06000334 RID: 820 RVA: 0x0000CABB File Offset: 0x0000ACBB
		internal void InternalOnLayoutChanged()
		{
			this.OnLayoutChanged();
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000CAC3 File Offset: 0x0000ACC3
		internal void InternalValidateConstraints(object constraint)
		{
			this.ValidateConstraintObject(constraint);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000CACC File Offset: 0x0000ACCC
		protected virtual void OnLayoutChanged()
		{
			this.InvalidateLayout();
		}

		// Token: 0x06000337 RID: 823
		protected abstract void ValidateConstraintObject(object constraint);

		// Token: 0x06000338 RID: 824
		public abstract global::System.Windows.Size CalculateMaximumSize(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer container, object containerContext);

		// Token: 0x06000339 RID: 825
		public abstract global::System.Windows.Size CalculateMinimumSize(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer container, object containerContext);

		// Token: 0x0600033A RID: 826
		public abstract global::System.Windows.Size CalculatePreferredSize(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer container, object containerContext);

		// Token: 0x0600033B RID: 827 RVA: 0x0000CAD4 File Offset: 0x0000ACD4
		public virtual void InvalidateLayout()
		{
		}

		// Token: 0x0600033C RID: 828
		public abstract void LayoutContainer(global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer container, object containerContext);

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0000CAD6 File Offset: 0x0000ACD6
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

		// Token: 0x04000104 RID: 260
		private global::Infragistics.Controls.Layouts.Primitives.LayoutItemsCollection _layoutItems;
	}
}
