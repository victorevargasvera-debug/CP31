using System;

namespace Infragistics.Controls
{
	// Token: 0x020000F4 RID: 244
	internal class StateChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000892 RID: 2194 RVA: 0x0001DF80 File Offset: 0x0001C180
		public StateChangedEventArgs(global::Infragistics.Controls.TouchState newState, global::Infragistics.Controls.TouchState oldState)
		{
			this.NewState = newState;
			this.OldState = oldState;
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x0001DF96 File Offset: 0x0001C196
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x0001DF9E File Offset: 0x0001C19E
		public global::Infragistics.Controls.TouchState NewState { get; private set; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x0001DFA7 File Offset: 0x0001C1A7
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x0001DFAF File Offset: 0x0001C1AF
		public global::Infragistics.Controls.TouchState OldState { get; private set; }
	}
}
