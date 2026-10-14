using System;

namespace SourceGrid.Cells.Models
{
	// Token: 0x020003B2 RID: 946
	internal class ToolTip : global::SourceGrid.Cells.Models.IToolTipText, global::SourceGrid.Cells.Models.IModel
	{
		// Token: 0x06002B89 RID: 11145 RVA: 0x00092468 File Offset: 0x00090668
		public string GetToolTipText(global::SourceGrid.CellContext cellContext)
		{
			return this.m_ToolTipText;
		}

		// Token: 0x17000CE0 RID: 3296
		// (get) Token: 0x06002B8A RID: 11146 RVA: 0x00092470 File Offset: 0x00090670
		// (set) Token: 0x06002B8B RID: 11147 RVA: 0x00092478 File Offset: 0x00090678
		public string ToolTipText
		{
			get
			{
				return this.m_ToolTipText;
			}
			set
			{
				this.m_ToolTipText = value;
			}
		}

		// Token: 0x04000E98 RID: 3736
		private string m_ToolTipText;
	}
}
