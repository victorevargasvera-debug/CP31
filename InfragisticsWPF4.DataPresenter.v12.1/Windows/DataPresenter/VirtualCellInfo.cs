using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000206 RID: 518
	internal class VirtualCellInfo
	{
		// Token: 0x06001CBE RID: 7358 RVA: 0x0007DF2B File Offset: 0x0007C12B
		internal VirtualCellInfo(global::System.Windows.Rect clipRect, global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedLocation, global::System.Windows.FrameworkElement element, global::System.Windows.Rect elementRect)
		{
			this.ClipRect = clipRect;
			this.Field = field;
			this.FixedLocation = fixedLocation;
			this.Element = element;
			this.ElementRect = elementRect;
		}

		// Token: 0x04000BFE RID: 3070
		internal readonly global::Infragistics.Windows.DataPresenter.Field Field;

		// Token: 0x04000BFF RID: 3071
		internal readonly global::Infragistics.Windows.DataPresenter.FixedFieldLocation FixedLocation;

		// Token: 0x04000C00 RID: 3072
		internal readonly global::System.Windows.Rect ClipRect;

		// Token: 0x04000C01 RID: 3073
		internal readonly global::System.Windows.FrameworkElement Element;

		// Token: 0x04000C02 RID: 3074
		internal readonly global::System.Windows.Rect ElementRect;
	}
}
