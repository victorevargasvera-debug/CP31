using System;
using DevAge.Drawing;
using DevAge.Drawing.VisualElements;

namespace SourceGrid.Cells.Views
{
	// Token: 0x02000392 RID: 914
	[global::System.Serializable]
	internal class Header : global::SourceGrid.Cells.Views.Cell
	{
		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x06002AFC RID: 11004 RVA: 0x00091278 File Offset: 0x0008F478
		// (set) Token: 0x06002AFD RID: 11005 RVA: 0x00091284 File Offset: 0x0008F484
		public new static global::DevAge.Drawing.RectangleBorder DefaultBorder
		{
			get
			{
				global::SourceGrid.Cells.Views.Header.Initialize();
				return global::SourceGrid.Cells.Views.Header.t_DefaultBorder;
			}
			set
			{
				global::SourceGrid.Cells.Views.Header.Initialize();
				global::SourceGrid.Cells.Views.Header.t_DefaultBorder = value;
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x06002AFE RID: 11006 RVA: 0x00091294 File Offset: 0x0008F494
		public new static global::SourceGrid.Cells.Views.Header Default
		{
			get
			{
				global::SourceGrid.Cells.Views.Header.Initialize();
				return global::SourceGrid.Cells.Views.Header.t_DefaultHeader;
			}
		}

		// Token: 0x06002AFF RID: 11007 RVA: 0x000912A0 File Offset: 0x0008F4A0
		public new static void Initialize()
		{
			if (global::SourceGrid.Cells.Views.Header.t_Initialized)
			{
				return;
			}
			global::SourceGrid.Cells.Views.Header.t_DefaultBorder = global::DevAge.Drawing.RectangleBorder.NoBorder;
			global::SourceGrid.Cells.Views.Header.t_Initialized = true;
			global::SourceGrid.Cells.Views.Header.t_DefaultHeader = new global::SourceGrid.Cells.Views.Header();
		}

		// Token: 0x06002B00 RID: 11008 RVA: 0x000912C8 File Offset: 0x0008F4C8
		static Header()
		{
			global::SourceGrid.Cells.Views.Header.Initialize();
		}

		// Token: 0x06002B01 RID: 11009 RVA: 0x000912D0 File Offset: 0x0008F4D0
		public Header()
		{
			this.Background = new global::DevAge.Drawing.VisualElements.HeaderThemed();
			base.Border = global::SourceGrid.Cells.Views.Header.DefaultBorder;
		}

		// Token: 0x06002B02 RID: 11010 RVA: 0x000912F4 File Offset: 0x0008F4F4
		public Header(global::SourceGrid.Cells.Views.Header p_Source) : base(p_Source)
		{
			this.Background = (global::DevAge.Drawing.VisualElements.IHeader)p_Source.Background.Clone();
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x00091324 File Offset: 0x0008F524
		public override object Clone()
		{
			return new global::SourceGrid.Cells.Views.Header(this);
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06002B04 RID: 11012 RVA: 0x0009132C File Offset: 0x0008F52C
		// (set) Token: 0x06002B05 RID: 11013 RVA: 0x0009133C File Offset: 0x0008F53C
		public new global::DevAge.Drawing.VisualElements.IHeader Background
		{
			get
			{
				return (global::DevAge.Drawing.VisualElements.IHeader)base.Background;
			}
			set
			{
				base.Background = value;
			}
		}

		// Token: 0x06002B06 RID: 11014 RVA: 0x00091348 File Offset: 0x0008F548
		protected override void PrepareView(global::SourceGrid.CellContext context)
		{
			base.PrepareView(context);
			if (context.CellRange.Contains(context.Grid.MouseDownPosition))
			{
				this.Background.Style = global::DevAge.Drawing.ControlDrawStyle.Pressed;
				return;
			}
			if (context.CellRange.Contains(context.Grid.MouseCellPosition))
			{
				this.Background.Style = global::DevAge.Drawing.ControlDrawStyle.Hot;
				return;
			}
			this.Background.Style = global::DevAge.Drawing.ControlDrawStyle.Normal;
		}

		// Token: 0x04000E7C RID: 3708
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Views.Header t_DefaultHeader;

		// Token: 0x04000E7D RID: 3709
		[global::System.ThreadStatic]
		private static global::DevAge.Drawing.RectangleBorder t_DefaultBorder;

		// Token: 0x04000E7E RID: 3710
		[global::System.ThreadStatic]
		private static bool t_Initialized;
	}
}
