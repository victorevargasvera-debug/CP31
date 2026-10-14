using System;

namespace Infragistics.Controls
{
	// Token: 0x020000D6 RID: 214
	internal class StateChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000793 RID: 1939 RVA: 0x0001A3D4 File Offset: 0x000185D4
		public StateChangedEventArgs(global::Infragistics.Controls.TouchState newState, global::Infragistics.Controls.TouchState oldState)
		{
			this.NewState = newState;
			this.OldState = oldState;
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x0001A3EA File Offset: 0x000185EA
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x0001A3F2 File Offset: 0x000185F2
		public global::Infragistics.Controls.TouchState NewState { get; private set; }

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x0001A3FB File Offset: 0x000185FB
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x0001A403 File Offset: 0x00018603
		public global::Infragistics.Controls.TouchState OldState { get; private set; }
	}
}
