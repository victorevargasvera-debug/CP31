using System;
using DevAge.Drawing;

namespace SourceGrid.Cells.Models
{
	// Token: 0x020003AE RID: 942
	internal class CheckBox : global::SourceGrid.Cells.Models.ICheckBox, global::SourceGrid.Cells.Models.IModel
	{
		// Token: 0x06002B7C RID: 11132 RVA: 0x0009231C File Offset: 0x0009051C
		public global::SourceGrid.Cells.Models.CheckBoxStatus GetCheckBoxStatus(global::SourceGrid.CellContext cellContext)
		{
			bool checkEnable = false;
			if (cellContext.Cell.Editor != null && cellContext.Cell.Editor.EnableEdit)
			{
				checkEnable = true;
			}
			object value = cellContext.Cell.Model.ValueModel.GetValue(cellContext);
			if (value == null)
			{
				return new global::SourceGrid.Cells.Models.CheckBoxStatus(checkEnable, global::DevAge.Drawing.CheckBoxState.Undefined, this.m_Caption);
			}
			if (value is bool)
			{
				return new global::SourceGrid.Cells.Models.CheckBoxStatus(checkEnable, new bool?((bool)value), this.m_Caption);
			}
			throw new global::SourceGrid.SourceGridException("Cell value not supported for this cell. Expected bool value or null.");
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x000923B4 File Offset: 0x000905B4
		public void SetCheckedValue(global::SourceGrid.CellContext cellContext, bool? pChecked)
		{
			if (cellContext.Cell.Editor != null && cellContext.Cell.Editor.EnableEdit)
			{
				cellContext.Cell.Editor.SetCellValue(cellContext, pChecked);
			}
		}

		// Token: 0x17000CDE RID: 3294
		// (get) Token: 0x06002B7E RID: 11134 RVA: 0x00092408 File Offset: 0x00090608
		// (set) Token: 0x06002B7F RID: 11135 RVA: 0x00092410 File Offset: 0x00090610
		public string Caption
		{
			get
			{
				return this.m_Caption;
			}
			set
			{
				this.m_Caption = value;
			}
		}

		// Token: 0x04000E96 RID: 3734
		private string m_Caption;
	}
}
