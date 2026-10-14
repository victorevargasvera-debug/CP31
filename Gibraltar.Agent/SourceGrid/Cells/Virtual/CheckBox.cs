using System;
using SourceGrid.Cells.Controllers;
using SourceGrid.Cells.Editors;
using SourceGrid.Cells.Models;
using SourceGrid.Cells.Views;

namespace SourceGrid.Cells.Virtual
{
	// Token: 0x020003E9 RID: 1001
	internal class CheckBox : global::SourceGrid.Cells.Virtual.CellVirtual
	{
		// Token: 0x06002CAE RID: 11438 RVA: 0x000963A4 File Offset: 0x000945A4
		public CheckBox()
		{
			this.View = global::SourceGrid.Cells.Views.CheckBox.Default;
			base.AddController(global::SourceGrid.Cells.Controllers.CheckBox.Default);
			base.AddController(global::SourceGrid.Cells.Controllers.MouseInvalidate.Default);
			base.Editor = new global::SourceGrid.Cells.Editors.EditorBase(typeof(bool));
			base.Editor.EditableMode = global::SourceGrid.EditableMode.None;
			base.Model.AddModel(new global::SourceGrid.Cells.Models.CheckBox());
		}
	}
}
