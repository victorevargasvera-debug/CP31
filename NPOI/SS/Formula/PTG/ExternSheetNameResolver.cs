using System;
using System.Text;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000108 RID: 264
	public class ExternSheetNameResolver
	{
		// Token: 0x060008E2 RID: 2274 RVA: 0x00018254 File Offset: 0x00016454
		public static string PrependSheetName(global::NPOI.SS.Formula.IFormulaRenderingWorkbook book, int field_1_index_extern_sheet, string cellRefText)
		{
			global::NPOI.SS.Formula.ExternalSheet externalSheet = book.GetExternalSheet(field_1_index_extern_sheet);
			global::System.Text.StringBuilder stringBuilder;
			if (externalSheet != null)
			{
				string workbookName = externalSheet.WorkbookName;
				string sheetName = externalSheet.SheetName;
				if (workbookName != null)
				{
					stringBuilder = new global::System.Text.StringBuilder(workbookName.Length + sheetName.Length + cellRefText.Length + 4);
					global::NPOI.SS.Formula.SheetNameFormatter.AppendFormat(stringBuilder, workbookName, sheetName);
				}
				else
				{
					stringBuilder = new global::System.Text.StringBuilder(sheetName.Length + cellRefText.Length + 4);
					global::NPOI.SS.Formula.SheetNameFormatter.AppendFormat(stringBuilder, sheetName);
				}
				if (externalSheet is global::NPOI.SS.Formula.ExternalSheetRange)
				{
					global::NPOI.SS.Formula.ExternalSheetRange externalSheetRange = (global::NPOI.SS.Formula.ExternalSheetRange)externalSheet;
					if (!externalSheetRange.FirstSheetName.Equals(externalSheetRange.LastSheetName))
					{
						stringBuilder.Append(':');
						global::NPOI.SS.Formula.SheetNameFormatter.AppendFormat(stringBuilder, externalSheetRange.LastSheetName);
					}
				}
			}
			else
			{
				string sheetFirstNameByExternSheet = book.GetSheetFirstNameByExternSheet(field_1_index_extern_sheet);
				string sheetLastNameByExternSheet = book.GetSheetLastNameByExternSheet(field_1_index_extern_sheet);
				stringBuilder = new global::System.Text.StringBuilder(sheetFirstNameByExternSheet.Length + cellRefText.Length + 4);
				if (sheetFirstNameByExternSheet.Length < 1)
				{
					stringBuilder.Append("#REF");
				}
				else
				{
					global::NPOI.SS.Formula.SheetNameFormatter.AppendFormat(stringBuilder, sheetFirstNameByExternSheet);
					if (!sheetFirstNameByExternSheet.Equals(sheetLastNameByExternSheet))
					{
						stringBuilder.Append(':');
						stringBuilder.Append(sheetLastNameByExternSheet);
					}
				}
			}
			stringBuilder.Append('!');
			stringBuilder.Append(cellRefText);
			return stringBuilder.ToString();
		}
	}
}
