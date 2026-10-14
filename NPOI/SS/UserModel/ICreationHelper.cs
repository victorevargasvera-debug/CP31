using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000058 RID: 88
	public interface ICreationHelper
	{
		// Token: 0x0600034C RID: 844
		global::NPOI.SS.UserModel.IRichTextString CreateRichTextString(string text);

		// Token: 0x0600034D RID: 845
		global::NPOI.SS.UserModel.IDataFormat CreateDataFormat();

		// Token: 0x0600034E RID: 846
		global::NPOI.SS.UserModel.IHyperlink CreateHyperlink(global::NPOI.SS.UserModel.HyperlinkType type);

		// Token: 0x0600034F RID: 847
		global::NPOI.SS.UserModel.IFormulaEvaluator CreateFormulaEvaluator();

		// Token: 0x06000350 RID: 848
		global::NPOI.SS.UserModel.ExtendedColor CreateExtendedColor();

		// Token: 0x06000351 RID: 849
		global::NPOI.SS.UserModel.IClientAnchor CreateClientAnchor();
	}
}
