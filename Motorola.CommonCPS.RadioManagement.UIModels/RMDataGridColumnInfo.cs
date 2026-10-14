using System;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000011 RID: 17
	public class RMDataGridColumnInfo
	{
		// Token: 0x0600008B RID: 139 RVA: 0x0000978C File Offset: 0x0000798C
		public RMDataGridColumnInfo()
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000097A0 File Offset: 0x000079A0
		public RMDataGridColumnInfo(string fieldName = null, string fieldUIString = null, bool isVisible = true)
		{
			this.FieldName = fieldName;
			this.FieldUIString = fieldUIString;
			this.IsVisible = isVisible;
		}

		// Token: 0x04000024 RID: 36
		public string FieldName;

		// Token: 0x04000025 RID: 37
		public string FieldUIString;

		// Token: 0x04000026 RID: 38
		public bool IsVisible;
	}
}
