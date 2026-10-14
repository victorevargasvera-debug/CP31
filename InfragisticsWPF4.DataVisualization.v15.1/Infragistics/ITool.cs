using System;
using System.Windows.Input;

namespace Infragistics
{
	// Token: 0x0200001B RID: 27
	public interface ITool
	{
		// Token: 0x06000183 RID: 387
		bool CanStart();

		// Token: 0x06000184 RID: 388
		bool CanStart(global::System.Windows.Input.MouseButtonEventArgs e);

		// Token: 0x06000185 RID: 389
		void Start();

		// Token: 0x06000186 RID: 390
		void KeyDown();

		// Token: 0x06000187 RID: 391
		void KeyUp();

		// Token: 0x06000188 RID: 392
		void MouseMove();

		// Token: 0x06000189 RID: 393
		void MouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e);

		// Token: 0x0600018A RID: 394
		void MouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e);

		// Token: 0x0600018B RID: 395
		void OnMouseLeftButtonDoubleClick();

		// Token: 0x0600018C RID: 396
		void Stop();
	}
}
