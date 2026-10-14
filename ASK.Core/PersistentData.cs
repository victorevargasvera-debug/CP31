using System;
using Motorola.CommonCPS.ResourceRepository;

namespace ASK.Core
{
	// Token: 0x02000026 RID: 38
	[global::System.Serializable]
	public class PersistentData
	{
		// Token: 0x06000172 RID: 370 RVA: 0x00029F40 File Offset: 0x00028140
		internal PersistentData()
		{
			this.RadioWideACLRecSet = new global::ASK.Core.AccessLevelDataRecordSet(global::Motorola.CommonCPS.ResourceRepository.Resources.Radio_Wide_Test);
			this.SystemWideACLRecSet = new global::ASK.Core.AccessLevelDataRecordSet(global::Motorola.CommonCPS.ResourceRepository.Resources.System_Wide_Test);
			this.ConvSystemACLRecSet = new global::ASK.Core.AccessLevelDataRecordSet(global::Motorola.CommonCPS.ResourceRepository.Resources.Conventional_System_Test);
		}

		// Token: 0x040000D0 RID: 208
		public global::ASK.Core.AccessLevelDataRecordSet RadioWideACLRecSet;

		// Token: 0x040000D1 RID: 209
		public global::ASK.Core.AccessLevelDataRecordSet SystemWideACLRecSet;

		// Token: 0x040000D2 RID: 210
		public global::ASK.Core.AccessLevelDataRecordSet ConvSystemACLRecSet;
	}
}
