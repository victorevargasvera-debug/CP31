using System;

namespace NLog.Config
{
	// Token: 0x02000166 RID: 358
	public class LoggingConfigurationChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000FB9 RID: 4025 RVA: 0x00028BEF File Offset: 0x00026DEF
		public LoggingConfigurationChangedEventArgs(global::NLog.Config.LoggingConfiguration activatedConfiguration, global::NLog.Config.LoggingConfiguration deactivatedConfiguration)
		{
			this.ActivatedConfiguration = activatedConfiguration;
			this.DeactivatedConfiguration = deactivatedConfiguration;
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x00028C05 File Offset: 0x00026E05
		// (set) Token: 0x06000FBB RID: 4027 RVA: 0x00028C0D File Offset: 0x00026E0D
		public global::NLog.Config.LoggingConfiguration DeactivatedConfiguration { get; private set; }

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x00028C16 File Offset: 0x00026E16
		// (set) Token: 0x06000FBD RID: 4029 RVA: 0x00028C1E File Offset: 0x00026E1E
		public global::NLog.Config.LoggingConfiguration ActivatedConfiguration { get; private set; }

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000FBE RID: 4030 RVA: 0x00028C27 File Offset: 0x00026E27
		[global::System.Obsolete("This option will be removed in NLog 5. Marked obsolete on NLog 4.5")]
		public global::NLog.Config.LoggingConfiguration OldConfiguration
		{
			get
			{
				return this.ActivatedConfiguration;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000FBF RID: 4031 RVA: 0x00028C2F File Offset: 0x00026E2F
		[global::System.Obsolete("This option will be removed in NLog 5. Marked obsolete on NLog 4.5")]
		public global::NLog.Config.LoggingConfiguration NewConfiguration
		{
			get
			{
				return this.DeactivatedConfiguration;
			}
		}
	}
}
