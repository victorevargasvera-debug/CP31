using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000072 RID: 114
	public interface IHeaderFooter
	{
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000411 RID: 1041
		// (set) Token: 0x06000412 RID: 1042
		string Left { get; set; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000413 RID: 1043
		// (set) Token: 0x06000414 RID: 1044
		string Center { get; set; }

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000415 RID: 1045
		// (set) Token: 0x06000416 RID: 1046
		string Right { get; set; }
	}
}
