using System;
using System.Drawing;
using DevAge.ComponentModel.Validator;

namespace SourceGrid.Cells.Models
{
	// Token: 0x020003B4 RID: 948
	internal class ValueImage : global::SourceGrid.Cells.Models.IImage, global::SourceGrid.Cells.Models.IModel
	{
		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x06002B92 RID: 11154 RVA: 0x000924C0 File Offset: 0x000906C0
		public static global::SourceGrid.Cells.Models.ValueImage Default
		{
			get
			{
				if (global::SourceGrid.Cells.Models.ValueImage.t_Default == null)
				{
					global::SourceGrid.Cells.Models.ValueImage.t_Default = new global::SourceGrid.Cells.Models.ValueImage();
				}
				return global::SourceGrid.Cells.Models.ValueImage.t_Default;
			}
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x000924DC File Offset: 0x000906DC
		public global::System.Drawing.Image GetImage(global::SourceGrid.CellContext cellContext)
		{
			object value = cellContext.Cell.Model.ValueModel.GetValue(cellContext);
			return (global::System.Drawing.Image)this.imageConverter.ObjectToValue(value);
		}

		// Token: 0x04000E9A RID: 3738
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Models.ValueImage t_Default;

		// Token: 0x04000E9B RID: 3739
		private readonly global::DevAge.ComponentModel.Validator.ValidatorTypeConverter imageConverter = new global::DevAge.ComponentModel.Validator.ValidatorTypeConverter(typeof(global::System.Drawing.Image));
	}
}
