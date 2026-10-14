using System;
using System.Collections.ObjectModel;
using ASK.Interface;

namespace ASK.Core
{
	// Token: 0x0200001A RID: 26
	public interface IKeyRecord
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600012A RID: 298
		// (set) Token: 0x0600012B RID: 299
		short Version { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600012C RID: 300
		// (set) Token: 0x0600012D RID: 301
		global::ASK.Interface.KeyType Type { get; set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600012E RID: 302
		// (set) Token: 0x0600012F RID: 303
		global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Core.IKeyDataRecord> KeyDataList { get; set; }
	}
}
