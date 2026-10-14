using System;
using System.Collections;
using DevAge.Drawing;
using SourceGrid.Cells.Controllers;
using SourceGrid.Cells.Models;
using SourceGrid.Cells.Views;

namespace SourceGrid.Cells
{
	// Token: 0x020003A8 RID: 936
	internal class ColumnHeader : global::SourceGrid.Cells.Cell
	{
		// Token: 0x06002B60 RID: 11104 RVA: 0x0009206C File Offset: 0x0009026C
		public ColumnHeader() : this(null)
		{
		}

		// Token: 0x06002B61 RID: 11105 RVA: 0x00092078 File Offset: 0x00090278
		public ColumnHeader(object cellValue) : base(cellValue)
		{
			this.View = global::SourceGrid.Cells.Views.ColumnHeader.Default;
			base.Model.AddModel(new global::SourceGrid.Cells.Models.SortableHeader());
			base.AddController(global::SourceGrid.Cells.Controllers.Unselectable.Default);
			base.AddController(global::SourceGrid.Cells.Controllers.MouseInvalidate.Default);
			this.ResizeEnabled = true;
			this.AutomaticSortEnabled = true;
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x06002B62 RID: 11106 RVA: 0x000920D0 File Offset: 0x000902D0
		// (set) Token: 0x06002B63 RID: 11107 RVA: 0x000920EC File Offset: 0x000902EC
		public bool ResizeEnabled
		{
			get
			{
				return base.FindController(typeof(global::SourceGrid.Cells.Controllers.Resizable)) == global::SourceGrid.Cells.Controllers.Resizable.ResizeWidth;
			}
			set
			{
				if (value == this.ResizeEnabled)
				{
					return;
				}
				if (value)
				{
					base.AddController(global::SourceGrid.Cells.Controllers.Resizable.ResizeWidth);
					return;
				}
				base.RemoveController(global::SourceGrid.Cells.Controllers.Resizable.ResizeWidth);
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06002B64 RID: 11108 RVA: 0x00092118 File Offset: 0x00090318
		// (set) Token: 0x06002B65 RID: 11109 RVA: 0x00092134 File Offset: 0x00090334
		public bool AutomaticSortEnabled
		{
			get
			{
				return base.FindController(typeof(global::SourceGrid.Cells.Controllers.SortableHeader)) == global::SourceGrid.Cells.Controllers.SortableHeader.Default;
			}
			set
			{
				if (value == this.AutomaticSortEnabled)
				{
					return;
				}
				if (value)
				{
					base.AddController(global::SourceGrid.Cells.Controllers.SortableHeader.Default);
					return;
				}
				base.RemoveController(global::SourceGrid.Cells.Controllers.SortableHeader.Default);
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06002B66 RID: 11110 RVA: 0x00092160 File Offset: 0x00090360
		private global::SourceGrid.Cells.Models.SortableHeader SortableHeaderModel
		{
			get
			{
				return (global::SourceGrid.Cells.Models.SortableHeader)base.Model.FindModel(typeof(global::SourceGrid.Cells.Models.SortableHeader));
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x06002B67 RID: 11111 RVA: 0x0009217C File Offset: 0x0009037C
		// (set) Token: 0x06002B68 RID: 11112 RVA: 0x0009218C File Offset: 0x0009038C
		public global::SourceGrid.Cells.Models.SortStatus SortStatus
		{
			get
			{
				return this.SortableHeaderModel.SortStatus;
			}
			set
			{
				this.SortableHeaderModel.SortStatus = value;
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x06002B69 RID: 11113 RVA: 0x0009219C File Offset: 0x0009039C
		// (set) Token: 0x06002B6A RID: 11114 RVA: 0x000921AC File Offset: 0x000903AC
		public global::System.Collections.IComparer SortComparer
		{
			get
			{
				return this.SortStatus.Comparer;
			}
			set
			{
				this.SortStatus = new global::SourceGrid.Cells.Models.SortStatus(this.SortStatus.Style, value);
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x06002B6B RID: 11115 RVA: 0x000921C8 File Offset: 0x000903C8
		// (set) Token: 0x06002B6C RID: 11116 RVA: 0x000921D8 File Offset: 0x000903D8
		public global::DevAge.Drawing.HeaderSortStyle SortStyle
		{
			get
			{
				return this.SortStatus.Style;
			}
			set
			{
				this.SortStatus = new global::SourceGrid.Cells.Models.SortStatus(value, this.SortStatus.Comparer);
			}
		}

		// Token: 0x06002B6D RID: 11117 RVA: 0x000921F4 File Offset: 0x000903F4
		public void Sort(bool ascending)
		{
			global::SourceGrid.Cells.Controllers.SortableHeader sortableHeader = (global::SourceGrid.Cells.Controllers.SortableHeader)base.FindController(typeof(global::SourceGrid.Cells.Controllers.SortableHeader));
			if (sortableHeader == null)
			{
				throw new global::SourceGrid.SourceGridException("No SortableHeader controller found");
			}
			sortableHeader.SortColumn(new global::SourceGrid.CellContext(base.Grid, base.Range.Start, this), ascending, this.SortComparer);
		}
	}
}
