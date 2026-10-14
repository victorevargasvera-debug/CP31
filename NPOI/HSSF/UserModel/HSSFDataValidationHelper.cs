using System;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200035E RID: 862
	public class HSSFDataValidationHelper : global::NPOI.SS.UserModel.IDataValidationHelper
	{
		// Token: 0x060019B7 RID: 6583 RVA: 0x0000253E File Offset: 0x0000073E
		public HSSFDataValidationHelper(global::NPOI.HSSF.UserModel.HSSFSheet sheet)
		{
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x0004EBA4 File Offset: 0x0004CDA4
		public global::NPOI.SS.UserModel.IDataValidationConstraint CreateDateConstraint(int operatorType, string formula1, string formula2, string dateFormat)
		{
			return global::NPOI.HSSF.UserModel.DVConstraint.CreateDateConstraint(operatorType, formula1, formula2, dateFormat);
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x0004EBB0 File Offset: 0x0004CDB0
		public global::NPOI.SS.UserModel.IDataValidationConstraint CreateExplicitListConstraint(string[] listOfValues)
		{
			return global::NPOI.HSSF.UserModel.DVConstraint.CreateExplicitListConstraint(listOfValues);
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x0004EBB8 File Offset: 0x0004CDB8
		public global::NPOI.SS.UserModel.IDataValidationConstraint CreateFormulaListConstraint(string listFormula)
		{
			return global::NPOI.HSSF.UserModel.DVConstraint.CreateFormulaListConstraint(listFormula);
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x0004EBC0 File Offset: 0x0004CDC0
		public global::NPOI.SS.UserModel.IDataValidationConstraint CreateNumericConstraint(int validationType, int operatorType, string formula1, string formula2)
		{
			return global::NPOI.HSSF.UserModel.DVConstraint.CreateNumericConstraint(validationType, operatorType, formula1, formula2);
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x0004EBCC File Offset: 0x0004CDCC
		public global::NPOI.SS.UserModel.IDataValidationConstraint CreateintConstraint(int operatorType, string formula1, string formula2)
		{
			return global::NPOI.HSSF.UserModel.DVConstraint.CreateNumericConstraint(1, operatorType, formula1, formula2);
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x0004EBD7 File Offset: 0x0004CDD7
		public global::NPOI.SS.UserModel.IDataValidationConstraint CreateDecimalConstraint(int operatorType, string formula1, string formula2)
		{
			return global::NPOI.HSSF.UserModel.DVConstraint.CreateNumericConstraint(2, operatorType, formula1, formula2);
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x0004EBE2 File Offset: 0x0004CDE2
		public global::NPOI.SS.UserModel.IDataValidationConstraint CreateTextLengthConstraint(int operatorType, string formula1, string formula2)
		{
			return global::NPOI.HSSF.UserModel.DVConstraint.CreateNumericConstraint(6, operatorType, formula1, formula2);
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x0004EBED File Offset: 0x0004CDED
		public global::NPOI.SS.UserModel.IDataValidationConstraint CreateTimeConstraint(int operatorType, string formula1, string formula2)
		{
			return global::NPOI.HSSF.UserModel.DVConstraint.CreateTimeConstraint(operatorType, formula1, formula2);
		}

		// Token: 0x060019C0 RID: 6592 RVA: 0x0004EBF7 File Offset: 0x0004CDF7
		public global::NPOI.SS.UserModel.IDataValidationConstraint CreateCustomConstraint(string formula)
		{
			return global::NPOI.HSSF.UserModel.DVConstraint.CreateCustomFormulaConstraint(formula);
		}

		// Token: 0x060019C1 RID: 6593 RVA: 0x0004EBFF File Offset: 0x0004CDFF
		public global::NPOI.SS.UserModel.IDataValidation CreateValidation(global::NPOI.SS.UserModel.IDataValidationConstraint constraint, global::NPOI.SS.Util.CellRangeAddressList cellRangeAddressList)
		{
			return new global::NPOI.HSSF.UserModel.HSSFDataValidation(cellRangeAddressList, constraint);
		}
	}
}
