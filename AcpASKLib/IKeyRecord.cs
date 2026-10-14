using System;
using System.Collections.ObjectModel;

namespace AcpASKLib
{
	// Token: 0x02000028 RID: 40
	public interface IKeyRecord
	{
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000129 RID: 297
		// (set) Token: 0x0600012A RID: 298
		short Version { get; set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600012B RID: 299
		// (set) Token: 0x0600012C RID: 300
		global::AcpASKLib.KeyType Type { get; set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600012D RID: 301
		// (set) Token: 0x0600012E RID: 302
		global::System.Collections.ObjectModel.ObservableCollection<global::AcpASKLib.IKeyDataRecord> KeyDataList { get; set; }
	}
}
