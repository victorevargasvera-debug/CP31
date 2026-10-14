using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000045 RID: 69
	public interface ITable
	{
		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000273 RID: 627
		int StartColIndex { get; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000274 RID: 628
		int StartRowIndex { get; }

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000275 RID: 629
		int EndColIndex { get; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000276 RID: 630
		int EndRowIndex { get; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000277 RID: 631
		string Name { get; }

		// Token: 0x06000278 RID: 632
		int FindColumnIndex(string columnHeader);

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000279 RID: 633
		string SheetName { get; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600027A RID: 634
		bool IsHasTotalsRow { get; }
	}
}
