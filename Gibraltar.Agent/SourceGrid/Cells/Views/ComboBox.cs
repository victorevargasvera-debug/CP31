using System;
using System.Collections.Generic;
using DevAge.Drawing;
using DevAge.Drawing.VisualElements;

namespace SourceGrid.Cells.Views
{
	// Token: 0x02000397 RID: 919
	internal class ComboBox : global::SourceGrid.Cells.Views.Cell
	{
		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06002B1E RID: 11038 RVA: 0x00091698 File Offset: 0x0008F898
		public new static global::SourceGrid.Cells.Views.ComboBox Default
		{
			get
			{
				if (global::SourceGrid.Cells.Views.ComboBox.t_Default == null)
				{
					global::SourceGrid.Cells.Views.ComboBox.t_Default = new global::SourceGrid.Cells.Views.ComboBox();
				}
				return global::SourceGrid.Cells.Views.ComboBox.t_Default;
			}
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x000916B4 File Offset: 0x0008F8B4
		public ComboBox()
		{
			this.ElementDropDown.AnchorArea = new global::DevAge.Drawing.AnchorArea(float.NaN, 0f, 0f, 0f, false, false);
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x000916FC File Offset: 0x0008F8FC
		public ComboBox(global::SourceGrid.Cells.Views.ComboBox p_Source) : base(p_Source)
		{
			this.ElementDropDown = (global::DevAge.Drawing.VisualElements.IDropDownButton)this.ElementDropDown.Clone();
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x00091738 File Offset: 0x0008F938
		protected override void PrepareView(global::SourceGrid.CellContext context)
		{
			base.PrepareView(context);
			this.PrepareVisualElementDropDown(context);
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x00091748 File Offset: 0x0008F948
		protected override global::System.Collections.Generic.IEnumerable<global::DevAge.Drawing.VisualElements.IVisualElement> GetElements()
		{
			if (this.ElementDropDown != null)
			{
				yield return this.ElementDropDown;
			}
			foreach (global::DevAge.Drawing.VisualElements.IVisualElement v in this.GetBaseElements())
			{
				yield return v;
			}
			yield break;
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x0009176C File Offset: 0x0008F96C
		private global::System.Collections.Generic.IEnumerable<global::DevAge.Drawing.VisualElements.IVisualElement> GetBaseElements()
		{
			return base.GetElements();
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06002B24 RID: 11044 RVA: 0x00091774 File Offset: 0x0008F974
		// (set) Token: 0x06002B25 RID: 11045 RVA: 0x0009177C File Offset: 0x0008F97C
		public global::DevAge.Drawing.VisualElements.IDropDownButton ElementDropDown
		{
			get
			{
				return this.mElementDropDown;
			}
			set
			{
				this.mElementDropDown = value;
			}
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x00091788 File Offset: 0x0008F988
		protected virtual void PrepareVisualElementDropDown(global::SourceGrid.CellContext context)
		{
			if (context.CellRange.Contains(context.Grid.MouseCellPosition))
			{
				this.ElementDropDown.Style = global::DevAge.Drawing.ButtonStyle.Hot;
				return;
			}
			this.ElementDropDown.Style = global::DevAge.Drawing.ButtonStyle.Normal;
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x000917D4 File Offset: 0x0008F9D4
		public override object Clone()
		{
			return new global::SourceGrid.Cells.Views.ComboBox(this);
		}

		// Token: 0x04000E83 RID: 3715
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Views.ComboBox t_Default;

		// Token: 0x04000E84 RID: 3716
		private global::DevAge.Drawing.VisualElements.IDropDownButton mElementDropDown = new global::DevAge.Drawing.VisualElements.DropDownButtonThemed();
	}
}
