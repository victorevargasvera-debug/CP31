using System;
using SourceGrid.Cells.Editors;
using SourceGrid.Cells.Models;

namespace SourceGrid.Cells.Virtual
{
	// Token: 0x0200039B RID: 923
	internal class Image : global::SourceGrid.Cells.Virtual.CellVirtual
	{
		// Token: 0x06002B3E RID: 11070 RVA: 0x00091A64 File Offset: 0x0008FC64
		public Image()
		{
			base.Model.AddModel(global::SourceGrid.Cells.Models.ValueImage.Default);
			base.Editor = new global::SourceGrid.Cells.Editors.ImagePicker();
		}
	}
}
