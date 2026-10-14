using System;
using DevAge.Drawing.VisualElements;

namespace SourceGrid.Cells.Views
{
	// Token: 0x020003E6 RID: 998
	[global::System.Serializable]
	internal class RowHeader : global::SourceGrid.Cells.Views.Header
	{
		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06002C90 RID: 11408 RVA: 0x00095F20 File Offset: 0x00094120
		public new static global::SourceGrid.Cells.Views.RowHeader Default
		{
			get
			{
				if (global::SourceGrid.Cells.Views.RowHeader.t_Default == null)
				{
					global::SourceGrid.Cells.Views.RowHeader.t_Default = new global::SourceGrid.Cells.Views.RowHeader();
				}
				return global::SourceGrid.Cells.Views.RowHeader.t_Default;
			}
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x00095F3C File Offset: 0x0009413C
		public RowHeader()
		{
			this.Background = new global::DevAge.Drawing.VisualElements.RowHeaderThemed();
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x00095F50 File Offset: 0x00094150
		public RowHeader(global::SourceGrid.Cells.Views.RowHeader p_Source) : base(p_Source)
		{
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x00095F5C File Offset: 0x0009415C
		public override object Clone()
		{
			return new global::SourceGrid.Cells.Views.RowHeader(this);
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x06002C94 RID: 11412 RVA: 0x00095F64 File Offset: 0x00094164
		// (set) Token: 0x06002C95 RID: 11413 RVA: 0x00095F74 File Offset: 0x00094174
		public new global::DevAge.Drawing.VisualElements.IRowHeader Background
		{
			get
			{
				return (global::DevAge.Drawing.VisualElements.IRowHeader)base.Background;
			}
			set
			{
				base.Background = value;
			}
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x00095F80 File Offset: 0x00094180
		protected override void PrepareView(global::SourceGrid.CellContext context)
		{
			base.PrepareView(context);
		}

		// Token: 0x04000F25 RID: 3877
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Views.RowHeader t_Default;
	}
}
