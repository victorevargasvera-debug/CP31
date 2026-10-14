using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000201 RID: 513
	internal interface IToolWindowHost
	{
		// Token: 0x06001305 RID: 4869
		void DragMove(global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x06001306 RID: 4870
		void DragResize(global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation location, global::System.Windows.Input.Cursor cursor, global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x06001307 RID: 4871
		void Activate();

		// Token: 0x06001308 RID: 4872
		void Close();

		// Token: 0x06001309 RID: 4873
		void RelativePositionStateChanged();

		// Token: 0x0600130A RID: 4874
		void BringToFront();

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x0600130B RID: 4875
		bool HandlesDelayedMinMaxRequests { get; }

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x0600130C RID: 4876
		bool IsWindow { get; }

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x0600130D RID: 4877
		bool AllowsTransparency { get; }

		// Token: 0x0600130E RID: 4878
		bool SupportsAllowTransparency(bool allowsTransparency);

		// Token: 0x0600130F RID: 4879
		void EnsureOnScreen(bool fullyInView);

		// Token: 0x06001310 RID: 4880
		global::System.Windows.Rect GetRestoreBounds();

		// Token: 0x06001311 RID: 4881
		void SetRestoreBounds(global::System.Windows.Rect rect);

		// Token: 0x06001312 RID: 4882
		void SetWindowState(global::System.Windows.WindowState newState);

		// Token: 0x06001313 RID: 4883
		global::System.Windows.Rect GetWindowBounds();

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001314 RID: 4884
		bool IsUsingOsNonClientArea { get; }

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001315 RID: 4885
		global::Infragistics.Windows.Controls.ToolWindowHostType HostType { get; }
	}
}
