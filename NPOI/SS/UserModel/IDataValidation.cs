using System;
using NPOI.SS.Util;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200005C RID: 92
	public interface IDataValidation
	{
		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600036F RID: 879
		global::NPOI.SS.UserModel.IDataValidationConstraint ValidationConstraint { get; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000370 RID: 880
		// (set) Token: 0x06000371 RID: 881
		int ErrorStyle { get; set; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000372 RID: 882
		// (set) Token: 0x06000373 RID: 883
		bool EmptyCellAllowed { get; set; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000374 RID: 884
		// (set) Token: 0x06000375 RID: 885
		bool SuppressDropDownArrow { get; set; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000376 RID: 886
		// (set) Token: 0x06000377 RID: 887
		bool ShowPromptBox { get; set; }

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000378 RID: 888
		// (set) Token: 0x06000379 RID: 889
		bool ShowErrorBox { get; set; }

		// Token: 0x0600037A RID: 890
		void CreatePromptBox(string title, string text);

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600037B RID: 891
		string PromptBoxTitle { get; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600037C RID: 892
		string PromptBoxText { get; }

		// Token: 0x0600037D RID: 893
		void CreateErrorBox(string title, string text);

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600037E RID: 894
		string ErrorBoxTitle { get; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600037F RID: 895
		string ErrorBoxText { get; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000380 RID: 896
		global::NPOI.SS.Util.CellRangeAddressList Regions { get; }
	}
}
