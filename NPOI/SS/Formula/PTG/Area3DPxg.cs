using System;
using System.Text;
using NPOI.SS.Util;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x020000EC RID: 236
	public class Area3DPxg : global::NPOI.SS.Formula.PTG.AreaPtgBase, global::NPOI.SS.Formula.PTG.Pxg3D, global::NPOI.SS.Formula.PTG.Pxg
	{
		// Token: 0x060007E5 RID: 2021 RVA: 0x00015F4E File Offset: 0x0001414E
		public Area3DPxg(int externalWorkbookNumber, global::NPOI.SS.Formula.SheetIdentifier sheetName, string arearef) : this(externalWorkbookNumber, sheetName, new global::NPOI.SS.Util.AreaReference(arearef))
		{
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00015F60 File Offset: 0x00014160
		public Area3DPxg(int externalWorkbookNumber, global::NPOI.SS.Formula.SheetIdentifier sheetName, global::NPOI.SS.Util.AreaReference arearef) : base(arearef)
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

		// Token: 0x060007E7 RID: 2023 RVA: 0x00015FB9 File Offset: 0x000141B9
		public Area3DPxg(global::NPOI.SS.Formula.SheetIdentifier sheetName, string arearef) : this(sheetName, new global::NPOI.SS.Util.AreaReference(arearef))
		{
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00015FC8 File Offset: 0x000141C8
		public Area3DPxg(global::NPOI.SS.Formula.SheetIdentifier sheetName, global::NPOI.SS.Util.AreaReference arearef) : this(-1, sheetName, arearef)
		{
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00015FD4 File Offset: 0x000141D4
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
			stringBuilder.Append("sheet=").Append(this.SheetName);
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

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x000160AA File Offset: 0x000142AA
		public int ExternalWorkbookNumber
		{
			get
			{
				return this.externalWorkbookNumber;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x000160B2 File Offset: 0x000142B2
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x000160BA File Offset: 0x000142BA
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

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x000160C3 File Offset: 0x000142C3
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x000160CB File Offset: 0x000142CB
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

		// Token: 0x060007EF RID: 2031 RVA: 0x000160D4 File Offset: 0x000142D4
		public string Format2DRefAsString()
		{
			return base.FormatReferenceAsString();
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x000160DC File Offset: 0x000142DC
		public override string ToFormulaString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (this.externalWorkbookNumber >= 0)
			{
				stringBuilder.Append('[');
				stringBuilder.Append(this.externalWorkbookNumber);
				stringBuilder.Append(']');
			}
			global::NPOI.SS.Formula.SheetNameFormatter.AppendFormat(stringBuilder, this.firstSheetName);
			if (this.lastSheetName != null)
			{
				stringBuilder.Append(':');
				global::NPOI.SS.Formula.SheetNameFormatter.AppendFormat(stringBuilder, this.lastSheetName);
			}
			stringBuilder.Append('!');
			stringBuilder.Append(base.FormatReferenceAsString());
			return stringBuilder.ToString();
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x00008875 File Offset: 0x00006A75
		public override int Size
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0001615C File Offset: 0x0001435C
		public override void Write(global::NPOI.Util.ILittleEndianOutput out1)
		{
			throw new global::System.InvalidOperationException("XSSF-only Ptg, should not be serialised");
		}

		// Token: 0x04000433 RID: 1075
		private int externalWorkbookNumber = -1;

		// Token: 0x04000434 RID: 1076
		private string firstSheetName;

		// Token: 0x04000435 RID: 1077
		private string lastSheetName;
	}
}
