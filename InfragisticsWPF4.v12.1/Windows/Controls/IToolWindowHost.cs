using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020001D3 RID: 467
	internal interface IToolWindowHost
	{
		// Token: 0x06001134 RID: 4404
		void DragMove(global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x06001135 RID: 4405
		void DragResize(global::Infragistics.Windows.Controls.ToolWindowResizeElementLocation location, global::System.Windows.Input.Cursor cursor, global::System.Windows.Input.MouseEventArgs e);

		// Token: 0x06001136 RID: 4406
		void Activate();

		// Token: 0x06001137 RID: 4407
		void Close();

		// Token: 0x06001138 RID: 4408
		void RelativePositionStateChanged();

		// Token: 0x06001139 RID: 4409
		void BringToFront();

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x0600113A RID: 4410
		bool HandlesDelayedMinMaxRequests { get; }

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x0600113B RID: 4411
		bool IsWindow { get; }

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x0600113C RID: 4412
		bool AllowsTransparency { get; }

		// Token: 0x0600113D RID: 4413
		bool SupportsAllowTransparency(bool allowsTransparency);

		// Token: 0x0600113E RID: 4414
		void EnsureOnScreen(bool fullyInView);

		// Token: 0x0600113F RID: 4415
		global::System.Windows.Rect GetRestoreBounds();

		// Token: 0x06001140 RID: 4416
		void SetRestoreBounds(global::System.Windows.Rect rect);

		// Token: 0x06001141 RID: 4417
		void SetWindowState(global::System.Windows.WindowState newState);

		// Token: 0x06001142 RID: 4418
		global::System.Windows.Rect GetWindowBounds();

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001143 RID: 4419
		bool IsUsingOsNonClientArea { get; }
	}
}
