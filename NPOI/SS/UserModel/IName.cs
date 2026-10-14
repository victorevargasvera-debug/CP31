using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000077 RID: 119
	public interface IName
	{
		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000426 RID: 1062
		string SheetName { get; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000427 RID: 1063
		// (set) Token: 0x06000428 RID: 1064
		string NameName { get; set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000429 RID: 1065
		// (set) Token: 0x0600042A RID: 1066
		string RefersToFormula { get; set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600042B RID: 1067
		bool IsFunctionName { get; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600042C RID: 1068
		bool IsDeleted { get; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600042D RID: 1069
		// (set) Token: 0x0600042E RID: 1070
		int SheetIndex { get; set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x0600042F RID: 1071
		// (set) Token: 0x06000430 RID: 1072
		string Comment { get; set; }

		// Token: 0x06000431 RID: 1073
		void SetFunction(bool value);
	}
}
