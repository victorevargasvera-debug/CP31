using System;
using SourceGrid.Cells.Editors;
using SourceGrid.Cells.Models;

namespace SourceGrid.Cells
{
	// Token: 0x0200039C RID: 924
	internal class Image : global::SourceGrid.Cells.Cell
	{
		// Token: 0x06002B3F RID: 11071 RVA: 0x00091A98 File Offset: 0x0008FC98
		public Image() : this(null)
		{
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x00091AA4 File Offset: 0x0008FCA4
		public Image(object value) : base(value)
		{
			base.Model.RemoveModel(base.Model.FindModel(typeof(global::SourceGrid.Cells.Models.Image)));
			base.Model.AddModel(global::SourceGrid.Cells.Models.ValueImage.Default);
			base.Editor = new global::SourceGrid.Cells.Editors.ImagePicker();
		}
	}
}
