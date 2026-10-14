using System;
using DevAge.ComponentModel;

namespace SourceGrid.Cells.Models
{
	// Token: 0x020003AC RID: 940
	internal class ValueModel : global::SourceGrid.Cells.Models.IValueModel, global::SourceGrid.Cells.Models.IModel
	{
		// Token: 0x06002B76 RID: 11126 RVA: 0x00092294 File Offset: 0x00090494
		public ValueModel()
		{
		}

		// Token: 0x06002B77 RID: 11127 RVA: 0x0009229C File Offset: 0x0009049C
		public ValueModel(object val)
		{
			this.m_Value = val;
		}

		// Token: 0x06002B78 RID: 11128 RVA: 0x000922AC File Offset: 0x000904AC
		public object GetValue(global::SourceGrid.CellContext cellContext)
		{
			return this.m_Value;
		}

		// Token: 0x06002B79 RID: 11129 RVA: 0x000922B4 File Offset: 0x000904B4
		public void SetValue(global::SourceGrid.CellContext cellContext, object p_Value)
		{
			global::DevAge.ComponentModel.ValueEventArgs valueEventArgs = new global::DevAge.ComponentModel.ValueEventArgs(p_Value);
			if (cellContext.Grid != null)
			{
				cellContext.Grid.Controller.OnValueChanging(cellContext, valueEventArgs);
			}
			this.m_Value = valueEventArgs.Value;
			if (cellContext.Grid != null)
			{
				cellContext.Grid.Controller.OnValueChanged(cellContext, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x04000E95 RID: 3733
		private object m_Value;
	}
}
