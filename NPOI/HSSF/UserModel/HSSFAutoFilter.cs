using System;
using NPOI.HSSF.Model;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.AutoFilter;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000368 RID: 872
	public class HSSFAutoFilter : global::NPOI.SS.UserModel.IAutoFilter
	{
		// Token: 0x06001A83 RID: 6787 RVA: 0x0005147C File Offset: 0x0004F67C
		public HSSFAutoFilter(global::NPOI.HSSF.UserModel.HSSFSheet sheet)
		{
			this._sheet = sheet;
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x0005148C File Offset: 0x0004F68C
		public HSSFAutoFilter(string formula, global::NPOI.HSSF.UserModel.HSSFWorkbook workbook)
		{
			global::NPOI.SS.Formula.PTG.Ptg[] array = global::NPOI.HSSF.Model.HSSFFormulaParser.Parse(formula, workbook);
			if (!(array[0] is global::NPOI.SS.Formula.PTG.Area3DPtg))
			{
				throw new global::System.ArgumentException("incorrect formula");
			}
			global::NPOI.SS.Formula.PTG.Area3DPtg area3DPtg = (global::NPOI.SS.Formula.PTG.Area3DPtg)array[0];
			global::NPOI.HSSF.UserModel.HSSFSheet hssfsheet = (global::NPOI.HSSF.UserModel.HSSFSheet)workbook.GetSheetAt(area3DPtg.ExternSheetIndex);
			int num = hssfsheet.Sheet.FindFirstRecordLocBySid(85);
			this.CreateFilterModeRecord(hssfsheet, num + 1);
			this.CreateAutoFilterInfoRecord(hssfsheet, num + 2, area3DPtg);
			global::NPOI.HSSF.Record.NameRecord nameRecord = workbook.Workbook.GetSpecificBuiltinRecord(13, area3DPtg.ExternSheetIndex + 1);
			if (nameRecord == null)
			{
				nameRecord = workbook.Workbook.CreateBuiltInName(13, area3DPtg.ExternSheetIndex + 1);
			}
			nameRecord.IsHiddenName = true;
			nameRecord.NameDefinition = array;
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x0005153C File Offset: 0x0004F73C
		private void CreateFilterModeRecord(global::NPOI.HSSF.UserModel.HSSFSheet sheet, int insertPos)
		{
			if (sheet.Sheet.FindFirstRecordBySid(155) == null)
			{
				this.filtermode = new global::NPOI.HSSF.Record.AutoFilter.FilterModeRecord();
				sheet.Sheet.Records.Insert(insertPos, this.filtermode);
			}
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x00051574 File Offset: 0x0004F774
		private void CreateAutoFilterInfoRecord(global::NPOI.HSSF.UserModel.HSSFSheet sheet, int insertPos, global::NPOI.SS.Formula.PTG.Area3DPtg ptg)
		{
			global::NPOI.HSSF.Record.Record record = sheet.Sheet.FindFirstRecordBySid(157);
			global::NPOI.HSSF.Record.AutoFilter.AutoFilterInfoRecord autoFilterInfoRecord;
			if (record == null)
			{
				autoFilterInfoRecord = new global::NPOI.HSSF.Record.AutoFilter.AutoFilterInfoRecord();
				sheet.Sheet.Records.Insert(insertPos, autoFilterInfoRecord);
			}
			else
			{
				autoFilterInfoRecord = (record as global::NPOI.HSSF.Record.AutoFilter.AutoFilterInfoRecord);
			}
			autoFilterInfoRecord.NumEntries = (short)(ptg.LastColumn - ptg.FirstColumn + 1);
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x000515CC File Offset: 0x0004F7CC
		private void RemoveFilterModeRecord(global::NPOI.HSSF.UserModel.HSSFSheet sheet)
		{
			if (this.filtermode != null)
			{
				sheet.Sheet.Records.Remove(this.filtermode);
			}
		}

		// Token: 0x04000B1C RID: 2844
		private global::NPOI.HSSF.Record.AutoFilter.FilterModeRecord filtermode;

		// Token: 0x04000B1D RID: 2845
		private global::NPOI.HSSF.UserModel.HSSFSheet _sheet;
	}
}
