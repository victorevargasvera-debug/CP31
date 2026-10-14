using System;
using System.Windows;

namespace Infragistics.Controls
{
	// Token: 0x02000055 RID: 85
	public interface IOverviewPlusDetailControl
	{
		// Token: 0x0600045D RID: 1117
		void ZoomTo100();

		// Token: 0x0600045E RID: 1118
		void ScaleToFit();

		// Token: 0x0600045F RID: 1119
		void RenderPreview();

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000460 RID: 1120
		global::System.Windows.Rect WorldRect { get; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000461 RID: 1121
		global::System.Windows.Rect ViewportRect { get; }

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000462 RID: 1122
		double MinimumZoomLevel { get; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000463 RID: 1123
		double MaximumZoomLevel { get; }

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000464 RID: 1124
		string ZoomLevelDisplayText { get; }

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000465 RID: 1125
		// (set) Token: 0x06000466 RID: 1126
		global::Infragistics.Controls.InteractionState DefaultInteraction { get; set; }
	}
}
