using System;
using System.Collections;

namespace NPOI.SS.Util
{
	// Token: 0x0200002C RID: 44
	public class SheetReferences
	{
		// Token: 0x060001C0 RID: 448 RVA: 0x0000807C File Offset: 0x0000627C
		public SheetReferences()
		{
			this.map = new global::System.Collections.Hashtable(5);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00008090 File Offset: 0x00006290
		public void AddSheetReference(string sheetName, int number)
		{
			this.map[number] = sheetName;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000080A4 File Offset: 0x000062A4
		public string GetSheetName(int number)
		{
			return (string)this.map[number];
		}

		// Token: 0x040000A4 RID: 164
		private global::System.Collections.Hashtable map;
	}
}
