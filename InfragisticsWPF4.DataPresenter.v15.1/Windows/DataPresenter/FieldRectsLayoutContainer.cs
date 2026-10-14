using System;
using System.Collections.Generic;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200018D RID: 397
	internal class FieldRectsLayoutContainer : global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer
	{
		// Token: 0x0600190A RID: 6410 RVA: 0x00073EFC File Offset: 0x000720FC
		internal FieldRectsLayoutContainer()
		{
			this._positions = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Rect>();
		}

		// Token: 0x17000695 RID: 1685
		internal global::System.Windows.Rect this[global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item]
		{
			get
			{
				global::System.Windows.Rect result;
				if (!this._positions.TryGetValue(item, out result))
				{
					result = default(global::System.Windows.Rect);
				}
				return result;
			}
			set
			{
				this._positions[item] = value;
			}
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00073F45 File Offset: 0x00072145
		internal void Reset(global::System.Windows.Vector nearFixedFieldOffset, global::System.Windows.Vector scrollableFieldOffset, global::System.Windows.Vector farFixedFieldOffset)
		{
			this._positions.Clear();
			this._nearFixedFieldOffset = nearFixedFieldOffset;
			this._scrollableFieldOffset = scrollableFieldOffset;
			this._farFixedFieldOffset = farFixedFieldOffset;
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00073F67 File Offset: 0x00072167
		global::System.Windows.Rect global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer.GetBounds(object containerContext)
		{
			return (global::System.Windows.Rect)containerContext;
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x00073F70 File Offset: 0x00072170
		void global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer.PositionItem(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item, global::System.Windows.Rect rect, object containerContext)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase fieldLayoutItemBase = item as global::Infragistics.Windows.DataPresenter.FieldLayoutItemBase;
			if (fieldLayoutItemBase != null)
			{
				switch (fieldLayoutItemBase.FixedLocation)
				{
				case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.Scrollable:
					rect.Offset(this._scrollableFieldOffset);
					break;
				case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToNearEdge:
					rect.Offset(this._nearFixedFieldOffset);
					break;
				case global::Infragistics.Windows.DataPresenter.FixedFieldLocation.FixedToFarEdge:
					rect.Offset(this._farFixedFieldOffset);
					break;
				}
				this._positions[item] = rect;
			}
		}

		// Token: 0x04000A40 RID: 2624
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Rect> _positions;

		// Token: 0x04000A41 RID: 2625
		private global::System.Windows.Vector _nearFixedFieldOffset;

		// Token: 0x04000A42 RID: 2626
		private global::System.Windows.Vector _scrollableFieldOffset;

		// Token: 0x04000A43 RID: 2627
		private global::System.Windows.Vector _farFixedFieldOffset;
	}
}
