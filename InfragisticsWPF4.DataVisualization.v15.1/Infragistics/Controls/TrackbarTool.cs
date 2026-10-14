using System;
using System.Windows.Input;

namespace Infragistics.Controls
{
	// Token: 0x02000029 RID: 41
	public class TrackbarTool : global::Infragistics.Tool
	{
		// Token: 0x06000222 RID: 546 RVA: 0x0000A630 File Offset: 0x00008830
		public TrackbarTool(global::Infragistics.InteractiveControl view) : base(view)
		{
			this.zoombar = (view as global::Infragistics.Controls.XamZoombar);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000A648 File Offset: 0x00008848
		public override bool CanStart(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Infragistics.InteractiveElement interactiveElement = base.View.HitTest(base.View.LastInput.DocMousePosition);
			return interactiveElement is global::Infragistics.Controls.TrackShape;
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000A680 File Offset: 0x00008880
		public override void Start()
		{
			base.Start();
			double newValue = this.zoombar.CalculateValue(base.LastInput.DocMousePosition);
			this.zoombar.MoveTo(newValue, false);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000A6B7 File Offset: 0x000088B7
		public override void MouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.MouseLeftButtonUp(e);
			base.StopTool();
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000A6C6 File Offset: 0x000088C6
		public override void Stop()
		{
			this.zoombar.StopMove();
			base.Stop();
		}

		// Token: 0x040000A3 RID: 163
		private global::Infragistics.Controls.XamZoombar zoombar;
	}
}
