using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000034 RID: 52
	public class CellCopyPolicy
	{
		// Token: 0x060001EC RID: 492 RVA: 0x00008FC4 File Offset: 0x000071C4
		public CellCopyPolicy()
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00009030 File Offset: 0x00007230
		public CellCopyPolicy(global::NPOI.SS.UserModel.CellCopyPolicy other)
		{
			this.copyCellValue = other.IsCopyCellValue;
			this.copyCellStyle = other.IsCopyCellStyle;
			this.copyCellFormula = other.IsCopyCellFormula;
			this.copyHyperlink = other.IsCopyHyperlink;
			this.mergeHyperlink = other.IsMergeHyperlink;
			this.copyRowHeight = other.IsCopyRowHeight;
			this.condenseRows = other.IsCondenseRows;
			this.copyMergedRegions = other.IsCopyMergedRegions;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x000090FC File Offset: 0x000072FC
		private CellCopyPolicy(global::NPOI.SS.UserModel.CellCopyPolicy.Builder builder)
		{
			this.copyCellValue = builder.copyCellValue;
			this.copyCellStyle = builder.copyCellStyle;
			this.copyCellFormula = builder.copyCellFormula;
			this.copyHyperlink = builder.copyHyperlink;
			this.mergeHyperlink = builder.mergeHyperlink;
			this.copyRowHeight = builder.copyRowHeight;
			this.condenseRows = builder.condenseRows;
			this.copyMergedRegions = builder.copyMergedRegions;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x000091C8 File Offset: 0x000073C8
		public global::NPOI.SS.UserModel.CellCopyPolicy.Builder CreateBuilder()
		{
			return new global::NPOI.SS.UserModel.CellCopyPolicy.Builder().CellValue(this.copyCellValue).CellStyle(this.copyCellStyle).CellFormula(this.copyCellFormula).CopyHyperlink(this.copyHyperlink).MergeHyperlink(this.mergeHyperlink).RowHeight(this.copyRowHeight).CondenseRows(this.condenseRows).MergedRegions(this.copyMergedRegions);
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x00009232 File Offset: 0x00007432
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x0000923A File Offset: 0x0000743A
		public bool IsCopyCellValue
		{
			get
			{
				return this.copyCellValue;
			}
			set
			{
				this.copyCellValue = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00009243 File Offset: 0x00007443
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x0000924B File Offset: 0x0000744B
		public bool IsCopyCellStyle
		{
			get
			{
				return this.copyCellStyle;
			}
			set
			{
				this.copyCellStyle = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00009254 File Offset: 0x00007454
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x0000925C File Offset: 0x0000745C
		public bool IsCopyCellFormula
		{
			get
			{
				return this.copyCellFormula;
			}
			set
			{
				this.copyCellFormula = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x00009265 File Offset: 0x00007465
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x0000926D File Offset: 0x0000746D
		public bool IsCopyHyperlink
		{
			get
			{
				return this.copyHyperlink;
			}
			set
			{
				this.copyHyperlink = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00009276 File Offset: 0x00007476
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x0000927E File Offset: 0x0000747E
		public bool IsMergeHyperlink
		{
			get
			{
				return this.mergeHyperlink;
			}
			set
			{
				this.mergeHyperlink = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00009287 File Offset: 0x00007487
		// (set) Token: 0x060001FB RID: 507 RVA: 0x0000928F File Offset: 0x0000748F
		public bool IsCopyRowHeight
		{
			get
			{
				return this.copyRowHeight;
			}
			set
			{
				this.copyRowHeight = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00009298 File Offset: 0x00007498
		// (set) Token: 0x060001FD RID: 509 RVA: 0x000092A0 File Offset: 0x000074A0
		public bool IsCondenseRows
		{
			get
			{
				return this.condenseRows;
			}
			set
			{
				this.condenseRows = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001FE RID: 510 RVA: 0x000092A9 File Offset: 0x000074A9
		// (set) Token: 0x060001FF RID: 511 RVA: 0x000092B1 File Offset: 0x000074B1
		public bool IsCopyMergedRegions
		{
			get
			{
				return this.copyMergedRegions;
			}
			set
			{
				this.copyMergedRegions = value;
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000092BA File Offset: 0x000074BA
		public global::NPOI.SS.UserModel.CellCopyPolicy Clone()
		{
			return (global::NPOI.SS.UserModel.CellCopyPolicy)base.MemberwiseClone();
		}

		// Token: 0x040000B4 RID: 180
		public static bool DEFAULT_COPY_CELL_VALUE_POLICY = true;

		// Token: 0x040000B5 RID: 181
		public static bool DEFAULT_COPY_CELL_STYLE_POLICY = true;

		// Token: 0x040000B6 RID: 182
		public static bool DEFAULT_COPY_CELL_FORMULA_POLICY = true;

		// Token: 0x040000B7 RID: 183
		public static bool DEFAULT_COPY_HYPERLINK_POLICY = true;

		// Token: 0x040000B8 RID: 184
		public static bool DEFAULT_MERGE_HYPERLINK_POLICY = false;

		// Token: 0x040000B9 RID: 185
		public static bool DEFAULT_COPY_ROW_HEIGHT_POLICY = true;

		// Token: 0x040000BA RID: 186
		public static bool DEFAULT_CONDENSE_ROWS_POLICY = false;

		// Token: 0x040000BB RID: 187
		public static bool DEFAULT_COPY_MERGED_REGIONS_POLICY = true;

		// Token: 0x040000BC RID: 188
		private bool copyCellValue = global::NPOI.SS.UserModel.CellCopyPolicy.DEFAULT_COPY_CELL_VALUE_POLICY;

		// Token: 0x040000BD RID: 189
		private bool copyCellStyle = global::NPOI.SS.UserModel.CellCopyPolicy.DEFAULT_COPY_CELL_STYLE_POLICY;

		// Token: 0x040000BE RID: 190
		private bool copyCellFormula = global::NPOI.SS.UserModel.CellCopyPolicy.DEFAULT_COPY_CELL_FORMULA_POLICY;

		// Token: 0x040000BF RID: 191
		private bool copyHyperlink = global::NPOI.SS.UserModel.CellCopyPolicy.DEFAULT_COPY_HYPERLINK_POLICY;

		// Token: 0x040000C0 RID: 192
		private bool mergeHyperlink = global::NPOI.SS.UserModel.CellCopyPolicy.DEFAULT_MERGE_HYPERLINK_POLICY;

		// Token: 0x040000C1 RID: 193
		private bool copyRowHeight = global::NPOI.SS.UserModel.CellCopyPolicy.DEFAULT_COPY_ROW_HEIGHT_POLICY;

		// Token: 0x040000C2 RID: 194
		private bool condenseRows = global::NPOI.SS.UserModel.CellCopyPolicy.DEFAULT_CONDENSE_ROWS_POLICY;

		// Token: 0x040000C3 RID: 195
		private bool copyMergedRegions = global::NPOI.SS.UserModel.CellCopyPolicy.DEFAULT_COPY_MERGED_REGIONS_POLICY;

		// Token: 0x0200055A RID: 1370
		public class Builder
		{
			// Token: 0x0600338C RID: 13196 RVA: 0x000A12BB File Offset: 0x0009F4BB
			public global::NPOI.SS.UserModel.CellCopyPolicy.Builder CellValue(bool copyCellValue)
			{
				this.copyCellValue = copyCellValue;
				return this;
			}

			// Token: 0x0600338D RID: 13197 RVA: 0x000A12C5 File Offset: 0x0009F4C5
			public global::NPOI.SS.UserModel.CellCopyPolicy.Builder CellStyle(bool copyCellStyle)
			{
				this.copyCellStyle = copyCellStyle;
				return this;
			}

			// Token: 0x0600338E RID: 13198 RVA: 0x000A12CF File Offset: 0x0009F4CF
			public global::NPOI.SS.UserModel.CellCopyPolicy.Builder CellFormula(bool copyCellFormula)
			{
				this.copyCellFormula = copyCellFormula;
				return this;
			}

			// Token: 0x0600338F RID: 13199 RVA: 0x000A12D9 File Offset: 0x0009F4D9
			public global::NPOI.SS.UserModel.CellCopyPolicy.Builder CopyHyperlink(bool copyHyperlink)
			{
				this.copyHyperlink = copyHyperlink;
				return this;
			}

			// Token: 0x06003390 RID: 13200 RVA: 0x000A12E3 File Offset: 0x0009F4E3
			public global::NPOI.SS.UserModel.CellCopyPolicy.Builder MergeHyperlink(bool mergeHyperlink)
			{
				this.mergeHyperlink = mergeHyperlink;
				return this;
			}

			// Token: 0x06003391 RID: 13201 RVA: 0x000A12ED File Offset: 0x0009F4ED
			public global::NPOI.SS.UserModel.CellCopyPolicy.Builder RowHeight(bool copyRowHeight)
			{
				this.copyRowHeight = copyRowHeight;
				return this;
			}

			// Token: 0x06003392 RID: 13202 RVA: 0x000A12F7 File Offset: 0x0009F4F7
			public global::NPOI.SS.UserModel.CellCopyPolicy.Builder CondenseRows(bool condenseRows)
			{
				this.condenseRows = condenseRows;
				return this;
			}

			// Token: 0x06003393 RID: 13203 RVA: 0x000A1301 File Offset: 0x0009F501
			public global::NPOI.SS.UserModel.CellCopyPolicy.Builder MergedRegions(bool copyMergedRegions)
			{
				this.copyMergedRegions = copyMergedRegions;
				return this;
			}

			// Token: 0x06003394 RID: 13204 RVA: 0x000A130B File Offset: 0x0009F50B
			public global::NPOI.SS.UserModel.CellCopyPolicy Build()
			{
				return new global::NPOI.SS.UserModel.CellCopyPolicy(this);
			}

			// Token: 0x04001877 RID: 6263
			internal bool copyCellValue = global::NPOI.SS.UserModel.CellCopyPolicy.DEFAULT_COPY_CELL_VALUE_POLICY;

			// Token: 0x04001878 RID: 6264
			internal bool copyCellStyle = global::NPOI.SS.UserModel.CellCopyPolicy.DEFAULT_COPY_CELL_STYLE_POLICY;

			// Token: 0x04001879 RID: 6265
			internal bool copyCellFormula = global::NPOI.SS.UserModel.CellCopyPolicy.DEFAULT_COPY_CELL_FORMULA_POLICY;

			// Token: 0x0400187A RID: 6266
			internal bool copyHyperlink = global::NPOI.SS.UserModel.CellCopyPolicy.DEFAULT_COPY_HYPERLINK_POLICY;

			// Token: 0x0400187B RID: 6267
			internal bool mergeHyperlink = global::NPOI.SS.UserModel.CellCopyPolicy.DEFAULT_MERGE_HYPERLINK_POLICY;

			// Token: 0x0400187C RID: 6268
			internal bool copyRowHeight = global::NPOI.SS.UserModel.CellCopyPolicy.DEFAULT_COPY_ROW_HEIGHT_POLICY;

			// Token: 0x0400187D RID: 6269
			internal bool condenseRows = global::NPOI.SS.UserModel.CellCopyPolicy.DEFAULT_CONDENSE_ROWS_POLICY;

			// Token: 0x0400187E RID: 6270
			internal bool copyMergedRegions = global::NPOI.SS.UserModel.CellCopyPolicy.DEFAULT_COPY_MERGED_REGIONS_POLICY;
		}
	}
}
