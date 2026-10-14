using System;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x0200002C RID: 44
	public class LoadModuleCompletedEventArgs : global::System.EventArgs
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x0000471A File Offset: 0x0000291A
		public LoadModuleCompletedEventArgs(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo, global::System.Exception error)
		{
			if (moduleInfo == null)
			{
				throw new global::System.ArgumentNullException("moduleInfo");
			}
			this.ModuleInfo = moduleInfo;
			this.Error = error;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000473E File Offset: 0x0000293E
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00004746 File Offset: 0x00002946
		public global::Microsoft.Practices.Prism.Modularity.ModuleInfo ModuleInfo { get; private set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000474F File Offset: 0x0000294F
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00004757 File Offset: 0x00002957
		public global::System.Exception Error { get; private set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00004760 File Offset: 0x00002960
		// (set) Token: 0x060000EC RID: 236 RVA: 0x00004768 File Offset: 0x00002968
		public bool IsErrorHandled { get; set; }
	}
}
