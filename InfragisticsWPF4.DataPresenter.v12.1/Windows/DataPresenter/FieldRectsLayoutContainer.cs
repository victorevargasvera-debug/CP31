using System;
using System.Collections.Generic;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000171 RID: 369
	internal class FieldRectsLayoutContainer : global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer
	{
		// Token: 0x06001588 RID: 5512 RVA: 0x00061DA8 File Offset: 0x0005FFA8
		internal FieldRectsLayoutContainer()
		{
			this._positions = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Rect>();
		}

		// Token: 0x1700054F RID: 1359
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

		// Token: 0x0600158B RID: 5515 RVA: 0x00061DF1 File Offset: 0x0005FFF1
		internal void Reset(global::System.Windows.Vector nearFixedFieldOffset, global::System.Windows.Vector scrollableFieldOffset, global::System.Windows.Vector farFixedFieldOffset)
		{
			this._positions.Clear();
			this._nearFixedFieldOffset = nearFixedFieldOffset;
			this._scrollableFieldOffset = scrollableFieldOffset;
			this._farFixedFieldOffset = farFixedFieldOffset;
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00061E13 File Offset: 0x00060013
		global::System.Windows.Rect global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer.GetBounds(object containerContext)
		{
			return (global::System.Windows.Rect)containerContext;
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x00061E1C File Offset: 0x0006001C
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

		// Token: 0x0400088A RID: 2186
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::System.Windows.Rect> _positions;

		// Token: 0x0400088B RID: 2187
		private global::System.Windows.Vector _nearFixedFieldOffset;

		// Token: 0x0400088C RID: 2188
		private global::System.Windows.Vector _scrollableFieldOffset;

		// Token: 0x0400088D RID: 2189
		private global::System.Windows.Vector _farFixedFieldOffset;
	}
}
