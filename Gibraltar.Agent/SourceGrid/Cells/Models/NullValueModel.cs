using System;

namespace SourceGrid.Cells.Models
{
	// Token: 0x020003AB RID: 939
	internal class NullValueModel : global::SourceGrid.Cells.Models.IValueModel, global::SourceGrid.Cells.Models.IModel
	{
		// Token: 0x17000CDD RID: 3293
		// (get) Token: 0x06002B71 RID: 11121 RVA: 0x0009225C File Offset: 0x0009045C
		public static global::SourceGrid.Cells.Models.NullValueModel Default
		{
			get
			{
				if (global::SourceGrid.Cells.Models.NullValueModel.t_Default == null)
				{
					global::SourceGrid.Cells.Models.NullValueModel.t_Default = new global::SourceGrid.Cells.Models.NullValueModel();
				}
				return global::SourceGrid.Cells.Models.NullValueModel.t_Default;
			}
		}

		// Token: 0x06002B73 RID: 11123 RVA: 0x00092280 File Offset: 0x00090480
		public object GetValue(global::SourceGrid.CellContext cellContext)
		{
			return null;
		}

		// Token: 0x06002B74 RID: 11124 RVA: 0x00092284 File Offset: 0x00090484
		public void SetValue(global::SourceGrid.CellContext cellContext, object p_Value)
		{
			throw new global::System.ApplicationException("This model doesn't support editing");
		}

		// Token: 0x06002B75 RID: 11125 RVA: 0x00092290 File Offset: 0x00090490
		public string GetDisplayText(global::SourceGrid.CellContext cellContext)
		{
			return null;
		}

		// Token: 0x04000E94 RID: 3732
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Models.NullValueModel t_Default;
	}
}
