using System;
using NPOI.SS.Util;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000060 RID: 96
	public interface IDataValidationHelper
	{
		// Token: 0x0600038B RID: 907
		global::NPOI.SS.UserModel.IDataValidationConstraint CreateFormulaListConstraint(string listFormula);

		// Token: 0x0600038C RID: 908
		global::NPOI.SS.UserModel.IDataValidationConstraint CreateExplicitListConstraint(string[] listOfValues);

		// Token: 0x0600038D RID: 909
		global::NPOI.SS.UserModel.IDataValidationConstraint CreateNumericConstraint(int validationType, int operatorType, string formula1, string formula2);

		// Token: 0x0600038E RID: 910
		global::NPOI.SS.UserModel.IDataValidationConstraint CreateTextLengthConstraint(int operatorType, string formula1, string formula2);

		// Token: 0x0600038F RID: 911
		global::NPOI.SS.UserModel.IDataValidationConstraint CreateDecimalConstraint(int operatorType, string formula1, string formula2);

		// Token: 0x06000390 RID: 912
		global::NPOI.SS.UserModel.IDataValidationConstraint CreateintConstraint(int operatorType, string formula1, string formula2);

		// Token: 0x06000391 RID: 913
		global::NPOI.SS.UserModel.IDataValidationConstraint CreateDateConstraint(int operatorType, string formula1, string formula2, string dateFormat);

		// Token: 0x06000392 RID: 914
		global::NPOI.SS.UserModel.IDataValidationConstraint CreateTimeConstraint(int operatorType, string formula1, string formula2);

		// Token: 0x06000393 RID: 915
		global::NPOI.SS.UserModel.IDataValidationConstraint CreateCustomConstraint(string formula);

		// Token: 0x06000394 RID: 916
		global::NPOI.SS.UserModel.IDataValidation CreateValidation(global::NPOI.SS.UserModel.IDataValidationConstraint constraint, global::NPOI.SS.Util.CellRangeAddressList cellRangeAddressList);
	}
}
