using System;

namespace ASK.Core
{
	// Token: 0x0200001D RID: 29
	public interface IKeyDataRecord
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000136 RID: 310
		// (set) Token: 0x06000137 RID: 311
		byte KeyType { get; set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000138 RID: 312
		// (set) Token: 0x06000139 RID: 313
		int SystemID { get; set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600013A RID: 314
		// (set) Token: 0x0600013B RID: 315
		bool Editable { get; set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600013C RID: 316
		// (set) Token: 0x0600013D RID: 317
		bool IsSelected { get; set; }
	}
}
