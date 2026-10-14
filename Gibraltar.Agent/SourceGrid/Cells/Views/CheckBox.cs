using System;
using System.Collections.Generic;
using DevAge.Drawing;
using DevAge.Drawing.VisualElements;
using SourceGrid.Cells.Models;

namespace SourceGrid.Cells.Views
{
	// Token: 0x02000345 RID: 837
	[global::System.Serializable]
	internal class CheckBox : global::SourceGrid.Cells.Views.Cell
	{
		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x0600288F RID: 10383 RVA: 0x0008C970 File Offset: 0x0008AB70
		public new static global::SourceGrid.Cells.Views.CheckBox Default
		{
			get
			{
				if (global::SourceGrid.Cells.Views.CheckBox.t_Default == null)
				{
					global::SourceGrid.Cells.Views.CheckBox.t_Default = new global::SourceGrid.Cells.Views.CheckBox();
				}
				return global::SourceGrid.Cells.Views.CheckBox.t_Default;
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x06002890 RID: 10384 RVA: 0x0008C98C File Offset: 0x0008AB8C
		public static global::SourceGrid.Cells.Views.CheckBox MiddleLeftAlign
		{
			get
			{
				if (global::SourceGrid.Cells.Views.CheckBox.t_MiddleLeftAlign == null)
				{
					global::SourceGrid.Cells.Views.CheckBox.t_MiddleLeftAlign = new global::SourceGrid.Cells.Views.CheckBox();
					global::SourceGrid.Cells.Views.CheckBox.t_MiddleLeftAlign.CheckBoxAlignment = global::DevAge.Drawing.ContentAlignment.MiddleLeft;
					global::SourceGrid.Cells.Views.CheckBox.t_MiddleLeftAlign.TextAlignment = global::DevAge.Drawing.ContentAlignment.MiddleLeft;
				}
				return global::SourceGrid.Cells.Views.CheckBox.t_MiddleLeftAlign;
			}
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x0008C9C0 File Offset: 0x0008ABC0
		public CheckBox()
		{
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x0008C9DC File Offset: 0x0008ABDC
		public CheckBox(global::SourceGrid.Cells.Views.CheckBox p_Source) : base(p_Source)
		{
			this.m_CheckBoxAlignment = p_Source.m_CheckBoxAlignment;
			this.ElementCheckBox = (global::DevAge.Drawing.VisualElements.ICheckBox)this.ElementCheckBox.Clone();
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x06002893 RID: 10387 RVA: 0x0008CA2C File Offset: 0x0008AC2C
		// (set) Token: 0x06002894 RID: 10388 RVA: 0x0008CA34 File Offset: 0x0008AC34
		public global::DevAge.Drawing.ContentAlignment CheckBoxAlignment
		{
			get
			{
				return this.m_CheckBoxAlignment;
			}
			set
			{
				this.m_CheckBoxAlignment = value;
			}
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x0008CA40 File Offset: 0x0008AC40
		protected override void PrepareView(global::SourceGrid.CellContext context)
		{
			base.PrepareView(context);
			this.PrepareVisualElementCheckBox(context);
		}

		// Token: 0x06002896 RID: 10390 RVA: 0x0008CA50 File Offset: 0x0008AC50
		protected override global::System.Collections.Generic.IEnumerable<global::DevAge.Drawing.VisualElements.IVisualElement> GetElements()
		{
			if (this.ElementCheckBox != null)
			{
				yield return this.ElementCheckBox;
			}
			foreach (global::DevAge.Drawing.VisualElements.IVisualElement v in this.GetBaseElements())
			{
				yield return v;
			}
			yield break;
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x0008CA74 File Offset: 0x0008AC74
		private global::System.Collections.Generic.IEnumerable<global::DevAge.Drawing.VisualElements.IVisualElement> GetBaseElements()
		{
			return base.GetElements();
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x06002898 RID: 10392 RVA: 0x0008CA7C File Offset: 0x0008AC7C
		// (set) Token: 0x06002899 RID: 10393 RVA: 0x0008CA84 File Offset: 0x0008AC84
		public global::DevAge.Drawing.VisualElements.ICheckBox ElementCheckBox
		{
			get
			{
				return this.mElementCheckBox;
			}
			set
			{
				this.mElementCheckBox = value;
			}
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x0008CA90 File Offset: 0x0008AC90
		protected virtual void PrepareVisualElementCheckBox(global::SourceGrid.CellContext context)
		{
			this.ElementCheckBox.AnchorArea = new global::DevAge.Drawing.AnchorArea(this.CheckBoxAlignment, false);
			global::SourceGrid.Cells.Models.ICheckBox checkBox = (global::SourceGrid.Cells.Models.ICheckBox)context.Cell.Model.FindModel(typeof(global::SourceGrid.Cells.Models.ICheckBox));
			global::SourceGrid.Cells.Models.CheckBoxStatus checkBoxStatus = checkBox.GetCheckBoxStatus(context);
			if (context.CellRange.Contains(context.Grid.MouseCellPosition))
			{
				if (checkBoxStatus.CheckEnable)
				{
					this.ElementCheckBox.Style = global::DevAge.Drawing.ControlDrawStyle.Hot;
				}
				else
				{
					this.ElementCheckBox.Style = global::DevAge.Drawing.ControlDrawStyle.Disabled;
				}
			}
			else if (checkBoxStatus.CheckEnable)
			{
				this.ElementCheckBox.Style = global::DevAge.Drawing.ControlDrawStyle.Normal;
			}
			else
			{
				this.ElementCheckBox.Style = global::DevAge.Drawing.ControlDrawStyle.Disabled;
			}
			this.ElementCheckBox.CheckBoxState = checkBoxStatus.CheckState;
			base.ElementText.Value = checkBoxStatus.Caption;
		}

		// Token: 0x0600289B RID: 10395 RVA: 0x0008CB7C File Offset: 0x0008AD7C
		public override object Clone()
		{
			return new global::SourceGrid.Cells.Views.CheckBox(this);
		}

		// Token: 0x04000E02 RID: 3586
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Views.CheckBox t_Default;

		// Token: 0x04000E03 RID: 3587
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Views.CheckBox t_MiddleLeftAlign;

		// Token: 0x04000E04 RID: 3588
		private global::DevAge.Drawing.ContentAlignment m_CheckBoxAlignment = global::DevAge.Drawing.ContentAlignment.MiddleCenter;

		// Token: 0x04000E05 RID: 3589
		private global::DevAge.Drawing.VisualElements.ICheckBox mElementCheckBox = new global::DevAge.Drawing.VisualElements.CheckBoxThemed();
	}
}
