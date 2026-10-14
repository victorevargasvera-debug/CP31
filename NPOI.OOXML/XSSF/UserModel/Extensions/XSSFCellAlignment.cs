using System;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.UserModel.Extensions
{
	// Token: 0x020000B1 RID: 177
	public class XSSFCellAlignment
	{
		// Token: 0x06000B31 RID: 2865 RVA: 0x0002A5F8 File Offset: 0x000287F8
		public XSSFCellAlignment(global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment cellAlignment)
		{
			this.cellAlignement = cellAlignment;
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x0002A607 File Offset: 0x00028807
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x0002A614 File Offset: 0x00028814
		public global::NPOI.SS.UserModel.VerticalAlignment Vertical
		{
			get
			{
				return (global::NPOI.SS.UserModel.VerticalAlignment)this.cellAlignement.vertical;
			}
			set
			{
				this.cellAlignement.vertical = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_VerticalAlignment)value;
				this.cellAlignement.verticalSpecified = true;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x0002A62E File Offset: 0x0002882E
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x0002A63B File Offset: 0x0002883B
		public global::NPOI.SS.UserModel.HorizontalAlignment Horizontal
		{
			get
			{
				return (global::NPOI.SS.UserModel.HorizontalAlignment)this.cellAlignement.horizontal;
			}
			set
			{
				this.cellAlignement.horizontal = (global::NPOI.OpenXmlFormats.Spreadsheet.ST_HorizontalAlignment)value;
				this.cellAlignement.horizontalSpecified = true;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000B36 RID: 2870 RVA: 0x0002A655 File Offset: 0x00028855
		// (set) Token: 0x06000B37 RID: 2871 RVA: 0x0002A662 File Offset: 0x00028862
		public long Indent
		{
			get
			{
				return this.cellAlignement.indent;
			}
			set
			{
				this.cellAlignement.indent = value;
				this.cellAlignement.indentSpecified = true;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0002A67C File Offset: 0x0002887C
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x0002A68C File Offset: 0x0002888C
		public long TextRotation
		{
			get
			{
				return this.cellAlignement.textRotation;
			}
			set
			{
				long num = value;
				if (num < 0L && num >= -90L)
				{
					num = 90L + -1L * num;
				}
				this.cellAlignement.textRotation = num;
				this.cellAlignement.textRotationSpecified = true;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000B3A RID: 2874 RVA: 0x0002A6C7 File Offset: 0x000288C7
		// (set) Token: 0x06000B3B RID: 2875 RVA: 0x0002A6D4 File Offset: 0x000288D4
		public bool WrapText
		{
			get
			{
				return this.cellAlignement.wrapText;
			}
			set
			{
				this.cellAlignement.wrapText = value;
				this.cellAlignement.wrapTextSpecified = true;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x0002A6EE File Offset: 0x000288EE
		// (set) Token: 0x06000B3D RID: 2877 RVA: 0x0002A6FB File Offset: 0x000288FB
		public bool ShrinkToFit
		{
			get
			{
				return this.cellAlignement.shrinkToFit;
			}
			set
			{
				this.cellAlignement.shrinkToFit = value;
				this.cellAlignement.shrinkToFitSpecified = value;
			}
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0002A715 File Offset: 0x00028915
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment GetCTCellAlignment()
		{
			return this.cellAlignement;
		}

		// Token: 0x040003B0 RID: 944
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_CellAlignment cellAlignement;
	}
}
