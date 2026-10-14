using System;

namespace AcpASKLib
{
	// Token: 0x0200002A RID: 42
	public interface IKeyDataRecord
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000134 RID: 308
		// (set) Token: 0x06000135 RID: 309
		byte KeyType { get; set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000136 RID: 310
		// (set) Token: 0x06000137 RID: 311
		int SystemID { get; set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000138 RID: 312
		// (set) Token: 0x06000139 RID: 313
		bool Editable { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600013A RID: 314
		// (set) Token: 0x0600013B RID: 315
		bool IsSelected { get; set; }
	}
}
