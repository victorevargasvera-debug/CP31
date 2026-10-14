using System;

namespace NPOI.SS.Extractor
{
	// Token: 0x0200000D RID: 13
	public interface IExcelExtractor
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600007E RID: 126
		// (set) Token: 0x0600007F RID: 127
		bool IncludeCellComments { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000080 RID: 128
		// (set) Token: 0x06000081 RID: 129
		bool IncludeSheetNames { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000082 RID: 130
		// (set) Token: 0x06000083 RID: 131
		bool FormulasNotResults { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000084 RID: 132
		// (set) Token: 0x06000085 RID: 133
		bool IncludeHeaderFooter { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000086 RID: 134
		string Text { get; }
	}
}
