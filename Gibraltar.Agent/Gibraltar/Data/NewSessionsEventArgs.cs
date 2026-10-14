using System;
using Loupe.Extensibility.Data;

namespace Gibraltar.Data
{
	// Token: 0x02000256 RID: 598
	internal class NewSessionsEventArgs : global::System.EventArgs
	{
		// Token: 0x06001E02 RID: 7682 RVA: 0x0006AF6C File Offset: 0x0006916C
		public NewSessionsEventArgs(int newSessions, int warningSessions, int errorSessions, int criticalSessions, global::Loupe.Extensibility.Data.LogMessageSeverity maxSeverity)
		{
			this.NewSessions = newSessions;
			this.WarningSessions = warningSessions;
			this.ErrorSessions = errorSessions;
			this.CriticalSessions = criticalSessions;
			this.MaxSeverity = maxSeverity;
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06001E03 RID: 7683 RVA: 0x0006AFA8 File Offset: 0x000691A8
		// (set) Token: 0x06001E04 RID: 7684 RVA: 0x0006AFB0 File Offset: 0x000691B0
		public int NewSessions { get; private set; }

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x0006AFBC File Offset: 0x000691BC
		// (set) Token: 0x06001E06 RID: 7686 RVA: 0x0006AFC4 File Offset: 0x000691C4
		public int WarningSessions { get; private set; }

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x0006AFD0 File Offset: 0x000691D0
		// (set) Token: 0x06001E08 RID: 7688 RVA: 0x0006AFD8 File Offset: 0x000691D8
		public int ErrorSessions { get; private set; }

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x0006AFE4 File Offset: 0x000691E4
		// (set) Token: 0x06001E0A RID: 7690 RVA: 0x0006AFEC File Offset: 0x000691EC
		public int CriticalSessions { get; private set; }

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x0006AFF8 File Offset: 0x000691F8
		// (set) Token: 0x06001E0C RID: 7692 RVA: 0x0006B000 File Offset: 0x00069200
		public global::Loupe.Extensibility.Data.LogMessageSeverity MaxSeverity { get; private set; }
	}
}
