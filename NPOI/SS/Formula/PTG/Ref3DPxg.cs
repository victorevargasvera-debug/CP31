using System;
using System.Text;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x020000F1 RID: 241
	public class Ref3DPxg : global::NPOI.SS.Formula.PTG.RefPtgBase, global::NPOI.SS.Formula.PTG.Pxg3D, global::NPOI.SS.Formula.PTG.Pxg
	{
		// Token: 0x0600080F RID: 2063 RVA: 0x0001645C File Offset: 0x0001465C
		public Ref3DPxg(int externalWorkbookNumber, global::NPOI.SS.Formula.SheetIdentifier sheetName, string cellref) : this(externalWorkbookNumber, sheetName, new global::NPOI.SS.Util.CellReference(cellref))
		{
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x0001646C File Offset: 0x0001466C
		public Ref3DPxg(int externalWorkbookNumber, global::NPOI.SS.Formula.SheetIdentifier sheetName, global::NPOI.SS.Util.CellReference c) : base(c)
		{
			this.externalWorkbookNumber = externalWorkbookNumber;
			this.firstSheetName = sheetName.SheetId.Name;
			if (sheetName is global::NPOI.SS.Formula.SheetRangeIdentifier)
			{
				this.lastSheetName = ((global::NPOI.SS.Formula.SheetRangeIdentifier)sheetName).LastSheetIdentifier.Name;
				return;
			}
			this.lastSheetName = null;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x000164C5 File Offset: 0x000146C5
		public Ref3DPxg(global::NPOI.SS.Formula.SheetIdentifier sheetName, string cellref) : this(sheetName, new global::NPOI.SS.Util.CellReference(cellref))
		{
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x000164D4 File Offset: 0x000146D4
		public Ref3DPxg(global::NPOI.SS.Formula.SheetIdentifier sheetName, global::NPOI.SS.Util.CellReference c) : this(-1, sheetName, c)
		{
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x000164E0 File Offset: 0x000146E0
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(base.GetType().Name);
			stringBuilder.Append(" [");
			if (this.externalWorkbookNumber >= 0)
			{
				stringBuilder.Append(" [");
				stringBuilder.Append("workbook=").Append(this.ExternalWorkbookNumber);
				stringBuilder.Append("] ");
			}
			stringBuilder.Append("sheet=").Append(this.firstSheetName);
			if (this.lastSheetName != null)
			{
				stringBuilder.Append(" : ");
				stringBuilder.Append("sheet=").Append(this.lastSheetName);
			}
			stringBuilder.Append(" ! ");
			stringBuilder.Append(base.FormatReferenceAsString());
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x000165B6 File Offset: 0x000147B6
		public int ExternalWorkbookNumber
		{
			get
			{
				return this.externalWorkbookNumber;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x000165BE File Offset: 0x000147BE
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x000165C6 File Offset: 0x000147C6
		public string SheetName
		{
			get
			{
				return this.firstSheetName;
			}
			set
			{
				this.firstSheetName = value;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x000165CF File Offset: 0x000147CF
		// (set) Token: 0x06000818 RID: 2072 RVA: 0x000165D7 File Offset: 0x000147D7
		public string LastSheetName
		{
			get
			{
				return this.lastSheetName;
			}
			set
			{
				this.lastSheetName = value;
			}
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x000165E0 File Offset: 0x000147E0
		public string Format2DRefAsString()
		{
			return base.FormatReferenceAsString();
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x000165E8 File Offset: 0x000147E8
		public override string ToFormulaString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (this.externalWorkbookNumber >= 0)
			{
				stringBuilder.Append('[');
				stringBuilder.Append(this.externalWorkbookNumber);
				stringBuilder.Append(']');
			}
			if (this.firstSheetName != null)
			{
				global::NPOI.SS.Formula.SheetNameFormatter.AppendFormat(stringBuilder, this.firstSheetName);
			}
			if (this.lastSheetName != null)
			{
				stringBuilder.Append(':');
				global::NPOI.SS.Formula.SheetNameFormatter.AppendFormat(stringBuilder, this.lastSheetName);
			}
			stringBuilder.Append('!');
			stringBuilder.Append(base.FormatReferenceAsString());
			return stringBuilder.ToString();
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x00008875 File Offset: 0x00006A75
		public override int Size
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x0001615C File Offset: 0x0001435C
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			throw new global::System.InvalidOperationException("XSSF-only Ptg, should not be serialised");
		}

		// Token: 0x0400043B RID: 1083
		private int externalWorkbookNumber = -1;

		// Token: 0x0400043C RID: 1084
		private string firstSheetName;

		// Token: 0x0400043D RID: 1085
		private string lastSheetName;
	}
}
