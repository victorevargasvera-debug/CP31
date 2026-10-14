using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001AA RID: 426
	public class ExitEditingCellEventArgs : global::Infragistics.CancellableEventArgs
	{
		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x0002A31B File Offset: 0x0002851B
		// (set) Token: 0x06000B8B RID: 2955 RVA: 0x0002A323 File Offset: 0x00028523
		public global::Infragistics.Controls.Grids.Cell Cell { get; protected internal set; }

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0002A32C File Offset: 0x0002852C
		// (set) Token: 0x06000B8D RID: 2957 RVA: 0x0002A334 File Offset: 0x00028534
		public object NewValue { get; set; }

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x0002A33D File Offset: 0x0002853D
		// (set) Token: 0x06000B8F RID: 2959 RVA: 0x0002A345 File Offset: 0x00028545
		public bool EditingCanceled { get; protected internal set; }

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x0002A34E File Offset: 0x0002854E
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x0002A356 File Offset: 0x00028556
		public global::System.Windows.FrameworkElement Editor { get; protected internal set; }

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x0002A35F File Offset: 0x0002855F
		// (set) Token: 0x06000B93 RID: 2963 RVA: 0x0002A367 File Offset: 0x00028567
		internal bool PreventEvaluateBindings { get; set; }
	}
}
