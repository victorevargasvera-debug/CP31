using System;
using System.Collections.Generic;
using DevAge.Drawing;
using DevAge.Drawing.VisualElements;
using SourceGrid.Cells.Models;

namespace SourceGrid.Cells.Views
{
	// Token: 0x02000393 RID: 915
	[global::System.Serializable]
	internal class ColumnHeader : global::SourceGrid.Cells.Views.Header
	{
		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x06002B07 RID: 11015 RVA: 0x000913C8 File Offset: 0x0008F5C8
		public new static global::SourceGrid.Cells.Views.ColumnHeader Default
		{
			get
			{
				if (global::SourceGrid.Cells.Views.ColumnHeader.t_Default == null)
				{
					global::SourceGrid.Cells.Views.ColumnHeader.t_Default = new global::SourceGrid.Cells.Views.ColumnHeader();
				}
				return global::SourceGrid.Cells.Views.ColumnHeader.t_Default;
			}
		}

		// Token: 0x06002B08 RID: 11016 RVA: 0x000913E4 File Offset: 0x0008F5E4
		public ColumnHeader()
		{
			this.Background = new global::DevAge.Drawing.VisualElements.ColumnHeaderThemed();
		}

		// Token: 0x06002B09 RID: 11017 RVA: 0x00091404 File Offset: 0x0008F604
		public ColumnHeader(global::SourceGrid.Cells.Views.ColumnHeader p_Source) : base(p_Source)
		{
		}

		// Token: 0x06002B0A RID: 11018 RVA: 0x00091418 File Offset: 0x0008F618
		public override object Clone()
		{
			return new global::SourceGrid.Cells.Views.ColumnHeader(this);
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06002B0B RID: 11019 RVA: 0x00091420 File Offset: 0x0008F620
		// (set) Token: 0x06002B0C RID: 11020 RVA: 0x00091430 File Offset: 0x0008F630
		public new global::DevAge.Drawing.VisualElements.IColumnHeader Background
		{
			get
			{
				return (global::DevAge.Drawing.VisualElements.IColumnHeader)base.Background;
			}
			set
			{
				base.Background = value;
			}
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x0009143C File Offset: 0x0008F63C
		protected override void PrepareView(global::SourceGrid.CellContext context)
		{
			base.PrepareView(context);
			this.PrepareVisualElementSortIndicator(context);
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x0009144C File Offset: 0x0008F64C
		protected override global::System.Collections.Generic.IEnumerable<global::DevAge.Drawing.VisualElements.IVisualElement> GetElements()
		{
			if (this.ElementSort != null)
			{
				yield return this.ElementSort;
			}
			foreach (global::DevAge.Drawing.VisualElements.IVisualElement v in this.GetBaseElements())
			{
				yield return v;
			}
			yield break;
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x00091470 File Offset: 0x0008F670
		private global::System.Collections.Generic.IEnumerable<global::DevAge.Drawing.VisualElements.IVisualElement> GetBaseElements()
		{
			return base.GetElements();
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06002B10 RID: 11024 RVA: 0x00091478 File Offset: 0x0008F678
		// (set) Token: 0x06002B11 RID: 11025 RVA: 0x00091480 File Offset: 0x0008F680
		public global::DevAge.Drawing.VisualElements.ISortIndicator ElementSort
		{
			get
			{
				return this.mElementSort;
			}
			set
			{
				this.mElementSort = value;
			}
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x0009148C File Offset: 0x0008F68C
		protected virtual void PrepareVisualElementSortIndicator(global::SourceGrid.CellContext context)
		{
			global::SourceGrid.Cells.Models.ISortableHeader sortableHeader = (global::SourceGrid.Cells.Models.ISortableHeader)context.Cell.Model.FindModel(typeof(global::SourceGrid.Cells.Models.ISortableHeader));
			if (sortableHeader != null)
			{
				global::SourceGrid.Cells.Models.SortStatus sortStatus = sortableHeader.GetSortStatus(context);
				this.ElementSort.SortStyle = sortStatus.Style;
				return;
			}
			this.ElementSort.SortStyle = global::DevAge.Drawing.HeaderSortStyle.None;
		}

		// Token: 0x04000E7F RID: 3711
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Views.ColumnHeader t_Default;

		// Token: 0x04000E80 RID: 3712
		private global::DevAge.Drawing.VisualElements.ISortIndicator mElementSort = new global::DevAge.Drawing.VisualElements.SortIndicator();
	}
}
