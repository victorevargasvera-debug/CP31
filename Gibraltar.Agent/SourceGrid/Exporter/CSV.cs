using System;
using System.Globalization;
using System.IO;
using SourceGrid.Cells;

namespace SourceGrid.Exporter
{
	// Token: 0x020003E3 RID: 995
	internal class CSV
	{
		// Token: 0x06002C6D RID: 11373 RVA: 0x000953E8 File Offset: 0x000935E8
		public CSV()
		{
			this.mFieldSeparator = global::System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator;
			this.mLineSeparator = global::System.Environment.NewLine;
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06002C6E RID: 11374 RVA: 0x00095410 File Offset: 0x00093610
		// (set) Token: 0x06002C6F RID: 11375 RVA: 0x00095418 File Offset: 0x00093618
		public string FieldSeparator
		{
			get
			{
				return this.mFieldSeparator;
			}
			set
			{
				this.mFieldSeparator = value;
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06002C70 RID: 11376 RVA: 0x00095424 File Offset: 0x00093624
		// (set) Token: 0x06002C71 RID: 11377 RVA: 0x0009542C File Offset: 0x0009362C
		public string LineSeparator
		{
			get
			{
				return this.mLineSeparator;
			}
			set
			{
				this.mLineSeparator = value;
			}
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x00095438 File Offset: 0x00093638
		public virtual void Export(global::SourceGrid.GridVirtual grid, global::System.IO.TextWriter stream)
		{
			for (int i = 0; i < grid.Rows.Count; i++)
			{
				for (int j = 0; j < grid.Columns.Count; j++)
				{
					if (j > 0)
					{
						stream.Write(this.mFieldSeparator);
					}
					global::SourceGrid.Cells.ICellVirtual cell = grid.GetCell(i, j);
					global::SourceGrid.Position pPosition = new global::SourceGrid.Position(i, j);
					global::SourceGrid.CellContext context = new global::SourceGrid.CellContext(grid, pPosition, cell);
					this.ExportCSVCell(context, stream);
				}
				stream.Write(this.mLineSeparator);
			}
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x000954C0 File Offset: 0x000936C0
		protected virtual void ExportCSVCell(global::SourceGrid.CellContext context, global::System.IO.TextWriter stream)
		{
			if (context.Cell != null)
			{
				string text = context.DisplayText;
				if (text == null)
				{
					text = string.Empty;
				}
				text = text.Replace("\r\n", " ");
				text = text.Replace("\n", " ");
				text = text.Replace("\r", " ");
				stream.Write(text);
				return;
			}
			stream.Write("");
		}

		// Token: 0x04000F18 RID: 3864
		private string mFieldSeparator;

		// Token: 0x04000F19 RID: 3865
		private string mLineSeparator;
	}
}
