using System;
using SourceGrid.Cells.Controllers;
using SourceGrid.Cells.Editors;
using SourceGrid.Cells.Models;
using SourceGrid.Cells.Views;

namespace SourceGrid.Cells
{
	// Token: 0x020003EA RID: 1002
	internal class CheckBox : global::SourceGrid.Cells.Cell
	{
		// Token: 0x06002CAF RID: 11439 RVA: 0x00096410 File Offset: 0x00094610
		public CheckBox() : this(null, new bool?(false))
		{
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x00096420 File Offset: 0x00094620
		public CheckBox(string caption, bool? checkValue) : base(checkValue)
		{
			if (caption != null && caption.Length > 0)
			{
				this.View = global::SourceGrid.Cells.Views.CheckBox.MiddleLeftAlign;
			}
			else
			{
				this.View = global::SourceGrid.Cells.Views.CheckBox.Default;
			}
			base.Model.AddModel(new global::SourceGrid.Cells.Models.CheckBox());
			base.AddController(global::SourceGrid.Cells.Controllers.CheckBox.Default);
			base.AddController(global::SourceGrid.Cells.Controllers.MouseInvalidate.Default);
			base.Editor = new global::SourceGrid.Cells.Editors.EditorBase(typeof(bool));
			base.Editor.EditableMode = global::SourceGrid.EditableMode.None;
			this.Caption = caption;
		}

		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x06002CB1 RID: 11441 RVA: 0x000964B8 File Offset: 0x000946B8
		private global::SourceGrid.Cells.Models.CheckBox CheckBoxModel
		{
			get
			{
				return (global::SourceGrid.Cells.Models.CheckBox)base.Model.FindModel(typeof(global::SourceGrid.Cells.Models.CheckBox));
			}
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06002CB2 RID: 11442 RVA: 0x000964D4 File Offset: 0x000946D4
		// (set) Token: 0x06002CB3 RID: 11443 RVA: 0x00096500 File Offset: 0x00094700
		public bool? Checked
		{
			get
			{
				return this.CheckBoxModel.GetCheckBoxStatus(base.GetContext()).Checked;
			}
			set
			{
				this.CheckBoxModel.SetCheckedValue(base.GetContext(), value);
			}
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06002CB4 RID: 11444 RVA: 0x00096514 File Offset: 0x00094714
		// (set) Token: 0x06002CB5 RID: 11445 RVA: 0x00096524 File Offset: 0x00094724
		public string Caption
		{
			get
			{
				return this.CheckBoxModel.Caption;
			}
			set
			{
				this.CheckBoxModel.Caption = value;
			}
		}
	}
}
