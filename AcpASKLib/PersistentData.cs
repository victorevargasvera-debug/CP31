using System;
using AcpCommonResources;

namespace AcpASKLib
{
	// Token: 0x02000033 RID: 51
	[global::System.Serializable]
	public class PersistentData
	{
		// Token: 0x0600016F RID: 367 RVA: 0x000284C0 File Offset: 0x000266C0
		internal PersistentData()
		{
			this.RadioWideACLRecSet = new global::AcpASKLib.AccessLevelDataRecordSet(global::AcpCommonResources.AcpResources.Radio_Wide_Test);
			this.SystemWideACLRecSet = new global::AcpASKLib.AccessLevelDataRecordSet(global::AcpCommonResources.AcpResources.System_Wide_Test);
			this.ConvSystemACLRecSet = new global::AcpASKLib.AccessLevelDataRecordSet(global::AcpCommonResources.AcpResources.Conventional_System_Test);
		}

		// Token: 0x040001B7 RID: 439
		public global::AcpASKLib.AccessLevelDataRecordSet RadioWideACLRecSet;

		// Token: 0x040001B8 RID: 440
		public global::AcpASKLib.AccessLevelDataRecordSet SystemWideACLRecSet;

		// Token: 0x040001B9 RID: 441
		public global::AcpASKLib.AccessLevelDataRecordSet ConvSystemACLRecSet;
	}
}
