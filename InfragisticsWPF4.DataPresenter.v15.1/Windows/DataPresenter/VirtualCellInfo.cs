using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200023A RID: 570
	internal class VirtualCellInfo
	{
		// Token: 0x0600213D RID: 8509 RVA: 0x000944B7 File Offset: 0x000926B7
		internal VirtualCellInfo(global::System.Windows.Rect clipRect, global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.FixedFieldLocation fixedLocation, global::System.Windows.FrameworkElement element, global::System.Windows.Rect elementRect)
		{
			this.ClipRect = clipRect;
			this.Field = field;
			this.FixedLocation = fixedLocation;
			this.Element = element;
			this.ElementRect = elementRect;
		}

		// Token: 0x04000E1B RID: 3611
		internal readonly global::Infragistics.Windows.DataPresenter.Field Field;

		// Token: 0x04000E1C RID: 3612
		internal readonly global::Infragistics.Windows.DataPresenter.FixedFieldLocation FixedLocation;

		// Token: 0x04000E1D RID: 3613
		internal readonly global::System.Windows.Rect ClipRect;

		// Token: 0x04000E1E RID: 3614
		internal readonly global::System.Windows.FrameworkElement Element;

		// Token: 0x04000E1F RID: 3615
		internal readonly global::System.Windows.Rect ElementRect;
	}
}
